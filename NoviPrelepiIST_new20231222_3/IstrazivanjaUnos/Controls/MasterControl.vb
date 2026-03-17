Imports System.Collections.Generic

Public Class MasterControl
    Inherits DataGridView
#Region "Variables"
    Friend rowCurrent As New List(Of Integer)
    Friend rowDefaultHeight As Integer = 22
    Friend rowExpandedHeight As Integer = 300
    Friend rowDefaultDivider As Integer = 0
    Friend rowExpandedDivider As Integer = 300 - 22
    Friend rowDividerMargin As Integer = 5
    Friend collapseRow As Boolean
    Friend childView As New detailControl With {.Height = rowExpandedDivider - rowDividerMargin * 2, .Visible = False}
    '
    Friend WithEvents RowHeaderIconList As System.Windows.Forms.ImageList
    Private components As System.ComponentModel.IContainer
    '
    Dim _cDataset As DataSet
    Dim _cDatasetpom As DataSet
    Dim _foreignKey() As String
    Dim _filterFormat() As String
    Dim glavnaTabela As String
    Enum rowHeaderIcons
        expand = 0
        collapse = 1
    End Enum
#End Region
#Region "Initialze and Display"
    Sub New(ByVal cDataset As DataSet, ByVal cDatasetpom As DataSet)
        Me.Controls.Add(childView)
        InitializeComponent()
        _cDataset = cDataset
        _cDatasetpom = cDatasetpom
        'childView._cDataset = cDataset
        childView._cDataset = cDatasetpom
        applyGridTheme(Me)
        Dock = DockStyle.Fill
    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterControl))
        Me.RowHeaderIconList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RowHeaderIconList
        '
        Me.RowHeaderIconList.ImageStream = CType(resources.GetObject("RowHeaderIconList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.RowHeaderIconList.TransparentColor = System.Drawing.Color.Transparent
        Me.RowHeaderIconList.Images.SetKeyName(0, "expand.png")
        Me.RowHeaderIconList.Images.SetKeyName(1, "collapse.png")
        '
        'MasterControl
        '
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region
#Region "DataControl"
    Friend Sub setParentSource(ByVal tableName As String, ByVal foreignKey As String)
        Me.DataSource = New DataView(_cDataset.Tables(tableName))
        glavnaTabela = tableName
        setGridRowHeader(Me)
        Dim fK() As String = foreignKey.TrimEnd(";").Split(";")
        _filterFormat = fK
        For i As Integer = 0 To fK.GetUpperBound(0)
            If _cDataset.Tables(tableName).Columns(fK(i)).GetType.ToString = GetType(Integer).ToString OrElse _cDataset.Tables(tableName).Columns(fK(i)).GetType.ToString = GetType(Double).ToString OrElse _cDataset.Tables(tableName).Columns(fK(i)).GetType.ToString = GetType(Decimal).ToString Then
                _filterFormat(i) = fK(i) & "={0}"
            Else
                _filterFormat(i) = fK(i) & "='{0}'"
            End If
        Next
        _foreignKey = foreignKey.TrimEnd(";").Split(";")
    End Sub
#End Region
#Region "GridEvents"

    Private Sub popuniPodtabeleODGlavne(ByVal mc As MasterControl)
        'Dim glavna As String = glavnaTabela
        For i As Integer = 1 To _cDataset.Tables.Count - 1  'sve sem glavne koja je u ds.tables(0)
            Dim nadtabela As String = _cDataset.Tables(i).Namespace.Split("%")(0)
            If glavnaTabela.Trim.ToUpper = nadtabela.Trim.ToUpper Then
                For k As Integer = 0 To mc.childView.childGrid.Count - 1
                    If _cDataset.Tables(i).TableName.Trim.ToUpper = mc.childView.childGrid(k).Tag.TableName.Trim.ToUpper Then
                        Dim dvv As DataView = getDV(mc.childView.childGrid(k).Tag)
                        mc.childView.childGrid(k).DataSource = dvv
                        'mc.childView.childGrid(k).Parent
                    End If
                Next
            End If
        Next
    End Sub
    Dim errr As Integer
    Private Sub MasterControl_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles MyBase.RowHeaderMouseClick
        Dim mc As MasterControl = DirectCast(sender, MasterControl)
        'popunim podtabele od glavne
        If _cDataset.Tables.Count > 1 Then   'ima nesto sem glavne
            Call popuniPodtabeleODGlavne(mc)

            Dim rect As Rectangle = New Rectangle((rowDefaultHeight - 16) / 2, (rowDefaultHeight - 16) / 2, 16, 16)

            If errr <> e.RowIndex AndAlso collapseRow = False Then
                'zatvori
                rowCurrent.Clear()
                Me.Rows(errr).Height = rowDefaultHeight
                Me.Rows(errr).DividerHeight = rowDefaultDivider
                Me.ClearSelection()
                collapseRow = True
            End If

            errr = e.RowIndex
            If rect.Contains(e.Location) Then
                If rowCurrent.Contains(e.RowIndex) Then
                    rowCurrent.Clear()
                    Me.Rows(e.RowIndex).Height = rowDefaultHeight
                    Me.Rows(e.RowIndex).DividerHeight = rowDefaultDivider
                Else
                    If Not rowCurrent.Count = 0 Then
                        Dim eRow As Integer = rowCurrent(0)
                        rowCurrent.Clear()
                        Me.Rows(eRow).Height = rowDefaultHeight
                        Me.Rows(eRow).DividerHeight = rowDefaultDivider
                        Me.ClearSelection()
                        collapseRow = True
                        Me.Rows(eRow).Selected = True
                    End If
                    rowCurrent.Add(e.RowIndex)
                    Me.Rows(e.RowIndex).Height = rowExpandedHeight
                    Me.Rows(e.RowIndex).DividerHeight = rowExpandedDivider
                End If
                Me.ClearSelection()
                collapseRow = True
                Me.Rows(e.RowIndex).Selected = True
            Else
                'collapseRow = False NIKAKO INACE OSTANE PRETHODNI OTVOREN
            End If

        End If

    End Sub

    Private Sub MasterControl_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles MyBase.RowPostPaint
        'set childview control
        If _cDataset.Tables.Count > 1 Then   'ima nesto sem glavne

            Dim rect As Object = New Rectangle(e.RowBounds.X + ((rowDefaultHeight - 16) / 2), e.RowBounds.Y + ((rowDefaultHeight - 16) / 2), 16, 16)
            If collapseRow Then
                If rowCurrent.Contains(e.RowIndex) Then
                    sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)
                    childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                    childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                    childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10
                    childView.Visible = True
                Else
                    childView.Visible = False
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
                End If
                collapseRow = False
            Else
                If rowCurrent.Contains(e.RowIndex) Then
                    sender.Rows(e.RowIndex).DividerHeight = sender.Rows(e.RowIndex).height - rowDefaultHeight
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.collapse), rect)
                    childView.Location = New Point(e.RowBounds.Left + sender.RowHeadersWidth, e.RowBounds.Top + rowDefaultHeight + 5)
                    childView.Width = e.RowBounds.Right - sender.rowheaderswidth
                    childView.Height = sender.Rows(e.RowIndex).DividerHeight - 10
                    childView.Visible = True
                Else
                    e.Graphics.DrawImage(RowHeaderIconList.Images(rowHeaderIcons.expand), rect)
                End If
            End If
        End If

        rowPostPaint_HeaderCount(sender, e)
    End Sub
    Private Sub MasterControl_Scroll(sender As Object, e As ScrollEventArgs) Handles MyBase.Scroll
        If Not rowCurrent.Count = 0 Then
            collapseRow = True
            Me.ClearSelection()
            Me.Rows(rowCurrent(0)).Selected = True
        End If
    End Sub
    Private Sub MasterControl_SelectionChanged(sender As Object, e As EventArgs) Handles MyBase.SelectionChanged

        If Not Me.RowCount = 0 AndAlso Not Me.CurrentRow Is Nothing Then
            If rowCurrent.Contains(Me.CurrentRow.Index) Then
                For Each cGrid As DataGridView In childView.childGrid
                    'CType(cGrid.DataSource, DataView).RowFilter = "CustomerID='ANATR'"
                    Dim rowf As String = ""
                    For i As Integer = 0 To _foreignKey.GetUpperBound(0)
                        rowf = rowf + String.Format(_filterFormat(i), Me(_foreignKey(i), Me.CurrentRow.Index).Value) + " $ "
                    Next
                    rowf = rowf.Trim.TrimEnd("$").Replace("$", "AND")
                    If Not cGrid.DataSource Is Nothing Then
                        cGrid.AccessibleName = rowf
                        Dim dvv As DataView = getDV(cGrid.DataSource)
                        dvv.RowFilter = rowf
                    End If
                Next
            End If
        End If
    End Sub
    Function getDV(ByVal dd As Object) As DataView
        If TypeOf dd Is DataTable Then
            Dim dv As New DataView(dd)
            getDV = dv
        ElseIf TypeOf dd Is DataView Then
            getDV = dd
        End If
    End Function
#End Region
End Class
