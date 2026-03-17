Option Strict Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class Form_ISTLK
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

    Friend WithEvents mnuColumnText As ContextMenuStrip
    Friend WithEvents dhide As ToolStripMenuItem
    Friend WithEvents dunhide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents dsort As ToolStripMenuItem
    Friend WithEvents dmcs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents dfind As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As ToolStripSeparator
    Friend WithEvents dunfilterall As ToolStripMenuItem
    Friend WithEvents dfilter As ToolStripMenuItem
    Friend WithEvents dequals As ToolStripMenuItem
    Friend WithEvents mnuColumnNumber As ContextMenuStrip
    Friend WithEvents nhide As ToolStripMenuItem
    Friend WithEvents nunhide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents nsort As ToolStripMenuItem
    Friend WithEvents nmcs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents nfind As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents nequals As ToolStripMenuItem
    Friend WithEvents nfilter As ToolStripMenuItem
    Friend WithEvents nunfilterall As ToolStripMenuItem
    Friend WithEvents ddnequals As ToolStripMenuItem
    Friend WithEvents ndnequals As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents dfreeze As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents nfreeze As ToolStripMenuItem
    Friend WithEvents dunfreezeall As ToolStripMenuItem
    Friend WithEvents nunfreezeall As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents dafc As ToolStripMenuItem
    Friend WithEvents dafw As ToolStripMenuItem
    Friend WithEvents DAFCH As ToolStripMenuItem
    Friend WithEvents nafc As ToolStripMenuItem
    Friend WithEvents nafw As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents cboIST As ComboBox
    Friend WithEvents tv As TreeView
    Friend WithEvents txtL1 As TextBox
    Friend WithEvents txtL3 As TextBox
    Friend WithEvents txtL2 As TextBox
    Friend WithEvents paneT2 As Panel
    Friend WithEvents paneT3 As Panel
    Friend WithEvents paneT1 As Panel
    Friend WithEvents paneT0 As Panel
    Friend WithEvents txtL0 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTabel As Label
    Friend WithEvents cboTable As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents paneT4 As Panel
    Friend WithEvents txtL4 As TextBox
    Friend WithEvents paneT6 As Panel
    Friend WithEvents txtL6 As TextBox
    Friend WithEvents chbOnExitStop As CheckBox
    Friend WithEvents chbOnExitNote As CheckBox
    Friend WithEvents dgvOnExitNote As DataGridView
    Friend WithEvents dgvOnExitStop As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents lblErrorColor As Label
    Friend WithEvents lblErrorType As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PaneT8 As Panel
    Friend WithEvents paneT7 As Panel
    Friend WithEvents Mkc_ColorCombobox5 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox6 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents chbBC As CheckBox
    Friend WithEvents chbFC As CheckBox
    Friend WithEvents lblNoteDefaultText As Label
    Friend WithEvents llNAAA As LinkLabel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents llNAA As LinkLabel
    Friend WithEvents llNA As LinkLabel
    Friend WithEvents chbNS As CheckBox
    Friend WithEvents txtNY As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNX As TextBox
    Friend WithEvents txtL7 As TextBox
    Friend WithEvents lblErrorNumber As Label
    Friend WithEvents cboErrorNumber As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtError As TextBox
    Friend WithEvents lblSqlScript As Label
    Friend WithEvents txtAction As TextBox
    Friend WithEvents nafch As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbNoColor As RadioButton
    Friend WithEvents rbPurple As RadioButton
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents rbYellow As RadioButton
    Friend WithEvents rbOnlyOnBLC As RadioButton
    Friend WithEvents rbDontSave As RadioButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents rbSlovoQ As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNewErrorNumber As TextBox
    Friend WithEvents btnNewError As Button
    Friend WithEvents pnErrorNumber As Panel
    Friend WithEvents lblValidFrom As Label
    Friend WithEvents cboValidFrom As ComboBox
    Friend WithEvents paneT5 As Panel
    Friend WithEvents vdo As DateTimePicker2
    Friend WithEvents vod As DateTimePicker2
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtL5 As TextBox
    Friend WithEvents BtnOK As Button
    Friend WithEvents btnCLOSE As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents btnREfresh As Button
    Friend WithEvents lblErrorWeight As Label
    Friend WithEvents rbL As RadioButton
    Friend WithEvents rbT As RadioButton
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    Dim dISTError As New System.Data.DataTable

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ISTLK))
        Me.mnuColumnText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.dhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.dsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.dmcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.dfind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.dequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddnequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.dfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunfilterall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.dfreeze = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunfreezeall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.dafc = New System.Windows.Forms.ToolStripMenuItem()
        Me.dafw = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAFCH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnNumber = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.nhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.nunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.nsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.nmcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.nfind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.nequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.ndnequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.nfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.nunfilterall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.nfreeze = New System.Windows.Forms.ToolStripMenuItem()
        Me.nunfreezeall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.nafc = New System.Windows.Forms.ToolStripMenuItem()
        Me.nafw = New System.Windows.Forms.ToolStripMenuItem()
        Me.nafch = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboIST = New System.Windows.Forms.ComboBox()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.paneT0 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblValidFrom = New System.Windows.Forms.Label()
        Me.cboValidFrom = New System.Windows.Forms.ComboBox()
        Me.pnErrorNumber = New System.Windows.Forms.Panel()
        Me.txtNewErrorNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNewError = New System.Windows.Forms.Button()
        Me.lblErrorNumber = New System.Windows.Forms.Label()
        Me.cboErrorNumber = New System.Windows.Forms.ComboBox()
        Me.lblTabel = New System.Windows.Forms.Label()
        Me.cboTable = New System.Windows.Forms.ComboBox()
        Me.txtL0 = New System.Windows.Forms.TextBox()
        Me.paneT1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtL1 = New System.Windows.Forms.TextBox()
        Me.paneT2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbOnlyOnBLC = New System.Windows.Forms.RadioButton()
        Me.rbDontSave = New System.Windows.Forms.RadioButton()
        Me.lblErrorType = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblErrorWeight = New System.Windows.Forms.Label()
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.rbT = New System.Windows.Forms.RadioButton()
        Me.rbSlovoQ = New System.Windows.Forms.RadioButton()
        Me.rbNoColor = New System.Windows.Forms.RadioButton()
        Me.rbPurple = New System.Windows.Forms.RadioButton()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.rbYellow = New System.Windows.Forms.RadioButton()
        Me.lblErrorColor = New System.Windows.Forms.Label()
        Me.txtL2 = New System.Windows.Forms.TextBox()
        Me.paneT3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtError = New System.Windows.Forms.TextBox()
        Me.txtL3 = New System.Windows.Forms.TextBox()
        Me.paneT4 = New System.Windows.Forms.Panel()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.lblSqlScript = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.txtL4 = New System.Windows.Forms.TextBox()
        Me.paneT5 = New System.Windows.Forms.Panel()
        Me.vdo = New DateTimePicker2()
        Me.vod = New DateTimePicker2()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtL5 = New System.Windows.Forms.TextBox()
        Me.paneT6 = New System.Windows.Forms.Panel()
        Me.chbOnExitStop = New System.Windows.Forms.CheckBox()
        Me.chbOnExitNote = New System.Windows.Forms.CheckBox()
        Me.txtL6 = New System.Windows.Forms.TextBox()
        Me.dgvOnExitNote = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvOnExitStop = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paneT7 = New System.Windows.Forms.Panel()
        Me.Mkc_ColorCombobox5 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox6 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.chbBC = New System.Windows.Forms.CheckBox()
        Me.chbFC = New System.Windows.Forms.CheckBox()
        Me.lblNoteDefaultText = New System.Windows.Forms.Label()
        Me.llNAAA = New System.Windows.Forms.LinkLabel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.llNAA = New System.Windows.Forms.LinkLabel()
        Me.llNA = New System.Windows.Forms.LinkLabel()
        Me.chbNS = New System.Windows.Forms.CheckBox()
        Me.txtNY = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNX = New System.Windows.Forms.TextBox()
        Me.txtL7 = New System.Windows.Forms.TextBox()
        Me.PaneT8 = New System.Windows.Forms.Panel()
        Me.btnREfresh = New System.Windows.Forms.Button()
        Me.btnCLOSE = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuColumnText.SuspendLayout()
        Me.mnuColumnNumber.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.paneT0.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnErrorNumber.SuspendLayout()
        Me.paneT1.SuspendLayout()
        Me.paneT2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.paneT3.SuspendLayout()
        Me.paneT4.SuspendLayout()
        Me.paneT5.SuspendLayout()
        Me.paneT6.SuspendLayout()
        CType(Me.dgvOnExitNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOnExitStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paneT7.SuspendLayout()
        Me.PaneT8.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuColumnText
        '
        Me.mnuColumnText.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuColumnText.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuColumnText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dhide, Me.dunhide, Me.ToolStripSeparator17, Me.dsort, Me.dmcs, Me.ToolStripSeparator18, Me.dfind, Me.ToolStripSeparator19, Me.dequals, Me.ddnequals, Me.dfilter, Me.dunfilterall, Me.ToolStripSeparator4, Me.dfreeze, Me.dunfreezeall, Me.ToolStripSeparator6, Me.dafc, Me.dafw, Me.DAFCH})
        Me.mnuColumnText.Name = "mnuColumn"
        Me.mnuColumnText.ShowCheckMargin = True
        Me.mnuColumnText.Size = New System.Drawing.Size(240, 342)
        '
        'dhide
        '
        Me.dhide.Name = "dhide"
        Me.dhide.Size = New System.Drawing.Size(239, 22)
        Me.dhide.Text = "Hide column"
        '
        'dunhide
        '
        Me.dunhide.Name = "dunhide"
        Me.dunhide.Size = New System.Drawing.Size(239, 22)
        Me.dunhide.Text = "Unhide all"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(236, 6)
        '
        'dsort
        '
        Me.dsort.Name = "dsort"
        Me.dsort.Size = New System.Drawing.Size(239, 22)
        Me.dsort.Text = "Sort"
        Me.dsort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'dmcs
        '
        Me.dmcs.Name = "dmcs"
        Me.dmcs.Size = New System.Drawing.Size(239, 22)
        Me.dmcs.Text = "Multi column sort"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(236, 6)
        '
        'dfind
        '
        Me.dfind.Name = "dfind"
        Me.dfind.Size = New System.Drawing.Size(239, 22)
        Me.dfind.Text = "Find"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(236, 6)
        '
        'dequals
        '
        Me.dequals.Name = "dequals"
        Me.dequals.Size = New System.Drawing.Size(239, 22)
        Me.dequals.Text = "Equals"
        '
        'ddnequals
        '
        Me.ddnequals.Name = "ddnequals"
        Me.ddnequals.Size = New System.Drawing.Size(239, 22)
        Me.ddnequals.Text = "Does not equal"
        '
        'dfilter
        '
        Me.dfilter.Name = "dfilter"
        Me.dfilter.Size = New System.Drawing.Size(239, 22)
        Me.dfilter.Text = "Text filters"
        '
        'dunfilterall
        '
        Me.dunfilterall.Name = "dunfilterall"
        Me.dunfilterall.Size = New System.Drawing.Size(239, 22)
        Me.dunfilterall.Text = "Unfilter all"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(236, 6)
        '
        'dfreeze
        '
        Me.dfreeze.Name = "dfreeze"
        Me.dfreeze.Size = New System.Drawing.Size(239, 22)
        Me.dfreeze.Text = "Freeze"
        '
        'dunfreezeall
        '
        Me.dunfreezeall.Name = "dunfreezeall"
        Me.dunfreezeall.Size = New System.Drawing.Size(239, 22)
        Me.dunfreezeall.Text = "Unfreeze all"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(236, 6)
        '
        'dafc
        '
        Me.dafc.Name = "dafc"
        Me.dafc.Size = New System.Drawing.Size(239, 22)
        Me.dafc.Text = "AutoFit to context"
        '
        'dafw
        '
        Me.dafw.Name = "dafw"
        Me.dafw.Size = New System.Drawing.Size(239, 22)
        Me.dafw.Text = "AutoFit to window"
        '
        'DAFCH
        '
        Me.DAFCH.Name = "DAFCH"
        Me.DAFCH.Size = New System.Drawing.Size(239, 22)
        Me.DAFCH.Text = "AutoFit to column header"
        '
        'mnuColumnNumber
        '
        Me.mnuColumnNumber.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuColumnNumber.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuColumnNumber.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nhide, Me.nunhide, Me.ToolStripSeparator1, Me.nsort, Me.nmcs, Me.ToolStripSeparator2, Me.nfind, Me.ToolStripSeparator3, Me.nequals, Me.ndnequals, Me.nfilter, Me.nunfilterall, Me.ToolStripSeparator5, Me.nfreeze, Me.nunfreezeall, Me.ToolStripSeparator7, Me.nafc, Me.nafw, Me.nafch})
        Me.mnuColumnNumber.Name = "mnuColumn"
        Me.mnuColumnNumber.ShowCheckMargin = True
        Me.mnuColumnNumber.Size = New System.Drawing.Size(240, 342)
        '
        'nhide
        '
        Me.nhide.Name = "nhide"
        Me.nhide.Size = New System.Drawing.Size(239, 22)
        Me.nhide.Text = "Hide column"
        '
        'nunhide
        '
        Me.nunhide.Name = "nunhide"
        Me.nunhide.Size = New System.Drawing.Size(239, 22)
        Me.nunhide.Text = "Unhide all"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(236, 6)
        '
        'nsort
        '
        Me.nsort.Name = "nsort"
        Me.nsort.Size = New System.Drawing.Size(239, 22)
        Me.nsort.Text = "Sort"
        Me.nsort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'nmcs
        '
        Me.nmcs.Name = "nmcs"
        Me.nmcs.Size = New System.Drawing.Size(239, 22)
        Me.nmcs.Text = "Multi column sort"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(236, 6)
        '
        'nfind
        '
        Me.nfind.Name = "nfind"
        Me.nfind.Size = New System.Drawing.Size(239, 22)
        Me.nfind.Text = "Find"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(236, 6)
        '
        'nequals
        '
        Me.nequals.Name = "nequals"
        Me.nequals.Size = New System.Drawing.Size(239, 22)
        Me.nequals.Text = "Equals"
        '
        'ndnequals
        '
        Me.ndnequals.Name = "ndnequals"
        Me.ndnequals.Size = New System.Drawing.Size(239, 22)
        Me.ndnequals.Text = "Does not equal"
        '
        'nfilter
        '
        Me.nfilter.Name = "nfilter"
        Me.nfilter.Size = New System.Drawing.Size(239, 22)
        Me.nfilter.Text = "Number filters"
        '
        'nunfilterall
        '
        Me.nunfilterall.Name = "nunfilterall"
        Me.nunfilterall.Size = New System.Drawing.Size(239, 22)
        Me.nunfilterall.Text = "Unfilter all"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(236, 6)
        '
        'nfreeze
        '
        Me.nfreeze.Name = "nfreeze"
        Me.nfreeze.Size = New System.Drawing.Size(239, 22)
        Me.nfreeze.Text = "Freeze"
        '
        'nunfreezeall
        '
        Me.nunfreezeall.Name = "nunfreezeall"
        Me.nunfreezeall.Size = New System.Drawing.Size(239, 22)
        Me.nunfreezeall.Text = "Unfreeze all"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(236, 6)
        '
        'nafc
        '
        Me.nafc.Name = "nafc"
        Me.nafc.Size = New System.Drawing.Size(239, 22)
        Me.nafc.Text = "AutoFit to context"
        '
        'nafw
        '
        Me.nafw.Name = "nafw"
        Me.nafw.Size = New System.Drawing.Size(239, 22)
        Me.nafw.Text = "AutoFit to window"
        '
        'nafch
        '
        Me.nafch.Name = "nafch"
        Me.nafch.Size = New System.Drawing.Size(239, 22)
        Me.nafch.Text = "AutoFit to column header"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PaneT8)
        Me.SplitContainer1.Size = New System.Drawing.Size(1238, 709)
        Me.SplitContainer1.SplitterDistance = 250
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SplitContainer4.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer4.Panel1.Controls.Add(Me.cboIST)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.tv)
        Me.SplitContainer4.Size = New System.Drawing.Size(250, 709)
        Me.SplitContainer4.SplitterDistance = 354
        Me.SplitContainer4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IST app"
        '
        'cboIST
        '
        Me.cboIST.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cboIST.DropDownWidth = 750
        Me.cboIST.FormattingEnabled = True
        Me.cboIST.Location = New System.Drawing.Point(0, 333)
        Me.cboIST.Name = "cboIST"
        Me.cboIST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboIST.Size = New System.Drawing.Size(250, 21)
        Me.cboIST.TabIndex = 0
        '
        'tv
        '
        Me.tv.BackColor = System.Drawing.SystemColors.Menu
        Me.tv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv.Location = New System.Drawing.Point(0, 0)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(250, 351)
        Me.tv.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.paneT0, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.paneT1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.paneT2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.paneT3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.paneT4, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.paneT5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.paneT6, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.paneT7, 0, 7)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(808, 633)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'paneT0
        '
        Me.paneT0.Controls.Add(Me.GroupBox1)
        Me.paneT0.Controls.Add(Me.txtL0)
        Me.paneT0.Location = New System.Drawing.Point(3, 3)
        Me.paneT0.Name = "paneT0"
        Me.paneT0.Size = New System.Drawing.Size(801, 50)
        Me.paneT0.TabIndex = 147
        Me.paneT0.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblValidFrom)
        Me.GroupBox1.Controls.Add(Me.cboValidFrom)
        Me.GroupBox1.Controls.Add(Me.pnErrorNumber)
        Me.GroupBox1.Controls.Add(Me.btnNewError)
        Me.GroupBox1.Controls.Add(Me.lblErrorNumber)
        Me.GroupBox1.Controls.Add(Me.cboErrorNumber)
        Me.GroupBox1.Controls.Add(Me.lblTabel)
        Me.GroupBox1.Controls.Add(Me.cboTable)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(3, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 200)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblValidFrom
        '
        Me.lblValidFrom.AutoSize = True
        Me.lblValidFrom.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblValidFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblValidFrom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblValidFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblValidFrom.Location = New System.Drawing.Point(1198, 24)
        Me.lblValidFrom.Name = "lblValidFrom"
        Me.lblValidFrom.Size = New System.Drawing.Size(158, 13)
        Me.lblValidFrom.TabIndex = 157
        Me.lblValidFrom.Text = "Choose date valid from"
        '
        'cboValidFrom
        '
        Me.cboValidFrom.DropDownWidth = 750
        Me.cboValidFrom.FormattingEnabled = True
        Me.cboValidFrom.Location = New System.Drawing.Point(1198, 58)
        Me.cboValidFrom.Name = "cboValidFrom"
        Me.cboValidFrom.Size = New System.Drawing.Size(546, 21)
        Me.cboValidFrom.TabIndex = 156
        '
        'pnErrorNumber
        '
        Me.pnErrorNumber.BackColor = System.Drawing.SystemColors.Menu
        Me.pnErrorNumber.Controls.Add(Me.txtNewErrorNumber)
        Me.pnErrorNumber.Controls.Add(Me.Label4)
        Me.pnErrorNumber.Location = New System.Drawing.Point(357, 99)
        Me.pnErrorNumber.Name = "pnErrorNumber"
        Me.pnErrorNumber.Size = New System.Drawing.Size(162, 62)
        Me.pnErrorNumber.TabIndex = 155
        Me.pnErrorNumber.Visible = False
        '
        'txtNewErrorNumber
        '
        Me.txtNewErrorNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNewErrorNumber.Location = New System.Drawing.Point(7, 31)
        Me.txtNewErrorNumber.Name = "txtNewErrorNumber"
        Me.txtNewErrorNumber.Size = New System.Drawing.Size(141, 21)
        Me.txtNewErrorNumber.TabIndex = 153
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Error number"
        '
        'btnNewError
        '
        Me.btnNewError.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewError.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnNewError.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNewError.Location = New System.Drawing.Point(7, 99)
        Me.btnNewError.Name = "btnNewError"
        Me.btnNewError.Size = New System.Drawing.Size(323, 42)
        Me.btnNewError.TabIndex = 152
        Me.btnNewError.Text = "New error"
        Me.btnNewError.UseVisualStyleBackColor = True
        '
        'lblErrorNumber
        '
        Me.lblErrorNumber.AutoSize = True
        Me.lblErrorNumber.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblErrorNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblErrorNumber.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblErrorNumber.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorNumber.Location = New System.Drawing.Point(357, 18)
        Me.lblErrorNumber.Name = "lblErrorNumber"
        Me.lblErrorNumber.Size = New System.Drawing.Size(146, 13)
        Me.lblErrorNumber.TabIndex = 151
        Me.lblErrorNumber.Text = "Choose error number"
        '
        'cboErrorNumber
        '
        Me.cboErrorNumber.DropDownWidth = 750
        Me.cboErrorNumber.FormattingEnabled = True
        Me.cboErrorNumber.Location = New System.Drawing.Point(357, 58)
        Me.cboErrorNumber.Name = "cboErrorNumber"
        Me.cboErrorNumber.Size = New System.Drawing.Size(321, 21)
        Me.cboErrorNumber.TabIndex = 150
        '
        'lblTabel
        '
        Me.lblTabel.AutoSize = True
        Me.lblTabel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblTabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTabel.Location = New System.Drawing.Point(9, 18)
        Me.lblTabel.Name = "lblTabel"
        Me.lblTabel.Size = New System.Drawing.Size(91, 13)
        Me.lblTabel.TabIndex = 6
        Me.lblTabel.Text = "Choose table"
        '
        'cboTable
        '
        Me.cboTable.DropDownWidth = 750
        Me.cboTable.FormattingEnabled = True
        Me.cboTable.Location = New System.Drawing.Point(9, 58)
        Me.cboTable.Name = "cboTable"
        Me.cboTable.Size = New System.Drawing.Size(321, 21)
        Me.cboTable.TabIndex = 5
        '
        'txtL0
        '
        Me.txtL0.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL0.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL0.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL0.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL0.Location = New System.Drawing.Point(0, 0)
        Me.txtL0.Multiline = True
        Me.txtL0.Name = "txtL0"
        Me.txtL0.ReadOnly = True
        Me.txtL0.Size = New System.Drawing.Size(801, 37)
        Me.txtL0.TabIndex = 0
        Me.txtL0.TabStop = False
        Me.txtL0.Text = "Error"
        '
        'paneT1
        '
        Me.paneT1.AccessibleName = "tableDescription"
        Me.paneT1.Controls.Add(Me.Label3)
        Me.paneT1.Controls.Add(Me.txtTitle)
        Me.paneT1.Controls.Add(Me.txtL1)
        Me.paneT1.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneT1.Location = New System.Drawing.Point(3, 59)
        Me.paneT1.Name = "paneT1"
        Me.paneT1.Size = New System.Drawing.Size(802, 50)
        Me.paneT1.TabIndex = 146
        Me.paneT1.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(3, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Type textual description for this error"
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(3, 57)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(738, 200)
        Me.txtTitle.TabIndex = 144
        '
        'txtL1
        '
        Me.txtL1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL1.Location = New System.Drawing.Point(0, 0)
        Me.txtL1.Multiline = True
        Me.txtL1.Name = "txtL1"
        Me.txtL1.ReadOnly = True
        Me.txtL1.Size = New System.Drawing.Size(802, 37)
        Me.txtL1.TabIndex = 0
        Me.txtL1.TabStop = False
        Me.txtL1.Text = "Description"
        '
        'paneT2
        '
        Me.paneT2.AccessibleName = "parentAtributes"
        Me.paneT2.Controls.Add(Me.GroupBox3)
        Me.paneT2.Controls.Add(Me.GroupBox2)
        Me.paneT2.Controls.Add(Me.txtL2)
        Me.paneT2.Cursor = System.Windows.Forms.Cursors.Default
        Me.paneT2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.paneT2.Location = New System.Drawing.Point(3, 115)
        Me.paneT2.Name = "paneT2"
        Me.paneT2.Size = New System.Drawing.Size(801, 50)
        Me.paneT2.TabIndex = 114
        Me.paneT2.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbOnlyOnBLC)
        Me.GroupBox3.Controls.Add(Me.rbDontSave)
        Me.GroupBox3.Controls.Add(Me.lblErrorType)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(443, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 130)
        Me.GroupBox3.TabIndex = 176
        Me.GroupBox3.TabStop = False
        '
        'rbOnlyOnBLC
        '
        Me.rbOnlyOnBLC.AutoSize = True
        Me.rbOnlyOnBLC.Location = New System.Drawing.Point(43, 73)
        Me.rbOnlyOnBLC.Name = "rbOnlyOnBLC"
        Me.rbOnlyOnBLC.Size = New System.Drawing.Size(140, 17)
        Me.rbOnlyOnBLC.TabIndex = 171
        Me.rbOnlyOnBLC.TabStop = True
        Me.rbOnlyOnBLC.Text = "Batch logical control"
        Me.rbOnlyOnBLC.UseVisualStyleBackColor = True
        '
        'rbDontSave
        '
        Me.rbDontSave.AutoSize = True
        Me.rbDontSave.Location = New System.Drawing.Point(43, 47)
        Me.rbDontSave.Name = "rbDontSave"
        Me.rbDontSave.Size = New System.Drawing.Size(85, 17)
        Me.rbDontSave.TabIndex = 170
        Me.rbDontSave.TabStop = True
        Me.rbDontSave.Text = "Don't save"
        Me.rbDontSave.UseVisualStyleBackColor = True
        '
        'lblErrorType
        '
        Me.lblErrorType.AutoSize = True
        Me.lblErrorType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblErrorType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblErrorType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorType.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorType.Location = New System.Drawing.Point(66, 0)
        Me.lblErrorType.Name = "lblErrorType"
        Me.lblErrorType.Size = New System.Drawing.Size(39, 13)
        Me.lblErrorType.TabIndex = 169
        Me.lblErrorType.Text = "Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblErrorWeight)
        Me.GroupBox2.Controls.Add(Me.rbL)
        Me.GroupBox2.Controls.Add(Me.rbT)
        Me.GroupBox2.Controls.Add(Me.rbSlovoQ)
        Me.GroupBox2.Controls.Add(Me.rbNoColor)
        Me.GroupBox2.Controls.Add(Me.rbPurple)
        Me.GroupBox2.Controls.Add(Me.rbGreen)
        Me.GroupBox2.Controls.Add(Me.rbYellow)
        Me.GroupBox2.Controls.Add(Me.lblErrorColor)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(3, 43)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 130)
        Me.GroupBox2.TabIndex = 175
        Me.GroupBox2.TabStop = False
        '
        'lblErrorWeight
        '
        Me.lblErrorWeight.AutoSize = True
        Me.lblErrorWeight.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblErrorWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblErrorWeight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorWeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorWeight.Location = New System.Drawing.Point(319, 22)
        Me.lblErrorWeight.Name = "lblErrorWeight"
        Me.lblErrorWeight.Size = New System.Drawing.Size(52, 13)
        Me.lblErrorWeight.TabIndex = 181
        Me.lblErrorWeight.Text = "Weight"
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbL.Location = New System.Drawing.Point(328, 73)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(37, 18)
        Me.rbL.TabIndex = 180
        Me.rbL.TabStop = True
        Me.rbL.Text = "L"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'rbT
        '
        Me.rbT.AutoSize = True
        Me.rbT.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbT.Location = New System.Drawing.Point(328, 47)
        Me.rbT.Name = "rbT"
        Me.rbT.Size = New System.Drawing.Size(38, 18)
        Me.rbT.TabIndex = 179
        Me.rbT.TabStop = True
        Me.rbT.Text = "T"
        Me.rbT.UseVisualStyleBackColor = True
        '
        'rbSlovoQ
        '
        Me.rbSlovoQ.AutoSize = True
        Me.rbSlovoQ.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbSlovoQ.Location = New System.Drawing.Point(195, 73)
        Me.rbSlovoQ.Name = "rbSlovoQ"
        Me.rbSlovoQ.Size = New System.Drawing.Size(74, 18)
        Me.rbSlovoQ.TabIndex = 178
        Me.rbSlovoQ.TabStop = True
        Me.rbSlovoQ.Text = "slovo Q"
        Me.rbSlovoQ.UseVisualStyleBackColor = True
        '
        'rbNoColor
        '
        Me.rbNoColor.AutoSize = True
        Me.rbNoColor.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbNoColor.Location = New System.Drawing.Point(195, 47)
        Me.rbNoColor.Name = "rbNoColor"
        Me.rbNoColor.Size = New System.Drawing.Size(73, 18)
        Me.rbNoColor.TabIndex = 177
        Me.rbNoColor.TabStop = True
        Me.rbNoColor.Text = "slovo N"
        Me.rbNoColor.UseVisualStyleBackColor = True
        '
        'rbPurple
        '
        Me.rbPurple.AutoSize = True
        Me.rbPurple.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbPurple.Location = New System.Drawing.Point(61, 73)
        Me.rbPurple.Name = "rbPurple"
        Me.rbPurple.Size = New System.Drawing.Size(67, 18)
        Me.rbPurple.TabIndex = 176
        Me.rbPurple.TabStop = True
        Me.rbPurple.Text = "Purple"
        Me.rbPurple.UseVisualStyleBackColor = True
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbGreen.Location = New System.Drawing.Point(61, 47)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(66, 18)
        Me.rbGreen.TabIndex = 175
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'rbYellow
        '
        Me.rbYellow.AutoSize = True
        Me.rbYellow.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbYellow.Location = New System.Drawing.Point(61, 22)
        Me.rbYellow.Name = "rbYellow"
        Me.rbYellow.Size = New System.Drawing.Size(67, 18)
        Me.rbYellow.TabIndex = 174
        Me.rbYellow.TabStop = True
        Me.rbYellow.Text = "Yellow"
        Me.rbYellow.UseVisualStyleBackColor = True
        '
        'lblErrorColor
        '
        Me.lblErrorColor.AutoSize = True
        Me.lblErrorColor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblErrorColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblErrorColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorColor.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblErrorColor.Location = New System.Drawing.Point(17, 0)
        Me.lblErrorColor.Name = "lblErrorColor"
        Me.lblErrorColor.Size = New System.Drawing.Size(41, 13)
        Me.lblErrorColor.TabIndex = 151
        Me.lblErrorColor.Text = "Color"
        '
        'txtL2
        '
        Me.txtL2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL2.Location = New System.Drawing.Point(0, 0)
        Me.txtL2.Multiline = True
        Me.txtL2.Name = "txtL2"
        Me.txtL2.ReadOnly = True
        Me.txtL2.Size = New System.Drawing.Size(801, 37)
        Me.txtL2.TabIndex = 1
        Me.txtL2.TabStop = False
        Me.txtL2.Text = "Properties"
        '
        'paneT3
        '
        Me.paneT3.AccessibleName = "childAttributes"
        Me.paneT3.Controls.Add(Me.Label2)
        Me.paneT3.Controls.Add(Me.txtError)
        Me.paneT3.Controls.Add(Me.txtL3)
        Me.paneT3.Location = New System.Drawing.Point(3, 171)
        Me.paneT3.Name = "paneT3"
        Me.paneT3.Size = New System.Drawing.Size(802, 50)
        Me.paneT3.TabIndex = 115
        Me.paneT3.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Type logical conditions for this error"
        '
        'txtError
        '
        Me.txtError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtError.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtError.Location = New System.Drawing.Point(3, 63)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(738, 200)
        Me.txtError.TabIndex = 146
        '
        'txtL3
        '
        Me.txtL3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL3.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL3.Location = New System.Drawing.Point(0, 0)
        Me.txtL3.Multiline = True
        Me.txtL3.Name = "txtL3"
        Me.txtL3.ReadOnly = True
        Me.txtL3.Size = New System.Drawing.Size(802, 37)
        Me.txtL3.TabIndex = 2
        Me.txtL3.TabStop = False
        Me.txtL3.Text = "Statment"
        '
        'paneT4
        '
        Me.paneT4.Controls.Add(Me.btnFind)
        Me.paneT4.Controls.Add(Me.lblSqlScript)
        Me.paneT4.Controls.Add(Me.txtAction)
        Me.paneT4.Controls.Add(Me.txtL4)
        Me.paneT4.Location = New System.Drawing.Point(3, 227)
        Me.paneT4.Name = "paneT4"
        Me.paneT4.Size = New System.Drawing.Size(801, 50)
        Me.paneT4.TabIndex = 150
        Me.paneT4.Tag = ""
        '
        'btnFind
        '
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Location = New System.Drawing.Point(523, 126)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(218, 42)
        Me.btnFind.TabIndex = 149
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'lblSqlScript
        '
        Me.lblSqlScript.AutoSize = True
        Me.lblSqlScript.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSqlScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSqlScript.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSqlScript.Location = New System.Drawing.Point(3, 50)
        Me.lblSqlScript.Name = "lblSqlScript"
        Me.lblSqlScript.Size = New System.Drawing.Size(105, 13)
        Me.lblSqlScript.TabIndex = 147
        Me.lblSqlScript.Text = "Choose sql script"
        '
        'txtAction
        '
        Me.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAction.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAction.Location = New System.Drawing.Point(3, 80)
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(738, 21)
        Me.txtAction.TabIndex = 146
        '
        'txtL4
        '
        Me.txtL4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL4.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL4.Location = New System.Drawing.Point(0, 0)
        Me.txtL4.Multiline = True
        Me.txtL4.Name = "txtL4"
        Me.txtL4.ReadOnly = True
        Me.txtL4.Size = New System.Drawing.Size(801, 37)
        Me.txtL4.TabIndex = 2
        Me.txtL4.TabStop = False
        Me.txtL4.Text = "Action"
        '
        'paneT5
        '
        Me.paneT5.Controls.Add(Me.vdo)
        Me.paneT5.Controls.Add(Me.vod)
        Me.paneT5.Controls.Add(Me.TextBox2)
        Me.paneT5.Controls.Add(Me.TextBox1)
        Me.paneT5.Controls.Add(Me.txtL5)
        Me.paneT5.Location = New System.Drawing.Point(3, 283)
        Me.paneT5.Name = "paneT5"
        Me.paneT5.Size = New System.Drawing.Size(801, 50)
        Me.paneT5.TabIndex = 151
        Me.paneT5.Tag = ""
        '
        'vdo
        '
        Me.vdo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.vdo.Location = New System.Drawing.Point(211, 80)
        Me.vdo.Name = "vdo"
        Me.vdo.Size = New System.Drawing.Size(206, 21)
        Me.vdo.TabIndex = 166
        '
        'vod
        '
        Me.vod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.vod.Location = New System.Drawing.Point(3, 80)
        Me.vod.Name = "vod"
        Me.vod.Size = New System.Drawing.Size(206, 21)
        Me.vod.TabIndex = 165
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox2.Location = New System.Drawing.Point(211, 40)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(206, 37)
        Me.TextBox2.TabIndex = 164
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "Validity to"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox1.Location = New System.Drawing.Point(3, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(206, 37)
        Me.TextBox1.TabIndex = 161
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "Validity from"
        '
        'txtL5
        '
        Me.txtL5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL5.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL5.Location = New System.Drawing.Point(0, 0)
        Me.txtL5.Multiline = True
        Me.txtL5.Name = "txtL5"
        Me.txtL5.ReadOnly = True
        Me.txtL5.Size = New System.Drawing.Size(801, 37)
        Me.txtL5.TabIndex = 2
        Me.txtL5.TabStop = False
        Me.txtL5.Text = "Validity period"
        '
        'paneT6
        '
        Me.paneT6.Controls.Add(Me.chbOnExitStop)
        Me.paneT6.Controls.Add(Me.chbOnExitNote)
        Me.paneT6.Controls.Add(Me.txtL6)
        Me.paneT6.Controls.Add(Me.dgvOnExitNote)
        Me.paneT6.Controls.Add(Me.dgvOnExitStop)
        Me.paneT6.Location = New System.Drawing.Point(3, 339)
        Me.paneT6.Name = "paneT6"
        Me.paneT6.Size = New System.Drawing.Size(801, 50)
        Me.paneT6.TabIndex = 152
        Me.paneT6.Tag = ""
        Me.paneT6.Visible = False
        '
        'chbOnExitStop
        '
        Me.chbOnExitStop.AutoSize = True
        Me.chbOnExitStop.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbOnExitStop.Location = New System.Drawing.Point(3, 43)
        Me.chbOnExitStop.Name = "chbOnExitStop"
        Me.chbOnExitStop.Size = New System.Drawing.Size(52, 17)
        Me.chbOnExitStop.TabIndex = 152
        Me.chbOnExitStop.Text = "Stop"
        '
        'chbOnExitNote
        '
        Me.chbOnExitNote.AutoSize = True
        Me.chbOnExitNote.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbOnExitNote.Location = New System.Drawing.Point(3, 75)
        Me.chbOnExitNote.Name = "chbOnExitNote"
        Me.chbOnExitNote.Size = New System.Drawing.Size(52, 17)
        Me.chbOnExitNote.TabIndex = 151
        Me.chbOnExitNote.Text = "Note"
        '
        'txtL6
        '
        Me.txtL6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL6.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL6.Location = New System.Drawing.Point(0, 0)
        Me.txtL6.Multiline = True
        Me.txtL6.Name = "txtL6"
        Me.txtL6.ReadOnly = True
        Me.txtL6.Size = New System.Drawing.Size(801, 37)
        Me.txtL6.TabIndex = 2
        Me.txtL6.TabStop = False
        Me.txtL6.Text = "On Exit button"
        '
        'dgvOnExitNote
        '
        Me.dgvOnExitNote.AllowDrop = True
        Me.dgvOnExitNote.AllowUserToOrderColumns = True
        Me.dgvOnExitNote.AllowUserToResizeRows = False
        Me.dgvOnExitNote.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnExitNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnExitNote.ColumnHeadersHeight = 30
        Me.dgvOnExitNote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOnExitNote.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvOnExitNote.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnExitNote.Location = New System.Drawing.Point(73, 32)
        Me.dgvOnExitNote.MultiSelect = False
        Me.dgvOnExitNote.Name = "dgvOnExitNote"
        Me.dgvOnExitNote.RowHeadersWidth = 33
        Me.dgvOnExitNote.RowTemplate.Height = 30
        Me.dgvOnExitNote.Size = New System.Drawing.Size(629, 193)
        Me.dgvOnExitNote.TabIndex = 164
        Me.dgvOnExitNote.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "On Exit button note if"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 300
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 300
        '
        'dgvOnExitStop
        '
        Me.dgvOnExitStop.AllowDrop = True
        Me.dgvOnExitStop.AllowUserToOrderColumns = True
        Me.dgvOnExitStop.AllowUserToResizeRows = False
        Me.dgvOnExitStop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnExitStop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnExitStop.ColumnHeadersHeight = 30
        Me.dgvOnExitStop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOnExitStop.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvOnExitStop.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnExitStop.Location = New System.Drawing.Point(534, 32)
        Me.dgvOnExitStop.MultiSelect = False
        Me.dgvOnExitStop.Name = "dgvOnExitStop"
        Me.dgvOnExitStop.RowHeadersWidth = 33
        Me.dgvOnExitStop.RowTemplate.Height = 30
        Me.dgvOnExitStop.Size = New System.Drawing.Size(629, 193)
        Me.dgvOnExitStop.TabIndex = 163
        Me.dgvOnExitStop.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "On Exit button stop if"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 300
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 300
        '
        'paneT7
        '
        Me.paneT7.Controls.Add(Me.Mkc_ColorCombobox5)
        Me.paneT7.Controls.Add(Me.Mkc_ColorCombobox6)
        Me.paneT7.Controls.Add(Me.chbBC)
        Me.paneT7.Controls.Add(Me.chbFC)
        Me.paneT7.Controls.Add(Me.lblNoteDefaultText)
        Me.paneT7.Controls.Add(Me.llNAAA)
        Me.paneT7.Controls.Add(Me.TextBox4)
        Me.paneT7.Controls.Add(Me.llNAA)
        Me.paneT7.Controls.Add(Me.llNA)
        Me.paneT7.Controls.Add(Me.chbNS)
        Me.paneT7.Controls.Add(Me.txtNY)
        Me.paneT7.Controls.Add(Me.Label12)
        Me.paneT7.Controls.Add(Me.Label13)
        Me.paneT7.Controls.Add(Me.Label15)
        Me.paneT7.Controls.Add(Me.txtNX)
        Me.paneT7.Controls.Add(Me.txtL7)
        Me.paneT7.Location = New System.Drawing.Point(3, 395)
        Me.paneT7.Name = "paneT7"
        Me.paneT7.Size = New System.Drawing.Size(801, 50)
        Me.paneT7.TabIndex = 153
        Me.paneT7.Tag = ""
        Me.paneT7.Visible = False
        '
        'Mkc_ColorCombobox5
        '
        Me.Mkc_ColorCombobox5.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox5.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox5.Location = New System.Drawing.Point(117, 78)
        Me.Mkc_ColorCombobox5.Name = "Mkc_ColorCombobox5"
        Me.Mkc_ColorCombobox5.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox5.Size = New System.Drawing.Size(435, 23)
        Me.Mkc_ColorCombobox5.TabIndex = 160
        Me.Mkc_ColorCombobox5.Visible = False
        '
        'Mkc_ColorCombobox6
        '
        Me.Mkc_ColorCombobox6.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox6.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox6.Location = New System.Drawing.Point(117, 106)
        Me.Mkc_ColorCombobox6.Name = "Mkc_ColorCombobox6"
        Me.Mkc_ColorCombobox6.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox6.Size = New System.Drawing.Size(435, 23)
        Me.Mkc_ColorCombobox6.TabIndex = 159
        Me.Mkc_ColorCombobox6.Visible = False
        '
        'chbBC
        '
        Me.chbBC.AutoSize = True
        Me.chbBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBC.Location = New System.Drawing.Point(3, 106)
        Me.chbBC.Name = "chbBC"
        Me.chbBC.Size = New System.Drawing.Size(86, 17)
        Me.chbBC.TabIndex = 158
        Me.chbBC.Text = "Back color"
        '
        'chbFC
        '
        Me.chbFC.AutoSize = True
        Me.chbFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFC.Location = New System.Drawing.Point(3, 78)
        Me.chbFC.Name = "chbFC"
        Me.chbFC.Size = New System.Drawing.Size(83, 17)
        Me.chbFC.TabIndex = 157
        Me.chbFC.Text = "Fore color"
        '
        'lblNoteDefaultText
        '
        Me.lblNoteDefaultText.AutoSize = True
        Me.lblNoteDefaultText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteDefaultText.Location = New System.Drawing.Point(3, 133)
        Me.lblNoteDefaultText.Name = "lblNoteDefaultText"
        Me.lblNoteDefaultText.Size = New System.Drawing.Size(74, 13)
        Me.lblNoteDefaultText.TabIndex = 152
        Me.lblNoteDefaultText.Text = "Default text"
        '
        'llNAAA
        '
        Me.llNAAA.ActiveLinkColor = System.Drawing.Color.Black
        Me.llNAAA.AutoSize = True
        Me.llNAAA.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNAAA.LinkColor = System.Drawing.Color.Black
        Me.llNAAA.Location = New System.Drawing.Point(704, 80)
        Me.llNAAA.Name = "llNAAA"
        Me.llNAAA.Size = New System.Drawing.Size(21, 23)
        Me.llNAAA.TabIndex = 155
        Me.llNAAA.TabStop = True
        Me.llNAAA.Text = "a"
        Me.llNAAA.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(3, 155)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(738, 125)
        Me.TextBox4.TabIndex = 145
        '
        'llNAA
        '
        Me.llNAA.ActiveLinkColor = System.Drawing.Color.Black
        Me.llNAA.AutoSize = True
        Me.llNAA.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNAA.LinkColor = System.Drawing.Color.Black
        Me.llNAA.Location = New System.Drawing.Point(656, 98)
        Me.llNAA.Name = "llNAA"
        Me.llNAA.Size = New System.Drawing.Size(18, 18)
        Me.llNAA.TabIndex = 154
        Me.llNAA.TabStop = True
        Me.llNAA.Text = "a"
        Me.llNAA.Visible = False
        '
        'llNA
        '
        Me.llNA.ActiveLinkColor = System.Drawing.Color.Black
        Me.llNA.AutoSize = True
        Me.llNA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNA.LinkColor = System.Drawing.Color.Black
        Me.llNA.Location = New System.Drawing.Point(613, 116)
        Me.llNA.Name = "llNA"
        Me.llNA.Size = New System.Drawing.Size(14, 13)
        Me.llNA.TabIndex = 153
        Me.llNA.TabStop = True
        Me.llNA.Text = "a"
        Me.llNA.Visible = False
        '
        'chbNS
        '
        Me.chbNS.AutoSize = True
        Me.chbNS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNS.Location = New System.Drawing.Point(609, 50)
        Me.chbNS.Name = "chbNS"
        Me.chbNS.Size = New System.Drawing.Size(50, 17)
        Me.chbNS.TabIndex = 156
        Me.chbNS.Text = "Size"
        '
        'txtNY
        '
        Me.txtNY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNY.Location = New System.Drawing.Point(269, 50)
        Me.txtNY.Name = "txtNY"
        Me.txtNY.Size = New System.Drawing.Size(91, 21)
        Me.txtNY.TabIndex = 148
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 50)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "Location"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(246, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 13)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Y"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(117, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 13)
        Me.Label15.TabIndex = 149
        Me.Label15.Text = "X"
        '
        'txtNX
        '
        Me.txtNX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNX.Location = New System.Drawing.Point(137, 50)
        Me.txtNX.Name = "txtNX"
        Me.txtNX.Size = New System.Drawing.Size(91, 21)
        Me.txtNX.TabIndex = 147
        '
        'txtL7
        '
        Me.txtL7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL7.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL7.Location = New System.Drawing.Point(0, 0)
        Me.txtL7.Multiline = True
        Me.txtL7.Name = "txtL7"
        Me.txtL7.ReadOnly = True
        Me.txtL7.Size = New System.Drawing.Size(801, 37)
        Me.txtL7.TabIndex = 2
        Me.txtL7.TabStop = False
        Me.txtL7.Text = "Note"
        '
        'PaneT8
        '
        Me.PaneT8.Controls.Add(Me.btnREfresh)
        Me.PaneT8.Controls.Add(Me.btnCLOSE)
        Me.PaneT8.Controls.Add(Me.BtnOK)
        Me.PaneT8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PaneT8.Location = New System.Drawing.Point(0, 655)
        Me.PaneT8.Name = "PaneT8"
        Me.PaneT8.Size = New System.Drawing.Size(984, 54)
        Me.PaneT8.TabIndex = 172
        '
        'btnREfresh
        '
        Me.btnREfresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREfresh.Location = New System.Drawing.Point(277, 12)
        Me.btnREfresh.Name = "btnREfresh"
        Me.btnREfresh.Size = New System.Drawing.Size(114, 32)
        Me.btnREfresh.TabIndex = 12
        Me.btnREfresh.Text = "Refresh"
        Me.btnREfresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnREfresh.UseVisualStyleBackColor = True
        '
        'btnCLOSE
        '
        Me.btnCLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLOSE.Location = New System.Drawing.Point(146, 12)
        Me.btnCLOSE.Name = "btnCLOSE"
        Me.btnCLOSE.Size = New System.Drawing.Size(114, 32)
        Me.btnCLOSE.TabIndex = 11
        Me.btnCLOSE.Text = "Close"
        Me.btnCLOSE.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOK.Location = New System.Drawing.Point(16, 12)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(114, 32)
        Me.BtnOK.TabIndex = 10
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckPathExists = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1238, 40)
        Me.PanelTop.TabIndex = 145
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.Transparent
        Me.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b3.FlatAppearance.BorderSize = 0
        Me.b3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.Color.DarkOrange
        Me.b3.Location = New System.Drawing.Point(10, 4)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(799, 32)
        Me.b3.TabIndex = 184
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1198, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Logovan
        '
        Me.Logovan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(946, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_ISTLK
        '
        Me.ClientSize = New System.Drawing.Size(1238, 749)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "Form_ISTLK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuColumnText.ResumeLayout(False)
        Me.mnuColumnNumber.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout()
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.paneT0.ResumeLayout(False)
        Me.paneT0.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnErrorNumber.ResumeLayout(False)
        Me.pnErrorNumber.PerformLayout()
        Me.paneT1.ResumeLayout(False)
        Me.paneT1.PerformLayout()
        Me.paneT2.ResumeLayout(False)
        Me.paneT2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.paneT3.ResumeLayout(False)
        Me.paneT3.PerformLayout()
        Me.paneT4.ResumeLayout(False)
        Me.paneT4.PerformLayout()
        Me.paneT5.ResumeLayout(False)
        Me.paneT5.PerformLayout()
        Me.paneT6.ResumeLayout(False)
        Me.paneT6.PerformLayout()
        CType(Me.dgvOnExitNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOnExitStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paneT7.ResumeLayout(False)
        Me.paneT7.PerformLayout()
        Me.PaneT8.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
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

    Dim dtIST As New System.Data.DataTable
    Dim dtISTBaze As New System.Data.DataTable
    Dim jezik As String
    Dim txtmode As String
    Dim ISTConnectionString As String = ""
    Dim DBConnectionString As String = ""
    Dim appCode As String = ""

    Public Sub New(ByVal DBConnectionString As String, ByVal ISTConnectionString As String, ByVal appcode As String, ByVal txtmode As String, ByVal jezik As String)
        Me.New()
        Me.DBConnectionString = DBConnectionString
        Me.ISTConnectionString = ISTConnectionString
        Me.appCode = appcode
        Me.txtmode = txtmode
        Me.jezik = jezik
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Logovan.Text = GetUserName.ToString.Trim
        Call SetLang()
    End Sub
    Private Sub SetLang()
        ''
        'Dim dt As System.Data.DataTable = getDTVBText(dtLang, "GUI")
        'b3.Text = getControlText2(dt, "naslov9", Me.jezik)
        b3.Text = "Edit ISTRulesLogicalControl"
    End Sub
    Private Sub cboTable_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTable.Enter
        Dim strSQl As String = ""
        If Me.cboIST.SelectedValue <> "" Then
            strSQl = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode='" + cboIST.SelectedValue.ToString + "' and isnull(typeOfTableParentChild,'') not in ('S','A','K') order by 1"
            Call popunicbo(cboTable, strSQl, Me.ISTConnectionString)
        End If
        cboErrorNumber.Text = String.Empty
    End Sub
    Private Sub cboErrorNumber_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboErrorNumber.Enter
        If Me.cboIST.SelectedValue <> "" And Me.cboTable.SelectedValue <> "" Then
            Dim strSQl As String = "select distinct errNumber as displaymember,errNumber as valuemember from _ISTRulesDataValidation where appcode='" + cboIST.SelectedValue.ToString + "' and tableName='" + cboTable.SelectedValue.ToString + "' order by 1"
            Call popunicbo(cboErrorNumber, strSQl, Me.ISTConnectionString)
        Else
            Me.cboErrorNumber.DataSource = Nothing
            Me.cboErrorNumber.Items.Clear()
        End If
    End Sub
    Private Sub cboIST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIST.SelectedIndexChanged
        If Me.cboIST.SelectedValue <> "" Then
            Call DajTabelePoljaIST(tv, Me.cboIST.SelectedValue)
        End If
        pnErrorNumber.Visible = False
        Call isprazni()
    End Sub
    Private Sub cboErrorNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboErrorNumber.SelectedIndexChanged

        Dim ErrorNumber As String = ""
        If cboErrorNumber.Text <> "" Then ErrorNumber = cboErrorNumber.Text
        Dim expresion As String = "errNumber = '" + ErrorNumber + "' and  TableName='" + cboTable.Text + "'"
        Dim dt As DataTable

        If (ErrorNumber <> "") Then
            dt = dISTError.Copy
            dt.DefaultView.RowFilter = expresion
            dt = dt.DefaultView.ToTable

            cboValidFrom.SelectedIndex = cboValidFrom.FindString(String.Empty)
            'dr = New DataView(dt).ToTable().Rows(0)

            cboValidFrom.Items.Clear()
            cboValidFrom.Items.Add(String.Empty)

            For Each drc As DataRow In dt.Rows
                cboValidFrom.Items.Add(drc("ValidFrom").ToString().Substring(0, 10))
            Next

            cboValidFrom.SelectedIndex = 1
        End If

    End Sub
    Private Sub cboValidFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboValidFrom.SelectedIndexChanged

        Dim dt As DataTable
        Dim dr As DataRow
        Dim expresion As String = ""

        If cboErrorNumber.Text <> "" And cboValidFrom.Text <> "" Then
            expresion = "errNumber = '" + cboErrorNumber.Text + "' and  TableName='" + cboTable.Text + "' and validFrom = '" + cboValidFrom.Text + "'"
        End If

        If (expresion <> "") Then
            dt = dISTError.Copy
            dt.DefaultView.RowFilter = expresion
            dt = dt.DefaultView.ToTable

            dr = New DataView(dt).ToTable().Rows(0)

            Me.txtTitle.Text = dr("errTitle").ToString()
            Me.txtError.Text = dr("Error").ToString()
            Me.txtAction.Text = dr("errAction").ToString()

            Me.vod.Text = dr("ValidFrom").ToString()
            Me.vod.Text = dr("ValidTo").ToString()
            Me.txtAction.Text = dr("errAction").ToString()
            Select Case dr("errWeight").ToString().ToUpper()
                Case "T"
                    Me.rbT.Checked = True
                Case "L"
                    Me.rbL.Checked = True
                Case "Y"
                    Me.rbYellow.Checked = True
                Case "G"
                    Me.rbGreen.Checked = True
                Case "P"
                    Me.rbPurple.Checked = True
                Case "N"
                    Me.rbNoColor.Checked = True
                Case "Q"
                    Me.rbSlovoQ.Checked = True
            End Select

            pnErrorNumber.Visible = False

            Select Case dr("condition").ToString().ToUpper()
                Case "LKVELIKA", "EXECUTEONLYFROMDATAVALIDATIONMODULE"
                    Me.rbOnlyOnBLC.Checked = True
                Case "DONTSAVE"
                    Me.rbDontSave.Checked = True
            End Select
            vod.Text = dr("ValidFrom").ToString()
            vdo.Text = dr("ValidTo").ToString()
        End If

        pnErrorNumber.Visible = False

    End Sub
    Sub DajTabelePoljaIST(ByVal tv As TreeView, ByVal sifist As String)

        Dim izrazODBC As String = ""
        tv.Nodes.Clear()

        Dim sqlColumns As String = "select * from _ISTTablesColumns where appCode='" + sifist.Trim + "' order by tableName,orderNumber"
        Dim sqlErrors As String = "select * from _ISTRulesDataValidation where appCode='" + sifist.Trim + "' order by tableName,errNumber"
        Dim dISTPolja As New System.Data.DataTable

        dISTPolja.Clear()
        dISTError.Clear()
        Dim adp As New System.Data.SqlClient.SqlDataAdapter(sqlColumns, Me.ISTConnectionString)
        Dim adp1 As New System.Data.SqlClient.SqlDataAdapter(sqlErrors, Me.ISTConnectionString)

        Try
            adp.Fill(dISTPolja)
            adp1.Fill(dISTError)
        Finally
            adp.Dispose()
        End Try

        If dISTPolja.Rows.Count > 0 Then
            Dim node As TreeNode
            Dim tab As String = dISTPolja.Rows(0).Item("tableName").ToString.Trim.ToUpper
            Dim slTab As String = ""
            node = tv.Nodes.Add(tab)
            node.Tag = "TN"
            Dim polje As String = dISTPolja.Rows(0).Item("columnName").ToString.Trim
            node.Nodes.Add(polje)
            node.Nodes(node.Nodes.Count - 1).Tag = "CN"
            For i As Integer = 1 To dISTPolja.Rows.Count - 1
                slTab = dISTPolja.Rows(i).Item("tableName").ToString.Trim.ToUpper
                If tab <> slTab Then
                    tab = slTab
                    node = tv.Nodes.Add(slTab)
                    node.Tag = node.Text
                End If
                polje = dISTPolja.Rows(i).Item("columnName").ToString.Trim
                node.Nodes.Add(polje)
                node.Nodes(node.Nodes.Count - 1).Tag = "CN"
            Next
            tv.Visible = True

        End If

    End Sub
    Private Sub cboTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTable.SelectedIndexChanged
        Call isprazni()
    End Sub
    Sub isprazni()
        pnErrorNumber.Visible = False

        Me.txtTitle.Text = String.Empty
        Me.txtError.Text = String.Empty
        Me.txtAction.Text = String.Empty
        Me.rbT.Checked = False
        Me.rbL.Checked = True
        Me.rbYellow.Checked = True
        Me.rbGreen.Checked = True
        Me.rbPurple.Checked = True
        Me.rbNoColor.Checked = True
        Me.rbSlovoQ.Checked = True
        Me.rbOnlyOnBLC.Checked = False
        Me.rbDontSave.Checked = False

        cboErrorNumber.SelectedIndex = cboErrorNumber.FindString(String.Empty)
        cboValidFrom.SelectedIndex = cboValidFrom.FindString(String.Empty)
        cboValidFrom.Items.Clear()
        pnErrorNumber.Visible = False
    End Sub
    Dim ttable As Boolean = False
    Dim ccolumn As Boolean = False
    Private Sub tvISTTabele_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tv.NodeMouseDoubleClick
        ttable = False
        ccolumn = False
        If (e.Node Is Me.tv.SelectedNode AndAlso e.Node.Parent Is Nothing) Then
            Me.txtL0.Text = "Table : " + e.Node.Text '+ "    in _ISTTables.typeOfTableParentChild of IST metadata"
            cboTable.SelectedIndex = cboTable.FindString(e.Node.Text)
            ttable = False
            ccolumn = True
        End If
        If (e.Node Is Me.tv.SelectedNode AndAlso Not e.Node.Parent Is Nothing) Then

            Dim insertPos As Integer = Me.txtError.SelectionStart
            Me.txtError.Text = Me.txtError.Text.Insert(insertPos, e.Node.Text)
            Me.txtError.SelectionStart = insertPos + e.Node.Text.Length
        End If
    End Sub
    Private Sub tv_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles tv.ItemDrag
        Dim tv As TreeView = CType(sender, System.Windows.Forms.TreeView)
        Dim nd As TreeNode = DirectCast(e.Item, TreeNode)
        If nd.Nodes.Count = 0 Then
            tv.SelectedNode = nd
            Dim EffectCursor As New Cursor(New System.IO.MemoryStream(My.Resources.Move))
            tv.DoDragDrop(nd.Text, DragDropEffects.Copy)
            tv.SelectedNode.Checked = True
            Dim ttaagg As String = tv.SelectedNode.Tag
        End If
    End Sub
    Private Sub chbBC_CheckedChanged(sender As Object, e As EventArgs) Handles chbBC.CheckedChanged
        Mkc_ColorCombobox6.Visible = chbBC.Checked
    End Sub
    Private Sub txtClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtL0.Click, txtL1.Click, txtL2.Click, txtL3.Click, txtL4.Click, txtL5.Click, txtL6.Click, txtL7.Click
        Dim txt As TextBox = CType(sender, TextBox)
        Dim pnl As Panel = txt.Parent
        For Each p As Panel In TableLayoutPanel1.Controls
            If p.Equals(pnl) Then
                If p.Height > 50 Then
                    p.AutoSize = False
                    p.Height = 20
                Else
                    'p.Height = CInt(p.Tag.ToString)
                    p.AutoSize = True
                End If
            Else
                If p.Name <> "PaneT8" Then
                    p.AutoSize = False
                    p.Height = 20
                End If
            End If
        Next
    End Sub
    Private Sub tvISTTabele_NodeMouseHover(sender As Object, e As TreeNodeMouseHoverEventArgs)
        Me.txtError.Text = e.Node.Name
    End Sub
    Private Sub btnNewError_Click(sender As Object, e As EventArgs) Handles btnNewError.Click
        Call isprazni()
        If cboTable.Text = "" Then
            ISTMessageBox.Show("You must select table")
        Else
            pnErrorNumber.Visible = True
        End If
    End Sub
    Sub zapamtiLk()
        Dim sqlconn As New SqlConnection(Me.ISTConnectionString)
        sqlconn.Open()
        Dim cmd As New SqlCommand("spUpdateInsertISTLK", sqlconn)
        cmd.CommandType = CommandType.StoredProcedure
        Dim rbrGreske As String = ""
        If txtNewErrorNumber.Visible Then
            rbrGreske = txtNewErrorNumber.Text
        Else rbrGreske = cboErrorNumber.Text
        End If
        Dim errWeight As String = ""
        Dim condition As String = ""

        If Me.rbT.Checked = True Then errWeight = "T"
        If Me.rbL.Checked = True Then errWeight = "L"
        If Me.rbYellow.Checked = True Then errWeight = "Y"
        If Me.rbGreen.Checked = True Then errWeight = "G"
        If Me.rbPurple.Checked = True Then errWeight = "P"
        If Me.rbNoColor.Checked = True Then errWeight = "N"
        If Me.rbSlovoQ.Checked = True Then errWeight = "Q"

        If Me.rbOnlyOnBLC.Checked = True Then condition = "EXECUTEONLYFROMDATAVALIDATIONMODULE"
        If Me.rbDontSave.Checked = True Then condition = "DONTSAVE"

        Try
            cmd.Parameters.Add("@SIFIST", SqlDbType.NVarChar, 8)
            cmd.Parameters("@SIFIST").Value = cboIST.Text
            cmd.Parameters.Add("@TABELA", SqlDbType.NVarChar, 50)
            cmd.Parameters("@TABELA").Value = cboTable.Text
            cmd.Parameters.Add("@RbrGreske", SqlDbType.NVarChar, 18)
            cmd.Parameters("@RbrGreske").Value = rbrGreske
            cmd.Parameters.Add("@vodPre", SqlDbType.NVarChar, 10)
            cmd.Parameters("@vodPre").Value = cboValidFrom.Text

            cmd.Parameters.Add("@Greska", SqlDbType.NVarChar, 4000)
            cmd.Parameters("@Greska").Value = txtError.Text
            cmd.Parameters.Add("@uslov", SqlDbType.NVarChar, 255)
            cmd.Parameters("@uslov").Value = condition
            cmd.Parameters.Add("@nazivGreske", SqlDbType.NVarChar, 255)
            cmd.Parameters("@nazivGreske").Value = txtTitle.Text
            cmd.Parameters.Add("@Akcija", SqlDbType.NVarChar, 255)
            cmd.Parameters("@Akcija").Value = txtAction.Text
            cmd.Parameters.Add("@tezina", SqlDbType.Char, 1)
            cmd.Parameters("@tezina").Value = errWeight
            cmd.Parameters.Add("@vod", SqlDbType.NVarChar, 10)
            cmd.Parameters("@vod").Value = vod.Text
            cmd.Parameters.Add("@vdo", SqlDbType.NVarChar, 10)
            cmd.Parameters("@vdo").Value = vdo.Text
            cmd.ExecuteNonQuery()
            sqlconn.Close()
            ISTMessageBox.Show("Successfully!!!")
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboIST_Leave(sender As Object, e As EventArgs) Handles cboIST.Leave
        cboIST.SelectedIndex = cboIST.FindString(cboIST.Text)
    End Sub
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        zapamtiLk()
    End Sub
    Private Sub btnCLOSE_Click(sender As Object, e As EventArgs) Handles btnCLOSE.Click
        Me.Close()
    End Sub
    Private Sub txtNewErrorNumber_Leave(sender As Object, e As EventArgs) Handles txtNewErrorNumber.Leave
        Dim greskaIndex As Integer

        greskaIndex = cboErrorNumber.FindString(txtNewErrorNumber.Text)
        If greskaIndex > 0 Then
            ISTMessageBox.Show("The error exists")
            txtNewErrorNumber.Text = ""
            txtNewErrorNumber.Select()
        End If
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = DialogResult.OK Then
            txtAction.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub btnREfresh_Click(sender As Object, e As EventArgs) Handles btnREfresh.Click
        Call isprazni()
        If Me.cboIST.SelectedValue <> "" Then
            Call DajTabelePoljaIST(tv, Me.cboIST.SelectedValue)
            ISTMessageBox.Show("Succefully!!!")
        End If
        pnErrorNumber.Visible = False
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    'Sub setTheme(ByVal theme As String)
    '    If theme = "L" Then
    '        ISTTheme.ChosenTheme("Light")
    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    Else
    '        ISTTheme.ChosenTheme("Dark")
    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    End If
    'End Sub

    Dim zapamtibojuteme As Color = Nothing
    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelTop
        ReDim Preserve nizButtonOboji(2)
        'ActivateButtonColor
        Dim nizButtonOrange() As Button = {}
        Dim inizButtonOrange As Integer = -1

        'For i As Integer = 0 To nizButton.GetUpperBound(0)
        '    ReDim Preserve nizButtonOrange(i)
        '    nizButtonOrange(i) = nizButton(i)
        '    inizButtonOrange = i
        'Next
        zapamtibojuteme = setTheme(nizButtonOboji, nizButtonOrange, theme)

    End Sub

    Private Sub frm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SettingObjForTheme(GetTheme())
        Me.SplitContainer4.SplitterDistance = 50
        Me.SplitContainer1.SplitterDistance = 250

        Me.paneT0.AutoSize = False
        Me.paneT1.AutoSize = False
        Me.paneT2.AutoSize = False
        Me.paneT3.AutoSize = False
        Me.paneT4.AutoSize = False
        Me.paneT5.AutoSize = False
        Me.paneT6.AutoSize = False
        Me.paneT7.AutoSize = False
        Me.PaneT8.AutoSize = False

        Me.paneT0.Height = 20
        Me.paneT1.Height = 20
        Me.paneT2.Height = 20
        Me.paneT3.Height = 20
        Me.paneT4.Height = 20
        Me.paneT5.Height = 20
        Me.paneT6.Height = 20
        Me.paneT7.Height = 20
        Me.PaneT8.Height = 200


        Me.paneT0.Dock = DockStyle.Fill
        Me.paneT1.Dock = DockStyle.Fill
        Me.paneT2.Dock = DockStyle.Fill
        Me.paneT3.Dock = DockStyle.Fill
        Me.paneT4.Dock = DockStyle.Fill
        Me.paneT5.Dock = DockStyle.Fill
        Me.paneT6.Dock = DockStyle.Fill
        Me.paneT7.Dock = DockStyle.Fill
        Me.PaneT8.Dock = DockStyle.Bottom
        Me.TableLayoutPanel1.Dock = DockStyle.Fill
        Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST order by 1"
        Call popunicbo(cboIST, strSQl, Me.ISTConnectionString)
        cboTable.Text = String.Empty
        cboErrorNumber.Text = String.Empty

        If appCode <> "" Then
            cboIST.SelectedValue = appCode
            Call DajTabelePoljaIST(tv, Me.cboIST.SelectedValue)
        End If
    End Sub

End Class