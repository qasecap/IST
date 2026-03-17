Option Strict Off

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Public Enum GroupingAggregate
    GroupBy = 0
    Sum = 1
    Avg = 2
    Min = 3
    Max = 4
    Count = 5
    SumDistinct = 6
    AvgDistinct = 7
    MinDistinct = 8
    MaxDistinct = 9
    CountDistinct = 10
    StDev = 11
    StDevP = 12
    Var = 13
    VarP = 14
End Enum

Public Enum Sort
    NoSort = 0
    Ascending = 1
    Descending = 2
End Enum

Public Class QueryField
    Implements ICloneable, INotifyPropertyChanged

    ' ** Fields
    Private _alias As String

    Private _column As String
    Private _filter As String
    Private _groupBy As GroupingAggregate
    Private _output As Boolean
    Private Shared _rx1 As Regex = New Regex("^([^<>=]*)\s*(<|>|=|<>|<=|>=)\s*([^<>=]+)$", (RegexOptions.Compiled Or RegexOptions.IgnoreCase))
    Private Shared _rx2 As Regex = New Regex("^([^<>=]*)\s*BETWEEN\s+(.+)\s+AND\s+(.+)$", (RegexOptions.Compiled Or RegexOptions.IgnoreCase))
    Private _sort As Sort
    Private _table As DataTable
    Private _tableAlias As String

    ' ** Ctors
    Public Sub New(ByVal col As DataColumn)
        Me._table = col.Table
        Me._column = col.ColumnName
        Me._output = True
    End Sub

    Public Sub New(ByVal dt As DataTable)
        Me._table = dt
        Me._column = "*"
        Me._output = True
    End Sub

    ' ** Events
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Overridable Sub OnPropertyChanged(ByVal e As PropertyChangedEventArgs)
        RaiseEvent PropertyChanged(Me, e)
    End Sub

    Private Sub OnPropertyChanged(ByVal propName As String)
        Me.OnPropertyChanged(New PropertyChangedEventArgs(propName))
    End Sub

    ' ** Methods
    Public Function Clone() As Object Implements ICloneable.Clone
        Return MyBase.MemberwiseClone
    End Function

    Public Function GetFilterExpression() As String
        GetFilterExpression = Nothing
        Dim filter As String = Me.Filter.Trim
        If (filter.Length = 0) Then
            Return String.Empty
        End If
        Dim m As Match = QueryField._rx1.Match(filter)
        If m.Success Then
            Return IIf((m.Groups.Item(1).Value.Length = 0), String.Format("({0} {1})", Me.GetFullName(True), filter), String.Format("({0})", filter))
        End If
        m = QueryField._rx2.Match(filter)
        If m.Success Then
            Return IIf((m.Groups.Item(1).Value.Length = 0), String.Format("({0} {1})", Me.GetFullName, filter), String.Format("({0})", filter))
        End If
        Debug.WriteLine("Warning: failed to parse filter...")
        Return String.Format("({0} {1})", Me.GetFullName(True), filter)
    End Function

    Public Function GetFullName() As String
        GetFullName = Nothing
        Try
            If ((Me.Column = "*") OrElse Me._table.Columns.Contains(Me.Column)) Then
                'Return String.Format("{0}.{1}", OleDbSchema.GetFullTableName(Me._table), OleDbSchema.BracketName(Me.Column))
                Return String.Format("{0}.{1}", Me.TableAlias, OleDbSchema.BracketName(Me.Column))
            End If
            Return OleDbSchema.BracketName(Me.Column)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Public Function GetFullName(ByVal groupBy As Boolean) As String
        GetFullName = ""
        Dim str As String = Me.GetFullName
        If Not groupBy Then
            Return str
        End If
        Dim fmt As String = "{0}"
        Select Case Me.GroupBy
            Case GroupingAggregate.Sum
                fmt = "SUM({0})"
                Exit Select
            Case GroupingAggregate.Avg
                fmt = "AVG({0})"
                Exit Select
            Case GroupingAggregate.Min
                fmt = "MIN({0})"
                Exit Select
            Case GroupingAggregate.Max
                fmt = "MAX({0})"
                Exit Select
            Case GroupingAggregate.Count
                fmt = "COUNT({0})"
                Exit Select
            Case GroupingAggregate.SumDistinct
                fmt = "SUM(DISTINCT {0})"
                Exit Select
            Case GroupingAggregate.AvgDistinct
                fmt = "AVG(DISTINCT {0})"
                Exit Select
            Case GroupingAggregate.MinDistinct
                fmt = "MIN(DISTINCT {0})"
                Exit Select
            Case GroupingAggregate.MaxDistinct
                fmt = "MAX(DISTINCT {0})"
                Exit Select
            Case GroupingAggregate.CountDistinct
                fmt = "COUNT(DISTINCT {0})"
                Exit Select
            Case GroupingAggregate.StDev
                fmt = "STDEV({0})"
                Exit Select
            Case GroupingAggregate.StDevP
                fmt = "STDEVP({0})"
                Exit Select
            Case GroupingAggregate.Var
                fmt = "VAR({0})"
                Exit Select
            Case GroupingAggregate.VarP
                fmt = "VARP({0})"
                Exit Select
        End Select
        Return String.Format(fmt, str)
    End Function

    ' ** Properties

    Public Property Column() As String
        Get
            Return Me._column
        End Get
        Set(ByVal value As String)
            If (Me._column <> value) Then
                Me._column = value
                Me.OnPropertyChanged("Column")
            End If
        End Set
    End Property

    Public Property [Alias]() As String
        Get
            Return IIf((Not Me._alias Is Nothing), Me._alias, String.Empty)
        End Get
        Set(ByVal value As String)
            If (Me._alias <> value) Then
                Me._alias = value
                Me.OnPropertyChanged("Alias")
            End If
        End Set
    End Property

    Public ReadOnly Property Table() As String
        Get
            Return Me._table.TableName
        End Get
    End Property

    Public Property TableAlias() As String
        Get
            Return IIf((Not Me._tableAlias Is Nothing), Me._tableAlias, String.Empty)
        End Get
        Set(ByVal value As String)
            If (Me._tableAlias <> value) Then
                Me._tableAlias = value
                Me.OnPropertyChanged("TableAlias")
            End If
        End Set
    End Property

    Public Property Output() As Boolean
        Get
            Return Me._output
        End Get
        Set(ByVal value As Boolean)
            If (Me._output <> value) Then
                Me._output = value
                Me.OnPropertyChanged("Output")
            End If
        End Set
    End Property

    Public Property GroupBy() As GroupingAggregate
        Get
            Return Me._groupBy
        End Get
        Set(ByVal value As GroupingAggregate)
            If (Me._groupBy <> value) Then
                Me._groupBy = value
                Me.OnPropertyChanged("GroupBy")
            End If
        End Set
    End Property

    Public Property Sort() As Sort
        Get
            Return Me._sort
        End Get
        Set(ByVal value As Sort)
            If (Me._sort <> value) Then
                Me._sort = value
                Me.OnPropertyChanged("Sort")
            End If
        End Set
    End Property

    Public Property Filter() As String
        Get
            Return IIf((Not Me._filter Is Nothing), Me._filter, String.Empty)
        End Get
        Set(ByVal value As String)
            If (Me._filter <> value) Then
                Me._filter = value
                Me.OnPropertyChanged("Filter")
            End If
        End Set
    End Property

End Class

Public Class QueryFieldCollection
    Inherits BindingList(Of QueryField)

    ' ** Override
    Protected Overrides Sub OnListChanged(ByVal e As ListChangedEventArgs)
        If (e.ListChangedType = ListChangedType.ItemChanged) Then
            Dim f As QueryField = MyBase.Item(e.NewIndex)
            Dim name As String = e.PropertyDescriptor.Name
            If (Not name Is Nothing) Then
                If Not (name = "Alias") Then
                    If ((name = "GroupBy") AndAlso ((f.GroupBy <> GroupingAggregate.GroupBy) AndAlso String.IsNullOrEmpty(f.Alias))) Then
                        f.Alias = Me.CreateUniqueAlias(f)
                    End If
                Else
                    Dim field As QueryField
                    For Each field In Me
                        If ((Not field Is f) AndAlso (f.Alias = field.Alias)) Then
                            f.Alias = Me.CreateUniqueAlias(f)
                            Exit For
                        End If
                    Next
                End If
            End If
        End If
        MyBase.OnListChanged(e)
    End Sub

    ' ** Methods
    Private Function CreateUniqueAlias(ByVal f As QueryField) As String
        Dim i As Integer = 1
        Do While True
            Dim uniqueAlias As String = String.Format("Expr{0}", i)
            Dim duplicate As Boolean = False
            Dim field As QueryField
            For Each field In Me
                If ((Not field Is f) AndAlso (String.Compare(uniqueAlias, field.Alias, True) = 0)) Then
                    duplicate = True
                    Exit For
                End If
            Next
            If Not duplicate Then
                Return uniqueAlias
            End If
            i = i + 1
        Loop
        Return "Never"
    End Function

End Class