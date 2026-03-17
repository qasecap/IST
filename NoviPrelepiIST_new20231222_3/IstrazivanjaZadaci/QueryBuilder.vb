Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text

Public Enum GroupByExtension
    None = 0
    Cube = 1
    Rollup = 2
    All = 3
End Enum

Public Class QueryBuilder

    ' ** Fields
    Private _distinct As Boolean

    Private _gbExtension As GroupByExtension
    Private _groupBy As Boolean
    Private _missingJoins As Boolean
    Private _queryFields As QueryFieldCollection
    Private _schema As OleDbSchema
    Private _istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Private _sql As String = Nothing
    Private _sqlpom As String = Nothing
    Private _sqlIsDirty As Boolean
    Private _sqlPomIsDirty As Boolean
    Public tableQBCount As Integer
    Private _top As Integer

    ' ** Ctor
    Friend Sub New(ByVal schema As OleDbSchema, ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable)
        Me._schema = schema
        Me._schema.istTabele = istTabele
        Me._istTabele = istTabele
        Me._queryFields = New QueryFieldCollection
        AddHandler Me._queryFields.ListChanged, New ListChangedEventHandler(AddressOf Me._queryFields_ListChanged)
    End Sub

    ' ** Event Handlers
    Private Sub _queryFields_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
        Me._sqlIsDirty = True
        Me._sqlPomIsDirty = True
    End Sub

    ' ** Implementation
    Dim e As Integer = 1

    Private Function BuildSelectClause() As String
        BuildSelectClause = Nothing
        e = e + 1
        If e > 1000 Then
            Exit Function
        End If
        Dim sb As New StringBuilder
        Dim field As QueryField
        Dim its As String = ""
        Dim ffa As String = ""

        Dim k As Integer = 0
        Dim kk As Integer = 100

        For Each field In Me.QueryFields

            If field.Output Then
                Dim tt As String = field.Table
                Dim fa As String = field.Alias
                If (sb.Length > 0) Then sb.Append("," & vbNewLine + vbTab)
                Dim item As String = field.GetFullName(Me.GroupBy)
                Dim itemskr As String = field.Column.ToString
                If its.Trim.IndexOf(itemskr + "$") < 0 Then
                    its = its + itemskr + "$"
                    If Not String.IsNullOrEmpty(field.Alias) Then
                        ffa = fa
                    Else
                        ffa = ""
                        If Me.GroupBy = True Then
                            kk = kk + 1
                            ffa = itemskr + "_" + tt.Trim + "_" + Str(kk).Trim
                        End If
                    End If
                Else
                    If itemskr.Trim <> "*" Then
                        k = k + 1
                        ffa = itemskr + "_" + tt.Trim + "_" + Str(k).Trim
                    End If
                End If
                sb.Append(item)
                If ffa <> "" Then sb.AppendFormat(" AS {0}", OleDbSchema.BracketName(fa))
            End If

            If ffa <> "" Then field.Alias = ffa

        Next

        Return sb.ToString

    End Function

    Private Function BuildFromClause() As String
        BuildFromClause = ""
        Dim k As Integer = 0

        Dim tables As New List(Of DataTable)
        Dim field As QueryField

        Dim pt As String = "" : Dim pa As String = ""
        For Each field In Me.QueryFields

            Dim table As DataTable = Nothing
            Dim tableName As String = ""
            If Not field.Table Is Nothing Then
                tableName = field.Table
                table = Me._schema.Tables.Item(tableName)
            End If

            Dim ta As String = ""
            If Not field.TableAlias Is Nothing Then ta = field.TableAlias
            If pt.IndexOf(tableName + "$") < 0 Then pt = pt + tableName + "$"
            If pa.IndexOf(ta + "$") < 0 Then pa = pa + ta + "$"
            Dim ptt() As String = pt.Split("$")
            Dim paa() As String = pa.Split("$")

            If Not table Is Nothing AndAlso tables.Contains(table) = False Then
                k = k + 1
                tables.Add(table)
                Dim ind As Integer = Array.IndexOf(ptt, tableName)
                If ind < 0 OrElse paa(ind) = "" Then
                    field.TableAlias = "T" + Str(k).Trim
                Else
                    field.TableAlias = paa(ind)
                End If
            ElseIf Not table Is Nothing AndAlso tables.Contains(table) = True Then
                Dim ind As Integer = Array.IndexOf(ptt, tableName)
                field.TableAlias = paa(ind)
            End If
        Next

        Me.tableQBCount = tables.Count
        Dim qTables As New List(Of DataTable)
        Dim qJoins As New List(Of String)
        Dim sb As New StringBuilder
        k = 0
        Dim z As String = ""
        For Each dt As DataTable In tables
            If Not qTables.Contains(dt) Then
                k = k + 1
                If k > 1 Then z = ", "
                sb.AppendFormat(z + "{0}", OleDbSchema.GetFullTableName(dt) + " AS " + "T" + Str(k).Trim)
                qTables.Add(dt)
            End If
        Next

        Return sb.ToString
    End Function

    Private Function BuildWhereClause() As String
        Dim sb As New StringBuilder
        Dim field As QueryField
        For Each field In Me.QueryFields
            If (field.Filter.Length > 0) Then
                Dim item As String = field.GetFilterExpression
                If (item.Length > 0) Then
                    If (sb.Length > 0) Then
                        sb.Append(" AND" & vbNewLine + vbTab)
                    End If
                    sb.Append(item)
                End If
            End If
        Next
        Return sb.ToString
    End Function

    Private Function BuildGroupByClause() As String
        Dim sb As New StringBuilder
        If Me.GroupBy Then
            Dim field As QueryField
            For Each field In Me.QueryFields
                If (field.GroupBy = GroupingAggregate.GroupBy) Then
                    If (sb.Length > 0) Then
                        sb.Append("," & vbNewLine + vbTab)
                    End If
                    Dim item As String = field.GetFullName
                    sb.Append(item)
                End If
            Next
            Select Case Me.GroupByExtension
                Case GroupByExtension.Cube
                    sb.Append(" WITH CUBE")
                    Exit Select
                Case GroupByExtension.Rollup
                    sb.Append(" WITH ROLLUP")
                    Exit Select
                Case GroupByExtension.All
                    Return ("ALL " & sb.ToString)
            End Select
        End If
        Return sb.ToString
    End Function

    Private Function BuildOrderByClause() As String
        Dim sb As New StringBuilder
        Dim field As QueryField
        For Each field In Me.QueryFields
            If (field.Sort <> Sort.NoSort) Then
                If (sb.Length > 0) Then
                    sb.Append("," & vbNewLine + vbTab)
                End If
                Dim item As String = field.GetFullName(True)
                sb.Append(item)
                If (field.Sort = Sort.Descending) Then
                    sb.Append(" DESC")
                End If
            End If
        Next
        Return sb.ToString
    End Function

    Private Function BuildSqlStatement() As String

        If ((Me.QueryFields.Count = 0) OrElse (Me._schema Is Nothing)) Then
            Me.tableQBCount = 0
            Me._missingJoins = False
            Return String.Empty
        End If

        Dim sb As New StringBuilder
        sb.Append(" SELECT ")

        If Me.Distinct Then sb.Append("DISTINCT ")
        If (Me.Top > 0) Then sb.AppendFormat("TOP {0} ", Me.Top)

        sb.Append(vbNewLine + vbTab)

        e = 0
        Dim sselect As String = Me.BuildSelectClause
        If (sselect.Length > 0) Then sb.Append(sselect)
        Dim ffrom As String = Me.BuildFromClause
        If (ffrom.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " FROM" & vbNewLine + vbTab + "{0}", ffrom + "")
        If Me.GroupBy Then
            Dim groupBy As String = Me.BuildGroupByClause
            If (groupBy.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " GROUP BY" & vbNewLine + vbTab & "{0}", groupBy)
            Dim having As String = Me.BuildWhereClause
            If (having.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " HAVING" & vbNewLine + vbTab & "{0}", having)
        Else
            Dim where As String = Me.BuildWhereClause
            If (where.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " WHERE" & vbNewLine + vbTab & "{0}", where)
        End If
        Dim orderBy As String = Me.BuildOrderByClause
        If (orderBy.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " ORDER BY" & vbNewLine + vbTab & "{0}", orderBy)

        sb.Append(";"c)
        Return sb.ToString
    End Function

    Private Function BuildSqlStatementPom() As String
        If ((Me.QueryFields.Count = 0) OrElse (Me._schema Is Nothing)) Then
            Me.tableQBCount = 0
            Me._missingJoins = False
            Return String.Empty
        End If
        Dim sb As New StringBuilder
        sb.Append(" SELECT ")

        If Me.Distinct Then sb.Append("DISTINCT ")
        If (Me.Top > 0) Then sb.AppendFormat("TOP {0} ", Me.Top)

        sb.Append(vbNewLine + vbTab)
        e = 0
        Dim sselect As String = Me.BuildSelectClause
        If (sselect.Length > 0) Then sb.Append(sselect)
        Dim ffrom As String = Me.BuildFromClause
        sb.AppendFormat(ChrW(13) & ChrW(10) & " $FROM" & vbNewLine + vbTab + "{0}", ffrom + "$")
        If Me.GroupBy Then
            Dim groupBy As String = Me.BuildGroupByClause
            If (groupBy.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " GROUP BY" & vbNewLine + vbTab & "{0}", groupBy)
            Dim having As String = Me.BuildWhereClause
            If (having.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " HAVING" & vbNewLine + vbTab & "{0}", having)
        Else
            Dim where As String = Me.BuildWhereClause
            If (where.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " WHERE" & vbNewLine + vbTab & "{0}", where)
        End If
        Dim orderBy As String = Me.BuildOrderByClause
        If (orderBy.Length > 0) Then sb.AppendFormat(ChrW(13) & ChrW(10) & " ORDER BY" & vbNewLine + vbTab & "{0}", orderBy)

        sb.Append(";"c)
        Return sb.ToString
    End Function

    'Private Function GetRelation(ByVal dt1 As DataTable, ByVal dt2 As DataTable) As DataRelation
    '    Dim dr As DataRelation
    '    For Each dr In Me._schema.Relations
    '        If (((dr.ParentTable Is dt1) AndAlso (dr.ChildTable Is dt2)) OrElse ((dr.ParentTable Is dt2) AndAlso (dr.ChildTable Is dt1))) Then
    '            Return dr
    '        End If
    '    Next
    '    Return Nothing
    'End Function
    'Private Function InsertRelatedTable(ByVal dt As DataTable, ByVal list As List(Of DataTable)) As Boolean
    '    If Not list.Contains(dt) Then
    '        If (list.Count = 0) Then
    '            list.Add(dt)
    '            Return True
    '        End If
    '        Dim index As Integer = 0
    '        Do While (index <= list.Count)
    '            Dim before As Boolean = ((index = 0) OrElse (Not Me.GetRelation(dt, list.Item((index - 1))) Is Nothing))
    '            Dim after As Boolean = ((index = list.Count) OrElse (Not Me.GetRelation(dt, list.Item(index)) Is Nothing))
    '            If (before AndAlso after) Then
    '                list.Insert(index, dt)
    '                Return True
    '            End If
    '            index += 1
    '        Loop
    '    End If
    '    Return False
    'End Function

    ' ** Properties
    Public Property ConnectionString() As String
        Get
            Return Me._schema.ConnectionString
        End Get
        Set(ByVal value As String)
            If (Me._schema.ConnectionString <> value) Then
                Me._schema.ConnectionString = value
                Me._schema.istTabele = Me._istTabele
                Me._sql = Nothing
                Me.QueryFields.Clear()
            End If
        End Set
    End Property

    Public Property Distinct() As Boolean
        Get
            Return Me._distinct
        End Get
        Set(ByVal value As Boolean)
            Me._distinct = value
            Me._sql = Nothing
        End Set
    End Property

    Public Property GroupBy() As Boolean
        Get
            Return Me._groupBy
        End Get
        Set(ByVal value As Boolean)
            If (Me._groupBy <> value) Then
                Me._groupBy = value
                Me._sql = Nothing
            End If
        End Set
    End Property

    Public Property GroupByExtension() As GroupByExtension
        Get
            Return Me._gbExtension
        End Get
        Set(ByVal value As GroupByExtension)
            If (Me._gbExtension <> value) Then
                Me._gbExtension = value
                Me._sql = Nothing
            End If
        End Set
    End Property

    Public ReadOnly Property QueryFields() As QueryFieldCollection
        Get
            Return Me._queryFields
        End Get
    End Property

    Friend ReadOnly Property Schema() As OleDbSchema
        Get
            Return Me._schema
        End Get
    End Property

    Public ReadOnly Property Sql() As String
        Get
            If ((Me._sql Is Nothing) OrElse Me._sqlIsDirty) Then
                Me._sqlIsDirty = False
                Me._sql = Me.BuildSqlStatement
            End If
            Return Me._sql
        End Get
    End Property

    Public ReadOnly Property sqlPom() As String
        Get
            If ((Me._sqlpom Is Nothing) OrElse Me._sqlPomIsDirty) Then
                Me._sqlPomIsDirty = False
                Me._sqlpom = Me.BuildSqlStatementPom
            End If
            Return Me._sqlpom
        End Get
    End Property

    Public Property Top() As Integer
        Get
            Return Me._top
        End Get
        Set(ByVal value As Integer)
            Me._top = value
            Me._sql = Nothing
        End Set
    End Property

End Class