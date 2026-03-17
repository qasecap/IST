Option Strict Off

Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Web.Script.Serialization
Imports System.Linq
Imports System.Reflection
Imports System.Threading

Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class FormPoljoprivreda
    Inherits FormTemplate
#Region " Windows Form Designer generated code "

    Public Sub New()
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
    Friend WithEvents panelNapomena As Panel
    Friend WithEvents lblKucniBroj As Label
    Friend WithEvents tboxNapomenaRBR As TextBox
    Friend WithEvents btnNapomenaOK As Button
    Friend WithEvents btnNapomenaCancel As Button
    Friend WithEvents PanelZakazivanje As Panel
    Friend WithEvents dtpDatumDolaska As ComboBox
    Friend WithEvents lblDatumDolaska As Label
    Friend WithEvents LabelZNapomena As Label
    Friend WithEvents p1 As Panel
    Friend WithEvents txtAdresa As TextBox
    Friend WithEvents txtPIG As TextBox
    Friend WithEvents p2 As Panel
    Friend WithEvents dtpZakazanoVreme As ComboBox
    Friend WithEvents dtpZakazanoDatum As ComboBox
    Friend WithEvents LabelPopunite As Label
    Friend WithEvents LabelZDatum As Label
    Friend WithEvents LabelKontaktO As Label
    Friend WithEvents txtBrojTelefona As TextBox
    Friend WithEvents txtKontaktOsoba As TextBox
    Friend WithEvents LabelZVreme As Label
    Friend WithEvents btnZakCancel As Button
    Friend WithEvents btnZakOk As Button
    Friend WithEvents txtIshodNapomena As TextBox
    Friend WithEvents ButtonIzlaz As Button
    Friend WithEvents ButtonCancelZahtev As Button
    Friend WithEvents ButtonZahtev As Button
    Friend WithEvents LabelRazlog As Label
    Friend WithEvents tboxNapomenaStatusAnketar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBrojStanaVrataPorukaZahtev As Label
    Friend WithEvents lblBrojStanaVrataZahtev As Label
    Friend WithEvents txtBrojStanaVratazahtev As TextBox
    Friend WithEvents txtUlicaZahtev As TextBox
    Friend WithEvents txtKBrojZahtev As TextBox
    Friend WithEvents txtRbrStanZahtev As TextBox
    Friend WithEvents txtkucni_broj_idCDZahtev As TextBox
    Friend WithEvents llOVDE As LinkLabel
    Friend WithEvents lblNapomenaAdresa As Label
    Friend WithEvents tboxNapomenaPIG As TextBox
    Friend WithEvents ButtonIzvestaji As Button
    Friend WithEvents ButtonLK As Button
    Friend WithEvents LabelTel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb7 As RadioButton
    Friend WithEvents rb6 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents lblPIG As Label
    Friend WithEvents lblkojikont As Label
    Friend WithEvents cbPonistiZak As CheckBox
    Friend WithEvents btnRegBrMP As Button
    Friend WithEvents lblAdresa As Label
    Friend WithEvents lblAdr As Label
    Friend WithEvents lblrbrs As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents txt1 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents PanelLegendaDGV1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDelete As Label
    Friend WithEvents LegendaDelete As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPin As Label
    Friend WithEvents LegendaPin As TextBox
    Friend WithEvents LegendaPencil As TextBox
    Friend WithEvents LegendaHouse As TextBox
    Friend WithEvents lblPencil As Label
    Friend WithEvents lblHouse As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents lblRBR As Label
    Friend WithEvents txtRBR As TextBox
    Friend WithEvents tboxNapomenaNapomena As TextBox
    Friend WithEvents lblNapomenaRBR As Label
    Friend WithEvents lblNapomenaNapomena As Label
    Friend WithEvents tboxNapomenaAdresa As TextBox
    Friend WithEvents lblNapomenaNaslov As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btnLegenda As Button
    Friend WithEvents pbEU As PictureBox
    Friend WithEvents gbStatusi As GroupBox
    Friend WithEvents rbSve As RadioButton
    Friend WithEvents rbVraceno As RadioButton
    Friend WithEvents rbZapoceto As RadioButton
    Friend WithEvents rbZavrsenoP As RadioButton
    Friend WithEvents rbZavrsenoNP As RadioButton
    Friend WithEvents panelZahtevZaDoradu As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tboxZahtevRbr As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tboxZahtevAdresa As TextBox
    Friend WithEvents tboxZahtevPig As TextBox
    Friend WithEvents cbZahtevZaDoradu As CheckBox
    Friend WithEvents btnZahtevCancel As Button
    Friend WithEvents btnZahtevOK As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents tboxZahtevRazlog As TextBox
    Friend WithEvents gbFilteri As GroupBox
    Friend WithEvents filtPig As TextBox
    Friend WithEvents filtDatumZakazan As ComboBox
    Friend WithEvents lblDatZak As Label
    Friend WithEvents lblNaselje As Label
    Friend WithEvents lblPIGF As Label
    Friend WithEvents filtNaseljeee As TextBox
    Friend WithEvents llPonisti As LinkLabel
    Friend WithEvents PanelRegBrMP As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents btnZatvori As Button
    Friend WithEvents DGVRegBrMP As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents lblUkupno As Label
    Friend WithEvents lblRPG As Label
    Friend WithEvents filtRPG As TextBox
    Friend WithEvents btnPutniTroskovi As Button
    Friend WithEvents panelPutniTroskovi As Panel
    Friend WithEvents btnJavPrev As Button
    Friend WithEvents lblPutniTroskovi As Label
    Friend WithEvents btnSopPrev As Button
    Friend WithEvents btnZatvoriPT As Button
    Friend WithEvents labelsToolTip As ToolTip

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPoljoprivreda))
        Me.panelNapomena = New System.Windows.Forms.Panel()
        Me.lblNapomenaNaslov = New System.Windows.Forms.Label()
        Me.tboxNapomenaNapomena = New System.Windows.Forms.TextBox()
        Me.lblNapomenaRBR = New System.Windows.Forms.Label()
        Me.lblNapomenaNapomena = New System.Windows.Forms.Label()
        Me.tboxNapomenaAdresa = New System.Windows.Forms.TextBox()
        Me.lblNapomenaAdresa = New System.Windows.Forms.Label()
        Me.tboxNapomenaPIG = New System.Windows.Forms.TextBox()
        Me.btnNapomenaCancel = New System.Windows.Forms.Button()
        Me.btnNapomenaOK = New System.Windows.Forms.Button()
        Me.lblKucniBroj = New System.Windows.Forms.Label()
        Me.tboxNapomenaRBR = New System.Windows.Forms.TextBox()
        Me.lblkojikont = New System.Windows.Forms.Label()
        Me.txtkucni_broj_idCDZahtev = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblrbrs = New System.Windows.Forms.Label()
        Me.lblAdr = New System.Windows.Forms.Label()
        Me.lblBrojStanaVrataPorukaZahtev = New System.Windows.Forms.Label()
        Me.lblBrojStanaVrataZahtev = New System.Windows.Forms.Label()
        Me.txtBrojStanaVratazahtev = New System.Windows.Forms.TextBox()
        Me.txtUlicaZahtev = New System.Windows.Forms.TextBox()
        Me.txtKBrojZahtev = New System.Windows.Forms.TextBox()
        Me.txtRbrStanZahtev = New System.Windows.Forms.TextBox()
        Me.ButtonCancelZahtev = New System.Windows.Forms.Button()
        Me.ButtonZahtev = New System.Windows.Forms.Button()
        Me.LabelRazlog = New System.Windows.Forms.Label()
        Me.tboxNapomenaStatusAnketar = New System.Windows.Forms.TextBox()
        Me.PanelZakazivanje = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbPonistiZak = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb7 = New System.Windows.Forms.RadioButton()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.dtpDatumDolaska = New System.Windows.Forms.ComboBox()
        Me.lblDatumDolaska = New System.Windows.Forms.Label()
        Me.LabelZNapomena = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.Panel()
        Me.lblRBR = New System.Windows.Forms.Label()
        Me.txtRBR = New System.Windows.Forms.TextBox()
        Me.lblAdresa = New System.Windows.Forms.Label()
        Me.lblPIG = New System.Windows.Forms.Label()
        Me.txtAdresa = New System.Windows.Forms.TextBox()
        Me.txtPIG = New System.Windows.Forms.TextBox()
        Me.p2 = New System.Windows.Forms.Panel()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.dtpZakazanoVreme = New System.Windows.Forms.ComboBox()
        Me.dtpZakazanoDatum = New System.Windows.Forms.ComboBox()
        Me.LabelPopunite = New System.Windows.Forms.Label()
        Me.LabelZDatum = New System.Windows.Forms.Label()
        Me.LabelKontaktO = New System.Windows.Forms.Label()
        Me.txtBrojTelefona = New System.Windows.Forms.TextBox()
        Me.txtKontaktOsoba = New System.Windows.Forms.TextBox()
        Me.LabelZVreme = New System.Windows.Forms.Label()
        Me.btnZakCancel = New System.Windows.Forms.Button()
        Me.btnZakOk = New System.Windows.Forms.Button()
        Me.txtIshodNapomena = New System.Windows.Forms.TextBox()
        Me.ButtonIzlaz = New System.Windows.Forms.Button()
        Me.llOVDE = New System.Windows.Forms.LinkLabel()
        Me.ButtonIzvestaji = New System.Windows.Forms.Button()
        Me.ButtonLK = New System.Windows.Forms.Button()
        Me.btnRegBrMP = New System.Windows.Forms.Button()
        Me.labelsToolTip = New System.Windows.Forms.ToolTip()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PanelLegendaDGV1 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnLegenda = New System.Windows.Forms.Button()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.LegendaHouse = New System.Windows.Forms.TextBox()
        Me.lblHouse = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.LegendaDelete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.LegendaPin = New System.Windows.Forms.TextBox()
        Me.LegendaPencil = New System.Windows.Forms.TextBox()
        Me.lblPencil = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pbEU = New System.Windows.Forms.PictureBox()
        Me.gbStatusi = New System.Windows.Forms.GroupBox()
        Me.rbZavrsenoNP = New System.Windows.Forms.RadioButton()
        Me.rbSve = New System.Windows.Forms.RadioButton()
        Me.rbVraceno = New System.Windows.Forms.RadioButton()
        Me.rbZapoceto = New System.Windows.Forms.RadioButton()
        Me.rbZavrsenoP = New System.Windows.Forms.RadioButton()
        Me.panelZahtevZaDoradu = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tboxZahtevRbr = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tboxZahtevAdresa = New System.Windows.Forms.TextBox()
        Me.tboxZahtevPig = New System.Windows.Forms.TextBox()
        Me.cbZahtevZaDoradu = New System.Windows.Forms.CheckBox()
        Me.btnZahtevCancel = New System.Windows.Forms.Button()
        Me.btnZahtevOK = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tboxZahtevRazlog = New System.Windows.Forms.TextBox()
        Me.gbFilteri = New System.Windows.Forms.GroupBox()
        Me.filtRPG = New System.Windows.Forms.TextBox()
        Me.lblRPG = New System.Windows.Forms.Label()
        Me.filtNaseljeee = New System.Windows.Forms.TextBox()
        Me.lblDatZak = New System.Windows.Forms.Label()
        Me.lblNaselje = New System.Windows.Forms.Label()
        Me.lblPIGF = New System.Windows.Forms.Label()
        Me.filtDatumZakazan = New System.Windows.Forms.ComboBox()
        Me.filtPig = New System.Windows.Forms.TextBox()
        Me.llPonisti = New System.Windows.Forms.LinkLabel()
        Me.PanelRegBrMP = New System.Windows.Forms.Panel()
        Me.DGVRegBrMP = New System.Windows.Forms.DataGridView()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btnZatvori = New System.Windows.Forms.Button()
        Me.lblUkupno = New System.Windows.Forms.Label()
        Me.btnPutniTroskovi = New System.Windows.Forms.Button()
        Me.panelPutniTroskovi = New System.Windows.Forms.Panel()
        Me.btnZatvoriPT = New System.Windows.Forms.Button()
        Me.btnJavPrev = New System.Windows.Forms.Button()
        Me.lblPutniTroskovi = New System.Windows.Forms.Label()
        Me.btnSopPrev = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNapomena.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelZakazivanje.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.PanelLegendaDGV1.SuspendLayout()
        CType(Me.pbEU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStatusi.SuspendLayout()
        Me.panelZahtevZaDoradu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbFilteri.SuspendLayout()
        Me.PanelRegBrMP.SuspendLayout()
        CType(Me.DGVRegBrMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelPutniTroskovi.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelNapomena
        '
        Me.panelNapomena.BackColor = System.Drawing.Color.LightYellow
        Me.panelNapomena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelNapomena.Controls.Add(Me.lblNapomenaNaslov)
        Me.panelNapomena.Controls.Add(Me.tboxNapomenaNapomena)
        Me.panelNapomena.Controls.Add(Me.lblNapomenaRBR)
        Me.panelNapomena.Controls.Add(Me.lblNapomenaNapomena)
        Me.panelNapomena.Controls.Add(Me.tboxNapomenaAdresa)
        Me.panelNapomena.Controls.Add(Me.lblNapomenaAdresa)
        Me.panelNapomena.Controls.Add(Me.tboxNapomenaPIG)
        Me.panelNapomena.Controls.Add(Me.btnNapomenaCancel)
        Me.panelNapomena.Controls.Add(Me.btnNapomenaOK)
        Me.panelNapomena.Controls.Add(Me.lblKucniBroj)
        Me.panelNapomena.Controls.Add(Me.tboxNapomenaRBR)
        Me.panelNapomena.Location = New System.Drawing.Point(535, 491)
        Me.panelNapomena.Name = "panelNapomena"
        Me.panelNapomena.Size = New System.Drawing.Size(613, 286)
        Me.panelNapomena.TabIndex = 50
        Me.panelNapomena.Visible = False
        '
        'lblNapomenaNaslov
        '
        Me.lblNapomenaNaslov.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomenaNaslov.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblNapomenaNaslov.Location = New System.Drawing.Point(2, 2)
        Me.lblNapomenaNaslov.Name = "lblNapomenaNaslov"
        Me.lblNapomenaNaslov.Size = New System.Drawing.Size(239, 19)
        Me.lblNapomenaNaslov.TabIndex = 10000066
        Me.lblNapomenaNaslov.Text = "UNOS NAPOMENE"
        '
        'tboxNapomenaNapomena
        '
        Me.tboxNapomenaNapomena.Location = New System.Drawing.Point(20, 93)
        Me.tboxNapomenaNapomena.MaxLength = 500
        Me.tboxNapomenaNapomena.Multiline = True
        Me.tboxNapomenaNapomena.Name = "tboxNapomenaNapomena"
        Me.tboxNapomenaNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tboxNapomenaNapomena.Size = New System.Drawing.Size(574, 149)
        Me.tboxNapomenaNapomena.TabIndex = 60
        '
        'lblNapomenaRBR
        '
        Me.lblNapomenaRBR.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomenaRBR.Location = New System.Drawing.Point(154, 35)
        Me.lblNapomenaRBR.Name = "lblNapomenaRBR"
        Me.lblNapomenaRBR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNapomenaRBR.Size = New System.Drawing.Size(38, 14)
        Me.lblNapomenaRBR.TabIndex = 10000065
        Me.lblNapomenaRBR.Text = "RBR"
        '
        'lblNapomenaNapomena
        '
        Me.lblNapomenaNapomena.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomenaNapomena.Location = New System.Drawing.Point(15, 72)
        Me.lblNapomenaNapomena.Name = "lblNapomenaNapomena"
        Me.lblNapomenaNapomena.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNapomenaNapomena.Size = New System.Drawing.Size(80, 16)
        Me.lblNapomenaNapomena.TabIndex = 57
        Me.lblNapomenaNapomena.Text = "Napomena"
        '
        'tboxNapomenaAdresa
        '
        Me.tboxNapomenaAdresa.AccessibleName = "CONVERTCIRLAT"
        Me.tboxNapomenaAdresa.Location = New System.Drawing.Point(305, 33)
        Me.tboxNapomenaAdresa.MaxLength = 19
        Me.tboxNapomenaAdresa.Name = "tboxNapomenaAdresa"
        Me.tboxNapomenaAdresa.Size = New System.Drawing.Size(289, 22)
        Me.tboxNapomenaAdresa.TabIndex = 10000064
        '
        'lblNapomenaAdresa
        '
        Me.lblNapomenaAdresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomenaAdresa.Location = New System.Drawing.Point(249, 36)
        Me.lblNapomenaAdresa.Name = "lblNapomenaAdresa"
        Me.lblNapomenaAdresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNapomenaAdresa.Size = New System.Drawing.Size(55, 19)
        Me.lblNapomenaAdresa.TabIndex = 10000059
        Me.lblNapomenaAdresa.Text = "Adresa"
        '
        'tboxNapomenaPIG
        '
        Me.tboxNapomenaPIG.AccessibleName = "CONVERTCIRLAT"
        Me.tboxNapomenaPIG.Enabled = False
        Me.tboxNapomenaPIG.Location = New System.Drawing.Point(43, 32)
        Me.tboxNapomenaPIG.MaxLength = 19
        Me.tboxNapomenaPIG.Name = "tboxNapomenaPIG"
        Me.tboxNapomenaPIG.Size = New System.Drawing.Size(104, 22)
        Me.tboxNapomenaPIG.TabIndex = 10000058
        '
        'btnNapomenaCancel
        '
        Me.btnNapomenaCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnNapomenaCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNapomenaCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNapomenaCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNapomenaCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNapomenaCancel.Location = New System.Drawing.Point(397, 249)
        Me.btnNapomenaCancel.Name = "btnNapomenaCancel"
        Me.btnNapomenaCancel.Size = New System.Drawing.Size(90, 24)
        Me.btnNapomenaCancel.TabIndex = 70
        Me.btnNapomenaCancel.Text = "Cancel"
        Me.btnNapomenaCancel.UseVisualStyleBackColor = False
        '
        'btnNapomenaOK
        '
        Me.btnNapomenaOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNapomenaOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnNapomenaOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNapomenaOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNapomenaOK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNapomenaOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNapomenaOK.Location = New System.Drawing.Point(502, 249)
        Me.btnNapomenaOK.Name = "btnNapomenaOK"
        Me.btnNapomenaOK.Size = New System.Drawing.Size(90, 24)
        Me.btnNapomenaOK.TabIndex = 65
        Me.btnNapomenaOK.Text = "OK"
        Me.btnNapomenaOK.UseVisualStyleBackColor = False
        '
        'lblKucniBroj
        '
        Me.lblKucniBroj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKucniBroj.Location = New System.Drawing.Point(6, 35)
        Me.lblKucniBroj.Name = "lblKucniBroj"
        Me.lblKucniBroj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblKucniBroj.Size = New System.Drawing.Size(34, 14)
        Me.lblKucniBroj.TabIndex = 51
        Me.lblKucniBroj.Text = "PIG"
        '
        'tboxNapomenaRBR
        '
        Me.tboxNapomenaRBR.AccessibleName = "CONVERTCIRLAT"
        Me.tboxNapomenaRBR.Location = New System.Drawing.Point(197, 32)
        Me.tboxNapomenaRBR.MaxLength = 19
        Me.tboxNapomenaRBR.Name = "tboxNapomenaRBR"
        Me.tboxNapomenaRBR.Size = New System.Drawing.Size(43, 22)
        Me.tboxNapomenaRBR.TabIndex = 40
        '
        'lblkojikont
        '
        Me.lblkojikont.AutoSize = True
        Me.lblkojikont.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblkojikont.Location = New System.Drawing.Point(12, 247)
        Me.lblkojikont.Name = "lblkojikont"
        Me.lblkojikont.Size = New System.Drawing.Size(227, 14)
        Me.lblkojikont.TabIndex = 10000066
        Me.lblkojikont.Text = "Zahtev će biti prosleđen instruktoru:"
        '
        'txtkucni_broj_idCDZahtev
        '
        Me.txtkucni_broj_idCDZahtev.Enabled = False
        Me.txtkucni_broj_idCDZahtev.Location = New System.Drawing.Point(80, 205)
        Me.txtkucni_broj_idCDZahtev.Name = "txtkucni_broj_idCDZahtev"
        Me.txtkucni_broj_idCDZahtev.Size = New System.Drawing.Size(142, 20)
        Me.txtkucni_broj_idCDZahtev.TabIndex = 10000060
        Me.txtkucni_broj_idCDZahtev.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblrbrs)
        Me.Panel1.Controls.Add(Me.lblAdr)
        Me.Panel1.Controls.Add(Me.lblBrojStanaVrataPorukaZahtev)
        Me.Panel1.Controls.Add(Me.lblBrojStanaVrataZahtev)
        Me.Panel1.Controls.Add(Me.txtBrojStanaVratazahtev)
        Me.Panel1.Controls.Add(Me.txtUlicaZahtev)
        Me.Panel1.Controls.Add(Me.txtKBrojZahtev)
        Me.Panel1.Controls.Add(Me.txtRbrStanZahtev)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(5, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 76)
        Me.Panel1.TabIndex = 10000059
        '
        'lblrbrs
        '
        Me.lblrbrs.AutoSize = True
        Me.lblrbrs.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblrbrs.Location = New System.Drawing.Point(490, 11)
        Me.lblrbrs.Name = "lblrbrs"
        Me.lblrbrs.Size = New System.Drawing.Size(74, 14)
        Me.lblrbrs.TabIndex = 10000070
        Me.lblrbrs.Text = "Rbr. stana"
        '
        'lblAdr
        '
        Me.lblAdr.AutoSize = True
        Me.lblAdr.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdr.Location = New System.Drawing.Point(108, 11)
        Me.lblAdr.Name = "lblAdr"
        Me.lblAdr.Size = New System.Drawing.Size(53, 14)
        Me.lblAdr.TabIndex = 10000066
        Me.lblAdr.Text = "Adresa"
        '
        'lblBrojStanaVrataPorukaZahtev
        '
        Me.lblBrojStanaVrataPorukaZahtev.AutoSize = True
        Me.lblBrojStanaVrataPorukaZahtev.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblBrojStanaVrataPorukaZahtev.Location = New System.Drawing.Point(348, 36)
        Me.lblBrojStanaVrataPorukaZahtev.Name = "lblBrojStanaVrataPorukaZahtev"
        Me.lblBrojStanaVrataPorukaZahtev.Size = New System.Drawing.Size(237, 14)
        Me.lblBrojStanaVrataPorukaZahtev.TabIndex = 10000065
        Me.lblBrojStanaVrataPorukaZahtev.Text = "Redni broj stana na vratima ne postoji"
        Me.lblBrojStanaVrataPorukaZahtev.Visible = False
        '
        'lblBrojStanaVrataZahtev
        '
        Me.lblBrojStanaVrataZahtev.AutoSize = True
        Me.lblBrojStanaVrataZahtev.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrojStanaVrataZahtev.Location = New System.Drawing.Point(10, 36)
        Me.lblBrojStanaVrataZahtev.Name = "lblBrojStanaVrataZahtev"
        Me.lblBrojStanaVrataZahtev.Size = New System.Drawing.Size(150, 14)
        Me.lblBrojStanaVrataZahtev.TabIndex = 10000063
        Me.lblBrojStanaVrataZahtev.Text = "Broj stana na vratima"
        '
        'txtBrojStanaVratazahtev
        '
        Me.txtBrojStanaVratazahtev.Location = New System.Drawing.Point(164, 36)
        Me.txtBrojStanaVratazahtev.Name = "txtBrojStanaVratazahtev"
        Me.txtBrojStanaVratazahtev.Size = New System.Drawing.Size(132, 20)
        Me.txtBrojStanaVratazahtev.TabIndex = 10000064
        '
        'txtUlicaZahtev
        '
        Me.txtUlicaZahtev.Location = New System.Drawing.Point(164, 8)
        Me.txtUlicaZahtev.Name = "txtUlicaZahtev"
        Me.txtUlicaZahtev.Size = New System.Drawing.Size(323, 20)
        Me.txtUlicaZahtev.TabIndex = 51
        '
        'txtKBrojZahtev
        '
        Me.txtKBrojZahtev.Location = New System.Drawing.Point(407, 8)
        Me.txtKBrojZahtev.Name = "txtKBrojZahtev"
        Me.txtKBrojZahtev.Size = New System.Drawing.Size(79, 20)
        Me.txtKBrojZahtev.TabIndex = 65
        Me.txtKBrojZahtev.Visible = False
        '
        'txtRbrStanZahtev
        '
        Me.txtRbrStanZahtev.Location = New System.Drawing.Point(567, 8)
        Me.txtRbrStanZahtev.Name = "txtRbrStanZahtev"
        Me.txtRbrStanZahtev.Size = New System.Drawing.Size(56, 20)
        Me.txtRbrStanZahtev.TabIndex = 67
        '
        'ButtonCancelZahtev
        '
        Me.ButtonCancelZahtev.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancelZahtev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelZahtev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancelZahtev.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelZahtev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCancelZahtev.Location = New System.Drawing.Point(436, 233)
        Me.ButtonCancelZahtev.Name = "ButtonCancelZahtev"
        Me.ButtonCancelZahtev.Size = New System.Drawing.Size(90, 24)
        Me.ButtonCancelZahtev.TabIndex = 70
        Me.ButtonCancelZahtev.Text = "Cancel"
        Me.ButtonCancelZahtev.UseVisualStyleBackColor = False
        '
        'ButtonZahtev
        '
        Me.ButtonZahtev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonZahtev.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonZahtev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonZahtev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonZahtev.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonZahtev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonZahtev.Location = New System.Drawing.Point(541, 233)
        Me.ButtonZahtev.Name = "ButtonZahtev"
        Me.ButtonZahtev.Size = New System.Drawing.Size(90, 24)
        Me.ButtonZahtev.TabIndex = 65
        Me.ButtonZahtev.Text = "OK"
        Me.ButtonZahtev.UseVisualStyleBackColor = False
        '
        'LabelRazlog
        '
        Me.LabelRazlog.Location = New System.Drawing.Point(239, 108)
        Me.LabelRazlog.Name = "LabelRazlog"
        Me.LabelRazlog.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelRazlog.Size = New System.Drawing.Size(85, 14)
        Me.LabelRazlog.TabIndex = 57
        Me.LabelRazlog.Text = "Razlog"
        '
        'tboxNapomenaStatusAnketar
        '
        Me.tboxNapomenaStatusAnketar.Location = New System.Drawing.Point(330, 108)
        Me.tboxNapomenaStatusAnketar.MaxLength = 500
        Me.tboxNapomenaStatusAnketar.Multiline = True
        Me.tboxNapomenaStatusAnketar.Name = "tboxNapomenaStatusAnketar"
        Me.tboxNapomenaStatusAnketar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tboxNapomenaStatusAnketar.Size = New System.Drawing.Size(301, 119)
        Me.tboxNapomenaStatusAnketar.TabIndex = 60
        '
        'PanelZakazivanje
        '
        Me.PanelZakazivanje.BackColor = System.Drawing.Color.LightYellow
        Me.PanelZakazivanje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelZakazivanje.Controls.Add(Me.Label3)
        Me.PanelZakazivanje.Controls.Add(Me.cbPonistiZak)
        Me.PanelZakazivanje.Controls.Add(Me.GroupBox1)
        Me.PanelZakazivanje.Controls.Add(Me.dtpDatumDolaska)
        Me.PanelZakazivanje.Controls.Add(Me.lblDatumDolaska)
        Me.PanelZakazivanje.Controls.Add(Me.LabelZNapomena)
        Me.PanelZakazivanje.Controls.Add(Me.p1)
        Me.PanelZakazivanje.Controls.Add(Me.p2)
        Me.PanelZakazivanje.Controls.Add(Me.btnZakCancel)
        Me.PanelZakazivanje.Controls.Add(Me.btnZakOk)
        Me.PanelZakazivanje.Controls.Add(Me.txtIshodNapomena)
        Me.PanelZakazivanje.Location = New System.Drawing.Point(600, 183)
        Me.PanelZakazivanje.Name = "PanelZakazivanje"
        Me.PanelZakazivanje.Size = New System.Drawing.Size(852, 582)
        Me.PanelZakazivanje.TabIndex = 1016
        Me.PanelZakazivanje.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(9, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 19)
        Me.Label3.TabIndex = 10000067
        Me.Label3.Text = "UNOS ISHODA POSETE"
        '
        'cbPonistiZak
        '
        Me.cbPonistiZak.AutoSize = True
        Me.cbPonistiZak.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPonistiZak.ForeColor = System.Drawing.Color.DarkRed
        Me.cbPonistiZak.Location = New System.Drawing.Point(11, 556)
        Me.cbPonistiZak.Name = "cbPonistiZak"
        Me.cbPonistiZak.Size = New System.Drawing.Size(214, 22)
        Me.cbPonistiZak.TabIndex = 96
        Me.cbPonistiZak.Text = "Poništi zakazivanje stana"
        Me.cbPonistiZak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb7)
        Me.GroupBox1.Controls.Add(Me.rb6)
        Me.GroupBox1.Controls.Add(Me.rb4)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(835, 128)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ishod posete"
        '
        'rb7
        '
        Me.rb7.AutoSize = True
        Me.rb7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb7.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb7.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb7.Location = New System.Drawing.Point(10, 99)
        Me.rb7.Name = "rb7"
        Me.rb7.Size = New System.Drawing.Size(407, 17)
        Me.rb7.TabIndex = 6
        Me.rb7.TabStop = True
        Me.rb7.Text = "5 - Nije ostvaren kontakt sa domaćinstvom ni posle više pokušaja "
        Me.rb7.UseVisualStyleBackColor = True
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb6.Location = New System.Drawing.Point(10, 79)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(376, 17)
        Me.rb6.TabIndex = 5
        Me.rb6.TabStop = True
        Me.rb6.Text = "4 - Odbijanje (obrazložiti u Napomeni i obavestiti instruktora)"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb4.Location = New System.Drawing.Point(10, 59)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(460, 17)
        Me.rb4.TabIndex = 3
        Me.rb4.TabStop = True
        Me.rb4.Text = "3 - Prekinuto popisivanje (dogovoren termin ponovnog dolaska popisivača) "
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb2.Location = New System.Drawing.Point(10, 39)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(298, 17)
        Me.rb2.TabIndex = 1
        Me.rb2.TabStop = True
        Me.rb2.Text = "2 - Dogovoren drugi termin dolaska popisivača "
        Me.rb2.UseVisualStyleBackColor = True
        '
        'rb1
        '
        Me.rb1.AutoSize = True
        Me.rb1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb1.Location = New System.Drawing.Point(10, 19)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(820, 17)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "1 - Ostavljeno obaveštenje o dolasku popisivača, obrazac P-11 (trenutno nema niko" &
    "ga u gazdinstvu/zatečeno lice ne može da da podatke)"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'dtpDatumDolaska
        '
        Me.dtpDatumDolaska.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.dtpDatumDolaska.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dtpDatumDolaska.CausesValidation = False
        Me.dtpDatumDolaska.DropDownHeight = 125
        Me.dtpDatumDolaska.FormattingEnabled = True
        Me.dtpDatumDolaska.IntegralHeight = False
        Me.dtpDatumDolaska.Items.AddRange(New Object() {"01.10.2023", "02.10.2023", "03.10.2023", "04.10.2023", "05.10.2023", "06.10.2023", "07.10.2023", "08.10.2023", "09.10.2023", "10.10.2023", "11.10.2023", "12.10.2023", "13.10.2023", "14.10.2023", "15.10.2023", "16.10.2023", "17.10.2023", "18.10.2023", "19.10.2023", "20.10.2023", "21.10.2023", "22.10.2023", "23.10.2023", "24.10.2023", "25.10.2023", "26.10.2023", "27.10.2023", "28.10.2023", "29.10.2023", "30.10.2023", "31.10.2023", "01.11.2023", "02.11.2023", "03.11.2023", "04.11.2023", "05.11.2023", "06.11.2023", "07.11.2023", "08.11.2023", "09.11.2023", "10.11.2023", "11.11.2023", "12.11.2023", "13.11.2023", "14.11.2023", "15.11.2023", "01.12.2023", "02.12.2023", "03.12.2023", "04.12.2023", "05.12.2023", "06.12.2023", "07.12.2023", "08.12.2023", "09.12.2023", "10.12.2023", "11.12.2023", "12.12.2023", "13.12.2023", "14.12.2023", "15.12.2023", "16.12.2023", "17.12.2023", "18.12.2023", "19.12.2023", "20.12.2023", "21.12.2023", "22.12.2023", "23.12.2023", "24.12.2023", "25.12.2023", "26.12.2023", "27.12.2023", "28.12.2023", "29.12.2023", "30.12.2023", "31.12.2023", "01.01.2024", "02.01.2024", "03.01.2024", "04.01.2024", "05.01.2024", "06.01.2024", "07.01.2024", "08.01.2024", "09.01.2024", "10.01.2024", "11.01.2024", "12.01.2024", "13.01.2024", "14.01.2024", "15.01.2024", "16.01.2024", "17.01.2024", "18.01.2024", "19.01.2024", "20.01.2024", "21.01.2024", "22.01.2024", "23.01.2024", "24.01.2024", "25.01.2024", "26.01.2024", "27.01.2024", "28.01.2024", "29.01.2024", "30.01.2024", "31.01.2024", "", ""})
        Me.dtpDatumDolaska.Location = New System.Drawing.Point(379, 89)
        Me.dtpDatumDolaska.Name = "dtpDatumDolaska"
        Me.dtpDatumDolaska.Size = New System.Drawing.Size(170, 22)
        Me.dtpDatumDolaska.TabIndex = 93
        '
        'lblDatumDolaska
        '
        Me.lblDatumDolaska.AutoSize = True
        Me.lblDatumDolaska.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDatumDolaska.Location = New System.Drawing.Point(270, 89)
        Me.lblDatumDolaska.Name = "lblDatumDolaska"
        Me.lblDatumDolaska.Size = New System.Drawing.Size(98, 14)
        Me.lblDatumDolaska.TabIndex = 92
        Me.lblDatumDolaska.Text = "Datum posete"
        '
        'LabelZNapomena
        '
        Me.LabelZNapomena.AutoSize = True
        Me.LabelZNapomena.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelZNapomena.Location = New System.Drawing.Point(10, 402)
        Me.LabelZNapomena.Name = "LabelZNapomena"
        Me.LabelZNapomena.Size = New System.Drawing.Size(77, 14)
        Me.LabelZNapomena.TabIndex = 57
        Me.LabelZNapomena.Text = "Napomena"
        '
        'p1
        '
        Me.p1.Controls.Add(Me.lblRBR)
        Me.p1.Controls.Add(Me.txtRBR)
        Me.p1.Controls.Add(Me.lblAdresa)
        Me.p1.Controls.Add(Me.lblPIG)
        Me.p1.Controls.Add(Me.txtAdresa)
        Me.p1.Controls.Add(Me.txtPIG)
        Me.p1.Enabled = False
        Me.p1.Location = New System.Drawing.Point(11, 37)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(833, 39)
        Me.p1.TabIndex = 68
        '
        'lblRBR
        '
        Me.lblRBR.AutoSize = True
        Me.lblRBR.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRBR.Location = New System.Drawing.Point(225, 11)
        Me.lblRBR.Name = "lblRBR"
        Me.lblRBR.Size = New System.Drawing.Size(34, 14)
        Me.lblRBR.TabIndex = 99
        Me.lblRBR.Text = "RBR"
        '
        'txtRBR
        '
        Me.txtRBR.Enabled = False
        Me.txtRBR.Location = New System.Drawing.Point(267, 8)
        Me.txtRBR.Name = "txtRBR"
        Me.txtRBR.Size = New System.Drawing.Size(87, 22)
        Me.txtRBR.TabIndex = 98
        '
        'lblAdresa
        '
        Me.lblAdresa.AutoSize = True
        Me.lblAdresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdresa.Location = New System.Drawing.Point(367, 10)
        Me.lblAdresa.Name = "lblAdresa"
        Me.lblAdresa.Size = New System.Drawing.Size(53, 14)
        Me.lblAdresa.TabIndex = 97
        Me.lblAdresa.Text = "Adresa"
        '
        'lblPIG
        '
        Me.lblPIG.AutoSize = True
        Me.lblPIG.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIG.Location = New System.Drawing.Point(5, 11)
        Me.lblPIG.Name = "lblPIG"
        Me.lblPIG.Size = New System.Drawing.Size(32, 14)
        Me.lblPIG.TabIndex = 96
        Me.lblPIG.Text = "PIG"
        '
        'txtAdresa
        '
        Me.txtAdresa.Enabled = False
        Me.txtAdresa.Location = New System.Drawing.Point(427, 8)
        Me.txtAdresa.Name = "txtAdresa"
        Me.txtAdresa.Size = New System.Drawing.Size(390, 22)
        Me.txtAdresa.TabIndex = 51
        '
        'txtPIG
        '
        Me.txtPIG.Enabled = False
        Me.txtPIG.Location = New System.Drawing.Point(42, 8)
        Me.txtPIG.Name = "txtPIG"
        Me.txtPIG.Size = New System.Drawing.Size(172, 22)
        Me.txtPIG.TabIndex = 67
        '
        'p2
        '
        Me.p2.Controls.Add(Me.LabelTel)
        Me.p2.Controls.Add(Me.dtpZakazanoVreme)
        Me.p2.Controls.Add(Me.dtpZakazanoDatum)
        Me.p2.Controls.Add(Me.LabelPopunite)
        Me.p2.Controls.Add(Me.LabelZDatum)
        Me.p2.Controls.Add(Me.LabelKontaktO)
        Me.p2.Controls.Add(Me.txtBrojTelefona)
        Me.p2.Controls.Add(Me.txtKontaktOsoba)
        Me.p2.Controls.Add(Me.LabelZVreme)
        Me.p2.Location = New System.Drawing.Point(93, 256)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(751, 126)
        Me.p2.TabIndex = 68
        '
        'LabelTel
        '
        Me.LabelTel.Location = New System.Drawing.Point(381, 83)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(65, 20)
        Me.LabelTel.TabIndex = 88
        Me.LabelTel.Text = "Telefon"
        Me.LabelTel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'dtpZakazanoVreme
        '
        Me.dtpZakazanoVreme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.dtpZakazanoVreme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dtpZakazanoVreme.CausesValidation = False
        Me.dtpZakazanoVreme.DropDownHeight = 125
        Me.dtpZakazanoVreme.FormattingEnabled = True
        Me.dtpZakazanoVreme.IntegralHeight = False
        Me.dtpZakazanoVreme.Items.AddRange(New Object() {"08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30", "", "", "", "", ""})
        Me.dtpZakazanoVreme.Location = New System.Drawing.Point(452, 32)
        Me.dtpZakazanoVreme.Name = "dtpZakazanoVreme"
        Me.dtpZakazanoVreme.Size = New System.Drawing.Size(283, 22)
        Me.dtpZakazanoVreme.TabIndex = 70
        '
        'dtpZakazanoDatum
        '
        Me.dtpZakazanoDatum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.dtpZakazanoDatum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dtpZakazanoDatum.CausesValidation = False
        Me.dtpZakazanoDatum.DropDownHeight = 125
        Me.dtpZakazanoDatum.FormattingEnabled = True
        Me.dtpZakazanoDatum.IntegralHeight = False
        Me.dtpZakazanoDatum.Items.AddRange(New Object() {"01.10.2023", "02.10.2023", "03.10.2023", "04.10.2023", "05.10.2023", "06.10.2023", "07.10.2023", "08.10.2023", "09.10.2023", "10.10.2023", "11.10.2023", "12.10.2023", "13.10.2023", "14.10.2023", "15.10.2023", "16.10.2023", "17.10.2023", "18.10.2023", "19.10.2023", "20.10.2023", "21.10.2023", "22.10.2023", "23.10.2023", "24.10.2023", "25.10.2023", "26.10.2023", "27.10.2023", "28.10.2023", "29.10.2023", "30.10.2023", "31.10.2023", "01.11.2023", "02.11.2023", "03.11.2023", "04.11.2023", "05.11.2023", "06.11.2023", "07.11.2023", "08.11.2023", "09.11.2023", "10.11.2023", "11.11.2023", "12.11.2023", "13.11.2023", "14.11.2023", "15.11.2023", "01.12.2023", "02.12.2023", "03.12.2023", "04.12.2023", "05.12.2023", "06.12.2023", "07.12.2023", "08.12.2023", "09.12.2023", "10.12.2023", "11.12.2023", "12.12.2023", "13.12.2023", "14.12.2023", "15.12.2023", "16.12.2023", "17.12.2023", "18.12.2023", "19.12.2023", "20.12.2023", "21.12.2023", "22.12.2023", "23.12.2023", "24.12.2023", "25.12.2023", "26.12.2023", "27.12.2023", "28.12.2023", "29.12.2023", "30.12.2023", "31.12.2023", "01.01.2024", "02.01.2024", "03.01.2024", "04.01.2024", "05.01.2024", "06.01.2024", "07.01.2024", "08.01.2024", "09.01.2024", "10.01.2024", "11.01.2024", "12.01.2024", "13.01.2024", "14.01.2024", "15.01.2024", "16.01.2024", "17.01.2024", "18.01.2024", "19.01.2024", "20.01.2024", "21.01.2024", "22.01.2024", "23.01.2024", "24.01.2024", "25.01.2024", "26.01.2024", "27.01.2024", "28.01.2024", "29.01.2024", "30.01.2024", "31.01.2024", "", ""})
        Me.dtpZakazanoDatum.Location = New System.Drawing.Point(452, 7)
        Me.dtpZakazanoDatum.Name = "dtpZakazanoDatum"
        Me.dtpZakazanoDatum.Size = New System.Drawing.Size(283, 22)
        Me.dtpZakazanoDatum.TabIndex = 68
        '
        'LabelPopunite
        '
        Me.LabelPopunite.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPopunite.Location = New System.Drawing.Point(164, 11)
        Me.LabelPopunite.Name = "LabelPopunite"
        Me.LabelPopunite.Size = New System.Drawing.Size(150, 29)
        Me.LabelPopunite.TabIndex = 84
        Me.LabelPopunite.Text = "Molim vas, popunite:"
        '
        'LabelZDatum
        '
        Me.LabelZDatum.Location = New System.Drawing.Point(319, 11)
        Me.LabelZDatum.Name = "LabelZDatum"
        Me.LabelZDatum.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelZDatum.Size = New System.Drawing.Size(126, 14)
        Me.LabelZDatum.TabIndex = 74
        Me.LabelZDatum.Text = "Zakazano - datum"
        '
        'LabelKontaktO
        '
        Me.LabelKontaktO.Location = New System.Drawing.Point(328, 59)
        Me.LabelKontaktO.Name = "LabelKontaktO"
        Me.LabelKontaktO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelKontaktO.Size = New System.Drawing.Size(117, 14)
        Me.LabelKontaktO.TabIndex = 78
        Me.LabelKontaktO.Text = "Kontakt osoba"
        '
        'txtBrojTelefona
        '
        Me.txtBrojTelefona.Location = New System.Drawing.Point(452, 82)
        Me.txtBrojTelefona.MaxLength = 13
        Me.txtBrojTelefona.Name = "txtBrojTelefona"
        Me.txtBrojTelefona.Size = New System.Drawing.Size(283, 22)
        Me.txtBrojTelefona.TabIndex = 81
        Me.txtBrojTelefona.Tag = "3"
        '
        'txtKontaktOsoba
        '
        Me.txtKontaktOsoba.Location = New System.Drawing.Point(452, 57)
        Me.txtKontaktOsoba.MaxLength = 50
        Me.txtKontaktOsoba.Name = "txtKontaktOsoba"
        Me.txtKontaktOsoba.Size = New System.Drawing.Size(283, 22)
        Me.txtKontaktOsoba.TabIndex = 75
        Me.txtKontaktOsoba.Tag = "3"
        '
        'LabelZVreme
        '
        Me.LabelZVreme.Location = New System.Drawing.Point(319, 35)
        Me.LabelZVreme.Name = "LabelZVreme"
        Me.LabelZVreme.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelZVreme.Size = New System.Drawing.Size(126, 14)
        Me.LabelZVreme.TabIndex = 76
        Me.LabelZVreme.Text = "Zakazano - vreme"
        '
        'btnZakCancel
        '
        Me.btnZakCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnZakCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZakCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZakCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZakCancel.Location = New System.Drawing.Point(649, 551)
        Me.btnZakCancel.Name = "btnZakCancel"
        Me.btnZakCancel.Size = New System.Drawing.Size(90, 24)
        Me.btnZakCancel.TabIndex = 63
        Me.btnZakCancel.Text = "Cancel"
        Me.btnZakCancel.UseVisualStyleBackColor = False
        '
        'btnZakOk
        '
        Me.btnZakOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnZakOk.BackColor = System.Drawing.SystemColors.Control
        Me.btnZakOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZakOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZakOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZakOk.Location = New System.Drawing.Point(754, 551)
        Me.btnZakOk.Name = "btnZakOk"
        Me.btnZakOk.Size = New System.Drawing.Size(90, 24)
        Me.btnZakOk.TabIndex = 61
        Me.btnZakOk.Text = "OK"
        Me.btnZakOk.UseVisualStyleBackColor = False
        '
        'txtIshodNapomena
        '
        Me.txtIshodNapomena.Location = New System.Drawing.Point(10, 422)
        Me.txtIshodNapomena.MaxLength = 500
        Me.txtIshodNapomena.Multiline = True
        Me.txtIshodNapomena.Name = "txtIshodNapomena"
        Me.txtIshodNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIshodNapomena.Size = New System.Drawing.Size(834, 119)
        Me.txtIshodNapomena.TabIndex = 82
        '
        'ButtonIzlaz
        '
        Me.ButtonIzlaz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonIzlaz.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonIzlaz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzlaz.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzlaz.Location = New System.Drawing.Point(1159, 5)
        Me.ButtonIzlaz.Name = "ButtonIzlaz"
        Me.ButtonIzlaz.Size = New System.Drawing.Size(227, 26)
        Me.ButtonIzlaz.TabIndex = 12
        Me.ButtonIzlaz.TabStop = False
        Me.ButtonIzlaz.Text = "Izlaz"
        Me.ButtonIzlaz.UseVisualStyleBackColor = False
        '
        'llOVDE
        '
        Me.llOVDE.AutoSize = True
        Me.llOVDE.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llOVDE.LinkColor = System.Drawing.SystemColors.HotTrack
        Me.llOVDE.Location = New System.Drawing.Point(10, 4)
        Me.llOVDE.Margin = New System.Windows.Forms.Padding(0)
        Me.llOVDE.Name = "llOVDE"
        Me.llOVDE.Size = New System.Drawing.Size(327, 14)
        Me.llOVDE.TabIndex = 1021
        Me.llOVDE.TabStop = True
        Me.llOVDE.Text = "*Izmena naziva ulice koju je popisivač dodao   "
        '
        'ButtonIzvestaji
        '
        Me.ButtonIzvestaji.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonIzvestaji.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonIzvestaji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzvestaji.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzvestaji.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzvestaji.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzvestaji.Location = New System.Drawing.Point(1159, 120)
        Me.ButtonIzvestaji.Name = "ButtonIzvestaji"
        Me.ButtonIzvestaji.Size = New System.Drawing.Size(227, 22)
        Me.ButtonIzvestaji.TabIndex = 10
        Me.ButtonIzvestaji.TabStop = False
        Me.ButtonIzvestaji.Text = "Izveštaji"
        Me.ButtonIzvestaji.UseVisualStyleBackColor = False
        Me.ButtonIzvestaji.Visible = False
        '
        'ButtonLK
        '
        Me.ButtonLK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonLK.BackColor = System.Drawing.Color.Cornsilk
        Me.ButtonLK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLK.Location = New System.Drawing.Point(892, 65)
        Me.ButtonLK.Name = "ButtonLK"
        Me.ButtonLK.Size = New System.Drawing.Size(194, 22)
        Me.ButtonLK.TabIndex = 1031
        Me.ButtonLK.TabStop = False
        Me.ButtonLK.Text = "LK"
        Me.ButtonLK.UseVisualStyleBackColor = False
        Me.ButtonLK.Visible = False
        '
        'btnRegBrMP
        '
        Me.btnRegBrMP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRegBrMP.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegBrMP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegBrMP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegBrMP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegBrMP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRegBrMP.Location = New System.Drawing.Point(1159, 61)
        Me.btnRegBrMP.Name = "btnRegBrMP"
        Me.btnRegBrMP.Size = New System.Drawing.Size(227, 36)
        Me.btnRegBrMP.TabIndex = 11
        Me.btnRegBrMP.TabStop = False
        Me.btnRegBrMP.Text = "PIG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reg br u Ministarstvu poljoprivrede"
        Me.btnRegBrMP.UseVisualStyleBackColor = False
        Me.btnRegBrMP.Visible = False
        '
        'labelsToolTip
        '
        Me.labelsToolTip.ToolTipTitle = "Napomena instruktora"
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.Color.AliceBlue
        Me.TabPage1.Controls.Add(Me.DGV1)
        Me.TabPage1.Controls.Add(Me.txt1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(511, 706)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Popis poljoprivrede 2023"
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV1.Location = New System.Drawing.Point(3, 3)
        Me.DGV1.MultiSelect = False
        Me.DGV1.Name = "DGV1"
        Me.DGV1.ReadOnly = True
        Me.DGV1.RowHeadersWidth = 30
        Me.DGV1.Size = New System.Drawing.Size(505, 700)
        Me.DGV1.TabIndex = 350
        Me.DGV1.Visible = False
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt1.Location = New System.Drawing.Point(22, 5)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(313, 12)
        Me.txt1.TabIndex = 1007
        Me.txt1.TabStop = False
        Me.txt1.Tag = ""
        Me.txt1.Text = "..."
        Me.txt1.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Location = New System.Drawing.Point(7, 255)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(519, 733)
        Me.TabControl1.TabIndex = 1013
        '
        'PanelLegendaDGV1
        '
        Me.PanelLegendaDGV1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelLegendaDGV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox2)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label27)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox1)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label26)
        Me.PanelLegendaDGV1.Controls.Add(Me.btnLegenda)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox12)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label21)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label10)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox6)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label17)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox11)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label16)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox10)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label15)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox9)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label13)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox8)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label11)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox7)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaHouse)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblHouse)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label7)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox5)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label6)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox4)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label5)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox3)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label8)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label9)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label2)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblDelete)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaDelete)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label1)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblPin)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaPin)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaPencil)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblPencil)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label20)
        Me.PanelLegendaDGV1.Location = New System.Drawing.Point(12, 5)
        Me.PanelLegendaDGV1.Name = "PanelLegendaDGV1"
        Me.PanelLegendaDGV1.Size = New System.Drawing.Size(778, 121)
        Me.PanelLegendaDGV1.TabIndex = 1038
        Me.PanelLegendaDGV1.Tag = "NeDiraj"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(446, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(30, 26)
        Me.TextBox2.TabIndex = 1083
        Me.TextBox2.TabStop = False
        Me.TextBox2.Text = "..."
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label27.Location = New System.Drawing.Point(475, 66)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(184, 14)
        Me.Label27.TabIndex = 1082
        Me.Label27.Text = "proširenje kolone za telefon"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(9, 84)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(30, 26)
        Me.TextBox1.TabIndex = 1081
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "🖐"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label26.Location = New System.Drawing.Point(38, 92)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(455, 14)
        Me.Label26.TabIndex = 1080
        Me.Label26.Text = "otvara se prozor za zahtev za doradu popisanog i poslatog gazdinstva"
        '
        'btnLegenda
        '
        Me.btnLegenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLegenda.BackColor = System.Drawing.SystemColors.Control
        Me.btnLegenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLegenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLegenda.Location = New System.Drawing.Point(720, 4)
        Me.btnLegenda.Name = "btnLegenda"
        Me.btnLegenda.Size = New System.Drawing.Size(33, 23)
        Me.btnLegenda.TabIndex = 1053
        Me.btnLegenda.Text = "_"
        Me.btnLegenda.UseVisualStyleBackColor = False
        Me.btnLegenda.Visible = False
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox12.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(9, 29)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(30, 26)
        Me.TextBox12.TabIndex = 1040
        Me.TextBox12.TabStop = False
        Me.TextBox12.Text = "+"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label21.Location = New System.Drawing.Point(38, 37)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(447, 14)
        Me.Label21.TabIndex = 1039
        Me.Label21.Text = "otvara se prozor za dodavanje novog gazdinstva na izabranom PIG-u"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label10.Location = New System.Drawing.Point(36, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 14)
        Me.Label10.TabIndex = 1069
        Me.Label10.Text = "Navodnjavanje"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(6, 266)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(30, 26)
        Me.TextBox6.TabIndex = 1068
        Me.TextBox6.TabStop = False
        Me.TextBox6.Text = "💧"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label17.Location = New System.Drawing.Point(301, 279)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(173, 14)
        Me.Label17.TabIndex = 1079
        Me.Label17.Text = "Ostali podaci o gazdinstvu"
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(271, 267)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(30, 26)
        Me.TextBox11.TabIndex = 1078
        Me.TextBox11.TabStop = False
        Me.TextBox11.Text = "💬"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label16.Location = New System.Drawing.Point(301, 251)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(196, 14)
        Me.Label16.TabIndex = 1077
        Me.Label16.Text = "Obrada i održavanje zemljišta"
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox10.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(271, 239)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(30, 26)
        Me.TextBox10.TabIndex = 1076
        Me.TextBox10.TabStop = False
        Me.TextBox10.Text = "🏕"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label15.Location = New System.Drawing.Point(301, 223)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(294, 14)
        Me.Label15.TabIndex = 1075
        Me.Label15.Text = "Poljoprivredna mehanizacija, oprema i objekti"
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox9.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(271, 211)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(30, 26)
        Me.TextBox9.TabIndex = 1074
        Me.TextBox9.TabStop = False
        Me.TextBox9.Text = "🚜"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label13.Location = New System.Drawing.Point(301, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 14)
        Me.Label13.TabIndex = 1073
        Me.Label13.Text = "Načini držanja stoke"
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox8.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(271, 184)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(30, 26)
        Me.TextBox8.TabIndex = 1072
        Me.TextBox8.TabStop = False
        Me.TextBox8.Text = "🏡"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label11.Location = New System.Drawing.Point(301, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 14)
        Me.Label11.TabIndex = 1071
        Me.Label11.Text = "Upotreba đubriva"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(271, 156)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(30, 26)
        Me.TextBox7.TabIndex = 1070
        Me.TextBox7.TabStop = False
        Me.TextBox7.Text = "♺"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LegendaHouse
        '
        Me.LegendaHouse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaHouse.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaHouse.Location = New System.Drawing.Point(446, 29)
        Me.LegendaHouse.Name = "LegendaHouse"
        Me.LegendaHouse.ReadOnly = True
        Me.LegendaHouse.Size = New System.Drawing.Size(30, 26)
        Me.LegendaHouse.TabIndex = 1020
        Me.LegendaHouse.TabStop = False
        Me.LegendaHouse.Text = "🖉"
        Me.LegendaHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHouse
        '
        Me.lblHouse.AutoSize = True
        Me.lblHouse.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblHouse.Location = New System.Drawing.Point(475, 39)
        Me.lblHouse.Name = "lblHouse"
        Me.lblHouse.Size = New System.Drawing.Size(322, 14)
        Me.lblHouse.TabIndex = 68
        Me.lblHouse.Text = "otvara se prozor za unos napomene o gazdinstvu"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label7.Location = New System.Drawing.Point(36, 251)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 14)
        Me.Label7.TabIndex = 1067
        Me.Label7.Text = "Radna snaga i aktivnosti gazdinstva"
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(6, 239)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(30, 26)
        Me.TextBox5.TabIndex = 1066
        Me.TextBox5.TabStop = False
        Me.TextBox5.Text = "👪"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label6.Location = New System.Drawing.Point(36, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 14)
        Me.Label6.TabIndex = 1065
        Me.Label6.Text = "Stoka, pčele i druge životinje"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(6, 212)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(30, 26)
        Me.TextBox4.TabIndex = 1064
        Me.TextBox4.TabStop = False
        Me.TextBox4.Text = "🐷"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label5.Location = New System.Drawing.Point(36, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 14)
        Me.Label5.TabIndex = 1063
        Me.Label5.Text = "Voćnjaci i vinogradi"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(6, 185)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(30, 26)
        Me.TextBox3.TabIndex = 1062
        Me.TextBox3.TabStop = False
        Me.TextBox3.Text = "🍒"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, -1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 1059
        Me.Label8.Text = "LEGENDA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label9.Location = New System.Drawing.Point(87, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 14)
        Me.Label9.TabIndex = 1058
        Me.Label9.Text = "U prikazanoj tabeli, klikom na ikonicu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label2.Location = New System.Drawing.Point(519, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 14)
        Me.Label2.TabIndex = 1047
        Me.Label2.Text = "Otvaranje aplikacije za unos po poglavljima:"
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblDelete.Location = New System.Drawing.Point(36, 170)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(158, 14)
        Me.lblDelete.TabIndex = 1026
        Me.lblDelete.Text = "Poljoprivredno zemljište"
        '
        'LegendaDelete
        '
        Me.LegendaDelete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaDelete.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaDelete.Location = New System.Drawing.Point(6, 158)
        Me.LegendaDelete.Name = "LegendaDelete"
        Me.LegendaDelete.ReadOnly = True
        Me.LegendaDelete.Size = New System.Drawing.Size(30, 26)
        Me.LegendaDelete.TabIndex = 1022
        Me.LegendaDelete.TabStop = False
        Me.LegendaDelete.Text = "🌻"
        Me.LegendaDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label1.Location = New System.Drawing.Point(3, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(935, 14)
        Me.Label1.TabIndex = 1046
        Me.Label1.Text = "_________________________________________________________________________________" &
    "___________________________________"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPin.Location = New System.Drawing.Point(476, 95)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(143, 14)
        Me.lblPin.TabIndex = 1030
        Me.lblPin.Text = "otvara se upitnik (P1)"
        '
        'LegendaPin
        '
        Me.LegendaPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPin.Location = New System.Drawing.Point(446, 83)
        Me.LegendaPin.Name = "LegendaPin"
        Me.LegendaPin.ReadOnly = True
        Me.LegendaPin.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPin.TabIndex = 1029
        Me.LegendaPin.TabStop = False
        Me.LegendaPin.Text = "📝"
        Me.LegendaPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LegendaPencil
        '
        Me.LegendaPencil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPencil.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPencil.Location = New System.Drawing.Point(9, 56)
        Me.LegendaPencil.Name = "LegendaPencil"
        Me.LegendaPencil.ReadOnly = True
        Me.LegendaPencil.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPencil.TabIndex = 1021
        Me.LegendaPencil.TabStop = False
        Me.LegendaPencil.Text = "🗓"
        Me.LegendaPencil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPencil
        '
        Me.lblPencil.AutoSize = True
        Me.lblPencil.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPencil.Location = New System.Drawing.Point(38, 65)
        Me.lblPencil.Name = "lblPencil"
        Me.lblPencil.Size = New System.Drawing.Size(415, 14)
        Me.lblPencil.TabIndex = 70
        Me.lblPencil.Text = "otvara se prozor za zakazivanje ponovnog dolaska u gazdinstvo"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 51)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 25)
        Me.Label20.TabIndex = 66
        '
        'pbEU
        '
        Me.pbEU.Image = CType(resources.GetObject("pbEU.Image"), System.Drawing.Image)
        Me.pbEU.InitialImage = CType(resources.GetObject("pbEU.InitialImage"), System.Drawing.Image)
        Me.pbEU.Location = New System.Drawing.Point(944, 6)
        Me.pbEU.Name = "pbEU"
        Me.pbEU.Size = New System.Drawing.Size(134, 38)
        Me.pbEU.TabIndex = 1039
        Me.pbEU.TabStop = False
        '
        'gbStatusi
        '
        Me.gbStatusi.Controls.Add(Me.rbZavrsenoNP)
        Me.gbStatusi.Controls.Add(Me.rbSve)
        Me.gbStatusi.Controls.Add(Me.rbVraceno)
        Me.gbStatusi.Controls.Add(Me.rbZapoceto)
        Me.gbStatusi.Controls.Add(Me.rbZavrsenoP)
        Me.gbStatusi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbStatusi.Location = New System.Drawing.Point(10, 162)
        Me.gbStatusi.Name = "gbStatusi"
        Me.gbStatusi.Size = New System.Drawing.Size(549, 41)
        Me.gbStatusi.TabIndex = 1040
        Me.gbStatusi.TabStop = False
        Me.gbStatusi.Text = "Statusi"
        '
        'rbZavrsenoNP
        '
        Me.rbZavrsenoNP.AutoSize = True
        Me.rbZavrsenoNP.BackColor = System.Drawing.Color.Honeydew
        Me.rbZavrsenoNP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbZavrsenoNP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbZavrsenoNP.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbZavrsenoNP.Location = New System.Drawing.Point(108, 19)
        Me.rbZavrsenoNP.Name = "rbZavrsenoNP"
        Me.rbZavrsenoNP.Size = New System.Drawing.Size(163, 17)
        Me.rbZavrsenoNP.TabIndex = 6
        Me.rbZavrsenoNP.TabStop = True
        Me.rbZavrsenoNP.Text = "Završeno (nije poslato) "
        Me.rbZavrsenoNP.UseVisualStyleBackColor = False
        '
        'rbSve
        '
        Me.rbSve.AutoSize = True
        Me.rbSve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSve.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbSve.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbSve.Location = New System.Drawing.Point(503, 19)
        Me.rbSve.Name = "rbSve"
        Me.rbSve.Size = New System.Drawing.Size(47, 17)
        Me.rbSve.TabIndex = 5
        Me.rbSve.TabStop = True
        Me.rbSve.Text = "Sve"
        Me.rbSve.UseVisualStyleBackColor = True
        '
        'rbVraceno
        '
        Me.rbVraceno.AutoSize = True
        Me.rbVraceno.BackColor = System.Drawing.Color.MistyRose
        Me.rbVraceno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbVraceno.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbVraceno.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbVraceno.Location = New System.Drawing.Point(363, 19)
        Me.rbVraceno.Name = "rbVraceno"
        Me.rbVraceno.Size = New System.Drawing.Size(134, 17)
        Me.rbVraceno.TabIndex = 3
        Me.rbVraceno.TabStop = True
        Me.rbVraceno.Text = "Vraćeno na doradu"
        Me.rbVraceno.UseVisualStyleBackColor = False
        '
        'rbZapoceto
        '
        Me.rbZapoceto.AutoSize = True
        Me.rbZapoceto.BackColor = System.Drawing.Color.LightYellow
        Me.rbZapoceto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbZapoceto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbZapoceto.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbZapoceto.Location = New System.Drawing.Point(279, 19)
        Me.rbZapoceto.Name = "rbZapoceto"
        Me.rbZapoceto.Size = New System.Drawing.Size(78, 17)
        Me.rbZapoceto.TabIndex = 1
        Me.rbZapoceto.TabStop = True
        Me.rbZapoceto.Text = "Započeto"
        Me.rbZapoceto.UseVisualStyleBackColor = False
        '
        'rbZavrsenoP
        '
        Me.rbZavrsenoP.AutoSize = True
        Me.rbZavrsenoP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbZavrsenoP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbZavrsenoP.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbZavrsenoP.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbZavrsenoP.Location = New System.Drawing.Point(11, 19)
        Me.rbZavrsenoP.Name = "rbZavrsenoP"
        Me.rbZavrsenoP.Size = New System.Drawing.Size(134, 17)
        Me.rbZavrsenoP.TabIndex = 0
        Me.rbZavrsenoP.TabStop = True
        Me.rbZavrsenoP.Text = "Završeno (poslato)"
        Me.rbZavrsenoP.UseVisualStyleBackColor = False
        '
        'panelZahtevZaDoradu
        '
        Me.panelZahtevZaDoradu.BackColor = System.Drawing.Color.LightYellow
        Me.panelZahtevZaDoradu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelZahtevZaDoradu.Controls.Add(Me.Label4)
        Me.panelZahtevZaDoradu.Controls.Add(Me.Panel3)
        Me.panelZahtevZaDoradu.Controls.Add(Me.cbZahtevZaDoradu)
        Me.panelZahtevZaDoradu.Controls.Add(Me.btnZahtevCancel)
        Me.panelZahtevZaDoradu.Controls.Add(Me.btnZahtevOK)
        Me.panelZahtevZaDoradu.Controls.Add(Me.Label22)
        Me.panelZahtevZaDoradu.Controls.Add(Me.tboxZahtevRazlog)
        Me.panelZahtevZaDoradu.Location = New System.Drawing.Point(569, 414)
        Me.panelZahtevZaDoradu.Name = "panelZahtevZaDoradu"
        Me.panelZahtevZaDoradu.Size = New System.Drawing.Size(705, 265)
        Me.panelZahtevZaDoradu.TabIndex = 1041
        Me.panelZahtevZaDoradu.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(9, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(377, 19)
        Me.Label4.TabIndex = 10000068
        Me.Label4.Text = "ZAHTEV ZA DORADU POSLATOG GAZDINSTVA"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.tboxZahtevRbr)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.tboxZahtevAdresa)
        Me.Panel3.Controls.Add(Me.tboxZahtevPig)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(15, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(681, 39)
        Me.Panel3.TabIndex = 10000067
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(185, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 14)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "RBR"
        '
        'tboxZahtevRbr
        '
        Me.tboxZahtevRbr.Enabled = False
        Me.tboxZahtevRbr.Location = New System.Drawing.Point(219, 8)
        Me.tboxZahtevRbr.Name = "tboxZahtevRbr"
        Me.tboxZahtevRbr.Size = New System.Drawing.Size(44, 22)
        Me.tboxZahtevRbr.TabIndex = 98
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(281, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 14)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "Adresa"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 14)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "PIG"
        '
        'tboxZahtevAdresa
        '
        Me.tboxZahtevAdresa.Enabled = False
        Me.tboxZahtevAdresa.Location = New System.Drawing.Point(341, 8)
        Me.tboxZahtevAdresa.Name = "tboxZahtevAdresa"
        Me.tboxZahtevAdresa.Size = New System.Drawing.Size(334, 22)
        Me.tboxZahtevAdresa.TabIndex = 51
        '
        'tboxZahtevPig
        '
        Me.tboxZahtevPig.Enabled = False
        Me.tboxZahtevPig.Location = New System.Drawing.Point(38, 8)
        Me.tboxZahtevPig.Name = "tboxZahtevPig"
        Me.tboxZahtevPig.Size = New System.Drawing.Size(127, 22)
        Me.tboxZahtevPig.TabIndex = 67
        '
        'cbZahtevZaDoradu
        '
        Me.cbZahtevZaDoradu.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.cbZahtevZaDoradu.AutoSize = True
        Me.cbZahtevZaDoradu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbZahtevZaDoradu.Location = New System.Drawing.Point(15, 92)
        Me.cbZahtevZaDoradu.Name = "cbZahtevZaDoradu"
        Me.cbZahtevZaDoradu.Size = New System.Drawing.Size(337, 18)
        Me.cbZahtevZaDoradu.TabIndex = 10000058
        Me.cbZahtevZaDoradu.Tag = "1"
        Me.cbZahtevZaDoradu.Text = "Zahtev popisivača za doradu poslatog gazdinstva"
        Me.cbZahtevZaDoradu.UseVisualStyleBackColor = True
        '
        'btnZahtevCancel
        '
        Me.btnZahtevCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnZahtevCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZahtevCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZahtevCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZahtevCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZahtevCancel.Location = New System.Drawing.Point(495, 231)
        Me.btnZahtevCancel.Name = "btnZahtevCancel"
        Me.btnZahtevCancel.Size = New System.Drawing.Size(90, 24)
        Me.btnZahtevCancel.TabIndex = 70
        Me.btnZahtevCancel.Text = "Cancel"
        Me.btnZahtevCancel.UseVisualStyleBackColor = False
        '
        'btnZahtevOK
        '
        Me.btnZahtevOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnZahtevOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnZahtevOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZahtevOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZahtevOK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZahtevOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZahtevOK.Location = New System.Drawing.Point(600, 231)
        Me.btnZahtevOK.Name = "btnZahtevOK"
        Me.btnZahtevOK.Size = New System.Drawing.Size(90, 24)
        Me.btnZahtevOK.TabIndex = 65
        Me.btnZahtevOK.Text = "OK"
        Me.btnZahtevOK.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(7, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label22.Size = New System.Drawing.Size(55, 15)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Razlog"
        '
        'tboxZahtevRazlog
        '
        Me.tboxZahtevRazlog.Location = New System.Drawing.Point(12, 141)
        Me.tboxZahtevRazlog.MaxLength = 500
        Me.tboxZahtevRazlog.Multiline = True
        Me.tboxZahtevRazlog.Name = "tboxZahtevRazlog"
        Me.tboxZahtevRazlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tboxZahtevRazlog.Size = New System.Drawing.Size(681, 82)
        Me.tboxZahtevRazlog.TabIndex = 60
        '
        'gbFilteri
        '
        Me.gbFilteri.Controls.Add(Me.filtRPG)
        Me.gbFilteri.Controls.Add(Me.lblRPG)
        Me.gbFilteri.Controls.Add(Me.filtNaseljeee)
        Me.gbFilteri.Controls.Add(Me.lblDatZak)
        Me.gbFilteri.Controls.Add(Me.lblNaselje)
        Me.gbFilteri.Controls.Add(Me.lblPIGF)
        Me.gbFilteri.Controls.Add(Me.filtDatumZakazan)
        Me.gbFilteri.Controls.Add(Me.filtPig)
        Me.gbFilteri.Controls.Add(Me.llPonisti)
        Me.gbFilteri.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbFilteri.Location = New System.Drawing.Point(12, 208)
        Me.gbFilteri.Name = "gbFilteri"
        Me.gbFilteri.Size = New System.Drawing.Size(854, 41)
        Me.gbFilteri.TabIndex = 1042
        Me.gbFilteri.TabStop = False
        Me.gbFilteri.Text = "Filteri"
        '
        'filtRPG
        '
        Me.filtRPG.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtRPG.Location = New System.Drawing.Point(205, 15)
        Me.filtRPG.Name = "filtRPG"
        Me.filtRPG.Size = New System.Drawing.Size(110, 22)
        Me.filtRPG.TabIndex = 1044
        Me.filtRPG.Visible = False
        '
        'lblRPG
        '
        Me.lblRPG.AutoSize = True
        Me.lblRPG.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPG.Location = New System.Drawing.Point(167, 19)
        Me.lblRPG.Name = "lblRPG"
        Me.lblRPG.Size = New System.Drawing.Size(32, 14)
        Me.lblRPG.TabIndex = 1045
        Me.lblRPG.Text = "RPG"
        '
        'filtNaseljeee
        '
        Me.filtNaseljeee.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtNaseljeee.Location = New System.Drawing.Point(372, 17)
        Me.filtNaseljeee.Name = "filtNaseljeee"
        Me.filtNaseljeee.Size = New System.Drawing.Size(134, 22)
        Me.filtNaseljeee.TabIndex = 100
        '
        'lblDatZak
        '
        Me.lblDatZak.AutoSize = True
        Me.lblDatZak.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatZak.Location = New System.Drawing.Point(511, 20)
        Me.lblDatZak.Name = "lblDatZak"
        Me.lblDatZak.Size = New System.Drawing.Size(127, 14)
        Me.lblDatZak.TabIndex = 99
        Me.lblDatZak.Text = "Datum zakazivanja"
        '
        'lblNaselje
        '
        Me.lblNaselje.AutoSize = True
        Me.lblNaselje.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNaselje.Location = New System.Drawing.Point(320, 19)
        Me.lblNaselje.Name = "lblNaselje"
        Me.lblNaselje.Size = New System.Drawing.Size(54, 14)
        Me.lblNaselje.TabIndex = 98
        Me.lblNaselje.Text = "Naselje"
        '
        'lblPIGF
        '
        Me.lblPIGF.AutoSize = True
        Me.lblPIGF.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIGF.Location = New System.Drawing.Point(10, 19)
        Me.lblPIGF.Name = "lblPIGF"
        Me.lblPIGF.Size = New System.Drawing.Size(29, 14)
        Me.lblPIGF.TabIndex = 97
        Me.lblPIGF.Text = "PIG"
        '
        'filtDatumZakazan
        '
        Me.filtDatumZakazan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtDatumZakazan.FormattingEnabled = True
        Me.filtDatumZakazan.Location = New System.Drawing.Point(649, 17)
        Me.filtDatumZakazan.Name = "filtDatumZakazan"
        Me.filtDatumZakazan.Size = New System.Drawing.Size(104, 22)
        Me.filtDatumZakazan.TabIndex = 2
        '
        'filtPig
        '
        Me.filtPig.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtPig.Location = New System.Drawing.Point(45, 15)
        Me.filtPig.Name = "filtPig"
        Me.filtPig.Size = New System.Drawing.Size(115, 22)
        Me.filtPig.TabIndex = 0
        Me.filtPig.Visible = False
        '
        'llPonisti
        '
        Me.llPonisti.ActiveLinkColor = System.Drawing.Color.Black
        Me.llPonisti.AutoSize = True
        Me.llPonisti.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llPonisti.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.llPonisti.LinkColor = System.Drawing.Color.Black
        Me.llPonisti.LinkVisited = True
        Me.llPonisti.Location = New System.Drawing.Point(764, 13)
        Me.llPonisti.Margin = New System.Windows.Forms.Padding(0)
        Me.llPonisti.Name = "llPonisti"
        Me.llPonisti.Size = New System.Drawing.Size(29, 25)
        Me.llPonisti.TabIndex = 1043
        Me.llPonisti.TabStop = True
        Me.llPonisti.Text = "⛝"
        Me.llPonisti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.llPonisti.VisitedLinkColor = System.Drawing.Color.Black
        '
        'PanelRegBrMP
        '
        Me.PanelRegBrMP.BackColor = System.Drawing.Color.LightGray
        Me.PanelRegBrMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelRegBrMP.Controls.Add(Me.DGVRegBrMP)
        Me.PanelRegBrMP.Controls.Add(Me.Label25)
        Me.PanelRegBrMP.Controls.Add(Me.btnZatvori)
        Me.PanelRegBrMP.Location = New System.Drawing.Point(85, 592)
        Me.PanelRegBrMP.Name = "PanelRegBrMP"
        Me.PanelRegBrMP.Size = New System.Drawing.Size(482, 356)
        Me.PanelRegBrMP.TabIndex = 1043
        Me.PanelRegBrMP.Visible = False
        '
        'DGVRegBrMP
        '
        Me.DGVRegBrMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRegBrMP.Location = New System.Drawing.Point(6, 29)
        Me.DGVRegBrMP.Name = "DGVRegBrMP"
        Me.DGVRegBrMP.RowHeadersWidth = 51
        Me.DGVRegBrMP.Size = New System.Drawing.Size(467, 287)
        Me.DGVRegBrMP.TabIndex = 10000067
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label25.Location = New System.Drawing.Point(2, 2)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(151, 19)
        Me.Label25.TabIndex = 10000066
        Me.Label25.Text = "Registracioni brojevi"
        '
        'btnZatvori
        '
        Me.btnZatvori.BackColor = System.Drawing.SystemColors.Control
        Me.btnZatvori.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZatvori.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZatvori.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZatvori.Location = New System.Drawing.Point(383, 325)
        Me.btnZatvori.Name = "btnZatvori"
        Me.btnZatvori.Size = New System.Drawing.Size(90, 24)
        Me.btnZatvori.TabIndex = 70
        Me.btnZatvori.Text = "Zatvori"
        Me.btnZatvori.UseVisualStyleBackColor = False
        '
        'lblUkupno
        '
        Me.lblUkupno.AutoSize = True
        Me.lblUkupno.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUkupno.Location = New System.Drawing.Point(13, 147)
        Me.lblUkupno.Name = "lblUkupno"
        Me.lblUkupno.Size = New System.Drawing.Size(0, 16)
        Me.lblUkupno.TabIndex = 1044
        Me.lblUkupno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPutniTroskovi
        '
        Me.btnPutniTroskovi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPutniTroskovi.BackColor = System.Drawing.SystemColors.Control
        Me.btnPutniTroskovi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPutniTroskovi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPutniTroskovi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPutniTroskovi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnPutniTroskovi.Location = New System.Drawing.Point(1159, 33)
        Me.btnPutniTroskovi.Name = "btnPutniTroskovi"
        Me.btnPutniTroskovi.Size = New System.Drawing.Size(227, 26)
        Me.btnPutniTroskovi.TabIndex = 1045
        Me.btnPutniTroskovi.TabStop = False
        Me.btnPutniTroskovi.Text = "Evidencija putnih troškova"
        Me.btnPutniTroskovi.UseVisualStyleBackColor = False
        '
        'panelPutniTroskovi
        '
        Me.panelPutniTroskovi.BackColor = System.Drawing.Color.LightYellow
        Me.panelPutniTroskovi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPutniTroskovi.Controls.Add(Me.btnZatvoriPT)
        Me.panelPutniTroskovi.Controls.Add(Me.btnJavPrev)
        Me.panelPutniTroskovi.Controls.Add(Me.lblPutniTroskovi)
        Me.panelPutniTroskovi.Controls.Add(Me.btnSopPrev)
        Me.panelPutniTroskovi.Location = New System.Drawing.Point(901, 147)
        Me.panelPutniTroskovi.Name = "panelPutniTroskovi"
        Me.panelPutniTroskovi.Size = New System.Drawing.Size(410, 308)
        Me.panelPutniTroskovi.TabIndex = 1046
        Me.panelPutniTroskovi.Visible = False
        '
        'btnZatvoriPT
        '
        Me.btnZatvoriPT.BackColor = System.Drawing.SystemColors.Control
        Me.btnZatvoriPT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZatvoriPT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZatvoriPT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZatvoriPT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZatvoriPT.Location = New System.Drawing.Point(313, 276)
        Me.btnZatvoriPT.Name = "btnZatvoriPT"
        Me.btnZatvoriPT.Size = New System.Drawing.Size(90, 24)
        Me.btnZatvoriPT.TabIndex = 10000068
        Me.btnZatvoriPT.Text = "Zatvori"
        Me.btnZatvoriPT.UseVisualStyleBackColor = False
        '
        'btnJavPrev
        '
        Me.btnJavPrev.BackColor = System.Drawing.SystemColors.Control
        Me.btnJavPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnJavPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnJavPrev.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJavPrev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnJavPrev.Location = New System.Drawing.Point(68, 168)
        Me.btnJavPrev.Name = "btnJavPrev"
        Me.btnJavPrev.Size = New System.Drawing.Size(278, 80)
        Me.btnJavPrev.TabIndex = 10000067
        Me.btnJavPrev.Text = "JAVNI PREVOZ"
        Me.btnJavPrev.UseVisualStyleBackColor = False
        '
        'lblPutniTroskovi
        '
        Me.lblPutniTroskovi.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPutniTroskovi.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPutniTroskovi.Location = New System.Drawing.Point(2, 2)
        Me.lblPutniTroskovi.Name = "lblPutniTroskovi"
        Me.lblPutniTroskovi.Size = New System.Drawing.Size(239, 19)
        Me.lblPutniTroskovi.TabIndex = 10000066
        Me.lblPutniTroskovi.Text = "ODABIR PREVOZNOG SREDSTVA"
        '
        'btnSopPrev
        '
        Me.btnSopPrev.BackColor = System.Drawing.SystemColors.Control
        Me.btnSopPrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSopPrev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSopPrev.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSopPrev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSopPrev.Location = New System.Drawing.Point(68, 59)
        Me.btnSopPrev.Name = "btnSopPrev"
        Me.btnSopPrev.Size = New System.Drawing.Size(278, 80)
        Me.btnSopPrev.TabIndex = 70
        Me.btnSopPrev.Text = "SOPSTVENO VOZILO"
        Me.btnSopPrev.UseVisualStyleBackColor = False
        '
        'FormPoljoprivreda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoScroll = False
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelZakazivanje)
        Me.Controls.Add(Me.panelZahtevZaDoradu)
        Me.Controls.Add(Me.panelNapomena)
        Me.Controls.Add(Me.panelPutniTroskovi)
        Me.Controls.Add(Me.btnPutniTroskovi)
        Me.Controls.Add(Me.lblUkupno)
        Me.Controls.Add(Me.PanelRegBrMP)
        Me.Controls.Add(Me.gbFilteri)
        Me.Controls.Add(Me.gbStatusi)
        Me.Controls.Add(Me.pbEU)
        Me.Controls.Add(Me.PanelLegendaDGV1)
        Me.Controls.Add(Me.btnRegBrMP)
        Me.Controls.Add(Me.ButtonLK)
        Me.Controls.Add(Me.ButtonIzvestaji)
        Me.Controls.Add(Me.ButtonIzlaz)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        
        Me.Name = "FormPoljoprivreda"
        Me.HP.SetShowHelp(Me, False)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adresar "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNapomena.ResumeLayout(False)
        Me.panelNapomena.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelZakazivanje.ResumeLayout(False)
        Me.PanelZakazivanje.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.PanelLegendaDGV1.ResumeLayout(False)
        Me.PanelLegendaDGV1.PerformLayout()
        CType(Me.pbEU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbStatusi.ResumeLayout(False)
        Me.gbStatusi.PerformLayout()
        Me.panelZahtevZaDoradu.ResumeLayout(False)
        Me.panelZahtevZaDoradu.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbFilteri.ResumeLayout(False)
        Me.gbFilteri.PerformLayout()
        Me.PanelRegBrMP.ResumeLayout(False)
        CType(Me.DGVRegBrMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelPutniTroskovi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim dist As DatasetIstrazivanja
    Dim mrist As DatasetIstrazivanja.ISTRow
    Dim mb As DatasetIstrazivanja.ISTBAZERow
    Dim ttab As DatasetIstrazivanja.ISTTABSDataTable
    Dim txtInst As String
    Dim txtmode As String
    Dim vrt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim pom As String
    Dim jezik As String
    Dim txtpismo As String
    Dim DBConnectionString As String
    Dim ISTConnectionString As String
    Dim CAPIServer As String
    Dim CAPIBaza As String
    Dim dtJson As DataTable
    Dim mdtAWL As DataTable
    Dim mdtQE As DataTable
    Dim mdtLabel As DataTable
    Dim mdtMessage As DataTable

    Dim txtoffice As String
    Dim folder As String

    Dim lokalno As Boolean

    Dim color1 As Color = System.Drawing.Color.Cornsilk
    Dim color2 As Color = System.Drawing.Color.Ivory
    Dim color3 As Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(167, Byte), Integer))
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1

    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    If m.Msg = WM_NCLBUTTONDBLCLK Then Return
    '    If m.Msg = WM_NCLBUTTONDOWN Then Return
    '    MyBase.WndProc(m)
    'End Sub
    'Private Sub ButtonIzvestaji_Click(sender As Object, e As EventArgs) Handles ButtonIzvestaji.Click

    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

    '    'If Panel3.Visible = True Then
    '    '    Call Cancel()
    '    'End If
    '    'If PanelNUl.Visible = True Then
    '    '    Call CancelNUL()
    '    'End If
    '    Call zatvoriIPonistiPanele()
    '    'Call MrefreshClick()
    '    Dim frm As New FormIzvestaji(Me.DBConnectionString, Me.ISTConnectionString, ttab, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.vrt, folder, mb,
    '                                 Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.CAPIServer, Me.CAPIBaza, txtmode,
    '                                 Me.jezik, Me.txtInst, Me.txtpismo, Me.txtoffice)
    '    Me.Hide()
    '    Try
    '        frm.ShowDialog()
    '    Catch ex As System.Exception
    '         ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        frm.Dispose()
    '        Me.Show()
    '        'If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Procedures and reports")
    '        Me.Cursor = System.Windows.Forms.Cursors.Default
    '    End Try
    'End Sub
    'Sub MrefreshClick()

    '    Dim app As String = Me.lblSifra.Text
    '    Dim d As Date = New Date(Me.vrt.G.ToString, Me.vrt.M, 2)
    '    Dim vtvt As String = d.ToString("yyyy-MM-dd")

    '    'puni DatasetIstrazivanja
    '    'puni DatasetIstrazivanja
    '    'puni DatasetIstrazivanja
    '    'puni DatasetIstrazivanja
    '    'puni DatasetIstrazivanja
    '    Me.dist.Clear()

    '    frdb(Me.dist)
    '    fbaz(Me.dist, vtvt)
    '    fist(Me.dist, app, vtvt)

    '    If Me.dist.IST.Rows.Count = 0 Then
    '        Exit Sub
    '    End If

    '    Dim appStaraApl As String = app : Dim appR As String = app : Dim tablesT As String = "" 'tabele, polja i LK moraju da budu iz iste app
    '    If Not Me.dist.IST.Rows(0).Item("Abaza") Is System.DBNull.Value Then
    '        Dim additionalParameters As String = Me.dist.IST.Rows(0).Item("Abaza").ToString.Trim.ToUpper
    '        Dim pp() As String = additionalParameters.Split(CType(";", Char()))
    '        For i As Integer = 0 To pp.GetUpperBound(0)
    '            Dim kk() As String = pp(i).Split(CType("=", Char()))
    '            If kk.Length >= 2 AndAlso kk(0) <> "" AndAlso kk(1) <> "" Then
    '                If kk(0) = "IST" Then appStaraApl = kk(1).Trim
    '                If kk(0) = "ISTTABS" OrElse kk(0) = "ISTREPORTSPROCEDURES" Then appR = kk(1)
    '                If kk(0) = "ISTTABLES" OrElse kk(0) = "ISTTABELE" Then
    '                    'ISTTABLES=A1=A,B1=B,C1=C
    '                    'A1=A,B1=B,C1=C
    '                    tablesT = pp(i).Trim.ToUpper.Replace("ISTTABLES=", "").Replace("ISTTABELE=", "")
    '                End If
    '            End If
    '        Next
    '    End If

    '    ftab(Me.dist, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)
    '    fpol(Me.dist, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)
    '    flk(Me.dist, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)
    '    fttabs(Me.dist, appR, appStaraApl, vtvt)
    '    fAWL(Me.dist, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)
    '    fQuestionExplanation(Me.dist, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)
    '    fLabel(Me.dist, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)
    '    fMessage(Me.dist, app, appStaraApl, vtvt)

    '    Dim redISt As DatasetIstrazivanja.ISTRow = Nothing
    '    For Each rowIST As DatasetIstrazivanja.ISTRow In dist.IST.Rows
    '        redISt = rowIST
    '    Next

    '    Me.Cursor = Cursors.WaitCursor

    '    Call newnew(ISTConnectionString, redISt, dist, Nothing,
    '                m_folderProgramaZaUnos, appRegKeyL, Nothing, txtpismo, txtoffice, Nothing, txtmode, DSBrisanjeDEPO,
    '                DSBrisanjeServer, DSBrisanjeBaza, m_folderZaGen, CATIServer, CATIBaza, CAPIServer, CAPIBaza, PublicDBServer, PublicDBBaza,
    '                Nothing, PXMETAApp, PXMETATable, "refresh")

    '    Me.Cursor = Cursors.Default
    '    'ISTMessageBox.Show("Metadata is refreshed!")
    'End Sub

    Dim kosam As String
    Public Sub New(ByVal dist As DatasetIstrazivanja, ByVal ttab As DatasetIstrazivanja.ISTTABSDataTable, ByVal ri As DatasetIstrazivanja.ISTRow,
                ByVal mdtLabelPrenos As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable, ByVal mdtmessagePrenos As DataTable,
                ByVal DBConnectionString As String,
                ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                ByVal txtInstalacije As String, ByVal txtpismo As String, ByVal txtmode As String, ByVal jezik As String,
                ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
                ByVal txt_DSBrisanjeBaza As String, ByVal ISTConnectionString As String,
                ByVal txt_CAPIServer As String, ByVal txt_CAPIBaza As String,
                ByVal txtoffice As String, ByVal folder As String, ByVal mmb As DatasetIstrazivanja.ISTBAZERow, ByVal kosam As String)

        Application.EnableVisualStyles()
        InitializeComponent()



        'lblOuter.FlatStyle = 0
        'lblOuter.BorderStyle = BorderStyle.FixedSingle
        'lblOuter.BackColor = Color.Transparent
        'lblOuter.Text = String.Empty
        Me.kosam = kosam
        'fiktivnianketar = kosam

        '*****************

        Me.DBConnectionString = DBConnectionString
        Me.ISTConnectionString = ISTConnectionString
        Me.mdtLabel = mdtLabelPrenos
        Me.mdtMessage = mdtmessagePrenos
        Me.jezik = jezik
        Me.txtpismo = txtpismo
        Me.vrt = vt
        Me.txtInst = txtInstalacije
        Me.txtmode = txtmode
        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        Me.CAPIServer = txt_CAPIServer
        Me.CAPIBaza = txt_CAPIBaza
        Me.dtJson = dtJson
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.dist = dist
        Me.txtoffice = txtoffice
        Me.folder = folder
        Me.mb = mmb
        Me.ttab = ttab
        Me.mrist = ri


        filtNaseljeee.Text = ""
        filtNaseljeee.Name = "filtNaseljeee"
        filtNaseljeee.Visible = False
        AddHandler filtNaseljeee.TextChanged, AddressOf filterTextBoxDGV1_Changed


        filtPig.Text = ""
        filtPig.Name = "filtPig"
        filtPig.Visible = False
        AddHandler filtPig.TextChanged, AddressOf filterTextBoxDGV1_Changed

        filtRPG.Text = ""
        filtRPG.Name = "filtRPG"
        filtRPG.Visible = False
        AddHandler filtRPG.TextChanged, AddressOf filterTextBoxDGV1_Changed


        filtDatumZakazan.Name = "filtDatumZakazan"
        filtDatumZakazan.DropDownWidth = 150
        filtDatumZakazan.Visible = False
        Call popunicbo(filtDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from Adresar where anketar=N'" + kosam + "' and isnull(ZakazanoDatum,'')<>'' order by ZakazanoDatum", Me.DBConnectionString, False, False, True, True)
        filtDatumZakazan.TabStop = False
        AddHandler filtDatumZakazan.SelectedIndexChanged, AddressOf comboboxdatum_Changed
        filtDatumZakazan.Text = "*"
        'AddHandler filterStatus.DrawItem, AddressOf ComboBox1_DrawItem


        Dim filterStatus As String = ""
        If rbZavrsenoP.Checked = True Then
            filterStatus = "ZAVRSENOP"
        ElseIf rbZavrsenoNP.Checked = True Then
            filterStatus = "ZAVRSENONP"
        ElseIf rbZapoceto.Checked = True Then
            filterStatus = "ZAPOCETO"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If

        Call SetLang()
        refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

        Call srediGridView222()

    End Sub

    Private Sub comboboxdatum_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DirectCast(sender, ComboBox).Text <> "" Then
            If DGV1.Visible = True Then

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                If DGV1.Rows.Count > 0 Then
                    DGV1.Focus()
                    DGV1.ClearSelection()
                    DGV1.Rows(0).Selected = True
                End If
            End If
        End If

    End Sub
    Sub srediGridView222()

        Dim gridCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
       .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
       .BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer)),
       .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
       .ForeColor = System.Drawing.SystemColors.ControlLightLight,
       .SelectionBackColor = System.Drawing.SystemColors.Highlight,
       .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
       .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}
        Dim gridCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.SystemColors.ControlLightLight,
        .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.ControlText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[False]}
        Dim gridCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.Color.Lavender,
        .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.WindowText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}


        'DGV1.Columns("praznoA").Frozen = True

        DGV1.AllowUserToAddRows = False
        DGV1.AllowUserToDeleteRows = False
        DGV1.BackgroundColor = System.Drawing.SystemColors.Window
        DGV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DGV1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        'grid.ColumnHeadersDefaultCellStyle = gridCellStyle4

        DGV1.ColumnHeadersDefaultCellStyle.BackColor = color2
        DGV1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DGV1.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DGV1.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DGV1.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DGV1.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DGV1.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]

        DGV1.ColumnHeadersHeight = 40
        DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGV1.DefaultCellStyle = gridCellStyle2
        DGV1.EnableHeadersVisualStyles = False
        DGV1.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        DGV1.ReadOnly = True
        DGV1.RowHeadersVisible = True
        DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DGV1.RowHeadersDefaultCellStyle = gridCellStyle3
        'DGV1.Font = gridCellStyle.Font

        DGV1.RowTemplate.Height = 30

        Me.DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV1.ColumnHeadersHeight = Me.DGV1.ColumnHeadersHeight * 2
        Me.DGV1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        'Call applyGridTheme4(DGV1, color2, Color.Black)


    End Sub

    Sub srediGridView333()

        Dim gridCellStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
       .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
       .BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer)),
       .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
       .ForeColor = System.Drawing.SystemColors.ControlLightLight,
       .SelectionBackColor = System.Drawing.SystemColors.Highlight,
       .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
       .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}
        Dim gridCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.SystemColors.ControlLightLight,
        .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.ControlText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[False]}
        Dim gridCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle With {
        .Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
        .BackColor = System.Drawing.Color.Lavender,
        .Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)),
        .ForeColor = System.Drawing.SystemColors.WindowText,
        .SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(89, Byte), Integer)),
        .SelectionForeColor = System.Drawing.SystemColors.HighlightText,
        .WrapMode = System.Windows.Forms.DataGridViewTriState.[True]}

        DGVRegBrMP.AllowUserToAddRows = False
        DGVRegBrMP.AllowUserToDeleteRows = False
        DGVRegBrMP.BackgroundColor = System.Drawing.SystemColors.Window
        DGVRegBrMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        DGVRegBrMP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        'grid.ColumnHeadersDefaultCellStyle = gridCellStyle4

        DGVRegBrMP.ColumnHeadersDefaultCellStyle.BackColor = color2
        DGVRegBrMP.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        DGVRegBrMP.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DGVRegBrMP.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DGVRegBrMP.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DGVRegBrMP.ColumnHeadersDefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DGVRegBrMP.ColumnHeadersDefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]

        DGVRegBrMP.ColumnHeadersHeight = 40
        DGVRegBrMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DGVRegBrMP.DefaultCellStyle = gridCellStyle2
        DGVRegBrMP.EnableHeadersVisualStyles = False
        DGVRegBrMP.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        DGVRegBrMP.ReadOnly = True
        DGVRegBrMP.RowHeadersVisible = True
        DGVRegBrMP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DGVRegBrMP.RowHeadersDefaultCellStyle = gridCellStyle3
        'DGVRegBrMP.Font = gridCellStyle.Font

        DGVRegBrMP.RowTemplate.Height = 30

        Me.DGVRegBrMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGVRegBrMP.ColumnHeadersHeight = Me.DGVRegBrMP.ColumnHeadersHeight * 2
        Me.DGVRegBrMP.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGVRegBrMP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        'Call applyGridTheme4(DGV1, color2, Color.Black)


    End Sub

    Private Sub filterTextBoxDGV1_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DGV1.Visible = True Then
            Dim filterStatus As String = ""
            If rbZavrsenoP.Checked = True Then
                filterStatus = "ZAVRSENOP"
            ElseIf rbZavrsenoNP.Checked = True Then
                filterStatus = "ZAVRSENONP"
            ElseIf rbZapoceto.Checked = True Then
                filterStatus = "ZAPOCETO"
            ElseIf rbVraceno.Checked = True Then
                filterStatus = "VRACENO"
            ElseIf rbSve.Checked = True Then
                filterStatus = "SVE"
            End If
            refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)
        End If
        DirectCast(sender, TextBox).Focus()

    End Sub

    Private Sub FormDnevnikAnketiranja_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call PreVentFlicker()
        'Me.WindowState = FormWindowState.Maximized

        'TabControl1.Location = New Point(Me.ButtonUnosNovogKBR.Location.X, Me.ButtonUnosNovogKBR.Location.Y + ButtonUnosNovogKBR.Height + 10)
        TabControl1.Width = Me.Width - 30  'Me.Width - 30
        TabControl1.Height = (Screen.PrimaryScreen.WorkingArea.Height - 280)

        EnableDoubleBuffered(DGV1)


        srediGridView222()
        Me.PanelZakazivanje.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - PanelZakazivanje.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - PanelZakazivanje.Height / 2)
        Me.panelNapomena.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panelNapomena.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panelNapomena.Height / 2)
        Me.panelZahtevZaDoradu.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panelZahtevZaDoradu.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panelZahtevZaDoradu.Height / 2)
        PanelRegBrMP.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - PanelRegBrMP.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - PanelRegBrMP.Height / 2)
        Me.panelPutniTroskovi.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panelPutniTroskovi.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panelPutniTroskovi.Height / 2)
        btnLegenda.Location = New Point(PanelLegendaDGV1.Location.X + PanelLegendaDGV1.Width - btnLegenda.Width, PanelLegendaDGV1.Location.Y)



        ButtonIzlaz.Location = New Point(Me.Width - 25 - ButtonIzlaz.Width, ButtonIzlaz.Location.Y)
        'ButtonIzvestaji.Location = New Point(Me.Width - 25 - ButtonIzlaz.Width, ButtonIzvestaji.Location.Y)
        btnPutniTroskovi.Location = New Point(Me.Width - 25 - ButtonIzvestaji.Width, btnPutniTroskovi.Location.Y)
        btnRegBrMP.Location = New Point(Me.Width - 25 - ButtonIzlaz.Width, btnRegBrMP.Location.Y)
        pbEU.Location = New Point(Me.Width - ButtonIzlaz.Width - 30 - pbEU.Width, ButtonIzlaz.Location.Y)
        SetCueText(filtNaseljeee, "🔎 ")
        SetCueText(filtPig, "🔎 ")
        SetCueText(filtRPG, "🔎 ")

        TabControl1locX = TabControl1.Location.X
        TabControl1locY = TabControl1.Location.Y
        TabControl1Height = TabControl1.Height
        gbStatusi.Location = New Point(gbStatusi.Location.X, PanelLegendaDGV1.Location.Y + PanelLegendaDGV1.Height + 70)
        gbStatusi.Width = rbZavrsenoNP.Width + rbZapoceto.Width + rbVraceno.Width + rbSve.Width + 160
        gbFilteri.Location = New Point(gbStatusi.Location.X + gbStatusi.Width + 65, gbStatusi.Location.Y)

        rbZavrsenoNP.Location = New Point(rbZavrsenoP.Location.X + rbZavrsenoP.Width + 5, rbZavrsenoP.Location.Y)
        rbZapoceto.Location = New Point(rbZavrsenoNP.Location.X + rbZavrsenoNP.Width + 5, rbZavrsenoNP.Location.Y)
        rbVraceno.Location = New Point(rbZapoceto.Location.X + rbZapoceto.Width + 5, rbZapoceto.Location.Y)
        rbSve.Location = New Point(rbVraceno.Location.X + rbVraceno.Width + 5, rbVraceno.Location.Y)

        'lblPIG
        'lblPIG.Location = New Point(gbFilteri.Location.X + 10, gbFilteri.Location.Y + 5)
        'lblPIG.Location = New Point(rbSve.Location.X + 1000, rbSve.Location.Y + 1000)
        filtPig.Width = 90
        filtRPG.Width = 105
        filtNaseljeee.Width = 100
        filtDatumZakazan.Width = 100
        gbFilteri.Width = lblPIGF.Width + filtPig.Width + lblRPG.Width + filtRPG.Width + lblNaselje.Width + filtNaseljeee.Width + lblDatZak.Width + filtDatumZakazan.Width + llPonisti.Width + 70
        filtPig.Location = New Point(lblPIGF.Location.X + lblPIG.Width + 2, filtPig.Location.Y)
        lblRPG.Location = New Point(filtPig.Location.X + filtPig.Width + 2, lblPIGF.Location.Y)
        filtRPG.Location = New Point(lblRPG.Location.X + lblRPG.Width + 2, filtPig.Location.Y)
        lblNaselje.Location = New Point(filtRPG.Location.X + filtRPG.Width + 2, lblPIGF.Location.Y)
        filtNaseljeee.Location = New Point(lblNaselje.Location.X + lblNaselje.Width + 2, filtPig.Location.Y)
        lblDatZak.Location = New Point(filtNaseljeee.Location.X + filtNaseljeee.Width + 2, lblPIGF.Location.Y)
        filtDatumZakazan.Location = New Point(lblDatZak.Location.X + lblDatZak.Width + 2, filtPig.Location.Y)
        llPonisti.Location = New Point(filtDatumZakazan.Location.X + filtDatumZakazan.Width + 10, filtRPG.Location.Y - 6)

        If Not filtNaseljeee Is Nothing AndAlso Not DGV1 Is Nothing Then
            'filtNaseljeee.Width = DGV1.Columns("Nazivnaselja").Width
            'filtNaseljeee.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width + DGV1.Columns("PIG").Width + DGV1.Columns("rbr").Width + DGV1.Columns("ImePrezime").Width, DGV1.ColumnHeadersHeight - filtNaseljeee.Height - 1)
            filtNaseljeee.Visible = True

        End If

        If Not filtPig Is Nothing AndAlso Not DGV1 Is Nothing Then

            filtPig.BringToFront()
            'filtPig.Width = DGV1.Columns("PIG").Width
            'filtPig.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width, DGV1.ColumnHeadersHeight - filtPig.Height - 1)
            'filtPig.AccessibleName = filtPig.Location.X
            filtPig.Visible = True
        End If

        If Not filtRPG Is Nothing AndAlso Not DGV1 Is Nothing Then

            filtRPG.BringToFront()
            'filtPig.Width = DGV1.Columns("PIG").Width
            'filtPig.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width, DGV1.ColumnHeadersHeight - filtPig.Height - 1)
            'filtPig.AccessibleName = filtPig.Location.X
            filtRPG.Visible = True
        End If


        If Not filtDatumZakazan Is Nothing AndAlso Not DGV1 Is Nothing Then
            'filtDatumZakazan.Width = DGV1.Columns("ZakazanoDatum").Width
            'filtDatumZakazan.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width + DGV1.Columns("PIG").Width + DGV1.Columns("rbr").Width + DGV1.Columns("ImePrezime").Width _
            '+ DGV1.Columns("Nazivnaselja").Width + DGV1.Columns("Ulica").Width + DGV1.Columns("Kbr").Width + DGV1.Columns("Tel").Width + DGV1.Columns("Prazno0").Width _
            '+ DGV1.Columns("Zakazivanje").Width + DGV1.Columns("Ishod").Width + DGV1.Columns("Prazno0").Width + DGV1.Columns("PoglOpstiPodaci").Width + DGV1.Columns("PoglZemljiste").Width _
            '+ DGV1.Columns("PoglVocnjaciVinogradi").Width + DGV1.Columns("PoglStoka").Width + DGV1.Columns("PoglRadnaSnaga").Width + DGV1.Columns("PoglNavodnjavanje").Width + DGV1.Columns("PoglDjubrivo").Width _
            '+ DGV1.Columns("PoglNacinDrzanjaStoke").Width + DGV1.Columns("PoglMehanizacija").Width + DGV1.Columns("PoglObrada").Width + DGV1.Columns("PoglOstaliPodaci").Width + DGV1.Columns("PraznoB").Width _
            '+ DGV1.Columns("UzorakVV").Width + DGV1.Columns("praznoC").Width, DGV1.ColumnHeadersHeight - filtNaseljeee.Height - 1)
            filtDatumZakazan.Visible = True
        End If



    End Sub

    Sub pZahVisible()
        Me.panelZahtevZaDoradu.BringToFront()

        Me.panelZahtevZaDoradu.Visible = True
        Call samoja(panelZahtevZaDoradu)

        cbZahtevZaDoradu.Focus()
    End Sub
    Sub pZahNonVisible()

        Call nesamoja(panelZahtevZaDoradu)
        Me.panelZahtevZaDoradu.Visible = False

        tboxZahtevRazlog.Text = ""
        cbZahtevZaDoradu.Checked = False
    End Sub

    Sub panelPutniTroskoviVisible()
        Me.panelPutniTroskovi.BringToFront()
        Me.panelPutniTroskovi.Visible = True
        Call samoja(panelPutniTroskovi)
    End Sub

    Sub panelPutniTroskoviNonVisible()
        Call nesamoja(panelPutniTroskovi)
        Me.panelPutniTroskovi.Visible = False

    End Sub



    Private Sub ButtonZahtev_Click(sender As Object, e As EventArgs) Handles btnZahtevOK.Click

        If cbZahtevZaDoradu.Checked = False Then
            ISTMessageBox.Show("Morate čekirati da želite da zatražite zahtev za doradu!")
            cbZahtevZaDoradu.Focus()
            Exit Sub
        End If

        Dim vredPIG As String = tboxZahtevPig.Text.Trim
        Dim vredRBR As String = tboxZahtevRbr.Text.Trim
        'Dim vredStatus As String = zapamceniStatusanketar
        'If cbZahtevZaDoradu.Checked = True Then vredStatus = "3" Else vredStatus = "2" 'zapamceniStatusanketar

        If cbZahtevZaDoradu.Checked = True AndAlso tboxZahtevRazlog.Text.Trim = "" Then
            ISTMessageBox.Show("Razlog ne sme biti prazan!")
            tboxNapomenaStatusAnketar.Focus()
            Exit Sub
        End If
        Dim strSQL As String = ""
        Dim strproverastatusa As String = "select isnull(statusanketar,0) from adresar " + nvrd +
                                        " where anketar=N'" + kosam + "' and PIG='" + Me.tboxZahtevPig.Text + "' and RBR='" + Me.tboxZahtevRbr.Text + "'" + nvrd

        Dim dtproverastatusa As DataTable = izvrsiSQLvratiDT(strproverastatusa, Me.DBConnectionString, Me.jezik)
        If dtproverastatusa.Rows.Count > 0 AndAlso cbZahtevZaDoradu.Checked Then
            ' If dtproverastatusa.Rows(0).Item(0).ToString.Trim = "3" Then
            strSQL = " update adresar " + vbCrLf +
                               " set statusanketar=3, date_update=getdate(), user_update=N'" + kosam + "'," + vbCrLf +
                               " USER_statusAnketar='" + kosam + "', " + vbCrLf +
                               " napomenaStatusAnketar=N'" + tboxZahtevRazlog.Text + "' " + vbCrLf +
                               " where anketar=N'" + kosam + "' and PIG='" + Me.tboxZahtevPig.Text + "' and RBR='" + Me.tboxZahtevRbr.Text + "'"

            'Else
            '    strSQL = " update adresar " + vbCrLf +
            '                   " set statusanketar=" + vred2.Trim + ", date_update=getdate(), user_update=N'" + kosam + "'," + vbCrLf +
            '                   " DATE_statusAnketar='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', USER_statusAnketar='" + kosam + "', " + vbCrLf +
            '                   " napomenaStatusAnketar=N'" + tboxNapomenaStatusAnketar.Text + "' " + vbCrLf +
            '                   " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCDZahtev.Text + "' and rbrstan='" + Me.txtRbrStanZahtev.Text + "'" + nvrd +
            '                   " and krug_idcd='" + atbPK.sselectedValue.Trim + "' and mbops='" + atbOps.sselectedValue.Trim + "'"
            'End If
        End If

        Dim ok As String = izvrsiSQL(strSQL, Me.DBConnectionString)
        If ok <> "ok" Then
            ISTMessageBox.Show("Greska 1! Zovite administratora!")
            Me.Close()
            Exit Sub
        End If

        Dim pomrowDGV1 As Integer = panelZahtevZaDoradu.Tag
        'Call refreshDGV1()
        'If DGV1.Rows.Count > 0 Then
        '    DGV1.ClearSelection()
        '    DGV1.Rows(pomrowDGV1).Selected = True
        'End If

        Dim filterStatus As String = ""
        If rbZavrsenoP.Checked = True Then
            filterStatus = "ZAVRSENOP"
        ElseIf rbZavrsenoNP.Checked = True Then
            filterStatus = "ZAVRSENONP"
        ElseIf rbZapoceto.Checked = True Then
            filterStatus = "ZAPOCETO"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If

        refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)
        If DGV1.Rows.Count > 0 Then
            DGV1.ClearSelection()
            'DGV2.Rows(PanelZakazivanjeStana.Tag).Selected = True
            If DGV1.Rows.Count - 1 >= pomrowDGV1 Then
                DGV1.Rows(pomrowDGV1).Selected = True
            Else
                DGV1.Rows(0).Selected = True
            End If
        End If

        panelZahtevZaDoradu.Tag = 0
        Call pZahNonVisible()
    End Sub

    Private Sub btnZahtevCancel_Click(sender As Object, e As EventArgs) Handles btnZahtevCancel.Click
        Call pZahNonVisible()
        panelZahtevZaDoradu.Tag = 0
        DGV1.Focus()
    End Sub

    Private Sub samoja(ByVal cntl As Control)
        cntl.AccessibleDefaultActionDescription = "samoja"
        For Each c As Control In Me.Controls
            If c.AccessibleDefaultActionDescription = "" Then
                c.Enabled = False
            End If
            If c.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela" Then
                If c.Enabled = False Then c.AccessibleRole = 0
                If c.Enabled = True Then c.AccessibleRole = 1
                c.Enabled = False
            End If
        Next
    End Sub
    Private Sub nesamoja(ByVal cntl As Control)
        cntl.AccessibleDefaultActionDescription = ""
        For Each c As Control In Me.Controls
            If c.AccessibleDefaultActionDescription = "" Then
                c.Enabled = True
            End If
            If c.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela" Then
                If c.AccessibleRole = 0 Then c.Enabled = False : c.AccessibleRole = -1
                If c.AccessibleRole = 1 Then c.Enabled = True : c.AccessibleRole = -1
                c.Enabled = False
            End If
        Next
    End Sub

    Sub pZakazivanjeStanaVisible()
        txtPIG.Text = ""
        txtRBR.Text = ""
        dtpDatumDolaska.Text = ""
        rb1.Checked = False
        rb2.Checked = False
        rb4.Checked = False
        rb6.Checked = False
        rb7.Checked = False
        dtpZakazanoDatum.Text = ""
        dtpZakazanoVreme.Text = ""
        txtKontaktOsoba.Text = ""
        txtBrojTelefona.Text = ""
        txtIshodNapomena.Text = ""
        Me.PanelZakazivanje.BringToFront()
        Me.PanelZakazivanje.Visible = True
        Call samoja(PanelZakazivanje)
        dtpDatumDolaska.Focus()
    End Sub

    Sub pZakazivanjeStanaNonVisible()

        Call nesamoja(PanelZakazivanje)
        Me.PanelZakazivanje.Visible = False

        txtPIG.Text = ""
        txtRBR.Text = ""
        'ishodi  'cb1-cb7
        rb1.Checked = False
        rb2.Checked = False
        rb4.Checked = False
        rb6.Checked = False
        rb7.Checked = False
        p2.Visible = False
        dtpZakazanoDatum.Text = ""
        dtpZakazanoVreme.Text = ""
        txtKontaktOsoba.Text = ""
        txtBrojTelefona.Text = ""
        txtIshodNapomena.Text = ""
    End Sub



    Sub Promena2(ByVal selectedRow As Integer)
        DGV1.ClearSelection()
        DGV1.Rows(selectedRow).Selected = True

        Call pZakazivanjeStanaNonVisible()

        cbPonistiZak.Visible = False
        cbPonistiZak.Checked = False
        Dim si As Integer = DGV1.SelectedRows(0).Index
        Call pZakazivanjeStanaVisible()
        PanelZakazivanje.Tag = selectedRow
        p1.Enabled = False

        txtAdresa.Text = DGV1.Rows(si).Cells(DGV1.Columns("ulica").Index).Value.ToString + " " + DGV1.Rows(si).Cells(DGV1.Columns("kbr").Index).Value.ToString
        txtPIG.Text = DGV1.Rows(si).Cells(DGV1.Columns("pig").Index).Value.ToString
        txtRBR.Text = DGV1.Rows(si).Cells(DGV1.Columns("rbr").Index).Value.ToString
        dtpDatumDolaska.Text = DGV1.Rows(si).Cells(DGV1.Columns("DatumDolaska").Index).Value.ToString
        txtIshodNapomena.Text = DGV1.Rows(si).Cells(DGV1.Columns("IshodNapomena").Index).Value.ToString
        txtKontaktOsoba.Text = DGV1.Rows(si).Cells(DGV1.Columns("KontaktOsoba").Index).Value.ToString
        txtBrojTelefona.Text = DGV1.Rows(si).Cells(DGV1.Columns("BrojTelefona").Index).Value.ToString


        If dtpDatumDolaska.Text.Trim = "" Then dtpDatumDolaska.Text = Date.Now.ToString("dd.MM.yyyy")


        'ishodi  'cb1-cb7
        Dim ishod As String = DGV1.Rows(si).Cells(DGV1.Columns("ishod").Index).Value.ToString
        Dim iishod As Integer = 0
        If IsNumeric(ishod) = True Then iishod = CInt(ishod)

        rb1.Checked = False
        rb2.Checked = False
        rb4.Checked = False
        rb6.Checked = False
        rb7.Checked = False

        If iishod = 1 Then rb1.Checked = True
        If iishod = 2 Then rb2.Checked = True
        If iishod = 3 Then rb4.Checked = True
        If iishod = 4 Then rb6.Checked = True
        If iishod = 5 Then rb7.Checked = True

        p2.Enabled = True

        dtpZakazanoDatum.Text = ""
        If Not DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoDatum").Index).Value Is System.DBNull.Value AndAlso
                            DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoDatum").Index).Value.ToString <> "" Then
            dtpZakazanoDatum.Text = DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoDatum").Index).Value.ToString
        End If

        dtpZakazanoVreme.Text = ""
        If Not DGV1.Rows(si).Cells(DGV1.Columns("Zakazanovreme").Index).Value Is System.DBNull.Value AndAlso
                            DGV1.Rows(si).Cells(DGV1.Columns("Zakazanovreme").Index).Value.ToString <> "" Then
            dtpZakazanoVreme.Text = DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoVreme").Index).Value.ToString
        End If



        Dim cati_nacin As String = DGV1.Rows(si).Cells(DGV1.Columns("cati_nacin").Index).Value.ToString
        Dim icati_nacin As String = ""
        If IsNumeric(cati_nacin) = True Then icati_nacin = cati_nacin.Trim

        dtpZakazanoDatum.Text = dtpZakazanoDatum.Text.Trim

        dtpDatumDolaska.Text = dtpDatumDolaska.Text.Trim

        txtBrojTelefona.Text = txtBrojTelefona.Text.Trim

        dtpZakazanoVreme.Text = dtpZakazanoVreme.Text.Trim

        If rb1.Checked = True OrElse rb2.Checked = True OrElse rb4.Checked = True OrElse rb6.Checked = True OrElse rb7.Checked = True Then
            cbPonistiZak.Visible = True
        Else
            cbPonistiZak.Visible = False
        End If

    End Sub

    Private Sub Rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then

            Dim str As String = "select * from OpstiPodaci s inner join Adresar a on a.pig=s.pig and a.rbr=s.rbr " + nvrd +
                                " where a.anketar=N'" + kosam + "' and s.pig='" + txtPIG.Text.Trim + "' and s.rbr='" + txtRBR.Text.Trim + "' " + nvrd
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Započeli ste popisivanje ovog gazdinstva. Dozvoljen ishod je 3 ili 4.")
                rb1.Checked = False
                Exit Sub
            End If

            p2.Visible = False
            dtpZakazanoDatum.Text = ""
            dtpZakazanoVreme.Text = ""
            txtKontaktOsoba.Text = ""
            txtBrojTelefona.Text = ""
            txtIshodNapomena.Focus()
            txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
            txtIshodNapomena.SelectionLength = 0
            'Me.cbTelefon.Enabled = True
            'Me.cbDolazak.Enabled = True
            'Me.cbTelefon.Checked = False
            'Me.cbDolazak.Checked = False
            'p2.Visible = True
            'dtpZakazanoDatum.Focus()
        End If
    End Sub
    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        If rb2.Checked = True Then
            Dim str As String = "select * from OpstiPodaci s  inner join Adresar a on a.pig=s.pig and a.rbr=s.rbr " + nvrd +
                                " where a.anketar=N'" + kosam + "' and s.pig='" + txtPIG.Text.Trim + "' and s.rbr='" + txtRBR.Text.Trim + "' " + nvrd
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Započeli ste popisivanje ovog gazdinstva. Dozvoljen ishod je 3 ili 4.")
                rb2.Checked = False
                Exit Sub
            End If
            p2.Visible = True
            dtpZakazanoDatum.Focus()
        End If
    End Sub


    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked = True Then
            p2.Visible = True
            Me.dtpZakazanoDatum.Focus()
        End If
    End Sub

    Private Sub rb6_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged

        If rb6.Checked = True Then
            p2.Visible = False
            dtpZakazanoDatum.Text = ""
            dtpZakazanoVreme.Text = ""
            txtKontaktOsoba.Text = ""
            txtBrojTelefona.Text = ""
            txtIshodNapomena.Focus()
            txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
            txtIshodNapomena.SelectionLength = 0
        End If
    End Sub
    Private Sub rb7_CheckedChanged(sender As Object, e As EventArgs) Handles rb7.CheckedChanged

        If rb7.Checked = True Then
            Dim str As String = "select * from OpstiPodaci s  inner join Adresar a on a.pig=s.pig and a.rbr=s.rbr " + nvrd +
                                " where a.anketar=N'" + kosam + "' and s.pig='" + txtPIG.Text.Trim + "' and s.rbr='" + txtRBR.Text.Trim + "' " + nvrd
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Započeli ste popisivanje ovog gazdinstva. Dozvoljen ishod je 3 ili 4.")
                rb7.Checked = False
                Exit Sub
            End If
            p2.Visible = False
            dtpZakazanoDatum.Text = ""
            dtpZakazanoVreme.Text = ""
            txtKontaktOsoba.Text = ""
            txtBrojTelefona.Text = ""
            txtIshodNapomena.Focus()
            txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
            txtIshodNapomena.SelectionLength = 0
        End If
    End Sub

    Sub Dgv1CellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)

        Me.Cursor = Cursors.WaitCursor

        If erowindex >= 0 Then
            DGV1.ClearSelection()
            DGV1.Rows(erowindex).Selected = True

            If DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("Zakazivanje").DisplayIndex Then
                Call Promena2(erowindex)
                Me.Cursor = Cursors.Default

                Exit Sub
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("Napomena").DisplayIndex Then

                DGV1.ClearSelection()
                DGV1.Rows(erowindex).Selected = True
                Call Promena(erowindex)
                Me.Cursor = Cursors.Default

                Exit Sub
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("ZahtevDorada").DisplayIndex Then
                Call ZahtevZaDoradu(erowindex)
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("Tel").DisplayIndex AndAlso DGV1.Columns("TEL").Width = 100 AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("Tel").Index).Value.ToString.Trim.Length > 10 Then
                DGV1.Columns("TEL").Width = 300
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("Tel").DisplayIndex AndAlso DGV1.Columns("TEL").Width <> 100 Then
                DGV1.Columns("TEL").Width = 100
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PodeliPIG").DisplayIndex Then

                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim tabela As String = "Adresar"
                Dim zakljucanOdmahSve As Boolean = False
                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True : zakljucanOdmahSve = True

                Dim KljuceviSaEkranaSaVrednostima(,) As String
                ReDim KljuceviSaEkranaSaVrednostima(1, 1)
                KljuceviSaEkranaSaVrednostima(0, 0) = "PIG".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(0, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("PIG").Index).Value.ToString

                Dim strsql As String = "select max(cast(rbr as int))+1 from Adresar where anketar=N'" + kosam + "' and pig='" + DGV1.Rows(erowindex).Cells(DGV1.Columns("PIG").Index).Value.ToString + "'"
                Dim dt As DataTable = izvrsiSQLvratiDT(strsql, DBConnectionString, Me.jezik)
                If dt.Rows.Count > 0 Then
                    KljuceviSaEkranaSaVrednostima(1, 0) = "RBR".Trim.ToUpper
                    KljuceviSaEkranaSaVrednostima(1, 1) = dt.Rows(0).Item(0).ToString
                    Dim pamtipig As String = DGV1.Rows(erowindex).Cells(DGV1.Columns("PIG").Index).Value.ToString
                    Dim pamtirbr As String = DGV1.Rows(erowindex).Cells(DGV1.Columns("RBR").Index).Value.ToString

                    Dim dosaoIzCapiAdresara As Boolean = True
                    'filtDatumZakazan.Items.Clear()

                    Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                       True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                       Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

                    Try
                        frm.ShowDialog()
                    Catch ex As Exception
                        ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Finally
                        frm.Dispose()
                    End Try

                    Dim filterStatus As String = ""
                    If rbZavrsenoP.Checked = True Then
                        filterStatus = "ZAVRSENOP"
                    ElseIf rbZavrsenoNP.Checked = True Then
                        filterStatus = "ZAVRSENONP"
                    ElseIf rbZapoceto.Checked = True Then
                        filterStatus = "ZAPOCETO"
                    ElseIf rbVraceno.Checked = True Then
                        filterStatus = "VRACENO"
                    ElseIf rbSve.Checked = True Then
                        filterStatus = "SVE"
                    End If

                    refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                    Dim selektujpocetni As Integer = 0
                    For i As Integer = 0 To DGV1.Rows.Count - 1
                        If DGV1.Rows(i).Cells("PIG").Value.ToString = pamtipig AndAlso DGV1.Rows(i).Cells("RBR").Value.ToString = pamtirbr Then
                            selektujpocetni = i
                            Exit For
                        End If
                    Next
                    DGV1.ClearSelection()
                    DGV1.Rows(selektujpocetni).Selected = True
                Else
                    ISTMessageBox.Show("Dogodila se greka. Pokušajte ponovo.")
                    Me.Cursor = Cursors.Default

                    Exit Sub
                End If

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglOpstiPodaci").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglOpstiPodaci").Index).Value.ToString <> "x" Then

                Dim odziv8 As String = DGV1.Rows(erowindex).Cells(DGV1.Columns("Odziv").Index).Value.ToString.Trim
                If odziv8 = "8" Then
                    ISTMessageBox.Show("Podaci za ovaj PIG su popunjeni zbirno u upitniku za drugi PIG! Ne možete otvoriti upitnik!")
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim tabela As String = "OpstiPodaci"
                Dim zakljucanOdmahSve As Boolean = False
                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True : zakljucanOdmahSve = True

                Dim KljuceviSaEkranaSaVrednostima(,) As String
                ReDim KljuceviSaEkranaSaVrednostima(1, 1)
                KljuceviSaEkranaSaVrednostima(0, 0) = "PIG".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(0, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("PIG").Index).Value.ToString
                KljuceviSaEkranaSaVrednostima(1, 0) = "RBR".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(1, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("RBR").Index).Value.ToString


                Dim dosaoIzCapiAdresara As Boolean = True
                'filtDatumZakazan.Items.Clear()

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

                Try
                    frm.ShowDialog()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglZemljiste").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglZemljiste").Index).Value.ToString <> "x" Then


                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "pogl_02"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True



                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next


                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 2! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If


                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglVocnjaciVinogradi").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglVocnjaciVinogradi").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = ""
                If DGV1.Rows(erowindex).Cells(DGV1.Columns("uzorakVV").Index).Value.ToString.Trim.ToUpper = "DA" Then
                    podtabela = "Pogl_03"
                Else
                    podtabela = "vPogl_03"
                End If
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 6! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF
                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglStoka").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglStoka").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Pogl_04"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 7! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglRadnaSnaga").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglRadnaSnaga").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Pogl_05"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 8! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglNavodnjavanje").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglNavodnjavanje").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Modul1"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 9! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglDjubrivo").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglDjubrivo").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Modul2"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 10! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglNacinDrzanjaStoke").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglNacinDrzanjaStoke").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Modul3"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 11! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglMehanizacija").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglMehanizacija").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Modul4"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 12! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglObrada").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglObrada").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Modul5"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 13! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglOstaliPodaci").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglOstaliPodaci").Index).Value.ToString.Trim <> "/" Then
                Dim tabela As String = "OpstiPodaci"
                Dim podtabela As String = "Modul6"
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim zakljucanOdmahSve As Boolean = False
                Dim dosaoIzCapiAdresara As Boolean = True

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV1.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

                If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim strsql As String = "update opstipodaci set QC=0 where PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;" + nvrd +
                                                    "update adresar set statusanketar=0, Date_statusAnketar=getdate()," + nvrd +
                                                    " date_update = getdate(), user_update=N'" + kosam + "'," + nvrd +
                                                    " USER_statusAnketar=N'" + kosam + "' " + nvrd +
                                                    " where anketar=N'" + kosam + "' and PIG='" + KljuceviPodtabelaSavrednostima(1, 1) + "' and RBR='" + KljuceviPodtabelaSavrednostima(2, 1) + "' ;"
                            Dim ok As String = izvrsiSQL(strsql, Me.DBConnectionString)
                            If ok = "ok" Then
                            Else
                                ISTMessageBox.Show("Greska 14! Zovite administratora! ")
                            End If
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara, True)

                Try
                    'frm.Show() '= TrueF

                    frm.pDGDupliKlikIzISTDGV(podtabela, KljuceviPodtabelaSavrednostima, KljuceviGlavnaSaVrednostima)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbZavrsenoP.Checked = True Then
                    filterStatus = "ZAVRSENOP"
                ElseIf rbZavrsenoNP.Checked = True Then
                    filterStatus = "ZAVRSENONP"
                ElseIf rbZapoceto.Checked = True Then
                    filterStatus = "ZAPOCETO"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True

            End If
        End If

        'If DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("DDELETE").DisplayIndex Then
        '    Call BrisanjeReda(erowindex)
        '    erowindex = erowindex - 1
        'End If


        Me.Cursor = Cursors.Default

    End Sub

    Sub DgvRegBRMPCellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)

        Me.Cursor = Cursors.WaitCursor

        If erowindex >= 0 Then
            DGVRegBrMP.ClearSelection()
            DGVRegBrMP.Rows(erowindex).Selected = True

            If DGVRegBrMP.Columns(eColumnIndex).DisplayIndex = DGVRegBrMP.Columns("Unos").DisplayIndex Then

                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim tabela As String = "OpstiPodaci"
                Dim zakljucanOdmahSve As Boolean = False
                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True : zakljucanOdmahSve = True

                Dim KljuceviSaEkranaSaVrednostima(,) As String
                ReDim KljuceviSaEkranaSaVrednostima(1, 1)
                KljuceviSaEkranaSaVrednostima(0, 0) = "PIG".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(0, 1) = DGVRegBrMP.Rows(erowindex).Cells(DGVRegBrMP.Columns("PIG").Index).Value.ToString
                KljuceviSaEkranaSaVrednostima(1, 0) = "RBR".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(1, 1) = DGVRegBrMP.Rows(erowindex).Cells(DGVRegBrMP.Columns("RBR").Index).Value.ToString


                Dim dosaoIzCapiAdresara As Boolean = True
                'filtDatumZakazan.Items.Clear()

                Dim strStatus As String = "select statusanketar from adresar where PIG='" + KljuceviSaEkranaSaVrednostima(0, 1) + "' and RBR='" + KljuceviSaEkranaSaVrednostima(1, 1) + "' ;" + nvrd
                Dim dtStatus As DataTable = izvrsiSQLvratiDT(strStatus, Me.DBConnectionString, Nothing)
                Dim kojistatus As String = ""

                If dtStatus.Rows.Count > 0 Then
                    kojistatus = dtStatus.Rows(0).Item(0).ToString.Trim
                Else
                    Exit Sub
                End If

                If kojistatus = "2" OrElse kojistatus = "3" Then
                    zakljucanOdmahSve = True
                ElseIf kojistatus = "1" Then
                    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                        Case "Ne"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

                Try
                    frm.ShowDialog()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try

                refreshDGVRegBrMP()


            End If
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Sub ZahtevZaDoradu(ByVal selectedRow As Integer)


        DGV1.ClearSelection()
        DGV1.Rows(selectedRow).Selected = True

        Dim si As Integer = DGV1.SelectedRows(0).Index
        Dim dgvStatusAnketar As String = DGV1.Rows(si).Cells(DGV1.Columns("statusanketar").Index).Value.ToString.Trim

        Call pZahNonVisible()

        'zapamceniStatusanketar = dgvStatusAnketar
        panelZahtevZaDoradu.Tag = selectedRow

        If dgvStatusAnketar = "3" Then cbZahtevZaDoradu.Checked = True
        tboxZahtevPig.Text = DGV1.Rows(si).Cells(DGV1.Columns("PIG").Index).Value.ToString
        tboxZahtevRbr.Text = DGV1.Rows(si).Cells(DGV1.Columns("RBR").Index).Value.ToString
        tboxZahtevRazlog.Text = DGV1.Rows(si).Cells(DGV1.Columns("napomenaStatusAnketar").Index).Value.ToString
        tboxZahtevAdresa.Text = DGV1.Rows(si).Cells(DGV1.Columns("ulica").Index).Value.ToString + " " + DGV1.Rows(si).Cells(DGV1.Columns("kbr").Index).Value.ToString


        Call pZahVisible()

    End Sub
    Private Function DajKljuceve(ByVal tbl As String) As String()
        Dim klj() As String = {}
        For Each p As DatasetIstrazivanja.ISTPOLJARow In Me.dist.ISTPOLJA.Rows
            If p.TABELA.Trim.ToUpper = tbl.Trim.ToUpper Then
                If Not p.IsKLJUCNull AndAlso p.KLJUC.Trim.ToUpper = "P" Then
                    ReDim Preserve klj(1 + klj.GetUpperBound(0))
                    klj(klj.GetUpperBound(0)) = p.POLJE.Trim.ToUpper
                End If
            End If
        Next
        Return klj
    End Function

    Sub enabledtabkontrolu()
        TabControl1.Tag = "enabled"
    End Sub
    Sub disabledtabkontrolu()
        TabControl1.Tag = "disabled"
    End Sub

    Sub p3NonVisible()

        Call enabledtabkontrolu()
        tboxNapomenaPIG.Text = ""
        tboxNapomenaRBR.Text = ""
        tboxNapomenaAdresa.Text = ""
        tboxNapomenaNapomena.Text = ""
        Call nesamoja(panelNapomena)
        Me.panelNapomena.Visible = False

    End Sub
    Sub Promena(ByVal selectedRow As Integer)
        Call p3NonVisible()

        DGV1.ClearSelection()
        DGV1.Rows(selectedRow).Selected = True

        Dim si As Integer = DGV1.SelectedRows(0).Index

        tboxNapomenaPIG.Text = DGV1.Rows(si).Cells(DGV1.Columns("PIG").Index).Value.ToString
        tboxNapomenaRBR.Text = DGV1.Rows(si).Cells(DGV1.Columns("RBR").Index).Value.ToString
        tboxNapomenaAdresa.Text = DGV1.Rows(si).Cells(DGV1.Columns("Ulica").Index).Value.ToString + " " + DGV1.Rows(si).Cells(DGV1.Columns("Kbr").Index).Value.ToString
        tboxNapomenaNapomena.Text = DGV1.Rows(si).Cells(DGV1.Columns("ISTNote").Index).Value.ToString

        tboxNapomenaPIG.Enabled = False
        tboxNapomenaRBR.Enabled = False
        tboxNapomenaAdresa.Enabled = False
        tboxNapomenaPIG.Visible = True
        tboxNapomenaNapomena.Enabled = True
        tboxNapomenaNapomena.SelectionStart = tboxNapomenaNapomena.Text.Length + 1
        tboxNapomenaPIG.BringToFront()

        Call p3Visible()

    End Sub

    Private Sub btnNapomenaOK_Click(sender As Object, e As EventArgs) Handles btnNapomenaOK.Click


        If tboxNapomenaNapomena.Text.Trim = "" Then
            ISTMessageBox.Show("Napomena ne sme biti prazna!")
            Call p3NonVisible()
            Exit Sub
        Else
            Dim str As String = ""
            If tboxNapomenaPIG.Text.Trim.ToUpper <> "" AndAlso tboxNapomenaRBR.Text.Trim.ToUpper <> "" Then
                str = " update Adresar" + vbCrLf +
                      " set istnote=N'" + tboxNapomenaNapomena.Text.Trim + "'" + vbCrLf +
                      " where anketar=N'" + kosam + "' and pig='" + tboxNapomenaPIG.Text.Trim + "' and rbr='" + tboxNapomenaRBR.Text.Trim + "'"
            Else
                ISTMessageBox.Show("Dogodila se greška. Pokušajte ponovo!")
                Call p3NonVisible()
                Exit Sub
            End If
            Dim ok As String = izvrsiSQL(str, Me.DBConnectionString)
            If ok = "ok" Then
            Else
                ISTMessageBox.Show("Greska 3! Zovite administratora! ")
            End If
            Call p3NonVisible()

            Dim filterStatus As String = ""
            If rbZavrsenoP.Checked = True Then
                filterStatus = "ZAVRSENOP"
            ElseIf rbZavrsenoNP.Checked = True Then
                filterStatus = "ZAVRSENONP"
            ElseIf rbZapoceto.Checked = True Then
                filterStatus = "ZAPOCETO"
            ElseIf rbVraceno.Checked = True Then
                filterStatus = "VRACENO"
            ElseIf rbSve.Checked = True Then
                filterStatus = "SVE"
            End If

            refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

            DGV1.Focus()
        End If

    End Sub


    Private Sub btnNapomenaCancel_Click(sender As Object, e As EventArgs) Handles btnNapomenaCancel.Click
        Call p3NonVisible()
        DGV1.Focus()
    End Sub

    Sub p3Visible()
        Call disabledtabkontrolu()
        panelNapomena.BringToFront()
        Me.panelNapomena.Visible = True
        Call samoja(panelNapomena)
        tboxNapomenaNapomena.Focus()
    End Sub

    Sub srediCell(ByVal dgv As DataGridView, ByVal ime As String, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If DGV1.Columns(ime) Is Nothing Then Exit Sub
        Dim ki As Integer = DGV1.Columns(ime).Index
        If e.ColumnIndex = ki AndAlso e.Value IsNot Nothing Then
            e.CellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem

        Dim tabContas As TabControl = DirectCast(sender, TabControl)
        Dim sTexto As String = tabContas.TabPages(e.Index).Text
        Dim g As Graphics = e.Graphics
        Dim fonte As Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'tabContas.Font
        Dim format = New System.Drawing.StringFormat
        'CHANGES HERE...
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center
        Dim pincel As New SolidBrush(Color.White)
        ''RENEMED VARIEBLE HERE...
        Dim retangulo As RectangleF = RectangleF.op_Implicit(tabContas.GetTabRect(e.Index))

        fonte = New Font(fonte, FontStyle.Bold)
        g.FillRectangle(Brushes.DarkGreen, retangulo)

        g.DrawString(sTexto, fonte, pincel, retangulo, format)
    End Sub
    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub



    Private Sub SetLang()
        ''
        Dim dt As DataTable = getDTVBText(dtLang, "FormPoljoprivreda")
    End Sub


    Private Sub ButtonIzlaz_Click(sender As Object, e As EventArgs) Handles ButtonIzlaz.Click

        Me.Close()
    End Sub


    Private Sub btnRegBrMP_Click(sender As Object, e As EventArgs) Handles btnRegBrMP.Click

        Call refreshDGVRegBrMP()

    End Sub

    Sub refreshDGVRegBrMP()

        Dim selektovanred As Integer = -1
        Dim selektovanPig As String = ""
        Dim selektovanRbr As Integer = -1
        If DGVRegBrMP.SelectedCells.Count > 0 Then
            selektovanred = DGVRegBrMP.SelectedCells.Item(0).RowIndex
        End If
        If selektovanred >= 0 Then
            selektovanPig = DGVRegBrMP.Rows(selektovanred).Cells(DGVRegBrMP.Columns("PIG").Index).Value.ToString
            selektovanRbr = DGVRegBrMP.Rows(selektovanred).Cells(DGVRegBrMP.Columns("RBR").Index).Value.ToString
        End If

        Dim str As String = "" + nvrd +
            " DROP TABLE IF EXISTS  #pp " + nvrd +
            " select distinct p422_1 as regbrmp, pig, rbr into #pp from opstipodaci o where isnull(p422_1,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'PP700001')" + nvrd +
            " union" + nvrd +
            " select distinct p422_2 as regbrmp, pig, rbr from opstipodaci o where isnull(p422_2,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " union" + nvrd +
            " Select distinct p422_3 As regbrmp, pig, rbr from opstipodaci o where isnull(p422_3,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " union" + nvrd +
            " select distinct p422_4 as regbrmp, pig, rbr from opstipodaci o where isnull(p422_4,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " union" + nvrd +
            " select distinct p422_5 as regbrmp, pig, rbr from opstipodaci o where isnull(p422_5,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " union" + nvrd +
            " select distinct p422_6 as regbrmp, pig, rbr from opstipodaci o where isnull(p422_5,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " union" + nvrd +
            " Select distinct regbrmp, pig, rbr from adresar where isnull(regbrmp,'')<>'' and anketar='" + kosam + "' " + nvrd + nvrd +
            "" + nvrd +
            " select distinct p422_1 as regbrmp, o.pig, o.rbr, (case when exists(select * from adresar a where o.pig=a.pig and o.rbr=a.rbr and isnull(statusanketar,0) not in (2,3)) then N'📝' else '' end) " + nvrd +
            " as Unos, " + nvrd +
            " (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
            " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=aa.pig and o.rbr=aa.rbr) then 'ZAPOCETO'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
            " else '' end) as status" + nvrd +
            " from opstipodaci o inner join (select pig,rbr,statusanketar,user_statusanketar from adresar) aa on aa.pig=o.pig and aa.rbr=o.rbr " + nvrd +
            " where isnull(p422_1,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " and exists(select * from #pp p where o.p422_1=p.regbrmp and not(p.pig=o.pig and p.rbr=o.rbr))" + nvrd +
            " union" + nvrd +
            " select distinct p422_2, o.pig, o.rbr, (case when exists(select * from adresar a where o.pig=a.pig and o.rbr=a.rbr and isnull(statusanketar,0) not in (2,3)) then N'📝' else '' end) " + nvrd +
            " as Unos, " + nvrd +
            " (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
            " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=aa.pig and o.rbr=aa.rbr) then 'ZAPOCETO'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
            " else '' end) as status" + nvrd +
            " from opstipodaci o inner join (select pig,rbr,statusanketar,user_statusanketar from adresar) aa on aa.pig=o.pig and aa.rbr=o.rbr " + nvrd +
            " where isnull(p422_2,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " and exists(select * from #pp p where o.p422_2=p.regbrmp and not(p.pig=o.pig and p.rbr=o.rbr))" + nvrd +
            " union" + nvrd +
            " select distinct p422_3, o.pig, o.rbr, (case when exists(select * from adresar a where o.pig=a.pig and o.rbr=a.rbr and isnull(statusanketar,0) not in (2,3)) then N'📝' else '' end) " + nvrd +
            " as Unos, " + nvrd +
            " (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
            " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=aa.pig and o.rbr=aa.rbr) then 'ZAPOCETO'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
            " else '' end) as status" + nvrd +
            " from opstipodaci o inner join (select pig,rbr,statusanketar,user_statusanketar from adresar) aa on aa.pig=o.pig and aa.rbr=o.rbr " + nvrd +
            " where isnull(p422_3,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " and exists(select * from #pp p where o.p422_3=p.regbrmp and not(p.pig=o.pig and p.rbr=o.rbr))" + nvrd +
            " union" + nvrd +
            " select distinct p422_4, o.pig, o.rbr, (case when exists(select * from adresar a where o.pig=a.pig and o.rbr=a.rbr and isnull(statusanketar,0) not in (2,3)) then N'📝' else '' end) " + nvrd +
            " as Unos, " + nvrd +
            " (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
            " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=aa.pig and o.rbr=aa.rbr) then 'ZAPOCETO'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
            " else '' end) as status" + nvrd +
            " from opstipodaci o inner join (select pig,rbr,statusanketar,user_statusanketar from adresar) aa on aa.pig=o.pig and aa.rbr=o.rbr " + nvrd +
            " where isnull(p422_4,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " and exists(select * from #pp p where o.p422_4=p.regbrmp and not(p.pig=o.pig and p.rbr=o.rbr))" + nvrd +
            " union" + nvrd +
            " select distinct p422_5, o.pig, o.rbr, (case when exists(select * from adresar a where o.pig=a.pig and o.rbr=a.rbr and isnull(statusanketar,0) not in (2,3)) then N'📝' else '' end) " + nvrd +
            " as Unos, " + nvrd +
            " (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
            " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=aa.pig and o.rbr=aa.rbr) then 'ZAPOCETO'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
            " else '' end) as status" + nvrd +
            " from opstipodaci o inner join (select pig,rbr,statusanketar,user_statusanketar from adresar) aa on aa.pig=o.pig and aa.rbr=o.rbr " + nvrd +
            " where isnull(p422_5,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " and exists(select * from #pp p where o.p422_5=p.regbrmp and not(p.pig=o.pig and p.rbr=o.rbr))" + nvrd +
            " union" + nvrd +
            " select distinct p422_6, o.pig, o.rbr, (case when exists(select * from adresar a where o.pig=a.pig and o.rbr=a.rbr and isnull(statusanketar,0) not in (2,3)) then N'📝' else '' end) " + nvrd +
            " as Unos, " + nvrd +
            " (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
            " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=aa.pig and o.rbr=aa.rbr) then 'ZAPOCETO'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
            " else '' end) as status" + nvrd +
            " from opstipodaci o inner join (select pig,rbr,statusanketar,user_statusanketar from adresar) aa on aa.pig=o.pig and aa.rbr=o.rbr " + nvrd +
            " where isnull(p422_6,'')<>'' and exists(select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar=N'" + kosam + "')" + nvrd +
            " and exists(select * from #pp p where o.p422_6=p.regbrmp and not(p.pig=o.pig and p.rbr=o.rbr))" + nvrd +
            " union" + nvrd +
            " select distinct regbrmp, pig, rbr, (case when isnull(statusanketar,0) not in (2,3) then N'📝' else '' end) as Unos, (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
            " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=a.pig and o.rbr=a.rbr) then 'ZAPOCETO'" + nvrd +
            " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
            " else '' end) as status" + nvrd +
            " from adresar a where isnull(regbrmp,'')<>'' and anketar=N'" + kosam + "'" + nvrd +
            " and exists(select * from #pp p where a.regbrmp=p.regbrmp and not(p.pig=a.pig and p.rbr=a.rbr))" + nvrd +
            " order by 1,2,3"

        Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
        'DGVRegBrMP
        DGVRegBrMP.DataSource = dt
        DGVRegBrMP.Columns("regbrmp").HeaderText = "Reg br u Min polj"
        DGVRegBrMP.Columns("pig").HeaderText = "PIG"
        DGVRegBrMP.Columns("rbr").HeaderText = "RBR"
        DGVRegBrMP.Columns("Unos").HeaderText = ""
        DGVRegBrMP.Columns("Status").Visible = False

        DGVRegBrMP.Columns("regbrmp").Width = 120

        srediGridView333()
        Call samoja(PanelRegBrMP)
        PanelRegBrMP.Visible = True

        If selektovanPig <> "" AndAlso selektovanRbr > -1 Then
            DGVRegBrMP.ClearSelection()
            Dim selectedrow As Integer = vratiSelektvanRedDGVRegBrMP(selektovanPig, selektovanRbr)
            If selectedrow >= 0 AndAlso DGVRegBrMP.Rows.Count > 0 AndAlso DGVRegBrMP.Rows.Count - 1 >= selectedrow Then
                DGVRegBrMP.Rows(selectedrow).Selected = True
            ElseIf DGV1.Rows.Count > 0 Then
                DGVRegBrMP.Rows(0).Selected = True
            Else
            End If
        End If

    End Sub

    Dim dodatak As String = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                  " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                  " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                  " Set @Hash  = '12345';    " + vbCrLf +
                  " Declare @a as varbinary(256);  " + vbCrLf
    Sub refreshDGV1(ByVal filterNas As String, ByVal filtPigg As String, ByVal filterzak As String, ByVal filtRPGg As String, Optional ByVal filterstatus As String = "")


        Dim selektovanred As Integer = -1
        Dim selektovanPig As String = ""
        Dim selektovanRbr As Integer = -1
        If DGV1.SelectedCells.Count > 0 Then
            selektovanred = DGV1.SelectedCells.Item(0).RowIndex
        End If
        If selektovanred >= 0 Then
            selektovanPig = DGV1.Rows(selektovanred).Cells(DGV1.Columns("PIG").Index).Value.ToString
            selektovanRbr = DGV1.Rows(selektovanred).Cells(DGV1.Columns("RBR").Index).Value.ToString
        End If
        '✔
        Dim str As String = ""

        Dim dt As DataTable
        Dim a As String = ""
        'Dim aa As System.Windows.Forms.SortOrder = Nothing
        Dim b As Integer = -1
        If Not DGV1 Is Nothing Then
            a = DGV1.SortOrder.ToString
            'aa = DGV1.SortOrder
            If Not DGV1.SortedColumn Is Nothing Then
                b = DGV1.SortedColumn.Index
            End If
        End If
        Dim filterdatumZvezdica As String = ""
        If filtDatumZakazan.Text.Trim = "*" Then
            filterdatumZvezdica = ""
        Else
            filterdatumZvezdica = filtDatumZakazan.Text
        End If

        Dim sacuvajvrFilteraZak As String = filtDatumZakazan.Text
        '" when isnull(statusanketar,0) in ('1','0') and not exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr and trim(isnull(odziv,''))='7') then N'📝' else '' end) as PoglOpstiPodaci, " + nvrd +

        str = dodatak + " Select '+' as PodeliPIG,a.PIG, a.rbr, RegBrMP, PravniStatus, (case when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash)))))+' '+trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(Prezime)='' then NULL else Prezime end),1), 1, CONVERT(varbinary, @Hash))))) " + nvrd +
              " when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))) else '' end) as ImePrezime, Nazivnaselja, NASELJe, " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) ULICA, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kbr)='' then NULL else kbr end),1), 1, CONVERT(varbinary, @Hash))))) Kbr, " + nvrd +
              " + (case when isnull(trim(MOBILNITelefon),'')<>'' and isnull(trim(Telefon),'')<>'' then trim(TELEFON)+', '+trim(MOBILNITelefon) " + nvrd +
              " when isnull(trim(MOBILNITelefon),'')='' and isnull(trim(Telefon),'')<>'' then trim(TELEFON) " + nvrd +
              " when isnull(trim(MOBILNITelefon),'')<>'' and isnull(trim(Telefon),'')='' then trim(MOBILNITelefon) else '' end) as Tel, OPstina, Nazivopstine," + nvrd +
              " N'' as Prazno0,  " + nvrd +
              " (case when isnull(statusanketar,0) in ('2','3') then '' " + nvrd +
              " when isnull(statusanketar,0) in ('1','0') then N'📝' else '' end) as PoglOpstiPodaci, " + nvrd +
              " (case when isnull(P2,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'🌻' when isnull(P2,0)=0 then N' /' else '' end) as PoglZemljiste," + nvrd +
              " (case when isnull(P3,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'🍒' when isnull(P3,0)=0 then N' /' else '' end) as PoglVocnjaciVinogradi," + nvrd +
              " (case when isnull(P4,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'🐷' when isnull(P4,0)=0 then N' /' else '' end) as PoglStoka," + nvrd +
              " (case when isnull(P5,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'👪' when isnull(P5,0)=0 then N' /' else '' end) as PoglRadnaSnaga, " + nvrd +
              " (case when isnull(M1,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'💧'  when isnull(M1,0)=0 then N' /' else '' end) as PoglNavodnjavanje, " + nvrd +
              " (case when isnull(M2,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'♺'  when isnull(M2,0)=0 then N' /' else '' end) as PoglDjubrivo," + nvrd +
              " (case when isnull(M3,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'🏡' when isnull(M3,0)=0 then N' /' else '' end) as PoglNacinDrzanjaStoke," + nvrd +
              " (case when isnull(M4,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'🚜' when isnull(M4,0)=0 then N' /' else '' end) as PoglMehanizacija, " + nvrd +
              " (case when isnull(M5,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'🏕' when isnull(M5,0)=0 then N' /' else '' end) as PoglObrada," + nvrd +
              " (case when isnull(M6,0)=1 and exists (select * from opstipodaci where a.pig=pig and a.rbr=rbr) then N'💬' when isnull(M6,0)=0 then N' /' else '' end) as PoglOstaliPodaci, " + nvrd +
              " N'' as PraznoB,(case when isnull(UzorakVV,0)=1 then 'Da' else 'Ne' end) as UzorakVV, N'' as praznoC, " + nvrd +
              " (case when isnull(statusanketar,0) in ('2','3','1') then '' " + nvrd +
              " when isnull(statusanketar,0)=0 then N'🗓' else '' end) as Zakazivanje, " + nvrd +
              " Ishod, ZakazanoDatum, ZakazanoVreme, IshodNapomena," + nvrd +
              " N'' as Prazno1, N'🖉' as Napomena, istnote, N'' as PraznoD, " + nvrd +
              " (case when isnull(a.statusAnketar,0)=2 and isnull(webunos,0)<>1 then N'🖐' else '' end ) as ZahtevDorada, (case when isnull(a.statusAnketar,0)=3 then N' Tražen zahtev' else  a.napomenaKontrolorNivo1 end) as napomenaKontrolorNivo1, N'' as PraznoA, a.napomenaStatusAnketar," + nvrd +
              " CATI_nacin, BrojTelefona, KontaktOsoba, DatumDolaska, god, " + nvrd +
              " (case when isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' then 'ZAVRSENOP'" + nvrd +
              " when isnull(statusanketar,0)='1' and user_statusanketar like 'p%' then 'ZAVRSENONP'" + nvrd +
              " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=a.pig and o.rbr=a.rbr) then 'ZAPOCETO'" + nvrd +
              " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
              " else '' end) as status, statusanketar, '' as proba,  isnull(cast(o.Odziv as nvarchar(2)),'') as odziv" + nvrd +
              " from Adresar a left join (select pig, rbr, odziv from opstipodaci) o on a.pig=o.pig and a.rbr=o.rbr where anketar=N'" + kosam + "' and Nazivnaselja like '%" + filterNas + "%' and a.pig like N'%" + filtPigg + "%' and isnull(ZakazanoDatum,'') like N'%" + filterdatumZvezdica + "%'" + nvrd +
              " and isnull(regBrMP,'') like N'%" + filtRPGg + "%' " + nvrd

        If filterstatus.Trim.ToUpper = "" OrElse filterstatus.Trim.ToUpper = "SVE" Then

        ElseIf filterstatus.Trim.ToUpper = "ZAVRSENOP" Then
            str = str + nvrd + " and isnull(statusanketar,0) in ('2','3') and user_statusanketar like 'p%' "
        ElseIf filterstatus.Trim.ToUpper = "ZAVRSENONP" Then
            str = str + nvrd + " and isnull(statusanketar,0)='1' and user_statusanketar like 'p%' "
        ElseIf filterstatus.Trim.ToUpper = "ZAPOCETO" Then
            str = str + nvrd + " and isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) not in ('I7','I8') and exists (select * from OpstiPodaci o where o.pig=a.pig and o.rbr=a.rbr) "
        ElseIf filterstatus.Trim.ToUpper = "VRACENO" Then
            str = str + nvrd + " and isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') "
        End If

        str = str + nvrd + " order by OPstina,NASELJe,ULICA,Kbr,PIG, rbr"

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)

        DGV1.DataSource = dt

        If a.Trim.ToUpper <> "NONE" AndAlso a.Trim.ToUpper <> "" AndAlso b >= 0 Then
            If a.Trim.ToUpper = "DESCENDING" Then
                DGV1.Sort(DGV1.Columns(b), ListSortDirection.Descending)
            ElseIf a.Trim.ToUpper = "ASCENDING" Then
                DGV1.Sort(DGV1.Columns(b), ListSortDirection.Ascending)
            End If
        End If

        DGV1.Columns("PravniStatus").Visible = False
        DGV1.Columns("NASELJe").Visible = False
        DGV1.Columns("OPstina").Visible = False
        DGV1.Columns("Nazivopstine").Visible = False
        'DGV1.Columns("Ishod").Visible = False
        'DGV1.Columns("IshodNapomena").Visible = False
        DGV1.Columns("CATI_nacin").Visible = False
        DGV1.Columns("BrojTelefona").Visible = False
        DGV1.Columns("KontaktOsoba").Visible = False
        DGV1.Columns("DatumDolaska").Visible = False
        DGV1.Columns("status").Visible = False
        DGV1.Columns("god").Visible = False
        DGV1.Columns("napomenaStatusAnketar").Visible = False
        DGV1.Columns("StatusAnketar").Visible = False
        DGV1.Columns("proba").Visible = False
        DGV1.Columns("PoglZemljiste").Visible = False
        DGV1.Columns("PoglVocnjaciVinogradi").Visible = False
        DGV1.Columns("PoglStoka").Visible = False
        DGV1.Columns("PoglRadnaSnaga").Visible = False
        DGV1.Columns("PoglNavodnjavanje").Visible = False
        DGV1.Columns("PoglDjubrivo").Visible = False
        DGV1.Columns("PoglNacinDrzanjaStoke").Visible = False
        DGV1.Columns("PoglMehanizacija").Visible = False
        DGV1.Columns("PoglObrada").Visible = False
        DGV1.Columns("PoglOstaliPodaci").Visible = False
        DGV1.Columns("UzorakVV").Visible = False
        DGV1.Columns("PraznoB").Visible = False
        DGV1.Columns("UzorakVV").Visible = False
        DGV1.Columns("Odziv").Visible = False


        'DGV1.Columns("Nazivnaselja").Frozen = True
        'DGV1.Columns("ZakazanoVreme").Frozen = True
        'DGV1.Columns("DA").Width = 100
        'DGV1.Columns("praznoA").MinimumWidth = 2
        DGV1.Columns("Ishod").HeaderText = "Ishod posete"
        DGV1.Columns("IshodNapomena").HeaderText = "Napomena"
        DGV1.Columns("PIG").HeaderText = "PIG"
        DGV1.Columns("rbr").HeaderText = "RBR"
        DGV1.Columns("ImePrezime").HeaderText = "Ime i prezime / Naziv PL"
        DGV1.Columns("Nazivnaselja").HeaderText = "Naziv naselja"
        DGV1.Columns("ULICA").HeaderText = "Ulica"
        DGV1.Columns("Kbr").HeaderText = "Kućni broj"
        DGV1.Columns("TEL").HeaderText = "Telefon"
        DGV1.Columns("Zakazivanje").HeaderText = ""
        DGV1.Columns("Napomena").HeaderText = "Unos napomene"
        DGV1.Columns("Prazno0").HeaderText = ""
        DGV1.Columns("Prazno1").HeaderText = ""
        DGV1.Columns("PraznoA").HeaderText = ""
        DGV1.Columns("PraznoB").HeaderText = ""
        DGV1.Columns("PraznoC").HeaderText = ""
        DGV1.Columns("PraznoD").HeaderText = ""
        DGV1.Columns("PodeliPIG").HeaderText = ""
        DGV1.Columns("IstNote").HeaderText = ""
        DGV1.Columns("ZakazanoDatum").HeaderText = "Datum"
        DGV1.Columns("ZakazanoVreme").HeaderText = "Vreme"
        DGV1.Columns("ZahtevDorada").HeaderText = ""
        DGV1.Columns("UzorakVV").HeaderText = "U uzorku za voćnjake i vinograde"
        DGV1.Columns("napomenaKontrolorNivo1").HeaderText = "Napomena instruktora"
        DGV1.Columns("RegBrMP").HeaderText = "RPG"

        DGV1.Columns("PoglZemljiste").HeaderText = "P2"
        DGV1.Columns("PoglVocnjaciVinogradi").HeaderText = "P3"
        DGV1.Columns("PoglStoka").HeaderText = "P4"
        DGV1.Columns("PoglRadnaSnaga").HeaderText = "P5"
        DGV1.Columns("PoglNavodnjavanje").HeaderText = "M1"
        DGV1.Columns("PoglDjubrivo").HeaderText = "M2"
        DGV1.Columns("PoglNacinDrzanjaStoke").HeaderText = "M3"
        DGV1.Columns("PoglMehanizacija").HeaderText = "M4"
        DGV1.Columns("PoglObrada").HeaderText = "M5"
        DGV1.Columns("PoglOstaliPodaci").HeaderText = "P6"
        DGV1.Columns("PoglOpstiPodaci").HeaderText = "P1"


        DGV1.Columns("PIG").Width = 90
        DGV1.Columns("rbr").Width = 40
        DGV1.Columns("ImePrezime").Width = 200
        DGV1.Columns("Nazivnaselja").Width = 200
        DGV1.Columns("ULICA").Width = 200
        DGV1.Columns("kbr").Width = 60
        DGV1.Columns("PoglZemljiste").Width = 30
        DGV1.Columns("PoglVocnjaciVinogradi").Width = 30
        DGV1.Columns("PoglStoka").Width = 30
        DGV1.Columns("PoglRadnaSnaga").Width = 30
        DGV1.Columns("PoglNavodnjavanje").Width = 30
        DGV1.Columns("PoglDjubrivo").Width = 30
        DGV1.Columns("PoglNacinDrzanjaStoke").Width = 30
        DGV1.Columns("PoglMehanizacija").Width = 30
        DGV1.Columns("PoglObrada").Width = 30
        DGV1.Columns("PoglOstaliPodaci").Width = 30
        DGV1.Columns("PoglOpstiPodaci").Width = 50
        DGV1.Columns("prazno0").MinimumWidth = 2
        DGV1.Columns("Prazno0").Width = 2
        DGV1.Columns("prazno1").MinimumWidth = 2
        DGV1.Columns("Prazno1").Width = 2
        DGV1.Columns("praznoA").MinimumWidth = 2
        DGV1.Columns("PraznoA").Width = 2
        DGV1.Columns("praznoB").MinimumWidth = 2
        DGV1.Columns("PraznoB").Width = 2
        DGV1.Columns("praznoC").MinimumWidth = 2
        DGV1.Columns("PraznoC").Width = 2
        DGV1.Columns("praznoD").MinimumWidth = 2
        DGV1.Columns("PraznoD").Width = 2
        DGV1.Columns("PodeliPIG").Width = 30
        DGV1.Columns("IstNote").Width = 130
        DGV1.Columns("Zakazivanje").Width = 30
        DGV1.Columns("ZakazanoDatum").Width = 80
        DGV1.Columns("ZakazanoVreme").Width = 65
        DGV1.Columns("TEL").Width = 100
        DGV1.Columns("Ishod").Width = 50
        DGV1.Columns("UzorakVV").Width = 83
        DGV1.Columns("Napomena").Width = 70
        DGV1.Columns("ZahtevDorada").Width = 30
        DGV1.Columns("napomenaKontrolorNivo1").Width = 200
        DGV1.Columns("proba").Width = 300
        DGV1.Columns("RegBrMP").Width = 120
        'DGV1.Columns("Zakazivanje").Width = 70
        'DGV1.Columns("Kbr").Width =
        'DGV1.Columns("TELEFON").Width = 70
        'DGV1.Columns("MobilniTELEFON").Width = 70

        '.Columns("BrojvracenihStanova").DefaultCellStyle.ForeColor = Color.Red

        DGV1.EnableHeadersVisualStyles = False

        'DGV1.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'DGV1.Columns("BrojvracenihStanova").DefaultCellStyle.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold)

        'DGV1.Columns("brojstanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        'DGV1.Columns("BrojZavrStanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        'DGV1.Columns("BrojvracenihStanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        'DGV1.Columns("DA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

        If Not filtNaseljeee Is Nothing Then
            'filtNaseljeee.Width = DGV1.Columns("Nazivnaselja").Width
            'filtNaseljeee.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width + DGV1.Columns("PIG").Width + DGV1.Columns("rbr").Width + DGV1.Columns("ImePrezime").Width, DGV1.ColumnHeadersHeight - filtNaseljeee.Height - 1)
            filtNaseljeee.Visible = True
        End If

        If Not filtPig Is Nothing Then

            'filtPig.Width = DGV1.Columns("PIG").Width
            'filtPig.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width, DGV1.ColumnHeadersHeight - filtPig.Height - 1)
            'filtPig.AccessibleName = filtPig.Location.X
            filtPig.BringToFront()
            filtPig.Visible = True
        End If

        If Not filtRPG Is Nothing Then

            'filtPig.Width = DGV1.Columns("PIG").Width
            'filtPig.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width, DGV1.ColumnHeadersHeight - filtPig.Height - 1)
            'filtPig.AccessibleName = filtPig.Location.X
            filtRPG.BringToFront()
            filtRPG.Visible = True
        End If

        If Not filtDatumZakazan Is Nothing AndAlso Not DGV1 Is Nothing Then
            'filtDatumZakazan.Width = DGV1.Columns("ZakazanoDatum").Width
            'filtDatumZakazan.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width + DGV1.Columns("PIG").Width + DGV1.Columns("rbr").Width + DGV1.Columns("ImePrezime").Width _
            '    + DGV1.Columns("Nazivnaselja").Width + DGV1.Columns("Ulica").Width + DGV1.Columns("Kbr").Width + DGV1.Columns("Tel").Width + DGV1.Columns("Prazno0").Width _
            '    + DGV1.Columns("Zakazivanje").Width + DGV1.Columns("Ishod").Width + DGV1.Columns("Prazno0").Width + DGV1.Columns("PoglOpstiPodaci").Width + DGV1.Columns("PoglZemljiste").Width _
            '    + DGV1.Columns("PoglVocnjaciVinogradi").Width + DGV1.Columns("PoglStoka").Width + DGV1.Columns("PoglRadnaSnaga").Width + DGV1.Columns("PoglNavodnjavanje").Width + DGV1.Columns("PoglDjubrivo").Width _
            '    + DGV1.Columns("PoglNacinDrzanjaStoke").Width + DGV1.Columns("PoglMehanizacija").Width + DGV1.Columns("PoglObrada").Width + DGV1.Columns("PoglOstaliPodaci").Width + DGV1.Columns("PraznoB").Width _
            '    + DGV1.Columns("UzorakVV").Width + DGV1.Columns("praznoC").Width, DGV1.ColumnHeadersHeight - filtNaseljeee.Height - 1)
            filtDatumZakazan.Visible = True
            filtDatumZakazan.Text = sacuvajvrFilteraZak
            srediGridView222()
        End If


        If selektovanPig <> "" AndAlso selektovanRbr > -1 Then
            DGV1.ClearSelection()
            Dim selectedrow As Integer = vratiSelektvanRedDGV1(selektovanPig, selektovanRbr)


            If selectedrow >= 0 AndAlso DGV1.Rows.Count > 0 AndAlso DGV1.Rows.Count - 1 >= selectedrow Then
                DGV1.Rows(selectedrow).Selected = True
            ElseIf DGV1.Rows.Count > 0 Then
                DGV1.Rows(0).Selected = True
            Else

            End If

        End If

        Dim strlbl As String = " select count(*) ukupno, " + nvrd +
                                  "(select count(*) from opstipodaci o where isnull(odziv,'0')='1' and exists (select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar='" + kosam + "')) odziv1, " + nvrd +
                                  " (select count(*) from opstipodaci o where isnull(odziv,'0')<>'1' and exists (select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar='" + kosam + "')) neodziv1 " + nvrd +
                                  " from adresar where anketar='" + kosam + "'" + nvrd

        Dim dtlbl As DataTable = izvrsiSQLvratiDT(strlbl, DBConnectionString, Me.jezik)
        If dtlbl.Rows.Count = 1 Then
            lblUkupno.Text = "Ukupno gazdinstava: " + dtlbl.Rows(0).Item(0).ToString + "     Broj gazdinstva sa odzivom jedan: " + dtlbl.Rows(0).Item(1).ToString + "     Broj gazdinstva sa odzivom različitim od jedan: " + dtlbl.Rows(0).Item(2).ToString + ""
        Else
            lblUkupno.Text = ""
        End If


        DGV1.Visible = True

    End Sub

    Function vratiSelektvanRedDGV1(ByVal selektovanPig As String, ByVal selektovanRbr As Integer) As Integer
        Dim pomrowDGV1 As Integer = 0

        If DGV1.Rows.Count > 0 Then

            Dim kojiPIG As String = selektovanPig
            Dim kojiRBR As String = selektovanRbr

            For i As Integer = 0 To DGV1.Rows.Count - 1
                If kojiPIG.Trim = DGV1.Rows(i).Cells(DGV1.Columns("PIG").Index).Value.ToString().Trim AndAlso kojiRBR.Trim = DGV1.Rows(i).Cells(DGV1.Columns("RBR").Index).Value.ToString().Trim Then
                    pomrowDGV1 = i
                    'DGV2.Rows(i).Selected = True
                    Exit For
                End If
            Next
        End If
        Return pomrowDGV1
    End Function

    Function vratiSelektvanRedDGVRegBrMP(ByVal selektovanPig As String, ByVal selektovanRbr As Integer) As Integer
        Dim pomrowDGVRegBrMP As Integer = 0

        If DGVRegBrMP.Rows.Count > 0 Then

            Dim kojiPIG As String = selektovanPig
            Dim kojiRBR As String = selektovanRbr

            For i As Integer = 0 To DGV1.Rows.Count - 1
                If kojiPIG.Trim = DGVRegBrMP.Rows(i).Cells(DGVRegBrMP.Columns("PIG").Index).Value.ToString().Trim AndAlso kojiRBR.Trim = DGVRegBrMP.Rows(i).Cells(DGVRegBrMP.Columns("RBR").Index).Value.ToString().Trim Then
                    pomrowDGVRegBrMP = i
                    'DGV2.Rows(i).Selected = True
                    Exit For
                End If
            Next
        End If
        Return pomrowDGVRegBrMP
    End Function


    Private Sub DGV1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        If DGV1.Visible = False Then
            Exit Sub
        End If
        'If DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("StatusAnketar").Index).Value.ToString = "0" AndAlso Mid(DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("User_StatusAnketar").Index).Value.ToString, 0, 1) = "P" Then
        '    DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew    'SystemColors.ControlLightLight
        'ElseIf DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("StatusAnketar").Index).Value.ToString = "0" AndAlso Mid(DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("User_StatusAnketar").Index).Value.ToString, 0, 1) = "I" Then
        '    DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White    'SystemColors.ControlLightLight
        'End If
        If DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("status").Index).Value.ToString = "ZAVRSENOP" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ElseIf DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("status").Index).Value.ToString = "ZAVRSENONP" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew
        ElseIf DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("status").Index).Value.ToString = "ZAPOCETO" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow
        ElseIf DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("status").Index).Value.ToString = "VRACENO" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose
        Else
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White
        End If

    End Sub

    Private Sub DGVRegBrMP_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGVRegBrMP.CellFormatting
        If DGVRegBrMP.Visible = False Then
            Exit Sub
        End If
        If DGVRegBrMP.Rows(e.RowIndex).Cells(DGVRegBrMP.Columns("status").Index).Value.ToString = "ZAVRSENOP" Then
            DGVRegBrMP.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ElseIf DGVRegBrMP.Rows(e.RowIndex).Cells(DGVRegBrMP.Columns("status").Index).Value.ToString = "ZAVRSENONP" Then
            DGVRegBrMP.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew
        ElseIf DGVRegBrMP.Rows(e.RowIndex).Cells(DGVRegBrMP.Columns("status").Index).Value.ToString = "ZAPOCETO" Then
            DGVRegBrMP.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow
        ElseIf DGVRegBrMP.Rows(e.RowIndex).Cells(DGVRegBrMP.Columns("status").Index).Value.ToString = "VRACENO" Then
            DGVRegBrMP.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose
        Else
            DGVRegBrMP.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White
        End If

    End Sub

    Private Sub dgv_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles DGV1.ColumnWidthChanged
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim rtHeader As Rectangle = dgv.DisplayRectangle
        rtHeader.Height = dgv.ColumnHeadersHeight / 2
        dgv.Invalidate(rtHeader)

        If Not DGV1 Is Nothing Then
            DGV1.Columns("prazno0").MinimumWidth = 2
            DGV1.Columns("prazno0").Width = 2
            DGV1.Columns("prazno1").MinimumWidth = 2
            DGV1.Columns("prazno1").Width = 2
            DGV1.Columns("praznoA").MinimumWidth = 2
            DGV1.Columns("praznoA").Width = 2
            DGV1.Columns("praznoB").MinimumWidth = 2
            DGV1.Columns("praznoB").Width = 2
        End If

    End Sub

    Private Sub DGVRegBrMP_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles DGVRegBrMP.ColumnWidthChanged
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim rtHeader As Rectangle = dgv.DisplayRectangle
        rtHeader.Height = dgv.ColumnHeadersHeight / 2
        dgv.Invalidate(rtHeader)
    End Sub

    Private Sub dgv1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles DGV1.Scroll
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim rtHeader As Rectangle = dgv.DisplayRectangle
        rtHeader.Height = dgv.ColumnHeadersHeight / 2
        dgv.Invalidate(rtHeader)
    End Sub

    Private Sub DGVRegBrMP_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles DGVRegBrMP.Scroll
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim rtHeader As Rectangle = dgv.DisplayRectangle
        rtHeader.Height = dgv.ColumnHeadersHeight / 2
        dgv.Invalidate(rtHeader)
    End Sub

    Private Sub dgv_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DGV1.CellPainting

        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        If dgv.Name.Trim.ToUpper = "DGV1" Then
            Call sredigrid(28, 4, dgv, e, "Zakazivanje posete / ponovnog dolaska", color1, Color.Black)
            Call sredigrid(34, 1, dgv, e, "Unos i izmena napomene", color1, Color.Black)
            'Call sredigrid(13, 11, dgv, e, "Poglavlja i moduli", color1, Color.Black)
            Call sredigrid(37, 1, dgv, e, "Zahtev za doradu", color1, Color.Black)
        End If


    End Sub
    Sub sredigrid(ByVal poc As Integer, ByVal brkol As Integer, ByVal dgv As DataGridView, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs, ByVal headername As String, ByVal backcolor As Color, ByVal forecolor As Color)

        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then

            Dim w2 As Integer = 0
            Dim pocetni As Integer = poc
            Dim brkolona As Integer = brkol
            For i As Integer = pocetni To dgv.Columns.Count
                If dgv.Columns(i).Visible = False Then
                Else
                    pocetni = i
                    Exit For
                End If
            Next
            Dim r1 As Rectangle = dgv.GetCellDisplayRectangle(pocetni, -1, True)
            If r1.X = 0 AndAlso r1.Y = 0 Then
                Exit Sub
            End If
            Dim krajnja As Integer = 0
            For i As Integer = pocetni To dgv.Columns.Count
                If dgv.Columns(i).Visible = False Then
                Else
                    'e.Handled = True
                    w2 = w2 + dgv.Columns(i).Width
                    brkolona = brkolona - 1
                    'dgv.Columns(i).HeaderCell.Style.BackColor = backcolor
                    'dgv.Columns(i).HeaderCell.Style.ForeColor = forecolor
                    krajnja = i + 1
                    If brkolona = -1 Then Exit For
                End If
            Next

            'r1.X += 1
            'r1.Y += 1
            r1.Width = w2 - 1
            r1.Height = r1.Height \ 2.5
            ''e.Graphics.FillRectangle(New SolidBrush(dgv.ColumnHeadersDefaultCellStyle.BackColor), r1)
            e.Graphics.FillRectangle(New SolidBrush(backcolor), r1)

            e.Graphics.DrawRectangle(New Pen(Drawing.Color.Lavender, 1), r1)

            Dim format As New StringFormat()
            format.Alignment = StringAlignment.Center
            format.LineAlignment = StringAlignment.Center
            e.Graphics.DrawString(headername, dgv.ColumnHeadersDefaultCellStyle.Font, New SolidBrush(forecolor), r1, format)
            'e.Graphics.DrawRectangle(New Pen(Drawing.Color.Lavender, 1), r1)

        End If

    End Sub

    Private Sub btnZakCancel_Click(sender As Object, e As EventArgs) Handles btnZakCancel.Click
        Call pZakazivanjeStanaNonVisible()
        DGV1.Focus()
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

        If e.ColumnIndex <> DGV1.Columns("PodeliPig").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("Zakazivanje").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("Napomena").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglZemljiste").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglVocnjaciVinogradi").DisplayIndex _
            AndAlso e.ColumnIndex <> DGV1.Columns("PoglStoka").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglRadnaSnaga").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglNavodnjavanje").DisplayIndex _
            AndAlso e.ColumnIndex <> DGV1.Columns("PoglDjubrivo").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglNacinDrzanjaStoke").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglMehanizacija").DisplayIndex _
            AndAlso e.ColumnIndex <> DGV1.Columns("PoglObrada").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglOstaliPodaci").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglOpstiPodaci").DisplayIndex _
            AndAlso e.ColumnIndex <> DGV1.Columns("ZahtevDorada").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("Tel").DisplayIndex Then
            Exit Sub
        End If
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        Else
            Call Dgv1CellContentClick(e.RowIndex, e.ColumnIndex)
        End If
    End Sub

    Private Sub DGVRegBrMP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRegBrMP.CellContentClick

        If e.ColumnIndex <> DGVRegBrMP.Columns("UNOS").DisplayIndex Then
            Exit Sub
        End If
        Call DgvRegBRMPCellContentClick(e.RowIndex, e.ColumnIndex)

    End Sub

    Private Sub btnZakOk_Click(sender As Object, e As EventArgs) Handles btnZakOk.Click

        Dim ok As Boolean = True
        Dim ch1 As Integer = 0
        Dim si As Integer = DGV1.SelectedRows(0).Index
        Dim pig As String = DGV1.Rows(si).Cells(DGV1.Columns("pig").Index).Value.ToString.Trim
        Dim rbr As String = DGV1.Rows(si).Cells(DGV1.Columns("rbr").Index).Value.ToString.Trim

        If cbPonistiZak.Checked = True Then
            Dim msgtxt As String = "Da li ste sigurni da želite da obrišete zakazivanje?"
            ''videti šta ako postoje podaci!!!!! NISTA, NIJE DOZVOLJENO
            Dim msgtitle As String = "............"

            Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
            Select Case opc
                Case "Da"
                    Dim opc2 As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle, 2)
                    Select Case opc2
                        Case "Da"

                            Dim strSQLponisti As String = " update Adresar " + vbCrLf +
                                   " set ishod=null, IshodNapomena=''," +
                                   " date_update=getdate(), user_update=N'" + kosam + "', " + vbCrLf +
                                   " zakazanovreme='', " + vbCrLf +
                                   " zakazanoDatum='', " + vbCrLf +
                                   " kontaktosoba='', " + vbCrLf +
                                   " BrojTelefona='', " + vbCrLf +
                                   " DatumDolaska='' " + vbCrLf +
                                   " where anketar=N'" + kosam + "' and pig='" + pig + "' and rbr='" + rbr + "'"


                            Dim ok2 As String = izvrsiSQL(strSQLponisti, Me.DBConnectionString)
                            If ok2 = "ok" Then
                                ISTMessageBox.Show("Obrisano!")
                                '''20220715 Call refreshDGV1()

                                Dim filterStatus2 As String = ""
                                If rbZavrsenoP.Checked = True Then
                                    filterStatus2 = "ZAVRSENOP"
                                ElseIf rbZavrsenoNP.Checked = True Then
                                    filterStatus2 = "ZAVRSENONP"
                                ElseIf rbZapoceto.Checked = True Then
                                    filterStatus2 = "ZAPOCETO"
                                ElseIf rbVraceno.Checked = True Then
                                    filterStatus2 = "VRACENO"
                                ElseIf rbSve.Checked = True Then
                                    filterStatus2 = "SVE"
                                End If

                                refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus2)

                                If DGV1.Rows.Count > 0 Then
                                    DGV1.ClearSelection()
                                    DGV1.Rows(si).Selected = True
                                End If

                                cbPonistiZak.Checked = False
                                Call pZakazivanjeStanaNonVisible()
                            Else
                                ISTMessageBox.Show("Greska 4! Zovite administratora! ")
                            End If

                        Case "Ne"
                        Case "Cancel"
                    End Select
                Case "Ne"
                Case "Cancel"
            End Select
            Exit Sub
        End If

        If dtpDatumDolaska.Text.Trim = "" Then
            ISTMessageBox.Show("Morate uneti datum posete!")
            Exit Sub
        End If

        If dtpZakazanoDatum.Text.Trim <> "" AndAlso dtpZakazanoVreme.Text.Trim <> "" Then
            Dim str As String = "select * from Adresar where anketar=N'" + kosam + "' and " + nvrd +
                                "( (select count(*) from Adresar where anketar=N'" + kosam + "' and ZakazanoDatum='" + dtpZakazanoDatum.Text + "' and ZakazanoVreme='" + dtpZakazanoVreme.Text + "' ) - " + nvrd +
                                "  (select count(*) from Adresar where anketar=N'" + kosam + "' and ZakazanoDatum='" + dtpZakazanoDatum.Text + "' and ZakazanoVreme='" + dtpZakazanoVreme.Text + "' and pig='" + pig + "' and rbr='" + rbr + "' ) )>0 "
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)

            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Za ovaj datum i vreme već imate zakazan termin popisivanja, morate promeniti ili datum ili vreme.")
                dtpZakazanoDatum.Focus()
                Exit Sub
            End If
        End If

        If rb1.Checked = False AndAlso rb2.Checked = False AndAlso rb4.Checked = False AndAlso rb6.Checked = False AndAlso rb7.Checked = False Then
            ISTMessageBox.Show("Morate označiti ishod posete!")
            Exit Sub
        End If

        If (rb2.Checked = True OrElse rb4.Checked = True) Then
            If dtpZakazanoDatum.Text.Trim = "" Then
                ISTMessageBox.Show("Morate uneti datum zakazane posete!")
                dtpZakazanoDatum.Focus()
                Exit Sub
            ElseIf dtpZakazanoVreme.Text.Trim = "" Then
                ISTMessageBox.Show("Morate uneti vreme zakazane posete!")
                dtpZakazanoVreme.Focus()
                Exit Sub
            End If
        End If


        If (rb6.Checked = True OrElse rb7.Checked = True) Then
            If txtIshodNapomena.Text.Trim = "" OrElse txtIshodNapomena.Text.Trim.Length < 10 Then
                ISTMessageBox.Show("Morate uneti napomenu, bar 10 znakova!")
                txtIshodNapomena.Focus()
                Exit Sub
            End If
        End If

        If dtpZakazanoDatum.Text.Trim <> "" AndAlso dtpZakazanoDatum.Text.Trim.Length <> 10 Then
            ISTMessageBox.Show("Nije ispravan format datuma.")
            dtpZakazanoDatum.Focus()
            Exit Sub
        End If

        If dtpDatumDolaska.Text.Trim <> "" AndAlso dtpDatumDolaska.Text.Trim.Length <> 10 Then
            ISTMessageBox.Show("Nije ispravan format datuma.")
            dtpDatumDolaska.Focus()
            Exit Sub
        End If

        If dtpZakazanoDatum.Text.Trim <> "" AndAlso dtpDatumDolaska.Text.Trim <> "" Then
            Dim dZD As String = dtpZakazanoDatum.Text.Trim
            Dim dDD As String = dtpDatumDolaska.Text.Trim

            Dim dzdY As Integer = CInt(dZD.Substring(6, 4))
            Dim dzdM As Integer = CInt(dZD.Substring(3, 2))
            Dim dzdD As Integer = CInt(dZD.Substring(0, 2))

            Dim dDDY As Integer = CInt(dDD.Substring(6, 4))
            Dim dDDM As Integer = CInt(dDD.Substring(3, 2))
            Dim dDDD As Integer = CInt(dDD.Substring(0, 2))

            Dim okok As Integer = 1

            If dzdY > dDDY Then
                okok = 0
            ElseIf dzdY = dDDY AndAlso dzdM > dDDM Then
                okok = 0
            ElseIf dzdY = dDDY AndAlso dzdM = dDDM AndAlso dzdD >= dDDD Then
                okok = 0
            End If

            If okok = 1 Then
                ISTMessageBox.Show("Datum posete mora biti manji ili jednak zakazanom datumu!")
                dtpZakazanoDatum.Focus()
                Exit Sub
            End If
        End If

        Dim iishod As Integer = 0

        If rb1.Checked = True Then iishod = 1
        If rb2.Checked = True Then iishod = 2
        If rb4.Checked = True Then iishod = 3
        If rb6.Checked = True Then iishod = 4
        If rb7.Checked = True Then iishod = 5

        Dim strSQL As String = " update Adresar " + vbCrLf +
                                   " set ishod='" + CStr(iishod).Trim + "', IshodNapomena=N'" + Me.txtIshodNapomena.Text.Trim + "'," +
                                   " date_update=getdate(), user_update=N'" + kosam + "'"

        strSQL = strSQL + ", zakazanovreme=N'" + dtpZakazanoVreme.Text + "'"
        strSQL = strSQL + ", zakazanoDatum=N'" + dtpZakazanoDatum.Text + "'"
        strSQL = strSQL + ", kontaktosoba=N'" + txtKontaktOsoba.Text + "'"
        strSQL = strSQL + ", BrojTelefona=N'" + txtBrojTelefona.Text + "'"
        strSQL = strSQL + ", DatumDolaska=N'" + dtpDatumDolaska.Text + "'"

        'strSQL = strSQL + ", date_update='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', user_update='ANK'"

        strSQL = strSQL + vbCrLf +
                    " where anketar=N'" + kosam + "' and pig='" + pig + "' and rbr='" + rbr + "' "

        Dim ok1 As String = izvrsiSQL(strSQL, Me.DBConnectionString)
        If ok1 = "ok" Then
        Else
            ISTMessageBox.Show("Greska 5! Zovite administratora! ")
        End If

        '''20220715 Call refreshDGV1()
        Dim pomocnaNapomenaKBR As String = ""
        Dim pomocnaUlicaMapa As String = ""
        Dim pomocnaUlica As String = ""

        Dim pomocna As String = ""
        pomocna = filtDatumZakazan.Text
        Call popunicbo(filtDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from Adresar where anketar=N'" + kosam + "' and isnull(ZakazanoDatum,'')<>'' order by ZakazanoDatum", Me.DBConnectionString, False, False, True, True)
        filtDatumZakazan.Text = pomocna

        Dim filterStatus As String = ""
        If rbZavrsenoP.Checked = True Then
            filterStatus = "ZAVRSENOP"
        ElseIf rbZavrsenoNP.Checked = True Then
            filterStatus = "ZAVRSENONP"
        ElseIf rbZapoceto.Checked = True Then
            filterStatus = "ZAPOCETO"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If
        refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

        If DGV1.Rows.Count > 0 Then
            DGV1.ClearSelection()
            DGV1.Rows(si).Selected = True
        End If

        Call pZakazivanjeStanaNonVisible()

    End Sub

    Private lblOuter As Label = New Label()
    Private controlLocation As Point

    Private Sub panel_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelZakazivanje.MouseDown, panelZahtevZaDoradu.MouseDown, panelNapomena.MouseDown, PanelRegBrMP.MouseDown, panelPutniTroskovi.MouseDown
        sender.Parent.Controls.Add(lblOuter)
        controlLocation = e.Location
        sender.cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelZakazivanje.MouseMove, panelZahtevZaDoradu.MouseMove, panelNapomena.MouseMove, PanelRegBrMP.MouseMove, panelPutniTroskovi.MouseMove

        If e.Button = MouseButtons.Left Then
            Dim l As Integer = sender.Left + e.X - controlLocation.X
            Dim t As Integer = sender.Top + e.Y - controlLocation.Y
            Dim w As Integer = sender.Width
            Dim h As Integer = sender.Height
            l = If((l < 0), 0, (If((l + w > sender.Parent.ClientRectangle.Width), sender.Parent.ClientRectangle.Width - w, l)))
            t = If((t < 0), 0, (If((t + h > sender.Parent.ClientRectangle.Height), sender.Parent.ClientRectangle.Height - h, t)))
            sender.Left = l
            sender.Top = t
            lblOuter.Left = l
            lblOuter.Top = t
            lblOuter.Width = w
            lblOuter.Height = h
            sender.Parent.Update()
            sender.Parent.Invalidate()
        End If
    End Sub
    Private Sub panel_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelZakazivanje.MouseUp, panelZahtevZaDoradu.MouseUp, panelNapomena.MouseUp, PanelRegBrMP.MouseUp, panelPutniTroskovi.MouseUp
        sender.Parent.Controls.remove(lblOuter)
        sender.cursor = Cursors.Default
    End Sub

    Private Sub DGV1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.RowHeaderMouseDoubleClick

        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Dim erowindex As Integer = e.RowIndex
        'If erowindex >= 0 Then
        '    Dim zzak As Boolean = False
        '    Dim red As Integer = erowindex
        '    Dim tabela As String = "OpstiPodaci"
        '    Dim zakljucanOdmahSve As Boolean = False
        '    Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
        '    If zak = 1 Then zzak = True : zakljucanOdmahSve = True

        '    Dim KljuceviSaEkranaSaVrednostima(,) As String
        '    ReDim KljuceviSaEkranaSaVrednostima(1, 1)
        '    KljuceviSaEkranaSaVrednostima(0, 0) = "PIG".Trim.ToUpper
        '    KljuceviSaEkranaSaVrednostima(0, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("PIG").Index).Value.ToString
        '    KljuceviSaEkranaSaVrednostima(1, 0) = "RBR".Trim.ToUpper
        '    KljuceviSaEkranaSaVrednostima(1, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("RBR").Index).Value.ToString


        '    Dim dosaoIzCapiAdresara As Boolean = True
        '    'filtDatumZakazan.Items.Clear()

        '    Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
        '       True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
        '       Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

        '    Try
        '        frm.ShowDialog()
        '    Catch ex As Exception
        '        ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Finally
        '        frm.Dispose()
        '    End Try

        '    Dim filterStatus As String = ""
        '    If rbZavrsenoP.Checked = True Then
        '        filterStatus = "ZAVRSENOP"
        '    ElseIf rbZavrsenoNP.Checked = True Then
        '        filterStatus = "ZAVRSENONP"
        '    ElseIf rbZapoceto.Checked = True Then
        '        filterStatus = "ZAPOCETO"
        '    ElseIf rbVraceno.Checked = True Then
        '        filterStatus = "VRACENO"
        '    ElseIf rbSve.Checked = True Then
        '        filterStatus = "SVE"
        '    End If

        '    refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtDatumZakazan.Text, filtRPG.Text, filterStatus)

        '    'DGV1.ClearSelection()
        '    'DGV1.Rows(erowindex).Selected = True
        'Else
        '    ISTMessageBox.Show("Dogodila se greka. Pokušajte ponovo.")
        'End If
        'Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub btnLegendaM_Click(sender As Object, e As EventArgs) Handles btnLegenda.Click
        Dim pom As Button = DirectCast(sender, Button)
        Dim overlayHandle As ISTFormIsLoading
        overlayHandle = New ISTFormIsLoading(Me, Me.TabControl1.Parent)
        overlayHandle.Show()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If pom.Text = "_" Then
            LegMinimize()
            If pom.Name = btnLegenda.Name Then
                DGV1.Focus()
                btnLegenda.Text = "🗖"
            End If
        ElseIf pom.Text = "🗖" Then
            LegMaximize()
            If pom.Name = btnLegenda.Name Then
                DGV1.Focus()
                btnLegenda.Text = "_"
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        overlayHandle.Close()
    End Sub

    Private Sub LegMinimize()

        Call SuspendDrawing(TabControl1)
        Call SuspendDrawing(PanelLegendaDGV1)


        Dim pomkojigrid As String = ""
        If DGV1.Visible = True Then
            pomkojigrid = "DGV1"
        End If
        Label9.Visible = False
        TabControl1.Visible = False
        PanelLegendaDGV1.Visible = False
        PanelLegendaDGV1.Height = 24
        Dim pom As Integer = TabControl1.Location.Y
        TabControl1.Location = New Point(TabControl1.Location.X, PanelLegendaDGV1.Location.Y + PanelLegendaDGV1.Height + 50)
        TabControl1.Height = TabControl1.Height - PanelLegendaDGV1.Location.Y - PanelLegendaDGV1.Height - 50 + pom 'Me.ButtonIzlaz.Location.Y - Me.ButtonIzlaz.Height -

        TabControl1.Visible = True
        PanelLegendaDGV1.Visible = True

        gbStatusi.Location = New Point(gbStatusi.Location.X, PanelLegendaDGV1.Location.Y + PanelLegendaDGV1.Height + 10)
        gbFilteri.Location = New Point(gbStatusi.Location.X + gbStatusi.Width + 10, gbStatusi.Location.Y)


        If pomkojigrid = "DGV1" Then
            DGV1.Visible = True
            DGV1.BringToFront()
        End If

        Call ResumeDrawing(TabControl1)
        Call ResumeDrawing(PanelLegendaDGV1)


    End Sub
    Dim TabControl1locX As Integer = 0
    Dim TabControl1locY As Integer = 0
    Dim TabControl1Height As Integer = 0

    Private Sub LegMaximize()

        Call SuspendDrawing(TabControl1)
        Call SuspendDrawing(PanelLegendaDGV1)

        Label9.Visible = True
        TabControl1.Visible = False
        TabControl1.Location = New Point(TabControl1locX, TabControl1locY)
        TabControl1.Height = TabControl1Height
        TabControl1.Visible = True


        Call ResumeDrawing(TabControl1)
        PanelLegendaDGV1.Visible = False
        PanelLegendaDGV1.Height = 304 ' visinaLegende1
        PanelLegendaDGV1.Visible = True
        gbStatusi.Location = New Point(gbStatusi.Location.X, PanelLegendaDGV1.Location.Y + PanelLegendaDGV1.Height + 10)
        gbFilteri.Location = New Point(gbStatusi.Location.X + gbStatusi.Width + 30, gbStatusi.Location.Y)

        'filtPig.Location = New Point(gbFilteri.Location.X + 30, gbFilteri.Location.Y - 30)
        Call ResumeDrawing(PanelLegendaDGV1)

    End Sub

    Private Sub ButtonIzvestaji_Click(sender As Object, e As EventArgs) Handles ButtonIzvestaji.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor


        'Call zatvoriIPonistiPanele()

        Dim frm As New FormIzvestaji(Me.DBConnectionString, Me.ISTConnectionString, ttab, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.vrt, folder, mb,
                                     Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.CAPIServer, Me.CAPIBaza, txtmode,
                                     Me.jezik, Nothing, Me.txtInst, Me.txtpismo, Me.txtoffice)
        Me.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            Me.Show()
            'If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Procedures and reports")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub rbZavrsenoP_CheckedChanged(sender As Object, e As EventArgs) Handles rbZavrsenoP.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, "ZAVRSENOP")
    End Sub

    Private Sub rbZavrsenoNP_CheckedChanged(sender As Object, e As EventArgs) Handles rbZavrsenoNP.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, "ZAVRSENONP")
    End Sub

    Private Sub rbZapoceto_CheckedChanged(sender As Object, e As EventArgs) Handles rbZapoceto.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, "ZAPOCETO")
    End Sub

    Private Sub rbVraceno_CheckedChanged(sender As Object, e As EventArgs) Handles rbVraceno.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, "VRACENO")
    End Sub

    Private Sub rbSve_CheckedChanged(sender As Object, e As EventArgs) Handles rbSve.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, "SVE")
    End Sub

    Private Sub llPonisti_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPonisti.LinkClicked

        Dim filterStatus As String = ""
        If rbZavrsenoP.Checked = True Then
            filterStatus = "ZAVRSENOP"
        ElseIf rbZavrsenoNP.Checked = True Then
            filterStatus = "ZAVRSENONP"
        ElseIf rbZapoceto.Checked = True Then
            filterStatus = "ZAPOCETO"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If
        filtNaseljeee.Text = ""
        filtPig.Text = ""
        filtDatumZakazan.Text = "*"
        filtRPG.Text = ""
        'SetCueText(filtPig, "🔎 ")
        refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)

    End Sub

    Private Sub btnZatvori_Click(sender As Object, e As EventArgs) Handles btnZatvori.Click
        DGVRegBrMP.ClearSelection()
        PanelRegBrMP.Visible = False
        Call nesamoja(PanelRegBrMP)

        Dim filterStatus As String = ""
        If rbZavrsenoP.Checked = True Then
            filterStatus = "ZAVRSENOP"
        ElseIf rbZavrsenoNP.Checked = True Then
            filterStatus = "ZAVRSENONP"
        ElseIf rbZapoceto.Checked = True Then
            filterStatus = "ZAPOCETO"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If

        refreshDGV1(filtNaseljeee.Text, filtPig.Text.Trim, filtDatumZakazan.Text.Trim, filtRPG.Text.Trim, filterStatus)
    End Sub

    Private Sub DGV1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentDoubleClick
        Dim aa As String = ""
        If 2 = 2 Then

        End If
    End Sub

    Private Sub btnPutniTroskovi_Click(sender As Object, e As EventArgs) Handles btnPutniTroskovi.Click

        Call panelPutniTroskoviVisible()

    End Sub

    Private Sub btnZatvoriPT_Click(sender As Object, e As EventArgs) Handles btnZatvoriPT.Click

        Call panelPutniTroskoviNonVisible()

    End Sub

    Private Sub btnSopPrev_Click(sender As Object, e As EventArgs) Handles btnSopPrev.Click

        Dim zzak As Boolean = False
        Dim anketar As String = kosam.Trim.ToUpper
        Dim tabela As String = "PutniTroskovi"
        Dim zakljucanOdmahSve As Boolean = False
        Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
        If zak = 1 Then zzak = True : zakljucanOdmahSve = True

        Dim KljuceviSaEkranaSaVrednostima(,) As String
        ReDim KljuceviSaEkranaSaVrednostima(4, 1)
        KljuceviSaEkranaSaVrednostima(0, 0) = "AnketarNalog"
        KljuceviSaEkranaSaVrednostima(0, 1) = anketar

        KljuceviSaEkranaSaVrednostima(1, 0) = "TipPrevoza"
        KljuceviSaEkranaSaVrednostima(1, 1) = "1"

        KljuceviSaEkranaSaVrednostima(2, 0) = "Dan"
        KljuceviSaEkranaSaVrednostima(2, 1) = ""

        KljuceviSaEkranaSaVrednostima(3, 0) = "Mesec"
        KljuceviSaEkranaSaVrednostima(3, 1) = ""

        KljuceviSaEkranaSaVrednostima(4, 0) = "Godina"
        KljuceviSaEkranaSaVrednostima(4, 1) = ""


        Dim dosaoIzCapiAdresara As Boolean = True
        'filtDatumZakazan.Items.Clear()

        Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
           True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
           Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

        Try
            frm.ShowDialog()
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            frm.Dispose()
        End Try



    End Sub

    Private Sub btnJavPrev_Click(sender As Object, e As EventArgs) Handles btnJavPrev.Click

        Dim zzak As Boolean = False
        Dim anketar As String = kosam.Trim.ToUpper
        Dim tabela As String = "PutniTroskovi"
        Dim zakljucanOdmahSve As Boolean = False
        Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
        If zak = 1 Then zzak = True : zakljucanOdmahSve = True

        Dim KljuceviSaEkranaSaVrednostima(,) As String
        ReDim KljuceviSaEkranaSaVrednostima(4, 1)
        KljuceviSaEkranaSaVrednostima(0, 0) = "AnketarNalog"
        KljuceviSaEkranaSaVrednostima(0, 1) = anketar

        KljuceviSaEkranaSaVrednostima(1, 0) = "TipPrevoza"
        KljuceviSaEkranaSaVrednostima(1, 1) = "2"

        KljuceviSaEkranaSaVrednostima(2, 0) = "Dan"
        KljuceviSaEkranaSaVrednostima(2, 1) = ""

        KljuceviSaEkranaSaVrednostima(3, 0) = "Mesec"
        KljuceviSaEkranaSaVrednostima(3, 1) = ""

        KljuceviSaEkranaSaVrednostima(4, 0) = "Godina"
        KljuceviSaEkranaSaVrednostima(4, 1) = ""


        Dim dosaoIzCapiAdresara As Boolean = True
        'filtDatumZakazan.Items.Clear()

        Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
               True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
               Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

        Try
            frm.ShowDialog()
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            frm.Dispose()
        End Try


    End Sub


    Private Sub txtBrojTelefona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrojTelefona.KeyPress

        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(13) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> " "c)
        End If

        If e.KeyChar = ChrW(13) Then
            txtIshodNapomena.Focus()
            txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
            txtIshodNapomena.SelectionLength = 0
        End If

    End Sub

    Private Sub dtpDatumDolaska_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dtpDatumDolaska.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape 'ESC

            Case Keys.Enter
                GroupBox1.Focus()
        End Select

    End Sub

    Private Sub dtpZakazanoDatum_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dtpZakazanoDatum.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape 'ESC

            Case Keys.Enter
                dtpZakazanoVreme.Focus()
        End Select
    End Sub

    Private Sub dtpZakazanoVreme_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles dtpZakazanoVreme.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape 'ESC

            Case Keys.Enter
                txtKontaktOsoba.Focus()
        End Select

    End Sub


    Private Sub txtKontaktOsoba_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKontaktOsoba.KeyPress

        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(13) Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c)
        End If

        If e.KeyChar = ChrW(13) Then
            txtBrojTelefona.Focus()
            txtBrojTelefona.SelectionStart = txtBrojTelefona.Text.Length
            txtBrojTelefona.SelectionLength = 0
        End If
    End Sub

    Private Sub LegendaHouse_TextChanged(sender As Object, e As EventArgs) Handles LegendaHouse.TextChanged

    End Sub

    Private Sub lblHouse_Click(sender As Object, e As EventArgs) Handles lblHouse.Click

    End Sub
End Class

'Public Module CueBannerText3
'    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
'    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
'    End Function
'    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
'    Private Const EM_SETCUEBANNER As Integer = &H1501


'    Public Sub SetCueText(cntrl As Control, text As String)
'        If TypeOf cntrl Is ComboBox Then
'            Dim Edit_hWnd As IntPtr = FindWindowEx(cntrl.Handle, IntPtr.Zero, "Edit", Nothing)
'            If Not Edit_hWnd = IntPtr.Zero Then
'                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
'            End If
'        ElseIf TypeOf cntrl Is TextBox Then
'            SendMessage(cntrl.Handle, EM_SETCUEBANNER, 0, text)
'        End If
'    End Sub
'End Module
'Class CCombobox3 : Inherits ComboBox
'    Sub New()
'        Me.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
'    End Sub

'    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
'        MyBase.OnDrawItem(e)
'        Dim item As CComboboxItem = DirectCast(Me.Items(e.Index), CComboboxItem)
'        Using ForeBrush As Brush = New SolidBrush(item.Forecolor)
'            Using BackBrush As Brush = New SolidBrush(item.Backcolor)
'                e.Graphics.FillRectangle(BackBrush, e.Bounds)
'                e.Graphics.TranslateTransform(0, e.Bounds.Y)
'                e.Graphics.DrawString(item.ToString, Me.Font, ForeBrush, 0, 0)
'            End Using
'        End Using
'    End Sub
'End Class
'Class CComboboxItem3

'    Public Sub New(Value As Object, Color As Color, BackColor As Color)
'        Me.Value = Value
'        Me.Forecolor = Color
'        Me.Backcolor = BackColor
'    End Sub

'    Public Property Value As Object = Nothing
'    Public Property Forecolor As Color = Color.Black
'    Public Property Backcolor As Color = Color.Black

'    Public Overrides Function ToString() As String
'        Return Value.ToString
'    End Function

'End Class

