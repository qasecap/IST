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

Public Class FormPpoljoKon
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
    Friend WithEvents lblkojikont As Label
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
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPin As Label
    Friend WithEvents LegendaPin As TextBox
    Friend WithEvents LegendaPencil As TextBox
    Friend WithEvents lblPencil As Label
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
    Friend WithEvents tboxNapomenaNapomena As TextBox
    Friend WithEvents lblNapomenaRBR As Label
    Friend WithEvents lblNapomenaNapomena As Label
    Friend WithEvents tboxNapomenaAdresa As TextBox
    Friend WithEvents lblNapomenaNaslov As Label
    Friend WithEvents pbEU As PictureBox
    Friend WithEvents gbStatusi As GroupBox
    Friend WithEvents rbSve As RadioButton
    Friend WithEvents rbVraceno As RadioButton
    Friend WithEvents panelZahtevZaDoradu As Panel
    Friend WithEvents lblZahtev As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tboxZahtevRbr As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents tboxZahtevAdresa As TextBox
    Friend WithEvents tboxZahtevPig As TextBox
    Friend WithEvents btnZahtevCancel As Button
    Friend WithEvents btnZahtevOK As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents tboxRazlogZahtev As TextBox
    Friend WithEvents gbFilteri As GroupBox
    Friend WithEvents filtPig As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents filtNaseljeee As TextBox
    Friend WithEvents llPonisti As LinkLabel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblUkupno As Label

    Friend WithEvents rbZahtevOdbijen As RadioButton
    Friend WithEvents rbZahtevOdobren As RadioButton
    Friend WithEvents gbVracanje As GroupBox
    Friend WithEvents tbRazlogVracanja As TextBox
    Friend WithEvents gbZahtevTrazi As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbPlaceni As RadioButton
    Friend WithEvents rbZaPlacanje As RadioButton
    Friend WithEvents lblPopisivac As Label
    Friend WithEvents filtPopisivac As ComboBox
    Friend WithEvents btnRaspodela As Button
    Friend WithEvents lblVracanje As Label
    Friend WithEvents panelRaspodela As Panel
    Friend WithEvents btnRaspodelaAA As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents btnRaspodelaNA As Button
    Friend WithEvents btnRaspodelaCancel As Button
    Friend WithEvents panelRaspodelaNA As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents gbRaspodelaNA As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cbOdKogaNA As ComboBox
    Friend WithEvents cbKomeNA As ComboBox
    Friend WithEvents btnRaspodelaNACancel As Button
    Friend WithEvents btnRaspodelaNAOK As Button
    Friend WithEvents gbGazdinstvaRaspodelaNA As GroupBox
    Friend WithEvents dgvNA As DataGridView
    Friend WithEvents btnNastaviNA As Button
    Friend WithEvents LegendaHouse As TextBox
    Friend WithEvents lblHouse As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbCekirajSveNA As CheckBox
    Friend WithEvents gbSecurity As GroupBox
    Friend WithEvents lblRaspodelaAAPoruka As Label
    Friend WithEvents labelsToolTip As ToolTip

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPpoljoKon))
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
        Me.ButtonIzlaz = New System.Windows.Forms.Button()
        Me.llOVDE = New System.Windows.Forms.LinkLabel()
        Me.ButtonIzvestaji = New System.Windows.Forms.Button()
        Me.ButtonLK = New System.Windows.Forms.Button()
        Me.labelsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.PanelLegendaDGV1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LegendaHouse = New System.Windows.Forms.TextBox()
        Me.lblHouse = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.LegendaPin = New System.Windows.Forms.TextBox()
        Me.LegendaPencil = New System.Windows.Forms.TextBox()
        Me.lblPencil = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.pbEU = New System.Windows.Forms.PictureBox()
        Me.gbStatusi = New System.Windows.Forms.GroupBox()
        Me.rbPlaceni = New System.Windows.Forms.RadioButton()
        Me.rbZaPlacanje = New System.Windows.Forms.RadioButton()
        Me.rbSve = New System.Windows.Forms.RadioButton()
        Me.rbVraceno = New System.Windows.Forms.RadioButton()
        Me.panelZahtevZaDoradu = New System.Windows.Forms.Panel()
        Me.lblVracanje = New System.Windows.Forms.Label()
        Me.lblZahtev = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tboxZahtevRbr = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tboxZahtevAdresa = New System.Windows.Forms.TextBox()
        Me.tboxZahtevPig = New System.Windows.Forms.TextBox()
        Me.btnZahtevCancel = New System.Windows.Forms.Button()
        Me.btnZahtevOK = New System.Windows.Forms.Button()
        Me.gbVracanje = New System.Windows.Forms.GroupBox()
        Me.tbRazlogVracanja = New System.Windows.Forms.TextBox()
        Me.gbZahtevTrazi = New System.Windows.Forms.GroupBox()
        Me.rbZahtevOdobren = New System.Windows.Forms.RadioButton()
        Me.tboxRazlogZahtev = New System.Windows.Forms.TextBox()
        Me.rbZahtevOdbijen = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.gbFilteri = New System.Windows.Forms.GroupBox()
        Me.filtPopisivac = New System.Windows.Forms.ComboBox()
        Me.lblPopisivac = New System.Windows.Forms.Label()
        Me.filtNaseljeee = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.filtPig = New System.Windows.Forms.TextBox()
        Me.llPonisti = New System.Windows.Forms.LinkLabel()
        Me.lblUkupno = New System.Windows.Forms.Label()
        Me.btnRaspodela = New System.Windows.Forms.Button()
        Me.panelRaspodela = New System.Windows.Forms.Panel()
        Me.btnRaspodelaCancel = New System.Windows.Forms.Button()
        Me.btnRaspodelaAA = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnRaspodelaNA = New System.Windows.Forms.Button()
        Me.panelRaspodelaNA = New System.Windows.Forms.Panel()
        Me.cbCekirajSveNA = New System.Windows.Forms.CheckBox()
        Me.btnRaspodelaNACancel = New System.Windows.Forms.Button()
        Me.btnRaspodelaNAOK = New System.Windows.Forms.Button()
        Me.gbGazdinstvaRaspodelaNA = New System.Windows.Forms.GroupBox()
        Me.dgvNA = New System.Windows.Forms.DataGridView()
        Me.gbRaspodelaNA = New System.Windows.Forms.GroupBox()
        Me.btnNastaviNA = New System.Windows.Forms.Button()
        Me.lblRaspodelaAAPoruka = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cbOdKogaNA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbKomeNA = New System.Windows.Forms.ComboBox()
        Me.gbSecurity = New System.Windows.Forms.GroupBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNapomena.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.PanelLegendaDGV1.SuspendLayout()
        CType(Me.pbEU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbStatusi.SuspendLayout()
        Me.panelZahtevZaDoradu.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbVracanje.SuspendLayout()
        Me.gbZahtevTrazi.SuspendLayout()
        Me.gbFilteri.SuspendLayout()
        Me.panelRaspodela.SuspendLayout()
        Me.panelRaspodelaNA.SuspendLayout()
        Me.gbGazdinstvaRaspodelaNA.SuspendLayout()
        CType(Me.dgvNA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRaspodelaNA.SuspendLayout()
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
        Me.panelNapomena.Location = New System.Drawing.Point(1003, 315)
        Me.panelNapomena.Name = "panelNapomena"
        Me.panelNapomena.Size = New System.Drawing.Size(410, 356)
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
        Me.tboxNapomenaNapomena.Location = New System.Drawing.Point(82, 106)
        Me.tboxNapomenaNapomena.MaxLength = 500
        Me.tboxNapomenaNapomena.Multiline = True
        Me.tboxNapomenaNapomena.Name = "tboxNapomenaNapomena"
        Me.tboxNapomenaNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tboxNapomenaNapomena.Size = New System.Drawing.Size(317, 204)
        Me.tboxNapomenaNapomena.TabIndex = 60
        '
        'lblNapomenaRBR
        '
        Me.lblNapomenaRBR.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomenaRBR.Location = New System.Drawing.Point(283, 29)
        Me.lblNapomenaRBR.Name = "lblNapomenaRBR"
        Me.lblNapomenaRBR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNapomenaRBR.Size = New System.Drawing.Size(38, 14)
        Me.lblNapomenaRBR.TabIndex = 10000065
        Me.lblNapomenaRBR.Text = "RBR"
        '
        'lblNapomenaNapomena
        '
        Me.lblNapomenaNapomena.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomenaNapomena.Location = New System.Drawing.Point(2, 106)
        Me.lblNapomenaNapomena.Name = "lblNapomenaNapomena"
        Me.lblNapomenaNapomena.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNapomenaNapomena.Size = New System.Drawing.Size(80, 16)
        Me.lblNapomenaNapomena.TabIndex = 57
        Me.lblNapomenaNapomena.Text = "Napomena"
        '
        'tboxNapomenaAdresa
        '
        Me.tboxNapomenaAdresa.AccessibleName = "CONVERTCIRLAT"
        Me.tboxNapomenaAdresa.Location = New System.Drawing.Point(82, 52)
        Me.tboxNapomenaAdresa.MaxLength = 19
        Me.tboxNapomenaAdresa.Name = "tboxNapomenaAdresa"
        Me.tboxNapomenaAdresa.Size = New System.Drawing.Size(317, 22)
        Me.tboxNapomenaAdresa.TabIndex = 10000064
        '
        'lblNapomenaAdresa
        '
        Me.lblNapomenaAdresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomenaAdresa.Location = New System.Drawing.Point(19, 55)
        Me.lblNapomenaAdresa.Name = "lblNapomenaAdresa"
        Me.lblNapomenaAdresa.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNapomenaAdresa.Size = New System.Drawing.Size(62, 19)
        Me.lblNapomenaAdresa.TabIndex = 10000059
        Me.lblNapomenaAdresa.Text = "Adresa"
        '
        'tboxNapomenaPIG
        '
        Me.tboxNapomenaPIG.AccessibleName = "CONVERTCIRLAT"
        Me.tboxNapomenaPIG.Enabled = False
        Me.tboxNapomenaPIG.Location = New System.Drawing.Point(82, 26)
        Me.tboxNapomenaPIG.MaxLength = 19
        Me.tboxNapomenaPIG.Name = "tboxNapomenaPIG"
        Me.tboxNapomenaPIG.Size = New System.Drawing.Size(194, 22)
        Me.tboxNapomenaPIG.TabIndex = 10000058
        '
        'btnNapomenaCancel
        '
        Me.btnNapomenaCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnNapomenaCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNapomenaCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNapomenaCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNapomenaCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNapomenaCancel.Location = New System.Drawing.Point(204, 322)
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
        Me.btnNapomenaOK.Location = New System.Drawing.Point(309, 322)
        Me.btnNapomenaOK.Name = "btnNapomenaOK"
        Me.btnNapomenaOK.Size = New System.Drawing.Size(90, 24)
        Me.btnNapomenaOK.TabIndex = 65
        Me.btnNapomenaOK.Text = "OK"
        Me.btnNapomenaOK.UseVisualStyleBackColor = False
        '
        'lblKucniBroj
        '
        Me.lblKucniBroj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKucniBroj.Location = New System.Drawing.Point(18, 29)
        Me.lblKucniBroj.Name = "lblKucniBroj"
        Me.lblKucniBroj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblKucniBroj.Size = New System.Drawing.Size(61, 14)
        Me.lblKucniBroj.TabIndex = 51
        Me.lblKucniBroj.Text = "PIG"
        '
        'tboxNapomenaRBR
        '
        Me.tboxNapomenaRBR.AccessibleName = "CONVERTCIRLAT"
        Me.tboxNapomenaRBR.Location = New System.Drawing.Point(330, 26)
        Me.tboxNapomenaRBR.MaxLength = 19
        Me.tboxNapomenaRBR.Name = "tboxNapomenaRBR"
        Me.tboxNapomenaRBR.Size = New System.Drawing.Size(69, 22)
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
        Me.ButtonIzvestaji.Location = New System.Drawing.Point(1159, 36)
        Me.ButtonIzvestaji.Name = "ButtonIzvestaji"
        Me.ButtonIzvestaji.Size = New System.Drawing.Size(227, 26)
        Me.ButtonIzvestaji.TabIndex = 10
        Me.ButtonIzvestaji.TabStop = False
        Me.ButtonIzvestaji.Text = "Izveštaji i dodatne opcije"
        Me.ButtonIzvestaji.UseVisualStyleBackColor = False
        '
        'ButtonLK
        '
        Me.ButtonLK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonLK.BackColor = System.Drawing.Color.Cornsilk
        Me.ButtonLK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLK.Location = New System.Drawing.Point(1165, 144)
        Me.ButtonLK.Name = "ButtonLK"
        Me.ButtonLK.Size = New System.Drawing.Size(195, 22)
        Me.ButtonLK.TabIndex = 1031
        Me.ButtonLK.TabStop = False
        Me.ButtonLK.Text = "LK"
        Me.ButtonLK.UseVisualStyleBackColor = False
        Me.ButtonLK.Visible = False
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
        Me.TabPage1.Size = New System.Drawing.Size(186, 333)
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
        Me.DGV1.Size = New System.Drawing.Size(491, 310)
        Me.DGV1.TabIndex = 350
        Me.DGV1.Visible = False
        '
        'txt1
        '
        Me.txt1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt1.Location = New System.Drawing.Point(7, 7)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(490, 20)
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 213)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(194, 360)
        Me.TabControl1.TabIndex = 1013
        '
        'PanelLegendaDGV1
        '
        Me.PanelLegendaDGV1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelLegendaDGV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLegendaDGV1.Controls.Add(Me.Label11)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox1)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaHouse)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblHouse)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label3)
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
        Me.PanelLegendaDGV1.Controls.Add(Me.Label7)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox5)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label6)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox4)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label5)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox3)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label8)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label9)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label2)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label1)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblPin)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaPin)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaPencil)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblPencil)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label20)
        Me.PanelLegendaDGV1.Location = New System.Drawing.Point(13, 5)
        Me.PanelLegendaDGV1.Name = "PanelLegendaDGV1"
        Me.PanelLegendaDGV1.Size = New System.Drawing.Size(681, 130)
        Me.PanelLegendaDGV1.TabIndex = 1038
        Me.PanelLegendaDGV1.Tag = "NeDiraj"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label11.Location = New System.Drawing.Point(309, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(394, 14)
        Me.Label11.TabIndex = 1084
        Me.Label11.Text = "otvara se prozor za odobravanje/odbijanje zahtev za doradu"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(280, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(30, 26)
        Me.TextBox1.TabIndex = 1081
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "🖐"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LegendaHouse
        '
        Me.LegendaHouse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaHouse.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaHouse.Location = New System.Drawing.Point(11, 48)
        Me.LegendaHouse.Name = "LegendaHouse"
        Me.LegendaHouse.ReadOnly = True
        Me.LegendaHouse.Size = New System.Drawing.Size(30, 26)
        Me.LegendaHouse.TabIndex = 1083
        Me.LegendaHouse.TabStop = False
        Me.LegendaHouse.Text = "🖉"
        Me.LegendaHouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHouse
        '
        Me.lblHouse.AutoSize = True
        Me.lblHouse.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblHouse.Location = New System.Drawing.Point(40, 58)
        Me.lblHouse.Name = "lblHouse"
        Me.lblHouse.Size = New System.Drawing.Size(237, 14)
        Me.lblHouse.TabIndex = 1082
        Me.lblHouse.Text = "otvara se prozor za unos napomene"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(388, 14)
        Me.Label3.TabIndex = 1045
        Me.Label3.Text = "Upitnike koje ste ispravljali ne možete vratiti na doradu!"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label1.Location = New System.Drawing.Point(-4, 81)
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
        Me.lblPin.Location = New System.Drawing.Point(40, 31)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(143, 14)
        Me.lblPin.TabIndex = 1030
        Me.lblPin.Text = "otvara se upitnik (P1)"
        '
        'LegendaPin
        '
        Me.LegendaPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPin.Location = New System.Drawing.Point(10, 19)
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
        Me.LegendaPencil.Location = New System.Drawing.Point(280, 22)
        Me.LegendaPencil.Name = "LegendaPencil"
        Me.LegendaPencil.ReadOnly = True
        Me.LegendaPencil.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPencil.TabIndex = 1021
        Me.LegendaPencil.TabStop = False
        Me.LegendaPencil.Text = "✉"
        Me.LegendaPencil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPencil
        '
        Me.lblPencil.AutoSize = True
        Me.lblPencil.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPencil.Location = New System.Drawing.Point(309, 31)
        Me.lblPencil.Name = "lblPencil"
        Me.lblPencil.Size = New System.Drawing.Size(315, 14)
        Me.lblPencil.TabIndex = 70
        Me.lblPencil.Text = "otvara se prozor za slanje gazdinstva na doradu"
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
        Me.gbStatusi.Controls.Add(Me.rbPlaceni)
        Me.gbStatusi.Controls.Add(Me.rbZaPlacanje)
        Me.gbStatusi.Controls.Add(Me.rbSve)
        Me.gbStatusi.Controls.Add(Me.rbVraceno)
        Me.gbStatusi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbStatusi.Location = New System.Drawing.Point(12, 315)
        Me.gbStatusi.Name = "gbStatusi"
        Me.gbStatusi.Size = New System.Drawing.Size(486, 41)
        Me.gbStatusi.TabIndex = 1040
        Me.gbStatusi.TabStop = False
        Me.gbStatusi.Text = "Statusi"
        '
        'rbPlaceni
        '
        Me.rbPlaceni.AutoSize = True
        Me.rbPlaceni.BackColor = System.Drawing.SystemColors.ControlLight
        Me.rbPlaceni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbPlaceni.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbPlaceni.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbPlaceni.Location = New System.Drawing.Point(159, 18)
        Me.rbPlaceni.Name = "rbPlaceni"
        Me.rbPlaceni.Size = New System.Drawing.Size(123, 17)
        Me.rbPlaceni.TabIndex = 7
        Me.rbPlaceni.TabStop = True
        Me.rbPlaceni.Text = "Predati za isplatu"
        Me.rbPlaceni.UseVisualStyleBackColor = False
        '
        'rbZaPlacanje
        '
        Me.rbZaPlacanje.AutoSize = True
        Me.rbZaPlacanje.BackColor = System.Drawing.Color.Honeydew
        Me.rbZaPlacanje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbZaPlacanje.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbZaPlacanje.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbZaPlacanje.Location = New System.Drawing.Point(11, 18)
        Me.rbZaPlacanje.Name = "rbZaPlacanje"
        Me.rbZaPlacanje.Size = New System.Drawing.Size(142, 17)
        Me.rbZaPlacanje.TabIndex = 6
        Me.rbZaPlacanje.TabStop = True
        Me.rbZaPlacanje.Text = "Čekirani za plaćanje"
        Me.rbZaPlacanje.UseVisualStyleBackColor = False
        '
        'rbSve
        '
        Me.rbSve.AutoSize = True
        Me.rbSve.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbSve.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbSve.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rbSve.Location = New System.Drawing.Point(428, 18)
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
        Me.rbVraceno.Location = New System.Drawing.Point(288, 18)
        Me.rbVraceno.Name = "rbVraceno"
        Me.rbVraceno.Size = New System.Drawing.Size(134, 17)
        Me.rbVraceno.TabIndex = 3
        Me.rbVraceno.TabStop = True
        Me.rbVraceno.Text = "Vraćeno na doradu"
        Me.rbVraceno.UseVisualStyleBackColor = False
        '
        'panelZahtevZaDoradu
        '
        Me.panelZahtevZaDoradu.BackColor = System.Drawing.Color.LightYellow
        Me.panelZahtevZaDoradu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelZahtevZaDoradu.Controls.Add(Me.lblVracanje)
        Me.panelZahtevZaDoradu.Controls.Add(Me.lblZahtev)
        Me.panelZahtevZaDoradu.Controls.Add(Me.Panel3)
        Me.panelZahtevZaDoradu.Controls.Add(Me.btnZahtevCancel)
        Me.panelZahtevZaDoradu.Controls.Add(Me.btnZahtevOK)
        Me.panelZahtevZaDoradu.Controls.Add(Me.gbVracanje)
        Me.panelZahtevZaDoradu.Controls.Add(Me.gbZahtevTrazi)
        Me.panelZahtevZaDoradu.Location = New System.Drawing.Point(230, 402)
        Me.panelZahtevZaDoradu.Name = "panelZahtevZaDoradu"
        Me.panelZahtevZaDoradu.Size = New System.Drawing.Size(708, 338)
        Me.panelZahtevZaDoradu.TabIndex = 1041
        Me.panelZahtevZaDoradu.Visible = False
        '
        'lblVracanje
        '
        Me.lblVracanje.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVracanje.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblVracanje.Location = New System.Drawing.Point(9, 9)
        Me.lblVracanje.Name = "lblVracanje"
        Me.lblVracanje.Size = New System.Drawing.Size(377, 26)
        Me.lblVracanje.TabIndex = 10000075
        Me.lblVracanje.Text = "VRAĆANJE NA DORADU POSLATOG GAZDINSTVA"
        '
        'lblZahtev
        '
        Me.lblZahtev.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZahtev.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblZahtev.Location = New System.Drawing.Point(9, 9)
        Me.lblZahtev.Name = "lblZahtev"
        Me.lblZahtev.Size = New System.Drawing.Size(377, 19)
        Me.lblZahtev.TabIndex = 10000068
        Me.lblZahtev.Text = "ZAHTEV ZA DORADU POSLATOG GAZDINSTVA"
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
        Me.Panel3.Location = New System.Drawing.Point(12, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(684, 39)
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
        Me.tboxZahtevRbr.Location = New System.Drawing.Point(224, 8)
        Me.tboxZahtevRbr.Name = "tboxZahtevRbr"
        Me.tboxZahtevRbr.Size = New System.Drawing.Size(50, 22)
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
        Me.tboxZahtevAdresa.Size = New System.Drawing.Size(337, 22)
        Me.tboxZahtevAdresa.TabIndex = 51
        '
        'tboxZahtevPig
        '
        Me.tboxZahtevPig.Enabled = False
        Me.tboxZahtevPig.Location = New System.Drawing.Point(40, 8)
        Me.tboxZahtevPig.Name = "tboxZahtevPig"
        Me.tboxZahtevPig.Size = New System.Drawing.Size(138, 22)
        Me.tboxZahtevPig.TabIndex = 67
        '
        'btnZahtevCancel
        '
        Me.btnZahtevCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnZahtevCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnZahtevCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnZahtevCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZahtevCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnZahtevCancel.Location = New System.Drawing.Point(495, 300)
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
        Me.btnZahtevOK.Location = New System.Drawing.Point(600, 300)
        Me.btnZahtevOK.Name = "btnZahtevOK"
        Me.btnZahtevOK.Size = New System.Drawing.Size(90, 24)
        Me.btnZahtevOK.TabIndex = 65
        Me.btnZahtevOK.Text = "OK"
        Me.btnZahtevOK.UseVisualStyleBackColor = False
        '
        'gbVracanje
        '
        Me.gbVracanje.Controls.Add(Me.tbRazlogVracanja)
        Me.gbVracanje.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbVracanje.Location = New System.Drawing.Point(12, 89)
        Me.gbVracanje.Name = "gbVracanje"
        Me.gbVracanje.Size = New System.Drawing.Size(684, 205)
        Me.gbVracanje.TabIndex = 10000074
        Me.gbVracanje.TabStop = False
        Me.gbVracanje.Text = "Razlog vraćanja na doradu"
        Me.gbVracanje.Visible = False
        '
        'tbRazlogVracanja
        '
        Me.tbRazlogVracanja.Enabled = False
        Me.tbRazlogVracanja.Location = New System.Drawing.Point(6, 34)
        Me.tbRazlogVracanja.MaxLength = 500
        Me.tbRazlogVracanja.Multiline = True
        Me.tbRazlogVracanja.Name = "tbRazlogVracanja"
        Me.tbRazlogVracanja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbRazlogVracanja.Size = New System.Drawing.Size(672, 165)
        Me.tbRazlogVracanja.TabIndex = 60
        '
        'gbZahtevTrazi
        '
        Me.gbZahtevTrazi.Controls.Add(Me.rbZahtevOdobren)
        Me.gbZahtevTrazi.Controls.Add(Me.tboxRazlogZahtev)
        Me.gbZahtevTrazi.Controls.Add(Me.rbZahtevOdbijen)
        Me.gbZahtevTrazi.Controls.Add(Me.Label22)
        Me.gbZahtevTrazi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbZahtevTrazi.Location = New System.Drawing.Point(12, 89)
        Me.gbZahtevTrazi.Name = "gbZahtevTrazi"
        Me.gbZahtevTrazi.Size = New System.Drawing.Size(684, 205)
        Me.gbZahtevTrazi.TabIndex = 10000073
        Me.gbZahtevTrazi.TabStop = False
        Me.gbZahtevTrazi.Text = "Status zahteva za doradu"
        Me.gbZahtevTrazi.Visible = False
        '
        'rbZahtevOdobren
        '
        Me.rbZahtevOdobren.AutoSize = True
        Me.rbZahtevOdobren.BackColor = System.Drawing.Color.LightYellow
        Me.rbZahtevOdobren.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbZahtevOdobren.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbZahtevOdobren.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbZahtevOdobren.Location = New System.Drawing.Point(18, 21)
        Me.rbZahtevOdobren.Name = "rbZahtevOdobren"
        Me.rbZahtevOdobren.Size = New System.Drawing.Size(145, 18)
        Me.rbZahtevOdobren.TabIndex = 10000071
        Me.rbZahtevOdobren.TabStop = True
        Me.rbZahtevOdobren.Text = "Odobravam zahtev"
        Me.rbZahtevOdobren.UseVisualStyleBackColor = False
        '
        'tboxRazlogZahtev
        '
        Me.tboxRazlogZahtev.Enabled = False
        Me.tboxRazlogZahtev.Location = New System.Drawing.Point(71, 77)
        Me.tboxRazlogZahtev.MaxLength = 500
        Me.tboxRazlogZahtev.Multiline = True
        Me.tboxRazlogZahtev.Name = "tboxRazlogZahtev"
        Me.tboxRazlogZahtev.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tboxRazlogZahtev.Size = New System.Drawing.Size(607, 122)
        Me.tboxRazlogZahtev.TabIndex = 60
        '
        'rbZahtevOdbijen
        '
        Me.rbZahtevOdbijen.AutoSize = True
        Me.rbZahtevOdbijen.BackColor = System.Drawing.Color.LightYellow
        Me.rbZahtevOdbijen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbZahtevOdbijen.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rbZahtevOdbijen.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbZahtevOdbijen.Location = New System.Drawing.Point(18, 43)
        Me.rbZahtevOdbijen.Name = "rbZahtevOdbijen"
        Me.rbZahtevOdbijen.Size = New System.Drawing.Size(164, 18)
        Me.rbZahtevOdbijen.TabIndex = 10000072
        Me.rbZahtevOdbijen.TabStop = True
        Me.rbZahtevOdbijen.Text = "Ne odobravam zahtev"
        Me.rbZahtevOdbijen.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(14, 76)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label22.Size = New System.Drawing.Size(54, 17)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = "Razlog"
        '
        'gbFilteri
        '
        Me.gbFilteri.Controls.Add(Me.filtPopisivac)
        Me.gbFilteri.Controls.Add(Me.lblPopisivac)
        Me.gbFilteri.Controls.Add(Me.filtNaseljeee)
        Me.gbFilteri.Controls.Add(Me.Label23)
        Me.gbFilteri.Controls.Add(Me.Label19)
        Me.gbFilteri.Controls.Add(Me.filtPig)
        Me.gbFilteri.Controls.Add(Me.llPonisti)
        Me.gbFilteri.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gbFilteri.Location = New System.Drawing.Point(271, 145)
        Me.gbFilteri.Name = "gbFilteri"
        Me.gbFilteri.Size = New System.Drawing.Size(800, 42)
        Me.gbFilteri.TabIndex = 1042
        Me.gbFilteri.TabStop = False
        Me.gbFilteri.Text = "Filteri"
        '
        'filtPopisivac
        '
        Me.filtPopisivac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.filtPopisivac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.filtPopisivac.BackColor = System.Drawing.SystemColors.Window
        Me.filtPopisivac.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtPopisivac.FormattingEnabled = True
        Me.filtPopisivac.Location = New System.Drawing.Point(102, 16)
        Me.filtPopisivac.Name = "filtPopisivac"
        Me.filtPopisivac.Size = New System.Drawing.Size(295, 22)
        Me.filtPopisivac.TabIndex = 1045
        '
        'lblPopisivac
        '
        Me.lblPopisivac.AutoSize = True
        Me.lblPopisivac.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPopisivac.Location = New System.Drawing.Point(31, 18)
        Me.lblPopisivac.Name = "lblPopisivac"
        Me.lblPopisivac.Size = New System.Drawing.Size(65, 14)
        Me.lblPopisivac.TabIndex = 1045
        Me.lblPopisivac.Text = "Popisivač"
        '
        'filtNaseljeee
        '
        Me.filtNaseljeee.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtNaseljeee.Location = New System.Drawing.Point(632, 15)
        Me.filtNaseljeee.Name = "filtNaseljeee"
        Me.filtNaseljeee.Size = New System.Drawing.Size(127, 22)
        Me.filtNaseljeee.TabIndex = 100
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(573, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 14)
        Me.Label23.TabIndex = 98
        Me.Label23.Text = "Naselje"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(404, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 14)
        Me.Label19.TabIndex = 97
        Me.Label19.Text = "PIG"
        '
        'filtPig
        '
        Me.filtPig.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filtPig.Location = New System.Drawing.Point(438, 15)
        Me.filtPig.Name = "filtPig"
        Me.filtPig.Size = New System.Drawing.Size(128, 22)
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
        Me.llPonisti.Location = New System.Drawing.Point(765, 10)
        Me.llPonisti.Margin = New System.Windows.Forms.Padding(0)
        Me.llPonisti.Name = "llPonisti"
        Me.llPonisti.Size = New System.Drawing.Size(29, 25)
        Me.llPonisti.TabIndex = 1043
        Me.llPonisti.TabStop = True
        Me.llPonisti.Text = "⛝"
        Me.llPonisti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.llPonisti.VisitedLinkColor = System.Drawing.Color.Black
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
        'btnRaspodela
        '
        Me.btnRaspodela.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnRaspodela.BackColor = System.Drawing.SystemColors.Control
        Me.btnRaspodela.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRaspodela.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaspodela.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaspodela.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRaspodela.Location = New System.Drawing.Point(1159, 68)
        Me.btnRaspodela.Name = "btnRaspodela"
        Me.btnRaspodela.Size = New System.Drawing.Size(227, 26)
        Me.btnRaspodela.TabIndex = 1045
        Me.btnRaspodela.TabStop = False
        Me.btnRaspodela.Text = "Preraspodela materijala"
        Me.btnRaspodela.UseVisualStyleBackColor = False
        '
        'panelRaspodela
        '
        Me.panelRaspodela.BackColor = System.Drawing.Color.LightYellow
        Me.panelRaspodela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRaspodela.Controls.Add(Me.btnRaspodelaCancel)
        Me.panelRaspodela.Controls.Add(Me.btnRaspodelaAA)
        Me.panelRaspodela.Controls.Add(Me.Label21)
        Me.panelRaspodela.Controls.Add(Me.btnRaspodelaNA)
        Me.panelRaspodela.Location = New System.Drawing.Point(286, 202)
        Me.panelRaspodela.Name = "panelRaspodela"
        Me.panelRaspodela.Size = New System.Drawing.Size(488, 253)
        Me.panelRaspodela.TabIndex = 1046
        Me.panelRaspodela.Visible = False
        '
        'btnRaspodelaCancel
        '
        Me.btnRaspodelaCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnRaspodelaCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRaspodelaCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaspodelaCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaspodelaCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRaspodelaCancel.Location = New System.Drawing.Point(393, 222)
        Me.btnRaspodelaCancel.Name = "btnRaspodelaCancel"
        Me.btnRaspodelaCancel.Size = New System.Drawing.Size(90, 24)
        Me.btnRaspodelaCancel.TabIndex = 10000077
        Me.btnRaspodelaCancel.Text = "Zatvori"
        Me.btnRaspodelaCancel.UseVisualStyleBackColor = False
        '
        'btnRaspodelaAA
        '
        Me.btnRaspodelaAA.BackColor = System.Drawing.SystemColors.Control
        Me.btnRaspodelaAA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRaspodelaAA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaspodelaAA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaspodelaAA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRaspodelaAA.Location = New System.Drawing.Point(22, 144)
        Me.btnRaspodelaAA.Name = "btnRaspodelaAA"
        Me.btnRaspodelaAA.Size = New System.Drawing.Size(445, 63)
        Me.btnRaspodelaAA.TabIndex = 10000076
        Me.btnRaspodelaAA.Text = "Raspodela materijala od aktivnog popisivača aktivnom popisivaču"
        Me.btnRaspodelaAA.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label21.Location = New System.Drawing.Point(9, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(202, 19)
        Me.Label21.TabIndex = 10000068
        Me.Label21.Text = "RASPODELA MATERIJALA"
        '
        'btnRaspodelaNA
        '
        Me.btnRaspodelaNA.BackColor = System.Drawing.SystemColors.Control
        Me.btnRaspodelaNA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRaspodelaNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaspodelaNA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaspodelaNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRaspodelaNA.Location = New System.Drawing.Point(22, 61)
        Me.btnRaspodelaNA.Name = "btnRaspodelaNA"
        Me.btnRaspodelaNA.Size = New System.Drawing.Size(445, 63)
        Me.btnRaspodelaNA.TabIndex = 70
        Me.btnRaspodelaNA.Text = "Raspodela materijala od neaktivnog popisivača aktivnom popisivaču"
        Me.btnRaspodelaNA.UseVisualStyleBackColor = False
        '
        'panelRaspodelaNA
        '
        Me.panelRaspodelaNA.BackColor = System.Drawing.Color.LightYellow
        Me.panelRaspodelaNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelRaspodelaNA.Controls.Add(Me.cbCekirajSveNA)
        Me.panelRaspodelaNA.Controls.Add(Me.btnRaspodelaNACancel)
        Me.panelRaspodelaNA.Controls.Add(Me.btnRaspodelaNAOK)
        Me.panelRaspodelaNA.Controls.Add(Me.gbGazdinstvaRaspodelaNA)
        Me.panelRaspodelaNA.Controls.Add(Me.gbRaspodelaNA)
        Me.panelRaspodelaNA.Location = New System.Drawing.Point(257, 381)
        Me.panelRaspodelaNA.Name = "panelRaspodelaNA"
        Me.panelRaspodelaNA.Size = New System.Drawing.Size(1001, 597)
        Me.panelRaspodelaNA.TabIndex = 1047
        Me.panelRaspodelaNA.Visible = False
        '
        'cbCekirajSveNA
        '
        Me.cbCekirajSveNA.AutoSize = True
        Me.cbCekirajSveNA.Location = New System.Drawing.Point(751, 156)
        Me.cbCekirajSveNA.Name = "cbCekirajSveNA"
        Me.cbCekirajSveNA.Size = New System.Drawing.Size(238, 18)
        Me.cbCekirajSveNA.TabIndex = 10000079
        Me.cbCekirajSveNA.Text = "Želim da obeležim sva gazdinstva"
        Me.cbCekirajSveNA.UseVisualStyleBackColor = True
        Me.cbCekirajSveNA.Visible = False
        '
        'btnRaspodelaNACancel
        '
        Me.btnRaspodelaNACancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnRaspodelaNACancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRaspodelaNACancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaspodelaNACancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaspodelaNACancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRaspodelaNACancel.Location = New System.Drawing.Point(699, 556)
        Me.btnRaspodelaNACancel.Name = "btnRaspodelaNACancel"
        Me.btnRaspodelaNACancel.Size = New System.Drawing.Size(144, 28)
        Me.btnRaspodelaNACancel.TabIndex = 10000078
        Me.btnRaspodelaNACancel.Text = "CANCEL"
        Me.btnRaspodelaNACancel.UseVisualStyleBackColor = False
        '
        'btnRaspodelaNAOK
        '
        Me.btnRaspodelaNAOK.BackColor = System.Drawing.SystemColors.Control
        Me.btnRaspodelaNAOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRaspodelaNAOK.Enabled = False
        Me.btnRaspodelaNAOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRaspodelaNAOK.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaspodelaNAOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnRaspodelaNAOK.Location = New System.Drawing.Point(849, 556)
        Me.btnRaspodelaNAOK.Name = "btnRaspodelaNAOK"
        Me.btnRaspodelaNAOK.Size = New System.Drawing.Size(144, 28)
        Me.btnRaspodelaNAOK.TabIndex = 10000077
        Me.btnRaspodelaNAOK.Text = "OK"
        Me.btnRaspodelaNAOK.UseVisualStyleBackColor = False
        '
        'gbGazdinstvaRaspodelaNA
        '
        Me.gbGazdinstvaRaspodelaNA.Controls.Add(Me.dgvNA)
        Me.gbGazdinstvaRaspodelaNA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbGazdinstvaRaspodelaNA.ForeColor = System.Drawing.Color.Black
        Me.gbGazdinstvaRaspodelaNA.Location = New System.Drawing.Point(13, 178)
        Me.gbGazdinstvaRaspodelaNA.Name = "gbGazdinstvaRaspodelaNA"
        Me.gbGazdinstvaRaspodelaNA.Size = New System.Drawing.Size(983, 371)
        Me.gbGazdinstvaRaspodelaNA.TabIndex = 10000072
        Me.gbGazdinstvaRaspodelaNA.TabStop = False
        Me.gbGazdinstvaRaspodelaNA.Text = "Obeležite gazdinstva koja žeilte da prebacite, a zatim kliknite na dugme OK"
        Me.gbGazdinstvaRaspodelaNA.Visible = False
        '
        'dgvNA
        '
        Me.dgvNA.AllowUserToAddRows = False
        Me.dgvNA.AllowUserToDeleteRows = False
        Me.dgvNA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvNA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvNA.Location = New System.Drawing.Point(3, 18)
        Me.dgvNA.MultiSelect = False
        Me.dgvNA.Name = "dgvNA"
        Me.dgvNA.ReadOnly = True
        Me.dgvNA.RowHeadersWidth = 30
        Me.dgvNA.Size = New System.Drawing.Size(977, 350)
        Me.dgvNA.TabIndex = 351
        '
        'gbRaspodelaNA
        '
        Me.gbRaspodelaNA.Controls.Add(Me.btnNastaviNA)
        Me.gbRaspodelaNA.Controls.Add(Me.lblRaspodelaAAPoruka)
        Me.gbRaspodelaNA.Controls.Add(Me.Label24)
        Me.gbRaspodelaNA.Controls.Add(Me.cbOdKogaNA)
        Me.gbRaspodelaNA.Controls.Add(Me.Label4)
        Me.gbRaspodelaNA.Controls.Add(Me.cbKomeNA)
        Me.gbRaspodelaNA.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbRaspodelaNA.ForeColor = System.Drawing.Color.DarkGreen
        Me.gbRaspodelaNA.Location = New System.Drawing.Point(13, 12)
        Me.gbRaspodelaNA.Name = "gbRaspodelaNA"
        Me.gbRaspodelaNA.Size = New System.Drawing.Size(980, 137)
        Me.gbRaspodelaNA.TabIndex = 10000071
        Me.gbRaspodelaNA.TabStop = False
        Me.gbRaspodelaNA.Text = "RASPODELA MATERIJALA OD NEAKTIVNOG POPISIVAČA AKTIVNOM POPISIVAČU"
        '
        'btnNastaviNA
        '
        Me.btnNastaviNA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNastaviNA.BackColor = System.Drawing.SystemColors.Control
        Me.btnNastaviNA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNastaviNA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNastaviNA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNastaviNA.ForeColor = System.Drawing.Color.Black
        Me.btnNastaviNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnNastaviNA.Location = New System.Drawing.Point(870, 109)
        Me.btnNastaviNA.Name = "btnNastaviNA"
        Me.btnNastaviNA.Size = New System.Drawing.Size(104, 24)
        Me.btnNastaviNA.TabIndex = 10000072
        Me.btnNastaviNA.Text = "Nastavi"
        Me.btnNastaviNA.UseVisualStyleBackColor = False
        '
        'lblRaspodelaAAPoruka
        '
        Me.lblRaspodelaAAPoruka.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaspodelaAAPoruka.ForeColor = System.Drawing.Color.Maroon
        Me.lblRaspodelaAAPoruka.Location = New System.Drawing.Point(5, 114)
        Me.lblRaspodelaAAPoruka.Name = "lblRaspodelaAAPoruka"
        Me.lblRaspodelaAAPoruka.Size = New System.Drawing.Size(878, 19)
        Me.lblRaspodelaAAPoruka.TabIndex = 10000073
        Me.lblRaspodelaAAPoruka.Text = "Potrebno je da se prvo sinhronizuje popisivač od kog se oduzima materijal, a zati" &
    "m popisivač kome se dodeljuje materijal!"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(362, 19)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(271, 19)
        Me.Label24.TabIndex = 10000071
        Me.Label24.Text = "Popisivač kom se daje materijal"
        '
        'cbOdKogaNA
        '
        Me.cbOdKogaNA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbOdKogaNA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbOdKogaNA.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbOdKogaNA.FormattingEnabled = True
        Me.cbOdKogaNA.Location = New System.Drawing.Point(6, 48)
        Me.cbOdKogaNA.Name = "cbOdKogaNA"
        Me.cbOdKogaNA.Size = New System.Drawing.Size(268, 22)
        Me.cbOdKogaNA.TabIndex = 10000069
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 19)
        Me.Label4.TabIndex = 10000068
        Me.Label4.Text = "Popisivač od kog se oduzima materijal"
        '
        'cbKomeNA
        '
        Me.cbKomeNA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbKomeNA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbKomeNA.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.cbKomeNA.FormattingEnabled = True
        Me.cbKomeNA.Location = New System.Drawing.Point(365, 48)
        Me.cbKomeNA.Name = "cbKomeNA"
        Me.cbKomeNA.Size = New System.Drawing.Size(268, 22)
        Me.cbKomeNA.TabIndex = 10000070
        '
        'gbSecurity
        '
        Me.gbSecurity.BackColor = System.Drawing.Color.LightGray
        Me.gbSecurity.Font = New System.Drawing.Font("Verdana", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSecurity.ForeColor = System.Drawing.Color.DarkBlue
        Me.gbSecurity.Location = New System.Drawing.Point(137, 601)
        Me.gbSecurity.Name = "gbSecurity"
        Me.gbSecurity.Size = New System.Drawing.Size(920, 90)
        Me.gbSecurity.TabIndex = 1048
        Me.gbSecurity.TabStop = False
        Me.gbSecurity.Text = "                                     Security checking ... please wait ...       " &
    "                                              "
        Me.gbSecurity.Visible = False
        '
        'FormPpoljoKon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoScroll = False
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbSecurity)
        Me.Controls.Add(Me.panelRaspodelaNA)
        Me.Controls.Add(Me.panelRaspodela)
        Me.Controls.Add(Me.btnRaspodela)
        Me.Controls.Add(Me.lblUkupno)
        Me.Controls.Add(Me.gbFilteri)
        Me.Controls.Add(Me.panelZahtevZaDoradu)
        Me.Controls.Add(Me.gbStatusi)
        Me.Controls.Add(Me.pbEU)
        Me.Controls.Add(Me.PanelLegendaDGV1)
        Me.Controls.Add(Me.ButtonLK)
        Me.Controls.Add(Me.ButtonIzvestaji)
        Me.Controls.Add(Me.ButtonIzlaz)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.panelNapomena)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        
        Me.Name = "FormPpoljoKon"
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
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbVracanje.ResumeLayout(False)
        Me.gbVracanje.PerformLayout()
        Me.gbZahtevTrazi.ResumeLayout(False)
        Me.gbZahtevTrazi.PerformLayout()
        Me.gbFilteri.ResumeLayout(False)
        Me.gbFilteri.PerformLayout()
        Me.panelRaspodela.ResumeLayout(False)
        Me.panelRaspodelaNA.ResumeLayout(False)
        Me.panelRaspodelaNA.PerformLayout()
        Me.gbGazdinstvaRaspodelaNA.ResumeLayout(False)
        CType(Me.dgvNA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRaspodelaNA.ResumeLayout(False)
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


    Dim kosam As String
    Dim kojiadresar As String
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

        Me.kosam = kosam
        kojiadresar = "Adresar" + kosam.Trim.Substring(1, 2)
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

        filtPopisivac.Name = "filtPopisivac"
        filtPopisivac.DropDownWidth = 300
        filtPopisivac.Visible = False
        Call popunicbo(filtPopisivac, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' order by 1", Me.DBConnectionString, False, False, True, False)
        filtPopisivac.TabStop = False
        AddHandler filtPopisivac.SelectedIndexChanged, AddressOf comboboxpopisivac_Changed
        filtPopisivac.Text = "*"

        cbOdKogaNA.Name = "cbOdKogaNA"
        cbOdKogaNA.DropDownWidth = 100
        cbOdKogaNA.Visible = True
        Call popunicbo(cbOdKogaNA, "select distinct top 0  Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' order by 1", Me.DBConnectionString, False, False, True, False)
        cbOdKogaNA.TabStop = False
        cbOdKogaNA.BringToFront()
        AddHandler cbOdKogaNA.SelectedIndexChanged, AddressOf cbOdKogaNA_Changed
        cbOdKogaNA.Text = ""

        cbKomeNA.Name = "cbKomeNA"
        cbKomeNA.DropDownWidth = 100
        cbKomeNA.Visible = True
        Call popunicbo(cbKomeNA, "select distinct top 0  Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' order by 1", Me.DBConnectionString, False, False, True, False)
        cbKomeNA.TabStop = False
        cbKomeNA.BringToFront()
        'AddHandler cbKomeNA.SelectedIndexChanged, AddressOf cbOdKogaNA_Changed
        cbKomeNA.Text = ""


        Dim filterStatus As String = ""
        If rbPlaceni.Checked = True Then
            filterStatus = "PLACENI"
        ElseIf rbZaPlacanje.Checked = True Then
            filterStatus = "ZAPLACANJE"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If

        Call SetLang()
        refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)

        Call srediGridView222()

    End Sub

    Private Sub comboboxpopisivac_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DirectCast(sender, ComboBox).Text <> "" Then
            If DGV1.Visible = True Then

                Dim filterStatus As String = ""
                If rbPlaceni.Checked = True Then
                    filterStatus = "PLACENI"
                ElseIf rbZaPlacanje.Checked = True Then
                    filterStatus = "ZAPLACANJE"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)

                If DGV1.Rows.Count > 0 Then
                    DGV1.Focus()
                    DGV1.ClearSelection()
                    DGV1.Rows(0).Selected = True
                End If
            End If
        End If

    End Sub

    Private Sub cbOdKogaNA_Changed(ByVal sender As Object, ByVal e As EventArgs)

        cbKomeNA.SelectedValue = ""
        cbKomeNA.SelectedText = ""
        cbKomeNA.Text = ""

        Dim pom As String = ""

        If cbOdKogaNA.SelectedValue Is Nothing Then
            pom = ""
        Else
            pom = cbOdKogaNA.SelectedValue.ToString.Trim
        End If

        Dim aktivan As Integer = -1
        If KojaRaspodela = "AA" Then
            aktivan = 1
        ElseIf KojaRaspodela = "NA" Then
            aktivan = 0
        End If

        Call popunicbo(cbKomeNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po v where OpstinskiKoor=N'" + kosam + "' and anketar<>N'" + pom + "'" + nvrd +
                                 " and exists (select * from imtrep.[dbo].[vPP23_VezaOKPOP_IBbroj] x where isnull(odustao,0)=0 and sifraok='" + kosam + "' and v.anketar=x.sifra) order by 1", Me.DBConnectionString, False, False, True, False) 'OLJA

        cbKomeNA.TabStop = False

        'If DirectCast(sender, ComboBox).Text <> "" Then
        '    If DGV1.Visible = True Then

        '        Dim filterStatus As String = ""
        '        If rbPlaceni.Checked = True Then
        '            filterStatus = "PLACENI"
        '        ElseIf rbZaPlacanje.Checked = True Then
        '            filterStatus = "ZAPLACANJE"
        '        ElseIf rbVraceno.Checked = True Then
        '            filterStatus = "VRACENO"
        '        ElseIf rbSve.Checked = True Then
        '            filterStatus = "SVE"
        '        End If

        '        refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)

        '        If DGV1.Rows.Count > 0 Then
        '            DGV1.Focus()
        '            DGV1.ClearSelection()
        '            DGV1.Rows(0).Selected = True
        '        End If
        '    End If
        'End If

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


    End Sub

    Private Sub filterTextBoxDGV1_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DGV1.Visible = True Then
            Dim filterStatus As String = ""
            If rbPlaceni.Checked = True Then
                filterStatus = "PLACENI"
            ElseIf rbZaPlacanje.Checked = True Then
                filterStatus = "ZAPLACANJE"
            ElseIf rbVraceno.Checked = True Then
                filterStatus = "VRACENO"
            ElseIf rbSve.Checked = True Then
                filterStatus = "SVE"
            End If
            refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)
        End If
        DirectCast(sender, TextBox).Focus()

    End Sub

    Private Sub FormDnevnikAnketiranja_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call PreVentFlicker()
        'Me.WindowState = FormWindowState.Maximized

        'TabControl1.Location = New Point(Me.ButtonUnosNovogKBR.Location.X, Me.ButtonUnosNovogKBR.Location.Y + ButtonUnosNovogKBR.Height + 10)
        TabControl1.Width = Me.Width - 30  'Me.Width - 30
        TabControl1.Height = (Screen.PrimaryScreen.WorkingArea.Height - 260)

        EnableDoubleBuffered(DGV1)


        srediGridView222()
        'Me.PanelZakazivanje.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - PanelZakazivanje.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - PanelZakazivanje.Height / 2)
        Me.panelNapomena.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panelNapomena.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panelNapomena.Height / 2)
        Me.panelZahtevZaDoradu.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panelZahtevZaDoradu.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panelZahtevZaDoradu.Height / 2)
        'PanelRegBrMP.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - PanelRegBrMP.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - PanelRegBrMP.Height / 2)
        Me.panelRaspodela.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panelRaspodela.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panelRaspodela.Height / 2)
        Me.panelRaspodelaNA.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - panelRaspodelaNA.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - panelRaspodelaNA.Height / 2)
        Me.gbSecurity.Location = New Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - gbSecurity.Width / 2, Screen.PrimaryScreen.WorkingArea.Height / 2 - gbSecurity.Height / 2)

        ButtonIzlaz.Location = New Point(Me.Width - 25 - ButtonIzlaz.Width, ButtonIzlaz.Location.Y)
        ButtonIzvestaji.Location = New Point(ButtonIzlaz.Location.X, ButtonIzlaz.Location.Y + ButtonIzlaz.Height + 5)
        btnRaspodela.Location = New Point(ButtonIzvestaji.Location.X, ButtonIzvestaji.Location.Y + ButtonIzvestaji.Height + 5)
        'ButtonIzvestaji.Location = New Point(Me.Width - 25 - ButtonIzlaz.Width, ButtonIzvestaji.Location.Y)
        'btnPutniTroskovi.Location = New Point(Me.Width - 25 - ButtonIzvestaji.Width, btnPutniTroskovi.Location.Y)
        'btnRegBrMP.Location = New Point(Me.Width - 25 - ButtonIzlaz.Width, btnRegBrMP.Location.Y)
        pbEU.Location = New Point(Me.Width - 25 - ButtonIzlaz.Width - 25 - pbEU.Width, ButtonIzlaz.Location.Y)
        SetCueText(filtNaseljeee, "🔎 ")
        SetCueText(filtPig, "🔎 ")

        gbStatusi.Location = New Point(gbStatusi.Location.X, PanelLegendaDGV1.Location.Y + PanelLegendaDGV1.Height + 30)
        gbFilteri.Location = New Point(gbStatusi.Location.X + gbStatusi.Width + 10, gbStatusi.Location.Y)

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

        If Not filtPopisivac Is Nothing AndAlso Not DGV1 Is Nothing Then

            filtPopisivac.BringToFront()
            'filtPig.Width = DGV1.Columns("PIG").Width
            'filtPig.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width, DGV1.ColumnHeadersHeight - filtPig.Height - 1)
            'filtPig.AccessibleName = filtPig.Location.X
            filtPopisivac.Visible = True
        End If


        'If Not filtDatumZakazan Is Nothing AndAlso Not DGV1 Is Nothing Then
        '    'filtDatumZakazan.Width = DGV1.Columns("ZakazanoDatum").Width
        '    'filtDatumZakazan.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width + DGV1.Columns("PIG").Width + DGV1.Columns("rbr").Width + DGV1.Columns("ImePrezime").Width _
        '    '+ DGV1.Columns("Nazivnaselja").Width + DGV1.Columns("Ulica").Width + DGV1.Columns("Kbr").Width + DGV1.Columns("Tel").Width + DGV1.Columns("Prazno0").Width _
        '    '+ DGV1.Columns("Zakazivanje").Width + DGV1.Columns("Ishod").Width + DGV1.Columns("Prazno0").Width + DGV1.Columns("PoglOpstiPodaci").Width + DGV1.Columns("PoglZemljiste").Width _
        '    '+ DGV1.Columns("PoglVocnjaciVinogradi").Width + DGV1.Columns("PoglStoka").Width + DGV1.Columns("PoglRadnaSnaga").Width + DGV1.Columns("PoglNavodnjavanje").Width + DGV1.Columns("PoglDjubrivo").Width _
        '    '+ DGV1.Columns("PoglNacinDrzanjaStoke").Width + DGV1.Columns("PoglMehanizacija").Width + DGV1.Columns("PoglObrada").Width + DGV1.Columns("PoglOstaliPodaci").Width + DGV1.Columns("PraznoB").Width _
        '    '+ DGV1.Columns("UzorakVV").Width + DGV1.Columns("praznoC").Width, DGV1.ColumnHeadersHeight - filtNaseljeee.Height - 1)
        '    filtDatumZakazan.Visible = True
        'End If



    End Sub

    Sub pZahVisible(ByVal verzija As String)
        Me.panelZahtevZaDoradu.BringToFront()

        If verzija = "ZAHTEV" Then
            lblZahtev.Visible = True
            lblVracanje.Visible = False
            gbVracanje.Visible = False
            gbZahtevTrazi.Visible = True
            tbRazlogVracanja.Enabled = False
            'tboxRazlogZahtev.Enabled = True
            gbZahtevTrazi.BringToFront()
            rbZahtevOdobren.Focus()
        Else
            lblZahtev.Visible = False
            lblVracanje.Visible = True
            gbZahtevTrazi.Visible = False
            gbVracanje.Visible = True
            tbRazlogVracanja.Enabled = True
            tboxRazlogZahtev.Enabled = False
            gbVracanje.BringToFront()
            tbRazlogVracanja.Focus()
        End If

        Me.panelZahtevZaDoradu.Visible = True
        Call samoja(panelZahtevZaDoradu)

        'rbZahtevOdobren.Focus()
    End Sub
    Sub pZahNonVisible()

        Call nesamoja(panelZahtevZaDoradu)
        Me.panelZahtevZaDoradu.Visible = False
        tboxZahtevPig.Text = ""
        tboxZahtevRbr.Text = ""
        tboxZahtevAdresa.Text = ""
        tboxRazlogZahtev.Text = ""
        tbRazlogVracanja.Text = ""
        tbRazlogVracanja.Enabled = False
        tboxRazlogZahtev.Enabled = False
        rbZahtevOdobren.Checked = False
        rbZahtevOdbijen.Checked = False
    End Sub


    Sub pRaspodelaVisible()
        Me.panelRaspodela.BringToFront()

        Me.panelRaspodela.Visible = True
        Call samoja(panelRaspodela)

        'rbZahtevOdobren.Focus()
    End Sub
    Sub pRaspodelaNonVisible()

        Call nesamoja(panelRaspodela)
        lblRaspodelaAAPoruka.Visible = False
        Me.panelRaspodela.Visible = False

    End Sub

    Sub pRaspodelaNAVisible(ByVal AANA As String)
        cbCekirajSveNA.Visible = False
        cbCekirajSveNA.Checked = False
        'cbCekirajSveNA.Enabled = True
        KojaRaspodela = AANA
        pRaspodelaNonVisible()
        Me.panelRaspodelaNA.BringToFront()
        cbKomeNA.SelectedValue = ""
        cbKomeNA.SelectedText = ""
        cbKomeNA.Text = ""

        cbOdKogaNA.SelectedValue = ""
        cbOdKogaNA.SelectedText = ""
        cbOdKogaNA.Text = ""

        'Dim aktivan As Integer = -1
        'If KojaRaspodela = "AA" Then
        '    aktivan = 1
        'ElseIf KojaRaspodela = "NA" Then
        '    aktivan = 0
        'End If
        Dim pom As String = ""
        If cbOdKogaNA.SelectedValue Is Nothing Then
            pom = ""
        Else
            pom = cbOdKogaNA.SelectedValue.ToString.Trim
        End If


        If AANA = "NA" Then
            lblRaspodelaAAPoruka.Visible = False
            gbRaspodelaNA.Text = "RASPODELA MATERIJALA OD NEAKTIVNOG POPISIVAČA AKTIVNOM POPISIVAČU"
            Call popunicbo(cbOdKogaNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po v where OpstinskiKoor=N'" + kosam + "' and anketar<>N'" + pom + "'" + nvrd +
                                       " and exists (select * from imtrep.[dbo].[vPP23_VezaOKPOP_IBbroj] x where isnull(odustao,0)=1 and sifraok='" + kosam + "' and v.anketar=x.sifra) order by 1", Me.DBConnectionString, False, False, True, False) 'OLJA
        ElseIf AANA = "AA" Then
            lblRaspodelaAAPoruka.Visible = True
            gbRaspodelaNA.Text = "RASPODELA MATERIJALA OD AKTIVNOG POPISIVAČA AKTIVNOM POPISIVAČU"
            Call popunicbo(cbOdKogaNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po v where OpstinskiKoor=N'" + kosam + "' " + nvrd +
                                       " and exists (select * from imtrep.[dbo].[vPP23_VezaOKPOP_IBbroj] x where isnull(odustao,0)=0 and sifraok='" + kosam + "' and v.anketar=x.sifra) order by 1", Me.DBConnectionString, False, False, True, False) 'OLJA
        End If

        cbKomeNA.TabStop = False

        Call popunicbo(cbKomeNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po v where OpstinskiKoor=N'" + kosam + "' " + nvrd +
                                 " and exists (select * from imtrep.[dbo].[vPP23_VezaOKPOP_IBbroj] x where isnull(odustao,0)=0 and sifraok='" + kosam + "' and v.anketar=x.sifra) order by 1", Me.DBConnectionString, False, False, True, False) 'OLJA
        cbKomeNA.TabStop = False

        gbRaspodelaNA.Visible = True
        'gbRaspodelaNA.Enabled = True
        enablegbRaspodela()

        gbGazdinstvaRaspodelaNA.Visible = False

        Me.panelRaspodelaNA.Visible = True
        Call samoja(panelRaspodelaNA)

        'rbZahtevOdobren.Focus()
    End Sub

    Sub disablegbRaspodela()
        cbOdKogaNA.Enabled = False
        cbKomeNA.Enabled = False
        btnNastaviNA.Enabled = False
    End Sub

    Sub enablegbRaspodela()
        cbOdKogaNA.Enabled = True
        cbKomeNA.Enabled = True
        btnNastaviNA.Enabled = True
    End Sub

    Sub pRaspodelaNANonVisible()

        Call nesamoja(panelRaspodelaNA)
        Me.panelRaspodelaNA.Visible = False
        pRaspodelaVisible()

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

    'Sub pZakazivanjeStanaVisible()
    '    txtPIG.Text = ""
    '    txtRBR.Text = ""
    '    dtpDatumDolaska.Text = ""
    '    rb1.Checked = False
    '    rb2.Checked = False
    '    rb4.Checked = False
    '    rb6.Checked = False
    '    rb7.Checked = False
    '    dtpZakazanoDatum.Text = ""
    '    dtpZakazanoVreme.Text = ""
    '    txtKontaktOsoba.Text = ""
    '    txtBrojTelefona.Text = ""
    '    txtIshodNapomena.Text = ""
    '    Me.PanelZakazivanje.BringToFront()
    '    Me.PanelZakazivanje.Visible = True
    '    Call samoja(PanelZakazivanje)
    '    dtpDatumDolaska.Focus()
    'End Sub

    'Sub pZakazivanjeStanaNonVisible()

    '    Call nesamoja(PanelZakazivanje)
    '    Me.PanelZakazivanje.Visible = False

    '    txtPIG.Text = ""
    '    txtRBR.Text = ""
    '    'ishodi  'cb1-cb7
    '    rb1.Checked = False
    '    rb2.Checked = False
    '    rb4.Checked = False
    '    rb6.Checked = False
    '    rb7.Checked = False
    '    p2.Visible = False
    '    dtpZakazanoDatum.Text = ""
    '    dtpZakazanoVreme.Text = ""
    '    txtKontaktOsoba.Text = ""
    '    txtBrojTelefona.Text = ""
    '    txtIshodNapomena.Text = ""
    'End Sub



    'Sub Promena2(ByVal selectedRow As Integer)
    '    DGV1.ClearSelection()
    '    DGV1.Rows(selectedRow).Selected = True

    '    Call pZakazivanjeStanaNonVisible()

    '    cbPonistiZak.Visible = False
    '    cbPonistiZak.Checked = False
    '    Dim si As Integer = DGV1.SelectedRows(0).Index
    '    Call pZakazivanjeStanaVisible()
    '    PanelZakazivanje.Tag = selectedRow
    '    p1.Enabled = False

    '    txtAdresa.Text = DGV1.Rows(si).Cells(DGV1.Columns("ulica").Index).Value.ToString + " " + DGV1.Rows(si).Cells(DGV1.Columns("kbr").Index).Value.ToString
    '    txtPIG.Text = DGV1.Rows(si).Cells(DGV1.Columns("pig").Index).Value.ToString
    '    txtRBR.Text = DGV1.Rows(si).Cells(DGV1.Columns("rbr").Index).Value.ToString
    '    dtpDatumDolaska.Text = DGV1.Rows(si).Cells(DGV1.Columns("DatumDolaska").Index).Value.ToString
    '    txtIshodNapomena.Text = DGV1.Rows(si).Cells(DGV1.Columns("IshodNapomena").Index).Value.ToString
    '    txtKontaktOsoba.Text = DGV1.Rows(si).Cells(DGV1.Columns("KontaktOsoba").Index).Value.ToString
    '    txtBrojTelefona.Text = DGV1.Rows(si).Cells(DGV1.Columns("BrojTelefona").Index).Value.ToString


    '    If dtpDatumDolaska.Text.Trim = "" Then dtpDatumDolaska.Text = Date.Now.ToString("dd.MM.yyyy")


    '    'ishodi  'cb1-cb7
    '    Dim ishod As String = DGV1.Rows(si).Cells(DGV1.Columns("ishod").Index).Value.ToString
    '    Dim iishod As Integer = 0
    '    If IsNumeric(ishod) = True Then iishod = CInt(ishod)

    '    rb1.Checked = False
    '    rb2.Checked = False
    '    rb4.Checked = False
    '    rb6.Checked = False
    '    rb7.Checked = False

    '    If iishod = 1 Then rb1.Checked = True
    '    If iishod = 2 Then rb2.Checked = True
    '    If iishod = 3 Then rb4.Checked = True
    '    If iishod = 4 Then rb6.Checked = True
    '    If iishod = 5 Then rb7.Checked = True

    '    p2.Enabled = True

    '    dtpZakazanoDatum.Text = ""
    '    If Not DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoDatum").Index).Value Is System.DBNull.Value AndAlso
    '                        DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoDatum").Index).Value.ToString <> "" Then
    '        dtpZakazanoDatum.Text = DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoDatum").Index).Value.ToString
    '    End If

    '    dtpZakazanoVreme.Text = ""
    '    If Not DGV1.Rows(si).Cells(DGV1.Columns("Zakazanovreme").Index).Value Is System.DBNull.Value AndAlso
    '                        DGV1.Rows(si).Cells(DGV1.Columns("Zakazanovreme").Index).Value.ToString <> "" Then
    '        dtpZakazanoVreme.Text = DGV1.Rows(si).Cells(DGV1.Columns("ZakazanoVreme").Index).Value.ToString
    '    End If



    '    Dim cati_nacin As String = DGV1.Rows(si).Cells(DGV1.Columns("cati_nacin").Index).Value.ToString
    '    Dim icati_nacin As String = ""
    '    If IsNumeric(cati_nacin) = True Then icati_nacin = cati_nacin.Trim

    '    dtpZakazanoDatum.Text = dtpZakazanoDatum.Text.Trim

    '    dtpDatumDolaska.Text = dtpDatumDolaska.Text.Trim

    '    txtBrojTelefona.Text = txtBrojTelefona.Text.Trim

    '    dtpZakazanoVreme.Text = dtpZakazanoVreme.Text.Trim

    '    If rb1.Checked = True OrElse rb2.Checked = True OrElse rb4.Checked = True OrElse rb6.Checked = True OrElse rb7.Checked = True Then
    '        cbPonistiZak.Visible = True
    '    Else
    '        cbPonistiZak.Visible = False
    '    End If

    'End Sub

    'Private Sub Rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
    '    If rb1.Checked = True Then

    '        Dim str As String = "select * from OpstiPodaci s inner join Adresar a on a.pig=s.pig and a.rbr=s.rbr " + nvrd +
    '                            " where a.anketar=N'" + kosam + "' and s.pig='" + txtPIG.Text.Trim + "' and s.rbr='" + txtRBR.Text.Trim + "' " + nvrd
    '        Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
    '        If dt.Rows.Count > 0 Then
    '            ISTMessageBox.Show("Započeli ste popisivanje ovog gazdinstva. Dozvoljen ishod je 4 ili 5.")
    '            rb1.Checked = False
    '            Exit Sub
    '        End If

    '        p2.Visible = False
    '        dtpZakazanoDatum.Text = ""
    '        dtpZakazanoVreme.Text = ""
    '        txtKontaktOsoba.Text = ""
    '        txtBrojTelefona.Text = ""
    '        txtIshodNapomena.Focus()
    '        txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
    '        txtIshodNapomena.SelectionLength = 0
    '        'Me.cbTelefon.Enabled = True
    '        'Me.cbDolazak.Enabled = True
    '        'Me.cbTelefon.Checked = False
    '        'Me.cbDolazak.Checked = False
    '        'p2.Visible = True
    '        'dtpZakazanoDatum.Focus()
    '    End If
    'End Sub
    'Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
    '    If rb2.Checked = True Then
    '        Dim str As String = "select * from OpstiPodaci s  inner join Adresar a on a.pig=s.pig and a.rbr=s.rbr " + nvrd +
    '                            " where a.anketar=N'" + kosam + "' and s.pig='" + txtPIG.Text.Trim + "' and s.rbr='" + txtRBR.Text.Trim + "' " + nvrd
    '        Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
    '        If dt.Rows.Count > 0 Then
    '            ISTMessageBox.Show("Započeli ste popisivanje ovog gazdinstva. Dozvoljen ishod je 4 ili 5.")
    '            rb2.Checked = False
    '            Exit Sub
    '        End If
    '        p2.Visible = True
    '        dtpZakazanoDatum.Focus()
    '    End If
    'End Sub


    'Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
    '    If rb4.Checked = True Then
    '        p2.Visible = True
    '        Me.dtpZakazanoDatum.Focus()
    '    End If
    'End Sub

    'Private Sub rb6_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged

    '    If rb6.Checked = True Then
    '        p2.Visible = False
    '        dtpZakazanoDatum.Text = ""
    '        dtpZakazanoVreme.Text = ""
    '        txtKontaktOsoba.Text = ""
    '        txtBrojTelefona.Text = ""
    '        txtIshodNapomena.Focus()
    '        txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
    '        txtIshodNapomena.SelectionLength = 0
    '    End If
    'End Sub
    'Private Sub rb7_CheckedChanged(sender As Object, e As EventArgs) Handles rb7.CheckedChanged

    '    If rb7.Checked = True Then
    '        Dim str As String = "select * from OpstiPodaci s  inner join Adresar a on a.pig=s.pig and a.rbr=s.rbr " + nvrd +
    '                            " where a.anketar=N'" + kosam + "' and s.pig='" + txtPIG.Text.Trim + "' and s.rbr='" + txtRBR.Text.Trim + "' " + nvrd
    '        Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
    '        If dt.Rows.Count > 0 Then
    '            ISTMessageBox.Show("Započeli ste popisivanje ovog gazdinstva. Dozvoljen ishod je 4 ili 5.")
    '            rb7.Checked = False
    '            Exit Sub
    '        End If
    '        p2.Visible = False
    '        dtpZakazanoDatum.Text = ""
    '        dtpZakazanoVreme.Text = ""
    '        txtKontaktOsoba.Text = ""
    '        txtBrojTelefona.Text = ""
    '        txtIshodNapomena.Focus()
    '        txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
    '        txtIshodNapomena.SelectionLength = 0
    '    End If
    'End Sub

    Sub Dgv1CellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)

        Me.Cursor = Cursors.WaitCursor

        If erowindex >= 0 Then
            DGV1.ClearSelection()
            DGV1.Rows(erowindex).Selected = True

            If DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("Napomena").DisplayIndex Then

                DGV1.ClearSelection()
                DGV1.Rows(erowindex).Selected = True
                Call Promena(erowindex)
                Me.Cursor = Cursors.Default
                
                Exit Sub
            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("ZahtevDorada").DisplayIndex Then
                '    " (case when isnull(a.statusAnketar,0)=3 then N'🖐' when isnull(a.statusAnketar,0)=2 then N'✉' else '' end ) as ZahtevDorada, a.napomenaStatusAnketar RazlogZahteva, " + nvrd +

                Dim verzija As String = ""
                If DGV1.Rows(erowindex).Cells(DGV1.Columns("ZahtevDorada").Index).Value.ToString.Trim = "🖐" Then
                    verzija = "ZAHTEV"
                ElseIf DGV1.Rows(erowindex).Cells(DGV1.Columns("ZahtevDorada").Index).Value.ToString.Trim = "✉" Then
                    verzija = "VRACANJE"
                End If
                If verzija.Trim <> "" Then
                    Call ZahtevZaDoradu(erowindex, verzija)
                Else
                    Exit Sub
                End If


            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("ZahtevZaPlacanje").DisplayIndex Then
                Call ZahtevZaPlacanjeAkcija(erowindex)


            ElseIf DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("PoglOpstiPodaci").DisplayIndex AndAlso DGV1.Rows(erowindex).Cells(DGV1.Columns("PoglOpstiPodaci").Index).Value.ToString <> "x" Then

                gbSecurity.Visible = True
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim tabela As String = "prijemOpstiPodaci"
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

                'If DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                '    zakljucanOdmahSve = True
                'ElseIf DGV1.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                '    Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

                '    Dim msgtitle As String = "............"

                '    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                '    Select Case opc
                '        Case "Da"
                '        Case "Ne"
                '            Me.Cursor = Cursors.Default
                '            Exit Sub
                '    End Select


                'End If

                'Me.lSecurity.Visible = True
                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

                Try
                    gbSecurity.Visible = False
                    frm.ShowDialog()
                Catch ex As Exception
                    gbSecurity.Visible = False
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    gbSecurity.Visible = False
                    frm.Dispose()
                End Try

                Dim filterStatus As String = ""
                If rbPlaceni.Checked = True Then
                    filterStatus = "PLACENI"
                ElseIf rbZaPlacanje.Checked = True Then
                    filterStatus = "ZAPLACANJE"
                ElseIf rbVraceno.Checked = True Then
                    filterStatus = "VRACENO"
                ElseIf rbSve.Checked = True Then
                    filterStatus = "SVE"
                End If

                refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)

                'DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True


            End If


        End If

        Me.Cursor = Cursors.Default
        
    End Sub


    'Sub DgvRegBRMPCellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)

    '    Me.Cursor = Cursors.WaitCursor

    '    If erowindex >= 0 Then
    '        DGVRegBrMP.ClearSelection()
    '        DGVRegBrMP.Rows(erowindex).Selected = True

    '        If DGVRegBrMP.Columns(eColumnIndex).DisplayIndex = DGVRegBrMP.Columns("Unos").DisplayIndex Then

    '            Dim zzak As Boolean = False
    '            Dim red As Integer = erowindex
    '            Dim tabela As String = "OpstiPodaci"
    '            Dim zakljucanOdmahSve As Boolean = False
    '            Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
    '            If zak = 1 Then zzak = True : zakljucanOdmahSve = True

    '            Dim KljuceviSaEkranaSaVrednostima(,) As String
    '            ReDim KljuceviSaEkranaSaVrednostima(1, 1)
    '            KljuceviSaEkranaSaVrednostima(0, 0) = "PIG".Trim.ToUpper
    '            KljuceviSaEkranaSaVrednostima(0, 1) = DGVRegBrMP.Rows(erowindex).Cells(DGVRegBrMP.Columns("PIG").Index).Value.ToString
    '            KljuceviSaEkranaSaVrednostima(1, 0) = "RBR".Trim.ToUpper
    '            KljuceviSaEkranaSaVrednostima(1, 1) = DGVRegBrMP.Rows(erowindex).Cells(DGVRegBrMP.Columns("RBR").Index).Value.ToString


    '            Dim dosaoIzCapiAdresara As Boolean = True
    '            'filtDatumZakazan.Items.Clear()

    '            Dim strStatus As String = "select statusanketar from adresar where PIG='" + KljuceviSaEkranaSaVrednostima(0, 1) + "' and RBR='" + KljuceviSaEkranaSaVrednostima(1, 1) + "' ;" + nvrd
    '            Dim dtStatus As DataTable = izvrsiSQLvratiDT(strStatus, Me.DBConnectionString, Nothing)
    '            Dim kojistatus As String = ""

    '            If dtStatus.Rows.Count > 0 Then
    '                kojistatus = dtStatus.Rows(0).Item(0).ToString.Trim
    '            Else
    '                Exit Sub
    '            End If

    '            If kojistatus = "2" OrElse kojistatus = "3" Then
    '                zakljucanOdmahSve = True
    '            ElseIf kojistatus = "1" Then
    '                Dim msgtxt As String = "Upitnik za ovo gazdinstvo je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"

    '                Dim msgtitle As String = "............"

    '                Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
    '                Select Case opc
    '                    Case "Da"
    '                    Case "Ne"
    '                        Me.Cursor = Cursors.Default
    '                        Exit Sub
    '                End Select


    '            End If

    '            Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
    '               True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
    '               Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve, KljuceviSaEkranaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)

    '            Try
    '                frm.ShowDialog()
    '            Catch ex As Exception
    '                ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Finally
    '                frm.Dispose()
    '            End Try

    '            refreshDGVRegBrMP()


    '        End If
    '    End If
    '    Me.Cursor = Cursors.Default

    'End Sub

    Sub ZahtevZaPlacanjeAkcija(ByVal selectedRow As Integer)

        Dim ZahtevZaPlacanje As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("ZahtevZaPlacanje").Index).Value.ToString
        Dim StatusAnketar As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("statusanketar").Index).Value.ToString.Trim
        Dim UserStatusAnketar As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("user_statusanketar").Index).Value.ToString.Trim
        Dim StatusKontrolorNivo1 As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("statusKontrolorNivo1").Index).Value.ToString.Trim
        Dim PIG As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("PIG").Index).Value.ToString.Trim
        Dim RBR As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("RBR").Index).Value.ToString.Trim
        Dim ImaGR As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("GR").Index).Value.ToString.Trim
        Dim sql As String = ""
        If StatusKontrolorNivo1 = "" Then StatusKontrolorNivo1 = "0"
        If StatusAnketar = "" Then StatusAnketar = "0"
        'and exists (select * from imtrep.[dbo].[vPP23_VezaOKPOP_IBbroj] x where isnull(odustao,0)=0 and sifraok='" + kosam + "' and a.anketar=x.sifra)
        If ImaGR.Trim.ToUpper = "DA" Then
            ISTMessageBox.Show("Ovaj upitnik ima grešku, ne možete postaviti status - Spremno za plaćanje - dok ne ispravite grešku vi ili popisivač!")
            Exit Sub
        End If

        If ZahtevZaPlacanje.Trim.ToUpper = "FALSE" AndAlso StatusKontrolorNivo1.Trim.ToUpper.Substring(0, 1) = "0" Then
            If StatusAnketar.Trim.ToUpper = "2" Then
                sql = " update " + kojiadresar + " set StatusKontrolorNivo1=6, User_StatusKontrolorNivo1=N'" + kosam + "', DATE_statusKontrolorNivo1=getdate()" + nvrd +
                      " where pig='" + PIG + "' and rbr='" + RBR + "' "

            ElseIf StatusAnketar.Trim.ToUpper = "0" AndAlso (UserStatusAnketar.Trim.ToUpper.Substring(0, 2) = "I7" OrElse UserStatusAnketar.Trim.ToUpper.Substring(0, 2) = "I8") Then
                ISTMessageBox.Show("Ovaj upitnik je vraćen na doradu popisivaču, ne možete postaviti status - Spremno za plaćanje -")
                Exit Sub
            ElseIf StatusAnketar.Trim.ToUpper = "3" Then
                Dim msgtxt As String = "Da li ste sigurni da želite da ovaj upitnik postaviti u status - Spremno za plaćanje?" + nvrd +
                                       "Popisivač je ovaj upitnik tražio na doradu, postavljanjem statusa automatski će se smatrati da dorada nije odobrena!"
                Dim msgtitle As String = "............"

                Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                Select Case opc
                    Case "Da"
                        Dim opc2 As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle, 2)
                        Select Case opc2
                            Case "Da"
                                sql = " update " + kojiadresar + " set StatusKontrolorNivo1=6, User_StatusKontrolorNivo1=N'" + kosam + "', DATE_statusKontrolorNivo1=getdate()," + nvrd +
                        " statusanketar=2, user_statusanketar=N'" + kosam + "'" + nvrd +
                        " where pig='" + PIG + "' and rbr='" + RBR + "' " + nvrd
                            Case "Ne"
                                Exit Sub
                            Case "Cancel"
                                Me.Cursor = Cursors.Default
                                Exit Sub
                        End Select
                    Case "Ne"
                        Exit Sub
                    Case "Cancel"
                        Me.Cursor = Cursors.Default
                        Exit Sub
                End Select
            End If
        ElseIf ZahtevZaPlacanje.Trim.ToUpper = "FALSE" AndAlso (StatusKontrolorNivo1.Trim.ToUpper.Substring(0, 1) = "7" OrElse StatusKontrolorNivo1.Trim.ToUpper.Substring(0, 1) = "6") Then
            ISTMessageBox.Show("Greska 101. Pozoite administratora.")
        ElseIf ZahtevZaPlacanje.Trim.ToUpper = "TRUE" AndAlso StatusKontrolorNivo1.Trim.ToUpper.Substring(0, 1) = "7" Then
            ISTMessageBox.Show("Upitnik je poslat na plaćanje, ne možete promeniti status.")
        ElseIf ZahtevZaPlacanje.Trim.ToUpper = "TRUE" AndAlso StatusKontrolorNivo1.Trim.ToUpper.Substring(0, 1) = "0" Then
            ISTMessageBox.Show("Greska 102. Pozoite administratora.")
        ElseIf ZahtevZaPlacanje.Trim.ToUpper = "TRUE" AndAlso StatusKontrolorNivo1.Trim.ToUpper.Substring(0, 1) = "6" Then
            sql = " update " + kojiadresar + " set StatusKontrolorNivo1=0, User_StatusKontrolorNivo1=N'" + kosam + "', DATE_statusKontrolorNivo1=getdate()" + nvrd +
                  " where pig='" + PIG + "' and rbr='" + RBR + "' "
        End If

        If sql.Trim.ToUpper <> "" Then
            Dim ok As String = izvrsiSQL(sql, DBConnectionString)
            If ok.ToUpper <> "OK" Then
                ISTMessageBox.Show("Greska 100. Pozoite administratora.")
            End If
        End If
        Dim filterStatus As String = ""
        If rbPlaceni.Checked = True Then
            filterStatus = "PLACENI"
        ElseIf rbZaPlacanje.Checked = True Then
            filterStatus = "ZAPLACANJE"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If
        refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)
    End Sub

    Sub ZahtevZaDoradu(ByVal selectedRow As Integer, ByVal verzija As String)


        DGV1.ClearSelection()
        DGV1.Rows(selectedRow).Selected = True

        Dim si As Integer = DGV1.SelectedRows(0).Index
        Dim dgvStatusAnketar As String = DGV1.Rows(si).Cells(DGV1.Columns("statusanketar").Index).Value.ToString.Trim
        Dim dgvpig As String = DGV1.Rows(si).Cells(DGV1.Columns("pig").Index).Value.ToString.Trim
        Dim dgvrbr As String = DGV1.Rows(si).Cells(DGV1.Columns("rbr").Index).Value.ToString.Trim
        Dim dgvadresa As String = DGV1.Rows(si).Cells(DGV1.Columns("adresa").Index).Value.ToString.Trim

        Call pZahNonVisible()

        tboxZahtevPig.Text = dgvpig
        tboxZahtevRbr.Text = dgvrbr
        tboxZahtevAdresa.Text = dgvadresa



        'zapamceniStatusanketar = dgvStatusAnketar
        panelZahtevZaDoradu.Tag = selectedRow

        'If dgvStatusAnketar = "3" Then cbZahtevZaDoradu.Checked = True
        'tboxZahtevPig.Text = DGV1.Rows(si).Cells(DGV1.Columns("PIG").Index).Value.ToString
        'tboxZahtevRbr.Text = DGV1.Rows(si).Cells(DGV1.Columns("RBR").Index).Value.ToString
        'tboxZahtevRazlog.Text = DGV1.Rows(si).Cells(DGV1.Columns("napomenaStatusAnketar").Index).Value.ToString
        'tboxZahtevAdresa.Text = DGV1.Rows(si).Cells(DGV1.Columns("Adresa").Index).Value.ToString


        Call pZahVisible(verzija)

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

    Sub p3Visible()
        Call disabledtabkontrolu()
        panelNapomena.BringToFront()
        Me.panelNapomena.Visible = True
        Call samoja(panelNapomena)
        tboxNapomenaNapomena.Focus()
    End Sub

    Sub Promena(ByVal selectedRow As Integer)
        Call p3NonVisible()

        DGV1.ClearSelection()
        DGV1.Rows(selectedRow).Selected = True

        Dim si As Integer = DGV1.SelectedRows(0).Index

        tboxNapomenaPIG.Text = DGV1.Rows(si).Cells(DGV1.Columns("PIG").Index).Value.ToString
        tboxNapomenaRBR.Text = DGV1.Rows(si).Cells(DGV1.Columns("RBR").Index).Value.ToString
        tboxNapomenaAdresa.Text = DGV1.Rows(si).Cells(DGV1.Columns("Adresa").Index).Value.ToString
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

    Dim dodatak As String = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                  " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                  " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                  " Set @Hash  = '12345';    " + vbCrLf +
                  " Declare @a as varbinary(256);  " + vbCrLf
    Sub refreshDGV1(ByVal filterNas As String, ByVal filtPigg As String, ByVal filtPopisivacc As String, Optional ByVal filterstatus As String = "")


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
        Dim filterpopisivacZvezdica As String = ""
        If filtPopisivac.Text.Trim = "*" Then
            filterpopisivacZvezdica = ""
        Else
            If filtPopisivac.Text.Trim.Length > 9 Then
                filterpopisivacZvezdica = filtPopisivac.SelectedValue.ToString.Trim
            Else
                filterpopisivacZvezdica = ""
            End If

        End If

        Dim sacuvajvrFilteraPop As String = filtPopisivac.Text

        str = dodatak + " Select (case when isnull(statusKontrolorNivo1, 0) In (6,7) Then cast(1 As bit) When isnull(statusKontrolorNivo1,0)=0 Then cast(0 As bit) Else cast(0 As bit) End) As ZahtevZaPlacanje," + nvrd +
              " a.anketar,a.PIG, a.rbr, (case when ( isnull(cast(M1.indgr as int),0)+ isnull(cast(M2.indgr as int),0)+ isnull(cast(M3.indgr as int),0)+ isnull(cast(M4.indgr as int),0)+ isnull(cast(M5.indgr as int),0)+" + nvrd +
              " isnull(cast(M6.indgr as int),0)+ isnull(cast(P1.indgr as int),0)+ isnull(cast(P2.indgr as int),0)+ isnull(cast(P3.indgr as int),0)+ isnull(cast(P4.indgr as int),0)+" + nvrd +
              " isnull(cast(P5.indgr as int),0)+ isnull(cast(VP3.indgr as int),0)>0) then 'Da' else 'Ne' end) as GR," + nvrd +
              " N'' as Prazno0,  " + nvrd +
              " (case when isnull(a.statusAnketar,0) in (2,3) and isnull(statuskontrolornivo1,0) not in (6,7) then N'📝' else '' end ) PoglOpstiPodaci, N'' as PraznoB, " + nvrd +
              " PravniStatus, " + nvrd +
              " (case when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash)))))+' '+trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(Prezime)='' then NULL else Prezime end),1), 1, CONVERT(varbinary, @Hash))))) " + nvrd +
              " when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))) else '' end) as ImePrezime, " + nvrd +
              " Nazivnaselja, NASELJe,  " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) +' '+ trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kbr)='' then NULL else kbr end),1), 1, CONVERT(varbinary, @Hash))))) Adresa, " + nvrd +
              " OPstina, Nazivopstine," + nvrd +
              " N'' as Prazno1, N'🖉' as Napomena, ISTNote,  N'' as PraznoD, " + nvrd +
              " (case when isnull(a.webunos,0)=0 and isnull(a.statusAnketar,0)=3 and isnull(statuskontrolornivo1,0)<>7 and not exists (select * from imtrep.[dbo].[vPP23_VezaOKPOP_IBbroj] x where isnull(odustao,0)=1 and sifraok='" + kosam + "' and a.anketar=x.sifra)" + nvrd +
              " then N'🖐' when isnull(a.webunos,0)=0 and  isnull(a.statusAnketar,0)=2 and isnull(statuskontrolornivo1,0)<>7 and not exists (select * from imtrep.[dbo].[vPP23_VezaOKPOP_IBbroj] x where isnull(odustao,0)=1 and sifraok='" + kosam + "' and a.anketar=x.sifra) then N'✉' else '' end ) as ZahtevDorada, a.napomenaStatusAnketar RazlogZahteva, " + nvrd +
              " (case when isnull(a.statusAnketar,0)=2 and left(trim(isnull(a.user_statusAnketar,'')),1) = 'P' and isnull(a.capiexported,0)=1 then 'Da' else '' end ) as Ispravljeno , a.napomenaKontrolorNivo1 , N'' as PraznoA, " + nvrd +
              " god, (case when isnull(statusKontrolorNivo1,0)=7 then 'PLACENI'" + nvrd +
              " when isnull(statusKontrolorNivo1,0)=6 then N'ZAPLACANJE'" + nvrd +
              " when isnull(statusanketar,0)='0' and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') then 'VRACENO'" + nvrd +
              " else '' end) as status, statusanketar, '' as proba, statusKontrolorNivo1, user_statusanketar " + nvrd +
              " from (select * from " + kojiadresar + " xx where exists (select * from Veza_Ank_Kont_Po b where xx.anketar=b.anketar and b.opstinskikoor=N'" + kosam + "' and aktivan=1) and " + nvrd +
              " (isnull(statusanketar,0) in (2,3) or (isnull(statusanketar,0)=0 and left(isnull(trim(user_statusanketar),'9999'),2) in ('I7','I8')))) a " + nvrd +
              " left join (select pig, rbr, indgr from prijemModul1) M1 on a.pig=M1.pig and a.rbr=M1.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemModul2) M2 on a.pig=M2.pig and a.rbr=M2.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemModul3) M3 on a.pig=M3.pig and a.rbr=M3.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemModul4) M4 on a.pig=M4.pig and a.rbr=M4.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemModul5) M5 on a.pig=M5.pig and a.rbr=M5.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemModul6) M6 on a.pig=M6.pig and a.rbr=M6.rbr" + nvrd +
              " left join (select pig, rbr, indgr, odziv from prijemOpstiPodaci) P1 on a.pig=P1.pig and a.rbr=P1.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemPogl_02) P2 on a.pig=P2.pig and a.rbr=P2.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemPogl_03) P3 on a.pig=P3.pig and a.rbr=P3.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemPogl_04) P4 on a.pig=P4.pig and a.rbr=P4.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemPogl_05) P5 on a.pig=P5.pig and a.rbr=P5.rbr" + nvrd +
              " left join (select pig, rbr, indgr from prijemvPogl_03) vP3 on a.pig=vP3.pig and a.rbr=vP3.rbr" + nvrd +
              " where (isnull(cast(P1.Odziv as nvarchar(2)),'')='1' or (isnull(cast(P1.Odziv as nvarchar(2)),'')='' and isnull(user_statusanketar,'')<>'I7999999') and isnull(statusanketar,0)=0 and left(isnull(trim(user_statusanketar),'9999'),2) in ('I7','I8')) and Nazivnaselja like '%" + filterNas + "%' and a.pig like N'%" + filtPigg + "%' " + nvrd +
              " and isnull(Anketar,'') like N'%" + filterpopisivacZvezdica + "%' " + nvrd

        If filterstatus.Trim.ToUpper = "" OrElse filterstatus.Trim.ToUpper = "SVE" Then

        ElseIf filterstatus.Trim.ToUpper = "PLACENI" Then
            str = str + nvrd + " and isnull(statusKontrolorNivo1,0)=7 "
        ElseIf filterstatus.Trim.ToUpper = "ZAPLACANJE" Then
            str = str + nvrd + " and isnull(statusKontrolorNivo1,0)=6 "
        ElseIf filterstatus.Trim.ToUpper = "VRACENO" Then
            str = str + nvrd + " and isnull(statusanketar,0)=0 and left(trim(isnull(user_statusanketar,'')),2) in ('I7','I8') "
        End If

        str = str + nvrd + " order by OPstina,NASELJe,Anketar, ULICA,Kbr,PIG, rbr"

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)

        DGV1.DataSource = dt

        If a.Trim.ToUpper <> "NONE" AndAlso a.Trim.ToUpper <> "" AndAlso b >= 0 Then
            If a.Trim.ToUpper = "DESCENDING" Then
                DGV1.Sort(DGV1.Columns(b), ListSortDirection.Descending)
            ElseIf a.Trim.ToUpper = "ASCENDING" Then
                DGV1.Sort(DGV1.Columns(b), ListSortDirection.Ascending)
            End If
        End If


        DGV1.Columns("statusKontrolorNivo1").Visible = False
        DGV1.Columns("user_statusanketar").Visible = False
        DGV1.Columns("statusanketar").Visible = False
        DGV1.Columns("proba").Visible = False
        DGV1.Columns("status").Visible = False
        DGV1.Columns("user_statusanketar").Visible = False
        DGV1.Columns("god").Visible = False
        DGV1.Columns("napomenaKontrolorNivo1").Visible = False
        DGV1.Columns("pravnistatus").Visible = False


        DGV1.Columns("PIG").HeaderText = "PIG"
        DGV1.Columns("rbr").HeaderText = "RBR"
        DGV1.Columns("ImePrezime").HeaderText = "Ime i prezime / Naziv PL"
        DGV1.Columns("Nazivnaselja").HeaderText = "Naziv naselja"
        DGV1.Columns("Napomena").HeaderText = "Unos napomene"
        DGV1.Columns("Prazno0").HeaderText = ""
        DGV1.Columns("Prazno1").HeaderText = ""
        DGV1.Columns("PraznoA").HeaderText = ""
        DGV1.Columns("PraznoD").HeaderText = ""
        DGV1.Columns("PraznoB").HeaderText = ""
        DGV1.Columns("ZahtevDorada").HeaderText = ""
        DGV1.Columns("ISTNote").HeaderText = "Napomena"
        DGV1.Columns("Naselje").HeaderText = "Naselje"
        DGV1.Columns("OPstina").HeaderText = "Opština"
        DGV1.Columns("Nazivopstine").HeaderText = "Naziv opštine"
        DGV1.Columns("ZahtevZaPlacanje").HeaderText = "Upitnik je pregledan" + nvrd + "i spreman za plaćanje"
        DGV1.Columns("GR").HeaderText = "Upitnik ima grešku"
        DGV1.Columns("RazlogZahteva").HeaderText = "Razlog zahteva za doradu"
        DGV1.Columns("PoglOpstiPodaci").HeaderText = "P1"
        DGV1.Columns("Ispravljeno").HeaderText = "Popisivač ispravio upitnik koji je bio vraćen na doradu"
        DGV1.Columns("anketar").HeaderText = "Nalog popisivača"

        DGV1.Columns("PIG").Width = 90
        DGV1.Columns("rbr").Width = 40
        DGV1.Columns("ImePrezime").Width = 200
        DGV1.Columns("Nazivnaselja").Width = 200

        DGV1.Columns("PoglOpstiPodaci").Width = 30
        DGV1.Columns("prazno0").MinimumWidth = 2
        DGV1.Columns("Prazno0").Width = 2
        DGV1.Columns("prazno1").MinimumWidth = 2
        DGV1.Columns("Prazno1").Width = 2
        DGV1.Columns("praznoA").MinimumWidth = 2
        DGV1.Columns("PraznoA").Width = 2
        DGV1.Columns("praznoD").MinimumWidth = 2
        DGV1.Columns("PraznoD").Width = 2
        DGV1.Columns("praznoB").MinimumWidth = 2
        DGV1.Columns("PraznoB").Width = 2
        DGV1.Columns("Napomena").Width = 70
        DGV1.Columns("ZahtevDorada").Width = 30
        DGV1.Columns("napomenaKontrolorNivo1").Width = 200
        DGV1.Columns("proba").Width = 300
        DGV1.Columns("ZahtevZaPlacanje").Width = 100
        DGV1.Columns("Adresa").Width = 150
        DGV1.Columns("GR").Width = 100
        DGV1.Columns("RazlogZahteva").Width = 120
        DGV1.Columns("Ispravljeno").Width = 120
        DGV1.Columns("anketar").Width = 80
        DGV1.Columns("naselje").Width = 80


        DGV1.EnableHeadersVisualStyles = False

        If Not filtNaseljeee Is Nothing Then
            filtNaseljeee.Visible = True
        End If

        If Not filtPig Is Nothing Then
            filtPig.BringToFront()
            filtPig.Visible = True
        End If

        If Not filtPopisivac Is Nothing AndAlso Not DGV1 Is Nothing Then
            'filtDatumZakazan.Width = DGV1.Columns("ZakazanoDatum").Width
            'filtDatumZakazan.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("PodeliPIG").Width + DGV1.Columns("PIG").Width + DGV1.Columns("rbr").Width + DGV1.Columns("ImePrezime").Width _
            '    + DGV1.Columns("Nazivnaselja").Width + DGV1.Columns("Ulica").Width + DGV1.Columns("Kbr").Width + DGV1.Columns("Tel").Width + DGV1.Columns("Prazno0").Width _
            '    + DGV1.Columns("Zakazivanje").Width + DGV1.Columns("Ishod").Width + DGV1.Columns("Prazno0").Width + DGV1.Columns("PoglOpstiPodaci").Width + DGV1.Columns("PoglZemljiste").Width _
            '    + DGV1.Columns("PoglVocnjaciVinogradi").Width + DGV1.Columns("PoglStoka").Width + DGV1.Columns("PoglRadnaSnaga").Width + DGV1.Columns("PoglNavodnjavanje").Width + DGV1.Columns("PoglDjubrivo").Width _
            '    + DGV1.Columns("PoglNacinDrzanjaStoke").Width + DGV1.Columns("PoglMehanizacija").Width + DGV1.Columns("PoglObrada").Width + DGV1.Columns("PoglOstaliPodaci").Width + DGV1.Columns("PraznoB").Width _
            '    + DGV1.Columns("UzorakVV").Width + DGV1.Columns("praznoC").Width, DGV1.ColumnHeadersHeight - filtNaseljeee.Height - 1)
            filtPopisivac.Visible = True
            filtPopisivac.Text = sacuvajvrFilteraPop
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

        'Dim strlbl As String = " select count(*) ukupno, " + nvrd +
        '                          "(select count(*) from opstipodaci o where isnull(odziv,'0')='1' and exists (select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar='" + kosam + "')) odziv1, " + nvrd +
        '                          " (select count(*) from opstipodaci o where isnull(odziv,'0')<>'1' and exists (select * from adresar a where a.pig=o.pig and a.rbr=o.rbr and anketar='" + kosam + "')) neodziv1 " + nvrd +
        '                          " from adresar where anketar='" + kosam + "'" + nvrd

        'Dim dtlbl As DataTable = izvrsiSQLvratiDT(strlbl, DBConnectionString, Me.jezik)
        'If dtlbl.Rows.Count = 1 Then
        '    lblUkupno.Text = "Ukupno gazdinstava: " + dtlbl.Rows(0).Item(0).ToString + "     Broj gazdinstva sa odzivom jedan: " + dtlbl.Rows(0).Item(1).ToString + "     Broj gazdinstva sa odzivom različit od jedan: " + dtlbl.Rows(0).Item(2).ToString + ""
        'Else
        '    lblUkupno.Text = ""
        'End If


        DGV1.Visible = True

    End Sub

    Dim dtNA As DataTable

    Dim selektovanipigovi As String = ""

    Sub refreshDGVNA(ByVal selektovanipigovi As String, ByVal kojaraspodela As String, Optional svecekiraj As Boolean = False)

        'Dim aktivan As Integer = -1
        'If kojaraspodela = "AA" Then
        '    aktivan = 1
        'ElseIf kojaraspodela = "NA" Then
        '    aktivan = 0
        'End If

        Dim selektovanred As Integer = -1
        Dim selektovanPig As String = ""
        If dgvNA.SelectedCells.Count > 0 Then
            selektovanred = dgvNA.SelectedCells.Item(0).RowIndex
        End If
        If selektovanred >= 0 Then
            selektovanPig = dgvNA.Rows(selektovanred).Cells(dgvNA.Columns("PIG").Index).Value.ToString + dgvNA.Rows(selektovanred).Cells(dgvNA.Columns("RBR").Index).Value.ToString
        End If
        '✔


        Dim str As String = ""

        Dim dt As DataTable
        Dim a As String = ""
        'Dim aa As System.Windows.Forms.SortOrder = Nothing
        Dim b As Integer = -1
        If Not dgvNA Is Nothing Then
            a = dgvNA.SortOrder.ToString
            If Not dgvNA.SortedColumn Is Nothing Then
                b = dgvNA.SortedColumn.Index
            End If
        End If
        Dim pom As String = ""
        If selektovanipigovi = "" Then
            pom = "''"
        Else
            pom = selektovanipigovi
        End If

        If cbOdKogaNA Is Nothing OrElse cbOdKogaNA.SelectedValue.ToString.Trim = "" Then
            str = "Select top 0 '' ZahtevZaPlacanje, '' as pig, '' ImePrezime, '' Nazivnaselja, '' NASELJe, '' Adresa, '' OPstina, '' Nazivopstine from adresar71"
        ElseIf svecekiraj = False Then
            str = dodatak + " Select (case when pig+trim(cast(rbr as nvarchar(2))) in (" + pom + ") Then cast(1 As bit) Else cast(0 As bit) End) As ZaRaspodelu," + nvrd +
              " a.PIG, a.rbr,  " + nvrd +
              " (case when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash)))))+' '+trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(Prezime)='' then NULL else Prezime end),1), 1, CONVERT(varbinary, @Hash))))) " + nvrd +
              " when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))) else '' end) as ImePrezime, " + nvrd +
              " Nazivnaselja, NASELJe,  " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) +' '+ trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kbr)='' then NULL else kbr end),1), 1, CONVERT(varbinary, @Hash))))) Adresa, " + nvrd +
              " OPstina, Nazivopstine " + nvrd +
              " from (select * from " + kojiadresar + " xx where exists (select * from Veza_Ank_Kont_Po b where xx.anketar=b.anketar and b.opstinskikoor=N'" + kosam + "' and aktivan=1) and " + nvrd +
              " (isnull(statusanketar,0)=0 and left(isnull(trim(user_statusanketar),'9999'),2) not in ('I7','I8'))) a " + nvrd +
              " where isnull(Anketar,'') like N'%" + cbOdKogaNA.SelectedValue.ToString.Trim + "%' " + nvrd +
              " and not exists (select * from RaspodelaAktivanAktivan xx where a.anketar=xx.anketarod and a.pig=xx.pig and a.rbr=xx.rbr and xx.anketardo=N'" + cbKomeNA.SelectedValue.ToString.Trim + "')"
        ElseIf svecekiraj = True Then
            str = dodatak + " Select (case when 2=2 Then cast(1 As bit) Else cast(0 As bit) End) As ZaRaspodelu," + nvrd +
              " a.PIG, a.rbr,  " + nvrd +
              " (case when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash)))))+' '+trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(Prezime)='' then NULL else Prezime end),1), 1, CONVERT(varbinary, @Hash))))) " + nvrd +
              " when isnull(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))),'')<>'' then trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(NazivPL)='' then NULL else NazivPL end),1), 1, CONVERT(varbinary, @Hash))))) else '' end) as ImePrezime, " + nvrd +
              " Nazivnaselja, NASELJe,  " + nvrd +
              " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) +' '+ trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kbr)='' then NULL else kbr end),1), 1, CONVERT(varbinary, @Hash))))) Adresa, " + nvrd +
              " OPstina, Nazivopstine " + nvrd +
              " from (select * from " + kojiadresar + " xx where exists (select * from Veza_Ank_Kont_Po b where xx.anketar=b.anketar and b.opstinskikoor=N'" + kosam + "' and aktivan=1) and " + nvrd +
              " (isnull(statusanketar,0)=0 and left(isnull(trim(user_statusanketar),'9999'),2) not in ('I7','I8'))) a " + nvrd +
              " where isnull(Anketar,'') like N'%" + cbOdKogaNA.SelectedValue.ToString.Trim + "%' " + nvrd +
              " and not exists (select * from RaspodelaAktivanAktivan xx where a.anketar=xx.anketarod and a.pig=xx.pig and a.rbr=xx.rbr and xx.anketardo=N'" + cbKomeNA.SelectedValue.ToString.Trim + "')"
        End If

        str = str + nvrd + " order by PIG, rbr "

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)

        dgvNA.DataSource = dt
        dtNA = Nothing
        dtNA = dt

        If a.Trim.ToUpper <> "NONE" AndAlso a.Trim.ToUpper <> "" AndAlso b >= 0 Then
            If a.Trim.ToUpper = "DESCENDING" Then
                dgvNA.Sort(dgvNA.Columns(b), ListSortDirection.Descending)
            ElseIf a.Trim.ToUpper = "ASCENDING" Then
                dgvNA.Sort(dgvNA.Columns(b), ListSortDirection.Ascending)
            End If
        End If

        dgvNA.Columns("ZaRaspodelu").HeaderText = ""


        dgvNA.Columns("PIG").HeaderText = "PIG"
        dgvNA.Columns("rbr").HeaderText = "RBR"
        dgvNA.Columns("ImePrezime").HeaderText = "Ime i prezime / Naziv PL"
        dgvNA.Columns("Nazivnaselja").HeaderText = "Naziv naselja"


        dgvNA.Columns("Naselje").HeaderText = "Naselje"
        dgvNA.Columns("OPstina").HeaderText = "Opština"
        dgvNA.Columns("Nazivopstine").HeaderText = "Naziv opštine"

        dgvNA.Columns("PIG").Width = 90
        dgvNA.Columns("ImePrezime").Width = 200
        dgvNA.Columns("Nazivnaselja").Width = 200
        dgvNA.Columns("Adresa").Width = 150
        dgvNA.Columns("naselje").Width = 80


        dgvNA.EnableHeadersVisualStyles = False

        If Not filtNaseljeee Is Nothing Then
            filtNaseljeee.Visible = True
        End If

        If Not filtPig Is Nothing Then
            filtPig.BringToFront()
            filtPig.Visible = True
        End If

        srediGridView222()


        If selektovanPig <> "" Then
            dgvNA.ClearSelection()
            Dim selectedrow As Integer = vratiSelektvanRedDGVNA(selektovanPig)


            If selectedrow >= 0 AndAlso dgvNA.Rows.Count > 0 AndAlso dgvNA.Rows.Count - 1 >= selectedrow Then
                dgvNA.Rows(selectedrow).Selected = True
            ElseIf dgvNA.Rows.Count > 0 Then
                dgvNA.Rows(0).Selected = True
            Else

            End If

        End If




        If selektovanred >= 0 AndAlso (dgvNA.Rows.Count - 1) > selektovanred Then
            '   Clear selection and then reselect the cell that was selected before by index
            dgvNA.ClearSelection()
            dgvNA.CurrentCell = dgvNA.Rows(selektovanred).Cells(0)
        End If


        dgvNA.Visible = True
        dgvNA.BringToFront()

    End Sub



    Function vratiSelektvanRedDGV1(ByVal selektovanPig As String, ByVal selektovanRbr As Integer) As Integer
        Dim pomrowDGV1 As Integer = 0

        If DGV1.Rows.Count > 0 Then

            Dim kojiPIG As String = selektovanPig
            Dim kojiRBR As String = selektovanRbr

            For i As Integer = 0 To DGV1.Rows.Count - 1
                If kojiPIG.Trim = DGV1.Rows(i).Cells(DGV1.Columns("PIG").Index).Value.ToString().Trim AndAlso kojiRBR.Trim = DGV1.Rows(i).Cells(DGV1.Columns("RBR").Index).Value.ToString().Trim Then
                    pomrowDGV1 = i
                    Exit For
                End If
            Next
        End If
        Return pomrowDGV1
    End Function

    Function vratiSelektvanRedDGVNA(ByVal selektovanPig As String) As Integer
        Dim pomrowDGVNA As Integer = 0

        If dgvNA.Rows.Count > 0 Then
            Dim kojipig As String = ""
            Dim kojirbr As String = ""

            Dim PIGRBR As String = selektovanPig
            If PIGRBR.Length > 3 Then
                kojipig = PIGRBR.Substring(0, 10)
                kojirbr = PIGRBR.Substring(10, PIGRBR.Length - 10)
            End If
            For i As Integer = 0 To dgvNA.Rows.Count - 1
                If kojipig.Trim = dgvNA.Rows(i).Cells(dgvNA.Columns("PIG").Index).Value.ToString().Trim AndAlso kojirbr.Trim = dgvNA.Rows(i).Cells(dgvNA.Columns("rbr").Index).Value.ToString().Trim Then
                    pomrowDGVNA = i
                    Exit For
                End If
            Next
        End If
        Return pomrowDGVNA
    End Function


    Private Sub DGV1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        If DGV1.Visible = False Then
            Exit Sub
        End If
        If DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("status").Index).Value.ToString = "PLACENI" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLight
        ElseIf DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("status").Index).Value.ToString = "ZAPLACANJE" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.Honeydew
        ElseIf DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("status").Index).Value.ToString = "VRACENO" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose
        Else
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.White
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
            DGV1.Columns("praznoD").MinimumWidth = 2
            DGV1.Columns("PraznoD").Width = 2
            DGV1.Columns("praznoB").MinimumWidth = 2
            DGV1.Columns("PraznoB").Width = 2

        End If

    End Sub

    Private Sub DGVRegBrMP_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs)
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

    Private Sub DGVRegBrMP_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs)
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim rtHeader As Rectangle = dgv.DisplayRectangle
        rtHeader.Height = dgv.ColumnHeadersHeight / 2
        dgv.Invalidate(rtHeader)
    End Sub

    Private Sub dgv_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DGV1.CellPainting

        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        If dgv.Name.Trim.ToUpper = "DGV1" Then
            'Call sredigrid(28, 4, dgv, e, "Zakazivanje posete / ponovnog dolaska", color1, Color.Black)
            'Call sredigrid(34, 1, dgv, e, "Unos i izmena napomene", color1, Color.Black)
            ''Call sredigrid(13, 11, dgv, e, "Poglavlja i moduli", color1, Color.Black)
            'Call sredigrid(37, 1, dgv, e, "Zahtev za doradu", color1, Color.Black)
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


    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick

        If e.ColumnIndex <> DGV1.Columns("Napomena").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("PoglOpstiPodaci").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("ZahtevZaPlacanje").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("ZahtevDorada").DisplayIndex Then
            Exit Sub
        End If
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        Else
            Call Dgv1CellContentClick(e.RowIndex, e.ColumnIndex)
        End If
    End Sub

    'Private Sub DGVRegBrMP_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRegBrMP.CellContentClick

    '    If e.ColumnIndex <> DGVRegBrMP.Columns("UNOS").DisplayIndex Then
    '        Exit Sub
    '    End If
    '    Call DgvRegBRMPCellContentClick(e.RowIndex, e.ColumnIndex)

    'End Sub

    Private lblOuter As Label = New Label()
    Private controlLocation As Point

    Private Sub panel_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelZahtevZaDoradu.MouseDown, panelNapomena.MouseDown, panelRaspodela.MouseDown, panelRaspodelaNA.MouseDown
        sender.Parent.Controls.Add(lblOuter)
        controlLocation = e.Location
        sender.cursor = Cursors.SizeAll
    End Sub
    Private Sub panel_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelZahtevZaDoradu.MouseMove, panelNapomena.MouseMove, panelRaspodela.MouseMove, panelRaspodelaNA.MouseMove
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
    Private Sub panel_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelZahtevZaDoradu.MouseUp, panelNapomena.MouseUp, panelRaspodela.MouseUp, panelRaspodelaNA.MouseUp
        sender.Parent.Controls.remove(lblOuter)
        sender.cursor = Cursors.Default
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

    Private Sub rbPlaceni_CheckedChanged(sender As Object, e As EventArgs) Handles rbPlaceni.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, "PLACENI")
    End Sub

    Private Sub rbZaPlacanje_CheckedChanged(sender As Object, e As EventArgs) Handles rbZaPlacanje.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, "ZAPLACANJE")
    End Sub

    Private Sub rbVraceno_CheckedChanged(sender As Object, e As EventArgs) Handles rbVraceno.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, "VRACENO")
    End Sub

    Private Sub rbSve_CheckedChanged(sender As Object, e As EventArgs) Handles rbSve.CheckedChanged
        Call refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, "SVE")
    End Sub

    Private Sub llPonisti_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPonisti.LinkClicked

        Dim filterStatus As String = ""
        If rbPlaceni.Checked = True Then
            filterStatus = "PLACENI"
        ElseIf rbZaPlacanje.Checked = True Then
            filterStatus = "ZAPLACANJE"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If
        filtNaseljeee.Text = ""
        filtPig.Text = ""
        filtPopisivac.Text = "*"
        'SetCueText(filtPig, "🔎 ")
        refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)

    End Sub


    Private Sub DGV1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentDoubleClick
        Dim aa As String = ""
        If 2 = 2 Then

        End If
    End Sub

    Private Sub rbZahtevOdbijen_Click(sender As Object, e As EventArgs) Handles rbZahtevOdbijen.Click
        If rbZahtevOdbijen.Checked = True Then
            tboxRazlogZahtev.Enabled = True
        ElseIf rbZahtevOdbijen.Checked = False Then
            tboxRazlogZahtev.Text = ""
            tboxRazlogZahtev.Enabled = False
        End If
    End Sub

    Private Sub rbZahtevOdobren_Click(sender As Object, e As EventArgs) Handles rbZahtevOdobren.Click
        If rbZahtevOdobren.Checked = True Then
            tboxRazlogZahtev.Enabled = False
        ElseIf rbZahtevOdobren.Checked = False Then
            tboxRazlogZahtev.Enabled = True
        End If
    End Sub

    Private Sub btnZahtevOK_Click(sender As Object, e As EventArgs) Handles btnZahtevOK.Click

        Dim kojired As Integer = DGV1.SelectedRows(0).Index
        '    " (case when isnull(a.statusAnketar,0)=3 then N'🖐' when isnull(a.statusAnketar,0)=2 then N'✉' else '' end ) as ZahtevDorada, a.napomenaStatusAnketar RazlogZahteva, " + nvrd +

        Dim status As String = DGV1.Rows(kojired).Cells(DGV1.Columns("status").Index).Value.ToString.Trim.ToUpper

        If DGV1.Rows(kojired).Cells(DGV1.Columns("ZahtevDorada").Index).Value.ToString.Trim = "🖐" Then

            If rbZahtevOdobren.Checked = False AndAlso rbZahtevOdbijen.Checked = False Then
                ISTMessageBox.Show("Morate čekirati jednu od opcija - Odobravam ili Ne odobravam zahtev -")
                Exit Sub
            End If

            If rbZahtevOdobren.Checked = True Then

                If status = "ZAPLACANJE" Then
                    Dim msgtxt As String = "Da li ste sigurni da želite ovaj upitnik vratiti na doradu?" + nvrd +
                                      "Status - Spreman za plaćanje - će automatski biti poništen!"
                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim opc2 As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle, 2)
                            Select Case opc2
                                Case "Da"
                                    Dim sql1 As String = "update " + kojiadresar + " set statusanketar=0, user_statusanketar=N'" + kosam + "', DATE_statusAnketar=getdate(), capiexported=1, statuskontrolornivo1=0 where pig='" + tboxZahtevPig.Text.Trim + "' and rbr=" + tboxZahtevRbr.Text.Trim + ""
                                    Dim ok1 As String = izvrsiSQL(sql1, DBConnectionString)
                                    If ok1 <> "ok" Then
                                        ISTMessageBox.Show("Greška 555! Pozovite administratora!")
                                        Exit Sub
                                    End If
                                Case "Ne"
                                    Exit Sub
                                Case "Cancel"
                                    Me.Cursor = Cursors.Default
                                    Exit Sub
                            End Select
                        Case "Ne"
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select
                Else
                    Dim sql1 As String = "update " + kojiadresar + " set statusanketar=0, user_statusanketar=N'" + kosam + "', DATE_statusAnketar=getdate(), capiexported=1 where pig='" + tboxZahtevPig.Text.Trim + "' and rbr=" + tboxZahtevRbr.Text.Trim + ""
                    Dim ok1 As String = izvrsiSQL(sql1, DBConnectionString)
                    If ok1 <> "ok" Then
                        ISTMessageBox.Show("Greška 444! Pozovite administratora!")
                        Exit Sub
                    End If
                End If

            End If

            If rbZahtevOdbijen.Checked = True Then
                If tboxRazlogZahtev.Text.Trim = "" Then
                    ISTMessageBox.Show("Morate upisati razlog!")
                    tboxRazlogZahtev.Focus()
                    Exit Sub
                ElseIf tboxRazlogZahtev.Text.Trim.Length < 5 Then
                    ISTMessageBox.Show("Morate upisati detaljniji razlog!")
                    tboxRazlogZahtev.Focus()
                    Exit Sub
                End If

                Dim sql1 As String = "update " + kojiadresar + " set statusanketar=2, user_statusanketar=N'" + kosam + "', DATE_statusAnketar=getdate(), napomenaKontrolorNivo1=N'" + tboxRazlogZahtev.Text + "'  where pig='" + tboxZahtevPig.Text.Trim + "' and rbr=" + tboxZahtevRbr.Text.Trim + ""
                Dim ok1 As String = izvrsiSQL(sql1, DBConnectionString)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show("Greška 557! Pozovite administratora!")
                    Exit Sub
                End If
            End If


        ElseIf DGV1.Rows(kojired).Cells(DGV1.Columns("ZahtevDorada").Index).Value.ToString.Trim = "✉" Then

            If tbRazlogVracanja.Text.Trim = "" Then
                ISTMessageBox.Show("Morate upisati razlog vraćanja na doradu!")
                tbRazlogVracanja.Focus()
                Exit Sub
            ElseIf tbRazlogVracanja.Text.Trim.Length < 5 Then
                ISTMessageBox.Show("Morate upisati detaljniji razlog vraćanja na doradu!")
                tbRazlogVracanja.Focus()
                Exit Sub
            Else


                If status = "ZAPLACANJE" Then
                    Dim msgtxt As String = "Da li ste sigurni da želite ovaj upitnik vratiti na doradu?" + nvrd +
                                      "Status - Spreman za plaćanje - će automatski biti poništen!"
                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Da"
                            Dim opc2 As String = customDialogResult({"Da", "Ne"}, msgtxt, msgtitle, 2)
                            Select Case opc2
                                Case "Da"
                                    Dim sql1 As String = "update " + kojiadresar + " set statusanketar=0, user_statusanketar=N'" + kosam + "', DATE_statusAnketar=getdate(), capiexported=1, statuskontrolornivo1=0, napomenaKontrolorNivo1=N'" + tbRazlogVracanja.Text + "'  where pig='" + tboxZahtevPig.Text.Trim + "' and rbr=" + tboxZahtevRbr.Text.Trim + ""
                                    Dim ok1 As String = izvrsiSQL(sql1, DBConnectionString)
                                    If ok1 <> "ok" Then
                                        ISTMessageBox.Show("Greška 411! Pozovite administratora!")
                                        Exit Sub
                                    End If
                                Case "Ne"
                                    Exit Sub
                                Case "Cancel"
                                    Me.Cursor = Cursors.Default
                                    Exit Sub
                            End Select
                        Case "Ne"
                            Exit Sub
                        Case "Cancel"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select
                Else
                    Dim sql1 As String = "update " + kojiadresar + " set statusanketar=0, user_statusanketar=N'" + kosam + "', DATE_statusAnketar=getdate(), capiexported=1, napomenaKontrolorNivo1=N'" + tbRazlogVracanja.Text + "'  where pig='" + tboxZahtevPig.Text.Trim + "' and rbr=" + tboxZahtevRbr.Text.Trim + ""
                    Dim ok1 As String = izvrsiSQL(sql1, DBConnectionString)
                    If ok1 <> "ok" Then
                        ISTMessageBox.Show("Greška 412! Pozovite administratora!")
                        Exit Sub
                    End If
                End If

            End If

        End If

        Dim filterStatus As String = ""
        If rbPlaceni.Checked = True Then
            filterStatus = "PLACENI"
        ElseIf rbZaPlacanje.Checked = True Then
            filterStatus = "ZAPLACANJE"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If

        refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)

        Call pZahNonVisible()


    End Sub

    Private Sub btnZahtevCancel_Click(sender As Object, e As EventArgs) Handles btnZahtevCancel.Click
        Call pZahNonVisible()
    End Sub

    Private Sub btnNapomenaOK_Click(sender As Object, e As EventArgs) Handles btnNapomenaOK.Click

        If tboxNapomenaNapomena.Text.Trim = "" Then
            ISTMessageBox.Show("Morate upisati napomenu, ili zatvorite prozor!")
            tboxNapomenaNapomena.Focus()
            Exit Sub
        Else
            Dim sql1 As String = "update " + kojiadresar + " set istnote=N'" + tboxNapomenaNapomena.Text + "' , ko_UPDATE=N'" + kosam + "' , datum_UPDATE = getdate() where pig='" + tboxNapomenaPIG.Text.Trim + "' and rbr=" + tboxNapomenaRBR.Text.Trim + ""
            Dim ok1 As String = izvrsiSQL(sql1, DBConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show("Greška 888! Pozovite administratora!")
                Exit Sub
            End If
        End If

        Dim filterStatus As String = ""
        If rbPlaceni.Checked = True Then
            filterStatus = "PLACENI"
        ElseIf rbZaPlacanje.Checked = True Then
            filterStatus = "ZAPLACANJE"
        ElseIf rbVraceno.Checked = True Then
            filterStatus = "VRACENO"
        ElseIf rbSve.Checked = True Then
            filterStatus = "SVE"
        End If

        refreshDGV1(filtNaseljeee.Text, filtPig.Text, filtPopisivac.Text.Trim, filterStatus)

        Call p3NonVisible()


    End Sub

    Private Sub btnNapomenaCancel_Click(sender As Object, e As EventArgs) Handles btnNapomenaCancel.Click

        Call p3NonVisible()

    End Sub

    Private Sub btnRaspodela_Click(sender As Object, e As EventArgs) Handles btnRaspodela.Click

        Call pRaspodelaVisible()

    End Sub

    Private Sub btnRaspodelaCancel_Click(sender As Object, e As EventArgs) Handles btnRaspodelaCancel.Click

        Call pRaspodelaNonVisible()

    End Sub

    Dim KojaRaspodela As String = ""
    Private Sub btnRaspodelaNA_Click(sender As Object, e As EventArgs) Handles btnRaspodelaNA.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'Call popunicbo(cbOdKogaNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' order by 1", Me.DBConnectionString, False, False, True, True)
        'cbOdKogaNA.TabStop = False

        'Call popunicbo(cbKomeNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' order by 1", Me.DBConnectionString, False, False, True, True)
        'cbKomeNA.TabStop = False
        KojaRaspodela = "NA"
        pRaspodelaNAVisible("NA")
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub


    Private Sub btnRaspodelaAA_Click(sender As Object, e As EventArgs) Handles btnRaspodelaAA.Click


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'Call popunicbo(cbOdKogaNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' order by 1", Me.DBConnectionString, False, False, True, True)
        'cbOdKogaNA.TabStop = False

        'Call popunicbo(cbKomeNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' order by 1", Me.DBConnectionString, False, False, True, True)
        'cbKomeNA.TabStop = False
        KojaRaspodela = "AA"
        pRaspodelaNAVisible("AA")

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub


    Private Sub btnRaspodelaNACancel_Click(sender As Object, e As EventArgs) Handles btnRaspodelaNACancel.Click
        KojaRaspodela = ""
        selektovanipigovi = ""
        pRaspodelaNANonVisible()

    End Sub

    Private Sub btnRaspodelaNAOK_Click(sender As Object, e As EventArgs) Handles btnRaspodelaNAOK.Click

        If KojaRaspodela = "NA" Then

        ElseIf KojaRaspodela = "AA" Then
            Dim str As String = ""

            For i As Integer = 0 To dgvNA.Rows.Count - 1
                If dgvNA.Rows(i).Cells(dgvNA.Columns("ZaRaspodelu").Index).Value.ToString.Trim.ToUpper = "TRUE" Then
                    str = str + "insert into RaspodelaAktivanAktivan ( AnketarOd, AnketarDo, PIG, RBR ,ZavrsenoAnk1 ,ZavrsenoAnk2, DateInsert) select N'" + cbOdKogaNA.SelectedValue.ToString.Trim + "', " + nvrd +
                                " N'" + cbKomeNA.SelectedValue.ToString.Trim + "', '" + dgvNA.Rows(i).Cells(dgvNA.Columns("PIG").Index).Value.ToString.Trim.ToUpper + "', " + nvrd +
                                " " + dgvNA.Rows(i).Cells(dgvNA.Columns("RBR").Index).Value.ToString.Trim.ToUpper + ", 0, 0, getdate(); " + nvrd + nvrd
                End If
            Next
            If str.Trim <> "" Then
                Dim ok As String = izvrsiSQL(str, DBConnectionString)
                If ok <> "ok" Then
                    ISTMessageBox.Show("Dogodila se greška, kontaktirajte administratora! ERROR 878.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                ISTMessageBox.Show("Uspešno ste preraspodelili materijal!")
                pRaspodelaNANonVisible()
                KojaRaspodela = ""
                selektovanipigovi = ""
            Else
                ISTMessageBox.Show("Morate obeležiti gazdinstva koja želite da prebacite ili izađite iz opcije Raspodela klikom na dugme CANCEL!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If


        End If



    End Sub

    Private Sub dgvNA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNA.CellContentClick


        If e.ColumnIndex <> dgvNA.Columns("ZaRaspodelu").DisplayIndex Then
            Exit Sub
        Else
            Call DgvNaCellContentClick(e.RowIndex, e.ColumnIndex)
        End If

    End Sub

    Private Sub btnNastaviNA_Click(sender As Object, e As EventArgs) Handles btnNastaviNA.Click

        Dim overlayHandle As ISTFormIsLoading
        overlayHandle = New ISTFormIsLoading(Me, Me.gbRaspodelaNA.Parent)
        overlayHandle.Show()

        If cbOdKogaNA.Text.Trim = "" OrElse cbKomeNA.Text.Trim = "" Then
            ISTMessageBox.Show("Morate izabrati popisivača od kog oduzimate materijal i popisivača kome dodeljujete materijal!")
            Exit Sub
        End If
        refreshDGVNA(selektovanipigovi, KojaRaspodela)
        If KojaRaspodela = "AA" Then
            cbCekirajSveNA.Visible = False
        ElseIf KojaRaspodela = "NA" Then
            cbCekirajSveNA.Checked = False
            cbCekirajSveNA.Visible = True
        End If
        If KojaRaspodela.ToUpper.Trim = "" Then
        Else

        End If
        selektovanipigovi = ""
        'gbRaspodelaNA.Enabled = False
        disablegbRaspodela()
        gbGazdinstvaRaspodelaNA.Enabled = True
        gbGazdinstvaRaspodelaNA.Visible = True
        overlayHandle.Close()
    End Sub

    Sub DgvNaCellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)

        Me.Cursor = Cursors.WaitCursor

        If erowindex >= 0 Then
            dgvNA.ClearSelection()
            dgvNA.Rows(erowindex).Selected = True
            If dgvNA.Columns(eColumnIndex).DisplayIndex = dgvNA.Columns("ZaRaspodelu").DisplayIndex Then

                If cbCekirajSveNA.Checked = True Then
                    selektovanipigovi = ""
                    Dim overlayHandle As ISTFormIsLoading
                    overlayHandle = New ISTFormIsLoading(Me, Me.gbRaspodelaNA.Parent)
                    overlayHandle.Show()

                    For i As Integer = 0 To dgvNA.Rows.Count - 1
                        If i <> erowindex Then
                            selektovanipigovi = selektovanipigovi + ",'" + dgvNA.Rows(i).Cells(dgvNA.Columns("PIG").Index).Value.ToString.Trim + dgvNA.Rows(i).Cells(dgvNA.Columns("RBR").Index).Value.ToString.Trim + "'"
                        End If
                    Next
                    selektovanipigovi = selektovanipigovi.Replace(",'',", ",")
                    selektovanipigovi = selektovanipigovi.Replace("'',", "")
                    selektovanipigovi = selektovanipigovi.TrimStart(",")
                    cbCekirajSveNA.Checked = False
                    'cbCekirajSveNA.Enabled = True
                    overlayHandle.Close()
                Else
                    If dgvNA.Rows(erowindex).Cells(dgvNA.Columns("ZaRaspodelu").Index).Value.ToString.Trim.ToUpper = "FALSE" Then
                        selektovanipigovi = selektovanipigovi + ",'" + dgvNA.Rows(erowindex).Cells(dgvNA.Columns("PIG").Index).Value.ToString.Trim + dgvNA.Rows(erowindex).Cells(dgvNA.Columns("RBR").Index).Value.ToString.Trim + "'"
                        selektovanipigovi = selektovanipigovi.TrimStart(",")
                    Else
                        selektovanipigovi = selektovanipigovi + ",'" + dgvNA.Rows(erowindex).Cells(dgvNA.Columns("PIG").Index).Value.ToString.Trim + dgvNA.Rows(erowindex).Cells(dgvNA.Columns("RBR").Index).Value.ToString.Trim + "'"
                        selektovanipigovi = selektovanipigovi.Replace(dgvNA.Rows(erowindex).Cells(dgvNA.Columns("PIG").Index).Value.ToString.Trim + dgvNA.Rows(erowindex).Cells(dgvNA.Columns("RBR").Index).Value.ToString.Trim, "")
                        selektovanipigovi = selektovanipigovi.Replace(",'',", ",")
                        selektovanipigovi = selektovanipigovi.Replace("'',", "")
                        selektovanipigovi = selektovanipigovi.TrimStart(",")
                    End If

                End If

                refreshDGVNA(selektovanipigovi, KojaRaspodela)
                Dim postojiNecekiran As Boolean = False
                For j As Integer = 0 To dtNA.Rows.Count - 1
                    If dtNA.Rows(j).Item("ZaRaspodelu") = "FALSE" Then
                        postojiNeCekiran = True
                        Exit For
                    End If
                Next
                If postojiNecekiran = False Then
                    bezporuke = True
                    cbCekirajSveNA.Checked = True
                    'cbCekirajSveNA.Enabled = False
                    bezporuke = False
                Else
                    bezporuke = True
                    cbCekirajSveNA.Checked = False
                    'cbCekirajSveNA.Enabled = True
                    bezporuke = False
                End If
            End If


            End If

        Me.Cursor = Cursors.Default

    End Sub

    Dim bezporuke As Boolean = False

    Private Sub cbCekirajSveNA_CheckedChanged(sender As Object, e As EventArgs) Handles cbCekirajSveNA.CheckedChanged

        If bezporuke = False Then
            If cbCekirajSveNA.Checked = True Then
                Dim opc As String = customDialogResult({"Da", "Ne"}, "Da li ste sigurni da želite da obeležite sva gazdinstva?", "Potvrdite")
                Select Case opc
                    Case "Da"
                        Dim opc2 As String = customDialogResult({"Da", "Ne"}, "Da li ste sigurni da želite da obeležite sva gazdinstva?", "Potvrdite")
                        Select Case opc2
                            Case "Da"
                                refreshDGVNA("", "NA", True)
                            Case "Ne"
                                cbCekirajSveNA.Checked = False
                                Exit Sub
                            Case "Cancel"
                                cbCekirajSveNA.Checked = False
                                Me.Cursor = Cursors.Default
                                Exit Sub
                        End Select
                    Case "Ne"
                        cbCekirajSveNA.Checked = False
                        Exit Sub
                    Case "Cancel"
                        cbCekirajSveNA.Checked = False
                        Me.Cursor = Cursors.Default
                        Exit Sub
                End Select
                'cbCekirajSveNA.Enabled = False
            Else
                refreshDGVNA("", "NA", False)
                Exit Sub
            End If
        Else
            If cbCekirajSveNA.Checked = True Then
                refreshDGVNA("", "NA", True)
            Else
                cbCekirajSveNA.Checked = False
                refreshDGVNA("", "NA", False)
                Exit Sub
            End If

        End If


        bezporuke = False

    End Sub




    'Private Sub cbOdKogaNA_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbOdKogaNA.SelectedValueChanged
    '    cbKomeNA.SelectedValue = ""
    '    cbKomeNA.SelectedText = ""
    '    cbKomeNA.Text = ""

    '    Dim pom As String = ""

    '    If cbOdKogaNA.SelectedValue Is Nothing Then
    '        pom = ""
    '    Else
    '        pom = cbOdKogaNA.SelectedValue.ToString.Trim
    '    End If

    '    Call popunicbo(cbKomeNA, "select distinct Anketar+' - '+ImeAnketar as displaymember, anketar as valuemember from Veza_Ank_Kont_Po where OpstinskiKoor=N'" + kosam + "' and anketar<>N'" + pom + "' order by 1", Me.DBConnectionString, False, False, True, True)
    '    cbKomeNA.TabStop = False
    'End Sub








    'Private Sub cbListZahtev_ItemCheck(sender As Object, e As ItemCheckEventArgs)
    '    If cbListZahtev.CheckedItems.Item(0) = True Then
    '        tboxZahtevRazlog.Enabled = False
    '    ElseIf cbListZahtev.CheckedItems.Item(1) = True Then
    '        tboxZahtevRazlog.Enabled = True
    '    End If
    'End Sub
End Class

