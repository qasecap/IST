Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormQD
    Inherits FormTemplate

    Dim ttab As DatasetIstrazivanja.ISTTABSDataTable
    Dim istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Dim istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Dim istLK As DatasetIstrazivanja.ISTLKDataTable
    Dim istBaze As DatasetIstrazivanja.ISTBAZEDataTable
    Dim mrist As DatasetIstrazivanja.ISTRow

    Dim ISTConnectionString As String = ""
    Dim DBConnectionString As String = ""

    Dim putanja As String
    Dim dtSelect As New System.Data.DataTable
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String

    Dim jezik As String
    Dim txtmode As String

    Dim sifistA As String
    Dim dbNameA As String
    Dim dbServerNameA As String
    Dim konDepo As String
    Dim lokalno As Boolean
    Private _builder As QueryBuilder
    Private vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    '*******
    Private originalExStyle As Integer = -1
    Private enableFormLevelDoubleBuffering As Boolean = True
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            If originalExStyle = -1 Then originalExStyle = MyBase.CreateParams.ExStyle
            Dim cp As CreateParams = MyBase.CreateParams

            If enableFormLevelDoubleBuffering Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            Else
                cp.ExStyle = originalExStyle
            End If
            Return cp
        End Get
    End Property
    Public Sub TurnOffFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = False
        'Me.MaximizeBox = True
    End Sub
    Public Sub TurnOnFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = True
        ' Me.MaximizeBox = True
    End Sub
    Private Sub Form_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        TurnOnFormLevelDoubleBuffering()
    End Sub

    Private Sub Form_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        TurnOffFormLevelDoubleBuffering()
    End Sub
    '*******
    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                    ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable,
                    ByVal ISTConnectionString As String,
                    ByVal txtInst As String, ByVal txtPismo As String,
                    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
                    ByVal txt_DSBrisanjeBaza As String, ByVal txtmode As String, ByVal jezik As String)

        MyBase.New()
        InitializeComponent()


        Me.istTabele = istTabele

        Me._builder = New QueryBuilder(New OleDbSchema, istTabele)

        Me._builder.ConnectionString = DBConnectionString

        AddHandler Me._builder.QueryFields.ListChanged, New ListChangedEventHandler(AddressOf Me.QueryFields_ListChanged)

        Me._grid.DataSource = Me._builder.QueryFields

        Me.FixGridColumns()
        Me.UpdateGridColumns()
        Me.UpdateTableTree()

        Me.jezik = jezik
        Call SetLang()
        Me.txtmode = txtmode
        Me.vt = vt
        Me.Text = Me.Text + " - " + ri.Naziv.Trim
        Me.ttab = ttab

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        lokalno = False
        'NS je trazio da za njih se ne radi DEPO pri brisanju
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

        Me.mrist = ri

        'ucvtA.Init(vt)

        Me.sifistA = ri.SIFIST.Trim
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString

        Dim bs() As String = dajBazuServer(sifistA, Me.ISTConnectionString).Split("$")
        dbNameA = bs(0) : dbServerNameA = bs(1)

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza

        'Call srediformu()
        konDepo = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)
    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")

    End Sub

    Public Property ConnectionString() As String
        Get
            Return Me._builder.ConnectionString
        End Get
        Set(ByVal value As String)
            If (value <> Me.ConnectionString) Then
                Me._builder.ConnectionString = value
                Me.UpdateTableTree()
            End If
        End Set
    End Property

    Private ReadOnly Property Schema() As OleDbSchema
        Get
            Return Me._builder.Schema
        End Get
    End Property

    Public Property SelectStatement() As String
        Get
            Return Me._builder.Sql
        End Get
        Set(ByVal value As String)
        End Set
    End Property

    ' ** Event Handlers
    Private Sub _btnCheckSql_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnCheckSql.Click
        Try
            Dim connstring As String = Me.DBConnectionString
            If connstring.IndexOf("Provider=", StringComparison.OrdinalIgnoreCase) < 0 Then connstring = "Provider=SQLOLEDB.1;" + connstring
            Dim da As New OleDbDataAdapter(Me.txtSql.Text, connstring)
            Dim dt As New DataTable
            da.FillSchema(dt, SchemaType.Mapped)
            ISTMessageBox.Show(Me, "SqlCheckSucceeded", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Catch ex As Exception
            Dim msg As String = String.Format("SqlCheckFailed", ex.Message)
            ISTMessageBox.Show(Me, msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub _btnClearQuery_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnClearQuery.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If ISTMessageBox.Show("ConfirmClear", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
            Call clearaLL()
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub clearaLL()
        Me._builder.QueryFields.Clear()
        Me._gridPreview.DataSource = Nothing
        Me._grid.DataSource = Me._builder.QueryFields
        Me.txtSql.Text = ""
        txtSqlPom = ""
        Call pponistiINSERTAPPEND()
    End Sub

    Dim txtSqlPom As String = ""

    Private Sub _btnGroupBy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnGroupBy.Click
        Me._btnGroupBy.Checked = Not Me._btnGroupBy.Checked
        Me._builder.GroupBy = Me._btnGroupBy.Checked
        Call qbuilder()
        Me.UpdateGridColumns()
    End Sub

    Private Sub _btnProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnProperties.Click
        Using dlg As FormQDQueryPropertiesDialog = New FormQDQueryPropertiesDialog
            dlg.Font = Me.Font
            dlg.QueryBuilder = Me._builder
            If (dlg.ShowDialog = DialogResult.OK) Then
                Call qbuilder()
            End If
        End Using
    End Sub

    Dim iinsertinto As Boolean
    Dim aappend As Boolean
    Dim aasview As Boolean
    Dim sselect As Boolean
    Dim strRes As String

    Private Sub _btnViewResults_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnViewResults.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            strRes = ""
            'Dim dt As DataTable = izvrsiSQLvratiDT(Me.SelectStatement.Replace("$", ""), Me.DBConnectionString, Me.jezik)
            Dim dt As DataTable = izvrsiSQLvratiDT(Me.txtSql.Text, Me.DBConnectionString, Me.jezik)
            Me._gridPreview.DataSource = dt
            Me.Text = String.Format(Me.Text, dt.TableName, dt.Rows.Count)

            strRes = "--(" + dbServerNameA + "," + dbNameA + ")" + nvrd + Me.txtSql.Text + ";"
        Catch x As Exception
            Dim msg As String = String.Format("ErrGettingData", x.Message)
            ISTMessageBox.Show(Me, msg, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub _grid_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles _grid.CellClick
        If (Me._grid.Columns.Item(e.ColumnIndex).Name = "Filter") Then
            Using dlg As FormQDFilterEditor = New FormQDFilterEditor
                Dim field As QueryField = TryCast(Me._grid.Rows.Item(e.RowIndex).DataBoundItem, QueryField)
                dlg.Font = Me.Font
                dlg.QueryField = field
                If (dlg.ShowDialog(Me) = DialogResult.OK) Then
                    field.Filter = dlg.Value
                End If
            End Using
        End If
    End Sub

    Private selectedRowCount As Integer? = Nothing       'As Integer?  da bi mogao i nothing i null, inace samo integer ne moze
    Private cancelDeletion As Boolean = False

    Private Sub _grid_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles _grid.UserDeletingRow
        If Not Me.selectedRowCount.HasValue Then
            'This is the first row being deleted.
            Me.selectedRowCount = Me._grid.SelectedRows.Count
            Me.cancelDeletion = (ISTMessageBox.Show("Are you sure you want to delete the selected row(s)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No)
            Dim tt As String = _grid.SelectedRows(0).Cells.Item("table").Value.ToString.Trim.ToUpper
            tabele = tabele.Replace(tt + ";", "")
        End If

        e.Cancel = Me.cancelDeletion
    End Sub

    Private Sub _grid_CellEndEdit(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles _grid.CellEndEdit, _grid.CellContentClick
        Me._grid.CommitEdit(DataGridViewDataErrorContexts.Commit)
    End Sub

    Private Sub _grid_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles _grid.DragDrop
        Dim node As TreeNode = TryCast(e.Data.GetData(GetType(TreeNode)), TreeNode)
        If (Not node Is Nothing) Then
            Me.AddField(node.Tag, node)
        Else
            Dim row As DataGridViewRow = TryCast(e.Data.GetData(GetType(DataGridViewRow)), DataGridViewRow)
            If (Not row Is Nothing) Then
                Dim pt As Point = Me._grid.PointToClient(New Point(e.X, e.Y))
                Dim ht As DataGridView.HitTestInfo = Me._grid.HitTest(pt.X, pt.Y)
                Dim src As Integer = row.Index
                Dim dst As Integer = ht.RowIndex
                If (dst < 0) Then
                    dst = (Me._grid.Rows.Count - 1)
                End If
                If (src <> dst) Then
                    Dim fields As QueryFieldCollection = Me._builder.QueryFields
                    Dim field As QueryField = fields.Item(src)
                    fields.RemoveAt(src)
                    fields.Insert(dst, field)
                End If
            End If
        End If
    End Sub

    Private Sub _grid_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles _grid.DragEnter
        Dim node As TreeNode = TryCast(e.Data.GetData(GetType(TreeNode)), TreeNode)
        If ((Not node Is Nothing) AndAlso (TypeOf node.Tag Is DataColumn OrElse TypeOf node.Tag Is DataTable)) Then
            e.Effect = DragDropEffects.Copy
        Else
            Dim row As DataGridViewRow = TryCast(e.Data.GetData(GetType(DataGridViewRow)), DataGridViewRow)
            If ((Not row Is Nothing) AndAlso Me._grid.Rows.Contains(row)) Then
                e.Effect = DragDropEffects.Move
            End If
        End If
    End Sub

    Private Sub _grid_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles _grid.DragOver
        Dim row As DataGridViewRow = TryCast(e.Data.GetData(GetType(DataGridViewRow)), DataGridViewRow)
        If (Not row Is Nothing) Then
            Dim pt As Point = Me._grid.PointToClient(New Point(e.X, e.Y))
            Select Case Me._grid.HitTest(pt.X, pt.Y).Type
                Case DataGridViewHitTestType.None, DataGridViewHitTestType.Cell, DataGridViewHitTestType.RowHeader
                    e.Effect = DragDropEffects.Move
                    Return
            End Select
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub _grid_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _grid.MouseDown
        Dim ht As DataGridView.HitTestInfo = Me._grid.HitTest(e.X, e.Y)
        If (ht.Type = DataGridViewHitTestType.RowHeader) Then
            Dim row As DataGridViewRow = Me._grid.Rows.Item(ht.RowIndex)
            If (Not row Is Nothing) Then
                Dim field As QueryField = TryCast(row.DataBoundItem, QueryField)
                If (Not field Is Nothing) Then
                    Me._grid.CurrentCell = row.Cells.Item(0)
                    If (MyBase.DoDragDrop(row, DragDropEffects.Move) <> DragDropEffects.None) Then
                        Me._timer.Tag = field
                        Me._timer.Start()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub _mnuHideThisTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _mnuHideThisTable.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim node As TreeNode = Me._treeTables.SelectedNode
        If (Not node Is Nothing) Then
            Me._treeTables.Nodes.Remove(node)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub _mnuDropThisTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _mnuDropThisTable.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim node As TreeNode = Me._treeTables.SelectedNode

        If (Not node Is Nothing) Then
            Dim sql As String = "select top(1) ko_insert from ISTLogKoriscenjaProcesa where proces='query designer - create table' and izvestaj='" + node.Text + "' and ko_insert like '%" + GetUserNameIzBaze(Me.DBConnectionString) + "%' order by datum_insert desc"
            Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.konDepo, Me.jezik)

            If dt.Rows.Count = 1 Then
                Call ddrop(sql, "table", node.Text)
            Else

                Dim sqlV As String = "select top(1) ko_insert from ISTLogKoriscenjaProcesa where proces='query designer - create view' and izvestaj='" + node.Text + "' and ko_insert like '%" + GetUserNameIzBaze(Me.DBConnectionString) + "%' order by datum_insert desc"
                Dim dtV As DataTable = izvrsiSQLvratiDT(sqlV, Me.konDepo, Me.jezik)

                If dtV.Rows.Count = 1 Then
                    Call ddrop(sql, "view", node.Text)
                Else
                    ISTMessageBox.Show("Drop is not allowed! You did not create this object.")
                End If

            End If

        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub ddrop(ByVal sql As String, ByVal oobject As String, ByVal nname As String)
        If ISTMessageBox.Show("Do you want to drop " + oobject + "?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            sql = "DROP " + oobject + " " + nname

            Dim ok1 As String = izvrsiSQL(sql, Me.DBConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER95", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            Dim txt As String = "Drop " + oobject
            Call UpisiUISTLogKoriscenjaProcesa("Query designer - " + txt, nname)
            Me._builder = New QueryBuilder(New OleDbSchema, Me.istTabele)
            Me._builder.ConnectionString = DBConnectionString
            AddHandler Me._builder.QueryFields.ListChanged, New ListChangedEventHandler(AddressOf Me.QueryFields_ListChanged)
            Me.UpdateTableTree()
        End If
    End Sub

    Private Sub _bRefresh_Click(sender As Object, e As EventArgs) Handles _bRefresh.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call rrefresh()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub rrefresh()

        Me._builder = New QueryBuilder(New OleDbSchema, Me.istTabele)
        Me._builder.ConnectionString = DBConnectionString
        AddHandler Me._builder.QueryFields.ListChanged, New ListChangedEventHandler(AddressOf Me.QueryFields_ListChanged)
        Me.UpdateTableTree()

    End Sub

    'Private Sub _mnuRelatedTables_DropDownItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs)
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    Dim node As TreeNode = Me.FindNode(e.ClickedItem.Text)
    '    If (Not node Is Nothing) Then
    '        Me._treeTables.SelectedNode = node
    '        node.Expand()
    '    End If
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Sub

    Private Sub _mnuShowAllTables_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _mnuShowAllTables.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.UpdateTableTree()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub _mnuTree_Opening(ByVal sender As Object, ByVal e As CancelEventArgs)
        Dim pt As Point = Me._treeTables.PointToClient(Control.MousePosition)
        Dim nd As TreeNode = Me._treeTables.GetNodeAt(pt)
        Dim dt As DataTable = IIf((nd Is Nothing), Nothing, TryCast(nd.Tag, DataTable))
        If (Not nd Is Nothing) Then
            Me._treeTables.SelectedNode = nd
        End If
        If (dt Is Nothing) Then
            e.Cancel = True
        Else
            'Me._mnuRelatedTables.DropDownItems.Clear()
            'If ((Not nd Is Nothing) AndAlso TypeOf nd.Tag Is DataTable) Then
            '    Dim list As New List(Of String)
            '    Dim dr As DataRelation
            '    For Each dr In Me._builder.Schema.Relations
            '        If Not ((Not dr.ParentTable Is dt) OrElse list.Contains(dr.ChildTable.TableName)) Then
            '            list.Add(dr.ChildTable.TableName)
            '        ElseIf Not ((Not dr.ChildTable Is dt) OrElse list.Contains(dr.ParentTable.TableName)) Then
            '            list.Add(dr.ParentTable.TableName)
            '        End If
            '    Next
            '    list.Sort()
            'Dim tableName As String
            'For Each tableName In list
            '    If (Not Me.FindNode(tableName) Is Nothing) Then
            '        Me._mnuRelatedTables.DropDownItems.Add(tableName)
            '    End If
            'Next
            'End If
        End If
    End Sub

    Private Sub _timer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles _timer.Tick
        Me._timer.Stop()
        Me.SelectField(TryCast(Me._timer.Tag, QueryField))
    End Sub

    Private Sub _treeTables_ItemDrag(ByVal sender As Object, ByVal e As ItemDragEventArgs) Handles _treeTables.ItemDrag
        Dim node As TreeNode = TryCast(e.Item, TreeNode)
        If ((Not node Is Nothing) AndAlso (TypeOf node.Tag Is DataTable OrElse TypeOf node.Tag Is DataColumn)) Then
            Me._treeTables.SelectedNode = node
            MyBase.DoDragDrop(e.Item, DragDropEffects.Copy)
        End If
    End Sub

    Private Sub _treeTables_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles _treeTables.NodeMouseDoubleClick
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If ((e.Node Is Me._treeTables.SelectedNode) AndAlso TypeOf e.Node.Tag Is DataColumn) Then
            Me.AddField(e.Node.Tag, e.Node)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub qbuilder()
        Try
            Call qq()
        Catch ex As Exception
            ' ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                Call qq()
            Catch ex2 As Exception
                Call qq()
                '  ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Try
    End Sub

    Sub qq()
        Me.txtSql.Text = Me._builder.Sql
        Me.txtSqlPom = Me._builder.sqlPom
        If strJoin <> "" Then
            Dim pp() As String = txtSqlPom.Split("$")
            txtSqlPom = pp(0) + "$FROM " + strJoin.Trim + "$" + pp(2)
            txtSql.Text = pp(0) + "FROM " + strJoin + pp(2)
        End If
    End Sub

    Private Sub QueryFields_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
        Try
            Call qbuilder()
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' ** Implementation
    Private Sub AddColumn(ByVal dc As DataColumn)
        Dim field As New QueryField(dc)
        Me._builder.QueryFields.Add(field)
        Me.SelectField(field)
    End Sub

    Private Sub AddDataColumns(ByVal node As TreeNode, ByVal dt As DataTable)
        Dim col As DataColumn
        For Each col In dt.Columns
            Dim field As TreeNode = node.Nodes.Add(col.ColumnName)
            field.Tag = col
            field.ImageIndex = 2
            field.SelectedImageIndex = 2
        Next
    End Sub

    Dim tabele As String = ""

    Private Sub AddField(ByVal element As Object, ByVal node As TreeNode)
        Dim dt As DataTable = TryCast(element, DataTable)
        If (Not dt Is Nothing) Then
            Me.AddTable(dt)
            'If node.Level = 1 Then tabele = tabele + node.Text.Trim.ToUpper + ";"
        End If
        Dim dc As DataColumn = TryCast(element, DataColumn)
        If (Not dc Is Nothing) Then
            Me.AddColumn(dc)
        End If
    End Sub

    Private Sub AddTable(ByVal dt As DataTable)
        Dim field As New QueryField(dt)
        Me._builder.QueryFields.Add(field)
        Me.SelectField(field)
    End Sub

    Private Function FindNode(ByVal [text] As String) As TreeNode
        Return Me.FindNode(Me._treeTables.Nodes, [text])
    End Function

    Private Function FindNode(ByVal nodes As TreeNodeCollection, ByVal [text] As String) As TreeNode
        Dim node As TreeNode
        For Each node In nodes
            Dim dt As DataTable = TryCast(node.Tag, DataTable)
            If ((Not dt Is Nothing) AndAlso (dt.TableName = [text])) Then
                Return node
            End If
            Dim child As TreeNode = Me.FindNode(node.Nodes, [text])
            If (Not child Is Nothing) Then
                Return child
            End If
        Next
        Return Nothing
    End Function

    Private Sub FixGridColumns()
        Dim i As Integer
        For i = 0 To Me._grid.Columns.Count - 1
            Dim col As DataGridViewColumn = Me._grid.Columns.Item(i)
            If col.ValueType.IsEnum Then
                Dim cmb As New DataGridViewComboBoxColumn
                cmb.ValueType = col.ValueType
                cmb.Name = col.Name
                cmb.DataPropertyName = col.DataPropertyName
                cmb.HeaderText = col.HeaderText
                cmb.DisplayStyleForCurrentCellOnly = True
                cmb.DataSource = [Enum].GetValues(col.ValueType)
                Me._grid.Columns.RemoveAt(i)
                Me._grid.Columns.Insert(i, cmb)
            ElseIf (col.Name = "Filter") Then
                Dim btn As New DataGridViewButtonColumn
                btn.ValueType = col.ValueType
                btn.Name = col.Name
                btn.DataPropertyName = col.DataPropertyName
                btn.HeaderText = col.HeaderText
                Me._grid.Columns.RemoveAt(i)
                Me._grid.Columns.Insert(i, btn)
            End If
        Next i
    End Sub

    Private Sub SelectField(ByVal field As QueryField)
        Dim cm As CurrencyManager = TryCast(Me.BindingContext.Item(Me._grid.DataSource), CurrencyManager)
        cm.Position = cm.List.IndexOf(field)
    End Sub

    Private Sub UpdateGridColumns()
        Me._grid.Columns.Item("Column").Frozen = True
        Me._grid.Columns.Item("GroupBy").Visible = Me._builder.GroupBy
    End Sub

    Private Sub UpdateTableTree()
        Dim nodes As TreeNodeCollection = Me._treeTables.Nodes
        nodes.Clear()
        Dim ndTables As New TreeNode("Tables", 0, 0)
        Dim ndViews As New TreeNode("Views", 1, 1)

        If (Not Me.Schema Is Nothing) Then
            Me._treeTables.BeginUpdate()
            Dim dt As DataTable
            For Each dt In Me.Schema.Tables
                Dim node As New TreeNode(dt.TableName)
                node.Tag = dt
                Select Case OleDbSchema.GetTableType(dt)
                    Case TableType.Table
                        ndTables.Nodes.Add(node)
                        node.ImageIndex = 0
                        node.SelectedImageIndex = 0
                        Me.AddDataColumns(node, dt)
                        Exit Select
                    Case TableType.View
                        ndViews.Nodes.Add(node)
                        node.ImageIndex = 1
                        node.SelectedImageIndex = 1
                        Me.AddDataColumns(node, dt)
                        Exit Select
                End Select
            Next

            Dim nd As TreeNode

            For Each nd In New TreeNode() {ndTables, ndViews}
                If (nd.Nodes.Count > 0) Then
                    nd.Text = String.Format("{0} ({1})", nd.Text, nd.Nodes.Count)
                    nodes.Add(nd)
                End If
            Next

            ndTables.Expand()
            Me._treeTables.EndUpdate()
        End If
    End Sub

    Private Sub QueryDesignerDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Function GetChildren(parentNode As TreeNode) As List(Of String)
        Dim nodes As List(Of String) = New List(Of String)
        GetAllChildren(parentNode, nodes)
        Return nodes
    End Function

    Sub GetAllChildren(parentNode As TreeNode, nodes As List(Of String))
        For Each childNode As TreeNode In parentNode.Nodes
            nodes.Add(childNode.Text)
            GetAllChildren(childNode, nodes)
        Next
    End Sub

    '+++++++++++++++++++++++++++
    Function DoesTableExist(ByVal tableName As String) As Boolean
        Dim connstring As String = Me.DBConnectionString
        If connstring.IndexOf("Provider=", StringComparison.OrdinalIgnoreCase) < 0 Then connstring = "Provider=SQLOLEDB.1;" + connstring
        Dim connection As New OleDbConnection(connstring)
        connection.Open()
        Dim tables As DataTable = connection.GetSchema("Tables")
        connection.Close()
        Dim tableView As DataView = tables.DefaultView
        tableView.RowFilter = String.Format("TABLE_NAME='{0}'", tableName)
        Return tableView.Count > 0
    End Function

    Function DoesViewExist(ByVal viewName As String) As Boolean
        Dim connstring As String = Me.DBConnectionString
        If connstring.IndexOf("Provider=", StringComparison.OrdinalIgnoreCase) < 0 Then connstring = "Provider=SQLOLEDB.1;" + connstring
        Dim connection As New OleDbConnection(connstring)
        connection.Open()
        Dim views As DataTable = connection.GetSchema("Tables")
        connection.Close()
        Dim view As DataView = views.DefaultView
        view.RowFilter = String.Format("TABLE_NAME='{0}' and TABLE_TYPE='VIEW'", viewName)
        Return view.Count > 0
    End Function

    Function DoesColumnExistWithinTable(ByVal tableName As String, ByVal columnName As String) As Boolean
        Dim connstring As String = Me.DBConnectionString
        If connstring.IndexOf("Provider=", StringComparison.OrdinalIgnoreCase) < 0 Then connstring = "Provider=SQLOLEDB.1;" + connstring
        Dim connection As New OleDbConnection(connstring)
        connection.Open()
        Dim columns As DataTable = connection.GetSchema("Columns")
        connection.Close()
        Dim columnView As DataView = columns.DefaultView
        columnView.RowFilter = String.Format("TABLE_NAME='{0}' AND COLUMN_NAME='{1}'", tableName, columnName)
        Return columnView.Count > 0
    End Function

    Function DoesDataExistWithinTable(ByVal tableName As String, ByVal columnName As String) As Boolean
        Dim connstring As String = Me.DBConnectionString
        If connstring.IndexOf("Provider=", StringComparison.OrdinalIgnoreCase) < 0 Then connstring = "Provider=SQLOLEDB.1;" + connstring
        Dim connection As New OleDbConnection(connstring)
        Dim command As New OleDbCommand(String.Format("SELECT COUNT({1}) As CountOfData FROM {0}", tableName, columnName), connection)
        connection.Open()
        Dim countOfData As Int32 = Convert.ToInt32(command.ExecuteScalar)
        connection.Close()
        Return countOfData > 0
    End Function

    Private Sub _bAddJ_Click(sender As Object, e As EventArgs) Handles _bAddJ.Click
        Call jjoin()
    End Sub

    Private Sub _bRemoveJ_Click(sender As Object, e As EventArgs) Handles _bRemoveJ.Click
        strJoin = ""
        Call qbuilder()
    End Sub

    Dim tabeleJoin() As String
    Dim koloneJoin() As String
    Dim bazaPrefiksJoin() As String
    Dim aliasJoin() As String
    Dim iJoin As Integer
    Dim strJoin As String = ""

    Sub ppp(ByVal i As Integer, ByVal tabela As String, ByVal kolone As String, ByVal slovo As String, ByVal dbname As String, ByVal dbserver As String)

        iJoin = iJoin + 1
        ReDim Preserve bazaPrefiksJoin(iJoin)

        Dim prefiks As String = "dbo."
        If tabela.Trim.IndexOf(".") > 0 Then prefiks = ""
        bazaPrefiksJoin(iJoin) = dbname + "." + prefiks

        ReDim Preserve tabeleJoin(iJoin)
        tabeleJoin(iJoin) = tabela

        ReDim Preserve aliasJoin(iJoin)
        aliasJoin(iJoin) = slovo

        ReDim Preserve koloneJoin(iJoin)
        kolone = kolone + "$" : kolone = kolone.Replace("$$", "")
        koloneJoin(iJoin) = kolone

    End Sub

    Sub jjoin()
        iJoin = -1
        tabeleJoin = Nothing
        koloneJoin = Nothing

        Dim tabela As String = ""
        Dim ptabela As String = ""
        Dim kolone As String = ""
        Dim k As Integer = 0
        For i As Integer = 0 To Me._builder.QueryFields.Count - 1
            tabela = (Me._builder.QueryFields(i)).Table
            If ptabela <> tabela Then
                ptabela = tabela
                k = k + 1
                Dim node As TreeNode = FindNode(ptabela)
                If node.Level = 1 Then   'tabela
                    kolone = ""
                    For m As Integer = 0 To node.Nodes.Count - 1
                        kolone = kolone + node.Nodes(m).Text + "$"
                    Next
                    Call ppp(iJoin, ptabela, kolone, "T" + Str(k).Trim, dbNameA, dbServerNameA)
                End If
            End If
        Next

        Dim fJoin As FormJoin = New FormJoin(Me, tabeleJoin, koloneJoin, bazaPrefiksJoin, aliasJoin)
        Dim kako As String = ""
        strJoin = ""
        If fJoin.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            strJoin = fJoin.strJOIN
            If strJoin <> "" Then
                Dim pp() As String = txtSqlPom.Split("$")
                txtSqlPom = pp(0) + "$FROM " + strJoin.Trim + "$" + pp(2)
                txtSql.Text = pp(0) + "FROM " + strJoin + pp(2)
            End If
        End If
    End Sub

    Private Sub _bNewTable1_Click(sender As Object, e As EventArgs) Handles _bNewTable1.Click
        _bTableName.Visible = True
        _bTableName.Focus()
        iinsertinto = True
        aappend = False
        aasview = False
    End Sub

    Sub pponistiINSERTAPPEND()
        iinsertinto = False
        aappend = False
        aasview = False
    End Sub

    Private Sub _basview_Click(sender As Object, e As EventArgs) Handles _bAsView.Click
        _bTableName.Visible = True
        _bTableName.Focus()
        iinsertinto = False
        aappend = False
        aasview = True
    End Sub

    Private Sub _bRun_Click(sender As Object, e As EventArgs) Handles _bRun.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim txt As String = ""

        If iinsertinto = False AndAlso aappend = False AndAlso aasview = False Then
            iinsertinto = True
        End If

        If iinsertinto = True AndAlso DoesTableExist(_bTableName.Text.Trim.ToUpper) = True Then
            ISTMessageBox.Show("Table with that name already exists!")
            _bTableName.Visible = True
            _bTableName.Focus()
            Exit Sub
        End If

        If aappend = True AndAlso DoesTableExist(_bTableName.Text.Trim.ToUpper) = False Then
            ISTMessageBox.Show("Table with that name do not exists! You can not add records!")
            _bTableName.Visible = True
            _bTableName.Focus()
            Exit Sub
        End If

        If aasview = True AndAlso DoesViewExist(_bTableName.Text.Trim.ToUpper) = True Then
            If ISTMessageBox.Show("View with that name already exists! ALTER?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                txtSqlPom = "ALTER VIEW " + _bTableName.Text + " AS " + vbNewLine + vbTab & txtSqlPom
                txtSql.Text = "ALTER VIEW " + _bTableName.Text + " AS " + vbNewLine + vbTab & txtSql.Text
                txt = "Alter view"
            Else
                ISTMessageBox.Show("View with that name already exists!")
                    _bTableName.Visible = True
                    _bTableName.Focus()
                    Exit Sub
                End If

            End If

            Dim strsql As String = txtSqlPom
        If iinsertinto = True Then
            If _bTableName.Text <> "" Then
                Dim mm() As String = txtSqlPom.Split("&")
                If mm.GetUpperBound(0) > 0 Then 'vec je bilo into
                    txtSqlPom = mm(0) + mm(2)
                End If
                Dim pp() As String = txtSqlPom.Split("$")
                'txtSqlPom = pp(0) & ",'" & GetUserNameIzBaze(Me.DBConnectionString) & "' as user_insert,'" & DateTime.Now() & "' as date_insert &INTO " + _bTableName.Text + vbNewLine + vbTab & "&$" + pp(1) + "$" + vbNewLine + vbTab + pp(2)
                'txtSql.Text = pp(0) & ",'" & GetUserNameIzBaze(Me.DBConnectionString) & "'  as user_insert,'" & DateTime.Now() & "' as date_insert  INTO " + _bTableName.Text + vbNewLine + vbTab + pp(1) + vbNewLine + vbTab + pp(2)
                txtSqlPom = pp(0) & " &INTO " + _bTableName.Text + vbNewLine + vbTab & "&$" + pp(1) + "$" + vbNewLine + vbTab + pp(2)
                txtSql.Text = pp(0) & " INTO " + _bTableName.Text + vbNewLine + vbTab + pp(1) + vbNewLine + vbTab + pp(2)

                txt = "Create table"
            End If '
        End If

        If aappend = True Then
            txtSql.Text = "INSERT INTO" & _bTableName.Text & vbNewLine + vbTab & txtSql.Text
            txtSqlPom = "INSERT INTO" & _bTableName.Text & vbNewLine + vbTab & txtSqlPom
            txt = "Append rows"
        End If

        If aasview = True Then
            If _bTableName.Text <> "" Then
                txtSqlPom = "CREATE VIEW " + _bTableName.Text + " AS " + vbNewLine + vbTab & txtSqlPom
                txtSql.Text = "CREATE VIEW " + _bTableName.Text + " AS " + vbNewLine + vbTab & txtSql.Text
                txt = "Create view"
            End If
        End If

        Dim ok1 As String = izvrsiSQL(txtSql.Text, Me.DBConnectionString)
        If ok1 <> "ok" Then
            ISTMessageBox.Show(txtSql.Text + nvrd + nvrd + "is not executed! ER96", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Call UpisiUISTLogKoriscenjaProcesa("Query designer - " + txt, _bTableName.Text, txtSql.Text)

        If iinsertinto = True OrElse aasview = True Then
            Me._builder = New QueryBuilder(New OleDbSchema, Me.istTabele)
            Me._builder.ConnectionString = DBConnectionString
            AddHandler Me._builder.QueryFields.ListChanged, New ListChangedEventHandler(AddressOf Me.QueryFields_ListChanged)
            Me.UpdateTableTree()
            Call clearaLL()
        End If


        _bTableName.Text = ""
        Me._bRun.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default

        Me._treeTables.Focus()


    End Sub

    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, Optional ByVal izvestaj As String = "", Optional ByVal upit As String = "")
        Dim sifist As String = Me.mrist.SIFIST
        Dim god As String = Me.vt.G.ToString
        Dim mes As String = String.Format("{0:d2}", Me.vt.M)
        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
                & "(SifIst,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
                & " values( " _
                & "N'" & sifist & "','" & god & "','" & mes & "'," _
                & "'" & proces & "',N'" + izvestaj & "','" + upit & "'," _
                & "N'" & GetUserNameIzBaze(Me.DBConnectionString).ToString.Trim & "'," _
                & "" & "(select top 1 GETDATE())" & ");" + nvrd

        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.konDepo)

        Dim ok1 As String = izvrsiSQL(strSQL, konDepo)
        If ok1 <> "ok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER96", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Private Sub _bAppend1_Click(sender As Object, e As EventArgs) Handles _bAppend1.Click
        iinsertinto = False
        aappend = True
        aasview = False
    End Sub

    Private Sub _bExcel1_Click(sender As Object, e As EventArgs) Handles _bExcel1.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim dt As DataTable = DirectCast(_gridPreview.DataSource, DataTable).Copy
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Export2Excel_DGV(lokalno, ds, Me.jezik, True, strRes, konDepo)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub _bXml1_Click(sender As Object, e As EventArgs) Handles _bXml1.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim dt As DataTable = DirectCast(_gridPreview.DataSource, DataTable).Copy
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim datumVreme As String = Now.ToShortDateString.Trim.Replace("/", "") & "_" & Now.ToShortTimeString.Trim.Replace(":", "")
            Export2XML_DGV(datumVreme.Trim, lokalno, ds, Me.jezik, True, strRes, konDepo)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub _bJson1_Click(sender As Object, e As EventArgs) Handles _bJson1.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim dt As DataTable = DirectCast(_gridPreview.DataSource, DataTable).Copy
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim datumVreme As String = Now.ToShortDateString.Trim.Replace("/", "") & "_" & Now.ToShortTimeString.Trim.Replace(":", "")
            Export2JSON_DGV(datumVreme.Trim, lokalno, ds, Me.jezik, True, strRes, konDepo)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub _bTableName_Leave(sender As Object, e As EventArgs) Handles _bTableName.Leave
        If _bTableName.Text <> "" Then
            _bRun.Visible = True
        End If
    End Sub


End Class