Option Strict Off

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Diagnostics

Public Class Form_ISTTables
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

    Friend WithEvents mnu00 As ContextMenuStrip
    Friend WithEvents ToolStripSeparator19 As ToolStripSeparator
    Friend WithEvents dafc As ToolStripMenuItem
    Friend WithEvents dafw As ToolStripMenuItem
    Friend WithEvents dafch As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents Label1 As Label
    Friend WithEvents cboIST As ComboBox
    Friend WithEvents tv As TreeView
    Friend WithEvents txtTL1 As TextBox
    Friend WithEvents txtTL3 As TextBox
    Friend WithEvents paneT3 As Panel
    Friend WithEvents paneT1 As Panel
    Friend WithEvents Mkc_ColorCombobox2T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox1T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbBC As CheckBox
    Friend WithEvents cbFC As CheckBox
    Friend WithEvents cbN As CheckBox
    Friend WithEvents tbH As TrackBar
    Friend WithEvents cbH As CheckBox
    Friend WithEvents cbAR As CheckBox
    Friend WithEvents cbI As CheckBox
    Friend WithEvents cbTBold As CheckBox
    Friend WithEvents cbTAC As CheckBox
    Friend WithEvents cbS As CheckBox
    Friend WithEvents paneT0 As Panel
    Friend WithEvents txtTL0 As TextBox
    Friend WithEvents GB As GroupBox
    Friend WithEvents rbS As RadioButton
    Friend WithEvents rbK As RadioButton
    Friend WithEvents rbABook As RadioButton
    Friend WithEvents rbD As RadioButton
    Friend WithEvents rbG As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTTitle As TextBox
    Friend WithEvents paneT4 As Panel
    Friend WithEvents txtTL4 As TextBox
    Friend WithEvents paneT5 As Panel
    Friend WithEvents txtTL5 As TextBox
    Friend WithEvents paneT6 As Panel
    Friend WithEvents txtTL6 As TextBox
    Friend WithEvents cbOnSaveNextDontClose As CheckBox
    Friend WithEvents dgvOnSaveNextStop As DataGridView
    Friend WithEvents dgvOnSaveNextClose As DataGridView
    Friend WithEvents dgvOnSaveNextMSG As DataGridView
    Friend WithEvents dgvOnSaveNextSimpleMSG As DataGridView
    Friend WithEvents dgvOnSaveNextNote As DataGridView
    Friend WithEvents dgvOnSaveNextDelete As DataGridView
    Friend WithEvents dgvOnSaveNextExec As DataGridView
    Friend WithEvents dgvOnButtonClickStop As DataGridView
    Friend WithEvents dgvOnSaveNextFocusOn As DataGridView
    Friend WithEvents dgvOnSaveExec As DataGridView
    Friend WithEvents dgvOnExitMSG As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents cIF As DataGridViewTextBoxColumn
    Friend WithEvents cMSG As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanelTABLE As TableLayoutPanel
    Friend WithEvents paneT8 As Panel
    Friend WithEvents txtTUpdate As TextBox
    Friend WithEvents paneT7 As Panel
    Friend WithEvents Mkc_ColorCombobox5T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox6T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbNoteBC As CheckBox
    Friend WithEvents cbNoteFC As CheckBox
    Friend WithEvents lblNoteDefaultText As Label
    Friend WithEvents txtNote As TextBox
    Friend WithEvents cbNoteS As CheckBox
    Friend WithEvents txtNY As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txtNX As TextBox
    Friend WithEvents txtTL7 As TextBox
    Friend WithEvents txtvdoT0 As DateTimePicker2
    Friend WithEvents txtvodT0 As DateTimePicker2
    Friend WithEvents txtOrdinalNumber As TextBox
    Friend WithEvents lblGT As Label
    Friend WithEvents cboNadTabela As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtL12 As TextBox
    Friend WithEvents txtTitleO As TextBox
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents txtT2BY As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtT2BX As TextBox
    Friend WithEvents cbT2DisableMouse As CheckBox
    Friend WithEvents cbOnButtonClick As CheckBox
    Friend WithEvents cbT2BAR As CheckBox
    Friend WithEvents cbT2BI As CheckBox
    Friend WithEvents cbT2BB As CheckBox
    Friend WithEvents cbT2BAC As CheckBox
    Friend WithEvents cbT2BS As CheckBox
    Friend WithEvents cbNoButton As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDESO As TextBox
    Friend WithEvents txtT2BH As TextBox
    Friend WithEvents txtT2BW As TextBox
    Friend WithEvents txtGH As TextBox
    Friend WithEvents cbView As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Mkc_ColorCombobox3T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox4T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbBH As CheckBox
    Friend WithEvents cbT2BBC As CheckBox
    Friend WithEvents cbBW As CheckBox
    Friend WithEvents cbT2BFC As CheckBox
    Friend WithEvents cbHA As CheckBox
    Friend WithEvents cbNoGridSpace As CheckBox
    Friend WithEvents cbNoGrid As CheckBox
    Friend WithEvents cbGCI As CheckBox
    Friend WithEvents cbT2Max As CheckBox
    Friend WithEvents cbGH As CheckBox
    Friend WithEvents cbT2Min As CheckBox
    Friend WithEvents cbGCAR As CheckBox
    Friend WithEvents cbT2Web As CheckBox
    Friend WithEvents cbNoPlus As CheckBox
    Friend WithEvents cbBVF As CheckBox
    Friend WithEvents dfind As ToolStripMenuItem
    Friend WithEvents castI As ToolStripMenuItem
    Friend WithEvents castD182 As ToolStripMenuItem
    Friend WithEvents castC As ToolStripMenuItem
    Friend WithEvents castC50 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents isnullP As ToolStripMenuItem
    Friend WithEvents isnullP0 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn

    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn

    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn

    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents txtSY As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtSX As TextBox
    Friend WithEvents tbFS As TrackBar
    Friend WithEvents tbNFS As TrackBar
    Friend WithEvents tbBFS As TrackBar
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage41 As TabPage
    Friend WithEvents TabPage42 As TabPage
    Friend WithEvents TabPage43 As TabPage
    Friend WithEvents TabPage44 As TabPage
    Friend WithEvents TabPage45 As TabPage
    Friend WithEvents TabPage46 As TabPage
    Friend WithEvents TabPage47 As TabPage
    Friend WithEvents TabPage48 As TabPage
    Friend WithEvents mnu01 As ContextMenuStrip
    Friend WithEvents DDFIND As ToolStripMenuItem
    Friend WithEvents btnT0OK As Button
    Friend WithEvents btnT0Cancel As Button
    Friend WithEvents btnT7OK As Button
    Friend WithEvents btnT7Cancel As Button
    Friend WithEvents btnT1OK As Button
    Friend WithEvents btnT1Cancel As Button
    Friend WithEvents btnT3OK As Button
    Friend WithEvents btnT3Cancel As Button
    Friend WithEvents btnT4OK As Button
    Friend WithEvents btnT4Cancel As Button
    Friend WithEvents btnT5OK As Button
    Friend WithEvents btnT5Cancel As Button
    Friend WithEvents btnT6OK As Button
    Friend WithEvents btnT6Cancel As Button
    Friend WithEvents lbOnSaveExec As ListBox
    Friend WithEvents lbOnSaveNextExec As ListBox
    Friend WithEvents mnu02 As ContextMenuStrip
    Friend WithEvents tDCI As ToolStripMenuItem
    Friend WithEvents tRefresh As ToolStripMenuItem
    Friend WithEvents tDCDB As ToolStripMenuItem
    Friend WithEvents paneAT As Panel
    Friend WithEvents txtTLAT As TextBox
    Friend WithEvents btnATOK As Button
    Friend WithEvents btnATCancel As Button
    Friend WithEvents lblGAT As Label
    Friend WithEvents cboNadTabelaAT As ComboBox
    Friend WithEvents txtvdoAT As DateTimePicker2
    Friend WithEvents txtvodAT As DateTimePicker2
    Friend WithEvents txtlbl12AT As TextBox
    Friend WithEvents txtDescriptionAT As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents cboTipAT As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtNameAT As TextBox
    Friend WithEvents TableLayoutPanelCOLUMN As TableLayoutPanel
    Friend WithEvents paneP0 As Panel
    Friend WithEvents Label63 As Label
    Friend WithEvents chbFilterLK As CheckBox
    Friend WithEvents Label45 As Label
    Friend WithEvents txtType As ComboBox
    Friend WithEvents btnP0OK As Button
    Friend WithEvents btnP0Cancel As Button
    Friend WithEvents Label52 As Label
    Friend WithEvents CboRelTable As ComboBox
    Friend WithEvents CboRelCol As ComboBox
    Friend WithEvents cboRelDB As ComboBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtvdo As DateTimePicker2
    Friend WithEvents txtvod As DateTimePicker2
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtLenght As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txtDV As TextBox
    Friend WithEvents chbPK As CheckBox
    Friend WithEvents txtL0 As TextBox
    Friend WithEvents paneP1 As Panel
    Friend WithEvents dgvRB As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents Label53 As Label
    Friend WithEvents btnP1OK As Button
    Friend WithEvents btnP1Cancel As Button
    Friend WithEvents gbAC As GroupBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents txtACFilterStart As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents txtLett As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents txtACWidth As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents txtACHeight As TextBox
    Friend WithEvents txtACFilterLen As TextBox
    Friend WithEvents cbACLTL As CheckBox
    Friend WithEvents txtACAsgnLen As TextBox
    Friend WithEvents txtACFilterName As TextBox
    Friend WithEvents txtACAsgnStart As TextBox
    Friend WithEvents txtACAsgn As TextBox
    Friend WithEvents txtACMinTL As TextBox
    Friend WithEvents txtACLength As TextBox
    Friend WithEvents txtACStart As TextBox
    Friend WithEvents llACB As LinkLabel
    Friend WithEvents txtACB As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents txtCBGroup As TextBox
    Friend WithEvents TabControlDGV As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents cboGS As ComboBox
    Friend WithEvents txtGSW As TextBox
    Friend WithEvents txtGTitle As TextBox
    Friend WithEvents txtGFS As TextBox
    Friend WithEvents txtGWidth As TextBox
    Friend WithEvents txtGLocationX As TextBox
    Friend WithEvents txtGHeight As TextBox
    Friend WithEvents txtGLocationY As TextBox
    Friend WithEvents lblGLocationX As Label
    Friend WithEvents lblGLocationY As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label62 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents txtGColHHght As TextBox
    Friend WithEvents txtGRHW As TextBox
    Friend WithEvents txtGHRFS As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dgvGridStop As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtGridEditText As TextBox
    Friend WithEvents txtGridOpenText As TextBox
    Friend WithEvents txtGridDeleteText As TextBox
    Friend WithEvents txtGridDeleteWidth As TextBox
    Friend WithEvents txtGridOpenWidth As TextBox
    Friend WithEvents txtGridEditWidth As TextBox
    Friend WithEvents cboGOpen As ComboBox
    Friend WithEvents chbGEdit As CheckBox
    Friend WithEvents chbGridOpen As CheckBox
    Friend WithEvents chbGridDelete As CheckBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents dgvGridColumn As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents dgvGridAddCol As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents txtExpression As TextBox
    Friend WithEvents txtL6 As TextBox
    Friend WithEvents gbCBO As GroupBox
    Friend WithEvents lDM As Label
    Friend WithEvents lVM As Label
    Friend WithEvents lF As Label
    Friend WithEvents txtfDM As TextBox
    Friend WithEvents txtfVM As TextBox
    Friend WithEvents txtfF As TextBox
    Friend WithEvents lDS As Label
    Friend WithEvents cbCWO As CheckBox
    Friend WithEvents txtfDS As TextBox
    Friend WithEvents cbHRB As CheckBox
    Friend WithEvents cbVRB As CheckBox
    Friend WithEvents cbLL As CheckBox
    Friend WithEvents cbDTP As CheckBox
    Friend WithEvents cbDGV As CheckBox
    Friend WithEvents cbRCHB As CheckBox
    Friend WithEvents cbLCHB As CheckBox
    Friend WithEvents cbCHB As CheckBox
    Friend WithEvents cbAC As CheckBox
    Friend WithEvents cbCB As CheckBox
    Friend WithEvents cbB As CheckBox
    Friend WithEvents cbTB As CheckBox
    Friend WithEvents Label68 As Label
    Friend WithEvents cbFP As CheckBox
    Friend WithEvents paneP2 As Panel
    Friend WithEvents paneP21 As Panel
    Friend WithEvents dgvHeaderSpec As DataGridView
    Friend WithEvents Label71 As Label
    Friend WithEvents btnP2OK As Button
    Friend WithEvents btnP2Cancel As Button
    Friend WithEvents tbFSize As TrackBar
    Friend WithEvents chbML As CheckBox
    Friend WithEvents Label72 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Mkc_ColorCombobox1 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox2 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents chbBackColor As CheckBox
    Friend WithEvents chbForeColor As CheckBox
    Friend WithEvents chbOnlyTitle As CheckBox
    Friend WithEvents txtL1 As TextBox
    Friend WithEvents chbRAligment As CheckBox
    Friend WithEvents chbFItalic As CheckBox
    Friend WithEvents chbFBold As CheckBox
    Friend WithEvents chbCAligment As CheckBox
    Friend WithEvents chbFSize As CheckBox
    Friend WithEvents paneP3 As Panel
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents txtSPOrderColumn As TextBox
    Friend WithEvents txtSPOrderRow As TextBox
    Friend WithEvents btnP3OK As Button
    Friend WithEvents btnP3Cancel As Button
    Friend WithEvents Label76 As Label
    Friend WithEvents chbNQG As CheckBox
    Friend WithEvents chbNTS As CheckBox
    Friend WithEvents Label77 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents txtSPOrderTable As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents txtVS As TextBox
    Friend WithEvents txtON As TextBox
    Friend WithEvents chbNewWebGroup As CheckBox
    Friend WithEvents chbRight As CheckBox
    Friend WithEvents chbCentar As CheckBox
    Friend WithEvents Mkc_ColorComboboxBC As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorComboboxFC As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents chbBC As CheckBox
    Friend WithEvents chbFC As CheckBox
    Friend WithEvents chbVF As CheckBox
    Friend WithEvents chbEF As CheckBox
    Friend WithEvents chbBF As CheckBox
    Friend WithEvents chbBN As CheckBox
    Friend WithEvents chbFB As CheckBox
    Friend WithEvents chbItalic As CheckBox
    Friend WithEvents chbFU As CheckBox
    Friend WithEvents txtMultilineH As TextBox
    Friend WithEvents chbMultilineH As CheckBox
    Friend WithEvents chbMultiline As CheckBox
    Friend WithEvents chbRO As CheckBox
    Friend WithEvents txtL4 As TextBox
    Friend WithEvents paneP6 As Panel
    Friend WithEvents paneAC As Panel
    Friend WithEvents panePPreview As Panel
    Friend WithEvents cbPKAC As CheckBox
    Friend WithEvents txtvdoAC As DateTimePicker2
    Friend WithEvents txtvodAC As DateTimePicker2
    Friend WithEvents txtlbl12AC As TextBox
    Friend WithEvents txtLabelAC As TextBox
    Friend WithEvents lblDescriptionAC As Label
    Friend WithEvents txtLenAC As TextBox
    Friend WithEvents lblLntAC As Label
    Friend WithEvents lblTypeAC As Label
    Friend WithEvents cboTypeAC As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents gbOptionsAC As GroupBox
    Friend WithEvents txtTotalAC As TextBox
    Friend WithEvents lblNumber1AC As Label
    Friend WithEvents txtNameAC As TextBox
    Friend WithEvents txtCLAC As TextBox
    Friend WithEvents txtlblPPreview As TextBox
    Friend WithEvents txtCUpdate As TextBox
    Friend WithEvents PanelAAT As Panel
    Friend WithEvents txtAT2 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtCNAC As TextBox
    Friend WithEvents txtTNAC As TextBox
    Friend WithEvents txtRNAC As TextBox
    Friend WithEvents cbTableAC As CheckBox
    Friend WithEvents Label95 As Label
    Friend WithEvents Label98 As Label
    Friend WithEvents cbTabDownLeft As CheckBox
    Friend WithEvents txtNLC As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents txtColLen As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents Mkc_tbc As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_tfc As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbAddE As CheckBox
    Friend WithEvents cbAddMo As CheckBox
    Friend WithEvents cbAddY As CheckBox
    Friend WithEvents cbAddMB As CheckBox
    Friend WithEvents cbAddM As CheckBox
    Friend WithEvents cbAddG As CheckBox
    Friend WithEvents gbUC As GroupBox
    Friend WithEvents btnUC As Button
    Friend WithEvents cbAddUC As CheckBox
    Friend WithEvents Label113 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents Label111 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents dgvHeader As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Col18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents txtL11 As TextBox
    Friend WithEvents btnP21OK As Button
    Friend WithEvents btnP21Cancel As Button
    Friend WithEvents chbTabIndex As CheckBox
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewComboBoxColumn
    Friend WithEvents Column14 As DataGridViewComboBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents mnuColumnNumber As ContextMenuStrip
    Friend WithEvents nhide As ToolStripMenuItem
    Friend WithEvents nunhide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents nsort As ToolStripMenuItem
    Friend WithEvents nmcs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents nfind As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents nequals As ToolStripMenuItem
    Friend WithEvents ndnequals As ToolStripMenuItem
    Friend WithEvents nfilter As ToolStripMenuItem
    Friend WithEvents nunfilterall As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents nfreeze As ToolStripMenuItem
    Friend WithEvents nunfreezeall As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents nafc As ToolStripMenuItem
    Friend WithEvents nafw As ToolStripMenuItem
    Friend WithEvents nafch As ToolStripMenuItem
    Friend WithEvents mnuColumnText As ContextMenuStrip
    Friend WithEvents dhide As ToolStripMenuItem
    Friend WithEvents dunhide As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As ToolStripSeparator
    Friend WithEvents dsort As ToolStripMenuItem
    Friend WithEvents dmcs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As ToolStripSeparator
    Friend WithEvents DFIND2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents dequals As ToolStripMenuItem
    Friend WithEvents ddnequals As ToolStripMenuItem
    Friend WithEvents dfilter As ToolStripMenuItem
    Friend WithEvents dunfilterall As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents dfreeze As ToolStripMenuItem
    Friend WithEvents dunfreezeall As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents DAFC2 As ToolStripMenuItem
    Friend WithEvents DAFW2 As ToolStripMenuItem
    Friend WithEvents DAFCh2 As ToolStripMenuItem
    Friend WithEvents txtNLR As TextBox
    Friend WithEvents Label121 As Label
    Friend WithEvents gbApp As TabControl
    Friend WithEvents TabPageRa As TabPage
    Friend WithEvents TabPageCa As TabPage
    Friend WithEvents c110 As ComboBox
    Friend WithEvents dgvAppC As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents c120 As CheckBox
    Friend WithEvents btnAppC As Button
    Friend WithEvents c6 As CheckBox
    Friend WithEvents Label123 As Label
    Friend WithEvents c11 As TextBox
    Friend WithEvents Label122 As Label
    Friend WithEvents c12 As TextBox
    Friend WithEvents Label118 As Label
    Friend WithEvents c10 As TextBox
    Friend WithEvents Label120 As Label
    Friend WithEvents c9 As TextBox
    Friend WithEvents Label97 As Label
    Friend WithEvents c8 As TextBox
    Friend WithEvents Label119 As Label
    Friend WithEvents Label117 As Label
    Friend WithEvents c7 As TextBox
    Friend WithEvents Label116 As Label
    Friend WithEvents Label115 As Label
    Friend WithEvents c5 As ComboBox
    Friend WithEvents Label114 As Label
    Friend WithEvents c4 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents c3 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Label105 As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents Label103 As Label
    Friend WithEvents c2 As ComboBox
    Friend WithEvents Label102 As Label
    Friend WithEvents c0 As TextBox
    Friend WithEvents c1 As ComboBox
    Friend WithEvents Label101 As Label
    Friend WithEvents r110 As ComboBox
    Friend WithEvents dgvAppR As DataGridView
    Friend WithEvents r120 As CheckBox
    Friend WithEvents btnAppR As Button
    Friend WithEvents r6 As CheckBox
    Friend WithEvents Label127 As Label
    Friend WithEvents r11 As TextBox
    Friend WithEvents Label128 As Label
    Friend WithEvents r12 As TextBox
    Friend WithEvents Label129 As Label
    Friend WithEvents r10 As TextBox
    Friend WithEvents Label130 As Label
    Friend WithEvents r9 As TextBox
    Friend WithEvents Label131 As Label
    Friend WithEvents r8 As TextBox
    Friend WithEvents Label132 As Label
    Friend WithEvents Label133 As Label
    Friend WithEvents r7 As TextBox
    Friend WithEvents Label134 As Label
    Friend WithEvents Label135 As Label
    Friend WithEvents r5 As ComboBox
    Friend WithEvents Label136 As Label
    Friend WithEvents r4 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents r3 As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Label137 As Label
    Friend WithEvents Label138 As Label
    Friend WithEvents Label139 As Label
    Friend WithEvents r2 As ComboBox
    Friend WithEvents Label140 As Label
    Friend WithEvents r0 As TextBox
    Friend WithEvents r1 As ComboBox
    Friend WithEvents Label141 As Label
    Friend WithEvents cbPFC As CheckBox
    Friend WithEvents cboBCAT As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cboFCAT As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cboBGCAT As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Label144 As Label
    Friend WithEvents cboTAAT As ComboBox
    Friend WithEvents cboFTAT As ComboBox
    Friend WithEvents Label145 As Label
    Friend WithEvents tbSAT As TrackBar
    Friend WithEvents tbHAT As TrackBar
    Friend WithEvents cbHAT As CheckBox
    Friend WithEvents cbSAT As CheckBox
    Friend WithEvents txtColumnsStartFrom As TextBox
    Friend WithEvents txtRowsStartFrom As TextBox
    Friend WithEvents chbColumnsStartFrom As CheckBox
    Friend WithEvents chbRowsStartFrom As CheckBox
    Friend WithEvents llPreviewT As LinkLabel
    Friend WithEvents btnTSubmit As Button
    Friend WithEvents btnTSubmitCancel As Button
    Friend WithEvents btnCSubmit As Button
    Friend WithEvents btnCSubmitCancel As Button
    Friend WithEvents cbTc2 As CheckBox
    Friend WithEvents cbTc1 As CheckBox
    Friend WithEvents cbTc4 As CheckBox
    Friend WithEvents cbTc6 As CheckBox
    Friend WithEvents cbTc5 As CheckBox
    Friend WithEvents tssc11 As ToolStripSeparator
    Friend WithEvents tssc1 As ToolStripMenuItem
    Friend WithEvents tssc2 As ToolStripMenuItem
    Friend WithEvents tssc3 As ToolStripMenuItem
    Friend WithEvents tssc12 As ToolStripSeparator
    Friend WithEvents tssc4 As ToolStripMenuItem
    Friend WithEvents tssc5 As ToolStripMenuItem
    Friend WithEvents tssc6 As ToolStripMenuItem
    Friend WithEvents tFC As ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents mnu03 As ContextMenuStrip
    Friend WithEvents tdtI As ToolStripMenuItem
    Friend WithEvents tdtDB As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents tFT As ToolStripTextBox
    Friend WithEvents ttRefresh As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents tsst1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents tsst2 As ToolStripMenuItem
    Friend WithEvents tsst3 As ToolStripMenuItem
    Friend WithEvents tsst4 As ToolStripMenuItem
    Friend WithEvents tsst5 As ToolStripMenuItem
    Friend WithEvents tsst6 As ToolStripMenuItem
    Friend WithEvents tsst7 As ToolStripMenuItem
    Friend WithEvents tsst8 As ToolStripMenuItem
    Friend WithEvents tsst9 As ToolStripMenuItem
    Friend WithEvents nacrw As ToolStripMenuItem
    Friend WithEvents DACRW As ToolStripMenuItem
    Friend WithEvents cbCopyT As CheckBox
    Friend WithEvents gbCopy As GroupBox
    Friend WithEvents Label106 As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents cbCopy As ComboBox
    Friend WithEvents cbCopyName As TextBox
    Friend WithEvents btn2 As Button
    Friend WithEvents cbCopyMD As CheckBox
    Friend WithEvents btn1 As Button
    Friend WithEvents Label107 As Label
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn58 As DataGridViewTextBoxColumn
    Friend WithEvents cbDNR As CheckBox
    Friend WithEvents paneT2 As Panel
    Friend WithEvents cboBGCATe As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbTc3 As CheckBox
    Friend WithEvents btnT2Cancel As Button
    Friend WithEvents btnT2OK As Button
    Friend WithEvents dgvDontOpen As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents cbPKD As CheckBox
    Friend WithEvents paneAWL As Panel
    Friend WithEvents Mkc_ColorCombobox8T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents txtY As TextBox
    Friend WithEvents Mkc_ColorCombobox7T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbAWLBC As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbAWLFC As CheckBox
    Friend WithEvents cbInline As CheckBox
    Friend WithEvents cbNotMovable As CheckBox
    Friend WithEvents lblY As Label
    Friend WithEvents lblDT As Label
    Friend WithEvents lblX As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents cbDontOpen As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbAVL As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbT1HSVF As CheckBox
    Friend WithEvents txtDT As TextBox
    Friend WithEvents cbT1VSVF As CheckBox
    Friend WithEvents cbPKLeave As CheckBox
    Friend WithEvents cbDNTRM As CheckBox
    Friend WithEvents cbT1DisableMouse As CheckBox
    Friend WithEvents cbSupportEU As CheckBox
    Friend WithEvents cbMixmode As CheckBox
    Friend WithEvents cbLCcbVF As CheckBox
    Friend WithEvents cbSVF As CheckBox
    Friend WithEvents cbLKVF As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbCATI As CheckBox
    Friend WithEvents cbT1Web As CheckBox
    Friend WithEvents cbK As CheckBox
    Friend WithEvents cbA As CheckBox
    Friend WithEvents txtTL2 As TextBox
    Friend WithEvents cbX As CheckBox
    Friend WithEvents cbSendEmail As CheckBox
    Friend WithEvents cbAdvancedSearch As CheckBox
    Friend WithEvents cbMax As CheckBox
    Friend WithEvents txtYH As TextBox
    Friend WithEvents Label86 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents txtXW As TextBox
    Friend WithEvents llC4 As LinkLabel
    Friend WithEvents PanelCPE As Panel
    Friend WithEvents btnOKCPE As Button
    Friend WithEvents btnCancelCPE As Button
    Friend WithEvents dgvCPE As DataGridView
    Friend WithEvents llPreviewC As LinkLabel
    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents llC2 As LinkLabel
    Friend WithEvents llC1 As LinkLabel
    Friend WithEvents llC3 As LinkLabel
    Friend WithEvents cboCPE As ComboBox
    Friend WithEvents Label89 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents clbLang As CheckedListBox
    Friend WithEvents btnAddLang As Button
    Friend WithEvents btnACCancel As Button
    Friend WithEvents btnACOK As Button
    Friend WithEvents tRenameC As ToolStripMenuItem
    Friend WithEvents tRenameT As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents Label91 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents cbLabelVF As CheckBox
    Friend WithEvents cbAwls As CheckBox
    Friend WithEvents llC5 As LinkLabel
    Friend WithEvents cbTableDescription As CheckBox
    Friend WithEvents cbLabel As CheckBox
    Friend WithEvents llC6 As LinkLabel
    Friend WithEvents llCC7 As LinkLabel
    Friend WithEvents llC8 As LinkLabel
    Friend WithEvents cbMessage As CheckBox
    Friend WithEvents cbQE As CheckBox
    Friend WithEvents llC9 As LinkLabel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents cbDESO As CheckBox

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_ISTTables))
        Me.mnu00 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.castI = New System.Windows.Forms.ToolStripMenuItem()
        Me.castD182 = New System.Windows.Forms.ToolStripMenuItem()
        Me.castC = New System.Windows.Forms.ToolStripMenuItem()
        Me.castC50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.isnullP = New System.Windows.Forms.ToolStripMenuItem()
        Me.isnullP0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.dfind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.dafc = New System.Windows.Forms.ToolStripMenuItem()
        Me.dafw = New System.Windows.Forms.ToolStripMenuItem()
        Me.dafch = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboIST = New System.Windows.Forms.ComboBox()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanelTABLE = New System.Windows.Forms.TableLayoutPanel()
        Me.paneT2 = New System.Windows.Forms.Panel()
        Me.cboBGCATe = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbTc3 = New System.Windows.Forms.CheckBox()
        Me.btnT2Cancel = New System.Windows.Forms.Button()
        Me.btnT2OK = New System.Windows.Forms.Button()
        Me.dgvDontOpen = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbPKD = New System.Windows.Forms.CheckBox()
        Me.paneAWL = New System.Windows.Forms.Panel()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Mkc_ColorCombobox8T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.txtYH = New System.Windows.Forms.TextBox()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txtXW = New System.Windows.Forms.TextBox()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.Mkc_ColorCombobox7T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbAWLBC = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbAWLFC = New System.Windows.Forms.CheckBox()
        Me.cbInline = New System.Windows.Forms.CheckBox()
        Me.cbNotMovable = New System.Windows.Forms.CheckBox()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblDT = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.cbDontOpen = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbAVL = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbT1HSVF = New System.Windows.Forms.CheckBox()
        Me.txtDT = New System.Windows.Forms.TextBox()
        Me.cbT1VSVF = New System.Windows.Forms.CheckBox()
        Me.cbPKLeave = New System.Windows.Forms.CheckBox()
        Me.cbDNTRM = New System.Windows.Forms.CheckBox()
        Me.cbT1DisableMouse = New System.Windows.Forms.CheckBox()
        Me.cbSupportEU = New System.Windows.Forms.CheckBox()
        Me.cbMixmode = New System.Windows.Forms.CheckBox()
        Me.cbLCcbVF = New System.Windows.Forms.CheckBox()
        Me.cbSVF = New System.Windows.Forms.CheckBox()
        Me.cbLKVF = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCATI = New System.Windows.Forms.CheckBox()
        Me.cbT1Web = New System.Windows.Forms.CheckBox()
        Me.cbK = New System.Windows.Forms.CheckBox()
        Me.cbA = New System.Windows.Forms.CheckBox()
        Me.txtTL2 = New System.Windows.Forms.TextBox()
        Me.cbX = New System.Windows.Forms.CheckBox()
        Me.cbSendEmail = New System.Windows.Forms.CheckBox()
        Me.cbAdvancedSearch = New System.Windows.Forms.CheckBox()
        Me.cbMax = New System.Windows.Forms.CheckBox()
        Me.paneT3 = New System.Windows.Forms.Panel()
        Me.cbDNR = New System.Windows.Forms.CheckBox()
        Me.btnT3OK = New System.Windows.Forms.Button()
        Me.btnT3Cancel = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvOnButtonClickStop = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtT2BY = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtT2BX = New System.Windows.Forms.TextBox()
        Me.cbT2DisableMouse = New System.Windows.Forms.CheckBox()
        Me.cbOnButtonClick = New System.Windows.Forms.CheckBox()
        Me.cbT2BAR = New System.Windows.Forms.CheckBox()
        Me.cbT2BI = New System.Windows.Forms.CheckBox()
        Me.cbT2BB = New System.Windows.Forms.CheckBox()
        Me.cbT2BAC = New System.Windows.Forms.CheckBox()
        Me.cbT2BS = New System.Windows.Forms.CheckBox()
        Me.cbNoButton = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDESO = New System.Windows.Forms.TextBox()
        Me.txtT2BH = New System.Windows.Forms.TextBox()
        Me.txtT2BW = New System.Windows.Forms.TextBox()
        Me.txtGH = New System.Windows.Forms.TextBox()
        Me.cbView = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Mkc_ColorCombobox3T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox4T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbBH = New System.Windows.Forms.CheckBox()
        Me.cbT2BBC = New System.Windows.Forms.CheckBox()
        Me.cbBW = New System.Windows.Forms.CheckBox()
        Me.cbT2BFC = New System.Windows.Forms.CheckBox()
        Me.cbHA = New System.Windows.Forms.CheckBox()
        Me.cbNoGridSpace = New System.Windows.Forms.CheckBox()
        Me.cbNoGrid = New System.Windows.Forms.CheckBox()
        Me.cbGCI = New System.Windows.Forms.CheckBox()
        Me.cbT2Max = New System.Windows.Forms.CheckBox()
        Me.cbGH = New System.Windows.Forms.CheckBox()
        Me.cbT2Min = New System.Windows.Forms.CheckBox()
        Me.cbGCAR = New System.Windows.Forms.CheckBox()
        Me.cbT2Web = New System.Windows.Forms.CheckBox()
        Me.cbNoPlus = New System.Windows.Forms.CheckBox()
        Me.cbBVF = New System.Windows.Forms.CheckBox()
        Me.cbDESO = New System.Windows.Forms.CheckBox()
        Me.txtTL3 = New System.Windows.Forms.TextBox()
        Me.tbBFS = New System.Windows.Forms.TrackBar()
        Me.paneAT = New System.Windows.Forms.Panel()
        Me.gbCopy = New System.Windows.Forms.GroupBox()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.cbCopy = New System.Windows.Forms.ComboBox()
        Me.cbCopyName = New System.Windows.Forms.TextBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.cbCopyMD = New System.Windows.Forms.CheckBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.cbCopyT = New System.Windows.Forms.CheckBox()
        Me.cbTc4 = New System.Windows.Forms.CheckBox()
        Me.cbTc2 = New System.Windows.Forms.CheckBox()
        Me.cbTc1 = New System.Windows.Forms.CheckBox()
        Me.llPreviewT = New System.Windows.Forms.LinkLabel()
        Me.tbSAT = New System.Windows.Forms.TrackBar()
        Me.tbHAT = New System.Windows.Forms.TrackBar()
        Me.cbHAT = New System.Windows.Forms.CheckBox()
        Me.cbSAT = New System.Windows.Forms.CheckBox()
        Me.cboBGCAT = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.cboTAAT = New System.Windows.Forms.ComboBox()
        Me.cboFTAT = New System.Windows.Forms.ComboBox()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.cboBCAT = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cboFCAT = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.lblGAT = New System.Windows.Forms.Label()
        Me.cboNadTabelaAT = New System.Windows.Forms.ComboBox()
        Me.txtvdoAT = New DateTimePicker2()
        Me.txtvodAT = New DateTimePicker2()
        Me.txtlbl12AT = New System.Windows.Forms.TextBox()
        Me.txtDescriptionAT = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboTipAT = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNameAT = New System.Windows.Forms.TextBox()
        Me.btnATOK = New System.Windows.Forms.Button()
        Me.btnATCancel = New System.Windows.Forms.Button()
        Me.txtTLAT = New System.Windows.Forms.TextBox()
        Me.paneT0 = New System.Windows.Forms.Panel()
        Me.btnT0OK = New System.Windows.Forms.Button()
        Me.btnT0Cancel = New System.Windows.Forms.Button()
        Me.txtvdoT0 = New DateTimePicker2()
        Me.txtvodT0 = New DateTimePicker2()
        Me.txtOrdinalNumber = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtL12 = New System.Windows.Forms.TextBox()
        Me.txtTL0 = New System.Windows.Forms.TextBox()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.rbS = New System.Windows.Forms.RadioButton()
        Me.rbK = New System.Windows.Forms.RadioButton()
        Me.rbABook = New System.Windows.Forms.RadioButton()
        Me.lblGT = New System.Windows.Forms.Label()
        Me.cboNadTabela = New System.Windows.Forms.ComboBox()
        Me.rbD = New System.Windows.Forms.RadioButton()
        Me.rbG = New System.Windows.Forms.RadioButton()
        Me.paneT1 = New System.Windows.Forms.Panel()
        Me.btnT1OK = New System.Windows.Forms.Button()
        Me.btnT1Cancel = New System.Windows.Forms.Button()
        Me.tbFS = New System.Windows.Forms.TrackBar()
        Me.txtTitleO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTTitle = New System.Windows.Forms.TextBox()
        Me.Mkc_ColorCombobox2T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox1T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbBC = New System.Windows.Forms.CheckBox()
        Me.cbFC = New System.Windows.Forms.CheckBox()
        Me.cbN = New System.Windows.Forms.CheckBox()
        Me.tbH = New System.Windows.Forms.TrackBar()
        Me.cbH = New System.Windows.Forms.CheckBox()
        Me.txtTL1 = New System.Windows.Forms.TextBox()
        Me.cbAR = New System.Windows.Forms.CheckBox()
        Me.cbI = New System.Windows.Forms.CheckBox()
        Me.cbTBold = New System.Windows.Forms.CheckBox()
        Me.cbTAC = New System.Windows.Forms.CheckBox()
        Me.cbS = New System.Windows.Forms.CheckBox()
        Me.paneT4 = New System.Windows.Forms.Panel()
        Me.lbOnSaveExec = New System.Windows.Forms.ListBox()
        Me.btnT4OK = New System.Windows.Forms.Button()
        Me.btnT4Cancel = New System.Windows.Forms.Button()
        Me.dgvOnSaveExec = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTL4 = New System.Windows.Forms.TextBox()
        Me.paneT5 = New System.Windows.Forms.Panel()
        Me.btnT5OK = New System.Windows.Forms.Button()
        Me.btnT5Cancel = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage41 = New System.Windows.Forms.TabPage()
        Me.dgvOnSaveNextStop = New System.Windows.Forms.DataGridView()
        Me.cIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMSG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage42 = New System.Windows.Forms.TabPage()
        Me.dgvOnSaveNextNote = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage43 = New System.Windows.Forms.TabPage()
        Me.dgvOnSaveNextSimpleMSG = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage44 = New System.Windows.Forms.TabPage()
        Me.dgvOnSaveNextMSG = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage45 = New System.Windows.Forms.TabPage()
        Me.dgvOnSaveNextClose = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage46 = New System.Windows.Forms.TabPage()
        Me.dgvOnSaveNextFocusOn = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage47 = New System.Windows.Forms.TabPage()
        Me.dgvOnSaveNextDelete = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage48 = New System.Windows.Forms.TabPage()
        Me.lbOnSaveNextExec = New System.Windows.Forms.ListBox()
        Me.dgvOnSaveNextExec = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbOnSaveNextDontClose = New System.Windows.Forms.CheckBox()
        Me.txtTL5 = New System.Windows.Forms.TextBox()
        Me.paneT6 = New System.Windows.Forms.Panel()
        Me.btnT6OK = New System.Windows.Forms.Button()
        Me.btnT6Cancel = New System.Windows.Forms.Button()
        Me.dgvOnExitMSG = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTL6 = New System.Windows.Forms.TextBox()
        Me.paneT7 = New System.Windows.Forms.Panel()
        Me.btnT7OK = New System.Windows.Forms.Button()
        Me.btnT7Cancel = New System.Windows.Forms.Button()
        Me.tbNFS = New System.Windows.Forms.TrackBar()
        Me.txtSY = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSX = New System.Windows.Forms.TextBox()
        Me.lblNoteDefaultText = New System.Windows.Forms.Label()
        Me.Mkc_ColorCombobox5T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox6T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbNoteBC = New System.Windows.Forms.CheckBox()
        Me.cbNoteFC = New System.Windows.Forms.CheckBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.cbNoteS = New System.Windows.Forms.CheckBox()
        Me.txtNY = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNX = New System.Windows.Forms.TextBox()
        Me.txtTL7 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelCOLUMN = New System.Windows.Forms.TableLayoutPanel()
        Me.paneAC = New System.Windows.Forms.Panel()
        Me.cbPKAC = New System.Windows.Forms.CheckBox()
        Me.txtvdoAC = New DateTimePicker2()
        Me.txtvodAC = New DateTimePicker2()
        Me.txtlbl12AC = New System.Windows.Forms.TextBox()
        Me.txtLabelAC = New System.Windows.Forms.TextBox()
        Me.btnACCancel = New System.Windows.Forms.Button()
        Me.btnACOK = New System.Windows.Forms.Button()
        Me.lblDescriptionAC = New System.Windows.Forms.Label()
        Me.txtLenAC = New System.Windows.Forms.TextBox()
        Me.lblLntAC = New System.Windows.Forms.Label()
        Me.lblTypeAC = New System.Windows.Forms.Label()
        Me.cboTypeAC = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gbOptionsAC = New System.Windows.Forms.GroupBox()
        Me.txtTotalAC = New System.Windows.Forms.TextBox()
        Me.PanelAAT = New System.Windows.Forms.Panel()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.txtColumnsStartFrom = New System.Windows.Forms.TextBox()
        Me.txtRowsStartFrom = New System.Windows.Forms.TextBox()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.Mkc_tbc = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_tfc = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbPFC = New System.Windows.Forms.CheckBox()
        Me.gbApp = New System.Windows.Forms.TabControl()
        Me.TabPageRa = New System.Windows.Forms.TabPage()
        Me.r110 = New System.Windows.Forms.ComboBox()
        Me.dgvAppR = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn58 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r120 = New System.Windows.Forms.CheckBox()
        Me.btnAppR = New System.Windows.Forms.Button()
        Me.r6 = New System.Windows.Forms.CheckBox()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.r11 = New System.Windows.Forms.TextBox()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.r12 = New System.Windows.Forms.TextBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.r10 = New System.Windows.Forms.TextBox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.r9 = New System.Windows.Forms.TextBox()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.r8 = New System.Windows.Forms.TextBox()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.r7 = New System.Windows.Forms.TextBox()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.r5 = New System.Windows.Forms.ComboBox()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.r4 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.r3 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.r2 = New System.Windows.Forms.ComboBox()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.r0 = New System.Windows.Forms.TextBox()
        Me.r1 = New System.Windows.Forms.ComboBox()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.TabPageCa = New System.Windows.Forms.TabPage()
        Me.c110 = New System.Windows.Forms.ComboBox()
        Me.dgvAppC = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c120 = New System.Windows.Forms.CheckBox()
        Me.btnAppC = New System.Windows.Forms.Button()
        Me.c6 = New System.Windows.Forms.CheckBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.c11 = New System.Windows.Forms.TextBox()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.c12 = New System.Windows.Forms.TextBox()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.c10 = New System.Windows.Forms.TextBox()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.c9 = New System.Windows.Forms.TextBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.c8 = New System.Windows.Forms.TextBox()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.c7 = New System.Windows.Forms.TextBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.c5 = New System.Windows.Forms.ComboBox()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.c4 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.c3 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.c2 = New System.Windows.Forms.ComboBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.c0 = New System.Windows.Forms.TextBox()
        Me.c1 = New System.Windows.Forms.ComboBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.txtNLR = New System.Windows.Forms.TextBox()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.txtColLen = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.txtNLC = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.cbTabDownLeft = New System.Windows.Forms.CheckBox()
        Me.txtAT2 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtRNAC = New System.Windows.Forms.TextBox()
        Me.txtTNAC = New System.Windows.Forms.TextBox()
        Me.txtCNAC = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.chbColumnsStartFrom = New System.Windows.Forms.CheckBox()
        Me.chbRowsStartFrom = New System.Windows.Forms.CheckBox()
        Me.cbTc6 = New System.Windows.Forms.CheckBox()
        Me.cbTc5 = New System.Windows.Forms.CheckBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.cbTableAC = New System.Windows.Forms.CheckBox()
        Me.lblNumber1AC = New System.Windows.Forms.Label()
        Me.txtNameAC = New System.Windows.Forms.TextBox()
        Me.txtCLAC = New System.Windows.Forms.TextBox()
        Me.gbUC = New System.Windows.Forms.GroupBox()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.cbAddG = New System.Windows.Forms.CheckBox()
        Me.cbAddM = New System.Windows.Forms.CheckBox()
        Me.btnUC = New System.Windows.Forms.Button()
        Me.cbAddMB = New System.Windows.Forms.CheckBox()
        Me.cbAddE = New System.Windows.Forms.CheckBox()
        Me.cbAddY = New System.Windows.Forms.CheckBox()
        Me.cbAddMo = New System.Windows.Forms.CheckBox()
        Me.cbAddUC = New System.Windows.Forms.CheckBox()
        Me.paneP0 = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.chbFilterLK = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.ComboBox()
        Me.btnP0OK = New System.Windows.Forms.Button()
        Me.btnP0Cancel = New System.Windows.Forms.Button()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.CboRelTable = New System.Windows.Forms.ComboBox()
        Me.CboRelCol = New System.Windows.Forms.ComboBox()
        Me.cboRelDB = New System.Windows.Forms.ComboBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtvdo = New DateTimePicker2()
        Me.txtvod = New DateTimePicker2()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtLenght = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtDV = New System.Windows.Forms.TextBox()
        Me.chbPK = New System.Windows.Forms.CheckBox()
        Me.txtL0 = New System.Windows.Forms.TextBox()
        Me.paneP1 = New System.Windows.Forms.Panel()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.btnP1OK = New System.Windows.Forms.Button()
        Me.btnP1Cancel = New System.Windows.Forms.Button()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.txtCBGroup = New System.Windows.Forms.TextBox()
        Me.TabControlDGV = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cboGS = New System.Windows.Forms.ComboBox()
        Me.txtGSW = New System.Windows.Forms.TextBox()
        Me.txtGTitle = New System.Windows.Forms.TextBox()
        Me.txtGFS = New System.Windows.Forms.TextBox()
        Me.txtGWidth = New System.Windows.Forms.TextBox()
        Me.txtGLocationX = New System.Windows.Forms.TextBox()
        Me.txtGHeight = New System.Windows.Forms.TextBox()
        Me.txtGLocationY = New System.Windows.Forms.TextBox()
        Me.lblGLocationX = New System.Windows.Forms.Label()
        Me.lblGLocationY = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtGColHHght = New System.Windows.Forms.TextBox()
        Me.txtGRHW = New System.Windows.Forms.TextBox()
        Me.txtGHRFS = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgvGridStop = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtGridEditText = New System.Windows.Forms.TextBox()
        Me.txtGridOpenText = New System.Windows.Forms.TextBox()
        Me.txtGridDeleteText = New System.Windows.Forms.TextBox()
        Me.txtGridDeleteWidth = New System.Windows.Forms.TextBox()
        Me.txtGridOpenWidth = New System.Windows.Forms.TextBox()
        Me.txtGridEditWidth = New System.Windows.Forms.TextBox()
        Me.cboGOpen = New System.Windows.Forms.ComboBox()
        Me.chbGEdit = New System.Windows.Forms.CheckBox()
        Me.chbGridOpen = New System.Windows.Forms.CheckBox()
        Me.chbGridDelete = New System.Windows.Forms.CheckBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.dgvGridColumn = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.dgvGridAddCol = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtExpression = New System.Windows.Forms.TextBox()
        Me.txtL6 = New System.Windows.Forms.TextBox()
        Me.gbCBO = New System.Windows.Forms.GroupBox()
        Me.lDM = New System.Windows.Forms.Label()
        Me.lVM = New System.Windows.Forms.Label()
        Me.lF = New System.Windows.Forms.Label()
        Me.txtfDM = New System.Windows.Forms.TextBox()
        Me.txtfVM = New System.Windows.Forms.TextBox()
        Me.txtfF = New System.Windows.Forms.TextBox()
        Me.lDS = New System.Windows.Forms.Label()
        Me.cbCWO = New System.Windows.Forms.CheckBox()
        Me.txtfDS = New System.Windows.Forms.TextBox()
        Me.cbHRB = New System.Windows.Forms.CheckBox()
        Me.cbVRB = New System.Windows.Forms.CheckBox()
        Me.cbLL = New System.Windows.Forms.CheckBox()
        Me.cbDTP = New System.Windows.Forms.CheckBox()
        Me.cbDGV = New System.Windows.Forms.CheckBox()
        Me.cbRCHB = New System.Windows.Forms.CheckBox()
        Me.cbLCHB = New System.Windows.Forms.CheckBox()
        Me.cbCHB = New System.Windows.Forms.CheckBox()
        Me.cbAC = New System.Windows.Forms.CheckBox()
        Me.cbCB = New System.Windows.Forms.CheckBox()
        Me.cbB = New System.Windows.Forms.CheckBox()
        Me.cbTB = New System.Windows.Forms.CheckBox()
        Me.cbFP = New System.Windows.Forms.CheckBox()
        Me.dgvRB = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbAC = New System.Windows.Forms.GroupBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtACFilterStart = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtLett = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtACWidth = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtACHeight = New System.Windows.Forms.TextBox()
        Me.txtACFilterLen = New System.Windows.Forms.TextBox()
        Me.cbACLTL = New System.Windows.Forms.CheckBox()
        Me.txtACAsgnLen = New System.Windows.Forms.TextBox()
        Me.txtACFilterName = New System.Windows.Forms.TextBox()
        Me.txtACAsgnStart = New System.Windows.Forms.TextBox()
        Me.txtACAsgn = New System.Windows.Forms.TextBox()
        Me.txtACMinTL = New System.Windows.Forms.TextBox()
        Me.txtACLength = New System.Windows.Forms.TextBox()
        Me.txtACStart = New System.Windows.Forms.TextBox()
        Me.llACB = New System.Windows.Forms.LinkLabel()
        Me.txtACB = New System.Windows.Forms.TextBox()
        Me.paneP2 = New System.Windows.Forms.Panel()
        Me.btnP2Cancel = New System.Windows.Forms.Button()
        Me.btnP2OK = New System.Windows.Forms.Button()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.tbFSize = New System.Windows.Forms.TrackBar()
        Me.chbML = New System.Windows.Forms.CheckBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Mkc_ColorCombobox1 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox2 = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.chbBackColor = New System.Windows.Forms.CheckBox()
        Me.chbForeColor = New System.Windows.Forms.CheckBox()
        Me.chbOnlyTitle = New System.Windows.Forms.CheckBox()
        Me.txtL1 = New System.Windows.Forms.TextBox()
        Me.chbRAligment = New System.Windows.Forms.CheckBox()
        Me.chbFItalic = New System.Windows.Forms.CheckBox()
        Me.chbFBold = New System.Windows.Forms.CheckBox()
        Me.chbCAligment = New System.Windows.Forms.CheckBox()
        Me.chbFSize = New System.Windows.Forms.CheckBox()
        Me.paneP21 = New System.Windows.Forms.Panel()
        Me.btnP21OK = New System.Windows.Forms.Button()
        Me.btnP21Cancel = New System.Windows.Forms.Button()
        Me.txtL11 = New System.Windows.Forms.TextBox()
        Me.dgvHeaderSpec = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.dgvHeader = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paneP3 = New System.Windows.Forms.Panel()
        Me.chbTabIndex = New System.Windows.Forms.CheckBox()
        Me.chbBN = New System.Windows.Forms.CheckBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txtSPOrderColumn = New System.Windows.Forms.TextBox()
        Me.txtSPOrderRow = New System.Windows.Forms.TextBox()
        Me.btnP3OK = New System.Windows.Forms.Button()
        Me.btnP3Cancel = New System.Windows.Forms.Button()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.chbNQG = New System.Windows.Forms.CheckBox()
        Me.chbNTS = New System.Windows.Forms.CheckBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.txtSPOrderTable = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.txtVS = New System.Windows.Forms.TextBox()
        Me.txtON = New System.Windows.Forms.TextBox()
        Me.chbNewWebGroup = New System.Windows.Forms.CheckBox()
        Me.chbRight = New System.Windows.Forms.CheckBox()
        Me.chbCentar = New System.Windows.Forms.CheckBox()
        Me.Mkc_ColorComboboxBC = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorComboboxFC = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.chbBC = New System.Windows.Forms.CheckBox()
        Me.chbFC = New System.Windows.Forms.CheckBox()
        Me.chbVF = New System.Windows.Forms.CheckBox()
        Me.chbEF = New System.Windows.Forms.CheckBox()
        Me.chbBF = New System.Windows.Forms.CheckBox()
        Me.chbFB = New System.Windows.Forms.CheckBox()
        Me.chbItalic = New System.Windows.Forms.CheckBox()
        Me.chbFU = New System.Windows.Forms.CheckBox()
        Me.txtMultilineH = New System.Windows.Forms.TextBox()
        Me.chbMultiline = New System.Windows.Forms.CheckBox()
        Me.chbRO = New System.Windows.Forms.CheckBox()
        Me.txtL4 = New System.Windows.Forms.TextBox()
        Me.chbMultilineH = New System.Windows.Forms.CheckBox()
        Me.panePPreview = New System.Windows.Forms.Panel()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.PanelCPE = New System.Windows.Forms.Panel()
        Me.btnOKCPE = New System.Windows.Forms.Button()
        Me.btnCancelCPE = New System.Windows.Forms.Button()
        Me.dgvCPE = New System.Windows.Forms.DataGridView()
        Me.llPreviewC = New System.Windows.Forms.LinkLabel()
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.llC2 = New System.Windows.Forms.LinkLabel()
        Me.llC1 = New System.Windows.Forms.LinkLabel()
        Me.llC3 = New System.Windows.Forms.LinkLabel()
        Me.cboCPE = New System.Windows.Forms.ComboBox()
        Me.txtlblPPreview = New System.Windows.Forms.TextBox()
        Me.clbLang = New System.Windows.Forms.CheckedListBox()
        Me.btnAddLang = New System.Windows.Forms.Button()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.llC6 = New System.Windows.Forms.LinkLabel()
        Me.llC5 = New System.Windows.Forms.LinkLabel()
        Me.llC4 = New System.Windows.Forms.LinkLabel()
        Me.cbTableDescription = New System.Windows.Forms.CheckBox()
        Me.cbLabel = New System.Windows.Forms.CheckBox()
        Me.cbLabelVF = New System.Windows.Forms.CheckBox()
        Me.cbAwls = New System.Windows.Forms.CheckBox()
        Me.llCC7 = New System.Windows.Forms.LinkLabel()
        Me.cbMessage = New System.Windows.Forms.CheckBox()
        Me.llC8 = New System.Windows.Forms.LinkLabel()
        Me.llC9 = New System.Windows.Forms.LinkLabel()
        Me.cbQE = New System.Windows.Forms.CheckBox()
        Me.paneT8 = New System.Windows.Forms.Panel()
        Me.btnTSubmit = New System.Windows.Forms.Button()
        Me.btnTSubmitCancel = New System.Windows.Forms.Button()
        Me.txtTUpdate = New System.Windows.Forms.TextBox()
        Me.paneP6 = New System.Windows.Forms.Panel()
        Me.btnCSubmit = New System.Windows.Forms.Button()
        Me.btnCSubmitCancel = New System.Windows.Forms.Button()
        Me.txtCUpdate = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnu01 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DDFIND = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu02 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tDCI = New System.Windows.Forms.ToolStripMenuItem()
        Me.tDCDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tRenameC = New System.Windows.Forms.ToolStripMenuItem()
        Me.tFC = New System.Windows.Forms.ToolStripTextBox()
        Me.tssc11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssc1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssc12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tssc2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssc3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssc4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssc5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tssc6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.tRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnNumber = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.nhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.nunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.nsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.nmcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.nfind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.nequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.ndnequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.nfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.nunfilterall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.nfreeze = New System.Windows.Forms.ToolStripMenuItem()
        Me.nunfreezeall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.nafc = New System.Windows.Forms.ToolStripMenuItem()
        Me.nafw = New System.Windows.Forms.ToolStripMenuItem()
        Me.nafch = New System.Windows.Forms.ToolStripMenuItem()
        Me.nacrw = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.dhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.dsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.dmcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.DFIND2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.dequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.ddnequals = New System.Windows.Forms.ToolStripMenuItem()
        Me.dfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunfilterall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.dfreeze = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunfreezeall = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.DAFC2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAFW2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAFCh2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DACRW = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu03 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tdtI = New System.Windows.Forms.ToolStripMenuItem()
        Me.tdtDB = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tRenameT = New System.Windows.Forms.ToolStripMenuItem()
        Me.tFT = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsst1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsst2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsst3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsst4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsst5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsst6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsst7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsst8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsst9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ttRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit
        Me.mnu00.SuspendLayout
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.Panel1.SuspendLayout
        Me.SplitContainer1.Panel2.SuspendLayout
        Me.SplitContainer1.SuspendLayout
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer4.Panel1.SuspendLayout
        Me.SplitContainer4.Panel2.SuspendLayout
        Me.SplitContainer4.SuspendLayout
        Me.TableLayoutPanelTABLE.SuspendLayout
        Me.paneT2.SuspendLayout
        CType(Me.dgvDontOpen, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneAWL.SuspendLayout
        Me.paneT3.SuspendLayout
        Me.Panel2.SuspendLayout
        CType(Me.dgvOnButtonClickStop, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbBFS, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneAT.SuspendLayout
        Me.gbCopy.SuspendLayout
        CType(Me.tbSAT, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbHAT, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneT0.SuspendLayout
        Me.GB.SuspendLayout
        Me.paneT1.SuspendLayout
        CType(Me.tbFS, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.tbH, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneT4.SuspendLayout
        CType(Me.dgvOnSaveExec, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneT5.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage41.SuspendLayout
        CType(Me.dgvOnSaveNextStop, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage42.SuspendLayout
        CType(Me.dgvOnSaveNextNote, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage43.SuspendLayout
        CType(Me.dgvOnSaveNextSimpleMSG, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage44.SuspendLayout
        CType(Me.dgvOnSaveNextMSG, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage45.SuspendLayout
        CType(Me.dgvOnSaveNextClose, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage46.SuspendLayout
        CType(Me.dgvOnSaveNextFocusOn, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage47.SuspendLayout
        CType(Me.dgvOnSaveNextDelete, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage48.SuspendLayout
        CType(Me.dgvOnSaveNextExec, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneT6.SuspendLayout
        CType(Me.dgvOnExitMSG, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneT7.SuspendLayout
        CType(Me.tbNFS, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TableLayoutPanelCOLUMN.SuspendLayout
        Me.paneAC.SuspendLayout
        Me.gbOptionsAC.SuspendLayout
        Me.PanelAAT.SuspendLayout
        Me.gbApp.SuspendLayout
        Me.TabPageRa.SuspendLayout
        CType(Me.dgvAppR, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPageCa.SuspendLayout
        CType(Me.dgvAppC, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbUC.SuspendLayout
        Me.paneP0.SuspendLayout
        Me.paneP1.SuspendLayout
        Me.TabControlDGV.SuspendLayout
        Me.TabPage4.SuspendLayout
        Me.TabPage5.SuspendLayout
        Me.TabPage6.SuspendLayout
        CType(Me.dgvGridStop, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage7.SuspendLayout
        Me.TabPage8.SuspendLayout
        CType(Me.dgvGridColumn, System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage9.SuspendLayout
        CType(Me.dgvGridAddCol, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbCBO.SuspendLayout
        CType(Me.dgvRB, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbAC.SuspendLayout
        Me.paneP2.SuspendLayout
        CType(Me.tbFSize, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneP21.SuspendLayout
        CType(Me.dgvHeaderSpec, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneP3.SuspendLayout
        Me.panePPreview.SuspendLayout
        Me.PanelCPE.SuspendLayout
        CType(Me.dgvCPE, System.ComponentModel.ISupportInitialize).BeginInit
        Me.paneT8.SuspendLayout
        Me.paneP6.SuspendLayout
        Me.mnu01.SuspendLayout
        Me.mnu02.SuspendLayout
        Me.mnuColumnNumber.SuspendLayout
        Me.mnuColumnText.SuspendLayout
        Me.mnu03.SuspendLayout
        Me.PanelTop.SuspendLayout
        Me.SuspendLayout
        '
        'mnu00
        '
        Me.mnu00.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu00.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnu00.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.castI, Me.castD182, Me.castC, Me.castC50, Me.ToolStripSeparator1, Me.isnullP, Me.isnullP0, Me.ToolStripSeparator2, Me.dfind, Me.ToolStripSeparator19, Me.dafc, Me.dafw, Me.dafch})
        Me.mnu00.Name = "mnuColumn"
        Me.mnu00.ShowCheckMargin = True
        Me.mnu00.Size = New System.Drawing.Size(240, 242)
        '
        'castI
        '
        Me.castI.Name = "castI"
        Me.castI.Size = New System.Drawing.Size(239, 22)
        Me.castI.Text = "cast as integer"
        '
        'castD182
        '
        Me.castD182.Name = "castD182"
        Me.castD182.Size = New System.Drawing.Size(239, 22)
        Me.castD182.Text = "cast as decimal(18,2)"
        '
        'castC
        '
        Me.castC.Name = "castC"
        Me.castC.Size = New System.Drawing.Size(239, 22)
        Me.castC.Text = "cast as char"
        '
        'castC50
        '
        Me.castC50.Name = "castC50"
        Me.castC50.Size = New System.Drawing.Size(239, 22)
        Me.castC50.Text = "cast as char(50)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(236, 6)
        '
        'isnullP
        '
        Me.isnullP.Name = "isnullP"
        Me.isnullP.Size = New System.Drawing.Size(239, 22)
        Me.isnullP.Text = "isnull (value,'')"
        '
        'isnullP0
        '
        Me.isnullP0.Name = "isnullP0"
        Me.isnullP0.Size = New System.Drawing.Size(239, 22)
        Me.isnullP0.Text = "isnull (value,0)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(236, 6)
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
        'dafch
        '
        Me.dafch.Name = "dafch"
        Me.dafch.Size = New System.Drawing.Size(239, 22)
        Me.dafch.Text = "AutoFit to column header"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ControlLightLight
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanelTABLE)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanelCOLUMN)
        Me.SplitContainer1.Panel2.Controls.Add(Me.paneT8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.paneP6)
        Me.SplitContainer1.Size = New System.Drawing.Size(1370, 604)
        Me.SplitContainer1.SplitterDistance = 249
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
        Me.SplitContainer4.Size = New System.Drawing.Size(249, 604)
        Me.SplitContainer4.SplitterDistance = 372
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
        Me.cboIST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboIST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIST.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cboIST.DropDownWidth = 750
        Me.cboIST.FormattingEnabled = True
        Me.cboIST.Location = New System.Drawing.Point(0, 351)
        Me.cboIST.Name = "cboIST"
        Me.cboIST.Size = New System.Drawing.Size(249, 21)
        Me.cboIST.TabIndex = 0
        '
        'tv
        '
        Me.tv.BackColor = System.Drawing.SystemColors.Menu
        Me.tv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv.Location = New System.Drawing.Point(0, 0)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(249, 228)
        Me.tv.TabIndex = 0
        '
        'TableLayoutPanelTABLE
        '
        Me.TableLayoutPanelTABLE.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanelTABLE.ColumnCount = 1
        Me.TableLayoutPanelTABLE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT2, 0, 3)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT3, 0, 4)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneAT, 0, 0)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT0, 0, 1)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT1, 0, 2)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT4, 0, 5)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT5, 0, 6)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT6, 0, 7)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.paneT7, 0, 8)
        Me.TableLayoutPanelTABLE.Location = New System.Drawing.Point(3, 0)
        Me.TableLayoutPanelTABLE.Name = "TableLayoutPanelTABLE"
        Me.TableLayoutPanelTABLE.RowCount = 11
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanelTABLE.Size = New System.Drawing.Size(540, 518)
        Me.TableLayoutPanelTABLE.TabIndex = 0
        Me.TableLayoutPanelTABLE.Visible = False
        '
        'paneT2
        '
        Me.paneT2.AccessibleName = "parentAtributes"
        Me.paneT2.Controls.Add(Me.cboBGCATe)
        Me.paneT2.Controls.Add(Me.cbTc3)
        Me.paneT2.Controls.Add(Me.btnT2Cancel)
        Me.paneT2.Controls.Add(Me.btnT2OK)
        Me.paneT2.Controls.Add(Me.dgvDontOpen)
        Me.paneT2.Controls.Add(Me.cbPKD)
        Me.paneT2.Controls.Add(Me.paneAWL)
        Me.paneT2.Controls.Add(Me.cbDontOpen)
        Me.paneT2.Controls.Add(Me.Label10)
        Me.paneT2.Controls.Add(Me.cbAVL)
        Me.paneT2.Controls.Add(Me.Label9)
        Me.paneT2.Controls.Add(Me.Label8)
        Me.paneT2.Controls.Add(Me.cbT1HSVF)
        Me.paneT2.Controls.Add(Me.txtDT)
        Me.paneT2.Controls.Add(Me.cbT1VSVF)
        Me.paneT2.Controls.Add(Me.cbPKLeave)
        Me.paneT2.Controls.Add(Me.cbDNTRM)
        Me.paneT2.Controls.Add(Me.cbT1DisableMouse)
        Me.paneT2.Controls.Add(Me.cbSupportEU)
        Me.paneT2.Controls.Add(Me.cbMixmode)
        Me.paneT2.Controls.Add(Me.cbLCcbVF)
        Me.paneT2.Controls.Add(Me.cbSVF)
        Me.paneT2.Controls.Add(Me.cbLKVF)
        Me.paneT2.Controls.Add(Me.Label2)
        Me.paneT2.Controls.Add(Me.cbCATI)
        Me.paneT2.Controls.Add(Me.cbT1Web)
        Me.paneT2.Controls.Add(Me.cbK)
        Me.paneT2.Controls.Add(Me.cbA)
        Me.paneT2.Controls.Add(Me.txtTL2)
        Me.paneT2.Controls.Add(Me.cbX)
        Me.paneT2.Controls.Add(Me.cbSendEmail)
        Me.paneT2.Controls.Add(Me.cbAdvancedSearch)
        Me.paneT2.Controls.Add(Me.cbMax)
        Me.paneT2.Cursor = System.Windows.Forms.Cursors.Default
        Me.paneT2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.paneT2.Location = New System.Drawing.Point(3, 163)
        Me.paneT2.Name = "paneT2"
        Me.paneT2.Size = New System.Drawing.Size(534, 50)
        Me.paneT2.TabIndex = 114
        Me.paneT2.Tag = "680"
        '
        'cboBGCATe
        '
        Me.cboBGCATe.AccessibleName = ""
        Me.cboBGCATe.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.cboBGCATe.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.cboBGCATe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBGCATe.Location = New System.Drawing.Point(138, 286)
        Me.cboBGCATe.Name = "cboBGCATe"
        Me.cboBGCATe.SelectedColor = System.Drawing.Color.Empty
        Me.cboBGCATe.Size = New System.Drawing.Size(250, 30)
        Me.cboBGCATe.TabIndex = 269
        Me.cboBGCATe.Tag = "VF"
        Me.cboBGCATe.Visible = False
        '
        'cbTc3
        '
        Me.cbTc3.AutoSize = True
        Me.cbTc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTc3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTc3.Location = New System.Drawing.Point(3, 285)
        Me.cbTc3.Name = "cbTc3"
        Me.cbTc3.Size = New System.Drawing.Size(123, 17)
        Me.cbTc3.TabIndex = 151
        Me.cbTc3.Text = "Background color"
        '
        'btnT2Cancel
        '
        Me.btnT2Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT2Cancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnT2Cancel.Location = New System.Drawing.Point(145, 646)
        Me.btnT2Cancel.Name = "btnT2Cancel"
        Me.btnT2Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT2Cancel.TabIndex = 167
        Me.btnT2Cancel.Tag = "2"
        Me.btnT2Cancel.Text = "Cancel"
        Me.btnT2Cancel.UseVisualStyleBackColor = True
        '
        'btnT2OK
        '
        Me.btnT2OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT2OK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnT2OK.Location = New System.Drawing.Point(10, 646)
        Me.btnT2OK.Name = "btnT2OK"
        Me.btnT2OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT2OK.TabIndex = 166
        Me.btnT2OK.Tag = "2"
        Me.btnT2OK.Text = "OK"
        Me.btnT2OK.UseVisualStyleBackColor = True
        '
        'dgvDontOpen
        '
        Me.dgvDontOpen.AllowDrop = True
        Me.dgvDontOpen.AllowUserToOrderColumns = True
        Me.dgvDontOpen.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvDontOpen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDontOpen.ColumnHeadersHeight = 30
        Me.dgvDontOpen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDontOpen.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDontOpen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvDontOpen.GridColor = System.Drawing.SystemColors.Control
        Me.dgvDontOpen.Location = New System.Drawing.Point(0, 546)
        Me.dgvDontOpen.MultiSelect = False
        Me.dgvDontOpen.Name = "dgvDontOpen"
        Me.dgvDontOpen.RowHeadersWidth = 33
        Me.dgvDontOpen.RowTemplate.Height = 30
        Me.dgvDontOpen.Size = New System.Drawing.Size(1007, 97)
        Me.dgvDontOpen.TabIndex = 165
        Me.dgvDontOpen.Tag = "14"
        Me.dgvDontOpen.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "Dont open form if"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 300
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 300
        '
        'cbPKD
        '
        Me.cbPKD.AccessibleName = "primarykeyDisabled=true"
        Me.cbPKD.AutoSize = True
        Me.cbPKD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPKD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPKD.Location = New System.Drawing.Point(3, 209)
        Me.cbPKD.Name = "cbPKD"
        Me.cbPKD.Size = New System.Drawing.Size(157, 17)
        Me.cbPKD.TabIndex = 134
        Me.cbPKD.Text = "Primary key is disabled"
        '
        'paneAWL
        '
        Me.paneAWL.Controls.Add(Me.Label92)
        Me.paneAWL.Controls.Add(Me.Mkc_ColorCombobox8T)
        Me.paneAWL.Controls.Add(Me.txtYH)
        Me.paneAWL.Controls.Add(Me.Label86)
        Me.paneAWL.Controls.Add(Me.Label87)
        Me.paneAWL.Controls.Add(Me.txtXW)
        Me.paneAWL.Controls.Add(Me.txtY)
        Me.paneAWL.Controls.Add(Me.Mkc_ColorCombobox7T)
        Me.paneAWL.Controls.Add(Me.cbAWLBC)
        Me.paneAWL.Controls.Add(Me.Label11)
        Me.paneAWL.Controls.Add(Me.cbAWLFC)
        Me.paneAWL.Controls.Add(Me.cbInline)
        Me.paneAWL.Controls.Add(Me.cbNotMovable)
        Me.paneAWL.Controls.Add(Me.lblY)
        Me.paneAWL.Controls.Add(Me.lblDT)
        Me.paneAWL.Controls.Add(Me.lblX)
        Me.paneAWL.Controls.Add(Me.txtX)
        Me.paneAWL.Location = New System.Drawing.Point(407, 72)
        Me.paneAWL.Name = "paneAWL"
        Me.paneAWL.Size = New System.Drawing.Size(446, 272)
        Me.paneAWL.TabIndex = 144
        Me.paneAWL.Visible = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(10, 67)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(31, 13)
        Me.Label92.TabIndex = 156
        Me.Label92.Text = "Size"
        '
        'Mkc_ColorCombobox8T
        '
        Me.Mkc_ColorCombobox8T.AccessibleName = "backColorxxx"
        Me.Mkc_ColorCombobox8T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox8T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox8T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox8T.Location = New System.Drawing.Point(131, 233)
        Me.Mkc_ColorCombobox8T.Name = "Mkc_ColorCombobox8T"
        Me.Mkc_ColorCombobox8T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox8T.Size = New System.Drawing.Size(255, 31)
        Me.Mkc_ColorCombobox8T.TabIndex = 150
        Me.Mkc_ColorCombobox8T.Tag = "VF"
        Me.Mkc_ColorCombobox8T.Visible = False
        '
        'txtYH
        '
        Me.txtYH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYH.Location = New System.Drawing.Point(136, 110)
        Me.txtYH.Name = "txtYH"
        Me.txtYH.Size = New System.Drawing.Size(75, 21)
        Me.txtYH.TabIndex = 153
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(63, 115)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(43, 13)
        Me.Label86.TabIndex = 155
        Me.Label86.Text = "Height"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(63, 88)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(39, 13)
        Me.Label87.TabIndex = 154
        Me.Label87.Text = "Width"
        '
        'txtXW
        '
        Me.txtXW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXW.Location = New System.Drawing.Point(136, 84)
        Me.txtXW.Name = "txtXW"
        Me.txtXW.Size = New System.Drawing.Size(75, 21)
        Me.txtXW.TabIndex = 152
        '
        'txtY
        '
        Me.txtY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtY.Location = New System.Drawing.Point(136, 40)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(75, 21)
        Me.txtY.TabIndex = 111
        '
        'Mkc_ColorCombobox7T
        '
        Me.Mkc_ColorCombobox7T.AccessibleName = "foreColorxxx"
        Me.Mkc_ColorCombobox7T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox7T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox7T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox7T.Location = New System.Drawing.Point(131, 205)
        Me.Mkc_ColorCombobox7T.Name = "Mkc_ColorCombobox7T"
        Me.Mkc_ColorCombobox7T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox7T.Size = New System.Drawing.Size(255, 31)
        Me.Mkc_ColorCombobox7T.TabIndex = 149
        Me.Mkc_ColorCombobox7T.Tag = "VF"
        Me.Mkc_ColorCombobox7T.Visible = False
        '
        'cbAWLBC
        '
        Me.cbAWLBC.AutoSize = True
        Me.cbAWLBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAWLBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAWLBC.Location = New System.Drawing.Point(3, 233)
        Me.cbAWLBC.Name = "cbAWLBC"
        Me.cbAWLBC.Size = New System.Drawing.Size(83, 17)
        Me.cbAWLBC.TabIndex = 148
        Me.cbAWLBC.Text = "Back color"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 143
        Me.Label11.Text = "Location"
        '
        'cbAWLFC
        '
        Me.cbAWLFC.AutoSize = True
        Me.cbAWLFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAWLFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAWLFC.Location = New System.Drawing.Point(3, 205)
        Me.cbAWLFC.Name = "cbAWLFC"
        Me.cbAWLFC.Size = New System.Drawing.Size(80, 17)
        Me.cbAWLFC.TabIndex = 147
        Me.cbAWLFC.Text = "Fore color"
        '
        'cbInline
        '
        Me.cbInline.AccessibleName = ""
        Me.cbInline.AutoSize = True
        Me.cbInline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbInline.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbInline.Location = New System.Drawing.Point(3, 177)
        Me.cbInline.Name = "cbInline"
        Me.cbInline.Size = New System.Drawing.Size(110, 17)
        Me.cbInline.TabIndex = 129
        Me.cbInline.Text = "Inline with field"
        '
        'cbNotMovable
        '
        Me.cbNotMovable.AccessibleName = "AVLnotMovable"
        Me.cbNotMovable.AutoSize = True
        Me.cbNotMovable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNotMovable.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNotMovable.Location = New System.Drawing.Point(3, 151)
        Me.cbNotMovable.Name = "cbNotMovable"
        Me.cbNotMovable.Size = New System.Drawing.Size(95, 17)
        Me.cbNotMovable.TabIndex = 128
        Me.cbNotMovable.Text = "Not movable"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(107, 46)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(14, 13)
        Me.lblY.TabIndex = 114
        Me.lblY.Text = "Y"
        '
        'lblDT
        '
        Me.lblDT.AutoSize = True
        Me.lblDT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDT.Location = New System.Drawing.Point(302, 5)
        Me.lblDT.Name = "lblDT"
        Me.lblDT.Size = New System.Drawing.Size(74, 13)
        Me.lblDT.TabIndex = 115
        Me.lblDT.Text = "Default text"
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(106, 19)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(15, 13)
        Me.lblX.TabIndex = 113
        Me.lblX.Text = "X"
        '
        'txtX
        '
        Me.txtX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtX.Location = New System.Drawing.Point(136, 14)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(75, 21)
        Me.txtX.TabIndex = 110
        '
        'cbDontOpen
        '
        Me.cbDontOpen.AccessibleName = "ButtonSaveVisibleFalse"
        Me.cbDontOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDontOpen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDontOpen.Location = New System.Drawing.Point(10, 513)
        Me.cbDontOpen.Name = "cbDontOpen"
        Me.cbDontOpen.Size = New System.Drawing.Size(358, 26)
        Me.cbDontOpen.TabIndex = 146
        Me.cbDontOpen.Text = "Don't open form for this table if"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(401, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 13)
        Me.Label10.TabIndex = 142
        Me.Label10.Text = "Always visible label:"
        '
        'cbAVL
        '
        Me.cbAVL.AccessibleName = ""
        Me.cbAVL.AutoSize = True
        Me.cbAVL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAVL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAVL.Location = New System.Drawing.Point(407, 50)
        Me.cbAVL.Name = "cbAVL"
        Me.cbAVL.Size = New System.Drawing.Size(162, 17)
        Me.cbAVL.TabIndex = 107
        Me.cbAVL.Text = "With always visible label"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(686, 515)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 15)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "**LC is batch logical control"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(10, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 13)
        Me.Label8.TabIndex = 140
        Me.Label8.Text = "Visible FALSE for:"
        '
        'cbT1HSVF
        '
        Me.cbT1HSVF.AccessibleName = "HorizontalScrollVisibleFalse"
        Me.cbT1HSVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT1HSVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT1HSVF.Location = New System.Drawing.Point(202, 433)
        Me.cbT1HSVF.Name = "cbT1HSVF"
        Me.cbT1HSVF.Size = New System.Drawing.Size(218, 26)
        Me.cbT1HSVF.TabIndex = 139
        Me.cbT1HSVF.Text = "Horizontal scroll"
        '
        'txtDT
        '
        Me.txtDT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDT.Location = New System.Drawing.Point(856, 72)
        Me.txtDT.Multiline = True
        Me.txtDT.Name = "txtDT"
        Me.txtDT.Size = New System.Drawing.Size(716, 252)
        Me.txtDT.TabIndex = 112
        Me.txtDT.Visible = False
        '
        'cbT1VSVF
        '
        Me.cbT1VSVF.AccessibleName = "VerticalScrollVisibleFalse"
        Me.cbT1VSVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT1VSVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT1VSVF.Location = New System.Drawing.Point(10, 433)
        Me.cbT1VSVF.Name = "cbT1VSVF"
        Me.cbT1VSVF.Size = New System.Drawing.Size(182, 26)
        Me.cbT1VSVF.TabIndex = 138
        Me.cbT1VSVF.Text = "Vertical scroll "
        '
        'cbPKLeave
        '
        Me.cbPKLeave.AccessibleName = "onLeavePKKeepData"
        Me.cbPKLeave.AutoSize = True
        Me.cbPKLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPKLeave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPKLeave.Location = New System.Drawing.Point(3, 182)
        Me.cbPKLeave.Name = "cbPKLeave"
        Me.cbPKLeave.Size = New System.Drawing.Size(280, 17)
        Me.cbPKLeave.TabIndex = 137
        Me.cbPKLeave.Text = "When leave primary key keeps data on form"
        '
        'cbDNTRM
        '
        Me.cbDNTRM.AccessibleName = "DontResize"
        Me.cbDNTRM.AutoSize = True
        Me.cbDNTRM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDNTRM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDNTRM.Location = New System.Drawing.Point(3, 132)
        Me.cbDNTRM.Name = "cbDNTRM"
        Me.cbDNTRM.Size = New System.Drawing.Size(189, 17)
        Me.cbDNTRM.TabIndex = 136
        Me.cbDNTRM.Text = "Don't resize controls on form"
        '
        'cbT1DisableMouse
        '
        Me.cbT1DisableMouse.AccessibleName = "DisableMouse"
        Me.cbT1DisableMouse.AutoSize = True
        Me.cbT1DisableMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT1DisableMouse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT1DisableMouse.Location = New System.Drawing.Point(3, 107)
        Me.cbT1DisableMouse.Name = "cbT1DisableMouse"
        Me.cbT1DisableMouse.Size = New System.Drawing.Size(107, 17)
        Me.cbT1DisableMouse.TabIndex = 135
        Me.cbT1DisableMouse.Text = "Disable mouse"
        '
        'cbSupportEU
        '
        Me.cbSupportEU.AccessibleName = "supportEU"
        Me.cbSupportEU.AutoSize = True
        Me.cbSupportEU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSupportEU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSupportEU.Location = New System.Drawing.Point(3, 81)
        Me.cbSupportEU.Name = "cbSupportEU"
        Me.cbSupportEU.Size = New System.Drawing.Size(164, 17)
        Me.cbSupportEU.TabIndex = 134
        Me.cbSupportEU.Text = "Add suported by EU logo"
        '
        'cbMixmode
        '
        Me.cbMixmode.AccessibleName = "MIXMODE"
        Me.cbMixmode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMixmode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMixmode.Location = New System.Drawing.Point(637, 433)
        Me.cbMixmode.Name = "cbMixmode"
        Me.cbMixmode.Size = New System.Drawing.Size(418, 26)
        Me.cbMixmode.TabIndex = 133
        Me.cbMixmode.Text = "Add table for MIXMODE mode"
        '
        'cbLCcbVF
        '
        Me.cbLCcbVF.AccessibleName = "GBLKVISIBLEFALSE"
        Me.cbLCcbVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLCcbVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLCcbVF.Location = New System.Drawing.Point(10, 454)
        Me.cbLCcbVF.Name = "cbLCcbVF"
        Me.cbLCcbVF.Size = New System.Drawing.Size(378, 26)
        Me.cbLCcbVF.TabIndex = 132
        Me.cbLCcbVF.Text = "Logical control check boxes"
        '
        'cbSVF
        '
        Me.cbSVF.AccessibleName = "ButtonSaveVisibleFalse"
        Me.cbSVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSVF.Location = New System.Drawing.Point(202, 409)
        Me.cbSVF.Name = "cbSVF"
        Me.cbSVF.Size = New System.Drawing.Size(189, 26)
        Me.cbSVF.TabIndex = 131
        Me.cbSVF.Text = "SAVE button"
        '
        'cbLKVF
        '
        Me.cbLKVF.AccessibleName = "ButtonLKVisibleFalse"
        Me.cbLKVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLKVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLKVF.Location = New System.Drawing.Point(10, 409)
        Me.cbLKVF.Name = "cbLKVF"
        Me.cbLKVF.Size = New System.Drawing.Size(182, 26)
        Me.cbLKVF.TabIndex = 130
        Me.cbLKVF.Text = "**LC button"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(630, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 13)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Also valid for the corresponding child tables:"
        '
        'cbCATI
        '
        Me.cbCATI.AccessibleName = "CATI"
        Me.cbCATI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCATI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCATI.Location = New System.Drawing.Point(637, 409)
        Me.cbCATI.Name = "cbCATI"
        Me.cbCATI.Size = New System.Drawing.Size(432, 26)
        Me.cbCATI.TabIndex = 125
        Me.cbCATI.Text = "Add table for CATI mode"
        '
        'cbT1Web
        '
        Me.cbT1Web.AccessibleName = "web"
        Me.cbT1Web.AutoSize = True
        Me.cbT1Web.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT1Web.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT1Web.Location = New System.Drawing.Point(3, 260)
        Me.cbT1Web.Name = "cbT1Web"
        Me.cbT1Web.Size = New System.Drawing.Size(211, 17)
        Me.cbT1Web.TabIndex = 124
        Me.cbT1Web.Text = "Generate web page for this table"
        '
        'cbK
        '
        Me.cbK.AccessibleName = "K"
        Me.cbK.AutoSize = True
        Me.cbK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbK.Location = New System.Drawing.Point(3, 157)
        Me.cbK.Name = "cbK"
        Me.cbK.Size = New System.Drawing.Size(195, 17)
        Me.cbK.TabIndex = 116
        Me.cbK.Text = "Primary key can be with error"
        '
        'cbA
        '
        Me.cbA.AccessibleName = "A"
        Me.cbA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbA.Location = New System.Drawing.Point(637, 474)
        Me.cbA.Name = "cbA"
        Me.cbA.Size = New System.Drawing.Size(418, 26)
        Me.cbA.TabIndex = 118
        Me.cbA.Text = "**LC on LC button, except for code books"
        '
        'txtTL2
        '
        Me.txtTL2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL2.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL2.Location = New System.Drawing.Point(0, 0)
        Me.txtTL2.Multiline = True
        Me.txtTL2.Name = "txtTL2"
        Me.txtTL2.ReadOnly = True
        Me.txtTL2.Size = New System.Drawing.Size(534, 30)
        Me.txtTL2.TabIndex = 1
        Me.txtTL2.TabStop = False
        Me.txtTL2.Tag = "VP"
        Me.txtTL2.Text = "Main table"
        '
        'cbX
        '
        Me.cbX.AccessibleName = "X"
        Me.cbX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbX.Location = New System.Drawing.Point(637, 454)
        Me.cbX.Name = "cbX"
        Me.cbX.Size = New System.Drawing.Size(432, 26)
        Me.cbX.TabIndex = 117
        Me.cbX.Text = "**LC only on LC button and SAVE button"
        '
        'cbSendEmail
        '
        Me.cbSendEmail.AccessibleName = "SendEmail"
        Me.cbSendEmail.AutoSize = True
        Me.cbSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSendEmail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSendEmail.Location = New System.Drawing.Point(3, 55)
        Me.cbSendEmail.Name = "cbSendEmail"
        Me.cbSendEmail.Size = New System.Drawing.Size(151, 17)
        Me.cbSendEmail.TabIndex = 108
        Me.cbSendEmail.Text = "Add send email button"
        '
        'cbAdvancedSearch
        '
        Me.cbAdvancedSearch.AccessibleName = "npretraga"
        Me.cbAdvancedSearch.AutoSize = True
        Me.cbAdvancedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAdvancedSearch.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAdvancedSearch.Location = New System.Drawing.Point(3, 233)
        Me.cbAdvancedSearch.Name = "cbAdvancedSearch"
        Me.cbAdvancedSearch.Size = New System.Drawing.Size(224, 17)
        Me.cbAdvancedSearch.TabIndex = 109
        Me.cbAdvancedSearch.Text = "Table is always in advanced search"
        '
        'cbMax
        '
        Me.cbMax.AccessibleName = "max"
        Me.cbMax.AutoSize = True
        Me.cbMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMax.Location = New System.Drawing.Point(3, 30)
        Me.cbMax.Name = "cbMax"
        Me.cbMax.Size = New System.Drawing.Size(131, 17)
        Me.cbMax.TabIndex = 106
        Me.cbMax.Text = "Form is maximized"
        '
        'paneT3
        '
        Me.paneT3.AccessibleName = "childAttributes"
        Me.paneT3.Controls.Add(Me.cbDNR)
        Me.paneT3.Controls.Add(Me.btnT3OK)
        Me.paneT3.Controls.Add(Me.btnT3Cancel)
        Me.paneT3.Controls.Add(Me.Panel2)
        Me.paneT3.Controls.Add(Me.txtT2BY)
        Me.paneT3.Controls.Add(Me.Label18)
        Me.paneT3.Controls.Add(Me.Label19)
        Me.paneT3.Controls.Add(Me.Label20)
        Me.paneT3.Controls.Add(Me.txtT2BX)
        Me.paneT3.Controls.Add(Me.cbT2DisableMouse)
        Me.paneT3.Controls.Add(Me.cbOnButtonClick)
        Me.paneT3.Controls.Add(Me.cbT2BAR)
        Me.paneT3.Controls.Add(Me.cbT2BI)
        Me.paneT3.Controls.Add(Me.cbT2BB)
        Me.paneT3.Controls.Add(Me.cbT2BAC)
        Me.paneT3.Controls.Add(Me.cbT2BS)
        Me.paneT3.Controls.Add(Me.cbNoButton)
        Me.paneT3.Controls.Add(Me.Label6)
        Me.paneT3.Controls.Add(Me.Label5)
        Me.paneT3.Controls.Add(Me.txtDESO)
        Me.paneT3.Controls.Add(Me.txtT2BH)
        Me.paneT3.Controls.Add(Me.txtT2BW)
        Me.paneT3.Controls.Add(Me.txtGH)
        Me.paneT3.Controls.Add(Me.cbView)
        Me.paneT3.Controls.Add(Me.Label7)
        Me.paneT3.Controls.Add(Me.Mkc_ColorCombobox3T)
        Me.paneT3.Controls.Add(Me.Mkc_ColorCombobox4T)
        Me.paneT3.Controls.Add(Me.cbBH)
        Me.paneT3.Controls.Add(Me.cbT2BBC)
        Me.paneT3.Controls.Add(Me.cbBW)
        Me.paneT3.Controls.Add(Me.cbT2BFC)
        Me.paneT3.Controls.Add(Me.cbHA)
        Me.paneT3.Controls.Add(Me.cbNoGridSpace)
        Me.paneT3.Controls.Add(Me.cbNoGrid)
        Me.paneT3.Controls.Add(Me.cbGCI)
        Me.paneT3.Controls.Add(Me.cbT2Max)
        Me.paneT3.Controls.Add(Me.cbGH)
        Me.paneT3.Controls.Add(Me.cbT2Min)
        Me.paneT3.Controls.Add(Me.cbGCAR)
        Me.paneT3.Controls.Add(Me.cbT2Web)
        Me.paneT3.Controls.Add(Me.cbNoPlus)
        Me.paneT3.Controls.Add(Me.cbBVF)
        Me.paneT3.Controls.Add(Me.cbDESO)
        Me.paneT3.Controls.Add(Me.txtTL3)
        Me.paneT3.Controls.Add(Me.tbBFS)
        Me.paneT3.Location = New System.Drawing.Point(3, 219)
        Me.paneT3.Name = "paneT3"
        Me.paneT3.Size = New System.Drawing.Size(534, 50)
        Me.paneT3.TabIndex = 115
        Me.paneT3.Tag = "615"
        '
        'cbDNR
        '
        Me.cbDNR.AccessibleName = "DontResize"
        Me.cbDNR.AutoSize = True
        Me.cbDNR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDNR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDNR.Location = New System.Drawing.Point(3, 163)
        Me.cbDNR.Name = "cbDNR"
        Me.cbDNR.Size = New System.Drawing.Size(189, 17)
        Me.cbDNR.TabIndex = 280
        Me.cbDNR.Text = "Don't resize controls on form"
        '
        'btnT3OK
        '
        Me.btnT3OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT3OK.Location = New System.Drawing.Point(3, 496)
        Me.btnT3OK.Name = "btnT3OK"
        Me.btnT3OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT3OK.TabIndex = 279
        Me.btnT3OK.Tag = "3"
        Me.btnT3OK.Text = "OK"
        Me.btnT3OK.UseVisualStyleBackColor = True
        '
        'btnT3Cancel
        '
        Me.btnT3Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT3Cancel.Location = New System.Drawing.Point(145, 496)
        Me.btnT3Cancel.Name = "btnT3Cancel"
        Me.btnT3Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT3Cancel.TabIndex = 278
        Me.btnT3Cancel.Tag = "3"
        Me.btnT3Cancel.Text = "Cancel"
        Me.btnT3Cancel.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvOnButtonClickStop)
        Me.Panel2.Location = New System.Drawing.Point(737, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 496)
        Me.Panel2.TabIndex = 1
        Me.Panel2.Visible = False
        '
        'dgvOnButtonClickStop
        '
        Me.dgvOnButtonClickStop.AllowDrop = True
        Me.dgvOnButtonClickStop.AllowUserToOrderColumns = True
        Me.dgvOnButtonClickStop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnButtonClickStop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnButtonClickStop.ColumnHeadersHeight = 30
        Me.dgvOnButtonClickStop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnButtonClickStop.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOnButtonClickStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnButtonClickStop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnButtonClickStop.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnButtonClickStop.Location = New System.Drawing.Point(0, 0)
        Me.dgvOnButtonClickStop.MultiSelect = False
        Me.dgvOnButtonClickStop.Name = "dgvOnButtonClickStop"
        Me.dgvOnButtonClickStop.RowHeadersWidth = 45
        Me.dgvOnButtonClickStop.RowTemplate.Height = 30
        Me.dgvOnButtonClickStop.Size = New System.Drawing.Size(654, 496)
        Me.dgvOnButtonClickStop.TabIndex = 168
        Me.dgvOnButtonClickStop.Tag = "15"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.HeaderText = "On button click stop if"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 300
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 300
        '
        'txtT2BY
        '
        Me.txtT2BY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BY.Location = New System.Drawing.Point(472, 378)
        Me.txtT2BY.Name = "txtT2BY"
        Me.txtT2BY.Size = New System.Drawing.Size(75, 21)
        Me.txtT2BY.TabIndex = 270
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(354, 359)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 273
        Me.Label18.Text = "Location"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(455, 384)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 272
        Me.Label19.Text = "Y"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(353, 384)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 271
        Me.Label20.Text = "X"
        '
        'txtT2BX
        '
        Me.txtT2BX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BX.Location = New System.Drawing.Point(371, 378)
        Me.txtT2BX.Name = "txtT2BX"
        Me.txtT2BX.Size = New System.Drawing.Size(75, 21)
        Me.txtT2BX.TabIndex = 269
        '
        'cbT2DisableMouse
        '
        Me.cbT2DisableMouse.AccessibleName = "DisableMouse"
        Me.cbT2DisableMouse.AutoSize = True
        Me.cbT2DisableMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2DisableMouse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2DisableMouse.Location = New System.Drawing.Point(3, 137)
        Me.cbT2DisableMouse.Name = "cbT2DisableMouse"
        Me.cbT2DisableMouse.Size = New System.Drawing.Size(107, 17)
        Me.cbT2DisableMouse.TabIndex = 268
        Me.cbT2DisableMouse.Text = "Disable mouse"
        '
        'cbOnButtonClick
        '
        Me.cbOnButtonClick.AutoSize = True
        Me.cbOnButtonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOnButtonClick.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOnButtonClick.Location = New System.Drawing.Point(590, 76)
        Me.cbOnButtonClick.Name = "cbOnButtonClick"
        Me.cbOnButtonClick.Size = New System.Drawing.Size(143, 17)
        Me.cbOnButtonClick.TabIndex = 266
        Me.cbOnButtonClick.Text = "Button on click event"
        '
        'cbT2BAR
        '
        Me.cbT2BAR.AutoSize = True
        Me.cbT2BAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BAR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BAR.Location = New System.Drawing.Point(338, 229)
        Me.cbT2BAR.Name = "cbT2BAR"
        Me.cbT2BAR.Size = New System.Drawing.Size(103, 17)
        Me.cbT2BAR.TabIndex = 260
        Me.cbT2BAR.Text = "Aligment right"
        '
        'cbT2BI
        '
        Me.cbT2BI.AccessibleName = "fontItalic"
        Me.cbT2BI.AutoSize = True
        Me.cbT2BI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BI.Location = New System.Drawing.Point(338, 178)
        Me.cbT2BI.Name = "cbT2BI"
        Me.cbT2BI.Size = New System.Drawing.Size(51, 17)
        Me.cbT2BI.TabIndex = 261
        Me.cbT2BI.Text = "Italic"
        '
        'cbT2BB
        '
        Me.cbT2BB.AccessibleName = "fontBold"
        Me.cbT2BB.AutoSize = True
        Me.cbT2BB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BB.Location = New System.Drawing.Point(338, 151)
        Me.cbT2BB.Name = "cbT2BB"
        Me.cbT2BB.Size = New System.Drawing.Size(48, 17)
        Me.cbT2BB.TabIndex = 258
        Me.cbT2BB.Text = "Bold"
        '
        'cbT2BAC
        '
        Me.cbT2BAC.AutoSize = True
        Me.cbT2BAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BAC.Location = New System.Drawing.Point(338, 203)
        Me.cbT2BAC.Name = "cbT2BAC"
        Me.cbT2BAC.Size = New System.Drawing.Size(113, 17)
        Me.cbT2BAC.TabIndex = 259
        Me.cbT2BAC.Text = "Aligment center"
        '
        'cbT2BS
        '
        Me.cbT2BS.AutoSize = True
        Me.cbT2BS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BS.Location = New System.Drawing.Point(338, 127)
        Me.cbT2BS.Name = "cbT2BS"
        Me.cbT2BS.Size = New System.Drawing.Size(47, 17)
        Me.cbT2BS.TabIndex = 265
        Me.cbT2BS.Text = "Size"
        '
        'cbNoButton
        '
        Me.cbNoButton.AccessibleName = "NoButton"
        Me.cbNoButton.AutoSize = True
        Me.cbNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoButton.Location = New System.Drawing.Point(338, 255)
        Me.cbNoButton.Name = "cbNoButton"
        Me.cbNoButton.Size = New System.Drawing.Size(110, 17)
        Me.cbNoButton.TabIndex = 256
        Me.cbNoButton.Text = "No button at all"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(326, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Button apperance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(11, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 240
        Me.Label5.Text = "Grid options"
        '
        'txtDESO
        '
        Me.txtDESO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESO.Location = New System.Drawing.Point(169, 86)
        Me.txtDESO.Name = "txtDESO"
        Me.txtDESO.Size = New System.Drawing.Size(75, 21)
        Me.txtDESO.TabIndex = 253
        Me.txtDESO.Visible = False
        '
        'txtT2BH
        '
        Me.txtT2BH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BH.Location = New System.Drawing.Point(429, 76)
        Me.txtT2BH.Name = "txtT2BH"
        Me.txtT2BH.Size = New System.Drawing.Size(75, 21)
        Me.txtT2BH.TabIndex = 247
        Me.txtT2BH.Visible = False
        '
        'txtT2BW
        '
        Me.txtT2BW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BW.Location = New System.Drawing.Point(429, 100)
        Me.txtT2BW.Name = "txtT2BW"
        Me.txtT2BW.Size = New System.Drawing.Size(75, 21)
        Me.txtT2BW.TabIndex = 245
        Me.txtT2BW.Visible = False
        '
        'txtGH
        '
        Me.txtGH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGH.Location = New System.Drawing.Point(122, 377)
        Me.txtGH.Name = "txtGH"
        Me.txtGH.Size = New System.Drawing.Size(75, 21)
        Me.txtGH.TabIndex = 226
        Me.txtGH.Visible = False
        '
        'cbView
        '
        Me.cbView.AccessibleName = "view"
        Me.cbView.AutoSize = True
        Me.cbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbView.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbView.Location = New System.Drawing.Point(3, 60)
        Me.cbView.Name = "cbView"
        Me.cbView.Size = New System.Drawing.Size(131, 17)
        Me.cbView.TabIndex = 230
        Me.cbView.Text = "Data are read only"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 252
        Me.Label7.Visible = False
        '
        'Mkc_ColorCombobox3T
        '
        Me.Mkc_ColorCombobox3T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox3T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox3T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox3T.Location = New System.Drawing.Point(441, 306)
        Me.Mkc_ColorCombobox3T.Name = "Mkc_ColorCombobox3T"
        Me.Mkc_ColorCombobox3T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox3T.Size = New System.Drawing.Size(255, 21)
        Me.Mkc_ColorCombobox3T.TabIndex = 249
        Me.Mkc_ColorCombobox3T.Tag = "VF"
        Me.Mkc_ColorCombobox3T.Visible = False
        '
        'Mkc_ColorCombobox4T
        '
        Me.Mkc_ColorCombobox4T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox4T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox4T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox4T.Location = New System.Drawing.Point(441, 332)
        Me.Mkc_ColorCombobox4T.Name = "Mkc_ColorCombobox4T"
        Me.Mkc_ColorCombobox4T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox4T.Size = New System.Drawing.Size(255, 21)
        Me.Mkc_ColorCombobox4T.TabIndex = 248
        Me.Mkc_ColorCombobox4T.Tag = "VF"
        Me.Mkc_ColorCombobox4T.Visible = False
        '
        'cbBH
        '
        Me.cbBH.AutoSize = True
        Me.cbBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBH.Location = New System.Drawing.Point(338, 76)
        Me.cbBH.Name = "cbBH"
        Me.cbBH.Size = New System.Drawing.Size(59, 17)
        Me.cbBH.TabIndex = 246
        Me.cbBH.Text = "Height"
        '
        'cbT2BBC
        '
        Me.cbT2BBC.AutoSize = True
        Me.cbT2BBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BBC.Location = New System.Drawing.Point(338, 332)
        Me.cbT2BBC.Name = "cbT2BBC"
        Me.cbT2BBC.Size = New System.Drawing.Size(83, 17)
        Me.cbT2BBC.TabIndex = 244
        Me.cbT2BBC.Text = "Back color"
        '
        'cbBW
        '
        Me.cbBW.AutoSize = True
        Me.cbBW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBW.Location = New System.Drawing.Point(338, 100)
        Me.cbBW.Name = "cbBW"
        Me.cbBW.Size = New System.Drawing.Size(55, 17)
        Me.cbBW.TabIndex = 243
        Me.cbBW.Text = "Width"
        '
        'cbT2BFC
        '
        Me.cbT2BFC.AutoSize = True
        Me.cbT2BFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BFC.Location = New System.Drawing.Point(338, 306)
        Me.cbT2BFC.Name = "cbT2BFC"
        Me.cbT2BFC.Size = New System.Drawing.Size(80, 17)
        Me.cbT2BFC.TabIndex = 242
        Me.cbT2BFC.Text = "Fore color"
        '
        'cbHA
        '
        Me.cbHA.AccessibleName = "HORIZONTAL"
        Me.cbHA.AutoSize = True
        Me.cbHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHA.Location = New System.Drawing.Point(3, 111)
        Me.cbHA.Name = "cbHA"
        Me.cbHA.Size = New System.Drawing.Size(216, 17)
        Me.cbHA.TabIndex = 239
        Me.cbHA.Text = "Horizontal aligment for all buttons"
        '
        'cbNoGridSpace
        '
        Me.cbNoGridSpace.AccessibleName = "NoGridSpace"
        Me.cbNoGridSpace.AutoSize = True
        Me.cbNoGridSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoGridSpace.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoGridSpace.Location = New System.Drawing.Point(3, 326)
        Me.cbNoGridSpace.Name = "cbNoGridSpace"
        Me.cbNoGridSpace.Size = New System.Drawing.Size(159, 17)
        Me.cbNoGridSpace.TabIndex = 237
        Me.cbNoGridSpace.Text = "No space between grids"
        '
        'cbNoGrid
        '
        Me.cbNoGrid.AccessibleName = "noGrid"
        Me.cbNoGrid.AutoSize = True
        Me.cbNoGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoGrid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoGrid.Location = New System.Drawing.Point(3, 403)
        Me.cbNoGrid.Name = "cbNoGrid"
        Me.cbNoGrid.Size = New System.Drawing.Size(98, 17)
        Me.cbNoGrid.TabIndex = 229
        Me.cbNoGrid.Text = "Collapse grid"
        '
        'cbGCI
        '
        Me.cbGCI.AccessibleName = "gridColumnsIst"
        Me.cbGCI.AutoSize = True
        Me.cbGCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGCI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGCI.Location = New System.Drawing.Point(3, 248)
        Me.cbGCI.Name = "cbGCI"
        Me.cbGCI.Size = New System.Drawing.Size(128, 17)
        Me.cbGCI.TabIndex = 233
        Me.cbGCI.Text = "Columns from IST"
        '
        'cbT2Max
        '
        Me.cbT2Max.AccessibleName = "Max"
        Me.cbT2Max.AutoSize = True
        Me.cbT2Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2Max.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2Max.Location = New System.Drawing.Point(3, 299)
        Me.cbT2Max.Name = "cbT2Max"
        Me.cbT2Max.Size = New System.Drawing.Size(83, 17)
        Me.cbT2Max.TabIndex = 227
        Me.cbT2Max.Text = "Maximized"
        '
        'cbGH
        '
        Me.cbGH.AutoSize = True
        Me.cbGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGH.Location = New System.Drawing.Point(3, 377)
        Me.cbGH.Name = "cbGH"
        Me.cbGH.Size = New System.Drawing.Size(59, 17)
        Me.cbGH.TabIndex = 235
        Me.cbGH.Text = "Height"
        '
        'cbT2Min
        '
        Me.cbT2Min.AccessibleName = "Min"
        Me.cbT2Min.AutoSize = True
        Me.cbT2Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2Min.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2Min.Location = New System.Drawing.Point(3, 275)
        Me.cbT2Min.Name = "cbT2Min"
        Me.cbT2Min.Size = New System.Drawing.Size(79, 17)
        Me.cbT2Min.TabIndex = 228
        Me.cbT2Min.Text = "Minimized"
        '
        'cbGCAR
        '
        Me.cbGCAR.AccessibleName = "GRIDCOLAUTORESIZE"
        Me.cbGCAR.AutoSize = True
        Me.cbGCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGCAR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGCAR.Location = New System.Drawing.Point(3, 224)
        Me.cbGCAR.Name = "cbGCAR"
        Me.cbGCAR.Size = New System.Drawing.Size(140, 17)
        Me.cbGCAR.TabIndex = 234
        Me.cbGCAR.Text = "Columns auto resize"
        '
        'cbT2Web
        '
        Me.cbT2Web.AccessibleName = "web"
        Me.cbT2Web.AutoSize = True
        Me.cbT2Web.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2Web.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2Web.Location = New System.Drawing.Point(3, 34)
        Me.cbT2Web.Name = "cbT2Web"
        Me.cbT2Web.Size = New System.Drawing.Size(211, 17)
        Me.cbT2Web.TabIndex = 231
        Me.cbT2Web.Text = "Generate web page for this table"
        '
        'cbNoPlus
        '
        Me.cbNoPlus.AccessibleName = "NoPlus"
        Me.cbNoPlus.AutoSize = True
        Me.cbNoPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoPlus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoPlus.Location = New System.Drawing.Point(3, 351)
        Me.cbNoPlus.Name = "cbNoPlus"
        Me.cbNoPlus.Size = New System.Drawing.Size(78, 17)
        Me.cbNoPlus.TabIndex = 238
        Me.cbNoPlus.Text = "No + sign"
        '
        'cbBVF
        '
        Me.cbBVF.AccessibleName = "buttonVisibleFalse"
        Me.cbBVF.AutoSize = True
        Me.cbBVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBVF.Location = New System.Drawing.Point(338, 280)
        Me.cbBVF.Name = "cbBVF"
        Me.cbBVF.Size = New System.Drawing.Size(91, 17)
        Me.cbBVF.TabIndex = 257
        Me.cbBVF.Text = "Visible false"
        '
        'cbDESO
        '
        Me.cbDESO.AutoSize = True
        Me.cbDESO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDESO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDESO.Location = New System.Drawing.Point(3, 86)
        Me.cbDESO.Name = "cbDESO"
        Me.cbDESO.Size = New System.Drawing.Size(161, 17)
        Me.cbDESO.TabIndex = 254
        Me.cbDESO.Text = "Data entry screen order"
        '
        'txtTL3
        '
        Me.txtTL3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL3.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL3.Location = New System.Drawing.Point(0, 0)
        Me.txtTL3.Multiline = True
        Me.txtTL3.Name = "txtTL3"
        Me.txtTL3.ReadOnly = True
        Me.txtTL3.Size = New System.Drawing.Size(534, 30)
        Me.txtTL3.TabIndex = 2
        Me.txtTL3.TabStop = False
        Me.txtTL3.Tag = "VP"
        Me.txtTL3.Text = "Subtable"
        '
        'tbBFS
        '
        Me.tbBFS.AccessibleName = "lHeight"
        Me.tbBFS.LargeChange = 1
        Me.tbBFS.Location = New System.Drawing.Point(429, 127)
        Me.tbBFS.Maximum = 20
        Me.tbBFS.Minimum = 6
        Me.tbBFS.Name = "tbBFS"
        Me.tbBFS.Size = New System.Drawing.Size(145, 45)
        Me.tbBFS.TabIndex = 277
        Me.tbBFS.TabStop = False
        Me.tbBFS.Tag = "8"
        Me.tbBFS.Value = 8
        Me.tbBFS.Visible = False
        '
        'paneAT
        '
        Me.paneAT.Controls.Add(Me.gbCopy)
        Me.paneAT.Controls.Add(Me.cbCopyT)
        Me.paneAT.Controls.Add(Me.cbTc4)
        Me.paneAT.Controls.Add(Me.cbTc2)
        Me.paneAT.Controls.Add(Me.cbTc1)
        Me.paneAT.Controls.Add(Me.llPreviewT)
        Me.paneAT.Controls.Add(Me.tbSAT)
        Me.paneAT.Controls.Add(Me.tbHAT)
        Me.paneAT.Controls.Add(Me.cbHAT)
        Me.paneAT.Controls.Add(Me.cbSAT)
        Me.paneAT.Controls.Add(Me.cboBGCAT)
        Me.paneAT.Controls.Add(Me.Label144)
        Me.paneAT.Controls.Add(Me.cboTAAT)
        Me.paneAT.Controls.Add(Me.cboFTAT)
        Me.paneAT.Controls.Add(Me.Label145)
        Me.paneAT.Controls.Add(Me.cboBCAT)
        Me.paneAT.Controls.Add(Me.cboFCAT)
        Me.paneAT.Controls.Add(Me.lblGAT)
        Me.paneAT.Controls.Add(Me.cboNadTabelaAT)
        Me.paneAT.Controls.Add(Me.txtvdoAT)
        Me.paneAT.Controls.Add(Me.txtvodAT)
        Me.paneAT.Controls.Add(Me.txtlbl12AT)
        Me.paneAT.Controls.Add(Me.txtDescriptionAT)
        Me.paneAT.Controls.Add(Me.lblDescription)
        Me.paneAT.Controls.Add(Me.Label23)
        Me.paneAT.Controls.Add(Me.cboTipAT)
        Me.paneAT.Controls.Add(Me.Label24)
        Me.paneAT.Controls.Add(Me.txtNameAT)
        Me.paneAT.Controls.Add(Me.btnATOK)
        Me.paneAT.Controls.Add(Me.btnATCancel)
        Me.paneAT.Controls.Add(Me.txtTLAT)
        Me.paneAT.Location = New System.Drawing.Point(3, 3)
        Me.paneAT.Name = "paneAT"
        Me.paneAT.Size = New System.Drawing.Size(534, 42)
        Me.paneAT.TabIndex = 173
        Me.paneAT.Tag = "530"
        '
        'gbCopy
        '
        Me.gbCopy.Controls.Add(Me.Label106)
        Me.gbCopy.Controls.Add(Me.Label96)
        Me.gbCopy.Controls.Add(Me.cbCopy)
        Me.gbCopy.Controls.Add(Me.cbCopyName)
        Me.gbCopy.Controls.Add(Me.btn2)
        Me.gbCopy.Controls.Add(Me.cbCopyMD)
        Me.gbCopy.Controls.Add(Me.btn1)
        Me.gbCopy.Location = New System.Drawing.Point(556, 56)
        Me.gbCopy.Name = "gbCopy"
        Me.gbCopy.Size = New System.Drawing.Size(384, 242)
        Me.gbCopy.TabIndex = 277
        Me.gbCopy.TabStop = False
        Me.gbCopy.Visible = False
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label106.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(10, 19)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(37, 13)
        Me.Label106.TabIndex = 319
        Me.Label106.Text = "Table"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label96.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(10, 63)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(40, 13)
        Me.Label96.TabIndex = 318
        Me.Label96.Text = "Name"
        '
        'cbCopy
        '
        Me.cbCopy.CausesValidation = False
        Me.cbCopy.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbCopy.FormattingEnabled = True
        Me.cbCopy.Location = New System.Drawing.Point(10, 36)
        Me.cbCopy.Name = "cbCopy"
        Me.cbCopy.Size = New System.Drawing.Size(366, 21)
        Me.cbCopy.TabIndex = 317
        '
        'cbCopyName
        '
        Me.cbCopyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbCopyName.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbCopyName.Location = New System.Drawing.Point(10, 79)
        Me.cbCopyName.Name = "cbCopyName"
        Me.cbCopyName.Size = New System.Drawing.Size(366, 20)
        Me.cbCopyName.TabIndex = 316
        '
        'btn2
        '
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Location = New System.Drawing.Point(248, 190)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(128, 31)
        Me.btn2.TabIndex = 315
        Me.btn2.Tag = "0"
        Me.btn2.Text = "Submit"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'cbCopyMD
        '
        Me.cbCopyMD.AutoSize = True
        Me.cbCopyMD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCopyMD.Location = New System.Drawing.Point(197, 165)
        Me.cbCopyMD.Name = "cbCopyMD"
        Me.cbCopyMD.Size = New System.Drawing.Size(112, 17)
        Me.cbCopyMD.TabIndex = 314
        Me.cbCopyMD.Text = "Copy Metadata"
        '
        'btn1
        '
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Location = New System.Drawing.Point(248, 104)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(128, 31)
        Me.btn1.TabIndex = 313
        Me.btn1.Tag = "0"
        Me.btn1.Text = "Submit"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'cbCopyT
        '
        Me.cbCopyT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCopyT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCopyT.Location = New System.Drawing.Point(556, 32)
        Me.cbCopyT.Name = "cbCopyT"
        Me.cbCopyT.Size = New System.Drawing.Size(262, 26)
        Me.cbCopyT.TabIndex = 276
        Me.cbCopyT.Text = "Copy table like"
        '
        'cbTc4
        '
        Me.cbTc4.AutoSize = True
        Me.cbTc4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbTc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTc4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTc4.Location = New System.Drawing.Point(26, 384)
        Me.cbTc4.Name = "cbTc4"
        Me.cbTc4.Size = New System.Drawing.Size(123, 17)
        Me.cbTc4.TabIndex = 275
        Me.cbTc4.Text = "Background color"
        Me.cbTc4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbTc2
        '
        Me.cbTc2.AccessibleName = ""
        Me.cbTc2.AutoSize = True
        Me.cbTc2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbTc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTc2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTc2.Location = New System.Drawing.Point(26, 263)
        Me.cbTc2.Name = "cbTc2"
        Me.cbTc2.Size = New System.Drawing.Size(83, 17)
        Me.cbTc2.TabIndex = 274
        Me.cbTc2.Text = "Back color"
        Me.cbTc2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbTc1
        '
        Me.cbTc1.AccessibleName = ""
        Me.cbTc1.AutoSize = True
        Me.cbTc1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbTc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTc1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTc1.Location = New System.Drawing.Point(26, 237)
        Me.cbTc1.Name = "cbTc1"
        Me.cbTc1.Size = New System.Drawing.Size(80, 17)
        Me.cbTc1.TabIndex = 273
        Me.cbTc1.Text = "Fore color"
        Me.cbTc1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'llPreviewT
        '
        Me.llPreviewT.ActiveLinkColor = System.Drawing.Color.Black
        Me.llPreviewT.AutoSize = True
        Me.llPreviewT.BackColor = System.Drawing.Color.Transparent
        Me.llPreviewT.DisabledLinkColor = System.Drawing.Color.Black
        Me.llPreviewT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llPreviewT.LinkColor = System.Drawing.Color.Black
        Me.llPreviewT.Location = New System.Drawing.Point(337, 500)
        Me.llPreviewT.Name = "llPreviewT"
        Me.llPreviewT.Size = New System.Drawing.Size(146, 13)
        Me.llPreviewT.TabIndex = 272
        Me.llPreviewT.TabStop = True
        Me.llPreviewT.Text = "Preview data entry form"
        Me.llPreviewT.Visible = False
        '
        'tbSAT
        '
        Me.tbSAT.AccessibleName = "lHeight"
        Me.tbSAT.LargeChange = 1
        Me.tbSAT.Location = New System.Drawing.Point(160, 311)
        Me.tbSAT.Maximum = 20
        Me.tbSAT.Minimum = 6
        Me.tbSAT.Name = "tbSAT"
        Me.tbSAT.Size = New System.Drawing.Size(145, 45)
        Me.tbSAT.TabIndex = 271
        Me.tbSAT.TabStop = False
        Me.tbSAT.Tag = "8"
        Me.tbSAT.Value = 8
        Me.tbSAT.Visible = False
        '
        'tbHAT
        '
        Me.tbHAT.AccessibleName = "lHeight"
        Me.tbHAT.LargeChange = 1
        Me.tbHAT.Location = New System.Drawing.Point(160, 189)
        Me.tbHAT.Maximum = 5
        Me.tbHAT.Minimum = 1
        Me.tbHAT.Name = "tbHAT"
        Me.tbHAT.Size = New System.Drawing.Size(145, 45)
        Me.tbHAT.TabIndex = 270
        Me.tbHAT.TabStop = False
        Me.tbHAT.Tag = "1"
        Me.tbHAT.Value = 1
        Me.tbHAT.Visible = False
        '
        'cbHAT
        '
        Me.cbHAT.AccessibleName = ""
        Me.cbHAT.AutoSize = True
        Me.cbHAT.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbHAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHAT.Location = New System.Drawing.Point(26, 189)
        Me.cbHAT.Name = "cbHAT"
        Me.cbHAT.Size = New System.Drawing.Size(86, 17)
        Me.cbHAT.TabIndex = 268
        Me.cbHAT.Tag = ""
        Me.cbHAT.Text = "Title height"
        Me.cbHAT.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cbSAT
        '
        Me.cbSAT.AutoSize = True
        Me.cbSAT.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbSAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSAT.Location = New System.Drawing.Point(26, 311)
        Me.cbSAT.Name = "cbSAT"
        Me.cbSAT.Size = New System.Drawing.Size(73, 17)
        Me.cbSAT.TabIndex = 269
        Me.cbSAT.Text = "Font size"
        Me.cbSAT.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'cboBGCAT
        '
        Me.cboBGCAT.AccessibleName = ""
        Me.cboBGCAT.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.cboBGCAT.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.cboBGCAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBGCAT.Location = New System.Drawing.Point(160, 384)
        Me.cboBGCAT.Name = "cboBGCAT"
        Me.cboBGCAT.SelectedColor = System.Drawing.Color.Empty
        Me.cboBGCAT.Size = New System.Drawing.Size(374, 30)
        Me.cboBGCAT.TabIndex = 267
        Me.cboBGCAT.Tag = "VF"
        Me.cboBGCAT.Visible = False
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label144.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label144.Location = New System.Drawing.Point(26, 361)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(91, 13)
        Me.Label144.TabIndex = 265
        Me.Label144.Text = "Text alignment"
        Me.Label144.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboTAAT
        '
        Me.cboTAAT.AutoCompleteCustomSource.AddRange(New String() {"Left", "Center", "Right"})
        Me.cboTAAT.CausesValidation = False
        Me.cboTAAT.DropDownWidth = 250
        Me.cboTAAT.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboTAAT.FormattingEnabled = True
        Me.cboTAAT.Items.AddRange(New Object() {"Left", "Right", "Center"})
        Me.cboTAAT.Location = New System.Drawing.Point(160, 361)
        Me.cboTAAT.Name = "cboTAAT"
        Me.cboTAAT.Size = New System.Drawing.Size(374, 21)
        Me.cboTAAT.TabIndex = 264
        '
        'cboFTAT
        '
        Me.cboFTAT.CausesValidation = False
        Me.cboFTAT.DropDownWidth = 250
        Me.cboFTAT.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboFTAT.FormattingEnabled = True
        Me.cboFTAT.Items.AddRange(New Object() {"Bold", "Italic", "Underline", "Regular"})
        Me.cboFTAT.Location = New System.Drawing.Point(160, 286)
        Me.cboFTAT.Name = "cboFTAT"
        Me.cboFTAT.Size = New System.Drawing.Size(374, 21)
        Me.cboFTAT.TabIndex = 263
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label145.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label145.Location = New System.Drawing.Point(26, 286)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(60, 13)
        Me.Label145.TabIndex = 262
        Me.Label145.Text = "Font type"
        Me.Label145.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboBCAT
        '
        Me.cboBCAT.AccessibleName = ""
        Me.cboBCAT.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.cboBCAT.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.cboBCAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBCAT.Location = New System.Drawing.Point(160, 263)
        Me.cboBCAT.Name = "cboBCAT"
        Me.cboBCAT.SelectedColor = System.Drawing.Color.Empty
        Me.cboBCAT.Size = New System.Drawing.Size(374, 30)
        Me.cboBCAT.TabIndex = 195
        Me.cboBCAT.Tag = "VF"
        Me.cboBCAT.Visible = False
        '
        'cboFCAT
        '
        Me.cboFCAT.AccessibleName = ""
        Me.cboFCAT.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.cboFCAT.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.cboFCAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFCAT.Location = New System.Drawing.Point(160, 240)
        Me.cboFCAT.Name = "cboFCAT"
        Me.cboFCAT.SelectedColor = System.Drawing.Color.Empty
        Me.cboFCAT.Size = New System.Drawing.Size(374, 30)
        Me.cboFCAT.TabIndex = 194
        Me.cboFCAT.Tag = "VF"
        Me.cboFCAT.Visible = False
        '
        'lblGAT
        '
        Me.lblGAT.AutoSize = True
        Me.lblGAT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblGAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGAT.Location = New System.Drawing.Point(26, 77)
        Me.lblGAT.Name = "lblGAT"
        Me.lblGAT.Size = New System.Drawing.Size(107, 13)
        Me.lblGAT.TabIndex = 171
        Me.lblGAT.Text = "Main/parent table"
        Me.lblGAT.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblGAT.Visible = False
        '
        'cboNadTabelaAT
        '
        Me.cboNadTabelaAT.CausesValidation = False
        Me.cboNadTabelaAT.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboNadTabelaAT.FormattingEnabled = True
        Me.cboNadTabelaAT.Location = New System.Drawing.Point(160, 77)
        Me.cboNadTabelaAT.Name = "cboNadTabelaAT"
        Me.cboNadTabelaAT.Size = New System.Drawing.Size(374, 21)
        Me.cboNadTabelaAT.TabIndex = 170
        Me.cboNadTabelaAT.Visible = False
        '
        'txtvdoAT
        '
        Me.txtvdoAT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvdoAT.Location = New System.Drawing.Point(301, 442)
        Me.txtvdoAT.Name = "txtvdoAT"
        Me.txtvdoAT.Size = New System.Drawing.Size(138, 21)
        Me.txtvdoAT.TabIndex = 169
        '
        'txtvodAT
        '
        Me.txtvodAT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvodAT.Location = New System.Drawing.Point(160, 442)
        Me.txtvodAT.Name = "txtvodAT"
        Me.txtvodAT.Size = New System.Drawing.Size(138, 21)
        Me.txtvodAT.TabIndex = 168
        '
        'txtlbl12AT
        '
        Me.txtlbl12AT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtlbl12AT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlbl12AT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtlbl12AT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtlbl12AT.Location = New System.Drawing.Point(160, 412)
        Me.txtlbl12AT.Multiline = True
        Me.txtlbl12AT.Name = "txtlbl12AT"
        Me.txtlbl12AT.ReadOnly = True
        Me.txtlbl12AT.Size = New System.Drawing.Size(279, 30)
        Me.txtlbl12AT.TabIndex = 167
        Me.txtlbl12AT.TabStop = False
        Me.txtlbl12AT.Tag = "VP"
        Me.txtlbl12AT.Text = "Validity period"
        '
        'txtDescriptionAT
        '
        Me.txtDescriptionAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescriptionAT.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtDescriptionAT.Location = New System.Drawing.Point(160, 100)
        Me.txtDescriptionAT.MaxLength = 1250
        Me.txtDescriptionAT.Multiline = True
        Me.txtDescriptionAT.Name = "txtDescriptionAT"
        Me.txtDescriptionAT.Size = New System.Drawing.Size(374, 84)
        Me.txtDescriptionAT.TabIndex = 166
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(26, 100)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(98, 13)
        Me.lblDescription.TabIndex = 165
        Me.lblDescription.Text = "Title/description"
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(26, 54)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 13)
        Me.Label23.TabIndex = 164
        Me.Label23.Text = "Type"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cboTipAT
        '
        Me.cboTipAT.CausesValidation = False
        Me.cboTipAT.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboTipAT.FormattingEnabled = True
        Me.cboTipAT.Items.AddRange(New Object() {"G - Main/parent table", "D - Subtable/child table", "A - Address book", "K - Code book", "S - table is in IST just for purpose of generating script for CAPI"})
        Me.cboTipAT.Location = New System.Drawing.Point(160, 54)
        Me.cboTipAT.Name = "cboTipAT"
        Me.cboTipAT.Size = New System.Drawing.Size(374, 21)
        Me.cboTipAT.TabIndex = 163
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(26, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(40, 13)
        Me.Label24.TabIndex = 162
        Me.Label24.Text = "Name"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNameAT
        '
        Me.txtNameAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameAT.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtNameAT.Location = New System.Drawing.Point(160, 32)
        Me.txtNameAT.Name = "txtNameAT"
        Me.txtNameAT.Size = New System.Drawing.Size(374, 20)
        Me.txtNameAT.TabIndex = 161
        '
        'btnATOK
        '
        Me.btnATOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnATOK.Location = New System.Drawing.Point(26, 491)
        Me.btnATOK.Name = "btnATOK"
        Me.btnATOK.Size = New System.Drawing.Size(128, 31)
        Me.btnATOK.TabIndex = 160
        Me.btnATOK.Tag = "0"
        Me.btnATOK.Text = "Submit"
        Me.btnATOK.UseVisualStyleBackColor = True
        '
        'btnATCancel
        '
        Me.btnATCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnATCancel.Location = New System.Drawing.Point(160, 491)
        Me.btnATCancel.Name = "btnATCancel"
        Me.btnATCancel.Size = New System.Drawing.Size(128, 31)
        Me.btnATCancel.TabIndex = 159
        Me.btnATCancel.Tag = "0"
        Me.btnATCancel.Text = "Cancel"
        Me.btnATCancel.UseVisualStyleBackColor = True
        '
        'txtTLAT
        '
        Me.txtTLAT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTLAT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTLAT.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTLAT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTLAT.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTLAT.Location = New System.Drawing.Point(0, 0)
        Me.txtTLAT.Multiline = True
        Me.txtTLAT.Name = "txtTLAT"
        Me.txtTLAT.ReadOnly = True
        Me.txtTLAT.Size = New System.Drawing.Size(534, 30)
        Me.txtTLAT.TabIndex = 1
        Me.txtTLAT.TabStop = False
        Me.txtTLAT.Tag = "VP"
        Me.txtTLAT.Text = "Add table"
        '
        'paneT0
        '
        Me.paneT0.Controls.Add(Me.btnT0OK)
        Me.paneT0.Controls.Add(Me.btnT0Cancel)
        Me.paneT0.Controls.Add(Me.txtvdoT0)
        Me.paneT0.Controls.Add(Me.txtvodT0)
        Me.paneT0.Controls.Add(Me.txtOrdinalNumber)
        Me.paneT0.Controls.Add(Me.Label4)
        Me.paneT0.Controls.Add(Me.txtL12)
        Me.paneT0.Controls.Add(Me.txtTL0)
        Me.paneT0.Controls.Add(Me.GB)
        Me.paneT0.Location = New System.Drawing.Point(3, 51)
        Me.paneT0.Name = "paneT0"
        Me.paneT0.Size = New System.Drawing.Size(534, 50)
        Me.paneT0.TabIndex = 147
        Me.paneT0.Tag = "400"
        '
        'btnT0OK
        '
        Me.btnT0OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT0OK.Location = New System.Drawing.Point(6, 348)
        Me.btnT0OK.Name = "btnT0OK"
        Me.btnT0OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT0OK.TabIndex = 158
        Me.btnT0OK.Tag = "0"
        Me.btnT0OK.Text = "OK"
        Me.btnT0OK.UseVisualStyleBackColor = True
        '
        'btnT0Cancel
        '
        Me.btnT0Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT0Cancel.Location = New System.Drawing.Point(148, 348)
        Me.btnT0Cancel.Name = "btnT0Cancel"
        Me.btnT0Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT0Cancel.TabIndex = 157
        Me.btnT0Cancel.Tag = "0"
        Me.btnT0Cancel.Text = "Cancel"
        Me.btnT0Cancel.UseVisualStyleBackColor = True
        '
        'txtvdoT0
        '
        Me.txtvdoT0.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvdoT0.Location = New System.Drawing.Point(205, 243)
        Me.txtvdoT0.Name = "txtvdoT0"
        Me.txtvdoT0.Size = New System.Drawing.Size(195, 21)
        Me.txtvdoT0.TabIndex = 156
        '
        'txtvodT0
        '
        Me.txtvodT0.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvodT0.Location = New System.Drawing.Point(6, 243)
        Me.txtvodT0.Name = "txtvodT0"
        Me.txtvodT0.Size = New System.Drawing.Size(195, 21)
        Me.txtvodT0.TabIndex = 155
        '
        'txtOrdinalNumber
        '
        Me.txtOrdinalNumber.Location = New System.Drawing.Point(6, 300)
        Me.txtOrdinalNumber.Name = "txtOrdinalNumber"
        Me.txtOrdinalNumber.Size = New System.Drawing.Size(157, 21)
        Me.txtOrdinalNumber.TabIndex = 154
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 13)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Ordinal number"
        '
        'txtL12
        '
        Me.txtL12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL12.Location = New System.Drawing.Point(6, 214)
        Me.txtL12.Multiline = True
        Me.txtL12.Name = "txtL12"
        Me.txtL12.ReadOnly = True
        Me.txtL12.Size = New System.Drawing.Size(395, 30)
        Me.txtL12.TabIndex = 150
        Me.txtL12.TabStop = False
        Me.txtL12.Tag = "VP"
        Me.txtL12.Text = "Validity period"
        '
        'txtTL0
        '
        Me.txtTL0.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL0.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL0.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL0.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL0.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL0.Location = New System.Drawing.Point(0, 0)
        Me.txtTL0.Multiline = True
        Me.txtTL0.Name = "txtTL0"
        Me.txtTL0.ReadOnly = True
        Me.txtTL0.Size = New System.Drawing.Size(534, 30)
        Me.txtTL0.TabIndex = 0
        Me.txtTL0.TabStop = False
        Me.txtTL0.Tag = "VP"
        Me.txtTL0.Text = "Table"
        '
        'GB
        '
        Me.GB.AccessibleName = "typeOfTableParentChild"
        Me.GB.Controls.Add(Me.rbS)
        Me.GB.Controls.Add(Me.rbK)
        Me.GB.Controls.Add(Me.rbABook)
        Me.GB.Controls.Add(Me.lblGT)
        Me.GB.Controls.Add(Me.cboNadTabela)
        Me.GB.Controls.Add(Me.rbD)
        Me.GB.Controls.Add(Me.rbG)
        Me.GB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB.Location = New System.Drawing.Point(6, 36)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(420, 171)
        Me.GB.TabIndex = 1
        Me.GB.TabStop = False
        '
        'rbS
        '
        Me.rbS.AutoSize = True
        Me.rbS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbS.Location = New System.Drawing.Point(3, 118)
        Me.rbS.Name = "rbS"
        Me.rbS.Size = New System.Drawing.Size(394, 18)
        Me.rbS.TabIndex = 4
        Me.rbS.TabStop = True
        Me.rbS.Text = "S - table is in IST just for purpose of generating script for CAPI"
        Me.rbS.UseVisualStyleBackColor = True
        '
        'rbK
        '
        Me.rbK.AutoSize = True
        Me.rbK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbK.Location = New System.Drawing.Point(3, 93)
        Me.rbK.Name = "rbK"
        Me.rbK.Size = New System.Drawing.Size(114, 18)
        Me.rbK.TabIndex = 3
        Me.rbK.TabStop = True
        Me.rbK.Text = "K - Code book"
        Me.rbK.UseVisualStyleBackColor = True
        '
        'rbABook
        '
        Me.rbABook.AutoSize = True
        Me.rbABook.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbABook.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbABook.Location = New System.Drawing.Point(3, 67)
        Me.rbABook.Name = "rbABook"
        Me.rbABook.Size = New System.Drawing.Size(130, 18)
        Me.rbABook.TabIndex = 2
        Me.rbABook.TabStop = True
        Me.rbABook.Text = "A - Address book"
        Me.rbABook.UseVisualStyleBackColor = True
        '
        'lblGT
        '
        Me.lblGT.AutoSize = True
        Me.lblGT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGT.Location = New System.Drawing.Point(188, 42)
        Me.lblGT.Name = "lblGT"
        Me.lblGT.Size = New System.Drawing.Size(156, 13)
        Me.lblGT.TabIndex = 152
        Me.lblGT.Text = "Choose main/parent table"
        Me.lblGT.Visible = False
        '
        'cboNadTabela
        '
        Me.cboNadTabela.AccessibleName = ""
        Me.cboNadTabela.DropDownWidth = 750
        Me.cboNadTabela.FormattingEnabled = True
        Me.cboNadTabela.Location = New System.Drawing.Point(188, 66)
        Me.cboNadTabela.Name = "cboNadTabela"
        Me.cboNadTabela.Size = New System.Drawing.Size(218, 21)
        Me.cboNadTabela.TabIndex = 151
        Me.cboNadTabela.Visible = False
        '
        'rbD
        '
        Me.rbD.AutoSize = True
        Me.rbD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbD.Location = New System.Drawing.Point(3, 42)
        Me.rbD.Name = "rbD"
        Me.rbD.Size = New System.Drawing.Size(166, 18)
        Me.rbD.TabIndex = 1
        Me.rbD.TabStop = True
        Me.rbD.Text = "D - Subtable/child table"
        Me.rbD.UseVisualStyleBackColor = True
        '
        'rbG
        '
        Me.rbG.AutoSize = True
        Me.rbG.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rbG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbG.Location = New System.Drawing.Point(3, 16)
        Me.rbG.Name = "rbG"
        Me.rbG.Size = New System.Drawing.Size(153, 18)
        Me.rbG.TabIndex = 0
        Me.rbG.TabStop = True
        Me.rbG.Text = "G - Main/parent table"
        Me.rbG.UseVisualStyleBackColor = True
        '
        'paneT1
        '
        Me.paneT1.AccessibleName = "tableDescription"
        Me.paneT1.Controls.Add(Me.btnT1OK)
        Me.paneT1.Controls.Add(Me.btnT1Cancel)
        Me.paneT1.Controls.Add(Me.tbFS)
        Me.paneT1.Controls.Add(Me.txtTitleO)
        Me.paneT1.Controls.Add(Me.Label3)
        Me.paneT1.Controls.Add(Me.txtTTitle)
        Me.paneT1.Controls.Add(Me.Mkc_ColorCombobox2T)
        Me.paneT1.Controls.Add(Me.Mkc_ColorCombobox1T)
        Me.paneT1.Controls.Add(Me.cbBC)
        Me.paneT1.Controls.Add(Me.cbFC)
        Me.paneT1.Controls.Add(Me.cbN)
        Me.paneT1.Controls.Add(Me.tbH)
        Me.paneT1.Controls.Add(Me.cbH)
        Me.paneT1.Controls.Add(Me.txtTL1)
        Me.paneT1.Controls.Add(Me.cbAR)
        Me.paneT1.Controls.Add(Me.cbI)
        Me.paneT1.Controls.Add(Me.cbTBold)
        Me.paneT1.Controls.Add(Me.cbTAC)
        Me.paneT1.Controls.Add(Me.cbS)
        Me.paneT1.Location = New System.Drawing.Point(3, 107)
        Me.paneT1.Name = "paneT1"
        Me.paneT1.Size = New System.Drawing.Size(534, 50)
        Me.paneT1.TabIndex = 146
        Me.paneT1.Tag = "270"
        '
        'btnT1OK
        '
        Me.btnT1OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT1OK.Location = New System.Drawing.Point(3, 213)
        Me.btnT1OK.Name = "btnT1OK"
        Me.btnT1OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT1OK.TabIndex = 149
        Me.btnT1OK.Tag = "1"
        Me.btnT1OK.Text = "OK"
        Me.btnT1OK.UseVisualStyleBackColor = True
        '
        'btnT1Cancel
        '
        Me.btnT1Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT1Cancel.Location = New System.Drawing.Point(145, 213)
        Me.btnT1Cancel.Name = "btnT1Cancel"
        Me.btnT1Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT1Cancel.TabIndex = 148
        Me.btnT1Cancel.Tag = "1"
        Me.btnT1Cancel.Text = "Cancel"
        Me.btnT1Cancel.UseVisualStyleBackColor = True
        '
        'tbFS
        '
        Me.tbFS.AccessibleName = "lHeight"
        Me.tbFS.LargeChange = 1
        Me.tbFS.Location = New System.Drawing.Point(216, 104)
        Me.tbFS.Maximum = 20
        Me.tbFS.Minimum = 6
        Me.tbFS.Name = "tbFS"
        Me.tbFS.Size = New System.Drawing.Size(145, 45)
        Me.tbFS.TabIndex = 147
        Me.tbFS.TabStop = False
        Me.tbFS.Tag = "8"
        Me.tbFS.Value = 8
        Me.tbFS.Visible = False
        '
        'txtTitleO
        '
        Me.txtTitleO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitleO.Location = New System.Drawing.Point(1361, 152)
        Me.txtTitleO.Name = "txtTitleO"
        Me.txtTitleO.Size = New System.Drawing.Size(293, 21)
        Me.txtTitleO.TabIndex = 146
        Me.txtTitleO.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Title"
        '
        'txtTTitle
        '
        Me.txtTTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTTitle.Location = New System.Drawing.Point(73, 39)
        Me.txtTTitle.MaxLength = 1250
        Me.txtTTitle.Name = "txtTTitle"
        Me.txtTTitle.Size = New System.Drawing.Size(1058, 21)
        Me.txtTTitle.TabIndex = 144
        '
        'Mkc_ColorCombobox2T
        '
        Me.Mkc_ColorCombobox2T.AccessibleName = ""
        Me.Mkc_ColorCombobox2T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox2T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox2T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox2T.Location = New System.Drawing.Point(584, 155)
        Me.Mkc_ColorCombobox2T.Name = "Mkc_ColorCombobox2T"
        Me.Mkc_ColorCombobox2T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox2T.Size = New System.Drawing.Size(255, 30)
        Me.Mkc_ColorCombobox2T.TabIndex = 143
        Me.Mkc_ColorCombobox2T.Tag = "VF"
        Me.Mkc_ColorCombobox2T.Visible = False
        '
        'Mkc_ColorCombobox1T
        '
        Me.Mkc_ColorCombobox1T.AccessibleName = ""
        Me.Mkc_ColorCombobox1T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox1T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox1T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox1T.Location = New System.Drawing.Point(584, 127)
        Me.Mkc_ColorCombobox1T.Name = "Mkc_ColorCombobox1T"
        Me.Mkc_ColorCombobox1T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox1T.Size = New System.Drawing.Size(255, 30)
        Me.Mkc_ColorCombobox1T.TabIndex = 142
        Me.Mkc_ColorCombobox1T.Tag = "VF"
        Me.Mkc_ColorCombobox1T.Visible = False
        '
        'cbBC
        '
        Me.cbBC.AccessibleName = ""
        Me.cbBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBC.Location = New System.Drawing.Point(429, 155)
        Me.cbBC.Name = "cbBC"
        Me.cbBC.Size = New System.Drawing.Size(155, 26)
        Me.cbBC.TabIndex = 141
        Me.cbBC.Text = "Back color"
        '
        'cbFC
        '
        Me.cbFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFC.Location = New System.Drawing.Point(429, 127)
        Me.cbFC.Name = "cbFC"
        Me.cbFC.Size = New System.Drawing.Size(155, 26)
        Me.cbFC.TabIndex = 140
        Me.cbFC.Text = "Fore color"
        '
        'cbN
        '
        Me.cbN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbN.Location = New System.Drawing.Point(731, 78)
        Me.cbN.Name = "cbN"
        Me.cbN.Size = New System.Drawing.Size(346, 26)
        Me.cbN.TabIndex = 115
        Me.cbN.Text = "Without DB table name in title"
        '
        'tbH
        '
        Me.tbH.AccessibleName = "lHeight"
        Me.tbH.LargeChange = 1
        Me.tbH.Location = New System.Drawing.Point(576, 78)
        Me.tbH.Maximum = 5
        Me.tbH.Minimum = 1
        Me.tbH.Name = "tbH"
        Me.tbH.Size = New System.Drawing.Size(145, 45)
        Me.tbH.TabIndex = 114
        Me.tbH.TabStop = False
        Me.tbH.Tag = "1"
        Me.tbH.Value = 1
        Me.tbH.Visible = False
        '
        'cbH
        '
        Me.cbH.AccessibleName = ""
        Me.cbH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbH.Location = New System.Drawing.Point(429, 81)
        Me.cbH.Name = "cbH"
        Me.cbH.Size = New System.Drawing.Size(155, 26)
        Me.cbH.TabIndex = 108
        Me.cbH.Text = "Title height"
        '
        'txtTL1
        '
        Me.txtTL1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL1.Location = New System.Drawing.Point(0, 0)
        Me.txtTL1.Multiline = True
        Me.txtTL1.Name = "txtTL1"
        Me.txtTL1.ReadOnly = True
        Me.txtTL1.Size = New System.Drawing.Size(534, 30)
        Me.txtTL1.TabIndex = 0
        Me.txtTL1.TabStop = False
        Me.txtTL1.Tag = "VP"
        Me.txtTL1.Text = "Title"
        '
        'cbAR
        '
        Me.cbAR.AccessibleName = "lRightA"
        Me.cbAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAR.Location = New System.Drawing.Point(3, 157)
        Me.cbAR.Name = "cbAR"
        Me.cbAR.Size = New System.Drawing.Size(222, 26)
        Me.cbAR.TabIndex = 107
        Me.cbAR.Text = "Aligment right"
        '
        'cbI
        '
        Me.cbI.AccessibleName = "fontItalic"
        Me.cbI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbI.Location = New System.Drawing.Point(3, 104)
        Me.cbI.Name = "cbI"
        Me.cbI.Size = New System.Drawing.Size(122, 26)
        Me.cbI.TabIndex = 109
        Me.cbI.Text = "Italic"
        '
        'cbTBold
        '
        Me.cbTBold.AccessibleDescription = ""
        Me.cbTBold.AccessibleName = "fontBold"
        Me.cbTBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTBold.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTBold.Location = New System.Drawing.Point(3, 78)
        Me.cbTBold.Name = "cbTBold"
        Me.cbTBold.Size = New System.Drawing.Size(122, 26)
        Me.cbTBold.TabIndex = 105
        Me.cbTBold.Tag = ""
        Me.cbTBold.Text = "Bold"
        '
        'cbTAC
        '
        Me.cbTAC.AccessibleName = "lCenterA"
        Me.cbTAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTAC.Location = New System.Drawing.Point(3, 130)
        Me.cbTAC.Name = "cbTAC"
        Me.cbTAC.Size = New System.Drawing.Size(222, 26)
        Me.cbTAC.TabIndex = 106
        Me.cbTAC.Text = "Aligment center"
        '
        'cbS
        '
        Me.cbS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbS.Location = New System.Drawing.Point(216, 78)
        Me.cbS.Name = "cbS"
        Me.cbS.Size = New System.Drawing.Size(91, 26)
        Me.cbS.TabIndex = 113
        Me.cbS.Text = "Font size"
        '
        'paneT4
        '
        Me.paneT4.Controls.Add(Me.lbOnSaveExec)
        Me.paneT4.Controls.Add(Me.btnT4OK)
        Me.paneT4.Controls.Add(Me.btnT4Cancel)
        Me.paneT4.Controls.Add(Me.dgvOnSaveExec)
        Me.paneT4.Controls.Add(Me.txtTL4)
        Me.paneT4.Location = New System.Drawing.Point(3, 275)
        Me.paneT4.Name = "paneT4"
        Me.paneT4.Size = New System.Drawing.Size(534, 50)
        Me.paneT4.TabIndex = 150
        Me.paneT4.Tag = "210"
        '
        'lbOnSaveExec
        '
        Me.lbOnSaveExec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbOnSaveExec.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbOnSaveExec.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbOnSaveExec.FormattingEnabled = True
        Me.lbOnSaveExec.Location = New System.Drawing.Point(245, 30)
        Me.lbOnSaveExec.Name = "lbOnSaveExec"
        Me.lbOnSaveExec.Size = New System.Drawing.Size(289, 20)
        Me.lbOnSaveExec.TabIndex = 174
        '
        'btnT4OK
        '
        Me.btnT4OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT4OK.Location = New System.Drawing.Point(4, 257)
        Me.btnT4OK.Name = "btnT4OK"
        Me.btnT4OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT4OK.TabIndex = 170
        Me.btnT4OK.Tag = "4"
        Me.btnT4OK.Text = "OK"
        Me.btnT4OK.UseVisualStyleBackColor = True
        '
        'btnT4Cancel
        '
        Me.btnT4Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT4Cancel.Location = New System.Drawing.Point(146, 257)
        Me.btnT4Cancel.Name = "btnT4Cancel"
        Me.btnT4Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT4Cancel.TabIndex = 169
        Me.btnT4Cancel.Tag = "4"
        Me.btnT4Cancel.Text = "Cancel"
        Me.btnT4Cancel.UseVisualStyleBackColor = True
        '
        'dgvOnSaveExec
        '
        Me.dgvOnSaveExec.AllowDrop = True
        Me.dgvOnSaveExec.AllowUserToOrderColumns = True
        Me.dgvOnSaveExec.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveExec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveExec.ColumnHeadersHeight = 30
        Me.dgvOnSaveExec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveExec.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOnSaveExec.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveExec.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveExec.Location = New System.Drawing.Point(0, 28)
        Me.dgvOnSaveExec.MultiSelect = False
        Me.dgvOnSaveExec.Name = "dgvOnSaveExec"
        Me.dgvOnSaveExec.RowHeadersWidth = 33
        Me.dgvOnSaveExec.RowTemplate.Height = 30
        Me.dgvOnSaveExec.Size = New System.Drawing.Size(418, 220)
        Me.dgvOnSaveExec.TabIndex = 168
        Me.dgvOnSaveExec.Tag = "13"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.HeaderText = "On Save button EXECUTE stored procedure"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 300
        '
        'txtTL4
        '
        Me.txtTL4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL4.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL4.Location = New System.Drawing.Point(0, 0)
        Me.txtTL4.Multiline = True
        Me.txtTL4.Name = "txtTL4"
        Me.txtTL4.ReadOnly = True
        Me.txtTL4.Size = New System.Drawing.Size(534, 30)
        Me.txtTL4.TabIndex = 2
        Me.txtTL4.TabStop = False
        Me.txtTL4.Tag = "VP"
        Me.txtTL4.Text = "OnSaveButton.Click Event"
        '
        'paneT5
        '
        Me.paneT5.Controls.Add(Me.btnT5OK)
        Me.paneT5.Controls.Add(Me.btnT5Cancel)
        Me.paneT5.Controls.Add(Me.TabControl1)
        Me.paneT5.Controls.Add(Me.cbOnSaveNextDontClose)
        Me.paneT5.Controls.Add(Me.txtTL5)
        Me.paneT5.Location = New System.Drawing.Point(3, 331)
        Me.paneT5.Name = "paneT5"
        Me.paneT5.Size = New System.Drawing.Size(534, 50)
        Me.paneT5.TabIndex = 151
        Me.paneT5.Tag = "450"
        '
        'btnT5OK
        '
        Me.btnT5OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT5OK.Location = New System.Drawing.Point(11, 323)
        Me.btnT5OK.Name = "btnT5OK"
        Me.btnT5OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT5OK.TabIndex = 151
        Me.btnT5OK.Tag = "5"
        Me.btnT5OK.Text = "OK"
        Me.btnT5OK.UseVisualStyleBackColor = True
        '
        'btnT5Cancel
        '
        Me.btnT5Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT5Cancel.Location = New System.Drawing.Point(150, 323)
        Me.btnT5Cancel.Name = "btnT5Cancel"
        Me.btnT5Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT5Cancel.TabIndex = 150
        Me.btnT5Cancel.Tag = "5"
        Me.btnT5Cancel.Text = "Cancel"
        Me.btnT5Cancel.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage41)
        Me.TabControl1.Controls.Add(Me.TabPage42)
        Me.TabControl1.Controls.Add(Me.TabPage43)
        Me.TabControl1.Controls.Add(Me.TabPage44)
        Me.TabControl1.Controls.Add(Me.TabPage45)
        Me.TabControl1.Controls.Add(Me.TabPage46)
        Me.TabControl1.Controls.Add(Me.TabPage47)
        Me.TabControl1.Controls.Add(Me.TabPage48)
        Me.TabControl1.Location = New System.Drawing.Point(11, 76)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(500, 220)
        Me.TabControl1.TabIndex = 135
        '
        'TabPage41
        '
        Me.TabPage41.Controls.Add(Me.dgvOnSaveNextStop)
        Me.TabPage41.Location = New System.Drawing.Point(4, 22)
        Me.TabPage41.Name = "TabPage41"
        Me.TabPage41.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage41.Size = New System.Drawing.Size(492, 194)
        Me.TabPage41.TabIndex = 0
        Me.TabPage41.Text = "Stop"
        Me.TabPage41.UseVisualStyleBackColor = True
        '
        'dgvOnSaveNextStop
        '
        Me.dgvOnSaveNextStop.AllowDrop = True
        Me.dgvOnSaveNextStop.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextStop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextStop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextStop.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextStop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cIF, Me.cMSG})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextStop.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvOnSaveNextStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextStop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextStop.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextStop.Location = New System.Drawing.Point(3, 3)
        Me.dgvOnSaveNextStop.MultiSelect = False
        Me.dgvOnSaveNextStop.Name = "dgvOnSaveNextStop"
        Me.dgvOnSaveNextStop.RowHeadersWidth = 33
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextStop.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvOnSaveNextStop.RowTemplate.Height = 30
        Me.dgvOnSaveNextStop.Size = New System.Drawing.Size(486, 188)
        Me.dgvOnSaveNextStop.TabIndex = 156
        Me.dgvOnSaveNextStop.Tag = "0"
        '
        'cIF
        '
        Me.cIF.HeaderText = "On SaveNext button stop if "
        Me.cIF.Name = "cIF"
        Me.cIF.Width = 300
        '
        'cMSG
        '
        Me.cMSG.HeaderText = "Message"
        Me.cMSG.Name = "cMSG"
        Me.cMSG.Width = 300
        '
        'TabPage42
        '
        Me.TabPage42.Controls.Add(Me.dgvOnSaveNextNote)
        Me.TabPage42.Location = New System.Drawing.Point(4, 23)
        Me.TabPage42.Name = "TabPage42"
        Me.TabPage42.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage42.Size = New System.Drawing.Size(492, 193)
        Me.TabPage42.TabIndex = 1
        Me.TabPage42.Text = "Note"
        Me.TabPage42.UseVisualStyleBackColor = True
        '
        'dgvOnSaveNextNote
        '
        Me.dgvOnSaveNextNote.AllowDrop = True
        Me.dgvOnSaveNextNote.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextNote.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextNote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextNote.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextNote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOnSaveNextNote.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvOnSaveNextNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextNote.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextNote.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextNote.Location = New System.Drawing.Point(3, 3)
        Me.dgvOnSaveNextNote.MultiSelect = False
        Me.dgvOnSaveNextNote.Name = "dgvOnSaveNextNote"
        Me.dgvOnSaveNextNote.RowHeadersWidth = 40
        Me.dgvOnSaveNextNote.RowTemplate.Height = 30
        Me.dgvOnSaveNextNote.Size = New System.Drawing.Size(486, 187)
        Me.dgvOnSaveNextNote.TabIndex = 159
        Me.dgvOnSaveNextNote.Tag = "1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "On SaveNext button note if"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 300
        '
        'TabPage43
        '
        Me.TabPage43.Controls.Add(Me.dgvOnSaveNextSimpleMSG)
        Me.TabPage43.Location = New System.Drawing.Point(4, 23)
        Me.TabPage43.Name = "TabPage43"
        Me.TabPage43.Size = New System.Drawing.Size(492, 193)
        Me.TabPage43.TabIndex = 2
        Me.TabPage43.Text = "Simple message"
        Me.TabPage43.UseVisualStyleBackColor = True
        '
        'dgvOnSaveNextSimpleMSG
        '
        Me.dgvOnSaveNextSimpleMSG.AllowDrop = True
        Me.dgvOnSaveNextSimpleMSG.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextSimpleMSG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextSimpleMSG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextSimpleMSG.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextSimpleMSG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextSimpleMSG.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvOnSaveNextSimpleMSG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextSimpleMSG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextSimpleMSG.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextSimpleMSG.Location = New System.Drawing.Point(0, 0)
        Me.dgvOnSaveNextSimpleMSG.MultiSelect = False
        Me.dgvOnSaveNextSimpleMSG.Name = "dgvOnSaveNextSimpleMSG"
        Me.dgvOnSaveNextSimpleMSG.RowHeadersWidth = 40
        Me.dgvOnSaveNextSimpleMSG.RowTemplate.Height = 30
        Me.dgvOnSaveNextSimpleMSG.Size = New System.Drawing.Size(492, 193)
        Me.dgvOnSaveNextSimpleMSG.TabIndex = 160
        Me.dgvOnSaveNextSimpleMSG.Tag = "2"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "On SaveNext button simple message if"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 300
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 300
        '
        'TabPage44
        '
        Me.TabPage44.Controls.Add(Me.dgvOnSaveNextMSG)
        Me.TabPage44.Location = New System.Drawing.Point(4, 23)
        Me.TabPage44.Name = "TabPage44"
        Me.TabPage44.Size = New System.Drawing.Size(492, 193)
        Me.TabPage44.TabIndex = 3
        Me.TabPage44.Text = "Message"
        Me.TabPage44.UseVisualStyleBackColor = True
        '
        'dgvOnSaveNextMSG
        '
        Me.dgvOnSaveNextMSG.AllowDrop = True
        Me.dgvOnSaveNextMSG.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextMSG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextMSG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextMSG.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextMSG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextMSG.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvOnSaveNextMSG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextMSG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextMSG.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextMSG.Location = New System.Drawing.Point(0, 0)
        Me.dgvOnSaveNextMSG.MultiSelect = False
        Me.dgvOnSaveNextMSG.Name = "dgvOnSaveNextMSG"
        Me.dgvOnSaveNextMSG.RowHeadersWidth = 40
        Me.dgvOnSaveNextMSG.RowTemplate.Height = 30
        Me.dgvOnSaveNextMSG.Size = New System.Drawing.Size(492, 193)
        Me.dgvOnSaveNextMSG.TabIndex = 161
        Me.dgvOnSaveNextMSG.Tag = "3"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "On SaveNext button message if"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 300
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 300
        '
        'TabPage45
        '
        Me.TabPage45.Controls.Add(Me.dgvOnSaveNextClose)
        Me.TabPage45.Location = New System.Drawing.Point(4, 23)
        Me.TabPage45.Name = "TabPage45"
        Me.TabPage45.Size = New System.Drawing.Size(492, 193)
        Me.TabPage45.TabIndex = 4
        Me.TabPage45.Text = "Close form"
        Me.TabPage45.UseVisualStyleBackColor = True
        '
        'dgvOnSaveNextClose
        '
        Me.dgvOnSaveNextClose.AllowDrop = True
        Me.dgvOnSaveNextClose.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextClose.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextClose.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextClose.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextClose.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextClose.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvOnSaveNextClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextClose.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextClose.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextClose.Location = New System.Drawing.Point(0, 0)
        Me.dgvOnSaveNextClose.MultiSelect = False
        Me.dgvOnSaveNextClose.Name = "dgvOnSaveNextClose"
        Me.dgvOnSaveNextClose.RowHeadersWidth = 40
        Me.dgvOnSaveNextClose.RowTemplate.Height = 30
        Me.dgvOnSaveNextClose.Size = New System.Drawing.Size(492, 193)
        Me.dgvOnSaveNextClose.TabIndex = 162
        Me.dgvOnSaveNextClose.Tag = "4"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "On SaveNext button close form if"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 300
        '
        'TabPage46
        '
        Me.TabPage46.Controls.Add(Me.dgvOnSaveNextFocusOn)
        Me.TabPage46.Location = New System.Drawing.Point(4, 23)
        Me.TabPage46.Name = "TabPage46"
        Me.TabPage46.Size = New System.Drawing.Size(492, 193)
        Me.TabPage46.TabIndex = 5
        Me.TabPage46.Text = "Focus on"
        Me.TabPage46.UseVisualStyleBackColor = True
        '
        'dgvOnSaveNextFocusOn
        '
        Me.dgvOnSaveNextFocusOn.AllowDrop = True
        Me.dgvOnSaveNextFocusOn.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextFocusOn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextFocusOn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextFocusOn.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextFocusOn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextFocusOn.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvOnSaveNextFocusOn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextFocusOn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextFocusOn.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextFocusOn.Location = New System.Drawing.Point(0, 0)
        Me.dgvOnSaveNextFocusOn.MultiSelect = False
        Me.dgvOnSaveNextFocusOn.Name = "dgvOnSaveNextFocusOn"
        Me.dgvOnSaveNextFocusOn.RowHeadersWidth = 40
        Me.dgvOnSaveNextFocusOn.RowTemplate.Height = 30
        Me.dgvOnSaveNextFocusOn.Size = New System.Drawing.Size(492, 193)
        Me.dgvOnSaveNextFocusOn.TabIndex = 157
        Me.dgvOnSaveNextFocusOn.Tag = "5"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "On SaveNext button focus if"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Focus on"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 300
        '
        'TabPage47
        '
        Me.TabPage47.Controls.Add(Me.dgvOnSaveNextDelete)
        Me.TabPage47.Location = New System.Drawing.Point(4, 23)
        Me.TabPage47.Name = "TabPage47"
        Me.TabPage47.Size = New System.Drawing.Size(492, 193)
        Me.TabPage47.TabIndex = 6
        Me.TabPage47.Text = "Delete"
        Me.TabPage47.UseVisualStyleBackColor = True
        '
        'dgvOnSaveNextDelete
        '
        Me.dgvOnSaveNextDelete.AllowDrop = True
        Me.dgvOnSaveNextDelete.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextDelete.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextDelete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextDelete.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextDelete.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextDelete.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvOnSaveNextDelete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextDelete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextDelete.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextDelete.Location = New System.Drawing.Point(0, 0)
        Me.dgvOnSaveNextDelete.MultiSelect = False
        Me.dgvOnSaveNextDelete.Name = "dgvOnSaveNextDelete"
        Me.dgvOnSaveNextDelete.RowHeadersWidth = 40
        Me.dgvOnSaveNextDelete.RowTemplate.Height = 30
        Me.dgvOnSaveNextDelete.Size = New System.Drawing.Size(492, 193)
        Me.dgvOnSaveNextDelete.TabIndex = 157
        Me.dgvOnSaveNextDelete.Tag = "6"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "On Save button delete if"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 300
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Delete from (table names separated by comma)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'TabPage48
        '
        Me.TabPage48.Controls.Add(Me.lbOnSaveNextExec)
        Me.TabPage48.Controls.Add(Me.dgvOnSaveNextExec)
        Me.TabPage48.Location = New System.Drawing.Point(4, 23)
        Me.TabPage48.Name = "TabPage48"
        Me.TabPage48.Size = New System.Drawing.Size(492, 193)
        Me.TabPage48.TabIndex = 7
        Me.TabPage48.Text = "Exec"
        Me.TabPage48.UseVisualStyleBackColor = True
        '
        'lbOnSaveNextExec
        '
        Me.lbOnSaveNextExec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbOnSaveNextExec.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbOnSaveNextExec.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbOnSaveNextExec.FormattingEnabled = True
        Me.lbOnSaveNextExec.Location = New System.Drawing.Point(10, 0)
        Me.lbOnSaveNextExec.Name = "lbOnSaveNextExec"
        Me.lbOnSaveNextExec.Size = New System.Drawing.Size(482, 193)
        Me.lbOnSaveNextExec.TabIndex = 175
        '
        'dgvOnSaveNextExec
        '
        Me.dgvOnSaveNextExec.AllowDrop = True
        Me.dgvOnSaveNextExec.AllowUserToOrderColumns = True
        Me.dgvOnSaveNextExec.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnSaveNextExec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnSaveNextExec.ColumnHeadersHeight = 30
        Me.dgvOnSaveNextExec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnSaveNextExec.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvOnSaveNextExec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOnSaveNextExec.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnSaveNextExec.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnSaveNextExec.Location = New System.Drawing.Point(0, 0)
        Me.dgvOnSaveNextExec.MultiSelect = False
        Me.dgvOnSaveNextExec.Name = "dgvOnSaveNextExec"
        Me.dgvOnSaveNextExec.RowHeadersWidth = 40
        Me.dgvOnSaveNextExec.RowTemplate.Height = 30
        Me.dgvOnSaveNextExec.Size = New System.Drawing.Size(492, 193)
        Me.dgvOnSaveNextExec.TabIndex = 165
        Me.dgvOnSaveNextExec.Tag = "7"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "On SaveNext button EXECUTE stored procedure"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 300
        '
        'cbOnSaveNextDontClose
        '
        Me.cbOnSaveNextDontClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOnSaveNextDontClose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOnSaveNextDontClose.Location = New System.Drawing.Point(19, 43)
        Me.cbOnSaveNextDontClose.Name = "cbOnSaveNextDontClose"
        Me.cbOnSaveNextDontClose.Size = New System.Drawing.Size(241, 26)
        Me.cbOnSaveNextDontClose.TabIndex = 134
        Me.cbOnSaveNextDontClose.Tag = "OnSaveNextDontClose"
        Me.cbOnSaveNextDontClose.Text = "Don't close form"
        '
        'txtTL5
        '
        Me.txtTL5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL5.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL5.Location = New System.Drawing.Point(0, 0)
        Me.txtTL5.Multiline = True
        Me.txtTL5.Name = "txtTL5"
        Me.txtTL5.ReadOnly = True
        Me.txtTL5.Size = New System.Drawing.Size(534, 30)
        Me.txtTL5.TabIndex = 2
        Me.txtTL5.TabStop = False
        Me.txtTL5.Tag = "VP"
        Me.txtTL5.Text = "OnSaveNextButton.Click Event"
        '
        'paneT6
        '
        Me.paneT6.Controls.Add(Me.btnT6OK)
        Me.paneT6.Controls.Add(Me.btnT6Cancel)
        Me.paneT6.Controls.Add(Me.dgvOnExitMSG)
        Me.paneT6.Controls.Add(Me.txtTL6)
        Me.paneT6.Location = New System.Drawing.Point(3, 387)
        Me.paneT6.Name = "paneT6"
        Me.paneT6.Size = New System.Drawing.Size(534, 50)
        Me.paneT6.TabIndex = 152
        Me.paneT6.Tag = "400"
        '
        'btnT6OK
        '
        Me.btnT6OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT6OK.Location = New System.Drawing.Point(9, 259)
        Me.btnT6OK.Name = "btnT6OK"
        Me.btnT6OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT6OK.TabIndex = 172
        Me.btnT6OK.Tag = "6"
        Me.btnT6OK.Text = "OK"
        Me.btnT6OK.UseVisualStyleBackColor = True
        '
        'btnT6Cancel
        '
        Me.btnT6Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT6Cancel.Location = New System.Drawing.Point(146, 259)
        Me.btnT6Cancel.Name = "btnT6Cancel"
        Me.btnT6Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT6Cancel.TabIndex = 171
        Me.btnT6Cancel.Tag = "6"
        Me.btnT6Cancel.Text = "Cancel"
        Me.btnT6Cancel.UseVisualStyleBackColor = True
        '
        'dgvOnExitMSG
        '
        Me.dgvOnExitMSG.AllowDrop = True
        Me.dgvOnExitMSG.AllowUserToOrderColumns = True
        Me.dgvOnExitMSG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvOnExitMSG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOnExitMSG.ColumnHeadersHeight = 30
        Me.dgvOnExitMSG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOnExitMSG.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvOnExitMSG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvOnExitMSG.GridColor = System.Drawing.SystemColors.Control
        Me.dgvOnExitMSG.Location = New System.Drawing.Point(0, 28)
        Me.dgvOnExitMSG.MultiSelect = False
        Me.dgvOnExitMSG.Name = "dgvOnExitMSG"
        Me.dgvOnExitMSG.RowHeadersWidth = 33
        Me.dgvOnExitMSG.RowTemplate.Height = 30
        Me.dgvOnExitMSG.Size = New System.Drawing.Size(671, 220)
        Me.dgvOnExitMSG.TabIndex = 164
        Me.dgvOnExitMSG.Tag = "8"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "On Exit button message if"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 300
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 300
        '
        'txtTL6
        '
        Me.txtTL6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL6.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL6.Location = New System.Drawing.Point(0, 0)
        Me.txtTL6.Multiline = True
        Me.txtTL6.Name = "txtTL6"
        Me.txtTL6.ReadOnly = True
        Me.txtTL6.Size = New System.Drawing.Size(534, 30)
        Me.txtTL6.TabIndex = 2
        Me.txtTL6.TabStop = False
        Me.txtTL6.Tag = "VP"
        Me.txtTL6.Text = "OnExitButton.Click Event"
        '
        'paneT7
        '
        Me.paneT7.Controls.Add(Me.btnT7OK)
        Me.paneT7.Controls.Add(Me.btnT7Cancel)
        Me.paneT7.Controls.Add(Me.tbNFS)
        Me.paneT7.Controls.Add(Me.txtSY)
        Me.paneT7.Controls.Add(Me.Label17)
        Me.paneT7.Controls.Add(Me.Label21)
        Me.paneT7.Controls.Add(Me.Label22)
        Me.paneT7.Controls.Add(Me.txtSX)
        Me.paneT7.Controls.Add(Me.lblNoteDefaultText)
        Me.paneT7.Controls.Add(Me.Mkc_ColorCombobox5T)
        Me.paneT7.Controls.Add(Me.Mkc_ColorCombobox6T)
        Me.paneT7.Controls.Add(Me.cbNoteBC)
        Me.paneT7.Controls.Add(Me.cbNoteFC)
        Me.paneT7.Controls.Add(Me.txtNote)
        Me.paneT7.Controls.Add(Me.cbNoteS)
        Me.paneT7.Controls.Add(Me.txtNY)
        Me.paneT7.Controls.Add(Me.Label12)
        Me.paneT7.Controls.Add(Me.Label13)
        Me.paneT7.Controls.Add(Me.Label15)
        Me.paneT7.Controls.Add(Me.txtNX)
        Me.paneT7.Controls.Add(Me.txtTL7)
        Me.paneT7.Location = New System.Drawing.Point(3, 443)
        Me.paneT7.Name = "paneT7"
        Me.paneT7.Size = New System.Drawing.Size(534, 50)
        Me.paneT7.TabIndex = 153
        Me.paneT7.Tag = "300"
        '
        'btnT7OK
        '
        Me.btnT7OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT7OK.Location = New System.Drawing.Point(0, 291)
        Me.btnT7OK.Name = "btnT7OK"
        Me.btnT7OK.Size = New System.Drawing.Size(128, 31)
        Me.btnT7OK.TabIndex = 168
        Me.btnT7OK.Tag = "7"
        Me.btnT7OK.Text = "OK"
        Me.btnT7OK.UseVisualStyleBackColor = True
        '
        'btnT7Cancel
        '
        Me.btnT7Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnT7Cancel.Location = New System.Drawing.Point(138, 291)
        Me.btnT7Cancel.Name = "btnT7Cancel"
        Me.btnT7Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnT7Cancel.TabIndex = 167
        Me.btnT7Cancel.Tag = "7"
        Me.btnT7Cancel.Text = "Cancel"
        Me.btnT7Cancel.UseVisualStyleBackColor = True
        '
        'tbNFS
        '
        Me.tbNFS.AccessibleName = "lHeight"
        Me.tbNFS.LargeChange = 1
        Me.tbNFS.Location = New System.Drawing.Point(706, 59)
        Me.tbNFS.Maximum = 20
        Me.tbNFS.Minimum = 6
        Me.tbNFS.Name = "tbNFS"
        Me.tbNFS.Size = New System.Drawing.Size(145, 45)
        Me.tbNFS.TabIndex = 166
        Me.tbNFS.TabStop = False
        Me.tbNFS.Tag = "8"
        Me.tbNFS.TickFrequency = 2
        Me.tbNFS.Value = 8
        Me.tbNFS.Visible = False
        '
        'txtSY
        '
        Me.txtSY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSY.Location = New System.Drawing.Point(538, 35)
        Me.txtSY.Name = "txtSY"
        Me.txtSY.Size = New System.Drawing.Size(75, 21)
        Me.txtSY.TabIndex = 162
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(376, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 165
        Me.Label17.Text = "Size"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(519, 35)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 13)
        Me.Label21.TabIndex = 164
        Me.Label21.Text = "Y"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(414, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 13)
        Me.Label22.TabIndex = 163
        Me.Label22.Text = "X"
        '
        'txtSX
        '
        Me.txtSX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSX.Location = New System.Drawing.Point(435, 35)
        Me.txtSX.Name = "txtSX"
        Me.txtSX.Size = New System.Drawing.Size(75, 21)
        Me.txtSX.TabIndex = 161
        '
        'lblNoteDefaultText
        '
        Me.lblNoteDefaultText.AutoSize = True
        Me.lblNoteDefaultText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoteDefaultText.Location = New System.Drawing.Point(9, 130)
        Me.lblNoteDefaultText.Name = "lblNoteDefaultText"
        Me.lblNoteDefaultText.Size = New System.Drawing.Size(74, 13)
        Me.lblNoteDefaultText.TabIndex = 152
        Me.lblNoteDefaultText.Text = "Default text"
        '
        'Mkc_ColorCombobox5T
        '
        Me.Mkc_ColorCombobox5T.AutoSize = True
        Me.Mkc_ColorCombobox5T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox5T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox5T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox5T.Location = New System.Drawing.Point(112, 65)
        Me.Mkc_ColorCombobox5T.Name = "Mkc_ColorCombobox5T"
        Me.Mkc_ColorCombobox5T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox5T.Size = New System.Drawing.Size(255, 21)
        Me.Mkc_ColorCombobox5T.TabIndex = 160
        Me.Mkc_ColorCombobox5T.Tag = "VF"
        Me.Mkc_ColorCombobox5T.Visible = False
        '
        'Mkc_ColorCombobox6T
        '
        Me.Mkc_ColorCombobox6T.AutoSize = True
        Me.Mkc_ColorCombobox6T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox6T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox6T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox6T.Location = New System.Drawing.Point(112, 92)
        Me.Mkc_ColorCombobox6T.Name = "Mkc_ColorCombobox6T"
        Me.Mkc_ColorCombobox6T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox6T.Size = New System.Drawing.Size(255, 21)
        Me.Mkc_ColorCombobox6T.TabIndex = 159
        Me.Mkc_ColorCombobox6T.Tag = "VF"
        Me.Mkc_ColorCombobox6T.Visible = False
        '
        'cbNoteBC
        '
        Me.cbNoteBC.AutoSize = True
        Me.cbNoteBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoteBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoteBC.Location = New System.Drawing.Point(9, 92)
        Me.cbNoteBC.Name = "cbNoteBC"
        Me.cbNoteBC.Size = New System.Drawing.Size(83, 17)
        Me.cbNoteBC.TabIndex = 158
        Me.cbNoteBC.Text = "Back color"
        '
        'cbNoteFC
        '
        Me.cbNoteFC.AutoSize = True
        Me.cbNoteFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoteFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoteFC.Location = New System.Drawing.Point(9, 65)
        Me.cbNoteFC.Name = "cbNoteFC"
        Me.cbNoteFC.Size = New System.Drawing.Size(80, 17)
        Me.cbNoteFC.TabIndex = 157
        Me.cbNoteFC.Text = "Fore color"
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNote.Location = New System.Drawing.Point(0, 151)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(995, 128)
        Me.txtNote.TabIndex = 145
        '
        'cbNoteS
        '
        Me.cbNoteS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoteS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoteS.Location = New System.Drawing.Point(706, 32)
        Me.cbNoteS.Name = "cbNoteS"
        Me.cbNoteS.Size = New System.Drawing.Size(154, 26)
        Me.cbNoteS.TabIndex = 156
        Me.cbNoteS.Text = "Font size"
        '
        'txtNY
        '
        Me.txtNY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNY.Location = New System.Drawing.Point(230, 35)
        Me.txtNY.Name = "txtNY"
        Me.txtNY.Size = New System.Drawing.Size(75, 21)
        Me.txtNY.TabIndex = 148
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "Location"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(212, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 13)
        Me.Label13.TabIndex = 150
        Me.Label13.Text = "Y"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(110, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 13)
        Me.Label15.TabIndex = 149
        Me.Label15.Text = "X"
        '
        'txtNX
        '
        Me.txtNX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNX.Location = New System.Drawing.Point(129, 35)
        Me.txtNX.Name = "txtNX"
        Me.txtNX.Size = New System.Drawing.Size(75, 21)
        Me.txtNX.TabIndex = 147
        '
        'txtTL7
        '
        Me.txtTL7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtTL7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTL7.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTL7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTL7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtTL7.Location = New System.Drawing.Point(0, 0)
        Me.txtTL7.Multiline = True
        Me.txtTL7.Name = "txtTL7"
        Me.txtTL7.ReadOnly = True
        Me.txtTL7.Size = New System.Drawing.Size(534, 20)
        Me.txtTL7.TabIndex = 2
        Me.txtTL7.TabStop = False
        Me.txtTL7.Tag = "VP"
        Me.txtTL7.Text = "Note"
        '
        'TableLayoutPanelCOLUMN
        '
        Me.TableLayoutPanelCOLUMN.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TableLayoutPanelCOLUMN.ColumnCount = 1
        Me.TableLayoutPanelCOLUMN.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelCOLUMN.Controls.Add(Me.paneAC, 0, 1)
        Me.TableLayoutPanelCOLUMN.Controls.Add(Me.paneP0, 0, 2)
        Me.TableLayoutPanelCOLUMN.Controls.Add(Me.paneP1, 0, 3)
        Me.TableLayoutPanelCOLUMN.Controls.Add(Me.paneP2, 0, 4)
        Me.TableLayoutPanelCOLUMN.Controls.Add(Me.paneP21, 0, 5)
        Me.TableLayoutPanelCOLUMN.Controls.Add(Me.paneP3, 0, 6)
        Me.TableLayoutPanelCOLUMN.Controls.Add(Me.panePPreview, 0, 0)
        Me.TableLayoutPanelCOLUMN.Location = New System.Drawing.Point(555, 0)
        Me.TableLayoutPanelCOLUMN.Name = "TableLayoutPanelCOLUMN"
        Me.TableLayoutPanelCOLUMN.RowCount = 11
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelCOLUMN.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelCOLUMN.Size = New System.Drawing.Size(540, 471)
        Me.TableLayoutPanelCOLUMN.TabIndex = 1
        Me.TableLayoutPanelCOLUMN.Visible = False
        '
        'paneAC
        '
        Me.paneAC.Controls.Add(Me.cbPKAC)
        Me.paneAC.Controls.Add(Me.txtvdoAC)
        Me.paneAC.Controls.Add(Me.txtvodAC)
        Me.paneAC.Controls.Add(Me.txtlbl12AC)
        Me.paneAC.Controls.Add(Me.txtLabelAC)
        Me.paneAC.Controls.Add(Me.btnACCancel)
        Me.paneAC.Controls.Add(Me.btnACOK)
        Me.paneAC.Controls.Add(Me.lblDescriptionAC)
        Me.paneAC.Controls.Add(Me.txtLenAC)
        Me.paneAC.Controls.Add(Me.lblLntAC)
        Me.paneAC.Controls.Add(Me.lblTypeAC)
        Me.paneAC.Controls.Add(Me.cboTypeAC)
        Me.paneAC.Controls.Add(Me.Label25)
        Me.paneAC.Controls.Add(Me.Label26)
        Me.paneAC.Controls.Add(Me.gbOptionsAC)
        Me.paneAC.Controls.Add(Me.txtNameAC)
        Me.paneAC.Controls.Add(Me.txtCLAC)
        Me.paneAC.Controls.Add(Me.gbUC)
        Me.paneAC.Controls.Add(Me.cbAddUC)
        Me.paneAC.Location = New System.Drawing.Point(3, 122)
        Me.paneAC.Name = "paneAC"
        Me.paneAC.Size = New System.Drawing.Size(534, 50)
        Me.paneAC.TabIndex = 174
        Me.paneAC.Tag = "750"
        '
        'cbPKAC
        '
        Me.cbPKAC.AccessibleName = "P"
        Me.cbPKAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPKAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPKAC.Location = New System.Drawing.Point(176, 194)
        Me.cbPKAC.Name = "cbPKAC"
        Me.cbPKAC.Size = New System.Drawing.Size(222, 26)
        Me.cbPKAC.TabIndex = 175
        Me.cbPKAC.Text = "Primary key"
        '
        'txtvdoAC
        '
        Me.txtvdoAC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvdoAC.Location = New System.Drawing.Point(307, 253)
        Me.txtvdoAC.Name = "txtvdoAC"
        Me.txtvdoAC.Size = New System.Drawing.Size(129, 21)
        Me.txtvdoAC.TabIndex = 174
        '
        'txtvodAC
        '
        Me.txtvodAC.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvodAC.Location = New System.Drawing.Point(176, 253)
        Me.txtvodAC.Name = "txtvodAC"
        Me.txtvodAC.Size = New System.Drawing.Size(129, 21)
        Me.txtvodAC.TabIndex = 173
        '
        'txtlbl12AC
        '
        Me.txtlbl12AC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtlbl12AC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlbl12AC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtlbl12AC.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtlbl12AC.Location = New System.Drawing.Point(176, 224)
        Me.txtlbl12AC.Multiline = True
        Me.txtlbl12AC.Name = "txtlbl12AC"
        Me.txtlbl12AC.ReadOnly = True
        Me.txtlbl12AC.Size = New System.Drawing.Size(260, 30)
        Me.txtlbl12AC.TabIndex = 172
        Me.txtlbl12AC.TabStop = False
        Me.txtlbl12AC.Tag = "VP"
        Me.txtlbl12AC.Text = "Validity period"
        '
        'txtLabelAC
        '
        Me.txtLabelAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabelAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtLabelAC.Location = New System.Drawing.Point(176, 95)
        Me.txtLabelAC.Name = "txtLabelAC"
        Me.txtLabelAC.Size = New System.Drawing.Size(260, 20)
        Me.txtLabelAC.TabIndex = 171
        '
        'btnACCancel
        '
        Me.btnACCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnACCancel.Location = New System.Drawing.Point(1077, 249)
        Me.btnACCancel.Name = "btnACCancel"
        Me.btnACCancel.Size = New System.Drawing.Size(128, 31)
        Me.btnACCancel.TabIndex = 159
        Me.btnACCancel.Tag = "0"
        Me.btnACCancel.Text = "Cancel"
        Me.btnACCancel.UseVisualStyleBackColor = True
        '
        'btnACOK
        '
        Me.btnACOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnACOK.Location = New System.Drawing.Point(945, 249)
        Me.btnACOK.Name = "btnACOK"
        Me.btnACOK.Size = New System.Drawing.Size(128, 31)
        Me.btnACOK.TabIndex = 160
        Me.btnACOK.Tag = "0"
        Me.btnACOK.Text = "Submit"
        Me.btnACOK.UseVisualStyleBackColor = True
        '
        'lblDescriptionAC
        '
        Me.lblDescriptionAC.AutoSize = True
        Me.lblDescriptionAC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescriptionAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionAC.Location = New System.Drawing.Point(11, 95)
        Me.lblDescriptionAC.Name = "lblDescriptionAC"
        Me.lblDescriptionAC.Size = New System.Drawing.Size(37, 13)
        Me.lblDescriptionAC.TabIndex = 170
        Me.lblDescriptionAC.Text = "Label"
        '
        'txtLenAC
        '
        Me.txtLenAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLenAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtLenAC.Location = New System.Drawing.Point(176, 159)
        Me.txtLenAC.Name = "txtLenAC"
        Me.txtLenAC.Size = New System.Drawing.Size(260, 20)
        Me.txtLenAC.TabIndex = 169
        '
        'lblLntAC
        '
        Me.lblLntAC.AutoSize = True
        Me.lblLntAC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLntAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLntAC.Location = New System.Drawing.Point(11, 159)
        Me.lblLntAC.Name = "lblLntAC"
        Me.lblLntAC.Size = New System.Drawing.Size(72, 13)
        Me.lblLntAC.TabIndex = 168
        Me.lblLntAC.Text = "Max Length"
        '
        'lblTypeAC
        '
        Me.lblTypeAC.AutoSize = True
        Me.lblTypeAC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTypeAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTypeAC.Location = New System.Drawing.Point(11, 126)
        Me.lblTypeAC.Name = "lblTypeAC"
        Me.lblTypeAC.Size = New System.Drawing.Size(34, 13)
        Me.lblTypeAC.TabIndex = 167
        Me.lblTypeAC.Text = "Type"
        '
        'cboTypeAC
        '
        Me.cboTypeAC.CausesValidation = False
        Me.cboTypeAC.DropDownWidth = 500
        Me.cboTypeAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboTypeAC.FormattingEnabled = True
        Me.cboTypeAC.Items.AddRange(New Object() {"Integer (-2,147,483,648 to 2,147,483,647)", "Tiny integer (0 to 255)", "Small integer (-32,768 to 32,767)", "Big integer (-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)", "Character", "Decimal with 2 places", "Decimal with 5 places"})
        Me.cboTypeAC.Location = New System.Drawing.Point(176, 126)
        Me.cboTypeAC.Name = "cboTypeAC"
        Me.cboTypeAC.Size = New System.Drawing.Size(260, 21)
        Me.cboTypeAC.TabIndex = 166
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(11, 65)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 13)
        Me.Label25.TabIndex = 165
        Me.Label25.Text = "Control is textBox"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(11, 32)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 164
        Me.Label26.Text = "Name"
        '
        'gbOptionsAC
        '
        Me.gbOptionsAC.Controls.Add(Me.txtTotalAC)
        Me.gbOptionsAC.Controls.Add(Me.PanelAAT)
        Me.gbOptionsAC.Controls.Add(Me.Label95)
        Me.gbOptionsAC.Controls.Add(Me.cbTableAC)
        Me.gbOptionsAC.Controls.Add(Me.lblNumber1AC)
        Me.gbOptionsAC.Location = New System.Drawing.Point(17, 290)
        Me.gbOptionsAC.Name = "gbOptionsAC"
        Me.gbOptionsAC.Size = New System.Drawing.Size(1656, 612)
        Me.gbOptionsAC.TabIndex = 163
        Me.gbOptionsAC.TabStop = False
        Me.gbOptionsAC.Visible = False
        '
        'txtTotalAC
        '
        Me.txtTotalAC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalAC.Enabled = False
        Me.txtTotalAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtTotalAC.Location = New System.Drawing.Point(1549, 577)
        Me.txtTotalAC.Name = "txtTotalAC"
        Me.txtTotalAC.Size = New System.Drawing.Size(106, 13)
        Me.txtTotalAC.TabIndex = 51
        Me.txtTotalAC.Visible = False
        '
        'PanelAAT
        '
        Me.PanelAAT.Controls.Add(Me.Label98)
        Me.PanelAAT.Controls.Add(Me.txtColumnsStartFrom)
        Me.PanelAAT.Controls.Add(Me.txtRowsStartFrom)
        Me.PanelAAT.Controls.Add(Me.Label107)
        Me.PanelAAT.Controls.Add(Me.Mkc_tbc)
        Me.PanelAAT.Controls.Add(Me.Mkc_tfc)
        Me.PanelAAT.Controls.Add(Me.cbPFC)
        Me.PanelAAT.Controls.Add(Me.gbApp)
        Me.PanelAAT.Controls.Add(Me.txtNLR)
        Me.PanelAAT.Controls.Add(Me.Label121)
        Me.PanelAAT.Controls.Add(Me.txtColLen)
        Me.PanelAAT.Controls.Add(Me.Label100)
        Me.PanelAAT.Controls.Add(Me.txtNLC)
        Me.PanelAAT.Controls.Add(Me.Label99)
        Me.PanelAAT.Controls.Add(Me.cbTabDownLeft)
        Me.PanelAAT.Controls.Add(Me.txtAT2)
        Me.PanelAAT.Controls.Add(Me.Label29)
        Me.PanelAAT.Controls.Add(Me.txtRNAC)
        Me.PanelAAT.Controls.Add(Me.txtTNAC)
        Me.PanelAAT.Controls.Add(Me.txtCNAC)
        Me.PanelAAT.Controls.Add(Me.Label28)
        Me.PanelAAT.Controls.Add(Me.Label27)
        Me.PanelAAT.Controls.Add(Me.chbColumnsStartFrom)
        Me.PanelAAT.Controls.Add(Me.chbRowsStartFrom)
        Me.PanelAAT.Controls.Add(Me.cbTc6)
        Me.PanelAAT.Controls.Add(Me.cbTc5)
        Me.PanelAAT.Location = New System.Drawing.Point(15, 50)
        Me.PanelAAT.Name = "PanelAAT"
        Me.PanelAAT.Size = New System.Drawing.Size(1629, 523)
        Me.PanelAAT.TabIndex = 58
        Me.PanelAAT.Visible = False
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label98.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(1462, 5)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(31, 13)
        Me.Label98.TabIndex = 56
        Me.Label98.Text = "Title"
        '
        'txtColumnsStartFrom
        '
        Me.txtColumnsStartFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColumnsStartFrom.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtColumnsStartFrom.Location = New System.Drawing.Point(1000, 90)
        Me.txtColumnsStartFrom.Name = "txtColumnsStartFrom"
        Me.txtColumnsStartFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtColumnsStartFrom.TabIndex = 281
        Me.txtColumnsStartFrom.Tag = "VF"
        Me.txtColumnsStartFrom.Visible = False
        '
        'txtRowsStartFrom
        '
        Me.txtRowsStartFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRowsStartFrom.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtRowsStartFrom.Location = New System.Drawing.Point(1000, 62)
        Me.txtRowsStartFrom.Name = "txtRowsStartFrom"
        Me.txtRowsStartFrom.Size = New System.Drawing.Size(75, 20)
        Me.txtRowsStartFrom.TabIndex = 279
        Me.txtRowsStartFrom.Tag = "VF"
        Me.txtRowsStartFrom.Visible = False
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label107.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(563, 75)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(116, 13)
        Me.Label107.TabIndex = 284
        Me.Label107.Text = "Cell name iteration"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mkc_tbc
        '
        Me.Mkc_tbc.AccessibleName = ""
        Me.Mkc_tbc.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_tbc.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_tbc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_tbc.Location = New System.Drawing.Point(1267, 121)
        Me.Mkc_tbc.Name = "Mkc_tbc"
        Me.Mkc_tbc.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_tbc.Size = New System.Drawing.Size(254, 30)
        Me.Mkc_tbc.TabIndex = 189
        Me.Mkc_tbc.Tag = "VF"
        '
        'Mkc_tfc
        '
        Me.Mkc_tfc.AccessibleName = ""
        Me.Mkc_tfc.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_tfc.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_tfc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_tfc.Location = New System.Drawing.Point(1267, 93)
        Me.Mkc_tfc.Name = "Mkc_tfc"
        Me.Mkc_tfc.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_tfc.Size = New System.Drawing.Size(254, 30)
        Me.Mkc_tfc.TabIndex = 188
        Me.Mkc_tfc.Tag = "VF"
        '
        'cbPFC
        '
        Me.cbPFC.AutoSize = True
        Me.cbPFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPFC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbPFC.Location = New System.Drawing.Point(503, 157)
        Me.cbPFC.Name = "cbPFC"
        Me.cbPFC.Size = New System.Drawing.Size(339, 17)
        Me.cbPFC.TabIndex = 219
        Me.cbPFC.Text = "Formating priority - columns format above rows format"
        Me.cbPFC.UseVisualStyleBackColor = True
        '
        'gbApp
        '
        Me.gbApp.Controls.Add(Me.TabPageRa)
        Me.gbApp.Controls.Add(Me.TabPageCa)
        Me.gbApp.Location = New System.Drawing.Point(11, 156)
        Me.gbApp.Name = "gbApp"
        Me.gbApp.SelectedIndex = 0
        Me.gbApp.Size = New System.Drawing.Size(1743, 337)
        Me.gbApp.TabIndex = 218
        '
        'TabPageRa
        '
        Me.TabPageRa.AutoScroll = True
        Me.TabPageRa.Controls.Add(Me.r110)
        Me.TabPageRa.Controls.Add(Me.dgvAppR)
        Me.TabPageRa.Controls.Add(Me.r120)
        Me.TabPageRa.Controls.Add(Me.btnAppR)
        Me.TabPageRa.Controls.Add(Me.r6)
        Me.TabPageRa.Controls.Add(Me.Label127)
        Me.TabPageRa.Controls.Add(Me.r11)
        Me.TabPageRa.Controls.Add(Me.Label128)
        Me.TabPageRa.Controls.Add(Me.r12)
        Me.TabPageRa.Controls.Add(Me.Label129)
        Me.TabPageRa.Controls.Add(Me.r10)
        Me.TabPageRa.Controls.Add(Me.Label130)
        Me.TabPageRa.Controls.Add(Me.r9)
        Me.TabPageRa.Controls.Add(Me.Label131)
        Me.TabPageRa.Controls.Add(Me.r8)
        Me.TabPageRa.Controls.Add(Me.Label132)
        Me.TabPageRa.Controls.Add(Me.Label133)
        Me.TabPageRa.Controls.Add(Me.r7)
        Me.TabPageRa.Controls.Add(Me.Label134)
        Me.TabPageRa.Controls.Add(Me.Label135)
        Me.TabPageRa.Controls.Add(Me.r5)
        Me.TabPageRa.Controls.Add(Me.Label136)
        Me.TabPageRa.Controls.Add(Me.r4)
        Me.TabPageRa.Controls.Add(Me.r3)
        Me.TabPageRa.Controls.Add(Me.Label137)
        Me.TabPageRa.Controls.Add(Me.Label138)
        Me.TabPageRa.Controls.Add(Me.Label139)
        Me.TabPageRa.Controls.Add(Me.r2)
        Me.TabPageRa.Controls.Add(Me.Label140)
        Me.TabPageRa.Controls.Add(Me.r0)
        Me.TabPageRa.Controls.Add(Me.r1)
        Me.TabPageRa.Controls.Add(Me.Label141)
        Me.TabPageRa.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRa.Name = "TabPageRa"
        Me.TabPageRa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRa.Size = New System.Drawing.Size(1735, 311)
        Me.TabPageRa.TabIndex = 0
        Me.TabPageRa.Text = "Rows appereance"
        Me.TabPageRa.UseVisualStyleBackColor = True
        '
        'r110
        '
        Me.r110.CausesValidation = False
        Me.r110.DropDownWidth = 250
        Me.r110.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r110.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r110.FormattingEnabled = True
        Me.r110.Items.AddRange(New Object() {"Numeric", "Alpha numeric", "Alpha", "Date", "Time", "ISTDate", "Values separated by comma"})
        Me.r110.Location = New System.Drawing.Point(1338, 56)
        Me.r110.Name = "r110"
        Me.r110.Size = New System.Drawing.Size(102, 21)
        Me.r110.TabIndex = 270
        '
        'dgvAppR
        '
        Me.dgvAppR.AllowDrop = True
        Me.dgvAppR.AllowUserToOrderColumns = True
        Me.dgvAppR.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvAppR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAppR.ColumnHeadersHeight = 30
        Me.dgvAppR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn56, Me.DataGridViewTextBoxColumn57, Me.DataGridViewTextBoxColumn58})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAppR.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgvAppR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvAppR.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAppR.Location = New System.Drawing.Point(9, 121)
        Me.dgvAppR.MultiSelect = False
        Me.dgvAppR.Name = "dgvAppR"
        Me.dgvAppR.RowHeadersWidth = 33
        Me.dgvAppR.RowTemplate.Height = 30
        Me.dgvAppR.Size = New System.Drawing.Size(1621, 168)
        Me.dgvAppR.TabIndex = 287
        Me.dgvAppR.Tag = "8"
        '
        'DataGridViewTextBoxColumn56
        '
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn56.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn56.HeaderText = "Rows"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        '
        'DataGridViewTextBoxColumn57
        '
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn57.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn57.HeaderText = "Appereance"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.Width = 600
        '
        'DataGridViewTextBoxColumn58
        '
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn58.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn58.HeaderText = "Values"
        Me.DataGridViewTextBoxColumn58.Name = "DataGridViewTextBoxColumn58"
        Me.DataGridViewTextBoxColumn58.Width = 200
        '
        'r120
        '
        Me.r120.AccessibleName = ""
        Me.r120.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r120.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.r120.Location = New System.Drawing.Point(1455, 60)
        Me.r120.Name = "r120"
        Me.r120.Size = New System.Drawing.Size(106, 20)
        Me.r120.TabIndex = 269
        Me.r120.Text = "Empty"
        '
        'btnAppR
        '
        Me.btnAppR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppR.Location = New System.Drawing.Point(1555, 84)
        Me.btnAppR.Name = "btnAppR"
        Me.btnAppR.Size = New System.Drawing.Size(35, 30)
        Me.btnAppR.TabIndex = 286
        Me.btnAppR.Tag = "0"
        Me.btnAppR.Text = "+"
        Me.btnAppR.UseVisualStyleBackColor = True
        '
        'r6
        '
        Me.r6.AutoSize = True
        Me.r6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.r6.Location = New System.Drawing.Point(857, 86)
        Me.r6.Name = "r6"
        Me.r6.Size = New System.Drawing.Size(12, 11)
        Me.r6.TabIndex = 285
        Me.r6.UseVisualStyleBackColor = True
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label127.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(1338, 6)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(51, 13)
        Me.Label127.TabIndex = 284
        Me.Label127.Text = "Allowed"
        '
        'r11
        '
        Me.r11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r11.Location = New System.Drawing.Point(1338, 86)
        Me.r11.Name = "r11"
        Me.r11.Size = New System.Drawing.Size(103, 20)
        Me.r11.TabIndex = 283
        Me.r11.Visible = False
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label128.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(1446, 6)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(77, 13)
        Me.Label128.TabIndex = 282
        Me.Label128.Text = "Not allowed "
        '
        'r12
        '
        Me.r12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r12.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r12.Location = New System.Drawing.Point(1446, 86)
        Me.r12.Name = "r12"
        Me.r12.Size = New System.Drawing.Size(103, 20)
        Me.r12.TabIndex = 281
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label129.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(1125, 52)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(26, 13)
        Me.Label129.TabIndex = 280
        Me.Label129.Text = "Min"
        '
        'r10
        '
        Me.r10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r10.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r10.Location = New System.Drawing.Point(1232, 86)
        Me.r10.Name = "r10"
        Me.r10.Size = New System.Drawing.Size(103, 20)
        Me.r10.TabIndex = 279
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label130.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(1232, 52)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(30, 13)
        Me.Label130.TabIndex = 278
        Me.Label130.Text = "Max"
        '
        'r9
        '
        Me.r9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r9.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r9.Location = New System.Drawing.Point(1125, 86)
        Me.r9.Name = "r9"
        Me.r9.Size = New System.Drawing.Size(103, 20)
        Me.r9.TabIndex = 277
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label131.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(909, 52)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(26, 13)
        Me.Label131.TabIndex = 276
        Me.Label131.Text = "Min"
        '
        'r8
        '
        Me.r8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r8.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r8.Location = New System.Drawing.Point(1017, 86)
        Me.r8.Name = "r8"
        Me.r8.Size = New System.Drawing.Size(103, 20)
        Me.r8.TabIndex = 275
        '
        'Label132
        '
        Me.Label132.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label132.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(1179, 6)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(122, 24)
        Me.Label132.TabIndex = 274
        Me.Label132.Text = "Length"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label133.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(1017, 52)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(30, 13)
        Me.Label133.TabIndex = 273
        Me.Label133.Text = "Max"
        '
        'r7
        '
        Me.r7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r7.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r7.Location = New System.Drawing.Point(909, 86)
        Me.r7.Name = "r7"
        Me.r7.Size = New System.Drawing.Size(103, 20)
        Me.r7.TabIndex = 272
        '
        'Label134
        '
        Me.Label134.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label134.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.Location = New System.Drawing.Point(971, 6)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(122, 24)
        Me.Label134.TabIndex = 271
        Me.Label134.Text = "Value"
        '
        'Label135
        '
        Me.Label135.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label135.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.Location = New System.Drawing.Point(840, 6)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(70, 42)
        Me.Label135.TabIndex = 268
        Me.Label135.Text = "Read only"
        '
        'r5
        '
        Me.r5.CausesValidation = False
        Me.r5.DropDownWidth = 250
        Me.r5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r5.FormattingEnabled = True
        Me.r5.Items.AddRange(New Object() {"None", "Fixed single", "Fixed 3D"})
        Me.r5.Location = New System.Drawing.Point(702, 86)
        Me.r5.Name = "r5"
        Me.r5.Size = New System.Drawing.Size(138, 21)
        Me.r5.TabIndex = 267
        '
        'Label136
        '
        Me.Label136.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label136.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.Location = New System.Drawing.Point(702, 6)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(122, 42)
        Me.Label136.TabIndex = 266
        Me.Label136.Text = "Border"
        '
        'r4
        '
        Me.r4.AccessibleName = ""
        Me.r4.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.r4.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.r4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r4.Location = New System.Drawing.Point(560, 86)
        Me.r4.Name = "r4"
        Me.r4.SelectedColor = System.Drawing.Color.Empty
        Me.r4.Size = New System.Drawing.Size(139, 30)
        Me.r4.TabIndex = 265
        '
        'r3
        '
        Me.r3.AccessibleName = ""
        Me.r3.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.r3.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.r3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3.Location = New System.Drawing.Point(418, 86)
        Me.r3.Name = "r3"
        Me.r3.SelectedColor = System.Drawing.Color.Empty
        Me.r3.Size = New System.Drawing.Size(139, 30)
        Me.r3.TabIndex = 264
        '
        'Label137
        '
        Me.Label137.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label137.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label137.Location = New System.Drawing.Point(560, 6)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(122, 42)
        Me.Label137.TabIndex = 263
        Me.Label137.Text = "Back color"
        '
        'Label138
        '
        Me.Label138.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label138.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label138.Location = New System.Drawing.Point(418, 6)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(122, 42)
        Me.Label138.TabIndex = 262
        Me.Label138.Text = "Fore color"
        '
        'Label139
        '
        Me.Label139.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label139.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.Location = New System.Drawing.Point(275, 6)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(122, 42)
        Me.Label139.TabIndex = 261
        Me.Label139.Text = "Text alignment"
        '
        'r2
        '
        Me.r2.AutoCompleteCustomSource.AddRange(New String() {"Left", "Center", "Right"})
        Me.r2.CausesValidation = False
        Me.r2.DropDownWidth = 250
        Me.r2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r2.FormattingEnabled = True
        Me.r2.Items.AddRange(New Object() {"Left", "Right", "Center"})
        Me.r2.Location = New System.Drawing.Point(275, 86)
        Me.r2.Name = "r2"
        Me.r2.Size = New System.Drawing.Size(138, 21)
        Me.r2.TabIndex = 260
        '
        'Label140
        '
        Me.Label140.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label140.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.Location = New System.Drawing.Point(9, 6)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(118, 56)
        Me.Label140.TabIndex = 259
        Me.Label140.Text = "Rows, separated by comma"
        '
        'r0
        '
        Me.r0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.r0.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r0.Location = New System.Drawing.Point(10, 86)
        Me.r0.Name = "r0"
        Me.r0.Size = New System.Drawing.Size(103, 20)
        Me.r0.TabIndex = 258
        '
        'r1
        '
        Me.r1.CausesValidation = False
        Me.r1.DropDownWidth = 250
        Me.r1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.r1.FormattingEnabled = True
        Me.r1.Items.AddRange(New Object() {"Bold", "Italic", "Underline", "Regular"})
        Me.r1.Location = New System.Drawing.Point(135, 86)
        Me.r1.Name = "r1"
        Me.r1.Size = New System.Drawing.Size(138, 21)
        Me.r1.TabIndex = 257
        '
        'Label141
        '
        Me.Label141.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label141.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.Location = New System.Drawing.Point(135, 6)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(122, 42)
        Me.Label141.TabIndex = 256
        Me.Label141.Text = "Font type"
        '
        'TabPageCa
        '
        Me.TabPageCa.AutoScroll = True
        Me.TabPageCa.Controls.Add(Me.c110)
        Me.TabPageCa.Controls.Add(Me.dgvAppC)
        Me.TabPageCa.Controls.Add(Me.c120)
        Me.TabPageCa.Controls.Add(Me.btnAppC)
        Me.TabPageCa.Controls.Add(Me.c6)
        Me.TabPageCa.Controls.Add(Me.Label123)
        Me.TabPageCa.Controls.Add(Me.c11)
        Me.TabPageCa.Controls.Add(Me.Label122)
        Me.TabPageCa.Controls.Add(Me.c12)
        Me.TabPageCa.Controls.Add(Me.Label118)
        Me.TabPageCa.Controls.Add(Me.c10)
        Me.TabPageCa.Controls.Add(Me.Label120)
        Me.TabPageCa.Controls.Add(Me.c9)
        Me.TabPageCa.Controls.Add(Me.Label97)
        Me.TabPageCa.Controls.Add(Me.c8)
        Me.TabPageCa.Controls.Add(Me.Label119)
        Me.TabPageCa.Controls.Add(Me.Label117)
        Me.TabPageCa.Controls.Add(Me.c7)
        Me.TabPageCa.Controls.Add(Me.Label116)
        Me.TabPageCa.Controls.Add(Me.Label115)
        Me.TabPageCa.Controls.Add(Me.c5)
        Me.TabPageCa.Controls.Add(Me.Label114)
        Me.TabPageCa.Controls.Add(Me.c4)
        Me.TabPageCa.Controls.Add(Me.c3)
        Me.TabPageCa.Controls.Add(Me.Label105)
        Me.TabPageCa.Controls.Add(Me.Label104)
        Me.TabPageCa.Controls.Add(Me.Label103)
        Me.TabPageCa.Controls.Add(Me.c2)
        Me.TabPageCa.Controls.Add(Me.Label102)
        Me.TabPageCa.Controls.Add(Me.c0)
        Me.TabPageCa.Controls.Add(Me.c1)
        Me.TabPageCa.Controls.Add(Me.Label101)
        Me.TabPageCa.Location = New System.Drawing.Point(4, 23)
        Me.TabPageCa.Name = "TabPageCa"
        Me.TabPageCa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageCa.Size = New System.Drawing.Size(1735, 310)
        Me.TabPageCa.TabIndex = 1
        Me.TabPageCa.Text = "Columns appereance"
        Me.TabPageCa.UseVisualStyleBackColor = True
        '
        'c110
        '
        Me.c110.CausesValidation = False
        Me.c110.DropDownWidth = 250
        Me.c110.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c110.FormattingEnabled = True
        Me.c110.Items.AddRange(New Object() {"Numeric", "Alpha numeric", "Alpha", "Date", "Time", "ISTDate", "Values separated by comma"})
        Me.c110.Location = New System.Drawing.Point(1338, 56)
        Me.c110.Name = "c110"
        Me.c110.Size = New System.Drawing.Size(102, 21)
        Me.c110.TabIndex = 270
        '
        'dgvAppC
        '
        Me.dgvAppC.AccessibleDescription = "77"
        Me.dgvAppC.AllowDrop = True
        Me.dgvAppC.AllowUserToOrderColumns = True
        Me.dgvAppC.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvAppC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAppC.ColumnHeadersHeight = 30
        Me.dgvAppC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn54, Me.DataGridViewTextBoxColumn55, Me.Column18})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAppC.DefaultCellStyle = DataGridViewCellStyle21
        Me.dgvAppC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvAppC.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAppC.Location = New System.Drawing.Point(9, 121)
        Me.dgvAppC.MultiSelect = False
        Me.dgvAppC.Name = "dgvAppC"
        Me.dgvAppC.RowHeadersWidth = 33
        Me.dgvAppC.RowTemplate.Height = 30
        Me.dgvAppC.Size = New System.Drawing.Size(1621, 169)
        Me.dgvAppC.TabIndex = 287
        Me.dgvAppC.Tag = "8"
        '
        'DataGridViewTextBoxColumn54
        '
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn54.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn54.HeaderText = "Columns"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        '
        'DataGridViewTextBoxColumn55
        '
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn55.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn55.HeaderText = "Appereance"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.Width = 600
        '
        'Column18
        '
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column18.DefaultCellStyle = DataGridViewCellStyle20
        Me.Column18.HeaderText = "Values"
        Me.Column18.Name = "Column18"
        Me.Column18.Width = 200
        '
        'c120
        '
        Me.c120.AccessibleName = ""
        Me.c120.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.c120.Location = New System.Drawing.Point(1455, 60)
        Me.c120.Name = "c120"
        Me.c120.Size = New System.Drawing.Size(106, 20)
        Me.c120.TabIndex = 269
        Me.c120.Text = "Empty"
        '
        'btnAppC
        '
        Me.btnAppC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAppC.Location = New System.Drawing.Point(1557, 84)
        Me.btnAppC.Name = "btnAppC"
        Me.btnAppC.Size = New System.Drawing.Size(35, 30)
        Me.btnAppC.TabIndex = 286
        Me.btnAppC.Tag = "0"
        Me.btnAppC.Text = "+"
        Me.btnAppC.UseVisualStyleBackColor = True
        '
        'c6
        '
        Me.c6.AutoSize = True
        Me.c6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.c6.Location = New System.Drawing.Point(857, 86)
        Me.c6.Name = "c6"
        Me.c6.Size = New System.Drawing.Size(12, 11)
        Me.c6.TabIndex = 285
        Me.c6.UseVisualStyleBackColor = True
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label123.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(1338, 6)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(51, 13)
        Me.Label123.TabIndex = 284
        Me.Label123.Text = "Allowed"
        '
        'c11
        '
        Me.c11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c11.Location = New System.Drawing.Point(1338, 86)
        Me.c11.Name = "c11"
        Me.c11.Size = New System.Drawing.Size(103, 20)
        Me.c11.TabIndex = 283
        Me.c11.Visible = False
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label122.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(1446, 6)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(77, 13)
        Me.Label122.TabIndex = 282
        Me.Label122.Text = "Not allowed "
        '
        'c12
        '
        Me.c12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c12.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c12.Location = New System.Drawing.Point(1446, 86)
        Me.c12.Name = "c12"
        Me.c12.Size = New System.Drawing.Size(103, 20)
        Me.c12.TabIndex = 281
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label118.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(1125, 52)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(26, 13)
        Me.Label118.TabIndex = 280
        Me.Label118.Text = "Min"
        '
        'c10
        '
        Me.c10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c10.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c10.Location = New System.Drawing.Point(1232, 86)
        Me.c10.Name = "c10"
        Me.c10.Size = New System.Drawing.Size(103, 20)
        Me.c10.TabIndex = 279
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label120.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(1232, 52)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(30, 13)
        Me.Label120.TabIndex = 278
        Me.Label120.Text = "Max"
        '
        'c9
        '
        Me.c9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c9.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c9.Location = New System.Drawing.Point(1125, 86)
        Me.c9.Name = "c9"
        Me.c9.Size = New System.Drawing.Size(103, 20)
        Me.c9.TabIndex = 277
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label97.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(909, 52)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(26, 13)
        Me.Label97.TabIndex = 276
        Me.Label97.Text = "Min"
        '
        'c8
        '
        Me.c8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c8.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c8.Location = New System.Drawing.Point(1017, 86)
        Me.c8.Name = "c8"
        Me.c8.Size = New System.Drawing.Size(103, 20)
        Me.c8.TabIndex = 275
        '
        'Label119
        '
        Me.Label119.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label119.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(1179, 6)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(122, 24)
        Me.Label119.TabIndex = 274
        Me.Label119.Text = "Length"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label117.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(1017, 52)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(30, 13)
        Me.Label117.TabIndex = 273
        Me.Label117.Text = "Max"
        '
        'c7
        '
        Me.c7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c7.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c7.Location = New System.Drawing.Point(909, 86)
        Me.c7.Name = "c7"
        Me.c7.Size = New System.Drawing.Size(103, 20)
        Me.c7.TabIndex = 272
        '
        'Label116
        '
        Me.Label116.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label116.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(971, 6)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(122, 24)
        Me.Label116.TabIndex = 271
        Me.Label116.Text = "Value"
        '
        'Label115
        '
        Me.Label115.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label115.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(840, 6)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(70, 42)
        Me.Label115.TabIndex = 268
        Me.Label115.Text = "Read only"
        '
        'c5
        '
        Me.c5.CausesValidation = False
        Me.c5.DropDownWidth = 250
        Me.c5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c5.FormattingEnabled = True
        Me.c5.Items.AddRange(New Object() {"None", "Fixed single", "Fixed 3D"})
        Me.c5.Location = New System.Drawing.Point(702, 86)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(138, 21)
        Me.c5.TabIndex = 267
        '
        'Label114
        '
        Me.Label114.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label114.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(702, 6)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(122, 42)
        Me.Label114.TabIndex = 266
        Me.Label114.Text = "Border"
        '
        'c4
        '
        Me.c4.AccessibleName = ""
        Me.c4.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.c4.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.c4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c4.Location = New System.Drawing.Point(560, 86)
        Me.c4.Name = "c4"
        Me.c4.SelectedColor = System.Drawing.Color.Empty
        Me.c4.Size = New System.Drawing.Size(139, 30)
        Me.c4.TabIndex = 265
        '
        'c3
        '
        Me.c3.AccessibleName = ""
        Me.c3.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.c3.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.c3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c3.Location = New System.Drawing.Point(418, 86)
        Me.c3.Name = "c3"
        Me.c3.SelectedColor = System.Drawing.Color.Empty
        Me.c3.Size = New System.Drawing.Size(139, 30)
        Me.c3.TabIndex = 264
        '
        'Label105
        '
        Me.Label105.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label105.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(560, 6)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(122, 42)
        Me.Label105.TabIndex = 263
        Me.Label105.Text = "Back color"
        '
        'Label104
        '
        Me.Label104.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label104.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.Location = New System.Drawing.Point(418, 6)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(122, 42)
        Me.Label104.TabIndex = 262
        Me.Label104.Text = "Fore color"
        '
        'Label103
        '
        Me.Label103.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label103.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(275, 6)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(122, 42)
        Me.Label103.TabIndex = 261
        Me.Label103.Text = "Text alignment"
        '
        'c2
        '
        Me.c2.AutoCompleteCustomSource.AddRange(New String() {"Left", "Center", "Right"})
        Me.c2.CausesValidation = False
        Me.c2.DropDownWidth = 250
        Me.c2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c2.FormattingEnabled = True
        Me.c2.Items.AddRange(New Object() {"Left", "Right", "Center"})
        Me.c2.Location = New System.Drawing.Point(275, 86)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(138, 21)
        Me.c2.TabIndex = 260
        '
        'Label102
        '
        Me.Label102.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label102.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(9, 6)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(118, 56)
        Me.Label102.TabIndex = 259
        Me.Label102.Text = "Columns, separated by comma"
        '
        'c0
        '
        Me.c0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c0.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c0.Location = New System.Drawing.Point(10, 86)
        Me.c0.Name = "c0"
        Me.c0.Size = New System.Drawing.Size(103, 20)
        Me.c0.TabIndex = 258
        '
        'c1
        '
        Me.c1.CausesValidation = False
        Me.c1.DropDownWidth = 250
        Me.c1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.c1.FormattingEnabled = True
        Me.c1.Items.AddRange(New Object() {"Bold", "Italic", "Underline", "Regular"})
        Me.c1.Location = New System.Drawing.Point(135, 86)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(138, 21)
        Me.c1.TabIndex = 257
        '
        'Label101
        '
        Me.Label101.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label101.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(135, 6)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(122, 42)
        Me.Label101.TabIndex = 256
        Me.Label101.Text = "Font type"
        '
        'txtNLR
        '
        Me.txtNLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNLR.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtNLR.Location = New System.Drawing.Point(359, 5)
        Me.txtNLR.Name = "txtNLR"
        Me.txtNLR.Size = New System.Drawing.Size(257, 20)
        Me.txtNLR.TabIndex = 217
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label121.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(624, 5)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(266, 13)
        Me.Label121.TabIndex = 216
        Me.Label121.Text = "Whole rows are labels, separated by comma "
        '
        'txtColLen
        '
        Me.txtColLen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtColLen.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtColLen.Location = New System.Drawing.Point(10, 92)
        Me.txtColLen.Multiline = True
        Me.txtColLen.Name = "txtColLen"
        Me.txtColLen.Size = New System.Drawing.Size(315, 61)
        Me.txtColLen.TabIndex = 62
        '
        'Label100
        '
        Me.Label100.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label100.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(330, 92)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(165, 65)
        Me.Label100.TabIndex = 61
        Me.Label100.Text = "Columns length separated by comma"
        '
        'txtNLC
        '
        Me.txtNLC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNLC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtNLC.Location = New System.Drawing.Point(359, 34)
        Me.txtNLC.Name = "txtNLC"
        Me.txtNLC.Size = New System.Drawing.Size(257, 20)
        Me.txtNLC.TabIndex = 60
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label99.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(624, 34)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(282, 13)
        Me.Label99.TabIndex = 59
        Me.Label99.Text = "Whole columns are labels, separated by comma"
        '
        'cbTabDownLeft
        '
        Me.cbTabDownLeft.AutoSize = True
        Me.cbTabDownLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTabDownLeft.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbTabDownLeft.Location = New System.Drawing.Point(503, 110)
        Me.cbTabDownLeft.Name = "cbTabDownLeft"
        Me.cbTabDownLeft.Size = New System.Drawing.Size(183, 17)
        Me.cbTabDownLeft.TabIndex = 58
        Me.cbTabDownLeft.Text = "Tab - goes down then right*"
        Me.cbTabDownLeft.UseVisualStyleBackColor = True
        '
        'txtAT2
        '
        Me.txtAT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAT2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtAT2.Location = New System.Drawing.Point(1109, 19)
        Me.txtAT2.Multiline = True
        Me.txtAT2.Name = "txtAT2"
        Me.txtAT2.Size = New System.Drawing.Size(410, 69)
        Me.txtAT2.TabIndex = 56
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(119, 34)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(85, 13)
        Me.Label29.TabIndex = 46
        Me.Label29.Text = "Rows number"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRNAC
        '
        Me.txtRNAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRNAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtRNAC.Location = New System.Drawing.Point(10, 34)
        Me.txtRNAC.Name = "txtRNAC"
        Me.txtRNAC.Size = New System.Drawing.Size(103, 20)
        Me.txtRNAC.TabIndex = 43
        '
        'txtTNAC
        '
        Me.txtTNAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTNAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtTNAC.Location = New System.Drawing.Point(10, 5)
        Me.txtTNAC.Name = "txtTNAC"
        Me.txtTNAC.Size = New System.Drawing.Size(103, 20)
        Me.txtTNAC.TabIndex = 44
        '
        'txtCNAC
        '
        Me.txtCNAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCNAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtCNAC.Location = New System.Drawing.Point(10, 64)
        Me.txtCNAC.Name = "txtCNAC"
        Me.txtCNAC.Size = New System.Drawing.Size(103, 20)
        Me.txtCNAC.TabIndex = 45
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(119, 64)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(105, 13)
        Me.Label28.TabIndex = 47
        Me.Label28.Text = "Columns number"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(119, 5)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(128, 13)
        Me.Label27.TabIndex = 48
        Me.Label27.Text = "Table ordinal number"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chbColumnsStartFrom
        '
        Me.chbColumnsStartFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbColumnsStartFrom.Location = New System.Drawing.Point(766, 90)
        Me.chbColumnsStartFrom.Name = "chbColumnsStartFrom"
        Me.chbColumnsStartFrom.Size = New System.Drawing.Size(255, 20)
        Me.chbColumnsStartFrom.TabIndex = 278
        Me.chbColumnsStartFrom.Text = "Columns start from"
        Me.chbColumnsStartFrom.UseVisualStyleBackColor = True
        '
        'chbRowsStartFrom
        '
        Me.chbRowsStartFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRowsStartFrom.Location = New System.Drawing.Point(766, 62)
        Me.chbRowsStartFrom.Name = "chbRowsStartFrom"
        Me.chbRowsStartFrom.Size = New System.Drawing.Size(200, 22)
        Me.chbRowsStartFrom.TabIndex = 277
        Me.chbRowsStartFrom.Text = "Rows start from"
        Me.chbRowsStartFrom.UseVisualStyleBackColor = True
        '
        'cbTc6
        '
        Me.cbTc6.AccessibleName = ""
        Me.cbTc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTc6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTc6.Location = New System.Drawing.Point(1114, 121)
        Me.cbTc6.Name = "cbTc6"
        Me.cbTc6.Size = New System.Drawing.Size(154, 26)
        Me.cbTc6.TabIndex = 283
        Me.cbTc6.Text = "Back color"
        '
        'cbTc5
        '
        Me.cbTc5.AccessibleName = ""
        Me.cbTc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTc5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTc5.Location = New System.Drawing.Point(1114, 93)
        Me.cbTc5.Name = "cbTc5"
        Me.cbTc5.Size = New System.Drawing.Size(154, 26)
        Me.cbTc5.TabIndex = 282
        Me.cbTc5.Text = "Fore color"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label95.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label95.Location = New System.Drawing.Point(11, 18)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(176, 13)
        Me.Label95.TabIndex = 60
        Me.Label95.Text = "Add more like this control"
        '
        'cbTableAC
        '
        Me.cbTableAC.AutoSize = True
        Me.cbTableAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTableAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbTableAC.Location = New System.Drawing.Point(337, 17)
        Me.cbTableAC.Name = "cbTableAC"
        Me.cbTableAC.Size = New System.Drawing.Size(84, 17)
        Me.cbTableAC.TabIndex = 0
        Me.cbTableAC.Text = "Table style"
        Me.cbTableAC.UseVisualStyleBackColor = True
        '
        'lblNumber1AC
        '
        Me.lblNumber1AC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNumber1AC.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblNumber1AC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1AC.Location = New System.Drawing.Point(3, 583)
        Me.lblNumber1AC.Name = "lblNumber1AC"
        Me.lblNumber1AC.Size = New System.Drawing.Size(1650, 26)
        Me.lblNumber1AC.TabIndex = 42
        Me.lblNumber1AC.Text = "* Name will be automatically added with suffix _ and ordinal number  * Tab defaul" &
    "t goes right then down * Total number of control for adding"
        Me.lblNumber1AC.Visible = False
        '
        'txtNameAC
        '
        Me.txtNameAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNameAC.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtNameAC.Location = New System.Drawing.Point(176, 32)
        Me.txtNameAC.Name = "txtNameAC"
        Me.txtNameAC.Size = New System.Drawing.Size(260, 20)
        Me.txtNameAC.TabIndex = 161
        '
        'txtCLAC
        '
        Me.txtCLAC.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtCLAC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCLAC.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCLAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtCLAC.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtCLAC.Location = New System.Drawing.Point(0, 0)
        Me.txtCLAC.Multiline = True
        Me.txtCLAC.Name = "txtCLAC"
        Me.txtCLAC.ReadOnly = True
        Me.txtCLAC.Size = New System.Drawing.Size(534, 30)
        Me.txtCLAC.TabIndex = 1
        Me.txtCLAC.TabStop = False
        Me.txtCLAC.Tag = "VP"
        Me.txtCLAC.Text = "Add field to IST and column to DB"
        '
        'gbUC
        '
        Me.gbUC.Controls.Add(Me.Label113)
        Me.gbUC.Controls.Add(Me.Label112)
        Me.gbUC.Controls.Add(Me.Label111)
        Me.gbUC.Controls.Add(Me.Label110)
        Me.gbUC.Controls.Add(Me.Label109)
        Me.gbUC.Controls.Add(Me.Label108)
        Me.gbUC.Controls.Add(Me.cbAddG)
        Me.gbUC.Controls.Add(Me.cbAddM)
        Me.gbUC.Controls.Add(Me.btnUC)
        Me.gbUC.Controls.Add(Me.cbAddMB)
        Me.gbUC.Controls.Add(Me.cbAddE)
        Me.gbUC.Controls.Add(Me.cbAddY)
        Me.gbUC.Controls.Add(Me.cbAddMo)
        Me.gbUC.Location = New System.Drawing.Point(472, 58)
        Me.gbUC.Name = "gbUC"
        Me.gbUC.Size = New System.Drawing.Size(466, 225)
        Me.gbUC.TabIndex = 192
        Me.gbUC.TabStop = False
        Me.gbUC.Visible = False
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(99, 168)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(127, 13)
        Me.Label113.TabIndex = 195
        Me.Label113.Text = "char(8), primary key"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(99, 140)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(127, 13)
        Me.Label112.TabIndex = 194
        Me.Label112.Text = "char(2), primary key"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(99, 111)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(127, 13)
        Me.Label111.TabIndex = 193
        Me.Label111.Text = "char(4), primary key"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(99, 84)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(127, 13)
        Me.Label110.TabIndex = 192
        Me.Label110.Text = "char(8), primary key"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Location = New System.Drawing.Point(99, 55)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(127, 13)
        Me.Label109.TabIndex = 191
        Me.Label109.Text = "char(2), primary key"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Location = New System.Drawing.Point(99, 28)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(127, 13)
        Me.Label108.TabIndex = 62
        Me.Label108.Text = "char(4), primary key"
        '
        'cbAddG
        '
        Me.cbAddG.AutoSize = True
        Me.cbAddG.Location = New System.Drawing.Point(10, 28)
        Me.cbAddG.Name = "cbAddG"
        Me.cbAddG.Size = New System.Drawing.Size(53, 17)
        Me.cbAddG.TabIndex = 183
        Me.cbAddG.Text = "GOD"
        Me.cbAddG.UseVisualStyleBackColor = True
        '
        'cbAddM
        '
        Me.cbAddM.AutoSize = True
        Me.cbAddM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAddM.Location = New System.Drawing.Point(10, 55)
        Me.cbAddM.Name = "cbAddM"
        Me.cbAddM.Size = New System.Drawing.Size(47, 17)
        Me.cbAddM.TabIndex = 184
        Me.cbAddM.Text = "MES"
        Me.cbAddM.UseVisualStyleBackColor = True
        '
        'btnUC
        '
        Me.btnUC.Location = New System.Drawing.Point(265, 26)
        Me.btnUC.Name = "btnUC"
        Me.btnUC.Size = New System.Drawing.Size(98, 31)
        Me.btnUC.TabIndex = 190
        Me.btnUC.Tag = "0"
        Me.btnUC.Text = "Add"
        Me.btnUC.UseVisualStyleBackColor = True
        '
        'cbAddMB
        '
        Me.cbAddMB.AutoSize = True
        Me.cbAddMB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAddMB.Location = New System.Drawing.Point(10, 84)
        Me.cbAddMB.Name = "cbAddMB"
        Me.cbAddMB.Size = New System.Drawing.Size(40, 17)
        Me.cbAddMB.TabIndex = 185
        Me.cbAddMB.Text = "MB"
        Me.cbAddMB.UseVisualStyleBackColor = True
        '
        'cbAddE
        '
        Me.cbAddE.AutoSize = True
        Me.cbAddE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAddE.Location = New System.Drawing.Point(10, 168)
        Me.cbAddE.Name = "cbAddE"
        Me.cbAddE.Size = New System.Drawing.Size(52, 17)
        Me.cbAddE.TabIndex = 189
        Me.cbAddE.Text = "ENTP"
        Me.cbAddE.UseVisualStyleBackColor = True
        '
        'cbAddY
        '
        Me.cbAddY.AutoSize = True
        Me.cbAddY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAddY.Location = New System.Drawing.Point(10, 111)
        Me.cbAddY.Name = "cbAddY"
        Me.cbAddY.Size = New System.Drawing.Size(68, 17)
        Me.cbAddY.TabIndex = 187
        Me.cbAddY.Text = "ISTYear"
        Me.cbAddY.UseVisualStyleBackColor = True
        '
        'cbAddMo
        '
        Me.cbAddMo.AutoSize = True
        Me.cbAddMo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAddMo.Location = New System.Drawing.Point(10, 140)
        Me.cbAddMo.Name = "cbAddMo"
        Me.cbAddMo.Size = New System.Drawing.Size(77, 17)
        Me.cbAddMo.TabIndex = 188
        Me.cbAddMo.Text = "ISTMonth"
        Me.cbAddMo.UseVisualStyleBackColor = True
        '
        'cbAddUC
        '
        Me.cbAddUC.AutoSize = True
        Me.cbAddUC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAddUC.Location = New System.Drawing.Point(472, 38)
        Me.cbAddUC.Name = "cbAddUC"
        Me.cbAddUC.Size = New System.Drawing.Size(252, 17)
        Me.cbAddUC.TabIndex = 191
        Me.cbAddUC.Text = "Add year, month, enterprise ID columns"
        Me.cbAddUC.UseVisualStyleBackColor = True
        '
        'paneP0
        '
        Me.paneP0.Controls.Add(Me.Label63)
        Me.paneP0.Controls.Add(Me.chbFilterLK)
        Me.paneP0.Controls.Add(Me.Label45)
        Me.paneP0.Controls.Add(Me.txtType)
        Me.paneP0.Controls.Add(Me.btnP0OK)
        Me.paneP0.Controls.Add(Me.btnP0Cancel)
        Me.paneP0.Controls.Add(Me.Label52)
        Me.paneP0.Controls.Add(Me.CboRelTable)
        Me.paneP0.Controls.Add(Me.CboRelCol)
        Me.paneP0.Controls.Add(Me.cboRelDB)
        Me.paneP0.Controls.Add(Me.Label30)
        Me.paneP0.Controls.Add(Me.Label31)
        Me.paneP0.Controls.Add(Me.Label32)
        Me.paneP0.Controls.Add(Me.txtvdo)
        Me.paneP0.Controls.Add(Me.txtvod)
        Me.paneP0.Controls.Add(Me.TextBox1)
        Me.paneP0.Controls.Add(Me.Label33)
        Me.paneP0.Controls.Add(Me.txtLenght)
        Me.paneP0.Controls.Add(Me.Label34)
        Me.paneP0.Controls.Add(Me.Label35)
        Me.paneP0.Controls.Add(Me.txtDV)
        Me.paneP0.Controls.Add(Me.chbPK)
        Me.paneP0.Controls.Add(Me.txtL0)
        Me.paneP0.Location = New System.Drawing.Point(3, 178)
        Me.paneP0.Name = "paneP0"
        Me.paneP0.Size = New System.Drawing.Size(534, 44)
        Me.paneP0.TabIndex = 147
        Me.paneP0.Tag = "350"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label63.Location = New System.Drawing.Point(762, 326)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(195, 13)
        Me.Label63.TabIndex = 285
        Me.Label63.Text = "Filtered batch logical control"
        '
        'chbFilterLK
        '
        Me.chbFilterLK.AccessibleName = "FilterLK"
        Me.chbFilterLK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFilterLK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFilterLK.Location = New System.Drawing.Point(762, 363)
        Me.chbFilterLK.Name = "chbFilterLK"
        Me.chbFilterLK.Size = New System.Drawing.Size(629, 26)
        Me.chbFilterLK.TabIndex = 284
        Me.chbFilterLK.Text = "Do batch logical control by value of this column"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label45.Location = New System.Drawing.Point(762, 146)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(144, 13)
        Me.Label45.TabIndex = 248
        Me.Label45.Text = "Relation to codebook"
        '
        'txtType
        '
        Me.txtType.FormattingEnabled = True
        Me.txtType.Items.AddRange(New Object() {"int", "integer", "tinyint", "smallint", "big", "bigint", "decimal", "money", "smallmoney", "float", "real", "numeric", "bit", "boolean", "date", "datetime", "time", "char", "varchar", "text", "nchar", "nvarchar", "ntext", "ISTdate", "Email"})
        Me.txtType.Location = New System.Drawing.Point(255, 280)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(204, 21)
        Me.txtType.TabIndex = 247
        '
        'btnP0OK
        '
        Me.btnP0OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP0OK.Location = New System.Drawing.Point(63, 388)
        Me.btnP0OK.Name = "btnP0OK"
        Me.btnP0OK.Size = New System.Drawing.Size(128, 31)
        Me.btnP0OK.TabIndex = 246
        Me.btnP0OK.Tag = "0"
        Me.btnP0OK.Text = "OK"
        Me.btnP0OK.UseVisualStyleBackColor = True
        '
        'btnP0Cancel
        '
        Me.btnP0Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP0Cancel.Location = New System.Drawing.Point(201, 388)
        Me.btnP0Cancel.Name = "btnP0Cancel"
        Me.btnP0Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnP0Cancel.TabIndex = 245
        Me.btnP0Cancel.Tag = "0"
        Me.btnP0Cancel.Text = "Cancel"
        Me.btnP0Cancel.UseVisualStyleBackColor = True
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label52.Location = New System.Drawing.Point(39, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(37, 13)
        Me.Label52.TabIndex = 244
        Me.Label52.Text = "Data"
        '
        'CboRelTable
        '
        Me.CboRelTable.AccessibleName = ""
        Me.CboRelTable.DropDownWidth = 125
        Me.CboRelTable.FormattingEnabled = True
        Me.CboRelTable.Location = New System.Drawing.Point(762, 214)
        Me.CboRelTable.Name = "CboRelTable"
        Me.CboRelTable.Size = New System.Drawing.Size(471, 21)
        Me.CboRelTable.TabIndex = 164
        '
        'CboRelCol
        '
        Me.CboRelCol.AccessibleName = ""
        Me.CboRelCol.DropDownWidth = 125
        Me.CboRelCol.FormattingEnabled = True
        Me.CboRelCol.Location = New System.Drawing.Point(762, 248)
        Me.CboRelCol.Name = "CboRelCol"
        Me.CboRelCol.Size = New System.Drawing.Size(471, 21)
        Me.CboRelCol.TabIndex = 163
        '
        'cboRelDB
        '
        Me.cboRelDB.AccessibleName = ""
        Me.cboRelDB.DropDownWidth = 125
        Me.cboRelDB.FormattingEnabled = True
        Me.cboRelDB.Location = New System.Drawing.Point(762, 181)
        Me.cboRelDB.Name = "cboRelDB"
        Me.cboRelDB.Size = New System.Drawing.Size(471, 21)
        Me.cboRelDB.TabIndex = 162
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(630, 214)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 13)
        Me.Label30.TabIndex = 159
        Me.Label30.Text = "table"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(630, 248)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(48, 13)
        Me.Label31.TabIndex = 158
        Me.Label31.Text = "column"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(630, 181)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(59, 13)
        Me.Label32.TabIndex = 157
        Me.Label32.Text = "database"
        '
        'txtvdo
        '
        Me.txtvdo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvdo.Location = New System.Drawing.Point(264, 102)
        Me.txtvdo.Name = "txtvdo"
        Me.txtvdo.Size = New System.Drawing.Size(195, 21)
        Me.txtvdo.TabIndex = 152
        '
        'txtvod
        '
        Me.txtvod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvod.Location = New System.Drawing.Point(64, 102)
        Me.txtvod.Name = "txtvod"
        Me.txtvod.Size = New System.Drawing.Size(195, 21)
        Me.txtvod.TabIndex = 151
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBox1.Location = New System.Drawing.Point(64, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(397, 30)
        Me.TextBox1.TabIndex = 150
        Me.TextBox1.TabStop = False
        Me.TextBox1.Tag = "VP"
        Me.TextBox1.Text = "Validity period"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(64, 316)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(69, 13)
        Me.Label33.TabIndex = 123
        Me.Label33.Text = "Max length"
        '
        'txtLenght
        '
        Me.txtLenght.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLenght.Location = New System.Drawing.Point(255, 314)
        Me.txtLenght.Name = "txtLenght"
        Me.txtLenght.Size = New System.Drawing.Size(204, 21)
        Me.txtLenght.TabIndex = 122
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(64, 278)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(34, 13)
        Me.Label34.TabIndex = 121
        Me.Label34.Text = "Type"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(64, 242)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(83, 13)
        Me.Label35.TabIndex = 117
        Me.Label35.Text = "Default value"
        '
        'txtDV
        '
        Me.txtDV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDV.Location = New System.Drawing.Point(255, 242)
        Me.txtDV.Name = "txtDV"
        Me.txtDV.Size = New System.Drawing.Size(204, 21)
        Me.txtDV.TabIndex = 116
        '
        'chbPK
        '
        Me.chbPK.AccessibleName = "P"
        Me.chbPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbPK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPK.Location = New System.Drawing.Point(66, 174)
        Me.chbPK.Name = "chbPK"
        Me.chbPK.Size = New System.Drawing.Size(222, 26)
        Me.chbPK.TabIndex = 107
        Me.chbPK.Text = "Primary key"
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
        Me.txtL0.Size = New System.Drawing.Size(534, 30)
        Me.txtL0.TabIndex = 0
        Me.txtL0.TabStop = False
        Me.txtL0.Tag = "VP"
        Me.txtL0.Text = "Properties"
        '
        'paneP1
        '
        Me.paneP1.Controls.Add(Me.Label68)
        Me.paneP1.Controls.Add(Me.Label53)
        Me.paneP1.Controls.Add(Me.btnP1OK)
        Me.paneP1.Controls.Add(Me.btnP1Cancel)
        Me.paneP1.Controls.Add(Me.Label50)
        Me.paneP1.Controls.Add(Me.Label51)
        Me.paneP1.Controls.Add(Me.Label54)
        Me.paneP1.Controls.Add(Me.txtCBGroup)
        Me.paneP1.Controls.Add(Me.TabControlDGV)
        Me.paneP1.Controls.Add(Me.txtExpression)
        Me.paneP1.Controls.Add(Me.txtL6)
        Me.paneP1.Controls.Add(Me.gbCBO)
        Me.paneP1.Controls.Add(Me.cbHRB)
        Me.paneP1.Controls.Add(Me.cbVRB)
        Me.paneP1.Controls.Add(Me.cbLL)
        Me.paneP1.Controls.Add(Me.cbDTP)
        Me.paneP1.Controls.Add(Me.cbDGV)
        Me.paneP1.Controls.Add(Me.cbRCHB)
        Me.paneP1.Controls.Add(Me.cbLCHB)
        Me.paneP1.Controls.Add(Me.cbCHB)
        Me.paneP1.Controls.Add(Me.cbAC)
        Me.paneP1.Controls.Add(Me.cbCB)
        Me.paneP1.Controls.Add(Me.cbB)
        Me.paneP1.Controls.Add(Me.cbTB)
        Me.paneP1.Controls.Add(Me.cbFP)
        Me.paneP1.Controls.Add(Me.dgvRB)
        Me.paneP1.Controls.Add(Me.gbAC)
        Me.paneP1.Location = New System.Drawing.Point(3, 228)
        Me.paneP1.Name = "paneP1"
        Me.paneP1.Size = New System.Drawing.Size(534, 50)
        Me.paneP1.TabIndex = 150
        Me.paneP1.Tag = "600"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(19, 261)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(165, 13)
        Me.Label68.TabIndex = 235
        Me.Label68.Text = "CheckBox belongs to group"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label53.Location = New System.Drawing.Point(46, 444)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(43, 13)
        Me.Label53.TabIndex = 255
        Me.Label53.Text = "Other"
        '
        'btnP1OK
        '
        Me.btnP1OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP1OK.Location = New System.Drawing.Point(19, 724)
        Me.btnP1OK.Name = "btnP1OK"
        Me.btnP1OK.Size = New System.Drawing.Size(128, 31)
        Me.btnP1OK.TabIndex = 254
        Me.btnP1OK.Tag = "1"
        Me.btnP1OK.Text = "OK"
        Me.btnP1OK.UseVisualStyleBackColor = True
        '
        'btnP1Cancel
        '
        Me.btnP1Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP1Cancel.Location = New System.Drawing.Point(155, 724)
        Me.btnP1Cancel.Name = "btnP1Cancel"
        Me.btnP1Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnP1Cancel.TabIndex = 253
        Me.btnP1Cancel.Tag = "1"
        Me.btnP1Cancel.Text = "Cancel"
        Me.btnP1Cancel.UseVisualStyleBackColor = True
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label50.Location = New System.Drawing.Point(46, 129)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(70, 13)
        Me.Label50.TabIndex = 238
        Me.Label50.Text = "Checkbox"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label51.Location = New System.Drawing.Point(46, 30)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(75, 13)
        Me.Label51.TabIndex = 237
        Me.Label51.Text = "ComboBox"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label54.Location = New System.Drawing.Point(46, 335)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(85, 13)
        Me.Label54.TabIndex = 236
        Me.Label54.Text = "RadioButton"
        '
        'txtCBGroup
        '
        Me.txtCBGroup.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtCBGroup.Location = New System.Drawing.Point(19, 290)
        Me.txtCBGroup.Name = "txtCBGroup"
        Me.txtCBGroup.Size = New System.Drawing.Size(90, 20)
        Me.txtCBGroup.TabIndex = 230
        '
        'TabControlDGV
        '
        Me.TabControlDGV.Controls.Add(Me.TabPage4)
        Me.TabControlDGV.Controls.Add(Me.TabPage5)
        Me.TabControlDGV.Controls.Add(Me.TabPage6)
        Me.TabControlDGV.Controls.Add(Me.TabPage7)
        Me.TabControlDGV.Controls.Add(Me.TabPage8)
        Me.TabControlDGV.Controls.Add(Me.TabPage9)
        Me.TabControlDGV.Location = New System.Drawing.Point(893, 342)
        Me.TabControlDGV.Name = "TabControlDGV"
        Me.TabControlDGV.SelectedIndex = 0
        Me.TabControlDGV.Size = New System.Drawing.Size(1063, 327)
        Me.TabControlDGV.TabIndex = 221
        Me.TabControlDGV.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label55)
        Me.TabPage4.Controls.Add(Me.Label56)
        Me.TabPage4.Controls.Add(Me.Label57)
        Me.TabPage4.Controls.Add(Me.Label58)
        Me.TabPage4.Controls.Add(Me.Label59)
        Me.TabPage4.Controls.Add(Me.Label60)
        Me.TabPage4.Controls.Add(Me.Label61)
        Me.TabPage4.Controls.Add(Me.cboGS)
        Me.TabPage4.Controls.Add(Me.txtGSW)
        Me.TabPage4.Controls.Add(Me.txtGTitle)
        Me.TabPage4.Controls.Add(Me.txtGFS)
        Me.TabPage4.Controls.Add(Me.txtGWidth)
        Me.TabPage4.Controls.Add(Me.txtGLocationX)
        Me.TabPage4.Controls.Add(Me.txtGHeight)
        Me.TabPage4.Controls.Add(Me.txtGLocationY)
        Me.TabPage4.Controls.Add(Me.lblGLocationX)
        Me.TabPage4.Controls.Add(Me.lblGLocationY)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1055, 301)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Grid specifications"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(29, 193)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label55.Size = New System.Drawing.Size(171, 19)
        Me.Label55.TabIndex = 266
        Me.Label55.Text = "Font size"
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(29, 74)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label56.Size = New System.Drawing.Size(171, 19)
        Me.Label56.TabIndex = 265
        Me.Label56.Text = "Title"
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(29, 163)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label57.Size = New System.Drawing.Size(171, 19)
        Me.Label57.TabIndex = 264
        Me.Label57.Text = "Width"
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(29, 134)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label58.Size = New System.Drawing.Size(171, 19)
        Me.Label58.TabIndex = 263
        Me.Label58.Text = "Height"
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(10, 104)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label59.Size = New System.Drawing.Size(171, 19)
        Me.Label59.TabIndex = 262
        Me.Label59.Text = "Location"
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(29, 45)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label60.Size = New System.Drawing.Size(171, 19)
        Me.Label60.TabIndex = 261
        Me.Label60.Text = "Condition"
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(29, 15)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label61.Size = New System.Drawing.Size(171, 19)
        Me.Label61.TabIndex = 260
        Me.Label61.Text = "Source"
        '
        'cboGS
        '
        Me.cboGS.DropDownWidth = 413
        Me.cboGS.FormattingEnabled = True
        Me.cboGS.Location = New System.Drawing.Point(210, 15)
        Me.cboGS.Name = "cboGS"
        Me.cboGS.Size = New System.Drawing.Size(701, 21)
        Me.cboGS.TabIndex = 151
        '
        'txtGSW
        '
        Me.txtGSW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSW.Location = New System.Drawing.Point(210, 45)
        Me.txtGSW.Name = "txtGSW"
        Me.txtGSW.Size = New System.Drawing.Size(701, 21)
        Me.txtGSW.TabIndex = 153
        '
        'txtGTitle
        '
        Me.txtGTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGTitle.Location = New System.Drawing.Point(210, 74)
        Me.txtGTitle.Name = "txtGTitle"
        Me.txtGTitle.Size = New System.Drawing.Size(701, 21)
        Me.txtGTitle.TabIndex = 155
        '
        'txtGFS
        '
        Me.txtGFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGFS.Location = New System.Drawing.Point(210, 193)
        Me.txtGFS.Name = "txtGFS"
        Me.txtGFS.Size = New System.Drawing.Size(123, 21)
        Me.txtGFS.TabIndex = 166
        '
        'txtGWidth
        '
        Me.txtGWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGWidth.Location = New System.Drawing.Point(210, 163)
        Me.txtGWidth.Name = "txtGWidth"
        Me.txtGWidth.Size = New System.Drawing.Size(123, 21)
        Me.txtGWidth.TabIndex = 164
        '
        'txtGLocationX
        '
        Me.txtGLocationX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGLocationX.Location = New System.Drawing.Point(210, 104)
        Me.txtGLocationX.Name = "txtGLocationX"
        Me.txtGLocationX.Size = New System.Drawing.Size(89, 21)
        Me.txtGLocationX.TabIndex = 158
        '
        'txtGHeight
        '
        Me.txtGHeight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGHeight.Location = New System.Drawing.Point(210, 134)
        Me.txtGHeight.Name = "txtGHeight"
        Me.txtGHeight.Size = New System.Drawing.Size(123, 21)
        Me.txtGHeight.TabIndex = 163
        '
        'txtGLocationY
        '
        Me.txtGLocationY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGLocationY.Location = New System.Drawing.Point(351, 104)
        Me.txtGLocationY.Name = "txtGLocationY"
        Me.txtGLocationY.Size = New System.Drawing.Size(89, 21)
        Me.txtGLocationY.TabIndex = 160
        '
        'lblGLocationX
        '
        Me.lblGLocationX.AutoSize = True
        Me.lblGLocationX.Location = New System.Drawing.Point(176, 104)
        Me.lblGLocationX.Name = "lblGLocationX"
        Me.lblGLocationX.Size = New System.Drawing.Size(15, 13)
        Me.lblGLocationX.TabIndex = 157
        Me.lblGLocationX.Text = "X"
        '
        'lblGLocationY
        '
        Me.lblGLocationY.AutoSize = True
        Me.lblGLocationY.Location = New System.Drawing.Point(326, 104)
        Me.lblGLocationY.Name = "lblGLocationY"
        Me.lblGLocationY.Size = New System.Drawing.Size(14, 13)
        Me.lblGLocationY.TabIndex = 159
        Me.lblGLocationY.Text = "Y"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label62)
        Me.TabPage5.Controls.Add(Me.Label64)
        Me.TabPage5.Controls.Add(Me.Label65)
        Me.TabPage5.Controls.Add(Me.txtGColHHght)
        Me.TabPage5.Controls.Add(Me.txtGRHW)
        Me.TabPage5.Controls.Add(Me.txtGHRFS)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1055, 300)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Header"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(10, 80)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label62.Size = New System.Drawing.Size(247, 19)
        Me.Label62.TabIndex = 268
        Me.Label62.Text = "Header height"
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(10, 50)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label64.Size = New System.Drawing.Size(247, 19)
        Me.Label64.TabIndex = 267
        Me.Label64.Text = "Header font size"
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(10, 19)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label65.Size = New System.Drawing.Size(247, 19)
        Me.Label65.TabIndex = 266
        Me.Label65.Text = "Row header width"
        '
        'txtGColHHght
        '
        Me.txtGColHHght.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGColHHght.Location = New System.Drawing.Point(272, 75)
        Me.txtGColHHght.Name = "txtGColHHght"
        Me.txtGColHHght.Size = New System.Drawing.Size(123, 21)
        Me.txtGColHHght.TabIndex = 172
        '
        'txtGRHW
        '
        Me.txtGRHW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRHW.Location = New System.Drawing.Point(272, 20)
        Me.txtGRHW.Name = "txtGRHW"
        Me.txtGRHW.Size = New System.Drawing.Size(123, 21)
        Me.txtGRHW.TabIndex = 168
        '
        'txtGHRFS
        '
        Me.txtGHRFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGHRFS.Location = New System.Drawing.Point(272, 48)
        Me.txtGHRFS.Name = "txtGHRFS"
        Me.txtGHRFS.Size = New System.Drawing.Size(123, 21)
        Me.txtGHRFS.TabIndex = 170
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgvGridStop)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(1055, 300)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Stop"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgvGridStop
        '
        Me.dgvGridStop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGridStop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGridStop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridStop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5})
        Me.dgvGridStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGridStop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvGridStop.Location = New System.Drawing.Point(3, 3)
        Me.dgvGridStop.Name = "dgvGridStop"
        Me.dgvGridStop.Size = New System.Drawing.Size(1049, 294)
        Me.dgvGridStop.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.HeaderText = "Grid link stop if"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Message"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 250
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label66)
        Me.TabPage7.Controls.Add(Me.Label67)
        Me.TabPage7.Controls.Add(Me.txtGridEditText)
        Me.TabPage7.Controls.Add(Me.txtGridOpenText)
        Me.TabPage7.Controls.Add(Me.txtGridDeleteText)
        Me.TabPage7.Controls.Add(Me.txtGridDeleteWidth)
        Me.TabPage7.Controls.Add(Me.txtGridOpenWidth)
        Me.TabPage7.Controls.Add(Me.txtGridEditWidth)
        Me.TabPage7.Controls.Add(Me.cboGOpen)
        Me.TabPage7.Controls.Add(Me.chbGEdit)
        Me.TabPage7.Controls.Add(Me.chbGridOpen)
        Me.TabPage7.Controls.Add(Me.chbGridDelete)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(1055, 300)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "Link action"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(536, 5)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(151, 13)
        Me.Label66.TabIndex = 176
        Me.Label66.Text = "**Specify text for screen"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(848, 4)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(39, 13)
        Me.Label67.TabIndex = 175
        Me.Label67.Text = "Width"
        '
        'txtGridEditText
        '
        Me.txtGridEditText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridEditText.Location = New System.Drawing.Point(536, 34)
        Me.txtGridEditText.Name = "txtGridEditText"
        Me.txtGridEditText.Size = New System.Drawing.Size(299, 21)
        Me.txtGridEditText.TabIndex = 174
        '
        'txtGridOpenText
        '
        Me.txtGridOpenText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridOpenText.Location = New System.Drawing.Point(536, 71)
        Me.txtGridOpenText.Name = "txtGridOpenText"
        Me.txtGridOpenText.Size = New System.Drawing.Size(299, 21)
        Me.txtGridOpenText.TabIndex = 173
        '
        'txtGridDeleteText
        '
        Me.txtGridDeleteText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridDeleteText.Location = New System.Drawing.Point(536, 109)
        Me.txtGridDeleteText.Name = "txtGridDeleteText"
        Me.txtGridDeleteText.Size = New System.Drawing.Size(299, 21)
        Me.txtGridDeleteText.TabIndex = 172
        '
        'txtGridDeleteWidth
        '
        Me.txtGridDeleteWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridDeleteWidth.Location = New System.Drawing.Point(848, 109)
        Me.txtGridDeleteWidth.Name = "txtGridDeleteWidth"
        Me.txtGridDeleteWidth.Size = New System.Drawing.Size(102, 21)
        Me.txtGridDeleteWidth.TabIndex = 171
        '
        'txtGridOpenWidth
        '
        Me.txtGridOpenWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridOpenWidth.Location = New System.Drawing.Point(848, 71)
        Me.txtGridOpenWidth.Name = "txtGridOpenWidth"
        Me.txtGridOpenWidth.Size = New System.Drawing.Size(102, 21)
        Me.txtGridOpenWidth.TabIndex = 170
        '
        'txtGridEditWidth
        '
        Me.txtGridEditWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridEditWidth.Location = New System.Drawing.Point(848, 34)
        Me.txtGridEditWidth.Name = "txtGridEditWidth"
        Me.txtGridEditWidth.Size = New System.Drawing.Size(102, 21)
        Me.txtGridEditWidth.TabIndex = 169
        '
        'cboGOpen
        '
        Me.cboGOpen.DropDownWidth = 187
        Me.cboGOpen.FormattingEnabled = True
        Me.cboGOpen.Location = New System.Drawing.Point(205, 71)
        Me.cboGOpen.Name = "cboGOpen"
        Me.cboGOpen.Size = New System.Drawing.Size(316, 21)
        Me.cboGOpen.TabIndex = 168
        '
        'chbGEdit
        '
        Me.chbGEdit.AccessibleName = ""
        Me.chbGEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbGEdit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGEdit.Location = New System.Drawing.Point(10, 34)
        Me.chbGEdit.Name = "chbGEdit"
        Me.chbGEdit.Size = New System.Drawing.Size(177, 26)
        Me.chbGEdit.TabIndex = 167
        Me.chbGEdit.Text = "Edit"
        '
        'chbGridOpen
        '
        Me.chbGridOpen.AccessibleName = ""
        Me.chbGridOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbGridOpen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGridOpen.Location = New System.Drawing.Point(10, 74)
        Me.chbGridOpen.Name = "chbGridOpen"
        Me.chbGridOpen.Size = New System.Drawing.Size(177, 26)
        Me.chbGridOpen.TabIndex = 166
        Me.chbGridOpen.Text = "Open table"
        '
        'chbGridDelete
        '
        Me.chbGridDelete.AccessibleName = ""
        Me.chbGridDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbGridDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGridDelete.Location = New System.Drawing.Point(10, 111)
        Me.chbGridDelete.Name = "chbGridDelete"
        Me.chbGridDelete.Size = New System.Drawing.Size(177, 26)
        Me.chbGridDelete.TabIndex = 165
        Me.chbGridDelete.Text = "Delete"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.dgvGridColumn)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(1055, 300)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "Columns in grid"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'dgvGridColumn
        '
        Me.dgvGridColumn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGridColumn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGridColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridColumn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column8})
        Me.dgvGridColumn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvGridColumn.Location = New System.Drawing.Point(0, 6)
        Me.dgvGridColumn.Name = "dgvGridColumn"
        Me.dgvGridColumn.Size = New System.Drawing.Size(947, 201)
        Me.dgvGridColumn.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.HeaderText = "Screen name=Database Column name"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 350
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column width"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 90
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.dgvGridAddCol)
        Me.TabPage9.Location = New System.Drawing.Point(4, 23)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(1055, 300)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "Add column"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'dgvGridAddCol
        '
        Me.dgvGridAddCol.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGridAddCol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGridAddCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridAddCol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column17})
        Me.dgvGridAddCol.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvGridAddCol.Location = New System.Drawing.Point(0, 3)
        Me.dgvGridAddCol.Name = "dgvGridAddCol"
        Me.dgvGridAddCol.Size = New System.Drawing.Size(766, 201)
        Me.dgvGridAddCol.TabIndex = 0
        '
        'Column9
        '
        Me.Column9.HeaderText = "Screen name=Database Column name"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 300
        '
        'Column17
        '
        Me.Column17.HeaderText = "Column widht"
        Me.Column17.Name = "Column17"
        '
        'txtExpression
        '
        Me.txtExpression.Location = New System.Drawing.Point(19, 647)
        Me.txtExpression.Multiline = True
        Me.txtExpression.Name = "txtExpression"
        Me.txtExpression.Size = New System.Drawing.Size(1318, 71)
        Me.txtExpression.TabIndex = 218
        Me.txtExpression.Visible = False
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
        Me.txtL6.Size = New System.Drawing.Size(534, 30)
        Me.txtL6.TabIndex = 3
        Me.txtL6.TabStop = False
        Me.txtL6.Tag = "VP"
        Me.txtL6.Text = "Control type"
        '
        'gbCBO
        '
        Me.gbCBO.Controls.Add(Me.lDM)
        Me.gbCBO.Controls.Add(Me.lVM)
        Me.gbCBO.Controls.Add(Me.lF)
        Me.gbCBO.Controls.Add(Me.txtfDM)
        Me.gbCBO.Controls.Add(Me.txtfVM)
        Me.gbCBO.Controls.Add(Me.txtfF)
        Me.gbCBO.Controls.Add(Me.lDS)
        Me.gbCBO.Controls.Add(Me.cbCWO)
        Me.gbCBO.Controls.Add(Me.txtfDS)
        Me.gbCBO.Location = New System.Drawing.Point(318, 30)
        Me.gbCBO.Name = "gbCBO"
        Me.gbCBO.Size = New System.Drawing.Size(713, 267)
        Me.gbCBO.TabIndex = 239
        Me.gbCBO.TabStop = False
        Me.gbCBO.Text = "Combobox"
        Me.gbCBO.Visible = False
        '
        'lDM
        '
        Me.lDM.AutoSize = True
        Me.lDM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDM.Location = New System.Drawing.Point(19, 129)
        Me.lDM.Name = "lDM"
        Me.lDM.Size = New System.Drawing.Size(101, 13)
        Me.lDM.TabIndex = 223
        Me.lDM.Text = "Display member"
        '
        'lVM
        '
        Me.lVM.AutoSize = True
        Me.lVM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lVM.Location = New System.Drawing.Point(201, 129)
        Me.lVM.Name = "lVM"
        Me.lVM.Size = New System.Drawing.Size(90, 13)
        Me.lVM.TabIndex = 224
        Me.lVM.Text = "Value member"
        '
        'lF
        '
        Me.lF.AutoSize = True
        Me.lF.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lF.Location = New System.Drawing.Point(384, 129)
        Me.lF.Name = "lF"
        Me.lF.Size = New System.Drawing.Size(35, 13)
        Me.lF.TabIndex = 225
        Me.lF.Text = "Filter"
        '
        'txtfDM
        '
        Me.txtfDM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtfDM.Location = New System.Drawing.Point(19, 156)
        Me.txtfDM.Name = "txtfDM"
        Me.txtfDM.Size = New System.Drawing.Size(170, 20)
        Me.txtfDM.TabIndex = 227
        '
        'txtfVM
        '
        Me.txtfVM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtfVM.Location = New System.Drawing.Point(201, 156)
        Me.txtfVM.Name = "txtfVM"
        Me.txtfVM.Size = New System.Drawing.Size(170, 20)
        Me.txtfVM.TabIndex = 228
        '
        'txtfF
        '
        Me.txtfF.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtfF.Location = New System.Drawing.Point(384, 156)
        Me.txtfF.Name = "txtfF"
        Me.txtfF.Size = New System.Drawing.Size(299, 20)
        Me.txtfF.TabIndex = 229
        '
        'lDS
        '
        Me.lDS.AutoSize = True
        Me.lDS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDS.Location = New System.Drawing.Point(19, 28)
        Me.lDS.Name = "lDS"
        Me.lDS.Size = New System.Drawing.Size(76, 13)
        Me.lDS.TabIndex = 222
        Me.lDS.Text = "Data source"
        '
        'cbCWO
        '
        Me.cbCWO.AccessibleName = ""
        Me.cbCWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCWO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCWO.Location = New System.Drawing.Point(19, 214)
        Me.cbCWO.Name = "cbCWO"
        Me.cbCWO.Size = New System.Drawing.Size(683, 28)
        Me.cbCWO.TabIndex = 232
        Me.cbCWO.Text = "For web also generate combobox instead of autocomplete list"
        '
        'txtfDS
        '
        Me.txtfDS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtfDS.Location = New System.Drawing.Point(19, 56)
        Me.txtfDS.Multiline = True
        Me.txtfDS.Name = "txtfDS"
        Me.txtfDS.Size = New System.Drawing.Size(669, 59)
        Me.txtfDS.TabIndex = 226
        '
        'cbHRB
        '
        Me.cbHRB.AccessibleName = ""
        Me.cbHRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHRB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHRB.Location = New System.Drawing.Point(19, 403)
        Me.cbHRB.Name = "cbHRB"
        Me.cbHRB.Size = New System.Drawing.Size(147, 26)
        Me.cbHRB.TabIndex = 251
        Me.cbHRB.Text = "Horizontal "
        '
        'cbVRB
        '
        Me.cbVRB.AccessibleName = ""
        Me.cbVRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbVRB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVRB.Location = New System.Drawing.Point(19, 366)
        Me.cbVRB.Name = "cbVRB"
        Me.cbVRB.Size = New System.Drawing.Size(147, 26)
        Me.cbVRB.TabIndex = 250
        Me.cbVRB.Text = "Vertical"
        '
        'cbLL
        '
        Me.cbLL.AccessibleName = ""
        Me.cbLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLL.Location = New System.Drawing.Point(19, 585)
        Me.cbLL.Name = "cbLL"
        Me.cbLL.Size = New System.Drawing.Size(278, 26)
        Me.cbLL.TabIndex = 249
        Me.cbLL.Text = "LinkLabel"
        '
        'cbDTP
        '
        Me.cbDTP.AccessibleName = ""
        Me.cbDTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDTP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDTP.Location = New System.Drawing.Point(19, 557)
        Me.cbDTP.Name = "cbDTP"
        Me.cbDTP.Size = New System.Drawing.Size(278, 26)
        Me.cbDTP.TabIndex = 248
        Me.cbDTP.Text = "DateTimePicker"
        '
        'cbDGV
        '
        Me.cbDGV.AccessibleName = ""
        Me.cbDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDGV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDGV.Location = New System.Drawing.Point(19, 529)
        Me.cbDGV.Name = "cbDGV"
        Me.cbDGV.Size = New System.Drawing.Size(278, 26)
        Me.cbDGV.TabIndex = 247
        Me.cbDGV.Text = "DataGridView"
        '
        'cbRCHB
        '
        Me.cbRCHB.AccessibleName = ""
        Me.cbRCHB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRCHB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRCHB.Location = New System.Drawing.Point(19, 228)
        Me.cbRCHB.Name = "cbRCHB"
        Me.cbRCHB.Size = New System.Drawing.Size(278, 26)
        Me.cbRCHB.TabIndex = 246
        Me.cbRCHB.Text = "Right CheckBox"
        '
        'cbLCHB
        '
        Me.cbLCHB.AccessibleName = ""
        Me.cbLCHB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLCHB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLCHB.Location = New System.Drawing.Point(19, 196)
        Me.cbLCHB.Name = "cbLCHB"
        Me.cbLCHB.Size = New System.Drawing.Size(278, 26)
        Me.cbLCHB.TabIndex = 245
        Me.cbLCHB.Text = "Left CheckBox"
        '
        'cbCHB
        '
        Me.cbCHB.AccessibleName = ""
        Me.cbCHB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCHB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCHB.Location = New System.Drawing.Point(19, 164)
        Me.cbCHB.Name = "cbCHB"
        Me.cbCHB.Size = New System.Drawing.Size(278, 26)
        Me.cbCHB.TabIndex = 244
        Me.cbCHB.Text = "CheckBox"
        '
        'cbAC
        '
        Me.cbAC.AccessibleName = ""
        Me.cbAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAC.Location = New System.Drawing.Point(19, 86)
        Me.cbAC.Name = "cbAC"
        Me.cbAC.Size = New System.Drawing.Size(278, 26)
        Me.cbAC.TabIndex = 243
        Me.cbAC.Text = "Autocomplete textbox"
        '
        'cbCB
        '
        Me.cbCB.AccessibleName = ""
        Me.cbCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCB.Location = New System.Drawing.Point(19, 56)
        Me.cbCB.Name = "cbCB"
        Me.cbCB.Size = New System.Drawing.Size(278, 26)
        Me.cbCB.TabIndex = 242
        Me.cbCB.Text = "ComboBox"
        '
        'cbB
        '
        Me.cbB.AccessibleName = ""
        Me.cbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbB.Location = New System.Drawing.Point(19, 501)
        Me.cbB.Name = "cbB"
        Me.cbB.Size = New System.Drawing.Size(278, 26)
        Me.cbB.TabIndex = 241
        Me.cbB.Text = "Button"
        '
        'cbTB
        '
        Me.cbTB.AccessibleName = ""
        Me.cbTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTB.Location = New System.Drawing.Point(19, 472)
        Me.cbTB.Name = "cbTB"
        Me.cbTB.Size = New System.Drawing.Size(278, 26)
        Me.cbTB.TabIndex = 240
        Me.cbTB.Text = "TextBox"
        '
        'cbFP
        '
        Me.cbFP.AccessibleName = ""
        Me.cbFP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFP.Location = New System.Drawing.Point(19, 614)
        Me.cbFP.Name = "cbFP"
        Me.cbFP.Size = New System.Drawing.Size(278, 26)
        Me.cbFP.TabIndex = 252
        Me.cbFP.Text = "Virtual field"
        '
        'dgvRB
        '
        Me.dgvRB.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.dgvRB.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvRB.Location = New System.Drawing.Point(231, 340)
        Me.dgvRB.Name = "dgvRB"
        Me.dgvRB.Size = New System.Drawing.Size(752, 288)
        Me.dgvRB.TabIndex = 256
        Me.dgvRB.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Option value"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.HeaderText = "Option text"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 250
        '
        'gbAC
        '
        Me.gbAC.Controls.Add(Me.Label36)
        Me.gbAC.Controls.Add(Me.Label37)
        Me.gbAC.Controls.Add(Me.Label38)
        Me.gbAC.Controls.Add(Me.Label39)
        Me.gbAC.Controls.Add(Me.Label40)
        Me.gbAC.Controls.Add(Me.txtACFilterStart)
        Me.gbAC.Controls.Add(Me.Label41)
        Me.gbAC.Controls.Add(Me.Label42)
        Me.gbAC.Controls.Add(Me.txtLett)
        Me.gbAC.Controls.Add(Me.Label43)
        Me.gbAC.Controls.Add(Me.txtACWidth)
        Me.gbAC.Controls.Add(Me.Label44)
        Me.gbAC.Controls.Add(Me.Label46)
        Me.gbAC.Controls.Add(Me.Label47)
        Me.gbAC.Controls.Add(Me.Label48)
        Me.gbAC.Controls.Add(Me.Label49)
        Me.gbAC.Controls.Add(Me.txtACHeight)
        Me.gbAC.Controls.Add(Me.txtACFilterLen)
        Me.gbAC.Controls.Add(Me.cbACLTL)
        Me.gbAC.Controls.Add(Me.txtACAsgnLen)
        Me.gbAC.Controls.Add(Me.txtACFilterName)
        Me.gbAC.Controls.Add(Me.txtACAsgnStart)
        Me.gbAC.Controls.Add(Me.txtACAsgn)
        Me.gbAC.Controls.Add(Me.txtACMinTL)
        Me.gbAC.Controls.Add(Me.txtACLength)
        Me.gbAC.Controls.Add(Me.txtACStart)
        Me.gbAC.Controls.Add(Me.llACB)
        Me.gbAC.Controls.Add(Me.txtACB)
        Me.gbAC.Location = New System.Drawing.Point(1034, 30)
        Me.gbAC.Name = "gbAC"
        Me.gbAC.Size = New System.Drawing.Size(871, 353)
        Me.gbAC.TabIndex = 233
        Me.gbAC.TabStop = False
        Me.gbAC.Text = "Autocomplete textbox"
        Me.gbAC.Visible = False
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(530, 132)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label36.Size = New System.Drawing.Size(146, 19)
        Me.Label36.TabIndex = 265
        Me.Label36.Text = "Width"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(530, 266)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label37.Size = New System.Drawing.Size(146, 19)
        Me.Label37.TabIndex = 264
        Me.Label37.Text = "Start position"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label38.Location = New System.Drawing.Point(606, 169)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(42, 13)
        Me.Label38.TabIndex = 266
        Me.Label38.Text = "Filter"
        Me.Label38.Visible = False
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(9, 132)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label39.Size = New System.Drawing.Size(247, 19)
        Me.Label39.TabIndex = 259
        Me.Label39.Text = "Minimum type length"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(530, 232)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label40.Size = New System.Drawing.Size(146, 19)
        Me.Label40.TabIndex = 263
        Me.Label40.Text = "Length"
        '
        'txtACFilterStart
        '
        Me.txtACFilterStart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACFilterStart.Location = New System.Drawing.Point(683, 266)
        Me.txtACFilterStart.Multiline = True
        Me.txtACFilterStart.Name = "txtACFilterStart"
        Me.txtACFilterStart.Size = New System.Drawing.Size(159, 30)
        Me.txtACFilterStart.TabIndex = 184
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(9, 232)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label41.Size = New System.Drawing.Size(247, 19)
        Me.Label41.TabIndex = 257
        Me.Label41.Text = "Assign length"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(530, 198)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label42.Size = New System.Drawing.Size(146, 19)
        Me.Label42.TabIndex = 262
        Me.Label42.Text = "Filter name"
        '
        'txtLett
        '
        Me.txtLett.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLett.Location = New System.Drawing.Point(683, 65)
        Me.txtLett.Multiline = True
        Me.txtLett.Name = "txtLett"
        Me.txtLett.Size = New System.Drawing.Size(159, 30)
        Me.txtLett.TabIndex = 198
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(9, 198)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label43.Size = New System.Drawing.Size(247, 19)
        Me.Label43.TabIndex = 256
        Me.Label43.Text = "Assign start from position"
        '
        'txtACWidth
        '
        Me.txtACWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACWidth.Location = New System.Drawing.Point(683, 132)
        Me.txtACWidth.Multiline = True
        Me.txtACWidth.Name = "txtACWidth"
        Me.txtACWidth.Size = New System.Drawing.Size(159, 30)
        Me.txtACWidth.TabIndex = 194
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(9, 165)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label44.Size = New System.Drawing.Size(247, 19)
        Me.Label44.TabIndex = 255
        Me.Label44.Text = "Assign to"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(530, 99)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label46.Size = New System.Drawing.Size(146, 19)
        Me.Label46.TabIndex = 261
        Me.Label46.Text = "Height"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(9, 99)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label47.Size = New System.Drawing.Size(247, 19)
        Me.Label47.TabIndex = 254
        Me.Label47.Text = "Length"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(9, 65)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label48.Size = New System.Drawing.Size(247, 19)
        Me.Label48.TabIndex = 253
        Me.Label48.Text = "Start position"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(530, 65)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label49.Size = New System.Drawing.Size(146, 19)
        Me.Label49.TabIndex = 260
        Me.Label49.Text = "Letter"
        '
        'txtACHeight
        '
        Me.txtACHeight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACHeight.Location = New System.Drawing.Point(683, 99)
        Me.txtACHeight.Multiline = True
        Me.txtACHeight.Name = "txtACHeight"
        Me.txtACHeight.Size = New System.Drawing.Size(159, 30)
        Me.txtACHeight.TabIndex = 192
        '
        'txtACFilterLen
        '
        Me.txtACFilterLen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACFilterLen.Location = New System.Drawing.Point(683, 232)
        Me.txtACFilterLen.Multiline = True
        Me.txtACFilterLen.Name = "txtACFilterLen"
        Me.txtACFilterLen.Size = New System.Drawing.Size(159, 30)
        Me.txtACFilterLen.TabIndex = 182
        '
        'cbACLTL
        '
        Me.cbACLTL.AccessibleName = ""
        Me.cbACLTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbACLTL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbACLTL.Location = New System.Drawing.Point(122, 276)
        Me.cbACLTL.Name = "cbACLTL"
        Me.cbACLTL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbACLTL.Size = New System.Drawing.Size(301, 26)
        Me.cbACLTL.TabIndex = 187
        Me.cbACLTL.Text = "Limit to list"
        '
        'txtACAsgnLen
        '
        Me.txtACAsgnLen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACAsgnLen.Location = New System.Drawing.Point(262, 232)
        Me.txtACAsgnLen.Multiline = True
        Me.txtACAsgnLen.Name = "txtACAsgnLen"
        Me.txtACAsgnLen.Size = New System.Drawing.Size(159, 30)
        Me.txtACAsgnLen.TabIndex = 186
        '
        'txtACFilterName
        '
        Me.txtACFilterName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACFilterName.Location = New System.Drawing.Point(683, 198)
        Me.txtACFilterName.Multiline = True
        Me.txtACFilterName.Name = "txtACFilterName"
        Me.txtACFilterName.Size = New System.Drawing.Size(159, 30)
        Me.txtACFilterName.TabIndex = 180
        '
        'txtACAsgnStart
        '
        Me.txtACAsgnStart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACAsgnStart.Location = New System.Drawing.Point(262, 198)
        Me.txtACAsgnStart.Multiline = True
        Me.txtACAsgnStart.Name = "txtACAsgnStart"
        Me.txtACAsgnStart.Size = New System.Drawing.Size(159, 30)
        Me.txtACAsgnStart.TabIndex = 184
        '
        'txtACAsgn
        '
        Me.txtACAsgn.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACAsgn.Location = New System.Drawing.Point(262, 165)
        Me.txtACAsgn.Multiline = True
        Me.txtACAsgn.Name = "txtACAsgn"
        Me.txtACAsgn.Size = New System.Drawing.Size(159, 30)
        Me.txtACAsgn.TabIndex = 182
        '
        'txtACMinTL
        '
        Me.txtACMinTL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACMinTL.Location = New System.Drawing.Point(262, 132)
        Me.txtACMinTL.Multiline = True
        Me.txtACMinTL.Name = "txtACMinTL"
        Me.txtACMinTL.Size = New System.Drawing.Size(159, 30)
        Me.txtACMinTL.TabIndex = 180
        '
        'txtACLength
        '
        Me.txtACLength.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACLength.Location = New System.Drawing.Point(262, 99)
        Me.txtACLength.Multiline = True
        Me.txtACLength.Name = "txtACLength"
        Me.txtACLength.Size = New System.Drawing.Size(159, 30)
        Me.txtACLength.TabIndex = 178
        '
        'txtACStart
        '
        Me.txtACStart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACStart.Location = New System.Drawing.Point(262, 65)
        Me.txtACStart.Multiline = True
        Me.txtACStart.Name = "txtACStart"
        Me.txtACStart.Size = New System.Drawing.Size(159, 30)
        Me.txtACStart.TabIndex = 176
        '
        'llACB
        '
        Me.llACB.AutoSize = True
        Me.llACB.Location = New System.Drawing.Point(17, 30)
        Me.llACB.Name = "llACB"
        Me.llACB.Size = New System.Drawing.Size(71, 13)
        Me.llACB.TabIndex = 175
        Me.llACB.TabStop = True
        Me.llACB.Text = "Choose file"
        '
        'txtACB
        '
        Me.txtACB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACB.Location = New System.Drawing.Point(146, 22)
        Me.txtACB.Multiline = True
        Me.txtACB.Name = "txtACB"
        Me.txtACB.Size = New System.Drawing.Size(697, 32)
        Me.txtACB.TabIndex = 172
        '
        'paneP2
        '
        Me.paneP2.Controls.Add(Me.btnP2Cancel)
        Me.paneP2.Controls.Add(Me.btnP2OK)
        Me.paneP2.Controls.Add(Me.Label71)
        Me.paneP2.Controls.Add(Me.tbFSize)
        Me.paneP2.Controls.Add(Me.chbML)
        Me.paneP2.Controls.Add(Me.Label72)
        Me.paneP2.Controls.Add(Me.txtTitle)
        Me.paneP2.Controls.Add(Me.Mkc_ColorCombobox1)
        Me.paneP2.Controls.Add(Me.Mkc_ColorCombobox2)
        Me.paneP2.Controls.Add(Me.chbBackColor)
        Me.paneP2.Controls.Add(Me.chbForeColor)
        Me.paneP2.Controls.Add(Me.chbOnlyTitle)
        Me.paneP2.Controls.Add(Me.txtL1)
        Me.paneP2.Controls.Add(Me.chbRAligment)
        Me.paneP2.Controls.Add(Me.chbFItalic)
        Me.paneP2.Controls.Add(Me.chbFBold)
        Me.paneP2.Controls.Add(Me.chbCAligment)
        Me.paneP2.Controls.Add(Me.chbFSize)
        Me.paneP2.Location = New System.Drawing.Point(3, 284)
        Me.paneP2.Name = "paneP2"
        Me.paneP2.Size = New System.Drawing.Size(534, 50)
        Me.paneP2.TabIndex = 146
        Me.paneP2.Tag = "370"
        '
        'btnP2Cancel
        '
        Me.btnP2Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP2Cancel.Location = New System.Drawing.Point(171, 444)
        Me.btnP2Cancel.Name = "btnP2Cancel"
        Me.btnP2Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnP2Cancel.TabIndex = 151
        Me.btnP2Cancel.Tag = "2"
        Me.btnP2Cancel.Text = "Cancel"
        Me.btnP2Cancel.UseVisualStyleBackColor = True
        '
        'btnP2OK
        '
        Me.btnP2OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP2OK.Location = New System.Drawing.Point(15, 444)
        Me.btnP2OK.Name = "btnP2OK"
        Me.btnP2OK.Size = New System.Drawing.Size(128, 31)
        Me.btnP2OK.TabIndex = 152
        Me.btnP2OK.Tag = "2"
        Me.btnP2OK.Text = "OK"
        Me.btnP2OK.UseVisualStyleBackColor = True
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.ForeColor = System.Drawing.Color.Red
        Me.Label71.Location = New System.Drawing.Point(835, 36)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(0, 13)
        Me.Label71.TabIndex = 158
        '
        'tbFSize
        '
        Me.tbFSize.AccessibleName = ""
        Me.tbFSize.LargeChange = 1
        Me.tbFSize.Location = New System.Drawing.Point(613, 322)
        Me.tbFSize.Maximum = 20
        Me.tbFSize.Minimum = 7
        Me.tbFSize.Name = "tbFSize"
        Me.tbFSize.Size = New System.Drawing.Size(145, 45)
        Me.tbFSize.TabIndex = 150
        Me.tbFSize.TabStop = False
        Me.tbFSize.Tag = "8"
        Me.tbFSize.Value = 7
        Me.tbFSize.Visible = False
        '
        'chbML
        '
        Me.chbML.AccessibleName = "multiline"
        Me.chbML.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.chbML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbML.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbML.Location = New System.Drawing.Point(17, 290)
        Me.chbML.Name = "chbML"
        Me.chbML.Size = New System.Drawing.Size(345, 26)
        Me.chbML.TabIndex = 147
        Me.chbML.Text = "Multiline"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(11, 33)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(112, 13)
        Me.Label72.TabIndex = 145
        Me.Label72.Text = "Label / description"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(13, 60)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(801, 161)
        Me.txtTitle.TabIndex = 144
        '
        'Mkc_ColorCombobox1
        '
        Me.Mkc_ColorCombobox1.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox1.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox1.Location = New System.Drawing.Point(171, 322)
        Me.Mkc_ColorCombobox1.Name = "Mkc_ColorCombobox1"
        Me.Mkc_ColorCombobox1.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox1.Size = New System.Drawing.Size(255, 30)
        Me.Mkc_ColorCombobox1.TabIndex = 143
        Me.Mkc_ColorCombobox1.Tag = "VF"
        Me.Mkc_ColorCombobox1.Visible = False
        '
        'Mkc_ColorCombobox2
        '
        Me.Mkc_ColorCombobox2.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox2.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox2.Location = New System.Drawing.Point(171, 361)
        Me.Mkc_ColorCombobox2.Name = "Mkc_ColorCombobox2"
        Me.Mkc_ColorCombobox2.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox2.Size = New System.Drawing.Size(255, 30)
        Me.Mkc_ColorCombobox2.TabIndex = 142
        Me.Mkc_ColorCombobox2.Tag = "VF"
        Me.Mkc_ColorCombobox2.Visible = False
        '
        'chbBackColor
        '
        Me.chbBackColor.AccessibleName = ""
        Me.chbBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBackColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBackColor.Location = New System.Drawing.Point(17, 356)
        Me.chbBackColor.Name = "chbBackColor"
        Me.chbBackColor.Size = New System.Drawing.Size(155, 26)
        Me.chbBackColor.TabIndex = 141
        Me.chbBackColor.Text = "Back color"
        '
        'chbForeColor
        '
        Me.chbForeColor.AccessibleName = ""
        Me.chbForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbForeColor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbForeColor.Location = New System.Drawing.Point(17, 322)
        Me.chbForeColor.Name = "chbForeColor"
        Me.chbForeColor.Size = New System.Drawing.Size(155, 26)
        Me.chbForeColor.TabIndex = 140
        Me.chbForeColor.Text = "Fore color"
        '
        'chbOnlyTitle
        '
        Me.chbOnlyTitle.AccessibleName = "$"
        Me.chbOnlyTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbOnlyTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbOnlyTitle.Location = New System.Drawing.Point(458, 290)
        Me.chbOnlyTitle.Name = "chbOnlyTitle"
        Me.chbOnlyTitle.Size = New System.Drawing.Size(346, 26)
        Me.chbOnlyTitle.TabIndex = 115
        Me.chbOnlyTitle.Text = "Without DB field name in label"
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
        Me.txtL1.Size = New System.Drawing.Size(534, 30)
        Me.txtL1.TabIndex = 0
        Me.txtL1.TabStop = False
        Me.txtL1.Tag = "VP"
        Me.txtL1.Text = "Control label"
        '
        'chbRAligment
        '
        Me.chbRAligment.AccessibleName = "LRIGHTA"
        Me.chbRAligment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRAligment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRAligment.Location = New System.Drawing.Point(458, 256)
        Me.chbRAligment.Name = "chbRAligment"
        Me.chbRAligment.Size = New System.Drawing.Size(222, 26)
        Me.chbRAligment.TabIndex = 107
        Me.chbRAligment.Text = "Aligment right"
        '
        'chbFItalic
        '
        Me.chbFItalic.AccessibleName = "fontItalic"
        Me.chbFItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFItalic.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFItalic.Location = New System.Drawing.Point(458, 223)
        Me.chbFItalic.Name = "chbFItalic"
        Me.chbFItalic.Size = New System.Drawing.Size(122, 26)
        Me.chbFItalic.TabIndex = 109
        Me.chbFItalic.Text = "Italic"
        '
        'chbFBold
        '
        Me.chbFBold.AccessibleName = "fontBold"
        Me.chbFBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFBold.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFBold.Location = New System.Drawing.Point(17, 223)
        Me.chbFBold.Name = "chbFBold"
        Me.chbFBold.Size = New System.Drawing.Size(122, 26)
        Me.chbFBold.TabIndex = 105
        Me.chbFBold.Text = "Bold"
        '
        'chbCAligment
        '
        Me.chbCAligment.AccessibleName = "LCENTERA"
        Me.chbCAligment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCAligment.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCAligment.Location = New System.Drawing.Point(17, 256)
        Me.chbCAligment.Name = "chbCAligment"
        Me.chbCAligment.Size = New System.Drawing.Size(222, 26)
        Me.chbCAligment.TabIndex = 106
        Me.chbCAligment.Text = "Aligment center"
        '
        'chbFSize
        '
        Me.chbFSize.AccessibleName = ""
        Me.chbFSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFSize.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFSize.Location = New System.Drawing.Point(458, 322)
        Me.chbFSize.Name = "chbFSize"
        Me.chbFSize.Size = New System.Drawing.Size(145, 26)
        Me.chbFSize.TabIndex = 113
        Me.chbFSize.Text = "Font size"
        '
        'paneP21
        '
        Me.paneP21.Controls.Add(Me.btnP21OK)
        Me.paneP21.Controls.Add(Me.btnP21Cancel)
        Me.paneP21.Controls.Add(Me.txtL11)
        Me.paneP21.Controls.Add(Me.dgvHeaderSpec)
        Me.paneP21.Controls.Add(Me.Label69)
        Me.paneP21.Controls.Add(Me.Label70)
        Me.paneP21.Controls.Add(Me.dgvHeader)
        Me.paneP21.Location = New System.Drawing.Point(3, 340)
        Me.paneP21.Name = "paneP21"
        Me.paneP21.Size = New System.Drawing.Size(534, 50)
        Me.paneP21.TabIndex = 175
        Me.paneP21.Tag = "750"
        '
        'btnP21OK
        '
        Me.btnP21OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP21OK.Location = New System.Drawing.Point(19, 377)
        Me.btnP21OK.Name = "btnP21OK"
        Me.btnP21OK.Size = New System.Drawing.Size(128, 31)
        Me.btnP21OK.TabIndex = 174
        Me.btnP21OK.Tag = "21"
        Me.btnP21OK.Text = "OK"
        Me.btnP21OK.UseVisualStyleBackColor = True
        '
        'btnP21Cancel
        '
        Me.btnP21Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP21Cancel.Location = New System.Drawing.Point(155, 377)
        Me.btnP21Cancel.Name = "btnP21Cancel"
        Me.btnP21Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnP21Cancel.TabIndex = 173
        Me.btnP21Cancel.Tag = "21"
        Me.btnP21Cancel.Text = "Cancel"
        Me.btnP21Cancel.UseVisualStyleBackColor = True
        '
        'txtL11
        '
        Me.txtL11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtL11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtL11.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtL11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtL11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtL11.Location = New System.Drawing.Point(0, 0)
        Me.txtL11.Multiline = True
        Me.txtL11.Name = "txtL11"
        Me.txtL11.ReadOnly = True
        Me.txtL11.Size = New System.Drawing.Size(534, 30)
        Me.txtL11.TabIndex = 1
        Me.txtL11.TabStop = False
        Me.txtL11.Tag = "VP"
        Me.txtL11.Text = "Table Header"
        '
        'dgvHeaderSpec
        '
        Me.dgvHeaderSpec.AllowDrop = True
        Me.dgvHeaderSpec.AllowUserToOrderColumns = True
        Me.dgvHeaderSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvHeaderSpec.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvHeaderSpec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHeaderSpec.ColumnHeadersHeight = 30
        Me.dgvHeaderSpec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column10, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeaderSpec.DefaultCellStyle = DataGridViewCellStyle29
        Me.dgvHeaderSpec.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvHeaderSpec.GridColor = System.Drawing.SystemColors.Control
        Me.dgvHeaderSpec.Location = New System.Drawing.Point(886, 84)
        Me.dgvHeaderSpec.MultiSelect = False
        Me.dgvHeaderSpec.Name = "dgvHeaderSpec"
        Me.dgvHeaderSpec.RowHeadersWidth = 33
        DataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeaderSpec.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.dgvHeaderSpec.RowTemplate.Height = 30
        Me.dgvHeaderSpec.Size = New System.Drawing.Size(1302, 227)
        Me.dgvHeaderSpec.TabIndex = 161
        Me.dgvHeaderSpec.Tag = "0"
        '
        'Column7
        '
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.DefaultCellStyle = DataGridViewCellStyle22
        Me.Column7.HeaderText = "Header row number"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 146
        '
        'Column10
        '
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column10.DefaultCellStyle = DataGridViewCellStyle23
        Me.Column10.HeaderText = "Header row height"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 137
        '
        'Column12
        '
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle24
        Me.Column12.HeaderText = "Font size"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 82
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column13.DefaultCellStyle = DataGridViewCellStyle25
        Me.Column13.HeaderText = "Appearance"
        Me.Column13.Items.AddRange(New Object() {"FONTBOLD", "FONTITALIC", "FONTUNDERLINE"})
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 81
        '
        'Column14
        '
        Me.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column14.DefaultCellStyle = DataGridViewCellStyle26
        Me.Column14.HeaderText = "Aligment"
        Me.Column14.Items.AddRange(New Object() {"RIGHT", "LEFT"})
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 63
        '
        'Column15
        '
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column15.DefaultCellStyle = DataGridViewCellStyle27
        Me.Column15.HeaderText = "Fore color"
        Me.Column15.Name = "Column15"
        Me.Column15.Width = 89
        '
        'Column16
        '
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column16.DefaultCellStyle = DataGridViewCellStyle28
        Me.Column16.HeaderText = "Back color"
        Me.Column16.Name = "Column16"
        Me.Column16.Width = 92
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(17, 55)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(260, 13)
        Me.Label69.TabIndex = 160
        Me.Label69.Text = "* For merging, enter key word merge in cell"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(17, 33)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(310, 13)
        Me.Label70.TabIndex = 159
        Me.Label70.Text = "* In each row enter value of one header column text"
        '
        'dgvHeader
        '
        Me.dgvHeader.AllowDrop = True
        Me.dgvHeader.AllowUserToOrderColumns = True
        Me.dgvHeader.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvHeader.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHeader.ColumnHeadersHeight = 30
        Me.dgvHeader.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.Col18, Me.DataGridViewTextBoxColumn26})
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeader.DefaultCellStyle = DataGridViewCellStyle32
        Me.dgvHeader.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvHeader.GridColor = System.Drawing.SystemColors.Control
        Me.dgvHeader.Location = New System.Drawing.Point(17, 84)
        Me.dgvHeader.MultiSelect = False
        Me.dgvHeader.Name = "dgvHeader"
        Me.dgvHeader.RowHeadersWidth = 33
        DataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeader.RowsDefaultCellStyle = DataGridViewCellStyle33
        Me.dgvHeader.RowTemplate.Height = 30
        Me.dgvHeader.Size = New System.Drawing.Size(858, 227)
        Me.dgvHeader.TabIndex = 157
        Me.dgvHeader.Tag = "0"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.HeaderText = "Header row"
        Me.DataGridViewTextBoxColumn25.MaxInputLength = 2
        Me.DataGridViewTextBoxColumn25.MinimumWidth = 50
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'Col18
        '
        DataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Col18.DefaultCellStyle = DataGridViewCellStyle31
        Me.Col18.HeaderText = "Column "
        Me.Col18.Name = "Col18"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.HeaderText = "Header text"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ToolTipText = "In each row enter value of one header column text + vbcrlf +  For merging, leave " &
    "previous cells empty"
        Me.DataGridViewTextBoxColumn26.Width = 250
        '
        'paneP3
        '
        Me.paneP3.Controls.Add(Me.chbTabIndex)
        Me.paneP3.Controls.Add(Me.chbBN)
        Me.paneP3.Controls.Add(Me.Label73)
        Me.paneP3.Controls.Add(Me.Label74)
        Me.paneP3.Controls.Add(Me.Label75)
        Me.paneP3.Controls.Add(Me.txtSPOrderColumn)
        Me.paneP3.Controls.Add(Me.txtSPOrderRow)
        Me.paneP3.Controls.Add(Me.btnP3OK)
        Me.paneP3.Controls.Add(Me.btnP3Cancel)
        Me.paneP3.Controls.Add(Me.Label76)
        Me.paneP3.Controls.Add(Me.chbNQG)
        Me.paneP3.Controls.Add(Me.chbNTS)
        Me.paneP3.Controls.Add(Me.Label77)
        Me.paneP3.Controls.Add(Me.Label78)
        Me.paneP3.Controls.Add(Me.Label79)
        Me.paneP3.Controls.Add(Me.Label80)
        Me.paneP3.Controls.Add(Me.Label81)
        Me.paneP3.Controls.Add(Me.Label82)
        Me.paneP3.Controls.Add(Me.Label83)
        Me.paneP3.Controls.Add(Me.txtSPOrderTable)
        Me.paneP3.Controls.Add(Me.Label84)
        Me.paneP3.Controls.Add(Me.txtVS)
        Me.paneP3.Controls.Add(Me.txtON)
        Me.paneP3.Controls.Add(Me.chbNewWebGroup)
        Me.paneP3.Controls.Add(Me.chbRight)
        Me.paneP3.Controls.Add(Me.chbCentar)
        Me.paneP3.Controls.Add(Me.Mkc_ColorComboboxBC)
        Me.paneP3.Controls.Add(Me.Mkc_ColorComboboxFC)
        Me.paneP3.Controls.Add(Me.chbBC)
        Me.paneP3.Controls.Add(Me.chbFC)
        Me.paneP3.Controls.Add(Me.chbVF)
        Me.paneP3.Controls.Add(Me.chbEF)
        Me.paneP3.Controls.Add(Me.chbBF)
        Me.paneP3.Controls.Add(Me.chbFB)
        Me.paneP3.Controls.Add(Me.chbItalic)
        Me.paneP3.Controls.Add(Me.chbFU)
        Me.paneP3.Controls.Add(Me.txtMultilineH)
        Me.paneP3.Controls.Add(Me.chbMultiline)
        Me.paneP3.Controls.Add(Me.chbRO)
        Me.paneP3.Controls.Add(Me.txtL4)
        Me.paneP3.Controls.Add(Me.chbMultilineH)
        Me.paneP3.Location = New System.Drawing.Point(3, 396)
        Me.paneP3.Name = "paneP3"
        Me.paneP3.Size = New System.Drawing.Size(534, 50)
        Me.paneP3.TabIndex = 150
        Me.paneP3.Tag = "375"
        '
        'chbTabIndex
        '
        Me.chbTabIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbTabIndex.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTabIndex.Location = New System.Drawing.Point(586, 296)
        Me.chbTabIndex.Name = "chbTabIndex"
        Me.chbTabIndex.Size = New System.Drawing.Size(176, 26)
        Me.chbTabIndex.TabIndex = 256
        Me.chbTabIndex.Text = "Tab index"
        '
        'chbBN
        '
        Me.chbBN.AccessibleName = "borderNone"
        Me.chbBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBN.Location = New System.Drawing.Point(223, 380)
        Me.chbBN.Name = "chbBN"
        Me.chbBN.Size = New System.Drawing.Size(219, 26)
        Me.chbBN.TabIndex = 154
        Me.chbBN.Text = "None"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label73.Location = New System.Drawing.Point(1291, 187)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(31, 13)
        Me.Label73.TabIndex = 255
        Me.Label73.Text = "Row"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label74.Location = New System.Drawing.Point(1291, 216)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(51, 13)
        Me.Label74.TabIndex = 254
        Me.Label74.Text = "Column"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label75.Location = New System.Drawing.Point(1291, 157)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(37, 13)
        Me.Label75.TabIndex = 253
        Me.Label75.Text = "Table"
        '
        'txtSPOrderColumn
        '
        Me.txtSPOrderColumn.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSPOrderColumn.Location = New System.Drawing.Point(1198, 216)
        Me.txtSPOrderColumn.Name = "txtSPOrderColumn"
        Me.txtSPOrderColumn.Size = New System.Drawing.Size(84, 21)
        Me.txtSPOrderColumn.TabIndex = 252
        '
        'txtSPOrderRow
        '
        Me.txtSPOrderRow.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSPOrderRow.Location = New System.Drawing.Point(1198, 187)
        Me.txtSPOrderRow.Name = "txtSPOrderRow"
        Me.txtSPOrderRow.Size = New System.Drawing.Size(84, 21)
        Me.txtSPOrderRow.TabIndex = 251
        '
        'btnP3OK
        '
        Me.btnP3OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP3OK.Location = New System.Drawing.Point(15, 438)
        Me.btnP3OK.Name = "btnP3OK"
        Me.btnP3OK.Size = New System.Drawing.Size(128, 31)
        Me.btnP3OK.TabIndex = 250
        Me.btnP3OK.Tag = "3"
        Me.btnP3OK.Text = "OK"
        Me.btnP3OK.UseVisualStyleBackColor = True
        '
        'btnP3Cancel
        '
        Me.btnP3Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnP3Cancel.Location = New System.Drawing.Point(154, 438)
        Me.btnP3Cancel.Name = "btnP3Cancel"
        Me.btnP3Cancel.Size = New System.Drawing.Size(128, 31)
        Me.btnP3Cancel.TabIndex = 249
        Me.btnP3Cancel.Tag = "3"
        Me.btnP3Cancel.Text = "Cancel"
        Me.btnP3Cancel.UseVisualStyleBackColor = True
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label76.Location = New System.Drawing.Point(1198, 263)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(231, 13)
        Me.Label76.TabIndex = 248
        Me.Label76.Text = "Control marks new question group"
        '
        'chbNQG
        '
        Me.chbNQG.AccessibleName = ""
        Me.chbNQG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNQG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNQG.Location = New System.Drawing.Point(1198, 288)
        Me.chbNQG.Name = "chbNQG"
        Me.HP.SetShowHelp(Me.chbNQG, False)
        Me.chbNQG.Size = New System.Drawing.Size(342, 28)
        Me.chbNQG.TabIndex = 247
        Me.chbNQG.Text = "Desktop, CAPI, CATI"
        '
        'chbNTS
        '
        Me.chbNTS.AccessibleName = ""
        Me.chbNTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNTS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNTS.Location = New System.Drawing.Point(586, 261)
        Me.chbNTS.Name = "chbNTS"
        Me.chbNTS.Size = New System.Drawing.Size(176, 28)
        Me.chbNTS.TabIndex = 246
        Me.chbNTS.Text = "No tab stop"
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label77.Location = New System.Drawing.Point(31, 350)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(87, 13)
        Me.Label77.TabIndex = 245
        Me.Label77.Text = "Border style"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label78.Location = New System.Drawing.Point(31, 278)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(97, 13)
        Me.Label78.TabIndex = 244
        Me.Label78.Text = "Text aligment"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label79.Location = New System.Drawing.Point(31, 64)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(36, 13)
        Me.Label79.TabIndex = 243
        Me.Label79.Text = "Font"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label80.Location = New System.Drawing.Point(1167, 32)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(51, 13)
        Me.Label80.TabIndex = 242
        Me.Label80.Text = "Layout"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label81.Location = New System.Drawing.Point(554, 32)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(65, 13)
        Me.Label81.TabIndex = 241
        Me.Label81.Text = "Behavior"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label82.Location = New System.Drawing.Point(9, 32)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(85, 13)
        Me.Label82.TabIndex = 238
        Me.Label82.Text = "Appereance"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label83.Location = New System.Drawing.Point(1198, 129)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(148, 13)
        Me.Label83.TabIndex = 170
        Me.Label83.Text = "Screen position order"
        '
        'txtSPOrderTable
        '
        Me.txtSPOrderTable.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSPOrderTable.Location = New System.Drawing.Point(1198, 157)
        Me.txtSPOrderTable.Name = "txtSPOrderTable"
        Me.txtSPOrderTable.Size = New System.Drawing.Size(84, 21)
        Me.txtSPOrderTable.TabIndex = 169
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(1291, 92)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(83, 13)
        Me.Label84.TabIndex = 168
        Me.Label84.Text = "Control width"
        '
        'txtVS
        '
        Me.txtVS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVS.Location = New System.Drawing.Point(1198, 92)
        Me.txtVS.Name = "txtVS"
        Me.txtVS.Size = New System.Drawing.Size(84, 21)
        Me.txtVS.TabIndex = 167
        '
        'txtON
        '
        Me.txtON.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtON.Location = New System.Drawing.Point(834, 296)
        Me.txtON.Name = "txtON"
        Me.txtON.Size = New System.Drawing.Size(84, 21)
        Me.txtON.TabIndex = 165
        Me.txtON.Visible = False
        '
        'chbNewWebGroup
        '
        Me.chbNewWebGroup.AccessibleName = ""
        Me.chbNewWebGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNewWebGroup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNewWebGroup.Location = New System.Drawing.Point(1198, 321)
        Me.chbNewWebGroup.Name = "chbNewWebGroup"
        Me.chbNewWebGroup.Size = New System.Drawing.Size(342, 28)
        Me.chbNewWebGroup.TabIndex = 164
        Me.chbNewWebGroup.Text = "Web"
        '
        'chbRight
        '
        Me.chbRight.AccessibleName = "frighta"
        Me.chbRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRight.Location = New System.Drawing.Point(35, 308)
        Me.chbRight.Name = "chbRight"
        Me.chbRight.Size = New System.Drawing.Size(171, 26)
        Me.chbRight.TabIndex = 163
        Me.chbRight.Text = "Right"
        '
        'chbCentar
        '
        Me.chbCentar.AccessibleName = "fCenterA"
        Me.chbCentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCentar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCentar.Location = New System.Drawing.Point(223, 308)
        Me.chbCentar.Name = "chbCentar"
        Me.chbCentar.Size = New System.Drawing.Size(219, 26)
        Me.chbCentar.TabIndex = 162
        Me.chbCentar.Text = "Center"
        '
        'Mkc_ColorComboboxBC
        '
        Me.Mkc_ColorComboboxBC.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorComboboxBC.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorComboboxBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorComboboxBC.Location = New System.Drawing.Point(207, 226)
        Me.Mkc_ColorComboboxBC.Name = "Mkc_ColorComboboxBC"
        Me.Mkc_ColorComboboxBC.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorComboboxBC.Size = New System.Drawing.Size(247, 30)
        Me.Mkc_ColorComboboxBC.TabIndex = 161
        Me.Mkc_ColorComboboxBC.Visible = False
        '
        'Mkc_ColorComboboxFC
        '
        Me.Mkc_ColorComboboxFC.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorComboboxFC.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorComboboxFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorComboboxFC.Location = New System.Drawing.Point(207, 193)
        Me.Mkc_ColorComboboxFC.Name = "Mkc_ColorComboboxFC"
        Me.Mkc_ColorComboboxFC.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorComboboxFC.Size = New System.Drawing.Size(247, 30)
        Me.Mkc_ColorComboboxFC.TabIndex = 160
        Me.Mkc_ColorComboboxFC.Tag = "VF"
        Me.Mkc_ColorComboboxFC.Visible = False
        '
        'chbBC
        '
        Me.chbBC.AccessibleName = ""
        Me.chbBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBC.Location = New System.Drawing.Point(35, 226)
        Me.chbBC.Name = "chbBC"
        Me.chbBC.Size = New System.Drawing.Size(155, 26)
        Me.chbBC.TabIndex = 159
        Me.chbBC.Text = "Back color"
        '
        'chbFC
        '
        Me.chbFC.AccessibleName = ""
        Me.chbFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFC.Location = New System.Drawing.Point(35, 193)
        Me.chbFC.Name = "chbFC"
        Me.chbFC.Size = New System.Drawing.Size(155, 26)
        Me.chbFC.TabIndex = 158
        Me.chbFC.Text = "Fore color"
        '
        'chbVF
        '
        Me.chbVF.AccessibleName = "visiblefalse"
        Me.chbVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVF.Location = New System.Drawing.Point(586, 159)
        Me.chbVF.Name = "chbVF"
        Me.chbVF.Size = New System.Drawing.Size(176, 26)
        Me.chbVF.TabIndex = 157
        Me.chbVF.Text = "Visible false"
        '
        'chbEF
        '
        Me.chbEF.AccessibleName = "enabledfalse"
        Me.chbEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEF.Location = New System.Drawing.Point(586, 193)
        Me.chbEF.Name = "chbEF"
        Me.chbEF.Size = New System.Drawing.Size(176, 26)
        Me.chbEF.TabIndex = 156
        Me.chbEF.Text = "Enable false"
        '
        'chbBF
        '
        Me.chbBF.AccessibleName = "borderFixed"
        Me.chbBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBF.Location = New System.Drawing.Point(35, 380)
        Me.chbBF.Name = "chbBF"
        Me.chbBF.Size = New System.Drawing.Size(163, 26)
        Me.chbBF.TabIndex = 155
        Me.chbBF.Text = "Fixed single"
        '
        'chbFB
        '
        Me.chbFB.AccessibleName = "fontbold"
        Me.chbFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFB.Location = New System.Drawing.Point(35, 92)
        Me.chbFB.Name = "chbFB"
        Me.chbFB.Size = New System.Drawing.Size(155, 26)
        Me.chbFB.TabIndex = 152
        Me.chbFB.Text = "Bold"
        '
        'chbItalic
        '
        Me.chbItalic.AccessibleName = "fontitalic"
        Me.chbItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbItalic.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbItalic.Location = New System.Drawing.Point(35, 125)
        Me.chbItalic.Name = "chbItalic"
        Me.chbItalic.Size = New System.Drawing.Size(155, 26)
        Me.chbItalic.TabIndex = 151
        Me.chbItalic.Text = "Italic"
        '
        'chbFU
        '
        Me.chbFU.AccessibleName = "fontunderline"
        Me.chbFU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFU.Location = New System.Drawing.Point(35, 159)
        Me.chbFU.Name = "chbFU"
        Me.chbFU.Size = New System.Drawing.Size(155, 26)
        Me.chbFU.TabIndex = 150
        Me.chbFU.Text = "Underline"
        '
        'txtMultilineH
        '
        Me.txtMultilineH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMultilineH.Location = New System.Drawing.Point(834, 125)
        Me.txtMultilineH.Name = "txtMultilineH"
        Me.txtMultilineH.Size = New System.Drawing.Size(84, 21)
        Me.txtMultilineH.TabIndex = 149
        Me.txtMultilineH.Visible = False
        '
        'chbMultiline
        '
        Me.chbMultiline.AccessibleName = "multiline"
        Me.chbMultiline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMultiline.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMultiline.Location = New System.Drawing.Point(586, 92)
        Me.chbMultiline.Name = "chbMultiline"
        Me.chbMultiline.Size = New System.Drawing.Size(176, 26)
        Me.chbMultiline.TabIndex = 131
        Me.chbMultiline.Text = "Multiline"
        '
        'chbRO
        '
        Me.chbRO.AccessibleName = "readonly"
        Me.chbRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRO.Location = New System.Drawing.Point(586, 226)
        Me.chbRO.Name = "chbRO"
        Me.chbRO.Size = New System.Drawing.Size(176, 26)
        Me.chbRO.TabIndex = 129
        Me.chbRO.Text = "Read Only"
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
        Me.txtL4.Size = New System.Drawing.Size(534, 30)
        Me.txtL4.TabIndex = 2
        Me.txtL4.TabStop = False
        Me.txtL4.Tag = "VP"
        Me.txtL4.Text = "Apperance Behavior Layout "
        '
        'chbMultilineH
        '
        Me.chbMultilineH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMultilineH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMultilineH.Location = New System.Drawing.Point(587, 125)
        Me.chbMultilineH.Name = "chbMultilineH"
        Me.chbMultilineH.Size = New System.Drawing.Size(248, 26)
        Me.chbMultilineH.TabIndex = 148
        Me.chbMultilineH.Text = "Multiline height in px"
        '
        'panePPreview
        '
        Me.panePPreview.Controls.Add(Me.Label91)
        Me.panePPreview.Controls.Add(Me.PanelCPE)
        Me.panePPreview.Controls.Add(Me.llPreviewC)
        Me.panePPreview.Controls.Add(Me.ucvt)
        Me.panePPreview.Controls.Add(Me.llC2)
        Me.panePPreview.Controls.Add(Me.llC1)
        Me.panePPreview.Controls.Add(Me.llC3)
        Me.panePPreview.Controls.Add(Me.cboCPE)
        Me.panePPreview.Controls.Add(Me.txtlblPPreview)
        Me.panePPreview.Controls.Add(Me.clbLang)
        Me.panePPreview.Controls.Add(Me.btnAddLang)
        Me.panePPreview.Controls.Add(Me.Label85)
        Me.panePPreview.Controls.Add(Me.Label88)
        Me.panePPreview.Controls.Add(Me.Label89)
        Me.panePPreview.Controls.Add(Me.llC6)
        Me.panePPreview.Controls.Add(Me.llC5)
        Me.panePPreview.Controls.Add(Me.llC4)
        Me.panePPreview.Controls.Add(Me.cbTableDescription)
        Me.panePPreview.Controls.Add(Me.cbLabel)
        Me.panePPreview.Controls.Add(Me.cbLabelVF)
        Me.panePPreview.Controls.Add(Me.cbAwls)
        Me.panePPreview.Controls.Add(Me.llCC7)
        Me.panePPreview.Controls.Add(Me.cbMessage)
        Me.panePPreview.Controls.Add(Me.llC8)
        Me.panePPreview.Controls.Add(Me.llC9)
        Me.panePPreview.Controls.Add(Me.cbQE)
        Me.panePPreview.Location = New System.Drawing.Point(3, 3)
        Me.panePPreview.Name = "panePPreview"
        Me.panePPreview.Size = New System.Drawing.Size(534, 113)
        Me.panePPreview.TabIndex = 0
        Me.panePPreview.Tag = "580"
        '
        'Label91
        '
        Me.Label91.BackColor = System.Drawing.Color.AntiqueWhite
        Me.Label91.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label91.Location = New System.Drawing.Point(1214, 50)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(119, 18)
        Me.Label91.TabIndex = 980
        Me.Label91.Text = "colorTest"
        Me.Label91.Visible = False
        '
        'PanelCPE
        '
        Me.PanelCPE.Controls.Add(Me.btnOKCPE)
        Me.PanelCPE.Controls.Add(Me.btnCancelCPE)
        Me.PanelCPE.Controls.Add(Me.dgvCPE)
        Me.PanelCPE.Location = New System.Drawing.Point(1027, 233)
        Me.PanelCPE.Name = "PanelCPE"
        Me.PanelCPE.Size = New System.Drawing.Size(336, 67)
        Me.PanelCPE.TabIndex = 198
        Me.PanelCPE.Visible = False
        '
        'btnOKCPE
        '
        Me.btnOKCPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOKCPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOKCPE.Location = New System.Drawing.Point(38, 5)
        Me.btnOKCPE.Margin = New System.Windows.Forms.Padding(15, 13, 15, 13)
        Me.btnOKCPE.Name = "btnOKCPE"
        Me.btnOKCPE.Size = New System.Drawing.Size(128, 31)
        Me.btnOKCPE.TabIndex = 181
        Me.btnOKCPE.Tag = "0"
        Me.btnOKCPE.Text = "Save"
        Me.btnOKCPE.UseVisualStyleBackColor = True
        '
        'btnCancelCPE
        '
        Me.btnCancelCPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelCPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelCPE.Location = New System.Drawing.Point(175, 5)
        Me.btnCancelCPE.Margin = New System.Windows.Forms.Padding(15, 13, 15, 13)
        Me.btnCancelCPE.Name = "btnCancelCPE"
        Me.btnCancelCPE.Size = New System.Drawing.Size(128, 31)
        Me.btnCancelCPE.TabIndex = 180
        Me.btnCancelCPE.Tag = "0"
        Me.btnCancelCPE.Text = "Exit"
        Me.btnCancelCPE.UseVisualStyleBackColor = True
        '
        'dgvCPE
        '
        Me.dgvCPE.AllowUserToAddRows = False
        Me.dgvCPE.AllowUserToDeleteRows = False
        Me.dgvCPE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCPE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCPE.Location = New System.Drawing.Point(0, 0)
        Me.dgvCPE.Name = "dgvCPE"
        Me.dgvCPE.Size = New System.Drawing.Size(336, 67)
        Me.dgvCPE.TabIndex = 10000027
        '
        'llPreviewC
        '
        Me.llPreviewC.ActiveLinkColor = System.Drawing.Color.Black
        Me.llPreviewC.BackColor = System.Drawing.Color.Transparent
        Me.llPreviewC.DisabledLinkColor = System.Drawing.Color.Black
        Me.llPreviewC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llPreviewC.LinkColor = System.Drawing.Color.Black
        Me.llPreviewC.Location = New System.Drawing.Point(282, 94)
        Me.llPreviewC.Name = "llPreviewC"
        Me.llPreviewC.Size = New System.Drawing.Size(537, 32)
        Me.llPreviewC.TabIndex = 196
        Me.llPreviewC.TabStop = True
        Me.llPreviewC.Text = "Preview data entry form"
        '
        'ucvt
        '
        Me.ucvt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ucvt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvt.Location = New System.Drawing.Point(51, 72)
        Me.ucvt.Name = "ucvt"
        Me.ucvt.Size = New System.Drawing.Size(125, 75)
        Me.ucvt.TabIndex = 202
        '
        'llC2
        '
        Me.llC2.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC2.BackColor = System.Drawing.Color.Transparent
        Me.llC2.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC2.LinkColor = System.Drawing.Color.Black
        Me.llC2.Location = New System.Drawing.Point(51, 239)
        Me.llC2.Name = "llC2"
        Me.llC2.Size = New System.Drawing.Size(391, 24)
        Me.llC2.TabIndex = 197
        Me.llC2.TabStop = True
        Me.llC2.Tag = "2"
        Me.llC2.Text = "Label's (as virtual field) text"
        '
        'llC1
        '
        Me.llC1.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC1.BackColor = System.Drawing.Color.Transparent
        Me.llC1.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC1.LinkColor = System.Drawing.Color.Black
        Me.llC1.Location = New System.Drawing.Point(51, 206)
        Me.llC1.Name = "llC1"
        Me.llC1.Size = New System.Drawing.Size(391, 24)
        Me.llC1.TabIndex = 200
        Me.llC1.TabStop = True
        Me.llC1.Tag = "1"
        Me.llC1.Text = "Simple label's text"
        '
        'llC3
        '
        Me.llC3.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC3.BackColor = System.Drawing.Color.Transparent
        Me.llC3.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC3.LinkColor = System.Drawing.Color.Black
        Me.llC3.Location = New System.Drawing.Point(51, 272)
        Me.llC3.Name = "llC3"
        Me.llC3.Size = New System.Drawing.Size(391, 24)
        Me.llC3.TabIndex = 201
        Me.llC3.TabStop = True
        Me.llC3.Tag = "3"
        Me.llC3.Text = "Rename column's (field's) name"
        '
        'cboCPE
        '
        Me.cboCPE.CausesValidation = False
        Me.cboCPE.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboCPE.FormattingEnabled = True
        Me.cboCPE.Location = New System.Drawing.Point(1027, 199)
        Me.cboCPE.Name = "cboCPE"
        Me.cboCPE.Size = New System.Drawing.Size(331, 21)
        Me.cboCPE.TabIndex = 199
        Me.cboCPE.Text = "Choose screen form number"
        Me.cboCPE.Visible = False
        '
        'txtlblPPreview
        '
        Me.txtlblPPreview.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtlblPPreview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtlblPPreview.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtlblPPreview.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtlblPPreview.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtlblPPreview.Location = New System.Drawing.Point(0, 0)
        Me.txtlblPPreview.Multiline = True
        Me.txtlblPPreview.Name = "txtlblPPreview"
        Me.txtlblPPreview.ReadOnly = True
        Me.txtlblPPreview.Size = New System.Drawing.Size(534, 30)
        Me.txtlblPPreview.TabIndex = 1
        Me.txtlblPPreview.TabStop = False
        Me.txtlblPPreview.Tag = "VP"
        Me.txtlblPPreview.Text = "Preview, various texts changing"
        '
        'clbLang
        '
        Me.clbLang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbLang.ColumnWidth = 180
        Me.clbLang.FormattingEnabled = True
        Me.clbLang.Location = New System.Drawing.Point(58, 436)
        Me.clbLang.MultiColumn = True
        Me.clbLang.Name = "clbLang"
        Me.clbLang.Size = New System.Drawing.Size(364, 208)
        Me.clbLang.TabIndex = 978
        Me.clbLang.TabStop = False
        Me.clbLang.Visible = False
        '
        'btnAddLang
        '
        Me.btnAddLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddLang.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnAddLang.Location = New System.Drawing.Point(1044, 613)
        Me.btnAddLang.Name = "btnAddLang"
        Me.btnAddLang.Size = New System.Drawing.Size(145, 31)
        Me.btnAddLang.TabIndex = 979
        Me.btnAddLang.Tag = ""
        Me.btnAddLang.Text = "Add"
        Me.btnAddLang.UseVisualStyleBackColor = True
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label85.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label85.Location = New System.Drawing.Point(38, 351)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(1334, 28)
        Me.Label85.TabIndex = 974
        Me.Label85.Text = "Add for selected languages (*If some always visible label/label exists it will NO" &
    "T be overwritten)"
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label88.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label88.Location = New System.Drawing.Point(31, 164)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(1334, 28)
        Me.Label88.TabIndex = 975
        Me.Label88.Text = "Changing texts  (changes are possible in yellow columns)"
        '
        'Label89
        '
        Me.Label89.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label89.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label89.Location = New System.Drawing.Point(31, 42)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(1334, 28)
        Me.Label89.TabIndex = 976
        Me.Label89.Text = "Preview"
        '
        'llC6
        '
        Me.llC6.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC6.BackColor = System.Drawing.Color.Transparent
        Me.llC6.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC6.LinkColor = System.Drawing.Color.Black
        Me.llC6.Location = New System.Drawing.Point(51, 305)
        Me.llC6.Name = "llC6"
        Me.llC6.Size = New System.Drawing.Size(456, 24)
        Me.llC6.TabIndex = 986
        Me.llC6.TabStop = True
        Me.llC6.Tag = "6"
        Me.llC6.Text = "Multilanguage table title (description) text"
        '
        'llC5
        '
        Me.llC5.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC5.BackColor = System.Drawing.Color.Transparent
        Me.llC5.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC5.LinkColor = System.Drawing.Color.Black
        Me.llC5.Location = New System.Drawing.Point(537, 239)
        Me.llC5.Name = "llC5"
        Me.llC5.Size = New System.Drawing.Size(473, 24)
        Me.llC5.TabIndex = 983
        Me.llC5.TabStop = True
        Me.llC5.Tag = "5"
        Me.llC5.Text = "Multilanguage lable's (as virtual field) text"
        '
        'llC4
        '
        Me.llC4.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC4.BackColor = System.Drawing.Color.Transparent
        Me.llC4.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC4.LinkColor = System.Drawing.Color.Black
        Me.llC4.Location = New System.Drawing.Point(537, 272)
        Me.llC4.Name = "llC4"
        Me.llC4.Size = New System.Drawing.Size(473, 24)
        Me.llC4.TabIndex = 203
        Me.llC4.TabStop = True
        Me.llC4.Tag = "4"
        Me.llC4.Text = "Multilanguage always visible lable's text"
        '
        'cbTableDescription
        '
        Me.cbTableDescription.AccessibleName = ""
        Me.cbTableDescription.AutoSize = True
        Me.cbTableDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTableDescription.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTableDescription.Location = New System.Drawing.Point(843, 386)
        Me.cbTableDescription.Name = "cbTableDescription"
        Me.cbTableDescription.Size = New System.Drawing.Size(117, 17)
        Me.cbTableDescription.TabIndex = 985
        Me.cbTableDescription.Text = "table description"
        '
        'cbLabel
        '
        Me.cbLabel.AccessibleName = ""
        Me.cbLabel.AutoSize = True
        Me.cbLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLabel.Location = New System.Drawing.Point(624, 386)
        Me.cbLabel.Name = "cbLabel"
        Me.cbLabel.Size = New System.Drawing.Size(95, 17)
        Me.cbLabel.TabIndex = 984
        Me.cbLabel.Text = "simple label "
        '
        'cbLabelVF
        '
        Me.cbLabelVF.AccessibleName = ""
        Me.cbLabelVF.AutoSize = True
        Me.cbLabelVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLabelVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLabelVF.Location = New System.Drawing.Point(336, 386)
        Me.cbLabelVF.Name = "cbLabelVF"
        Me.cbLabelVF.Size = New System.Drawing.Size(145, 17)
        Me.cbLabelVF.TabIndex = 982
        Me.cbLabelVF.Text = "label (as virtual field)"
        '
        'cbAwls
        '
        Me.cbAwls.AccessibleName = ""
        Me.cbAwls.AutoSize = True
        Me.cbAwls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAwls.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAwls.Location = New System.Drawing.Point(58, 386)
        Me.cbAwls.Name = "cbAwls"
        Me.cbAwls.Size = New System.Drawing.Size(133, 17)
        Me.cbAwls.TabIndex = 981
        Me.cbAwls.Text = "always visible label"
        '
        'llCC7
        '
        Me.llCC7.ActiveLinkColor = System.Drawing.Color.Black
        Me.llCC7.BackColor = System.Drawing.Color.Transparent
        Me.llCC7.DisabledLinkColor = System.Drawing.Color.Black
        Me.llCC7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llCC7.LinkColor = System.Drawing.Color.Black
        Me.llCC7.Location = New System.Drawing.Point(537, 206)
        Me.llCC7.Name = "llCC7"
        Me.llCC7.Size = New System.Drawing.Size(473, 24)
        Me.llCC7.TabIndex = 987
        Me.llCC7.TabStop = True
        Me.llCC7.Tag = "7"
        Me.llCC7.Text = "Multilanguage simple label's text"
        '
        'cbMessage
        '
        Me.cbMessage.AccessibleName = ""
        Me.cbMessage.AutoSize = True
        Me.cbMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMessage.Location = New System.Drawing.Point(1104, 386)
        Me.cbMessage.Name = "cbMessage"
        Me.cbMessage.Size = New System.Drawing.Size(157, 17)
        Me.cbMessage.TabIndex = 989
        Me.cbMessage.Text = "additional 10 messages"
        '
        'llC8
        '
        Me.llC8.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC8.BackColor = System.Drawing.Color.Transparent
        Me.llC8.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC8.LinkColor = System.Drawing.Color.Black
        Me.llC8.Location = New System.Drawing.Point(537, 305)
        Me.llC8.Name = "llC8"
        Me.llC8.Size = New System.Drawing.Size(473, 24)
        Me.llC8.TabIndex = 988
        Me.llC8.TabStop = True
        Me.llC8.Tag = "8"
        Me.llC8.Text = "Multilanguage message's text"
        '
        'llC9
        '
        Me.llC9.ActiveLinkColor = System.Drawing.Color.Black
        Me.llC9.BackColor = System.Drawing.Color.Transparent
        Me.llC9.DisabledLinkColor = System.Drawing.Color.Black
        Me.llC9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llC9.LinkColor = System.Drawing.Color.Black
        Me.llC9.Location = New System.Drawing.Point(1027, 305)
        Me.llC9.Name = "llC9"
        Me.llC9.Size = New System.Drawing.Size(363, 24)
        Me.llC9.TabIndex = 991
        Me.llC9.TabStop = True
        Me.llC9.Tag = "9"
        Me.llC9.Text = "Question explanation's text"
        '
        'cbQE
        '
        Me.cbQE.AccessibleName = ""
        Me.cbQE.AutoSize = True
        Me.cbQE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbQE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQE.Location = New System.Drawing.Point(1104, 434)
        Me.cbQE.Name = "cbQE"
        Me.cbQE.Size = New System.Drawing.Size(141, 17)
        Me.cbQE.TabIndex = 990
        Me.cbQE.Text = "question explanation"
        '
        'paneT8
        '
        Me.paneT8.Controls.Add(Me.btnTSubmit)
        Me.paneT8.Controls.Add(Me.btnTSubmitCancel)
        Me.paneT8.Controls.Add(Me.txtTUpdate)
        Me.paneT8.Location = New System.Drawing.Point(3, 529)
        Me.paneT8.Name = "paneT8"
        Me.paneT8.Padding = New System.Windows.Forms.Padding(5, 0, 20, 20)
        Me.paneT8.Size = New System.Drawing.Size(534, 70)
        Me.paneT8.TabIndex = 172
        Me.paneT8.Tag = "500"
        Me.paneT8.Visible = False
        '
        'btnTSubmit
        '
        Me.btnTSubmit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnTSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTSubmit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnTSubmit.ForeColor = System.Drawing.Color.White
        Me.btnTSubmit.Location = New System.Drawing.Point(3, 2)
        Me.btnTSubmit.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTSubmit.Name = "btnTSubmit"
        Me.btnTSubmit.Size = New System.Drawing.Size(128, 34)
        Me.btnTSubmit.TabIndex = 174
        Me.btnTSubmit.Tag = "6"
        Me.btnTSubmit.Text = "Submit"
        Me.btnTSubmit.UseVisualStyleBackColor = False
        '
        'btnTSubmitCancel
        '
        Me.btnTSubmitCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTSubmitCancel.BackColor = System.Drawing.Color.DimGray
        Me.btnTSubmitCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTSubmitCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnTSubmitCancel.ForeColor = System.Drawing.Color.White
        Me.btnTSubmitCancel.Location = New System.Drawing.Point(3, 36)
        Me.btnTSubmitCancel.Margin = New System.Windows.Forms.Padding(10)
        Me.btnTSubmitCancel.Name = "btnTSubmitCancel"
        Me.btnTSubmitCancel.Size = New System.Drawing.Size(128, 30)
        Me.btnTSubmitCancel.TabIndex = 173
        Me.btnTSubmitCancel.Tag = "6"
        Me.btnTSubmitCancel.Text = "Cancel"
        Me.btnTSubmitCancel.UseVisualStyleBackColor = False
        '
        'txtTUpdate
        '
        Me.txtTUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTUpdate.Location = New System.Drawing.Point(136, 2)
        Me.txtTUpdate.Multiline = True
        Me.txtTUpdate.Name = "txtTUpdate"
        Me.txtTUpdate.Size = New System.Drawing.Size(111, 59)
        Me.txtTUpdate.TabIndex = 0
        '
        'paneP6
        '
        Me.paneP6.Controls.Add(Me.btnCSubmit)
        Me.paneP6.Controls.Add(Me.btnCSubmitCancel)
        Me.paneP6.Controls.Add(Me.txtCUpdate)
        Me.paneP6.Location = New System.Drawing.Point(555, 529)
        Me.paneP6.Name = "paneP6"
        Me.paneP6.Padding = New System.Windows.Forms.Padding(5, 0, 20, 20)
        Me.paneP6.Size = New System.Drawing.Size(534, 70)
        Me.paneP6.TabIndex = 172
        Me.paneP6.Tag = "200"
        Me.paneP6.Visible = False
        '
        'btnCSubmit
        '
        Me.btnCSubmit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnCSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCSubmit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCSubmit.ForeColor = System.Drawing.Color.White
        Me.btnCSubmit.Location = New System.Drawing.Point(3, 2)
        Me.btnCSubmit.Name = "btnCSubmit"
        Me.btnCSubmit.Size = New System.Drawing.Size(128, 34)
        Me.btnCSubmit.TabIndex = 178
        Me.btnCSubmit.Tag = "0"
        Me.btnCSubmit.Text = "Submit"
        Me.btnCSubmit.UseVisualStyleBackColor = False
        '
        'btnCSubmitCancel
        '
        Me.btnCSubmitCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCSubmitCancel.BackColor = System.Drawing.Color.DimGray
        Me.btnCSubmitCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCSubmitCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCSubmitCancel.ForeColor = System.Drawing.Color.White
        Me.btnCSubmitCancel.Location = New System.Drawing.Point(3, 36)
        Me.btnCSubmitCancel.Name = "btnCSubmitCancel"
        Me.btnCSubmitCancel.Size = New System.Drawing.Size(128, 30)
        Me.btnCSubmitCancel.TabIndex = 177
        Me.btnCSubmitCancel.Tag = "0"
        Me.btnCSubmitCancel.Text = "Cancel"
        Me.btnCSubmitCancel.UseVisualStyleBackColor = False
        '
        'txtCUpdate
        '
        Me.txtCUpdate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUpdate.Location = New System.Drawing.Point(136, 2)
        Me.txtCUpdate.Multiline = True
        Me.txtCUpdate.Name = "txtCUpdate"
        Me.txtCUpdate.Size = New System.Drawing.Size(111, 59)
        Me.txtCUpdate.TabIndex = 176
        '
        'mnu01
        '
        Me.mnu01.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu01.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnu01.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DDFIND})
        Me.mnu01.Name = "mnuColumn"
        Me.mnu01.ShowCheckMargin = True
        Me.mnu01.Size = New System.Drawing.Size(120, 26)
        '
        'DDFIND
        '
        Me.DDFIND.Name = "DDFIND"
        Me.DDFIND.Size = New System.Drawing.Size(119, 22)
        Me.DDFIND.Text = "Find"
        '
        'mnu02
        '
        Me.mnu02.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu02.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnu02.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tDCI, Me.tDCDB, Me.ToolStripSeparator11, Me.tRenameC, Me.tFC, Me.tssc11, Me.tssc1, Me.tssc12, Me.tssc2, Me.tssc3, Me.tssc4, Me.tssc5, Me.tssc6, Me.ToolStripSeparator15, Me.tRefresh})
        Me.mnu02.Name = "mnuColumn"
        Me.mnu02.ShowCheckMargin = True
        Me.mnu02.Size = New System.Drawing.Size(339, 273)
        '
        'tDCI
        '
        Me.tDCI.Name = "tDCI"
        Me.tDCI.Size = New System.Drawing.Size(338, 22)
        Me.tDCI.Text = "Delete field from IST"
        '
        'tDCDB
        '
        Me.tDCDB.Name = "tDCDB"
        Me.tDCDB.Size = New System.Drawing.Size(338, 22)
        Me.tDCDB.Text = "Delete column from DB and field from IST"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(335, 6)
        '
        'tRenameC
        '
        Me.tRenameC.Name = "tRenameC"
        Me.tRenameC.Size = New System.Drawing.Size(338, 22)
        Me.tRenameC.Text = "Rename field/column"
        '
        'tFC
        '
        Me.tFC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tFC.Name = "tFC"
        Me.tFC.Size = New System.Drawing.Size(100, 23)
        Me.tFC.Text = "Find field"
        '
        'tssc11
        '
        Me.tssc11.Name = "tssc11"
        Me.tssc11.Size = New System.Drawing.Size(335, 6)
        '
        'tssc1
        '
        Me.tssc1.Name = "tssc1"
        Me.tssc1.Size = New System.Drawing.Size(338, 22)
        Me.tssc1.Text = "Add column/control"
        Me.tssc1.Visible = False
        '
        'tssc12
        '
        Me.tssc12.Name = "tssc12"
        Me.tssc12.Size = New System.Drawing.Size(335, 6)
        '
        'tssc2
        '
        Me.tssc2.Name = "tssc2"
        Me.tssc2.Size = New System.Drawing.Size(338, 22)
        Me.tssc2.Text = "Properties"
        '
        'tssc3
        '
        Me.tssc3.Name = "tssc3"
        Me.tssc3.Size = New System.Drawing.Size(338, 22)
        Me.tssc3.Text = "Control Type"
        '
        'tssc4
        '
        Me.tssc4.Name = "tssc4"
        Me.tssc4.Size = New System.Drawing.Size(338, 22)
        Me.tssc4.Text = "Label"
        '
        'tssc5
        '
        Me.tssc5.Name = "tssc5"
        Me.tssc5.Size = New System.Drawing.Size(338, 22)
        Me.tssc5.Text = "Table Header"
        '
        'tssc6
        '
        Me.tssc6.Name = "tssc6"
        Me.tssc6.Size = New System.Drawing.Size(338, 22)
        Me.tssc6.Text = "Appereance Behavior Layout"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(335, 6)
        '
        'tRefresh
        '
        Me.tRefresh.Name = "tRefresh"
        Me.tRefresh.Size = New System.Drawing.Size(338, 22)
        Me.tRefresh.Text = "Refresh"
        '
        'mnuColumnNumber
        '
        Me.mnuColumnNumber.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuColumnNumber.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuColumnNumber.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nhide, Me.nunhide, Me.ToolStripSeparator3, Me.nsort, Me.nmcs, Me.ToolStripSeparator4, Me.nfind, Me.ToolStripSeparator5, Me.nequals, Me.ndnequals, Me.nfilter, Me.nunfilterall, Me.ToolStripSeparator6, Me.nfreeze, Me.nunfreezeall, Me.ToolStripSeparator7, Me.nafc, Me.nafw, Me.nafch, Me.nacrw})
        Me.mnuColumnNumber.Name = "mnuColumn"
        Me.mnuColumnNumber.ShowCheckMargin = True
        Me.mnuColumnNumber.Size = New System.Drawing.Size(240, 386)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(236, 6)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(236, 6)
        '
        'nfind
        '
        Me.nfind.Name = "nfind"
        Me.nfind.Size = New System.Drawing.Size(239, 22)
        Me.nfind.Text = "Find"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(236, 6)
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(236, 6)
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
        'nacrw
        '
        Me.nacrw.Name = "nacrw"
        Me.nacrw.Size = New System.Drawing.Size(239, 22)
        Me.nacrw.Text = "Reset column width"
        '
        'mnuColumnText
        '
        Me.mnuColumnText.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuColumnText.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuColumnText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dhide, Me.dunhide, Me.ToolStripSeparator17, Me.dsort, Me.dmcs, Me.ToolStripSeparator18, Me.DFIND2, Me.ToolStripSeparator8, Me.dequals, Me.ddnequals, Me.dfilter, Me.dunfilterall, Me.ToolStripSeparator9, Me.dfreeze, Me.dunfreezeall, Me.ToolStripSeparator10, Me.DAFC2, Me.DAFW2, Me.DAFCh2, Me.DACRW})
        Me.mnuColumnText.Name = "mnuColumn"
        Me.mnuColumnText.ShowCheckMargin = True
        Me.mnuColumnText.Size = New System.Drawing.Size(240, 364)
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
        'DFIND2
        '
        Me.DFIND2.Name = "DFIND2"
        Me.DFIND2.Size = New System.Drawing.Size(239, 22)
        Me.DFIND2.Text = "Find"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(236, 6)
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
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(236, 6)
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
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(236, 6)
        '
        'DAFC2
        '
        Me.DAFC2.Name = "DAFC2"
        Me.DAFC2.Size = New System.Drawing.Size(239, 22)
        Me.DAFC2.Text = "AutoFit to context"
        '
        'DAFW2
        '
        Me.DAFW2.Name = "DAFW2"
        Me.DAFW2.Size = New System.Drawing.Size(239, 22)
        Me.DAFW2.Text = "AutoFit to window"
        '
        'DAFCh2
        '
        Me.DAFCh2.Name = "DAFCh2"
        Me.DAFCh2.Size = New System.Drawing.Size(239, 22)
        Me.DAFCh2.Text = "AutoFit to column header"
        '
        'DACRW
        '
        Me.DACRW.Name = "DACRW"
        Me.DACRW.Size = New System.Drawing.Size(239, 22)
        Me.DACRW.Text = "Reset column width"
        '
        'mnu03
        '
        Me.mnu03.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu03.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnu03.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tdtI, Me.tdtDB, Me.ToolStripSeparator12, Me.tRenameT, Me.tFT, Me.ToolStripSeparator13, Me.tsst1, Me.ToolStripSeparator14, Me.tsst2, Me.tsst3, Me.tsst4, Me.tsst5, Me.tsst6, Me.tsst7, Me.tsst8, Me.tsst9, Me.ToolStripSeparator16, Me.ttRefresh})
        Me.mnu03.Name = "mnuColumn"
        Me.mnu03.ShowCheckMargin = True
        Me.mnu03.Size = New System.Drawing.Size(273, 339)
        '
        'tdtI
        '
        Me.tdtI.Name = "tdtI"
        Me.tdtI.Size = New System.Drawing.Size(272, 22)
        Me.tdtI.Text = "Delete table from IST"
        '
        'tdtDB
        '
        Me.tdtDB.Name = "tdtDB"
        Me.tdtDB.Size = New System.Drawing.Size(272, 22)
        Me.tdtDB.Text = "Delete table from DB and IST"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(269, 6)
        '
        'tRenameT
        '
        Me.tRenameT.Name = "tRenameT"
        Me.tRenameT.Size = New System.Drawing.Size(272, 22)
        Me.tRenameT.Text = "Rename table"
        '
        'tFT
        '
        Me.tFT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tFT.Name = "tFT"
        Me.tFT.Size = New System.Drawing.Size(100, 23)
        Me.tFT.Text = "Find table"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(269, 6)
        '
        'tsst1
        '
        Me.tsst1.Name = "tsst1"
        Me.tsst1.Size = New System.Drawing.Size(272, 22)
        Me.tsst1.Text = "Add table"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(269, 6)
        '
        'tsst2
        '
        Me.tsst2.Name = "tsst2"
        Me.tsst2.Size = New System.Drawing.Size(272, 22)
        Me.tsst2.Text = "Properties"
        '
        'tsst3
        '
        Me.tsst3.Name = "tsst3"
        Me.tsst3.Size = New System.Drawing.Size(272, 22)
        Me.tsst3.Text = "Title"
        '
        'tsst4
        '
        Me.tsst4.Name = "tsst4"
        Me.tsst4.Size = New System.Drawing.Size(272, 22)
        Me.tsst4.Text = "Main table"
        '
        'tsst5
        '
        Me.tsst5.Name = "tsst5"
        Me.tsst5.Size = New System.Drawing.Size(272, 22)
        Me.tsst5.Text = "Subtable"
        '
        'tsst6
        '
        Me.tsst6.Name = "tsst6"
        Me.tsst6.Size = New System.Drawing.Size(272, 22)
        Me.tsst6.Text = "OnSaveButton.Click Event"
        '
        'tsst7
        '
        Me.tsst7.Name = "tsst7"
        Me.tsst7.Size = New System.Drawing.Size(272, 22)
        Me.tsst7.Text = "OnSaveNextButton.Click Event"
        '
        'tsst8
        '
        Me.tsst8.Name = "tsst8"
        Me.tsst8.Size = New System.Drawing.Size(272, 22)
        Me.tsst8.Text = "OnExitButton.Click Event"
        '
        'tsst9
        '
        Me.tsst9.Name = "tsst9"
        Me.tsst9.Size = New System.Drawing.Size(272, 22)
        Me.tsst9.Text = "Note"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(269, 6)
        '
        'ttRefresh
        '
        Me.ttRefresh.Name = "ttRefresh"
        Me.ttRefresh.Size = New System.Drawing.Size(272, 22)
        Me.ttRefresh.Text = "Refresh tables"
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
        Me.PanelTop.Size = New System.Drawing.Size(1370, 40)
        Me.PanelTop.TabIndex = 143
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
        Me.b3.Size = New System.Drawing.Size(741, 32)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1330, 0)
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
        Me.Logovan.Location = New System.Drawing.Point(1078, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_ISTTables
        '
        Me.ClientSize = New System.Drawing.Size(1370, 644)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_ISTTables"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit
        Me.mnu00.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.PerformLayout
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer4.ResumeLayout(False)
        Me.TableLayoutPanelTABLE.ResumeLayout(False)
        Me.paneT2.ResumeLayout(False)
        Me.paneT2.PerformLayout
        CType(Me.dgvDontOpen, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneAWL.ResumeLayout(False)
        Me.paneAWL.PerformLayout
        Me.paneT3.ResumeLayout(False)
        Me.paneT3.PerformLayout
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvOnButtonClickStop, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbBFS, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneAT.ResumeLayout(False)
        Me.paneAT.PerformLayout
        Me.gbCopy.ResumeLayout(False)
        Me.gbCopy.PerformLayout
        CType(Me.tbSAT, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbHAT, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneT0.ResumeLayout(False)
        Me.paneT0.PerformLayout
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout
        Me.paneT1.ResumeLayout(False)
        Me.paneT1.PerformLayout
        CType(Me.tbFS, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.tbH, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneT4.ResumeLayout(False)
        Me.paneT4.PerformLayout
        CType(Me.dgvOnSaveExec, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneT5.ResumeLayout(False)
        Me.paneT5.PerformLayout
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage41.ResumeLayout(False)
        CType(Me.dgvOnSaveNextStop, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage42.ResumeLayout(False)
        CType(Me.dgvOnSaveNextNote, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage43.ResumeLayout(False)
        CType(Me.dgvOnSaveNextSimpleMSG, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage44.ResumeLayout(False)
        CType(Me.dgvOnSaveNextMSG, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage45.ResumeLayout(False)
        CType(Me.dgvOnSaveNextClose, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage46.ResumeLayout(False)
        CType(Me.dgvOnSaveNextFocusOn, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage47.ResumeLayout(False)
        CType(Me.dgvOnSaveNextDelete, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage48.ResumeLayout(False)
        CType(Me.dgvOnSaveNextExec, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneT6.ResumeLayout(False)
        Me.paneT6.PerformLayout
        CType(Me.dgvOnExitMSG, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneT7.ResumeLayout(False)
        Me.paneT7.PerformLayout
        CType(Me.tbNFS, System.ComponentModel.ISupportInitialize).EndInit
        Me.TableLayoutPanelCOLUMN.ResumeLayout(False)
        Me.paneAC.ResumeLayout(False)
        Me.paneAC.PerformLayout
        Me.gbOptionsAC.ResumeLayout(False)
        Me.gbOptionsAC.PerformLayout
        Me.PanelAAT.ResumeLayout(False)
        Me.PanelAAT.PerformLayout
        Me.gbApp.ResumeLayout(False)
        Me.TabPageRa.ResumeLayout(False)
        Me.TabPageRa.PerformLayout
        CType(Me.dgvAppR, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPageCa.ResumeLayout(False)
        Me.TabPageCa.PerformLayout
        CType(Me.dgvAppC, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbUC.ResumeLayout(False)
        Me.gbUC.PerformLayout
        Me.paneP0.ResumeLayout(False)
        Me.paneP0.PerformLayout
        Me.paneP1.ResumeLayout(False)
        Me.paneP1.PerformLayout
        Me.TabControlDGV.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgvGridStop, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout
        Me.TabPage8.ResumeLayout(False)
        CType(Me.dgvGridColumn, System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage9.ResumeLayout(False)
        CType(Me.dgvGridAddCol, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbCBO.ResumeLayout(False)
        Me.gbCBO.PerformLayout
        CType(Me.dgvRB, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbAC.ResumeLayout(False)
        Me.gbAC.PerformLayout
        Me.paneP2.ResumeLayout(False)
        Me.paneP2.PerformLayout
        CType(Me.tbFSize, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneP21.ResumeLayout(False)
        Me.paneP21.PerformLayout
        CType(Me.dgvHeaderSpec, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneP3.ResumeLayout(False)
        Me.paneP3.PerformLayout
        Me.panePPreview.ResumeLayout(False)
        Me.panePPreview.PerformLayout
        Me.PanelCPE.ResumeLayout(False)
        CType(Me.dgvCPE, System.ComponentModel.ISupportInitialize).EndInit
        Me.paneT8.ResumeLayout(False)
        Me.paneT8.PerformLayout
        Me.paneP6.ResumeLayout(False)
        Me.paneP6.PerformLayout
        Me.mnu01.ResumeLayout(False)
        Me.mnu02.ResumeLayout(False)
        Me.mnu02.PerformLayout
        Me.mnuColumnNumber.ResumeLayout(False)
        Me.mnuColumnText.ResumeLayout(False)
        Me.mnu03.ResumeLayout(False)
        Me.mnu03.PerformLayout
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
    Dim lokalno As Boolean
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka

    Public Sub New(ByVal DBConnectionString As String, ByVal ISTConnectionString As String, ByVal txtmode As String, ByVal jezik As String,
                   ByVal DSBrisanjeDEPO As String, ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String,
                   ByVal mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka)

        Me.New()

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size

        Me.Logovan.Text = GetUserName.ToString.Trim
        Me.ISTConnectionString = ISTConnectionString

        Me.txtmode = txtmode
        Me.jezik = jezik
        Call SetLang()

        Me.DSBrisanjeDEPO = DSBrisanjeDEPO
        Me.DSBrisanjeServer = DSBrisanjeServer
        Me.DSBrisanjeBaza = DSBrisanjeBaza
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

        ucvt.Init(mvt)
        Me.vt = mvt

        Dim strSQl As String = "select distinct IDLang as valuemember,Language + ' ' +IDLang as displaymember from ISTLanguage order by 1"

        Call popuniclb(clbLang, strSQl, Me.ISTConnectionString, Me.jezik)
    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "GUI")
        b3.Text = getControlText2(dt, "naslov8", Me.jezik)
        b3.Text = "Edit ISTTablesColumns"

    End Sub

    Sub popuniNDcbo(ByVal cbo As ComboBox)
        Dim strSQl As String = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" + cboIST.SelectedValue.ToString + "' and isnull(typeOfTableParentChild,'') not in ('S','A','K','O') order by 1"
        Call popunicbo(cbo, strSQl, Me.ISTConnectionString)
    End Sub

    Private Sub cboGT_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call popuniNDcbo(cboNadTabela)
    End Sub

    Dim dtvRepIstPolja As DataTable

    Private Sub cboIST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIST.SelectedIndexChanged
        If Me.cboIST.SelectedValue <> "" Then
            appCode = cboIST.SelectedValue.ToString.Trim
            Call DajTabelePoljaIST(tv)
            Me.DBConnectionString = constr(appCode)
            Call TpaneSize()
            Call CpaneSize()
        End If
    End Sub

    Sub DajTabelePoljaIST(ByVal tv As TreeView)

        Me.Cursor = Cursors.WaitCursor

        Dim vodIST As String = ""
        Dim vdoIST As String = ""
        Dim strIST As String = "select vod, vdo from IST where sifist=N'" + appCode + "'"
        Dim dtv As DataTable = izvrsiSQLvratiDT(strIST, Me.ISTConnectionString, Nothing)

        Dim vodA As String = vodApp(appCode)
        vodIST = vodA.Split("$")(0)
        vdoIST = vodA.Split("$")(1)

        dtvRepIstPolja = fdtvRepIstPoljaTabelaSP(appCode, "", "")

        Dim izrazODBC As String = ""
        tv.Nodes.Clear()

        Dim sqlT As String = "select tabela from isttabele where sifist=N'" + appCode + "' order by tabela"
        Dim dtT As New System.Data.DataTable
        dtT = izvrsiSQLvratiDT(sqlT, Me.ISTConnectionString, Me.jezik)

        Dim node As TreeNode
        node = tv.Nodes.Add("Add table")
        node.Tag = "ADDTT$" + vodIST + "$" + vdoIST

        tv.Visible = True

        Dim pompolje As String = ""

        If dtT.Rows.Count > 0 Then
            For t As Integer = 0 To dtT.Rows.Count - 1
                Dim tabela As String = dtT.Rows(t).Item("tabela").ToString.Trim.ToUpper
                node = tv.Nodes.Add(tabela)

                node.Tag = "TT" + tabela + "$" + vodTabela(appCode, tabela).Split("$")(0)

                Dim slTab As String = ""

                Dim redoviMEM2() As DataRow = dtvRepIstPolja.Select("tabela='" + tabela + "'", "rbr ASC")

                If redoviMEM2.Length = 0 Then
                    node.Nodes.Add("Add column")
                    node.Nodes(node.Nodes.Count - 1).Tag = "ADDCC$" + vodIST + "$10$" + vdoIST
                End If

                If redoviMEM2.Length > 0 Then
                    Dim polje As String = redoviMEM2(0).Item("polje").ToString.Trim
                    Dim vod As String = Format(redoviMEM2(0).Item("vod"), "yyyy-MM-dd")
                    node.Nodes.Add("Add column")
                    node.Nodes(node.Nodes.Count - 1).Tag = "ADDCC$" + vodIST + "$" + maxrbr(appCode, tabela) + "$" + vdoIST

                    For i As Integer = 0 To redoviMEM2.Length - 1
                        polje = redoviMEM2(i).Item("polje").ToString.Trim
                        vod = Format(redoviMEM2(i).Item("vod"), "yyyy-MM-dd")
                        node.Nodes.Add(polje)

                        node.Nodes(node.Nodes.Count - 1).Tag = "CC" + tabela + "." + polje + "$" + vod + "$" + maxrbr(appCode, tabela)

                        pompolje = redoviMEM2(i).Item("pp").ToString.Trim.ToUpper
                        If pompolje = "LBL" Then node.Nodes(node.Nodes.Count - 1).ToolTipText = redoviMEM2(i).Item("izraz").ToString.TrimEnd("'").TrimStart("'")

                    Next
                End If
            Next
        End If

        tv.ShowNodeToolTips = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Function fdtvRepIstPoljaTabelaSP(ByVal app As String, ByVal tabela As String, ByVal vtvt As String) As DataTable
        Dim sql As String = "exec usp_vRepIstPoljaTabela @sifist=N'" + app.Trim + "', @tabela=N'" + tabela.Trim + "',@vt='" + vtvt + "'"
        fdtvRepIstPoljaTabelaSP = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function

    Function constr(ByVal appcode As String)
        constr = Me.DBConnectionString
        Dim sql As String = " select distinct databaseAlias,rdatabase,databaseserver,connectionDoc,ODBC from vBazaServerEng where appcode=N'" + appcode + "' "
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)
        If dt.Rows.Count > 0 AndAlso Not dt.Rows(0).Item("ODBC") Is System.DBNull.Value AndAlso dt.Rows(0).Item("ODBC") <> "" Then
            constr = dt.Rows(0).Item("ODBC").ToString.Trim.Replace("Provider=SQLOLEDB.1;", "") + ";Integrated Security=SSPI;Persist Security Info=False"
        End If
    End Function

    Function vodTabela(ByVal appcode As String, ByVal tablename As String)
        Dim vod As String = "2010-1-1" : Dim vdo As String = "2999-1-1"
        Dim sqlT As String = "select vod,vdo from Isttabele where sifist=N'" + appcode + "' and  tabela=N'" + tablename + "'"
        Dim dtT As New System.Data.DataTable
        dtT = izvrsiSQLvratiDT(sqlT, Me.ISTConnectionString, Me.jezik)
        If dtT.Rows.Count > 0 Then
            vod = Format(dtT.Rows(0).Item(0), "yyyy-MM-dd")
            vdo = Format(dtT.Rows(0).Item(1), "yyyy-MM-dd")
        End If
        vodTabela = vod + "$" + vdo
    End Function

    Function vodApp(ByVal appcode As String) As String
        Dim vod As String = "2010-1-1" : Dim vdo As String = "2999-1-1"
        Dim sqlT As String = "select vod,vdo from IST where sifist=N'" + appcode + "'"
        Dim dtT As New System.Data.DataTable
        dtT = izvrsiSQLvratiDT(sqlT, Me.ISTConnectionString, Me.jezik)
        If dtT.Rows.Count > 0 Then
            vod = Format(dtT.Rows(0).Item(0), "yyyy-MM-dd")
            vdo = Format(dtT.Rows(0).Item(1), "yyyy-MM-dd")
        End If
        vodApp = vod + "$" + vdo
    End Function

    Function maxrbr(ByVal appcode As String, ByVal tablename As String)
        maxrbr = 100
        Dim sqlTM As String = "select max(rbr) as MM from IstPolja where sifist=N'" + appcode + "' and tabela=N'" + tablename + "'"
        Dim dtTM As New System.Data.DataTable
        dtTM = izvrsiSQLvratiDT(sqlTM, Me.ISTConnectionString, Me.jezik)
        If dtTM.Rows.Count > 0 Then maxrbr = dtTM.Rows(0).Item(0).ToString.Trim
    End Function

    Dim ttable As String = ""
    Dim vvod As String = ""

    Private Sub rbD_CheckedChanged(sender As Object, e As EventArgs) Handles rbD.CheckedChanged
        Me.lblGT.Visible = rbD.Checked
        Me.cboNadTabela.Visible = rbD.Checked
        Me.cboNadTabela.Focus()
    End Sub

    Private Sub cbpAVL_CheckedChanged(sender As Object, e As EventArgs) Handles cbAVL.CheckedChanged
        paneAWL.Visible = cbAVL.Checked
        txtDT.Visible = cbAVL.Checked
    End Sub

    Private Sub cbFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbFC.CheckedChanged
        Mkc_ColorCombobox1T.Visible = cbFC.Checked
        If cbFC.Checked = False Then Mkc_ColorCombobox1T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbBC.CheckedChanged
        Mkc_ColorCombobox2T.Visible = cbBC.Checked
        If cbBC.Checked = False Then Mkc_ColorCombobox2T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbawlFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbAWLFC.CheckedChanged
        Mkc_ColorCombobox7T.Visible = cbAWLFC.Checked
        If cbAWLFC.Checked = False Then Mkc_ColorCombobox7T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cawlbBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbAWLBC.CheckedChanged
        Mkc_ColorCombobox8T.Visible = cbAWLBC.Checked
        If cbAWLBC.Checked = False Then Mkc_ColorCombobox8T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbcGH_CheckedChanged(sender As Object, e As EventArgs)
        txtGH.Visible = cbGH.Checked
    End Sub

    Private Sub cbcbH_CheckedChanged(sender As Object, e As EventArgs)
        txtT2BH.Visible = cbBH.Checked
    End Sub

    Private Sub cbcbW_CheckedChanged(sender As Object, e As EventArgs)
        txtT2BW.Visible = cbBW.Checked
    End Sub

    Private Sub cbcFC_CheckedChanged(sender As Object, e As EventArgs)
        Mkc_ColorCombobox3T.Visible = cbT2BFC.Checked
        If cbT2BFC.Checked = False Then Mkc_ColorCombobox3T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbcBC_CheckedChanged(sender As Object, e As EventArgs)
        Mkc_ColorCombobox4T.Visible = cbT2BBC.Checked
        If cbT2BBC.Checked = False Then Mkc_ColorCombobox4T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbcDESO_CheckedChanged(sender As Object, e As EventArgs)
        txtDESO.Visible = cbDESO.Checked
    End Sub

    Private Sub tv_ItemDrag(ByVal sender As Object, ByVal e As ItemDragEventArgs) Handles tv.ItemDrag
        Dim tv As TreeView = CType(sender, TreeView)
        Dim nd As TreeNode = DirectCast(e.Item, TreeNode)
        If nd.Nodes.Count = 0 Then
            tv.SelectedNode = nd
            Dim EffectCursor As New Cursor(New System.IO.MemoryStream(My.Resources.Move))
            tv.DoDragDrop(nd.Text, DragDropEffects.Copy)
            tv.SelectedNode.Checked = True
            Dim ttaagg As String = tv.SelectedNode.Tag
        End If
    End Sub

    Private Sub cbNoteFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbNoteFC.CheckedChanged
        Mkc_ColorCombobox5T.Visible = cbNoteFC.Checked
        If cbNoteFC.Checked = False Then Mkc_ColorCombobox5T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbNoteBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbNoteBC.CheckedChanged
        Mkc_ColorCombobox6T.Visible = cbNoteBC.Checked
        If cbNoteBC.Checked = False Then Mkc_ColorCombobox6T.SelectedColor = System.Drawing.Color.Empty
    End Sub

    Private Sub cbNoteS_CheckedChanged(sender As Object, e As EventArgs) Handles cbNoteS.CheckedChanged
        tbNFS.Visible = cbNoteS.Checked
        If cbNoteS.Checked = False Then tbNFS.Value = tbNFS.Tag
    End Sub

    Dim rc As ResizeableControl

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load


        Me.SplitContainer4.SplitterDistance = 50
        Me.SplitContainer1.SplitterDistance = 250

        '***********
        'TABLE
        '***********

        Call TpaneSize()

        Me.paneAT.Dock = DockStyle.Fill
        Me.paneT0.Dock = DockStyle.Fill
        Me.paneT1.Dock = DockStyle.Fill
        Me.paneT2.Dock = DockStyle.Fill
        Me.paneT3.Dock = DockStyle.Fill
        Me.paneT4.Dock = DockStyle.Fill
        Me.paneT5.Dock = DockStyle.Fill
        Me.paneT6.Dock = DockStyle.Fill
        Me.paneT7.Dock = DockStyle.Fill
        Me.paneT8.Dock = DockStyle.Bottom

        'Me.txtTUpdate.Dock = DockStyle.Fill
        txtTUpdate.Location = New Point(btnTSubmit.Location.X + btnTSubmit.Width + 5, 2)
        txtTUpdate.Width = paneT8.Width - btnTSubmit.Width - 10
        txtTUpdate.Height = paneT8.Height - 4
        Me.TableLayoutPanelTABLE.Dock = DockStyle.Fill

        txtNote.Width = Me.paneT7.Width - Me.txtNote.Location.X - 5

        TabControl1.Location = New Point(cbOnSaveNextDontClose.Location.X, cbOnSaveNextDontClose.Location.Y + cbOnSaveNextDontClose.Height + 25)
        TabControl1.Width = Me.paneT5.Width - TabControl1.Location.X - 25

        dgvDontOpen.AllowUserToAddRows = False
        dgvDontOpen.Width = Me.paneT2.Width - dgvDontOpen.Location.X - 25


        dgvOnSaveExec.AllowUserToAddRows = False
        dgvOnSaveNextClose.AllowUserToAddRows = False
        dgvOnSaveNextStop.AllowUserToAddRows = False
        dgvOnSaveNextExec.AllowUserToAddRows = False
        dgvOnExitMSG.Width = Me.paneT6.Width - dgvOnExitMSG.Location.X - 25

        '***********
        'COLUMN
        '***********

        Call CpaneSize()
        Me.panePPreview.Dock = DockStyle.Fill
        Me.paneAC.Dock = DockStyle.Fill
        Me.paneP0.Dock = DockStyle.Fill
        Me.paneP1.Dock = DockStyle.Fill
        Me.paneP2.Dock = DockStyle.Fill
        Me.paneP21.Dock = DockStyle.Fill
        Me.paneP3.Dock = DockStyle.Fill

        Me.paneP6.Dock = DockStyle.Bottom

        'Me.txtCUpdate.Dock = DockStyle.Fill
        txtCUpdate.Location = New Point(btnCSubmit.Location.X + btnCSubmit.Width + 5, 2)
        txtCUpdate.Width = paneP6.Width - btnCSubmit.Width - 10
        txtCUpdate.Height = paneP6.Height - 4
        Me.TableLayoutPanelCOLUMN.Dock = DockStyle.Fill

        '***********
        'Ne mogu oni kojima je meta nasledjen od neke druge app
        Dim strSQl As String = "select distinct sifist as displaymember,sifist as valuemember from IST where isnull(sifrat,0)=4 and isnull(abaza,'') not like '%IST=%' and isnull(abaza,'') not like '%IST =%' order by 1"
        Call popunicbo(cboIST, strSQl, Me.ISTConnectionString)

        'gbOptionsAC.Width = Me.paneAC.Width - gbOptionsAC.Location.X - 25

        'Me.PanelAAT.Width = gbOptionsAC.Width - 25
        'Me.gbApp.Width = gbOptionsAC.Width - 50

    End Sub

    Sub TpaneSize()
        Me.paneAT.AutoSize = False
        Me.paneT0.AutoSize = False
        Me.paneT1.AutoSize = False
        Me.paneT2.AutoSize = False
        Me.paneT3.AutoSize = False
        Me.paneT4.AutoSize = False
        Me.paneT5.AutoSize = False
        Me.paneT6.AutoSize = False
        Me.paneT7.AutoSize = False

        Me.paneAT.Height = 20
        Me.paneT0.Height = 20
        Me.paneT1.Height = 20
        Me.paneT2.Height = 20
        Me.paneT3.Height = 20
        Me.paneT4.Height = 20
        Me.paneT5.Height = 20
        Me.paneT6.Height = 20
        Me.paneT7.Height = 20

    End Sub

    Sub CpaneSize()
        Me.panePPreview.AutoSize = False
        Me.paneAC.AutoSize = False
        Me.paneP0.AutoSize = False
        Me.paneP1.AutoSize = False
        Me.paneP2.AutoSize = False
        Me.paneP21.AutoSize = False
        Me.paneP3.AutoSize = False
        Me.panePPreview.Height = 20
        Me.paneAC.Height = 20
        Me.paneP0.Height = 20
        Me.paneP1.Height = 20
        Me.paneP2.Height = 20
        Me.paneP21.Height = 20
        Me.paneP3.Height = 20

    End Sub

    Sub openCloseT(ByVal txt As TextBox, ByVal pnl As Panel)

        For Each p As Panel In TableLayoutPanelTABLE.Controls
            If p.Equals(pnl) Then
                If p.Height > 50 Then
                    p.AutoSize = False
                    p.Height = 20
                Else
                    p.AutoSize = True
                    If txt.Name = "txtTL4" Then
                        dgvOnSaveExec.Height = p.Height - 25
                        dgvOnSaveExec.Rows(0).Height = 100
                    ElseIf txt.Name = "txtTL5" Then
                        'TabControl1.Height = p.Height - 50
                        TabControl1.Width = Me.paneT5.Width - TabControl1.Location.X - 25

                        dgvOnSaveNextStop.Height = TabControl1.Height - 25
                        dgvOnSaveNextStop.Rows(0).Height = 100

                        dgvOnSaveNextClose.Height = TabControl1.Height - 25
                        dgvOnSaveNextClose.Rows(0).Height = 100

                        dgvOnSaveNextExec.Height = TabControl1.Height - 25
                        dgvOnSaveNextExec.Rows(0).Height = 100
                    ElseIf txt.Name = "txtTL6" Then
                        dgvOnExitMSG.Width = Me.paneT6.Width - dgvOnExitMSG.Location.X - 25
                        dgvOnExitMSG.Rows(0).Height = 100
                    End If
                End If
            Else
                p.AutoSize = False
                p.Height = 20
            End If
        Next
    End Sub

    Private Sub txtClickT(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTLAT.Click, txtTL0.Click, txtTL1.Click, txtTL2.Click, txtTL3.Click, txtTL4.Click, txtTL5.Click, txtTL6.Click, txtTL7.Click
        Dim txt As TextBox = CType(sender, TextBox)
        Dim pnl As Panel = txt.Parent

        Dim vodIST As String = "" : Dim vdoIST As String = ""
        Dim vodA As String = vodApp(appCode)
        vodIST = vodA.Split("$")(0) : vdoIST = vodA.Split("$")(1)

        Me.txtvodAT.Text = vodIST
        Me.txtvdoAT.Text = vdoIST

        Call openCloseT(txt, pnl)
    End Sub

    Private Sub txtClickC(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlblPPreview.Click, txtCLAC.Click, txtL0.Click, txtL1.Click, txtL11.Click, txtL4.Click, txtL6.Click
        Dim txt As TextBox = CType(sender, TextBox)
        Dim pnl As Panel = txt.Parent

        Dim vv() As String = vodTabela(appCode, tabela).Split("$")
        Me.txtvodAC.Text = vv(0)
        Me.txtvdoAC.Text = vv(1)

        Call openCloseC(txt, pnl)
    End Sub

    Sub openCloseC(ByVal txt As TextBox, ByVal pnl As Panel)
        For Each p As Panel In TableLayoutPanelCOLUMN.Controls
            If p.Equals(pnl) Then
                If p.Height > 50 Then
                    p.AutoSize = False
                    p.Height = 20
                Else
                    'p.Height = CInt(p.Tag.ToString)
                    p.AutoSize = True
                    If txt.Name = "txtCLAC" Then
                        gbOptionsAC.Width = Me.paneAC.Width - gbOptionsAC.Location.X - 25
                        Me.PanelAAT.Width = gbOptionsAC.Width - 25
                        Me.gbApp.Width = gbOptionsAC.Width - 50
                    ElseIf txt.Name = "txtL11" Then
                        dgvHeader.Height = p.Height - 150
                        dgvHeaderSpec.Height = p.Height - 50
                        btnP21OK.Location = New Point(5, p.Height - 50)
                        btnP21Cancel.Location = New Point(5 + btnT1OK.Width + 5, p.Height - 50)
                    End If
                End If
            Else
                p.AutoSize = False
                p.Height = 20
            End If
        Next
    End Sub

    Private Sub Mkc_ColorCombobox1_SelectedColorChanged(SelectedColor As Color) Handles Mkc_ColorCombobox1T.SelectedColorChanged
        If r4.SelectedColor.Name = "Chocalate" Then r4.SelectedColor = Color.Chocolate
        If r4.SelectedColor.Name = "Lavander" Then r3.SelectedColor = Color.Lavender
        If r4.SelectedColor.Name = "Transparent" Then r4.SelectedColor = Color.Snow
        If r3.SelectedColor.Name = "Chocalate" Then r3.SelectedColor = Color.Chocolate
        If r3.SelectedColor.Name = "Lavander" Then r3.SelectedColor = Color.Lavender
        Mkc_ColorCombobox1T.AccessibleName = "foreColor" + Me.Mkc_ColorCombobox1T.SelectedColor.ToString
    End Sub

    Private Sub Mkc_ColorCombobox2_SelectedColorChanged(SelectedColor As Color) Handles Mkc_ColorCombobox2T.SelectedColorChanged
        Mkc_ColorCombobox2T.AccessibleName = "backColor" + Me.Mkc_ColorCombobox2T.SelectedColor.ToString
    End Sub

    Dim typeOfTableParentChild As String = ""
    Dim parentTableName As String = ""
    Dim ValidFrom As String = ""
    Dim ValidTo As String = ""
    Dim tableDescription As String = ""
    Dim tableOrder As String = ""

    Dim dataentryScreenOrder As String = ""
    Dim parentAtributes As String = ""
    Dim childAtributes As String = ""

    Dim tabela As String = ""
    Dim tValidFrom As String = ""
    Dim tMaxRbr As String = ""

    Private Sub tv_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles tv.NodeMouseDoubleClick
        Me.cboCPE.Visible = False
        promenaVOD = False

        Dim mySelectedNode As TreeNode
        mySelectedNode = tv.SelectedNode
        If Not mySelectedNode Is Nothing Then
            If e.Button = MouseButtons.Left Then
                Call tvNodeMouseDoubleClick(mySelectedNode)
            End If
        End If
    End Sub

    Sub tvNodeMouseDoubleClick(ByVal mySelectedNode As TreeNode)

        If mySelectedNode.Tag.indexof("ADDTT") = 0 Then
            Me.TableLayoutPanelCOLUMN.Visible = False
            Me.paneP6.Visible = False
            Me.TableLayoutPanelTABLE.Visible = True
            Me.paneT8.Visible = True
            Call rResetT()
            txtTLAT.Text = "Add table to app: " + appCode
            Call openCloseT(txtTLAT, txtTLAT.Parent)
            Dim pp() As String = mySelectedNode.Tag.split("$")
            Me.txtvodAT.Text = pp(1).Trim
            Me.txtvdoAT.Text = pp(2).Trim
            Me.txtTL0.Text = "Table : " + " new table" + "    in _ISTTables of IST metadata"

        ElseIf mySelectedNode.Tag.indexof("ADDCC") = 0 Then
            Me.TableLayoutPanelTABLE.Visible = False
            Me.paneT8.Visible = False
            Me.TableLayoutPanelCOLUMN.Visible = True
            Me.paneP6.Visible = True
            Dim tt As String = txtCLAC.Text.Replace("Add column to table:", "").Trim
            tabela = mySelectedNode.Parent.Text
            If tt.Trim.ToUpper <> tabela.Trim.ToUpper Then
                Call rResetC()
            End If
            txtCLAC.Text = "Add column to table: " + tabela
            Me.txtL0.Text = "Column :" + " new column" + "    in _ISTTablesColumns of IST metadata"

            Dim pp() As String = mySelectedNode.Tag.split("$")
            tValidFrom = pp(1).Trim
            tMaxRbr = pp(2).Trim

            Dim vv() As String = vodTabela(appCode, tabela).Split("$")
            Me.txtvodAC.Text = vv(0)
            Me.txtvdoAC.Text = vv(1)

            If txtCLAC.Parent.Height <= 50 Then Call openCloseC(txtCLAC, txtCLAC.Parent)
            Me.txtNameAC.Focus()

        ElseIf mySelectedNode.Tag.indexof("TT") = 0 Then
            Me.TableLayoutPanelCOLUMN.Visible = False
            Me.paneP6.Visible = False
            Me.TableLayoutPanelTABLE.Visible = True
            Me.paneT8.Visible = True

            Call rResetT()
            tabela = mySelectedNode.Text
            txtTLAT.Text = "Add table to app: " + appCode
            If ttable <> mySelectedNode.Tag Then Call dajT(mySelectedNode)

        ElseIf mySelectedNode.Tag.indexof("CC") = 0 Then
            Me.TableLayoutPanelTABLE.Visible = False
            Me.paneT8.Visible = False
            Me.TableLayoutPanelCOLUMN.Visible = True
            Me.paneP6.Visible = True

            Dim tt As String = txtCLAC.Text.Replace("Add column to table:", "").Trim
            tabela = mySelectedNode.Parent.Text
            If tt.Trim.ToUpper <> tabela.Trim.ToUpper Then Call rResetC()

            txtCLAC.Text = "Add column to table: " + tabela
            Call openCloseC(txtL0, txtL0.Parent)
            If ttable <> mySelectedNode.Tag Then Call dajC(mySelectedNode)

        End If
    End Sub

    Sub dajT(ByVal eNode As TreeNode)
        Me.Cursor = Cursors.WaitCursor
        Call rResetT()
        ttable = eNode.Tag.split("$")(0).substring(2)
        vvod = eNode.Tag.split("$")(1)
        Me.txtTL0.Text = "Table : " + ttable + "    in _ISTTables of IST metadata"
        Dim dt As DataTable = getDTT()
        If dt.Rows.Count = 1 Then
            Call getVariablesT(dt)
            Try
                getMetaDataPaneT0()
                getMetaDataPaneT1()
                getMetaDataPaneT2()
                getMetaDataPaneT3()
                getMetaDataPaneT4()
                getMetaDataPaneT5()
                getMetaDataPaneT6()
                getMetaDataPaneT7()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try

            Dim ss As String = "select distinct connectionDoc  from ist.dbo.vBazaServerEng where appcode=N'" + Me.cboIST.SelectedValue.ToString.Trim + "'"
            Dim dd As System.Data.DataTable = izvrsiSQLvratiDT(ss, Me.ISTConnectionString, Me.jezik)
            If dd.Rows.Count > 0 Then
                ss = dd.Rows(0).Item(0).ToString + ";Integrated Security=SSPI;Persist Security Info=False" + ""
            End If

            Dim strSQL As String = "select name as displaymember,name as valuemember from dbo.sysobjects where (type = 'P') and name not like 'dt_%' order by 1"

            Call fillLB(lbOnSaveExec, strSQL, ss)
            Call fillLB(lbOnSaveNextExec, strSQL, ss)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Function getDTT() As DataTable
        typeOfTableParentChild = "" : parentTableName = "" : tableDescription = "" : dataentryScreenOrder = "" : tableOrder = ""
        parentAtributes = "" : childAtributes = "" : ValidFrom = "" : ValidTo = ""

        Dim strSQl As String = "select appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder," +
                "tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo from _ISTTables where appcode=N'" + Me.cboIST.SelectedValue.ToString.Trim +
                "' and tableName=N'" + ttable + "' and cast (validFrom as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTT = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Me.jezik)
    End Function

    Sub getVariablesT(ByVal dt As DataTable)
        typeOfTableParentChild = dt.Rows(0).Item("typeOfTableParentChild").ToString.Trim
        parentTableName = dt.Rows(0).Item("parentTableName").ToString.Trim
        tableOrder = dt.Rows(0).Item("tableOrder").ToString.Trim
        tableDescription = dt.Rows(0).Item("tableDescription").ToString.Trim
        parentAtributes = dt.Rows(0).Item("parentAtributes").ToString.Trim
        childAtributes = dt.Rows(0).Item("childAtributes").ToString.Trim
        ValidFrom = CDate(dt.Rows(0).Item("VALIDFROM")).ToString("yyyy/MM/dd")
        ValidTo = CDate(dt.Rows(0).Item("VALIDTO")).ToString("yyyy/MM/dd")
        dataentryScreenOrder = dt.Rows(0).Item("dataentryScreenOrder").ToString.Trim
    End Sub

    Sub getMetaDataPaneT0()

        If typeOfTableParentChild = "G" Then rbG.Checked = True
        If typeOfTableParentChild = "D" Then rbD.Checked = True
        If typeOfTableParentChild = "A" Then rbABook.Checked = True
        If typeOfTableParentChild = "K" Then rbK.Checked = True
        If typeOfTableParentChild = "S" Then rbS.Checked = True

        Call popuniNDcbo(cboNadTabela)

        Me.cboNadTabela.SelectedValue = parentTableName
        Me.txtOrdinalNumber.Text = tableOrder
        Me.txtvodT0.Text = CDate(ValidFrom).ToString("yyyy-MM-dd")
        Me.txtvdoT0.Text = CDate(ValidTo).ToString("yyyy-MM-dd")

    End Sub

    Sub setMetaDataPaneT0()
        If Not Me.cboNadTabela.SelectedValue Is Nothing Then parentTableName = Me.cboNadTabela.SelectedValue.ToString.Trim
        If rbG.Checked = True Then typeOfTableParentChild = "G"
        If rbD.Checked = True Then typeOfTableParentChild = "D"
        If rbABook.Checked = True Then typeOfTableParentChild = "A"
        If rbK.Checked = True Then typeOfTableParentChild = "K"
        If rbS.Checked = True Then typeOfTableParentChild = "S"
        ValidFrom = Me.txtvodT0.Value.ToString("yyyy-MM-dd")
        ValidTo = Me.txtvdoT0.Value.ToString("yyyy-MM-dd")
        tableOrder = Me.txtOrdinalNumber.Text.Trim
    End Sub

    Sub rResetT()
        For Each pp As Panel In Me.TableLayoutPanelTABLE.Controls
            If TypeOf pp Is Panel Then
                For Each k As Control In DirectCast(pp, Panel).Controls
                    If TypeOf k Is Panel Then Call rResetPane(k)
                    If TypeOf k Is CheckBox Then DirectCast(k, CheckBox).Checked = False
                    If TypeOf k Is ComboBox Then DirectCast(k, ComboBox).Text = ""
                    If TypeOf k Is TextBox AndAlso DirectCast(k, TextBox).Tag <> "VP" Then DirectCast(k, TextBox).Text = ""
                    'If TypeOf k Is DateTimePicker2 Then DirectCast(k, DateTimePicker2).Text = ""
                    If TypeOf k Is mkc_ColorCombobox.mkc_ColorCombobox Then
                        DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).SelectedColor = System.Drawing.Color.Empty
                        If DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).Tag = "VF" Then DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).Visible = False
                    End If
                    If TypeOf k Is DataGridView AndAlso Not DirectCast(k, DataGridView).DataSource Is Nothing Then
                        'DirectCast(k, DataGridView).Rows.Clear()
                        DirectCast(k, DataGridView).DataSource = Nothing
                    End If
                    If TypeOf k Is CheckedListBox AndAlso Not DirectCast(k, CheckedListBox).DataSource Is Nothing Then
                        For i As Integer = 0 To DirectCast(k, CheckedListBox).Items.Count - 1
                            DirectCast(k, CheckedListBox).SetItemChecked(i, False)
                        Next
                    End If
                    If TypeOf k Is TrackBar Then
                        DirectCast(k, TrackBar).Value = DirectCast(k, TrackBar).Tag
                    End If
                Next
            End If
        Next
    End Sub

    'Function getttt(ByVal text As String, ByVal what As String) As String
    '    getttt = ""
    '    If text.Trim.ToUpper.IndexOf(what) >= 0 Then
    '        Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
    '        getttt = text.Trim.ToUpper.Substring(b + what.Length)
    '    End If
    'End Function
    Sub getMetaDataPaneT7()
        'NOTE
        Dim pp() As String = parentAtributes.Split(";")
        For ii As Integer = 0 To pp.GetUpperBound(0)
            pp(ii) = pp(ii).Replace(vbCrLf, "").Trim
            If pp(ii).Length > 4 AndAlso pp(ii).Trim.ToUpper.IndexOf("NOTE") = 0 Then
                pp(ii) = pp(ii).Trim.ToUpper.Replace("NOTE=", "")
                Dim kk() As String = pp(ii).Split("$")
                For i As Integer = 0 To kk.GetUpperBound(0)
                    If kk(i).Length > 9 AndAlso kk(i).Trim.ToUpper.IndexOf("FORECOLOR") = 0 Then
                        cbNoteFC.Checked = True
                        Dim fc As String = getttt(kk(i), "FORECOLOR")
                        If fc <> "" Then Mkc_ColorCombobox5T.SelectedColor = Color.FromName(fc)
                    ElseIf kk(i).Length > 9 AndAlso kk(i).Trim.ToUpper.IndexOf("BACKCOLOR") = 0 Then
                        cbNoteBC.Checked = True
                        Dim bc As String = getttt(kk(i), "BACKCOLOR")
                        If bc <> "" Then Mkc_ColorCombobox6T.SelectedColor = Color.FromName(bc)
                    ElseIf kk(i).Length > 9 AndAlso kk(i).Trim.ToUpper.IndexOf("<FONTSIZE") >= 0 Then
                        cbNoteS.Checked = True
                        Dim cc As String = getttt(kk(i), "<FONTSIZE")
                        Dim n() As String = kk(i).Replace("<FONTSIZE", "").Split(">")
                        tbNFS.Value = CInt(n(0))
                        Dim t As String = ""
                        If n.GetUpperBound(0) > 0 Then
                            For nin As Integer = 1 To n.GetUpperBound(0)
                                t = t + n(nin) + ">"
                            Next
                        End If
                        txtNote.Text = t
                    ElseIf kk(i).Length > 8 AndAlso kk(i).Trim.ToUpper.IndexOf("LOCATION") = 0 Then
                        'LOCATION(X=1,Y=270)
                        Dim pom As String = kk(i).Trim.ToUpper.Replace("LOCATION", "")
                        Dim p() As String = pom.Split(",")
                        txtNX.Text = p(0).Trim.ToUpper.Split("=")(1)
                        txtNY.Text = p(1).Trim.ToUpper.Split("=")(1)
                    ElseIf kk(i).Length > 4 AndAlso kk(i).Trim.ToUpper.IndexOf("SIZE") >= 0 Then
                        'SIZE(1,270)
                        Dim pom As String = kk(i).Trim.ToUpper.Replace("SIZE", "")
                        Dim p() As String = pom.Split(",")
                        txtSX.Text = p(0).Trim.Replace("(", "")
                        txtSY.Text = p(1).Trim.Replace(")", "")
                    ElseIf kk(i).Trim <> "" Then
                        txtNote.Text = kk(i)
                    End If
                Next
                Exit For
            End If
        Next
    End Sub

    Function setMetaDataPaneT7() As String
        setMetaDataPaneT7 = ""
        'NOTE
        If txtNote.Text.Trim <> "" Then
            Dim note As String = "NOTE="
            'Note=<FONTSIZE7>ttttt$forecolorBlack$backcolorLiteGrey$LOCATION(X=800,Y=50)$SIZE(400,350)

            Dim ffsn As String = "8"
            Dim fsN As Integer = CInt(tbNFS.Value.ToString())
            ffsn = CStr(fsN).Trim
            note = note + "fontSize" + ffsn + "$"

            If cbNoteS.Checked = True Then note = note + " <fontSize" + ffsn.Trim + ">"
            If txtNote.Text.Trim <> "" Then note = note + txtNote.Text + "$"
            If txtNX.Text.Trim <> "" AndAlso txtNY.Text <> "" Then note = note + "LOCATION(X=" + txtNX.Text.Trim + ",Y=" + txtNY.Text + ")" + "$"
            If txtSX.Text.Trim <> "" AndAlso txtSY.Text <> "" Then note = note + "SIZE(" + txtSX.Text.Trim + "," + txtSY.Text + ")" + "$"

            If Mkc_ColorCombobox6T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox6T.SelectedColor = Color.Chocolate
            If Mkc_ColorCombobox6T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox6T.SelectedColor = Color.Snow
            If Mkc_ColorCombobox6T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox6T.SelectedColor = Color.Lavender
            If Mkc_ColorCombobox5T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox5T.SelectedColor = Color.Chocolate
            If Mkc_ColorCombobox5T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox5T.SelectedColor = Color.Lavender

            If cbNoteFC.Checked = True AndAlso Mkc_ColorCombobox5T.SelectedColor.Name <> "0" Then note = note + "foreColor" + Mkc_ColorCombobox5T.SelectedColor.Name + "$"
            If cbNoteBC.Checked = True AndAlso Mkc_ColorCombobox6T.SelectedColor.Name <> "0" Then note = note + "backColor" + Mkc_ColorCombobox6T.SelectedColor.Name + "$"

            Return note + ";"
        End If

    End Function

    Sub getMetaDataPaneT6()
        Dim pp() As String = parentAtributes.Split(";")
        Dim OnExitMsgIf() As String = {}
        Dim OnExitMsgIs() As String = {}
        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("ONEXITMSGIF") >= 0 Then
                OnExitMsgIf = pp(i).Trim.ToUpper.Replace("ONEXITMSGIF=", "").Split("$")
            End If
            If pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("ONEXITMSGIS") >= 0 Then
                OnExitMsgIs = pp(i).Trim.ToUpper.Replace("ONEXITMSGIS=", "").Split("$")
            End If
        Next

        dopuni(OnExitMsgIf, OnExitMsgIs)

        'dgvOnExitMSG.Rows.Clear()
        dgvOnExitMSG.DataSource = Nothing
        For i As Integer = 0 To OnExitMsgIs.GetUpperBound(0)
            If OnExitMsgIf(i) = "" Then OnExitMsgIf(i) = "2=2"
            dgvOnExitMSG.Rows.Add(New String() {OnExitMsgIf(i), OnExitMsgIs(i)})
        Next

    End Sub

    Function setMetaDataPaneT6() As String
        Dim pom As String = ""
        'OnExitMsg
        Dim OnExitMsgIf As String = "" : Dim OnExitMsgIs As String = ""
        pom = pom + setSaVise(OnExitMsgIf, OnExitMsgIs, dgvOnExitMSG, "OnExitMsgIf", "OnExitMsgIs")
        Return pom

    End Function

    Sub getMetaDataPaneT5()
        Dim pp() As String = parentAtributes.Split(";")

        Dim sstopmsg() As String = {}
        Dim skipto() As String = {}
        Dim skipif() As String = {}
        Dim onenterskipto() As String = {}
        Dim onenterskipif() As String = {}

        'OnSaveNextFocusOn;OnSaveNextFocusIF
        Dim OnSaveNextFocusOn() As String = {}
        Dim OnSaveNextFocusIF() As String = {}
        'OnSaveNextMSGIF;OnSaveNextMSGIS
        Dim OnSaveNextMSGIF() As String = {}
        Dim OnSaveNextMSGIS() As String = {}
        'OnSaveNextSimpleMSGIF;OnSaveNextSimpleMSGIS
        Dim OnSaveNextSimpleMSGIF() As String = {}
        Dim OnSaveNextSimpleMSGIS() As String = {}
        'OnSaveNextNoteIF;OnSaveNextNoteIS
        Dim OnSaveNextNoteIF() As String = {}
        Dim OnSaveNextNoteIS() As String = {}
        'OnSaveNextDeleteIF;OnSaveNextDeleteFrom
        Dim OnSaveNextDeleteIF() As String = {}
        Dim OnSaveNextDeleteFrom() As String = {}
        'OnSaveNextStopIF;OnSaveNextStopMSGIS
        Dim OnSaveNextStopIF As String = ""
        Dim OnSaveNextStopMSGIS As String = ""
        'OnSaveNextCloseIF
        Dim OnSaveNextCloseIF As String = ""
        'OnSaveNextExec
        Dim OnSaveNextExec As String = ""

        Dim a As Integer = 0
        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Length > 15 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTSTOPIF") >= 0 Then
                OnSaveNextStopIF = pp(i).Trim.ToUpper.Replace("ONSAVENEXTSTOPIF=", "")
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTSTOPMSGIS") >= 0 Then
                OnSaveNextStopMSGIS = pp(i).Trim.ToUpper.Replace("ONSAVENEXTSTOPMSGIS=", "")
            ElseIf pp(i).Length > 17 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTCLOSEIF") >= 0 Then
                OnSaveNextCloseIF = pp(i).Trim.ToUpper.Replace("ONSAVENEXTCLOSEIF=", "")
            ElseIf pp(i).Length > 14 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTEXEC") >= 0 Then
                OnSaveNextExec = pp(i).Trim.ToUpper.Replace("ONSAVENEXTEXEC=", "")
            ElseIf pp(i).Length > 17 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTFOCUSON") >= 0 Then
                OnSaveNextFocusOn = pp(i).Trim.ToUpper.Replace("ONSAVENEXTFOCUSON=", "").Split("$")
            ElseIf pp(i).Length > 17 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTFOCUSIF") >= 0 Then
                OnSaveNextFocusIF = pp(i).Trim.ToUpper.Replace("ONSAVENEXTFOCUSIF=", "").Split("$")
            ElseIf pp(i).Length > 15 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTMSGIF") >= 0 Then
                OnSaveNextMSGIF = pp(i).Trim.ToUpper.Replace("ONSAVENEXTMSGIF=", "").Split("$")
            ElseIf pp(i).Length > 15 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTMSGIS") >= 0 Then
                OnSaveNextMSGIS = pp(i).Trim.ToUpper.Replace("ONSAVENEXTMSGIS=", "").Split("$")
            ElseIf pp(i).Length > 21 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTSIMPLEMSGIF") >= 0 Then
                OnSaveNextSimpleMSGIF = pp(i).Trim.ToUpper.Replace("ONSAVENEXTSIMPLEMSGIF=", "").Split("$")
            ElseIf pp(i).Length > 21 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTSIMPLEMSGIS") >= 0 Then
                OnSaveNextSimpleMSGIS = pp(i).Trim.ToUpper.Replace("ONSAVENEXTSIMPLEMSGIS=", "").Split("$")
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTNOTEIF") >= 0 Then
                OnSaveNextNoteIF = pp(i).Trim.ToUpper.Replace("ONSAVENEXTNOTEIF=", "").Split("$")
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTNOTEIS") >= 0 Then
                OnSaveNextNoteIS = pp(i).Trim.ToUpper.Replace("ONSAVENEXTNOTEIS=", "").Split("$")
            ElseIf pp(i).Length > 18 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTDELETEIF") >= 0 Then
                OnSaveNextDeleteIF = pp(i).Trim.ToUpper.Replace("ONSAVENEXTDELETEIF=", "").Split("$")
            ElseIf pp(i).Length > 20 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVENEXTDELETEFROM") >= 0 Then
                OnSaveNextDeleteFrom = pp(i).Trim.ToUpper.Replace("ONSAVENEXTDELETEFROM=", "").Split("$")
            End If
        Next

        dopuni(OnSaveNextFocusIF, OnSaveNextFocusOn)
        dopuni(OnSaveNextMSGIF, OnSaveNextMSGIS)
        dopuni(OnSaveNextSimpleMSGIF, OnSaveNextSimpleMSGIS)
        dopuni(OnSaveNextNoteIF, OnSaveNextNoteIS)
        dopuni(OnSaveNextDeleteIF, OnSaveNextDeleteFrom)

        dgvOnSaveNextFocusOn.DataSource = Nothing
        For i As Integer = 0 To OnSaveNextFocusOn.GetUpperBound(0)
            If OnSaveNextFocusIF(i) = "" Then OnSaveNextFocusIF(i) = "2=2"
            dgvOnSaveNextFocusOn.Rows.Add(New String() {OnSaveNextFocusIF(i), OnSaveNextFocusOn(i)})
        Next

        dgvOnSaveNextMSG.DataSource = Nothing
        For i As Integer = 0 To OnSaveNextMSGIS.GetUpperBound(0)
            If OnSaveNextMSGIF(i) = "" Then OnSaveNextMSGIF(i) = "2=2"
            dgvOnSaveNextMSG.Rows.Add(New String() {OnSaveNextMSGIF(i), OnSaveNextMSGIS(i)})
        Next

        dgvOnSaveNextSimpleMSG.DataSource = Nothing
        For i As Integer = 0 To OnSaveNextSimpleMSGIS.GetUpperBound(0)
            If OnSaveNextSimpleMSGIF(i) = "" Then OnSaveNextSimpleMSGIF(i) = "2=2"
            dgvOnSaveNextSimpleMSG.Rows.Add(New String() {OnSaveNextSimpleMSGIF(i), OnSaveNextSimpleMSGIS(i)})
        Next

        dgvOnSaveNextNote.DataSource = Nothing
        For i As Integer = 0 To OnSaveNextNoteIS.GetUpperBound(0)
            If OnSaveNextNoteIF(i) = "" Then OnSaveNextNoteIF(i) = "2=2"
            dgvOnSaveNextNote.Rows.Add(New String() {OnSaveNextNoteIF(i), OnSaveNextNoteIS(i)})
        Next

        dgvOnSaveNextDelete.DataSource = Nothing
        For i As Integer = 0 To OnSaveNextDeleteFrom.GetUpperBound(0)
            If OnSaveNextDeleteIF(i) = "" Then OnSaveNextDeleteIF(i) = "2=2"
            dgvOnSaveNextDelete.Rows.Add(New String() {OnSaveNextDeleteIF(i), OnSaveNextDeleteFrom(i)})
        Next

        dgvOnSaveNextStop.DataSource = Nothing
        If OnSaveNextStopMSGIS.Trim <> "" Then
            If OnSaveNextStopIF = "" Then OnSaveNextStopIF = "2=2"
            dgvOnSaveNextStop.Rows.Add(New String() {OnSaveNextStopIF, OnSaveNextStopMSGIS})
        Else
            dgvOnSaveNextStop.Rows.Add(New String() {"", ""})
        End If

        dgvOnSaveNextExec.DataSource = Nothing
        If OnSaveNextExec.Trim <> "" Then
            dgvOnSaveNextExec.Rows.Add(New String() {OnSaveNextExec})
        Else
            dgvOnSaveNextExec.Rows.Add(New String() {""})
        End If

        dgvOnSaveNextClose.DataSource = Nothing
        If OnSaveNextCloseIF.Trim <> "" Then
            dgvOnSaveNextClose.Rows.Add(New String() {OnSaveNextCloseIF})
        Else
            dgvOnSaveNextClose.Rows.Add(New String() {""})
        End If

    End Sub

    'Sub dopuni(ByRef iif() As String, ByVal onn() As String)
    '    Dim iifLength = iif.Length
    '    If iif.Length < onn.Length Then
    '        For ii As Integer = 0 To onn.Length - iifLength - 1
    '            ReDim Preserve iif(ii)
    '            iif(ii) = "2=2"
    '        Next
    '    End If
    'End Sub
    Function setMetaDataPaneT5() As String
        Dim pom As String = ""
        'OnSaveNextFocusOn;OnSaveNextFocusIF
        Dim OnSaveNextFocusIF As String = "" : Dim OnSaveNextFocusOn As String = ""
        pom = pom + setSaVise(OnSaveNextFocusIF, OnSaveNextFocusOn, dgvOnSaveNextFocusOn, "OnSaveNextFocusIF", "OnSaveNextFocusOn")

        'OnSaveNextMSGIF;OnSaveNextMSGIS
        Dim OnSaveNextMSGIF As String = "" : Dim OnSaveNextMSGIS As String = ""
        pom = pom + setSaVise(OnSaveNextMSGIF, OnSaveNextMSGIS, dgvOnSaveNextMSG, "OnSaveNextMSGIF", "OnSaveNextMSGIS")

        'OnSaveNextSimpleMSGIF;OnSaveNextSimpleMSGIS
        Dim OnSaveNextSimpleMSGIF As String = "" : Dim OnSaveNextSimpleMSGIS As String = ""
        pom = pom + setSaVise(OnSaveNextSimpleMSGIF, OnSaveNextSimpleMSGIS, dgvOnSaveNextSimpleMSG, "OnSaveNextSimpleMSGIF", "OnSaveNextSimpleMSGIS")

        'OnSaveNextNoteIF;OnSaveNextNoteIS
        Dim OnSaveNextNoteIF As String = "" : Dim OnSaveNextNoteIS As String = ""
        pom = pom + setSaVise(OnSaveNextNoteIF, OnSaveNextNoteIS, dgvOnSaveNextNote, "OnSaveNextNoteIF", "OnSaveNextNoteIS")

        'OnSaveNextDeleteIF;OnSaveNextDeleteFrom
        Dim OnSaveNextDeleteIF As String = "" : Dim OnSaveNextDeleteFrom As String = ""
        pom = pom + setSaVise(OnSaveNextDeleteIF, OnSaveNextDeleteFrom, dgvOnSaveNextDelete, "OnSaveNextDeleteIF", "OnSaveNextDeleteFrom")

        'OnSaveNextStopIF;OnSaveNextStopMSG
        Dim OnSaveNextStopIF As String = "" : Dim OnSaveNextStopMSGIS As String = ""
        pom = pom + set2(OnSaveNextStopIF, OnSaveNextStopMSGIS, dgvOnSaveNextStop, "OnSaveNextStopIF", "OnSaveNextStopMSGIS")

        'OnSaveNextCloseIF
        Dim OnSaveNextCloseIF As String = ""
        pom = pom + set1(OnSaveNextCloseIF, dgvOnSaveNextClose, "OnSaveNextCloseIF")

        'OnSaveNextExec
        Dim OnSaveNextExec As String = ""
        pom = pom + set1(OnSaveNextExec, dgvOnSaveNextExec, "OnSaveNextExec")

        Return pom

    End Function

    'Function set1(ByVal s1 As String, ByVal dgv As DataGridView, ByVal ss1 As String) As String
    '    's1 je uvek sa IF (ako postoji IF)
    '    set1 = ""
    '    If Not dgv.Rows(0).Cells(0).Value Is Nothing AndAlso dgv.Rows(0).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(0).Cells(0).Value.ToString.Trim
    '    If s1 <> "" Then
    '        s1 = s1 + ";" : s1 = s1.Replace(";;", "").Replace("'", "''")
    '        set1 = set1 + ss1 + "=" + s1 + ";"
    '        set1 = set1.Replace("'", "''")
    '    End If
    '    Return set1
    'End Function
    Function set2(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        set2 = ""
        If Not dgv.Rows(0).Cells(1).Value Is Nothing AndAlso dgv.Rows(0).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(0).Cells(1).Value.ToString.Trim
        If Not dgv.Rows(0).Cells(0).Value Is Nothing AndAlso dgv.Rows(0).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(0).Cells(0).Value.ToString.Trim
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + ";" : s1 = s1.Replace(";;", "")
            set2 = set2 + ss1 + "=" + s1 + ";"
            s2 = s2 + ";" : s2 = s2.Replace(";;", "")
            set2 = set2 + ss2 + "=" + s2 + ";"
            set2 = set2.Replace("'", "''")
        End If

        Return set2
    End Function

    Function setSaVise(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        setSaVise = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + "$"
            If s2 <> "" AndAlso s1 = "" Then s1 = "2=2$"
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "$" : s1 = s1.Replace("$$", "")
            setSaVise = setSaVise + ss1 + "=" + s1 + ";"
            s2 = s2 + "$" : s2 = s2.Replace("$$", "")
            setSaVise = setSaVise + ss2 + "=" + s2 + ";"
            setSaVise = setSaVise.Replace("'", "''")
        End If
        Return setSaVise
    End Function

    Function set4(ByVal s1 As String, ByVal s2 As String, ByVal s3 As String, ByVal s4 As String, ByVal dgv As DataGridView,
                  ByVal ss1 As String, ByVal ss2 As String, ByVal ss3 As String, ByVal ss4 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        set4 = ""
        If Not dgv.Rows(0).Cells(0).Value Is Nothing AndAlso dgv.Rows(0).Cells(0).Value <> "" Then s1 = dgv.Rows(0).Cells(0).Value.ToString.Trim
        If Not dgv.Rows(0).Cells(1).Value Is Nothing AndAlso dgv.Rows(0).Cells(1).Value <> "" Then s2 = dgv.Rows(0).Cells(1).Value.ToString.Trim
        If Not dgv.Rows(0).Cells(2).Value Is Nothing AndAlso dgv.Rows(0).Cells(2).Value <> "" Then s3 = dgv.Rows(0).Cells(2).Value.ToString.Trim
        If Not dgv.Rows(0).Cells(3).Value Is Nothing AndAlso dgv.Rows(0).Cells(3).Value <> "" Then s4 = dgv.Rows(0).Cells(3).Value.ToString.Trim
        If s1 <> "" AndAlso s2 <> "" AndAlso s3 <> "" AndAlso s4 <> "" Then
            set4 = set4 + ss2 + "=" + s2 + "(" + s3 + ")" + "values(" + s4 + ")" + ";"
            set4 = set4 + ss1 + "=" + s1 + ";"
            set4 = set4.Replace("'", "''")
        End If

        Return set4

    End Function

    Sub getMetaDataPaneT4()
        Dim pp() As String = parentAtributes.Split(";")
        Dim OnSaveExec As String = ""
        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("ONSAVEEXEC") >= 0 Then
                OnSaveExec = pp(i).Trim.ToUpper.Replace("ONSAVEEXEC=", "")
            End If
        Next

        dgvOnSaveExec.DataSource = Nothing
        If OnSaveExec.Trim <> "" Then
            dgvOnSaveExec.Rows.Add(New String() {OnSaveExec})
        Else
            dgvOnSaveExec.Rows.Add(New String() {""})
        End If

    End Sub

    Function setMetaDataPaneT4() As String
        'OnSaveExec
        Dim OnSaveExec As String = ""
        Return set1(OnSaveExec, dgvOnSaveExec, "OnSaveExec")
    End Function

    Sub getMetaDataPaneT3()
        Dim pp() As String = childAtributes.Split(";")
        Dim sstopif() As String = {}
        Dim sstopmsg() As String = {}
        Dim skipto() As String = {}
        Dim skipif() As String = {}
        Dim onenterskipto() As String = {}
        Dim onenterskipif() As String = {}
        Dim autolistby As String = ""
        Dim autolistto As String = ""
        Dim addnewrowto As String = ""
        Dim ffields As String = ""
        Dim vvalues As String = ""
        Dim addnewrowif As String = ""

        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("MAX") = 0 Then
                cbT2Max.Checked = True
            ElseIf pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("MIN") = 0 Then
                cbT2Min.Checked = True
            ElseIf pp(i).Length > 3 AndAlso pp(i).Trim.ToUpper.IndexOf("VIEW") = 0 Then
                cbView.Checked = True
            ElseIf pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("WEB") = 0 Then
                cbT2Web.Checked = True
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("DISABLEMOUSE") = 0 Then
                cbT2DisableMouse.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper = "DONTRESIZE" Then
                cbDNR.Checked = True
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper = "GRIDCOLAUTORESIZE" Then
                cbGCAR.Checked = True
            ElseIf pp(i).Length > 13 AndAlso pp(i).Trim.ToUpper = "GRIDCOLUMNSIST" Then
                cbGCI.Checked = True
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper = "NOGRID" Then
                cbNoGrid.Checked = True
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper = "NOPLUS" Then
                cbNoPlus.Checked = True
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper = "NOGRIDSPACE" Then
                cbNoGridSpace.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("GRIDHEIGHT") = 0 Then
                cbGH.Checked = True
                Me.txtGH.Text = pp(i).Trim.ToUpper.Split("=")(1)
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper = "HORIZONTAL" Then
                cbHA.Checked = True
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONHEIGHT") >= 0 Then
                cbBH.Checked = True
                txtT2BH.Text = pp(i).Trim.ToUpper.Split("=")(1)
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONWIDTH") >= 0 Then
                cbBW.Checked = True
                txtT2BW.Text = pp(i).Trim.ToUpper.Split("=")(1)
            ElseIf pp(i).Length > 13 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONLOCATION") >= 0 Then
                'BUTTONLOCATION(X=1,Y=270)
                Dim pom As String = pp(i).Trim.ToUpper.Replace("BUTTONLOCATION", "")
                Dim p() As String = pom.Split(",")

                If p.Length = 2 Then
                    txtT2BX.Text = CInt(p(0).Trim.ToUpper.Replace("X=", "").Replace("(", ""))
                    txtT2BY.Text = CInt(p(1).Trim.ToUpper.Replace("Y=", "").Replace(")", ""))
                End If
                If p.Length = 1 Then
                    p(0) = p(0).Trim.ToUpper.Replace("(", "").Replace(")", "").Replace("=", "")
                    If p(0).Trim.ToUpper.IndexOf("X") >= 0 Then txtT2BX.Text = CInt(p(0).Trim.ToUpper.Replace("X", ""))
                    If p(0).Trim.ToUpper.IndexOf("Y") >= 0 Then txtT2BY.Text = CInt(p(0).Trim.ToUpper.Replace("Y", ""))
                End If

            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper = "FONTBOLD" Then
                cbT2BB.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper = "FONTITALIC" Then
                cbT2BI.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper = "LCENTERA" Then
                cbT2BAC.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper = "LRIGHTA" Then
                cbT2BAR.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                cbT2BS.Checked = True
                Dim fs As Integer = pp(i).Trim.ToUpper.Replace("FONTSIZE", "")
                tbBFS.Value = fs
            ElseIf pp(i).Trim.ToUpper = "BUTTONVISIBLEFALSE" Then
                cbBVF.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper = "NOBUTTON" Then
                cbNoButton.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") = 0 Then
                cbT2BFC.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorCombobox3T.SelectedColor = Color.FromName(fc)
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") = 0 Then
                cbT2BBC.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorCombobox4T.SelectedColor = Color.FromName(bc)
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("STOPIF") >= 0 Then
                cbOnButtonClick.Checked = True
                sstopif = pp(i).Trim.ToUpper.Replace("STOPIF=", "").Split("$")
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("STOPMSG") >= 0 Then
                cbOnButtonClick.Checked = True
                sstopmsg = pp(i).Trim.ToUpper.Replace("STOPMSG=", "").Split("$")
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOLISTBY") >= 0 Then
                autolistby = pp(i).Trim.ToUpper.Replace("AUTOLISTBY=", "")
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOLISTTO") >= 0 Then
                autolistto = pp(i).Trim.ToUpper.Replace("AUTOLISTTO=", "")
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("ADDNEWROWTO") >= 0 Then
                addnewrowto = pp(i).Trim.ToUpper.Replace("ADDNEWROWTO=", "")
                addnewrowto = addnewrowto.Trim.ToUpper.Replace("(", "$($")
                addnewrowto = addnewrowto.Trim.ToUpper.Replace("values", "$values")
                Dim p() As String = addnewrowto.Split("$")
                addnewrowto = p(0)
                'vP12019$($god, OpsPop, krug, rbrP3, rbrP2, Rbrdom, RbrP1, ind, Ime, Prezime)$values$($god,OpsPop,krug,rbrP3,rbrP2,Rbrdom,RbrP1,ind,Ime,Prezime)
                ffields = p(2).Replace(")", "")
                vvalues = p(5).Replace(")", "")
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("ADDNEWROWIF") >= 0 Then
                addnewrowif = pp(i).Trim.ToUpper.Replace("ADDNEWROWIF=", "")
            End If
        Next

        If Me.cbOnButtonClick.Checked = True Then
            Me.Panel2.Visible = True
            dopuni(sstopif, sstopmsg)
            For i As Integer = 0 To sstopmsg.GetUpperBound(0)
                If sstopif(i) = "" Then sstopif(i) = "2=2"
                dgvOnButtonClickStop.Rows.Add(New String() {sstopif(i), sstopmsg(i)})
            Next
        End If

        If dataentryScreenOrder.Trim <> "" Then
            Me.cbDESO.Checked = True
            Me.txtDESO.Text = dataentryScreenOrder
        End If

    End Sub

    Function setMetaDataPaneT3() As String
        setMetaDataPaneT3 = ""
        Dim pom As String = ""

        If Me.cbDESO.Checked = True AndAlso Me.txtDESO.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill data screen entry order")
            Me.txtDESO.Focus()
            Exit Function
        End If
        If Me.cbGH.Checked = True AndAlso Me.txtGH.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill grid height")
            Me.txtGH.Focus()
            Exit Function
        End If
        If Me.cbBW.Checked = True AndAlso Me.txtT2BW.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill button width")
            Me.txtT2BW.Focus()
            Exit Function
        End If
        If Me.cbBH.Checked = True AndAlso Me.txtT2BH.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill button height")
            Me.txtT2BH.Focus()
            Exit Function
        End If
        If Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text = "" Then
            ISTMessageBox.Show("Please, fill button location Y")
            Me.txtT2BY.Focus()
            Exit Function
        End If
        If Me.txtT2BX.Text = "" AndAlso Me.txtT2BY.Text <> "" Then
            ISTMessageBox.Show("Please, fill button location X")
            Me.txtT2BX.Focus()
            Exit Function
        End If
        If Me.cbOnButtonClick.Checked = True AndAlso dgvOnButtonClickStop.Rows.Count < 1 Then
            ISTMessageBox.Show("Please, fill on button click event")
            Panel2.Visible = True
            dgvOnButtonClickStop.Focus()
            Exit Function
        End If

        'dataentryScreenOrder
        If Me.cbDESO.Checked = True AndAlso Me.txtDESO.Text <> "" Then dataentryScreenOrder = Me.txtDESO.Text

        For Each k As Control In paneT3.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                Dim text As String = k.AccessibleName.Trim.ToUpper
                If DirectCast(k, CheckBox).Checked = True Then If pom.Trim.ToUpper.IndexOf(text) < 0 Then pom = pom + text + ";"
            End If
        Next
        If cbT2BS.Checked = True Then
            Dim ffbs As String = "8"
            Dim fsbs As Integer = CInt(tbBFS.Value.ToString())
            ffbs = CStr(fsbs).Trim
            pom = pom + "fontSize" + ffbs + ";"
        End If

        If Me.cbGH.Checked = True Then pom = pom + "gridHeight=" + Me.txtGH.Text.Trim + ";"
        If Me.cbBW.Checked = True Then pom = pom + "buttonWidth=" + Me.txtT2BW.Text.Trim + ";"
        If Me.cbBH.Checked = True Then pom = pom + "buttonHeight=" + Me.txtT2BH.Text.Trim + ";"

        If Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text = "" Then
            pom = pom + "buttonLocation(X=" + Me.txtT2BX.Text.Trim + ");"
        ElseIf Me.txtT2BX.Text = "" AndAlso Me.txtT2BY.Text <> "" Then
            pom = pom + "buttonLocation(Y=" + Me.txtT2BY.Text.Trim + ");"
        ElseIf Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text <> "" Then
            pom = pom + "buttonLocation(X=" + Me.txtT2BX.Text.Trim + ",Y=" + Me.txtT2BY.Text.Trim + ");"
        End If

        If Mkc_ColorCombobox4T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox4T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox4T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox4T.SelectedColor = Color.Snow
        If Mkc_ColorCombobox4T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox4T.SelectedColor = Color.Lavender
        If Mkc_ColorCombobox3T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox3T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox3T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox3T.SelectedColor = Color.Lavender

        If cbT2BFC.Checked = True AndAlso Mkc_ColorCombobox3T.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorCombobox3T.SelectedColor.Name + ";"
        If cbT2BBC.Checked = True AndAlso Mkc_ColorCombobox4T.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorCombobox4T.SelectedColor.Name + ";"

        If Me.cbOnButtonClick.Checked = True Then
            Dim pstopif As String = "" : Dim pstopmsg As String = ""
            pom = pom + setSaVise(pstopif, pstopmsg, dgvOnButtonClickStop, "stopif", "stopmsg")
        End If



        pom = pom.Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")

        Return pom

    End Function

    Sub getMetaDataPaneT2()
        Dim pp() As String = parentAtributes.Split(";")
        Dim dontopenif As String = ""
        Dim dontopenmsgis As String = ""
        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("MAX") >= 0 Then
                cbMax.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("SENDEMAIL") >= 0 Then
                cbSendEmail.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("SUPPORTEU") >= 0 Then
                cbSupportEU.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DONTRESIZE") >= 0 Then
                cbDNTRM.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("SCROLLBAR") >= 0 Then
                cbDNTRM.Checked = True
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("DISABLEMOUSE") >= 0 Then
                cbT1DisableMouse.Checked = True
                'ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("SHRINK") >= 0 Then
                '    cbShrink.Checked = True
            ElseIf pp(i).Length > 0 AndAlso pp(i).Trim.ToUpper = "K" Then
                cbK.Checked = True
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper.IndexOf("ONLEAVEOKKEEPDATA") >= 0 Then
                cbPKLeave.Checked = True
            ElseIf pp(i).Length > 21 AndAlso pp(i).Trim.ToUpper.IndexOf("PRIMARYKEYDISBLED=TRUE") >= 0 Then
                cbPKD.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper = "NPRETRAGA" Then
                cbAdvancedSearch.Checked = True
            ElseIf pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper = "WEB" Then
                cbT1Web.Checked = True
            ElseIf pp(i).Length > 19 AndAlso pp(i).Trim.ToUpper = "BUTTONLKVISIBLEFALSE" Then
                cbLKVF.Checked = True
            ElseIf pp(i).Length > 21 AndAlso pp(i).Trim.ToUpper = "BUTTONSAVEVISIBLEFALSE" Then
                cbSVF.Checked = True
            ElseIf pp(i).Length > 25 AndAlso pp(i).Trim.ToUpper = "VERTICALSCROLLVISIBLEFALSE" Then
                cbT1VSVF.Checked = True
            ElseIf pp(i).Length > 27 AndAlso pp(i).Trim.ToUpper = "HORIZONTALSCROLLVISIBLEFALSE" Then
                cbT1HSVF.Checked = True
            ElseIf pp(i).Length > 15 AndAlso pp(i).Trim.ToUpper = "GBLKVISIBLEFALSE" Then
                cbLCcbVF.Checked = True
            ElseIf pp(i).Length > 3 AndAlso pp(i).Trim.ToUpper = "CATI" Then
                cbCATI.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper = "MIXMODE" Then
                cbMixmode.Checked = True
            ElseIf pp(i).Length > 0 AndAlso pp(i).Trim.ToUpper = "X" Then
                cbX.Checked = True
            ElseIf pp(i).Length > 0 AndAlso pp(i).Trim.ToUpper = "A" Then
                cbA.Checked = True
            ElseIf pp(i).Length > 14 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKGROUNDCOLOR") = 0 Then
                Me.cbTc3.Checked = True
                Dim fc As String = getttt(pp(i), "BACKGROUNDCOLOR")
                If fc <> "" Then cboBGCATe.SelectedColor = Color.FromName(fc)
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DONTOPENIF") >= 0 Then
                cbDontOpen.Checked = True
                dontopenif = pp(i).Trim.ToUpper.Replace("DONTOPENIF=", "")
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("DONTOPENMSGIS") >= 0 Then
                cbDontOpen.Checked = True
                dontopenmsgis = pp(i).Trim.ToUpper.Replace("DONTOPENMSGIS=", "")
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper.IndexOf("ALWAYSVISIBLELABEL") >= 0 Then
                cbAVL.Checked = True
                Me.paneAWL.Visible = True
                Dim kk() As String = pp(i).Split("$")
                For ii As Integer = 0 To kk.GetUpperBound(0)
                    If kk(ii).Length > 1 AndAlso kk(ii).Trim.ToUpper.IndexOf("D=") = 0 Then
                        Dim ppm As String = Replace(kk(ii).Trim, "d=", "", 1, , CompareMethod.Text)
                        If ppm.StartsWith("'") = True AndAlso ppm.EndsWith("'") = True Then
                            txtDT.Text = ppm.Substring(1, ppm.Length - 2)
                        End If
                    ElseIf kk(ii).Length > 5 AndAlso kk(ii).Trim.ToUpper.IndexOf("INLINE") = 0 Then
                        Me.cbInline.Checked = True
                    ElseIf kk(ii).Length > 12 AndAlso kk(ii).Trim.ToUpper.IndexOf("AVLNOTMOVABLE") = 0 Then
                        Me.cbNotMovable.Checked = True
                    ElseIf kk(ii).Length > 8 AndAlso kk(ii).Trim.ToUpper.IndexOf("FORECOLOR") = 0 Then
                        cbAWLFC.Checked = True
                        Mkc_ColorCombobox7T.Visible = True
                        Dim fc As String = getttt(kk(ii), "FORECOLOR")
                        If fc <> "" Then Mkc_ColorCombobox7T.SelectedColor = Color.FromName(fc)
                    ElseIf kk(ii).Length > 8 AndAlso kk(ii).Trim.ToUpper.IndexOf("BACKCOLOR") = 0 Then
                        cbAWLBC.Checked = True
                        Mkc_ColorCombobox8T.Visible = True
                        Dim bx As String = getttt(kk(ii), "BACKCOLOR")
                        If bx <> "" Then Mkc_ColorCombobox8T.SelectedColor = Color.FromName(bx)
                    ElseIf kk(ii).Length > 5 AndAlso kk(ii).Trim.ToUpper.IndexOf("INLINE") = 0 Then
                        Me.cbInline.Checked = True
                    ElseIf kk(ii).Length > 16 AndAlso kk(ii).Trim.ToUpper.IndexOf("ALWAYSVISIBLELABEL") = 0 Then
                        Dim opo As String = kk(ii).Trim.ToUpper.Replace("ALWAYSVISIBLELABEL", "")
                        If opo.IndexOf(",") > 0 Then
                            opo = opo.Replace("(", "").Replace(")", "")
                            Dim xxyy() As String = opo.Split(",")
                            Dim xx As String = xxyy(0).Split("=")(1)
                            If IsNumeric(xx.Trim) Then txtX.Text = xx
                            Dim yy As String = xxyy(1).Split("=")(1)
                            If IsNumeric(yy.Trim) Then txtY.Text = yy
                        End If
                    ElseIf kk(ii).Length > 4 AndAlso kk(ii).Trim.ToUpper.IndexOf("SIZE") = 0 Then
                        Dim opo As String = kk(ii).Trim.ToUpper.Replace("SIZE", "")
                        If opo.IndexOf(",") > 0 Then
                            opo = opo.Replace("(", "").Replace(")", "")
                            Dim xxyy() As String = opo.Split(",")
                            Dim xx As String = xxyy(0)
                            If IsNumeric(xx.Trim) Then txtXW.Text = xx
                            Dim yy As String = xxyy(1)
                            If IsNumeric(yy.Trim) Then txtYH.Text = yy
                        End If
                    End If
                Next
            End If
        Next

        If Me.cbInline.Checked = True Then
            txtX.Text = "" : txtY.Text = ""
        End If

        dgvDontOpen.DataSource = Nothing
        If Me.cbDontOpen.Checked = True Then
            If dontopenmsgis.Trim <> "" Then
                If dontopenif = "" Then dontopenif = "2=2"
                dgvDontOpen.Rows.Add(New String() {dontopenif, dontopenmsgis})
            End If
        Else
            dgvDontOpen.Rows.Add(New String() {"", ""})
        End If

    End Sub

    Function setMetaDataPaneT2() As String
        setMetaDataPaneT2 = ""
        Dim pomm As String = ""
        If Me.cbDontOpen.Checked = True AndAlso dgvDontOpen.Rows.Count < 1 Then
            ISTMessageBox.Show("Please, fill dont open from event")
            dgvDontOpen.Focus()
            Exit Function
        End If

        For Each k As Control In paneT2.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                Dim text As String = k.AccessibleName.Trim.ToUpper
                If DirectCast(k, CheckBox).Checked = True Then If pomm.Trim.ToUpper.IndexOf(text) < 0 Then pomm = pomm + text + ";"
            End If
        Next

        If cbAVL.Checked = True Then
            Dim pom As String = ""
            If cbInline.Checked = False Then
                pom = pom + "AlwaysVisibleLabel"
                If txtX.Text <> "" AndAlso txtY.Text <> "" AndAlso IsNumeric(txtX.Text) AndAlso IsNumeric(txtY.Text) Then pom = pom + "(X=" + txtX.Text + ",Y=" + txtY.Text + ")"
            End If
            If txtXW.Text <> "" AndAlso txtYH.Text <> "" AndAlso IsNumeric(txtXW.Text) AndAlso IsNumeric(txtYH.Text) Then pom = pom + "$" + "Size(" + txtXW.Text + "," + txtYH.Text + ")"
            If cbInline.Checked = True Then pom = pom + "InLineAlwaysVisibleLabelOnField"
            If txtDT.Text <> "" AndAlso txtDT.Text <> "''" Then
                If txtDT.Text.StartsWith("'") = True AndAlso txtDT.Text.EndsWith("'") = True Then
                    txtDT.Text = txtDT.Text.Substring(1, txtDT.Text.Length - 2)
                End If
                pom = pom + "$" + "D=''" + txtDT.Text + "''"
            End If

            If Mkc_ColorCombobox8T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox8T.SelectedColor = Color.Chocolate
            If Mkc_ColorCombobox8T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox8T.SelectedColor = Color.Lavender
            If Mkc_ColorCombobox7T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox7T.SelectedColor = Color.Chocolate
            If Mkc_ColorCombobox7T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox7T.SelectedColor = Color.Lavender
            If Mkc_ColorCombobox8T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox8T.SelectedColor = Color.Snow

            If cbAWLFC.Checked = True AndAlso Mkc_ColorCombobox7T.SelectedColor.Name <> "0" Then pom = pom + "$" + "foreColor" + Mkc_ColorCombobox7T.SelectedColor.Name
            If cbAWLBC.Checked = True AndAlso Mkc_ColorCombobox8T.SelectedColor.Name <> "0" Then pom = pom + "$" + "backColor" + Mkc_ColorCombobox8T.SelectedColor.Name
            pomm = pomm + pom + ";"
        End If

        If Me.cbDontOpen.Checked = True Then
            Dim dontopenif As String = "" : Dim dontopenmsgis As String = ""
            pomm = pomm + set2(dontopenif, dontopenmsgis, dgvDontOpen, "dontopenif", "DontOpenMSGIS")
        End If

        If cboBGCATe.SelectedColor.Name <> "0" AndAlso cboBGCATe.SelectedColor.Name <> "Transparent" Then pomm = pomm + ";" + "backGroundColor" + cboBGCATe.SelectedColor.Name + ";"

        pomm = pomm.Replace(";;", ";").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")

        Return pomm

    End Function

    Sub getMetaDataPaneT1()

        Dim opisG As String = tableDescription
        Dim naslovForeColor As String = ""
        Dim naslovBackColor As String = ""
        Dim naslovVisina As String = ""
        Dim naslovFontSize As String = ""

        If tableDescription.Trim = "" Then Exit Sub

        Dim pp() As String = tableDescription.Split("$")

        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i) = "" Then cbN.Checked = True
            If pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") >= 0 Then
                cbFC.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorCombobox1T.SelectedColor = Color.FromName(fc)
                naslovForeColor = fc
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 Then
                cbBC.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorCombobox2T.SelectedColor = Color.FromName(bc)
                naslovBackColor = bc
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                cbTBold.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                cbI.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("LCENTERA") = 0 Then
                cbTAC.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("LRIGHTA") = 0 Then
                cbAR.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                Dim fs As Integer = CInt(pp(i).Trim.ToUpper.Replace("FONTSIZE", ""))
                cbS.Checked = True
                tbFS.Value = fs
                naslovFontSize = getttt(pp(i), "FONTSIZE")
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("LHEIGHT") = 0 Then
                cbH.Checked = True
                Dim h As String = getttt(pp(i), "LHEIGHT")
                If IsNumeric(h.Trim) = True Then tbH.Value = CInt(h.Trim)
                naslovVisina = h
            ElseIf pp(i).Trim <> "" Then
                txtTTitle.Text = pp(i)
            End If
        Next

        opisG = Replace(opisG, "fontbold", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontitalic", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontunderline", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "ldesnop", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentarp", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lrighta", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentera", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "forecolor" + naslovForeColor.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "backcolor" + naslovBackColor.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontsize" + naslovFontSize.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lheight" + naslovVisina.ToLower, "", 1, , CompareMethod.Text)

        opisG = opisG.Replace("$$", "$")

        If opisG.IndexOf("$") >= 0 AndAlso opisG.Trim.Substring(0, 1) = "$" Then
            cbN.Checked = True
        ElseIf opisG.Length > 0 AndAlso opisG.IndexOf("$") < 0 Then
            cbN.Checked = False
        ElseIf opisG.Length = 0 Then
            cbN.Checked = True
        End If
    End Sub

    Function setMetaDataPaneT1() As String

        Dim pom As String = ""

        For Each k As Control In paneT1.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim.ToUpper + "$"
            End If
        Next

        If cbN.Checked = True Then pom = "$" + pom + "$"

        If Mkc_ColorCombobox2T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox2T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox2T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox2T.SelectedColor = Color.Lavender
        If Mkc_ColorCombobox1T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox1T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox1T.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox1T.SelectedColor = Color.Lavender
        If Mkc_ColorCombobox2T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox2T.SelectedColor = Color.Snow

        If cbFC.Checked = True AndAlso Mkc_ColorCombobox1T.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorCombobox1T.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorCombobox2T.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorCombobox2T.SelectedColor.Name + "$"
        If txtTTitle.Text.Trim <> "" Then pom = pom + txtTTitle.Text + "$"

        Dim ffs As String = "8"
        Dim fs As Integer = CInt(tbFS.Value.ToString())
        ffs = CStr(fs).Trim
        pom = pom + "fontSize" + ffs + "$"

        Dim h As String = tbH.Value.ToString()
        If h > 1 Then pom = pom + "lHeight" + h + "$"
        pom = pom.Replace("$$", "$")

        Return pom
    End Function

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTTitle.Leave
        'uradi replace
        'smesti u txttitleO
        If Me.txtTitleO.Text.Trim <> "" Then
            tableDescription = Replace(tableDescription, Me.txtTitleO.Text.Trim.ToLower, "", 1, , CompareMethod.Text)
        End If
        Me.txtTitleO.Text = txtTTitle.Text
        tableDescription = tableDescription + txtTTitle.Text + "$"
        tableDescription = tableDescription.Replace("$$", "$")
    End Sub

    Private Sub cbS_CheckedChanged(sender As Object, e As EventArgs) Handles cbS.CheckedChanged
        tbFS.Visible = cbS.Checked
        If cbS.Checked = True Then tbFS.Value = tbFS.Tag
    End Sub

    Private Sub cbH_CheckedChanged(sender As Object, e As EventArgs) Handles cbH.CheckedChanged
        tbH.Visible = cbH.Checked
        If cbH.Checked = True Then tbH.Value = tbH.Tag
    End Sub

    Sub brisi(ByVal text As String, ByVal what As String)
        If text.Trim.ToUpper.IndexOf(what) >= 0 Then
            Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
            Dim c As Integer = text.Trim.ToUpper.Substring(b).IndexOf("$")
            Dim colorName As String = text.Trim.ToUpper.Substring(b + what.Length, c - b - what.Length)
            text = Replace(text, what.Trim.ToLower + colorName + "$", "", 1, , CompareMethod.Text)
        End If
    End Sub

    Private Sub cbTAC_CheckedChanged(sender As Object, e As EventArgs) Handles cbTAC.CheckedChanged
        If cbTAC.Checked = True Then cbAR.Checked = False
    End Sub

    Private Sub cbAR_CheckedChanged(sender As Object, e As EventArgs) Handles cbAR.CheckedChanged
        If cbAR.Checked = True Then cbTAC.Checked = False
    End Sub

    Private Sub cbInlineAWL_CheckedChanged(sender As Object, e As EventArgs) Handles cbInline.CheckedChanged
        If cbInline.Checked = True Then
            txtX.Text = ""
            txtY.Text = ""
        End If
    End Sub

    Private Sub cbOnButtonClick_CheckedChanged(sender As Object, e As EventArgs) Handles cbOnButtonClick.CheckedChanged
        Panel2.Visible = cbOnButtonClick.Checked
    End Sub

    Private Sub cbDontOpen_CheckedChanged(sender As Object, e As EventArgs) Handles cbDontOpen.CheckedChanged
        dgvDontOpen.Visible = cbDontOpen.Checked
    End Sub

    Private Sub cbT2BS_CheckedChanged(sender As Object, e As EventArgs) Handles cbT2BS.CheckedChanged
        tbBFS.Visible = cbT2BS.Checked
        If cbT2BS.Checked = True Then tbBFS.Value = tbBFS.Tag
    End Sub

    Private Sub tb_Scroll(ByVal sender As Object, ByVal e As EventArgs) Handles tbBFS.Scroll, tbFS.Scroll, tbNFS.Scroll
        ToolTip1.SetToolTip(sender, sender.Value.ToString())
    End Sub

    '************
    'datagridview
    Public Shared MouseX As Integer

    Public Shared MouseY As Integer
    Private mouseLocation As DataGridViewCellEventArgs

    'dgvOnSaveNextStop.MouseDown,
    'dgvOnSaveNextClose.MouseDown,
    'dgvOnSaveNextMSG.MouseDown,
    'dgvOnSaveNextSimpleMSG.MouseDown,
    'dgvOnSaveNextNote.MouseDown,
    'dgvOnSaveNextDelete.MouseDown,
    'dgvOnSaveNextExec.MouseDown,
    'dgvOnSavePanelAutoListTo.MouseDown,
    'dgvOnSavePanelAddNewRow.MouseDown,
    'dgvOnSavePanelSkip.MouseDown,
    'dgvOnButtonClickStop.MouseDown,
    'dgvOnEnterPanelSkip.MouseDown
    Private Sub dgv_RowPostPaint(ByVal sender As System.Object, ByVal e As DataGridViewRowPostPaintEventArgs) Handles dgvOnSaveNextStop.RowPostPaint,
    dgvOnSaveNextClose.RowPostPaint, dgvOnSaveNextMSG.RowPostPaint, dgvOnSaveNextSimpleMSG.RowPostPaint,
    dgvOnSaveNextNote.RowPostPaint, dgvOnSaveNextDelete.RowPostPaint, dgvOnSaveNextExec.RowPostPaint,
    dgvOnButtonClickStop.RowPostPaint, dgvOnSaveNextFocusOn.RowPostPaint,
    dgvOnSaveExec.RowPostPaint, dgvOnExitMSG.RowPostPaint

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim rowIdx As Integer = CInt((e.RowIndex + 1).ToString())
        Dim rowFont As New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim centerFormat As Object = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center
        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)

    End Sub

    Private Sub dgv_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles dgvOnSaveNextStop.DragDrop,
    dgvOnSaveNextClose.DragDrop, dgvOnSaveNextMSG.DragDrop, dgvOnSaveNextSimpleMSG.DragDrop,
    dgvOnSaveNextNote.DragDrop, dgvOnSaveNextDelete.DragDrop, dgvOnSaveNextExec.DragDrop,
    dgvOnButtonClickStop.DragDrop, dgvOnSaveNextFocusOn.DragDrop,
    dgvOnSaveExec.DragDrop, dgvOnExitMSG.DragDrop, dgvDontOpen.DragDrop

        If e.Data IsNot Nothing Then
            Dim text As String = e.Data.GetData(DataFormats.Text)
            Dim clientPoint As Point = sender.PointToClient(New Point(e.X, e.Y))
            Dim info As DataGridView.HitTestInfo = sender.HitTest(clientPoint.X, clientPoint.Y)
            If info.Type = DataGridViewHitTestType.Cell Then
                If sender.Rows(info.RowIndex).Cells(info.ColumnIndex).Value Is Nothing Then
                    sender.Rows(info.RowIndex).Cells(info.ColumnIndex).Value = text
                Else
                    sender.Rows(info.RowIndex).Cells(info.ColumnIndex).Value = sender.Rows(info.RowIndex).Cells(info.ColumnIndex).Value.ToString.Trim + " " + text
                End If
            End If
        End If

    End Sub

    Private Sub dgv_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles dgvOnSaveNextStop.DragEnter,
    dgvOnSaveNextClose.DragEnter, dgvOnSaveNextMSG.DragEnter, dgvOnSaveNextSimpleMSG.DragEnter,
    dgvOnSaveNextNote.DragEnter, dgvOnSaveNextDelete.DragEnter, dgvOnSaveNextExec.DragEnter,
    dgvOnButtonClickStop.DragEnter, dgvOnSaveNextFocusOn.DragEnter,
    dgvOnSaveExec.DragEnter, dgvOnExitMSG.DragEnter, dgvDontOpen.DragEnter

        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub dgv_CellMouseEnter(ByVal sender As Object, ByVal location As DataGridViewCellEventArgs) Handles dgvOnSaveNextStop.CellMouseEnter,
    dgvOnSaveNextClose.CellMouseEnter, dgvOnSaveNextMSG.CellMouseEnter, dgvOnSaveNextSimpleMSG.CellMouseEnter,
    dgvOnSaveNextNote.CellMouseEnter, dgvOnSaveNextDelete.CellMouseEnter, dgvOnSaveNextExec.CellMouseEnter,
    dgvOnButtonClickStop.CellMouseEnter, dgvOnSaveNextFocusOn.CellMouseEnter,
    dgvOnSaveExec.CellMouseEnter, dgvOnExitMSG.CellMouseEnter, dgvDontOpen.CellMouseEnter

        mouseLocation = location

    End Sub

    'ovo skida defaultni meni koji se pojavljuje na desno dugme
    Private Sub dgv_ECS1(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvOnSaveNextStop.EditingControlShowing,
                dgvOnSaveNextClose.EditingControlShowing, dgvOnSaveNextMSG.EditingControlShowing, dgvOnSaveNextSimpleMSG.EditingControlShowing,
                dgvOnSaveNextNote.EditingControlShowing, dgvOnSaveNextDelete.EditingControlShowing, dgvOnSaveNextExec.EditingControlShowing,
                dgvOnButtonClickStop.EditingControlShowing, dgvOnSaveNextFocusOn.EditingControlShowing,
                dgvOnSaveExec.EditingControlShowing, dgvOnExitMSG.EditingControlShowing, dgvDontOpen.EditingControlShowing

        Dim dgv As DataGridView = CType(sender, DataGridView)
        If dgv.Tag = 0 Then
            If dgv.CurrentCell.ColumnIndex = 0 Then e.Control.ContextMenuStrip = mnu00
            If dgv.CurrentCell.ColumnIndex = 1 Then e.Control.ContextMenuStrip = mnu01
        End If

    End Sub

    'Private Sub dgv_ECS2(ByVal sender As Object, ByVal e As DataGridViewEditingControlShowingEventArgs) Handles dgvASGN.EditingControlShowing,
    '            dgvColor.EditingControlShowing,
    '            dgvDelete.EditingControlShowing,
    '            dgvDoAssign.EditingControlShowing,
    '            dgvDoRO.EditingControlShowing,
    '            dgvDoVF.EditingControlShowing,
    '            dgvDoVT.EditingControlShowing,
    '            dgvStop.EditingControlShowing,
    '            dgvOdSkip.EditingControlShowing,
    '            dgvOMSG.EditingControlShowing,
    '            dgvRO.EditingControlShowing,
    '            dgvMessage.EditingControlShowing,
    '            dgvSMSG.EditingControlShowing,
    '            dgvStop.EditingControlShowing,
    '            dgvVF.EditingControlShowing,
    '            dgvVT.EditingControlShowing
    '    e.Control.ContextMenuStrip = mnuColumnText
    'End Sub
    Private Sub dgv_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgvOnSaveNextStop.MouseDown,
                dgvOnSaveNextClose.MouseDown, dgvOnSaveNextMSG.MouseDown, dgvOnSaveNextSimpleMSG.MouseDown, dgvOnSaveNextNote.MouseDown,
                dgvOnSaveNextDelete.MouseDown, dgvOnSaveNextExec.MouseDown, dgvOnButtonClickStop.MouseDown, dgvOnSaveNextFocusOn.MouseDown,
                dgvOnSaveExec.MouseDown, dgvOnExitMSG.MouseDown, dgvDontOpen.MouseDown

        MouseX = e.X
        MouseY = e.Y

    End Sub

    'Private Sub dgv_CellMouseDown(ByVal sender As Object, ByVal e As  DataGridViewCellMouseEventArgs) Handles dgvASGN.CellMouseDown,
    'dgvColor.CellMouseDown,
    '        dgvDelete.CellMouseDown,
    '        dgvDoAssign.CellMouseDown,
    '        dgvDoRO.CellMouseDown,
    '        dgvDoVF.CellMouseDown,
    '        dgvDoVT.CellMouseDown,
    '        dgvStop.CellMouseDown,
    '        dgvOdSkip.CellMouseDown,
    '        dgvOMSG.CellMouseDown,
    '        dgvRO.CellMouseDown,
    '        dgvMessage.CellMouseDown,
    '        dgvSMSG.CellMouseDown,
    '        dgvStop.CellMouseDown,
    '        dgvVF.CellMouseDown,
    '        dgvVT.CellMouseDown
    '    Dim dgv As  DataGridView = CType(sender,  DataGridView)
    '    Dim rowClicked As DataGridView.HitTestInfo = dgv.HitTest(e.X, e.Y)
    '    If e.Button =  MouseButtons.Right AndAlso e.RowIndex > -1 Then
    '        dgv.ClearSelection()
    '        mnuColumnText.Show(dgv, New System.Drawing.Point(MouseX, MouseY))
    '    End If
    'End Sub
    Private Sub dgv_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvOnSaveNextStop.CellMouseDown,
        dgvOnSaveNextClose.CellMouseDown, dgvOnSaveNextMSG.CellMouseDown, dgvOnSaveNextSimpleMSG.CellMouseDown,
        dgvOnSaveNextNote.CellMouseDown, dgvOnSaveNextDelete.CellMouseDown, dgvOnSaveNextExec.CellMouseDown,
        dgvOnButtonClickStop.CellMouseDown, dgvOnSaveNextFocusOn.CellMouseDown,
        dgvOnSaveExec.CellMouseDown, dgvOnExitMSG.CellMouseDown, dgvDontOpen.CellMouseDown

        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim ht As DataGridView.HitTestInfo = dgv.HitTest(e.X, e.Y)

        Try
            If e.Button = MouseButtons.Right AndAlso e.RowIndex > -1 AndAlso e.ColumnIndex > -1 AndAlso
               dgv.RowCount > 0 AndAlso dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).IsInEditMode = True Then
                dgv.ClearSelection() : selectedText = ""
                eRowIndex = e.RowIndex : eColumnIndex = e.ColumnIndex
                Dim tb As TextBox = CType(dgv.EditingControl, DataGridViewTextBoxEditingControl)
                Dim ClickIndex As Integer = tb.GetCharIndexFromPosition(e.Location)
                lastIndex = tb.Text.LastIndexOf(" ", ClickIndex) + 1
                If tb.Text <> "" Then tb.Text = tb.Text + " "
                nextIndex = tb.Text.IndexOf(" ", ClickIndex)
                selectedText = tb.Text.Substring(lastIndex, nextIndex - lastIndex)
                selectedDgv = dgv
                If e.ColumnIndex = 0 AndAlso dgv.Tag = 0 Then mnu00.Tag = dgv.Columns(e.ColumnIndex).Name
                If e.ColumnIndex = 1 AndAlso dgv.Tag = 0 Then mnu01.Tag = dgv.Columns(e.ColumnIndex).Name
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Dim eRowIndex As Integer = -1
    Dim eColumnIndex As Integer = -1
    Dim selectedDgv As DataGridView
    Dim selectedText As String = ""
    Dim tt As String = ""
    Dim nextIndex As Integer
    Dim lastIndex As Integer
    Dim neselektuj As Boolean = False

    Private Sub mnu00_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu00.ItemClicked
        Dim ci As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        neselektuj = False
        If ci.Name.Trim.ToUpper.IndexOf("CAST") = 0 AndAlso selectedText.Trim <> "" Then
            tt = ci.Text.Trim.Replace("cast ", "cast " + selectedText + " ")
        End If
        If ci.Name.Trim.ToUpper.IndexOf("ISNULL") = 0 AndAlso selectedText.Trim <> "" Then
            tt = ci.Text.Trim.Replace("value", selectedText)
        End If
        If ci.Name.Trim.ToUpper = "DFIND" Then
            neselektuj = True
            Call findDGV(selectedDgv, mnu00.Tag)
        End If
    End Sub

    Private Sub mnu01_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu01.ItemClicked
        neselektuj = True
        Dim ci As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        If ci.Name.Trim.ToUpper = "DDFIND" Then Call findDGV(selectedDgv, mnu01.Tag)
    End Sub

    Private Sub mnu00_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles mnu00.Closing
        If neselektuj = False Then
            selectedDgv.CurrentCell = selectedDgv.Item(0, 1)
            Dim pp As String = selectedDgv.Rows(eRowIndex).Cells(eColumnIndex).Value
            selectedText = pp.Substring(lastIndex, nextIndex - lastIndex)
            pp = pp.Substring(0, lastIndex) + tt + pp.Substring(nextIndex)
            If eRowIndex > -1 AndAlso eColumnIndex > -1 Then
                selectedDgv.Rows(eRowIndex).Cells(eColumnIndex).Value = pp.Trim
                selectedDgv.CurrentCell = selectedDgv.Item(eRowIndex, eColumnIndex)
            End If
            selectedText = ""
        End If
    End Sub

    Private Sub cbDESO_CheckedChanged(sender As Object, e As EventArgs) Handles cbDESO.CheckedChanged
        txtDESO.Visible = cbDESO.Checked
        txtDESO.Focus()
    End Sub

    Private Sub cbGH_CheckedChanged(sender As Object, e As EventArgs) Handles cbGH.CheckedChanged
        txtGH.Visible = cbGH.Checked
        txtGH.Focus()
    End Sub

    Private Sub cbBH_CheckedChanged(sender As Object, e As EventArgs) Handles cbBH.CheckedChanged
        txtT2BH.Visible = cbBH.Checked
        txtT2BH.Focus()
    End Sub

    Private Sub cbBW_CheckedChanged(sender As Object, e As EventArgs) Handles cbBW.CheckedChanged
        txtT2BW.Visible = cbBW.Checked
        txtT2BW.Focus()
    End Sub

    Private Sub cbT2BFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbT2BFC.CheckedChanged
        Mkc_ColorCombobox3T.Visible = cbT2BFC.Checked
        If cbT2BFC.Checked = False Then
            Mkc_ColorCombobox3T.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_ColorCombobox3T.Focus()
        End If
    End Sub

    Private Sub cbT2BBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbT2BBC.CheckedChanged
        Mkc_ColorCombobox4T.Visible = cbT2BBC.Checked
        If cbT2BBC.Checked = False Then
            Mkc_ColorCombobox4T.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_ColorCombobox4T.Focus()
        End If

    End Sub

    Private Sub btnT0Cancel_Click(sender As Object, e As EventArgs) Handles btnT0Cancel.Click, btnT1Cancel.Click, btnT2Cancel.Click, btnT3Cancel.Click, btnT4Cancel.Click, btnT5Cancel.Click, btnT6Cancel.Click, btnT7Cancel.Click
        Dim b As Button = DirectCast(sender, Button)
        Call getAgainT(b.Tag)
    End Sub

    Sub getAgainT(ByVal T As Integer)
        Call rResetT()
        Dim dt As DataTable = getDTT()
        If dt.Rows.Count = 1 Then
            Call getVariablesT(dt)
            Try
                If T = 0 Then getMetaDataPaneT0()
                If T = 1 Then getMetaDataPaneT1()
                If T = 2 Then getMetaDataPaneT2()
                If T = 3 Then getMetaDataPaneT3()
                If T = 4 Then getMetaDataPaneT4()
                If T = 5 Then getMetaDataPaneT5()
                If T = 6 Then getMetaDataPaneT6()
                If T = 7 Then getMetaDataPaneT7()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnTOK_Click(sender As Object, e As EventArgs) Handles btnT0OK.Click, btnT1OK.Click, btnT2OK.Click, btnT3OK.Click, btnT4OK.Click, btnT5OK.Click, btnT6OK.Click, btnT7OK.Click
        Dim b As Button = DirectCast(sender, Button)
        Call ssetT(b.Tag)
        b.Parent.AutoSize = False
        b.Parent.Height = 20
    End Sub

    Sub ssetT(ByVal T As Integer)

        Me.Cursor = Cursors.WaitCursor
        Dim strSQl As String = "select appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder," +
                "tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo from _ISTTables where appcode=N'" + Me.cboIST.SelectedValue.ToString.Trim +
                "' and tableName=N'" + ttable + "' and cast (validFrom as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        Dim strSQlU As String = ""
        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Me.jezik)
        'If dt.Rows.Count = 0 Then
        '    'insert (nemoguce)
        'End If
        If dt.Rows.Count = 1 Then
            'update
            strSQlU = "update _ISTTables set "
            strSQl = ""
            Try
                If T = 0 Then
                    typeOfTableParentChild = "" : parentTableName = "" : ValidFrom = "" : ValidTo = "" : tableOrder = ""
                    setMetaDataPaneT0()
                    'typeOfTableParentChild,parentTableName,ValidFrom,ValidTo,tableOrder - paneT0
                    If typeOfTableParentChild.Trim <> "" Then strSQl = strSQl + " typeOfTableParentChild='" + typeOfTableParentChild + "',"
                    If parentTableName.Trim <> "" Then strSQl = strSQl + " parenttableName=N'" + parentTableName + "',"
                    If ValidFrom.Trim <> "" Then strSQl = strSQl + " validFrom ='" + Convert.ToDateTime(ValidFrom).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "',"
                    If ValidTo.Trim <> "" Then strSQl = strSQl + " ValidTo ='" + Convert.ToDateTime(ValidTo).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "',"
                    If tableOrder.Trim <> "" Then strSQl = strSQl + " tableOrder='" + tableOrder + "',"
                End If
                If T = 1 Then
                    tableDescription = setMetaDataPaneT1()
                    If tableDescription.Trim <> "" Then strSQl = strSQl + " tableDescription=N'" + tableDescription + "',"
                End If
                If T = 3 Then
                    childAtributes = ""
                    childAtributes = setMetaDataPaneT3()
                    If childAtributes.Trim <> "" Then strSQl = strSQl + " childAtributes=N'" + childAtributes + "',"

                    dataentryScreenOrder = ""
                    If dataentryScreenOrder.Trim <> "" Then strSQl = strSQl + " dataentryScreenOrder='" + dataentryScreenOrder + "',"
                End If

                'parentAtributes = ""
                If T = 2 OrElse T = 4 OrElse T = 5 OrElse T = 6 OrElse T = 7 Then
                    parentAtributes = ""
                    parentAtributes = parentAtributes + setMetaDataPaneT2()
                    parentAtributes = parentAtributes + setMetaDataPaneT4()
                    parentAtributes = parentAtributes + setMetaDataPaneT5()
                    parentAtributes = parentAtributes + setMetaDataPaneT6()
                    parentAtributes = parentAtributes + setMetaDataPaneT7()
                End If

                If parentAtributes.Trim <> "" Then
                    parentAtributes = parentAtributes.Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
                    strSQl = strSQl + " parentAtributes=N'" + parentAtributes + "',"
                End If
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try

            If strSQl <> "" Then
                strSQl = strSQl.TrimEnd(",")
                strSQl = strSQl + " where appcode=N'" + Me.cboIST.SelectedValue.ToString.Trim + "' and tableName=N'" + ttable + "'"

                If ValidFrom.Trim <> "" Then
                    strSQl = strSQl + "  and cast (validFrom as date)='" + Convert.ToDateTime(ValidFrom).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                Else
                    strSQl = strSQl + "  and cast (validFrom as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                End If

                strSQlU = strSQlU + strSQl
            Else
                strSQlU = ""
            End If
        End If

        Me.txtTUpdate.Text = strSQlU
        Dim pp As String = ""
        If Not Me.txtTUpdate.Tag Is Nothing Then
            pp = Me.txtTUpdate.Tag + ";"
        End If
        Me.txtTUpdate.Tag = pp + "ISTTABELE" + ";"

        Me.txtTUpdate.Visible = True
        Me.Cursor = Cursors.Default

    End Sub

    Dim FormPoint As Point

    Private Sub tv_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tv.NodeMouseClick
        Me.cboCPE.Visible = False
        promenaVOD = False

        Dim ClickPoint As Point = New Point(e.X, e.Y)
        Dim ClickNode As TreeNode = tv.GetNodeAt(ClickPoint)
        If ClickNode Is Nothing Then Return

        tv.SelectedNode = e.Node
        Dim mySelectedNode As TreeNode
        mySelectedNode = tv.SelectedNode

        Call tvNodeMouseDoubleClick(mySelectedNode)

        If e.Button = MouseButtons.Right Then
            tabela = ""
            tValidFrom = ""
            tMaxRbr = ""
            If mySelectedNode.Tag.indexof("TT") = 0 Then
                Dim tabela As String = mySelectedNode.Text
                Dim indextabela As Integer = mySelectedNode.Index
                tValidFrom = mySelectedNode.Tag.split("$")(1)
                mnu03.Tag = tabela + ";" + tValidFrom + ";" + Str(indextabela).Trim
                tFT.Tag = mnu03.Tag
                mnu03.Show(tv, e.Location)
            End If
            If mySelectedNode.Tag.indexof("CC") = 0 Then
                Dim polje As String = mySelectedNode.Text
                Dim indexpolje As Integer = mySelectedNode.Index
                tabela = mySelectedNode.Parent.Text
                Dim indextabela As Integer = mySelectedNode.Parent.Index
                txtCLAC.Text = "Add column to table: " + tabela
                tValidFrom = mySelectedNode.Tag.split("$")(1)
                tMaxRbr = mySelectedNode.Tag.split("$")(2)
                If tabela = "" Then tabela = mySelectedNode.Text : indextabela = mySelectedNode.Index
                mnu02.Tag = tabela + ";" + tValidFrom + ";" + tMaxRbr + ";" + polje + ";" + Str(indextabela).Trim + ";" + Str(indexpolje).Trim
                tFC.Tag = mnu02.Tag
                mnu02.Show(tv, e.Location)
            End If
        End If
    End Sub

    Private Sub mnu02_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu02.ItemClicked
        Dim ci As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim pp() As String = sender.tag.split(";")
        'pp(0) je tabela , pp(3) je polje    mnu02.Tag = tabela + ";" + tValidFrom + ";" + tMaxRbr + ";" + polje
        If ci.Name.Trim.ToUpper = "TDCI" AndAlso ISTMessageBox.Show("Are you sure you want to delete column?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call bbrisiKolonu(pp, True, False)
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Delete column from _IST DialogResult Yes", pp(0).Trim + "." + pp(2).Trim, "Are you sure you want to delete column?")
        ElseIf ci.Name.Trim.ToUpper = "TDCDB" AndAlso ISTMessageBox.Show("Are you sure you want to delete column?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'pp(3)
            Call bbrisiKolonu(pp, True, True)
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Delete column from _IST and DB DialogResult Yes", pp(0).Trim + "." + pp(3).Trim, "Are you sure you want to delete column?")
        ElseIf ci.Name.Trim.ToUpper = "TRENAMEC" Then
            Me.Cursor = Cursors.WaitCursor
            Dim cntl As Control = mnu02.SourceControl
            Dim fforma As mFormRenameTC = New mFormRenameTC(dsIST, Me, mnu02.Right, mnu02.Top, appCode, Me.ISTConnectionString, Me.DBConnectionString, pp, "C")
            Call openForma(fforma)
            Me.Cursor = Cursors.Default
        ElseIf ci.Name.Trim.ToUpper = "TREFRESH" Then
            mnu02.Close()
            Call DajTabelePoljaIST(tv)
            tv.Refresh()
            Dim indextabela As Integer = CInt(pp(4))
            tv.Nodes(indextabela).Expand()
        ElseIf ci.Name.Trim.ToUpper = "TSSC1" Then
            Call openCloseC(txtCLAC, txtCLAC.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSSC2" Then
            Call openCloseC(txtL0, txtL0.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSSC3" Then
            Call openCloseC(txtL6, txtL6.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSSC4" Then
            Call openCloseC(txtL1, txtL1.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSSC5" Then
            Call openCloseC(txtL11, txtL11.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSSC6" Then
            Call openCloseC(txtL4, txtL4.Parent)
        End If
    End Sub

    Private Sub mnu03_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu03.ItemClicked
        Dim ci As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim pp() As String = sender.tag.split(";")
        'pp(0) je tabela     mnu03.Tag =  tabela + ";" + tValidFrom + ";" + Str(indextabela).Trim
        If ci.Name.Trim.ToUpper = "TDTI" AndAlso ISTMessageBox.Show("Are you sure you want to delete table?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call bbrisiTabelu(pp, True, False)
            mnu03.Close()
        ElseIf ci.Name.Trim.ToUpper = "TDTDB" AndAlso ISTMessageBox.Show("Are you sure you want to delete table?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'pp(3)
            Call bbrisiTabelu(pp, True, True)
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("delete table from _IST and DB DialogResult Yes", pp(0).Trim, "Are you sure you want to delete table?")
            mnu03.Close()
        ElseIf ci.Name.Trim.ToUpper = "TRENAMET" Then
            Me.Cursor = Cursors.WaitCursor
            Dim cntl As Control = mnu02.SourceControl
            Dim fforma As mFormRenameTC = New mFormRenameTC(dsIST, Me, mnu02.Right, mnu02.Top, appCode, Me.ISTConnectionString, Me.DBConnectionString, pp, "T")
            Call openForma(fforma)
            Me.Cursor = Cursors.Default
        ElseIf ci.Name.Trim.ToUpper = "TTREFRESH" Then
            mnu03.Close()
            Call DajTabelePoljaIST(tv)
            tv.Refresh()
        ElseIf ci.Name.Trim.ToUpper = "TSST1" Then
            Call openCloseT(txtTLAT, txtTLAT.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST2" Then
            Call openCloseT(txtTL0, txtTL0.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST3" Then
            Call openCloseT(txtTL1, txtTL1.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST4" Then
            Call openCloseT(txtTL2, txtTL2.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST5" Then
            Call openCloseT(txtTL3, txtTL3.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST6" Then
            Call openCloseT(txtTL4, txtTL4.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST7" Then
            Call openCloseT(txtTL5, txtTL5.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST8" Then
            Call openCloseT(txtTL6, txtTL6.Parent)
        ElseIf ci.Name.Trim.ToUpper = "TSST9" Then
            Call openCloseT(txtTL7, txtTL7.Parent)
        End If
    End Sub

    Private Sub tFC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tFC.KeyPress
        Try
            '?????
            Select Case e.KeyChar
                Case ChrW(27) 'ESC kakvo god da je pp (prazno puno)
                'trt.Text = DGTabelePanel(DGi(tabela)).Rows(0).Item(plj).ToString
                'If autb = True Then
                '    CType(sender, AutoCompleteTextbox).SelectAll()
                'Else
                '    CType(sender, TextBox).SelectAll()
                'End If
                Case ChrW(13) 'Enter
                    Dim pp() As String = tFC.Tag.split(";")
                    Dim indextabela As Integer = CInt(pp(4))
                    Dim indextrazeno As Integer = -1
                    Dim txt As String = tFC.Text.Trim.ToUpper
                    For i As Integer = 0 To tv.Nodes(indextabela).Nodes.Count - 1
                        If tv.Nodes(indextabela).Nodes(i).Text.Trim.ToUpper = txt Then
                            indextrazeno = i
                            Exit For
                        End If
                    Next
                    If indextrazeno > -1 Then
                        mnu02.Close()
                        tv.SelectedNode = tv.Nodes(indextabela).Nodes(indextrazeno)
                    Else
                        tFC.Text = tFC.Text + " DOES NOT EXIST!"
                        tFC.Focus()
                    End If
                Case Else
            End Select
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Function postojiuDB(ByVal tabela As String, ByVal polje As String) As Boolean
        postojiuDB = True
        Dim sql As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + tabela + "' and  COLUMN_NAME=N'" + polje + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            postojiuDB = False
        End If
    End Function

    Sub bbrisiKolonu(ByVal pp() As String, ByVal ist As Boolean, ByVal db As Boolean)

        Dim sqlIST As String = "delete from ISTPolja where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(3).Trim + "'" +
        " and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"

        sqlIST = sqlIST + "delete from ISTAWLs where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(3).Trim + "'" +
        " and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        sqlIST = sqlIST + "delete from ISTQuestionExplanation where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(3).Trim + "'" +
        " and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        Dim sqlDB As String = "" : Dim sqlDBDropTip As String = "" : Dim DropTip As String = ""
        If postojiuDB(pp(0).Trim, pp(3).Trim) Then
            'skini prvo kljuc ako je kljuc
            'Alter table drop primary key
            sqlDB = "ALTER TABLE " + pp(0).Trim + " DROP COLUMN " + pp(3).Trim + ";"
            sqlDBDropTip = pp(0).Trim + ";" + pp(3) + "#"
            DropTip = DropTip + "DROP" + "#"
            db = True
        Else
            db = False
        End If

        Dim pDB As String = "nok"
        Dim pIST As String = "nok"

        If ist = True And db = False Then
            pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, "ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION")
            If pIST = "nok" Then ISTMessageBox.Show("Error. Not deleted from IST!") Else ISTMessageBox.Show("Deleted from IST!")
        End If
        If ist = True And db = True Then
            pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, "ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION", sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
            If pIST = "nok" Then ISTMessageBox.Show("Error. Not deleted from IST!") Else ISTMessageBox.Show("Deleted from IST!")
            If pIST = "ok" Then
                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If pDB = "nok" Then ISTMessageBox.Show("Error. Not deleted from DB!") Else ISTMessageBox.Show("Deleted from DB!")
            End If
        End If

        Call DajTabelePoljaIST(tv)
        tv.Refresh()
        Dim indextabela As Integer = CInt(pp(4))
        Call tvNodeMouseDoubleClick(tv.Nodes(indextabela).Nodes(0))
        Call tvNodeMouseDoubleClick(tv.Nodes(indextabela).Nodes(0))

        tv.Nodes(indextabela).Expand()

    End Sub

    Sub openForma(ByVal fforma As Form)
        If Not CType(fforma, Control).IsDisposed Then
            Try
                fforma.AccessibleName = "mem"
                fforma.AccessibleDescription = mnu02.AccessibleDescription
                fforma.Tag = mnu02.Tag
                fforma.ShowDialog()
                fforma.StartPosition = FormStartPosition.CenterScreen
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                If Not CType(fforma, Control).IsDisposed Then
                    fforma.Dispose()
                End If

            End Try
            Call refreshT()
        End If
    End Sub

    Sub refreshT()
        Call DajTabelePoljaIST(tv)
        tv.Refresh()
        Call tvNodeMouseDoubleClick(tv.Nodes(0))
        Call tvNodeMouseDoubleClick(tv.Nodes(0))
    End Sub

    Sub bbrisiTabelu(ByVal pp() As String, ByVal ist As Boolean, ByVal db As Boolean)

        Dim sqlIST As String = "delete from IstTabele where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "';"

        sqlIST = sqlIST + "delete from ISTPolja where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "';"

        sqlIST = sqlIST + "delete from ISTAWLs where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "';"

        sqlIST = sqlIST + "delete from ISTQuestionExplanation where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "';"

        sqlIST = sqlIST + "delete from ISTLK where sifist=N'" + appCode + "' and tabela=N'" + pp(0).Trim + "';"

        'NAMERNO NE TREBA VOD JER ZA TABELU SAMO JEDNA MOZE DA POSTOJI U BAZI

        Dim sqlDB As String = "DROP TABLE " + pp(0).Trim + ";"
        Dim sqlDBDropTip As String = ""
        Dim DropTip As String = ""
        Dim pDB As String = "nok"
        Dim pIST As String = "nok"

        If ist = True And db = False Then
            pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, "ISTTABELE;ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION;ISTLK")
            If pIST = "nok" Then ISTMessageBox.Show("Error. Not deleted from IST!") Else ISTMessageBox.Show("Deleted from IST!")
        End If
        If ist = True And db = True Then
            pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, "ISTTABELE;ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION;ISTLK")
            If pIST = "nok" Then ISTMessageBox.Show("Error. Not deleted from IST!") Else ISTMessageBox.Show("Deleted from IST!")
            If pIST = "ok" Then
                Dim por As String = "Are you sure that you want to drop table " + pp(0).Trim + " from DB?" + nvrd + nvrd + "FOR UNDO ACTION YOU HAVE TO CREATE TABLE IN DB" + nvrd + nvrd + "UNDO WILL NOT CREATE TABLE IN DB!"
                Dim dr1 As DialogResult = ISTMessageBox.Show(por, "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Select Case dr1
                    Case DialogResult.Yes
                        Dim dr2 As DialogResult = ISTMessageBox.Show(por, "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                        Select Case dr2
                            Case DialogResult.Yes
                                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                                If pDB = "nok" Then ISTMessageBox.Show("Error. Not deleted from DB!") Else ISTMessageBox.Show("Deleted from DB!")
                                If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("delete table from _IST DialogResult Yes", pp(0).Trim, "Are you sure you want To delete table?")
                            Case DialogResult.No
                                Exit Sub
                            Case DialogResult.Cancel
                                Exit Sub
                        End Select
                    Case DialogResult.No
                        Exit Sub
                    Case DialogResult.Cancel
                        Exit Sub
                End Select
            End If
        End If

        Call DajTabelePoljaIST(tv)
        tv.Refresh()
        Call tvNodeMouseDoubleClick(tv.Nodes(0))
        Call tvNodeMouseDoubleClick(tv.Nodes(0))
    End Sub

    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, Optional ByVal izvestaj As String = "", Optional ByVal upit As String = "")
        Dim sifist As String = appCode
        Dim god As String = Date.Today.Year.ToString
        Dim mes As String = String.Format("{0:d2}", Date.Today.Month.ToString)
        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
        & "(SifIst,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
        & " values( " _
        & "N'" & sifist & "','" & god & "','" & mes & "'," _
        & "N'" & proces.Replace("'", "") & "',N'" + izvestaj.Replace("'", "") & "',N'" + upit.Replace("'", "") & "'," _
        & "N'" & GetUserName.ToString.Trim & "'," _
        & "" & "(select top 1 GETDATE())" & ");" + nvrd

        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)
        Dim ok1 As String = izvrsiSQL(strSQL, konDepo)
        If ok1 = "nok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER76", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub frm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Dim frmCollection As New FormCollection()
        frmCollection = Application.OpenForms()
        If Not frmCollection.Item("FormAddTable") Is Nothing AndAlso frmCollection.Item("FormAddTable").IsHandleCreated Then frmCollection.Item("FormAddTable").Close()
    End Sub

    Sub rResetPane(ByVal container As Control)
        For Each k As Control In DirectCast(container, Control).Controls
            If TypeOf k Is CheckBox Then DirectCast(k, CheckBox).Checked = False
            If TypeOf k Is ComboBox Then DirectCast(k, ComboBox).Text = ""
            If TypeOf k Is TextBox AndAlso DirectCast(k, TextBox).Tag <> "VP" Then DirectCast(k, TextBox).Text = ""
            If TypeOf k Is TextBox AndAlso DirectCast(k, TextBox).Tag = "VF" Then DirectCast(k, TextBox).Visible = False

            Dim vodIST As String = "" : Dim vdoIST As String = ""
            Dim vodA As String = vodApp(appCode)
            vodIST = vodA.Split("$")(0) : vdoIST = vodA.Split("$")(1)
            If TypeOf k Is DateTimePicker2 AndAlso DirectCast(k, DateTimePicker2).Name.IndexOf("txtvod") = 0 Then DirectCast(k, DateTimePicker2).Text = vodIST
            If TypeOf k Is DateTimePicker2 AndAlso DirectCast(k, DateTimePicker2).Name.IndexOf("txtvdo") = 0 Then DirectCast(k, DateTimePicker2).Text = vdoIST

            If TypeOf k Is RadioButton Then DirectCast(k, RadioButton).Checked = False
            If TypeOf k Is mkc_ColorCombobox.mkc_ColorCombobox Then
                DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).SelectedColor = System.Drawing.Color.Empty
                If DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).Tag = "VF" Then DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).Visible = False
            End If
            If TypeOf k Is DataGridView AndAlso Not DirectCast(k, DataGridView).DataSource Is Nothing Then
                DirectCast(k, DataGridView).DataSource = Nothing
            End If
            If TypeOf k Is Panel Then Call rResetPane(DirectCast(k, Panel))
            If TypeOf k Is GroupBox Then Call rResetPane(DirectCast(k, GroupBox))
            If TypeOf k Is TabControl Then Call rResetPane(DirectCast(k, TabControl))
            If TypeOf k Is CheckedListBox AndAlso Not DirectCast(k, CheckedListBox).DataSource Is Nothing Then
                For i As Integer = 0 To DirectCast(k, CheckedListBox).Items.Count - 1
                    DirectCast(k, CheckedListBox).SetItemChecked(i, False)
                Next
            End If
        Next
    End Sub

    Private Sub btnTATOK_Click(sender As Object, e As EventArgs) Handles btnATOK.Click
        Try

            If Me.txtNameAT.Text = "" Then
                ISTMessageBox.Show("Please, enter table name!")
                Me.txtNameAT.Focus()
                Exit Sub
            End If

            Dim tip As String = "G"
            Dim pomtip As String = ""
            If cboTipAT.SelectedItem Is Nothing OrElse cboTipAT.SelectedItem.ToString.Trim = "" Then
                ISTMessageBox.Show("Please, enter table type!")
                cboTipAT.Focus()
                Exit Sub
            End If
            pomtip = cboTipAT.SelectedItem.ToString.Trim
            tip = pomtip.Trim.Substring(0, 1)
            Dim nadtabela As String = ""
            If cboNadTabelaAT.Visible = True Then
                If cboNadTabelaAT.SelectedValue Is Nothing OrElse cboNadTabelaAT.SelectedValue.ToString.Trim = "" Then
                    ISTMessageBox.Show("Please, enter parent table!")
                    Me.cboNadTabelaAT.Focus()
                    Exit Sub
                End If
                nadtabela = cboNadTabelaAT.SelectedValue.ToString.Trim
            End If

            Dim dodajKljucOdnadtabele As Boolean = False
            If pomtip = "D - Subtable/child table" Then
                dodajKljucOdnadtabele = True
                tip = "D"
            End If

            Dim nname As String = Me.txtNameAT.Text.Trim
            If Me.txtDescriptionAT.Text.Trim = "" Then Me.txtDescriptionAT.Text = nname

            Dim poostojiUDB As Boolean = False
            Dim sss As String = "SELECT 1 FROM sys.Objects WHERE  Object_id = OBJECT_ID(N'" + nname + "') AND Type = N'U'"
            Dim dt As New DataTable
            dt = izvrsiSQLvratiDT(sss, Me.DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then poostojiUDB = True

            Dim poostojiUIST As Boolean = False
            Dim sssI As String = "SELECT tabela FROM ISTtabele WHERE tabela = N'" + nname + "' AND sifist=N'" + appCode + "'"
            Dim dtI As New DataTable
            dtI = izvrsiSQLvratiDT(sssI, Me.ISTConnectionString, Me.jezik)
            If dtI.Rows.Count > 0 Then poostojiUIST = True

            If poostojiUDB = True AndAlso poostojiUIST = True Then
                ISTMessageBox.Show("Name already exists in DB and in IST!")
                Me.txtNameAT.Focus()
                Me.txtNameAT.SelectAll()
                Exit Sub
            End If

            Dim nnameDB As String = Me.txtNameAT.Text.Trim
            If nname.IndexOf(".") < 0 Then nnameDB = "dbo." + nname

            Dim sqlDB As String = "CREATE TABLE " + nnameDB + " (" + nvrd +
                                                "INDGR bit null ," + nvrd +
                                                "LK bit null ," + nvrd +
                                                "LKweb bit null ," + nvrd +
                                                "E001 bit null ," + nvrd +
                                                "date_LKZ datetime null ," + nvrd +
                                                "date_LKO datetime null ," + nvrd +
                                                "user_LKZ nvarchar(50) null ," + nvrd +
                                                "user_LKO nvarchar(50) null ," + nvrd +
                                                "date_LKZweb datetime null ," + nvrd +
                                                "date_LKOweb datetime null ," + nvrd +
                                                "user_LKZweb nvarchar(50) null ," + nvrd +
                                                "user_LKOweb nvarchar(50) null ," + nvrd +
                                                "user_INSERT nvarchar(50) null ," + nvrd +
                                                "date_INSERT datetime null ," + nvrd +
                                                "sourceof_INSERT nvarchar(5) null ," + nvrd +
                                                "user_UPDATE nvarchar(50) null ," + nvrd +
                                                "date_UPDATE datetime null ," + nvrd +
                                                "user_REVIEW nvarchar(50) null ," + nvrd +
                                                "date_REVIEW datetime null ," + nvrd +
                                                "IST_duration integer null ," + nvrd +
                                                "CAPIExported smallint null ," + nvrd +
                                                "ComputerName nvarchar(50) null " + nvrd +
                                                                ");" + nvrd

            Dim sqlDBDropTip As String = "DROP TABLE " + nnameDB + ";" + "#"
            Dim dropTip As String = "DROPTABLE" + "#"
            Dim tabDesc As String = ""

            If cboBCAT.SelectedColor.Name = "Chocalate" Then cboBCAT.SelectedColor = Color.Chocolate
            If cboBCAT.SelectedColor.Name = "Lavander" Then cboBCAT.SelectedColor = Color.Lavender
            If cboFCAT.SelectedColor.Name = "Chocalate" Then cboFCAT.SelectedColor = Color.Chocolate
            If cboFCAT.SelectedColor.Name = "Lavander" Then cboFCAT.SelectedColor = Color.Lavender
            If cboBCAT.SelectedColor.Name = "Transparent" Then cboBCAT.SelectedColor = Color.Snow

            If cboFCAT.SelectedColor.Name <> "0" Then tabDesc = tabDesc + "foreColor" + cboFCAT.SelectedColor.Name + "$"
            If cboBCAT.SelectedColor.Name <> "0" Then tabDesc = tabDesc + "backColor" + cboBCAT.SelectedColor.Name + "$"
            If cboFTAT.SelectedItem <> "" AndAlso cboFTAT.SelectedItem <> "Regular" Then tabDesc = tabDesc + "font" + cboFTAT.SelectedItem + "$"
            If cboTAAT.SelectedItem <> "" AndAlso cboTAAT.SelectedItem <> "Left" Then tabDesc = tabDesc + "l" + cboTAAT.SelectedItem + "A$"

            Dim ffs As String = "8"
            Dim fs As Integer = CInt(tbSAT.Value.ToString())
            ffs = CStr(fs).Trim
            tabDesc = tabDesc + "fontSize" + ffs + "$"

            Dim h As String = tbHAT.Value.ToString()
            If h > 1 Then tabDesc = tabDesc + "lHeight" + h + "$"

            tabDesc = "$" + tabDesc + Me.txtDescriptionAT.Text

            Dim pa As String = "max"
            If cboBGCAT.SelectedColor.Name <> "0" Then pa = pa + ";" + "backGroundColor" + cboBGCAT.SelectedColor.Name + ";"
            Dim cAtr As String = ""
            If tip = "D" Then cAtr = "GRIDCOLUMNSIST"
            Dim sqlI As String = "insert into _ISTTables(" +
                "appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,ValidFrom,ValidTo,parentAtributes,childAtributes" +
                 ") " + nvrd +
                "VALUES (" + nvrd +
                "N'" + appCode + "',N'" + nname + "','" + tip + "',N'" + nadtabela + "',N'" + tabDesc + "','" +
                Me.txtvodAT.Value.ToString("yyyy-MM-dd") + "','" + Me.txtvdoAT.Value.ToString("yyyy-MM-dd") + "',N'" + pa + "',N'" + cAtr + "');" + nvrd

            Dim ssE As String = "SELECT errNumber FROM _ISTRulesDataValidation WHERE tableName = N'" + Me.txtNameAT.Text.Trim + "' AND appCode=N'" + appCode + "' and errNumber='E001'"
            Dim dtE As New DataTable
            dtE = izvrsiSQLvratiDT(ssE, Me.ISTConnectionString, Me.jezik)

            If dtE.Rows.Count = 0 Then
                sqlI = sqlI + " insert into _ISTRulesDataValidation(appCode,tableName,errNumber,Error,errWeight,errTitle,condition,errAction,ValidFrom,ValidTo)" +
                                          "values(N'" & appCode & "',N'" & nname & "','E001','2=3','T','If is needed...',Null,Null,'" +
                                          Me.txtvodAT.Value.ToString("yyyy-MM-dd") + "','" + Me.txtvdoAT.Value.ToString("yyyy-MM-dd") + "');" & nvrd
            End If

            Dim pIST As String = "nok"
            Dim pDB As String = "nok"


            Dim errorDb As Boolean = False
            Dim errorIST As Boolean = False
            If poostojiUDB = False AndAlso poostojiUIST = False Then
                Dim sql As String = ""
                If dodajKljucOdnadtabele = True Then
                    sql = dodajPoljaOdNadtbeleKljuc(nadtabela, nname)
                    If sql <> "~~~" Then
                        Dim pp() As String = sql.Split("~")
                        sqlI = sqlI + pp(0)
                        sqlDB = sqlDB + pp(1)
                        sqlDBDropTip = sqlDBDropTip + pp(2) + "#"
                        dropTip = dropTip + pp(3) + "#"
                    End If

                End If

                pIST = napraviBackUpizvrsiSQLISTTABLES(sqlI, "ISTTABELE;ISTLK", sqlDBDropTip.TrimEnd("#"), dropTip.TrimEnd("#"))
                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If pDB = "nok" Then
                    errorDb = True
                    ISTMessageBox.Show("Error. Not added in DB!")
                End If
            End If

            If poostojiUDB = True AndAlso poostojiUIST = False Then
                pIST = napraviBackUpizvrsiSQLISTTABLES(sqlI, "ISTTABELE;ISTLK")
                If pIST = "nok" Then errorIST = True : ISTMessageBox.Show("Error. Not added in IST!") Else ISTMessageBox.Show("Added in IST!")
            ElseIf poostojiUDB = False AndAlso poostojiUIST = True Then
                pIST = napraviBackUpizvrsiSQLISTTABLES("", "", sqlDBDropTip, dropTip.TrimEnd("#"))
                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If pDB = "nok" Then errorDb = True : ISTMessageBox.Show("Error. Not added in DB!") Else ISTMessageBox.Show("Added in DB!")
            End If

            If errorDb = False AndAlso errorIST = False Then
                Call rResetPane(Me.paneAT)
                Me.paneAT.AutoSize = False
                Me.paneAT.Height = 20
            End If

            Call DajTabelePoljaIST(tv)
        Catch ex As Exception

            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Function dodajPoljaOdNadtbeleKljuc(ByVal nadtabela As String, ByVal tabela As String) As String

        Dim sql As String = ""

        Dim str As String = "select Col.Column_Name As pk from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col WHERE" +
            " Col.Constraint_Name = Tab.Constraint_Name " +
            " And Col.Table_Name = Tab.Table_Name " +
            " And Constraint_Type = 'PRIMARY KEY' " +
            " AND Col.Table_Name ='" + nadtabela + "'"
        Dim dt1 As New DataTable
        dt1 = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
        Dim nn As String = ""
        Dim sqlDB As String = "" : Dim sqlDBDropTip As String = "" : Dim DropTip As String = ""
        Dim sqlIST As String = ""
        For i As Integer = 0 To dt1.Rows.Count - 1
            Dim kol As String = dt1.Rows(i).Item("pk").ToString.Trim
            nn = nn + kol + ","

            Dim poostojiUDB As Boolean = False
            Dim sss As String = "SELECT name FROM sys.columns WHERE Name = N'" + kol + "' AND Object_ID = Object_ID(N'" + tabela + "')"
            Dim dt As New DataTable
            dt = izvrsiSQLvratiDT(sss, Me.DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then poostojiUDB = True

            Dim poostojiUIST As Boolean = False
            Dim sssI As String = "SELECT columnName FROM _ISTTablesColumns WHERE appCode=N'" + appCode + "' and columnName = N'" + kol + "' AND tableName=N'" + tabela + "'"
            Dim dtI As New DataTable
            dtI = izvrsiSQLvratiDT(sssI, Me.ISTConnectionString, Me.jezik)
            If dtI.Rows.Count > 0 Then poostojiUIST = True

            If poostojiUDB = False Then
                Dim p As String = dajPPP(nadtabela, tabela, kol)
                If p <> "~~" Then
                    Dim pp() As String = p.Split("~")
                    sqlDB = sqlDB + pp(0) + nvrd
                    sqlDBDropTip = sqlDBDropTip + pp(1) + "#"
                    DropTip = DropTip + pp(2) + "#"
                End If
            End If

            If poostojiUIST = False Then
                Dim sssNT As String = "SELECT label,orderNumber,columnType,columnLenght,ValidFrom,ValidTo FROM _ISTTablesColumns WHERE appcode=N'" + appCode + "' and columnName = N'" + kol + "' AND tableName=N'" + nadtabela + "'"
                Dim dtIi As New DataTable
                dtIi = izvrsiSQLvratiDT(sssNT, Me.ISTConnectionString, Me.jezik)
                If dtIi.Rows.Count > 0 Then
                    Dim llabel As String = ""
                    Dim rbr As String = ""
                    Dim tipIST As String = ""
                    Dim duzIST As String = ""
                    Dim vod As String = ""
                    Dim vdo As String = ""

                    If Not dtIi.Rows(0).Item("label") Is System.DBNull.Value Then llabel = dtIi.Rows(0).Item("label").ToString.Trim
                    If Not dtIi.Rows(0).Item("orderNumber") Is System.DBNull.Value Then rbr = dtIi.Rows(0).Item("orderNumber").ToString.Trim
                    If Not dtIi.Rows(0).Item("columnType") Is System.DBNull.Value Then tipIST = dtIi.Rows(0).Item("columnType").ToString.Trim
                    If Not dtIi.Rows(0).Item("columnLenght") Is System.DBNull.Value Then duzIST = dtIi.Rows(0).Item("columnLenght").ToString.Trim
                    If Not dtIi.Rows(0).Item("ValidFrom") Is System.DBNull.Value Then vod = CDate(dtIi.Rows(0).Item("VALIDFROM")).ToString("yyyy-MM-dd")
                    If Not dtIi.Rows(0).Item("ValidTo") Is System.DBNull.Value Then vdo = CDate(dtIi.Rows(0).Item("VALIDTO")).ToString("yyyy-MM-dd")

                    sqlIST = sqlIST + "insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,label,orderNumber,columnType,columnLenght,ValidFrom,ValidTo,columnAtributes) VALUES (" +
                    "N'" + appCode + "',N'" + tabela + "',N'" + kol + "','P',N'" + llabel + "','" +
                    CStr(rbr).Trim + "','" + tipIST + "','" + duzIST + "','" + Convert.ToDateTime(vod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "','" +
                    Convert.ToDateTime(vdo).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "',N'');" + nvrd
                End If
            End If

        Next

        nn = nn.TrimEnd(",")
        sqlDB = sqlDB + " alter table " + tabela + "  add primary key (" + nn + ");" + nvrd
        sqlDBDropTip = sqlDBDropTip + tabela + ";" + nn + "#"
        DropTip = DropTip + "ADDPK" + "#"
        sql = sqlIST + "~" + sqlDB + "~" + sqlDBDropTip.TrimEnd("#") + "~" + DropTip.TrimEnd("#")
        Return sql
    End Function

    Function dajPPP(ByVal nadtabela As String, ByVal tabela As String, ByVal pp As String) As String
        Dim sqlDBDropTip As String = ""
        Dim DropTip As String = ""
        Dim sqlDB As String = ""
        dajPPP = "~~"
        Dim sss As String = "select c.name + ' ' + UPPER(tp.name) + " +
            "CASE When tp.name In ('varchar', 'char', 'varbinary', 'binary', 'text') " +
            "THEN '(' + CASE WHEN c.max_length = -1 THEN 'MAX' ELSE CAST(c.max_length AS VARCHAR(5)) END + ')' " +
            "WHEN tp.name IN ('nvarchar', 'nchar', 'ntext') " +
            "THEN '(' + CASE WHEN c.max_length = -1 THEN 'MAX' ELSE CAST(c.max_length / 2 AS VARCHAR(5)) END + ')' " +
            "WHEN tp.name IN ('datetime2', 'time2', 'datetimeoffset')  " +
            "THEN '(' + CAST(c.scale AS VARCHAR(5)) + ')' " +
            "WHEN tp.name = 'decimal'  " +
            "THEN '(' + CAST(c.[precision] AS VARCHAR(5)) + ',' + CAST(c.scale AS VARCHAR(5)) + ')' " +
            "Else '' End  As tipDBduzDB " +
            "From sys.columns c INNER JOIN sys.tables t On c.object_id = t.object_id " +
            "INNER Join sys.types tp ON tp.user_type_id = c.user_type_id     " +
            "where t.name = N'" + nadtabela + "' and c.name = N'" + pp + "' "
        Dim dt As New DataTable
        dt = izvrsiSQLvratiDT(sss, Me.DBConnectionString, Me.jezik)
        If dt.Rows.Count > 0 Then
            sqlDB = "ALTER TABLE " + tabela + " ADD  " + dt.Rows(0).Item("tipDBduzDB").ToString.Trim + " NOT NULL;"
            sqlDBDropTip = tabela + ";" + dt.Rows(0).Item("tipDBduzDB").ToString.Trim
            DropTip = "ADD"
            dajPPP = sqlDB + "~" + sqlDBDropTip + "~" + DropTip
        End If

    End Function

    Private Sub cboTypeAC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTypeAC.SelectedIndexChanged

        Dim cTip As String = "TextBox"

        Dim cT As String = cboTypeAC.SelectedItem.ToString.Trim
        If cTip = "TextBox" AndAlso (Not cboTypeAC.SelectedItem Is Nothing AndAlso cT <> "") Then
            gbOptionsAC.Visible = True
        Else
            gbOptionsAC.Visible = False
        End If
        txtLenAC.Text = "10"

    End Sub

    Dim sqlIST As String = ""
    Dim sqlTabele As String = ""
    Dim sqlDB As String = ""
    Dim sqlDBDropTip As String = ""
    Dim DropTip As String = ""
    Private Sub btnACOK_Click(sender As Object, e As EventArgs) Handles btnACOK.Click
        Try

            Dim ISTtabela As String = Replace(txtCLAC.Text.Trim, "add column to table:", "", 1, , CompareMethod.Text).Trim

            If ISTtabela = "" Then ISTMessageBox.Show("Select table!") : Exit Sub

            If Not txtNameAC.Text Is Nothing AndAlso txtNameAC.Text = "" Then
                ISTMessageBox.Show("Please, enter control name!")
                Me.txtNameAC.Focus()
                Exit Sub
            End If

            Dim nname As String = Me.txtNameAC.Text.Trim

            Dim poostojiUDB As Boolean = False
            Dim sss As String = "SELECT name FROM sys.columns WHERE Name = N'" + nname + "' AND Object_ID = Object_ID(N'" + ISTtabela + "')"
            Dim dt As New DataTable
            dt = izvrsiSQLvratiDT(sss, Me.DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then poostojiUDB = True

            Dim poostojiUIST As Boolean = False
            Dim sssI As String = "SELECT polje FROM ISTPolja WHERE sifist=N'" + appCode + "' and polje = N'" + nname + "' AND tabela=N'" + ISTtabela + "'"
            Dim dtI As New DataTable
            dtI = izvrsiSQLvratiDT(sssI, Me.ISTConnectionString, Me.jezik)
            If dtI.Rows.Count > 0 Then poostojiUIST = True

            Dim inDB As Boolean = True

            Dim cTip As String = "TextBox"
            inDB = True
            Dim express As String = ""

            If poostojiUDB = True AndAlso inDB = True AndAlso poostojiUIST = True Then
                ISTMessageBox.Show("Name already exists in DB and in IST!")
                Me.txtNameAC.Focus()
                Me.txtNameAC.SelectAll()
                Exit Sub
            End If
            If inDB = False AndAlso poostojiUIST = True Then
                ISTMessageBox.Show("Name already exists in IST!")
                Me.txtNameAC.Focus()
                Me.txtNameAC.SelectAll()
                Exit Sub
            End If

            Dim rbr As Integer = 10

            Dim sqlRbr As String = "SELECT max(rbr) as mrbr FROM ISTPolja WHERE sifist=N'" + appCode + "' AND tabela=N'" + ISTtabela + "'"
            Dim dtRbr As New DataTable
            dtRbr = izvrsiSQLvratiDT(sqlRbr, Me.ISTConnectionString, Me.jezik)

            If dtRbr.Rows.Count > 0 AndAlso Not dtRbr.Rows(0).Item("mrbr") Is System.DBNull.Value Then rbr = CInt(dtRbr.Rows(0).Item("mrbr").ToString.Trim)

            sqlIST = ""
            sqlDB = ""
            sqlTabele = ""
            sqlDBDropTip = ""
            DropTip = ""

            If cbTableAC.Checked = True Then
                If Me.chbRowsStartFrom.Checked = True AndAlso (txtRowsStartFrom.Text = "" OrElse IsNumeric(txtRowsStartFrom.Text.Trim) = False) Then
                    txtRowsStartFrom.Focus()
                    Exit Sub
                End If
                If Me.chbColumnsStartFrom.Checked = True AndAlso (txtColumnsStartFrom.Text = "" OrElse IsNumeric(txtColumnsStartFrom.Text.Trim) = False) Then
                    txtColumnsStartFrom.Focus()
                    Exit Sub
                End If
                Call ttableAC(rbr, nname, express, inDB)
            Else
                Call ssimple(rbr, nname, express, inDB, cTip)
            End If

            Dim pIST As String = "nok"
            Dim pDB As String = "nok"

            Dim errorDB As Boolean = False
            Dim errorIST As Boolean = False

            If poostojiUDB = False AndAlso inDB = True AndAlso poostojiUIST = False Then
                Dim p As String = postaviPK(npk, ISTtabela)
                If p <> "~~" Then
                    Dim pp() As String = p.Split("~")
                    sqlDB = sqlDB + pp(0)
                    sqlDBDropTip = sqlDBDropTip + pp(1) + "#"
                    DropTip = DropTip + pp(2) + "#"
                End If

                pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, sqlTabele, sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If pIST = "nok" Then errorIST = True : ISTMessageBox.Show("Error. Not added in IST!Primary key is not added!")
                If pDB = "nok" Then errorIST = True : ISTMessageBox.Show("Error. Not added in DB!")

            ElseIf (poostojiUDB = True OrElse inDB = False) AndAlso poostojiUIST = False Then
                pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, sqlTabele)
                If pIST = "nok" Then errorIST = True : ISTMessageBox.Show("Error. Not added in IST!")
            ElseIf poostojiUDB = False AndAlso inDB = True AndAlso poostojiUIST = True Then
                pIST = napraviBackUpizvrsiSQLISTTABLES("", "", sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If pDB = "nok" Then errorDB = True : ISTMessageBox.Show("Error. Not added in DB!")
            End If

            sqlIST = ""
            sqlDB = ""
            sqlTabele = ""
            sqlDBDropTip = ""
            DropTip = ""

            If errorDB = False AndAlso errorIST = False Then
                Call rResetPane(Me.paneAC)
                If dgvAppR.DataSource = Nothing Then dgvAppR.Rows.Clear() Else dgvAppR.DataSource = Nothing
                If dgvAppC.DataSource = Nothing Then dgvAppC.Rows.Clear() Else dgvAppC.DataSource = Nothing
                gbOptionsAC.Visible = False
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    'Sub ponistiAC()
    '    txtNameAC.Text = ""
    '    cboTypeAC.SelectedIndex = -1
    '    txtLenAC.Text = ""
    '    cbTableAC.Checked = False
    '    txtNumberAC.Text = ""
    '    txtLabelAC.Text = ""
    '    cbSimpleAC.Checked = False
    '    txtAT1.Text = ""
    '    txtAT2.Text = ""
    '    txtRNAC.Text = ""
    '    txtCNAC.Text = ""
    '    txtTNAC.Text = ""
    'End Sub
    Dim npk As String = ""

    Function postaviPK(ByVal npk As String, ByVal tabela As String) As String
        postaviPK = ""
        Dim sqlDBDropTip As String = ""
        Dim DropTip As String = ""
        Dim sqlDB As String = ""
        sqlDB = "select OBJECT_NAME(OBJECT_ID) AS NameofConstraint" +
        " From sys.objects" +
        " Where OBJECT_NAME(parent_object_id) =N'" + tabela + "'" +
        " And type_desc Like 'PRIMARY_KEY_CONSTRAINT'"

        Dim dt As New DataTable
        dt = izvrsiSQLvratiDT(sqlDB, Me.DBConnectionString, Me.jezik)
        Dim NameofConstraint As String = ""
        If dt.Rows.Count > 0 AndAlso Not dt.Rows(0).Item("NameofConstraint") Is System.DBNull.Value Then NameofConstraint = dt.Rows(0).Item("NameofConstraint").ToString.Trim

        sqlDB = "select Col.Column_Name As pk from INFORMATION_SCHEMA.TABLE_CONSTRAINTS Tab, INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE Col WHERE" +
            " Col.Constraint_Name = Tab.Constraint_Name " +
            " And Col.Table_Name = Tab.Table_Name " +
            " And Constraint_Type = 'PRIMARY KEY' " +
            " AND Col.Table_Name =N'" + tabela + "'"
        Dim dt1 As New DataTable
        dt1 = izvrsiSQLvratiDT(sqlDB, Me.DBConnectionString, Me.jezik)
        Dim nn As String = ""

        For i As Integer = 0 To dt1.Rows.Count - 1
            nn = nn + dt1.Rows(i).Item("pk").ToString.Trim + ","
        Next
        nn = nn.trimend(",")
        nn = nn + npk
        Dim p As String = ""
        If NameofConstraint <> "" Then
            sqlDB = "alter table " + tabela + " DROP CONSTRAINT [" + NameofConstraint + "];" + nvrd    'skida PK
            sqlDBDropTip = tabela + ";" + NameofConstraint + "#"
            DropTip = "DROPCONSTRAINT" + "#"
        End If
        If nn <> "" Then
            sqlDB = sqlDB + " alter table " + tabela + " ADD PRIMARY KEY (" + nn + ");" + nvrd
            sqlDBDropTip = sqlDBDropTip + tabela + ";" + nn + "#"
            DropTip = DropTip + "ADDPK" + "#"
        End If

        postaviPK = sqlDB + "~" + sqlDBDropTip.TrimEnd("#") + "~" + DropTip.TrimEnd("#")

    End Function

    Sub ssimple(ByVal rbr As Integer, ByVal nname As String, ByVal express As String, ByVal inDB As Boolean, ByVal cTip As String)
        Dim nn As String = ""

        npk = ""

        Dim tipDB As String = ""
        Dim tipIST As String = ""
        Dim duzDB As String = ""
        Dim duzIST As String = ""
        Dim ccType As String = ""

        If inDB = True Then
            ccType = cboTypeAC.SelectedItem.ToString.Trim
            If ccType = "Character" Then
                tipDB = "nvarchar"
                tipIST = tipDB
            ElseIf ccType.IndexOf("Integer") = 0 Then
                tipDB = "Integer"
                tipIST = "integer"
                duzDB = ""
            ElseIf ccType.IndexOf("Tiny integer") = 0 Then
                tipDB = "tinyint"
                tipIST = "tinyint"
                duzDB = ""
            ElseIf ccType.IndexOf("Small integer") = 0 Then
                tipDB = "smallint"
                tipIST = "smallint"
                duzDB = ""
            ElseIf ccType.IndexOf("Big integer") = 0 Then
                tipDB = "bigint"
                tipIST = "bigint"
                duzDB = ""
            ElseIf ccType = "Decimal with 2 places" Then
                tipDB = "Decimal(18,2)"
                tipIST = "decimal"
                duzDB = ""
            ElseIf ccType = "Decimal with 5 places" Then
                tipDB = "Decimal(18,5)"
                tipIST = "decimal"
                duzDB = ""
            End If
        Else
            tipDB = ""
            tipIST = ""
            duzDB = ""
            duzIST = ""
        End If

        tipIST = tipDB

        If tipDB = "nvarchar" Then
            If Me.txtLenAC.Text.Trim = "" OrElse IsNumeric(Me.txtLenAC.Text) = False Then Me.txtLenAC.Text = "10"
            duzDB = "(" + Me.txtLenAC.Text.Trim + ")"
        Else
            If IsNumeric(Me.txtLenAC.Text) = False Then Me.txtLenAC.Text = ""
            duzDB = ""
        End If

        duzIST = Me.txtLenAC.Text.Trim

        Dim llabel As String = ""
        If Me.txtLabelAC.Text.Trim = "" Then
            llabel = "$LRIGHTA$Label for " + nname
        Else
            llabel = "$LRIGHTA$" + Me.txtLabelAC.Text
        End If

        Dim nnot As String = "" : Dim pk As String = ""
        If cbPKAC.Checked = True Then nnot = " Not " : pk = "P" : npk = nname  'samo prvi može da bude PK
        If inDB = True Then
            If nname.IndexOf(" ") >= 0 Then nname = "[" + nname + "]"
            sqlDB = sqlDB + "ALTER TABLE " + tabela + " ADD " + nname + " " + tipDB + " " + duzDB + " " + nnot + " NULL;" + nvrd
            sqlDBDropTip = sqlDBDropTip + tabela + ";" + nn + "#"
            DropTip = DropTip + "ADD" + "#"
        End If

        If cTip = "Title" Then
            Dim ttitle1 As String = "Title"
            If Me.txtLabelAC.Text.Trim <> "" Then ttitle1 = txtLabelAC.Text.Trim
            rbr = rbr + 10
            sqlIST = sqlIST + "insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,orderNumber,columnType,columnLenght,ValidFrom,ValidTo,columnAtributes,controlSize,label) VALUES (" +
            "N'" + appCode + "',N'" + tabela + "',N'titleS_" + nname + "','','" + CStr(rbr).Trim + "','','','" + Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
            Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "',N'''''',1,N'$LCENTERA$fontbold$fontsize10$" + ttitle1 + "');" + nvrd

            If sqlTabele.IndexOf("ISTPOLJA;") < 0 Then sqlTabele = sqlTabele + "ISTPOLJA;"
        End If

        If cTip = "TextBox" Then
            rbr = rbr + 10
            sqlIST = sqlIST + "insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,label,orderNumber,columnType,columnLenght,ValidFrom,ValidTo,columnAtributes) VALUES (" +
                    "N'" + appCode + "',N'" + tabela + "',N'" + nname + "','" + pk + "',N'" + llabel.Trim + "','" +
                    CStr(rbr).Trim + "','" + tipIST + "','" + duzIST + "','" + Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                    Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "',N'" + express + "');" + nvrd

            If sqlTabele.IndexOf("ISTPOLJA;") < 0 Then sqlTabele = sqlTabele + "ISTPOLJA;"

            sqlIST = sqlIST + "insert into ISTAwls(sifist,tabela,polje,vod,vdo,idlang,idawl,qmt,ttext,sort) VALUES (" +
                "N'" + appCode + "',N'" + tabela + "',N'" + nname + "','" +
                Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,'Q',N'awl for " + nname + "',1);" + nvrd
            If sqlTabele.IndexOf("ISTAWLS;") < 0 Then sqlTabele = sqlTabele + "ISTAWLS;"

            sqlIST = sqlIST + "insert into ISTQuestionExplanation(sifist,tabela,polje,vod,vdo,idlang,idQuestionExplanation,ttext) VALUES (" +
                "N'" + appCode + "',N'" + tabela + "',N'" + nname + "','" +
                Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,N'Question explanation for " + nname + "');" + nvrd

            If sqlTabele.IndexOf("ISTQUESTIONEXPLANATION;") < 0 Then sqlTabele = sqlTabele + "ISTQUESTIONEXPLANATION;"
        End If

    End Sub

    Function gettNLR(ByVal txt As String) As String
        txt = txt.Replace(";", ",")
        gettNLR = ""
        If txt <> "" Then
            Dim kon As String = ""
            Dim pp() As String = txt.Split(",")
            For i As Integer = 0 To pp.GetUpperBound(0)
                If pp(i) <> "" AndAlso pp(i).IndexOf("-") > 0 Then
                    Dim ip() As String = pp(i).Split("-")
                    If IsNumeric(ip(0).Trim) AndAlso IsNumeric(ip(1).Trim) Then
                        For m As Integer = CInt(ip(0)) To CInt(ip(1))
                            kon = kon + CStr(m).Trim + ","
                        Next
                    End If
                ElseIf pp(i) <> "" AndAlso pp(i).IndexOf("-") <= 0 Then
                    If IsNumeric(pp(i)) Then kon = kon + pp(i) + ","
                ElseIf pp(i) = "" Then
                End If
            Next
            gettNLR = kon.TrimEnd(",")
        End If
        'AndAlso txt.IndexOf("-") > 0
    End Function

    Sub ttableAC(ByVal rbr As Integer, ByVal nname As String, ByVal express As String, ByVal inDB As Boolean)

        npk = ""

        Dim tNLR() As String = {}
        Dim tNLC() As String = {}

        If txtNLR.Text <> "" Then tNLR = gettNLR(txtNLR.Text).Split(",")
        If txtNLC.Text <> "" Then tNLC = gettNLR(txtNLC.Text).Split(",")

        Dim rr As Integer = 0
        Dim cc As Integer = 0
        Dim tt As Integer = 0

        If Me.txtRNAC.Text = "" OrElse IsNumeric(Me.txtRNAC.Text) = False Then
            Me.txtRNAC.Focus()
            Exit Sub
        End If
        If Me.txtCNAC.Text = "" OrElse IsNumeric(Me.txtCNAC.Text) = False Then
            Me.txtCNAC.Focus()
            Exit Sub
        End If
        If Me.txtTNAC.Text = "" OrElse IsNumeric(Me.txtTNAC.Text) = False Then
            Me.txtTNAC.Focus()
            Exit Sub
        End If
        rr = CInt(Me.txtRNAC.Text.Trim)
        cc = CInt(Me.txtCNAC.Text.Trim)
        tt = CInt(Me.txtTNAC.Text.Trim)

        Dim tableLayout As String = ""
        Dim mm As Integer = 0

        'naslov tabele
        If Me.txtAT2.Text <> "" Then
            Dim ttitle2 As String = txtAT2.Text
            rbr = rbr + 10
            Dim ttt As String = "$LCENTERA$fontbold$fontsize10$"

            If c4.SelectedColor.Name = "Chocalate" Then c4.SelectedColor = Color.Chocolate
            If c4.SelectedColor.Name = "Lavander" Then c4.SelectedColor = Color.Lavender
            If c4.SelectedColor.Name = "Transparent" Then c4.SelectedColor = Color.Snow
            If c3.SelectedColor.Name = "Chocalate" Then c3.SelectedColor = Color.Chocolate
            If c3.SelectedColor.Name = "Lavander" Then c3.SelectedColor = Color.Lavender

            If c3.SelectedColor.Name <> "0" Then ttt = ttt + "foreColor" + c3.SelectedColor.Name + "$"
            If c4.SelectedColor.Name <> "0" Then ttt = ttt + "backColor" + c4.SelectedColor.Name + "$"

            sqlIST = sqlIST + "insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,orderNumber,columnType,columnLenght,ValidFrom,ValidTo,columnAtributes,controlSize,label) VALUES (" +
                        "N'" + appCode + "',N'" + tabela + "',N'titleS_" + nname + "','','" + CStr(rbr).Trim + "','','','" + Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                        Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','''''',1,N'" + ttt + ttitle2 + "');" + nvrd

            If sqlTabele.IndexOf("ISTPOLJA;") < 0 Then sqlTabele = sqlTabele + "ISTPOLJA;"
        End If

        Dim nn As String = ""
        Dim nnfp As String = ""
        Dim sufiksName As String = ""
        Dim sufiksNamefp As String = ""

        Dim pravired As Integer = 0
        Dim pravakolona As Integer = 0
        Dim ppravired As Boolean = False
        Dim ppravakolona As Boolean = False

        For r As Integer = 1 To rr
            ppravired = False
            pravakolona = 0
            For c As Integer = 1 To cc
                ppravakolona = False
                If r = 1 AndAlso c = 1 Then mm = 0

                Dim tipDB As String = ""
                Dim tipIST As String = ""
                Dim duzDB As String = ""
                Dim duzIST As String = ""
                Dim ccType As String = ""

                If inDB = True Then
                    ccType = cboTypeAC.SelectedItem.ToString.Trim
                    If ccType = "Character" Then
                        tipDB = "nvarchar"
                        tipIST = tipDB
                    ElseIf ccType = "Integer" Then
                        tipDB = "Integer"
                        tipIST = "Integer"
                        duzDB = ""
                    ElseIf ccType = "Big Integer" Then
                        tipDB = "Bigint"
                        tipIST = "big"
                        duzDB = ""
                    ElseIf ccType = "Decimal With 2 places" Then
                        tipDB = "Decimal(18, 2) Then"
                        tipIST = "Decimal"
                        duzDB = ""
                    ElseIf ccType = "Decimal With 5 places" Then
                        tipDB = "Decimal(18,5)"
                        tipIST = "Decimal"
                        duzDB = ""
                    End If
                Else
                    tipDB = ""
                    tipIST = ""
                    duzDB = ""
                    duzIST = ""
                End If

                tipIST = tipDB

                If tipDB = "nvarchar" Then
                    If Me.txtLenAC.Text.Trim = "" OrElse IsNumeric(Me.txtLenAC.Text) = False Then Me.txtLenAC.Text = "10"
                    duzIST = Me.txtLenAC.Text.Trim
                    duzDB = "(" + Me.txtLenAC.Text.Trim + ")"
                Else
                    duzDB = ""
                End If

                Dim kkolone As String = ""
                Dim indK As Integer = -1
                Dim dRed As Integer = -1
                Dim od As String = ""
                Dim pomod As String = ""
                Dim rredovi As String = ""
                Dim indR As Integer = -1
                Dim pexpress As String = ""

                If cbPFC.Checked = True Then
                    'Format redova                    '
                    For i As Integer = 0 To dgvAppR.Rows.Count - 1
                        If Not dgvAppR.Rows(i).Cells(0).Value Is Nothing AndAlso dgvAppR.Rows(i).Cells(0).Value.ToString.Trim <> "" Then
                            rredovi = gettNLR(dgvAppR.Rows(i).Cells(0).Value.ToString.Trim)
                            Dim arrR() As String = rredovi.Split(",")
                            indR = Array.IndexOf(arrR, CStr(r).Trim)
                        End If
                        If indR > -1 Then dRed = i : Exit For
                    Next
                    If indR > -1 AndAlso dRed > -1 Then
                        If Not dgvAppR.Rows(dRed).Cells(1).Value Is Nothing AndAlso dgvAppR.Rows(dRed).Cells(1).Value.ToString.Trim <> "" Then
                            pexpress = dgvAppR.Rows(dRed).Cells(1).Value.ToString.Trim + "$"
                        End If
                        If Not dgvAppR.Rows(dRed).Cells(2).Value Is Nothing AndAlso dgvAppR.Rows(dRed).Cells(2).Value.ToString.Trim <> "" Then
                            If pomod <> "" Then pomod = pomod + ";"
                            od = "#{" + dgvAppR.Rows(dRed).Cells(2).Value.ToString.Trim + "}"
                        End If
                    End If
                    'Format kolona
                    For i As Integer = 0 To dgvAppC.Rows.Count - 1
                        If Not dgvAppC.Rows(i).Cells(0).Value Is Nothing AndAlso dgvAppC.Rows(i).Cells(0).Value.ToString.Trim <> "" Then
                            kkolone = gettNLR(dgvAppC.Rows(i).Cells(0).Value.ToString.Trim)
                            Dim arrK() As String = kkolone.Split(",")
                            indK = Array.IndexOf(arrK, CStr(c).Trim)
                        End If
                        If indK > -1 Then dRed = i : Exit For
                    Next
                    If indK > -1 AndAlso dRed > -1 Then
                        If Not dgvAppC.Rows(dRed).Cells(1).Value Is Nothing AndAlso dgvAppC.Rows(dRed).Cells(1).Value.ToString.Trim <> "" Then
                            pexpress = dgvAppC.Rows(dRed).Cells(1).Value.ToString.Trim + "$"
                        End If
                        If Not dgvAppC.Rows(dRed).Cells(2).Value Is Nothing AndAlso dgvAppC.Rows(dRed).Cells(2).Value.ToString.Trim <> "" Then
                            od = "#{" + dgvAppC.Rows(dRed).Cells(2).Value.ToString.Trim + "}"
                        End If
                    End If
                Else
                    'Format kolona
                    For i As Integer = 0 To dgvAppC.Rows.Count - 1
                        If Not dgvAppC.Rows(i).Cells(0).Value Is Nothing AndAlso dgvAppC.Rows(i).Cells(0).Value.ToString.Trim <> "" Then
                            kkolone = gettNLR(dgvAppC.Rows(i).Cells(0).Value.ToString.Trim)
                            Dim arrK() As String = kkolone.Split(",")
                            indK = Array.IndexOf(arrK, CStr(c).Trim)
                        End If
                        If indK > -1 Then dRed = i : Exit For
                    Next
                    If indK > -1 AndAlso dRed > -1 Then
                        If Not dgvAppC.Rows(dRed).Cells(1).Value Is Nothing AndAlso dgvAppC.Rows(dRed).Cells(1).Value.ToString.Trim <> "" Then
                            pexpress = dgvAppC.Rows(dRed).Cells(1).Value.ToString.Trim + "$"
                        End If
                        If Not dgvAppC.Rows(dRed).Cells(2).Value Is Nothing AndAlso dgvAppC.Rows(dRed).Cells(2).Value.ToString.Trim <> "" Then
                            od = "#{" + dgvAppC.Rows(dRed).Cells(2).Value.ToString.Trim + "}"
                        End If
                    End If

                    'format redova
                    For i As Integer = 0 To dgvAppR.Rows.Count - 1
                        If Not dgvAppR.Rows(i).Cells(0).Value Is Nothing AndAlso dgvAppR.Rows(i).Cells(0).Value.ToString.Trim <> "" Then
                            rredovi = gettNLR(dgvAppR.Rows(i).Cells(0).Value.ToString.Trim)
                            Dim arrR() As String = rredovi.Split(",")
                            indR = Array.IndexOf(arrR, CStr(r).Trim)
                        End If
                        If indR > -1 Then dRed = i : Exit For
                    Next
                    If indR > -1 AndAlso dRed > -1 Then
                        If Not dgvAppR.Rows(dRed).Cells(1).Value Is Nothing AndAlso dgvAppR.Rows(dRed).Cells(1).Value.ToString.Trim <> "" Then
                            pexpress = dgvAppR.Rows(dRed).Cells(1).Value.ToString.Trim + "$"
                        End If
                        If Not dgvAppR.Rows(dRed).Cells(2).Value Is Nothing AndAlso dgvAppR.Rows(dRed).Cells(2).Value.ToString.Trim <> "" Then
                            If pomod <> "" Then pomod = pomod + ";"
                            od = "#{" + dgvAppR.Rows(dRed).Cells(2).Value.ToString.Trim + "}"
                        End If
                    End If
                End If

                Dim arrColLen() As String = {}
                Dim indColLen As Integer = -1
                If txtColLen.Text.Trim <> "" Then
                    arrColLen = txtColLen.Text.Split(",")
                    indColLen = Array.IndexOf(arrColLen, arrColLen(c - 1))
                End If
                Dim ColLen As String = "100"   'VS
                If indColLen > -1 Then ColLen = arrColLen(indColLen)

                If txtNLR.Text = "0" Then txtNLR.Text = ""
                If txtNLC.Text = "0" Then txtNLC.Text = ""

                If txtRowsStartFrom.Text = "" AndAlso txtColumnsStartFrom.Text = "" Then
                    sufiksName = "_" + CStr(r).Trim + "_" + CStr(c).Trim
                    nn = nname + "_" + CStr(tt).Trim + sufiksName
                    nnfp = "fp_" + nn
                ElseIf txtRowsStartFrom.Text = "" AndAlso txtColumnsStartFrom.Text <> "" Then
                    'ne moze
                    txtRowsStartFrom.Focus()
                    Exit Sub
                End If

                If txtNLR.Text <> "" OrElse txtNLC.Text <> "" Then

                    Dim arrNLR() As String = tNLR    'txtNLR.Text.Split(",")
                    Dim indNLR As Integer = Array.IndexOf(arrNLR, CStr(r).Trim)

                    Dim arrNLC() As String = tNLC ' txtNLC.Text.Split(",")
                    Dim indNLC As Integer = Array.IndexOf(arrNLC, CStr(c).Trim)

                    ''''rbr
                    tableLayout = CStr(tt).Trim + "." + CStr(r).Trim + "." + CStr(c).Trim

                    ''''rbr
                    If cbTabDownLeft.Checked = False Then rbr = rbr + 10
                    If cbTabDownLeft.Checked = True AndAlso (r = 1 AndAlso c = 1) Then rbr = rbr + 10 : mm = rbr
                    If cbTabDownLeft.Checked = True AndAlso Not (r = 1 AndAlso c = 1) Then rbr = mm + rr * (c - 1) * 10 + r * 10 - 10
                    ''''rbr

                    If indNLR > -1 OrElse indNLC > -1 Then
                        'fiktivno polje
                        If txtRowsStartFrom.Text <> "" AndAlso txtColumnsStartFrom.Text = "" Then
                            'moze samo 1 kolona
                            Dim rred As Integer = CInt(txtRowsStartFrom.Text) + (r - 1)
                            sufiksNamefp = CStr(r).Trim
                            nnfp = "fp_" + nname + sufiksNamefp
                        ElseIf txtRowsStartFrom.Text <> "" AndAlso txtColumnsStartFrom.Text <> "" Then
                            Dim rred As Integer = CInt(txtRowsStartFrom.Text) + (r - 1)
                            Dim kkol As Integer = CInt(txtColumnsStartFrom.Text) + (c - 1)
                            sufiksNamefp = CStr(r).Trim + "_" + CStr(kkol).Trim
                            nnfp = "fp_" + nname + sufiksNamefp
                        End If

                        'express = "Text For cell " + nn + ""
                        express = "Text_" + tableLayout + ""

                        sqlIST = sqlIST + " insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,label,orderNumber,columnType,columnLenght,validatingEvent," +
                                          " ValidFrom,ValidTo,columnAtributes,tableLayout,controlSize) VALUES(" +
                                          "N'" + appCode + "',N'" + tabela + "',N'" + nnfp + "','',N'$','" +
                                          CStr(rbr).Trim + "','','','','" + Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                                          Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "',N'" + pexpress + "''" + express + "''','" +
                                          tableLayout + "'," + ColLen + ");" + nvrd

                        If sqlTabele.IndexOf("ISTPOLJA;") < 0 Then sqlTabele = sqlTabele + "ISTPOLJA;"
                    Else
                        'pravo polje
                        If txtRowsStartFrom.Text <> "" AndAlso txtColumnsStartFrom.Text = "" Then
                            ''moze da postoji i samo 1 kolona
                            Dim rred As Integer = CInt(txtRowsStartFrom.Text) + pravired
                            ppravired = True
                            ppravakolona = True
                            sufiksName = CStr(rred).Trim
                            nn = nname + "_" + sufiksName
                        ElseIf txtRowsStartFrom.Text <> "" AndAlso txtColumnsStartFrom.Text <> "" Then
                            Dim rred As Integer = CInt(txtRowsStartFrom.Text) + pravired
                            ppravired = True
                            ppravakolona = True
                            'Dim kkol As Integer = CInt(txtColumnsStartFrom.Text) + (c - 1)
                            Dim kkol As Integer = CInt(txtColumnsStartFrom.Text) + pravakolona
                            sufiksName = CStr(rred).Trim + "_" + CStr(kkol).Trim
                            nn = nname + "_" + sufiksName
                        End If

                        If inDB = True Then
                            If nn.IndexOf(" ") >= 0 Then nn = "[" + nn + "]"
                            sqlDB = sqlDB + "ALTER TABLE " + tabela + " ADD " + nn + " " + tipDB + " " + duzDB + " NULL;" + nvrd
                            sqlDBDropTip = sqlDBDropTip + tabela + ";" + nn + "#"
                            DropTip = DropTip + "ADD" + "#"
                        End If

                        sqlIST = sqlIST + "insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,label,orderNumber,columnType,columnLenght,validatingEvent," +
                        "ValidFrom,ValidTo,columnAtributes,tableLayout,controlSize) VALUES(" +
                        "N'" + appCode + "',N'" + tabela + "',N'" + nn + "','',N'$','" +
                        CStr(rbr).Trim + "','" + tipIST + "','" + duzIST + "','" + od + "','" + Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                        Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "',N'" + pexpress + "','" + tableLayout + "'," + ColLen + ");" + nvrd

                        If sqlTabele.IndexOf("ISTPOLJA;") < 0 Then sqlTabele = sqlTabele + "ISTPOLJA;"

                        If inDB = True Then
                            sqlIST = sqlIST + "insert into ISTAwls(sifist,tabela,polje,vod,vdo,idlang,idawl,qmt,ttext,sort) VALUES (" +
                                                "N'" + appCode + "',N'" + tabela + "',N'" + nn + "','" +
                                                Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                                                Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,'Q',N'awl for " + nn + "',1);" + nvrd

                            If sqlTabele.IndexOf("ISTAWLS;") < 0 Then sqlTabele = sqlTabele + "ISTAWLS;"

                            sqlIST = sqlIST + "insert into ISTQuestionExplanation(sifist,tabela,polje,vod,vdo,idlang,idQuestionExplanation,ttext) VALUES (" +
                                           "N'" + appCode + "',N'" + tabela + "',N'" + nn + "','" +
                                           Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                                           Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,N'Question explanation for " + nn + "');" + nvrd

                            If sqlTabele.IndexOf("ISTQUESTIONEXPLANATION;") < 0 Then sqlTabele = sqlTabele + "ISTQUESTIONEXPLANATION;"


                        End If
                    End If

                End If

                If txtNLR.Text = "" AndAlso txtNLC.Text = "" Then
                    If txtRowsStartFrom.Text <> "" AndAlso txtColumnsStartFrom.Text = "" Then
                        ''moze da postoji i samo 1 kolona
                        Dim rred As Integer = CInt(txtRowsStartFrom.Text) + (r - 1)
                        sufiksName = CStr(rred).Trim
                        nn = nname + sufiksName
                    ElseIf txtRowsStartFrom.Text <> "" AndAlso txtColumnsStartFrom.Text <> "" Then
                        Dim rred As Integer = CInt(txtRowsStartFrom.Text) + (r - 1)
                        Dim kkol As Integer = CInt(txtColumnsStartFrom.Text) + (c - 1)
                        sufiksName = CStr(rred).Trim + "_" + CStr(kkol).Trim
                        nn = nname + sufiksName
                    End If

                    'pravo polje
                    Dim llabel As String = "$"
                    If c = 1 Then
                        If Me.txtLabelAC.Text.Trim = "" Then
                            llabel = "$LRIGHTA$Label for " + nn
                        Else
                            llabel = "$LRIGHTA$" + Me.txtLabelAC.Text + sufiksName
                        End If
                    End If
                    ''''rbr

                    tableLayout = CStr(tt).Trim + "." + CStr(r).Trim + "." + CStr(c).Trim
                    If inDB = True Then
                        If nn.IndexOf(" ") >= 0 Then nn = "[" + nn + "]"
                        sqlDB = sqlDB + "ALTER TABLE " + tabela + " ADD " + nn + " " + tipDB + " " + duzDB + " NULL;" + nvrd
                        sqlDBDropTip = sqlDBDropTip + tabela + ";" + nn + "#"
                        DropTip = DropTip + "ADD" + "#"
                    End If
                    ''''rbr
                    If cbTabDownLeft.Checked = False Then rbr = rbr + 10
                    If cbTabDownLeft.Checked = True AndAlso (r = 1 AndAlso c = 1) Then rbr = rbr + 10 : mm = rbr
                    If cbTabDownLeft.Checked = True AndAlso Not (r = 1 AndAlso c = 1) Then rbr = mm + rr * (c - 1) * 10 + r * 10 - 10
                    ''''rbr
                    sqlIST = sqlIST + "insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,label,orderNumber,columnType,columnLenght,validatingEvent," +
                    "ValidFrom,ValidTo,columnAtributes,tableLayout,controlSize) VALUES(" +
                        "N'" + appCode + "',N'" + tabela + "',N'" + nn + "','',N'" + llabel.Trim + "','" +
                        CStr(rbr).Trim + "','" + tipIST + "','" + duzIST + "',N'" + od + "','" + Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                        Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "',N'" + pexpress + "','" + tableLayout + "'," + ColLen + ");" + nvrd

                    If sqlTabele.IndexOf("ISTPOLJA;") < 0 Then sqlTabele = sqlTabele + "ISTPOLJA;"

                    If inDB = True Then
                        sqlIST = sqlIST + "insert into ISTAwls(sifist,tabela,polje,vod,vdo,idlang,idawl,qmt,ttext,sort) VALUES (" +
                "N'" + appCode + "',N'" + tabela + "',N'" + nn + "','" +
                Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,'Q',N'awl for " + nname + "',1);" + nvrd

                        If sqlTabele.IndexOf("ISTAWLS;") < 0 Then sqlTabele = sqlTabele + "ISTAWLS;"

                        sqlIST = sqlIST + "insert into ISTQuestionExplanation(sifist,tabela,polje,vod,vdo,idlang,idQuestionExplanation,ttext) VALUES (" +
              "N'" + appCode + "',N'" + tabela + "',N'" + nn + "','" +
              Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
              Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,N'Question explanation for " + nname + "');" + nvrd

                        If sqlTabele.IndexOf("ISTQUESTIONEXPLANATION;") < 0 Then sqlTabele = sqlTabele + "ISTQUESTIONEXPLANATION;"
                    End If

                End If

                If ppravakolona = True Then pravakolona = pravakolona + 1
            Next

            If ppravired = True Then pravired = pravired + 1
        Next

    End Sub

    Private Sub cbTableAC_CheckedChanged(sender As Object, e As EventArgs) Handles cbTableAC.CheckedChanged

        Me.PanelAAT.Visible = cbTableAC.Checked

        If cbTableAC.Checked = True Then
            Me.PanelAAT.Visible = True
            Me.txtTotalAC.Text = "0"
            Dim sssI As String = "SELECT max(cast(f1 as int))+1 as ff1 FROM vrepISTPolja WHERE sifist=N'" + appCode + "' AND tabela=N'" + tabela + "'"
            Dim dtI As New DataTable
            dtI = izvrsiSQLvratiDT(sssI, Me.ISTConnectionString, Me.jezik)
            txtTNAC.Text = "1"
            If dtI.Rows.Count > 0 Then txtTNAC.Text = dtI.Rows(0).Item("ff1").ToString.Trim

            Me.txtRNAC.Focus()
        Else
            Call rResetPane(Me.PanelAAT)
        End If

    End Sub

    Sub RCAC()
        Dim dod As Integer = 0
        If cbTableAC.Checked = True Then
            If Me.txtRNAC.Text = "" OrElse IsNumeric(Me.txtRNAC.Text) = False Then txtRNAC.Text = "1"
            If Me.txtCNAC.Text = "" OrElse IsNumeric(Me.txtCNAC.Text) = False Then txtCNAC.Text = "1"
            dod = CInt(txtRNAC.Text.Trim) * CInt(txtCNAC.Text.Trim)
        End If
        Me.txtTotalAC.Text = CStr(dod).Trim
    End Sub

    Private Sub txtRN_TextChanged(sender As Object, e As EventArgs) Handles txtRNAC.TextChanged
        Call RCAC()
    End Sub

    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCNAC.TextChanged
        Call RCAC()
    End Sub

    Private Sub txtTNAC_TextChanged(sender As Object, e As EventArgs) Handles txtTNAC.TextChanged
        If Me.txtTNAC.Text = "" OrElse IsNumeric(Me.txtTNAC.Text) = False Then txtTNAC.Text = "1"
    End Sub

    '*********************************
    '_ISTTablesColumns
    '*********************************
    Private Sub cboRelDB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRelDB.SelectedIndexChanged
        If Not cboRelDB.SelectedValue Is Nothing AndAlso cboRelDB.SelectedValue.ToString <> "" Then
            Dim strSQl As String = "Use " + cboRelDB.SelectedValue.ToString + " SELECT TABLE_NAME as displaymember,TABLE_NAME as valuemember FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'  order by 1"
            Dim strsql2 As String = "select distinct connectionDoc  from ist.dbo.vBazaServerEng where rdatabase=N'" + cboRelDB.SelectedValue.ToString + "'"
            Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(strsql2, Me.ISTConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                strsql2 = dt.Rows(0).Item(0).ToString + ";Integrated Security=SSPI;Persist Security Info=False" + ""
                Call popunicbo(CboRelTable, strSQl, strsql2)
            End If
        End If
    End Sub

    Private Sub cboRelTable_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strSQl As String = "Use " + cboRelDB.SelectedValue.ToString + " SELECT TABLE_NAME as displaymember,TABLE_NAME as valuemember FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'  order by 1"
        Dim strsql2 As String = "select distinct connectionDoc  from ist.dbo.vBazaServerEng where rdatabase=N'" + cboRelDB.SelectedValue.ToString + "'"

        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(strsql2, Me.ISTConnectionString, Me.jezik)
        If dt.Rows.Count > 0 Then
            strsql2 = dt.Rows(0).Item(0).ToString + ";Integrated Security=SSPI;Persist Security Info=False" + ""
            Call popunicbo(CboRelTable, strSQl, strsql2)
        End If
    End Sub

    Private Sub cboRelTable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboRelTable.SelectedIndexChanged
        Dim strSQl As String = "SELECT COLUMN_NAME as displaymember,COLUMN_NAME as valuemember FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + CboRelTable.SelectedValue.ToString + "' order by 1"
        Dim strsql2 As String = "select distinct connectionDoc  from ist.dbo.vBazaServerEng where rdatabase=N'" + cboRelDB.SelectedValue.ToString + "'"

        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(strsql2, Me.ISTConnectionString, Me.jezik)
        If dt.Rows.Count > 0 Then
            strsql2 = dt.Rows(0).Item(0).ToString + ";Integrated Security=SSPI;Persist Security Info=False" + ""
            Call popunicbo(CboRelCol, strSQl, strsql2)
        End If
    End Sub

    Private Sub cboGS_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strSQl As String = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" + cboIST.SelectedValue.ToString + "' and isnull(typeOfTableParentChild,'') not in ('K','S','A') order by 1"
        Call popunicbo(cboGS, strSQl, Me.ISTConnectionString)
    End Sub

    Private Sub chbFSize_CheckedChanged(sender As Object, e As EventArgs) Handles chbFSize.CheckedChanged
        tbFSize.Visible = chbFSize.Checked
        If chbFSize.Checked = True Then tbFSize.Value = tbFSize.Tag
    End Sub

    Private Sub chbForeColor_CheckedChanged(sender As Object, e As EventArgs) Handles chbForeColor.CheckedChanged
        Mkc_ColorCombobox1.Visible = chbForeColor.Checked
        If chbForeColor.Checked = False Then
            Mkc_ColorCombobox1.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_ColorCombobox1.Focus()
        End If
    End Sub

    Private Sub chbBackColor_CheckedChanged(sender As Object, e As EventArgs) Handles chbBackColor.CheckedChanged
        Mkc_ColorCombobox2.Visible = chbBackColor.Checked
        If chbBackColor.Checked = False Then
            Mkc_ColorCombobox2.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_ColorCombobox2.Focus()
        End If
    End Sub

    Private Sub cbACB_CheckedChanged(sender As Object, e As EventArgs)
        Me.gbAC.Visible = cbAC.Checked
        If Me.gbAC.Visible = True Then
            Me.gbAC.Focus()
        End If
    End Sub


    Private Sub cbfCWO_CheckedChanged(sender As Object, e As EventArgs)
        Me.lDS.Visible = cbCWO.Checked
        Me.txtfDS.Visible = cbCWO.Checked
        Me.lDM.Visible = cbCWO.Checked
        Me.txtfDM.Visible = cbCWO.Checked
        Me.lVM.Visible = cbCWO.Checked
        Me.txtfVM.Visible = cbCWO.Checked
        Me.lF.Visible = cbCWO.Checked
        Me.txtfF.Visible = cbCWO.Checked
        Me.txtfDS.Focus()
    End Sub


    Private Sub chbMultilineH_CheckedChanged(sender As Object, e As EventArgs) Handles chbMultilineH.CheckedChanged
        Me.txtMultilineH.Visible = chbMultilineH.Checked
        If chbMultilineH.Checked = False Then
            Me.txtMultilineH.Text = ""
        Else
            Me.txtMultilineH.Focus()
        End If

    End Sub

    Private Sub chbTabIndex_CheckedChanged(sender As Object, e As EventArgs) Handles chbTabIndex.CheckedChanged
        Me.txtON.Visible = chbTabIndex.Checked
        If chbTabIndex.Checked = False Then
            Me.txtON.Text = ""
        Else
            Me.txtON.Focus()
        End If
    End Sub

    Private Sub chbFC_CheckedChanged(sender As Object, e As EventArgs) Handles chbFC.CheckedChanged, cbNoteFC.CheckedChanged
        Me.Mkc_ColorComboboxFC.Visible = chbFC.Checked
        If chbFC.Checked = False Then
            Mkc_ColorComboboxFC.SelectedColor = System.Drawing.Color.Empty
        Else
            Me.Mkc_ColorComboboxFC.Focus()
        End If

    End Sub

    Private Sub chbBC_CheckedChanged(sender As Object, e As EventArgs) Handles chbBC.CheckedChanged
        Me.Mkc_ColorComboboxBC.Visible = chbBC.Checked
        If chbBC.Checked = False Then
            Mkc_ColorComboboxBC.SelectedColor = System.Drawing.Color.Empty
        Else
            Me.Mkc_ColorComboboxBC.Focus()
        End If
    End Sub

    Private Sub llACB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llACB.LinkClicked


        Dim openFileDialog1 As New OpenFileDialog()
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            txtACB.Text = openFileDialog1.SafeFileName
            'ISTMessageBox.Show(openFileDialog1.FileName, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub chbGridOpen_CheckedChanged(sender As Object, e As EventArgs)
        cboGOpen.Visible = chbGridOpen.Checked
        If chbGridOpen.Checked = True Then
            Dim strSQl As String = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" + cboIST.SelectedValue.ToString + "' and isnull(typeOfTableParentChild,'')='D' and parenttableName=N'" +
                tv.SelectedNode.Parent.Text.ToString + "'" +
                " order by 1"
            Call popunicbo(cboGOpen, strSQl, Me.ISTConnectionString)
        End If
    End Sub

    Dim primaryKey As String = ""
    Dim relationalDatabase As String = ""
    Dim relationalTable As String = ""
    Dim relationaColumn As String = ""
    Dim controlSize As String = ""
    Dim validatingEvent As String = ""

    Dim enterEvent As String = ""
    Dim defaultValue As String = ""
    Dim label As String = ""
    Dim orderNumber As String = ""

    Dim columnType As String = ""
    Dim columnLenght As String = ""
    Dim tableLayout As String = ""

    'Dim ValidFrom As String = ""
    'Dim ValidTo As String = ""
    Dim columnAtributes As String = ""

    Dim ffield As String = ""

    'Dim ttable As String
    Dim vvodC As String

    Sub dajC(ByVal eNode As TreeNode)
        Me.Cursor = Cursors.WaitCursor
        Call rResetC()
        If eNode.Tag = "" Then Me.TableLayoutPanelCOLUMN.Visible = False
        If eNode.Tag <> "" Then

            Dim tt As String = eNode.Tag.split("$")(0).substring(2)
            vvodC = eNode.Tag.split("$")(1)

            Me.TableLayoutPanelCOLUMN.Visible = True
            Me.txtL0.Text = "Column :" + tt + "    in _ISTTablesColumns of IST metadata"
            ttable = tt.Split(".")(0)
            ffield = tt.Split(".")(1)

            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)

                cbSVF.Checked = False

                Try
                    getMetaDataPaneP0()
                    getMetaDataPaneP1()
                    getMetaDataPaneP2()
                    getMetaDataPaneP21()
                    getMetaDataPaneP3()

                    ''getMetaDataPaneT6()
                    ''getMetaDataPaneT7()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try

                Dim ss As String = "select distinct connectionDoc  from ist.dbo.vBazaServerEng where appcode=N'" + Me.cboIST.SelectedValue.ToString.Trim + "'"
                Dim dd As System.Data.DataTable = izvrsiSQLvratiDT(ss, Me.ISTConnectionString, Me.jezik)
                If dd.Rows.Count > 0 Then
                    ss = dd.Rows(0).Item(0).ToString + ";Integrated Security=SSPI;Persist Security Info=False" + ""
                End If
                Dim strSQL As String = "select name as displaymember,name as valuemember from dbo.sysobjects where (type = 'P') and name not like 'dt_%' order by 1"

            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Sub rResetC()
        For Each pp As Panel In Me.TableLayoutPanelCOLUMN.Controls
            If TypeOf pp Is Panel Then
                For Each k As Control In DirectCast(pp, Panel).Controls
                    If TypeOf k Is Panel Then Call rResetPane(k)
                    If TypeOf k Is CheckBox Then DirectCast(k, CheckBox).Checked = False
                    If TypeOf k Is ComboBox Then DirectCast(k, ComboBox).Text = ""
                    If TypeOf k Is TextBox AndAlso DirectCast(k, TextBox).Tag <> "VP" Then DirectCast(k, TextBox).Text = ""
                    If TypeOf k Is DateTimePicker2 Then DirectCast(k, DateTimePicker2).Text = ""
                    If TypeOf k Is RadioButton Then DirectCast(k, RadioButton).Checked = False
                    If TypeOf k Is mkc_ColorCombobox.mkc_ColorCombobox Then
                        DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).SelectedColor = System.Drawing.Color.Empty
                        If DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).Tag = "VF" Then DirectCast(k, mkc_ColorCombobox.mkc_ColorCombobox).Visible = False
                    End If
                    If TypeOf k Is DataGridView AndAlso Not DirectCast(k, DataGridView).DataSource Is Nothing Then
                        DirectCast(k, DataGridView).DataSource = Nothing
                    End If
                    If TypeOf k Is CheckedListBox AndAlso Not DirectCast(k, CheckedListBox).DataSource Is Nothing Then
                        For i As Integer = 0 To DirectCast(k, CheckedListBox).Items.Count - 1
                            DirectCast(k, CheckedListBox).SetItemChecked(i, False)
                        Next
                    End If
                    If TypeOf k Is TrackBar Then
                        DirectCast(k, TrackBar).Value = DirectCast(k, TrackBar).Tag
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub lb_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim lb As ListBox = DirectCast(sender, ListBox)
        If lb.Items.Count = 0 Then Return
        Dim index As Integer = lb.IndexFromPoint(e.X, e.Y)
        Dim s As String = lb.Items(index).row(0).ToString()
        lb.DoDragDrop(s, DragDropEffects.Copy)
    End Sub

    Sub fillLB(ByVal lb As ListBox, ByVal str As String, ByVal kkon As String)
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
        lb.DataSource = dtKon
        lb.DisplayMember = "displaymember"
        lb.ValueMember = "valuemember"
        Dim dv As New System.Data.DataView(dtKon)
        lb.DataSource = dv
    End Sub

    Function getDTC() As System.Data.DataTable
        primaryKey = "" : relationalDatabase = "" : relationalTable = "" : relationaColumn = "" : controlSize = "" : validatingEvent = ""
        enterEvent = "" : defaultValue = "" : label = "" : orderNumber = "" : columnType = "" : columnLenght = "" : tableLayout = "" : ValidFrom = ""
        ValidTo = "" : columnAtributes = ""

        Dim strSQl As String = "select appCode, tableName, columnName, primaryKey, relationalDatabase, relationalTable, relationaColumn, controlSize, validatingEvent, enterEvent, defaultValue," +
                "label,orderNumber,columnType,columnLenght,tableLayout,ValidFrom," +
                "ValidTo,columnAtributes from _ISTTablesColumns " +
                "where appcode=N'" + Me.cboIST.SelectedValue.ToString.Trim + "' and tableName=N'" + ttable + "' and columnName=N'" + ffield + "'" +
                " and cast (validFrom as date)='" + Convert.ToDateTime(vvodC).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Me.jezik)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        primaryKey = dt.Rows(0).Item("primaryKey").ToString.Trim
        relationalDatabase = dt.Rows(0).Item("relationalDatabase").ToString.Trim
        relationalTable = dt.Rows(0).Item("relationalTable").ToString.Trim
        relationaColumn = dt.Rows(0).Item("relationaColumn").ToString.Trim
        controlSize = dt.Rows(0).Item("controlSize").ToString.Trim
        validatingEvent = dt.Rows(0).Item("validatingEvent").ToString.Trim
        enterEvent = dt.Rows(0).Item("enterEvent").ToString.Trim
        defaultValue = dt.Rows(0).Item("defaultValue").ToString.Trim
        label = dt.Rows(0).Item("label").ToString.Trim
        orderNumber = dt.Rows(0).Item("orderNumber").ToString.Trim
        columnType = dt.Rows(0).Item("columnType").ToString.Trim
        columnLenght = dt.Rows(0).Item("columnLenght").ToString.Trim
        tableLayout = dt.Rows(0).Item("tableLayout").ToString.Trim
        ValidFrom = CDate(dt.Rows(0).Item("VALIDFROM")).ToString("yyyy/MM/dd")
        ValidTo = CDate(dt.Rows(0).Item("VALIDTO")).ToString("yyyy/MM/dd")
        columnAtributes = dt.Rows(0).Item("columnAtributes").ToString.Trim

    End Sub

    Sub getMetaDataPaneP0()

        If primaryKey = "P" Then chbPK.Checked = True

        Me.txtVS.Text = controlSize
        Me.txtDV.Text = defaultValue
        Me.txtON.Text = orderNumber
        Me.txtType.Text = columnType
        Me.txtLenght.Text = columnLenght

        If Not tableLayout Is Nothing AndAlso tableLayout.IndexOf(".") > 0 Then
            Dim nn() As String = tableLayout.Trim.Split(".")
            For i As Integer = 0 To nn.GetUpperBound(0)
                Me.txtSPOrderTable.Text = nn(0)
                Me.txtSPOrderRow.Text = nn(1)
                Me.txtSPOrderColumn.Text = nn(2)
            Next
        End If

        'Me.txtSPOrderTable.Text = tableLayout

        Me.txtvod.Text = ValidFrom
        Me.txtvdo.Text = ValidTo   '28.01.9989

        Dim strSQl As String = "SELECT name as displaymember,name as valuemember FROM master.sys.databases order by 1"
        Call popunicbo(cboRelDB, strSQl, Me.ISTConnectionString)

        Me.cboRelDB.SelectedValue = relationalDatabase
        Me.CboRelTable.SelectedValue = relationalTable
        Me.CboRelCol.SelectedValue = relationaColumn

        If enterEvent = "" Then Exit Sub
        enterEvent = enterEvent.Replace(vbCrLf, "").Replace("#{", "").Trim
        If enterEvent.Substring(enterEvent.Length - 1, 1) = "}" Then enterEvent = enterEvent.Substring(0, enterEvent.Length - 1)

        Dim pp() = enterEvent.Split("$")

        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Length > 7 AndAlso pp(i).Trim.tolower.IndexOf("datavalidationfor") >= 0 Then chbFilterLK.Checked = True
        Next
    End Sub

    Sub setMetaDataPaneP0()

        If chbPK.Checked = True Then primaryKey = "P"
        ''controlSize = Me.txtVS.Text.Trim
        defaultValue = Me.txtDV.Text.Trim
        'orderNumber = Me.txtON.Text.Trim
        columnType = Me.txtType.Text.Trim
        columnLenght = Me.txtLenght.Text.Trim
        'tableLayout = Me.txtSPOrderTable.Text.Trim
        ValidFrom = Me.txtvod.Text
        ValidTo = Me.txtvdo.Text

        relationalDatabase = Me.cboRelDB.SelectedValue
        relationalTable = Me.CboRelTable.SelectedValue
        relationaColumn = Me.CboRelCol.SelectedValue

        If chbFilterLK.Checked = True Then
            columnAtributes = columnAtributes + "$" + "datavalidationfor$"
        End If


    End Sub

    Function setMetaDataPaneP10() As String
        Dim pom As String = ""
        If chbFilterLK.Checked = True Then pom = "datavalidationfor$"
        Return pom
    End Function

    Sub getMetaDataPaneP1()

        'izraz i do autocomplete
        Dim multilineheight As String = ""
        Dim forecolor As String = ""
        Dim backcolor As String = ""

        If columnAtributes.Trim = "" Then
            cbTB.Checked = True
            Exit Sub
        End If

        Dim ffp As Boolean = False
        Dim ccbo As Boolean = False
        Dim rcb As Boolean = False
        Dim cch As Boolean = False
        Dim ddtp As Boolean = False
        Dim lll As Boolean = False
        Dim bbutton As Boolean = False
        Dim ddgv As Boolean = False
        Dim sselect As Boolean = False

        Dim nn() As String = columnAtributes.Split("$")
        Dim pom As String = "" : Dim pom1 As String = ""
        For i As Integer = 0 To nn.GetUpperBound(0)
            If nn(i).Trim.ToLower.IndexOf("multiline") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("fontbold") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("readonly") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("fontitalic") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("fontunderline") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("visiblefalse") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("enablefalse") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("frighta") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("pdesnop") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("pcentarp") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("fcentera") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("fcentera") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("borderfixed") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("bordernone") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("multiline") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("height") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("backcolor") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("forecolor") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("datavalidationfor") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("webstr") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("endofwebstr") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("divDisplayNone") = 0 Then
            ElseIf nn(i).Trim.ToLower.IndexOf("endofdivDisplayNone") = 0 Then
            ElseIf nn(i).Trim = "" Then
            Else
                pom = pom + nn(i) + ";"
                pom1 = pom1 + nn(i) + "$"
            End If
        Next
        pom = pom + ";" : pom = pom.Replace(";;", "")
        pom1 = pom1 + "$" : pom1 = pom1.Replace("$$", "")

        Dim ccolumnAtributes As String = pom
        Dim ocolumnAtributes As String = pom1

        Dim CheckBox As String = ""
        'Dim radiobuttonvo() As String = {}
        'Dim radiobuttonv() As String = {}
        Dim radiobuttonvo As String = ""
        Dim radiobuttonv As String = ""
        Dim combo As String = ""
        Dim comboweb As String = ""
        Dim rowheader As String = ""
        Dim gridlinkstopif() As String = {}
        Dim gridlinkstopifmsg() As String = {}
        Dim gridaddcolumn() As String = {}
        'Dim gridaddcolumnname() As String = {}
        Dim gridcolumns() As String = {}
        Dim gridwidth() As String = {}

        Dim gridlinkaction() As String = {}
        Dim gridlinktext() As String = {}
        Dim gridlinkwidth() As String = {}

        ccolumnAtributes = Replace(ccolumnAtributes, "multiline", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fontbold", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "readonly", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fontitalic", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fontunderline", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "visiblefalse", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "enablefalse", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "frighta", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fcentera", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fcentrea", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "pcentarp", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "pdesnop", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fcentera", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "borderfixed", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "bordernone", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "webstr", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "endofwebstr", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "divDisplayNone", "", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "endofdivDisplayNone", "", 1, , CompareMethod.Text)

        dgvRB.DataSource = Nothing
        If ccolumnAtributes Is Nothing Then ccolumnAtributes = ""
        Dim pp() As String = ccolumnAtributes.Split(";")

        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Trim = "" Then
                'nista
                cbTB.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("LINKLABEL") = 0 Then
                cbLL.Checked = True
                lll = True
            ElseIf pp(i).Length > 13 AndAlso pp(i).Trim.ToUpper.IndexOf("DATETIMEPICKER") = 0 Then
                cbDTP.Checked = True
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTON") = 0 Then
                cbB.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("CHECKBOXL") = 0 Then
                Dim cb As String = pp(i).Trim.ToUpper.Replace("CHECKBOXL", "")
                txtCBGroup.Text = cb
                cbLCHB.Checked = True
                CheckBox = getttt(pp(i), "CHECKBOXL")
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("CHECKBOXR") = 0 Then
                Dim cb As String = pp(i).Trim.ToUpper.Replace("CHECKBOXR", "")
                txtCBGroup.Text = cb
                cbRCHB.Checked = True
                CheckBox = getttt(pp(i), "CHECKBOXR")
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("CHECKBOX") = 0 Then
                Dim cb As String = pp(i).Trim.ToUpper.Replace("CHECKBOX", "")
                txtCBGroup.Text = cb
                cbCHB.Checked = True
                CheckBox = getttt(pp(i), "CHECKBOX")
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("RADIOBUTTONV") >= 0 OrElse pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("RADIOBUTTONH") >= 0 Then
                'Dim rb = pp(i).Trim.ToUpper
                If pp(i).Trim.ToUpper.IndexOf("RADIOBUTTONV") >= 0 Then
                    cbVRB.Checked = True
                    Dim rbb() As String = pp(i).Trim.ToUpper.Replace("RADIOBUTTONV{", "").Replace("}", "").Split(",")
                    For j As Integer = 0 To rbb.GetUpperBound(0)
                        radiobuttonvo = rbb(j).Split("'")(0)
                        radiobuttonv = rbb(j).Split("'")(1)
                        dgvRB.Rows.Add(New String() {radiobuttonvo, radiobuttonv})
                    Next
                ElseIf pp(i).Trim.ToUpper.IndexOf("RADIOBUTTONH") >= 0 Then
                    cbHRB.Checked = True
                    Dim rbb() As String = pp(i).Trim.ToUpper.Replace("RADIOBUTTONH{", "").Replace("}", "").Split(",")
                    For j As Integer = 0 To rbb.GetUpperBound(0)
                        radiobuttonvo = rbb(j).Split("'")(0)
                        radiobuttonv = rbb(j).Split("'")(1)
                        dgvRB.Rows.Add(New String() {radiobuttonvo, radiobuttonv})
                    Next
                End If
            ElseIf pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("CBO") = 0 Then
                Dim cb As String = pp(i).Trim.ToUpper.Replace("CBO{", "")
                If cb.Substring(cb.Length - 1, 1) = "}" Then cb = cb.Substring(0, cb.Length - 1)
                If cb.Length > 4 AndAlso cb.Trim.ToUpper.IndexOf("IZVOR") = 0 OrElse cb.Length > 9 AndAlso cb.Trim.ToUpper.IndexOf("DATASOURCE") = 0 Then

                    Dim ds As String = cb.Trim.ToUpper.Replace("DATASOURCE=", "").Replace("IZVOR=", "")
                    txtfDS.Text = ds
                End If
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DISPLAYMEMBER") = 0 OrElse pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("PRIKAZI") = 0 Then
                Dim dm As String = pp(i).Trim.ToUpper.Replace("DISPLAYMEMBER=", "").Replace("PRIKAZI=", "")
                txtfDM.Text = dm
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("VALUEMEMBER") = 0 OrElse pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("UBAZU") = 0 Then
                Dim vm As String = pp(i).Trim.ToUpper.Replace("VALUEMEMBER=", "").Replace("UBAZU=", "")
                txtfVM.Text = vm
                cbCB.Checked = True
                gbCBO.Visible = True
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("FILTER") = 0 Then
                Dim ff As String = pp(i).Trim.ToUpper.Replace("FILTER=", "")
                txtfF.Text = ff
                cbCB.Checked = True
                gbCBO.Visible = True
                combo = getttt(pp(i), "CBO")
            ElseIf pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("CBW") = 0 Then
                cbCB.Checked = True
                cbCWO.Checked = True
                gbCBO.Visible = True
                Dim cb As String = pp(i).Trim.ToUpper.Replace("CBW{", "")
                If cb.Substring(cb.Length - 1, 1) = "}" Then cb = cb.Substring(0, cb.Length - 1)
                If cb.Length > 4 AndAlso cb.Trim.ToUpper.IndexOf("IZVOR") = 0 OrElse cb.Length > 9 AndAlso cb.Trim.ToUpper.IndexOf("DATASOURCE") = 0 Then

                    Dim ds As String = cb.Trim.ToUpper.Replace("DATASOURCE=", "").Replace("IZVOR=", "")
                    txtfDS.Text = ds
                End If
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DISPLAYMEMBER") = 0 OrElse pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("PRIKAZI") = 0 Then
                Dim dm As String = pp(i).Trim.ToUpper.Replace("DISPLAYMEMBER=", "").Replace("PRIKAZI=", "")
                txtfDM.Text = dm
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("VALUEMEMBER") = 0 OrElse pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("UBAZU") = 0 Then
                Dim vm As String = pp(i).Trim.ToUpper.Replace("VALUEMEMBER=", "").Replace("UBAZU=", "")
                txtfVM.Text = vm

            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("FILTER=") = 0 Then
                Dim ff As String = pp(i).Trim.ToUpper.Replace("FILTER=", "")
                txtfF.Text = ff
                combo = getttt(pp(i), "CBW")

            ElseIf pp(i).Length >= 0 AndAlso pp(i).Trim.IndexOf("'") = 0 Then
                Dim virf As String = pp(i).Trim.ToUpper
                txtExpression.Visible = True
                txtExpression.Text = virf
                cbFP.Checked = True
                ffp = True
            End If
        Next

        If ccolumnAtributes.Trim.IndexOf("#{") >= 0 Then
            sselect = True
            ffp = True
            ccolumnAtributes = ccolumnAtributes.Replace(vbCrLf, "").Replace("#{", "").Trim
            'If ccolumnAtributes.Substring(ccolumnAtributes.Length - 1, 1) = "}" Then ccolumnAtributes = ccolumnAtributes.Substring(0, ccolumnAtributes.Length - 1)
            ccolumnAtributes = ccolumnAtributes.TrimEnd("}")
            cbFP.Checked = True
        End If

        If ccolumnAtributes.Trim.ToUpper.IndexOf("DATAGRIDVIEW") >= 0 Then
            cbDGV.Checked = True
            'ccolumnAtributes = ccolumnAtributes.Replace(vbCrLf, "").Replace("#{", "").Trim
            '    If ccolumnAtributes.Substring(ccolumnAtributes.Length - 1, 1) = "}" Then ccolumnAtributes = ccolumnAtributes.Substring(0, ccolumnAtributes.Length - 1)
            ocolumnAtributes = columnAtributes
            Dim dgpp() As String = ocolumnAtributes.Split(";")
            For i As Integer = 0 To dgpp.GetUpperBound(0)
                If dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDSOURCE") = 0 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDSOURCEWHERE") < 0 Then
                    Dim gs As String = Replace(dgpp(i).Trim, "gridsource=", "", 1, , CompareMethod.Text).Trim
                    Dim strSQl As String = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" + cboIST.SelectedValue.ToString + "' and isnull(typeOfTableParentChild,'') not in ('K','S','A') order by 1"
                    Call popunicbo(cboGS, strSQl, Me.ISTConnectionString)
                    cboGS.Visible = True
                    cboGS.SelectedValue = gs
                ElseIf dgpp(i).Length > 14 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDSOURCEWHERE") = 0 Then
                    Dim gsw As String = Replace(dgpp(i).Trim, "gridsourcewhere=", "", 1, , CompareMethod.Text).Trim
                    txtGSW.Visible = True
                    txtGSW.Text = gsw
                ElseIf dgpp(i).Length > 8 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDTITLE") = 0 Then
                    Dim gt As String = Replace(dgpp(i).Trim, "gridtitle=", "", 1, , CompareMethod.Text).Trim
                    txtGTitle.Visible = True
                    txtGTitle.Text = gt
                ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDHEIGHT") = 0 Then
                    Dim gh As String = Replace(dgpp(i).Trim, "gridheight=", "", 1, , CompareMethod.Text).Trim
                    txtGHeight.Visible = True
                    txtGHeight.Text = gh
                ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDWIDTH") = 0 Then
                    Dim gw As String = Replace(dgpp(i).Trim, "gridwidth=", "", 1, , CompareMethod.Text).Trim
                    txtGWidth.Visible = True
                    txtGWidth.Text = gw
                ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDFONTSIZE") = 0 Then
                    Dim gfs As String = Replace(dgpp(i).Trim, "gridfontsize=", "", 1, , CompareMethod.Text).Trim
                    txtGFS.Visible = True
                    txtGFS.Text = gfs
                ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLOCATION") = 0 Then
                    Dim gl As String = Replace(dgpp(i).Trim, "gridlocation", "", 1, , CompareMethod.Text).Trim
                    Dim gll As String = gl.Replace("(", "").Replace(")", "")
                    Dim dgl() As String = gll.Split(",")
                    Dim xx As String = ""
                    Dim yy As String = ""
                    If dgl.Length > 1 Then
                        Dim xloc() As String = dgl(0).Split("=")
                        Dim yloc() As String = dgl(1).Split("=")
                        xx = xloc(1)
                        yy = yloc(1)
                    End If
                    txtGLocationX.Visible = True
                    txtGLocationY.Visible = True
                    txtGLocationX.Text = xx
                    txtGLocationY.Text = yy
                ElseIf dgpp(i).Length > 13 AndAlso dgpp(i).Trim.ToUpper.IndexOf("ROWHEADERSWIDTH") = 0 Then
                    Dim rhw As String = Replace(dgpp(i).Trim, "rowheaderswidth=", "", 1, , CompareMethod.Text).Trim
                    txtGRHW.Visible = True
                    txtGRHW.Text = rhw
                ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDHEADERROWFONTSIZE") = 0 Then
                    Dim hfs As String = Replace(dgpp(i).Trim, "gridheaderrowfontsize=", "", 1, , CompareMethod.Text).Trim
                    txtGHRFS.Visible = True
                    txtGHRFS.Text = hfs
                ElseIf dgpp(i).Length > 17 AndAlso dgpp(i).Trim.ToUpper.IndexOf("COLUMNHEADERSHEIGHT") = 0 Then
                    Dim chh As String = Replace(dgpp(i).Trim, "columnheadersheight=", "", 1, , CompareMethod.Text).Trim
                    txtGColHHght.Visible = True
                    txtGColHHght.Text = chh
                ElseIf dgpp(i).Length > 11 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKACTION") = 0 Then
                    gridlinkaction = Replace(dgpp(i).Trim, "gridlinkaction=", "", 1, , CompareMethod.Text).Trim.Split("$")
                ElseIf dgpp(i).Length > 11 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKTEXT") = 0 Then
                    gridlinktext = Replace(dgpp(i).Trim, "gridlinktext=", "", 1, , CompareMethod.Text).Trim.Split("$")
                ElseIf dgpp(i).Length > 11 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKWIDTH") = 0 Then
                    gridlinkwidth = Replace(dgpp(i).Trim, "gridlinkwidth=", "", 1, , CompareMethod.Text).Trim.Split("$")
                ElseIf dgpp(i).Length > 13 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKSTOPIF") >= 0 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKSTOPIFMSG") < 0 Then
                    gridlinkstopif = Replace(dgpp(i).Trim, "gridlinkstopif=", "", 1, , CompareMethod.Text).Trim.Split("$")
                ElseIf dgpp(i).Length > 15 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKSTOPIFMSG") >= 0 Then
                    gridlinkstopifmsg = Replace(dgpp(i).Trim, "gridlinkstopifmsg=", "", 1, , CompareMethod.Text).Trim.Split("$")
                    cbDGV.Checked = True
                ElseIf dgpp(i).Length > 10 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDCOLUMNS") >= 0 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDCOLUMNSWIDTH") < 0 Then
                    gridcolumns = Replace(dgpp(i).Trim, "gridcolumns=", "", 1, , CompareMethod.Text).Trim.Split(",")
                    cbDGV.Checked = True
                ElseIf dgpp(i).Length > 12 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDADDCOLUMN") >= 0 Then
                    gridaddcolumn = Replace(dgpp(i).Trim, "gridaddcolumn=", "", 1, , CompareMethod.Text).Trim.Split(",")
                ElseIf dgpp(i).Length > 15 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDCOLUMNSWIDTH") >= 0 Then
                    gridwidth = Replace(dgpp(i).Trim, "gridcolumnswidth=", "", 1, , CompareMethod.Text).Trim.Split(",")
                End If
            Next

            If Not gridlinkaction Is Nothing AndAlso gridlinkaction.Length > 0 Then
                For j As Integer = 0 To gridlinkaction.GetUpperBound(0)
                    Dim gla As String = gridlinkaction(j).Trim.ToUpper
                    If gla.Length > 3 AndAlso gla.ToUpper.IndexOf("EDIT") >= 0 Then
                        Dim le As String = Replace(gla.Trim, "edit=", "", 1, , CompareMethod.Text).Trim
                        chbGEdit.Checked = True
                        If Not gridlinktext Is Nothing Then txtGridEditText.Text = gridlinktext(j)
                        If Not gridlinkwidth Is Nothing Then txtGridEditWidth.Text = gridlinkwidth(j)
                    ElseIf gla.Length > 4 AndAlso gla.ToUpper.IndexOf("OPEN=") >= 0 Then
                        chbGridOpen.Checked = True
                        Dim strSQl As String = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" +
                                cboIST.SelectedValue.ToString + "' and isnull(typeOfTableParentChild,'')='D' and parenttableName=N'" +
                                ttable + "'" + " order by 1"
                        Call popunicbo(cboGOpen, strSQl, Me.ISTConnectionString)
                        cboGOpen.SelectedValue = Replace(gla.Trim, "open=", "", 1, , CompareMethod.Text).Trim
                        If Not gridlinktext Is Nothing Then txtGridOpenText.Text = gridlinktext(j)
                        If Not gridlinkwidth Is Nothing Then txtGridOpenWidth.Text = gridlinkwidth(j)
                    ElseIf gla.Length > 6 AndAlso gla.ToUpper.IndexOf("DELETE=") >= 0 Then
                        Dim ld As String = Replace(gla.Trim, "delete=", "", 1, , CompareMethod.Text).Trim
                        txtGridDeleteText.Text = ld
                        chbGridDelete.Checked = True
                        If Not gridlinktext Is Nothing Then txtGridDeleteText.Text = gridlinktext(j)
                        If Not gridlinkwidth Is Nothing Then txtGridDeleteWidth.Text = gridlinkwidth(j)
                    End If
                Next
            End If

            dopuni(gridlinkstopif, gridlinkstopifmsg)
            dgvGridStop.DataSource = Nothing
            For i As Integer = 0 To gridlinkstopifmsg.GetUpperBound(0)
                If gridlinkstopif(i) = "" Then gridlinkstopif(i) = "2=2"
                dgvGridStop.Rows.Add(New String() {gridlinkstopif(i), gridlinkstopifmsg(i)})
            Next

            dgvGridColumn.DataSource = Nothing
            For i As Integer = 0 To gridcolumns.GetUpperBound(0)
                dgvGridColumn.Rows.Add(New String() {gridcolumns(i), gridwidth(i)})
            Next

            dgvGridAddCol.DataSource = Nothing
            For i As Integer = 0 To gridaddcolumn.GetUpperBound(0)
                dgvGridAddCol.Rows.Add(New String() {gridaddcolumn(i), gridwidth(gridcolumns.GetUpperBound(0) + i + 1)})
            Next

        End If 'datagridview

        If Not ccolumnAtributes.Trim.StartsWith("'") Then ccolumnAtributes = "'" + ccolumnAtributes
        If Not ccolumnAtributes.Trim.EndsWith("'") Then ccolumnAtributes = ccolumnAtributes + "'"

        If ffp = True Then txtExpression.Text = ccolumnAtributes

        If cbLL.Checked = False AndAlso cbDTP.Checked = False AndAlso cbCB.Checked = False AndAlso
            cbLCHB.Checked = False AndAlso cbRCHB.Checked = False AndAlso cbB.Checked = False AndAlso
            cbVRB.Checked = False AndAlso cbCHB.Checked = False AndAlso cbDGV.Checked = False AndAlso
            cbCB.Checked = False AndAlso cbCWO.Checked = False AndAlso ffp = False Then
            cbTB.Checked = True
        End If
    End Sub

    Dim pomgridwidth As String

    Function setMetaDataPaneP1() As String
        'izraz
        Dim pom As String = ""

        For Each k As Control In paneP1.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim.ToUpper + "$"
            End If
        Next

        'If chbMultilineH.Checked = True Then pom = "multilineheight" + txtMultilineH.Text + "$"

        If cbCHB.Checked = True Then pom = pom + "checkbox=" + txtCBGroup.Text
        If cbRCHB.Checked = True Then pom = pom + "checkboxR" + txtCBGroup.Text
        If cbLCHB.Checked = True Then pom = pom + "checkboxL" + txtCBGroup.Text
        If cbB.Checked = True Then pom = pom + "button"
        If cbDTP.Checked = True Then pom = pom + "DateTimePicker"
        If cbLL.Checked = True Then pom = pom + "LinkLabel"

        If cbCB.Checked = True AndAlso cbCWO.Checked = True AndAlso txtfF.Text = "" Then pom = pom + "CBW{DataSource=" + txtfDS.Text + ";DisplayMember=" + txtfDM.Text + ";ValueMember=" + txtfVM.Text + "}"
        If cbCB.Checked = True AndAlso cbCWO.Checked = True AndAlso txtfF.Text <> "" Then pom = pom + "CBW{DataSource=" + txtfDS.Text + ";DisplayMember=" + txtfDM.Text + ";ValueMember=" + txtfVM.Text + ";Filter=" + txtfF.Text + "}"
        If cbCB.Checked = True AndAlso cbCWO.Checked = False AndAlso txtfF.Text = "" Then pom = pom + "CBO{DataSource=" + txtfDS.Text + ";DisplayMember=" + txtfDM.Text + ";ValueMember=" + txtfVM.Text + "}"
        If cbCB.Checked = True AndAlso cbCWO.Checked = False AndAlso txtfF.Text <> "" Then pom = pom + "CBO{DataSource=" + txtfDS.Text + ";DisplayMember=" + txtfDM.Text + ";ValueMember=" + txtfVM.Text + ";Filter=" + txtfF.Text + "}"
        If cbVRB.Checked = True Then pom = pom + "RadioButtonV{" + setRB(dgvRB) + "}"
        If cbHRB.Checked = True Then pom = pom + "RadioButtonH{" + setRB(dgvRB) + "}"

        If cbDGV.Checked = True Then
            pom = "DataGridView;" + nvrd
            If txtGTitle.Text <> "" Then pom = pom + "GridTitle=" + txtGTitle.Text + ";" + nvrd
            If txtGLocationX.Text <> "" AndAlso txtGLocationY.Text <> "" Then pom = pom + "GridLocation(X=" + txtGLocationX.Text + ",Y=" + txtGLocationY.Text + ");" + nvrd
            If cboGS.SelectedValue <> "" Then pom = pom + "GridSource=" + cboGS.SelectedValue + ";" + nvrd
            If txtGSW.Text <> "" Then pom = pom + "GridSourceWhere=" + txtGSW.Text + ";" + nvrd
            If txtGHeight.Text <> "" Then pom = pom + "GridHeight=" + txtGHeight.Text + ";" + nvrd
            If txtGWidth.Text <> "" Then pom = pom + "GridWidth=" + txtGWidth.Text + ";" + nvrd
            If txtGFS.Text <> "" Then pom = pom + "GridFontSize=" + txtGFS.Text + ";" + nvrd
            If txtGRHW.Text <> "" Then pom = pom + "RowHeadersWidth=" + txtGRHW.Text + ";" + nvrd
            If txtGHRFS.Text <> "" Then pom = pom + "GridHeaderRowFontSize=" + txtGHRFS.Text + ";" + nvrd
            If txtGColHHght.Text <> "" Then pom = pom + "ColumnHeadersHeight=" + txtGColHHght.Text + ";" + nvrd

            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Edit$Open=" + cboGOpen.SelectedValue + "&Delete;" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkAction=Edit$Open=" + cboGOpen.SelectedValue + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Edit$Delete;" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Open=" + cboGOpen.SelectedValue + "$Delete;" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkAction=Edit;" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkAction=Open=" + cboGOpen.SelectedValue + ";" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Delete;" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridEditText.Text + "&" + txtGridOpenText.Text + "$" + txtGridDeleteText.Text + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkText=" + txtGridEditText.Text + "&" + txtGridOpenText.Text + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridEditText.Text + "&" + txtGridDeleteText.Text + ";" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridOpenText.Text + "$" + txtGridDeleteText.Text + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkText=" + txtGridEditText.Text + ";" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkText=" + txtGridOpenText.Text + ";" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridDeleteText.Text + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + "&" + txtGridOpenWidth.Text + "$" + txtGridDeleteWidth.Text + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + "&" + txtGridOpenWidth.Text + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + "&" + txtGridDeleteWidth.Text + ";" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridOpenWidth.Text + "$" + txtGridDeleteWidth.Text + ";" + nvrd
            If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + ";" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkWidth=" + txtGridOpenWidth.Text + ";" + nvrd
            If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridDeleteWidth.Text + ";" + nvrd

            Dim gridlinkstopif As String = "" : Dim gridlinkstopifmsg As String = ""
            pom = pom + setGridStop(gridlinkstopif, gridlinkstopifmsg, dgvGridStop, "GridLinkStopif", "GridLinkStopIfMsg") + nvrd
            Dim gridcolumns As String = "" : Dim gridwidth As String = "" : pomgridwidth = ""
            pom = pom + setGridCol(gridcolumns, gridwidth, dgvGridColumn, "GridColumns", "GridColumnsWidth") + nvrd
            Dim gridaddcolumn As String = "" : Dim ggridwidth As String = ""
            Dim ppom As String = setGridAddCol(gridaddcolumn, gridwidth + ggridwidth, dgvGridAddCol, pomgridwidth, "GridAddColumn", "GridColumnsWidth")
            If ppom <> "" Then
                pom = pom + nvrd + ppom
            Else
                pom = pom + nvrd + "GridColumnsWidth=" + pomgridwidth + ";"
            End If
        End If

        Return pom
    End Function

    Function setMetaDataPaneP11() As String
        'do autocompete
        Dim pom As String = ""

        If txtACB.Text <> "" Then pom = pom + "autocomplete=" + txtACB.Text + ";"
        If txtACStart.Text <> "" Then pom = pom + "autocompletestart=" + txtACStart.Text + ";"
        If txtACLength.Text <> "" Then pom = pom + "autocompletelength=" + txtACLength.Text + ";"
        If txtACMinTL.Text <> "" Then pom = pom + "autocompletemintypelength=" + txtACMinTL.Text + ";"
        If txtACAsgn.Text <> "" Then pom = pom + "autocompleteassignto=" + txtACAsgn.Text + ";"
        If txtACAsgnStart.Text <> "" Then pom = pom + "autocompleteassignstart=" + txtACAsgnStart.Text + ";"
        If txtACAsgnLen.Text <> "" Then pom = pom + "autocompleteassignlength=" + txtACAsgnLen.Text + ";"
        If cbACLTL.Checked = True Then pom = pom + "autocompletelimittolist=True;"
        If txtLett.Text <> "" Then pom = pom + "autocompleteletter=" + txtLett.Text + ";"
        If txtACHeight.Text <> "" Then pom = pom + "autocompleteheight=" + txtACHeight.Text + ";"
        If txtACWidth.Text <> "" Then pom = pom + "autocompletewidth=" + txtACWidth.Text + ";"
        If txtACFilterName.Text <> "" Then pom = pom + "autocompletefilter=" + txtACFilterName.Text + ";"
        If txtACFilterLen.Text <> "" Then pom = pom + "autocompletefilterlength=" + txtACFilterLen.Text + ";"
        If txtACFilterStart.Text <> "" Then pom = pom + "autocompletefilterstart=" + txtACFilterStart.Text + ";"

        Return pom

    End Function

    Function setGridStop(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        setGridStop = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + "$"
            If s2 <> "" AndAlso s1 = "" Then s1 = "2=2$"
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "$" : s1 = s1.Replace("$$", "")
            setGridStop = setGridStop + ss1 + "=" + s1 + ";"
            s2 = s2 + "$" : s2 = s2.Replace("$$", "")
            setGridStop = setGridStop + ss2 + "=" + s2 + ";"

        End If
        Return setGridStop
    End Function

    Function setGridCol(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String) As String

        setGridCol = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + ","
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + ","
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1.TrimEnd(",")
            setGridCol = setGridCol + ss1 + "=" + s1 + ";"
            s2 = s2.TrimEnd(",")
            'setGridCol = setGridCol + ss2 + "=" + s2 + ";"
            pomgridwidth = s2

        End If
        Return setGridCol
    End Function

    Function setGridAddCol(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal pomgridwidth As String, ByVal ss1 As String, ByVal ss2 As String) As String

        setGridAddCol = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + ","
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + ","
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1.TrimEnd(",")
            setGridAddCol = setGridAddCol + ss1 + "=" + s1 + ";"
            s2 = s2.TrimEnd(",")
            pomgridwidth = pomgridwidth.TrimEnd(";")
            pomgridwidth = pomgridwidth + "," + s2

            setGridAddCol = setGridAddCol + ss2 + "=" + pomgridwidth + ";"

        End If
        Return setGridAddCol
    End Function

    Function setRB(ByVal dgv As DataGridView) As String

        Dim rb As String = ""
        setRB = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(0).Value Is Nothing Then
                rb = rb + dgv.Rows(i).Cells(0).Value + "'" + dgv.Rows(i).Cells(1).Value + "',"
            End If
        Next
        setRB = rb.TrimEnd(",")
        Return setRB

    End Function

    Function set1(ByVal s1 As String, ByVal dgv As DataGridView, ByVal ss1 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        set1 = ""
        If Not dgv.Rows(0).Cells(0).Value Is Nothing AndAlso dgv.Rows(0).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(0).Cells(0).Value.ToString.Trim
        If s1 <> "" Then
            s1 = s1 + ";" : s1 = s1.Replace(";;", "").Replace("'", "''")
            set1 = set1 + ss1 + "=" + s1 + ";"
            set1 = set1.Replace("'", "''")
        End If
        Return set1
    End Function

    '******************************************************
    Function setSaVise(ByVal s1 As String, ByVal s2 As String, ByVal s3 As String, ByVal s4 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String, ByVal ss3 As String, ByVal ss4 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        setSaVise = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(3).Value Is Nothing AndAlso dgv.Rows(i).Cells(3).Value.ToString.Trim <> "" Then s4 = s4 + dgv.Rows(i).Cells(3).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(2).Value Is Nothing AndAlso dgv.Rows(i).Cells(2).Value.ToString.Trim <> "" Then s3 = s3 + dgv.Rows(i).Cells(2).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + "$"
            If s2 <> "" AndAlso s1 = "" Then s1 = "2=2$"
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "$" : s1 = s1.Replace("$$", "")
            setSaVise = setSaVise + ss1 + "=" + s1 + ";"
            s2 = s2 + "$" : s2 = s2.Replace("$$", "")
            setSaVise = setSaVise + ss2 + "=" + s2 + ";"
            s3 = s3 + "$" : s3 = s3.Replace("$$", "")
            setSaVise = setSaVise + ss3 + "=" + s3 + ";"
            s4 = s4 + "$" : s4 = s4.Replace("$$", "")
            setSaVise = setSaVise + ss4 + "=" + s4 + ";"

            setSaVise = setSaVise.Replace("'", "''")
        End If
        Return setSaVise
    End Function

    Function setSaVise1(ByVal s1 As String, ByVal dgv As DataGridView, ByVal ss1 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        setSaVise1 = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + "$"

        Next
        If s1 <> "" Then
            s1 = s1 + "$" : s1 = s1.Replace("$$", "")
            setSaVise1 = setSaVise1 + ss1 + "=" + s1 + ";"

            setSaVise1 = setSaVise1.Replace("'", "''")
        End If
        Return setSaVise1
    End Function

    Function setSaVise2(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        setSaVise2 = ""
        For i As Integer = 0 To dgv.Rows.Count - 1

            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + "$"
            If s2 <> "" AndAlso s1 = "" Then s1 = "2=2$"
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "$" : s1 = s1.Replace("$$", "")
            setSaVise2 = setSaVise2 + ss1 + "=" + s1 + ";"
            s2 = s2 + "$" : s2 = s2.Replace("$$", "")
            setSaVise2 = setSaVise2 + ss2 + "=" + s2 + ";"

            setSaVise2 = setSaVise2.Replace("'", "''")
        End If
        Return setSaVise2
    End Function

    Function setSaVise3(ByVal s1 As String, ByVal s2 As String, ByVal s3 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String, ByVal ss3 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        setSaVise3 = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(2).Value Is Nothing AndAlso dgv.Rows(i).Cells(2).Value.ToString.Trim <> "" Then s3 = s3 + dgv.Rows(i).Cells(2).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + "$"
            If s2 <> "" AndAlso s1 = "" Then s1 = "2=2$"
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "$" : s1 = s1.Replace("$$", "")
            setSaVise3 = setSaVise3 + ss1 + "=" + s1 + ";"
            s2 = s2 + "$" : s2 = s2.Replace("$$", "")
            setSaVise3 = setSaVise3 + ss2 + "=" + s2 + ";"
            s3 = s3 + "$" : s3 = s3.Replace("$$", "")
            setSaVise3 = setSaVise3 + ss3 + "=" + s3 + ";"

            setSaVise3 = setSaVise3.Replace("'", "''")
        End If
        Return setSaVise3
    End Function

    Sub getMetaDataPaneP2()

        If label = "" Then Exit Sub
        Dim opisG As String = label
        Dim naslovForeColor As String = ""
        Dim naslovBackColor As String = ""
        Dim naslovVisina As String = ""
        Dim naslovFontSize As String = ""

        Dim red() As String = label.Split("#")
        Dim pravalabela As String = red(0)

        Dim pp() As String = pravalabela.Split("$")

        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i) = "" Then chbOnlyTitle.Checked = True
            If pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") >= 0 Then
                chbForeColor.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorCombobox1.SelectedColor = Color.FromName(fc)
                naslovForeColor = fc
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 Then
                chbBackColor.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorCombobox2.SelectedColor = Color.FromName(bc)
                naslovBackColor = bc
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                chbFBold.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                chbFItalic.Checked = True
            ElseIf pp(i).Length > 7 AndAlso (pp(i).Trim.ToUpper.IndexOf("LCENTERA") = 0 OrElse pp(i).Trim.ToUpper.IndexOf("LCENTREA") = 0 OrElse pp(i).Trim.ToUpper.IndexOf("LCENTARP") = 0) Then
                chbCAligment.Checked = True
            ElseIf pp(i).Length > 6 AndAlso (pp(i).Trim.ToUpper.IndexOf("LRIGHTA") = 0 OrElse pp(i).Trim.ToUpper.IndexOf("LDESNOP") = 0) Then
                chbRAligment.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("MULTILINE") = 0 Then
                chbML.Checked = True
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("WEBSTR") = 0 Then
                chbNewWebGroup.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                Dim fs As Integer = CInt(pp(i).Trim.ToUpper.Replace("FONTSIZE", ""))
                chbFSize.Checked = True
                tbFSize.Value = fs
                naslovFontSize = getttt(pp(i), "FONTSIZE")
            ElseIf pp(i).Trim <> "" Then
                txtTitle.Text = pp(i)
            End If
        Next

        opisG = Replace(opisG, "fontbold", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontitalic", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontunderline", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "ldesnop", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentarp", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lrighta", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "ldesnop", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentera", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentarp", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "multiline", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "webstr", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "forecolor" + naslovForeColor.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "backcolor" + naslovBackColor.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontsize" + naslovFontSize.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lheight" + naslovVisina.ToLower, "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lvisina" + naslovVisina.ToLower, "", 1, , CompareMethod.Text)

        opisG = opisG.Replace("$$", "$")


    End Sub

    Sub getMetaDataPaneP21()

        If label = "" Then Exit Sub
        Dim opisG As String = label
        Dim naslovForeColor As String = ""
        Dim naslovBackColor As String = ""
        Dim naslovVisina As String = ""
        Dim naslovFontSize As String = ""

        Dim red() As String = label.Split("#")

        Dim visina As String = ""
        Dim fsize As String = ""
        Dim apperance As String = ""
        Dim aligment As String = ""
        Dim forecol As String = ""
        Dim backcol As String = ""
        Dim tekst As String = ""
        If red.Length > 1 Then
            dgvHeaderSpec.DataSource = Nothing
            dgvHeader.DataSource = Nothing

            For ii As Integer = 1 To red.GetUpperBound(0)
                red(ii) = red(ii).Replace(vbCrLf, "").Trim
                'Dim nadlabela1() As String = nn(ii).Split("#")
                'For i As Integer = 1 To nadlabela1.GetUpperBound(0)
                Dim nadlabela() As String = red(ii).Split("$")
                For i As Integer = 0 To nadlabela.GetUpperBound(0)
                    If nadlabela(i).Length > 6 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("LVISINA") = 0 Then
                        visina = nadlabela(i).Trim.ToUpper.Replace("LVISINA", "")
                    ElseIf nadlabela(i).Length > 6 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("LHEIGHT") = 0 Then
                        visina = nadlabela(ii).Trim.ToUpper.Replace("LHEIGHT", "")
                    ElseIf nadlabela(i).Length > 7 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                        fsize = nadlabela(i).Trim.ToUpper.Replace("FONTSIZE", "")
                    ElseIf nadlabela(i).Length > 7 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                        apperance = nadlabela(i).Trim.ToUpper
                    ElseIf nadlabela(i).Length > 9 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                        apperance = nadlabela(i).Trim.ToUpper
                    ElseIf nadlabela(i).Length > 12 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("FONTUNDERLINE") = 0 Then
                        apperance = nadlabela(i).Trim.ToUpper
                    ElseIf nadlabela(i).Length > 6 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("LRIGHTA") = 0 Then
                        aligment = nadlabela(i).Trim.ToUpper.Replace("LRIGHTA", "RIGHT")
                    ElseIf nadlabela(i).Length > 5 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("LLEFTA") = 0 Then
                        aligment = nadlabela(i).Trim.ToUpper.Replace("LLEFTA", "LEFT")
                    ElseIf nadlabela(i).Length > 8 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("FORECOLOR") = 0 Then
                        forecol = nadlabela(i).Trim.ToUpper.Replace("FORECOLOR", "")
                    ElseIf nadlabela(i).Length > 8 AndAlso nadlabela(i).Trim.ToUpper.IndexOf("BACKCOLOR") = 0 Then
                        backcol = nadlabela(i).Trim.ToUpper.Replace("BACKCOLOR", "")
                    Else
                        tekst = nadlabela(i) + " "
                    End If
                Next

                Dim nadlabela2() As String = tekst.Split(";")
                For i As Integer = 0 To nadlabela2.GetUpperBound(0)
                    dgvHeader.Rows.Add(New String() {ii, i + 1, nadlabela2(i)})
                Next
                ' For k As Integer = 0 To nadlabela.GetUpperBound(0)
                dgvHeaderSpec.Rows.Add(New String() {ii, visina, fsize, apperance, aligment, forecol, backcol})
                '  Next
            Next
        End If

    End Sub

    Function setNL(ByVal dgv As DataGridView, dgv2 As DataGridView) As String
        Dim red As Integer = 0
        Dim nl As String = ""
        setNL = ""

        Dim zr As Integer = 0
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(0).Value Is Nothing Then
                red = dgv.Rows(i).Cells(0).Value
                If red > zr Then
                    If red > 1 Then nl = nl.TrimEnd(";")
                    nl = nl + "#"
                    zr = red
                    For ii As Integer = 0 To dgv2.Rows.Count - 1
                        If dgv2.Rows(ii).Cells(0).Value = red Then
                            If Not dgv2.Rows(ii).Cells(1).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(1).Value <> "" Then
                                nl = nl + "LHEIGHT" + dgv2.Rows(ii).Cells(1).Value + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(2).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(2).Value <> "" Then
                                nl = nl + "FONTSIZE" + dgv2.Rows(ii).Cells(2).Value + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(3).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(3).Value <> "" AndAlso dgv2.Rows(ii).Cells(3).Value = "FONTBOLD" Then
                                nl = nl + "FONTBOLD" + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(3).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(3).Value <> "" AndAlso dgv2.Rows(ii).Cells(3).Value = "FONTITALIC" Then
                                nl = nl + "FONTITALIC" + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(3).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(3).Value <> "" AndAlso dgv2.Rows(ii).Cells(3).Value = "FONTUNDERLINE" Then
                                nl = nl + "FONTUNDERLINE" + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(4).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(4).Value <> "" AndAlso dgv2.Rows(ii).Cells(4).Value = "RIGHT" Then
                                nl = nl + "LRIFHTA" + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(4).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(4).Value <> "" AndAlso dgv2.Rows(ii).Cells(4).Value = "LEFT" Then
                                nl = nl + "LLEFTA" + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(5).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(5).Value <> "" Then
                                nl = nl + "FORECOLOR" + dgv2.Rows(ii).Cells(5).Value + "$"
                            End If
                            If Not dgv2.Rows(ii).Cells(6).Value Is Nothing AndAlso dgv2.Rows(ii).Cells(6).Value <> "" Then
                                nl = nl + "BACKCOLOR" + dgv2.Rows(ii).Cells(6).Value + "$"
                            End If
                            Exit For
                        End If
                    Next
                End If
                nl = nl + dgv.Rows(i).Cells(2).Value.ToString.Trim + " ;"
            End If

        Next
        nl = nl.TrimEnd(";")
        setNL = nl
        Return setNL

    End Function

    Function setMetaDataPaneP2() As String
        'opis
        Dim pom As String = ""

        For Each k As Control In paneP2.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim.ToUpper + "$"
            End If
        Next

        'nadlabela

        If Mkc_ColorCombobox2.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox2.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox2.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox2.SelectedColor = Color.Lavender
        If Mkc_ColorCombobox2.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox2.SelectedColor = Color.Snow
        If Mkc_ColorCombobox1.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox1.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox1.SelectedColor.Name = "Lavander" Then Mkc_ColorCombobox1.SelectedColor = Color.Lavender

        If chbForeColor.Checked = True AndAlso Mkc_ColorCombobox1.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorCombobox1.SelectedColor.Name + "$"
        If chbBackColor.Checked = True AndAlso Mkc_ColorCombobox2.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorCombobox2.SelectedColor.Name + "$"

        If chbFSize.Checked = True Then
            Dim ffs As String = "8"
            Dim fs As Integer = CInt(tbFSize.Value.ToString())
            ffs = CStr(fs).Trim
            pom = pom + "fontSize" + ffs + "$"
        End If

        'Dim h As String = tbHHeight.Value.ToString()
        'If h > 1 Then pom = pom + "lHeight" + h + "$"

        If chbOnlyTitle.Checked = True Then pom = "$" + pom

        If txtTitle.Text.Trim <> "" Then
            pom = pom + txtTitle.Text + "$"
        Else
            pom = pom + "   " + "$"
        End If
        'pom = pom + setNL(dgvHeader, dgvHeaderSpec)
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")

        'ISTMessageBox.Show(pom)

        pom = pom.TrimEnd("$")
        Return pom

    End Function

    Function setMetaDataPaneP21() As String
        'opis
        Dim pom As String = ""
        pom = pom + setNL(dgvHeader, dgvHeaderSpec)
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")
        'ISTMessageBox.Show(pom)
        pom = pom.TrimEnd("$")
        Return pom

    End Function

    Sub getMetaDataPaneP3()

        Dim multilineheight As String = ""
        Dim forecolor As String = ""
        Dim backcolor As String = ""
        Dim ccolumnAtributes As String = columnAtributes
        If ccolumnAtributes.Trim = "" Then Exit Sub

        ccolumnAtributes = Replace(ccolumnAtributes, "multiline", "multiline" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fontbold", "fontbold" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "readonly", "readonly" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fontitalic", "fontitalic" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fontunderline", "fontunderline" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "visiblefalse", "visiblefalse" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "enablefalse", "enablefalse" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "frighta", "frighta" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fcentera", "fcentera" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "fcentrea", "fcentrea" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "borderfixed", "borderfixed" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "bordernone", "bordernone" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = ccolumnAtributes.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")

        Dim pp() As String = ccolumnAtributes.Split("$")
        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Replace("#{", "").Trim

            If pp(i).Length > 1 AndAlso pp(i).Substring(pp(i).Length - 1, 1) = "}" Then pp(i) = pp(i).Substring(0, pp(i).Length - 1)

            If pp(i).Trim = "" Then

            ElseIf pp(i).Length > 14 AndAlso pp(i).Trim.ToUpper.IndexOf("MULTILINEHEIGHT") = 0 Then
                Dim mlh As String = pp(i).Trim.ToUpper.Replace("MULTILINEHEIGHT", "")
                txtMultilineH.Text = mlh
                chbMultilineH.Checked = True
                multilineheight = getttt(pp(i), "MULTILINEHEIGHT")
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") >= 0 Then
                chbFC.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorComboboxFC.SelectedColor = Color.FromName(fc)
                forecolor = fc
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 Then
                chbBC.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorComboboxBC.SelectedColor = Color.FromName(bc)
                backcolor = bc
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("READONLY") = 0 Then
                chbRO.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("MULTILINE") = 0 Then
                chbMultiline.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                chbFB.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                chbItalic.Checked = True
            ElseIf pp(i).Length > 12 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTUNDERLINE") = 0 Then
                chbFU.Checked = True
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("VISIBLEFALSE") = 0 Then
                chbVF.Checked = True
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("ENABLEFALSE") = 0 Then
                chbEF.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("FRIGHTA") = 0 Then
                chbRight.Checked = True
            ElseIf pp(i).Length > 7 AndAlso (pp(i).Trim.ToUpper.IndexOf("FCENTERA") = 0 OrElse pp(i).Trim.ToUpper.IndexOf("FCENTREA") = 0) Then
                chbCentar.Checked = True
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("BORDERFIXED") = 0 Then
                chbBF.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("BORDERNONE") = 0 Then
                chbBN.Checked = True
            End If
        Next

    End Sub

    Function setMetaDataPaneP3() As String
        'izraz
        Dim pom As String = ""

        For Each k As Control In paneP3.Controls
            If TypeOf k Is CheckBox AndAlso DirectCast(k, CheckBox).Name <> "chbNTS" AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim.ToUpper + "$"
            End If
        Next

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxBC.SelectedColor = Color.Chocolate
        If Mkc_ColorComboboxBC.SelectedColor.Name = "Lavander" Then Mkc_ColorComboboxBC.SelectedColor = Color.Lavender
        If Mkc_ColorComboboxBC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow
        If Mkc_ColorComboboxFC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxFC.SelectedColor = Color.Chocolate
        If Mkc_ColorComboboxFC.SelectedColor.Name = "Lavander" Then Mkc_ColorComboboxFC.SelectedColor = Color.Lavender

        If chbMultilineH.Checked = True Then pom = pom + "multilineheight" + txtMultilineH.Text + "$"
        If chbFC.Checked = True AndAlso Mkc_ColorComboboxFC.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorComboboxFC.SelectedColor.Name + "$"
        If chbBC.Checked = True AndAlso Mkc_ColorComboboxBC.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorComboboxBC.SelectedColor.Name + "$"
        If cbFP.Checked = True Then
            Dim pp As String = txtExpression.Text.Trim
            If pp.StartsWith("'") AndAlso pp.EndsWith("'") Then
                pp = pp.Substring(1, Len(pp) - 2)
            End If
            If pp = "" Then pp = "    "
            pp = pp.Replace("'", "''")
            pom = pom + "'" + pp + "'"
        End If

        Return pom
    End Function

    Function setMetaDataPaneP31() As String
        'od
        Dim pom As String = ""
        If chbNQG.Checked = True Then pom = pom + "NEWQUESTIONGROUP" + "$"
        If chbNewWebGroup.Checked = True Then pom = pom + "WEBSTR" + "$"
        If chbNTS.Checked = True Then pom = pom + "NOTABSTOP" + "$"

        Return pom
    End Function

    Function setMetaDataPaneP32() As String
        'rbr
        Dim pom As String = ""
        If txtON.Text <> "" Then pom = pom + txtON.Text

        Return pom
    End Function

    Function setMetaDataPaneP33() As String
        'forma
        Dim pom As String = ""
        If txtSPOrderTable.Text <> "" AndAlso txtSPOrderRow.Text <> "" AndAlso txtSPOrderColumn.Text <> "" Then pom = pom + txtSPOrderTable.Text + "." + txtSPOrderRow.Text + "." + txtSPOrderColumn.Text

        Return pom
    End Function

    Function setMetaDataPaneP34() As String
        'VS
        Dim pom As String = ""
        If txtVS.Text <> "" Then pom = pom + txtVS.Text
        Return pom
    End Function

    '****************************************

    Sub dopuni(ByRef iif() As String, ByVal onn() As String)
        Dim iifLength = iif.Length
        If iif.Length < onn.Length Then
            For ii As Integer = 0 To onn.Length - iifLength - 1
                ReDim Preserve iif(ii)
                iif(ii) = "2=2"
            Next
        End If
    End Sub

    Sub sset()
        Dim P As Integer = 0

        Me.Cursor = Cursors.WaitCursor
        Dim strSQl As String = "select appCode, tableName, columnName, primaryKey, relationalDatabase, relationalTable, relationaColumn, controlSize, validatingEvent, enterEvent, defaultValue," +
                "label,orderNumber,columnType,columnLenght,tableLayout,ValidFrom,ValidTo,columnAtributes from _ISTTablesColumns where appcode=N'" +
                Me.cboIST.SelectedValue.ToString.Trim + "' and tableName=N'" + ttable + "' and columnName=N'" + ffield + "' and cast (validFrom as date)='" + Convert.ToDateTime(vvodC).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        Dim strSQlU As String = ""
        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Me.jezik)

        If dt.Rows.Count = 1 Then
            'update
            strSQlU = "update _ISTTablesColumns set "
            strSQl = ""
            Try
                ' If P = 0 Then
                primaryKey = "" : relationalDatabase = "" : relationalTable = "" : relationaColumn = "" : defaultValue = "" : columnType = "" : columnLenght = "" : ValidFrom = "" : ValidTo = ""
                setMetaDataPaneP0()
                'primaryKey,relationalDatabase,relationalTable,relationaColumn,defaultValue,columnType,columnLenght,ValidFrom,ValidTo - paneT0
                If primaryKey.Trim <> "" Then strSQl = strSQl + " primaryKey='" + primaryKey + "',"
                If relationalDatabase.Trim <> "" Then strSQl = strSQl + " relationalDatabase='" + relationalDatabase + "',"
                If relationalTable <> "" Then strSQl = strSQl + " relationalTable=N'" + relationalTable + "',"
                If relationaColumn <> "" Then strSQl = strSQl + " relationaColumn=N'" + relationaColumn + "',"
                If defaultValue.Trim <> "" Then strSQl = strSQl + " defaultValue=N'" + defaultValue + "',"
                If columnType.Trim <> "" Then strSQl = strSQl + " columnType='" + columnType + "',"
                If columnLenght.Trim <> "" Then strSQl = strSQl + " columnLenght='" + columnLenght + "',"
                If ValidFrom.Trim <> "" Then strSQl = strSQl + " validFrom='" + Convert.ToDateTime(ValidFrom).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "',"
                If ValidTo.Trim <> "" Then strSQl = strSQl + " ValidTo ='" + Convert.ToDateTime(ValidTo).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "',"

                '  End If

                ' If P = 10 OrElse P = 4 OrElse P = 11 Then
                'enterevent
                enterEvent = ""

                enterEvent = setMetaDataPaneP10()

                enterEvent = enterEvent + setMetaDataPaneP11()
                'label = setMetaDataPaneP1()
                'If label.Trim <> "" Then strSQl = strSQl + " label='" + label + "',"
                If enterEvent.Trim <> "" Then strSQl = strSQl + " enterEvent=N'" + enterEvent + "',"
                '   End If
                '   If P = 31 OrElse P = 5 Then
                'validatingevent
                validatingEvent = ""
                validatingEvent = setMetaDataPaneP31()

                If validatingEvent.Trim <> "" Then strSQl = strSQl + " validatingEvent=N'" + validatingEvent + "',"
                '   End If

                '  If P = 34 Then
                'controlSize
                controlSize = ""
                controlSize = setMetaDataPaneP34()
                If controlSize.Trim <> "" Then strSQl = strSQl + " controlSize='" + controlSize + "',"
                ' End If

                '    If P = 2 Then
                'label
                label = ""
                label = setMetaDataPaneP2()
                If label.Trim <> "" Then strSQl = strSQl + " label=N'" + label + "',"
                '  End If

                '    If P = 21 Then
                'label
                label = ""
                label = setMetaDataPaneP21()
                If label.Trim <> "" Then strSQl = strSQl + " label=N'" + label + "',"
                '  End If

                ' If P = 32 Then
                'orderNumber
                orderNumber = ""
                orderNumber = setMetaDataPaneP32()
                If orderNumber.Trim <> "" Then strSQl = strSQl + " orderNumber='" + orderNumber + "',"
                '  End If
                '  If P = 33 Then
                'tableLayout
                tableLayout = ""
                tableLayout = setMetaDataPaneP33()
                If tableLayout.Trim <> "" Then strSQl = strSQl + " tableLayout='" + tableLayout + "',"
                '   End If

                'columnAtributes = ""
                '  If P = 1 OrElse P = 3 Then
                columnAtributes = ""
                columnAtributes = columnAtributes + setMetaDataPaneP1()
                columnAtributes = columnAtributes + setMetaDataPaneP3()

                '   End If

                If columnAtributes.Trim <> "" Then
                    columnAtributes = columnAtributes.Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
                    strSQl = strSQl + " columnAtributes=N'" + columnAtributes + "',"
                End If
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try

            If strSQl <> "" Then
                strSQl = strSQl.TrimEnd(",")
                strSQl = strSQl + " where appcode=N'" + Me.cboIST.SelectedValue.ToString.Trim + "' and tableName=N'" + ttable + "' and columnName=N'" + ffield + "'"

                If promenaVOD = False Then
                    If ValidFrom.Trim <> "" Then
                        strSQl = strSQl + "  and cast (validFrom as date)='" + Convert.ToDateTime(ValidFrom).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                    Else
                        strSQl = strSQl + "  and cast (validFrom as date)='" + Convert.ToDateTime(vvodC).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                    End If
                End If

                strSQlU = strSQlU + strSQl
            Else
                strSQlU = ""
            End If
        End If

        Me.txtCUpdate.Text = strSQlU
        Dim pp As String = ""
        If Not Me.txtCUpdate.Tag Is Nothing Then
            pp = Me.txtCUpdate.Tag + ";"
        End If
        If pp.IndexOf("ISTPOLJA;") < 0 Then Me.txtCUpdate.Tag = pp + "ISTPOLJA;"

        Me.txtCUpdate.Visible = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub rbCB_CheckedChanged(sender As Object, e As EventArgs)
        txtCBGroup.Visible = True
        txtCBGroup.Focus()
    End Sub

    Private Sub cbTB_CheckedChanged(sender As Object, e As EventArgs) Handles cbTB.CheckedChanged, cbFP.CheckedChanged, cbHRB.CheckedChanged, cbVRB.CheckedChanged, cbLL.CheckedChanged,
        cbDTP.CheckedChanged, cbDGV.CheckedChanged, cbRCHB.CheckedChanged, cbLCHB.CheckedChanged, cbCHB.CheckedChanged,
        cbAC.CheckedChanged, cbCB.CheckedChanged, cbB.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then Call ch(sender.name)

        txtExpression.Visible = cbFP.Checked
        gbCBO.Visible = cbCB.Checked
        gbCBO.Location = New Point(300, 50)
        gbAC.Visible = cbAC.Checked
        gbAC.Location = New Point(300, 50)
        TabControlDGV.Visible = cbDGV.Checked
        TabControlDGV.Location = New Point(300, 50)
        dgvRB.Visible = (cbHRB.Checked OrElse cbVRB.Checked)

    End Sub

    'gbAC
    'txtCBGroup
    'TabControlDGV
    'txtRBH
    'txtExpression
    'txtL6
    'gbCBO
    'txtRBV
    Sub ch(ByVal cbName As String)
        For Each k As Control In paneP1.Controls
            If TypeOf k Is CheckBox AndAlso k.Name.Trim.ToUpper <> cbName.Trim.ToUpper Then
                DirectCast(k, CheckBox).Checked = False
            End If
        Next
    End Sub

    Private Sub txtExec_DragEnter(sender As Object, e As DragEventArgs)
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub txtExec_DragDrop(sender As Object, e As DragEventArgs)
        If e.Data IsNot Nothing Then
            Dim text As String = e.Data.GetData(DataFormats.Text)
            sender.text = text
        End If
    End Sub

    Private Sub dgv_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles dgvHeader.CellValidating, dgvRB.CellValidating
        If e.ColumnIndex = 0 Then
            Dim i As Integer
            If Not Integer.TryParse(Convert.ToString(e.FormattedValue), i) AndAlso Convert.ToString(e.FormattedValue) <> "" Then
                e.Cancel = True
                ISTMessageBox.Show("please enter numeric")
            End If
        End If
    End Sub

    Private Sub btnP0OK_Click(sender As Object, e As EventArgs) Handles btnP0OK.Click, btnP1OK.Click, btnP2OK.Click, btnP21OK.Click, btnP3OK.Click
        Try
            Call sset()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbPKAC_CheckedChanged(sender As Object, e As EventArgs) Handles cbPKAC.CheckedChanged
        gbOptionsAC.Visible = Not cbPKAC.Checked
    End Sub

    Private dsIST As New DatasetIstrazivanja
    Private rist As DatasetIstrazivanja.ISTRow
    Private mdtAWL As New System.Data.DataTable
    Dim mdtQE As New System.Data.DataTable
    Private mdtLabel As New System.Data.DataTable
    Private mdtMessage As New System.Data.DataTable

    Private Sub llPreviewC_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPreviewC.LinkClicked

        'brisi backuopve od pre
        Call deleteUNDOREDOPOLJA()
        Call refreshMetaOpen(1)
    End Sub
    Sub deleteUNDOREDOPOLJA()
        Dim dFold As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\Istrazivanja"
        Dim folder As String = dFold + "\GUIBACKUP\POLJA"

        Dim notepadProcesses As Process() = Process.GetProcessesByName("notepad")
        For i As Integer = 0 To notepadProcesses.GetUpperBound(0)
            If notepadProcesses(i).MainWindowTitle.Trim.ToUpper.IndexOf("BACKUPUNDO.TXT") >= 0 Then
                notepadProcesses(i).Kill()
            End If
            If notepadProcesses(i).MainWindowTitle.Trim.ToUpper.IndexOf("BACKUPREDO.TXT") >= 0 Then
                notepadProcesses(i).Kill()
            End If
        Next

        If Directory.Exists(folder) Then
            System.IO.Directory.Delete(folder, True)
        End If

    End Sub

    Sub refreshMetaOpen(Optional ByVal prvi As Integer = 0)

        Me.Cursor = Cursors.WaitCursor
        Try
            'Me.vt = ucvt
            'Dim d As Date = New Date(vt.G, vt.M, 2)
            'Dim vtvt As String = d.ToString("yyyy-MM-dd")

            Dim pomocnoMes As Integer = Me.ucvt.M
            If Me.ucvt.M > 12 Then
                pomocnoMes = 12
            End If
            Dim d As Date = New Date(Me.ucvt.G.ToString, pomocnoMes, 2)
            Dim vtvt As String = d.ToString("yyyy-MM-dd")


            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja

            Call puniDatasetIstrazivanja(appCode, vtvt, tabela)

            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            Me.Cursor = Cursors.Default

            Try
                Call llPreview("C")
            Catch ex As Exception
                ISTMessageBox.Show("ccc")
                ISTMessageBox.Show("The app is not defined for chosen time point!")
                ' ISTMessageBox.Show(ex.Message, "",  MessageBoxButtons.OK,  MessageBoxIcon.Error)
                Me.Cursor = Cursors.Default
            End Try
        Catch ex As Exception
            'ISTMessageBox.Show("aaa")
            ISTMessageBox.Show("The app is not defined for chosen time point!")
            ' ISTMessageBox.Show(ex.Message, "",  MessageBoxButtons.OK,  MessageBoxIcon.Error)
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    '00:00:00 00:00:00
    Private Sub llPreviewT_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPreviewT.LinkClicked
        Call llPreview("T")
    End Sub
    Dim fbtnUndoVisible As Boolean
    Dim fbtnRedoVisible As Boolean
    Dim fbtnRefreshClicked As Boolean
    Dim fbtnRefreshVisible As Boolean = True
    Sub llPreview(ByVal what As String)
        Me.Cursor = Cursors.WaitCursor

        Dim ISTtabela As String = ""

        If what = "C" Then ISTtabela = Replace(txtCLAC.Text, "add column to table:", "", 1, , CompareMethod.Text).Trim
        If what = "T" Then
            ISTtabela = Replace(txtTL0.Text.Trim, "in _isttables of ist metadata", "", 1, , CompareMethod.Text).Trim
            ISTtabela = Replace(ISTtabela.Trim, "table", "", 1, , CompareMethod.Text).Trim
            ISTtabela = ISTtabela.Trim.Replace(":", "").Trim
        End If

        If ISTtabela = "" Then ISTMessageBox.Show("Select table!") : Exit Sub
        Dim previewEditMode As Boolean = True
        Dim frm As New IstrazivanjaUnos.FormIstUnos(dsIST, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vt, ISTtabela, False, "", "", Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                    Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, False, False,,,,,,,,,,,,,,,,,,,,,,,,,,, previewEditMode,,,,,,
                    fbtnUndoVisible, fbtnRedoVisible, fbtnRefreshVisible)
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally

            If Not frm.IsDisposed Then
                Dim frmRefresh As Boolean = frm.refreshForm
                fbtnUndoVisible = frm.btnUndoVisible
                fbtnRedoVisible = frm.btnRedoVisible
                fbtnRefreshVisible = frm.btnRefreshVisible
                fbtnRefreshClicked = frm.btnRefreshClicked
                frm.Dispose()
                If frmRefresh = True OrElse fbtnRefreshClicked = True Then
                    Call refreshMetaOpen()
                End If
            End If

        End Try

        Me.Cursor = Cursors.Default

    End Sub
#Region "refreshdsIST"

    Sub puniDatasetIstrazivanja(ByVal app As String, ByVal vtvt As String, ByVal tabela As String)
        Me.dsIST.Clear()
        fISTNovo1Deo(app, vtvt) 'ISTBAZE,IST

        If Me.dsIST.IST.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim appStaraApl As String = app : Dim appR As String = app : Dim tablesT As String = "" 'tabele, polja i LK moraju da budu iz iste app
        If Not Me.dsIST.IST.Rows(0).Item("Abaza") Is System.DBNull.Value Then
            Dim additionalParameters As String = Me.dsIST.IST.Rows(0).Item("Abaza").ToString.Trim.ToUpper
            Dim pp() As String = additionalParameters.Split(CType(";", Char()))
            For i As Integer = 0 To pp.GetUpperBound(0)
                Dim kk() As String = pp(i).Split(CType("=", Char()))
                If kk.Length >= 2 AndAlso kk(0) <> "" AndAlso kk(1) <> "" Then
                    If kk(0) = "IST" Then appStaraApl = kk(1).Trim
                    If kk(0) = "ISTTABS" OrElse kk(0) = "ISTREPORTSPROCEDURES" Then appR = kk(1)
                    If kk(0) = "ISTTABLES" OrElse kk(0) = "ISTTABELE" Then
                        'ISTTABLES=A1=A,B1=B,C1=C
                        'A1=A,B1=B,C1=C
                        tablesT = pp(i).Trim.ToUpper.Replace("ISTTABLES=", "").Replace("ISTTABELE=", "")
                    End If
                End If
            Next
        End If

        fISTTABELE(Me.dsIST, app, appStaraApl, vtvt, tablesT.Trim.ToUpper, tabela)
        fISTNovo2Deo(app, appStaraApl, vtvt, tablesT.Trim.ToUpper, tabela)  'ISTOPOLJA, ISTLK
        fISTOstalo(app, appStaraApl, vtvt, tablesT.Trim.ToUpper, tabela)

        For Each rowIST As DatasetIstrazivanja.ISTRow In dsIST.IST.Rows
            Me.rist = rowIST
        Next

    End Sub
    Sub fISTNovo1Deo(ByVal app As String, ByVal vtvt As String, Optional ByVal x As Integer = 0)

        Dim sqlISTBAZE As String = "select * from ISTBaze where vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) And '" + vtvt + "' <= vdo;"
        Dim sqlIST As String = "select * from IST where sifIST=N'" + app.Trim + "' And vod <= Convert(DateTime, DateAdd(Month, DateDiff(Month, 0, '" + vtvt + "'), 0), 126) and '" + vtvt + "' <= vdo;"
        Dim ssql As String = sqlISTBAZE + sqlIST
        If x = 1 Then
            sqlIST = "select * from IST"
        End If
        Try
            Dim ds As System.Data.DataSet = izvrsiSQLvratiDS(ssql, ISTConnectionString, Nothing)
            'Me.dsIST.ISTBAZE.Clear()
            'Me.dsIST.IST.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Me.dsIST.ISTBAZE.ImportRow(ds.Tables(0).Rows(i))
            Next
            For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
                Me.dsIST.IST.ImportRow(ds.Tables(1).Rows(i))
            Next
            If Me.dsIST.IST.Rows.Count = 0 Then
                ''msg 277
                Dim msgtxt277 As String = getMessageText(dtMessages, "277", Me.jezik)
                Throw New System.Exception(msgtxt277)
            End If
        Catch ex As System.Exception
            'Dim por As String = "CHECK databaseType (FIZBAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseType THAT DOES NOT EXISTS IN table _ISTDatabaseConnStrings (ISTBAZE)." + nvrd + nvrd +
            '    "CHECK databaseAlias (BAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseAlias THAT DOES NOT EXISTS IN table _IST." + nvrd
            'ISTMessageBox.Show("_IST _ISTDatabaseConnStrings (ISTBAZE) !!!! " + nvrd + por + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Sub fISTNovo2Deo(ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String, ByVal tabela As String)
        If Me.dsIST.ISTTABELE.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt2741 As String = getMessageText(dtMessages, "2741", Me.jezik)
            ISTMessageBox.Show(msgtxt2741)
            Exit Sub
        End If
        Dim sqlISTPolja As String = ""
        Dim sqlISTLK As String = ""

        'tabele koje postoje u ISTTabele
        Dim ttabele As String = ""
        For i As Integer = 0 To Me.dsIST.ISTTABELE.Rows.Count - 1
            ttabele = ttabele + "'" + DirectCast((Me.dsIST.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
        Next
        ttabele = ttabele.TrimEnd(CType(",", Char()))

        sqlISTPolja = "select * from ISTPolja where sifIST =N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ") and tabela=N'" + tabela + "'" +
                " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                " and '" + vtvt + "' <= vdo " +
                " order by tabela,rbr;"
        sqlISTLK = "select SIfIST,TABELA,RbrGreske,replace(GRESKA,'webrelacija','Relacija') as greska,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo" +
          " from ISTLk " +
          " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ") and tabela=N'" + tabela + "'" +
          " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
          " and '" + vtvt + "' <= vdo  order by sifIST,tabela,rbrgreske; "

        Dim ssql As String = sqlISTPolja + sqlISTLK

        Dim ds As New System.Data.DataSet
        ds = izvrsiSQLvratiDS(ssql, Me.ISTConnectionString, Nothing)

        Me.dsIST.ISTPOLJA.Clear()

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Me.dsIST.ISTPOLJA.ImportRow(ds.Tables(0).Rows(i))
        Next

        If Me.dsIST.ISTPOLJA.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt274 As String = getMessageText(dtMessages, "274", Me.jezik)
            'Throw New System.Exception(msgtxt274)
            ISTMessageBox.Show(msgtxt274)
        End If

        Me.dsIST.ISTLK.Clear()

        For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
            Me.dsIST.ISTLK.ImportRow(ds.Tables(1).Rows(i))
        Next

        If Me.dsIST.ISTLK.Rows.Count = 0 Then
            ''msg 275
            Dim msgtxt275 As String = getMessageText(dtMessages, "275", Me.jezik)
            ISTMessageBox.Show(msgtxt275, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            For i As Integer = 0 To Me.dsIST.ISTLK.Rows.Count - 1
                Dim ppp As String = ""
                If Not (Me.dsIST.ISTLK.Rows(i).Item("uslov").GetType Is GetType(System.DBNull) OrElse Me.dsIST.ISTLK.Rows(i).Item("uslov").Trim = "") Then
                    ppp = Me.dsIST.ISTLK.Rows(i).Item("uslov").trim.toupper
                    If ppp.IndexOf("LKVELIKA") < 0 AndAlso ppp.IndexOf("LKUNOS") < 0 AndAlso ppp.IndexOf("EXECUTEONLYONDATAENTRYFORM") < 0 AndAlso ppp.IndexOf("EXECUTEONLYFROMDATAVALIDATIONMODULE") < 0 AndAlso ppp.IndexOf("EXECUTEONLYONADDEDBUTTONCONTROL") < 0 AndAlso ppp.IndexOf("DONTSAVE") < 0 AndAlso ppp.IndexOf("DONTSEND") < 0 Then
                        Me.dsIST.ISTLK.Rows(i).Item("uslov") = ""
                    End If
                End If
            Next
        End If

    End Sub

    Sub fISTTABELE(ByVal ds As DatasetIstrazivanja, ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String, ByVal tabela As String)

        Dim sql As String = ""

        sql = "select * from ISTTabele where sifIST=N'" + appStaraApl.Trim + "' and tabela=N'" + tabela + "'" +
                    " and vod <= Convert(DateTime, DateAdd(Month, DateDiff(Month, 0, '" + vtvt + "'), 0), 126) " +
                    " and '" + vtvt + "' <= vdo and isnull(T1,'') not like '%ISTVIEW%'" +
                    " order by baza"


        Try
            Dim dtIST As System.Data.DataTable = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)
            ds.ISTTABELE.Clear()

            For i As Integer = 0 To dtIST.Rows.Count - 1
                ds.ISTTABELE.ImportRow(dtIST.Rows(i))
            Next

            'ovo ne sme jer nece davati dobro za backup
            'For i As Integer = 0 To ds.ISTTABELE.Rows.Count - 1
            '    ds.ISTTABELE.Rows(i)("DG") = "G"
            'Next
            'For i As Integer = 0 To ds.ISTTABELE.Rows.Count - 1
            '    ds.ISTTABELE.Rows(i)("NadTabela") = ""
            'Next

        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub fISTOstalo(ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String, ByVal tabela As String)

        If Me.dsIST.ISTTABELE.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt2741 As String = getMessageText(dtMessages, "2741", Me.jezik)
            ISTMessageBox.Show(msgtxt2741)
            Exit Sub
        End If

        Dim sqlISTAWLs As String = ""
        Dim sqlISTQuestionExplanation As String = ""
        Dim sqlISTLabels As String = ""

        Dim sqlISTABS As String = "select * from ISTTabs where sifist in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
        " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
        " and '" + vtvt + "' <= vdo  " +
        " order by sifist,rbrTabele;"

        Dim sqlISTMessages As String = " select * from ISTMessages where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
            " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
            " and '" + vtvt + "' <= vdo  " +
            " order by IDLang,IDMsg;"


        'tabele koje postoje u ISTTabele
        Dim ttabele As String = ""
        For i As Integer = 0 To Me.dsIST.ISTTABELE.Rows.Count - 1
            ttabele = ttabele + "'" + DirectCast((Me.dsIST.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
        Next
        ttabele = ttabele.TrimEnd(CType(",", Char()))

        sqlISTAWLs = "select * from ISTAWLs " +
             " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ") and tabela=N'" + tabela + "'" +
             " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
             " and '" + vtvt + "' <= vdo  " +
             " order by tabela,polje;"
        sqlISTQuestionExplanation = "select * from ISTQuestionExplanation " +
             " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ") and tabela=N'" + tabela + "'" +
             " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
             " and '" + vtvt + "' <= vdo  " +
             " order by tabela,polje;"
        sqlISTLabels = "select * from ISTLabels " +
             " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ") and tabela=N'" + tabela + "'" +
             " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
             " and '" + vtvt + "' <= vdo  " +
             " order by tabela,polje;"

        Dim ssql As String = sqlISTABS + sqlISTAWLs + sqlISTQuestionExplanation + sqlISTLabels + sqlISTMessages

        Dim ds As System.Data.DataSet = izvrsiSQLvratiDS(ssql, Me.ISTConnectionString, Nothing)
        If app <> appStaraApl Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i)("sifIST") = app
            Next
        End If
        Me.dsIST.ISTTABS.Clear()
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Me.dsIST.ISTTABS.ImportRow(ds.Tables(0).Rows(i))
        Next

        Try
            mdtAWL = ds.Tables(1)

        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtQE = ds.Tables(2)

        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtLabel = ds.Tables(3)

        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtMessage = ds.Tables(4)
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtMessage.Rows.Count - 1
                    mdtMessage.Rows(i)("sifIST") = app
                Next
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub cboTipAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipAT.SelectedIndexChanged
        If cboTipAT.SelectedIndex = 1 Then   'D
            cboNadTabelaAT.Visible = True
            Call popuniNDcbo(cboNadTabelaAT)
        Else
            cboNadTabelaAT.Visible = False
        End If
    End Sub

    Private Sub llCPtextFromExcel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llC1.LinkClicked, llC2.LinkClicked, llC3.LinkClicked,
        llC4.LinkClicked, llC5.LinkClicked, llC8.LinkClicked, llC9.LinkClicked
        Dim ISTtabela As String = Replace(txtCLAC.Text, "add column to table:", "", 1, , CompareMethod.Text).Trim
        If ISTtabela = "" Then ISTMessageBox.Show("Select table!") : Exit Sub

        Dim strSQl As String = " select distinct 'Screen form     ' + cast(f1 as char)  as displaymember,f1  as valuemember " +
                                " from vrepISTPolja " +
                                " where sifist=N'" + appCode + "' and tabela=N'" + ISTtabela + "'"

        Dim strSQl2 As String = " select ''  as displaymember,''  as valuemember "

        If sender.tag = "1" Then
            dgvCPE.AccessibleDescription = "LABEL"
            strSQl = strSQl + " and pp='lbl'"
        ElseIf sender.tag = "2" Then
            dgvCPE.AccessibleDescription = "VF"
            strSQl = strSQl + " and pp='lbl'"
        ElseIf sender.tag = "3" Then
            dgvCPE.AccessibleDescription = "NAME"
        ElseIf sender.tag = "4" Then
            dgvCPE.AccessibleDescription = "AWL"
        ElseIf sender.tag = "5" Then
            strSQl = strSQl + " and pp='lbl'"
            dgvCPE.AccessibleDescription = "FPLABELMULTILANGUAGE"
            'ElseIf sender.tag = "6" Then
            '    strSQl = strSQl2
            '    dgvCPE.AccessibleDescription = "TABLEDESCRIPTION"
        ElseIf sender.tag = "7" Then
            strSQl = strSQl + " and pp='lbl'"
            dgvCPE.AccessibleDescription = "LABELMULTILANGUAGE"
        ElseIf sender.tag = "8" Then
            dgvCPE.AccessibleDescription = "MESSAGEMULTILANGUAGE"
        ElseIf sender.tag = "9" Then
            dgvCPE.AccessibleDescription = "QUESTIONEXPLANATION"
        End If

        Call popunicbo(cboCPE, strSQl, Me.ISTConnectionString, , True)
        Me.cboCPE.Visible = True
        Me.cboCPE.Focus()
    End Sub

    Private Sub llC6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llC6.LinkClicked
        dgvCPE.AccessibleDescription = "TABLEDESCRIPTION"
        Me.PanelCPE.Dock = DockStyle.Fill
        Me.PanelCPE.Visible = True
        Call fillDGV()
    End Sub

    Private Sub llC8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llC8.LinkClicked
        dgvCPE.AccessibleDescription = "MESSAGEMULTILANGUAGE"
        Me.PanelCPE.Dock = DockStyle.Fill
        Me.PanelCPE.Visible = True
        Call fillDGV()
    End Sub

    Private Sub btnOKCPE_Click(sender As Object, e As EventArgs) Handles btnOKCPE.Click

        Dim dt As DataTable = Me.dgvCPE.DataSource
        Dim pDB As String = "ok" : Dim pIST As String = "ok"
        Dim ppNOK As Boolean = False
        Dim sta As String = Me.dgvCPE.AccessibleDescription.Trim.ToUpper

        Try
            Dim db As Boolean = False
            Dim str As String = ""
            Dim strDB As String = ""
            Dim sqlDBDropTip As String = "" : Dim DropTip As String = ""
            Dim por As String = "" : Dim porDB As String = ""

            pDB = "ok" : pIST = "ok"
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim sifist As String = dt.Rows(i).Item("appCode").ToString.Trim

                Dim polje As String = ""
                If sta <> "TABLEDESCRIPTION" AndAlso sta <> "MESSAGEMULTILANGUAGE" Then polje = dt.Rows(i).Item("field").ToString.Trim
                'If sta <> "MESSAGEMULTILANGUAGE" Then tabela = dt.Rows(i).Item("_table").ToString

                Dim vvod As String = dt.Rows(i).Item("validFrom").ToString
                Dim ttext As String = dt.Rows(i).Item("text").ToString.Trim
                If ttext.Trim.StartsWith("'") AndAlso ttext.Trim.EndsWith("'") Then ttext = ttext.Substring(1, Len(ttext) - 2)
                ttext = ttext.Replace("'", "''")

                If sta = "VF" AndAlso dt.Rows(i).Item("text").ToString.IndexOf("Text_") < 0 Then
                    Dim formatizraz As String = dt.Rows(i).Item("formatizraz").ToString.Trim
                    formatizraz = formatizraz.TrimEnd("$")
                    If ttext.Trim = "" Then ttext = "      "
                    str = str + " update istpolja set izraz = N'" + formatizraz + "$''" + ttext + "''' " +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + tabela + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" +
                           Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';" + nvrd

                    por = "Error. IST Is Not updated! Virtual filed values are not updated"

                End If

                If sta = "LABEL" Then
                    Dim formatopis As String = dt.Rows(i).Item("formatopis").ToString.Trim
                    formatopis = formatopis.TrimEnd("$")
                    str = str + " update istpolja set opis = N'" + formatopis + "$" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + tabela + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" +
                           Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';" + nvrd

                    por = "Error. IST Is Not updated! Rename for labels are not done"

                End If

                If sta = "AWL" Then
                    Dim onF1awls As String = ""
                    If Not (dt.Rows(i).Item(11) Is System.DBNull.Value) AndAlso dt.Rows(i).Item(11).ToString.Trim <> "" Then onF1awls = ", onF1=1"
                    If (dt.Rows(i).Item(11) Is System.DBNull.Value) Then onF1awls = ", onF1=Null"

                    Dim qmt As String = dt.Rows(i).Item("qmt").ToString.Trim
                    Dim sort As String = dt.Rows(i).Item("sort").ToString.Trim

                    str = str + " update istAwls set ttext = N'" + ttext + "'" + onF1awls + ",'" + qmt + "'," + sort + "" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + tabela + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" +
                           Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString + "' and IDAwl=" + dt.Rows(i).Item("IDAwl").ToString + ";" + nvrd

                    por = "Error. IST Is Not updated! Awl values for fields are not updated"

                End If

                If sta = "QUESTIONEXPLANATION" Then
                    str = str + " update ISTQuestionExplanation set ttext = N'" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + tabela + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString + "' and IDQuestionExplanation=" + dt.Rows(i).Item("IDQuestionExplanation").ToString + ";" + nvrd

                    por = "Error. IST Is Not updated! Question explanation values for fields are not updated"


                End If

                If sta = "FPLABELMULTILANGUAGE" Then
                    str = str + " update istLabels set ttext = N'" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + tabela + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString + "' and IDLabel=" + dt.Rows(i).Item("IDLabel").ToString + " and tip='fp';"

                    por = "Error. IST Is Not updated! Label (as virtual field) values for fields are not updated"

                End If

                If sta = "LABELMULTILANGUAGE" Then
                    str = str + " update istLabels set ttext = N'" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + tabela + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString + "' and IDLabel=" + dt.Rows(i).Item("IDLabel").ToString + " and tip='lbl';" + nvrd

                    por = "Error. IST Is Not updated! Label (as virtual field) values for fields are not updated"

                End If

                If sta = "TABLEDESCRIPTION" Then
                    str = str + " update istLabels set ttext = N'" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + tabela + "'" +
                           " and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString + "' and IDLabel=" + dt.Rows(i).Item("IDLabel").ToString + " and tip='td';" + nvrd

                    por = "Error. IST Is Not updated! Label (as virtual field) values for fields are not updated"

                End If

                If sta = "MESSAGEMULTILANGUAGE" Then
                    str = str + " update istMessages set ttext = N'" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "'" +
                           " and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString.Trim + "' and IDMsg='" + dt.Rows(i).Item("IDMsg").ToString.Trim + "';" + nvrd

                    por = "Error. IST Is Not updated! Messages' context are not updated"

                End If

                If sta = "NAME" Then
                    Dim currentName As String = dt.Rows(i).Item("fieldOrg").ToString.Trim
                    Dim newName As String = dt.Rows(i).Item("field").ToString.Trim
                    If currentName.Trim.ToUpper <> newName.Trim.ToUpper Then
                        Dim pp2 As String = dt.Rows(i).Item("typeF").ToString.Trim
                        Dim strWProvera As String = " where sifist=N'" + sifist + "' and tabela=N'" + tabela +
                            "' and polje=N'" + newName + "'" +
                            "  and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                        Dim strProvera As String = "select polje from istpolja " + strWProvera
                        Dim dtprovera As DataTable = izvrsiSQLvratiDT(strProvera, Me.ISTConnectionString, Nothing)
                        If dtprovera.Rows.Count > 0 Then
                            ppNOK = True
                            ISTMessageBox.Show("Error. Name " + newName + " already exists! Rename for " + newName + " is skipped!")
                        Else
                            If pp2.Trim.ToUpper <> "DATAGRIDVIEW" AndAlso pp2.Trim.ToUpper <> "LABEL" Then
                                db = True

                                strDB = strDB + " exec sp_rename N'" + tabela + "." + currentName + "', N'" + newName + "','COLUMN';" + nvrd
                                sqlDBDropTip = sqlDBDropTip + " exec sp_rename N'" + tabela + "." + newName + "', N'" + currentName + "','COLUMN';" + "#"
                                DropTip = DropTip + "RENAME" + "#"

                                porDB = "Error. IST Is Not updated! Rename for fields in DB are not done"
                            End If

                            str = str + " update istpolja set polje = N'" + newName + "'" +
                              " where sifist=N'" + sifist + "' and tabela=N'" + tabela + "'" +
                              " and polje=N'" + currentName + "' and cast (vod as date)='" +
                              Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" + ";" + nvrd

                            por = "Error. IST Is Not updated! Rename for fields are not done"

                        End If
                    End If
                End If
            Next

            If db = False Then
                pIST = napraviBackUpizvrsiSQLISTTABLES(str, "ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION;ISTLABELS;ISTMESSAGES")
                If pIST = "nok" Then ppNOK = True : ISTMessageBox.Show(por)
            End If
            If db = True Then
                pIST = napraviBackUpizvrsiSQLISTTABLES(str, "ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION;ISTLABELS;ISTMESSAGES", sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
                If pIST = "nok" Then ppNOK = True : ISTMessageBox.Show(por)
                pDB = izvrsiSQLDB(strDB, Me.DBConnectionString)
                If pDB = "nok" Then ISTMessageBox.Show(porDB)
            End If


            Me.Cursor = Cursors.Default

            If ppNOK = True Then
                Call fillDGV()
            Else
                Call closeCEP()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub
    Function napraviBackUpizvrsiSQLISTTABLES(ByVal strI As String, Optional ByVal isttabele As String = "", Optional ByVal slqDBDropTip As String = "", Optional ByVal DBDropTip As String = "") As String
        Dim DBtxt As String = ""
        If slqDBDropTip <> "" AndAlso DBDropTip <> "" Then
            Dim pp() As String = slqDBDropTip.Split("#")
            Dim ppDrop() As String = DBDropTip.Split("#")
            If pp.Length <> ppDrop.Length Then
                ISTMessageBox.Show("napraviBackUpizvrsiSQLISTTABLES" + nvrd + nvrd + "pp<>ppdrop")
            End If
            For i As Integer = 0 To pp.GetUpperBound(0)
                pp(i) = pp(i).TrimEnd("#")
                If ppDrop(i) = "DROP" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "ADD", Me.DBConnectionString)
                ElseIf ppDrop(i) = "ADD" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "DROP", Me.DBConnectionString)
                ElseIf ppDrop(i) = "ALTER COLUMN" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "ALTER COLUMN", Me.DBConnectionString)
                ElseIf ppDrop(i) = "RENAME" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "RENAME", Me.DBConnectionString)
                ElseIf ppDrop(i) = "DROPTABLE" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "DROPTABLE", Me.DBConnectionString)
                ElseIf ppDrop(i) = "ADDPK" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "ADDPK", Me.DBConnectionString)
                ElseIf ppDrop(i) = "DROPCONSTRAINT" Then
                    DBtxt = DBtxt + dbBackUpFile(pp(i), "DROPCONSTRAINT", Me.DBConnectionString)
                End If
            Next
        End If


        Call BackUp(dsIST, appCode, tabela, param(isttabele), DBtxt, "TABELE")

        'btnUndoVisible = True
        'btnUndo.Visible = True
        'btnRedoVisible = False
        'btnRedo.Visible = False

        Dim p As String = "nok"
        If strI <> "" Then
            strI = " begin transaction; " + nvrd + strI + nvrd + " commit;"
            p = izvrsiSQL(strI, Me.ISTConnectionString)
        Else
            p = "ok"
        End If

        'p = "ok"
        Return p
    End Function
    Private Sub btncancelCPE_Click(sender As Object, e As EventArgs) Handles btnCancelCPE.Click
        If ISTMessageBox.Show("Are you sure you want to exit without SAVE?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call closeCEP()
        End If
    End Sub

    Sub closeCEP()

        Me.PanelCPE.Dock = DockStyle.None
        Me.PanelCPE.Visible = False
        Me.cboCPE.Visible = False
    End Sub

    Private Sub cboCPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCPE.SelectedIndexChanged
        If cboCPE.SelectedValue <> "" Then
            Me.PanelCPE.Dock = DockStyle.Fill
            Me.PanelCPE.Visible = True
            Call fillDGV()
        End If
    End Sub

    Sub fillDGV()
        'Dim tab As String = Me.cboCPE.SelectedValue.ToString
        Dim strSQl As String = ""

        '0-7
        Dim sqlselect1 As String = "select sifist as appCode,tabela as _table,polje as field,rbr as ordinalNumber,vod as validFrom, cast(f1 as integer) as ttable, cast(f2 as integer)  as rrow, cast(f3 as integer)  as ccolumn,"
        Dim sqlfromwhereISTPolja As String = " from vrepISTPolja where sifist=N'" + appCode + "' and tabela=N'" + ttable + "'"
        Dim sqlfromwhereAWLS As String = " from vrepISTAWLs where sifist=N'" + appCode + "' and tabela=N'" + ttable + "'"
        Dim sqlfromwhereQE As String = " from  vrepISTQuestionExplanation where sifist=N'" + appCode + "' and tabela=N'" + ttable + "'"
        Dim sqlfromwhereLabelsFP As String = " from vrepISTLabels where sifist=N'" + appCode + "' and tabela=N'" + ttable + "' and tip='fp'"
        Dim sqlfromwhereLabelsLBL As String = " from vrepISTLabels where sifist=N'" + appCode + "' and tabela=N'" + ttable + "' and tip='lbl'"

        Dim sqlselect2 As String = "select sifist as appCode,tabela as _table,vod as validFrom,"
        Dim sqlfromwhereLabelsTD As String = " from vrepISTTableDescriptions where sifist=N'" + appCode + "' and tabela=N'" + ttable + "' and tip='td'"  'table description

        Dim sqlselect3 As String = "select sifist as appCode,vod as validFrom,"
        Dim sqlfromwhereMessages As String = " from ISTMessages where sifist=N'" + appCode + "'"

        If Not dgvCPE.AccessibleDescription Is Nothing Then
            If dgvCPE.AccessibleDescription.Trim.ToUpper = "LABEL" Then
                '8-10
                strSQl = sqlselect1 + " formatizraz, formatopis, opis as text " + sqlfromwhereISTPolja + " and pp ='tb'"
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "VF" Then
                '8-10
                strSQl = sqlselect1 + " formatizraz, formatopis, izrazTextBezNN as text " + sqlfromwhereISTPolja + " and pp='lbl'"
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "NAME" Then
                '8-10
                strSQl = sqlselect1 + " opis as label, pp2 as typeF, polje  as fieldOrg " + sqlfromwhereISTPolja
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "AWL" Then
                '8-11
                strSQl = sqlselect1 + " Idlang, IdAwl, qmt, sort, ttext as text, onF1 as [appears only when F1 is pressed (if true set 1)]" + sqlfromwhereAWLS
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "QUESTIONEXPLANATION" Then
                '8-11
                strSQl = sqlselect1 + " Idlang, IdQuestionExplanation, ttext as text " + sqlfromwhereQE
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "FPLABELMULTILANGUAGE" Then
                '8-10
                strSQl = sqlselect1 + " Idlang, IdLabel, ttext as text" + sqlfromwhereLabelsFP
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "TABLEDESCRIPTION" Then
                '8-10
                strSQl = sqlselect2 + " Idlang, IdLabel, ttext as text" + sqlfromwhereLabelsTD
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "LABELMULTILANGUAGE" Then
                '8-10
                strSQl = sqlselect1 + " Idlang, IdLabel, ttext as text" + sqlfromwhereLabelsLBL
            ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "MESSAGEMULTILANGUAGE" Then
                '8-10
                strSQl = sqlselect3 + " Idlang, IdMsg, ttext as text" + sqlfromwhereMessages
            End If
        Else
            Exit Sub
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "TABLEDESCRIPTION" Then
            strSQl = strSQl + " order by tabela "
        ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "MESSAGEMULTILANGUAGE" Then
            strSQl = strSQl + " order by IDlang,IDMsg "
        Else
            If Not (cboCPE.SelectedValue = "All") Then strSQl = strSQl + " and cast(f1 as int)= " + cboCPE.SelectedValue.ToString
            strSQl = strSQl + " order by rbr "
        End If

        'ttable
        Dim dt As DataTable = izvrsiSQLvratiDT(strSQl, Me.ISTConnectionString, Me.jezik)
        Me.dgvCPE.DataSource = dt

        dgvCPE.Columns("appCode").Visible = False

        dgvCPE.DefaultCellStyle.BackColor = SystemColors.ButtonFace

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "TABLEDESCRIPTION" Then
            dgvCPE.Columns("_table").ReadOnly = True
            dgvCPE.Columns("validFrom").ReadOnly = True
        ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper = "MESSAGEMULTILANGUAGE" Then
            dgvCPE.Columns("validFrom").ReadOnly = True
        Else
            dgvCPE.Columns("_table").Visible = False
            dgvCPE.Columns("field").ReadOnly = True
            dgvCPE.Columns("ordinalNumber").ReadOnly = True
            dgvCPE.Columns("validFrom").ReadOnly = True
            dgvCPE.Columns("ttable").ReadOnly = True
            dgvCPE.Columns("rrow").ReadOnly = True
            dgvCPE.Columns("ccolumn").ReadOnly = True
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "LABEL" Then
            'dgvCPE.Columns("text_for_label").DefaultCellStyle.BackColor = SystemColors.Window
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
            dgvCPE.Columns("formatizraz").Visible = False
            dgvCPE.Columns("formatopis").Visible = False
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "VF" Then
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
            dgvCPE.Columns("formatizraz").Visible = False
            dgvCPE.Columns("formatopis").Visible = False
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "NAME" Then
            dgvCPE.Columns("label").ReadOnly = True
            dgvCPE.Columns("typeF").ReadOnly = True
            dgvCPE.Columns("field").ReadOnly = False
            dgvCPE.Columns("field").DefaultCellStyle.BackColor = Color.AntiqueWhite
            dgvCPE.Columns("fieldOrg").Visible = False
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "AWL" Then
            dgvCPE.Columns("Idlang").ReadOnly = True
            dgvCPE.Columns("IDAwl").ReadOnly = True
            '- for multiply lines use <br>
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
            dgvCPE.Columns("appears only when F1 is pressed (if true set 1)").DefaultCellStyle.BackColor = Color.AntiqueWhite  '11
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "QUESTIONEXPLANATION" Then
            dgvCPE.Columns("Idlang").ReadOnly = True
            dgvCPE.Columns("IDQuestionExplanation").ReadOnly = True
            '- for multiply lines use <br>
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "FPLABELMULTILANGUAGE" OrElse dgvCPE.AccessibleDescription.Trim.ToUpper = "TABLEDESCRIPTION" OrElse dgvCPE.AccessibleDescription.Trim.ToUpper = "LABELMULTILANGUAGE" Then
            dgvCPE.Columns("Idlang").ReadOnly = True
            dgvCPE.Columns("IDLabel").ReadOnly = True
            '- for multiply lines use <br>
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
        End If
        If dgvCPE.AccessibleDescription.Trim.ToUpper = "MESSAGEMULTILANGUAGE" Then
            dgvCPE.Columns("Idlang").ReadOnly = True
            dgvCPE.Columns("IDMsg").ReadOnly = True
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
        End If

        'If dgvCPE.AccessibleDescription.Trim.ToUpper = "NAME" Then
        '    dgvCPE.Columns("fieldOrg").Visible = False
        'ElseIf dgvCPE.AccessibleDescription.Trim.ToUpper <> "NAME" AndAlso dgvCPE.AccessibleDescription.Trim.ToUpper <> "AWL" Then
        '    dgvCPE.Columns("formatizraz").Visible = False
        '    dgvCPE.Columns("formatopis").Visible = False
        'End If

        Me.dgvCPE.Tag = dt
    End Sub

    Private Sub dgvCPE_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCPE.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            Dim tb As TextBox = TryCast(e.Control, TextBox)

            'Remove Event handler keyPress early add if any
            RemoveHandler tb.KeyPress, AddressOf tb_KeyPress

            '11=onF1
            If dgvCPE.AccessibleDescription.Trim.ToUpper = "AWL" AndAlso Me.dgvCPE.CurrentCell.ColumnIndex = 11 Then
                AddHandler tb.KeyPress, AddressOf tb_KeyPress
            End If
        End If
    End Sub

    Private Sub tb_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Or (Char.IsDigit(e.KeyChar) And e.KeyChar <> "1"c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub dgvCPE_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCPE.KeyDown
        Try
            If e.Control And (e.KeyCode = Keys.C) Then
                Dim d As DataObject = dgvCPE.GetClipboardContent()
                Clipboard.SetDataObject(d)
                e.Handled = True
            ElseIf (e.Control And e.KeyCode = Keys.V) Then
                PasteUnboundRecords()
            End If
        Catch ex As Exception
            'Log Exception
        End Try
    End Sub

    Private Sub PasteUnboundRecords()

        Try

            Dim rowLines As String() = Clipboard.GetText(TextDataFormat.UnicodeText).Split(New String(0) {vbCr & vbLf}, StringSplitOptions.None)
            Dim currentRowIndex As Integer = (If(dgvCPE.CurrentRow IsNot Nothing, dgvCPE.CurrentRow.Index, 0))
            Dim currentColumnIndex As Integer = (If(dgvCPE.CurrentCell IsNot Nothing, dgvCPE.CurrentCell.ColumnIndex, 0))
            Dim currentColumnCount As Integer = dgvCPE.Columns.Count

            dgvCPE.AllowUserToAddRows = False
            For rowLine As Integer = 0 To rowLines.Length - 1

                If rowLine = rowLines.Length - 1 AndAlso String.IsNullOrEmpty(rowLines(rowLine)) Then
                    Exit For
                End If

                Dim columnsData As String() = rowLines(rowLine).Split(New String(0) {vbTab}, StringSplitOptions.None)
                If (currentColumnIndex + columnsData.Length) > dgvCPE.Columns.Count Then
                    For columnCreationCounter As Integer = 0 To ((currentColumnIndex + columnsData.Length) - currentColumnCount) - 1
                        If columnCreationCounter = rowLines.Length - 1 Then
                            Exit For
                        End If
                    Next
                End If
                If dgvCPE.Rows.Count > (currentRowIndex + rowLine) Then
                    For columnsDataIndex As Integer = 0 To columnsData.Length - 1
                        If currentColumnIndex + columnsDataIndex <= dgvCPE.Columns.Count - 1 Then
                            dgvCPE.Rows(currentRowIndex + rowLine).Cells(currentColumnIndex + columnsDataIndex).Value = columnsData(columnsDataIndex)
                        End If
                    Next
                Else
                    Dim pasteCells As String() = New String(dgvCPE.Columns.Count - 1) {}
                    For cellStartCounter As Integer = currentColumnIndex To dgvCPE.Columns.Count - 1
                        If columnsData.Length > (cellStartCounter - currentColumnIndex) Then
                            pasteCells(cellStartCounter) = columnsData(cellStartCounter - currentColumnIndex)
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            'Log Exception
        End Try

    End Sub

    Private Sub dgvCPE_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles dgvCPE.CellMouseDown
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dt As DataTable = dgv.DataSource
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim kol As String = dt.Columns(e.ColumnIndex).ColumnName  'bilo dt.Columns(e.ColumnIndex).Caption

            Dim kolTip As String = dt.Columns(e.ColumnIndex).DataType.Name
            Dim tip As String = ""
            If kolTip = "String" OrElse kolTip = "Char" Then
                tip = "S"
            ElseIf kolTip = "Decimal" OrElse kolTip = "Double" Then
                tip = "N"
            ElseIf kolTip = "Int16" OrElse kolTip = "Int32" OrElse kolTip = "Int64" Then
                tip = "N"
            ElseIf kolTip = "DateTime" Then
            ElseIf kolTip = "Boolean" Then
            End If

            If e.Button = MouseButtons.Right Then
                dgv.ClearSelection()
                dgv.CurrentCell = dgv(e.ColumnIndex, e.RowIndex)
                dgv.CurrentCell.Selected = True

                If dgv.Columns.Count < 100 Then
                    If tip = "S" Then dgv.ContextMenuStrip = mnuColumnText : mnuColumnText.Tag = kol
                    If tip = "N" Then dgv.ContextMenuStrip = mnuColumnNumber : mnuColumnNumber.Tag = kol
                Else
                    dgv.ContextMenuStrip = Nothing
                    ''msg 246
                    Dim msgtxt246 As String = getMessageText(dtMessages, "246", Me.jezik)
                    ''msg 247
                    Dim msgtxt247 As String = getMessageText(dtMessages, "247", Me.jezik)
                    ''msg 248
                    Dim msgtxt248 As String = getMessageText(dtMessages, "248", Me.jezik)
                    ''msg 249
                    Dim msgtxt249 As String = getMessageText(dtMessages, "249", Me.jezik)
                    Dim poruka As String = msgtxt246 + Str(dgv.ColumnCount).Trim + msgtxt247 + nvrd + nvrd
                    poruka = poruka + msgtxt248 + nvrd + msgtxt249
                    ISTMessageBox.Show(poruka, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Exit Sub
            End If
        Else
            dgv.ContextMenuStrip = Nothing
        End If

    End Sub

    Private Sub mnuColumnText_ItemClicked(ByVal sender As System.Object, ByVal e As ToolStripItemClickedEventArgs) Handles mnuColumnText.ItemClicked
        Dim dgv As DataGridView = dgvCPE
        'Dim dgvO As DataGridView = vidljiviGridO
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuColumnText.Tag

        Select Case f
            Case "DHIDE"
                dgv.Columns(k).Visible = False : dgv.Columns(k).Tag = "H"
            Case "DUNHIDE"
                For i As Integer = 0 To dgv.Columns.Count - 1
                    If dgv.Columns(i).Tag = "H" Then dgv.Columns(i).Visible = True : dgv.Columns(i).Tag = ""
                Next
            Case "DSORT"
                Select Case dgv.SortOrder
                    Case SortOrder.Ascending
                        dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                    Case Else
                        dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
                End Select
            Case "DMCS"
                Call multicolumnsort(dgv)
            Case "DFIND2"
                Call findDGV(dgv, k)
            Case "DFILTER"
                Call filterDGV(dgv, k)
            Case "DUNFILTERALL"
                Call funfilterDGV(dgv, k)
            Case "DFREEZE"
                dgv.Columns(k).Frozen = True
            Case "DUNFREEZEALL"
                For i As Integer = 0 To dgv.Columns.Count - 1
                    dgv.Columns(i).Frozen = False
                Next
            Case "DEQUALS"
                Dim vred As String = dgv.Item(k, dgv.CurrentRow.Index).Value.ToString.Trim.TrimStart("'").TrimEnd("'")
                Call fequals(dgv, k, vred, "S")
            Case "DDNEQUALS"
                Dim vred As String = dgv.Item(k, dgv.CurrentRow.Index).Value.ToString.Trim.TrimStart("'").TrimEnd("'")
                Call fdnequals(dgv, k, vred, "S")
            Case "DAFC2"
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Case "DAFW2"
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Case "DAFCH2"
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            Case "DACRW2"
                dgv.Columns(k).Width = 150
            Case Else
        End Select
    End Sub

    Private Sub mnuColumnNumber_ItemClicked(ByVal sender As System.Object, ByVal e As ToolStripItemClickedEventArgs) Handles mnuColumnNumber.ItemClicked
        Dim dgv As DataGridView = dgvCPE
        'Dim dgvO As DataGridView = vidljiviGridO
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuColumnNumber.Tag

        Select Case f
            Case "NHIDE"
                dgv.Columns(k).Visible = False : dgv.Columns(k).Tag = "H"
            Case "NUNHIDE"
                For i As Integer = 0 To dgv.Columns.Count - 1
                    If dgv.Columns(i).Tag = "H" Then dgv.Columns(i).Visible = True : dgv.Columns(i).Tag = ""
                Next
            Case "NSORT"
                Select Case dgv.SortOrder
                    Case SortOrder.Ascending
                        dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                    Case Else
                        dgv.Sort(dgv.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
                End Select
            Case "NMCS"
                Call multicolumnsort(dgv)
            Case "NFIND"
                Call findDGV(dgv, k)
            Case "NFILTER"
                Call filterNDGV(dgv, k)
            Case "NUNFILTERALL"
                Call funfilterDGV(dgv, k)
            Case "NFREEZE"
                dgv.Columns(k).Frozen = True : dgv.Columns(k).Tag = "F"
            Case "NUNFREEZEALL"
                For i As Integer = 0 To dgv.Columns.Count - 1
                    dgv.Columns(i).Frozen = False
                Next
            Case "NEQUALS"
                Dim vred As String = dgv.Item(k, dgv.CurrentRow.Index).Value.ToString.Trim
                Call fequals(dgv, k, vred, "N")
            Case "NDNEQUALS"
                Dim vred As String = dgv.Item(k, dgv.CurrentRow.Index).Value.ToString.Trim
                fdnequals(dgv, k, vred, "N")
            Case "NAFC"
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Case "NAFW"
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Case "NAFCH"
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
            Case "NACRW"
                dgv.Columns(k).Width = 150
            Case Else
        End Select
    End Sub

    Sub funfilterDGV(ByVal dg As DataGridView, ByVal k As String)
        Dim dt As DataTable = dgvCPE.Tag
        Me.dgvCPE.DataSource = dt
    End Sub

    Sub multicolumnsort(ByVal dg As DataGridView)
        If Not dgvCPE Is Nothing Then

            Dim dgvC As String = ""
            For Each dgvCol As DataGridViewColumn In dg.Columns
                dgvC = dgvC + dgvCol.HeaderText + "$"
            Next

            Dim fsort As New IstrazivanjaUnos.FormSort(Me, dgvC)
            Dim kako As String = ""
            Dim strOrderby As String = ""
            If fsort.ShowDialog() = DialogResult.OK Then
                strOrderby = fsort.SortOrder
                Dim dt As System.Data.DataTable
                dt = dg.DataSource
                Dim dv As New DataView(dt)
                dv.Sort = strOrderby
                dt = dv.ToTable()
                dg.DataSource = dt
            End If
        End If
    End Sub

    Sub findDGV(ByVal dg As DataGridView, ByVal k As String)
        Dim ffind As New IstrazivanjaUnos.FormFind(Me, dg, k, dg.Right, dg.Top)
        ffind.Show()
    End Sub

    Sub fequals(ByVal dg As DataGridView, ByVal k As String, ByVal c As String, ByVal tip As String)
        If Not dg Is Nothing Then

            Dim dt As System.Data.DataTable

            Dim dv As New DataView(dg.DataSource)

            Dim uslov As String = ""
            If tip = "S" Then uslov = k + " = '" + c + "'"
            If tip = "N" Then uslov = k + " = " + c + ""

            dv.RowFilter = uslov
            dt = dv.ToTable()
            dg.DataSource = dt

        End If
    End Sub

    Sub fdnequals(ByVal dg As DataGridView, ByVal k As String, ByVal c As String, ByVal tip As String)
        If Not dg Is Nothing Then

            Dim dt As System.Data.DataTable
            Dim dv As New DataView(dg.DataSource)

            Dim uslov As String = ""
            If tip = "S" Then uslov = k + " <> '" + c + "'"
            If tip = "N" Then uslov = k + " <> " + c + ""

            dv.RowFilter = uslov
            dt = dv.ToTable()
            dg.DataSource = dt

        End If
    End Sub

    Sub filterDGV(ByVal dg As DataGridView, ByVal k As String)
        If Not dg Is Nothing Then
            Dim ffilter As New IstrazivanjaUnos.FormFilterT(Me)
            Dim kako As String = ""
            Dim uslov As String = ""
            If ffilter.ShowDialog() = DialogResult.OK Then
                uslov = ffilter.Filter
                Dim dt As System.Data.DataTable
                Dim dv As New DataView(dg.DataSource)
                If uslov <> "" Then
                    If dv.Table.Columns(k).DataType.Name = "String" OrElse dv.Table.Columns(k).DataType.Name = "Char" Then
                        dv.RowFilter = k + uslov
                        dt = dv.ToTable()
                        dg.DataSource = dt
                    End If

                End If
                If dg.Name.Trim.ToUpper = "DGISTTABLES" Then dg.AllowUserToAddRows = False
            End If
        End If
    End Sub

    Sub filterNDGV(ByVal dg As DataGridView, ByVal k As String)
        If Not dg Is Nothing Then
            Dim ffilter As New IstrazivanjaUnos.FormFilterN(Me)
            Dim kako As String = ""
            Dim uslov As String = ""
            If ffilter.ShowDialog() = DialogResult.OK Then

                uslov = ffilter.Filter
                Dim dt As System.Data.DataTable
                Dim dv As New DataView(dg.DataSource)

                If uslov <> "" Then
                    If dv.Table.Columns(k).DataType.Name = "Decimal" OrElse
                            dv.Table.Columns(k).DataType.Name = "Int16" OrElse
                            dv.Table.Columns(k).DataType.Name = "Int32" OrElse
                            dv.Table.Columns(k).DataType.Name = "Int64" OrElse
                        dv.Table.Columns(k).DataType.Name = "Double" Then
                        If uslov.IndexOf(";") < 0 Then
                            dv.RowFilter = k + uslov
                        Else
                            Dim tt() As String = uslov.Split(";")
                            Dim u As String = ""
                            If tt(0).ToString.Trim <> "" Then u = k + " >= " + tt(0).ToString.Trim Else u = "2=2"
                            If tt(1).ToString.Trim <> "" Then u = u + " AND " + k + " <= " + tt(1).ToString.Trim
                            dv.RowFilter = u
                        End If

                        dt = dv.ToTable()
                        dg.DataSource = dt

                    End If

                End If
                If dg.Name.Trim.ToUpper = "DGISTTABLES" Then dg.AllowUserToAddRows = False

            End If
        End If
    End Sub

    Private Sub btnUC_Click(sender As Object, e As EventArgs) Handles btnUC.Click

        Dim ISTtabela As String = Replace(txtCLAC.Text, "add column to table:", "", 1, , CompareMethod.Text).Trim
        If ISTtabela = "" Then ISTMessageBox.Show("Select table!") : Exit Sub

        Dim rbr As Integer = 10
        Dim sqlRbr As String = "SELECT min(rbr) as mrbr FROM ISTPolja WHERE sifist=N'" + appCode + "' AND tabela=N'" + ISTtabela + "'"
        Dim dtRbr As New DataTable
        dtRbr = izvrsiSQLvratiDT(sqlRbr, Me.ISTConnectionString, Me.jezik)
        If dtRbr.Rows.Count > 0 AndAlso Not dtRbr.Rows(0).Item("mrbr") Is System.DBNull.Value Then rbr = CInt(dtRbr.Rows(0).Item("mrbr").ToString.Trim)

        If cbAddG.Checked = True Then Call pr("GOD", "4", rbr)
        If cbAddM.Checked = True Then Call pr("MES", "2", rbr + 1)
        If cbAddMB.Checked = True Then Call pr("MB", "8", rbr + 2)
        If cbAddY.Checked = True Then Call pr("ISTYEAR", "4", rbr)
        If cbAddMo.Checked = True Then Call pr("ISTMONTH", "2", rbr + 1)
        If cbAddE.Checked = True Then Call pr("ENTP", "8", rbr + 2)
        Me.gbUC.Visible = False
        Me.cbAddUC.Checked = False
    End Sub

    Private Sub cbAddUC_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddUC.CheckedChanged
        Me.gbUC.Visible = cbAddUC.Checked
    End Sub

    Private Sub cbAddG_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddG.CheckedChanged
        If cbAddG.Checked = True Then Me.cbAddY.Checked = False
    End Sub

    Private Sub cbAddY_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddY.CheckedChanged
        If cbAddY.Checked = True Then Me.cbAddG.Checked = False
    End Sub

    Private Sub cbAddM_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddM.CheckedChanged
        If cbAddM.Checked = True Then Me.cbAddMo.Checked = False
    End Sub

    Private Sub cbAddMo_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddMo.CheckedChanged
        If cbAddMo.Checked = True Then Me.cbAddM.Checked = False
    End Sub

    Private Sub cbAddMB_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddMB.CheckedChanged
        If cbAddMB.Checked = True Then Me.cbAddE.Checked = False
    End Sub

    Private Sub cbAddE_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddE.CheckedChanged
        If cbAddE.Checked = True Then Me.cbAddMB.Checked = False
    End Sub

    Sub pr(ByVal nname As String, ByVal duzIST As String, ByVal rbr As Integer)

        Dim sqlDB As String = ""
        Dim sqlIST As String = ""
        Dim sqlDBDropTip As String = ""
        Dim DropTip As String = ""
        Try

            Dim poostojiUDB As Boolean = False
            Dim sss As String = "SELECT name FROM sys.columns WHERE Name = N'" + nname + "' AND Object_ID = Object_ID(N'" + tabela + "')"
            Dim dt As New DataTable
            dt = izvrsiSQLvratiDT(sss, Me.DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then poostojiUDB = True

            Dim poostojiUIST As Boolean = False
            Dim sssI As String = "SELECT polje FROM ISTPolja WHERE sifist=N'" + appCode + "' and polje = N'" + nname + "' AND tabela=N'" + tabela + "'"
            Dim dtI As New DataTable
            dtI = izvrsiSQLvratiDT(sssI, Me.ISTConnectionString, Me.jezik)
            If dtI.Rows.Count > 0 Then poostojiUIST = True

            sqlDB = "ALTER TABLE " + tabela + " ADD " + nname + " CHAR (" + duzIST.Trim + ") NOT NULL;" + nvrd
            sqlDBDropTip = tabela + ";" + nname + "#"
            DropTip = "ADD" + "#"

            sqlIST = "insert into _ISTTablesColumns(appCode,tableName,columnName,primaryKey,label,orderNumber,columnType,columnLenght,ValidFrom,ValidTo,columnAtributes) VALUES (" +
                    "N'" + appCode + "',N'" + tabela + "',N'" + nname + "','P',N'" + nname + "','" +
                    CStr(rbr).Trim + "','char','" + duzIST + "','" + Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                    Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "',N'');" + nvrd

            sqlIST = sqlIST + "insert into ISTAwls(sifist,tabela,polje,vod,vdo,idlang,idawl,qmt,ttext,sort) VALUES (" +
                    "N'" + appCode + "',N'" + tabela + "',N'" + nname + "','" +
                    Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                    Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,'Q',N'awl for " + nname + "',1);" + nvrd

            sqlIST = sqlIST + "insert into ISTQuestionExplanation(sifist,tabela,polje,vod,vdo,idlang,idQuestionExplanation,ttext) VALUES (" +
                    "N'" + appCode + "',N'" + tabela + "',N'" + nname + "','" +
                    Me.txtvodAC.Value.ToString("yyyy-MM-dd") + "','" +
                    Me.txtvdoAC.Value.ToString("yyyy-MM-dd") + "','" + Me.jezik + "',1,N'Question explanation for " + nname + "');" + nvrd

            Dim pDB As String = "nok"
            Dim pIST As String = "nok"

            Dim errorDb As Boolean = False
            Dim errorIST As Boolean = False

            If poostojiUDB = False AndAlso poostojiUIST = False Then
                Dim p As String = postaviPK(nname, tabela)
                If p <> "~~" Then
                    Dim pp() As String = p.Split("~")
                    sqlDB = sqlDB + pp(0)
                    sqlDBDropTip = sqlDBDropTip + pp(1) + "#"
                    DropTip = DropTip + pp(2) + "#"
                End If

                pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, "ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION;ISTLABELS;ISTMESSAGES", sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If pIST = "nok" Then errorIST = True : ISTMessageBox.Show("Error. Not added in IST!")
                If pDB = "nok" Then errorDb = True : ISTMessageBox.Show("Error. Primary key Is Not added!")
            End If

            If poostojiUDB = True AndAlso poostojiUIST = False Then
                pIST = napraviBackUpizvrsiSQLISTTABLES(sqlIST, "ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION;ISTLABELS;ISTMESSAGES", sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
                If pIST = "nok" Then errorIST = True : ISTMessageBox.Show("Error. Not added in IST!")
            End If

            If poostojiUDB = False AndAlso poostojiUIST = True Then
                pIST = napraviBackUpizvrsiSQLISTTABLES("", "", sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
                pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If pDB = "nok" Then errorDb = True : ISTMessageBox.Show("Error. Not added in DB!")
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtCNAC_Enter(sender As Object, e As EventArgs) Handles txtCNAC.Enter
        Me.txtCNAC.SelectAll()
    End Sub

    Private Sub btnP21Cancel_Click(sender As Object, e As EventArgs) Handles btnP0Cancel.Click, btnP1Cancel.Click, btnP2Cancel.Click, btnP21Cancel.Click, btnP3Cancel.Click
        Dim b As Button = DirectCast(sender, Button)
        Call getAgainC(b.Tag)
        promenaVOD = False
    End Sub

    Sub getAgainC(ByVal P As Integer)
        Call rResetC()
        Dim dt As DataTable = getDTC()
        If dt.Rows.Count = 1 Then
            Call getVariablesC(dt)
            Try
                If P = 0 Then getMetaDataPaneP0()
                If P = 1 Then getMetaDataPaneP1()
                If P = 2 Then getMetaDataPaneP2()
                If P = 21 Then getMetaDataPaneP21()
                If P = 3 Then getMetaDataPaneP3()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAppC_Click(sender As Object, e As EventArgs) Handles btnAppC.Click

        If c0.Text.Trim = "" Then c0.Focus() : Exit Sub

        Dim kolone As String = c0.Text.Trim
        Dim izraz As String = ""
        Dim od As String = ""

        If c1.SelectedItem <> "" AndAlso c1.SelectedItem <> "Regular" Then izraz = izraz + "font" + c1.SelectedItem + "$"
        If c2.SelectedItem <> "" AndAlso c2.SelectedItem <> "Left" Then izraz = izraz + "f" + c2.SelectedItem + "A$"

        If c4.SelectedColor.Name = "Chocalate" Then c4.SelectedColor = Color.Chocolate
        If c4.SelectedColor.Name = "Lavander" Then c4.SelectedColor = Color.Lavender
        If c4.SelectedColor.Name = "Transparent" Then c4.SelectedColor = Color.Snow
        If c3.SelectedColor.Name = "Chocalate" Then c3.SelectedColor = Color.Chocolate
        If c3.SelectedColor.Name = "Lavander" Then c3.SelectedColor = Color.Lavender

        If c3.SelectedColor.Name <> "0" Then izraz = izraz + "foreColor" + c3.SelectedColor.Name + "$"
        If c4.SelectedColor.Name <> "0" Then izraz = izraz + "backColor" + c4.SelectedColor.Name + "$"
        If c5.SelectedItem = "None" Then
            izraz = izraz + "borderNone$"
        ElseIf c5.SelectedItem = "Fixed Single" Then
            izraz = izraz + "borderFixed$"
        End If
        If c6.Checked = True Then izraz = izraz + "ReadOnly$"
        izraz = izraz.TrimEnd("$")

        If c7.Text.Trim <> "" Then od = od + "min=" + c7.Text + ";"
        If c8.Text.Trim <> "" Then od = od + "max=" + c8.Text + ";"
        If c9.Text.Trim <> "" Then od = od + "MNLength=" + c9.Text + ";"
        If c10.Text.Trim <> "" Then od = od + "MXLength=" + c10.Text + ";"

        '        Numeric
        '        Alpha numeric
        '        Alpha
        '        Values separated by comma

        Dim yy As String = ""
        If c110.SelectedItem = "Numeric" Then
            yy = yy + "Numeric"
        ElseIf c110.SelectedItem = "Alpha numeric" Then
            yy = yy + "AlphaNumeric"
        ElseIf c110.SelectedItem = "Alpha" Then
            yy = yy + "Alpha"
        ElseIf c110.SelectedItem = "Date" Then
            yy = yy + "Date"
        ElseIf c110.SelectedItem = "ISTDate" Then
            yy = yy + "ISTDate"
        ElseIf c110.SelectedItem = "Time" Then
            yy = yy + "Time"
        ElseIf c110.SelectedItem = "Values separated by comma" Then
            If c11.Text.Trim <> "" Then yy = yy + c11.Text + ""
        End If
        If yy <> "" Then od = od + "Yes=" + yy + ";"

        Dim nn As String = ""
        If c120.Checked = True Then nn = nn + ","
        If c12.Text.Trim <> "" Then nn = nn + c11.Text + ""
        If nn <> "" Then od = od + "No=" + nn + ";"

        dgvAppC.Rows.Add(New String() {kolone, izraz, od})

        Call emptyCs()

    End Sub

    Sub emptyCs()
        c0.Text = ""
        c7.Text = ""
        c8.Text = ""
        c9.Text = ""
        c10.Text = ""
        c110.SelectedIndex = -1
        c11.Visible = False
        c11.Text = ""

        c120.Checked = False
        c12.Text = ""
        c6.Checked = False

        c1.SelectedIndex = -1
        c2.SelectedIndex = -1
        c3.SelectedColor = System.Drawing.Color.Empty
        c4.SelectedColor = System.Drawing.Color.Empty
        c5.SelectedIndex = -1

    End Sub

    Private Sub btnAppR_Click(sender As Object, e As EventArgs) Handles btnAppR.Click

        If r0.Text.Trim = "" Then r0.Focus() : Exit Sub

        Dim redovi As String = r0.Text.Trim
        Dim izraz As String = ""
        Dim od As String = ""

        If r1.SelectedItem <> "" AndAlso r1.SelectedItem <> "Regular" Then izraz = izraz + "font" + r1.SelectedItem + "$"
        If r2.SelectedItem <> "" AndAlso r2.SelectedItem <> "Left" Then izraz = izraz + "f" + r2.SelectedItem + "A$"

        If r4.SelectedColor.Name = "Chocalate" Then r4.SelectedColor = Color.Chocolate
        If r4.SelectedColor.Name = "Lavander" Then r4.SelectedColor = Color.Lavender
        If r4.SelectedColor.Name = "Transparent" Then r4.SelectedColor = Color.Snow
        If r3.SelectedColor.Name = "Chocalate" Then r3.SelectedColor = Color.Chocolate
        If r3.SelectedColor.Name = "Lavander" Then r3.SelectedColor = Color.Lavender

        If r3.SelectedColor.Name <> "0" Then izraz = izraz + "foreColor" + r3.SelectedColor.Name + "$"
        If r4.SelectedColor.Name <> "0" Then izraz = izraz + "backColor" + r4.SelectedColor.Name + "$"
        If r5.SelectedItem = "None" Then
            izraz = izraz + "borderNone$"
        ElseIf r5.SelectedItem = "Fixed Single" Then
            izraz = izraz + "borderFixed$"
        End If
        If r6.Checked = True Then izraz = izraz + "ReadOnly$"
        izraz = izraz.TrimEnd("$")

        If r7.Text.Trim <> "" Then od = od + "min=" + r7.Text + ";"
        If r8.Text.Trim <> "" Then od = od + "max=" + r8.Text + ";"
        If r9.Text.Trim <> "" Then od = od + "MNLength=" + r9.Text + ";"
        If r10.Text.Trim <> "" Then od = od + "MXLength=" + r10.Text + ";"

        '        Numeric
        '        Alpha numeric
        'Alpha
        '        Values separated by comma

        Dim yy As String = ""
        If r110.SelectedItem = "Numeric" Then
            yy = yy + "Numeric"
        ElseIf r110.SelectedItem = "Alpha numeric" Then
            yy = yy + "AlphaNumeric"
        ElseIf r110.SelectedItem = "Alpha" Then
            yy = yy + "Alpha"
        ElseIf r110.SelectedItem = "Date" Then
            yy = yy + "Date"
        ElseIf r110.SelectedItem = "ISTDate" Then
            yy = yy + "ISTDate"
        ElseIf r110.SelectedItem = "Time" Then
            yy = yy + "Time"
        ElseIf r110.SelectedItem = "Values separated by comma" Then
            If r11.Text.Trim <> "" Then yy = yy + r11.Text + ""
        End If
        If yy <> "" Then od = od + "Yes=" + yy + ";"

        Dim nn As String = ""
        If r120.Checked = True Then nn = nn + ","
        If r12.Text.Trim <> "" Then nn = nn + r11.Text + ""
        If nn <> "" Then od = od + "No=" + nn + ";"

        dgvAppR.Rows.Add(New String() {redovi, izraz, od})

        Call emptyRs()

    End Sub

    Sub emptyRs()
        r0.Text = ""
        r7.Text = ""
        r8.Text = ""
        r9.Text = ""
        r10.Text = ""
        r110.SelectedIndex = -1
        r11.Visible = False
        r11.Text = ""

        r120.Checked = False
        r12.Text = ""
        r6.Checked = False

        r1.SelectedIndex = -1
        r2.SelectedIndex = -1
        r3.SelectedColor = System.Drawing.Color.Empty
        r4.SelectedColor = System.Drawing.Color.Empty
        r5.SelectedIndex = -1

    End Sub

    Private Sub btnCACCancel_Click(sender As Object, e As EventArgs) Handles btnACCancel.Click
        dgvAppC.DataSource = Nothing
    End Sub

    Private Sub c110_SelectedIndexChanged(sender As Object, e As EventArgs)
        If c110.SelectedItem = "Values separated by comma" Then
            c11.Visible = True
        Else
            c11.Visible = False
        End If
    End Sub

    Private Sub cbSAT_CheckedChanged(sender As Object, e As EventArgs) Handles cbSAT.CheckedChanged
        tbSAT.Visible = cbSAT.Checked
        If cbSAT.Checked = False Then tbSAT.Value = tbSAT.Tag
    End Sub

    Private Sub cbHAT_CheckedChanged(sender As Object, e As EventArgs) Handles cbHAT.CheckedChanged
        tbHAT.Visible = cbHAT.Checked
        If cbHAT.Checked = False Then tbHAT.Value = tbHAT.Tag
    End Sub

    Private Sub cbCNIterate_CheckedChanged(sender As Object, e As EventArgs) Handles chbRowsStartFrom.CheckedChanged
        Me.txtRowsStartFrom.Visible = Me.chbRowsStartFrom.Checked
        If Me.chbRowsStartFrom.Checked = True Then
            txtRowsStartFrom.Focus()
            txtRowsStartFrom.Text = ""
        Else
            txtRowsStartFrom.Text = ""
        End If
    End Sub

    Private Sub cbCN_CheckedChanged(sender As Object, e As EventArgs) Handles chbColumnsStartFrom.CheckedChanged
        Me.txtColumnsStartFrom.Visible = Me.chbColumnsStartFrom.Checked
        If Me.chbColumnsStartFrom.Checked = True Then
            txtColumnsStartFrom.Focus()
            txtColumnsStartFrom.Text = ""
        Else
            txtColumnsStartFrom.Text = ""
        End If
    End Sub

    Private Sub btnTSubmit_Click(sender As Object, e As EventArgs) Handles btnTSubmit.Click
        Try
            Dim sqlTabele As String = txtTUpdate.Tag
            Dim pok As String = napraviBackUpizvrsiSQLISTTABLES(txtTUpdate.Text, sqlTabele)

            If pok = "ok" Then
                Me.txtTUpdate.Text = ""
                Me.txtTUpdate.Tag = ""
                Call TpaneSize()
            Else
                ISTMessageBox.Show(txtTUpdate.Text + nvrd + nvrd + "is not executed! ER75", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnCSubmit_Click(sender As Object, e As EventArgs) Handles btnCSubmit.Click
        Try
            Dim sqlTabele As String = txtCUpdate.Tag
            Dim pok As String = izvrsiSQL(txtCUpdate.Text, Me.ISTConnectionString)
            pok = napraviBackUpizvrsiSQLISTTABLES(txtCUpdate.Text, sqlTabele)

            If pok = "ok" Then
                Me.txtCUpdate.Text = ""
                Me.txtCUpdate.Tag = ""
                Call CpaneSize()
                promenaVOD = False
            Else
                ISTMessageBox.Show(txtCUpdate.Text + nvrd + nvrd + "is not executed! ER75", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbTc1_CheckedChanged(sender As Object, e As EventArgs) Handles cbTc1.CheckedChanged
        Me.cboFCAT.Visible = cbTc1.Checked
        If cbTc1.Checked = False Then
            cboFCAT.SelectedColor = System.Drawing.Color.Empty
        Else
            cboFCAT.Focus()
        End If
    End Sub

    Private Sub cbTc2_CheckedChanged(sender As Object, e As EventArgs) Handles cbTc2.CheckedChanged
        Me.cboBCAT.Visible = cbTc2.Checked
        If cbTc2.Checked = False Then
            cboBCAT.SelectedColor = System.Drawing.Color.Empty
        Else
            cboBCAT.Focus()
        End If
    End Sub

    Private Sub cbTc3_CheckedChanged(sender As Object, e As EventArgs) Handles cbTc3.CheckedChanged
        Me.cboBGCATe.Visible = cbTc3.Checked
        If cbTc3.Checked = False Then
            cboBGCATe.SelectedColor = System.Drawing.Color.Empty
        Else
            cboBGCATe.Focus()
        End If
    End Sub

    Private Sub cbTc4_CheckedChanged(sender As Object, e As EventArgs) Handles cbTc4.CheckedChanged
        cboBGCAT.Visible = cbTc4.Checked
        If cbTc4.Checked = False Then
            cboBGCAT.SelectedColor = System.Drawing.Color.Empty
        Else
            cboBGCAT.Focus()
        End If
    End Sub

    Private Sub cbTc5_CheckedChanged(sender As Object, e As EventArgs) Handles cbTc5.CheckedChanged
        Me.Mkc_tfc.Visible = cbTc5.Checked
        If cbTc5.Checked = False Then
            Mkc_tfc.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_tfc.Focus()
        End If
    End Sub

    Private Sub cbTc6_CheckedChanged(sender As Object, e As EventArgs) Handles cbTc6.CheckedChanged
        Me.Mkc_tbc.Visible = cbTc6.Checked
        If cbTc6.Checked = False Then
            Mkc_tbc.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_tbc.Focus()
        End If
    End Sub

    Private Sub chbBF_CheckedChanged(sender As Object, e As EventArgs) Handles chbBF.CheckedChanged
        If chbBF.Checked = True Then chbBN.Checked = False
    End Sub

    Private Sub chbBn_CheckedChanged(sender As Object, e As EventArgs) Handles chbBN.CheckedChanged
        If chbBN.Checked = True Then chbBF.Checked = False
    End Sub

    Private Sub chbRight_CheckedChanged(sender As Object, e As EventArgs) Handles chbRight.CheckedChanged
        If chbRight.Checked = True Then chbCentar.Checked = False
    End Sub

    Private Sub chbCentar_CheckedChanged(sender As Object, e As EventArgs) Handles chbCentar.CheckedChanged
        If chbCentar.Checked = True Then chbRight.Checked = False
    End Sub

    Private Sub chbMultiline_CheckedChanged(sender As Object, e As EventArgs) Handles chbMultiline.CheckedChanged
        If chbMultiline.Checked = True Then chbMultilineH.Checked = False : Me.txtMultilineH.Text = "" : Me.txtMultilineH.Visible = False
    End Sub

    Dim promenaVOD As Boolean
    Dim vrednostVOD As String

    Private Sub txtvod_Validating(sender As Object, e As CancelEventArgs) Handles txtvod.Validating
        Dim vv As String = txtvod.ToString.Trim
        If vv <> vrednostVOD Then
            promenaVOD = True
        Else
            promenaVOD = False
        End If
    End Sub

    Private Sub txtvod_Enter(sender As Object, e As EventArgs) Handles txtvod.Enter
        vrednostVOD = txtvod.ToString.Trim
    End Sub

    Private Sub btnCSubmitCancel_Click(sender As Object, e As EventArgs) Handles btnCSubmitCancel.Click
        promenaVOD = False
    End Sub

    Private Sub cbCopyT_CheckedChanged(sender As Object, e As EventArgs) Handles cbCopyT.CheckedChanged

        gbCopy.Visible = cbCopyT.Checked
        If cbCopyT.Checked = True Then
            Call popuniNDcbo2(cbCopy)
        Else
            Me.cbCopy.SelectedIndex = -1
            Me.cbCopyName.Text = ""
            Me.cbCopyMD.Checked = False
        End If
    End Sub

    Sub popuniNDcbo2(ByVal cbo As ComboBox)
        Dim strSQl As String = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" + cboIST.SelectedValue.ToString + "' and isnull(typeOfTableParentChild,'') not in ('S','A','K','O') order by 1"
        Call popunicbo(cbo, strSQl, Me.ISTConnectionString)
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If cbCopy.SelectedItem Is Nothing OrElse cbCopy.SelectedItem.ToString.Trim = "" Then
            ISTMessageBox.Show("Please, choose table!")
            cbCopy.Focus()
            Exit Sub
        End If

        If Me.cbCopyName.Text = "" Then
            ISTMessageBox.Show("Please, enter table name!")
            cbCopyName.Focus()
            Exit Sub
        End If

        Dim tt As String = cbCopy.SelectedValue.ToString.Trim
        Dim nname As String = cbCopyName.Text.Trim

        Dim poostojiUDB As Boolean = False
        Dim sss As String = "SELECT 1 FROM sys.Objects WHERE  Object_id = OBJECT_ID(N'" + nname + "') AND Type = N'U'"
        Dim dt As New DataTable
        dt = izvrsiSQLvratiDT(sss, Me.DBConnectionString, Me.jezik)
        If dt.Rows.Count > 0 Then poostojiUDB = True

        Dim poostojiUIST As Boolean = False
        Dim sssI As String = "SELECT tabela FROM ISTtabele WHERE tabela = N'" + nname + "' AND sifist=N'" + appCode + "'"
        Dim dtI As New DataTable
        dtI = izvrsiSQLvratiDT(sssI, Me.ISTConnectionString, Me.jezik)
        If dtI.Rows.Count > 0 Then poostojiUIST = True

        If poostojiUDB = True AndAlso poostojiUIST = True Then
            ISTMessageBox.Show("Name already exists in DB and in IST!")
            Me.cbCopyName.Focus()
            Me.cbCopyName.SelectAll()
            Exit Sub
        End If

        Dim sql As String = "SELECT top 0 * INTO " + nname + " FROM " + tt + " Where 1=2 "
        Dim p2 As String = izvrsiSQL(sql, Me.DBConnectionString)
        If p2 = "ok" Then
            sql = " SELECT c.name AS column_name, i.name AS index_name, c.is_identity FROM sys.indexes i " +
            " inner join sys.index_columns ic  ON i.object_id = ic.object_id AND i.index_id = ic.index_id " +
            " inner join sys.columns c On ic.object_id = c.object_id And c.column_id = ic.column_id " +
            " WHERE i.is_primary_key = 1 " +
            " and i.object_ID = OBJECT_ID('" + tt + "');"
            Dim dtPK As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

            Dim pk As String = ""
            For i As Integer = 0 To dtPK.Rows.Count - 1
                pk = pk + dtPK.Rows(i).Item("column_name").ToString.Trim + ","
            Next
            sql = "alter table " + nname + " add primary key (" + pk.TrimEnd(",") + ")"
            Dim sqlDBDropTip As String = nname + ";" + pk.TrimEnd(",")
            Dim DropTip As String = "ADDPK"
            Call napraviBackUpizvrsiSQLISTTABLES("", "", sqlDBDropTip, DropTip)
            p2 = izvrsiSQLDB(sql, Me.DBConnectionString)
            If p2 = "ok" Then
                ISTMessageBox.Show("Done!")
            Else
                ISTMessageBox.Show("Error!")
            End If
        Else
            ISTMessageBox.Show("Error!")
        End If

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim tt As String = cbCopy.SelectedValue.ToString.Trim
        Dim nname As String = cbCopyName.Text.Trim
        Dim sql As String = ""
        sql = sql + "insert into isttabele(SifIst,TABELA,DG,NadTabela,Opis,RbrUnos,BAZA,ABAZA,T1,T2,Vod,Vdo) " +
                         "select SIFIST,'" + nname + "' as tabela,DG,NadTabela,Opis,RbrUnos,BAZA,ABAZA,T1,T2,Vod,Vdo from isttabele where sifist=N'" + appCode + "' and tabela=N'" + tt + "';" + nvrd

        sql = sql + "insert into istpolja (SIFIST,TABELA,POLJE,KLJUC,RelBaza,RelTabela,RelPolje,VS,OD,DO,DG,Opis,rbr,tip,duzina,Forma,Vod,Vdo,Izraz) " +
             "select SIFIST,'" + nname + "' as tabela,POLJE,KLJUC,RelBaza,RelTabela,RelPolje,VS,OD,DO,DG,Opis,rbr,tip,duzina,Forma,Vod,Vdo,Izraz from istpolja where sifist=N'" + appCode + "' and tabela=N'" + tt + "';" + nvrd

        sql = sql + "insert into istawls (SIFIST,TABELA,POLJE,vod,vdo,idlang,idawl,qmt,ttext,sort) " +
             "select SIFIST,'" + nname + "' as tabela,POLJE,vod,vdo,idlang,idawl,qmt,ttext,sort from istawls where sifist=N'" + appCode + "' and tabela=N'" + tt + "';" + nvrd

        sql = sql + "insert into ISTQuestionExplanation (SIFIST,TABELA,POLJE,vod,vdo,idlang,idQuestionExplanation,ttext) " +
             "select SIFIST,'" + nname + "' as tabela,POLJE,vod,vdo,idlang,idawl,ttext from ISTQuestionExplanation where sifist=N'" + appCode + "' and tabela=N'" + tt + "';" + nvrd

        sql = sql + "insert into istLK (SIFIST,TABELA,RbrGreske,GRESKA,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo) " +
             "select SIFIST,'" + nname + "' as tabela,RbrGreske,GRESKA,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo from istLK where sifist=N'" + appCode + "' and tabela=N'" + tt + "';" + nvrd


        Dim p2 As String = napraviBackUpizvrsiSQLISTTABLES(sql, "ISTTABELE;ISTPOLJA;ISTAWLS;ISTQUESTIONEXPLANATION;ISTLK")
        If p2 = "ok" Then
            ISTMessageBox.Show("Done!")
        Else
            ISTMessageBox.Show("Error!")
        End If
    End Sub

    Private Sub cboNadTabelaAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboNadTabelaAT.SelectedIndexChanged
        If Not (cboNadTabelaAT.SelectedValue Is Nothing OrElse cboNadTabelaAT.SelectedValue.ToString.Trim = "") Then
            Dim vod As String = vodTabela(appCode, cboNadTabelaAT.SelectedValue).Split("$")(0)
            Dim vdo As String = vodTabela(appCode, cboNadTabelaAT.SelectedValue).Split("$")(1)
            Me.txtvodAT.Text = vod
            Me.txtvdoAT.Text = vdo
        End If
    End Sub

    Private Sub btnAddLang_Click(sender As Object, e As EventArgs) Handles btnAddLang.Click
        Dim sql As String = ""
        Dim por As String = ""

        If cbAwls.Checked = True AndAlso Me.clbLang.CheckedItems.Count > 0 Then
            For i As Integer = 0 To Me.clbLang.CheckedItems.Count - 1
                Dim jj As String = DirectCast((Me.clbLang.CheckedItems(i)), System.Data.DataRowView).Row.ItemArray(0).ToString
                sql = sql + "insert into ISTAwls (SIFIST,TABELA,POLJE,vod,IDLang,IDAwl,qmt,ttext,sort,vdo) " +
                " select SIFIST,TABELA,POLJE,vod,'" + jj + "' as IDLang,1 as IDAwl,'Q','awl_'+polje as ttext,1,vdo" +
                " from vrepistpolja a" +
                " where sifist=N'" + appCode + "' and tabela=N'" + tabela + "' and pp='tb' " +
                " and not exists(select * from istawls where sifist=a.sifist And TABELA=a.tabela" +
                " and POLJE=a.polje And vod=a.vod And idlang='" + jj + "');" + nvrd
            Next
            por = "Error! Always visual labels are NOT added!"
        End If

        If cbQE.Checked = True AndAlso Me.clbLang.CheckedItems.Count > 0 Then
            For i As Integer = 0 To Me.clbLang.CheckedItems.Count - 1
                Dim jj As String = DirectCast((Me.clbLang.CheckedItems(i)), System.Data.DataRowView).Row.ItemArray(0).ToString
                sql = sql + "insert into ISTQuestionExplanation (SIFIST,TABELA,POLJE,vod,IDLang,IDQuestionExplanation,ttext,vdo) " +
                " select SIFIST,TABELA,POLJE,vod,'" + jj + "' as IDLang,1 as IDQuestionExplanation,'qe_'+polje as ttext,vdo" +
                " from vrepistpolja a" +
                " where sifist=N'" + appCode + "' and tabela=N'" + tabela + "' and pp='tb' " +
                " and not exists(select * from ISTQuestionExplanation where sifist=a.sifist And TABELA=a.tabela" +
                " and POLJE=a.polje And vod=a.vod And idlang='" + jj + "');" + nvrd
            Next
            por = "Error! Always visual labels are NOT added!"
        End If

        If cbLabelVF.Checked = True AndAlso Me.clbLang.CheckedItems.Count > 0 Then
            For i As Integer = 0 To Me.clbLang.CheckedItems.Count - 1
                Dim jj As String = DirectCast((Me.clbLang.CheckedItems(i)), System.Data.DataRowView).Row.ItemArray(0).ToString
                sql = sql + "insert into ISTLabels (SIFIST,TABELA,POLJE,vod,IDLang,IDLabel,tip,ttext,vdo) " +
                " select SIFIST,TABELA,POLJE,vod,'" + jj + "' as IDLang,1 as IDLabel,'fp','lvf_'+polje as ttext,vdo" +
                " from vrepistpolja a" +
                " where sifist=N'" + appCode + "' and tabela=N'" + tabela + "' and pp='lbl' " +
                " and not exists(select * from ISTLabels where sifist=a.sifist And TABELA=a.tabela" +
                " and POLJE=a.polje And vod=a.vod And idlang='" + jj + "' and tip='fp');" + nvrd
            Next
            por = "Error! Labels are NOT added!"
        End If

        If cbTableDescription.Checked = True AndAlso Me.clbLang.CheckedItems.Count > 0 Then
            For i As Integer = 0 To Me.clbLang.CheckedItems.Count - 1
                Dim jj As String = DirectCast((Me.clbLang.CheckedItems(i)), System.Data.DataRowView).Row.ItemArray(0).ToString
                sql = sql + "insert into ISTLabels (SIFIST,TABELA,POLJE,vod,IDLang,IDLabel,tip,ttext,vdo) " +
                " select SIFIST,TABELA,'-' as POLJE,vod,'" + jj + "' as IDLang,1 as IDLabel,'td','ltd_'+TABELA as ttext,vdo" +
                " from vrepisttabele a" +
                " where sifist=N'" + appCode + "' and tabela=N'" + tabela + "'" +
                " and not exists(select * from ISTLabels where sifist=a.sifist And TABELA=a.tabela" +
                " and vod=a.vod And idlang='" + jj + "' and tip='td');" + nvrd
            Next
            por = "Error! table descriptions are NOT added!"
        End If

        If cbLabel.Checked = True AndAlso Me.clbLang.CheckedItems.Count > 0 Then
            For i As Integer = 0 To Me.clbLang.CheckedItems.Count - 1
                Dim jj As String = DirectCast((Me.clbLang.CheckedItems(i)), System.Data.DataRowView).Row.ItemArray(0).ToString
                sql = sql + "insert into ISTLabels (SIFIST,TABELA,POLJE,vod,IDLang,IDLabel,tip,ttext,vdo) " +
                " select SIFIST,TABELA,POLJE,vod,'" + jj + "' as IDLang,1 as IDLabel,'lbl','lbl_'+polje as ttext,vdo" +
                " from vrepistpolja a" +
                " where sifist=N'" + appCode + "' and tabela=N'" + tabela + "' " +   'ide za sve i za lbl i za tp.....
                " and not exists(select * from ISTLabels where sifist=a.sifist And TABELA=a.tabela" +
                " and POLJE=a.polje And vod=a.vod And idlang='" + jj + "' and tip='lbl');" + nvrd
            Next
            por = "Error! Labels are NOT added!"
        End If
        If cbMessage.Checked = True AndAlso Me.clbLang.CheckedItems.Count > 0 Then
            Dim maxCount As Integer = 0
            Dim vod As String = vodTabela(appCode, tabela).Split("$")(0)
            Dim vdo As String = vodTabela(appCode, tabela).Split("$")(1)
            For i As Integer = 0 To Me.clbLang.CheckedItems.Count - 1
                Dim jj As String = DirectCast((Me.clbLang.CheckedItems(i)), System.Data.DataRowView).Row.ItemArray(0).ToString
                Dim sqlCount As String = "select max(idMsg) as maxIDMsg from ISTMessages where sifist=N'" + appCode + "' and idlang='" + jj + "'"
                Dim dtMM As DataTable = izvrsiSQLvratiDT(sqlCount, Me.ISTConnectionString, Nothing)
                If dtMM.Rows.Count > 0 AndAlso dtMM.Rows(0).Item("maxIDMsg").ToString.Trim <> "" AndAlso dtMM.Rows(0).Item("maxIDMsg").ToString.Trim <> "0" AndAlso IsNumeric(dtMM.Rows(0).Item("maxIDMsg")) Then
                    maxCount = CInt(dtMM.Rows(0).Item("maxIDMsg").ToString.Trim)
                End If

                For r As Integer = maxCount + 1 To maxCount + 10
                    sql = sql + "insert into ISTMessages (SIFIST,vod,IDLang,IDMsg,ttext,vdo) " +
                         " values(N'" + appCode + "','" + vod + "','" + jj + "'," + CStr(r).Trim + ",'msg text','" + vdo + "');"
                Next
            Next
            por = "Error! messages are NOT added!"
        End If

        Dim p2 As String = napraviBackUpizvrsiSQLISTTABLES(sql, "ISTAWLS;ISTQUESTIONEXPLANATION;ISTLABELS;ISTMESSAGES")
        If p2 = "ok" Then
            ISTMessageBox.Show("Done.")
            Me.cbLabelVF.Checked = False
            Me.cbLabel.Checked = False
            Me.cbAwls.Checked = False
            Me.cbQE.Checked = False
            Me.cbMessage.Checked = False
            For i As Integer = 0 To Me.clbLang.Items.Count - 1
                clbLang.SetItemChecked(i, False)
            Next
            Me.clbLang.Visible = False
        Else
            ISTMessageBox.Show(por)
        End If

    End Sub

    Private Sub txtCNIterateStart_Leave(sender As Object, e As EventArgs) Handles txtRowsStartFrom.Leave
        Dim pp As String = txtRowsStartFrom.Text.Trim
        If pp <> "" AndAlso Not IsNumeric(pp) OrElse (IsNumeric(pp) AndAlso CInt(pp) < 1) Then
            ISTMessageBox.Show("'Rows start from' must be number greater then 0.")
            txtRowsStartFrom.Text = "1"
        End If
    End Sub

    Private Sub txtCNIStart_Leave(sender As Object, e As EventArgs) Handles txtColumnsStartFrom.Leave
        Dim pp As String = txtColumnsStartFrom.Text.Trim
        If pp <> "" AndAlso Not IsNumeric(pp) OrElse (IsNumeric(pp) AndAlso CInt(pp) < 1) Then
            ISTMessageBox.Show("'Columns start from' must be number greater then 0.")
            txtColumnsStartFrom.Text = "1"
        End If
    End Sub

    Private Sub cbAwls_CheckedChanged(sender As Object, e As EventArgs) Handles cbAwls.CheckedChanged
        If cbAwls.Checked = True Then
            cbLabelVF.Checked = False
            cbQE.Checked = False
            cbTableDescription.Checked = False
            cbLabel.Checked = False
            cbMessage.Checked = False
        End If
        clbLang.Visible = True
    End Sub

    Private Sub cbLabelVF_CheckedChanged(sender As Object, e As EventArgs) Handles cbLabelVF.CheckedChanged
        If cbLabelVF.Checked = True Then
            cbAwls.Checked = False
            cbQE.Checked = False
            cbTableDescription.Checked = False
            cbLabel.Checked = False
            cbMessage.Checked = False
        End If
        clbLang.Visible = True
    End Sub

    Private Sub cbTableDescription_CheckedChanged(sender As Object, e As EventArgs) Handles cbTableDescription.CheckedChanged
        If cbTableDescription.Checked = True Then
            cbAwls.Checked = False
            cbQE.Checked = False
            cbLabelVF.Checked = False
            cbLabel.Checked = False
            cbMessage.Checked = False
        End If
        clbLang.Visible = True
    End Sub

    Private Sub cbLabel_CheckedChanged(sender As Object, e As EventArgs) Handles cbLabel.CheckedChanged
        If cbLabel.Checked = True Then
            cbAwls.Checked = False
            cbQE.Checked = False
            cbLabelVF.Checked = False
            cbTableDescription.Checked = False
            cbMessage.Checked = False
        End If
        clbLang.Visible = True
    End Sub

    Private Sub cbMessagel_CheckedChanged(sender As Object, e As EventArgs) Handles cbMessage.CheckedChanged
        If cbMessage.Checked = True Then
            cbAwls.Checked = False
            cbQE.Checked = False
            cbLabelVF.Checked = False
            cbTableDescription.Checked = False
            cbLabel.Checked = False
        End If
        clbLang.Visible = True
    End Sub

    Private Sub cbQE_CheckedChanged(sender As Object, e As EventArgs) Handles cbQE.CheckedChanged
        If cbQE.Checked = True Then
            cbMessage.Checked = False
            cbAwls.Checked = False
            cbLabelVF.Checked = False
            cbTableDescription.Checked = False
            cbLabel.Checked = False
        End If
        clbLang.Visible = True
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Call deleteUNDOREDOPOLJA()
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

    Private Sub Form_IST_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SettingObjForTheme(GetTheme())
    End Sub
End Class