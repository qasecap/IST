Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormAdvancedUpdating
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Friend WithEvents ButtonISTIzlaz As Button
    Friend WithEvents mnuNumber As ContextMenuStrip
    Friend WithEvents nHide As ToolStripMenuItem
    Friend WithEvents nUnHide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents nSort As ToolStripMenuItem
    Friend WithEvents nMultiColumnSort As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents nFind As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As ToolStripSeparator
    Friend WithEvents nEquals As ToolStripMenuItem
    Friend WithEvents nUnFilter As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator21 As ToolStripSeparator
    Friend WithEvents nNotEqual As ToolStripMenuItem
    Friend WithEvents nGreaterThan As ToolStripMenuItem
    Friend WithEvents nLessThan As ToolStripMenuItem
    Friend WithEvents nGreaterThanOrEqual As ToolStripMenuItem
    Friend WithEvents mnuString As ContextMenuStrip
    Friend WithEvents sHide As ToolStripMenuItem
    Friend WithEvents sUnHide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents sSort As ToolStripMenuItem
    Friend WithEvents sMultiColumnSort As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents sFind As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents sUnFilter As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents nLessThanOrEqual As ToolStripMenuItem
    Friend WithEvents sEquals As ToolStripMenuItem
    Friend WithEvents sNotEqual As ToolStripMenuItem
    Friend WithEvents sContains As ToolStripMenuItem
    Friend WithEvents sNotContain As ToolStripMenuItem
    Friend WithEvents sBeginsWith As ToolStripMenuItem
    Friend WithEvents sNotBeginWith As ToolStripMenuItem
    Friend WithEvents sEndsWith As ToolStripMenuItem
    Friend WithEvents tt As TextBox
    Friend WithEvents lblDistinctCount As Label
    Friend WithEvents txtSQLUpdate As TextBox
    Friend WithEvents lblApp As Label
    Friend WithEvents lbltabelaB As Label
    Friend WithEvents ucvtB As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents clbTabelaB As CheckedListBox
    Friend WithEvents txtTabelaB As TextBox
    Friend WithEvents bDownTB As PictureBox
    Friend WithEvents clbFilterB As CheckedListBox
    Friend WithEvents clbAppB As CheckedListBox
    Friend WithEvents bDownAppB As PictureBox
    Friend WithEvents txtAppB As TextBox
    Friend WithEvents ButtonFieldB As Button
    Friend WithEvents panelTabelaB As Panel
    Friend WithEvents panelCondition As Panel
    Friend WithEvents cbOR2 As CheckBox
    Friend WithEvents cbOR1 As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblF4 As Label
    Friend WithEvents bUpdate As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents bReset As Button
    Friend WithEvents panelTabelaA As Panel
    Friend WithEvents ucvtA As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents txtAppA As TextBox
    Friend WithEvents bAddTableB As Button
    Friend WithEvents bDownAppA As PictureBox
    Friend WithEvents clbAppA As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clbTabelaA As CheckedListBox
    Friend WithEvents txtTabelaA As TextBox
    Friend WithEvents bDownTA As PictureBox
    Friend WithEvents clbFilterA As CheckedListBox
    Friend WithEvents ButtonFieldA As Button
    Friend WithEvents lbltabelaA As Label
    Friend WithEvents TLP As TableLayoutPanel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents bJoin As Button
    Friend WithEvents bSQL As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelTabelaD As Panel
    Friend WithEvents ButtonFieldD As Button
    Friend WithEvents txtAppD As TextBox
    Friend WithEvents bDownAppD As PictureBox
    Friend WithEvents clbAppD As CheckedListBox
    Friend WithEvents clbFilterD As CheckedListBox
    Friend WithEvents bDownTD As PictureBox
    Friend WithEvents txtTabelaD As TextBox
    Friend WithEvents clbTabelaD As CheckedListBox
    Friend WithEvents ucvtD As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents panelTabelaC As Panel
    Friend WithEvents ButtonFieldC As Button
    Friend WithEvents txtAppC As TextBox
    Friend WithEvents bDownAppC As PictureBox
    Friend WithEvents clbAppC As CheckedListBox
    Friend WithEvents clbFilterC As CheckedListBox
    Friend WithEvents bDownTC As PictureBox
    Friend WithEvents txtTabelaC As TextBox
    Friend WithEvents clbTabelaC As CheckedListBox
    Friend WithEvents ucvtC As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents bRemoveTableB As Button
    Friend WithEvents bAddTableC As Button
    Friend WithEvents bRemoveTableD As Button
    Friend WithEvents bRemoveTableC As Button
    Friend WithEvents bAddTableD As Button
    Friend WithEvents nNotEndWith As ToolStripMenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdvancedUpdating))
        Me.ButtonISTIzlaz = New System.Windows.Forms.Button()
        Me.mnuNumber = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.nHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.nUnHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.nSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.nMultiColumnSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.nFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.nEquals = New System.Windows.Forms.ToolStripMenuItem()
        Me.nNotEqual = New System.Windows.Forms.ToolStripMenuItem()
        Me.nGreaterThan = New System.Windows.Forms.ToolStripMenuItem()
        Me.nGreaterThanOrEqual = New System.Windows.Forms.ToolStripMenuItem()
        Me.nLessThan = New System.Windows.Forms.ToolStripMenuItem()
        Me.nLessThanOrEqual = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.nUnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuString = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.sHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.sUnHide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.sSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.sMultiColumnSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.sFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.sEquals = New System.Windows.Forms.ToolStripMenuItem()
        Me.sNotEqual = New System.Windows.Forms.ToolStripMenuItem()
        Me.sContains = New System.Windows.Forms.ToolStripMenuItem()
        Me.sNotContain = New System.Windows.Forms.ToolStripMenuItem()
        Me.sBeginsWith = New System.Windows.Forms.ToolStripMenuItem()
        Me.sNotBeginWith = New System.Windows.Forms.ToolStripMenuItem()
        Me.sEndsWith = New System.Windows.Forms.ToolStripMenuItem()
        Me.nNotEndWith = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.sUnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.tt = New System.Windows.Forms.TextBox()
        Me.lblDistinctCount = New System.Windows.Forms.Label()
        Me.txtSQLUpdate = New System.Windows.Forms.TextBox()
        Me.panelTabelaB = New System.Windows.Forms.Panel()
        Me.bRemoveTableB = New System.Windows.Forms.Button()
        Me.bAddTableC = New System.Windows.Forms.Button()
        Me.ButtonFieldB = New System.Windows.Forms.Button()
        Me.txtAppB = New System.Windows.Forms.TextBox()
        Me.bDownAppB = New System.Windows.Forms.PictureBox()
        Me.clbAppB = New System.Windows.Forms.CheckedListBox()
        Me.clbFilterB = New System.Windows.Forms.CheckedListBox()
        Me.bDownTB = New System.Windows.Forms.PictureBox()
        Me.txtTabelaB = New System.Windows.Forms.TextBox()
        Me.clbTabelaB = New System.Windows.Forms.CheckedListBox()
        Me.ucvtB = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.lbltabelaB = New System.Windows.Forms.Label()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.panelCondition = New System.Windows.Forms.Panel()
        Me.cbOR2 = New System.Windows.Forms.CheckBox()
        Me.cbOR1 = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblF4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bUpdate = New System.Windows.Forms.Button()
        Me.bReset = New System.Windows.Forms.Button()
        Me.panelTabelaA = New System.Windows.Forms.Panel()
        Me.ucvtA = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.txtAppA = New System.Windows.Forms.TextBox()
        Me.bAddTableB = New System.Windows.Forms.Button()
        Me.bDownAppA = New System.Windows.Forms.PictureBox()
        Me.clbAppA = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbTabelaA = New System.Windows.Forms.CheckedListBox()
        Me.txtTabelaA = New System.Windows.Forms.TextBox()
        Me.bDownTA = New System.Windows.Forms.PictureBox()
        Me.clbFilterA = New System.Windows.Forms.CheckedListBox()
        Me.ButtonFieldA = New System.Windows.Forms.Button()
        Me.lbltabelaA = New System.Windows.Forms.Label()
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.panelTabelaD = New System.Windows.Forms.Panel()
        Me.bRemoveTableD = New System.Windows.Forms.Button()
        Me.ButtonFieldD = New System.Windows.Forms.Button()
        Me.txtAppD = New System.Windows.Forms.TextBox()
        Me.bDownAppD = New System.Windows.Forms.PictureBox()
        Me.clbAppD = New System.Windows.Forms.CheckedListBox()
        Me.clbFilterD = New System.Windows.Forms.CheckedListBox()
        Me.bDownTD = New System.Windows.Forms.PictureBox()
        Me.txtTabelaD = New System.Windows.Forms.TextBox()
        Me.clbTabelaD = New System.Windows.Forms.CheckedListBox()
        Me.ucvtD = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.panelTabelaC = New System.Windows.Forms.Panel()
        Me.bRemoveTableC = New System.Windows.Forms.Button()
        Me.bAddTableD = New System.Windows.Forms.Button()
        Me.ButtonFieldC = New System.Windows.Forms.Button()
        Me.txtAppC = New System.Windows.Forms.TextBox()
        Me.bDownAppC = New System.Windows.Forms.PictureBox()
        Me.clbAppC = New System.Windows.Forms.CheckedListBox()
        Me.clbFilterC = New System.Windows.Forms.CheckedListBox()
        Me.bDownTC = New System.Windows.Forms.PictureBox()
        Me.txtTabelaC = New System.Windows.Forms.TextBox()
        Me.clbTabelaC = New System.Windows.Forms.CheckedListBox()
        Me.ucvtC = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bJoin = New System.Windows.Forms.Button()
        Me.bSQL = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuNumber.SuspendLayout()
        Me.mnuString.SuspendLayout()
        Me.panelTabelaB.SuspendLayout()
        CType(Me.bDownAppB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDownTB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCondition.SuspendLayout()
        Me.panelTabelaA.SuspendLayout()
        CType(Me.bDownAppA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDownTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP.SuspendLayout()
        Me.panelTabelaD.SuspendLayout()
        CType(Me.bDownAppD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDownTD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTabelaC.SuspendLayout()
        CType(Me.bDownAppC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDownTC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonISTIzlaz
        '
        Me.ButtonISTIzlaz.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonISTIzlaz.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonISTIzlaz.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonISTIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonISTIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonISTIzlaz.Location = New System.Drawing.Point(1297, 3)
        Me.ButtonISTIzlaz.Name = "ButtonISTIzlaz"
        Me.ButtonISTIzlaz.Size = New System.Drawing.Size(70, 24)
        Me.ButtonISTIzlaz.TabIndex = 59
        Me.ButtonISTIzlaz.Text = "Излаз"
        Me.ButtonISTIzlaz.UseVisualStyleBackColor = False
        '
        'mnuNumber
        '
        Me.mnuNumber.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuNumber.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nHide, Me.nUnHide, Me.ToolStripSeparator17, Me.nSort, Me.nMultiColumnSort, Me.ToolStripSeparator18, Me.nFind, Me.ToolStripSeparator19, Me.nEquals, Me.nNotEqual, Me.nGreaterThan, Me.nGreaterThanOrEqual, Me.nLessThan, Me.nLessThanOrEqual, Me.ToolStripSeparator21, Me.nUnFilter})
        Me.mnuNumber.Name = "mnuColumn"
        Me.mnuNumber.ShowCheckMargin = True
        Me.mnuNumber.Size = New System.Drawing.Size(221, 292)
        '
        'nHide
        '
        Me.nHide.Name = "nHide"
        Me.nHide.Size = New System.Drawing.Size(220, 22)
        Me.nHide.Text = "Hide column"
        '
        'nUnHide
        '
        Me.nUnHide.Name = "nUnHide"
        Me.nUnHide.Size = New System.Drawing.Size(220, 22)
        Me.nUnHide.Text = "Unhide all"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(217, 6)
        '
        'nSort
        '
        Me.nSort.Name = "nSort"
        Me.nSort.Size = New System.Drawing.Size(220, 22)
        Me.nSort.Text = "Sort"
        Me.nSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'nMultiColumnSort
        '
        Me.nMultiColumnSort.Name = "nMultiColumnSort"
        Me.nMultiColumnSort.Size = New System.Drawing.Size(220, 22)
        Me.nMultiColumnSort.Text = "Multi column sort"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(217, 6)
        '
        'nFind
        '
        Me.nFind.Name = "nFind"
        Me.nFind.Size = New System.Drawing.Size(220, 22)
        Me.nFind.Text = "Find"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(217, 6)
        '
        'nEquals
        '
        Me.nEquals.Name = "nEquals"
        Me.nEquals.Size = New System.Drawing.Size(220, 22)
        Me.nEquals.Text = "Equals"
        '
        'nNotEqual
        '
        Me.nNotEqual.Name = "nNotEqual"
        Me.nNotEqual.Size = New System.Drawing.Size(220, 22)
        Me.nNotEqual.Text = "Does not equal"
        '
        'nGreaterThan
        '
        Me.nGreaterThan.Name = "nGreaterThan"
        Me.nGreaterThan.Size = New System.Drawing.Size(220, 22)
        Me.nGreaterThan.Text = "Greater than"
        '
        'nGreaterThanOrEqual
        '
        Me.nGreaterThanOrEqual.Name = "nGreaterThanOrEqual"
        Me.nGreaterThanOrEqual.Size = New System.Drawing.Size(220, 22)
        Me.nGreaterThanOrEqual.Text = "Greater than or equal"
        '
        'nLessThan
        '
        Me.nLessThan.Name = "nLessThan"
        Me.nLessThan.Size = New System.Drawing.Size(220, 22)
        Me.nLessThan.Text = "Less than"
        '
        'nLessThanOrEqual
        '
        Me.nLessThanOrEqual.Name = "nLessThanOrEqual"
        Me.nLessThanOrEqual.Size = New System.Drawing.Size(220, 22)
        Me.nLessThanOrEqual.Text = "Less than or equal"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(217, 6)
        '
        'nUnFilter
        '
        Me.nUnFilter.Name = "nUnFilter"
        Me.nUnFilter.Size = New System.Drawing.Size(220, 22)
        Me.nUnFilter.Text = "Show all"
        '
        'mnuString
        '
        Me.mnuString.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuString.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sHide, Me.sUnHide, Me.ToolStripSeparator1, Me.sSort, Me.sMultiColumnSort, Me.ToolStripSeparator2, Me.sFind, Me.ToolStripSeparator3, Me.sEquals, Me.sNotEqual, Me.sContains, Me.sNotContain, Me.sBeginsWith, Me.sNotBeginWith, Me.sEndsWith, Me.nNotEndWith, Me.ToolStripSeparator4, Me.sUnFilter})
        Me.mnuString.Name = "mnuColumn"
        Me.mnuString.ShowCheckMargin = True
        Me.mnuString.Size = New System.Drawing.Size(210, 336)
        '
        'sHide
        '
        Me.sHide.Name = "sHide"
        Me.sHide.Size = New System.Drawing.Size(209, 22)
        Me.sHide.Text = "Hide column"
        '
        'sUnHide
        '
        Me.sUnHide.Name = "sUnHide"
        Me.sUnHide.Size = New System.Drawing.Size(209, 22)
        Me.sUnHide.Text = "Unhide all"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(206, 6)
        '
        'sSort
        '
        Me.sSort.Name = "sSort"
        Me.sSort.Size = New System.Drawing.Size(209, 22)
        Me.sSort.Text = "Sort"
        Me.sSort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'sMultiColumnSort
        '
        Me.sMultiColumnSort.Name = "sMultiColumnSort"
        Me.sMultiColumnSort.Size = New System.Drawing.Size(209, 22)
        Me.sMultiColumnSort.Text = "Multi column sort"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(206, 6)
        '
        'sFind
        '
        Me.sFind.Name = "sFind"
        Me.sFind.Size = New System.Drawing.Size(209, 22)
        Me.sFind.Text = "Find"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(206, 6)
        '
        'sEquals
        '
        Me.sEquals.Name = "sEquals"
        Me.sEquals.Size = New System.Drawing.Size(209, 22)
        Me.sEquals.Text = "Equals"
        '
        'sNotEqual
        '
        Me.sNotEqual.Name = "sNotEqual"
        Me.sNotEqual.Size = New System.Drawing.Size(209, 22)
        Me.sNotEqual.Text = "Does not equal"
        '
        'sContains
        '
        Me.sContains.Name = "sContains"
        Me.sContains.Size = New System.Drawing.Size(209, 22)
        Me.sContains.Text = "Contains"
        '
        'sNotContain
        '
        Me.sNotContain.Name = "sNotContain"
        Me.sNotContain.Size = New System.Drawing.Size(209, 22)
        Me.sNotContain.Text = "Does not contain"
        '
        'sBeginsWith
        '
        Me.sBeginsWith.Name = "sBeginsWith"
        Me.sBeginsWith.Size = New System.Drawing.Size(209, 22)
        Me.sBeginsWith.Text = "Begins with"
        '
        'sNotBeginWith
        '
        Me.sNotBeginWith.Name = "sNotBeginWith"
        Me.sNotBeginWith.Size = New System.Drawing.Size(209, 22)
        Me.sNotBeginWith.Text = "Does not begin with"
        '
        'sEndsWith
        '
        Me.sEndsWith.Name = "sEndsWith"
        Me.sEndsWith.Size = New System.Drawing.Size(209, 22)
        Me.sEndsWith.Text = "Ends with"
        '
        'nNotEndWith
        '
        Me.nNotEndWith.Name = "nNotEndWith"
        Me.nNotEndWith.Size = New System.Drawing.Size(209, 22)
        Me.nNotEndWith.Text = "Does not end with"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(206, 6)
        '
        'sUnFilter
        '
        Me.sUnFilter.Name = "sUnFilter"
        Me.sUnFilter.Size = New System.Drawing.Size(209, 22)
        Me.sUnFilter.Text = "Show all"
        '
        'tt
        '
        Me.tt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tt.Enabled = False
        Me.tt.Location = New System.Drawing.Point(0, 727)
        Me.tt.Multiline = True
        Me.tt.Name = "tt"
        Me.tt.Size = New System.Drawing.Size(1370, 22)
        Me.tt.TabIndex = 10000139
        '
        'lblDistinctCount
        '
        Me.TLP.SetColumnSpan(Me.lblDistinctCount, 3)
        Me.lblDistinctCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDistinctCount.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblDistinctCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblDistinctCount.Location = New System.Drawing.Point(619, 635)
        Me.lblDistinctCount.Name = "lblDistinctCount"
        Me.lblDistinctCount.Size = New System.Drawing.Size(748, 32)
        Me.lblDistinctCount.TabIndex = 10000137
        Me.lblDistinctCount.Text = "."
        Me.lblDistinctCount.Visible = False
        '
        'txtSQLUpdate
        '
        Me.txtSQLUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TLP.SetColumnSpan(Me.txtSQLUpdate, 5)
        Me.txtSQLUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQLUpdate.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.txtSQLUpdate.Location = New System.Drawing.Point(3, 670)
        Me.txtSQLUpdate.Multiline = True
        Me.txtSQLUpdate.Name = "txtSQLUpdate"
        Me.txtSQLUpdate.Size = New System.Drawing.Size(1364, 54)
        Me.txtSQLUpdate.TabIndex = 10000318
        '
        'panelTabelaB
        '
        Me.panelTabelaB.AllowDrop = True
        Me.panelTabelaB.Controls.Add(Me.bRemoveTableB)
        Me.panelTabelaB.Controls.Add(Me.bAddTableC)
        Me.panelTabelaB.Controls.Add(Me.ButtonFieldB)
        Me.panelTabelaB.Controls.Add(Me.txtAppB)
        Me.panelTabelaB.Controls.Add(Me.bDownAppB)
        Me.panelTabelaB.Controls.Add(Me.clbAppB)
        Me.panelTabelaB.Controls.Add(Me.clbFilterB)
        Me.panelTabelaB.Controls.Add(Me.bDownTB)
        Me.panelTabelaB.Controls.Add(Me.txtTabelaB)
        Me.panelTabelaB.Controls.Add(Me.clbTabelaB)
        Me.panelTabelaB.Controls.Add(Me.ucvtB)
        Me.panelTabelaB.Controls.Add(Me.lbltabelaB)
        Me.panelTabelaB.Controls.Add(Me.lblApp)
        Me.panelTabelaB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.panelTabelaB.Location = New System.Drawing.Point(311, 3)
        Me.panelTabelaB.Name = "panelTabelaB"
        Me.panelTabelaB.Size = New System.Drawing.Size(302, 286)
        Me.panelTabelaB.TabIndex = 10000278
        Me.panelTabelaB.Visible = False
        '
        'bRemoveTableB
        '
        Me.bRemoveTableB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRemoveTableB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRemoveTableB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bRemoveTableB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRemoveTableB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bRemoveTableB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bRemoveTableB.Location = New System.Drawing.Point(279, 120)
        Me.bRemoveTableB.Margin = New System.Windows.Forms.Padding(0)
        Me.bRemoveTableB.Name = "bRemoveTableB"
        Me.bRemoveTableB.Size = New System.Drawing.Size(21, 21)
        Me.bRemoveTableB.TabIndex = 10000321
        Me.bRemoveTableB.Text = "-"
        Me.bRemoveTableB.UseVisualStyleBackColor = False
        Me.bRemoveTableB.Visible = False
        '
        'bAddTableC
        '
        Me.bAddTableC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddTableC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAddTableC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAddTableC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddTableC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bAddTableC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bAddTableC.Location = New System.Drawing.Point(279, 100)
        Me.bAddTableC.Margin = New System.Windows.Forms.Padding(0)
        Me.bAddTableC.Name = "bAddTableC"
        Me.bAddTableC.Size = New System.Drawing.Size(21, 21)
        Me.bAddTableC.TabIndex = 10000320
        Me.bAddTableC.Text = "+"
        Me.bAddTableC.UseVisualStyleBackColor = False
        Me.bAddTableC.Visible = False
        '
        'ButtonFieldB
        '
        Me.ButtonFieldB.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFieldB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFieldB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFieldB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonFieldB.Image = CType(resources.GetObject("ButtonFieldB.Image"), System.Drawing.Image)
        Me.ButtonFieldB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonFieldB.Location = New System.Drawing.Point(257, 137)
        Me.ButtonFieldB.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFieldB.Name = "ButtonFieldB"
        Me.ButtonFieldB.Size = New System.Drawing.Size(21, 21)
        Me.ButtonFieldB.TabIndex = 10000184
        Me.ButtonFieldB.UseVisualStyleBackColor = False
        Me.ButtonFieldB.Visible = False
        '
        'txtAppB
        '
        Me.txtAppB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAppB.Location = New System.Drawing.Point(45, 63)
        Me.txtAppB.MaxLength = 20
        Me.txtAppB.Name = "txtAppB"
        Me.txtAppB.Size = New System.Drawing.Size(212, 21)
        Me.txtAppB.TabIndex = 10000181
        '
        'bDownAppB
        '
        Me.bDownAppB.BackColor = System.Drawing.Color.Transparent
        Me.bDownAppB.Image = CType(resources.GetObject("bDownAppB.Image"), System.Drawing.Image)
        Me.bDownAppB.Location = New System.Drawing.Point(257, 63)
        Me.bDownAppB.Name = "bDownAppB"
        Me.bDownAppB.Size = New System.Drawing.Size(21, 21)
        Me.bDownAppB.TabIndex = 10000182
        Me.bDownAppB.TabStop = False
        '
        'clbAppB
        '
        Me.clbAppB.BackColor = System.Drawing.SystemColors.Window
        Me.clbAppB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbAppB.CheckOnClick = True
        Me.clbAppB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbAppB.FormattingEnabled = True
        Me.clbAppB.Location = New System.Drawing.Point(45, 83)
        Me.clbAppB.Name = "clbAppB"
        Me.clbAppB.Size = New System.Drawing.Size(212, 18)
        Me.clbAppB.TabIndex = 10000180
        Me.clbAppB.Visible = False
        '
        'clbFilterB
        '
        Me.clbFilterB.BackColor = System.Drawing.SystemColors.Window
        Me.clbFilterB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbFilterB.CheckOnClick = True
        Me.clbFilterB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbFilterB.FormattingEnabled = True
        Me.clbFilterB.Location = New System.Drawing.Point(45, 137)
        Me.clbFilterB.Name = "clbFilterB"
        Me.clbFilterB.Size = New System.Drawing.Size(212, 146)
        Me.clbFilterB.TabIndex = 10000177
        Me.clbFilterB.Visible = False
        '
        'bDownTB
        '
        Me.bDownTB.BackColor = System.Drawing.Color.Transparent
        Me.bDownTB.Image = CType(resources.GetObject("bDownTB.Image"), System.Drawing.Image)
        Me.bDownTB.Location = New System.Drawing.Point(257, 100)
        Me.bDownTB.Name = "bDownTB"
        Me.bDownTB.Size = New System.Drawing.Size(21, 21)
        Me.bDownTB.TabIndex = 10000175
        Me.bDownTB.TabStop = False
        '
        'txtTabelaB
        '
        Me.txtTabelaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTabelaB.Location = New System.Drawing.Point(45, 100)
        Me.txtTabelaB.MaxLength = 20
        Me.txtTabelaB.Name = "txtTabelaB"
        Me.txtTabelaB.Size = New System.Drawing.Size(212, 21)
        Me.txtTabelaB.TabIndex = 10000174
        '
        'clbTabelaB
        '
        Me.clbTabelaB.BackColor = System.Drawing.SystemColors.Window
        Me.clbTabelaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbTabelaB.CheckOnClick = True
        Me.clbTabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbTabelaB.FormattingEnabled = True
        Me.clbTabelaB.Location = New System.Drawing.Point(45, 120)
        Me.clbTabelaB.Name = "clbTabelaB"
        Me.clbTabelaB.Size = New System.Drawing.Size(212, 18)
        Me.clbTabelaB.TabIndex = 10000173
        Me.clbTabelaB.Visible = False
        '
        'ucvtB
        '
        Me.ucvtB.BackColor = System.Drawing.SystemColors.Control
        Me.ucvtB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvtB.Location = New System.Drawing.Point(45, 9)
        Me.ucvtB.Name = "ucvtB"
        Me.ucvtB.Size = New System.Drawing.Size(109, 48)
        Me.ucvtB.TabIndex = 10000176
        Me.ucvtB.TabStop = False
        '
        'lbltabelaB
        '
        Me.lbltabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltabelaB.ForeColor = System.Drawing.Color.Black
        Me.lbltabelaB.Location = New System.Drawing.Point(3, 101)
        Me.lbltabelaB.Name = "lbltabelaB"
        Me.lbltabelaB.Size = New System.Drawing.Size(40, 20)
        Me.lbltabelaB.TabIndex = 10000183
        Me.lbltabelaB.Text = "Table"
        Me.lbltabelaB.Visible = False
        '
        'lblApp
        '
        Me.lblApp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblApp.ForeColor = System.Drawing.Color.Black
        Me.lblApp.Location = New System.Drawing.Point(3, 64)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(32, 26)
        Me.lblApp.TabIndex = 10000179
        Me.lblApp.Text = "App"
        Me.lblApp.Visible = False
        '
        'panelCondition
        '
        Me.panelCondition.BackColor = System.Drawing.SystemColors.Control
        Me.TLP.SetColumnSpan(Me.panelCondition, 2)
        Me.panelCondition.Controls.Add(Me.cbOR2)
        Me.panelCondition.Controls.Add(Me.cbOR1)
        Me.panelCondition.Controls.Add(Me.Label16)
        Me.panelCondition.Controls.Add(Me.Label15)
        Me.panelCondition.Controls.Add(Me.lblF4)
        Me.panelCondition.Controls.Add(Me.Label12)
        Me.panelCondition.Controls.Add(Me.Label13)
        Me.panelCondition.Controls.Add(Me.Label11)
        Me.panelCondition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCondition.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.panelCondition.Location = New System.Drawing.Point(3, 295)
        Me.panelCondition.Name = "panelCondition"
        Me.panelCondition.Size = New System.Drawing.Size(610, 337)
        Me.panelCondition.TabIndex = 10000323
        '
        'cbOR2
        '
        Me.cbOR2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbOR2.Location = New System.Drawing.Point(33, 249)
        Me.cbOR2.Name = "cbOR2"
        Me.cbOR2.Size = New System.Drawing.Size(22, 19)
        Me.cbOR2.TabIndex = 10000323
        '
        'cbOR1
        '
        Me.cbOR1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbOR1.Location = New System.Drawing.Point(33, 180)
        Me.cbOR1.Name = "cbOR1"
        Me.cbOR1.Size = New System.Drawing.Size(22, 19)
        Me.cbOR1.TabIndex = 10000322
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(3, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(25, 20)
        Me.Label16.TabIndex = 10000320
        Me.Label16.Text = "OR"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(3, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 20)
        Me.Label15.TabIndex = 10000319
        Me.Label15.Text = "OR"
        '
        'lblF4
        '
        Me.lblF4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblF4.ForeColor = System.Drawing.Color.Black
        Me.lblF4.Location = New System.Drawing.Point(3, 4)
        Me.lblF4.Name = "lblF4"
        Me.lblF4.Size = New System.Drawing.Size(376, 23)
        Me.lblF4.TabIndex = 10000262
        Me.lblF4.Text = "All"
        Me.lblF4.Visible = False
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(3, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 20)
        Me.Label12.TabIndex = 10000262
        Me.Label12.Text = "Update to"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(3, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 20)
        Me.Label13.TabIndex = 10000270
        Me.Label13.Text = "Criteria"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 40)
        Me.Label11.TabIndex = 10000261
        Me.Label11.Text = "Fields from TABLE A"
        '
        'bUpdate
        '
        Me.bUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bUpdate.Location = New System.Drawing.Point(85, 0)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(77, 22)
        Me.bUpdate.TabIndex = 10000316
        Me.bUpdate.Text = "UPDATE"
        Me.bUpdate.UseVisualStyleBackColor = False
        '
        'bReset
        '
        Me.bReset.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bReset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bReset.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bReset.Location = New System.Drawing.Point(255, 0)
        Me.bReset.Name = "bReset"
        Me.bReset.Size = New System.Drawing.Size(77, 22)
        Me.bReset.TabIndex = 10000136
        Me.bReset.Text = "Reset"
        Me.bReset.UseVisualStyleBackColor = False
        '
        'panelTabelaA
        '
        Me.panelTabelaA.Controls.Add(Me.ucvtA)
        Me.panelTabelaA.Controls.Add(Me.txtAppA)
        Me.panelTabelaA.Controls.Add(Me.bAddTableB)
        Me.panelTabelaA.Controls.Add(Me.bDownAppA)
        Me.panelTabelaA.Controls.Add(Me.clbAppA)
        Me.panelTabelaA.Controls.Add(Me.Label1)
        Me.panelTabelaA.Controls.Add(Me.clbTabelaA)
        Me.panelTabelaA.Controls.Add(Me.txtTabelaA)
        Me.panelTabelaA.Controls.Add(Me.bDownTA)
        Me.panelTabelaA.Controls.Add(Me.clbFilterA)
        Me.panelTabelaA.Controls.Add(Me.ButtonFieldA)
        Me.panelTabelaA.Controls.Add(Me.lbltabelaA)
        Me.panelTabelaA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.panelTabelaA.Location = New System.Drawing.Point(3, 3)
        Me.panelTabelaA.Name = "panelTabelaA"
        Me.panelTabelaA.Size = New System.Drawing.Size(302, 286)
        Me.panelTabelaA.TabIndex = 10000324
        '
        'ucvtA
        '
        Me.ucvtA.BackColor = System.Drawing.SystemColors.Control
        Me.ucvtA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvtA.Location = New System.Drawing.Point(45, 9)
        Me.ucvtA.Name = "ucvtA"
        Me.ucvtA.Size = New System.Drawing.Size(109, 48)
        Me.ucvtA.TabIndex = 10000155
        Me.ucvtA.TabStop = False
        '
        'txtAppA
        '
        Me.txtAppA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAppA.Location = New System.Drawing.Point(45, 63)
        Me.txtAppA.MaxLength = 20
        Me.txtAppA.Name = "txtAppA"
        Me.txtAppA.Size = New System.Drawing.Size(212, 21)
        Me.txtAppA.TabIndex = 10000185
        Me.txtAppA.Visible = False
        '
        'bAddTableB
        '
        Me.bAddTableB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddTableB.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAddTableB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAddTableB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddTableB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bAddTableB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bAddTableB.Location = New System.Drawing.Point(280, 100)
        Me.bAddTableB.Margin = New System.Windows.Forms.Padding(0)
        Me.bAddTableB.Name = "bAddTableB"
        Me.bAddTableB.Size = New System.Drawing.Size(21, 21)
        Me.bAddTableB.TabIndex = 10000144
        Me.bAddTableB.Text = "+"
        Me.bAddTableB.UseVisualStyleBackColor = False
        Me.bAddTableB.Visible = False
        '
        'bDownAppA
        '
        Me.bDownAppA.BackColor = System.Drawing.Color.Transparent
        Me.bDownAppA.Image = CType(resources.GetObject("bDownAppA.Image"), System.Drawing.Image)
        Me.bDownAppA.Location = New System.Drawing.Point(257, 63)
        Me.bDownAppA.Name = "bDownAppA"
        Me.bDownAppA.Size = New System.Drawing.Size(21, 21)
        Me.bDownAppA.TabIndex = 10000186
        Me.bDownAppA.TabStop = False
        Me.bDownAppA.Visible = False
        '
        'clbAppA
        '
        Me.clbAppA.BackColor = System.Drawing.SystemColors.Window
        Me.clbAppA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbAppA.CheckOnClick = True
        Me.clbAppA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbAppA.FormattingEnabled = True
        Me.clbAppA.Location = New System.Drawing.Point(45, 83)
        Me.clbAppA.Name = "clbAppA"
        Me.clbAppA.Size = New System.Drawing.Size(212, 18)
        Me.clbAppA.TabIndex = 10000184
        Me.clbAppA.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 26)
        Me.Label1.TabIndex = 10000183
        Me.Label1.Text = "App"
        Me.Label1.Visible = False
        '
        'clbTabelaA
        '
        Me.clbTabelaA.BackColor = System.Drawing.SystemColors.Window
        Me.clbTabelaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbTabelaA.CheckOnClick = True
        Me.clbTabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbTabelaA.FormattingEnabled = True
        Me.clbTabelaA.Location = New System.Drawing.Point(45, 120)
        Me.clbTabelaA.Name = "clbTabelaA"
        Me.clbTabelaA.Size = New System.Drawing.Size(212, 18)
        Me.clbTabelaA.TabIndex = 10000130
        Me.clbTabelaA.Visible = False
        '
        'txtTabelaA
        '
        Me.txtTabelaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTabelaA.Location = New System.Drawing.Point(45, 100)
        Me.txtTabelaA.MaxLength = 20
        Me.txtTabelaA.Name = "txtTabelaA"
        Me.txtTabelaA.Size = New System.Drawing.Size(212, 21)
        Me.txtTabelaA.TabIndex = 10000131
        '
        'bDownTA
        '
        Me.bDownTA.BackColor = System.Drawing.Color.Transparent
        Me.bDownTA.Image = CType(resources.GetObject("bDownTA.Image"), System.Drawing.Image)
        Me.bDownTA.Location = New System.Drawing.Point(257, 100)
        Me.bDownTA.Name = "bDownTA"
        Me.bDownTA.Size = New System.Drawing.Size(21, 21)
        Me.bDownTA.TabIndex = 10000132
        Me.bDownTA.TabStop = False
        '
        'clbFilterA
        '
        Me.clbFilterA.BackColor = System.Drawing.SystemColors.Window
        Me.clbFilterA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbFilterA.CheckOnClick = True
        Me.clbFilterA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbFilterA.FormattingEnabled = True
        Me.clbFilterA.Location = New System.Drawing.Point(45, 137)
        Me.clbFilterA.Name = "clbFilterA"
        Me.clbFilterA.Size = New System.Drawing.Size(212, 146)
        Me.clbFilterA.TabIndex = 10000141
        Me.clbFilterA.Visible = False
        '
        'ButtonFieldA
        '
        Me.ButtonFieldA.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFieldA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFieldA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFieldA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonFieldA.Image = CType(resources.GetObject("ButtonFieldA.Image"), System.Drawing.Image)
        Me.ButtonFieldA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonFieldA.Location = New System.Drawing.Point(257, 137)
        Me.ButtonFieldA.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFieldA.Name = "ButtonFieldA"
        Me.ButtonFieldA.Size = New System.Drawing.Size(21, 21)
        Me.ButtonFieldA.TabIndex = 10000143
        Me.ButtonFieldA.UseVisualStyleBackColor = False
        Me.ButtonFieldA.Visible = False
        '
        'lbltabelaA
        '
        Me.lbltabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltabelaA.ForeColor = System.Drawing.Color.Black
        Me.lbltabelaA.Location = New System.Drawing.Point(2, 100)
        Me.lbltabelaA.Name = "lbltabelaA"
        Me.lbltabelaA.Size = New System.Drawing.Size(40, 20)
        Me.lbltabelaA.TabIndex = 10000133
        Me.lbltabelaA.Text = "Table"
        '
        'TLP
        '
        Me.TLP.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TLP.ColumnCount = 5
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54902!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.54902!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.60784!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.60784!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.68627!))
        Me.TLP.Controls.Add(Me.panelTabelaD, 3, 0)
        Me.TLP.Controls.Add(Me.panelTabelaC, 2, 0)
        Me.TLP.Controls.Add(Me.panelTabelaA, 0, 0)
        Me.TLP.Controls.Add(Me.panelCondition, 0, 1)
        Me.TLP.Controls.Add(Me.ButtonISTIzlaz, 4, 0)
        Me.TLP.Controls.Add(Me.panelTabelaB, 1, 0)
        Me.TLP.Controls.Add(Me.lblDistinctCount, 2, 2)
        Me.TLP.Controls.Add(Me.dgv, 2, 1)
        Me.TLP.Controls.Add(Me.txtSQLUpdate, 0, 3)
        Me.TLP.Controls.Add(Me.Panel1, 0, 2)
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP.Location = New System.Drawing.Point(0, 0)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 4
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.24134!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.30021!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.476876!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.981575!))
        Me.TLP.Size = New System.Drawing.Size(1370, 727)
        Me.TLP.TabIndex = 10000326
        '
        'panelTabelaD
        '
        Me.panelTabelaD.AllowDrop = True
        Me.panelTabelaD.Controls.Add(Me.bRemoveTableD)
        Me.panelTabelaD.Controls.Add(Me.ButtonFieldD)
        Me.panelTabelaD.Controls.Add(Me.txtAppD)
        Me.panelTabelaD.Controls.Add(Me.bDownAppD)
        Me.panelTabelaD.Controls.Add(Me.clbAppD)
        Me.panelTabelaD.Controls.Add(Me.clbFilterD)
        Me.panelTabelaD.Controls.Add(Me.bDownTD)
        Me.panelTabelaD.Controls.Add(Me.txtTabelaD)
        Me.panelTabelaD.Controls.Add(Me.clbTabelaD)
        Me.panelTabelaD.Controls.Add(Me.ucvtD)
        Me.panelTabelaD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTabelaD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.panelTabelaD.Location = New System.Drawing.Point(887, 3)
        Me.panelTabelaD.Name = "panelTabelaD"
        Me.panelTabelaD.Size = New System.Drawing.Size(262, 286)
        Me.panelTabelaD.TabIndex = 10000328
        Me.panelTabelaD.Visible = False
        '
        'bRemoveTableD
        '
        Me.bRemoveTableD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRemoveTableD.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRemoveTableD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bRemoveTableD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRemoveTableD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bRemoveTableD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bRemoveTableD.Location = New System.Drawing.Point(239, 100)
        Me.bRemoveTableD.Margin = New System.Windows.Forms.Padding(0)
        Me.bRemoveTableD.Name = "bRemoveTableD"
        Me.bRemoveTableD.Size = New System.Drawing.Size(21, 21)
        Me.bRemoveTableD.TabIndex = 10000325
        Me.bRemoveTableD.Text = "-"
        Me.bRemoveTableD.UseVisualStyleBackColor = False
        Me.bRemoveTableD.Visible = False
        '
        'ButtonFieldD
        '
        Me.ButtonFieldD.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFieldD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFieldD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFieldD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonFieldD.Image = CType(resources.GetObject("ButtonFieldD.Image"), System.Drawing.Image)
        Me.ButtonFieldD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonFieldD.Location = New System.Drawing.Point(217, 137)
        Me.ButtonFieldD.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFieldD.Name = "ButtonFieldD"
        Me.ButtonFieldD.Size = New System.Drawing.Size(21, 21)
        Me.ButtonFieldD.TabIndex = 10000184
        Me.ButtonFieldD.UseVisualStyleBackColor = False
        Me.ButtonFieldD.Visible = False
        '
        'txtAppD
        '
        Me.txtAppD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAppD.Location = New System.Drawing.Point(5, 63)
        Me.txtAppD.MaxLength = 20
        Me.txtAppD.Name = "txtAppD"
        Me.txtAppD.Size = New System.Drawing.Size(212, 21)
        Me.txtAppD.TabIndex = 10000181
        '
        'bDownAppD
        '
        Me.bDownAppD.BackColor = System.Drawing.Color.Transparent
        Me.bDownAppD.Image = CType(resources.GetObject("bDownAppD.Image"), System.Drawing.Image)
        Me.bDownAppD.Location = New System.Drawing.Point(217, 63)
        Me.bDownAppD.Name = "bDownAppD"
        Me.bDownAppD.Size = New System.Drawing.Size(21, 21)
        Me.bDownAppD.TabIndex = 10000182
        Me.bDownAppD.TabStop = False
        '
        'clbAppD
        '
        Me.clbAppD.BackColor = System.Drawing.SystemColors.Window
        Me.clbAppD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbAppD.CheckOnClick = True
        Me.clbAppD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbAppD.FormattingEnabled = True
        Me.clbAppD.Location = New System.Drawing.Point(5, 83)
        Me.clbAppD.Name = "clbAppD"
        Me.clbAppD.Size = New System.Drawing.Size(212, 18)
        Me.clbAppD.TabIndex = 10000180
        Me.clbAppD.Visible = False
        '
        'clbFilterD
        '
        Me.clbFilterD.BackColor = System.Drawing.SystemColors.Window
        Me.clbFilterD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbFilterD.CheckOnClick = True
        Me.clbFilterD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbFilterD.FormattingEnabled = True
        Me.clbFilterD.Location = New System.Drawing.Point(5, 137)
        Me.clbFilterD.Name = "clbFilterD"
        Me.clbFilterD.Size = New System.Drawing.Size(212, 146)
        Me.clbFilterD.TabIndex = 10000177
        Me.clbFilterD.Visible = False
        '
        'bDownTD
        '
        Me.bDownTD.BackColor = System.Drawing.Color.Transparent
        Me.bDownTD.Image = CType(resources.GetObject("bDownTD.Image"), System.Drawing.Image)
        Me.bDownTD.Location = New System.Drawing.Point(217, 100)
        Me.bDownTD.Name = "bDownTD"
        Me.bDownTD.Size = New System.Drawing.Size(21, 21)
        Me.bDownTD.TabIndex = 10000175
        Me.bDownTD.TabStop = False
        '
        'txtTabelaD
        '
        Me.txtTabelaD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabelaD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTabelaD.Location = New System.Drawing.Point(5, 100)
        Me.txtTabelaD.MaxLength = 20
        Me.txtTabelaD.Name = "txtTabelaD"
        Me.txtTabelaD.Size = New System.Drawing.Size(212, 21)
        Me.txtTabelaD.TabIndex = 10000174
        '
        'clbTabelaD
        '
        Me.clbTabelaD.BackColor = System.Drawing.SystemColors.Window
        Me.clbTabelaD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbTabelaD.CheckOnClick = True
        Me.clbTabelaD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbTabelaD.FormattingEnabled = True
        Me.clbTabelaD.Location = New System.Drawing.Point(5, 120)
        Me.clbTabelaD.Name = "clbTabelaD"
        Me.clbTabelaD.Size = New System.Drawing.Size(212, 18)
        Me.clbTabelaD.TabIndex = 10000173
        Me.clbTabelaD.Visible = False
        '
        'ucvtD
        '
        Me.ucvtD.BackColor = System.Drawing.SystemColors.Control
        Me.ucvtD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvtD.Location = New System.Drawing.Point(5, 9)
        Me.ucvtD.Name = "ucvtD"
        Me.ucvtD.Size = New System.Drawing.Size(109, 48)
        Me.ucvtD.TabIndex = 10000176
        Me.ucvtD.TabStop = False
        '
        'panelTabelaC
        '
        Me.panelTabelaC.AllowDrop = True
        Me.panelTabelaC.Controls.Add(Me.bRemoveTableC)
        Me.panelTabelaC.Controls.Add(Me.bAddTableD)
        Me.panelTabelaC.Controls.Add(Me.ButtonFieldC)
        Me.panelTabelaC.Controls.Add(Me.txtAppC)
        Me.panelTabelaC.Controls.Add(Me.bDownAppC)
        Me.panelTabelaC.Controls.Add(Me.clbAppC)
        Me.panelTabelaC.Controls.Add(Me.clbFilterC)
        Me.panelTabelaC.Controls.Add(Me.bDownTC)
        Me.panelTabelaC.Controls.Add(Me.txtTabelaC)
        Me.panelTabelaC.Controls.Add(Me.clbTabelaC)
        Me.panelTabelaC.Controls.Add(Me.ucvtC)
        Me.panelTabelaC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTabelaC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.panelTabelaC.Location = New System.Drawing.Point(619, 3)
        Me.panelTabelaC.Name = "panelTabelaC"
        Me.panelTabelaC.Size = New System.Drawing.Size(262, 286)
        Me.panelTabelaC.TabIndex = 10000327
        Me.panelTabelaC.Visible = False
        '
        'bRemoveTableC
        '
        Me.bRemoveTableC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRemoveTableC.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bRemoveTableC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bRemoveTableC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bRemoveTableC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bRemoveTableC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bRemoveTableC.Location = New System.Drawing.Point(238, 120)
        Me.bRemoveTableC.Margin = New System.Windows.Forms.Padding(0)
        Me.bRemoveTableC.Name = "bRemoveTableC"
        Me.bRemoveTableC.Size = New System.Drawing.Size(21, 21)
        Me.bRemoveTableC.TabIndex = 10000323
        Me.bRemoveTableC.Text = "-"
        Me.bRemoveTableC.UseVisualStyleBackColor = False
        Me.bRemoveTableC.Visible = False
        '
        'bAddTableD
        '
        Me.bAddTableD.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddTableD.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAddTableD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAddTableD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddTableD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bAddTableD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bAddTableD.Location = New System.Drawing.Point(238, 100)
        Me.bAddTableD.Margin = New System.Windows.Forms.Padding(0)
        Me.bAddTableD.Name = "bAddTableD"
        Me.bAddTableD.Size = New System.Drawing.Size(21, 21)
        Me.bAddTableD.TabIndex = 10000322
        Me.bAddTableD.Text = "+"
        Me.bAddTableD.UseVisualStyleBackColor = False
        Me.bAddTableD.Visible = False
        '
        'ButtonFieldC
        '
        Me.ButtonFieldC.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFieldC.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFieldC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFieldC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonFieldC.Image = CType(resources.GetObject("ButtonFieldC.Image"), System.Drawing.Image)
        Me.ButtonFieldC.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonFieldC.Location = New System.Drawing.Point(216, 137)
        Me.ButtonFieldC.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFieldC.Name = "ButtonFieldC"
        Me.ButtonFieldC.Size = New System.Drawing.Size(21, 21)
        Me.ButtonFieldC.TabIndex = 10000184
        Me.ButtonFieldC.UseVisualStyleBackColor = False
        Me.ButtonFieldC.Visible = False
        '
        'txtAppC
        '
        Me.txtAppC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAppC.Location = New System.Drawing.Point(4, 63)
        Me.txtAppC.MaxLength = 20
        Me.txtAppC.Name = "txtAppC"
        Me.txtAppC.Size = New System.Drawing.Size(212, 21)
        Me.txtAppC.TabIndex = 10000181
        '
        'bDownAppC
        '
        Me.bDownAppC.BackColor = System.Drawing.Color.Transparent
        Me.bDownAppC.Image = CType(resources.GetObject("bDownAppC.Image"), System.Drawing.Image)
        Me.bDownAppC.Location = New System.Drawing.Point(216, 63)
        Me.bDownAppC.Name = "bDownAppC"
        Me.bDownAppC.Size = New System.Drawing.Size(21, 21)
        Me.bDownAppC.TabIndex = 10000182
        Me.bDownAppC.TabStop = False
        '
        'clbAppC
        '
        Me.clbAppC.BackColor = System.Drawing.SystemColors.Window
        Me.clbAppC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbAppC.CheckOnClick = True
        Me.clbAppC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbAppC.FormattingEnabled = True
        Me.clbAppC.Location = New System.Drawing.Point(4, 83)
        Me.clbAppC.Name = "clbAppC"
        Me.clbAppC.Size = New System.Drawing.Size(212, 18)
        Me.clbAppC.TabIndex = 10000180
        Me.clbAppC.Visible = False
        '
        'clbFilterC
        '
        Me.clbFilterC.BackColor = System.Drawing.SystemColors.Window
        Me.clbFilterC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbFilterC.CheckOnClick = True
        Me.clbFilterC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbFilterC.FormattingEnabled = True
        Me.clbFilterC.Location = New System.Drawing.Point(4, 137)
        Me.clbFilterC.Name = "clbFilterC"
        Me.clbFilterC.Size = New System.Drawing.Size(212, 146)
        Me.clbFilterC.TabIndex = 10000177
        Me.clbFilterC.Visible = False
        '
        'bDownTC
        '
        Me.bDownTC.BackColor = System.Drawing.Color.Transparent
        Me.bDownTC.Image = CType(resources.GetObject("bDownTC.Image"), System.Drawing.Image)
        Me.bDownTC.Location = New System.Drawing.Point(216, 100)
        Me.bDownTC.Name = "bDownTC"
        Me.bDownTC.Size = New System.Drawing.Size(21, 21)
        Me.bDownTC.TabIndex = 10000175
        Me.bDownTC.TabStop = False
        '
        'txtTabelaC
        '
        Me.txtTabelaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabelaC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTabelaC.Location = New System.Drawing.Point(4, 100)
        Me.txtTabelaC.MaxLength = 20
        Me.txtTabelaC.Name = "txtTabelaC"
        Me.txtTabelaC.Size = New System.Drawing.Size(212, 21)
        Me.txtTabelaC.TabIndex = 10000174
        '
        'clbTabelaC
        '
        Me.clbTabelaC.BackColor = System.Drawing.SystemColors.Window
        Me.clbTabelaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbTabelaC.CheckOnClick = True
        Me.clbTabelaC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbTabelaC.FormattingEnabled = True
        Me.clbTabelaC.Location = New System.Drawing.Point(4, 120)
        Me.clbTabelaC.Name = "clbTabelaC"
        Me.clbTabelaC.Size = New System.Drawing.Size(212, 18)
        Me.clbTabelaC.TabIndex = 10000173
        Me.clbTabelaC.Visible = False
        '
        'ucvtC
        '
        Me.ucvtC.BackColor = System.Drawing.SystemColors.Control
        Me.ucvtC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvtC.Location = New System.Drawing.Point(4, 9)
        Me.ucvtC.Name = "ucvtC"
        Me.ucvtC.Size = New System.Drawing.Size(109, 48)
        Me.ucvtC.TabIndex = 10000176
        Me.ucvtC.TabStop = False
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TLP.SetColumnSpan(Me.dgv, 3)
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(619, 295)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(748, 337)
        Me.dgv.TabIndex = 10000325
        Me.dgv.Visible = False
        '
        'Panel1
        '
        Me.TLP.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.bReset)
        Me.Panel1.Controls.Add(Me.bJoin)
        Me.Panel1.Controls.Add(Me.bUpdate)
        Me.Panel1.Controls.Add(Me.bSQL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 638)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(610, 26)
        Me.Panel1.TabIndex = 10000326
        '
        'bJoin
        '
        Me.bJoin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bJoin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bJoin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bJoin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bJoin.Location = New System.Drawing.Point(170, 0)
        Me.bJoin.Name = "bJoin"
        Me.bJoin.Size = New System.Drawing.Size(77, 22)
        Me.bJoin.TabIndex = 10000324
        Me.bJoin.Text = "Join"
        Me.bJoin.UseVisualStyleBackColor = False
        '
        'bSQL
        '
        Me.bSQL.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bSQL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bSQL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bSQL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bSQL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bSQL.Location = New System.Drawing.Point(3, 0)
        Me.bSQL.Name = "bSQL"
        Me.bSQL.Size = New System.Drawing.Size(77, 22)
        Me.bSQL.TabIndex = 10000317
        Me.bSQL.Text = "SQL view"
        Me.bSQL.UseVisualStyleBackColor = False
        '
        'FormAdvancedUpdating
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.CancelButton = Me.ButtonISTIzlaz
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.TLP)
        Me.Controls.Add(Me.tt)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        
        Me.Name = "FormAdvancedUpdating"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuNumber.ResumeLayout(False)
        Me.mnuString.ResumeLayout(False)
        Me.panelTabelaB.ResumeLayout(False)
        Me.panelTabelaB.PerformLayout()
        CType(Me.bDownAppB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDownTB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCondition.ResumeLayout(False)
        Me.panelTabelaA.ResumeLayout(False)
        Me.panelTabelaA.PerformLayout()
        CType(Me.bDownAppA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDownTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP.ResumeLayout(False)
        Me.TLP.PerformLayout()
        Me.panelTabelaD.ResumeLayout(False)
        Me.panelTabelaD.PerformLayout()
        CType(Me.bDownAppD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDownTD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTabelaC.ResumeLayout(False)
        Me.panelTabelaC.PerformLayout()
        CType(Me.bDownAppC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDownTC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

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
    Dim vtA As String
    Dim vtB As String
    Dim vtC As String
    Dim vtD As String

    Dim mvtA As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim mvtB As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim mvtC As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim mvtD As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka

    Dim arrayControlsA() As AutoCompleteTextbox
    Dim arrayControlsFAB0() As AutoCompleteTextbox
    Dim arrayControlsFAB3() As AutoCompleteTextbox
    Dim arrayControlsFAB6() As AutoCompleteTextbox
    Dim arrayControlsFAB9() As AutoCompleteTextbox
    Dim arrayControlsAB1() As AutoCompleteTextbox
    Dim arrayControlsAB4() As AutoCompleteTextbox
    Dim arrayControlsAB7() As AutoCompleteTextbox
    Dim arrayControlsOP2() As ComboBox
    Dim arrayControlsOP5() As ComboBox
    Dim arrayControlsOP8() As ComboBox

    Dim sifistA As String
    Dim dbNameA As String
    Dim dbServerNameA As String
    Dim dbNameB As String
    Dim dbServerNameB As String
    Dim dbNameC As String
    Dim dbServerNameC As String
    Dim dbNameD As String
    Dim dbServerNameD As String

    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow, ByVal ISTConnectionString As String,
                    ByVal txtInst As String, ByVal txtPismo As String,
                    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
                    ByVal txt_DSBrisanjeBaza As String, ByVal txtmode As String, ByVal jezik As String)

        Me.New()

        Me.jezik = jezik
        Call SetLang()
        Me.txtmode = txtmode

        Me.Text = Me.Text + " - " + ri.Naziv.Trim
        Me.ttab = ttab

        Me.mrist = ri

        ucvtA.Init(vt) : ucvtB.Init(vt) : ucvtC.Init(vt) : ucvtD.Init(vt)

        Me.sifistA = ri.SIFIST.Trim
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString

        Dim bs() As String = dajBazuServer(sifistA, Me.ISTConnectionString).Split("$")
        dbNameA = bs(0) : dbServerNameA = bs(1)

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza

        Me.mvtA = ucvtA
        Me.mvtB = ucvtB
        Me.mvtC = ucvtC
        Me.mvtD = ucvtD
        vtA = ucvtA.G.ToString + "-" + String.Format("{0:d2}", ucvtA.M) + "-01"
        vtB = ucvtB.G.ToString + "-" + String.Format("{0:d2}", ucvtB.M) + "-01"
        vtC = ucvtC.G.ToString + "-" + String.Format("{0:d2}", ucvtC.M) + "-01"
        vtD = ucvtD.G.ToString + "-" + String.Format("{0:d2}", ucvtD.M) + "-01"

        Dim strSQlA As String = "select  distinct tabela as valuemember,tabela+' '+opis as displaymember from vISTTABELEzaDOK('" + vtA + "','" + Me.sifistA.ToString.Trim + "')  order by 1"

        Call fillCLB(clbTabelaA, strSQlA, Me.ISTConnectionString)

        Call srediformu()

        Me.jezik = jezik

        Dim actb As AutoCompleteTextbox
        Dim cboop As ComboBox
        Me.panelCondition.Width = 78 + 6 * 85 + 5
        Me.txtSQLUpdate.Width = 78 + 6 * 85

        Me.lblF4.Text = "All below are autocomplete text boxes, press F4  or FN+F4 to see all possible values or add free value"
        Me.lblF4.AutoSize = True

        Dim m As Integer = -1

        For i As Integer = 1 To 4
            m = m + 1   ' m je i-1
            ReDim Preserve arrayControlsA(m)
            ReDim Preserve arrayControlsFAB0(m) : ReDim Preserve arrayControlsFAB3(m) : ReDim Preserve arrayControlsFAB6(m) : ReDim Preserve arrayControlsFAB9(m)
            ReDim Preserve arrayControlsAB1(m) : ReDim Preserve arrayControlsAB4(m) : ReDim Preserve arrayControlsAB7(m)
            ReDim Preserve arrayControlsOP2(m) : ReDim Preserve arrayControlsOP5(m) : ReDim Preserve arrayControlsOP8(m)
            'red kolona
            actb = addACTB_A(Str(i).Trim) : arrayControlsA(m) = actb
            actb = addACTB_FAB(0, Str(i).Trim) : arrayControlsFAB0(m) = actb

            actb = addACTB_AB(1, Str(i).Trim) : arrayControlsAB1(m) = actb
            cboop = addCBOOP(2, Str(i).Trim) : arrayControlsOP2(m) = cboop
            actb = addACTB_FAB(3, Str(i).Trim) : arrayControlsFAB3(m) = actb

            actb = addACTB_AB(4, Str(i).Trim) : arrayControlsAB4(m) = actb
            cboop = addCBOOP(5, Str(i).Trim) : arrayControlsOP5(m) = cboop
            actb = addACTB_FAB(6, Str(i).Trim) : arrayControlsFAB6(m) = actb

            actb = addACTB_AB(7, Str(i).Trim) : arrayControlsAB7(m) = actb
            cboop = addCBOOP(8, Str(i).Trim) : arrayControlsOP8(m) = cboop
            actb = addACTB_FAB(9, Str(i).Trim) : arrayControlsFAB9(m) = actb
        Next

        lbltabelaA.Visible = True
        lbltabelaA.Location = New Point(Me.Label1.Location.X, txtAppA.Location.Y + txtAppA.Height + 1)
        txtTabelaA.Location = New Point(Me.txtAppA.Location.X, txtAppA.Location.Y + txtAppA.Height + 1)
        bDownTA.Location = New Point(Me.txtTabelaA.Location.X + txtTabelaA.Width + 1, txtTabelaA.Location.Y)
        bAddTableB.Location = New Point(Me.bDownTA.Location.X + bDownTA.Width + 1, bDownTA.Location.Y)
        ButtonFieldA.Location = New Point(Me.clbFilterA.Location.X + clbFilterA.Width + 1, clbFilterA.Location.Y)
    End Sub

    Private Sub cbOR1_CheckedChanged(sender As Object, e As EventArgs) Handles cbOR1.CheckedChanged
        If cbOR1.Checked = True Then
            vnv("2", True)
        Else
            vnv("2", False)
        End If
    End Sub

    Sub vnv(ByVal part As String, ByVal v As Boolean)
        For Each cntl As Control In Me.panelCondition.Controls
            If Not cntl.Tag Is Nothing AndAlso cntl.Tag = part Then
                cntl.Visible = v
                If v = False Then cntl.Text = ""
            End If
        Next
    End Sub

    Private Sub cbOR2_CheckedChanged(sender As Object, e As EventArgs) Handles cbOR2.CheckedChanged
        If cbOR2.Checked = True Then
            vnv("3", True)
        Else
            vnv("3", False)
        End If
    End Sub

    Function addACTB_A(ByVal k As String) As AutoCompleteTextbox
        Dim actb As New AutoCompleteTextbox
        actb.Visible = True
        actb.Width = 84 + 40
        actb.Name = "actbA" + k
        actb.Location = New Point(78 + (CInt(k) - 1) * (85 + 40 + 0), 4 + 43)
        actb.Font = New System.Drawing.Font("Verdana", 8.0!)
        actb.AccessibleName = actb.Name
        actb.autoCompleteLimitToList = True
        actb.aWidth = 0
        actb.Font = New Font(Me.Font.Name, 8.0!)
        AddHandler actb.LostFocus, AddressOf Me.actb_LostFocus2
        panelCondition.Controls.Add(actb)
        actb.BackColor = SystemColors.Window
        Return actb
    End Function

    Function addACTB_FAB(ByVal r As String, ByVal k As Integer) As AutoCompleteTextbox
        Dim actb As New AutoCompleteTextbox
        actb.Visible = True
        actb.Width = 84 + 40
        actb.Name = "actbFAB" + r + Str(k).Trim
        actb.Location = New Point(78 + (CInt(k) - 1) * (85 + 40 + 0), 4 + 43 + 41 + r * 23)
        actb.Font = New System.Drawing.Font("Verdana", 8.0!)
        actb.AccessibleName = actb.Name
        actb.autoCompleteLimitToList = False
        actb.aWidth = 200
        actb.Font = New Font(Me.Font.Name, 9)
        AddHandler actb.LostFocus, AddressOf Me.actb_LostFocus
        panelCondition.Controls.Add(actb)
        actb.BackColor = SystemColors.Window
        If r > 3 Then actb.Visible = False
        If r > 3 And r < 7 Then actb.Tag = "2"  '4 5 6
        If r > 6 Then actb.Tag = "3"            '7 8 9
        Return actb
    End Function

    Function addACTB_AB(ByVal r As String, ByVal k As Integer) As AutoCompleteTextbox
        Dim actb As New AutoCompleteTextbox
        actb.Visible = True
        actb.Width = 84 + 40
        actb.Name = "actbAB" + r + Str(k).Trim
        actb.Location = New Point(78 + (CInt(k) - 1) * (85 + 40 + 0), 4 + 43 + 41 + r * 23)
        actb.Font = New System.Drawing.Font("Verdana", 8.0!)
        actb.AccessibleName = actb.Name
        actb.aWidth = 200
        actb.autoCompleteLimitToList = True
        actb.Font = New Font(Me.Font.Name, 9)
        AddHandler actb.LostFocus, AddressOf Me.actb_LostFocus2
        panelCondition.Controls.Add(actb)
        actb.BackColor = SystemColors.Window
        If r > 3 Then actb.Visible = False
        If r > 3 And r < 7 Then actb.Tag = "2"  '4 5 6
        If r > 6 Then actb.Tag = "3"            '7 8 9
        Return actb
    End Function

    Function addCBOOP(ByVal r As String, ByVal k As String) As ComboBox
        Dim cboOP As New ComboBox
        cboOP.Visible = True
        cboOP.Width = 84 + 40
        cboOP.DropDownWidth = 125
        cboOP.BackColor = SystemColors.Window
        cboOP.Name = "cboOP" + r + Str(k).Trim
        cboOP.Location = New Point(78 + (CInt(k) - 1) * (85 + 40 + 0), 4 + 43 + 41 + r * 23)
        cboOP.Font = New System.Drawing.Font("Verdana", 8.0!)
        cboOP.Font = New Font(Me.Font.Name, 9)
        cboOP.Items.Add("=")
        cboOP.Items.Add(">=")
        cboOP.Items.Add("<=")
        cboOP.Items.Add(">")
        cboOP.Items.Add("<")
        cboOP.Items.Add("<>")
        cboOP.Items.Add("like")
        cboOP.Items.Add("not like")
        cboOP.Items.Add("between")
        cboOP.Items.Add("not between")
        cboOP.Items.Add("in")
        cboOP.Items.Add("not in")
        cboOP.Items.Add("is")
        cboOP.Items.Add("not is")
        cboOP.Text = "="
        panelCondition.Controls.Add(cboOP)
        If r > 3 Then cboOP.Visible = False
        If r > 3 And r < 7 Then cboOP.Tag = "2"  '4 5 6
        If r > 6 Then cboOP.Tag = "3"            '7 8 9
        Return cboOP
    End Function

    Private Sub actb_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)   ' LostFocus
        Dim actb As AutoCompleteTextbox = CType(sender, AutoCompleteTextbox)
        actb.autoCompleteLimitToList = False   'MORA
    End Sub

    Private Sub actb_LostFocus2(ByVal sender As Object, ByVal e As System.EventArgs)   ' LostFocus
        Dim actb As AutoCompleteTextbox = CType(sender, AutoCompleteTextbox)
        actb.autoCompleteLimitToList = True   'MORA
    End Sub

    Sub izbaciKontroleIzVT(ByVal cntl As Control)
        For Each c As Control In cntl.Controls
            If c.Name = "Label1" Then c.Visible = False : c.Height = 2 : c.Width = 2
            If c.Name = "CheckBoxMes59" Then c.Visible = False : c.Height = 2 : c.Width = 2
            If c.Name.ToLower = "datetimepicker1" Then c.Location = New Point(2, 2) : c.BringToFront()
        Next
    End Sub

    Private Sub bDownTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDownTA.Click
        Me.clbTabelaA.Height = Me.Height \ 5
        Me.clbTabelaA.Visible = Not Me.clbTabelaA.Visible
        Dim strSQlA As String = "select  distinct tabela as valuemember,tabela as displaymember from vISTTABELEzaDOK('" + vtA + "','" + sifistA.Trim + "') order by 1"
        If Me.clbTabelaA.Visible = True Then Me.clbTabelaA.BringToFront()
        clbTabelaA.Location = New Point(txtTabelaA.Location.X, txtTabelaA.Location.Y + txtTabelaA.Height + 1)
        Call fillCLB(clbTabelaA, strSQlA, Me.ISTConnectionString)
        Me.txtTabelaA.Text = ""
    End Sub

    'Dim anApp As Boolean = False
    'Dim anTable As Boolean = False
    Private Sub bDownTB_Click(sender As Object, e As EventArgs) Handles bDownTB.Click
        Call fillTable(vtB, clbAppB, txtAppB, clbTabelaB, txtTabelaB)
    End Sub

    Private Sub bDownTC_Click(sender As Object, e As EventArgs) Handles bDownTC.Click
        Call fillTable(vtC, clbAppC, txtAppC, clbTabelaC, txtTabelaC)
    End Sub

    Private Sub bDownTD_Click(sender As Object, e As EventArgs) Handles bDownTD.Click
        Call fillTable(vtD, clbAppD, txtAppD, clbTabelaD, txtTabelaD)
    End Sub

    Sub fillTable(ByVal vt As String, ByVal clbApp As CheckedListBox, ByVal txtApp As TextBox, ByVal clbTabela As CheckedListBox, ByVal txtTabela As TextBox, Optional ByVal pom As String = "")
        If pom = "" Then pom = vt + "','" + txtApp.Text.Trim.ToUpper
        Dim strSQl As String = "select  distinct tabela as valuemember,tabela as displaymember from vISTTABELEzaDOK('" + pom + "')  order by 1"
        clbTabela.Height = Me.Height \ 5
        clbTabela.Visible = Not clbTabela.Visible

        If clbTabela.Visible = True Then clbTabela.BringToFront()
        clbTabela.Location = New Point(txtTabela.Location.X, txtTabela.Location.Y + txtTabela.Height + 1)
        Call fillCLB(clbTabela, strSQl, Me.ISTConnectionString)
        txtTabela.Text = ""
    End Sub

    Sub fillCBOformDT(ByVal cbo As System.Windows.Forms.ComboBox, ByVal fab As String)

        Dim tt As String = "NULL"
        Dim pp As String = "NULL"

        Dim dtt As New System.Data.DataTable
        dtt.Columns.Add("valuemember")
        dtt.Columns.Add("displaymember")

        dtt.Rows.Add(New Object() {tt, ""})

        For i As Integer = 0 To dvPKA.Count - 1
            If Not (dvPKA(i).Item("displaymember") Is System.DBNull.Value) AndAlso Not (dvPKA(i).Item("valuemember") Is System.DBNull.Value) Then
                tt = dvPKA(i).Item("valuemember").ToString.Trim
                pp = "A." + dvPKA(i).Item("displaymember").ToString.Trim
                dtt.Rows.Add(New Object() {tt, pp})
            End If
        Next

        If fab.IndexOf("AB") > 0 AndAlso Not dvPKB Is Nothing Then
            For i As Integer = 0 To dvPKB.Count - 1
                If Not (dvPKB(i).Item("displaymember") Is System.DBNull.Value) AndAlso Not (dvPKB(i).Item("valuemember") Is System.DBNull.Value) Then
                    tt = dvPKB(i).Item("valuemember").ToString.Trim
                    pp = "B." + dvPKB(i).Item("displaymember").ToString.Trim
                    dtt.Rows.Add(New Object() {tt, pp})
                End If
            Next
        End If

        cbo.DataSource = dtt
        cbo.DisplayMember = "displaymember"
        cbo.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtt)
        cbo.DataSource = dv

    End Sub

    Sub fillAUTBformDT(ByVal autb As AutoCompleteTextbox, ByVal fab As String)

        Dim pp As String = ""
        Dim source As Object = New List(Of String)()

        For i As Integer = 0 To dvPKA.Count - 1
            If Not (dvPKA(i).Item("displaymember") Is System.DBNull.Value) Then
                pp = "A." + dvPKA(i).Item("displaymember").ToString.Trim
                source.Add(pp)
            End If
        Next

        If fab.IndexOf("AB") >= 0 Then
            If Not dvPKB Is Nothing Then
                For i As Integer = 0 To dvPKB.Count - 1
                    If Not (dvPKB(i).Item("displaymember") Is System.DBNull.Value) Then
                        pp = "B." + dvPKB(i).Item("displaymember").ToString.Trim
                        source.Add(pp)
                    End If
                Next
            End If
            If Not dvPKC Is Nothing Then
                For i As Integer = 0 To dvPKC.Count - 1
                    If Not (dvPKC(i).Item("displaymember") Is System.DBNull.Value) Then
                        pp = "C." + dvPKC(i).Item("displaymember").ToString.Trim
                        source.Add(pp)
                    End If
                Next
            End If
            If Not dvPKD Is Nothing Then
                For i As Integer = 0 To dvPKD.Count - 1
                    If Not (dvPKD(i).Item("displaymember") Is System.DBNull.Value) Then
                        pp = "D." + dvPKD(i).Item("displaymember").ToString.Trim
                        source.Add(pp)
                    End If
                Next
            End If
        End If

        autb.AutoCompleteList = source
        autb.MinTypedCharacters = 1

        If fab.IndexOf("FAB") >= 0 Then
            autb.autoCompleteLimitToList = False
        Else
            autb.autoCompleteLimitToList = True
        End If

    End Sub

    Sub fillCLB(ByVal clb As System.Windows.Forms.CheckedListBox, ByVal str As String, ByVal kkon As String)

        Dim tt As String = "NULL"
        Dim pp As String = "NULL"

        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(str, kkon, Me.jezik)
        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "valuemember"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")

        For i As Integer = 0 To dvPK.Count - 1
            If Not (dvPK(i).Item("displaymember") Is System.DBNull.Value) AndAlso Not (dvPK(i).Item("valuemember") Is System.DBNull.Value) Then
                tt = dvPK(i).Item("valuemember").ToString.Trim
                pp = dvPK(i).Item("displaymember").ToString.Trim
                dtKon.Rows.Add(New Object() {tt, pp})
            End If
        Next

        clb.DataSource = dtKon
        clb.DisplayMember = "displaymember"
        clb.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtKon)
        clb.DataSource = dv

    End Sub

    Function fillPolja(ByVal tabela As String, ByVal clb As System.Windows.Forms.CheckedListBox, ByVal str As String, ByVal kkon As String) As DataView
        'polje as valuemember,polje + ' ' + replace(opispom,'$','') as displaymember,combobox,izraz,cbotabela,cboprikazi,cboubazu,cbofilter,rbr
        Dim tt As String = "NULL"
        Dim pp As String = "NULL"

        Dim d2 As String = "NULL"
        Dim d3 As String = "NULL"
        Dim d4 As String = "NULL"
        Dim d5 As String = "NULL"
        Dim d6 As String = "NULL"
        Dim d7 As String = "NULL"
        Dim d8 As String = "NULL"
        Dim d9 As String = "NULL"
        Dim d10 As String = "NULL"
        Dim d11 As String = "NULL"

        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(str, kkon, Me.jezik)
        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "rbr"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")

        dtKon.Columns.Add("combobox")
        dtKon.Columns.Add("izraz")
        dtKon.Columns.Add("cbotabela")
        dtKon.Columns.Add("cboprikazi")
        dtKon.Columns.Add("cboubazu")
        dtKon.Columns.Add("cbofilter")

        dtKon.Columns.Add("polje")
        dtKon.Columns.Add("tabela")
        dtKon.Columns.Add("cboprikaziO")
        dtKon.Columns.Add("opisPom")
        dtKon.Columns.Add("tabdisplaymember")

        For i As Integer = 0 To dvPK.Count - 1
            'uvek
            If Not (dvPK(i).Item("valuemember") Is System.DBNull.Value) Then tt = dvPK(i).Item("valuemember").ToString.Trim
            If Not (dvPK(i).Item("displaymember") Is System.DBNull.Value) Then pp = dvPK(i).Item("displaymember").ToString.Trim
            If Not (dvPK(i).Item("tabela") Is System.DBNull.Value) Then d8 = dvPK(i).Item("tabela").ToString.Trim
            If Not (dvPK(i).Item("opisPom") Is System.DBNull.Value) Then d10 = dvPK(i).Item("opisPom").ToString.Trim
            If Not (dvPK(i).Item("polje") Is System.DBNull.Value) Then d7 = dvPK(i).Item("polje").ToString.Trim

            dtKon.Rows.Add(New Object() {tt, pp, "0", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", tabela + "." + pp})

            'cbo
            If Not dvPK(i).Item("combobox") Is System.DBNull.Value AndAlso dvPK(i).Item("combobox").ToString.Trim = "1" Then
                If Not (dvPK(i).Item("cboubazu") Is System.DBNull.Value) Then tt = dvPK(i).Item("cboubazu").ToString.Trim
                If Not (dvPK(i).Item("cboprikazi") Is System.DBNull.Value) Then pp = dvPK(i).Item("cboprikazi").ToString.Trim
                If Not (dvPK(i).Item("izraz") Is System.DBNull.Value) Then d2 = dvPK(i).Item("izraz").ToString.Trim
                If Not (dvPK(i).Item("cbotabela") Is System.DBNull.Value) Then d3 = dvPK(i).Item("cbotabela").ToString.Trim
                If Not (dvPK(i).Item("cboprikazi") Is System.DBNull.Value) Then d4 = dvPK(i).Item("cboprikazi").ToString.Trim
                If Not (dvPK(i).Item("cboubazu") Is System.DBNull.Value) Then d5 = dvPK(i).Item("cboubazu").ToString.Trim
                If Not (dvPK(i).Item("cbofilter") Is System.DBNull.Value) Then d6 = dvPK(i).Item("cbofilter").ToString.Trim
                If Not (dvPK(i).Item("cboprikaziO") Is System.DBNull.Value) Then d9 = dvPK(i).Item("cboprikaziO").ToString.Trim '& "_" & CStr(i).Trim

                dtKon.Rows.Add(New Object() {tt, d9, "1", d2, d3, d4, d5, d6, d7, d8, d9, d10, tabela + "." + d9})
            End If
        Next

        clb.DataSource = dtKon
        clb.DisplayMember = "displaymember"
        clb.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtKon)
        clb.DataSource = dv

        fillPolja = dv

    End Function

    Function CBOdatasource(ByVal izraz As String) As String
        Dim str As String = ""
        If izraz.Length > 0 Then
            izraz = zamena(izraz)
            If izraz Is Nothing Then izraz = ""
        End If

        Dim izvorCBO As String = ""
        Dim prikaziCBO As String = ""
        Dim upisiCBO As String = ""
        Dim prenesiCBO As String = ""
        CBOdatasource = ""
        Dim sta As String = izraz.Trim
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        sta = sta.Substring(0, sta.Length - 1)
        sta = sta.Replace("}", "")
        Dim nizCB As String() = Microsoft.VisualBasic.Split(sta, ";")
        For ii As Integer = 0 To nizCB.GetUpperBound(0)
            If nizCB(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                CBOdatasource = nizCB(ii).Replace("IZVOR=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                CBOdatasource = nizCB(ii).Replace("DATASOURCE=", "")
            End If
        Next

    End Function

    Function srediFilter(ByVal izraz As String) As String

        If izraz.Length > 0 Then
            izraz = zamena(izraz)
            If izraz Is Nothing Then izraz = ""
        End If
        Dim filterCBO As String = ""
        Dim sta As String = izraz.Trim
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        sta = sta.Substring(0, sta.Length - 1)
        sta = sta.Replace("}", "")

        Dim nizCB As String() = Microsoft.VisualBasic.Split(sta, ";")
        For ii As Integer = 0 To nizCB.GetUpperBound(0)
            If nizCB(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                filterCBO = nizCB(ii).Replace("FILTER=", "") 'naselje_maticni_broj=d.sif_Naselja
                Dim pp() As String = filterCBO.Split("=")
                Dim ff As String = ""
                Dim poc As String = ""
                For i As Integer = 0 To pp.GetUpperBound(0)
                    If pp(i).Trim.ToUpper.IndexOf("D.") = 0 Then
                        pp(i) = ttabela + "." + pp(i).Trim.ToUpper.Replace("D.", "")
                    Else
                        pp(i) = cCBOtabela + "." + pp(i)
                    End If
                Next
                izraz = pp(0) + "=" + pp(1)
            End If
        Next
        If filterCBO = "" Then
            srediFilter = "2=2"
        Else
            srediFilter = izraz
        End If

    End Function

    Function srediIzraz(ByVal uf As String, ByVal izraz As String, ByVal ccolumnname As String, ByVal fil As String) As String
        Dim fromCL As String = ""
        Dim ffilter As String = ""
        Dim ppoc As String = ""

        If izraz.Length > 0 Then
            izraz = zamena(izraz)
            If izraz Is Nothing Then izraz = ""
        End If

        Dim izvorCBO As String = ""
        Dim prikaziCBO As String = ""
        Dim upisiCBO As String = ""
        Dim filterCBO As String = ""
        Dim prenesiCBO As String = ""

        Dim sta As String = izraz.Trim
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        sta = sta.Substring(0, sta.Length - 1)
        sta = sta.Replace("}", "")

        Dim nizCB As String() = Microsoft.VisualBasic.Split(sta, ";")
        For ii As Integer = 0 To nizCB.GetUpperBound(0)
            If nizCB(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                izvorCBO = nizCB(ii).Replace("IZVOR=", "")
                fromCL = izvorCBO.Substring(izvorCBO.ToUpper.IndexOf("FROM"))
            End If

            If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                izvorCBO = nizCB(ii).Replace("DATASOURCE=", "")
                fromCL = izvorCBO.Substring(izvorCBO.ToUpper.IndexOf("FROM"))
            End If

            If nizCB(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                filterCBO = nizCB(ii).Replace("FILTER=", "") 'naselje_maticni_broj=d.sif_Naselja
                Dim pp() As String = filterCBO.Split("=")
                Dim ff As String = ""
                Dim poc As String = ""
                For i As Integer = 0 To pp.GetUpperBound(0)
                    If pp(i).Trim.ToUpper.IndexOf("D.") = 0 Then
                        If pp(i).Trim.ToUpper.Replace("D.", "") = ccolumnname.Trim.ToUpper Then
                            ff = fil
                        End If
                    Else
                        poc = pp(i)
                        ppoc = poc + ","
                    End If
                Next
                If ff <> "" Then
                    ffilter = poc & fil
                Else
                    ffilter = "2=2"
                End If
            End If
        Next

        If uf = "2=2" Then
            ffilter = "2=2"
        Else
            uf = Replace(uf, "and", "~", 1, , CompareMethod.Text)
            Dim pp() As String = uf.Split("~")
            For i As Integer = 0 To pp.GetUpperBound(0)
                Dim ppp() As String = pp(i).Split("$")
                If ppp(0).Trim.ToUpper = cCBOubazu.Trim.ToUpper OrElse ppp(0).Trim.ToUpper = cCBOprikaziO.Trim.ToUpper Then
                    ffilter = ffilter + " and " + pp(i).Replace("$", "")
                End If
            Next
        End If

        fromCL = fromCL.Trim
        If fromCL.ToUpper.IndexOf("WHERE") < 0 AndAlso Mid(fromCL, Len(fromCL), 1) = ")" Then
            fromCL = Mid(fromCL, 1, Len(fromCL) - 1)
        End If

        If fromCL.Trim.ToUpper.IndexOf("WHERE") < 0 Then
            izraz = "select distinct " + ppoc + cCBOubazu + " ," + cCBOprikaziO + " " + fromCL + " where " + ffilter + " order by " + ppoc.Replace(",", "")
        Else
            izraz = "select distinct " + ppoc + cCBOubazu + "," + cCBOprikaziO + " " + fromCL + " and " + ffilter + " order by " + ppoc.Replace(",", "")
        End If

        srediIzraz = izraz
    End Function

    Sub txtTC(ByVal clb As CheckedListBox, ByVal txt As TextBox)

        clb.Visible = True
        clb.BringToFront()
        Dim vred As String = txt.Text
        Dim dv As New System.Data.DataView
        dv = clb.DataSource
        If IsNumeric(vred) = False Then
            Dim vredCir As String = konverzijaLatCir(vred)
            Dim vredLat As String = konverzijaCirLat(vred)
            dv.RowFilter = "displaymember Like '%" & vredCir & "%' OR displaymember LIKE '%" & vredLat & "%'"
        Else
            dv.RowFilter = "displaymember Like '%" & vred & "%'"
        End If
        clb.DataSource = dv

        clb.Height = dv.Count * 20
        If clb.Height > Me.Height \ 4 Then clb.Height = Me.Height \ 4
    End Sub

    Dim dvPKA As New DataView
    Dim dvPKARBR As New DataView

    Dim dvPKB As New DataView
    Dim dvPKBRBR As New DataView

    Dim dvPKC As New DataView
    Dim dvPKCRBR As New DataView

    Dim dvPKD As New DataView
    Dim dvPKDRBR As New DataView

    Sub fillFAB()
        For Each cntl As Control In Me.panelCondition.Controls
            If TypeOf cntl Is AutoCompleteTextbox AndAlso cntl.Name.Replace("actb", "").IndexOf("FAB") = 0 Then
                Call fillAUTBformDT(DirectCast(cntl, AutoCompleteTextbox), "FAB")
            End If
        Next
    End Sub

    Sub fillAB()
        For Each cntl As Control In Me.panelCondition.Controls
            If TypeOf cntl Is AutoCompleteTextbox AndAlso cntl.Name.Replace("actb", "").IndexOf("AB") = 0 Then
                Call fillAUTBformDT(DirectCast(cntl, AutoCompleteTextbox), "AB")
            End If
        Next
    End Sub

    Sub fillA()
        For Each cntl As Control In Me.panelCondition.Controls
            If TypeOf cntl Is AutoCompleteTextbox AndAlso cntl.Name.Replace("actb", "").IndexOf("A") = 0 AndAlso cntl.Name.Replace("actb", "").IndexOf("AB") < 0 Then
                Call fillAUTBformDT(DirectCast(cntl, AutoCompleteTextbox), "A")
            End If
        Next
    End Sub

    Dim fieldsPart As String
    Dim fromPart As String

    Sub part(ByVal clbFilter As CheckedListBox, ByVal clbTabela As CheckedListBox,
             ByVal ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal sifist As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If clbFilter.CheckedItems.Count = 0 Then
            ISTMessageBox.Show("Please, choose fields for filtering by ")
            clbFilter.Focus()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        Else
            Dim dv As DataView = clbFilter.DataSource
            Dim notIn As String = ""
            ttabela = clbTabela.SelectedValue.Trim

            Dim pomDTbl As DataTable = Nothing
            pomDTbl = dv.ToTable()
            Dim dvq As New DataView(pomDTbl)

            Dim vrt As String = imaGODMES(dvq, ttabela)

            Dim strTP As String = ""
            If vrt <> "" AndAlso vrt.IndexOf("GOD") > -1 Then strTP = strTP + " and god='" + ucvt.G.ToString + "'"
            If vrt <> "" AndAlso vrt.IndexOf("MES") > -1 Then strTP = strTP + " and mes='" + String.Format("{0:d2}", ucvt.M) + "'"
            If vrt <> "" AndAlso vrt.IndexOf("ISTYEAR") > -1 Then strTP = strTP + " and ISTYEAR='" + ucvt.G.ToString + "'"
            If vrt <> "" AndAlso vrt.IndexOf("ISTMONTH") > -1 Then strTP = strTP + " and ISTMONTH=''" + String.Format("{0:d2}", ucvt.M) + "'"

            fieldsPart = ""

            If strTP <> "" Then
                fromPart = "(select * from " + ttabela + " where 2=2 " & strTP + " )  as " + ttabela
            Else
                fromPart = ttabela
            End If

            For Each itemChecked As Object In clbFilter.CheckedItems
                Dim si As Integer = clbFilter.Items.IndexOf(itemChecked)
                Dim dvrow As DataRow = dv(si).Row

                If dvrow.Item("combobox").ToString = "1" Then
                    'iscombobox = 1
                    ppolje = dvrow.Item("polje").ToString
                    cCBOprikazi = dvrow.Item("CBOprikazi").ToString
                    cCBOprikaziO = dvrow.Item("CBOprikazio").ToString
                    cCBOubazu = dvrow.Item("CBOubazu").ToString
                    ttabela = dvrow.Item("tabela").ToString
                    iizraz = dvrow.Item("izraz").ToString
                    cCBOtabela = dvrow.Item("CBOtabela").ToString
                    ccboFilter = srediFilter(dvrow.Item("izraz").ToString)
                    cCBOtabelaIzraz = CBOdatasource(dvrow.Item("izraz").ToString)
                    If cCBOtabelaIzraz.Trim.IndexOf("(") < 0 AndAlso cCBOtabelaIzraz.Trim.ToUpper.IndexOf("SELECT") = 0 Then cCBOtabelaIzraz = "(" + cCBOtabelaIzraz + ")"

                    If fieldsPart.Trim.ToUpper.IndexOf(ttabela.Trim.ToUpper + "." + ppolje.Trim.ToUpper & ",") < 0 Then
                        fieldsPart = fieldsPart & ttabela + "." + ppolje & "," + cCBOtabela + "." + cCBOprikaziO + ","
                    ElseIf fieldsPart.Trim.ToUpper.IndexOf(cCBOtabela.Trim.ToUpper + "." + cCBOprikaziO.ToUpper & ",") < 0 Then
                        fieldsPart = fieldsPart & cCBOtabela + "." + cCBOprikaziO + ","
                    End If

                    If fromPart.Trim.ToUpper.IndexOf(cCBOtabelaIzraz.Trim.ToUpper & " AS ") < 0 Then
                        fromPart = fromPart + " inner join " + cCBOtabelaIzraz + " as " + cCBOtabela + " on " + ccboFilter + " and " + ttabela + "." + ppolje + "=" + cCBOtabela + "." + cCBOubazu
                    End If
                Else
                    'iscombobox = 0
                    If fieldsPart.Trim.ToUpper.IndexOf(ttabela.Trim.ToUpper + "." + dvrow.Item("valuemember").ToString.Trim.ToUpper & ",") < 0 Then fieldsPart = fieldsPart & ttabela + "." + dvrow.Item("valuemember").ToString.Trim.ToUpper & ","
                End If

                notIn = notIn + "'" & dvrow.Item("valuemember").ToString.Trim.ToUpper & "',"

            Next

            notIn = notIn + "$"
            notIn = " and polje not in (" + notIn.Replace(",$", ")")

            fieldsPart = (fieldsPart + "$").Replace(",$", "")
            Dim str As String = "select distinct " + fieldsPart + " from " + fromPart + " order by " + fieldsPart

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As New System.Data.DataTable
            Dim sql As String = " select pravaBaza,konekcija,naziv,periodika,server from vBazaServer where sifist='" + sifist + "'"
            dt = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)

            Dim dbName As String = dt.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim
            Dim dbServerName As String = dt.Rows(0).Item("server").ToString.ToUpper.Trim

            Dim dgvConn As String = getConnectionString(dbServerName, dbName, txtmode, Me.DBConnectionString)
            Call popuniDGridView(dgv, dgvConn, str, Me.jezik)
            Call srediGridView(dgv, False, 30)

            Call nijeZaSort(dgv)
            dgv.Visible = True

            lblDistinctCount.Text = "Distinct Count - " & dgv.Rows.Count.ToString
            lblDistinctCount.Visible = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub ButtonFieldA_Click(sender As Object, e As EventArgs) Handles ButtonFieldA.Click
        Call part(clbFilterA, clbTabelaA, ucvtA, sifistA.ToString.Trim.ToUpper)
    End Sub

    Private Sub ButtonFieldB_Click(sender As Object, e As EventArgs) Handles ButtonFieldB.Click
        Call part(clbFilterB, clbTabelaB, ucvtB, txtAppB.Text.Trim.ToUpper)
    End Sub

    Private Sub buttonFieldC_Click(sender As Object, e As EventArgs) Handles ButtonFieldC.Click
        Call part(clbFilterC, clbTabelaC, ucvtC, txtAppC.Text.Trim.ToUpper)
    End Sub

    Private Sub buttonFieldD_Click(sender As Object, e As EventArgs) Handles ButtonFieldD.Click
        Call part(clbFilterD, clbTabelaD, ucvtD, txtAppD.Text.Trim.ToUpper)
    End Sub

    Function imaGODMES(ByVal dv As DataView, ByVal tabela As String) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView
        dvG = dv
        dvG.RowFilter = "valuemember='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView
        dvM = dv
        dvM.RowFilter = "valuemember='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView
        dvGE = dv
        dvGE.RowFilter = "valuemember='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView
        dvME = dv
        dvME.RowFilter = "valuemember='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        If imaG = True Then s = s + "$GOD$"
        If imaM = True Then s = s + "$MES$"
        If imaGE = True Then s = s + "$ISTYEAR$"
        If imaME = True Then s = s + "$ISTMONTH$"

        imaGODMES = s
    End Function

    '*********************ISTCOmboBox
    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")

    End Sub

    '**********************************
    Sub srediformu()
        Dim ww As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width()
        Dim hh As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height()
        Dim xx As Integer = ww - (ButtonISTIzlaz.Width + 25)
        Me.ButtonISTIzlaz.Location = New System.Drawing.Point(xx, 8)
    End Sub

    Dim iscombobox As Integer
    Dim iizraz As String = ""
    Dim ppolje As String = ""
    Dim cCBOprikazi As String = ""
    Dim cCBOprikaziO As String = ""
    Dim ccboFilter As String = ""
    Dim cCBOubazu As String = ""
    Dim ttabela As String = ""
    Dim cCBOtabela As String = ""
    Dim cCBOtabelaIzraz As String = ""

    Sub nijeZaSort(ByVal dg As DataGridView)
        Dim dt As DataTable = dg.DataSource
        For i As Integer = 0 To dg.Columns.Count - 1
            Dim kolTip As String = dt.Columns(i).DataType.Name
            If Not (kolTip = "Boolean" OrElse kolTip = "Char" OrElse kolTip = "DateTime" OrElse kolTip = "Guid" OrElse kolTip = "String" OrElse kolTip = "TimeSpan") Then
                dg.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            dg.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

    Private Sub mnuNumber_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuNumber.ItemClicked

        Dim vvalue As String = dgv.CurrentCell.Value.ToString()
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        For Each mi As Object In mnuNumber.Items
            If TypeOf mi Is ToolStripMenuItem Then mi.Checked = False
        Next
        currentItem.Checked = True
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuNumber.Tag
        If f = "NHIDE" Then dgv.Columns(k).Visible = False : dgv.Columns(k).Tag = "H"
        If f = "NUNHIDE" Then
            For i As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(i).Tag = "H" Then dgv.Columns(i).Visible = True : dgv.Columns(i).Tag = ""
            Next
        End If
        If f = "NEQUALS" Then Call filterEqualsNotEquals(k, "=", vvalue)
        If f = "NNOTEQUAL" Then Call filterEqualsNotEquals(k, "<>", vvalue)

        If f = "NGREATERTHAN" Then Call filterEqualsNotEquals(k, ">", vvalue)
        If f = "NGREATERTHANOREQUAL" Then Call filterEqualsNotEquals(k, ">=", vvalue)
        If f = "NLESSTHAN" Then Call filterEqualsNotEquals(k, "<", vvalue)
        If f = "NLESSTHANOREQUAL" Then Call filterEqualsNotEquals(k, "<=", vvalue)

        If f = "NUNFILTER" Then Call Unfilter()
        If f = "NSORT" Then
            Select Case dgv.SortOrder
                Case System.Windows.Forms.SortOrder.Ascending
                    dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                Case Else
                    dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
            End Select
        End If
        If f = "NMULTICOLUMNSORT" Then Call multicolumnsort(dgv)
        If f = "NFIND" Then Call findInDGV(dgv, k)

    End Sub

    Private Sub filterEqualsNotEquals(ByVal columnName As String, ByVal oper As String, ByVal vvalue As String)

        Dim fil As String = oper & vvalue
        If vvalue Is Nothing OrElse vvalue = "" Then
            If oper = "<>" Then fil = " is not null"
            If oper = ">" OrElse oper = ">=" Then fil = " is not null"
            If oper = "<" OrElse oper = "<=" Then fil = " < 0 "
            If oper = "=" Then fil = " is null"
        End If

        uuslovFilter = uuslovFilter & " and " & columnName & "$" & fil

        Dim dtTop As DataTable = dgv.DataSource
        dgv.Tag = dtTop
        dtTop.DefaultView.RowFilter = columnName & fil
        Dim dtFilter As DataTable = dtTop.DefaultView.ToTable.Copy
        dgv.DataSource = dtFilter

    End Sub

    Private Sub mnuString_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuString.ItemClicked

        Dim vvalue As String = dgv.CurrentCell.Value.ToString()

        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        For Each mi As Object In mnuString.Items
            If TypeOf mi Is ToolStripMenuItem Then mi.Checked = False
        Next
        currentItem.Checked = True
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuString.Tag
        If f = "SHIDE" Then dgv.Columns(k).Visible = False : dgv.Columns(k).Tag = "H"
        If f = "SUNHIDE" Then
            For i As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(i).Tag = "H" Then dgv.Columns(i).Visible = True : dgv.Columns(i).Tag = ""
            Next
        End If
        If f = "SEQUALS" Then Call filterStringEqualsNotEquals(k, "", "", vvalue, "")
        If f = "SNOTEQUAL" Then Call filterStringEqualsNotEquals(k, "not", "", vvalue, "")

        If f = "SBEGINSWITH" Then Call filterStringEqualsNotEquals(k, "", "", vvalue, "%")
        If f = "SNOTBEGINWITH" Then Call filterStringEqualsNotEquals(k, "not", "", vvalue, "%")

        If f = "SCONTAINSSWITH" Then Call filterStringEqualsNotEquals(k, "", "%", vvalue, "%")
        If f = "SNOTCONTAINWITH" Then Call filterStringEqualsNotEquals(k, "not", "%", vvalue, "%")

        If f = "SENDSSWITH" Then Call filterStringEqualsNotEquals(k, "", "%", vvalue, "")
        If f = "SNOTENDWITH" Then Call filterStringEqualsNotEquals(k, "not", "%", vvalue, "")

        If f = "SUNFILTER" Then Call Unfilter()
        If f = "SSORT" Then
            Select Case dgv.SortOrder
                Case System.Windows.Forms.SortOrder.Ascending
                    dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                Case Else
                    dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
            End Select
        End If
        If f = "SMULTICOLUMNSORT" Then Call multicolumnsort(dgv)
        If f = "SFIND" Then Call findInDGV(dgv, k)

    End Sub

    Dim uuslovFilter As String = ""

    Private Sub filterStringEqualsNotEquals(ByVal columnName As String, ByVal notOper As String, ByVal per1 As String, ByVal vvalue As String, ByVal per2 As String)

        Dim uslov As String = ""

        Dim fil As String = " " & notOper & " like '" & per1 & vvalue & per2 & "'"
        If vvalue Is Nothing OrElse vvalue = "" Then
            If notOper = "" Then fil = " is null"
            If notOper = "not" Then fil = " is not null"
        End If

        uuslovFilter = uuslovFilter & " and " & columnName & "$" & fil
        Dim dtTop As DataTable = dgv.DataSource
        dgv.Tag = dtTop
        dtTop.DefaultView.RowFilter = columnName & fil
        Dim dtFilter As DataTable = dtTop.DefaultView.ToTable.Copy
        dgv.DataSource = dtFilter

        uuslovFilter = uuslovFilter.Replace("like '", "like N'")

    End Sub

    Private Sub Unfilter()
        uuslovFilter = "2=2"
        If Not dgv.Tag Is Nothing Then
            Dim dtSve As DataTable = dgv.Tag
            dtSve.DefaultView.RowFilter = "2=2"
            dgv.DataSource = dtSve.DefaultView.ToTable
            For i As Integer = 0 To dgv.Columns.Count - 1
                Dim kol As String = dgv.DataSource.Columns(i).ColumnName.ToString.Trim.ToUpper
                If dgv.Columns(i).Tag = "H" AndAlso kol.IndexOf("_NEC") < 0 Then dgv.Columns(i).Visible = True : dgv.Columns(i).Tag = ""
            Next
            dgv.Tag = Nothing
        End If

    End Sub

    Sub multicolumnsort(ByVal dg As DataGridView)

        Dim dgvC As String = ""
        For Each dgvCol As DataGridViewColumn In dg.Columns
            dgvC = dgvC + dgvCol.HeaderText + "$"
        Next

        Dim fsort As New IstrazivanjaUnos.FormSort(Me, dgvC)
        Dim kako As String = ""
        Dim strOrderby As String = ""
        If fsort.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            strOrderby = fsort.SortOrder
            Dim dt As System.Data.DataTable
            dt = dg.DataSource
            Dim dv As New DataView(dt)
            dv.Sort = strOrderby
            dt = dv.ToTable()
            dg.DataSource = dt
        End If

    End Sub

    Sub findInDGV(ByVal dg As DataGridView, ByVal k As String)
        Dim ffind As New IstrazivanjaUnos.FormFind(Me, dg, k, dgv.Right, dgv.Top)
        ffind.Show()
    End Sub

    Private Sub dgva_MouseDown(sender As Object, e As MouseEventArgs) Handles dgv.MouseDown

        Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        dgvMouseDown(dg, e)

    End Sub

    Sub dgvMouseDown(ByVal dg As DataGridView, ByVal e As MouseEventArgs)

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dt As DataTable = dg.DataSource
        Dim ht As DataGridView.HitTestInfo
        ht = dg.HitTest(e.X, e.Y)
        If ht.Type = DataGridViewHitTestType.Cell OrElse ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Dim kol As String = dt.Columns(ht.ColumnIndex).Caption
            Dim kolTip As String = dt.Columns(ht.ColumnIndex).DataType.Name

            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                If dg.Columns.Count < 100 Then

                    If kolTip = "Boolean" Then

                    End If
                    If kolTip = "String" OrElse kolTip = "Char" OrElse kolTip = "DateTime" OrElse kolTip = "TimeSpan" Then
                        dg.ContextMenuStrip = mnuString
                        mnuString.Tag = kol
                    End If

                    If kolTip = "Decimal" OrElse kolTip = "Int32" OrElse kolTip = "Int64" OrElse kolTip = "Guid" Then
                        dg.ContextMenuStrip = mnuNumber
                        mnuNumber.Tag = kol
                    End If
                Else
                    dg.ContextMenuStrip = Nothing

                    ''msg 246
                    Dim msgtxt246 As String = getMessageText(dtMessages, "246", Me.jezik)
                    ''msg 247
                    Dim msgtxt247 As String = getMessageText(dtMessages, "247", Me.jezik)
                    ''msg 248
                    Dim msgtxt248 As String = getMessageText(dtMessages, "248", Me.jezik)
                    ''msg 249
                    Dim msgtxt249 As String = getMessageText(dtMessages, "249", Me.jezik)

                    Dim poruka As String = msgtxt246 + Str(dg.ColumnCount).Trim + msgtxt247 + nvrd + nvrd
                    poruka = poruka + msgtxt248 + nvrd + msgtxt249
                    ISTMessageBox.Show(poruka, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                'MouseButtons.left
                Dim sumK As String = "Sum: "
                Dim countK As String = "Count: "
                Dim minK As String = "Min: "
                Dim maxK As String = "Max: "
                Dim avgK As String = "Avg: "

                Dim tt As String = ""
                tt = kol + "   "
                If (dt.Columns(kol).DataType.ToString() = "System.String") Then
                    tt = tt + "   " + countK + dt.Compute("count(" + kol + ")", "").ToString
                    tt = tt + "   " + minK + dt.Compute("min(" + kol + ")", "").ToString
                    tt = tt + "   " + maxK + dt.Compute("max(" + kol + ")", "").ToString
                ElseIf (dt.Columns(kol).DataType.ToString() = "System.Boolean") Then
                    tt = tt + "   " + countK + dt.Compute("count(" + kol + ")", "").ToString
                    'broj sa 0 false
                    'broj sa 1 true
                ElseIf (dt.Columns(kol).DataType.ToString() = "System.DateTime") Then
                    tt = tt + "   " + countK + dt.Compute("count(" + kol + ")", "").ToString
                    'broj sa 0 false
                    'broj sa 1 true
                Else
                    tt = tt + "   " + countK + dt.Compute("count(" + kol + ")", "").ToString
                    tt = tt + "   " + sumK + dt.Compute("Sum(" + kol + ")", "").ToString
                    tt = tt + "   " + minK + dt.Compute("min(" + kol + ")", "").ToString
                    tt = tt + "   " + maxK + dt.Compute("max(" + kol + ")", "").ToString
                    tt = tt + "   " + avgK + dt.Compute("avg(" + kol + ")", "").ToString
                End If

                Dim lblBrojredova As String = ""

            End If
        Else
            dg.ContextMenuStrip = Nothing
        End If
    End Sub

    Dim tabeleJoin() As String
    Dim koloneJoin() As String
    Dim bazaPrefiksJoin() As String
    Dim aliasJoin() As String
    Dim iJoin As Integer
    Dim strJoin As String = ""

    Sub ppp(ByVal i As Integer, ByVal tabela As String, ByVal clb As CheckedListBox, ByVal slovo As String, ByVal dbname As String, ByVal dbserver As String)

        iJoin = iJoin + 1
        ReDim Preserve bazaPrefiksJoin(iJoin)

        Dim prefiks As String = "dbo."
        If tabela.Trim.IndexOf(".") > 0 Then prefiks = ""
        bazaPrefiksJoin(iJoin) = dbname + "." + prefiks

        ReDim Preserve tabeleJoin(iJoin)
        'tabeleJoin(iJoin) = dbname + "." + prefiks + tabela + " AS " + slovo
        tabeleJoin(iJoin) = tabela '+ " AS " + slovo

        ReDim Preserve aliasJoin(iJoin)
        aliasJoin(iJoin) = slovo

        ReDim Preserve koloneJoin(iJoin)
        For it As Integer = 0 To clb.Items.Count - 1
            koloneJoin(iJoin) = koloneJoin(iJoin) + clb.Items(it).Row.Item("valuemember").ToString + "$"
        Next
        koloneJoin(iJoin) = koloneJoin(iJoin) + "$"
        koloneJoin(iJoin) = koloneJoin(iJoin).Replace("$$", "")
    End Sub

    Private Sub bJoin_Click(sender As Object, e As EventArgs) Handles bJoin.Click
        Call jjoin()
    End Sub

    Sub jjoin()
        iJoin = -1
        tabeleJoin = Nothing
        koloneJoin = Nothing
        If txtTabelaA.Text <> "" Then Call ppp(iJoin, txtTabelaA.Text, clbFilterA, "A", dbNameA, dbServerNameA)
        If txtTabelaB.Text <> "" Then Call ppp(iJoin, txtTabelaB.Text, clbFilterB, "B", dbNameB, dbServerNameB)
        If txtTabelaC.Text <> "" Then Call ppp(iJoin, txtTabelaC.Text, clbFilterC, "C", dbNameC, dbServerNameC)
        If txtTabelaD.Text <> "" Then Call ppp(iJoin, txtTabelaD.Text, clbFilterD, "D", dbNameD, dbServerNameD)

        Dim fJoin As FormJoin = New FormJoin(Me, tabeleJoin, koloneJoin, bazaPrefiksJoin, aliasJoin)
        Dim kako As String = ""
        strJoin = ""
        If fJoin.ShowDialog() = System.Windows.Forms.DialogResult.OK Then strJoin = fJoin.strJOIN
    End Sub

    'Private Sub bReset_Click(sender As Object, e As EventArgs) Handles bReset.Click
    '    Call refreshAll()
    '    'Me.txtSQLUpdate.Text = ""
    'End Sub
    '*****************
    Function zamena(ByVal sta As String) As String

        sta = sta.ToUpper.Trim
        sta = Replace(sta, "MULTILINE", "", 1, , CompareMethod.Text)
        sta = Replace(sta, "FONTBOLD", "", 1, , CompareMethod.Text)
        sta = Replace(sta, "BORDERNONE", "", 1, , CompareMethod.Text)
        sta = Replace(sta, "BORDERFIXED", "", 1, , CompareMethod.Text)
        sta = Replace(sta.Trim, "READONLY", "", 1, , CompareMethod.Text)
        sta = Replace(sta.Trim, "PDESNOP", "", 1, , CompareMethod.Text)
        sta = Replace(sta.Trim, "FRIGHTA", "", 1, , CompareMethod.Text)
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        If sta.Length > 0 Then sta = sta.Substring(0, sta.Length - 1)
        'sta = sta.Replace("}", "")
        'zamena GGGMMM
        sta = sta.Trim.ToUpper
        sta = strrpl(sta, "{GGG}", "'" + Me.mvtA.G.ToString + "'")
        sta = strrpl(sta, "{MMM}", "'" + String.Format("{0:d2}", Me.mvtA.M) + "'")
        sta = strrpl(sta, "{YYY}", "'" + Me.mvtA.G.ToString + "'")

        sta = GGMMGoreDole(sta, Me.mvtA.G, Me.mvtA.M)
        sta = strrpl(sta, "VRTACKA", Me.mvtA.vtwhere(""))
        sta = strrpl(sta, "GGG", Me.mvtA.GWhere(""))
        sta = strrpl(sta, "MMM", Me.mvtA.mWhere(""))
        sta = strrpl(sta, "YYY", Me.mvtA.YWhere(""))

        sta = sta.Replace(ChrW(26), "")
        Return sta
    End Function
    Dim sset As String = ""
    Dim uupdate As String = ""

    Private Sub bUpdate_Click(sender As Object, e As EventArgs) Handles bUpdate.Click

        Dim sql As String = Me.txtSQLUpdate.Text
        If Sql <> "" Then
            Dim ok1 As String = izvrsiSQL(Sql, Me.ISTConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER36", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

    End Sub

    Private Sub txtAppB_TextChanged(sender As Object, e As EventArgs) Handles txtAppB.TextChanged
        Call txtTC(clbAppB, txtAppB)
    End Sub

    Private Sub txtAppC_TextChanged(sender As Object, e As EventArgs) Handles txtAppC.TextChanged
        Call txtTC(clbAppC, txtAppC)
    End Sub

    Private Sub txtAppD_TextChanged(sender As Object, e As EventArgs) Handles txtAppD.TextChanged
        Call txtTC(clbAppD, txtAppD)
    End Sub

    Private Sub bDownAppB_Click(sender As Object, e As EventArgs) Handles bDownAppB.Click
        Call bAddTable(clbAppB, txtAppB, "'" + sifistA + "'")
    End Sub

    Private Sub bDownAppC_Click(sender As Object, e As EventArgs) Handles bDownAppC.Click
        Call bAddTable(clbAppC, txtAppC, "'" + sifistA + "','" + txtAppB.Text.Trim.ToUpper + "'")
    End Sub

    Private Sub bDownAppD_Click(sender As Object, e As EventArgs) Handles bDownAppD.Click
        Call bAddTable(clbAppD, txtAppD, "'" + sifistA + "','" + txtAppB.Text.Trim.ToUpper + "','" + txtAppC.Text.Trim.ToUpper + "'")
    End Sub

    Private Sub bAddTable(ByVal clbApp As CheckedListBox, ByVal txtApp As TextBox, ByVal sifreist As String)
        clbApp.Height = Me.Height \ 4
        clbApp.Visible = Not clbApp.Visible
        ' Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST where appcode not in (" + sifreist + ") order by 1"
        Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST   order by 1"
        If clbApp.Visible = True Then clbApp.BringToFront()
        Call fillCLB(clbApp, strSQl, Me.ISTConnectionString)
        txtApp.Text = ""
    End Sub

    Private Sub clbAppB_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppB.ItemCheck
        Call fillApp(sender, e, vtB, clbAppB, clbTabelaB, lbltabelaB, bDownTB, txtTabelaB, txtAppB)
        lbltabelaB.Visible = True
        lbltabelaB.Location = New Point(Me.lblApp.Location.X, txtAppB.Location.Y + txtAppB.Height + 1)
        txtTabelaB.Location = New Point(Me.txtAppB.Location.X, txtAppB.Location.Y + txtAppB.Height + 1)
        bDownTB.Location = New Point(Me.txtTabelaB.Location.X + txtTabelaB.Width + 1, txtTabelaB.Location.Y)
        bAddTableC.Location = New Point(Me.bDownTB.Location.X + bDownTB.Width + 1, bDownTB.Location.Y)
        bRemoveTableB.Location = New Point(Me.bAddTableC.Location.X, bAddTableC.Location.Y + bAddTableC.Height + 1)
    End Sub

    Private Sub clbAppC_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppC.ItemCheck
        Call fillApp(sender, e, vtC, clbAppC, clbTabelaC, Nothing, bDownTC, txtTabelaC, txtAppC)

        txtTabelaC.Location = New Point(Me.txtAppC.Location.X, txtAppC.Location.Y + txtAppC.Height + 1)
        bDownTC.Location = New Point(Me.txtTabelaC.Location.X + txtTabelaC.Width + 1, txtTabelaC.Location.Y)
        bAddTableD.Location = New Point(Me.bDownTC.Location.X + bDownTC.Width + 1, bDownTC.Location.Y)
        bRemoveTableC.Location = New Point(Me.bAddTableD.Location.X, bAddTableD.Location.Y + bAddTableD.Height + 1)
    End Sub

    Private Sub clbAppD_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppD.ItemCheck
        Call fillApp(sender, e, vtD, clbAppD, clbTabelaD, Nothing, bDownTD, txtTabelaD, txtAppD)
        txtTabelaD.Location = New Point(Me.txtAppD.Location.X, txtAppD.Location.Y + txtAppD.Height + 1)
        bDownTD.Location = New Point(Me.txtTabelaD.Location.X + txtTabelaD.Width + 1, txtTabelaD.Location.Y)
        bRemoveTableD.Location = New Point(Me.bDownTD.Location.X + bDownTD.Width + 1, bDownTD.Location.Y)
    End Sub

    Sub fillApp(ByVal sender As Object, ByVal e As ItemCheckEventArgs,
           ByVal vt As String, ByVal clbApp As CheckedListBox, ByVal clbTabela As CheckedListBox, ByVal lbltabela As Label,
           ByVal bDownT As PictureBox, ByVal txtTabela As TextBox, ByVal txtApp As TextBox)

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To clbApp.Items.Count - 1 Step 1
                If i <> e.Index Then
                    clbApp.SetItemChecked(i, False)
                End If
            Next i
            txtApp.Text = clbApp.SelectedValue.Trim
            Dim strSQl As String = "select  distinct tabela as valuemember,tabela+' '+opis as displaymember from vISTTABELEzaDOK('" + vt + "','" + clbApp.SelectedValue.ToString.Trim.ToUpper + "')  order by 1"
            Call fillCLB(clbTabela, strSQl, Me.ISTConnectionString)
            If Not lbltabela Is Nothing Then lbltabela.Visible = True
            txtTabela.Visible = True
            bDownT.Visible = True
        End If
        clbApp.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub clbTabelaA_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbTabelaA.ItemCheck

        clbFilterA.Location = New Point(Me.txtTabelaA.Location.X, txtTabelaA.Location.Y + txtTabelaA.Height + 1)
        Me.txtAppA.Text = sifistA
        Call tabelaIC(sender, e, "A", vtA, txtAppA, clbAppA, txtTabelaA, clbFilterA, bDownTA, ButtonFieldA)
        Call fillA()
        Call fillFAB()
        Call fillAB()
        bAddTableB.Visible = True
    End Sub

    Private Sub clbTabelaB_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbTabelaB.ItemCheck

        clbFilterB.Location = New Point(Me.txtTabelaB.Location.X, txtTabelaB.Location.Y + txtTabelaB.Height + 1)
        Call tabelaIC(sender, e, "B", vtB, txtAppB, clbAppB, txtTabelaB, clbFilterB, bDownTB, ButtonFieldB)
        Call fillFAB()
        Call fillAB()
        bAddTableC.Visible = True
        bRemoveTableB.Visible = True
    End Sub

    Private Sub clbTabelaC_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbTabelaC.ItemCheck
        clbFilterC.Location = New Point(Me.txtTabelaC.Location.X, txtTabelaC.Location.Y + txtTabelaC.Height + 1)
        Call tabelaIC(sender, e, "C", vtC, txtAppC, clbAppC, txtTabelaC, clbFilterC, bDownTC, ButtonFieldC)
        Call fillFAB()
        Call fillAB()
        bAddTableD.Visible = True
        bRemoveTableC.Visible = True
    End Sub

    Private Sub clbTabelaD_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbTabelaD.ItemCheck
        clbFilterD.Location = New Point(Me.txtTabelaD.Location.X, txtTabelaD.Location.Y + txtTabelaD.Height + 1)
        Call tabelaIC(sender, e, "D", vtD, txtAppD, clbAppD, txtTabelaD, clbFilterD, bDownTD, ButtonFieldD)
        Call fillFAB()
        Call fillAB()
        bRemoveTableD.Visible = True
    End Sub

    Sub tabelaIC(sender As Object, e As ItemCheckEventArgs, ByVal slovo As String, ByVal vt As String, ByVal txtApp As TextBox, ByVal clbApp As CheckedListBox,
                 ByVal txtTabela As TextBox, ByVal clbFilter As CheckedListBox, ByVal bDownT As PictureBox,
                 ByVal ButtonField As Button, Optional pom As String = "")
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim clbtabela As CheckedListBox = DirectCast(sender, CheckedListBox)

        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To clbtabela.Items.Count - 1 Step 1
                If i <> e.Index Then
                    clbtabela.SetItemChecked(i, False)
                End If
            Next i

            txtTabela.Text = clbtabela.SelectedValue.ToString.Trim
            If pom = "" Then pom = vt + "','" + txtApp.Text.Trim.ToUpper

            Dim strSQL1 As String = "select distinct polje as valuemember,polje as displaymember,tabela, polje, Replace(Replace(opispom,'$',''),' ','_') as opispom," +
                     "combobox,izraz,cbotabela,cboprikazi As cboprikaziO," +
                     "cboprikazi+ ' ' + replace(opispom,'$','') as cboprikazi,cboubazu,cbofilter,rbr " +
                     "from vISTPoljaKonsultTabela('" + pom + "','" + txtTabela.Text.Trim + "') " +
                     "where tipPolja<>'LBL' order by rbr"
            If slovo = "A" Then
                dvPKARBR = fillPolja(slovo, clbFilter, strSQL1, Me.ISTConnectionString)
            End If
            Dim bs() As String = dajBazuServer(txtApp.Text, Me.ISTConnectionString).Split("$")
            If slovo = "B" Then
                dvPKBRBR = fillPolja(slovo, clbFilter, strSQL1, Me.ISTConnectionString)
                dbNameB = bs(0) : dbServerNameB = bs(1)
            End If
            If slovo = "C" Then
                dvPKCRBR = fillPolja(slovo, clbFilter, strSQL1, Me.ISTConnectionString)
                dbNameC = bs(0) : dbServerNameC = bs(1)
            End If
            If slovo = "D" Then
                dvPKDRBR = fillPolja(slovo, clbFilter, strSQL1, Me.ISTConnectionString)
                dbNameD = bs(0) : dbServerNameD = bs(1)
            End If

            Dim strSQL2 As String = "select distinct polje as valuemember,polje as displaymember,tabela, polje, Replace(Replace(opispom,'$',''),' ','_') as opispom," +
                     "combobox,izraz,cbotabela,cboprikazi As cboprikaziO," +
                     "cboprikazi+ ' ' + replace(opispom,'$','') as cboprikazi,cboubazu,cbofilter " +
                     "from vISTPoljaKonsultTabela('" + pom + "','" + txtTabela.Text.Trim + "') " +
                     "where tipPolja<>'LBL' order by 1"

            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(strSQL2, Me.ISTConnectionString, Me.jezik)
            If slovo = "A" Then dvPKA = dt.AsDataView
            If slovo = "B" Then dvPKB = dt.AsDataView
            If slovo = "C" Then dvPKC = dt.AsDataView
            If slovo = "D" Then dvPKD = dt.AsDataView

            lblF4.Visible = True
            panelCondition.Visible = True

            For i As Integer = 0 To clbFilter.Items.Count - 1 Step 1
                clbFilter.SetItemChecked(i, False)
            Next i

            clbFilter.Visible = True
            clbFilter.Width = clbtabela.Width - bDownT.Width

            ButtonField.Visible = True
            ButtonField.Location = New Point(clbFilter.Location.X + clbFilter.Width + 1, clbFilter.Location.Y)
        End If
        clbtabela.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub txttabelaA_TextChanged(sender As Object, e As EventArgs) Handles txtTabelaA.TextChanged
        Call txtTC(clbTabelaA, txtTabelaA)
    End Sub

    Private Sub txtTabelaB_TextChanged(sender As Object, e As EventArgs) Handles txtTabelaB.TextChanged
        Call txtTC(clbTabelaB, txtTabelaB)
    End Sub

    Private Sub txtTabelaC_TextChanged(sender As Object, e As EventArgs) Handles txtTabelaC.TextChanged
        Call txtTC(clbTabelaC, txtTabelaC)
    End Sub

    Private Sub txtTabelaD_TextChanged(sender As Object, e As EventArgs) Handles txtTabelaD.TextChanged
        Call txtTC(clbTabelaD, txtTabelaD)
    End Sub

    Sub resetPanel(ByVal p As Panel)
        p.SuspendLayout()
        Dim nniz() As String = {}
        Dim i As Integer = -1
        If p.Controls.Count > 0 Then
            For Each Control As Control In p.Controls
                i = i + 1
                ReDim Preserve nniz(i)
                nniz(i) = Control.Name
            Next
            For i = LBound(nniz) To UBound(nniz)
                If p.Controls.Find(nniz(i), True).Length > 0 Then p.Controls.RemoveByKey(nniz(i))
            Next
        End If
        p.ResumeLayout()
    End Sub

    Private Sub dgvA_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgv.ColumnHeaderMouseDoubleClick

        'Dim ime As String = dgvA.Columns(e.ColumnIndex).Name

        'If openForAdd = False AndAlso Me.Controls.Find("LB_LEFT" & ime, True).Length = 0 Then
        '    addForSet("LEFT", ime)
        '    imeL = ime
        'End If
        'If openForAdd = True Then
        '    Dim lbl As Label = NadjiKontroluKOJAJELABELA(panelSet, "LB_RIGHT" & imeL)
        '    If Not lbl Is Nothing AndAlso lbl.Text = "choose .... " Then lbl.Text = dgvA.Columns(e.ColumnIndex).Name
        'End If
        'openForAdd = Not openForAdd

    End Sub

    Dim imeL As String
    Dim openForAdd As Boolean
    Dim lblSetStartTop As Integer
    Dim xxL As Integer
    Dim yyL As Integer
    Dim brCntlpanelSet As Integer

    Private Sub bSQL_Click(sender As Object, e As EventArgs) Handles bSQL.Click
        txtSQLUpdate.Enabled = Not txtSQLUpdate.Enabled

        Dim sset As String = ""
        Dim ffrom As String = ""
        Dim wwhere As String = ""
        txtSQLUpdate.Text = ""
        Dim z1 As String = "" : Dim z2 As String = ""

        For i As Integer = 0 To arrayControlsA.GetUpperBound(0)
            'set
            If arrayControlsA(i).Text.Trim <> "" AndAlso arrayControlsFAB0(i).Text.Trim <> "" Then

                Dim a As String = arrayControlsA(i).Text.Trim
                Dim b As String = arrayControlsFAB0(i).Text.Trim

                If Me.panelTabelaB.Visible = False Then
                    If arrayControlsA(i).Text.Trim.IndexOf(".") = 1 Then a = arrayControlsA(i).Text.Trim.Substring(2)
                    If arrayControlsFAB0(i).Text.Trim.IndexOf(".") = 1 Then b = arrayControlsFAB0(i).Text.Trim.Substring(2)
                End If

                sset = sset + a + "=" + b + ", "

            End If
            'where
            Dim ppomw As String = ""
            If arrayControlsAB1(i).Text.Trim <> "" AndAlso arrayControlsOP2(i).Text.Trim <> "" AndAlso arrayControlsFAB3(i).Text.Trim <> "" Then

                Dim a As String = arrayControlsAB1(i).Text.Trim
                Dim b As String = arrayControlsFAB3(i).Text.Trim
                If Me.panelTabelaB.Visible = False Then
                    If arrayControlsAB1(i).Text.Trim.IndexOf(".") = 1 Then a = arrayControlsAB1(i).Text.Trim.Substring(2)
                    If arrayControlsFAB3(i).Text.Trim.IndexOf(".") = 1 Then b = arrayControlsFAB3(i).Text.Trim.Substring(2)
                End If

                ppomw = "(" + ppomw + a + arrayControlsOP2(i).Text.Trim + b

                If cbOR1.Checked = True AndAlso arrayControlsAB4(i).Text.Trim <> "" AndAlso arrayControlsOP5(i).Text.Trim <> "" AndAlso arrayControlsFAB6(i).Text.Trim <> "" Then
                    z1 = "" : z2 = ""

                    Dim c As String = arrayControlsAB4(i).Text.Trim
                    Dim d As String = arrayControlsFAB6(i).Text.Trim
                    If Me.panelTabelaB.Visible = False Then
                        If arrayControlsAB4(i).Text.Trim.IndexOf(".") = 1 Then c = arrayControlsAB4(i).Text.Trim.Substring(2)
                        If arrayControlsFAB6(i).Text.Trim.IndexOf(".") = 1 Then d = arrayControlsFAB6(i).Text.Trim.Substring(2)
                    End If

                    If Not (IsNumeric(arrayControlsFAB6(i).Text.Trim) = True AndAlso arrayControlsFAB6(i).Text.Trim.Length > 0 AndAlso arrayControlsFAB6(i).Text.Trim.Substring(0, 1) <> "0") Then z1 = "N'" : z2 = "'"
                    ppomw = ppomw + " OR " + c + arrayControlsOP5(i).Text.Trim + z1 + d + z2
                End If

                If cbOR2.Checked = True AndAlso arrayControlsAB7(i).Text.Trim <> "" AndAlso arrayControlsOP8(i).Text.Trim <> "" AndAlso arrayControlsFAB9(i).Text.Trim <> "" Then
                    z1 = "" : z2 = ""

                    Dim ee As String = arrayControlsAB7(i).Text.Trim
                    Dim f As String = arrayControlsFAB9(i).Text.Trim
                    If Me.panelTabelaB.Visible = False Then
                        If arrayControlsAB7(i).Text.Trim.IndexOf(".") = 1 Then ee = arrayControlsAB7(i).Text.Trim.Substring(2)
                        If arrayControlsFAB9(i).Text.Trim.IndexOf(".") = 1 Then f = arrayControlsFAB9(i).Text.Trim.Substring(2)
                    End If

                    If Not (IsNumeric(arrayControlsFAB9(i).Text.Trim) = True AndAlso arrayControlsFAB9(i).Text.Trim.Length > 0 AndAlso arrayControlsFAB9(i).Text.Trim.Substring(0, 1) <> "0") Then z1 = "N'" : z2 = "'"
                    ppomw = ppomw + " OR " + ee + arrayControlsOP8(i).Text.Trim + z1 + f + z2

                End If

                ppomw = ppomw + ")"
                ppomw = ppomw.Replace("''", "'")
                wwhere = wwhere + ppomw + " AND "
            End If
        Next

        sset = "set " + sset + "###" : sset = sset.Replace(", ###", "")
        wwhere = "where " + wwhere + "###" : wwhere = wwhere.Replace("AND ###", "")

        'ista tabela
        If Me.panelTabelaB.Visible = False Then
            txtSQLUpdate.Text = "update  " + clbTabelaA.SelectedValue.Trim + nvrd + sset + nvrd + wwhere
        Else
            If strJoin = "" Then
                Call jjoin()
            Else
                ffrom = strJoin
                txtSQLUpdate.Text = "update A " + nvrd + sset + nvrd + ffrom + nvrd + wwhere
            End If
        End If
        'UPDATE A
        'SET A.Column = B.Column
        'FROM baza1.dbo.Table1 AS A INNER Join baza1.dbo.Table2 AS B On A.CommonField = B.CommonField
        'WHERE A.BatchNo = '110';

        'strJoin
    End Sub

    Private Sub bReset_Click(sender As Object, e As EventArgs) Handles bReset.Click
        Call reset()
    End Sub

    Sub reset()
        lblF4.Visible = False
        Me.panelCondition.Visible = False
        Call EmptyPC()
    End Sub

    Sub EmptyPC()
        For Each cntl As Control In Me.panelCondition.Controls
            If TypeOf cntl Is AutoCompleteTextbox Then DirectCast(cntl, AutoCompleteTextbox).Text = ""
            If TypeOf cntl Is ComboBox Then DirectCast(cntl, ComboBox).DataSource = Nothing
            If TypeOf cntl Is TextBox Then DirectCast(cntl, TextBox).Text = ""
        Next
        txtSQLUpdate.Visible = False
    End Sub

    Private Sub bAddTableC_Click(sender As Object, e As EventArgs) Handles bAddTableC.Click
        Call bAddApp(panelTabelaC, txtAppC, bDownAppC, txtTabelaC, bDownTC, clbTabelaC, clbFilterC, ButtonFieldC)
    End Sub

    Private Sub bAddTableD_Click(sender As Object, e As EventArgs) Handles bAddTableD.Click
        Call bAddApp(panelTabelaD, txtAppD, bDownAppD, txtTabelaD, bDownTD, clbTabelaD, clbFilterD, ButtonFieldD)
    End Sub

    Private Sub bAddTableB_Click(sender As Object, e As EventArgs) Handles bAddTableB.Click
        ucvtB.Visible = True
        Call bAddApp(panelTabelaB, txtAppB, bDownAppB, txtTabelaB, bDownTB, clbTabelaB, clbFilterB, ButtonFieldB)
        Me.lblApp.Visible = True
    End Sub

    Private Sub bAddApp(ByVal panelTabela As Panel, ByVal txtApp As TextBox, ByVal bDownApp As PictureBox,
                        ByVal txtTabela As TextBox, ByVal bDownT As PictureBox, ByVal clbTabela As CheckedListBox,
                        ByVal clbFilter As CheckedListBox, ByVal ButtonField As Button)
        panelTabela.Visible = True
        txtApp.Visible = True
        bDownApp.Visible = True
        txtTabela.Visible = False
        bDownT.Visible = False
        clbTabela.Visible = False
        Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST order by 1"
        Call fillCLB(clbAppB, strSQl, Me.ISTConnectionString)

    End Sub

    Private Sub bRemoveTableB_Click(sender As Object, e As EventArgs) Handles bRemoveTableB.Click
        Me.panelTabelaB.Visible = False
        Call srediPanel(txtAppB, bDownAppB, clbAppB, txtTabelaB, bDownTB, clbTabelaB, clbFilterB, ButtonFieldB)
        Me.lblApp.Visible = False
        Me.lbltabelaB.Visible = False

    End Sub

    Private Sub bRemoveTableC_Click(sender As Object, e As EventArgs) Handles bRemoveTableC.Click
        Me.panelTabelaC.Visible = False
        Call srediPanel(txtAppC, bDownAppC, clbAppC, txtTabelaC, bDownTC, clbTabelaC, clbFilterC, ButtonFieldC)
    End Sub

    Private Sub bRemoveTableD_Click(sender As Object, e As EventArgs) Handles bRemoveTableD.Click
        Me.panelTabelaD.Visible = False
        Call srediPanel(txtAppD, bDownAppD, clbAppD, txtTabelaD, bDownTD, clbTabelaD, clbFilterD, ButtonFieldD)
    End Sub

    Sub srediPanel(ByVal txtApp As TextBox, ByVal bDownApp As PictureBox, ByVal clbApp As CheckedListBox,
                        ByVal txtTabela As TextBox, ByVal bDownT As PictureBox, ByVal clbTabela As CheckedListBox,
                   ByVal clbFilter As CheckedListBox, ByVal ButtonField As Button)
        txtApp.Text = ""
        txtApp.Visible = True
        bDownApp.Visible = True
        clbApp.Visible = False
        For i As Integer = 0 To clbApp.Items.Count - 1 Step 1
            clbApp.SetItemChecked(i, False)
        Next i

        txtTabela.Text = ""
        txtTabela.Visible = False
        bDownT.Visible = False
        clbTabela.Visible = False
        For i As Integer = 0 To clbTabela.Items.Count - 1 Step 1
            clbTabela.SetItemChecked(i, False)
        Next i

        clbFilter.Visible = False
        For i As Integer = 0 To clbFilter.Items.Count - 1 Step 1
            clbFilter.SetItemChecked(i, False)
        Next i

        ButtonField.Visible = False
    End Sub

    '***************
End Class