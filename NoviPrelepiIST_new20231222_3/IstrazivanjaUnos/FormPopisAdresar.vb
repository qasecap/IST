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

Public Class FormPopisAdresar
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
    'Dim vrtacka As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents lblPK As System.Windows.Forms.Label
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblNapomena As Label
    Friend WithEvents lblLong As Label
    Friend WithEvents lblLat As Label
    Friend WithEvents lblKucniBroj As Label
    Friend WithEvents tboxNapomenaOKucnomBroju As TextBox
    Friend WithEvents tboxLongituda As TextBox
    Friend WithEvents tboxLatituda As TextBox
    Friend WithEvents tboxkbr As TextBox
    Friend WithEvents lblUlicaKbroj As Label
    Friend WithEvents tbox1A As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonUnosNovogKBR As Button
    Friend WithEvents ButtonDodajAdr As Button
    Friend WithEvents tboxSource As TextBox
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents tboxKucniBR As TextBox
    Friend WithEvents LabelKucniBR As Label
    Friend WithEvents tboxIDULICE As TextBox
    Friend WithEvents LabelLongituda As Label
    Friend WithEvents TextBoxLong As TextBox
    Friend WithEvents LabelLatituda As Label
    Friend WithEvents TextBoxLat As TextBox
    Friend WithEvents MinLongituda As TextBox
    Friend WithEvents MaxLatituda As TextBox
    Friend WithEvents MaxLongituda As TextBox
    Friend WithEvents MinLatituda As TextBox
    Friend WithEvents ButtonNastavi As Button
    Friend WithEvents lblUlica As Label
    Friend WithEvents PanelNUl As Panel
    Friend WithEvents tboxKucniBrIDCD As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents ButtonResetPK As Button
    Friend WithEvents DGV2 As DataGridView
    Friend WithEvents DGV3 As DataGridView
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PanelZakazivanjeStana As Panel
    Friend WithEvents dtpDatumDolaska As ComboBox
    Friend WithEvents lblDatumDolaska As Label
    Friend WithEvents txtkucni_broj_idCD As TextBox
    Friend WithEvents lblBrojStanaVrataPoruka As Label
    Friend WithEvents LabelZNapomena As Label
    Friend WithEvents p1 As Panel
    Friend WithEvents txtUlica As TextBox
    Friend WithEvents txtKBroj As TextBox
    Friend WithEvents txtRbrStan As TextBox
    Friend WithEvents p2 As Panel
    Friend WithEvents dtpZakazanoVreme As ComboBox
    Friend WithEvents dtpZakazanoDatum As ComboBox
    Friend WithEvents LabelPopunite As Label
    Friend WithEvents cbDolazak As CheckBox
    Friend WithEvents cbTelefon As CheckBox
    Friend WithEvents LabelNacinAnk As Label
    Friend WithEvents LabelZDatum As Label
    Friend WithEvents LabelKontaktO As Label
    Friend WithEvents txtBrojTelefona As TextBox
    Friend WithEvents txtKontaktOsoba As TextBox
    Friend WithEvents LabelZVreme As Label
    Friend WithEvents lblBrojStanaVrata As Label
    Friend WithEvents txtBrojStanaVrata As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonSave2 As Button
    Friend WithEvents txtIshodNapomena As TextBox
    Friend WithEvents ButtonIzlaz As Button
    Friend WithEvents PanelZahtev As Panel
    Friend WithEvents cbZahtev As CheckBox
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
    Friend WithEvents PanelLegendaDGV1 As Panel
    Friend WithEvents lblPencil As Label
    Friend WithEvents lblHouse As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents LegendaHouse As TextBox
    Friend WithEvents LegendaPencil As TextBox
    Friend WithEvents LegendaDelete As TextBox
    Friend WithEvents lblDelete As Label
    Friend WithEvents PanelLegendaDGV2 As Panel
    Friend WithEvents lblLegenda2 As Label
    Friend WithEvents lblText2 As Label
    Friend WithEvents lblHand As Label
    Friend WithEvents LegendaHand As TextBox
    Friend WithEvents LegendaPeople As TextBox
    Friend WithEvents LegendaPencil2 As TextBox
    Friend WithEvents lblPeople As Label
    Friend WithEvents lblPenacil2 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents LegendaRed As TextBox
    Friend WithEvents LegendaGrey As TextBox
    Friend WithEvents LegendaGreen As TextBox
    Friend WithEvents LegendaPgreen As TextBox
    Friend WithEvents LegendaYellow As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblYellow As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents LegendaPhone As TextBox
    Friend WithEvents legendaFtoF As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblFtoF As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPin As Label
    Friend WithEvents LegendaPin As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt4 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents llOVDE As LinkLabel
    Friend WithEvents PanelIzmenaNazivaNoveUlice As Panel
    Friend WithEvents PanelIzmenaUL As Panel
    Friend WithEvents ButtonIzmenaULCancel As Button
    Friend WithEvents ButtonIzmenaULOK As Button
    Friend WithEvents lblNNUlice As Label
    Friend WithEvents txtSNUlice As Label
    Friend WithEvents lblSNUlice As Label
    Friend WithEvents txtNNUlice As TextBox
    Friend WithEvents lbUlice As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LblOps As Label
    Friend WithEvents LblObjasnjenje As Label
    Friend WithEvents btnLegenda1M As Button
    Friend WithEvents btnLegenda2M As Button
    Friend WithEvents lblNKBRUUlici As Label
    Friend WithEvents textboxUlica As TextBox
    Friend WithEvents textboxIDUlice As TextBox
    Friend WithEvents textboxIDUliceNNaziv As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tboxNovaUlica As TextBox
    Friend WithEvents ButtonUnosNoveUlice As Button
    Friend WithEvents PanelSpisakUlica As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents LBSpisakUL As ListBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ButtonSpisakUlica As Button
    Friend WithEvents LBNUlSpisak As ListBox
    Friend WithEvents ButtonNeDodajAdr As Button
    Friend WithEvents lblnaselje As Label
    Friend WithEvents BtnZatvori As Button
    Friend WithEvents ButtonIzvestaji As Button
    Friend WithEvents ButtonLK As Button
    Friend WithEvents PanelNapomenaStan As Panel
    Friend WithEvents txtkucni_broj_idCDNapomena As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents txtBrojStanaVrataNapomena As TextBox
    Friend WithEvents txtUlicaNapomena As TextBox
    Friend WithEvents txtKBrojNapomena As TextBox
    Friend WithEvents txtRbrStanNapomena As TextBox
    Friend WithEvents btnCancelNapomenaStan As Button
    Friend WithEvents btnOKNapomenaStan As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtNapomenaStan As TextBox
    Friend WithEvents txtkrug_idCDNapomena As TextBox
    Friend WithEvents ButtonZakazani As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents LabelTel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb7 As RadioButton
    Friend WithEvents rb6 As RadioButton
    Friend WithEvents rb5 As RadioButton
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PanelNapomenaLica As Panel
    Friend WithEvents TxtKrugIDCDLica As TextBox
    Friend WithEvents TxtKbrIDCDLica As TextBox
    Friend WithEvents PodpanelNapomenaLica As Panel
    Friend WithEvents TxtRBrLicaNapomenaLica As TextBox
    Friend WithEvents LblRbLicaNapomenaLica As Label
    Friend WithEvents LblRbrStVrataNapomenaLica As Label
    Friend WithEvents TxtRbrStVrataNapomenaLica As TextBox
    Friend WithEvents TxtUlicaKbrNapomenaLica As TextBox
    Friend WithEvents TxtRbrStNapomenaLica As TextBox
    Friend WithEvents BtnCancNapomenaLica As Button
    Friend WithEvents BtnOkNapomenaLica As Button
    Friend WithEvents LblNapomenaLica As Label
    Friend WithEvents TxtNapomenaLica As TextBox
    Friend WithEvents TxtIDULICELica As TextBox
    Friend WithEvents TxtMBOPSLica As TextBox
    Friend WithEvents TxtImeNapomenaLica As TextBox
    Friend WithEvents LblImeLicaNapomenaLica As Label
    Friend WithEvents LblRbrStana2 As Label
    Friend WithEvents PanelLegendaDGV3 As Panel
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents BtnSvaLica As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblkojikont As Label
    Friend WithEvents LblRbrDomNapomenaLica As Label
    Friend WithEvents TxtRbrDomNapomenaLica As TextBox
    Friend WithEvents lblBrojKBR As Label
    Friend WithEvents PanelUklanjanje As Panel
    Friend WithEvents cmbRazlogUklanjanja As ComboBox
    Friend WithEvents lblRazlogUklanjanja As Label
    Friend WithEvents lblObjasnjenjeUklanjanja As Label
    Friend WithEvents tboxObjasnjenjeUklanjanja As TextBox
    Friend WithEvents lblUklonitiIzMaterijala As Label
    Friend WithEvents cbUklonitiIzMaterijala As CheckBox
    Friend WithEvents btnMapa As Button
    Friend WithEvents btnMapaKbr As Button
    Friend WithEvents llNastavi As LinkLabel
    Friend WithEvents gbKBR As GroupBox
    Friend WithEvents llNastaviUL As LinkLabel
    Friend WithEvents btnMapaKbrUL As Button
    Friend WithEvents gbKBRUL As GroupBox
    Friend WithEvents btnMapaIzmenaKBR As Button
    Friend WithEvents LabelUkLica As Label
    Friend WithEvents txtUkupanBrLica As TextBox
    Friend WithEvents lblPapir As Label
    Friend WithEvents LegendaPapir As TextBox
    Friend WithEvents cbPonistiZak As CheckBox
    Friend WithEvents chbZavrsenKrug As CheckBox
    Friend WithEvents btnVracanjeKrugova As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents PanelPKDorada As Panel
    Friend WithEvents gbPKVrati As GroupBox
    Friend WithEvents cmbVratiPK As ComboBox
    Friend WithEvents txtVratiPK As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents btnCancelPKDorada As Button
    Friend WithEvents btnOKPKDorada As Button
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents lblAdresa As Label
    Friend WithEvents lblAdr As Label
    Friend WithEvents lableAdresa As Label
    Friend WithEvents lblrbrs As Label
    Friend WithEvents Labeladr As Label
    Friend WithEvents lblTrazeniNaDoradu As Label
    Friend WithEvents txtMBOPS As TextBox
    Friend WithEvents txtKrug As TextBox
    Friend WithEvents labelsToolTip As ToolTip
    Friend WithEvents btnInformation As Button
    Friend WithEvents ButtonResetUl As Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPopisAdresar))
        Me.lblPK = New System.Windows.Forms.Label()
        Me.ButtonResetPK = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMapaIzmenaKBR = New System.Windows.Forms.Button()
        Me.llNastavi = New System.Windows.Forms.LinkLabel()
        Me.btnMapaKbr = New System.Windows.Forms.Button()
        Me.textboxIDUlice = New System.Windows.Forms.TextBox()
        Me.lblNKBRUUlici = New System.Windows.Forms.Label()
        Me.textboxUlica = New System.Windows.Forms.TextBox()
        Me.tboxKucniBrIDCD = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.tboxSource = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblKucniBroj = New System.Windows.Forms.Label()
        Me.tboxkbr = New System.Windows.Forms.TextBox()
        Me.gbKBR = New System.Windows.Forms.GroupBox()
        Me.tboxNapomenaOKucnomBroju = New System.Windows.Forms.TextBox()
        Me.tboxLatituda = New System.Windows.Forms.TextBox()
        Me.tboxLongituda = New System.Windows.Forms.TextBox()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.lblNapomena = New System.Windows.Forms.Label()
        Me.tbox1A = New System.Windows.Forms.TextBox()
        Me.lblUlicaKbroj = New System.Windows.Forms.Label()
        Me.PanelZahtev = New System.Windows.Forms.Panel()
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
        Me.cbZahtev = New System.Windows.Forms.CheckBox()
        Me.ButtonCancelZahtev = New System.Windows.Forms.Button()
        Me.ButtonZahtev = New System.Windows.Forms.Button()
        Me.LabelRazlog = New System.Windows.Forms.Label()
        Me.tboxNapomenaStatusAnketar = New System.Windows.Forms.TextBox()
        Me.ButtonUnosNovogKBR = New System.Windows.Forms.Button()
        Me.ButtonDodajAdr = New System.Windows.Forms.Button()
        Me.tboxKucniBR = New System.Windows.Forms.TextBox()
        Me.LabelKucniBR = New System.Windows.Forms.Label()
        Me.tboxIDULICE = New System.Windows.Forms.TextBox()
        Me.LabelLongituda = New System.Windows.Forms.Label()
        Me.TextBoxLong = New System.Windows.Forms.TextBox()
        Me.LabelLatituda = New System.Windows.Forms.Label()
        Me.TextBoxLat = New System.Windows.Forms.TextBox()
        Me.MinLongituda = New System.Windows.Forms.TextBox()
        Me.MaxLatituda = New System.Windows.Forms.TextBox()
        Me.MaxLongituda = New System.Windows.Forms.TextBox()
        Me.MinLatituda = New System.Windows.Forms.TextBox()
        Me.ButtonNastavi = New System.Windows.Forms.Button()
        Me.lblUlica = New System.Windows.Forms.Label()
        Me.PanelNUl = New System.Windows.Forms.Panel()
        Me.llNastaviUL = New System.Windows.Forms.LinkLabel()
        Me.btnMapaKbrUL = New System.Windows.Forms.Button()
        Me.ButtonNeDodajAdr = New System.Windows.Forms.Button()
        Me.LBNUlSpisak = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tboxNovaUlica = New System.Windows.Forms.TextBox()
        Me.gbKBRUL = New System.Windows.Forms.GroupBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.DGV2 = New System.Windows.Forms.DataGridView()
        Me.DGV3 = New System.Windows.Forms.DataGridView()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PanelZakazivanjeStana = New System.Windows.Forms.Panel()
        Me.txtMBOPS = New System.Windows.Forms.TextBox()
        Me.txtKrug = New System.Windows.Forms.TextBox()
        Me.cbPonistiZak = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb7 = New System.Windows.Forms.RadioButton()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.txtKBroj = New System.Windows.Forms.TextBox()
        Me.dtpDatumDolaska = New System.Windows.Forms.ComboBox()
        Me.lblDatumDolaska = New System.Windows.Forms.Label()
        Me.txtkucni_broj_idCD = New System.Windows.Forms.TextBox()
        Me.lblBrojStanaVrataPoruka = New System.Windows.Forms.Label()
        Me.LabelZNapomena = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.Panel()
        Me.lblAdresa = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUlica = New System.Windows.Forms.TextBox()
        Me.txtRbrStan = New System.Windows.Forms.TextBox()
        Me.p2 = New System.Windows.Forms.Panel()
        Me.LabelUkLica = New System.Windows.Forms.Label()
        Me.txtUkupanBrLica = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelTel = New System.Windows.Forms.Label()
        Me.dtpZakazanoVreme = New System.Windows.Forms.ComboBox()
        Me.dtpZakazanoDatum = New System.Windows.Forms.ComboBox()
        Me.LabelPopunite = New System.Windows.Forms.Label()
        Me.cbDolazak = New System.Windows.Forms.CheckBox()
        Me.cbTelefon = New System.Windows.Forms.CheckBox()
        Me.LabelNacinAnk = New System.Windows.Forms.Label()
        Me.LabelZDatum = New System.Windows.Forms.Label()
        Me.LabelKontaktO = New System.Windows.Forms.Label()
        Me.txtBrojTelefona = New System.Windows.Forms.TextBox()
        Me.txtKontaktOsoba = New System.Windows.Forms.TextBox()
        Me.LabelZVreme = New System.Windows.Forms.Label()
        Me.lblBrojStanaVrata = New System.Windows.Forms.Label()
        Me.txtBrojStanaVrata = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonSave2 = New System.Windows.Forms.Button()
        Me.txtIshodNapomena = New System.Windows.Forms.TextBox()
        Me.ButtonIzlaz = New System.Windows.Forms.Button()
        Me.PanelLegendaDGV1 = New System.Windows.Forms.Panel()
        Me.btnLegenda1M = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt4 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDelete = New System.Windows.Forms.Label()
        Me.LegendaDelete = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPin = New System.Windows.Forms.Label()
        Me.LegendaPin = New System.Windows.Forms.TextBox()
        Me.LegendaPencil = New System.Windows.Forms.TextBox()
        Me.LegendaHouse = New System.Windows.Forms.TextBox()
        Me.lblPencil = New System.Windows.Forms.Label()
        Me.lblHouse = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PanelLegendaDGV2 = New System.Windows.Forms.Panel()
        Me.lblHand = New System.Windows.Forms.Label()
        Me.LegendaPapir = New System.Windows.Forms.TextBox()
        Me.LegendaHand = New System.Windows.Forms.TextBox()
        Me.legendaFtoF = New System.Windows.Forms.TextBox()
        Me.lblPapir = New System.Windows.Forms.Label()
        Me.LegendaPeople = New System.Windows.Forms.TextBox()
        Me.LegendaPencil2 = New System.Windows.Forms.TextBox()
        Me.btnLegenda2M = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LegendaPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblFtoF = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblYellow = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LegendaRed = New System.Windows.Forms.TextBox()
        Me.LegendaGrey = New System.Windows.Forms.TextBox()
        Me.LegendaGreen = New System.Windows.Forms.TextBox()
        Me.LegendaPgreen = New System.Windows.Forms.TextBox()
        Me.LegendaYellow = New System.Windows.Forms.TextBox()
        Me.lblLegenda2 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.lblPeople = New System.Windows.Forms.Label()
        Me.lblPenacil2 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.llOVDE = New System.Windows.Forms.LinkLabel()
        Me.PanelIzmenaNazivaNoveUlice = New System.Windows.Forms.Panel()
        Me.PanelIzmenaUL = New System.Windows.Forms.Panel()
        Me.textboxIDUliceNNaziv = New System.Windows.Forms.TextBox()
        Me.LblObjasnjenje = New System.Windows.Forms.Label()
        Me.lbUlice = New System.Windows.Forms.ListBox()
        Me.txtNNUlice = New System.Windows.Forms.TextBox()
        Me.lblSNUlice = New System.Windows.Forms.Label()
        Me.txtSNUlice = New System.Windows.Forms.Label()
        Me.ButtonIzmenaULCancel = New System.Windows.Forms.Button()
        Me.ButtonIzmenaULOK = New System.Windows.Forms.Button()
        Me.lblNNUlice = New System.Windows.Forms.Label()
        Me.LblOps = New System.Windows.Forms.Label()
        Me.ButtonUnosNoveUlice = New System.Windows.Forms.Button()
        Me.PanelSpisakUlica = New System.Windows.Forms.Panel()
        Me.BtnZatvori = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBSpisakUL = New System.Windows.Forms.ListBox()
        Me.ButtonSpisakUlica = New System.Windows.Forms.Button()
        Me.lblnaselje = New System.Windows.Forms.Label()
        Me.ButtonResetUl = New System.Windows.Forms.Button()
        Me.ButtonIzvestaji = New System.Windows.Forms.Button()
        Me.ButtonLK = New System.Windows.Forms.Button()
        Me.PanelNapomenaStan = New System.Windows.Forms.Panel()
        Me.txtkrug_idCDNapomena = New System.Windows.Forms.TextBox()
        Me.txtkucni_broj_idCDNapomena = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBrojStanaVrataNapomena = New System.Windows.Forms.TextBox()
        Me.txtUlicaNapomena = New System.Windows.Forms.TextBox()
        Me.txtKBrojNapomena = New System.Windows.Forms.TextBox()
        Me.txtRbrStanNapomena = New System.Windows.Forms.TextBox()
        Me.btnCancelNapomenaStan = New System.Windows.Forms.Button()
        Me.btnOKNapomenaStan = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtNapomenaStan = New System.Windows.Forms.TextBox()
        Me.ButtonZakazani = New System.Windows.Forms.Button()
        Me.PanelNapomenaLica = New System.Windows.Forms.Panel()
        Me.PanelUklanjanje = New System.Windows.Forms.Panel()
        Me.lblObjasnjenjeUklanjanja = New System.Windows.Forms.Label()
        Me.tboxObjasnjenjeUklanjanja = New System.Windows.Forms.TextBox()
        Me.cmbRazlogUklanjanja = New System.Windows.Forms.ComboBox()
        Me.lblRazlogUklanjanja = New System.Windows.Forms.Label()
        Me.lblUklonitiIzMaterijala = New System.Windows.Forms.Label()
        Me.cbUklonitiIzMaterijala = New System.Windows.Forms.CheckBox()
        Me.TxtIDULICELica = New System.Windows.Forms.TextBox()
        Me.TxtMBOPSLica = New System.Windows.Forms.TextBox()
        Me.TxtKrugIDCDLica = New System.Windows.Forms.TextBox()
        Me.TxtKbrIDCDLica = New System.Windows.Forms.TextBox()
        Me.PodpanelNapomenaLica = New System.Windows.Forms.Panel()
        Me.lableAdresa = New System.Windows.Forms.Label()
        Me.LblRbrDomNapomenaLica = New System.Windows.Forms.Label()
        Me.TxtRbrDomNapomenaLica = New System.Windows.Forms.TextBox()
        Me.LblRbrStana2 = New System.Windows.Forms.Label()
        Me.TxtImeNapomenaLica = New System.Windows.Forms.TextBox()
        Me.LblImeLicaNapomenaLica = New System.Windows.Forms.Label()
        Me.TxtRBrLicaNapomenaLica = New System.Windows.Forms.TextBox()
        Me.LblRbLicaNapomenaLica = New System.Windows.Forms.Label()
        Me.LblRbrStVrataNapomenaLica = New System.Windows.Forms.Label()
        Me.TxtRbrStVrataNapomenaLica = New System.Windows.Forms.TextBox()
        Me.TxtUlicaKbrNapomenaLica = New System.Windows.Forms.TextBox()
        Me.TxtRbrStNapomenaLica = New System.Windows.Forms.TextBox()
        Me.BtnCancNapomenaLica = New System.Windows.Forms.Button()
        Me.BtnOkNapomenaLica = New System.Windows.Forms.Button()
        Me.LblNapomenaLica = New System.Windows.Forms.Label()
        Me.TxtNapomenaLica = New System.Windows.Forms.TextBox()
        Me.PanelLegendaDGV3 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.BtnSvaLica = New System.Windows.Forms.Button()
        Me.lblBrojKBR = New System.Windows.Forms.Label()
        Me.btnMapa = New System.Windows.Forms.Button()
        Me.chbZavrsenKrug = New System.Windows.Forms.CheckBox()
        Me.btnVracanjeKrugova = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Labeladr = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.PanelPKDorada = New System.Windows.Forms.Panel()
        Me.lblTrazeniNaDoradu = New System.Windows.Forms.Label()
        Me.gbPKVrati = New System.Windows.Forms.GroupBox()
        Me.cmbVratiPK = New System.Windows.Forms.ComboBox()
        Me.txtVratiPK = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnCancelPKDorada = New System.Windows.Forms.Button()
        Me.btnOKPKDorada = New System.Windows.Forms.Button()
        Me.labelsToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnInformation = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbKBR.SuspendLayout()
        Me.PanelZahtev.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelNUl.SuspendLayout()
        Me.gbKBRUL.SuspendLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PanelZakazivanjeStana.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.PanelLegendaDGV1.SuspendLayout()
        Me.PanelLegendaDGV2.SuspendLayout()
        Me.PanelIzmenaNazivaNoveUlice.SuspendLayout()
        Me.PanelIzmenaUL.SuspendLayout()
        Me.PanelSpisakUlica.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelNapomenaStan.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.PanelNapomenaLica.SuspendLayout()
        Me.PanelUklanjanje.SuspendLayout()
        Me.PodpanelNapomenaLica.SuspendLayout()
        Me.PanelLegendaDGV3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.PanelPKDorada.SuspendLayout()
        Me.gbPKVrati.SuspendLayout()
        Me.SuspendLayout()

        '
        'lblPK
        '
        Me.lblPK.AutoSize = True
        Me.lblPK.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPK.Location = New System.Drawing.Point(5, 35)
        Me.lblPK.Name = "lblPK"
        Me.lblPK.Size = New System.Drawing.Size(84, 14)
        Me.lblPK.TabIndex = 18
        Me.lblPK.Text = "Popisni krug"
        '
        'ButtonResetPK
        '
        Me.ButtonResetPK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonResetPK.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonResetPK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonResetPK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonResetPK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResetPK.Location = New System.Drawing.Point(1159, 32)
        Me.ButtonResetPK.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonResetPK.Name = "ButtonResetPK"
        Me.ButtonResetPK.Size = New System.Drawing.Size(227, 26)
        Me.ButtonResetPK.TabIndex = 7
        Me.ButtonResetPK.TabStop = False
        Me.ButtonResetPK.Text = "Povratak na izbor popisnog kruga"
        Me.ButtonResetPK.UseVisualStyleBackColor = False
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
        Me.DGV1.Size = New System.Drawing.Size(491, 250)
        Me.DGV1.TabIndex = 350
        Me.DGV1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnMapaIzmenaKBR)
        Me.Panel3.Controls.Add(Me.llNastavi)
        Me.Panel3.Controls.Add(Me.btnMapaKbr)
        Me.Panel3.Controls.Add(Me.textboxIDUlice)
        Me.Panel3.Controls.Add(Me.lblNKBRUUlici)
        Me.Panel3.Controls.Add(Me.textboxUlica)
        Me.Panel3.Controls.Add(Me.tboxKucniBrIDCD)
        Me.Panel3.Controls.Add(Me.ButtonCancel)
        Me.Panel3.Controls.Add(Me.tboxSource)
        Me.Panel3.Controls.Add(Me.ButtonSave)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.lblKucniBroj)
        Me.Panel3.Controls.Add(Me.tboxkbr)
        Me.Panel3.Controls.Add(Me.gbKBR)
        Me.Panel3.Location = New System.Drawing.Point(67, 757)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(495, 358)
        Me.Panel3.TabIndex = 50
        Me.Panel3.Visible = False
        '
        'btnMapaIzmenaKBR
        '
        Me.btnMapaIzmenaKBR.BackColor = System.Drawing.SystemColors.Control
        Me.btnMapaIzmenaKBR.Enabled = False
        Me.btnMapaIzmenaKBR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMapaIzmenaKBR.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnMapaIzmenaKBR.Location = New System.Drawing.Point(181, 61)
        Me.btnMapaIzmenaKBR.Name = "btnMapaIzmenaKBR"
        Me.btnMapaIzmenaKBR.Size = New System.Drawing.Size(283, 22)
        Me.btnMapaIzmenaKBR.TabIndex = 10000064
        Me.btnMapaIzmenaKBR.TabStop = False
        Me.btnMapaIzmenaKBR.Text = "Izmena lokacije kućnog broja na mapi"
        Me.btnMapaIzmenaKBR.UseVisualStyleBackColor = False
        Me.btnMapaIzmenaKBR.Visible = False
        '
        'llNastavi
        '
        Me.llNastavi.AutoSize = True
        Me.llNastavi.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNastavi.Location = New System.Drawing.Point(400, 88)
        Me.llNastavi.Name = "llNastavi"
        Me.llNastavi.Size = New System.Drawing.Size(64, 18)
        Me.llNastavi.TabIndex = 10000062
        Me.llNastavi.TabStop = True
        Me.llNastavi.Text = "Nastavi"
        Me.llNastavi.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnMapaKbr
        '
        Me.btnMapaKbr.BackColor = System.Drawing.SystemColors.Control
        Me.btnMapaKbr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMapaKbr.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnMapaKbr.Location = New System.Drawing.Point(181, 64)
        Me.btnMapaKbr.Name = "btnMapaKbr"
        Me.btnMapaKbr.Size = New System.Drawing.Size(283, 22)
        Me.btnMapaKbr.TabIndex = 10000061
        Me.btnMapaKbr.Text = "Dodaj novi kućni broj na mapu"
        Me.btnMapaKbr.UseVisualStyleBackColor = False
        '
        'textboxIDUlice
        '
        Me.textboxIDUlice.Enabled = False
        Me.textboxIDUlice.Location = New System.Drawing.Point(10, 329)
        Me.textboxIDUlice.Name = "textboxIDUlice"
        Me.textboxIDUlice.Size = New System.Drawing.Size(47, 22)
        Me.textboxIDUlice.TabIndex = 10000060
        Me.textboxIDUlice.Visible = False
        '
        'lblNKBRUUlici
        '
        Me.lblNKBRUUlici.Location = New System.Drawing.Point(-1, 9)
        Me.lblNKBRUUlici.Name = "lblNKBRUUlici"
        Me.lblNKBRUUlici.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNKBRUUlici.Size = New System.Drawing.Size(176, 15)
        Me.lblNKBRUUlici.TabIndex = 10000059
        Me.lblNKBRUUlici.Text = "Ulica"
        '
        'textboxUlica
        '
        Me.textboxUlica.AccessibleName = "CONVERTCIRLAT"
        Me.textboxUlica.Enabled = False
        Me.textboxUlica.Location = New System.Drawing.Point(181, 7)
        Me.textboxUlica.MaxLength = 19
        Me.textboxUlica.Name = "textboxUlica"
        Me.textboxUlica.Size = New System.Drawing.Size(283, 22)
        Me.textboxUlica.TabIndex = 10000058
        '
        'tboxKucniBrIDCD
        '
        Me.tboxKucniBrIDCD.Location = New System.Drawing.Point(63, 329)
        Me.tboxKucniBrIDCD.Name = "tboxKucniBrIDCD"
        Me.tboxKucniBrIDCD.Size = New System.Drawing.Size(47, 22)
        Me.tboxKucniBrIDCD.TabIndex = 64
        Me.tboxKucniBrIDCD.Visible = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCancel.Location = New System.Drawing.Point(269, 327)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(90, 24)
        Me.ButtonCancel.TabIndex = 70
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'tboxSource
        '
        Me.tboxSource.Enabled = False
        Me.tboxSource.Location = New System.Drawing.Point(116, 329)
        Me.tboxSource.Name = "tboxSource"
        Me.tboxSource.Size = New System.Drawing.Size(50, 22)
        Me.tboxSource.TabIndex = 62
        Me.tboxSource.Visible = False
        '
        'ButtonSave
        '
        Me.ButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSave.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonSave.Location = New System.Drawing.Point(374, 327)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(90, 24)
        Me.ButtonSave.TabIndex = 65
        Me.ButtonSave.Text = "OK"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(172, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 14)
        Me.Label12.TabIndex = 60
        Me.Label12.Text = "."
        Me.Label12.Visible = False
        '
        'lblKucniBroj
        '
        Me.lblKucniBroj.Location = New System.Drawing.Point(114, 36)
        Me.lblKucniBroj.Name = "lblKucniBroj"
        Me.lblKucniBroj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblKucniBroj.Size = New System.Drawing.Size(61, 14)
        Me.lblKucniBroj.TabIndex = 51
        Me.lblKucniBroj.Text = "Kućni broj"
        '
        'tboxkbr
        '
        Me.tboxkbr.AccessibleName = "CONVERTCIRLAT"
        Me.tboxkbr.Location = New System.Drawing.Point(181, 36)
        Me.tboxkbr.MaxLength = 19
        Me.tboxkbr.Name = "tboxkbr"
        Me.tboxkbr.Size = New System.Drawing.Size(283, 22)
        Me.tboxkbr.TabIndex = 40
        '
        'gbKBR
        '
        Me.gbKBR.Controls.Add(Me.tboxNapomenaOKucnomBroju)
        Me.gbKBR.Controls.Add(Me.tboxLatituda)
        Me.gbKBR.Controls.Add(Me.tboxLongituda)
        Me.gbKBR.Controls.Add(Me.lblLat)
        Me.gbKBR.Controls.Add(Me.lblLong)
        Me.gbKBR.Controls.Add(Me.lblNapomena)
        Me.gbKBR.Controls.Add(Me.tbox1A)
        Me.gbKBR.Controls.Add(Me.lblUlicaKbroj)
        Me.gbKBR.Location = New System.Drawing.Point(10, 101)
        Me.gbKBR.Name = "gbKBR"
        Me.gbKBR.Size = New System.Drawing.Size(465, 223)
        Me.gbKBR.TabIndex = 10000063
        Me.gbKBR.TabStop = False
        '
        'tboxNapomenaOKucnomBroju
        '
        Me.tboxNapomenaOKucnomBroju.Location = New System.Drawing.Point(171, 96)
        Me.tboxNapomenaOKucnomBroju.MaxLength = 500
        Me.tboxNapomenaOKucnomBroju.Multiline = True
        Me.tboxNapomenaOKucnomBroju.Name = "tboxNapomenaOKucnomBroju"
        Me.tboxNapomenaOKucnomBroju.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tboxNapomenaOKucnomBroju.Size = New System.Drawing.Size(283, 119)
        Me.tboxNapomenaOKucnomBroju.TabIndex = 60
        '
        'tboxLatituda
        '
        Me.tboxLatituda.Enabled = False
        Me.tboxLatituda.Location = New System.Drawing.Point(171, 71)
        Me.tboxLatituda.Name = "tboxLatituda"
        Me.tboxLatituda.Size = New System.Drawing.Size(283, 22)
        Me.tboxLatituda.TabIndex = 55
        '
        'tboxLongituda
        '
        Me.tboxLongituda.Enabled = False
        Me.tboxLongituda.Location = New System.Drawing.Point(171, 45)
        Me.tboxLongituda.Name = "tboxLongituda"
        Me.tboxLongituda.Size = New System.Drawing.Size(283, 22)
        Me.tboxLongituda.TabIndex = 50
        '
        'lblLat
        '
        Me.lblLat.Location = New System.Drawing.Point(80, 71)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblLat.Size = New System.Drawing.Size(85, 15)
        Me.lblLat.TabIndex = 55
        Me.lblLat.Text = "Latituda"
        '
        'lblLong
        '
        Me.lblLong.Location = New System.Drawing.Point(80, 47)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblLong.Size = New System.Drawing.Size(85, 13)
        Me.lblLong.TabIndex = 56
        Me.lblLong.Text = "Longituda"
        '
        'lblNapomena
        '
        Me.lblNapomena.Location = New System.Drawing.Point(80, 96)
        Me.lblNapomena.Name = "lblNapomena"
        Me.lblNapomena.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNapomena.Size = New System.Drawing.Size(85, 14)
        Me.lblNapomena.TabIndex = 57
        Me.lblNapomena.Text = "Napomena"
        '
        'tbox1A
        '
        Me.tbox1A.Enabled = False
        Me.tbox1A.Location = New System.Drawing.Point(171, 21)
        Me.tbox1A.Name = "tbox1A"
        Me.tbox1A.Size = New System.Drawing.Size(283, 22)
        Me.tbox1A.TabIndex = 45
        '
        'lblUlicaKbroj
        '
        Me.lblUlicaKbroj.Location = New System.Drawing.Point(23, 21)
        Me.lblUlicaKbroj.Name = "lblUlicaKbroj"
        Me.lblUlicaKbroj.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblUlicaKbroj.Size = New System.Drawing.Size(142, 14)
        Me.lblUlicaKbroj.TabIndex = 58
        Me.lblUlicaKbroj.Text = "Adresa na terenu"
        Me.lblUlicaKbroj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelZahtev
        '
        Me.PanelZahtev.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelZahtev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelZahtev.Controls.Add(Me.lblkojikont)
        Me.PanelZahtev.Controls.Add(Me.txtkucni_broj_idCDZahtev)
        Me.PanelZahtev.Controls.Add(Me.Panel1)
        Me.PanelZahtev.Controls.Add(Me.cbZahtev)
        Me.PanelZahtev.Controls.Add(Me.ButtonCancelZahtev)
        Me.PanelZahtev.Controls.Add(Me.ButtonZahtev)
        Me.PanelZahtev.Controls.Add(Me.LabelRazlog)
        Me.PanelZahtev.Controls.Add(Me.tboxNapomenaStatusAnketar)
        Me.PanelZahtev.Location = New System.Drawing.Point(158, 690)
        Me.PanelZahtev.Name = "PanelZahtev"
        Me.PanelZahtev.Size = New System.Drawing.Size(643, 269)
        Me.PanelZahtev.TabIndex = 1018
        Me.PanelZahtev.Visible = False
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
        Me.txtkucni_broj_idCDZahtev.Size = New System.Drawing.Size(142, 22)
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
        Me.txtBrojStanaVratazahtev.Size = New System.Drawing.Size(132, 22)
        Me.txtBrojStanaVratazahtev.TabIndex = 10000064
        '
        'txtUlicaZahtev
        '
        Me.txtUlicaZahtev.Location = New System.Drawing.Point(164, 8)
        Me.txtUlicaZahtev.Name = "txtUlicaZahtev"
        Me.txtUlicaZahtev.Size = New System.Drawing.Size(323, 22)
        Me.txtUlicaZahtev.TabIndex = 51
        '
        'txtKBrojZahtev
        '
        Me.txtKBrojZahtev.Location = New System.Drawing.Point(407, 8)
        Me.txtKBrojZahtev.Name = "txtKBrojZahtev"
        Me.txtKBrojZahtev.Size = New System.Drawing.Size(79, 22)
        Me.txtKBrojZahtev.TabIndex = 65
        Me.txtKBrojZahtev.Visible = False
        '
        'txtRbrStanZahtev
        '
        Me.txtRbrStanZahtev.Location = New System.Drawing.Point(567, 8)
        Me.txtRbrStanZahtev.Name = "txtRbrStanZahtev"
        Me.txtRbrStanZahtev.Size = New System.Drawing.Size(56, 22)
        Me.txtRbrStanZahtev.TabIndex = 67
        '
        'cbZahtev
        '
        Me.cbZahtev.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.cbZahtev.AutoSize = True
        Me.cbZahtev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbZahtev.Location = New System.Drawing.Point(330, 86)
        Me.cbZahtev.Name = "cbZahtev"
        Me.cbZahtev.Size = New System.Drawing.Size(304, 18)
        Me.cbZahtev.TabIndex = 10000058
        Me.cbZahtev.Tag = "1"
        Me.cbZahtev.Text = "Zahtev popisivača za doradu poslatog stana"
        Me.cbZahtev.UseVisualStyleBackColor = True
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
        'ButtonUnosNovogKBR
        '
        Me.ButtonUnosNovogKBR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonUnosNovogKBR.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonUnosNovogKBR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonUnosNovogKBR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUnosNovogKBR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnosNovogKBR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonUnosNovogKBR.Location = New System.Drawing.Point(7, 272)
        Me.ButtonUnosNovogKBR.Name = "ButtonUnosNovogKBR"
        Me.ButtonUnosNovogKBR.Size = New System.Drawing.Size(180, 22)
        Me.ButtonUnosNovogKBR.TabIndex = 25
        Me.ButtonUnosNovogKBR.Text = "Unos novog kućnog broja"
        Me.ButtonUnosNovogKBR.UseVisualStyleBackColor = False
        Me.ButtonUnosNovogKBR.Visible = False
        '
        'ButtonDodajAdr
        '
        Me.ButtonDodajAdr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonDodajAdr.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonDodajAdr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDodajAdr.Enabled = False
        Me.ButtonDodajAdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDodajAdr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDodajAdr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonDodajAdr.Location = New System.Drawing.Point(266, 363)
        Me.ButtonDodajAdr.Name = "ButtonDodajAdr"
        Me.ButtonDodajAdr.Size = New System.Drawing.Size(90, 24)
        Me.ButtonDodajAdr.TabIndex = 20
        Me.ButtonDodajAdr.Text = "OK"
        Me.ButtonDodajAdr.UseVisualStyleBackColor = False
        '
        'tboxKucniBR
        '
        Me.tboxKucniBR.AccessibleName = "CONVERTCIRLAT"
        Me.tboxKucniBR.Location = New System.Drawing.Point(122, 30)
        Me.tboxKucniBR.MaxLength = 19
        Me.tboxKucniBR.Name = "tboxKucniBR"
        Me.tboxKucniBR.Size = New System.Drawing.Size(232, 22)
        Me.tboxKucniBR.TabIndex = 4
        '
        'LabelKucniBR
        '
        Me.LabelKucniBR.AutoSize = True
        Me.LabelKucniBR.Location = New System.Drawing.Point(27, 33)
        Me.LabelKucniBR.Name = "LabelKucniBR"
        Me.LabelKucniBR.Size = New System.Drawing.Size(69, 14)
        Me.LabelKucniBR.TabIndex = 66
        Me.LabelKucniBR.Text = "Kućni broj"
        '
        'tboxIDULICE
        '
        Me.tboxIDULICE.Location = New System.Drawing.Point(440, 160)
        Me.tboxIDULICE.Name = "tboxIDULICE"
        Me.tboxIDULICE.Size = New System.Drawing.Size(102, 22)
        Me.tboxIDULICE.TabIndex = 850
        Me.tboxIDULICE.Visible = False
        '
        'LabelLongituda
        '
        Me.LabelLongituda.AutoSize = True
        Me.LabelLongituda.Location = New System.Drawing.Point(11, 21)
        Me.LabelLongituda.Name = "LabelLongituda"
        Me.LabelLongituda.Size = New System.Drawing.Size(70, 14)
        Me.LabelLongituda.TabIndex = 68
        Me.LabelLongituda.Text = "Longituda"
        '
        'TextBoxLong
        '
        Me.TextBoxLong.Enabled = False
        Me.TextBoxLong.Location = New System.Drawing.Point(106, 21)
        Me.TextBoxLong.Name = "TextBoxLong"
        Me.TextBoxLong.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxLong.TabIndex = 10
        '
        'LabelLatituda
        '
        Me.LabelLatituda.AutoSize = True
        Me.LabelLatituda.Location = New System.Drawing.Point(11, 47)
        Me.LabelLatituda.Name = "LabelLatituda"
        Me.LabelLatituda.Size = New System.Drawing.Size(59, 14)
        Me.LabelLatituda.TabIndex = 70
        Me.LabelLatituda.Text = "Latituda"
        '
        'TextBoxLat
        '
        Me.TextBoxLat.Enabled = False
        Me.TextBoxLat.Location = New System.Drawing.Point(106, 50)
        Me.TextBoxLat.Name = "TextBoxLat"
        Me.TextBoxLat.Size = New System.Drawing.Size(232, 22)
        Me.TextBoxLat.TabIndex = 15
        '
        'MinLongituda
        '
        Me.MinLongituda.Location = New System.Drawing.Point(337, 114)
        Me.MinLongituda.Name = "MinLongituda"
        Me.MinLongituda.Size = New System.Drawing.Size(102, 22)
        Me.MinLongituda.TabIndex = 500
        Me.MinLongituda.Visible = False
        '
        'MaxLatituda
        '
        Me.MaxLatituda.Location = New System.Drawing.Point(440, 114)
        Me.MaxLatituda.Name = "MaxLatituda"
        Me.MaxLatituda.Size = New System.Drawing.Size(102, 22)
        Me.MaxLatituda.TabIndex = 600
        Me.MaxLatituda.Visible = False
        '
        'MaxLongituda
        '
        Me.MaxLongituda.Location = New System.Drawing.Point(337, 137)
        Me.MaxLongituda.Name = "MaxLongituda"
        Me.MaxLongituda.Size = New System.Drawing.Size(102, 22)
        Me.MaxLongituda.TabIndex = 700
        Me.MaxLongituda.Visible = False
        '
        'MinLatituda
        '
        Me.MinLatituda.Location = New System.Drawing.Point(440, 137)
        Me.MinLatituda.Name = "MinLatituda"
        Me.MinLatituda.Size = New System.Drawing.Size(102, 22)
        Me.MinLatituda.TabIndex = 800
        Me.MinLatituda.Visible = False
        '
        'ButtonNastavi
        '
        Me.ButtonNastavi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonNastavi.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNastavi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNastavi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNastavi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNastavi.Location = New System.Drawing.Point(125, 68)
        Me.ButtonNastavi.Name = "ButtonNastavi"
        Me.ButtonNastavi.Size = New System.Drawing.Size(94, 22)
        Me.ButtonNastavi.TabIndex = 5
        Me.ButtonNastavi.Text = "Potvrdi izbor"
        Me.ButtonNastavi.UseVisualStyleBackColor = False
        '
        'lblUlica
        '
        Me.lblUlica.AutoSize = True
        Me.lblUlica.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUlica.Location = New System.Drawing.Point(-1, 58)
        Me.lblUlica.Name = "lblUlica"
        Me.lblUlica.Size = New System.Drawing.Size(90, 14)
        Me.lblUlica.TabIndex = 77
        Me.lblUlica.Text = "Ulica na mapi"
        '
        'PanelNUl
        '
        Me.PanelNUl.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelNUl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNUl.Controls.Add(Me.llNastaviUL)
        Me.PanelNUl.Controls.Add(Me.btnMapaKbrUL)
        Me.PanelNUl.Controls.Add(Me.ButtonDodajAdr)
        Me.PanelNUl.Controls.Add(Me.ButtonNeDodajAdr)
        Me.PanelNUl.Controls.Add(Me.LBNUlSpisak)
        Me.PanelNUl.Controls.Add(Me.Label11)
        Me.PanelNUl.Controls.Add(Me.tboxNovaUlica)
        Me.PanelNUl.Controls.Add(Me.LabelKucniBR)
        Me.PanelNUl.Controls.Add(Me.tboxKucniBR)
        Me.PanelNUl.Controls.Add(Me.gbKBRUL)
        Me.PanelNUl.Location = New System.Drawing.Point(28, 95)
        Me.PanelNUl.Name = "PanelNUl"
        Me.PanelNUl.Size = New System.Drawing.Size(377, 396)
        Me.PanelNUl.TabIndex = 78
        Me.PanelNUl.Visible = False
        '
        'llNastaviUL
        '
        Me.llNastaviUL.AutoSize = True
        Me.llNastaviUL.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llNastaviUL.Location = New System.Drawing.Point(286, 263)
        Me.llNastaviUL.Name = "llNastaviUL"
        Me.llNastaviUL.Size = New System.Drawing.Size(64, 18)
        Me.llNastaviUL.TabIndex = 10000069
        Me.llNastaviUL.TabStop = True
        Me.llNastaviUL.Text = "Nastavi"
        Me.llNastaviUL.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'btnMapaKbrUL
        '
        Me.btnMapaKbrUL.BackColor = System.Drawing.SystemColors.Control
        Me.btnMapaKbrUL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMapaKbrUL.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnMapaKbrUL.Location = New System.Drawing.Point(25, 62)
        Me.btnMapaKbrUL.Name = "btnMapaKbrUL"
        Me.btnMapaKbrUL.Size = New System.Drawing.Size(328, 22)
        Me.btnMapaKbrUL.TabIndex = 10000068
        Me.btnMapaKbrUL.Text = "Dodaj novi kućni broj na mapu"
        Me.btnMapaKbrUL.UseVisualStyleBackColor = False
        '
        'ButtonNeDodajAdr
        '
        Me.ButtonNeDodajAdr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonNeDodajAdr.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNeDodajAdr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNeDodajAdr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonNeDodajAdr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNeDodajAdr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonNeDodajAdr.Location = New System.Drawing.Point(164, 363)
        Me.ButtonNeDodajAdr.Name = "ButtonNeDodajAdr"
        Me.ButtonNeDodajAdr.Size = New System.Drawing.Size(90, 24)
        Me.ButtonNeDodajAdr.TabIndex = 10000067
        Me.ButtonNeDodajAdr.Text = "Cancel"
        Me.ButtonNeDodajAdr.UseVisualStyleBackColor = False
        '
        'LBNUlSpisak
        '
        Me.LBNUlSpisak.BackColor = System.Drawing.Color.Gainsboro
        Me.LBNUlSpisak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBNUlSpisak.FormattingEnabled = True
        Me.LBNUlSpisak.ItemHeight = 14
        Me.LBNUlSpisak.Location = New System.Drawing.Point(25, 90)
        Me.LBNUlSpisak.Name = "LBNUlSpisak"
        Me.LBNUlSpisak.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LBNUlSpisak.Size = New System.Drawing.Size(325, 156)
        Me.LBNUlSpisak.TabIndex = 10000066
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 14)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Nova ulica"
        '
        'tboxNovaUlica
        '
        Me.tboxNovaUlica.AccessibleName = "CONVERTCIRLAT"
        Me.tboxNovaUlica.Location = New System.Drawing.Point(122, 4)
        Me.tboxNovaUlica.MaxLength = 40
        Me.tboxNovaUlica.Name = "tboxNovaUlica"
        Me.tboxNovaUlica.Size = New System.Drawing.Size(232, 22)
        Me.tboxNovaUlica.TabIndex = 3
        '
        'gbKBRUL
        '
        Me.gbKBRUL.Controls.Add(Me.TextBoxLat)
        Me.gbKBRUL.Controls.Add(Me.TextBoxLong)
        Me.gbKBRUL.Controls.Add(Me.LabelLongituda)
        Me.gbKBRUL.Controls.Add(Me.LabelLatituda)
        Me.gbKBRUL.Location = New System.Drawing.Point(12, 275)
        Me.gbKBRUL.Name = "gbKBRUL"
        Me.gbKBRUL.Size = New System.Drawing.Size(344, 85)
        Me.gbKBRUL.TabIndex = 10000070
        Me.gbKBRUL.TabStop = False
        Me.gbKBRUL.Visible = False
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
        'DGV2
        '
        Me.DGV2.AllowUserToAddRows = False
        Me.DGV2.AllowUserToDeleteRows = False
        Me.DGV2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV2.Location = New System.Drawing.Point(3, 3)
        Me.DGV2.MultiSelect = False
        Me.DGV2.Name = "DGV2"
        Me.DGV2.ReadOnly = True
        Me.DGV2.RowHeadersWidth = 30
        Me.DGV2.Size = New System.Drawing.Size(490, 250)
        Me.DGV2.TabIndex = 1011
        Me.DGV2.Visible = False
        '
        'DGV3
        '
        Me.DGV3.AllowUserToAddRows = False
        Me.DGV3.AllowUserToDeleteRows = False
        Me.DGV3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGV3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV3.Location = New System.Drawing.Point(0, 0)
        Me.DGV3.MultiSelect = False
        Me.DGV3.Name = "DGV3"
        Me.DGV3.ReadOnly = True
        Me.DGV3.RowHeadersWidth = 30
        Me.DGV3.Size = New System.Drawing.Size(204, 273)
        Me.DGV3.TabIndex = 10101
        Me.DGV3.Visible = False
        '
        'txt2
        '
        Me.txt2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt2.Location = New System.Drawing.Point(6, 10)
        Me.txt2.Multiline = True
        Me.txt2.Name = "txt2"
        Me.txt2.ReadOnly = True
        Me.txt2.Size = New System.Drawing.Size(490, 20)
        Me.txt2.TabIndex = 1012
        Me.txt2.TabStop = False
        Me.txt2.Tag = ""
        Me.txt2.Text = "..."
        Me.txt2.Visible = False
        '
        'txt3
        '
        Me.txt3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txt3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt3.Location = New System.Drawing.Point(6, 10)
        Me.txt3.Multiline = True
        Me.txt3.Name = "txt3"
        Me.txt3.ReadOnly = True
        Me.txt3.Size = New System.Drawing.Size(490, 20)
        Me.txt3.TabIndex = 1012
        Me.txt3.TabStop = False
        Me.txt3.Tag = ""
        Me.txt3.Text = "..."
        Me.txt3.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.TabControl1.Location = New System.Drawing.Point(5, 370)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(212, 300)
        Me.TabControl1.TabIndex = 1013
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
        Me.TabPage1.Size = New System.Drawing.Size(204, 273)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Unos/izmena podataka o zgradi"
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.DGV2)
        Me.TabPage2.Controls.Add(Me.txt2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(204, 273)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Unos/izmena podataka o stanu i ishoda poseta"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DGV3)
        Me.TabPage3.Controls.Add(Me.txt3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(204, 273)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Pregled i izmena podataka o licima"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PanelZakazivanjeStana
        '
        Me.PanelZakazivanjeStana.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelZakazivanjeStana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelZakazivanjeStana.Controls.Add(Me.txtMBOPS)
        Me.PanelZakazivanjeStana.Controls.Add(Me.txtKrug)
        Me.PanelZakazivanjeStana.Controls.Add(Me.cbPonistiZak)
        Me.PanelZakazivanjeStana.Controls.Add(Me.GroupBox1)
        Me.PanelZakazivanjeStana.Controls.Add(Me.txtKBroj)
        Me.PanelZakazivanjeStana.Controls.Add(Me.dtpDatumDolaska)
        Me.PanelZakazivanjeStana.Controls.Add(Me.lblDatumDolaska)
        Me.PanelZakazivanjeStana.Controls.Add(Me.txtkucni_broj_idCD)
        Me.PanelZakazivanjeStana.Controls.Add(Me.lblBrojStanaVrataPoruka)
        Me.PanelZakazivanjeStana.Controls.Add(Me.LabelZNapomena)
        Me.PanelZakazivanjeStana.Controls.Add(Me.p1)
        Me.PanelZakazivanjeStana.Controls.Add(Me.p2)
        Me.PanelZakazivanjeStana.Controls.Add(Me.lblBrojStanaVrata)
        Me.PanelZakazivanjeStana.Controls.Add(Me.txtBrojStanaVrata)
        Me.PanelZakazivanjeStana.Controls.Add(Me.Button2)
        Me.PanelZakazivanjeStana.Controls.Add(Me.TextBox1)
        Me.PanelZakazivanjeStana.Controls.Add(Me.ButtonSave2)
        Me.PanelZakazivanjeStana.Controls.Add(Me.txtIshodNapomena)
        Me.PanelZakazivanjeStana.Location = New System.Drawing.Point(477, 514)
        Me.PanelZakazivanjeStana.Name = "PanelZakazivanjeStana"
        Me.PanelZakazivanjeStana.Size = New System.Drawing.Size(814, 646)
        Me.PanelZakazivanjeStana.TabIndex = 1016
        Me.PanelZakazivanjeStana.Visible = False
        '
        'txtMBOPS
        '
        Me.txtMBOPS.Enabled = False
        Me.txtMBOPS.Location = New System.Drawing.Point(433, 610)
        Me.txtMBOPS.Name = "txtMBOPS"
        Me.txtMBOPS.Size = New System.Drawing.Size(52, 22)
        Me.txtMBOPS.TabIndex = 98
        Me.txtMBOPS.Visible = False
        '
        'txtKrug
        '
        Me.txtKrug.Enabled = False
        Me.txtKrug.Location = New System.Drawing.Point(285, 610)
        Me.txtKrug.Name = "txtKrug"
        Me.txtKrug.Size = New System.Drawing.Size(142, 22)
        Me.txtKrug.TabIndex = 97
        Me.txtKrug.Visible = False
        '
        'cbPonistiZak
        '
        Me.cbPonistiZak.AutoSize = True
        Me.cbPonistiZak.Font = New System.Drawing.Font("Verdana", 11.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPonistiZak.ForeColor = System.Drawing.Color.DarkRed
        Me.cbPonistiZak.Location = New System.Drawing.Point(11, 615)
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
        Me.GroupBox1.Controls.Add(Me.rb5)
        Me.GroupBox1.Controls.Add(Me.rb4)
        Me.GroupBox1.Controls.Add(Me.rb3)
        Me.GroupBox1.Controls.Add(Me.rb2)
        Me.GroupBox1.Controls.Add(Me.rb1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 165)
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
        Me.rb7.Location = New System.Drawing.Point(10, 145)
        Me.rb7.Name = "rb7"
        Me.rb7.Size = New System.Drawing.Size(407, 17)
        Me.rb7.TabIndex = 6
        Me.rb7.TabStop = True
        Me.rb7.Text = "7 - Nije ostvaren kontakt sa domaćinstvom ni posle više pokušaja "
        Me.rb7.UseVisualStyleBackColor = True
        '
        'rb6
        '
        Me.rb6.AutoSize = True
        Me.rb6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb6.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb6.Location = New System.Drawing.Point(10, 124)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(376, 17)
        Me.rb6.TabIndex = 5
        Me.rb6.TabStop = True
        Me.rb6.Text = "6 - Odbijanje (obrazložiti u Napomeni i obavestiti instruktora)"
        Me.rb6.UseVisualStyleBackColor = True
        '
        'rb5
        '
        Me.rb5.AutoSize = True
        Me.rb5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb5.Location = New System.Drawing.Point(10, 103)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(427, 17)
        Me.rb5.TabIndex = 4
        Me.rb5.TabStop = True
        Me.rb5.Text = "5 - Prekinuto popisivanje (dogovoren termin telefonskog popisivanja) "
        Me.rb5.UseVisualStyleBackColor = True
        '
        'rb4
        '
        Me.rb4.AutoSize = True
        Me.rb4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb4.Location = New System.Drawing.Point(10, 82)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(460, 17)
        Me.rb4.TabIndex = 3
        Me.rb4.TabStop = True
        Me.rb4.Text = "4 - Prekinuto popisivanje (dogovoren termin ponovnog dolaska popisivača) "
        Me.rb4.UseVisualStyleBackColor = True
        '
        'rb3
        '
        Me.rb3.AutoSize = True
        Me.rb3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb3.Location = New System.Drawing.Point(10, 61)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(288, 17)
        Me.rb3.TabIndex = 2
        Me.rb3.TabStop = True
        Me.rb3.Text = "3 - Dogovoren termin telefonskog popisivanja"
        Me.rb3.UseVisualStyleBackColor = True
        '
        'rb2
        '
        Me.rb2.AutoSize = True
        Me.rb2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rb2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.rb2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.rb2.Location = New System.Drawing.Point(10, 40)
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
        Me.rb1.Size = New System.Drawing.Size(790, 17)
        Me.rb1.TabIndex = 0
        Me.rb1.TabStop = True
        Me.rb1.Text = "1 - Ostavljeno obaveštenje o dolasku popisivača, obrazac P-11 (trenutno nema niko" &
    "ga u stanu/zatečeno lice ne može da da podatke)"
        Me.rb1.UseVisualStyleBackColor = True
        '
        'txtKBroj
        '
        Me.txtKBroj.Location = New System.Drawing.Point(16, 67)
        Me.txtKBroj.Name = "txtKBroj"
        Me.txtKBroj.Size = New System.Drawing.Size(61, 22)
        Me.txtKBroj.TabIndex = 65
        Me.txtKBroj.Visible = False
        '
        'dtpDatumDolaska
        '
        Me.dtpDatumDolaska.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.dtpDatumDolaska.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dtpDatumDolaska.CausesValidation = False
        Me.dtpDatumDolaska.FormattingEnabled = True
        Me.dtpDatumDolaska.Items.AddRange(New Object() {"01.10.2022", "02.10.2022", "03.10.2022", "04.10.2022", "05.10.2022", "06.10.2022", "07.10.2022", "08.10.2022", "09.10.2022", "10.10.2022", "11.10.2022", "12.10.2022", "13.10.2022", "14.10.2022", "15.10.2022", "16.10.2022", "17.10.2022", "18.10.2022", "19.10.2022", "20.10.2022", "21.10.2022", "22.10.2022", "23.10.2022", "24.10.2022", "25.10.2022", "26.10.2022", "27.10.2022", "28.10.2022", "29.10.2022", "30.10.2022", "31.10.2022", "01.11.2022", "02.11.2022", "03.11.2022", "04.11.2022", "05.11.2022", "06.11.2022", "07.11.2022", "08.11.2022", "09.11.2022", "10.11.2022", "11.11.2022", "12.11.2022", "13.11.2022", "14.11.2022", "15.11.2022", "", ""})
        Me.dtpDatumDolaska.Location = New System.Drawing.Point(375, 84)
        Me.dtpDatumDolaska.Name = "dtpDatumDolaska"
        Me.dtpDatumDolaska.Size = New System.Drawing.Size(170, 22)
        Me.dtpDatumDolaska.TabIndex = 93
        '
        'lblDatumDolaska
        '
        Me.lblDatumDolaska.AutoSize = True
        Me.lblDatumDolaska.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblDatumDolaska.Location = New System.Drawing.Point(270, 84)
        Me.lblDatumDolaska.Name = "lblDatumDolaska"
        Me.lblDatumDolaska.Size = New System.Drawing.Size(98, 14)
        Me.lblDatumDolaska.TabIndex = 92
        Me.lblDatumDolaska.Text = "Datum posete"
        '
        'txtkucni_broj_idCD
        '
        Me.txtkucni_broj_idCD.Enabled = False
        Me.txtkucni_broj_idCD.Location = New System.Drawing.Point(134, 610)
        Me.txtkucni_broj_idCD.Name = "txtkucni_broj_idCD"
        Me.txtkucni_broj_idCD.Size = New System.Drawing.Size(142, 22)
        Me.txtkucni_broj_idCD.TabIndex = 91
        Me.txtkucni_broj_idCD.Visible = False
        '
        'lblBrojStanaVrataPoruka
        '
        Me.lblBrojStanaVrataPoruka.AutoSize = True
        Me.lblBrojStanaVrataPoruka.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblBrojStanaVrataPoruka.Location = New System.Drawing.Point(481, 55)
        Me.lblBrojStanaVrataPoruka.Name = "lblBrojStanaVrataPoruka"
        Me.lblBrojStanaVrataPoruka.Size = New System.Drawing.Size(201, 14)
        Me.lblBrojStanaVrataPoruka.TabIndex = 90
        Me.lblBrojStanaVrataPoruka.Text = "Broj stana na vratima ne postoji"
        Me.lblBrojStanaVrataPoruka.Visible = False
        '
        'LabelZNapomena
        '
        Me.LabelZNapomena.AutoSize = True
        Me.LabelZNapomena.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelZNapomena.Location = New System.Drawing.Point(10, 469)
        Me.LabelZNapomena.Name = "LabelZNapomena"
        Me.LabelZNapomena.Size = New System.Drawing.Size(77, 14)
        Me.LabelZNapomena.TabIndex = 57
        Me.LabelZNapomena.Text = "Napomena"
        '
        'p1
        '
        Me.p1.Controls.Add(Me.lblAdresa)
        Me.p1.Controls.Add(Me.Label3)
        Me.p1.Controls.Add(Me.txtUlica)
        Me.p1.Controls.Add(Me.txtRbrStan)
        Me.p1.Enabled = False
        Me.p1.Location = New System.Drawing.Point(209, 6)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(599, 39)
        Me.p1.TabIndex = 68
        '
        'lblAdresa
        '
        Me.lblAdresa.AutoSize = True
        Me.lblAdresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblAdresa.Location = New System.Drawing.Point(106, 11)
        Me.lblAdresa.Name = "lblAdresa"
        Me.lblAdresa.Size = New System.Drawing.Size(53, 14)
        Me.lblAdresa.TabIndex = 97
        Me.lblAdresa.Text = "Adresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(481, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Rbr. stana"
        '
        'txtUlica
        '
        Me.txtUlica.Location = New System.Drawing.Point(166, 8)
        Me.txtUlica.Name = "txtUlica"
        Me.txtUlica.Size = New System.Drawing.Size(309, 22)
        Me.txtUlica.TabIndex = 51
        '
        'txtRbrStan
        '
        Me.txtRbrStan.Location = New System.Drawing.Point(557, 8)
        Me.txtRbrStan.Name = "txtRbrStan"
        Me.txtRbrStan.Size = New System.Drawing.Size(36, 22)
        Me.txtRbrStan.TabIndex = 67
        '
        'p2
        '
        Me.p2.Controls.Add(Me.LabelUkLica)
        Me.p2.Controls.Add(Me.txtUkupanBrLica)
        Me.p2.Controls.Add(Me.Label14)
        Me.p2.Controls.Add(Me.LabelTel)
        Me.p2.Controls.Add(Me.dtpZakazanoVreme)
        Me.p2.Controls.Add(Me.dtpZakazanoDatum)
        Me.p2.Controls.Add(Me.LabelPopunite)
        Me.p2.Controls.Add(Me.cbDolazak)
        Me.p2.Controls.Add(Me.cbTelefon)
        Me.p2.Controls.Add(Me.LabelNacinAnk)
        Me.p2.Controls.Add(Me.LabelZDatum)
        Me.p2.Controls.Add(Me.LabelKontaktO)
        Me.p2.Controls.Add(Me.txtBrojTelefona)
        Me.p2.Controls.Add(Me.txtKontaktOsoba)
        Me.p2.Controls.Add(Me.LabelZVreme)
        Me.p2.Location = New System.Drawing.Point(57, 277)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(751, 191)
        Me.p2.TabIndex = 68
        '
        'LabelUkLica
        '
        Me.LabelUkLica.Location = New System.Drawing.Point(225, 108)
        Me.LabelUkLica.Name = "LabelUkLica"
        Me.LabelUkLica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelUkLica.Size = New System.Drawing.Size(220, 20)
        Me.LabelUkLica.TabIndex = 91
        Me.LabelUkLica.Text = "Ukupan/očekivan broj lica u stanu "
        '
        'txtUkupanBrLica
        '
        Me.txtUkupanBrLica.Location = New System.Drawing.Point(452, 107)
        Me.txtUkupanBrLica.MaxLength = 2
        Me.txtUkupanBrLica.Name = "txtUkupanBrLica"
        Me.txtUkupanBrLica.Size = New System.Drawing.Size(283, 22)
        Me.txtUkupanBrLica.TabIndex = 90
        Me.txtUkupanBrLica.Tag = "3"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(575, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(173, 11)
        Me.Label14.TabIndex = 89
        Me.Label14.Text = "* Možete uneti samo brojeve"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LabelTel
        '
        Me.LabelTel.Location = New System.Drawing.Point(381, 83)
        Me.LabelTel.Name = "LabelTel"
        Me.LabelTel.Size = New System.Drawing.Size(65, 20)
        Me.LabelTel.TabIndex = 88
        Me.LabelTel.Text = "Telefon *"
        '
        'dtpZakazanoVreme
        '
        Me.dtpZakazanoVreme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.dtpZakazanoVreme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dtpZakazanoVreme.CausesValidation = False
        Me.dtpZakazanoVreme.FormattingEnabled = True
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
        Me.dtpZakazanoDatum.FormattingEnabled = True
        Me.dtpZakazanoDatum.Items.AddRange(New Object() {"01.10.2022", "02.10.2022", "03.10.2022", "04.10.2022", "05.10.2022", "06.10.2022", "07.10.2022", "08.10.2022", "09.10.2022", "10.10.2022", "11.10.2022", "12.10.2022", "13.10.2022", "14.10.2022", "15.10.2022", "16.10.2022", "17.10.2022", "18.10.2022", "19.10.2022", "20.10.2022", "21.10.2022", "22.10.2022", "23.10.2022", "24.10.2022", "25.10.2022", "26.10.2022", "27.10.2022", "28.10.2022", "29.10.2022", "30.10.2022", "31.10.2022", "01.11.2022", "02.11.2022", "03.11.2022", "04.11.2022", "05.11.2022", "06.11.2022", "07.11.2022", "08.11.2022", "09.11.2022", "10.11.2022", "11.11.2022", "12.11.2022", "13.11.2022", "14.11.2022", "15.11.2022", "", ""})
        Me.dtpZakazanoDatum.Location = New System.Drawing.Point(452, 7)
        Me.dtpZakazanoDatum.Name = "dtpZakazanoDatum"
        Me.dtpZakazanoDatum.Size = New System.Drawing.Size(283, 22)
        Me.dtpZakazanoDatum.TabIndex = 68
        '
        'LabelPopunite
        '
        Me.LabelPopunite.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelPopunite.Location = New System.Drawing.Point(81, 11)
        Me.LabelPopunite.Name = "LabelPopunite"
        Me.LabelPopunite.Size = New System.Drawing.Size(178, 29)
        Me.LabelPopunite.TabIndex = 84
        Me.LabelPopunite.Text = "Molim vas, popunite:"
        '
        'cbDolazak
        '
        Me.cbDolazak.AutoSize = True
        Me.cbDolazak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDolazak.Location = New System.Drawing.Point(452, 168)
        Me.cbDolazak.Name = "cbDolazak"
        Me.cbDolazak.Size = New System.Drawing.Size(73, 18)
        Me.cbDolazak.TabIndex = 83
        Me.cbDolazak.Tag = "2"
        Me.cbDolazak.Text = "Dolazak"
        Me.cbDolazak.UseVisualStyleBackColor = True
        '
        'cbTelefon
        '
        Me.cbTelefon.AutoSize = True
        Me.cbTelefon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTelefon.Location = New System.Drawing.Point(452, 149)
        Me.cbTelefon.Name = "cbTelefon"
        Me.cbTelefon.Size = New System.Drawing.Size(68, 18)
        Me.cbTelefon.TabIndex = 82
        Me.cbTelefon.Tag = "2"
        Me.cbTelefon.Text = "Telefon"
        Me.cbTelefon.UseVisualStyleBackColor = True
        '
        'LabelNacinAnk
        '
        Me.LabelNacinAnk.AutoSize = True
        Me.LabelNacinAnk.Location = New System.Drawing.Point(312, 149)
        Me.LabelNacinAnk.Name = "LabelNacinAnk"
        Me.LabelNacinAnk.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelNacinAnk.Size = New System.Drawing.Size(117, 14)
        Me.LabelNacinAnk.TabIndex = 72
        Me.LabelNacinAnk.Text = "Način popisivanja"
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
        'lblBrojStanaVrata
        '
        Me.lblBrojStanaVrata.AutoSize = True
        Me.lblBrojStanaVrata.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrojStanaVrata.Location = New System.Drawing.Point(218, 55)
        Me.lblBrojStanaVrata.Name = "lblBrojStanaVrata"
        Me.lblBrojStanaVrata.Size = New System.Drawing.Size(150, 14)
        Me.lblBrojStanaVrata.TabIndex = 68
        Me.lblBrojStanaVrata.Text = "Broj stana na vratima"
        '
        'txtBrojStanaVrata
        '
        Me.txtBrojStanaVrata.Location = New System.Drawing.Point(375, 52)
        Me.txtBrojStanaVrata.MaxLength = 10
        Me.txtBrojStanaVrata.Name = "txtBrojStanaVrata"
        Me.txtBrojStanaVrata.Size = New System.Drawing.Size(97, 22)
        Me.txtBrojStanaVrata.TabIndex = 69
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(612, 610)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 24)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(10, 610)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(117, 22)
        Me.TextBox1.TabIndex = 62
        Me.TextBox1.Visible = False
        '
        'ButtonSave2
        '
        Me.ButtonSave2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSave2.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonSave2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSave2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonSave2.Location = New System.Drawing.Point(717, 610)
        Me.ButtonSave2.Name = "ButtonSave2"
        Me.ButtonSave2.Size = New System.Drawing.Size(90, 24)
        Me.ButtonSave2.TabIndex = 61
        Me.ButtonSave2.Text = "OK"
        Me.ButtonSave2.UseVisualStyleBackColor = False
        '
        'txtIshodNapomena
        '
        Me.txtIshodNapomena.Location = New System.Drawing.Point(10, 489)
        Me.txtIshodNapomena.MaxLength = 500
        Me.txtIshodNapomena.Multiline = True
        Me.txtIshodNapomena.Name = "txtIshodNapomena"
        Me.txtIshodNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIshodNapomena.Size = New System.Drawing.Size(797, 119)
        Me.txtIshodNapomena.TabIndex = 54
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
        'PanelLegendaDGV1
        '
        Me.PanelLegendaDGV1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelLegendaDGV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLegendaDGV1.Controls.Add(Me.btnLegenda1M)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label8)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label9)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label5)
        Me.PanelLegendaDGV1.Controls.Add(Me.TextBox3)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label6)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label7)
        Me.PanelLegendaDGV1.Controls.Add(Me.txt4)
        Me.PanelLegendaDGV1.Controls.Add(Me.txt5)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label2)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblDelete)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaDelete)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label1)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblPin)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaPin)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaPencil)
        Me.PanelLegendaDGV1.Controls.Add(Me.LegendaHouse)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblPencil)
        Me.PanelLegendaDGV1.Controls.Add(Me.lblHouse)
        Me.PanelLegendaDGV1.Controls.Add(Me.Label20)
        Me.PanelLegendaDGV1.Location = New System.Drawing.Point(515, 12)
        Me.PanelLegendaDGV1.Name = "PanelLegendaDGV1"
        Me.PanelLegendaDGV1.Size = New System.Drawing.Size(530, 251)
        Me.PanelLegendaDGV1.TabIndex = 1019
        Me.PanelLegendaDGV1.Tag = "NeDiraj"
        '
        'btnLegenda1M
        '
        Me.btnLegenda1M.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLegenda1M.BackColor = System.Drawing.SystemColors.Control
        Me.btnLegenda1M.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLegenda1M.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLegenda1M.Location = New System.Drawing.Point(495, 0)
        Me.btnLegenda1M.Name = "btnLegenda1M"
        Me.btnLegenda1M.Size = New System.Drawing.Size(33, 23)
        Me.btnLegenda1M.TabIndex = 1052
        Me.btnLegenda1M.Text = "_"
        Me.btnLegenda1M.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 16)
        Me.Label8.TabIndex = 1059
        Me.Label8.Text = "LEGENDA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label9.Location = New System.Drawing.Point(87, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 14)
        Me.Label9.TabIndex = 1058
        Me.Label9.Text = "U prikazanoj tabeli, klikom na ikonicu:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label5.Location = New System.Drawing.Point(43, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 14)
        Me.Label5.TabIndex = 1057
        Me.Label5.Text = "Popisivanje zgrade nije započeto"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TextBox3.Location = New System.Drawing.Point(14, 177)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(22, 20)
        Me.TextBox3.TabIndex = 1056
        Me.TextBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label6.Location = New System.Drawing.Point(43, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(300, 14)
        Me.Label6.TabIndex = 1055
        Me.Label6.Text = "Popisivanje zgrade/stanova u zgradi završeno"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label7.Location = New System.Drawing.Point(43, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 14)
        Me.Label7.TabIndex = 1054
        Me.Label7.Text = "Popisivanje zgrade/stanova u zgradi u toku"
        '
        'txt4
        '
        Me.txt4.BackColor = System.Drawing.Color.LimeGreen
        Me.txt4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt4.Location = New System.Drawing.Point(14, 221)
        Me.txt4.Name = "txt4"
        Me.txt4.ReadOnly = True
        Me.txt4.Size = New System.Drawing.Size(22, 20)
        Me.txt4.TabIndex = 1053
        Me.txt4.TabStop = False
        Me.txt4.Text = "2"
        '
        'txt5
        '
        Me.txt5.BackColor = System.Drawing.Color.Yellow
        Me.txt5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txt5.Location = New System.Drawing.Point(14, 199)
        Me.txt5.Name = "txt5"
        Me.txt5.ReadOnly = True
        Me.txt5.Size = New System.Drawing.Size(22, 20)
        Me.txt5.TabIndex = 1052
        Me.txt5.TabStop = False
        Me.txt5.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label2.Location = New System.Drawing.Point(11, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 14)
        Me.Label2.TabIndex = 1047
        Me.Label2.Text = "Značenje simbola i boja u prikazanoj tabeli:"
        '
        'lblDelete
        '
        Me.lblDelete.AutoSize = True
        Me.lblDelete.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblDelete.Location = New System.Drawing.Point(41, 89)
        Me.lblDelete.Name = "lblDelete"
        Me.lblDelete.Size = New System.Drawing.Size(381, 14)
        Me.lblDelete.TabIndex = 1026
        Me.lblDelete.Text = "briše se dodati kućni broj u kome nije započeto popisivanje"
        '
        'LegendaDelete
        '
        Me.LegendaDelete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaDelete.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaDelete.Location = New System.Drawing.Point(13, 83)
        Me.LegendaDelete.Name = "LegendaDelete"
        Me.LegendaDelete.ReadOnly = True
        Me.LegendaDelete.Size = New System.Drawing.Size(30, 26)
        Me.LegendaDelete.TabIndex = 1022
        Me.LegendaDelete.TabStop = False
        Me.LegendaDelete.Text = "🗑"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label1.Location = New System.Drawing.Point(13, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(503, 14)
        Me.Label1.TabIndex = 1046
        Me.Label1.Text = "______________________________________________________________"
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPin.Location = New System.Drawing.Point(43, 154)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(245, 14)
        Me.lblPin.TabIndex = 1030
        Me.lblPin.Text = "Kućni broj dodat od strane popisivača"
        '
        'LegendaPin
        '
        Me.LegendaPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPin.Location = New System.Drawing.Point(14, 149)
        Me.LegendaPin.Name = "LegendaPin"
        Me.LegendaPin.ReadOnly = True
        Me.LegendaPin.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPin.TabIndex = 1029
        Me.LegendaPin.TabStop = False
        Me.LegendaPin.Text = "📌"
        '
        'LegendaPencil
        '
        Me.LegendaPencil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPencil.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPencil.Location = New System.Drawing.Point(14, 23)
        Me.LegendaPencil.Name = "LegendaPencil"
        Me.LegendaPencil.ReadOnly = True
        Me.LegendaPencil.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPencil.TabIndex = 1021
        Me.LegendaPencil.TabStop = False
        Me.LegendaPencil.Text = "🖉"
        '
        'LegendaHouse
        '
        Me.LegendaHouse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaHouse.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaHouse.Location = New System.Drawing.Point(14, 51)
        Me.LegendaHouse.Name = "LegendaHouse"
        Me.LegendaHouse.ReadOnly = True
        Me.LegendaHouse.Size = New System.Drawing.Size(30, 26)
        Me.LegendaHouse.TabIndex = 1020
        Me.LegendaHouse.TabStop = False
        Me.LegendaHouse.Text = "🏠"
        '
        'lblPencil
        '
        Me.lblPencil.AutoSize = True
        Me.lblPencil.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPencil.Location = New System.Drawing.Point(41, 30)
        Me.lblPencil.Name = "lblPencil"
        Me.lblPencil.Size = New System.Drawing.Size(493, 14)
        Me.lblPencil.TabIndex = 70
        Me.lblPencil.Text = "otvara se prozor za napomenu ili izmenu podataka o dodatom kućnom broju "
        '
        'lblHouse
        '
        Me.lblHouse.AutoSize = True
        Me.lblHouse.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblHouse.Location = New System.Drawing.Point(41, 58)
        Me.lblHouse.Name = "lblHouse"
        Me.lblHouse.Size = New System.Drawing.Size(335, 14)
        Me.lblHouse.TabIndex = 68
        Me.lblHouse.Text = "otvara se prozor za unos/izmenu podataka o zgradi"
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
        'PanelLegendaDGV2
        '
        Me.PanelLegendaDGV2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelLegendaDGV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLegendaDGV2.Controls.Add(Me.lblHand)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaPapir)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaHand)
        Me.PanelLegendaDGV2.Controls.Add(Me.legendaFtoF)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblPapir)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaPeople)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaPencil2)
        Me.PanelLegendaDGV2.Controls.Add(Me.btnLegenda2M)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label4)
        Me.PanelLegendaDGV2.Controls.Add(Me.TextBox2)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaPhone)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblPhone)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblFtoF)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label27)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label26)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label25)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label24)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblYellow)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label22)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaRed)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaGrey)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaGreen)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaPgreen)
        Me.PanelLegendaDGV2.Controls.Add(Me.LegendaYellow)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblLegenda2)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblText2)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblPeople)
        Me.PanelLegendaDGV2.Controls.Add(Me.lblPenacil2)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label29)
        Me.PanelLegendaDGV2.Controls.Add(Me.Label23)
        Me.PanelLegendaDGV2.Location = New System.Drawing.Point(424, 26)
        Me.PanelLegendaDGV2.Name = "PanelLegendaDGV2"
        Me.PanelLegendaDGV2.Size = New System.Drawing.Size(530, 300)
        Me.PanelLegendaDGV2.TabIndex = 1020
        Me.PanelLegendaDGV2.Tag = "NeDiraj"
        Me.PanelLegendaDGV2.Visible = False
        '
        'lblHand
        '
        Me.lblHand.AutoSize = True
        Me.lblHand.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblHand.Location = New System.Drawing.Point(65, 86)
        Me.lblHand.Name = "lblHand"
        Me.lblHand.Size = New System.Drawing.Size(426, 14)
        Me.lblHand.TabIndex = 1024
        Me.lblHand.Text = "otvara se prozor za zahtev za doradu popisanog i poslatog stana "
        '
        'LegendaPapir
        '
        Me.LegendaPapir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPapir.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPapir.Location = New System.Drawing.Point(34, 58)
        Me.LegendaPapir.Name = "LegendaPapir"
        Me.LegendaPapir.ReadOnly = True
        Me.LegendaPapir.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPapir.TabIndex = 1056
        Me.LegendaPapir.TabStop = False
        Me.LegendaPapir.Text = "📝"
        '
        'LegendaHand
        '
        Me.LegendaHand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaHand.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaHand.Location = New System.Drawing.Point(33, 80)
        Me.LegendaHand.Name = "LegendaHand"
        Me.LegendaHand.ReadOnly = True
        Me.LegendaHand.Size = New System.Drawing.Size(30, 26)
        Me.LegendaHand.TabIndex = 1021
        Me.LegendaHand.TabStop = False
        Me.LegendaHand.Text = "🖐"
        '
        'legendaFtoF
        '
        Me.legendaFtoF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.legendaFtoF.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.legendaFtoF.Location = New System.Drawing.Point(16, 121)
        Me.legendaFtoF.Name = "legendaFtoF"
        Me.legendaFtoF.ReadOnly = True
        Me.legendaFtoF.Size = New System.Drawing.Size(30, 26)
        Me.legendaFtoF.TabIndex = 1048
        Me.legendaFtoF.TabStop = False
        Me.legendaFtoF.Text = "🏃"
        '
        'lblPapir
        '
        Me.lblPapir.AutoSize = True
        Me.lblPapir.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPapir.Location = New System.Drawing.Point(65, 66)
        Me.lblPapir.Name = "lblPapir"
        Me.lblPapir.Size = New System.Drawing.Size(286, 14)
        Me.lblPapir.TabIndex = 1055
        Me.lblPapir.Text = "otvara se prozor za zakazivanje popisivanja"
        '
        'LegendaPeople
        '
        Me.LegendaPeople.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPeople.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPeople.Location = New System.Drawing.Point(16, 20)
        Me.LegendaPeople.Name = "LegendaPeople"
        Me.LegendaPeople.ReadOnly = True
        Me.LegendaPeople.Size = New System.Drawing.Size(43, 24)
        Me.LegendaPeople.TabIndex = 1021
        Me.LegendaPeople.TabStop = False
        Me.LegendaPeople.Text = "🏦👪"
        '
        'LegendaPencil2
        '
        Me.LegendaPencil2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPencil2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPencil2.Location = New System.Drawing.Point(35, 37)
        Me.LegendaPencil2.Name = "LegendaPencil2"
        Me.LegendaPencil2.ReadOnly = True
        Me.LegendaPencil2.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPencil2.TabIndex = 1020
        Me.LegendaPencil2.TabStop = False
        Me.LegendaPencil2.Text = "🖉"
        '
        'btnLegenda2M
        '
        Me.btnLegenda2M.AutoSize = True
        Me.btnLegenda2M.BackColor = System.Drawing.SystemColors.Control
        Me.btnLegenda2M.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLegenda2M.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLegenda2M.Location = New System.Drawing.Point(495, -1)
        Me.btnLegenda2M.Margin = New System.Windows.Forms.Padding(0)
        Me.btnLegenda2M.Name = "btnLegenda2M"
        Me.btnLegenda2M.Size = New System.Drawing.Size(33, 28)
        Me.btnLegenda2M.TabIndex = 1053
        Me.btnLegenda2M.Text = "_"
        Me.btnLegenda2M.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label4.Location = New System.Drawing.Point(45, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 14)
        Me.Label4.TabIndex = 1051
        Me.Label4.Text = "Popisivanje nije započeto"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TextBox2.Location = New System.Drawing.Point(16, 167)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(22, 20)
        Me.TextBox2.TabIndex = 1050
        Me.TextBox2.TabStop = False
        '
        'LegendaPhone
        '
        Me.LegendaPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LegendaPhone.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LegendaPhone.Location = New System.Drawing.Point(16, 142)
        Me.LegendaPhone.Name = "LegendaPhone"
        Me.LegendaPhone.ReadOnly = True
        Me.LegendaPhone.Size = New System.Drawing.Size(30, 26)
        Me.LegendaPhone.TabIndex = 1049
        Me.LegendaPhone.TabStop = False
        Me.LegendaPhone.Text = "📞"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPhone.Location = New System.Drawing.Point(45, 148)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(212, 14)
        Me.lblPhone.TabIndex = 1047
        Me.lblPhone.Text = "Zakazano popisivanje telefonom"
        '
        'lblFtoF
        '
        Me.lblFtoF.AutoSize = True
        Me.lblFtoF.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblFtoF.Location = New System.Drawing.Point(45, 127)
        Me.lblFtoF.Name = "lblFtoF"
        Me.lblFtoF.Size = New System.Drawing.Size(279, 14)
        Me.lblFtoF.TabIndex = 1046
        Me.lblFtoF.Text = "Zakazano popisivanje dolaskom popisivača"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label27.Location = New System.Drawing.Point(45, 279)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(297, 14)
        Me.Label27.TabIndex = 1044
        Me.Label27.Text = "Instruktor je popisivaču vratio stan na doradu"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label26.Location = New System.Drawing.Point(45, 257)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(454, 14)
        Me.Label26.TabIndex = 1043
        Me.Label26.Text = "Popisivač je zatražio od instruktora mogućnost dorade poslatog stana "
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label25.Location = New System.Drawing.Point(45, 235)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(300, 14)
        Me.Label25.TabIndex = 1042
        Me.Label25.Text = "Popisivanje završeno, podaci poslati na server"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label24.Location = New System.Drawing.Point(45, 213)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(441, 14)
        Me.Label24.TabIndex = 1041
        Me.Label24.Text = "Popisivanje završeno, podaci će sledećom sinhronizacijom biti poslati"
        '
        'lblYellow
        '
        Me.lblYellow.AutoSize = True
        Me.lblYellow.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblYellow.Location = New System.Drawing.Point(45, 191)
        Me.lblYellow.Name = "lblYellow"
        Me.lblYellow.Size = New System.Drawing.Size(123, 14)
        Me.lblYellow.TabIndex = 1040
        Me.lblYellow.Text = "Popisivanje u toku"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label22.Location = New System.Drawing.Point(13, 109)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(282, 14)
        Me.Label22.TabIndex = 1039
        Me.Label22.Text = "Značenje simbola i boja u prikazanoj tabeli:"
        '
        'LegendaRed
        '
        Me.LegendaRed.BackColor = System.Drawing.Color.Red
        Me.LegendaRed.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LegendaRed.Location = New System.Drawing.Point(16, 277)
        Me.LegendaRed.Name = "LegendaRed"
        Me.LegendaRed.ReadOnly = True
        Me.LegendaRed.Size = New System.Drawing.Size(22, 20)
        Me.LegendaRed.TabIndex = 1038
        Me.LegendaRed.TabStop = False
        Me.LegendaRed.Text = "4"
        '
        'LegendaGrey
        '
        Me.LegendaGrey.BackColor = System.Drawing.Color.Gainsboro
        Me.LegendaGrey.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LegendaGrey.Location = New System.Drawing.Point(16, 255)
        Me.LegendaGrey.Name = "LegendaGrey"
        Me.LegendaGrey.ReadOnly = True
        Me.LegendaGrey.Size = New System.Drawing.Size(22, 20)
        Me.LegendaGrey.TabIndex = 1037
        Me.LegendaGrey.TabStop = False
        Me.LegendaGrey.Text = "3"
        '
        'LegendaGreen
        '
        Me.LegendaGreen.BackColor = System.Drawing.Color.LimeGreen
        Me.LegendaGreen.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LegendaGreen.Location = New System.Drawing.Point(16, 233)
        Me.LegendaGreen.Name = "LegendaGreen"
        Me.LegendaGreen.ReadOnly = True
        Me.LegendaGreen.Size = New System.Drawing.Size(22, 20)
        Me.LegendaGreen.TabIndex = 1036
        Me.LegendaGreen.TabStop = False
        Me.LegendaGreen.Text = "2"
        '
        'LegendaPgreen
        '
        Me.LegendaPgreen.BackColor = System.Drawing.Color.PaleGreen
        Me.LegendaPgreen.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LegendaPgreen.Location = New System.Drawing.Point(16, 211)
        Me.LegendaPgreen.Name = "LegendaPgreen"
        Me.LegendaPgreen.ReadOnly = True
        Me.LegendaPgreen.Size = New System.Drawing.Size(22, 20)
        Me.LegendaPgreen.TabIndex = 1035
        Me.LegendaPgreen.TabStop = False
        Me.LegendaPgreen.Text = "1"
        '
        'LegendaYellow
        '
        Me.LegendaYellow.BackColor = System.Drawing.Color.Yellow
        Me.LegendaYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LegendaYellow.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.LegendaYellow.Location = New System.Drawing.Point(16, 189)
        Me.LegendaYellow.Name = "LegendaYellow"
        Me.LegendaYellow.ReadOnly = True
        Me.LegendaYellow.Size = New System.Drawing.Size(22, 20)
        Me.LegendaYellow.TabIndex = 1034
        Me.LegendaYellow.TabStop = False
        Me.LegendaYellow.Text = "0"
        '
        'lblLegenda2
        '
        Me.lblLegenda2.AutoSize = True
        Me.lblLegenda2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLegenda2.Location = New System.Drawing.Point(12, 1)
        Me.lblLegenda2.Name = "lblLegenda2"
        Me.lblLegenda2.Size = New System.Drawing.Size(73, 16)
        Me.lblLegenda2.TabIndex = 1028
        Me.lblLegenda2.Text = "LEGENDA"
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblText2.Location = New System.Drawing.Point(87, 2)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(244, 14)
        Me.lblText2.TabIndex = 1027
        Me.lblText2.Text = "U prikazanoj tabeli, klikom na ikonicu:"
        '
        'lblPeople
        '
        Me.lblPeople.AutoSize = True
        Me.lblPeople.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPeople.Location = New System.Drawing.Point(65, 24)
        Me.lblPeople.Name = "lblPeople"
        Me.lblPeople.Size = New System.Drawing.Size(377, 14)
        Me.lblPeople.TabIndex = 70
        Me.lblPeople.Text = "otvara se prozor za unos/izmenu podataka o stanu i licima"
        '
        'lblPenacil2
        '
        Me.lblPenacil2.AutoSize = True
        Me.lblPenacil2.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.lblPenacil2.Location = New System.Drawing.Point(65, 45)
        Me.lblPenacil2.Name = "lblPenacil2"
        Me.lblPenacil2.Size = New System.Drawing.Size(237, 14)
        Me.lblPenacil2.TabIndex = 68
        Me.lblPenacil2.Text = "otvara se prozor za unos napomene"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(11, 58)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(0, 25)
        Me.Label29.TabIndex = 66
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label23.Location = New System.Drawing.Point(13, 95)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(503, 14)
        Me.Label23.TabIndex = 1045
        Me.Label23.Text = "______________________________________________________________"
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
        'PanelIzmenaNazivaNoveUlice
        '
        Me.PanelIzmenaNazivaNoveUlice.Controls.Add(Me.llOVDE)
        Me.PanelIzmenaNazivaNoveUlice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelIzmenaNazivaNoveUlice.Location = New System.Drawing.Point(5, 302)
        Me.PanelIzmenaNazivaNoveUlice.Name = "PanelIzmenaNazivaNoveUlice"
        Me.PanelIzmenaNazivaNoveUlice.Size = New System.Drawing.Size(340, 30)
        Me.PanelIzmenaNazivaNoveUlice.TabIndex = 1022
        Me.PanelIzmenaNazivaNoveUlice.Tag = "NeDiraj"
        Me.PanelIzmenaNazivaNoveUlice.Visible = False
        '
        'PanelIzmenaUL
        '
        Me.PanelIzmenaUL.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelIzmenaUL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelIzmenaUL.Controls.Add(Me.textboxIDUliceNNaziv)
        Me.PanelIzmenaUL.Controls.Add(Me.LblObjasnjenje)
        Me.PanelIzmenaUL.Controls.Add(Me.lbUlice)
        Me.PanelIzmenaUL.Controls.Add(Me.txtNNUlice)
        Me.PanelIzmenaUL.Controls.Add(Me.lblSNUlice)
        Me.PanelIzmenaUL.Controls.Add(Me.txtSNUlice)
        Me.PanelIzmenaUL.Controls.Add(Me.ButtonIzmenaULCancel)
        Me.PanelIzmenaUL.Controls.Add(Me.ButtonIzmenaULOK)
        Me.PanelIzmenaUL.Controls.Add(Me.lblNNUlice)
        Me.PanelIzmenaUL.Location = New System.Drawing.Point(239, 555)
        Me.PanelIzmenaUL.Name = "PanelIzmenaUL"
        Me.PanelIzmenaUL.Size = New System.Drawing.Size(604, 471)
        Me.PanelIzmenaUL.TabIndex = 1023
        Me.PanelIzmenaUL.Visible = False
        '
        'textboxIDUliceNNaziv
        '
        Me.textboxIDUliceNNaziv.AccessibleName = "CONVERTCIRLAT"
        Me.textboxIDUliceNNaziv.Location = New System.Drawing.Point(237, 441)
        Me.textboxIDUliceNNaziv.MaxLength = 50
        Me.textboxIDUliceNNaziv.Name = "textboxIDUliceNNaziv"
        Me.textboxIDUliceNNaziv.Size = New System.Drawing.Size(123, 22)
        Me.textboxIDUliceNNaziv.TabIndex = 10000063
        Me.textboxIDUliceNNaziv.Visible = False
        '
        'LblObjasnjenje
        '
        Me.LblObjasnjenje.Location = New System.Drawing.Point(33, 76)
        Me.LblObjasnjenje.Name = "LblObjasnjenje"
        Me.LblObjasnjenje.Size = New System.Drawing.Size(536, 29)
        Me.LblObjasnjenje.TabIndex = 10000062
        Me.LblObjasnjenje.Text = "Postojeći nazivi ulica u odabranom krugu:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(novi naziv ulice ne može biti isti ka" &
    "o naziv postojećih ulica)"
        '
        'lbUlice
        '
        Me.lbUlice.BackColor = System.Drawing.Color.Gainsboro
        Me.lbUlice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbUlice.FormattingEnabled = True
        Me.lbUlice.ItemHeight = 14
        Me.lbUlice.Location = New System.Drawing.Point(36, 110)
        Me.lbUlice.Name = "lbUlice"
        Me.lbUlice.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lbUlice.Size = New System.Drawing.Size(533, 198)
        Me.lbUlice.TabIndex = 10000061
        '
        'txtNNUlice
        '
        Me.txtNNUlice.AccessibleName = "CONVERTCIRLAT"
        Me.txtNNUlice.Location = New System.Drawing.Point(150, 38)
        Me.txtNNUlice.MaxLength = 50
        Me.txtNNUlice.Name = "txtNNUlice"
        Me.txtNNUlice.Size = New System.Drawing.Size(419, 22)
        Me.txtNNUlice.TabIndex = 10000060
        '
        'lblSNUlice
        '
        Me.lblSNUlice.Location = New System.Drawing.Point(36, 13)
        Me.lblSNUlice.Name = "lblSNUlice"
        Me.lblSNUlice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblSNUlice.Size = New System.Drawing.Size(104, 22)
        Me.lblSNUlice.TabIndex = 10000059
        Me.lblSNUlice.Text = "Stari naziv"
        '
        'txtSNUlice
        '
        Me.txtSNUlice.Location = New System.Drawing.Point(150, 13)
        Me.txtSNUlice.Name = "txtSNUlice"
        Me.txtSNUlice.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSNUlice.Size = New System.Drawing.Size(419, 22)
        Me.txtSNUlice.TabIndex = 10000058
        Me.txtSNUlice.Text = ".."
        '
        'ButtonIzmenaULCancel
        '
        Me.ButtonIzmenaULCancel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonIzmenaULCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzmenaULCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzmenaULCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzmenaULCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzmenaULCancel.Location = New System.Drawing.Point(374, 438)
        Me.ButtonIzmenaULCancel.Name = "ButtonIzmenaULCancel"
        Me.ButtonIzmenaULCancel.Size = New System.Drawing.Size(90, 24)
        Me.ButtonIzmenaULCancel.TabIndex = 70
        Me.ButtonIzmenaULCancel.Text = "Cancel"
        Me.ButtonIzmenaULCancel.UseVisualStyleBackColor = False
        '
        'ButtonIzmenaULOK
        '
        Me.ButtonIzmenaULOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonIzmenaULOK.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonIzmenaULOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzmenaULOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzmenaULOK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzmenaULOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzmenaULOK.Location = New System.Drawing.Point(479, 438)
        Me.ButtonIzmenaULOK.Name = "ButtonIzmenaULOK"
        Me.ButtonIzmenaULOK.Size = New System.Drawing.Size(90, 24)
        Me.ButtonIzmenaULOK.TabIndex = 65
        Me.ButtonIzmenaULOK.Text = "OK"
        Me.ButtonIzmenaULOK.UseVisualStyleBackColor = False
        '
        'lblNNUlice
        '
        Me.lblNNUlice.Location = New System.Drawing.Point(36, 38)
        Me.lblNNUlice.Name = "lblNNUlice"
        Me.lblNNUlice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNNUlice.Size = New System.Drawing.Size(104, 22)
        Me.lblNNUlice.TabIndex = 51
        Me.lblNNUlice.Text = "Novi naziv"
        '
        'LblOps
        '
        Me.LblOps.AutoSize = True
        Me.LblOps.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOps.Location = New System.Drawing.Point(33, 12)
        Me.LblOps.Name = "LblOps"
        Me.LblOps.Size = New System.Drawing.Size(56, 14)
        Me.LblOps.TabIndex = 1024
        Me.LblOps.Text = "Opština"
        '
        'ButtonUnosNoveUlice
        '
        Me.ButtonUnosNoveUlice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonUnosNoveUlice.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonUnosNoveUlice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonUnosNoveUlice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUnosNoveUlice.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnosNoveUlice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonUnosNoveUlice.Location = New System.Drawing.Point(300, 67)
        Me.ButtonUnosNoveUlice.Name = "ButtonUnosNoveUlice"
        Me.ButtonUnosNoveUlice.Size = New System.Drawing.Size(115, 22)
        Me.ButtonUnosNoveUlice.TabIndex = 4
        Me.ButtonUnosNoveUlice.Text = "Unos nove ulice"
        Me.ButtonUnosNoveUlice.UseVisualStyleBackColor = False
        Me.ButtonUnosNoveUlice.Visible = False
        '
        'PanelSpisakUlica
        '
        Me.PanelSpisakUlica.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelSpisakUlica.Controls.Add(Me.BtnZatvori)
        Me.PanelSpisakUlica.Controls.Add(Me.PictureBox2)
        Me.PanelSpisakUlica.Controls.Add(Me.Label13)
        Me.PanelSpisakUlica.Controls.Add(Me.LBSpisakUL)
        Me.PanelSpisakUlica.Location = New System.Drawing.Point(1119, 242)
        Me.PanelSpisakUlica.Name = "PanelSpisakUlica"
        Me.PanelSpisakUlica.Size = New System.Drawing.Size(533, 311)
        Me.PanelSpisakUlica.TabIndex = 1026
        Me.PanelSpisakUlica.Visible = False
        '
        'BtnZatvori
        '
        Me.BtnZatvori.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnZatvori.BackColor = System.Drawing.SystemColors.Control
        Me.BtnZatvori.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnZatvori.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnZatvori.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnZatvori.Location = New System.Drawing.Point(422, 272)
        Me.BtnZatvori.Name = "BtnZatvori"
        Me.BtnZatvori.Size = New System.Drawing.Size(97, 28)
        Me.BtnZatvori.TabIndex = 10000065
        Me.BtnZatvori.Text = "OK"
        Me.BtnZatvori.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(518, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 10000064
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(139, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(227, 19)
        Me.Label13.TabIndex = 10000063
        Me.Label13.Text = "Spisak ulica u odabranom krugu"
        '
        'LBSpisakUL
        '
        Me.LBSpisakUL.BackColor = System.Drawing.Color.Gainsboro
        Me.LBSpisakUL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBSpisakUL.FormattingEnabled = True
        Me.LBSpisakUL.ItemHeight = 14
        Me.LBSpisakUL.Location = New System.Drawing.Point(1, 23)
        Me.LBSpisakUL.Name = "LBSpisakUL"
        Me.LBSpisakUL.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.LBSpisakUL.Size = New System.Drawing.Size(533, 156)
        Me.LBSpisakUL.TabIndex = 10000062
        '
        'ButtonSpisakUlica
        '
        Me.ButtonSpisakUlica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonSpisakUlica.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonSpisakUlica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSpisakUlica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonSpisakUlica.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSpisakUlica.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonSpisakUlica.Location = New System.Drawing.Point(1084, 15)
        Me.ButtonSpisakUlica.Name = "ButtonSpisakUlica"
        Me.ButtonSpisakUlica.Size = New System.Drawing.Size(47, 37)
        Me.ButtonSpisakUlica.TabIndex = 1027
        Me.ButtonSpisakUlica.TabStop = False
        Me.ButtonSpisakUlica.Text = "Spisak svih ulica u krugu"
        Me.ButtonSpisakUlica.UseVisualStyleBackColor = False
        Me.ButtonSpisakUlica.Visible = False
        '
        'lblnaselje
        '
        Me.lblnaselje.AutoSize = True
        Me.lblnaselje.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnaselje.Location = New System.Drawing.Point(365, 31)
        Me.lblnaselje.Name = "lblnaselje"
        Me.lblnaselje.Size = New System.Drawing.Size(122, 14)
        Me.lblnaselje.TabIndex = 1028
        Me.lblnaselje.Text = "Naseljeno mesto: "
        '
        'ButtonResetUl
        '
        Me.ButtonResetUl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonResetUl.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonResetUl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonResetUl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonResetUl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResetUl.Location = New System.Drawing.Point(1159, 59)
        Me.ButtonResetUl.Name = "ButtonResetUl"
        Me.ButtonResetUl.Size = New System.Drawing.Size(227, 26)
        Me.ButtonResetUl.TabIndex = 8
        Me.ButtonResetUl.TabStop = False
        Me.ButtonResetUl.Text = "Povratak na izbor ulice"
        Me.ButtonResetUl.UseVisualStyleBackColor = False
        '
        'ButtonIzvestaji
        '
        Me.ButtonIzvestaji.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonIzvestaji.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonIzvestaji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzvestaji.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzvestaji.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzvestaji.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzvestaji.Location = New System.Drawing.Point(1159, 158)
        Me.ButtonIzvestaji.Name = "ButtonIzvestaji"
        Me.ButtonIzvestaji.Size = New System.Drawing.Size(227, 22)
        Me.ButtonIzvestaji.TabIndex = 10
        Me.ButtonIzvestaji.TabStop = False
        Me.ButtonIzvestaji.Text = "Izveštaji"
        Me.ButtonIzvestaji.UseVisualStyleBackColor = False
        '
        'ButtonLK
        '
        Me.ButtonLK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonLK.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonLK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLK.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLK.Location = New System.Drawing.Point(1191, 222)
        Me.ButtonLK.Name = "ButtonLK"
        Me.ButtonLK.Size = New System.Drawing.Size(195, 22)
        Me.ButtonLK.TabIndex = 1031
        Me.ButtonLK.TabStop = False
        Me.ButtonLK.Text = "LK"
        Me.ButtonLK.UseVisualStyleBackColor = False
        Me.ButtonLK.Visible = False
        '
        'PanelNapomenaStan
        '
        Me.PanelNapomenaStan.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelNapomenaStan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNapomenaStan.Controls.Add(Me.txtkrug_idCDNapomena)
        Me.PanelNapomenaStan.Controls.Add(Me.txtkucni_broj_idCDNapomena)
        Me.PanelNapomenaStan.Controls.Add(Me.Panel5)
        Me.PanelNapomenaStan.Controls.Add(Me.btnCancelNapomenaStan)
        Me.PanelNapomenaStan.Controls.Add(Me.btnOKNapomenaStan)
        Me.PanelNapomenaStan.Controls.Add(Me.Label16)
        Me.PanelNapomenaStan.Controls.Add(Me.txtNapomenaStan)
        Me.PanelNapomenaStan.Location = New System.Drawing.Point(682, 992)
        Me.PanelNapomenaStan.Name = "PanelNapomenaStan"
        Me.PanelNapomenaStan.Size = New System.Drawing.Size(643, 269)
        Me.PanelNapomenaStan.TabIndex = 1032
        Me.PanelNapomenaStan.Visible = False
        '
        'txtkrug_idCDNapomena
        '
        Me.txtkrug_idCDNapomena.Enabled = False
        Me.txtkrug_idCDNapomena.Location = New System.Drawing.Point(5, 235)
        Me.txtkrug_idCDNapomena.Name = "txtkrug_idCDNapomena"
        Me.txtkrug_idCDNapomena.Size = New System.Drawing.Size(28, 22)
        Me.txtkrug_idCDNapomena.TabIndex = 10000061
        Me.txtkrug_idCDNapomena.Visible = False
        '
        'txtkucni_broj_idCDNapomena
        '
        Me.txtkucni_broj_idCDNapomena.Enabled = False
        Me.txtkucni_broj_idCDNapomena.Location = New System.Drawing.Point(5, 205)
        Me.txtkucni_broj_idCDNapomena.Name = "txtkucni_broj_idCDNapomena"
        Me.txtkucni_broj_idCDNapomena.Size = New System.Drawing.Size(28, 22)
        Me.txtkucni_broj_idCDNapomena.TabIndex = 10000060
        Me.txtkucni_broj_idCDNapomena.Visible = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label48)
        Me.Panel5.Controls.Add(Me.Label47)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.txtBrojStanaVrataNapomena)
        Me.Panel5.Controls.Add(Me.txtUlicaNapomena)
        Me.Panel5.Controls.Add(Me.txtKBrojNapomena)
        Me.Panel5.Controls.Add(Me.txtRbrStanNapomena)
        Me.Panel5.Enabled = False
        Me.Panel5.Location = New System.Drawing.Point(5, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(615, 85)
        Me.Panel5.TabIndex = 10000059
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(29, 14)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label48.Size = New System.Drawing.Size(134, 19)
        Me.Label48.TabIndex = 10000065
        Me.Label48.Text = "Adresa"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(30, 38)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label47.Size = New System.Drawing.Size(134, 19)
        Me.Label47.TabIndex = 10000062
        Me.Label47.Text = "Rbr. stana"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(14, 61)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(150, 14)
        Me.Label15.TabIndex = 10000063
        Me.Label15.Text = "Broj stana na vratima"
        '
        'txtBrojStanaVrataNapomena
        '
        Me.txtBrojStanaVrataNapomena.Location = New System.Drawing.Point(170, 58)
        Me.txtBrojStanaVrataNapomena.Name = "txtBrojStanaVrataNapomena"
        Me.txtBrojStanaVrataNapomena.Size = New System.Drawing.Size(97, 22)
        Me.txtBrojStanaVrataNapomena.TabIndex = 10000064
        '
        'txtUlicaNapomena
        '
        Me.txtUlicaNapomena.Location = New System.Drawing.Point(170, 11)
        Me.txtUlicaNapomena.Name = "txtUlicaNapomena"
        Me.txtUlicaNapomena.Size = New System.Drawing.Size(442, 22)
        Me.txtUlicaNapomena.TabIndex = 51
        '
        'txtKBrojNapomena
        '
        Me.txtKBrojNapomena.Location = New System.Drawing.Point(533, 58)
        Me.txtKBrojNapomena.Name = "txtKBrojNapomena"
        Me.txtKBrojNapomena.Size = New System.Drawing.Size(79, 22)
        Me.txtKBrojNapomena.TabIndex = 65
        Me.txtKBrojNapomena.Visible = False
        '
        'txtRbrStanNapomena
        '
        Me.txtRbrStanNapomena.Location = New System.Drawing.Point(170, 35)
        Me.txtRbrStanNapomena.Name = "txtRbrStanNapomena"
        Me.txtRbrStanNapomena.Size = New System.Drawing.Size(97, 22)
        Me.txtRbrStanNapomena.TabIndex = 67
        '
        'btnCancelNapomenaStan
        '
        Me.btnCancelNapomenaStan.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelNapomenaStan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelNapomenaStan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelNapomenaStan.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelNapomenaStan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelNapomenaStan.Location = New System.Drawing.Point(418, 233)
        Me.btnCancelNapomenaStan.Name = "btnCancelNapomenaStan"
        Me.btnCancelNapomenaStan.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelNapomenaStan.TabIndex = 70
        Me.btnCancelNapomenaStan.Text = "Cancel"
        Me.btnCancelNapomenaStan.UseVisualStyleBackColor = False
        '
        'btnOKNapomenaStan
        '
        Me.btnOKNapomenaStan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOKNapomenaStan.BackColor = System.Drawing.SystemColors.Control
        Me.btnOKNapomenaStan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOKNapomenaStan.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOKNapomenaStan.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKNapomenaStan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOKNapomenaStan.Location = New System.Drawing.Point(523, 233)
        Me.btnOKNapomenaStan.Name = "btnOKNapomenaStan"
        Me.btnOKNapomenaStan.Size = New System.Drawing.Size(90, 24)
        Me.btnOKNapomenaStan.TabIndex = 65
        Me.btnOKNapomenaStan.Text = "OK"
        Me.btnOKNapomenaStan.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(25, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(85, 14)
        Me.Label16.TabIndex = 57
        Me.Label16.Text = "Napomena"
        '
        'txtNapomenaStan
        '
        Me.txtNapomenaStan.Location = New System.Drawing.Point(116, 95)
        Me.txtNapomenaStan.MaxLength = 500
        Me.txtNapomenaStan.Multiline = True
        Me.txtNapomenaStan.Name = "txtNapomenaStan"
        Me.txtNapomenaStan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNapomenaStan.Size = New System.Drawing.Size(504, 117)
        Me.txtNapomenaStan.TabIndex = 60
        '
        'ButtonZakazani
        '
        Me.ButtonZakazani.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonZakazani.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonZakazani.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonZakazani.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonZakazani.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonZakazani.Location = New System.Drawing.Point(1159, 86)
        Me.ButtonZakazani.Name = "ButtonZakazani"
        Me.ButtonZakazani.Size = New System.Drawing.Size(227, 35)
        Me.ButtonZakazani.TabIndex = 9
        Me.ButtonZakazani.TabStop = False
        Me.ButtonZakazani.Text = "Svi zakazani stanovi"
        Me.ButtonZakazani.UseVisualStyleBackColor = False
        '
        'PanelNapomenaLica
        '
        Me.PanelNapomenaLica.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelNapomenaLica.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelNapomenaLica.Controls.Add(Me.PanelUklanjanje)
        Me.PanelNapomenaLica.Controls.Add(Me.TxtIDULICELica)
        Me.PanelNapomenaLica.Controls.Add(Me.TxtMBOPSLica)
        Me.PanelNapomenaLica.Controls.Add(Me.TxtKrugIDCDLica)
        Me.PanelNapomenaLica.Controls.Add(Me.TxtKbrIDCDLica)
        Me.PanelNapomenaLica.Controls.Add(Me.PodpanelNapomenaLica)
        Me.PanelNapomenaLica.Controls.Add(Me.BtnCancNapomenaLica)
        Me.PanelNapomenaLica.Controls.Add(Me.BtnOkNapomenaLica)
        Me.PanelNapomenaLica.Controls.Add(Me.LblNapomenaLica)
        Me.PanelNapomenaLica.Controls.Add(Me.TxtNapomenaLica)
        Me.PanelNapomenaLica.Location = New System.Drawing.Point(256, 523)
        Me.PanelNapomenaLica.Name = "PanelNapomenaLica"
        Me.PanelNapomenaLica.Size = New System.Drawing.Size(643, 293)
        Me.PanelNapomenaLica.TabIndex = 1034
        Me.PanelNapomenaLica.Visible = False
        '
        'PanelUklanjanje
        '
        Me.PanelUklanjanje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUklanjanje.Controls.Add(Me.lblObjasnjenjeUklanjanja)
        Me.PanelUklanjanje.Controls.Add(Me.tboxObjasnjenjeUklanjanja)
        Me.PanelUklanjanje.Controls.Add(Me.cmbRazlogUklanjanja)
        Me.PanelUklanjanje.Controls.Add(Me.lblRazlogUklanjanja)
        Me.PanelUklanjanje.Controls.Add(Me.lblUklonitiIzMaterijala)
        Me.PanelUklanjanje.Controls.Add(Me.cbUklonitiIzMaterijala)
        Me.PanelUklanjanje.Location = New System.Drawing.Point(5, 228)
        Me.PanelUklanjanje.Name = "PanelUklanjanje"
        Me.PanelUklanjanje.Size = New System.Drawing.Size(615, 10)
        Me.PanelUklanjanje.TabIndex = 10000065
        Me.PanelUklanjanje.Visible = False
        '
        'lblObjasnjenjeUklanjanja
        '
        Me.lblObjasnjenjeUklanjanja.Location = New System.Drawing.Point(69, 45)
        Me.lblObjasnjenjeUklanjanja.Name = "lblObjasnjenjeUklanjanja"
        Me.lblObjasnjenjeUklanjanja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblObjasnjenjeUklanjanja.Size = New System.Drawing.Size(85, 26)
        Me.lblObjasnjenjeUklanjanja.TabIndex = 10000066
        Me.lblObjasnjenjeUklanjanja.Text = "Objašnjenje"
        Me.lblObjasnjenjeUklanjanja.Visible = False
        '
        'tboxObjasnjenjeUklanjanja
        '
        Me.tboxObjasnjenjeUklanjanja.Location = New System.Drawing.Point(157, 48)
        Me.tboxObjasnjenjeUklanjanja.MaxLength = 50
        Me.tboxObjasnjenjeUklanjanja.Multiline = True
        Me.tboxObjasnjenjeUklanjanja.Name = "tboxObjasnjenjeUklanjanja"
        Me.tboxObjasnjenjeUklanjanja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tboxObjasnjenjeUklanjanja.Size = New System.Drawing.Size(447, 71)
        Me.tboxObjasnjenjeUklanjanja.TabIndex = 10000067
        Me.tboxObjasnjenjeUklanjanja.Visible = False
        '
        'cmbRazlogUklanjanja
        '
        Me.cmbRazlogUklanjanja.FormattingEnabled = True
        Me.cmbRazlogUklanjanja.Location = New System.Drawing.Point(157, 45)
        Me.cmbRazlogUklanjanja.Name = "cmbRazlogUklanjanja"
        Me.cmbRazlogUklanjanja.Size = New System.Drawing.Size(447, 22)
        Me.cmbRazlogUklanjanja.TabIndex = 10000069
        Me.cmbRazlogUklanjanja.Visible = False
        '
        'lblRazlogUklanjanja
        '
        Me.lblRazlogUklanjanja.Location = New System.Drawing.Point(69, 45)
        Me.lblRazlogUklanjanja.Name = "lblRazlogUklanjanja"
        Me.lblRazlogUklanjanja.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRazlogUklanjanja.Size = New System.Drawing.Size(85, 16)
        Me.lblRazlogUklanjanja.TabIndex = 10000068
        Me.lblRazlogUklanjanja.Text = "Razlog"
        Me.lblRazlogUklanjanja.Visible = False
        '
        'lblUklonitiIzMaterijala
        '
        Me.lblUklonitiIzMaterijala.Location = New System.Drawing.Point(7, 3)
        Me.lblUklonitiIzMaterijala.Name = "lblUklonitiIzMaterijala"
        Me.lblUklonitiIzMaterijala.Size = New System.Drawing.Size(300, 14)
        Me.lblUklonitiIzMaterijala.TabIndex = 10000065
        Me.lblUklonitiIzMaterijala.Text = "Dodatna napomena:"
        '
        'cbUklonitiIzMaterijala
        '
        Me.cbUklonitiIzMaterijala.AutoSize = True
        Me.cbUklonitiIzMaterijala.Location = New System.Drawing.Point(9, 21)
        Me.cbUklonitiIzMaterijala.Name = "cbUklonitiIzMaterijala"
        Me.cbUklonitiIzMaterijala.Size = New System.Drawing.Size(354, 18)
        Me.cbUklonitiIzMaterijala.TabIndex = 10000064
        Me.cbUklonitiIzMaterijala.Text = "Pri obradi materijala ovo lice treba ukloniti iz obrade"
        Me.cbUklonitiIzMaterijala.UseVisualStyleBackColor = True
        '
        'TxtIDULICELica
        '
        Me.TxtIDULICELica.Enabled = False
        Me.TxtIDULICELica.Location = New System.Drawing.Point(82, 255)
        Me.TxtIDULICELica.Name = "TxtIDULICELica"
        Me.TxtIDULICELica.Size = New System.Drawing.Size(28, 22)
        Me.TxtIDULICELica.TabIndex = 10000063
        Me.TxtIDULICELica.Visible = False
        '
        'TxtMBOPSLica
        '
        Me.TxtMBOPSLica.Enabled = False
        Me.TxtMBOPSLica.Location = New System.Drawing.Point(44, 255)
        Me.TxtMBOPSLica.Name = "TxtMBOPSLica"
        Me.TxtMBOPSLica.Size = New System.Drawing.Size(28, 22)
        Me.TxtMBOPSLica.TabIndex = 10000062
        Me.TxtMBOPSLica.Visible = False
        '
        'TxtKrugIDCDLica
        '
        Me.TxtKrugIDCDLica.Enabled = False
        Me.TxtKrugIDCDLica.Location = New System.Drawing.Point(5, 255)
        Me.TxtKrugIDCDLica.Name = "TxtKrugIDCDLica"
        Me.TxtKrugIDCDLica.Size = New System.Drawing.Size(28, 22)
        Me.TxtKrugIDCDLica.TabIndex = 10000061
        Me.TxtKrugIDCDLica.Visible = False
        '
        'TxtKbrIDCDLica
        '
        Me.TxtKbrIDCDLica.Enabled = False
        Me.TxtKbrIDCDLica.Location = New System.Drawing.Point(2, 225)
        Me.TxtKbrIDCDLica.Name = "TxtKbrIDCDLica"
        Me.TxtKbrIDCDLica.Size = New System.Drawing.Size(28, 22)
        Me.TxtKbrIDCDLica.TabIndex = 10000060
        Me.TxtKbrIDCDLica.Visible = False
        '
        'PodpanelNapomenaLica
        '
        Me.PodpanelNapomenaLica.Controls.Add(Me.lableAdresa)
        Me.PodpanelNapomenaLica.Controls.Add(Me.LblRbrDomNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.TxtRbrDomNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.LblRbrStana2)
        Me.PodpanelNapomenaLica.Controls.Add(Me.TxtImeNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.LblImeLicaNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.TxtRBrLicaNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.LblRbLicaNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.LblRbrStVrataNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.TxtRbrStVrataNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.TxtUlicaKbrNapomenaLica)
        Me.PodpanelNapomenaLica.Controls.Add(Me.TxtRbrStNapomenaLica)
        Me.PodpanelNapomenaLica.Enabled = False
        Me.PodpanelNapomenaLica.Location = New System.Drawing.Point(5, 4)
        Me.PodpanelNapomenaLica.Name = "PodpanelNapomenaLica"
        Me.PodpanelNapomenaLica.Size = New System.Drawing.Size(615, 127)
        Me.PodpanelNapomenaLica.TabIndex = 10000059
        '
        'lableAdresa
        '
        Me.lableAdresa.AutoSize = True
        Me.lableAdresa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lableAdresa.Location = New System.Drawing.Point(162, 12)
        Me.lableAdresa.Name = "lableAdresa"
        Me.lableAdresa.Size = New System.Drawing.Size(53, 14)
        Me.lableAdresa.TabIndex = 10000072
        Me.lableAdresa.Text = "Adresa"
        '
        'LblRbrDomNapomenaLica
        '
        Me.LblRbrDomNapomenaLica.AutoSize = True
        Me.LblRbrDomNapomenaLica.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblRbrDomNapomenaLica.Location = New System.Drawing.Point(53, 55)
        Me.LblRbrDomNapomenaLica.Name = "LblRbrDomNapomenaLica"
        Me.LblRbrDomNapomenaLica.Size = New System.Drawing.Size(162, 14)
        Me.LblRbrDomNapomenaLica.TabIndex = 10000070
        Me.LblRbrDomNapomenaLica.Text = "Redni broj domaćinstva"
        '
        'TxtRbrDomNapomenaLica
        '
        Me.TxtRbrDomNapomenaLica.Location = New System.Drawing.Point(224, 55)
        Me.TxtRbrDomNapomenaLica.Name = "TxtRbrDomNapomenaLica"
        Me.TxtRbrDomNapomenaLica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtRbrDomNapomenaLica.Size = New System.Drawing.Size(257, 22)
        Me.TxtRbrDomNapomenaLica.TabIndex = 10000071
        '
        'LblRbrStana2
        '
        Me.LblRbrStana2.AutoSize = True
        Me.LblRbrStana2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblRbrStana2.Location = New System.Drawing.Point(483, 12)
        Me.LblRbrStana2.Name = "LblRbrStana2"
        Me.LblRbrStana2.Size = New System.Drawing.Size(74, 14)
        Me.LblRbrStana2.TabIndex = 10000069
        Me.LblRbrStana2.Text = "Rbr. stana"
        '
        'TxtImeNapomenaLica
        '
        Me.TxtImeNapomenaLica.Location = New System.Drawing.Point(224, 102)
        Me.TxtImeNapomenaLica.Name = "TxtImeNapomenaLica"
        Me.TxtImeNapomenaLica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtImeNapomenaLica.Size = New System.Drawing.Size(257, 22)
        Me.TxtImeNapomenaLica.TabIndex = 10000068
        '
        'LblImeLicaNapomenaLica
        '
        Me.LblImeLicaNapomenaLica.AutoSize = True
        Me.LblImeLicaNapomenaLica.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblImeLicaNapomenaLica.Location = New System.Drawing.Point(155, 102)
        Me.LblImeLicaNapomenaLica.Name = "LblImeLicaNapomenaLica"
        Me.LblImeLicaNapomenaLica.Size = New System.Drawing.Size(60, 14)
        Me.LblImeLicaNapomenaLica.TabIndex = 10000067
        Me.LblImeLicaNapomenaLica.Text = "Ime lica"
        '
        'TxtRBrLicaNapomenaLica
        '
        Me.TxtRBrLicaNapomenaLica.Location = New System.Drawing.Point(224, 78)
        Me.TxtRBrLicaNapomenaLica.Name = "TxtRBrLicaNapomenaLica"
        Me.TxtRBrLicaNapomenaLica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtRBrLicaNapomenaLica.Size = New System.Drawing.Size(257, 22)
        Me.TxtRBrLicaNapomenaLica.TabIndex = 10000066
        '
        'LblRbLicaNapomenaLica
        '
        Me.LblRbLicaNapomenaLica.AutoSize = True
        Me.LblRbLicaNapomenaLica.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblRbLicaNapomenaLica.Location = New System.Drawing.Point(113, 78)
        Me.LblRbLicaNapomenaLica.Name = "LblRbLicaNapomenaLica"
        Me.LblRbLicaNapomenaLica.Size = New System.Drawing.Size(102, 14)
        Me.LblRbLicaNapomenaLica.TabIndex = 10000065
        Me.LblRbLicaNapomenaLica.Text = "Redni broj lica"
        '
        'LblRbrStVrataNapomenaLica
        '
        Me.LblRbrStVrataNapomenaLica.AutoSize = True
        Me.LblRbrStVrataNapomenaLica.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LblRbrStVrataNapomenaLica.Location = New System.Drawing.Point(65, 32)
        Me.LblRbrStVrataNapomenaLica.Name = "LblRbrStVrataNapomenaLica"
        Me.LblRbrStVrataNapomenaLica.Size = New System.Drawing.Size(150, 14)
        Me.LblRbrStVrataNapomenaLica.TabIndex = 10000063
        Me.LblRbrStVrataNapomenaLica.Text = "Broj stana na vratima"
        '
        'TxtRbrStVrataNapomenaLica
        '
        Me.TxtRbrStVrataNapomenaLica.Location = New System.Drawing.Point(224, 32)
        Me.TxtRbrStVrataNapomenaLica.Name = "TxtRbrStVrataNapomenaLica"
        Me.TxtRbrStVrataNapomenaLica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtRbrStVrataNapomenaLica.Size = New System.Drawing.Size(257, 22)
        Me.TxtRbrStVrataNapomenaLica.TabIndex = 10000064
        '
        'TxtUlicaKbrNapomenaLica
        '
        Me.TxtUlicaKbrNapomenaLica.Location = New System.Drawing.Point(224, 8)
        Me.TxtUlicaKbrNapomenaLica.Name = "TxtUlicaKbrNapomenaLica"
        Me.TxtUlicaKbrNapomenaLica.Size = New System.Drawing.Size(257, 22)
        Me.TxtUlicaKbrNapomenaLica.TabIndex = 51
        '
        'TxtRbrStNapomenaLica
        '
        Me.TxtRbrStNapomenaLica.Location = New System.Drawing.Point(558, 8)
        Me.TxtRbrStNapomenaLica.Name = "TxtRbrStNapomenaLica"
        Me.TxtRbrStNapomenaLica.Size = New System.Drawing.Size(50, 22)
        Me.TxtRbrStNapomenaLica.TabIndex = 67
        '
        'BtnCancNapomenaLica
        '
        Me.BtnCancNapomenaLica.BackColor = System.Drawing.SystemColors.Control
        Me.BtnCancNapomenaLica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancNapomenaLica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCancNapomenaLica.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancNapomenaLica.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancNapomenaLica.Location = New System.Drawing.Point(431, 265)
        Me.BtnCancNapomenaLica.Name = "BtnCancNapomenaLica"
        Me.BtnCancNapomenaLica.Size = New System.Drawing.Size(90, 24)
        Me.BtnCancNapomenaLica.TabIndex = 70
        Me.BtnCancNapomenaLica.Text = "Cancel"
        Me.BtnCancNapomenaLica.UseVisualStyleBackColor = False
        '
        'BtnOkNapomenaLica
        '
        Me.BtnOkNapomenaLica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnOkNapomenaLica.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOkNapomenaLica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOkNapomenaLica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOkNapomenaLica.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOkNapomenaLica.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnOkNapomenaLica.Location = New System.Drawing.Point(530, 265)
        Me.BtnOkNapomenaLica.Name = "BtnOkNapomenaLica"
        Me.BtnOkNapomenaLica.Size = New System.Drawing.Size(90, 24)
        Me.BtnOkNapomenaLica.TabIndex = 65
        Me.BtnOkNapomenaLica.Text = "OK"
        Me.BtnOkNapomenaLica.UseVisualStyleBackColor = False
        '
        'LblNapomenaLica
        '
        Me.LblNapomenaLica.Location = New System.Drawing.Point(25, 137)
        Me.LblNapomenaLica.Name = "LblNapomenaLica"
        Me.LblNapomenaLica.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblNapomenaLica.Size = New System.Drawing.Size(85, 14)
        Me.LblNapomenaLica.TabIndex = 57
        Me.LblNapomenaLica.Text = "Napomena"
        '
        'TxtNapomenaLica
        '
        Me.TxtNapomenaLica.Location = New System.Drawing.Point(116, 136)
        Me.TxtNapomenaLica.MaxLength = 500
        Me.TxtNapomenaLica.Multiline = True
        Me.TxtNapomenaLica.Name = "TxtNapomenaLica"
        Me.TxtNapomenaLica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNapomenaLica.Size = New System.Drawing.Size(504, 86)
        Me.TxtNapomenaLica.TabIndex = 60
        '
        'PanelLegendaDGV3
        '
        Me.PanelLegendaDGV3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelLegendaDGV3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelLegendaDGV3.Controls.Add(Me.Label19)
        Me.PanelLegendaDGV3.Controls.Add(Me.Label18)
        Me.PanelLegendaDGV3.Controls.Add(Me.Label17)
        Me.PanelLegendaDGV3.Controls.Add(Me.Label34)
        Me.PanelLegendaDGV3.Controls.Add(Me.Label35)
        Me.PanelLegendaDGV3.Controls.Add(Me.TextBox13)
        Me.PanelLegendaDGV3.Controls.Add(Me.TextBox14)
        Me.PanelLegendaDGV3.Controls.Add(Me.Label37)
        Me.PanelLegendaDGV3.Controls.Add(Me.Label38)
        Me.PanelLegendaDGV3.Controls.Add(Me.Label39)
        Me.PanelLegendaDGV3.Location = New System.Drawing.Point(411, 338)
        Me.PanelLegendaDGV3.Name = "PanelLegendaDGV3"
        Me.PanelLegendaDGV3.Size = New System.Drawing.Size(530, 114)
        Me.PanelLegendaDGV3.TabIndex = 1035
        Me.PanelLegendaDGV3.Tag = "NeDiraj"
        Me.PanelLegendaDGV3.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.3!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label19.Location = New System.Drawing.Point(405, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 14)
        Me.Label19.TabIndex = 1047
        Me.Label19.Text = "zadebljani"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label18.Location = New System.Drawing.Point(8, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(503, 14)
        Me.Label18.TabIndex = 1046
        Me.Label18.Text = "______________________________________________________________"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.3!, System.Drawing.FontStyle.Italic)
        Me.Label17.Location = New System.Drawing.Point(3, 89)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(419, 14)
        Me.Label17.TabIndex = 1029
        Me.Label17.Text = "Redovi u tabeli koji se odnose na lica na koje se vodi domaćinstvo su"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(12, 2)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(73, 16)
        Me.Label34.TabIndex = 1028
        Me.Label34.Text = "LEGENDA"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label35.Location = New System.Drawing.Point(87, 3)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(244, 14)
        Me.Label35.TabIndex = 1027
        Me.Label35.Text = "U prikazanoj tabeli, klikom na ikonicu:"
        '
        'TextBox13
        '
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox13.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13.Location = New System.Drawing.Point(16, 21)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(30, 26)
        Me.TextBox13.TabIndex = 1021
        Me.TextBox13.TabStop = False
        Me.TextBox13.Text = "👪"
        '
        'TextBox14
        '
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox14.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(16, 47)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(30, 26)
        Me.TextBox14.TabIndex = 1020
        Me.TextBox14.TabStop = False
        Me.TextBox14.Text = "🖉"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label37.Location = New System.Drawing.Point(45, 28)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(347, 14)
        Me.Label37.TabIndex = 70
        Me.Label37.Text = "otvara se prozor za pregled/izmenu podataka o licima"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Verdana", 8.3!)
        Me.Label38.Location = New System.Drawing.Point(45, 54)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(395, 14)
        Me.Label38.TabIndex = 68
        Me.Label38.Text = "otvara se prozor za unos/izmenu napomene za odabrano lice"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(11, 56)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(0, 25)
        Me.Label39.TabIndex = 66
        '
        'BtnSvaLica
        '
        Me.BtnSvaLica.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnSvaLica.BackColor = System.Drawing.SystemColors.Control
        Me.BtnSvaLica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSvaLica.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSvaLica.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSvaLica.Location = New System.Drawing.Point(1159, 122)
        Me.BtnSvaLica.Name = "BtnSvaLica"
        Me.BtnSvaLica.Size = New System.Drawing.Size(227, 35)
        Me.BtnSvaLica.TabIndex = 1036
        Me.BtnSvaLica.TabStop = False
        Me.BtnSvaLica.Text = "Sva lica"
        Me.BtnSvaLica.UseVisualStyleBackColor = False
        Me.BtnSvaLica.Visible = False
        '
        'lblBrojKBR
        '
        Me.lblBrojKBR.AutoSize = True
        Me.lblBrojKBR.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrojKBR.Location = New System.Drawing.Point(9, 344)
        Me.lblBrojKBR.Name = "lblBrojKBR"
        Me.lblBrojKBR.Size = New System.Drawing.Size(164, 14)
        Me.lblBrojKBR.TabIndex = 1037
        Me.lblBrojKBR.Text = "Ukupno kućnih brojeva:  "
        Me.lblBrojKBR.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblBrojKBR.Visible = False
        '
        'btnMapa
        '
        Me.btnMapa.BackColor = System.Drawing.SystemColors.Control
        Me.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMapa.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.btnMapa.Location = New System.Drawing.Point(1051, 68)
        Me.btnMapa.Name = "btnMapa"
        Me.btnMapa.Size = New System.Drawing.Size(180, 22)
        Me.btnMapa.TabIndex = 1038
        Me.btnMapa.Text = "Mapa"
        Me.btnMapa.UseVisualStyleBackColor = False
        Me.btnMapa.Visible = False
        '
        'chbZavrsenKrug
        '
        Me.chbZavrsenKrug.AutoSize = True
        Me.chbZavrsenKrug.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbZavrsenKrug.Location = New System.Drawing.Point(1162, 202)
        Me.chbZavrsenKrug.Name = "chbZavrsenKrug"
        Me.chbZavrsenKrug.Size = New System.Drawing.Size(248, 22)
        Me.chbZavrsenKrug.TabIndex = 1039
        Me.chbZavrsenKrug.Text = "Krug je kompletno popisan"
        Me.chbZavrsenKrug.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbZavrsenKrug.UseVisualStyleBackColor = True
        Me.chbZavrsenKrug.Visible = False
        '
        'btnVracanjeKrugova
        '
        Me.btnVracanjeKrugova.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVracanjeKrugova.BackColor = System.Drawing.SystemColors.Control
        Me.btnVracanjeKrugova.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVracanjeKrugova.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVracanjeKrugova.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVracanjeKrugova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnVracanjeKrugova.Location = New System.Drawing.Point(1159, 181)
        Me.btnVracanjeKrugova.Name = "btnVracanjeKrugova"
        Me.btnVracanjeKrugova.Size = New System.Drawing.Size(227, 24)
        Me.btnVracanjeKrugova.TabIndex = 11
        Me.btnVracanjeKrugova.TabStop = False
        Me.btnVracanjeKrugova.Text = "Krugovi za doradu"
        Me.btnVracanjeKrugova.UseVisualStyleBackColor = False
        Me.btnVracanjeKrugova.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.TextBox7)
        Me.Panel2.Controls.Add(Me.TextBox8)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label41)
        Me.Panel2.Controls.Add(Me.TextBox17)
        Me.Panel2.Location = New System.Drawing.Point(420, 213)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(643, 293)
        Me.Panel2.TabIndex = 1041
        Me.Panel2.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.TextBox4)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.CheckBox1)
        Me.Panel4.Location = New System.Drawing.Point(5, 228)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(615, 10)
        Me.Panel4.TabIndex = 10000065
        Me.Panel4.Visible = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(69, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label21.Size = New System.Drawing.Size(85, 26)
        Me.Label21.TabIndex = 10000066
        Me.Label21.Text = "Objašnjenje"
        Me.Label21.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(157, 48)
        Me.TextBox4.MaxLength = 250
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox4.Size = New System.Drawing.Size(447, 71)
        Me.TextBox4.TabIndex = 10000067
        Me.TextBox4.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(447, 22)
        Me.ComboBox1.TabIndex = 10000069
        Me.ComboBox1.Visible = False
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(69, 45)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label28.Size = New System.Drawing.Size(85, 16)
        Me.Label28.TabIndex = 10000068
        Me.Label28.Text = "Razlog"
        Me.Label28.Visible = False
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(7, 3)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(300, 14)
        Me.Label30.TabIndex = 10000065
        Me.Label30.Text = "Dodatna napomena:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(354, 18)
        Me.CheckBox1.TabIndex = 10000064
        Me.CheckBox1.Text = "Pri obradi materijala ovo lice treba ukloniti iz obrade"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(82, 255)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(28, 22)
        Me.TextBox5.TabIndex = 10000063
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(44, 255)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(28, 22)
        Me.TextBox6.TabIndex = 10000062
        Me.TextBox6.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(5, 255)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(28, 22)
        Me.TextBox7.TabIndex = 10000061
        Me.TextBox7.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(2, 225)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(28, 22)
        Me.TextBox8.TabIndex = 10000060
        Me.TextBox8.Visible = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Labeladr)
        Me.Panel6.Controls.Add(Me.Label31)
        Me.Panel6.Controls.Add(Me.TextBox9)
        Me.Panel6.Controls.Add(Me.Label32)
        Me.Panel6.Controls.Add(Me.TextBox10)
        Me.Panel6.Controls.Add(Me.Label33)
        Me.Panel6.Controls.Add(Me.TextBox11)
        Me.Panel6.Controls.Add(Me.Label36)
        Me.Panel6.Controls.Add(Me.Label40)
        Me.Panel6.Controls.Add(Me.TextBox12)
        Me.Panel6.Controls.Add(Me.TextBox15)
        Me.Panel6.Controls.Add(Me.TextBox16)
        Me.Panel6.Enabled = False
        Me.Panel6.Location = New System.Drawing.Point(5, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(615, 127)
        Me.Panel6.TabIndex = 10000059
        '
        'Labeladr
        '
        Me.Labeladr.AutoSize = True
        Me.Labeladr.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Labeladr.Location = New System.Drawing.Point(115, 12)
        Me.Labeladr.Name = "Labeladr"
        Me.Labeladr.Size = New System.Drawing.Size(53, 14)
        Me.Labeladr.TabIndex = 10000072
        Me.Labeladr.Text = "Adresa"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(5, 55)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(162, 14)
        Me.Label31.TabIndex = 10000070
        Me.Label31.Text = "Redni broj domaćinstva"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(169, 55)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox9.Size = New System.Drawing.Size(328, 22)
        Me.TextBox9.TabIndex = 10000071
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label32.Location = New System.Drawing.Point(499, 12)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 14)
        Me.Label32.TabIndex = 10000069
        Me.Label32.Text = "Rbr. stana"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(169, 102)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox10.Size = New System.Drawing.Size(328, 22)
        Me.TextBox10.TabIndex = 10000068
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label33.Location = New System.Drawing.Point(107, 102)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(60, 14)
        Me.Label33.TabIndex = 10000067
        Me.Label33.Text = "Ime lica"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(169, 78)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox11.Size = New System.Drawing.Size(328, 22)
        Me.TextBox11.TabIndex = 10000066
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label36.Location = New System.Drawing.Point(65, 78)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 14)
        Me.Label36.TabIndex = 10000065
        Me.Label36.Text = "Redni broj lica"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(17, 32)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(150, 14)
        Me.Label40.TabIndex = 10000063
        Me.Label40.Text = "Broj stana na vratima"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(169, 32)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox12.Size = New System.Drawing.Size(328, 22)
        Me.TextBox12.TabIndex = 10000064
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(169, 8)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(328, 22)
        Me.TextBox15.TabIndex = 51
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(577, 8)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(31, 22)
        Me.TextBox16.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(431, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 24)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(530, 265)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(90, 24)
        Me.Button3.TabIndex = 65
        Me.Button3.Text = "OK"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(25, 137)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label41.Size = New System.Drawing.Size(85, 14)
        Me.Label41.TabIndex = 57
        Me.Label41.Text = "Napomena"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(116, 136)
        Me.TextBox17.MaxLength = 500
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox17.Size = New System.Drawing.Size(504, 86)
        Me.TextBox17.TabIndex = 60
        '
        'PanelPKDorada
        '
        Me.PanelPKDorada.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelPKDorada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPKDorada.Controls.Add(Me.lblTrazeniNaDoradu)
        Me.PanelPKDorada.Controls.Add(Me.gbPKVrati)
        Me.PanelPKDorada.Controls.Add(Me.btnCancelPKDorada)
        Me.PanelPKDorada.Controls.Add(Me.btnOKPKDorada)
        Me.PanelPKDorada.Location = New System.Drawing.Point(12, 107)
        Me.PanelPKDorada.Name = "PanelPKDorada"
        Me.PanelPKDorada.Size = New System.Drawing.Size(544, 313)
        Me.PanelPKDorada.TabIndex = 1042
        '
        'lblTrazeniNaDoradu
        '
        Me.lblTrazeniNaDoradu.AutoSize = True
        Me.lblTrazeniNaDoradu.Location = New System.Drawing.Point(17, 192)
        Me.lblTrazeniNaDoradu.Name = "lblTrazeniNaDoradu"
        Me.lblTrazeniNaDoradu.Size = New System.Drawing.Size(522, 14)
        Me.lblTrazeniNaDoradu.TabIndex = 10000072
        Me.lblTrazeniNaDoradu.Text = "Spisak krugova koje ste tražili na doradu i za koje čekate odgovor od instruktora" &
    ":"
        '
        'gbPKVrati
        '
        Me.gbPKVrati.Controls.Add(Me.cmbVratiPK)
        Me.gbPKVrati.Controls.Add(Me.txtVratiPK)
        Me.gbPKVrati.Controls.Add(Me.Label43)
        Me.gbPKVrati.Controls.Add(Me.Label44)
        Me.gbPKVrati.Location = New System.Drawing.Point(16, 12)
        Me.gbPKVrati.Name = "gbPKVrati"
        Me.gbPKVrati.Size = New System.Drawing.Size(520, 171)
        Me.gbPKVrati.TabIndex = 10000071
        Me.gbPKVrati.TabStop = False
        '
        'cmbVratiPK
        '
        Me.cmbVratiPK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbVratiPK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbVratiPK.CausesValidation = False
        Me.cmbVratiPK.FormattingEnabled = True
        Me.cmbVratiPK.Location = New System.Drawing.Point(166, 19)
        Me.cmbVratiPK.Name = "cmbVratiPK"
        Me.cmbVratiPK.Size = New System.Drawing.Size(348, 22)
        Me.cmbVratiPK.TabIndex = 10000072
        '
        'txtVratiPK
        '
        Me.txtVratiPK.Location = New System.Drawing.Point(166, 43)
        Me.txtVratiPK.MaxLength = 500
        Me.txtVratiPK.Multiline = True
        Me.txtVratiPK.Name = "txtVratiPK"
        Me.txtVratiPK.Size = New System.Drawing.Size(348, 118)
        Me.txtVratiPK.TabIndex = 15
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(6, 22)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(153, 14)
        Me.Label43.TabIndex = 68
        Me.Label43.Text = "Tražim na doradu krug:"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(105, 47)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(54, 14)
        Me.Label44.TabIndex = 70
        Me.Label44.Text = "Razlog:"
        '
        'btnCancelPKDorada
        '
        Me.btnCancelPKDorada.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelPKDorada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelPKDorada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelPKDorada.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPKDorada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCancelPKDorada.Location = New System.Drawing.Point(345, 278)
        Me.btnCancelPKDorada.Name = "btnCancelPKDorada"
        Me.btnCancelPKDorada.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelPKDorada.TabIndex = 70
        Me.btnCancelPKDorada.Text = "Cancel"
        Me.btnCancelPKDorada.UseVisualStyleBackColor = False
        '
        'btnOKPKDorada
        '
        Me.btnOKPKDorada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOKPKDorada.BackColor = System.Drawing.SystemColors.Control
        Me.btnOKPKDorada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOKPKDorada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOKPKDorada.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKPKDorada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnOKPKDorada.Location = New System.Drawing.Point(444, 278)
        Me.btnOKPKDorada.Name = "btnOKPKDorada"
        Me.btnOKPKDorada.Size = New System.Drawing.Size(90, 24)
        Me.btnOKPKDorada.TabIndex = 65
        Me.btnOKPKDorada.Text = "OK"
        Me.btnOKPKDorada.UseVisualStyleBackColor = False
        '
        'labelsToolTip
        '
        Me.labelsToolTip.ToolTipTitle = "Napomena instruktora"
        '
        'btnInformation
        '
        Me.btnInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnInformation.BackColor = System.Drawing.Color.White
        Me.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInformation.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformation.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnInformation.Location = New System.Drawing.Point(1082, 158)
        Me.btnInformation.Name = "btnInformation"
        Me.btnInformation.Size = New System.Drawing.Size(47, 37)
        Me.btnInformation.TabIndex = 1060
        Me.btnInformation.TabStop = False
        Me.btnInformation.Text = "ⓘ"
        Me.btnInformation.UseVisualStyleBackColor = False
        Me.btnInformation.Visible = False
        '
        'FormPopisAdresar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoScroll = False
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelLegendaDGV2)
        Me.Controls.Add(Me.btnInformation)
        Me.Controls.Add(Me.PanelPKDorada)
        Me.Controls.Add(Me.btnVracanjeKrugova)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelIzmenaUL)
        Me.Controls.Add(Me.PanelLegendaDGV1)
        Me.Controls.Add(Me.PanelZahtev)
        Me.Controls.Add(Me.PanelNapomenaLica)
        Me.Controls.Add(Me.PanelZakazivanjeStana)
        Me.Controls.Add(Me.PanelNUl)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnMapa)
        Me.Controls.Add(Me.lblBrojKBR)
        Me.Controls.Add(Me.BtnSvaLica)
        Me.Controls.Add(Me.ButtonZakazani)
        Me.Controls.Add(Me.PanelNapomenaStan)
        Me.Controls.Add(Me.ButtonLK)
        Me.Controls.Add(Me.ButtonIzvestaji)
        Me.Controls.Add(Me.PanelSpisakUlica)
        Me.Controls.Add(Me.ButtonResetUl)
        Me.Controls.Add(Me.lblnaselje)
        Me.Controls.Add(Me.ButtonSpisakUlica)
        Me.Controls.Add(Me.LblOps)
        Me.Controls.Add(Me.ButtonIzlaz)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ButtonResetPK)
        Me.Controls.Add(Me.lblUlica)
        Me.Controls.Add(Me.ButtonNastavi)
        Me.Controls.Add(Me.MinLatituda)
        Me.Controls.Add(Me.MaxLongituda)
        Me.Controls.Add(Me.MaxLatituda)
        Me.Controls.Add(Me.MinLongituda)
        Me.Controls.Add(Me.tboxIDULICE)
        Me.Controls.Add(Me.ButtonUnosNovogKBR)
        Me.Controls.Add(Me.lblPK)
        Me.Controls.Add(Me.ButtonUnosNoveUlice)
        Me.Controls.Add(Me.PanelIzmenaNazivaNoveUlice)
        Me.Controls.Add(Me.chbZavrsenKrug)
        Me.Controls.Add(Me.PanelLegendaDGV3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        
        Me.Name = "FormPopisAdresar"
        Me.HP.SetShowHelp(Me, False)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adresar                  F4 ili FN+F4 - otvara na polju izbor popisnog kruga, izb" &
    "or ulice na mapi"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.gbKBR.ResumeLayout(False)
        Me.gbKBR.PerformLayout()
        Me.PanelZahtev.ResumeLayout(False)
        Me.PanelZahtev.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelNUl.ResumeLayout(False)
        Me.PanelNUl.PerformLayout()
        Me.gbKBRUL.ResumeLayout(False)
        Me.gbKBRUL.PerformLayout()
        CType(Me.DGV2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.PanelZakazivanjeStana.ResumeLayout(False)
        Me.PanelZakazivanjeStana.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.PanelLegendaDGV1.ResumeLayout(False)
        Me.PanelLegendaDGV1.PerformLayout()
        Me.PanelLegendaDGV2.ResumeLayout(False)
        Me.PanelLegendaDGV2.PerformLayout()
        Me.PanelIzmenaNazivaNoveUlice.ResumeLayout(False)
        Me.PanelIzmenaNazivaNoveUlice.PerformLayout()
        Me.PanelIzmenaUL.ResumeLayout(False)
        Me.PanelIzmenaUL.PerformLayout()
        Me.PanelSpisakUlica.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelNapomenaStan.ResumeLayout(False)
        Me.PanelNapomenaStan.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.PanelNapomenaLica.ResumeLayout(False)
        Me.PanelNapomenaLica.PerformLayout()
        Me.PanelUklanjanje.ResumeLayout(False)
        Me.PanelUklanjanje.PerformLayout()
        Me.PodpanelNapomenaLica.ResumeLayout(False)
        Me.PodpanelNapomenaLica.PerformLayout()
        Me.PanelLegendaDGV3.ResumeLayout(False)
        Me.PanelLegendaDGV3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PanelPKDorada.ResumeLayout(False)
        Me.PanelPKDorada.PerformLayout()
        Me.gbPKVrati.ResumeLayout(False)
        Me.gbPKVrati.PerformLayout()
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

    Dim color1 As Color = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(205, Byte), Integer))
    Dim color2 As Color = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(188, Byte), Integer))
    Dim color3 As Color = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(167, Byte), Integer))
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        If m.Msg = WM_NCLBUTTONDOWN Then Return
        MyBase.WndProc(m)
    End Sub
    Private Sub ButtonIzvestaji_Click(sender As Object, e As EventArgs) Handles ButtonIzvestaji.Click

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        'If Panel3.Visible = True Then
        '    Call Cancel()
        'End If
        'If PanelNUl.Visible = True Then
        '    Call CancelNUL()
        'End If
        Call zatvoriIPonistiPanele()
        'Call MrefreshClick()
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



        lblOuter.FlatStyle = 0
        lblOuter.BorderStyle = BorderStyle.FixedSingle
        lblOuter.BackColor = Color.Transparent
        lblOuter.Text = String.Empty
        Me.kosam = kosam
        fiktivnianketar = kosam

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

        Call SetLang()
        Call Reset()

        For Each cntl As Control In Panel3.Controls
            If TypeOf cntl Is TextBox Then
                '*****
                AddHandler DirectCast(cntl, TextBox).KeyPress, AddressOf Me.pp_KeyPress
                AddHandler DirectCast(cntl, TextBox).KeyDown, AddressOf Me.pp_KeyDown
                AddHandler DirectCast(cntl, TextBox).Enter, AddressOf Me.pp_Enter
            End If
            If TypeOf cntl Is ComboBox Then
                '*****
                AddHandler DirectCast(cntl, ComboBox).KeyDown, AddressOf Me.cbpp_KeyDown
            End If
        Next
        For Each cntl As Control In PanelNapomenaLica.Controls
            If TypeOf cntl Is TextBox Then
                '*****
                AddHandler DirectCast(cntl, TextBox).KeyPress, AddressOf Me.pp_KeyPress
                AddHandler DirectCast(cntl, TextBox).KeyDown, AddressOf Me.pp_KeyDown
                AddHandler DirectCast(cntl, TextBox).Enter, AddressOf Me.pp_Enter
            End If
        Next
        For Each cntl As Control In Me.Controls
            If TypeOf cntl Is TextBox Then
                '*****
                AddHandler DirectCast(cntl, TextBox).KeyPress, AddressOf Me.pp_KeyPress
                AddHandler DirectCast(cntl, TextBox).KeyDown, AddressOf Me.pp_KeyDown
                AddHandler DirectCast(cntl, TextBox).Enter, AddressOf Me.pp_Enter
            End If
        Next
        For Each cntl As Control In PanelNUl.Controls
            If TypeOf cntl Is TextBox Then
                '*****
                AddHandler DirectCast(cntl, TextBox).KeyPress, AddressOf Me.pp_KeyPress
                AddHandler DirectCast(cntl, TextBox).KeyDown, AddressOf Me.pp_KeyDown
                AddHandler DirectCast(cntl, TextBox).Enter, AddressOf Me.pp_Enter
            End If
        Next
        For Each cntl As Control In PanelNapomenaStan.Controls
            If TypeOf cntl Is TextBox Then
                '*****
                AddHandler DirectCast(cntl, TextBox).KeyPress, AddressOf Me.pp_KeyPress
                AddHandler DirectCast(cntl, TextBox).KeyDown, AddressOf Me.pp_KeyDown
                AddHandler DirectCast(cntl, TextBox).Enter, AddressOf Me.pp_Enter
            End If
        Next
        For Each cntl As Control In PanelIzmenaUL.Controls
            If TypeOf cntl Is TextBox Then
                '*****
                AddHandler DirectCast(cntl, TextBox).KeyPress, AddressOf Me.pp_KeyPress
                AddHandler DirectCast(cntl, TextBox).KeyDown, AddressOf Me.pp_KeyDown
                AddHandler DirectCast(cntl, TextBox).Enter, AddressOf Me.pp_Enter
            End If
        Next

        MinLongituda.Text = "18.829593888"
        MaxLongituda.Text = "23.012929222"
        MinLatituda.Text = "41.8910378"
        MaxLatituda.Text = "46.1919378"

        dodatak = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                  " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                  " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                  " Set @Hash  = '12345';    " + vbCrLf +
                  " Declare @a as varbinary(256);  " + vbCrLf

        Me.ButtonNastavi.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela"
        Me.ButtonUnosNoveUlice.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela"


        Call srediGridView222()

    End Sub
    Dim txtcloudcati As Boolean = False
    Dim anketarcloud As String = ""
    Dim fiktivnianketar As String = ""   '"PP70149002"

    Private Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub

    Dim TabControl1locX As Integer = 0
    Dim TabControl1locY As Integer = 0
    Dim TabControl1Height As Integer = 0
    Private Sub FormDnevnikAnketiranja_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call PreVentFlicker()
        'Me.WindowState = FormWindowState.Maximized
        btnMapa.Location = New Point(ButtonUnosNovogKBR.Location.X, ButtonUnosNovogKBR.Location.Y - 30)
        TabControl1.Location = New Point(Me.ButtonUnosNovogKBR.Location.X, Me.ButtonUnosNovogKBR.Location.Y + ButtonUnosNovogKBR.Height + 10)
        TabControl1.Width = Me.Width - 30
        TabControl1.Height = (Screen.PrimaryScreen.WorkingArea.Height - Me.ButtonUnosNovogKBR.Location.Y - Me.ButtonUnosNovogKBR.Height - 32)
        chbZavrsenKrug.Location = New Point(btnMapa.Location.X + btnMapa.Width + 30, btnMapa.Location.Y)

        TabControl1locX = TabControl1.Location.X
        TabControl1locY = TabControl1.Location.Y
        TabControl1Height = TabControl1.Height

        EnableDoubleBuffered(DGV1)
        EnableDoubleBuffered(DGV2)
        EnableDoubleBuffered(DGV3)

        Me.DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV1.ColumnHeadersHeight = Me.DGV1.ColumnHeadersHeight * 2
        Me.DGV1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        Me.DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV2.ColumnHeadersHeight = Me.DGV2.ColumnHeadersHeight * 2
        Me.DGV2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing


        Me.DGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DGV3.ColumnHeadersHeight = Me.DGV3.ColumnHeadersHeight * 2
        Me.DGV3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        Me.DGV3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        ButtonSpisakUlica.Size = ButtonResetPK.Size
        ButtonIzlaz.Location = New Point(Me.Width - 25 - ButtonResetPK.Width, ButtonIzlaz.Location.Y)
        ButtonResetPK.Location = New Point(Me.Width - 25 - ButtonResetPK.Width, ButtonIzlaz.Location.Y + ButtonIzlaz.Height + 2)
        ButtonResetUl.Location = New Point(ButtonResetPK.Location.X, ButtonResetPK.Location.Y + ButtonResetPK.Height + 2)
        ButtonZakazani.Location = New Point(ButtonResetUl.Location.X, ButtonResetUl.Location.Y + ButtonResetUl.Height + 2)
        'BtnSvaLica.Location = New Point(ButtonZakazani.Location.X, ButtonZakazani.Location.Y + ButtonZakazani.Height + 2)

        'ButtonIzvestaji.Location = New Point(BtnSvaLica.Location.X, BtnSvaLica.Location.Y + BtnSvaLica.Height + 2)
        ButtonIzvestaji.Location = New Point(ButtonZakazani.Location.X, ButtonZakazani.Location.Y + ButtonZakazani.Height + 2)
        'ButtonSpisakUlica.Location = New Point(Me.Width - 25 - ButtonSpisakUlica.Width, ButtonResetPK.Location.Y + ButtonResetPK.Height + 10)
        PanelLegendaDGV1.Location = New Point(ButtonIzlaz.Location.X - PanelLegendaDGV1.Width - 2, ButtonIzlaz.Location.Y)
        PanelLegendaDGV2.Location = New Point(ButtonIzlaz.Location.X - PanelLegendaDGV1.Width - 2, ButtonIzlaz.Location.Y)
        PanelLegendaDGV3.Location = New Point(ButtonIzlaz.Location.X - PanelLegendaDGV1.Width - 2, ButtonIzlaz.Location.Y)
        Panel3.Location = New Point((TabControl1.Width - Panel3.Width) \ 2, TabControl1.Location.Y - 150)
        PanelNapomenaLica.Location = New Point((TabControl1.Width - PanelNapomenaLica.Width) \ 2, TabControl1.Location.Y - 150)
        PanelZakazivanjeStana.Location = New Point((TabControl1.Width - PanelZakazivanjeStana.Width) \ 2, TabControl1.Location.Y + TabControl1.Height - PanelZakazivanjeStana.Height - 100)
        PanelSpisakUlica.Location = Panel3.Location
        PanelZahtev.Location = Panel3.Location
        PanelNUl.Location = New Point(ButtonNastavi.Location.X + ButtonNastavi.Width + 10, ButtonNastavi.Location.Y)
        'lblInformation.Location = New Point(ButtonNastavi.Location.X + ButtonNastavi.Width + 10, ButtonNastavi.Location.Y)
        btnInformation.Location = New Point(ButtonNastavi.Location.X + ButtonNastavi.Width + 10, ButtonNastavi.Location.Y)
        'linklblIstiKrugDrugiPopisivac.Location = New Point(ButtonNastavi.Location.X + ButtonNastavi.Width + 10, ButtonNastavi.Location.Y)
        PanelIzmenaUL.Location = PanelNUl.Location
        btnVracanjeKrugova.Location = New Point(ButtonIzvestaji.Location.X, ButtonIzvestaji.Location.Y + ButtonIzvestaji.Height + 2)
        PanelNapomenaStan.Location = New Point((TabControl1.Width - PanelZakazivanjeStana.Width) \ 2, TabControl1.Location.Y + TabControl1.Height - PanelZakazivanjeStana.Height - 100)
        PanelPKDorada.Location = New Point((TabControl1.Width - PanelZakazivanjeStana.Width) \ 2, TabControl1.Location.Y + TabControl1.Height - PanelZakazivanjeStana.Height - 100)

        If atbOps.Enabled = False Then
            atbPK.Focus()
        Else
            atbOps.Focus()
        End If

        SetCueText(filterUlica, "🔎 unesite pojam za pretragu")
        SetCueText(filterStatus, "*")
        SetCueText(filterUlicaMapa, "🔎")
        SetCueText(filterNapomenaKBR, "🔎")
        SetCueText(filterDatumZakazan, "*")
        SetCueText(filterStatusDGV2, "*")
        SetCueText(filterUlicaDGV2, "🔎 unesite pojam za pretragu")
        SetCueText(filterAdresaTerenDGV2, "*")
        SetCueText(filterUlicaDGV3, "🔎 unesite pojam za pretragu")
        SetCueText(filterImePrezime, "🔎")
        'SetCueText(filterJMBG, "🔎")

        'Call LegMinimize()
        'Call LegMaximize()
        PanelLegendaDGV1.Visible = False
        PanelLegendaDGV2.Visible = False
        PanelLegendaDGV3.Visible = False
    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        If e.ColumnIndex <> DGV1.Columns("OOPEN1").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("DA").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("EEDIT").DisplayIndex AndAlso e.ColumnIndex <> DGV1.Columns("DDELETE").DisplayIndex Then
            Exit Sub
        End If
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        Else
            Call Dgv1CellContentClick(e.RowIndex, e.ColumnIndex)
        End If

        ' End If

    End Sub
    Dim dosaoIzCapiAdresara As Boolean = True
    Dim stariKBR As String = ""
    Dim staraLong As String = ""
    Dim staraLat As String = ""
    Dim staraNapomena As String = ""
    Sub Dgv1CellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)

        Me.Cursor = Cursors.WaitCursor

        If erowindex >= 0 Then
            DGV1.ClearSelection()
            DGV1.Rows(erowindex).Selected = True
            'Dim selectedRowCount As Integer = DGV1.Rows.GetRowCount(DataGridViewElementStates.Selected)

            If DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("OOPEN1").DisplayIndex Then
                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim tabela As String = "P2_OBJEKAT"
                Dim zakljucanOdmahSve As Boolean = False
                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True : zakljucanOdmahSve = True

                Dim KljuceviSaEkranaSaVrednostima(,) As String
                ReDim KljuceviSaEkranaSaVrednostima(2, 1)
                KljuceviSaEkranaSaVrednostima(0, 0) = "mbops".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(0, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("mbops").Index).Value.ToString
                KljuceviSaEkranaSaVrednostima(1, 0) = "Krug_idcd".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(1, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("Krug_idcd").Index).Value.ToString
                KljuceviSaEkranaSaVrednostima(2, 0) = "kucni_broj_idCD".Trim.ToUpper
                KljuceviSaEkranaSaVrednostima(2, 1) = DGV1.Rows(erowindex).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString

                'filterDatumZakazan.Items.Clear()

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
                '20220715 Call refreshDGV1()

                Dim pomocnaNapomenaKBR As String = ""
                Dim pomocnaUlicaMapa As String = ""
                Dim pomocnaUlica As String = ""
                Dim pomocna As String = ""
                If Not filterNapomenaKBR Is Nothing Then
                    pomocnaNapomenaKBR = filterNapomenaKBR.Text
                End If
                If Not filterUlicaMapa Is Nothing Then
                    pomocnaUlicaMapa = filterUlicaMapa.Text
                End If
                If Not filterUlica Is Nothing Then
                    pomocnaUlica = filterUlica.Text
                End If
                If Not filterStatus Is Nothing Then
                    pomocna = filterStatus.Text
                    If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
                    If pomocna = "*" Then pomocna = ""
                End If
                refreshDGV1(pomocnaUlica, pomocna, pomocnaUlicaMapa, pomocnaNapomenaKBR)
                If DGV1.Rows.Count > 0 Then
                    If DGV1.Rows.Count - 1 >= erowindex Then
                        DGV1.Focus()
                        DGV1.ClearSelection()
                        DGV1.Rows(erowindex).Selected = True
                    End If
                End If

            End If
            If DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("DA").DisplayIndex Then
                filterDatumZakazan.SelectedIndex = -1
                Call refreshDGV2(erowindex)
                Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' and " +
                                                            "mbops='" + atbOps.sselectedValue + "'" +
                                                            " and Krug_idcd='" + atbPK.sselectedValue + "'" +
                                                            " and kucni_broj_idCD='" + DGV1.Rows(erowindex).Cells(DGV1.Columns("kucni_broj_idCD").Index).Value.ToString + "'" +
                                                            " order by ZakazanoDatum", Me.DBConnectionString, False, False, True, True)
                If DGV2.Rows.Count > 0 Then
                    DGV2.Tag = erowindex
                    Me.TabControl1.SelectedTab = Me.TabPage2
                    DGV2.Visible = True
                    DGV2.Focus()
                    DGV2.ClearSelection()
                    DGV2.Rows(0).Selected = True
                    Me.Cursor = Cursors.Default
                    
                End If

                Exit Sub
            End If

            If DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("EEDIT").DisplayIndex Then
                gbKBR.Visible = True
                btnMapaKbr.Tag = ""
                btnMapaIzmenaKBR.Tag = "izmena"
                Dim opstina As String = atbOps.sselectedValue.Trim
                If postojiMapa() = False Then
                    btnMapaIzmenaKBR.Visible = False
                Else
                    btnMapaIzmenaKBR.Visible = True
                End If
                btnMapaKbr.Visible = False
                llNastavi.Visible = False
                gbKBR.Visible = True
                DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True
                If DGV1.Rows.Count - 1 >= erowindex Then
                    DGV1.Rows(erowindex).Selected = True
                Else
                    DGV1.Rows(0).Selected = True
                End If

                'odaklesidosao.text = "grid"
                Call Promena(erowindex)
                stariKBR = tboxkbr.Text
                staraLong = tboxLongituda.Text
                staraLat = tboxLatituda.Text
                staraNapomena = tboxNapomenaOKucnomBroju.Text
                Me.Cursor = Cursors.Default
                
                Exit Sub
            End If

            If DGV1.Columns(eColumnIndex).DisplayIndex = DGV1.Columns("DDELETE").DisplayIndex Then
                Call BrisanjeReda(erowindex)
                erowindex = erowindex - 1
            End If
        End If

        If erowindex >= 0 AndAlso DGV1.Rows.Count > 0 Then
            Call refreshDGV2(erowindex)
            If DGV2.Rows.Count > 0 Then
                DGV2.Focus()
                DGV2.ClearSelection()
                DGV2.Rows(0).Selected = True
            End If
        Else
            'ivanaaa
            Call praznidgv2()
        End If
        Me.Cursor = Cursors.Default
        
    End Sub



    Private Sub dgv3_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DGV3.CellContentClick
        If e.ColumnIndex <> DGV3.Columns("OOPENSTAN").DisplayIndex AndAlso e.ColumnIndex <> DGV3.Columns("EEditNapomena").DisplayIndex Then
            Exit Sub
        End If
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        Else
            Call Dgv3CellContentClick(e.RowIndex, e.ColumnIndex)
        End If

        ' End If

    End Sub


    Sub Dgv3CellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)
        Dim pomrowDGV1 As Integer = 0
        Dim pomrowDGV2 As Integer = 0
        Dim kojistan As String = ""

        Me.Cursor = Cursors.WaitCursor
        If erowindex >= 0 Then
            DGV3.ClearSelection()
            DGV3.Rows(erowindex).Selected = True
            'Dim selectedRowCount As Integer = DGV1.Rows.GetRowCount(DataGridViewElementStates.Selected)
            If DGV1.SelectedCells.Count > 0 Then
                pomrowDGV1 = DGV1.SelectedCells.Item(0).RowIndex
            Else
                Dim kojimbops As String = DGV3.Rows(erowindex).Cells("mbops").Value.ToString()
                Dim kojikrug As String = DGV3.Rows(erowindex).Cells("krug_idcd").Value.ToString()
                Dim kojikbr As String = DGV3.Rows(erowindex).Cells("kucni_broj_idcd").Value.ToString()
                For i As Integer = 0 To DGV1.Rows.Count - 1
                    If kojimbops.Trim = DGV1.Rows(i).Cells("mbops").Value.ToString.Trim AndAlso kojikrug.Trim = DGV1.Rows(i).Cells("krug_idcd").Value.ToString.Trim AndAlso
                        kojikbr.Trim = DGV1.Rows(i).Cells("kucni_broj_idcd").Value.ToString.Trim Then
                        pomrowDGV1 = i
                        Exit For
                    End If
                Next
            End If

            kojistan = DGV3.Rows(erowindex).Cells("rbrstan").Value.ToString()
            For i As Integer = 0 To DGV2.Rows.Count - 1
                If kojistan.Trim = DGV2.Rows(i).Cells("rbrstan").Value.ToString().Trim Then
                    pomrowDGV2 = i
                    Exit For
                End If
            Next

            If DGV3.Columns(eColumnIndex).DisplayIndex = DGV3.Columns("OOPENSTAN").DisplayIndex Then
                DGV3.ClearSelection()
                'DGV3.Rows(erowindex).Selected = True
                If DGV3.Rows.Count - 1 >= erowindex Then
                    DGV3.Rows(erowindex).Selected = True
                Else
                    DGV3.Rows(0).Selected = True
                End If

                Dim zzak As Boolean = False
                Dim red As Integer = erowindex

                Dim tabela As String = "P2_STAN"
                Dim podtabela As String = ""
                Dim zakljucanOdmahSve As Boolean = False
                If DGV3.Rows(erowindex).Cells("RbrDom").Value.ToString.Trim = "0" Then
                    podtabela = "vspisaklica"
                Else
                    podtabela = "spisaklica"
                    If DGV3.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV3.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                        zakljucanOdmahSve = True
                    ElseIf DGV3.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                        Dim msgtxt As String = "Stan u kom živi ovo lice je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za lice poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"
                        ''videti šta ako postoje podaci!!!!! NISTA, NIJE DOZVOLJENO
                        Dim msgtitle As String = "............"

                        Dim opc As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle)
                        Select Case opc
                            Case "Yes"

                            Case "No"
                                Me.Cursor = Cursors.Default
                                
                                Exit Sub
                        End Select
                    End If
                End If
                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True
                'If DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("QC").Index).Value.ToString <> "" AndAlso
                '         DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("Poslat").Index).Value.ToString <> "" Then
                '    zakljucanOdmahSve = True
                'End If
                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviPodtabela() As String = DajKljuceve(podtabela)

                Dim KljuceviGlavnaSaVrednostima(,) As String
                Dim KljuceviPodtabelaSavrednostima(,) As String

                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                ReDim KljuceviPodtabelaSavrednostima(KljuceviPodtabela.GetUpperBound(0), 1)


                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV3.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next

                For i As Integer = 0 To KljuceviPodtabela.GetUpperBound(0)
                    KljuceviPodtabelaSavrednostima(i, 0) = KljuceviPodtabela(i).Trim.ToUpper
                    KljuceviPodtabelaSavrednostima(i, 1) = DGV3.Rows(erowindex).Cells(KljuceviPodtabela(i).Trim.ToUpper).Value
                Next

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
                'If filterDatumZakazan.Tag = "svi" Then
                '    refreshdgv2zakazni()
                'Else
                'Call refreshDGV2(erowindex)
                'End If
                If Not filterUlicaDGV3.Tag Is Nothing AndAlso filterUlicaDGV3.Tag = "svi" Then
                    Dim pomocna As String = ""
                    If Not filterStatus Is Nothing Then
                        pomocna = filterStatus.Text
                        If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
                        If pomocna = "*" Then pomocna = ""
                    End If
                    refreshDGV1(filterUlica.Text, pomocna, filterUlicaMapa.Text, filterNapomenaKBR.Text)
                    'refreshDGV1()
                    refreshdgv3svalica()
                    filterUlicaDGV3.Text = ""
                    filterImePrezime.Text = ""
                    'filterJMBG.Text = ""
                    Me.Cursor = Cursors.Default
                    
                    Exit Sub
                End If
            ElseIf DGV3.Columns(eColumnIndex).DisplayIndex = DGV3.Columns("eeditnapomena").DisplayIndex Then
                DGV3.ClearSelection()
                'DGV3.Rows(erowindex).Selected = True
                If DGV3.Rows.Count - 1 >= erowindex Then
                    DGV3.Rows(erowindex).Selected = True
                Else
                    DGV3.Rows(0).Selected = True
                End If

                Dim pom As String = ""
                'BtnOkNapomenaLica.Tag = pomrowDGV2
                DGV3.Tag = pomrowDGV2
                'odaklesidosao.text = "grid"
                Call OtvoriNapomenuDGV3(erowindex)
                Me.Cursor = Cursors.Default
                
                Exit Sub

                'Call PanelNapomenaLicaVisible()
            End If

        End If

        If erowindex >= 0 AndAlso DGV3.Rows.Count > 0 Then
            'Call refreshDGV1()
            Dim pomocna As String = ""
            If Not filterStatus Is Nothing Then
                pomocna = filterStatus.Text
                If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
                If pomocna = "*" Then pomocna = ""
            End If
            refreshDGV1(filterUlica.Text, pomocna, filterUlicaMapa.Text, filterNapomenaKBR.Text)
            If DGV1.Rows.Count > 0 Then
                DGV1.ClearSelection()
                'DGV1.Rows(pomrowDGV1).Selected = True
                If DGV1.Rows.Count - 1 >= pomrowDGV1 Then
                    DGV1.Rows(pomrowDGV1).Selected = True
                Else
                    DGV1.Rows(0).Selected = True
                End If

            End If

            If pRbrStan = "" Then
                Call refreshDGV2(pomrowDGV1)
                If DGV2.Rows.Count > 0 Then
                    'DGV2.ClearSelection()
                    'DGV2.Rows(pomrowDGV2).Selected = True
                End If
            Else

                Call refreshDGV2(pomrowDGV1, , , , , kojistan)
                If DGV2.Rows.Count > 0 Then
                    DGV2.ClearSelection()
                    'DGV2.Rows(pomrowDGV2).Selected = True
                    If DGV2.Rows.Count - 1 >= pomrowDGV2 Then
                        DGV2.Rows(pomrowDGV2).Selected = True
                    Else
                        DGV2.Rows(0).Selected = True
                    End If


                End If
            End If

            If DGV3.Rows.Count > 0 Then
                DGV3.Focus()
                DGV3.ClearSelection()
                'DGV3.Rows(erowindex).Selected = True
                If DGV3.Rows.Count - 1 >= erowindex Then
                    DGV3.Rows(erowindex).Selected = True
                Else
                    DGV3.Rows(0).Selected = True
                End If

            End If
        Else
            'ivanaaa
            Call praznidgv3()
        End If
        Me.Cursor = Cursors.Default
        
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
    Dim dodatak As String = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                  " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                  " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                  " Set @Hash  = '12345';    " + vbCrLf +
                  " Declare @a as varbinary(256);  " + vbCrLf
    Sub refreshDGV1(Optional ByVal ulicaKBroj As String = "", Optional ByVal status As String = "", Optional ByVal NoviKbrojTeren As String = "", Optional ByVal NapomenaOKucnomBroju As String = "", Optional ponistisort As Boolean = False)
        '✔
        Dim str As String = ""
        If status = "*" Then
            status = ""
        End If
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
        If ponistisort = True Then
            a = "NONE"
        End If



        If atbUlica.sselectedValue <> "" AndAlso atbUlica.sselectedValue <> "000000000000" Then
            str = dodatak + " select * from (select distinct" + nvrd +
            " (case when isnull(b.adresateren,0)=0 then ' '" + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0)=0 then '0' " + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0) not in (5,6) " + nvrd +
            " and isnull(b.brojstanova,9999)<> (select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD" + nvrd +
            " and a.KRUG_IDCD=b.KRUG_IDCD and a.mbops=b.mbops and a.qc=1 and exists (select * from adresar xx where xx.mbops=a.mbops And xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(statusanketar,0) in (1,2))  )" + nvrd +
            " and ((isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)<>0) or (isnull(vrstazgrade,0) in (1,2,3))) then '0'" + nvrd +
            " when isnull(b.adresateren,0)=4 or isnull(vrstazgrade,0) in (5,6) or (isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)=0) or " + nvrd +
            " isnull(b.brojstanova,9999)=(select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD and a.KRUG_IDCD=b.KRUG_IDCD and a.qc=1 and exists (select * from adresar xx where xx.mbops=a.mbops And xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(statusanketar,0) in (1,2)))" + nvrd +
            " then '2' end) as Status," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.UlicakBroj)='' then NULL else  a.UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicaKBroj," + nvrd +
            " (case when isnull(b.adresateren,0)=4 then N'Ne postoji zgrada na ovoj adresi' else (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(b.noviNazivUliceTeren)='' then NULL else b.noviNazivUliceTeren end),1), 1, CONVERT(varbinary, @Hash)))))+' '+b.NoviKbrojTeren) end) as NoviKbrojTeren, " + nvrd +
            " N'🏠' as OOpen1," + nvrd +
            " (case when isnull(vrstazgrade,0)=1 then N'Stambena zgrada / kuća' when isnull(vrstazgrade,0)=2 then N'Zgrada za kolektivni smeštaj' when isnull(vrstazgrade,0)=3 then N'Zgrada/ objekat nastanjena iz nužde'" + nvrd +
            " when isnull(vrstazgrade,0)=4 then N'Nestambena zgrada (škola, hotel, fabrika i sl.)' when isnull(vrstazgrade,0)=5 then N'Pomoćna zgrada koja se ne popisuje' when isnull(vrstazgrade,0)=6 then N'Zgrada u izgradnji koja se ne popisuje' " + nvrd +
            " else '' end) as vrstazgrade,' ' as praznoA," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(b.brojstanova As varchar(4)),'') else '' end) as BrojStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then" + nvrd +
            " (select cast(count(*) as varchar(4)) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan)) else '' end) as BrojZavrStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan)) as varchar(6)),'') else '' end) as BrojNeZavrStanova,' ' as praznoD," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD and isnull(ishod,0) in (2,3,4,5)) else '' end) as BrojZakStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=1) else '' end) as BrojZakP11Stanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=6 and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  )) and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1) ) else '' end) as BrojZakOdbStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=7 and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  )) and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1)) else '' end) as BrojZakNOKStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast((isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan))" + nvrd +
            " - (case when (select cast(count(*) as int) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%'))=0 then 0 else " + nvrd +
            " (select cast(count(*) as int) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%')) end )" + nvrd +
            " - (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0) in (1,2,3,4,5,6,7)  and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  )) and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1))) as varchar(6)),'') else '' end) as BrojOstalNezavrStanova, " + nvrd + '' ' as praznoF,
            " (case when (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%'))=0 then '' else " +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%')) end ) as BrojVracenihStanova,' ' as praznoD2," + nvrd +
            " case when isnull(b.BrojStanova,'')='' then '' else N'🏘' end as DA," + nvrd +
            " N'🖉' as EEdit,b.NapomenaOKucnomBroju,' ' as praznoB," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica,a.longituda,a.latituda," + nvrd + '" a.krug,a.kbroj,a.ulica,a.longituda,a.latituda," + nvrd +
            " a.krug_idcd,a.idulice,a.kucni_broj_idcd,a.mbops," + nvrd +
            " case when a.sourceof_INSERT='ANK' then N'📌' else '' end as sourceof_INSERT," + nvrd +
            " case when a.sourceof_INSERT='ANK' and not exists(select * from p2_stan x where a.mbops=x.mbops and a.krug_idcd=x.krug_idcd and a.kucni_broj_idcd=x.kucni_broj_idcd )  then N'🗑' else '' end as DDelete,' ' as praznoE " +
            " from (select * from adresar where trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) like N'%" + ulicaKBroj + "%' and IDANKETAR=N'" + kosam + "') a left join " + nvrd +
            " p2_objekat b on a.krug_idcd=b.krug_idcd and a.kucni_broj_idcd=b.kucni_broj_idcd " + nvrd +
            " where a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and a.idulice='" + atbUlica.sselectedValue + "'" + nvrd +
            " ) aaa  where aaa.status like '%" + status + "%' and isnull(NoviKbrojTeren,'') like N'%" + NoviKbrojTeren + "%' and isnull(NapomenaOKucnomBroju,'') like N'%" + NapomenaOKucnomBroju + "%' order by aaa.ulica asc,len(aaa.kBroj) asc,aaa.kBroj asc"
        ElseIf atbUlica.sselectedValue = "000000000000" Then
            str = dodatak + "select * from (select distinct" + nvrd +
            " (case when isnull(b.adresateren,0)=0 then ' '" + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0)=0 then '0' " + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0) not in (5,6) " + nvrd +
            " and isnull(b.brojstanova,9999)<> (select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD " + nvrd +
            " and a.KRUG_IDCD=b.KRUG_IDCD and a.mbops=b.mbops and a.qc=1 and exists (select * from adresar xx where xx.mbops=a.mbops And xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(statusanketar,0) in (1,2))  )" + nvrd +
            " and ((isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)<>0) or (isnull(vrstazgrade,0) in (1,2,3))) then '0'" + nvrd +
            " when isnull(b.adresateren,0)=4 or isnull(vrstazgrade,0) in (5,6) or (isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)=0) or " + nvrd +
            " isnull(b.brojstanova,9999)= (select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD and a.KRUG_IDCD=b.KRUG_IDCD and a.qc=1 and exists (select * from adresar xx where xx.mbops=a.mbops And xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(statusanketar,0) in (1,2)))" + nvrd +
            " then '2' end) as Status," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.UlicakBroj)='' then NULL else a.UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicaKBroj," + nvrd +
            " (case when isnull(b.adresateren,0)=4 then N'Ne postoji zgrada na ovoj adresi' else (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(b.noviNazivUliceTeren)='' then NULL else b.noviNazivUliceTeren end),1), 1, CONVERT(varbinary, @Hash)))))+' '+b.NoviKbrojTeren) end) as NoviKbrojTeren, " + nvrd +
            " N'🏠' as OOpen1," + nvrd +
            " (case when isnull(vrstazgrade,0)=1 then N'Stambena zgrada / kuća' when isnull(vrstazgrade,0)=2 then N'Zgrada za kolektivni smeštaj' when isnull(vrstazgrade,0)=3 then N'Zgrada/ objekat nastanjena iz nužde'" + nvrd +
            " when isnull(vrstazgrade,0)=4 then N'Nestambena zgrada (škola, hotel, fabrika i sl.)' when isnull(vrstazgrade,0)=5 then N'Pomoćna zgrada koja se ne popisuje' when isnull(vrstazgrade,0)=6 then N'Zgrada u izgradnji koja se ne popisuje' " + nvrd +
            " else '' end) as vrstazgrade,' ' as praznoA, " + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(b.brojstanova As varchar(4)),'') else '' end) as BrojStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then" + nvrd +
            " (select cast(count(*) as varchar(4)) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan)) else '' end) as BrojZavrStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan)) as varchar(6)),'') else '' end) as BrojNeZavrStanova, ' ' as praznoD," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD and isnull(ishod,0) in (2,3,4,5)) else '' end) as BrojZakStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=1) else '' end) as BrojZakP11Stanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=6 and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  ))  and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1)) else '' end) as BrojZakOdbStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=7 and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  ))  and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1)) else '' end) as BrojZakNOKStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast((isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan))" + nvrd +
            " - (case when (select cast(count(*) as int) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%'))=0 then 0 else " + nvrd +
            " (select cast(count(*) as int) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%')) end )" + nvrd +
            " - (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0) in (1,2,3,4,5,6,7)  and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  )) and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1))) as varchar(6)),'') else '' end) as BrojOstalNezavrStanova, " + nvrd + '' ' as praznoF,
            " (case when (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%'))=0 then '' else " +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%')) end ) as BrojVracenihStanova,' ' as praznoD2," + nvrd +
            " case when isnull(b.BrojStanova,'')='' then '' else N'🏘' end as DA," + nvrd +
            " N'🖉' as EEdit,b.NapomenaOKucnomBroju,' ' as praznoB," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica,a.longituda,a.latituda," + nvrd + '" a.krug,a.kbroj,a.ulica,a.longituda,a.latituda," + nvrd +
            " a.krug_idcd,a.idulice,a.kucni_broj_idcd,a.mbops," + nvrd +
            " case when a.sourceof_INSERT='ANK' then N'📌' else '' end as sourceof_INSERT," + nvrd +
            " case when a.sourceof_INSERT='ANK' and not exists(select * from p2_stan x where a.mbops=x.mbops and a.krug_idcd=x.krug_idcd and a.kucni_broj_idcd=x.kucni_broj_idcd ) then N'🗑' else '' end as DDelete,' ' as praznoE " +
            " from (select * from adresar where trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) like N'%" + ulicaKBroj + "%' and IDANKETAR=N'" + kosam + "') a left join " + nvrd +
            " p2_objekat b on a.krug_idcd=b.krug_idcd and a.kucni_broj_idcd=b.kucni_broj_idcd " + nvrd +
            " where a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' " + nvrd +
            " ) aaa  where aaa.status like '%" + status + "%' and isnull(NoviKbrojTeren,'') like N'%" + NoviKbrojTeren + "%' and isnull(NapomenaOKucnomBroju,'') like N'%" + NapomenaOKucnomBroju + "%' order by aaa.ulica asc,len(aaa.kBroj) asc,aaa.kBroj asc"

            '" case when isnull(b.BrojStanova,9999)=9999 and isnull(vrstazgrade,0) in (0,1,2,3,4) and isnull(b.adresateren,0) <> 4 then N'📝' else '' end as NE," + nvrd +
            '" case when isnull(b.BrojStanova,'') ='' then ZakazanoDatumObj else '' end as ZakazanoDatumObj ," + nvrd +
            '" case when isnull(b.BrojStanova,'')='' then ZakazanoVremeObj else '' end as ZakazanoVremeObj," + nvrd +
            '" a.ZakazanoNapomenaObj,' ' as praznoC, " + nvrd +
        Else
            str = dodatak + "select * from (select distinct" + nvrd +
            " (case when isnull(b.adresateren,0)=0 then ' '" + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0)=0 then '0' " + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0) not in (5,6) " + nvrd +
            " and isnull(b.brojstanova,9999)<> (select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD " + nvrd +
            " and a.KRUG_IDCD=b.KRUG_IDCD and a.qc=1 and exists (select * from adresar xx where xx.mbops=a.mbops And xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(statusanketar,0) in (1,2))  )" + nvrd +
            " and ((isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)<>0) or (isnull(vrstazgrade,0) in (1,2,3))) then '0'" + nvrd +
            " when isnull(b.adresateren,0)=4 or isnull(vrstazgrade,0) in (5,6) or (isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)=0) or " + nvrd +
            " isnull(b.brojstanova,9999)= (select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD and a.KRUG_IDCD=b.KRUG_IDCD and a.qc=1 and exists (select * from adresar xx where xx.mbops=a.mbops And xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(statusanketar,0) in (1,2)))" + nvrd +
            " then '2' end) as Status," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.UlicakBroj)='' then NULL else a.UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicaKBroj," + nvrd +
            " (case when isnull(b.adresateren,0)=4 then N'Ne postoji zgrada na ovoj adresi' else (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(b.noviNazivUliceTeren)='' then NULL else b.noviNazivUliceTeren end),1), 1, CONVERT(varbinary, @Hash)))))+' '+b.NoviKbrojTeren) end) as NoviKbrojTeren," + nvrd +
            " N'🏠' as OOpen1," + nvrd +
            " (case when isnull(vrstazgrade,0)=1 then N'Stambena zgrada / kuća' when isnull(vrstazgrade,0)=2 then N'Zgrada za kolektivni smeštaj' when isnull(vrstazgrade,0)=3 then N'Zgrada/ objekat nastanjena iz nužde'" + nvrd +
            " when isnull(vrstazgrade,0)=4 then N'Nestambena zgrada (škola, hotel, fabrika i sl.)' when isnull(vrstazgrade,0)=5 then N'Pomoćna zgrada koja se ne popisuje' when isnull(vrstazgrade,0)=6 then N'Zgrada u izgradnji koja se ne popisuje' " + nvrd +
            " else '' end) as vrstazgrade,' ' as praznoA, " + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(b.brojstanova As varchar(4)),'') else '' end) as BrojStanova," + nvrd +
           " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then" + nvrd +
            " (select cast(count(*) as varchar(4)) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan)) else '' end) as BrojZavrStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan)) as varchar(6)),'') else '' end) as BrojNeZavrStanova, ' ' as praznoD," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD and isnull(ishod,0) in (2,3,4,5)) else '' end) as BrojZakStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=1) else '' end) as BrojZakP11Stanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=6 and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  ))  and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1)) else '' end) as BrojZakOdbStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=7 and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  ))  and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1)) else '' end) as BrojZakNOKStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast((isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1 and exists (select * from adresar ad where isnull(ad.statusanketar,0) in (1,2) and xx.mbops=ad.mbops And xx.Krug_idcd=ad.Krug_idcd And xx.kucni_broj_idCD=ad.kucni_broj_idCD and xx.rbrstan=ad.rbrstan))" + nvrd +
            " - (case when (select cast(count(*) as int) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%'))=0 then 0 else " + nvrd +
            " (select cast(count(*) as int) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%')) end )" + nvrd +
            " - (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0) in (1,2,3,4,5,6,7) and not (isnull(statusanketar,0)=0 and (isnull(user_statusanketar,'') like 'i7%' or   isnull(user_statusanketar,'') like 'i8%'  )) and not exists (select * from p2_stan st where xx.mbops=st.mbops And xx.Krug_idcd=st.Krug_idcd And xx.kucni_broj_idCD=st.kucni_broj_idCD and xx.rbrstan=st.rbrstan and isnull(qc,0)=1))) as varchar(6)),'') else '' end) as BrojOstalNezavrStanova," + nvrd + ' ' ' as praznoF,
            " (case when (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%'))=0 then '' else " +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%')) end ) as BrojVracenihStanova,' ' as praznoD2," + nvrd +
            " case when isnull(b.BrojStanova,'')='' then '' else N'🏘' end as DA," + nvrd +
             " N'🖉' as EEdit,b.NapomenaOKucnomBroju, ' ' as praznoB," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj,a.longituda,a.latituda," + nvrd + '" a.krug,a.ulica,a.kbroj,a.longituda,a.latituda," + nvrd +
            " a.krug_idcd,a.idulice,a.kucni_broj_idcd,a.mbops,case when a.sourceof_INSERT='ANK' then N'📌' else '' end as sourceof_INSERT," + nvrd +
            " case when a.sourceof_INSERT='ANK' and not exists(select * from p2_stan x where a.mbops=x.mbops and a.krug_idcd=x.krug_idcd and a.kucni_broj_idcd=x.kucni_broj_idcd ) then N'🗑' else '' end as DDelete,' ' as praznoE " +
            " from (select * from adresar where trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) like N'%" + ulicaKBroj + "%' and IDANKETAR=N'" + kosam + "') a left join " + nvrd +
            "  p2_objekat  b on a.krug_idcd=b.krug_idcd And a.kucni_broj_idcd=b.kucni_broj_idcd " + nvrd +
            " where a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and a.idulice='" + tboxIDULICE.Text.Trim + "'" + nvrd +
            " ) aaa  where  aaa.status like '%" + status + "%' and isnull(NoviKbrojTeren,'') like N'%" + NoviKbrojTeren + "%' and isnull(NapomenaOKucnomBroju,'') like N'%" + NapomenaOKucnomBroju + "%' order by  aaa.ulica asc,len(aaa.kBroj) asc, aaa.kBroj asc"

            '" case when isnull(b.BrojStanova,9999)=9999 and isnull(vrstazgrade,0) in (0,1,2,3,4) and isnull(b.adresateren,0) <> 4 then N'📝' else '' end as NE," + nvrd +
            '" case when isnull(b.BrojStanova,'')='' then ZakazanoDatumObj else '' end as ZakazanoDatumObj ," + nvrd +
            '" case when isnull(b.BrojStanova,'') ='' then ZakazanoVremeObj else '' end as ZakazanoVremeObj," + nvrd +
            '" a.ZakazanoNapomenaObj,' ' as praznoC, " + nvrd +
        End If


        'DGV1.Sort(DGV1.Columns(5), ListSortDirection.Descending)

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)

        DGV1.DataSource = dt
        dtOrig = dt
        txt1.Text = CStr(dt.Rows.Count)



        If a.Trim.ToUpper <> "NONE" AndAlso a.Trim.ToUpper <> "" AndAlso b >= 0 Then
            If a.Trim.ToUpper = "DESCENDING" Then
                DGV1.Sort(DGV1.Columns(b), ListSortDirection.Descending)
            ElseIf a.Trim.ToUpper = "ASCENDING" Then
                DGV1.Sort(DGV1.Columns(b), ListSortDirection.Ascending)
            End If
        End If
        ''DGV1.Columns("open").text = "UNETOBJEKAT"
        'DGV1.Columns("x").Width = 200
        'DGV1.Columns("x").HeaderText = "Popisivanje u toku"

        DGV1.Columns("sourceof_INSERT").Visible = True
        'DGV1.Columns("krug").Visible = False
        DGV1.Columns("ulica").Visible = False
        DGV1.Columns("kbroj").Visible = False
        DGV1.Columns("krug_idcd").Visible = False
        DGV1.Columns("idulice").Visible = False
        DGV1.Columns("kucni_broj_idcd").Visible = False
        'DGV1.Columns("kucni_broj").Visible = False
        DGV1.Columns("Longituda").Visible = False
        DGV1.Columns("Latituda").Visible = False
        DGV1.Columns("mbops").Visible = False
        DGV1.Columns("DA").Visible = False
        'DGV1.Columns("ZakazanoDatumObj").Width = 80
        'DGV1.Columns("ZakazanoVremeObj").Width = 80
        DGV1.Columns("ulicaKBroj").Width = 250
        DGV1.Columns("NapomenaOKucnomBroju").Width = 200

        DGV1.Columns("NoviKbrojTeren").Width = 220
        DGV1.Columns("OOpen1").Width = 70
        DGV1.Columns("vrstazgrade").Width = 150

        DGV1.Columns("brojstanova").Width = 80
        DGV1.Columns("BrojZavrStanova").Width = 80
        DGV1.Columns("BrojZakStanova").Width = 80
        DGV1.Columns("BrojNeZavrStanova").Width = 80
        DGV1.Columns("BrojZakP11Stanova").Width = 80
        DGV1.Columns("BrojZakOdbStanova").Width = 80
        DGV1.Columns("BrojZakNOKStanova").Width = 90
        DGV1.Columns("BrojOstalNezavrStanova").Width = 80
        'DGV1.Columns("BrojZapStanova").Width = 80
        'DGV1.Columns("BrojZakazanihStanova").Width = 80
        DGV1.Columns("BrojVracenihStanova").Width = 115
        DGV1.Columns("DA").Width = 100


        'DGV1.Columns("NE").Width = 35
        DGV1.Columns("EEdit").Width = 35
        DGV1.Columns("status").Width = 38
        DGV1.Columns("sourceof_INSERT").Width = 35
        DGV1.Columns("DDelete").Width = 35
        DGV1.Columns("praznoA").MinimumWidth = 2
        DGV1.Columns("praznoA").Width = 2
        DGV1.Columns("praznoB").MinimumWidth = 2
        DGV1.Columns("praznoB").Width = 2
        'DGV1.Columns("praznoC").MinimumWidth = 2
        'DGV1.Columns("praznoC").Width = 2
        DGV1.Columns("praznoD").MinimumWidth = 2
        DGV1.Columns("praznoD").Width = 2
        DGV1.Columns("praznoD2").MinimumWidth = 2
        DGV1.Columns("praznoD2").Width = 2
        DGV1.Columns("praznoE").MinimumWidth = 2
        DGV1.Columns("praznoE").Width = 2
        'DGV1.Columns("praznoF").MinimumWidth = 2
        'DGV1.Columns("praznoF").Width = 2

        DGV1.Columns("ulicaKBroj").HeaderText = "Adresa na mapi (ulica i kućni broj)" + nvrd + nvrd
        DGV1.Columns("OOpen1").HeaderText = "Unos / izmena podataka o zgradi"
        DGV1.Columns("EEdit").HeaderText = ""
        DGV1.Columns("DDelete").HeaderText = ""
        DGV1.Columns("NapomenaOKucnomBroju").HeaderText = "Napomena za zgradu" + nvrd + nvrd
        DGV1.Columns("vrstazgrade").HeaderText = "Vrsta zgrade"
        DGV1.Columns("status").HeaderText = "Status" + nvrd + nvrd
        'DGV1.Columns("ZakazanoNapomenaObj").HeaderText = "Napomena"
        DGV1.Columns("sourceof_INSERT").HeaderText = ""
        DGV1.Columns("NoviKbrojTeren").HeaderText = "Adresa na terenu" + nvrd + nvrd
        ' DGV1.Columns("NE").HeaderText = ""
        'DGV1.Columns("ZakazanoDatumObj").HeaderText = "Datum"
        'DGV1.Columns("ZakazanoVremeObj").HeaderText = "Vreme"
        DGV1.Columns("brojstanova").HeaderText = "ukupan broj stanova"
        DGV1.Columns("DA").HeaderText = "unos/izmena podataka o stanu i ishoda poseta"
        DGV1.Columns("BrojZavrStanova").HeaderText = "završeni"
        DGV1.Columns("BrojNeZavrStanova").HeaderText = "nezavršeni"
        DGV1.Columns("BrojZakStanova").HeaderText = "zakazani"
        DGV1.Columns("BrojZakP11Stanova").HeaderText = "ostavljen P11"
        DGV1.Columns("BrojZakOdbStanova").HeaderText = "odbijanje"
        DGV1.Columns("BrojZakNOKStanova").HeaderText = "nije ostvaren kontak sa domaćinstvom"
        DGV1.Columns("BrojOstalNezavrStanova").HeaderText = "ostali nezavršeni"
        DGV1.Columns("BrojvracenihStanova").HeaderText = "broj stanova koje je instruktor vratio na doradu"
        DGV1.Columns("praznoA").HeaderText = ""
        DGV1.Columns("praznoB").HeaderText = ""
        'DGV1.Columns("praznoC").HeaderText = ""
        DGV1.Columns("praznoD").HeaderText = ""
        DGV1.Columns("praznoE").HeaderText = ""
        'DGV1.Columns("praznoF").HeaderText = ""

        DGV1.Columns("BrojvracenihStanova").DefaultCellStyle.ForeColor = Color.Red

        DGV1.EnableHeadersVisualStyles = False

        DGV1.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DGV1.Columns("BrojvracenihStanova").DefaultCellStyle.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold)

        DGV1.Columns("brojstanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        DGV1.Columns("BrojZavrStanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        'DGV1.Columns("BrojZapStanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        'DGV1.Columns("BrojZakazanihStanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        DGV1.Columns("BrojvracenihStanova").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter
        DGV1.Columns("DA").HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter

        If Not filterStatus Is Nothing Then
            filterStatus.Width = DGV1.Columns("Status").Width
            filterStatus.Location = New Point(DGV1.RowHeadersWidth, DGV1.ColumnHeadersHeight - filterStatus.Height - 1)
            filterStatus.Visible = True
        End If
        If Not filterUlica Is Nothing Then
            filterUlica.Width = DGV1.Columns("ulicakbroj").Width
            filterUlica.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("Status").Width, DGV1.ColumnHeadersHeight - filterUlica.Height - 1)
            filterUlica.Visible = True
        End If
        If Not filterUlicaMapa Is Nothing Then
            filterUlicaMapa.Width = DGV1.Columns("novikbrojteren").Width
            filterUlicaMapa.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("Status").Width + filterUlica.Width, DGV1.ColumnHeadersHeight - filterUlicaMapa.Height - 1)
            filterUlicaMapa.Visible = True
        End If

        If Not filterNapomenaKBR Is Nothing Then
            filterNapomenaKBR.Width = DGV1.Columns("NapomenaOKucnomBroju").Width
            filterNapomenaKBR.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("Status").Width + filterUlica.Width + filterUlicaMapa.Width + DGV1.Columns("praznoA").Width + DGV1.Columns("EEdit").Width + 2, DGV1.ColumnHeadersHeight - filterNapomenaKBR.Height - 1)
            '''''filterNapomenaKBR.Visible = True
        End If

        If dt.Rows.Count > 0 Then
            If prerecunajsumu(dt, "BrojvracenihStanova") > 0 Then
                DGV1.Columns("BrojvracenihStanova").HeaderCell.Style.ForeColor = Color.Red
            Else
                DGV1.Columns("BrojvracenihStanova").HeaderCell.Style.ForeColor = Color.Black
            End If
        End If

        If PrikaziZavrsetakKruga() = 0 AndAlso (atbOps.Text.Trim = "" OrElse atbPK.Text.Trim = "" OrElse atbUlica.Text.Trim = "") Then
            chbZavrsenKrug.Visible = False
        ElseIf PrikaziZavrsetakKruga() = 0 AndAlso atbOps.Text.Trim <> "" AndAlso atbPK.Text.Trim <> "" AndAlso atbUlica.Text.Trim <> "" Then
            chbZavrsenKrug.Visible = True
            chbZavrsenKrug.Text = "Potvrđujem nakon obilaska terena da je krug zaista prazan"
        ElseIf PrikaziZavrsetakKruga() = 1 Then
            chbZavrsenKrug.Visible = True
            chbZavrsenKrug.Text = "Potvrđujem da je krug kompletno popisan"
        ElseIf PrikaziZavrsetakKruga() = 2 Then
            chbZavrsenKrug.Visible = False
        End If

        'ivanaaa
        Call praznidgv2()


    End Sub

    Private Function PrikaziZavrsetakKruga()

        Dim Str As String = dodatak + "select * from (select distinct" + nvrd +
            " (case when isnull(b.adresateren,0)=0 then ' '" + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0)=0 then '0' " + nvrd +
            " when isnull(b.adresateren,0) not in (0,4) and isnull(vrstazgrade,0) not in (5,6) " + nvrd +
            " and isnull(b.brojstanova,9999)<> (select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD " + nvrd +
            " and a.KRUG_IDCD=b.KRUG_IDCD and a.mbops=b.mbops and a.qc=1)" + nvrd +
            " and ((isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)<>0) or (isnull(vrstazgrade,0) in (1,2,3))) then '0'" + nvrd +
            " when isnull(b.adresateren,0)=4 or isnull(vrstazgrade,0) in (5,6) or (isnull(vrstazgrade,0)=4 and isnull(b.brojstanova,9999)=0) or " + nvrd +
            " isnull(b.brojstanova,9999)= (select count(*) from p2_stan a where a.mbops=b.mbops and a.kucni_broj_idCD=b.kucni_broj_idCD and a.KRUG_IDCD=b.KRUG_IDCD and a.qc=1)" + nvrd +
            " then '2' end) as Status," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.UlicakBroj)='' then NULL else a.UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicaKBroj," + nvrd +
            " (case when isnull(b.adresateren,0)=4 then N'Ne postoji zgrada na ovoj adresi' else (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(b.noviNazivUliceTeren)='' then NULL else b.noviNazivUliceTeren end),1), 1, CONVERT(varbinary, @Hash)))))+' '+b.NoviKbrojTeren) end) as NoviKbrojTeren, " + nvrd +
            " N'🏠' as OOpen1," + nvrd +
            " (case when isnull(vrstazgrade,0)=1 then N'Stambena zgrada / kuća' when isnull(vrstazgrade,0)=2 then N'Zgrada za kolektivni smeštaj' when isnull(vrstazgrade,0)=3 then N'Zgrada/ objekat nastanjena iz nužde'" + nvrd +
            " when isnull(vrstazgrade,0)=4 then N'Nestambena zgrada (škola, hotel, fabrika i sl.)' when isnull(vrstazgrade,0)=5 then N'Pomoćna zgrada koja se ne popisuje' when isnull(vrstazgrade,0)=6 then N'Zgrada u izgradnji koja se ne popisuje' " + nvrd +
            " else '' end) as vrstazgrade,' ' as praznoA, " + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(b.brojstanova As varchar(4)),'') else '' end) as BrojStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then" + nvrd +
            " (select cast(count(*) as varchar(4)) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1) else '' end) as BrojZavrStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast(isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1) as varchar(6)),'') else '' end) as BrojNeZavrStanova, ' ' as praznoD," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD and isnull(ishod,0) in (2,3,4,5)) else '' end) as BrojZakStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=1) else '' end) as BrojZakP11Stanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=6) else '' end) as BrojZakOdbStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0)=7) else '' end) as BrojZakNOKStanova," + nvrd +
            " (case when isnull(b.adresateren,0) not in (0,4) And isnull(vrstazgrade,0) in (0,1,2,3,4) And isnull(b.brojstanova,9999) Not in (0,9999) then " + nvrd +
            " isnull(cast((isnull(cast(b.brojstanova As int),0) - (select isnull(cast(count(*) as int),0) from p2_stan xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.QC,0)=1)" + nvrd +
            " - (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(ishod,0) in (1,2,3,4,5,6,7))) as varchar(6)),'') else '' end) as BrojOstalNezavrStanova,' ' as praznoF," + nvrd +
            " (case when (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%'))=0 then '' else " +
            " (select cast(count(*) as varchar(4)) from adresar xx where xx.mbops=b.mbops And xx.Krug_idcd=b.Krug_idcd And xx.kucni_broj_idCD=b.kucni_broj_idCD And isnull(xx.statusAnketar,0)=0 and (isnull(xx.USER_statusAnketar,'') like 'I7%' or isnull(xx.USER_statusAnketar,'') like 'I8%')) end ) as BrojVracenihStanova, ' ' as praznoD2," + nvrd +
            " case when isnull(b.BrojStanova,'')='' then '' else N'🏘' end as DA," + nvrd +
            " N'🖉' as EEdit,b.NapomenaOKucnomBroju,' ' as praznoB," + nvrd +
            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica,a.longituda,a.latituda," + nvrd + '" a.krug,a.kbroj,a.ulica,a.longituda,a.latituda," + nvrd +
            " a.krug_idcd,a.idulice,a.kucni_broj_idcd,a.mbops," + nvrd +
            " case when a.sourceof_INSERT='ANK' then N'📌' else '' end as sourceof_INSERT," + nvrd +
            " case when a.sourceof_INSERT='ANK' and not exists(select * from p2_stan x where a.mbops=x.mbops and a.krug_idcd=x.krug_idcd and a.kucni_broj_idcd=x.kucni_broj_idcd ) then N'🗑' else '' end as DDelete,' ' as praznoE " +
            " from (select * from adresar where IDANKETAR=N'" + kosam + "') a left join " + nvrd +
            " p2_objekat b on a.krug_idcd=b.krug_idcd and a.kucni_broj_idcd=b.kucni_broj_idcd " + nvrd +
            " where a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' " + nvrd +
            " ) aaa  order by  aaa.BrojVracenihStanova desc, aaa.ulica asc,len(aaa.kBroj) asc, aaa.kBroj asc"

        Dim prikazi As Integer = 0

        Dim dt As DataTable = izvrsiSQLvratiDT(Str, Me.DBConnectionString, Me.jezik)
        If dt.Rows.Count > 0 Then
            prikazi = 1
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("status").trim <> "2" Then
                    prikazi = 2
                    Exit For
                End If
            Next
        End If

        Return prikazi
    End Function

    Private Sub chbZavrsenKrug_CheckedChanged(sender As Object, e As EventArgs) Handles chbZavrsenKrug.CheckedChanged
        If chbZavrsenKrug.Checked = True Then
            Dim msgtxt As String = "Da li ste sigurni da ste završili rad u ovom krugu?" + nvrd +
                                   "Krug će narednom sinhronizacijom biti poslat instruktoru na" + nvrd +
                                   "kontrolu i više nećete moći da vršite izmene na ovom krugu!"
            ''videti šta ako postoje podaci!!!!! NISTA, NIJE DOZVOLJENO
            Dim msgtitle As String = "............"
            Dim opc As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle)
            Select Case opc
                Case "Yes"
                    Dim opc2 As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle, 2)
                    Select Case opc2
                        Case "Yes"
                            Dim str As String = ""
                            If chbZavrsenKrug.Text = "Potvrđujem da je krug kompletno popisan" Then
                                str = "update [AdresarSviKrugovi] set [IndZavrsenPop]=1, [USER_UPDATE_IndZavrsenPop]=N'" + kosam + "', [DATE_UPDATE__IndZavrsenPop]=getdate() where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and IDanketar=N'" + kosam + "'"
                            ElseIf chbZavrsenKrug.Text = "Potvrđujem nakon obilaska terena da je krug zaista prazan" Then
                                str = "update [AdresarSviKrugovi] set [IndPrazan]=1, [USER_UPDATE_IndZavrsenPop]=N'" + kosam + "', [DATE_UPDATE__IndZavrsenPop]=getdate() where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and IDanketar=N'" + kosam + "'"
                            Else
                                str = "select '000' "
                            End If
                            Dim ok As String = izvrsiSQL(str, Me.DBConnectionString)
                            If ok <> "ok" Then
                                ISTMessageBox.Show("Greška 9! Zovite administratora!")
                                Me.Close()
                                Exit Sub
                            End If
                            Call Reset()
                            If atbOps.Text = "" Then
                                atbOps.Focus()
                            Else
                                atbPK.Focus()
                            End If
                            Exit Sub
                        Case "No"
                            chbZavrsenKrug.Checked = False
                    End Select
                Case "No"
                    chbZavrsenKrug.Checked = False
            End Select
        End If
    End Sub

    Private lblOuter As Label = New Label()
    Private controlLocation As Point

    Private Sub panel_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelZakazivanjeStana.MouseDown, PanelNUl.MouseDown, Panel3.MouseDown, PanelIzmenaUL.MouseDown, PanelSpisakUlica.MouseDown, PanelNapomenaLica.MouseDown, PanelZahtev.MouseDown, PanelNapomenaStan.MouseDown, PanelPKDorada.MouseDown
        sender.Parent.Controls.Add(lblOuter)
        controlLocation = e.Location
        sender.cursor = Cursors.SizeAll
    End Sub

    Private Sub panel_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelZakazivanjeStana.MouseMove, PanelNUl.MouseMove, Panel3.MouseMove, PanelIzmenaUL.MouseMove, PanelSpisakUlica.MouseMove, PanelNapomenaLica.MouseMove, PanelZahtev.MouseMove, PanelNapomenaStan.MouseMove, PanelPKDorada.MouseMove
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
    Private Sub panel_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles PanelZakazivanjeStana.MouseUp, PanelNUl.MouseUp, Panel3.MouseUp, PanelIzmenaUL.MouseUp, PanelSpisakUlica.MouseUp, PanelNapomenaLica.MouseUp, PanelZahtev.MouseUp, PanelNapomenaStan.MouseUp, PanelPKDorada.MouseUp
        sender.Parent.Controls.remove(lblOuter)
        sender.cursor = Cursors.Default
    End Sub


    Function prerecunajsumu(ByVal dt As DataTable, ByVal kolona As String) As Integer
        Dim sum As Integer = 0
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item(kolona).trim <> "" Then
                sum = dt.Rows(i).Item(kolona) + sum
            End If
        Next
        Return sum
    End Function
    Function dajSQLzaDGV2(ByVal pv As String, ByVal dv As String, Optional ByVal tv As String = "", Optional datumzakazano As String = "", Optional ByVal status As String = "", Optional ByVal ulicakbroj As String = "", Optional ByVal novikbroj As String = "") As String
        Dim str1 As String = ""
        Dim str2 As String = ""
        If tv <> "" Then
            str1 = " and m.kucni_broj_idCD='" + CStr(tv).Trim + "' "
        End If
        If dv <> "000000000000" Then
            str2 = " and m.idulice='" + CStr(dv).Trim + "'"
        End If
        ' SELECT distinct N'🏠' as OOpen1,
        Dim str As String = dodatak + "select * from (select left(a.Krug_idcd,4) as krugZaPrikaz,a.NazivNaselja," + nvrd +
        " (case when isnull(a.statusAnketar,0)=0 and isnull(a.USER_statusAnketar,'') not like 'I7%' and isnull(a.USER_statusAnketar,'') not like 'I8%' and isnull(imastan,'')='' then ' ' " + nvrd +
        " when isnull(a.statusAnketar,0)=0 and isnull(a.USER_statusAnketar,'') not like 'I7%' and isnull(a.USER_statusAnketar,'') not like 'I8%' and isnull(imastan,'')<>'' then '0' " + nvrd +
        " when isnull(a.statusAnketar,0)=0 and (isnull(a.USER_statusAnketar,'') like 'I7%' or isnull(a.USER_statusAnketar,'') like 'I8%') then '4' " + nvrd +
        " else cast(isnull(a.statusAnketar,'') as varchar(1)) end) as statusAnketar,case when isnull(ooo.kucni_broj_idCD,'')='' then '' else cast(a.RbrStan as char(10)) end as RbrStan, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.UlicakBroj)='' then NULL else a.UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicaKBroj," + nvrd +
        " (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(OOO.noviNazivUliceTeren)='' then NULL else OOO.noviNazivUliceTeren end),1), 1, CONVERT(varbinary, @Hash)))))+' '+OOO.NoviKbrojTeren) as NoviKbrojTeren," + nvrd +
        " (case when isnull(sss.BrojStana,'')='' then isnull(BrojStanaVrata,'') else sss.BrojStana end) as BrojStana," + nvrd + 'BrojStanaVrata da li ovde broj stana na vratima iz adresara (zakazivanje) ili iz stana
        " (case when cast(isnull(a.statusAnketar,'') as varchar(1)) in ('','0','1') then N'🏦👪' else '' end) as OOpen2," + nvrd +
        " (select cast(isnull(brojdom,0) as varchar(3)) from p2_stan bb where bb.mbops=a.mbops and bb.Krug_idcd=a.Krug_idcd and bb.kucni_broj_idCD=a.kucni_broj_idCD and bb.rbrstan=a.rbrstan ) +'/'+" + nvrd +
        " cast(isnull((select count(*) from p2_dom xx where xx.mbops=a.mbops and xx.Krug_idcd=a.Krug_idcd and xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(brlica,0)>0 group by rbrstan),0) as varchar(3)) as BrojDom," + nvrd +
        " (select cast(isnull(UBrLicaStan,0) as varchar(3)) from p2_stan bb where bb.mbops=a.mbops and bb.Krug_idcd=a.Krug_idcd And bb.kucni_broj_idCD=a.kucni_broj_idCD And bb.rbrstan=a.rbrstan ) +'/'+" + nvrd +
        " cast(isnull((select count(*) from p1 xx where xx.mbops =a.mbops and xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD And xx.rbrstan=a.rbrstan And isnull(podatak, 0) > 0 group by rbrstan),0) as varchar(3)) as BrojLica," + nvrd +
        " ' ' as praznoA," +
        " (case when isnull(a.statusAnketar,0)= 0 Then N'📝' else '' end ) as EEdit,DatumDolaska,a.ZakazanoDatum, a.ZakazanoVreme, cast(a.Ishod as nvarchar(1)) +'-'+ ltrim(rtrim(i.naziv)) as nazivishod, " + nvrd +
        " (case when isnull(a.cati_nacin,0)=1 then N'📞' when isnull(a.cati_nacin,0)=2 then N'🏃' else '' end) as nacinanketiranja," + nvrd +
        " a.KontaktOsoba,a.BrojTelefona, a.ukupnolicastan, a.IshodNapomena, ' ' as praznoB," + nvrd +
        " N'🖉' as EEditNapomena,napomenaostanu, " + nvrd +
        "' ' as prazno," + nvrd +
        " (case when (isnull(a.statusAnketar,0)=2 or isnull(a.statusAnketar,0)=3) then N'🖐' else '' end ) as OOpen3,a.napomenaStatusAnketar, a.napomenaKontrolorNivo1,' ' as praznoC," + nvrd +
        " (case when not exists(select * from p2_dom x where a.mbops=x.mbops and a.krug_idcd=x.krug_idcd and a.kucni_broj_idcd=x.kucni_broj_idcd and a.rbrstan=x.rbrstan ) " + nvrd +
        " And Not exists (select * from spisaklica x where a.mbops=x.mbops and a.krug_idcd=x.krug_idcd and a.kucni_broj_idcd=x.kucni_broj_idcd and a.rbrstan=x.rbrstan )" + nvrd +
        " And Not exists (select * from P1 x where a.mbops=x.mbops and a.krug_idcd=x.krug_idcd and a.kucni_broj_idcd=x.kucni_broj_idcd and a.rbrstan=x.rbrstan )" + nvrd +
         " And exists (select * from P2_stan x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan ) and cast(isnull(a.statusAnketar,'') as varchar(1)) in ('','0','1')" + nvrd +
        " then N'🗑' else '' end) as DeleteIZStana," + nvrd +
        " a.kucni_broj_Deo,a.Krug_idcd,a.idulice,a.kucni_broj_idCD,  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj,a.cati_nacin, " + nvrd + '" a.Krug, a.kucni_broj, a.kucni_broj_Deo,a.Krug_idcd, a.idulice,a.kucni_broj_idCD,a.ulica,a.kbroj,a.cati_nacin, " + nvrd +
        " a.mbops, a.NazivOpstine, a.mbnas,  " + nvrd +
        " a.sourceof_INSERT, a.ishod, " + nvrd +
        " a.USER_statusAnketar, a.statusKontrolorNivo1, a.USER_statusKontrolorNivo1, " + nvrd +
        " (case when isnull(imastan,0)=0 then 0 else 1 end) as statusBoja" + nvrd +
        " from (select * from dbo.Adresar where IDANKETAR=N'" + kosam + "') A inner join " + nvrd +
        " (select * from dbo.P2_objekat where isnull(brojstanova,0)>0)OOO On a.mbops=ooo.mbops and a.Krug_idcd=ooo.Krug_idcd And a.kucni_broj_idCD=ooo.kucni_broj_idCD " + vbCrLf +
        " left join" + nvrd +
        " (select ishod,naziv from sif_Ishod where IDLang='" + Me.jezik.Trim + "') i on a.ishod=i.ishod" + vbCrLf +
        " left join " + nvrd +
        " (select Krug_idcd,kucni_broj_idCD, rbrstan,rbrstan as imastan,BrojStana from P2_Stan) sss on a.Krug_idcd=sss.Krug_idcd and a.kucni_broj_idCD=sss.kucni_broj_idCD and a.RbrStan=sss.RbrStan) m" + nvrd +
        " where  m.mbops='" + atbOps.sselectedValue + "' and m.krug_idcd ='" + CStr(pv).Trim + "' " + str2 + str1 + nvrd +
        " and isnull(m.ZakazanoDatum,' ') like N'%" + datumzakazano + "%' and isnull(m.statusanketar,' ') like N'%" + status + "%' and m.UlicakBroj like N'%" + ulicakbroj + "%' and isnull(m.NoviKbrojTeren,' ') like N'%" + novikbroj + "%' order by m.kBroj "

        Return str
    End Function

    Function dajSQLzaDGV3(ByVal krug As String, ByVal idulice As String, Optional ByVal kbr_idcd As String = "", Optional ByVal rbrstana As String = "", Optional ByVal fulica As String = "", Optional ByVal fime As String = "", Optional ByVal fjmbg As String = "") As String
        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim str3 As String = ""
        If kbr_idcd <> "" Then
            str1 = " and a.kucni_broj_idCD='" + CStr(kbr_idcd).Trim + "' "
        End If
        If idulice <> "000000000000" Then
            str2 = " and adr.idulice='" + CStr(idulice).Trim + "'"
        End If
        If rbrstana <> "" Then
            str3 = " and a.rbrstan='" + CStr(rbrstana).Trim + "'"
        End If

        Dim strwhere As String = ""

        If krug = "" OrElse kbr_idcd = "" OrElse idulice = "" Then
        Else
            strwhere = " a.mbops ='" + atbOps.sselectedValue + "' and a.krug_idcd ='" + CStr(krug).Trim + "' " + str2 + str1 + str3 + nvrd + " and "
        End If

        '" ,case when len(ltrim(rtrim(ime)))<=2 and len(ltrim(rtrim(prezime)))<=2 then ime+' '+prezime " + nvrd +
        '" when len(ltrim(rtrim(ime)))>2 And len(ltrim(rtrim(prezime)))<=2 then left(ltrim(rtrim(ime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(ime)))-2)+' '+prezime " + nvrd +
        '" when len(ltrim(rtrim(ime)))<=2 And len(ltrim(rtrim(prezime)))>2 then ime+' '+left(ltrim(rtrim(prezime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(prezime)))-2) " + nvrd +
        '" Else left(ltrim(rtrim(ime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(ime)))-2) " + nvrd +
        '" +' '+left(ltrim(rtrim(prezime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(prezime)))-2) end as ImePrezime " + nvrd +

        ' SELECT distinct N'🏠' as OOpen1,
        Dim str As String = dodatak + "select  " + nvrd +
                            " a.[RbrStan],trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicakbroj,brojstana " + nvrd +
                            " ,a.rbrdom,a.rbrp1" + nvrd +
                            " ,trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash)))))+' ' +trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) as ImePrezime" + nvrd +
                            " ,trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ImeRoditelja)='' then NULL else ImeRoditelja end),1), 1, CONVERT(varbinary, @Hash))))) ImeRoditelja ,isnull([Pol],'') as pol " + nvrd +
                            " ,case when rest='999999' then [Dan]+[Mesec]+[GodRod]+rest else [Dan]+[Mesec]+[GodRod]+substring('*******************************************************',1,len(ltrim(rtrim(rest)))) end  as jmbg " + nvrd +
                            " ,isnull(cast([Starost] as varchar(3)),'') as [Starost] " + nvrd +
                            " ,isnull(cast([LiceJe] as varchar(2)),'') as [LiceJe] " + nvrd +
                            " ,isnull(cast([ClanDom] as varchar(2)),'') as ClanDom, (case when isnull(adr.statusanketar,0) in (0,1) then N'👪' else '' end) as OOpenStan " + nvrd +
                            " ,' ' as praznoX, N'🖉' as EEditNapomena " + nvrd +
                            " ,isnull(a.istnote,'') as napomena, ' ' as praznoY " + nvrd +
                            " ,a.[MBOPS],a.[Krug_idcd] " + nvrd +
                            " ,a.[kucni_broj_idCD],idulice,adr.sourceof_INSERT ,  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))) + ' ' + trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) as ImePrezimeCelo" + nvrd +
                            " ,a.ssrodstvo " + nvrd +
                            " ,(case when isnull(adr.statusAnketar,0)=0 and isnull(adr.USER_statusAnketar,'') not like 'I7%' and isnull(adr.USER_statusAnketar,'') not like 'I8%' then '0' " + nvrd +
                            " when isnull(adr.statusAnketar,0)=0 and (isnull(adr.USER_statusAnketar,'') like 'I7%' or isnull(adr.USER_statusAnketar,'') like 'I8%') then '4' " + nvrd +
                            " else cast(isnull(adr.statusAnketar,'') as varchar(1)) end) as statusAnketar" + nvrd +
                            " ,UklonitiLice, UklonitiLiceRazlog, UklonitiLiceObjasnjenje" + nvrd +
                            " From spisaklica a left Join p2_dom b on a.[MBOPS]=b.[MBOPS] And a.[Krug_idcd]=b.[Krug_idcd] And a.[kucni_broj_idCD]=b.[kucni_broj_idCD] " + nvrd +
                            " and a.[RbrStan]=b.[RbrStan] and a.rbrdom=b.rbrdom " + nvrd +
                            " left join adresar as adr on  a.[MBOPS]=adr.[MBOPS] and a.[Krug_idcd]=adr.[Krug_idcd] and a.[kucni_broj_idCD]=adr.[kucni_broj_idCD] and a.[RbrStan]=adr.[RbrStan] " + nvrd +
                            " left join p2_stan as st on a.[MBOPS]=st.[MBOPS] and a.[Krug_idcd]=st.[Krug_idcd] and a.[kucni_broj_idCD]=st.[kucni_broj_idCD] and a.[RbrStan]=st.[RbrStan] " + nvrd +
                            " Where IDANKETAR=N'" + kosam + "' and " + strwhere + nvrd +
                            " trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) like N'%" + fulica + "%' and " + nvrd +
                            " (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))) + ' ' + trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) like N'%" + fime + "%') and dan+mesec+godrod+rest like '%" + fjmbg + "%'"

        Return str
    End Function
    Function dajSQLzaDGV2Prazan() As String
        'Dim str As String = "select RbrStan, " +
        '        "statusAnketar, " +
        '        "ulicaKBroj," +
        '        "Null As NoviKbrojTeren, " +
        '        "Null as BrojStana, " +
        '        "Null As OOpen2, " +
        '        "Null as BrojDom, " +
        '        "Null As BrojLica, " +
        '        "' ' as praznoA, " +
        '        "Null as EEdit," +
        '        "DatumDolaska," +
        '        "Null as nazivishod,  " +
        '        "Null as nacinanketiranja, " +
        '        "KontaktOsoba, " +
        '        "BrojTelefona, " +
        '        "ZakazanoDatum," +
        '        "ZakazanoVreme," +
        '        "IshodNapomena," +
        '        "' ' as praznoB, " +
        '        "Null As OOpen3," +
        '        "napomenaStatusAnketar, " +
        '        "napomenaKontrolorNivo1," +
        '        "' ' as praznoC," +
        '        "' ' as prazno, " +
        '        "Krug," +
        '        "kucni_broj, " +
        '        "kucni_broj_Deo," +
        '        "Krug_idcd," +
        '        "idulice, " +
        '        "kucni_broj_idCD," +
        '        "ulica, kbroj," +
        '        "cati_nacin," +
        '        "UkupnoLicaStan, " +
        '        "mbops," +
        '        "NazivOpstine," +
        '        "mbnas," +
        '        "NazivNaselja, " +
        '        "sourceof_INSERT," +
        '        "ishod, " +
        '        "USER_statusAnketar," +
        '        "statusKontrolorNivo1, " +
        '        "USER_statusKontrolorNivo1, " +
        '        "Null as statusBoja " +
        '        "from dbo.Adresar " +
        '        "where 2 = 3 "
        Dim str As String = dodatak + "select * from (select left(a.Krug_idcd,4) as krugZaPrikaz,a.NazivNaselja, " + nvrd +
        " (case when isnull(a.statusAnketar,0)=0 and isnull(a.USER_statusAnketar,'') not like 'I7%' and isnull(a.USER_statusAnketar,'') not like 'I8%' and isnull(imastan,'')='' then ' ' " + nvrd +
        " when isnull(a.statusAnketar,0)=0 and isnull(a.USER_statusAnketar,'') not like 'I7%' and isnull(a.USER_statusAnketar,'') not like 'I8%' and isnull(imastan,'')<>'' then '0' " + nvrd +
        " when isnull(a.statusAnketar,0)=0 and (isnull(a.USER_statusAnketar,'') like 'I7%' or isnull(a.USER_statusAnketar,'') like 'I8%') then '4' " + nvrd +
        " else cast(isnull(a.statusAnketar,'') as varchar(1)) end) as statusAnketar,case when isnull(ooo.kucni_broj_idCD,'')='' then '' else cast(a.RbrStan as char(10)) end as RbrStan, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.UlicakBroj)='' then NULL else a.UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicaKBroj," + nvrd +
        " (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(OOO.noviNazivUliceTeren)='' then NULL else OOO.noviNazivUliceTeren end),1), 1, CONVERT(varbinary, @Hash)))))+' '+OOO.NoviKbrojTeren) as NoviKbrojTeren," + nvrd +
        " (case when isnull(sss.BrojStana,'')='' then isnull(BrojStanaVrata,'') else sss.BrojStana end) as BrojStana," + nvrd + 'BrojStanaVrata da li ovde broj stana na vratima iz adresara (zakazivanje) ili iz stana
        " (case when cast(isnull(a.statusAnketar,'') as varchar(1)) in ('','0','1') then N'🏦👪' else '' end) as OOpen2," + nvrd +
        " (select cast(isnull(brojdom,0) as varchar(3)) from p2_stan bb where bb.mbops=a.mbops and bb.Krug_idcd=a.Krug_idcd and bb.kucni_broj_idCD=a.kucni_broj_idCD and bb.rbrstan=a.rbrstan ) +'/'+" + nvrd +
        " cast(isnull((select count(*) from p2_dom xx where xx.mbops=a.mbops and xx.Krug_idcd=a.Krug_idcd and xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(brlica,0)>0 group by rbrstan),0) as varchar(3)) as BrojDom," + nvrd +
        " (select cast(isnull(UBrLicaStan,0) as varchar(3)) from p2_stan bb where bb.mbops=a.mbops and bb.Krug_idcd=a.Krug_idcd And bb.kucni_broj_idCD=a.kucni_broj_idCD And bb.rbrstan=a.rbrstan ) +'/'+" + nvrd +
        " cast(isnull((select count(*) from p1 xx where xx.mbops =a.mbops and xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD And xx.rbrstan=a.rbrstan And isnull(podatak, 0) > 0 group by rbrstan),0) as varchar(3)) as BrojLica," + nvrd +
        " ' ' as praznoA," +
        " (case when isnull(a.statusAnketar,0)= 0 Then N'📝' else '' end ) as EEdit,DatumDolaska,a.ZakazanoDatum, a.ZakazanoVreme, cast(a.Ishod as nvarchar(1)) +'-'+ ltrim(rtrim(i.naziv)) as nazivishod, " + nvrd +
        " (case when isnull(a.cati_nacin,0)=1 then N'📞' when isnull(a.cati_nacin,0)=2 then N'🏃' else '' end) as nacinanketiranja," + nvrd +
        " a.KontaktOsoba,a.BrojTelefona, a.ukupnolicastan, a.IshodNapomena, ' ' as praznoB," + nvrd +
        " N'🖉' as EEditNapomena,napomenaostanu, " + nvrd +
        "' ' as prazno," + nvrd +
        " (case when (isnull(a.statusAnketar,0)=2 or isnull(a.statusAnketar,0)=3) then N'🖐' else '' end ) as OOpen3,a.napomenaStatusAnketar, a.napomenaKontrolorNivo1,' ' as praznoC," + nvrd +
        " (case when Not exists(select * from p2_dom x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan ) " + nvrd +
        " And Not exists (select * from spisaklica x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan )" + nvrd +
        " And Not exists (select * from P1 x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan )" + nvrd +
        " And exists (select * from P2_stan x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan ) and cast(isnull(a.statusAnketar,'') as varchar(1)) in ('','0','1')" + nvrd +
        " then N'🗑' else '' end) as DeleteIZStana," + nvrd +
        " a.kucni_broj_Deo,a.idulice,a.Krug_idcd,a.kucni_broj_idCD,  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj,a.cati_nacin, " + nvrd + '" a.Krug, a.kucni_broj, a.kucni_broj_Deo,a.Krug_idcd, a.idulice,a.kucni_broj_idCD,a.ulica,a.kbroj,a.cati_nacin, " + nvrd +
        " a.mbops, a.NazivOpstine, a.mbnas, " + nvrd +
        " a.sourceof_INSERT, a.ishod, " + nvrd +
        " a.USER_statusAnketar, a.statusKontrolorNivo1, a.USER_statusKontrolorNivo1, " + nvrd +
        " (case when isnull(imastan,0)=0 then 0 else 1 end) as statusBoja" + nvrd +
        " from dbo.Adresar A inner join " + nvrd +
        " (select * from dbo.P2_objekat where isnull(brojstanova,0)>0)OOO On a.mbops=ooo.mbops and a.Krug_idcd=ooo.Krug_idcd And a.kucni_broj_idCD=ooo.kucni_broj_idCD " + vbCrLf +
        " left join" + nvrd +
        " (select ishod,naziv from sif_Ishod where IDLang='" + Me.jezik.Trim + "') i on a.ishod=i.ishod" + vbCrLf +
        " left join " + nvrd +
        " (select Krug_idcd,kucni_broj_idCD, rbrstan,rbrstan as imastan,BrojStana from P2_Stan) sss on a.Krug_idcd=sss.Krug_idcd and a.kucni_broj_idCD=sss.kucni_broj_idCD and a.RbrStan=sss.RbrStan) m" + nvrd +
        " where 2=3"
        Return str
    End Function
    Sub refreshDGV2(Optional ByVal eRowIndex As Integer = -1, Optional datumzakazano As String = "", Optional status As String = "", Optional ByVal ulicakbroj As String = "", Optional ByVal novikbroj As String = "", Optional ByVal rbrstanZaDGV3 As String = "")

        Dim pamtikbr As String = pamtikbrDGV2

        If DGV2.Rows.Count > 0 AndAlso filterUlicaDGV2.Tag = "" AndAlso filterAdresaTerenDGV2.Tag = "" Then
            pamtikbr = DGV2.Rows(0).Cells("kucni_broj_idCD").Value.ToString
            DGV2.DataSource = Nothing
            DGV2.Rows.Clear()
            DGV2.Visible = False
        End If

        Dim pompostojikbr As Boolean = False
        If DGV2.Visible = True AndAlso Not DGV1 Is Nothing Then
            For i As Integer = 0 To DGV1.Rows.Count - 1
                If pamtikbr = DGV1.Rows(i).Cells("kucni_broj_idCD").Value.ToString Then
                    pompostojikbr = True
                End If
            Next

            If DGV1.Rows.Count = 0 OrElse pompostojikbr = False Then
                ISTMessageBox.Show("Promenjen je status objekta, za filtrirane vrednosti ne postoji izabrani objekat." + nvrd + "Molimo vas poništite filter.")
                TabControl1.SelectedTab = TabPage1
                TabPage1.Visible = True
                'ivanaaa
                Call praznidgv2()
                TabControl1.SelectedIndex = 0

                Exit Sub
            End If
        End If


        Dim dt As DataTable
        Dim str As String = ""
        If eRowIndex >= 0 Then
            Dim pkucni_broj_idCD As String = DGV1.Rows(eRowIndex).Cells("kucni_broj_idCD").Value.ToString
            Dim pIDUlice As String = DGV1.Rows(eRowIndex).Cells("IDULICE").Value.ToString
            If datumzakazano = "*" Then
                datumzakazano = ""
            End If
            If status = "*" Then
                status = ""
            End If
            str = dajSQLzaDGV2(nizACTB(0).sselectedValue.Trim, pIDUlice, pkucni_broj_idCD, datumzakazano, status, ulicakbroj, novikbroj)
        Else
            str = dajSQLzaDGV2Prazan()
            DGV2.Visible = False
        End If

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
        DGV2.DataSource = dt
        dtOrig = dt

        If Not dt Is Nothing AndAlso dt.Rows.Count >= 0 Then
            DGV2.Columns("zakazanovreme").Frozen = True
            If ButtonZakazani.Text = "Svi zakazani stanovi" Then
                DGV2.Columns("NazivNaselja").Visible = False
                DGV2.Columns("krugZaPrikaz").Visible = False
            Else
                DGV2.Columns("NazivNaselja").Visible = True
                DGV2.Columns("krugZaPrikaz").Visible = True
            End If


            DGV2.Columns("krug_idcd").Visible = False
            DGV2.Columns("ulica").Visible = False
            DGV2.Columns("idulice").Visible = False
            DGV2.Columns("kbroj").Visible = False
            DGV2.Columns("kucni_broj_idcd").Visible = False
            'DGV2.Columns("kucni_broj").Visible = False
            DGV2.Columns("mbops").Visible = False
            DGV2.Columns("nazivopstine").Visible = False
            DGV2.Columns("mbnas").Visible = False
            DGV2.Columns("kucni_broj_Deo").Visible = False
            DGV2.Columns("sourceof_INSERT").Visible = False
            DGV2.Columns("ishod").Visible = False
            DGV2.Columns("cati_nacin").Visible = False
            DGV2.Columns("USER_statusAnketar").Visible = False
            DGV2.Columns("statusKontrolorNivo1").Visible = False
            DGV2.Columns("USER_statusKontrolorNivo1").Visible = False
            DGV2.Columns("napomenaStatusAnketar").Visible = False
            DGV2.Columns("statusBoja").Visible = False
            DGV2.Columns("BrojDom").Visible = False

            DGV2.Columns("Eedit").HeaderText = ""
            DGV2.Columns("RbrStan").HeaderText = "Rbr stana"
            DGV2.Columns("ulicakbroj").HeaderText = "Adresa na mapi (ulica i kućni broj)"
            DGV2.Columns("nazivishod").HeaderText = "Ishod posete"
            DGV2.Columns("OOpen2").HeaderText = "Unos podataka o stanu i licima"
            DGV2.Columns("OOpen3").HeaderText = "Zahtev za doradu popisanog stana"
            DGV2.Columns("KontaktOsoba").HeaderText = "Ime i prezime osobe za kontakt"
            DGV2.Columns("statusAnketar").HeaderText = "Status" + nvrd + nvrd
            DGV2.Columns("NoviKbrojTeren").HeaderText = "Adresa na terenu"
            DGV2.Columns("BrojDom").HeaderText = "Broj dom / uneta dom"
            DGV2.Columns("BrojLica").HeaderText = "Broj lica / broj Popisnica"
            DGV2.Columns("BrojStana").HeaderText = "Broj stana na vratima"
            DGV2.Columns("datumdolaska").HeaderText = "Datum posete"
            DGV2.Columns("zakazanodatum").HeaderText = "Zakazan datum" + nvrd + nvrd
            DGV2.Columns("zakazanovreme").HeaderText = "Zakazano vreme"
            DGV2.Columns("nacinanketiranja").HeaderText = "" '"Način anketiranja"
            DGV2.Columns("brojtelefona").HeaderText = "Telefon"
            DGV2.Columns("IshodNapomena").HeaderText = "Napomena"
            DGV2.Columns("napomenaKontrolorNivo1").HeaderText = "Komentar instruktora"
            DGV2.Columns("EEditNapomena").HeaderText = ""
            DGV2.Columns("napomenaostanu").HeaderText = " "
            DGV2.Columns("krugZaPrikaz").HeaderText = "Krug"
            DGV2.Columns("NazivNaselja").HeaderText = "Naselje"
            DGV2.Columns("DeleteIZStana").HeaderText = "Obrisati unete podatke za stan"
            DGV2.Columns("ukupnolicastan").HeaderText = "Ukupan / očekivan broj lica u stanu"

            DGV2.Columns("prazno").HeaderText = ""
            DGV2.Columns("praznoA").HeaderText = ""
            DGV2.Columns("praznoB").HeaderText = ""
            DGV2.Columns("praznoC").HeaderText = ""

            DGV2.Columns("datumdolaska").Width = 80
            'DGV2.Columns("krugZaPrikaz").Width = 60
            DGV2.Columns("RbrStan").Width = 55
            DGV2.Columns("BrojDom").Width = 60
            DGV2.Columns("BrojLica").Width = 60
            DGV2.Columns("ulicakbroj").Width = 200
            DGV2.Columns("NoviKbrojTeren").Width = 150
            DGV2.Columns("OOpen2").Width = 60
            DGV2.Columns("nacinanketiranja").Width = 30
            DGV2.Columns("statusAnketar").Width = 40
            DGV2.Columns("BrojStana").Width = 50
            DGV2.Columns("eedit").Width = 30
            DGV2.Columns("zakazanovreme").Width = 60
            DGV2.Columns("napomenaKontrolorNivo1").Width = 100
            DGV2.Columns("EEditNapomena").Width = 30
            DGV2.Columns("napomenaostanu").Width = 100
            DGV2.Columns("OOPEN3").Width = 80
            DGV2.Columns("NazivNaselja").Width = 70
            DGV2.Columns("krugZaPrikaz").Width = 40
            DGV2.Columns("DeleteIZStana").Width = 100
            DGV2.Columns("ukupnolicastan").Width = 70

            DGV2.Columns("prazno").MinimumWidth = 2
            DGV2.Columns("prazno").Width = 3

            DGV2.Columns("praznoA").MinimumWidth = 2
            DGV2.Columns("praznoA").Width = 3
            DGV2.Columns("praznoB").MinimumWidth = 2
            DGV2.Columns("praznoB").Width = 3
            DGV2.Columns("praznoC").MinimumWidth = 2
            DGV2.Columns("praznoC").Width = 3

            DGV2.EnableHeadersVisualStyles = False
            DGV2.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            DGV2.Columns("prazno").HeaderCell.Style.BackColor = color3
            DGV2.Columns("prazno").DefaultCellStyle.BackColor = color3

            DGV2.Columns("praznoA").HeaderCell.Style.BackColor = color3
            DGV2.Columns("praznoB").HeaderCell.Style.BackColor = color3
            DGV2.Columns("praznoC").HeaderCell.Style.BackColor = color3

            DGV2.Columns("praznoA").DefaultCellStyle.BackColor = color3
            DGV2.Columns("praznoB").DefaultCellStyle.BackColor = color3
            DGV2.Columns("praznoC").DefaultCellStyle.BackColor = color3

            If Not filterStatusDGV2 Is Nothing Then
                filterStatusDGV2.Width = DGV2.Columns("statusAnketar").Width
                filterStatusDGV2.Visible = True
                filterStatusDGV2.Location = New Point(DGV2.RowHeadersWidth, DGV2.ColumnHeadersHeight - filterStatusDGV2.Height - 1)
            End If

            If Not filterDatumZakazan Is Nothing Then
                filterDatumZakazan.Width = DGV2.Columns("zakazanodatum").Width
                filterDatumZakazan.Visible = True
                filterDatumZakazan.Location = New Point(DGV2.RowHeadersWidth +
                                                        DGV2.Columns("RbrStan").Width +
                                                        DGV2.Columns("statusAnketar").Width +
                                                        DGV2.Columns("ulicaKBroj").Width +
                                                        DGV2.Columns("NoviKbrojTeren").Width +
                                                        DGV2.Columns("BrojStana").Width +
                                                        DGV2.Columns("OOpen2").Width +
                                                        DGV2.Columns("BrojLica").Width +
                                                        DGV2.Columns("praznoA").Width +
                                                        DGV2.Columns("EEdit").Width +
                                                        DGV2.Columns("DatumDolaska").Width,
                                                        DGV2.ColumnHeadersHeight - filterDatumZakazan.Height - 1)
                '+
                '                                       DGV2.Columns("nazivishod").Width +
                '                                       DGV2.Columns("nacinanketiranja").Width +
                '                                       DGV2.Columns("KontaktOsoba").Width +
                '                                       DGV2.Columns("BrojTelefona").Width
                If DGV2.Columns("NazivNaselja").Visible = True Then
                    filterDatumZakazan.Location = New Point(filterDatumZakazan.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterDatumZakazan.Location.Y)
                    filterUlicaDGV2.Visible = True
                    filterAdresaTerenDGV2.Visible = True
                Else
                    filterUlicaDGV2.Visible = False
                    filterAdresaTerenDGV2.Visible = False
                End If
                filterDatumZakazan.AccessibleName = filterDatumZakazan.Location.X
            End If

            If Not filterUlicaDGV2 Is Nothing Then
                filterUlicaDGV2.Width = DGV2.Columns("ulicaKBroj").Width
                filterUlicaDGV2.Visible = True
                filterUlicaDGV2.Location = New Point(DGV2.RowHeadersWidth, DGV2.ColumnHeadersHeight - filterUlicaDGV2.Height - 1)
                If DGV2.Columns("NazivNaselja").Visible = True Then
                    filterUlicaDGV2.Location = New Point(filterUlicaDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width + DGV2.Columns("statusanketar").Width + DGV2.Columns("rbrstan").Width, filterUlicaDGV2.Location.Y)
                    filterUlicaDGV2.Visible = True
                Else
                    filterUlicaDGV2.Visible = False
                End If
            End If

            If Not filterAdresaTerenDGV2 Is Nothing Then
                filterAdresaTerenDGV2.Width = DGV2.Columns("NoviKbrojTeren").Width
                filterAdresaTerenDGV2.Visible = True
                filterAdresaTerenDGV2.Location = New Point(DGV2.RowHeadersWidth + DGV2.Columns("RbrStan").Width + DGV2.Columns("statusAnketar").Width + DGV2.Columns("ulicaKBroj").Width, DGV2.ColumnHeadersHeight - filterAdresaTerenDGV2.Height - 1)
                If DGV2.Columns("NazivNaselja").Visible = True Then
                    filterAdresaTerenDGV2.Location = New Point(filterUlicaDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterAdresaTerenDGV2.Location.Y)
                    filterAdresaTerenDGV2.Visible = True
                Else
                    filterAdresaTerenDGV2.Visible = False
                End If
            End If


            'DGV2.Columns("zakazanodatum").Frozen = True
            DGV2.Visible = True
            If DGV2.Rows.Count > 0 Then
                Call refreshDGV3(eRowIndex, rbrstanZaDGV3)
                If DGV3.Rows.Count > 0 Then
                    TabPage3.Tag = "ima"
                Else
                    TabPage3.Tag = "nema"
                End If
            End If
        End If

    End Sub

    Sub refreshDGV3(Optional ByVal eRowIndex As Integer = -1, Optional ByVal rbrstana As String = "", Optional ByVal ulica As String = "", Optional ByVal ime As String = "", Optional ByVal jmbg As String = "")

        'If DGV3.Rows.Count > 0 Then
        '    DGV3.DataSource = Nothing
        '    DGV3.Rows.Clear()
        '    DGV3.Visible = False
        'End If

        If Not (TabControl1.Contains(TabPage3)) = True Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim str As String = ""
        If eRowIndex >= 0 Then
            If DGV1.SelectedCells.Count > 0 Then
                Dim pkucni_broj_idCD As String = DGV1.Rows(eRowIndex).Cells(DGV1.Columns("kucni_broj_idCD").Index).Value.ToString
                Dim pIDUlice As String = DGV1.Rows(eRowIndex).Cells(DGV1.Columns("IDULICE").Index).Value.ToString

                str = dajSQLzaDGV3(nizACTB(0).sselectedValue.Trim, pIDUlice, pkucni_broj_idCD, rbrstana, ulica, ime, jmbg)
            Else
                str = dajSQLzaDGV3("", "", "", rbrstana, ulica, ime, jmbg)
            End If

        Else
            str = dajSQLzaDGV3Prazan()
            DGV3.Visible = False
        End If

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
        DGV3.DataSource = dt


        If Not dt Is Nothing AndAlso dt.Rows.Count >= 0 Then
            DGV3.Columns(6).Frozen = True
            DGV3.Columns("idulice").Visible = False
            DGV3.Columns("krug_idcd").Visible = False
            DGV3.Columns("kucni_broj_idcd").Visible = False
            DGV3.Columns("mbops").Visible = False
            DGV3.Columns("imeprezimecelo").Visible = False
            DGV3.Columns("sourceof_INSERT").Visible = False
            DGV3.Columns("ssrodstvo").Visible = False
            DGV3.Columns("statusanketar").Visible = False
            DGV3.Columns("UklonitiLice").Visible = False
            DGV3.Columns("UklonitiLiceRazlog").Visible = False
            DGV3.Columns("UklonitiLiceObjasnjenje").Visible = False
            DGV3.Columns("jmbg").Visible = False

            DGV3.Columns("ulicakbroj").HeaderText = "Adresa na mapi (ulica i kućni broj)"
            DGV3.Columns("RbrStan").HeaderText = "Rbr stana"
            DGV3.Columns("OOpenStan").HeaderText = "Pregled/izmena podataka o licima"
            DGV3.Columns("Rbrdom").HeaderText = "Redni broj domaćinstva"
            DGV3.Columns("rbrp1").HeaderText = "Redni broj lica"
            DGV3.Columns("imeprezime").HeaderText = "Ime i prezime lica" + nvrd + nvrd
            DGV3.Columns("imeroditelja").HeaderText = "Ime roditelja"
            DGV3.Columns("Pol").HeaderText = "Pol"
            DGV3.Columns("jmbg").HeaderText = "JMBG" + nvrd + nvrd
            DGV3.Columns("starost").HeaderText = "Starost"
            DGV3.Columns("liceje").HeaderText = "Status lica u domaćinstvu" + nvrd + "(1-član domaćinstva," + nvrd + "2-PPL)"
            DGV3.Columns("clandom").HeaderText = "Član domaćinstva je" + nvrd + "(1-prisutan," + nvrd + "2-odsutan)"
            DGV3.Columns("eeditnapomena").HeaderText = ""
            DGV3.Columns("napomena").HeaderText = " "
            DGV3.Columns("praznoX").HeaderText = ""
            DGV3.Columns("praznoY").HeaderText = ""
            DGV3.Columns("brojstana").HeaderText = "Broj stana na vratima"

            DGV3.Columns("praznoX").MinimumWidth = 2
            DGV3.Columns("praznoX").Width = 3
            DGV3.Columns("praznoX").HeaderCell.Style.BackColor = color3
            DGV3.Columns("praznoX").DefaultCellStyle.BackColor = color3

            DGV3.Columns("praznoY").MinimumWidth = 2
            DGV3.Columns("praznoY").Width = 3
            DGV3.Columns("praznoY").HeaderCell.Style.BackColor = color3
            DGV3.Columns("praznoY").DefaultCellStyle.BackColor = color3

            ''DGV1.Rows(0).DefaultCellStyle.ForeColor = Color.Red
            '' DGV1.Columns("BrojvracenihStanova").DefaultCellStyle.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold)

            DGV3.Columns("ulicakbroj").Width = 250
            DGV3.Columns("RbrStan").Width = 55
            DGV3.Columns("OOpenStan").Width = 100
            DGV3.Columns("Rbrdom").Width = 100
            DGV3.Columns("rbrp1").Width = 100
            DGV3.Columns("imeprezime").Width = 150
            DGV3.Columns("imeroditelja").Width = 75
            DGV3.Columns("Pol").Width = 40
            DGV3.Columns("jmbg").Width = 100
            DGV3.Columns("starost").Width = 60
            DGV3.Columns("liceje").Width = 150
            DGV3.Columns("clandom").Width = 150
            DGV3.Columns("eeditnapomena").Width = 50
            DGV3.Columns("napomena").Width = 150
            DGV3.Columns("brojstana").Width = 100

            DGV3.EnableHeadersVisualStyles = False
            DGV3.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            DGV3.Visible = True

            'For i As Integer = 0 To DGV3.Rows.Count - 1
            '    If DGV3.Rows(i).Cells(DGV3.Columns("ssrodstvo").Index).Value.ToString.Trim = "1" Then
            '        DGV3.Rows(i).DefaultCellStyle.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold)
            '    End If
            '    If DGV3.Rows(i).Cells(DGV3.Columns("UklonitiLice").Index).Value.ToString.Trim = "1" Then
            '        DGV3.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro
            '    End If
            'Next

            If Not filterUlicaDGV3 Is Nothing Then
                filterUlicaDGV3.Width = DGV3.Columns("ulicaKBroj").Width
                filterUlicaDGV3.Location = New Point(DGV3.Columns("RbrStan").Width + DGV3.RowHeadersWidth, DGV3.ColumnHeadersHeight - filterUlicaDGV3.Height - 1)
                'filterUlicaDGV3.Visible = True
                filterUlicaDGV3.AccessibleName = filterUlicaDGV3.Location.X
            End If

            If Not filterImePrezime Is Nothing Then
                filterImePrezime.Width = DGV3.Columns("imeprezime").Width
                filterImePrezime.Location = New Point(DGV3.RowHeadersWidth + DGV3.Columns("ulicakbroj").Width + DGV3.Columns("RbrStan").Width + DGV3.Columns("rbrdom").Width + DGV3.Columns("rbrp1").Width + DGV3.Columns("brojstana").Width, DGV3.ColumnHeadersHeight - filterImePrezime.Height - 1)
                filterImePrezime.Visible = True
                filterImePrezime.AccessibleName = filterImePrezime.Location.X
            End If
            'If Not filterJMBG Is Nothing Then
            '    filterJMBG.Width = DGV3.Columns("jmbg").Width
            '    filterJMBG.Location = New Point(DGV3.RowHeadersWidth + DGV3.Columns("ulicakbroj").Width + DGV3.Columns("RbrStan").Width + DGV3.Columns("OOpenStan").Width + DGV3.Columns("rbrdom").Width + DGV3.Columns("rbrp1").Width + DGV3.Columns("brojstana").Width + DGV3.Columns("imeprezime").Width + DGV3.Columns("ImeRoditelja").Width + DGV3.Columns("Pol").Width, DGV3.ColumnHeadersHeight - filterJMBG.Height - 1)
            '    filterJMBG.Visible = True
            '    filterJMBG.AccessibleName = filterJMBG.Location.X
            'End If

        End If



    End Sub

    Function dajSQLzaDGV3Prazan() As String

        '" ,Case When len(ltrim(rtrim(ime)))<=2 And len(ltrim(rtrim(prezime)))<=2 Then ime+' '+prezime " + nvrd +
        '" when len(ltrim(rtrim(ime)))>2 And len(ltrim(rtrim(prezime)))<=2 then left(ltrim(rtrim(ime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(ime)))-2)+' '+prezime " + nvrd +
        '" when len(ltrim(rtrim(ime)))<=2 And len(ltrim(rtrim(prezime)))>2 then ime+' '+left(ltrim(rtrim(prezime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(prezime)))-2) " + nvrd +
        '" Else left(ltrim(rtrim(ime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(ime)))-2) " + nvrd +
        '" +' '+left(ltrim(rtrim(prezime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(prezime)))-2) end as ImePrezime " + nvrd +


        Dim str As String = dodatak + "select  " + nvrd +
                            " a.[RbrStan], trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicakbroj,brojstana  " + nvrd +
                            " ,a.rbrdom,a.rbrp1" + nvrd +
                            " ,trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash)))))+' ' +trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) as ImePrezime" + nvrd +
                            " , trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(imeRoditelja)='' then NULL else imeRoditelja end),1), 1, CONVERT(varbinary, @Hash))))) ImeRoditelja,isnull([Pol],'') as pol " + nvrd +
                            " ,case when rest='999999' then [Dan]+[Mesec]+[GodRod]+rest else [Dan]+[Mesec]+[GodRod]+substring('*******************************************************',1,len(ltrim(rtrim(rest)))) end  as jmbg " + nvrd +
                            " ,isnull(cast([Starost] as varchar(3)),'') as [Starost] " + nvrd +
                            " ,isnull(cast([LiceJe] as varchar(2)),'') as [LiceJe] " + nvrd +
                            " ,isnull(cast([ClanDom] as varchar(2)),'') as ClanDom,(case when isnull(adr.statusanketar,0) in (0,1) then N'👪' else '' end) as OOpenStan  " + nvrd +
                            " ,' ' as praznoX, N'🖉' as EEditNapomena " + nvrd +
                            " ,isnull(a.istnote,'') as napomena, ' ' as praznoY " + nvrd +
                            " ,a.[MBOPS],a.[Krug_idcd] " + nvrd +
                            " ,a.[kucni_broj_idCD],idulice,adr.sourceof_INSERT ,  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))) + ' ' + trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) as ImePrezimeCelo" + nvrd +
                            " ,a.ssrodstvo " + nvrd +
                            " ,(case when isnull(adr.statusAnketar,0)=0 and isnull(adr.USER_statusAnketar,'') not like 'I7%' and isnull(adr.USER_statusAnketar,'') not like 'I8%' then '0' " + nvrd +
                            " when isnull(adr.statusAnketar,0)=0 and (isnull(adr.USER_statusAnketar,'') like 'I7%' or isnull(adr.USER_statusAnketar,'') like 'I8%') then '4' " + nvrd +
                            " else cast(isnull(adr.statusAnketar,'') as varchar(1)) end) as statusAnketar" + nvrd +
                            " ,UklonitiLice, UklonitiLiceRazlog, UklonitiLiceObjasnjenje" + nvrd +
                            " From spisaklica a left Join p2_dom b on a.[MBOPS]=b.[MBOPS] And a.[Krug_idcd]=b.[Krug_idcd] And a.[kucni_broj_idCD]=b.[kucni_broj_idCD] " + nvrd +
                            " and a.[RbrStan]=b.[RbrStan] and a.rbrdom=b.rbrdom " + nvrd +
                            " left join adresar as adr on  a.[MBOPS]=adr.[MBOPS] and a.[Krug_idcd]=adr.[Krug_idcd] and a.[kucni_broj_idCD]=adr.[kucni_broj_idCD] and a.[RbrStan]=adr.[RbrStan] " + nvrd +
                            " left join p2_stan as st on a.[MBOPS]=st.[MBOPS] and a.[Krug_idcd]=st.[Krug_idcd] and a.[kucni_broj_idCD]=st.[kucni_broj_idCD] and a.[RbrStan]=st.[RbrStan] " + nvrd +
                            " where 2=3"
        Return str
    End Function

    Private Sub dgv1_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DGV1.DataBindingComplete
        For Each r As DataGridViewRow In DGV1.Rows
            r.Cells("OOpen1") = New DataGridViewLinkCell()
            Call formatLLCell(r.Cells("OOpen1"))

            r.Cells("EEdit") = New DataGridViewLinkCell()
            Call formatLLCell(r.Cells("EEdit"))

            If r.Cells("DA").Value <> "" Then
                r.Cells("DA") = New DataGridViewLinkCell()
                Call formatLLCell(r.Cells("DA"))
            End If

            r.Cells("DDelete") = New DataGridViewLinkCell()
            Call formatLLCell(r.Cells("DDelete"))
        Next

        DGV1.ClearSelection()
    End Sub
    Sub formatLLCell(ByVal llcell As DataGridViewLinkCell)
        Dim c1 As DataGridViewLinkCell = DirectCast(llcell, DataGridViewLinkCell)
        c1.UseColumnTextForLinkValue = True
        c1.LinkBehavior = LinkBehavior.AlwaysUnderline
        c1.LinkColor = Color.Black
        c1.VisitedLinkColor = Color.Black
        c1.TrackVisitedState = True
    End Sub
    'Filteri za DGV1
    Dim filterUlica As TextBox
    Dim filterUlicaDGV2 As TextBox
    Dim filterStatus As ComboBox
    Dim filterUlicaMapa As TextBox
    Dim filterNapomenaKBR As TextBox
    Dim filterAdresaTerenDGV2 As TextBox
    Dim filterDatumZakazan As ComboBox

    'Filteri za DGV2
    Dim filterStatusDGV2 As ComboBox

    'filteri za DGV3
    Dim filterUlicaDGV3 As TextBox
    Dim filterImePrezime As TextBox
    'Dim filterJMBG As TextBox

    Sub srediGridView222()

        DGV1.Columns("praznoA").Frozen = True

        Call applyGridTheme4(DGV1, color1, Color.Black)
        Call applyGridTheme4(DGV2, color2, Color.Black)
        Call applyGridTheme4(DGV3, color3, Color.Black)

        DGV1.Columns("praznoA").HeaderCell.Style.BackColor = color2
        DGV1.Columns("praznoB").HeaderCell.Style.BackColor = color2
        DGV1.Columns("praznoD").HeaderCell.Style.BackColor = color2
        DGV1.Columns("praznoD2").HeaderCell.Style.BackColor = color2
        DGV1.Columns("praznoE").HeaderCell.Style.BackColor = color2
        'DGV1.Columns("praznof").HeaderCell.Style.BackColor = color2

        DGV1.Columns("praznoA").DefaultCellStyle.BackColor = color2
        DGV1.Columns("praznoB").DefaultCellStyle.BackColor = color2
        DGV1.Columns("praznoD").DefaultCellStyle.BackColor = color2
        DGV1.Columns("praznoD2").DefaultCellStyle.BackColor = color2
        DGV1.Columns("praznoE").DefaultCellStyle.BackColor = color2
        Me.filterUlica = New TextBox()
        filterUlica.Name = "FilterUlica"
        filterUlica.Visible = False
        filterUlica.Width = 200
        AddHandler filterUlica.TextChanged, AddressOf filterTextBoxDGV1_Changed
        DGV1.Controls.Add(filterUlica)

        Me.filterUlicaMapa = New TextBox()
        filterUlicaMapa.Name = "FilterUlicaMapa"
        filterUlicaMapa.Visible = False
        filterUlicaMapa.Width = 200
        AddHandler filterUlicaMapa.TextChanged, AddressOf filterTextBoxDGV1_Changed
        DGV1.Controls.Add(filterUlicaMapa)

        Me.filterNapomenaKBR = New TextBox()
        filterNapomenaKBR.Name = "Filternapomenakbr"
        filterNapomenaKBR.Visible = False
        filterNapomenaKBR.Width = 200
        AddHandler filterNapomenaKBR.TextChanged, AddressOf filterTextBoxDGV1_Changed
        DGV1.Controls.Add(filterNapomenaKBR)

        Me.filterStatus = New CCombobox()
        filterStatus.Name = "FilterStatus"
        filterStatus.DropDownWidth = 300
        filterStatus.Visible = False
        filterStatus.Width = 200
        filterStatus.Items.Clear()



        filterStatus.Items.Add(New CComboboxItem("     - popisivanje objekta nije započeto", Color.Black, Color.White))
        filterStatus.Items.Add(New CComboboxItem("0   - popisivanje objekta/stanova u objektu u toku", Color.Black, Color.Yellow))
        filterStatus.Items.Add(New CComboboxItem("2   - popisivanje objekta/stanova u objektu završeno", Color.Black, Color.LimeGreen))
        filterStatus.Items.Add(New CComboboxItem("*   - svi", Color.Black, Color.White))

        AddHandler filterStatus.SelectedIndexChanged, AddressOf combobox_Changed
        DGV1.Controls.Add(filterStatus)

    End Sub

    'Dim visinaLegende1 As Integer = 0
    'Dim visinaLegende2 As Integer = 0
    Sub Reset()
        'Dim msgtxt400 As String = getMessageText(dtMessages, "400", Me.jezik) + nvrd
        'linklblIstiKrugDrugiPopisivac.Visible = False
        Call zatvoriIPonistiPanele()
        lblnaselje.Text = ""
        ButtonUnosNoveUlice.Visible = False
        PanelIzmenaNazivaNoveUlice.Visible = False
        neradivalidaciju = False
        PanelLegendaDGV1.Visible = False
        PanelLegendaDGV2.Visible = False
        PanelLegendaDGV3.Visible = False
        ButtonResetPK.Enabled = True
        ButtonResetUl.Enabled = True
        btnMapa.Visible = False
        lblBrojKBR.Location = New Point(ButtonUnosNovogKBR.Location.X + ButtonUnosNovogKBR.Width + 30, ButtonUnosNovogKBR.Location.Y)
        Dim strSQl As String

        If nizACTB Is Nothing OrElse nizACTB.Length = 0 Then

            strSQl = " select distinct [Krug_idcd] As valuemember, (case when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(left(krug_idcd,4),4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd)" + nvrd +
                     " then krug_idcd else left(krug_idcd,4) end) As displaymember FROM [Popis2021].[dbo].[AdresarSviKrugovi] a" + nvrd +
                     " where IDANKETAR=N'" + kosam + "' and isnull([IndZavrsenPop],0)=0 order by 1" 'DODATI WHERE ANKETAR = LOGOVAN ANKETAR
            atbPK = sklopiACTextBox(strSQl, "ulica", Me.DBConnectionString)
            atbPK.Name = "ATBPK"
            atbPK.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela"
            atbPK.TabIndex = 2
            atbPK.MinTypedCharacters = 1
            atbPK.autoCompleteMaxDropDownItems = 12
            atbPK.autoCompleteLimitToList = True
            atbPK.autoCompleteLetter = "LAT"
            atbPK.MDoubleClick = False
            atbPK.MaxLength = 4
            atbPK.Width = 250
            atbPK.Height = 22
            atbPK.Location = New Point(lblPK.Location.X + lblPK.Width + 10, lblPK.Location.Y)
            lblnaselje.Location = New Point(atbPK.Location.X + atbPK.Width + 3, atbPK.Location.Y)
            atbPK.BringToFront()
            Me.Controls.Add(atbPK)

            iACTB = iACTB + 1
            ReDim Preserve nizACTB(iACTB)
            ReDim Preserve nizACTBime(iACTB)
            nizACTB(iACTB) = atbPK
            nizACTBime(iACTB) = atbPK.Name.Trim.ToUpper

            atbUlica = sklopiACTextBox(strSQl, "ulica", Me.DBConnectionString)

            atbUlica.Name = "ATBULICA"
            atbUlica.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela"
            atbUlica.TabIndex = 3

            atbUlica.MinTypedCharacters = 1
            atbUlica.MaxLength = 49
            atbUlica.autoCompleteMaxDropDownItems = 12
            atbUlica.autoCompleteLimitToList = True
            atbUlica.autoCompleteLetter = "LAT"
            atbUlica.MDoubleClick = False
            atbUlica.Width = 250
            atbUlica.Height = 22
            atbUlica.Location = New Point(atbPK.Location.X, atbPK.Location.Y + atbPK.Height + 2)

            atbUlica.BringToFront()

            Me.Controls.Add(atbUlica)

            iACTB = iACTB + 1
            ReDim Preserve nizACTB(iACTB)
            ReDim Preserve nizACTBime(iACTB)
            nizACTB(iACTB) = atbUlica
            nizACTBime(iACTB) = atbUlica.Name.Trim.ToUpper

            ButtonUnosNoveUlice.Location = New Point(atbUlica.Location.X + atbUlica.Width + 3, atbUlica.Location.Y)
            ButtonUnosNoveUlice.Height = atbUlica.Height
            PanelIzmenaNazivaNoveUlice.Location = New Point(ButtonUnosNoveUlice.Location.X + ButtonUnosNoveUlice.Width + 3, ButtonUnosNoveUlice.Location.Y)
            PanelIzmenaNazivaNoveUlice.Height = atbUlica.Height
            'jedna ops
            'strSQl = "select distinct NazivOpstine As displaymember, mbops As valuemember from Adresar where mbops='70149' order by nazivopstine" 'DODATI WHERE ANKETAR = LOGOVAN ANKETAR
            'vise ops
            strSQl = " select distinct NazivOpstine as displaymember, a.mbops as valuemember from AdresarSviKrugovi  a  " + nvrd + 'DODATI WHERE ANKETAR = LOGOVAN ANKETAR
                     " where IDANKETAR=N'" + kosam + "' and isnull([IndPrazan],0) not in (1,2,3) and isnull([IndZavrsenPop],0) not in (1,2,3) order by nazivopstine"
            atbOps = sklopiACTextBox(strSQl, "NazivOpstine", Me.DBConnectionString)
            atbOps.Name = "ATBOps"
            atbOps.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela"
            atbOps.TabIndex = 1
            atbOps.MinTypedCharacters = 1
            atbOps.autoCompleteMaxDropDownItems = 12
            atbOps.autoCompleteLimitToList = True
            atbOps.autoCompleteLetter = "LAT"
            atbOps.MDoubleClick = False
            atbOps.MaxLength = 255
            atbOps.Width = 250
            atbOps.Height = 22
            atbOps.Location = New Point(atbPK.Location.X, atbPK.Location.Y - atbPK.Height - 2)
            atbOps.BringToFront()
            Me.Controls.Add(atbOps)

            iACTB = iACTB + 1
            ReDim Preserve nizACTB(iACTB)
            ReDim Preserve nizACTBime(iACTB)
            nizACTB(iACTB) = atbOps
            nizACTBime(iACTB) = atbOps.Name.Trim.ToUpper

            'za izmenu naziva ulice
            atbPromenaNazivaUlice = sklopiACTextBox(strSQl, "ulica", Me.DBConnectionString)

            atbPromenaNazivaUlice.Name = "ATBPROMENANAZIVAULICE"
            atbPromenaNazivaUlice.TabIndex = 10000011
            atbPromenaNazivaUlice.MinTypedCharacters = 1
            atbPromenaNazivaUlice.MaxLength = 49
            atbPromenaNazivaUlice.autoCompleteMaxDropDownItems = 12
            atbPromenaNazivaUlice.autoCompleteLimitToList = False
            'atbPromenaNazivaUlice.autoCompleteLetter = "LAT"
            atbPromenaNazivaUlice.MDoubleClick = False
            atbPromenaNazivaUlice.Width = 479
            atbPromenaNazivaUlice.Height = 22
            atbPromenaNazivaUlice.Location = txtSNUlice.Location

            atbPromenaNazivaUlice.BringToFront()

            PanelIzmenaUL.Controls.Add(atbPromenaNazivaUlice)

            iACTB = iACTB + 1
            ReDim Preserve nizACTB(iACTB)
            ReDim Preserve nizACTBime(iACTB)
            nizACTB(iACTB) = atbPromenaNazivaUlice
            nizACTBime(iACTB) = atbPromenaNazivaUlice.Name.Trim.ToUpper

            'za novi kbr
            atbULKBR = sklopiACTextBox(strSQl, "ulica", Me.DBConnectionString)

            atbULKBR.Name = "ATBULKBR"
            atbULKBR.TabIndex = 10000011
            atbULKBR.MinTypedCharacters = 1
            atbULKBR.MaxLength = 49
            atbULKBR.autoCompleteMaxDropDownItems = 12
            atbULKBR.autoCompleteLimitToList = False
            atbULKBR.autoCompleteLetter = "LAT"
            atbULKBR.MDoubleClick = False
            atbULKBR.Width = 283
            atbULKBR.Height = 22
            atbULKBR.Location = textboxUlica.Location
            atbULKBR.BringToFront()

            Panel3.Controls.Add(atbULKBR)

            iACTB = iACTB + 1
            ReDim Preserve nizACTB(iACTB)
            ReDim Preserve nizACTBime(iACTB)
            nizACTB(iACTB) = atbULKBR
            nizACTBime(iACTB) = atbULKBR.Name.Trim.ToUpper

            If atbOps.AutoCompleteList.Count = 1 Then
                Dim pp() As String = atbOps.AutoCompleteDataSourceDB(0).Split("ˇ")
                atbOps.sselectedValue = pp(0)
                Call dodelaVrAUTB(atbOps, atbOps.sselectedValue)
                atbOps.sselectedText = atbOps.Text
                atbOps.Enabled = False
            Else
                atbOps.Enabled = True
                atbOps.Focus()
            End If

            Me.ButtonNastavi.Location = New Point(atbUlica.Location.X, atbUlica.Location.Y + atbUlica.Height + 7)
            'lblInformation.Location = New Point(ButtonNastavi.Location.X + ButtonNastavi.Width + 10, ButtonNastavi.Location.Y)
            btnInformation.Location = New Point(ButtonNastavi.Location.X + ButtonNastavi.Width + 10, ButtonNastavi.Location.Y)
        End If



        If Not nizACTB Is Nothing AndAlso nizACTB.Length > 0 Then
            atbOps.nepotrebnavalidacija = False
            atbUlica.nepotrebnavalidacija = False
            atbPK.nepotrebnavalidacija = False
            nizACTB(0).Text = ""
            nizACTB(0).sselectedText = ""
            nizACTB(0).sselectedValue = ""
            nizACTB(1).Text = ""
            nizACTB(1).sselectedText = ""
            nizACTB(1).sselectedValue = ""
            atbPK.Enabled = True
            atbUlica.Enabled = True
            ButtonUnosNoveUlice.Enabled = True
            If atbOps.Enabled = True Then
                nizACTB(2).Text = ""
                nizACTB(2).sselectedText = ""
                nizACTB(2).sselectedValue = ""
                'atbOps.Focus()
            Else
                atbPK.sselectedValue = ""
                atbPK.sselectedText = ""
                atbPK.Text = ""
                'lblInformation.Visible = False
                btnInformation.Visible = False
                atbUlica.sselectedValue = ""
                atbUlica.sselectedText = ""
                atbUlica.Text = ""

                strSQl = " select distinct [Krug_idcd] As valuemember, " + nvrd +
                                       " (case " + nvrd +
                                       " when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and  isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and (isnull(USER_UPDATE_IndZavrsenPop,'') like N'i7%' or isnull(USER_UPDATE_IndZavrsenPop,'') like N'i8%')" + nvrd +
                                       " then krug_idcd+' - vracen na doradu' " + nvrd +
                                       " when not exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and (isnull(USER_UPDATE_IndZavrsenPop,'') like N'i7%' or isnull(USER_UPDATE_IndZavrsenPop,'') like N'i8%')" + nvrd +
                                       " then left(krug_idcd,4)+' - vracen na doradu' " + nvrd +
                                       " when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and  isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i7%' and  isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i8%'" + nvrd +
                                       " then krug_idcd " + nvrd +
                                       " when not exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i7%' and  isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i8%'" + nvrd +
                                       " then left(krug_idcd,4) " + nvrd +
                                       " Else left(krug_idcd,4) end) As displaymember " + nvrd +
                                       " FROM [Popis2021].[dbo].[AdresarSviKrugovi] a " + nvrd +
                                       " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and isnull([IndPrazan],0) not in (1,2,3) and isnull([IndZavrsenPop],0) not in (1,2,3) order by 1" 'DODATI WHERE ANKETAR = LOGOVAN ANKETAR
                Call popuniAutbDB(atbPK, strSQl)
                atbPK.Visible = True
                'atbPK.Focus()
            End If
        End If

        tboxIDULICE.Text = ""
        Call enableIzborZaGrid()

        If atbOps.AutoCompleteList.Count = 1 Then
            atbOps.Enabled = False
            atbPK.Focus()
        Else
            atbOps.Enabled = True
            atbOps.Focus()
        End If

        Call invisibletabkontrola()


        If Not TabControl1.Controls.Contains(TabPage1) Then
            TabControl1.TabPages.Remove(TabPage3)
            TabControl1.TabPages.Remove(TabPage2)
            TabPage2.Text = "Unos/izmena podataka o stanu i ishoda poseta"
            TabControl1.TabPages.Add(TabPage1)
            TabControl1.TabPages.Add(TabPage2)
            TabControl1.TabPages.Add(TabPage3)
            TabControl1.SelectedTab = TabPage1
            TabPage1.Visible = True
            'ivanaaa
            Call praznidgv2()
            TabControl1.SelectedIndex = 0
            ButtonZakazani.BackColor = System.Drawing.SystemColors.Control
            ButtonZakazani.Text = "Svi zakazani stanovi"
            BtnSvaLica.BackColor = System.Drawing.SystemColors.Control
            BtnSvaLica.Text = "Sva lica"
            'TabControl1.TabPages.Add(TabPage2)
        End If

        '20220715 Call refreshDGV1()

        Dim pomocnaNapomenaKBR As String = ""
        Dim pomocnaUlicaMapa As String = ""
        Dim pomocnaUlica As String = ""
        Dim pomocna As String = ""
        If Not filterNapomenaKBR Is Nothing Then
            pomocnaNapomenaKBR = filterNapomenaKBR.Text
        End If
        If Not filterUlicaMapa Is Nothing Then
            pomocnaUlicaMapa = filterUlicaMapa.Text
        End If
        If Not filterUlica Is Nothing Then
            pomocnaUlica = filterUlica.Text
        End If
        If Not filterStatus Is Nothing Then
            pomocna = filterStatus.Text
            If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
            If pomocna = "*" Then pomocna = ""
        End If
        refreshDGV1(pomocnaUlica, pomocna, pomocnaUlicaMapa, pomocnaNapomenaKBR)

        'If PanelLegendaDGV1.Height < 200 AndAlso btnLegenda1M.Text = "🗖" Then
        '    LegMaximize()
        'End If
        'Legenda() 'ima u  Call refreshDGV1, pa unutar njega Call refreshDGV2

        atbUlica.MinTypedCharacters = 1



        If DGV2.Controls.Contains(filterDatumZakazan) Then
        Else
            Me.filterDatumZakazan = New ComboBox()
            filterDatumZakazan.Name = "filterDatumZakazan"
            filterDatumZakazan.DropDownWidth = 300
            filterDatumZakazan.Visible = False
            filterDatumZakazan.Width = 200
            Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' order by ZakazanoDatum", Me.DBConnectionString, False, False, True, True)
            'filterDatumZakazan.Items.AddRange(New Object() {"01.10.2021", "02.10.2021", "03.10.2021", "04.10.2021", "05.10.2021", "06.10.2021", "07.10.2021", "08.10.2021", "09.10.2021", "10.10.2021", "11.10.2021", "12.10.2021", "13.10.2021", "14.10.2021", "15.10.2021", "16.10.2021", "17.10.2021", "18.10.2021", "19.10.2021", "20.10.2021", "21.10.2021", "22.10.2021", "23.10.2021", "24.10.2021", "25.10.2021", "26.10.2021", "27.10.2021", "28.10.2021", "29.10.2021", "30.10.2021", "31.10.2021", "01.11.2021", "02.11.2021", "03.11.2021", "04.11.2021", "05.11.2021", "06.11.2021", "07.11.2021", "08.11.2021", "09.11.2021", "10.11.2021", "11.11.2021", "12.11.2021", "13.11.2021", "14.11.2021", "15.11.2021", "16.11.2021", "17.11.2021", "18.11.2021", "19.11.2021", "20.11.2021", "21.11.2021", "22.11.2021", "23.11.2021", "24.11.2021", "25.11.2021", "26.11.2021", "27.11.2021", "28.11.2021", "29.11.2021", "30.11.2021", "", ""})
            filterDatumZakazan.TabStop = False
            AddHandler filterDatumZakazan.SelectedIndexChanged, AddressOf comboboxdatum_Changed
            'AddHandler filterStatus.DrawItem, AddressOf ComboBox1_DrawItem
            DGV2.Controls.Add(filterDatumZakazan)
        End If

        If DGV2.Controls.Contains(filterStatusDGV2) Then
        Else
            Me.filterStatusDGV2 = New CCombobox()
            filterStatusDGV2.Name = "filterStatusDGV2"
            filterStatusDGV2.DropDownWidth = 500
            'filterStatus.Text = "(*)"
            filterStatusDGV2.Visible = False
            filterStatusDGV2.Width = 200
            filterStatusDGV2.Items.Clear()
            filterStatusDGV2.Items.Add(New CComboboxItem("     - popisivanje nije započeto", Color.Black, Color.White))
            filterStatusDGV2.Items.Add(New CComboboxItem("0   - popisivanje u toku", Color.Black, Color.Yellow))
            filterStatusDGV2.Items.Add(New CComboboxItem("1   - popisivanje završeno, podaci će sledećom sinhronizacijom biti poslati", Color.Black, Color.PaleGreen))
            filterStatusDGV2.Items.Add(New CComboboxItem("2   - popisivanje završeno, podaci poslati na server", Color.Black, Color.LimeGreen))
            filterStatusDGV2.Items.Add(New CComboboxItem("3   - Popisivač je zatražio od instruktora mogućnost ispravke poslatog stana ", Color.Black, Color.Gainsboro))
            filterStatusDGV2.Items.Add(New CComboboxItem("4   - Instruktor je popisivaču vratio stan na doradu", Color.Black, Color.Red))
            filterStatusDGV2.Items.Add(New CComboboxItem("*   - svi", Color.Black, Color.White))
            filterStatusDGV2.TabStop = False
            AddHandler filterStatusDGV2.SelectedIndexChanged, AddressOf comboboxdgv2status_Changed
            'AddHandler filterStatus.DrawItem, AddressOf ComboBox1_DrawItem
            DGV2.Controls.Add(filterStatusDGV2)
        End If

        If DGV2.Controls.Contains(filterUlicaDGV2) Then
        Else
            Me.filterUlicaDGV2 = New TextBox()
            filterUlicaDGV2.Name = "filterUlicaDGV2"
            filterUlicaDGV2.Visible = False
            filterUlicaDGV2.Width = 200
            filterUlicaDGV2.Tag = ""
            AddHandler filterUlicaDGV2.TextChanged, AddressOf filterTextBoxDGV2_Changed
            DGV2.Controls.Add(filterUlicaDGV2)
        End If

        If DGV2.Controls.Contains(filterAdresaTerenDGV2) Then
        Else
            Me.filterAdresaTerenDGV2 = New TextBox()
            filterAdresaTerenDGV2.Name = "filterAdresaTerenDGV2"
            filterAdresaTerenDGV2.Visible = False
            filterAdresaTerenDGV2.Width = 200
            filterAdresaTerenDGV2.Tag = ""
            AddHandler filterAdresaTerenDGV2.TextChanged, AddressOf filterTextBoxDGV2_Changed
            DGV2.Controls.Add(filterAdresaTerenDGV2)
        End If


        If DGV3.Controls.Contains(filterUlicaDGV3) Then
            filterUlicaDGV3.Visible = False
        Else
            Me.filterUlicaDGV3 = New TextBox()
            filterUlicaDGV3.Name = "filterUlicaDGV3"
            filterUlicaDGV3.Visible = False
            filterUlicaDGV3.Width = 200
            filterUlicaDGV3.Tag = ""
            AddHandler filterUlicaDGV3.TextChanged, AddressOf filterTextBoxDGV3_Changed
            DGV3.Controls.Add(filterUlicaDGV3)
        End If

        If DGV3.Controls.Contains(filterImePrezime) Then
        Else
            Me.filterImePrezime = New TextBox()
            filterImePrezime.Name = "filterImePrezime"
            filterImePrezime.Visible = False
            filterImePrezime.Width = 200
            filterImePrezime.Tag = ""
            AddHandler filterImePrezime.TextChanged, AddressOf filterTextBoxDGV3_Changed
            DGV3.Controls.Add(filterImePrezime)
        End If

        'If DGV3.Controls.Contains(filterJMBG) Then
        'Else
        '    Me.filterJMBG = New TextBox()
        '    filterJMBG.Name = "filterJMBG"
        '    filterJMBG.Visible = False
        '    filterJMBG.Width = 200
        '    filterJMBG.Tag = ""
        '    AddHandler filterJMBG.TextChanged, AddressOf filterTextBoxDGV3_Changed
        '    DGV3.Controls.Add(filterJMBG)
        'End If
        ButtonUnosNoveUlice.Visible = False
        PanelIzmenaNazivaNoveUlice.Visible = False
        'llOVDE.Visible = True
        'ButtonUnosNoveUlice.Visible = True
        lblBrojKBR.Text = ""


        cmbRazlogUklanjanja.Items.Clear()
        'cmbRazlogUklanjanja.Items.Add(New KeyValuePair(Of String, String)("1", "Lice nije član domaćinstva"))
        'cmbRazlogUklanjanja.Items.Add(New KeyValuePair(Of String, String)("2", "Lice ne živi u ovom stanu"))
        'cmbRazlogUklanjanja.Items.Add(New KeyValuePair(Of String, String)("3", "Lice ne živi na ovom kućnom broju"))

        cmbRazlogUklanjanja.Items.Add("Nepotrebno sačuvano. Lice nije član domaćinstva")
        cmbRazlogUklanjanja.Items.Add("Nepotrebno sačuvano. Lice ne živi u ovom stanu")
        cmbRazlogUklanjanja.Items.Add("Nepotrebno sačuvano. Lice ne živi na ovom kućnom broju")
        cmbRazlogUklanjanja.Items.Add("Nepotrebno sačuvano. ...Služba da da predlog za spisak razloga")
        'cmbRazlogUklanjanja.Items.Add(New ComboboxItem("     - popisivanje objekta nije započeto", Color.Black, Color.White))
        'cmbRazlogUklanjanja.Items.Add(New ComboboxItem("0   - popisivanje objekta/stanova u objektu u toku", Color.Black, Color.Yellow))
        'cmbRazlogUklanjanja.Items.Add(New ComboboxItem("2   - popisivanje objekta/stanova u objektu završeno", Color.Black, Color.LimeGreen))
        'cmbRazlogUklanjanja.Items.Add(New ComboboxItem("*   - svi", Color.Black, Color.White))

        AddHandler cmbRazlogUklanjanja.SelectedIndexChanged, AddressOf cmbUkloniti_Changed
        PanelUklanjanje.Controls.Add(cmbRazlogUklanjanja)

        Dim strBTNZaKrug = "select * from AdresarSviKrugovi where idanketar=N'" + kosam + "' and " + nvrd +
                    " (isnull(IndZavrsenPop,0)=1 or isnull(IndPrazan,0)=1)"
        Dim dtBTNZaKrug As DataTable = izvrsiSQLvratiDT(strBTNZaKrug, Me.DBConnectionString, Me.jezik)
        If dtBTNZaKrug.Rows.Count > 0 Then
            btnVracanjeKrugova.Visible = True
        Else
            btnVracanjeKrugova.Visible = False
        End If

    End Sub
    Sub dodelaVrAUTB(ByVal autbox As AutoCompleteTextbox, ByVal vr As String)
        'zbog OnTextChanged koji je u formTemplate
        autbox.AccessibleName = autbox.AccessibleName + "WSAWS;" 'zbog OnTextChanged koji je u formTemplate

        If autbox.DB = True AndAlso Not autbox.AutoCompleteDataSourceDB Is Nothing Then
            For Each Str As String In autbox.AutoCompleteDataSourceDB
                Dim pp() As String = Str.Split("ˇ")
                'pp(0) - value, pp(1) - display
                Dim pomstrV As String = pp(0)
                If pomstrV.ToLower.Trim = vr.ToLower.Trim Then
                    vr = pp(1)
                    autbox.sselectedValue = pp(0)
                    autbox.sselectedText = vr
                    Exit For
                End If
            Next
        End If

        If vr <> "" Then
            autbox.CurrentAutoCompleteList.Clear()
            If Not autbox.AccessibleName Is Nothing AndAlso autbox.AccessibleName.IndexOf("ENCRYPT;") >= 0 Then
                'vr = Decrypt(vr)
                'Nevena 08082022
                'vr = CryptoReader.AesCrypt.DecryptStringAES(vr)
                vr = DeKripto(vr, DBConnectionString, Me.jezik)
            Else
                autbox.CurrentAutoCompleteList.Add(vr)
            End If
        End If
        autbox.Text = vr
        autbox.Text = autbox.Text.Trim

        autbox.AccessibleName = autbox.AccessibleName.Replace("WSAWS;", "")

    End Sub

    Sub zatvoriIPonistiPanele()

        For Each k As Control In Me.Controls
            If TypeOf k Is Panel AndAlso CStr(k.Tag) <> "NeDiraj" Then
                k.Visible = False
                TabControl1.Tag = ""
                For Each kk As Control In k.Controls
                    If TypeOf kk Is TextBox Then
                        DirectCast(kk, TextBox).Text = ""
                    End If
                    If TypeOf kk Is AutoCompleteTextbox Then
                        DirectCast(kk, AutoCompleteTextbox).Text = ""
                        DirectCast(kk, AutoCompleteTextbox).sselectedText = ""
                        DirectCast(kk, AutoCompleteTextbox).sselectedValue = ""
                    End If
                    If TypeOf kk Is CheckBox Then
                        DirectCast(kk, CheckBox).Checked = False
                    End If
                    If TypeOf kk Is RadioButton Then
                        DirectCast(kk, RadioButton).Checked = False
                    End If
                    If TypeOf kk Is ComboBox Then
                        DirectCast(kk, ComboBox).Text = ""
                        DirectCast(kk, ComboBox).SelectedText = ""
                        DirectCast(kk, ComboBox).SelectedValue = ""
                    End If
                Next
            End If
        Next

    End Sub
    Private Sub SetLang()
        ''
        Dim dt As DataTable = getDTVBText(dtLang, "FormPopisAdresar")
        'Me.lblPK.Text = getControlText2(dt, "lblPK", Me.jezik)

        'Me.lblPK.Text = getControlText2(dt, "lblPK", Me.jezik)
        'Me.btnReset.Text = getControlText2(dt, "btnReset1", Me.jezik) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & getControlText2(dt, "btnReset2", Me.jezik)
        'Me.Label11.Text = getControlText2(dt, "Label11", Me.jezik)
        'Me.Label10.Text = getControlText2(dt, "Label10", Me.jezik)
        'Me.Label9.Text = getControlText2(dt, "Label9", Me.jezik)
        'Me.Label8.Text = getControlText2(dt, "Label8", Me.jezik)
        'Me.Label14.Text = getControlText2(dt, "Label9", Me.jezik)
        'Me.Label15.Text = getControlText2(dt, "Label8", Me.jezik)
        'Me.Label7.Text = getControlText2(dt, "Label7", Me.jezik)
        'Me.Label13.Text = getControlText2(dt, "Label7", Me.jezik)
        'Me.Button1.Text = getControlText2(dt, "Button1", Me.jezik)
        'Me.ButtonPrikazi.Text = getControlText2(dt, "ButtonPrikazi", Me.jezik)
        'Me.ButtonNastavi.Text = getControlText2(dt, "ButtonNastavi", Me.jezik)
        'Me.lblUlica.Text = getControlText2(dt, "lblUlica", Me.jezik)

        'Me.lblPK.Text = "Popisni krug"
        'Me.btnReset.Text = "Povratak na izbor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "popisnog kruga / ulice"
        'Me.Label11.Text = "Ulica i kbr na terenu"
        'Me.Label10.Text = "Napomena"
        'Me.Label9.Text = "Longituda"
        'Me.Label8.Text = "Latituda"
        'Me.Label14.Text = "Longituda"
        'Me.Label15.Text = "Latituda"
        'Me.Label7.Text = "Krboj"
        'Me.Label13.Text = "Kućni broj"
        'Me.Button1.Text = "Unos novog kućnog broja"
        'Me.ButtonPrikazi.Text = "Dodaj u adresar"
        'Me.ButtonNastavi.Text = "Nastavi"
        'Me.lblUlica.Text = "Ulica"

        ' Dim msgtxt225 As String = getMessageText(dtMessages, "225", jezik)
    End Sub
    Sub popuniAutbDB(ByVal actbox As AutoCompleteTextbox, ByVal acDataSource As String)
        Dim dt As DataTable = izvrsiSQLvratiDT(acDataSource, Me.DBConnectionString, Nothing)
        Dim dv As DataView = dt.DefaultView
        actbox.DB = True
        If actbox.orderBy <> "" Then dv.Sort = actbox.orderBy

        Dim sourceDisplay As Object = New List(Of String)()
        Dim dataSource As Object = New List(Of String)()
        Dim pomD As String = ""
        Dim pomV As String = ""
        For i As Integer = 0 To dv.Count - 1
            pomD = IIf(dv(i).Item(actbox.displayMember.Trim) Is System.DBNull.Value, "", dv(i).Item(actbox.displayMember.Trim).ToString.Trim)
            pomV = IIf(dv(i).Item(actbox.valueMember) Is System.DBNull.Value, "", dv(i).Item(actbox.valueMember).ToString.Trim)
            sourceDisplay.Add(pomD)
            dataSource.Add(pomV + "ˇ" + pomD)
        Next
        actbox.AutoCompleteList = sourceDisplay
        actbox.AutoCompleteDataSourceDB = dataSource
    End Sub
    Function sklopiACTextBox(ByVal strSQl As String, ByVal orderBy As String, ByVal DBConnectionString As String) As Control
        sklopiACTextBox = Nothing
        Dim actbox As New AutoCompleteTextbox
        actbox.AccessibleName = actbox.AccessibleName + "AUTB;"

        Dim ft As FontStyle = FontStyle.Regular
        Dim ftB As FontStyle = FontStyle.Bold
        Dim ftI As FontStyle = FontStyle.Italic
        Dim ftU As FontStyle = FontStyle.Underline

        actbox.Font = New Font(Me.Font, ft)
        actbox.BorderStyle = BorderStyle.FixedSingle

        Dim ssourcetxt As String = ""
        Dim acMTLength As Integer = 2 'default

        Dim acFilter As String = ""
        Dim acFilterStart As Integer = 0
        Dim acFilterLength As Integer = 0
        Dim acLimitToList As String = ""
        Dim acLetter As String = "LAT" 'default
        Dim acMaxDropDownItems As Integer = 12 'default

        Dim acDisplayMember As String = "displaymember"
        Dim acValueMember As String = "valuemember"
        Dim acDataSource As String = strSQl
        Dim acOrderBy As String = "displaymember" 'orderBy

        actbox.DB = True
        actbox.displayMember = acDisplayMember.Trim
        actbox.valueMember = acValueMember.Trim
        actbox.DataSourceDB = acDataSource.Trim
        actbox.orderBy = acOrderBy.Trim
        Call popuniAutbDB(actbox, acDataSource)

        '*****
        actbox.MinTypedCharacters = acMTLength
        actbox.autoCompleteMaxDropDownItems = acMaxDropDownItems
        actbox.autoCompleteLimitToList = False
        actbox.autoCompleteLetter = acLetter
        If acLimitToList <> "" AndAlso acLimitToList.Trim.ToUpper = "False" Then actbox.autoCompleteLimitToList = False
        actbox.MDoubleClick = False
        '*****
        AddHandler actbox.KeyPress, AddressOf Me.pp_KeyPress
        AddHandler actbox.Validating, AddressOf Me.actb_validating
        AddHandler actbox.TextChanged, AddressOf Me.actb_TextChanged
        AddHandler actbox.Enter, AddressOf Me.actb_Enter
        AddHandler actbox.KeyUp, AddressOf Me.pp_KeyUp

        Return actbox

    End Function
    Dim actbOpsStaro As String = ""
    Dim actb0Staro As String = ""
    Dim actb1Staro As String = ""
    Private Sub actb_Enter(sender As Object, e As EventArgs)

        Dim actbox As AutoCompleteTextbox = DirectCast(sender, AutoCompleteTextbox)
        'SendKeys.SendWait("{F4}")
        Dim actboxime As String = actbox.Name.Trim.ToUpper
        Select Case actboxime
            Case "ATBOPS"
                actbOpsStaro = ""
                actbOpsStaro = actbox.Text
            Case "ATBPK"
                actb0Staro = ""
                actb0Staro = actbox.Text
                ButtonUnosNoveUlice.Visible = False
                PanelIzmenaNazivaNoveUlice.Visible = False
            Case "ATBULICA"
                actb1Staro = ""
                actb1Staro = actbox.Text
        End Select

    End Sub
    Private neradivalidaciju As Boolean = False
    Private Sub actb_validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) ' LostFocus

        If neradivalidaciju = True Then
            neradivalidaciju = False
            Dim autb1 As AutoCompleteTextbox = DirectCast(sender, AutoCompleteTextbox)
            If autb1.sselectedValue <> "" AndAlso autb1.Name = "ATBPK" Then
                ButtonUnosNoveUlice.Visible = True
                PanelIzmenaNazivaNoveUlice.Visible = True
            End If
            Exit Sub
        End If

        neradivalidaciju = False

        'If btnReset.Focused = False AndAlso DirectCast(sender, AutoCompleteTextbox).sselectedText = "" Then
        '    ISTMessageBox.Show("Sinisa Cimba")
        '    sender.focus()
        'End If
        Dim autb As AutoCompleteTextbox = DirectCast(sender, AutoCompleteTextbox)
        If autb.Text.Trim = "" AndAlso autb.Name <> "ATBULICA" Then
            autb.Focus()
            Call autbleaveAL(sender)
            Exit Sub
        End If

        Call autbleaveAL(sender)

        If autb.Name = "ATBPK" Then
            Dim str As String = ""
            str = " select distinct NazivNaselja from AdresarSviKrugovi " +
                  " where IDANKETAR=N'" + kosam + "' and krug_idcd='" + atbPK.sselectedValue + "' and mbops='" + atbOps.sselectedValue + "'"
            Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                lblnaselje.Text = "Naseljeno mesto: " + dt.Rows(0).Item(0).ToString + ""
            Else
                lblnaselje.Text = ""
                'ButtonUnosNoveUlice.Visible = False
                'PanelIzmenaNazivaNoveUlice.Visible = False
            End If

        End If

        If autb.Name = "ATBPK" Then
            ButtonUnosNoveUlice.Visible = True
            PanelIzmenaNazivaNoveUlice.Visible = True
        End If



    End Sub
    Private Sub actb_TextChanged(sender As Object, e As EventArgs)
        Dim tbox As AutoCompleteTextbox = sender
        If Not tbox.AccessibleName Is Nothing AndAlso tbox.AccessibleName.Trim <> "" AndAlso tbox.AccessibleName.Trim.ToUpper.IndexOf("CONVERTCIRLAT") >= 0 Then
            If tbox.Text.Trim <> "" AndAlso IsNumeric(tbox.Text) = False Then
                tbox.Text = FormTemplate.konverzijaCirLat(tbox.Text)
                tbox.Select(tbox.Text.Length, 0)
            End If
        End If

        If Not tbox.AccessibleName Is Nothing AndAlso tbox.AccessibleName.Trim <> "" AndAlso tbox.AccessibleName.Trim.ToUpper.IndexOf("CONVERTLATCIR") >= 0 Then
            If tbox.Text.Trim <> "" AndAlso IsNumeric(tbox.Text) = False Then
                tbox.Text = FormTemplate.konverzijaLatCir(tbox.Text)
                tbox.Select(tbox.Text.Length, 0)
            End If
        End If
    End Sub
    Private Sub pp_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Dim tbox As Control = sender
        Dim autb As Boolean = False
        If Not tbox.AccessibleName Is Nothing Then tbox.AccessibleName = tbox.AccessibleName + ";" : tbox.AccessibleName = tbox.AccessibleName.Replace(";;", ";")
        If Not tbox.AccessibleName Is Nothing AndAlso tbox.AccessibleName.IndexOf("AUTB;") >= 0 Then
            tbox = CType(sender, AutoCompleteTextbox)
            autb = True
        Else
            tbox = CType(sender, TextBox)
        End If

        Dim plj As String = Mid(tbox.Name.Trim.ToUpper, 3)
        'AktivanTekstBoks = tbox
        Select Case e.KeyChar
            Case ChrW(27) 'ESC

            Case ChrW(13) 'Enter
                Try
                    If Not tbox.AccessibleName Is Nothing AndAlso tbox.AccessibleName.IndexOf("AUTB;") >= 0 Then
                        'Call autbleaveAL(tbox)
                        If tbox.Name = "ATBULKBR" Then
                            tboxkbr.Focus()
                        End If
                        If tbox.Name = "ATBPROMENANAZIVAULICE" Then
                            'txtNNUlice.Text = tbox.Text
                            txtNNUlice.Text = ""
                            txtNNUlice.Focus()
                            'txtNNUlice.SelectionStart = 0
                            'txtNNUlice.SelectionLength = txtNNUlice.Text.Length
                        End If
                        If tbox.Name = "ATBULICA" AndAlso atbUlica.Text.Trim <> "" Then
                            Me.ButtonNastavi.Focus()
                        ElseIf tbox.Name = "ATBULICA" AndAlso atbUlica.Text.Trim = "" Then
                            Me.ButtonUnosNoveUlice.Focus()
                        End If
                        If atbOps.Enabled = False Then
                            If tbox.Name = "ATBPK" Then
                                Call actbV0()
                            End If
                        Else
                            If tbox.Name.Trim.ToUpper = "ATBOPS" Then
                                Call actbVOps()
                            ElseIf tbox.Name = "ATBPK" Then
                                Call actbV0()
                            End If
                        End If
                    Else
                        'Me.SelectNextControl(ActiveControl, True, True, True, True)
                    End If

                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            Case Else
        End Select

    End Sub
    Sub actbV0()
        'osveziti
        Me.lblUlica.Visible = True
        Me.ButtonNastavi.Visible = True
        Call nevid()

        If actb0Staro <> atbPK.Text Then
            atbUlica.sselectedValue = ""
            atbUlica.sselectedText = ""
            atbUlica.Text = ""
            Dim strSQl As String = dodatak + " select distinct  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " +
                                   " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "'" +
                                   " union" +
                                   " select '(*)' as displaymember, '000000000000' as valuemember order by displaymember"
            Call popuniAutbDB(atbUlica, strSQl)
        End If

        atbUlica.Visible = True
        atbUlica.Focus()
        atbUlica.SelectionStart = 0
        atbUlica.SelectionLength = atbUlica.Text.Length
        'SendKeys.SendWait("{F4}")
    End Sub
    Sub actbVOps()
        'osveziti
        Me.lblUlica.Visible = True
        Call nevid()

        If actbOpsStaro <> atbOps.Text Then
            atbPK.sselectedValue = ""
            atbPK.sselectedText = ""
            atbPK.Text = ""
            'lblInformation.Visible = False
            btnInformation.Visible = False
            atbUlica.sselectedValue = ""
            atbUlica.sselectedText = ""
            atbUlica.Text = ""
            'Dim strSQl As String = "select distinct left(krug_idcd,4) as displaymember,krug_idcd as valuemember from Adresar " +
            '    " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' order by krug_idcd"
            Dim strSQl As String =
                     " select distinct [Krug_idcd] As valuemember, " + nvrd +
                                       " (case " + nvrd +
                                       " when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and  isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and (isnull(USER_UPDATE_IndZavrsenPop,'') like N'i7%' or isnull(USER_UPDATE_IndZavrsenPop,'') like N'i8%')" + nvrd +
                                       " then krug_idcd+' - vracen na doradu' " + nvrd +
                                       " when not exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and (isnull(USER_UPDATE_IndZavrsenPop,'') like N'i7%' or isnull(USER_UPDATE_IndZavrsenPop,'') like N'i8%')" + nvrd +
                                       " then left(krug_idcd,4)+' - vracen na doradu' " + nvrd +
                                       " when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and  isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i7%' and  isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i8%'" + nvrd +
                                       " then krug_idcd " + nvrd +
                                       " when not exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i7%' and  isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i8%'" + nvrd +
                                       " then left(krug_idcd,4) " + nvrd +
                                       " Else left(krug_idcd,4) end) As displaymember " + nvrd +
                                       " FROM [Popis2021].[dbo].[AdresarSviKrugovi] a " + nvrd +
                                       " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and isnull([IndPrazan],0) not in (1,2,3) and isnull([IndZavrsenPop],0) not in (1,2,3) order by 1"

            '" select distinct [Krug_idcd] As valuemember, (case when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(left(krug_idcd,4),4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd)" + nvrd +
            '         " then krug_idcd else left(krug_idcd,4) end) As displaymember FROM [Popis2021].[dbo].[AdresarSviKrugovi] a" + nvrd +
            '         " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and isnull([IndZavrsenPop],0)=0 order by 1" 'DODATI WHERE ANKETAR = LOGOVAN ANKETAR
            Call popuniAutbDB(atbPK, strSQl)
        End If

        atbPK.Visible = True
        atbPK.Focus()
        atbPK.SelectionStart = 0
        atbPK.SelectionLength = atbPK.Text.Length

    End Sub
    Dim text1 As String = ""
    Private Sub autbleaveAL(ByVal actb As AutoCompleteTextbox)

        actb.HideSuggestionListBox()

        If actb.Text.Trim <> "" AndAlso actb.CurrentAutoCompleteList.Count = 0 AndAlso actb.autoCompleteLimitToList = True Then
            actb.Text = ""
            actb.assignvalue = ""
            actb.sselectedValue = ""
            Exit Sub
        End If

        If Me.Text.Trim <> "" AndAlso actb.CurrentAutoCompleteList.Count = 0 AndAlso actb.autoCompleteLimitToList = False Then
            actb.assignvalue = ""
            actb.sselectedValue = ""
            Exit Sub
        End If

        Dim dodeli As String = ""
        If actb.DB = True Then
            If actb.Text.Trim <> "" Then
                For Each sstr As String In actb.AutoCompleteDataSourceDB
                    Dim pp() As String = sstr.Split("ˇ")
                    'pp(0) - value
                    'pp(1) - display
                    Dim pomstrD As String = pp(1)
                    If pomstrD.ToLower.Trim = actb.Text.ToLower.Trim Then
                        dodeli = pp(0)
                        Exit For
                    End If
                Next
            End If
            actb.sselectedValue = dodeli.Trim
            If dodeli.Trim = "" Then actb.Text = ""
            actb.sselectedText = actb.Text.Trim
        End If
        If atbOps.sselectedValue <> "" AndAlso atbOps.sselectedText <> "" Then
            If actb.Name.Trim.ToUpper = "ATBOPS" Then
                Dim strSQl As String = " select distinct [Krug_idcd] As valuemember, " + nvrd +
                                       " (case " + nvrd +
                                       " when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and  isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and (isnull(USER_UPDATE_IndZavrsenPop,'') like N'i7%' or isnull(USER_UPDATE_IndZavrsenPop,'') like N'i8%')" + nvrd +
                                       " then krug_idcd+' - vracen na doradu' " + nvrd +
                                       " when not exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and (isnull(USER_UPDATE_IndZavrsenPop,'') like N'i7%' or isnull(USER_UPDATE_IndZavrsenPop,'') like N'i8%')" + nvrd +
                                       " then left(krug_idcd,4)+' - vracen na doradu' " + nvrd +
                                       " when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and  isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i7%' and  isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i8%'" + nvrd +
                                       " then krug_idcd " + nvrd +
                                       " when not exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd) and isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)=0 and isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i7%' and  isnull(USER_UPDATE_IndZavrsenPop,'') not like N'i8%'" + nvrd +
                                       " then left(krug_idcd,4) " + nvrd +
                                       " Else left(krug_idcd,4) end) As displaymember " + nvrd +
                                       " FROM [Popis2021].[dbo].[AdresarSviKrugovi] a " + nvrd +
                                       " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and isnull([IndPrazan],0) not in (1,2,3) and isnull([IndZavrsenPop],0) not in (1,2,3) order by 1"

                '" select distinct [Krug_idcd] As valuemember, (case when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(left(krug_idcd,4),4)=left(a.krug_idcd,4) and krug_idcd<>a.krug_idcd)" + nvrd +
                '                      " then krug_idcd else left(krug_idcd,4) end) As displaymember FROM [Popis2021].[dbo].[AdresarSviKrugovi] a" + nvrd +
                '                      " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and isnull([IndZavrsenPop],0)=0 order by 1" 'DODATI WHERE ANKETAR = LOGOVAN ANKETAR
                Call popuniAutbDB(atbPK, strSQl)
            ElseIf actb.Name.Trim.ToUpper = "ATBPK" AndAlso atbPK.sselectedValue <> "" AndAlso atbPK.sselectedText <> "" Then
                If atbPK.sselectedText.Trim.ToUpper.IndexOf("NA DORADU") >= 0 Then
                    'Me.lblInformation.Visible = True
                    btnInformation.Visible = True
                    Dim strToolTip As String = "select NapomenaVracenIns from adresarsvikrugovi where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and idanketar='" + kosam + "'"
                    Dim dtToolTip As DataTable = izvrsiSQLvratiDT(strToolTip, DBConnectionString, jezik)
                    If Not dtToolTip Is Nothing AndAlso dtToolTip.Rows.Count > 0 Then
                        text1 = dtToolTip.Rows(0).Item(0).ToString.Trim
                        If text1.Length > 80 Then
                            text1 = splitText(text1)
                        End If
                        'Me.labelsToolTip.SetToolTip(Me.lblInformation, text)
                        'Me.labelsToolTip.AutoPopDelay = 5000
                        'Me.labelsToolTip.InitialDelay = 0
                        'Me.labelsToolTip.ReshowDelay = 0
                        'Me.labelsToolTip.ShowAlways = True
                        Me.labelsToolTip.SetToolTip(Me.btnInformation, text1)
                        'Me.labelsToolTip.Show(text, lblInformation, lblInformation.PointToClient(Cursor.Position), 30000)
                        'Me.labelsToolTip.Show(text, lblInformation, 60000)
                    Else
                        Me.labelsToolTip.SetToolTip(Me.btnInformation, "")
                        text1 = ""
                    End If

                Else
                    'Me.lblInformation.Visible = False
                    btnInformation.Visible = False
                End If
                Dim strSQlupit As String = dodatak + " select distinct  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " +
                                           " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "'" +
                                           " union" +
                                           " select '(*)' as displaymember, '000000000000' as valuemember order by displaymember"
                Call popuniAutbDB(atbUlica, strSQlupit)
            ElseIf actb.Name.Trim.ToUpper = "ATBPK" AndAlso (atbPK.sselectedValue = "" OrElse atbPK.sselectedText = "") Then
                Dim strSQlupit2 As String = dodatak + " select distinct  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " +
                                           " where 2=3"
                Call popuniAutbDB(atbUlica, strSQlupit2)
            End If
        End If


    End Sub
    Function splitText(ByVal str As String) As String


        Dim SplitStr As String = ""
        Dim SplitStr2 As String = str

        For i As Integer = 80 To Len(str)
            If Mid(SplitStr2, i, 1) = " " Then
                SplitStr = SplitStr + Mid(SplitStr2, 1, i) + vbCrLf
                SplitStr2 = Mid(SplitStr2, i + 1, Len(SplitStr2) - i)
                i = 80
                If i > Len(SplitStr2) Then
                    Exit For
                End If
            End If
        Next

        Return SplitStr + SplitStr2
    End Function

    'Private toolTipFlags As TextFormatFlags = TextFormatFlags.VerticalCenter Or TextFormatFlags.LeftAndRightPadding Or TextFormatFlags.HorizontalCenter Or TextFormatFlags.NoClipping
    'Private toolTipFont As Font = New Font("Arial", 12.0F, FontStyle.Bold)

    'Private Sub toolTip1_Popup(ByVal sender As Object, ByVal e As PopupEventArgs)
    '    Dim toolTipText As String = (TryCast(sender, ToolTip)).GetToolTip(e.AssociatedControl)

    '    Using g = e.AssociatedControl.CreateGraphics()
    '        Dim textSize = Size.Add(TextRenderer.MeasureText(g, toolTipText, toolTipFont, Size.Empty, toolTipFlags), New Size(100, 50))
    '        e.ToolTipSize = textSize
    '    End Using
    'End Sub

    'Private Sub toolTip1_Draw(ByVal sender As Object, ByVal e As DrawToolTipEventArgs)
    '    Call DrawToolTip(e)
    'End Sub

    'Private Sub DrawToolTip(ByVal e As DrawToolTipEventArgs)
    '    Using linearGradientBrush = New LinearGradientBrush(e.Bounds, Color.GreenYellow, Color.MintCream, 45.0F)
    '        e.Graphics.FillRectangle(linearGradientBrush, e.Bounds)
    '    End Using

    '    Dim shadowBounds = New Rectangle(New Point(e.Bounds.X + 1, e.Bounds.Y + 1), e.Bounds.Size)
    '    TextRenderer.DrawText(e.Graphics, e.ToolTipText, toolTipFont, shadowBounds, Color.LightGray, toolTipFlags)
    '    TextRenderer.DrawText(e.Graphics, e.ToolTipText, toolTipFont, e.Bounds, Color.Black, toolTipFlags)
    'End Sub

    Private Sub btnSort_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Dim nizACTB() As AutoCompleteTextbox
    Dim nizACTBime() As String
    Dim iACTB As Integer = -1
    Dim atbPK As AutoCompleteTextbox
    Dim atbUlica As AutoCompleteTextbox
    Dim atbOps As AutoCompleteTextbox
    Dim atbPromenaNazivaUlice As AutoCompleteTextbox
    Dim atbULKBR As AutoCompleteTextbox
    Sub nevid()
        DGV1.Visible = False
        ButtonUnosNovogKBR.Visible = False
        lblBrojKBR.Visible = False
        PanelNUl.Visible = False
    End Sub
    Dim StaraNovaUL As Integer = 0
    Dim dtOrig As DataTable
    Sub panelNapomenaLicaVisible(ByVal erowindex As Integer)
        Call disabledtabkontrolu()
        PanelNapomenaLica.BringToFront()

        Me.PanelNapomenaLica.Visible = True
        Call samoja(PanelNapomenaLica)

        'If DGV3.Rows(erowindex).Cells("RbrDom").Value.ToString.Trim = "0" Then
        '    PanelUklanjanje.Visible = True
        'Else
        '    PanelUklanjanje.Visible = True
        '    Dim strsql As String = "select count(*) from spisaklica where mbops='" + TxtMBOPSLica.Text + "' and krug_idcd='" + TxtKrugIDCDLica.Text + "' and kucni_broj_idcd='" + TxtKbrIDCDLica.Text + "' and rbrdom='" + TxtRbrDomNapomenaLica.Text + "' and rbrstan='" + TxtRbrStNapomenaLica.Text + "' and isnull(UklonitiLice,0)=0 and rbrp1<>1"
        '    Dim dt As DataTable = izvrsiSQLvratiDT(strsql, DBConnectionString, Me.jezik)
        '    If dt.Rows.Count > 0 Then
        '        If dt.Rows(0).Item(0) > 0 AndAlso TxtRBrLicaNapomenaLica.Text = "1" Then
        '            PanelUklanjanje.Visible = False
        '        Else
        '            PanelUklanjanje.Visible = True
        '        End If
        '    End If
        '    If DGV3.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV3.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
        '        PanelUklanjanje.Visible = False
        '    End If
        'End If
        TxtNapomenaLica.Focus()
    End Sub

    Sub panelNapomenaLicaNonVisible()
        Call enabledtabkontrolu()

        'Call PanelNapomenaLicaNonVisible()

        TxtNapomenaLica.Text = ""
        TxtUlicaKbrNapomenaLica.Text = ""
        TxtRbrStNapomenaLica.Text = ""
        TxtRbrStVrataNapomenaLica.Text = ""
        TxtRBrLicaNapomenaLica.Text = ""
        TxtImeNapomenaLica.Text = ""

        TxtKbrIDCDLica.Text = ""
        TxtKrugIDCDLica.Text = ""
        TxtMBOPSLica.Text = ""
        TxtIDULICELica.Text = ""

        Call nesamoja(PanelNapomenaLica)
        Me.PanelNapomenaLica.Visible = False

    End Sub

    Sub p3Visible()
        Call disabledtabkontrolu()
        Panel3.BringToFront()
        Me.Panel3.Visible = True
        Call samoja(Panel3)
        tboxkbr.Focus()
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

    Sub p3NonVisible()
        Call enabledtabkontrolu()
        Label12.Text = ""
        tboxkbr.Text = ""
        tbox1A.Text = ""
        tboxLatituda.Text = ""
        tboxLongituda.Text = ""
        tboxNapomenaOKucnomBroju.Text = ""

        Call nesamoja(Panel3)

        Me.Panel3.Visible = False
    End Sub

    Sub pZahVisible()
        Me.PanelZahtev.BringToFront()

        Me.PanelZahtev.Visible = True
        Call samoja(PanelZahtev)

        cbZahtev.Focus()
    End Sub
    Sub pZahNonVisible()

        Call nesamoja(PanelZahtev)
        Me.PanelZahtev.Visible = False

        Me.txtkucni_broj_idCDZahtev.Text = ""
        tboxNapomenaStatusAnketar.Text = ""
        cbZahtev.Checked = False
    End Sub
    Sub pNapomenaVisible()
        Me.PanelNapomenaStan.BringToFront()

        Me.PanelNapomenaStan.Visible = True
        Call samoja(PanelNapomenaStan)

        txtNapomenaStan.Focus()
        TabControl1.Enabled = False
    End Sub
    Sub pNapomenaNonVisible()

        Call nesamoja(PanelNapomenaStan)
        Me.PanelNapomenaStan.Visible = False

        TabControl1.Enabled = True
        'Me.PanelZahtev.SendToBack()
        Me.txtkucni_broj_idCDNapomena.Text = ""
        Me.txtkrug_idCDNapomena.Text = ""
        tboxNapomenaStatusAnketar.Text = ""
    End Sub
    Sub Promena2(ByVal selectedRow As Integer)
        DGV2.ClearSelection()
        DGV2.Rows(selectedRow).Selected = True

        Call pZakazivanjeStanaNonVisible()

        cbPonistiZak.Visible = False
        cbPonistiZak.Checked = False
        Dim si As Integer = DGV2.SelectedRows(0).Index
        nevena = True
        Call pZakazivanjeStanaVisible()
        PanelZakazivanjeStana.Tag = selectedRow
        p1.Enabled = False

        Dim IDULICA As String = DGV2.Rows(si).Cells(DGV2.Columns("IDulice").Index).Value.ToString

        txtUlica.Text = DGV2.Rows(si).Cells(DGV2.Columns("ulica").Index).Value.ToString + " " + DGV2.Rows(si).Cells(DGV2.Columns("kbroj").Index).Value.ToString
        txtKBroj.Text = DGV2.Rows(si).Cells(DGV2.Columns("kbroj").Index).Value.ToString
        txtRbrStan.Text = DGV2.Rows(si).Cells(DGV2.Columns("rbrstan").Index).Value.ToString
        txtBrojStanaVrata.Text = DGV2.Rows(si).Cells(DGV2.Columns("BrojStana").Index).Value.ToString
        dtpDatumDolaska.Text = DGV2.Rows(si).Cells(DGV2.Columns("DatumDolaska").Index).Value.ToString
        txtMBOPS.Text = DGV2.Rows(si).Cells(DGV2.Columns("mbops").Index).Value.ToString
        txtKrug.Text = DGV2.Rows(si).Cells(DGV2.Columns("krug_idcd").Index).Value.ToString
        txtIshodNapomena.Text = DGV2.Rows(si).Cells(DGV2.Columns("IshodNapomena").Index).Value.ToString
        txtkucni_broj_idCD.Text = DGV2.Rows(si).Cells(DGV2.Columns("kucni_broj_idCD").Index).Value.ToString
        txtKontaktOsoba.Text = DGV2.Rows(si).Cells(DGV2.Columns("KontaktOsoba").Index).Value.ToString
        txtBrojTelefona.Text = DGV2.Rows(si).Cells(DGV2.Columns("BrojTelefona").Index).Value.ToString
        txtUkupanBrLica.Text = DGV2.Rows(si).Cells(DGV2.Columns("ukupnolicastan").Index).Value.ToString

        If dtpDatumDolaska.Text.Trim = "" Then dtpDatumDolaska.Text = Date.Now.ToString("dd.MM.yyyy")


        'ishodi  'cb1-cb7
        Dim ishod As String = DGV2.Rows(si).Cells(DGV2.Columns("ishod").Index).Value.ToString
        Dim iishod As Integer = 0
        If IsNumeric(ishod) = True Then iishod = CInt(ishod)

        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
        rb4.Checked = False
        rb5.Checked = False
        rb6.Checked = False
        rb7.Checked = False

        If iishod = 1 Then rb1.Checked = True
        If iishod = 2 Then rb2.Checked = True
        If iishod = 3 Then rb3.Checked = True
        If iishod = 4 Then rb4.Checked = True
        If iishod = 5 Then rb5.Checked = True
        If iishod = 6 Then rb6.Checked = True
        If iishod = 7 Then rb7.Checked = True

        p2.Enabled = True

        dtpZakazanoDatum.Text = ""
        If Not DGV2.Rows(si).Cells(DGV2.Columns("ZakazanoDatum").Index).Value Is System.DBNull.Value AndAlso
                            DGV2.Rows(si).Cells(DGV2.Columns("ZakazanoDatum").Index).Value.ToString <> "" Then
            dtpZakazanoDatum.Text = DGV2.Rows(si).Cells(DGV2.Columns("ZakazanoDatum").Index).Value.ToString
        End If

        dtpZakazanoVreme.Text = ""
        If Not DGV2.Rows(si).Cells(DGV2.Columns("Zakazanovreme").Index).Value Is System.DBNull.Value AndAlso
                            DGV2.Rows(si).Cells(DGV2.Columns("Zakazanovreme").Index).Value.ToString <> "" Then
            dtpZakazanoVreme.Text = DGV2.Rows(si).Cells(DGV2.Columns("ZakazanoVreme").Index).Value.ToString
        End If



        Dim cati_nacin As String = DGV2.Rows(si).Cells(DGV2.Columns("cati_nacin").Index).Value.ToString
        Dim icati_nacin As String = ""
        If IsNumeric(cati_nacin) = True Then icati_nacin = cati_nacin.Trim
        cbTelefon.Checked = False
        cbDolazak.Checked = False
        If icati_nacin = "1" Then cbTelefon.Checked = True
        If icati_nacin = "2" Then cbDolazak.Checked = True


        Dim stan As String = DGV2.Rows(si).Cells(DGV2.Columns("rbrstan").Index).Value.ToString
        Dim krug As String = DGV2.Rows(si).Cells(DGV2.Columns("krug_idcd").Index).Value.ToString
        tboxSource.Enabled = False
        tboxSource.Text = DGV2.Rows(si).Cells(DGV2.Columns("sourceof_INSERT").Index).Value.ToString

        dtpZakazanoDatum.Text = dtpZakazanoDatum.Text.Trim

        dtpDatumDolaska.Text = dtpDatumDolaska.Text.Trim

        txtBrojTelefona.Text = txtBrojTelefona.Text.Trim

        dtpZakazanoVreme.Text = dtpZakazanoVreme.Text.Trim

        Dim strproveraBrStana = "select * from p2_stan where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + krug + "'" + nvrd +
            " and kucni_broj_idCD='" + txtkucni_broj_idCD.Text.Trim + "' and rbrstan='" + stan + "' and isnull(brojstana,'')<>''"
        Dim dtprovera As DataTable = izvrsiSQLvratiDT(strproveraBrStana, DBConnectionString, Me.jezik)
        If dtprovera.Rows.Count > 0 Then
            txtBrojStanaVrata.Enabled = False
            GroupBox1.Focus()
        Else
            txtBrojStanaVrata.Enabled = True
            txtBrojStanaVrata.Focus()
        End If

        If (txtBrojStanaVrata.Enabled = True AndAlso txtBrojStanaVrata.Text.Trim <> "") OrElse rb1.Checked = True OrElse rb2.Checked = True OrElse rb3.Checked = True OrElse rb4.Checked = True OrElse rb5.Checked = True OrElse rb6.Checked = True OrElse rb7.Checked = True Then
            cbPonistiZak.Visible = True
        Else
            cbPonistiZak.Visible = False
        End If



        nevena = False
    End Sub



    Private Sub Rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        If rb1.Checked = True Then

            Dim str As String = "select * from p2_stan s  inner join adresar a on a.mbops=s.mbops and a.krug_idcd=s.krug_idcd and a.kucni_broj_idcd=s.kucni_broj_idcd and a.rbrstan=s.rbrstan " + nvrd +
                                " where a.idanketar=N'" + kosam + "' and s.mbops='" + txtMBOPS.Text.Trim + "' and s.krug_idcd='" + txtKrug.Text.Trim + "' " + nvrd +
                                " and s.kucni_broj_idcd='" + txtkucni_broj_idCD.Text.Trim + "' and s.rbrstan=" + txtRbrStan.Text.Trim + " and isnull(QC,0)=0"
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Započeli ste popisivanje ovog stana. Dozvoljen ishod je 4, 5, ili 6.")
                rb1.Checked = False
                Exit Sub
            End If

            Me.cbTelefon.Checked = False
            Me.cbDolazak.Checked = False
            p2.Visible = False
            dtpZakazanoDatum.Text = ""
            dtpZakazanoVreme.Text = ""
            txtUkupanBrLica.Text = ""
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
            Dim str As String = "select * from p2_stan s  inner join adresar a on a.mbops=s.mbops and a.krug_idcd=s.krug_idcd and a.kucni_broj_idcd=s.kucni_broj_idcd and a.rbrstan=s.rbrstan " + nvrd +
                                " where a.idanketar=N'" + kosam + "' and s.mbops='" + txtMBOPS.Text.Trim + "' and s.krug_idcd='" + txtKrug.Text.Trim + "' " + nvrd +
                                " and s.kucni_broj_idcd='" + txtkucni_broj_idCD.Text.Trim + "' and s.rbrstan=" + txtRbrStan.Text.Trim + " and isnull(QC,0)=0"
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Započeli ste popisivanje ovog stana. Dozvoljen ishod je 4, 5, ili 6.")
                rb2.Checked = False
                Exit Sub
            End If
            Me.cbDolazak.Checked = True
            Me.cbTelefon.Checked = False
            Me.cbTelefon.Enabled = False
            Me.cbDolazak.Enabled = False
            p2.Visible = True
            dtpZakazanoDatum.Focus()
        End If
    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged
        If rb3.Checked = True Then
            Dim str As String = "select * from p2_stan s  inner join adresar a on a.mbops=s.mbops and a.krug_idcd=s.krug_idcd and a.kucni_broj_idcd=s.kucni_broj_idcd and a.rbrstan=s.rbrstan " + nvrd +
                                " where a.idanketar=N'" + kosam + "' and s.mbops='" + txtMBOPS.Text.Trim + "' and s.krug_idcd='" + txtKrug.Text.Trim + "' " + nvrd +
                                " and s.kucni_broj_idcd='" + txtkucni_broj_idCD.Text.Trim + "' and s.rbrstan=" + txtRbrStan.Text.Trim + " and isnull(QC,0)=0"
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Započeli ste popisivanje ovog stana. Dozvoljen ishod je 4, 5, ili 6.")
                rb3.Checked = False
                Exit Sub
            End If
            Me.cbTelefon.Checked = True
            Me.cbDolazak.Checked = False
            Me.cbTelefon.Enabled = False
            Me.cbDolazak.Enabled = False
            p2.Visible = True
            Me.cbTelefon.Checked = True
            Me.cbDolazak.Checked = False
            Me.dtpZakazanoDatum.Focus()
            Me.cbTelefon.Enabled = False
            Me.cbDolazak.Enabled = False
        End If
    End Sub
    Private Sub rb4_CheckedChanged(sender As Object, e As EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked = True Then
            Me.cbDolazak.Checked = True
            Me.cbTelefon.Checked = False
            Me.cbTelefon.Enabled = False
            Me.cbDolazak.Enabled = False
            p2.Visible = True
            Me.cbTelefon.Checked = False
            Me.dtpZakazanoDatum.Focus()
            Me.cbDolazak.Checked = True
            Me.cbTelefon.Enabled = False
            Me.cbDolazak.Enabled = False
        End If
    End Sub
    Private Sub rb5_CheckedChanged(sender As Object, e As EventArgs) Handles rb5.CheckedChanged
        If rb5.Checked = True Then
            Me.cbTelefon.Checked = True
            Me.cbDolazak.Checked = False
            Me.cbTelefon.Enabled = False
            Me.cbDolazak.Enabled = False
            p2.Visible = True
            dtpZakazanoDatum.Focus()
        End If
    End Sub
    Private Sub rb6_CheckedChanged(sender As Object, e As EventArgs) Handles rb6.CheckedChanged

        If rb6.Checked = True Then
            Me.cbTelefon.Checked = False
            Me.cbDolazak.Checked = False
            p2.Visible = False
            dtpZakazanoDatum.Text = ""
            dtpZakazanoVreme.Text = ""
            txtUkupanBrLica.Text = ""
            txtKontaktOsoba.Text = ""
            txtBrojTelefona.Text = ""
            txtIshodNapomena.Focus()
            txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
            txtIshodNapomena.SelectionLength = 0
        End If
    End Sub
    Private Sub rb7_CheckedChanged(sender As Object, e As EventArgs) Handles rb7.CheckedChanged

        If rb7.Checked = True Then
            Dim str As String = "select * from p2_stan s  inner join adresar a on a.mbops=s.mbops and a.krug_idcd=s.krug_idcd and a.kucni_broj_idcd=s.kucni_broj_idcd and a.rbrstan=s.rbrstan " + nvrd +
                                " where a.idanketar=N'" + kosam + "' and s.mbops='" + txtMBOPS.Text.Trim + "' and s.krug_idcd='" + txtKrug.Text.Trim + "' " + nvrd +
                                " and s.kucni_broj_idcd='" + txtkucni_broj_idCD.Text.Trim + "' and s.rbrstan=" + txtRbrStan.Text.Trim + " and isnull(QC,0)=0"
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Započeli ste popisivanje ovog stana. Dozvoljen ishod je 4, 5, ili 6.")
                rb7.Checked = False
                Exit Sub
            End If
            Me.cbTelefon.Checked = False
            Me.cbDolazak.Checked = False
            p2.Visible = False
            dtpZakazanoDatum.Text = ""
            dtpZakazanoVreme.Text = ""
            txtUkupanBrLica.Text = ""
            txtKontaktOsoba.Text = ""
            txtBrojTelefona.Text = ""
            txtIshodNapomena.Focus()
            txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
            txtIshodNapomena.SelectionLength = 0
        End If
    End Sub

    Private Sub ButtonSave2_Click(sender As Object, e As EventArgs) Handles ButtonSave2.Click

        Dim ok As Boolean = True
        Dim ch1 As Integer = 0
        Dim pomrowDGV1 As Integer = vratiSelektvanRedDGV1(PanelZakazivanjeStana.Tag)
        Dim si As Integer = DGV2.SelectedRows(0).Index
        Dim krug As String = DGV2.Rows(si).Cells(DGV2.Columns("krug_idcd").Index).Value.ToString.Trim
        Dim ops As String = DGV2.Rows(si).Cells(DGV2.Columns("mbops").Index).Value.ToString.Trim

        If cbPonistiZak.Checked = True Then
            Dim msgtxt As String = "Da li ste sigurni da želite da obrišete zakazivanje stana?"
            ''videti šta ako postoje podaci!!!!! NISTA, NIJE DOZVOLJENO
            Dim msgtitle As String = "............"

            Dim opc As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle)
            Select Case opc
                Case "Yes"
                    Dim opc2 As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle, 2)
                    Select Case opc2
                        Case "Yes"

                            Dim strSQLponisti As String = " update adresar " + vbCrLf +
                                   " set ishod=null, IshodNapomena=''," +
                                   " date_update=getdate(), user_update=N'" + kosam + "', " + vbCrLf +
                                   " brojStanaVrata = '', " + vbCrLf +
                                   " zakazanovreme='', " + vbCrLf +
                                   " zakazanoDatum='', " + vbCrLf +
                                   " kontaktosoba='', " + vbCrLf +
                                   " BrojTelefona='', " + vbCrLf +
                                   " DatumDolaska='', " + vbCrLf +
                                   " UkupnoLicaStan=NULL, " + vbCrLf +
                                   " cati_nacin=Null " + vbCrLf +
                                   " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCD.Text + "' and rbrstan='" + Me.txtRbrStan.Text.Trim + "' and krug_idcd='" + krug + "' and mbops='" + ops + "'"


                            Dim ok2 As String = izvrsiSQL(strSQLponisti, Me.DBConnectionString)
                            If ok2 = "ok" Then
                                ISTMessageBox.Show("Obrisano!")
                                '20220715 Call refreshDGV1()
                                Dim pomocnaNapomenaKBR2 As String = ""
                                Dim pomocnaUlicaMapa2 As String = ""
                                Dim pomocnaUlica2 As String = ""
                                Dim pomocna2 As String = ""
                                If Not filterNapomenaKBR Is Nothing Then
                                    pomocnaNapomenaKBR2 = filterNapomenaKBR.Text
                                End If
                                If Not filterUlicaMapa Is Nothing Then
                                    pomocnaUlicaMapa2 = filterUlicaMapa.Text
                                End If
                                If Not filterUlica Is Nothing Then
                                    pomocnaUlica2 = filterUlica.Text
                                End If
                                If Not filterStatus Is Nothing Then
                                    pomocna2 = filterStatus.Text
                                    If pomocna2.Length > 0 AndAlso pomocna2 <> "" Then pomocna2 = pomocna2.Substring(0, 1)
                                    If pomocna2 = "*" Then pomocna2 = ""
                                End If
                                refreshDGV1(pomocnaUlica2, pomocna2, pomocnaUlicaMapa2, pomocnaNapomenaKBR2)

                                If DGV1.Rows.Count > 0 Then
                                    DGV1.ClearSelection()
                                    'DGV1.Rows(pomrowDGV1).Selected = True
                                    If DGV1.Rows.Count - 1 >= pomrowDGV1 Then
                                        DGV1.Rows(pomrowDGV1).Selected = True
                                    Else
                                        DGV1.Rows(0).Selected = True
                                    End If

                                End If

                                If filterDatumZakazan.Tag = "svi" Then
                                    refreshdgv2zakazni()
                                    Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' order by ZakazanoDatum", Me.DBConnectionString, False, False, False, True)
                                    If DGV2.Rows.Count > 0 Then
                                        DGV2.ClearSelection()
                                        DGV2.Rows(0).Selected = True
                                    Else
                                        ISTMessageBox.Show("Nemate zakazanih stanova.")

                                        If ButtonNastavi.Enabled = True OrElse BtnSvaLica.Tag <> "" Then

                                        ElseIf ButtonNastavi.Enabled = False AndAlso (atbOps.Text = "" OrElse atbPK.Text = "" OrElse atbUlica.Text = "") Then
                                            ButtonZakazani.Tag = "dosao"
                                            ButtonZakazani.Text = "Svi zakazani stanovi"
                                            TabPage2.Text = "Unos/izmena podataka o stanu i ishoda poseta"
                                            filterDatumZakazan.Tag = ""
                                            Call Reset()
                                            If atbOps.Text = "" Then
                                                atbOps.Focus()
                                            Else
                                                atbPK.Focus()
                                            End If
                                            ButtonZakazani.BackColor = System.Drawing.SystemColors.Control
                                        ElseIf ButtonNastavi.Enabled = False AndAlso atbOps.Text <> "" AndAlso atbPK.Text <> "" AndAlso atbUlica.Text <> "" Then
                                            If ButtonZakazani.Text = "Svi zakazani stanovi" Then

                                            Else
                                                filterDatumZakazan.Tag = ""
                                                TabControl1.TabPages.Remove(TabPage2)
                                                TabPage2.Text = "Unos/izmena podataka o stanu i ishoda poseta"
                                                ButtonZakazani.Text = "Svi zakazani stanovi"
                                                TabControl1.TabPages.Add(TabPage1)
                                                TabControl1.TabPages.Add(TabPage2)
                                                TabControl1.TabPages.Add(TabPage3)
                                                TabControl1.SelectedTab = TabPage1
                                                TabPage1.Visible = True
                                                DGV1.Visible = True
                                                'DGV2.DataSource = Nothing
                                                'refreshDGV2(-1)
                                                Call praznidgv2()
                                                TabControl1.SelectedIndex = 0
                                                promenaTaba()
                                                'PanelLegendaDGV1.Visible = True
                                                'refreshDGV1()
                                                ButtonZakazani.BackColor = System.Drawing.SystemColors.Control
                                                DGV1.Focus()
                                            End If
                                        End If
                                    End If

                                Else

                                    Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' and " +
                                                          "mbops='" + atbOps.sselectedValue + "'" +
                                                          " and Krug_idcd='" + atbPK.sselectedValue + "'" +
                                                          " and kucni_broj_idCD='" + DGV1.Rows(pomrowDGV1).Cells(DGV1.Columns("kucni_broj_idCD").Index).Value.ToString + "'" +
                                                          " order by ZakazanoDatum", Me.DBConnectionString, False, False, True, True)
                                    Call refreshDGV2(pomrowDGV1)
                                    If DGV2.Rows.Count > 0 Then
                                        DGV2.ClearSelection()
                                        'DGV2.Rows(PanelZakazivanjeStana.Tag).Selected = True
                                        If DGV2.Rows.Count - 1 >= PanelZakazivanjeStana.Tag Then
                                            DGV2.Rows(PanelZakazivanjeStana.Tag).Selected = True
                                        Else
                                            DGV2.Rows(0).Selected = True
                                        End If

                                    End If
                                End If


                                cbPonistiZak.Checked = False
                                Call pZakazivanjeStanaNonVisible()
                            Else
                                ISTMessageBox.Show("Greška 10! Zovite administratora!")
                                Me.Close()
                                Exit Sub
                            End If

                        Case "No"
                    End Select
                Case "No"
            End Select
            Exit Sub
        End If

        If dtpZakazanoDatum.Text.Trim <> "" AndAlso dtpZakazanoVreme.Text.Trim <> "" Then
            Dim str As String = "select * from adresar where idanketar=N'" + kosam + "' and  " + nvrd +
                                "( (select count(*) from adresar where idanketar=N'" + kosam + "' and ZakazanoDatum='" + dtpZakazanoDatum.Text + "' and ZakazanoVreme='" + dtpZakazanoVreme.Text + "' ) - " + nvrd +
                                "  (select count(*) from adresar where idanketar=N'" + kosam + "' and ZakazanoDatum='" + dtpZakazanoDatum.Text + "' and ZakazanoVreme='" + dtpZakazanoVreme.Text + "' and mbops='" + txtMBOPS.Text.Trim + "' and krug_idcd='" + txtKrug.Text.Trim + "' and kucni_broj_idcd='" + txtkucni_broj_idCD.Text.Trim + "' and rbrstan='" + txtRbrStan.Text.Trim + "' ) )>0"
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)

            If dt.Rows.Count > 0 Then
                ISTMessageBox.Show("Za ovaj datum i vreme već imate zakazan stan, morate promeniti ili datum ili vreme.")
                dtpZakazanoDatum.Focus()
                Exit Sub
            End If
        End If

        If txtUkupanBrLica.Text.Trim <> "" Then
            Dim str As String = "select UBrLicaStan from p2_stan s  inner join adresar a on a.mbops=s.mbops and a.krug_idcd=s.krug_idcd and a.kucni_broj_idcd=s.kucni_broj_idcd and a.rbrstan=s.rbrstan " + nvrd +
                                " where a.idanketar=N'" + kosam + "' and s.mbops='" + txtMBOPS.Text.Trim + "' and s.krug_idcd='" + txtKrug.Text.Trim + "' " + nvrd +
                                " and s.kucni_broj_idcd='" + txtkucni_broj_idCD.Text.Trim + "' and s.rbrstan=" + txtRbrStan.Text.Trim + ""
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)

            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item(0).ToString.Trim <> txtUkupanBrLica.Text.Trim Then
                    ISTMessageBox.Show("Ukupan broj lica u stanu koji ste uneli u upitniku za stan se ne slaže sa 'Ukupnim/očekivanim brojem lica u stanu'")
                    txtUkupanBrLica.Focus()
                    Exit Sub
                End If
            End If
        End If




        If txtBrojStanaVrata.Enabled = True AndAlso txtBrojStanaVrata.Text.Trim = "" AndAlso DGV2.Rows.Count > 1 Then
            ISTMessageBox.Show("Morate uneti broj stana na vratima!")
            txtBrojStanaVrata.Focus()
            Exit Sub
        End If

        If rb1.Checked = False AndAlso rb2.Checked = False AndAlso rb3.Checked = False AndAlso rb4.Checked = False AndAlso rb5.Checked = False AndAlso rb6.Checked = False AndAlso rb7.Checked = False Then
            ISTMessageBox.Show("Morate označiti ishod posete!")
            Exit Sub
        End If

        If (rb2.Checked = True OrElse rb3.Checked = True OrElse rb4.Checked = True OrElse rb5.Checked = True) Then
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

        If (rb3.Checked = True OrElse rb5.Checked = True) Then
            If txtKontaktOsoba.Text.Trim = "" OrElse txtKontaktOsoba.Text.Length < 2 Then
                ISTMessageBox.Show("Morate uneti kontakt osobu, duzine bar 2.")
                txtKontaktOsoba.Focus()
                Exit Sub
            ElseIf txtBrojTelefona.Text.Trim = "" OrElse txtBrojTelefona.Text.Length < 5 Then
                ISTMessageBox.Show("Morate uneti ispravan broj telefona.")
                txtBrojTelefona.Focus()
                Exit Sub
            End If
        End If

        If (rb2.Checked = True OrElse rb3.Checked = True OrElse rb4.Checked = True OrElse rb5.Checked = True) Then
            If txtUkupanBrLica.Text.Trim = "" Then
                ISTMessageBox.Show("Morate uneti vrednost u polju 'Ukupan/očekivan broj lica u stanu!'")
                txtUkupanBrLica.Focus()
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
        If rb3.Checked = True Then iishod = 3
        If rb4.Checked = True Then iishod = 4
        If rb5.Checked = True Then iishod = 5
        If rb6.Checked = True Then iishod = 6
        If rb7.Checked = True Then iishod = 7

        Dim strSQL As String = " update adresar " + vbCrLf +
                                   " set ishod='" + CStr(iishod).Trim + "', IshodNapomena=N'" + Me.txtIshodNapomena.Text.Trim + "'," +
                                   " date_update=getdate(), user_update=N'" + kosam + "'"

        Dim rbrstananavratima As String = ""
        If txtBrojStanaVrata.Text.Trim <> "" Then
            rbrstananavratima = txtBrojStanaVrata.Text.Trim
            strSQL = strSQL + ", brojStanaVrata=N'" + rbrstananavratima + "'"
        End If

        strSQL = strSQL + ", zakazanovreme=N'" + dtpZakazanoVreme.Text + "'"
        strSQL = strSQL + ", zakazanoDatum=N'" + dtpZakazanoDatum.Text + "'"
        strSQL = strSQL + ", kontaktosoba=N'" + txtKontaktOsoba.Text + "'"
        strSQL = strSQL + ", BrojTelefona=N'" + txtBrojTelefona.Text + "'"
        strSQL = strSQL + ", DatumDolaska=N'" + dtpDatumDolaska.Text + "'"
        If txtUkupanBrLica.Text.Trim = "" Then
            strSQL = strSQL + ", UkupnoLicaStan=NULL"
        Else
            strSQL = strSQL + ", UkupnoLicaStan=N'" + txtUkupanBrLica.Text.Trim + "'"
        End If

        Dim cati_nacin As String = ""
        If cbTelefon.Checked = True Then cati_nacin = "1"
        If cbDolazak.Checked = True Then cati_nacin = "2"
        If cati_nacin <> "" Then
            strSQL = strSQL + ", cati_nacin='" + cati_nacin.Trim + "'"
        Else
            strSQL = strSQL + ", cati_nacin=Null"
        End If

        'strSQL = strSQL + ", date_update='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', user_update='ANK'"

        strSQL = strSQL + vbCrLf +
                    " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCD.Text + "' and rbrstan='" + Me.txtRbrStan.Text.Trim + "' and krug_idcd='" + krug + "' and mbops='" + ops + "'"

        Dim ok3 As String = izvrsiSQL(strSQL, Me.DBConnectionString)
        If ok3 <> "ok" Then
            ISTMessageBox.Show("Greška 11! Zovite administratora!")
            Me.Close()
            Exit Sub
        End If

        If filterDatumZakazan.Tag = "svi" Then
            Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' order by ZakazanoDatum", Me.DBConnectionString, False, False, False, True)
        Else
            Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' and " +
                                                          "mbops='" + atbOps.sselectedValue + "'" +
                                                          " and Krug_idcd='" + atbPK.sselectedValue + "'" +
                                                          " and kucni_broj_idCD='" + DGV1.Rows(pomrowDGV1).Cells(DGV1.Columns("kucni_broj_idCD").Index).Value.ToString + "'" +
                                                          " order by ZakazanoDatum", Me.DBConnectionString, False, False, True, True)
        End If

        '20220715 Call refreshDGV1()
        Dim pomocnaNapomenaKBR As String = ""
        Dim pomocnaUlicaMapa As String = ""
        Dim pomocnaUlica As String = ""
        Dim pomocna As String = ""
        If Not filterNapomenaKBR Is Nothing Then
            pomocnaNapomenaKBR = filterNapomenaKBR.Text
        End If
        If Not filterUlicaMapa Is Nothing Then
            pomocnaUlicaMapa = filterUlicaMapa.Text
        End If
        If Not filterUlica Is Nothing Then
            pomocnaUlica = filterUlica.Text
        End If
        If Not filterStatus Is Nothing Then
            pomocna = filterStatus.Text
            If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
            If pomocna = "*" Then pomocna = ""
        End If
        refreshDGV1(pomocnaUlica, pomocna, pomocnaUlicaMapa, pomocnaNapomenaKBR)

        If DGV1.Rows.Count > 0 Then
            DGV1.ClearSelection()
            'DGV1.Rows(pomrowDGV1).Selected = True
            If DGV1.Rows.Count - 1 >= pomrowDGV1 Then
                DGV1.Rows(pomrowDGV1).Selected = True
            Else
                DGV1.Rows(0).Selected = True
            End If

        End If

        If filterDatumZakazan.Tag = "svi" Then
            refreshdgv2zakazni()
        Else
            Call refreshDGV2(pomrowDGV1)
        End If

        If DGV2.Rows.Count > 0 Then
            DGV2.ClearSelection()
            'DGV2.Rows(PanelZakazivanjeStana.Tag).Selected = True
            If DGV2.Rows.Count - 1 >= PanelZakazivanjeStana.Tag Then
                DGV2.Rows(PanelZakazivanjeStana.Tag).Selected = True
            Else
                DGV2.Rows(0).Selected = True
            End If

        End If

        Call pZakazivanjeStanaNonVisible()

    End Sub


    Sub pZakazivanjeStanaVisible()
        txtUlica.Text = ""
        txtKBroj.Text = ""
        txtRbrStan.Text = ""
        dtpDatumDolaska.Text = ""
        txtBrojStanaVrata.Text = ""
        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
        rb4.Checked = False
        rb5.Checked = False
        rb6.Checked = False
        rb7.Checked = False
        dtpZakazanoDatum.Text = ""
        dtpZakazanoVreme.Text = ""
        txtKontaktOsoba.Text = ""
        txtBrojTelefona.Text = ""
        cbTelefon.Checked = False
        cbDolazak.Checked = False
        txtIshodNapomena.Text = ""
        tboxSource.Text = ""
        txtKrug.Text = ""
        txtKrug.Text = ""
        Me.PanelZakazivanjeStana.BringToFront()
        Me.PanelZakazivanjeStana.Visible = True
        Call samoja(PanelZakazivanjeStana)
        txtBrojStanaVrata.Focus()
    End Sub
    Sub pZakazivanjeStanaNonVisible()

        Call nesamoja(PanelZakazivanjeStana)
        Me.PanelZakazivanjeStana.Visible = False

        'Me.PanelZakazivanjeStana.SendToBack()
        txtUlica.Text = ""
        txtKBroj.Text = ""
        txtRbrStan.Text = ""
        txtBrojStanaVrata.Text = ""
        'ishodi  'cb1-cb7
        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
        rb4.Checked = False
        rb5.Checked = False
        rb6.Checked = False
        rb7.Checked = False
        p2.Visible = False
        dtpZakazanoDatum.Text = ""
        dtpZakazanoVreme.Text = ""
        txtKontaktOsoba.Text = ""
        txtBrojTelefona.Text = ""
        cbTelefon.Checked = False
        cbDolazak.Checked = False
        txtIshodNapomena.Text = ""
        tboxSource.Text = ""
        txtKrug.Text = ""
        txtMBOPS.Text = ""
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonDodajAdr.Click
        Me.Cursor = Cursors.WaitCursor



        Dim novinazivul As String = ""

        Dim strProvera As String = dodatak + "select * from Adresar a " + vbCrLf +
                " where IDANKETAR=N'" + kosam + "' and a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and ltrim(rtrim( trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash)))))))=N'" + tboxNovaUlica.Text.Trim + "' "
        Dim dtProvera As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Nothing)
        If dtProvera.Rows.Count > 0 Then
            ISTMessageBox.Show("Ne možete uneti već postojeću ulicu!")
            tboxNovaUlica.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf tboxNovaUlica.Text.Trim = "" Then
            ISTMessageBox.Show("Obavezan naziv ulice")
            tboxNovaUlica.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf Me.tboxKucniBR.Text.Trim = "" Then
            ISTMessageBox.Show("Obavezan kućni broj")
            tboxKucniBR.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf CDbl(Val(Me.MinLongituda.Text.Trim)) > CDbl(Val(Me.TextBoxLong.Text.Trim)) OrElse CDbl(Val(Me.MaxLongituda.Text.Trim)) < CDbl(Val(Me.TextBoxLong.Text.Trim)) Then
            ISTMessageBox.Show("Neispravna longituda")
            ButtonNeDodajAdr.Focus()
            Exit Sub
        ElseIf Me.TextBoxLong.Text.Trim = "" Then
            ISTMessageBox.Show("Obavezna longituda")
            ButtonNeDodajAdr.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf Me.TextBoxLat.Text.Trim = "" Then
            ISTMessageBox.Show("Obavezna latituda")
            ButtonNeDodajAdr.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf CDbl(Val(Me.MaxLatituda.Text.Trim)) < CDbl(Val(Me.TextBoxLat.Text.Trim)) OrElse CDbl(Val(Me.MinLatituda.Text.Trim)) > CDbl(Val(Me.TextBoxLat.Text.Trim)) Then
            ISTMessageBox.Show("Neispravna latituda")
            ButtonNeDodajAdr.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf CDbl(Val(Me.TextBoxLong.Text.Trim)) > CDbl(Val(Me.TextBoxLat.Text.Trim)) Then
            ISTMessageBox.Show("Proverite unos za longitudu i latitudu")
            ButtonNeDodajAdr.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf Me.tboxKucniBR.Text.IndexOf(".") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf(",") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf(":") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf("'") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf(")") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf("(") >= 0 Then
            ISTMessageBox.Show("Nedozvoljena vrednost pri unosu kućnog broja : , . ' ) (")
            tboxKucniBR.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Call nesamoja(PanelNUl)
        PanelNUl.Visible = False

        novinazivul = tboxNovaUlica.Text

        Dim kucni_broj As String = ""
        Dim idulice As String = ""

        Dim strsql As String = "select max(cast(idulice As bigint)) from Adresar " + vbCrLf +
            " where IDANKETAR=N'" + kosam + "' and sourceof_insert='ANK' and substring(idulice,1,8)=substring('" + fiktivnianketar + "',2,8) " 'and mbops='" + atbOps.sselectedValue + "' " 'and krug_idcd='" + atbPK.sselectedValue + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(strsql, Me.DBConnectionString, Nothing)

        Dim strsql2 As String = " select max(cast(left(kucni_broj_idcd,12) as bigint)) " + nvrd +
                                " from ( " + nvrd +
                                " select cast(left(kucni_broj_idcd,12) as bigint) as kucni_broj_idcd from Adresar   " + nvrd +
                                " where IDANKETAR=N'" + kosam + "' and sourceof_insert='ANK' and substring(kucni_broj_idcd,1,8)=substring('" + fiktivnianketar + "',2,8)  " + nvrd +
                                " union all " + nvrd +
                                " select cast(left(kucni_broj_idcd,12) as bigint) as kucni_broj_idcd from adresarzaizvestaje  where  substring(kucni_broj_idcd,1,8)=substring('" + fiktivnianketar + "',2,8) ) a "

        '"select max(cast(left(kucni_broj_idcd,12) as bigint)) from Adresar b " + vbCrLf +
        '    " where IDANKETAR=N'" + kosam + "' and sourceof_insert='ANK' and substring(kucni_broj_idcd,1,8)=substring('" + fiktivnianketar + "',2,8) " + nvrd + 'and mbops='" + atbOps.sselectedValue + "' " 'and krug_idcd='" + atbPK.sselectedValue + "'"
        '    " and not exists (select * from adresarzaizvestaje a where a.mbops=b.mbops and a.krug_idcd=b.krug_idcd and a.kucni_broj_idcd=b.kucni_broj_idcd ) "
        Dim dt2 As DataTable = izvrsiSQLvratiDT(strsql2, Me.DBConnectionString, Nothing)

        If dt.Rows.Count > 0 AndAlso Not (dt.Rows(0).Item(0) Is Nothing) AndAlso (Not (dt.Rows(0).Item(0).GetType Is GetType(System.DBNull))) Then
            idulice = (dt.Rows(0).Item(0) + 1).ToString
        Else
            idulice = (Mid(fiktivnianketar, 2, 8).ToString + "0000")
        End If

        If dt2.Rows.Count > 0 AndAlso Not (dt2.Rows(0).Item(0) Is Nothing) AndAlso (Not (dt2.Rows(0).Item(0).GetType Is GetType(System.DBNull))) Then
            kucni_broj = (dt2.Rows(0).Item(0) + 1).ToString
        Else
            kucni_broj = (Mid(fiktivnianketar, 2, 8).ToString + Mid("0000", 1, 4).ToString)
        End If
        'substring(suser_sname(),1,10),

        Dim strsql3 As String = dodatak + "insert into Adresar (MBOPS,Krug_idcd," + vbCrLf + '"insert into Adresar (MBOPS,Krug_idcd,Krug,kucni_broj," + vbCrLf +
       " kucni_broj_idCD, RbrStan, RbrUKrugu, KrugDeo, kucni_broj_Deo, IDAnketar, MBNAS, NazivOpstine," + vbCrLf +
       " NazivNaselja,IDUlice,ulica,KBroj,Latituda,Longituda,SK,PkuSk," + vbCrLf +
       " ulicaKBroj,sourceof_INSERT,user_INSERT,date_INSERT)" + vbCrLf +
       " select Top 1 MBOPS,Krug_idcd,'" + kucni_broj.Trim + "01' ,1,1,'01','01',N'" + fiktivnianketar + "'," + vbCrLf +
       " MBNAS,NazivOpstine,NazivNaselja,'" + idulice + "',trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + novinazivul.Trim + "', 1, CONVERT(varbinary, @Hash)) ), 1))," +
       " trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + tboxKucniBR.Text.Trim + "', 1, CONVERT(varbinary, @Hash)) ), 1)), " + nvrd +
       " " + TextBoxLat.Text.Trim + "," + TextBoxLong.Text.Trim + ",SK,PkuSk," + vbCrLf +
       " trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + novinazivul.Trim + " " + tboxKucniBR.Text.Trim + "', 1, CONVERT(varbinary, @Hash)) ), 1)), " + nvrd +
       " 'ANK',N'" + kosam + "', getdate() " + vbCrLf +
       " from AdresarSviKrugovi where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue.Trim + "'"
        tboxIDULICE.Text = idulice

        Dim ok As String = izvrsiSQL(strsql3, Me.DBConnectionString)
        If ok <> "ok" Then
            ISTMessageBox.Show("Greška 12! Zovite administratora!")
            Me.Close()
            Exit Sub
        End If

        Dim strSQlupit As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " +
                                   " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "'" +
                                   " union" +
                                   " select '(*)' as displaymember, '000000000000' as valuemember order by displaymember"
        Call popuniAutbDB(atbUlica, strSQlupit)
        atbUlica.sselectedValue = ""
        atbUlica.sselectedText = ""
        atbUlica.Text = ""

        'atbUlica.sselectedValue = ""
        'atbUlica.sselectedText = ""
        'atbUlica.Text = ""
        'atbUlica.Focus()

        Call enableIzborZaGrid()
        atbUlica.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    Sub postojiUlica()
        '20220715 Call refreshDGV1()
        Dim pomocnaNapomenaKBR As String = ""
        Dim pomocnaUlicaMapa As String = ""
        Dim pomocnaUlica As String = ""
        Dim pomocna As String = ""
        If Not filterNapomenaKBR Is Nothing Then
            pomocnaNapomenaKBR = filterNapomenaKBR.Text
        End If
        If Not filterUlicaMapa Is Nothing Then
            pomocnaUlicaMapa = filterUlicaMapa.Text
        End If
        If Not filterUlica Is Nothing Then
            pomocnaUlica = filterUlica.Text
        End If
        If Not filterStatus Is Nothing Then
            pomocna = filterStatus.Text
            If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
            If pomocna = "*" Then pomocna = ""
        End If
        refreshDGV1(pomocnaUlica, pomocna, pomocnaUlicaMapa, pomocnaNapomenaKBR)

        'DGV1.Columns("krug").Visible = False
        DGV1.Columns("ulica").Visible = False
        DGV1.Columns("kbroj").Visible = False
        ' DGV1.Columns("ulicaKBroj").Visible = False
        DGV1.Columns("krug_idcd").Visible = False
        DGV1.Columns("idulice").Visible = False
        DGV1.Columns("kucni_broj_idcd").Visible = False
        'DGV1.Columns("kucni_broj").Visible = False
        DGV1.Columns("sourceof_INSERT").Visible = False
        DGV1.Columns("mbops").Visible = False
        'DGV1.Columns("NoviKbrojTeren").ReadOnly = True
        'DGV1.Columns("ZakazanoNapomenaObj").Width = 500
        DGV1.Columns("longituda").Width = 150
        DGV1.Columns("latituda").Width = 150
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonUnosNovogKBR.Click
        Me.Cursor = Cursors.WaitCursor
        If postojiMapa() = False Then
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Exit Sub
        End If
        btnMapaKbr.Visible = True
        btnMapaIzmenaKBR.Visible = False
        ButtonSave.Enabled = False
        btnMapaKbr.Text = "Dodaj novi kućni broj na mapu"
        btnMapaKbr.Tag = "unos"
        btnMapaIzmenaKBR.Tag = ""
        gbKBR.Visible = False
        btnMapaKbr.Enabled = True
        llNastavi.Enabled = False
        llNastavi.Visible = True
        'odaklesidosao.text = "btn"
        Call zatvoriIPonistiPanele()
        Call p3NonVisible()
        Call p3Visible()
        Label12.Text = "I"
        tbox1A.Visible = False
        lblUlicaKbroj.Visible = False
        tboxkbr.Enabled = True
        tbox1A.Enabled = False
        'tboxLatituda.Enabled = True
        'tboxLongituda.Enabled = True
        If atbUlica.sselectedValue <> "000000000000" Then 'OrElse selectedCellCount > 0 Then
            textboxUlica.Enabled = False
            textboxUlica.Visible = True
            atbULKBR.Visible = False
            textboxIDUlice.Text = atbUlica.sselectedValue
            textboxUlica.Text = atbUlica.sselectedText
            tboxkbr.Focus()
        Else
            Dim strSQlupit As String = dodatak + "select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) As displaymember, idulice as valuemember from Adresar " + vbCrLf +
                " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "' order by displaymember"
            Call popuniAutbDB(atbULKBR, strSQlupit)
            textboxUlica.Visible = False
            atbULKBR.sselectedText = ""
            atbULKBR.Text = ""
            atbULKBR.sselectedValue = ""
            atbULKBR.Enabled = True
            atbULKBR.Visible = True
            atbULKBR.Focus()
        End If
        lblNKBRUUlici.Text = "Ulica"
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'ButtonSave.Enabled = False
        Dim vred As String = tboxkbr.Text.Trim
        Dim vred2 As String = tboxLatituda.Text.Trim
        Dim vred3 As String = tboxLongituda.Text.Trim
        Dim vred4 As String = tboxKucniBrIDCD.Text.Trim
        Dim vred5 As String = ""
        Dim vred6 As String = ""

        If atbUlica.sselectedValue = "000000000000" AndAlso atbULKBR.sselectedText = "" AndAlso atbULKBR.Visible = True AndAlso Label12.Text = "I" Then
            ISTMessageBox.Show("Nije izabrana ulica!")
            atbULKBR.Focus()
            Exit Sub
        End If

        If vred = "" OrElse vred2 = "" OrElse vred3 = "" Then
            If vred = "" Then
                ISTMessageBox.Show("Polje KUĆNI BROJ ne sme biti prazno!")
                tboxkbr.Focus()
                Exit Sub
            ElseIf vred3 = "" Then
                ISTMessageBox.Show("Polje LONGITUDA ne sme biti prazno!")
                If btnMapaKbr.Enabled = True Then
                    btnMapaKbr.Focus()
                Else
                    llNastavi.Focus()
                End If
                Exit Sub
            ElseIf vred2 = "" Then
                ISTMessageBox.Show("Polje LATITUDA ne sme biti prazno!")
                If btnMapaKbr.Enabled = True Then
                    btnMapaKbr.Focus()
                Else
                    llNastavi.Focus()
                End If
                Exit Sub
            End If
            ' ButtonSave.Enabled = True
        ElseIf vred.IndexOf(".") >= 0 OrElse vred.IndexOf(",") >= 0 OrElse vred.IndexOf(":") >= 0 OrElse vred.IndexOf("'") >= 0 OrElse vred.IndexOf(")") >= 0 OrElse vred.IndexOf("(") >= 0 Then
            ISTMessageBox.Show("Nedozvoljena vrednost pri unosu kućnog broja :,.'()")
            tboxkbr.Focus()
            Exit Sub
        ElseIf CDbl(Val(Me.MinLongituda.Text.Trim)) > CDbl(Val(Me.tboxLongituda.Text.Trim)) OrElse CDbl(Val(Me.MaxLongituda.Text.Trim)) < CDbl(Val(Me.tboxLongituda.Text.Trim)) Then
            ISTMessageBox.Show("Neispravna longituda")
            tboxLongituda.Focus()
            ' ButtonSave.Enabled = True
            Exit Sub
        ElseIf CDbl(Val(Me.MaxLatituda.Text.Trim)) < CDbl(Val(Me.tboxLatituda.Text.Trim)) OrElse CDbl(Val(Me.MinLatituda.Text.Trim)) > CDbl(Val(Me.tboxLatituda.Text.Trim)) Then
            ISTMessageBox.Show("Neispravna latituda")
            tboxLatituda.Focus()
            ' ButtonSave.Enabled = True
            Exit Sub
        ElseIf CDbl(Val(Me.tboxLatituda.Text.Trim)) < CDbl(Val(Me.tboxLongituda.Text.Trim)) Then
            ISTMessageBox.Show("Proverite unos za longitudu i latitudu")
            tboxLongituda.Focus()
            'ButtonSave.Enabled = True
            Exit Sub
        End If

        If atbUlica.sselectedValue = "000000000000" AndAlso Label12.Text = "I" Then
            vred5 = atbULKBR.sselectedValue
            vred6 = atbULKBR.sselectedText
        Else
            vred5 = textboxIDUlice.Text.Trim
            vred6 = textboxUlica.Text.Trim
        End If

        If Label12.Text = "I" Then

            Dim strProvera As String = dodatak + "select ltrim(rtrim(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))))) from Adresar a left join p2_objekat b on a.kucni_broj_idcd=b.kucni_broj_idcd and a.krug_idcd=b.krug_idcd " + vbCrLf +
                " where IDANKETAR=N'" + kosam + "' and a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and a.idulice='" + vred5.Trim + "' and trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash)))))=N'" + vred + "'"
            Dim dtProvera As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Nothing)
            If dtProvera.Rows.Count > 0 Then
                ISTMessageBox.Show("Ne možete uneti već postojeći kućni broj!")
                tboxkbr.Focus()
                Exit Sub
            Else
                'ne postoji, moze INSERT
                Dim strsql2 As String = " select max(cast(left(kucni_broj_idcd,12) as bigint)) " + nvrd +
                                        " from ( " + nvrd +
                                        " select cast(left(kucni_broj_idcd,12) as bigint) as kucni_broj_idcd from Adresar   " + nvrd +
                                        " where IDANKETAR=N'" + kosam + "' and sourceof_insert='ANK' and substring(kucni_broj_idcd,1,8)=substring('" + fiktivnianketar + "',2,8)  " + nvrd +
                                        " union all " + nvrd +
                                        " select cast(left(kucni_broj_idcd,12) as bigint) as kucni_broj_idcd from adresarzaizvestaje  where  substring(kucni_broj_idcd,1,8)=substring('" + fiktivnianketar + "',2,8) ) a "
                '"select max(cast(left(kucni_broj_idcd,12) as bigint)) from Adresar b " + vbCrLf +
                '    " where IDANKETAR=N'" + kosam + "' and sourceof_insert='ANK' and substring(kucni_broj_idcd,1,8)=substring('" + fiktivnianketar + "',2,8) " + nvrd + '+ vbCrLf +
                '    " and not exists (select * from adresarzaizvestaje a where a.mbops=b.mbops and a.krug_idcd=b.krug_idcd and a.kucni_broj_idcd=b.kucni_broj_idcd ) "
                '" and mbops='" + atbOps.sselectedValue + "'" ' and krug_idcd='" + atbPK.sselectedValue + "'"
                Dim dt2 As DataTable = izvrsiSQLvratiDT(strsql2, Me.DBConnectionString, Nothing)
                Dim kucni_broj As String = ""

                If dt2.Rows.Count > 0 AndAlso Not (dt2.Rows(0).Item(0) Is Nothing) AndAlso (Not (dt2.Rows(0).Item(0).GetType Is GetType(System.DBNull))) Then
                    kucni_broj = (dt2.Rows(0).Item(0) + 1).ToString
                Else
                    kucni_broj = (Mid(fiktivnianketar, 2, 8).ToString + Mid("0000", 1, 4).ToString)
                End If

                Dim str As String = dodatak + "insert into Adresar (MBOPS,Krug_idcd," + vbCrLf +
               " kucni_broj_idCD, RbrStan, RbrUKrugu, KrugDeo, kucni_broj_Deo, IDAnketar, MBNAS, NazivOpstine," + vbCrLf +
               " NazivNaselja,IDUlice,Ulica,KBroj,Latituda,Longituda,SK,PkuSk," + vbCrLf +
               " ulicaKBroj,sourceof_INSERT,user_INSERT,date_INSERT) " +
               " select Top 1 MBOPS,Krug_idcd," + vbCrLf +
               " '" + kucni_broj.Trim + "01' ,1,1,'01','01',N'" + fiktivnianketar + "'," + vbCrLf +
               " MBNAS,NazivOpstine,NazivNaselja,IDUlice,ulica," + vbCrLf +
               " trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka,  N'" + tboxkbr.Text.Trim + "', 1, CONVERT(varbinary, @Hash)) ), 1)),'" + tboxLatituda.Text.Trim + "','" + tboxLongituda.Text.Trim + "'," + vbCrLf +
               " SK,PkuSk,  trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash)))))+' '+N'" + tboxkbr.Text.Trim + "'), 1, CONVERT(varbinary, @Hash)) ), 1)), " + vbCrLf +
               " N'ANK' ,N'" + kosam + "', getdate() from Adresar" + vbCrLf +
               " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue.Trim + "' and idulice='" + vred5.Trim + "'"

                Dim ok As String = izvrsiSQL(str, Me.DBConnectionString)
                If ok = "ok" Then
                    Dim str2 As String = "insert into p2_objekat (KRUG_idcd,kucni_broj_idCD,MBOps,NapomenaOKucnomBroju,user_INSERT,date_INSERT)" + vbCrLf +
                        " select KRUG_idcd,kucni_broj_idCD,MBOps, N'" + tboxNapomenaOKucnomBroju.Text + "',N'" + kosam + "', getdate() from ADRESAR a" + vbCrLf +
                        " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue.Trim + "' and idulice='" + vred5.Trim + "' and kucni_broj_idcd='" + kucni_broj + "01'" + vbCrLf +
                        " and not exists(select * from p2_objekat b where a.krug_idcd=b.krug_idcd and a.kucni_broj_idcd=b.kucni_broj_idcd)"
                    Dim ok2 As String = izvrsiSQL(str2, Me.DBConnectionString)
                    If ok2 = "ok" Then
                    Else
                        ISTMessageBox.Show("Greška 13! Zovite administratora!")
                        Me.Close()
                        Exit Sub
                    End If
                Else
                    ISTMessageBox.Show("Greška 14! Zovite administratora!")
                    Me.Close()
                    Exit Sub
                End If
            End If

            'INSERT
        ElseIf Label12.Text = "U" Then

            'Dim str2 As String = " select suser_name()"
            'Dim dt As DataTable = izvrsiSQLvratiDT(str2, Me.DBConnectionString, Me.jezik)
            'Dim korisnik As String = dt.Rows(0).Item(0)
            'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")
            'Dim fileReader1 As String = My.Computer.FileSystem.ReadAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\LongLat.txt")


            Dim opstina As String = atbOps.sselectedValue.Trim
            If postojiMapa() = False Then
                ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")

            Else
                Dim fileReader1 As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt")
                Dim pomlong As String = ""
                Dim pomlat As String = ""
                Dim p() As String = fileReader1.Replace(vbTab, " ").Replace(vbCr, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Trim.Split("$")
                If p.Length = 2 AndAlso Not p(0) Is Nothing AndAlso Not p(1) Is Nothing Then
                    pomlong = p(0).Trim.Replace(",", ".")
                    pomlat = p(1).Trim.Replace(",", ".")
                End If
            End If

            If tboxkbr.Text = stariKBR AndAlso tboxLongituda.Text = staraLong AndAlso tboxLatituda.Text = staraLat AndAlso tboxNapomenaOKucnomBroju.Text = staraNapomena Then
                ISTMessageBox.Show("Niste imali izmenu!")
                tboxkbr.Focus()
                Exit Sub
            End If

            If pom1 <> vred Then
                Dim strProvera As String = dodatak + "select ltrim(rtrim(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))))) " + vbCrLf +
                        " from Adresar a left join p2_objekat b on a.kucni_broj_idcd=b.kucni_broj_idcd and a.krug_idcd=b.krug_idcd " + vbCrLf +
                        " where IDANKETAR=N'" + kosam + "' and a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and a.idulice='" + vred5.Trim + "'" +
                        " and trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash)))))=N'" + vred + "'"
                Dim dtProvera As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Nothing)
                If dtProvera.Rows.Count > 0 Then
                    ISTMessageBox.Show("Kućni broj već postoji!")
                    tboxkbr.Focus()
                    Exit Sub
                End If

                If proveraKbr(vred) = False Then
                    ISTMessageBox.Show("Kućni broj nije ispravan!")
                    tboxkbr.Focus()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If
            End If


            'UPDATE
            'moze da menja samo lat,long,NapomenaOKucnomBroju ako nije RGZ
            'ako je RGZ samo NapomenaOKucnomBroju
            Dim str As String = ""
            If tboxSource.Text.Trim.ToUpper = "" Then
                str = "  if not exists (select * from p2_objekat where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and kucni_broj_idcd='" + vred4 + "')" + nvrd +
                          " insert into p2_objekat (KRUG_idcd,kucni_broj_idCD,MBOps,NapomenaOKucnomBroju,user_INSERT,date_INSERT)" + vbCrLf +
                          " select KRUG_idcd,kucni_broj_idCD,MBOps, N'" + tboxNapomenaOKucnomBroju.Text + "',N'" + kosam + "', getdate() from Adresar a " + vbCrLf +
                          " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue.Trim + "' and idulice='" + vred5.Trim + "' and kucni_broj_idcd='" + vred4 + "'" + vbCrLf +
                          " update p2_objekat set capiexported=0, NapomenaOKucnomBroju=N'" + tboxNapomenaOKucnomBroju.Text + "', date_update=getdate(), user_update=N'" + kosam + "'" + vbCrLf +
                          " where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and kucni_broj_idcd='" + vred4 + "'"
            Else
                str = dodatak +
                    " update adresar set kbroj=trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + tboxkbr.Text.Trim + "', 1, CONVERT(varbinary, @Hash)) ), 1))," + nvrd +
                    " longituda='" + tboxLongituda.Text.Trim + "', latituda='" + tboxLatituda.Text.Trim + "', ulicakbroj=trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + vred6 + "'+' '+N'" + tboxkbr.Text.Trim + "', 1, CONVERT(varbinary, @Hash)) ), 1)), " + nvrd +
                    " date_update=getdate(), user_update=N'" + kosam + "'" + vbCrLf +
                    " where IDANKETAR=N'" + kosam + "' and krug_idcd='" + atbPK.sselectedValue + "' and idulice='" + vred5.Trim + "' and kucni_broj_idcd='" + vred4 + "'" + vbCrLf +
                    " insert into p2_objekat (KRUG_idcd,kucni_broj_idCD,MBOps,NapomenaOKucnomBroju,user_INSERT,date_INSERT)" + vbCrLf +
                    " select KRUG_idcd,kucni_broj_idCD,MBOps, N'" + tboxNapomenaOKucnomBroju.Text + "',N'" + kosam + "', getdate() from Adresar a " + vbCrLf +
                    " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue.Trim + "' and idulice='" + vred5.Trim + "' and kucni_broj_idcd='" + vred4 + "'" + vbCrLf +
                    " and not exists (select * from p2_objekat b where a.krug_idcd=b.krug_idcd and a.kucni_broj_idcd=b.kucni_broj_idcd )" + vbCrLf +
                    " update p2_objekat set capiexported=0,NapomenaOKucnomBroju=N'" + tboxNapomenaOKucnomBroju.Text + "', date_update=getdate(), user_update=N'" + kosam + "'" + vbCrLf +
                    " where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and kucni_broj_idcd='" + vred4 + "'"
            End If
            Dim ok As String = izvrsiSQL(str, Me.DBConnectionString)
            If ok <> "ok" Then
                ISTMessageBox.Show("Greška 15! Zovite administratora!")
                Me.Close()
                Exit Sub
            End If


            If postojiMapa() = False Then
                'ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")

            Else
                If btnMapaIzmenaKBR.Tag = "izmena" Then
                    If opstina.Trim <> "" Then
                        'If tboxLongituda.Text <> staraLong OrElse tboxLatituda.Text <> staraLat Then
                        '    Dim fileReader As String = ""
                        '    fileReader = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBRSaLongLat.txt")
                        '    fileReader = fileReader + atbPK.sselectedText.Trim.Substring(0, 4) + "$" + textboxUlica.Text + "$" + stariKBR + "$" + staraLong.Trim + "$" + staraLat.Trim + ";"
                        '    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBRSaLongLat.txt", "", False)
                        '    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBRSaLongLat.txt", "" + fileReader.Trim + "", False)
                        'End If
                        If tboxLongituda.Text = staraLong AndAlso tboxLatituda.Text = staraLat AndAlso tboxkbr.Text <> stariKBR Then
                            Dim fileReader2 As String = ""
                            fileReader2 = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\UpdateKBR.txt")
                            fileReader2 = fileReader2 + atbPK.sselectedText.Trim.Substring(0, 4) + "$" + textboxUlica.Text + "$" + stariKBR + "$" + tboxkbr.Text + "$" + tboxLongituda.Text + "$" + tboxLatituda.Text + ";"
                            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\UpdateKBR.txt", "", False)
                            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\UpdateKBR.txt", "" + fileReader2.Trim + "", False)
                        End If
                    End If
                End If

                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
            End If

            Call p3NonVisible()
            DGV1.Focus()


        End If

        Call p3NonVisible()
        '20220715 Call refreshDGV1()

        Dim pomocnaNapomenaKBR As String = ""
        Dim pomocnaUlicaMapa As String = ""
        Dim pomocnaUlica As String = ""
        Dim pomocna As String = ""
        If Not filterNapomenaKBR Is Nothing Then
            pomocnaNapomenaKBR = filterNapomenaKBR.Text
        End If
        If Not filterUlicaMapa Is Nothing Then
            pomocnaUlicaMapa = filterUlicaMapa.Text
        End If
        If Not filterUlica Is Nothing Then
            pomocnaUlica = filterUlica.Text
        End If
        If Not filterStatus Is Nothing Then
            pomocna = filterStatus.Text
            If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
            If pomocna = "*" Then pomocna = ""
        End If
        refreshDGV1(pomocnaUlica, pomocna, pomocnaUlicaMapa, pomocnaNapomenaKBR)

        lblBrojKBR.Text = "Ukupno kućnih brojeva: " + DGV1.Rows.Count.ToString
    End Sub

    Sub BrisanjeReda(ByVal selectedRow As Integer)
        'Dim selectedRowValues As Boolean = DGV1.SelectedRows("sourceof_INSERT").ToString.Equals("ANK")
        Dim psource As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("sourceof_INSERT").Index).Value.ToString.Trim
        Dim kojaulica As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("idulice").Index).Value.ToString.Trim

        Dim msgtxt As String = "Da li ste sigurni da želite da brišete kućni broj?"
        ''videti šta ako postoje podaci!!!!! NISTA, NIJE DOZVOLJENO
        Dim msgtitle As String = "............"
        If psource <> "" Then
            Dim opc As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle)
            Select Case opc
                Case "Yes"
                    Dim opc2 As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle, 2)
                    Select Case opc2
                        Case "Yes"
                            'Dim strProvera As String = "select * from P2_Objekat " + vbCrLf +
                            '    " where isnull(AdresaTeren,0)<>0 and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                            '    " and kucni_broj_idcd='" + DGV1.Rows(selectedRow).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString + "'"
                            Dim strProvera As String = "select * from P2_Stan " + vbCrLf +
                                " where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                                " and kucni_broj_idcd='" + DGV1.Rows(selectedRow).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString + "'"
                            Dim dt As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Me.jezik)
                            Dim pomkbr As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("kbroj").Index).Value.ToString
                            Dim pomulica As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("ulica").Index).Value.ToString
                            If dt.Rows.Count > 0 Then
                                ISTMessageBox.Show("Nije dozvoljeno. Postoji unet materijal za stan na izabranom kućni broj." + nvrd + "Morate prvo obrisati materijal za stanove, pa onda obrisati kućni broj!")
                            Else

                                Dim str As String = " delete from p2_objekat" + vbCrLf +
                                    " where exists (select * from adresar a where trim(a.sourceof_INSERT)='ANK' and p2_objekat.mbops=a.mbops and p2_objekat.krug_idcd=a.krug_idcd and p2_objekat.kucni_broj_idcd=a.kucni_broj_idcd) " + vbCrLf +
                                    " and not exists (select * from p2_stan b where p2_objekat.mbops=b.mbops and p2_objekat.krug_idcd=b.krug_idcd and p2_objekat.kucni_broj_idcd=b.kucni_broj_idcd)" + vbCrLf +
                                    " and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                                    " and kucni_broj_idcd='" + DGV1.Rows(selectedRow).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString + "';" + vbCrLf +
                                    " delete from Adresar" + vbCrLf +
                                    " where not exists (select * from p2_stan b where Adresar.mbops=b.mbops and Adresar.krug_idcd=b.krug_idcd and Adresar.kucni_broj_idcd=b.kucni_broj_idcd)" + vbCrLf +
                                    " and trim(sourceof_INSERT)='ANK' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                                    " and idulice='" + kojaulica.Trim + "'" + vbCrLf +
                                    " and kucni_broj_idcd='" + DGV1.Rows(selectedRow).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString + "';"
                                Dim ok As String = izvrsiSQL(str, Me.DBConnectionString)

                                Dim str22 As String = " Select * from Adresar" + vbCrLf +
                                    " where not exists (select * from p2_stan b where Adresar.mbops=b.mbops and Adresar.krug_idcd=b.krug_idcd and Adresar.kucni_broj_idcd=b.kucni_broj_idcd)" + vbCrLf +
                                    " and trim(sourceof_INSERT)='ANK' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                                    " and idulice='" + kojaulica.Trim + "'" + vbCrLf +
                                    " and kucni_broj_idcd='" + DGV1.Rows(selectedRow).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString + "';"
                                Dim dt22 As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
                                If dt22.rows.count > 0 Then
                                    ISTMessageBox.Show("Neuspešno! Ne možete obrisati ovaj kućni broj!")
                                    Me.Cursor = Cursors.Default
                                    Exit Sub
                                End If

                                    If ok = "ok" Then
                                        ' DELETE
                                        'Dim str2 As String = " select suser_name()"
                                        'Dim dt2 As DataTable = izvrsiSQLvratiDT(str2, Me.DBConnectionString, Me.jezik)
                                        'Dim korisnik As String = dt2.Rows(0).Item(0)
                                        'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")

                                        If postojiMapa() = False Then
                                            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
                                            Me.Cursor = Cursors.Default
                                        Else
                                            Dim opstina As String = atbOps.sselectedValue.Trim
                                            If opstina.Trim <> "" Then
                                                Dim fileReader As String = ""
                                                fileReader = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt")
                                                fileReader = fileReader + atbPK.sselectedText.Trim.Substring(0, 4) + "$" + pomulica + "$" + pomkbr + ";"
                                                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt", "", False)
                                                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt", "" + fileReader.Trim + "", False)
                                            End If
                                        End If

                                        ISTMessageBox.Show("Obrisano!")
                                        '20220715 Call refreshDGV1()

                                        Dim pomocnaNapomenaKBR As String = ""
                                        Dim pomocnaUlicaMapa As String = ""
                                        Dim pomocnaUlica As String = ""
                                        Dim pomocna As String = ""
                                        If Not filterNapomenaKBR Is Nothing Then
                                            pomocnaNapomenaKBR = filterNapomenaKBR.Text
                                        End If
                                        If Not filterUlicaMapa Is Nothing Then
                                            pomocnaUlicaMapa = filterUlicaMapa.Text
                                        End If
                                        If Not filterUlica Is Nothing Then
                                            pomocnaUlica = filterUlica.Text
                                        End If
                                        If Not filterStatus Is Nothing Then
                                            pomocna = filterStatus.Text
                                            If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
                                            If pomocna = "*" Then pomocna = ""
                                        End If
                                        refreshDGV1(pomocnaUlica, pomocna, pomocnaUlicaMapa, pomocnaNapomenaKBR)

                                        lblBrojKBR.Text = "Ukupno kućnih brojeva: " + DGV1.Rows.Count.ToString
                                        If DGV1.Rows.Count = 0 Then
                                            Dim pomcbo1 As String = atbPK.sselectedText

                                            Dim pom1cbo1 As String = atbPK.sselectedValue
                                            Dim pomcbo2 As String = atbOps.sselectedText
                                            Dim pom1cbo2 As String = atbOps.sselectedValue
                                            Dim pomatb1 As String = atbUlica.Text

                                            Call Reset()

                                            atbOps.sselectedText = pomcbo2
                                            atbOps.Text = pomcbo2
                                            atbOps.sselectedValue = pom1cbo2
                                            atbPK.sselectedText = pomcbo1
                                            atbPK.Text = pomcbo1
                                            atbPK.sselectedValue = pom1cbo1
                                            actbOpsStaro = pomcbo2
                                            actb0Staro = pomcbo1
                                            actb1Staro = pomatb1
                                            Call actbVOps()
                                            Call actbV0()
                                            Dim strSQl2 As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " +
                                                 " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "'" +
                                                 " union" +
                                                 " select '(*)' as displaymember, '000000000000' as valuemember order by displaymember"
                                            Call popuniAutbDB(atbUlica, strSQl2)
                                            'If atbUlica.Text <> "(*)" Then
                                            '    atbUlica.Text = pomatb1
                                            'Else
                                            atbUlica.Text = ""
                                            'End If
                                            atbUlica.Focus()
                                            atbUlica.SelectionStart = 0
                                            atbUlica.SelectionLength = atbUlica.Text.Length
                                        End If
                                    Else
                                        ISTMessageBox.Show("Greška 16! Zovite administratora!")
                                        Me.Close()
                                        Exit Sub
                                    End If
                                End If

                                Case "No"
                    End Select
                Case "No"
            End Select
        ElseIf psource.Trim = "" Then
            ISTMessageBox.Show("Nije dozvoljeno poništavanje kućnih brojeva koje niste sami dodali.")
        Else
            ISTMessageBox.Show("Molim vas, selektujte red.")
        End If
    End Sub

    Sub BrisanjeMaterijalaZaStan(ByVal selectedRow As Integer)
        If selectedRow >= 0 Then
            'Dim selectedRowValues As Boolean = DGV1.SelectedRows("sourceof_INSERT").ToString.Equals("ANK")
            Dim kojaops As String = DGV2.Rows(selectedRow).Cells(DGV2.Columns("mbops").Index).Value.ToString.Trim
            Dim kojikrug As String = DGV2.Rows(selectedRow).Cells(DGV2.Columns("krug_idcd").Index).Value.ToString.Trim
            Dim kojikbr As String = DGV2.Rows(selectedRow).Cells(DGV2.Columns("kucni_broj_idcd").Index).Value.ToString.Trim
            Dim kojistan As String = DGV2.Rows(selectedRow).Cells(DGV2.Columns("rbrstan").Index).Value.ToString.Trim
            'Dim kojaulica As String = DGV2.Rows(selectedRow).Cells(DGV2.Columns("idulice").Index).Value.ToString.Trim

            Dim msgtxt As String = "Da li ste sigurni da želite da obrišete unete podatke za ovaj stan?"
            ''videti šta ako postoje podaci!!!!! NISTA, NIJE DOZVOLJENO
            Dim msgtitle As String = "............"

            Dim opc As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle)
            Select Case opc
                Case "Yes"
                    Dim opc2 As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle, 2)
                    Select Case opc2
                        Case "Yes"
                            'Dim strProvera As String = "select * from P2_Objekat " + vbCrLf +
                            '    " where isnull(AdresaTeren,0)<>0 and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                            '    " and kucni_broj_idcd='" + DGV1.Rows(selectedRow).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString + "'"
                            Dim strProvera As String = "select * from P2_Stan a " + vbCrLf +
                                " where a.mbops='" + kojaops + "' and a.krug_idcd='" + kojikrug + "'" + vbCrLf +
                                " and a.kucni_broj_idcd='" + kojikbr + "' and a.rbrstan='" + kojistan + "' and not exists" + nvrd +
                                "(select * from p2_dom x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan ) and not exists" + nvrd +
                                "(select * from spisaklica x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan ) and not exists" + nvrd +
                                "(select * from P1 x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan )"
                            Dim dt As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Me.jezik)
                            'Dim pomkbr As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("kbroj").Index).Value.ToString
                            'Dim pomulica As String = DGV1.Rows(selectedRow).Cells(DGV1.Columns("ulica").Index).Value.ToString
                            If dt.Rows.Count <> 1 Then
                                ISTMessageBox.Show("Nije dozvoljeno. Postoji unet materijal za domaćinstvo ili lica na izabranom stanu." + nvrd + "Morate prvo obrisati materijal za domaćinstvo/lica, pa onda obrisati materijal za stan!")
                            Else

                                Dim str As String = " delete from p2_stan" + vbCrLf +
                                    " where mbops='" + kojaops + "' and krug_idcd='" + kojikrug + "'" + vbCrLf +
                                    " and kucni_broj_idcd='" + kojikbr + "' and rbrstan='" + kojistan + "';" + vbCrLf +
                                    "update adresar set statusanketar=0, [USER_statusAnketar]=N'" + fiktivnianketar + "',[DATE_statusAnketar]=getdate()" + vbCrLf +
                                    " where mbops='" + kojaops + "' and krug_idcd='" + kojikrug + "'" + vbCrLf +
                                    " and kucni_broj_idcd='" + kojikbr + "' and rbrstan='" + kojistan + "';"
                                Dim ok As String = izvrsiSQL(str, Me.DBConnectionString)
                                If ok = "ok" Then
                                    ' DELETE
                                    'Dim str2 As String = " select suser_name()"
                                    'Dim dt2 As DataTable = izvrsiSQLvratiDT(str2, Me.DBConnectionString, Me.jezik)
                                    'Dim korisnik As String = dt2.Rows(0).Item(0)
                                    'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")
                                    ISTMessageBox.Show("Obrisano!")
                                    '20220715 Call refreshDGV1()
                                    Dim pomocnaNapomenaKBR As String = ""
                                    Dim pomocnaUlicaMapa As String = ""
                                    Dim pomocnaUlica As String = ""
                                    Dim pomocna As String = ""
                                    If Not filterNapomenaKBR Is Nothing Then
                                        pomocnaNapomenaKBR = filterNapomenaKBR.Text
                                    End If
                                    If Not filterUlicaMapa Is Nothing Then
                                        pomocnaUlicaMapa = filterUlicaMapa.Text
                                    End If
                                    If Not filterUlica Is Nothing Then
                                        pomocnaUlica = filterUlica.Text
                                    End If
                                    If Not filterStatus Is Nothing Then
                                        pomocna = filterStatus.Text
                                        If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
                                        If pomocna = "*" Then pomocna = ""
                                    End If
                                    refreshDGV1(pomocnaUlica, pomocna, pomocnaUlicaMapa, pomocnaNapomenaKBR)

                                Else
                                    ISTMessageBox.Show("Greška 17! Zovite administratora!")
                                    Me.Close()
                                    Exit Sub
                                End If
                            End If

                        Case "No"
                    End Select
                Case "No"
            End Select
        Else
            ISTMessageBox.Show("Molim vas, selektujte red.")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Call Cancel()
        'overlayHandle2.Close()
    End Sub

    Private Sub Cancel()
        Dim ulica As String = ""
        ButtonSave.Enabled = True
        If atbUlica.sselectedValue = "000000000000" Then
            ulica = atbULKBR.sselectedText
            'vred5 = atbULKBR.sselectedValue
            'vred6 = atbULKBR.sselectedText
        Else
            ulica = textboxUlica.Text.Trim
            'vred5 = textboxIDUlice.Text.Trim
            'vred6 = textboxUlica.Text.Trim
        End If

        'Dim str As String = " select suser_name()"
        'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
        'Dim korisnik As String = dt.Rows(0).Item(0)
        'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")


        If postojiMapa() = False Then
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Me.Cursor = Cursors.Default
        Else
            Dim opstina As String = atbOps.sselectedValue.Trim
            If btnMapaKbr.Tag = "unos" Then
                If opstina.Trim <> "" Then
                    Dim fileReader As String = ""
                    fileReader = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt")
                    fileReader = fileReader + atbPK.sselectedText.Trim.Substring(0, 4) + "$" + ulica + "$" + tboxkbr.Text + ";"
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt", "" + fileReader.Trim + "", False)
                End If
            End If


            Dim pomlong As String = ""
            Dim pomlat As String = ""
            If btnMapaIzmenaKBR.Tag = "izmena" Then
                Dim fileReader1 As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt")
                Dim p() As String = fileReader1.Replace(vbTab, " ").Replace(vbCr, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Trim.Split("$")
                If p.Length = 2 AndAlso Not p(0) Is Nothing AndAlso Not p(1) Is Nothing Then
                    pomlong = p(0).Trim.Replace(",", ".")
                    pomlat = p(1).Trim.Replace(",", ".")
                End If
            End If

            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
        End If


        Call p3NonVisible()
        DGV1.Focus()
    End Sub
    Private Sub TextBoxLong_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxLong.KeyPress
        Dim keyChar = e.KeyChar
        If Char.IsDigit(keyChar) OrElse (keyChar = "."c AndAlso Me.TextBoxLong.Text.IndexOf(".") < 0 AndAlso Len(Me.TextBoxLong.Text) > 0) Then
            Dim text = Me.TextBoxLong.Text
            Dim selectionStart = Me.TextBoxLong.SelectionStart
            Dim selectionLength = Me.TextBoxLong.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 2 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 11 Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            ElseIf Double.TryParse(text, New Integer) AndAlso text.IndexOf("."c) > 2 Then
                e.Handled = True
                'ElseIf Double.TryParse(text, New Integer) AndAlso text.IndexOf("."c) text.Length > 2 Then
                '    'Reject an integer that is longer than 16 digits.
                '    e.Handled = True
            End If
        ElseIf keyChar = ControlChars.Back Then
            e.Handled = False
        Else
            'Reject all other characters.
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            TextBoxLat.Focus()
        End If
    End Sub
    Private Sub txtBrojTelefona_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrojTelefona.KeyPress
        'Dim keyChar = e.KeyChar
        'Me.txtBrojTelefona.Text = Me.txtBrojTelefona.Text.Trim
        'If Char.IsDigit(keyChar) OrElse (keyChar = "."c AndAlso Me.txtBrojTelefona.Text.IndexOf(".") < 0 AndAlso Len(Me.txtBrojTelefona.Text) > 0) Then
        '    Dim text = Me.txtBrojTelefona.Text
        '    Dim selectionStart = Me.txtBrojTelefona.SelectionStart
        '    Dim selectionLength = Me.txtBrojTelefona.SelectionLength

        '    text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

        'ElseIf keyChar = ControlChars.Back Then
        '    e.Handled = False
        'Else
        '    'Reject all other characters.
        '    e.Handled = True
        'End If

        'If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> " "c) Then 'OrElse(Not e.KeyChar = ControlChars.Back)
        '    e.Handled = True
        'ElseIf e.keyChar = ControlChars.Back Then
        '    e.Handled = False
        'End If
        'If e.KeyChar = ChrW(13) Then
        '    txtUkupanBrLica.Focus()
        'End If
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(13) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> " "c)
        End If

        If e.KeyChar = ChrW(13) Then
            txtUkupanBrLica.Focus()
            txtUkupanBrLica.SelectionStart = txtUkupanBrLica.Text.Length
            txtUkupanBrLica.SelectionLength = 0
        End If

    End Sub


    Private Sub txtBrojStanaVrata_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBrojStanaVrata.KeyPress

        If e.KeyChar = ChrW(13) Then
            dtpDatumDolaska.Focus()
            dtpDatumDolaska.SelectionStart = txtUkupanBrLica.Text.Length
            dtpDatumDolaska.SelectionLength = 0
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

    Private Sub txtUkupanBrLica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUkupanBrLica.KeyPress
        'Dim keyChar = e.KeyChar
        'Me.txtBrojTelefona.Text = Me.txtBrojTelefona.Text.Trim
        'If Char.IsDigit(keyChar) OrElse (keyChar = "."c AndAlso Me.txtBrojTelefona.Text.IndexOf(".") < 0 AndAlso Len(Me.txtBrojTelefona.Text) > 0) Then
        '    Dim text = Me.txtBrojTelefona.Text
        '    Dim selectionStart = Me.txtBrojTelefona.SelectionStart
        '    Dim selectionLength = Me.txtBrojTelefona.SelectionLength

        '    text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

        'ElseIf keyChar = ControlChars.Back Then
        '    e.Handled = False
        'Else
        '    'Reject all other characters.
        '    e.Handled = True
        'End If

        'If Not (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> " "c) Then 'OrElse(Not e.KeyChar = ControlChars.Back)
        '    e.Handled = False
        'Else
        '    e.Handled = True
        'End If

        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(13) Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> " "c)
        End If

        If e.KeyChar = ChrW(13) Then
            txtIshodNapomena.Focus()
            txtIshodNapomena.SelectionStart = txtIshodNapomena.Text.Length
            txtIshodNapomena.SelectionLength = 0
        End If
    End Sub

    Private Sub txtKontaktOsoba_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKontaktOsoba.KeyPress
        'If (Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c) Then
        '    e.Handled = True
        'End If
        If e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ChrW(13) Then
            'e.Handled = Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar <> " "c)
            e.Handled = Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c)
        End If
        'If (DirectCast(sender, TextBox).Text.Length = 0) Then
        '    e.KeyChar = Char.ToUpper(e.KeyChar)
        'End If
        If e.KeyChar = ChrW(13) Then
            txtBrojTelefona.Focus()
            txtBrojTelefona.SelectionStart = txtBrojTelefona.Text.Length
            txtBrojTelefona.SelectionLength = 0
        End If
    End Sub



    Private Sub TextBoxLat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxLat.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsDigit(keyChar) OrElse (keyChar = "."c AndAlso Me.TextBoxLat.Text.IndexOf(".") < 0 AndAlso Len(Me.TextBoxLat.Text) > 0) Then
            Dim text = Me.TextBoxLat.Text
            Dim selectionStart = Me.TextBoxLat.SelectionStart
            Dim selectionLength = Me.TextBoxLat.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 2 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 11 Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            ElseIf Double.TryParse(text, New Integer) AndAlso text.IndexOf("."c) > 2 Then
                e.Handled = True
            End If
        ElseIf keyChar = ControlChars.Back Then
            e.Handled = False
        Else
            'Reject all other characters.
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            ButtonDodajAdr.Focus()
        End If
    End Sub
    Private Sub tboxLatituda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxLatituda.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsDigit(keyChar) OrElse (keyChar = "."c AndAlso Me.tboxLatituda.Text.IndexOf(".") < 0 AndAlso Len(Me.tboxLatituda.Text) > 0) Then
            Dim text = Me.tboxLatituda.Text
            Dim selectionStart = Me.tboxLatituda.SelectionStart
            Dim selectionLength = Me.tboxLatituda.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 2 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 11 Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            ElseIf Double.TryParse(text, New Integer) AndAlso text.IndexOf("."c) > 2 Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            End If
        ElseIf keyChar = ControlChars.Back Then
            e.Handled = False
        Else
            'Reject all other characters.
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            tboxNapomenaOKucnomBroju.Focus()
            tboxNapomenaOKucnomBroju.SelectionStart = tboxNapomenaOKucnomBroju.Text.Length
            tboxNapomenaOKucnomBroju.SelectionLength = 0
        End If
    End Sub
    Private Sub tboxLongituda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxLongituda.KeyPress
        Dim keyChar = e.KeyChar

        If Char.IsDigit(keyChar) OrElse (keyChar = "."c AndAlso Me.tboxLongituda.Text.IndexOf(".") < 0 AndAlso Len(Me.tboxLongituda.Text) > 0) Then
            Dim text = Me.tboxLongituda.Text
            Dim selectionStart = Me.tboxLongituda.SelectionStart
            Dim selectionLength = Me.tboxLongituda.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If Integer.TryParse(text, New Integer) AndAlso text.Length > 2 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            ElseIf Double.TryParse(text, New Double) AndAlso text.IndexOf("."c) < text.Length - 11 Then
                'Reject a real number with two many decimal places.
                e.Handled = True
            ElseIf Double.TryParse(text, New Integer) AndAlso text.IndexOf("."c) > 2 Then
                e.Handled = True
            End If
        ElseIf keyChar = ControlChars.Back Then
            e.Handled = False
        Else
            'Reject all other characters.
            e.Handled = True
        End If
        If e.KeyChar = ChrW(13) Then
            tboxLatituda.Focus()
        End If
    End Sub
    Private Sub tboxKucniBR_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxKucniBR.KeyPress
        If e.KeyChar = ChrW(13) Then
            btnMapaKbrUL.Focus()
        End If
    End Sub
    Private Sub tboxNovaUlica_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxNovaUlica.KeyPress
        If e.KeyChar = ChrW(13) Then
            tboxKucniBR.Focus()
        End If
    End Sub
    Private Sub txtNNUlice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNNUlice.KeyPress
        If e.KeyChar = ChrW(13) Then
            ButtonIzmenaULOK.Focus()
        End If
    End Sub
    Private Sub tboxkbr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxkbr.KeyPress
        If e.KeyChar = ChrW(13) Then
            If llNastavi.Visible = True Then
                btnMapaKbr.Focus()
            Else
                tboxNapomenaOKucnomBroju.Focus()
            End If

        End If
    End Sub
    Private Sub tboxNapomena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxNapomenaOKucnomBroju.KeyPress, tboxNapomenaStatusAnketar.KeyPress, txtIshodNapomena.KeyPress, txtNapomenaStan.KeyPress

        Dim tbox As TextBox = DirectCast(sender, TextBox)
        Dim keyChar = e.KeyChar

        If Char.IsDigit(keyChar) Then
            Dim text = tbox.Text
            Dim selectionStart = tbox.SelectionStart
            Dim selectionLength = tbox.SelectionLength

            text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

            If text.Length > 999 Then
                'Reject an integer that is longer than 16 digits.
                e.Handled = True
            End If
        End If
        If e.KeyChar = ChrW(13) Then
            If tbox.Name.Trim.ToUpper = "TBOXNAPOMENA" Then
                e.Handled = True
                ButtonSave.Focus()
            ElseIf tbox.Name.Trim.ToUpper = "TEXTBOXRAZLOG" Then
                e.Handled = True
                ButtonZahtev.Focus()
            ElseIf tbox.Name.Trim.ToUpper = "TXTISHODNAPOMENA" Then
                e.Handled = True
                ButtonSave2.Focus()
            ElseIf tbox.Name.Trim.ToUpper = "TXTNAPOMENASTAN" Then
                e.Handled = True
                btnOKNapomenaStan.Focus()
            End If
        End If

    End Sub
    'Private Sub tboxNapomenaZak_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboxNapomenaZak.KeyPress
    '    Dim keyChar = e.KeyChar

    '    If Char.IsDigit(keyChar) Then
    '        Dim text = Me.tboxNapomenaZak.Text
    '        Dim selectionStart = Me.tboxNapomenaZak.SelectionStart
    '        Dim selectionLength = Me.tboxNapomenaZak.SelectionLength

    '        text = text.Substring(0, selectionStart) & keyChar & text.Substring(selectionStart + selectionLength)

    '        If text.Length > 999 Then
    '            'Reject an integer that is longer than 16 digits.
    '            e.Handled = True
    '        End If
    '    End If
    '    If e.KeyChar = ChrW(13) Then
    '        ButtonOkZak.Focus()
    '    End If
    'End Sub
    'Private Sub TextBoxLong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxLong.KeyDown
    '    If e.Control AndAlso e.KeyCode = Keys.V Then
    '        'do paste
    '        TextBoxLong.SelectedText = Clipboard.GetText()

    '    End If
    '    'Select Case e.KeyCode
    '    '    Case Keys.Up
    '    '        SendKeys.Send("+{TAB}")
    '    '    Case Keys.Down
    '    '        SendKeys.Send("{TAB}")
    '    '    Case Else
    '    'End Select
    'End Sub
    'Private Sub TextBoxLat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxLat.KeyDown
    '    If e.Control AndAlso e.KeyCode = Keys.V Then
    '        'do paste
    '        TextBoxLat.SelectedText = Clipboard.GetText()
    '    End If
    '    'Select Case e.KeyCode
    '    '    Case Keys.Up
    '    '        SendKeys.Send("+{TAB}")
    '    '    Case Keys.Down
    '    '        SendKeys.Send("{TAB}")
    '    '    Case Else
    '    'End Select
    'End Sub
    'Private Sub tboxLatituda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tboxLatituda.KeyDown
    '    If e.Control AndAlso e.KeyCode = Keys.V Then
    '        'do paste
    '        tboxLatituda.SelectedText = Clipboard.GetText()
    '    End If
    '    'Select Case e.KeyCode
    '    '    Case Keys.Up
    '    '        SendKeys.Send("+{TAB}")
    '    '    Case Keys.Down
    '    '        SendKeys.Send("{TAB}")
    '    '    Case Else
    '    'End Select
    'End Sub
    'Private Sub tboxLongituda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tboxLongituda.KeyDown
    '    If e.Control AndAlso e.KeyCode = Keys.V Then
    '        'do paste
    '        tboxLongituda.SelectedText = Clipboard.GetText()
    '    End If
    '    'Select Case e.KeyCode
    '    '    Case Keys.Up
    '    '        SendKeys.Send("+{TAB}")
    '    '    Case Keys.Down
    '    '        SendKeys.Send("{TAB}")
    '    '    Case Else
    '    'End Select
    'End Sub



    Private Sub ButtonNastavi_Click(sender As Object, e As EventArgs) Handles ButtonNastavi.Click


        If atbPK.Text.Trim = "" Then
            atbPK.Focus()
            Exit Sub
        End If

        If atbUlica.Text.Trim = "" Then
            atbUlica.Focus()
            Exit Sub
        End If
        BtnSvaLica.Tag = ""
        ButtonZakazani.Tag = ""
        Me.Cursor = Cursors.WaitCursor

        Dim overlayHandle As ISTFormIsLoading
        overlayHandle = New ISTFormIsLoading(Me, Me.TabControl1.Parent)
        overlayHandle.Show()
        tboxIDULICE.Text = ""
        Dim strsqlLongituda As String = " select min(longituda), max(longituda) from Adresar " + vbCrLf +
                                        " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'"
        Dim dtLongituda As DataTable = izvrsiSQLvratiDT(strsqlLongituda, Me.DBConnectionString, Nothing)
        Dim strsqlLatituda As String = " select min(latituda),max(latituda) from Adresar " + vbCrLf +
                                       " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'"
        Dim dtLatituda As DataTable = izvrsiSQLvratiDT(strsqlLatituda, Me.DBConnectionString, Nothing)

        tboxIDULICE.Text = atbUlica.sselectedValue
        tboxKucniBR.Clear()
        TextBoxLong.Clear()
        TextBoxLat.Clear()
        ButtonDodajAdr.Enabled = True
        If atbOps.sselectedValue = "" Then
            atbOps.Focus()
            ISTMessageBox.Show("Morate izabrati opštinu")
            overlayHandle.Close()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf atbPK.sselectedValue = "" Then
            atbPK.Focus()
            ISTMessageBox.Show("Morate izabrati popisni krug")
            overlayHandle.Close()
            Me.Cursor = Cursors.Default
            Exit Sub
        ElseIf atbUlica.Text = "" Then
            atbUlica.Focus()
            ISTMessageBox.Show("Morate izabrati ulicu")
            overlayHandle.Close()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor

        Call nesamoja(PanelNUl)
        PanelNUl.Visible = False

        Call refreshDGV1(,,,, True)
        Call disableIzborZaGrid()
        Call visibletabkontrola()
        Call enabledtabkontrolu()
        StaraNovaUL = 1

        'Legenda()
        PanelLegendaDGV1.Visible = True
        PanelLegendaDGV2.Visible = False
        PanelLegendaDGV3.Visible = False
        nevena = True
        TabControl1.SelectedTab = TabPage1
        TabPage1.Visible = True
        TabControl1.SelectedIndex = 0
        DGV1.Focus()
        ButtonUnosNoveUlice.Visible = False
        PanelIzmenaNazivaNoveUlice.Visible = False
        'TabControl1.TabPages.Remove(TabPage1)
        'TabControl1.TabPages.Remove(TabPage2)
        'TabControl1.TabPages.Add(TabPage1)
        'TabControl1.TabPages.Add(TabPage2)
        'llOVDE.Visible = False
        'ButtonUnosNoveUlice.Visible = False
        TabControl1.SelectedTab = TabPage1
        nevena = False
        'ButtonZakazani.Enabled = True
        Call promenaTaba()
        filterDatumZakazan.Tag = ""
        lblBrojKBR.Text = "Ukupno kućnih brojeva: " + DGV1.Rows.Count.ToString

        Dim strimatabelu As String = ""


        'Dim str As String = " select suser_name()"
        'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)



        If postojiMapa() = False Then
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Me.Cursor = Cursors.Default
            overlayHandle.Close()
        Else
            Dim opstina As String = atbOps.sselectedValue.Trim
            If opstina.Trim <> "" Then
                Dim dir As New IO.DirectoryInfo("C:\IST\QGIS\Popis_21\" + opstina.Trim + "")
                If dir.Exists Then
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\Resources\SifOps.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\Resources\SifOps.txt", CStr(CInt(opstina.Trim)).Trim, False, System.Text.Encoding.ASCII)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina.Trim + "\pk.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina.Trim + "\pk.txt", atbPK.sselectedText.Trim.Substring(0, 4), False)
                    btnMapa.Visible = True
                    'ADILLLLLLLLLLLLLLLLLL
                    If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then   'može i testcapi
                        Dim FilePath = "C:\IST\Istrazivanja.NET.9500\popis_21\PrebaciSTARTUPPY.vbs"
                        Dim dir2 As New IO.DirectoryInfo("C:\IST\QGIS\Popis_21\Resources")
                        If System.IO.File.Exists(FilePath) AndAlso dir2.Exists Then
                            Dim myProcess As Process = Process.Start("C:\IST\Istrazivanja.NET.9500\popis_21\PrebaciSTARTUPPY.vbs")
                            myProcess.WaitForExit()
                        End If
                    End If
                Else
                    ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
                End If
                'Dim korisnik As String = dt.Rows(0).Item(0)
                'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")

            End If
        End If


        overlayHandle.Close()
        Me.Cursor = Cursors.Default

    End Sub
    Sub enableIzborZaGrid()
        atbOps.Enabled = True
        atbPK.Enabled = True
        atbUlica.Enabled = True
        ButtonUnosNoveUlice.Enabled = True
        ButtonNastavi.Enabled = True
        PanelIzmenaNazivaNoveUlice.Enabled = True
    End Sub
    Sub disableIzborZaGrid()
        atbOps.Enabled = False
        atbPK.Enabled = False
        atbUlica.Enabled = False
        ButtonUnosNoveUlice.Enabled = False
        ButtonNastavi.Enabled = False
        PanelIzmenaNazivaNoveUlice.Enabled = False
    End Sub
    Sub enabledtabkontrolu()
        ButtonUnosNovogKBR.Enabled = True
        TabControl1.Tag = "enabled"
        'TabControl1.Enabled = True
        'DGV1.Enabled = True
    End Sub
    Sub disabledtabkontrolu()
        ButtonUnosNovogKBR.Enabled = False
        TabControl1.Tag = "disabled"
        'TabControl1.Enabled = False
        'DGV1.Enabled = False
    End Sub
    Sub visibletabkontrola()
        ButtonUnosNovogKBR.Visible = True
        lblBrojKBR.Visible = True
        TabControl1.Visible = True
        DGV1.Visible = True
    End Sub
    Sub invisibletabkontrola()
        ButtonUnosNovogKBR.Visible = False
        lblBrojKBR.Visible = False
        TabControl1.Visible = False
        DGV1.Visible = False
    End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    '    Call Reset()
    'End Sub

    'Private Sub DGV1_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.RowHeaderMouseDoubleClick
    '    Dim rezultat As Integer = dgv2open(e)
    '    If rezultat = 1 Then
    '        Me.TabControl1.SelectedTab = Me.TabPage2
    '        'PanelLegendaDGV1.Visible = False
    '        'PanelLegendaDGV2.Visible = True
    '    Else
    '        Me.TabControl1.SelectedTab = Me.TabPage1
    '        'PanelLegendaDGV2.Visible = False
    '        'PanelLegendaDGV1.Visible = True
    '        ISTMessageBox.Show("Nemate unete stanove za ovaj kbr!")
    '    End If
    'End Sub
    Private Sub DGV1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.RowHeaderMouseClick
        Dim rezultat As Integer = dgv2open(e)
        If rezultat = 1 Then
        Else
            Me.TabControl1.SelectedTab = Me.TabPage1
        End If
    End Sub
    Function dgv2open(e As DataGridViewCellMouseEventArgs) As Integer
        If e.RowIndex >= 0 Then
            DGV1.ClearSelection()
            DGV1.Rows(e.RowIndex).Selected = True
            Dim selectedRowCount As Integer = DGV1.Rows.GetRowCount(DataGridViewElementStates.Selected)
            'Call Promena(selectedRowCount)
            Call refreshDGV2(e.RowIndex)
            If DGV2.Rows.Count > 0 Then
                DGV2.Visible = True
                dgv2open = 1
            Else
                DGV2.Visible = False
                dgv2open = 0
            End If
        End If
    End Function
    Dim pom1 As String = ""

    Sub Promena(ByVal selectedRow As Integer)
        Call p3NonVisible()
        Label12.Text = "U"
        DGV1.ClearSelection()
        'DGV1.Rows(selectedRow).Selected = True
        If DGV1.Rows.Count - 1 >= selectedRow Then
            DGV1.Rows(selectedRow).Selected = True
        Else
            DGV1.Rows(0).Selected = True
        End If


        Dim si As Integer = DGV1.SelectedRows(0).Index

        tboxkbr.Enabled = False
        atbULKBR.Enabled = False
        tbox1A.Enabled = False
        tboxSource.Enabled = False
        tboxSource.Text = DGV1.Rows(si).Cells(DGV1.Columns("sourceof_INSERT").Index).Value.ToString
        tboxkbr.Text = DGV1.Rows(si).Cells(DGV1.Columns("kbroj").Index).Value.ToString
        tbox1A.Text = DGV1.Rows(si).Cells(DGV1.Columns("NoviKbrojTeren").Index).Value.ToString
        tboxLatituda.Text = DGV1.Rows(si).Cells(DGV1.Columns("latituda").Index).Value.ToString
        tboxLongituda.Text = DGV1.Rows(si).Cells(DGV1.Columns("longituda").Index).Value.ToString
        tboxNapomenaOKucnomBroju.Text = DGV1.Rows(si).Cells(DGV1.Columns("NapomenaOKucnomBroju").Index).Value.ToString
        tboxKucniBrIDCD.Text = DGV1.Rows(si).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString
        textboxIDUlice.Text = DGV1.Rows(si).Cells(DGV1.Columns("idulice").Index).Value.ToString
        textboxUlica.Text = DGV1.Rows(si).Cells(DGV1.Columns("ulica").Index).Value.ToString
        Dim rgziliank As String = DGV1.Rows(si).Cells(DGV1.Columns("sourceof_INSERT").Index).Value.ToString
        textboxUlica.Visible = True
        textboxUlica.BringToFront()
        pom1 = tboxkbr.Text.Trim


        Call p3Visible()
        If rgziliank = "📌" Then
            tbox1A.Visible = False
            lblUlicaKbroj.Visible = False
            btnMapaIzmenaKBR.Enabled = True
        Else
            tbox1A.Visible = True
            lblUlicaKbroj.Visible = True
            btnMapaIzmenaKBR.Enabled = False
        End If
        If tboxSource.Text.Trim.ToUpper = "" Then
            tboxLatituda.Enabled = False
            tboxLongituda.Enabled = False
            tboxNapomenaOKucnomBroju.Enabled = True
            tboxNapomenaOKucnomBroju.SelectAll()
            tboxNapomenaOKucnomBroju.Focus()
        Else
            tboxkbr.Enabled = True
            'tboxLatituda.Enabled = True
            'tboxLongituda.Enabled = True
            tboxNapomenaOKucnomBroju.Enabled = True
            tboxLatituda.SelectAll()
            tboxkbr.Focus()
        End If
        lblNKBRUUlici.Text = "Ulica"
    End Sub

    Private Sub DGV1_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV1.CellFormatting
        If DGV1.Visible = False Then
            Exit Sub
        End If

        If DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("sourceof_INSERT").Index).Value.ToString = "" Then
            DGV1.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue    'SystemColors.ControlLightLight     
        End If

        Dim ki As Integer = DGV1.Columns("Status").Index
        If e.ColumnIndex = ki AndAlso e.Value IsNot Nothing Then
            'Fetch the value of the second Column.
            Dim sa As String = ""
            If Not e.Value Is System.DBNull.Value Then
                sa = e.Value.ToString.Trim
            End If
            If sa = "" Then
                e.CellStyle.BackColor = Color.White
            ElseIf sa = "0" Then
                e.CellStyle.BackColor = Color.Yellow
            ElseIf sa = "2" Then
                e.CellStyle.BackColor = Color.LimeGreen
            End If
        End If

    End Sub
    Sub srediCell(ByVal dgv As DataGridView, ByVal ime As String, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs)
        If DGV1.Columns(ime) Is Nothing Then Exit Sub
        Dim ki As Integer = DGV1.Columns(ime).Index
        If e.ColumnIndex = ki AndAlso e.Value IsNot Nothing Then
            e.CellStyle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        End If
    End Sub
    Private Sub DGV2_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DGV2.CellFormatting
        If DGV2.Rows.Count = 0 Then
            Exit Sub
        End If
        Dim ki As Integer = DGV2.Columns("statusAnketar").Index
        Dim dgkbr As String = DGV2.Rows(e.RowIndex).Cells(DGV2.Columns("kucni_broj_idcd").Index).Value
        Dim dgkrug As String = DGV2.Rows(e.RowIndex).Cells(DGV2.Columns("krug_idcd").Index).Value
        Dim dgrbrstan As String = DGV2.Rows(e.RowIndex).Cells(DGV2.Columns("rbrstan").Index).Value
        Dim dtStatus As String = DGV2.Rows(e.RowIndex).Cells(DGV2.Columns("statusBoja").Index).Value

        If e.ColumnIndex = ki AndAlso e.Value IsNot Nothing Then
            'Fetch the value of the second Column.
            Dim sa As String = ""
            If Not e.Value Is System.DBNull.Value Then
                sa = e.Value.ToString.Trim
            End If
            'Apply Background color based on value.
            If sa = "0" Then
                e.CellStyle.BackColor = Color.Yellow
            ElseIf sa = "" Then
                e.CellStyle.BackColor = Color.White
                'e.CellStyle.ForeColor = Color.Yellow
            ElseIf sa = "1" Then
                e.CellStyle.BackColor = Color.PaleGreen
                'e.CellStyle.ForeColor = Color.PaleGreen
            ElseIf sa = "2" Then
                e.CellStyle.BackColor = Color.LimeGreen
                ' e.CellStyle.ForeColor = Color.LimeGreen
            ElseIf sa = "3" Then
                e.CellStyle.BackColor = Color.Gainsboro
                'e.CellStyle.ForeColor = Color.Gainsboro
            ElseIf sa = "4" Then
                e.CellStyle.BackColor = Color.Red
                ' e.CellStyle.ForeColor = Color.Red
            End If
        End If

    End Sub
    Private Sub DGV1_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV1.CellMouseDown
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        End If
    End Sub
    Private Sub DGV2_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV2.CellMouseDown
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        End If
    End Sub
    Private Sub DGV3_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV3.CellMouseDown
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        End If
    End Sub


    Sub staviPaneledaBuduClosed()
        PanelPKDorada.Visible = False
        Panel3.Visible = False
        PanelZahtev.Visible = False
        PanelZakazivanjeStana.Visible = False
        PanelNUl.Visible = False
        PanelNapomenaLica.Visible = False
        PanelSpisakUlica.Visible = False
        PanelNapomenaStan.Visible = False
        PanelIzmenaUL.Visible = False

    End Sub
    Private Sub btnResetPK_Click(sender As Object, e As EventArgs) Handles ButtonResetPK.Click

        Dim overlayHandle As ISTFormIsLoading
        overlayHandle = New ISTFormIsLoading(Me, Me.TabControl1.Parent)
        overlayHandle.Show()


        'If Panel3.Visible = True Then
        '    Call Cancel()
        'End If
        'If PanelNUl.Visible = True Then
        '    Call CancelNUL()
        'End If
        Dim mbops As String = atbOps.sselectedValue
        Dim nmbops As String = atbOps.sselectedText
        BtnSvaLica.Tag = ""
        ButtonZakazani.Tag = ""
        Call Reset()
        atbOps.sselectedValue = mbops
        atbOps.sselectedText = nmbops
        atbOps.Text = nmbops
        atbPK.Focus()
        overlayHandle.Close()
    End Sub
    Private Sub btnResetUl_Click(sender As Object, e As EventArgs) Handles ButtonResetUl.Click
        If atbOps.sselectedValue Is Nothing OrElse atbOps.sselectedValue = "" Then
            ISTMessageBox.Show("Ne možete birati ulicu jer nije odabrana opština!")
            Exit Sub
        ElseIf atbPK.sselectedValue Is Nothing OrElse atbPK.sselectedValue = "" Then
            ISTMessageBox.Show("Ne možete birati ulicu jer nije odabran popisni krug!")
            Exit Sub
        End If

        Dim overlayHandle As ISTFormIsLoading
        overlayHandle = New ISTFormIsLoading(Me, Me.TabControl1.Parent)
        overlayHandle.Show()


        'If Panel3.Visible = True Then
        '    Call Cancel()
        'End If
        'If PanelNUl.Visible = True Then
        '    Call CancelNUL()
        'End If
        Dim mbops As String = atbOps.sselectedValue
        Dim nmbops As String = atbOps.sselectedText
        Dim pk As String = atbPK.sselectedValue
        Dim npk As String = atbPK.sselectedText
        BtnSvaLica.Tag = ""
        ButtonZakazani.Tag = ""
        Call Reset()
        ButtonUnosNoveUlice.Visible = True
        PanelIzmenaNazivaNoveUlice.Visible = True
        atbOps.sselectedValue = mbops
        atbOps.sselectedText = nmbops
        atbOps.Text = nmbops
        atbPK.sselectedValue = pk
        atbPK.sselectedText = npk
        atbPK.Text = npk
        Dim strSQl2 As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " +
                                                 " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "'" +
                                                 " union" +
                                                 " select '(*)' as displaymember, '000000000000' as valuemember order by displaymember"
        Call popuniAutbDB(atbUlica, strSQl2)
        atbUlica.Focus()
        overlayHandle.Close()
    End Sub
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click
        'ivanaaaa
        Call praznidgv2()

    End Sub
    'cor do tabcontrole
    Private Sub TabControl1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabControl1.DrawItem

        Dim tabContas As TabControl = DirectCast(sender, TabControl)
        Dim sTexto As String = tabContas.TabPages(e.Index).Text
        Dim g As Graphics = e.Graphics
        Dim fonte As Font = tabContas.Font
        Dim format = New StringFormat
        'CHANGES HERE...
        format.Alignment = StringAlignment.Center
        format.LineAlignment = StringAlignment.Center
        Dim pincel As New SolidBrush(Color.Black)
        ''RENEMED VARIEBLE HERE...
        Dim retangulo As RectangleF = RectangleF.op_Implicit(tabContas.GetTabRect(e.Index))

        If tabContas.SelectedIndex = e.Index Then
            fonte = New Font(fonte, FontStyle.Underline)
            pincel = New SolidBrush(Color.DarkBlue)
            'CHANGED BACKGROUN COLOR HERE...
            g.FillRectangle(Brushes.PaleGreen, retangulo)
        End If
        g.DrawString(sTexto, fonte, pincel, retangulo, format)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If nevena = True Then
            Exit Sub
        End If
        promenaTaba()

    End Sub
    Sub promenaTaba()
        Dim pomrowDGV3 As Integer = -1
        Dim pomrowDGV2 As Integer = -1
        Dim kojistan As String = ""
        If DGV2.Rows.Count > 0 AndAlso DGV3.Rows.Count > 0 Then
            If Not oldtabpage Is Nothing AndAlso oldtabpage Is TabPage3 AndAlso Not newtabpage Is Nothing AndAlso newtabpage Is TabPage2 Then
                If DGV3.SelectedCells.Count > 0 Then

                    pomrowDGV3 = DGV3.SelectedCells.Item(0).RowIndex
                    kojistan = DGV3.Rows(pomrowDGV3).Cells(DGV3.Columns("rbrstan").Index).Value.ToString()
                    For i As Integer = 0 To DGV2.Rows.Count - 1
                        If kojistan.Trim = DGV2.Rows(i).Cells(DGV2.Columns("rbrstan").Index).Value.ToString().Trim Then
                            pomrowDGV2 = i
                            'DGV2.Rows(i).Selected = True
                            Exit For
                        End If
                    Next
                End If
            End If
        ElseIf DGV2.Rows.Count = 0 AndAlso DGV3.Rows.Count = 0 Then
            TabControl1.SelectedTab = TabPage1
        ElseIf DGV2.Rows.Count > 0 AndAlso DGV3.Rows.Count = 0 Then
            If Not oldtabpage Is Nothing AndAlso oldtabpage Is TabPage1 Then
                If TabControl1.SelectedIndex >= 0 AndAlso Not newtabpage Is Nothing AndAlso newtabpage Is TabPage2 Then 'TabControl1.SelectedTab.Name.Trim.ToUpper = "TABPAGE2"
                    TabControl1.SelectedTab = TabPage2
                ElseIf TabControl1.SelectedIndex >= 0 AndAlso Not newtabpage Is Nothing AndAlso newtabpage Is TabPage3 Then 'TabControl1.SelectedTab.Name.Trim.ToUpper = "TABPAGE3"
                    TabControl1.SelectedTab = TabPage1
                End If

            ElseIf Not oldtabpage Is Nothing AndAlso oldtabpage Is TabPage2 Then
                If TabControl1.SelectedIndex >= 0 AndAlso Not newtabpage Is Nothing AndAlso newtabpage Is TabPage1 Then 'TabControl1.SelectedTab.Name.Trim.ToUpper = "TABPAGE1"
                    TabControl1.SelectedTab = TabPage1
                ElseIf TabControl1.SelectedIndex >= 0 AndAlso Not newtabpage Is Nothing AndAlso newtabpage Is TabPage3 Then 'TabControl1.SelectedTab.Name.Trim.ToUpper = "TABPAGE3"
                    TabControl1.SelectedTab = TabPage2
                End If
            End If
        End If


        If TabControl1.SelectedIndex >= 0 AndAlso TabControl1.SelectedTab.Name.Trim.ToUpper = "TABPAGE2" Then 'TabControl1.SelectedIndex = 1
            Call SuspendDrawing(PanelLegendaDGV2)
            ButtonUnosNovogKBR.Enabled = False
            PanelLegendaDGV2.BringToFront()
            PanelLegendaDGV2.Visible = True
            PanelLegendaDGV1.Visible = False
            PanelLegendaDGV3.Visible = False
            If filterDatumZakazan.Tag = "svi" Then
                lblBrojKBR.Text = "Ukupno zakazanih stanova: " + DGV2.Rows.Count.ToString
            Else
                filterDatumZakazan.Text = "*"
                lblBrojKBR.Text = "Ukupno stanova u odabranom kućnom broju: " + DGV2.Rows.Count.ToString
            End If
            If pomrowDGV2 > -1 Then
                DGV2.Focus()
                DGV2.ClearSelection()
                'DGV2.Rows(pomrowDGV2).Selected = True
                If DGV2.Rows.Count - 1 >= pomrowDGV2 Then
                    DGV2.Rows(pomrowDGV2).Selected = True
                Else
                    DGV2.Rows(0).Selected = True
                End If

            End If
            Me.ButtonUnosNovogKBR.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela"
            Call ResumeDrawing(PanelLegendaDGV2)
        ElseIf TabControl1.SelectedIndex >= 0 AndAlso TabControl1.SelectedTab.Name.Trim.ToUpper = "TABPAGE1" Then
            Call SuspendDrawing(PanelLegendaDGV1)
            ButtonUnosNovogKBR.Enabled = True
            PanelLegendaDGV1.BringToFront()
            PanelLegendaDGV1.Visible = True
            PanelLegendaDGV2.Visible = False
            PanelLegendaDGV3.Visible = False
            lblBrojKBR.Text = "Ukupno kućnih brojeva: " + DGV1.Rows.Count.ToString
            Me.ButtonUnosNovogKBR.AccessibleDefaultActionDescription = ""
            Call ResumeDrawing(PanelLegendaDGV1)
        ElseIf TabControl1.SelectedIndex >= 0 AndAlso TabControl1.SelectedTab.Name.Trim.ToUpper = "TABPAGE3" Then
            Call SuspendDrawing(PanelLegendaDGV3)
            ButtonUnosNovogKBR.Enabled = False
            PanelLegendaDGV2.Visible = False
            PanelLegendaDGV1.Visible = False
            PanelLegendaDGV3.BringToFront()
            PanelLegendaDGV3.Visible = True
            If pomrowDGV3 > -1 Then
                DGV3.Focus()
                DGV3.ClearSelection()
                'DGV3.Rows(pomrowDGV3).Selected = True
                If DGV3.Rows.Count - 1 >= pomrowDGV3 Then
                    DGV3.Rows(pomrowDGV3).Selected = True
                Else
                    DGV3.Rows(0).Selected = True
                End If

            End If
            If filterUlicaDGV3.Tag = "svi" Then
                lblBrojKBR.Text = "Ukupno lica: " + DGV3.Rows.Count.ToString
            Else
                lblBrojKBR.Text = "Ukupno lica u odabranom stanu: " + DGV3.Rows.Count.ToString
            End If
            Me.ButtonUnosNovogKBR.AccessibleDefaultActionDescription = "nedirajpriotvaranjuizatvaranjupanela"
            Call ResumeDrawing(PanelLegendaDGV3)
        Else
            PanelLegendaDGV1.Visible = False
            PanelLegendaDGV2.Visible = False
            PanelLegendaDGV3.Visible = False
            lblBrojKBR.Text = ""
            Me.ButtonUnosNovogKBR.AccessibleDefaultActionDescription = ""
        End If

        DGV1.PerformLayout()
        DGV2.PerformLayout()
        DGV3.PerformLayout()
    End Sub


    'Private Sub DGV1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV1.KeyPress
    '    If e.KeyChar = ChrW(13) Then
    '        Dim erowindex As Integer = DGV1.CurrentCell.RowIndex - 1
    '        Dim eColumnIndex As Integer = DGV1.CurrentCell.ColumnIndex

    '        If Not DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value Is System.DBNull.Value AndAlso 
    '                       DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString <> "" Then 
    '            Call Dgv1CellContentClick(erowindex, eColumnIndex)
    '            DGV1.Rows(erowindex).Selected = True
    '            DGV1.CurrentCell = DGV1.Rows(erowindex).Cells(eColumnIndex)
    '            e.Handled = True
    '        Else
    '            ' DGV1.Rows(erowindex).Selected = True
    '        End If

    '    End If
    'End Sub
    'Private Sub DGV1_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV1.KeyDown

    '    Dim erowindex As Integer = DGV1.CurrentCell.RowIndex
    '    Dim eColumnIndex As Integer = DGV1.CurrentCell.ColumnIndex
    '    'Dim pom As String = "Then🏠📝🗑📆🖉🏘"

    '    Dim kolona As Boolean = False
    '    If DGV1.Columns(eColumnIndex).Name.IndexOf("prazno") = 0 Then
    '        kolona = True
    '    End If
    '    If e.KeyCode = Keys.Enter Then
    '        If Not DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value Is System.DBNull.Value AndAlso
    '                       DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString <> "" AndAlso
    '            (DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🏠") >= 0 OrElse
    '            DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("📝") >= 0 OrElse
    '            DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🖉") >= 0 OrElse
    '            DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🏘") >= 0 OrElse
    '            DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🗑") >= 0
    '            ) Then
    '            Call Dgv1CellContentClick(erowindex, eColumnIndex)
    '            DGV1.Rows(erowindex).Selected = True
    '            e.SuppressKeyPress = True
    '        Else
    '            e.SuppressKeyPress = False
    '        End If
    '    ElseIf kolona = True Then
    '        If e.KeyCode = Keys.Right Then
    '            SendKeys.Send("{TAB}")
    '        ElseIf e.KeyCode = Keys.Left Then
    '            SendKeys.Send("{LEFT}")
    '        End If
    '    End If
    'End Sub

    Private Sub DGV1_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV1.KeyDown

        If DGV1.CurrentCell Is Nothing Then
            Exit Sub
        End If

        If DGV1.SelectedRows.Count = 1 AndAlso e.KeyCode = Keys.Right Then
            DGV1.CurrentCell = DGV1.Rows(DGV1.CurrentCell.RowIndex).Cells(0)
            SendKeys.Send("{LEFT}")
            Exit Sub
        End If
        'DGV1.CurrentCell = DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("Status").Index)
        Dim columnCollection As DataGridViewColumnCollection = DGV1.Columns
        Dim lastVisibleColumn As DataGridViewColumn = columnCollection.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.None)
        Dim firstVisibleColumn As DataGridViewColumn = columnCollection.GetFirstColumn(DataGridViewElementStates.Visible)


        Dim erowindex As Integer = DGV1.CurrentCell.RowIndex
        Dim eColumnIndex As Integer = DGV1.CurrentCell.ColumnIndex
        Dim prvadesno As Integer = lastVisibleColumn.Index
        Dim prvalevo As Integer = firstVisibleColumn.Index

        If eColumnIndex <> lastVisibleColumn.Index Then
            For i As Integer = eColumnIndex To lastVisibleColumn.Index - 1
                If DGV1.Columns(i + 1).Visible = True Then
                    prvadesno = i + 1
                    Exit For
                End If
            Next
        End If

        If eColumnIndex <> firstVisibleColumn.Index Then
            For i As Integer = eColumnIndex To firstVisibleColumn.Index Step -1
                If DGV1.Columns(i - 1).Visible = True Then
                    prvalevo = i - 1
                    Exit For
                End If
            Next
        End If

        'Dim pom As String = "🏠📝🗑📆🖉🏘"

        Dim kolonaDesno As Boolean = False
        Dim kolonaLevo As Boolean = False
        If eColumnIndex < lastVisibleColumn.Index AndAlso DGV1.Columns(prvadesno).Name.IndexOf("prazno") = 0 Then
            kolonaDesno = True
        End If
        If eColumnIndex > firstVisibleColumn.Index AndAlso DGV1.Columns(prvalevo).Name.IndexOf("prazno") = 0 Then
            kolonaLevo = True
        End If
        If e.KeyCode = Keys.Enter Then
            If Not DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value Is System.DBNull.Value AndAlso
                            DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString <> "" AndAlso
                (DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🏠") >= 0 OrElse
                DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("📝") >= 0 OrElse
                DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🖉") >= 0 OrElse
                DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🏘") >= 0 OrElse
                DGV1.Rows(erowindex).Cells(DGV1.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🗑") >= 0
                ) Then
                Call Dgv1CellContentClick(erowindex, eColumnIndex)
                DGV1.ClearSelection()
                'DGV1.Rows(erowindex).Selected = True
                If DGV1.Rows.Count - 1 >= erowindex Then
                    DGV1.Rows(erowindex).Selected = True
                Else
                    DGV1.Rows(0).Selected = True
                End If
                e.SuppressKeyPress = True
            Else
                e.SuppressKeyPress = False
            End If
        ElseIf kolonaDesno = True AndAlso e.KeyCode = Keys.Right Then
            SendKeys.Send("{TAB}")
        ElseIf kolonaLevo = True AndAlso e.KeyCode = Keys.Left Then
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub DGV2_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV2.KeyDown
        If DGV2.CurrentCell Is Nothing Then
            Exit Sub
        End If
        Dim erowindex As Integer = DGV2.CurrentCell.RowIndex
        Dim eColumnIndex As Integer = DGV2.CurrentCell.ColumnIndex
        'Dim pom As String = "👪🖉🖐"

        If e.KeyCode = Keys.Enter Then
            If Not DGV2.Rows(erowindex).Cells(DGV2.Columns(eColumnIndex).Index).Value Is System.DBNull.Value AndAlso
                            DGV2.Rows(erowindex).Cells(DGV2.Columns(eColumnIndex).Index).Value.ToString <> "" AndAlso
                (DGV2.Rows(erowindex).Cells(DGV2.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🏦👪") >= 0 OrElse
                DGV2.Rows(erowindex).Cells(DGV2.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🖐") >= 0 OrElse
                DGV2.Rows(erowindex).Cells(DGV2.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🖉") >= 0
                ) Then
                Call Dgv2CellContentClick(erowindex, eColumnIndex)
                DGV2.ClearSelection()
                'DGV2.Rows(erowindex).Selected = True
                If DGV2.Rows.Count - 1 >= erowindex Then
                    DGV2.Rows(erowindex).Selected = True
                Else
                    DGV2.Rows(0).Selected = True
                End If

                e.SuppressKeyPress = True
            Else
                e.SuppressKeyPress = False
            End If
        End If
    End Sub
    Private Sub DGV3_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV3.KeyDown
        If DGV3.CurrentCell Is Nothing Then
            Exit Sub
        End If
        Dim erowindex As Integer = DGV3.CurrentCell.RowIndex
        Dim eColumnIndex As Integer = DGV3.CurrentCell.ColumnIndex
        'Dim pom As String = "👪🖉🖐"

        If e.KeyCode = Keys.Enter Then
            If Not DGV3.Rows(erowindex).Cells(DGV3.Columns(eColumnIndex).Index).Value Is System.DBNull.Value AndAlso
                            DGV3.Rows(erowindex).Cells(DGV3.Columns(eColumnIndex).Index).Value.ToString <> "" AndAlso
                (DGV3.Rows(erowindex).Cells(DGV3.Columns(eColumnIndex).Index).Value.ToString.IndexOf("👪") >= 0 OrElse
                 DGV3.Rows(erowindex).Cells(DGV3.Columns(eColumnIndex).Index).Value.ToString.IndexOf("🖉") >= 0
                ) Then
                Call Dgv3CellContentClick(erowindex, eColumnIndex)
                DGV3.ClearSelection()
                'DGV3.Rows(erowindex).Selected = True
                If DGV3.Rows.Count - 1 >= erowindex Then
                    DGV3.Rows(erowindex).Selected = True
                Else
                    DGV3.Rows(0).Selected = True
                End If

                e.SuppressKeyPress = True
            Else
                e.SuppressKeyPress = False
            End If
        End If
    End Sub
    Private Sub DGV2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV2.CellContentClick
        If e.ColumnIndex <> DGV2.Columns("OOPEN2").DisplayIndex AndAlso e.ColumnIndex <> DGV2.Columns("EEDIT").DisplayIndex AndAlso e.ColumnIndex <> DGV2.Columns("EEditNapomena").DisplayIndex AndAlso e.ColumnIndex <> DGV2.Columns("OOPEN3").DisplayIndex AndAlso e.ColumnIndex <> DGV2.Columns("deleteIZStana").DisplayIndex Then
            Exit Sub
        End If
        If TabControl1.Tag = "disabled" Then
            Exit Sub
        End If
        nevena = True
        Call Dgv2CellContentClick(e.RowIndex, e.ColumnIndex)
        nevena = False
    End Sub


    Sub Dgv2CellContentClick(ByVal erowindex As Integer, ByVal eColumnIndex As Integer)

        Me.Cursor = Cursors.WaitCursor
        If erowindex >= 0 Then
            PanelZakazivanjeStana.Tag = Nothing
            Dim pomrowDGV1 As Integer = vratiSelektvanRedDGV1(erowindex)
            If PanelZakazivanjeStana.Tag Is Nothing Then
                PanelZakazivanjeStana.Tag = erowindex
            End If

            If DGV2.Columns(eColumnIndex).DisplayIndex <> DGV2.Columns("OOPEN2").DisplayIndex AndAlso DGV2.Columns(eColumnIndex).DisplayIndex <> DGV2.Columns("EEDIT").DisplayIndex AndAlso DGV2.Columns(eColumnIndex).DisplayIndex <> DGV2.Columns("EEditNapomena").DisplayIndex AndAlso DGV2.Columns(eColumnIndex).DisplayIndex <> DGV2.Columns("OOPEN3").DisplayIndex AndAlso DGV2.Columns(eColumnIndex).DisplayIndex <> DGV2.Columns("deleteIZStana").DisplayIndex Then
                Exit Sub
            End If


            If DGV2.Columns(eColumnIndex).DisplayIndex = DGV2.Columns("OOPEN2").DisplayIndex Then
                DGV2.ClearSelection()
                'DGV2.Rows(erowindex).Selected = True
                If DGV2.Rows.Count - 1 >= erowindex Then
                    DGV2.Rows(erowindex).Selected = True
                Else
                    DGV2.Rows(0).Selected = True
                End If

                Dim zzak As Boolean = False
                Dim red As Integer = erowindex
                Dim kolona As Integer = eColumnIndex
                Dim tabela As String = "P2_STAN"

                Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, "")
                If zak = 1 Then zzak = True

                Dim zakljucanOdmahSve As Boolean = False
                If DGV2.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "2" OrElse DGV2.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "3" Then
                    zakljucanOdmahSve = True
                ElseIf DGV2.Rows(erowindex).Cells("statusAnketar").Value.ToString.Trim = "1" Then
                    Dim msgtxt As String = "Ovaj stan je kompletiran i spreman za slanje. " + nvrd + "Ulaskom u upitnik za stan poništiće se status i moraćete ponovo da obeležite da je upitnik spreman za slanje." + nvrd + "Da li hoćete da nastavite?"
                    ''videti šta ako postoje podaci!!!!! NISTA, NIJE DOZVOLJENO
                    Dim msgtitle As String = "............"

                    Dim opc As String = customDialogResult({"Yes", "No"}, msgtxt, msgtitle)
                    Select Case opc
                        Case "Yes"

                        Case "No"
                            Me.Cursor = Cursors.Default
                            Exit Sub
                    End Select


                End If

                'If DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("QC").Index).Value.ToString <> "" AndAlso
                '         DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("Poslat").Index).Value.ToString <> "" Then
                '    zakljucanOdmahSve = True
                'End If

                Dim KljuceviGlavna() As String = DajKljuceve(tabela)
                Dim KljuceviGlavnaSaVrednostima(,) As String
                ReDim KljuceviGlavnaSaVrednostima(KljuceviGlavna.GetUpperBound(0), 1)
                For i As Integer = 0 To KljuceviGlavna.GetUpperBound(0)
                    KljuceviGlavnaSaVrednostima(i, 0) = KljuceviGlavna(i).Trim.ToUpper
                    KljuceviGlavnaSaVrednostima(i, 1) = DGV2.Rows(erowindex).Cells(KljuceviGlavna(i).Trim.ToUpper).Value
                Next



                Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   True, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,
                                   KljuceviGlavnaSaVrednostima,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Nothing,,,, dosaoIzCapiAdresara)
                Try
                    frm.ShowDialog()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Finally
                    frm.Dispose()
                End Try
            End If

            If DGV2.Columns(eColumnIndex).DisplayIndex = DGV2.Columns("EEDIT").DisplayIndex Then
                Call Promena2(erowindex)
            End If
            If DGV2.Columns(eColumnIndex).DisplayIndex = DGV2.Columns("EEditNapomena").DisplayIndex Then
                Call OtvoriNapomenu(erowindex)
            End If
            If DGV2.Columns(eColumnIndex).DisplayIndex = DGV2.Columns("OOPEN3").DisplayIndex Then
                Call ZahtevZaDoradu(erowindex, pomrowDGV1)
            End If

            If DGV2.Columns(eColumnIndex).DisplayIndex = DGV2.Columns("deleteIZStana").DisplayIndex Then
                Call BrisanjeMaterijalaZaStan(erowindex)
                'erowindex = erowindex - 1
            End If

            'Call refreshDGV1()
            Dim pomocna As String = ""
            If Not filterStatus Is Nothing Then
                pomocna = filterStatus.Text
                If pomocna.Length > 0 AndAlso pomocna <> "" Then pomocna = pomocna.Substring(0, 1)
                If pomocna = "*" Then pomocna = ""
            End If
            refreshDGV1(filterUlica.Text, pomocna, filterUlicaMapa.Text, filterNapomenaKBR.Text)

            If DGV1.Rows.Count > 0 Then
                DGV1.ClearSelection()
                'DGV1.Rows(pomrowDGV1).Selected = True
                If DGV1.Rows.Count - 1 >= pomrowDGV1 Then
                    DGV1.Rows(pomrowDGV1).Selected = True
                Else
                    DGV1.Rows(0).Selected = True
                End If

            End If

            If filterDatumZakazan.Tag = "svi" Then
                refreshdgv2zakazni()
                If DGV2.Rows.Count > 0 Then
                    DGV2.ClearSelection()
                    ' DGV2.Rows(erowindex).Selected = True
                    If DGV2.Rows.Count - 1 >= erowindex Then
                        DGV2.Rows(erowindex).Selected = True
                    Else
                        DGV2.Rows(0).Selected = True
                    End If

                End If
            Else
                Call refreshDGV2(pomrowDGV1)
                If DGV2.Rows.Count > 0 Then
                    DGV2.ClearSelection()
                    'DGV2.Rows(erowindex).Selected = True
                    If DGV2.Rows.Count - 1 >= erowindex Then
                        DGV2.Rows(erowindex).Selected = True
                    Else
                        DGV2.Rows(0).Selected = True
                    End If


                End If
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Function vratiSelektvanRedDGV1(ByVal erowindex As Integer) As Integer
        Dim pomrowDGV1 As Integer = 0
        If filterUlicaDGV3.Tag = "svi" Then
            Return pomrowDGV1
            Exit Function
        End If
        If DGV1.SelectedCells.Count > 0 Then
            pomrowDGV1 = DGV1.SelectedCells.Item(0).RowIndex
        Else
            Dim kojimbops As String = DGV2.Rows(erowindex).Cells(DGV2.Columns("mbops").Index).Value.ToString()
            Dim kojikrug As String = DGV2.Rows(erowindex).Cells(DGV2.Columns("krug_idcd").Index).Value.ToString()
            Dim kojikbr As String = DGV2.Rows(erowindex).Cells(DGV2.Columns("kucni_broj_idcd").Index).Value.ToString()
            For i As Integer = 0 To DGV1.Rows.Count - 1
                If kojimbops.Trim = DGV1.Rows(i).Cells(DGV1.Columns("mbops").Index).Value.ToString().Trim AndAlso kojikrug.Trim = DGV1.Rows(i).Cells(DGV1.Columns("krug_idcd").Index).Value.ToString().Trim AndAlso kojikbr.Trim = DGV1.Rows(i).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString().Trim Then
                    pomrowDGV1 = i
                    'DGV2.Rows(i).Selected = True
                    Exit For
                End If
            Next
        End If
        Return pomrowDGV1
    End Function

    Sub OtvoriNapomenu(ByVal selectedRow As Integer)
        DGV2.ClearSelection()
        DGV2.Rows(selectedRow).Selected = True
        Dim si As Integer = DGV2.SelectedRows(0).Index
        Dim napomenastan As String = DGV2.Rows(si).Cells(DGV2.Columns("napomenaostanu").Index).Value.ToString.Trim
        Call pNapomenaNonVisible()
        PanelNapomenaStan.Tag = selectedRow
        txtNapomenaStan.Text = napomenastan
        txtUlicaNapomena.Text = DGV2.Rows(si).Cells(DGV2.Columns("ulica").Index).Value.ToString + " " + DGV2.Rows(si).Cells(DGV2.Columns("kbroj").Index).Value.ToString
        txtKBrojNapomena.Text = DGV2.Rows(si).Cells(DGV2.Columns("kbroj").Index).Value.ToString
        txtRbrStanNapomena.Text = DGV2.Rows(si).Cells(DGV2.Columns("rbrstan").Index).Value.ToString
        txtBrojStanaVrataNapomena.Text = DGV2.Rows(si).Cells(DGV2.Columns("BrojStana").Index).Value.ToString


        txtkucni_broj_idCDNapomena.Text = DGV2.Rows(si).Cells(DGV2.Columns("kucni_broj_idCD").Index).Value.ToString
        txtkrug_idCDNapomena.Text = DGV2.Rows(si).Cells(DGV2.Columns("krug_idCD").Index).Value.ToString
        txtKBrojNapomena.Visible = False
        Call pNapomenaVisible()



    End Sub

    Dim staravrNapomeneLica As String = ""
    Sub OtvoriNapomenuDGV3(ByVal selectedRow As Integer)

        DGV3.ClearSelection()
        DGV3.Rows(selectedRow).Selected = True

        Dim si As Integer = DGV3.SelectedRows(0).Index
        Dim napomenalica As String = DGV3.Rows(si).Cells(DGV3.Columns("napomena").Index).Value.ToString.Trim

        Call panelNapomenaLicaNonVisible()


        PanelNapomenaLica.Tag = selectedRow


        TxtNapomenaLica.Text = napomenalica
        staravrNapomeneLica = napomenalica
        TxtUlicaKbrNapomenaLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("ulicakbroj").Index).Value.ToString
        TxtRbrStNapomenaLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("rbrstan").Index).Value.ToString
        TxtRbrStVrataNapomenaLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("BrojStana").Index).Value.ToString
        TxtRbrDomNapomenaLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("Rbrdom").Index).Value.ToString
        TxtRBrLicaNapomenaLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("Rbrp1").Index).Value.ToString
        TxtImeNapomenaLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("imeprezimecelo").Index).Value.ToString


        TxtKbrIDCDLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("kucni_broj_idCD").Index).Value.ToString
        TxtKrugIDCDLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("krug_idCD").Index).Value.ToString
        TxtMBOPSLica.Text = DGV3.Rows(si).Cells(DGV3.Columns("mbops").Index).Value.ToString
        TxtIDULICELica.Text = DGV3.Rows(si).Cells(DGV3.Columns("idulice").Index).Value.ToString

        If DGV3.Rows(si).Cells(DGV3.Columns("UklonitiLice").Index).Value.ToString = "1" Then
            cbUklonitiIzMaterijala.Checked = True
        Else
            cbUklonitiIzMaterijala.Checked = False
        End If
        cmbRazlogUklanjanja.Text = DGV3.Rows(si).Cells(DGV3.Columns("UklonitiLiceRazlog").Index).Value.ToString
        tboxObjasnjenjeUklanjanja.Text = DGV3.Rows(si).Cells(DGV3.Columns("UklonitiLiceObjasnjenje").Index).Value.ToString

        Call panelNapomenaLicaVisible(selectedRow)

    End Sub

    Dim zapamceniStatusanketar As String = ""
    Sub ZahtevZaDoradu(ByVal selectedRow As Integer, ByVal selectedRowDGV1 As Integer)

        lblkojikont.Text = "Zahtev će biti prosleđen instruktoru: "
        lblkojikont.Visible = False
        DGV2.ClearSelection()
        DGV2.Rows(selectedRow).Selected = True

        Dim si As Integer = DGV2.SelectedRows(0).Index
        Dim dgvStatusAnketar As String = DGV2.Rows(si).Cells(DGV2.Columns("statusanketar").Index).Value.ToString.Trim

        Call pZahNonVisible()

        zapamceniStatusanketar = dgvStatusAnketar
        PanelZahtev.Tag = selectedRow

        If dgvStatusAnketar = "3" Then cbZahtev.Checked = True
        Dim pomMBOPS As String = DGV2.Rows(si).Cells(DGV2.Columns("mbops").Index).Value.ToString
        Dim pomKrug_IDCD As String = DGV2.Rows(si).Cells(DGV2.Columns("krug_idcd").Index).Value.ToString
        txtUlicaZahtev.Text = DGV2.Rows(si).Cells(DGV2.Columns("ulica").Index).Value.ToString + " " + DGV2.Rows(si).Cells(DGV2.Columns("kbroj").Index).Value.ToString
        txtKBrojZahtev.Text = DGV2.Rows(si).Cells(DGV2.Columns("kbroj").Index).Value.ToString
        txtRbrStanZahtev.Text = DGV2.Rows(si).Cells(DGV2.Columns("rbrstan").Index).Value.ToString
        txtBrojStanaVratazahtev.Text = DGV2.Rows(si).Cells(DGV2.Columns("BrojStana").Index).Value.ToString
        tboxNapomenaStatusAnketar.Text = DGV2.Rows(si).Cells(DGV2.Columns("napomenaStatusAnketar").Index).Value.ToString

        txtkucni_broj_idCDZahtev.Text = DGV2.Rows(si).Cells(DGV2.Columns("kucni_broj_idCD").Index).Value.ToString

        '''''PROVERITI da li moze na jednom krugidcd za istog anketara da budu dva instruktora
        Dim strkojikont As String = "select top 1 Imeinstruktor from Obrnuta_Veza_Ucesnici_PK where mbops='" + pomMBOPS + "' and krug_idcd='" + pomKrug_IDCD + "' and Popisivac=N'" + kosam + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(strkojikont, Me.DBConnectionString, Me.jezik)
        If dt.Rows.Count > 0 Then
            Dim imekont As String = dt.Rows(0).Item(0)
            lblkojikont.Text = lblkojikont.Text + " " + imekont
            lblkojikont.Visible = True
        Else
            lblkojikont.Visible = False
        End If


        Call pZahVisible()

    End Sub
    'Sub refreshDGV22(Optional ByVal erowindex As Integer = -1)
    '    'case when isnull(sss.QC,'')='' then N'' else N'✔' end as QC,case when isnull(sss.CapiExported,'')='' then N'' else N'✔' end as Poslat,'
    '    Dim dt As DataTable

    '    Dim str As String = ""
    '    If erowindex >= 0 Then
    '        Dim pkucni_broj_idCD As String = DGV2.Rows(erowindex).Cells(DGV2.Columns("kucni_broj_idCD").Index).Value.ToString
    '        str = dajSQLzaDGV2(nizACTB(0).sselectedValue.Trim, nizACTB(1).sselectedValue.Trim, pkucni_broj_idCD)
    '        DGV2.Visible = True
    '        'PanelLegendaDGV2.Visible = True
    '    Else
    '        str = "select * from p2_objekat where 2=3"
    '        DGV2.Visible = False
    '    End If

    '    dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)

    '    DGV2.DataSource = dt
    '    dtOrig = dt

    'End Sub

    'Private Sub DGV2_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV2.RowHeaderMouseDoubleClick
    '    If e.RowIndex >= 0 Then
    '        DGV2.Rows(e.RowIndex).Selected = True
    '        Dim selectedRowCount As Integer = DGV2.Rows.GetRowCount(DataGridViewElementStates.Selected)
    '        Dim selectedRow As Integer = e.RowIndex
    '        Call Promena2(selectedRow)
    '    End If

    'End Sub
    '''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub dgv2_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DGV2.DataBindingComplete
        For Each r As DataGridViewRow In DGV2.Rows

            If r.Cells("OOpen2").Value = "P2_Stan" Then
                r.Cells("OOpen2") = New DataGridViewLinkCell()
                Call formatLLCell(r.Cells("OOpen2"))
            End If

            r.Cells("EEdit") = New DataGridViewLinkCell()
            Call formatLLCell(r.Cells("EEdit"))

            'r.Cells("DDelete") = New DataGridViewLinkCell()
            'Call formatLLCell(r.Cells("DDelete"))
        Next
        DGV2.ClearSelection()
    End Sub

    Private Sub dgv3_DataBindingComplete(ByVal sender As Object, ByVal e As DataGridViewBindingCompleteEventArgs) Handles DGV3.DataBindingComplete
        For Each r As DataGridViewRow In DGV3.Rows

            If r.Cells("OOpenStan").Value = "P2_Stan" Then
                r.Cells("OOpenStan") = New DataGridViewLinkCell()
                Call formatLLCell(r.Cells("OOpenStan"))
            End If

            r.Cells("EEditNapomena") = New DataGridViewLinkCell()
            Call formatLLCell(r.Cells("EEditNapomena"))

            'r.Cells("DDelete") = New DataGridViewLinkCell()
            'Call formatLLCell(r.Cells("DDelete"))
        Next
        DGV3.ClearSelection()
    End Sub

    Sub falsesvisem(ByVal cb As CheckBox, ByVal cTag As Integer)
        For Each c As Control In PanelZakazivanjeStana.Controls
            If TypeOf c Is CheckBox AndAlso c.Tag = cTag Then
                If c.Name <> cb.Name Then
                    DirectCast(c, CheckBox).Checked = False
                End If
            End If
        Next
    End Sub

    Private Sub txtBrojStanaVrata_Leave(sender As Object, e As EventArgs) Handles txtBrojStanaVrata.Leave
        If Me.txtBrojStanaVrata.Text.Trim = "" Then
            Me.lblBrojStanaVrataPoruka.Visible = True
        Else
            Me.lblBrojStanaVrataPoruka.Visible = False
        End If
    End Sub
    Private Sub cbDolazak_CheckedChanged(sender As Object, e As EventArgs) Handles cbDolazak.CheckedChanged
        If cbDolazak.Checked = True Then
            cbTelefon.Checked = False
        End If
    End Sub
    Private Sub cbTelefon_CheckedChanged(sender As Object, e As EventArgs) Handles cbTelefon.CheckedChanged
        If cbTelefon.Checked = True Then
            cbDolazak.Checked = False
            txtBrojTelefona.Focus()
        End If
    End Sub
    Dim cboIndexNaEnter As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call pZakazivanjeStanaNonVisible()
        DGV2.Focus()
    End Sub
    Private Sub ButtonCancelZahtev_Click(sender As Object, e As EventArgs) Handles ButtonCancelZahtev.Click
        Call pZahNonVisible()
        DGV2.Focus()
    End Sub
    Private Sub ButtonCancelNapomenaStan_Click(sender As Object, e As EventArgs) Handles btnCancelNapomenaStan.Click
        Call pNapomenaNonVisible()
        DGV2.Focus()
    End Sub

    Private Sub ButtonZahtev_Click(sender As Object, e As EventArgs) Handles ButtonZahtev.Click

        If cbZahtev.Checked = False AndAlso tboxNapomenaStatusAnketar.Text.Trim <> "" Then
            ISTMessageBox.Show("Morate čekirati da želite da zatražite zahtev za doradu!")
            cbZahtev.Focus()
            Exit Sub
        End If

        Dim vred As String = txtkucni_broj_idCDZahtev.Text.Trim
        Dim vred2 As String = zapamceniStatusanketar
        If cbZahtev.Checked = True Then vred2 = "3" Else vred2 = "2" 'zapamceniStatusanketar

        If vred2 = "3" AndAlso tboxNapomenaStatusAnketar.Text.Trim = "" Then
            ISTMessageBox.Show("Razlog ne sme biti prazan!")
            tboxNapomenaStatusAnketar.Focus()
            Exit Sub
        ElseIf vred2 = "2" Then
            tboxNapomenaStatusAnketar.Text = ""
        End If
        Dim strSQL As String = ""
        Dim strproverastatusa As String = "select isnull(statusanketar,0) from adresar " + nvrd +
                                        " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCDZahtev.Text + "' and rbrstan='" + Me.txtRbrStanZahtev.Text + "'" + nvrd +
                                        " and krug_idcd='" + atbPK.sselectedValue.Trim + "' and mbops='" + atbOps.sselectedValue.Trim + "'"
        Dim dtproverastatusa As DataTable = izvrsiSQLvratiDT(strproverastatusa, Me.DBConnectionString, Me.jezik)
        If dtproverastatusa.Rows.Count > 0 Then
            If dtproverastatusa.Rows(0).Item(0).ToString.Trim = "3" Then
                strSQL = " update adresar " + vbCrLf +
                               " set statusanketar=" + vred2.Trim + ", date_update=getdate(), user_update=N'" + kosam + "'," + vbCrLf +
                               " USER_statusAnketar='" + kosam + "', " + vbCrLf +
                               " napomenaStatusAnketar=N'" + tboxNapomenaStatusAnketar.Text + "' " + vbCrLf +
                               " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCDZahtev.Text + "' and rbrstan='" + Me.txtRbrStanZahtev.Text + "'" + nvrd +
                               " and krug_idcd='" + atbPK.sselectedValue.Trim + "' and mbops='" + atbOps.sselectedValue.Trim + "'"
            Else
                strSQL = " update adresar " + vbCrLf +
                               " set statusanketar=" + vred2.Trim + ", date_update=getdate(), user_update=N'" + kosam + "'," + vbCrLf +
                               " DATE_statusAnketar='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', USER_statusAnketar='" + kosam + "', " + vbCrLf +
                               " napomenaStatusAnketar=N'" + tboxNapomenaStatusAnketar.Text + "' " + vbCrLf +
                               " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCDZahtev.Text + "' and rbrstan='" + Me.txtRbrStanZahtev.Text + "'" + nvrd +
                               " and krug_idcd='" + atbPK.sselectedValue.Trim + "' and mbops='" + atbOps.sselectedValue.Trim + "'"
            End If
        End If

        'Dim strSQL As String = " update adresar " + vbCrLf +
        '                   " set statusanketar=" + vred2.Trim + ", date_update=getdate(), user_update=N'" + kosam + "'," + vbCrLf +
        '                   " DATE_statusAnketar='" + Date.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', USER_statusAnketar='" + kosam + "', " + vbCrLf +
        '                   " napomenaStatusAnketar=N'" + tboxNapomenaStatusAnketar.Text + "' " + vbCrLf +
        '                   " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCDZahtev.Text + "' and rbrstan='" + Me.txtRbrStanZahtev.Text + "'" + nvrd +
        '                   " and krug_idcd='" + atbPK.sselectedValue.Trim + "' and mbops='" + atbOps.sselectedValue.Trim + "'"
        'USER_statusAnketar
        'DATE_statusAnketar
        'napomenaStatusAnketar
        Dim ok As String = izvrsiSQL(strSQL, Me.DBConnectionString)
        If ok <> "ok" Then
            ISTMessageBox.Show("Greska 1! Zovite administratora!")
            Me.Close()
            Exit Sub
        End If

        Dim pomrowDGV1 As Integer = vratiSelektvanRedDGV1(PanelZakazivanjeStana.Tag)
        'Call refreshDGV1()
        'If DGV1.Rows.Count > 0 Then
        '    DGV1.ClearSelection()
        '    DGV1.Rows(pomrowDGV1).Selected = True
        'End If
        If filterDatumZakazan.Tag = "svi" Then
            refreshdgv2zakazni()
        Else
            Call refreshDGV2(pomrowDGV1)
            If DGV2.Rows.Count > 0 Then
                DGV2.ClearSelection()
                'DGV2.Rows(PanelZakazivanjeStana.Tag).Selected = True
                If DGV2.Rows.Count - 1 >= PanelZakazivanjeStana.Tag Then
                    DGV2.Rows(PanelZakazivanjeStana.Tag).Selected = True
                Else
                    DGV2.Rows(0).Selected = True
                End If
            End If
        End If

        Call pZahNonVisible()
    End Sub

    Private Sub ButtonNapomenaOStanuOK_Click(sender As Object, e As EventArgs) Handles btnOKNapomenaStan.Click

        Dim vred As String = txtNapomenaStan.Text.Trim

        If vred = "" Then
            ISTMessageBox.Show("Napomena ne sme biti prazna!")
            txtNapomenaStan.Focus()
            Exit Sub
        End If

        Dim strSQL As String = " update adresar " + vbCrLf +
                               " set date_update=getdate(), user_update=N'" + kosam + "'," + vbCrLf +
                               " napomenaOStanu=N'" + txtNapomenaStan.Text + "' " + vbCrLf +
                               " where IDANKETAR=N'" + kosam + "' and kucni_broj_idCD='" + Me.txtkucni_broj_idCDNapomena.Text + "' and krug_idcd=" +
                               Me.txtkrug_idCDNapomena.Text.Trim + " and rbrstan='" + Me.txtRbrStanNapomena.Text + "'"


        Dim ok As String = izvrsiSQL(strSQL, Me.DBConnectionString)
        If ok <> "ok" Then
            ISTMessageBox.Show("Greška 2! Zovite administratora!")
            Me.Close()
            Exit Sub
        End If

        Dim pomrowDGV1 As Integer = vratiSelektvanRedDGV1(PanelNapomenaStan.Tag)
        'Call refreshDGV1()
        'If DGV1.Rows.Count > 0 Then
        '    DGV1.ClearSelection()
        '    DGV1.Rows(pomrowDGV1).Selected = True
        'End If

        If filterDatumZakazan.Tag = "svi" Then
            refreshdgv2zakazni()
        Else
            Call refreshDGV2(pomrowDGV1)
        End If
        If DGV2.Rows.Count > 0 Then
            DGV2.ClearSelection()
            'DGV2.Rows(PanelNapomenaStan.Tag).Selected = True
            If DGV2.Rows.Count - 1 >= PanelNapomenaStan.Tag Then
                DGV2.Rows(PanelNapomenaStan.Tag).Selected = True
            Else
                DGV2.Rows(0).Selected = True
            End If
        End If
        Call pNapomenaNonVisible()
    End Sub

    Private Sub ButtonIzlaz_Click(sender As Object, e As EventArgs) Handles ButtonIzlaz.Click
        If Panel3.Visible = True Then
            Call Cancel()
        End If
        If PanelNUl.Visible = True Then
            Call CancelNUL()
        End If
        Me.Close()
    End Sub

    Private Sub kucnibrojeviMapaBojenje()


        Dim opstina As String = atbOps.sselectedValue.Trim
        Dim krug As String = atbPK.sselectedValue.Trim

        Dim FileName = "IndikatorKBR.txt" ' The Name of file with its Extension Example A.txt or A.xml

        Dim FilePath = "C:\IST\QGIS\Popis_21\" + opstina & "\" & FileName  'First Name of Directory and Then Name of Folder if it exists and then attach the name of file you want to search.

        If System.IO.File.Exists(FilePath) Then
            If opstina.Trim <> "" AndAlso krug.Trim <> "" Then
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorKBR.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorNKBR.txt", "", False)

                Dim str As String = dodatak + " select distinct * from (select distinct cast(left(a.kucni_broj_idcd,12) as bigint) kucnibroj," + nvrd +
                                    " (case when isnull(b.adresateren,0)=0 then '99' " + nvrd +
                                    " when isnull(b.adresateren,0) Not in (0,4) And isnull(vrstazgrade,0)=0 then '0' " + nvrd +
                                    " when isnull(b.adresateren,0) Not in (0,4) And isnull(vrstazgrade,0) Not in (5,6) " + nvrd +
                                    " And isnull(b.brojstanova,9999)<> (select count(*) from p2_stan a where a.mbops=b.mbops And a.kucni_broj_idCD=b.kucni_broj_idCD " + nvrd +
                                    " And a.KRUG_IDCD=b.KRUG_IDCD And a.mbops=b.mbops And a.qc=1)" + nvrd +
                                    " And ((isnull(vrstazgrade,0)=4 And isnull(b.brojstanova,9999)<>0) Or (isnull(vrstazgrade,0) in (1,2,3))) then '0'" + nvrd +
                                    " when isnull(b.adresateren,0)=4 Or isnull(vrstazgrade,0) in (5,6) Or (isnull(vrstazgrade,0)=4 And isnull(b.brojstanova,9999)=0) Or " + nvrd +
                                    " isnull(b.brojstanova, 9999) = (select count(*) from p2_stan a where a.mbops=b.mbops And a.kucni_broj_idCD=b.kucni_broj_idCD And a.KRUG_IDCD=b.KRUG_IDCD And a.qc=1)" + nvrd +
                                    " then '2' end) as Status, a.mbops, a.krug_idcd, a.sourceof_insert, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else  a.kBroj end),1), 1, CONVERT(varbinary, @Hash)))))  as kbroj, a.idanketar " + nvrd +
                                    " from (Select * from adresar where  mbops='" + opstina + "') a left join " + nvrd +
                                    " p2_objekat b on a.krug_idcd=b.krug_idcd And a.kucni_broj_idcd=b.kucni_broj_idcd " + nvrd +
                                    " where a.mbops ='" + opstina + "' " + nvrd +
                                    " ) aaa  where  aaa.mbops='" + opstina + "' and aaa.krug_idcd='" + krug + "' and aaa.idanketar='" + kosam + "'"

                Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
                Dim aa As String = ""
                Dim bb As String = ""
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item(4).ToString.Trim <> "ANK" Then
                        aa = aa + dt.Rows(i).Item(0).ToString.Trim + "$" + dt.Rows(i).Item(1).ToString.Trim + ";" + nvrd
                    Else
                        bb = bb + dt.Rows(i).Item(5).ToString.Trim + "#" + dt.Rows(i).Item(6).ToString.Trim + "$" + dt.Rows(i).Item(1).ToString.Trim + ";" + nvrd
                    End If

                Next
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorKBR.txt", "" + aa.Trim + "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorNKBR.txt", "" + bb.Trim + "", False)
            Else
                ISTMessageBox.Show("Morate izabrati opštinu i popisni krug.")
            End If
        End If


    End Sub


    'Private Sub DGV1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellClick
    '    If TabControl1.Tag = "disabled" Then
    '        Exit Sub
    '    End If
    '    If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
    '        Dim pom As String = DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("idulice").Index).Value.ToString
    '        Dim pom2 As String = DGV1.Rows(e.RowIndex).Cells(DGV1.Columns("ulica").Index).Value.ToString
    '        Call refreshDGV2(e.RowIndex)
    '    End If
    'End Sub

    Sub pp_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tbox As TextBox = DirectCast(sender, TextBox)
        If tbox.Multiline = True Then tbox.Select(tbox.Text.Length, 0)
    End Sub
    Private Sub pp_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)

        Dim tbox As TextBox = DirectCast(sender, TextBox)
        Dim p As Object = tbox.Parent
        Select Case e.KeyCode
            Case Keys.Up
                Dim k As Control = fKeysUp(tbox.TabIndex, tbox.Parent)
                If Not k Is Nothing Then k.Focus()
                e.SuppressKeyPress = True
                'SendKeys.Send("+{TAB}")
            Case Keys.Down
                Dim k As Control = fKeysDown(tbox.TabIndex, tbox.Parent)
                If Not k Is Nothing Then k.Focus()
                e.SuppressKeyPress = True
            Case Else
        End Select

        If e.Control AndAlso e.KeyCode = Keys.V Then
            'do paste
            tbox.SelectedText = Clipboard.GetText()
            e.SuppressKeyPress = True
        End If

        Dim pom As String = "tboxNapomena,tboxNapomenaZak,TextBoxRazlog,TxtIshodNapomena,txtNapomenaStan"

        If e.Alt AndAlso e.KeyCode = Keys.Enter And pom.IndexOf(tbox.Name) >= 0 Then
            tbox.SelectionStart = tbox.SelectionStart
            tbox.SelectionLength = 0
            tbox.SelectedText = vbCrLf
            e.SuppressKeyPress = True
        End If

    End Sub
    Function fKeysDown(ByVal ti As Integer, ByVal p As Panel) As TextBox
        fKeysDown = Nothing
        Dim k As Control = p.GetNextControl(p, True) 'Get the first control in the tab order.
        Do Until k Is Nothing  'MORA PREKO LOOPA
            If TypeOf k Is TextBox AndAlso k.TabIndex > 0 AndAlso k.Visible = True AndAlso k.Enabled = True AndAlso k.TabStop = True Then
                If k.TabIndex > ti Then
                    fKeysDown = k
                    k = Nothing
                Else
                    k = p.GetNextControl(k, True) 'Get the next control in the tab order.
                End If
            Else
                k = p.GetNextControl(k, True) 'Get the next control in the tab order.
            End If
        Loop
    End Function
    Private Sub tboxkbr_TextChanged(sender As Object, e As EventArgs) Handles tboxkbr.TextChanged
        Dim tbox As TextBox = sender
        If Not tbox.AccessibleName Is Nothing AndAlso tbox.AccessibleName.Trim <> "" AndAlso tbox.AccessibleName.Trim.ToUpper.IndexOf("CONVERTCIRLAT") >= 0 Then
            If tbox.Text.Trim <> "" Then tbox.Text = FormTemplate.konverzijaCirLat(tbox.Text) : tbox.Select(tbox.Text.Length, 0)
        End If
    End Sub
    Private Sub tboxKucniBR_TextChanged(sender As Object, e As EventArgs) Handles tboxKucniBR.TextChanged
        Dim tbox As TextBox = sender
        If Not tbox.AccessibleName Is Nothing AndAlso tbox.AccessibleName.Trim <> "" AndAlso tbox.AccessibleName.Trim.ToUpper.IndexOf("CONVERTCIRLAT") >= 0 Then
            If tbox.Text.Trim <> "" Then tbox.Text = FormTemplate.konverzijaCirLat(tbox.Text) : tbox.Select(tbox.Text.Length, 0)
        End If
    End Sub
    Dim lbUliceStaro As Integer = 0
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llOVDE.LinkClicked
        atbPromenaNazivaUlice.Width = txtNNUlice.Width
        txtNNUlice.Text = ""
        atbPromenaNazivaUlice.Text = ""
        atbPromenaNazivaUlice.sselectedText = ""
        atbPromenaNazivaUlice.sselectedValue = ""

        Dim strSQlupit As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " + vbCrLf +
                                   " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "' and substring(IDULICE, 1, 8) ='" + Mid(fiktivnianketar, 2, 8) + "'" + vbCrLf +
                                   " order by displaymember"
        Dim dt As DataTable = izvrsiSQLvratiDT(strSQlupit, DBConnectionString, Me.jezik)
        If dt.Rows.Count <= 0 Then
            ISTMessageBox.Show("Nemate unetih novih ulica")
            atbUlica.Focus()
            Exit Sub
        End If

        Call popuniAutbDB(atbPromenaNazivaUlice, strSQlupit)
        txtSNUlice.Visible = False
        atbPromenaNazivaUlice.Visible = True
        atbPromenaNazivaUlice.BringToFront()

        lbUlice.Location = New Point(lbUlice.Location.X, LblObjasnjenje.Location.Y + 50)

        LblObjasnjenje.Visible = True
        ButtonIzmenaULOK.Visible = True
        ButtonIzmenaULCancel.Visible = True
        PanelIzmenaUL.BringToFront()

        Dim strSQl As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, ulica as valuemember from Adresar " + vbCrLf +
                               " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                               " order by ulica"
        Call popunilb(lbUlice, strSQl, Me.DBConnectionString, Me.jezik)

        PanelIzmenaUL.Visible = True
        Call samoja(PanelIzmenaUL)

        Call disableIzborZaGrid()
        atbPromenaNazivaUlice.Focus()

        'SendKeys.Send("{F4}")
    End Sub
    Sub PrikaziUlice()
        'ISKLJUCENO
        Call disabledtabkontrolu()
        PanelSpisakUlica.BringToFront()

        PanelSpisakUlica.Visible = True
        Call samoja(PanelSpisakUlica)

        Dim strSQl As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as valuemember from Adresar " + vbCrLf +
                               " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "'" + vbCrLf +
                               " order by ulica"
        Call popunilb(LBSpisakUL, strSQl, Me.DBConnectionString, Me.jezik)
    End Sub
    Private Sub ButtonIzmenaULCancel_cancel(sender As Object, e As EventArgs) Handles ButtonIzmenaULCancel.Click
        Call nesamoja(PanelIzmenaUL)
        PanelIzmenaUL.Visible = False
        Call enableIzborZaGrid()
        atbUlica.Focus()
        atbUlica.SelectionStart = 0
        atbUlica.SelectionLength = atbUlica.Text.Length
    End Sub
    Private Sub ButtonIzmenaULOK_Click(sender As Object, e As EventArgs) Handles ButtonIzmenaULOK.Click


        Dim strSQlupit As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " + vbCrLf +
                                   " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "' and substring(IDULICE, 1, 8) ='" + Mid(fiktivnianketar, 2, 8) + "' and trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash)))))=N'" + atbPromenaNazivaUlice.sselectedText + "' " + vbCrLf +
                                   " order by displaymember"
        Dim dt2 As DataTable = izvrsiSQLvratiDT(strSQlupit, DBConnectionString, Me.jezik)
        If dt2.Rows.Count <= 0 Then
            ISTMessageBox.Show("Nije ispravan Stari naziv ulice")
            atbPromenaNazivaUlice.Focus()
            Exit Sub
        End If


        Dim strSQl As String = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica from Adresar" + vbCrLf +
                               " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) =N'" + txtNNUlice.Text.Trim + "' " + vbCrLf +
                               " order by ulica"
        Dim dt As DataTable = izvrsiSQLvratiDT(strSQl, Me.DBConnectionString, Me.jezik)
        Dim br As Integer = dt.Rows.Count
        Dim vred5 As String = ""

        If atbPromenaNazivaUlice.Text.Trim = "" Then
            ISTMessageBox.Show("Morate odabrati ulicu čiji naziv želite da promenite!")
            atbPromenaNazivaUlice.Focus()
            Exit Sub
        ElseIf txtNNUlice.Text.Trim = "" Then
            ISTMessageBox.Show("Morate uneti naziv ulice!")
            txtNNUlice.Focus()
            Exit Sub
        ElseIf dt.Rows.Count > 0 Then
            ISTMessageBox.Show("Morate uneti naziv ulice koji ne postoji!")
            txtNNUlice.Focus()
            Exit Sub
        Else
            vred5 = atbPromenaNazivaUlice.sselectedValue
            Dim str As String = dodatak + " update adresar " +
                                " set ulica=trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + txtNNUlice.Text + "', 1, CONVERT(varbinary, @Hash)) ), 1)), ulicakbroj=trim(CONVERT(nvarchar(1000), (EncryptByPassPhrase(@Lozinka, N'" + txtNNUlice.Text + "'+' '+trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kbroj)='' then NULL else kbroj end),1), 1, CONVERT(varbinary, @Hash)))))         , 1, CONVERT(varbinary, @Hash)) ), 1)), " + nvrd +
                                " date_update=getdate(),user_update=N'" + kosam + "'" +
                                " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' and idulice='" + vred5.Trim + "'"
            Dim ok As String = izvrsiSQL(str, Me.DBConnectionString)
            If ok = "ok" Then
                atbUlica.sselectedValue = ""
                atbUlica.sselectedText = ""
                atbUlica.Text = ""
                strSQl = dodatak + " select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as displaymember, idulice as valuemember from Adresar " +
                           " where IDANKETAR=N'" + kosam + "' and mbops='" + atbOps.sselectedValue + "' and krug_idcd ='" + atbPK.sselectedValue + "'" +
                           " union" +
                           " select '(*)' as displaymember, '000000000000' as valuemember order by displaymember"
                Call popuniAutbDB(atbUlica, strSQl)
            Else
                ISTMessageBox.Show("Greška 3! Zovite administratora!")
                Me.Close()
                Exit Sub
            End If

            Call nesamoja(PanelIzmenaUL)
            PanelIzmenaUL.Visible = False


            If postojiMapa() = False Then
                ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
                Me.Cursor = Cursors.Default
            Else
                Dim opstina As String = atbOps.sselectedValue.Trim
                If opstina.Trim <> "" Then
                    Dim fileReader As String = ""
                    fileReader = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IzmenaUL.txt")
                    fileReader = fileReader + atbPromenaNazivaUlice.sselectedText + "$" + txtNNUlice.Text.Trim + ";"
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IzmenaUL.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IzmenaUL.txt", "" + fileReader.Trim + "", False)
                End If
            End If
        End If

        Call enableIzborZaGrid()
        atbUlica.Focus()
    End Sub
    'Private Sub lbUlice_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lbUlice.MouseDoubleClick
    '    Me.txtNNUlice.Text = DirectCast(Me.lbUlice.SelectedItem, System.Data.DataRowView).Row.ItemArray(1)
    'End Sub
    Function fKeysUp(ByVal ti As Integer, ByVal p As Panel) As Control
        fKeysUp = Nothing
        Dim k As Control = p.GetNextControl(p, True) 'Get the first control in the tab order.

        Dim ppk As Control = k
        Do Until k Is Nothing  'MORA PREKO LOOPA
            If (TypeOf k Is TextBox OrElse TypeOf k Is ComboBox) AndAlso k.TabIndex > 0 AndAlso k.Visible = True AndAlso k.Enabled = True AndAlso k.TabStop = True Then
                If k.TabIndex < ti Then
                    ppk = k
                    k = p.GetNextControl(k, True) 'Get the next control in the tab order.
                Else
                    fKeysUp = ppk
                    k = Nothing
                End If
            Else
                k = p.GetNextControl(k, True) 'Get the next control in the tab order.
            End If
        Loop
    End Function
    Private Sub pp_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        'ISTMessageBox.Show("pp_KeyUp")
        neradivalidaciju = False
        Select Case e.KeyCode
            Case Keys.Up
                neradivalidaciju = True
        End Select
    End Sub
    Private Sub btnLegendaM_Click(sender As Object, e As EventArgs) Handles btnLegenda1M.Click, btnLegenda2M.Click
        Dim pom As Button = DirectCast(sender, Button)
        If pom.Text = "_" Then
            LegMinimize()
            If pom.Name = btnLegenda1M.Name Then
                DGV1.Focus()
                PanelLegendaDGV1.Visible = True
                PanelLegendaDGV2.Visible = False
            ElseIf pom.Name = btnLegenda2M.Name Then
                DGV2.Focus()
                PanelLegendaDGV1.Visible = False
                PanelLegendaDGV2.Visible = True
            End If
        ElseIf pom.Text = "🗖" Then
            LegMaximize()
            If pom.Name = btnLegenda1M.Name Then
                DGV1.Focus()
                PanelLegendaDGV1.Visible = True
                PanelLegendaDGV2.Visible = False
            ElseIf pom.Name = btnLegenda2M.Name Then
                DGV2.Focus()
                PanelLegendaDGV1.Visible = False
                PanelLegendaDGV2.Visible = True
            End If
        End If

    End Sub
    ' PanelLegendaDGV1.Height 297
    'visinaLegende1
    Private Sub LegMinimize()

        Call SuspendDrawing(TabControl1)
        Call SuspendDrawing(PanelLegendaDGV1)
        Call SuspendDrawing(PanelLegendaDGV2)

        Dim pomkojigrid As String = ""
        If DGV1.Visible = True Then
            pomkojigrid = "DGV1"
        ElseIf DGV2.Visible = True Then
            pomkojigrid = "DGV2"
        End If
        Label9.Visible = False
        lblText2.Visible = False
        'visinaLegende1 = PanelLegendaDGV1.Height
        'visinaLegende2 = PanelLegendaDGV2.Height
        PanelLegendaDGV1.Height = 24
        PanelLegendaDGV2.Height = 24
        btnLegenda1M.Text = "🗖"
        btnLegenda2M.Text = "🗖"
        TabControl1.Location = New Point(TabControl1.Location.X, TabControl1.Location.Y - 120)
        TabControl1.Height = (Screen.PrimaryScreen.WorkingArea.Height - Me.btnVracanjeKrugova.Location.Y - Me.btnVracanjeKrugova.Height - 20)
        PanelZakazivanjeStana.Location = New Point((TabControl1.Width - PanelZakazivanjeStana.Width) \ 2, TabControl1.Location.Y + TabControl1.Height - PanelZakazivanjeStana.Height - 100)
        ButtonUnosNovogKBR.Location = New Point(ButtonUnosNovogKBR.Location.X, ButtonUnosNovogKBR.Location.Y - 120)
        btnMapa.Location = New Point(ButtonUnosNovogKBR.Location.X, ButtonUnosNovogKBR.Location.Y - 30)
        chbZavrsenKrug.Location = New Point(btnMapa.Location.X + btnMapa.Width + 30, btnMapa.Location.Y)
        lblBrojKBR.Location = New Point(ButtonUnosNovogKBR.Location.X + ButtonUnosNovogKBR.Width + 30, ButtonUnosNovogKBR.Location.Y)
        If pomkojigrid = "DGV1" Then
            DGV1.Visible = True
            DGV1.BringToFront()
        ElseIf pomkojigrid = "DGV2" Then
            DGV2.Visible = True
            DGV2.BringToFront()
        End If
        Call ResumeDrawing(TabControl1)
        Call ResumeDrawing(PanelLegendaDGV1)
        Call ResumeDrawing(PanelLegendaDGV2)

    End Sub

    Private Sub LegMaximize()

        Call SuspendDrawing(TabControl1)
        Call SuspendDrawing(PanelLegendaDGV1)
        Call SuspendDrawing(PanelLegendaDGV2)

        Label9.Visible = True
        lblText2.Visible = True
        btnLegenda1M.Text = "_"
        btnLegenda2M.Text = "_"


        TabControl1.Location = New Point(TabControl1locX, TabControl1locY)
        TabControl1.Height = TabControl1Height
        PanelZakazivanjeStana.Location = New Point((TabControl1.Width - PanelZakazivanjeStana.Width) \ 2, TabControl1.Location.Y + TabControl1.Height - PanelZakazivanjeStana.Height - 100)
        ButtonUnosNovogKBR.Location = New Point(ButtonUnosNovogKBR.Location.X, ButtonUnosNovogKBR.Location.Y + 120)
        btnMapa.Location = New Point(ButtonUnosNovogKBR.Location.X, ButtonUnosNovogKBR.Location.Y - 30)
        chbZavrsenKrug.Location = New Point(btnMapa.Location.X + btnMapa.Width + 30, btnMapa.Location.Y)
        lblBrojKBR.Location = New Point(ButtonUnosNovogKBR.Location.X + ButtonUnosNovogKBR.Width + 30, ButtonUnosNovogKBR.Location.Y)

        Call ResumeDrawing(TabControl1)
        PanelLegendaDGV1.Height = 251 ' visinaLegende1
        PanelLegendaDGV2.Height = 301 'visinaLegende2
        Call ResumeDrawing(PanelLegendaDGV1)
        Call ResumeDrawing(PanelLegendaDGV2)



    End Sub
    Private Sub cbpp_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Dim trt As ComboBox = CType(sender, ComboBox)
        Select Case e.KeyCode
            Case Keys.Escape 'ESC
            Case Keys.Enter  'Enter
                Dim aaa As String = trt.Name
                If Not (trt.SelectedValue) Is Nothing Then
                    'ako je poslednji nema gde dole!!!!
                    If cboIndexNaEnter <> trt.SelectedIndex Then
                        If trt.SelectedValue = CType(CType(trt.Items(trt.Items.Count - 1), Object), DataRowView).Item(1) Then
                            SendKeys.Send("{UP}")
                            SendKeys.Send("{DOWN}")
                        Else
                            SendKeys.Send("{DOWN}")
                            SendKeys.Send("{UP}")
                        End If
                    End If
                Else
                    'dodato 11022013
                    'pre bilo samo SendKeys.Send("{DOWN}") umesto if then else
                    If trt.Text.Trim.Length > 0 AndAlso trt.SelectedText.Trim.Length = 0 Then
                        SendKeys.Send("{DOWN}")
                        SendKeys.Send("{DOWN}")
                        'ako nije poslednji
                        Dim dt As DataTable = CType(CType(trt.DataSource, Object), DataTable)
                        Dim sqlText As String = "2=2 AND prikazi LIKE '" & trt.Text.Trim.ToUpper & "%'"
                        Dim red01 As DataRow() = dt.Select(sqlText)
                        Dim poslednjiPrikazi As String = CType(CType(trt.Items(trt.Items.Count - 1), Object), DataRowView).Item(0).ToString.Trim.ToUpper
                        If red01.Length = 1 AndAlso red01(0).Item("prikazi").ToString.Trim.ToUpper = poslednjiPrikazi Then
                            'POSLEDNJI
                        Else
                            SendKeys.Send("{UP}")
                        End If
                    Else
                        SendKeys.Send("{DOWN}")
                    End If
                End If
                SendKeys.Send("{TAB}")
            'MORA OVAKO DOKAZ PROBNIPOPIS NIKAKO
            'Me.SelectNextControl(ActiveControl, True, True, True, True)
            Case Keys.Up
            Case Keys.Down
            Case Keys.Left
            Case Keys.Right
            Case Keys.Back
            Case Keys.Delete
            Case Keys.F4
            Case Else
                If trt.DroppedDown = False Then trt.DroppedDown = True
        End Select
    End Sub

    Private Sub BtnZatvori_Click(sender As Object, e As EventArgs) Handles BtnZatvori.Click
        Me.Cursor = Cursors.WaitCursor
        Call enabledtabkontrolu()

        Call nesamoja(PanelSpisakUlica)
        PanelSpisakUlica.Visible = False

        DGV1.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BtnCancNapomenaLica_Click(sender As Object, e As EventArgs) Handles BtnCancNapomenaLica.Click
        Me.Cursor = Cursors.WaitCursor
        Call panelNapomenaLicaNonVisible()
        DGV3.Focus()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub BtnOkNapomenaLica_Click(sender As Object, e As EventArgs) Handles BtnOkNapomenaLica.Click
        Dim vred As String = TxtNapomenaLica.Text.Trim

        If vred = "" AndAlso staravrNapomeneLica = "" AndAlso cbUklonitiIzMaterijala.Checked = False Then
            ISTMessageBox.Show("Napomena ne sme biti prazna!")
            TxtNapomenaLica.Focus()
            Exit Sub
        End If

        If cbUklonitiIzMaterijala.Checked = True Then
            'If cmbRazlogUklanjanja.Text.Trim = "" Then
            '    ISTMessageBox.Show("Obeležili ste da lice treba biti uklonjeno iz materijala, molimo vas izaberite razlog!")
            '    cmbRazlogUklanjanja.Focus()
            '    Exit Sub
            'Else
            If tboxObjasnjenjeUklanjanja.Text.Trim = "" Then
                ISTMessageBox.Show("Obeležili ste da lice treba biti uklonjeno iz materijala, molimo vas upišite objašnjenje!")
                tboxObjasnjenjeUklanjanja.Focus()
                Exit Sub
            End If
            If Len(tboxObjasnjenjeUklanjanja.Text) < 10 Then
                ISTMessageBox.Show("Obeležili ste da lice treba biti uklonjeno iz materijala, molimo vas upišite detaljnije objašnjenje!")
                tboxObjasnjenjeUklanjanja.Focus()
                Exit Sub
            End If
        End If

        Dim str2 As String = ""
        If cbUklonitiIzMaterijala.Checked = True Then
            str2 = " , UklonitiLice=1 , UklonitiLiceRazlog=N'" + cmbRazlogUklanjanja.Text.Trim + "' , UklonitiLiceObjasnjenje=N'" + tboxObjasnjenjeUklanjanja.Text.Trim + "'"
        Else
            str2 = " , UklonitiLice=null , UklonitiLiceRazlog='' , UklonitiLiceObjasnjenje=''"

        End If

        Dim strSQL As String = " update spisaklica " + vbCrLf +
                               " set date_update=getdate(), user_update=N'" + kosam + "'," + vbCrLf +
                               " istnote=N'" + TxtNapomenaLica.Text + "'" + vbCrLf + str2 + vbCrLf +
                               " where kucni_broj_idCD='" + Me.TxtKbrIDCDLica.Text + "' and krug_idcd=" +
                               Me.TxtKrugIDCDLica.Text.Trim + " and rbrstan='" + Me.TxtRbrStNapomenaLica.Text + "'" + nvrd +
                               " and mbops='" + TxtMBOPSLica.Text + "' AND RBRDOM='" + TxtRbrDomNapomenaLica.Text + "' and rbrp1='" + TxtRBrLicaNapomenaLica.Text + "' "




        Dim ok As String = izvrsiSQL(strSQL, Me.DBConnectionString)
        If ok <> "ok" Then
            ISTMessageBox.Show("Greška 4! Zovite administratora!")
            Me.Close()
            Exit Sub
        End If
        'Dim pomrowDGV1 As Integer = vratiSelektvanRedDGV1(BtnOkNapomenaLica.Tag)
        Dim pomrowDGV1 As Integer = vratiSelektvanRedDGV1(DGV3.Tag)
        'Call refreshDGV1()
        'If DGV1.Rows.Count > 0 Then
        '    DGV1.ClearSelection()
        '    DGV1.Rows(pomrowDGV1).Selected = True
        'End If


        If DGV3.Rows.Count > 0 Then
            If pRbrStan = "" Then
                Call refreshDGV3(pomrowDGV1)
            Else
                Call refreshDGV2(pomrowDGV1,,,,, pRbrStan)
            End If
            If DGV3.Rows.Count > 0 Then
                DGV3.Focus()
                DGV3.ClearSelection()
                'DGV3.Rows(PanelNapomenaLica.Tag).Selected = True
                If DGV3.Rows.Count - 1 >= PanelNapomenaLica.Tag Then
                    DGV3.Rows(PanelNapomenaLica.Tag).Selected = True
                Else
                    DGV3.Rows(0).Selected = True
                End If

            End If
        End If
        staravrNapomeneLica = ""
        Call panelNapomenaLicaNonVisible()
    End Sub

    Private Function postojiMapa() As Boolean
        If atbOps.sselectedValue.Trim <> "" Then
            Dim dir As New IO.DirectoryInfo("C:\IST\QGIS\Popis_21\" + atbOps.sselectedValue.Trim.Trim + "")
            If dir.Exists Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub BtnNUlica_Click(sender As Object, e As EventArgs) Handles ButtonUnosNoveUlice.Click
        Me.Cursor = Cursors.WaitCursor

        If postojiMapa() = False Then
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        ButtonDodajAdr.Enabled = False
        llNastaviUL.Enabled = False
        llNastaviUL.Visible = True
        btnMapaKbrUL.Tag = "unos"

        gbKBRUL.Visible = False
        btnMapaKbrUL.Enabled = True
        llNastaviUL.Enabled = False
        llNastaviUL.Visible = True

        atbUlica.sselectedText = ""
        atbUlica.sselectedValue = ""
        atbUlica.Text = ""
        LBNUlSpisak.Visible = True
        'PanelNUl.Height = PanelIzmenaUL.Height
        'LBNUlSpisak.Height = 226
        'LBNUlSpisak.Width = tboxNovaUlica.Width + Label11.Width + 10
        'ButtonDodajAdr.Location = New Point(ButtonDodajAdr.Location.X, gbKBRUL.Location.Y + LBNUlSpisak.Height + 50)
        'ButtonNeDodajAdr.Location = New Point(ButtonNeDodajAdr.Location.X, gbKBRUL.Location.Y + LBNUlSpisak.Height + 50)
        Dim strSQl As String = dodatak + "select distinct trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) As displaymember, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as valuemember from Adresar where mbops='" + atbOps.sselectedValue + "' and krug_idcd='" + atbPK.sselectedValue + "' order by trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash)))))"
        Call popunilb(LBNUlSpisak, strSQl, Me.DBConnectionString, Me.jezik)
        tboxNovaUlica.Text = ""
        tboxKucniBR.Text = ""
        TextBoxLong.Text = ""
        TextBoxLat.Text = ""
        PanelNUl.BringToFront()

        PanelNUl.Visible = True
        PanelNUl.Enabled = True
        Call samoja(PanelNUl)

        tboxKucniBR.Enabled = True
        tboxNovaUlica.Enabled = True
        tboxNovaUlica.Focus()
        Call disableIzborZaGrid()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub btnSpisakUlica_Click(sender As Object, e As EventArgs) Handles ButtonSpisakUlica.Click
        'ISKLJUCENO  ButtonSpisakUlica.visible=false
        Me.Cursor = Cursors.WaitCursor
        Call CancelNUL()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub dgv_ColumnWidthChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles DGV1.ColumnWidthChanged, DGV2.ColumnWidthChanged, DGV3.ColumnWidthChanged
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim rtHeader As Rectangle = dgv.DisplayRectangle
        rtHeader.Height = dgv.ColumnHeadersHeight / 2
        dgv.Invalidate(rtHeader)

        If DGV1.Visible = True Then
            If Not DGV1.Columns(e.Column.Name) Is Nothing AndAlso e.Column.Name.Trim.ToUpper.IndexOf("PRAZNO") = 0 Then
                DGV1.Columns(e.Column.Name).Width = 2
                Exit Sub
            End If
            filterUlica.Width = DGV1.Columns("ulicaKBroj").Width
            filterUlica.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("Status").Width, DGV1.ColumnHeadersHeight - filterUlica.Height - 1)

            filterStatus.Width = DGV1.Columns("Status").Width
            filterStatus.Location = New Point(DGV1.RowHeadersWidth, DGV1.ColumnHeadersHeight - filterStatus.Height - 1)

            filterUlicaMapa.Width = DGV1.Columns("NoviKbrojTeren").Width
            filterUlicaMapa.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("Status").Width + filterUlica.Width, DGV1.ColumnHeadersHeight - filterUlicaMapa.Height - 1)

            filterNapomenaKBR.Width = DGV1.Columns("NapomenaOKucnomBroju").Width
            filterNapomenaKBR.Location = New Point(DGV1.RowHeadersWidth + DGV1.Columns("Status").Width + filterUlica.Width + filterUlicaMapa.Width + DGV1.Columns("praznoA").Width + DGV1.Columns("EEdit").Width + 2, DGV1.ColumnHeadersHeight - filterNapomenaKBR.Height - 1)
        End If

        If DGV2.Visible = True Then
            If Not DGV2.Columns(e.Column.Name) Is Nothing AndAlso e.Column.Name.Trim.ToUpper.IndexOf("PRAZNO") = 0 Then
                DGV2.Columns(e.Column.Name).Width = 2
                Exit Sub
            End If
            If e.Column.Index < DGV2.Columns("zakazanodatum").Index Then
                'If filterDatumZakazan.AccessibleDescription Is Nothing OrElse IsNumeric(filterDatumZakazan.AccessibleDescription) = False Then
                filterDatumZakazan.Location = New Point(DGV2.RowHeadersWidth +
                                                    DGV2.Columns("RbrStan").Width +
                                                    DGV2.Columns("statusAnketar").Width +
                                                    DGV2.Columns("ulicaKBroj").Width +
                                                    DGV2.Columns("NoviKbrojTeren").Width +
                                                    DGV2.Columns("BrojStana").Width +
                                                    DGV2.Columns("OOpen2").Width +
                                                    DGV2.Columns("BrojLica").Width +
                                                    DGV2.Columns("praznoA").Width +
                                                    DGV2.Columns("EEdit").Width +
                                                    DGV2.Columns("DatumDolaska").Width,
                                                    DGV2.ColumnHeadersHeight - filterDatumZakazan.Height - 1)
                '+
                '                                    DGV2.Columns("nazivishod").Width +
                '                                    DGV2.Columns("nacinanketiranja").Width +
                '                                    DGV2.Columns("KontaktOsoba").Width +
                '                                    DGV2.Columns("BrojTelefona").Width
                'Else
                '    filterDatumZakazan.Location = New Point(CInt(filterDatumZakazan.AccessibleDescription), DGV2.ColumnHeadersHeight - filterDatumZakazan.Height - 1)
                ' End If

            ElseIf e.Column.Index = DGV2.Columns("zakazanodatum").Index Then
                filterDatumZakazan.Width = DGV2.Columns("zakazanodatum").Width
            End If

            filterStatusDGV2.Width = DGV2.Columns("statusAnketar").Width
            filterStatusDGV2.Location = New Point(DGV2.RowHeadersWidth, DGV2.ColumnHeadersHeight - filterStatusDGV2.Height - 1)


            filterUlicaDGV2.Width = DGV2.Columns("ulicaKBroj").Width
            filterUlicaDGV2.Location = New Point(DGV2.RowHeadersWidth, DGV2.ColumnHeadersHeight - filterUlicaDGV2.Height - 1)

            filterAdresaTerenDGV2.Width = DGV2.Columns("NoviKbrojTeren").Width
            filterAdresaTerenDGV2.Location = New Point(DGV2.RowHeadersWidth + DGV2.Columns("RbrStan").Width + DGV2.Columns("statusAnketar").Width + DGV2.Columns("ulicaKBroj").Width, DGV2.ColumnHeadersHeight - filterAdresaTerenDGV2.Height - 1)

            If DGV2.Columns("NazivNaselja").Visible = True Then
                filterDatumZakazan.Location = New Point(filterDatumZakazan.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterDatumZakazan.Location.Y)
                filterStatusDGV2.Location = New Point(filterStatusDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterStatusDGV2.Location.Y)
                filterUlicaDGV2.Location = New Point(filterUlicaDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterUlicaDGV2.Location.Y)
                filterAdresaTerenDGV2.Location = New Point(filterAdresaTerenDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterAdresaTerenDGV2.Location.Y)
                filterUlicaDGV2.Visible = True
                filterAdresaTerenDGV2.Visible = True
            Else
                filterUlicaDGV2.Visible = False
                filterAdresaTerenDGV2.Visible = False
            End If

        End If

        If DGV3.Visible = True Then
            If Not DGV3.Columns(e.Column.Name) Is Nothing AndAlso e.Column.Name.Trim.ToUpper.IndexOf("PRAZNO") = 0 Then
                DGV3.Columns(e.Column.Name).Width = 2
                Exit Sub
            End If
            filterUlicaDGV3.Width = DGV3.Columns("ulicaKBroj").Width
            filterUlicaDGV3.Location = New Point(DGV3.Columns("RbrStan").Width + DGV3.RowHeadersWidth, DGV3.ColumnHeadersHeight - filterUlicaDGV3.Height - 1)

            filterImePrezime.Width = DGV3.Columns("imeprezime").Width
            filterImePrezime.Location = New Point(DGV3.RowHeadersWidth + DGV3.Columns("ulicakbroj").Width + DGV3.Columns("RbrStan").Width + DGV3.Columns("rbrdom").Width + DGV3.Columns("rbrp1").Width + DGV3.Columns("brojstana").Width, DGV3.ColumnHeadersHeight - filterImePrezime.Height - 1)

            'filterJMBG.Width = DGV3.Columns("jmbg").Width
            'filterJMBG.Location = New Point(DGV3.RowHeadersWidth + DGV3.Columns("ulicakbroj").Width + DGV3.Columns("RbrStan").Width + DGV3.Columns("OOpenStan").Width + DGV3.Columns("rbrdom").Width + DGV3.Columns("rbrp1").Width + DGV3.Columns("brojstana").Width + DGV3.Columns("imeprezime").Width + DGV3.Columns("ImeRoditelja").Width + DGV3.Columns("Pol").Width, DGV3.ColumnHeadersHeight - filterJMBG.Height - 1)
        End If


    End Sub
    Private Sub dgv1_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles DGV1.Scroll
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)
        Dim rtHeader As Rectangle = dgv.DisplayRectangle
        rtHeader.Height = dgv.ColumnHeadersHeight / 2
        dgv.Invalidate(rtHeader)
    End Sub
    Private Sub dgv2_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles DGV2.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Exit Sub
        Else
            Dim dgv As DataGridView = DirectCast(sender, DataGridView)
            Dim rtHeader As Rectangle = dgv.DisplayRectangle
            rtHeader.Height = dgv.ColumnHeadersHeight / 2
            dgv.Invalidate(rtHeader)

            SuspendLayout()
            Call SuspendDrawing(DGV2)

            'filterDatumZakazan.Location = New Point(Math.Abs(filterDatumZakazan.AccessibleName - e.NewValue), filterDatumZakazan.Location.Y)
            'filterDatumZakazan.Location = New Point(filterDatumZakazan.AccessibleName - e.NewValue, filterDatumZakazan.Location.Y)

            Call ResumeDrawing(DGV2)
            ResumeLayout()

        End If
    End Sub

    Private Sub dgv3_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles DGV3.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Exit Sub
        Else
            Dim dgv As DataGridView = DirectCast(sender, DataGridView)
            Dim rtHeader As Rectangle = dgv.DisplayRectangle
            rtHeader.Height = dgv.ColumnHeadersHeight / 2
            dgv.Invalidate(rtHeader)

            'SuspendLayout()
            'Call SuspendDrawing(DGV3)
            'filterJMBG.Location = New Point(Math.Abs(filterJMBG.AccessibleName - e.NewValue), filterJMBG.Location.Y)
            'filterJMBG.AccessibleDescription = filterJMBG.Location.X
            'Call ResumeDrawing(DGV3)
            'ResumeLayout()

        End If
    End Sub
    Private Sub dgv_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DGV1.CellPainting, DGV2.CellPainting, DGV3.CellPainting

        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        If dgv.Name.Trim.ToUpper = "DGV1" Then
            Call sredigrid2(10, 5, dgv, e, nvrd + nvrd + nvrd + "nezavršeni stanovi", color1, Color.Black)
            Call sredigrid(18, 1, dgv, e, "Izmena podataka o kućnom broju koji je popisivač dodao i unos napomene", color1, Color.Black)
            Call sredigrid(6, 10, dgv, e, "Stanovi", color1, Color.Black)

        ElseIf dgv.Name.Trim.ToUpper = "DGV2" Then
            If DGV2.Columns("NazivNaselja").Visible = True Then
                Call sredigrid(12, 8, dgv, e, "Ishod posete / Zakazivanje", color2, Color.Black)
                Call sredigrid(22, 1, dgv, e, "Napomena za stan", color2, Color.Black)
                'Call sredigrid(24, 1, dgv, e, "Zahtev za doradu i komentar instruktora", color2, Color.Black)
            Else
                Call sredigrid(12, 8, dgv, e, "Ishod posete / Zakazivanje", color2, Color.Black)
                Call sredigrid(22, 1, dgv, e, "Napomena za stan", color2, Color.Black)
                'Call sredigrid(23, 2, dgv, e, "Zahtev za doradu i komentar instruktora", color2, Color.Black)
            End If

        ElseIf dgv.Name.Trim.ToUpper = "DGV3" Then
            Call sredigrid(14, 1, dgv, e, "Napomena za lice", color3, Color.Black)
        End If

        ' e.Handled = True
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
            r1.Height = r1.Height \ 3
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

    Sub sredigrid2(ByVal poc As Integer, ByVal brkol As Integer, ByVal dgv As DataGridView, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs, ByVal headername As String, ByVal backcolor As Color, ByVal forecolor As Color)

        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then

            Dim ColumnHeadersvisina As Integer = dgv.ColumnHeadersHeight
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
            r1.Height = r1.Height \ 2
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

    Private Sub filterTextBoxDGV2_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DGV2.Tag Is Nothing OrElse IsNumeric(DGV2.Tag) = False Then DGV2.Tag = -1

        filterUlicaDGV2.Tag = "filtul"
        filterAdresaTerenDGV2.Tag = "filtnkbr"

        Dim pom As String = filterStatusDGV2.Text
        If pom.Length > 0 AndAlso pom <> "" Then pom = pom.Substring(0, 1)
        If pom = "*" Then pom = ""

        If Not filterDatumZakazan.Tag Is Nothing AndAlso filterDatumZakazan.Tag = "" Then
            If DGV1.SelectedRows.Count > 0 Then
                refreshDGV2(DGV2.Tag, filterDatumZakazan.Text, pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
            Else
                'ivanaaaa
                Call praznidgv2()
            End If
        Else
            If filterDatumZakazan.Text = " " OrElse filterDatumZakazan.Text = "*" Then
                refreshdgv2zakazni("", pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
            Else
                refreshdgv2zakazni(filterDatumZakazan.Text, pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
            End If

        End If
        filterUlicaDGV2.Tag = ""
        filterAdresaTerenDGV2.Tag = ""

        DirectCast(sender, TextBox).Focus()

    End Sub

    Private Sub filterTextBoxDGV3_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DGV3.Visible = True Then
            Dim pomocna1 As String = filterUlicaDGV3.Text
            Dim pomocna2 As String = filterImePrezime.Text
            Dim pomocna3 As String = "" 'filterJMBG.Text
            Dim pomrowDGV1 As Integer = 0
            If DGV1.SelectedCells.Count > 0 Then
                pomrowDGV1 = vratiSelektvanRedDGV1(DGV3.Tag)
            Else
                pomrowDGV1 = 0
            End If
            If Not filterUlicaDGV3.Tag Is Nothing AndAlso filterUlicaDGV3.Tag = "" Then
                'If DGV3.Rows.Count > 0 Then
                If pRbrStan = "" Then
                    Call refreshDGV3(pomrowDGV1,, pomocna1, pomocna2, pomocna3)
                Else
                    Call refreshDGV3(pomrowDGV1, pRbrStan, pomocna1, pomocna2, pomocna3)
                End If
                ' Else
                'ivanaaaa
                'Call praznidgv3()
                'End If
            Else
                refreshdgv3svalica(pomocna1, pomocna2, pomocna3)
            End If
        End If

        DirectCast(sender, TextBox).Focus()
    End Sub

    Private Sub filterTextBoxDGV1_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DGV1.Visible = True Then
            Dim pom As String = filterStatus.Text
            If pom.Length > 0 AndAlso pom <> "" Then pom = pom.Substring(0, 1)
            If pom = "*" Then pom = ""
            refreshDGV1(filterUlica.Text, pom, filterUlicaMapa.Text, filterNapomenaKBR.Text)
        End If

        'If DGV2.Visible = True Then
        '    If DGV2.Tag Is Nothing OrElse IsNumeric(DGV2.Tag) = False Then Else DGV2.Tag = -1

        '    filterUlicaDGV2.Tag = "filtul"
        '    filterAdresaTerenDGV2.Tag = "filtnkbr"

        '    Dim pom As String = filterStatusDGV2.Text
        '    If pom.Length > 0 AndAlso pom <> "" Then pom = pom.Substring(0, 1)
        '    If pom = "*" Then pom = ""

        '    If Not filterDatumZakazan.Tag Is Nothing AndAlso filterDatumZakazan.Tag = "" Then
        '        If DGV1.SelectedRows.Count > 0 Then
        '            refreshDGV2(DGV2.Tag, filterDatumZakazan.Text, pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
        '        Else
        '            'ivanaaaa
        '            Call praznidgv2()
        '        End If
        '    Else
        '        If filterDatumZakazan.Text = " " OrElse filterDatumZakazan.Text = "*" Then
        '            refreshdgv2zakazni("", pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
        '            'filterDatumZakazan.Text = "*"
        '        Else
        '            refreshdgv2zakazni(filterDatumZakazan.Text, pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
        '        End If

        '    End If
        '    filterUlicaDGV2.Tag = ""
        '    filterAdresaTerenDGV2.Tag = ""
        'End If

        DirectCast(sender, TextBox).Focus()

    End Sub

    Private Sub btnZakazani_Click(sender As Object, e As EventArgs) Handles ButtonZakazani.Click
        'If Panel3.Visible = True Then
        '    Call Cancel()
        'End If
        'If PanelNUl.Visible = True Then
        '    Call CancelNUL()
        'End If

        Dim ttext As String = ""
        Dim overlayHandle As ISTFormIsLoading
        overlayHandle = New ISTFormIsLoading(Me, Me.TabControl1.Parent)
        overlayHandle.Show()

        If ButtonNastavi.Enabled = True OrElse BtnSvaLica.Tag <> "" Then
            Dim str As String = "select distinct zakazanodatum from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' order by ZakazanoDatum"
            Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            If dt.Rows.Count = 0 Then
                ISTMessageBox.Show("Nemate zakazanih stanova.")
                overlayHandle.Close()
                Exit Sub
            End If
        ElseIf ButtonNastavi.Enabled = False AndAlso atbOps.Text <> "" AndAlso atbPK.Text <> "" AndAlso atbUlica.Text <> "" Then
            If ButtonZakazani.Text = "Svi zakazani stanovi" Then
                Dim str As String = "select distinct zakazanodatum from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' order by ZakazanoDatum"
                Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
                If dt.Rows.Count = 0 Then
                    ISTMessageBox.Show("Nemate zakazanih stanova.")
                    overlayHandle.Close()
                    Exit Sub
                End If
            End If
        End If

        If BtnSvaLica.Text.Trim.ToUpper <> "SVA LICA" Then
            TabControl1.TabPages.Remove(TabPage3)
            BtnSvaLica.Text = "Sva lica"
            BtnSvaLica.BackColor = System.Drawing.SystemColors.Control
            DGV3.Visible = False
            filterUlicaDGV3.Tag = ""
        End If
        Call zatvoriIPonistiPanele()

        If ButtonNastavi.Enabled = True OrElse BtnSvaLica.Tag <> "" Then
            ButtonZakazani.Tag = "dosao"
            If atbOps.Enabled = True Then
                atbOps.Text = ""
                ttext = "Povratak na izbor opštine"
            Else
                ttext = "Povratak na izbor popisnog kruga"
            End If
            Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' order by ZakazanoDatum", Me.DBConnectionString, False, False, False, True)
            atbPK.Text = ""
            'lblInformation.Visible = False
            btnInformation.Visible = False
            atbUlica.Text = ""
            lblnaselje.Text = ""
            filterDatumZakazan.Tag = "svi"
            filterDatumZakazan.Visible = True
            Call disableIzborZaGrid()
            Call visibletabkontrola()
            Call enabledtabkontrolu()
            'If TabControl1.Controls.Contains(TabPage1) Then
            TabControl1.TabPages.Remove(TabPage3)
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage1)
            DGV1.Visible = False
            TabControl1.TabPages.Add(TabPage2)
            Call refreshdgv2zakazni()
            TabControl1.SelectedIndex = 0
            TabControl1.SelectedTab = TabPage2
            promenaTaba()
            ButtonZakazani.Text = ttext
            'PanelLegendaDGV1.Visible = False
            'PanelLegendaDGV2.Visible = True
            TabPage2.Text = "Spisak zakazanih stanova"
            ButtonZakazani.BackColor = Color.AliceBlue
            ButtonResetPK.Enabled = False
            ButtonResetUl.Enabled = False
            ' End If
        ElseIf ButtonNastavi.Enabled = False AndAlso (atbOps.Text = "" OrElse atbPK.Text = "" OrElse atbUlica.Text = "") Then
            ButtonZakazani.Tag = "dosao"
            ButtonZakazani.Text = "Svi zakazani stanovi"
            TabPage2.Text = "Unos/izmena podataka o stanu i ishoda poseta"
            filterDatumZakazan.Tag = ""
            Call Reset()
            If atbOps.Text = "" Then
                atbOps.Focus()
            Else
                atbPK.Focus()
            End If
            ButtonZakazani.BackColor = System.Drawing.SystemColors.Control
        ElseIf ButtonNastavi.Enabled = False AndAlso atbOps.Text <> "" AndAlso atbPK.Text <> "" AndAlso atbUlica.Text <> "" Then
            If ButtonZakazani.Text = "Svi zakazani stanovi" Then
                Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' order by ZakazanoDatum", Me.DBConnectionString, False, False, False, True)
                filterDatumZakazan.Tag = "svi"
                TabControl1.TabPages.Remove(TabPage3)
                TabControl1.TabPages.Remove(TabPage2)
                TabControl1.TabPages.Remove(TabPage1)
                TabControl1.TabPages.Add(TabPage2)
                DGV1.Visible = False
                ButtonZakazani.Text = "Povratak na Unos/Izmena podataka o zgradi"
                TabPage2.Text = "Spisak zakazanih stanova"
                Call refreshdgv2zakazni()
                TabControl1.SelectedIndex = 0
                TabControl1.SelectedTab = TabPage2
                promenaTaba()
                ButtonZakazani.BackColor = Color.AliceBlue
                filterDatumZakazan.Text = "*"
                filterUlicaDGV2.Text = ""
                filterAdresaTerenDGV2.Text = ""
                filterStatusDGV2.Text = "*"
            Else
                filterDatumZakazan.Tag = ""
                TabControl1.TabPages.Remove(TabPage2)
                TabPage2.Text = "Unos/izmena podataka o stanu i ishoda poseta"
                ButtonZakazani.Text = "Svi zakazani stanovi"
                TabControl1.TabPages.Add(TabPage1)
                TabControl1.TabPages.Add(TabPage2)
                TabControl1.TabPages.Add(TabPage3)
                TabControl1.SelectedTab = TabPage1
                TabPage1.Visible = True
                DGV1.Visible = True
                'DGV2.DataSource = Nothing
                'refreshDGV2(-1)
                Call praznidgv2()
                TabControl1.SelectedIndex = 0
                promenaTaba()
                'PanelLegendaDGV1.Visible = True
                'refreshDGV1()
                ButtonZakazani.BackColor = System.Drawing.SystemColors.Control
                DGV1.Focus()
            End If
        End If
        BtnSvaLica.Tag = ""
        overlayHandle.Close()

    End Sub

    Private Sub BtnSvaLica_Click(sender As Object, e As EventArgs) Handles BtnSvaLica.Click
        'If Panel3.Visible = True Then
        '    Call Cancel()
        'End If
        'If PanelNUl.Visible = True Then
        '    Call CancelNUL()
        'End If

        Dim str As String = "select rbrp1 from spisaklica s left join adresar a on s.mbops=a.mbops and s.krug_idcd=a.krug_idcd and s.kucni_broj_idcd=a.kucni_broj_idcd and s.rbrstan=a.rbrstan where IDANKETAR=N'" + kosam + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
        If dt.Rows.Count = 0 Then
            ISTMessageBox.Show("Nemate unetih lica.")
            Exit Sub
        End If
        If ButtonZakazani.Text.Trim.ToUpper <> "SPISAK ZAKAZANIH STANOVA" Then
            TabControl1.TabPages.Remove(TabPage2)
            ButtonZakazani.Text = "Svi zakazani stanovi"
            ButtonZakazani.BackColor = System.Drawing.SystemColors.Control
            DGV2.Visible = False
            filterDatumZakazan.Tag = ""
        End If
        Call zatvoriIPonistiPanele()
        Dim ttext As String = ""
        Dim overlayHandle As ISTFormIsLoading
        overlayHandle = New ISTFormIsLoading(Me, Me.TabControl1.Parent)
        overlayHandle.Show()

        If ButtonNastavi.Enabled = True OrElse ButtonZakazani.Tag <> "" Then
            BtnSvaLica.Tag = "dosao"
            If atbOps.Enabled = True Then
                atbOps.Text = ""
                ttext = "Povratak na izbor opštine"
            Else
                ttext = "Povratak na izbor popisnog kruga"
            End If
            atbPK.Text = ""
            atbUlica.Text = ""
            lblnaselje.Text = ""
            filterUlicaDGV3.Tag = "svi"
            'filterUlicaDGV3.Visible = True
            filterImePrezime.Visible = True
            'filterJMBG.Visible = True
            Call disableIzborZaGrid()
            Call visibletabkontrola()
            Call enabledtabkontrolu()
            TabControl1.TabPages.Remove(TabPage3)
            TabControl1.TabPages.Remove(TabPage2)
            TabControl1.TabPages.Remove(TabPage1)
            DGV1.Visible = False
            DGV2.Visible = False
            TabControl1.TabPages.Add(TabPage3)
            Call refreshdgv3svalica()
            TabControl1.SelectedIndex = 0
            TabControl1.SelectedTab = TabPage3
            promenaTaba()
            BtnSvaLica.Text = ttext
            TabPage3.Text = "Sva lica"
            BtnSvaLica.BackColor = Color.AliceBlue
            ButtonResetPK.Enabled = False
            ButtonResetUl.Enabled = False
            ' End If
        ElseIf ButtonNastavi.Enabled = False AndAlso (atbOps.Text = "" OrElse atbPK.Text = "" OrElse atbUlica.Text = "") Then
            BtnSvaLica.Tag = "dosao"
            filterUlicaDGV3.Tag = ""
            Call Reset()
            'If atbOps.Text = "" Then
            '    atbOps.Focus()
            'Else
            '    atbPK.Focus()
            'End If
            BtnSvaLica.BackColor = System.Drawing.SystemColors.Control
            BtnSvaLica.Text = "Sva lica"
            TabPage3.Text = "Pregled i izmena podataka o licima"
        ElseIf ButtonNastavi.Enabled = False AndAlso atbOps.Text <> "" AndAlso atbPK.Text <> "" AndAlso atbUlica.Text <> "" Then
            If BtnSvaLica.Text = "Sva lica" Then
                TabControl1.TabPages.Remove(TabPage3)
                TabControl1.TabPages.Remove(TabPage2)
                TabControl1.TabPages.Remove(TabPage1)
                TabControl1.TabPages.Add(TabPage3)
                DGV1.Visible = False
                DGV2.Visible = False
                TabPage3.Text = "Sva lica"
                Call refreshdgv3svalica()
                TabControl1.SelectedIndex = 0
                TabControl1.SelectedTab = TabPage3
                filterUlicaDGV3.Tag = "svi"
                promenaTaba()
                BtnSvaLica.BackColor = Color.AliceBlue
                BtnSvaLica.Text = "Povratak na Unos/Izmena podataka o zgradi"
            Else
                filterUlicaDGV3.Tag = ""
                TabControl1.TabPages.Remove(TabPage3)
                TabPage3.Text = "Pregled i izmena podataka o licima"
                TabControl1.TabPages.Add(TabPage1)
                TabControl1.TabPages.Add(TabPage2)
                TabControl1.TabPages.Add(TabPage3)
                TabControl1.SelectedTab = TabPage1
                TabPage1.Visible = True
                DGV1.Visible = True
                'DGV2.DataSource = Nothing
                'refreshDGV2(-1)
                refreshDGV3()
                'Call praznidgv2()
                TabControl1.SelectedIndex = 0
                promenaTaba()
                'PanelLegendaDGV1.Visible = True
                'refreshDGV1()
                BtnSvaLica.BackColor = System.Drawing.SystemColors.Control
                BtnSvaLica.Text = "Sva lica"
                DGV1.Focus()
            End If
        End If
        ButtonZakazani.Tag = ""
        overlayHandle.Close()
    End Sub
    Dim pamtikbrDGV2 As String = ""
    Sub praznidgv2()
        If DGV2.Rows.Count > 0 Then
            pamtikbrDGV2 = DGV2.Rows(0).Cells("kucni_broj_idcd").Value.ToString.Trim
            Dim pom2 As Integer = DGV2.Rows.Count - 1
            For i As Integer = pom2 To 0 Step -1
                Dim dgvDelRow As DataGridViewRow = DGV2.Rows(i)
                DGV2.Rows.Remove(dgvDelRow)
            Next
        Else
            refreshDGV2()
        End If
        praznidgv3()
    End Sub

    Sub praznidgv3()
        If DGV3.Rows.Count > 0 Then
            Dim pom2 As Integer = DGV3.Rows.Count - 1
            For i As Integer = pom2 To 0 Step -1
                Dim dgvDelRow As DataGridViewRow = DGV3.Rows(i)
                DGV3.Rows.Remove(dgvDelRow)
            Next
        Else
            refreshDGV3()
        End If
    End Sub
    Sub refreshdgv2zakazni(Optional ByVal datumzakazano As String = "", Optional ByVal status As String = "", Optional ByVal ulicakbroj As String = "", Optional ByVal novikbroj As String = "")
        'case when isnull(sss.QC,'')='' then N'' else N'✔' end as QC,case when isnull(sss.CapiExported,'')='' then N'' else N'✔' end as Poslat,'
        Dim dt As DataTable

        Dim str As String = dodatak + "select * from (select left(a.Krug_idcd,4) as krugZaPrikaz,a.NazivNaselja, " + nvrd +
        " (case when isnull(a.statusAnketar,0)=0 and isnull(a.USER_statusAnketar,'') not like 'I7%' and isnull(a.USER_statusAnketar,'') not like 'I8%' and  isnull(imastan,'')='' then ' ' " + nvrd +
        " when isnull(a.statusAnketar,0)=0 and isnull(a.USER_statusAnketar,'') not like 'I7%' and isnull(a.USER_statusAnketar,'') not like 'I8%' and isnull(imastan,'')<>'' then '0' " + nvrd +
        " when isnull(a.statusAnketar,0)=0 and (isnull(a.USER_statusAnketar,'') like 'I7%' or isnull(a.USER_statusAnketar,'') like 'I8%') then '4' " + nvrd +
        " else cast(isnull(a.statusAnketar,'') as varchar(1)) end) as statusAnketar,case when isnull(ooo.kucni_broj_idCD,'')='' then '' else cast(a.RbrStan as char(10)) end as RbrStan, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.UlicakBroj)='' then NULL else a.UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicaKBroj," + nvrd +
        " (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(OOO.noviNazivUliceTeren)='' then NULL else OOO.noviNazivUliceTeren end),1), 1, CONVERT(varbinary, @Hash)))))+' '+OOO.NoviKbrojTeren) as NoviKbrojTeren," + nvrd +
        " (case when isnull(sss.BrojStana,'')='' then isnull(BrojStanaVrata,'') else sss.BrojStana end) as BrojStana," + nvrd + 'BrojStanaVrata da li ovde broj stana na vratima iz adresara (zakazivanje) ili iz stana
        " (case when cast(isnull(a.statusAnketar,'') as varchar(1)) in ('','0','1') then N'🏦👪' else '' end) as OOpen2," + nvrd +
        " (select cast(isnull(brojdom,0) as varchar(3)) from p2_stan bb where bb.mbops=a.mbops and bb.Krug_idcd=a.Krug_idcd and bb.kucni_broj_idCD=a.kucni_broj_idCD and bb.rbrstan=a.rbrstan ) +'/'+" + nvrd +
        " cast(isnull((select count(*) from p2_dom xx where xx.mbops=a.mbops and xx.Krug_idcd=a.Krug_idcd and xx.kucni_broj_idCD=a.kucni_broj_idCD and xx.rbrstan=a.rbrstan and isnull(brlica,0)>0 group by rbrstan),0) as varchar(3)) as BrojDom," + nvrd +
        " (select cast(isnull(UBrLicaStan,0) as varchar(3)) from p2_stan bb where bb.mbops=a.mbops and bb.Krug_idcd=a.Krug_idcd And bb.kucni_broj_idCD=a.kucni_broj_idCD And bb.rbrstan=a.rbrstan ) +'/'+" + nvrd +
        " cast(isnull((select count(*) from p1 xx where xx.mbops =a.mbops and xx.Krug_idcd=a.Krug_idcd And xx.kucni_broj_idCD=a.kucni_broj_idCD And xx.rbrstan=a.rbrstan And isnull(podatak, 0) > 0 group by rbrstan),0) as varchar(3)) as BrojLica," + nvrd +
        " ' ' as praznoA," +
        " (case when isnull(a.statusAnketar,0)= 0 Then N'📝' else '' end ) as EEdit,DatumDolaska, cast(a.Ishod as nvarchar(1)) +'-'+ ltrim(rtrim(i.naziv)) as nazivishod, " + nvrd +
        " (case when isnull(a.cati_nacin,0)=1 then N'📞' when isnull(a.cati_nacin,0)=2 then N'🏃' else '' end) as nacinanketiranja," + nvrd +
        " a.KontaktOsoba,a.BrojTelefona,a.ZakazanoDatum, a.ZakazanoVreme, a.ukupnolicastan, a.IshodNapomena, ' ' as praznoB," + nvrd +
        " N'🖉' as EEditNapomena,napomenaostanu, " + nvrd +
        "' ' as prazno," + nvrd +
        " (case when (isnull(a.statusAnketar,0)=2 or isnull(a.statusAnketar,0)=3) then N'🖐' else '' end ) as OOpen3,a.napomenaStatusAnketar, a.napomenaKontrolorNivo1,' ' as praznoC," + nvrd +
        " (case when Not exists(select * from p2_dom x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan ) " + nvrd +
        " And Not exists (select * from spisaklica x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan )" + nvrd +
        " And Not exists (select * from P1 x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan )" + nvrd +
        " And exists (select * from P2_stan x where a.mbops=x.mbops And a.krug_idcd=x.krug_idcd And a.kucni_broj_idcd=x.kucni_broj_idcd And a.rbrstan=x.rbrstan ) and cast(isnull(a.statusAnketar,'') as varchar(1)) in ('','0','1')" + nvrd +
        " then N'🗑' else '' end) as DeleteIZStana," + nvrd +
        " a.kucni_broj_Deo,a.Krug_idcd, a.idulice,a.kucni_broj_idCD,trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj,a.cati_nacin, " + nvrd +
        " a.mbops, a.NazivOpstine, a.mbnas, " + nvrd +
        " a.sourceof_INSERT, a.ishod, " + nvrd +
        " a.USER_statusAnketar, a.statusKontrolorNivo1, a.USER_statusKontrolorNivo1, " + nvrd +
        " (case when isnull(imastan,0)=0 then 0 else 1 end) as statusBoja" + nvrd +
        " from (select * from dbo.Adresar where IDANKETAR=N'" + kosam + "') A inner join " + nvrd +
        " (select * from dbo.P2_objekat where isnull(brojstanova,0)>0)OOO On a.mbops=ooo.mbops and a.Krug_idcd=ooo.Krug_idcd And a.kucni_broj_idCD=ooo.kucni_broj_idCD " + vbCrLf +
        " left join" + nvrd +
        " (select ishod,naziv from sif_Ishod where IDLang='" + Me.jezik.Trim + "') i on a.ishod=i.ishod" + vbCrLf +
        " left join " + nvrd +
        " (select Krug_idcd,kucni_broj_idCD, rbrstan,rbrstan as imastan,BrojStana from P2_Stan) sss on a.Krug_idcd=sss.Krug_idcd and a.kucni_broj_idCD=sss.kucni_broj_idCD and a.RbrStan=sss.RbrStan) a" + nvrd +
        " where isnull(ZakazanoDatum,'')<>'' and isnull(ZakazanoDatum,' ') like '%" + datumzakazano + "%' and isnull(statusanketar,' ') like N'%" + status + "%' and UlicakBroj like N'%" + ulicakbroj + "%' and isnull(NoviKbrojTeren,' ') like N'%" + novikbroj + "%'  order by a.ZakazanoDatum"

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
        TabControl1.SelectedTab = TabPage2
        DGV2.DataSource = dt
        TabPage2.Visible = True
        DGV2.Visible = True


        If Not dt Is Nothing AndAlso dt.Rows.Count >= 0 Then

            DGV2.Columns("zakazanovreme").Frozen = True
            'If ButtonZakazani.Text = "Svi zakazani stanovi" Then
            '    DGV2.Columns("NazivNaselja").Visible = False
            '    DGV2.Columns("krugZaPrikaz").Visible = False
            'Else
            '    DGV2.Columns("NazivNaselja").Visible = True
            '    DGV2.Columns("krugZaPrikaz").Visible = True
            'End If

            DGV2.Columns("NazivNaselja").Visible = True
            DGV2.Columns("krugZaPrikaz").Visible = True


            'DGV2.Columns("krug").Visible = False
            DGV2.Columns("ulica").Visible = False
            DGV2.Columns("idulice").Visible = False
            DGV2.Columns("kbroj").Visible = False
            DGV2.Columns("krug_idcd").Visible = False
            DGV2.Columns("kucni_broj_idcd").Visible = False
            'DGV2.Columns("kucni_broj").Visible = False
            DGV2.Columns("mbops").Visible = False
            DGV2.Columns("nazivopstine").Visible = False
            DGV2.Columns("mbnas").Visible = False
            'DGV2.Columns("NazivNaselja").Visible = False
            DGV2.Columns("kucni_broj_Deo").Visible = False
            DGV2.Columns("sourceof_INSERT").Visible = False
            DGV2.Columns("ishod").Visible = False
            DGV2.Columns("cati_nacin").Visible = False
            DGV2.Columns("USER_statusAnketar").Visible = False
            DGV2.Columns("statusKontrolorNivo1").Visible = False
            DGV2.Columns("USER_statusKontrolorNivo1").Visible = False
            DGV2.Columns("napomenaStatusAnketar").Visible = False
            DGV2.Columns("statusBoja").Visible = False
            DGV2.Columns("BrojDom").Visible = False

            DGV2.Columns("Eedit").HeaderText = ""
            DGV2.Columns("RbrStan").HeaderText = "Rbr stana"
            DGV2.Columns("ulicakbroj").HeaderText = "Adresa na mapi (ulica i kućni broj)" + nvrd + nvrd
            DGV2.Columns("nazivishod").HeaderText = "Ishod posete"
            DGV2.Columns("OOpen2").HeaderText = "Unos podataka o stanu i licima"
            DGV2.Columns("OOpen3").HeaderText = "Zahtev za doradu popisanog stana"
            DGV2.Columns("KontaktOsoba").HeaderText = "Ime i prezime osobe za kontakt"
            DGV2.Columns("statusAnketar").HeaderText = "Status" + nvrd + nvrd
            DGV2.Columns("NoviKbrojTeren").HeaderText = "Adresa na terenu" + nvrd + nvrd
            DGV2.Columns("BrojDom").HeaderText = "Broj dom / uneta dom"
            DGV2.Columns("BrojLica").HeaderText = "Broj lica / broj Popisnica"
            DGV2.Columns("BrojStana").HeaderText = "Broj stana na vratima"
            DGV2.Columns("datumdolaska").HeaderText = "Datum posete"
            DGV2.Columns("zakazanodatum").HeaderText = "Zakazan datum" + nvrd + nvrd
            DGV2.Columns("zakazanovreme").HeaderText = "Zakazano vreme"
            DGV2.Columns("nacinanketiranja").HeaderText = "" '"Način anketiranja"
            DGV2.Columns("brojtelefona").HeaderText = "Telefon"
            DGV2.Columns("IshodNapomena").HeaderText = "Napomena"
            DGV2.Columns("napomenaKontrolorNivo1").HeaderText = "Komentar instruktora"
            DGV2.Columns("EEditNapomena").HeaderText = ""
            DGV2.Columns("napomenaostanu").HeaderText = " "
            DGV2.Columns("krugZaPrikaz").HeaderText = "Krug"
            DGV2.Columns("NazivNaselja").HeaderText = "Naselje"
            DGV2.Columns("DeleteIZStana").HeaderText = "Obrisati unete podatke za stan"
            DGV2.Columns("ukupnolicastan").HeaderText = "Ukupan / očekivan broj lica u stanu"

            DGV2.Columns("prazno").HeaderText = ""
            DGV2.Columns("praznoA").HeaderText = ""
            DGV2.Columns("praznoB").HeaderText = ""
            DGV2.Columns("praznoC").HeaderText = ""

            DGV2.Columns("datumdolaska").Width = 80
            'DGV2.Columns("krugZaPrikaz").Width = 60
            DGV2.Columns("RbrStan").Width = 55
            DGV2.Columns("BrojDom").Width = 60
            DGV2.Columns("BrojLica").Width = 60
            DGV2.Columns("ulicakbroj").Width = 200
            DGV2.Columns("NoviKbrojTeren").Width = 180
            DGV2.Columns("OOpen2").Width = 60
            DGV2.Columns("nacinanketiranja").Width = 30
            DGV2.Columns("statusAnketar").Width = 40
            DGV2.Columns("BrojStana").Width = 50
            DGV2.Columns("eedit").Width = 30
            DGV2.Columns("zakazanovreme").Width = 60
            DGV2.Columns("napomenaKontrolorNivo1").Width = 100
            DGV2.Columns("EEditNapomena").Width = 30
            DGV2.Columns("napomenaostanu").Width = 100
            DGV2.Columns("OOPEN3").Width = 80
            DGV2.Columns("NazivNaselja").Width = 70
            DGV2.Columns("krugZaPrikaz").Width = 40
            DGV2.Columns("DeleteIZStana").Width = 100
            DGV2.Columns("ukupnolicastan").Width = 70

            DGV2.Columns("prazno").MinimumWidth = 2
            DGV2.Columns("prazno").Width = 3

            DGV2.Columns("praznoA").MinimumWidth = 2
            DGV2.Columns("praznoA").Width = 3
            DGV2.Columns("praznoB").MinimumWidth = 2
            DGV2.Columns("praznoB").Width = 3
            DGV2.Columns("praznoC").MinimumWidth = 2
            DGV2.Columns("praznoC").Width = 3

            DGV2.EnableHeadersVisualStyles = False
            DGV2.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

            DGV2.Columns("prazno").HeaderCell.Style.BackColor = color3
            DGV2.Columns("prazno").DefaultCellStyle.BackColor = color3

            DGV2.Columns("praznoA").HeaderCell.Style.BackColor = color3
            DGV2.Columns("praznoB").HeaderCell.Style.BackColor = color3
            DGV2.Columns("praznoC").HeaderCell.Style.BackColor = color3

            DGV2.Columns("praznoA").DefaultCellStyle.BackColor = color3
            DGV2.Columns("praznoB").DefaultCellStyle.BackColor = color3
            DGV2.Columns("praznoC").DefaultCellStyle.BackColor = color3



            If Not filterStatusDGV2 Is Nothing Then
                filterStatusDGV2.Width = DGV2.Columns("statusAnketar").Width
                filterStatusDGV2.Visible = True
                filterStatusDGV2.Location = New Point(DGV2.RowHeadersWidth, DGV2.ColumnHeadersHeight - filterStatusDGV2.Height - 1)
            End If

            If Not filterDatumZakazan Is Nothing Then
                filterDatumZakazan.Width = DGV2.Columns("zakazanodatum").Width
                filterDatumZakazan.Visible = True
                filterDatumZakazan.Location = New Point(DGV2.RowHeadersWidth +
                                                        DGV2.Columns("RbrStan").Width +
                                                        DGV2.Columns("statusAnketar").Width +
                                                        DGV2.Columns("ulicaKBroj").Width +
                                                        DGV2.Columns("NoviKbrojTeren").Width +
                                                        DGV2.Columns("BrojStana").Width +
                                                        DGV2.Columns("OOpen2").Width +
                                                        DGV2.Columns("BrojLica").Width +
                                                        DGV2.Columns("praznoA").Width +
                                                        DGV2.Columns("EEdit").Width +
                                                        DGV2.Columns("DatumDolaska").Width,
                                                        DGV2.ColumnHeadersHeight - filterDatumZakazan.Height - 1)
                '+
                '                                        DGV2.Columns("nazivishod").Width +
                '                                        DGV2.Columns("nacinanketiranja").Width +
                '                                        DGV2.Columns("KontaktOsoba").Width +
                '                                        DGV2.Columns("BrojTelefona").Width
                filterDatumZakazan.AccessibleName = filterDatumZakazan.Location.X
            End If

            If Not filterUlicaDGV2 Is Nothing Then
                filterUlicaDGV2.Width = DGV2.Columns("ulicaKBroj").Width
                filterUlicaDGV2.Visible = True
                filterUlicaDGV2.Location = New Point(DGV2.RowHeadersWidth + DGV2.Columns("RbrStan").Width + DGV2.Columns("statusAnketar").Width, DGV2.ColumnHeadersHeight - filterUlicaDGV2.Height - 1)
            End If

            If Not filterAdresaTerenDGV2 Is Nothing Then
                filterAdresaTerenDGV2.Width = DGV2.Columns("NoviKbrojTeren").Width
                filterAdresaTerenDGV2.Visible = True
                filterAdresaTerenDGV2.Location = New Point(DGV2.RowHeadersWidth + DGV2.Columns("RbrStan").Width + DGV2.Columns("statusAnketar").Width + DGV2.Columns("ulicaKBroj").Width, DGV2.ColumnHeadersHeight - filterAdresaTerenDGV2.Height - 1)
            End If

            If Not DGV2 Is Nothing Then 'DGV2.Columns("NazivNaselja").Visible = True 
                filterDatumZakazan.Location = New Point(filterDatumZakazan.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterDatumZakazan.Location.Y)
                filterStatusDGV2.Location = New Point(filterStatusDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterStatusDGV2.Location.Y)
                filterUlicaDGV2.Location = New Point(filterUlicaDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterUlicaDGV2.Location.Y)
                filterAdresaTerenDGV2.Location = New Point(filterAdresaTerenDGV2.Location.X + DGV2.Columns("NazivNaselja").Width + DGV2.Columns("krugZaPrikaz").Width, filterAdresaTerenDGV2.Location.Y)
                filterUlicaDGV2.Visible = True
                filterAdresaTerenDGV2.Visible = True
            Else
                filterUlicaDGV2.Visible = False
                filterAdresaTerenDGV2.Visible = False
            End If


            DGV2.Visible = True
        End If

    End Sub


    Sub refreshdgv3svalica(Optional ByVal fulica As String = "", Optional ByVal fime As String = "", Optional ByVal fjmbg As String = "")
        Dim dt As DataTable
        Dim str1 As String = ""
        Dim str2 As String = ""
        Dim str3 As String = ""

        '" ,case when len(ltrim(rtrim(ime)))<=2 and len(ltrim(rtrim(prezime)))<=2 then ime+' ' +prezime " + nvrd +
        '" when len(ltrim(rtrim(ime)))>2 And len(ltrim(rtrim(prezime)))<=2 then left(ltrim(rtrim(ime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(ime)))-2)+' '+prezime " + nvrd +
        '" when len(ltrim(rtrim(ime)))<=2 And len(ltrim(rtrim(prezime)))>2 then ime+' '+left(ltrim(rtrim(prezime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(prezime)))-2) " + nvrd +
        '" Else left(ltrim(rtrim(ime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(ime)))-2) " + nvrd +
        '" +' '+left(ltrim(rtrim(prezime)),2)+substring('*******************************************************',1,len(ltrim(rtrim(prezime)))-2) end as ImePrezime " + nvrd +


        Dim str As String = dodatak + "select  " + nvrd +
                            " a.[RbrStan], trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) as ulicakbroj,brojstana" + nvrd +
                            " ,a.rbrdom,a.rbrp1" + nvrd +
                            " ,trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash)))))+' ' +trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) as ImePrezime" + nvrd +
                             " , trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ImeRoditelja)='' then NULL else ImeRoditelja end),1), 1, CONVERT(varbinary, @Hash))))) ImeRoditelja,isnull([Pol],'') as pol " + nvrd +
                            " ,case when rest='999999' then [Dan]+[Mesec]+[GodRod]+rest else [Dan]+[Mesec]+[GodRod]+substring('*******************************************************',1,len(ltrim(rtrim(rest)))) end  as jmbg " + nvrd +
                            " ,isnull(cast([Starost] as varchar(3)),'') as [Starost] " + nvrd +
                            " ,isnull(cast([LiceJe] as varchar(2)),'') as [LiceJe] " + nvrd +
                            " ,isnull(cast([ClanDom] as varchar(2)),'') as ClanDom, N'👪' as OOpenStan  " + nvrd +
                            " ,' ' as praznoX, N'🖉' as EEditNapomena " + nvrd +
                            " ,isnull(a.istnote,'') as napomena, ' ' as praznoY " + nvrd +
                            " ,a.[MBOPS],a.[Krug_idcd] " + nvrd +
                            " ,a.[kucni_broj_idCD],idulice,adr.sourceof_INSERT ,  trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))) + ' ' + trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) as ImePrezimeCelo" + nvrd +
                            " ,a.ssrodstvo " + nvrd +
                            " ,(case when isnull(adr.statusAnketar,0)=0 and isnull(adr.USER_statusAnketar,'') not like 'I7%' and  isnull(adr.USER_statusAnketar,'') not like 'I8%' then '0' " + nvrd +
                            " when isnull(adr.statusAnketar,0)=0 and (isnull(adr.USER_statusAnketar,'') like 'I7%' or isnull(adr.USER_statusAnketar,'') like 'I8%') then '4' " + nvrd +
                            " else cast(isnull(adr.statusAnketar,'') as varchar(1)) end) as statusAnketar" + nvrd +
                            " ,UklonitiLice, UklonitiLiceRazlog, UklonitiLiceObjasnjenje" + nvrd +
                            " From spisaklica a left Join p2_dom b on a.[MBOPS]=b.[MBOPS] And a.[Krug_idcd]=b.[Krug_idcd] And a.[kucni_broj_idCD]=b.[kucni_broj_idCD] " + nvrd +
                            " and a.[RbrStan]=b.[RbrStan] and a.rbrdom=b.rbrdom " + nvrd +
                            " left join adresar as adr on  a.[MBOPS]=adr.[MBOPS] and a.[Krug_idcd]=adr.[Krug_idcd] and a.[kucni_broj_idCD]=adr.[kucni_broj_idCD] and a.[RbrStan]=adr.[RbrStan] " + nvrd +
                            " left join p2_stan as st on a.[MBOPS]=st.[MBOPS] and a.[Krug_idcd]=st.[Krug_idcd] and a.[kucni_broj_idCD]=st.[kucni_broj_idCD] and a.[RbrStan]=st.[RbrStan] " + nvrd +
                            " where IDANKETAR=N'" + kosam + "' and trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(UlicakBroj)='' then NULL else UlicakBroj end),1), 1, CONVERT(varbinary, @Hash))))) like N'%" + fulica + "%' and " + nvrd +
                            " (trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ime)='' then NULL else ime end),1), 1, CONVERT(varbinary, @Hash))))) + ' ' + trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(prezime)='' then NULL else prezime end),1), 1, CONVERT(varbinary, @Hash))))) like N'%" + fime + "%') and dan+mesec+godrod+rest like '%" + fjmbg + "%'"

        dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
        TabControl1.SelectedTab = TabPage3
        DGV3.DataSource = dt
        TabPage3.Visible = True
        DGV3.Visible = True


        If Not dt Is Nothing AndAlso dt.Rows.Count >= 0 Then
            DGV3.Columns(6).Frozen = True
            DGV3.Columns("idulice").Visible = False
            DGV3.Columns("krug_idcd").Visible = False
            DGV3.Columns("kucni_broj_idcd").Visible = False
            DGV3.Columns("mbops").Visible = False
            DGV3.Columns("imeprezimecelo").Visible = False
            DGV3.Columns("sourceof_INSERT").Visible = False
            DGV3.Columns("ssrodstvo").Visible = False
            DGV3.Columns("statusanketar").Visible = False
            DGV3.Columns("UklonitiLice").Visible = False
            DGV3.Columns("UklonitiLiceRazlog").Visible = False
            DGV3.Columns("UklonitiLiceObjasnjenje").Visible = False
            DGV3.Columns("jmbg").Visible = False

            DGV3.Columns("ulicakbroj").HeaderText = "Adresa na mapi (ulica i kućni broj)"
            DGV3.Columns("RbrStan").HeaderText = "Redni broj stana"
            DGV3.Columns("OOpenStan").HeaderText = "Pregled/izmena podataka o licima"
            DGV3.Columns("Rbrdom").HeaderText = "Redni broj domaćinstva"
            DGV3.Columns("rbrp1").HeaderText = "Redni broj lica"
            DGV3.Columns("imeprezime").HeaderText = "Ime i prezime lica" + nvrd + nvrd
            DGV3.Columns("imeroditelja").HeaderText = "Ime roditelja"
            DGV3.Columns("Pol").HeaderText = "Pol"
            DGV3.Columns("jmbg").HeaderText = "JMBG" + nvrd + nvrd
            DGV3.Columns("starost").HeaderText = "Starost"
            DGV3.Columns("liceje").HeaderText = "Status lica u domaćinstvu" + nvrd + "(1-član domaćinstva," + nvrd + "2-PPL)"
            DGV3.Columns("clandom").HeaderText = "Član domaćinstva je" + nvrd + "(1-prisutan," + nvrd + "2-odsutan)"
            DGV3.Columns("eeditnapomena").HeaderText = ""
            DGV3.Columns("napomena").HeaderText = "Napomena"
            DGV3.Columns("praznoX").HeaderText = ""
            DGV3.Columns("praznoY").HeaderText = ""
            DGV3.Columns("brojstana").HeaderText = "Broj stana na vratima"

            DGV3.Columns("praznoX").MinimumWidth = 2
            DGV3.Columns("praznoX").Width = 3
            DGV3.Columns("praznoX").HeaderCell.Style.BackColor = color3
            DGV3.Columns("praznoX").DefaultCellStyle.BackColor = color3

            DGV3.Columns("praznoY").MinimumWidth = 2
            DGV3.Columns("praznoY").Width = 3
            DGV3.Columns("praznoY").HeaderCell.Style.BackColor = color3
            DGV3.Columns("praznoY").DefaultCellStyle.BackColor = color3


            DGV3.Columns("ulicakbroj").Width = 160
            DGV3.Columns("RbrStan").Width = 100
            DGV3.Columns("OOpenStan").Width = 100
            DGV3.Columns("Rbrdom").Width = 100
            DGV3.Columns("rbrp1").Width = 100
            DGV3.Columns("imeprezime").Width = 150
            DGV3.Columns("imeroditelja").Width = 75
            DGV3.Columns("Pol").Width = 40
            DGV3.Columns("jmbg").Width = 100
            DGV3.Columns("starost").Width = 60
            DGV3.Columns("liceje").Width = 150
            DGV3.Columns("clandom").Width = 150
            DGV3.Columns("eeditnapomena").Width = 50
            DGV3.Columns("napomena").Width = 150
            DGV3.Columns("brojstana").Width = 100

            DGV3.EnableHeadersVisualStyles = False
            DGV3.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))


            DGV3.Visible = True

            'For i As Integer = 0 To DGV3.Rows.Count - 1
            '    If DGV3.Rows(i).Cells(DGV3.Columns("ssrodstvo").Index).Value.ToString.Trim = "1" Then
            '        DGV3.Rows(i).DefaultCellStyle.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold)
            '    End If
            '    If DGV3.Rows(i).Cells(DGV3.Columns("UklonitiLice").Index).Value.ToString.Trim = "1" Then
            '        DGV3.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro
            '    End If
            'Next

            If Not filterUlicaDGV3 Is Nothing Then
                filterUlicaDGV3.Width = DGV3.Columns("ulicaKBroj").Width
                filterUlicaDGV3.Location = New Point(DGV3.Columns("RbrStan").Width + DGV3.RowHeadersWidth, DGV3.ColumnHeadersHeight - filterUlicaDGV3.Height - 1)
                'filterUlicaDGV3.Visible = True
                filterUlicaDGV3.AccessibleName = filterUlicaDGV3.Location.X
            End If

            If Not filterImePrezime Is Nothing Then
                filterImePrezime.Width = DGV3.Columns("imeprezime").Width
                filterImePrezime.Location = New Point(DGV3.RowHeadersWidth + DGV3.Columns("ulicakbroj").Width + DGV3.Columns("RbrStan").Width + DGV3.Columns("rbrdom").Width + DGV3.Columns("rbrp1").Width + DGV3.Columns("brojstana").Width, DGV3.ColumnHeadersHeight - filterImePrezime.Height - 1)
                filterImePrezime.Visible = True
                filterImePrezime.AccessibleName = filterImePrezime.Location.X
            End If
            'If Not filterJMBG Is Nothing Then
            '    filterJMBG.Width = DGV3.Columns("jmbg").Width
            '    filterJMBG.Location = New Point(DGV3.RowHeadersWidth + DGV3.Columns("ulicakbroj").Width + DGV3.Columns("RbrStan").Width + DGV3.Columns("OOpenStan").Width + DGV3.Columns("rbrdom").Width + DGV3.Columns("rbrp1").Width + DGV3.Columns("brojstana").Width + DGV3.Columns("imeprezime").Width + DGV3.Columns("ImeRoditelja").Width + DGV3.Columns("Pol").Width, DGV3.ColumnHeadersHeight - filterJMBG.Height - 1)
            '    filterJMBG.Visible = True
            '    filterJMBG.AccessibleName = filterJMBG.Location.X
            'End If

        End If

    End Sub


    Private Sub combobox_Changed(ByVal sender As Object, ByVal e As EventArgs)


        If DirectCast(sender, ComboBox).Text <> "" Then
            If DGV1.Visible = True Then
                Dim pom As String = filterStatus.Text
                If pom.Length > 0 AndAlso pom <> "" Then pom = pom.Substring(0, 1)
                refreshDGV1(filterUlica.Text, pom, filterUlicaMapa.Text, filterNapomenaKBR.Text)
                If DGV1.Rows.Count > 0 Then
                    DGV1.Focus()
                    DGV1.ClearSelection()
                    DGV1.Rows(0).Selected = True
                End If
            End If
        End If


    End Sub

    Private Sub comboboxdatum_Changed(ByVal sender As Object, ByVal e As EventArgs)


        If DirectCast(sender, ComboBox).Text <> "" Then
            If DGV2.Visible = True Then
                If Not DGV2.Tag Is Nothing AndAlso IsNumeric(DGV2.Tag) = True Then
                Else
                    DGV2.Tag = -1
                End If
                Dim pom As String = filterStatusDGV2.Text
                If pom.Length > 0 AndAlso pom <> "" Then pom = pom.Substring(0, 1)
                If pom = "*" Then pom = ""
                If Not filterDatumZakazan.Tag Is Nothing AndAlso filterDatumZakazan.Tag = "" Then
                    If DGV1.SelectedCells.Count > 0 Then
                        refreshDGV2(DGV2.Tag, filterDatumZakazan.Text, pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
                    Else
                        'ivanaaaa
                        Call praznidgv2()
                    End If

                Else
                    If filterDatumZakazan.Text = " " OrElse filterDatumZakazan.Text = "*" Then
                        refreshdgv2zakazni("", pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
                    Else
                        refreshdgv2zakazni(filterDatumZakazan.Text, pom, filterUlicaDGV2.Text, filterAdresaTerenDGV2.Text)
                    End If
                End If

                If DGV2.Rows.Count > 0 Then
                    DGV2.Focus()
                    DGV2.ClearSelection()
                    DGV2.Rows(0).Selected = True
                End If
            End If
        End If

    End Sub
    Private Sub comboboxdgv2status_Changed(ByVal sender As Object, ByVal e As EventArgs)

        If DirectCast(sender, ComboBox).Text <> "" Then
            If DGV2.Visible = True Then

                Dim pom As String = filterStatusDGV2.Text
                If pom.Length > 0 AndAlso pom <> "" Then pom = pom.Substring(0, 1)
                If pom = "*" Then pom = ""

                If Not filterDatumZakazan.Tag Is Nothing AndAlso filterDatumZakazan.Tag = "" Then
                    If Not DGV2.Tag Is Nothing AndAlso IsNumeric(DGV2.Tag) = True Then
                    Else
                        DGV2.Tag = -1
                    End If
                    refreshDGV2(DGV2.Tag, filterDatumZakazan.Text, pom)
                Else
                    If filterDatumZakazan.Text = " " OrElse filterDatumZakazan.Text = "*" Then
                        refreshdgv2zakazni("", pom)
                    Else
                        refreshdgv2zakazni(filterDatumZakazan.Text, pom)
                    End If
                End If

                If DGV2.Rows.Count > 0 Then
                    DGV2.Focus()
                    DGV2.ClearSelection()
                    DGV2.Rows(0).Selected = True
                End If
            End If
        End If

    End Sub
    Function btnandtxtfocused() As Control

        btnandtxtfocused = Nothing
        For Each cntl As Control In Me.Controls
            If TypeOf cntl Is Panel Then
                For Each k As Control In cntl.Controls
                    If (TypeOf k Is Button AndAlso DirectCast(k, Button).Enabled = True AndAlso DirectCast(k, Button).Focused = True) OrElse (TypeOf k Is TextBox AndAlso DirectCast(k, TextBox).Enabled = True AndAlso DirectCast(k, TextBox).Focused = True) Then
                        btnandtxtfocused = k
                        Exit Function
                    End If
                Next
            End If
            If (TypeOf cntl Is Button AndAlso DirectCast(cntl, Button).Enabled = True AndAlso DirectCast(cntl, Button).Focused = True) OrElse (TypeOf cntl Is TextBox AndAlso DirectCast(cntl, TextBox).Enabled = True AndAlso DirectCast(cntl, TextBox).Focused = True) Then
                btnandtxtfocused = cntl
                Exit For
            End If
        Next
    End Function

    Function tabpagefocused() As Control

        tabpagefocused = Nothing
        For Each cntl As Control In TabControl1.Controls
            If (TypeOf cntl Is TabPage AndAlso DirectCast(cntl, TabPage).Enabled = True AndAlso DirectCast(cntl, TabPage).Focused) Then
                tabpagefocused = cntl
                Exit For
            End If
        Next
    End Function

    'Dim odaklejedosao As String = ""
    Private Sub TabPage1_Validating(sender As Object, e As CancelEventArgs) Handles TabPage1.Validating
        If nevena = True OrElse ButtonIzlaz.Focused OrElse ButtonResetPK.Focused OrElse ButtonResetUl.Focused OrElse ButtonIzvestaji.Focused OrElse ButtonZakazani.Focused OrElse BtnSvaLica.Focused OrElse btnVracanjeKrugova.Focused Then
            Exit Sub
        End If
        'odaklejedosao = "tabpage1"
        Dim k As Control = btnandtxtfocused()
        If Not k Is Nothing Then
            If DGV1.Visible = True AndAlso DGV1.Rows.Count > 1 Then
                If DGV1.SelectedCells.Count > 0 Then
                    Call refreshDGV2(DGV1.SelectedCells.Item(0).RowIndex)
                End If
                DGV1.Focus()
                'DGV2.ClearSelection()
                DGV1.Rows(1).Selected = True
                DGV1.Rows(1).Selected = False
            End If

            k.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub TabPage2_Validating(sender As Object, e As CancelEventArgs) Handles TabPage2.Validating
        'odaklejedosao = "tabpage2"
        If nevena = True OrElse ButtonIzlaz.Focused OrElse ButtonResetPK.Focused OrElse ButtonResetUl.Focused OrElse ButtonIzvestaji.Focused OrElse ButtonZakazani.Focused OrElse BtnSvaLica.Focused OrElse btnLegenda1M.Focused OrElse btnLegenda2M.Focused OrElse ButtonSave.Focused OrElse btnVracanjeKrugova.Focused Then
            Exit Sub
        End If
        Dim k As Control = btnandtxtfocused()
        If Not k Is Nothing Then
            If DGV2.Visible = True AndAlso DGV2.Rows.Count > 1 Then
                Dim pomrowDGV1 As Integer = vratiSelektvanRedDGV1(DGV2.SelectedCells.Item(0).RowIndex)
                If DGV2.SelectedCells.Count > 0 Then
                    Call refreshDGV3(pomrowDGV1)
                    If DGV3.Rows.Count > 0 Then
                        DGV3.Visible = True
                        Me.TabControl1.SelectedTab = Me.TabPage3
                    Else
                        DGV3.Visible = False
                        Me.TabControl1.SelectedTab = Me.TabPage2
                    End If
                ElseIf DGV1.SelectedCells.Count > 0 Then
                    refreshDGV3(pomrowDGV1)
                End If
                DGV2.Focus()
                'DGV2.ClearSelection()
                DGV2.Rows(1).Selected = True
                DGV2.Rows(1).Selected = False
            End If

            k.Focus()
            Exit Sub
        End If

    End Sub

    Dim oldtabpage As TabPage
    Dim newtabpage As TabPage
    Private Sub TabControl1_deselecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Deselecting
        oldtabpage = e.TabPage
    End Sub
    Dim pRbrStan As String = ""
    Dim nevena As Boolean = False

    Private Sub TabControl1_selecting(sender As Object, e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        If nevena = True Then
            Exit Sub
        End If
        pRbrStan = ""
        TabPage2.Tag = ""
        TabPage3.Tag = ""
        filterUlicaDGV3.Text = ""
        filterImePrezime.Text = ""
        'filterJMBG.Text = ""
        If (Not filterDatumZakazan.Tag Is Nothing AndAlso filterDatumZakazan.Tag = "svi") OrElse (Not filterUlicaDGV3.Tag Is Nothing AndAlso filterUlicaDGV3.Tag = "svi") Then
            Exit Sub
        End If
        If DGV1.SelectedCells.Count > 0 Then
            Dim iRowIndex As Integer = Me.DGV1.SelectedCells.Item(0).RowIndex
            Dim dt As DataTable
            Dim pkucni_broj_idCD As String = DGV1.Rows(iRowIndex).Cells(DGV1.Columns("kucni_broj_idCD").Index).Value.ToString
            Dim pIDUlice As String = DGV1.Rows(iRowIndex).Cells(DGV1.Columns("IDULICE").Index).Value.ToString
            If Not oldtabpage Is Nothing AndAlso oldtabpage Is TabPage1 AndAlso e.TabPage Is TabPage2 Then
                Dim str As String = dajSQLzaDGV2(nizACTB(0).sselectedValue.Trim, pIDUlice, pkucni_broj_idCD, "", "")
                dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
                filterDatumZakazan.Text = "*"
                filterUlicaDGV2.Text = ""
                filterAdresaTerenDGV2.Text = ""
                filterStatusDGV2.Text = "*"
                If dt.Rows.Count > 0 Then
                    refreshDGV2(iRowIndex, "", "")
                    DGV2.Tag = iRowIndex
                    If DGV2.Rows.Count > 0 Then
                        TabControl1.SelectedTab.TabIndex = 1
                        DGV2.Focus()
                        DGV2.ClearSelection()
                        DGV2.Rows(0).Selected = True

                    End If
                    Call popunicbo(filterDatumZakazan, "select distinct zakazanodatum as displaymember, zakazanodatum as valuemember from adresar where IDANKETAR=N'" + kosam + "' and isnull(zakazanodatum,'')<>'' and " +
                                                            "mbops='" + atbOps.sselectedValue + "'" +
                                                            " and Krug_idcd='" + atbPK.sselectedValue + "'" +
                                                            " and kucni_broj_idCD='" + pkucni_broj_idCD.Trim + "'" +
                                                            " order by ZakazanoDatum", Me.DBConnectionString, False, False, True, True)
                    newtabpage = e.TabPage
                    Exit Sub
                Else
                    'TabPage2.Tag = "bezstanova"
                    ISTMessageBox.Show("Nema unetih stanova u okviru ovog kućnog broja.")
                    e.Cancel = True
                    newtabpage = Nothing
                    Exit Sub
                End If
            ElseIf Not oldtabpage Is Nothing AndAlso oldtabpage Is TabPage1 AndAlso e.TabPage Is TabPage3 Then
                'OVO SMO TRENUTNO ISKLJUCILI NE BRISATI!!!!!!!!!
                'Dim str As String = dajSQLzaDGV3(nizACTB(0).sselectedValue.Trim, pIDUlice, pkucni_broj_idCD)
                'dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
                'If dt.Rows.Count > 0 Then
                '    DGV2.Tag = iRowIndex
                '    refreshDGV2(iRowIndex)
                '    'DGV3.Tag = iRowIndex
                '    If DGV3.Rows.Count > 0 Then
                '        TabControl1.SelectedTab.TabIndex = 2
                '        DGV3.Focus()
                '        DGV3.Rows(0).Selected = True
                '    End If
                '    newtabpage = e.TabPage
                '    Exit Sub
                'Else
                '    ISTMessageBox.Show("Nema unetih lica u okviru ovog kućnog broja.")
                '    e.Cancel = True
                '    newtabpage = Nothing
                '    Exit Sub
                'End If
                e.Cancel = True
                newtabpage = Nothing
                Exit Sub
            ElseIf Not oldtabpage Is Nothing AndAlso oldtabpage Is TabPage2 AndAlso e.TabPage Is TabPage3 Then
                If DGV2.SelectedCells.Count > 0 Then
                    Dim aRowIndex As Integer = Me.DGV2.SelectedCells.Item(0).RowIndex
                    pRbrStan = DGV2.Rows(aRowIndex).Cells(DGV2.Columns("rbrstan").Index).Value.ToString.Trim
                Else
                    pRbrStan = ""
                End If
                Dim str As String = dajSQLzaDGV3(nizACTB(0).sselectedValue.Trim, pIDUlice, pkucni_broj_idCD, pRbrStan)
                dt = izvrsiSQLvratiDT(str, Me.DBConnectionString, Nothing)
                If dt.Rows.Count > 0 Then
                    DGV2.Tag = iRowIndex
                    refreshDGV2(iRowIndex,,,,, pRbrStan)
                    'DGV3.Tag = iRowIndex
                    If DGV3.Rows.Count > 0 Then
                        TabControl1.SelectedTab.TabIndex = 2
                        DGV3.Focus()
                        DGV3.ClearSelection()
                        DGV3.Rows(0).Selected = True
                    End If
                    newtabpage = e.TabPage
                    Exit Sub
                Else
                    'TabPage3.Tag = "bezlica"
                    ISTMessageBox.Show("Nema unetih lica u okviru ovog stana.")
                    e.Cancel = True
                    newtabpage = Nothing
                    Exit Sub
                End If
            ElseIf Not oldtabpage Is Nothing AndAlso oldtabpage Is TabPage3 AndAlso e.TabPage Is TabPage2 Then
                newtabpage = e.TabPage
            End If
        Else
            'TabPage2.Tag = "nijeodabrano"
            If filterDatumZakazan.Tag = "svi" OrElse filterUlicaDGV3.Tag = "svi" OrElse oldtabpage Is Nothing Then
                e.Cancel = True
                newtabpage = Nothing
            Else
                e.Cancel = True
                newtabpage = Nothing
                ISTMessageBox.Show("Odaberite kućni broj kako biste mogli da pristupite pregledu stanova.")
            End If
        End If
    End Sub

    Private Sub cbUklonitiIzMaterijala_CheckedChanged(sender As Object, e As EventArgs) Handles cbUklonitiIzMaterijala.CheckedChanged

        If cbUklonitiIzMaterijala.Checked = True Then
            'lblRazlogUklanjanja.Visible = True
            'cmbRazlogUklanjanja.Visible = True
            lblObjasnjenjeUklanjanja.Visible = True
            tboxObjasnjenjeUklanjanja.Visible = True
        End If

        If cbUklonitiIzMaterijala.Checked = False Then
            lblRazlogUklanjanja.Visible = False
            cmbRazlogUklanjanja.Visible = False
            lblObjasnjenjeUklanjanja.Visible = False
            tboxObjasnjenjeUklanjanja.Visible = False
            cmbRazlogUklanjanja.Text = ""
            'cmbRazlogUklanjanja.ValueMember = ""
            'cmbRazlogUklanjanja.DisplayMember = ""
            tboxObjasnjenjeUklanjanja.Text = ""
        End If
    End Sub
    Private Sub cmbUkloniti_Changed(ByVal sender As Object, ByVal e As EventArgs)
        tboxObjasnjenjeUklanjanja.Focus()
    End Sub

    Private Sub DGV3_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGV3.CellFormatting
        'For i As Integer = 0 To DGV3.Rows.Count - 1
        If DGV3.Rows(e.RowIndex).Cells(DGV3.Columns("ssrodstvo").Index).Value.ToString.Trim = "1" Then
            DGV3.Rows(e.RowIndex).DefaultCellStyle.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold)
        End If
        If DGV3.Rows(e.RowIndex).Cells(DGV3.Columns("UklonitiLice").Index).Value.ToString.Trim = "1" Then
            DGV3.Rows(e.RowIndex).DefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro
        End If
        'Next
    End Sub
    Private Sub btnMapa_Click(sender As Object, e As EventArgs) Handles btnMapa.Click, btnMapaKbr.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim ulica As String = ""
        Dim vred As String = tboxkbr.Text.Trim
        Dim vred4 As String = tboxKucniBrIDCD.Text.Trim
        Dim vred5 As String = ""
        Dim vred6 As String = ""

        Try
            Dim kbr As String = ""

            If sender.name.trim.toupper = "BTNMAPAKBR" Then
                kbr = "KBR"
                If atbUlica.sselectedValue = "000000000000" Then
                    ulica = atbULKBR.sselectedText
                    vred5 = atbULKBR.sselectedValue
                    vred6 = atbULKBR.sselectedText
                Else
                    ulica = textboxUlica.Text.Trim
                    vred5 = textboxIDUlice.Text.Trim
                    vred6 = textboxUlica.Text.Trim
                End If
                If atbUlica.sselectedValue = "000000000000" AndAlso atbULKBR.sselectedText = "" Then
                    ISTMessageBox.Show("Nije izabrana ulica!")
                    atbULKBR.Focus()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                ElseIf atbUlica.sselectedValue <> "000000000000" And textboxUlica.Text.Trim = "" Then
                    ISTMessageBox.Show("Nije izabrana ulica!")
                    textboxUlica.Focus()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If

                If vred = "" Then
                    ISTMessageBox.Show("Polje KUĆNI BROJ ne sme biti prazno!")
                    tboxkbr.Focus()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If

                If proveraKbr(vred) = False Then
                    ISTMessageBox.Show("Kućni broj nije ispravan!")
                    tboxkbr.Focus()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If

                Dim strProvera As String = dodatak + "select ltrim(rtrim(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))))) from Adresar a left join p2_objekat b on a.kucni_broj_idcd=b.kucni_broj_idcd and a.krug_idcd=b.krug_idcd " + vbCrLf +
                       " where IDANKETAR=N'" + kosam + "' and a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and a.idulice='" + vred5.Trim + "' and trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash)))))=N'" + vred + "'"
                Dim dtProvera As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Nothing)
                If dtProvera.Rows.Count > 0 Then
                    ISTMessageBox.Show("Ne možete uneti već postojeći kućni broj!")
                    tboxkbr.Focus()
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                    Exit Sub
                End If

            Else
                kbr = ""
            End If

            Dim prepisinove As String = dodatak + "select distinct left(krug_idcd,4), longituda, latituda, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kBroj)='' then NULL else kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj, PKuSK, SK from adresar where sourceof_INSERT='ANK' and isnull(naslediood,'')<>'' and IDAnketar=N'" + kosam + "' and isnull(KBROdDrugogDodatNaMapu,0)<>1"
            Dim updateprepisane As String = "update adresar set KBROdDrugogDodatNaMapu=1  where sourceof_INSERT='ANK' and isnull(naslediood,'')<>'' and IDAnketar=N'" + kosam + "' and isnull(KBROdDrugogDodatNaMapu,0)<>1"
            Dim dtprebaci As DataTable = izvrsiSQLvratiDT(prepisinove, Me.DBConnectionString, Me.jezik)
            Dim strzatxt As String = ""
            If dtprebaci.Rows.Count > 0 Then
                For i As Integer = 0 To dtprebaci.Rows.Count - 1
                    strzatxt = strzatxt + dtprebaci.Rows(i).Item(0).ToString.Trim + "$" + dtprebaci.Rows(i).Item(1).ToString.Replace(",", ".").Trim + "$" + dtprebaci.Rows(i).Item(2).ToString.Replace(",", ".").Trim + "$" + dtprebaci.Rows(i).Item(3).ToString.Trim + "$" + dtprebaci.Rows(i).Item(4).ToString.Trim + "$" + dtprebaci.Rows(i).Item(5).ToString.Trim + "$" + dtprebaci.Rows(i).Item(6).ToString.Trim + ";"
                Next
            End If

            Dim opstina As String = atbOps.sselectedValue.Trim
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt", "", False)
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt", strzatxt, False)



            Dim sreditacke As String = dodatak + "select distinct left(krug_idcd,4), longituda, latituda, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as Ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kBroj)='' then NULL else kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj from adresar where sourceof_INSERT='ANK' and IDAnketar=N'" + kosam + "'"
            Dim dtsreditacke As DataTable = izvrsiSQLvratiDT(sreditacke, Me.DBConnectionString, Me.jezik)
            Dim sreditacketxt As String = ""
            If dtsreditacke.Rows.Count > 0 Then
                For i As Integer = 0 To dtsreditacke.Rows.Count - 1
                    sreditacketxt = sreditacketxt + dtsreditacke.Rows(i).Item(0).ToString.Trim + "$" + dtsreditacke.Rows(i).Item(1).ToString.Replace(",", ".").Trim + "$" + dtsreditacke.Rows(i).Item(2).ToString.Replace(",", ".").Trim + "$" + dtsreditacke.Rows(i).Item(3).ToString.Trim + "$" + dtsreditacke.Rows(i).Item(4).ToString.Trim + ";"
                Next
            End If
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\SrediTacke.txt", "", False)
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\SrediTacke.txt", sreditacketxt, False)


            'Dim str As String = " select suser_name()"
            'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)

            If opstina.Trim <> "" Then
                'Dim korisnik As String = dt.Rows(0).Item(0)
                'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\formaMape.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\formaMape.txt", kbr.Trim, False)
                '''''TACKANJE PREMA ULICIIII
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorUlica.txt", "", False)

                If kbr = "KBR" Then
                    If ulica.Trim <> "" Then
                        My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorUlica.txt", "(*);", False)
                    End If
                ElseIf kbr = "" Then
                    If atbUlica.sselectedText <> "" Then
                        Dim prepisiul As String = atbUlica.sselectedText.Trim + ";"
                        My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorUlica.txt", prepisiul, False)
                    End If
                End If


                If kbr = "KBR" Then

                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\ulica.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\ulica.txt", "'" + ulica.Trim + "'", False)

                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\kbr.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\kbr.txt", "'" + tboxkbr.Text.Trim + "'", False)

                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\krug.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\krug.txt", "'" + atbPK.sselectedText.Trim.Substring(0, 4) + "'", False)

                    'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjaulica.txt", "", False)
                    'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjaulica.txt", ulica.Trim, False)

                    'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjikbr.txt", "", False)
                    'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjikbr.txt", tboxkbr.Text.Trim, False)
                End If

            End If
            Call kucnibrojeviMapaBojenje()
            ' Dim a As Boolean = CheckIfRunning()
            Dim overlayHandle As ISTFormIsLoading
            overlayHandle = New ISTFormIsLoading(Me, Me.ButtonIzlaz.Parent)
            overlayHandle.Show()
            Dim p As Process()
            p = Process.GetProcessesByName("qgis-ltr-bin")
            If p.Length > 0 Then
                For Each pp As Process In Process.GetProcesses
                    If pp.ProcessName = "qgis-ltr-bin" Then
                        pp.Kill()
                    End If
                Next
            End If

            'Button.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim myProcess As Process = Process.Start("C:\IST\QGIS\Popis_21\Resources\qgis_v2.bat")
            myProcess.WaitForExit()
            Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
            psi.FileName = "C:\Program Files\QGIS 3.4\bin\qgis-ltr-bin.exe"
            psi.Arguments = atbOps.sselectedValue.Trim + ".qgs"
            psi.WorkingDirectory = "C:\IST\QGIS\Popis_21\" + atbOps.sselectedValue.Trim + "\"
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
            Dim ppp As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
            ppp.WaitForExit()
            overlayHandle.Close()
            ISTMessageBox.Show("Rad sa mapom je završen, možete nastaviti sa radom u aplikaciji za unos.")


            Me.Cursor = Cursors.Default


            Dim fileReader11 As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt")
            If fileReader11.Trim = "" Then
                Dim ok As String = izvrsiSQL(updateprepisane, Me.DBConnectionString)
                If ok <> "ok" Then
                    ISTMessageBox.Show("Greška 5! Zovite administratora!")
                    Me.Close()
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try



        Me.Cursor = Cursors.Default
        tboxkbr.Enabled = False
        textboxUlica.Enabled = False
        atbULKBR.Enabled = False
        btnMapaKbr.Enabled = False
        llNastavi.Enabled = True

    End Sub
    Private Sub ProcessExited(ByVal sender As Object, ByVal e As System.EventArgs)
        ISTMessageBox.Show("nevenica")
    End Sub


    Private Sub btnMapaIzmena_Click(sender As Object, e As EventArgs) Handles btnMapaIzmenaKBR.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim vred As String = tboxkbr.Text.Trim
        Dim vred4 As String = tboxKucniBrIDCD.Text.Trim

        'tboxSource.Text = DGV1.Rows(si).Cells(DGV1.Columns("sourceof_INSERT").Index).Value.ToString
        'tboxkbr.Text = DGV1.Rows(si).Cells(DGV1.Columns("kbroj").Index).Value.ToString
        'tbox1A.Text = DGV1.Rows(si).Cells(DGV1.Columns("NoviKbrojTeren").Index).Value.ToString
        'tboxLatituda.Text = DGV1.Rows(si).Cells(DGV1.Columns("latituda").Index).Value.ToString
        'tboxLongituda.Text = DGV1.Rows(si).Cells(DGV1.Columns("longituda").Index).Value.ToString
        'tboxNapomenaOKucnomBroju.Text = DGV1.Rows(si).Cells(DGV1.Columns("NapomenaOKucnomBroju").Index).Value.ToString
        'tboxKucniBrIDCD.Text = DGV1.Rows(si).Cells(DGV1.Columns("kucni_broj_idcd").Index).Value.ToString
        'textboxIDUlice.Text = DGV1.Rows(si).Cells(DGV1.Columns("idulice").Index).Value.ToString
        'textboxUlica.Text = DGV1.Rows(si).Cells(DGV1.Columns("ulica").Index).Value.ToString

        Try
            If vred = "" Then
                ISTMessageBox.Show("Polje KUĆNI BROJ ne sme biti prazno!")
                tboxkbr.Focus()
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If

            Dim strProvera As String = dodatak + "select distinct ltrim(rtrim(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash))))))) from Adresar a left join p2_objekat b on a.kucni_broj_idcd=b.kucni_broj_idcd And a.krug_idcd=b.krug_idcd " + vbCrLf +
                       " where IDANKETAR=N'" + kosam + "' and a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and a.idulice='" + textboxIDUlice.Text.Trim + "' and trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.kBroj)='' then NULL else a.kBroj end),1), 1, CONVERT(varbinary, @Hash)))))=N'" + vred + "'"
            Dim dtProvera As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Nothing)
            If dtProvera.Rows.Count > 0 AndAlso dtProvera.Rows(0).Item(0).ToString <> stariKBR Then
                ISTMessageBox.Show("Ne možete uneti već postojeći kućni broj!")
                tboxkbr.Focus()
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If

            'Dim str As String = " select suser_name()"
            'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
            Dim opstina As String = atbOps.sselectedValue.Trim
            ''''''TACKANJE PREMA ULICIIII
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorUlica.txt", "", False)
            If opstina.Trim <> "" Then

                If btnMapaIzmenaKBR.Tag = "izmena" Then
                    If opstina.Trim <> "" Then
                        If tboxLongituda.Text = staraLong AndAlso tboxLatituda.Text = staraLat AndAlso tboxkbr.Text <> stariKBR Then
                            Dim fileReader2 As String = ""
                            fileReader2 = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\UpdateKBR.txt")
                            fileReader2 = fileReader2 + atbPK.sselectedText.Trim.Substring(0, 4) + "$" + textboxUlica.Text + "$" + stariKBR + "$" + tboxkbr.Text + "$" + tboxLongituda.Text + "$" + tboxLatituda.Text + ";"
                            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\UpdateKBR.txt", "", False)
                            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\UpdateKBR.txt", "" + fileReader2.Trim + "", False)
                        End If
                    End If
                End If
                ''''''TACKANJE PREMA ULICIIII
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorUlica.txt", "(*);", False)
                'Dim korisnik As String = dt.Rows(0).Item(0)
                'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\formaMape.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\formaMape.txt", "KBR", False)

                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\ulica.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\ulica.txt", "'" + textboxUlica.Text + "'", False)

                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\kbr.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\kbr.txt", "'" + tboxkbr.Text.Trim + "'", False)

                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\krug.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\krug.txt", "'" + atbPK.sselectedText.Trim.Substring(0, 4) + "'", False)

                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjaulica.txt", "", False)
                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjaulica.txt", ulica.Trim, False)

                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjikbr.txt", "", False)
                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjikbr.txt", tboxkbr.Text.Trim, False)
            End If
            ' Dim a As Boolean = CheckIfRunning()

            '    'Dim info As New ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Desktop\Za QGIS\" + atbOps.sselectedValue.Trim + "\qgis_v2.bat")
            '    Dim info As New ProcessStartInfo("C:\IST\QGIS\Popis_21\Resources\qgis_v2.bat")
            '    ' Dim p As String = "dial_string=" + phoneNumber
            '    'info.Verb = "runas"
            '    info.WindowStyle = ProcessWindowStyle.Maximized
            '    info.UseShellExecute = True
            '    ' info.Arguments = p

            '    Dim p As Process()
            '    p = Process.GetProcessesByName("qgis-ltr-bin")
            '    If p.Length > 0 Then
            '        For Each pp As Process In Process.GetProcesses
            '            If pp.ProcessName = "qgis-ltr-bin" Then
            '                pp.Kill()
            '            End If
            '        Next
            '    End If

            '    Process.Start(info)
            '    Dim podigao As Integer = -1
            '    p = Process.GetProcessesByName("qgis-ltr-bin")
            '    Dim izadji As Boolean = False
            '    For i As Integer = 1 To 10000000
            '        For Each pp As Process In Process.GetProcesses
            '            If i > 5500 Then
            '                If pp.ProcessName = "qgis-ltr-bin" Then
            '                    podigao = 1
            '                Else
            '                    podigao = 0
            '                    Exit For
            '                End If
            '            End If
            '        Next
            '        If podigao = 0 Then
            '            overlayHandle.Close()
            '            Me.Cursor = System.Windows.Forms.Cursors.Default
            '            Exit For
            '        End If
            '    Next
            '    'process.WaitForExit()
            '    'ISTMessageBox.Show("bb")
            'Catch ex As Exception
            '    ISTMessageBox.Show(ex.Message)
            'End Try

            Dim prepisinove As String = dodatak + "select distinct left(krug_idcd,4), longituda, latituda, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as Ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kBroj)='' then NULL else kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj, PKuSK, SK from adresar where sourceof_INSERT='ANK' and isnull(naslediood,'')<>'' and IDAnketar=N'" + kosam + "' and isnull(KBROdDrugogDodatNaMapu,0)<>1"
            Dim updateprepisane As String = "update adresar set KBROdDrugogDodatNaMapu=1  where sourceof_INSERT='ANK' and isnull(naslediood,'')<>'' and IDAnketar=N'" + kosam + "' and isnull(KBROdDrugogDodatNaMapu,0)<>1"
            Dim dtprebaci As DataTable = izvrsiSQLvratiDT(prepisinove, Me.DBConnectionString, Me.jezik)
            Dim strzatxt As String = ""
            If dtprebaci.Rows.Count > 0 Then
                For i As Integer = 0 To dtprebaci.Rows.Count - 1
                    strzatxt = strzatxt + dtprebaci.Rows(i).Item(0).ToString.Trim + "$" + dtprebaci.Rows(i).Item(1).ToString.Replace(",", ".").Trim + "$" + dtprebaci.Rows(i).Item(2).ToString.Replace(",", ".").Trim + "$" + dtprebaci.Rows(i).Item(3).ToString.Trim + "$" + dtprebaci.Rows(i).Item(4).ToString.Trim + "$" + dtprebaci.Rows(i).Item(5).ToString.Trim + "$" + dtprebaci.Rows(i).Item(6).ToString.Trim + ";"
                Next
            End If
            'Dim opstina As String = atbOps.sselectedValue.Trim
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt", "", False)
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt", strzatxt, False)

            Dim sreditacke As String = dodatak + "select distinct left(krug_idcd,4), longituda, latituda, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as Ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kBroj)='' then NULL else kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj from adresar where sourceof_INSERT='ANK' and IDAnketar=N'" + kosam + "'"
            Dim dtsreditacke As DataTable = izvrsiSQLvratiDT(sreditacke, Me.DBConnectionString, Me.jezik)
            Dim sreditacketxt As String = ""
            If dtsreditacke.Rows.Count > 0 Then
                For i As Integer = 0 To dtsreditacke.Rows.Count - 1
                    sreditacketxt = sreditacketxt + dtsreditacke.Rows(i).Item(0).ToString.Trim + "$" + dtsreditacke.Rows(i).Item(1).ToString.Replace(",", ".").Trim + "$" + dtsreditacke.Rows(i).Item(2).ToString.Replace(",", ".").Trim + "$" + dtsreditacke.Rows(i).Item(3).ToString.Trim + "$" + dtsreditacke.Rows(i).Item(4).ToString.Trim + ";"
                Next
            End If
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\SrediTacke.txt", "", False)
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\SrediTacke.txt", sreditacketxt, False)
            Call kucnibrojeviMapaBojenje()
            Dim overlayHandle As ISTFormIsLoading
            overlayHandle = New ISTFormIsLoading(Me, Me.ButtonIzlaz.Parent)
            overlayHandle.Show()


            Dim p As Process()
            p = Process.GetProcessesByName("qgis-ltr-bin")
            If p.Length > 0 Then
                For Each pp As Process In Process.GetProcesses
                    If pp.ProcessName = "qgis-ltr-bin" Then
                        pp.Kill()
                    End If
                Next
            End If

            'Button.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim myProcess As Process = Process.Start("C:\IST\QGIS\Popis_21\Resources\qgis_v2.bat")
            myProcess.WaitForExit()
            Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
            psi.FileName = "C:\Program Files\QGIS 3.4\bin\qgis-ltr-bin.exe"
            psi.Arguments = atbOps.sselectedValue.Trim + ".qgs"
            psi.WorkingDirectory = "C:\IST\QGIS\Popis_21\" + atbOps.sselectedValue.Trim + "\"
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
            Dim ppp As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
            ppp.WaitForExit()
            overlayHandle.Close()
            ISTMessageBox.Show("Rad sa mapom je završen, možete nastaviti sa radom u aplikaciji za unos.")

            Dim fileReader11 As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt")
            If fileReader11.Trim = "" Then
                Dim ok As String = izvrsiSQL(updateprepisane, Me.DBConnectionString)
                If ok <> "ok" Then
                    ISTMessageBox.Show("Greška 6! Zovite administratora!")
                    Me.Close()
                    Exit Sub
                End If
            End If

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Default

        gbKBR.Visible = False
        llNastavi.Visible = True
        tboxkbr.Enabled = False
        textboxUlica.Enabled = False
        atbULKBR.Enabled = False
        btnMapaIzmenaKBR.Enabled = False
        llNastavi.Enabled = True

    End Sub

    Private Sub llNastavi_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llNastavi.LinkClicked
        'Dim str As String = " select suser_name()"
        'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
        'Dim korisnik As String = dt.Rows(0).Item(0)
        'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")


        If postojiMapa() = False Then
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Me.Cursor = Cursors.Default
        Else
            Dim opstina As String = atbOps.sselectedValue.Trim
            If opstina.Trim <> "" Then
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt")
                Dim p() As String = fileReader.Replace(vbTab, " ").Replace(vbCr, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Trim.Split("$")
                If p.Length = 2 AndAlso Not p(0) Is Nothing AndAlso Not p(1) Is Nothing Then
                    tboxLongituda.Text = p(0).Trim
                    tboxLatituda.Text = p(1).Trim
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
                Else
                    tboxLongituda.Text = ""
                    tboxLatituda.Text = ""
                End If
            End If
        End If

        llNastavi.Enabled = False
        btnMapaKbr.Enabled = False
        ButtonSave.Enabled = True
        gbKBR.Visible = True
        tboxNapomenaOKucnomBroju.Focus()
    End Sub

    Private Sub llNastaviUL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llNastaviUL.LinkClicked
        'Dim str As String = " select suser_name()"
        'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
        'Dim korisnik As String = dt.Rows(0).Item(0)
        'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")


        If postojiMapa() = False Then
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Me.Cursor = Cursors.Default
        Else
            Dim opstina As String = atbOps.sselectedValue.Trim
            If opstina.Trim <> "" Then
                Dim fileReader As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt")
                Dim p() As String = fileReader.Replace(vbTab, " ").Replace(vbCr, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Trim.Split("$")
                If p.Length = 2 AndAlso Not p(0) Is Nothing AndAlso Not p(1) Is Nothing Then
                    TextBoxLong.Text = p(0).Trim
                    TextBoxLat.Text = p(1).Trim
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
                Else
                    TextBoxLong.Text = ""
                    TextBoxLat.Text = ""
                End If
            End If
        End If
        llNastaviUL.Enabled = False
        btnMapaKbrUL.Enabled = False
        ButtonDodajAdr.Enabled = True
        gbKBRUL.Visible = True
        ButtonDodajAdr.Focus()
    End Sub

    Private Sub btnMapaKbrUL_Click(sender As Object, e As EventArgs) Handles btnMapaKbrUL.Click
        Dim novinazivul As String = ""
        llNastavi.Visible = True
        llNastavi.Enabled = True
        gbKBR.Visible = False

        Dim strProvera As String = dodatak + "select * from Adresar a " + vbCrLf +
                " where IDANKETAR=N'" + kosam + "' and a.mbops='" + atbOps.sselectedValue + "' and a.krug_idcd='" + atbPK.sselectedValue + "' and ltrim(rtrim(trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(a.ulica)='' then NULL else a.ulica end),1), 1, CONVERT(varbinary, @Hash)))))))=N'" + tboxNovaUlica.Text.Trim + "' "
        Dim dtProvera As DataTable = izvrsiSQLvratiDT(strProvera, Me.DBConnectionString, Nothing)
        If dtProvera.Rows.Count > 0 Then
            ISTMessageBox.Show("Ne možete uneti već postojeću ulicu!")
            tboxNovaUlica.Focus()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        ElseIf tboxNovaUlica.Text.Trim = "" Then
            ISTMessageBox.Show("Obavezan naziv ulice")
            tboxNovaUlica.Focus()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        ElseIf Me.tboxKucniBR.Text.Trim = "" Then
            ISTMessageBox.Show("Obavezan kućni broj")
            tboxKucniBR.Focus()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        ElseIf Me.tboxKucniBR.Text.IndexOf(".") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf(",") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf(":") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf("'") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf(")") >= 0 OrElse Me.tboxKucniBR.Text.IndexOf("(") >= 0 Then
            ISTMessageBox.Show("Nedozvoljena vrednost pri unosu kućnog broja : , . ' ) (")
            tboxKucniBR.Focus()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        If proveraKbr(Me.tboxKucniBR.Text.Trim) = False Then
            ISTMessageBox.Show("Kućni broj nije ispravan!")
            tboxKucniBR.Focus()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If

        Try
            Dim kbr As String = "KBR"
            'Dim str As String = " select suser_name()"
            'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
            Dim opstina As String = atbOps.sselectedValue.Trim

            If opstina.Trim <> "" Then
                'Dim korisnik As String = dt.Rows(0).Item(0)
                'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\Resources\SifOps.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\Resources\SifOps.txt", CStr(CInt(opstina.Trim)).Trim, False, System.Text.Encoding.ASCII)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina.Trim + "\pk.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina.Trim + "\pk.txt", atbPK.sselectedText.Trim.Substring(0, 4), False)
            End If
            ''''''TACKANJE PREMA ULICIIII
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorUlica.txt", "", False)
            If opstina.Trim <> "" Then
                'Dim korisnik As String = dt.Rows(0).Item(0)
                'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\formaMape.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\formaMape.txt", kbr.Trim, False)


                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\ulica.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\ulica.txt", "'" + tboxNovaUlica.Text.Trim + "'", False)

                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\kbr.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\kbr.txt", "'" + tboxKucniBR.Text.Trim + "'", False)

                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\krug.txt", "", False)
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\krug.txt", "'" + atbPK.sselectedText.Trim.Substring(0, 4) + "'", False)

                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjaulica.txt", "", False)
                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjaulica.txt", ulica.Trim, False)

                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjikbr.txt", "", False)
                'My.Computer.FileSystem.WriteAllText("C:\Users\" + korisnik + "\Desktop\Za QGIS\80268\QGIS\poslednjikbr.txt", tboxkbr.Text.Trim, False)
                ''''''TACKANJE PREMA ULICIIII
                My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\IndikatorUlica.txt", "(*);", False)

            End If
            ' Dim a As Boolean = CheckIfRunning()

            ''Dim info As New ProcessStartInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Desktop\Za QGIS\" + atbOps.sselectedValue.Trim + "\qgis_v2.bat")
            'Dim info As New ProcessStartInfo("C:\IST\QGIS\Popis_21\Resources\qgis_v2.bat")
            '' Dim p As String = "dial_string=" + phoneNumber
            ''info.Verb = "runas"
            'info.WindowStyle = ProcessWindowStyle.Maximized
            'info.UseShellExecute = True
            '' info.Arguments = p

            'Dim p As Process()
            'p = Process.GetProcessesByName("qgis-ltr-bin")
            'If p.Length > 0 Then
            '    For Each pp As Process In Process.GetProcesses
            '        If pp.ProcessName = "qgis-ltr-bin" Then
            '            pp.Kill()
            '        End If
            '    Next
            'End If

            'Process.Start(info)
            'Dim podigao As Integer = -1
            'p = Process.GetProcessesByName("qgis-ltr-bin")
            'Dim izadji As Boolean = False
            'For i As Integer = 1 To 10000000
            '    For Each pp As Process In Process.GetProcesses
            '        If i > 5500 Then
            '            If pp.ProcessName = "qgis-ltr-bin" Then
            '                podigao = 1
            '            Else
            '                podigao = 0
            '                Exit For
            '            End If
            '        End If
            '    Next
            '    If podigao = 0 Then
            '        overlayHandle.Close()
            '        Me.Cursor = System.Windows.Forms.Cursors.Default
            '        Exit For
            '    End If
            'Next

            ''process.WaitForExit()
            ''ISTMessageBox.Show("bb")

            Dim prepisinove As String = dodatak + "select distinct left(krug_idcd,4), longituda, latituda, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as Ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kBroj)='' then NULL else kBroj end),1), 1, CONVERT(varbinary, @Hash))))) kbroj, PKuSK, SK from adresar where sourceof_INSERT='ANK' and isnull(naslediood,'')<>'' and IDAnketar=N'" + kosam + "' and isnull(KBROdDrugogDodatNaMapu,0)<>1"
            Dim updateprepisane As String = "update adresar set KBROdDrugogDodatNaMapu=1  where sourceof_INSERT='ANK' and isnull(naslediood,'')<>'' and IDAnketar=N'" + kosam + "' and isnull(KBROdDrugogDodatNaMapu,0)<>1"
            Dim dtprebaci As DataTable = izvrsiSQLvratiDT(prepisinove, Me.DBConnectionString, Me.jezik)
            Dim strzatxt As String = ""
            If dtprebaci.Rows.Count > 0 Then
                For i As Integer = 0 To dtprebaci.Rows.Count - 1
                    strzatxt = strzatxt + dtprebaci.Rows(i).Item(0).ToString.Trim + "$" + dtprebaci.Rows(i).Item(1).ToString.Replace(",", ".").Trim + "$" + dtprebaci.Rows(i).Item(2).ToString.Replace(",", ".").Trim + "$" + dtprebaci.Rows(i).Item(3).ToString.Trim + "$" + dtprebaci.Rows(i).Item(4).ToString.Trim + "$" + dtprebaci.Rows(i).Item(5).ToString.Trim + "$" + dtprebaci.Rows(i).Item(6).ToString.Trim + ";"
                Next
            End If
            'Dim opstina As String = atbOps.sselectedValue.Trim
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt", "", False)
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt", strzatxt, False)

            Dim sreditacke As String = dodatak + "select distinct left(krug_idcd,4), longituda, latituda, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(ulica)='' then NULL else ulica end),1), 1, CONVERT(varbinary, @Hash))))) as  Ulica, trim(CONVERT(nvarchar(1000), (DecryptByPassPhrase(@Lozinka, convert(varbinary(256),(case when trim(kBroj)='' then NULL else kBroj end),1), 1, CONVERT(varbinary, @Hash))))) as kbroj from adresar where sourceof_INSERT='ANK' and IDAnketar=N'" + kosam + "'"
            Dim dtsreditacke As DataTable = izvrsiSQLvratiDT(sreditacke, Me.DBConnectionString, Me.jezik)
            Dim sreditacketxt As String = ""
            If dtsreditacke.Rows.Count > 0 Then
                For i As Integer = 0 To dtsreditacke.Rows.Count - 1
                    sreditacketxt = sreditacketxt + dtsreditacke.Rows(i).Item(0).ToString.Trim + "$" + dtsreditacke.Rows(i).Item(1).ToString.Replace(",", ".").Trim + "$" + dtsreditacke.Rows(i).Item(2).ToString.Replace(",", ".").Trim + "$" + dtsreditacke.Rows(i).Item(3).ToString.Trim + "$" + dtsreditacke.Rows(i).Item(4).ToString.Trim + ";"
                Next
            End If
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\SrediTacke.txt", "", False)
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\SrediTacke.txt", sreditacketxt, False)
            Call kucnibrojeviMapaBojenje()
            Dim overlayHandle As ISTFormIsLoading
            overlayHandle = New ISTFormIsLoading(Me, Me.ButtonIzlaz.Parent)
            overlayHandle.Show()

            Dim p As Process()
            p = Process.GetProcessesByName("qgis-ltr-bin")
            If p.Length > 0 Then
                For Each pp As Process In Process.GetProcesses
                    If pp.ProcessName = "qgis-ltr-bin" Then
                        pp.Kill()
                    End If
                Next
            End If

            'Button.Enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim myProcess As Process = Process.Start("C:\IST\QGIS\Popis_21\Resources\qgis_v2.bat")
            myProcess.WaitForExit()
            Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
            psi.FileName = "C:\Program Files\QGIS 3.4\bin\qgis-ltr-bin.exe"
            psi.Arguments = atbOps.sselectedValue.Trim + ".qgs"
            psi.WorkingDirectory = "C:\IST\QGIS\Popis_21\" + atbOps.sselectedValue.Trim + "\"
            psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
            Dim ppp As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
            ppp.WaitForExit()
            overlayHandle.Close()
            ISTMessageBox.Show("Rad sa mapom je završen, možete nastaviti sa radom u aplikaciji za unos.")

            Dim fileReader11 As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\PrepisiTacke.txt")
            If fileReader11.Trim = "" Then
                Dim ok As String = izvrsiSQL(updateprepisane, Me.DBConnectionString)
                If ok <> "ok" Then
                    ISTMessageBox.Show("Greška 7! Zovite administratora!")
                    Me.Close()
                    Exit Sub
                End If
            End If


            Me.Cursor = Cursors.Default

        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
        tboxKucniBR.Enabled = False
        tboxNovaUlica.Enabled = False
        btnMapaKbrUL.Enabled = False
        llNastaviUL.Enabled = True
        llNastaviUL.Focus()


    End Sub

    Function proveraKbr(ByVal kbr As String)
        'Dim pom As Boolean = False
        Dim pom2 As Boolean = False
        Dim pom3 As Boolean = False
        For i As Integer = Len(kbr) To 1 Step -1
            If Mid(kbr.Trim.ToUpper, i, 1) = "N" Then
                'pom = True
                If i + 1 <= Len(kbr) Then 'pom2 = True AndAlso
                    For j As Integer = i + 1 To Len(kbr)
                        If Not (IsNumeric(Mid(kbr.Trim.ToUpper, j, 1))) Then
                            pom2 = True
                            Exit For
                        End If
                    Next
                End If
                Exit For
            End If
        Next
        If kbr.Trim.ToUpper.IndexOf("N") < 0 Then
            pom2 = True
        End If
        'If pom = True AndAlso (i - 1) > 0 Then
        'If IsNumeric(Mid(kbr.Trim.ToUpper, i - 1, 1)) Then
        '    pom2 = True
        '    'Exit For
        'ElseIf Len(kbr) >= 2 AndAlso Mid(kbr.Trim.ToUpper, i - 1, 2) = "BB" Then
        '    pom2 = True
        '    'Exit For
        'End If
        'If i + 1 <= Len(kbr) Then 'pom2 = True AndAlso
        '        For j As Integer = i + 1 To Len(kbr)
        '            If Not (IsNumeric(Mid(kbr.Trim.ToUpper, j, 1))) Then
        '                pom2 = False
        '                Exit For
        '            End If
        '        Next
        '        Exit For
        '    End If
        '    If pom2 = True Then
        '        Exit For
        '    End If
        'End If

        If pom2 = True Then
            pom3 = False
        Else
            pom3 = True
        End If
        Return pom3
    End Function

    Private Sub FormPopisAdresar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Panel3.Visible = True Then
            Call Cancel()
        End If
        If PanelNUl.Visible = True Then
            Call CancelNUL()
        End If
    End Sub

    Private Sub CancelNUL()

        Call nesamoja(PanelNUl)
        PanelNUl.Visible = False

        atbOps.Enabled = True
        atbPK.Enabled = True
        atbUlica.Enabled = True
        ButtonNastavi.Enabled = True
        atbUlica.Focus()
        atbUlica.SelectionStart = 0
        atbUlica.SelectionLength = atbUlica.Text.Length

        'Dim str As String = " select suser_name()"
        'Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)
        'Dim korisnik As String = dt.Rows(0).Item(0)
        'korisnik = korisnik.Trim.ToUpper.Replace("STATSRB\", "")


        If postojiMapa() = False Then
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Call enableIzborZaGrid()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If


        If postojiMapa() = False Then
            ISTMessageBox.Show("Nemate instaliranu mapu. Molimo vas pozovite instruktora kako biste mogli da nastavite sa radom!")
            Me.Cursor = Cursors.Default
        Else
            Dim opstina As String = atbOps.sselectedValue.Trim
            If btnMapaKbrUL.Tag = "unos" Then
                If opstina.Trim <> "" Then
                    Dim fileReader As String = ""
                    fileReader = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt")
                    fileReader = fileReader + atbPK.sselectedText.Trim.Substring(0, 4) + "$" + tboxNovaUlica.Text + "$" + tboxKucniBR.Text + ";"
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt", "", False)
                    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\brisanjeKBR.txt", "" + fileReader.Trim + "", False)
                End If
            End If
            My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\Popis_21\" + opstina + "\LongLat.txt", "", False)
        End If

        Call enableIzborZaGrid()

    End Sub

    Private Sub ButtonNeDodajAdr_Click(sender As Object, e As EventArgs) Handles ButtonNeDodajAdr.Click

        Me.Cursor = Cursors.WaitCursor

        Call CancelNUL()
        ' PanelNUl.Visible = False

        'Dim opstina As String = atbOps.sselectedValue.Trim

        'If opstina.Trim <> "" Then
        '    Dim fileReader As String = ""
        '    fileReader = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\" + opstina + "\brisanjeKBR.txt")
        '    fileReader = fileReader + atbPK.sselectedText.Trim + "$" + tboxNovaUlica.Text.Trim + "$" + tboxkbr.Text + ";"
        '    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\" + opstina + "\brisanjeKBR.txt", "", False)
        '    My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\" + opstina + "\brisanjeKBR.txt", "" + fileReader.Trim + "", False)


        '    Dim pomlong As String = ""
        '    Dim pomlat As String = ""

        '    Dim fileReader1 As String = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\" + opstina + "\LongLat.txt")
        '    Dim p() As String = fileReader1.Replace(vbTab, " ").Replace(vbCr, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Trim.Split(",")
        '    If p.Length = 2 AndAlso Not p(0) Is Nothing AndAlso Not p(1) Is Nothing Then
        '        pomlong = p(0).Trim
        '        pomlat = p(1).Trim
        '    End If

        '    If opstina.Trim <> "" Then
        '        Dim fileReader3 As String = ""
        '        fileReader3 = My.Computer.FileSystem.ReadAllText("C:\IST\QGIS\" + opstina + "\brisanjeKBRSaLongLat.txt")
        '        fileReader3 = fileReader3 + atbPK.sselectedText.Trim + "$" + textboxUlica.Text + "$" + tboxkbr.Text + "$" + pomlong.Trim + "$" + pomlat.Trim + ";"
        '        My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\" + opstina + "\brisanjeKBRSaLongLat.txt", "", False)
        '        My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\" + opstina + "\brisanjeKBRSaLongLat.txt", "" + fileReader3.Trim + "", False)
        '    End If

        'End If


        'My.Computer.FileSystem.WriteAllText("C:\IST\QGIS\" + opstina + "\LongLat.txt", "", False)

        'atbOps.Enabled = True
        'atbPK.Enabled = True
        'atbUlica.Enabled = True
        'ButtonNastavi.Enabled = True
        'atbUlica.Focus()
        'atbUlica.SelectionStart = 0
        'atbUlica.SelectionLength = atbUlica.Text.Length

        'Call enableIzborZaGrid()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub tboxNovaUlica_TextChanged(sender As Object, e As EventArgs) Handles tboxNovaUlica.TextChanged, txtNNUlice.TextChanged
        Dim tbox As TextBox = sender
        If tbox.Text.Trim <> "" AndAlso IsNumeric(tbox.Text.Trim) = False Then
            tbox.Text = FormTemplate.konverzijaCirLat(tbox.Text)
        End If
        tbox.SelectionStart = tbox.Text.Length
    End Sub

    'Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DGV1.DataError, DGV2.DataError, DGV3.DataError
    '    Try
    '        Dim dgv As DataGridView = sender
    '        If TypeOf (e.Exception) Is System.Data.ConstraintException Then
    '            dgv.Rows(e.RowIndex).ErrorText = "must be unique value"
    '            dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "must be unique value"
    '            ISTMessageBox.Show(e.Exception.Message, "Error ConstraintException", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            e.ThrowException = False
    '        End If

    '    Catch ex As Exception
    '        ISTMessageBox.Show(ex.Message, "ERROR: dataGridView1_DataError", MessageBoxButtons.OK, MessageBoxIcon.[Error])
    '    End Try

    'End Sub
    Private Sub dataGridView1_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DGV1.DataError, DGV2.DataError, DGV3.DataError
        Try
            Dim dgv As DataGridView = sender
            If TypeOf (e.Exception) Is System.Data.ConstraintException Then
                dgv.Rows(e.RowIndex).ErrorText = "Mora biti jedinstvena vrednost"
                dgv.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "Mora biti jedinstvena vrednost"
                ISTMessageBox.Show(e.Exception.Message, "Dogodila se greška, pozovite administratora", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.ThrowException = False
            End If

        Catch ex As Exception
            ISTMessageBox.Show(ex.Message, "Greška u gridu", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try

    End Sub

    Private Sub DGV2_SelectionChanged(sender As Object, e As EventArgs) Handles DGV2.SelectionChanged
        Dim aaa As String = "2"
    End Sub

    Private Sub btnVracanjeKrugova_Click(sender As Object, e As EventArgs) Handles btnVracanjeKrugova.Click



        txtVratiPK.Text = ""

        lblTrazeniNaDoradu.Visible = False
        lblTrazeniNaDoradu.Text = "Spisak krugova koje ste tražili na doradu i za koje čekate odgovor od instruktora:" + nvrd

        Call disableIzborZaGrid()

        Dim str As String = "select aa.mbops,nazivopstine,  " + nvrd +
                            "string_agg(displaymember,',') displaymember " + nvrd +
                            "from " + nvrd +
                            "(select distinct mbops, nazivopstine, " + nvrd +
                            "(case when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)=left(a.krug_idcd,4) And krug_idcd<>a.krug_idcd)  " + nvrd +
                            "then krug_idcd  " + nvrd +
                            "Else left(krug_idcd,4) End) As displaymember  " + nvrd +
                            "FROM [Popis2021].[dbo].[AdresarSviKrugovi] a " + nvrd +
                            "where IDANKETAR = N'" + kosam + "' and (isnull([IndZavrsenPop],0)=3 or isnull([IndPrazan],0)=3)) aa " + nvrd + '"inner Join(select distinct mbops, nazivopstine from adresar where IDANKETAR=N'" + kosam + "') b on aa.mbops=b.mbops " + nvrd +
                            "Group by aa.mbops, aa.nazivopstine "


        Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.DBConnectionString, Me.jezik)

        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                lblTrazeniNaDoradu.Text = lblTrazeniNaDoradu.Text + dt.Rows(i).Item(1).ToString + " - " + dt.Rows(i).Item(2).ToString + nvrd
            Next
            lblTrazeniNaDoradu.Visible = True
        End If

        Dim str2 As String = " select distinct [Krug_idcd]+'$'+a.mbops As valuemember, " + nvrd +
                             " (case when exists (select left(krug_idcd,4) from adresarsvikrugovi where left(krug_idcd,4)= Left(a.krug_idcd, 4) And krug_idcd <> a.krug_idcd) And  isnull(IndPrazan,0)+isnull(IndZavrsenPop,0)<>0 " + nvrd +
                             " then krug_idcd+'  ('+nazivopstine+')' " + nvrd +
                             " Else left(krug_idcd,4)+'      ('+nazivopstine+')' end) As displaymember, a.mbops  " + nvrd +
                             " From [Popis2021].[dbo].[AdresarSviKrugovi] a " + nvrd + 'inner Join(Select distinct mbops, nazivopstine from adresar where IDANKETAR= N'" + kosam + "') b on a.mbops=b.mbops  
                             " where IDANKETAR = N'" + kosam + "'  and (isnull([IndZavrsenPop],0)=1 or isnull([IndPrazan],0)=1) order by 3,1 "


        Dim dt2 As DataTable = izvrsiSQLvratiDT(str2, Me.DBConnectionString, Me.jezik)


        If dt2.Rows.Count > 0 Then
            Call popunicbo(cmbVratiPK, str2, DBConnectionString, True)

            PanelPKDorada.Visible = True
            Call samoja(PanelPKDorada)
        Else
            ISTMessageBox.Show("Nemate vraćenih popisnih krugova niti krugova koje možete da tražite na doradu. U pitanju je greška!")

            Call nesamoja(PanelPKDorada)
            PanelPKDorada.Visible = False

            If TabControl1.Visible = False Then
                Call enableIzborZaGrid()
                If atbOps.Text = "" AndAlso atbOps.Enabled = True Then
                    atbOps.Focus()
                ElseIf atbPK.Text = "" AndAlso atbPK.Enabled = True Then
                    atbPK.Focus()
                ElseIf atbUlica.Text = "" AndAlso atbUlica.Enabled = True Then
                    atbUlica.Focus()
                End If
            End If
            Exit Sub
        End If
    End Sub

    Private Sub btnOKPKDorada_Click(sender As Object, e As EventArgs) Handles btnOKPKDorada.Click

        If cmbVratiPK.SelectedValue = "" Then
            ISTMessageBox.Show("Morate izabrati popisni krug sa spiska.")
            cmbVratiPK.Focus()
            Exit Sub
        ElseIf txtVratiPK.Text.Trim = "" Then
            ISTMessageBox.Show("Morate upisati razlog.")
            txtVratiPK.Focus()
            Exit Sub
        ElseIf txtVratiPK.Text.Trim.Length < 15 Then
            ISTMessageBox.Show("Morate upisati detaljnije objašnjenje u polje Razlog.")
            txtVratiPK.Focus()
            Exit Sub
        End If

        Call nesamoja(PanelPKDorada)
        PanelPKDorada.Visible = False

        Dim krugiops() As String = cmbVratiPK.SelectedValue.split("$")
        Dim krugidcd As String = ""
        Dim mbopstine As String = ""

        If krugiops.Length = 2 Then
            krugidcd = krugiops(0).Trim
            mbopstine = krugiops(1).Trim
        Else
            ISTMessageBox.Show("Greška pokušajte ponovo ili pozovite instruktora.")
            Exit Sub
        End If

        Dim st As String = " begin transaction" + nvrd +
                           " update adresarsvikrugovi" + nvrd +
                           " set indprazan=3, USER_UPDATE_IndZavrsenPop=N'" + kosam + "', DATE_UPDATE__IndZavrsenPop=getdate(), NapomenaVracenPop=N'" + txtVratiPK.Text + "' " + nvrd +
                           " where isnull(indprazan,0)=1 and mbops='" + mbopstine + "' and krug_idcd='" + krugidcd + "' and idanketar='" + kosam + "' " + nvrd +
                           " update adresarsvikrugovi" + nvrd +
                           " set IndZavrsenPop=3, USER_UPDATE_IndZavrsenPop=N'" + kosam + "', DATE_UPDATE__IndZavrsenPop=getdate(), NapomenaVracenPop=N'" + txtVratiPK.Text + "' " + nvrd +
                           " where isnull(IndZavrsenPop,0)=1 and mbops='" + mbopstine + "' and krug_idcd='" + krugidcd + "' and idanketar='" + kosam + "' " + nvrd +
                           " commit transaction;"
        Dim ok2 As String = izvrsiSQL(st, Me.DBConnectionString)
        If ok2 = "ok" Then
        Else
            ISTMessageBox.Show("Greška 8! Zovite administratora!")
            Me.Close()
            Exit Sub
        End If

        If TabControl1.Visible = False Then
            Call enableIzborZaGrid()
            If atbOps.Text = "" AndAlso atbOps.Enabled = True Then
                atbOps.Focus()
            ElseIf atbPK.Text = "" AndAlso atbPK.Enabled = True Then
                atbPK.Focus()
            ElseIf atbUlica.Text = "" AndAlso atbUlica.Enabled = True Then
                atbUlica.Focus()
            End If
        End If

        Dim strBTNZaKrug = "select * from AdresarSviKrugovi where idanketar=N'" + kosam + "' and " + nvrd +
                    " (isnull(IndZavrsenPop,0)=1 or isnull(IndPrazan,0)=1)"
        Dim dtBTNZaKrug As DataTable = izvrsiSQLvratiDT(strBTNZaKrug, Me.DBConnectionString, Me.jezik)
        If dtBTNZaKrug.Rows.Count > 0 Then
            btnVracanjeKrugova.Visible = True
        Else
            btnVracanjeKrugova.Visible = False
        End If

    End Sub


    Private Sub btnCancelPKDorada_Click(sender As Object, e As EventArgs) Handles btnCancelPKDorada.Click

        Call nesamoja(PanelPKDorada)
        PanelPKDorada.Visible = False

        If TabControl1.Visible = False Then
            Call enableIzborZaGrid()
            If atbOps.Text = "" AndAlso atbOps.Enabled = True Then
                atbOps.Focus()
            ElseIf atbPK.Text = "" AndAlso atbPK.Enabled = True Then
                atbPK.Focus()
            ElseIf atbUlica.Text = "" AndAlso atbUlica.Enabled = True Then
                atbUlica.Focus()
            End If
        End If

        Dim strBTNZaKrug = "select * from AdresarSviKrugovi where idanketar=N'" + kosam + "' and " + nvrd +
                    " (isnull(IndZavrsenPop,0)=1 or isnull(IndPrazan,0)=1)"
        Dim dtBTNZaKrug As DataTable = izvrsiSQLvratiDT(strBTNZaKrug, Me.DBConnectionString, Me.jezik)
        If dtBTNZaKrug.Rows.Count > 0 Then
            btnVracanjeKrugova.Visible = True
        Else
            btnVracanjeKrugova.Visible = False
        End If
    End Sub

    Private Sub btnInformation_MouseHover(sender As Object, e As EventArgs) Handles btnInformation.MouseHover
        Me.labelsToolTip.Active = True
        Me.labelsToolTip.Show(text1, btnInformation, btnInformation.PointToClient(Cursor.Position), 60000)
    End Sub

    Private Sub btnInformation_MouseLeave(sender As Object, e As EventArgs) Handles btnInformation.MouseLeave
        Me.labelsToolTip.Active = False
    End Sub


End Class

Public Module CueBannerText
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function
    Private Declare Function FindWindowEx Lib "user32" Alias "FindWindowExA" (ByVal hWnd1 As IntPtr, ByVal hWnd2 As IntPtr, ByVal lpsz1 As String, ByVal lpsz2 As String) As IntPtr
    Private Const EM_SETCUEBANNER As Integer = &H1501


    Public Sub SetCueText(cntrl As Control, text As String)
        If TypeOf cntrl Is ComboBox Then
            Dim Edit_hWnd As IntPtr = FindWindowEx(cntrl.Handle, IntPtr.Zero, "Edit", Nothing)
            If Not Edit_hWnd = IntPtr.Zero Then
                SendMessage(Edit_hWnd, EM_SETCUEBANNER, 0, text)
            End If
        ElseIf TypeOf cntrl Is TextBox Then
            SendMessage(cntrl.Handle, EM_SETCUEBANNER, 0, text)
        End If
    End Sub
End Module
Class CCombobox : Inherits ComboBox
    Sub New()
        Me.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
    End Sub

    Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
        MyBase.OnDrawItem(e)
        Dim item As CComboboxItem = DirectCast(Me.Items(e.Index), CComboboxItem)
        Using ForeBrush As Brush = New SolidBrush(item.Forecolor)
            Using BackBrush As Brush = New SolidBrush(item.Backcolor)
                e.Graphics.FillRectangle(BackBrush, e.Bounds)
                e.Graphics.TranslateTransform(0, e.Bounds.Y)
                e.Graphics.DrawString(item.ToString, Me.Font, ForeBrush, 0, 0)
            End Using
        End Using
    End Sub
End Class
Class CComboboxItem

    Public Sub New(Value As Object, Color As Color, BackColor As Color)
        Me.Value = Value
        Me.Forecolor = Color
        Me.Backcolor = BackColor
    End Sub

    Public Property Value As Object = Nothing
    Public Property Forecolor As Color = Color.Black
    Public Property Backcolor As Color = Color.Black

    Public Overrides Function ToString() As String
        Return Value.ToString
    End Function

End Class

