Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports IstrazivanjaUnos.DataGridViewMultiSortUnos

Public Class FormNaprednaPretragaUnos
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents tabKontrola As System.Windows.Forms.TabControl

    Friend WithEvents GB2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_JSON As System.Windows.Forms.Button
    Friend WithEvents ButtonNPPonisti As System.Windows.Forms.Button
    Friend WithEvents ButtonXML As System.Windows.Forms.Button
    Friend WithEvents ButtonPrikaziExcel As System.Windows.Forms.Button
    Friend WithEvents ButtonNPTrazi As System.Windows.Forms.Button
    Friend WithEvents ButtonNPIzlaz As System.Windows.Forms.Button
    Friend WithEvents cbRazliciti As System.Windows.Forms.CheckBox
    Friend WithEvents btnNPUvuci As System.Windows.Forms.Button
    Friend WithEvents tUvuci As System.Windows.Forms.TextBox
    Friend WithEvents panelPamtiOkvir As System.Windows.Forms.Panel
    Friend WithEvents ButtonNPSacuvajUslov As System.Windows.Forms.Button
    Friend WithEvents tp_naziv As System.Windows.Forms.TextBox
    Friend WithEvents lblNPnaziv As System.Windows.Forms.Label
    Friend WithEvents lblNPNapomena As System.Windows.Forms.Label
    Friend WithEvents tp_napomena As System.Windows.Forms.TextBox
    Friend WithEvents ButtonNPCancel As System.Windows.Forms.Button
    Friend WithEvents dgA As System.Windows.Forms.DataGridView
    Friend WithEvents txtUslov As System.Windows.Forms.TextBox
    Friend WithEvents txtPOM As System.Windows.Forms.TextBox
    Friend WithEvents bClose As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tvBaza As System.Windows.Forms.TreeView
    Friend WithEvents btnNPStariUpit As System.Windows.Forms.Button
    Friend WithEvents btnNPSacuvajUslov As System.Windows.Forms.Button
    Friend WithEvents mnuColumnSve As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents xsum As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xmin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xmax As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xcount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xavg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuColumn As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents amin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents amax As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents acount As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xgroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xhide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xunhide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents agroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ahide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aunhide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuUngroup As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents bungroup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bunhide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents xsort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xmcs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents asort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents amcs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bsort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bmcs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bAgregiranje As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents afind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents xfind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblPorukaUslov As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents xfilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xunfilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents afilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aunfilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bfilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bunfilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuWithFunction As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents dhide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dunhide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dsort As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dmcs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dfind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dfilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dunfilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonNPPonistiSve As System.Windows.Forms.Button
    Friend WithEvents chStart As System.Windows.Forms.CheckBox
    Friend WithEvents chEnd As System.Windows.Forms.CheckBox
    Friend WithEvents chContanes As System.Windows.Forms.CheckBox
    Friend WithEvents GBLike As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents xBTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents xSTB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents aBTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aSTB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bBTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bSTB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents dBTF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dSTB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clbAplikacija As CheckedListBox
    Friend WithEvents lblAplikacija As Label
    Friend WithEvents txtTraziPoCLB As TextBox
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents PanelContext As Panel
    Friend WithEvents btnDown As Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNaprednaPretragaUnos))
        Me.tabKontrola = New System.Windows.Forms.TabControl()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.ButtonNPPonistiSve = New System.Windows.Forms.Button()
        Me.btnNPStariUpit = New System.Windows.Forms.Button()
        Me.btnNPSacuvajUslov = New System.Windows.Forms.Button()
        Me.btn_JSON = New System.Windows.Forms.Button()
        Me.ButtonNPPonisti = New System.Windows.Forms.Button()
        Me.ButtonXML = New System.Windows.Forms.Button()
        Me.ButtonPrikaziExcel = New System.Windows.Forms.Button()
        Me.ButtonNPTrazi = New System.Windows.Forms.Button()
        Me.ButtonNPIzlaz = New System.Windows.Forms.Button()
        Me.cbRazliciti = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnNPUvuci = New System.Windows.Forms.Button()
        Me.tUvuci = New System.Windows.Forms.TextBox()
        Me.panelPamtiOkvir = New System.Windows.Forms.Panel()
        Me.lblNPnaziv = New System.Windows.Forms.Label()
        Me.ButtonNPCancel = New System.Windows.Forms.Button()
        Me.ButtonNPSacuvajUslov = New System.Windows.Forms.Button()
        Me.tp_naziv = New System.Windows.Forms.TextBox()
        Me.lblNPNapomena = New System.Windows.Forms.Label()
        Me.tp_napomena = New System.Windows.Forms.TextBox()
        Me.dgA = New System.Windows.Forms.DataGridView()
        Me.txtUslov = New System.Windows.Forms.TextBox()
        Me.txtPOM = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tvBaza = New System.Windows.Forms.TreeView()
        Me.mnuColumnSve = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.xsum = New System.Windows.Forms.ToolStripMenuItem()
        Me.xmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.xmax = New System.Windows.Forms.ToolStripMenuItem()
        Me.xcount = New System.Windows.Forms.ToolStripMenuItem()
        Me.xavg = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.xgroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.xhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.xunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.xsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.xmcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.xfind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.xfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.xunfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.xBTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.xSTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumn = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.amin = New System.Windows.Forms.ToolStripMenuItem()
        Me.amax = New System.Windows.Forms.ToolStripMenuItem()
        Me.acount = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.agroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ahide = New System.Windows.Forms.ToolStripMenuItem()
        Me.aunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.asort = New System.Windows.Forms.ToolStripMenuItem()
        Me.amcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.afind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.afilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.aunfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.aBTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.aSTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUngroup = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.bungroup = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.bunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.bsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.bmcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.bFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.bfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.bunfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.bBTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.bSTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.bAgregiranje = New System.Windows.Forms.Button()
        Me.bClose = New System.Windows.Forms.PictureBox()
        Me.lblPorukaUslov = New System.Windows.Forms.Label()
        Me.mnuWithFunction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.dhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunhide = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.dsort = New System.Windows.Forms.ToolStripMenuItem()
        Me.dmcs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.dfind = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.dfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.dunfilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.dBTF = New System.Windows.Forms.ToolStripMenuItem()
        Me.dSTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.chStart = New System.Windows.Forms.CheckBox()
        Me.chEnd = New System.Windows.Forms.CheckBox()
        Me.chContanes = New System.Windows.Forms.CheckBox()
        Me.GBLike = New System.Windows.Forms.GroupBox()
        Me.clbAplikacija = New System.Windows.Forms.CheckedListBox()
        Me.lblAplikacija = New System.Windows.Forms.Label()
        Me.txtTraziPoCLB = New System.Windows.Forms.TextBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.btnDown = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB2.SuspendLayout()
        Me.panelPamtiOkvir.SuspendLayout()
        CType(Me.dgA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuColumnSve.SuspendLayout()
        Me.mnuColumn.SuspendLayout()
        Me.mnuUngroup.SuspendLayout()
        CType(Me.bClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuWithFunction.SuspendLayout()
        Me.GBLike.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabKontrola
        '
        Me.tabKontrola.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.tabKontrola.ForeColor = System.Drawing.Color.RoyalBlue
        Me.tabKontrola.ItemSize = New System.Drawing.Size(48, 19)
        Me.tabKontrola.Location = New System.Drawing.Point(5, 312)
        Me.tabKontrola.Name = "tabKontrola"
        Me.tabKontrola.SelectedIndex = 0
        Me.tabKontrola.Size = New System.Drawing.Size(498, 323)
        Me.tabKontrola.TabIndex = 61
        Me.tabKontrola.Visible = False
        '
        'GB2
        '
        Me.GB2.Controls.Add(Me.ButtonNPPonistiSve)
        Me.GB2.Controls.Add(Me.btnNPStariUpit)
        Me.GB2.Controls.Add(Me.btnNPSacuvajUslov)
        Me.GB2.Controls.Add(Me.btn_JSON)
        Me.GB2.Controls.Add(Me.ButtonNPPonisti)
        Me.GB2.Controls.Add(Me.ButtonXML)
        Me.GB2.Controls.Add(Me.ButtonPrikaziExcel)
        Me.GB2.Controls.Add(Me.ButtonNPTrazi)
        Me.GB2.Location = New System.Drawing.Point(986, 37)
        Me.GB2.Margin = New System.Windows.Forms.Padding(1)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(152, 236)
        Me.GB2.TabIndex = 100
        Me.GB2.TabStop = False
        '
        'ButtonNPPonistiSve
        '
        Me.ButtonNPPonistiSve.BackColor = System.Drawing.Color.Linen
        Me.ButtonNPPonistiSve.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonNPPonistiSve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNPPonistiSve.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNPPonistiSve.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonNPPonistiSve.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNPPonistiSve.Location = New System.Drawing.Point(8, 122)
        Me.ButtonNPPonistiSve.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonNPPonistiSve.Name = "ButtonNPPonistiSve"
        Me.ButtonNPPonistiSve.Size = New System.Drawing.Size(136, 23)
        Me.ButtonNPPonistiSve.TabIndex = 107
        Me.ButtonNPPonistiSve.Text = "Поништи све"
        Me.ButtonNPPonistiSve.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonNPPonistiSve.UseVisualStyleBackColor = False
        '
        'btnNPStariUpit
        '
        Me.btnNPStariUpit.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnNPStariUpit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNPStariUpit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNPStariUpit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNPStariUpit.Location = New System.Drawing.Point(8, 69)
        Me.btnNPStariUpit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNPStariUpit.Name = "btnNPStariUpit"
        Me.btnNPStariUpit.Size = New System.Drawing.Size(136, 23)
        Me.btnNPStariUpit.TabIndex = 106
        Me.btnNPStariUpit.Text = "Постојећи услов"
        Me.btnNPStariUpit.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnNPSacuvajUslov
        '
        Me.btnNPSacuvajUslov.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnNPSacuvajUslov.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNPSacuvajUslov.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNPSacuvajUslov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNPSacuvajUslov.Location = New System.Drawing.Point(8, 45)
        Me.btnNPSacuvajUslov.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNPSacuvajUslov.Name = "btnNPSacuvajUslov"
        Me.btnNPSacuvajUslov.Size = New System.Drawing.Size(136, 23)
        Me.btnNPSacuvajUslov.TabIndex = 105
        Me.btnNPSacuvajUslov.Text = "Сачувај услов"
        Me.btnNPSacuvajUslov.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_JSON
        '
        Me.btn_JSON.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn_JSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_JSON.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_JSON.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_JSON.Location = New System.Drawing.Point(8, 198)
        Me.btn_JSON.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_JSON.Name = "btn_JSON"
        Me.btn_JSON.Size = New System.Drawing.Size(136, 23)
        Me.btn_JSON.TabIndex = 54
        Me.btn_JSON.Text = "JSON"
        Me.btn_JSON.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonNPPonisti
        '
        Me.ButtonNPPonisti.BackColor = System.Drawing.Color.Linen
        Me.ButtonNPPonisti.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonNPPonisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNPPonisti.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNPPonisti.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonNPPonisti.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNPPonisti.Location = New System.Drawing.Point(8, 97)
        Me.ButtonNPPonisti.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonNPPonisti.Name = "ButtonNPPonisti"
        Me.ButtonNPPonisti.Size = New System.Drawing.Size(136, 23)
        Me.ButtonNPPonisti.TabIndex = 53
        Me.ButtonNPPonisti.Text = "Поништи"
        Me.ButtonNPPonisti.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonNPPonisti.UseVisualStyleBackColor = False
        '
        'ButtonXML
        '
        Me.ButtonXML.BackColor = System.Drawing.Color.Transparent
        Me.ButtonXML.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonXML.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonXML.Location = New System.Drawing.Point(8, 174)
        Me.ButtonXML.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonXML.Name = "ButtonXML"
        Me.ButtonXML.Size = New System.Drawing.Size(136, 23)
        Me.ButtonXML.TabIndex = 51
        Me.ButtonXML.Text = "XML"
        Me.ButtonXML.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonXML.UseVisualStyleBackColor = False
        '
        'ButtonPrikaziExcel
        '
        Me.ButtonPrikaziExcel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPrikaziExcel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonPrikaziExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrikaziExcel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrikaziExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrikaziExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonPrikaziExcel.Location = New System.Drawing.Point(8, 150)
        Me.ButtonPrikaziExcel.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPrikaziExcel.Name = "ButtonPrikaziExcel"
        Me.ButtonPrikaziExcel.Size = New System.Drawing.Size(136, 23)
        Me.ButtonPrikaziExcel.TabIndex = 50
        Me.ButtonPrikaziExcel.Text = "Excel"
        Me.ButtonPrikaziExcel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonPrikaziExcel.UseVisualStyleBackColor = False
        '
        'ButtonNPTrazi
        '
        Me.ButtonNPTrazi.BackColor = System.Drawing.Color.Linen
        Me.ButtonNPTrazi.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonNPTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNPTrazi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNPTrazi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonNPTrazi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNPTrazi.Location = New System.Drawing.Point(8, 16)
        Me.ButtonNPTrazi.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonNPTrazi.Name = "ButtonNPTrazi"
        Me.ButtonNPTrazi.Size = New System.Drawing.Size(136, 23)
        Me.ButtonNPTrazi.TabIndex = 52
        Me.ButtonNPTrazi.Text = "Тражи"
        Me.ButtonNPTrazi.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonNPTrazi.UseVisualStyleBackColor = False
        '
        'ButtonNPIzlaz
        '
        Me.ButtonNPIzlaz.BackColor = System.Drawing.Color.Transparent
        Me.ButtonNPIzlaz.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonNPIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonNPIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNPIzlaz.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNPIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNPIzlaz.Location = New System.Drawing.Point(994, 13)
        Me.ButtonNPIzlaz.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonNPIzlaz.Name = "ButtonNPIzlaz"
        Me.ButtonNPIzlaz.Size = New System.Drawing.Size(136, 23)
        Me.ButtonNPIzlaz.TabIndex = 98
        Me.ButtonNPIzlaz.Text = "Излаз"
        Me.ButtonNPIzlaz.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonNPIzlaz.UseVisualStyleBackColor = False
        '
        'cbRazliciti
        '
        Me.cbRazliciti.BackColor = System.Drawing.Color.Transparent
        Me.cbRazliciti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRazliciti.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbRazliciti.Location = New System.Drawing.Point(5, 49)
        Me.cbRazliciti.Name = "cbRazliciti"
        Me.cbRazliciti.Size = New System.Drawing.Size(264, 22)
        Me.cbRazliciti.TabIndex = 101
        Me.cbRazliciti.Text = "Прикажи различите редове (distinct)"
        Me.cbRazliciti.UseVisualStyleBackColor = False
        '
        'btnNPUvuci
        '
        Me.btnNPUvuci.BackColor = System.Drawing.Color.Transparent
        Me.btnNPUvuci.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnNPUvuci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNPUvuci.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNPUvuci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNPUvuci.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNPUvuci.Location = New System.Drawing.Point(720, 52)
        Me.btnNPUvuci.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNPUvuci.Name = "btnNPUvuci"
        Me.btnNPUvuci.Size = New System.Drawing.Size(200, 23)
        Me.btnNPUvuci.TabIndex = 103
        Me.btnNPUvuci.Text = "Изабери вредности"
        Me.btnNPUvuci.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNPUvuci.UseVisualStyleBackColor = False
        Me.btnNPUvuci.Visible = False
        '
        'tUvuci
        '
        Me.tUvuci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tUvuci.Location = New System.Drawing.Point(519, 389)
        Me.tUvuci.MaxLength = 1000000
        Me.tUvuci.Multiline = True
        Me.tUvuci.Name = "tUvuci"
        Me.tUvuci.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tUvuci.Size = New System.Drawing.Size(121, 109)
        Me.tUvuci.TabIndex = 104
        Me.tUvuci.Visible = False
        Me.tUvuci.WordWrap = False
        '
        'panelPamtiOkvir
        '
        Me.panelPamtiOkvir.BackColor = System.Drawing.Color.Linen
        Me.panelPamtiOkvir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPamtiOkvir.Controls.Add(Me.lblNPnaziv)
        Me.panelPamtiOkvir.Controls.Add(Me.ButtonNPCancel)
        Me.panelPamtiOkvir.Controls.Add(Me.ButtonNPSacuvajUslov)
        Me.panelPamtiOkvir.Controls.Add(Me.tp_naziv)
        Me.panelPamtiOkvir.Controls.Add(Me.lblNPNapomena)
        Me.panelPamtiOkvir.Controls.Add(Me.tp_napomena)
        Me.panelPamtiOkvir.Location = New System.Drawing.Point(297, 115)
        Me.panelPamtiOkvir.Name = "panelPamtiOkvir"
        Me.panelPamtiOkvir.Size = New System.Drawing.Size(623, 175)
        Me.panelPamtiOkvir.TabIndex = 10000051
        Me.panelPamtiOkvir.Visible = False
        '
        'lblNPnaziv
        '
        Me.lblNPnaziv.AutoSize = True
        Me.lblNPnaziv.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPnaziv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNPnaziv.Location = New System.Drawing.Point(20, 13)
        Me.lblNPnaziv.Name = "lblNPnaziv"
        Me.lblNPnaziv.Size = New System.Drawing.Size(191, 13)
        Me.lblNPnaziv.TabIndex = 10000050
        Me.lblNPnaziv.Text = "Назив критеријума за претрагу"
        '
        'ButtonNPCancel
        '
        Me.ButtonNPCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNPCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonNPCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNPCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNPCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNPCancel.Location = New System.Drawing.Point(67, 133)
        Me.ButtonNPCancel.Name = "ButtonNPCancel"
        Me.ButtonNPCancel.Size = New System.Drawing.Size(136, 25)
        Me.ButtonNPCancel.TabIndex = 10000055
        Me.ButtonNPCancel.Text = "Cancel"
        Me.ButtonNPCancel.UseVisualStyleBackColor = False
        '
        'ButtonNPSacuvajUslov
        '
        Me.ButtonNPSacuvajUslov.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNPSacuvajUslov.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonNPSacuvajUslov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNPSacuvajUslov.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNPSacuvajUslov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNPSacuvajUslov.Location = New System.Drawing.Point(466, 132)
        Me.ButtonNPSacuvajUslov.Name = "ButtonNPSacuvajUslov"
        Me.ButtonNPSacuvajUslov.Size = New System.Drawing.Size(136, 25)
        Me.ButtonNPSacuvajUslov.TabIndex = 10000054
        Me.ButtonNPSacuvajUslov.Text = "Сачувај"
        Me.ButtonNPSacuvajUslov.UseVisualStyleBackColor = False
        '
        'tp_naziv
        '
        Me.tp_naziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tp_naziv.Location = New System.Drawing.Point(67, 33)
        Me.tp_naziv.MaxLength = 20
        Me.tp_naziv.Name = "tp_naziv"
        Me.tp_naziv.Size = New System.Drawing.Size(535, 22)
        Me.tp_naziv.TabIndex = 10000052
        '
        'lblNPNapomena
        '
        Me.lblNPNapomena.AutoSize = True
        Me.lblNPNapomena.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPNapomena.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNPNapomena.Location = New System.Drawing.Point(20, 56)
        Me.lblNPNapomena.Name = "lblNPNapomena"
        Me.lblNPNapomena.Size = New System.Drawing.Size(64, 13)
        Me.lblNPNapomena.TabIndex = 10000053
        Me.lblNPNapomena.Text = "Напомена"
        '
        'tp_napomena
        '
        Me.tp_napomena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tp_napomena.Location = New System.Drawing.Point(67, 76)
        Me.tp_napomena.MaxLength = 255
        Me.tp_napomena.Multiline = True
        Me.tp_napomena.Name = "tp_napomena"
        Me.tp_napomena.Size = New System.Drawing.Size(535, 50)
        Me.tp_napomena.TabIndex = 10000051
        '
        'dgA
        '
        Me.dgA.AllowUserToAddRows = False
        Me.dgA.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgA.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgA.GridColor = System.Drawing.Color.DarkGray
        Me.dgA.Location = New System.Drawing.Point(644, 389)
        Me.dgA.Name = "dgA"
        Me.dgA.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgA.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgA.RowTemplate.Height = 25
        Me.dgA.Size = New System.Drawing.Size(59, 109)
        Me.dgA.TabIndex = 10000052
        Me.dgA.Visible = False
        '
        'txtUslov
        '
        Me.txtUslov.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUslov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUslov.Location = New System.Drawing.Point(519, 504)
        Me.txtUslov.MaxLength = 255
        Me.txtUslov.Multiline = True
        Me.txtUslov.Name = "txtUslov"
        Me.txtUslov.ReadOnly = True
        Me.txtUslov.Size = New System.Drawing.Size(186, 34)
        Me.txtUslov.TabIndex = 10000053
        Me.txtUslov.Visible = False
        '
        'txtPOM
        '
        Me.txtPOM.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOM.Location = New System.Drawing.Point(519, 541)
        Me.txtPOM.MaxLength = 255
        Me.txtPOM.Multiline = True
        Me.txtPOM.Name = "txtPOM"
        Me.txtPOM.ReadOnly = True
        Me.txtPOM.Size = New System.Drawing.Size(186, 34)
        Me.txtPOM.TabIndex = 10000054
        Me.txtPOM.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(651, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(54, 66)
        Me.Panel1.TabIndex = 97
        Me.Panel1.Visible = False
        '
        'tvBaza
        '
        Me.tvBaza.AllowDrop = True
        Me.tvBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvBaza.CheckBoxes = True
        Me.tvBaza.ItemHeight = 16
        Me.tvBaza.Location = New System.Drawing.Point(594, 317)
        Me.tvBaza.Name = "tvBaza"
        Me.tvBaza.Size = New System.Drawing.Size(51, 66)
        Me.tvBaza.TabIndex = 77
        Me.tvBaza.Visible = False
        '
        'mnuColumnSve
        '
        Me.mnuColumnSve.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuColumnSve.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.xsum, Me.xmin, Me.xmax, Me.xcount, Me.xavg, Me.ToolStripSeparator2, Me.xgroup, Me.ToolStripSeparator1, Me.xhide, Me.xunhide, Me.ToolStripSeparator6, Me.xsort, Me.xmcs, Me.ToolStripSeparator11, Me.xfind, Me.ToolStripSeparator12, Me.xfilter, Me.xunfilter, Me.ToolStripSeparator15, Me.xBTF, Me.xSTB})
        Me.mnuColumnSve.Name = "mnuColumn"
        Me.mnuColumnSve.ShowCheckMargin = True
        Me.mnuColumnSve.Size = New System.Drawing.Size(199, 430)
        '
        'xsum
        '
        Me.xsum.Image = CType(resources.GetObject("xsum.Image"), System.Drawing.Image)
        Me.xsum.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.xsum.Name = "xsum"
        Me.xsum.Size = New System.Drawing.Size(198, 26)
        Me.xsum.Text = "Sum"
        '
        'xmin
        '
        Me.xmin.Name = "xmin"
        Me.xmin.Size = New System.Drawing.Size(198, 26)
        Me.xmin.Text = "Min"
        '
        'xmax
        '
        Me.xmax.Name = "xmax"
        Me.xmax.Size = New System.Drawing.Size(198, 26)
        Me.xmax.Text = "Max"
        '
        'xcount
        '
        Me.xcount.Name = "xcount"
        Me.xcount.Size = New System.Drawing.Size(198, 26)
        Me.xcount.Text = "Count"
        '
        'xavg
        '
        Me.xavg.Name = "xavg"
        Me.xavg.Size = New System.Drawing.Size(198, 26)
        Me.xavg.Text = "Average"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(195, 6)
        '
        'xgroup
        '
        Me.xgroup.Name = "xgroup"
        Me.xgroup.Size = New System.Drawing.Size(198, 26)
        Me.xgroup.Text = "Group by"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'xhide
        '
        Me.xhide.Name = "xhide"
        Me.xhide.Size = New System.Drawing.Size(198, 26)
        Me.xhide.Text = "Hide column"
        '
        'xunhide
        '
        Me.xunhide.Name = "xunhide"
        Me.xunhide.Size = New System.Drawing.Size(198, 26)
        Me.xunhide.Text = "Unhide all"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(195, 6)
        '
        'xsort
        '
        Me.xsort.Name = "xsort"
        Me.xsort.Size = New System.Drawing.Size(198, 26)
        Me.xsort.Text = "Sort"
        Me.xsort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'xmcs
        '
        Me.xmcs.Name = "xmcs"
        Me.xmcs.Size = New System.Drawing.Size(198, 26)
        Me.xmcs.Text = "Multi column sort"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(195, 6)
        '
        'xfind
        '
        Me.xfind.Name = "xfind"
        Me.xfind.Size = New System.Drawing.Size(198, 26)
        Me.xfind.Text = "Find"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(195, 6)
        '
        'xfilter
        '
        Me.xfilter.Name = "xfilter"
        Me.xfilter.Size = New System.Drawing.Size(198, 26)
        Me.xfilter.Text = "Show top levels"
        '
        'xunfilter
        '
        Me.xunfilter.Name = "xunfilter"
        Me.xunfilter.Size = New System.Drawing.Size(198, 26)
        Me.xunfilter.Text = "Show all"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(195, 6)
        '
        'xBTF
        '
        Me.xBTF.Name = "xBTF"
        Me.xBTF.Size = New System.Drawing.Size(198, 26)
        Me.xBTF.Text = "Bring to front"
        '
        'xSTB
        '
        Me.xSTB.Name = "xSTB"
        Me.xSTB.Size = New System.Drawing.Size(198, 26)
        Me.xSTB.Text = "Send to back"
        '
        'mnuColumn
        '
        Me.mnuColumn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.mnuColumn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.amin, Me.amax, Me.acount, Me.ToolStripSeparator3, Me.agroup, Me.ToolStripSeparator4, Me.ahide, Me.aunhide, Me.ToolStripSeparator7, Me.asort, Me.amcs, Me.ToolStripSeparator10, Me.afind, Me.ToolStripSeparator13, Me.afilter, Me.aunfilter, Me.ToolStripSeparator16, Me.aBTF, Me.aSTB})
        Me.mnuColumn.Name = "mnuColumn"
        Me.mnuColumn.ShowCheckMargin = True
        Me.mnuColumn.Size = New System.Drawing.Size(194, 326)
        '
        'amin
        '
        Me.amin.Name = "amin"
        Me.amin.Size = New System.Drawing.Size(193, 22)
        Me.amin.Text = "Min"
        '
        'amax
        '
        Me.amax.Name = "amax"
        Me.amax.Size = New System.Drawing.Size(193, 22)
        Me.amax.Text = "Max"
        '
        'acount
        '
        Me.acount.Name = "acount"
        Me.acount.Size = New System.Drawing.Size(193, 22)
        Me.acount.Text = "Count"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(190, 6)
        '
        'agroup
        '
        Me.agroup.Name = "agroup"
        Me.agroup.Size = New System.Drawing.Size(193, 22)
        Me.agroup.Text = "Group by"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(190, 6)
        '
        'ahide
        '
        Me.ahide.Name = "ahide"
        Me.ahide.Size = New System.Drawing.Size(193, 22)
        Me.ahide.Text = "Hide column"
        '
        'aunhide
        '
        Me.aunhide.Name = "aunhide"
        Me.aunhide.Size = New System.Drawing.Size(193, 22)
        Me.aunhide.Text = "Unhide all"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(190, 6)
        '
        'asort
        '
        Me.asort.Name = "asort"
        Me.asort.Size = New System.Drawing.Size(193, 22)
        Me.asort.Text = "Sort"
        '
        'amcs
        '
        Me.amcs.Name = "amcs"
        Me.amcs.Size = New System.Drawing.Size(193, 22)
        Me.amcs.Text = "Multi column sort"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(190, 6)
        '
        'afind
        '
        Me.afind.Name = "afind"
        Me.afind.Size = New System.Drawing.Size(193, 22)
        Me.afind.Text = "Find"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(190, 6)
        '
        'afilter
        '
        Me.afilter.Name = "afilter"
        Me.afilter.Size = New System.Drawing.Size(193, 22)
        Me.afilter.Text = "Show top levels"
        '
        'aunfilter
        '
        Me.aunfilter.Name = "aunfilter"
        Me.aunfilter.Size = New System.Drawing.Size(193, 22)
        Me.aunfilter.Text = "Show all"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(190, 6)
        '
        'aBTF
        '
        Me.aBTF.Name = "aBTF"
        Me.aBTF.Size = New System.Drawing.Size(193, 22)
        Me.aBTF.Text = "Bring to front"
        '
        'aSTB
        '
        Me.aSTB.Name = "aSTB"
        Me.aSTB.Size = New System.Drawing.Size(193, 22)
        Me.aSTB.Text = "Send to back"
        '
        'mnuUngroup
        '
        Me.mnuUngroup.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.mnuUngroup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bungroup, Me.ToolStripSeparator5, Me.bunhide, Me.ToolStripSeparator8, Me.bsort, Me.bmcs, Me.ToolStripSeparator9, Me.bFind, Me.ToolStripSeparator14, Me.bfilter, Me.bunfilter, Me.ToolStripSeparator20, Me.bBTF, Me.bSTB})
        Me.mnuUngroup.Name = "mnuColumn"
        Me.mnuUngroup.ShowCheckMargin = True
        Me.mnuUngroup.Size = New System.Drawing.Size(194, 232)
        '
        'bungroup
        '
        Me.bungroup.Name = "bungroup"
        Me.bungroup.Size = New System.Drawing.Size(193, 22)
        Me.bungroup.Text = "Ungroup"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(190, 6)
        '
        'bunhide
        '
        Me.bunhide.Name = "bunhide"
        Me.bunhide.Size = New System.Drawing.Size(193, 22)
        Me.bunhide.Text = "Unhide all"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(190, 6)
        '
        'bsort
        '
        Me.bsort.Name = "bsort"
        Me.bsort.Size = New System.Drawing.Size(193, 22)
        Me.bsort.Text = "Sort"
        '
        'bmcs
        '
        Me.bmcs.Name = "bmcs"
        Me.bmcs.Size = New System.Drawing.Size(193, 22)
        Me.bmcs.Text = "Multi column sort"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(190, 6)
        '
        'bFind
        '
        Me.bFind.Name = "bFind"
        Me.bFind.Size = New System.Drawing.Size(193, 22)
        Me.bFind.Text = "Find"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(190, 6)
        '
        'bfilter
        '
        Me.bfilter.Name = "bfilter"
        Me.bfilter.Size = New System.Drawing.Size(193, 22)
        Me.bfilter.Text = "Show top levels"
        '
        'bunfilter
        '
        Me.bunfilter.Name = "bunfilter"
        Me.bunfilter.Size = New System.Drawing.Size(193, 22)
        Me.bunfilter.Text = "Show all"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(190, 6)
        '
        'bBTF
        '
        Me.bBTF.Name = "bBTF"
        Me.bBTF.Size = New System.Drawing.Size(193, 22)
        Me.bBTF.Text = "Bring to front"
        '
        'bSTB
        '
        Me.bSTB.Name = "bSTB"
        Me.bSTB.Size = New System.Drawing.Size(193, 22)
        Me.bSTB.Text = "Sent to front"
        '
        'bAgregiranje
        '
        Me.bAgregiranje.BackColor = System.Drawing.Color.Transparent
        Me.bAgregiranje.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bAgregiranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAgregiranje.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAgregiranje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAgregiranje.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bAgregiranje.Location = New System.Drawing.Point(551, 53)
        Me.bAgregiranje.Margin = New System.Windows.Forms.Padding(0)
        Me.bAgregiranje.Name = "bAgregiranje"
        Me.bAgregiranje.Size = New System.Drawing.Size(136, 23)
        Me.bAgregiranje.TabIndex = 105
        Me.bAgregiranje.Tag = "<<<<<<<<<<<<"
        Me.bAgregiranje.Text = "Агрегирање"
        Me.bAgregiranje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bAgregiranje.UseVisualStyleBackColor = False
        Me.bAgregiranje.Visible = False
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.Transparent
        Me.bClose.Image = CType(resources.GetObject("bClose.Image"), System.Drawing.Image)
        Me.bClose.Location = New System.Drawing.Point(711, 317)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(16, 16)
        Me.bClose.TabIndex = 10000055
        Me.bClose.TabStop = False
        Me.bClose.Visible = False
        '
        'lblPorukaUslov
        '
        Me.lblPorukaUslov.AutoSize = True
        Me.lblPorukaUslov.BackColor = System.Drawing.Color.Transparent
        Me.lblPorukaUslov.Location = New System.Drawing.Point(764, 317)
        Me.lblPorukaUslov.Name = "lblPorukaUslov"
        Me.lblPorukaUslov.Size = New System.Drawing.Size(49, 14)
        Me.lblPorukaUslov.TabIndex = 10000056
        Me.lblPorukaUslov.Text = "Label1"
        '
        'mnuWithFunction
        '
        Me.mnuWithFunction.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuWithFunction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dhide, Me.dunhide, Me.ToolStripSeparator17, Me.dsort, Me.dmcs, Me.ToolStripSeparator18, Me.dfind, Me.ToolStripSeparator19, Me.dfilter, Me.dunfilter, Me.ToolStripSeparator21, Me.dBTF, Me.dSTB})
        Me.mnuWithFunction.Name = "mnuColumn"
        Me.mnuWithFunction.ShowCheckMargin = True
        Me.mnuWithFunction.Size = New System.Drawing.Size(194, 226)
        '
        'dhide
        '
        Me.dhide.Name = "dhide"
        Me.dhide.Size = New System.Drawing.Size(193, 22)
        Me.dhide.Text = "Hide column"
        '
        'dunhide
        '
        Me.dunhide.Name = "dunhide"
        Me.dunhide.Size = New System.Drawing.Size(193, 22)
        Me.dunhide.Text = "Unhide all"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(190, 6)
        '
        'dsort
        '
        Me.dsort.Name = "dsort"
        Me.dsort.Size = New System.Drawing.Size(193, 22)
        Me.dsort.Text = "Sort"
        Me.dsort.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'dmcs
        '
        Me.dmcs.Name = "dmcs"
        Me.dmcs.Size = New System.Drawing.Size(193, 22)
        Me.dmcs.Text = "Multi column sort"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(190, 6)
        '
        'dfind
        '
        Me.dfind.Name = "dfind"
        Me.dfind.Size = New System.Drawing.Size(193, 22)
        Me.dfind.Text = "Find"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(190, 6)
        '
        'dfilter
        '
        Me.dfilter.Name = "dfilter"
        Me.dfilter.Size = New System.Drawing.Size(193, 22)
        Me.dfilter.Text = "Show top levels"
        '
        'dunfilter
        '
        Me.dunfilter.Name = "dunfilter"
        Me.dunfilter.Size = New System.Drawing.Size(193, 22)
        Me.dunfilter.Text = "Show all"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(190, 6)
        '
        'dBTF
        '
        Me.dBTF.Name = "dBTF"
        Me.dBTF.Size = New System.Drawing.Size(193, 22)
        Me.dBTF.Text = "Bring to front"
        '
        'dSTB
        '
        Me.dSTB.Name = "dSTB"
        Me.dSTB.Size = New System.Drawing.Size(193, 22)
        Me.dSTB.Text = "Send to back"
        '
        'chStart
        '
        Me.chStart.AutoSize = True
        Me.chStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chStart.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chStart.Location = New System.Drawing.Point(7, 10)
        Me.chStart.Name = "chStart"
        Me.chStart.Size = New System.Drawing.Size(74, 16)
        Me.chStart.TabIndex = 10000057
        Me.chStart.Text = "starts with"
        Me.chStart.UseVisualStyleBackColor = True
        '
        'chEnd
        '
        Me.chEnd.AutoSize = True
        Me.chEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chEnd.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEnd.Location = New System.Drawing.Point(104, 10)
        Me.chEnd.Name = "chEnd"
        Me.chEnd.Size = New System.Drawing.Size(68, 16)
        Me.chEnd.TabIndex = 10000058
        Me.chEnd.Text = "ends with"
        Me.chEnd.UseVisualStyleBackColor = True
        '
        'chContanes
        '
        Me.chContanes.AutoSize = True
        Me.chContanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chContanes.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chContanes.Location = New System.Drawing.Point(195, 10)
        Me.chContanes.Name = "chContanes"
        Me.chContanes.Size = New System.Drawing.Size(64, 16)
        Me.chContanes.TabIndex = 10000059
        Me.chContanes.Text = "contains"
        Me.chContanes.UseVisualStyleBackColor = True
        '
        'GBLike
        '
        Me.GBLike.BackColor = System.Drawing.Color.Transparent
        Me.GBLike.Controls.Add(Me.chEnd)
        Me.GBLike.Controls.Add(Me.chContanes)
        Me.GBLike.Controls.Add(Me.chStart)
        Me.GBLike.Location = New System.Drawing.Point(746, 332)
        Me.GBLike.Margin = New System.Windows.Forms.Padding(1)
        Me.GBLike.Name = "GBLike"
        Me.GBLike.Padding = New System.Windows.Forms.Padding(1)
        Me.GBLike.Size = New System.Drawing.Size(257, 32)
        Me.GBLike.TabIndex = 10000060
        Me.GBLike.TabStop = False
        Me.GBLike.Visible = False
        '
        'clbAplikacija
        '
        Me.clbAplikacija.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.clbAplikacija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbAplikacija.CheckOnClick = True
        Me.clbAplikacija.FormattingEnabled = True
        Me.clbAplikacija.Location = New System.Drawing.Point(297, 29)
        Me.clbAplikacija.Name = "clbAplikacija"
        Me.clbAplikacija.Size = New System.Drawing.Size(131, 19)
        Me.clbAplikacija.TabIndex = 10000061
        Me.clbAplikacija.Visible = False
        '
        'lblAplikacija
        '
        Me.lblAplikacija.AutoSize = True
        Me.lblAplikacija.BackColor = System.Drawing.Color.Transparent
        Me.lblAplikacija.Location = New System.Drawing.Point(2, 6)
        Me.lblAplikacija.Name = "lblAplikacija"
        Me.lblAplikacija.Size = New System.Drawing.Size(215, 14)
        Me.lblAplikacija.TabIndex = 10000062
        Me.lblAplikacija.Text = "Изаберите апликацију из ИСТ-а"
        '
        'txtTraziPoCLB
        '
        Me.txtTraziPoCLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTraziPoCLB.Location = New System.Drawing.Point(297, 6)
        Me.txtTraziPoCLB.MaxLength = 20
        Me.txtTraziPoCLB.Name = "txtTraziPoCLB"
        Me.txtTraziPoCLB.Size = New System.Drawing.Size(131, 22)
        Me.txtTraziPoCLB.TabIndex = 10000063
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
        Me.PanelTop.Size = New System.Drawing.Size(1134, 40)
        Me.PanelTop.TabIndex = 10000065
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
        Me.b3.Size = New System.Drawing.Size(240, 32)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1094, 0)
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
        Me.Logovan.Location = New System.Drawing.Point(886, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.HP.SetShowHelp(Me.Logovan, True)
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelContext
        '
        Me.PanelContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContext.Controls.Add(Me.btnDown)
        Me.PanelContext.Controls.Add(Me.dgA)
        Me.PanelContext.Controls.Add(Me.lblAplikacija)
        Me.PanelContext.Controls.Add(Me.GBLike)
        Me.PanelContext.Controls.Add(Me.Panel1)
        Me.PanelContext.Controls.Add(Me.tvBaza)
        Me.PanelContext.Controls.Add(Me.ButtonNPIzlaz)
        Me.PanelContext.Controls.Add(Me.GB2)
        Me.PanelContext.Controls.Add(Me.txtTraziPoCLB)
        Me.PanelContext.Controls.Add(Me.btnNPUvuci)
        Me.PanelContext.Controls.Add(Me.clbAplikacija)
        Me.PanelContext.Controls.Add(Me.tUvuci)
        Me.PanelContext.Controls.Add(Me.lblPorukaUslov)
        Me.PanelContext.Controls.Add(Me.panelPamtiOkvir)
        Me.PanelContext.Controls.Add(Me.bAgregiranje)
        Me.PanelContext.Controls.Add(Me.bClose)
        Me.PanelContext.Controls.Add(Me.txtUslov)
        Me.PanelContext.Controls.Add(Me.txtPOM)
        Me.PanelContext.Controls.Add(Me.cbRazliciti)
        Me.PanelContext.Controls.Add(Me.tabKontrola)
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(0, 40)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(1134, 662)
        Me.PanelContext.TabIndex = 10000066
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDown.ForeColor = System.Drawing.Color.Black
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(428, 6)
        Me.btnDown.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(23, 22)
        Me.btnDown.TabIndex = 10000065
        Me.btnDown.TabStop = False
        Me.btnDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'FormNaprednaPretragaUnos
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = False
        Me.ClientSize = New System.Drawing.Size(1134, 702)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormNaprednaPretragaUnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB2.ResumeLayout(False)
        Me.panelPamtiOkvir.ResumeLayout(False)
        Me.panelPamtiOkvir.PerformLayout()
        CType(Me.dgA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuColumnSve.ResumeLayout(False)
        Me.mnuColumn.ResumeLayout(False)
        Me.mnuUngroup.ResumeLayout(False)
        CType(Me.bClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuWithFunction.ResumeLayout(False)
        Me.GBLike.ResumeLayout(False)
        Me.GBLike.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelContext.ResumeLayout(False)
        Me.PanelContext.PerformLayout()
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
    Dim brCntl As Integer
    Dim ISTkon As String = ""
    Dim ms As String
    Dim dtIST As New System.Data.DataTable
    Dim dtISTBaze As New System.Data.DataTable
    Dim vidljiviTV As TreeView
    Dim vidljiviPanel As Panel
    Dim vidljiviGridLabel As Label
    Dim vidljiviPanelGrid As Panel
    Dim vidljiviGrid As DataGridView
    Private mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim vt As String
    Dim DSzaExport As New System.Data.DataSet
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim lokalno As Boolean
    Dim jezik As String
    Dim konDepo As String
    Dim txtmode As String
    Dim panelmenucollapse As Boolean

    Public Sub New(ByVal ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal s As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                    ByVal mconn As String, ByVal txtInst As String, ByVal txtPismo As String,
                    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
                    ByVal txt_DSBrisanjeBaza As String, ByVal txtmode As String, ByVal jezik As String, ByVal panelmenucollapse As Boolean)

        Me.New()
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.jezik = jezik
        Call SetLang()
        Me.panelmenucollapse = panelmenucollapse
        Me.txtmode = txtmode
        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        lokalno = False
        'NS je trazio da za njih se ne radi DEPO pri brisanju
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True
        Me.ms = s
        Me.Logovan.Text = GetUserName.ToString.Trim
        Me.mvt = ucvt
        vt = ucvt.G.ToString + "-" + String.Format("{0:d2}", ucvt.M) + "-01"

        Dim sifapp As String = ri.SIFIST.Trim
        b3.Text = sifapp + "    " + String.Format("{0:d2}", ucvt.M) + " / " + ucvt.G.ToString

        Me.ISTkon = mconn

        'Dim y As Integer = Me.GB1.Location.Y
        'Me.Text = Me.Text + " " + txtInst + " - " + ri.Naziv.Trim

        '*****************
        Call napunidtIST()
        '*****************
        brCntl = 0

        Dim strSQl As String = "select  distinct sifist as valuemember,sifist+' '+naziv as displaymember from vIST('" + vt + "')  order by 1"

        Call popuniclb(clbAplikacija, strSQl, Me.ISTkon, Me.jezik)
        Call dajIzbor()
        'AddHandler Me.Paint, AddressOf DrawBorder

        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Call srediformu()

        Me.jezik = jezik

        konDepo = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.ms)
        Me.txtTraziPoCLB.Focus()
    End Sub

    Sub dajIzbor()

        Dim ww As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width()
        Dim x As Integer = Me.clbAplikacija.Location.X

        Me.clbAplikacija.Height = Me.Height \ 4
        Me.clbAplikacija.Width = ww - x - 35
        Me.clbAplikacija.Width = 915

        clbAplikacija.Top = Me.lblAplikacija.Top + Me.lblAplikacija.Height + 22
        clbAplikacija.Left = lblAplikacija.Left
        Me.clbAplikacija.Visible = False

        txtTraziPoCLB.Top = clbAplikacija.Top - Me.txtTraziPoCLB.Height
        txtTraziPoCLB.Width = Me.clbAplikacija.Width
        txtTraziPoCLB.Left = clbAplikacija.Left
        Me.txtTraziPoCLB.Visible = True
        txtTraziPoCLB.Focus()

        btnDown.Location = New System.Drawing.Point(txtTraziPoCLB.Location.X + txtTraziPoCLB.Width + 0, txtTraziPoCLB.Location.Y)

    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        Me.clbAplikacija.Visible = Not Me.clbAplikacija.Visible
        Me.txtTraziPoCLB.Focus()
    End Sub



    Private Sub txtTraziPoCLB_TextChanged(sender As Object, e As EventArgs) Handles txtTraziPoCLB.TextChanged
        Me.clbAplikacija.Visible = True
        Dim vred As String = txtTraziPoCLB.Text
        Dim dv As New System.Data.DataView
        dv = clbAplikacija.DataSource
        If IsNumeric(vred) = False Then
            Dim vredCir As String = konverzijaLatCir(vred)
            Dim vredLat As String = konverzijaCirLat(vred)
            dv.RowFilter = "displaymember LIKE '%" & vredCir & "%' OR displaymember LIKE '%" & vredLat & "%'"
        Else
            dv.RowFilter = "displaymember Like '%" & vred & "%'"
        End If
        clbAplikacija.DataSource = dv

        clbAplikacija.Height = dv.Count * 20
        If Me.clbAplikacija.Height > Me.Height \ 4 Then Me.clbAplikacija.Height = Me.Height \ 4
    End Sub

    Private Sub clbAplikacija_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAplikacija.ItemCheck
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To Me.clbAplikacija.Items.Count - 1 Step 1
                If i <> e.Index Then
                    Me.clbAplikacija.SetItemChecked(i, False)
                End If
            Next i
            Call popuniTv(clbAplikacija.SelectedValue.Trim)

            ''msg 290
            Dim msgtxt290 As String = getMessageText(dtMessages, "290", Me.jezik)
            ''msg 291
            Dim msgtxt291 As String = getMessageText(dtMessages, "291", Me.jezik)

            Dim tekst As String = "" _
                    + msgtxt290 + nvrd + nvrd _
                    + msgtxt291

            Call porukaUslov(tekst)
            Me.lblAplikacija.Text = clbAplikacija.Text.Trim
            Me.lblAplikacija.SendToBack()
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.clbAplikacija.Visible = False
    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formNaprednaPretraga")
        lblAplikacija.Text = getControlText2(dt, "lblAplikacija", Me.jezik)
        ButtonNPPonistiSve.Text = getControlText2(dt, "ButtonNPPonistiSve", Me.jezik)
        btnNPStariUpit.Text = getControlText2(dt, "btnNPStariUpit", Me.jezik)
        btnNPSacuvajUslov.Text = getControlText2(dt, "btnNPSacuvajUslov", Me.jezik)
        ButtonNPPonisti.Text = getControlText2(dt, "ButtonNPPonisti", Me.jezik)
        ButtonNPTrazi.Text = getControlText2(dt, "ButtonNPTrazi", Me.jezik)
        ButtonNPIzlaz.Text = getControlText2(dt, "ButtonNPIzlaz", Me.jezik)
        cbRazliciti.Text = getControlText2(dt, "cbRazliciti", Me.jezik)
        btnNPUvuci.Text = getControlText2(dt, "btnNPUvuci", Me.jezik)
        lblNPnaziv.Text = getControlText2(dt, "lblNPnaziv", Me.jezik)
        ButtonNPCancel.Text = getControlText2(dt, "ButtonNPCancel", Me.jezik)
        ButtonNPSacuvajUslov.Text = getControlText2(dt, "ButtonNPSacuvajUslov", Me.jezik)
        lblNPNapomena.Text = getControlText2(dt, "lblNPNapomena", Me.jezik)
        bAgregiranje.Text = getControlText2(dt, "bAgregiranje", Me.jezik)
        Me.b3.Text = ""


    End Sub

    Private Sub txtAplikacija_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Public Sub txtAplikacija_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Sub srediformu()
        Dim ww As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width()
        Dim hh As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height()

        Dim x As Integer = ww - (Me.GB2.Width + 10)

        Me.ButtonNPIzlaz.Location = New System.Drawing.Point(x + 8, 8)
        Dim y As Integer = Me.ButtonNPIzlaz.Location.Y + Me.ButtonNPIzlaz.Height + 5
        Me.GB2.Location = New System.Drawing.Point(x, y)
    End Sub

    Sub napunidtIST()
        Dim strSQl As String = "select *,month(vod) as mmod, year(vod) as ggod, month(vdo) as mmdo, year(vdo) as ggdo from IST"
        dtIST.Clear()
        Try
            dtIST = izvrsiSQLvratiDT(strSQl, Me.ISTkon, Nothing)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetQuotedName(ByVal label As String) As String
        GetQuotedName = ""
        Dim pos1 As Integer
        Dim pos2 As Integer
        pos1 = label.IndexOf("\") + 1
        pos2 = label.LastIndexOf("\")
        If ((pos2 - pos1) > 0) Then
            GetQuotedName(label.Substring(pos1, pos2 - pos1))
        Else
            GetQuotedName = ""
        End If
    End Function

    Function prazanTreeView(ByVal tv As System.Windows.Forms.TreeView) As Boolean
        Dim nTabela As System.Windows.Forms.TreeNode
        Dim nPolje As System.Windows.Forms.TreeNode
        prazanTreeView = True
        For Each nTabela In tv.Nodes
            If nTabela.Checked Then
                prazanTreeView = False
                Exit For
            End If
            For Each nPolje In nTabela.Nodes
                If nPolje.Checked Then
                    prazanTreeView = False
                    Exit For
                End If
            Next nPolje
        Next nTabela
    End Function

    Sub porukaUslov(ByVal poruka As String)
        Me.lblPorukaUslov.Text = poruka
        lblPorukaUslov.Font = New System.Drawing.Font("Verdana", 8.0!, FontStyle.Bold)
        Me.lblPorukaUslov.Left = vidljiviPanel.Left
        Me.lblPorukaUslov.Top = vidljiviPanel.Top + 100

    End Sub

    Sub popuniTv(ByVal vrednost As String)
        Dim dtP As New System.Data.DataTable

        Dim sqlP As String = " select * from vIST('" + vt + "') where SifIst='" + vrednost + "' "

        Try
            dtP = izvrsiSQLvratiDT(sqlP, Me.ISTkon, Nothing)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Dim dISTPravaBaza As New System.Data.DataTable
        Dim sqlVB As String = " select server,baza,pravaBaza,konekcija,naziv,periodika,izrazODBC from vISTNPBazaServer ('" + vt + "') where SifIst='" + vrednost + "' "

        Try
            dISTPravaBaza = izvrsiSQLvratiDT(sqlVB, Me.ISTkon, Nothing)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Dim server As String = dISTPravaBaza.Rows(0).Item("server").ToString.Trim
        Dim baza As String = dISTPravaBaza.Rows(0).Item("pravabaza").ToString.Trim
        Dim serverBaza As String = server + "$" + baza
        'Me.kon = izrazODBC

        If dtP.Rows.Count <> 1 Then
            Dim poruka As String = "Nešto nije ok sa tabelom IST!"
            ISTMessageBox.Show(poruka, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            'sakrij sve tv i pripadajuce panele
            For Each cntl As Control In Me.Controls
                If cntl.Name.Length >= 3 AndAlso cntl.Name.Substring(0, 3) = "tv_" OrElse
                   cntl.Name.Length >= 6 AndAlso cntl.Name.Substring(0, 6) = "panel_" Then cntl.Visible = False
            Next

            'popuni tvBaza sa podacima iz ISTa
            Dim tv As New TreeView
            Dim tvime As String = "tv_" & vrednost
            Dim gridime As String = "dg_" & vrednost
            Dim panelime As String = "panel_" & vrednost
            Dim panelgridime As String = "pp_" & vrednost

            Dim ptv As TreeView = NadjiKontrolu(PanelContext, tvime)
            Dim pGrid As DataGridView = NadjiKontroluTab(Me.tabKontrola, gridime)
            Dim pPanel As Panel = NadjiKontrolu(PanelContext, panelime)
            Dim pPanelGrid As Panel = NadjiKontroluTab(Me.tabKontrola, panelgridime)
            If ptv Is Nothing Then
                tv.Name = tvime
                tv.Location = New System.Drawing.Point(16, 80)
                tv.Size = (New System.Drawing.Size(376, 227))
                tv.AllowDrop = True
                tv.CheckBoxes = True
                tv.BorderStyle = BorderStyle.FixedSingle
                tv.Tag = serverBaza
                PanelContext.Controls.Add(tv)

                vidljiviTV = tv
                AddHandler tv.AfterCheck, AddressOf Me.tv_AfterCheck
                AddHandler tv.DragDrop, AddressOf Me.tv_DragDrop
                AddHandler tv.DragOver, AddressOf Me.tv_DragOver
                AddHandler tv.ItemDrag, AddressOf Me.tv_ItemDrag
                AddHandler tv.GiveFeedback, AddressOf Me.tv_giveFeedback
                AddHandler tv.NodeMouseDoubleClick, AddressOf Me.tv_NodeMouseDoubleClick

                Dim panel As New Panel
                panel.Name = "panel_" & vrednost
                panel.Location = New System.Drawing.Point(398 + Me.PanelTop.Height, 62)
                panel.Size = (New System.Drawing.Size(548, 245))
                panel.Width = Me.Width - vidljiviTV.Width - Me.GB2.Width - 100
                panel.AllowDrop = True
                PanelContext.Controls.Add(panel)
                vidljiviPanel = panel
                Call DajTabelePoljaISTzaTV(tv, vrednost)
            Else
                'postoji
                vidljiviTV = ptv
                vidljiviGrid = pGrid
                vidljiviPanel = pPanel
                vidljiviPanelGrid = pPanelGrid
                ptv.Visible = True
                If Not pGrid Is Nothing Then pGrid.Visible = True
                pPanel.Visible = True
            End If
        End If
    End Sub

    Sub DajTabelePoljaISTzaTV(ByVal tv As System.Windows.Forms.TreeView, ByVal sifist As String)

        Dim izrazODBC As String = ""
        tv.Nodes.Clear()
        Dim sql As String = "select * from vISTNPPolja('" + vt + "','" + sifist.Trim + "') where vrstaPolja <>'FP' order by tabela,rbr"

        Dim dISTPolja As New System.Data.DataTable
        dISTPolja.Clear()
        Try
            dISTPolja = izvrsiSQLvratiDT(sql, Me.ISTkon, Nothing)
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        If dISTPolja.Rows.Count > 0 Then
            Dim node As System.Windows.Forms.TreeNode
            Dim tabela As String = dISTPolja.Rows(0).Item("tabela").ToString.Trim.ToUpper
            Dim slTab As String = ""
            node = tv.Nodes.Add(tabela)
            node.Tag = node.Text
            Dim polje As String = dISTPolja.Rows(0).Item("polje").ToString.Trim
            Dim izraz As String = zamena(dISTPolja.Rows(0).Item("izraz").ToString.Trim)
            Dim cbo As String = srediIzraz(dISTPolja.Rows(0).Item("izraz").ToString.Trim, tabela, polje)
            Dim vrstapolja As String = dISTPolja.Rows(0).Item("vrstapolja").ToString.Trim
            Dim filter As String = dISTPolja.Rows(0).Item("filterovanoPoPolju").ToString.Trim
            Dim tippolja As String = dISTPolja.Rows(0).Item("tippolja").ToString.Trim
            Dim duzina As String = dISTPolja.Rows(0).Item("duzina").ToString.Trim
            Dim kljuc As String = dISTPolja.Rows(0).Item("kljuc").ToString.Trim

            node.Nodes.Add(polje)
            node.Nodes(node.Nodes.Count - 1).Tag = vrstapolja & "$" & izraz & "$" & filter & "$" & tippolja & "$" & duzina & "$" & tabela & "$" & kljuc & "$" & cbo
            For i As Integer = 1 To dISTPolja.Rows.Count - 1
                slTab = dISTPolja.Rows(i).Item("tabela").ToString.Trim.ToUpper
                If tabela <> slTab Then
                    tabela = slTab
                    node = tv.Nodes.Add(slTab)
                    node.Tag = node.Text
                End If
                polje = dISTPolja.Rows(i).Item("polje").ToString.Trim
                izraz = zamena(dISTPolja.Rows(i).Item("izraz").ToString.Trim)
                cbo = srediIzraz(dISTPolja.Rows(i).Item("izraz").ToString.Trim, tabela, polje)
                vrstapolja = dISTPolja.Rows(i).Item("vrstapolja").ToString.Trim
                filter = dISTPolja.Rows(i).Item("filterovanoPoPolju").ToString.Trim
                tippolja = dISTPolja.Rows(i).Item("tippolja").ToString.Trim
                duzina = dISTPolja.Rows(i).Item("duzina").ToString.Trim
                kljuc = dISTPolja.Rows(i).Item("kljuc").ToString.Trim

                node.Nodes.Add(polje)
                node.Nodes(node.Nodes.Count - 1).Tag = vrstapolja & "$" & izraz & "$" & filter & "$" & tippolja & "$" & duzina & "$" & tabela & "$" & kljuc & "$" & cbo
            Next
            tv.Visible = True
        End If
    End Sub

    Function srediIzraz(ByVal izraz As String, ByVal tabela As String, ByVal polje As String) As String
        Dim str As String = ""
        If izraz.Length > 0 Then
            ''zamena GGGMMM
            izraz = izraz.ToUpper.Trim
            izraz = Replace(izraz, "MULTILINE", "", 1, , CompareMethod.Text)
            izraz = Replace(izraz, "FONTBOLD", "", 1, , CompareMethod.Text)
            izraz = Replace(izraz, "BORDERNONE", "", 1, , CompareMethod.Text)
            izraz = Replace(izraz, "BORDERFIXED", "", 1, , CompareMethod.Text)
            izraz = Replace(izraz.Trim, "READONLY", "", 1, , CompareMethod.Text)
            izraz = Replace(izraz.Trim, "PDESNOP", "", 1, , CompareMethod.Text)
            izraz = Replace(izraz.Trim, "FRIGHTA", "", 1, , CompareMethod.Text)
            If Not (izraz Is Nothing) Then
                izraz = Replace(izraz, "$", "", 1, , CompareMethod.Text)
                izraz = strrpl(izraz, "{GGG}", "'" + Me.mvt.G.ToString + "'")
                izraz = strrpl(izraz, "{MMM}", "'" + String.Format("{0:d2}", Me.mvt.M) + "'")
                izraz = strrpl(izraz, "{YYY}", "'" + Me.mvt.G.ToString + "'")

                izraz = GGMMGoreDole(izraz, Me.mvt.G, Me.mvt.M)
                izraz = strrpl(izraz, "VRTACKA", Me.mvt.vtwhere(""))
                izraz = strrpl(izraz, "GGG", Me.mvt.GWhere(""))
                izraz = strrpl(izraz, "MMM", Me.mvt.mWhere(""))
                izraz = strrpl(izraz, "YYY", Me.mvt.YWhere(""))

                izraz = izraz.Replace(ChrW(26), "")
            End If
            If izraz Is Nothing Then izraz = ""
        End If

        If izraz.Length > 0 AndAlso izraz.Trim.ToUpper <> "LINKLABEL" Then
            If izraz.Length > 3 AndAlso izraz.Trim.Substring(0, 2) = "CB" Then
                Dim izvorCBO As String = ""
                Dim prikaziCBO As String = ""
                Dim upisiCBO As String = ""
                Dim prenesiCBO As String = ""
                Dim fromCL As String = ""
                Dim sta As String = izraz.Trim
                sta = sta.Replace("CBO{", "")
                sta = sta.Replace("CBW{", "")
                sta = sta.Substring(0, sta.Length - 1)
                sta = sta.Replace("}", "")
                Dim nizCB As String() = Microsoft.VisualBasic.Split(sta, ";")
                For ii As Integer = 0 To nizCB.GetUpperBound(0)
                    If nizCB(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                        izvorCBO = nizCB(ii).Replace("IZVOR=", "")

                        If izvorCBO.Trim.ToUpper.IndexOf("ORDER BY") > 0 Then
                            izvorCBO = izvorCBO.Substring(0, izvorCBO.Trim.ToUpper.IndexOf("ORDER BY") + 1)
                        End If

                        fromCL = izvorCBO.Substring(izvorCBO.ToUpper.IndexOf("FROM"))
                    End If
                    If nizCB(ii).Trim.ToUpper.IndexOf("PRIKAZI=") >= 0 Then
                        prikaziCBO = nizCB(ii).Replace("PRIKAZI=", "")
                    End If
                    If nizCB(ii).Trim.ToUpper.IndexOf("UBAZU=") >= 0 Then
                        upisiCBO = nizCB(ii).Replace("UBAZU=", "")
                    End If
                    If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                        izvorCBO = nizCB(ii).Replace("DATASOURCE=", "")
                        fromCL = izvorCBO.Substring(izvorCBO.ToUpper.IndexOf("FROM"))
                    End If
                    If nizCB(ii).Trim.ToUpper.IndexOf("DISPLAYMEMBER=") >= 0 Then
                        prikaziCBO = nizCB(ii).Replace("DISPLAYMEMBER=", "")
                    End If
                    If nizCB(ii).Trim.ToUpper.IndexOf("VALUEMEMBER=") >= 0 Then
                        upisiCBO = nizCB(ii).Replace("VALUEMEMBER=", "")
                    End If
                Next

                str = " (" & izvorCBO & ") AS " + polje + "_CBO ON " + polje + "_CBO." + upisiCBO + "=" + tabela + "." + polje + "#" + polje + "_CBO." + prikaziCBO
            Else
                str = ""  'nije CB
            End If 'da li je CB
        End If

        srediIzraz = str
    End Function

    Function zamena(ByVal sta As String) As String
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        If sta.Length > 0 Then sta = sta.Substring(0, sta.Length - 1)
        'sta = sta.Replace("}", "")
        'zamena GGGMMM
        sta = sta.Trim.ToUpper
        sta = strrpl(sta, "{GGG}", "'" + Me.mvt.G.ToString + "'")
        sta = strrpl(sta, "{MMM}", "'" + String.Format("{0:d2}", Me.mvt.M) + "'")
        sta = strrpl(sta, "{YYY}", "'" + Me.mvt.G.ToString + "'")

        sta = GGMMGoreDole(sta, Me.mvt.G, Me.mvt.M)
        sta = strrpl(sta, "VRTACKA", Me.mvt.vtwhere(""))
        sta = strrpl(sta, "GGG", Me.mvt.GWhere(""))
        sta = strrpl(sta, "MMM", Me.mvt.mWhere(""))
        sta = strrpl(sta, "YYY", Me.mvt.YWhere(""))

        sta = sta.Replace(ChrW(26), "")
        Return sta
    End Function

    Dim img As Bitmap

    Private Sub FormNpretraga_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim frmCollection As New FormCollection()
        frmCollection = Application.OpenForms()
        If Not frmCollection.Item("FormFind") Is Nothing AndAlso frmCollection.Item("FormFind").IsHandleCreated Then frmCollection.Item("FormFind").Close()
    End Sub

    Private Sub app_giveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles Me.GiveFeedback, tvBaza.GiveFeedback
        e.UseDefaultCursors = False
        Cursor.Current = CreateCursor(img)
    End Sub

    Private Sub tv_giveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs)
        e.UseDefaultCursors = False
        Cursor.Current = CreateCursor(img)
    End Sub

    Private Sub app_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragOver, tvBaza.DragOver
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub tv_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub tv_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs)
        Dim tv As TreeView = CType(sender, System.Windows.Forms.TreeView)
        Dim pime As String = tv.Name.Replace("tv_", "panel_")
        Dim p As Panel = NadjiKontrolu(Me.PanelContext, pime)
        Dim nd As TreeNode = DirectCast(e.Item, TreeNode)
        If nd.Nodes.Count = 0 Then
            tv.SelectedNode = nd
            Dim EffectCursor As New Cursor(New System.IO.MemoryStream(My.Resources.Move))
            img = New Bitmap(nd.Bounds.Width + 15, nd.Bounds.Height + 26)
            Dim gr As Graphics = Graphics.FromImage(img)
            gr.Clear(Color.White)
            EffectCursor.Draw(gr, New Rectangle(0, 0, EffectCursor.Size.Width, EffectCursor.Size.Height))
            gr.DrawString(nd.Text, tvBaza.Font, Brushes.Black, New Point(15, 26))
            img.MakeTransparent(Color.White)
            tv.DoDragDrop(nd.Text, DragDropEffects.Copy)
            tv.SelectedNode.Checked = True
            Dim ttaagg As String = tv.SelectedNode.Tag
            Dim ime As String = nd.Text.Trim
            dodaj(ime, p, ttaagg, tv)
        End If
    End Sub

    Sub dodaj(ByVal ime As String, ByVal p As Panel, ByVal tag As String, ByVal tv As TreeView)
        Me.lblPorukaUslov.Text = ""
        Dim pp As String() = Microsoft.VisualBasic.Split(tag, "$")
        Dim vrstaPolja As String = pp(0).ToString.Trim
        Dim izraz As String = pp(1).ToString.Trim
        Dim filter As String = pp(2).ToString.Trim
        Dim tippolja As String = pp(3).ToString.Trim
        Dim duzina As String = pp(4).ToString.Trim
        Dim tabela As String = pp(5).ToString.Trim
        Dim kljuc As String = pp(6).ToString.Trim
        Dim cboZaSelect As String = pp(7).ToString.Trim
        Dim nizCB As String() = Microsoft.VisualBasic.Split(izraz, ";")
        Dim izvorCBO As String = ""
        Dim prikaziCBO As String = ""
        Dim upisiCBO As String = ""
        Dim filterCBO As String = ""
        Dim cb As Boolean = False
        Dim tb As Boolean = False
        Dim dtp As Boolean = False
        If vrstaPolja.Trim.ToUpper = "CB" Then
            cb = True
            For ii As Integer = 0 To nizCB.GetUpperBound(0)
                If nizCB(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                    izvorCBO = nizCB(ii).Replace("IZVOR=", "")
                End If
                If nizCB(ii).Trim.ToUpper.IndexOf("PRIKAZI=") >= 0 Then
                    prikaziCBO = nizCB(ii).Replace("PRIKAZI=", "")
                End If
                If nizCB(ii).Trim.ToUpper.IndexOf("UBAZU=") >= 0 Then
                    upisiCBO = nizCB(ii).Replace("UBAZU=", "")
                End If
                If nizCB(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                    filterCBO = nizCB(ii).Replace("FILTER=", "")
                End If
            Next
        ElseIf vrstaPolja.Trim.ToUpper = "DTP" Then
            dtp = True
        Else
            tb = True
        End If

        Dim visina As Integer = 20
        ' If p.Controls.Find(imekontrole, True).Length = 0 Then
        ' End If
        If p.Controls.Count = 0 Then brCntl = 0 : p.Height = 245
        Dim cboZL As New FlatCombo
        cboZL.Width = 50
        cboZL.FlatStyle = FlatStyle.Flat

        If p.Controls.Find("CBOZL_" & ime, True).Length = 0 Then
            cboZL.Name = "CBOZL_" & ime
        Else
            Dim b As Integer = nadjiKolikoIhIma("CBOZL_", p, ime)
            cboZL.Name = "CBOZL_" & ime & "_CopyOf" & Str(b + 1).Trim
        End If

        'location od poslednje dodate?
        If (brCntl + 1) * 20 > p.Height - 20 Then
            p.Height = p.Height + 25
        End If
        cboZL.Location = New System.Drawing.Point(10, (brCntl + 1) * 20)
        cboZL.Items.Add("(")
        cboZL.Items.Add("((")
        cboZL.Items.Add("(((")
        p.Controls.Add(cboZL)
        'labela
        Dim lbl As New System.Windows.Forms.Label
        lbl.Width = 150
        If p.Controls.Find("LB_" & ime, True).Length = 0 Then
            lbl.Name = "LB_" & ime
        Else
            Dim b As Integer = nadjiKolikoIhIma("LB_", p, ime)
            lbl.Name = "LB_" & ime & "_CopyOf" & Str(b + 1).Trim
        End If
        lbl.Text = ime
        lbl.Tag = tabela
        lbl.Location = New System.Drawing.Point(cboZL.Location.X + cboZL.Width + 5, cboZL.Location.Y)
        p.Controls.Add(lbl)
        AddHandler lbl.MouseDown, AddressOf Me.lbl_MouseDown
        'combobox
        Dim cboOP As New FlatCombo
        cboOP.Width = 100
        cboOP.FlatStyle = FlatStyle.Flat
        lbl.Width = 150
        If p.Controls.Find("CBOOP_" & ime, True).Length = 0 Then
            cboOP.Name = "CBOOP_" & ime
        Else
            Dim b As Integer = nadjiKolikoIhIma("CBOOP_", p, ime)
            cboOP.Name = "CBOOP_" & ime & "_CopyOf" & Str(b + 1).Trim
        End If
        cboOP.Location = New System.Drawing.Point(lbl.Location.X + lbl.Width + 5, lbl.Location.Y)
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
        AddHandler cboOP.SelectionChangeCommitted, AddressOf Me.cboOP_SelectionChangeCommitted
        p.Controls.Add(cboOP)
        'textBox ili combobox
        Dim trt As New System.Windows.Forms.TextBox
        Dim dtptrt As New DateTimePicker2
        'Dim cbtrt As New System.Windows.Forms.ComboBox
        Dim cbtrt As New FlatCombo

        If tb = True Then
            trt.Width = 200
            trt.BorderStyle = BorderStyle.FixedSingle
            If p.Controls.Find("TP_" & ime, True).Length = 0 Then
                trt.Name = "TP_" & ime
            Else
                Dim b As Integer = nadjiKolikoIhIma("TP_", p, ime)
                trt.Name = "TP_" & ime & "_CopyOf" & Str(b + 1).Trim
            End If
            trt.Location = New System.Drawing.Point(cboOP.Location.X + cboOP.Width + 5, cboOP.Location.Y)
            'trt.TabIndex = br + 1
            trt.Focus()
            'If duzina > 0 Then trt.MaxLength = duzina ne moze zbog null i zbog %%
            trt.MaxLength = 1000000
            trt.Tag = tippolja
            p.Controls.Add(trt)
            AddHandler trt.Validating, AddressOf Me.trt_Validating
        End If
        If dtp = True Then
            dtptrt.Width = 200
            If p.Controls.Find("DTP_" & ime, True).Length = 0 Then
                dtptrt.Name = "DTP_" & ime
            Else
                Dim b As Integer = nadjiKolikoIhIma("DTP_", p, ime)
                dtptrt.Name = "DTP_" & ime & "_CopyOf" & Str(b + 1).Trim
            End If
            dtptrt.Location = New System.Drawing.Point(cboOP.Location.X + cboOP.Width + 5, cboOP.Location.Y)
            dtptrt.Focus()
            dtptrt.Tag = tippolja
            p.Controls.Add(dtptrt)
        End If
        If cb = True Then
            cbtrt.Width = 200
            cbtrt.DropDownWidth = 250
            cbtrt.FlatStyle = FlatStyle.Flat
            If p.Controls.Find("CB_" & ime, True).Length = 0 Then
                cbtrt.Name = "CB_" & ime
            Else
                Dim b As Integer = nadjiKolikoIhIma("CB_", p, ime)
                cbtrt.Name = "CB_" & ime & "_CopyOf" & Str(b + 1).Trim
            End If

            cbtrt.Location = New System.Drawing.Point(cboOP.Location.X + cboOP.Width + 5, cboOP.Location.Y)
            cbtrt.Focus()
            cbtrt.DropDownStyle = ComboBoxStyle.DropDownList
            cbtrt.Tag = tippolja
            p.Controls.Add(cbtrt)
            Dim sb() As String = tv.Tag.ToString.Trim.Split("$")
            Dim server As String = sb(0).Trim
            Dim baza As String = sb(1).Trim
            Dim konekcija As String = getConnectionString(server, baza, txtmode, Me.ms)
            cbpp_popuni(konekcija, cbtrt, izvorCBO, prikaziCBO, upisiCBO)
        End If
        brCntl = brCntl + 1

        'zagrada desna
        Dim cboZD As New FlatCombo
        cboZD.Width = 50
        cboZD.FlatStyle = FlatStyle.Flat
        If p.Controls.Find("CBOZD_" & ime, True).Length = 0 Then
            cboZD.Name = "CBOZD_" & ime
        Else
            Dim b As Integer = nadjiKolikoIhIma("CBOZD_", p, ime)
            cboZD.Name = "CBOZD_" & ime & "_CopyOf" & Str(b + 1).Trim
        End If

        If tb = True Then
            cboZD.Location = New System.Drawing.Point(trt.Location.X + trt.Width + 5, trt.Location.Y)
        ElseIf dtp = True Then
            cboZD.Location = New System.Drawing.Point(dtptrt.Location.X + dtptrt.Width + 5, dtptrt.Location.Y)
        Else
            cboZD.Location = New System.Drawing.Point(cbtrt.Location.X + cbtrt.Width + 5, cbtrt.Location.Y)
        End If
        cboZD.Items.Add(")")
        cboZD.Items.Add("))")
        cboZD.Items.Add(")))")
        p.Controls.Add(cboZD)
        'combobox
        Dim cbVeznik As New FlatCombo
        cbVeznik.Width = 50
        cbVeznik.FlatStyle = FlatStyle.Flat
        If p.Controls.Find("CBOV_" & ime, True).Length = 0 Then
            cbVeznik.Name = "CBOV_" & ime
        Else
            Dim b As Integer = nadjiKolikoIhIma("CBOV_", p, ime)
            cbVeznik.Name = "CBOV_" & ime & "_CopyOf" & Str(b + 1).Trim
        End If
        cbVeznik.Location = New System.Drawing.Point(cboZD.Location.X + cboZD.Width + 5, cboZD.Location.Y)
        cbVeznik.Items.Add("AND")
        cbVeznik.Items.Add("OR")
        cbVeznik.Text = "AND"
        p.Controls.Add(cbVeznik)
    End Sub

    Private Sub trt_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        'If Me.GBLike.Visible = True Then GBLike.Enabled = True
        'If Me.GBLike.Visible = False Then GBLike.Enabled = False
    End Sub

    Private Sub cboOP_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim cbOP As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        Call promeni(cbOP)
    End Sub

    Sub promeni(ByVal cbOP As ComboBox)
        Dim imePolja As String = cbOP.Name.Substring(cbOP.Name.IndexOf("_") + 1)
        Dim cbo As System.Windows.Forms.ComboBox = CType(NadjiKontrolu(vidljiviPanel, "CB_" + imePolja), ComboBox)
        Dim tbx As System.Windows.Forms.TextBox = CType(NadjiKontrolu(vidljiviPanel, "TP_" + imePolja), TextBox)

        Dim cb As Boolean = False
        If Not cbo Is Nothing Then cb = True

        If cbOP.SelectedItem = "in" OrElse cbOP.SelectedItem = "not in" _
        OrElse cbOP.SelectedItem = "like" OrElse cbOP.SelectedItem = "not like" _
        OrElse cbOP.SelectedItem = "between" OrElse cbOP.SelectedItem = "not between" _
        OrElse cbOP.SelectedItem = "is" OrElse cbOP.SelectedItem = "not is" Then
            If cb = True Then Call zameniCBOiTXT(cbo, cb, imePolja)
        Else
            If cb = True Then Call zameniCBOiTXT(cbo, Not cb, imePolja)
        End If

        ''msg 295
        Dim msgtxt295 As String = getMessageText(dtMessages, "295", Me.jezik)

        If cbOP.SelectedItem = "in" OrElse cbOP.SelectedItem = "not in" Then
            btnNPUvuci.Visible = True
            btnNPUvuci.Text = msgtxt295
            btnNPUvuci.Tag = cbOP.Name
        Else
            btnNPUvuci.Visible = False
        End If

        If cbOP.SelectedItem = "like" OrElse cbOP.SelectedItem = "not like" Then
            GBLike.Visible = True
            GBLike.Tag = cbOP.Name
            GBLike.Location = New Point(btnNPUvuci.Location.X, btnNPUvuci.Location.Y - 5)
        Else
            GBLike.Visible = False
        End If

    End Sub

    Sub zameniCBOiTXT(ByVal cbo As ComboBox, ByVal cb As Boolean, ByVal ime As String)
        Dim trt As New System.Windows.Forms.TextBox
        If cb = True Then
            cbo.Visible = False
            trt.Width = 200
            trt.BorderStyle = BorderStyle.FixedSingle
            Dim tt As Control = NadjiKontrolu(vidljiviPanel, "TP_" & ime)

            If tt Is Nothing Then
                trt.Name = "TP_" & ime
                trt.Location = cbo.Location
                trt.Focus()
                trt.Tag = cbo.Tag
                vidljiviPanel.Controls.Add(trt)
            Else
                tt.Visible = True
                tt.Text = ""
            End If
        Else
            cbo.Visible = True
            cbo.Text = ""
            Dim tt As Control = NadjiKontrolu(vidljiviPanel, "TP_" & ime)
            If Not tt Is Nothing Then tt.Visible = False
        End If
    End Sub

    Function nadjiKolikoIhIma(ByVal prefiks As String, ByVal p As Panel, ByVal ime As String) As Integer
        Dim b As Integer = 0
        For Each cntl As Control In p.Controls
            Dim dokle As Integer = prefiks.Length + ime.Length
            If cntl.Name.Length >= dokle AndAlso cntl.Name.Substring(0, dokle).Trim.ToUpper = prefiks + ime.Trim.ToUpper Then
                b = b + 1
            End If
        Next
        nadjiKolikoIhIma = b
    End Function

    Private Sub cbpp_popuni(ByVal kon As String, ByRef cbo As System.Windows.Forms.ComboBox, ByVal izvorcbo As String, ByVal prikaziCBO As String, ByVal upisicbo As String,
                            Optional ByVal filter As Boolean = False, Optional ByVal SV As String = "", Optional ByVal bezFilteraIakoGaIma As Boolean = False)
        Dim sqlFilter As String = "2=2"
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(izvorcbo, kon, Me.jezik)

        Dim ds As DataSet = New DataSet
        ds.Tables.Add("tabela")
        ds.Tables("tabela").Columns.Add("prikazi", GetType(String))
        ds.Tables("tabela").Columns.Add("upisi", GetType(String))
        'ubaci prazan
        Dim dr0 As DataRow = ds.Tables("tabela").NewRow()
        dr0("prikazi") = ""
        dr0("upisi") = ""
        ds.Tables("tabela").Rows.Add(dr0)
        For i As Int16 = 0 To dt.Rows.Count - 1
            Dim dr As DataRow = ds.Tables("tabela").NewRow()
            dr("prikazi") = dt.Rows(i).Item(prikaziCBO)
            dr("upisi") = dt.Rows(i).Item(upisicbo)
            ds.Tables("tabela").Rows.Add(dr)
        Next
        cbo.DisplayMember = "prikazi"
        cbo.ValueMember = "upisi"
        cbo.DataSource = ds.Tables("tabela")
    End Sub

    Public Function NadjiKontroluTab(ByVal parent As TabControl, ByVal ident As String) As Control
        Dim control As Control = Nothing
        For Each tab As TabPage In parent.TabPages
            For Each ctr As Control In tab.Controls
                If ctr.Name.Trim.ToUpper = ident.Trim.ToUpper Then
                    control = ctr
                    Exit For
                End If
            Next ctr
        Next tab
        Return control
    End Function

    Private Sub DrawBorder(ByVal sender As Object, ByVal e As PaintEventArgs)
        'Dim rect As New Rectangle(clbAplikacija.Location.X - 1, clbAplikacija.Location.Y - 1, clbAplikacija.Width + 1, clbAplikacija.Height + 1)
        'Dim pen As New Pen(Color.Black, 1)
        'Dim g As Graphics = e.Graphics
        'g.DrawRectangle(pen, rect)
    End Sub

    Private Sub tv_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim tv As TreeView = CType(sender, System.Windows.Forms.TreeView)
        Dim pime As String = tv.Name.Replace("tv_", "panel_")
        Dim p As Panel = NadjiKontrolu(PanelContext, pime)
        Dim polje As String = e.Data.GetData(DataFormats.Text)
        Call skloniSaPanela(p, polje, False)
    End Sub

    Sub skloniSaPanela(ByVal p As Panel, ByVal polje As String, ByVal sve As Boolean)
        Dim skloni As Boolean = False
        For indx As Integer = p.Controls.Count - 1 To 0 Step -1
            Dim cntl As Control
            cntl = p.Controls.Item(indx)
            Dim ppolje As String = cntl.Name.Substring(cntl.Name.IndexOf("_") + 1)
            If sve = True AndAlso ppolje.IndexOf("_CopyOf") > 0 Then ppolje = ppolje.Substring(0, ppolje.IndexOf("_CopyOf"))
            If ppolje = polje Then
                p.Controls.Remove(cntl)
                skloni = True
                cntl.Dispose()
            End If
        Next

    End Sub

    Sub skloniSaPanelaSveStoPripadaTabeli(ByVal p As Panel, ByVal tabela As String)

        Dim polja As String = ""
        Dim skloni As Boolean = False

        If p.Controls.Count > 0 Then
            For Each c As Control In p.Controls
                Dim punoime As String = c.Name
                Dim imePolja As String = c.Name.Substring(c.Name.IndexOf("_") + 1)
                Dim prefiks As String = c.Name.Substring(0, c.Name.IndexOf("_") + 1)

                If prefiks = "LB_" Then
                    Dim imetabele As String = CType(NadjiKontrolu(p, c.Name), Label).Tag.ToString.Trim
                    polja = polja + imetabele + "." + imePolja + "$"
                End If
            Next

            polja = polja + "#"
            polja = polja.Replace("$#", "")
            Dim poljaniz As String() = polja.Split("$")

            For i As Integer = 0 To poljaniz.GetUpperBound(0)
                Dim pp As String() = poljaniz(i).Split(".")
                Dim imePolja As String = pp(1)
                Dim imeTabele As String = pp(0)
                skloni = False
                If imeTabele.Trim.ToUpper = tabela.Trim.ToUpper Then
                    'sve remove
                    p.Controls.Remove(CType(NadjiKontrolu(p, "CBOZL_" + imePolja), ComboBox))
                    p.Controls.Remove(CType(NadjiKontrolu(p, "LB_" + imePolja), Label))
                    p.Controls.Remove(CType(NadjiKontrolu(p, "CBOOP_" + imePolja), ComboBox))
                    If Not NadjiKontrolu(p, "TP_" + imePolja) Is Nothing Then
                        p.Controls.Remove(CType(NadjiKontrolu(p, "TP_" + imePolja), TextBox))
                    End If
                    If Not NadjiKontrolu(p, "CB_" + imePolja) Is Nothing Then
                        p.Controls.Remove(CType(NadjiKontrolu(p, "CB_" + imePolja), ComboBox))
                    End If
                    p.Controls.Remove(CType(NadjiKontrolu(p, "CBOZD_" + imePolja), ComboBox))
                    p.Controls.Remove(CType(NadjiKontrolu(p, "CBOV_" + imePolja), ComboBox))
                    skloni = True
                End If

            Next
        End If
    End Sub

    Private Sub tv_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        If e.Action <> System.Windows.Forms.TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(e.Node, e.Node.Checked)
            End If
        End If

        Dim p As Panel = vidljiviPanel
        Dim tv As System.Windows.Forms.TreeView = CType(sender, System.Windows.Forms.TreeView)
        Dim ime As String = e.Node.Text.Trim.ToUpper
        Dim nTabela As System.Windows.Forms.TreeNode
        Dim nPolje As System.Windows.Forms.TreeNode
        Dim tabela As Boolean = False
        Dim polje As String = False
        For Each nTabela In tv.Nodes
            If nTabela.Text.Trim.ToUpper = ime Then tabela = True : Exit For
            For Each nPolje In nTabela.Nodes
                If nPolje.Text.Trim.ToUpper = ime Then polje = True : Exit For
            Next
        Next

        If e.Node.Checked = False AndAlso polje = True Then Call skloniSaPanela(p, e.Node.Text, True)
        If e.Node.Checked = False AndAlso tabela = True Then Call skloniSaPanelaSveStoPripadaTabeli(p, e.Node.Text)
    End Sub

    Private Sub tv_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs)
        Dim nd As TreeNode = DirectCast(e.Node, TreeNode)
        Dim tv As TreeView = CType(sender, System.Windows.Forms.TreeView)
        Call dodajDK(tv, nd)
    End Sub

    Sub dodajDK(ByVal tv As TreeView, ByVal nd As TreeNode)
        Dim pime As String = tv.Name.Replace("tv_", "panel_")
        Dim p As Panel = NadjiKontrolu(PanelContext, pime)
        If nd.Nodes.Count = 0 Then
            tv.SelectedNode = nd
            tv.SelectedNode.Checked = True
            Dim ttaagg As String = tv.SelectedNode.Tag
            Dim ime As String = nd.Text.Trim
            dodaj(ime, p, ttaagg, tv)
        End If
    End Sub

    Private Sub lbl_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim lbl As System.Windows.Forms.Label = CType(sender, System.Windows.Forms.Label)
        If e.Button = MouseButtons.Left Then
            Dim ppolje As String = lbl.Name.Substring(lbl.Name.IndexOf("_") + 1)
            lbl.DoDragDrop(ppolje, DragDropEffects.Copy Or DragDropEffects.Move)
        End If
    End Sub

    Private Sub CheckAllChildNodes(ByVal treeNode As System.Windows.Forms.TreeNode, ByVal nodeChecked As Boolean)
        Dim node As System.Windows.Forms.TreeNode
        For Each node In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next node
    End Sub

    Private Sub CheckForCheckedChildren(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)
        If Not HasCheckedChildNodes(e.Node) Then e.Cancel = True
    End Sub

    Private Function HasCheckedChildNodes(ByVal node As System.Windows.Forms.TreeNode) As Boolean
        If node.Nodes.Count = 0 Then Return False
        Dim childNode As System.Windows.Forms.TreeNode
        For Each childNode In node.Nodes
            If childNode.Checked Then Return True
            If HasCheckedChildNodes(childNode) Then Return True
        Next childNode
        Return False
    End Function

#Region "   CreateIconIndirect"

    Private Structure IconInfo
        Public fIcon As Boolean
        Public xHotspot As Int32
        Public yHotspot As Int32
        Public hbmMask As IntPtr
        Public hbmColor As IntPtr
    End Structure

    <DllImport("user32.dll", EntryPoint:="CreateIconIndirect")>
    Private Shared Function CreateIconIndirect(ByVal iconInfo As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Public Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    End Function

    <DllImport("gdi32.dll")>
    Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function

    ''' <summary>
    ''' CreateCursor
    ''' </summary>
    ''' <param name="bmp"></param>
    ''' <returns>custom Cursor</returns>
    ''' <remarks>creates a custom cursor from a bitmap</remarks>
    Public Function CreateCursor(ByVal bmp As Bitmap) As Cursor
        'Setup the Cursors IconInfo
        Dim tmp As New IconInfo
        tmp.xHotspot = 0
        tmp.yHotspot = 0
        tmp.fIcon = False
        tmp.hbmMask = bmp.GetHbitmap()
        tmp.hbmColor = bmp.GetHbitmap()

        'Create the Pointer for the Cursor Icon
        Dim pnt As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(tmp))
        Marshal.StructureToPtr(tmp, pnt, True)
        Dim curPtr As IntPtr = CreateIconIndirect(pnt)

        'Clean Up
        DestroyIcon(pnt)
        DeleteObject(tmp.hbmMask)
        DeleteObject(tmp.hbmColor)

        Return New Cursor(curPtr)
    End Function

#End Region

    Public upitzaprikaz As String

    Private Sub ButtonTrazi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonNPTrazi.Click
        Me.dgA.Visible = False
        Me.bClose.Visible = False
        Me.panelPamtiOkvir.Visible = False
        If Me.txtUslov.Visible = True Then
            Call trazi(txtUslov.Text)
            Me.txtUslov.Visible = False
        Else
            If Not vidljiviTV Is Nothing Then
                If prazanTreeView(vidljiviTV) = True Then
                    ''msg 245
                    Dim msgtxt245 As String = getMessageText(dtMessages, "245", Me.jezik)
                    ISTMessageBox.Show(msgtxt245, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    vidljiviTV.Focus()
                Else
                    Call trazi()
                End If
            End If
        End If
    End Sub

    Sub trazi(Optional ByVal postojeciUslov As String = "")
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim str As String = ""
        If Me.tabKontrola.Visible = False Then
            Me.tabKontrola.Visible = True
            tabKontrola.Width = Me.Width - 25
            tabKontrola.Height = Me.Height - vidljiviTV.Location.X - vidljiviTV.Height - 125 ' + Me.PanelBarraTitulo.Height
        End If
        Dim postoji As Boolean = False
        For Each tp As TabPage In tabKontrola.TabPages
            If tp.Text = clbAplikacija.SelectedValue.Trim Then  '"tab_" & cboKopijaOd1.SelectedValue.Trim Then
                postoji = True
                Exit For
            End If
        Next
        If postoji = False Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim TabPage As New TabPage
            tabKontrola.TabPages.Add(TabPage)
            TabPage.Text = clbAplikacija.SelectedValue.Trim   '& tab.TabPages.Count
            ''''
            Dim pp As New Panel
            pp.Location = New System.Drawing.Point(0, 0)
            pp.Width = 0
            pp.Height = 38
            'pp.BackColor = SystemColors.ActiveCaption
            pp.AllowDrop = True
            pp.Name = "pp_" & clbAplikacija.SelectedValue.Trim
            vidljiviPanelGrid = pp
            TabPage.Controls.Add(pp)

            Dim lblBrojRedova As New Label
            lblBrojRedova.Dock = DockStyle.Bottom
            lblBrojRedova.Name = "lblbrr_" & clbAplikacija.SelectedValue.Trim
            lblBrojRedova.Text = ""
            lblBrojRedova.ForeColor = Color.Black
            lblBrojRedova.Font = New System.Drawing.Font("Verdana", 8.0!, FontStyle.Bold)
            lblBrojRedova.Height = 14
            TabPage.Controls.Add(lblBrojRedova)
            vidljiviGridLabel = lblBrojRedova

            Dim dg As New DataGridView
            dg.Height = TabPage.Height - pp.Height - 10 - lblBrojRedova.Height
            dg.Location = New System.Drawing.Point(pp.Location.X, pp.Location.Y + pp.Height + 1)
            dg.Width = tabKontrola.Width - 5
            dg.Name = "dg_" & clbAplikacija.SelectedValue.Trim
            TabPage.Controls.Add(dg)
            AddHandler dg.ColumnHeaderMouseDoubleClick, AddressOf dg_ColumnHeaderMouseDoubleClick
            AddHandler dg.MouseDown, AddressOf dg_MouseDown
            AddHandler dg.DataSourceChanged, AddressOf dg_DataSourceChanged
            AddHandler dg.RowPostPaint, AddressOf dg_RowPostPaint
            AddHandler dg.ColumnAdded, AddressOf dg_ColumnAdded
            vidljiviGrid = dg
        End If
        If postojeciUslov = "" Then
            str = sloziSQL(vidljiviTV, vidljiviPanel)
        Else
            str = postojeciUslov
        End If

        upitzaprikaz = str
        Call srediGridView(vidljiviGrid, True, 30)

        Dim sb() As String = vidljiviTV.Tag.ToString.Trim.Split("$")
        Dim server As String = sb(0).Trim
        Dim baza As String = sb(1).Trim
        Dim konekcija As String = getConnectionString(server, baza, txtmode, Me.ms)
        Call dgrid(konekcija, str, vidljiviGrid, vidljiviGridLabel)

        Call predjiNaTab(vidljiviGrid)
        Me.txtPOM.Text = Me.txtPOM.Text + "--(" + server + "," + baza + ")" + nvrd + upitzaprikaz + ";"
        'usporava, pa je izbačeno
        'vidljiviGrid.AutoResizeColumns()
        'vidljiviGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Call nijeZaSort(vidljiviGrid)
        Dim copyDataTable As DataTable
        If Not vidljiviGrid.DataSource Is Nothing Then
            copyDataTable = vidljiviGrid.DataSource.Copy()
            copyDataTableO = copyDataTable.Copy
        End If
        Call dajAgregatniNiz(vidljiviGrid)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dg_ColumnAdded(ByVal sender As Object, ByVal e As DataGridViewColumnEventArgs)
        e.Column.FillWeight = 10
        ' <<this line will help you
    End Sub

    Private Sub dg_RowPostPaint(ByVal sender As Object, ByVal e As DataGridViewRowPostPaintEventArgs)
        Dim dg As DataGridView = TryCast(sender, DataGridView)
        Dim rowIdx As Integer = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim centerFormat As Object = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top,
        dg.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Public Function dajAgregatniNiz(ByVal dg As DataGridView) As String()
        agregatniniz = Nothing
        ReDim Preserve agregatniniz(dg.Columns.Count - 1)
        For i As Integer = 0 To dg.Columns.Count - 1
            agregatniniz(i) = dg.Columns(i).HeaderText.Trim.ToUpper + ":"
        Next
        dajAgregatniNiz = agregatniniz
    End Function

    Private Sub dg_ColumnDividerDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs)
        'Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'If AllCellsSelected(dg) = True Then
        '    dg.AutoResizeColumns()
        '    dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        'End If
        'Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Function AllCellsSelected(ByVal dgv As DataGridView) As Boolean
        AllCellsSelected = (dgv.SelectedCells.Count = (dgv.RowCount * dgv.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Private Sub dg_CellMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)
        Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        If e.Button = System.Windows.Forms.MouseButtons.Right AndAlso e.ColumnIndex >= 0 Then
            dg.Columns(e.ColumnIndex).Selected = True
        End If
    End Sub

    Public copyDataTableO As DataTable

    Private Sub dg_ColumnHeaderMouseDoubleClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
        Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        Dim ColName As String = dg.DataSource.Columns(e.ColumnIndex).ColumnName.ToString.Trim.ToUpper
        Call predgrup(ColName)
    End Sub

    Sub predgrup(ByVal ColName As String)

        Dim moze As Boolean = True
        If ColName.Trim.Length >= 4 Then
            Dim a As String = ColName.Substring(ColName.Trim.Length - 4).Trim.ToUpper
            If a = "_SUM" OrElse a = "_MAX" OrElse a = "_MIN" OrElse a = "_AVG" Then moze = False
        End If
        If ColName.Trim.Length >= 6 Then
            Dim a As String = ColName.Substring(ColName.Trim.Length - 6).Trim.ToUpper
            If a = "_COUNT" Then moze = False
        End If

        Dim pp As Panel
        Dim k As Control = NadjiKontroluTab(Me.tabKontrola, "pp_" & clbAplikacija.SelectedValue.Trim)

        'nema grupisanja ako je nesto uzeto za sum,...
        Dim nadjen As Boolean = False
        For i As Integer = 0 To agregatniniz.GetUpperBound(0)
            If agregatniniz(i).Split(":")(0).Trim = ColName.Trim AndAlso agregatniniz(i).Split(":")(1).Trim <> "" Then
                nadjen = True
                Exit For
            End If
        Next

        If nadjen = False AndAlso moze = True Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Not k Is Nothing Then
                pp = CType(k, Panel)
                Dim gb As Control = NadjiKontrolu(pp, "GB_" + ColName)
                If gb Is Nothing Then
                    Dim y As Integer = 14
                    Dim gbk As New GroupBox
                    gbk.Text = ""

                    Dim lbl As New Label()
                    lbl.AutoSize = True
                    lbl.ForeColor = Color.Black
                    lbl.Font = New System.Drawing.Font("Verdana", 8.0!)
                    lbl.Text = ColName
                    Dim g As Graphics = lbl.CreateGraphics()
                    lbl.Width = CInt(g.MeasureString(lbl.Text, lbl.Font).Width)
                    lbl.Location = New System.Drawing.Point(2, 16)
                    lbl.Name = "LB_" + lbl.Text.Trim.ToUpper
                    gbk.Controls.Add(lbl)

                    Dim bCloseG As New PictureBox
                    bCloseG.Image = My.Resources.ResourceManager.GetObject("closebutton")
                    bCloseG.Location = New System.Drawing.Point(lbl.Location.X + lbl.Width + 5, y - 5)
                    bCloseG.Width = 16
                    bCloseG.Height = 16
                    bCloseG.Name = "BC_" + lbl.Text.Trim.ToUpper
                    AddHandler bCloseG.Click, AddressOf bCloseG_Click
                    gbk.Controls.Add(bCloseG)

                    Dim x As Integer = pp.Width

                    gbk.Location = New System.Drawing.Point(pp.Width, 0)
                    gbk.Name = "GB_" + lbl.Text.Trim.ToUpper
                    gbk.Font = New System.Drawing.Font("Verdana", 8.0!)
                    gbk.Size = New System.Drawing.Size(lbl.Width + bCloseG.Width + 10, pp.Height - 1)
                    pp.Controls.Add(gbk)

                    pp.Width = pp.Width + gbk.Width

                    Call grupisi(ColName)
                End If
            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Sub grupisi(ByVal kolona As String, Optional ByVal e As String = "")

        Dim ok As Boolean = False
        If Not vidljiviGrid Is Nothing Then
            Dim dto As New DataTable
            dto = vidljiviGrid.DataSource.copy

            Dim poljag As String = ""
            Dim poljaf As String = ""
            Dim polja As String = ""
            Dim tt As String = vpgCNTL()
            If e <> "" Then tt = e

            Dim gb() As String = {}
            Dim s As String = ""
            Dim spolja As String = ""
            Dim poljas As String = ""
            Dim svekol As String = ""

            If tt <> "" Then
                gb = tt.Split(",")
                For i As Integer = 0 To gb.GetUpperBound(0)
                    s = s + gb(i).Trim.ToUpper.Trim.ToUpper + "_NEC desc,"
                    poljag = poljag + gb(i).Trim.ToUpper + ","
                    spolja = spolja + gb(i).Trim.ToUpper + " ASC,"
                Next
            End If

            For Each kol As DataColumn In dto.Columns
                Dim ime As String = kol.Caption.Trim.ToUpper
                If poljag.IndexOf(ime + ",") >= 0 Then
                    poljas = poljas + ime + ","
                Else
                    If ime.IndexOf("_NEC") >= 0 Then
                        poljas = poljas + "1 as " + ime + ","
                    Else
                        Dim nadjen As String = ""
                        For i As Integer = 0 To agregatniniz.GetUpperBound(0)
                            If agregatniniz(i).Split(":")(0).Trim = ime.Trim AndAlso agregatniniz(i).Split(":")(1).Trim <> "" Then
                                nadjen = agregatniniz(i)
                                nadjen = nadjen + ","
                                nadjen = nadjen.Replace(",,", "")
                                Exit For
                            End If
                        Next
                        If nadjen <> "" AndAlso nadjen.Split(":")(0).Trim = ime.Trim AndAlso nadjen.Split(":")(1).Trim <> "" Then
                            Dim f() As String = nadjen.Split(":")(1).Split(",")
                            For ii As Integer = 0 To f.GetUpperBound(0)
                                Dim sta As String = f(ii) + "(" + ime + ") as " + ime + "_" + f(ii) + ","
                                If poljas.Trim.ToUpper.IndexOf(sta.Trim.ToUpper) < 0 Then
                                    poljas = poljas + f(ii) + "(" + ime + ") as " + ime + "_" + f(ii) + ","
                                    If poljaf.IndexOf(ime + ",") < 0 Then poljaf = poljaf + ime + ","
                                End If
                            Next
                        Else
                            If poljas.Trim.ToUpper.IndexOf(ime) < 0 Then poljas = poljas + "Null as " + ime + ","
                        End If
                    End If
                    svekol = svekol + ime + ","
                End If
            Next

            Dim selectGroupBy As String = ""
            Dim strGroupBy As String = ""
            Dim polje As String = kolona

            selectGroupBy = poljas
            strGroupBy = strGroupBy + poljag

            If selectGroupBy.Trim <> "" Then
                selectGroupBy = selectGroupBy + "$"
                selectGroupBy = selectGroupBy.Replace(",$", "")
                ok = True
            End If
            If strGroupBy.Trim <> "" Then
                strGroupBy = strGroupBy + "$"
                strGroupBy = "GROUP BY " + strGroupBy.Replace(",$", "")
                ok = True
            End If
            If ok = True Then
                Dim noviSQl As String = ""
                noviSQl = "select " + selectGroupBy + nvrd + " FROM (" + upitzaprikaz + ") as BBB " + nvrd + strGroupBy

                Dim sb() As String = vidljiviTV.Tag.ToString.Trim.Split("$")
                Dim server As String = sb(0).Trim
                Dim baza As String = sb(1).Trim
                Dim konekcija As String = getConnectionString(server, baza, txtmode, Me.ms)

                Dim dt As New DataTable
                For Each kol As DataColumn In dto.Columns
                    dt.Columns.Add(kol.Caption, DirectCast(kol, System.Data.DataColumn).DataType)
                Next

                Dim dt1 As New DataTable
                dt1 = izvrsiSQLvratiDT(noviSQl, konekcija, Me.jezik, dt)

                For Each kolDT1 As DataColumn In dt1.Columns
                    Dim ima As Boolean = False
                    For Each kolDTO As DataColumn In dto.Columns
                        If kolDTO.Caption = kolDT1.Caption Then ima = True
                    Next
                    If ima = False Then
                        Dim ime As String = kolDT1.Caption.Substring(0, kolDT1.Caption.LastIndexOf("_"))
                        Dim ff As String = kolDT1.Caption.Substring(kolDT1.Caption.LastIndexOf("_") + 1)
                        If ff = "COUNT" Then
                            dto.Columns.Add(kolDT1.Caption, DirectCast(kolDT1, System.Data.DataColumn).DataType, "1")
                        Else
                            dto.Columns.Add(kolDT1.Caption, DirectCast(kolDT1, System.Data.DataColumn).DataType, ime)
                        End If
                    End If
                Next

                dt1.Merge(dto)

                Dim u As String = ""
                If svekol <> "" Then
                    svekol = svekol + ","
                    svekol = svekol.Replace(",,", "")
                    Dim k() As String = svekol.Split(",")
                    For i As Integer = 0 To k.GetUpperBound(0)
                        If k(i).Trim.ToUpper.IndexOf("_NEC") < 0 Then u = u + " " + k(i).Trim.ToUpper + " is null AND"
                    Next
                End If

                If s <> "" Then
                    s = s + ","
                    s = s.Replace(",,", "")
                End If
                If u <> "" Then
                    u = u + "AND"
                    u = u.Replace("ANDAND", "")
                End If

                dt1.Columns.Add(kolona + "_NEC", GetType(Integer), u)
                For Each kol As DataColumn In dt1.Columns
                    Dim ime As String = kol.Caption.Trim.ToUpper
                    If poljag.IndexOf(ime + ",") < 0 Then polja = polja + ime + ","
                Next

                Dim pom As String = poljag + polja + ","
                pom = pom.Replace(",,", "")
                Dim kolone() As String = pom.Split(",")
                ReorderTable(dt1, kolone)
                dt1.DefaultView.Sort = spolja + s

                vidljiviGrid.DataSource = Nothing
                vidljiviGrid.DataSource = dt1.DefaultView.ToTable().Copy

                Dim bk As Integer = vidljiviGrid.Columns.Count - 1
                For i As Integer = bk To bk - gb.GetUpperBound(0) Step -1
                    vidljiviGrid.Columns(i).Visible = False
                Next

                Call nijeZaSort(vidljiviGrid)

            End If
        End If

    End Sub

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

    Sub odgrupisi(ByVal kolona As String)
        Dim gb() As String = {}
        If Not vidljiviGrid Is Nothing Then
            vidljiviGrid.DataSource = copyDataTableO.Copy
            Dim tt As String = vpgCNTL()
            If tt <> "" Then
                gb = tt.Split(",")
                Dim e As String = ""
                For i As Integer = 0 To gb.GetUpperBound(0)
                    e = e + gb(i) + ","
                    Call grupisi(gb(i), (e + ",").Replace(",,", ""))
                Next
            End If
        End If
    End Sub

    Public Sub ReorderTable(ByRef dt As DataTable, ByVal ParamArray columns() As String)
        If columns.Length <> dt.Columns.Count Then
            Throw New ArgumentException("Count of columns must be equal to table.Column.Count", "columns")
        End If
        For i As Integer = 0 To columns.Length - 1
            dt.Columns(columns(i)).SetOrdinal(i)
        Next
    End Sub

    Private Function vpgCNTL() As String
        vpgCNTL = ""
        For indx As Integer = 0 To vidljiviPanelGrid.Controls.Count - 1
            Dim kk As Control = vidljiviPanelGrid.Controls.Item(indx)
            If TypeOf kk Is GroupBox Then vpgCNTL = vpgCNTL + kk.Name.Trim.ToUpper.Replace("GB_", "") + ","
        Next
        If vpgCNTL <> "" Then
            vpgCNTL = vpgCNTL + ","
            vpgCNTL = vpgCNTL.Replace(",,", "")
        End If
    End Function

    Private Sub bCloseG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim b As System.Windows.Forms.PictureBox = CType(sender, System.Windows.Forms.PictureBox)
        Dim ColName As String = b.Name.Trim.ToUpper.Replace("BC_", "")
        Call preodgrup(ColName)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub preodgrup(ByVal ColName As String)
        Dim k As Control = NadjiKontroluTab(Me.tabKontrola, "pp_" & clbAplikacija.SelectedValue.Trim)

        If Not k Is Nothing Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call UnfilterTop()
            Dim pp As Panel = CType(k, Panel)
            Dim gbk As Control = NadjiKontrolu(pp, "gb_" + ColName)
            If Not gbk Is Nothing Then
                Dim x As Integer = gbk.Location.X
                Dim w As Integer = gbk.Width
                For indx As Integer = 0 To vidljiviPanelGrid.Controls.Count - 1
                    Dim kk As Control = vidljiviPanelGrid.Controls.Item(indx)
                    If TypeOf kk Is GroupBox Then
                        Dim xx As Integer = kk.Location.X
                        If xx > x Then kk.Location = New System.Drawing.Point(xx - w, kk.Location.Y)
                    End If
                Next
                vidljiviPanelGrid.Controls.Remove(gbk)
                gbk.Dispose()
                pp.Width = pp.Width - gbk.Width

                Call odgrupisi(ColName)

            End If
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub dg_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        'Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        '    Try
        '        If e.RowIndex > 0 And e.ColumnIndex = 0 Then
        '            If dg.Item(0, e.RowIndex - 1).Value = e.Value Then
        '                e.Value = ""
        '            ElseIf e.RowIndex < dg.Rows.Count - 1 Then
        '                dg.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.SkyBlue
        '            End If
        '        End If
        '    Catch ex As Exception
        '    End Try
    End Sub

    Private Sub dg_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        Dim brojRedova As String = dg.Rows.Count.ToString.Trim
        vidljiviGridLabel.Text = "Rows number " & brojRedova & "."
    End Sub

    Private Sub dg_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dt As DataTable = dg.DataSource
        Dim ht As DataGridView.HitTestInfo
        ht = dg.HitTest(e.X, e.Y)
        If ht.Type = DataGridViewHitTestType.Cell OrElse ht.Type = DataGridViewHitTestType.ColumnHeader Then
            Dim kol As String = dt.Columns(ht.ColumnIndex).Caption
            Dim kolTip As String = dt.Columns(ht.ColumnIndex).DataType.Name
            Dim gbk As Control = NadjiKontrolu(vidljiviPanelGrid, "gb_" + kol)
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                If dg.Columns.Count < 100 Then
                    If gbk Is Nothing Then 'nije grupisano po ovoj koloni
                        If kolFunkcija(kol) = True Then
                            dg.ContextMenuStrip = mnuWithFunction
                            mnuColumn.Tag = kol
                            Call cekirajMeni(mnuWithFunction, kol)
                        Else
                            If kolTip = "Boolean" OrElse kolTip = "Char" OrElse kolTip = "DateTime" OrElse kolTip = "Guid" OrElse kolTip = "String" OrElse kolTip = "TimeSpan" Then
                                dg.ContextMenuStrip = mnuColumn
                                mnuColumn.Tag = kol
                                Call cekirajMeni(mnuColumn, kol)
                            Else
                                dg.ContextMenuStrip = mnuColumnSve
                                mnuColumnSve.Tag = kol
                                Call cekirajMeni(mnuColumnSve, kol)
                            End If
                        End If
                    Else
                        dg.ContextMenuStrip = mnuUngroup
                        mnuUngroup.Tag = kol
                        Call cekirajMeni(mnuUngroup, kol)
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
                    ISTMessageBox.Show(poruka, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                Dim dd() As String = vidljiviGridLabel.Text.Split(".")
                Dim lblBrojredova As String = ""
                If dd.Length > 0 Then lblBrojredova = dd(0) + "."
                vidljiviGridLabel.Text = lblBrojredova + "                      " + tt
            End If
        Else
            dg.ContextMenuStrip = Nothing
        End If

    End Sub

    Function kolFunkcija(ByVal kol As String) As Boolean
        Dim kf As Boolean = False
        If kol.Trim.Length >= 4 Then
            Dim a As String = kol.Substring(kol.Trim.Length - 4).Trim.ToUpper
            If a = "_SUM" OrElse a = "_MAX" OrElse a = "_MIN" OrElse a = "_AVG" Then kf = True
        End If
        If kol.Trim.Length >= 6 Then
            Dim a As String = kol.Substring(kol.Trim.Length - 6).Trim.ToUpper
            If a = "_COUNT" Then kf = True
        End If
        kolFunkcija = kf
    End Function

    Sub cekirajMeni(ByVal m As ContextMenuStrip, ByVal kol As String)

        For Each mi As Object In m.Items
            If TypeOf mi Is ToolStripMenuItem Then mi.Checked = False
        Next
        Dim nadjen As String = ""
        For i As Integer = 0 To agregatniniz.GetUpperBound(0)
            If agregatniniz(i).Split(":")(0).Trim = kol.Trim AndAlso agregatniniz(i).Split(":")(1).Trim <> "" Then
                nadjen = agregatniniz(i)
                nadjen = nadjen + ","
                nadjen = nadjen.Replace(",,", "")
                Exit For
            End If
        Next
        If nadjen <> "" Then
            Dim f() As String = nadjen.Split(":")(1).Split(",")
            For ii As Integer = 0 To f.GetUpperBound(0)
                If f(ii).Trim.ToUpper = "AVERAGE" Then f(ii) = "AVG"
                For Each mi As Object In m.Items
                    If TypeOf mi Is ToolStripMenuItem AndAlso mi.Name.Substring(1).Trim.ToUpper = f(ii).Trim.ToUpper Then mi.Checked = True
                Next
            Next
        End If
    End Sub

    Public agregatniniz() As String

    Private Sub mnuColumn_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuColumn.ItemClicked
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuColumn.Tag
        If f <> "AGROUP" AndAlso f <> "AUNGROUP" AndAlso f <> "AHIDE" AndAlso f <> "AUNHIDE" _
        AndAlso f <> "ASORT" AndAlso f <> "AMCS" AndAlso f <> "AFIND" AndAlso f <> "AFILTER" _
        AndAlso f <> "AUNFILTER" AndAlso f <> "ASTB" AndAlso f <> "ABTF" Then
            Call dajmeni(currentItem, k)
        End If
        If f = "AFILTER" Then Call filterTop()
        If f = "AUNFILTER" Then Call UnfilterTop()
        If f = "AGROUP" Then Call predgrup(k)
        If f = "AUNGROUP" Then Call preodgrup(k)
        If f = "AHIDE" Then vidljiviGrid.Columns(k).Visible = False : vidljiviGrid.Columns(k).Tag = "H"
        If f = "AUNHIDE" Then
            For i As Integer = 0 To vidljiviGrid.Columns.Count - 1
                If vidljiviGrid.Columns(i).Tag = "H" Then vidljiviGrid.Columns(i).Visible = True : vidljiviGrid.Columns(i).Tag = ""
            Next
        End If
        If f = "ASORT" Then
            Select Case vidljiviGrid.SortOrder
                Case System.Windows.Forms.SortOrder.Ascending
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                Case Else
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
            End Select
        End If
        If f = "AMCS" Then Call multicolumnsort(vidljiviGrid)
        If f = "AFIND" Then Call findDGV(vidljiviGrid, k)
        If f = "ABTF" Then tabKontrola.BringToFront()
        If f = "ASTB" Then tabKontrola.SendToBack()
    End Sub

    Private Sub mnuColumnSve_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuColumnSve.ItemClicked
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuColumnSve.Tag
        If f <> "XGROUP" AndAlso f <> "XUNGROUP" AndAlso f <> "XHIDE" AndAlso f <> "XUNHIDE" _
        AndAlso f <> "XSORT" AndAlso f <> "XMCS" AndAlso f <> "XFIND" AndAlso f <> "XFILTER" _
        AndAlso f <> "XUNFILTER" AndAlso f <> "XSTB" AndAlso f <> "XBTF" Then
            Call dajmeni(currentItem, k)
        End If
        If f = "XFILTER" Then Call filterTop()
        If f = "XUNFILTER" Then Call UnfilterTop()
        If f = "XGROUP" Then Call predgrup(k)
        If f = "XUNGROUP" Then Call preodgrup(k)
        If f = "XHIDE" Then vidljiviGrid.Columns(k).Visible = False : vidljiviGrid.Columns(k).Tag = "H"
        If f = "XUNHIDE" Then
            For i As Integer = 0 To vidljiviGrid.Columns.Count - 1
                If vidljiviGrid.Columns(i).Tag = "H" Then vidljiviGrid.Columns(i).Visible = True : vidljiviGrid.Columns(i).Tag = ""
            Next
        End If
        If f = "XSORT" Then
            Select Case vidljiviGrid.SortOrder
                Case System.Windows.Forms.SortOrder.Ascending
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                Case Else
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
            End Select
        End If

        If f = "XMCS" Then Call multicolumnsort(vidljiviGrid)
        If f = "XFIND" Then Call findDGV(vidljiviGrid, k)
        If f = "XBTF" Then tabKontrola.BringToFront()
        If f = "XSTB" Then tabKontrola.SendToBack()
    End Sub

    Private Sub filterTop()
        Dim koloneGroup As String = vpgCNTL()
        If koloneGroup <> "" Then
            Dim ss() As String = koloneGroup.Split(",")
            Dim uslovFilter As String = ""
            For i As Integer = 0 To ss.GetUpperBound(0)
                uslovFilter = uslovFilter + ss(i) + "_NEC=1 OR "
            Next
            uslovFilter = uslovFilter + "AND"
            uslovFilter = uslovFilter.Replace("OR AND", "")

            Dim dtTop As DataTable = vidljiviGrid.DataSource
            vidljiviGrid.Tag = dtTop
            dtTop.DefaultView.RowFilter = uslovFilter
            Dim dtFilter As DataTable = dtTop.DefaultView.ToTable.Copy
            vidljiviGrid.DataSource = dtFilter

            koloneGroup = koloneGroup + ","
            Dim bk As Integer = vidljiviGrid.Columns.Count - 1
            For i As Integer = bk To 0 Step -1
                Dim moze As Boolean = False
                Dim kol As String = vidljiviGrid.DataSource.Columns(i).ColumnName.ToString.Trim.ToUpper
                If kolFunkcija(kol) = True Then moze = True
                If koloneGroup.IndexOf(kol + ",") > -1 Then moze = True
                If moze = False Then vidljiviGrid.Columns(i).Visible = False : vidljiviGrid.Columns(i).Tag = "H"
            Next
        End If
    End Sub

    Private Sub UnfilterTop()
        If Not vidljiviGrid.Tag Is Nothing Then
            Dim dtSve As DataTable = vidljiviGrid.Tag
            dtSve.DefaultView.RowFilter = " 2=2 "
            vidljiviGrid.DataSource = dtSve.DefaultView.ToTable

            For i As Integer = 0 To vidljiviGrid.Columns.Count - 1
                Dim kol As String = vidljiviGrid.DataSource.Columns(i).ColumnName.ToString.Trim.ToUpper
                If vidljiviGrid.Columns(i).Tag = "H" AndAlso kol.IndexOf("_NEC") < 0 Then vidljiviGrid.Columns(i).Visible = True : vidljiviGrid.Columns(i).Tag = ""
            Next
            vidljiviGrid.Tag = Nothing
        End If

    End Sub

    Private Sub mnuUngroup_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuUngroup.ItemClicked
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuUngroup.Tag
        If f = "BUNGROUP" Then Call preodgrup(k)
        If f = "BUNHIDE" Then
            For i As Integer = 0 To vidljiviGrid.Columns.Count - 1
                If vidljiviGrid.Columns(i).Tag = "H" Then vidljiviGrid.Columns(i).Visible = True : vidljiviGrid.Columns(i).Tag = ""
            Next
        End If
        If f = "BFILTER" Then Call filterTop()
        If f = "BUNFILTER" Then Call UnfilterTop()
        If f = "BSORT" Then
            Select Case vidljiviGrid.SortOrder
                Case System.Windows.Forms.SortOrder.Ascending
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                Case Else
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
            End Select
        End If
        If f = "BMCS" Then Call multicolumnsort(vidljiviGrid)
        If f = "BFIND" Then Call findDGV(vidljiviGrid, k)
        If f = "BBTF" Then tabKontrola.BringToFront()
        If f = "BSTB" Then tabKontrola.SendToBack()
    End Sub

    Private Sub mnuwithFunction_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles mnuWithFunction.ItemClicked
        Dim currentItem As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)
        Dim f As String = currentItem.Name.Trim.ToUpper
        Dim k As String = mnuUngroup.Tag
        If f = "DHIDE" Then vidljiviGrid.Columns(k).Visible = False : vidljiviGrid.Columns(k).Tag = "H"
        If f = "DUNHIDE" Then
            For i As Integer = 0 To vidljiviGrid.Columns.Count - 1
                If vidljiviGrid.Columns(i).Tag = "H" Then vidljiviGrid.Columns(i).Visible = True : vidljiviGrid.Columns(i).Tag = ""
            Next
        End If
        If f = "DFILTER" Then Call filterTop()
        If f = "DUNFILTER" Then Call UnfilterTop()
        If f = "DSORT" Then
            Select Case vidljiviGrid.SortOrder
                Case System.Windows.Forms.SortOrder.Ascending
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Descending)
                Case Else
                    vidljiviGrid.Sort(vidljiviGrid.Columns(k), System.ComponentModel.ListSortDirection.Ascending)
            End Select
        End If
        If f = "DMCS" Then Call multicolumnsort(vidljiviGrid)
        If f = "DFIND" Then Call findDGV(vidljiviGrid, k)
        If f = "DBTF" Then tabKontrola.BringToFront()
        If f = "DSTB" Then tabKontrola.SendToBack()
    End Sub

    Sub findDGV(ByVal dg As DataGridView, ByVal k As String)
        Dim ffind As New IstrazivanjaUnos.FormFind(Me, dg, k, vidljiviTV.Right, vidljiviTV.Top)
        'New FormFind(Me, dg, k, vidljiviTV)
        ffind.Show()
    End Sub

    Public Sub dajmeni(ByVal currentItem As ToolStripMenuItem, ByVal kol As String)
        Dim fn As String = currentItem.Name.Trim.ToUpper
        fn = fn.Substring(1)
        If fn = "AVERAGE" Then fn = "AVG"
        currentItem.Checked = Not currentItem.Checked
        Dim sada As Boolean = currentItem.Checked

        Dim promena As Boolean = False
        Dim koloneGroup As String = vpgCNTL()
        If nemaFn_imaGroup(fn, koloneGroup, kol) = True Then
            Call odgrupisiSve(koloneGroup)
            promena = True
        End If

        For i As Integer = 0 To agregatniniz.GetUpperBound(0)
            If agregatniniz(i).Split(":")(0).Trim = kol.Trim Then
                If agregatniniz(i).Split(":")(1).Trim.IndexOf(fn + ",") < 0 AndAlso sada = True Then
                    agregatniniz(i) = agregatniniz(i) + fn + ","
                    'dodajem
                End If
                If agregatniniz(i).Split(":")(1).Trim.IndexOf(fn + ",") >= 0 AndAlso sada = False Then
                    'oduzimam
                    agregatniniz(i) = agregatniniz(i).Replace(fn + ",", "")
                End If
                Exit For
            End If
        Next

        If promena = True Then Call grupisiSve(koloneGroup)

    End Sub

    Function nemaFn_imaGroup(ByVal fn As String, ByVal koloneGroup As String, ByVal kol As String) As Boolean
        nemaFn_imaGroup = True
        For i As Integer = 0 To agregatniniz.GetUpperBound(0)
            If agregatniniz(i).Split(":")(0).Trim = kol AndAlso agregatniniz(i).Split(":")(1).Trim <> "" Then
                Dim f() As String = agregatniniz(i).Split(":")(1).Split(",")
                For ii As Integer = 0 To f.GetUpperBound(0)
                    If fn.Trim.ToUpper = f(ii).Trim.ToUpper Then
                        nemaFn_imaGroup = False
                        Exit For
                    End If
                Next
            End If
            If nemaFn_imaGroup = False Then Exit For
        Next

        If nemaFn_imaGroup = True AndAlso koloneGroup <> "" Then
            nemaFn_imaGroup = True
        Else
            nemaFn_imaGroup = False
        End If
    End Function

    Sub odgrupisiSve(ByVal ss As String)
        Me.Cursor = Cursors.WaitCursor
        Dim tt() As String = ss.Split(",")
        For i As Integer = 0 To tt.GetUpperBound(0)
            preodgrup(tt(i))
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Sub grupisiSve(ByVal ss As String)
        Me.Cursor = Cursors.WaitCursor
        Dim tt() As String = ss.Split(",")
        For i As Integer = 0 To tt.GetUpperBound(0)
            predgrup(tt(i))
        Next
        Me.Cursor = Cursors.Default
    End Sub

    Private Function proveraP(ByVal kol As String) As Boolean
        proveraP = False
        For i As Integer = 0 To agregatniniz.GetUpperBound(0)
            If agregatniniz(i).Split(":")(0).Trim = kol.Trim AndAlso agregatniniz(i).Split(":")(1).Trim <> "" Then
                proveraP = True
                Exit For
            End If
        Next
    End Function

    Sub predjiNaTab(ByVal dg As DataGridView)
        'gde treba da predjem
        Dim psifist As String = dg.Name.Replace("dg_", "").Trim
        For Each tp As TabPage In Me.tabKontrola.TabPages
            If tp.Text.Trim.ToUpper = psifist.ToUpper Then    '"TAB_" + psifist.ToUpper
                Try
                    Me.tabKontrola.SelectedTab = tp
                Catch ex As System.Exception
                    Dim poruka As String = ex.Message
                    ISTMessageBox.Show(poruka, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
                Exit For
            End If
        Next tp
    End Sub

    Private Sub dgrid(ByVal kon As String, ByVal str As String, ByVal dg As DataGridView, ByVal lbl As Label)

        Dim rs As Long

        Try
            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(str, kon, Nothing)

            rs = dt.Rows.Count
            ''msg 8
            Dim msgtxt8 As String = getMessageText(dtMessages, "8", Me.jezik)
            ''msg 9
            Dim msgtxt9 As String = getMessageText(dtMessages, "9", Me.jezik)
            ''msg 10
            Dim msgtxt10 As String = getMessageText(dtMessages, "10", Me.jezik)
            If rs > 20 AndAlso ISTMessageBox.Show(msgtxt8 + rs.ToString + msgtxt9, msgtxt10, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.No Then
            Else
                dg.DataSource = dt
                Dim tekstKako As String = ""
                ''msg 292
                Dim msgtxt292 As String = getMessageText(dtMessages, "292", Me.jezik)
                ''msg 293
                Dim msgtxt293 As String = getMessageText(dtMessages, "293", Me.jezik)
                ''msg 294
                Dim msgtxt294 As String = getMessageText(dtMessages, "294", Me.jezik)
                If Me.cbRazliciti.Checked Then tekstKako = msgtxt293
                'dg.DisplayedRowCount(False)
                lbl.Text = msgtxt292 + " " + tekstKako + " " + msgtxt294 + " " + rs.ToString.Trim + "."
                dt.TableName = dg.Name.Replace("dg_", "")
                If DSzaExport IsNot Nothing AndAlso DSzaExport.Tables.Contains(dt.TableName) = True Then
                    DSzaExport.Tables.Remove(dt.TableName)
                End If
                DSzaExport.Tables.Add(dt)
                dg.Visible = True
            End If
        Catch ex As System.Exception
            ''msg 250
            Dim msgtxt250 As String = getMessageText(dtMessages, "250", Me.jezik)
            Dim poruka As String = msgtxt250 + nvrd + ex.Message
            ISTMessageBox.Show(poruka, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

    End Sub

    Function zapamtiPretragu(ByVal tv As TreeView, ByVal p As Panel) As String
        zapamtiPretragu = ""

        Dim tp As String = ""
        Dim ttpp As String = ""
        Dim uslovi As String = ""
        Dim nTabela As System.Windows.Forms.TreeNode
        Dim nPolje As System.Windows.Forms.TreeNode
        tp = ""
        Dim mozet As Boolean = False
        For Each nTabela In tv.Nodes
            mozet = False
            tp = ""
            For Each nPolje In nTabela.Nodes
                If nPolje.Checked = True Then
                    tp = tp + nPolje.Text.Trim + ","
                    mozet = True
                End If
            Next nPolje
            If tp <> "" Then
                tp = tp + ","
                tp = tp.Replace(",,", "")
                If mozet = True Then tp = nTabela.Text + ":" + tp
                ttpp = ttpp + tp + "$"
            End If
        Next nTabela
        If ttpp <> "" Then
            ttpp = ttpp + "$"
            ttpp = ttpp.Replace("$$", "")

            zapamtiPretragu = "TP:="
            If cbRazliciti.Checked = True Then
                zapamtiPretragu = zapamtiPretragu + "distinct"
            End If
            zapamtiPretragu = zapamtiPretragu + ttpp + ";"
        End If
    End Function

    Function sloziSQL(ByVal tv As TreeView, ByVal p As Panel) As String
        Dim mbmbr As String = ""
        Dim nTabela As System.Windows.Forms.TreeNode
        Dim nPolje As System.Windows.Forms.TreeNode
        Dim mozeT As Boolean = False

        Dim DajSamoKljuceve As String = ""
        Dim DajSvaOdabranaPolja As String = ""
        Dim DajOdabraneTabele As String = ""
        Dim DajOdabranaPoljaKojaNisuKljuc As String = ""

        Dim DajOdabranaPoljaFROMCBOSelect As String = ""

        Dim OdabraneTabeleKljucevi() As String = {}
        Dim SvaOdabranaPolja() As String = {}
        Dim OdabraneTabele() As String = {}
        Dim OdabranaPoljaKojaNisuKljuc() As String = {}


        Dim br As Integer = -1
        For Each nTabela In tv.Nodes
            DajSamoKljuceve = ""
            DajSvaOdabranaPolja = ""
            DajOdabraneTabele = ""
            DajOdabranaPoljaKojaNisuKljuc = ""
            'DajOdabranaPoljaCBO = ""
            'DajOdabranaPoljaCBOSelect = ""
            mozeT = False

            For Each nPolje In nTabela.Nodes
                Dim pp As String() = Microsoft.VisualBasic.Split(nPolje.Tag, "$")
                Dim kljuc As String = pp(6).ToString.Trim
                Dim vrstaPolja As String = pp(0).ToString.Trim
                Dim CBO As String = pp(7).ToString.Trim
                Dim prr() As String = Nothing
                If CBO.IndexOf("#") > 0 Then
                    prr = CBO.Split("#")
                End If

                If kljuc.ToUpper = "P" Then If kljuc.ToUpper = "P" Then DajSamoKljuceve = DajSamoKljuceve + nPolje.Text + ","
                If nPolje.Checked Then mozeT = True
                If nPolje.Checked Then DajSvaOdabranaPolja = DajSvaOdabranaPolja + nTabela.Text + "." + nPolje.Text + " as " + nTabela.Text + "_" + nPolje.Text + ","
                If nPolje.Checked AndAlso kljuc.ToUpper = "" Then DajOdabranaPoljaKojaNisuKljuc = DajOdabranaPoljaKojaNisuKljuc + nPolje.Text + ","
                If nPolje.Checked AndAlso vrstaPolja.ToUpper = "CB" Then
                    DajSvaOdabranaPolja = DajSvaOdabranaPolja + prr(1).Trim + ","
                    DajOdabranaPoljaFROMCBOSelect = DajOdabranaPoljaFROMCBOSelect + " LEFT JOIN " + prr(0).Trim
                End If
            Next nPolje

            If mozeT = True Then
                br = br + 1
                ReDim Preserve OdabraneTabele(br)
                OdabraneTabele(br) = nTabela.Text
                ReDim Preserve OdabraneTabeleKljucevi(br)
                If DajSamoKljuceve.Length > 0 Then
                    OdabraneTabeleKljucevi(br) = DajSamoKljuceve.Trim.Substring(0, DajSamoKljuceve.Trim.LastIndexOf(","))
                Else
                    OdabraneTabeleKljucevi(br) = ""
                End If
                ReDim Preserve SvaOdabranaPolja(br)
                SvaOdabranaPolja(br) = DajSvaOdabranaPolja.Trim.Substring(0, DajSvaOdabranaPolja.Trim.LastIndexOf(","))
                ReDim Preserve OdabranaPoljaKojaNisuKljuc(br)
                If DajOdabranaPoljaKojaNisuKljuc.Length > 0 Then
                    OdabranaPoljaKojaNisuKljuc(br) = DajOdabranaPoljaKojaNisuKljuc.Trim.Substring(0, DajOdabranaPoljaKojaNisuKljuc.Trim.LastIndexOf(","))
                Else
                    OdabranaPoljaKojaNisuKljuc(br) = ""
                End If

            End If
        Next nTabela

        Dim selectPoTabeli() As String = {}
        Dim str As String = ""

        For i As Integer = 0 To OdabraneTabele.GetUpperBound(0)
            str = ""
            If OdabraneTabeleKljucevi(i) <> "" Then str = str + OdabraneTabeleKljucevi(i)
            If OdabranaPoljaKojaNisuKljuc(i) <> "" Then str = str + "," + OdabranaPoljaKojaNisuKljuc(i)
            str = str + " from " + OdabraneTabele(i) + " where 2=2 "
            Dim u As String = dajUslovPoTabeli(OdabraneTabele(i)).Trim
            If u.Length > 0 Then str = str & " AND (" & u & ")"
            str = "$" + str
            str = str.Replace("$,", "")
            str = str.Replace("$", "")
            str = "(select " + str + ") as " + OdabraneTabele(i)
            ReDim Preserve selectPoTabeli(i)
            selectPoTabeli(i) = str
        Next

        Dim kljucevi() As String = {}
        For i As Integer = 0 To OdabraneTabele.GetUpperBound(0)
            ReDim Preserve kljucevi(i)
            kljucevi(i) = OdabraneTabele(i) + "," + OdabraneTabeleKljucevi(i)
        Next

        'SPAJANJE PO KLJUCU
        Dim strJOIN As String = "2=2"
        Dim brojTabela As Integer = OdabraneTabele.GetUpperBound(0) + 1
        For i As Integer = 0 To brojTabela - 2
            Dim tabTren As String() = Microsoft.VisualBasic.Split(kljucevi(i), ",")
            For tab As Integer = i + 1 To brojTabela - 1
                Dim tabSled As String() = Microsoft.VisualBasic.Split(kljucevi(tab), ",")
                For iit As Integer = 1 To tabTren.GetUpperBound(0)
                    For iis As Integer = 1 To tabSled.GetUpperBound(0)
                        If tabTren(iit).Trim.ToUpper = tabSled(iis).Trim.ToUpper Then
                            strJOIN = strJOIN + " AND " + tabTren(0) + "." + tabTren(iit) + "=" + tabSled(0) + "." + tabSled(iis)
                            Exit For
                        End If
                    Next
                Next
            Next
        Next

        Dim strSelect As String = ""
        Dim strFrom As String = ""
        For i As Integer = 0 To OdabraneTabele.GetUpperBound(0)
            strSelect = strSelect + SvaOdabranaPolja(i) + ","
        Next
        strSelect = strSelect.Trim.Substring(0, strSelect.Trim.LastIndexOf(","))
        For i As Integer = 0 To OdabraneTabele.GetUpperBound(0)
            strFrom = strFrom + selectPoTabeli(i) + ","
        Next
        strFrom = strFrom.Trim.Substring(0, strFrom.Trim.LastIndexOf(","))

        Dim kako As String = ""
        If Me.cbRazliciti.Checked Then kako = "distinct"

        strSelect = "SELECT " + kako + " " + strSelect & vbCrLf _
                     & Space(6) & "FROM " & strFrom & vbCrLf _
                     & Space(6) & DajOdabranaPoljaFROMCBOSelect & vbCrLf _
                     & Space(6) & "WHERE " & strJOIN

        Dim opetUslov As String = dajUslov()
        If opetUslov.Trim.Length > 0 Then strSelect = strSelect + " AND (" + opetUslov + ")"
        sloziSQL = strSelect
    End Function

    Function dajUslov() As String
        Dim strSQL As String = ""
        Dim cbZL As String = ""
        Dim polje As String = ""
        Dim cbOp As String = ""
        Dim cbVred As String = ""
        Dim tbVred As String = ""
        Dim cbZD As String = ""
        Dim cbVeznik As String = ""
        Dim dtpVred As DateTime

        Dim p As Panel = vidljiviPanel
        Dim polja As String = ""
        If p.Controls.Count > 0 Then
            For Each c As Control In p.Controls
                Dim punoime As String = c.Name
                Dim imePolja As String = c.Name.Substring(c.Name.IndexOf("_") + 1)
                Dim prefiks As String = c.Name.Substring(0, c.Name.IndexOf("_") + 1)

                If prefiks = "LB_" Then
                    Dim ttaabb As String = CType(NadjiKontrolu(p, c.Name), Label).Tag.ToString.Trim
                    polja = polja + ttaabb + "." + imePolja + "$"
                End If
            Next
            polja = polja + "#"
            polja = polja.Replace("$#", "")
            Dim poljaniz As String() = polja.Split("$")
            Dim tb As Boolean = False
            Dim cb As Boolean = False
            Dim dtp As Boolean = False
            Dim tippolja As String = ""
            Dim tbbroj As Boolean = False
            Dim cbbroj As Boolean = False
            Dim cirlat As String = ""
            For i As Integer = 0 To poljaniz.GetUpperBound(0)
                cirlat = ""
                Dim pp As String() = poljaniz(i).Split(".")
                Dim imePolja As String = pp(1)
                Dim imeTabele As String = pp(0)
                Dim vred As String = ""

                cbZL = CType(NadjiKontrolu(p, "CBOZL_" + imePolja), ComboBox).Text.Trim
                polje = CType(NadjiKontrolu(p, "LB_" + imePolja), Label).Text.Trim
                cbOp = CType(NadjiKontrolu(p, "CBOOP_" + imePolja), ComboBox).Text.Trim

                Dim tbcntl As Control = NadjiKontrolu(p, "TP_" + imePolja)
                Dim cbcntl As Control = NadjiKontrolu(p, "CB_" + imePolja)

                If Not tbcntl Is Nothing AndAlso tbcntl.Visible = True Then
                    tbVred = CType(tbcntl, TextBox).Text.Trim
                    tb = True
                    cb = False
                    tippolja = tbcntl.Tag.ToString.ToLower.Trim
                End If
                If Not cbcntl Is Nothing AndAlso cbcntl.Visible = True Then
                    cbVred = CType(cbcntl, ComboBox).SelectedValue.Trim
                    cb = True
                    tb = False
                    tippolja = cbcntl.Tag.ToString.ToLower.Trim
                End If

                cbZD = CType(NadjiKontrolu(p, "CBOZD_" + imePolja), ComboBox).Text.Trim
                cbVeznik = CType(NadjiKontrolu(p, "CBOV_" + imePolja), ComboBox).Text.Trim

                If Not (cbZL = "" AndAlso polje = "" AndAlso cbOp = "" AndAlso cbVred = "" AndAlso tbVred = "" AndAlso cbZD = "" AndAlso cbVeznik = "") Then
                    If cbVeznik = "" Then cbVeznik = "AND"
                    If cb = True Then
                        vred = cbVred.Trim
                        If tippolja = "decimal" OrElse tippolja = "int" OrElse tippolja = "numeric" Then cbbroj = True
                        If cbbroj = False AndAlso cbVred.Trim.ToUpper <> "NULL" AndAlso cbVred.Trim.ToUpper <> "" Then vred = "N'" + vred + "'"
                    End If
                    If dtp = True Then
                        'CONVERT(varchar, datum_insert, 120)
                        '--11-05-2013
                        Dim dd As String = dtpVred.Day.ToString.Trim
                        Dim mm As String = dtpVred.Month.ToString.Trim
                        Dim yyyy As String = dtpVred.Year.ToString.Trim
                        vred = "'" + mm + "/" + dd + "/" + yyyy + "'"
                        'If tippolja = "decimal" OrElse tippolja = "int" OrElse tippolja = "numeric" Then cbbroj = True
                        'If cbbroj = False AndAlso cbVred.Trim.ToUpper <> "NULL" AndAlso cbVred.Trim.ToUpper <> "" Then vred = "N'" + vred + "'"
                    End If
                    If tb = True Then
                        vred = tbVred.Trim
                        If tippolja = "decimal" OrElse tippolja = "int" OrElse tippolja = "numeric" Then tbbroj = True
                        If cbOp = "in" OrElse cbOp = "not in" Then
                            vred = "(" + tbVred.Trim + ")"
                            vred = vred.Replace("((", "(")
                            vred = vred.Replace("))", ")")
                        Else
                            If tbbroj = False AndAlso vred.Trim.ToUpper <> "NULL" AndAlso vred.Trim.ToUpper <> "" Then
                                vred = vred.Replace("'", "")
                                Dim proc As String = ""
                                If IsNumeric(vred) = False Then
                                    Dim vredCir As String = konverzijaLatCir(vred)
                                    Dim vredLat As String = konverzijaCirLat(vred)
                                    If cbOp = "like" OrElse cbOp = "not like " Then proc = "" 'proc = "%"
                                    Dim pomCir As String = "(" & polje & " " & cbOp & " N'" & proc & vredCir & proc & "')"
                                    Dim pomLat As String = "(" & polje & " " & cbOp & " N'" & proc & vredLat & proc & "')"
                                    cirlat = "(" & pomCir & " OR " & pomLat & ")"
                                Else
                                    If cbOp = "like" OrElse cbOp = "not like " Then
                                        'vred = "N'%" + vred + "%'"
                                        vred = "N'" & proc & vred & proc & "'"
                                    Else
                                        vred = "N'" + vred + "'"
                                    End If
                                End If
                            End If
                        End If
                    End If

                    If cbZL.IndexOf("_CopyOf") > 0 Then cbZL = cbZL.Substring(0, cbZL.IndexOf("_CopyOf") + 1)
                    If polje.IndexOf("_CopyOf") > 0 Then polje = polje.Substring(0, polje.IndexOf("_CopyOf") + 1)
                    polje = imeTabele + "." + polje
                    If cbOp.IndexOf("_CopyOf") > 0 Then cbOp = cbOp.Substring(0, cbOp.IndexOf("_CopyOf") + 1)
                    If vred.IndexOf("_CopyOf") > 0 Then vred = vred.Substring(0, vred.IndexOf("_CopyOf") + 1)
                    If cbZD.IndexOf("_CopyOf") > 0 Then cbZD = cbZD.Substring(0, cbZD.IndexOf("_CopyOf") + 1)
                    If cbVeznik.IndexOf("_CopyOf") > 0 Then cbVeznik = cbVeznik.Substring(0, cbVeznik.IndexOf("_CopyOf") + 1)
                End If

                If cirlat = "" Then
                    If vred.Trim.Length > 0 Then strSQL = strSQL + cbZL + polje + " " + cbOp + " " + vred + cbZD + " " + cbVeznik + " "
                Else
                    If vred.Trim.Length > 0 Then strSQL = strSQL + cbZL + cirlat + cbZD + " " + cbVeznik + " "
                End If
            Next

            If strSQL.Trim.Length > 0 Then
                strSQL = "$" + strSQL + "$"
                strSQL = strSQL.Replace("AND $", "")
                strSQL = strSQL.Replace("$ AND", "")
                strSQL = strSQL.Replace("OR $", "")
                strSQL = strSQL.Replace("$ OR", "")
                strSQL = strSQL.Replace("$", "")
            End If
        End If
        dajUslov = strSQL
    End Function

    Function dajUslovPoTabeli(ByVal tab As String) As String
        Dim strSQL As String = ""
        Dim cbZL As String = ""
        Dim polje As String = ""
        Dim cbOp As String = ""
        Dim cbVred As String = ""
        Dim tbVred As String = ""
        Dim dtpVred As DateTime
        Dim cbZD As String = ""
        Dim cbVeznik As String = ""

        Dim p As Panel = vidljiviPanel
        Dim polja As String = ""
        If p.Controls.Count > 0 Then
            For Each c As Control In p.Controls
                Dim punoime As String = c.Name
                Dim imePolja As String = c.Name.Substring(c.Name.IndexOf("_") + 1)
                Dim prefiks As String = c.Name.Substring(0, c.Name.IndexOf("_") + 1)

                If prefiks = "LB_" Then
                    Dim ttaabb As String = CType(NadjiKontrolu(p, c.Name), Label).Tag.ToString.Trim
                    polja = polja + ttaabb + "." + imePolja + "$"
                End If
            Next

            polja = polja + "#"
            polja = polja.Replace("$#", "")
            Dim poljaniz As String() = polja.Split("$")
            Dim tb As Boolean = False
            Dim cb As Boolean = False
            Dim dtp As Boolean = False
            Dim tippolja As String = ""
            Dim tbbroj As Boolean = False
            Dim cbbroj As Boolean = False
            Dim cirlat As String = ""
            For i As Integer = 0 To poljaniz.GetUpperBound(0)
                cirlat = ""
                Dim pp As String() = poljaniz(i).Split(".")
                Dim imePolja As String = pp(1)
                Dim imeTabele As String = pp(0)
                Dim vred As String = ""

                cbZL = CType(NadjiKontrolu(p, "CBOZL_" + imePolja), ComboBox).Text.Trim
                polje = CType(NadjiKontrolu(p, "LB_" + imePolja), Label).Text.Trim
                cbOp = CType(NadjiKontrolu(p, "CBOOP_" + imePolja), ComboBox).Text.Trim

                Dim tbcntl As Control = NadjiKontrolu(p, "TP_" + imePolja)
                Dim dtpcntl As Control = NadjiKontrolu(p, "DTP_" + imePolja)
                Dim cbcntl As Control = NadjiKontrolu(p, "CB_" + imePolja)

                If Not tbcntl Is Nothing AndAlso tbcntl.Visible = True Then
                    tbVred = CType(tbcntl, TextBox).Text.Trim
                    tb = True
                    cb = False
                    dtp = False
                    tippolja = tbcntl.Tag.ToString.ToLower.Trim
                End If
                If Not cbcntl Is Nothing AndAlso cbcntl.Visible = True Then
                    cbVred = CType(cbcntl, ComboBox).SelectedValue.Trim
                    cb = True
                    tb = False
                    dtp = False
                    tippolja = cbcntl.Tag.ToString.ToLower.Trim
                End If
                If Not dtpcntl Is Nothing AndAlso dtpcntl.Visible = True Then
                    dtpVred = CType(dtpcntl, DateTimePicker2).Value
                    cb = False
                    tb = False
                    dtp = True
                    tippolja = dtpcntl.Tag.ToString.ToLower.Trim
                End If

                cbZD = CType(NadjiKontrolu(p, "CBOZD_" + imePolja), ComboBox).Text.Trim
                cbVeznik = CType(NadjiKontrolu(p, "CBOV_" + imePolja), ComboBox).Text.Trim

                If Not (cbZL = "" AndAlso polje = "" AndAlso cbOp = "" AndAlso cbVred = "" AndAlso tbVred = "" AndAlso cbZD = "" AndAlso cbVeznik = "") Then
                    If cbVeznik = "" Then cbVeznik = "AND"
                    If cb = True Then
                        vred = cbVred.Trim
                        If tippolja = "decimal" OrElse tippolja = "int" OrElse tippolja = "numeric" Then cbbroj = True
                        If cbbroj = False AndAlso cbVred.Trim.ToUpper <> "NULL" AndAlso cbVred.Trim.ToUpper <> "" Then vred = "N'" + vred + "'"
                    End If
                    If dtp = True Then
                        'CONVERT(varchar, datum_insert, 120)
                        '--11-05-2013
                        Dim dd As String = dtpVred.Day.ToString.Trim
                        Dim mm As String = dtpVred.Month.ToString.Trim
                        Dim yyyy As String = dtpVred.Year.ToString.Trim
                        vred = "'" + mm + "/" + dd + "/" + yyyy + "'"
                        'If tippolja = "decimal" OrElse tippolja = "int" OrElse tippolja = "numeric" Then cbbroj = True
                        'If cbbroj = False AndAlso cbVred.Trim.ToUpper <> "NULL" AndAlso cbVred.Trim.ToUpper <> "" Then vred = "N'" + vred + "'"
                    End If
                    If tb = True Then
                        vred = tbVred.Trim
                        If tippolja = "decimal" OrElse tippolja = "int" OrElse tippolja = "numeric" Then tbbroj = True
                        If cbOp = "in" OrElse cbOp = "not in" Then
                            vred = "(" + tbVred.Trim + ")"
                            vred = vred.Replace("((", "(")
                            vred = vred.Replace("))", ")")
                        Else
                            If tbbroj = False AndAlso vred.Trim.ToUpper <> "NULL" AndAlso vred.Trim.ToUpper <> "" Then
                                vred = vred.Replace("'", "")
                                Dim proc As String = ""
                                If IsNumeric(vred) = False Then
                                    Dim vredCir As String = konverzijaLatCir(vred)
                                    Dim vredLat As String = konverzijaCirLat(vred)
                                    If cbOp = "like" OrElse cbOp = "not like " Then proc = "" 'proc = "%"
                                    Dim pomCir As String = "(" & polje & " " & cbOp & " N'" & proc & vredCir & proc & "')"
                                    Dim pomLat As String = "(" & polje & " " & cbOp & " N'" & proc & vredLat & proc & "')"
                                    cirlat = "(" & pomCir & " OR " & pomLat & ")"
                                Else
                                    If cbOp = "like" OrElse cbOp = "not like " Then
                                        'vred = "N'%" + vred + "%'"
                                        vred = "N'" & proc & vred & proc & "'"
                                    Else
                                        vred = "N'" + vred + "'"
                                    End If
                                End If
                            End If
                        End If
                    End If
                    If cbZL.IndexOf("_CopyOf") > 0 Then cbZL = cbZL.Substring(0, cbZL.IndexOf("_CopyOf") + 1)
                    If polje.IndexOf("_CopyOf") > 0 Then polje = polje.Substring(0, polje.IndexOf("_CopyOf") + 1)
                    If cbOp.IndexOf("_CopyOf") > 0 Then cbOp = cbOp.Substring(0, cbOp.IndexOf("_CopyOf") + 1)
                    If vred.IndexOf("_CopyOf") > 0 Then vred = vred.Substring(0, vred.IndexOf("_CopyOf") + 1)
                    If cbZD.IndexOf("_CopyOf") > 0 Then cbZD = cbZD.Substring(0, cbZD.IndexOf("_CopyOf") + 1)
                    If cbVeznik.IndexOf("_CopyOf") > 0 Then cbVeznik = cbVeznik.Substring(0, cbVeznik.IndexOf("_CopyOf") + 1)
                End If
                If imeTabele.Trim.ToUpper = tab.Trim.ToUpper Then
                    If cirlat = "" Then
                        If vred.Trim.Length > 0 Then strSQL = strSQL + cbZL + polje + " " + cbOp + " " + vred + cbZD + " " + cbVeznik + " "
                    Else
                        If vred.Trim.Length > 0 Then strSQL = strSQL + cbZL + cirlat + cbZD + " " + cbVeznik + " "
                    End If
                Else ' If imeTabele.Trim.ToUpper <> tab.Trim.ToUpper Then
                    'obrisi AND ili OR na kraju
                    strSQL = strSQL + cbZL + " 2=2 " + cbZD + " " + cbVeznik + " "
                End If
            Next

            If strSQL.Trim.Length > 0 Then
                strSQL = "$" + strSQL + "$"
                strSQL = strSQL.Replace("AND $", "")
                strSQL = strSQL.Replace("$ AND", "")
                strSQL = strSQL.Replace("OR $", "")
                strSQL = strSQL.Replace("$ OR", "")
                strSQL = strSQL.Replace("$", "")
            End If
        End If

        dajUslovPoTabeli = strSQL.Trim
    End Function

    Function zapamtiUslov(ByVal p As Panel) As String
        Dim strSQL As String = ""
        Dim cbZL As String = ""
        Dim polje As String = ""
        Dim cbOp As String = ""
        Dim cbVred As String = ""
        Dim tbVred As String = ""
        Dim cbZD As String = ""
        Dim cbVeznik As String = ""

        Dim polja As String = ""
        Dim tb As Boolean = False
        Dim cb As Boolean = False
        Dim tippolja As String = ""

        Dim iii As String = ""
        If p.Controls.Count > 0 Then
            For Each k As Control In p.Controls
                Dim imePolja As String = k.Name.Substring(k.Name.IndexOf("_") + 1).Trim.ToUpper
                If iii.IndexOf(imePolja + ";") < 0 Then iii = iii + imePolja + ";"
            Next
            iii = iii + ";"
            iii = iii.Replace(";;", "")
        End If
        Dim nizPolja() As String = iii.Split(";")
        Dim c As Control
        For i As Integer = 0 To nizPolja.GetUpperBound(0)
            c = NadjiKontrolu(vidljiviPanel, "CBOZL_" + nizPolja(i))
            If Not c Is Nothing Then strSQL = strSQL + "#" + "cbZL:" + CType(c, ComboBox).Text.Trim + "$"

            c = NadjiKontrolu(vidljiviPanel, "LB_" + nizPolja(i))
            If Not c Is Nothing Then
                Dim ttaabb As String = CType(c, Label).Tag.ToString.Trim
                strSQL = strSQL + "POLJE:" + ttaabb + "." + nizPolja(i) + "$"
            End If

            c = NadjiKontrolu(vidljiviPanel, "CBOOP_" + nizPolja(i))
            If Not c Is Nothing Then strSQL = strSQL + "cbOp:" + CType(c, ComboBox).Text.Trim + "$"

            c = NadjiKontrolu(vidljiviPanel, "TP_" + nizPolja(i))
            If Not c Is Nothing AndAlso c.Visible = True Then
                tbVred = CType(c, TextBox).Text.Trim
                tb = True
                cb = False
                tippolja = c.Tag.ToString.ToLower.Trim
                strSQL = strSQL + "tbVred:" + tbVred + "$"
            End If

            c = NadjiKontrolu(vidljiviPanel, "CB_" + nizPolja(i))
            If Not c Is Nothing AndAlso c.Visible = True Then
                cbVred = CType(c, ComboBox).SelectedValue.Trim
                cb = True
                tb = False
                tippolja = c.Tag.ToString.ToLower.Trim
                strSQL = strSQL + "cbVred:" + cbVred + "$"
            End If

            c = NadjiKontrolu(vidljiviPanel, "CBOZD_" + nizPolja(i))
            If Not c Is Nothing Then
                cbZD = CType(c, ComboBox).Text.Trim
                strSQL = strSQL + "cbZD:" + cbZD + "$"
            End If

            c = NadjiKontrolu(vidljiviPanel, "CBOV_" + nizPolja(i))
            If Not c Is Nothing Then
                cbVeznik = CType(c, ComboBox).Text.Trim
                strSQL = strSQL + "cbVeznik:" + cbVeznik
            End If
        Next
        strSQL = "#" + strSQL
        strSQL = strSQL.Replace("##", "")
        zapamtiUslov = "USLOV:=" + strSQL.Trim
    End Function

    Private Sub tabKontrola_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles tabKontrola.SelectedIndexChanged
        Dim sifist As String = ""
        Dim tc As TabControl = CType(sender, System.Windows.Forms.TabControl)
        Dim tp As TabPage = tc.TabPages(tc.SelectedIndex)
        sifist = tp.Text.Trim
        Dim ptv As TreeView = NadjiKontrolu(PanelContext, "tv_" + sifist)
        Dim pPanel As Panel = NadjiKontrolu(PanelContext, "panel_" + sifist)
        Dim pGrid As DataGridView = NadjiKontroluTab(Me.tabKontrola, "dg_" + sifist)
        Dim pPanelGrid As Panel = NadjiKontroluTab(Me.tabKontrola, "pp_" + sifist)
        Dim pGridLabel As Label = NadjiKontroluTab(Me.tabKontrola, "lblbrr_" + sifist)

        vidljiviPanel.Visible = False
        vidljiviTV.Visible = False
        vidljiviGrid.Visible = False
        vidljiviPanelGrid.Visible = False
        vidljiviGridLabel.Visible = False

        ptv.Visible = True
        pPanel.Visible = True
        pGrid.Visible = True
        pPanelGrid.Visible = True
        pGridLabel.Visible = True

        vidljiviPanel = pPanel
        vidljiviTV = ptv
        vidljiviGrid = pGrid
        vidljiviPanelGrid = pPanelGrid
        vidljiviGridLabel = pGridLabel
        Me.clbAplikacija.SelectedValue = sifist
    End Sub
    Friend Sub PerformSort(ByVal sortOrderList As List(Of KeyValuePair(Of DataGridViewColumn, Boolean)))
        Dim rowComparer As New GridRowComparerUnos(sortOrderList)
        vidljiviGrid.Sort(rowComparer)
    End Sub

    Private Sub ButtonPonisti_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonNPPonisti.Click
        Call ponisti()
    End Sub

    Sub ponistiSve()
        Try
            Dim k As Control
            For Each k In Me.Controls
                If TypeOf k Is Panel AndAlso k.Name.Substring(0, 6) = "panel_" Then Me.Controls.Remove(k)
                If TypeOf k Is TreeView AndAlso k.Name.Substring(0, 3) = "tv_" Then Me.Controls.Remove(k)
            Next
            k = vidljiviPanel
            If Not k Is Nothing Then PanelContext.Controls.Remove(k)
            k = vidljiviTV
            If Not k Is Nothing Then PanelContext.Controls.Remove(k)
            Me.tabKontrola.TabPages.Clear()
            Me.tabKontrola.Visible = False
            If Me.txtTraziPoCLB.Visible = True Then Me.txtTraziPoCLB.Text = ""
            Me.lblAplikacija.Text = ""
        Catch ex As Exception
            Me.tabKontrola.Visible = False
            Me.clbAplikacija.SelectedIndex = -1
            Me.clbAplikacija.Focus()
        End Try
    End Sub

    Private Sub ButtonPonistiSve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNPPonistiSve.Click
        Call ponistiSve()
    End Sub

    Sub ponisti()
        If Not vidljiviTV Is Nothing Then
            For Each n As TreeNode In vidljiviTV.Nodes
                CheckAllChildNodes(n, False)
                n.Checked = False
            Next
            If Not vidljiviPanel Is Nothing Then
                For indx As Integer = vidljiviPanel.Controls.Count - 1 To 0 Step -1
                    Dim cntl As Control
                    cntl = vidljiviPanel.Controls.Item(indx)
                    vidljiviPanel.Controls.Remove(cntl)
                    cntl.Dispose()
                Next
            End If
        End If

        brCntl = 0

        If Not vidljiviGrid Is Nothing Then vidljiviGrid.DataSource = Nothing
        If Not vidljiviGridLabel Is Nothing Then vidljiviGridLabel.Text = ""
        If Not vidljiviPanelGrid Is Nothing Then
            For indx As Integer = vidljiviPanelGrid.Controls.Count - 1 To 0 Step -1
                Dim cntl As Control
                cntl = vidljiviPanelGrid.Controls.Item(indx)
                If TypeOf cntl Is GroupBox Then
                    vidljiviPanelGrid.Controls.Remove(cntl)
                    cntl.Dispose()
                End If
            Next
            vidljiviPanelGrid.Width = 0
        End If

        For Each mi As Object In mnuColumnSve.Items
            If TypeOf mi Is ToolStripMenuItem Then mi.Checked = False
        Next
        For Each mi As Object In mnuColumn.Items
            If TypeOf mi Is ToolStripMenuItem Then mi.Checked = False
        Next
        For Each mi As Object In mnuUngroup.Items
            If TypeOf mi Is ToolStripMenuItem Then mi.Checked = False
        Next
        For Each mi As Object In mnuWithFunction.Items
            If TypeOf mi Is ToolStripMenuItem Then mi.Checked = False
        Next
        Me.cbRazliciti.Checked = False
        Me.btnNPSacuvajUslov.Visible = True
        Me.dgA.Visible = False
        Me.bClose.Visible = False
        Me.btnNPUvuci.Visible = False
        Me.GBLike.Visible = False
        Me.panelPamtiOkvir.Visible = False
        Me.txtPOM.Text = ""
        Me.txtUslov.Text = ""
        Me.txtUslov.Visible = False
        Me.lblPorukaUslov.Visible = False
    End Sub

    Private Sub ButtonPrikaziExcel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonPrikaziExcel.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call osveziDSzaExport(vidljiviGrid)
        Call srediZaExport()
        Export2Excel_DGV(lokalno, DSzaExport, Me.jezik, True, Me.txtPOM.Text, konDepo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub srediZaExport()
        For i As Integer = 0 To DSzaExport.Tables.Count - 1
            Dim dt As System.Data.DataTable = DSzaExport.Tables(i)
            For k As Integer = dt.Columns.Count - 1 To 0 Step -1
                Dim pp As String = dt.Columns(k).Caption.ToString.Trim.ToUpper
                If pp.IndexOf("_NEC") > 0 Then dt.Columns.RemoveAt(k)
            Next
        Next
    End Sub

    Private Sub ButtonXML_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ButtonXML.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call osveziDSzaExport(vidljiviGrid)
        Dim datumVreme As String = Now.ToShortDateString.Trim.Replace("/", "") & "_" & Now.ToShortTimeString.Trim.Replace(":", "")
        Call srediZaExport()
        Export2XML_DGV(datumVreme.Trim, lokalno, DSzaExport, Me.jezik, True, Me.txtPOM.Text, konDepo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btn_JSON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_JSON.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call osveziDSzaExport(vidljiviGrid)
        Dim datumVreme As String = Now.ToShortDateString.Trim.Replace("/", "") & "_" & Now.ToShortTimeString.Trim.Replace(":", "")
        Call srediZaExport()
        Export2JSON_DGV(datumVreme.Trim, lokalno, DSzaExport, Me.jezik, True, Me.txtPOM.Text, konDepo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public sqlMBRIzFajlaUslov As String
    Public mbr As String = ""

    Private Sub bUvuci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPUvuci.Click
        Me.dgA.Visible = False
        Me.bClose.Visible = False
        Me.panelPamtiOkvir.Visible = False

        ''msg 295
        Dim msgtxt295 As String = getMessageText(dtMessages, "295", Me.jezik)
        ''msg 296
        Dim msgtxt296 As String = getMessageText(dtMessages, "296", Me.jezik)

        If btnNPUvuci.Text = msgtxt295 Then
            btnNPUvuci.Text = msgtxt296
            Me.tUvuci.Visible = True
            Me.tUvuci.Width = Me.Width / 2
            Me.tUvuci.Height = Me.Height - 200
            Call centriraj(tUvuci)
            Me.tUvuci.Focus()
        ElseIf btnNPUvuci.Text = msgtxt296 Then
            Call ubaciPoduslov(btnNPUvuci.Tag, vidljiviPanel)
            Me.tUvuci.Visible = False
            Me.tUvuci.Text = ""
            btnNPUvuci.Text = msgtxt295
        End If
    End Sub

    Sub ubaciPoduslov(ByVal imeKontrole As String, ByVal p As Panel)
        Dim ime As String = imeKontrole.Replace("CBOOP_", "")
        Dim pp As String = ""
        If Not NadjiKontrolu(p, "TP_" + ime) Is Nothing Then
            Dim tip As String = NadjiKontrolu(p, "TP_" + ime).Tag
            If tip.Trim.ToUpper = "CHAR" Then pp = "'"
        End If

        Dim str As String = ""
        For Each strLine As String In tUvuci.Text.Split(vbNewLine)
            If strLine.Trim.Length > 0 Then str = str + pp + strLine.Trim + pp + ","
        Next
        str = str + "$"
        str = str.Replace(",$", "")
        str = "(" + str + ")"
        If Not NadjiKontrolu(p, "TP_" + ime) Is Nothing Then CType(NadjiKontrolu(p, "TP_" + ime), TextBox).Text = str.Trim
    End Sub

    Private Sub ButtonZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNPSacuvajUslov.Click
        If Me.tp_naziv.Text.Trim = "" Then
            ''msg 251
            Dim msgtxt251 As String = getMessageText(dtMessages, "251", Me.jezik)
            ISTMessageBox.Show(msgtxt251, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tp_naziv.Focus()
        Else
            upisiUFiksiraniFrameSample(upitzaprikaz)
            ''msg 252
            Dim msgtxt252 As String = getMessageText(dtMessages, "252", Me.jezik)
            ISTMessageBox.Show(msgtxt252, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.tp_naziv.Text = ""
            Me.tp_napomena.Text = ""
            Me.panelPamtiOkvir.Visible = False
            Me.bClose.Visible = False
        End If
    End Sub

    Sub upisiUFiksiraniFrameSample(ByVal uslov As String)
        Dim dt As DataTable
        dt = vidljiviGrid.DataSource
        Dim sql As String = upitzaprikaz.Replace("'", "''").ToUpper

        Dim TabelePoljaUslovi As String = zapamtiPretragu(vidljiviTV, vidljiviPanel)
        TabelePoljaUslovi = TabelePoljaUslovi + zapamtiUslov(vidljiviPanel)
        TabelePoljaUslovi = TabelePoljaUslovi.Replace("'", "''")
        Dim upit As String = "insert into dbo.ISTSavedAdvancedSearch (ko_insert,naziv,napomena,upitPrikaz,sifist,TabelePoljaUslovi) values('" +
        GetUserName.ToString.Trim + "','" + Me.tp_naziv.Text + "','" + Me.tp_napomena.Text + "','" + sql + "','" + Me.clbAplikacija.SelectedValue.trim + "','" + TabelePoljaUslovi + "')"

        Dim ok1 As String = izvrsiSQL(upit, konDepo)
        If ok1 <> "ok" Then
            ISTMessageBox.Show(upit + nvrd + nvrd + "is not executed! ER94", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_Sacuvaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPSacuvajUslov.Click

        If Not vidljiviTV Is Nothing Then
            If prazanTreeView(vidljiviTV) = True Then
                ''msg 245
                Dim msgtxt245 As String = getMessageText(dtMessages, "245", Me.jezik)
                ISTMessageBox.Show(msgtxt245, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                vidljiviTV.Focus()
            Else
                'ISTMessageBox.Show(upitZaPrikaz)
                If upitzaprikaz <> "" Then
                    Me.dgA.Visible = False
                    Me.bClose.Visible = False

                    Call centriraj(panelPamtiOkvir)
                    Dim x As Integer = panelPamtiOkvir.Location.X
                    Dim y As Integer = panelPamtiOkvir.Location.Y
                    Dim x1 As Integer = x + Me.panelPamtiOkvir.Width - bClose.Width
                    Dim y1 As Integer = y - bClose.Height
                    bClose.Location = New Point(x1, y1)
                    panelPamtiOkvir.Visible = True
                    bClose.Visible = True
                Else
                    ''msg 253
                    Dim msgtxt253 As String = getMessageText(dtMessages, "253", Me.jezik)
                    ISTMessageBox.Show(msgtxt253, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If



    End Sub

    Private Sub btn_StariUpit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNPStariUpit.Click
        Call ponisti()
        dajGridT()
    End Sub

    Sub dajGridT()
        Dim sql As String = "select CONVERT(varchar, datum_insert, 120) As datum_insert,ko_insert,naziv as title,napomena as comment,upitPrikaz as query,sifist as appCode,tabelePoljaUslovi as conditions" +
        " FROM dbo.ISTSavedAdvancedSearch where ko_insert='" + GetUserName.ToString.Trim + "' and 2=2 order by datum_insert desc "
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, konDepo, Me.jezik)
        dt.TableName = "ISTSavedAdvancedSearch"
        dgA.DataSource = dt
        dgA.Columns("ko_insert").Visible = False
        dgA.Columns("query").Visible = False
        dgA.Columns("conditions").Visible = False
        dgA.Width = Me.Width - 2.5 * (Me.GB2.Width + 100)
        dgA.Height = Me.Height / 2
        dgA.Font = New System.Drawing.Font("Verdana", 8.0!)
        Call centriraj(dgA)
        Dim x As Integer = dgA.Location.X
        Dim y As Integer = dgA.Location.Y
        Dim x1 As Integer = x + Me.dgA.Width - bClose.Width
        Dim y1 As Integer = y - bClose.Height
        bClose.Location = New Point(x1, y1)
        dgA.Visible = True
        bClose.Visible = True
    End Sub

    Private Sub dgA_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgA.DoubleClick
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dgA.CurrentRow.Index > -1 Then
            Dim strU As String = dgA.CurrentRow.Cells(4).Value.ToString.Trim
            Dim strTPU As String = dgA.CurrentRow.Cells(6).Value.ToString.Trim
            'Call prikazIzSacuvanih(strU)
            clbAplikacija.SelectedValue = dgA.CurrentRow.Cells(5).Value.ToString.Trim
            'ako postoji nadji taj dga
            If (Not Me.ButtonNPIzlaz.Focused) Then
                If Not clbAplikacija.SelectedValue Is Nothing AndAlso clbAplikacija.SelectedValue.Trim <> "" Then
                    Call popuniTv(clbAplikacija.SelectedValue.Trim)
                    Call postaviTv(vidljiviTV, strTPU, vidljiviPanel)
                End If
            End If
            Me.txtUslov.Text = strU
            txtUslov.Width = vidljiviPanel.Width
            txtUslov.Height = vidljiviTV.Height - 100
            txtUslov.Location = vidljiviPanel.Location
            'txtUslov.Visible = True
            'dgA.CaptionText = dgA.CaptionText + " - izabrani uslov: " + strU
        End If
        Me.dgA.Visible = False
        Me.bClose.Visible = False
        Me.panelPamtiOkvir.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub postaviTv(ByVal tv As TreeView, ByVal strTPU As String, ByVal p As Panel)
        'TP:=
        'USLOV:=
        Dim tp As String = ""
        Dim uslov As String = ""
        'ako postoji uslov dodaj panel ako vec nije dodat
        If strTPU.IndexOf("USLOV:=") > 0 Then
            Dim pime As String = tv.Name.Replace("tv_", "panel_")
            If vidljiviPanel Is Nothing Then
                Dim panel As New Panel
                panel.Name = pime
                panel.Location = New System.Drawing.Point(398 + PanelTop.Height, 62)
                panel.Size = (New System.Drawing.Size(548, 245))
                panel.Width = Me.Width - vidljiviTV.Width - Me.GB2.Width - 100
                panel.AllowDrop = True
                PanelContext.Controls.Add(panel)
                vidljiviPanel = panel
            Else
                vidljiviPanel.Visible = True
            End If
        End If

        Call oznaciUTV(tv, strTPU)

    End Sub

    Sub oznaciUTV(ByVal tv As TreeView, ByVal ttpp As String)
        Dim tp As String = ttpp.Split(";")(0).Replace("TP:=", "").Trim.ToUpper
        If tp.IndexOf("DISTINCT") >= 0 Then tp = tp.Replace("DISTINCT", "") : Me.cbRazliciti.Checked = True

        Dim nizUSLOV() As String = ttpp.Split(";")(1).Replace("USLOV:=", "").Split("#")
        Dim tpk As String = "$$"
        For i As Integer = 0 To nizUSLOV.GetUpperBound(0)
            If nizUSLOV(i).Trim <> "" Then
                Dim red() As String = nizUSLOV(i).Split("$")
                For r As Integer = 0 To red.GetUpperBound(0)
                    Dim staL As String = red(r).Split(":")(0).Trim.ToUpper
                    Dim staD As String = red(r).Split(":")(1).Trim.ToUpper
                    If staD.IndexOf("_COPYOF") > 0 Then staD = staD.Substring(0, staD.IndexOf("_COPYOF"))
                    If staL = "POLJE" Then
                        'klik2puta na tabela.polje u vidljivomTV
                        tpk = tpk + staD.Trim.ToUpper + "$$"
                    End If
                Next
            End If
        Next

        Dim nTabela As System.Windows.Forms.TreeNode
        Dim nPolje As System.Windows.Forms.TreeNode
        'Dim polje As String = ""
        Dim tplj() As String = {}
        Dim niztp() As String = tp.Split("$")
        Dim tab As String = ""
        Dim pt As String = ""
        For i As Integer = 0 To niztp.GetUpperBound(0)
            Dim tt As String = niztp(i).Split(":")(0).Trim.ToUpper
            Dim pp As String = niztp(i).Split(":")(1).Trim.ToUpper + ","
            Dim mozet As Boolean = True
            For Each nTabela In tv.Nodes
                If nTabela.Text.Trim.ToUpper = tt Then
                    mozet = True
                    For Each nPolje In nTabela.Nodes
                        If pp.IndexOf(nPolje.Text.Trim.ToUpper + ",") >= 0 Then
                            nPolje.Checked = True
                            If nTabela.IsExpanded = False Then nTabela.Expand()
                        Else
                            mozet = False ' nisu sva polja
                        End If
                    Next nPolje
                    If mozet = True Then nTabela.Checked = True
                End If
            Next nTabela
        Next

        'mora da 2xklik istim redosledom kao u nizUSLOV()
        For i As Integer = 0 To nizUSLOV.GetUpperBound(0)
            If nizUSLOV(i).Trim <> "" Then
                Dim red() As String = nizUSLOV(i).Split("$")
                For r As Integer = 0 To red.GetUpperBound(0)
                    Dim staL As String = red(r).Split(":")(0).Trim.ToUpper
                    Dim staD As String = red(r).Split(":")(1).Trim.ToUpper
                    If staD.IndexOf("_COPYOF") > 0 Then staD = staD.Substring(0, staD.IndexOf("_COPYOF"))
                    If staL = "POLJE" Then
                        Dim tt As String = staD.Split(".")(0).Trim.ToUpper
                        Dim pp As String = staD.Split(".")(1).Trim.ToUpper + ","
                        If pp.IndexOf("_COPYOF") > 0 Then pp = pp.Substring(0, pp.IndexOf("_COPYOF"))
                        'klik2puta na tabela.polje u vidljivomTV
                        tpk = tpk + staD.Trim.ToUpper + "$$"

                        For Each nTabela In tv.Nodes
                            If nTabela.Text.Trim.ToUpper = tt Then
                                For Each nPolje In nTabela.Nodes
                                    If pp.IndexOf(nPolje.Text.Trim.ToUpper + ",") >= 0 Then
                                        Dim x As String = nTabela.Text.Trim.ToUpper + "." + nPolje.Text.Trim.ToUpper
                                        If tpk.IndexOf("$$" + x + "$$") >= 0 Then
                                            Dim ttaagg As String = nPolje.Tag
                                            Dim ime As String = nPolje.Text.Trim
                                            ''2xklik
                                            Call dodaj(ime, vidljiviPanel, ttaagg, tv)
                                            tpk = Replace(tpk, "$$" + x, "", , 1)
                                            If nTabela.IsExpanded = False Then nTabela.Expand()
                                        End If
                                    Else

                                    End If
                                Next nPolje
                            End If
                        Next nTabela
                    End If
                Next
            End If

        Next

        If vidljiviPanel.Controls.Count > 0 Then
            For Each c As Control In vidljiviPanel.Controls
                Dim punoime As String = c.Name
                Dim imePolja As String = c.Name.Substring(c.Name.IndexOf("_") + 1).Trim.ToUpper
                Dim prefiks As String = c.Name.Substring(0, c.Name.IndexOf("_") + 1).Trim.ToUpper
                Dim tabpolje As String = ""
                If prefiks = "LB_" Then
                    Dim imetabele As String = CType(NadjiKontrolu(vidljiviPanel, c.Name), Label).Tag.ToString.Trim
                    tabpolje = imetabele + "." + imePolja
                    Dim praviRed As String = ""
                    Dim nasao As Boolean = False
                    For i As Integer = 0 To nizUSLOV.GetUpperBound(0)
                        Dim red() As String = nizUSLOV(i).Split("$")
                        For r As Integer = 0 To red.GetUpperBound(0)
                            Dim staL As String = red(r).Split(":")(0).Trim.ToUpper
                            Dim staD As String = red(r).Split(":")(1).Trim.ToUpper
                            If staL = "POLJE" AndAlso staD = tabpolje Then
                                'ovo je red koji mi treba
                                praviRed = nizUSLOV(i)
                                nasao = True
                                Exit For
                            End If
                        Next
                        If nasao = True Then Exit For
                    Next
                    Call popuni(tabpolje, imePolja, praviRed)
                End If
            Next
        End If

    End Sub

    Sub popuni(ByVal tabpolje As String, ByVal imePolja As String, ByVal praviRed As String)
        'Dim ime As String = imePolja
        'If ime.IndexOf("_CopyOf") > 0 Then ime = ime.Substring(0, ime.IndexOf("_CopyOf"))
        If praviRed <> "" Then
            Dim pr() As String = praviRed.Split("$")
            For r As Integer = 0 To pr.GetUpperBound(0)
                Dim staL As String = pr(r).Split(":")(0).Trim.ToUpper
                Dim staD As String = pr(r).Split(":")(1).Trim.ToUpper
                If staL = "CBZL" Then
                    Dim k As Control = NadjiKontrolu(vidljiviPanel, "CBOZL_" + imePolja)
                    If Not k Is Nothing Then CType(k, ComboBox).Text = staD
                End If
                If staL = "CBOP" Then
                    Dim k As Control = NadjiKontrolu(vidljiviPanel, "CBOOP_" + imePolja)
                    If Not k Is Nothing Then
                        CType(k, ComboBox).Text = staD
                        Call promeni(k)
                    End If
                End If
                If staL = "TBVRED" Then
                    Dim k As Control = NadjiKontrolu(vidljiviPanel, "TP_" + imePolja)
                    If Not k Is Nothing Then CType(k, TextBox).Text = staD
                End If
                If staL = "CBVRED" Then
                    Dim k As Control = NadjiKontrolu(vidljiviPanel, "CB_" + imePolja)
                    If Not k Is Nothing Then CType(k, ComboBox).SelectedValue = staD
                End If
                If staL = "CBZD" Then
                    Dim k As Control = NadjiKontrolu(vidljiviPanel, "CBOZD_" + imePolja)
                    If Not k Is Nothing Then CType(k, ComboBox).Text = staD
                End If
                If staL = "CBVEZNIK" Then
                    Dim k As Control = NadjiKontrolu(vidljiviPanel, "CBOV_" + imePolja)
                    If Not k Is Nothing Then CType(k, ComboBox).Text = staD
                End If
            Next
        End If

    End Sub

    Sub prikazIzSacuvanih(ByVal uslov As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'red = 0
        'osveziDataGridDT(Nothing, dgA)
        'dajGridF(True, uslov)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ButtonNPCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNPCancel.Click
        Me.panelPamtiOkvir.Visible = False
    End Sub

    Public Function GroupBy(ByVal i_sGroupByColumn As String, ByVal i_sAggregateColumn As String,
                            ByVal i_dSourceTable As DataTable) As DataTable

        Dim dv As New DataView(i_dSourceTable)
        Dim dtGroup As DataTable = dv.ToTable(True, New String() {i_sGroupByColumn})
        dtGroup.Columns.Add("Count", GetType(Integer))
        For Each dr As DataRow In dtGroup.Rows
            dr("Count") = i_dSourceTable.Compute((Convert.ToString("Count(") & i_sAggregateColumn) + ")", (i_sGroupByColumn & Convert.ToString(" = '")) + dr(i_sGroupByColumn) + "'")
        Next
        'sumObject = table.Compute("Sum(Total)", "EmpID = 5")
        Return dtGroup
    End Function

    Function GroupByMultiple(ByVal i_sGroupByColumns As String(), ByVal i_sAggregateColumn As String, ByVal i_dSourceTable As DataTable) As DataTable

        Dim dv As New DataView(i_dSourceTable)
        Dim dtGroup As DataTable = dv.ToTable(True, i_sGroupByColumns)
        dtGroup.Columns.Add("Count", GetType(Integer))
        Dim sCondition As String
        For Each dr As DataRow In dtGroup.Rows
            sCondition = ""
            For i As Integer = 0 To i_sGroupByColumns.Length - 1
                sCondition &= i_sGroupByColumns(i) & " = '" & dr(i_sGroupByColumns(i)) & "' "
                If i < i_sGroupByColumns.Length - 1 Then sCondition &= " AND "
            Next
            dr("Count") = i_dSourceTable.Compute("Count(" & i_sAggregateColumn & ")", sCondition)
        Next
        Return dtGroup
    End Function

    Private Sub bClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bClose.Click
        If Me.dgA.Visible = True Then Me.dgA.Visible = False
        If Me.panelPamtiOkvir.Visible = True Then Me.panelPamtiOkvir.Visible = False
        Me.bClose.Visible = False
    End Sub

    Sub multicolumnsort(ByVal dg As DataGridView)
        Me.dgA.Visible = False
        Me.bClose.Visible = False
        Me.panelPamtiOkvir.Visible = False

        If Not vidljiviGrid Is Nothing Then

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
                Call osveziDSzaExport(dg)
                Me.txtUslov.Text = Me.txtUslov.Text + strOrderby
            End If
        End If
    End Sub

    Public Sub osveziDSzaExport(ByVal dg As DataGridView)
        Dim dt As DataTable = dg.DataSource
        dt.TableName = dg.Name.Replace("dg_", "")
        If DSzaExport IsNot Nothing AndAlso DSzaExport.Tables.Contains(dt.TableName) = True Then
            DSzaExport.Tables.Remove(dt.TableName)
        End If

        DSzaExport.Tables.Add(dt)
    End Sub


    Private Sub FormNpretraga_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Call SettingObjForTheme(GetTheme())
        'Call setTheme(GetTheme())
        clbAplikacija.DrawMode = DrawMode.OwnerDrawFixed
        lblPorukaUslov.Text = ""

        Me.txtTraziPoCLB.Focus()

    End Sub

    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelTop
        ReDim Preserve nizButtonOboji(2)
        nizButtonOboji(2) = btnDown

        zapamtibojuteme = setTheme(nizButtonOboji, Nothing, theme)

    End Sub
    Dim zapamtibojuteme As Color = Nothing
    'Sub setTheme(ByVal theme As String)
    '    If theme = "L" Then
    '        ISTTheme.ChosenTheme("Light")

    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    Else
    '        ISTTheme.ChosenTheme("Dark")

    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    End If
    'End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
    Private Sub dgA_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgA.KeyUp
        Dim dg As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        If e.KeyCode = Keys.Delete Then
            If MsgBox("Brišete ovaj red?",
            MsgBoxStyle.Question + MsgBoxStyle.YesNo +
                         MsgBoxStyle.DefaultButton1,
                           "Potvrda brisanja") = MsgBoxResult.No Then
            Else
                'Dim i As Integer = (dg.CurrentRow.Index + 1).ToString()
                Dim datum_insert As String = dg.CurrentRow.Cells("datum_insert").Value.ToString()
                Dim ko_insert As String = GetUserName()
                Dim naziv As String = dg.CurrentRow.Cells("naziv").Value.ToString()

                Dim upit As String = "delete from ISTSavedAdvancedSearch where CONVERT(varchar, datum_insert, 120)='" + datum_insert _
                + "' and ko_insert=N'" + ko_insert + "' and naziv=N'" + naziv + "'"

                Dim ok1 As String = izvrsiSQL(upit, konDepo)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show(upit + nvrd + nvrd + "is not executed! ER95", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                dajGridT()
            End If

        End If
    End Sub

    Private Sub dgA_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgA.RowPostPaint
        Dim rowIdx As Integer = (e.RowIndex + 1).ToString()
        Dim rowFont As New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim centerFormat As Object = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center

        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top,
        dgA.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Sub ubaciProc(ByVal imeKontrole As String, ByVal p As Panel, ByVal koja As Integer)
        Dim ime As String = imeKontrole.Replace("CBOOP_", "")
        Dim pp As String = ""
        If Not NadjiKontrolu(p, "TP_" + ime) Is Nothing Then
            Dim tip As String = NadjiKontrolu(p, "TP_" + ime).Tag
            If tip.Trim.ToUpper = "CHAR" Then pp = "'"
        End If
        If Not NadjiKontrolu(p, "TP_" + ime) Is Nothing Then
            Dim tekst As String = CType(NadjiKontrolu(p, "TP_" + ime), TextBox).Text
            tekst = tekst.Replace("%", "")
            If koja = 1 Then
                tekst = tekst + "%"
            ElseIf koja = 2 Then
                tekst = "%" + tekst
            Else
                tekst = "%" + tekst + "%"
            End If
            CType(NadjiKontrolu(p, "TP_" + ime), TextBox).Text = tekst
        End If
    End Sub

    Private Sub chStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chStart.Click

        If Me.chStart.Checked = True Then
            Me.chEnd.Checked = False
            Me.chContanes.Checked = False
        Else
            Me.chEnd.Checked = False
            Me.chContanes.Checked = False
        End If

        Call ubaciProc(GBLike.Tag, vidljiviPanel, 1)
    End Sub

    Private Sub chEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chEnd.Click
        If Me.chEnd.Checked = True Then
            Me.chStart.Checked = False
            Me.chContanes.Checked = False
        Else
            Me.chStart.Checked = False
            Me.chContanes.Checked = False
        End If
        Call ubaciProc(GBLike.Tag, vidljiviPanel, 2)
    End Sub

    Private Sub chContanes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chContanes.Click
        If Me.chContanes.Checked = True Then
            Me.chEnd.Checked = False
            Me.chStart.Checked = False
        Else
            Me.chEnd.Checked = False
            Me.chStart.Checked = False
        End If
        Call ubaciProc(GBLike.Tag, vidljiviPanel, 3)
    End Sub

End Class