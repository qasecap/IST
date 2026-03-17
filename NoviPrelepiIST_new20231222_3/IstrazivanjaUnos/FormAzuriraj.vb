Option Strict Off
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net.WebRequestMethods
Imports System.Runtime.InteropServices
Imports IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
Imports System.Reflection
Imports System.Runtime.Remoting.Contexts
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Web.Script.Serialization
Imports MS.Internal
Imports System.Security.Cryptography
Imports System.Security.Policy

Public Class FormAzuriraj
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

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanelTABLE As TableLayoutPanel
    Friend WithEvents chbA As CheckBox
    Friend WithEvents ContextMenuBrisi As ContextMenu
    Friend WithEvents MenuItemBrisiTekuciRed As MenuItem
    Friend WithEvents MenuItemBrisiPrikazaneRedove As MenuItem
    Friend WithEvents ComboBoxTabele As ComboBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Btn_XML As Button
    Friend WithEvents ButtonIzborSlogova As Button
    Friend WithEvents Btn_Excel As Button
    Friend WithEvents ButtonBrisi As Button
    Friend WithEvents ButtonNoviSlog As Button
    Friend WithEvents ButtonUpitnik As Button
    Friend WithEvents btnNP As Button
    Friend WithEvents ButtonLK As Button
    Friend WithEvents ButtonAzurirajSlogUDGV As Button
    Friend WithEvents ButtonIzborKolona As Button
    Friend WithEvents PanelContext As Panel
    Friend WithEvents btn_SPSS As Button
    Friend WithEvents btn_JSON As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnPrazno As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents LabelTotalCount As Label
    Friend WithEvents tv As TreeView
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
    Friend WithEvents nacrw As ToolStripMenuItem
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
    Friend WithEvents DACRW As ToolStripMenuItem
    Friend WithEvents TabControlGreske As TabControl
    Friend WithEvents TabPageGreskeZaSlog As TabPage
    Friend WithEvents TabPageGreskeZaPrikazaneSlogove As TabPage
    Friend WithEvents TabPageGreskeZaCeluTabelu As TabPage
    Friend WithEvents btnLinijaRazmak As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnArrowDownHover As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents btnMenu As PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAzuriraj))
        Me.TableLayoutPanelTABLE = New System.Windows.Forms.TableLayoutPanel()
        Me.chbA = New System.Windows.Forms.CheckBox()
        Me.TabControlGreske = New System.Windows.Forms.TabControl()
        Me.TabPageGreskeZaSlog = New System.Windows.Forms.TabPage()
        Me.TabPageGreskeZaPrikazaneSlogove = New System.Windows.Forms.TabPage()
        Me.TabPageGreskeZaCeluTabelu = New System.Windows.Forms.TabPage()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ComboBoxTabele = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuBrisi = New System.Windows.Forms.ContextMenu()
        Me.MenuItemBrisiTekuciRed = New System.Windows.Forms.MenuItem()
        Me.MenuItemBrisiPrikazaneRedove = New System.Windows.Forms.MenuItem()
        Me.LabelTotalCount = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btn_SPSS = New System.Windows.Forms.Button()
        Me.btn_JSON = New System.Windows.Forms.Button()
        Me.Btn_XML = New System.Windows.Forms.Button()
        Me.ButtonIzborSlogova = New System.Windows.Forms.Button()
        Me.Btn_Excel = New System.Windows.Forms.Button()
        Me.ButtonBrisi = New System.Windows.Forms.Button()
        Me.ButtonNoviSlog = New System.Windows.Forms.Button()
        Me.ButtonUpitnik = New System.Windows.Forms.Button()
        Me.btnNP = New System.Windows.Forms.Button()
        Me.ButtonLK = New System.Windows.Forms.Button()
        Me.ButtonAzurirajSlogUDGV = New System.Windows.Forms.Button()
        Me.ButtonIzborKolona = New System.Windows.Forms.Button()
        Me.btnPrazno = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnArrowDownHover = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnLinijaRazmak = New System.Windows.Forms.Button()
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
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelTABLE.SuspendLayout()
        Me.TabControlGreske.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContext.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.mnuColumnNumber.SuspendLayout()
        Me.mnuColumnText.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanelTABLE
        '
        Me.TableLayoutPanelTABLE.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanelTABLE.ColumnCount = 1
        Me.TableLayoutPanelTABLE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTABLE.Controls.Add(Me.chbA, 0, 2)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.TabControlGreske, 0, 3)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.ProgressBar1, 0, 4)
        Me.TableLayoutPanelTABLE.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanelTABLE.Location = New System.Drawing.Point(2, 40)
        Me.TableLayoutPanelTABLE.Name = "TableLayoutPanelTABLE"
        Me.TableLayoutPanelTABLE.RowCount = 5
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.Size = New System.Drawing.Size(893, 747)
        Me.TableLayoutPanelTABLE.TabIndex = 0
        '
        'chbA
        '
        Me.chbA.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.chbA.Checked = True
        Me.chbA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chbA.Location = New System.Drawing.Point(3, 540)
        Me.chbA.Name = "chbA"
        Me.chbA.Size = New System.Drawing.Size(887, 20)
        Me.chbA.TabIndex = 175
        Me.chbA.Text = "Приказати у табели истраживања само колоне које су у услову грешке"
        Me.chbA.UseVisualStyleBackColor = False
        Me.chbA.Visible = False
        '
        'TabControlGreske
        '
        Me.TabControlGreske.Controls.Add(Me.TabPageGreskeZaSlog)
        Me.TabControlGreske.Controls.Add(Me.TabPageGreskeZaPrikazaneSlogove)
        Me.TabControlGreske.Controls.Add(Me.TabPageGreskeZaCeluTabelu)
        Me.TabControlGreske.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlGreske.HotTrack = True
        Me.TabControlGreske.Location = New System.Drawing.Point(3, 566)
        Me.TabControlGreske.Name = "TabControlGreske"
        Me.TabControlGreske.SelectedIndex = 0
        Me.TabControlGreske.Size = New System.Drawing.Size(887, 143)
        Me.TabControlGreske.TabIndex = 176
        Me.TabControlGreske.Visible = False
        '
        'TabPageGreskeZaSlog
        '
        Me.TabPageGreskeZaSlog.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPageGreskeZaSlog.Location = New System.Drawing.Point(4, 23)
        Me.TabPageGreskeZaSlog.Name = "TabPageGreskeZaSlog"
        Me.TabPageGreskeZaSlog.Size = New System.Drawing.Size(879, 116)
        Me.TabPageGreskeZaSlog.TabIndex = 0
        Me.TabPageGreskeZaSlog.Text = "Грешке за слог"
        '
        'TabPageGreskeZaPrikazaneSlogove
        '
        Me.TabPageGreskeZaPrikazaneSlogove.Location = New System.Drawing.Point(4, 23)
        Me.TabPageGreskeZaPrikazaneSlogove.Name = "TabPageGreskeZaPrikazaneSlogove"
        Me.TabPageGreskeZaPrikazaneSlogove.Size = New System.Drawing.Size(879, 116)
        Me.TabPageGreskeZaPrikazaneSlogove.TabIndex = 1
        Me.TabPageGreskeZaPrikazaneSlogove.Text = "Грешке за приказане слогове"
        '
        'TabPageGreskeZaCeluTabelu
        '
        Me.TabPageGreskeZaCeluTabelu.Location = New System.Drawing.Point(4, 23)
        Me.TabPageGreskeZaCeluTabelu.Name = "TabPageGreskeZaCeluTabelu"
        Me.TabPageGreskeZaCeluTabelu.Size = New System.Drawing.Size(879, 116)
        Me.TabPageGreskeZaCeluTabelu.TabIndex = 2
        Me.TabPageGreskeZaCeluTabelu.Text = "Грешке за целу табелу"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Window
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.ForeColor = System.Drawing.Color.SteelBlue
        Me.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 715)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(887, 29)
        Me.ProgressBar1.TabIndex = 174
        '
        'ComboBoxTabele
        '
        Me.ComboBoxTabele.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ComboBoxTabele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTabele.DropDownWidth = 600
        Me.ComboBoxTabele.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxTabele.FormattingEnabled = True
        Me.ComboBoxTabele.ItemHeight = 14
        Me.ComboBoxTabele.Location = New System.Drawing.Point(263, 9)
        Me.ComboBoxTabele.Name = "ComboBoxTabele"
        Me.ComboBoxTabele.Size = New System.Drawing.Size(357, 22)
        Me.ComboBoxTabele.TabIndex = 182
        Me.ComboBoxTabele.TabStop = False
        Me.ComboBoxTabele.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 20
        '
        'ContextMenuBrisi
        '
        Me.ContextMenuBrisi.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemBrisiTekuciRed, Me.MenuItemBrisiPrikazaneRedove})
        '
        'MenuItemBrisiTekuciRed
        '
        Me.MenuItemBrisiTekuciRed.Index = 0
        Me.MenuItemBrisiTekuciRed.Text = "&Текући ред"
        '
        'MenuItemBrisiPrikazaneRedove
        '
        Me.MenuItemBrisiPrikazaneRedove.Index = 1
        Me.MenuItemBrisiPrikazaneRedove.Text = "&Приказане редове"
        '
        'LabelTotalCount
        '
        Me.LabelTotalCount.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotalCount.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelTotalCount.ForeColor = System.Drawing.Color.DarkOrange
        Me.LabelTotalCount.Location = New System.Drawing.Point(631, 6)
        Me.LabelTotalCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTotalCount.Name = "LabelTotalCount"
        Me.LabelTotalCount.Size = New System.Drawing.Size(174, 29)
        Me.LabelTotalCount.TabIndex = 184
        Me.LabelTotalCount.Tag = "nediraj"
        Me.LabelTotalCount.Text = "Rows count: 1234567"
        Me.LabelTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelTotalCount.Visible = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnBack)
        Me.PanelMenu.Controls.Add(Me.Logovan)
        Me.PanelMenu.Controls.Add(Me.tv)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.btn_SPSS)
        Me.PanelMenu.Controls.Add(Me.btn_JSON)
        Me.PanelMenu.Controls.Add(Me.Btn_XML)
        Me.PanelMenu.Controls.Add(Me.ButtonIzborSlogova)
        Me.PanelMenu.Controls.Add(Me.Btn_Excel)
        Me.PanelMenu.Controls.Add(Me.ButtonBrisi)
        Me.PanelMenu.Controls.Add(Me.ButtonNoviSlog)
        Me.PanelMenu.Controls.Add(Me.ButtonUpitnik)
        Me.PanelMenu.Controls.Add(Me.btnNP)
        Me.PanelMenu.Controls.Add(Me.ButtonLK)
        Me.PanelMenu.Controls.Add(Me.ButtonAzurirajSlogUDGV)
        Me.PanelMenu.Controls.Add(Me.ButtonIzborKolona)
        Me.PanelMenu.Controls.Add(Me.btnPrazno)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button7)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(255, 787)
        Me.PanelMenu.TabIndex = 143
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(13, 711)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 33)
        Me.btnBack.TabIndex = 10000087
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Logovan
        '
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(0, 749)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(255, 18)
        Me.Logovan.TabIndex = 10000088
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tv
        '
        Me.tv.Location = New System.Drawing.Point(185, 694)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(47, 41)
        Me.tv.TabIndex = 10000085
        Me.tv.Visible = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(212, 5)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 36
        Me.btnMenu.TabStop = False
        '
        'btn_SPSS
        '
        Me.btn_SPSS.AccessibleName = ""
        Me.btn_SPSS.BackColor = System.Drawing.Color.Transparent
        Me.btn_SPSS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_SPSS.FlatAppearance.BorderSize = 0
        Me.btn_SPSS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_SPSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_SPSS.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_SPSS.ForeColor = System.Drawing.Color.White
        Me.btn_SPSS.Image = CType(resources.GetObject("btn_SPSS.Image"), System.Drawing.Image)
        Me.btn_SPSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SPSS.Location = New System.Drawing.Point(10, 650)
        Me.btn_SPSS.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_SPSS.Name = "btn_SPSS"
        Me.btn_SPSS.Size = New System.Drawing.Size(240, 38)
        Me.btn_SPSS.TabIndex = 34
        Me.btn_SPSS.Tag = "    Spss+txt"
        Me.btn_SPSS.Text = "    Spss+txt"
        Me.btn_SPSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_SPSS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_SPSS.UseVisualStyleBackColor = False
        Me.btn_SPSS.Visible = False
        '
        'btn_JSON
        '
        Me.btn_JSON.AccessibleName = "sakrij"
        Me.btn_JSON.BackColor = System.Drawing.Color.Transparent
        Me.btn_JSON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_JSON.FlatAppearance.BorderSize = 0
        Me.btn_JSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btn_JSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_JSON.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_JSON.ForeColor = System.Drawing.Color.White
        Me.btn_JSON.Image = CType(resources.GetObject("btn_JSON.Image"), System.Drawing.Image)
        Me.btn_JSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_JSON.Location = New System.Drawing.Point(10, 604)
        Me.btn_JSON.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_JSON.Name = "btn_JSON"
        Me.btn_JSON.Size = New System.Drawing.Size(240, 38)
        Me.btn_JSON.TabIndex = 32
        Me.btn_JSON.Tag = "    Json"
        Me.btn_JSON.Text = "    Json"
        Me.btn_JSON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_JSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_JSON.UseVisualStyleBackColor = False
        Me.btn_JSON.Visible = False
        '
        'Btn_XML
        '
        Me.Btn_XML.AccessibleName = "sakrij"
        Me.Btn_XML.BackColor = System.Drawing.Color.Transparent
        Me.Btn_XML.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_XML.FlatAppearance.BorderSize = 0
        Me.Btn_XML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Btn_XML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_XML.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_XML.ForeColor = System.Drawing.Color.White
        Me.Btn_XML.Image = CType(resources.GetObject("Btn_XML.Image"), System.Drawing.Image)
        Me.Btn_XML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_XML.Location = New System.Drawing.Point(10, 558)
        Me.Btn_XML.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_XML.Name = "Btn_XML"
        Me.Btn_XML.Size = New System.Drawing.Size(240, 38)
        Me.Btn_XML.TabIndex = 23
        Me.Btn_XML.Tag = "    Xml"
        Me.Btn_XML.Text = "    Xml"
        Me.Btn_XML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_XML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_XML.UseVisualStyleBackColor = False
        Me.Btn_XML.Visible = False
        '
        'ButtonIzborSlogova
        '
        Me.ButtonIzborSlogova.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIzborSlogova.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzborSlogova.FlatAppearance.BorderSize = 0
        Me.ButtonIzborSlogova.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonIzborSlogova.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIzborSlogova.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzborSlogova.ForeColor = System.Drawing.Color.White
        Me.ButtonIzborSlogova.Image = CType(resources.GetObject("ButtonIzborSlogova.Image"), System.Drawing.Image)
        Me.ButtonIzborSlogova.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzborSlogova.Location = New System.Drawing.Point(10, 144)
        Me.ButtonIzborSlogova.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonIzborSlogova.Name = "ButtonIzborSlogova"
        Me.ButtonIzborSlogova.Size = New System.Drawing.Size(240, 38)
        Me.ButtonIzborSlogova.TabIndex = 30
        Me.ButtonIzborSlogova.Text = "    Избор слогова"
        Me.ButtonIzborSlogova.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzborSlogova.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonIzborSlogova.UseVisualStyleBackColor = False
        '
        'Btn_Excel
        '
        Me.Btn_Excel.AccessibleName = "sakrij"
        Me.Btn_Excel.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Excel.FlatAppearance.BorderSize = 0
        Me.Btn_Excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Excel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Excel.ForeColor = System.Drawing.Color.White
        Me.Btn_Excel.Image = CType(resources.GetObject("Btn_Excel.Image"), System.Drawing.Image)
        Me.Btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Excel.Location = New System.Drawing.Point(10, 512)
        Me.Btn_Excel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Btn_Excel.Name = "Btn_Excel"
        Me.Btn_Excel.Size = New System.Drawing.Size(240, 38)
        Me.Btn_Excel.TabIndex = 21
        Me.Btn_Excel.Tag = "    Excel"
        Me.Btn_Excel.Text = "    Excel"
        Me.Btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Excel.UseVisualStyleBackColor = False
        Me.Btn_Excel.Visible = False
        '
        'ButtonBrisi
        '
        Me.ButtonBrisi.AccessibleName = "sakrij"
        Me.ButtonBrisi.BackColor = System.Drawing.Color.Transparent
        Me.ButtonBrisi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBrisi.FlatAppearance.BorderSize = 0
        Me.ButtonBrisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonBrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBrisi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrisi.ForeColor = System.Drawing.Color.White
        Me.ButtonBrisi.Image = CType(resources.GetObject("ButtonBrisi.Image"), System.Drawing.Image)
        Me.ButtonBrisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBrisi.Location = New System.Drawing.Point(10, 466)
        Me.ButtonBrisi.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonBrisi.Name = "ButtonBrisi"
        Me.ButtonBrisi.Size = New System.Drawing.Size(240, 38)
        Me.ButtonBrisi.TabIndex = 19
        Me.ButtonBrisi.Text = "    Бриши слог"
        Me.ButtonBrisi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBrisi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonBrisi.UseVisualStyleBackColor = False
        Me.ButtonBrisi.Visible = False
        '
        'ButtonNoviSlog
        '
        Me.ButtonNoviSlog.AccessibleName = "sakrij"
        Me.ButtonNoviSlog.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNoviSlog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNoviSlog.FlatAppearance.BorderSize = 0
        Me.ButtonNoviSlog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonNoviSlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNoviSlog.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNoviSlog.ForeColor = System.Drawing.Color.White
        Me.ButtonNoviSlog.Image = CType(resources.GetObject("ButtonNoviSlog.Image"), System.Drawing.Image)
        Me.ButtonNoviSlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNoviSlog.Location = New System.Drawing.Point(10, 420)
        Me.ButtonNoviSlog.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonNoviSlog.Name = "ButtonNoviSlog"
        Me.ButtonNoviSlog.Size = New System.Drawing.Size(240, 38)
        Me.ButtonNoviSlog.TabIndex = 10
        Me.ButtonNoviSlog.Text = "    Нови слог"
        Me.ButtonNoviSlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNoviSlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonNoviSlog.UseVisualStyleBackColor = False
        Me.ButtonNoviSlog.Visible = False
        '
        'ButtonUpitnik
        '
        Me.ButtonUpitnik.AccessibleName = "sakrij"
        Me.ButtonUpitnik.BackColor = System.Drawing.Color.Transparent
        Me.ButtonUpitnik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonUpitnik.FlatAppearance.BorderSize = 0
        Me.ButtonUpitnik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonUpitnik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpitnik.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpitnik.ForeColor = System.Drawing.Color.White
        Me.ButtonUpitnik.Image = CType(resources.GetObject("ButtonUpitnik.Image"), System.Drawing.Image)
        Me.ButtonUpitnik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUpitnik.Location = New System.Drawing.Point(10, 374)
        Me.ButtonUpitnik.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonUpitnik.Name = "ButtonUpitnik"
        Me.ButtonUpitnik.Size = New System.Drawing.Size(240, 38)
        Me.ButtonUpitnik.TabIndex = 8
        Me.ButtonUpitnik.Text = "    Упитник"
        Me.ButtonUpitnik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUpitnik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonUpitnik.UseVisualStyleBackColor = False
        Me.ButtonUpitnik.Visible = False
        '
        'btnNP
        '
        Me.btnNP.BackColor = System.Drawing.Color.Transparent
        Me.btnNP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNP.FlatAppearance.BorderSize = 0
        Me.btnNP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnNP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNP.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNP.ForeColor = System.Drawing.Color.White
        Me.btnNP.Image = CType(resources.GetObject("btnNP.Image"), System.Drawing.Image)
        Me.btnNP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNP.Location = New System.Drawing.Point(10, 328)
        Me.btnNP.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNP.Name = "btnNP"
        Me.btnNP.Size = New System.Drawing.Size(240, 38)
        Me.btnNP.TabIndex = 6
        Me.btnNP.Text = "    Напредна претрага"
        Me.btnNP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNP.UseVisualStyleBackColor = False
        '
        'ButtonLK
        '
        Me.ButtonLK.AccessibleName = "sakrij"
        Me.ButtonLK.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLK.FlatAppearance.BorderSize = 0
        Me.ButtonLK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonLK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLK.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLK.ForeColor = System.Drawing.Color.White
        Me.ButtonLK.Image = CType(resources.GetObject("ButtonLK.Image"), System.Drawing.Image)
        Me.ButtonLK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLK.Location = New System.Drawing.Point(10, 282)
        Me.ButtonLK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonLK.Name = "ButtonLK"
        Me.ButtonLK.Size = New System.Drawing.Size(240, 38)
        Me.ButtonLK.TabIndex = 4
        Me.ButtonLK.Text = "    Контрола"
        Me.ButtonLK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLK.UseVisualStyleBackColor = False
        Me.ButtonLK.Visible = False
        '
        'ButtonAzurirajSlogUDGV
        '
        Me.ButtonAzurirajSlogUDGV.AccessibleName = "sakrij"
        Me.ButtonAzurirajSlogUDGV.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAzurirajSlogUDGV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAzurirajSlogUDGV.FlatAppearance.BorderSize = 0
        Me.ButtonAzurirajSlogUDGV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonAzurirajSlogUDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAzurirajSlogUDGV.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAzurirajSlogUDGV.ForeColor = System.Drawing.Color.White
        Me.ButtonAzurirajSlogUDGV.Image = CType(resources.GetObject("ButtonAzurirajSlogUDGV.Image"), System.Drawing.Image)
        Me.ButtonAzurirajSlogUDGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAzurirajSlogUDGV.Location = New System.Drawing.Point(10, 236)
        Me.ButtonAzurirajSlogUDGV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAzurirajSlogUDGV.Name = "ButtonAzurirajSlogUDGV"
        Me.ButtonAzurirajSlogUDGV.Size = New System.Drawing.Size(240, 38)
        Me.ButtonAzurirajSlogUDGV.TabIndex = 2
        Me.ButtonAzurirajSlogUDGV.Text = "    Ажурирај"
        Me.ButtonAzurirajSlogUDGV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAzurirajSlogUDGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAzurirajSlogUDGV.UseVisualStyleBackColor = False
        Me.ButtonAzurirajSlogUDGV.Visible = False
        '
        'ButtonIzborKolona
        '
        Me.ButtonIzborKolona.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIzborKolona.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzborKolona.FlatAppearance.BorderSize = 0
        Me.ButtonIzborKolona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonIzborKolona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIzborKolona.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzborKolona.ForeColor = System.Drawing.Color.White
        Me.ButtonIzborKolona.Image = CType(resources.GetObject("ButtonIzborKolona.Image"), System.Drawing.Image)
        Me.ButtonIzborKolona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzborKolona.Location = New System.Drawing.Point(10, 190)
        Me.ButtonIzborKolona.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonIzborKolona.Name = "ButtonIzborKolona"
        Me.ButtonIzborKolona.Size = New System.Drawing.Size(240, 38)
        Me.ButtonIzborKolona.TabIndex = 0
        Me.ButtonIzborKolona.Text = "    Избор колона"
        Me.ButtonIzborKolona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzborKolona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonIzborKolona.UseVisualStyleBackColor = False
        '
        'btnPrazno
        '
        Me.btnPrazno.BackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrazno.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPrazno.FlatAppearance.BorderSize = 0
        Me.btnPrazno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrazno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrazno.ForeColor = System.Drawing.Color.White
        Me.btnPrazno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrazno.Location = New System.Drawing.Point(0, 767)
        Me.btnPrazno.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrazno.Name = "btnPrazno"
        Me.btnPrazno.Size = New System.Drawing.Size(255, 20)
        Me.btnPrazno.TabIndex = 37
        Me.btnPrazno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrazno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrazno.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(0, 99)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 28)
        Me.Button2.TabIndex = 10000083
        Me.Button2.Text = "W H E R E  I N T E G R A T I O N  M E E T S  I N F O R M A T I O N"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.Location = New System.Drawing.Point(0, 47)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(255, 52)
        Me.Button7.TabIndex = 10000082
        Me.Button7.Text = "IST"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(255, 47)
        Me.Button3.TabIndex = 10000084
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PanelContext
        '
        Me.PanelContext.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContext.Controls.Add(Me.TableLayoutPanelTABLE)
        Me.PanelContext.Controls.Add(Me.PanelTop)
        Me.PanelContext.Controls.Add(Me.btnLinijaRazmak)
        Me.PanelContext.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(255, 0)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(895, 787)
        Me.PanelContext.TabIndex = 145
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.LabelTotalCount)
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.ComboBoxTabele)
        Me.PanelTop.Controls.Add(Me.btnArrowDownHover)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(2, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(893, 40)
        Me.PanelTop.TabIndex = 10000078
        Me.PanelTop.Tag = "Theme"
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
        Me.b3.Location = New System.Drawing.Point(16, 8)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(237, 27)
        Me.b3.TabIndex = 184
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        Me.b3.Visible = False
        '
        'btnArrowDownHover
        '
        Me.btnArrowDownHover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArrowDownHover.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnArrowDownHover.FlatAppearance.BorderSize = 0
        Me.btnArrowDownHover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArrowDownHover.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArrowDownHover.ForeColor = System.Drawing.Color.White
        Me.btnArrowDownHover.Image = CType(resources.GetObject("btnArrowDownHover.Image"), System.Drawing.Image)
        Me.btnArrowDownHover.Location = New System.Drawing.Point(853, 0)
        Me.btnArrowDownHover.Name = "btnArrowDownHover"
        Me.btnArrowDownHover.Size = New System.Drawing.Size(40, 40)
        Me.btnArrowDownHover.TabIndex = 10000077
        Me.btnArrowDownHover.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(813, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = False
        Me.btnMinimizar.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(853, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = False
        Me.btnCerrar.Visible = False
        '
        'btnLinijaRazmak
        '
        Me.btnLinijaRazmak.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnLinijaRazmak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLinijaRazmak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLinijaRazmak.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLinijaRazmak.FlatAppearance.BorderSize = 0
        Me.btnLinijaRazmak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLinijaRazmak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLinijaRazmak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinijaRazmak.Font = New System.Drawing.Font("Arial Rounded MT Bold", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLinijaRazmak.ForeColor = System.Drawing.Color.White
        Me.btnLinijaRazmak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLinijaRazmak.Location = New System.Drawing.Point(0, 0)
        Me.btnLinijaRazmak.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLinijaRazmak.Name = "btnLinijaRazmak"
        Me.btnLinijaRazmak.Size = New System.Drawing.Size(2, 787)
        Me.btnLinijaRazmak.TabIndex = 10000077
        Me.btnLinijaRazmak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinijaRazmak.UseVisualStyleBackColor = False
        '
        'mnuColumnNumber
        '
        Me.mnuColumnNumber.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuColumnNumber.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuColumnNumber.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nhide, Me.nunhide, Me.ToolStripSeparator3, Me.nsort, Me.nmcs, Me.ToolStripSeparator4, Me.nfind, Me.ToolStripSeparator5, Me.nequals, Me.ndnequals, Me.nfilter, Me.nunfilterall, Me.ToolStripSeparator6, Me.nfreeze, Me.nunfreezeall, Me.ToolStripSeparator7, Me.nafc, Me.nafw, Me.nafch, Me.nacrw})
        Me.mnuColumnNumber.Name = "mnuColumn"
        Me.mnuColumnNumber.ShowCheckMargin = True
        Me.mnuColumnNumber.Size = New System.Drawing.Size(240, 364)
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
        'FormAzuriraj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1150, 787)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormAzuriraj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelTABLE.ResumeLayout(False)
        Me.TabControlGreske.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContext.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.mnuColumnNumber.ResumeLayout(False)
        Me.mnuColumnText.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public WithEvents mdd As DataGridView   'pomocni datagridview

    Public Shared brojotvorenihazuriranja As String = -1
    Public Shared dodakle As String
    Public Shared derrNumber As String
    Public Shared dodakleImeTabele As String
    Public Shared poslednjaIzabrana As String

    Public Shared niz_dgv() As DataGridView
    Public Shared niz_pdgv() As Panel
    Public Shared niz_l() As ListBox
    Public Shared niz_izabranaTabela() As String
    Public Shared imaPodTabelu() As Boolean
    Public Shared imaNadTabelu() As Boolean

    Public Shared niz_fpdgv() As Panel
    Public Shared niz_fdgv() As DataGridView
    Public Shared niz_fbf() As Button
    Public Shared niz_fbuf() As Button

    Public Shared niz_frsCheckBoxPrvihRedova() As Boolean
    Public Shared niz_frsNumericUpDownPrvihRedovaValue() As Integer
    Public Shared niz_frscmbTezinaGreskeSelectedItem() As String
    Public Shared niz_frsComboBoxRedoviSelectedItem() As String
    Public Shared niz_frsR() As String
    Public Shared niz_frsRE() As String


    Public Shared niz_pk() As System.Data.DataRow
    Public Shared niz_gr() As System.Data.DataRow
    Public Shared niz_kol() As System.Data.DataRow
    Public Shared niz_Left() As String
    Public Shared niz_Right() As String
    Public Shared niz_vs() As String

    'Dim dgvs_dataSet As New System.Data.DataSet
    Dim niz_TColInfo() As TcolInfo
    Dim nadnadtabela As String
    Dim izabranatabela As String
    Dim sveTabele() As String
    Dim sveTabeleSAPFX() As String
    Dim postojiLKpolje() As Boolean

    Dim frsR As FormAzurirajFilterRows
    Dim frsC As FormAzurirajFilterColumns
    Dim DBConnectionString As String
    Dim ISTConnectionString As String
    Dim dsIST As DatasetIstrazivanja
    Dim m_rowIST As DatasetIstrazivanja.ISTRow
    Dim mtt As DatasetIstrazivanja.ISTTABELEDataTable
    Dim mtp As DatasetIstrazivanja.ISTPOLJADataTable
    Dim mta As DatasetIstrazivanja.ISTPOLJADataTable
    Dim mtlk As DatasetIstrazivanja.ISTLKDataTable
    Dim tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka

    Dim mfold As String
    Dim txtInst As String = ""
    Dim txtpismo As String = ""
    Dim txtmode As String = ""
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim LX As Boolean
    Dim LA As Boolean
    Dim pamtiUpit As String
    Dim CAPIServer As String
    Dim CAPIBaza As String
    Dim mdtAWL As DataTable
    Dim mdtQE As DataTable
    Dim mdtLabel As DataTable
    Dim mdtMessage As DataTable
    Dim idtist As Integer = -1
    Dim lokalno As Boolean
    Dim konDepo As String
    Dim jezik As String
    Dim prosaoLoad As Integer = 0
    Dim ml As DatasetIstrazivanja.ISTLKDataTable
    Dim ssvaPoljaIzIst As DatasetIstrazivanja.ISTPOLJADataTable
    Dim sifist As String
    Dim panelmenucollapse As Boolean
    'Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    'Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    If m.Msg = WM_NCLBUTTONDBLCLK Then Return
    '    If m.Msg = WM_NCLBUTTONDOWN Then Return
    '    MyBase.WndProc(m)
    'End Sub
    Dim onlyTableDescription As Boolean = False
    Dim redoviMEMG() As DataRow
    Dim redoviMEM() As DataRow
    Dim redoviMEMD() As DataRow
    Dim redoviMEMAK() As DataRow
    Dim redovi() As DataRow

    Dim brojNodova As Integer = 0
    Dim GlavneIliPomocne As String
    Dim tabelaLK As String

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
    Public Sub New(ByVal odakle As String, ByVal ds As DatasetIstrazivanja, ByVal mdtLabel As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable,
                   ByVal mdtMessage As DataTable, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
    ByVal DBConnectionString As String,
    ByVal tt As DatasetIstrazivanja.ISTTABELEDataTable,
    ByVal svaPoljaIzIst As DatasetIstrazivanja.ISTPOLJADataTable, ByVal kljucPoljaIzIst As DatasetIstrazivanja.ISTPOLJADataTable,
    ByVal svaLKizIst As DatasetIstrazivanja.ISTLKDataTable, ByVal ri As DatasetIstrazivanja.ISTRow,
    ByVal fold As String, ByVal txtInstalacije As String, ByVal txtpismo As String, ByVal txtmode As String,
    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
    ByVal txt_DSBrisanjeBaza As String, ByVal jezik As String,
    ByVal ISTConnectionString As String, ByVal txt_CAPIServer As String, ByVal txt_CAPIBaza As String,
    ByVal errNumber As String, ByVal panelmenucollapse As Boolean, ByVal GlavneIliPomocne As String, Optional ByVal tabelaLK As String = "", Optional ByVal kosamnew As String = "")

        Me.New()

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Logovan.Text = kosamnew ' GetUserName.ToString.Trim
        zapamtilogovanog = Logovan.Text.Trim
        Me.ml = svaLKizIst
        Me.ssvaPoljaIzIst = svaPoljaIzIst
        Me.tabelaLK = tabelaLK
        If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then   'može i testcapi
            Me.ButtonAzurirajSlogUDGV.Visible = False
            Me.ButtonNoviSlog.Visible = False
            Me.ButtonUpitnik.Visible = False
            Me.Btn_Excel.Visible = False
            Me.btn_SPSS.Visible = False
            Me.Btn_XML.Visible = False
            Me.btn_JSON.Visible = False
        End If

        Me.txtmode = txtmode
        Me.txtpismo = txtpismo
        Me.jezik = jezik
        Me.GlavneIliPomocne = GlavneIliPomocne
        Me.ISTConnectionString = ISTConnectionString

        LX = False
        LA = False
        Me.dsIST = ds
        Me.txtInst = txtInstalacije
        Me.Text = Me.Text + "  " + txtInst + " - " + ri.Naziv.Trim
        Me.mfold = fold
        Me.DBConnectionString = DBConnectionString
        Me.m_rowIST = ri
        sifist = ri.Item(0).ToString.Trim
        Me.mtlk = svaLKizIst
        Me.mtt = tt
        Me.mtp = svaPoljaIzIst
        Me.mta = kljucPoljaIzIst
        Me.tacv = vt

        Call SetLang()
        Me.panelmenucollapse = panelmenucollapse
        b3.Text = sifist + "    " + String.Format("{0:d2}", Me.tacv.M) + " / " + Me.tacv.G.ToString

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza

        Me.CAPIServer = txt_CAPIServer
        Me.CAPIBaza = txt_CAPIBaza
        derrNumber = errNumber
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtLabel = mdtLabel
        Me.mdtMessage = mdtMessage
        konDepo = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)
        lokalno = False
        'NS je trazio da za njih se ne radi DEPO pri brisanju
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True
        Dim pomocne As Boolean = True
        If GlavneIliPomocne Is Nothing Then pomocne = False
        onlyTableDescription = False
        If Not (ds.IST.Rows(0).Item("ABAZA") Is System.DBNull.Value) AndAlso ds.IST.Rows(0).Item("ABAZA").ToString.Trim.ToUpper.IndexOf("ONLYTABLEDESCRIPTION") >= 0 Then
            onlyTableDescription = True
        End If


        Dim imaPodT As Boolean = False
        Dim imaNadT As Boolean = False

        tv.Nodes.Clear()
        Dim nnode As TreeNode
        Dim red As DatasetIstrazivanja.ISTTABELERow
        brojNodova = 0
        redoviMEMD = ds.ISTTABELE.Select("isnull(DG,'G')='D'  and isnull(baza,'')<>'0'", "baza ASC")
        If pomocne = True Then
            redoviMEM = ds.ISTTABELE.Select("(isnull(DG,'G')='A' or isnull(DG,'G')='K') and isnull(baza,'')<>'0'", "baza ASC")
            For r1 As Integer = 0 To redoviMEM.GetUpperBound(0)
                red = redoviMEM(r1)
                Dim rtTabela As String = red.Tabela
                'dodam glavnu
                nnode = tv.Nodes.Add(dajOpis(red))
                nnode.Tag = rtTabela
                brojNodova = brojNodova + 1
                podtabela(rtTabela, redoviMEMD, 1, Nothing)
            Next
            tv.ExpandAll()
        Else
            redoviMEM = ds.ISTTABELE.Select("isnull(DG,'G') in ('G','D') and isnull(baza,'')<>'0'", "baza ASC")
            If pomocne = False Then
                redoviMEMG = ds.ISTTABELE.Select("isnull(DG,'G')='G' and isnull(baza,'')<>'0'", "baza ASC")
                For r1 As Integer = 0 To redoviMEMG.GetUpperBound(0)
                    red = redoviMEMG(r1)
                    Dim rtTabela As String = red.Tabela
                    'dodam glavnu
                    nnode = tv.Nodes.Add(dajOpis(red))
                    nnode.Tag = rtTabela
                    brojNodova = brojNodova + 1
                    podtabela(rtTabela, redoviMEMD, 1, nnode)
                Next
            End If
        End If

        For i As Integer = 0 To redoviMEM.Count - 1
            Dim tab As DataRow = redoviMEM(i)
            Dim nogridediting As Boolean = False
            If postojipodtabelaJe(tab.Item("tabela")) Then
                imaPodT = True
            Else
                imaPodT = False
            End If
            If postojiNadtabelaJe(tab.Item("tabela")) Then
                imaNadT = True
            Else
                imaNadT = False
            End If
            If Not (tab.Item("T1") Is System.DBNull.Value) Then
                Dim IndikatorT1 As String = tab.Item("T1").ToString.Trim
                If IndikatorT1.Trim.ToUpper.IndexOf("NOGRIDEDITING") >= 0 Then nogridediting = True
            End If

            Dim tabeleTcolInfo As TcolInfo = New TcolInfo(tab.Item("tabela"), DBConnectionString, ri.ISTBAZERow, svaLKizIst, svaPoljaIzIst, mdd, Me.tacv,
                                                                     Me.TabPageGreskeZaSlog, Me.TabPageGreskeZaPrikazaneSlogove, Me.TabPageGreskeZaCeluTabelu, Me.chbA, Me.jezik, nogridediting, imaPodT, imaNadT, txtmode)
            idtist = idtist + 1

            'imaNadTabelu
            ReDim Preserve imaNadTabelu(idtist)
            imaNadTabelu(idtist) = imaNadT
            'imaPodTabelu
            ReDim Preserve imaPodTabelu(idtist)
            imaPodTabelu(idtist) = imaPodT

            'niz_TColInfo
            ReDim Preserve Me.niz_TColInfo(idtist)
            Me.niz_TColInfo(idtist) = tabeleTcolInfo
            tabeleTcolInfo.dt.DefaultView.AllowNew = False
            tabeleTcolInfo.dt.DefaultView.AllowDelete = False
            tabeleTcolInfo.dt.DefaultView.AllowDelete = False

            'postojiLKpolje u tabeli
            ReDim Preserve postojiLKpolje(idtist)
            If niz_TColInfo(idtist).dt.Columns.Contains("LK") Then
                postojiLKpolje(idtist) = True
            Else
                postojiLKpolje(idtist) = False
            End If

            'niz_dgv
            '****
            Dim dtt As New DataTable
            dtt = Me.niz_TColInfo(idtist).dt.Copy
            ReDim Preserve niz_dgv(idtist)
            niz_dgv(idtist) = New DataGridView
            AddHandler niz_dgv(idtist).SelectionChanged, AddressOf dg_CurrentCellChanged

            AddHandler niz_dgv(idtist).RowHeaderMouseDoubleClick, AddressOf dg_RowHeaderMouseDoubleClick
            AddHandler niz_dgv(idtist).CellClick, AddressOf dg_CellClick
            AddHandler niz_dgv(idtist).CellMouseDown, AddressOf dg_CellMouseDown
            AddHandler niz_dgv(idtist).RowEnter, AddressOf dg_RowEnter

            niz_dgv(idtist).DataSource = tabeleTcolInfo.dt.Copy
            niz_dgv(idtist).Name = tab.Item("tabela")
            If nogridediting = True Then niz_dgv(idtist).ReadOnly = True
            'MORA OVAJ SREDI GRID
            Call srediGridView(niz_dgv(idtist), False, 35)
            niz_dgv(idtist).Visible = False

            'niz_fdgv
            'panel
            ReDim Preserve niz_fpdgv(idtist)
            niz_fpdgv(idtist) = New Panel
            niz_fpdgv(idtist).AutoSize = False
            niz_fpdgv(idtist).BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
            niz_fpdgv(idtist).BorderStyle = BorderStyle.None
            niz_fpdgv(idtist).Name = "fpanel_" + tab.Item("tabela")
            niz_fpdgv(idtist).Visible = False
            'grid
            ReDim Preserve niz_fdgv(idtist)
            niz_fdgv(idtist) = New DataGridView
            niz_fdgv(idtist).Name = "filter_" + tab.Item("tabela")
            'MORA OVAJ SREDI GRID
            Call srediGridView(niz_fdgv(idtist), False, 35, 25)
            niz_fdgv(idtist).Visible = True
            'buttonf
            ReDim Preserve niz_fbf(idtist)
            niz_fbf(idtist) = New Button
            AddHandler niz_fbf(idtist).Click, AddressOf fdg_Click
            niz_fbf(idtist).Name = "btnf_" + tab.Item("tabela")
            niz_fbf(idtist).Text = ""
            niz_fbf(idtist).Visible = True
            niz_fbf(idtist).Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            niz_fbf(idtist).FlatStyle = System.Windows.Forms.FlatStyle.Flat
            niz_fbf(idtist).Image = My.Resources.filter.ToBitmap
            niz_fbf(idtist).BackColor = System.Drawing.Color.Transparent
            niz_fbf(idtist).FlatAppearance.BorderSize = 0
            niz_fbf(idtist).Tag = idtist
            'buttonuf
            ReDim Preserve niz_fbuf(idtist)
            niz_fbuf(idtist) = New Button
            AddHandler niz_fbuf(idtist).Click, AddressOf fudg_Click
            niz_fbuf(idtist).Name = "btnuf_" + tab.Item("tabela")
            niz_fbuf(idtist).Text = ""
            niz_fbuf(idtist).Visible = True
            niz_fbuf(idtist).Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
            niz_fbuf(idtist).FlatStyle = System.Windows.Forms.FlatStyle.Flat
            niz_fbuf(idtist).Image = My.Resources.unfilter.ToBitmap
            niz_fbuf(idtist).BackColor = System.Drawing.Color.Transparent
            niz_fbuf(idtist).FlatAppearance.BorderSize = 0
            niz_fbuf(idtist).Tag = idtist
            'add to panel
            niz_fpdgv(idtist).Controls.Add(niz_fdgv(idtist))
            niz_fpdgv(idtist).Controls.Add(niz_fbf(idtist))
            niz_fpdgv(idtist).Controls.Add(niz_fbuf(idtist))
            niz_fdgv(idtist).Height = (2 / 3) * niz_fpdgv(idtist).Height
            niz_fdgv(idtist).Dock = DockStyle.Top
            niz_fbf(idtist).Location = New Point(5, niz_fpdgv(idtist).Height - niz_fbf(idtist).Height - 1)
            niz_fbuf(idtist).Location = New Point(5 + niz_fbf(idtist).Width + 5, niz_fbf(idtist).Location.Y)
            niz_fbf(idtist).BringToFront()
            niz_fbuf(idtist).BringToFront()
            '****

            'niz_pdgv
            ReDim Preserve niz_pdgv(idtist)
            niz_pdgv(idtist) = New Panel
            niz_pdgv(idtist).AutoSize = False
            niz_pdgv(idtist).BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
            niz_pdgv(idtist).BorderStyle = BorderStyle.FixedSingle
            niz_pdgv(idtist).Width = 405
            niz_pdgv(idtist).Name = "panel_" + tab.Item("tabela")
            niz_pdgv(idtist).Visible = False
            ReDim Preserve niz_l(idtist)
            niz_l(idtist) = New ListBox
            niz_l(idtist).AutoSize = False
            niz_l(idtist).BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
            niz_l(idtist).BorderStyle = BorderStyle.None
            niz_l(idtist).Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
            niz_l(idtist).ForeColor = System.Drawing.Color.DarkOrange
            niz_l(idtist).Width = 400
            niz_l(idtist).Name = "list_" + tab.Item("tabela")
            'AddHandler niz_l(idtist).SelectedIndexChanged, AddressOf lb_SelectedIndexChanged
            AddHandler niz_l(idtist).MouseUp, AddressOf lb_MouseUp
            niz_l(idtist).Visible = True
            niz_pdgv(idtist).Controls.Add(niz_l(idtist))
            niz_l(idtist).Dock = DockStyle.Fill
            '****

            'sveTabele
            ReDim Preserve sveTabele(idtist)
            sveTabele(idtist) = tabeleTcolInfo.dt.TableName.Trim.ToUpper

            ReDim Preserve sveTabeleSAPFX(idtist)
            sveTabeleSAPFX(idtist) = tabeleTcolInfo.dt.Prefix.Trim.ToUpper + "." + tabeleTcolInfo.dt.TableName.Trim.ToUpper

            Me.ComboBoxTabele.Items.Add(tabeleTcolInfo.dt.Prefix.Trim.ToUpper + "." + tabeleTcolInfo.dt.TableName.Trim.ToUpper)
        Next

        For i As Integer = 0 To Me.niz_TColInfo.GetUpperBound(0)
            Dim cs() As System.Data.DataColumn = {}
            cs = dajCS0(Me.niz_TColInfo(i).dt.TableName.Trim.ToUpper, svaPoljaIzIst, Me.niz_TColInfo(i))
            Call appendTS0(ri.ISTBAZERow, Me.TabPageGreskeZaSlog, Me.TabPageGreskeZaPrikazaneSlogove, Me.TabPageGreskeZaCeluTabelu, Me.niz_TColInfo(i))
        Next

        For i As Integer = 0 To niz_dgv.Count - 1
            Me.TableLayoutPanelTABLE.Controls.Add(niz_fpdgv(i), 0, 0)
            Me.TableLayoutPanelTABLE.Controls.Add(niz_dgv(i), 0, 1)
            Me.PanelContext.Controls.Add(niz_pdgv(i))
        Next

        If odakle = "LK" Then
            dodakle = "LK"
            derrNumber = derrNumber
            dodakleImeTabele = tabelaLK   'akoJeIzLKImeTabele.Trim.ToUpper
            poslednjaIzabrana = tabelaLK
        Else
            dodakle = ""
        End If

        Call postaviNizove()

        If odakle = "LK" Then
            Dim iii As Integer = Array.IndexOf(sveTabele, tabelaLK)
            Call izabranaTabelaPostavi(iii)
        End If

        If odakle <> "LK" AndAlso brojNodova = 1 Then
            Call izabranaTabelaPostavi(0)
        End If

        Me.chbA_CheckedChanged(Nothing, Nothing)
        Me.TableLayoutPanelTABLE.Dock = System.Windows.Forms.DockStyle.Fill
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then   'može i testcapi
        Else
            Me.Kolona2(True)
            If Not pomdt Is Nothing AndAlso pomdt.Length > 0 Then
                Dim dr As DialogResult = ISTMessageBox.Show("Niste uradili LK posle ažuriranja. Da li želite da uradite LK?", "Batch logical control", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Select Case dr
                    Case DialogResult.Yes
                        Me.ButtonLK.Focus()
                        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("formAzuriraj" + " DialogResult for LK", "yes", "")
                    Case DialogResult.No
                        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("formAzuriraj" + " DialogResult for LK", "no", "")
                End Select
            End If
            If dodakle <> "izLK" Then

                poslednjaIzabrana = ""

                niz_izabranaTabela = Nothing
                niz_vs = Nothing
                niz_frsCheckBoxPrvihRedova = Nothing
                niz_frsNumericUpDownPrvihRedovaValue = Nothing
                niz_frscmbTezinaGreskeSelectedItem = Nothing
                niz_frsComboBoxRedoviSelectedItem = Nothing
                niz_pk = Nothing
                niz_gr = Nothing
                niz_kol = Nothing
                For Each tt As TcolInfo In niz_TColInfo
                    tt.Dispose()
                Next
                niz_TColInfo = Nothing
                For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                    niz_dgv(i).DataSource.Dispose()
                Next
                niz_dgv = Nothing
                niz_pdgv = Nothing
                niz_l = Nothing
                niz_Left = Nothing
                niz_Right = Nothing
                imaPodTabelu = Nothing
                imaNadTabelu = Nothing
                niz_fpdgv = Nothing
                niz_fdgv = Nothing
                niz_fbf = Nothing
                niz_fbuf = Nothing
                niz_frsR = Nothing
                niz_frsRE = Nothing
                If Not frsR Is Nothing Then frsR.Dispose()
                If Not frsC Is Nothing Then frsC.Dispose()
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Close()
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
    End Sub

    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelMenu
        ReDim Preserve nizButtonOboji(2)
        nizButtonOboji(2) = PanelTop

        zapamtibojuteme = setTheme(nizButtonOboji, Nothing, theme)

    End Sub
    Dim zapamtibojuteme As Color = Nothing
    'Sub setTheme(ByVal theme As String)
    '    If theme = "L" Then
    '        ISTTheme.ChosenTheme("Light")
    '        ActivateButtonColor = ISTTheme.ActivateButtons
    '        PanelMenu.BackColor = ISTTheme.PanelParent
    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    Else
    '        ISTTheme.ChosenTheme("Dark")
    '        ActivateButtonColor = ISTTheme.ActivateButtons
    '        PanelMenu.BackColor = ISTTheme.PanelParent
    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    End If
    'End Sub

    Sub visiblePanelTOP()
        btnArrowDownHover.Visible = False
        b3.Visible = True
        ComboBoxTabele.Visible = True
        LabelTotalCount.Visible = True
        PanelTop.BackColor = zapamtibojuteme
        btnCerrar.Visible = True
        btnMinimizar.Visible = True
    End Sub

    Sub nonvisiblePanelTOP()
        btnCerrar.Visible = False
        btnMinimizar.Visible = False
        b3.Visible = False
        ComboBoxTabele.Visible = False
        LabelTotalCount.Visible = False
        PanelTop.BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
        btnArrowDownHover.Visible = True
    End Sub

    Private Sub PanelTop_MouseLeave(sender As Object, e As EventArgs) Handles PanelTop.MouseLeave, btnMinimizar.MouseLeave, btnCerrar.MouseLeave, b3.MouseLeave, LabelTotalCount.MouseLeave, ComboBoxTabele.MouseLeave
        If MouseIsOverButton(b3) OrElse MouseIsOverCBO(ComboBoxTabele) OrElse MouseIsOverLabel(LabelTotalCount) OrElse MouseIsOverButton(b3) OrElse MouseIsOverButton(btnCerrar) OrElse MouseIsOverButton(btnMinimizar) OrElse MouseIsOverPanel(PanelTop) Then
        Else
            nonvisiblePanelTOP()
        End If

    End Sub

    Private Sub btnArrowDownHover_MouseHover(sender As Object, e As EventArgs) Handles btnArrowDownHover.MouseHover, PanelTop.MouseHover
        visiblePanelTOP()
    End Sub

    Private Sub PanelMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimizar.MouseEnter
        visiblePanelTOP()
    End Sub

    Private Function MouseIsOverButton(ByVal btn As System.Windows.Forms.Button) As Boolean
        Return btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position))
    End Function

    Private Function MouseIsOverPanel(ByVal pnl As Panel) As Boolean
        Return pnl.ClientRectangle.Contains(pnl.PointToClient(Cursor.Position))
    End Function

    Private Function MouseIsOverCBO(ByVal cbo As ComboBox) As Boolean
        Return cbo.ClientRectangle.Contains(cbo.PointToClient(Cursor.Position))
    End Function

    Private Function MouseIsOverLabel(ByVal lbl As Label) As Boolean
        Return lbl.ClientRectangle.Contains(lbl.PointToClient(Cursor.Position))
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then   'može i testcapi
        Else
            Me.Kolona2(True)
            If Not pomdt Is Nothing AndAlso pomdt.Length > 0 Then
                Dim dr As DialogResult = ISTMessageBox.Show("Niste uradili LK posle ažuriranja. Da li želite da uradite LK?", "Batch logical control", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                Select Case dr
                    Case DialogResult.Yes
                        Me.ButtonLK.Focus()
                        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("formAzuriraj" + " DialogResult for LK", "yes", "")
                    Case DialogResult.No
                        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("formAzuriraj" + " DialogResult for LK", "no", "")
                End Select
            End If
            If dodakle <> "izLK" Then

                poslednjaIzabrana = ""

                niz_izabranaTabela = Nothing
                niz_vs = Nothing
                niz_frsCheckBoxPrvihRedova = Nothing
                niz_frsNumericUpDownPrvihRedovaValue = Nothing
                niz_frscmbTezinaGreskeSelectedItem = Nothing
                niz_frsComboBoxRedoviSelectedItem = Nothing
                niz_pk = Nothing
                niz_gr = Nothing
                niz_kol = Nothing
                For Each tt As TcolInfo In niz_TColInfo
                    tt.Dispose()
                Next
                niz_TColInfo = Nothing
                For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                    niz_dgv(i).DataSource.Dispose()
                Next
                niz_dgv = Nothing
                niz_pdgv = Nothing
                niz_l = Nothing
                niz_Left = Nothing
                niz_Right = Nothing
                imaPodTabelu = Nothing
                imaNadTabelu = Nothing
                niz_fpdgv = Nothing
                niz_fdgv = Nothing
                niz_fbf = Nothing
                niz_fbuf = Nothing
                niz_frsR = Nothing
                niz_frsRE = Nothing
                If Not frsR Is Nothing Then frsR.Dispose()
                If Not frsC Is Nothing Then frsC.Dispose()
            End If
        End If
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
        System.Windows.Forms.Application.Exit()
    End Sub
    Sub podtabela(ByVal rtTabela As String, ByVal redoviMEMD() As DataRow, ByVal nivo As Integer, Optional ByVal no As TreeNode = Nothing)
        For r As Integer = 0 To redoviMEMD.GetUpperBound(0)
            Dim rt As DatasetIstrazivanja.ISTTABELERow
            rt = redoviMEMD(r)
            If rt.IsNadTabelaNull = False AndAlso rt.NadTabela.Trim.ToUpper = rtTabela.Trim.ToUpper Then
                Dim nnode2 As TreeNode
                nnode2 = no.Nodes.Add(dajOpis(rt))
                nnode2.Tag = rt.Tabela
                brojNodova = brojNodova + 1
                Call podtabela(rt.Tabela, redoviMEMD, nivo + 1, nnode2)
            End If
        Next
    End Sub
    Function dajOpis(ByVal rt As DatasetIstrazivanja.ISTTABELERow) As String

        Dim rtTabela As String = rt.Tabela.Trim
        Dim topis As String = rt.Tabela.Trim
        Dim sropis As String = ""
        If rt.IsOpisNull OrElse rt.Opis.Trim = "" Then
        Else
            sropis = sredjenOpis(rt.Opis)
        End If

        If rt.IsOpisNull OrElse rt.Opis.Trim = "" Then
            'topis
        ElseIf rt.Opis.Trim.IndexOf("$") < 0 AndAlso onlyTableDescription = False Then
            If sropis <> "" Then topis = topis + "-" + sropis
        Else
            If sropis <> "" Then topis = sropis
        End If

        Dim MLopis As String = getMultilanguageLabel(mdtLabel, txtmode, rt.Tabela.Trim, "", "td", Me.jezik)
        If MLopis <> "" Then topis = MLopis
        dajOpis = topis + "                 "

    End Function
    Sub postaviNizove()

        If niz_frsR Is Nothing Then
            ReDim Preserve niz_frsR(niz_dgv.GetUpperBound(0))
            For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                niz_frsR(i) = ""
            Next
        End If
        If niz_frsRE Is Nothing Then
            ReDim Preserve niz_frsRE(niz_dgv.GetUpperBound(0))
            For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                niz_frsRE(i) = ""
            Next
        End If
        If niz_izabranaTabela Is Nothing Then
            ReDim Preserve niz_izabranaTabela(niz_dgv.GetUpperBound(0))
            For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                niz_izabranaTabela(i) = ""
            Next
        End If
        If niz_frsCheckBoxPrvihRedova Is Nothing Then
            ReDim Preserve niz_frsCheckBoxPrvihRedova(niz_dgv.GetUpperBound(0))
            For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                niz_frsCheckBoxPrvihRedova(i) = False
            Next
        End If
        If niz_frsNumericUpDownPrvihRedovaValue Is Nothing Then
            ReDim Preserve niz_frsNumericUpDownPrvihRedovaValue(niz_dgv.GetUpperBound(0))
            For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                niz_frsNumericUpDownPrvihRedovaValue(i) = 0
            Next
        End If
        If niz_frscmbTezinaGreskeSelectedItem Is Nothing Then
            ReDim Preserve niz_frscmbTezinaGreskeSelectedItem(niz_dgv.GetUpperBound(0))
            For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                niz_frscmbTezinaGreskeSelectedItem(i) = ""
            Next
        End If
        If niz_frsComboBoxRedoviSelectedItem Is Nothing Then
            ReDim Preserve niz_frsComboBoxRedoviSelectedItem(niz_dgv.GetUpperBound(0))
            For i As Integer = 0 To niz_dgv.GetUpperBound(0)
                niz_frsComboBoxRedoviSelectedItem(i) = ""
            Next
        End If
        If niz_pk Is Nothing Then
            ReDim Preserve niz_pk(niz_dgv.GetUpperBound(0))
        End If
        If niz_gr Is Nothing Then
            ReDim Preserve niz_gr(niz_dgv.GetUpperBound(0))
        End If
        If niz_kol Is Nothing Then
            ReDim Preserve niz_kol(niz_dgv.GetUpperBound(0))
        End If
    End Sub
    Sub visibleColumns(ByVal dgv As DataGridView, ByVal alwaysVisibleColumns() As System.Data.DataColumn, ByVal imaPodtabeluNadtabelu As Boolean)

        Dim br As Integer = 0
        If imaPodtabeluNadtabelu AndAlso dgv.Columns.Contains("secondRowHeader") Then
            dgv.Columns("secondRowHeader").Visible = True
            dgv.Columns("secondRowHeader").ReadOnly = True
            dgv.Columns("secondRowHeader").HeaderText = ""
            dgv.Columns("secondRowHeader").Width = 25
            'dgv.Columns("secondRowHeader").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            With dgv.Columns("secondRowHeader").DefaultCellStyle
                .BackColor = Color.LightBlue
                .ForeColor = Color.DarkOrange
            End With
            br = 1
        End If

        For i As Integer = br To dgv.ColumnCount - 1
            dgv.Columns(i).Visible = False
            For Each col2 As System.Data.DataColumn In alwaysVisibleColumns
                If dgv.Columns(i).Name.Trim.ToUpper = col2.ColumnName.Trim.ToUpper Then
                    dgv.Columns(i).Visible = True
                End If
            Next
        Next
    End Sub

    Sub visibleFalseSviDGV()
        For i As Integer = 0 To niz_dgv.GetUpperBound(0)
            niz_fpdgv(i).Visible = False
            For m As Integer = 0 To niz_fdgv(i).Columns.Count - 1
                If niz_fdgv(i).Columns(m).ReadOnly = False Then
                    niz_fdgv(i).Rows(0).Cells(m).Value = DBNull.Value
                End If
            Next

            niz_pdgv(i).Visible = False
            niz_dgv(i).Visible = False
            niz_TColInfo(i).dg_greskeZaSlog.Visible = False
            niz_TColInfo(i).dg_greskeZaPrikazaneSlogove.Visible = False
            niz_TColInfo(i).dg_greskeZaTabelu.Visible = False
        Next
        Me.TabControlGreske.Visible = False
        Me.chbA.Visible = False
    End Sub

    Dim dtvRepIstPolja As DataTable
    Dim maxduz As Integer

    Dim fpm As Boolean = False
    Dim fpg As Boolean = False
    Dim fpmonth As Boolean = False
    Dim fpy As Boolean = False
    Dim fpk As Boolean = False
    Dim fpq As Boolean = False
    Dim fpp As Boolean = False
    Dim fph As Boolean = False
    Dim strLeftJoin As String = ""
    Dim strSelect As String = ""
    Dim strSelectactbDB As String = ""
    'Dim imaG As Boolean = False : Dim imaM As Boolean = False : Dim imaME As Boolean = False : Dim imaGE As Boolean = False
    Dim dtKljuc As New DataTable
    Private Sub fdg_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Call AF(sender, False)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub fudg_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Call AF(sender, True)
        Me.Cursor = Cursors.Default
    End Sub
    Sub AF(sender As Object, ByVal f As Boolean)
        Dim btn As Button = DirectCast(sender, Button)
        Dim ind As Integer = CInt(btn.Tag)
        Dim dgv As DataGridView = niz_fdgv(ind)
        Dim rc As String = CStr(niz_dgv(ind).Rows.Count)
        Call ApplyFilter(ind, f)
        If f = True Then
            LabelTotalCount.Text = "Rows count: " + CStr(niz_dgv(ind).Rows.Count)
        Else
            LabelTotalCount.Text = "Rows count: (" + CStr(niz_dgv(ind).Rows.Count) + " of " + rc + ")"
        End If

    End Sub
    Private Function Row2(ByVal r As System.Data.DataRow, ByVal b2 As Boolean) As String
        Dim rf As String = ""
        Dim col As System.Data.DataColumn
        For Each col In r.Table.Columns
            If Not r.IsNull(col.ColumnName) AndAlso col.ColumnName.Trim.ToUpper <> "INDGR" AndAlso col.ColumnName.Trim <> "secondRowHeader" Then
                Dim b As Boolean
                If col.DataType Is b.GetType Then
                    If CBool(r.Item(col.ColumnName)) Then
                        If rf <> "" Then
                            If b2 Then
                                rf = rf + " and "
                            Else
                                rf = rf + " or "
                            End If
                        End If

                    End If
                ElseIf CStr(r.Item(col.ColumnName)).Trim <> "" Then
                    If rf <> "" Then
                        If b2 Then
                            rf = rf + " and "
                        Else
                            rf = rf + " or "
                        End If
                    End If
                    rf = rf + FormAzurirajFilterRows.Kolona_get(r, col, False)
                End If
            End If
        Next
        If rf <> "" Then rf = "(" + rf + ")"
        Return rf
    End Function
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        CollapseMenu()
    End Sub
    Dim zapamtilogovanog As String = ""
    Private Sub CollapseMenu()
        If Me.PanelMenu.Width > 200 Then
            PanelMenu.Width = 60
            setTollTip(True)
            panelmenucollapse = True
            Button2.Visible = False
            Button7.Image = Nothing
            Dim dIndex = Logovan.Text.IndexOf(".")
            If (dIndex > -1) AndAlso (dIndex + 2) < Len(zapamtilogovanog) Then
                Logovan.Visible = True
                Logovan.Text = zapamtilogovanog.Trim.ToUpper.Substring(0, 1) + zapamtilogovanog.Trim.ToUpper.Substring(dIndex, 2)
            Else
                Logovan.Text = ""
            End If
        Else
            PanelMenu.Width = 255
            setTollTip(False)
            panelmenucollapse = False
            Button7.Image = My.Resources.crtaaaaa.ToBitmap
            Button2.Visible = True
            Logovan.Visible = True
            Logovan.Text = zapamtilogovanog
        End If

    End Sub

    Sub setTollTip(ByVal visibleTrue As Boolean)
        If visibleTrue = True Then
            ToolTip1.SetToolTip(ButtonAzurirajSlogUDGV, ButtonAzurirajSlogUDGV.Tag)
            ToolTip1.SetToolTip(ButtonIzborKolona, ButtonIzborKolona.Tag)
            ToolTip1.SetToolTip(ButtonIzborSlogova, ButtonIzborSlogova.Tag)
            ToolTip1.SetToolTip(ButtonBrisi, ButtonBrisi.Tag)
            ToolTip1.SetToolTip(ButtonNoviSlog, ButtonNoviSlog.Tag)
            ToolTip1.SetToolTip(ButtonUpitnik, ButtonUpitnik.Tag)
            ToolTip1.SetToolTip(ButtonLK, ButtonLK.Tag)
            ToolTip1.SetToolTip(btnNP, btnNP.Tag)
            ToolTip1.SetToolTip(Btn_Excel, Btn_Excel.Tag)
            ToolTip1.SetToolTip(btn_JSON, btn_JSON.Tag)
            ToolTip1.SetToolTip(Btn_XML, Btn_XML.Tag)
            ToolTip1.SetToolTip(btn_SPSS, btn_SPSS.Tag)
        Else
            ToolTip1.SetToolTip(ButtonAzurirajSlogUDGV, "")
            ToolTip1.SetToolTip(ButtonIzborKolona, "")
            ToolTip1.SetToolTip(ButtonIzborSlogova, "")
            ToolTip1.SetToolTip(ButtonBrisi, "")
            ToolTip1.SetToolTip(ButtonNoviSlog, "")
            ToolTip1.SetToolTip(ButtonUpitnik, "")
            ToolTip1.SetToolTip(ButtonLK, "")
            ToolTip1.SetToolTip(btnNP, "")
            ToolTip1.SetToolTip(Btn_Excel, "")
            ToolTip1.SetToolTip(btn_JSON, "")
            ToolTip1.SetToolTip(Btn_XML, "")
            ToolTip1.SetToolTip(btn_SPSS, "")
        End If
    End Sub


    Private currentBtn As Button
    Private Sub ActivateButton(ByVal senderBtn As Object, ByVal color As Color)
        If senderBtn IsNot Nothing Then
            DisableButton(Color.Transparent)
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = color
        End If
    End Sub

    Private Sub DisableButton(ByVal color As Color)
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = color
        End If
    End Sub
    Public Function dajCS0(ByVal tn As String, ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable, ByVal mt As TcolInfo) As System.Data.DataColumn()
        dajCS0 = {}
        Dim cs() As System.Data.DataColumn = {}
        For Each rp As DatasetIstrazivanja.ISTPOLJARow In tp.Rows
            If rp.TABELA.Trim.ToUpper = tn.Trim.ToUpper Then
                'ako je izraz prazan ILI
                'nije prazan I NEMA :S ILI    'bilo :SN svuda
                'nije prazan I ne pocinje sa "'" ILI
                'nije prazan I NEMA GLAVA
                'nije prazan I NEMA #FP{
                Dim rpIzraz As String = ""
                Dim rpOpis As String = ""

                If rp.IsIzrazNull = False Then
                    rpIzraz = rp.Izraz.Trim.ToUpper

                    If rp.IsIzrazNull OrElse rpIzraz = "" _
                                OrElse InStr(rpIzraz.ToUpper, "CHECKBOX") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATAGRIDVIEW") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "RADIOBUTTON") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBO{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBW{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATETIMEPICKER") > 0 OrElse InStr(rpIzraz.ToUpper, "ENCRYPT") > 0 Then
                    Else
                        rpIzraz = zameniRPIZRAZ(rpIzraz)
                    End If
                End If

                If rp.IsOpisNull = True Then
                Else
                    rpOpis = rp.Opis.Trim
                    Dim poz1 As Integer = rpOpis.LastIndexOf("$")
                    Dim poz2 As Integer = rpOpis.IndexOf("#")
                    If poz1 = 0 AndAlso poz2 = 1 Then rpOpis = "" '$#
                    If poz1 < 0 AndAlso poz2 = 0 Then rpOpis = "" 'nema $, ima #
                    If poz1 >= 0 AndAlso poz2 < 0 Then rpOpis = rpOpis.Substring(poz1 + 1) 'ima $, nema #
                    If poz1 >= 0 AndAlso poz2 > poz1 AndAlso poz2 > 1 Then rpOpis = rpOpis.Substring(poz1 + 1, poz2 - poz1 - 1)
                End If

                If rpIzraz.Length = 0 OrElse
                       InStr(rpIzraz.ToUpper, "CBO{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "CBW{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "ENCRYPT") >= 0 OrElse
                       InStr(rpIzraz.ToUpper, ":S") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "#FP{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "{") > 0 OrElse
                       (InStr(rpIzraz.ToUpper, ":S") = 0 AndAlso InStr(rpIzraz.ToUpper, "ISTLBL") = 0 AndAlso
                       rpIzraz.Substring(0, 1) <> "'" AndAlso rpIzraz.Substring(0, 1) <> "{" AndAlso
                       Not (rpIzraz.Length = 14 AndAlso rpIzraz.ToUpper.Substring(0, 14) = "DATETIMEPICKER") AndAlso
                       Not (rpIzraz.Length = 9 AndAlso rpIzraz.ToUpper.Substring(0, 9) = "LINKLABEL") AndAlso
                       Not (rpIzraz.Length = 12 AndAlso rpIzraz.ToUpper.Substring(0, 12) = "DATAGRIDVIEW") AndAlso
                       Not (rpIzraz.Length = 12 AndAlso rpIzraz.ToUpper.Substring(0, 12) = "AUTOCOMPLETE") AndAlso
                       ((InStr(rpIzraz.ToUpper, "CBO{") = 0 AndAlso InStr(rpIzraz.ToUpper, "CBW{") = 0 AndAlso
                       InStr(rpIzraz.ToUpper, "GLAVA.") = 0 AndAlso
                       InStr(rpIzraz.ToUpper, "HEAD.") = 0)) AndAlso
                       InStr(rpIzraz.ToUpper, "#FP{") = 0 AndAlso InStr(rpIzraz.ToUpper, "FCALCULATEAGE") = 0) Then

                    Dim ok As Boolean = True
                    If rpIzraz.Trim.ToUpper.IndexOf("FCALCULATEAGE") >= 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("#FP{") >= 0 OrElse
                       rpIzraz.Trim.ToUpper.IndexOf(":S") >= 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("DATAGRIDVIEW") >= 0 OrElse
                       rpIzraz.Trim.ToUpper.IndexOf("AUTOCOMPLETE") >= 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("ENCRYPT") >= 0 OrElse
                        (rpIzraz.Trim.ToUpper.IndexOf("RADIOBUTTON") < 0 AndAlso rpIzraz.Trim.ToUpper.IndexOf("BUTTON") >= 0) OrElse
                        rpIzraz.Trim.ToUpper.IndexOf("ISTLBL") >= 0 Then ok = False
                    If rpIzraz.IndexOf("'") = 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("{") = 0 Then ok = False
                    If ok = True Then
                        Dim c As New System.Data.DataColumn
                        If rpIzraz = "" _
                                OrElse InStr(rpIzraz.ToUpper, "CHECKBOX") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATAGRIDVIEW") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "AUTOCOMPLETE") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "ENCRYPT") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "RADIOBUTTON") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, ":S") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBO{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBW{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATETIMEPICKER") > 0 Then
                            c = mt.dt.Columns(rp.POLJE.Trim)
                        Else
                            Dim jesteIzraz As Boolean = False
                            If InStr(rpIzraz, "#") = 0 Then
                                Dim bbb() As String = razkvantaj(rpIzraz)
                                For i As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(i).Trim.ToUpper = "CASE" Then ' OrElse bbb(i) = "+" OrElse bbb(i) = "*" OrElse bbb(i) = "/" OrElse bbb(i) = "-" Then
                                        jesteIzraz = True
                                        Exit For
                                    End If
                                Next
                            End If

                            If InStr(rpIzraz, "#") <> 0 OrElse InStr(rpIzraz, "%:%") <> 0 OrElse jesteIzraz = True Then
                                c.Expression = "Parent(Exp1).Naziv"
                            Else
                                c.Expression = rpIzraz
                            End If
                            c.ColumnName = rp.POLJE.Trim
                            c.ExtendedProperties.Add("Izraz", rpIzraz)
                            If Not rp.IsOpisNull Then mt.dt.Columns(rp.POLJE.Trim).Caption = rpOpis
                        End If

                        If c Is Nothing Then
                            ''msg 48
                            Dim msgtxt48 As String = getMessageText(dtMessages, "48", Me.jezik)
                            ''msg 197
                            Dim msgtxt197 As String = getMessageText(dtMessages, "197", Me.jezik)
                            ISTMessageBox.Show(msgtxt48 + " " + rp.POLJE.Trim + " " + msgtxt197, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            If Not rp.IsOpisNull Then c.Caption = rpOpis
                            ReDim Preserve cs(1 + cs.GetUpperBound(0))
                            cs(cs.GetUpperBound(0)) = c
                        End If
                        c.Dispose()
                    End If
                End If
            End If
        Next
        Return cs
    End Function

    Public Sub appendTS0(ByVal rb As DatasetIstrazivanja.ISTBAZERow,
                         ByVal tpagslog As System.Windows.Forms.TabPage, ByVal tpagprikaz As System.Windows.Forms.TabPage, ByVal tpagcelatab As System.Windows.Forms.TabPage,
                         ByVal mt As TcolInfo)

        Call SetLangTColInfo0(mt)
        mt.dt_greskeZaSlog = mt.mdsgre.Greske_za_slog
        mt.dt_greskeZaSlog.TableName = mt.tab1

        ''Greske_za_slog
        Call imenaKolona40(mt.mdsgre.Tables(0), mt)

        mt.dg_greskeZaSlog = New DataGridView
        mt.dg_greskeZaSlog.Visible = False
        tpagslog.Controls.Add(mt.dg_greskeZaSlog)
        For Each c2 As System.Data.DataColumn In mt.dt_greskeZaSlog.Columns
            c2.ReadOnly = True
        Next
        Dim av(mt.dt_greskeZaSlog.Columns.Count - 1) As System.Data.DataColumn
        mt.dt_greskeZaSlog.Columns.CopyTo(av, 0)

        mt.dt_greskeZaSlog.DefaultView.AllowNew = False
        mt.dt_greskeZaSlog.DefaultView.AllowDelete = False
        mt.dg_greskeZaSlog.DataSource = mt.dt_greskeZaSlog

        'Greske_za_prikazane_slogove
        mt.dt_greskeZaPrikazaneSlogove = mt.mdsgre.Greske_za_prikazane_slogove
        mt.dt_greskeZaPrikazaneSlogove.TableName = mt.tab2
        Call imenaKolona50(mt.mdsgre.Tables(1), mt)
        mt.dg_greskeZaPrikazaneSlogove = New DataGridView
        mt.dg_greskeZaPrikazaneSlogove.Visible = False
        tpagprikaz.Controls.Add(mt.dg_greskeZaPrikazaneSlogove)
        For Each col As System.Data.DataColumn In mt.dt_greskeZaPrikazaneSlogove.Columns
            col.ReadOnly = True
        Next
        Dim cs2(mt.dt_greskeZaPrikazaneSlogove.Columns.Count - 1) As System.Data.DataColumn
        mt.dt_greskeZaPrikazaneSlogove.Columns.CopyTo(cs2, 0)
        '   mt.dg_greskeZaPrikazaneSlogove.MyAppendTableStyle(mt.dt_greskeZaPrikazaneSlogove.TableName, cs2, cs2, Nothing)
        mt.dt_greskeZaPrikazaneSlogove.DefaultView.AllowNew = False
        mt.dt_greskeZaPrikazaneSlogove.DefaultView.AllowDelete = False
        mt.dt_greskeZaPrikazaneSlogove.DefaultView.Sort = mt.dt_greskeZaPrikazaneSlogove.SlogovaColumn.ColumnName + " desc"
        mt.dg_greskeZaPrikazaneSlogove.DataSource = mt.dt_greskeZaPrikazaneSlogove

        mt.dg_greskeZaTabelu = New DataGridView
        mt.Visible = False
        tpagcelatab.Controls.Add(mt.dg_greskeZaTabelu)
        mt.LKizvestaj = New LKizv(Me.DBConnectionString, rb, mt.mtlk, mt.dg_greskeZaTabelu, Nothing, False, Me.tacv, Me.jezik)

        mt.greskeSetVisible(True)
        'ovo davi strasno, prebaceno da se radi kad se klikne na tab Greske za celu tabelu
        'Me.daj_dt_greskeZaTabelu()
        'ovo davi strasno
    End Sub
    Private Sub SetLangTColInfo0(ByVal mt As TcolInfo)
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formAzuriraj")
        '****GRIDOVI
        mt.dgGrid8 = getControlText2(dt, "dgGrid8", Me.jezik)
        mt.dgGrid9 = getControlText2(dt, "dgGrid9", Me.jezik)
        mt.dgGrid11 = getControlText2(dt, "dgGrid11", Me.jezik)
        mt.dgGrid17 = getControlText2(dt, "dgGrid17", Me.jezik)
        mt.tab1 = getControlText2(dt, "TabPageGreskeZaSlog", Me.jezik)
        mt.tab2 = getControlText2(dt, "TabPageGreskeZaPrikazaneSlogove", Me.jezik)
    End Sub

    Sub imenaKolona40(ByVal dgDT As System.Data.DataTable, ByVal mt As TcolInfo)
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = mt.dgGrid8
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = mt.dgGrid9
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = mt.dgGrid11
    End Sub

    Sub imenaKolona50(ByVal dgDT As System.Data.DataTable, ByVal mt As TcolInfo)
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = mt.dgGrid8
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = mt.dgGrid9
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = mt.dgGrid11
        If Not dgDT.Columns("Slogova") Is Nothing Then dgDT.Columns("Slogova").ColumnName = mt.dgGrid17
    End Sub


    Function IzabranaTabelaIndikatorJe() As Integer
        Try
            IzabranaTabelaIndikatorJe = -1
            If Not niz_izabranaTabela Is Nothing Then
                For i As Integer = 0 To niz_izabranaTabela.GetUpperBound(0)
                    If niz_izabranaTabela(i).Trim.ToUpper.IndexOf(";1") > 0 Then
                        IzabranaTabelaIndikatorJe = i
                        Exit For
                    End If
                Next
            End If
            Return IzabranaTabelaIndikatorJe
        Catch ex As Exception

        End Try

    End Function
    Public Sub RowSelection()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()

        frsR = New FormAzurirajFilterRows(Me.dsIST, Me.tacv, niz_dgv, niz_TColInfo, sveTabele, sveTabeleSAPFX, Me.txtpismo, Me.jezik, GlavneIliPomocne, txtmode, mdtLabel, pomind)
        If dodakle <> "LK" Then
            Try
                frsR.ShowDialog()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frsR.Dispose()
            End Try
            If frsR.DialogResult = DialogResult.Cancel Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Return
            End If
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
        'MORA DA SE PREKINE KURSOR
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call visibleFalseSviDGV()

        Dim ind As Integer = -1
        If dodakle <> "LK" Then
            ind = frsR.indikator
        Else
            ind = pomind
        End If

        Call izabranaTabelaPostavi(ind)

        niz_frsCheckBoxPrvihRedova(ind) = frsR.CheckBoxPrvihRedova.Checked
        niz_frsNumericUpDownPrvihRedovaValue(ind) = frsR.NumericUpDownPrvihRedova.Value
        niz_frscmbTezinaGreskeSelectedItem(ind) = frsR.cmbTezinaGreske.SelectedItem
        niz_frsComboBoxRedoviSelectedItem(ind) = frsR.ComboBoxRedovi.SelectedItem

        If Not niz_pk(ind) Is Nothing Then niz_pk(ind) = frsR.dgvPrimaryKey.DataSource.Rows(0)
        If Not niz_gr(ind) Is Nothing Then niz_gr(ind) = frsR.dgvErrorColumns.DataSource.Rows(0)
        If Not niz_kol(ind) Is Nothing Then niz_kol(ind) = frsR.dgvUpdatableColumns.DataSource.Rows(0)

        'izabranatabela = sveTabele(ind)
        Dim nnode As TreeNode = SearchTheTreeView(tv, sveTabele(ind))
        Dim tt() As String = ttTtt(nnode)
        'Me.Cursor = System.Windows.Forms.Cursors.Default
        ''MORA OVAKO DA SE PREKINE PA OPET DA SE POZOVE CURSOR WAIT

        Try
            If dodakle <> "LK" Then
                Me.filtred(frsR.Get_rowcol, tt)
                niz_frsR(ind) = frsR.Get_rowcol
            Else
                Me.filtred(frsR.Get_rowcolWithError(derrNumber), tt)
                niz_frsRE(ind) = frsR.Get_rowcolWithError(derrNumber)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call popuniComboBoxTabele(ind, tt)
        If ComboBoxTabele.Items.Count > 1 Then Me.ComboBoxTabele.Enabled = True Else Me.ComboBoxTabele.Enabled = False

        niz_TColInfo(ind).pamtics = {}
        Call visibleColumns(niz_dgv(ind), niz_TColInfo(ind).mviscol, imaPodTabelu(ind) OrElse imaNadTabelu(ind))
        Call visibleColumns(niz_fdgv(ind), niz_TColInfo(ind).mviscol, imaPodTabelu(ind) OrElse imaNadTabelu(ind))

        Call visibleTrueDGV(ind)
        Call nonvisiblePanelTOP()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub izabranaTabelaPostavi(ByVal ind As Integer)
        For i As Integer = 0 To niz_izabranaTabela.GetUpperBound(0)
            niz_izabranaTabela(i) = sveTabele(ind)
        Next
        niz_izabranaTabela(ind) = sveTabele(ind) + ";1"
    End Sub
    Private Sub ColumnSelection()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()

        frsC = New FormAzurirajFilterColumns(Me.dsIST, Me.tacv, niz_dgv, niz_TColInfo, sveTabele, sveTabeleSAPFX, Me.txtpismo, Me.jezik, GlavneIliPomocne, txtmode, mdtLabel, pomind, chbA.Checked)

        Try
            frsC.ShowDialog()
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frsC.Dispose()
        End Try

        If frsC.DialogResult = DialogResult.Cancel Then
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End If

        Dim ind As Integer = frsC.indikator

        'If niz_izabranaTabela Is Nothing Then ReDim Preserve niz_izabranaTabela(niz_dgv.GetUpperBound(0))
        Call izabranaTabelaPostavi(ind)

        If niz_Left Is Nothing Then ReDim Preserve niz_Left(niz_dgv.GetUpperBound(0))
        Dim poml As String = ""
        For i As Integer = 0 To frsC.lleft.Items.Count - 1
            poml = poml + frsC.lleft.Items(i).ToString.Trim + ";"
        Next
        poml = poml.TrimEnd(";")
        niz_Left(ind) = poml

        If niz_Right Is Nothing Then ReDim Preserve niz_Right(niz_dgv.GetUpperBound(0))
        Dim pomr As String = ""
        For i As Integer = 0 To frsC.lright.Items.Count - 1
            pomr = pomr + frsC.lright.Items(i).ToString.Trim + ";"
        Next
        pomr = pomr.TrimEnd(";")
        niz_Right(ind) = pomr


        Me.Cursor = System.Windows.Forms.Cursors.Default

        'MORA OVAKO DA SE PREKINE PA OPET DA SE POZOVE CURSOR WAIT

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If Not niz_Left Is Nothing AndAlso Not niz_Right Is Nothing Then
            Call DGVShowColumns22(niz_dgv(ind), niz_Left(ind), niz_Right(ind))
            Call DGVShowColumns22(niz_fdgv(ind), niz_Left(ind), niz_Right(ind))
        End If

        Me.chbA.Checked = False

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Sub DGVShowColumns22(ByVal dgv As DataGridView, ByVal lLeft As String, ByVal rRight As String)

        If Not lLeft Is Nothing Then
            Dim ll() As String = lLeft.Trim.ToUpper.Split(";")
            For i As Integer = 0 To ll.GetUpperBound(0)
                Dim nname As String = ll(i).Trim.ToUpper
                If nname <> "" AndAlso dgv.Columns.Contains(nname) Then dgv.Columns(nname).Visible = False
            Next
        End If

        If Not rRight Is Nothing Then
            Dim rr() As String = rRight.Trim.ToUpper.Split(";")
            For i As Integer = 0 To rr.GetUpperBound(0)
                Dim nname As String = rr(i).Trim.ToUpper
                If nname <> "" AndAlso dgv.Columns.Contains(nname) Then dgv.Columns(nname).Visible = True
            Next
        End If

    End Sub
    Sub visibleTrueDGV(ByVal i As Integer)

        Call srediGridView(niz_TColInfo(i).dg_greskeZaSlog, True, 20)
        niz_TColInfo(i).dg_greskeZaSlog.Dock = DockStyle.Fill

        Call srediGridView(niz_TColInfo(i).dg_greskeZaPrikazaneSlogove, False, 20)
        niz_TColInfo(i).dg_greskeZaPrikazaneSlogove.Dock = DockStyle.Fill

        Call srediGridView(niz_TColInfo(i).dg_greskeZaTabelu, False, 20)
        niz_TColInfo(i).dg_greskeZaTabelu.Dock = DockStyle.Fill
        niz_dgv(i).Dock = DockStyle.Fill
        niz_fpdgv(i).Dock = DockStyle.Fill

        Me.chbA.Visible = True
        Me.TabControlGreske.Visible = True
        niz_TColInfo(i).dg_greskeZaSlog.Visible = True
        niz_TColInfo(i).dg_greskeZaPrikazaneSlogove.Visible = True
        niz_TColInfo(i).dg_greskeZaTabelu.Visible = True

        For Each c As Control In Me.PanelMenu.Controls
            If TypeOf c Is Button Then
                If Not c.Tag Is Nothing AndAlso c.AccessibleName = "sakrij" Then
                    If niz_dgv(i).Rows.Count > 0 Then c.Visible = True Else c.Visible = False
                End If
            End If
        Next
        niz_dgv(i).ClearSelection()
        If niz_dgv(i).Rows.Count > 0 Then niz_dgv(i).Rows(0).Selected = True

        LabelTotalCount.Text = "Rows count: " + CStr(niz_dgv(i).Rows.Count)
        LabelTotalCount.Visible = True

        If Not niz_Left Is Nothing AndAlso Not niz_Right Is Nothing Then
            Call DGVShowColumns22(niz_dgv(i), niz_Left(i), niz_Right(i))
            Call DGVShowColumns22(niz_fdgv(i), niz_Left(i), niz_Right(i))
        End If

        niz_fpdgv(i).Visible = True
        niz_dgv(i).Visible = True
        niz_dgv(i).Focus()
    End Sub
    Sub popuniComboBoxTabele(ByVal ind As Integer, ByVal tt() As String)

        ComboBoxTabele.Items.Clear()
        Dim indeks As Integer = -1
        For i As Integer = 0 To tt.GetUpperBound(0)
            ComboBoxTabele.Items.Add(tt(i))
            indeks = indeks + 1
            If tt(i) = sveTabele(ind) Then
                ComboBoxTabele.SelectedIndex = indeks
            End If
        Next
        ComboBoxTabele.Visible = True
    End Sub

    Public Sub filtred(ByVal rfilt As String, ByVal tt() As String, Optional ByVal poruka As Boolean = True)
        Me.Cursor = Cursors.WaitCursor

        If dodakle = "LK" Then
            Dim ind As Integer = Array.IndexOf(sveTabele, dodakleImeTabele.Trim.ToUpper)
            niz_TColInfo(ind).dt.Rows.Clear()
            niz_dgv(ind).DataSource.Rows.Clear()
            'niz_TColInfo(ind).mgist = niz_dgv(ind)
        Else
            For i As Integer = niz_TColInfo.GetUpperBound(0) To 0 Step -1
                niz_TColInfo(i).dt.Rows.Clear()
                niz_dgv(i).DataSource.Rows.Clear()
            Next
        End If

        Dim sqlIzabrana As String = ""
        Dim sqlalias As String = "d"
        Dim uslov As String = "2=2"

        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim izabranaTabela As String = sveTabeleSAPFX(pomind).Trim
        sqlIzabrana = dajSelect(izabranaTabela, "d", rfilt, tt, imaPodTabelu(pomind), imaNadTabelu(pomind))

        Dim sql As String = ""
        Dim tabela As String = ""
        Dim izlazak As Boolean = False
        Dim prf As String = ""

        For i As Integer = 0 To tt.GetUpperBound(0)
            Dim ind As Integer = -1
            If tt(i).IndexOf(".") > 0 Then
                ind = Array.IndexOf(sveTabeleSAPFX, tt(i))
            Else
                ind = Array.IndexOf(sveTabele, tt(i))
            End If
            tabela = tt(i).Trim.ToUpper()
            prf = Me.niz_TColInfo(ind).dt.Prefix

            If prfxt(tabela.Trim).Trim.ToUpper <> prfxt(izabranaTabela).Trim.ToUpper Then
                sql = dajSelect(tabela, sqlalias, "2=2", tt, imaPodTabelu(i), imaNadTabelu(i), sqlIzabrana)
            Else
                sql = sqlIzabrana
            End If

            pamtiUpit = sql

            Try
                Dim dtt As New DataTable
                dtt = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
                Me.Cursor = Cursors.Default
                If poruka = True AndAlso prfxt(tabela.Trim).Trim.ToUpper = prfxt(izabranaTabela.Trim).Trim.ToUpper Then
                    Dim rs As Long = dtt.Rows.Count
                    ''msg 8
                    Dim msgtxt8 As String = getMessageText(dtMessages, "8", Me.jezik)
                    ''msg 9
                    Dim msgtxt9 As String = getMessageText(dtMessages, "9", Me.jezik)
                    ''msg 10
                    Dim msgtxt10 As String = getMessageText(dtMessages, "10", Me.jezik)
                    'bilo if rs > 20 AndAlso
                    If dodakle <> "LK" AndAlso ISTMessageBox.Show(msgtxt8 + " " + rs.ToString + msgtxt9, msgtxt10, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Cancel Then
                        Exit For
                    End If
                End If
                Me.Cursor = Cursors.WaitCursor
                Call secondRowHeader(dtt, tabela, prf, ind)

            Catch ex As System.Exception
                Me.Cursor = Cursors.Default
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next


        Me.Cursor = Cursors.Default
    End Sub
    Public Sub filtredT(ByVal rfilt As String, ByVal tabela As String)

        Dim ind As Integer = -1
        If tabela.IndexOf(".") > 0 Then
            ind = Array.IndexOf(sveTabeleSAPFX, tabela)
        Else
            ind = Array.IndexOf(sveTabele, tabela)
        End If

        Dim prf As String = Me.niz_TColInfo(ind).dt.Prefix
        Dim sql As String = ""
        Dim izlazak As Boolean = False

        niz_TColInfo(ind).dt.Rows.Clear()
        niz_dgv(ind).DataSource.Rows.Clear()

        sql = dajSelectT(tabela, rfilt, ind)
        'pamtiUpit = sql

        Try
            Dim dtt As New DataTable
            dtt = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
            Call secondRowHeader(dtt, tabela, prf, ind)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub secondRowHeader(ByVal dtt As DataTable, ByVal tabela As String, ByVal prf As String, ByVal ind As Integer)
        Dim imaNadT As Boolean = imaNadTabelu(ind)
        Dim imaPodT As Boolean = imaPodTabelu(ind)
        Dim glavnatabela As String = GtabelaJe(sveTabele(ind).Trim.ToUpper)

        Dim secondRowHeader As String = ""
        Dim prikazi As Boolean = False
        If imaNadT = False AndAlso imaPodT = False Then
            secondRowHeader = ""
            prikazi = False
        ElseIf glavnatabela.Trim.ToUpper = sveTabele(ind).Trim.ToUpper AndAlso imaPodT = True Then
            secondRowHeader = "➕"
            prikazi = True
        ElseIf imaNadT = True AndAlso imaPodT = False Then
            secondRowHeader = "➖"
            prikazi = True
        ElseIf imaNadT = True AndAlso imaPodT = True Then
            secondRowHeader = "➕"
            prikazi = True
        Else
            prikazi = False
        End If

        For im As Integer = 0 To dtt.Rows.Count - 1
            niz_TColInfo(ind).dt.ImportRow(dtt.Rows(im))
            If Not niz_TColInfo(ind).dt.Columns("secondRowHeader") Is Nothing Then
                niz_TColInfo(ind).dt.Rows(im).Item("secondRowHeader") = secondRowHeader
            End If
        Next

        niz_TColInfo(ind).dt.TableName = tabela
        niz_TColInfo(ind).dt.Prefix = prf
        niz_TColInfo(ind).dt.AcceptChanges()
        niz_TColInfo(ind).mgist = niz_dgv(ind)
        niz_dgv(ind).DataSource = niz_TColInfo(ind).dt

        Dim t2 As New System.Data.DataTable

        Call Grid22(niz_TColInfo(ind).dt.PrimaryKey, niz_TColInfo(ind).ucol, t2, Me.tacv, secondRowHeader)

        t2.DefaultView.AllowNew = False
        t2.DefaultView.AllowDelete = False
        niz_fdgv(ind).DataSource = t2

        Call visibleColumns(niz_fdgv(ind), niz_TColInfo(ind).mviscol, prikazi)
        Call visibleColumns(niz_dgv(ind), niz_TColInfo(ind).mviscol, prikazi)

    End Sub

    Private Sub Grid22(ByVal cs() As System.Data.DataColumn, ByVal cs2() As System.Data.DataColumn, ByVal t As System.Data.DataTable,
                      ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal secondRowHeader As String)
        Dim c As System.Data.DataColumn
        Dim vs() As Object = {}

        '***CUVAJ ZA PRIMER
        ' Dim icon As Image = My.Resources.filter.ToBitmap
        ' Convert the icon to a byte array
        'Dim iconBytes As Byte() = ImageToByteArray(icon)
        'Dim col1 As New System.Data.DataColumn("secondRowHeader", GetType(Byte()))
        't.Columns.Add(col1)
        'ReDim Preserve vs(1 + vs.GetUpperBound(0))
        ''vs(vs.GetUpperBound(0)) = "🔎"
        'vs(vs.GetUpperBound(0)) = iconBytes
        'col1.ReadOnly = True
        '***CUVAJ ZA PRIMER


        Dim col1 As New System.Data.DataColumn("secondRowHeader", GetType(System.String))
        t.Columns.Add(col1)
        ReDim Preserve vs(1 + vs.GetUpperBound(0))
        vs(vs.GetUpperBound(0)) = ""
        col1.ReadOnly = True

        For Each c In cs
            If c.ColumnName.Trim <> "INDGR" Then
                Dim col2 As New System.Data.DataColumn(c.ColumnName, c.DataType)
                If Not c.ExtendedProperties Is Nothing Then
                    For Each k As Object In c.ExtendedProperties.Keys
                        col2.ExtendedProperties.Add(k, c.ExtendedProperties.Item(k))
                    Next
                End If
                t.Columns.Add(col2)
                Dim val As Object = System.DBNull.Value
                If c.DataType Is GetType(Boolean) Then
                    c.AllowDBNull = False
                    val = False
                End If
                If c.ColumnName.Trim.ToUpper = "GOD" OrElse c.ColumnName.Trim.ToUpper = "ISTYEAR" Then
                    val = vt.G.ToString
                    col2.DefaultValue = val
                    col2.ReadOnly = True
                ElseIf c.ColumnName.Trim.ToUpper = "MES" OrElse c.ColumnName.Trim.ToUpper = "ISTMONTH" Then
                    val = String.Format("{0:d2}", vt.M)
                    col2.DefaultValue = val
                    col2.ReadOnly = True
                End If
                ReDim Preserve vs(1 + vs.GetUpperBound(0))
                vs(vs.GetUpperBound(0)) = val
            End If
        Next
        For Each c In cs2
            If c.ColumnName.Trim <> "INDGR" Then
                Dim col2 As New System.Data.DataColumn(c.ColumnName, c.DataType)
                If Not c.ExtendedProperties Is Nothing Then
                    For Each k As Object In c.ExtendedProperties.Keys
                        col2.ExtendedProperties.Add(k, c.ExtendedProperties.Item(k))
                    Next
                End If
                t.Columns.Add(col2)
                Dim val As Object = System.DBNull.Value
                If c.DataType Is GetType(Boolean) Then
                    c.AllowDBNull = False
                    val = False
                End If
                If c.ColumnName.Trim.ToUpper = "GOD" OrElse c.ColumnName.Trim.ToUpper = "ISTYEAR" Then
                    val = vt.G.ToString
                    col2.DefaultValue = val
                    col2.ReadOnly = True
                ElseIf c.ColumnName.Trim.ToUpper = "MES" OrElse c.ColumnName.Trim.ToUpper = "ISTMONTH" Then
                    val = String.Format("{0:d2}", vt.M)
                    col2.DefaultValue = val
                    col2.ReadOnly = True
                End If
                ReDim Preserve vs(1 + vs.GetUpperBound(0))
                vs(vs.GetUpperBound(0)) = val
            End If
        Next

        t.Rows.Add(vs)
        t.AcceptChanges()

    End Sub
    Private Function ImageToByteArray(imageIn As System.Drawing.Image) As Byte()
        Using ms As New System.IO.MemoryStream()
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function
    Private Function postojiNadtabelaJe(ByVal t As String) As Boolean
        'nadji podatbela sta je
        postojiNadtabelaJe = False
        For Each r As DatasetIstrazivanja.ISTTABELERow In Me.mtt.Rows
            If r.Tabela.Trim.ToUpper = t.Trim.ToUpper AndAlso (Not r.IsNadTabelaNull) AndAlso r.NadTabela.Trim.ToUpper <> "" Then
                postojiNadtabelaJe = True
                Exit For
            End If
        Next
    End Function
    Private Function postojipodtabelaJe(ByVal t As String) As Boolean
        'nadji podatbela sta je
        postojipodtabelaJe = False
        For Each r As DatasetIstrazivanja.ISTTABELERow In Me.mtt.Rows
            If (Not r.IsNadTabelaNull) AndAlso r.NadTabela.Trim.ToUpper = t.Trim.ToUpper Then
                postojipodtabelaJe = True
                Exit For
            End If
        Next
    End Function
    Private Function nadtabelaJe(ByVal t As String) As String
        'nadji nadtabela sta je
        nadtabelaJe = ""
        For Each r As DatasetIstrazivanja.ISTTABELERow In Me.mtt.Rows
            If (Not r.IsNadTabelaNull) AndAlso r.Tabela.Trim.ToUpper = t.Trim.ToUpper Then
                nadtabelaJe = r.NadTabela.Trim.ToUpper
                Exit For
            End If
        Next
    End Function
    Private Function GtabelaJe(ByVal t As String) As String
        'nadji nadNAdtabela sta je
        Dim nn As String = ""
        For Each r As DataRow In redoviMEM
            If r.Item("tabela").ToString.Trim.ToUpper = t.Trim.ToUpper Then
                Dim rtNadTabela As String = IIf(r.Item("NadTabela") Is System.DBNull.Value, "", r.Item("NadTabela").ToString.Trim.ToUpper)
                If rtNadTabela <> "" Then
                    nn = rtNadTabela
                    If nn.Trim <> "" Then
                        If DGT(nn) <> "D" Then
                            GtabelaJe = rtab(nn)
                            Exit Function
                        Else
                            GtabelaJe = GtabelaJe(nn)
                        End If
                    Else
                        GtabelaJe = rtab(t.Trim.ToUpper)
                        Exit Function
                    End If
                Else
                    GtabelaJe = rtab(t.Trim.ToUpper)
                    Exit Function
                End If
            End If
        Next

    End Function

    Function NadjiSvePodTabeleOD(tabela As String) As String()
        NadjiSvePodTabeleOD = {}
        Dim ff = SvePodTabeleOD(tabela)
        Dim pp() As String = {}
        Dim ipp As Integer = -1
        For Each pT As String In ff
            ipp = ipp + 1
            ReDim Preserve pp(ipp)
            pp(ipp) = pT
        Next
        NadjiSvePodTabeleOD = pp
    End Function
    Function SvePodTabeleOD(tabela As String) As HashSet(Of String)
        Dim SvePodTabele As New HashSet(Of String)
        Dim toProcess As New Stack(Of String)

        toProcess.Push(tabela)
        While toProcess.Count > 0
            Dim currentTable As String = toProcess.Pop()
            Dim r() As DataRow = Me.dsIST.ISTTABELE.Select("isnull(DG,'G')='D' and isnull(baza,'')<>'0' and isnull(nadtabela,'') ='" + currentTable + "'")
            If r.Count > 0 Then
                For i As Integer = 0 To r.Count - 1
                    Dim podTabela As String = IIf(r(i).Item("Tabela") Is System.DBNull.Value, "", r(i).Item("Tabela").ToString.Trim.ToUpper)
                    If Not SvePodTabele.Contains(podTabela) Then
                        SvePodTabele.Add(podTabela)
                        toProcess.Push(podTabela)
                    End If
                Next
            End If
        End While
        Return SvePodTabele
    End Function
    Function NadjiSveNadTabeleOD(tabela As String) As String()
        NadjiSveNadTabeleOD = {}
        Dim ff = SveNadTabeleOD(tabela)
        Dim pp() As String = {}
        Dim ipp As Integer = -1
        For Each pT As String In ff
            ipp = ipp + 1
            ReDim Preserve pp(ipp)
            pp(ipp) = pT
        Next
        NadjiSveNadTabeleOD = pp
    End Function
    Function SveNadTabeleOD(tabela As String) As HashSet(Of String)
        Dim SveNadTabele As New HashSet(Of String)
        Dim toProcess As New Stack(Of String)

        toProcess.Push(tabela)
        While toProcess.Count > 0
            Dim currentTable As String = toProcess.Pop()
            Dim r() As DataRow = Me.dsIST.ISTTABELE.Select("isnull(DG,'G')='D' and isnull(baza,'')<>'0' and isnull(tabela,'') ='" + currentTable + "'")
            If r.Count > 0 Then
                For i As Integer = 0 To r.Count - 1
                    Dim nadTabela As String = IIf(r(i).Item("nadtabela") Is System.DBNull.Value, "", r(i).Item("nadtabela").ToString.Trim.ToUpper)
                    If Not SveNadTabele.Contains(nadTabela) Then
                        SveNadTabele.Add(nadTabela)
                        toProcess.Push(nadTabela)
                    End If
                Next
            End If
        End While
        Return SveNadTabele
    End Function
    Function DGT(ByVal t As String) As String
        DGT = ""
        For Each rt As DataRow In redoviMEM
            If rt.Item("tabela").ToString.Trim.ToUpper = t.Trim.ToUpper Then
                Dim rtDG As String = IIf(rt.Item("DG") Is System.DBNull.Value, "", rt.Item("DG"))
                If rtDG.Trim = "" Then DGT = "G" Else DGT = rtDG
                Exit For
            End If
        Next
        Return DGT
    End Function
    Function rtab(ByVal t As String) As String
        rtab = ""
        For Each rt As DataRow In redoviMEM
            If rt.Item("tabela").ToString.Trim.ToUpper = t.Trim.ToUpper Then
                rtab = rt.Item("tabela")
                Exit For
            End If
        Next
        Return rtab
    End Function
    Private Function getexprSQL(ByVal r2 As System.Data.DataRow, ByVal tn As String, ByVal cn As String, Optional ByVal prefiks As String = "") As String
        Dim sql As String = ""
        For Each col As System.Data.DataColumn In r2.Table.PrimaryKey
            If Not r2.IsNull(col.ColumnName) Then
                If sql <> "" Then sql = sql + " and "
                sql = sql + Postavi(r2, col, False, prefiks)
            End If
        Next
        Dim v As String = Me.tacv.vWhere(tn, cn, Me.DBConnectionString, prefiks)
        If v <> "" Then
            If sql <> "" Then sql = sql + " and "
            sql = sql + v
        End If
        Return sql
    End Function
    Private Function dajSelect(ByVal tabela As String, ByVal sqlalias As String,
                               ByVal rfilt As String, ByVal tt() As String, ByVal imaPodT As Boolean, ByVal imaNadT As Boolean,
                               Optional ByVal sqlIzabrana As String = "") As String
        Dim selectDdeo As String = ""
        Dim poljaDdeo As String = ""
        Dim fromDdeo As String = ""
        Dim whereDdeo As String = ""

        Dim ppp As String = CStr(tabela)
        If ppp.IndexOf("DBO.") = 0 Then
            Dim pp() As String = ppp.Split(".")
            tabela = pp(0)
            If pp.Length > 0 Then tabela = pp(1)
        End If
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim izabranaTabela As String = sveTabeleSAPFX(pomind).Trim
        Dim pomizabranatabela As String = izabranaTabela
        Dim bbb As String = CStr(pomizabranatabela)
        If bbb.IndexOf("DBO.") = 0 Then
            Dim pp() As String = bbb.Split(".")
            pomizabranatabela = pp(0)
            If pp.Length > 0 Then pomizabranatabela = pp(1)
        End If

        Dim indTab As Integer = Array.IndexOf(tt, tabela)
        Dim indIz As Integer = Array.IndexOf(tt, pomizabranatabela)

        Dim tabelaTColInfo As TcolInfo = Nothing
        Dim izabranaTabelaTcolInfo As TcolInfo = Nothing

        Dim indTab2 As Integer = -1
        If tabela.IndexOf(".") > 0 Then
            indTab2 = Array.IndexOf(sveTabeleSAPFX, tabela)
        Else
            indTab2 = Array.IndexOf(sveTabele, tabela)
        End If

        Dim indIz2 As Integer = Array.IndexOf(sveTabele, pomizabranatabela)
        If pomizabranatabela.IndexOf(".") > 0 Then
            indIz2 = Array.IndexOf(sveTabeleSAPFX, pomizabranatabela)
        Else
            indIz2 = Array.IndexOf(sveTabele, pomizabranatabela)
        End If

        tabelaTColInfo = niz_TColInfo(indTab2)
        tabelaTColInfo.dt.Prefix = niz_TColInfo(indTab2).dt.Prefix
        tabelaTColInfo.dt.TableName = niz_TColInfo(indTab2).dt.TableName

        izabranaTabelaTcolInfo = niz_TColInfo(indIz2)
        izabranaTabelaTcolInfo.dt.Prefix = niz_TColInfo(indIz2).dt.Prefix
        izabranaTabelaTcolInfo.dt.TableName = niz_TColInfo(indIz2).dt.TableName

        Dim TabelaSaPrefiksom As String = tabela
        If tabelaTColInfo.dt.Prefix.Trim.ToUpper <> "DBO" AndAlso TabelaSaPrefiksom.IndexOf(".") < 0 Then
            TabelaSaPrefiksom = tabelaTColInfo.dt.Prefix.Trim.ToUpper + "." + TabelaSaPrefiksom
        End If

        Dim TabelaSaPrefiksomSaBazom As String = tabelaSQL(Me.m_rowIST.ISTBAZERow, Nothing, TabelaSaPrefiksom)

        'WHERE
        If rfilt <> "" Then whereDdeo = " where 2=2 and " + rfilt
        Dim vtacka As String = Me.tacv.vWhere(TabelaSaPrefiksomSaBazom, sqlalias, Me.DBConnectionString)
        If vtacka <> "" Then whereDdeo = whereDdeo + " and " + vtacka

        For Each rp As DatasetIstrazivanja.ISTPOLJARow In Me.mtp.Rows
            If rp.TABELA.Trim.ToUpper = TabelaSaPrefiksom Then
                Dim rDG As String = ""
                If rp.IsKLJUCNull = False AndAlso rp.KLJUC = "P" AndAlso rp.IsDGNull = False Then
                    If rp.DG.Trim.ToUpper.IndexOf("{LK}") >= 0 Then
                        whereDdeo = whereDdeo + " and " + sqlalias + "." & rp.POLJE & " not like 'IST'"
                        Exit For
                    End If
                End If
            End If
        Next
        'WHERE kraj

        'FROM
        fromDdeo = " from " + TabelaSaPrefiksomSaBazom + " " + sqlalias + ""
        fromDdeo = DodajPMGK(fromDdeo, tabela) + nvrd
        'FROM kraj

        'POLJA
        poljaDdeo = ssel(tabelaTColInfo, True)
        Dim secondRowheader As String = ""
        If imaPodT Then secondRowheader = "N'' as secondRowHeader,"
        If imaNadT Then secondRowheader = "N'' as secondRowHeader,"
        poljaDdeo = secondRowheader + poljaDdeo
        'POLJA kraj

        'SELECT CEO
        selectDdeo = poljaDdeo + nvrd + fromDdeo + nvrd + whereDdeo
        'selectDdeo = DodajPMGK(selectDdeo, tabela) + nvrd

        'ORDERBY
        Dim orderByDeo As String = ""
        Dim trebaOrderBy As Boolean = True
        If sqlIzabrana = "" AndAlso niz_frsCheckBoxPrvihRedova(indTab2) = True Then
            selectDdeo = "select top " + CInt(niz_frsNumericUpDownPrvihRedovaValue(indTab2)).ToString + " " + selectDdeo
            trebaOrderBy = True
        Else
            selectDdeo = "select " + selectDdeo
            trebaOrderBy = False
        End If

        If trebaOrderBy = True Then
            For Each kk As System.Data.DataColumn In tabelaTColInfo.dt.PrimaryKey
                orderByDeo = orderByDeo + "" + sqlalias + "." + kk.ColumnName.ToUpper + ","
            Next
            If orderByDeo.Trim <> "" Then
                orderByDeo = " order by " + orderByDeo.TrimEnd(",")
            End If
        End If
        'ORDERBY kraj

        selectDdeo = selectDdeo + orderByDeo
        'SELECT CEO kraj

        If sqlIzabrana <> "" Then
            Dim sqlJoin As String = ""

            If indTab < indIz Then
                For i As Integer = 0 To tabelaTColInfo.dt.PrimaryKey.Length - 1
                    sqlJoin = sqlJoin + " A." + tabelaTColInfo.dt.PrimaryKey(i).ColumnName + " = B." + tabelaTColInfo.dt.PrimaryKey(i).ColumnName + " and" 'ovo je kad je izabrana podtabela, a ti njena nadtabela
                Next
            End If
            If indTab > indIz Then
                For i As Integer = 0 To izabranaTabelaTcolInfo.dt.PrimaryKey.Length - 1
                    sqlJoin = sqlJoin + " A." + izabranaTabelaTcolInfo.dt.PrimaryKey(i).ColumnName + " = B." + izabranaTabelaTcolInfo.dt.PrimaryKey(i).ColumnName + " and" 'ovo je kad je izabrana podtabela, a ti njena nadtabela
                Next
            End If

            sqlJoin = sqlJoin + "$"
            sqlJoin = sqlJoin.Replace(" and$", "")

            Dim pp As Integer = sqlIzabrana.Trim.ToLower.IndexOf(" order by ")
            Dim sqlIzabranaBezOB As String = ""
            If pp > -1 Then
                sqlIzabranaBezOB = sqlIzabrana.Substring(0, pp)
            Else
                sqlIzabranaBezOB = sqlIzabrana
            End If

            Dim slqI As String = ""
            If trebaOrderBy = True Then slqI = sqlIzabrana
            If trebaOrderBy = False Then slqI = sqlIzabranaBezOB

            Dim pp2 As Integer = selectDdeo.Trim.ToLower.IndexOf(" order by ")
            Dim selectDdeoBezOB As String
            Dim selectDdeoOB As String = ""
            If pp2 > -1 Then
                selectDdeoBezOB = selectDdeo.Substring(0, pp2)
                selectDdeoOB = selectDdeo.Substring(pp2).Replace(" d.", " a.").Replace(",d.", ",a.")
            Else
                selectDdeoBezOB = selectDdeo
                selectDdeoOB = ""
            End If

            dajSelect = "select * into #aaa from (" + slqI + ") pom;" + nvrd + nvrd + nvrd + nvrd +
                        "select distinct a.* from (" + selectDdeoBezOB + ") a inner join (select * from #aaa) b on " + sqlJoin + " " + selectDdeoOB

        Else
            dajSelect = selectDdeo
        End If


    End Function
    Private Function dajSelectT(ByVal tabela As String, ByVal rfilt As String, ByVal ind As Integer) As String
        Dim selectDdeo As String = ""
        Dim poljaDdeo As String = ""
        Dim fromDdeo As String = ""
        Dim whereDdeo As String = ""

        Dim tabelaTColInfo As TcolInfo = Nothing
        Dim izabranaTabelaTcolInfo As TcolInfo = Nothing

        tabelaTColInfo = niz_TColInfo(ind)
        tabelaTColInfo.dt.Prefix = niz_TColInfo(ind).dt.Prefix
        tabelaTColInfo.dt.TableName = niz_TColInfo(ind).dt.TableName


        Dim TabelaSaPrefiksom As String = tabela
        If tabelaTColInfo.dt.Prefix.Trim.ToUpper <> "DBO" AndAlso TabelaSaPrefiksom.IndexOf(".") < 0 Then
            TabelaSaPrefiksom = tabelaTColInfo.dt.Prefix.Trim.ToUpper + "." + TabelaSaPrefiksom
        End If

        Dim TabelaSaPrefiksomSaBazom As String = tabelaSQL(Me.m_rowIST.ISTBAZERow, Nothing, TabelaSaPrefiksom)
        Dim sqlalias As String = "d"
        'WHERE
        If rfilt <> "" Then whereDdeo = " where 2=2 and " + rfilt
        Dim vtacka As String = Me.tacv.vWhere(TabelaSaPrefiksomSaBazom, sqlalias, Me.DBConnectionString)
        If vtacka <> "" Then whereDdeo = whereDdeo + " and " + vtacka

        For Each rp As DatasetIstrazivanja.ISTPOLJARow In Me.mtp.Rows
            If rp.TABELA.Trim.ToUpper = TabelaSaPrefiksom Then
                Dim rDG As String = ""
                If rp.IsKLJUCNull = False AndAlso rp.KLJUC = "P" AndAlso rp.IsDGNull = False Then
                    If rp.DG.Trim.ToUpper.IndexOf("{LK}") >= 0 Then
                        whereDdeo = whereDdeo + " and " + sqlalias + "." & rp.POLJE & " not like 'IST'"
                        Exit For
                    End If
                End If
            End If
        Next
        'WHERE kraj

        'FROM
        fromDdeo = " from " + TabelaSaPrefiksomSaBazom + " " + sqlalias + ""
        fromDdeo = DodajPMGK(fromDdeo, tabela) + nvrd
        'FROM kraj

        'POLJA

        poljaDdeo = ssel(tabelaTColInfo, True)
        Dim secondRowheader As String = ""

        If imaPodTabelu(ind) Then secondRowheader = "N'' as secondRowHeader,"
        If imaNadTabelu(ind) Then secondRowheader = "N'' as secondRowHeader,"
        poljaDdeo = secondRowheader + poljaDdeo
        'POLJA kraj


        'SELECT CEO
        selectDdeo = poljaDdeo + nvrd + fromDdeo + nvrd + whereDdeo

        'ORDERBY
        Dim orderByDeo As String = ""
        Dim trebaOrderBy As Boolean = True
        If niz_frsCheckBoxPrvihRedova(ind) = True Then
            selectDdeo = "select top " + CInt(niz_frsNumericUpDownPrvihRedovaValue(ind)).ToString + " " + selectDdeo
            trebaOrderBy = True
        Else
            selectDdeo = "select " + selectDdeo
            trebaOrderBy = False
        End If

        If trebaOrderBy = True Then
            For Each kk As System.Data.DataColumn In tabelaTColInfo.dt.PrimaryKey
                orderByDeo = orderByDeo + "" + sqlalias + "." + kk.ColumnName.ToUpper + ","
            Next
            If orderByDeo.Trim <> "" Then
                orderByDeo = " order by " + orderByDeo.TrimEnd(",")
            End If
        End If
        'ORDERBY kraj

        selectDdeo = selectDdeo + orderByDeo


        'SELECT CEO kraj

        dajSelectT = selectDdeo


    End Function
    Private Function getexprSQLKljuc(ByVal r2 As System.Data.DataRow, ByVal tn As String, ByVal cn As String, Optional ByVal prefiks As String = "") As String
        Dim sql As String = ""
        For Each col As System.Data.DataColumn In r2.Table.PrimaryKey
            If Not r2.IsNull(col.ColumnName) Then
                If sql <> "" Then sql = sql + " and "
                sql = sql + Postavi(r2, col, False, prefiks)
            End If
        Next
        Return sql
    End Function

    Public Function Postavi(ByVal r As System.Data.DataRow, ByVal c As System.Data.DataColumn, ByVal b As Boolean, Optional ByVal prefiks As String = "") As String
        Dim sql As String = prefiks + c.ColumnName
        If r.IsNull(c.ColumnName) Then
            If b Then
                sql = sql + "="
            Else
                sql = sql + " is "
            End If
            sql = sql + "null"
        Else
            sql = sql + "="
            Dim val As Object = r.ItemArray(c.Ordinal)
            If c.DataType Is GetType(String) Then
                If IsNumeric(CStr(val).Trim) = True Then
                    sql = sql + "'" + CStr(val).Trim + "'"
                Else
                    sql = sql + "N'" + CStr(val).Trim + "'"
                End If
            ElseIf c.DataType Is GetType(Boolean) Then
                If CBool(val) Then
                    sql = sql + "1"
                Else
                    sql = sql + "0"
                End If
            ElseIf c.DataType Is GetType(Date) Then
                sql = sql + "'" + CDate(val).ToString("yyyy-MM-dd hh:mm:ss") + "'"
            Else
                sql = sql + CStr(val)
            End If
        End If
        Return sql
    End Function

    Dim imaGM, ImaG, ImaM As Boolean
    Dim imaGME, ImaGE, ImaME As Boolean

    Public Function DodajPMGK(ByVal rr As String, ByVal tn As String, Optional ByVal prefiks As String = "d.") As String
        Dim trt As String = ""
        Dim imaPMGK As Boolean = False
        ImaG = ImaM = imaGM = False
        ImaG = ImaM = imaGM = False
        ImaGE = ImaME = imaGME = False
        Dim kljNiz() As String = {}
        For Each r As DatasetIstrazivanja.ISTPOLJARow In mtp
            If r.TABELA.Trim.ToUpper = tn.Trim.ToUpper Then
                If Not r.IsKLJUCNull AndAlso r.KLJUC.Trim.ToUpper = "P" Then
                    If r.POLJE.Trim.ToUpper <> "GOD" AndAlso r.POLJE.Trim.ToUpper <> "MES" _
                        AndAlso r.POLJE.Trim.ToUpper <> "ISTYEAR" AndAlso r.POLJE.Trim.ToUpper <> "ISTMONTH" Then
                        ReDim Preserve kljNiz(kljNiz.GetUpperBound(0) + 1)
                        kljNiz(kljNiz.GetUpperBound(0)) = r.POLJE.Trim.ToUpper
                    ElseIf r.POLJE.Trim.ToUpper = "GOD" Then
                        ImaG = True
                    ElseIf r.POLJE.Trim.ToUpper = "ISTYEAR" Then
                        ImaGE = True
                    ElseIf r.POLJE.Trim.ToUpper = "MES" Then
                        ImaM = True
                    ElseIf r.POLJE.Trim.ToUpper = "ISTMONTH" Then
                        ImaME = True
                    End If
                Else
                    Dim rpTRT As String = ""
                    If r.IsIzrazNull = False Then rpTRT = r.Izraz.Trim
                    If Not (r.IsIzrazNull) AndAlso rpTRT <> "" Then
                        Dim bbb() As String = razkvantaj(rpTRT)
                        For i As Integer = 0 To bbb.GetUpperBound(0)
                            If bbb(i).Length > 0 Then bbb(i) = bbb(i).Trim : bbb(i) = bbb(i) & "          "
                            If (InStr(bbb(i).ToUpper, "PG.") = 1 OrElse InStr(bbb(i).ToUpper, "PY.") = 1 OrElse
                                InStr(bbb(i).ToUpper, "#{PG.") = 1 OrElse InStr(bbb(i).ToUpper, "#{PY.") = 1 OrElse
                                InStr(bbb(i).ToUpper, "PM.") = 1 OrElse InStr(bbb(i).ToUpper, "PMONTH.") = 1 OrElse
                                InStr(bbb(i).ToUpper, "#{PM.") = 1 OrElse InStr(bbb(i).ToUpper, "#{PMONTH.") = 1 OrElse
                                InStr(bbb(i).ToUpper, "PK.") = 1 OrElse InStr(bbb(i).ToUpper, "PQ.") = 1 OrElse
                                InStr(bbb(i).ToUpper, "#{PK.") = 1 OrElse InStr(bbb(i).ToUpper, "#{PQ.") = 1 OrElse
                                InStr(bbb(i).ToUpper, "PP.") = 1 OrElse InStr(bbb(i).ToUpper, "PH.") = 1 OrElse
                                InStr(bbb(i).ToUpper, "#{PP.") = 1 OrElse InStr(bbb(i).ToUpper, "#{PH.") = 1) Then
                                imaPMGK = True
                                Exit For
                            End If
                        Next
                    End If
                End If
            End If
        Next
        imaGM = ImaG And ImaM
        imaGME = ImaGE And ImaME

        If imaPMGK = True Then
            If ImaG And imaGM = False Then trt = dajGM(kljNiz, tn, prefiks, "god")
            If imaGM Then trt = dajGM(kljNiz, tn, prefiks, "god", "mes")
            If ImaGE And imaGME = False Then trt = dajGME(kljNiz, tn, prefiks, "ISTYEAR")
            If imaGME Then trt = dajGME(kljNiz, tn, prefiks, "ISTYEAR", "ISTMONTH")
        End If

        Return rr & trt

    End Function

    Function dajGM(ByVal kljNiz() As String, ByVal tn As String, ByVal prefiks As String,
                   ByVal ggg As String, Optional ByVal mmm As String = "") As String
        Dim trt As String = ""
        Dim sfwP As String
        Dim GG1 As String = CStr(Me.tacv.G - 1)
        Dim MM1 As String
        Dim GGM1 As String
        Dim GGM3 As String
        Dim MM3 As String
        Dim GGM4 As String
        Dim MM4 As String
        If mmm <> "" Then
            sfwP = " LEFT JOIN " & tn & " PM  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PM." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
            Next
            MM1 = CStr(Me.tacv.M - 1).Trim.PadLeft(2, "0"c)
            If Me.tacv.M = 1 Then MM1 = "12"
            GGM1 = CStr(Me.tacv.G)
            If Me.tacv.M = 1 Then GGM1 = GG1
            GGM3 = CStr(Me.tacv.G)
            If Me.tacv.M < 4 Then GGM3 = GG1
            MM3 = CStr(Me.tacv.M - 3).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 4 Then MM3 = CStr(Me.tacv.M + 9).Trim.PadLeft(2, "0"c)
            'prethodno polugođe
            GGM4 = CStr(Me.tacv.G)
            If Me.tacv.M < 6 Then GGM4 = GG1 'prethodna godina
            MM4 = CStr(Me.tacv.M - 6).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 6 Then MM4 = CStr(Me.tacv.M + 6).Trim.PadLeft(2, "0"c)
            sfwP = sfwP + "(PM." + mmm + " = '" & MM1 & "' AND PM." + ggg + "='" & GGM1 & "' )"
            trt = sfwP & ")"

            sfwP = " LEFT JOIN " & tn & " PK  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PK." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
            Next
            sfwP = sfwP + "(PK." + mmm + " = '" & MM3 & "' AND PK." + ggg + "='" & GGM3 & "' )"
            trt = trt + sfwP & ")"
            sfwP = " LEFT JOIN " & tn & " PP  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PP." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
            Next
            sfwP = sfwP + "(PP." + mmm + " = '" & MM4 & "' AND PP." + ggg + "='" & GGM4 & "' )"
            trt = trt + sfwP & ")"
        End If

        sfwP = " LEFT JOIN " & tn & " PG  ON ("
        For i As Integer = 0 To kljNiz.GetUpperBound(0)
            sfwP = sfwP + "PG." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
        Next
        If mmm <> "" Then
            sfwP = sfwP + "(PG." + mmm + "= '" & CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) & "' AND PG." + ggg + "='" & GG1 & "' )"
        Else
            sfwP = sfwP + "(PG." + ggg + "='" & GG1 & "' )"
        End If

        trt = trt + sfwP & ")"

        dajGM = trt
    End Function

    Function dajGME(ByVal kljNiz() As String, ByVal tn As String, ByVal prefiks As String,
                   ByVal ggg As String, Optional ByVal mmm As String = "") As String
        Dim trt As String = ""
        Dim sfwP As String
        Dim GG1 As String = CStr(Me.tacv.G - 1)
        Dim MM1 As String
        Dim GGM1 As String
        Dim GGM3 As String
        Dim MM3 As String
        Dim GGM4 As String
        Dim MM4 As String
        If mmm <> "" Then
            sfwP = " LEFT JOIN " & tn & " PMONTH  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PMONTH." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
            Next
            MM1 = CStr(Me.tacv.M - 1).Trim.PadLeft(2, "0"c)
            If Me.tacv.M = 1 Then MM1 = "12"
            GGM1 = CStr(Me.tacv.G)
            If Me.tacv.M = 1 Then GGM1 = GG1
            GGM3 = CStr(Me.tacv.G)
            If Me.tacv.M < 4 Then GGM3 = GG1
            MM3 = CStr(Me.tacv.M - 3).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 4 Then MM3 = CStr(Me.tacv.M + 9).Trim.PadLeft(2, "0"c)
            'prethodno polugođe
            GGM4 = CStr(Me.tacv.G)
            If Me.tacv.M < 6 Then GGM4 = GG1 'prethodna godina
            MM4 = CStr(Me.tacv.M - 6).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 6 Then MM4 = CStr(Me.tacv.M + 6).Trim.PadLeft(2, "0"c)
            sfwP = sfwP + "(PMONTH." + mmm + " = '" & MM1 & "' AND PMONTH." + ggg + "='" & GGM1 & "' )"
            trt = sfwP & ")"

            sfwP = " LEFT JOIN " & tn & " PQ  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PQ." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
            Next
            sfwP = sfwP + "(PQ." + mmm + " = '" & MM3 & "' AND PQ." + ggg + "='" & GGM3 & "' )"
            trt = trt + sfwP & ")"
            sfwP = " LEFT JOIN " & tn & " PH  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PH." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
            Next
            sfwP = sfwP + "(PH." + mmm + " = '" & MM4 & "' AND PH." + ggg + "='" & GGM4 & "' )"
            trt = trt + sfwP & ")"
        End If

        sfwP = " LEFT JOIN " & tn & " PY  ON ("
        For i As Integer = 0 To kljNiz.GetUpperBound(0)
            sfwP = sfwP + "PY." & kljNiz(i).Trim.ToUpper & " = " & prefiks & "" & kljNiz(i) & " AND "
        Next
        If mmm <> "" Then
            sfwP = sfwP + "(PY." + mmm + "= '" & CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) & "' AND PY." + ggg + "='" & GG1 & "' )"
        Else
            sfwP = sfwP + "(PY." + ggg + "='" & GG1 & "' )"
        End If

        trt = trt + sfwP & ")"

        dajGME = trt
    End Function
    Private Sub FormAzuriraj_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call PreVentFlicker()

        For Each dgv As DataGridView In niz_dgv
            BufferMethod.DoubleBuffered(dgv, True)
        Next

        If Me.panelmenucollapse = True Then
            Call CollapseMenu()
        End If

        Call SettingObjForTheme(GetTheme())
        Call nonvisiblePanelTOP()
        prosaoLoad = 1

        If dodakle = "LK" Then
            Call RowSelection()
            dodakle = "izLK"
        End If

        ButtonIzborSlogova.Focus()
    End Sub


    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formAzuriraj")
        TabPageGreskeZaSlog.Text = getControlText2(dt, "TabPageGreskeZaSlog", Me.jezik)
        TabPageGreskeZaPrikazaneSlogove.Text = getControlText2(dt, "TabPageGreskeZaPrikazaneSlogove", Me.jezik)
        TabPageGreskeZaCeluTabelu.Text = getControlText2(dt, "TabPageGreskeZaCeluTabelu", Me.jezik)
        chbA.Text = getControlText2(dt, "chbA", Me.jezik)
        Dim bspace As String = "      "
        ButtonAzurirajSlogUDGV.Text = bspace + getControlText2(dt, "ButtonAAzuriraj", Me.jezik)
        ButtonAzurirajSlogUDGV.Tag = ButtonAzurirajSlogUDGV.Text
        ButtonIzborKolona.Text = bspace + getControlText2(dt, "ButtonAIzborKolona", Me.jezik)
        ButtonIzborKolona.Tag = ButtonIzborKolona.Text
        ButtonIzborSlogova.Text = bspace + getControlText2(dt, "ButtonAIzborSlogova", Me.jezik)
        ButtonIzborSlogova.Tag = ButtonIzborSlogova.Text
        ButtonBrisi.Text = bspace + getControlText2(dt, "ButtonABrisi", Me.jezik)
        ButtonBrisi.Tag = ButtonBrisi.Text
        ButtonNoviSlog.Text = bspace + getControlText2(dt, "ButtonANoviSlog", Me.jezik)
        ButtonNoviSlog.Tag = ButtonNoviSlog.Text
        ButtonUpitnik.Text = bspace + getControlText2(dt, "ButtonAUpitnik", Me.jezik)
        ButtonUpitnik.Tag = ButtonUpitnik.Text

        ButtonLK.Text = bspace + getControlText2(dt, "ButtonALK", Me.jezik)
        ButtonLK.Tag = ButtonLK.Text
        btnNP.Text = bspace + getControlText2(dt, "ButtonNPretraga", Me.jezik)
        btnNP.Tag = btnNP.Text

        Btn_Excel.Text = bspace + "Excel"
        Btn_Excel.Tag = Btn_Excel.Text

        btn_JSON.Text = bspace + "JSON"
        btn_JSON.Tag = btn_JSON.Text

        Btn_XML.Text = bspace + "XML"
        Btn_XML.Tag = Btn_XML.Text

        btn_SPSS.Text = bspace + "SPSS+txt"
        btn_SPSS.Tag = btn_SPSS.Text


    End Sub


    Public Function tabelaSQL(ByVal crb As DatasetIstrazivanja.ISTBAZERow, ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow, ByVal tableNameArg As String) As String
        If rowBaze Is Nothing Then rowBaze = crb
        Dim tableName As String = tableNameArg.Trim
        tableName = prfxt(tableName)
        Dim sODBC As String = rowBaze.IzrazODBC.Trim.ToLower.Replace("provider=sqloledb.1;", "")
        Dim db As String = conParametar(sODBC, "database")
        If db = "" Then
            db = conParametar(sODBC, "initial catalog")
            If db = "" Then db = rowBaze.Baza.Trim
        End If
        Dim prefix As String = zagr(db)
        tableName = prefix.Trim + "." + tableName
        If Not crb Is rowBaze Then
            Dim provider As String = conParametar(sODBC, "provider")
            If provider = "" Then provider = "SQLNCLI11" '
            tableName = "OPENROWSET('" + provider + "','" + sODBC + "'," + tableName + ")"
        End If
        Return tableName
    End Function

    Private Function conParametar(ByVal connectionString As String, ByVal parameter As String) As String
        Dim i As Integer = connectionString.ToLower.IndexOf(parameter)
        Dim iStart As Integer = i
        If i >= 0 Then
            i = connectionString.IndexOf("=", i + 1)
            If i >= 0 Then
                Dim j As Integer = connectionString.IndexOf(";", i + 1)
                If j >= 0 Then
                    Return connectionString.Substring(i + 1, j - i - 1).Trim
                Else
                    Return connectionString.Substring(i + 1).Trim
                End If
            End If
        End If
        Return ""
    End Function

    Public Function zagr(ByVal name As String) As String
        name = name.Trim
        If name.Chars(0) <> "["c Then Return "[" + name + "]"

        Return name
    End Function
    Private Sub Kolona2(Optional ByVal BasIzlaz As Boolean = False)
        Dim pm As Integer = 0
        Dim ti As TcolInfo
        Dim zklj As Integer = 0
        For Each ti In Me.niz_TColInfo
            If Not (ti.dt.Columns("LK")) Is Nothing Then
                For r As Integer = 0 To ti.dt.Rows.Count - 1
                    If ti.dt.Rows(r).RowState = System.Data.DataRowState.Modified Then
                        If (Not (ti.dt.Rows(r).Item("lk") Is System.DBNull.Value)) AndAlso CBool(ti.dt.Rows(r).Item("LK")) Then
                            ti.dt.Rows(r).RejectChanges()
                            zklj = zklj + 1
                        End If
                    End If
                Next
            End If
            Dim t As System.Data.DataTable = ti.dt.GetChanges(System.Data.DataRowState.Modified)
            If Not t Is Nothing Then
                pm = pm + t.Rows.Count
            End If
        Next

        If zklj > 0 Then
            If Not BasIzlaz Then
                ''msg 204
                Dim msgtxt204 As String = getMessageText(dtMessages, "204", Me.jezik)
                ''msg 205
                Dim msgtxt205 As String = getMessageText(dtMessages, "205", Me.jezik)
                ISTMessageBox.Show(msgtxt204 & CStr(zklj) & msgtxt205, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        If pm = 0 Then
            If Not BasIzlaz Then
                ''msg 206
                Dim msgtxt206 As String = getMessageText(dtMessages, "206", Me.jezik)
                ISTMessageBox.Show(msgtxt206, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return
        End If

        Dim dr As System.Windows.Forms.DialogResult
        ''msg 207
        Dim msgtxt207 As String = getMessageText(dtMessages, "207", Me.jezik)
        ''msg 208
        Dim msgtxt208 As String = getMessageText(dtMessages, "208", Me.jezik)
        ''msg 209
        Dim msgtxt209 As String = getMessageText(dtMessages, "209", Me.jezik)
        ''msg 210
        Dim msgtxt210 As String = getMessageText(dtMessages, "210", Me.jezik)
        dr = ISTMessageBox.Show(msgtxt207 + pm.ToString + "." + nvrd + msgtxt208 + nvrd + msgtxt209, msgtxt210, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If dr <> System.Windows.Forms.DialogResult.Yes Then
            If dr = System.Windows.Forms.DialogResult.Cancel Then
                'Me.dgvs_dataSet.RejectChanges()
            End If
            Return
        End If
        Dim conn As New System.Data.SqlClient.SqlConnection(Me.DBConnectionString)
        Try
            conn.Open()
        Catch ex As System.Exception
            conn.Dispose()
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Me.ProgressBar1.Visible = True
        Me.ProgressBar1.Value = Me.ProgressBar1.Minimum
        Me.ProgressBar1.Maximum = pm
        Me.ProgressBar1.Step = Me.ProgressBar1.Maximum \ 20
        If Me.ProgressBar1.Step = 0 Then Me.ProgressBar1.Step = 1

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim ra As Long

        Try
            Dim lk As New LogickaKontrola(Me.DBConnectionString, Me.m_rowIST.ISTBAZERow, Me.mtt, Me.mtp, Me.mta, Me.mtlk, Nothing, Nothing, Me.tacv, Me.jezik)
            For i As Integer = 0 To Me.niz_TColInfo.GetUpperBound(0)
                ti = niz_TColInfo(i)
                Dim ind As Integer = Array.IndexOf(niz_TColInfo, ti)
                Dim tabela As String = sveTabele(ind)
                Dim t As System.Data.DataTable
                t = ti.dt.GetChanges(System.Data.DataRowState.Modified)
                If Not t Is Nothing Then
                    Try
                        'For Each r As System.Data.DataRow In t.Rows
                        For r As Integer = 0 To t.Rows.Count - 1
                            Dim r2 As System.Data.DataRow = t.Rows(r)
                            Dim b As Boolean
                            Me.Kolona33(r2, ti, lk, ra, b)
                            If b Then
                                'nije bilo azuriranje, izađi Exit sub
                                Return
                            Else
                                'bilo, nastavi
                            End If
                            'Dim rindex As Integer = niz_dgv(ind).CurrentRow.Index
                            Dim dtn As DataTable = Greska2(Me.getexprSQL(r2, tabela, "", "d."), ind)
                            Dim rv22 As DataRow = dtn.Rows(0)
                            r2 = rv22
                            r2.AcceptChanges()
                            For Each column As DataColumn In DirectCast(niz_dgv(ind).DataSource, DataTable).Columns
                                If column.ReadOnly = False AndAlso column.ColumnName <> "secondRowHeader" AndAlso r2.Table.Columns.Contains(column.ColumnName) Then
                                    DirectCast(niz_dgv(ind).DataSource, DataTable).Rows(r)(column.ColumnName) = r2(column.ColumnName)
                                End If
                            Next

                            ti.dt.AcceptChanges()
                            DirectCast(niz_dgv(ind).DataSource, DataTable).AcceptChanges()
                            niz_dgv(ind).Refresh()

                            ti.daj_dt_greskeZaSlog(rv22)
                            ti.dg_greskeZaSlog.DataSource = ti.dt_greskeZaSlog


                        Next

                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        t.Dispose()
                    End Try
                End If
            Next
        Finally
            conn.Dispose()
            'dg_CurrentCellChanged(Nothing, Nothing)
            ''msg 211
            Dim msgtxt211 As String = getMessageText(dtMessages, "211", Me.jezik)
            ISTMessageBox.Show(msgtxt211 + ra.ToString, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.ProgressBar1.Visible = False
            Me.Cursor = System.Windows.Forms.Cursors.Default

            'pitaj za LK
            Dim drLK As DialogResult = ISTMessageBox.Show("Da li želite da uradite LK posle ažuriranja?", "Batch logical control", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Select Case drLK
                Case DialogResult.Yes
                    Me.ButtonLK.Focus()
                    ActivateButton(ButtonLK, ActivateButtonColor)
                    If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("formAzuriraj" + " DialogResult for LK", "yes", "")
                Case DialogResult.No
                    If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("formAzuriraj" + " DialogResult for LK", "no", "")
            End Select
        End Try
    End Sub

    Sub UradiLKZaSlog()

    End Sub

    Dim pomdt() As System.Data.DataTable
    Dim pomdtName() As String
    Dim pomdtPrefix() As String
    Dim indpomdt As Integer = -1

    Private Sub Kolona33(ByVal r As System.Data.DataRow, ByVal ti As TcolInfo, ByVal lk As LogickaKontrola, ByRef ra As Long, ByRef b As Boolean)

        b = False
        Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
        Me.ProgressBar1.Refresh()

        Dim str As String = ti.exprset(r, Me.m_rowIST.ISTBAZERow.FizBaza.Trim.ToUpper)
        If str <> "" Then

            'Dim tn As String = prfxt(ti.dt.Prefix + "." + ti.dt.TableName)
            Dim tabela As String = ti.dt.TableName.Trim.ToUpper
            If ti.dt.Prefix.Trim.ToUpper = "DBO" Then
            Else
                tabela = ti.dt.Prefix.Trim.ToUpper + "." + ti.dt.TableName.Trim.ToUpper
            End If

            Call parametriT1(tabela)

            Dim pratiEditInputDepo As Boolean = False

            If lokalno = False Then pratiEditInputDepo = True
            ''
            Dim str2 As String = Me.getexprSQL(r, tabela, "")
            Dim kljuc As String = Me.getexprSQLKljuc(r, tabela, "")

            Dim DTTkoDatum As New System.Data.DataTable
            DTTkoDatum = koDatum()

            Dim sql As String = "select * from " & tabela & " where 2=3 "

            Dim pomdt2 As New System.Data.DataTable
            pomdt2 = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)


            If Not (pomdt2.Columns("KO_UPDATE")) Is Nothing Then
                str = str + ",ko_UPDATE='" & DTTkoDatum.Rows(0).Item("ko").ToString.Trim & "'"
            End If
            If Not (pomdt2.Columns("DATUM_UPDATE")) Is Nothing Then
                str = str + ",datum_UPDATE='" & DTTkoDatum.Rows(0).Item("datum").ToString.Trim & "'"
            End If
            If Not (pomdt2.Columns("USER_UPDATE")) Is Nothing Then
                str = str + ",user_UPDATE='" & DTTkoDatum.Rows(0).Item("ko").ToString.Trim & "'"
            End If
            If Not (pomdt2.Columns("DATE_UPDATE")) Is Nothing Then
                str = str + ",date_UPDATE='" & DTTkoDatum.Rows(0).Item("datum").ToString.Trim & "'"
            End If
            If Not (pomdt2.Columns("CAPIEXPORTED")) Is Nothing Then
                str = str + ",CAPIEXPORTED=0"
            End If

            sql = "set nocount off;update " + tabela + " set " + str + " where " + str2

            Dim uspelo As Boolean = True

            Try

                Dim pom As Integer = izvrsiSQLVratiBrojSlogova(sql, Me.DBConnectionString)
                ra = ra + pom

            Catch ex As System.Exception
                uspelo = False
                Me.ProgressBar1.Visible = False
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'bila LK
                'If iskljucenaLKCela = False AndAlso iskljucenaLKsemZaAdresare = False Then
                '    'za ovaj slucaj obavezno LK samo iz batcha
                '    lk.LK(str2, ti.dt.TableName)
                'End If
                'Me.Greska2(str2, ti)
                b = True
                Return
            End Try

            ''NOVO*****
            ''UPISUJEM NIZPROMENA U DEPO
            If pratiEditInputDepo = True AndAlso uspelo = True Then
                'Dim sifist As String = Me.m_rowIST.Item(0).ToString.Trim
                Dim sqlLogPromena As String = ""
                Dim polja() As String = Microsoft.VisualBasic.Split(str, ",")

                For i As Integer = 0 To polja.GetUpperBound(0)
                    Dim pp() As String = Microsoft.VisualBasic.Split(polja(i), "=")
                    If pp(1).Trim.ToUpper.IndexOf("N'") = 0 Then pp(1) = pp(1).Substring(2).TrimEnd("'")
                    Dim polje As String = pp(0).ToString.Trim.ToUpper
                    If polje <> "DATUM_UPDATE" AndAlso polje <> "KO_UPDATE" AndAlso polje <> "DATE_UPDATE" AndAlso polje <> "USER_UPDATE" AndAlso polje <> "CAPIEXPORTED" Then
                        Dim originalVred As String = r(polje, System.Data.DataRowVersion.Original).ToString()
                        Dim currentVred As String = pp(1).ToString.Trim.ToUpper
                        Dim promena As String = ""
                        'INPUT
                        If originalVred = "" And currentVred <> "" Then promena = "IST_INPUT"
                        'EDIT
                        If originalVred <> "" And currentVred <> originalVred Then promena = "IST_EDIT"
                        If promena <> "" Then
                            sqlLogPromena = sqlLogPromena + "insert into dbo.[ISTPromenaVarijabli] (SifIst,god,mes,TABELA,kljuc,varijabla,vrstaPromene,ko_insert,datum_insert,valuebefore,valueafter) " _
                                                & " values( " _
                                                & "'" & sifist & "','" & CStr(Me.tacv.G).ToString.Trim & "','" & CStr(Me.tacv.M).ToString.Trim & "'," _
                                                & "'" & ti.dt.TableName.Trim.ToUpper & "','" & kljuc.Replace("'", "").Replace("  ", " ").Trim.ToUpper & "'," _
                                                & "'" & polje & "','" & promena & "'," _
                                                & "suser_sname(),(CONVERT([varchar],getdate(),(120))),N'" + originalVred + "',N'" + currentVred + "')" + vbCrLf
                        End If
                    End If
                Next

                Dim ok1 As String = izvrsiSQL(sqlLogPromena, konDepo)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER15", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            ''UPISUJEM NIZPROMENA U DEPO
            ''NOVO*****

            'MORA DA SE URADI LK NA NIVOU SLOGA
            If iskljucenaLKCela = False AndAlso iskljucenaLKsemZaAdresare = False Then
                'za ovaj slucaj obavezno LK samo iz batcha
                lk.LK(str2, ti.dt.TableName)
            End If

        End If
    End Sub
    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, Optional ByVal izvestaj As String = "", Optional ByVal upit As String = "")

        Dim god As String = Me.tacv.G.ToString
        Dim mes As String = String.Format("{0:d2}", Me.tacv.M)
        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
        & "(SifIst,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
        & " values( " _
        & "N'" & sifist & "','" & god & "','" & mes & "'," _
        & "N'" & proces.Replace("'", "") & "',N'" + izvestaj.Replace("'", "") & "',N'" + upit.Replace("'", "") & "'," _
        & "N'" & GetUserName.ToString.Trim & "'," _
        & "" & "(select top 1 GETDATE())" & ");" + nvrd

        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)

        Dim ok1 As String = izvrsiSQL(strSQL, konDepo)
        If ok1 <> "ok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER90", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Public Function koDatum() As System.Data.DataTable
        Dim DTTkoDatum As New System.Data.DataTable
        Dim sql As String = "select (suser_sname()) as ko,(CONVERT([varchar],getdate(),(120))) as datum"
        DTTkoDatum = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        Return DTTkoDatum
    End Function
    Private Function Greska2(ByVal str3 As String, ByVal ind As Integer, Optional ByVal prefiks As String = "") As DataTable
        Dim ti As TcolInfo = niz_TColInfo(ind)
        Dim tabelaSAPFX As String = sveTabeleSAPFX(ind)
        Dim pp() As String = tabelaSAPFX.Split(".")
        Dim tabbb As String = pp(1)
        Dim prefixx As String = pp(0)
        Dim secondRowheader As String = ""
        If imaPodTabelu(ind) Then secondRowheader = "N'' as secondRowHeader,"
        If imaNadTabelu(ind) Then secondRowheader = "N'' as secondRowHeader,"

        Dim sql As String = "select " + secondRowheader + ssel(ti, True)
        sql = sql + nvrd + " from " + tabelaSQL(Me.m_rowIST.ISTBAZERow, Nothing, tabelaSAPFX) + " d "

        sql = DodajPMGK(sql, tabbb)
        sql = sql + " where " + str3

        Dim dtN As New DataTable
        dtN = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

        Dim npk() As DataColumn = ti.dt.PrimaryKey
        Call addPKtoDT(npk, dtN)

        dtN.TableName = tabbb
        dtN.Prefix = prefixx

        Return dtN

    End Function
    Sub addPKtoDT(ByVal npk() As DataColumn, ByVal dtN As DataTable)

        Dim newPrimaryKeys(npk.Length - 1) As DataColumn
        For i As Integer = 0 To npk.GetUpperBound(0)
            Dim pk As DataColumn = dtN.Columns.Item(npk(i).ColumnName)
            If Not pk Is Nothing Then
                pk.Unique = True
                pk.AllowDBNull = False
                'dtN.PrimaryKey = New DataColumn() {pk}
                newPrimaryKeys(i) = pk
            End If
        Next
        dtN.PrimaryKey = newPrimaryKeys
    End Sub

    Dim maksimalan As Boolean = Nothing
    Dim iskljucenaLKsemZaAdresare As Boolean
    Dim iskljucenaLKCela As Boolean
    Dim zakljucanOdmahSve As Boolean
    Sub parametriT1(ByVal tabela As String)
        Dim nizIndikatorT1() As String = {}
        Dim IndikatorT1 As String = ""
        For Each tt As DatasetIstrazivanja.ISTTABELERow In mtt.Rows
            If tt.Tabela.Trim.ToUpper = tabela Then
                If Not (tt.Item("T1") Is System.DBNull.Value) Then
                    IndikatorT1 = IIf(tt.Item("T1") Is System.DBNull.Value, "", tt.Item("T1").ToString.Trim)
                    If IndikatorT1.Trim.ToUpper.Length > 0 Then nizIndikatorT1 = IndikatorT1.Split(";")
                    For k As Integer = 0 To nizIndikatorT1.GetUpperBound(0)
                        nizIndikatorT1(k) = nizIndikatorT1(k).Trim.ToUpper
                        If nizIndikatorT1(k) = "LOCKED" Then zakljucanOdmahSve = True
                        If maksimalan <> True Then
                            If nizIndikatorT1(k) = "MAX" Then maksimalan = True
                            If nizIndikatorT1(k) = "XA" Then iskljucenaLKsemZaAdresare = True
                            If nizIndikatorT1(k) = "AX" Then iskljucenaLKsemZaAdresare = True
                            If nizIndikatorT1(k) = "X" Then iskljucenaLKCela = True
                            If nizIndikatorT1(k) = "A" Then iskljucenaLKsemZaAdresare = True
                        End If
                    Next
                End If
                Exit For
            End If
        Next
    End Sub

    Private Sub Unos2(ByVal postojislog As Boolean, ByVal zakljucanUnos As Integer)

        Dim zakljucan As Boolean = False
        If zakljucanUnos = 1 Then zakljucan = True
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim tabela As String = sveTabele(pomind)
        Dim glavnatabela As String = GtabelaJe(sveTabele(pomind).Trim.ToUpper)
        pomind = Array.IndexOf(sveTabele, glavnatabela.Trim.ToUpper)

        Dim Kljucevi() As String = DajKljuceve(tabela)
        Dim KljuceviGlavnaTabela() As String = DajKljuceve(glavnatabela)

        Dim dgv As DataGridView = niz_dgv(pomind)
        Dim ti As TcolInfo = niz_TColInfo(pomind)

        If ti Is Nothing Then
            Dim msgtxt212 As String = getMessageText(dtMessages, "212", Me.jezik)
            ISTMessageBox.Show(msgtxt212, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Return
        End If

        Call parametriT1(glavnatabela)

        Dim ImaVODVDO As Boolean = False
        For Each p As DatasetIstrazivanja.ISTPOLJARow In Me.mtp.Rows
            If p.TABELA.Trim.ToUpper = glavnatabela AndAlso (p.POLJE.Trim.ToUpper = "VOD") Then
                ImaVODVDO = True
                Exit For
            End If
        Next

        Dim rv2 As DataRow = Nothing
        Dim rv2Index As Integer = -1
        If postojislog AndAlso (Me.m_rowIST.IsProgUnosNull OrElse Me.m_rowIST.ProgUnos.Trim = "") Then
            Dim dalje As Boolean = True
            While dalje
                If dgv.CurrentRow IsNot Nothing Then
                    Dim currentRowView As DataRowView = TryCast(dgv.CurrentRow.DataBoundItem, DataRowView)
                    If currentRowView IsNot Nothing Then
                        rv2 = currentRowView.Row
                        rv2Index = dgv.CurrentRow.Index
                    Else
                        ''msg 213
                        Dim msgtxt213 As String = getMessageText(dtMessages, "213", Me.jezik)
                        ISTMessageBox.Show(msgtxt213, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Return
                    End If
                End If
                Dim Vklj(,) As String = Nothing
                ReDim Vklj(KljuceviGlavnaTabela.GetUpperBound(0), 1)

                For i As Integer = 0 To KljuceviGlavnaTabela.GetUpperBound(0)
                    For Each col As DataColumn In rv2.Table.Columns
                        If KljuceviGlavnaTabela(i).Trim.ToUpper = col.ColumnName.Trim.ToUpper AndAlso Not rv2.IsNull(col.ColumnName) Then
                            Vklj(i, 0) = col.ColumnName.ToString.Trim.ToUpper
                            Vklj(i, 1) = rv2.Item(col.ColumnName).ToString.Trim.ToUpper
                            Exit For
                        End If
                    Next
                Next

                Dim frm As New IstrazivanjaUnos.FormIstUnos(dsIST, mdtLabel, mdtAWL, mdtQE, mdtMessage, DBConnectionString, Me.tacv, glavnatabela,
                                    True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper, Me.DSBrisanjeServer.Trim.ToUpper,
                                    Me.DSBrisanjeBaza.Trim.ToUpper, zakljucan, zakljucanOdmahSve, Vklj, , postojislog, , , , , LX, LA, , , maksimalan,,,,, CAPIServer, CAPIBaza)
                Try
                    frm.ShowDialog()
                Catch ex As System.Exception
                    ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    frm.Dispose()
                End Try

                If frm.ELzaPamceno Then
                    If Not ti Is Nothing Then
                        If Not rv2 Is Nothing Then
                            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                            Try
                                'vec je zapamtio slog, pa je samim tim i upisao u tabelu greske i indgr
                                Dim dtn As DataTable = Greska2(Me.getexprSQL(rv2, glavnatabela, "", "d."), pomind)
                                Dim rv22 As DataRow = dtn.Rows(0)
                                rv2 = rv22
                                rv2.AcceptChanges()
                                For Each column As DataColumn In DirectCast(dgv.DataSource, DataTable).Columns
                                    If column.ReadOnly = False AndAlso column.ColumnName <> "secondRowHeader" AndAlso rv2.Table.Columns.Contains(column.ColumnName) Then
                                        DirectCast(dgv.DataSource, DataTable).Rows(rv2Index)(column.ColumnName) = rv2(column.ColumnName)
                                    End If
                                Next

                                ti.dt.AcceptChanges()
                                DirectCast(dgv.DataSource, DataTable).AcceptChanges()
                                dgv.Refresh()

                                ti.daj_dt_greskeZaSlog(rv2)
                                ti.dg_greskeZaSlog.DataSource = ti.dt_greskeZaSlog

                                'ti.daj_dt_greskezaPrikazaneSlogove(dgv)
                                'ti.dg_greskeZaPrikazaneSlogove.DataSource = ti.dt_greskeZaPrikazaneSlogove
                                'ti.daj_dt_greskeZaTabelu()

                            Catch ex As System.Exception
                                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Finally
                                Me.Cursor = System.Windows.Forms.Cursors.Default
                            End Try
                        End If
                    End If
                End If 'ELzaPamceno

                dalje = frm.ELzaPamceno
                dalje = Not frm.neididalje

                If dalje AndAlso Not dgv.CurrentRow Is Nothing Then
                    Dim tRed As Integer = dgv.CurrentRow.Index
                    Dim slRed As Integer = tRed + 1
                    If Not frm.ELRefresh AndAlso slRed < dgv.Rows.Count Then
                        dgv.ClearSelection()
                        dgv.Rows(slRed).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = slRed
                        dgv.CurrentCell = dgv.Rows(slRed).Cells(0) 'MORA INACE NE VRTI PO REDOVIMA
                    End If
                    LX = frm.azurLX
                    LA = frm.azurLA
                    If (Not frm.ELRefresh) AndAlso slRed = dgv.Rows.Count Then
                        dalje = False
                        dgv.ClearSelection()
                        dgv.Rows(0).Selected = True
                        dgv.FirstDisplayedScrollingRowIndex = 0
                        dgv.CurrentCell = dgv.Rows(0).Cells(0)   'MORA INACE NE VRTI PO REDOVIMA

                        Return
                    End If
                Else

                    Return
                End If
                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then   'može i testcapi
                    dalje = False

                    Exit Sub
                End If
            End While
        End If
        If postojislog = False AndAlso (Me.m_rowIST.IsProgUnosNull OrElse Me.m_rowIST.ProgUnos.Trim = "") Then
            Dim Vklj(,) As String = Nothing

            Dim frm As New IstrazivanjaUnos.FormIstUnos(dsIST, mdtLabel, mdtAWL, mdtQE, mdtMessage, DBConnectionString, Me.tacv, glavnatabela,
                True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper, Me.DSBrisanjeServer.Trim.ToUpper,
                Me.DSBrisanjeBaza.Trim.ToUpper, zakljucan, zakljucanOdmahSve, Vklj, , postojislog, , , , , LX, LA, , , maksimalan,,,,, CAPIServer, CAPIBaza)

            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
            End Try

        End If



        If Me.m_rowIST.ProgUnos.ToLower.IndexOf(".exe") >= 0 Then
            Dim a2 As String = Me.DBConnectionString
            If postojislog = False Then
                a2 = a2 + Me.tacv.vtpos
            Else
                Dim dv_co As New DataView(dgv.DataSource)
                Dim v2 As System.Data.DataView = New DataView(dgv.DataSource)
                If Not rv2 Is Nothing Then
                    Dim p2 As String = ""
                    For i As Integer = 0 To KljuceviGlavnaTabela.GetUpperBound(0)
                        For Each col As DataColumn In rv2.Table.Columns
                            If KljuceviGlavnaTabela(i).Trim.ToUpper = col.ColumnName.Trim.ToUpper AndAlso Not rv2.IsNull(col.ColumnName) Then
                                If p2 <> "" Then
                                    p2 = p2 + ","
                                End If
                                p2 = p2 + CStr(rv2.ItemArray(col.Ordinal)).Trim
                                Exit For
                            End If
                        Next
                    Next

                    a2 = a2 + "#" + p2 + "##"
                    If Not rv2 Is Nothing Then
                        Dim w As String = Me.getexprSQL(rv2, glavnatabela, "")
                        If w <> "" Then
                            w = " and " + w
                        End If
                        a2 = a2 + w
                    End If
                Else
                    ''msg 213
                    Dim msgtxt213 As String = getMessageText(dtMessages, "213", Me.jezik)
                    ISTMessageBox.Show(msgtxt213, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
            externiUnos(Me.mfold + "\" + Me.m_rowIST.ProgUnos.Trim, False, Me.mfold, a2)
        End If
    End Sub

    Private Function ProveraUnosLOCK(ByVal pomind As Integer) As Integer  ' vraca 1 ako je zakljucan unos
        Dim tabela As String = sveTabeleSAPFX(pomind).Trim.ToUpper
        Dim ti As TcolInfo = niz_TColInfo(pomind)
        Dim ImaVODVDO As Boolean = False
        ProveraUnosLOCK = 0
        If Not ti Is Nothing Then
            ImaVODVDO = False
            For Each p As DatasetIstrazivanja.ISTPOLJARow In Me.mtp.Rows
                If p.TABELA.Trim.ToUpper = ti.dt.TableName.Trim.ToUpper Then
                    If (p.POLJE.Trim.ToUpper = "VOD") Then
                        ImaVODVDO = True
                        Exit For
                    End If
                End If
            Next

            Dim sql As String = " select * from " & tabela & " where 2=3  "
            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Me.jezik)
            Dim ImaG As Boolean = False
            Dim ImaM As Boolean = False
            Dim ImaGE As Boolean = False
            Dim ImaME As Boolean = False
            If Not dt.Columns("GOD") Is Nothing Then ImaG = True
            If Not dt.Columns("MES") Is Nothing Then ImaM = True
            If Not dt.Columns("ISTYEAR") Is Nothing Then ImaGE = True
            If Not dt.Columns("ISTMONTH") Is Nothing Then ImaME = True

            If Not dt.Columns("LK") Is Nothing Then 'ima kolonu LK
                Dim GG As String = CStr(Me.tacv.G)
                Dim MM As String = CStr(Me.tacv.M).Trim.PadLeft(2, "0"c)
                sql = " select min(cast(isnull(LK,0) as integer)) as LK from " & tabela & " where 2=2  "
                If ImaG Then sql = sql + " and god='" + GG + "'"
                If ImaM Then sql = sql + " and mes='" + MM + "'"
                If ImaGE Then sql = sql + " and ISTYEAR='" + GG + "'"
                If ImaME Then sql = sql + " and ISTMONTH='" + MM + "'"

                If ImaVODVDO Then
                    Dim ldm As String = Me.DADD("01.01." + Me.tacv.G.ToString, Me.tacv.M, -1)
                    Dim ssql As String = "((" + ldm + ") between "
                    If tabela <> "" Then ssql = ssql + tabela + "."
                    ssql = ssql + "VOD" + " and "
                    If tabela <> "" Then ssql = ssql + tabela + "."
                    ssql = ssql + "VDO" + ")"
                    sql = sql + " and " & ssql
                End If

                Dim dt1 As New System.Data.DataTable
                dt1 = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Me.jezik)
                If (Not (dt1.Rows(0).Item("LK").GetType Is GetType(System.DBNull))) AndAlso dt1.Rows(0).Item("LK").ToString.Trim = "1" Then
                    'zakljucan materijal u celoj vrtacki
                    ProveraUnosLOCK = 1
                End If
            End If
        End If

        Return ProveraUnosLOCK
    End Function

    Private Function ProveraLOCK(ByVal tn As String, ByVal Vklj(,) As String, ByVal ImaVODVDO As Boolean) As Integer  ' vraca 1 ako je zakljucan unos

        ProveraLOCK = 0
        Dim nijenov As Integer = 0

        Dim sql As String = " select * from " & Me.prfxt(tn) & " where 2=3  "
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Me.jezik)
        If Not dt.Columns("LK") Is Nothing Then 'ima kolonu LK
            Dim sqlS As String = " select cast(isnull(LK,0) as integer) as LK from " & Me.prfxt(tn) & " where 2=2 "

            For k As Integer = 0 To Vklj.GetUpperBound(0)
                sqlS = sqlS + " and " & Vklj(k, 0) & " =N'" & Vklj(k, 1) & "'"
            Next

            If ImaVODVDO Then
                Dim ldm As String = Me.DADD("01.01." + Me.tacv.G.ToString, Me.tacv.M, -1)
                Dim ssql As String = "((" + ldm + ") between "
                If Me.prfxt(tn) <> "" Then ssql = ssql + Me.prfxt(tn) + "."
                ssql = ssql + "VOD" + " and "
                If Me.prfxt(tn) <> "" Then ssql = ssql + Me.prfxt(tn) + "."
                ssql = ssql + "VDO" + ")"
                sqlS = sqlS + " and " & ssql
            End If

            Dim dtS As DataTable
            dtS = izvrsiSQLvratiDT(sqlS, Me.DBConnectionString, Me.jezik)

            If Not (dtS.Rows(0).Item("LK") Is Nothing) AndAlso (Not (dtS.Rows(0).Item("LK").GetType Is GetType(System.DBNull))) AndAlso dtS.Rows(0).Item("LK") = 1 Then
                ProveraLOCK = 1
            End If
        End If

        Return ProveraLOCK
    End Function


    Public Sub externiUnos(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = fn
        p.UseShellExecute = b
        If p.UseShellExecute Then
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Else
            p.WorkingDirectory = wd
            p.Arguments = a
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Try
            System.Diagnostics.Process.Start(p)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub
    Dim NodesThatMatch As New List(Of TreeNode)
    Private Function SearchTheTreeView(ByVal TV As TreeView, ByVal TextToFind As String) As TreeNode
        '  Empty previous
        NodesThatMatch.Clear()
        ' Keep calling RecursiveSearch
        For Each TN As TreeNode In TV.Nodes
            If TN.Tag.trim.toupper = TextToFind.Trim.ToUpper Then
                NodesThatMatch.Add(TN)
            End If
            RecursiveSearch(TN, TextToFind)
        Next
        If NodesThatMatch.Count > 0 Then
            Return NodesThatMatch(0)
        Else
            Return Nothing
        End If
    End Function
    Private Sub RecursiveSearch(ByVal treeNode As TreeNode, ByVal TextToFind As String)
        ' Keep calling the test recursively.
        For Each TN As TreeNode In treeNode.Nodes
            If TN.Tag.trim.toupper = TextToFind.Trim.ToUpper Then
                NodesThatMatch.Add(TN)
            End If
            RecursiveSearch(TN, TextToFind)
        Next
    End Sub

    Sub popuniListBoxTabele(ByVal ind As Integer, ByVal tt() As String, ByVal lb As ListBox, ByVal p As Panel, ByVal erowindex As Integer, ByVal ww As String)

        lb.Tag = erowindex
        lb.AccessibleName = ind
        lb.AccessibleDescription = ww
        lb.Items.Clear()
        p.Height = 50
        lb.Height = 50

        Dim nl(,) As String = {}
        Dim nll() As Integer = {}
        Dim nllt() As String = {}
        ReDim nl(tt.GetUpperBound(0), 1)
        ReDim nll(tt.GetUpperBound(0)) : ReDim nllt(tt.GetUpperBound(0))
        Dim listOfTuples As New List(Of Tuple(Of String, Integer, String))

        For i As Integer = 0 To tt.GetUpperBound(0)
            Dim nn As TreeNode = SearchTheTreeView(tv, tt(i).Trim.ToUpper())
            Dim nodeLevel As Integer = nn.Level
            Dim nodeIndex As Integer = nn.Index
            nl(i, 0) = tt(i)
            nl(i, 1) = CStr(nodeIndex * 10 + nodeLevel)
            nll(i) = nn.Level
            nllt(i) = tt(i)
            ' Add both elements with the index to keep the association
            listOfTuples.Add(Tuple.Create(nl(i, 0), nodeIndex * 10 + nodeLevel, nl(i, 1)))
        Next

        ' Sort the list of tuples based on the second item
        listOfTuples.Sort(Function(x, y) x.Item2.CompareTo(y.Item2))

        ' Now you can transfer the sorted tuples back into the 2D array if necessary
        For i As Integer = 0 To listOfTuples.Count - 1

            Dim iinndd As Integer = Array.IndexOf(nllt, listOfTuples(i).Item1)
            Dim level As Integer = nll(iinndd)
            lb.Items.Add(Space(4 * level) + listOfTuples(i).Item1)
            'nl(i, 1) = listOfTuples(i).Item3
        Next



        Dim hh As Integer = lb.Items.Count * 28 + 5
        If hh > 50 Then
            p.Height = lb.Items.Count * 33
            lb.Height = p.Height
        End If

    End Sub
    Function GetPKFromSelectedRow(ByVal dgv As DataGridView, ByVal erowindex As Integer) As String(,)
        Dim kljucV(,) As String = Nothing
        Dim pomind As Integer = Array.IndexOf(niz_dgv, dgv)
        Dim tabela As String = sveTabele(pomind)
        Dim kljuc() As String = DajKljuceve(tabela)
        Dim ti As TcolInfo = niz_TColInfo(pomind)
        Dim tRed As Integer = dgv.CurrentRow.Index
        dgv.ClearSelection()
        dgv.Rows(tRed).Selected = True

        If dgv.SelectedRows.Count > 0 AndAlso Not dgv.Rows(dgv.SelectedRows(0).Index).IsNewRow Then
            Dim row As DataGridViewRow = dgv.SelectedRows(0)
            Dim rv2 As DataRow = Nothing
            If dgv.CurrentRow IsNot Nothing Then
                Dim currentRowView As DataRowView = TryCast(dgv.CurrentRow.DataBoundItem, DataRowView)
                If currentRowView IsNot Nothing Then rv2 = currentRowView.Row
            End If

            kljucV = Nothing
            ReDim kljucV(kljuc.GetUpperBound(0), 1)

            For i As Integer = 0 To kljuc.GetUpperBound(0)
                For Each col As DataColumn In rv2.Table.Columns
                    If kljuc(i).Trim.ToUpper = col.ColumnName.Trim.ToUpper AndAlso Not rv2.IsNull(col.ColumnName) Then
                        kljucV(i, 0) = col.ColumnName.ToString.Trim.ToUpper
                        kljucV(i, 1) = rv2.Item(col.ColumnName).ToString.Trim.ToUpper
                        Exit For
                    End If
                Next
            Next
        End If

        GetPKFromSelectedRow = kljucV
    End Function

    Private Sub lb_MouseUp(sender As Object, e As MouseEventArgs)

        Dim lb As ListBox = DirectCast(sender, ListBox)
        Dim index As Integer = lb.IndexFromPoint(e.Location)
        If index <> ListBox.NoMatches Then
            ' An item was clicked, do something with it
            Dim tabelagdeidem As String = lb.Items(index).ToString.Trim.ToUpper

            Dim dgvodakleSamDosaoTabela As DataGridView = niz_dgv(CInt(lb.AccessibleName))
            Dim odakleSamDosaoTabela As String = dgvodakleSamDosaoTabela.Name.Trim.ToUpper
            Dim erowindex1 As Integer = CInt(lb.Tag)
            Dim ww As String = lb.AccessibleDescription
            Dim indtabelagdeidem As Integer = Array.IndexOf(sveTabele, tabelagdeidem)
            Dim dgvtabelagdeidem As DataGridView = niz_dgv(indtabelagdeidem)
            Call odvediME(odakleSamDosaoTabela, dgvodakleSamDosaoTabela, tabelagdeidem, indtabelagdeidem, dgvtabelagdeidem, ww.Trim.ToUpper)

        End If
    End Sub
    Private Sub ApplyFilter(ByVal ind As Integer, ByVal reset As Boolean)

        Me.Cursor = Cursors.WaitCursor
        Dim sql As String = ""
        Dim sqlJoin As String = ""
        Dim kljucK() As String = {}
        Dim kljuc() As String = {}
        Dim fdgv As DataGridView = niz_fdgv(ind)
        Dim fdt As System.Data.DataTable = CType(fdgv.DataSource, System.Data.DataTable)
        Dim fdt2 As System.Data.DataTable = CType(fdgv.DataSource, System.Data.DataTable)
        Dim tabela As String = sveTabele(ind)
        Dim filterStari As String = "2=2"
        If niz_frsR(ind) <> "" Then filterStari = niz_frsR(ind)

        Dim nnode As TreeNode = SearchTheTreeView(tv, tabela)
        Dim tt() As String = ttTtt(nnode)

        Dim filterString As String = "2=2"
        If reset = False Then
            filterString = frsR.Get_Frowcol(fdt) + " and " + filterStari
            Me.filtred(filterString, tt, False)   'vraca filter sa D.
            fdgv.DataSource = fdt2
        Else
            Me.filtred(filterStari, tt, False)   'vraca filter sa D.
        End If

        If ComboBoxTabele.Items.Count > 1 Then Me.ComboBoxTabele.Enabled = True

        If Not niz_Left Is Nothing AndAlso Not niz_Right Is Nothing Then
            Call DGVShowColumns22(niz_dgv(ind), niz_Left(ind), niz_Right(ind))
            Call DGVShowColumns22(niz_fdgv(ind), niz_Left(ind), niz_Right(ind))
        End If

        Me.Cursor = Cursors.Default
    End Sub
    Sub odvediME(ByVal odakleSamDosaoTabela As String, ByVal dgvodakleSamDosaoTabela As DataGridView, ByVal tabelagdeidem As String, ByVal indtabelagdeidem As Integer, ByVal dgvtabelagdeidem As DataGridView, ByVal ww As String)

        Dim nnodeOSD As TreeNode = SearchTheTreeView(tv, odakleSamDosaoTabela)
        Dim tt() As String = ttTtt(nnodeOSD)

        Dim iOSD As Integer = Array.IndexOf(tt, odakleSamDosaoTabela)
        Dim iGI As Integer = Array.IndexOf(tt, tabelagdeidem)
        Dim idemNaPodTabelu As Boolean = False
        Dim idemNaNadTabelu As Boolean = False
        If iOSD < iGI Then
            'idem na podtabelu
            idemNaPodTabelu = True
            idemNaNadTabelu = False
        End If

        If iOSD > iGI Then
            'idem na nadtabelu
            idemNaPodTabelu = False
            idemNaNadTabelu = True
        End If

        Dim filterStari As String = "2=2"
        If niz_frsR(indtabelagdeidem) <> "" Then filterStari = niz_frsR(indtabelagdeidem)

        Dim filterstring As String = "2=2"
        Dim kljucTGI() As String = DajKljuceve(tabelagdeidem)
        Dim kljucTODS(,) As String = GetPKFromSelectedRow(dgvodakleSamDosaoTabela, 0)
        If idemNaPodTabelu = True Then
            For i1 As Integer = 0 To kljucTGI.GetUpperBound(0)
                For i2 As Integer = 0 To kljucTODS.GetUpperBound(0)
                    If kljucTGI(i1).Trim.ToUpper = kljucTODS(i2, 0) Then
                        filterstring = filterstring + " and " + kljucTGI(i1) + "='" + kljucTODS(i2, 1) + "'"
                        Exit For
                    End If
                Next
            Next
            'idem na podtabelu
            filterstring = filterstring + " and " + filterStari
            Me.filtredT(filterstring, tabelagdeidem)
        End If

        If idemNaNadTabelu = True Then
            'idem na nadtabelu koja nije nadnadtabela
            If tabelagdeidem.Trim.ToUpper <> tt(0).Trim.ToUpper Then
                Dim TGI_NT As String = nadtabelaJe(tabelagdeidem)
                Dim kljucTGI_NT() As String = DajKljuceve(TGI_NT)
                For i1 As Integer = 0 To kljucTGI_NT.GetUpperBound(0)
                    For i2 As Integer = 0 To kljucTODS.GetUpperBound(0)
                        If kljucTGI(i1).Trim.ToUpper = kljucTODS(i2, 0) Then
                            filterstring = filterstring + " and " + kljucTGI_NT(i1) + "='" + kljucTODS(i2, 1) + "'"
                            Exit For
                        End If
                    Next
                Next
                filterstring = filterstring + " and " + filterStari
                Me.filtredT(filterstring, tabelagdeidem)
            Else
                Me.filtredT(filterStari, tabelagdeidem)
            End If
        End If

        Me.ComboBoxTabele.SelectedItem = tabelagdeidem
        If ww.Trim.ToUpper = "➕" Then
            dgvtabelagdeidem.AccessibleName = odakleSamDosaoTabela
            dgvtabelagdeidem.Columns(0).HeaderText = "🠈"
        ElseIf ww.Trim.ToUpper = "➖" Then
            If nadtabelaJe(dgvtabelagdeidem.Name) <> "" Then
                dgvtabelagdeidem.AccessibleName = nadtabelaJe(dgvtabelagdeidem.Name)
                dgvtabelagdeidem.Columns(0).HeaderText = "🠈"
            Else
                dgvtabelagdeidem.AccessibleName = ""
                dgvtabelagdeidem.Columns(0).HeaderText = ""
            End If
        End If

        If idemNaNadTabelu = True AndAlso Not dgvtabelagdeidem.AccessibleDescription Is Nothing AndAlso dgvtabelagdeidem.AccessibleDescription <> "" AndAlso IsNumeric(dgvtabelagdeidem.AccessibleDescription) = True Then
            dgvtabelagdeidem.ClearSelection()
            dgvtabelagdeidem.Rows(dgvtabelagdeidem.AccessibleDescription).Selected = True
        End If

        If Not niz_Left Is Nothing AndAlso Not niz_Right Is Nothing Then
            Call DGVShowColumns22(niz_dgv(indtabelagdeidem), niz_Left(indtabelagdeidem), niz_Right(indtabelagdeidem))
            Call DGVShowColumns22(niz_fdgv(indtabelagdeidem), niz_Left(indtabelagdeidem), niz_Right(indtabelagdeidem))
        End If

    End Sub
    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        If e.RowIndex = -1 Then ' -1 is the index of the header row
            ' Check if the click is on the first column header
            If e.RowIndex = -1 Then ' -1 is the index of the header row
                ' Check if the click is on the first column header
                If e.ColumnIndex = 0 Then
                    If Not dgv.AccessibleName Is Nothing AndAlso dgv.AccessibleName <> "" Then
                        Dim tabelagdeidem As String = dgv.AccessibleName
                        If tabelagdeidem <> "" Then
                            Dim indtabelagdeidem As Integer = -1
                            If tabelagdeidem.IndexOf(".") > 0 Then
                                indtabelagdeidem = Array.IndexOf(sveTabeleSAPFX, tabelagdeidem)
                            Else
                                indtabelagdeidem = Array.IndexOf(sveTabele, tabelagdeidem)
                            End If
                            Dim dgvodakleSamDosaoTabela As DataGridView = dgv
                            Dim dgvtabelagdeidem As DataGridView = niz_dgv(indtabelagdeidem)
                            Dim odakleSamDosaoTabela As String = dgvodakleSamDosaoTabela.Name.Trim.ToUpper
                            Call odvediME(odakleSamDosaoTabela, dgvodakleSamDosaoTabela, tabelagdeidem, indtabelagdeidem, dgvtabelagdeidem, "➖")
                        End If
                        Exit Sub
                    End If

                End If
            End If
        End If

        If e.ColumnIndex > -1 Then

            If dgv.Columns.Contains("secondRowHeader") AndAlso dgv.Columns("secondRowHeader").Visible = False Then
                Exit Sub
            End If

            Dim ind As Integer = Array.IndexOf(niz_dgv, dgv)
            Dim tabela As String = sveTabele(ind)

            If niz_pdgv(ind).Visible = True Then
                niz_pdgv(ind).Visible = False
                Exit Sub
            End If

            If dgv.Columns.Contains("secondRowHeader") AndAlso dgv.Columns("secondRowHeader").Visible = True AndAlso dgv.Columns(e.ColumnIndex).DisplayIndex <> dgv.Columns("secondRowHeader").DisplayIndex Then
                For i As Integer = 0 To niz_pdgv.GetUpperBound(0)
                    niz_pdgv(i).Visible = False
                Next
            End If

            Dim ki As Integer = -1
            Dim ww As String = ""
            Dim tabeleZaPrikaz() As String = Nothing

            If dgv.Columns.Contains("secondRowHeader") AndAlso dgv.Columns("secondRowHeader").Visible = True AndAlso dgv.Columns(e.ColumnIndex).DisplayIndex = dgv.Columns("secondRowHeader").DisplayIndex Then
                ki = dgv.Columns("secondRowHeader").Index
                ww = dgv.Rows(e.RowIndex).Cells(dgv.Columns("secondRowHeader").Index).Value
                If ww.Trim.ToUpper = "➕" Then
                    tabeleZaPrikaz = NadjiSvePodTabeleOD(tabela)
                ElseIf ww.Trim.ToUpper = "➖" Then
                    tabeleZaPrikaz = NadjiSveNadTabeleOD(tabela)
                Else
                    tabeleZaPrikaz = Nothing
                End If
                If Not tabeleZaPrikaz Is Nothing Then
                    Call popuniListBoxTabele(ind, tabeleZaPrikaz, niz_l(ind), niz_pdgv(ind), e.RowIndex, ww.Trim.ToUpper)
                    Dim rowRect As Rectangle = dgv.GetRowDisplayRectangle(e.RowIndex, False)
                    niz_pdgv(ind).Location = New Point(dgv.Location.X + rowRect.X + dgv.RowHeadersWidth, dgv.Location.Y + rowRect.Y + rowRect.Height)
                    For i As Integer = 0 To niz_pdgv.GetUpperBound(0)
                        niz_pdgv(i).Visible = False
                    Next
                    niz_pdgv(ind).Visible = True
                    niz_pdgv(ind).BringToFront()
                    dgv.AccessibleDescription = e.RowIndex
                    If e.RowIndex < dgv.FirstDisplayedScrollingRowIndex OrElse e.RowIndex > dgv.FirstDisplayedScrollingRowIndex + dgv.DisplayedRowCount(False) Then
                        dgv.FirstDisplayedScrollingRowIndex = e.RowIndex
                    End If
                End If
            End If


        End If

    End Sub
    Private Sub dg_RowEnter(sender As Object, e As DataGridViewCellEventArgs)

        Dim rowIndex As Integer = e.RowIndex
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim ind As Integer = Array.IndexOf(niz_dgv, dgv)

        'sve promene, ukljucujuci i vrednost gresaka imam u ti, a ne u DGV

        dgv.ClearSelection()
        dgv.Rows(e.RowIndex).Selected = True

        Dim rv2 As DataRow = Nothing
        If dgv.Rows(e.RowIndex) IsNot Nothing Then
            Dim tabela As String = sveTabele(ind)
            'If dgv.SelectedRows.Count > 0 Then
            '    For i As Integer = 0 To niz_pdgv.GetUpperBound(0)
            '        niz_pdgv(i).Visible = False
            '    Next
            'End If
            Dim currentRowView As DataRowView = TryCast(dgv.Rows(e.RowIndex).DataBoundItem, DataRowView)
            If currentRowView IsNot Nothing Then
                rv2 = currentRowView.Row
            Else
                ''msg 213
                Dim msgtxt213 As String = getMessageText(dtMessages, "213", Me.jezik)
                ISTMessageBox.Show(msgtxt213, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim dtn As DataTable = Greska2(Me.getexprSQL(rv2, tabela, "", "d."), ind)
            rv2 = dtn.Rows(0)
            Dim ti As TcolInfo = niz_TColInfo(ind)
            ti.daj_dt_greskeZaSlog(rv2)
            ti.dg_greskeZaSlog.DataSource = ti.dt_greskeZaSlog
            If niz_fdgv(ind).Columns.Count > 0 Then
                For i As Integer = 0 To dgv.Columns.Count - 1
                    If niz_fdgv(ind).Columns.Contains(dgv.Columns(i).Name) Then
                        niz_fdgv(ind).Columns(i).Visible = dgv.Columns(i).Visible
                    End If

                Next
            End If

        End If
    End Sub

    Private Sub TabControlGreske_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControlGreske.SelectedIndexChanged
        Dim ind As Integer = -1
        For i As Integer = 0 To niz_dgv.GetUpperBound(0)
            If niz_dgv(i).Visible = True Then
                ind = i
                Exit For
            End If
        Next

        If ind = -1 Then Exit Sub

        If Me.TabControlGreske.SelectedIndex = 0 Then
        ElseIf Me.TabControlGreske.SelectedIndex = 1 Then

            Dim ti As TcolInfo = niz_TColInfo(ind)
            If Not ti Is Nothing Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                ti.daj_dt_greskezaPrikazaneSlogove(ti)
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If

        ElseIf Me.TabControlGreske.SelectedIndex = 2 Then
            Dim ti As TcolInfo = niz_TColInfo(ind)
            If Not ti Is Nothing Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                ti.daj_dt_greskeZaTabelu()
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End If

        End If
    End Sub

    Private Sub dg_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs)
        'Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        'Dim ind As Integer = Array.IndexOf(niz_dgv, dgv)
        'Dim ti As TcolInfo = niz_TColInfo(ind)
        'If ti Is Nothing Then Return

        ''ti.daj_dt_greskeZaSlog(rv2)
        ''ti.daj_dt_greskezaPrikazaneSlogove(dgv)
        ''ti.daj_dt_greskeZaTabelu()
        ''ti.dg_greskeZaSlog.DataSource = ti.dt_greskeZaSlog
        ''ti.dg_greskeZaPrikazaneSlogove.DataSource = ti.dt_greskeZaPrikazaneSlogove



        'If dgv.CurrentRow IsNot Nothing Then
        '    Dim currentRowView As DataRowView = TryCast(dgv.CurrentRow.DataBoundItem, DataRowView)
        '    If currentRowView IsNot Nothing Then
        '        Dim rv As DataRow = currentRowView.Row
        '        ' Now you can access dataRow's fields
        '        ti.daj_dt_greskeZaSlog(rv)
        '        ti.dg_greskezaSlog_CurrentCellChanged(ti.dg_greskeZaSlog, Nothing)
        '    End If
        'End If
    End Sub

    'Sub DGVShowColumns(ByVal dgv As DataGridView, ByVal cs() As String)
    '    For i As Integer = 0 To cs.GetUpperBound(0)
    '        Dim nname As String = cs(i).Trim.ToUpper
    '        dgv.Columns(nname).Visible = True
    '    Next
    'End Sub
    Private Sub chbA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbA.CheckedChanged
        If prosaoLoad = 1 Then
            Dim ind As Integer = IzabranaTabelaIndikatorJe()
            If ind > -1 AndAlso Me.chbA.Checked = True AndAlso Not niz_TColInfo Is Nothing Then
                niz_TColInfo(ind).pamtics = {}
                Call visibleColumns(niz_dgv(ind), niz_TColInfo(ind).mviscol, imaPodTabelu(ind) OrElse imaNadTabelu(ind))
                Call visibleColumns(niz_fdgv(ind), niz_TColInfo(ind).mviscol, imaPodTabelu(ind) OrElse imaNadTabelu(ind))
            End If
        End If
    End Sub

    Private Sub BrisiSlog()
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim tabela As String = sveTabele(pomind)
        'Dim glavnatabela As String = GtabelaJe(sveTabele(pomind).Trim.ToUpper)
        'pomind = Array.IndexOf(sveTabele, glavnatabela.Trim.ToUpper)

        Dim kljuc() As String = DajKljuceve(tabela)

        Dim dgv As DataGridView = niz_dgv(pomind)
        Dim ti As TcolInfo = niz_TColInfo(pomind)

        Dim tRed As Integer = dgv.CurrentRow.Index
        dgv.ClearSelection()
        dgv.Rows(tRed).Selected = True

        If dgv.SelectedRows.Count > 0 AndAlso Not dgv.Rows(dgv.SelectedRows(0).Index).IsNewRow Then
            Dim row As DataGridViewRow = dgv.SelectedRows(0)
            Dim rv2 As DataRow = Nothing
            If dgv.CurrentRow IsNot Nothing Then
                Dim currentRowView As DataRowView = TryCast(dgv.CurrentRow.DataBoundItem, DataRowView)
                If currentRowView IsNot Nothing Then rv2 = currentRowView.Row
            End If

            Dim kljucV(,) As String = Nothing
            ReDim kljucV(kljuc.GetUpperBound(0), 1)

            For i As Integer = 0 To kljuc.GetUpperBound(0)
                For Each col As DataColumn In rv2.Table.Columns
                    If kljuc(i).Trim.ToUpper = col.ColumnName.Trim.ToUpper AndAlso Not rv2.IsNull(col.ColumnName) Then
                        kljucV(i, 0) = col.ColumnName.ToString.Trim.ToUpper
                        kljucV(i, 1) = rv2.Item(col.ColumnName).ToString.Trim.ToUpper
                        Exit For
                    End If
                Next
            Next

            ''msg 216
            Dim msgtxt216 As String = getMessageText(dtMessages, "216", Me.jezik)
            Dim dr As DialogResult = ISTMessageBox.Show(msgtxt216, "Error-Stop", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If dr <> DialogResult.Yes Then
                Return
            End If

            'kljuc
            'obrisati u svim podtabelama dalje, prvo po gridovima, pa posle dalje
            Dim svePodtabele() As String = NadjiSvePodTabeleOD(tabela)
            For i As Integer = 0 To svePodtabele.GetUpperBound(0)
                Dim ind As Integer = Array.IndexOf(sveTabele, svePodtabele(i).Trim.ToUpper)
                Dim dgvP As DataGridView = niz_dgv(ind)
                Call FindAndDeleteAllRowsByValues(dgvP, kljucV)
            Next
            dgv.DataSource.Rows(row.Index).Delete()
            'mora prvo da obrise child slogove pa tek onda glavnu tabeli
            DirectCast(dgv.DataSource, DataTable).AcceptChanges()



            Dim rowsAff As Long
            If lokalno = True Then
                rowsAff = BrisiIzBaze(tabela, svePodtabele, kljucV, True)
            Else
                rowsAff = BrisiIzBaze(tabela, svePodtabele, kljucV)
            End If
        End If

        If tRed < dgv.Rows.Count - 1 Then
            dgv.ClearSelection()
            dgv.Rows(tRed).Selected = True
        End If

    End Sub
    Private Function BrisiIzBaze(ByVal tabela As String, ByVal svePodtabele() As String, ByVal kljucv(,) As String, Optional lok As Boolean = False) As Long

        Dim sqlLogBrisanja As String = ""
        Dim strDelete As String = ""
        Dim strWhere As String = "2=2"
        Dim ind As Integer = -1
        For i As Integer = 0 To svePodtabele.GetUpperBound(0)
            strWhere = "2=2"
            ind = Array.IndexOf(sveTabele, svePodtabele(i).Trim.ToUpper)
            strDelete = strDelete + "delete from " + svePodtabele(i) + " where 2=2 "
            For mm As Integer = 0 To kljucv.GetUpperBound(0)
                strDelete = strDelete + " and " + kljucv(mm, 0) + "=N'" + kljucv(mm, 1) + "'"
                strWhere = strWhere + " and " + kljucv(mm, 0) + "=N'" + kljucv(mm, 1) + "'"
            Next
            If postojiLKpolje(ind) = True Then
                strDelete = strDelete + " AND (CAST(COALESCE (LK, 0) AS int) = 0) "
                strWhere = strWhere + " AND (CAST(COALESCE (LK, 0) AS int) = 0) "
            End If
            strDelete = strDelete + "; " + nvrd
            sqlLogBrisanja = sqlLogBrisanja + "insert into ISTLogBrisanja (SifIst,Tabela,ko,vreme,red) " _
                & " values( " _
                & "'" & sifist & "'," _
                & "'" & svePodtabele(i).Trim.ToUpper & "'," _
                & "'" & GetUserName.ToString.Trim & "'," _
                & "" & "(select top 1 GETDATE())" & "," _
                & "'" & strWhere.Replace("N'", "").Replace("'", "") & "'" _
                & ");"
        Next

        'glavna mora na kraju
        strDelete = strDelete + "delete from " + tabela + " where 2=2 "
        ind = Array.IndexOf(sveTabele, tabela.Trim.ToUpper)

        For i As Integer = 0 To kljucv.GetUpperBound(0)
            strDelete = strDelete + " and " + kljucv(i, 0) + "=N'" + kljucv(i, 1) + "'"
            strWhere = strWhere + " and " + kljucv(i, 0) + "=N'" + kljucv(i, 1) + "'"
        Next
        If postojiLKpolje(ind) = True Then
            strDelete = strDelete + " AND (CAST(COALESCE (LK, 0) AS int) = 0) "
            strWhere = strWhere + " AND (CAST(COALESCE (LK, 0) AS int) = 0) "
        End If
        strDelete = strDelete + "; " + nvrd

        sqlLogBrisanja = sqlLogBrisanja + "insert into ISTLogBrisanja (SifIst,Tabela,ko,vreme,red) " _
                & " values( " _
                & "'" & sifist & "'," _
                & "'" & tabela.Trim.ToUpper & "'," _
                & "'" & GetUserName.ToString.Trim & "'," _
                & "" & "(select top 1 GETDATE())" & "," _
                & "'" & strWhere.Replace("N'", "").Replace("'", "") & "'" _
                & ");"

        Dim ok As String = ""
        Try
            'Call izvrsiSQLVratiBrojSlogova(strDelete, Me.DBConnectionString)
            ok = izvrsiSQL(strDelete, Me.DBConnectionString)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message + vbCrLf + strDelete, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If lok = False AndAlso ok = "ok" Then
            Dim okLog As String = izvrsiSQL(sqlLogBrisanja, konDepo)
            If okLog <> "ok" Then
                ISTMessageBox.Show(sqlLogBrisanja + nvrd + nvrd + "is not executed! ER16", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Function
    Private Sub FindAndDeleteAllRowsByValues(dgv As DataGridView, ByVal kljucV(,) As String)
        Dim pp() As Integer = {}
        Dim ipp As Integer = -1
        For Each row As DataGridViewRow In dgv.Rows
            Dim nadjen As Boolean = True
            Dim izadji As Boolean = False
            For Each cell As DataGridViewCell In row.Cells
                For i As Integer = 0 To kljucV.GetUpperBound(0)
                    If Not row.Cells(kljucV(i, 0)).Value.ToString.Trim.ToUpper = kljucV(i, 1).Trim.ToUpper Then
                        'If Not row.Cells(kljucV(i, 0)).Value.Equals(kljucV(i, 1)) Then
                        nadjen = False
                        izadji = True
                        Exit For
                    End If
                Next
                If izadji = True Then Exit For
            Next
            If nadjen = True Then
                dgv.DataSource.Rows(row.Index).Delete()
                DirectCast(dgv.DataSource, DataTable).AcceptChanges()
            End If
        Next
    End Sub
    Private Sub dg_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim zakljucanUnos As Integer = ProveraUnosLOCK(pomind)
        Me.Unos2(True, zakljucanUnos)
        Me.Cursor = Cursors.Default
    End Sub


    Sub upisiULogFA(ByVal tip As String)
        If Not pamtiUpit Is Nothing Then
            Dim str As String = pamtiUpit.Replace("'", "''").ToUpper
            Dim vt As String = tacv.G.ToString.Trim & tacv.M.ToString.Trim.PadLeft(2, "0"c)
            Dim odakle As String = Me.m_rowIST.Item(0).ToString.Trim + ";" + vt + "; frmAzuriraj"
            Dim strSQL As String = "insert into ISTLogExcelXMLJSON (ko_insert,ExcelXMLJSON,upit,odakle) values('" +
            GetUserName.ToString.Trim + "','" + tip + "','" + str + "','" + odakle + "')"
            Dim ok1 As String = izvrsiSQL(strSQL, konDepo)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER91", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If


    End Sub

    Public Function ssel(ByVal a As TcolInfo, Optional ByVal CitajIGreske As Boolean = False,
                         Optional ByVal DuM As Boolean = False) As String
        Dim x As String = ""

        x = sselPY(a, CitajIGreske, DuM, 1)
        Dim tabela As String = a.dt.TableName.Trim.ToUpper
        If a.dt.Prefix.Trim.ToUpper = "DBO" Then
        Else
            tabela = a.dt.Prefix.Trim.ToUpper + "." + a.dt.TableName.Trim.ToUpper
        End If

        If CitajIGreske Then
            Dim gp As DatasetIstrazivanja.ISTLKRow
            For Each gp In Me.mtlk.Rows
                If tabela = gp.TABELA.Trim.ToUpper Then
                    If x <> "" Then x = x & ","
                    If DuM Then
                        x = x & "isnull(M." + gp.RbrGreske.Trim + ",0) as " + gp.RbrGreske.Trim
                    Else
                        x = x & "isnull(d." + gp.RbrGreske.Trim + ",0) as " + gp.RbrGreske.Trim
                    End If
                End If
            Next
        End If

        'MORA da bi radilo i zakljucavanje kroz grid
        If x <> "" AndAlso Not (a.dt.Columns("LK") Is Nothing) Then
            If DuM AndAlso x.Trim.ToUpper.IndexOf("M.[LK]") < 0 Then x = x & ",M.[LK] "
            If DuM = False AndAlso x.Trim.ToUpper.IndexOf("D.[LK]") < 0 Then x = x & ",D.[LK] "
        End If

        If x <> "" AndAlso Not (a.dt.Columns("INDGR") Is Nothing) Then
            If DuM AndAlso x.Trim.ToUpper.IndexOf("M.[INDGR]") < 0 Then x = x & ",M.[INDGR] "
            If DuM = False AndAlso x.Trim.ToUpper.IndexOf("D.[INDGR]") < 0 Then x = x & ",D.[INDGR] "
        End If

        Return x
    End Function

    Public Function sselPY(ByVal a As TcolInfo, Optional ByVal CitajIGreske As Boolean = False,
                           Optional ByVal DuM As Boolean = False, Optional kojaf As Integer = 2) As String

        Dim x As String = ""
        Dim tp As DatasetIstrazivanja.ISTPOLJARow
        Dim brojac As Integer = 0
        Dim notokDisplay As Boolean = False
        Dim tabela As String = a.dt.TableName.Trim.ToUpper
        If a.dt.Prefix.Trim.ToUpper = "DBO" Then
        Else
            tabela = a.dt.Prefix.Trim.ToUpper + "." + a.dt.TableName.Trim.ToUpper
        End If

        For Each tp In Me.mtp.Rows
            If tp.TABELA.Trim.ToUpper = tabela Then
                Dim ok As Boolean = True
                Dim tpTRT As String = ""
                If tp.IsIzrazNull = False Then
                    If tp.Izraz.Trim.ToUpper.IndexOf(":F") > 0 Then
                        Dim aa As String = "aa"
                    End If
                    tpTRT = tp.Izraz.Trim.ToUpper
                    If tpTRT.Trim.ToUpper.IndexOf("FCALCULATEAGE") >= 0 OrElse tpTRT.Trim.ToUpper.IndexOf("#FP{") >= 0 OrElse
                    tpTRT.Trim.ToUpper.IndexOf(":S") >= 0 OrElse tpTRT.Trim.ToUpper.IndexOf("DATAGRIDVIEW") >= 0 OrElse
                    tpTRT.Trim.ToUpper.IndexOf("AUTOCOMPLETE") >= 0 OrElse tpTRT.Trim.ToUpper.IndexOf("ENCRYPT") >= 0 OrElse
                    (tpTRT.Trim.ToUpper.IndexOf("RADIOBUTTON") < 0 AndAlso tpTRT.Trim.ToUpper.IndexOf("BUTTON") >= 0) OrElse
                    tpTRT.Trim.ToUpper.IndexOf("ISTLBL") >= 0 Then ok = False
                End If
                If ok = True Then
                    tpTRT = zameniRPIZRAZ(tpTRT)
                    If tpTRT.IndexOf("'") = 0 OrElse tpTRT.Trim.ToUpper.IndexOf("{") = 0 Then ok = False
                End If

                If ok = True Then
                    Dim gp As String = ""
                    'If kojaf = 1 Then
                    gp = getPoljet1(tp.IsIzrazNull, tp.POLJE, tpTRT, DuM, tabela)
                    'Else
                    '    gp = getPoljet2(tp.IsIzrazNull, tp.POLJE, tpTRT, DuM)
                    'End If
                    If gp <> "" Then
                        brojac = brojac + 1
                        If brojac < 1024 Then
                            x = x & gp & "," & nvrd
                        Else
                            notokDisplay = True
                            Exit For
                        End If
                    End If
                End If
            End If
        Next

        ' If notokDisplay = True Then ISTMessageBox.Show("Column count exceed 1024 columns." + nvrd + nvrd + "Only first 1024 columns will be diplayed.")

        If x <> "" Then
            x = x.Trim + "$$$"
            x = x.Replace(",$$$", "")
        End If

        Return x

    End Function



    Function getPoljet1(ByVal tpIsIzrazNull As Boolean, ByVal tppolje As String, ByVal tptrt As String,
                        ByVal DUM As Boolean, ByVal tabela As String) As String
        Dim x As String = ""
        If Not (tpIsIzrazNull OrElse tptrt = "" _
                OrElse InStr(tptrt.ToUpper, "LINKLABEL") > 0 _
                OrElse InStr(tptrt.ToUpper, "DATAGRIDVIEW") > 0 _
                OrElse InStr(tptrt.ToUpper, "AUTOCOMPLETE") > 0 _
                OrElse InStr(tptrt.ToUpper, "ENCRYPT") > 0 _
                OrElse InStr(tptrt.ToUpper, "CHECKBOX") > 0 _
                OrElse InStr(tptrt.ToUpper, "RADIOBUTTON") > 0 _
                OrElse InStr(tptrt.ToUpper, "DATETIMEPICKER") > 0 _
                OrElse InStr(tptrt.ToUpper, "CBO{") > 0 _
                OrElse InStr(tptrt.ToUpper, "CBW{") > 0) Then
            If tptrt <> "" AndAlso InStr(tptrt, "#") = 0 AndAlso InStr(tptrt.ToUpper, "GLAVA.") = 0 AndAlso
                    InStr(tptrt.ToUpper, "HEAD.") = 0 AndAlso InStr(tptrt.ToUpper, "#FP{") = 0 AndAlso InStr(tptrt.ToUpper, "FCALCULATEAGE") = 0 AndAlso tptrt.Substring(0, 1) <> "{" AndAlso
                    InStr(tptrt.ToUpper, "PG.") <= 0 AndAlso InStr(tptrt.ToUpper, "PY.") <= 0 AndAlso
                    InStr(tptrt.ToUpper, "PM.") <= 0 AndAlso InStr(tptrt.ToUpper, "PMONTH.") <= 0 AndAlso
                    InStr(tptrt.ToUpper, "PK.") <= 0 AndAlso InStr(tptrt.ToUpper, "PQ.") <= 0 AndAlso
                    InStr(tptrt.ToUpper, "PP.") <= 0 AndAlso InStr(tptrt.ToUpper, "PH.") <= 0 Then
                If x <> "" Then x = x & ","
                x = x & "(" + tptrt + ") as "
                If DUM Then x = x.ToUpper.Replace("D.", "M.")
                x = x & "[" & tppolje.Trim & "]"
            ElseIf tptrt <> "" AndAlso InStr(tptrt, "#") = 1 AndAlso InStr(tptrt.Trim.ToUpper, "SELECT") > 0 AndAlso InStr(tptrt.Trim.ToUpper, "FROM") = 0 Then
                tptrt = tptrt.Replace("#", "").Replace("{", "").Replace("}", "").Replace(":F", "").Replace(":S", "").Replace(":PK", "").Replace("SELECT", "")
                If x <> "" Then x = x & ","
                x = x & "(" + tptrt + ") as "
                If DUM Then x = x.ToUpper.Replace("D.", "M.")
                x = x & "[" & tppolje.Trim & "]"
            ElseIf tptrt <> "" AndAlso InStr(tptrt, "#") = 0 AndAlso InStr(tptrt.Trim.ToUpper, "SELECT") = 0 AndAlso (InStr(tptrt.ToUpper, "PG.") > 0 OrElse InStr(tptrt.ToUpper, "PY.") > 0 OrElse
                    InStr(tptrt.ToUpper, "PM.") > 0 OrElse InStr(tptrt.ToUpper, "PMONTH.") > 0 OrElse
                    InStr(tptrt.ToUpper, "PK.") > 0 OrElse InStr(tptrt.ToUpper, "PQ.") > 0 OrElse
                    InStr(tptrt.ToUpper, "PP.") > 0 OrElse InStr(tptrt.ToUpper, "PH.") > 0) Then
                tptrt = tptrt.Replace("#", "").Replace("{", "").Replace("}", "").Replace(":F", "").Replace(":S", "").Replace(":PK", "")
                If x <> "" Then x = x & ","
                x = x & "(" + tptrt + ") as "
                If DUM Then x = x.ToUpper.Replace("D.", "M.")
                x = x & "[" & tppolje.Trim & "]"
            Else
                Dim trt As String = tptrt.ToUpper
                If InStr(trt, ":S") = 0 AndAlso InStr(trt.Trim.ToUpper, "GLAVA.") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "HEAD.") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "#FP{") = 0 AndAlso
                                                            InStr(tptrt.ToUpper, "FCALCULATEAGE") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "CBO{") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "CBW{") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "ISTLBL") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "LINKLABEL") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "DATAGRIDVIEW") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "AUTOCOMPLETE") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "ENCRYPT") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "DATETIMEPICKER") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "CHECKBOX") = 0 AndAlso
                                                            InStr(trt.Trim.ToUpper, "RADIOBUTTON") = 0 AndAlso
                    trt.Trim.Substring(0, 1) <> "{" Then
                    trt = Replace(trt, "#", "")
                    trt = Replace(trt, "{", "")
                    trt = Replace(trt, ";}", "")
                    trt = Replace(trt, "; }", "")
                    trt = Replace(trt, "}", "")
                    If InStr(trt, ":") <> 0 Then trt = trt.Substring(0, trt.IndexOf(":"))
                    If DUM Then trt = Replace(trt, "D.", "M.")
                    If x <> "" Then x = x & ","
                    If trt.IndexOf(" MEM ") > 0 Then
                        'DODAJKLJUCNADTABELE
                        Dim podtabela As String = ""
                        Dim bbb() As String = razkvantaj(trt)
                        For ll As Integer = 1 To bbb.GetUpperBound(0) 'ne moze mem da bude nulti
                            If bbb(ll).Trim.ToUpper = "MEM" Then podtabela = bbb(ll - 1) : Exit For
                        Next
                        Dim klj() As String = DajKljuceve(tabela)
                        For ii As Integer = 0 To klj.GetUpperBound(0)
                            trt = trt + " and " + klj(ii) + "=D." + klj(ii)
                        Next
                        If DUM Then trt = Replace(trt, "D.", "M.")
                    End If

                    x = x & "(" + trt + ") as [" & tppolje.Trim & "]"

                End If
            End If
        Else
            If x <> "" Then x = x & ","
            If DUM Then
                x = x & "M.[" & tppolje.Trim & "]"
            Else
                x = x & "d.[" & tppolje.Trim & "]"
            End If
        End If

        getPoljet1 = x
    End Function

    Private Function DajKljuceve(ByVal tbl As String) As String()
        Dim klj() As String = {}
        For Each p As DatasetIstrazivanja.ISTPOLJARow In Me.mtp.Rows
            If p.TABELA.Trim.ToUpper = tbl.Trim.ToUpper Then
                If Not p.IsKLJUCNull AndAlso p.KLJUC.Trim.ToUpper = "P" Then
                    ReDim Preserve klj(1 + klj.GetUpperBound(0))
                    klj(klj.GetUpperBound(0)) = p.POLJE.Trim.ToUpper
                End If
            End If
        Next
        Return klj
    End Function

    Private Sub ComboBoxTabele_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxTabele.SelectedIndexChanged

        If Me.ComboBoxTabele.Items.Count = 1 Then
            Return
        End If

        If prosaoLoad = 1 Then
            Call cbsic(CStr(Me.ComboBoxTabele.SelectedItem).Trim.ToUpper)
        End If
    End Sub
    Sub cbsic(ByVal tabela As String)

        Dim ind As Integer = -1
        If tabela.IndexOf(".") > 0 Then
            ind = Array.IndexOf(sveTabeleSAPFX, tabela)
        Else
            ind = Array.IndexOf(sveTabele, tabela)
        End If
        For i As Integer = 0 To niz_pdgv.GetUpperBound(0)
            niz_pdgv(i).Visible = False
        Next
        Call visibleFalseSviDGV()
        niz_dgv(ind).Dock = DockStyle.Fill
        niz_TColInfo(ind).dt.DefaultView.RowFilter = String.Empty
        niz_TColInfo(ind).pamtics = {}
        Call visibleColumns(niz_fdgv(ind), niz_TColInfo(ind).mviscol, imaPodTabelu(ind) OrElse imaNadTabelu(ind))
        Call visibleColumns(niz_dgv(ind), niz_TColInfo(ind).mviscol, imaPodTabelu(ind) OrElse imaNadTabelu(ind))

        Call visibleTrueDGV(ind)

        Call izabranaTabelaPostavi(ind)
    End Sub
    Private Sub ButtonAIzborSlogova1_Click(sender As Object, e As EventArgs) Handles ButtonIzborSlogova.Click
        Call RowSelection()
    End Sub

    Private Sub ButtonIzborKolona_Click(sender As Object, e As EventArgs) Handles ButtonIzborKolona.Click
        Me.ColumnSelection()
    End Sub

    Private Sub ButtonAzuriraj_Click(sender As Object, e As EventArgs) Handles ButtonAzurirajSlogUDGV.Click
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim zakljucanUnos As Integer = ProveraUnosLOCK(pomind)
        If zakljucanUnos = 1 Then
            ''msg 220
            Dim msgtxt220 As String = getMessageText(dtMessages, "220", Me.jezik)
            ''msg 65
            Dim msgtxt65 As String = getMessageText(dtMessages, "65", Me.jezik)
            ISTMessageBox.Show(msgtxt220, msgtxt65, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Kolona2()
        End If
    End Sub

    Private Sub ButtonLK_Click(sender As Object, e As EventArgs) Handles ButtonLK.Click
        Call LKontrolaUradi()
    End Sub
    Sub LKontrolaUradi()
        Dim lk As New LogickaKontrola(Me.DBConnectionString, Me.m_rowIST.ISTBAZERow, Me.mtt, Me.mtp, Me.mta, Me.mtlk, Nothing, Nothing, Me.tacv, Me.jezik)
        Me.Cursor = Cursors.WaitCursor
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim izabranaTabela As String = sveTabeleSAPFX(pomind).Trim

        Dim tabela As String = izabranaTabela
        lk.LK("", tabela, True)

        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("LK Yes", "from dataedit ", "")
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnNP_Click(sender As Object, e As EventArgs) Handles btnNP.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New FormNaprednaPretragaUnos(Me.tacv, Me.DBConnectionString, Me.m_rowIST, Me.ISTConnectionString, Me.txtInst, Me.txtpismo, Me.DSBrisanjeDEPO,
                                            Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik, panelmenucollapse)
        Me.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            Me.Show()
            'If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub ButtonUpitnik_Click(sender As Object, e As EventArgs) Handles ButtonUpitnik.Click
        Me.Cursor = Cursors.WaitCursor
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim zakljucanUnos As Integer = ProveraUnosLOCK(pomind)
        Me.Unos2(True, zakljucanUnos)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonNoviSlog_Click(sender As Object, e As EventArgs) Handles ButtonNoviSlog.Click
        Me.Cursor = Cursors.WaitCursor
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()

        Dim zakljucanUnos As Integer = ProveraUnosLOCK(pomind)
        If zakljucanUnos = 1 Then
            ''msg 64
            Dim msgtxt64 As String = getMessageText(dtMessages, "64", Me.jezik)
            ''msg 65
            Dim msgtxt65 As String = getMessageText(dtMessages, "65", Me.jezik)
            ISTMessageBox.Show(msgtxt64, msgtxt65, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Unos2(False, zakljucanUnos)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonBrisi_Click(sender As Object, e As EventArgs) Handles ButtonBrisi.Click
        Dim pomind As Integer = IzabranaTabelaIndikatorJe()
        Dim zakljucanUnos As Integer = ProveraUnosLOCK(pomind)
        If zakljucanUnos = 1 Then
            ''msg 65
            Dim msgtxt65 As String = getMessageText(dtMessages, "65", Me.jezik)
            ''msg 221
            Dim msgtxt221 As String = getMessageText(dtMessages, "221", Me.jezik)
            ISTMessageBox.Show(msgtxt221, msgtxt65, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Call BrisiSlog()
        End If
    End Sub

    Private Sub BtnEx_Click(sender As Object, e As EventArgs) Handles Btn_Excel.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim dgvs() As DataGridView = dajGRDsZaExport()
        Dim filePath As String = getFileNameForExport("file", ".xml")

        If Not dgvs Is Nothing AndAlso dgvs.Length > 0 Then
            Call ExportDataGridViewToXMLSpreadsheet2003(dgvs, filePath)
            Call OpenXmlSpreadsheet(filePath)
            If lokalno = False Then Call upisiULogFA("xls")
        Else
            ''msg 219
            Dim msgtxt219 As String = getMessageText(dtMessages, "219", Me.jezik)
            ISTMessageBox.Show(msgtxt219, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Function getFileNameForExport(ByVal ff As String, Optional ByVal ekst As String = "") As String
        Dim dateTimeString As String = DateTime.Now.ToString("yyyyMMdd_HHmmss")
        Dim vt As String = tacv.G.ToString.Trim & tacv.M.ToString.Trim.PadLeft(2, "0"c)
        Dim nname As String = sifist + "_" + vt.Trim + "_" + dateTimeString
        If ff = "file" Then
            Dim filePath As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)
            filePath = filePath + "\" + nname.Trim + ekst
            getFileNameForExport = filePath
        End If
        If ff = "folder" Then
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim folderPath As String = Path.Combine(desktopPath, nname)
            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
                getFileNameForExport = folderPath
            End If
        End If

    End Function
    Function dajGRDsZaExport() As DataGridView()
        Dim dgvs() As DataGridView = {}
        Dim ipp As Integer = -1
        For i As Integer = 0 To ComboBoxTabele.Items.Count - 1
            Dim ind As Integer = Array.IndexOf(sveTabele, ComboBoxTabele.Items(i).trim.toupper)
            If niz_dgv(ind).Rows.Count > 0 Then
                ipp = ipp + 1
                ReDim Preserve dgvs(ipp)
                dgvs(ipp) = niz_dgv(ind)
                'If dgvs(ipp).Columns.Contains("secondRowHeader") Then
                '    '?????   remove, visible nije OK, sve se odrazava na niz_dgv(ind)
                'End If
            End If
        Next
        Return dgvs
    End Function
    Public Sub OpenXmlSpreadsheet(filePath As String)
        Try
            ' Start Microsoft Excel and open the specified XML file.
            Process.Start(filePath)
        Catch ex As Exception
            ' Handle exceptions (Excel not installed, file not found, etc.)
            Console.WriteLine("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub Btn_XML_Click(sender As Object, e As EventArgs) Handles Btn_XML.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim dgvs() As DataGridView = dajGRDsZaExport()

        If dgvs Is Nothing OrElse dgvs.Length = 0 Then
            ''msg 219
            Dim msgtxt219 As String = getMessageText(dtMessages, "219", Me.jezik)
            ISTMessageBox.Show(msgtxt219, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        Dim folderPath As String = getFileNameForExport("folder")
        Dim ds As New DataSet("DataGridViewsDataSet")

        For Each dgv As DataGridView In dgvs
            If Not dgv.Rows.Count > 0 Then Continue For ' Skip any non-visible DataGridViews.
            ' Create a DataTable to hold the data for each DataGridView
            Dim table As New DataTable(dgv.Name)
            ' Add columns to the DataTable
            For i As Integer = 0 To dgv.Columns.Count - 1
                If dgv.Columns(i).Visible Then ' Add only visible columns.
                    table.Columns.Add(dgv.Columns(i).HeaderText, dgv.Columns(i).ValueType)
                End If
            Next
            ' Add rows to the DataTable
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    Dim dataRow As DataRow = table.NewRow()
                    For i As Integer = 0 To dgv.Columns.Count - 1
                        If dgv.Columns(i).Visible Then
                            dataRow(i) = If(row.Cells(i).Value IsNot Nothing, row.Cells(i).Value.ToString(), String.Empty)
                        End If
                    Next
                    table.Rows.Add(dataRow)
                End If
            Next
            ' Add the DataTable to the DataSet
            ds.Tables.Add(table)
            Dim validFileName As String = table.TableName.Trim + ".xml"
            Dim pfilePath As String = Path.Combine(folderPath, validFileName)
            table.WriteXml(pfilePath)
            Try
                System.Diagnostics.Process.Start("Notepad.Exe", pfilePath)
            Catch ex As System.Exception
                System.Diagnostics.Process.Start(pfilePath)
            End Try
        Next

        'DataSet.WriteXml(exportFilePath)'ako hocemo sve
        If lokalno = False Then Call upisiULogFA("xml")
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub
    Private Sub btn_JSON_Click(sender As Object, e As EventArgs) Handles btn_JSON.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim dgvs() As DataGridView = dajGRDsZaExport()

        If dgvs Is Nothing OrElse dgvs.Length = 0 Then
            ''msg 219
            Dim msgtxt219 As String = getMessageText(dtMessages, "219", Me.jezik)
            ISTMessageBox.Show(msgtxt219, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        Dim folderPath As String = getFileNameForExport("folder")
        Dim ds As New DataSet("DataGridViewsDataSet")

        For Each dgv As DataGridView In dgvs
            Dim rows As New List(Of Dictionary(Of String, Object))
            ' Add rows to the List.
            For Each row As DataGridViewRow In dgv.Rows
                If Not row.IsNewRow Then
                    Dim rowDict As New Dictionary(Of String, Object)
                    For Each column As DataGridViewColumn In dgv.Columns
                        rowDict.Add(column.HeaderText, If(row.Cells(column.Index).Value IsNot Nothing, row.Cells(column.Index).Value, Nothing))
                    Next
                    rows.Add(rowDict)
                End If
            Next
            ' Serialize to JSON using the JavaScriptSerializer.
            Dim serializer As New JavaScriptSerializer()
            Dim json As String = serializer.Serialize(rows)
            ' Create a valid file name from the DataGridView name.
            'Dim validFileName As String = String.Join("_", dgv.Name.Split(Path.GetInvalidFileNameChars())) + ".json"
            ' Write the JSON string to a file.
            'File.WriteAllText(Path.Combine(folderPath, validFileName), json)

            Dim validFileName As String = dgv.Name.Trim + ".json"
            Dim pfilePath As String = Path.Combine(folderPath, validFileName)
            IO.File.WriteAllText(Path.Combine(folderPath, validFileName), json)
            Try
                System.Diagnostics.Process.Start("Notepad.Exe", pfilePath)
            Catch ex As System.Exception
                System.Diagnostics.Process.Start(pfilePath)
            End Try
        Next

        If lokalno = False Then Call upisiULogFA("json")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ButtonIzborSlogova_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonLK.MouseDown, ButtonUpitnik.MouseDown, ButtonNoviSlog.MouseDown, ButtonIzborSlogova.MouseDown, ButtonIzborKolona.MouseDown, ButtonBrisi.MouseDown, ButtonAzurirajSlogUDGV.MouseDown, btnNP.MouseDown, Btn_Excel.MouseDown, Btn_XML.MouseDown, btn_SPSS.MouseDown, btn_JSON.MouseDown
        ActivateButton(sender, ActivateButtonColor)
    End Sub
    'Private Sub btnCerrar_Click(sender As Object, e As EventArgs)

    'End Sub
    'mmmmmm
    Private Sub dg_CellMouseDown(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
        Dim dgv As DataGridView = CType(sender, DataGridView)
        Dim ind As Integer = Array.IndexOf(niz_dgv, dgv)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dt As DataTable = dgv.DataSource
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim kol As String = dt.Columns(e.ColumnIndex).ColumnName

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
                If tip = "S" Then dgv.ContextMenuStrip = mnuColumnText : mnuColumnText.AccessibleName = kol : mnuColumnText.Tag = ind
                If tip = "N" Then dgv.ContextMenuStrip = mnuColumnNumber : mnuColumnNumber.AccessibleName = kol : mnuColumnNumber.Tag = ind
            Else
                Exit Sub
            End If
        Else
            dgv.ContextMenuStrip = Nothing
        End If

    End Sub

    Private Sub mnuColumnText_ItemClicked(ByVal sender As System.Object, ByVal e As ToolStripItemClickedEventArgs) Handles mnuColumnText.ItemClicked

        Dim ind As Integer = mnuColumnText.Tag
        Dim dgv As DataGridView = niz_dgv(ind)
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuColumnText.AccessibleName

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
                Call AF(niz_fbuf(ind), True) 'Call funfilterDGV(ind)
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
        Dim ind As Integer = mnuColumnNumber.Tag
        Dim dgv As DataGridView = niz_dgv(ind)
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuColumnNumber.AccessibleName

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
                Call AF(niz_fbuf(ind), True) ' Call funfilterDGV(ind)
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

    'Sub funfilterDGV(ByVal ind As Integer)

    '    Dim dgv As DataGridView = niz_dgv(ind)
    '    Call ApplyFilter(ind, True)
    '    LabelTotalCount.Text = "Rows count: " + CStr(dgv.Rows.Count)

    'End Sub

    Sub multicolumnsort(ByVal dgv As DataGridView)
        If Not dgv Is Nothing Then

            Dim dgvC As String = ""
            For Each dgvCol As DataGridViewColumn In dgv.Columns
                dgvC = dgvC + dgvCol.HeaderText + "$"
            Next

            Dim fsort As New IstrazivanjaUnos.FormSort(Me, dgvC)
            Dim kako As String = ""
            Dim strOrderby As String = ""
            If fsort.ShowDialog() = DialogResult.OK Then
                strOrderby = fsort.SortOrder
                Dim dt As System.Data.DataTable
                dt = dgv.DataSource
                Dim dv As New DataView(dt)
                dv.Sort = strOrderby
                dt = dv.ToTable()
                Dim npk() As DataColumn = dv.Table.PrimaryKey
                For i As Integer = 0 To npk.GetUpperBound(0)
                    Dim pk As DataColumn = dt.Columns.Item(npk(i).ColumnName)
                    If Not pk Is Nothing Then
                        pk.Unique = True
                        pk.AllowDBNull = False
                        dt.PrimaryKey = New DataColumn() {pk}
                    End If
                Next
                dgv.DataSource = dt
            End If
        End If
    End Sub

    Sub findDGV(ByVal dgv As DataGridView, ByVal k As String)
        Dim ffind As New IstrazivanjaUnos.FormFind(Me, dgv, k, dgv.Right, dgv.Top)
        ffind.Show()
    End Sub

    Sub fequals(ByVal dgv As DataGridView, ByVal k As String, ByVal c As String, ByVal tip As String)
        If Not dgv Is Nothing Then

            Dim dt As New System.Data.DataTable

            Dim dv As New DataView(dgv.DataSource)

            Dim uslov As String = ""
            If tip = "S" Then uslov = k + " = '" + c + "'"
            If tip = "N" Then uslov = k + " = " + c + ""

            dv.RowFilter = uslov
            dt = dv.ToTable()

            Dim npk() As DataColumn = dv.Table.PrimaryKey
            Call addPKtoDT(npk, dt)

            dgv.DataSource = dt

        End If
    End Sub

    Sub fdnequals(ByVal dg As DataGridView, ByVal k As String, ByVal c As String, ByVal tip As String)
        If Not dg Is Nothing Then

            Dim dt As New System.Data.DataTable
            Dim dv As New DataView(dg.DataSource)

            Dim uslov As String = ""
            If tip = "S" Then uslov = k + " <> '" + c + "'"
            If tip = "N" Then uslov = k + " <> " + c + ""

            dv.RowFilter = uslov
            dt = dv.ToTable()

            Dim npk() As DataColumn = dv.Table.PrimaryKey
            Call addPKtoDT(npk, dt)

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
                Dim dt As New System.Data.DataTable
                Dim dv As New DataView(dg.DataSource)
                If uslov <> "" Then
                    If dv.Table.Columns(k).DataType.Name = "String" OrElse dv.Table.Columns(k).DataType.Name = "Char" Then
                        dv.RowFilter = k + uslov
                        dt = dv.ToTable()
                        Dim npk() As DataColumn = dv.Table.PrimaryKey
                        Call addPKtoDT(npk, dt)
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
                Dim dt As New System.Data.DataTable
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
                        Dim npk() As DataColumn = dv.Table.PrimaryKey
                        Call addPKtoDT(npk, dt)
                        dg.DataSource = dt

                    End If

                End If
                If dg.Name.Trim.ToUpper = "DGISTTABLES" Then dg.AllowUserToAddRows = False

            End If
        End If
    End Sub
    'mmmmmm
End Class
Public NotInheritable Class BufferMethod
    Public Shared Sub DoubleBuffered(dgView As DataGridView, Setting As Boolean)
        Dim dgvType As Type = dgView.[GetType]()
        Dim propInfo As PropertyInfo = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        propInfo.SetValue(dgView, Setting, Nothing)
    End Sub
End Class

Public Class PrevediAzur

    Public Function PrevediF(ByVal izraz As String) As String
        Dim ime As String
        Dim param As String
        Dim prvi, ostatak As String
        Dim prvaz, drugaz, taraba As Integer
        If Trim(izraz) = "" Then
            PrevediF = ""
        ElseIf InStr(1, izraz, "#") = 0 Then
            PrevediF = izraz
        Else
            taraba = InStr(1, izraz, "#")
            prvaz = InStr(1, izraz, "{")
            drugaz = ZavrZnak(Mid(izraz, prvaz + 1), "{", "}")
            If taraba = 1 Then prvi = "" Else prvi = Mid(izraz, 1, taraba - 1)
            'prvi = IIf(taraba = 1, "", izraz.Substring(0, taraba - 1))
            If prvaz + drugaz + 1 >= Len(izraz) Then ostatak = "" Else ostatak = Mid(izraz, prvaz + drugaz + 1)
            'ostatak = IIf(prvaz + drugaz + 1 >= Len(izraz), "", Mid(izraz, prvaz + drugaz + 1))

            ime = UCase$(Mid(izraz, taraba + 1, prvaz - taraba - 1))
            param = Mid(izraz, prvaz + 1, drugaz - 1)

            PrevediF = prvi & raztarabi(ime, param) & PrevediF(ostatak)
        End If
    End Function

    Private Function ZavrZnak(ByVal str As String, ByVal ZnakP As String, ByVal ZnakK As String) As Integer
        Dim pom As Integer
        Dim i As Integer
        i = 1
        pom = 1
        While pom > 0
            If Mid(str, i, Len(ZnakP)) = ZnakP Then pom = pom + 1
            If Mid(str, i, Len(ZnakP)) = ZnakK Then pom = pom - 1
            i = i + 1
        End While
        ZavrZnak = i - 1
    End Function

    Private Function raztarabi(ByVal uime As String, ByVal uparam As String) As String
        raztarabi = ""
        Dim ime As String
        Dim param As String
        ime = Trim(uime)
        param = Trim(uparam)
        If Trim(ime) = "" Then
            raztarabi = PrevediF(param)
        Else
            If InStr(1, param, "#") > 0 Then
                Dim trb, pz, zz As Integer
                trb = InStr(1, param, "#")
                pz = InStr(1, param, "{")
                zz = ZavrZnak(Mid(param, pz + 1), "{", "}")
                Dim prvi As String
                Dim tarabni As String
                Dim ostatak As String
                prvi = Trim(Mid(param, 1, trb - 1))
                tarabni = Trim(Mid(param, trb, pz - trb + zz + 1))
                ostatak = Trim(Mid(param, pz + zz + 1))
                raztarabi = raztarabi(ime, prvi & PrevediF(tarabni) & PrevediF(ostatak))
            Else ' bez ugnjezdenih
                'raztarabi = prevedi_1(ime, param)
            End If ' bez ugnjezdenih
        End If ' patologija, prazni
    End Function

End Class
Public Class TcolInfo
    Inherits FormTemplate
    Public dc As System.Windows.Forms.DataGridViewCell
    Public dt As System.Data.DataTable
    Public ecol() As System.Data.DataColumn = {}
    Public ucol() As System.Data.DataColumn = {}
    Public chksinhr As System.Windows.Forms.CheckBox
    Public WithEvents dg_greskeZaSlog As DataGridView
    Public dt_greskeZaSlog As DatasetGreske.Greske_za_slogDataTable
    Public dg_greskeZaPrikazaneSlogove As DataGridView
    Public dt_greskeZaPrikazaneSlogove As DatasetGreske.Greske_za_prikazane_slogoveDataTable
    Public dg_greskeZaTabelu As DataGridView
    Public LKizvestaj As LKizv
    Public mgist As DataGridView
    Public mviscol() As System.Data.DataColumn = {}
    Public pamtics() As String = {}
    Public DBConnectionString As String
    Public mtp As DatasetIstrazivanja.ISTPOLJADataTable
    Public mtlk As DatasetIstrazivanja.ISTLKDataTable
    Public mdsgre As New DatasetGreske
    Public tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Public cs() As System.Data.DataColumn
    Public Sub ggres(ByVal tpgrsl As System.Windows.Forms.TabPage, ByVal tpgrprikaz As System.Windows.Forms.TabPage, ByVal tpagcela As System.Windows.Forms.TabPage)


        'Call srediGridView(dg_greskeZaSlog, , 20)
        'Me.dg_greskeZaSlog.Dock = DockStyle.Fill

        'Call srediGridView(dg_greskeZaPrikazaneSlogove, , 20)
        'Me.dg_greskeZaPrikazaneSlogove.Dock = DockStyle.Fill

        'Call srediGridView(dg_greskeZaTabelu, , 20)
        'Me.dg_greskeZaTabelu.Dock = DockStyle.Fill
    End Sub

    Public Sub greskeSetVisible(ByVal b As Boolean)
        Me.dg_greskeZaSlog.Visible = b
        Me.dg_greskeZaPrikazaneSlogove.Visible = b
        Me.dg_greskeZaTabelu.Visible = b
    End Sub

    Public Function exprset(ByVal ri As System.Data.DataRow, Optional ByVal FizBaza As String = "") As String
        Dim sql As String = ""
        For Each col As System.Data.DataColumn In Me.ucol
            If col.Expression = "" Then
                If Not Object.Equals(ri.Item(col.ColumnName, System.Data.DataRowVersion.Original), ri.Item(col.ColumnName, System.Data.DataRowVersion.Current)) Then
                    If sql <> "" Then sql = sql + ","
                    sql = sql + UzmiSet(ri, col, True, FizBaza)
                End If
            End If
        Next
        Return sql
    End Function

    Public Function UzmiSet(ByVal r As System.Data.DataRow, ByVal col As System.Data.DataColumn, ByVal b As Boolean, Optional ByVal FizBaza As String = "") As String
        Dim sql As String = col.ColumnName
        If r.IsNull(col.ColumnName) Then
            If b Then
                sql = sql + "="
            Else
                sql = sql + " is "
            End If
            sql = sql + "null"
        Else
            sql = sql + "="
            Dim val As Object = r.ItemArray(col.Ordinal)
            If col.DataType Is GetType(String) Then
                If FizBaza = "SS" Then
                    sql = sql + "N'" + CStr(val) + "'"
                Else
                    sql = sql + "'" + CStr(val) + "'"
                End If
            ElseIf col.DataType Is GetType(Boolean) Then
                If CBool(val) Then
                    sql = sql + "1"
                Else
                    sql = sql + "0"
                End If
            ElseIf col.DataType Is GetType(Date) Then
                sql = sql + "'" + CStr(val) + "'"
            Else
                sql = sql + CStr(val)
            End If
        End If
        Return sql
    End Function

    Public Sub daj_dt_greskeZaTabelu()
        Try
            Me.LKizvestaj.LK2("", Me.dt.TableName)
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at LK2 - daj_dt_greskeZaTabelu" + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public Sub daj_dt_greskezaPrikazaneSlogove(ByVal ti As TcolInfo)
        Me.dt_greskeZaPrikazaneSlogove.Clear()
        Me.dt_greskeZaPrikazaneSlogove.AcceptChanges()

        Dim dv_co As New DataView(ti.dt)

        If Not dv_co Is Nothing Then
            Me.dt_greskeZaPrikazaneSlogove.SlogovaColumn.ReadOnly = False
            For Each rv As System.Data.DataRowView In dv_co
                For Each col As System.Data.DataColumn In Me.ecol
                    If Not rv.Row.IsNull(col.ColumnName) Then
                        Dim val As Integer = CInt(rv.Row.Item(col.ColumnName))
                        If val <> 0 Then
                            Do
                                For Each w As DatasetGreske.Greske_za_prikazane_slogoveRow In Me.mdsgre.Greske_za_prikazane_slogove.Rows
                                    If w.RbrGreske = col.ColumnName Then
                                        w.Slogova = w.Slogova + 1
                                        Exit Do
                                    End If
                                Next
                                Dim l As DatasetIstrazivanja.ISTLKRow
                                l = Me.mtlk.FindBySIFISTTABELARbrGreske(CType(Me.mtp.Rows(0), DatasetIstrazivanja.ISTPOLJARow).SIFIST, rv.Row.Table.ToString, col.ColumnName)
                                If l.Item("uslov").GetType Is GetType(System.DBNull) OrElse l.USLOV.Trim = "" OrElse l.USLOV.Trim.ToUpper.IndexOf("LKVELIKA") >= 0 OrElse l.USLOV.Trim.ToUpper.IndexOf("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                                    Dim ng As String = ""
                                    If l.IsNazivGreskeNull Then
                                        ng = ""
                                    Else
                                        ng = l.NazivGreske
                                    End If
                                    Me.mdsgre.Greske_za_prikazane_slogove.AddGreske_za_prikazane_slogoveRow(col.ColumnName, 1, ZameniGGGMMMAzur(l.GRESKA), ng)
                                End If
                            Loop While False
                        End If
                    End If
                Next
            Next
            Me.dt_greskeZaPrikazaneSlogove.SlogovaColumn.ReadOnly = True
        End If
        Me.dt_greskeZaPrikazaneSlogove.AcceptChanges()

    End Sub

    Public Sub daj_dt_greskeZaSlog(ByVal rv As System.Data.DataRow)

        If rv Is Nothing Then Return
        Me.dt_greskeZaSlog.Clear()
        Me.dt_greskeZaSlog.AcceptChanges()
        Dim sifIST As String = CType(Me.mtp.Rows(0), DatasetIstrazivanja.ISTPOLJARow).SIFIST
        Dim b As Boolean = False
        Dim col As System.Data.DataColumn
        For Each col In Me.ecol
            If Not rv.IsNull(col.ColumnName) Then
                Dim val As String = CStr(rv.Item(col.ColumnName)).Trim.ToLower
                If val <> "" AndAlso (val = "true" OrElse (val <> "false" AndAlso CInt(val) > 0)) Then
                    b = True
                    Dim l As DatasetIstrazivanja.ISTLKRow
                    l = Me.mtlk.FindBySIFISTTABELARbrGreske(sifIST, rv.Table.ToString, col.ColumnName)
                    If l.Item("uslov").GetType Is GetType(System.DBNull) OrElse l.USLOV.Trim = "" OrElse l.USLOV.Trim.ToUpper.IndexOf("LKVELIKA") >= 0 OrElse l.USLOV.Trim.ToUpper.IndexOf("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                        Dim ng As String
                        If l.IsNazivGreskeNull Then
                            ng = ""
                        Else
                            ng = l.NazivGreske
                        End If
                        Me.dt_greskeZaSlog.AddGreske_za_slogRow(col.ColumnName, ZameniGGGMMMAzur(l.GRESKA), ng)
                    End If
                End If
            End If
        Next
        Me.dt_greskeZaSlog.AcceptChanges()

    End Sub

    Dim jezik As String
    Dim txtmode As String = ""
    Public Sub New(ByVal tn As String, ByVal DBConnectionString As String, ByVal rb As DatasetIstrazivanja.ISTBAZERow,
                    ByVal l As DatasetIstrazivanja.ISTLKDataTable,
                    ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable,
                    ByVal gi As DataGridView, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal tpagslog As System.Windows.Forms.TabPage,
                    ByVal tpagprikaz As System.Windows.Forms.TabPage,
                    ByVal tpagcelatab As System.Windows.Forms.TabPage,
                    ByVal chksinh As System.Windows.Forms.CheckBox,
                    ByVal jezik As String, ByVal nogridediting As Boolean, ByVal imapodT As Boolean, ByVal imaNadT As Boolean, Optional ByVal txtmode As String = "")

        Dim pp() As String
        Dim prefixx As String = "dbo"
        Dim tabbb As String = tn
        If tabbb.IndexOf(".") > 0 Then
            pp = tabbb.Split(CType(".", Char()))
            prefixx = pp(0)
            tabbb = pp(1)
        End If

        Me.jezik = jezik
        Me.txtmode = txtmode
        Me.DBConnectionString = DBConnectionString
        Me.tacv = vt
        Me.chksinhr = chksinh
        Me.dt = New System.Data.DataTable(tn)
        Me.dt.TableName = tabbb
        Me.dt.Prefix = prefixx
        Me.mtp = tp
        Me.mtlk = l
        Me.mgist = gi

        Dim secondRowheader As String = ""
        If imapodT Then secondRowheader = "N'' as secondRowHeader,"
        If imaNadT Then secondRowheader = "N'' as secondRowHeader,"
        Dim sql As String = "select " + secondRowheader + sselIST(tn, l, tp) + nvrd + " from "

        Dim sqlPY As String = sselISTPY(tn, l, tp, 2)
        If sqlPY <> "" Then sqlPY = "," + sqlPY

        Dim ttn As String = ""
        ttn = prefixx + "." + tabbb
        sql = sql + "( select * from " + ttn + " where 1=0)" + " d  "

        Dim ImaG As Boolean = False
        Dim ImaM As Boolean = False
        Dim ImaGM As Boolean = False
        Dim ImaGE As Boolean = False
        Dim ImaME As Boolean = False
        Dim ImaGME As Boolean = False

        Dim kljNiz() As String = {}
        For Each r As DatasetIstrazivanja.ISTPOLJARow In mtp
            If r.TABELA.Trim.ToUpper = tn.Trim.ToUpper Then
                If Not r.IsKLJUCNull AndAlso r.KLJUC.Trim.ToUpper = "P" Then
                    If r.POLJE.Trim.ToUpper <> "GOD" AndAlso r.POLJE.Trim.ToUpper <> "MES" _
                           AndAlso r.POLJE.Trim.ToUpper <> "ISTYEAR" AndAlso r.POLJE.Trim.ToUpper <> "ISTMONTH" Then
                        ReDim Preserve kljNiz(kljNiz.GetUpperBound(0) + 1)
                        kljNiz(kljNiz.GetUpperBound(0)) = r.POLJE.Trim.ToUpper
                    ElseIf r.POLJE.Trim.ToUpper = "GOD" Then
                        ImaG = True
                    ElseIf r.POLJE.Trim.ToUpper = "ISTYEAR" Then
                        ImaGE = True
                    ElseIf r.POLJE.Trim.ToUpper = "MES" Then
                        ImaM = True
                    ElseIf r.POLJE.Trim.ToUpper = "ISTMONTH" Then
                        ImaME = True
                    End If
                End If
            End If
        Next
        ImaGM = ImaG And ImaM
        ImaGME = ImaGE And ImaME

        If ImaG And ImaGM = False Then
            sql = "Select d.*" + sqlPY + nvrd + " from ( " + sql + nvrd + " where d.god='" + CStr(Me.tacv.G).Trim + "') d "
            If sqlPY <> "" Then sql = sql + dajGM1(kljNiz, tn, "god")
        End If
        If ImaGE And ImaGME = False Then
            sql = "select d.*" + sqlPY + nvrd + " from ( " + sql + nvrd + " where d.ISTYEAR='" + CStr(Me.tacv.G).Trim + "') d "
            If sqlPY <> "" Then sql = sql + dajGM1E(kljNiz, tn, "ISTYEAR")
        End If

        If ImaGM Then
            sql = "select d.*" + sqlPY + nvrd + " from ( " + sql + nvrd + " where d.god='" + CStr(Me.tacv.G).Trim + "' and d.mes='" + CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) + "') d "
            If sqlPY <> "" Then sql = sql + dajGM1(kljNiz, tn, "god", "mes")
        End If
        If ImaGME Then
            sql = "select d.*" + sqlPY + nvrd + " from ( " + sql + nvrd + " where d.ISTYEAR='" + CStr(Me.tacv.G).Trim + "' and d.ISTMONTH='" + CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) + "') d "
            If sqlPY <> "" Then sql = sql + dajGM1E(kljNiz, tn, "ISTYEAR", "ISTMONTH")
        End If

        sql = sql + " where 1=0"

        Try
            Me.dt = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
            Me.dt.TableName = tabbb
            Me.dt.Prefix = prefixx
        Catch ex As System.Exception
            Dim poruka As String = ""
            If ex.Message.Trim.ToUpper.IndexOf("INVALID COLUMN NAME") >= 0 Then
                poruka = nvrd + nvrd + "Check virtuel fields with this column name."
            End If
            ISTMessageBox.Show(ex.Message + poruka)
            Exit Sub
        End Try

        Dim acs() As System.Data.DataColumn = {}
        Me.cs = dajCS(tn, tp)
        Call appendTS(tn, rb, l, cs, gi, tpagslog, tpagprikaz, tpagcelatab, nogridediting)

    End Sub
    Private Function sselIST(ByVal tn As String, ByVal l As DatasetIstrazivanja.ISTLKDataTable, ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable) As String

        Dim x As String = sselISTPY(tn, l, tp, 1)            '

        For Each rp As DatasetIstrazivanja.ISTLKRow In l.Rows
            If rp.TABELA.Trim.ToUpper = tn.Trim.ToUpper Then
                If x <> "" Then x = x & ","
                x = x & "d." + "[" + rp.RbrGreske.Trim + "]"
            End If
        Next

        If x <> "" Then
            Dim sql As String = "select * from " & Me.dt.Prefix + "." + Me.dt.TableName & " where 2=3 "

            Dim pomdt2 As New System.Data.DataTable
            pomdt2 = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

            If Not (pomdt2.Columns("LK")) Is Nothing Then
                If x.Trim.ToUpper.IndexOf("D.[LK]") < 0 AndAlso x.Trim.ToUpper.IndexOf("D.LK") < 0 AndAlso x.Trim.ToUpper.IndexOf("LK") < 0 Then x = x & ",d.[LK] "
            End If
            If Not (pomdt2.Columns("INDGR")) Is Nothing Then
                If x.Trim.ToUpper.IndexOf("D.[INDGR]") < 0 AndAlso x.Trim.ToUpper.IndexOf("D.INDGR") < 0 AndAlso x.Trim.ToUpper.IndexOf("INDGR") < 0 Then x = x & ",d.[INDGR] "
            End If
            If Not (pomdt2.Columns("KO_UPDATE")) Is Nothing Then
                If x.Trim.ToUpper.IndexOf("D.[KO_UPDATE]") < 0 AndAlso x.Trim.ToUpper.IndexOf("D.KO_UPDATE") < 0 AndAlso x.Trim.ToUpper.IndexOf("KO_UPDATE") < 0 Then x = x & ",d.[KO_UPDATE] "
            End If
            If Not (pomdt2.Columns("DATUM_UPDATE")) Is Nothing Then
                If x.Trim.ToUpper.IndexOf("D.[DATUM_UPDATE]") < 0 AndAlso x.Trim.ToUpper.IndexOf("D.DATUM_UPDATE") < 0 AndAlso x.Trim.ToUpper.IndexOf("DATUM_UPDATE") < 0 Then x = x & ",d.[DATUM_UPDATE] "
            End If
            If Not (pomdt2.Columns("USER_UPDATE")) Is Nothing Then
                If x.Trim.ToUpper.IndexOf("D.[USER_UPDATE]") < 0 AndAlso x.Trim.ToUpper.IndexOf("D.USER_UPDATE") < 0 AndAlso x.Trim.ToUpper.IndexOf("USER_UPDATE") < 0 Then x = x & ",d.[USER_UPDATE] "
            End If
            If Not (pomdt2.Columns("DATE_UPDATE")) Is Nothing Then
                If x.Trim.ToUpper.IndexOf("D.[DATE_UPDATE]") < 0 AndAlso x.Trim.ToUpper.IndexOf("D.DATE_UPDATE") < 0 AndAlso x.Trim.ToUpper.IndexOf("DATE_UPDATE") < 0 Then x = x & ",d.[DATE_UPDATE] "
            End If
        End If
        Return x

    End Function
    Private Function sselISTPY(ByVal tn As String, ByVal l As DatasetIstrazivanja.ISTLKDataTable, ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable, ByVal kojaf As Integer) As String
        Dim brojac As Integer = 0
        Dim notokDisplay As Boolean = False
        Dim x As String = ""
        For Each rp As DatasetIstrazivanja.ISTPOLJARow In tp.Rows
            If rp.TABELA.Trim.ToUpper = tn.Trim.ToUpper Then
                Dim ok As Boolean = True
                Dim rpTRT As String = ""
                If rp.IsIzrazNull = False Then
                    rpTRT = rp.Izraz.Trim.ToUpper
                    If rpTRT.Trim.ToUpper.IndexOf("FCALCULATEAGE") >= 0 OrElse rpTRT.Trim.ToUpper.IndexOf("#FP{") >= 0 OrElse
                       rpTRT.Trim.ToUpper.IndexOf(":S") >= 0 OrElse rpTRT.Trim.ToUpper.IndexOf("DATAGRIDVIEW") >= 0 OrElse
                       rpTRT.Trim.ToUpper.IndexOf("AUTOCOMPLETE") >= 0 OrElse rpTRT.Trim.ToUpper.IndexOf("ENCRYPT") >= 0 OrElse
                        (rpTRT.Trim.ToUpper.IndexOf("RADIOBUTTON") < 0 AndAlso rpTRT.Trim.ToUpper.IndexOf("BUTTON") >= 0) OrElse
                        rpTRT.Trim.ToUpper.IndexOf("ISTLBL") >= 0 Then ok = False

                    rpTRT = zameniRPIZRAZ(rpTRT)
                    If rpTRT.IndexOf("'") = 0 Then
                        ok = False
                    Else
                        rp.Izraz = ZameniGGGMMMAzur(rp.Izraz)
                        rp.Izraz = zameniCAPIUSER(rp.Izraz, txtmode, "", "")
                    End If
                End If

                If ok = True Then
                    'zamena GGGMMM
                    rpTRT = ZameniGGGMMMAzur(rpTRT)
                    rpTRT = zameniCAPIUSER(rpTRT, txtmode, "", "")
                    Dim gp As String = ""
                    If kojaf = 1 Then
                        gp = getPolje1(rp.IsIzrazNull, rp.POLJE, rpTRT)
                    Else
                        gp = getPolje2(rp.IsIzrazNull, rp.POLJE, rpTRT)
                    End If

                    If gp <> "" Then
                        brojac = brojac + 1
                        If brojac < 1024 Then
                            x = x & gp & "," & nvrd
                        Else
                            notokDisplay = True
                            Exit For
                        End If
                    End If
                End If
            End If
        Next

        If notokDisplay = True Then ISTMessageBox.Show("Column count exceed 1024 columns." + nvrd + nvrd + "Only first 1024 columns will be diplayed.")

        If x <> "" Then
            x = x.Trim + "$$$"
            x = x.Replace(",$$$", "")
        End If

        Return x

    End Function
    Private Function ZameniGGGMMMAzur(ByVal str As String) As String
        Dim sql As String = ""
        'zamena GGG,MMM
        sql = str
        sql = strrpl(sql, "{SIFIST}", "'" + Me.mtp.Rows(0).Item("sifist").ToString + "'")
        sql = strrpl(sql, "{APPCODE}", "'" + Me.mtp.Rows(0).Item("sifist").ToString + "'")
        sql = strrpl(sql, "{GGG}", "'" + Me.tacv.G.ToString + "'")
        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", Me.tacv.M) + "'")
        sql = strrpl(sql, "{YYY}", "'" + Me.tacv.G.ToString + "'")

        sql = GGMMGoreDole(sql, Me.tacv.G, Me.tacv.M)
        sql = strrpl(sql, "VRTACKA", Me.tacv.vtwhere(""))
        sql = strrpl(sql, "GGG", Me.tacv.GWhere(""))
        sql = strrpl(sql, "MMM", Me.tacv.mWhere(""))
        sql = strrpl(sql, "YYY", Me.tacv.YWhere(""))

        sql = sql.Replace(ChrW(26), "")
        str = sql
        Return str
    End Function

    Function getPolje1(ByVal rpIsIzrazNull As Boolean, ByVal rppolje As String, ByVal rptrt As String) As String
        Dim x As String = ""
        If rpIsIzrazNull = True OrElse rptrt = "" _
                 OrElse InStr(rptrt.ToUpper, "LINKLABEL") > 0 _
                 OrElse InStr(rptrt.ToUpper, "DATAGRIDVIEW") > 0 _
                 OrElse InStr(rptrt.ToUpper, "AUTOCOMPLETE") > 0 _
                 OrElse InStr(rptrt.ToUpper, "ENCRYPT") > 0 _
                 OrElse InStr(rptrt.ToUpper, "CHECKBOX") > 0 _
                 OrElse InStr(rptrt.ToUpper, "RADIOBUTTON") > 0 _
                 OrElse InStr(rptrt.ToUpper, "DATETIMEPICKER") > 0 _
                 OrElse InStr(rptrt.ToUpper, "CBO{") > 0 _
                 OrElse InStr(rptrt.ToUpper, "CBW{") > 0 Then
            x = "d.[" & rppolje.Trim & "]"
        Else

            ''''
            'nema glava, head, #FP, fcalculateage
            If InStr(rptrt.ToUpper, "GLAVA.") = 0 AndAlso InStr(rptrt.ToUpper, "HEAD.") = 0 AndAlso
                    InStr(rptrt.ToUpper, "#FP{") = 0 AndAlso InStr(rptrt.ToUpper, "FCALCULATEAGE") = 0 AndAlso rptrt.Substring(0, 1) <> "{" Then
                If InStr(rptrt, "#") > 0 AndAlso
                        InStr(rptrt.ToUpper, "PG.") <= 0 AndAlso InStr(rptrt.ToUpper, "PY.") <= 0 AndAlso
                        InStr(rptrt.ToUpper, "PM.") <= 0 AndAlso InStr(rptrt.ToUpper, "PMONTH.") <= 0 AndAlso
                        InStr(rptrt.ToUpper, "PK.") <= 0 AndAlso InStr(rptrt.ToUpper, "PQ.") <= 0 AndAlso
                        InStr(rptrt.ToUpper, "PP.") <= 0 AndAlso InStr(rptrt.ToUpper, "PH.") <= 0 Then
                    Dim trt As String = Replace(rptrt.ToUpper, "#", "")
                    trt = Replace(trt, "{", "")
                    trt = Replace(trt, ";}", "")
                    trt = Replace(trt, "; }", "")
                    trt = Replace(trt, "}", "")
                    If InStr(trt, ":S") = 0 Then
                        If InStr(trt, ":") <> 0 Then trt = trt.Substring(0, trt.IndexOf(":"))
                        If x <> "" Then x = x & ","
                        x = x & "( " & trt & ") as [" & rppolje.Trim & "]"
                    End If
                ElseIf InStr(rptrt.ToUpper, "PG.") > 0 OrElse InStr(rptrt.ToUpper, "PY.") > 0 OrElse
                            InStr(rptrt.ToUpper, "PM.") > 0 OrElse InStr(rptrt.ToUpper, "PMONTH.") > 0 OrElse
                            InStr(rptrt.ToUpper, "PK.") > 0 OrElse InStr(rptrt.ToUpper, "PQ.") > 0 OrElse
                            InStr(rptrt.ToUpper, "PP.") > 0 OrElse InStr(rptrt.ToUpper, "PH.") > 0 Then
                    'nista, bacamo gore
                Else
                    If rptrt.Trim.IndexOf("'") = 0 Then rptrt = "N" + rptrt
                    x = "( " & rptrt & ") as [" & rppolje.Trim & "]"
                End If
            End If  'nema u izrazu GLAVA., CBO, ostalo.....
        End If

        getPolje1 = x
    End Function

    Function getPolje2(ByVal rpIsIzrazNull As Boolean, ByVal rppolje As String, ByVal rptrt As String) As String
        Dim x As String = ""
        If rpIsIzrazNull OrElse rptrt = "" _
                    OrElse InStr(rptrt.ToUpper, "LINKLABEL") > 0 _
             OrElse InStr(rptrt.ToUpper, "DATAGRIDVIEW") > 0 _
             OrElse InStr(rptrt.ToUpper, "AUTOCOMPLETE") > 0 _
             OrElse InStr(rptrt.ToUpper, "ENCRYPT") > 0 _
                    OrElse InStr(rptrt.ToUpper, "CHECKBOX") > 0 _
                    OrElse InStr(rptrt.ToUpper, "RADIOBUTTON") > 0 _
                    OrElse InStr(rptrt.ToUpper, "DATETIMEPICKER") > 0 _
                    OrElse InStr(rptrt.ToUpper, "CBO{") > 0 _
                    OrElse InStr(rptrt.ToUpper, "CBW{") > 0 Then
        Else
            If InStr(rptrt.ToUpper, "GLAVA.") = 0 AndAlso InStr(rptrt.ToUpper, "HEAD.") = 0 AndAlso
                            InStr(rptrt.ToUpper, "#FP{") = 0 AndAlso InStr(rptrt.ToUpper, "FCALCULATEAGE") = 0 AndAlso rptrt.Substring(0, 1) <> "{" Then
                If InStr(rptrt, "#") > 0 AndAlso InStr(rptrt.ToUpper, "PG.") <= 0 AndAlso InStr(rptrt.ToUpper, "PY.") <= 0 AndAlso
                                 InStr(rptrt.ToUpper, "PM.") <= 0 AndAlso InStr(rptrt.ToUpper, "PMONTH.") <= 0 AndAlso
                                  InStr(rptrt.ToUpper, "PK.") <= 0 AndAlso InStr(rptrt.ToUpper, "PQ.") <= 0 AndAlso
                                   InStr(rptrt.ToUpper, "PP.") <= 0 AndAlso InStr(rptrt.ToUpper, "PH.") <= 0 Then
                ElseIf InStr(rptrt.ToUpper, "PG.") > 0 OrElse InStr(rptrt.ToUpper, "PY.") > 0 OrElse
                                 InStr(rptrt.ToUpper, "PM.") > 0 OrElse InStr(rptrt.ToUpper, "PMONTH.") > 0 OrElse
                                  InStr(rptrt.ToUpper, "PK.") > 0 OrElse InStr(rptrt.ToUpper, "PQ.") > 0 OrElse
                                   InStr(rptrt.ToUpper, "PP.") > 0 OrElse InStr(rptrt.ToUpper, "PH.") > 0 Then
                    ' bacamo gore
                    If InStr(rptrt, "#") > 0 Then
                        Dim trt As String = Replace(rptrt.ToUpper, "#", "")
                        trt = Replace(trt, "{", "")
                        trt = Replace(trt, ";}", "")
                        trt = Replace(trt, "; }", "")
                        trt = Replace(trt, "}", "")
                        If InStr(trt, ":S") = 0 Then
                            If InStr(trt, ":") <> 0 Then trt = trt.Substring(0, trt.IndexOf(":"))
                            If x <> "" Then x = x & ","
                            x = x & "( " & trt & ") as [" & rppolje.Trim & "]"
                        End If
                    Else
                        If x <> "" Then x = x & ","
                        If rptrt.Trim.IndexOf("'") = 0 Then rptrt = "N" + rptrt
                        x = x & "( " & rptrt & ") as [" & rppolje.Trim & "]"
                    End If
                End If
            End If  'nema u izrazu GLAVA., CBO, ostalo.....
        End If

        getPolje2 = x
    End Function
    Function dajGM1(ByVal kljNiz() As String, ByVal tn As String, ByVal ggg As String, Optional ByVal mmm As String = "", Optional ByVal ssm As String = "") As String

        Dim sql As String = ""
        Dim GG1 As String = CStr(Me.tacv.G - 1)
        Dim sfwP As String
        Dim MM1 As String
        Dim MM3 As String
        Dim MM4 As String
        Dim GGM1 As String
        Dim GGM3 As String
        Dim GGM4 As String
        If mmm <> "" Then
            MM1 = CStr(Me.tacv.M - 1).Trim.PadLeft(2, "0"c)
            If Me.tacv.M = 1 Then MM1 = "12"
            GGM1 = CStr(Me.tacv.G)
            If Me.tacv.M = 1 Then GGM1 = GG1
            GGM3 = CStr(Me.tacv.G)
            If Me.tacv.M < 4 Then GGM3 = GG1
            MM3 = CStr(Me.tacv.M - 3).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 4 Then MM3 = CStr(Me.tacv.M + 9).Trim.PadLeft(2, "0"c)
            'prethodno polugođe
            GGM4 = CStr(Me.tacv.G)
            If Me.tacv.M < 6 Then GGM4 = GG1 'prethodna godina
            MM4 = CStr(Me.tacv.M - 6).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 6 Then MM4 = CStr(Me.tacv.M + 6).Trim.PadLeft(2, "0"c)
            '----------------------------------------
            sfwP = " LEFT JOIN " & tn & " PM  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PM.[" & kljNiz(i).Trim.ToUpper & "] = d.[" & kljNiz(i) & "] AND "
            Next
            sfwP = sfwP + "(PM.[" + mmm + "] = '" & MM1 & "' AND PM.[" + ggg + "]='" & GGM1 & "' )"
            sql = sql + sfwP & ")"

            sfwP = " LEFT JOIN " & tn & " PK  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PK.[" & kljNiz(i).Trim.ToUpper & "] = d.[" & kljNiz(i) & "] AND "
            Next
            sfwP = sfwP + "(PK.[" + mmm + "] = '" & MM3 & "' AND PK.[" + ggg + "]='" & GGM3 & "' )"
            sql = sql + sfwP & ")"

            sfwP = " LEFT JOIN " & tn & " PP  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PP.[" & kljNiz(i).Trim.ToUpper & "] = d.[" & kljNiz(i) & "]  AND "
            Next
            sfwP = sfwP + "(PP.[" + mmm + "] = '" & MM4 & "' AND PP.[" + ggg + "]='" & GGM4 & "' )"
            sql = sql + sfwP & ")"
        End If

        sfwP = " LEFT JOIN " & tn & " PG  ON ("
        For i As Integer = 0 To kljNiz.GetUpperBound(0)
            sfwP = sfwP + "PG.[" & kljNiz(i).Trim.ToUpper & "] = d.[" & kljNiz(i) & "] AND "
        Next
        If mmm <> "" Then
            sfwP = sfwP + "(PG.[" + mmm + "]= '" & CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) & "' AND PG.[" + ggg + "]='" & GG1 & "' )"
        Else
            sfwP = sfwP + "(PG.[" + ggg + "]='" & GG1 & "' )"
        End If

        sql = sql + sfwP & ")"

        dajGM1 = sql
    End Function

    Function dajGM1E(ByVal kljNiz() As String, ByVal tn As String, ByVal ggg As String, Optional ByVal mmm As String = "") As String

        Dim sql As String = ""
        Dim GG1 As String = CStr(Me.tacv.G - 1)
        Dim sfwP As String
        Dim MM1 As String
        Dim MM3 As String
        Dim MM4 As String
        Dim GGM1 As String
        Dim GGM3 As String
        Dim GGM4 As String
        If mmm <> "" Then
            MM1 = CStr(Me.tacv.M - 1).Trim.PadLeft(2, "0"c)
            If Me.tacv.M = 1 Then MM1 = "12"
            GGM1 = CStr(Me.tacv.G)
            If Me.tacv.M = 1 Then GGM1 = GG1
            GGM3 = CStr(Me.tacv.G)
            If Me.tacv.M < 4 Then GGM3 = GG1
            MM3 = CStr(Me.tacv.M - 3).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 4 Then MM3 = CStr(Me.tacv.M + 9).Trim.PadLeft(2, "0"c)
            'prethodno polugođe
            GGM4 = CStr(Me.tacv.G)
            If Me.tacv.M < 6 Then GGM4 = GG1 'prethodna godina
            MM4 = CStr(Me.tacv.M - 6).Trim.PadLeft(2, "0"c)
            If Me.tacv.M < 6 Then MM4 = CStr(Me.tacv.M + 6).Trim.PadLeft(2, "0"c)
            '----------------------------------------
            sfwP = " LEFT JOIN " & tn & " PMONTH  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PMONTH.[" & kljNiz(i).Trim.ToUpper & "] = d.[" & kljNiz(i) & "] AND "
            Next
            sfwP = sfwP + "(PMONTH.[" + mmm + "] = '" & MM1 & "' AND PMONTH.[" + ggg + "]='" & GGM1 & "' )"
            sql = sql + sfwP & ")"

            sfwP = " LEFT JOIN " & tn & " PQ  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PQ.[" & kljNiz(i).Trim.ToUpper & "] = d.[" & kljNiz(i) & "] AND "
            Next
            sfwP = sfwP + "(PQ.[" + mmm + "] = '" & MM3 & "' AND PQ.[" + ggg + "]='" & GGM3 & "' )"
            sql = sql + sfwP & ")"

            sfwP = " LEFT JOIN " & tn & " PH  ON ("
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                sfwP = sfwP + "PH.[" & kljNiz(i).Trim.ToUpper & "] = d.[" & kljNiz(i) & "] AND "
            Next
            sfwP = sfwP + "(PH.[" + mmm + "] = '" & MM4 & "' AND PH.[" + ggg + "]='" & GGM4 & "' )"
            sql = sql + sfwP & ")"
        End If

        sfwP = " LEFT JOIN " & tn & " PY  ON ("
        For i As Integer = 0 To kljNiz.GetUpperBound(0)
            sfwP = sfwP + "PY.[" & kljNiz(i).Trim.ToUpper & "]= d.[" & kljNiz(i) & "] AND "
        Next
        If mmm <> "" Then
            sfwP = sfwP + "(PY.[" + mmm + "]= '" & CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) & "' AND PY.[" + ggg + "]='" & GG1 & "' )"
        Else
            sfwP = sfwP + "(PY.[" + ggg + "]='" & GG1 & "' )"
        End If

        sql = sql + sfwP & ")"

        dajGM1E = sql
    End Function


    Public Function dajCS(ByVal tn As String, ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable) As System.Data.DataColumn()
        dajCS = {}
        Dim cs() As System.Data.DataColumn = {}
        For Each rp As DatasetIstrazivanja.ISTPOLJARow In tp.Rows
            If rp.TABELA.Trim.ToUpper = tn.Trim.ToUpper Then

                If rp.POLJE.Trim.ToUpper = "DGDOM" Then
                    Dim mira As Integer
                    mira = 3
                End If

                'ako je izraz prazan ILI
                'nije prazan I NEMA :S ILI    'bilo :SN svuda
                'nije prazan I ne pocinje sa "'" ILI
                'nije prazan I NEMA GLAVA
                'nije prazan I NEMA #FP{
                Dim rpIzraz As String = ""
                Dim rpOpis As String = ""

                If rp.IsIzrazNull = False Then
                    rpIzraz = rp.Izraz.Trim.ToUpper

                    If rp.IsIzrazNull OrElse rpIzraz = "" _
                                OrElse InStr(rpIzraz.ToUpper, "CHECKBOX") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATAGRIDVIEW") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "RADIOBUTTON") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBO{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBW{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATETIMEPICKER") > 0 OrElse InStr(rpIzraz.ToUpper, "ENCRYPT") > 0 Then
                    Else
                        rpIzraz = zameniRPIZRAZ(rpIzraz)
                    End If
                End If

                If rp.IsOpisNull = True Then
                Else
                    rpOpis = rp.Opis.Trim
                    Dim poz1 As Integer = rpOpis.LastIndexOf("$")
                    Dim poz2 As Integer = rpOpis.IndexOf("#")
                    If poz1 = 0 AndAlso poz2 = 1 Then rpOpis = "" '$#
                    If poz1 < 0 AndAlso poz2 = 0 Then rpOpis = "" 'nema $, ima #
                    If poz1 >= 0 AndAlso poz2 < 0 Then rpOpis = rpOpis.Substring(poz1 + 1) 'ima $, nema #
                    If poz1 >= 0 AndAlso poz2 > poz1 AndAlso poz2 > 1 Then rpOpis = rpOpis.Substring(poz1 + 1, poz2 - poz1 - 1)
                End If

                If rpIzraz.Length = 0 OrElse
                       InStr(rpIzraz.ToUpper, "CBO{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "CBW{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "ENCRYPT") >= 0 OrElse
                       InStr(rpIzraz.ToUpper, ":S") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "#FP{") > 0 OrElse
                       InStr(rpIzraz.ToUpper, "{") > 0 OrElse
                       (InStr(rpIzraz.ToUpper, ":S") = 0 AndAlso InStr(rpIzraz.ToUpper, "ISTLBL") = 0 AndAlso
                       rpIzraz.Substring(0, 1) <> "'" AndAlso rpIzraz.Substring(0, 1) <> "{" AndAlso
                       Not (rpIzraz.Length = 14 AndAlso rpIzraz.ToUpper.Substring(0, 14) = "DATETIMEPICKER") AndAlso
                       Not (rpIzraz.Length = 9 AndAlso rpIzraz.ToUpper.Substring(0, 9) = "LINKLABEL") AndAlso
                       Not (rpIzraz.Length = 12 AndAlso rpIzraz.ToUpper.Substring(0, 12) = "DATAGRIDVIEW") AndAlso
                       Not (rpIzraz.Length = 12 AndAlso rpIzraz.ToUpper.Substring(0, 12) = "AUTOCOMPLETE") AndAlso
                       ((InStr(rpIzraz.ToUpper, "CBO{") = 0 AndAlso InStr(rpIzraz.ToUpper, "CBW{") = 0 AndAlso
                       InStr(rpIzraz.ToUpper, "GLAVA.") = 0 AndAlso
                       InStr(rpIzraz.ToUpper, "HEAD.") = 0)) AndAlso
                       InStr(rpIzraz.ToUpper, "#FP{") = 0 AndAlso InStr(rpIzraz.ToUpper, "FCALCULATEAGE") = 0) Then

                    Dim ok As Boolean = True
                    If rpIzraz.Trim.ToUpper.IndexOf("FCALCULATEAGE") >= 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("#FP{") >= 0 OrElse
                       rpIzraz.Trim.ToUpper.IndexOf(":S") >= 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("DATAGRIDVIEW") >= 0 OrElse
                         rpIzraz.Trim.ToUpper.IndexOf("GLAVA.") >= 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("HEAD.") >= 0 OrElse
                       rpIzraz.Trim.ToUpper.IndexOf("AUTOCOMPLETE") >= 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("ENCRYPT") >= 0 OrElse
                        (rpIzraz.Trim.ToUpper.IndexOf("RADIOBUTTON") < 0 AndAlso rpIzraz.Trim.ToUpper.IndexOf("BUTTON") >= 0) OrElse
                        rpIzraz.Trim.ToUpper.IndexOf("ISTLBL") >= 0 Then ok = False
                    If rpIzraz.IndexOf("'") = 0 OrElse rpIzraz.Trim.ToUpper.IndexOf("{") = 0 Then ok = False
                    If ok = True Then
                        Dim c As New System.Data.DataColumn
                        If rpIzraz = "" _
                                OrElse InStr(rpIzraz.ToUpper, "CHECKBOX") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATAGRIDVIEW") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "AUTOCOMPLETE") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "ENCRYPT") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "RADIOBUTTON") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, ":S") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBO{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "CBW{") > 0 _
                                OrElse InStr(rpIzraz.ToUpper, "DATETIMEPICKER") > 0 Then
                            c = Me.dt.Columns(rp.POLJE.Trim)
                        Else
                            Dim jesteIzraz As Boolean = False
                            If InStr(rpIzraz, "#") = 0 Then
                                Dim bbb() As String = razkvantaj(rpIzraz)
                                For i As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(i).Trim.ToUpper = "CASE" Then ' OrElse bbb(i) = "+" OrElse bbb(i) = "*" OrElse bbb(i) = "/" OrElse bbb(i) = "-" Then
                                        jesteIzraz = True
                                        Exit For
                                    End If
                                Next
                            End If

                            If InStr(rpIzraz, "#") <> 0 OrElse InStr(rpIzraz, "%:%") <> 0 OrElse jesteIzraz = True Then
                                c.Expression = "Parent(Exp1).Naziv"
                            Else
                                c.Expression = rpIzraz
                            End If
                            c.ColumnName = rp.POLJE.Trim
                            c.ExtendedProperties.Add("Izraz", rpIzraz)
                            If Not rp.IsOpisNull Then Me.dt.Columns(rp.POLJE.Trim).Caption = rpOpis
                        End If

                        If c Is Nothing Then
                            ''msg 48
                            Dim msgtxt48 As String = getMessageText(dtMessages, "48", Me.jezik)
                            ''msg 197
                            Dim msgtxt197 As String = getMessageText(dtMessages, "197", Me.jezik)
                            ISTMessageBox.Show(msgtxt48 + " " + rp.POLJE.Trim + " " + msgtxt197, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            If Not rp.IsOpisNull Then c.Caption = rpOpis
                            ReDim Preserve cs(1 + cs.GetUpperBound(0))
                            cs(cs.GetUpperBound(0)) = c
                            If kcol(rp) Then
                                c.AllowDBNull = False
                                c.ReadOnly = True
                                With Me.dt
                                    Dim pk() As System.Data.DataColumn = .PrimaryKey
                                    ReDim Preserve pk(1 + pk.GetUpperBound(0))
                                    pk(pk.GetUpperBound(0)) = c
                                    .PrimaryKey = pk
                                End With
                                ReDim Preserve Me.mviscol(1 + Me.mviscol.GetUpperBound(0))
                                Me.mviscol(Me.mviscol.GetUpperBound(0)) = c
                            Else

                                Dim ii As String
                                If c.Expression Is System.DBNull.Value OrElse c.Expression = "" Then
                                    ii = " "
                                Else
                                    ii = c.Expression.Trim
                                End If

                                If c.ColumnName.Trim.ToUpper.IndexOf("NONFILTER") >= 0 _
                                    OrElse ii.Substring(0, 1) = "'" _
                                    OrElse ii.Substring(0, 1) = "{" _
                                    OrElse (ii.Trim.Length >= 9 AndAlso ii.Substring(0, 9).ToUpper = "LINKLABEL") _
                                    OrElse (ii.Trim.Length >= 12 AndAlso ii.Substring(0, 12).ToUpper = "DATAGRIDVIEW") _
                                    OrElse (ii.Trim.Length >= 12 AndAlso ii.Substring(0, 12).ToUpper = "AUTOCOMPLETE") _
                                    OrElse (ii.Trim.Length >= 8 AndAlso ii.Substring(0, 8).ToUpper = "CHECKBOX") _
                                    OrElse (ii.Trim.Length >= 11 AndAlso ii.Substring(0, 11).ToUpper = "RADIOBUTTON") _
                                    OrElse (ii.Trim.Length >= 14 AndAlso ii.Substring(0, 14).ToUpper = "DATETIMEPICKER") _
                                    OrElse ii.Trim.ToUpper.IndexOf("ENCRYPT.") >= 0 _
                                    OrElse ii.Trim.ToUpper.IndexOf("GLAVA.") >= 0 _
                                    OrElse ii.Trim.ToUpper.IndexOf("HEAD.") >= 0 _
                                    OrElse ii.Trim.ToUpper.IndexOf("#FP{") >= 0 _
                                    OrElse ii.Trim.ToUpper.IndexOf(":S") >= 0 _
                                    OrElse ii.Trim.ToUpper.IndexOf("{") = 0 _
                                    OrElse ii.Trim.ToUpper.IndexOf("FCALCULATEAGE") >= 0 Then
                                    'po ovima se ne filtrira, odnosi se samo na fiktivna polja
                                    'da uopse ne udju oni koji nisu FP već samo "glume" labele - to su oni kojima je izraz 'pa nešto'
                                    'da uopste ne udju oni koji imaju u sebi GLAVA. ...
                                Else
                                    ReDim Preserve Me.ucol(1 + Me.ucol.GetUpperBound(0))
                                    Me.ucol(Me.ucol.GetUpperBound(0)) = c
                                End If
                            End If
                        End If
                        c.Dispose()
                    End If
                End If
            End If
        Next
        Return cs
    End Function
    Public Function kcol(ByVal r As DatasetIstrazivanja.ISTPOLJARow) As Boolean
        If Not r.IsKLJUCNull AndAlso r.KLJUC.Trim.ToUpper = "P" Then
            Return True
        End If
        Return False
    End Function

    Public Sub appendTS(ByVal tn As String, ByVal rb As DatasetIstrazivanja.ISTBAZERow, ByVal l As DatasetIstrazivanja.ISTLKDataTable,
                ByVal cs() As System.Data.DataColumn,
                ByVal gi As DataGridView, ByVal tpagslog As System.Windows.Forms.TabPage,
                ByVal tpagprikaz As System.Windows.Forms.TabPage, ByVal tpagcelatab As System.Windows.Forms.TabPage, ByVal nogridediting As Boolean)


        If nogridediting Then gi.ReadOnly = True

        For Each k2 As DatasetIstrazivanja.ISTLKRow In l.Rows
            If k2.TABELA.Trim.ToUpper = tn.Trim.ToUpper Then
                Dim col As System.Data.DataColumn
                col = Me.dt.Columns(k2.RbrGreske.Trim)
                If Not k2.IstezinaNull Then
                    col.ExtendedProperties.Add("Tezina", k2.tezina.Trim.ToUpper)
                End If
                col.ReadOnly = True
                ReDim Preserve Me.ecol(1 + Me.ecol.GetUpperBound(0))
                Me.ecol(Me.ecol.GetUpperBound(0)) = col
            End If
        Next
        ''''
        Call SetLangTColInfo()

        'Greske_za_slog
        Me.dt_greskeZaSlog = Me.mdsgre.Greske_za_slog
        Me.dt_greskeZaSlog.TableName = Me.tab1

        Call imenaKolona4(mdsgre.Tables(0))

        Me.dg_greskeZaSlog = New DataGridView
        Me.dg_greskeZaSlog.Visible = False
        tpagslog.Controls.Add(Me.dg_greskeZaSlog)
        For Each c2 As System.Data.DataColumn In Me.dt_greskeZaSlog.Columns
            c2.ReadOnly = True
        Next
        Dim av(Me.dt_greskeZaSlog.Columns.Count - 1) As System.Data.DataColumn
        Me.dt_greskeZaSlog.Columns.CopyTo(av, 0)
        ' Me.dg_greskeZaSlog.MyAppendTableStyle(Me.dt_greskeZaSlog.TableName, av, av, Nothing)
        Me.dt_greskeZaSlog.DefaultView.AllowNew = False
        Me.dt_greskeZaSlog.DefaultView.AllowDelete = False
        Me.dg_greskeZaSlog.DataSource = Me.dt_greskeZaSlog


        'Greske_za_prikazane_slogove
        Me.dt_greskeZaPrikazaneSlogove = Me.mdsgre.Greske_za_prikazane_slogove
        Me.dt_greskeZaPrikazaneSlogove.TableName = Me.tab2
        Call imenaKolona5(mdsgre.Tables(1))
        Me.dg_greskeZaPrikazaneSlogove = New DataGridView
        Me.dg_greskeZaPrikazaneSlogove.Visible = False
        tpagprikaz.Controls.Add(Me.dg_greskeZaPrikazaneSlogove)
        For Each col As System.Data.DataColumn In Me.dt_greskeZaPrikazaneSlogove.Columns
            col.ReadOnly = True
        Next
        Dim cs2(Me.dt_greskeZaPrikazaneSlogove.Columns.Count - 1) As System.Data.DataColumn
        Me.dt_greskeZaPrikazaneSlogove.Columns.CopyTo(cs2, 0)
        ' Me.dg_greskeZaPrikazaneSlogove.MyAppendTableStyle(Me.dt_greskeZaPrikazaneSlogove.TableName, cs2, cs2, Nothing)
        Me.dt_greskeZaPrikazaneSlogove.DefaultView.AllowNew = False
        Me.dt_greskeZaPrikazaneSlogove.DefaultView.AllowDelete = False
        Me.dt_greskeZaPrikazaneSlogove.DefaultView.Sort = Me.dt_greskeZaPrikazaneSlogove.SlogovaColumn.ColumnName + " desc"
        Me.dg_greskeZaPrikazaneSlogove.DataSource = Me.dt_greskeZaPrikazaneSlogove

        Me.dg_greskeZaTabelu = New DataGridView
        Me.dg_greskeZaTabelu.Visible = False
        tpagcelatab.Controls.Add(Me.dg_greskeZaTabelu)



        'Me.LKizvestaj = New LKizv(Me.DBConnectionString, rb, Me.mtlk, Me.dg_greskeZaTabelu, Nothing, False, Me.tacv, Me.jezik)
        'ovo davi strasno, prebaceno da se radi kad se klikne na tab Greske za celu tabelu
        'Me.daj_dt_greskeZaTabelu()
        'ovo davi strasno
    End Sub
    Sub imenaKolona4(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = dgGrid8
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = dgGrid9
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = dgGrid11
    End Sub

    Sub imenaKolona5(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = dgGrid8
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = dgGrid9
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = dgGrid11
        If Not dgDT.Columns("Slogova") Is Nothing Then dgDT.Columns("Slogova").ColumnName = dgGrid17
    End Sub

    Public dgGrid8 As String
    Public dgGrid9 As String
    Public dgGrid11 As String
    Public dgGrid17 As String
    Public tab1 As String
    Public tab2 As String

    Private Sub SetLangTColInfo()
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formAzuriraj")
        '****GRIDOVI
        Me.dgGrid8 = getControlText2(dt, "dgGrid8", Me.jezik)
        Me.dgGrid9 = getControlText2(dt, "dgGrid9", Me.jezik)
        Me.dgGrid11 = getControlText2(dt, "dgGrid11", Me.jezik)
        Me.dgGrid17 = getControlText2(dt, "dgGrid17", Me.jezik)
        Me.tab1 = getControlText2(dt, "TabPageGreskeZaSlog", Me.jezik)
        Me.tab2 = getControlText2(dt, "TabPageGreskeZaPrikazaneSlogove", Me.jezik)
    End Sub
    Public Shared Function grcols(ByVal g As String) As String()
        '  Dim kw() As String = {"in", "between", "and", "or", "not", "substring", "cast", "as", "integer", "int", "exists", "char", "nvarchar", "varchar", "select", "from", "where", "order", "by", "top", "count"}
        Dim kw() As String = {"in", "between", "and", "or", "not"}
        Dim cs() As String = {}
        For i As Integer = 0 To g.Length - 1
            Dim c As Char = g.Chars(i)
            If Char.IsLetter(c) OrElse c = "_"c Then
                Dim s As String = c
                For j As Integer = i + 1 To g.Length - 1
                    c = g.Chars(j)
                    If Char.IsLetterOrDigit(c) OrElse c = "_"c Then
                        s = s + c
                    Else
                        i = j
                        Exit For
                    End If
                Next
                If System.Array.IndexOf(kw, s.ToLower) < 0 Then
                    Do
                        For Each s2 As String In cs
                            If s2 = s Then
                                Exit Do
                            End If
                        Next
                        ReDim Preserve cs(1 + cs.GetUpperBound(0))
                        cs(cs.GetUpperBound(0)) = s
                    Loop While False
                End If
            End If
        Next
        Return cs
    End Function

    Public Sub dg_greskezaSlog_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_greskeZaSlog.CurrentCellChanged
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        If Me.chksinhr.Checked Then
            If dgv.CurrentRow IsNot Nothing Then
                Dim currentRowView As DataRowView = TryCast(dgv.CurrentRow.DataBoundItem, DataRowView)
                If currentRowView IsNot Nothing Then
                    Dim rv As DataRow = currentRowView.Row
                    ' Now you can access dataRow's fields
                    Dim cs() As String = {}
                    If Not rv Is Nothing AndAlso Not rv.IsNull(dgGrid9) Then
                        Dim g As String = CStr(rv.Item(dgGrid9))
                        cs = TcolInfo.grcols(g)
                    End If
                    Call DGVShowColumns(Me.mgist, cs, Me.pamtics)
                    Me.pamtics = cs
                End If
            End If
        End If

    End Sub
    Sub DGVShowColumns(ByVal dgv As DataGridView, ByVal cs() As String, ByVal pamtics() As String)

        For i As Integer = 0 To pamtics.GetUpperBound(0)
            Dim nname As String = pamtics(i).Trim.ToUpper
            If nname <> "" AndAlso dgv.Columns.Contains(nname) Then dgv.Columns(nname).Visible = False
        Next
        For i As Integer = 0 To cs.GetUpperBound(0)
            Dim nname As String = cs(i).Trim.ToUpper
            If nname <> "" AndAlso dgv.Columns.Contains(nname) Then dgv.Columns(nname).Visible = True
        Next

    End Sub


End Class

