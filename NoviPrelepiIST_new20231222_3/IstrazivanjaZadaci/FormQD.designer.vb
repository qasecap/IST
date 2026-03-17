<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormQD


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormQD))
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
        Me._treeTables = New System.Windows.Forms.TreeView()
        Me._mnuTree = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me._mnuHideThisTable = New System.Windows.Forms.ToolStripMenuItem()
        Me._mnuShowAllTables = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me._mnuDropThisTable = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me._bRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitContainer2 = New System.Windows.Forms.SplitContainer()
        Me._grid = New System.Windows.Forms.DataGridView()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me._gridPreview = New System.Windows.Forms.DataGridView()
        Me.txtSql = New System.Windows.Forms.TextBox()
        Me._toolStrip = New System.Windows.Forms.ToolStrip()
        Me._btnGroupBy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me._btnProperties = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me._bJoin = New System.Windows.Forms.ToolStripSplitButton()
        Me._bAddJ = New System.Windows.Forms.ToolStripMenuItem()
        Me._bRemoveJ = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me._btnCheckSql = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me._btnViewResults = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me._bExport = New System.Windows.Forms.ToolStripDropDownButton()
        Me._bExcel1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._bXml1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._bJson1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me._bSave = New System.Windows.Forms.ToolStripDropDownButton()
        Me._bNewTable1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._bAppend1 = New System.Windows.Forms.ToolStripMenuItem()
        Me._bAsView = New System.Windows.Forms.ToolStripMenuItem()
        Me._bTableName = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me._bRun = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._btnClearQuery = New System.Windows.Forms.ToolStripButton()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me._lblStatus = New System.Windows.Forms.Label()
        Me._btnCancel = New System.Windows.Forms.Button()
        Me._btnOK = New System.Windows.Forms.Button()
        Me._imgList = New System.Windows.Forms.ImageList(Me.components)
        Me._timer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me._mnuTree.SuspendLayout()
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer2.Panel1.SuspendLayout()
        Me.splitContainer2.Panel2.SuspendLayout()
        Me.splitContainer2.SuspendLayout()
        CType(Me._grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me._gridPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._toolStrip.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.splitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me._treeTables)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.splitContainer2)
        Me.splitContainer1.Size = New System.Drawing.Size(1205, 525)
        Me.splitContainer1.SplitterDistance = 233
        Me.splitContainer1.SplitterWidth = 3
        Me.splitContainer1.TabIndex = 5
        '
        '_treeTables
        '
        Me._treeTables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._treeTables.ContextMenuStrip = Me._mnuTree
        Me._treeTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me._treeTables.Location = New System.Drawing.Point(0, 0)
        Me._treeTables.Margin = New System.Windows.Forms.Padding(2)
        Me._treeTables.Name = "_treeTables"
        Me._treeTables.Size = New System.Drawing.Size(233, 525)
        Me._treeTables.TabIndex = 0
        '
        '_mnuTree
        '
        Me._mnuTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._mnuHideThisTable, Me._mnuShowAllTables, Me.toolStripMenuItem1, Me._mnuDropThisTable, Me.ToolStripSeparator3, Me._bRefresh})
        Me._mnuTree.Name = "_mnuTree"
        Me._mnuTree.Size = New System.Drawing.Size(208, 104)
        '
        '_mnuHideThisTable
        '
        Me._mnuHideThisTable.Name = "_mnuHideThisTable"
        Me._mnuHideThisTable.Size = New System.Drawing.Size(207, 22)
        Me._mnuHideThisTable.Text = "Hide this object"
        '
        '_mnuShowAllTables
        '
        Me._mnuShowAllTables.Name = "_mnuShowAllTables"
        Me._mnuShowAllTables.Size = New System.Drawing.Size(207, 22)
        Me._mnuShowAllTables.Text = "Show all tables and views"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(204, 6)
        '
        '_mnuDropThisTable
        '
        Me._mnuDropThisTable.Name = "_mnuDropThisTable"
        Me._mnuDropThisTable.Size = New System.Drawing.Size(207, 22)
        Me._mnuDropThisTable.Text = "Drop object"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(204, 6)
        '
        '_bRefresh
        '
        Me._bRefresh.Name = "_bRefresh"
        Me._bRefresh.Size = New System.Drawing.Size(207, 22)
        Me._bRefresh.Text = "Refresh"
        '
        'splitContainer2
        '
        Me.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.splitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer2.Margin = New System.Windows.Forms.Padding(2)
        Me.splitContainer2.Name = "splitContainer2"
        Me.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitContainer2.Panel1
        '
        Me.splitContainer2.Panel1.Controls.Add(Me._grid)
        '
        'splitContainer2.Panel2
        '
        Me.splitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.splitContainer2.Size = New System.Drawing.Size(969, 525)
        Me.splitContainer2.SplitterDistance = 83
        Me.splitContainer2.SplitterWidth = 3
        Me.splitContainer2.TabIndex = 0
        '
        '_grid
        '
        Me._grid.AllowDrop = True
        Me._grid.AllowUserToAddRows = False
        Me._grid.AllowUserToResizeRows = False
        Me._grid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me._grid.Location = New System.Drawing.Point(0, 0)
        Me._grid.Margin = New System.Windows.Forms.Padding(2)
        Me._grid.MultiSelect = False
        Me._grid.Name = "_grid"
        Me._grid.RowTemplate.Height = 24
        Me._grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me._grid.Size = New System.Drawing.Size(969, 83)
        Me._grid.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me._gridPreview)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.txtSql)
        Me.SplitContainer3.Size = New System.Drawing.Size(969, 439)
        Me.SplitContainer3.SplitterDistance = 251
        Me.SplitContainer3.TabIndex = 1
        '
        '_gridPreview
        '
        Me._gridPreview.AllowDrop = True
        Me._gridPreview.AllowUserToAddRows = False
        Me._gridPreview.AllowUserToDeleteRows = False
        Me._gridPreview.AllowUserToOrderColumns = True
        Me._gridPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me._gridPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me._gridPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me._gridPreview.Location = New System.Drawing.Point(0, 0)
        Me._gridPreview.Margin = New System.Windows.Forms.Padding(2)
        Me._gridPreview.MultiSelect = False
        Me._gridPreview.Name = "_gridPreview"
        Me._gridPreview.RowTemplate.Height = 24
        Me._gridPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me._gridPreview.Size = New System.Drawing.Size(969, 251)
        Me._gridPreview.TabIndex = 1
        '
        'txtSql
        '
        Me.txtSql.BackColor = System.Drawing.SystemColors.Window
        Me.txtSql.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSql.Location = New System.Drawing.Point(0, 0)
        Me.txtSql.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSql.Multiline = True
        Me.txtSql.Name = "txtSql"
        Me.txtSql.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtSql.Size = New System.Drawing.Size(969, 184)
        Me.txtSql.TabIndex = 1
        Me.txtSql.WordWrap = False
        '
        '_toolStrip
        '
        Me._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me._toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._btnGroupBy, Me.ToolStripSeparator7, Me._btnProperties, Me.toolStripSeparator1, Me._bJoin, Me.ToolStripLabel2, Me.ToolStripSeparator4, Me._btnCheckSql, Me.ToolStripSeparator8, Me._btnViewResults, Me.ToolStripSeparator6, Me._bExport, Me.ToolStripSeparator5, Me._bSave, Me._bTableName, Me.ToolStripLabel1, Me.ToolStripSeparator9, Me.ToolStripLabel4, Me._bRun, Me.ToolStripLabel3, Me.toolStripSeparator2, Me._btnClearQuery})
        Me._toolStrip.Location = New System.Drawing.Point(0, 0)
        Me._toolStrip.Name = "_toolStrip"
        Me._toolStrip.Size = New System.Drawing.Size(1205, 25)
        Me._toolStrip.TabIndex = 4
        Me._toolStrip.Text = "toolStrip1"
        '
        '_btnGroupBy
        '
        Me._btnGroupBy.Image = CType(resources.GetObject("_btnGroupBy.Image"), System.Drawing.Image)
        Me._btnGroupBy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnGroupBy.Name = "_btnGroupBy"
        Me._btnGroupBy.Size = New System.Drawing.Size(97, 22)
        Me._btnGroupBy.Text = "Group results"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        '_btnProperties
        '
        Me._btnProperties.Image = CType(resources.GetObject("_btnProperties.Image"), System.Drawing.Image)
        Me._btnProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnProperties.Name = "_btnProperties"
        Me._btnProperties.Size = New System.Drawing.Size(118, 22)
        Me._btnProperties.Text = " Query properties"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        '_bJoin
        '
        Me._bJoin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._bJoin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._bAddJ, Me._bRemoveJ})
        Me._bJoin.Image = CType(resources.GetObject("_bJoin.Image"), System.Drawing.Image)
        Me._bJoin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._bJoin.Name = "_bJoin"
        Me._bJoin.Size = New System.Drawing.Size(78, 22)
        Me._bJoin.Text = "Join tables"
        '
        '_bAddJ
        '
        Me._bAddJ.Name = "_bAddJ"
        Me._bAddJ.Size = New System.Drawing.Size(180, 22)
        Me._bAddJ.Text = "Add"
        '
        '_bRemoveJ
        '
        Me._bRemoveJ.Name = "_bRemoveJ"
        Me._bRemoveJ.Size = New System.Drawing.Size(180, 22)
        Me._bRemoveJ.Text = "Remove"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        '_btnCheckSql
        '
        Me._btnCheckSql.Image = CType(resources.GetObject("_btnCheckSql.Image"), System.Drawing.Image)
        Me._btnCheckSql.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnCheckSql.Name = "_btnCheckSql"
        Me._btnCheckSql.Size = New System.Drawing.Size(121, 22)
        Me._btnCheckSql.Text = "Check SQL syntax"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        '_btnViewResults
        '
        Me._btnViewResults.Image = CType(resources.GetObject("_btnViewResults.Image"), System.Drawing.Image)
        Me._btnViewResults.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnViewResults.Name = "_btnViewResults"
        Me._btnViewResults.Size = New System.Drawing.Size(122, 22)
        Me._btnViewResults.Text = "View query results"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        '_bExport
        '
        Me._bExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._bExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._bExcel1, Me._bXml1, Me._bJson1})
        Me._bExport.Image = CType(resources.GetObject("_bExport.Image"), System.Drawing.Image)
        Me._bExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._bExport.Name = "_bExport"
        Me._bExport.Size = New System.Drawing.Size(77, 22)
        Me._bExport.Text = "Export to:  "
        '
        '_bExcel1
        '
        Me._bExcel1.Name = "_bExcel1"
        Me._bExcel1.Size = New System.Drawing.Size(180, 22)
        Me._bExcel1.Text = "Excel"
        '
        '_bXml1
        '
        Me._bXml1.Name = "_bXml1"
        Me._bXml1.Size = New System.Drawing.Size(180, 22)
        Me._bXml1.Text = "Xml"
        '
        '_bJson1
        '
        Me._bJson1.Name = "_bJson1"
        Me._bJson1.Size = New System.Drawing.Size(180, 22)
        Me._bJson1.Text = "JSON"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        '_bSave
        '
        Me._bSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._bSave.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._bNewTable1, Me._bAppend1, Me._bAsView})
        Me._bSave.Image = CType(resources.GetObject("_bSave.Image"), System.Drawing.Image)
        Me._bSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._bSave.Name = "_bSave"
        Me._bSave.Size = New System.Drawing.Size(83, 22)
        Me._bSave.Text = "Save in db:  "
        '
        '_bNewTable1
        '
        Me._bNewTable1.Name = "_bNewTable1"
        Me._bNewTable1.Size = New System.Drawing.Size(203, 22)
        Me._bNewTable1.Text = "In new table"
        '
        '_bAppend1
        '
        Me._bAppend1.Name = "_bAppend1"
        Me._bAppend1.Size = New System.Drawing.Size(203, 22)
        Me._bAppend1.Text = "Append to existing table"
        '
        '_bAsView
        '
        Me._bAsView.Name = "_bAsView"
        Me._bAsView.Size = New System.Drawing.Size(203, 22)
        Me._bAsView.Text = "As view"
        '
        '_bTableName
        '
        Me._bTableName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me._bTableName.Name = "_bTableName"
        Me._bTableName.Size = New System.Drawing.Size(100, 25)
        Me._bTableName.Visible = False
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        '_bRun
        '
        Me._bRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me._bRun.Image = CType(resources.GetObject("_bRun.Image"), System.Drawing.Image)
        Me._bRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._bRun.Name = "_bRun"
        Me._bRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me._bRun.Size = New System.Drawing.Size(32, 22)
        Me._bRun.Text = "Run"
        Me._bRun.ToolTipText = "Execute sql command"
        Me._bRun.Visible = False
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        '_btnClearQuery
        '
        Me._btnClearQuery.Image = CType(resources.GetObject("_btnClearQuery.Image"), System.Drawing.Image)
        Me._btnClearQuery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnClearQuery.Name = "_btnClearQuery"
        Me._btnClearQuery.Size = New System.Drawing.Size(87, 22)
        Me._btnClearQuery.Text = "Clear query"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me._lblStatus)
        Me.panel1.Controls.Add(Me._btnCancel)
        Me.panel1.Controls.Add(Me._btnOK)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Location = New System.Drawing.Point(0, 550)
        Me.panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1205, 33)
        Me.panel1.TabIndex = 6
        '
        '_lblStatus
        '
        Me._lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._lblStatus.Location = New System.Drawing.Point(10, 6)
        Me._lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me._lblStatus.Name = "_lblStatus"
        Me._lblStatus.Size = New System.Drawing.Size(1035, 22)
        Me._lblStatus.TabIndex = 8
        Me._lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '_btnCancel
        '
        Me._btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._btnCancel.Location = New System.Drawing.Point(1126, 6)
        Me._btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(70, 22)
        Me._btnCancel.TabIndex = 7
        Me._btnCancel.Text = "Cancel"
        Me._btnCancel.UseVisualStyleBackColor = True
        '
        '_btnOK
        '
        Me._btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me._btnOK.Location = New System.Drawing.Point(1050, 6)
        Me._btnOK.Margin = New System.Windows.Forms.Padding(2)
        Me._btnOK.Name = "_btnOK"
        Me._btnOK.Size = New System.Drawing.Size(70, 22)
        Me._btnOK.TabIndex = 6
        Me._btnOK.Text = "OK"
        Me._btnOK.UseVisualStyleBackColor = True
        '
        '_imgList
        '
        Me._imgList.ImageStream = CType(resources.GetObject("_imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me._imgList.TransparentColor = System.Drawing.Color.Red
        Me._imgList.Images.SetKeyName(0, "Table.png")
        Me._imgList.Images.SetKeyName(1, "View.png")
        Me._imgList.Images.SetKeyName(2, "Field.png")
        '
        '_timer
        '
        Me._timer.Interval = 10
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(16, 22)
        Me.ToolStripLabel1.Text = "   "
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel2.Text = "     "
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel3.Text = "     "
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(22, 22)
        Me.ToolStripLabel4.Text = "     "
        '
        'FormQD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1205, 583)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me._toolStrip)
        Me.Controls.Add(Me.panel1)
        Me.Name = "FormQD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Query Designer"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        CType(Me.splitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer1.ResumeLayout(False)
        Me._mnuTree.ResumeLayout(False)
        Me.splitContainer2.Panel1.ResumeLayout(False)
        Me.splitContainer2.Panel2.ResumeLayout(False)
        CType(Me.splitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer2.ResumeLayout(False)
        CType(Me._grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.Panel2.PerformLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me._gridPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me._toolStrip.ResumeLayout(False)
        Me._toolStrip.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents _treeTables As System.Windows.Forms.TreeView
    Private WithEvents splitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents _grid As System.Windows.Forms.DataGridView
    Private WithEvents _toolStrip As System.Windows.Forms.ToolStrip
    Private WithEvents _btnGroupBy As System.Windows.Forms.ToolStripButton
    Private WithEvents _btnProperties As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents _btnCheckSql As System.Windows.Forms.ToolStripButton
    Private WithEvents _btnViewResults As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents _btnClearQuery As System.Windows.Forms.ToolStripButton
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents _lblStatus As System.Windows.Forms.Label
    Private WithEvents _btnCancel As System.Windows.Forms.Button
    Private WithEvents _btnOK As System.Windows.Forms.Button
    Private WithEvents _imgList As System.Windows.Forms.ImageList
    Private WithEvents _timer As System.Windows.Forms.Timer
    Private WithEvents _mnuTree As System.Windows.Forms.ContextMenuStrip
    Private WithEvents _mnuHideThisTable As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _mnuShowAllTables As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Private WithEvents txtSql As System.Windows.Forms.TextBox
    Private WithEvents _gridPreview As System.Windows.Forms.DataGridView
    Friend WithEvents _bTableName As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents _bRun As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _bJoin As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents _bAddJ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _bRemoveJ As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _bExport As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents _bExcel1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _bXml1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _bJson1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _bSave As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents _bNewTable1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _bAppend1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _bAsView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _mnuDropThisTable As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents _bRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
End Class
