Option Strict Off

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.IO
Imports System.Reflection
Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic
Imports Word = Microsoft.Office.Interop.Word
Imports System.Drawing.Text
Imports System.Drawing
Imports Microsoft.Win32
Imports System.Security.AccessControl
Imports System.Runtime.InteropServices
Imports System.Linq
Imports System.Drawing.Drawing2D
Imports System.Resources
Imports System.Data

Friend Class FormIstrazivanje
    Inherits FormTemplate

#Region " Windows Form Designer generated code "



    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        'SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        'Me.BackColor = System.Drawing.Color.Transparent
    End Sub

    'Form overrides dispose to clean up the component list.
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
    Friend WithEvents Logovan As Label
    Friend WithEvents lblPVT As Label
    Friend WithEvents LogovanAnketarCloud As Label
    Friend WithEvents UserControlVremenskaTacka1 As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents panelSinhronizacija As PanelBorderGainsboro
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBrojVracenihStanova As Label
    Friend WithEvents lblBrojQC As Label
    Friend WithEvents lblPorukaSinhronizacija As Label
    Friend WithEvents lblSinhrUspesno As Label
    Friend WithEvents lblSinhrNeuspesno As Label
    Friend WithEvents lblBrojVracenihStanovaBroj As Label
    Friend WithEvents lblBrojQCBroj As Label
    Friend WithEvents lblBrojPoslatihBroj As Label
    Friend WithEvents lblBrojPoslatih As Label
    Friend WithEvents lblKrugoviDorada As Label
    Friend WithEvents PanelTop As Panel
    Friend WithEvents lblNaziv As Label
    Friend WithEvents lblSifra As Label

    Friend WithEvents btnSinhronizacija As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button

    Friend WithEvents PanelContext As Panel
    Friend WithEvents ButtonPromenaIstrazivanja As Button
    Friend WithEvents MRefresh As Button
    Friend WithEvents MILastVersionDate As Label
    Friend WithEvents ctMenuStrip As ContextMenuStrip
    Friend WithEvents MIAplikacija As ToolStripMenuItem
    Friend WithEvents MIAdministracija As ToolStripMenuItem
    Friend WithEvents MIUputstva As ToolStripMenuItem
    Friend WithEvents MILanguage As ToolStripMenuItem
    Friend WithEvents mMode As ToolStripMenuItem
    Friend WithEvents btnMenu2 As Button
    Friend WithEvents MIZO As ToolStripMenuItem
    Friend WithEvents MIZakljucaj As ToolStripMenuItem
    Friend WithEvents MIZakljucajWeb As ToolStripMenuItem
    Friend WithEvents MIOtkljucaj As ToolStripMenuItem
    Friend WithEvents MIOtkljucajWeb As ToolStripMenuItem
    Friend WithEvents MIist2xml As ToolStripMenuItem
    Friend WithEvents MIIstUAspax As ToolStripMenuItem
    Friend WithEvents MIPodaciXml As ToolStripMenuItem
    Friend WithEvents MIXmlPodaci As ToolStripMenuItem
    Friend WithEvents MenuCAPI As ToolStripMenuItem
    Friend WithEvents MenuImportExcel As ToolStripMenuItem
    Friend WithEvents MIProjektanti As ToolStripMenuItem
    Friend WithEvents MIMreza As ToolStripMenuItem
    Friend WithEvents ISTMetaOld As ToolStripMenuItem
    Friend WithEvents mKorisnickoUputstvo As ToolStripMenuItem
    Friend WithEvents mVodic As ToolStripMenuItem
    Friend WithEvents MICatiGuide As ToolStripMenuItem
    Friend WithEvents mTehDok As ToolStripMenuItem
    Friend WithEvents mAlbanian As ToolStripMenuItem
    Friend WithEvents mBulgarian As ToolStripMenuItem
    Friend WithEvents mGerL As ToolStripMenuItem
    Friend WithEvents mDesktop As ToolStripMenuItem
    Friend WithEvents mCAPI As ToolStripMenuItem
    Friend WithEvents ButtonUnos As Button
    Friend WithEvents ButtonLogickaKontrola As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnCAPI As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents BtnAzurK As Button
    Friend WithEvents btnUnosA As Button
    Friend WithEvents BtnAdvancedSearch As Button
    Friend WithEvents ButtonIzvestaji As Button
    Friend WithEvents ButtonAzuriranje As Button
    Friend WithEvents ButtonAK As Button
    Friend WithEvents PanelCAPI As Panel
    Friend WithEvents PanelCATI As Panel
    Friend WithEvents btnCATI As Button
    Friend WithEvents PanelKonsultacione As Panel
    Friend WithEvents mEnglish As ToolStripMenuItem
    Friend WithEvents mItalian As ToolStripMenuItem
    Friend WithEvents mKirgyz As ToolStripMenuItem
    Friend WithEvents mMakC As ToolStripMenuItem
    Friend WithEvents mRussian As ToolStripMenuItem
    Friend WithEvents mSrpskiL As ToolStripMenuItem
    Friend WithEvents mSrpskiC As ToolStripMenuItem
    Friend WithEvents mVIET As ToolStripMenuItem
    Friend WithEvents mTurL As ToolStripMenuItem
    Friend WithEvents mUzbek As ToolStripMenuItem
    Friend WithEvents mMneL As ToolStripMenuItem
    Friend WithEvents mNasL As ToolStripMenuItem
    Friend WithEvents bSemiAutomaticCoding As LinkLabel
    Friend WithEvents bAdvancedTableUpdate As LinkLabel
    Friend WithEvents MainMenu11 As MainMenu
    Friend WithEvents MenuItem1 As MenuItem
    Friend WithEvents MenuItemStartRecentList As MenuItem
    Friend WithEvents btnChoose As Button
    Friend WithEvents MiXMLuIST As ToolStripMenuItem
    Friend WithEvents btnProba As Button
    Friend WithEvents txtIST As TextBox
    Friend WithEvents panelIST As TableLayoutPanel
    Friend WithEvents panelLast5 As Panel
    Friend WithEvents PanelVT As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnLinija2 As Button
    Friend WithEvents btnLinija1 As Button
    Friend WithEvents panelFooter As Panel
    Friend WithEvents btnFT5 As Button
    Friend WithEvents btnFT4 As Button
    Friend WithEvents btnFT3 As Button
    Friend WithEvents btnFT2 As Button
    Friend WithEvents btnFT1 As Button
    Friend WithEvents btnFTKraj As Button
    Friend WithEvents btnFTPocetni As Button
    Friend WithEvents panelOstalo As myPanel
    Friend WithEvents panelFooterPrazno As myPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents buttonTheme As Button
    Friend WithEvents PanelBoje As myPanel
    Friend WithEvents btnDark As Button
    Friend WithEvents btnA5 As Button
    Friend WithEvents btnA4 As Button
    Friend WithEvents btnA3 As Button
    Friend WithEvents btnA6 As Button
    Friend WithEvents btnA2 As Button
    Friend WithEvents btnA1 As Button
    Friend WithEvents btnA7 As Button
    Friend WithEvents btnLight As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnLinijaRazmak As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnArrowDownHover As Button
    Friend WithEvents btnFTRazmak5 As Button
    Friend WithEvents btnFTRazmak4 As Button
    Friend WithEvents btnFTRazmak3 As Button
    Friend WithEvents btnFTRazmak2 As Button
    Friend WithEvents btnFTRazmak1 As Button
    Friend WithEvents dgvIST As DataGridView

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIstrazivanje))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.lblPVT = New System.Windows.Forms.Label()
        Me.LogovanAnketarCloud = New System.Windows.Forms.Label()
        Me.panelSinhronizacija = New PanelBorderGainsboro()
        Me.lblKrugoviDorada = New System.Windows.Forms.Label()
        Me.lblBrojPoslatihBroj = New System.Windows.Forms.Label()
        Me.lblBrojPoslatih = New System.Windows.Forms.Label()
        Me.lblBrojQCBroj = New System.Windows.Forms.Label()
        Me.lblBrojVracenihStanovaBroj = New System.Windows.Forms.Label()
        Me.lblSinhrNeuspesno = New System.Windows.Forms.Label()
        Me.lblBrojVracenihStanova = New System.Windows.Forms.Label()
        Me.lblBrojQC = New System.Windows.Forms.Label()
        Me.lblPorukaSinhronizacija = New System.Windows.Forms.Label()
        Me.btnSinhronizacija = New System.Windows.Forms.Button()
        Me.lblSinhrUspesno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnArrowDownHover = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnMenu2 = New System.Windows.Forms.Button()
        Me.MRefresh = New System.Windows.Forms.Button()
        Me.ButtonPromenaIstrazivanja = New System.Windows.Forms.Button()
        Me.lblNaziv = New System.Windows.Forms.Label()
        Me.lblSifra = New System.Windows.Forms.Label()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.btnFTRazmak5 = New System.Windows.Forms.Button()
        Me.btnFT5 = New System.Windows.Forms.Button()
        Me.btnFTRazmak4 = New System.Windows.Forms.Button()
        Me.btnFT4 = New System.Windows.Forms.Button()
        Me.btnFTRazmak3 = New System.Windows.Forms.Button()
        Me.btnFT3 = New System.Windows.Forms.Button()
        Me.btnFTRazmak2 = New System.Windows.Forms.Button()
        Me.btnFT2 = New System.Windows.Forms.Button()
        Me.btnFTRazmak1 = New System.Windows.Forms.Button()
        Me.btnFT1 = New System.Windows.Forms.Button()
        Me.btnFTKraj = New System.Windows.Forms.Button()
        Me.btnFTPocetni = New System.Windows.Forms.Button()
        Me.panelOstalo = New myPanel()
        Me.bSemiAutomaticCoding = New System.Windows.Forms.LinkLabel()
        Me.bAdvancedTableUpdate = New System.Windows.Forms.LinkLabel()
        Me.panelIST = New System.Windows.Forms.TableLayoutPanel()
        Me.txtIST = New System.Windows.Forms.TextBox()
        Me.dgvIST = New System.Windows.Forms.DataGridView()
        Me.panelLast5 = New System.Windows.Forms.Panel()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.PanelVT = New System.Windows.Forms.Panel()
        Me.UserControlVremenskaTacka1 = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.btnProba = New System.Windows.Forms.Button()
        Me.MILastVersionDate = New System.Windows.Forms.Label()
        Me.panelFooterPrazno = New myPanel()
        Me.btnLinijaRazmak = New System.Windows.Forms.Button()
        Me.PanelBoje = New myPanel()
        Me.btnA5 = New System.Windows.Forms.Button()
        Me.btnA4 = New System.Windows.Forms.Button()
        Me.btnA3 = New System.Windows.Forms.Button()
        Me.btnA6 = New System.Windows.Forms.Button()
        Me.btnA2 = New System.Windows.Forms.Button()
        Me.btnA1 = New System.Windows.Forms.Button()
        Me.btnA7 = New System.Windows.Forms.Button()
        Me.btnLight = New System.Windows.Forms.Button()
        Me.btnDark = New System.Windows.Forms.Button()
        Me.ctMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MIAplikacija = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIZO = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIZakljucaj = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIZakljucajWeb = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIOtkljucaj = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIOtkljucajWeb = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIAdministracija = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIist2xml = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIIstUAspax = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIPodaciXml = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIXmlPodaci = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiXMLuIST = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCAPI = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuImportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIProjektanti = New System.Windows.Forms.ToolStripMenuItem()
        Me.ISTMetaOld = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIMreza = New System.Windows.Forms.ToolStripMenuItem()
        Me.MIUputstva = New System.Windows.Forms.ToolStripMenuItem()
        Me.mKorisnickoUputstvo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mVodic = New System.Windows.Forms.ToolStripMenuItem()
        Me.MICatiGuide = New System.Windows.Forms.ToolStripMenuItem()
        Me.mTehDok = New System.Windows.Forms.ToolStripMenuItem()
        Me.MILanguage = New System.Windows.Forms.ToolStripMenuItem()
        Me.mAlbanian = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBulgarian = New System.Windows.Forms.ToolStripMenuItem()
        Me.mGerL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mEnglish = New System.Windows.Forms.ToolStripMenuItem()
        Me.mItalian = New System.Windows.Forms.ToolStripMenuItem()
        Me.mKirgyz = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMakC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mRussian = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSrpskiL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mSrpskiC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mVIET = New System.Windows.Forms.ToolStripMenuItem()
        Me.mTurL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mUzbek = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMneL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mNasL = New System.Windows.Forms.ToolStripMenuItem()
        Me.mMode = New System.Windows.Forms.ToolStripMenuItem()
        Me.mDesktop = New System.Windows.Forms.ToolStripMenuItem()
        Me.mCAPI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonUnos = New System.Windows.Forms.Button()
        Me.ButtonLogickaKontrola = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnCAPI = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.buttonTheme = New System.Windows.Forms.Button()
        Me.btnLinija2 = New System.Windows.Forms.Button()
        Me.btnLinija1 = New System.Windows.Forms.Button()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.BtnAdvancedSearch = New System.Windows.Forms.Button()
        Me.ButtonIzvestaji = New System.Windows.Forms.Button()
        Me.ButtonAzuriranje = New System.Windows.Forms.Button()
        Me.ButtonAK = New System.Windows.Forms.Button()
        Me.PanelCATI = New System.Windows.Forms.Panel()
        Me.btnCATI = New System.Windows.Forms.Button()
        Me.PanelKonsultacione = New System.Windows.Forms.Panel()
        Me.btnUnosA = New System.Windows.Forms.Button()
        Me.BtnAzurK = New System.Windows.Forms.Button()
        Me.PanelCAPI = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu11 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItemStartRecentList = New System.Windows.Forms.MenuItem()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSinhronizacija.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelContext.SuspendLayout()
        Me.panelFooter.SuspendLayout()
        Me.panelOstalo.SuspendLayout()
        Me.panelIST.SuspendLayout()
        CType(Me.dgvIST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelVT.SuspendLayout()
        Me.PanelBoje.SuspendLayout()
        Me.ctMenuStrip.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.PanelCATI.SuspendLayout()
        Me.PanelKonsultacione.SuspendLayout()
        Me.PanelCAPI.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnMinimizar.Location = New System.Drawing.Point(817, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(857, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = False
        Me.btnCerrar.Visible = False
        '
        'Logovan
        '
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(0, 711)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(255, 18)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPVT
        '
        Me.lblPVT.AutoEllipsis = True
        Me.lblPVT.BackColor = System.Drawing.Color.Transparent
        Me.lblPVT.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPVT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblPVT.Location = New System.Drawing.Point(553, 584)
        Me.lblPVT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPVT.Name = "lblPVT"
        Me.lblPVT.Size = New System.Drawing.Size(339, 72)
        Me.lblPVT.TabIndex = 106
        Me.lblPVT.Tag = "nediraj"
        Me.lblPVT.Text = "PrivrednaKomoraVT"
        Me.lblPVT.Visible = False
        '
        'LogovanAnketarCloud
        '
        Me.LogovanAnketarCloud.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogovanAnketarCloud.BackColor = System.Drawing.Color.Transparent
        Me.LogovanAnketarCloud.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogovanAnketarCloud.ForeColor = System.Drawing.Color.DarkOrange
        Me.LogovanAnketarCloud.Location = New System.Drawing.Point(238, 1)
        Me.LogovanAnketarCloud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogovanAnketarCloud.Name = "LogovanAnketarCloud"
        Me.LogovanAnketarCloud.Size = New System.Drawing.Size(222, 40)
        Me.LogovanAnketarCloud.TabIndex = 119
        Me.LogovanAnketarCloud.Tag = "always"
        Me.LogovanAnketarCloud.Text = "aleksandar.karadjordjevicCloud"
        Me.LogovanAnketarCloud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelSinhronizacija
        '
        Me.panelSinhronizacija.Controls.Add(Me.lblKrugoviDorada)
        Me.panelSinhronizacija.Controls.Add(Me.lblBrojPoslatihBroj)
        Me.panelSinhronizacija.Controls.Add(Me.lblBrojPoslatih)
        Me.panelSinhronizacija.Controls.Add(Me.lblBrojQCBroj)
        Me.panelSinhronizacija.Controls.Add(Me.lblBrojVracenihStanovaBroj)
        Me.panelSinhronizacija.Controls.Add(Me.lblSinhrNeuspesno)
        Me.panelSinhronizacija.Controls.Add(Me.lblBrojVracenihStanova)
        Me.panelSinhronizacija.Controls.Add(Me.lblBrojQC)
        Me.panelSinhronizacija.Controls.Add(Me.lblPorukaSinhronizacija)
        Me.panelSinhronizacija.Controls.Add(Me.btnSinhronizacija)
        Me.panelSinhronizacija.Controls.Add(Me.lblSinhrUspesno)
        Me.panelSinhronizacija.Location = New System.Drawing.Point(33, 463)
        Me.panelSinhronizacija.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelSinhronizacija.Name = "panelSinhronizacija"
        Me.panelSinhronizacija.Size = New System.Drawing.Size(512, 248)
        Me.panelSinhronizacija.TabIndex = 139
        Me.panelSinhronizacija.Visible = False
        '
        'lblKrugoviDorada
        '
        Me.lblKrugoviDorada.AutoSize = True
        Me.lblKrugoviDorada.BackColor = System.Drawing.Color.Transparent
        Me.lblKrugoviDorada.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblKrugoviDorada.ForeColor = System.Drawing.Color.Maroon
        Me.lblKrugoviDorada.Location = New System.Drawing.Point(20, 153)
        Me.lblKrugoviDorada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKrugoviDorada.Name = "lblKrugoviDorada"
        Me.lblKrugoviDorada.Size = New System.Drawing.Size(290, 14)
        Me.lblKrugoviDorada.TabIndex = 155
        Me.lblKrugoviDorada.Tag = ""
        Me.lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:"
        Me.lblKrugoviDorada.Visible = False
        '
        'lblBrojPoslatihBroj
        '
        Me.lblBrojPoslatihBroj.AutoSize = True
        Me.lblBrojPoslatihBroj.BackColor = System.Drawing.Color.Transparent
        Me.lblBrojPoslatihBroj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblBrojPoslatihBroj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblBrojPoslatihBroj.Location = New System.Drawing.Point(281, 82)
        Me.lblBrojPoslatihBroj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrojPoslatihBroj.Name = "lblBrojPoslatihBroj"
        Me.lblBrojPoslatihBroj.Size = New System.Drawing.Size(16, 14)
        Me.lblBrojPoslatihBroj.TabIndex = 154
        Me.lblBrojPoslatihBroj.Tag = ""
        Me.lblBrojPoslatihBroj.Text = "0"
        '
        'lblBrojPoslatih
        '
        Me.lblBrojPoslatih.AutoSize = True
        Me.lblBrojPoslatih.BackColor = System.Drawing.Color.Transparent
        Me.lblBrojPoslatih.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblBrojPoslatih.Location = New System.Drawing.Point(20, 82)
        Me.lblBrojPoslatih.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrojPoslatih.Name = "lblBrojPoslatih"
        Me.lblBrojPoslatih.Size = New System.Drawing.Size(170, 14)
        Me.lblBrojPoslatih.TabIndex = 153
        Me.lblBrojPoslatih.Tag = ""
        Me.lblBrojPoslatih.Text = "Do sada poslato stanova:"
        '
        'lblBrojQCBroj
        '
        Me.lblBrojQCBroj.AutoSize = True
        Me.lblBrojQCBroj.BackColor = System.Drawing.Color.Transparent
        Me.lblBrojQCBroj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblBrojQCBroj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblBrojQCBroj.Location = New System.Drawing.Point(281, 107)
        Me.lblBrojQCBroj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrojQCBroj.Name = "lblBrojQCBroj"
        Me.lblBrojQCBroj.Size = New System.Drawing.Size(16, 14)
        Me.lblBrojQCBroj.TabIndex = 152
        Me.lblBrojQCBroj.Tag = ""
        Me.lblBrojQCBroj.Text = "0"
        '
        'lblBrojVracenihStanovaBroj
        '
        Me.lblBrojVracenihStanovaBroj.AutoSize = True
        Me.lblBrojVracenihStanovaBroj.BackColor = System.Drawing.Color.Transparent
        Me.lblBrojVracenihStanovaBroj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblBrojVracenihStanovaBroj.ForeColor = System.Drawing.Color.Maroon
        Me.lblBrojVracenihStanovaBroj.Location = New System.Drawing.Point(281, 132)
        Me.lblBrojVracenihStanovaBroj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrojVracenihStanovaBroj.Name = "lblBrojVracenihStanovaBroj"
        Me.lblBrojVracenihStanovaBroj.Size = New System.Drawing.Size(16, 14)
        Me.lblBrojVracenihStanovaBroj.TabIndex = 151
        Me.lblBrojVracenihStanovaBroj.Tag = ""
        Me.lblBrojVracenihStanovaBroj.Text = "0"
        '
        'lblSinhrNeuspesno
        '
        Me.lblSinhrNeuspesno.AutoSize = True
        Me.lblSinhrNeuspesno.BackColor = System.Drawing.Color.Transparent
        Me.lblSinhrNeuspesno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSinhrNeuspesno.ForeColor = System.Drawing.Color.Maroon
        Me.lblSinhrNeuspesno.Location = New System.Drawing.Point(8, 32)
        Me.lblSinhrNeuspesno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSinhrNeuspesno.Name = "lblSinhrNeuspesno"
        Me.lblSinhrNeuspesno.Size = New System.Drawing.Size(354, 14)
        Me.lblSinhrNeuspesno.TabIndex = 150
        Me.lblSinhrNeuspesno.Tag = ""
        Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  25.06.2021 - neuspešna"
        '
        'lblBrojVracenihStanova
        '
        Me.lblBrojVracenihStanova.AutoSize = True
        Me.lblBrojVracenihStanova.BackColor = System.Drawing.Color.Transparent
        Me.lblBrojVracenihStanova.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblBrojVracenihStanova.ForeColor = System.Drawing.Color.Maroon
        Me.lblBrojVracenihStanova.Location = New System.Drawing.Point(8, 131)
        Me.lblBrojVracenihStanova.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrojVracenihStanova.Name = "lblBrojVracenihStanova"
        Me.lblBrojVracenihStanova.Size = New System.Drawing.Size(201, 14)
        Me.lblBrojVracenihStanova.TabIndex = 149
        Me.lblBrojVracenihStanova.Tag = ""
        Me.lblBrojVracenihStanova.Text = "*Vraćeno stanova na doradu:"
        '
        'lblBrojQC
        '
        Me.lblBrojQC.AutoSize = True
        Me.lblBrojQC.BackColor = System.Drawing.Color.Transparent
        Me.lblBrojQC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblBrojQC.Location = New System.Drawing.Point(20, 107)
        Me.lblBrojQC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBrojQC.Name = "lblBrojQC"
        Me.lblBrojQC.Size = New System.Drawing.Size(187, 14)
        Me.lblBrojQC.TabIndex = 148
        Me.lblBrojQC.Tag = ""
        Me.lblBrojQC.Text = "Spremnih stanova za slanje:"
        '
        'lblPorukaSinhronizacija
        '
        Me.lblPorukaSinhronizacija.AutoSize = True
        Me.lblPorukaSinhronizacija.BackColor = System.Drawing.Color.Transparent
        Me.lblPorukaSinhronizacija.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPorukaSinhronizacija.ForeColor = System.Drawing.Color.Maroon
        Me.lblPorukaSinhronizacija.Location = New System.Drawing.Point(8, 57)
        Me.lblPorukaSinhronizacija.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPorukaSinhronizacija.Name = "lblPorukaSinhronizacija"
        Me.lblPorukaSinhronizacija.Size = New System.Drawing.Size(234, 14)
        Me.lblPorukaSinhronizacija.TabIndex = 147
        Me.lblPorukaSinhronizacija.Tag = ""
        Me.lblPorukaSinhronizacija.Text = "Molim vas, sinhronizujte se odmah"
        '
        'btnSinhronizacija
        '
        Me.btnSinhronizacija.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSinhronizacija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSinhronizacija.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSinhronizacija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSinhronizacija.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSinhronizacija.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSinhronizacija.Location = New System.Drawing.Point(0, 0)
        Me.btnSinhronizacija.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnSinhronizacija.Name = "btnSinhronizacija"
        Me.btnSinhronizacija.Size = New System.Drawing.Size(512, 28)
        Me.btnSinhronizacija.TabIndex = 142
        Me.btnSinhronizacija.TabStop = False
        Me.btnSinhronizacija.Text = "Преглед синхронизација"
        Me.btnSinhronizacija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSinhronizacija.UseVisualStyleBackColor = False
        '
        'lblSinhrUspesno
        '
        Me.lblSinhrUspesno.AutoSize = True
        Me.lblSinhrUspesno.BackColor = System.Drawing.Color.Transparent
        Me.lblSinhrUspesno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSinhrUspesno.Location = New System.Drawing.Point(8, 30)
        Me.lblSinhrUspesno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSinhrUspesno.Name = "lblSinhrUspesno"
        Me.lblSinhrUspesno.Size = New System.Drawing.Size(311, 14)
        Me.lblSinhrUspesno.TabIndex = 143
        Me.lblSinhrUspesno.Tag = ""
        Me.lblSinhrUspesno.Text = "Poslednja sinhronizacija:  25.06.2021 - uspešna"
        Me.lblSinhrUspesno.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.btnArrowDownHover)
        Me.PanelTop.Controls.Add(Me.Button4)
        Me.PanelTop.Controls.Add(Me.LogovanAnketarCloud)
        Me.PanelTop.Controls.Add(Me.btnMenu2)
        Me.PanelTop.Controls.Add(Me.MRefresh)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(255, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(897, 40)
        Me.PanelTop.TabIndex = 140
        Me.PanelTop.Tag = "Theme"
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
        Me.btnArrowDownHover.Location = New System.Drawing.Point(857, 0)
        Me.btnArrowDownHover.Name = "btnArrowDownHover"
        Me.btnArrowDownHover.Size = New System.Drawing.Size(40, 40)
        Me.btnArrowDownHover.TabIndex = 10000077
        Me.btnArrowDownHover.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(0, 0)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(2, 40)
        Me.Button4.TabIndex = 10000076
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnMenu2
        '
        Me.btnMenu2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu2.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu2.FlatAppearance.BorderSize = 0
        Me.btnMenu2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMenu2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu2.ForeColor = System.Drawing.Color.DarkGray
        Me.btnMenu2.Image = CType(resources.GetObject("btnMenu2.Image"), System.Drawing.Image)
        Me.btnMenu2.Location = New System.Drawing.Point(737, 0)
        Me.btnMenu2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMenu2.Name = "btnMenu2"
        Me.btnMenu2.Size = New System.Drawing.Size(40, 40)
        Me.btnMenu2.TabIndex = 156
        Me.btnMenu2.TabStop = False
        Me.btnMenu2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.btnMenu2, "Settings")
        Me.btnMenu2.UseVisualStyleBackColor = False
        Me.btnMenu2.Visible = False
        '
        'MRefresh
        '
        Me.MRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MRefresh.BackColor = System.Drawing.Color.Transparent
        Me.MRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MRefresh.FlatAppearance.BorderSize = 0
        Me.MRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MRefresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MRefresh.ForeColor = System.Drawing.Color.White
        Me.MRefresh.Image = CType(resources.GetObject("MRefresh.Image"), System.Drawing.Image)
        Me.MRefresh.Location = New System.Drawing.Point(777, 0)
        Me.MRefresh.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MRefresh.Name = "MRefresh"
        Me.HP.SetShowHelp(Me.MRefresh, True)
        Me.MRefresh.Size = New System.Drawing.Size(40, 40)
        Me.MRefresh.TabIndex = 149
        Me.MRefresh.Tag = "Refresh"
        Me.MRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.MRefresh, "Refresh")
        Me.MRefresh.UseVisualStyleBackColor = False
        Me.MRefresh.Visible = False
        '
        'ButtonPromenaIstrazivanja
        '
        Me.ButtonPromenaIstrazivanja.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPromenaIstrazivanja.FlatAppearance.BorderSize = 0
        Me.ButtonPromenaIstrazivanja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ButtonPromenaIstrazivanja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ButtonPromenaIstrazivanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPromenaIstrazivanja.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPromenaIstrazivanja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ButtonPromenaIstrazivanja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPromenaIstrazivanja.Location = New System.Drawing.Point(714, 38)
        Me.ButtonPromenaIstrazivanja.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonPromenaIstrazivanja.Name = "ButtonPromenaIstrazivanja"
        Me.ButtonPromenaIstrazivanja.Size = New System.Drawing.Size(179, 21)
        Me.ButtonPromenaIstrazivanja.TabIndex = 30
        Me.ButtonPromenaIstrazivanja.Text = "Избор апликације"
        Me.ButtonPromenaIstrazivanja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonPromenaIstrazivanja.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ButtonPromenaIstrazivanja.UseVisualStyleBackColor = False
        Me.ButtonPromenaIstrazivanja.Visible = False
        '
        'lblNaziv
        '
        Me.lblNaziv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNaziv.BackColor = System.Drawing.Color.Transparent
        Me.lblNaziv.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNaziv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblNaziv.Location = New System.Drawing.Point(7, 151)
        Me.lblNaziv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNaziv.Name = "lblNaziv"
        Me.lblNaziv.Size = New System.Drawing.Size(886, 55)
        Me.lblNaziv.TabIndex = 143
        Me.lblNaziv.Tag = "nediraj"
        Me.lblNaziv.Text = "."
        Me.lblNaziv.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSifra
        '
        Me.lblSifra.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSifra.BackColor = System.Drawing.Color.Transparent
        Me.lblSifra.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSifra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.lblSifra.Location = New System.Drawing.Point(7, 100)
        Me.lblSifra.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSifra.Name = "lblSifra"
        Me.lblSifra.Size = New System.Drawing.Size(886, 40)
        Me.lblSifra.TabIndex = 142
        Me.lblSifra.Tag = "nediraj"
        Me.lblSifra.Text = "."
        Me.lblSifra.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelContext
        '
        Me.PanelContext.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContext.Controls.Add(Me.panelFooter)
        Me.PanelContext.Controls.Add(Me.panelOstalo)
        Me.PanelContext.Controls.Add(Me.panelIST)
        Me.PanelContext.Controls.Add(Me.btnProba)
        Me.PanelContext.Controls.Add(Me.lblNaziv)
        Me.PanelContext.Controls.Add(Me.ButtonPromenaIstrazivanja)
        Me.PanelContext.Controls.Add(Me.panelSinhronizacija)
        Me.PanelContext.Controls.Add(Me.MILastVersionDate)
        Me.PanelContext.Controls.Add(Me.lblSifra)
        Me.PanelContext.Controls.Add(Me.lblPVT)
        Me.PanelContext.Controls.Add(Me.panelFooterPrazno)
        Me.PanelContext.Controls.Add(Me.btnLinijaRazmak)
        Me.PanelContext.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(255, 0)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(897, 749)
        Me.PanelContext.TabIndex = 144
        '
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.Transparent
        Me.panelFooter.Controls.Add(Me.btnFTRazmak5)
        Me.panelFooter.Controls.Add(Me.btnFT5)
        Me.panelFooter.Controls.Add(Me.btnFTRazmak4)
        Me.panelFooter.Controls.Add(Me.btnFT4)
        Me.panelFooter.Controls.Add(Me.btnFTRazmak3)
        Me.panelFooter.Controls.Add(Me.btnFT3)
        Me.panelFooter.Controls.Add(Me.btnFTRazmak2)
        Me.panelFooter.Controls.Add(Me.btnFT2)
        Me.panelFooter.Controls.Add(Me.btnFTRazmak1)
        Me.panelFooter.Controls.Add(Me.btnFT1)
        Me.panelFooter.Controls.Add(Me.btnFTKraj)
        Me.panelFooter.Controls.Add(Me.btnFTPocetni)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(2, 709)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(895, 20)
        Me.panelFooter.TabIndex = 10000070
        '
        'btnFTRazmak5
        '
        Me.btnFTRazmak5.BackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak5.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFTRazmak5.FlatAppearance.BorderSize = 0
        Me.btnFTRazmak5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTRazmak5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTRazmak5.ForeColor = System.Drawing.Color.Sienna
        Me.btnFTRazmak5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTRazmak5.Location = New System.Drawing.Point(716, 0)
        Me.btnFTRazmak5.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFTRazmak5.Name = "btnFTRazmak5"
        Me.btnFTRazmak5.Size = New System.Drawing.Size(20, 20)
        Me.btnFTRazmak5.TabIndex = 10000081
        Me.btnFTRazmak5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFTRazmak5.UseVisualStyleBackColor = False
        '
        'btnFT5
        '
        Me.btnFT5.AutoSize = True
        Me.btnFT5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFT5.BackColor = System.Drawing.Color.Transparent
        Me.btnFT5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFT5.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFT5.FlatAppearance.BorderSize = 0
        Me.btnFT5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFT5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFT5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFT5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnFT5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFT5.Location = New System.Drawing.Point(661, 0)
        Me.btnFT5.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFT5.Name = "btnFT5"
        Me.btnFT5.Size = New System.Drawing.Size(55, 20)
        Me.btnFT5.TabIndex = 10000080
        Me.btnFT5.Text = "LogLK"
        Me.btnFT5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFT5.UseVisualStyleBackColor = False
        '
        'btnFTRazmak4
        '
        Me.btnFTRazmak4.BackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak4.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFTRazmak4.FlatAppearance.BorderSize = 0
        Me.btnFTRazmak4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTRazmak4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTRazmak4.ForeColor = System.Drawing.Color.Sienna
        Me.btnFTRazmak4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTRazmak4.Location = New System.Drawing.Point(641, 0)
        Me.btnFTRazmak4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFTRazmak4.Name = "btnFTRazmak4"
        Me.btnFTRazmak4.Size = New System.Drawing.Size(20, 20)
        Me.btnFTRazmak4.TabIndex = 10000079
        Me.btnFTRazmak4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFTRazmak4.UseVisualStyleBackColor = False
        '
        'btnFT4
        '
        Me.btnFT4.AutoSize = True
        Me.btnFT4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFT4.BackColor = System.Drawing.Color.Transparent
        Me.btnFT4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFT4.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFT4.FlatAppearance.BorderSize = 0
        Me.btnFT4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFT4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFT4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFT4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnFT4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFT4.Location = New System.Drawing.Point(542, 0)
        Me.btnFT4.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFT4.Name = "btnFT4"
        Me.btnFT4.Size = New System.Drawing.Size(99, 20)
        Me.btnFT4.TabIndex = 10000078
        Me.btnFT4.Text = "buttonOcena"
        Me.btnFT4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFT4.UseVisualStyleBackColor = False
        '
        'btnFTRazmak3
        '
        Me.btnFTRazmak3.BackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak3.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFTRazmak3.FlatAppearance.BorderSize = 0
        Me.btnFTRazmak3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTRazmak3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTRazmak3.ForeColor = System.Drawing.Color.Sienna
        Me.btnFTRazmak3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTRazmak3.Location = New System.Drawing.Point(522, 0)
        Me.btnFTRazmak3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFTRazmak3.Name = "btnFTRazmak3"
        Me.btnFTRazmak3.Size = New System.Drawing.Size(20, 20)
        Me.btnFTRazmak3.TabIndex = 10000077
        Me.btnFTRazmak3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFTRazmak3.UseVisualStyleBackColor = False
        '
        'btnFT3
        '
        Me.btnFT3.AutoSize = True
        Me.btnFT3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFT3.BackColor = System.Drawing.Color.Transparent
        Me.btnFT3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFT3.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFT3.FlatAppearance.BorderSize = 0
        Me.btnFT3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFT3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFT3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnFT3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnFT3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFT3.Location = New System.Drawing.Point(324, 0)
        Me.btnFT3.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFT3.Name = "btnFT3"
        Me.btnFT3.Size = New System.Drawing.Size(198, 20)
        Me.btnFT3.TabIndex = 10000076
        Me.btnFT3.Text = "PoslednjiDatumSaPodacima"
        Me.btnFT3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFT3.UseVisualStyleBackColor = False
        '
        'btnFTRazmak2
        '
        Me.btnFTRazmak2.BackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFTRazmak2.FlatAppearance.BorderSize = 0
        Me.btnFTRazmak2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTRazmak2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTRazmak2.ForeColor = System.Drawing.Color.Sienna
        Me.btnFTRazmak2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTRazmak2.Location = New System.Drawing.Point(304, 0)
        Me.btnFTRazmak2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFTRazmak2.Name = "btnFTRazmak2"
        Me.btnFTRazmak2.Size = New System.Drawing.Size(20, 20)
        Me.btnFTRazmak2.TabIndex = 10000075
        Me.btnFTRazmak2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFTRazmak2.UseVisualStyleBackColor = False
        '
        'btnFT2
        '
        Me.btnFT2.AutoSize = True
        Me.btnFT2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFT2.BackColor = System.Drawing.Color.Transparent
        Me.btnFT2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFT2.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFT2.FlatAppearance.BorderSize = 0
        Me.btnFT2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFT2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFT2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFT2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnFT2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFT2.Location = New System.Drawing.Point(208, 0)
        Me.btnFT2.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFT2.Name = "btnFT2"
        Me.btnFT2.Size = New System.Drawing.Size(96, 20)
        Me.btnFT2.TabIndex = 10000074
        Me.btnFT2.Text = "BrojSlogova"
        Me.btnFT2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFT2.UseVisualStyleBackColor = False
        '
        'btnFTRazmak1
        '
        Me.btnFTRazmak1.BackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak1.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFTRazmak1.FlatAppearance.BorderSize = 0
        Me.btnFTRazmak1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFTRazmak1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTRazmak1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTRazmak1.ForeColor = System.Drawing.Color.Sienna
        Me.btnFTRazmak1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTRazmak1.Location = New System.Drawing.Point(188, 0)
        Me.btnFTRazmak1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFTRazmak1.Name = "btnFTRazmak1"
        Me.btnFTRazmak1.Size = New System.Drawing.Size(20, 20)
        Me.btnFTRazmak1.TabIndex = 10000073
        Me.btnFTRazmak1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFTRazmak1.UseVisualStyleBackColor = False
        '
        'btnFT1
        '
        Me.btnFT1.AutoSize = True
        Me.btnFT1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFT1.BackColor = System.Drawing.Color.Transparent
        Me.btnFT1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFT1.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFT1.FlatAppearance.BorderSize = 0
        Me.btnFT1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFT1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFT1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFT1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnFT1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFT1.Location = New System.Drawing.Point(70, 0)
        Me.btnFT1.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFT1.Name = "btnFT1"
        Me.btnFT1.Size = New System.Drawing.Size(118, 20)
        Me.btnFT1.TabIndex = 10000072
        Me.btnFT1.Text = "ValidniIntervali"
        Me.btnFT1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFT1.UseVisualStyleBackColor = False
        '
        'btnFTKraj
        '
        Me.btnFTKraj.BackColor = System.Drawing.Color.Transparent
        Me.btnFTKraj.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFTKraj.FlatAppearance.BorderSize = 0
        Me.btnFTKraj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFTKraj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFTKraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTKraj.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTKraj.ForeColor = System.Drawing.Color.White
        Me.btnFTKraj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTKraj.Location = New System.Drawing.Point(825, 0)
        Me.btnFTKraj.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFTKraj.Name = "btnFTKraj"
        Me.btnFTKraj.Size = New System.Drawing.Size(70, 20)
        Me.btnFTKraj.TabIndex = 10000071
        Me.btnFTKraj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFTKraj.UseVisualStyleBackColor = False
        '
        'btnFTPocetni
        '
        Me.btnFTPocetni.BackColor = System.Drawing.Color.Transparent
        Me.btnFTPocetni.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFTPocetni.FlatAppearance.BorderSize = 0
        Me.btnFTPocetni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFTPocetni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFTPocetni.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFTPocetni.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFTPocetni.ForeColor = System.Drawing.Color.White
        Me.btnFTPocetni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTPocetni.Location = New System.Drawing.Point(0, 0)
        Me.btnFTPocetni.Margin = New System.Windows.Forms.Padding(0)
        Me.btnFTPocetni.Name = "btnFTPocetni"
        Me.btnFTPocetni.Size = New System.Drawing.Size(70, 20)
        Me.btnFTPocetni.TabIndex = 26
        Me.btnFTPocetni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFTPocetni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFTPocetni.UseVisualStyleBackColor = False
        '
        'panelOstalo
        '
        Me.panelOstalo.Controls.Add(Me.bSemiAutomaticCoding)
        Me.panelOstalo.Controls.Add(Me.bAdvancedTableUpdate)
        Me.panelOstalo.Location = New System.Drawing.Point(19, 59)
        Me.panelOstalo.Name = "panelOstalo"
        Me.panelOstalo.Size = New System.Drawing.Size(200, 100)
        Me.panelOstalo.TabIndex = 10000071
        Me.panelOstalo.Visible = False
        '
        'bSemiAutomaticCoding
        '
        Me.bSemiAutomaticCoding.ActiveLinkColor = System.Drawing.Color.Black
        Me.bSemiAutomaticCoding.AutoSize = True
        Me.bSemiAutomaticCoding.BackColor = System.Drawing.Color.Transparent
        Me.bSemiAutomaticCoding.DisabledLinkColor = System.Drawing.Color.Black
        Me.bSemiAutomaticCoding.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bSemiAutomaticCoding.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.bSemiAutomaticCoding.LinkColor = System.Drawing.Color.Black
        Me.bSemiAutomaticCoding.Location = New System.Drawing.Point(18, 17)
        Me.bSemiAutomaticCoding.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bSemiAutomaticCoding.Name = "bSemiAutomaticCoding"
        Me.bSemiAutomaticCoding.Size = New System.Drawing.Size(137, 13)
        Me.bSemiAutomaticCoding.TabIndex = 113
        Me.bSemiAutomaticCoding.TabStop = True
        Me.bSemiAutomaticCoding.Text = "Semi automatic coding"
        Me.bSemiAutomaticCoding.Visible = False
        '
        'bAdvancedTableUpdate
        '
        Me.bAdvancedTableUpdate.ActiveLinkColor = System.Drawing.Color.Black
        Me.bAdvancedTableUpdate.AutoSize = True
        Me.bAdvancedTableUpdate.BackColor = System.Drawing.Color.Transparent
        Me.bAdvancedTableUpdate.DisabledLinkColor = System.Drawing.Color.Black
        Me.bAdvancedTableUpdate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.bAdvancedTableUpdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.bAdvancedTableUpdate.LinkColor = System.Drawing.Color.Black
        Me.bAdvancedTableUpdate.Location = New System.Drawing.Point(18, 38)
        Me.bAdvancedTableUpdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.bAdvancedTableUpdate.Name = "bAdvancedTableUpdate"
        Me.bAdvancedTableUpdate.Size = New System.Drawing.Size(138, 13)
        Me.bAdvancedTableUpdate.TabIndex = 112
        Me.bAdvancedTableUpdate.TabStop = True
        Me.bAdvancedTableUpdate.Text = "Advanced table update"
        Me.bAdvancedTableUpdate.Visible = False
        '
        'panelIST
        '
        Me.panelIST.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.panelIST.ColumnCount = 2
        Me.panelIST.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.0!))
        Me.panelIST.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.0!))
        Me.panelIST.Controls.Add(Me.txtIST, 0, 0)
        Me.panelIST.Controls.Add(Me.dgvIST, 0, 1)
        Me.panelIST.Controls.Add(Me.panelLast5, 0, 3)
        Me.panelIST.Controls.Add(Me.btnChoose, 1, 0)
        Me.panelIST.Controls.Add(Me.PanelVT, 0, 5)
        Me.panelIST.Location = New System.Drawing.Point(10, 210)
        Me.panelIST.Margin = New System.Windows.Forms.Padding(0)
        Me.panelIST.Name = "panelIST"
        Me.panelIST.RowCount = 6
        Me.panelIST.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.panelIST.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600.0!))
        Me.panelIST.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.panelIST.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.panelIST.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.panelIST.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.panelIST.Size = New System.Drawing.Size(878, 325)
        Me.panelIST.TabIndex = 10000068
        '
        'txtIST
        '
        Me.txtIST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIST.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIST.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIST.Location = New System.Drawing.Point(0, 0)
        Me.txtIST.Margin = New System.Windows.Forms.Padding(0)
        Me.txtIST.MaxLength = 20
        Me.txtIST.Name = "txtIST"
        Me.HP.SetShowHelp(Me.txtIST, True)
        Me.txtIST.Size = New System.Drawing.Size(851, 33)
        Me.txtIST.TabIndex = 10000066
        '
        'dgvIST
        '
        Me.dgvIST.AllowUserToAddRows = False
        Me.dgvIST.AllowUserToDeleteRows = False
        Me.dgvIST.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvIST.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvIST.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvIST.ColumnHeadersHeight = 22
        Me.dgvIST.ColumnHeadersVisible = False
        Me.dgvIST.GridColor = System.Drawing.Color.Gainsboro
        Me.dgvIST.Location = New System.Drawing.Point(0, 33)
        Me.dgvIST.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvIST.Name = "dgvIST"
        Me.dgvIST.ReadOnly = True
        Me.dgvIST.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvIST.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvIST.RowTemplate.Height = 25
        Me.dgvIST.Size = New System.Drawing.Size(851, 200)
        Me.dgvIST.TabIndex = 10000069
        '
        'panelLast5
        '
        Me.panelLast5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelLast5.BackColor = System.Drawing.Color.Transparent
        Me.panelLast5.Location = New System.Drawing.Point(3, 655)
        Me.panelLast5.Name = "panelLast5"
        Me.panelLast5.Size = New System.Drawing.Size(845, 45)
        Me.panelLast5.TabIndex = 10000069
        '
        'btnChoose
        '
        Me.btnChoose.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnChoose.FlatAppearance.BorderSize = 0
        Me.btnChoose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChoose.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChoose.ForeColor = System.Drawing.Color.Black
        Me.btnChoose.Image = CType(resources.GetObject("btnChoose.Image"), System.Drawing.Image)
        Me.btnChoose.Location = New System.Drawing.Point(851, 0)
        Me.btnChoose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(27, 33)
        Me.btnChoose.TabIndex = 159
        Me.btnChoose.TabStop = False
        Me.btnChoose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnChoose.UseVisualStyleBackColor = False
        '
        'PanelVT
        '
        Me.PanelVT.BackColor = System.Drawing.Color.Transparent
        Me.PanelVT.Controls.Add(Me.UserControlVremenskaTacka1)
        Me.PanelVT.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVT.Location = New System.Drawing.Point(3, 761)
        Me.PanelVT.Name = "PanelVT"
        Me.PanelVT.Size = New System.Drawing.Size(845, 79)
        Me.PanelVT.TabIndex = 10000070
        '
        'UserControlVremenskaTacka1
        '
        Me.UserControlVremenskaTacka1.BackColor = System.Drawing.Color.Transparent
        Me.UserControlVremenskaTacka1.Font = New System.Drawing.Font("Verdana", 10.2!)
        Me.UserControlVremenskaTacka1.Location = New System.Drawing.Point(363, 6)
        Me.UserControlVremenskaTacka1.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.UserControlVremenskaTacka1.Name = "UserControlVremenskaTacka1"
        Me.UserControlVremenskaTacka1.Size = New System.Drawing.Size(118, 70)
        Me.UserControlVremenskaTacka1.TabIndex = 82
        '
        'btnProba
        '
        Me.btnProba.BackColor = System.Drawing.Color.Transparent
        Me.btnProba.FlatAppearance.BorderSize = 0
        Me.btnProba.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnProba.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnProba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProba.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProba.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnProba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProba.Location = New System.Drawing.Point(714, 59)
        Me.btnProba.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProba.Name = "btnProba"
        Me.btnProba.Size = New System.Drawing.Size(179, 21)
        Me.btnProba.TabIndex = 160
        Me.btnProba.Text = "Proba"
        Me.btnProba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProba.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnProba.UseVisualStyleBackColor = False
        Me.btnProba.Visible = False
        '
        'MILastVersionDate
        '
        Me.MILastVersionDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MILastVersionDate.BackColor = System.Drawing.Color.Transparent
        Me.MILastVersionDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MILastVersionDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MILastVersionDate.Location = New System.Drawing.Point(444, 3)
        Me.MILastVersionDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MILastVersionDate.Name = "MILastVersionDate"
        Me.MILastVersionDate.Size = New System.Drawing.Size(449, 14)
        Me.MILastVersionDate.TabIndex = 154
        Me.MILastVersionDate.Tag = ""
        Me.MILastVersionDate.Text = "ISTversion"
        Me.MILastVersionDate.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'panelFooterPrazno
        '
        Me.panelFooterPrazno.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooterPrazno.Location = New System.Drawing.Point(2, 729)
        Me.panelFooterPrazno.Name = "panelFooterPrazno"
        Me.panelFooterPrazno.Size = New System.Drawing.Size(895, 20)
        Me.panelFooterPrazno.TabIndex = 10000072
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
        Me.btnLinijaRazmak.Size = New System.Drawing.Size(2, 749)
        Me.btnLinijaRazmak.TabIndex = 10000075
        Me.btnLinijaRazmak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinijaRazmak.UseVisualStyleBackColor = False
        '
        'PanelBoje
        '
        Me.PanelBoje.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelBoje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelBoje.Controls.Add(Me.btnA5)
        Me.PanelBoje.Controls.Add(Me.btnA4)
        Me.PanelBoje.Controls.Add(Me.btnA3)
        Me.PanelBoje.Controls.Add(Me.btnA6)
        Me.PanelBoje.Controls.Add(Me.btnA2)
        Me.PanelBoje.Controls.Add(Me.btnA1)
        Me.PanelBoje.Controls.Add(Me.btnA7)
        Me.PanelBoje.Controls.Add(Me.btnLight)
        Me.PanelBoje.Controls.Add(Me.btnDark)
        Me.PanelBoje.Location = New System.Drawing.Point(73, 580)
        Me.PanelBoje.Name = "PanelBoje"
        Me.PanelBoje.Size = New System.Drawing.Size(117, 117)
        Me.PanelBoje.TabIndex = 10000072
        Me.PanelBoje.Visible = False
        '
        'btnA5
        '
        Me.btnA5.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnA5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnA5.FlatAppearance.BorderSize = 2
        Me.btnA5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA5.Location = New System.Drawing.Point(79, 78)
        Me.btnA5.Name = "btnA5"
        Me.btnA5.Size = New System.Drawing.Size(30, 30)
        Me.btnA5.TabIndex = 8
        Me.btnA5.Tag = "A5"
        Me.btnA5.UseVisualStyleBackColor = False
        '
        'btnA4
        '
        Me.btnA4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnA4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnA4.FlatAppearance.BorderSize = 2
        Me.btnA4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA4.Location = New System.Drawing.Point(43, 78)
        Me.btnA4.Name = "btnA4"
        Me.btnA4.Size = New System.Drawing.Size(30, 30)
        Me.btnA4.TabIndex = 7
        Me.btnA4.Tag = "A4"
        Me.btnA4.UseVisualStyleBackColor = False
        '
        'btnA3
        '
        Me.btnA3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.btnA3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnA3.FlatAppearance.BorderSize = 2
        Me.btnA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA3.Location = New System.Drawing.Point(7, 78)
        Me.btnA3.Name = "btnA3"
        Me.btnA3.Size = New System.Drawing.Size(30, 30)
        Me.btnA3.TabIndex = 6
        Me.btnA3.Tag = "A3"
        Me.btnA3.UseVisualStyleBackColor = False
        '
        'btnA6
        '
        Me.btnA6.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnA6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnA6.FlatAppearance.BorderSize = 2
        Me.btnA6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA6.Location = New System.Drawing.Point(79, 42)
        Me.btnA6.Name = "btnA6"
        Me.btnA6.Size = New System.Drawing.Size(30, 30)
        Me.btnA6.TabIndex = 5
        Me.btnA6.Tag = "A6"
        Me.btnA6.UseVisualStyleBackColor = False
        '
        'btnA2
        '
        Me.btnA2.BackColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnA2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnA2.FlatAppearance.BorderSize = 2
        Me.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA2.Location = New System.Drawing.Point(43, 42)
        Me.btnA2.Name = "btnA2"
        Me.btnA2.Size = New System.Drawing.Size(30, 30)
        Me.btnA2.TabIndex = 4
        Me.btnA2.Tag = "A2"
        Me.btnA2.UseVisualStyleBackColor = False
        '
        'btnA1
        '
        Me.btnA1.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnA1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnA1.FlatAppearance.BorderSize = 2
        Me.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA1.Location = New System.Drawing.Point(7, 42)
        Me.btnA1.Name = "btnA1"
        Me.btnA1.Size = New System.Drawing.Size(30, 30)
        Me.btnA1.TabIndex = 3
        Me.btnA1.Tag = "A1"
        Me.btnA1.UseVisualStyleBackColor = False
        '
        'btnA7
        '
        Me.btnA7.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.btnA7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnA7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnA7.FlatAppearance.BorderSize = 2
        Me.btnA7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA7.Location = New System.Drawing.Point(79, 6)
        Me.btnA7.Name = "btnA7"
        Me.btnA7.Size = New System.Drawing.Size(30, 30)
        Me.btnA7.TabIndex = 2
        Me.btnA7.Tag = "A7"
        Me.btnA7.UseVisualStyleBackColor = False
        '
        'btnLight
        '
        Me.btnLight.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.btnLight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnLight.FlatAppearance.BorderSize = 2
        Me.btnLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLight.Location = New System.Drawing.Point(43, 6)
        Me.btnLight.Name = "btnLight"
        Me.btnLight.Size = New System.Drawing.Size(30, 30)
        Me.btnLight.TabIndex = 1
        Me.btnLight.Tag = "LIGHT"
        Me.btnLight.UseVisualStyleBackColor = False
        '
        'btnDark
        '
        Me.btnDark.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDark.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDark.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDark.FlatAppearance.BorderSize = 2
        Me.btnDark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDark.Location = New System.Drawing.Point(7, 6)
        Me.btnDark.Name = "btnDark"
        Me.btnDark.Size = New System.Drawing.Size(30, 30)
        Me.btnDark.TabIndex = 0
        Me.btnDark.Tag = "DARK"
        Me.btnDark.UseVisualStyleBackColor = False
        '
        'ctMenuStrip
        '
        Me.ctMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ctMenuStrip.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MIAplikacija, Me.MIAdministracija, Me.MIUputstva, Me.MILanguage, Me.mMode})
        Me.ctMenuStrip.Name = "ctMenuStrip"
        Me.ctMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ctMenuStrip.Size = New System.Drawing.Size(189, 154)
        '
        'MIAplikacija
        '
        Me.MIAplikacija.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MIZO, Me.MIZakljucaj, Me.MIZakljucajWeb, Me.MIOtkljucaj, Me.MIOtkljucajWeb})
        Me.MIAplikacija.Image = CType(resources.GetObject("MIAplikacija.Image"), System.Drawing.Image)
        Me.MIAplikacija.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MIAplikacija.Name = "MIAplikacija"
        Me.MIAplikacija.Size = New System.Drawing.Size(188, 30)
        Me.MIAplikacija.Text = "Апликација"
        '
        'MIZO
        '
        Me.MIZO.Name = "MIZO"
        Me.MIZO.Size = New System.Drawing.Size(197, 22)
        Me.MIZO.Text = "ЗО по табелама"
        '
        'MIZakljucaj
        '
        Me.MIZakljucaj.Name = "MIZakljucaj"
        Me.MIZakljucaj.Size = New System.Drawing.Size(197, 22)
        Me.MIZakljucaj.Text = "&Закључавање"
        '
        'MIZakljucajWeb
        '
        Me.MIZakljucajWeb.Name = "MIZakljucajWeb"
        Me.MIZakljucajWeb.Size = New System.Drawing.Size(197, 22)
        Me.MIZakljucajWeb.Text = "Закључавање web"
        '
        'MIOtkljucaj
        '
        Me.MIOtkljucaj.Name = "MIOtkljucaj"
        Me.MIOtkljucaj.Size = New System.Drawing.Size(197, 22)
        Me.MIOtkljucaj.Text = "От&кључавање"
        '
        'MIOtkljucajWeb
        '
        Me.MIOtkljucajWeb.Name = "MIOtkljucajWeb"
        Me.MIOtkljucajWeb.Size = New System.Drawing.Size(197, 22)
        Me.MIOtkljucajWeb.Text = "Откључавање web"
        '
        'MIAdministracija
        '
        Me.MIAdministracija.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MIist2xml, Me.MIIstUAspax, Me.MIPodaciXml, Me.MIXmlPodaci, Me.MiXMLuIST, Me.MenuCAPI, Me.MenuImportExcel, Me.MIProjektanti, Me.ISTMetaOld, Me.MIMreza})
        Me.MIAdministracija.Name = "MIAdministracija"
        Me.MIAdministracija.Size = New System.Drawing.Size(188, 30)
        Me.MIAdministracija.Text = "Администрација"
        '
        'MIist2xml
        '
        Me.MIist2xml.Image = CType(resources.GetObject("MIist2xml.Image"), System.Drawing.Image)
        Me.MIist2xml.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MIist2xml.Name = "MIist2xml"
        Me.MIist2xml.Size = New System.Drawing.Size(220, 30)
        Me.MIist2xml.Text = "I&ST -> XML"
        '
        'MIIstUAspax
        '
        Me.MIIstUAspax.Name = "MIIstUAspax"
        Me.MIIstUAspax.Size = New System.Drawing.Size(220, 30)
        Me.MIIstUAspax.Text = "IST -> ASPX"
        '
        'MIPodaciXml
        '
        Me.MIPodaciXml.Name = "MIPodaciXml"
        Me.MIPodaciXml.Size = New System.Drawing.Size(220, 30)
        Me.MIPodaciXml.Text = "P&odaci -> XML"
        '
        'MIXmlPodaci
        '
        Me.MIXmlPodaci.Name = "MIXmlPodaci"
        Me.MIXmlPodaci.Size = New System.Drawing.Size(220, 30)
        Me.MIXmlPodaci.Text = "XML -> Po&daci"
        '
        'MiXMLuIST
        '
        Me.MiXMLuIST.Name = "MiXMLuIST"
        Me.MiXMLuIST.Size = New System.Drawing.Size(220, 30)
        Me.MiXMLuIST.Text = "X&ML -> IST"
        '
        'MenuCAPI
        '
        Me.MenuCAPI.Name = "MenuCAPI"
        Me.MenuCAPI.Size = New System.Drawing.Size(220, 30)
        Me.MenuCAPI.Text = "Preparation for CAPI"
        '
        'MenuImportExcel
        '
        Me.MenuImportExcel.Name = "MenuImportExcel"
        Me.MenuImportExcel.Size = New System.Drawing.Size(220, 30)
        Me.MenuImportExcel.Text = "Import Excel file to DB"
        '
        'MIProjektanti
        '
        Me.MIProjektanti.Name = "MIProjektanti"
        Me.MIProjektanti.Size = New System.Drawing.Size(220, 30)
        Me.MIProjektanti.Text = "Пројектанти"
        '
        'ISTMetaOld
        '
        Me.ISTMetaOld.Name = "ISTMetaOld"
        Me.ISTMetaOld.Size = New System.Drawing.Size(220, 30)
        Me.ISTMetaOld.Text = "*GUI"
        '
        'MIMreza
        '
        Me.MIMreza.Name = "MIMreza"
        Me.MIMreza.Size = New System.Drawing.Size(220, 30)
        Me.MIMreza.Text = "Query designer"
        '
        'MIUputstva
        '
        Me.MIUputstva.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mKorisnickoUputstvo, Me.mVodic, Me.MICatiGuide, Me.mTehDok})
        Me.MIUputstva.Name = "MIUputstva"
        Me.MIUputstva.Size = New System.Drawing.Size(188, 30)
        Me.MIUputstva.Text = "Упутства"
        '
        'mKorisnickoUputstvo
        '
        Me.mKorisnickoUputstvo.Image = CType(resources.GetObject("mKorisnickoUputstvo.Image"), System.Drawing.Image)
        Me.mKorisnickoUputstvo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mKorisnickoUputstvo.Name = "mKorisnickoUputstvo"
        Me.mKorisnickoUputstvo.Size = New System.Drawing.Size(287, 30)
        Me.mKorisnickoUputstvo.Text = "User guide"
        '
        'mVodic
        '
        Me.mVodic.Name = "mVodic"
        Me.mVodic.Size = New System.Drawing.Size(287, 30)
        Me.mVodic.Text = "Developer guide"
        '
        'MICatiGuide
        '
        Me.MICatiGuide.Name = "MICatiGuide"
        Me.MICatiGuide.Size = New System.Drawing.Size(287, 30)
        Me.MICatiGuide.Text = "CATI guide"
        '
        'mTehDok
        '
        Me.mTehDok.Name = "mTehDok"
        Me.mTehDok.Size = New System.Drawing.Size(287, 30)
        Me.mTehDok.Text = "IST -> Техничка документација"
        '
        'MILanguage
        '
        Me.MILanguage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mAlbanian, Me.mBulgarian, Me.mGerL, Me.mEnglish, Me.mItalian, Me.mKirgyz, Me.mMakC, Me.mRussian, Me.mSrpskiL, Me.mSrpskiC, Me.mVIET, Me.mTurL, Me.mUzbek, Me.mMneL, Me.mNasL})
        Me.MILanguage.Name = "MILanguage"
        Me.MILanguage.Size = New System.Drawing.Size(188, 30)
        Me.MILanguage.Text = "Language"
        '
        'mAlbanian
        '
        Me.mAlbanian.Image = CType(resources.GetObject("mAlbanian.Image"), System.Drawing.Image)
        Me.mAlbanian.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mAlbanian.Name = "mAlbanian"
        Me.mAlbanian.Size = New System.Drawing.Size(186, 30)
        Me.mAlbanian.Tag = "nediraj"
        Me.mAlbanian.Text = "Albanian"
        '
        'mBulgarian
        '
        Me.mBulgarian.Name = "mBulgarian"
        Me.mBulgarian.Size = New System.Drawing.Size(186, 30)
        Me.mBulgarian.Text = "Български"
        '
        'mGerL
        '
        Me.mGerL.Name = "mGerL"
        Me.mGerL.Size = New System.Drawing.Size(186, 30)
        Me.mGerL.Text = "Deutsche"
        '
        'mEnglish
        '
        Me.mEnglish.Name = "mEnglish"
        Me.mEnglish.Size = New System.Drawing.Size(186, 30)
        Me.mEnglish.Tag = "nediraj"
        Me.mEnglish.Text = "English"
        '
        'mItalian
        '
        Me.mItalian.Name = "mItalian"
        Me.mItalian.Size = New System.Drawing.Size(186, 30)
        Me.mItalian.Text = "Italian"
        '
        'mKirgyz
        '
        Me.mKirgyz.Name = "mKirgyz"
        Me.mKirgyz.Size = New System.Drawing.Size(186, 30)
        Me.mKirgyz.Text = "Kyrgyz"
        '
        'mMakC
        '
        Me.mMakC.Name = "mMakC"
        Me.mMakC.Size = New System.Drawing.Size(186, 30)
        Me.mMakC.Text = "Македонски"
        '
        'mRussian
        '
        Me.mRussian.Name = "mRussian"
        Me.mRussian.Size = New System.Drawing.Size(186, 30)
        Me.mRussian.Text = "Русский"
        '
        'mSrpskiL
        '
        Me.mSrpskiL.Name = "mSrpskiL"
        Me.mSrpskiL.Size = New System.Drawing.Size(186, 30)
        Me.mSrpskiL.Tag = "nediraj"
        Me.mSrpskiL.Text = "Srpski"
        '
        'mSrpskiC
        '
        Me.mSrpskiC.Name = "mSrpskiC"
        Me.mSrpskiC.Size = New System.Drawing.Size(186, 30)
        Me.mSrpskiC.Tag = "nediraj"
        Me.mSrpskiC.Text = "Српски"
        '
        'mVIET
        '
        Me.mVIET.Name = "mVIET"
        Me.mVIET.Size = New System.Drawing.Size(186, 30)
        Me.mVIET.Text = "Tiếng Việt"
        '
        'mTurL
        '
        Me.mTurL.Name = "mTurL"
        Me.mTurL.Size = New System.Drawing.Size(186, 30)
        Me.mTurL.Text = "Türk"
        '
        'mUzbek
        '
        Me.mUzbek.Name = "mUzbek"
        Me.mUzbek.Size = New System.Drawing.Size(186, 30)
        Me.mUzbek.Text = "Uzbek"
        '
        'mMneL
        '
        Me.mMneL.Name = "mMneL"
        Me.mMneL.Size = New System.Drawing.Size(186, 30)
        Me.mMneL.Tag = "nediraj"
        Me.mMneL.Text = "Crnogorski"
        '
        'mNasL
        '
        Me.mNasL.Name = "mNasL"
        Me.mNasL.Size = New System.Drawing.Size(186, 30)
        Me.mNasL.Text = "Na našem jeziku"
        '
        'mMode
        '
        Me.mMode.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mDesktop, Me.mCAPI})
        Me.mMode.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mMode.Name = "mMode"
        Me.mMode.Size = New System.Drawing.Size(188, 30)
        Me.mMode.Text = "Mode"
        '
        'mDesktop
        '
        Me.mDesktop.Image = CType(resources.GetObject("mDesktop.Image"), System.Drawing.Image)
        Me.mDesktop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mDesktop.Name = "mDesktop"
        Me.mDesktop.Size = New System.Drawing.Size(160, 30)
        Me.mDesktop.Text = "Desktop"
        '
        'mCAPI
        '
        Me.mCAPI.Name = "mCAPI"
        Me.mCAPI.Size = New System.Drawing.Size(160, 30)
        Me.mCAPI.Text = "CAPI census"
        '
        'ButtonUnos
        '
        Me.ButtonUnos.BackColor = System.Drawing.Color.Transparent
        Me.ButtonUnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonUnos.FlatAppearance.BorderSize = 0
        Me.ButtonUnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUnos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUnos.ForeColor = System.Drawing.Color.White
        Me.ButtonUnos.Image = CType(resources.GetObject("ButtonUnos.Image"), System.Drawing.Image)
        Me.ButtonUnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUnos.Location = New System.Drawing.Point(10, 4)
        Me.ButtonUnos.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonUnos.Name = "ButtonUnos"
        Me.ButtonUnos.Size = New System.Drawing.Size(240, 38)
        Me.ButtonUnos.TabIndex = 0
        Me.ButtonUnos.Text = "    Унос"
        Me.ButtonUnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonUnos.UseVisualStyleBackColor = False
        '
        'ButtonLogickaKontrola
        '
        Me.ButtonLogickaKontrola.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLogickaKontrola.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogickaKontrola.FlatAppearance.BorderSize = 0
        Me.ButtonLogickaKontrola.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonLogickaKontrola.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogickaKontrola.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogickaKontrola.ForeColor = System.Drawing.Color.White
        Me.ButtonLogickaKontrola.Image = CType(resources.GetObject("ButtonLogickaKontrola.Image"), System.Drawing.Image)
        Me.ButtonLogickaKontrola.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogickaKontrola.Location = New System.Drawing.Point(10, 41)
        Me.ButtonLogickaKontrola.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLogickaKontrola.Name = "ButtonLogickaKontrola"
        Me.ButtonLogickaKontrola.Size = New System.Drawing.Size(240, 38)
        Me.ButtonLogickaKontrola.TabIndex = 2
        Me.ButtonLogickaKontrola.Text = "    Логичка контрола"
        Me.ButtonLogickaKontrola.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLogickaKontrola.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLogickaKontrola.UseVisualStyleBackColor = False
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
        Me.btnMenu.TabIndex = 13
        Me.btnMenu.TabStop = False
        '
        'btnCAPI
        '
        Me.btnCAPI.BackColor = System.Drawing.Color.Transparent
        Me.btnCAPI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCAPI.FlatAppearance.BorderSize = 0
        Me.btnCAPI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnCAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCAPI.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCAPI.ForeColor = System.Drawing.Color.White
        Me.btnCAPI.Image = CType(resources.GetObject("btnCAPI.Image"), System.Drawing.Image)
        Me.btnCAPI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCAPI.Location = New System.Drawing.Point(10, 6)
        Me.btnCAPI.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCAPI.Name = "btnCAPI"
        Me.HP.SetShowHelp(Me.btnCAPI, False)
        Me.btnCAPI.Size = New System.Drawing.Size(240, 38)
        Me.btnCAPI.TabIndex = 27
        Me.btnCAPI.Tag = "    Popisivanje"
        Me.btnCAPI.Text = "    Popisivanje"
        Me.btnCAPI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCAPI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCAPI.UseVisualStyleBackColor = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.PanelBoje)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.buttonTheme)
        Me.PanelMenu.Controls.Add(Me.btnLinija2)
        Me.PanelMenu.Controls.Add(Me.btnLinija1)
        Me.PanelMenu.Controls.Add(Me.Logovan)
        Me.PanelMenu.Controls.Add(Me.PanelDesktop)
        Me.PanelMenu.Controls.Add(Me.PanelCATI)
        Me.PanelMenu.Controls.Add(Me.PanelKonsultacione)
        Me.PanelMenu.Controls.Add(Me.PanelCAPI)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.Button7)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(255, 749)
        Me.PanelMenu.TabIndex = 141
        Me.PanelMenu.Tag = "Theme"
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
        Me.Button2.TabIndex = 10000073
        Me.Button2.Text = "W H E R E  I N T E G R A T I O N  M E E T S  I N F O R M A T I O N"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'buttonTheme
        '
        Me.buttonTheme.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonTheme.BackColor = System.Drawing.Color.Transparent
        Me.buttonTheme.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonTheme.FlatAppearance.BorderSize = 0
        Me.buttonTheme.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.buttonTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.buttonTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonTheme.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonTheme.Image = CType(resources.GetObject("buttonTheme.Image"), System.Drawing.Image)
        Me.buttonTheme.Location = New System.Drawing.Point(15, 665)
        Me.buttonTheme.Margin = New System.Windows.Forms.Padding(0)
        Me.buttonTheme.Name = "buttonTheme"
        Me.buttonTheme.Size = New System.Drawing.Size(27, 33)
        Me.buttonTheme.TabIndex = 161
        Me.buttonTheme.TabStop = False
        Me.buttonTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buttonTheme.UseVisualStyleBackColor = False
        '
        'btnLinija2
        '
        Me.btnLinija2.BackColor = System.Drawing.Color.Transparent
        Me.btnLinija2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLinija2.FlatAppearance.BorderSize = 0
        Me.btnLinija2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLinija2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLinija2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinija2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLinija2.ForeColor = System.Drawing.Color.White
        Me.btnLinija2.Image = CType(resources.GetObject("btnLinija2.Image"), System.Drawing.Image)
        Me.btnLinija2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLinija2.Location = New System.Drawing.Point(0, 452)
        Me.btnLinija2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLinija2.Name = "btnLinija2"
        Me.btnLinija2.Size = New System.Drawing.Size(255, 17)
        Me.btnLinija2.TabIndex = 159
        Me.btnLinija2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLinija2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinija2.UseVisualStyleBackColor = False
        '
        'btnLinija1
        '
        Me.btnLinija1.BackColor = System.Drawing.Color.Transparent
        Me.btnLinija1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLinija1.FlatAppearance.BorderSize = 0
        Me.btnLinija1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLinija1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLinija1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinija1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLinija1.ForeColor = System.Drawing.Color.White
        Me.btnLinija1.Image = CType(resources.GetObject("btnLinija1.Image"), System.Drawing.Image)
        Me.btnLinija1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLinija1.Location = New System.Drawing.Point(0, 381)
        Me.btnLinija1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLinija1.Name = "btnLinija1"
        Me.btnLinija1.Size = New System.Drawing.Size(255, 17)
        Me.btnLinija1.TabIndex = 158
        Me.btnLinija1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLinija1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinija1.UseVisualStyleBackColor = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.Transparent
        Me.PanelDesktop.Controls.Add(Me.BtnAdvancedSearch)
        Me.PanelDesktop.Controls.Add(Me.ButtonIzvestaji)
        Me.PanelDesktop.Controls.Add(Me.ButtonAzuriranje)
        Me.PanelDesktop.Controls.Add(Me.ButtonAK)
        Me.PanelDesktop.Controls.Add(Me.ButtonLogickaKontrola)
        Me.PanelDesktop.Controls.Add(Me.ButtonUnos)
        Me.PanelDesktop.Location = New System.Drawing.Point(0, 144)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(255, 238)
        Me.PanelDesktop.TabIndex = 155
        '
        'BtnAdvancedSearch
        '
        Me.BtnAdvancedSearch.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdvancedSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdvancedSearch.FlatAppearance.BorderSize = 0
        Me.BtnAdvancedSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnAdvancedSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdvancedSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdvancedSearch.ForeColor = System.Drawing.Color.White
        Me.BtnAdvancedSearch.Image = CType(resources.GetObject("BtnAdvancedSearch.Image"), System.Drawing.Image)
        Me.BtnAdvancedSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdvancedSearch.Location = New System.Drawing.Point(10, 189)
        Me.BtnAdvancedSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAdvancedSearch.Name = "BtnAdvancedSearch"
        Me.BtnAdvancedSearch.Size = New System.Drawing.Size(240, 38)
        Me.BtnAdvancedSearch.TabIndex = 25
        Me.BtnAdvancedSearch.Text = "    Напредна претрага"
        Me.BtnAdvancedSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAdvancedSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAdvancedSearch.UseVisualStyleBackColor = False
        '
        'ButtonIzvestaji
        '
        Me.ButtonIzvestaji.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIzvestaji.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzvestaji.FlatAppearance.BorderSize = 0
        Me.ButtonIzvestaji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonIzvestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIzvestaji.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzvestaji.ForeColor = System.Drawing.Color.White
        Me.ButtonIzvestaji.Image = CType(resources.GetObject("ButtonIzvestaji.Image"), System.Drawing.Image)
        Me.ButtonIzvestaji.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzvestaji.Location = New System.Drawing.Point(10, 152)
        Me.ButtonIzvestaji.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonIzvestaji.Name = "ButtonIzvestaji"
        Me.ButtonIzvestaji.Size = New System.Drawing.Size(240, 38)
        Me.ButtonIzvestaji.TabIndex = 24
        Me.ButtonIzvestaji.Text = "    Извештаји и процедуре"
        Me.ButtonIzvestaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzvestaji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonIzvestaji.UseVisualStyleBackColor = False
        '
        'ButtonAzuriranje
        '
        Me.ButtonAzuriranje.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAzuriranje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAzuriranje.FlatAppearance.BorderSize = 0
        Me.ButtonAzuriranje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonAzuriranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAzuriranje.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAzuriranje.ForeColor = System.Drawing.Color.White
        Me.ButtonAzuriranje.Image = CType(resources.GetObject("ButtonAzuriranje.Image"), System.Drawing.Image)
        Me.ButtonAzuriranje.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAzuriranje.Location = New System.Drawing.Point(10, 115)
        Me.ButtonAzuriranje.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonAzuriranje.Name = "ButtonAzuriranje"
        Me.ButtonAzuriranje.Size = New System.Drawing.Size(240, 38)
        Me.ButtonAzuriranje.TabIndex = 23
        Me.ButtonAzuriranje.Text = "    Ажурирање"
        Me.ButtonAzuriranje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAzuriranje.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAzuriranje.UseVisualStyleBackColor = False
        '
        'ButtonAK
        '
        Me.ButtonAK.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAK.FlatAppearance.BorderSize = 0
        Me.ButtonAK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonAK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAK.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAK.ForeColor = System.Drawing.Color.White
        Me.ButtonAK.Image = CType(resources.GetObject("ButtonAK.Image"), System.Drawing.Image)
        Me.ButtonAK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAK.Location = New System.Drawing.Point(10, 78)
        Me.ButtonAK.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonAK.Name = "ButtonAK"
        Me.ButtonAK.Size = New System.Drawing.Size(240, 38)
        Me.ButtonAK.TabIndex = 22
        Me.ButtonAK.Text = "    Аутоматска корекција"
        Me.ButtonAK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAK.UseVisualStyleBackColor = False
        '
        'PanelCATI
        '
        Me.PanelCATI.BackColor = System.Drawing.Color.Transparent
        Me.PanelCATI.Controls.Add(Me.btnCATI)
        Me.PanelCATI.Location = New System.Drawing.Point(0, 398)
        Me.PanelCATI.Name = "PanelCATI"
        Me.PanelCATI.Size = New System.Drawing.Size(255, 58)
        Me.PanelCATI.TabIndex = 156
        '
        'btnCATI
        '
        Me.btnCATI.BackColor = System.Drawing.Color.Transparent
        Me.btnCATI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCATI.FlatAppearance.BorderSize = 0
        Me.btnCATI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnCATI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCATI.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCATI.ForeColor = System.Drawing.Color.White
        Me.btnCATI.Image = CType(resources.GetObject("btnCATI.Image"), System.Drawing.Image)
        Me.btnCATI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCATI.Location = New System.Drawing.Point(10, 6)
        Me.btnCATI.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCATI.Name = "btnCATI"
        Me.btnCATI.Size = New System.Drawing.Size(240, 38)
        Me.btnCATI.TabIndex = 27
        Me.btnCATI.Tag = "      CATI"
        Me.btnCATI.Text = "      CATI"
        Me.btnCATI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCATI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCATI.UseVisualStyleBackColor = False
        '
        'PanelKonsultacione
        '
        Me.PanelKonsultacione.BackColor = System.Drawing.Color.Transparent
        Me.PanelKonsultacione.Controls.Add(Me.btnUnosA)
        Me.PanelKonsultacione.Controls.Add(Me.BtnAzurK)
        Me.PanelKonsultacione.Location = New System.Drawing.Point(0, 471)
        Me.PanelKonsultacione.Name = "PanelKonsultacione"
        Me.PanelKonsultacione.Size = New System.Drawing.Size(255, 93)
        Me.PanelKonsultacione.TabIndex = 157
        '
        'btnUnosA
        '
        Me.btnUnosA.BackColor = System.Drawing.Color.Transparent
        Me.btnUnosA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUnosA.FlatAppearance.BorderSize = 0
        Me.btnUnosA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnUnosA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnosA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnosA.ForeColor = System.Drawing.Color.White
        Me.btnUnosA.Image = CType(resources.GetObject("btnUnosA.Image"), System.Drawing.Image)
        Me.btnUnosA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnosA.Location = New System.Drawing.Point(10, 6)
        Me.btnUnosA.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUnosA.Name = "btnUnosA"
        Me.btnUnosA.Size = New System.Drawing.Size(240, 38)
        Me.btnUnosA.TabIndex = 27
        Me.btnUnosA.Text = "    Унос"
        Me.btnUnosA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnosA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUnosA.UseVisualStyleBackColor = False
        '
        'BtnAzurK
        '
        Me.BtnAzurK.BackColor = System.Drawing.Color.Transparent
        Me.BtnAzurK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAzurK.FlatAppearance.BorderSize = 0
        Me.BtnAzurK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnAzurK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAzurK.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAzurK.ForeColor = System.Drawing.Color.White
        Me.BtnAzurK.Image = CType(resources.GetObject("BtnAzurK.Image"), System.Drawing.Image)
        Me.BtnAzurK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAzurK.Location = New System.Drawing.Point(10, 43)
        Me.BtnAzurK.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnAzurK.Name = "BtnAzurK"
        Me.BtnAzurK.Size = New System.Drawing.Size(240, 38)
        Me.BtnAzurK.TabIndex = 28
        Me.BtnAzurK.Text = "    Ажурирање"
        Me.BtnAzurK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAzurK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAzurK.UseVisualStyleBackColor = False
        '
        'PanelCAPI
        '
        Me.PanelCAPI.BackColor = System.Drawing.Color.Transparent
        Me.PanelCAPI.Controls.Add(Me.btnCAPI)
        Me.PanelCAPI.Location = New System.Drawing.Point(0, 584)
        Me.PanelCAPI.Name = "PanelCAPI"
        Me.PanelCAPI.Size = New System.Drawing.Size(255, 57)
        Me.PanelCAPI.TabIndex = 155
        Me.PanelCAPI.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 729)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(255, 20)
        Me.Button1.TabIndex = 160
        Me.Button1.Tag = ""
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button7.TabIndex = 29
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
        Me.Button3.TabIndex = 10000074
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button3.UseVisualStyleBackColor = False
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
        'MainMenu11
        '
        Me.MainMenu11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemStartRecentList})
        Me.MenuItem1.Text = "&Апликације"
        '
        'MenuItemStartRecentList
        '
        Me.MenuItemStartRecentList.Index = 0
        Me.MenuItemStartRecentList.Text = "-"
        '
        'FormIstrazivanje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1152, 749)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormIstrazivanje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSinhronizacija.ResumeLayout(False)
        Me.panelSinhronizacija.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelContext.ResumeLayout(False)
        Me.panelFooter.ResumeLayout(False)
        Me.panelFooter.PerformLayout()
        Me.panelOstalo.ResumeLayout(False)
        Me.panelOstalo.PerformLayout()
        Me.panelIST.ResumeLayout(False)
        Me.panelIST.PerformLayout()
        CType(Me.dgvIST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelVT.ResumeLayout(False)
        Me.PanelBoje.ResumeLayout(False)
        Me.ctMenuStrip.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelCATI.ResumeLayout(False)
        Me.PanelKonsultacione.ResumeLayout(False)
        Me.PanelCAPI.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim m_zadaciVremenskaTacka As IstrazivanjaZadaci.IstrazivanjeVremenskaTacka
    Dim m_folderProgramaZaUnos As String
    Dim m_folderZaGen As String
    Dim m_IST As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeDEPOUser As String
    Dim DSBrisanjeDEPOPassword As String
    Dim CATIServer As String
    Dim CATIBaza As String
    Dim PublicDBServer As String
    Dim PublicDBBaza As String
    Dim CAPIServer As String
    Dim CAPIBaza As String
    Dim PXMETATable As String
    Dim PXMETAApp As String

    Dim Instalacija As String
    Dim txtpismo As String
    Dim txtmode As String
    Dim txtoffice As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String

    Dim panelmenucollapse As Boolean = False

    Dim m_zadaciIstrazivanje As IstrazivanjaZadaci.IstrazivanjeZadaci = Nothing

    <System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nheightRect As Integer, ByVal nweightRect As Integer) As IntPtr
    End Function

    'Disable maximize On Double click titlebar
    Public Const WM_NCLBUTTONDBLCLK As Integer = &HA3
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_NCLBUTTONDBLCLK Then Return
        'If m.Msg = WM_NCLBUTTONDOWN Then Return
        MyBase.WndProc(m)
    End Sub
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
    Public ReadOnly Property LB_CLK() As Button
        Get
            Return Me.m_zadaciVremenskaTacka.LB_CLK
        End Get
    End Property

    Public Overloads Sub Dispose()
        Me.m_zadaciVremenskaTacka.DDispose()
        MyBase.Dispose()
    End Sub

    Public lokalno As Boolean
    Public jezik As String
    Public mdtAWL As System.Data.DataTable
    Public mdtQE As System.Data.DataTable
    Public mdtLabel As System.Data.DataTable
    Public mdtMessage As System.Data.DataTable
    Dim appRegKeyL As Microsoft.Win32.RegistryKey
    Dim dtSpisakIST As New System.Data.DataTable
    Dim UserNameZCAPI As String = ""
    Dim UserNameCAPI As String = ""
    Dim postojiISTApp As Boolean
    Dim txtlogin As String = ""
    Dim kosamnew As String = ""
    Dim overlayHandleISTLoading As ISTFormIsLoading
    Dim dtZ As System.Data.DataTable = Nothing
    Public Sub New(
    ByVal istConnectionString As String,
    ByVal rowIstNonFilteredByVodVdo As DatasetIstrazivanja.ISTRow,
    ByVal datasetISTNonFilteredByVodVdo As DatasetIstrazivanja, ByVal datasetISTNonFilteredByVodVdoPX As DatasetIstrazivanja,
    ByVal folderZaProgrameZaUnos As String,
    ByVal appRegKey As Microsoft.Win32.RegistryKey,
    ByVal txtInstalacija As String, ByVal txtpismo As String, ByVal txtoffice As String,
    ByVal txtnonavailable As String, ByVal txtMode As String,
    ByVal DSBrisanjeDEPO As String,
    ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String, ByVal folderZaGen As String,
    ByVal CATIServer As String, ByVal CATIBaza As String,
    ByVal CAPIServer As String, ByVal CAPIBaza As String, ByVal PublicDBServer As String, ByVal PublicDBBaza As String,
    ByVal txtdefaultLanguage As String, ByVal PXMETAApp As String, ByVal PXMETATable As String, ByVal postojiISTApp As Boolean, Optional ByVal dtZ As System.Data.DataTable = Nothing,
    Optional ByVal txtlogin As String = "", Optional ByVal kosamnew As String = "", Optional overlayHandleISTLoading As ISTFormIsLoading = Nothing)

        Me.New()
        Call BestPerformance()
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.overlayHandleISTLoading = overlayHandleISTLoading
        overlayHandleISTLoading.Show()
        Call showTaskbar()
        'Call installBarCodeFont(txtMode.Trim.ToUpper)
        Me.postojiISTApp = postojiISTApp
        Me.Text = Me.Text + " : " + txtInstalacija + " - " + rowIstNonFilteredByVodVdo.Naziv
        If txtMode.Trim.ToUpper.IndexOf("CLOUD") >= 0 Then Call MapirajAzureDrive()
        Me.dtZ = dtZ
        Me.kosamnew = kosamnew
        Me.txtlogin = txtlogin
        Me.DSBrisanjeDEPO = DSBrisanjeDEPO
        Me.DSBrisanjeServer = DSBrisanjeServer
        Me.DSBrisanjeBaza = DSBrisanjeBaza
        Me.CATIServer = CATIServer
        Me.CATIBaza = CATIBaza
        Me.CAPIServer = CAPIServer
        Me.CAPIBaza = CAPIBaza
        Me.PublicDBServer = PublicDBServer
        Me.PublicDBBaza = PublicDBBaza
        Me.PXMETAApp = PXMETAApp
        Me.PXMETATable = PXMETATable
        Me.appRegKeyL = appRegKey
        lokalno = False
        'NS je trazio da za njih se ne radi DEPO pri brisanju
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

        Me.ISTConnectionString = istConnectionString
        Me.DBConnectionString = ""

        Me.m_folderZaGen = folderZaGen
        Me.m_folderProgramaZaUnos = folderZaProgrameZaUnos
        Me.Instalacija = txtInstalacija

        Dim lastModified As DateTime = IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location)
        Me.MILastVersionDate.Text = "version: " + lastModified.ToString("dd.MM.yyyy HH:mm:ss")

        Me.txtmode = txtMode
        Me.catiprefix = "dbo."
        Me.jezik = txtdefaultLanguage
        'Me.Logovan.Text = GetUserName.ToString.Trim
        Me.Logovan.Text = kosamnew.ToString.Trim


        If txtdefaultLanguage = "EN" Then Me.jezik = "EN" : Call SetLang()
        If txtdefaultLanguage = "SRC" Then Me.jezik = "SRC" : Call SetLang()
        If txtdefaultLanguage = "SRL" Then Me.jezik = "SRL" : Call SetLang()
        If txtdefaultLanguage = "SHQ" Then Me.jezik = "SHQ" : Call SetLang()
        If txtdefaultLanguage = "MNE" Then Me.jezik = "MNE" : Call SetLang()
        If txtdefaultLanguage = "MKD" Then Me.jezik = "MKD" : Call SetLang()
        If txtdefaultLanguage = "ITA" Then Me.jezik = "ITA" : Call SetLang()
        If txtdefaultLanguage = "BG" Then Me.jezik = "BG" : Call SetLang()
        If txtdefaultLanguage = "RUS" Then Me.jezik = "RUS" : Call SetLang()
        If txtdefaultLanguage = "VN" Then Me.jezik = "VN" : Call SetLang()
        If txtdefaultLanguage = "UZ" Then Me.jezik = "UZ" : Call SetLang()
        If txtdefaultLanguage = "GER" Then Me.jezik = "GER" ': Call SetLang()
        If txtdefaultLanguage = "TUR" Then Me.jezik = "TUR" ': Call SetLang()

        Me.txtoffice = txtoffice
        Me.txtpismo = txtpismo

        Call office()

        'If txtnonavailable <> "" Then Call available(txtnonavailable)

        If Me.txtmode.Trim.ToUpper.IndexOf("CLOUD") = 0 Then
            Call catiMode()
            Me.catiprefix = "cati."
        End If

        If Me.txtmode.Trim.ToUpper.IndexOf("CLOUDDESKTOP") = 0 Then
            Call cloudDesktopMode()
            Me.catiprefix = "cati."
        End If

        If txtMode.Trim.ToUpper = "CATI" Then
            Call catiMode()
            Me.btnCATI.Visible = False
        End If

        If txtMode.Trim.ToUpper = "CAPI" OrElse txtMode.Trim.ToUpper = "TESTCAPI" OrElse txtMode.Trim.ToUpper = "CAPITEST" OrElse txtMode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then
            Me.mMode.Visible = False
        End If

        If txtMode.Trim.ToUpper = "ZCAPI" OrElse txtMode.Trim.ToUpper = "Z" Then
            Call ZCAPIdata()
            'Me.mMode.Visible = False
            Me.MILanguage.Visible = False
        End If

        ButtonUnos.Enabled = True

        Call popunidtSpisakIST()

        If lblSifra.Text = "." Then
            Dim sifapp As String = getFirstFromRegistry()
            lblNaziv.Text = selCLBIST(sifapp)
            lblSifra.Text = sifapp.Trim
            Me.dgvIST.Visible = False
            Me.dgvIST.DataSource = dtSpisakIST
            Me.panelIST.RowStyles(1).SizeType = SizeType.Percent
            Me.panelIST.RowStyles(1).Height = 0
            Me.panelIST.RowStyles(3).SizeType = SizeType.Absolute
            Me.panelIST.RowStyles(3).Height = 70
            Me.panelIST.RowStyles(5).SizeType = SizeType.Absolute
            Me.panelIST.RowStyles(5).Height = 85

            Call checkAvailable(lblSifra.Text)

        End If
        If txtMode.Trim.ToUpper = "Z" OrElse txtMode.Trim.ToUpper = "ZCAPI" Then
            panelFooter.Visible = False
        Else
            panelFooter.Visible = True
        End If

        Call newnew(istConnectionString, rowIstNonFilteredByVodVdo, datasetISTNonFilteredByVodVdo, datasetISTNonFilteredByVodVdoPX,
        folderZaProgrameZaUnos, appRegKey, txtInstalacija, txtpismo, txtoffice, txtnonavailable, txtMode, DSBrisanjeDEPO,
        DSBrisanjeServer, DSBrisanjeBaza, folderZaGen, CATIServer, CATIBaza, CAPIServer, CAPIBaza, PublicDBServer, PublicDBBaza,
        txtdefaultLanguage, PXMETAApp, PXMETATable, "New")

        If txtlogin = "TRUE" AndAlso Not dtZ Is Nothing AndAlso dtZ.Rows.Count = 1 Then
            UserControlVremenskaTacka1.dtp.MinDate = dtZ.Rows(0).Item("vod")
            UserControlVremenskaTacka1.dtp.MaxDate = dtZ.Rows(0).Item("vdo")
        End If
        If txtlogin = "TRUE" Then
            UserControlVremenskaTacka1.Label1.Visible = False
            UserControlVremenskaTacka1.tbMes59.Visible = False
        End If

        Call fISTgetAwlQELabelsMeassages()

        Call getLastSurveys()

        ctMenuStrip.Renderer = New MyRenderer()
        ctMenuStrip.ForeColor = Color.White

        For Each item As ToolStripMenuItem In ctMenuStrip.Items
            'item.ForeColor = Color.White
            For Each subitem As ToolStripMenuItem In item.DropDownItems
                subitem.ForeColor = Color.White
                'AddHandler subitem.MouseLeave, AddressOf SubItem_MouseLeave
            Next
        Next
        zapamtilogovanog = Logovan.Text.Trim
        Call CAPICensus()
        Me.overlayHandleISTLoading.Close()
        otvorenSubMenu = False
    End Sub
    Sub popunidtSpisakIST()

        If txtlogin = "TRUE" AndAlso Not dtZ Is Nothing Then
            Me.dgvIST.DataSource = dtZ
            dtSpisakIST = dtZ
            If dtZ.Rows.Count = 1 Then
                UserControlVremenskaTacka1.dtp.MinDate = dtZ.Rows(0).Item("vod")
                UserControlVremenskaTacka1.dtp.MaxDate = dtZ.Rows(0).Item("vdo")
            End If
            If Not dgvIST Is Nothing AndAlso dgvIST.Columns.Count > 0 Then
                For i As Integer = 0 To dgvIST.Columns.Count - 1
                    If dgvIST.Columns(i).Name.ToString.ToUpper <> "SIFIST" AndAlso dgvIST.Columns(i).Name.ToString.ToUpper <> "NAZIV" AndAlso dgvIST.Columns(i).Name.ToString.ToUpper <> "SIFISTNAZIV" Then
                        dgvIST.Columns(i).Visible = False
                    End If
                Next
            End If
        ElseIf txtlogin = "TRUE" AndAlso dtZ Is Nothing Then
            '602
            Dim por As String = getMessageText(dtMessages, "602", Me.jezik)
            ISTMessageBox.Show(por)
        Else
            Dim sql As String = "  select distinct ist.Sifist as sifist ,  naziv as Naziv,ist.sifist+' - '+naziv as sifistnaziv from (select sifist,min(vod) as vod from ist group by sifist ) i inner join ist on i.sifist=ist.sifist and i.vod=ist.vod where year(ist.vod)<2100 order by ist.sifist"
            dtSpisakIST = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)
            Me.dgvIST.DataSource = dtSpisakIST
        End If

    End Sub

    Dim zapamtilogovanog As String = ""
    Sub checkAvailable(ByVal app As String)
        Dim sqlNonAvailable As String = "select ProgUnos from ist where sifist=N'" + app + "'"
        Dim dtNonAvailable As System.Data.DataTable = izvrsiSQLvratiDT(sqlNonAvailable, ISTConnectionString, jezik)
        Dim txtnonavailable As String = ""
        If Not dtNonAvailable Is Nothing AndAlso dtNonAvailable.Rows.Count > 0 Then
            Dim nonavailable As String() = dtNonAvailable.Rows(0).Item(0).ToString.ToUpper.Trim.Split("$")
            For i As Integer = 0 To nonavailable.GetUpperBound(0)
                If nonavailable(i).ToUpper.Trim.IndexOf("NONAVAILABLE=") = 0 Then
                    txtnonavailable = nonavailable(i).ToUpper.Trim.Replace("NONAVAILABLE=", "").Replace("(", "").Replace(")", "")
                    Exit For
                End If
            Next
        End If
        If txtnonavailable <> "" Then
            Call available(txtnonavailable, app)
        Else
            availableReset(app)
        End If

    End Sub
    Sub available(ByVal txtnonavailable As String, ByVal app As String)
        Call availableReset(app)
        Dim t As String() = txtnonavailable.Split(";")
        Dim konU As Boolean = True
        Dim konA As Boolean = True
        For ii As Integer = 0 To t.GetUpperBound(0)
            Select Case t(ii)
                Case "1"
                    Me.ButtonUnos.Visible = False
                Case "2"
                    Me.ButtonLogickaKontrola.Visible = False
                    ButtonAK.Location = ButtonLogickaKontrola.Location
                Case "3"
                    Me.ButtonAK.Visible = False
                    ButtonAzuriranje.Location = ButtonAK.Location
                Case "4"
                    Me.ButtonAzuriranje.Visible = False
                    ButtonIzvestaji.Location = ButtonAzuriranje.Location
                Case "5"
                    Me.ButtonIzvestaji.Visible = False
                    BtnAdvancedSearch.Location = ButtonIzvestaji.Location
                Case "6"
                    Me.BtnAdvancedSearch.Visible = False
                    btnCATI.Location = BtnAdvancedSearch.Location
                Case "7"
                    Me.btnCATI.Visible = False
                    btnUnosA.Location = btnCATI.Location
                Case "61"
                    Me.bAdvancedTableUpdate.Visible = False
                Case "8"
                    Me.btnUnosA.Visible = False
                    konU = False
                    BtnAzurK.Location = btnUnosA.Location
                Case "9"
                    Me.BtnAzurK.Visible = False
                    konA = False
                Case "10"
                                    'Case "11"
                '    Me.ButtonValidniIntervali.Visible = False
                'Case "12"
                '    Me.ButtonBrojSlogova.Visible = False
                'Case "13"
                '    Me.ButtonPoslednjiDatumSaPodacima.Visible = False
                'Case "14"
                '    Me.buttonOcena.Visible = False
                'Case "15"
                '    Me.buttonLogLK.Visible = False
                'Case "16"
                '    Me.llIST1.Visible = False
                Case "101"
                    Me.MIAplikacija.Visible = False
                    MIAplikacija.Height = 1
                Case "102"
                    Me.MIAdministracija.Visible = False
                    MIAdministracija.Height = 1
                Case "103"
                    Me.MIUputstva.Visible = False
                    MIUputstva.Height = 1
                Case "104"
                    Me.MILanguage.Visible = False
                    MILanguage.Height = 1
                Case "105"
                    Me.mMode.Visible = False
                Case "207"
                    'Me.bISTDesigner.Visible = False
                Case "300"
                    'ovo se vidi samo kad je txtmode CAPI,CAPITEST,TESTCAPI
                    'Me.panelSinhronizacija.Visible = False
                Case "301" 'osnovni meni - unos, lk, izvestaji ' izbor aplikacije NE BI TREBALO DA SE ISKLJUCI
                Case "303" ' izbor aplikacije NE BI TREBALO DA SE ISKLJUCI
                Case "304" 'vremenska tacka
                Case "305" ' validni intervali...
                    Me.panelOstalo.Visible = False
                    Me.panelFooter.Visible = False
                Case "400"
                    btnLinija1.Width = 0
                Case "401"
                    btnLinija2.Width = 0
            End Select
        Next
    End Sub
    Private Sub availableReset(ByVal app As String)

        Me.panelSinhronizacija.Visible = False
        Me.bAdvancedTableUpdate.Visible = False

        Me.panelOstalo.Visible = True
        Me.panelFooter.Visible = True

        Me.ButtonUnos.Visible = True
        Me.ButtonLogickaKontrola.Visible = True
        Me.ButtonAzuriranje.Location = New System.Drawing.Point(10, 115)
        Me.ButtonAzuriranje.Visible = True
        Me.ButtonAK.Location = New System.Drawing.Point(10, 78)
        Me.ButtonAK.Visible = True
        Me.ButtonIzvestaji.Location = New System.Drawing.Point(10, 152)
        Me.ButtonIzvestaji.Visible = True
        Me.BtnAdvancedSearch.Location = New System.Drawing.Point(10, 189)
        Me.BtnAdvancedSearch.Visible = True
        Me.btnCATI.Location = New System.Drawing.Point(10, 6)
        Me.btnCATI.Visible = True
        Me.btnUnosA.Location = New System.Drawing.Point(10, 6)
        Me.btnUnosA.Visible = True
        Me.BtnAzurK.Location = New System.Drawing.Point(10, 43)
        Me.BtnAzurK.Visible = True
        Me.MIAplikacija.Visible = True
        Me.MIAplikacija.Size = New System.Drawing.Size(188, 30)
        Me.MIAdministracija.Visible = True
        Me.MIAdministracija.Size = New System.Drawing.Size(188, 30)
        Me.MIUputstva.Visible = True
        Me.MIUputstva.Size = New System.Drawing.Size(188, 30)
        Me.MILanguage.Visible = True
        Me.MILanguage.Size = New System.Drawing.Size(188, 30)
        Me.mMode.Visible = True

        Me.btnLinija1.Size = New System.Drawing.Size(255, 17)
        Me.btnLinija2.Size = New System.Drawing.Size(255, 17)

        'Me.MRefresh.Visible = True
        Me.btnFTRazmak5.Visible = True

        If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
            Call capiMode(app)
        End If
    End Sub
    '**************************************************
    '**************************************************
    '**************************************************
    '**************************************************
    Function selCLBIST(ByVal sifapp As String) As String

        selCLBIST = "."
        For i As Integer = 0 To dtSpisakIST.Rows.Count - 1
            If dtSpisakIST.Rows(i).Item("sifist").ToString.Trim.ToUpper = sifapp.Trim.ToUpper Then
                dgvIST.ClearSelection()
                dgvIST.Rows(i).Selected = True
                selCLBIST = dtSpisakIST.Rows(i).Item("Naziv")
                Exit For
            End If
        Next

    End Function
    Sub dgvISTVisibleTrue()
        Me.panelIST.RowStyles(1).SizeType = SizeType.Absolute
        Me.panelIST.RowStyles(1).Height = 600
        Me.panelIST.RowStyles(3).SizeType = SizeType.Percent
        Me.panelIST.RowStyles(3).Height = 0
        Me.panelIST.RowStyles(5).SizeType = SizeType.Percent
        Me.panelIST.RowStyles(5).Height = 0
    End Sub
    Sub dgvISTVisibleFalse()
        Me.panelIST.RowStyles(1).SizeType = SizeType.Percent
        Me.panelIST.RowStyles(1).Height = 0
        Me.panelIST.RowStyles(3).SizeType = SizeType.Absolute
        Me.panelIST.RowStyles(3).Height = 70
        Me.panelIST.RowStyles(5).SizeType = SizeType.Absolute
        Me.panelIST.RowStyles(5).Height = 85
    End Sub
    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Me.dgvIST.Visible = Not Me.dgvIST.Visible
        If dgvIST.Visible = False Then
            dgvIST.DataSource = dtSpisakIST
            Call dgvISTVisibleFalse()
        Else
            If Me.lblSifra.Text.Trim <> "." Then Call selCLBIST(Me.lblSifra.Text.Trim)
            Call dgvISTVisibleTrue()
        End If
        If txtmode.Trim.ToUpper = "Z" OrElse txtmode.Trim.ToUpper = "ZCAPI" Then
            panelFooter.Visible = False
        Else
            panelFooter.Visible = True
        End If
        Me.txtIST.Focus()
    End Sub

    Private Sub txtIST_TextChanged(sender As Object, e As EventArgs) Handles txtIST.TextChanged
        Call osveziIzborIstrazivanja(txtIST.Text)
    End Sub
    Sub osveziIzborIstrazivanja(ByVal vred As String, Optional ByVal ponovo As Boolean = False)
        Me.dgvIST.Visible = True
        Call dgvISTVisibleTrue()
        Dim dv As New System.Data.DataView
        If ponovo = True Then
            dgvIST.DataSource = dtSpisakIST
        End If
        dv = dgvIST.DataSource.defaultview
        If IsNumeric(vred) = False Then
            Dim vredCir As String = konverzijaLatCir(vred)
            Dim vredLat As String = konverzijaCirLat(vred)
            dv.RowFilter = "sifistnaziv LIKE '%" & vredCir & "%' OR sifistnaziv LIKE '%" & vredLat & "%'"
        Else
            dv.RowFilter = "sifistnaziv Like '%" & vred & "%'"
        End If
        dgvIST.DataSource = dv.ToTable
        dgvIST.Height = dv.Count * 30
        If Me.dgvIST.Height > Me.Height \ 4 Then Me.dgvIST.Height = Me.Height \ 4
    End Sub
    Private Sub txtIST_PreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtIST.PreviewKeyDown
        If e.KeyData = Keys.Back Then
            e.IsInputKey = True
        End If
    End Sub
    Public Sub txtIST_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIST.KeyPress
        If e.KeyChar = ControlChars.Back Then
            If txtIST.Text.Length > 0 Then
                Call osveziIzborIstrazivanja(txtIST.Text.Substring(0, txtIST.Text.Length - 1), True)
            End If
        End If
    End Sub

    Private Sub dgvIST_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgvIST.CellClick
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            dgvIST.ClearSelection()
            dgvIST.Rows(e.RowIndex).Selected = True
            Dim app As String = dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("sifist").Index).Value.ToString
            If txtlogin = "TRUE" Then
                UserControlVremenskaTacka1.dtp.MinDate = dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("vod").Index).Value
                UserControlVremenskaTacka1.dtp.MaxDate = dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("vdo").Index).Value
            End If
            Me.postojiISTApp = True
            Call getIST(app)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub dgvIST_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvIST.RowHeaderMouseDoubleClick
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If e.RowIndex >= 0 Then
            dgvIST.ClearSelection()
            dgvIST.Rows(e.RowIndex).Selected = True
            Dim app As String = dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("sifist").Index).Value.ToString
            If txtlogin = "TRUE" Then
                UserControlVremenskaTacka1.dtp.MinDate = dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("vod").Index).Value
                UserControlVremenskaTacka1.dtp.MaxDate = dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("vdo").Index).Value
            End If
            Me.postojiISTApp = True
            Call getIST(app)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub buttonIST_Click(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Dim app As String = sender.text
        Try
            Me.postojiISTApp = proveraISTpostoji(app)
            Call getIST(app)
            Call checkAvailable(app)
        Catch ex As System.Exception
            DeleteReg(app)
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Me.Cursor = Cursors.Default
    End Sub

    Function proveraISTpostoji(ByVal app As String) As Boolean
        Dim sqlIST = "select * from IST where sifIST=N'" + app.Trim + "';"
        Dim postoji As Boolean = True
        Try
            Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sqlIST, ISTConnectionString, Nothing)
            If dt.Rows.Count = 0 Then
                postoji = False
            End If
        Catch ex As System.Exception
            postoji = False
        End Try
        Return postoji
    End Function
    Sub getIST(ByVal app As String)
        Call selectedIST(app)
        If MrefreshClick() = True Then
            Call DesktopMode()
            Call CAPICensus()
            Call UpdateReg(app)
            Call getLastSurveys()
        End If
    End Sub

    Sub selectedIST(ByVal sifapp As String)
        Dim dt As New System.Data.DataTable
        dt = dtSpisakIST.Copy
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("sifist").ToString.Trim.ToUpper = sifapp.Trim.ToUpper Then
                lblNaziv.Text = dt.Rows(i).Item("naziv").ToString.Trim
                lblSifra.Text = sifapp.Trim
                txtIST.Text = ""
                Me.dgvIST.Visible = False
                Me.dgvIST.DataSource = dtSpisakIST
                Call dgvISTVisibleFalse()
                Exit For
            End If
        Next i
        Call checkAvailable(sifapp)
    End Sub


    Dim nizButton() As Button = {}
    Dim inizButton As Integer = -1
    Sub getLastSurveys()
        Dim rr As RegistryKey
        rr = Registry.CurrentUser
        Dim registrySubKey As RegistryKey
        registrySubKey = rr.OpenSubKey("SOFTWARE\VB and VBA Program Settings\Istrazivanja\Izbor")

        Dim valueNames As String() = registrySubKey.GetValueNames()
        Dim valuedata As String = ""
        Dim valueName As String
        For Each valueName In valueNames
            valuedata = valuedata + registrySubKey.GetValue(valueName) + ";" ' valueName is the name of one of the Values belonging to the Registry Key
        Next
        valuedata = valuedata.TrimEnd(";")

        Dim lista() As String = valuedata.Split(";")
        Dim xx As Integer = 25

        For i As Integer = panelLast5.Controls.Count - 1 To 0 Step -1
            Dim c As Control = panelLast5.Controls(i)
            Me.panelLast5.Controls.Remove(c)
            RemoveHandler c.Click, AddressOf buttonIST_Click
            c.Dispose()
        Next
        nizButton = {}
        inizButton = -1

        Dim sirina As Integer = (txtIST.Width - 105) / 6

        If txtlogin <> "TRUE" Then
            For i As Integer = 0 To lista.GetUpperBound(0)
                Dim buttonIST As New Button
                buttonIST.Name = "buttonIST" + CStr(i).Trim
                buttonIST.Tag = "buttonIST"
                buttonIST.FlatAppearance.BorderSize = 0
                buttonIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
                buttonIST.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
                buttonIST.ForeColor = Color.White

                buttonIST.BackColor = ISTTheme.nizButtons
                buttonIST.FlatAppearance.MouseDownBackColor = ISTTheme.PanelParent
                buttonIST.FlatAppearance.MouseOverBackColor = ISTTheme.PanelParent

                buttonIST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
                buttonIST.Cursor = Cursors.Hand
                buttonIST.Location = New System.Drawing.Point(xx, 7)
                buttonIST.Margin = New System.Windows.Forms.Padding(0)
                buttonIST.Size = New System.Drawing.Size(sirina, 30)
                buttonIST.TabIndex = 10000072
                buttonIST.TabStop = False
                buttonIST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                buttonIST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
                buttonIST.UseVisualStyleBackColor = True
                buttonIST.Text = lista(i)
                Me.panelLast5.Controls.Add(buttonIST)
                xx = xx + buttonIST.Width + 15
                AddHandler buttonIST.Click, AddressOf buttonIST_Click
                inizButton = inizButton + 1
                ReDim Preserve nizButton(i)
                nizButton(i) = buttonIST
                buttonIST.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonIST.Width, buttonIST.Height, 5, 5))
            Next
        End If

        Dim pozicijaX As Integer = txtIST.Location.X + (txtIST.Width + btnChoose.Width) / 2 - Me.UserControlVremenskaTacka1.Width / 2
        Me.UserControlVremenskaTacka1.Location = New System.Drawing.Point(pozicijaX, UserControlVremenskaTacka1.Location.Y)
    End Sub

    Function getFirstFromRegistry() As String
        getFirstFromRegistry = ""
        Dim rr As RegistryKey
        rr = Registry.CurrentUser
        Dim registrySubKey As RegistryKey
        registrySubKey = rr.OpenSubKey("SOFTWARE\VB and VBA Program Settings\Istrazivanja\Izbor")

        Try
            Dim valueNames As String() = registrySubKey.GetValueNames()
            Dim valuedata As String = ""
            Dim valueName As String
            For Each valueName In valueNames
                valuedata = valuedata + registrySubKey.GetValue(valueName) + ";" ' valueName is the name of one of the Values belonging to the Registry Key
            Next
            valuedata = valuedata.TrimEnd(";")

            Dim lista() As String = valuedata.Split(";")
            getFirstFromRegistry = lista(0)
        Catch ex As System.Exception
            getFirstFromRegistry = ""
        End Try

    End Function

    '**************************************************
    '**************************************************
    '**************************************************
    '**************************************************
    Sub catiMode()

        Me.PanelDesktop.Visible = False
        Me.PanelCATI.Visible = True
        Me.PanelCAPI.Visible = False
        Me.PanelKonsultacione.Visible = False
        Me.panelOstalo.Visible = False
        Me.panelFooter.Visible = False
        Me.panelSinhronizacija.Visible = False
        MIAplikacija.Enabled = False
        MIAdministracija.Enabled = False
        'Me.Text = "IST " + txtmode.Trim.ToUpper + " mode"
    End Sub
    Sub DesktopMode()

        Me.Cursor = Cursors.WaitCursor
        Me.PanelDesktop.Visible = True
        Me.PanelCATI.Visible = True
        Me.PanelKonsultacione.Visible = True
        Dim bspace As String = "      "
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formIstrazivanje")

        btnUnosA.Text = bspace + getControlText2(dt, "btnUnosA", Me.jezik)
        BtnAzurK.Visible = True
        lblSifra.Visible = True
        panelIST.Visible = True

        Me.panelOstalo.Visible = True
        Me.panelFooter.Visible = True
        Me.PanelCAPI.Visible = False
        Me.panelSinhronizacija.Visible = False

        Me.Cursor = Cursors.Default
    End Sub
    Sub capiMode(ByVal appcode As String)
        Dim bspace As String = "      "
        Me.Cursor = Cursors.WaitCursor

        Me.PanelDesktop.Visible = False
        Me.PanelCATI.Visible = False
        Me.PanelCAPI.Top = Me.PanelDesktop.Top
        Me.PanelCAPI.Visible = True

        Me.PanelKonsultacione.Visible = True
        Me.panelOstalo.Visible = False
        Me.panelFooter.Visible = False
        Me.panelSinhronizacija.Visible = True

        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formIstrazivanje")
        If Me.lblSifra.Text.Trim.ToUpper = "POPIS_21" OrElse Me.lblSifra.Text.Trim.ToUpper = "PES_21" OrElse Me.lblSifra.Text.Trim.ToUpper = "POPTEST" OrElse Me.lblSifra.Text.Trim.ToUpper = "xPPOLJO" OrElse Me.lblSifra.Text.Trim.ToUpper = "PPES_24" OrElse Me.lblSifra.Text.Trim.ToUpper = "PPES24OK" Then
            BtnAzurK.Visible = False
            lblSifra.Visible = False
            panelIST.Visible = False
            btnUnosA.Text = bspace + getControlText2(dt, "lblEval", Me.jezik)
        Else
            btnUnosA.Text = bspace + getControlText2(dt, "btnUnosA", Me.jezik)
            BtnAzurK.Visible = True
            lblSifra.Visible = True
            panelIST.Visible = True
            If Me.lblSifra.Text.Trim.ToUpper = "PPOLJO23" OrElse Me.lblSifra.Text.Trim.ToUpper = "PPES24OK" Then
                btnCAPI.Text = "      Kontrola"
                Me.panelOstalo.Visible = False
                Me.panelFooter.Visible = False
                Me.panelSinhronizacija.Visible = False
                btnLinija1.Visible = False
                BtnAzurK.Visible = False
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        If Me.lblSifra.Text.Trim.ToUpper = "PPES_24" Then
            btnUnosA.Visible = False
            btnLinija1.Visible = False
            btnLinija2.Visible = False
            btnMenu2.Visible = False
        End If

        Call SuspendDrawing(panelSinhronizacija)
        Me.panelSinhronizacija.Visible = True
        'Me.panelSinhronizacija.Top = Me.panelOstalo.Top
        Call ResumeDrawing(panelSinhronizacija)
        Me.Cursor = Cursors.Default

    End Sub
    Sub cloudDesktopMode()
        Me.PanelDesktop.Visible = False
        Me.PanelCATI.Visible = False
        Me.PanelCAPI.Visible = False
        Me.PanelKonsultacione.Visible = False
        Me.panelOstalo.Visible = False
        Me.panelFooter.Visible = False
        Me.panelSinhronizacija.Visible = False

        MIAplikacija.Enabled = False
        MIAdministracija.Enabled = False
        Me.Text = "IST " + txtmode.Trim.ToUpper + " mode"
        'Me.bbIstCards3.Text = "IST " + txtmode.Trim.ToUpper + " mode"

        ButtonLogickaKontrola.Visible = False
        ButtonAK.Visible = False
        ButtonIzvestaji.Visible = False
        BtnAdvancedSearch.Visible = False
        ButtonAzuriranje.Visible = False
        'bQueryDesigner.Visible = False
        Me.btnFTRazmak5.Visible = False

        MIAplikacija.Visible = False
        MIAdministracija.Visible = False

        Me.LogovanAnketarCloud.Visible = False
        Me.Logovan.Visible = False

        'Me.MRefresh.Visible = False
        Me.MIUputstva.Visible = False
    End Sub
    Private Sub mCAPI_Click(sender As Object, e As EventArgs) Handles mCAPI.Click
        Call CAPICensus()
    End Sub

    Private Sub mCATI_Click(sender As Object, e As EventArgs)
        'Me.txtmode = "CAPITEST"
        Call catiMode()
    End Sub
    Private Sub mDesktop_Click(sender As Object, e As EventArgs) Handles mDesktop.Click
        'Me.txtmode = "DESKTOP"
        Call DesktopMode()
    End Sub

    Sub newnew(ByVal istConnectionString As String,
    ByVal rowIstNonFilteredByVodVdo As DatasetIstrazivanja.ISTRow,
    ByVal datasetISTNonFilteredByVodVdo As DatasetIstrazivanja, ByVal datasetISTNonFilteredByVodVdoPX As DatasetIstrazivanja,
    ByVal folderZaProgrameZaUnos As String,
    ByVal appRegKey As Microsoft.Win32.RegistryKey,
    ByVal txtInstalacija As String, ByVal txtpismo As String, ByVal txtoffice As String,
    ByVal txtnonavailable As String, ByVal txtMode As String,
    ByVal DSBrisanjeDEPO As String,
    ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String, ByVal folderZaGen As String,
    ByVal CATIServer As String, ByVal CATIBaza As String,
    ByVal CAPIServer As String, ByVal CAPIBaza As String, ByVal PublicDBServer As String, ByVal PublicDBBaza As String,
    ByVal txtdefaultLanguage As String, ByVal PXMETAApp As String, ByVal PXMETATable As String, ByVal odakle As String)

        If txtMode.Trim.ToUpper = "CAPI" OrElse txtMode.Trim.ToUpper = "TESTCAPI" OrElse txtMode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
            'preuzmi god, mes, sifIST i istuser iz CAPIdata
            Call CAPIdata()
            Me.m_zadaciVremenskaTacka = New IstrazivanjaZadaci.IstrazivanjeVremenskaTacka(Me, Me.rist, istConnectionString, dsIST, Nothing, Me.UserControlVremenskaTacka1,
                                                                                        Me.lblSifra, Me.lblNaziv, Nothing, Nothing, Nothing,
                                                                                        Me.txtpismo, Me.txtmode, Me.jezik, PXMETAApp, odakle)
            Me.UserControlVremenskaTacka1.Enabled = False
            Me.ButtonPromenaIstrazivanja.Visible = False
            panelIST.Enabled = False
        Else
            If txtMode.Trim.ToUpper = "ZCAPI" Then
                Call ZCAPIdata()
                'Me.UserControlVremenskaTacka1.Enabled = False
                'Me.ButtonPromenaIstrazivanja.Visible = False
                'panelIST.Enabled = False
            End If
            Me.m_zadaciVremenskaTacka = New IstrazivanjaZadaci.IstrazivanjeVremenskaTacka(Me, rowIstNonFilteredByVodVdo, istConnectionString,
                                                                                        datasetISTNonFilteredByVodVdo, datasetISTNonFilteredByVodVdoPX, Me.UserControlVremenskaTacka1,
                                                                                        Me.lblSifra, Me.lblNaziv, Me.ButtonPromenaIstrazivanja, Nothing, appRegKey,
                                                                                        Me.txtpismo, Me.txtmode, Me.jezik, PXMETAApp, odakle)
        End If

    End Sub

    Public Shared Sub MapirajAzureDrive()
        Dim p As New Process()
        ' Redirect the output stream of the child process.
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C net use S: \\istfileshareaccount.file.core.windows.net\istfileshare /u:AZURE\istfileshareaccount H8q+CSPlIu0nbMbRZWcDHfJanTAVjIiyn0Lr5MRL2IdvC/fmqg8GbyIryCBQHeTGjX4tOz9bMcN+5PcpSSnCLw== /persistent:no"
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.Verb = "runas"
        Try
            p.Start()
            p.WaitForExit()
        Catch ex As System.Exception
        End Try
    End Sub
    Public Shared Sub UnMapirajAzureDrive()

        Dim p As New Process()
        ' Redirect the output stream of the child process.
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C net use S: /delete"
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.Verb = "runas"
        Try
            p.Start()
            p.WaitForExit()
        Catch ex As System.Exception
        End Try
    End Sub


    Private dsIST As New DatasetIstrazivanja
    Private rist As DatasetIstrazivanja.ISTRow

    Function dajDEPOPVT() As String

        'SAMO PK
        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.connPravaBaza)
        Dim sql As String = "select ISTYEAR as god,ISTMONTH as mes from ISTPKYEARMONTH where sifIST='" + Me.lblSifra.Text + "' order by ISTYEAR desc, ISTMONTH desc"
        Dim dt As New Data.DataTable
        dt = izvrsiSQLvratiDT(sql, konDepo, "")
        Dim gg As String = ""
        Dim mm As String = ""
        If dt.Rows.Count > 0 Then
            gg = dt.Rows(0).Item("GOD").ToString.Trim
            mm = dt.Rows(0).Item("MES").ToString.Trim
            Dim dmd As String = mm
            If mm = "00" Then dmd = "12"
            Me.UserControlVremenskaTacka1.MyInit("Vod", "Vdo", Date.MinValue, Date.MaxValue, New Date(gg, dmd, 2))
        End If

        Dim sqlm As String = "select ISTYEAR as god,ISTMONTH as mes from ISTPKYEARMONTH where sifIST='" + Me.lblSifra.Text + "' order by ISTYEAR asc, ISTMONTH asc"
        Dim dtm As New Data.DataTable
        dtm = izvrsiSQLvratiDT(sqlm, konDepo, "")
        Dim ggm As String = ""
        Dim mmm As String = ""
        If dtm.Rows.Count > 0 Then
            ggm = dtm.Rows(0).Item("GOD").ToString.Trim
            mmm = dtm.Rows(0).Item("MES").ToString.Trim
        End If

        If mm = "00" Then
            dajDEPOPVT = ggm & "    -   " & gg
        Else
            dajDEPOPVT = mmm & "." & ggm + "    -   " & mm & "." + gg
        End If

    End Function

    Dim dtJson As Data.DataTable
    Sub ZCAPIdata()
        Dim dreg As Microsoft.Win32.RegistryKey
        Dim subKeyDatum As String = "IzabranDatum"
        If Not appRegKeyL Is Nothing Then
            dreg = appRegKeyL.OpenSubKey(subKeyDatum, True)
            'provera za vrtacku!!!
            Dim logovan As String = dreg.GetValue("ISTUser", "")
            If logovan Is Nothing OrElse logovan.Trim = "" Then
                logovan = GetUserName.ToString.Trim
            End If
            Me.Logovan.Text = logovan.ToString.Trim
            UserNameZCAPI = logovan
            dreg.Flush()
        End If
    End Sub
    'Sub proveraCAPIdata()
    '    'preuzima se sifIST, god,mes,user

    '    Dim dreg As Microsoft.Win32.RegistryKey
    '    Dim subKeyDatum As String = "IzabranDatum"
    '    If Not appRegKeyL Is Nothing Then
    '        dreg = appRegKeyL.OpenSubKey(subKeyDatum, True)
    '        'provera za vrtacku!!!
    '        Dim gg As String = dreg.GetValue("ISTYear", Nothing)
    '        Dim mm As String = dreg.GetValue("ISTMonth", Nothing)
    '        Dim logovan As String = dreg.GetValue("ISTUser", Nothing)
    '        Dim app As String = dreg.GetValue("ISTapp", Nothing)
    '        dreg.Flush()
    '        Dim sqlJson As String = ""
    '        Dim godina As Integer = CInt(gg)
    '        Dim mesec As Integer = CInt(mm)
    '        Dim d As Date = New Date(godina, mesec, 2)

    '        'provera za vrtacku!!!
    '        Me.UserControlVremenskaTacka1.MyInit("Vod", "Vdo", Date.MinValue, Date.MaxValue, d)
    '        Me.Logovan.Text = logovan.ToString.Trim
    '    End If

    '    UserNameZCAPI = GetUserNameZ()
    '    UserNameCAPI = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)

    'End Sub

    Sub CAPIdata()
        'preuzima se sifIST, god,mes,user

        Dim dreg As Microsoft.Win32.RegistryKey
        Dim subKeyDatum As String = "IzabranDatum"

        If Not appRegKeyL Is Nothing Then
            dreg = appRegKeyL.OpenSubKey(subKeyDatum, True)
            'provera za vrtacku!!!
            Dim gg As String = dreg.GetValue("ISTYear", Nothing)
            Dim mm As String = dreg.GetValue("ISTMonth", Nothing)
            Dim logovan As String = dreg.GetValue("ISTUser", Nothing)
            If logovan Is Nothing OrElse logovan.Trim = "" Then
                logovan = GetUserName.Trim
            End If
            Dim app As String = dreg.GetValue("ISTapp", Nothing)
            dreg.Flush()
            Dim sqlJson As String = ""
            Dim godina As Integer = CInt(gg)
            Dim mesec As Integer = CInt(mm)
            Dim d As Date = New Date(godina, mesec, 2)
            UserNameCAPI = logovan
            'provera za vrtacku!!!
            Me.UserControlVremenskaTacka1.MyInit("Vod", "Vdo", Date.MinValue, Date.MaxValue, New Date(gg, mm, 2))
            Me.Logovan.Text = logovan.ToString.Trim
            '2017-09-19 00:34:43.087 mi treba
            Dim vtvt As String = d.ToString("yyyy-MM-dd HH:mm:ss")

            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            Call puniDatasetIstrazivanja(app, vtvt)
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja
            'puni DatasetIstrazivanja

            Dim dISTPravaBaza As New System.Data.DataTable
            Dim sqls As String = " select pravaBaza,konekcija,naziv,periodika,server from vBazaServer where SifIST='" + app + "' "
            dISTPravaBaza = izvrsiSQLvratiDT(sqls, Me.ISTConnectionString, Nothing)

            pravaBaza = dISTPravaBaza.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim
            server = dISTPravaBaza.Rows(0).Item("server").ToString.ToUpper.Trim
            konekcija = dISTPravaBaza.Rows(0).Item("konekcija").ToString.Trim
            Dim DBConnectionString As String = getConnectionString(server, pravaBaza, txtmode, "")

            If sqlJson Is Nothing OrElse sqlJson.Trim = "" OrElse sqlJson.Trim = "null" Then
            Else
                Try
                    Dim sqlJson2 As String = "SELECT [key], [keyIST] as name, [value], [type] FROM vCAPIData where ISTapp='" + app + "'"
                    Try
                        dtJson = Nothing
                        dtJson = izvrsiSQLvratiDTJSON(sqlJson2, DBConnectionString, "")
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        dtJson = Nothing
                    End Try
                Catch ex As System.Exception
                    dtJson = Nothing
                End Try

            End If

            Try
                Dim execsp As String = ""
                If Not Me.dsIST.IST.Rows(0).Item("upitnik") Is System.DBNull.Value Then
                    Dim additionalParameters As String = Me.dsIST.IST.Rows(0).Item("upitnik").ToString.Trim.ToUpper
                    Dim pp() As String = additionalParameters.Split(CType(";", Char()))
                    For i As Integer = 0 To pp.GetUpperBound(0)
                        If pp(i).Trim.ToUpper.IndexOf("EXECONLOAD") >= 0 Then
                            execsp = NZ(Replace(pp(i), "execonload", "", 1, , CompareMethod.Text)).Trim()
                            Exit For
                        End If

                    Next
                End If
                If execsp <> "" Then
                    Dim ok As String = izvrsiSQL("exec " + execsp, DBConnectionString)
                    If ok <> "ok" Then
                        ISTMessageBox.Show("Error at EXECONLOAD!")
                    End If
                End If

            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Sub popuniReset(ByVal iniz As Integer, cntl As Object, ByVal vvisible As Boolean)
    '    ReDim Preserve nizAvailableReset(iniz)
    '    nizAvailableReset(iniz) = cntl
    'End Sub
    Private Sub FormIstrazivanje_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.UserControlVremenskaTacka1.Focus()
        System.Windows.Forms.Application.EnableVisualStyles()
    End Sub

    Private Sub ButtonValidniIntervali_ButtonClicked(sender As Object, e As EventArgs) Handles btnFT1.Click
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonValidniIntervali_Click()
        End If
    End Sub

    Private Sub ButtonBrojSlogova_ButtonClicked(sender As Object, e As EventArgs) Handles btnFT2.Click
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonBrojSlogova_Click()
        End If
    End Sub

    Private Sub ButtonPoslednjiDatumSaPodacima_ButtonClicked(sender As Object, e As EventArgs) Handles btnFT3.Click
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonPoslednjiDatumSaPodacima_Click()
        End If
    End Sub

    Private Sub buttonOcena_ButtonClicked(sender As Object, e As EventArgs) Handles btnFT4.Click
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonOcena_Click()
        End If
    End Sub

    Private Sub buttonLogLK_ButtonClicked(sender As Object, e As EventArgs) Handles btnFT5.Click
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonLogLK_Click()
        End If
    End Sub

    Private Sub BtnQueryDesigner_ButtonClicked(sender As Object, e As EventArgs)
        If MrefreshClick() = False Then Exit Sub
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.BtnQueryDesigner()
        End If


    End Sub

    Private Sub llIST1_ButtonClicked(sender As Object, e As EventArgs)
        If MrefreshClick() = False Then Exit Sub
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New IstrazivanjaZadaci.Form_IST(Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                        Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, Me.PublicDBServer.Trim.ToUpper, Me.PublicDBBaza.Trim.ToUpper, Me.txtmode, Me.jezik, Me.UserControlVremenskaTacka1, kosamnew)

        Me.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            frm.Dispose()
            Me.Show()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Private Sub llSemiAutomaticCoding_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles bSemiAutomaticCoding.LinkClicked

        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.llSifriranjeS_Click()
        End If
    End Sub

    Private Sub llAdvancedUpdating_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles bAdvancedTableUpdate.LinkClicked
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.llAdvancedUpdating_Click()
        End If
    End Sub

    Private Function Login(ByRef datasetIST As DatasetIstrazivanja, ByRef connectionString As String, ByRef rowIST As DatasetIstrazivanja.ISTRow, ByRef tabelaAdresar As DatasetIstrazivanja.ISTPOLJADataTable, ByRef datasetISTPX As DatasetIstrazivanja) As Boolean

        If Me.m_zadaciVremenskaTacka.ButtonLogin_Click(datasetIST, connectionString, rowIST, tabelaAdresar, datasetISTPX) Then
            Me.m_zadaciIstrazivanje = New IstrazivanjaZadaci.IstrazivanjeZadaci(connectionString, datasetIST, datasetISTPX,
            tabelaAdresar, rowIST, Me, Me.UserControlVremenskaTacka1, Me.m_folderProgramaZaUnos,
            Me.Instalacija, Me.txtpismo, Me.txtmode, ISTConnectionString,
            Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.CATIServer, Me.CATIBaza, Me.jezik, Me.dtMessages, Me.txtoffice, CAPIServer, CAPIBaza, PXMETATable,
                                                                                dtJson, m_folderZaGen, Me.PublicDBServer, Me.PublicDBBaza, mdtLabel, mdtAWL, mdtQE, mdtMessage, kosamnew)
            Return True
        End If
        Return False
    End Function

    Private Sub MIMreza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIMreza.Click
        If MrefreshClick() = False Then Exit Sub
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.BtnQueryDesigner()
        End If

    End Sub
    Private Sub MIist2xml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIist2xml.Click
        ist2xml()
    End Sub

    Private Sub ist2xml()
        Dim dataSetIST As DatasetIstrazivanja = Me.m_zadaciVremenskaTacka.dsdsIST
        Dim dlg As New System.Windows.Forms.SaveFileDialog
        dlg.Filter = "XML files (*.xml)|*.xml"
        dlg.FileName = "IST_" & CStr(dataSetIST.IST.Rows(0).ItemArray(dataSetIST.IST.Columns.IndexOf("SifIST"))) 'dlg.InitialDirectory + "\" +
        Dim dr As DialogResult
        dr = dlg.ShowDialog
        Dim fileName As String = dlg.FileName
        dlg.Dispose()
        If dr = DialogResult.OK Then
            dataSetIST.WriteXml(fileName)
        End If
    End Sub

    Private Sub MIIstUAspax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIIstUAspax.Click
        Me.Cursor = Cursors.WaitCursor
        ist2ASPX()
        Me.Cursor = Cursors.Default
    End Sub


    Dim dozvoljeno As String
    Dim RangeV As Boolean
    Dim RequiredF As Boolean
    Dim RegExV As Boolean
    Dim CustomV As Boolean
    Dim funkcijaDa As Boolean
    Dim funkcijaNe As Boolean
    Dim minL As String
    Dim maxL As String
    Dim minV As String
    Dim maxV As String
    Dim tipRV As String
    Dim nnizneV() As String
    Dim nnizdaV() As String
    Dim nizdodeliSta() As String = {}
    Dim nizdodeliKome() As String = {}
    Dim nizdodeliAko() As String = {}
    Dim nizskociNA() As String = {}
    Dim nizskociAKO() As String = {}
    Dim nizsamoCita() As String = {}
    Dim nizsamoCitaAKO() As String = {}

    Dim funkcijaCBODodela As Boolean
    Dim funkcijaSkoci As Boolean
    Dim funkcijaSamoCita As Boolean

    Dim sbJS As System.Text.StringBuilder = New System.Text.StringBuilder
    Dim sbFilter As System.Text.StringBuilder = New System.Text.StringBuilder
    Dim sbVBpom As System.Text.StringBuilder = New System.Text.StringBuilder

    Dim sbVBpomCBOSIC As System.Text.StringBuilder = New System.Text.StringBuilder
    Dim sbVBpomTBOIC As System.Text.StringBuilder = New System.Text.StringBuilder
    Dim vt As String
    Dim mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim dISTPoljaKonsult As New System.Data.DataTable
    Dim dISTPoljaKLJUCKonsult As New System.Data.DataTable
    Dim dISTTABELEzaWeb As New System.Data.DataTable
    Dim dISTDodela As New System.Data.DataTable
    Dim dISTTABELEzaWEBizbor As New System.Data.DataTable
    Dim dISTVEZAzaWEB As New System.Data.DataTable

    Dim IzIst As String = ""
    Dim Projektant As String = ""
    Dim prvoPoljeKljuc As String = ""
    Dim tipTabele As String = ""
    Dim imaGrid As Boolean
    Dim nadtabelaOdimetab As String = ""
    Dim poslednjePoljeKljuc As String = ""
    Dim konekcija As String = ""
    Dim prvoPoljeKojeNijeKljuc As String = ""
    Dim poslednjePoljeKojeNijeKljuc As String = ""
    Dim pravaBaza As String = ""
    Dim server As String = ""
    Dim periodika As String = ""
    Dim maxVSkljuc As String = ""

    Dim brojwebStrana As Integer = 0
    Dim brojdivDisplayNone As Integer = 0

    Dim nizPlus() As String = {}
    Dim nizPamti() As String = {}
    Dim nizTabelice()()() As String = {}
    Dim nizDodatniRedoviNLB()() As String = {}

    Dim nizLab()()() As String = {}
    Dim nizPremesti()()() As String = {}
    Dim nizPodtabele() As String = {}
    Dim connPravaBaza As String


    Function dajDIV(ByVal p As String, ByVal folderDesktopViews As String, ByVal pp As String) As String
        Dim filePathDesktop As String = ""
        If p = "pk" Then filePathDesktop = folderDesktopViews + "DIVPK.txt"
        If p = "nonpk" Then filePathDesktop = folderDesktopViews + "DIVNONPK.txt"
        Dim t As New System.IO.StreamReader(filePathDesktop)
        Dim s As String = t.ReadToEnd
        If p = "pk" Then s = s.Replace("99PK99", pp)
        If p = "nonpk" Then s = s.Replace("99NONPK99", pp)
        dajDIV = s
        t.Close()
    End Function

    Dim pkFieldsMVC As String = ""
    Dim nonpkFieldsMVC As String = ""
    Dim orgCLower() As String
    Dim orgC() As String
    Dim orgCLen() As String
    Dim orgCType() As String
    Dim orgCNull() As String

    Function sqlTableFields(ByVal tabela As String, ByVal sifIST As String) As System.Data.DataTable

        Dim dt As New System.Data.DataTable
        Dim dISTPravaBaza As New System.Data.DataTable
        Dim sqls As String = "select pravaBaza,konekcija,naziv,periodika,server from vBazaServer where SifIST='" + sifIST + "' "

        dISTPravaBaza = izvrsiSQLvratiDT(sqls, Me.ISTConnectionString, Nothing)

        pravaBaza = dISTPravaBaza.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim
        server = dISTPravaBaza.Rows(0).Item("server").ToString.ToUpper.Trim

        Dim konPravaBaza As String = getConnectionString(server, pravaBaza, txtmode, "")

        Try
            Dim sql As String = "SELECT * FROM " + tabela + " where 2=3"
            Try
                dt = Nothing
                dt = izvrsiSQLvratiDT(sql, konPravaBaza, "")
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                dt = Nothing
            End Try
        Catch ex As System.Exception
            dt = Nothing
        End Try

        Return dt

    End Function

    Dim k As String = ""
    Dim kGM As String = ""
    Dim kbezGM As String = ""
    Dim ifknull As String = ""
    Dim kp As String = ""
    Dim kPbezGM As String = ""
    Dim a As String = ""
    Dim abezGM As String = ""
    Dim vbagGM As String = ""
    Dim vbag As String = ""
    Dim abag As String = ""
    Dim whbezGM As String = ""

    Private Function fdtusp_vISTPoljaPoTabeli(ByVal vtvt As String, ByVal app As String, ByVal tabela As String) As System.Data.DataTable
        Dim sql As String = "exec usp_vISTPoljaPoTabeli @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + tabela + "'"
        fdtusp_vISTPoljaPoTabeli = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function
    Private Function fdtusp_vISTPoljaKonsult(ByVal vtvt As String, ByVal app As String) As System.Data.DataTable
        Dim sql As String = "exec usp_vISTPoljaKonsult @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "'"
        fdtusp_vISTPoljaKonsult = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function
    Private Function fdtusp_vISTPoljaKljucKonsult(ByVal vtvt As String, ByVal app As String) As System.Data.DataTable
        Dim sql As String = "exec usp_vISTPoljaKljucKonsult @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "'"
        fdtusp_vISTPoljaKljucKonsult = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function
    Private Function fdtusp_vISTPoljaKljucKonsultTabela(ByVal vtvt As String, ByVal app As String, ByVal tabela As String) As System.Data.DataTable
        Dim sql As String = "exec usp_vISTPoljaKljucKonsultTabela @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + tabela + "'"
        fdtusp_vISTPoljaKljucKonsultTabela = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function
    Private Function fdtusp_vISTPoljaKljucPoTabeli(ByVal vtvt As String, ByVal app As String, ByVal tabela As String) As System.Data.DataTable
        Dim sql As String = "exec usp_vISTPoljaKljucPoTabeli @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + tabela + "'"
        fdtusp_vISTPoljaKljucPoTabeli = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function
    Private Function fdtusp_vISTDodela(ByVal vtvt As String, ByVal app As String) As System.Data.DataTable
        Dim sql As String = "exec usp_vISTDodela @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "'"
        fdtusp_vISTDodela = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function
    Private Function fdtusp_vISTPoljaKonsultTabela(ByVal vtvt As String, ByVal app As String, ByVal tabela As String, ByVal uslov As String) As System.Data.DataTable
        Dim sql As String = "exec usp_vISTPoljaKonsultTabela @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + tabela + "',@uslov=N'" + uslov + "'"
        fdtusp_vISTPoljaKonsultTabela = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    End Function
    Private Sub ist2ASPX()

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(2057)

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim di As DatasetIstrazivanja = Nothing
        Dim diPX As DatasetIstrazivanja = Nothing

        Dim ri As DatasetIstrazivanja.ISTRow = Nothing
        Dim ipt As DatasetIstrazivanja.ISTPOLJADataTable = Nothing

        If Login(di, connPravaBaza, ri, ipt, diPX) Then
        Else
            ''msg 1
            Dim por As String = getMessageText(dtMessages, "1", Me.jezik) + nvrd  ' "Nemate dozvole nad bazom! " + nvrd
            ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim sqlTab As String = ""
        Dim sqlPolja As String = ""
        Dim sqlDodela As String = ""
        Dim sqlWEBIzbor As String = ""
        Dim sqlVEZAzaWEB As String = ""
        Dim dISTBaza As New System.Data.DataTable
        Dim dISTPravaBaza As New System.Data.DataTable
        Dim sqlVB As String = ""

        mvt = Me.UserControlVremenskaTacka1
        With Me.UserControlVremenskaTacka1.MyValue
            Dim vt1 As Date = New Date(.Year, .Month, Date.DaysInMonth(.Year, .Month))
            vt = CStr(vt1).Trim
        End With

        Dim dataSetIST As DatasetIstrazivanja = Me.m_zadaciVremenskaTacka.dsdsIST
        IzIst = CStr(dataSetIST.ISTPOLJA.Rows(0).Item("SifIST")).Trim.ToUpper
        If Not dataSetIST.IST.Rows(0).Item("projektant") Is System.DBNull.Value Then
            Projektant = CStr(dataSetIST.IST.Rows(0).Item("projektant")).Trim.ToUpper
        End If

        Dim imefoldera As String = IzIst
        imefoldera = imefoldera.Replace("/", "")
        imefoldera = imefoldera.Replace("\", "")
        imefoldera = imefoldera.Replace("*", "")
        imefoldera = imefoldera.Replace("?", "")
        imefoldera = imefoldera.Replace("<", "")
        imefoldera = imefoldera.Replace(">", "")
        imefoldera = imefoldera.Replace("|", "")
        'imefoldera = imefoldera.Replace("""", "")

        Dim folder As String = "C:\ISTASP_" + imefoldera + "\"
        Dim folderJS As String = "C:\ISTASP_" + imefoldera + "\js\"

        Try
            Call DeleteFilesFromFolders(folder, Me.jezik)
            Call CopyDirectory(m_folderZaGen + "\WEB", folder)
            Call DeleteTxtFilesFromFolders(folder)
        Catch ex As System.Exception
            ''msg 99
            Dim msgtxt As String = getMessageText(dtMessages, "99", Me.jezik) + nvrd

            ISTMessageBox.Show(msgtxt + nvrd + folder + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
        End Try

        dISTPoljaKonsult.Clear()
        dISTPoljaKonsult = fdtusp_vISTPoljaKonsult(vt, IzIst)  'order by tabela, rbr"

        If dISTPoljaKonsult.Rows.Count = 0 Then
            ''msg 100
            Dim msgtxt100 As String = getMessageText(dtMessages, "100", Me.jezik) + nvrd + nvrd
            ''msg 101
            Dim msgtxt101 As String = getMessageText(dtMessages, "101", Me.jezik)
            ISTMessageBox.Show(msgtxt100 + nvrd + msgtxt101, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        dISTPoljaKLJUCKonsult.Clear()
        dISTPoljaKLJUCKonsult = fdtusp_vISTPoljaKljucKonsult(vt, IzIst)   'order by tabela, rbr"

        sqlTab = " select * from  dbo.vISTTABELEzaWEB ('" + vt + "','" + IzIst + "')"
        dISTTABELEzaWeb.Clear()
        dISTTABELEzaWeb = izvrsiSQLvratiDT(sqlTab, ISTConnectionString, Nothing)

        dISTDodela.Clear()
        dISTDodela = fdtusp_vISTDodela(vt, IzIst)   'order by tabela"

        sqlWEBIzbor = " select * from dbo.vISTTABELEzaWEBizbor ('" + vt + "','" + IzIst + "') order by tabela"
        dISTTABELEzaWEBizbor.Clear()

        dISTTABELEzaWEBizbor = izvrsiSQLvratiDT(sqlWEBIzbor, ISTConnectionString, Nothing)

        sqlVEZAzaWEB = " select * from dbo.vISTVezaZaWEB ('" + vt + "','" + IzIst + "') order by jestemb desc,rbr asc"
        dISTVEZAzaWEB.Clear()

        dISTVEZAzaWEB = izvrsiSQLvratiDT(sqlVEZAzaWEB, ISTConnectionString, Nothing)

        sqlVB = " select pravaBaza,konekcija,naziv,periodika from vBazaServer where SifIST='" + IzIst + "' "

        dISTPravaBaza = izvrsiSQLvratiDT(sqlVB, ISTConnectionString, Nothing)

        pravaBaza = dISTPravaBaza.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim
        konekcija = dISTPravaBaza.Rows(0).Item("konekcija").ToString.Trim
        periodika = dISTPravaBaza.Rows(0).Item("periodika").ToString.ToUpper.Trim

        Dim opisIST As String = ""
        opisIST = dISTPravaBaza.Rows(0).Item("naziv").ToString.Trim

        Dim upitDDL As String = ""
        Dim opisTab As String = ""
        Dim upitFK As String = ""

        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim sbVB As System.Text.StringBuilder = New System.Text.StringBuilder

        sbJS.Length = 0
        sbFilter.Length = 0
        sbVBpom.Length = 0
        sbVBpomCBOSIC.Length = 0
        sbVBpomTBOIC.Length = 0

        Dim forma As String = ""
        Dim f1 As String = ""
        Dim f2 As String = ""
        Dim f3 As String = ""
        Dim vs As String = ""
        Dim pomDG As String = ""
        Dim pomOD As String
        dozvoljeno = ""
        maxL = ""
        Dim opis As String = ""
        Dim opisBOLD As String = ""
        Dim DGTabela As String = ""

        Dim webstr As Integer = 0
        Dim endofwebstr As Integer = 0
        Dim divDisplayNone As String = ""
        Dim EndOfdiv As Integer = 0

        Dim relPolje As String = ""
        Dim nazivZaDDL As String = ""
        Dim dodela As String = ""
        Dim opisNadLBL As String = ""
        Dim opisLAB As String = ""

        Dim izraz As String = ""
        Dim polje As String = ""
        Dim kolikoNaWeb As Integer = 0
        Dim sta As String = ""
        Dim staTabelica As String = ""
        Dim prvi As Boolean = False
        Dim upitCBO As String = ""
        Dim filterCBO As String = ""
        Dim imetab As String = ""

        Dim okAdr As Boolean = False
        Dim okRel As Boolean = False
        Dim imeAdr As String = ""
        Dim imeRel As String = ""

        Dim upitACE As String
        Dim filterACE As String

        If dISTTABELEzaWeb.Rows.Count = 0 Then
            ''msg 102
            Dim msgtxt As String = getMessageText(dtMessages, "102", Me.jezik)
            ISTMessageBox.Show(msgtxt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim imamCuvanjePanela As Boolean = False

        For Each tab As System.Data.DataRow In dISTTABELEzaWeb.Rows

            Dim pamtiTabelica As Integer = 0
            Dim imaGOD As Boolean = False
            Dim imaMES As Boolean = False
            Dim imaKV As Boolean = False
            Dim panel As Boolean = False

            sb.Length = 0
            sbVB.Length = 0
            sbJS.Length = 0
            sbFilter.Length = 0
            sbVBpom.Length = 0
            sbVBpomCBOSIC.Length = 0
            sbVBpomTBOIC.Length = 0

            Dim nizDG() As String = {}
            kolikoNaWeb = kolikoNaWeb + 1

            imetab = tab.Item("tabela").ToString.Trim.ToUpper
            imamCuvanjePanela = False
            tipTabele = ""

            If Not (tab.Item("T2").GetType Is GetType(System.DBNull)) Then
                If tab.Item("T2").ToString.Trim.ToUpper.IndexOf("PANEL") >= 0 Then
                    panel = True   'panelna podtabela
                End If
            End If

            Dim dg As String = tab.Item("DG").ToString.Trim.ToUpper

            Dim funkcija As String = tab.Item("funkcija").ToString.Trim.ToUpper
            If dg = "G" Then
                'za svaku tabelu KOJA JE G MORAM da imam adresar (ako postoji u LK kroz funkciju #Adresar ili kroz funkciju #Relacija)
                If funkcija = "A" Then    '#Adresar
                    imeAdr = tab.Item("adresarTabela").ToString.Trim.ToUpper
                    'ako je imeAdr.lenght=0 onda nema adresar funkcije
                    If imeAdr.Length > 0 Then okAdr = True
                End If
                If funkcija = "R" Then   '#Relacija
                    imeRel = tab.Item("adresarTabela").ToString.Trim.ToUpper
                    'ako je imeAdr.lenght=0 onda nema adresar funkcije
                    If imeRel.Length > 0 Then okRel = True
                End If
                If okAdr = True AndAlso okRel = True Then okAdr = False : imeAdr = "" 'relacija jaca od adresara
                If okAdr = False AndAlso okRel = False Then
                    ''msg 100
                    Dim msgtxt100 As String = getMessageText(dtMessages, "100", Me.jezik) + nvrd + nvrd
                    ''msg 103
                    Dim msgtxt103 As String = getMessageText(dtMessages, "103", Me.jezik)
                    ISTMessageBox.Show(msgtxt100 + nvrd + msgtxt103, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            If Not (tab.Item("opis").GetType Is GetType(System.DBNull)) Then
                opisTab = tab.Item("opis").ToString.Trim
            Else
                opisTab = imetab
            End If
            If opisTab.IndexOf("$") >= 0 Then
                opisTab = Microsoft.VisualBasic.Replace(opisTab, "$", "", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            End If
            If opisTab.Trim.IndexOf("LDESNOP") >= 0 Then
                opisTab = Microsoft.VisualBasic.Replace(opisTab, "ldesnop", "", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            End If
            If opisTab.Trim.IndexOf("LRIGHTA") >= 0 Then
                opisTab = Microsoft.VisualBasic.Replace(opisTab, "lrighta", "", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            End If
            If opisTab.Trim.ToUpper.IndexOf("FONTBOLD") >= 0 Then
                opisTab = Microsoft.VisualBasic.Replace(opisTab, "fontbold", "", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            End If
            If opisTab.Trim.ToUpper.IndexOf("LVISINA") >= 0 Then
                opisTab = Microsoft.VisualBasic.Replace(opisTab, "lvisina", "", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            End If
            If opisTab.Trim.ToUpper.IndexOf("LHEIGHT") >= 0 Then
                opisTab = Microsoft.VisualBasic.Replace(opisTab, "lheight", "", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            End If

            If Not (tab.Item("DG").GetType Is GetType(System.DBNull)) Then
                DGTabela = tab.Item("DG").ToString.Trim
            Else
                DGTabela = ""
            End If

            Dim redG As String
            If Not (tab.Item("red").GetType Is GetType(System.DBNull)) Then
                redG = tab.Item("red").ToString.Trim
            Else
                redG = ""
            End If

            Dim aspx As String = ""
            Dim vb As String = ""
            Dim js As String = ""
            aspx = folder + imetab + ".aspx"
            vb = folder + imetab + ".aspx.vb"
            js = folderJS + imetab + ".js"

            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(aspx)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(aspx)
                Dim fivb As New System.IO.FileInfo(vb)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(vb)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
            End Try

            Try
                Call dajRaznoISTZaTabelu(imetab)
            Catch ex As System.Exception
                ''msg 104
                Dim msgtxt As String = getMessageText(dtMessages, "104", Me.jezik) + nvrd + ex.Message
                ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Finally
            End Try

            Dim nizTabIndexa() As String = dajnizTabIndex(imetab)

            'aspx
            sb.Length = 0
            Dim osnovniASPXPoc As String = ""
            Dim osnovniASPXKraj As String = ""
            If panel = False Then
                osnovniASPXPoc = m_folderZaGen + "\WEB" + "\osnovniASPXPoc.txt"
                osnovniASPXKraj = m_folderZaGen + "\WEB" + "\osnovniASPXKraj.txt"
            Else
                osnovniASPXPoc = m_folderZaGen + "\WEB" + "\panelASPXPoc.txt"
                osnovniASPXKraj = m_folderZaGen + "\WEB" + "\panelASPXKraj.txt"
            End If
            Dim txtpocetak As New System.IO.StreamReader(osnovniASPXPoc)
            Dim txtkraj As New System.IO.StreamReader(osnovniASPXKraj)

            Dim strpocetak As String = txtpocetak.ReadToEnd
            txtpocetak.Close()

            strpocetak = strpocetak.Replace("99imetabele99", imetab.Trim.ToUpper)
            strpocetak = strpocetak.Replace("99opistabele99", opisTab)
            strpocetak = strpocetak.Replace("99opisIST99", opisIST)
            sb.Append(strpocetak + nvrd)
            'sb.Append("<br/>" + nvrd)

            Dim strkraj As String = txtkraj.ReadToEnd
            txtkraj.Close()
            strkraj = strkraj.Replace("99imetabele99", imetab)

            'naslov
            sb.Append("<table width=" + nvd + " 95%" + nvd + " cellpadding=" + nvd + " 0" + nvd + " cellspacing=" + nvd + " 0" + nvd + ">" + nvrd)
            sb.Append("<tr><td class=" + nvd + "IST13CB" + nvd + " colspan=" + nvd + " 2" + nvd + ">" + nvrd)
            If panel = False Then sb.Append(dajFP(False, opisTab, "FP_imetab", "-1", "500"))
            sb.Append("</td></tr>" + nvrd)

            'SKLOPI KLJUC
            Dim bb As Integer = -1
            Dim filter As Boolean = False
            ''DDL
            Dim DDL As Boolean = False
            Dim dodelaVBizLK As String = ""
            Dim nazivPolja As String = ""
            'CBW
            Dim CBOovi As String = ""
            Dim combo As Boolean = False
            Dim filterCBOovi As String = ""
            Dim sqlCBOovi As String = ""
            Dim nazivCBOovi As String = ""
            Dim CBOUBazu As String = ""
            Dim CBOPrikazi As String = ""
            'chb
            Dim chbox As Boolean = False
            'radio button list
            Dim rblist As Boolean = False
            'FP
            Dim FP As Boolean = False
            'FK   'fiktivno polje koje dobija vrednost na izlasku iz kljuca - izraz ima na kraju :PK}
            Dim FK As Boolean = False
            'ACE
            Dim ACEovi As String = ""
            Dim ACE As Boolean = False
            Dim ACEfilter As String = ""
            Dim sqlACEovi As String = ""
            Dim nazivACEovi As String = ""
            Dim ACEtipPolja As String = ""
            Dim ACEpravaBaza As String = ""
            Dim ACERelTabela As String = ""
            Dim ACETabela As String = ""
            Dim ACEUBazu As String = ""
            Dim ACEPrikazi As String = ""
            Dim ACEFiltriranoPolje As String = ""
            Dim ACEFiltriranoPoPolju As String = ""
            Dim imeUBazi As String = ""
            Dim imeWeb As String = ""
            Dim rbrUBAZI As String = ""
            Dim tabIndex As String = ""
            Dim pk As Integer = 0
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim.ToUpper = imetab Then
                    If CStr(t.Item("KLJUC")).Trim.ToUpper = "P" Then
                        pk = pk + 1
                        If panel = True AndAlso pk = 1 Then sb.Append("<tr>" + nvrd)
                        imeUBazi = CStr(t.Item("polje")).Trim.ToUpper
                        rbrUBAZI = CStr(t.Item("rbr")).Trim.ToUpper
                        imeWeb = CStr(t.Item("imeWeb")).Trim.ToUpper
                        Dim pomTipPolja As String = CStr(t.Item("tipPolja")).Trim.ToUpper
                        If pomTipPolja.Substring(0, 1) = "H" OrElse pomTipPolja.Substring(0, 1) = "L" Then   'hidden ili labela
                            tabIndex = "-1"
                        Else
                            tabIndex = CStr(System.Array.IndexOf(nizTabIndexa, imeUBazi)).Trim
                            If panel = True Then tabIndex = tabIndex + 1000
                        End If
                        DDL = False : combo = False : FP = False : ACE = False
                        vs = CStr(t.Item("vs")).Trim
                        pomDG = CStr(t.Item("DG")).Trim
                        If pomDG <> "D" AndAlso pomDG <> "G" AndAlso pomDG <> "A" AndAlso pomDG <> "K" Then
                            If pomTipPolja <> "LBL" AndAlso pomTipPolja <> "FP" Then
                                bb = bb + 1
                                ReDim Preserve nizDG(bb)
                                nizDG(bb) = imeWeb + ";" + pomDG.Trim
                            End If
                        End If

                        pomOD = CStr(t.Item("OD")).Trim.ToUpper
                        Dim pomTip As String = CStr(t.Item("tip")).Trim.ToUpper()
                        Dim pomDuzina As String = CStr(t.Item("duzina")).Trim.ToUpper
                        Dim pomFiltriranoPolje As String = CStr(t.Item("FiltriranoPolje")).Trim.ToUpper
                        Dim pomFiltriranoPoPolju As String = CStr(t.Item("FiltriranoPoPolju")).Trim.ToUpper
                        pomFiltriranoPoPolju = pomFiltriranoPoPolju.Replace("D.", "")

                        Call ZaProveru(pomOD, t.Item("polje"), pomTip, pomDuzina)
                        'polazim od toga da nije FP (tj da je izraz prazan)
                        FP = False : combo = False : ACE = False
                        izraz = CStr(t.Item("izraz")).Trim      'zamena GGGMMM u izrazu
                        izraz = ZameniGGGMMMSimple(izraz, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))

                        If CStr(t.Item("relTabela")).Trim <> "" Then 'DDL
                            DDL = True : combo = False : FP = False : ACE = False
                        ElseIf CStr(t.Item("izraz")).Trim <> "" Then 'FP ili CBO ili ACE 
                            If izraz.Trim.Length > 3 Then
                                If izraz.Trim.ToUpper.Substring(0, 3) = "CBW" Then 'COMBOBOX
                                    combo = True : DDL = False : FP = False : ACE = False
                                ElseIf izraz.Trim.ToUpper.Substring(0, 3) = "CBO" Then 'ACE
                                    ACE = True : DDL = False : combo = False : FP = False
                                End If
                            End If
                        End If
                        upitCBO = "" : upitACE = "" : upitDDL = "" : upitFK = ""

                        If combo = True Then
                            'CBW je višeg nivoa od relacije
                            'CBW{IZVOR=select * from vISTOpstineUnos;PRIKAZI=nazivLOps;UBAZU=mbops}
                            'CBW{IZVOR=select * from vISTNaseljeUnos;FILTER=mbops=d.opsLok;PRIKAZI=nazivLNas;UBAZU=mbnas}
                            Dim dt As New System.Data.DataTable
                            Dim izvorCBO As String = ""
                            Dim prikaziCBO As String = ""
                            Dim upisiCBO As String = ""
                            Dim prenesiCBO As String = ""
                            Dim filterCBO1 As String = ""
                            izraz = izraz.Replace("CBW{", "")
                            izraz = izraz.Substring(0, izraz.Length - 1)
                            Dim nizCB As String() = Microsoft.VisualBasic.Split(izraz, ";")
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
                                    filter = True
                                    filterCBO1 = nizCB(ii).Replace("FILTER=", "")
                                End If
                                If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                                    izvorCBO = nizCB(ii).Replace("DATASOURCE=", "")
                                End If
                                If nizCB(ii).Trim.ToUpper.IndexOf("DISPLAYMEMBER=") >= 0 Then
                                    prikaziCBO = nizCB(ii).Replace("DISPLAYMEMBER=", "")
                                End If
                                If nizCB(ii).Trim.ToUpper.IndexOf("VALUEMEMBER=") >= 0 Then
                                    upisiCBO = nizCB(ii).Replace("VALUEMEMBER=", "")
                                End If
                            Next
                            Dim sqlFilter As String = "2=2"
                            upitCBO = izvorCBO
                            filterCBO = filterCBO1
                        ElseIf ACE = True Then
                            'CBO je višeg nivoa od relacije
                            'CBO{IZVOR=select * from vISTOpstineUnos;PRIKAZI=nazivLOps;UBAZU=mbops}
                            'CBO{IZVOR=select * from vISTNaseljeUnos;FILTER=mbops=d.opsLok;PRIKAZI=nazivLNas;UBAZU=mbnas}
                            Dim dt As New System.Data.DataTable
                            Dim izvorACE As String = ""
                            Dim prikaziACE As String = ""
                            Dim upisiACE As String = ""
                            Dim prenesiACE As String = ""
                            Dim filterACE1 As String = ""
                            izraz = izraz.Replace("CBO{", "")
                            izraz = izraz.Substring(0, izraz.Length - 1)
                            Dim nizAC As String() = Microsoft.VisualBasic.Split(izraz, ";")
                            For ii As Integer = 0 To nizAC.GetUpperBound(0)
                                If nizAC(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                                    izvorACE = nizAC(ii).Replace("IZVOR=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("PRIKAZI=") >= 0 Then
                                    prikaziACE = nizAC(ii).Replace("PRIKAZI=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("UBAZU=") >= 0 Then
                                    upisiACE = nizAC(ii).Replace("UBAZU=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                                    filter = True
                                    filterACE1 = nizAC(ii).Replace("FILTER=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                                    izvorACE = nizAC(ii).Replace("DATASOURCE=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("DISPLAYMEMBER=") >= 0 Then
                                    prikaziACE = nizAC(ii).Replace("DISPLAYMEMBER=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("VALUEMEMBER=") >= 0 Then
                                    upisiACE = nizAC(ii).Replace("VALUEMEMBER=", "")
                                End If
                            Next
                            Dim sqlFilter As String = "2=2"
                            upitACE = izvorACE
                            filterACE = filterACE1
                        ElseIf DDL = True Then
                            upitDDL = t.Item("upit").ToString.Trim
                            nazivZaDDL = t.Item("uslov").ToString.Trim
                            dodela = t.Item("dodela").ToString.Trim
                        End If

                        opis = CStr(t.Item("izrazFP")).Trim

                        If panel = False Then sb.Append("<tr>" + nvrd)
                        'POLJE
                        sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)

                        If upitDDL.Trim.Length > 0 Then
                            sb.Append(dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL")))
                            sb.Append(dajRequiredFieldValidator(imeWeb))
                            sb.Append(dajFPrightBold(False, opis, "LBL_" + imeUBazi, "-1", maxVSkljuc))
                            sb.Append(dajACE(imetab, False, "", "", imeWeb, tabIndex, vs))
                            ACEovi = ACEovi + imeWeb + ";"
                            ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim.ToUpper + ";"
                            ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim.ToUpper + ";"
                            ACETabela = ACETabela + CStr(t.Item("relTabela")).Trim.ToUpper + ";"
                            ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                            ACEUBazu = ACEUBazu + CStr(t.Item("relPolje")).Trim.ToUpper + ";"
                            ACEPrikazi = ACEPrikazi + CStr(t.Item("relPolje")).Trim.ToUpper + ";"
                            sqlACEovi = sqlACEovi + upitACE + ";"
                            dodelaVBizLK = dodelaVBizLK + dodela + ";"
                            nazivPolja = nazivPolja + imeWeb + ";"
                        ElseIf upitACE.Trim.Length > 0 Then 'CBO u IST-u, ACE na web-u
                            sb.Append(dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL")))
                            sb.Append(dajRequiredFieldValidator(imeWeb))
                            ACEovi = ACEovi + imeWeb + ";"
                            ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim.ToUpper + ";"
                            ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim.ToUpper + ";"
                            ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                            ACETabela = ACETabela + CStr(t.Item("CBOTabela")).Trim.ToUpper + ";"
                            ACEUBazu = ACEUBazu + CStr(t.Item("CBOuBazu")).Trim.ToUpper + ";"
                            ACEPrikazi = ACEPrikazi + CStr(t.Item("CBOPrikazi")).Trim.ToUpper + ";"
                            ACEfilter = filterCBOovi + filterCBO + ";"
                            ACEFiltriranoPolje = ACEFiltriranoPolje + CStr(t.Item("FiltriranoPolje")).Trim.ToUpper + ";"
                            ACEFiltriranoPoPolju = ACEFiltriranoPoPolju + CStr(t.Item("FiltriranoPoPolju")).Trim.ToUpper + ";"
                            sqlACEovi = sqlACEovi + upitACE + ";"
                            ACEfilter = ACEfilter + CStr(t.Item("CBOFilter")).Trim.ToUpper + ";"
                            nazivPolja = nazivPolja + imeWeb + ";"
                            sb.Append(dajFPrightBold(False, opis, "LBL_" + imeUBazi.ToUpper, "-1", maxVSkljuc))
                            If pomFiltriranoPolje = "1" Then
                                sb.Append(dajACEFilter(imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vs))
                            Else 'NEMA update panela
                                sb.Append(dajACE(imetab, False, "", "", imeWeb, tabIndex, vs))
                            End If
                            dodelaVBizLK = dodelaVBizLK + dodela + ";"
                        ElseIf upitCBO.Trim.Length > 0 Then 'CBO u IST-u i na web-u
                            sb.Append(dajRequiredFieldValidatorDDL(imeWeb))
                            CBOovi = CBOovi + imeWeb + ";"
                            sqlCBOovi = sqlCBOovi + upitCBO + ";"
                            filterCBOovi = filterCBOovi + filterCBO + ";"
                            CBOUBazu = CBOUBazu + CStr(t.Item("CBOUBazu")).Trim.ToUpper + ";"
                            CBOPrikazi = CBOPrikazi + CStr(t.Item("CBOprikazi")).Trim.ToUpper + ";"
                            nazivPolja = nazivPolja + imeWeb + ";"
                            sb.Append(dajFPrightBold(False, opis, "LBL_" + imeUBazi.ToUpper, "-1", maxVSkljuc))
                            If pomFiltriranoPolje = "1" Then
                                sb.Append(dajCBO(False, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vs))
                            ElseIf ZaUpdatePanel(imetab, imeUBazi) <> "" Then
                                pomFiltriranoPoPolju = ZaUpdatePanel(imetab, imeUBazi.ToUpper)
                                sb.Append(dajCBO(False, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vs))
                            Else 'bez update panela
                                sb.Append(dajCBO(False, imetab, False, "", "", imeWeb, tabIndex, vs))
                            End If

                        Else 'text polje
                            'ako se radi o panelu samo ovde ima svrhe raditi promenu u odnosu na klasicno
                            'jer oni koji idu kao deo kljuca koji je kljuc nadtabele ti idu Visible=false
                            'i ti su sigurno obicna text polja
                            'ostalo normalno
                            Dim deoKljucaNadtabele As Boolean = False
                            If panel = True Then  'panelna podtabela
                                'ispitaj da li ovo polje je deo kljuca nadtabele
                                'ako jeste onda mora da bude visible=false
                                'ne treba RequiredFieldValidator, ne treba labela
                                Dim kljucNadTabele As String() = Microsoft.VisualBasic.Split(spremiKljucTabeleSaZarezom(nadtabelaOdimetab), ",")
                                For j As Integer = 0 To kljucNadTabele.GetUpperBound(0)
                                    kljucNadTabele(j) = kljucNadTabele(j).Trim.ToUpper.Replace(nadtabelaOdimetab.Trim.ToUpper + ".", "")
                                    If kljucNadTabele(j).Trim.ToUpper = imeUBazi.Trim.ToUpper Then
                                        deoKljucaNadtabele = True
                                        Exit For
                                    End If
                                Next
                            End If
                            'nije panel
                            If panel = False Then
                                If imeUBazi.ToUpper = "GOD" OrElse imeUBazi.ToUpper = "ISTYEAR" Then
                                    imaGOD = True
                                    sb.Append(dajRegularExpressionValidator(imeWeb, "4"))
                                ElseIf imeUBazi.ToUpper = "MES" OrElse imeUBazi.ToUpper = "ISTMONTH" Then
                                    imaMES = True
                                    sb.Append(dajRegularExpressionValidator(imeWeb, "1"))
                                    sb.Append(dajRangeValidator(imeWeb, "1", "12", tipRV))
                                ElseIf imeUBazi.ToUpper = "KV" Then
                                    imaKV = True
                                    sb.Append(dajRegularExpressionValidator(imeWeb, "1"))
                                    sb.Append(dajRangeValidator(imeWeb, "1", "4", tipRV))
                                Else
                                    If RegExV = True Then sb.Append(dajRegularExpressionValidator(imeWeb, minL))
                                    If RangeV = True Then sb.Append(dajRangeValidator(imeWeb, minV, maxV, tipRV))
                                End If
                                If funkcijaDa = True Or funkcijaNe = True Then
                                    Call spremiJS(imeWeb, nnizneV, nnizdaV)
                                    Call spremiVB(imeWeb, nnizneV, nnizdaV)
                                    sb.Append(dajCustomValidator(imeWeb))
                                End If
                                sb.Append(dajRequiredFieldValidator(imeWeb))
                                sb.Append(dajFPrightBold(False, opis, "LBL_" + imeUBazi, "-1", maxVSkljuc))
                                sb.Append(dajFilterPolje(False, imetab, False, "", "", imeWeb, tabIndex, vs, dozvoljeno, maxL))
                            End If
                            'jeste panel
                            If panel = True Then
                                If deoKljucaNadtabele = True Then
                                    If imeUBazi.ToUpper = "GOD" OrElse imeUBazi.ToUpper = "ISTYEAR" Then imaGOD = True
                                    If imeUBazi.ToUpper = "MES" OrElse imeUBazi.ToUpper = "ISTMONTH" Then imaMES = True
                                    If imeUBazi.ToUpper = "KV" Then imaKV = True
                                    vs = CStr(CInt(vs) / 2).Trim
                                    sb.Append(dajFilterPolje(False, imetab, False, "", "", imeWeb, tabIndex, vs, dozvoljeno, maxL, False))
                                Else
                                    If RegExV = True Then sb.Append(dajRegularExpressionValidator(imeWeb, minL))
                                    If RangeV = True Then sb.Append(dajRangeValidator(imeWeb, minV, maxV, tipRV))
                                    If funkcijaDa = True Or funkcijaNe = True Then
                                        Call spremiJS(imeWeb, nnizneV, nnizdaV)
                                        Call spremiVB(imeWeb, nnizneV, nnizdaV)
                                        sb.Append(dajCustomValidator(imeWeb))
                                    End If
                                    'sb.Append(dajRequiredFieldValidator(imeWeb))
                                    sb.Append(dajFPrightPanelKljuc(False, opis, "LBL_" + imeUBazi, "-1", maxVSkljuc))
                                    sb.Append(dajFilterPolje(False, imetab, False, "", "", imeWeb, tabIndex, vs, dozvoljeno, maxL))
                                End If
                            End If
                            nazivPolja = nazivPolja + imeWeb + ";"
                        End If
                        sb.Append("</td>" + nvrd)
                        'KRAJ POLJA
                        If panel = False Then sb.Append("</tr>" + nvrd)
                    End If
                End If
            Next 'SKLOPI KLJUC
            If panel = True Then
                sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)
                sb.Append("<asp:ImageButton ID=" + nvd + "view" + nvd + " runat=" + nvd + "server" + nvd + " TabIndex=" + nvd + tabIndex + nvd + " ImageUrl=" + nvd + "~/Images/search_button.gif" + nvd + " style=" + nvd + "width: 20px;" + nvd + " ToolTip=" + nvd + "Прикажи" + nvd + " CausesValidation=" + nvd + "False" + nvd + " />" + nvrd)
                sb.Append("</td>" + nvrd)
                sb.Append("</tr>" + nvrd)
            End If

            If panel = False Then
                sb.Append("<tr>" + nvrd)
                sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)
                sb.Append("<asp:Image ID=" + nvd + "linija" + nvd + " runat=" + nvd + "server" + nvd + " ImageUrl=" + nvd + "~/Images/greyline.jpg" + nvd + " />" + nvrd)
                sb.Append("</td>" + nvrd)
                sb.Append("</tr>" + nvrd)
            End If

            tabIndex = CStr(System.Array.IndexOf(nizTabIndexa, "ImageButtonView")).Trim
            If panel = True Then tabIndex = tabIndex + 1000

            If panel = False Then
                sb.Append("<tr>" + nvrd)
                sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)
                sb.Append("<asp:ImageButton ID=" + nvd + "view" + nvd + " runat=" + nvd + "server" + nvd + " TabIndex=" + nvd + tabIndex + nvd + " ImageUrl=" + nvd + "~/Images/search_button.gif" + nvd + " style=" + nvd + "width: 20px;" + nvd + " ToolTip=" + nvd + "Прикажи" + nvd + " CausesValidation=" + nvd + "False" + nvd + " />" + nvrd)
                sb.Append("</td>" + nvrd)
                sb.Append("</tr>" + nvrd)
                sb.Append("<tr>" + nvrd)
                sb.Append("<td class=" + nvd + "IST13R" + nvd + ">" + nvrd)
                sb.Append("<asp:Image ID=" + nvd + "img1" + nvd + " runat=" + nvd + "server" + nvd + " ImageUrl=" + nvd + "~/Images/space.gif" + nvd + " style=" + nvd + "width: 20px;" + nvd + "/>")
                sb.Append("<asp:Label ID=" + nvd + "lblPoruka" + nvd + " runat=" + nvd + "server" + nvd + " Width=" + nvd + " 750px" + nvd + " foreColor=" + nvd + "#000099" + nvd + "></asp:Label>")
                sb.Append("</td>" + nvrd)
                sb.Append("</tr>" + nvrd)
            End If
            sb.Append("</table>" + nvrd)
            'KRAJ SKLOPI KLJUC

            sb.Append("<br/>" + nvrd)

            ''SKLOPI OSTALE
            Dim niz() As String = {}
            Dim nizWebStr() As String = {}
            Dim nizEndOfWebStr() As String = {}

            Dim nizdivDisplayNone() As String = {}
            Dim nizEndOfdiv() As String = {}

            Dim i As Integer = -1
            Dim d As Integer = -1

            ReDim Preserve niz(i)

            Dim m As Integer = -1
            Dim k As Integer = -1
            Dim nadLBL() As String = {}
            Dim pamtiFormu As String = ""
            Dim grupaCHB As String = ""
            Dim maxDuzLabele As Integer = 1
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim.ToUpper = imetab Then
                    If CStr(t.Item("kljuc")).Trim.Length = 0 Then
                        grupaCHB = ""
                        imeUBazi = t.Item("polje").trim.toupper
                        rbrUBAZI = CStr(t.Item("rbr")).Trim.ToUpper
                        imeWeb = t.Item("imeWeb").trim.toupper
                        'procitaj FORMU
                        forma = CStr(t.Item("forma")).Trim
                        f1 = CStr(t.Item("f1")).Trim
                        f2 = CStr(t.Item("f2")).Trim
                        f3 = CStr(t.Item("f3")).Trim

                        webstr = CInt(CStr(t.Item("webstr")).Trim.ToUpper)
                        endofwebstr = CInt(CStr(t.Item("endofwebstr")).Trim.ToUpper)
                        divDisplayNone = CInt(CStr(t.Item("divDisplayNone")).Trim.ToUpper)
                        EndOfdiv = CInt(CStr(t.Item("EndOfdivDisplayNone")).Trim.ToUpper)

                        DDL = False : combo = False : FP = False : ACE = False : FK = False : chbox = False : rblist = False

                        vs = CStr(t.Item("vs")).Trim
                        pomDG = CStr(t.Item("DG")).Trim
                        Dim pomTipPolja As String = CStr(t.Item("tipPolja")).Trim.ToUpper
                        If pomTipPolja.Substring(0, 1) = "H" OrElse pomTipPolja.Substring(0, 1) = "L" Then   'hidden ili labela
                            tabIndex = "-1"
                        Else
                            tabIndex = CStr(System.Array.IndexOf(nizTabIndexa, imeUBazi)).Trim
                            If panel = True Then tabIndex = tabIndex + 1000
                        End If
                        If pomDG <> "D" AndAlso pomDG <> "G" AndAlso pomDG <> "A" AndAlso pomDG <> "K" Then
                            If pomTipPolja <> "LBL" AndAlso pomTipPolja <> "FP" Then
                                bb = bb + 1
                                ReDim Preserve nizDG(bb)
                                nizDG(bb) = t.Item("imeWeb").trim + ";" + pomDG.Trim
                            End If
                        End If
                        pomOD = CStr(t.Item("OD")).Trim.ToUpper
                        Dim pomTip As String = CStr(t.Item("tip")).Trim.ToUpper
                        Dim pomDuzina As String = CStr(t.Item("duzina")).Trim.ToUpper
                        Dim pomFiltriranoPolje As String = CStr(t.Item("FiltriranoPolje")).Trim.ToUpper
                        Dim pomFiltriranoPoPolju As String = CStr(t.Item("FiltriranoPoPolju")).Trim.ToUpper
                        pomFiltriranoPoPolju = pomFiltriranoPoPolju.Replace("D.", "")

                        Call ZaProveru(pomOD, t.Item("polje"), pomTip, pomDuzina)
                        'polazim od toga da nije FP (tj da je izraz prazan)
                        DDL = False : combo = False : FP = False : ACE = False : FK = False : chbox = False : rblist = False
                        izraz = ""
                        izraz = CStr(t.Item("izraz")).Trim 'zamena GGGMMM u izrazu
                        izraz = ZameniGGGMMMSimple(izraz, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))

                        If CStr(t.Item("relTabela")).Trim <> "" Then 'DDL
                            DDL = True : combo = False : FP = False : ACE = False : FK = False : chbox = False : rblist = False
                        End If
                        If izraz.Length > 0 Then 'FP ili CBO ili ACE ili FK ili RB ili CHB
                            If izraz.Substring(0, 2) = "CB" Then
                                If izraz.Trim.ToUpper.Substring(0, 3) = "CBW" Then 'COMBOBOX
                                    combo = True : DDL = False : FP = False : ACE = False : FK = False : chbox = False : rblist = False
                                ElseIf izraz.Trim.ToUpper.Substring(0, 3) = "CBO" Then 'ACE
                                    ACE = True : DDL = False : combo = False : FP = False : FK = False : chbox = False : rblist = False
                                End If
                            End If
                            If izraz.Trim.Length > 8 AndAlso izraz.Trim.ToUpper.Substring(0, 8) = "CHECKBOX" Then 'checkbox
                                ACE = False : DDL = False : combo = False : FP = False : FK = False : chbox = True : rblist = False
                            End If
                            If izraz.Trim.Length > 11 AndAlso izraz.Trim.ToUpper.Substring(0, 11) = "RADIOBUTTON" Then 'radiobutton
                                ACE = False : DDL = False : combo = False : FP = False : FK = False : chbox = False : rblist = True
                            End If
                            If izraz.Trim.ToUpper.IndexOf(":PK}") > 0 Then 'FK
                                ACE = False : DDL = False : combo = False : FP = False : FK = True : chbox = False : rblist = False
                            End If
                            If izraz.Trim.ToUpper.Substring(0, 1) <> "C" AndAlso izraz.Trim.ToUpper.Substring(0, 1) <> "R" AndAlso izraz.IndexOf(":PK}") < 0 Then 'FP
                                ACE = False : DDL = False : combo = False : FP = True : FK = False : chbox = False : rblist = False
                                If izraz.Substring(0, 1) = "'" Then
                                    izraz = izraz.Replace("'", "")
                                Else
                                    izraz = ""
                                End If
                            End If
                        End If

                        upitCBO = "" : upitACE = "" : upitDDL = "" : upitFK = ""

                        If combo = True Then
                            ' CBW je višeg nivoa od relacije
                            'CBW{IZVOR=select * from vISTOpstineUnos;PRIKAZI=nazivLOps;UBAZU=mbops}
                            'CBW{IZVOR=select * from vISTNaseljeUnos;FILTER=mbops=d.opsLok;PRIKAZI=nazivLNas;UBAZU=mbnas}
                            Dim dt As New System.Data.DataTable
                            Dim izvorCBO As String = ""
                            Dim prikaziCBO As String = ""
                            Dim upisiCBO As String = ""
                            Dim prenesiCBO As String = ""
                            Dim filterCBO1 As String = ""
                            izraz = izraz.Replace("CBW{", "")
                            izraz = izraz.Substring(0, izraz.Length - 1)
                            Dim nizCB As String() = Microsoft.VisualBasic.Split(izraz, ";")
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
                                    filter = True
                                    filterCBO1 = nizCB(ii).Replace("FILTER=", "")
                                End If
                                If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                                    izvorCBO = nizCB(ii).Replace("DATASOURCE=", "")
                                End If
                                If nizCB(ii).Trim.ToUpper.IndexOf("DISPLAYMEMBER=") >= 0 Then
                                    prikaziCBO = nizCB(ii).Replace("DISPLAYMEMBER=", "")
                                End If
                                If nizCB(ii).Trim.ToUpper.IndexOf("VALUEMEMBER=") >= 0 Then
                                    upisiCBO = nizCB(ii).Replace("VALUEMEMBER=", "")
                                End If
                            Next
                            Dim sqlFilter As String = "2=2"
                            upitCBO = izvorCBO
                            filterCBO = filterCBO1
                            relPolje = upisiCBO + ", " + prikaziCBO
                        ElseIf ACE = True Then
                            'CBO je višeg nivoa od relacije
                            'CBO{IZVOR=select * from vISTOpstineUnos;PRIKAZI=nazivLOps;UBAZU=mbops}
                            'CBO{IZVOR=select * from vISTNaseljeUnos;FILTER=mbops=d.opsLok;PRIKAZI=nazivLNas;UBAZU=mbnas}
                            Dim dt As New System.Data.DataTable
                            Dim izvorACE As String = ""
                            Dim prikaziACE As String = ""
                            Dim upisiACE As String = ""
                            Dim prenesiACE As String = ""
                            Dim filterACE1 As String = ""
                            izraz = izraz.Replace("CBO{", "")
                            izraz = izraz.Substring(0, izraz.Length - 1)
                            Dim nizAC As String() = Microsoft.VisualBasic.Split(izraz, ";")
                            For ii As Integer = 0 To nizAC.GetUpperBound(0)
                                If nizAC(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                                    izvorACE = nizAC(ii).Replace("IZVOR=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("PRIKAZI=") >= 0 Then
                                    prikaziACE = nizAC(ii).Replace("PRIKAZI=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("UBAZU=") >= 0 Then
                                    upisiACE = nizAC(ii).Replace("UBAZU=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                                    filter = True
                                    filterACE1 = nizAC(ii).Replace("FILTER=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                                    izvorACE = nizAC(ii).Replace("DATASOURCE=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("DISPLAYMEMBER=") >= 0 Then
                                    prikaziACE = nizAC(ii).Replace("DISPLAYMEMBER=", "")
                                End If
                                If nizAC(ii).Trim.ToUpper.IndexOf("VALUEMEMBER=") >= 0 Then
                                    upisiACE = nizAC(ii).Replace("VALUEMEMBER=", "")
                                End If
                            Next
                            Dim sqlFilter As String = "2=2"
                            upitACE = izvorACE
                            filterACE = filterACE1
                        ElseIf DDL = True Then
                            upitDDL = t.Item("upit").ToString.Trim
                            nazivZaDDL = t.Item("uslov").ToString.Trim
                            dodela = t.Item("dodela").ToString.Trim
                        ElseIf FK = True Then
                            upitFK = izraz.Replace("#{", "").Replace(":PK", "").Replace("}", "")
                        ElseIf chbox = True Then
                            Dim p() As String = imeWeb.Split("_")
                            grupaCHB = p(0).Replace("CH", "")
                            imeWeb = "CH_" + p(1)
                            'sb.Append("<asp:CheckBox ID='" + imeWeb + "' runat='server' AutoPostBack='true' />")
                            'ElseIf rblist = True Then
                            'Dim p() As String = imeWeb.Split("_")
                            'grupaCHB = p(0).Replace("RBG", "")
                            'imeWeb = "RBG_" + p(1)
                            'sb.Append("<asp:CheckBox ID='" + imeWeb + "' runat='server' AutoPostBack='true' />")
                        End If

                        opis = CStr(t.Item("izrazFP")).Trim.Replace(";", ",")
                        opisNadLBL = CStr(t.Item("opisNadLBL")).Trim
                        opisLAB = CStr(t.Item("opisLAB")).Trim
                        opisBOLD = CStr(t.Item("boldLabela")).Trim.ToUpper
                        Dim kako As String = "IST11R"
                        If opisBOLD = "B" Then kako = "IST11RB"
                        'tabelice
                        If forma.IndexOf(".") < 0 Then
                            'NEMA TABELICA - imam samo labelu i polje
                            i = i + 1
                            ReDim Preserve niz(i)
                            ReDim Preserve nizWebStr(i) : nizWebStr(i) = webstr
                            ReDim Preserve nizEndOfWebStr(i) : nizEndOfWebStr(i) = endofwebstr
                            ReDim Preserve nizdivDisplayNone(i) : nizdivDisplayNone(i) = divDisplayNone
                            ReDim Preserve nizEndOfdiv(i) : nizEndOfdiv(i) = EndOfdiv

                            If imeWeb.Substring(0, 1) = "H" Then   'tj nije samo $
                                niz(i) = "<td class=" + nvd + kako + nvd + ">" + dajLiteral(False, opis, "HIT_" + imeUBazi, opisBOLD)
                            ElseIf imeWeb.Substring(0, 1) = "N" Then  '(naslovLBL)
                                niz(i) = "<td class=" + nvd + kako + nvd + ">" + dajLiteral(False, opis, "naslovLIT_" + imeUBazi, opisBOLD)
                            ElseIf imeWeb.Substring(0, 2) = "FK" Then  '(FK)
                                niz(i) = "<td class=" + nvd + kako + nvd + ">" + dajLiteral(False, opisLAB, "LIT_" + imeUBazi, opisBOLD)
                            ElseIf rblist = True Then
                                niz(i) = "<td class=" + nvd + kako + nvd + ">" + dajLiteralRBG(False, opisLAB, izraz, "LIT_" + imeUBazi, opisBOLD)
                            Else
                                niz(i) = "<td class=" + nvd + kako + nvd + ">" + dajLiteral(False, opisLAB, "LIT_" + imeUBazi, opisBOLD)
                            End If

                            If CInt(vs) > 999 Then vs = "999"
                            If FP = True Then
                                If CStr(t.Item("prvoUFormi")).Trim = "1" And imeWeb.Substring(0, 1) <> "N" Then
                                    niz(i) = "<td class=" + nvd + kako + nvd + ">" + dajLiteral(False, opis, "LIT_" + imeUBazi, opisBOLD)
                                ElseIf CStr(t.Item("prvoUFormi")).Trim = "1" And imeWeb.Substring(0, 1) = "N" Then
                                    niz(i) = "<td class=" + nvd + kako + nvd + ">" + dajLiteral(False, opis, "naslovLIT_" + imeUBazi, opisBOLD)
                                Else
                                    niz(i) = niz(i) + dajFP(False, izraz, "FP1_" + imeUBazi, "-1", vs)
                                End If
                            Else
                                If upitDDL.Trim.Length > 0 Then
                                    If RequiredF = True Then niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                    niz(i) = niz(i) + dajACE(imetab, False, "", "", imeWeb, tabIndex, vs)
                                    ACEovi = ACEovi + CStr(t.Item("imeWeb")).Trim + ";"
                                    ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim + ";"
                                    ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim + ";"
                                    ACETabela = ACETabela + CStr(t.Item("relTabela")).Trim + ";"
                                    ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                                    ACEUBazu = ACEUBazu + CStr(t.Item("relPolje")).Trim + ";"
                                    ACEPrikazi = ACEPrikazi + CStr(t.Item("relPolje")).Trim + ";"
                                    sqlACEovi = sqlACEovi + upitACE + ";"
                                    dodelaVBizLK = dodelaVBizLK + dodela + ";"
                                    nazivPolja = nazivPolja + imeWeb + ";"
                                ElseIf upitACE.Trim.Length > 0 Then 'CBO u IST-u, ACE na web-u
                                    If RequiredF = True Then niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                    ACEovi = ACEovi + CStr(t.Item("imeWeb")).Trim + ";"
                                    ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim + ";"
                                    ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim + ";"
                                    ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                                    ACETabela = ACETabela + CStr(t.Item("CBOTabela")).Trim + ";"
                                    ACEUBazu = ACEUBazu + CStr(t.Item("CBOuBazu")).Trim + ";"
                                    ACEPrikazi = ACEPrikazi + CStr(t.Item("CBOPrikazi")).Trim + ";"
                                    ACEFiltriranoPolje = ACEFiltriranoPolje + CStr(t.Item("FiltriranoPolje")).Trim.ToUpper + ";"
                                    ACEFiltriranoPoPolju = ACEFiltriranoPoPolju + CStr(t.Item("FiltriranoPoPolju")).Trim.ToUpper + ";"
                                    sqlACEovi = sqlACEovi + upitACE + ";"
                                    ACEfilter = ACEfilter + CStr(t.Item("CBOFilter")).Trim.ToUpper + ";"
                                    nazivPolja = nazivPolja + imeWeb + ";"
                                    If pomFiltriranoPolje = "1" Then
                                        niz(i) = niz(i) + dajACEFilter(imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vs)
                                    Else 'NEMA update panela
                                        niz(i) = niz(i) + dajACE(imetab, False, "", "", imeWeb, tabIndex, vs)
                                    End If
                                    dodelaVBizLK = dodelaVBizLK + dodela + ";"
                                ElseIf upitCBO.Trim.Length > 0 Then 'CBO u IST-u i na web-u
                                    If RequiredF = True Then niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb)
                                    CBOovi = CBOovi + CStr(t.Item("imeWeb")).Trim + ";"
                                    sqlCBOovi = sqlCBOovi + upitCBO + ";"
                                    filterCBOovi = filterCBOovi + filterCBO + ";"
                                    CBOUBazu = CBOUBazu + CStr(t.Item("CBOUBazu")).Trim.ToUpper + ";"
                                    CBOPrikazi = CBOPrikazi + CStr(t.Item("CBOprikazi")).Trim.ToUpper + ";"
                                    nazivPolja = nazivPolja + imeWeb + ";"
                                    If pomFiltriranoPolje = "1" Then
                                        niz(i) = niz(i) + dajCBO(False, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vs)
                                    ElseIf ZaUpdatePanel(imetab, imeUBazi) <> "" Then
                                        pomFiltriranoPoPolju = ZaUpdatePanel(imetab, imeUBazi)
                                        niz(i) = niz(i) + dajCBO(False, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vs)
                                    Else 'bez update panela
                                        niz(i) = niz(i) + dajCBO(False, imetab, False, "", "", imeWeb, tabIndex, vs)
                                    End If
                                ElseIf upitFK.Trim.Length > 0 Then
                                    niz(i) = niz(i) + dajFPright(False, "", "FK_" + imeUBazi, "-1", vs)

                                ElseIf chbox = True Then
                                    If RequiredF = True Then niz(i) = niz(i) + dajRequiredFieldValidator(imeWeb)
                                    nazivPolja = nazivPolja + imeWeb + ";"
                                    niz(i) = niz(i) + dajCHPolje("", imeWeb, tabIndex, grupaCHB)

                                    'ElseIf rblist = True Then
                                    'If RequiredF = True Then niz(i) = niz(i) + dajRequiredFieldValidator(imeWeb)
                                    'nazivPolja = nazivPolja + imeWeb + ";"
                                    'niz(i) = niz(i) + dajRBLPolje("", imeWeb, tabIndex, vs, izraz, maxL)

                                Else
                                    If RegExV = True Then niz(i) = niz(i) + dajRegularExpressionValidator(imeWeb, minL)
                                    If RangeV = True Then niz(i) = niz(i) + dajRangeValidator(imeWeb, minV, maxV, tipRV)
                                    If funkcijaDa = True Or funkcijaNe = True Then
                                        Call spremiJS(imeWeb, nnizneV, nnizdaV)
                                        Call spremiVB(imeWeb, nnizneV, nnizdaV)
                                        niz(i) = niz(i) + dajCustomValidator(imeWeb)
                                    End If
                                    If RequiredF = True Then niz(i) = niz(i) + dajRequiredFieldValidator(imeWeb)
                                    nazivPolja = nazivPolja + imeWeb + ";"
                                    If rblist = False AndAlso ZaUpdatePanel(imetab, imeUBazi) <> "" Then
                                        pomFiltriranoPoPolju = ZaUpdatePanel(imetab, imeUBazi)
                                        niz(i) = niz(i) + dajFilterPolje(False, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vs, dozvoljeno, maxL)
                                    Else
                                        niz(i) = niz(i) + dajFilterPolje(False, imetab, False, "", "", imeWeb, tabIndex, vs, dozvoljeno, maxL)
                                    End If
                                End If
                            End If
                        Else 'IMA TABELICA
                            'da li je ova forma vec bila u okviru tabele, ako jeste onda preskakati jer su to podvucena polja koja verovatno nisu prava
                            If pamtiFormu.IndexOf("$" + forma + "$") < 0 Then 'nije vec bila ova forma
                                pamtiFormu = pamtiFormu + "$" + forma + "$"
                                ''
                                Dim vvss As String = Microsoft.VisualBasic.Split(nizTabelice(f1)(f2)(f3), "ˇ")(2)
                                sta = "~" + Microsoft.VisualBasic.Mid(forma, 1, forma.Trim.LastIndexOf(".") + 1) + "~"
                                Dim tTabelica As Integer = CInt(f1.Trim)
                                If pamtiTabelica <> tTabelica Then
                                    prvi = True
                                    pamtiTabelica = tTabelica
                                Else
                                    prvi = False
                                End If

                                Dim postoji As Boolean = False
                                Dim dod As Boolean = False
                                Dim pravoTabelice As String = ""
                                Dim labOpis As String = ""
                                If niz.Length > 0 Then
                                    For j As Integer = 0 To niz.GetUpperBound(0)
                                        If niz(j).IndexOf(sta) >= 0 Then
                                            postoji = True
                                            If FP = True Then
                                                niz(j) = niz(j) + dajLiteral(False, izraz, "LITFP2_" + imeUBazi, opisBOLD)
                                                pravoTabelice = pravoTabelice + dajLiteral(False, izraz, "LITFP2_" + imeUBazi, opisBOLD)
                                                If izraz = "" Then nizTabelice(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                                dod = True
                                            End If
                                            labOpis = ""
                                            'LABELA IZ OPISA...
                                            'ako je hidden polje to znaci da ga ima vise puta u tabelici
                                            If imeWeb.Substring(0, 1) = "H" Then
                                                'ne menjam  nizLab(f1)(f2)(f3)
                                            ElseIf imeWeb.Substring(0, 1) = "N" Then   '(naslovLBL)
                                                If dod = False Then labOpis = dajLiteral(False, opis, "LITIZM_" + imeUBazi, opisBOLD)
                                                If labOpis = "" Then nizLab(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"

                                            ElseIf rblist = True Then
                                                If izraz.Trim <> "" Then
                                                    labOpis = dajLiteralRBG(False, opisLAB, izraz, "LITIZM_" + imeUBazi, opisBOLD)
                                                End If
                                                If labOpis = "" Then nizLab(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                            Else
                                                If opis.Trim <> "" Then
                                                    labOpis = dajLiteral(False, opis, "LITIZM_" + imeUBazi, opisBOLD)
                                                End If
                                                If labOpis = "" Then nizLab(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                            End If

                                            If FP = False Then
                                                'prop
                                                If upitDDL.Trim.Length > 0 Then
                                                    If RequiredF = True Then
                                                        niz(j) = niz(j) + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL")) 'dajRequiredFieldValidatorDDL("DP_" + imeUBazi)
                                                        pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL")) 'dajRequiredFieldValidatorDDL("DP_" + imeUBazi)
                                                    End If
                                                    niz(j) = niz(j) + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                                    pravoTabelice = pravoTabelice + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                                    ACEovi = ACEovi + imeWeb + ";"
                                                    ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim + ";"
                                                    ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim + ";"
                                                    ACETabela = ACETabela + CStr(t.Item("relTabela")).Trim + ";"
                                                    ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                                                    ACEUBazu = ACEUBazu + CStr(t.Item("relPolje")).Trim + ";"
                                                    ACEPrikazi = ACEPrikazi + CStr(t.Item("relPolje")).Trim + ";"
                                                    sqlACEovi = sqlACEovi + upitACE + ";"
                                                    dodelaVBizLK = dodelaVBizLK + dodela + ";"
                                                    nazivPolja = nazivPolja + imeWeb + ";"
                                                ElseIf upitACE.Trim.Length > 0 Then
                                                    If RequiredF = True Then
                                                        niz(j) = niz(j) + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                                        pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                                    End If
                                                    ACEovi = ACEovi + imeWeb + ";"
                                                    ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim + ";"
                                                    ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim + ";"
                                                    ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                                                    ACETabela = ACETabela + CStr(t.Item("CBOTabela")).Trim + ";"
                                                    ACEUBazu = ACEUBazu + CStr(t.Item("CBOuBazu")).Trim + ";"
                                                    ACEPrikazi = ACEPrikazi + CStr(t.Item("CBOPrikazi")).Trim + ";"
                                                    ACEFiltriranoPolje = ACEFiltriranoPolje + CStr(t.Item("FiltriranoPolje")).Trim.ToUpper + ";"
                                                    ACEFiltriranoPoPolju = ACEFiltriranoPoPolju + CStr(t.Item("FiltriranoPoPolju")).Trim.ToUpper + ";"
                                                    sqlACEovi = sqlACEovi + upitACE + ";"
                                                    ACEfilter = ACEfilter + CStr(t.Item("CBOFilter")).Trim.ToUpper + ";"
                                                    nazivPolja = nazivPolja + imeWeb + ";"
                                                    If pomFiltriranoPolje = "1" Then
                                                        niz(j) = niz(j) + dajACEFilter(imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                        pravoTabelice = pravoTabelice + dajACEFilter(imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                    Else 'NEMA update panela
                                                        niz(j) = niz(j) + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                                        pravoTabelice = pravoTabelice + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                                    End If
                                                    dodelaVBizLK = dodelaVBizLK + dodela + ";"
                                                ElseIf upitCBO.Trim.Length > 0 Then
                                                    If RequiredF = True Then
                                                        niz(j) = niz(j) + dajRequiredFieldValidatorDDL(imeWeb)
                                                        pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb)
                                                    End If
                                                    CBOovi = CBOovi + imeWeb + ";"
                                                    sqlCBOovi = sqlCBOovi + upitCBO + ";"
                                                    filterCBOovi = filterCBOovi + filterCBO + ";"
                                                    CBOUBazu = CBOUBazu + CStr(t.Item("CBOUBazu")).Trim.ToUpper + ";"
                                                    CBOPrikazi = CBOPrikazi + CStr(t.Item("CBOprikazi")).Trim.ToUpper + ";"
                                                    nazivPolja = nazivPolja + imeWeb + ";"
                                                    If pomFiltriranoPolje = "1" Then
                                                        'prop
                                                        niz(j) = niz(j) + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                        pravoTabelice = pravoTabelice + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                    ElseIf ZaUpdatePanel(imetab, imeUBazi) <> "" Then
                                                        pomFiltriranoPoPolju = ZaUpdatePanel(imetab, imeUBazi)
                                                        niz(j) = niz(j) + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                        pravoTabelice = pravoTabelice + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                    Else 'bez update panela
                                                        niz(j) = niz(j) + dajCBO(True, imetab, False, "", "", CStr(t.Item("imeWeb")).Trim, tabIndex, vvss)
                                                        pravoTabelice = pravoTabelice + dajCBO(True, imetab, False, "", "", CStr(t.Item("imeWeb")).Trim, tabIndex, vvss)
                                                    End If
                                                ElseIf upitFK.Trim.Length > 0 Then
                                                    niz(j) = niz(j) + dajFPright(False, "", "FK_" + imeUBazi, "-1", vs)
                                                    pravoTabelice = pravoTabelice + dajFPright(False, "", "FK_" + imeUBazi, "-1", vs)

                                                ElseIf chbox = True Then
                                                    If RequiredF = True Then
                                                        niz(j) = niz(j) + dajRequiredFieldValidatorDDL(imeWeb)
                                                        pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb)
                                                    End If
                                                    nazivPolja = nazivPolja + imeWeb + ";"
                                                    pravoTabelice = pravoTabelice + dajCHPolje("", imeWeb, tabIndex, grupaCHB)
                                                    'ElseIf rblist = True Then
                                                    '    If RequiredF = True Then
                                                    '        niz(j) = niz(j) + dajRequiredFieldValidatorDDL(imeWeb)
                                                    '        pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb)
                                                    '    End If
                                                    '    nazivPolja = nazivPolja + imeWeb + ";"
                                                    '    niz(j) = niz(j) + dajRBLPolje("", imeWeb, tabIndex, vs, izraz, maxL)
                                                    '    pravoTabelice = pravoTabelice + dajRBLPolje("", imeWeb, tabIndex, vs, izraz, maxL)
                                                Else
                                                    If RegExV = True Then
                                                        niz(j) = niz(j) + dajRegularExpressionValidator(imeWeb, minL)
                                                        pravoTabelice = pravoTabelice + dajRegularExpressionValidator(imeWeb, minL)
                                                    End If
                                                    If RangeV = True Then
                                                        niz(j) = niz(j) + dajRangeValidator(imeWeb, minV, maxV, tipRV)
                                                        pravoTabelice = pravoTabelice + dajRangeValidator(imeWeb, minV, maxV, tipRV)
                                                    End If
                                                    If funkcijaDa = True Or funkcijaNe = True Then
                                                        Call spremiJS(imeWeb, nnizneV, nnizdaV)
                                                        Call spremiVB(imeWeb, nnizneV, nnizdaV)
                                                        niz(j) = niz(j) + dajCustomValidator(imeWeb)
                                                        pravoTabelice = pravoTabelice + dajCustomValidator(imeWeb)
                                                    End If

                                                    If RequiredF = True Then
                                                        niz(j) = niz(j) + dajRequiredFieldValidator(imeWeb)
                                                        pravoTabelice = pravoTabelice + dajRequiredFieldValidator(imeWeb)
                                                    End If
                                                    nazivPolja = nazivPolja + imeWeb + ";"
                                                    'prop
                                                    If rblist = False AndAlso ZaUpdatePanel(imetab, imeUBazi) <> "" Then
                                                        pomFiltriranoPoPolju = ZaUpdatePanel(imetab, imeUBazi)
                                                        niz(j) = niz(j) + dajFilterPolje(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                                        pravoTabelice = pravoTabelice + dajFilterPolje(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                                    Else
                                                        niz(j) = niz(j) + dajFilterPolje(True, imetab, False, "", "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                                        pravoTabelice = pravoTabelice + dajFilterPolje(True, imetab, False, "", "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                                    End If
                                                End If
                                            End If
                                        End If
                                    Next
                                End If

                                Dim nadlabela As Boolean = False

                                If postoji = False Then
                                    'NE POSTOJI RED, TEK GA SAD ISPISUJEMO PRVI PUT
                                    i = i + 1
                                    ReDim Preserve niz(i)
                                    ReDim Preserve nizWebStr(i) : nizWebStr(i) = webstr
                                    ReDim Preserve nizEndOfWebStr(i) : nizEndOfWebStr(i) = endofwebstr
                                    ReDim Preserve nizdivDisplayNone(i) : nizdivDisplayNone(i) = divDisplayNone
                                    ReDim Preserve nizEndOfdiv(i) : nizEndOfdiv(i) = EndOfdiv

                                    'LABELA (prva kolona)
                                    niz(i) = sta

                                    If FP = True Then
                                        If CStr(t.Item("prvoUFormi")).Trim = "1" And imeWeb.Substring(0, 1) = "H" Then
                                            niz(i) = niz(i) + dajLiteral(False, izraz, "HIT_" + imeUBazi, opisBOLD)
                                            pravoTabelice = pravoTabelice + dajLiteral(False, izraz, "LITFP_" + imeUBazi, opisBOLD)
                                            'dod = True
                                        ElseIf CStr(t.Item("prvoUFormi")).Trim = "1" And imeWeb.Substring(0, 1) = "N" Then  '(naslovLBL)
                                            niz(i) = niz(i) + dajLiteral(False, izraz, "naslovLIT_" + imeUBazi, opisBOLD)
                                            pravoTabelice = pravoTabelice + dajLiteral(False, izraz, "naslovLITFP_" + imeUBazi, opisBOLD)
                                            'dod = True
                                        Else
                                            niz(i) = niz(i) + dajFP(True, izraz, "FP3_" + imeUBazi, "-1", vvss)
                                            pravoTabelice = pravoTabelice + dajLiteral(False, izraz, "LITFP3_" + imeUBazi, opisBOLD)
                                            If izraz = "" Then nizTabelice(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                        End If
                                    End If

                                    Dim vvssLab As String = Microsoft.VisualBasic.Split(nizTabelice(f1)(0)(1), "ˇ")(2)
                                    labOpis = ""

                                    'hidden polje nikada ne moze da bude prvo!!
                                    If imeWeb.Substring(0, 1) = "N" Then  '(naslovLBL)
                                        'If dod = False Then
                                        If opisLAB <> "" Then labOpis = dajLiteral(False, opisLAB, "naslovLIT_" + imeUBazi, opisBOLD)
                                    ElseIf rblist = True Then
                                        If opisLAB <> "" Then
                                            labOpis = dajLiteralRBG(False, opisLAB, izraz, "LIT_" + imeUBazi, opisBOLD)
                                        End If
                                    Else
                                        If opisLAB <> "" Then
                                            labOpis = dajLiteral(False, opisLAB, "LIT_" + imeUBazi, opisBOLD)
                                        End If
                                    End If
                                    If labOpis = "" Then nizLab(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                    'LABELA IZ OPISA...

                                    If FP = False Then
                                        If upitDDL.Trim.Length > 0 Then
                                            If RequiredF = True Then
                                                niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                                pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                            End If
                                            niz(i) = niz(i) + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                            pravoTabelice = pravoTabelice + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                            ACEovi = ACEovi + imeWeb + ";"
                                            ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim + ";"
                                            ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim + ";"
                                            ACETabela = ACETabela + CStr(t.Item("relTabela")).Trim + ";"
                                            ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                                            ACEUBazu = ACEUBazu + CStr(t.Item("relPolje")).Trim + ";"
                                            ACEPrikazi = ACEPrikazi + CStr(t.Item("relPolje")).Trim + ";"
                                            sqlACEovi = sqlACEovi + upitACE + ";"
                                            dodelaVBizLK = dodelaVBizLK + dodela + ";"
                                            nazivPolja = nazivPolja + imeWeb + ";"
                                        ElseIf upitACE.Trim.Length > 0 Then
                                            If RequiredF = True Then
                                                niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                                pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb.Replace("_", "_LAZNIDDL"))
                                            End If
                                            ACEovi = ACEovi + imeWeb + ";"
                                            ACEtipPolja = ACEtipPolja + CStr(t.Item("tippolja")).Trim + ";"
                                            ACEpravaBaza = ACEpravaBaza + CStr(t.Item("pravaBaza")).Trim + ";"
                                            ACERelTabela = ACERelTabela + CStr(t.Item("RelTabela")).Trim.ToUpper + ";"
                                            ACETabela = ACETabela + CStr(t.Item("CBOTabela")).Trim + ";"
                                            ACEUBazu = ACEUBazu + CStr(t.Item("CBOuBazu")).Trim + ";"
                                            ACEPrikazi = ACEPrikazi + CStr(t.Item("CBOPrikazi")).Trim + ";"
                                            ACEFiltriranoPolje = ACEFiltriranoPolje + CStr(t.Item("FiltriranoPolje")).Trim.ToUpper + ";"
                                            ACEFiltriranoPoPolju = ACEFiltriranoPoPolju + CStr(t.Item("FiltriranoPoPolju")).Trim.ToUpper + ";"
                                            sqlACEovi = sqlACEovi + upitACE + ";"
                                            ACEfilter = ACEfilter + CStr(t.Item("CBOFilter")).Trim.ToUpper + ";"
                                            nazivPolja = nazivPolja + imeWeb + ";"
                                            If pomFiltriranoPolje = "1" Then
                                                'prop
                                                niz(i) = niz(i) + dajACEFilter(imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                pravoTabelice = pravoTabelice + dajACEFilter(imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                            Else 'NEMA update panela
                                                niz(i) = niz(i) + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                                pravoTabelice = pravoTabelice + dajACE(imetab, False, "", "", imeWeb, tabIndex, vvss)
                                            End If
                                            dodelaVBizLK = dodelaVBizLK + dodela + ";"
                                        ElseIf upitCBO.Trim.Length > 0 Then
                                            If RequiredF = True Then
                                                niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb)
                                                pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb)
                                            End If
                                            CBOovi = CBOovi + imeWeb + ";"
                                            sqlCBOovi = sqlCBOovi + upitCBO + ";"
                                            filterCBOovi = filterCBOovi + filterCBO + ";"
                                            CBOUBazu = CBOUBazu + CStr(t.Item("CBOUBazu")).Trim.ToUpper + ";"
                                            CBOPrikazi = CBOPrikazi + CStr(t.Item("CBOprikazi")).Trim.ToUpper + ";"
                                            nazivPolja = nazivPolja + imeWeb + ";"
                                            If pomFiltriranoPolje = "1" Then
                                                'prop
                                                niz(i) = niz(i) + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                pravoTabelice = pravoTabelice + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                            ElseIf ZaUpdatePanel(imetab, imeUBazi) <> "" Then
                                                pomFiltriranoPoPolju = ZaUpdatePanel(imetab, imeUBazi)
                                                niz(i) = niz(i) + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                                pravoTabelice = pravoTabelice + dajCBO(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss)
                                            Else 'bez update panela
                                                niz(i) = niz(i) + dajCBO(True, imetab, False, "", "", imeWeb, tabIndex, vvss)
                                                pravoTabelice = pravoTabelice + dajCBO(True, imetab, False, "", "", imeWeb, tabIndex, vvss)
                                            End If
                                        ElseIf upitFK.Trim.Length > 0 Then
                                            niz(i) = niz(i) + dajFPright(True, "", "FK_" + imeUBazi, "-1", vvss)
                                            pravoTabelice = pravoTabelice + dajFPright(True, "", "FK_" + imeUBazi, "-1", vvss)
                                            If izraz = "" Then nizTabelice(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                        ElseIf chbox = True Then
                                            If RequiredF = True Then
                                                niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb)
                                                pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb)
                                            End If
                                            nazivPolja = nazivPolja + imeWeb + ";"
                                            niz(i) = niz(i) + dajCHPolje("", imeWeb, tabIndex, grupaCHB)
                                            pravoTabelice = pravoTabelice + dajCHPolje("", imeWeb, tabIndex, grupaCHB)
                                            'If izraz = "" Then
                                            nizTabelice(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                            'ElseIf rblist = True Then
                                            '    If RequiredF = True Then
                                            '        niz(i) = niz(i) + dajRequiredFieldValidatorDDL(imeWeb)
                                            '        pravoTabelice = pravoTabelice + dajRequiredFieldValidatorDDL(imeWeb)
                                            '    End If
                                            '    nazivPolja = nazivPolja + imeWeb + ";"
                                            '    niz(i) = niz(i) + dajRBLPolje("", imeWeb, tabIndex, vs, izraz, maxL)
                                            '    pravoTabelice = pravoTabelice + dajRBLPolje("", imeWeb, tabIndex, vs, izraz, maxL)
                                            '    nizTabelice(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                                        Else
                                            If RegExV = True Then
                                                niz(i) = niz(i) + dajRegularExpressionValidator(imeWeb, minL)
                                                pravoTabelice = pravoTabelice + dajRegularExpressionValidator(imeWeb, minL)
                                            End If
                                            If RangeV = True Then
                                                niz(i) = niz(i) + dajRangeValidator(imeWeb, minV, maxV, tipRV)
                                                pravoTabelice = pravoTabelice + dajRangeValidator(imeWeb, minV, maxV, tipRV)
                                            End If
                                            If funkcijaDa = True Or funkcijaNe = True Then
                                                Call spremiJS(imeWeb, nnizneV, nnizdaV)
                                                Call spremiVB(imeWeb, nnizneV, nnizdaV)
                                                niz(i) = niz(i) + dajCustomValidator(imeWeb)
                                                pravoTabelice = pravoTabelice + dajCustomValidator(imeWeb)
                                            End If
                                            If RequiredF = True Then
                                                niz(i) = niz(i) + dajRequiredFieldValidator(imeWeb)
                                                pravoTabelice = pravoTabelice + dajRequiredFieldValidator(imeWeb)
                                            End If
                                            nazivPolja = nazivPolja + imeWeb + ";"
                                            'prop
                                            If rblist = False AndAlso ZaUpdatePanel(imetab, imeUBazi) <> "" Then
                                                pomFiltriranoPoPolju = ZaUpdatePanel(imetab, imeUBazi)
                                                niz(i) = niz(i) + dajFilterPolje(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                                pravoTabelice = pravoTabelice + dajFilterPolje(True, imetab, True, pomFiltriranoPoPolju, "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                            Else
                                                niz(i) = niz(i) + dajFilterPolje(True, imetab, False, "", "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                                pravoTabelice = pravoTabelice + dajFilterPolje(True, imetab, False, "", "", imeWeb, tabIndex, vvss, dozvoljeno, maxL)
                                            End If
                                        End If
                                    End If
                                End If  'PRVI PUT RED

                                Dim d0L As String = Microsoft.VisualBasic.Split(nizLab(f1)(f2)(f3), "ˇ")(0)
                                Dim d1L As String = Microsoft.VisualBasic.Split(nizLab(f1)(f2)(f3), "ˇ")(1)
                                Dim d2L As String = Microsoft.VisualBasic.Split(nizLab(f1)(f2)(f3), "ˇ")(2)

                                Dim d0 As String = Microsoft.VisualBasic.Split(nizTabelice(f1)(f2)(f3), "ˇ")(0)
                                Dim d1 As String = Microsoft.VisualBasic.Split(nizTabelice(f1)(f2)(f3), "ˇ")(1)
                                Dim d2 As String = Microsoft.VisualBasic.Split(nizTabelice(f1)(f2)(f3), "ˇ")(2)

                                nizLab(f1)(f2)(f3) = d0L + "ˇ" + d1L + "ˇ" + d2L + "ˇ" + labOpis
                                If imeWeb.Substring(0, 1) = "H" Then
                                    nizTabelice(f1)(f2)(f3) = d0.Replace("UBACENO", "HP") + "ˇ" + d1 + "ˇ" + d2 + "ˇ" + pravoTabelice
                                Else
                                    nizTabelice(f1)(f2)(f3) = d0 + "ˇ" + d1 + "ˇ" + d2 + "ˇ" + pravoTabelice
                                End If
                            End If 'nije bila forma
                        End If 'IMA TABELICA
                    End If 'nije kljuc
                Else
                    pamtiFormu = ""
                End If 'u okviru tabele
            Next 'OD POLJA


            'GOTOVO
            'u niz treba ubaciti na odgovarajuca mesta podtabele ili PANELE
            Dim gdePodtabela As Integer = 0
            Dim gdeUbaciti As Integer = 0
            Dim kojaPodtabela As String = ""
            Dim panelPodtabela As String = ""
            If nizPodtabele.Length > 0 Then
                For kk As Integer = 0 To nizPodtabele.GetUpperBound(0)
                    gdePodtabela = Microsoft.VisualBasic.Split(nizPodtabele(kk), "ˇ")(1)
                    kojaPodtabela = Microsoft.VisualBasic.Split(nizPodtabele(kk), "ˇ")(0)
                    panelPodtabela = Microsoft.VisualBasic.Split(nizPodtabele(kk), "ˇ")(2)
                    Dim grid As String = panelPodtabela.Trim + "GRID"
                    ReDim Preserve niz(niz.Length)
                    If gdePodtabela > 0 Then
                        For i = 0 To niz.GetUpperBound(0)
                            If niz(i) Is Nothing Then
                                niz(niz.Length - 1) = grid.Trim + kojaPodtabela
                            ElseIf niz(i).Substring(0, 1) = "~" Then
                                If CInt(niz(i).Substring(1, niz(i).IndexOf(".") - 1)) < gdePodtabela Then
                                Else
                                    gdeUbaciti = i
                                    For mm As Integer = niz.Length - 2 To gdeUbaciti Step -1
                                        niz(mm + 1) = niz(mm)
                                    Next
                                    niz(gdeUbaciti) = grid.Trim + kojaPodtabela
                                    Exit For
                                End If
                            End If
                        Next
                    Else
                        'OVE IDU NA KRAJ
                        niz(niz.Length - 1) = grid.Trim + kojaPodtabela
                    End If
                Next
            End If

            'ispisujem niz
            Dim ispisan As String = ";"
            Dim tabelica As String
            Dim samoFPiLBL() As String = {}
            Dim samoNaslov() As String = {}
            Dim nizTR() As String = {}
            For i = 0 To niz.GetUpperBound(0)
                ReDim Preserve samoFPiLBL(i)
                samoFPiLBL(i) = 0
                ReDim Preserve samoNaslov(i)
                samoNaslov(i) = 0
                If niz(i).LastIndexOf("TP_") < 0 AndAlso
                            niz(i).LastIndexOf("TK") < 0 AndAlso
                            niz(i).LastIndexOf("ACE") < 0 AndAlso
                            niz(i).LastIndexOf("ACF") < 0 AndAlso
                            niz(i).LastIndexOf("AKE") < 0 AndAlso
                            niz(i).LastIndexOf("CBO") < 0 AndAlso
                            niz(i).LastIndexOf("CKO") < 0 AndAlso
                            niz(i).LastIndexOf("CBO") < 0 AndAlso
                            niz(i).LastIndexOf("GRID") < 0 AndAlso
                            niz(i).LastIndexOf("FK") < 0 AndAlso
                            niz(i).LastIndexOf("CH") < 0 AndAlso
                            niz(i).LastIndexOf("RBG") < 0 AndAlso
                            niz(i).LastIndexOf("HT") < 0 Then
                    If niz(i).LastIndexOf("naslovLBL_") < 0 AndAlso niz(i).LastIndexOf("naslovLIT_") < 0 Then
                        samoFPiLBL(i) = 1  'red ima samo FP ili LBL, te se ne treba ucitavati!!!!!
                    Else
                        samoNaslov(i) = 1
                    End If
                End If
                ReDim Preserve nizTR(i)
                If niz(i).LastIndexOf("~") >= 0 Then   'tabelice
                    nizTR(i) = niz(i).Trim.Substring(1, niz(i).LastIndexOf("~") - 2).Trim
                Else
                    nizTR(i) = ""
                End If
            Next

            Dim strGridVisible As String = ""
            Dim otvorenTable As Boolean = False


            If brojwebStrana = 0 Then
                sb.Append("<table width=" + nvd + "95%" + nvd + " cellpadding=" + nvd + "0" + nvd + " cellspacing=" + nvd + "0" + nvd + ">" + nvrd)
                sb.Append(nvrd)
                otvorenTable = True
            End If

            If brojdivDisplayNone = 0 Then
                sb.Append("<table width=" + nvd + "95%" + nvd + " cellpadding=" + nvd + "0" + nvd + " cellspacing=" + nvd + "0" + nvd + ">" + nvrd)
                sb.Append(nvrd)
                otvorenTable = True
            End If


            For i = 0 To niz.GetUpperBound(0)
                '   If samoFPiLBL(i) = 0 Then
                'VAZNO webStr i divDisplayNone ne mogu istovremeno
                'novo
                If brojwebStrana > 0 AndAlso nizWebStr(i) > 0 Then
                    If otvorenTable = True Then sb.Append("</table>") : otvorenTable = False
                    sb.Append(nvrd)
                    sb.Append(dajDIVpoc(nizWebStr(i))) 'ovo otvara tabelu    div,table
                    sb.Append(nvrd)
                    otvorenTable = False
                ElseIf brojwebStrana > 0 AndAlso nizEndOfWebStr(i) > 0 Then
                    sb.Append("</div>")
                    sb.Append(nvrd)
                    otvorenTable = False
                End If

                'novo2
                If brojdivDisplayNone > 0 AndAlso nizEndOfdiv(i) > 0 Then
                    If IsNumeric(CInt(nizEndOfdiv(i).Trim)) Then
                        'Dim pz As Integer = CInt(nizEndOfdiv(i).Trim)
                        'For zi As Integer = 1 To pz
                        If otvorenTable = True Then sb.Append("</table>") : otvorenTable = False
                        sb.Append(dajDIVkraj()) 'ovo zatvara tabelu div,table
                        sb.Append(nvrd)
                        'Next
                    Else
                        ISTMessageBox.Show("Error at end of div")
                        If otvorenTable = True Then sb.Append("</table>") : otvorenTable = False
                        sb.Append(dajDIVkraj()) 'ovo zatvara tabelu div,table
                        sb.Append(nvrd)
                    End If

                End If
                If brojdivDisplayNone > 0 AndAlso nizdivDisplayNone(i) > 0 Then
                    If otvorenTable = True Then sb.Append("</table>") : otvorenTable = False
                    sb.Append(nvrd)
                    sb.Append(dajDIVpoc(nizdivDisplayNone(i))) 'ovo otvara tabelu div,table
                    sb.Append(nvrd)
                    otvorenTable = True
                End If


                sb.Append(nvrd)

                If niz(i).LastIndexOf("~") < 0 Then 'NIJE TABELICA
                    If otvorenTable = False Then
                        sb.Append("<table width=" + nvd + "95%" + nvd + " cellpadding=" + nvd + "1" + nvd + " cellspacing=" + nvd + "0" + nvd + ">" + nvrd)
                        sb.Append(nvrd)
                        otvorenTable = True
                    End If
                    sb.Append("<tr>" + nvrd)
                    If niz(i).Substring(0, 4).ToUpper = "GRID" Or niz(i).Substring(0, 9).ToUpper = "PANELGRID" Then     'PODTABELA
                        Dim podtabela As String = ""
                        Dim ppanel As Boolean = False
                        If niz(i).Substring(0, 4).ToUpper = "GRID" Then podtabela = niz(i).Substring(4).ToString.Trim()
                        If niz(i).Substring(0, 9).ToUpper = "PANELGRID" Then podtabela = niz(i).Substring(9).ToString.Trim() : ppanel = True

                        Dim dtpodTabPolja As New System.Data.DataTable
                        dtpodTabPolja = fdtusp_vISTPoljaPoTabeli(vt, IzIst, podtabela)  'order by tabela, rbr"
                        sb.Append(dajPodTabela(podtabela, dtpodTabPolja, ppanel, folder))
                        strGridVisible = strGridVisible + "Me.gv" + podtabela + ".Visible=XXX" + nvrd
                        strGridVisible = strGridVisible + "Me.lb" + podtabela + ".Visible=XXX" + nvrd
                        strGridVisible = strGridVisible + "Me.lblBrojSlogova" + podtabela + ".Visible=XXX" + nvrd
                        strGridVisible = strGridVisible + "Me.lblCount" + podtabela + ".Visible=XXX" + nvrd
                    Else
                        sb.Append("      " + niz(i) + "</td>" + nvrd)   'OBICAN RED
                    End If
                    sb.Append("</tr>" + nvrd)
                Else
                    'tabelice
                    'ne ispisuj ako je vec ispisan ****
                    tabelica = niz(i).Trim.Substring(1, niz(i).IndexOf(".") - 1)
                    If Not nizTabelice(tabelica) Is Nothing Then
                        If ispisan.IndexOf(";" + tabelica.ToString.Trim + ";") < 0 Then
                            If otvorenTable = True Then
                                sb.Append("</table>" + nvrd)
                                sb.Append(nvrd)
                                otvorenTable = False
                            End If
                            sb.Append("<table width=" + nvd + "95%" + nvd + " cellpadding=" + nvd + "1" + nvd + " cellspacing=" + nvd + "0" + nvd + ">" + nvrd)
                            sb.Append(nvrd)
                            otvorenTable = True

                            'PRVO NADLABELA AKO JE IMA
                            If Not nizTabelice(tabelica)(0) Is Nothing Then
                                sb.Append("<tr>" + nvrd)
                                Dim izbacizbogmerge As Boolean = False
                                For kolona As Integer = 1 To nizTabelice(tabelica)(0).Length - 1
                                    If Microsoft.VisualBasic.Split(nizTabelice(tabelica)(0)(kolona), "ˇ")(1).IndexOf("MERGE") > 0 Then
                                        'bio je merge
                                        'nema labele, ima polje sa colspan
                                        Dim tm As String = Microsoft.VisualBasic.Split(nizTabelice(tabelica)(0)(kolona), "ˇ")(1)
                                        Dim kolikoMerge As String = Microsoft.VisualBasic.Split(tm, "MERGE")(0).Trim
                                        sb.Append("<td class=" + nvd + "IST11C" + nvd + " colspan=" + nvd + kolikoMerge + nvd + ">" + nvrd)
                                        sb.Append(Microsoft.VisualBasic.Split(nizTabelice(tabelica)(0)(kolona), "ˇ")(3))
                                        sb.Append("</td>" + nvrd)
                                    ElseIf Microsoft.VisualBasic.Split(nizTabelice(tabelica)(0)(kolona), "ˇ")(1).IndexOf("IZBACIZBOGMRG") >= 0 Then
                                        'nema nista (ni labelu, ni polje)
                                    Else
                                        'nema merge
                                        'ima labelu
                                        sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)
                                        If Microsoft.VisualBasic.Split(nizLab(tabelica)(0)(kolona), "ˇ")(0) <> "UBACENO" Then
                                            sb.Append(Microsoft.VisualBasic.Split(nizLab(tabelica)(0)(kolona), "ˇ")(3))
                                        End If
                                        sb.Append("</td>" + nvrd)
                                        'ima polje
                                        sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)
                                        If Microsoft.VisualBasic.Split(nizTabelice(tabelica)(0)(kolona), "ˇ")(0) <> "UBACENO" Then
                                            sb.Append(Microsoft.VisualBasic.Split(nizTabelice(tabelica)(0)(kolona), "ˇ")(3))
                                        End If
                                        sb.Append("</td>" + nvrd)
                                    End If
                                Next
                                sb.Append("</tr>" + nvrd)

                                ''dodatni redovi ako postoje
                                If Not nizDodatniRedoviNLB(tabelica) Is Nothing Then
                                    sb.Append("<tr>" + nvrd)
                                    For dred As Integer = 1 To nizDodatniRedoviNLB(tabelica).Length - 1
                                        Dim vredkolone() As String = Microsoft.VisualBasic.Split(nizDodatniRedoviNLB(tabelica)(dred), ";")
                                        izbacizbogmerge = False
                                        Dim kolikoMerge As Integer = 1
                                        Dim doklePrviRed As Integer = nizTabelice(tabelica)(0).Length - 1
                                        Dim dokleOvajRed As Integer = vredkolone.GetUpperBound(0)
                                        Dim dokle As Integer = doklePrviRed
                                        If dokleOvajRed < doklePrviRed Then dokle = dokleOvajRed
                                        For kk As Integer = 1 To dokle
                                            If vredkolone(kk).Trim.ToUpper.IndexOf("MERGE") >= 0 Then
                                                'bio je merge
                                                kolikoMerge = kolikoMerge + 1
                                            Else
                                                sb.Append("<td class=" + nvd + "IST11C" + nvd + " colspan=" + nvd + CStr(kolikoMerge * 2).Trim + nvd + ">" + nvrd)
                                                sb.Append(vredkolone(kk))
                                                sb.Append("</td>" + nvrd)
                                            End If
                                        Next
                                        sb.Append("</tr>" + nvrd)
                                    Next
                                End If

                            End If
                            ''PREMESTANJE
                            For red As Integer = 1 To nizTabelice(tabelica).Length - 1
                                If Not nizTabelice(tabelica)(red) Is Nothing Then
                                    For kol As Integer = 1 To nizTabelice(tabelica)(red).Length - 1
                                        If nizPremesti(tabelica)(red)(kol) > 0 Then
                                            Dim trt As Integer = nizPremesti(tabelica)(red)(kol)
                                            Dim xx As String = nizTabelice(tabelica)(red)(trt)
                                            Dim xxLab As String = nizLab(tabelica)(red)(trt)
                                            nizTabelice(tabelica)(red)(trt) = nizTabelice(tabelica)(red)(kol)
                                            nizLab(tabelica)(red)(trt) = nizLab(tabelica)(red)(kol)
                                            nizTabelice(tabelica)(red)(kol) = xx
                                            nizLab(tabelica)(red)(kol) = xxLab
                                        End If
                                    Next
                                End If
                            Next
                            'SVI OSTALI REDOVI AKO POSTOJE
                            For red As Integer = 1 To nizTabelice(tabelica).Length - 1
                                If Not nizTabelice(tabelica)(red) Is Nothing Then
                                    sb.Append("<tr>" + nvrd)
                                    Dim koliko As Integer = 0
                                    Dim Jedini As String = ""
                                    'PREBROJ
                                    For kolona As Integer = 1 To nizTabelice(tabelica)(red).Length - 1
                                        'prvo labele

                                        'If nizCBnaCb.Length > 0 Then
                                        '    For i As Integer = 0 To nizCBnaCb.Length - 1
                                        Dim imaLitUbacen As Boolean = False
                                        Dim labTrt As String() = Microsoft.VisualBasic.Split(nizLab(tabelica)(red)(kolona), "ˇ")
                                        If labTrt.Length > 0 Then
                                            For ll As Integer = 0 To labTrt.Length - 1
                                                If labTrt(ll).Trim.ToUpper.IndexOf("LITERAL") >= 0 Then
                                                    imaLitUbacen = True
                                                End If
                                            Next
                                        End If
                                        If Microsoft.VisualBasic.Split(nizLab(tabelica)(red)(kolona), "ˇ")(0) <> "UBACENO" OrElse imaLitUbacen = True Then
                                            Jedini = nizLab(tabelica)(red)(kolona)
                                            koliko = koliko + 1
                                        End If
                                        'POLJA
                                        If Microsoft.VisualBasic.Split(nizTabelice(tabelica)(red)(kolona), "ˇ")(0) <> "UBACENO" Then
                                            Jedini = nizTabelice(tabelica)(red)(kolona)
                                            koliko = koliko + 1
                                        End If
                                    Next
                                    Dim myIndex As Integer = System.Array.IndexOf(nizTR, tabelica.ToString.Trim + "." + red.ToString.Trim)
                                    If samoNaslov(myIndex) = 1 AndAlso koliko = 1 Then 'MERGE
                                        '<td class="IST11R" colspan="4">
                                        Dim trt As Integer = (nizTabelice(tabelica)(red).Length - 1) * 2
                                        sb.Append("<td class=" + nvd + "IST11R" + nvd + " colspan=" + nvd + trt.ToString.Trim + nvd + ">" + nvrd)
                                        sb.Append(Microsoft.VisualBasic.Split(Jedini, "ˇ")(3))
                                        sb.Append("</td>" + nvrd)
                                    Else 'NIJE NASLOV I NIJE JEDINI AKO JE NASLOV
                                        For kolona As Integer = 1 To nizTabelice(tabelica)(red).Length - 1
                                            'prvo labele
                                            sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)
                                            If Microsoft.VisualBasic.Split(nizLab(tabelica)(red)(kolona), "ˇ")(0) <> "UBACENO" Then
                                                sb.Append(Microsoft.VisualBasic.Split(nizLab(tabelica)(red)(kolona), "ˇ")(3))
                                            ElseIf nizLab(tabelica)(red)(kolona).Trim.ToUpper.IndexOf("LITERAL") >= 0 Then
                                                sb.Append(Microsoft.VisualBasic.Split(nizLab(tabelica)(red)(kolona), "ˇ")(3))
                                            End If
                                            sb.Append("</td>" + nvrd)
                                            'POLJA
                                            sb.Append("<td class=" + nvd + "IST11R" + nvd + ">" + nvrd)
                                            If Microsoft.VisualBasic.Split(nizTabelice(tabelica)(red)(kolona), "ˇ")(0) <> "UBACENO" Then
                                                sb.Append(Microsoft.VisualBasic.Split(nizTabelice(tabelica)(red)(kolona), "ˇ")(3))
                                            End If
                                            sb.Append("</td>" + nvrd)
                                        Next
                                    End If
                                    sb.Append("</tr>" + nvrd)
                                End If
                            Next
                            ispisan = ispisan + tabelica + ";"
                            If otvorenTable = True Then
                                sb.Append("</table>" + nvrd)
                                sb.Append(nvrd)
                                otvorenTable = False
                            End If
                        End If 'VEC ISPISAN
                    End If 'AKO POSTOJI TABELICA
                End If 'DA LI JE TABELICA
                '    End If 'SAMO FPILB
            Next i

            If otvorenTable = True Then
                If brojwebStrana = 0 Then
                    sb.Append("</table>" + nvrd)
                Else
                    sb.Append(dajDIVkraj)
                End If

                If brojdivDisplayNone = 0 Then
                    sb.Append("</table>" + nvrd)
                Else
                    sb.Append(dajDIVkraj)
                End If

            End If
            sb.Append(nvrd)
            sb.Append(strkraj)

            '
            '
            'GENERISANJE VBa
            'GENERISANJE VBa
            'GENERISANJE VBa
            'GENERISANJE VBa
            'GENERISANJE VBa
            Dim ACEget As String = ""
            Dim ACEJS As String = ""
            sbVB.Append(dajOsnovniVB(imetab, nadtabelaOdimetab))
            sbVB.Append(nvrd)
            sbVB.Append(dajBrisiVB(imetab))
            sbVB.Append(nvrd)

            'view_click; pageLoad()
            Dim view As String = ""
            Dim pageLoad As String = ""
            If tipTabele = "G" Then
                sbVB.Append(dajIzlaz("", ""))
                sbVB.Append(nvrd)
                Dim strKodSes As String = ""
                Dim kljucG As String = spremiWhereKljuc(imetab)
                strKodSes = strKodSes + "   Dim kljuc" + imetab + "() = New String() {" + spremiKljucString(imetab) + "}" + nvrd
                strKodSes = strKodSes + "   Session.Add(" + nvd + "kljuc" + imetab + nvd + ", kljuc" + imetab + ")" + nvrd
                strKodSes = strKodSes + "   call USesiju(" + nvd + imetab + nvd + ")" + nvrd
                sbVB.Append(dajView(strKodSes, imetab))
                sbVB.Append(nvrd)
                sbVB.Append(dajUSesiju(kljucG))
                sbVB.Append(nvrd)
                sbVB.Append(dajPrikaziVB(imetab, imaGrid, tipTabele, "", ""))
                sbVB.Append(nvrd)
                sbVB.Append(dajPageLoadG(CBOovi.Trim.Length, imetab, imaGOD, imaMES, imaKV, funkcija))
                sbVB.Append(nvrd)
                sbVB.Append(dajPamtiG())
                sbVB.Append(nvrd)
                sbVB.Append(dajSaveSlog(imetab, ""))
                sbVB.Append(nvrd)
                sbVB.Append(dajPonistiPoljaKljuc("G", imetab, ""))
                sbVB.Append(nvrd)
                sbVB.Append(dajPonisti("G", imetab, "", strGridVisible))
                sbVB.Append(nvrd)
                sbVB.Append(dajNapraviInsert())
                sbVB.Append(nvrd)
                sbVB.Append(dajNapraviUpdate())
                sbVB.Append(nvrd)
                sbVB.Append(dajNapraviDelete())
                sbVB.Append(nvrd)
                sbVB.Append(dajDeleteSlog(imetab, ""))
                sbVB.Append(nvrd)

            End If
            Dim veza As String = ""

            If tipTabele = "D" Then       'imagrid=false
                sbVB.Append(dajIzlaz(nadtabelaOdimetab, imetab))
                sbVB.Append(nvrd)
                sbVB.Append(dajView("", imetab))
                sbVB.Append(nvrd)
                'u sesiju ne ide nista
                sbVB.Append(dajPrikaziVB(imetab, imaGrid, tipTabele, "", ""))
                sbVB.Append(nvrd)
                Dim dsDKK As New System.Data.DataTable
                dsDKK = poljaKljucKojaNePostoje2(imetab, nadtabelaOdimetab)
                Dim sqlDKK As String = ""

                Dim ddkpoljeB As String = ""
                Dim ddkpoljeW As String = ""
                Dim ddkpoljeT As String = ""
                Dim dajRequest As String = ""
                If dsDKK.Rows.Count = 0 Then   'veza 1-1
                    veza = "11"
                    'nema dkk
                    dsDKK.Clear()
                    sqlDKK = "select top 1 rbr,polje from dbo.vISTPoljaKLJUCPoTabeli ('" + vt + "','" + IzIst + "','" + imetab + "') where kljuc='P' order by rbr desc"
                    dsDKK = izvrsiSQLvratiDT(sqlDKK, ISTConnectionString, Me.jezik)
                Else
                    veza = "1N"
                    For j As Integer = 0 To dsDKK.Rows.Count - 1
                        Dim poljeWeb As String = dsDKK.Rows(j).Item("imeWeb").trim
                        Dim poljeBaza As String = dsDKK.Rows(j).Item("polje").trim
                        dajRequest = dajRequest + "Me." + poljeWeb + ".Text = Request.QueryString(" + nvd + poljeBaza + nvd + ").ToString" + nvrd
                    Next
                    'ovo je sve zbog postavljanja fokusa na prvo polje u podtabeli koje je kljuc, a ne pripaga glavnoj tabeli
                    ddkpoljeW = dsDKK.Rows(0).Item("imeWeb").trim    '(imeweb)
                    ddkpoljeT = dsDKK.Rows(0).Item("tipPolja").trim  '(tip)
                End If
                ddkpoljeB = dsDKK.Rows(0).Item("polje").trim
                sbVB.Append(dajPageLoadD(CBOovi.Trim.Length, veza, imetab, ddkpoljeB, ddkpoljeW, ddkpoljeT, nadtabelaOdimetab, dajRequest))
                sbVB.Append(nvrd)
                sbVB.Append(dajPamtiD(veza, imetab, ddkpoljeW, ddkpoljeT, nadtabelaOdimetab))
                sbVB.Append(nvrd)
                sbVB.Append(dajSaveSlogD(imetab, ddkpoljeB))
                sbVB.Append(nvrd)
                sbVB.Append(dajPonistiPoljaKljuc("D", imetab, nadtabelaOdimetab))
                sbVB.Append(nvrd)
                sbVB.Append(dajPonisti("D", imetab, nadtabelaOdimetab, strGridVisible))
                sbVB.Append(nvrd)
                'nema NapraviInsert,NapraviUpdate,NapraviDelete jer sve ide preko DS
                sbVB.Append(dajDeleteSlogD(imetab))
                sbVB.Append(nvrd)
            End If

            Dim sqlpodTab As String = "select podtabela,rbrUnos,panel from  dbo.vISTPODTABELEzaWEB ('" + vt + "','" + IzIst + "') where tabela='" + imetab + "' order by tabela"
            Dim dspodTab As New System.Data.DataTable

            dspodTab = izvrsiSQLvratiDT(sqlpodTab, ISTConnectionString, Nothing)


            If tipTabele = "GD" OrElse tipTabele = "GDP" OrElse tipTabele = "GP" Then 'imagrid=true
                Dim strKod As String = ""
                Dim strKodSes As String = ""
                Dim strKodS As String = ""
                Dim strKodD As String = ""
                Dim strGridovi As String = ""
                Dim kljucG As String = spremiWhereKljuc(imetab)
                Dim prelazaknG As String = spremiWhereKljucZaPrelazak(imetab)

                strKodSes = strKodSes + "   Dim kljuc" + imetab + "() = New String() {" + spremiKljucString(imetab) + "}" + nvrd
                strKodSes = strKodSes + "   Session.Add(" + nvd + "kljuc" + imetab + nvd + ", kljuc" + imetab + ")" + nvrd
                strKodSes = strKodSes + "   call USesiju(" + nvd + imetab + nvd + ")" + nvrd

                For pp As Integer = 0 To dspodTab.Rows.Count - 1
                    Dim podtabela As String = dspodTab.Rows(pp).Item("podtabela").ToString.Trim
                    Dim ppanel As String = dspodTab.Rows(pp).Item("panel").ToString.Trim   'panel ili ''

                    strKodSes = strKodSes + "   Dim kljuc" + podtabela + "() = New String() {" + spremiKljucString(podtabela) + "}" + nvrd
                    strKodSes = strKodSes + "   Session.Add(" + nvd + "kljuc" + podtabela + nvd + ", kljuc" + podtabela + ")" + nvrd
                    strKodSes = strKodSes + "   call USesiju(" + nvd + podtabela + nvd + ")" + nvrd

                    strKod = strKod + "lblCount" + podtabela + ".Text=bindGV" + podtabela + "().ToString" + nvrd
                    strKodS = strKodS + "pSaveSlog = pSaveSlog And pSaveSlogPodTabela(" + nvd + podtabela + nvd + ",gv" + podtabela + ")" + nvrd
                    strKodD = strKodD + "pDeleteSlog = pDeleteSlog And pDeleteSlogPodTabela(" + nvd + podtabela + nvd + ",kljuc)" + nvrd

                    Dim dsdkk As System.Data.DataTable
                    dsdkk = poljaKljucKojaNePostoje3(podtabela, imetab)

                    If ppanel = "" Then 'nije panelna podtabela
                        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pojedinacnigridVB.txt")
                        strGridovi = strGridovi + txt.ReadToEnd + nvrd
                        txt.Close()
                        strGridovi = strGridovi.Replace("99TABELA99", podtabela)
                        strGridovi = strGridovi.Replace("99PRELAZAKnG99", prelazaknG)
                        Dim dkk As String = ""
                        If dsdkk.Rows.Count = 0 Then   'veza 1-1
                            'nema dkk
                            strGridovi = strGridovi.Replace("99ODAKLE99", "GU")
                            strGridovi = strGridovi.Replace("99pomPOLJEOSTATAKKLJUCA99", "")
                            strGridovi = strGridovi.Replace("99PRELAZAKOSTATAKKLJUCA99", "")
                        Else
                            'veza 1-N
                            Dim pomCell As String = ""
                            Dim prelazakCell As String = ""
                            For j As Integer = 0 To dsdkk.Rows.Count - 1
                                Dim imeBaza As String = dsdkk.Rows(j).Item("polje").trim
                                Dim brojKolone As String = dsdkk.Rows(j).Item("redosled").trim
                                pomCell = pomCell + "Dim pom" + imeBaza + " as String = gv" + podtabela + ".SelectedRow.Cells(" + brojKolone + ").Text" + nvrd
                                prelazakCell = prelazakCell + "&" + imeBaza + "=" + nvd + " + pom" + imeBaza + "+" + nvd
                            Next
                            dkk = dsdkk.Rows(0).Item("polje").trim
                            strGridovi = strGridovi.Replace("99ODAKLE99", "GI")
                            strGridovi = strGridovi.Replace("99pomPOLJEOSTATAKKLJUCA99", pomCell)
                            strGridovi = strGridovi.Replace("99PRELAZAKOSTATAKKLJUCA99", prelazakCell)
                        End If
                    End If
                Next

                'koje panele sadrzi
                'za svaki panel u glavnoj tabeli
                'dodaj viewPanel
                'dodaj cmdCuvajPanel
                'dodaj klik na grid
                Dim strPKNP As String = ""
                Dim sqlP As String = ""
                Dim dsP As New System.Data.DataTable
                sqlP = "select podtabela as tabelaP from vISTPODTABELEzaWEB('" + vt + "','" + IzIst + "') where isnull(panel,'')='panel' " _
                + " and tabela='" + imetab + "'"

                dsP = izvrsiSQLvratiDT(sqlP, ISTConnectionString, Nothing)

                Dim LK As String = ""
                If dsP.Rows.Count > 0 Then
                    Dim tabelap As String = ""
                    For ii As Integer = 0 To dsP.Rows.Count - 1
                        tabelap = dsP.Rows(ii).Item("tabelap").ToString.Trim
                        'dodaj viewPanel99999999999999999999999999999999999999999999999999999
                        sbVB.Append(dajviewPanel(tabelap))
                        sbVB.Append(nvrd)
                        'dodaj cmdCuvajPanel99999999999999999999999999999999999999999999999999999
                        sbVB.Append(dajcmdCuvajPanel(imetab, tabelap))
                        sbVB.Append(nvrd)
                        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pojedinacnigridVBpanel.txt")
                        strGridovi = strGridovi + txt.ReadToEnd + nvrd
                        txt.Close()
                        strGridovi = strGridovi.Replace("99TABELAP99", tabelap)
                        strGridovi = strGridovi.Replace("99TABELAPKLJUC99", spremiWhereKljuc(tabelap, , True))

                        'dodaj da se slog iz grida može prebaciti u panel
                        Dim dsdkk As System.Data.DataTable
                        dsdkk = poljaKljucKojaNePostoje3(tabelap, imetab)
                        Dim dkk As String = ""
                        Dim pomCell As String = ""
                        For j As Integer = 0 To dsdkk.Rows.Count - 1
                            Dim iweb As String = dsdkk.Rows(j).Item("imeweb").trim
                            Dim brojKolone As String = dsdkk.Rows(j).Item("redosled").trim
                            pomCell = pomCell + "Me.PNL" + tabelap + iweb + ".Text = gv" + tabelap + ".SelectedRow.Cells(" + brojKolone + ").Text" + nvrd
                        Next
                        strGridovi = strGridovi.Replace("99pomPOLJEOSTATAKKLJUCA99", pomCell)

                        'dodajLK za svaki panel
                        sbVB.Append(dajLKpanel(tabelap))
                        sbVB.Append(nvrd)

                        'dodaj prenesiKljuceveNaPanele
                        strPKNP = strPKNP + spremiPrenesiKljucNaPanele(imetab, tabelap)
                        imamCuvanjePanela = True
                    Next
                End If

                sbVB.Append(dajIzlaz("", ""))
                sbVB.Append(nvrd)
                sbVB.Append(dajView(strKodSes, imetab))
                sbVB.Append(nvrd)
                sbVB.Append(dajUSesiju(kljucG))
                sbVB.Append(nvrd)
                sbVB.Append(dajPrikaziVB(imetab, imaGrid, tipTabele, strKod, strGridVisible, strPKNP))
                sbVB.Append(nvrd)
                sbVB.Append(dajPageLoadGD(CBOovi.Trim.Length, imetab, imaGOD, imaMES, imaKV, funkcija))
                sbVB.Append(nvrd)
                sbVB.Append(dajPamtiGD())    'NIJE isto sto i dajpamtiG
                sbVB.Append(nvrd)
                sbVB.Append(strGridovi)
                sbVB.Append(nvrd)
                sbVB.Append(dajSaveSlog(imetab, strKodS))
                sbVB.Append(nvrd)
                sbVB.Append(dajSaveSlogPodTabela())
                sbVB.Append(nvrd)
                sbVB.Append(dajPonistiPoljaKljuc("G", imetab, ""))
                sbVB.Append(nvrd)
                sbVB.Append(dajPonisti("G", imetab, "", strGridVisible))
                sbVB.Append(nvrd)
                sbVB.Append(dajNapraviInsert)
                sbVB.Append(nvrd)
                sbVB.Append(dajNapraviUpdate)
                sbVB.Append(nvrd)
                sbVB.Append(dajNapraviDelete)
                sbVB.Append(nvrd)
                sbVB.Append(dajnapraviInsertUpdatePodTabela)
                sbVB.Append(nvrd)
                sbVB.Append(dajDeleteSlog(imetab, strKodD))
                sbVB.Append(nvrd)
                sbVB.Append(dajDeleteSlogPodTabela())
                sbVB.Append(nvrd)
            End If

            If tipTabele = "DD" Then 'imagrid=true

            End If

            'za textPolja DODELA, SKAKANJE
            '2.ACE  (DDL ide kao ACE)
            Dim ACEplD As String = ""
            If ACEovi.Trim.Length > 0 Then
                Dim ACEs() As String = {}
                If ACEovi.Length > 0 Then ACEs = Microsoft.VisualBasic.Split(ACEovi.Substring(0, ACEovi.Length - 1), ";")
                Dim ACEtips() As String = {}
                If ACEtipPolja.Length > 0 Then ACEtips = Microsoft.VisualBasic.Split(ACEtipPolja.Substring(0, ACEtipPolja.Length - 1), ";")
                Dim ACEpravaBazas() As String = {}
                If ACEpravaBaza.Length > 0 Then ACEpravaBazas = Microsoft.VisualBasic.Split(ACEpravaBaza.Substring(0, ACEpravaBaza.Length - 1), ";")
                Dim ACETabelas() As String = {}
                If ACETabela.Length > 0 Then ACETabelas = Microsoft.VisualBasic.Split(ACETabela.Substring(0, ACETabela.Length - 1), ";")
                Dim ACERelTabelas() As String = {}
                If ACERelTabela.Length > 0 Then ACERelTabelas = Microsoft.VisualBasic.Split(ACERelTabela.Substring(0, ACERelTabela.Length - 1), ";")
                Dim ACEUBazus() As String = {}
                If ACEUBazu.Length > 0 Then ACEUBazus = Microsoft.VisualBasic.Split(ACEUBazu.Substring(0, ACEUBazu.Length - 1), ";")
                Dim ACEPrikazis() As String = {}
                If ACEPrikazi.Length > 0 Then ACEPrikazis = Microsoft.VisualBasic.Split(ACEPrikazi.Substring(0, ACEPrikazi.Length - 1), ";")
                Dim ACEFiltriranoPoljes() As String = {}
                If ACEFiltriranoPolje.Length > 0 Then ACEFiltriranoPoljes = Microsoft.VisualBasic.Split(ACEFiltriranoPolje.Substring(0, ACEFiltriranoPolje.Length - 1), ";")
                Dim ACEFiltriranoPoPoljus() As String = {}
                If ACEFiltriranoPoPolju.Length > 0 Then ACEFiltriranoPoPoljus = Microsoft.VisualBasic.Split(ACEFiltriranoPoPolju.Substring(0, ACEFiltriranoPoPolju.Length - 1), ";")
                Dim ACEfilters() As String = {}
                If ACEfilter.Length > 0 Then ACEfilters = Microsoft.VisualBasic.Split(ACEfilter.Substring(0, ACEfilter.Length - 1), ";")

                Dim dodelaVrednostiIZLK() As String = {}
                Dim sqlACE() As String = {}
                For l As Integer = 0 To ACEs.GetUpperBound(0)
                    If ACERelTabelas(l).Trim.Length > 0 Then  'onda je DDL u IST-u
                        dodelaVrednostiIZLK = Microsoft.VisualBasic.Split(dodelaVBizLK.Substring(0, dodelaVBizLK.Length - 1), ";")
                    Else 'onda je CBO u IST-u
                        'dodelaVrednosti = Microsoft.VisualBasic.Split(dodelaVBizLK.Substring(0, dodelaVBizLK.Length - 1), ";")
                    End If
                Next

                sqlACE = Microsoft.VisualBasic.Split(sqlACEovi.Substring(0, sqlACEovi.Length - 1), ";")
                Dim dsACE() As Integer = {}

                For l As Integer = 0 To ACEs.GetUpperBound(0)
                    sqlACE(l) = "SELECT distinct TOP 20 " + ACEUBazus(l) + " as polje, " + ACEPrikazis(l) + " as naziv "
                    If ACERelTabelas(l).Trim.Length > 0 Then  'onda je DDL u IST-u
                        If dodelaVrednostiIZLK(l).Trim.Length > 0 Then
                            Dim dod() As String = Microsoft.VisualBasic.Split(dodelaVrednostiIZLK(l), ",")
                            For ii As Integer = 0 To dod.GetUpperBound(0)
                                Dim jednako As Integer = dod(ii).IndexOf("=")
                                Dim mojePolje As String = dod(ii).Substring(0, jednako)
                                Dim poljeKonsult As String = dod(ii).Substring(jednako + 1)
                                sqlACE(l) = sqlACE(l) + "," + poljeKonsult + " as " + poljeKonsult
                            Next
                        End If
                    Else 'onda je CBO u IST-u
                        'dodelaVrednosti = Microsoft.VisualBasic.Split(dodelaVBizLK.Substring(0, dodelaVBizLK.Length - 1), ";")
                    End If

                    If ACETabelas(l).Trim.ToUpper.IndexOf("WHERE") >= 0 Then
                        sqlACE(l) = sqlACE(l) + " FROM " + ACEpravaBazas(l) + ".dbo." + ACETabelas(l) + " AND "
                    Else
                        sqlACE(l) = sqlACE(l) + " FROM " + ACEpravaBazas(l) + ".dbo." + ACETabelas(l) + " WHERE 2=2 AND "
                    End If
                Next

                Dim pop As String = ""
                Dim popCall As String = ""
                Dim yy As Integer = 0
                Dim isti As Integer = -1
                If ACEs.Length > 0 Then
                    ReDim Preserve dsACE(0)
                    dsACE(0) = 0
                    For yy = 1 To ACEs.GetUpperBound(0)
                        For fff As Integer = 0 To yy - 1
                            ReDim Preserve dsACE(yy)
                            If sqlACE(yy).ToUpper.Trim = sqlACE(fff).ToUpper.Trim Then
                                isti = fff
                                Exit For
                            Else
                                isti = yy
                            End If
                        Next
                        dsACE(yy) = isti
                    Next
                End If

                If ACEs.Length > 0 Then
                    For yy = 0 To ACEs.GetUpperBound(0)
                        If yy <= dsACE(yy) Then
                            'OVDE PRAVI PUBLIC SHARED FUNKCIJE
                            If ACERelTabelas(yy).Trim.Length > 0 Then  'onda je DDL u IST-u
                                sbVB.Append(dajACEMetodDDL(False, sqlACE(yy), ACEPrikazis(yy), "SM" + dsACE(yy).ToString.Trim))
                            Else 'onda je CBO u IST-u
                                sqlACE(yy) = sqlACE(yy).Replace("SELECT distinct TOP 20", "SELECT distinct TOP 20 * ,")
                                If yy <= ACEFiltriranoPoljes.GetUpperBound(0) AndAlso ACEFiltriranoPoljes(yy).Trim = "1" Then
                                    'sqlACE(yy) je drugacije
                                    Dim filterPom As String() = Microsoft.VisualBasic.Split(ACEfilters(yy), "=")
                                    sqlACE(yy) = sqlACE(yy) + " " + filterPom(0).Trim + "='" + nvd + "+ contextKey +" + nvd + "' AND "
                                    sbVB.Append(dajACEMetodDDL(True, sqlACE(yy), ACEPrikazis(yy), "SM" + dsACE(yy).ToString.Trim))
                                Else
                                    sbVB.Append(dajACEMetodDDL(False, sqlACE(yy), ACEPrikazis(yy), "SM" + dsACE(yy).ToString.Trim))
                                End If
                            End If
                            sbVB.Append(nvrd)
                            'DODAJ U GET
                            Dim trtACE As String = ACETabelas(yy)
                            If ACETabelas(yy).Trim.ToUpper.IndexOf("WHERE") >= 0 Then
                                trtACE = ACETabelas(yy).Substring(0, ACETabelas(yy).ToUpper.IndexOf("WHERE") - 1)
                            End If
                            ACEget = ACEget + dajACEGet(trtACE + dsACE(yy).ToString.Trim, ACETabelas(yy), ACEUBazus(yy), ACEPrikazis(yy), ACEpravaBazas(yy)) + nvrd
                            ''DODAJ u PageLoadD
                            'ACEplD = ACEplD + dajACEplD(ACEs(yy), ACETabelas(yy), ACEUBazus(yy), ACEPrikazis(yy), ACEpravaBazas(yy)) + nvrd

                        End If

                        'DODAJ u PageLoadD
                        ACEplD = ACEplD + dajACEplD(ACEs(yy), ACETabelas(yy), ACEUBazus(yy), ACEPrikazis(yy), ACEpravaBazas(yy)) + nvrd

                        'ZAMENA
                        sb.Replace("SM" + ACEs(yy).Replace("_", "_LAZNIDDL").Trim.ToUpper + "SM", "SM" + dsACE(yy).ToString.Trim.ToUpper)
                        Dim trtGGGMMM As String = ""
                        trtGGGMMM = ACETabelas(yy).ToString.Trim.ToUpper      'zamena GGGMMM u izrazu

                        trtGGGMMM = ZameniGGGMMMSimple(trtGGGMMM, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
                        If trtGGGMMM.Trim.ToUpper.IndexOf("WHERE") >= 0 Then
                            trtGGGMMM = trtGGGMMM.Substring(0, trtGGGMMM.ToUpper.IndexOf("WHERE") - 1)
                        End If
                        sb.Replace("SMTAG" + ACEs(yy).Replace("_", "_LAZNIDDL").Trim.ToUpper + "SMTAG", trtGGGMMM.Trim + dsACE(yy).ToString.Trim.ToUpper)
                        'PRAVI IMETABELE.JS
                        ACEJS = ACEJS + dajACEJS(ACEs(yy).Replace("_", "_LAZNIDDL"), ACEs(yy)) + nvrd
                    Next
                End If
            End If 'Kraj DDL
            'ZAMENA
            sbVB.Replace("99KLJUCACE99", ACEplD)

            If CBOovi.Trim.Length > 0 Then
                'prvo CBOovi
                If CBOovi.Trim.Length > 0 Then
                    Dim CBO() As String = Microsoft.VisualBasic.Split(CBOovi.Substring(0, CBOovi.Length - 1), ";")
                    Dim sqlCBO() As String = Microsoft.VisualBasic.Split(sqlCBOovi.Substring(0, sqlCBOovi.Length - 1), ";")
                    Dim CBOUBazus() As String = Microsoft.VisualBasic.Split(CBOUBazu.Substring(0, CBOUBazu.Length - 1), ";")
                    Dim CBOPrikazis() As String = Microsoft.VisualBasic.Split(CBOPrikazi.Substring(0, CBOPrikazi.Length - 1), ";")
                    filterCBOovi = filterCBOovi.Substring(0, filterCBOovi.Length - 1)
                    Dim ffCBO() As String = Microsoft.VisualBasic.Split(filterCBOovi, ";")

                    For l As Integer = 0 To CBO.GetUpperBound(0)
                        Dim fromCL As String = ""
                        If sqlCBO(l).ToUpper.IndexOf("*") >= 0 Then
                            fromCL = sqlCBO(l).ToUpper.Replace("SELECT *", "")
                            sqlCBO(l) = "select * "
                        Else
                            fromCL = sqlCBO(l).ToUpper.Replace("SELECT", "")
                        End If
                        If fromCL.ToUpper.IndexOf(".DBO.") < 0 Then
                            Dim bbb() As String = razkvantaj(fromCL)
                            For ll As Integer = 0 To bbb.GetUpperBound(0)
                                If bbb(ll).ToUpper.Trim = "FROM" Then
                                    bbb(ll) = "from " & pravaBaza & ".dbo."
                                End If
                            Next
                            fromCL = ustringaj(bbb).ToUpper
                            fromCL = fromCL.Replace(".DBO. ", ".DBO.")
                            fromCL = fromCL.Replace(".DBO.DBO.", ".DBO.")
                        End If
                        sqlCBO(l) = sqlCBO(l) + fromCL
                        If ffCBO(l).ToUpper.Trim.Length = 0 Then
                            sqlCBO(l) = sqlCBO(l) + ""
                        End If
                    Next

                    Dim pop As String = ""
                    Dim popCall As String = ""
                    Dim xx As Integer = 0
                    Dim dsCBO() As Integer = {}
                    Dim yy As Integer = 0
                    Dim isti As Integer = -1
                    If CBO.Length > 0 Then
                        ReDim Preserve dsCBO(0)
                        dsCBO(0) = 0
                        For yy = 1 To CBO.GetUpperBound(0)
                            For fff As Integer = 0 To yy - 1
                                ReDim Preserve dsCBO(yy)
                                If sqlCBO(yy).ToUpper.Trim = sqlCBO(fff).ToUpper.Trim Then
                                    isti = fff
                                    Exit For
                                Else
                                    isti = yy
                                End If
                            Next
                            dsCBO(yy) = isti
                        Next
                    End If
                    If CBO.Length > 0 Then
                        For xx = 0 To CBO.GetUpperBound(0)
                            If xx <= dsCBO(xx) Then
                                pop = pop + "  strSQL=" + nvd + sqlCBO(xx) + nvd + nvrd
                                pop = pop + "  ds = b.DajDS_IzUpita(strSQL,Me.lblKonekcija.Text)" + nvrd
                                pop = pop + "  Session.Add(" + nvd + "ds" + dsCBO(xx).ToString.Trim + nvd + ", ds)" + nvrd
                            End If
                            If ffCBO(xx).ToUpper.Trim.Length = 0 Then
                                'nemaFilter
                                popCall = popCall + "          call popuniCBOizvor" + "(Me." + CBO(xx).Trim + "," + nvd + "ds" + dsCBO(xx).ToString.Trim + nvd + "," + nvd + CBOUBazus(xx) + nvd + "," + nvd + CBOPrikazis(xx) + nvd + ")" + nvrd
                            Else
                                'ima filter
                                popCall = popCall + "          call popuni_" + CBO(xx).Trim + "(Me." + CBO(xx).Trim + "," & Microsoft.VisualBasic.Strings.Chr(34) & Microsoft.VisualBasic.Strings.Chr(34) & ")" + nvrd
                            End If
                        Next
                        sbVB.Append("Sub dsIzSesijeCBO ()")
                        sbVB.Append(nvrd)
                        sbVB.Append(" Dim ds As DataSet")
                        sbVB.Append(nvrd)
                        sbVB.Append(" Dim strSQL As String")
                        sbVB.Append(nvrd)
                        sbVB.Append(pop)
                        sbVB.Append(nvrd)
                        sbVB.Append("End Sub")
                        sbVB.Append(nvrd)
                        sbVB.Append("Sub popuniCBO ()")
                        sbVB.Append(nvrd)
                        sbVB.Append(popCall)
                        sbVB.Append(nvrd)
                        sbVB.Append("End Sub")
                        sbVB.Append(nvrd)
                    End If
                    Dim nizpopuniSubZaFiltriraneCBO() As String = {}
                    Dim ii As Integer = -1
                    If CBO.Length > 0 Then
                        Dim PostojiSelectedIndexChangedZa As String = ""
                        Dim CBOSICh() As String = {}
                        ReDim Preserve CBOSICh(CBO.GetUpperBound(0))
                        For y As Integer = 0 To CBO.GetUpperBound(0)
                            Dim sledecePolje As String
                            Dim cboKojiSeFiltrira As String
                            Dim pravoPolje As String = CBO(y).Trim.Substring(4)
                            Dim poljePoKomeSeFiltrira As String = ""
                            Dim dv As New System.Data.DataView(dISTPoljaKonsult)
                            Dim dv1 As New System.Data.DataView(dISTPoljaKonsult)
                            Dim dv2 As New System.Data.DataView(dISTPoljaKonsult)
                            Dim AutoPostBackPolje As String = ""
                            Dim mrt As String = "$"
                            Dim imaPocetak As Boolean = False
                            dv.RowFilter = "tabela='" & imetab & "' and polje='" & pravoPolje & "'"
                            pomOD = ""
                            If Not (CType(dv.Item(0), System.Data.DataRowView).Row("OD").GetType Is GetType(System.DBNull)) Then pomOD = CType(dv.Item(0), System.Data.DataRowView).Row("OD").Trim.toupper
                            Dim pomTip As String = ""
                            If Not (CType(dv.Item(0), System.Data.DataRowView).Row("tip").GetType Is GetType(System.DBNull)) Then pomTip = CType(dv.Item(0), System.Data.DataRowView).Row("tip").Trim.toupper
                            Dim pomDuzina As String = ""
                            If Not (CType(dv.Item(0), System.Data.DataRowView).Row("duzina").GetType Is GetType(System.DBNull)) Then pomDuzina = CType(dv.Item(0), System.Data.DataRowView).Row("duzina").Trim.toupper
                            Call ZaProveru(pomOD, pravoPolje, pomTip, pomDuzina)

                            If funkcijaCBODodela = True Then
                                AutoPostBackPolje = CBO(y).Trim.ToUpper
                                mrt = mrt + AutoPostBackPolje + "$"
                                Dim gde As Long = sbIndexOf(sb, " ID=" & nvd & AutoPostBackPolje & nvd & "")
                                If gde > -1 Then
                                    gde = gde + AutoPostBackPolje.Length + 7
                                    sb.Insert(gde, "AutoPostBack=" & nvd & "true" & nvd & " ", 1)
                                End If
                                CBOSICh(y) = CBOSICh(y) + nvrd
                                CBOSICh(y) = CBOSICh(y) + "  " + CBO(y).Trim + ".Focus()"
                                CBOSICh(y) = CBOSICh(y) + nvrd
                                CBOSICh(y) = CBOSICh(y) + "'DODELA"
                                CBOSICh(y) = CBOSICh(y) + dajDodelaCBO(imetab, "ds" + dsCBO(y).ToString.Trim, CBO(y).Trim, CBOUBazus(y), nizdodeliSta, nizdodeliKome, nizdodeliAko)
                                CBOSICh(y) = CBOSICh(y) + nvrd
                                If funkcijaSkoci = True Then   'kad sam vec otrcala do servera, da odskacem ako ima, ako nema probati JS
                                    CBOSICh(y) = CBOSICh(y) + "'SKAKANJE"
                                    CBOSICh(y) = CBOSICh(y) + dajSkakanjeSaCBO(imetab, CBO(y).Trim, nizskociNA, nizskociAKO)
                                End If
                            End If
                            If ffCBO(y).ToUpper.Trim.Length = 0 Then 'nema filter
                            Else 'ima filter
                                Dim trt() As String = {}
                                ffCBO(y) = ffCBO(y).Substring(0, ffCBO(y).Length)
                                trt = Microsoft.VisualBasic.Split(ffCBO(y), "=")
                                sbVB.Append(popuniFiltriraniCBO(CBO(y), "ds" + dsCBO(y).ToString.Trim, trt(0).Trim, CBOUBazus(y), CBOPrikazis(y)) + nvrd)
                                'npr opstina
                                Dim pp As String = trt(1).Trim.Replace("d.", "")
                                dv2.RowFilter = "tabela='" & imetab & "' and polje='" & pp & "'"
                                poljePoKomeSeFiltrira = CType(dv2.Item(0), System.Data.DataRowView).Row("imeWeb").ToString.Trim.ToUpper
                                AutoPostBackPolje = poljePoKomeSeFiltrira
                                If mrt.IndexOf("$" + AutoPostBackPolje + "$") < 0 Then
                                    Dim gde As Long = sbIndexOf(sb, " ID=" & nvd & AutoPostBackPolje & nvd & "")
                                    If gde > -1 Then
                                        gde = gde + AutoPostBackPolje.Length + 7
                                        sb.Insert(gde, "AutoPostBack=" & nvd & "true" & nvd & " ", 1)
                                    End If
                                Else 'vec je uradjen autopostback za to polje
                                End If
                                dv1.RowFilter = "tabela='" & imetab & "' and polje<>'" & pp & "' and tipPolja<>'FP'"
                                dv1.Sort = "Rbr"
                                sledecePolje = CType(dv1.Item(0), System.Data.DataRowView).Row("imeWeb").ToString.Trim
                                cboKojiSeFiltrira = CBO(y).Trim
                                If poljePoKomeSeFiltrira.Substring(0, 1) = "C" Then
                                    'AKO NE POSTOJI
                                    Dim postojicbo As Boolean = False
                                    Dim gdePostojiCBO As Integer = -1
                                    For zz As Integer = 0 To y
                                        If CBO(zz) = poljePoKomeSeFiltrira Then
                                            postojicbo = True
                                            gdePostojiCBO = zz
                                            Exit For
                                        End If
                                    Next
                                    If postojicbo = True Then
                                        CBOSICh(gdePostojiCBO) = CBOSICh(gdePostojiCBO) + nvrd
                                        CBOSICh(gdePostojiCBO) = CBOSICh(gdePostojiCBO) + "  " + poljePoKomeSeFiltrira + ".Focus()"
                                        CBOSICh(gdePostojiCBO) = CBOSICh(gdePostojiCBO) + nvrd
                                        CBOSICh(gdePostojiCBO) = CBOSICh(gdePostojiCBO) + "   popuni_" + CBO(y).Trim + "(" + cboKojiSeFiltrira + "," + poljePoKomeSeFiltrira + ".Text" + ")"
                                        CBOSICh(gdePostojiCBO) = CBOSICh(gdePostojiCBO) + nvrd
                                    Else
                                        CBOSICh(y) = CBOSICh(y) + nvrd
                                        CBOSICh(y) = CBOSICh(y) + "  " + poljePoKomeSeFiltrira + ".Focus()"
                                        CBOSICh(y) = CBOSICh(y) + nvrd
                                        CBOSICh(y) = CBOSICh(y) + "   popuni_" + CBO(y).Trim + "(" + cboKojiSeFiltrira + "," + poljePoKomeSeFiltrira + ".Text" + ")"
                                        CBOSICh(y) = CBOSICh(y) + nvrd
                                    End If
                                    ii = ii + 1
                                    ReDim Preserve nizpopuniSubZaFiltriraneCBO(ii)
                                    nizpopuniSubZaFiltriraneCBO(ii) = CBO(y).Trim + ";popuni_" + CBO(y).Trim + "(" + cboKojiSeFiltrira + "," + poljePoKomeSeFiltrira + ".Text" + ")"

                                ElseIf poljePoKomeSeFiltrira.Substring(0, 1) = "T" Then
                                    sbVB.Append(dajFiltriraniCBOTextChanged(imetab, cboKojiSeFiltrira, poljePoKomeSeFiltrira, sledecePolje) + nvrd)
                                End If
                            End If
                        Next  'sledeci CBO

                        For y As Integer = 0 To CBO.GetUpperBound(0)
                            'ispisi
                            sbVBpomCBOSIC.Append("Protected Sub  " + CBO(y).Trim + "_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles  " + CBO(y).Trim + ".SelectedIndexChanged")
                            sbVBpomCBOSIC.Append(nvrd)
                            sbVBpomCBOSIC.Append(CBOSICh(y))
                            sbVBpomCBOSIC.Append(nvrd)
                            sbVBpomCBOSIC.Append("End Sub")
                            sbVBpomCBOSIC.Append(nvrd)
                        Next
                        If nizpopuniSubZaFiltriraneCBO.Length > 0 Then
                            For ii = 0 To nizpopuniSubZaFiltriraneCBO.GetUpperBound(0) 'zameni 'ZAMENIime sa odgovarajucom funkcijom
                                Dim ime As String = Microsoft.VisualBasic.Split(nizpopuniSubZaFiltriraneCBO(ii), ";")(0).Trim
                                ime = "XXX" + ime.Trim + "XXX"
                                sbVBpomCBOSIC.Replace(ime, Microsoft.VisualBasic.Split(nizpopuniSubZaFiltriraneCBO(ii), ";")(1).Trim)
                            Next
                        End If
                    End If
                End If ' kraj CBO
            End If

            Dim pomAutoPostBack As String = "AutoPostBack=" + nvd + "true" + nvd + " AutoPostBack=" + nvd + "true" + nvd
            Dim pomAutoPostBack1 As String = "AutoPostBack=" + nvd + "true" + nvd
            sb.Replace(pomAutoPostBack, pomAutoPostBack1)

            sbVB.Append(dajDefaultPolja(True, imetab, prvoPoljeKljuc, tipTabele, nadtabelaOdimetab))
            sbVB.Append(nvrd)
            sbVB.Append(dajDefaultPolja(False, imetab, prvoPoljeKojeNijeKljuc, tipTabele, nadtabelaOdimetab))
            sbVB.Append(nvrd)
            sbVB.Append(dajPopuniSlog(imetab))
            sbVB.Append(nvrd)
            sbVB.Append(dajGetSlog(ACEovi.Trim.Length, imetab, ACEget))
            sbVB.Append(nvrd)
            sbVB.Append(dajDodelaIzAdresara(ACEovi.Trim.Length, imetab, ACEget))
            sbVB.Append(nvrd)
            sbVB.Append(dajDodelaIzWebRelacije(ACEovi.Trim.Length, imetab, ACEget))
            sbVB.Append(nvrd)
            sbVB.Append(dajZapamtiPlus(nizPlus, nizPamti))
            sbVB.Append(nvrd)
            sbVB.Append(dajdodajPlusPonoviP(nizPlus, nizPamti))
            sbVB.Append(nvrd)
            sbVB.Append(dajLK(imetab))
            sbVB.Append(nvrd)

            'ono sto se dodaje generalno
            If imamCuvanjePanela = True Then
                '9999999999999999999999999999999999999999999999999
                sbVB.Append(dajpSaveSlogPanel(ACEovi.Trim.Length, ACEget))
                sbVB.Append(nvrd)
                sbVB.Append(nvrd)
            End If

            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(aspx, False, System.Text.Encoding.UTF8)
                outfile.Write(sb.ToString())
                outfile.Write(sbFilter.ToString())
                outfile.Flush()
                outfile.Close()
                Dim outfileVB As New System.IO.StreamWriter(vb, False, System.Text.Encoding.UTF8)
                outfileVB.Write(sbVB.ToString())
                outfileVB.Write(sbVBpom.ToString())
                outfileVB.Write(sbVBpomCBOSIC.ToString())
                outfileVB.Write(nvrd + "End Class" + nvrd)
                outfileVB.Flush()
                outfileVB.Close()
                Dim outfileJS As New System.IO.StreamWriter(js, False, System.Text.Encoding.UTF8)
                outfileJS.Write(ACEJS)
                outfileJS.Write(sbJS.ToString())
                outfileJS.Flush()
                outfileJS.Close()
            Catch ex As System.Exception

                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
            End Try
        Next 'KRAJ OD za svaku tabelu
        '
        'sredjivanje baze:
        Dim generisano As String = ""
        If okRel = True Then generisano = proveraAdresaraIVeza(IzIst, imetab, imeRel, "R")
        If okAdr = True Then generisano = proveraAdresaraIVeza(IzIst, imetab, imeAdr, "A")
        '
        Call formirajZaAdm(IzIst, opisIST, folder, konekcija, periodika)
        '
        Call formirajMasterPageIST(folder, opisIST, "R1", periodika)
        Call formirajMasterPageIST(folder, opisIST, "R3", periodika)
        '
        Call formirajMetodologija(folder)
        '
        Call formirajIzvestaje(folder)
        '
        'Default.aspx se samo kopira
        '**

        If okRel = True Then Call formirajDefaultVBRel(IzIst, folder, imetab, imeRel, dataSetIST)
        If okAdr = True Then Call formirajDefaultVBAdr(IzIst, folder, imetab, imeAdr, dataSetIST) 'poslednja je G zbog order by DG u dISTTabelezaWeb
        '
        'IZBOR UPITNIKA ZA UNOS I PREGLED UNETIH SLOGOVA I DEFAULT.VB
        Dim opisAdresarW As String = ""
        Dim adresarW As String = ""
        Dim tabelaW As String = ""
        Dim funkcijaW As String = ""
        Dim spajanjeAdresarTabelaW As String = ""
        Dim orgAdresarTabelaW As String = ""
        Dim orgAdresarTabelaWZ As String = ""

        If dISTTABELEzaWEBizbor.Rows.Count > 0 Then
            'ovo radi samo za jedan G, treba prepraviti **
            For Each tabW As System.Data.DataRow In dISTTABELEzaWEBizbor.Rows
                adresarW = tabW.Item("adresarTabela").ToString.Trim.ToUpper
                tabelaW = tabW.Item("tabela").ToString.Trim.ToUpper
                opisAdresarW = adresarW
                spajanjeAdresarTabelaW = tabW.Item("spojiPoljaTabela").ToString.Trim.ToUpper
                funkcijaW = tabW.Item("funkcija").ToString.Trim.ToUpper
                orgAdresarTabelaW = tabW.Item("orgAdresarTabela").ToString.Trim.ToUpper
                If funkcijaW = "R" Then
                    ''zamena GGG,MMM d. ... ako postoje
                    '(select * from Adresar_SBS03 where kv=d.kv and god={GGG})
                    '(select * from Adresar_SBS03 where kv="'+me.tk_kv.text+ "' and god="'+me.TK_god.text+"'")
                    orgAdresarTabelaWZ = orgAdresarTabelaW.Trim.ToUpper      'zamena GGGMMM u izrazu
                    '" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
                    If orgAdresarTabelaWZ.IndexOf("{GGG}") > 0 Then
                        orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("{GGG}", "'" + nvd + "+ Me.TK_GOD.text +" + nvd + "'")
                        orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("{MMM}", "'" + nvd + "+ Me.TK_MES.text +" + nvd + "'")
                        orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("GGG", " god='" + nvd + "+ Me.TK_GOD.text +" + nvd + "'")
                        orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("MMM", " mes='" + "+ Me.TK_MES.text +" + "'")
                    End If
                    If orgAdresarTabelaWZ.IndexOf("{YYY}") > 0 Then
                        'orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("{YYY}", "'" + nvd + "+ Me.TK_ISTYEAR.text +" + nvd + "'")
                        'orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("{MMM}", "'" + nvd + "+ Me.TK_ISTMONTH.text +" + nvd + "'")
                        'orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("YYY", " ISTYEAR='" + nvd + "+ Me.TK_ISTYEAR.text +" + nvd + "'")
                        'orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace("MMM", " ISTMONTH='" + "+ Me.TK_ISTMONTH.text +" + "'")
                    End If
                    orgAdresarTabelaWZ = orgAdresarTabelaWZ.Replace(Microsoft.VisualBasic.Strings.ChrW(26), "")
                    Dim aaa() As String = razkvantaj(orgAdresarTabelaWZ)
                    For i As Integer = 0 To aaa.Length() - 1
                        If aaa(i).Length() > 1 AndAlso aaa(i).Substring(0, 2).ToUpper = "D." Then
                            Dim plj As String = aaa(i).Replace("D.", "").Trim.ToUpper
                            Dim dv As New System.Data.DataView(dISTPoljaKonsult)
                            dv.RowFilter = "2=2 and TABELA='" + adresarW.Trim + "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'ISTYEAR' and POLJE<>'MES' and POLJE<>'ISTMONTH' and polje='" + plj + "'"
                            dv.Sort = "tabela ASC"
                            If dv.Count > 0 Then
                                aaa(i) = "'" + nvd + "+ Me." + dv(0).Item("imeWeb").ToString.Trim() + ".Text + " + nvd + "'"
                            Else
                                aaa(i) = aaa(i).Replace("D.", "").Trim.ToUpper
                            End If
                        End If
                    Next
                    orgAdresarTabelaWZ = ustringaj(aaa).ToUpper()
                End If
                Try
                    Call formirajIzborUpitnikaZaUnos(folder, adresarW, opisAdresarW, tabelaW, spajanjeAdresarTabelaW, funkcijaW, orgAdresarTabelaWZ)
                Catch ex As System.Exception
                    ISTMessageBox.Show("Error at formirajIzborUpitnikaZaUnos" + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                '**
                Try
                    Call formirajPregledUnetihSlogova(folder, adresarW, spajanjeAdresarTabelaW, funkcijaW, orgAdresarTabelaW, orgAdresarTabelaWZ)
                Catch ex As System.Exception
                    ISTMessageBox.Show("Error at formirajPregledUnetihSlogova" + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            Next
        Else
            Dim aspxIzbUp As String = folder + "IzborUpitnikaZaUnos.aspx"
            Dim vbIzbUp As String = folder + "IzborUpitnikaZaUnos.aspx.vb"
            Dim aspxPUS As String = folder + "pregledUnetihSlogova.aspx"
            Dim vbPUS As String = folder + "pregledUnetihSlogova.aspx.vb"
            Try
                System.IO.File.Delete(aspxIzbUp)
                System.IO.File.Delete(vbIzbUp)
                System.IO.File.Delete(aspxPUS)
                System.IO.File.Delete(vbPUS)
            Catch ex As System.Exception

                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
            End Try
        End If

        'obrisi visak tj panelne strane koje nisu više potrebne
        For Each tab As System.Data.DataRow In dISTTABELEzaWeb.Rows
            If Not (tab.Item("T2").GetType Is GetType(System.DBNull)) Then
                If tab.Item("T2").ToString.Trim.ToUpper.IndexOf("PANEL") >= 0 Then
                    Try
                        Dim aspx As String = folder + tab.Item("tabela").ToString.Trim.ToUpper + ".aspx"
                        Dim vb As String = folder + tab.Item("tabela").ToString.Trim.ToUpper + ".aspx.vb"
                        Dim js As String = folderJS + tab.Item("tabela").ToString.Trim.ToUpper + ".js"
                        System.IO.File.Delete(aspx)
                        System.IO.File.Delete(vb)
                        System.IO.File.Delete(js)
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Finally
                    End Try
                End If
            End If
        Next

        Dim poruka As String = ""
        If kolikoNaWeb > 0 Then
            ''msg 105
            Dim msgtxt105 As String = getMessageText(dtMessages, "105", Me.jezik) + nvrd + nvrd
            poruka = poruka + msgtxt105 '"Web апликација генерисана." + nvrd + nvrd
            Dim pp As String = ""
            If generisano.Trim.ToUpper.IndexOf("USER") >= 0 Then
                Dim msgtxt106 As String = getMessageText(dtMessages, "106", Me.jezik) + nvrd
                pp = pp + msgtxt106
                'pp = pp + "- Креиран user IST_PPP који припада db_owner роли." + nvrd
            End If
            If generisano.Trim.ToUpper.IndexOf("POLJA") >= 0 Then
                Dim msgtxt107 As String = getMessageText(dtMessages, "107", Me.jezik) + nvrd
                pp = pp + msgtxt107
                'pp = pp + "- Креирана поља: WEBUNOS и MB (ако већ не постоји) у адресару." + nvrd
            End If
            If generisano.Trim.ToUpper.IndexOf("TABELA") >= 0 Then
                Dim msgtxt108 As String = getMessageText(dtMessages, "108", Me.jezik) + nvrd
                pp = pp + msgtxt108
                'pp = pp + "- Креирана табела Veza_KljucUserIstrazivanje." + nvrd
            End If
            If generisano.Trim.ToUpper.IndexOf("VIEW") >= 0 Then
                Dim msgtxt109 As String = getMessageText(dtMessages, "109", Me.jezik) + nvrd + nvrd
                pp = pp + msgtxt109
                'pp = pp + "- Креиран view vAdresarKljuceviSIfIST." + nvrd + nvrd
            End If
            Dim msgtxt110 As String = getMessageText(dtMessages, "110", Me.jezik) + nvrd
            If pp <> "" Then pp = msgtxt110 + nvrd + pp
            'If pp <> "" Then pp = "У бази:" + nvrd + pp
            poruka = poruka + pp

            ISTMessageBox.Show(poruka, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Function proveraAdresaraIVeza(ByVal sifIST As String, ByVal tabela As String, ByVal AdrRel As String, ByVal sta As String) As String

        proveraAdresaraIVeza = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim sql As String = ""
        Dim rez As String = ""

        '0.dodavanje IST_PPP usera ako ga nema
        sql = "SELECT * FROM sys.database_principals where type='S' and name='IST_PPP'"
        Dim dt0 As New System.Data.DataTable

        dt0 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        If dt0.Rows.Count = 0 Then
            'nema usera, kreiraj
            sql = "CREATE USER [IST_PPP] FOR LOGIN [IST_PPP] WITH DEFAULT_SCHEMA=[dbo]" + nvrd
            sql = sql + " EXEC sp_addrolemember 'db_owner', 'IST_PPP'"

            Dim ok1 As String = izvrsiSQL(sql, connPravaBaza)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER19", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            rez = rez + "USER"
        End If

        '1.dodavanje MB i WEBUNOS ako ne postoje
        'ako je adresar tabela:
        Dim adresar As String = ""
        Dim adrTabela As Boolean = False
        Dim adrView As Boolean = False
        Dim imaMBR As Boolean = False

        If sta = "R" Then
            '(select * from Adresar_SBS03 where kv=d.kv and god={GGG})
            If AdrRel.Trim.ToUpper.IndexOf("FROM") > 0 Then
                Dim ffrroomm As Integer = AdrRel.Trim.ToUpper.IndexOf(" FROM ") + 6
                Dim prviBlank As Integer = AdrRel.Substring(ffrroomm, AdrRel.Length - AdrRel.Trim.ToUpper.IndexOf(" FROM ") - 6 - 1).IndexOf(" ")
                If prviBlank < 0 Then
                    adresar = AdrRel.Substring(ffrroomm, AdrRel.Length - AdrRel.Trim.ToUpper.IndexOf(" FROM ") - 6 - 1)
                Else
                    adresar = AdrRel.Substring(ffrroomm, prviBlank)
                End If
            Else
                adresar = AdrRel
            End If
        End If
        If sta = "A" Then
            adresar = AdrRel
        End If

        sql = "select * from sys.objects where name='" + adresar + "'"
        Dim dtt As New System.Data.DataTable
        dtt = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)

        If dtt.Rows.Count = 0 Then
            'nema adresara, nesto nije potaman
        Else
            If dtt.Rows(0).Item("type").ToString.Trim.ToUpper = "U" Then adrTabela = True
            If dtt.Rows(0).Item("type").ToString.Trim.ToUpper = "V" Then adrView = True
        End If

        'WEBUNOS
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + adresar + "') and name='WEBUNOS'"
        Dim dt1 As New System.Data.DataTable
        dt1 = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)

        'MBR
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + adresar + "') and (name like '%MB%' or name like '%MATBR%')" +
" and name not like '%ops%' and name not like '%nas%' and name not like '%grad%' and name not like '%okr%' and name not like 'JMBG'"

        Dim dt2 As New System.Data.DataTable
        dt2 = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)

        Dim pv As String = ""
        Dim ov As String = ""

        If adrView = True Then
            sql = "SELECT isNull(OBJECT_DEFINITION (OBJECT_ID('" + adresar.Trim + "')),'') AS ddff"
            Dim dtv As New System.Data.DataTable
            dtv = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)

            Dim poc As Integer = dtv.Rows(0).Item("ddff").ToString.Trim.ToUpper.IndexOf("SELECT")
            Dim ffrroomm As Integer = dtv.Rows(0).Item("ddff").ToString.Trim.ToUpper.IndexOf("FROM")
            pv = dtv.Rows(0).Item("ddff").Substring(poc, ffrroomm - poc - 1)
            ov = dtv.Rows(0).Item("ddff").Substring(ffrroomm)
            If dt1.Rows.Count = 0 Then pv = pv + ", 1 as webunos"
            If dt2.Rows.Count = 0 Then
                pv = pv + ", '' as MB"
            Else
                imaMBR = True
            End If
            sql = "ALTER VIEW " + adresar.Trim + " AS " + pv + " " + ov
        End If
        If adrTabela = True Then
            If dt1.Rows.Count = 0 Then sql = "ALTER TABLE " + adresar.Trim + " add  WEBUNOS bit null" + nvrd
            If dt2.Rows.Count = 0 Then
                sql = sql + "ALTER TABLE " + adresar.Trim + " add  MBR char(8) NOT NULL DEFAULT('12345678')"
            Else
                imaMBR = True
            End If
        End If
        If sql <> "" Then

            Dim ok1 As String = izvrsiSQL(sql, connPravaBaza)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER20", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            rez = rez + "POLJA"
        End If

        '2.tabela tabelu Veza_KljucUserIstrazivanje
        sql = "select * from sys.objects where type='u' and name='Veza_KljucUserIstrazivanje'"
        Dim dt3 As New System.Data.DataTable
        dt3 = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)

        If dt3.Rows.Count = 0 Then
            Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\createVeza_KljucUserIstrazivanje.txt")
            sql = txt.ReadToEnd
            txt.Close()
            Dim ok1 As String = izvrsiSQL(sql, connPravaBaza)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER21", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            rez = rez + "TABELA"
        End If

        '3.view vAdresarKljucevi
        sifIST = sifIST.Replace("/", "")
        sifIST = sifIST.Replace("-", "")
        sql = "select * from sys.objects where type='v' and name='" + "vAdresarKljucevi" + sifIST.Trim + "'"
        Dim dt4 As New System.Data.DataTable
        dt4 = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)

        If dt4.Rows.Count = 0 Then
            Dim sqlKljuc As String = ""
            If imaMBR = False Then sqlKljuc = sqlKljuc + "MBR + " 'IST dodaje MB ali ne kao PK nego samo kao not null polje
            Dim dt5 As New System.Data.DataTable
            If adrTabela = True Then
                sql = "SELECT i.name AS IndexName, OBJECT_NAME(ic.OBJECT_ID) AS TableName, " +
                " COL_NAME(ic.OBJECT_ID,ic.column_id) AS Column_Name" +
                " FROM sys.indexes AS i INNER JOIN sys.index_columns AS ic" +
                " ON i.OBJECT_ID = ic.OBJECT_ID AND i.index_id = ic.index_id" +
                " WHERE i.is_primary_key = 1 and OBJECT_NAME(ic.OBJECT_ID) =  '" + adresar + "' and COL_NAME(ic.OBJECT_ID,ic.column_id)<>'GOD' and COL_NAME(ic.OBJECT_ID,ic.column_id)<>'MES' " +
                " and COL_NAME(ic.OBJECT_ID,ic.column_id)<>'ISTYEAR' and COL_NAME(ic.OBJECT_ID,ic.column_id)<>'ISTMONTH'"
                dt5 = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)
            End If
            If dt5.Rows.Count = 0 Then
                ''msg 111
                Dim msgtxt111 As String = getMessageText(dtMessages, "111", Me.jezik) + adresar + "! " + nvrd
                ''msg 112
                Dim msgtxt112 As String = getMessageText(dtMessages, "112", Me.jezik) + nvrd
                ISTMessageBox.Show(msgtxt111 + nvrd + msgtxt112, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If
            If adrView = True Then
                'vidi iz ISTa sta je PK
                sql = "select polje as Column_Name from dbo.vISTPoljaKLJUCPoTabeli ('" + vt + "','" + IzIst + "','" + adresar + "') where kljuc='P'"
                dt5 = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)
            End If

            For i As Integer = 0 To dt5.Rows.Count - 1
                sqlKljuc = sqlKljuc + dt5.Rows(i).Item("Column_Name").ToString.Trim.ToUpper + " + "
            Next
            sqlKljuc = sqlKljuc.Trim + ";"
            sqlKljuc = sqlKljuc.Replace("+;", "")
            sqlKljuc = sqlKljuc.Replace(";", "")
            Dim dt6 As New System.Data.DataTable
            sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + adresar + "')"
            dt6 = izvrsiSQLvratiDT(sql, connPravaBaza, Nothing)

            Dim sqlpolja As String = ""
            If imaMBR = False Then sqlpolja = sqlpolja + "MBR , " 'IST dodaje MB ali ne kao PK nego samo kao not null polje
            For i As Integer = 0 To dt6.Rows.Count - 1
                sqlpolja = sqlpolja + dt6.Rows(i).Item("name").ToString.Trim.ToUpper + " , "
            Next
            sqlpolja = sqlpolja.Trim + ";"
            sqlpolja = sqlpolja.Replace(",;", "")
            sqlpolja = sqlpolja.Replace(";", "")

            sql = "create view vAdresarKljucevi" + sifIST.Trim + " as select " + sqlpolja + "," +
    sqlKljuc + " as KLJUC from " + adresar + ""
            If sql <> "" Then
                Dim ok1 As String = izvrsiSQL(sql, connPravaBaza)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER22", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                rez = rez + "VIEW;"
            End If
        End If
        proveraAdresaraIVeza = rez
    End Function

    Sub formirajZaAdm(ByVal sifIST As String, ByVal opisIST As String, ByVal folder As String, ByVal konekcija As String, ByVal periodika As String)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'Default.aspx se samo kopira
        Dim txt As String
        txt = folder + "potrebnoZaWebAdministratore.txa"
        Dim sbtxt As System.Text.StringBuilder = New System.Text.StringBuilder
        sbtxt.Length = 0
        Dim txttxt As New System.IO.StreamReader(txt)
        Dim strtxt As String = txttxt.ReadToEnd
        txttxt.Close()

        strtxt = strtxt.Replace("99SIfIST99", sifIST)
        strtxt = strtxt.Replace("99NAZIV99", opisIST)
        strtxt = strtxt.Replace("99WIST99", folder.Replace("C:\", "").Replace("\", "/"))
        strtxt = strtxt.Replace("99BAZASERVER99", konekcija.ToUpper.Replace("USER ID=IST_PPP;PASSWORD=GILGAMES", ""))
        strtxt = strtxt.Replace(".statsrb.lan", "")
        strtxt = strtxt.Replace(".STATSRB.LAN", "")
        strtxt = strtxt.Replace("99PERIODIKA99", periodika)

        Dim dv04 As New System.Data.DataView(dISTVEZAzaWEB)
        dv04.RowFilter = "2=2 and jesteMB<>2"
        dv04.Sort = "jesteMb DESC, rbr ASC"
        Dim opis As String = ""
        For i As Integer = 0 To dv04.Count - 1
            opis = opis + dv04(i).Item("opis").ToString.Trim + nvrd
        Next
        If opis = "" Then opis = "XXXXXXXXXXXXXXXXXXXXX"
        strtxt = strtxt.Replace("99KLJUCADRESAR99", opis)

        sbtxt.Append(strtxt + nvrd)

        Dim outfiletxt As New System.IO.StreamWriter(txt, False, System.Text.Encoding.UTF8)
        outfiletxt.Write(sbtxt.ToString())
        outfiletxt.Flush()
        outfiletxt.Close()

    End Sub

    Sub formirajDefaultVBRel(ByVal sifIST As String, ByVal folder As String, ByVal tabela As String, ByVal relacija As String, ByVal dataSetIST As System.Data.DataSet)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'Default.aspx se samo kopira
        Dim VB As String
        VB = folder + "Default.aspx.vb"
        Dim sbVB As System.Text.StringBuilder = New System.Text.StringBuilder
        sbVB.Length = 0
        Dim txtVB As New System.IO.StreamReader(VB)
        Dim strVB As String = txtVB.ReadToEnd
        txtVB.Close()

        sifIST = sifIST.Replace("/", "")
        sifIST = sifIST.Replace("-", "")
        Dim vak As String = "dbo.vAdresarKljucevi" + sifIST.Trim
        'pitam da li postoji vAdresarKljuceviSIfIST
        'samo provera, trebalo bi ako ne postoji da ga formira IST
        Dim sqlAAA As String = "SELECT isNull(OBJECT_DEFINITION (OBJECT_ID('" + vak + "')),'') AS ddff"
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(sqlAAA, connPravaBaza, Nothing)

        Dim aaa As String = dt.Rows(0).Item("ddff")

        If aaa = "" Then   'vAdresarKljuceviSIfIST ne postoji
            ''msg 113
            Dim msgtxt113 As String = getMessageText(dtMessages, "113", Me.jezik)
            ''msg 114
            Dim msgtxt114 As String = getMessageText(dtMessages, "114", Me.jezik)
            ''msg 115
            Dim msgtxt115 As String = getMessageText(dtMessages, "115", Me.jezik)
            ''msg 116
            Dim msgtxt116 As String = getMessageText(dtMessages, "116", Me.jezik)
            Dim por As String = msgtxt113 + vak + msgtxt114 + nvrd
            por = por + msgtxt115 + nvrd
            por = por + msgtxt116
            ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'izvlacim iz vAdresarKljuceviSIfIST sta je KLJUC
        Dim kljuc As String = ""
        Dim poc As Integer = aaa.Trim.ToUpper.IndexOf("SELECT")
        Dim ffrroomm As Integer = aaa.Trim.ToUpper.IndexOf("FROM")
        '6-duzina SELECT, 4 - duzina FROM
        aaa = aaa.Trim.Substring(poc + 6, ffrroomm - poc - 1)
        Dim trt() As String = {}
        trt = Microsoft.VisualBasic.Split(aaa, ",")
        For i As Integer = 0 To trt.GetUpperBound(0)
            If trt(i).Trim.ToUpper.IndexOf("KLJUC") > 0 Then
                kljuc = trt(i)
                Exit For
            End If
        Next

        kljuc = kljuc.Trim.ToUpper.Replace("AS", "").Replace("KLJUC", "").Replace("SELECT", "").Replace("FROM", "").Trim
        Dim sastojciKljucaKD() As String = {}
        sastojciKljucaKD = Microsoft.VisualBasic.Split(kljuc, "+")

        Dim dISTLKRelacija As New System.Data.DataTable
        Dim sql As String = " select * from dbo.vISTLKrelacija ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "' and adresarTabela='" & relacija & "'"
        dISTLKRelacija.Clear()

        dISTLKRelacija = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        Dim spojiPolja As String = dISTLKRelacija.Rows(0).Item("spojiPoljaTabela")
        Dim spojiPoljaAdresar() As String = {}
        Dim spojiPoljaTabela() As String = {}
        Dim pom() As String = {}
        pom = Microsoft.VisualBasic.Split(spojiPolja, "AND")
        For i As Integer = 0 To pom.GetUpperBound(0)
            Dim pom1() As String = {}
            pom1 = Microsoft.VisualBasic.Split(pom(i), "=")
            ReDim Preserve spojiPoljaTabela(i)
            ReDim Preserve spojiPoljaAdresar(i)
            spojiPoljaTabela(i) = pom1(0)
            spojiPoljaAdresar(i) = pom1(1)
        Next

        Dim poljaTabela() As String = {}
        '99KLJUCKOM99 je kljuc tabele
        Dim ii As Integer = -1
        ReDim Preserve poljaTabela(ii)

        Dim dvT As New System.Data.DataView(dISTPoljaKonsult)
        dvT.RowFilter = "2=2 and tabela='" + tabela + "' and isnull(KLJUC,'')='P' and POLJE<>'GOD' and POLJE<>'MES' and POLJE<>'ISTYEAR' and POLJE<>'ISTMONTH'"
        dvT.Sort = "rbr ASC"

        For i As Integer = 0 To dvT.Count - 1
            For k As Integer = 0 To spojiPoljaTabela.GetUpperBound(0)
                If spojiPoljaTabela(k).Trim.ToUpper = dvT(i).Item("polje").ToString.Trim.ToUpper Then
                    spojiPoljaAdresar(k) = spojiPoljaAdresar(k) + "#" + dvT(i).Item("duzina").ToString.ToUpper.Trim
                    Exit For
                End If
            Next
        Next

        Dim ppp As String = "" : Dim pppkom As String = "" : Dim sesppp As String = "" : Dim pppdim As String = ""
        'mbr
        Dim odakle As Integer = 1 : Dim uDuzini As String = 8

        '0 uvek MBR
        Dim sta As String = sastojciKljucaKD(0).Trim
        pppdim = pppdim + "Dim " + sta + " As String" + nvrd
        ppp = ppp + "If Session(" + nvd + sta + nvd + ") Is Nothing Then" + nvrd
        ppp = ppp + "     " + sta + " =Mid(Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")," + CStr(odakle) + "," + CStr(uDuzini) + ")" + nvrd
        ppp = ppp + "      Session(" + nvd + sta.Trim + nvd + ") = " + sta + "" + nvrd
        ppp = ppp + "Else" + nvrd
        ppp = ppp + "     " + sta + " = Session(" + nvd + sta + nvd + ")" + nvrd
        ppp = ppp + "End If" + nvrd

        'uzmi prvi MBR iz Adresara
        '(select * from Adresar_SBS03 where kv=d.kv and god={GGG})
        Dim adresarTabela As String = ""
        If relacija.Trim.ToUpper.IndexOf("FROM") > 0 Then
            Dim fff As Integer = relacija.Trim.ToUpper.IndexOf(" FROM ") + 6
            Dim prviBlank As Integer = relacija.Substring(fff, relacija.Length - relacija.Trim.ToUpper.IndexOf(" FROM ") - 6 - 1).IndexOf(" ")
            If prviBlank < 0 Then
                adresarTabela = relacija.Substring(fff, relacija.Length - relacija.Trim.ToUpper.IndexOf(" FROM ") - 6 - 1)
            Else
                adresarTabela = relacija.Substring(fff, prviBlank)
            End If
        Else
            adresarTabela = relacija
        End If
        Dim dtA As New System.Data.DataTable
        Dim sqlA As String = " select max(" + sta + ") as " + sta + " from " + adresarTabela
        dtA.Clear()

        dtA = izvrsiSQLvratiDT(sqlA, connPravaBaza, Nothing)

        If dtA.Rows.Count > 0 AndAlso dtA.Rows(0).Item(sta).ToString.Trim.Length > 0 Then
            pppkom = "" + sta + "=" + nvd + dtA.Rows(0).Item(sta).ToString.Trim + nvd + " : Session(" + nvd + sta + nvd + ")=" + sastojciKljucaKD(0) + nvrd
        Else
            pppkom = "" + sta + "=" + nvd + "12345678" + nvd + " : Session(" + nvd + sta + nvd + ")=" + sastojciKljucaKD(0) + nvrd
        End If

        'ostatak
        For i As Integer = 1 To sastojciKljucaKD.GetUpperBound(0)
            odakle = odakle + uDuzini
            sta = sastojciKljucaKD(i).Trim
            For k As Integer = 0 To spojiPoljaAdresar.GetUpperBound(0)
                If sta = Microsoft.VisualBasic.Split(spojiPoljaAdresar(k).ToString.ToUpper.Trim, "#")(0).Trim Then
                    uDuzini = CInt(Microsoft.VisualBasic.Split(spojiPoljaAdresar(k).ToString.ToUpper.Trim, "#")(1).Trim)
                    Exit For
                End If
            Next
            pppdim = pppdim + "Dim " + sta + " As String" + nvrd
            ppp = ppp + "If Session(" + nvd + sta + nvd + ") Is Nothing Then" + nvrd
            ppp = ppp + "     " + sta + " =Mid(Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")," + CStr(odakle) + "," + CStr(uDuzini) + ")" + nvrd
            ppp = ppp + "      Session(" + nvd + sta.Trim + nvd + ") = " + sta + "" + nvrd
            ppp = ppp + "Else" + nvrd
            ppp = ppp + "     " + sta + " = Session(" + nvd + sta + nvd + ")" + nvrd
            ppp = ppp + "End If" + nvrd

            'konkretni da bi radilo odmah sa lokalne masine
            Dim dtAB As New System.Data.DataTable
            Dim sqlAB As String = " select max(" + sta + ") as " + sta + " from " + adresarTabela
            dtA.Clear()

            dtAB = izvrsiSQLvratiDT(sqlAB, connPravaBaza, Nothing)

            If dtA.Rows.Count > 0 AndAlso dtA.Rows(0).Item(sta).ToString.Trim.Length > 0 Then
                pppkom = "" + sta + "=" + nvd + dtA.Rows(0).Item(sta).ToString.Trim + nvd + " : Session(" + nvd + sta + nvd + ")=" + sastojciKljucaKD(0) + nvrd
            Else
                Dim aa As String = ""
                For im As Integer = 0 To uDuzini - 1
                    aa = aa + "1"
                Next
                pppkom = pppkom + "" + sta + "=" + nvd + aa + nvd + " : Session(" + nvd + sta + nvd + ")=" + sta + nvrd
            End If
        Next

        strVB = strVB.Replace("99SASTOJCIKLJUCA99", ppp)
        strVB = strVB.Replace("99DIMOSTALIDEOKLJUCA99", pppdim)
        strVB = strVB.Replace("99KLJUCKOM99", pppkom)
        strVB = strVB.Replace("99PROJEKTANT99", Projektant)
        strVB = strVB.Replace("99SIfIST99", sifIST.Trim.ToUpper)

        sbVB.Append(strVB + nvrd)

        Dim outfileVB As New System.IO.StreamWriter(VB, False, System.Text.Encoding.UTF8)
        outfileVB.Write(sbVB.ToString())
        outfileVB.Flush()
        outfileVB.Close()

    End Sub

    Sub formirajDefaultVBAdr(ByVal sifIST As String, ByVal folder As String, ByVal tabela As String, ByVal adresar As String, ByVal dataSetIST As System.Data.DataSet)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'Default.aspx se samo kopira
        Dim VB As String
        VB = folder + "Default.aspx.vb"
        Dim sbVB As System.Text.StringBuilder = New System.Text.StringBuilder
        sbVB.Length = 0
        Dim txtVB As New System.IO.StreamReader(VB)
        Dim strVB As String = txtVB.ReadToEnd
        txtVB.Close()

        sifIST = sifIST.Replace("/", "")
        sifIST = sifIST.Replace("-", "")
        Dim vak As String = "dbo.vAdresarKljucevi" + sifIST.Trim

        'pitam da li postoji vAdresarKljuceviSIfIST
        Dim sqlAAA As String = "SELECT isNull(OBJECT_DEFINITION (OBJECT_ID('" + vak + "')),'') AS ddff"
        Dim dt As New System.Data.DataTable

        dt = izvrsiSQLvratiDT(sqlAAA, connPravaBaza, Nothing)

        Dim aaa As String = dt.Rows(0).Item("ddff")
        If aaa = "" Then   'vAdresarKljuceviSIfIST ne postoji

            ''msg 113
            Dim msgtxt113 As String = getMessageText(dtMessages, "113", Me.jezik)
            ''msg 114
            Dim msgtxt114 As String = getMessageText(dtMessages, "114", Me.jezik)
            ''msg 115
            Dim msgtxt115 As String = getMessageText(dtMessages, "115", Me.jezik)
            ''msg 116
            Dim msgtxt116 As String = getMessageText(dtMessages, "116", Me.jezik)

            Dim por As String = msgtxt113 + vak + msgtxt114 + nvrd
            por = por + msgtxt115 + nvrd
            por = por + msgtxt116
            ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim kljuc As String = ""

        Dim poc As Integer = aaa.Trim.ToUpper.IndexOf("SELECT")
        Dim ffrroomm As Integer = aaa.Trim.ToUpper.IndexOf("FROM")
        aaa = aaa.Substring(poc + 6, ffrroomm - poc - 1)
        Dim trt() As String = {}
        trt = Microsoft.VisualBasic.Split(aaa, ",")
        For i As Integer = 0 To trt.GetUpperBound(0)
            If trt(i).IndexOf("KLJUC") > 0 Then
                kljuc = trt(i)
                Exit For
            End If
        Next

        kljuc = kljuc.Trim.ToUpper.Replace("AS", "").Replace("KLJUC", "").Replace("SELECT", "").Replace("FROM", "").Trim
        Dim sastojciKljucaKD() As String = {}
        sastojciKljucaKD = Microsoft.VisualBasic.Split(kljuc, "+")

        Dim dISTLKAdresar As New System.Data.DataTable
        Dim sql As String = " select * from dbo.vISTLKAdresar ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "' and adresarTabela='" & adresar & "'"
        dISTLKAdresar.Clear()

        dISTLKAdresar = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        Dim spojiPoljaTabela As String = dISTLKAdresar.Rows(0).Item("spojiPoljaTabela")
        Dim poljaTabela() As String = {}
        poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela, ",")

        Dim s As String = ""
        For j As Integer = 0 To poljaTabela.GetUpperBound(0)
            If poljaTabela(j).ToString.ToUpper.Trim = "GOD" OrElse poljaTabela(j).ToString.ToUpper.Trim = "ISTYEAR" Then
            ElseIf poljaTabela(j).ToString.ToUpper.Trim = "MES" OrElse poljaTabela(j).ToString.ToUpper.Trim = "ISTMONTH" Then
            Else
                s = s + poljaTabela(j) + ","
            End If
        Next
        spojiPoljaTabela = s ' ovo sluzi samo da izbacim god i mes
        poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela, ",")

        Dim dvT As New System.Data.DataView(dISTPoljaKonsult)
        dvT.RowFilter = "2=2 and tabela='" + tabela + "' and isnull(KLJUC,'')='P' and POLJE<>'GOD' and POLJE<>'MES' and POLJE<>'ISTYEAR' and POLJE<>'ISTMONTH'"
        dvT.Sort = "rbr ASC"

        For i As Integer = 0 To dvT.Count - 1
            For j As Integer = 0 To poljaTabela.GetUpperBound(0)
                If dvT(i).Item("polje").ToString.Trim.ToUpper = poljaTabela(j).ToString.ToUpper.Trim Then
                    poljaTabela(j) = poljaTabela(j).ToString.ToUpper.Trim + "#" + dvT(i).Item("duzina").ToString.ToUpper.Trim + ","
                End If
            Next
        Next

        Dim ppp As String = "" : Dim pppkom As String = "" : Dim sesppp As String = "" : Dim pppdim As String = ""
        'mbr
        Dim odakle As Integer = 1 : Dim uDuzini As String = 8

        Dim sta As String = sastojciKljucaKD(0).Trim
        pppdim = pppdim + "Dim " + sta + " As String" + nvrd
        ppp = ppp + "If Session(" + nvd + sta + nvd + ") Is Nothing Then" + nvrd
        ppp = ppp + "     " + sta + " =Mid(Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")," + CStr(odakle) + "," + CStr(uDuzini) + ")" + nvrd
        ppp = ppp + "      Session(" + nvd + sta.Trim + nvd + ") = " + sta + "" + nvrd
        ppp = ppp + "Else" + nvrd
        ppp = ppp + "     " + sta + " = Session(" + nvd + sta + nvd + ")" + nvrd
        ppp = ppp + "End If" + nvrd
        'zadaj konkretni da bi radilo sa lokalne masine
        Dim dtA As New System.Data.DataTable
        Dim sqlA As String = " select max(" + sta + ") as " + sta + " from " + adresar
        dtA.Clear()

        dtA = izvrsiSQLvratiDT(sqlA, connPravaBaza, Nothing)

        If dtA.Rows.Count > 0 AndAlso dtA.Rows(0).Item(sta).ToString.Trim.Length > 0 Then
            pppkom = "" + sta + "=" + nvd + dtA.Rows(0).Item(sta).ToString.Trim + nvd + " : Session(" + nvd + sta + nvd + ")=" + sastojciKljucaKD(0) + nvrd
        Else
            pppkom = "" + sta + "=" + nvd + "12345678" + nvd + " : Session(" + nvd + sta + nvd + ")=" + sastojciKljucaKD(0) + nvrd
        End If

        'ostatak
        For i As Integer = 1 To sastojciKljucaKD.GetUpperBound(0)
            odakle = odakle + uDuzini
            sta = sastojciKljucaKD(i).Trim 'Microsoft.VisualBasic.Split(poljaTabela(i - 1).ToString.ToUpper.Trim, "#")(0).trim
            For k As Integer = 0 To poljaTabela.GetUpperBound(0)
                If sta = Microsoft.VisualBasic.Split(poljaTabela(k).ToString.ToUpper.Trim, "#")(0).Trim Then
                    uDuzini = CInt(Microsoft.VisualBasic.Split(poljaTabela(k).ToString.ToUpper.Trim, "#")(1).Trim)
                    Exit For
                End If
            Next
            pppdim = pppdim + "Dim " + sta + " As String" + nvrd
            ppp = ppp + "If Session(" + nvd + sta + nvd + ") Is Nothing Then" + nvrd
            ppp = ppp + "     " + sta + " =Mid(Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")," + CStr(odakle) + "," + CStr(uDuzini) + ")" + nvrd
            ppp = ppp + "      Session(" + nvd + sta.Trim + nvd + ") = " + sta + "" + nvrd
            ppp = ppp + "Else" + nvrd
            ppp = ppp + "     " + sta + " = Session(" + nvd + sta + nvd + ")" + nvrd
            ppp = ppp + "End If" + nvrd

            'zadaj konkretni da bi radilo sa lokalne masine
            Dim dtAB As New System.Data.DataTable
            Dim sqlAB As String = " select max(" + sta + ") as " + sta + " from " + adresar
            dtA.Clear()

            dtAB = izvrsiSQLvratiDT(sqlAB, connPravaBaza, Nothing)

            If dtA.Rows.Count > 0 AndAlso dtA.Rows(0).Item(sta).ToString.Trim.Length > 0 Then
                pppkom = "" + sta + "=" + nvd + dtA.Rows(0).Item(sta).ToString.Trim + nvd + " : Session(" + nvd + sta + nvd + ")=" + sastojciKljucaKD(0) + nvrd
            Else
                Dim aa As String = ""
                For im As Integer = 0 To uDuzini - 1
                    aa = aa + "1"
                Next
                pppkom = pppkom + "" + sta + "=" + nvd + aa + nvd + " : Session(" + nvd + sta + nvd + ")=" + sta + nvrd
            End If
        Next

        strVB = strVB.Replace("99SASTOJCIKLJUCA99", ppp)
        strVB = strVB.Replace("99DIMOSTALIDEOKLJUCA99", pppdim)
        strVB = strVB.Replace("99KLJUCKOM99", pppkom)
        strVB = strVB.Replace("99PROJEKTANT99", Projektant)
        strVB = strVB.Replace("99SIfIST99", sifIST.Trim.ToUpper)

        sbVB.Append(strVB + nvrd)

        Dim outfileVB As New System.IO.StreamWriter(VB, False, System.Text.Encoding.UTF8)
        outfileVB.Write(sbVB.ToString())
        outfileVB.Flush()
        outfileVB.Close()

    End Sub

    Sub formirajIzborUpitnikaZaUnos(ByVal folder As String, ByVal adresar As String, ByVal opisAdresar As String,
ByVal tabela As String, ByVal spajanjeAdresarTabela As String, ByVal funkcija As String, ByVal orgAdresarTabela As String)
        ''IzborUpitnikaZaUnos
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim podtab As String = ""
        'IzborUpitnikaZaUnos.aspx
        Dim ASPX As String
        ASPX = folder + "IzborUpitnikaZaUnos.aspx"
        Dim sbASPX As System.Text.StringBuilder = New System.Text.StringBuilder
        sbASPX.Length = 0
        Dim txtASPX As New System.IO.StreamReader(ASPX)
        Dim strASPX As String = txtASPX.ReadToEnd
        txtASPX.Close()
        Dim podtabASPX As String = ""
        strASPX = strASPX.Replace("99ADRESAR99", adresar)

        'ako tabela ima mes
        If imaGODMES(tabela).Trim.ToUpper.IndexOf("MES") >= 0 Then
            strASPX = strASPX.Replace("99TKMES99", dajTKMES())
        Else
            strASPX = strASPX.Replace("99TKMES99", "")
        End If
        'ako tabela ima KV
        If imaGODMES(tabela).Trim.ToUpper.IndexOf("KV") >= 0 Then
            strASPX = strASPX.Replace("99TKKV99", dajTKKV())
        Else
            strASPX = strASPX.Replace("99TKKV99", "")
        End If

        strASPX = strASPX.Replace("99opistabele99", opisAdresar)
        strASPX = strASPX.Replace("99KLJUCADRESAR99", spremiKljucString(adresar).Replace("""", ""))
        sbASPX.Append(strASPX + nvrd)

        Dim outfileASPX As New System.IO.StreamWriter(ASPX, False, System.Text.Encoding.UTF8)
        outfileASPX.Write(sbASPX.ToString())
        outfileASPX.Flush()
        outfileASPX.Close()

        'IzborUpitnikaZaUnos.vb
        Dim VB As String
        VB = folder + "IzborUpitnikaZaUnos.aspx.vb"
        Dim sbVB As System.Text.StringBuilder = New System.Text.StringBuilder
        sbVB.Length = 0
        Dim txtVB As New System.IO.StreamReader(VB)
        Dim strVB As String = txtVB.ReadToEnd
        txtVB.Close()
        strVB = strVB.Replace("99konekcija99", konekcija)

        strVB = strVB.Replace("99POLJAADRESAR99", spremiPoljaTabeleSaZarezom(adresar, "A"))

        strVB = strVB.Replace("99ADRESAR99", adresar)
        If funkcija = "A" Then
            strVB = strVB.Replace("99ADRREL99", adresar)
        Else
            strVB = strVB.Replace("99ADRREL99", orgAdresarTabela)
        End If
        strVB = strVB.Replace("99TABELA99", tabela)

        strVB = strVB.Replace("99WHEREVRTACKAADRESAR99", spremiWhereVRTACKA(adresar, True, True))
        strVB = strVB.Replace("99WHEREVRTACKATABELA99", spremiWhereVRTACKA(tabela, True))

        Dim dv04 As New System.Data.DataView(dISTVEZAzaWEB)
        dv04.RowFilter = "2=2 and adresarTabela='" + adresar.Trim + "'"
        dv04.Sort = "jesteMb DESC, rbr ASC"
        Dim poljaveza As String = ""
        For i As Integer = 0 To dv04.Count - 1
            poljaveza = poljaveza + dv04(i).Item("veza").ToString.Trim + ","
        Next
        poljaveza = poljaveza + ";"
        poljaveza = poljaveza.Replace(",;", "")
        strVB = strVB.Replace("99POLJAVEZA99", poljaveza)

        Dim kljA As String = spremiKljucString(adresar).Replace("""", "")
        Dim kljT As String = spremiKljucString(tabela).Replace("""", "")
        Dim kljNizA As String() = Microsoft.VisualBasic.Split(kljA, ",")
        Dim spajanjeAT As String = ""
        Dim spajanjeAV As String = ""
        Dim kljUrl As String = ""
        Dim kljUrl1 As String = "" + nvd + ""
        Dim kljUrl2 As String = ""
        Dim kljNizT As String()
        kljA = ""
        If funkcija = "A" Then
            kljNizT = Microsoft.VisualBasic.Split(spajanjeAdresarTabela, ",")
            For i As Integer = 0 To kljNizA.GetUpperBound(0)
                kljA = kljA + "Dim " + kljNizA(i) + " As String =gv" + adresar.Trim + ".DataKeys(e.Row.RowIndex)(" + CStr(i).Trim + ").ToString()" + nvrd
                kljUrl = kljUrl + "Dim " + kljNizA(i) + " As String =gv" + adresar.Trim + ".DataKeys(gv" + adresar.Trim + ".SelectedRow.RowIndex)(" + CStr(i).Trim + ").ToString()" + nvrd
                kljUrl1 = kljUrl1 + kljNizT(i) + "={" + CStr(i).Trim + "}&"
                kljUrl2 = kljUrl2 + ", " + kljNizA(i)
                If kljNizA(i).Trim.ToUpper <> "GOD" AndAlso kljNizA(i).Trim.ToUpper <> "MES" AndAlso kljNizA(i).Trim.ToUpper <> "ISTYEAR" AndAlso kljNizA(i).Trim.ToUpper <> "ISTMONTH" Then
                    spajanjeAV = spajanjeAV + " ADRREL." + kljNizA(i).Trim + "=VEZA." + kljNizA(i).Trim + " AND "
                End If
                spajanjeAT = spajanjeAT + " ADRREL." + kljNizA(i).Trim + "=" + tabela.Trim + "." + kljNizT(i).Trim + " AND "
            Next
        Else
            Dim kljNizTRel As String = ""
            spajanjeAdresarTabela = spajanjeAdresarTabela.ToUpper.Trim.Replace(" =", "=").Replace("= ", "=")
            kljNizT = Microsoft.VisualBasic.Split(spajanjeAdresarTabela.ToUpper.Trim, " AND ")
            For i As Integer = 0 To kljNizT.GetUpperBound(0)
                kljNizTRel = kljNizTRel + Microsoft.VisualBasic.Split(kljNizT(i), "=")(0) + ","
                spajanjeAT = spajanjeAT + tabela.Trim + "." + Microsoft.VisualBasic.Split(kljNizT(i), "=")(0) + "= ADRREL." + Microsoft.VisualBasic.Split(kljNizT(i), "=")(1) + " AND "
            Next
            kljNizTRel = kljNizTRel + ")"
            kljNizTRel = kljNizTRel.Replace(",)", "")
            kljNizT = Microsoft.VisualBasic.Split(kljNizTRel, ",")

            For i As Integer = 0 To kljNizA.GetUpperBound(0)
                kljA = kljA + "Dim " + kljNizA(i) + " As String =gv" + adresar.Trim + ".DataKeys(e.Row.RowIndex)(" + CStr(i).Trim + ").ToString()" + nvrd
                kljUrl = kljUrl + "Dim " + kljNizA(i) + " As String =gv" + adresar.Trim + ".DataKeys(gv" + adresar.Trim + ".SelectedRow.RowIndex)(" + CStr(i).Trim + ").ToString()" + nvrd
                kljUrl2 = kljUrl2 + ", " + kljNizA(i)
                If kljNizA(i).Trim.ToUpper <> "GOD" AndAlso kljNizA(i).Trim.ToUpper <> "MES" AndAlso kljNizA(i).Trim.ToUpper <> "ISTYEAR" AndAlso kljNizA(i).Trim.ToUpper <> "ISTMONTH" Then
                    spajanjeAV = spajanjeAV + " ADRREL." + kljNizA(i).Trim + "=VEZA." + kljNizA(i).Trim + " AND "
                End If
            Next

            If kljNizT.GetUpperBound(0) = kljNizA.GetUpperBound(0) Then
                For i As Integer = 0 To kljNizA.GetUpperBound(0)
                    kljUrl1 = kljUrl1 + kljNizT(i) + "={" + CStr(i).Trim + "}&"
                Next
            ElseIf kljNizT.GetUpperBound(0) < kljNizA.GetUpperBound(0) Then
                '#WebRelacija{(select * from Adresar_SBS03 where kv=d.kv and god={GGG});mbr=mbr:sifopst=sifopst,terpod=terpod,rbr=rbr,del=del,nazivfirme=nazivfirme}
                Dim spoji As String()
                spoji = Microsoft.VisualBasic.Split(spajanjeAdresarTabela.ToUpper.Trim, " AND ")
                For i As Integer = 0 To spoji.GetUpperBound(0)
                    'Microsoft.VisualBasic.Split(spoji(i), "=")(0)     'polje iz tabele
                    'Microsoft.VisualBasic.Split(spoji(i), "=")(1)     'polje iz adresara
                    For a As Integer = 0 To kljNizA.GetUpperBound(0)
                        If kljNizA(a).ToUpper.Trim = Microsoft.VisualBasic.Split(spoji(i), "=")(1).ToUpper.Trim Then
                            kljUrl1 = kljUrl1 + Microsoft.VisualBasic.Split(spoji(i), "=")(1) + "={" + CStr(a).Trim + "}&"
                        End If
                    Next
                Next
            ElseIf kljNizT.GetUpperBound(0) > kljNizA.GetUpperBound(0) Then
                'videcemo
            End If
        End If

        spajanjeAT = spajanjeAT + ";"
        spajanjeAT = spajanjeAT.Replace(" AND ;", "")
        spajanjeAV = spajanjeAV + ";"
        spajanjeAV = spajanjeAV.Replace(" AND ;", "")
        strVB = strVB.Replace("99SPAJANJEAT99", spajanjeAT)
        strVB = strVB.Replace("99SPAJANJEAVEZA99", spajanjeAV)
        strVB = strVB.Replace("99KLJUCTABELA99", kljT)
        strVB = strVB.Replace("99POLJAVEZA99", poljaveza)

        kljUrl1 = kljUrl1 + ";"
        kljUrl1 = kljUrl1.Replace("&;", "")

        strVB = strVB.Replace("99KLJUCADRESAR99", kljA)
        strVB = strVB.Replace("99URLKLJUCADRESAR99", kljUrl)
        strVB = strVB.Replace("99URL99", kljUrl1 + "" + nvd + "" + kljUrl2)

        strVB = strVB.Replace("99VRTACKAIZSESIJE99", vrtackaIzSesije(tabela))
        strVB = strVB.Replace("99VRTACKAUSESIJU99", vrtackaUSesiju(tabela))

        Dim k As String = ""
        If imaGODMES(tabela).Trim.ToUpper.IndexOf("MES") >= 0 OrElse imaGODMES(tabela).Trim.ToUpper.IndexOf("ISTMONTH") >= 0 Then
            k = k + "Me.TK_MES.Enabled = False" + nvrd
        End If
        If imaGODMES(tabela).Trim.ToUpper.IndexOf("KV") >= 0 Then
            k = k + "Me.TK_KV.Enabled = False" + nvrd
        End If
        If imaGODMES(tabela).Trim.ToUpper.IndexOf("MES") < 0 And imaGODMES(tabela).Trim.ToUpper.IndexOf("ISTMONTH") < 0 And imaGODMES(tabela).Trim.ToUpper.IndexOf("KV") < 0 Then
            k = ""
        End If

        strVB = strVB.Replace("99TKMESENABLEDFALSE99", k)
        sbVB.Append(strVB + nvrd)

        Dim outfileVB As New System.IO.StreamWriter(VB, False, System.Text.Encoding.UTF8)
        outfileVB.Write(sbVB.ToString())
        outfileVB.Flush()
        outfileVB.Close()

    End Sub

    Sub formirajMasterPageIST(ByVal folder As String, ByVal opis As String, ByVal kojiMP As String, ByVal periodika As String)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim masterA As String
        masterA = folder + "MasterPageIST" + kojiMP.Trim + ".master"
        Dim sbMasterA As System.Text.StringBuilder = New System.Text.StringBuilder
        sbMasterA.Length = 0
        Dim txtMasterA As New System.IO.StreamReader(masterA)
        Dim strMasterA As String = txtMasterA.ReadToEnd
        txtMasterA.Close()
        strMasterA = strMasterA.Replace("99opisIST99", opis)

        Dim masterVB As String
        masterVB = folder + "MasterPageIST" + kojiMP.Trim + ".master.vb"
        Dim sbMasterVB As System.Text.StringBuilder = New System.Text.StringBuilder
        sbMasterVB.Length = 0
        Dim txtMasterVB As New System.IO.StreamReader(masterVB)
        Dim strMasterVB As String = txtMasterVB.ReadToEnd
        txtMasterVB.Close()

        Dim nadtabA As String = ""
        Dim nadtabVB As String = ""
        Dim nadTab As String = ""
        Dim nadTabOpis As String = ""
        Dim podTab As String = ""
        Dim sqlNadTab As String = "select tabela,opis from  dbo.vISTTABELEzaWEB ('" + vt + "','" + IzIst + "') where DG='G'"
        Dim dsNadTab As New System.Data.DataTable

        dsNadTab = izvrsiSQLvratiDT(sqlNadTab, ISTConnectionString, Nothing)

        If dsNadTab.Rows.Count = 0 Then
            strMasterA = strMasterA.Replace("99NADTABELE99", "")
        Else
            Dim a As String = ""
            Dim vb As String = ""
            For j As Integer = 0 To dsNadTab.Rows.Count - 1
                nadTab = dsNadTab.Rows(j).Item("tabela").ToString.Trim.ToUpper

                nadtabA = nadtabA + nvrd + dajNadTabeleZaMPISTaspx(nadTab) + nvrd
                a = a + nadtabA + nvrd

                nadtabVB = nadtabVB + nvrd + dajNadTabeleZaMPISTvb(nadTab) + nvrd
                vb = vb + nadtabVB + nvrd
            Next
            strMasterA = strMasterA.Replace("99NADTABELE99", a)
            strMasterVB = strMasterVB.Replace("99NADTABELE99", vb)

            Dim vrt As String = ""
            strMasterVB = strMasterVB.Replace("99MASTERVRTACKA99", vrtackaMaster(nadTab))
            strMasterVB = strMasterVB.Replace("99PERIODIKA99", periodika.Trim.ToUpper)
            strMasterVB = strMasterVB.Replace("99konekcija99", konekcija)
            strMasterVB = strMasterVB.Replace("99UPITLKWEB99", lkwebMaster(nadTab))

        End If

        sbMasterA.Append(strMasterA + nvrd)
        Dim outfileMasterA As New System.IO.StreamWriter(masterA, False, System.Text.Encoding.UTF8)
        outfileMasterA.Write(sbMasterA.ToString())
        outfileMasterA.Flush()
        outfileMasterA.Close()

        sbMasterVB.Append(strMasterVB + nvrd)
        Dim outfileMasterVB As New System.IO.StreamWriter(masterVB, False, System.Text.Encoding.UTF8)
        outfileMasterVB.Write(sbMasterVB.ToString())
        outfileMasterVB.Flush()
        outfileMasterVB.Close()

    End Sub

    Sub formirajIzvestaje(ByVal folder As String)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'promenaMETA 99konekcija99 u Izvestaji.apx.vb
        Dim izvestaji As String
        izvestaji = folder + "Izvestaji.aspx.vb"
        Dim sbIzvestaji As System.Text.StringBuilder = New System.Text.StringBuilder
        sbIzvestaji.Length = 0
        Dim txtIzvestaji As New System.IO.StreamReader(izvestaji)
        Dim strIzvestaji As String = txtIzvestaji.ReadToEnd
        txtIzvestaji.Close()

        strIzvestaji = strIzvestaji.Replace("99konekcija99", konekcija)
        sbIzvestaji.Append(strIzvestaji + nvrd)
        Dim outfileIzvestaji As New System.IO.StreamWriter(izvestaji, False, System.Text.Encoding.UTF8)
        outfileIzvestaji.Write(sbIzvestaji.ToString())
        outfileIzvestaji.Flush()
        outfileIzvestaji.Close()
    End Sub

    Sub formirajMetodologija(ByVal folder As String)
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'promenaMETA 99konekcija99 u Metodologija.apx.vb
        Dim metodologija As String
        metodologija = folder + "metodologija.aspx.vb"
        Dim sbMetodologija As System.Text.StringBuilder = New System.Text.StringBuilder
        sbMetodologija.Length = 0
        Dim txtMetodologija As New System.IO.StreamReader(metodologija)
        Dim strMetodologija As String = txtMetodologija.ReadToEnd
        txtMetodologija.Close()

        strMetodologija = strMetodologija.Replace("99konekcija99", konekcija)
        sbMetodologija.Append(strMetodologija + nvrd)
        Dim outfileMetodologija As New System.IO.StreamWriter(metodologija, False, System.Text.Encoding.UTF8)
        outfileMetodologija.Write(sbMetodologija.ToString())
        outfileMetodologija.Flush()
        outfileMetodologija.Close()
    End Sub

    Sub formirajPregledUnetihSlogova(ByVal folder As String, ByVal adresar As String,
ByVal spajanjeAdresarTabela As String, ByVal funkcija As String, ByVal orgAdresarTabela As String, ByVal orgAdresarTabelaZ As String)

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        'pregled unetih slogova .aspx
        Dim ASPX As String
        ASPX = folder + "pregledUnetihSlogova.aspx"
        Dim sbASPX As System.Text.StringBuilder = New System.Text.StringBuilder
        sbASPX.Length = 0
        Dim txtASPX As New System.IO.StreamReader(ASPX)
        Dim strASPX As String = txtASPX.ReadToEnd
        txtASPX.Close()

        Dim nadtabASPX As String = ""
        Dim podtabASPX As String = ""

        Dim nadTab As String = ""
        Dim nadTabOpis As String = ""
        Dim podTab As String = ""
        Dim sqlNadTab As String = "select tabela,opis from  dbo.vISTTABELEzaWEB ('" + vt + "','" + IzIst + "') where DG='G'"
        Dim dsNadTab As New System.Data.DataTable

        dsNadTab = izvrsiSQLvratiDT(sqlNadTab, ISTConnectionString, Nothing)

        If dsNadTab.Rows.Count = 0 Then
            strASPX = strASPX.Replace("99GRIDNADTABELE99", "")
        Else
            Dim aspxGD As String = ""
            For j As Integer = 0 To dsNadTab.Rows.Count - 1
                nadTab = dsNadTab.Rows(j).Item("tabela").ToString.Trim.ToUpper
                nadTabOpis = dsNadTab.Rows(j).Item("opis").ToString.Trim
                nadtabASPX = nadtabASPX + nvrd + dajgridNadtabelaASPX(nadTab) + nvrd
                'ako tabela ima mes
                If imaGODMES(nadTab).Trim.ToUpper.IndexOf("MES") >= 0 Then
                    strASPX = strASPX.Replace("99TKMES99", dajTKMES())
                Else
                    strASPX = strASPX.Replace("99TKMES99", "")
                End If
                'ako tabela ima KV
                If imaGODMES(nadTab).Trim.ToUpper.IndexOf("KV") >= 0 Then
                    strASPX = strASPX.Replace("99TKKV99", dajTKKV())
                Else
                    strASPX = strASPX.Replace("99TKKV99", "")
                End If
                nadtabASPX = nadtabASPX.Replace("99OPISTABELE99", nadTabOpis)
                nadtabASPX = nadtabASPX.Replace("99KLJUCNADTABELE99", spremiKljucString(nadTab).Replace("""", ""))
                aspxGD = aspxGD + nadtabASPX + nvrd

                Dim sqlpodTab As String = "select podtabela,rbrUnos,panel from  dbo.vISTPODTABELEzaWEB ('" + vt + "','" + IzIst + "') where tabela='" + nadTab + "' order by rbrUnos"
                Dim dspodTab As New System.Data.DataTable

                dspodTab = izvrsiSQLvratiDT(sqlpodTab, ISTConnectionString, Nothing)

                'podtabele, ako ih ima
                If dspodTab.Rows.Count > 0 Then
                    For kk As Integer = 0 To dspodTab.Rows.Count - 1
                        podTab = dspodTab.Rows(kk).Item("podtabela").ToString.Trim.ToUpper
                        podtabASPX = podtabASPX + nvrd + dajgridPodtabelaASPX(podTab) + nvrd
                    Next
                    aspxGD = aspxGD.Replace("99PODTABELE99", podtabASPX)
                Else
                    'ISTMessageBox.Show("NIJEDNA PODTABELA AKO OSTOJI NIJE OZNAČENA SA WEB!!!!!!!!!!")
                    aspxGD = aspxGD.Replace("99PODTABELE99", "")
                End If
            Next
            strASPX = strASPX.Replace("99GRIDNADTABELE99", aspxGD)
        End If
        sbASPX.Append(strASPX + nvrd)
        Dim outfileASPX As New System.IO.StreamWriter(ASPX, False, System.Text.Encoding.UTF8)
        outfileASPX.Write(sbASPX.ToString())
        outfileASPX.Flush()
        outfileASPX.Close()

        'pregled unetih slogova .vb
        Dim VB As String
        VB = folder + "pregledUnetihSlogova.aspx.vb"
        Dim sbVB As System.Text.StringBuilder = New System.Text.StringBuilder
        sbVB.Length = 0
        Dim txtVB As New System.IO.StreamReader(VB)
        Dim strVB As String = txtVB.ReadToEnd
        txtVB.Close()
        strVB = strVB.Replace("99konekcija99", konekcija)

        Dim nadtabVB As String = ""
        Dim nadtabVBsamoKLJUC As String = ""
        Dim podtabVB As String = ""

        If dsNadTab.Rows.Count = 0 Then
            strVB = strVB.Replace("99BINDGRIDNADTABELE99", "")
            strVB = strVB.Replace("99BINDGRIDNADTABELESAMOKLJUC99", "")
        Else
            Dim vbGD As String = ""
            Dim vbGDsamoKLJUC As String = ""
            Dim vbGDSIC As String = ""
            Dim vbRBKN As String = ""

            For j As Integer = 0 To dsNadTab.Rows.Count - 1
                Dim dv04 As New System.Data.DataView(dISTVEZAzaWEB)
                dv04.RowFilter = "2=2 and adresarTabela='" + adresar.Trim + "'"
                dv04.Sort = "jesteMb DESC, rbr ASC"
                Dim poljaveza As String = ""
                For i As Integer = 0 To dv04.Count - 1
                    poljaveza = poljaveza + dv04(i).Item("veza").ToString.Trim + ","
                Next
                poljaveza = poljaveza + ";"
                poljaveza = poljaveza.Replace(",;", "")

                nadTab = dsNadTab.Rows(j).Item("tabela").ToString.Trim.ToUpper

                If funkcija = "R" AndAlso orgAdresarTabelaZ.Trim.ToUpper.IndexOf(" FROM ") > 0 Then
                    nadtabVB = nadtabVB + nvrd + dajBindGridNadtabelaVB(nadTab, "RelSaSelectom") + nvrd
                    nadtabVBsamoKLJUC = nadtabVBsamoKLJUC + nvrd + dajBindGridNadtabelaVB(nadTab, "RelSaSelectom") + nvrd
                    strVB = strVB.Replace("99RELACIJA99", orgAdresarTabelaZ)
                Else
                    nadtabVB = nadtabVB + nvrd + dajBindGridNadtabelaVB(nadTab) + nvrd
                    nadtabVBsamoKLJUC = nadtabVBsamoKLJUC + nvrd + dajBindGridNadtabelaVB(nadTab) + nvrd
                End If
                nadtabVB = nadtabVB.Replace("99POLJANADTABELA99", spremiPoljaTabeleSaZarezom(nadTab))
                nadtabVB = nadtabVB.Replace("99WHEREVRTACKA99", spremiWhereVRTACKA(nadTab, True))
                vbGD = vbGD + nadtabVB + nvrd

                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99POLJANADTABELA99", spremiKljucTabeleSaZarezom(nadTab))
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99WHEREVRTACKA99", spremiWhereVRTACKA(nadTab, True))
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99NADTABELA99", nadTab)
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99KLJUCADRESAR99", spremiKljucTabeleSaZarezom(adresar))
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99ADRESAR99", adresar)
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99WHEREVRTACKAADRESAR99", spremiWhereVRTACKA(adresar, True))
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99POLJAVEZA99", poljaveza)
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99RELACIJA99", orgAdresarTabelaZ)

                '****za rolu 1
                If funkcija = "A" Then
                    Dim dISTLKAdresar As New System.Data.DataTable
                    Dim sql As String = " select * from dbo.vISTLKAdresar ('" + vt + "','" + IzIst + "') where tabela='" & nadTab & "' and adresarTabela='" & adresar & "'"
                    dISTLKAdresar.Clear()

                    dISTLKAdresar = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

                    Dim spojiPoljaTabela As String = dISTLKAdresar.Rows(0).Item("spojiPoljaTabela")
                    Dim poljaTabela() As String = {}
                    poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela, ",")
                    Dim str As String = ""
                    For i As Integer = 0 To poljaTabela.GetUpperBound(0)
                        str = str + " AND " + poljaTabela(i) + "='" + nvd + " + Session(" + nvd + poljaTabela(i) + nvd + ").ToString.Trim + " + nvd + "'"
                    Next
                    nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99KLJUCTABELE99", str)
                End If
                '****
                If funkcija = "R" Then
                    Dim dISTLKRelacija As New System.Data.DataTable
                    'NAPOMENA: trbalo bi da postoji samo 1 webRelacija
                    Dim sqlR As String = " select * from dbo.vISTLKRelacija ('" + vt + "','" + IzIst + "')" &
            " where tabela='" & nadTab & "' and adresarTabela='" & orgAdresarTabela & "'"
                    dISTLKRelacija.Clear()

                    dISTLKRelacija = izvrsiSQLvratiDT(sqlR, ISTConnectionString, Nothing)

                    Dim spojiPoljaTabelaR As String = dISTLKRelacija.Rows(0).Item("spojiPoljaTabela")
                    Dim poljaTabelaR() As String = {}
                    poljaTabelaR = Microsoft.VisualBasic.Split(spojiPoljaTabelaR, " AND ")
                    Dim strR As String = ""
                    For i As Integer = 0 To poljaTabelaR.GetUpperBound(0)
                        poljaTabelaR(i) = Microsoft.VisualBasic.Split(poljaTabelaR(i), "=")(0)
                        strR = strR + " AND " + poljaTabelaR(i) + "='" + nvd + " + Session(" + nvd + poljaTabelaR(i) + nvd + ").ToString.Trim + " + nvd + "'"
                    Next
                    nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99KLJUCTABELE99", strR)
                End If

                Dim kljA As String = spremiKljucString(adresar).Replace("""", "")

                If kljA = "" Then
                    ''msg 297
                    Dim msgtxt297 As String = getMessageText(dtMessages, "297", Me.jezik) + nvrd
                    ISTMessageBox.Show(msgtxt297, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim kljNizA As String() = Microsoft.VisualBasic.Split(kljA, ",")
                Dim kljNizT As String()
                Dim spajanjeAT As String = ""
                Dim spajanjeAV As String = ""
                If funkcija = "A" Then
                    kljNizT = Microsoft.VisualBasic.Split(spajanjeAdresarTabela, ",")
                    For i As Integer = 0 To kljNizA.GetUpperBound(0)
                        spajanjeAT = spajanjeAT + " " + adresar.Trim + "." + kljNizA(i).Trim + "=" + nadTab.Trim + "." + kljNizT(i).Trim + " AND "
                        If kljNizA(i).Trim.ToUpper <> "GOD" AndAlso kljNizA(i).Trim.ToUpper <> "MES" AndAlso kljNizA(i).Trim.ToUpper <> "ISTYEAR" AndAlso kljNizA(i).Trim.ToUpper <> "ISTMONTH" Then
                            spajanjeAV = spajanjeAV + " " + adresar.Trim + "." + kljNizA(i).Trim + "=VEZA." + kljNizA(i).Trim + " AND "
                        End If
                    Next
                Else
                    kljNizT = Microsoft.VisualBasic.Split(spajanjeAdresarTabela.ToUpper.Trim, " AND ")
                    For i As Integer = 0 To kljNizT.GetUpperBound(0)
                        spajanjeAT = spajanjeAT + " REL." + Microsoft.VisualBasic.Split(kljNizT(i), "=")(1) & "=" + nadTab.Trim + "." + Microsoft.VisualBasic.Split(kljNizT(i), "=")(0).Trim & " AND "
                        If kljNizA(i).Trim.ToUpper <> "GOD" AndAlso kljNizA(i).Trim.ToUpper <> "MES" AndAlso kljNizA(i).Trim.ToUpper <> "ISTYEAR" AndAlso kljNizA(i).Trim.ToUpper <> "ISTMONTH" Then
                            spajanjeAV = spajanjeAV + " REL." + kljNizA(i).Trim + "=VEZA." + kljNizA(i).Trim + " AND "
                        End If
                    Next
                End If

                spajanjeAT = spajanjeAT + ";"
                spajanjeAT = spajanjeAT.Replace(" AND ;", "")
                spajanjeAV = spajanjeAV + ";"
                spajanjeAV = spajanjeAV.Replace(" AND ;", "")

                strVB = strVB.Replace("99SPAJANJEAT99", spajanjeAT)
                strVB = strVB.Replace("99SPAJANJEAVEZA99", spajanjeAV)

                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99SPAJANJEAT99", spajanjeAT)
                nadtabVBsamoKLJUC = nadtabVBsamoKLJUC.Replace("99SPAJANJEAVEZA99", spajanjeAV)

                vbGDsamoKLJUC = vbGDsamoKLJUC + nadtabVBsamoKLJUC + nvrd

                Dim klj As String = spremiKljucString(nadTab).Replace("""", "")
                Dim kljNiz As String() = Microsoft.VisualBasic.Split(klj, ",")
                klj = ""
                Dim kljUrl As String = ""
                Dim kljUrl1 As String = "" + nvd + ""
                Dim kljUrl2 As String = ""
                For i As Integer = 0 To kljNiz.GetUpperBound(0)
                    klj = klj + "Dim " + kljNiz(i) + " As String =gv" + nadTab.Trim + ".DataKeys(e.Row.RowIndex)(" + CStr(i).Trim + ").ToString()" + nvrd
                    kljUrl = kljUrl + "Dim " + kljNiz(i) + " As String =gv" + nadTab.Trim + ".DataKeys(gv" + nadTab.Trim + ".SelectedRow.RowIndex)(" + CStr(i).Trim + ").ToString()" + nvrd
                    kljUrl1 = kljUrl1 + kljNiz(i) + "={" + CStr(i).Trim + "}&"
                    kljUrl2 = kljUrl2 + ", " + kljNiz(i)
                Next
                kljUrl1 = kljUrl1 + ";"
                kljUrl1 = kljUrl1.Replace("&;", "")

                vbGDSIC = vbGDSIC + nvrd + dajgridSIC(nadTab) + nvrd
                vbGDSIC = vbGDSIC.Replace("99URLKLJUCNADTABELE99", kljUrl)
                vbGDSIC = vbGDSIC.Replace("99URL99", kljUrl1 + "" + nvd + "" + kljUrl2)
                vbGDSIC = vbGDSIC + nvrd

                vbRBKN = vbRBKN + klj + nvrd
                Dim sqlpodTab As String = "select podtabela,rbrUnos,panel from dbo.vISTPODTABELEzaWEB ('" + vt + "','" + IzIst + "') where tabela='" + nadTab + "' order by rbrUnos"
                Dim dspodTab As New System.Data.DataTable

                dspodTab = izvrsiSQLvratiDT(sqlpodTab, ISTConnectionString, Nothing)

                If imaGODMES(nadTab).Trim.ToUpper.IndexOf("MES") >= 0 Then
                    strVB = strVB.Replace("99TKMESENABLEDFALSE99", "Me.TK_MES.Enabled = False")
                Else
                    strVB = strVB.Replace("99TKMESENABLEDFALSE99", "")
                End If
                'podtabele, ako ih ima
                If dspodTab.Rows.Count > 0 Then
                    For kk As Integer = 0 To dspodTab.Rows.Count - 1
                        podTab = dspodTab.Rows(kk).Item("podtabela").ToString.Trim.ToUpper
                        podtabVB = podtabVB + nvrd + dajgridPodtabelaVB(podTab, kljNiz) + nvrd
                    Next
                    podtabVB = podtabVB.Replace("99PODTABELE99", podtabVB)
                Else
                    podtabVB = podtabVB.Replace("99PODTABELE99", "")
                End If
            Next
            strVB = strVB.Replace("99BINDGRIDNADTABELESAMOKLJUC99", vbGDsamoKLJUC)
            strVB = strVB.Replace("99BINDGRIDNADTABELE99", vbGD)
            strVB = strVB.Replace("99NADTABELESELECTEDINDEXCHANGE99", vbGDSIC)
            strVB = strVB.Replace("99PODTABELE99", podtabVB)
            strVB = strVB.Replace("99RBKLJUCNADTABELE99", vbRBKN)
            strVB = strVB.Replace("99VRTACKAIZSESIJE99", vrtackaIzSesije(nadTab))
            strVB = strVB.Replace("99TABELA99", nadTab)
        End If

        sbVB.Append(strVB + nvrd)

        Dim outfileVB As New System.IO.StreamWriter(VB, False, System.Text.Encoding.UTF8)
        outfileVB.Write(sbVB.ToString())
        outfileVB.Flush()
        outfileVB.Close()

    End Sub

    Function dajgridPodtabelaVB(ByVal podtabela As String, ByVal kljN As String()) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim kljuc As String = spremiWhereKljuc(podtabela)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\dgPODTABELEvb.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99IMEPOLJA99", spremiPoljaTabeleSaZarezom(podtabela))
        str = str.Replace("99PODTABELA99", podtabela)

        '99KLJUCNADTABELE99
        'god='{0}' and mbr='{1}' and jus='{2}'", god, mbr, jus

        Dim k1 As String = ""
        For i As Integer = 0 To kljN.GetUpperBound(0)
            k1 = k1 + kljN(i) + "='{" + CStr(i).Trim + "}' and "
        Next
        k1 = k1 + ";"
        k1 = k1.Replace(" and ;", "") + nvd + ","

        Dim k2 As String = ""
        For i As Integer = 0 To kljN.GetUpperBound(0)
            k2 = k2 + kljN(i) + ","
        Next
        k2 = k2 + ";"
        k2 = k2.Replace(",;", "")
        str = str.Replace("99KLJUCNADTABELE99", k1 + k2)
        dajgridPodtabelaVB = str

    End Function

    Function dajNadTabeleZaMPISTaspx(ByVal nadtabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\NadTabeleZaMPISTaspx.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99NADTABELA99", nadtabela)
        dajNadTabeleZaMPISTaspx = str

    End Function

    Function dajNadTabeleZaMPISTvb(ByVal nadtabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\NadTabeleZaMPISTvb.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99NADTABELA99", nadtabela)
        dajNadTabeleZaMPISTvb = str

    End Function

    Function dajgridNadtabelaASPX(ByVal nadtabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'Dim kljuc As String = spremiWhereKljuc(nadtabela)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\dgNADTABELEaspx.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99NADTABELA99", nadtabela)
        dajgridNadtabelaASPX = str

    End Function

    Function dajgridSIC(ByVal nadtabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'Dim kljuc As String = spremiWhereKljuc(podtabela)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\nadTabeleSelectedIndexChange.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99NADTABELA99", nadtabela)
        dajgridSIC = str

    End Function

    Function dajgridPodtabelaASPX(ByVal podtabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'Dim kljuc As String = spremiWhereKljuc(podtabela)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\dgPODTABELEaspx.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99PODTABELA99", podtabela)

        dajgridPodtabelaASPX = str

    End Function

    Function dajBindGridNadtabelaVB(ByVal nadtabela As String, Optional ByVal relSaSelectom As String = "") As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'Dim kljuc As String = spremiWhereKljuc(nadtabela)
        Dim kojitxt As String = ""
        If relSaSelectom.Trim.Length > 0 Then
            kojitxt = "bindGridNadtabeleRel.txt"
        Else
            kojitxt = "bindGridNadtabele.txt"
        End If
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB\" + kojitxt)
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99NADTABELA99", nadtabela)
        dajBindGridNadtabelaVB = str

    End Function

    Sub dajRaznoISTZaTabelu(ByVal tabela As String)

        prvoPoljeKljuc = ""
        poslednjePoljeKljuc = ""
        prvoPoljeKojeNijeKljuc = ""
        poslednjePoljeKojeNijeKljuc = ""
        maxVSkljuc = ""

        Dim i As Integer = -1
        ReDim Preserve nizPlus(i)
        ReDim Preserve nizPamti(i)
        'ostalo
        Dim dv As New System.Data.DataView(dISTPoljaKLJUCKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and KLJUC='P' and TIPPOLJA<>'LBL' and POLJE<>'GOD' and POLJE<>'MES' and POLJE<>'ISTYEAR' and POLJE<>'ISTMONTH'"
        dv.Sort = "rbr ASC"
        If dv.Count > 0 Then
            If dv(0).Item("tippolja").ToString.Trim.Substring(0, 1) = "A" Then
                prvoPoljeKljuc = dv(0).Item("imeWeb").ToString.Trim.Replace("_", "_LAZNIDDL")
            Else
                prvoPoljeKljuc = dv(0).Item("imeWeb").ToString.Trim
            End If
            If dv(dv.Count - 1).Item("tippolja").ToString.Trim.Substring(0, 1) = "A" Then
                poslednjePoljeKljuc = dv(dv.Count - 1).Item("imeWeb").ToString.Trim.Replace("_", "_LAZNIDDL")
            Else
                poslednjePoljeKljuc = dv(dv.Count - 1).Item("imeWeb").ToString.Trim
            End If

            dv.Sort = "vs DESC"
            maxVSkljuc = dv(dv.Count - 1).Item("vs").ToString.Trim
            Dim trt As Integer = 0
            'u kljucu treba pustiti da duzina labele bude maksimalna
            If maxVSkljuc = "001" Or maxVSkljuc = "1" Or maxVSkljuc.Trim.Length = 0 Then
                maxVSkljuc = "100"
                trt = 100
            Else
                trt = CInt(dv(dv.Count - 1).Item("vs"))
            End If
            If trt < 200 Then maxVSkljuc = "200"
        End If

        Dim red01 As System.Data.DataRow() = dISTPoljaKLJUCKonsult.Select("2=2 and TABELA='" + tabela.Trim + "' and KLJUC='P' and TIPPOLJA<>'LBL' and POLJE<>'GOD' and POLJE<>'MES' and POLJE<>'ISTYEAR' and POLJE<>'ISTMONTH' and DG='+'")
        For i = 0 To red01.Length - 1
            ReDim Preserve nizPlus(i)
            If red01(i).Item("tipPolja").ToString.Trim.Substring(0, 1) = "A" Then
                nizPlus(i) = red01(i).Item("imeWeb").trim.Replace("_", "_LAZNIDDL") + ";" + red01(0).Item("tip").trim + ";" + red01(0).Item("duzina").trim
            Else
                nizPlus(i) = red01(i).Item("imeWeb").trim + ";" + red01(0).Item("tip").trim + ";" + red01(0).Item("duzina").trim
            End If
        Next
        Dim red02 As System.Data.DataRow() = dISTPoljaKLJUCKonsult.Select("2=2 and KLJUC='P' and TIPPOLJA<>'LBL' and POLJE<>'GOD' and POLJE<>'MES' and POLJE<>'ISTYEAR' and POLJE<>'ISTMONTH' and DG='P'")
        For i = 0 To red02.Length - 1
            ReDim Preserve nizPamti(i)
            If red02(i).Item("tipPolja").ToString.Trim.Substring(0, 1) = "A" Then
                nizPamti(i) = red02(i).Item("imeWeb").trim.Replace("_", "_LAZNIDDL")
            Else
                nizPamti(i) = red02(i).Item("imeWeb").trim
            End If
        Next

        Dim red03 As System.Data.DataRow() = dISTPoljaKonsult.Select("2=2 and TABELA='" + tabela.Trim + "' and KLJUC<>'P' and TIPPOLJA<>'LBL'", "rbr ASC")
        If red03.Length > 0 Then
            If red03(0).Item("tippolja").ToString.Trim.Substring(0, 1) = "A" Then
                prvoPoljeKojeNijeKljuc = red03(0).Item("imeWeb").ToString.Trim.Replace("_", "_LAZNIDDL")
            Else
                prvoPoljeKojeNijeKljuc = red03(0).Item("imeWeb").ToString.Trim
            End If
            If red03(red03.Length - 1).Item("tippolja").ToString.Trim.Substring(0, 1) = "A" Then
                poslednjePoljeKojeNijeKljuc = red03(red03.Length - 1).Item("imeWeb").ToString.Trim.Replace("_", "_LAZNIDDL")
            Else
                poslednjePoljeKojeNijeKljuc = red03(red03.Length - 1).Item("imeWeb").ToString.Trim
            End If
        Else 'TABELA MOZE DA IMA SAMO POLJA KOJA SU KLJUC
        End If

        Dim dv04 As New System.Data.DataView(dISTPoljaKonsult)
        dv04.RowFilter = "2=2 and TABELA='" + tabela.Trim + "'"
        dv04.Sort = "webstr DESC"
        brojwebStrana = 0
        If Not (dv04(0).Item("webstr").ToString.Trim.GetType Is GetType(System.DBNull)) Then
            brojwebStrana = CInt(dv04(0).Item("webstr").ToString.Trim)
        End If

        Dim dv044 As New System.Data.DataView(dISTPoljaKonsult)
        dv044.RowFilter = "2=2 and TABELA='" + tabela.Trim + "'"
        dv044.Sort = "divDisplayNone DESC"
        brojdivDisplayNone = 0
        If Not (dv044(0).Item("divDisplayNone").ToString.Trim.GetType Is GetType(System.DBNull)) Then
            brojdivDisplayNone = CInt(dv044(0).Item("divDisplayNone").ToString.Trim)
        End If


        'NADTABELA (ako postoji)
        nadtabelaOdimetab = ""
        Dim sqlInadpodTab As String = "select distinct nadtabela from  dbo.vISTTABELEzaWEB ('" + vt + "','" + IzIst + "') where tabela='" + tabela + "'"
        Dim dsInadpodTab As New System.Data.DataTable

        dsInadpodTab = izvrsiSQLvratiDT(sqlInadpodTab, ISTConnectionString, Nothing)

        If dsInadpodTab.Rows.Count > 0 Then nadtabelaOdimetab = dsInadpodTab.Rows(0).Item("nadtabela").trim

        'TIP TABELE
        tipTabele = ""
        Dim sqlT As String = "select distinct tabela,DG from  dbo.vISTTABELEzaWEB ('" + vt + "','" + IzIst + "') where tabela='" + tabela + "'"
        Dim dsT As New System.Data.DataTable

        dsT = izvrsiSQLvratiDT(sqlT, ISTConnectionString, Nothing)
        If dsT.Rows.Count > 0 Then tipTabele = dsT.Rows(0).Item("DG").ToString.Trim

        Dim sqlN As String = "select distinct case when T2 like '%panel%' then 'P' else DG end as DG,nadtabela from  dbo.vISTTABELEzaWEB ('" + vt + "','" + IzIst + "') " _
                                + " where nadtabela='" + tabela + "' order by DG"

        Dim dsN As New System.Data.DataSet
        dsN = izvrsiSQLvratiDS(sqlN, ISTConnectionString, Nothing)
        If dsN.Tables(0).Rows.Count > 0 Then
            For ii As Integer = 0 To dsN.Tables(0).Rows.Count - 1
                tipTabele = tipTabele + dsN.Tables(ii).Rows(0).Item("DG").ToString.Trim
            Next
        End If


        'NEMA GRIDOVA U imetab imaGrid=false
        imaGrid = False
        If tipTabele = "G" OrElse tipTabele = "D" OrElse tipTabele = "P" Then
        ElseIf tipTabele.Length > 1 AndAlso (tipTabele.IndexOf("D") >= 1 OrElse tipTabele.IndexOf("P") >= 1) Then
            imaGrid = True
        End If

        Dim f1 As Integer = 0
        Dim f2 As Integer = 0
        Dim f3 As Integer = 0
        Dim prvoUFormi As Integer = 0
        Dim NBL() As String = {}
        Dim daLiJeTabelica As Integer = 0
        Dim dv02 As New System.Data.DataView(dISTPoljaKonsult)
        dv02.RowFilter = "2=2 and TABELA='" + tabela.Trim + "'"
        dv02.Sort = "rbr ASC"

        ReDim Preserve nizTabelice(0)
        ReDim Preserve nizTabelice(0)(0)
        ReDim Preserve nizTabelice(0)(0)(0)

        ReDim Preserve nizLab(0)
        ReDim Preserve nizLab(0)(0)
        ReDim Preserve nizLab(0)(0)(0)

        ReDim Preserve nizPremesti(0)
        ReDim Preserve nizPremesti(0)(0)
        ReDim Preserve nizPremesti(0)(0)(0)

        Dim biof1 As String = ";"
        Dim biof1f2 As String = ";"
        Dim biof1f2f3 As String = ";"

        For i = 0 To dv02.Count - 1
            'SAMO ZA VAŽEĆE, tako da su i rbr i imePolja jedinstveni
            daLiJeTabelica = CInt(dv02(i).Item("daLiJeTabelica").ToString.ToUpper.Trim)
            If daLiJeTabelica = 1 Then
                f1 = CInt(dv02(i).Item("f1").ToString.Trim)
                f2 = CInt(dv02(i).Item("f2").ToString.Trim)
                f3 = CInt(dv02(i).Item("f3").ToString.Trim)
                prvoUFormi = CInt(dv02(i).Item("prvoUFormi").ToString.Trim)

                Dim dvv As New System.Data.DataView(dISTPoljaKonsult)
                dvv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and f1='" + CStr(f1).Trim + "'"
                dvv.Sort = "rbr ASC"
                Dim redGdeJeNadLBL As Integer = 1

                If f1 > nizTabelice.Length - 1 Then
                    If biof1.IndexOf(";" + CStr(f1).Trim + ";") < 0 Then
                        ReDim Preserve nizTabelice(f1)
                        ReDim Preserve nizTabelice(f1)(f2)
                        ReDim Preserve nizTabelice(f1)(f2)(f3)
                        ReDim Preserve nizLab(f1)
                        ReDim Preserve nizLab(f1)(f2)
                        ReDim Preserve nizLab(f1)(f2)(f3)
                        ReDim Preserve nizPremesti(f1)
                        ReDim Preserve nizPremesti(f1)(f2)
                        ReDim Preserve nizPremesti(f1)(f2)(f3)
                        ReDim Preserve NBL(f1)
                        ReDim Preserve nizDodatniRedoviNLB(f1)
                    End If
                End If

                If Not nizTabelice(f1) Is Nothing Then
                    If f2 > nizTabelice(f1).Length - 1 Then
                        If biof1f2.IndexOf(";" + CStr(f1).Trim + "_" + CStr(f2).Trim + ";") < 0 Then
                            ReDim Preserve nizTabelice(f1)(f2)
                            ReDim Preserve nizTabelice(f1)(f2)(f3)
                            ReDim Preserve nizLab(f1)(f2)
                            ReDim Preserve nizLab(f1)(f2)(f3)
                            ReDim Preserve nizPremesti(f1)(f2)
                            ReDim Preserve nizPremesti(f1)(f2)(f3)
                        End If
                    End If
                Else
                    ReDim Preserve nizTabelice(f1)(f2)
                    ReDim Preserve nizTabelice(f1)(f2)(f3)
                    ReDim Preserve nizLab(f1)(f2)
                    ReDim Preserve nizLab(f1)(f2)(f3)
                    ReDim Preserve nizPremesti(f1)(f2)
                    ReDim Preserve nizPremesti(f1)(f2)(f3)
                End If

                If Not nizTabelice(f1)(f2) Is Nothing Then
                    If f3 > nizTabelice(f1)(f2).Length - 1 Then
                        If biof1f2f3.IndexOf(";" + CStr(f1).Trim + "_" + CStr(f2).Trim + "_" + CStr(f3).Trim + ";") < 0 Then
                            ReDim Preserve nizTabelice(f1)(f2)(f3)
                            ReDim Preserve nizLab(f1)(f2)(f3)
                            ReDim Preserve nizPremesti(f1)(f2)(f3)
                        End If
                    End If
                Else
                    ReDim Preserve nizTabelice(f1)(f2)(f3)
                    ReDim Preserve nizLab(f1)(f2)(f3)
                    ReDim Preserve nizPremesti(f1)(f2)(f3)
                End If
                Dim vs As String = dv02(i).Item("vs").ToString.ToUpper.Trim
                Dim tipPolja As String = dv02(i).Item("tipPolja").ToString.ToUpper.Trim
                nizTabelice(f1)(f2)(f3) = "PPˇˇ" + vs + "ˇ" 'pravoPolje
                If tipPolja = "LBL" Then
                    'ako je fiktivno polje, onda je njegova labela uvek prazna!!!!!
                    nizLab(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                Else
                    If dv02(i).Item("opisLAB").ToString.ToUpper.Trim <> "" Then
                        nizLab(f1)(f2)(f3) = "LBLˇ" + dv02(i).Item("izrazFP").ToString.ToUpper.Trim + "ˇ" + vs + "ˇ"
                        'nizLab(f1)(f2)(f3) = "LBLˇ" + dv02(i).Item("opisLAB").ToString.ToUpper.Trim + "ˇ" + vs + "ˇ"
                    Else
                        nizLab(f1)(f2)(f3) = "UBACENOˇˇ0ˇ"
                    End If
                End If
                nizPremesti(f1)(f2)(f3) = 0

                'uzimamo da je NADLABELA prvi opis u tabeli koji ima #.....
                If prvoUFormi = 1 Then
                    For ii As Integer = 0 To dvv.Count - 1
                        If dvv(ii).Item("opisNadLBL").ToString.Trim.Trim.Length > 0 Then
                            NBL(f1) = dvv(ii).Item("opisNadLBL").ToString.Trim.Trim + "REDNBL" + CStr(f2).Trim
                            ' "REDNBL" + CStr(f2).Trim - broj redova u tabeli
                            dvv.Dispose()
                            Exit For
                        End If
                    Next
                End If

                'If f2 = 1 AndAlso f3 = 1 Then
                '    NBL(f1) = dv02(i).Item("opisNadLBL").ToString.Trim.Trim
                'End If

                If biof1.IndexOf(";" + CStr(f1).Trim + ";") < 0 Then biof1 = biof1 + CStr(f1).Trim + ";"
                If biof1f2.IndexOf(";" + CStr(f1).Trim + "_" + CStr(f2).Trim + ";") < 0 Then biof1f2 = biof1f2 + CStr(f1).Trim + "_" + CStr(f2).Trim + ";"
                If biof1f2f3.IndexOf(";" + CStr(f1).Trim + "_" + CStr(f2).Trim + "_" + CStr(f3).Trim + ";") < 0 Then biof1f2f3 = biof1f2f3 + CStr(f1).Trim + "_" + CStr(f2).Trim + "_" + CStr(f3).Trim + ";"
            End If
        Next 'OD POLJA
        ''VAZNO!!!!!!!!
        'Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), ";")(0) tip
        'Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), ";")(1) vrednost
        'Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), ";")(2) vs
        Dim brojTabelica As Integer = nizTabelice.Length - 1

        For tTab As Integer = 1 To brojTabelica
            Dim p As Integer = 0
            Dim tr As Integer = 0
            If Not nizTabelice(tTab) Is Nothing Then
                For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        tr = nizTabelice(tTab)(tRed).Length - 1
                        If p <= tr Then
                            p = tr
                        Else
                            ReDim Preserve nizTabelice(tTab)(tRed)(p)
                            ReDim Preserve nizLab(tTab)(tRed)(p)
                            ReDim Preserve nizPremesti(tTab)(tRed)(p)
                        End If
                    End If
                Next
            End If
        Next
        For tTab As Integer = 1 To brojTabelica
            If Not nizTabelice(tTab) Is Nothing Then
                Dim brojKol As Integer = 0
                Dim vsRed As Integer = 0
                Dim brojDodKol() As Integer = {}
                Dim maxBrK As Integer = 0
                For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        If nizTabelice(tTab)(tRed).Length - 1 > maxBrK Then
                            maxBrK = nizTabelice(tTab)(tRed).Length - 1
                        End If
                    End If
                Next
                For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                    'NAJVECI BROJ KOLONA U REDU
                    Dim brojCntl As Integer = 0
                    Dim vs As Integer = 0
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        Dim m As Integer = 0
                        For tKol As Integer = 1 To maxBrK 'nizTabelice(tTab)(tRed).Length - 1
                            brojCntl = brojCntl + 1
                            If tKol > nizTabelice(tTab)(tRed).Length - 1 Then
                                ReDim Preserve nizTabelice(tTab)(tRed)(tKol)
                                ReDim Preserve nizLab(tTab)(tRed)(tKol)
                                ReDim Preserve nizPremesti(tTab)(tRed)(tKol)
                            End If
                            If Not nizTabelice(tTab)(tRed)(tKol) Is Nothing Then
                                vs = vs + Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2)
                            Else
                                nizTabelice(tTab)(tRed)(tKol) = "UBACENOˇˇ0ˇ"
                                nizLab(tTab)(tRed)(tKol) = "UBACENOˇˇ0ˇ"
                                nizPremesti(tTab)(tRed)(tKol) = 0
                                m = m + 1
                            End If
                        Next 'od tKOL
                        ReDim Preserve brojDodKol(tRed)
                        brojDodKol(tRed) = m
                        If brojCntl > brojKol Then brojKol = brojCntl
                        If vs > vsRed Then vsRed = vs
                    End If
                Next 'od tRED

                For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        Dim ukVS As Integer = 0
                        For tKol As Integer = 1 To brojKol
                            ukVS = ukVS + Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2)
                        Next 'od tKOL
                        If vsRed > ukVS Then
                            Dim razl As Integer = vsRed - ukVS
                            Dim trt As Integer = 0
                            If brojDodKol(tRed) > 0 Then trt = CInt((vsRed - ukVS) / brojDodKol(tRed))
                            If trt > 0 Then
                                For tKol As Integer = 1 To brojKol
                                    Dim sta As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(0)
                                    Dim vrednost As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(1)
                                    Dim vs As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2)
                                    If vs = "0" Then vs = CStr(trt).Trim
                                    nizTabelice(tTab)(tRed)(tKol) = sta + "ˇ" + vrednost + "ˇ" + vs
                                    Dim staLab As String = Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(0)
                                    Dim vrednostLab As String = Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(1)
                                    If vrednostLab.Trim = "" Then
                                        nizLab(tTab)(tRed)(tKol) = "UBACENOˇˇ0ˇ"
                                    Else
                                        nizLab(tTab)(tRed)(tKol) = staLab + "ˇ" + vrednostLab + "ˇ" + vs + "ˇ"
                                    End If
                                    nizPremesti(tTab)(tRed)(tKol) = 0
                                Next 'od tKOL
                            End If
                        End If
                    End If
                Next 'od tRED

                Dim minpom As Integer = 999
                Dim maxpom As Integer = 0
                For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        Dim ukVS As Integer = 0
                        For tKol As Integer = 1 To brojKol
                            ukVS = ukVS + Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2)
                            'ukVS = ukVS + Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(2)
                        Next 'od tKOL
                        If ukVS > 999 Then    '999
                        Else
                            If minpom > 999 - ukVS Then minpom = 999 - ukVS
                            If maxpom < 999 - ukVS Then maxpom = 999 - ukVS
                        End If
                    End If
                Next 'od tRED
                If minpom = 999 Then minpom = 0
                Dim svePraznoUprvojLAB As Boolean = True

                'ako je u prvoj labeli sve prazno, nema potrebe da ista stavljamo u nizLab(tTab)(0)(1)
                For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        If nizLab(tTab)(tRed)(1) = "UBACENOˇˇ0ˇ" Then
                        Else
                            svePraznoUprvojLAB = False
                            Exit For
                        End If
                    End If
                Next
                If svePraznoUprvojLAB = True Then minpom = 0
                'PA NADLABELA ZA RED

                Dim nad() As String = {}
                Dim nadRed As Integer = 0
                Dim nadKol As Integer = 0

                If NBL.Length > 0 AndAlso Not NBL(tTab) Is Nothing Then
                    nad = Microsoft.VisualBasic.Split(Microsoft.VisualBasic.Split(NBL(tTab), "REDNBL")(0), ";")
                    nadRed = Microsoft.VisualBasic.Split(NBL(tTab), "REDNBL")(1)
                    nadKol = nad.Length
                Else
                    nadKol = 0
                End If

                Dim k As Integer = 0
                For tKol As Integer = 1 To brojKol     'nad.GetUpperBound(0)
                    ReDim Preserve nizTabelice(tTab)(0)(tKol)
                    ReDim Preserve nizLab(tTab)(0)(tKol)
                    ReDim Preserve nizPremesti(tTab)(0)(tKol)
                    nizTabelice(tTab)(0)(tKol) = "UBACENOˇˇ0ˇ"                      'NADLABELA
                    nizLab(tTab)(0)(tKol) = "UBACENOˇˇ0ˇ"
                    nizPremesti(tTab)(0)(tKol) = 0
                    If nadKol > 0 AndAlso tKol >= brojKol - nadKol + 1 AndAlso nad(k).Trim <> "" Then
                        Dim duz As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(nadRed)(tKol), "ˇ")(2).Trim 'NADLABELA
                        nizTabelice(tTab)(0)(tKol) = "LBLˇ" + nad(k).Trim + "ˇ" + duz + "ˇ"
                        k = k + 1
                    End If
                Next

                If minpom > 0 Then
                    nizLab(tTab)(0)(1) = "LITERALˇˇ" + CStr(minpom) + "ˇ" + dajFP(False, "", "nadP_" + CStr(tTab).Trim + "_" + CStr(0).Trim + "_" + CStr(0).Trim, "-1", CStr(minpom))
                Else
                    nizLab(tTab)(0)(1) = "UBACENOˇˇ" + Microsoft.VisualBasic.Split(nizLab(tTab)(nadRed)(1), "ˇ")(2).Trim + "ˇ"
                End If

                ''''PREMESTANJE
                'prvo nadji red sa najvecim brojem elemenata (tj sa minimalnim brojem dodatih kolona) - redminBDK
                Dim minBDK As Integer = 1   'minimalan broj dodatih kolona u redu
                Dim redminBDK As Integer = 1  'prvi red sa tim brojem
                Dim imaDodatihKolona As Boolean = False  'generalno za celu tabelicu
                For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        If brojDodKol(tRed) > 0 Then imaDodatihKolona = True
                        If brojDodKol(tRed) < minBDK Then
                            minBDK = brojDodKol(tRed)
                            redminBDK = tRed
                        End If
                    End If
                Next
                If imaDodatihKolona = True Then  'IMA DODATIH KOLONA  (minBDK>0)
                    'nadji duzine kolona od redminBDK  - duzPoredjenje
                    Dim duzPoredjenje() As Integer = {}
                    ReDim Preserve duzPoredjenje(brojKol)
                    duzPoredjenje(0) = 0
                    For tKol As Integer = 1 To brojKol
                        If Not nizTabelice(tTab)(redminBDK) Is Nothing Then
                            Dim duz As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(redminBDK)(tKol), "ˇ")(2).Trim
                            duzPoredjenje(tKol) = duz
                        End If
                    Next

                    'nadji koji su redovi kandidati za premestanje (moraju na od pocetka da imaju ubacen) -redZaPremestanje=1
                    Dim SviUbaceni As Boolean = False
                    Dim doKol As Integer = 0
                    Dim redZaPremestanje() As Integer = {}
                    ReDim Preserve redZaPremestanje(nizTabelice(tTab).Length - 1)
                    For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                        redZaPremestanje(tRed) = 0
                    Next
                    For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                        If Not nizLab(tTab)(tRed) Is Nothing Then
                            SviUbaceni = True
                            doKol = 0
                            For tKol As Integer = 1 To brojKol
                                Dim ss As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(0).Trim
                                If ss.Trim = "UBACENO" Then
                                    SviUbaceni = SviUbaceni And True
                                    doKol = tKol
                                Else
                                    SviUbaceni = SviUbaceni And False
                                    Exit For
                                End If
                            Next
                            If doKol > 0 Then
                                redZaPremestanje(tRed) = 1
                            End If
                        End If
                    Next 'od tRED
                    'popuni  nizPremesti
                    For tRed As Integer = 1 To nizTabelice(tTab).Length - 1
                        If Not nizTabelice(tTab)(tRed) Is Nothing Then
                            If tRed <> redminBDK AndAlso redZaPremestanje(tRed) = 1 AndAlso brojDodKol(tRed) > brojDodKol(redminBDK) Then
                                Dim premestanje As Boolean = False
                                Dim slobodna As Integer = 1
                                For tKol As Integer = brojDodKol(tRed) + 1 To brojKol
                                    If slobodna = tKol Then Exit For
                                    Dim duz As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2).Trim
                                    Dim mm As Integer = duzPoredjenje(tKol)
                                    If premestanje = False AndAlso duz <= mm Then
                                        'nema premestanja ako su svi ispred prazni i taj je =onom iznad
                                    Else
                                        For kolona As Integer = slobodna To tKol - 1
                                            nizPremesti(tTab)(tRed)(tKol) = kolona
                                            premestanje = True
                                            Dim suma As Integer = 0
                                            For kolPom As Integer = kolona To tKol  'brojDodKol(tRed)
                                                suma = suma + duzPoredjenje(kolPom)
                                                If duz >= suma Then
                                                    slobodna = kolPom + 1
                                                Else
                                                    Exit For
                                                End If
                                            Next
                                            If slobodna > 1 Then Exit For
                                        Next
                                    End If
                                Next
                            End If
                        End If
                    Next
                End If

                ''
                ''
                ''KONACNO
                Dim maxTKol() As Integer = {}
                ReDim Preserve maxTKol(brojKol)
                Dim redKol() As Integer = {}
                ReDim Preserve redKol(brojKol)
                For tKol As Integer = 1 To brojKol
                    maxTKol(tKol) = 0
                    redKol(tKol) = 0
                Next
                Dim ubaceno As Boolean = False
                For tRed As Integer = 1 To nizLab(tTab).Length - 1
                    If Not nizLab(tTab)(tRed) Is Nothing Then
                        ubaceno = True
                        For tKol As Integer = 1 To brojKol
                            redKol(tKol) = 0
                            Dim duz As Integer = 0
                            If Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(0) <> "UBACENO" Then
                                duz = CInt(Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2).Trim())
                            End If
                            Dim duzLab As Integer = 0
                            If Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(0) <> "UBACENO" Then
                                ubaceno = False   'znaci nesto ima u labeli izmedju
                                If tKol = 1 Then duzLab = maxpom Else duzLab = 150
                            End If
                            If ubaceno = False Then   'ako postoji LBL izmedju onda dodajemo 150
                                redKol(tKol) = redKol(tKol) + duzLab
                            End If
                            redKol(tKol) = redKol(tKol) + duz
                        Next
                        For tKol As Integer = 1 To brojKol
                            If maxTKol(tKol) < redKol(tKol) Then maxTKol(tKol) = redKol(tKol)
                        Next
                    End If
                Next 'od tRED

                Dim maxRedKon As Integer = 0
                For tKol As Integer = 1 To brojKol
                    maxRedKon = maxRedKon + maxTKol(tKol)
                Next
                'imam maxRedKon za TABELU
                'RASPODELA VS
                For tRed As Integer = 0 To nizTabelice(tTab).Length - 1
                    If Not nizTabelice(tTab)(tRed) Is Nothing Then
                        If maxRedKon > 999 Then    '999
                            Dim trt As Decimal = CDec(999 / maxRedKon)
                            For tKol As Integer = 1 To brojKol
                                Dim vs As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2)
                                Dim vsL As String = Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(2)

                                vs = CStr(CInt(CInt(vs) * trt)).ToString.Trim
                                vsL = CStr(CInt(CInt(vsL) * trt)).ToString.Trim

                                Dim sta As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(0)
                                Dim vrednost As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(1)
                                Dim ss As String = "ˇ"
                                If tRed = 0 Then  'NADLABELA
                                    ss = ss + dajFP(False, vrednost, "nad_" + CStr(tTab).Trim + "_" + CStr(0).Trim + "_" + CStr(tKol).Trim, "-1", vs)
                                End If
                                nizTabelice(tTab)(tRed)(tKol) = sta + "ˇ" + vrednost + "ˇ" + vs + ss

                                Dim staLab As String = Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(0)
                                Dim vrednostLab As String = Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(1)
                                Dim ssL As String = "ˇ"
                                If tRed = 0 And tKol = 1 Then
                                    ssL = ssL + Microsoft.VisualBasic.Split(nizLab(tTab)(tRed)(tKol), "ˇ")(3)
                                End If
                                nizLab(tTab)(tRed)(tKol) = staLab + "ˇ" + vrednostLab + "ˇ" + vsL + ssL
                            Next
                        Else
                            If tRed = 0 Then
                                Dim im As Integer = 0
                                For tKol As Integer = 1 To brojKol
                                    Dim vs As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(2)
                                    Dim sta As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(0)
                                    Dim vrednost As String = Microsoft.VisualBasic.Split(nizTabelice(tTab)(tRed)(tKol), "ˇ")(1)
                                    If vrednost.Trim.ToUpper = "MERGE" Then
                                        im = im + 1
                                        nizTabelice(tTab)(0)(tKol) = sta + "ˇ" + "IZBACIZBOGMRG" + "ˇ" + vs + "ˇ" + dajFP(False, vrednost, "nadP_" + CStr(tTab).Trim + "_" + CStr(0).Trim + "_" + CStr(tKol).Trim, "-1", CStr(vs).Trim)
                                    Else
                                        Dim merge As String = CStr(im * 2 + 2).Trim + "MERGE"
                                        If im = 0 Then merge = ""
                                        nizTabelice(tTab)(0)(tKol) = sta + "ˇ" + merge + vrednost + "ˇ" + vs + "ˇ" + dajFP(False, vrednost, "nadP_" + CStr(tTab).Trim + "_" + CStr(0).Trim + "_" + CStr(tKol).Trim, "-1", CStr(vs).Trim)
                                        im = 0
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next 'od tRED
            End If ' ako tabelica nije nothing
        Next 'od tTAB

        'dodatni redovi u tabelama za nadredove
        For tab As Integer = 1 To NBL.Length - 1
            If Not NBL(tab) Is Nothing AndAlso NBL(tab).IndexOf("#") >= 0 Then
                'ima vise redova u nadlabeli tabelice
                Dim redovi() As String = Microsoft.VisualBasic.Split(NBL(tab), "#")
                For ll As Integer = 1 To redovi.Length - 1
                    ReDim Preserve nizDodatniRedoviNLB(tab)(ll)
                    nizDodatniRedoviNLB(tab)(ll) = redovi(ll).Trim
                Next
            End If
        Next

        'DODAJEMO ZA PODTABELE (AKO IH IMA)
        'LINK BUTTON I GRIDVIEW
        'ili samo LABEL I GRIDVIEW ako je panel
        ReDim Preserve nizPodtabele(-1)
        Dim sqlpodTab As String = "select podtabela,rbrUnos,panel from  dbo.vISTPODTABELEzaWEB ('" + vt + "','" + IzIst + "') where tabela='" + tabela + "' order by tabela"
        Dim dspodTab As New System.Data.DataTable

        dspodTab = izvrsiSQLvratiDT(sqlpodTab, ISTConnectionString, Nothing)

        If dspodTab.Rows.Count > 0 Then
            ReDim Preserve nizPodtabele(dspodTab.Rows.Count - 1)
            For pp As Integer = 0 To dspodTab.Rows.Count - 1
                Dim podtabela As String = dspodTab.Rows(pp).Item("podtabela").ToString.Trim
                Dim rbrUnos As String = dspodTab.Rows(pp).Item("rbrUnos").ToString.Trim
                Dim panel As String = dspodTab.Rows(pp).Item("panel").ToString.Trim
                nizPodtabele(pp) = podtabela + "ˇ" + rbrUnos + "ˇ" + panel
            Next
        End If
    End Sub

    Function dajnizTabIndex(ByVal tabela As String) As String()

        Dim rbr As Long
        Dim MaxRbr As Long
        Dim nizTI() As String = {}
        Dim TI As Integer = 0
        Dim i As Integer = -1

        Dim red11 As System.Data.DataRow() = dISTPoljaKonsult.Select("2=2 and TABELA='" + tabela.Trim + "' and TIPPOLJA<>'LBL' and TIPPOLJA<>'HT'")
        MaxRbr = CLng(red11.Length)
        ReDim Preserve nizTI(MaxRbr + 1)

        'kljuc
        Dim dv12 As New System.Data.DataView(dISTPoljaKLJUCKonsult)
        dv12.Sort = "rbr ASC"
        dv12.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and KLJUC='P' and TIPPOLJA<>'LBL' and TIPPOLJA<>'HT'"
        For i = 0 To dv12.Count - 1
            rbr = CLng(dv12(i).Item("rbr"))
            TI = TI + 1
            nizTI(TI) = CStr(dv12(i).Item("polje")).Trim.ToUpper
        Next
        TI = TI + 1 'da ostavimo index za dugme TRAZI
        nizTI(TI) = "ImageButtonView"

        'ostalo
        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.Sort = "rbr ASC"
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and kljuc<>'P' and TipPolja<>'LBL' and TipPolja<>'HT'"
        For i = 0 To dv.Count - 1
            rbr = CLng(dv(i).Item("rbr"))
            TI = TI + 1
            nizTI(TI) = CStr(dv(i).Item("polje")).Trim.ToUpper
        Next
        dajnizTabIndex = nizTI
    End Function

    Function ZaUpdatePanel(ByVal tabela As String, ByVal polje As String) As String
        'npr da li za polje TP_jus treba update panel (tj, da li je ono u nekoj dodeli)

        ZaUpdatePanel = ""
        'KANDIDATI ZA UPDATE PANEL
        'su oni kojima je filtriranoPolje=1
        'i oni koji postoje u DodeliKome

        Dim sta As String = "tabela='" & tabela & "' and dodelaKome='" & polje & "'"
        If dISTDodela.Select(sta).Length > 0 Then
            If dISTDodela.Select(sta)(0).Item("imeWeb").ToString.Trim.Substring(0, 3) <> "HT_" Then ZaUpdatePanel = dISTDodela.Select(sta)(0).Item("imeWeb").ToString.Trim
        End If

    End Function

    Function dajSkakanjeSaCBO(ByVal tabela As String, ByVal imeWebSaKoga As String, ByVal skociNA() As String, ByVal skociAKO() As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim str As String = "" + nvrd
        For i As Integer = 0 To skociNA.GetUpperBound(0)
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim = tabela Then
                    If CDate(t.Item("Vod")) <= vt AndAlso vt <= CDate(t.Item("Vdo")) Then
                        If t.Item("polje").trim.toupper = skociNA(i).Trim.ToUpper Then
                            If skociAKO.Length > 0 Then
                                skociAKO(i) = skociAKO(i).Replace("d.", "")
                                Dim bbb() As String = razkvantaj(skociAKO(i))
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    Dim sta As String = "tabela='" & tabela & "' and polje='" & bbb(ll).ToUpper.Trim & "'"
                                    If dISTPoljaKonsult.Select(sta).Length > 0 Then
                                        bbb(ll) = dISTPoljaKonsult.Select(sta)(0).Item("imeWeb").ToString.Trim + ".Text"
                                    End If
                                Next
                                skociAKO(i) = ustringaj(bbb).ToUpper
                                skociAKO(i) = skociAKO(i).Replace("'", nvd)
                                skociAKO(i) = skociAKO(i).Trim.ToUpper.Replace("IS NULL", "=" + nvd + nvd)
                                str = str + "        if (" + skociAKO(i) + ") =True then  Me." + t.Item("imeWeb").trim + ".Focus()" + nvrd
                                'str = str + "        if ispitajUslov(" + nvd + skociAKO(i) + nvd + ") = True then  Me." + t.Item("imeWeb").trim + ".Focus()" + nvrd
                            Else
                                str = str + "        Me." + t.Item("imeWeb").trim + ".Focus()" + nvrd
                            End If
                        End If
                    End If
                End If
            Next
        Next
        dajSkakanjeSaCBO = str
    End Function

    Function dajDodelaCBO(ByVal tabela As String, ByVal dsIme As String, ByVal imeWebODKoga As String, ByVal imeWebUBazu As String, ByVal imeSta() As String, ByVal imeKome() As String, ByVal imeAko() As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim str As String = "" + nvrd
        str = str + "   Dim ds As DataSet" + nvrd
        str = str + "   Dim dt As DataTable" + nvrd
        str = str + "   Dim ppp As String = " + nvd + nvd + "" + nvrd
        str = str + "   ds = Session(" + nvd + dsIme + nvd + ") " + nvrd
        str = str + "   dt = ds.Tables(0)" + nvrd

        str = str + "   If Not " + imeWebODKoga + ".SelectedValue Is Nothing Then ppp = " + imeWebODKoga + ".SelectedValue.Trim" + nvrd
        str = str + "   Dim sta As String= " + nvd + imeWebUBazu + "='" + nvd + " & ppp & " + nvd + "'" + nvd + nvrd

        str = str + "   Dim indeks As Integer" + nvrd
        str = str + "   indeks = " + imeWebODKoga + ".SelectedIndex - 1" + nvrd

        str = str + "   If dt.Select(sta).Length > 0 Then" + nvrd

        For i As Integer = 0 To imeSta.GetUpperBound(0)
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim = tabela Then
                    If CDate(t.Item("Vod")) <= vt AndAlso vt <= CDate(t.Item("Vdo")) Then
                        If t.Item("polje").trim.toupper = imeKome(i).Trim.ToUpper AndAlso imeSta(i).Substring(0, 1) <> "#" Then
                            'ako je filter CBO mora ponovo popuni tajCBO kroz filter
                            If t.Item("filtriranoPolje") = 1 Then
                                str = str + "       XXX" + t.Item("imeWeb").trim + "XXX" + nvrd
                            End If
                            If imeSta(i).Trim.Length = 0 OrElse imeSta(i).Trim = "''" Then
                                str = str + "       Me." + t.Item("imeWeb").trim + ".Text = " + nvd + nvd + "" + nvrd
                            Else
                                str = str + "       Me." + t.Item("imeWeb").trim + ".Text = dt.Select(sta)(0).Item(" + nvd + imeSta(i) + nvd + ").ToString.Trim" + nvrd
                            End If
                        End If
                    End If
                End If
            Next
        Next

        str = str + "   End If" + nvrd
        dajDodelaCBO = str
    End Function

    Function dajpSaveSlogPanel(ByVal brojACE As Integer, ByVal strACE As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pSaveSlogPanel.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        Dim strDPK As String = "" + nvrd
        Dim strDP As String = "" + nvrd
        Dim strLK As String = "" + nvrd
        'za svaku tabelu koja je panel formiraj dodelu default polja
        'i poziv za LK
        For Each tab As System.Data.DataRow In dISTTABELEzaWeb.Rows
            If Not (tab.Item("T2").GetType Is GetType(System.DBNull)) Then
                If tab.Item("T2").ToString.Trim.ToUpper.IndexOf("PANEL") >= 0 Then
                    Try
                        Dim tabelap As String = tab.Item("tabela").ToString.Trim.ToUpper()
                        ' kljuc
                        strDPK = strDPK + "if tabelap=" + nvd + tabelap + nvd + " Then" + nvrd
                        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
                        dvK.RowFilter = "2=2 and tabela='" + tabelap + "' and isnull(KLJUC,'')='P' and ISNULL(DG,'')<>'' and POLJE <>'GOD' and POLJE<>'MES' and POLJE<>'ISTYEAR' and POLJE<>'ISTMONTH'"
                        dvK.Sort = "rbr ASC"

                        For i As Integer = 0 To dvK.Count - 1
                            Dim poljeUBazi As String = dvK(i).Item("polje").ToString.Trim
                            Dim poljeWeb As String = dvK(i).Item("imeWeb").ToString.Trim
                            Dim DG As String = dvK(i).Item("DG").ToString.Trim
                            If DG <> "{+}" AndAlso DG.ToUpper <> "{P}" Then
                                If poljeWeb.Substring(0, 1) = "T" OrElse poljeWeb.Substring(0, 1) = "H" Then
                                    strDPK = strDPK + "    Me.PNL" + tabelap + poljeWeb + ".Text =" + nvd + DG + nvd + nvrd
                                End If
                            End If
                        Next
                        strDPK = strDPK + "End if" + nvrd

                        'nijekljuc
                        strDP = strDP + "if tabelap=" + nvd + tabelap + nvd + " Then" + nvrd
                        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
                        dv.RowFilter = "2=2 and tabela='" + tabelap + "' and isnull(KLJUC,'')<>'P' and ISNULL(DG,'')<>''"
                        dv.Sort = "rbr ASC"
                        For i As Integer = 0 To dv.Count - 1
                            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
                            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim
                            Dim DG As String = dv(i).Item("DG").ToString.Trim
                            If DG <> "{+}" AndAlso DG.ToUpper <> "{P}" Then
                                If poljeWeb.Substring(0, 1) = "T" OrElse poljeWeb.Substring(0, 1) = "H" Then
                                    strDP = strDP + "    Me.PNL" + tabelap + poljeWeb + ".Text =" + nvd + DG + nvd + nvrd
                                End If
                            End If
                        Next
                        strDP = strDP + "End if" + nvrd

                        strLK = strLK + "if tabelapanel=" + nvd + tabelap + nvd + " Then" + nvrd
                        strLK = strLK + "   call LK" + tabelap + "()" + nvrd
                        strLK = strLK + "End if" + nvrd
                    Catch ex As System.Exception

                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Finally
                    End Try

                End If
            End If
        Next

        str = str.Replace("99TABELAPKLJUCDEFAULTPOLJA99", strDPK)
        str = str.Replace("99TABELAPDEFAULTPOLJA99", strDP)
        str = str.Replace("99LKPANEL99", strLK)

        str = str.Replace("99ACEPANEL99", dajACEPanel(brojACE, strACE))

        'NEURAĐENO!!!!!!!!
        str = str.Replace("'99DodajZaDiltriraneCPanel99", "")
        'str = str.Replace("'99DodajZaDiltriraneCPanel99", dajdodajZaFiltriraneCPanel(tabelap))

        dajpSaveSlogPanel = str

    End Function

    Function dajPopuniSlog(ByVal tabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim kljuc As String = spremiWhereKljuc(tabela)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\popuniSlog.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99TABELA99", tabela)
        str = str.Replace("99KLJUC99", kljuc)
        If prvoPoljeKojeNijeKljuc <> "" Then
            str = str.Replace("99PRVOPOLJE99", prvoPoljeKojeNijeKljuc)
        Else
            str = str.Replace("99PRVOPOLJE99.focus()", prvoPoljeKojeNijeKljuc)
        End If
        dajPopuniSlog = str
    End Function

    Private DGTabela As System.Data.DataTable

    Private Sub NapraviDGTabelu(ByVal tabela As String)

        Dim sqlP As String = "select * FROM " + tabela + " where 2=3"
        DGTabela = New System.Data.DataTable

        DGTabela = izvrsiSQLvratiDT(sqlP, connPravaBaza, Nothing)

        For Each c As System.Data.DataColumn In DGTabela.Columns
            If c.DataType.Name.ToUpper = "BOOLEAN" Then
                c.DataType = GetType(System.Int16)
            End If
        Next

    End Sub

    Private Function DGi(ByVal imetabele As String, Optional ByVal DTNiz() As System.Data.DataTable = Nothing) As Integer
        If DTNiz Is Nothing Then
            If DGTabela.TableName.Trim.ToUpper = imetabele.Trim.ToUpper Then Return 0
            Return -1
        Else
            For i As Integer = 0 To DTNiz.GetUpperBound(0)
                If DTNiz(i).TableName.Trim.ToUpper = imetabele.Trim.ToUpper Then Return i
            Next
            Return -1
        End If
    End Function

    Function dajLK(ByVal tabela As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim sql As String = ""
        Dim dt As New System.Data.DataTable
        Dim dtT As New System.Data.DataTable

        Dim poljeGreska As String
        Dim poljeRbrGreske As String
        Dim poljeNazivGreske As String
        Dim poljeTezina As String

        'pravila koja nemaju select...
        sql = " select greska,RbrGreske,NazivGreske,tezina from dbo.vISTLK ('" + vt + "','" + IzIst + "') where tabela='" + tabela + "'"
        dt.Clear()

        dt = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        Dim str As String = ""
        Call NapraviDGTabelu(tabela)

        Dim strGENGr As String = "" + nvrd
        Dim pomBoja As String = "Red"
        For i As Integer = 0 To dt.Rows.Count - 1
            poljeGreska = dt.Rows(i).Item("greska").ToString.Trim.ToUpper
            poljeRbrGreske = dt.Rows(i).Item("RbrGreske").ToString.Trim
            poljeNazivGreske = dt.Rows(i).Item("NazivGreske").ToString.Trim
            poljeNazivGreske = poljeNazivGreske.Replace(nvd, "''")
            poljeTezina = dt.Rows(i).Item("tezina").ToString.Trim
            'L - поље које је део грешке је жуте боје у уносу
            'Тешке:
            'Празно - поље које је део грешке је црвене боје у уносу
            'Т - поље које је део грешке је црвене боје у уносу
            'G - поље које је део грешке је зелене боје у уносу
            'P - поље које је део грешке је љубичасте боје у уносу
            'N - поље које је део грешке се не боји
            Select Case poljeTezina.Trim.ToUpper
                Case "T"
                    pomBoja = "Red"
                Case "L"
                    pomBoja = "Yellow"
                Case "G"
                    pomBoja = "Green"
                Case "P"
                    pomBoja = "Purple"
                Case "Q"
                    pomBoja = "PaleGreen"
                Case "N"
                    pomBoja = ""
            End Select

            If poljeGreska.IndexOf("#FP") >= 0 Or poljeGreska.IndexOf("UPARK") >= 0 Or poljeGreska.IndexOf("JMBG") >= 0 Then
                strGENGr = strGENGr + "     '****" + poljeGreska + nvrd
            Else
                poljeGreska = razCASTiLK(poljeGreska)
                Dim poljaUgr As String() = PoljaUGresci(tabela, poljeGreska)
                strGENGr = strGENGr + "     red = dt.Select(" + nvd + poljeGreska + nvd + ") " + nvrd
                strGENGr = strGENGr + "     If red.Length > 0 Then" + nvrd
                strGENGr = strGENGr + "         poruka= poruka + " + nvd + poljeNazivGreske + ";<br/>" + nvd + nvrd
                strGENGr = strGENGr + "         imaG = True" + nvrd
                If poljaUgr.Length > 0 Then
                    For ii As Integer = 0 To poljaUgr.GetUpperBound(0)
                        If pomBoja <> "" Then
                            strGENGr = strGENGr + "         'Me." + poljaUgr(ii) + ".BorderColor = Drawing.Color." + pomBoja + nvrd
                            strGENGr = strGENGr + "         Me." + poljaUgr(ii) + ".BackColor = Drawing.Color." + pomBoja + nvrd
                        End If
                        strGENGr = strGENGr + "         Me." + poljaUgr(ii) + ".ToolTip = " + nvd + poljeNazivGreske + nvd + nvrd
                    Next
                End If
                strGENGr = strGENGr + "     End If" + nvrd
            End If
        Next

        Dim strSelect As String = nvd + "select * FROM " + pravaBaza + ".dbo." + tabela + " where 2=3;" + nvd + nvrd
        Dim txtLK As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pocetakLK.txt")
        Dim strLK As String = txtLK.ReadToEnd
        strLK = strLK.Replace("99strSelect99", strSelect)

        str = str + "Function LK() as Boolean" + nvrd
        str = str + strLK + nvrd
        str = str + strGENGr + nvrd
        str = str + nvrd
        str = str + "       Me.lblPorukaGR.Text = poruka" + nvrd
        str = str + "       Return imaG" + nvrd
        str = str + "End Function" + nvrd
        dajLK = str
        txtLK.Close()
    End Function

    Function dajLKpanel(ByVal tabelap As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim sql As String = ""
        Dim dt As New System.Data.DataTable
        Dim dtT As New System.Data.DataTable

        Dim poljeGreska As String
        Dim poljeRbrGreske As String
        Dim poljeNazivGreske As String
        Dim poljeTezina As String

        'pravila koja nemaju select...
        sql = " select greska,RbrGreske,NazivGreske,tezina from dbo.vISTLK ('" + vt + "','" + IzIst + "') where tabela='" + tabelap + "'"
        dt.Clear()

        dt = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        Dim str As String = ""
        Call NapraviDGTabelu(tabelap)

        Dim strGENGr As String = "" + nvrd
        Dim pomBoja As String = "Red"
        For i As Integer = 0 To dt.Rows.Count - 1
            poljeGreska = dt.Rows(i).Item("greska").ToString.Trim.ToUpper
            poljeRbrGreske = dt.Rows(i).Item("RbrGreske").ToString.Trim
            poljeNazivGreske = dt.Rows(i).Item("NazivGreske").ToString.Trim
            poljeNazivGreske = poljeNazivGreske.Replace(nvd, "''")
            poljeTezina = dt.Rows(i).Item("tezina").ToString.Trim
            'L - поље које је део грешке је жуте боје у уносу
            'Тешке:
            'Празно - поље које је део грешке је црвене боје у уносу
            'Т - поље које је део грешке је црвене боје у уносу
            'G - поље које је део грешке је зелене боје у уносу
            'P - поље које је део грешке је љубичасте боје у уносу
            'N - поље које је део грешке се не боји
            Select Case poljeTezina.Trim.ToUpper
                Case "T"
                    pomBoja = "Red"
                Case "L"
                    pomBoja = "Yellow"
                Case "G"
                    pomBoja = "Green"
                Case "P"
                    pomBoja = "Purple"
                Case "Q"
                    pomBoja = "PaleGreen"
                Case "N"
                    pomBoja = ""
            End Select
            If poljeGreska.IndexOf("#FP") >= 0 Or poljeGreska.IndexOf("UPARK") >= 0 Or poljeGreska.IndexOf("JMBG") >= 0 Then
                strGENGr = strGENGr + "     '****" + poljeGreska + nvrd
            Else
                poljeGreska = razCASTiLK(poljeGreska)
                Dim poljaUgr As String() = PoljaUGresci(tabelap, poljeGreska)
                strGENGr = strGENGr + "     red = dt.Select(" + nvd + poljeGreska + nvd + ") " + nvrd
                strGENGr = strGENGr + "     If red.Length > 0 Then" + nvrd
                strGENGr = strGENGr + "         poruka= poruka + " + nvd + poljeNazivGreske + ";<br/>" + nvd + nvrd
                strGENGr = strGENGr + "         imaG = True" + nvrd
                If poljaUgr.Length > 0 Then
                    For ii As Integer = 0 To poljaUgr.GetUpperBound(0)
                        If pomBoja <> "" Then
                            strGENGr = strGENGr + "         'Me.PNL" + tabelap + poljaUgr(ii) + ".BorderColor = Drawing.Color.Red" + nvrd
                            strGENGr = strGENGr + "         Me.PNL" + tabelap + poljaUgr(ii) + ".BackColor = Drawing.Color.Red" + nvrd
                        End If
                        strGENGr = strGENGr + "         Me.PNL" + tabelap + poljaUgr(ii) + ".ToolTip = " + nvd + poljeNazivGreske + nvd + nvrd
                    Next
                End If
                strGENGr = strGENGr + "     End If" + nvrd
            End If
        Next

        Dim strSelect As String = nvd + "select * FROM " + pravaBaza + ".dbo." + tabelap + " where 2=3;" + nvd + nvrd
        Dim txtLK As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pocetakLKpanel.txt")
        Dim strLK As String = txtLK.ReadToEnd
        strLK = strLK.Replace("99strSelect99", strSelect)

        str = str + "Function LK" + tabelap + "() as Boolean" + nvrd
        str = str + strLK + nvrd
        str = str + "Call dajDefaultBorderColorPanel(" + nvd + tabelap + nvd + ")" + nvrd
        str = str + "Call popuniReduDSPanel(" + nvd + tabelap + nvd + ", dsLK.Tables(0), dsLK.Tables(0).Rows(0))"
        str = str + strGENGr + nvrd
        str = str + nvrd
        str = str + "       Me.lblPorukaGR.Text = poruka" + nvrd
        str = str + "       Return imaG" + nvrd
        str = str + "End Function" + nvrd
        dajLKpanel = str
        txtLK.Close()
    End Function

    Private Function PoljaUGresci(ByVal tabela As String, ByVal greska As String) As String()

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "tabela='" & tabela & "'"
        Dim trt() As String = {}

        For i As Integer = 0 To dv.Count - 1
            If ELPoljeUGresci(dv(i).Item("polje").Trim.ToUpper, greska) Then
                ReDim Preserve trt(1 + trt.GetUpperBound(0))
                If dv(i).Item("tippolja").Trim.ToUpper <> "LBL" Then
                    trt(trt.GetUpperBound(0)) = dv(i).Item("imeweb").Trim.ToUpper
                End If
            End If
        Next

        Return trt
    End Function

    Private Function ELPoljeUGresci(ByVal polje As String, ByVal greska As String, Optional ByVal Glavan As Boolean = False) As Boolean
        Dim gde As Integer = Microsoft.VisualBasic.InStr(greska.Trim.ToUpper, polje.Trim.ToUpper)

        If gde <> 0 Then
            Dim sl1 As Char = " "c
            If gde > 1 Then sl1 = Microsoft.VisualBasic.Mid(greska.Trim.ToUpper, gde - 1, 1)
            Dim sl2 As Char = " "c
            If gde + polje.Trim.Length <= greska.Trim.Length Then
                sl2 = Microsoft.VisualBasic.Mid(greska.Trim.ToUpper, gde + polje.Trim.Length, 1)
            End If
            'goran 15.05.2012
            If (Not System.Char.IsLetterOrDigit(sl1)) AndAlso (Not System.Char.IsLetterOrDigit(sl2)) AndAlso (sl1 <> "_"c) AndAlso (sl2 <> "_"c) Then
                If Glavan Then
                    If sl1 <> "."c Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return True
                End If
            Else
                If gde + polje.Trim.Length > greska.Trim.Length Then
                    Return False
                Else
                    Return ELPoljeUGresci(polje, greska.Substring(gde + polje.Trim.Length), Glavan)
                End If

            End If
        End If
        Return False
    End Function

    Private Function razCASTi(ByVal s As String) As String

        Dim kk() As String = razkvantaj(s)
        Dim trt As String = ""
        Dim i As Integer = 0
        While i <= kk.GetUpperBound(0)
            If kk(i).Trim = "CAST" OrElse kk(i).Trim = "CHARINDEX" OrElse kk(i).Trim = "INSTR" OrElse kk(i).Trim = "ISDATE" Or
    kk(i).Trim = "ISNUMERIC" OrElse kk(i).Trim = "LTRIM" OrElse kk(i).Trim = "RTRIM" Or kk(i).Trim = "LEFT" Or
    kk(i).Trim = "RIGHT" OrElse kk(i).Trim = "LEN" OrElse kk(i).Trim = "FLOOR" Then
                Dim brz As Integer = 1 : Dim pC As Integer = i + 2 : Dim kC As Integer = 0
                Dim Fja As String = kk(i).Trim
                Dim ZnakRazdvajanja As String = Microsoft.VisualBasic.IIf(kk(i).Trim = "CAST", "AS", ",")
                i += 1
                While brz > 0
                    i += 1
                    If kk(i) = "(" Then brz += 1
                    If kk(i) = ")" Then brz -= 1
                    If kk(i) = ZnakRazdvajanja Then kC = i - 1 'If kk(i) = "AS" Then kC = i - 1
                End While

                Dim frazla As String = ""
                Dim drugiP As String = ""
                Dim parm As Integer
                Select Case Fja
                    Case "CAST", "INSTR" '1-vi parametar
                        frazla = ustringaj(kk, pC, kC).ToUpper
                    Case "CHARINDEX" '2-gi parametar
                        frazla = ustringaj(kk, kC + 2, i - 1)
                    Case "LEFT", "RIGHT" '1 i 2-gi parametar
                        frazla = ustringaj(kk, pC, kC).ToUpper
                        drugiP = ustringaj(kk, kC + 2, i - 1)
                        parm = CType(drugiP, System.Int32)
                    Case "ISDATE" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "ISNUMERIC" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "RTRIM" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "LTRIM" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "LEN" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "FLOOR" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                End Select
                If frazla.IndexOf("CAST") >= 0 Or frazla.IndexOf("CHARINDEX") >= 0 Or
            frazla.IndexOf("INSTR") >= 0 Or frazla.IndexOf("ISDATE") >= 0 Or
            frazla.IndexOf("ISNUMERIC") >= 0 Or frazla.IndexOf("LTRIM") >= 0 Or
            frazla.IndexOf("RTRIM") >= 0 Or frazla.IndexOf("LEFT") >= 0 Or
            frazla.IndexOf("RIGHT") >= 0 Or frazla.IndexOf("LEN") >= 0 Or
            frazla.IndexOf("FLOOR") >= 0 Then
                    frazla = razCASTi(frazla)
                End If

                Dim pomkol As New System.Data.DataColumn("pomKol")
                pomkol.Expression = frazla.Trim

                DGTabela.Columns.Add(pomkol)
                Dim mrt = NZ(DGTabela.Compute("MAX(pomKol)", ""))
                DGTabela.Columns.Remove(pomkol)

                Dim bezNavodnika As String = Microsoft.VisualBasic.Replace(Microsoft.VisualBasic.Replace(kk(pC), "'", ""), """", "")
                Select Case Fja
                    Case "CAST"
                        Select Case kk(kC + 2)
                            Case "DATE", "DATETIME", "CHAR", "STRING"
                                mrt = "'" & CType(mrt, System.String).Trim & "'"
                            Case "INT", "INTEGER", "DOUBLE", "REAL", "FLOAT", "DECIMAL", "NUMBER"
                                If mrt.GetType Is GetType(System.DBNull) OrElse
                        CType(mrt, System.String).Trim = "" OrElse
                        Microsoft.VisualBasic.IsNumeric(mrt) = False Then mrt = "0"
                            Case Else
                        End Select
                    Case "CHARINDEX"
                        mrt = Microsoft.VisualBasic.InStr(mrt, bezNavodnika)
                    Case "INSTR"
                        mrt = Microsoft.VisualBasic.InStr(bezNavodnika, mrt)
                    Case "ISDATE"
                        If Microsoft.VisualBasic.IsDate(mrt) Then mrt = " 2=3 " Else mrt = " 2=2 "
                    Case "ISNUMERIC"
                        If Microsoft.VisualBasic.IsNumeric(mrt) = True Then
                            mrt = " 2=2 "
                        Else
                            mrt = " 2=3 "
                        End If
                    Case "LTRIM"
                        mrt = "'" & CType(mrt, System.String).Trim & "'"
                    Case "RTRIM"
                        mrt = "'" & CType(mrt, System.String).Trim & "'"
                    Case "LEN"
                        mrt = "'" & CType(mrt, System.String).Trim.Length & "'"
                    Case "FLOOR"
                        If mrt.GetType Is GetType(System.DBNull) OrElse CType(mrt, System.String).Trim = "" OrElse Microsoft.VisualBasic.IsNumeric(mrt) = False Then
                            mrt = "0"
                        Else
                            'mrt je the largest integer less than or equal
                            mrt = CType(mrt, Double)
                            mrt = System.Math.Floor(mrt)
                        End If

                'mrt = "'" & CType(mrt, System.String).Trim & "'"
                    Case "LEFT"
                        If mrt.trim.length >= parm Then
                            mrt = "'" & mrt.Substring(0, parm).ToString.Trim.ToUpper & "'"
                        Else
                            mrt = "'" & mrt.trim & "'"
                        End If
                    Case "RIGHT"
                        If mrt.trim.length >= parm Then
                            mrt = "'" & mrt.substring(mrt.trim.length - parm) & "'"
                        Else
                            mrt = "'" & mrt.trim & "'"
                        End If
                End Select
                trt += " " & mrt
            Else
                trt += " " & kk(i)
            End If
            trt = trt.Replace(" ' ", "'")
            i += 1
        End While
        Return trt
    End Function

    Private Function razCASTiLK(ByVal s As String) As String

        'len postoji
        'substring
        s = s.Trim.ToUpper.Replace("RTRIM", "TRIM").Replace("LTRIM", "TRIM")
        Dim kk() As String = razkvantaj(s)
        Dim trt As String = ""
        Dim i As Integer = 0
        While i <= kk.GetUpperBound(0)
            If kk(i).Trim = "CAST" OrElse kk(i).Trim = "CHARINDEX" OrElse kk(i).Trim = "INSTR" OrElse kk(i).Trim = "ISDATE" OrElse kk(i).Trim = "ISNUMERIC" OrElse kk(i).Trim = "LEFT" OrElse kk(i).Trim = "RIGHT" Or kk(i).Trim = "FLOOR" Then
                Dim brz As Integer = 1 : Dim pC As Integer = i + 2 : Dim kC As Integer = 0
                Dim Fja As String = kk(i).Trim
                Dim ZnakRazdvajanja As String = Microsoft.VisualBasic.IIf(kk(i).Trim = "CAST", "AS", ",")
                i += 1
                While brz > 0
                    i += 1
                    If kk(i) = "(" Then brz += 1
                    If kk(i) = ")" Then brz -= 1
                    If kk(i) = ZnakRazdvajanja Then kC = i - 1 'If kk(i) = "AS" Then kC = i - 1
                End While

                Dim frazla As String = ""
                Dim drugiP As String = ""
                Dim parm As Integer
                Select Case Fja
                    Case "CAST", "INSTR" '1-vi parametar
                        frazla = ustringaj(kk, pC, kC).ToUpper
                    Case "CHARINDEX" '2-gi parametar
                        frazla = ustringaj(kk, kC + 2, i - 1)
                    Case "LEFT", "RIGHT" '1 i 2-gi parametar
                        frazla = ustringaj(kk, pC, kC).ToUpper
                        drugiP = ustringaj(kk, kC + 2, i - 1).Trim
                        parm = CType(drugiP, System.Int32)
                    Case "ISDATE" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "ISNUMERIC" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "FLOOR" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                End Select
                If frazla.IndexOf("CAST") >= 0 Or frazla.IndexOf("CHARINDEX") >= 0 Or
            frazla.IndexOf("INSTR") >= 0 Or frazla.IndexOf("ISDATE") >= 0 Or
            frazla.IndexOf("ISNUMERIC") >= 0 Or frazla.IndexOf("LEFT") >= 0 Or
            frazla.IndexOf("RIGHT") >= 0 Or frazla.IndexOf("FLOOR") >= 0 Then
                    frazla = razCASTi(frazla)
                End If

                Dim mrt As String = ""

                Dim bezNavodnika As String = Microsoft.VisualBasic.Replace(Microsoft.VisualBasic.Replace(kk(pC), "'", ""), """", "")
                Select Case Fja
                    Case "CAST"
                        Select Case kk(kC + 2)
                            Case "DATE", "DATETIME", "CHAR", "STRING"
                                mrt = "CONVERT (" + frazla.Trim + ", 'system.string')"
                            Case "INT", "INTEGER"
                                mrt = "CONVERT (" + frazla.Trim + ", 'system.int32')"
                            Case "DOUBLE", "REAL", "FLOAT", "DECIMAL", "NUMBER"
                                mrt = "CONVERT (" + frazla.Trim + ", 'system.decimal')"
                            Case Else
                        End Select
                    Case "CHARINDEX"
                        mrt = " 2=2 "
                    Case "INSTR"
                        mrt = " 2=2 "
                    Case "ISDATE"
                        mrt = " 2=2 "
                    Case "ISNUMERIC"
                        mrt = " 2=2 "
                    Case "FLOOR"
                        mrt = " 2=2 "
                    Case "LEFT"
                        mrt = "SUBSTRING (" + frazla.Trim + ",1," + CStr(parm) + ")"
                    Case "RIGHT"
                        mrt = "SUBSTRING (" + frazla.Trim + ",len(" + frazla.Trim + ")-" + CStr(parm) + "+1," + CStr(parm) + ")"
                End Select
                trt += " " & mrt
            Else
                trt += " " & kk(i)
            End If
            trt = trt.Replace(" ' ", "'")
            i += 1
        End While
        Return trt
    End Function

    Function dajZapamtiPlus(ByVal nnizPlus() As String, ByVal nnizPamti() As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim str As String = ""
        str = str + "Sub zapamtiPlus()" + nvrd

        If nnizPlus.Length > 0 Then
            For i As Integer = 0 To nnizPlus.GetUpperBound(0)
                Dim trt() As String = Microsoft.VisualBasic.Split(nnizPlus(i), ";")
                str = str + "   Session.Add(" + nvd + trt(0).Trim + nvd + ", Me." + trt(0).Trim + ".Text)" + nvrd
                str = str + "   Session.Add(" + nvd + "TIP" + trt(0).Trim + nvd + "," + nvd + trt(1).Trim + nvd + ")" + nvrd
                str = str + "   Session.Add(" + nvd + "DUZINA" + trt(0).Trim + nvd + "," + nvd + trt(2).Trim + nvd + ")" + nvrd
            Next
        End If
        If nnizPamti.Length > 0 Then
            For i As Integer = 0 To nnizPamti.GetUpperBound(0)
                str = str + "   Session.Add(" + nvd + nnizPamti(i).Trim + nvd + ", Me." + nnizPamti(i).Trim + ".Text)" + nvrd
            Next
        End If
        str = str + "End Sub" + nvrd

        dajZapamtiPlus = str
    End Function

    Function dajdodajPlusPonoviP(ByVal nnizPlus() As String, ByVal nnizPamti() As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim str As String = ""
        str = str + "Sub dodajPlusPonoviP()" + nvrd
        str = str + "   Dim trt as Integer = 0" + nvrd
        str = str + "   Dim i as Integer" + nvrd
        str = str + "   Dim mrt as String" + nvrd
        str = str + "   Dim duzina as Integer = 1" + nvrd
        str = str + "   Dim tip as String" + nvrd
        'DG=P
        If nnizPamti.Length > 0 Then
            For i As Integer = 0 To nnizPamti.GetUpperBound(0)
                str = str + "   Me." + nnizPamti(i).Trim + ".Text= Session(" + nvd + nnizPamti(i).Trim + nvd + ")" + nvrd
            Next
        End If
        'DG=+
        If nnizPlus.Length > 0 Then
            For i As Integer = 0 To nnizPlus.GetUpperBound(0)
                Dim trt() As String = Microsoft.VisualBasic.Split(nnizPlus(i), ";")
                str = str + "   trt = CInt( Session(" + nvd + trt(0).Trim + nvd + "))+ 1" + nvrd
                str = str + "   tip = Session(" + nvd + "TIP" + trt(0).Trim + nvd + ")" + nvrd
                str = str + "   duzina = Session(" + nvd + "DUZINA" + trt(0).Trim + nvd + ")" + nvrd
                str = str + "   mrt = CStr(trt).Trim" + nvrd
                str = str + "   If tip=" + nvd + "char" + nvd + " Then" + nvrd
                str = str + "       For i  = 0 To duzina - mrt.Length - 1" + nvrd
                str = str + "           mrt = " + nvd + "0" + nvd + "+ mrt" + nvrd
                str = str + "       Next" + nvrd
                str = str + "   End If" + nvrd
                str = str + "   Me." + trt(0).Trim + ".Text= mrt" + nvrd
            Next
        End If

        str = str + "End Sub" + nvrd
        dajdodajPlusPonoviP = str
    End Function

    Function dajGetSlog(ByVal brojACE As Integer, ByVal tabela As String, ByVal strACE As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim txtP As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pGetSlog.txt")
        Dim strP As String = txtP.ReadToEnd
        txtP.Close()

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')<>'P' and TipPolja<>'LBL'"
        dv.Sort = "rbr ASC"
        'npr opstina
        Dim str As String = ""
        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim
            Dim filtriranoPolje As String = dv(i).Item("filtriranoPolje").ToString.Trim
            Dim filtriranoPoPolju As String = dv(i).Item("filtriranoPoPolju").ToString.Trim.Replace("d.", "")
            Dim poljePoKomeSeFiltrira As String = ""

            'ovo samo za CBW, NE ZA DDL i CBO
            'ako je poljeWeb filterovano ide popuni prvo
            If poljeWeb.Trim.Substring(0, 1) <> "T" AndAlso filtriranoPolje = 1 Then
                Dim dv2 As New System.Data.DataView(dISTPoljaKonsult)
                dv2.RowFilter = "tabela='" & tabela & "' and polje='" & filtriranoPoPolju & "'"
                poljePoKomeSeFiltrira = CType(dv2.Item(0), System.Data.DataRowView).Row("imeWeb").ToString.Trim
                str = str + "    popuni_" + poljeWeb + "(" + poljeWeb + "," + poljePoKomeSeFiltrira + ".Text" + ")" + nvrd
                str = str + "    If Not IsDBNull(red.Item(" + nvd + poljeUBazi + nvd + ").ToString.Trim) Then" + nvrd
                str = str + "       Try" + nvrd
                str = str + "           Me." + poljeWeb + ".Text = red.Item(" + nvd + poljeUBazi + nvd + ").ToString.Trim" + nvrd
                str = str + "       Catch" + nvrd
                str = str + "           Me." + poljeWeb + ".Text = red.Item(" + nvd + poljeUBazi + nvd + ").ToString" + nvrd
                str = str + "       End Try" + nvrd
                str = str + "    Else" + nvrd
                str = str + "           Me." + poljeWeb + ".Text =" + nvd + nvd + "" + nvrd
                str = str + "    End If" + nvrd + nvrd
            End If
        Next
        strP = strP.Replace("99dodajZaFiltriraneC99", str)
        'ako ima ACE onda
        If brojACE > 0 Then
            strACE = strACE.Trim.ToUpper      'zamena GGGMMM u izrazu

            strACE = ZameniGGGMMMSimple(strACE, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
            strACE = Microsoft.VisualBasic.Replace(strACE, ".DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            strACE = Microsoft.VisualBasic.Replace(strACE, ".DBO.DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            strP = strP.Replace("99ACE99", strACE)
        Else
            strP = strP.Replace("99ACE99", "")
        End If
        dajGetSlog = strP

    End Function

    Function dajACEPanel(ByVal brojACE As Integer, ByVal strACE As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        'ako ima ACE onda
        If brojACE > 0 Then
            strACE = strACE.Trim.ToUpper      'zamena GGGMMM u izrazu
            strACE = ZameniGGGMMMSimple(strACE, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
            strACE = Microsoft.VisualBasic.Replace(strACE, ".DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
            strACE = Microsoft.VisualBasic.Replace(strACE, ".DBO.DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
        Else
            strACE = ""
        End If
        dajACEPanel = strACE

    End Function

    Function dajdodajZaFiltriraneCPanel(ByVal tabelap As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabelap.Trim + "' and isnull(KLJUC,'')<>'P' and TipPolja<>'LBL'"
        dv.Sort = "rbr ASC"
        'npr opstina
        Dim str As String = ""
        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim
            Dim filtriranoPolje As String = dv(i).Item("filtriranoPolje").ToString.Trim
            Dim filtriranoPoPolju As String = dv(i).Item("filtriranoPoPolju").ToString.Trim.Replace("d.", "")
            Dim poljePoKomeSeFiltrira As String = ""
            'ovo samo za CBW, NE ZA DDL i CBO
            'ako je poljeWeb filterovano ide popuni prvo
            If poljeWeb.Trim.Substring(0, 1) <> "T" AndAlso filtriranoPolje = 1 Then
                Dim dv2 As New System.Data.DataView(dISTPoljaKonsult)
                dv2.RowFilter = "tabela='" & tabelap & "' and polje='" & filtriranoPoPolju & "'"
                poljePoKomeSeFiltrira = CType(dv2.Item(0), System.Data.DataRowView).Row("imeWeb").ToString.Trim
                str = str + "   popuni_" + poljeWeb + "(" + poljeWeb + "," + poljePoKomeSeFiltrira + ".Text" + ")" + nvrd
                str = str + "    If Not IsDBNull(red.Item(" + nvd + poljeUBazi + nvd + ").ToString.Trim) Then" + nvrd
                str = str + "       Try" + nvrd
                str = str + "           Me." + poljeWeb + ".Text = red.Item(" + nvd + poljeUBazi + nvd + ").ToString.Trim" + nvrd
                str = str + "       Catch" + nvrd
                str = str + "           Me." + poljeWeb + ".Text = red.Item(" + nvd + poljeUBazi + nvd + ").ToString" + nvrd
                str = str + "       End Try" + nvrd
                str = str + "    Else" + nvrd
                str = str + "           Me." + poljeWeb + ".Text =" + nvd + nvd + "" + nvrd
                str = str + "    End If" + nvrd + nvrd
            End If
        Next
        dajdodajZaFiltriraneCPanel = str
    End Function

    Function dajSaveSlog(ByVal tabela As String, ByVal strKod As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim tab As String = pravaBaza + ".dbo." + tabela

        Dim kljuc As String = spremiWhereKljuc(tabela)
        Dim kljucPoruka As String = kljuc
        kljucPoruka = kljucPoruka.Replace("2=2 AND", "")
        kljucPoruka = kljucPoruka.Replace(" AND", ";")

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pSaveSlog.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()

        strSS = strSS.Replace("99TABELA99", tab)
        strSS = strSS.Replace("99KLJUC99", kljuc)
        strSS = strSS.Replace("99SLOG99", kljucPoruka)
        strSS = strSS.Replace("99KODZAPODTABELE99", strKod)

        dajSaveSlog = strSS

    End Function

    Function dajviewPanel(ByVal tabelaP As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim kljucP As String = spremiWhereKljuc(tabelaP, , True)

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\viewVBPanel.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()
        strSS = strSS.Replace("99TABELAPKLJUCNIJEPRAZAN99", StringKojiIspitujeKljuc(tabelaP, True))
        strSS = strSS.Replace("99TABELAP99", tabelaP)
        strSS = strSS.Replace("99TABELAPKLJUC99", kljucP)
        dajviewPanel = strSS

    End Function

    Function dajView(ByVal strG As String, ByVal tabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\viewVB.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        str = str.Replace("99KLJUCNIJEPRAZAN99", StringKojiIspitujeKljuc(tabela))
        str = str.Replace("99USESIJU99", strG)

        Dim strFK As String = ""
        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and imeWeb like 'FK_%'"
        dv.Sort = "tabela ASC"
        If dv.Count = 0 Then
            str = str.Replace("99DODELAFPSAPK99", "")
        Else

            For i As Integer = 0 To dv.Count - 1
                Dim upit As String = dv(i).Item("izraz").ToString.Trim.ToUpper.Replace("#{", "").Replace(":PK}", "")
                upit = upit.Replace(":S", "").Replace(":F", "")
                'zamena GGG,MMM
                'zamena GGGMMM u izrazu
                upit = ZameniGGGMMMSimple(upit, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))

                Dim aaa() As String = razkvantaj(upit)
                For ii As Integer = 0 To aaa.Length() - 1
                    If aaa(ii).Length() > 1 AndAlso aaa(ii).Substring(0, 2).ToUpper = "D." Then
                        Dim plj As String = aaa(ii).Replace("D.", "").Trim.ToUpper
                        Dim dvii As New System.Data.DataView(dISTPoljaKonsult)
                        dvii.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='" + plj + "'"
                        dvii.Sort = "tabela ASC"
                        If dvii.Count > 0 Then
                            aaa(ii) = "'" + nvd + " + Me." + dvii(0).Item("imeWeb").ToString.Trim() + ".Text + " + nvd + "'"
                        Else
                            aaa(ii) = aaa(ii).Replace("D.", "").Trim.ToUpper
                        End If
                    End If
                Next

                upit = ustringaj(aaa).ToUpper()
                upit = upit + nvd

                strFK = strFK + "Dim str" + i.ToString.Trim + " As String =" + nvd + upit + nvrd
                strFK = strFK + "Dim ds" + i.ToString.Trim + " As New DataSet" + nvrd
                strFK = strFK + "ds" + i.ToString.Trim + "=b.DajDS_IzUpita(str" + i.ToString.Trim + ", Me.lblKonekcija.Text)" + nvrd
                strFK = strFK + "If ds" + i.ToString.Trim + ".Tables(0).Rows.Count > 0 Then" + nvrd
                Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim()
                strFK = strFK + "   Me." + poljeWeb + ".Text = ds" + i.ToString.Trim + ".Tables(0).Rows(0).Item(0).ToString.Trim" + nvrd
                strFK = strFK + "End If" + nvrd
            Next

            str = str.Replace("99DODELAFPSAPK99", strFK)
        End If

        dajView = str
    End Function

    Function dajcmdCuvajPanel(ByVal tabela As String, ByVal tabelaP As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim kljuc As String = spremiWhereKljuc(tabela)
        Dim kljucP As String = spremiWhereKljuc(tabelaP, , True)

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\cmdCuvajPanel.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()

        strSS = strSS.Replace("99TABELA99", tabela)
        strSS = strSS.Replace("99KLJUC99", kljuc)
        strSS = strSS.Replace("99TABELAP99", tabelaP)
        strSS = strSS.Replace("99TABELAPKLJUC99", kljucP)

        'postavi fokus na prvi kljuc koji je koji je vidljiv
        Dim dt As System.Data.DataTable
        dt = poljaKljucKojaNePostoje1(tabelaP, tabela)

        If dt.Rows.Count > 0 Then
            strSS = strSS.Replace("99FOKUSTABELAP99", "PNL" + tabelaP + dt.Rows(0).Item("imeweb").trim.toupper)
        Else
            strSS = strSS.Replace("99FOKUSTABELAP99", "")
        End If

        dajcmdCuvajPanel = strSS

    End Function

    Function poljaKljucKojaNePostoje1(ByVal tabela As String, ByVal nadtabela As String) As System.Data.DataTable
        ''polja vISTPoljaKonsultTabela koja postoje u tabeli1, a ne postoje vISTPoljaKonsultTabela u tabeli 2
        'Dim sql1 As String = "select rbr,polje,imeweb,tipPolja from vISTPoljaKLJUCKonsultTabela('" + vt + "','" + IzIst + "','" + tabela + "') A" _
        '+ " where kljuc='P' order by rbr"
        'Dim sql2 As String = "select polje from vISTPoljaKLJUCKonsultTabela('" + vt + "','" + IzIst + "','" + nadtabela + "')" _
        '+ " where kljuc='P' "

        Dim dt1 As System.Data.DataTable
        dt1 = fdtusp_vISTPoljaKljucKonsultTabela(vt, IzIst, tabela)   'order by rbr"

        Dim dt2 As System.Data.DataTable
        dt2 = fdtusp_vISTPoljaKljucKonsultTabela(vt, IzIst, nadtabela)   'order by rbr"

        poljaKljucKojaNePostoje1 = dt1.Copy

        Dim pp As String = ""
        Dim ppk As String = ""
        Dim ima As Boolean = False
        For i As Integer = 0 To dt1.Rows.Count - 1
            pp = dt1.Rows(i).Item("polje").trim.toupper
            For k As Integer = 0 To dt2.Rows.Count - 1
                ppk = dt2.Rows(k).Item("polje").trim.toupper
                If pp = ppk Then
                    ima = True
                    Exit For
                End If
            Next
            If ima = False Then poljaKljucKojaNePostoje1.ImportRow(dt1.Rows(i))
        Next

    End Function

    Function poljaKljucKojaNePostoje2(ByVal tabela As String, ByVal nadtabela As String) As System.Data.DataTable
        'polja vISTPoljaKonsultTabela koja postoje u tabeli1, a ne postoje vISTPoljaPoTabeli u tabeli 2

        Dim dt1 As System.Data.DataTable
        dt1 = fdtusp_vISTPoljaKljucKonsultTabela(vt, IzIst, tabela)   'order by rbr"

        Dim dt2 As System.Data.DataTable
        dt2 = fdtusp_vISTPoljaKljucPoTabeli(vt, IzIst, nadtabela)   'order by rbr"

        poljaKljucKojaNePostoje2 = dt1.Clone

        Dim pp As String = ""
        Dim ppk As String = ""
        Dim ima As Boolean = False
        For i As Integer = 0 To dt1.Rows.Count - 1
            pp = dt1.Rows(i).Item("polje").trim.toupper
            For k As Integer = 0 To dt2.Rows.Count - 1
                ppk = dt2.Rows(k).Item("polje").trim.toupper
                If pp = ppk Then
                    ima = True
                    Exit For
                End If
            Next
            If ima = False Then poljaKljucKojaNePostoje2.ImportRow(dt1.Rows(i))
        Next

    End Function

    Function poljaKljucKojaNePostoje3(ByVal tabela As String, ByVal nadtabela As String) As System.Data.DataTable
        'polja vISTPoljaPoTabeli koja postoje u tabeli1, a ne postoje vISTPoljaPoTabeli u tabeli 2

        'Dim sql1 As String = "select rbr,polje,redosled as red,imeweb from vISTPoljaKLJUCPoTabeli('" + vt + "','" + IzIst + "','" + tabela + "') A" _
        '+ " where kljuc='P' order by rbr"
        'Dim sql2 As String = "select polje from vISTPoljaKLJUCPoTabeli('" + vt + "','" + IzIst + "','" + nadtabela + "')" _
        '+ " where kljuc='P' "
        Dim dt1 As System.Data.DataTable
        dt1 = fdtusp_vISTPoljaKljucPoTabeli(vt, IzIst, tabela)   'order by rbr"

        Dim dt2 As System.Data.DataTable
        dt2 = fdtusp_vISTPoljaKljucPoTabeli(vt, IzIst, nadtabela)   'order by rbr"

        poljaKljucKojaNePostoje3 = dt1.Clone

        Dim pp As String = ""
        Dim ppk As String = ""
        Dim ima As Boolean = False
        For i As Integer = 0 To dt1.Rows.Count - 1
            pp = dt1.Rows(i).Item("polje").trim.toupper
            For k As Integer = 0 To dt2.Rows.Count - 1
                ppk = dt2.Rows(k).Item("polje").trim.toupper
                If pp = ppk Then
                    ima = True
                    Exit For
                End If
            Next
            If ima = False Then poljaKljucKojaNePostoje3.ImportRow(dt1.Rows(i))
        Next

    End Function

    Function dajDeleteSlog(ByVal tabela As String, ByVal strKod As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim tab As String = pravaBaza + ".dbo." + tabela

        Dim kljuc As String = spremiWhereKljuc(tabela)
        Dim kljucPoruka As String = kljuc
        kljucPoruka = kljucPoruka.Replace("2=2 AND", "")
        kljucPoruka = kljucPoruka.Replace(" AND", ";")

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pDeleteSlog.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()

        strSS = strSS.Replace("99TABELA99", tab)
        strSS = strSS.Replace("99KLJUC99", kljuc)
        strSS = strSS.Replace("99SLOG99", kljucPoruka)
        strSS = strSS.Replace("99KODZAPODTABELE99", strKod)
        dajDeleteSlog = strSS

    End Function

    Function dajSaveSlogPodTabela() As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pSaveSlogPodTabela.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()
        strSS = strSS.Replace("99PRAVABAZA99", pravaBaza)
        dajSaveSlogPodTabela = strSS

    End Function

    Function dajDeleteSlogPodTabela() As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pDeleteSlogPodTabela.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()
        strSS = strSS.Replace("99PRAVABAZA99", pravaBaza)
        dajDeleteSlogPodTabela = strSS

    End Function

    Function dajSaveSlogD(ByVal tabela As String, ByVal poljeBaza As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim tab As String = pravaBaza + ".dbo." + tabela

        Dim kljuc As String = spremiWhereKljuc(tabela)
        Dim kljucPoruka As String = kljuc
        kljucPoruka = kljucPoruka.Replace("2=2 AND", "")
        kljucPoruka = kljucPoruka.Replace(" AND", ";")

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pSaveSlogD.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()

        strSS = strSS.Replace("99DDKPOLJE99", poljeBaza)
        strSS = strSS.Replace("99TABELA99", tabela)
        strSS = strSS.Replace("99KLJUC99", kljuc)
        dajSaveSlogD = strSS

    End Function

    Function dajDeleteSlogD(ByVal tabela As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim tab As String = pravaBaza + ".dbo." + tabela

        Dim kljuc As String = spremiWhereKljuc(tabela)
        Dim kljucPoruka As String = kljuc
        kljucPoruka = kljucPoruka.Replace("2=2 AND", "")
        kljucPoruka = kljucPoruka.Replace(" AND", ";")

        Dim txtSS As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pDeleteSlogD.txt")
        Dim strSS As String = txtSS.ReadToEnd
        txtSS.Close()
        strSS = strSS.Replace("99TABELA99", tabela)
        strSS = strSS.Replace("99KLJUC99", kljuc)
        dajDeleteSlogD = strSS

    End Function

    Function dajNapraviInsert() As String
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\napraviInsert.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        dajNapraviInsert = str
    End Function

    Function dajNapraviUpdate() As String
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\napraviUpdate.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        dajNapraviUpdate = str
    End Function

    Function dajnapraviInsertUpdatePodTabela() As String
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\napraviInsertUpdatePodTabela.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        dajnapraviInsertUpdatePodTabela = str
    End Function

    Function dajNapraviDelete() As String
        Dim txtND As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\napraviDelete.txt")
        Dim strND As String = txtND.ReadToEnd
        txtND.Close()
        dajNapraviDelete = strND
    End Function

    Function prenesiKljuc(ByVal iztabele As String) As String
        Dim pk As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + iztabele.Trim + "' and isnull(KLJUC,'')='P' "
        dv.Sort = "rbr ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim()
            Dim poljeTip As String = dv(i).Item("tipPolja").ToString.Trim()

            pk = pk + "If Not IsNothing(Request.QueryString(" + nvd + poljeUBazi + nvd + ")) Then Me." + poljeWeb + ".Text=  Request.QueryString(" + nvd + poljeUBazi + nvd + ").ToString" + nvrd
            If poljeTip.Substring(0, 1).Trim = "A" Then
                pk = pk + "If Not IsNothing(Request.QueryString(" + nvd + poljeUBazi + nvd + ")) Then Me." + poljeWeb.Replace("_", "_LAZNIDDL") + ".Text=  Request.QueryString(" + nvd + poljeUBazi + nvd + ").ToString" + nvrd
            End If
        Next
        prenesiKljuc = pk
    End Function

    Function disableKljuc(ByVal iztabele As String) As String

        Dim pk As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and tabela='" + iztabele + "' and isnull(KLJUC,'')='P'"
        dv.Sort = "rbr ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim.ToUpper
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim()
            Dim poljeTip As String = dv(i).Item("tipPolja").ToString.Trim()
            If poljeUBazi = "GOD" OrElse poljeUBazi = "MES" OrElse poljeUBazi = "ISTYEAR" OrElse poljeUBazi = "ISTMONTH" Then
                If poljeTip.Substring(0, 1).Trim = "C" Then
                    pk = pk + "Me." + poljeWeb + ".Enabled = False" + nvrd
                Else
                    pk = pk + "Me." + poljeWeb + ".ReadOnly = True" + nvrd
                End If
                If poljeTip.Substring(0, 1).Trim = "A" Then pk = pk + "Me." + poljeWeb.Replace("_", "_LAZNIDDL") + ".ReadOnly = True" + nvrd
            Else
                If poljeTip.Substring(0, 1).Trim = "C" Then
                    pk = pk + "Me." + poljeWeb + ".Enabled = False" + nvrd
                Else
                    pk = pk + "Me." + poljeWeb + ".ReadOnly = True" + nvrd
                End If
                If poljeTip.Substring(0, 1).Trim = "A" Then pk = pk + "Me." + poljeWeb.Replace("_", "_LAZNIDDL") + ".ReadOnly = True" + nvrd
            End If

        Next
        disableKljuc = pk
    End Function

    Function prenesiKljucAdresar(ByVal tabela As String, ByVal adresar As String, ByVal funkcija As String) As String
        Dim pk As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim spojiPoljaTabela As String = ""
        Dim poljaTabela() As String = {}
        If funkcija = "R" Then
            Dim dISTLKRelacija As New System.Data.DataTable
            Dim sql As String = " select * from dbo.vISTLKRelacija ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "' and adresarTabela='" & adresar & "'"
            dISTLKRelacija.Clear()

            dISTLKRelacija = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            spojiPoljaTabela = dISTLKRelacija.Rows(0).Item("spojiPoljaTabela").trim.toupper
            poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela.Trim.ToUpper, " AND ")
            Dim kljNizTRel As String = ""
            For i As Integer = 0 To poljaTabela.GetUpperBound(0)
                poljaTabela(i) = poljaTabela(i).Replace("= ", "").Replace(" =", "")
                kljNizTRel = kljNizTRel + Microsoft.VisualBasic.Split(poljaTabela(i), "=")(0) + ","
            Next
            kljNizTRel = kljNizTRel + ")"
            kljNizTRel = kljNizTRel.Replace(",)", "")
            poljaTabela = Microsoft.VisualBasic.Split(kljNizTRel, ",")
        End If
        If funkcija = "A" Then
            Dim dISTLKAdresar As New System.Data.DataTable
            Dim sql As String = " select * from dbo.vISTLKAdresar ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "' and adresarTabela='" & adresar & "'"
            dISTLKAdresar.Clear()

            dISTLKAdresar = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            spojiPoljaTabela = dISTLKAdresar.Rows(0).Item("spojiPoljaTabela")
            poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela, ",")
        End If

        Dim dvT As New System.Data.DataView(dISTPoljaKonsult)
        dvT.RowFilter = "2=2 and tabela='" + tabela + "' and isnull(KLJUC,'')='P'"
        dvT.Sort = "rbr ASC"

        For i As Integer = 0 To dvT.Count - 1
            Dim poljeUBazi As String = dvT(i).Item("polje").ToString.Trim.ToUpper
            Dim poljeWeb As String = dvT(i).Item("imeWeb").ToString.Trim()
            Dim poljeTip As String = dvT(i).Item("tipPolja").ToString.Trim()
            For j As Integer = 0 To poljaTabela.GetUpperBound(0)
                If poljeUBazi <> "GOD" AndAlso poljeUBazi <> "MES" AndAlso poljeUBazi <> "ISTYEAR" AndAlso poljeUBazi <> "ISTMONTH" Then
                    If dvT(i).Item("polje").ToString.Trim.ToUpper = poljaTabela(j).ToString.ToUpper.Trim Then
                        pk = pk + "If Not IsNothing(Request.QueryString(" + nvd + poljeUBazi + nvd + ")) Then Me." + poljeWeb + ".Text=  Request.QueryString(" + nvd + poljeUBazi + nvd + ").ToString" + nvrd
                        If poljeTip.Substring(0, 1).Trim = "A" Then
                            pk = pk + "If Not IsNothing(Request.QueryString(" + nvd + poljeUBazi + nvd + ")) Then Me." + poljeWeb.Replace("_", "_LAZNIDDL") + ".Text=  Request.QueryString(" + nvd + poljeUBazi + nvd + ").ToString" + nvrd
                        End If
                    End If
                End If
            Next
        Next
        prenesiKljucAdresar = pk
    End Function

    Function disableKljucZaPoljaKojaSuIUAdresaru(ByVal tabela As String, ByVal adresar As String, ByVal imagod As Boolean, ByVal imames As Boolean, ByVal imakv As String, ByVal funkcija As String) As String
        Dim pk As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        If imagod = True Then pk = pk + "Me.TK_GOD.ReadOnly = True" + nvrd
        If imames = True Then pk = pk + "Me.TK_MES.ReadOnly = True" + nvrd
        If imakv = True Then pk = pk + "Me.TK_KV.ReadOnly = True" + nvrd
        Dim spojiPoljaTabela As String = ""
        Dim poljaTabela() As String = {}
        If funkcija = "R" Then
            Dim dISTLKRelacija As New System.Data.DataTable
            Dim sql As String = " select * from dbo.vISTLKRelacija ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "' and adresarTabela='" & adresar & "'"
            dISTLKRelacija.Clear()

            dISTLKRelacija = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            spojiPoljaTabela = dISTLKRelacija.Rows(0).Item("spojiPoljaTabela").trim.toupper

            poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela.Trim.ToUpper, " AND ")
            Dim kljNizTRel As String = ""
            For i As Integer = 0 To poljaTabela.GetUpperBound(0)
                kljNizTRel = kljNizTRel + Microsoft.VisualBasic.Split(poljaTabela(i), "=")(0) + ","
            Next
            kljNizTRel = kljNizTRel + ")"
            kljNizTRel = kljNizTRel.Replace(",)", "")
            poljaTabela = Microsoft.VisualBasic.Split(kljNizTRel, ",")
        End If
        If funkcija = "A" Then
            Dim dISTLKAdresar As New System.Data.DataTable
            Dim sql As String = " select * from dbo.vISTLKAdresar ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "' and adresarTabela='" & adresar & "'"
            dISTLKAdresar.Clear()

            dISTLKAdresar = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            spojiPoljaTabela = dISTLKAdresar.Rows(0).Item("spojiPoljaTabela")
            poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela, ",")
        End If

        Dim dvT As New System.Data.DataView(dISTPoljaKonsult)
        dvT.RowFilter = "2=2 and tabela='" + tabela + "' and isnull(KLJUC,'')='P'"
        dvT.Sort = "rbr ASC"

        For i As Integer = 0 To dvT.Count - 1
            Dim poljeUBazi As String = dvT(i).Item("polje").ToString.Trim.ToUpper
            Dim poljeWeb As String = dvT(i).Item("imeWeb").ToString.Trim()
            Dim poljeTip As String = dvT(i).Item("tipPolja").ToString.Trim()
            For j As Integer = 0 To poljaTabela.GetUpperBound(0)
                If poljeUBazi <> "GOD" AndAlso poljeUBazi <> "MES" AndAlso poljeUBazi <> "ISTYEAR" AndAlso poljeUBazi <> "ISTMONTH" Then
                    If dvT(i).Item("polje").ToString.Trim.ToUpper = poljaTabela(j).ToString.ToUpper.Trim Then
                        If poljeTip.Substring(0, 1).Trim = "C" Then
                            pk = pk + "Me." + poljeWeb + ".Enabled = False" + nvrd
                        Else
                            pk = pk + "Me." + poljeWeb + ".ReadOnly = True" + nvrd
                        End If
                        If poljeTip.Substring(0, 1).Trim = "A" Then pk = pk + "Me." + poljeWeb.Replace("_", "_LAZNIDDL") + ".ReadOnly = True" + nvrd
                    End If
                End If
            Next
        Next

        disableKljucZaPoljaKojaSuIUAdresaru = pk
    End Function

    Function vrtackaIzSesije(ByVal tabela As String) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        ''godina i mesec ako postoje

        If imaG = True Then s = s + "    TK_GOD.Text=Session(" + nvd + "god" + nvd + ")" + nvrd
        If imaM = True Then s = s + "    TK_MES.Text=Session(" + nvd + "mes" + nvd + ")" + nvrd
        If imaK = True Then s = s + "    TK_KV.Text=Session(" + nvd + "kv" + nvd + ")" + nvrd

        vrtackaIzSesije = s
    End Function

    Function imaGODMES(ByVal tabela As String) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        ''godina i mesec ako postoje

        If imaG = True Then s = s + "$GOD$"
        If imaM = True Then s = s + "$MES$"
        If imaGE = True Then s = s + "$ISTYEAR$"
        If imaME = True Then s = s + "$ISTMONTH$"

        If imaK = True Then s = s + "$KV$"

        imaGODMES = s
    End Function

    Function vrtackaUSesiju(ByVal tabela As String) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        If imaG = True Then s = s + "    TK_GOD.Text=Session(" + nvd + "god" + nvd + ")" + nvrd
        If imaM = True Then s = s + "    TK_MES.Text=Session(" + nvd + "mes" + nvd + ")" + nvrd
        If imaK = True Then s = s + "    TK_KV.Text=Session(" + nvd + "kv" + nvd + ")" + nvrd

        vrtackaUSesiju = s
    End Function

    Function lkwebMaster(ByVal tabela As String) As String

        Dim godmeskv As String = imaGMKS(tabela)

        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        'samo god
        If godmeskv.Substring(0, 1) = "T" AndAlso godmeskv.Substring(1, 1) = "F" AndAlso godmeskv.Substring(2, 1) = "F" Then
            s = "select isnull(max(GOD),'') as god from " + tabela + " where LKWeb=1"
        End If
        ' god + mes
        If godmeskv.Substring(0, 1) = "T" AndAlso godmeskv.Substring(1, 1) = "T" AndAlso godmeskv.Substring(2, 1) = "F" Then
            s = "select isnull(LEFT(max(GOD+mes),4),'') as god,isnull(RIGHT(max(GOD+mes),2),'') as mes" +
          " from " + tabela + " where LKWeb=1"
        End If
        ' god + kv
        If godmeskv.Substring(0, 1) = "T" AndAlso godmeskv.Substring(1, 1) = "F" AndAlso godmeskv.Substring(2, 1) = "T" Then
            s = "select isnull(LEFT(max(GOD+kv),4),'') as god,isnull(RIGHT(max(GOD+kv),1),'') as kv" +
          " from " + tabela + " where LKWeb=1"
        End If
        ' god + mes+kv
        If godmeskv.Substring(0, 1) = "T" AndAlso godmeskv.Substring(1, 1) = "T" AndAlso godmeskv.Substring(2, 1) = "T" Then
            s = "select isnull(LEFT(max(GOD+mes+kv),4),'') as god,isnull(substring(max(GOD+mes),5,2),'') as mes,isnull(RIGHT(max(GOD++mes+kv),1),'') as kv" +
          " from " + tabela + " where LKWeb=1"
        End If

        lkwebMaster = s
    End Function

    Function vrtackaMaster(ByVal tabela As String) As String

        Dim godmeskv As String = imaGMKS(tabela)

        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        If godmeskv.Substring(0, 1) = "T" Then
            s = s + "    Dim imaG As Boolean = True" + nvrd
            s = s + "    if not Session(" + nvd + "god" + nvd + ") is nothing then Me.DDLGOD.Text=Session(" + nvd + "god" + nvd + ")" + nvrd
        Else
            s = s + "    Dim imaG As Boolean = False" + nvrd
            s = s + "    Me.lblGOD.Visible = False" + nvrd
            s = s + "    Me.DDLGOD.Visible = False" + nvrd
        End If
        If godmeskv.Substring(1, 1) = "T" Then
            s = s + "    Dim imaM As Boolean = True" + nvrd
            s = s + "    if not Session(" + nvd + "mes" + nvd + ") is nothing then Me.DDLMES.Text=Session(" + nvd + "mes" + nvd + ")" + nvrd
        Else
            s = s + "    Dim imaM As Boolean = False" + nvrd
            s = s + "    Me.lblMES.Visible = False" + nvrd
            s = s + "    Me.DDLMES.Visible = False" + nvrd
        End If
        If godmeskv.Substring(2, 1) = "T" Then
            s = s + "    Dim imaK As Boolean = True" + nvrd
            s = s + "    if not Session(" + nvd + "mes" + nvd + ") is nothing then Me.DDLKV.Text=Session(" + nvd + "kv" + nvd + ")" + nvrd
        Else
            s = s + "    Dim imaK As Boolean = False" + nvrd
            s = s + "    Me.lblKV.Visible = False" + nvrd
            s = s + "    Me.DDLKV.Visible = False" + nvrd
        End If
        If godmeskv.Substring(3, 1) = "T" Then  'jos uvek nije razrađeno
            s = s + "    Dim imaS As Boolean = False" + nvrd
            s = s + "    Me.lblSED.Visible = False" + nvrd
            s = s + "    Me.DDLSED.Visible = False" + nvrd
        End If

        vrtackaMaster = s
    End Function

    Function imaGMKS(ByVal tabela As String) As String
        Dim imaG As String = "F"
        Dim imaM As String = "F"
        Dim imaGE As String = "F"
        Dim imaME As String = "F"

        Dim imaS As String = "F"
        Dim imaK As String = "F"

        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        'bolje iz tabele, ne iz periodike
        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = "T"
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = "T"
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = "T"

        If dvM.Count = 1 Then imaM = "T"
        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = "T"

        imaGMKS = imaG + imaM + imaK + imaS '+ imaGE + imaME

    End Function

    Function spremiPoljaTabeleSaZarezom(ByVal tabela As String, Optional ByVal adr As String = "") As String

        Dim s As String = ""
        spremiPoljaTabeleSaZarezom = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim sqlPolja As String = ""

        If adr = "A" Then
            sqlPolja = "SELECT Stuff((SELECT N', ADRREL.'+ ltrim(rtrim(polje)) FROM vISTPoljaPoTabeli " + "('" + vt + "','" + IzIst + "','" + tabela + "') FOR XML PATH(''),TYPE) .value('text()[1]','nvarchar(max)'),1,2,N'') as polja"
        Else
            sqlPolja = "SELECT Stuff((SELECT N', ' + ltrim(rtrim(tabela)) + '.'+ ltrim(rtrim(polje)) FROM vISTPoljaPoTabeli " + "('" + vt + "','" + IzIst + "','" + tabela + "') FOR XML PATH(''),TYPE) .value('text()[1]','nvarchar(max)'),1,2,N'') as polja"
        End If
        Dim dt As New System.Data.DataTable

        dt = izvrsiSQLvratiDT(sqlPolja, Me.ISTConnectionString, Nothing)

        Try
            spremiPoljaTabeleSaZarezom = dt.Rows(0).Item("polja").ToString.Trim()
        Catch ex As System.Exception
            ''msg 299
            Dim msgtxt299 As String = getMessageText(dtMessages, "299", Me.jezik) + nvrd

            ISTMessageBox.Show(msgtxt299 + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Function

    Function spremiKljucTabeleSaZarezom(ByVal tabela As String) As String

        Dim s As String = ""
        spremiKljucTabeleSaZarezom = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim sqlPolja As String = "SELECT Stuff((SELECT N', ' +  ltrim(rtrim(tabela)) + '.'+ ltrim(rtrim(polje)) FROM vISTPoljaKljucPoTabeli " + "('" + vt + "','" + IzIst + "','" + tabela + "') WHERE KLJUC='P' FOR XML PATH(''),TYPE) .value('text()[1]','nvarchar(max)'),1,2,N'') as polja"

        Dim dt As New System.Data.DataTable

        dt = izvrsiSQLvratiDT(sqlPolja, Me.ISTConnectionString, Nothing)
        Try
            spremiKljucTabeleSaZarezom = dt.Rows(0).Item("polja").ToString.Trim()
        Catch ex As System.Exception
            ''msg 299
            Dim msgtxt299 As String = getMessageText(dtMessages, "299", Me.jezik) + nvrd

            ISTMessageBox.Show(msgtxt299 + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Function

    Function spremiWhereVRTACKA(ByVal tabela As String, Optional ByVal dodajImeTabele As Boolean = False, Optional ByVal adrrel As Boolean = False) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim kljucJe As String = " 2=2"
        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        Dim tt As String = tabela.Trim
        If dodajImeTabele = True Then
            If adrrel = True Then
                tt = "ADRREL"
            End If
            If imaG = True Then kljucJe = kljucJe + " AND " + tt + ".god='" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
            If imaM = True Then kljucJe = kljucJe + " AND " + tt + ".mes='" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + "'" + ""
            If imaK = True Then kljucJe = kljucJe + " AND " + tt + ".kv='" + nvd + " + Me.TK_KV.Text.Trim + " + nvd + "'" + ""
        Else
            If imaG = True Then kljucJe = kljucJe + " AND god='" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
            If imaM = True Then kljucJe = kljucJe + " AND mes='" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + "'" + ""
            If imaK = True Then kljucJe = kljucJe + " AND kv='" + nvd + " + Me.TK_KV.Text.Trim + " + nvd + "'" + ""

        End If
        spremiWhereVRTACKA = kljucJe
    End Function

    Function spremiPrenesiKljucNaPanele(ByVal tabela As String, ByVal tabelap As String) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim kljucJe As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        If imaG = True Then kljucJe = kljucJe + "Me.PNL" + tabelap + "TK_GOD.Text = Me.TK_GOD.Text " + nvrd
        If imaM = True Then kljucJe = kljucJe + "Me.PNL" + tabelap + "TK_MES.Text = Me.TK_MES.Text " + nvrd
        If imaK = True Then kljucJe = kljucJe + "Me.PNL" + tabelap + "TK_KV.Text = Me.TK_KV.Text " + nvrd

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH' and POLJE<>'KV'"
        dv.Sort = "tabela ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim()
            kljucJe = kljucJe + "Me.PNL" + tabelap + poljeWeb + ".Text = Me." + poljeWeb + ".Text " + nvrd
        Next
        spremiPrenesiKljucNaPanele = kljucJe
    End Function

    Function spremiWhereKljuc(ByVal tabela As String, Optional ByVal dodajImeTabele As Boolean = False, Optional ByVal panel As Boolean = False) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim kljucJe As String = " 2=2"
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        If dodajImeTabele = True Then
            If imaG = True Then kljucJe = kljucJe + " AND " + tabela.Trim + ".god='" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
            If imaM = True Then kljucJe = kljucJe + " AND " + tabela.Trim + ".mes='" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + "'" + ""
            If imaK = True Then kljucJe = kljucJe + " AND " + tabela.Trim + ".kv='" + nvd + " + Me.TK_KV.Text.Trim + " + nvd + "'" + ""
        Else
            If imaG = True Then kljucJe = kljucJe + " AND god='" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
            If imaM = True Then kljucJe = kljucJe + " AND mes='" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + "'" + ""
            If imaK = True Then kljucJe = kljucJe + " AND kv='" + nvd + " + Me.TK_KV.Text.Trim + " + nvd + "'" + ""
        End If

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH' and POLJE<>'KV'"
        dv.Sort = "tabela ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim()
            If panel = True Then poljeWeb = "PNL" + tabela.Trim.ToUpper + poljeWeb
            kljucJe = kljucJe + " AND " + poljeUBazi + "='" + nvd + " + Me." + poljeWeb + ".Text.Trim + " + nvd + "'" + ""
        Next
        spremiWhereKljuc = kljucJe
    End Function

    Function spremiWhereKljucWebRelacija(ByVal adresar As String, ByVal tabela As String, ByVal spojiPoljaAdresar() As String, ByVal spojiPoljaTabela() As String, Optional ByVal dodajImeAdresara As Boolean = False) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim kljucJe As String = " 2=2"
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + adresar.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + adresar.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + adresar.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        If dodajImeAdresara = True Then
            If imaG = True Then kljucJe = kljucJe + " AND " + adresar.Trim + ".god='" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
            If imaM = True Then kljucJe = kljucJe + " AND " + adresar.Trim + ".mes='" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + "'" + ""
            If imaK = True Then kljucJe = kljucJe + " AND " + adresar.Trim + ".kv='" + nvd + " + Me.TK_KV.Text.Trim + " + nvd + "'" + ""
        Else
            If imaG = True Then kljucJe = kljucJe + " AND god='" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
            If imaM = True Then kljucJe = kljucJe + " AND mes='" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + "'" + ""
            If imaK = True Then kljucJe = kljucJe + " AND kv='" + nvd + " + Me.TK_KV.Text.Trim + " + nvd + "'" + ""
        End If

        Dim dvA As New System.Data.DataView(dISTPoljaKonsult)
        dvA.RowFilter = "2=2 and TABELA='" + adresar.Trim + "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH' and POLJE<>'KV'"
        dvA.Sort = "tabela ASC"

        For i As Integer = 0 To dvA.Count - 1
            Dim poljeUBazi As String = dvA(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = ""
            For k As Integer = 0 To spojiPoljaAdresar.GetUpperBound(0)
                If spojiPoljaAdresar(k).Trim.ToUpper = dvA(i).Item("polje").ToString.Trim.ToUpper Then
                    Dim dvT As New System.Data.DataView(dISTPoljaKonsult)
                    dvT.RowFilter = "2=2 and TABELA='" & tabela.Trim & "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH' and POLJE<>'KV' and " _
            & "polje='" & spojiPoljaTabela(k).Trim.ToUpper & "'"
                    dvT.Sort = "tabela ASC"
                    poljeWeb = dvT(0).Item("imeWeb").ToString.Trim.ToUpper
                    Exit For
                End If
            Next
            kljucJe = kljucJe + " AND " + poljeUBazi + "='" + nvd + " + Me." + poljeWeb + ".Text.Trim + " + nvd + "'" + ""
        Next
        spremiWhereKljucWebRelacija = kljucJe

    End Function

    Function StringKojiIspitujeKljuc(ByVal tabela As String, Optional ByVal panel As Boolean = False) As String

        Dim kljucJe As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')='P'"
        dv.Sort = "rbr ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim imeWeb As String = dv(i).Item("imeWeb").ToString.Trim
            If panel = True Then imeWeb = "PNL" + tabela.Trim.ToUpper + imeWeb
            kljucJe = kljucJe + " Me." + imeWeb.Trim.ToUpper + ".Text<>" + nvd + nvd + " AND"
        Next
        kljucJe = kljucJe + ")"
        StringKojiIspitujeKljuc = kljucJe.Replace("AND)", "")

    End Function

    Function spremiKljucString(ByVal tabela As String) As String

        Dim kljucJe As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')='P'"
        dv.Sort = "rbr ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            kljucJe = kljucJe + nvd + poljeUBazi + nvd + ","
        Next
        If kljucJe <> "" Then kljucJe = kljucJe + ")"
        spremiKljucString = kljucJe.Replace(",)", "")

    End Function

    Function spremiWhereKljucZaPrelazak(ByVal tabela As String) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim kljucJe As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView(dISTPoljaKonsult)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView(dISTPoljaKonsult)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView(dISTPoljaKonsult)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView(dISTPoljaKonsult)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        Dim dvK As New System.Data.DataView(dISTPoljaKonsult)
        dvK.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='KV'"
        If dvK.Count = 1 Then imaK = True

        If imaG = True Then kljucJe = kljucJe + "&god=" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + ""
        If imaM = True Then kljucJe = kljucJe + "&mes=" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + ""

        'If imaGE = True Then kljucJe = kljucJe + "&ISTYEAR=" + nvd + " + Me.TK_ISTYEAR.Text.Trim + " + nvd + ""
        'If imaME = True Then kljucJe = kljucJe + "&ISTMONTH=" + nvd + " + Me.TK_ISTMONTH.Text.Trim + " + nvd + ""

        If imaK = True Then kljucJe = kljucJe + "&kv=" + nvd + " + Me.TK_KV.Text.Trim + " + nvd + ""
        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES'  and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH' and POLJE<>'KV'"
        dv.Sort = "tabela ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim()
            kljucJe = kljucJe + "&" + poljeUBazi + "=" + nvd + " + Me." + poljeWeb + ".Text.Trim + " + nvd + ""
        Next

        spremiWhereKljucZaPrelazak = kljucJe.Substring(1) '(da preskocim prvi &)

    End Function

    Function dajDefaultPolja(ByVal kljuc As Boolean, ByVal tabela As String, ByVal pp As String, ByVal tipTabele As String, ByVal nadtabela As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim str As String = "" + nvrd

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        If kljuc = True Then
            dv.RowFilter = "2=2 and tabela='" + tabela + "' and isnull(KLJUC,'')='P' and ISNULL(DG,'')<>'' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH' "
        Else
            dv.RowFilter = "2=2 and tabela='" + tabela + "' and isnull(KLJUC,'')<>'P' and ISNULL(DG,'')<>''"
        End If
        dv.Sort = "rbr ASC"

        If kljuc = True Then
            str = str + "Sub PopuniDefaultPoljaKljuc ()" + nvrd
            str = str + "    Me.lblLKpom.Text=" + nvd + "0" + nvd + nvrd
            str = str + "    Me.lblCuvajpom.Text=" + nvd + "1" + nvd + nvrd
            str = str + "    Call vrtackaIzSesije()" + nvrd
            ''msg 117
            Dim msgtxt117 As String = getMessageText(dtMessages, "117", Me.jezik) + nvrd
            ''msg 118
            Dim msgtxt118 As String = getMessageText(dtMessages, "118", Me.jezik) + nvrd
            str = str + msgtxt117
            str = str + msgtxt118
            'str = str + "     '***NA NEKO OD OVIH POLJA IZ KLJUCA TREBA DA BUDE POSTAVLJEN FOCUS" + nvrd
            'str = str + "     '***IST PO DEFAULTU STAVLJA FOCUS NA PRVO POLJE" + nvrd

            If tipTabele.IndexOf("G") = 0 Then
            Else
                prenesiKljuc(nadtabela)
            End If
        Else
            str = str + "Sub PopuniDefaultPoljaKojaNisuKljuc ()" + nvrd
        End If

        If pp.Trim <> "" Then str = str + "    " + pp + ".Focus()" + nvrd
        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim
            Dim DG As String = dv(i).Item("DG").ToString.Trim
            If DG <> "{+}" AndAlso DG.ToUpper <> "{P}" Then
                If poljeWeb.Substring(0, 1) = "T" OrElse poljeWeb.Substring(0, 1) = "H" Then
                    str = str + "    " + poljeWeb + ".Text =" + nvd + DG + nvd + nvrd
                End If
            End If
        Next
        str = str + "End Sub" + nvrd

        dajDefaultPolja = str

    End Function

    Function dajPonistiPoljaKljuc(ByVal DG As String, ByVal tabela As String, ByVal nadtabela As String) As String

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim str As String = "" + nvrd
        Dim sql As String = ""
        Dim dt As New System.Data.DataTable

        If DG = "G" Then
            'sql = " select tipPolja,imeWeb from dbo.vISTPoljaKonsultTabela ('" + vt + "','" + IzIst + "','" + tabela + "') where isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH'  order by rbr"
            'dt = izvrsiSQLvratiDT(sql, ISTConnectionString, Me.jezik)
            dt.Clear()
            dt = fdtusp_vISTPoljaKonsultTabela(vt, IzIst, tabela, "isnull(KLJUC,'''')=''P'' and POLJE <>''GOD'' and POLJE<>''MES'' and POLJE <>''ISTYEAR'' and POLJE<>''ISTMONTH''  order by rbr")
        Else
            'za D ponistavamo samo ono sto je deo kljuca u dupetu, a ne i glavi
            dt = poljaKljucKojaNePostoje2(nadtabela, tabela)
        End If

        str = str + "Sub PonistiPoljaKljuc ()" + nvrd
        str = str + "    Me.lblLKpom.Text=" + nvd + "0" + nvd + nvrd
        str = str + "    Me.lblCuvajpom.Text=" + nvd + "1" + nvd + nvrd
        str = str + "    Call vrtackaIzSesije()" + nvrd

        ''msg 119
        Dim msgtxt As String = getMessageText(dtMessages, "119", Me.jezik)
        str = str + "'" + msgtxt + " (Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")" + nvrd
        'str = str + "     '***NEKO OD OVIH POLJA TREBA DA BUDE STAVLJENO U KOMENTAR ILI POSTAVLJENO NA VREDNOST PREUZETU IZ (Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")" + nvrd
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim tipPolja As String = dt.Rows(i).Item("tipPolja").ToString.Trim
            Dim poljeWeb As String = dt.Rows(i).Item("imeWeb").ToString.Trim

            If tipPolja = "CBO" Or tipPolja = "DDL" Then
                str = str + "    '" + poljeWeb + ".SelectedIndex = -1" + nvrd
            ElseIf tipPolja <> "LBL" Then
                str = str + "    '" + poljeWeb + ".Text =" + nvd + nvd + nvrd
            End If
        Next
        str = str + "'" + msgtxt + " (Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")" + nvrd
        'str = str + "     '***NEKO OD OVIH POLJA TREBA DA BUDE STAVLJENO U KOMENTAR ILI POSTAVLJENO NA VREDNOST PREUZETU IZ (Request.QueryString.Item(" + nvd + "Kljuc" + nvd + ")" + nvrd
        str = str + "End Sub" + nvrd
        dajPonistiPoljaKljuc = str

    End Function

    Function dajBrisiVB(ByVal tabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txtBrisiVB As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\cmdBrisiVB.txt")
        Dim strBrisiVB As String = txtBrisiVB.ReadToEnd
        txtBrisiVB.Close()
        Dim pop As String = ""
        strBrisiVB = strBrisiVB.Replace("99KLJUCNIJEPRAZAN99", StringKojiIspitujeKljuc(tabela))
        dajBrisiVB = strBrisiVB
    End Function

    Function dajOsnovniVB(ByVal tabela As String, ByVal nadtabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txtOsnovniVB As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\osnovniVB.txt")
        Dim strOsnovniVB As String = txtOsnovniVB.ReadToEnd
        txtOsnovniVB.Close()
        Dim pop As String = ""
        strOsnovniVB = strOsnovniVB.Replace("99konekcija99", konekcija)
        strOsnovniVB = strOsnovniVB.Replace("99imeTab99", tabela)
        strOsnovniVB = strOsnovniVB.Replace("Call dsIzSesijeCBO()", "")

        dajOsnovniVB = strOsnovniVB
    End Function

    Function dajPrikaziVB(ByVal tabela As String, ByVal imaGrid As Boolean, ByVal tipT As String,
ByVal strG As String, ByVal strGV As String, Optional ByVal strPKNP As String = "") As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\prikaziVB.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        Dim pop As String = ""
        If imaGrid = False Then
            str = str.Replace("99PRIKAZIGRIDOVE99", "")
        Else
            '"99PRIKAZIGRIDOVE99"
            strG = strG + "Call OsveziGpovratakIzD()" + nvrd
            'ako nema gridova strGridVisible=""
            If strGV.Trim <> "" Then
                strGV = strGV.Replace("XXX", "True")
            End If
            strG = strG + strGV + nvrd
            str = str.Replace("99PRIKAZIGRIDOVE99", strG)
        End If
        'ako ima panel
        If strPKNP <> "" Then
            str = str.Replace("'99POPUNIKLJUCEVENAPANELIMA99", strPKNP)
        End If

        dajPrikaziVB = str
    End Function

    Function dajDodelaIzAdresara(ByVal brojACE As Integer, ByVal tabela As String, ByVal strACE As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dISTDodelaIzAdresara As New System.Data.DataTable
        Dim sqlDodelaIzAdresara As String = " select * from dbo.vISTLKAdresarDodela ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "'"
        dISTDodelaIzAdresara.Clear()

        dISTDodelaIzAdresara = izvrsiSQLvratiDT(sqlDodelaIzAdresara, ISTConnectionString, Nothing)

        Dim str As String = ""
        Dim sta As String = "tabela='" & tabela & "'"

        Dim txtA As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\dodelaIzAdresara.txt")
        Dim strA As String = txtA.ReadToEnd
        txtA.Close()

        If dISTDodelaIzAdresara.Rows.Count > 0 Then
            'postoji dodela iz adresara
            strA = strA.Replace("99TABELA99", pravaBaza + ".dbo." + tabela)
            Dim kljucG As String = spremiWhereKljuc(tabela)
            strA = strA.Replace("99KLJUC99", kljucG)

            Dim adresarTabela As String = dISTDodelaIzAdresara.Rows(0).Item("adresarTabela")
            strA = strA.Replace("99ADRESARTABELA99", pravaBaza + ".dbo." + adresarTabela)

            Dim dv As New System.Data.DataView(dISTPoljaKonsult)
            dv.RowFilter = "2=2 and TABELA='" + adresarTabela.Trim + "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH'  "
            dv.Sort = "rbr ASC"

            Dim tkljucAdresar As String = ""
            For i As Integer = 0 To dv.Count - 1
                tkljucAdresar = tkljucAdresar + dv(i).Item("polje").ToString.Trim + ","
            Next
            tkljucAdresar = tkljucAdresar + "AAA"
            tkljucAdresar = tkljucAdresar.Replace(",AAA", "")

            Dim spojiPoljaTabela As String = dISTDodelaIzAdresara.Rows(0).Item("spojiPoljaTabela")
            Dim poljaTabela() As String = {}
            poljaTabela = Microsoft.VisualBasic.Split(spojiPoljaTabela, ",")
            Dim k As String = " 2=2 "
            For i As Integer = 0 To poljaTabela.GetUpperBound(0)
                If poljaTabela(i).Trim.ToUpper = "GOD" Then
                    k = k + " AND god='" + nvd + " + Me.TK_GOD.Text.Trim + " + nvd + "'" + ""
                ElseIf poljaTabela(i).Trim.ToUpper = "MES" Then
                    k = k + " AND mes='" + nvd + " + Me.TK_MES.Text.Trim + " + nvd + "'" + ""
                ElseIf poljaTabela(i).Trim.ToUpper = "ISTYEAR" Then
                    k = k + " AND ISTYEAR='" + nvd + " + Me.TK_ISTYEAR.Text.Trim + " + nvd + "'" + ""
                ElseIf poljaTabela(i).Trim.ToUpper = "ISTMONTH" Then
                    k = k + " AND ISTMONTH='" + nvd + " + Me.TK_ISTMONTH.Text.Trim + " + nvd + "'" + ""
                Else
                    Dim imewebPoljeAdresar As String = ""
                    If tkljucAdresar.IndexOf(",") > 0 Then
                        imewebPoljeAdresar = tkljucAdresar.Substring(0, tkljucAdresar.IndexOf(",")).Trim
                        tkljucAdresar = tkljucAdresar.Replace(imewebPoljeAdresar + ",", "")
                    Else
                        imewebPoljeAdresar = tkljucAdresar.Trim
                    End If
                    Dim imewebPoljeTabela As String = ""
                    Try
                        Dim dv1 As New System.Data.DataView(dISTPoljaKonsult)
                        dv1.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='" + poljaTabela(i).Trim() + "'"
                        dv1.Sort = "rbr ASC"
                        imewebPoljeTabela = dv1(0).Item("imeweb").ToString.Trim
                        k = k + " AND " + imewebPoljeAdresar + "='" + nvd + " + Me." + imewebPoljeTabela + ".Text.Trim+ " + nvd + "'" + ""
                    Catch ex As System.Exception
                        ''msg 120
                        Dim msgtxt As String = getMessageText(dtMessages, "120", Me.jezik) + nvrd
                        'Dim por As String = "Додела поља из адресара - није добро спајање адресара и табеле! "
                        ISTMessageBox.Show(msgtxt + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End Try
                End If
            Next

            strA = strA.Replace("99KLJUCADRESAR99", k)

            Dim dv2 As New System.Data.DataView(dISTPoljaKonsult)
            dv2.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')<>'P' "
            dv2.Sort = "rbr ASC"

            Dim dodelaAdresar As String = dISTDodelaIzAdresara.Rows(0).Item("dodelaAdresar")
            Dim dodela() As String = {}
            Dim fff() As String = {}
            Dim s As String = ""
            dodela = Microsoft.VisualBasic.Split(dodelaAdresar, ",")
            For i As Integer = 0 To dodela.GetUpperBound(0)
                fff = Microsoft.VisualBasic.Split(dodela(i), "=")
                'fff(0) - polje, fff(1) - poljeIzadresara
                For j As Integer = 0 To dv2.Count - 1
                    If dv2(j).Item("tipPolja").trim.toupper.substring(0, 1) = "T" AndAlso fff(0).Trim.ToUpper = dv2(j).Item("polje").trim.toupper Then
                        'textBox
                        s = s + "Me." + dv2(j).Item("imeweb").trim.toupper + ".text=dsA.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                    End If
                    If dv2(j).Item("tipPolja").trim.toupper.substring(0, 1) = "C" AndAlso fff(0).Trim.ToUpper = dv2(j).Item("polje").trim.toupper Then
                        'comboBox
                        ' ako je filterovan ide prvo popuni
                        Dim poljeUBazi As String = dv2(j).Item("polje").ToString.Trim
                        Dim poljeWeb As String = dv2(j).Item("imeWeb").ToString.Trim
                        Dim filtriranoPolje As String = dv2(j).Item("filtriranoPolje").ToString.Trim
                        Dim filtriranoPoPolju As String = dv2(j).Item("filtriranoPoPolju").ToString.Trim.Replace("d.", "")
                        Dim poljePoKomeSeFiltrira As String = ""

                        'ovo samo za CBW, NE ZA DDL i CBO
                        'ako je poljeWeb filterovano ide popuni prvo
                        If filtriranoPolje = 1 Then
                            Dim dv22 As New System.Data.DataView(dISTPoljaKonsult)
                            dv22.RowFilter = "tabela='" & tabela & "' and polje='" & filtriranoPoPolju & "'"
                            poljePoKomeSeFiltrira = CType(dv22.Item(0), System.Data.DataRowView).Row("imeWeb").ToString.Trim
                            s = s + "   popuni_" + poljeWeb + "(" + poljeWeb + "," + poljePoKomeSeFiltrira + ".Text" + ")" + nvrd
                        End If
                        s = s + "Me." + dv2(j).Item("imeweb").trim.toupper + ".text=dsA.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                    End If
                    If dv2(j).Item("tipPolja").trim.toupper.substring(0, 1) = "A" AndAlso fff(0).Trim.ToUpper = dv2(j).Item("polje").trim.toupper Then
                        Dim imewebL As String = dv2(j).Item("imeweb").trim.toupper.replace("_", "_LAZNIDDL")
                        Dim imeweb As String = dv2(j).Item("imeweb").trim.toupper
                        s = s + " Me." + imeweb + ".text=dsA.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                        s = s + " Dim trtDDD" + CStr(i).Trim + "  As String=dsA.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                        s = s + " If trtDDD" + CStr(i).Trim + " = " + nvd + nvd + " Then " + nvrd
                        s = s + "   Me." + imewebL + ".text=dsA.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                        s = s + " Else" + nvrd
                        s = s + "   Dim sql As String = " + nvd + nvd + "" + nvrd
                        s = s + "   Dim dsTrt As DataSet" + nvrd
                        s = s + "   Dim tag As String = Me." + imewebL + ".Attributes.Item(" + nvd + "Tag" + nvd + ").ToString.Trim" + nvrd

                        Dim sACE As String = ""
                        If brojACE > 0 Then
                            sACE = strACE.Replace("trtDDD", "trtDDD" + CStr(i).Trim)
                            sACE = sACE.Trim.ToUpper      'zamena GGGMMM u izrazu
                            sACE = ZameniGGGMMMSimple(sACE, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
                            sACE = Microsoft.VisualBasic.Replace(sACE, ".DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
                            sACE = Microsoft.VisualBasic.Replace(sACE, ".DBO.DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
                            s = s + sACE + nvrd
                        Else
                            s = s + nvrd
                        End If
                        s = s + "    dsTrt = b.DajDS_IzUpita(sql, Me.lblKonekcija.Text)" + nvrd
                        s = s + "    If dsTrt.Tables(0).Rows.Count > 0 Then" + nvrd
                        s = s + "      Me." + imewebL + ".text = dsTrt.Tables(0).Rows(0).Item(" + nvd + "prikazi" + nvd + ").ToString.Trim" + nvrd
                        s = s + "    Else" + nvrd
                        s = s + "      Me." + imewebL + ".text = " + nvd + nvd + "" + nvrd
                        s = s + "    End If" + nvrd
                        s = s + " End If" + nvrd
                    End If
                Next
            Next
            strA = strA.Replace("99DODELAPOLJAIZADRESARA99", s)
        Else
            'ako ne postoji dodela iz adresara
            strA = ""
            strA = strA + nvrd
            strA = strA + "Sub dodelaIzAdresara()" + nvrd
            strA = strA + "End Sub" + nvrd
            strA = strA + nvrd
        End If

        dajDodelaIzAdresara = strA
    End Function

    Function dajDodelaIzWebRelacije(ByVal brojACE As Integer, ByVal tabela As String, ByVal strACE As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dISTDodelaIzREL As New System.Data.DataTable
        Dim sqlDodelaIzREL As String = " select * from dbo.vISTLKRelacijaDodela ('" + vt + "','" + IzIst + "') where tabela='" & tabela & "'"
        dISTDodelaIzREL.Clear()

        dISTDodelaIzREL = izvrsiSQLvratiDT(sqlDodelaIzREL, ISTConnectionString, Nothing)

        Dim str As String = ""
        Dim sta As String = "tabela='" & tabela & "'"

        Dim txtR As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\dodelaIzWebRelacije.txt")
        Dim strR As String = txtR.ReadToEnd
        txtR.Close()

        Dim adresar As String = ""
        If dISTDodelaIzREL.Rows.Count > 0 Then
            'postoji dodela iz relacije
            strR = strR.Replace("99TABELA99", pravaBaza + ".dbo." + tabela)
            Dim kljucG As String = spremiWhereKljuc(tabela)
            strR = strR.Replace("99KLJUC99", kljucG)

            Dim relTabela As String = dISTDodelaIzREL.Rows(0).Item("adresarTabela").trim.toupper
            If relTabela.Trim.ToUpper.IndexOf("FROM") > 0 Then
                Dim ffrroomm As Integer = relTabela.Trim.ToUpper.IndexOf(" FROM ") + 6
                Dim prviBlank As Integer = relTabela.Substring(ffrroomm, relTabela.Length - relTabela.Trim.ToUpper.IndexOf(" FROM ") - 6 - 1).IndexOf(" ")
                If prviBlank < 0 Then
                    adresar = relTabela.Substring(ffrroomm, relTabela.Length - relTabela.Trim.ToUpper.IndexOf(" FROM ") - 6 - 1)
                Else
                    adresar = relTabela.Substring(ffrroomm, prviBlank)
                End If
                'upit
                '(select * from Adresar_SBS03 where kv=d.kv and god={GGG})
                'zamena GGG,MMM d. ... ako postoje
                relTabela = relTabela.Trim.ToUpper      'zamena GGGMMM u izrazu
                If relTabela.IndexOf("{GGG}") > 0 Then
                    relTabela = relTabela.Replace("{GGG}", "'" + nvd + "+ Me.TK_GOD.text +" + nvd + "'")
                    relTabela = relTabela.Replace("{MMM}", "'" + nvd + "+ Me.TK_MES.text +" + nvd + "'")
                    relTabela = relTabela.Replace("GGG", " god='" + nvd + "+ Me.TK_GOD.text +" + nvd + "'")
                    relTabela = relTabela.Replace("MMM", " mes='" + "+ Me.TK_MES.text +" + "'")
                End If

                If relTabela.IndexOf("{YYY}") > 0 Then
                    relTabela = relTabela.Replace("{YYY}", "'" + nvd + "+ Me.TK_ISTYEAR.text +" + nvd + "'")
                    relTabela = relTabela.Replace("{MMM}", "'" + nvd + "+ Me.TK_ISTMONTH.text +" + nvd + "'")
                    relTabela = relTabela.Replace("YYY", " ISTYEAR='" + nvd + "+ Me.TK_ISTYEAR.text +" + nvd + "'")
                    relTabela = relTabela.Replace("MMM", " ISTMONTH='" + "+ Me.TK_ISTMONTH.text +" + "'")
                End If
                relTabela = relTabela.Replace(Microsoft.VisualBasic.Strings.ChrW(26), "")
                Dim aaa = razkvantaj(relTabela)
                For i As Integer = 0 To aaa.length() - 1
                    If aaa(i).length() > 1 AndAlso aaa(i).substring(0, 2).toupper = "D." Then
                        Dim plj As String = aaa(i).Replace("D.", "").Trim.ToUpper
                        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
                        dv.RowFilter = "2=2 and TABELA='" + adresar.Trim +
                "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES' and POLJE <>'ISTYEAR' and POLJE<>'ISTMONTH'  and polje='" + plj + "'"
                        dv.Sort = "tabela ASC"
                        If dv.Count > 0 Then
                            aaa(i) = "'" + nvd + "+ Me." + dv(0).Item("imeWeb").ToString.Trim() + ".Text + " + nvd + "'"
                        Else
                            aaa(i) = aaa(i).Replace("D.", "").Trim.ToUpper
                        End If
                    End If
                Next
                relTabela = ustringaj(aaa).ToUpper()
                strR = strR.Replace("99RELTABELA99", relTabela)
            Else
                'obicna tabela
                strR = strR.Replace("99RELTABELA99", pravaBaza + ".dbo." + relTabela)
                adresar = relTabela
            End If

            Dim spojiPolja As String = dISTDodelaIzREL.Rows(0).Item("spojiPoljaTabela")
            Dim spojiPoljaAdresar() As String = {}
            Dim spojiPoljaTabela() As String = {}
            Dim pom() As String = {}
            pom = Microsoft.VisualBasic.Split(spojiPolja, "AND")
            For i As Integer = 0 To pom.GetUpperBound(0)
                Dim pom1() As String = {}
                pom1 = Microsoft.VisualBasic.Split(pom(i), "=")
                ReDim Preserve spojiPoljaTabela(i)
                ReDim Preserve spojiPoljaAdresar(i)
                spojiPoljaTabela(i) = pom1(0)
                spojiPoljaAdresar(i) = pom1(1)
            Next

            Dim tkljucAdresar As String = spremiWhereKljucWebRelacija(adresar, tabela, spojiPoljaAdresar, spojiPoljaTabela)
            strR = strR.Replace("99KLJUCREL99", tkljucAdresar)

            Dim dv2 As New System.Data.DataView(dISTPoljaKonsult)
            dv2.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')<>'P' "
            dv2.Sort = "rbr ASC"

            Dim dodelaRelacija As String = dISTDodelaIzREL.Rows(0).Item("dodelaAdresar").trim.toupper
            'sifopst=sifopst,terpod=terpod,rbr=rbr,del=del,nazivfirme=nazivfirme}
            dodelaRelacija = dodelaRelacija.Replace("}", "")
            Dim dodela() As String = {}
            Dim fff() As String = {}
            Dim s As String = ""
            dodela = Microsoft.VisualBasic.Split(dodelaRelacija, ",")
            For i As Integer = 0 To dodela.GetUpperBound(0)
                fff = Microsoft.VisualBasic.Split(dodela(i), "=")
                'fff(0) - polje iz tabele, fff(1) - polje iz relacije
                For j As Integer = 0 To dv2.Count - 1
                    If dv2(j).Item("tipPolja").trim.toupper.substring(0, 1) = "T" AndAlso fff(0).Trim.ToUpper = dv2(j).Item("polje").trim.toupper Then
                        'textBox
                        s = s + "Me." + dv2(j).Item("imeweb").trim.toupper + ".text=dsR.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                    End If
                    If dv2(j).Item("tipPolja").trim.toupper.substring(0, 1) = "C" AndAlso fff(0).Trim.ToUpper = dv2(j).Item("polje").trim.toupper Then
                        'comboBox
                        ' ako je filterovan ide prvo popuni
                        Dim poljeUBazi As String = dv2(j).Item("polje").ToString.Trim
                        Dim poljeWeb As String = dv2(j).Item("imeWeb").ToString.Trim
                        Dim filtriranoPolje As String = dv2(j).Item("filtriranoPolje").ToString.Trim
                        Dim filtriranoPoPolju As String = dv2(j).Item("filtriranoPoPolju").ToString.Trim.Replace("d.", "")
                        Dim poljePoKomeSeFiltrira As String = ""

                        'ovo samo za CBW, NE ZA DDL i CBO
                        'ako je poljeWeb filterovano ide popuni prvo
                        If filtriranoPolje = 1 Then
                            Dim dv22 As New System.Data.DataView(dISTPoljaKonsult)
                            dv22.RowFilter = "tabela='" & tabela & "' and polje='" & filtriranoPoPolju & "'"
                            poljePoKomeSeFiltrira = CType(dv22.Item(0), System.Data.DataRowView).Row("imeWeb").ToString.Trim
                            s = s + "   popuni_" + poljeWeb + "(" + poljeWeb + "," + poljePoKomeSeFiltrira + ".Text" + ")" + nvrd
                        End If
                        s = s + "Me." + dv2(j).Item("imeweb").trim.toupper + ".text=dsR.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                    End If
                    If dv2(j).Item("tipPolja").trim.toupper.substring(0, 1) = "A" AndAlso fff(0).Trim.ToUpper = dv2(j).Item("polje").trim.toupper Then
                        Dim imewebL As String = dv2(j).Item("imeweb").trim.toupper.replace("_", "_LAZNIDDL")
                        Dim imeweb As String = dv2(j).Item("imeweb").trim.toupper
                        s = s + " Me." + imeweb + ".text=dsR.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                        s = s + " Dim trtDDD" + CStr(i).Trim + "  As String=dsR.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                        s = s + " If trtDDD" + CStr(i).Trim + " = " + nvd + nvd + " Then " + nvrd
                        s = s + "   Me." + imewebL + ".text=dsR.Tables(0).Rows(0).Item(" + nvd + fff(1).Trim + nvd + ").ToString.Trim" + nvrd
                        s = s + " Else" + nvrd
                        s = s + "   Dim sql As String = " + nvd + nvd + "" + nvrd
                        s = s + "   Dim dsTrt As DataSet" + nvrd
                        s = s + "   Dim tag As String = Me." + imewebL + ".Attributes.Item(" + nvd + "Tag" + nvd + ").ToString.Trim" + nvrd

                        Dim sACE As String = ""
                        If brojACE > 0 Then
                            sACE = strACE.Replace("trtDDD", "trtDDD" + CStr(i).Trim)
                            sACE = sACE.Trim.ToUpper      'zamena GGGMMM u izrazu
                            sACE = ZameniGGGMMMSimple(sACE, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
                            sACE = Microsoft.VisualBasic.Replace(sACE, ".DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
                            sACE = Microsoft.VisualBasic.Replace(sACE, ".DBO.DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
                            s = s + sACE + nvrd
                        Else
                            s = s + nvrd
                        End If
                        s = s + "    dsTrt = b.DajDS_IzUpita(sql, Me.lblKonekcija.Text)" + nvrd
                        s = s + "    If dsTrt.Tables(0).Rows.Count > 0 Then" + nvrd
                        s = s + "      Me." + imewebL + ".text = dsTrt.Tables(0).Rows(0).Item(" + nvd + "prikazi" + nvd + ").ToString.Trim" + nvrd
                        s = s + "    Else" + nvrd
                        s = s + "      Me." + imewebL + ".text = " + nvd + nvd + "" + nvrd
                        s = s + "    End If" + nvrd
                        s = s + " End If" + nvrd
                    End If
                Next
            Next
            strR = strR.Replace("99DODELAPOLJAIZREL99", s)
        Else
            'ako ne postoji dodela iz adresara
            strR = ""
            strR = strR + nvrd
            strR = strR + "Sub dodelaIzWebRelacije()" + nvrd
            strR = strR + "End Sub" + nvrd
            strR = strR + nvrd
        End If

        dajDodelaIzWebRelacije = strR
    End Function

    Function dajIzlaz(ByVal nadtabela As String, ByVal tabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\izlazVB.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        If nadtabela = "" Then
            str = str.Replace("99RESPONSEREDIRECT99", "")
        Else
            Dim prelazaknG As String = spremiWhereKljucZaPrelazak(nadtabela)
            str = str.Replace("99RESPONSEREDIRECT99",
    "Response.Redirect(" + nvd + nadtabela + ".aspx?" + prelazaknG + "&imeD=" + tabela +
    "&ODS=" + nvd + " + odakle)")
        End If
        dajIzlaz = str
    End Function

    Function dajUSesiju(ByVal kljucG As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\USesijuVB.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        str = str.Replace("99KLJUCGLAVNA99", kljucG)
        str = str.Replace("99PRAVABAZA99", pravaBaza)
        dajUSesiju = str
    End Function

    Function dajPamtiD(ByVal vveza As String, ByVal tabela As String, ByVal poljeWeb As String, ByVal poljeTip As String, ByVal nadtabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pamtiD.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        str = str.Replace("99NADTABELA99", nadtabela)
        Dim prelazaknG As String = spremiWhereKljucZaPrelazak(nadtabela)
        str = str.Replace("99PRELAZAKnG99", prelazaknG)
        If vveza = "1N" Then 'veza 1-N
            If poljeTip.Substring(0, 1) = "A" Then
                str = str.Replace("99POLJE99", poljeWeb.Replace("_", "_LAZNIDDL"))
            Else
                str = str.Replace("99POLJE99", poljeWeb)
            End If
        Else           'vveza = "11"
            str = str.Replace("ME.99POLJE99.Focus()", "")
        End If
        dajPamtiD = str
    End Function

    Function dajPamtiG() As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pamtiG.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        dajPamtiG = str
    End Function

    Function dajPamtiGD() As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\pamtiGD.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        dajPamtiGD = str
    End Function

    Function dajPodTabela(ByVal podtabela As String, ByVal dtPolja As System.Data.DataTable, ByVal panel As Boolean, ByVal folder As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim putanja As String = ""
        If panel = False Then
            putanja = m_folderZaGen + "\WEB" + "\gridASPX.txt"
        Else
            putanja = m_folderZaGen + "\WEB" + "\panelgridASPX.txt"
        End If

        Dim txt As New System.IO.StreamReader(putanja)
        Dim str As String = txt.ReadToEnd
        txt.Close()
        str = str.Replace("99TABELA99", podtabela)

        Dim txtPNL As New System.IO.StreamReader(folder + "\" + podtabela + ".aspx")
        Dim pstr As String = txtPNL.ReadToEnd
        txtPNL.Close()
        podtabela = podtabela.Trim.ToUpper
        pstr = pstr.Replace("ID=" + nvd + "", "ID=" + nvd + "PNL" + podtabela)
        pstr = pstr.Replace("ID=" + nvd + "PNL" + podtabela + "PNL" + podtabela + nvd, "ID=" + nvd + "PNL" + podtabela + nvd)
        pstr = pstr.Replace("ControlToValidate=" + nvd + "", "ControlToValidate=" + nvd + "PNL" + podtabela)

        str = str.Replace("99PANELTABELA99", pstr)

        Dim txtkolona As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\koloneGrid.txt")
        Dim strkolona As String = txtkolona.ReadToEnd
        txtkolona.Close()
        Dim koloneGrid As String = ""
        If dtPolja.Rows.Count > 0 Then
            For i As Integer = 0 To dtPolja.Rows.Count - 1
                koloneGrid = koloneGrid + strkolona.Replace("99KOLONA99", dtPolja.Rows(i).Item("polje").ToString.Trim) + nvrd
            Next
            str = str.Replace("99KOLONEGRID99", koloneGrid)
        End If

        dajPodTabela = str
    End Function

    Function dajPageLoadG(ByVal brojCBO As Integer, ByVal tabela As String, ByVal imaGOD As Boolean, ByVal imaMES As Boolean, ByVal imaKV As String, ByVal funkcija As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\PageLoadG.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        Dim pop As String = ""
        str = str.Replace("99konekcija99", konekcija)
        Dim strDN As String = ""
        Dim strATR As String = ""
        Dim strFACE As String = ""

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and tabela='" + tabela + "' and TipPolja like 'A%'"
        dv.Sort = "rbr ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim imeWeb As String = dv(i).Item("imeWeb").ToString.Trim
            Dim filtriranoPolje As String = dv(i).Item("filtriranoPolje").ToString.Trim
            Dim filtriranoPoPolju As String = dv(i).Item("filtriranoPoPolju").ToString.Trim
            If filtriranoPoPolju.IndexOf("FP{") >= 0 Then
                'NE MOZE AKO JE FILTER PO FIKTIVNOM POLJU
            Else
                Dim imeLAZNIDDLWeb As String = dv(i).Item("imeWeb").ToString.Trim.Replace("_", "_LAZNIDDL")
                strDN = strDN + "Me." + imeWeb + ".Style.Add(" + nvd + "display" + nvd + ", " + nvd + "none" + nvd + ")" + nvrd
                If filtriranoPolje = "1" Then
                    strFACE = strFACE + dajAddAtrubutZaPonistavanje(tabela, filtriranoPoPolju.ToUpper, imeLAZNIDDLWeb.ToUpper) + nvrd
                End If
                strATR = strATR + imeLAZNIDDLWeb.ToUpper.Trim + ".Attributes.Add(" + nvd + "onBlur" + nvd + ", " _
        + nvd + "javascript:var x = document.getElementById('" + imeLAZNIDDLWeb.ToUpper.Trim + "').value.trim(); if (x.length==0) {document.getElementById('" + imeWeb.ToUpper.Trim + "').value='';} " + nvd + ")" + nvrd
            End If
        Next

        str = str.Replace("99DISPLAYNONE99", strDN)
        str = str.Replace("99ATRIBUTZALAZNIDDL99", strATR)

        If strFACE.Trim.Length > 0 Then
            str = str.Replace("99PONISTIFILTEROVANEACE99", strFACE)
        Else
            str = str.Replace("99PONISTIFILTEROVANEACE99", "")
        End If

        str = str.Replace("99poslednjePoljeKljuc99", poslednjePoljeKljuc)

        If prvoPoljeKojeNijeKljuc = "" OrElse prvoPoljeKojeNijeKljuc.Trim.ToUpper.Substring(0, 1) <> "T" Then
            str = str.Replace("99PRVOPOLJEKOJENIJEKLJUCONFOCUSSELECT99", "")
        Else 'textbox
            str = str.Replace("99PRVOPOLJEKOJENIJEKLJUCONFOCUSSELECT99", prvoPoljeKojeNijeKljuc + ".Attributes.Add(" + nvd + "onfocus" + nvd + ", " + nvd + "javascript:this.select();" + nvd + ")")
        End If

        'ako ima CBO onda
        If brojCBO > 0 Then
            str = str.Replace("99CALLZACBO99", "Call dsIzSesijeCBO()" + nvrd + "Call popuniCBO()" + nvrd)
        Else
            str = str.Replace("99CALLZACBO99", "")
        End If

        str = str.Replace("99VRTACKAIZSESIJE99", vrtackaIzSesije(tabela))
        str = str.Replace("99VRTACKAUSESIJU99", vrtackaUSesiju(tabela))

        Dim adresar As String = ""
        Dim dvA As New System.Data.DataView(dISTTABELEzaWEBizbor)
        dvA.RowFilter = "2=2 and Tabela='" + tabela.Trim + "'"
        If dvA.Count > 0 Then
            adresar = dvA(0).Item("orgadresartabela").ToString.Trim()
            str = str.Replace("99DISABLEKLJUCADRESAR99", disableKljucZaPoljaKojaSuIUAdresaru(tabela, adresar, imaGOD, imaMES, imaKV, funkcija))
        Else
            str = str.Replace("99DISABLEKLJUCADRESAR99", "")
        End If

        str = str.Replace("99PRENESIKLJUCGLAVNAADRESAR99", prenesiKljucAdresar(tabela, adresar, funkcija))

        str = str.Replace("99PRENESIKLJUCGLAVNA99", prenesiKljuc(tabela))
        str = str.Replace("99DISABLEKLJUC99", disableKljuc(tabela))

        str = str.Replace("99KLJUCIZPOCETNESESIJE99", prenesiKljucIzPocetneSesije(tabela))

        dajPageLoadG = str

    End Function

    Function prenesiKljucIzPocetneSesije(ByVal tabela As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and isnull(KLJUC,'')='P' and POLJE <>'GOD' and POLJE<>'MES'"
        dv.Sort = "tabela ASC"
        Dim str As String = ""
        For i As Integer = 0 To dv.Count - 1
            Dim poljeUBazi As String = dv(i).Item("polje").ToString.Trim
            Dim poljeWeb As String = dv(i).Item("imeWeb").ToString.Trim()
            str = str + "Me." + poljeWeb + ".Text= Session(" + nvd + poljeUBazi + nvd + ") " + nvrd
        Next
        prenesiKljucIzPocetneSesije = str
    End Function

    Function dajPageLoadGD(ByVal brojCBO As Integer, ByVal tabela As String, ByVal imagod As Boolean, ByVal imames As Boolean, ByVal imakv As String, ByVal funkcija As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\PageLoadGD.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        Dim pop As String = ""
        str = str.Replace("99konekcija99", konekcija)
        Dim strDN As String = ""
        Dim strATR As String = ""
        Dim strFACE As String = ""

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and tabela='" + tabela + "' and TipPolja like 'A%'"
        dv.Sort = "rbr ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim imeWeb As String = dv(i).Item("imeWeb").ToString.Trim
            Dim filtriranoPolje As String = dv(i).Item("filtriranoPolje").ToString.Trim
            Dim filtriranoPoPolju As String = dv(i).Item("filtriranoPoPolju").ToString.Trim
            Dim imeLAZNIDDLWeb As String = dv(i).Item("imeWeb").ToString.Trim.Replace("_", "_LAZNIDDL")
            strDN = strDN + "Me." + imeWeb + ".Style.Add(" + nvd + "display" + nvd + ", " + nvd + "none" + nvd + ")" + nvrd

            If filtriranoPolje = "1" Then
                strFACE = strFACE + dajAddAtrubutZaPonistavanje(tabela, filtriranoPoPolju.ToUpper, imeLAZNIDDLWeb.ToUpper) + nvrd
            End If

            strATR = strATR + imeLAZNIDDLWeb.ToUpper.Trim + ".Attributes.Add(" + nvd + "onBlur" + nvd + ", " _
    + nvd + "javascript:var x = document.getElementById('" + imeLAZNIDDLWeb.ToUpper.Trim + "').value.trim(); if (x.length==0) {document.getElementById('" + imeWeb.ToUpper.Trim + "').value='';} " + nvd + ")" + nvrd
        Next
        str = str.Replace("99DISPLAYNONE99", strDN)
        str = str.Replace("99ATRIBUTZALAZNIDDL99", strATR)

        If strFACE.Trim.Length > 0 Then
            str = str.Replace("99PONISTIFILTEROVANEACE99", strFACE)
        Else
            str = str.Replace("99PONISTIFILTEROVANEACE99", "")
        End If

        str = str.Replace("99poslednjePoljeKljuc99", poslednjePoljeKljuc)

        If prvoPoljeKojeNijeKljuc = "" OrElse prvoPoljeKojeNijeKljuc.Trim.ToUpper.Substring(0, 1) <> "T" Then
            str = str.Replace("99PRVOPOLJEKOJENIJEKLJUCONFOCUSSELECT99", "")
        Else 'textbox
            str = str.Replace("99PRVOPOLJEKOJENIJEKLJUCONFOCUSSELECT99", prvoPoljeKojeNijeKljuc + ".Attributes.Add(" + nvd + "onfocus" + nvd + ", " + nvd + "javascript:this.select();" + nvd + ")")
        End If

        'ako ima CBO onda
        If brojCBO > 0 Then
            str = str.Replace("99CALLZACBO99", "Call dsIzSesijeCBO()" + nvrd + "Call popuniCBO()" + nvrd)
        Else
            str = str.Replace("99CALLZACBO99", "")
        End If

        str = str.Replace("99VRTACKAIZSESIJE99", vrtackaIzSesije(tabela))
        str = str.Replace("99VRTACKAUSESIJU99", vrtackaUSesiju(tabela))

        Dim adresar As String = ""
        Dim dvA As New System.Data.DataView(dISTTABELEzaWEBizbor)
        dvA.RowFilter = "2=2 and Tabela='" + tabela.Trim + "'"
        If dvA.Count > 0 Then
            adresar = dvA(0).Item("orgadresartabela").ToString.Trim()
            str = str.Replace("99DISABLEKLJUCADRESAR99", disableKljucZaPoljaKojaSuIUAdresaru(tabela, adresar, imagod, imames, imakv, funkcija))
        Else
            str = str.Replace("99DISABLEKLJUCADRESAR99", "")
        End If
        str = str.Replace("99PRENESIKLJUCGLAVNAADRESAR99", prenesiKljucAdresar(tabela, adresar, funkcija))

        str = str.Replace("99PRENESIKLJUCGLAVNA99", prenesiKljuc(tabela))
        str = str.Replace("99DISABLEKLJUC99", disableKljuc(tabela))

        str = str.Replace("99KLJUCIZPOCETNESESIJE99", prenesiKljucIzPocetneSesije(tabela))

        dajPageLoadGD = str

    End Function

    Function dajPageLoadD(ByVal brojCBO As Integer, ByVal vveza As String, ByVal tabela As String, ByVal poljeBaza As String, ByVal poljeWeb As String, ByVal poljeTip As String, ByVal nadtabela As String, ByVal pk As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\PageLoadD.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        Dim pop As String = ""
        str = str.Replace("99konekcija99", konekcija)
        Dim strDN As String = ""
        Dim strATR As String = ""
        Dim strFACE As String = ""

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and tabela='" + tabela + "' and TipPolja like 'A%'"
        dv.Sort = "rbr ASC"

        For i As Integer = 0 To dv.Count - 1
            Dim imeWeb As String = dv(i).Item("imeWeb").ToString.Trim
            Dim imeBaza As String = dv(i).Item("polje").ToString.Trim
            Dim filtriranoPolje As String = dv(i).Item("filtriranoPolje").ToString.Trim
            Dim filtriranoPoPolju As String = dv(i).Item("filtriranoPoPolju").ToString.Trim
            Dim imeLAZNIDDLWeb As String = dv(i).Item("imeWeb").ToString.Trim.Replace("_", "_LAZNIDDL")
            strDN = strDN + "Me." + imeWeb + ".Style.Add(" + nvd + "display" + nvd + ", " + nvd + "none" + nvd + ")" + nvrd
            If filtriranoPolje = "1" Then
                strFACE = strFACE + dajAddAtrubutZaPonistavanje(tabela, filtriranoPoPolju.ToUpper, imeLAZNIDDLWeb.ToUpper) + nvrd
            End If
            strATR = strATR + imeLAZNIDDLWeb.ToUpper.Trim + ".Attributes.Add(" + nvd + "onBlur" + nvd + ", " _
    + nvd + "javascript:var x = document.getElementById('" + imeLAZNIDDLWeb.ToUpper.Trim + "').value.trim(); if (x.length==0) {document.getElementById('" + imeWeb.ToUpper.Trim + "').value='';} " + nvd + ")" + nvrd

        Next
        str = str.Replace("99DISPLAYNONE99", strDN)
        str = str.Replace("99ATRIBUTZALAZNIDDL99", strATR)

        If strFACE.Trim.Length > 0 Then
            str = str.Replace("99PONISTIFILTEROVANEACE99", strFACE)
        Else
            str = str.Replace("99PONISTIFILTEROVANEACE99", "")
        End If

        str = str.Replace("99poslednjePoljeKljuc99", poslednjePoljeKljuc)

        If prvoPoljeKojeNijeKljuc = "" OrElse prvoPoljeKojeNijeKljuc.Trim.ToUpper.Substring(0, 1) <> "T" Then
            str = str.Replace("99PRVOPOLJEKOJENIJEKLJUCONFOCUSSELECT99", "")
        Else 'textbox
            str = str.Replace("99PRVOPOLJEKOJENIJEKLJUCONFOCUSSELECT99", prvoPoljeKojeNijeKljuc + ".Attributes.Add(" + nvd + "onfocus" + nvd + ", " + nvd + "javascript:this.select();" + nvd + ")")
        End If

        'ako ima CBO onda
        If brojCBO > 0 Then
            str = str.Replace("99CALLZACBO99", "Call dsIzSesijeCBO()" + nvrd + "Call popuniCBO()" + nvrd)
        Else
            str = str.Replace("99CALLZACBO99", "")
        End If

        str = str.Replace("99PRENESIKLJUCGLAVNA99", prenesiKljuc(nadtabela))

        Dim strVeza As String = ""
        If vveza = "11" Then  'veza je 1-1
            strVeza = strVeza + "Call prikazi()" + nvrd
            strVeza = strVeza + "Call disablePoljaKLJUC()" + nvrd
        Else   'vveza.Trim = "1N"
            Dim txtVeza As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\veza1N.txt")
            strVeza = txtVeza.ReadToEnd
            txtVeza.Close()

            strVeza = strVeza.Replace("99DDKPOLJE99", poljeBaza)
            strVeza = strVeza.Replace("99OSTATAKKLJUCA99", pk)

            Dim poljeWebLazni As String = ""
            If poljeTip.Substring(0, 1) = "A" Then
                poljeWebLazni = poljeWeb.Replace("_", "_LAZNIDDL")
            End If

            'za FOCUS
            If poljeTip.Substring(0, 1) = "A" Then
                strVeza = strVeza.Replace("99POLJE99", poljeWebLazni)
            Else
                strVeza = strVeza.Replace("99POLJE99", poljeWeb)
            End If
        End If

        str = str.Replace("99VEZA99", strVeza)
        str = str.Replace("99DISABLEKLJUC99", disableKljuc(tabela))
        str = str.Replace("99DISABLEKLJUCNADTABELA99", disableKljuc(nadtabela))
        str = str.Replace("99VRTACKAIZSESIJE99", vrtackaIzSesije(tabela))
        str = str.Replace("99VRTACKAUSESIJU99", vrtackaUSesiju(tabela))
        dajPageLoadD = str

    End Function

    Function dajZaAceFilter(ByVal tabela As String, ByVal polje As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ponistiVB.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        Dim strPOM As String = ""

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and tabela='" + tabela + "' and polje='" + polje + "'"

        If Not dv(0).Item("cboubazu").ToString.Trim Is Nothing AndAlso dv(0).Item("cboubazu").ToString.Trim <> "" Then
            str = dv(0).Item("cboubazu").ToString.Trim
        Else
            str = dv(0).Item("polje").ToString.Trim
        End If
        dajZaAceFilter = str

    End Function

    Function dajAddAtrubutZaPonistavanje(ByVal tabela As String, ByVal opstina As String, ByVal naselje As String) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim str As String = ""
        Dim tip As String = ""
        Dim imeWeb As String = ""

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "2=2 and tabela='" + tabela + "' and polje='" + opstina + "'"

        imeWeb = dv(0).Item("imeWeb").ToString.Trim.ToUpper
        tip = dv(0).Item("tipPolja").ToString.Trim.ToUpper
        If tip.Substring(0, 1) = "A" Then
            str = "Me." + imeWeb.Replace("_", "_LAZNIDDL") + ".Attributes.Add(" + nvd + "onChange" + nvd + ", " + nvd + "document.getElementById('" + naselje + "').value='';" + nvd + ")"
        ElseIf tip.Substring(0, 1) = "T" Then
            str = "Me." + imeWeb + ".Attributes.Add(" + nvd + "onChange" + nvd + ", " + nvd + "document.getElementById('" + naselje + "').value='';" + nvd + ")"
        End If

        dajAddAtrubutZaPonistavanje = str

    End Function

    Function dajACEMetodDDL(ByVal filter As Boolean, ByVal sql As String, ByVal prikazi As String, ByVal imefunkcije As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACEMetodDDL.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()

        If filter = True Then
            str = str.Replace("99CONTEXTKEY99", ", ByVal contextKey As String")
        Else
            str = str.Replace("99CONTEXTKEY99", "")
        End If

        str = str.Replace("99IMEFUNKCIJE99", imefunkcije)
        str = str.Replace("99KONEKCIJA99", konekcija)
        str = str.Replace("99PRIKAZI99", prikazi)

        'zamena GGGMMM u izrazu
        sql = ZameniGGGMMMSimple(sql, Me.mvt.G, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
        sql = Replace(sql, ".DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)
        sql = Replace(sql, ".DBO.DBO.", ".DBO.", 1, , Microsoft.VisualBasic.CompareMethod.Text)

        str = str.Replace("99SQL99", sql)

        dajACEMetodDDL = str

    End Function

    'Function dajACEMetod(ByVal prikazi As String, ByVal ubazu As String, ByVal odakle As String, ByVal imefunkcije As String) As String
    '    Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
    '    Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
    '    Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACEMetod.txt")
    '    Dim str As String = txt.ReadToEnd
    '    txt.Close()

    '    str = str.Replace("99IMEFUNKCIJE99", imefunkcije)
    '    str = str.Replace("99KONEKCIJA99", konekcija)
    '    str = str.Replace("99PRIKAZI99", prikazi)

    '    Dim sql As String = ""
    '    sql = "select distinct TOP 20 " + ubazu + " as polje, " + prikazi + " as naziv from " + odakle + " where 2=2 AND "
    '    str = str.Replace("99SQL99", sql)
    '    dajACEMetod = str

    'End Function

    Function dajACEGet(ByVal tag As String, ByVal tabela As String, ByVal uBazu As String, ByVal prikazi As String, ByVal baza As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACEGet.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        Dim odakle As String = baza + ".dbo." + tabela

        If odakle.Trim.ToUpper.IndexOf("WHERE") >= 0 Then
        Else
            odakle = odakle + " where 2=2 "
        End If

        str = str.Replace("99SMTAG99", tag.Trim.ToUpper)
        str = str.Replace("99PRIKAZI99", prikazi)
        str = str.Replace("99UBAZU99", uBazu)
        str = str.Replace("99ODAKLE99", odakle)
        dajACEGet = str

    End Function

    Function dajACEplD(ByVal imeWeb As String, ByVal tabela As String, ByVal uBazu As String, ByVal prikazi As String, ByVal baza As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACEplD.txt")
        Dim str As String = txt.ReadToEnd
        txt.Close()
        Dim odakle As String = baza + ".dbo." + tabela
        str = str.Replace("99IMEWEB99", imeWeb)
        str = str.Replace("99LAZNIDDLIMEWEB99", imeWeb.Replace("_", "_LAZNIDDL"))
        str = str.Replace("99PRIKAZI99", prikazi)
        str = str.Replace("99UBAZU99", uBazu)
        str = str.Replace("99ODAKLE99", odakle)
        dajACEplD = str

    End Function

    Function dajACEJS(ByVal lazni As String, ByVal polje As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACEJS.txt")
        Dim str As String = txt.ReadToEnd
        str = str.Replace("99poljeLAZNIDDL99", lazni.Trim.ToUpper)
        str = str.Replace("99POLJE", polje.Trim.ToUpper)
        dajACEJS = str
        txt.Close()
    End Function

    Function dajPonisti(ByVal DG As String, ByVal tabela As String, ByVal nadtabela As String, ByVal strGV As String) As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim txt As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ponistiVB.txt")
        Dim str As String = txt.ReadToEnd
        Dim sql As String = ""
        Dim dt As New System.Data.DataTable
        Dim strPOM As String = ""

        If DG = "G" Then
            'sql = " select * from dbo.vISTPoljaKonsultTabela ('" + vt + "','" + IzIst + "','" + tabela + "') where TipPolja like 'A%' order by rbr"
            'dt = izvrsiSQLvratiDT(sql, ISTConnectionString, Me.jezik)
            dt.Clear()
            dt = fdtusp_vISTPoljaKonsultTabela(vt, IzIst, tabela, "TipPolja like ''A%'' order by rbr")
        Else
            'za D ponistavamo samo ono sto je deo kljuca u dupetu, a ne i glavi
            dt = poljaKljucKojaNePostoje2(tabela, nadtabela)
        End If

        Dim imeLAZNIDDLWeb As String
        Dim imeWeb As String
        For i As Integer = 0 To dt.Rows.Count - 1
            imeWeb = dt.Rows(i).Item("imeWeb").ToString.Trim
            strPOM = strPOM + "Me." + imeWeb + ".Text=" + nvd + nvd + nvrd
            If dt.Rows(i).Item("tippolja").ToString.Trim.Substring(0, 1) = "A" Then
                imeLAZNIDDLWeb = imeWeb.Replace("_", "_LAZNIDDL")
                strPOM = strPOM + "Me." + imeLAZNIDDLWeb + ".Text=" + nvd + nvd + nvrd
            End If
        Next
        'ako nema gridova strGridVisible=""
        If strGV.Trim <> "" Then
            strGV = strGV.Replace("XXX", "False")
            strPOM = strPOM + nvrd + strGV + nvrd
        End If
        'strGridVisible
        str = str.Replace("99PONISTILAZNIDDL99", strPOM)

        dajPonisti = str
        txt.Close()
    End Function

    Public Function sbIndexOf(ByVal sb As System.Text.StringBuilder, ByVal s As String) As Integer
        For i As Integer = 0 To sb.Length - s.Length - 1
            For y As Integer = 0 To s.Length - 1
                If s.Substring(y, 1) <> sb(i + y) Then
                    Exit For
                ElseIf y = s.Length - 1 Then
                    Return i
                End If
            Next
        Next
        Return -1
    End Function

    Sub spremiVB(ByVal polje As String, ByVal nnizneV() As String, ByVal nnizdaV() As String)

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        sbVBpom.Append(nvrd)
        sbVBpom.Append("Sub s_vrednosti_DaNe_" & polje.Trim & "(ByVal source As Object, ByVal args As ServerValidateEventArgs)")
        sbVBpom.Append(nvrd)
        sbVBpom.Append("          Try")
        sbVBpom.Append(nvrd)
        sbVBpom.Append("                    Dim trt As String = Integer.Parse(args.Value)")
        sbVBpom.Append(nvrd)
        If funkcijaNe = True Then
            sbVBpom.Append("                    If (")
            For i As Integer = 0 To nnizneV.GetUpperBound(0) - 1
                sbVBpom.Append("trt=" & nvd & nnizneV(i) & nvd & " OR ")
            Next
            sbVBpom.Append("trt=" & nvd & nnizneV(nnizneV.GetUpperBound(0)) & nvd)
            sbVBpom.Append(") then ")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                              args.IsValid = False")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                    Else")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                              args.IsValid = True")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                    End If")
            sbVBpom.Append(nvrd)
        End If

        If funkcijaDa = True Then
            sbVBpom.Append("                    If (")
            For i As Integer = 0 To nnizdaV.GetUpperBound(0) - 1
                sbVBpom.Append("trt=" & nvd & nnizdaV(i) & nvd & " OR ")
            Next
            sbVBpom.Append("trt=" & nvd & nnizdaV(nnizdaV.GetUpperBound(0)) & nvd)
            sbVBpom.Append(") then ")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                                        args.IsValid = True")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                    Else")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                                        args.IsValid = False")
            sbVBpom.Append(nvrd)
            sbVBpom.Append("                    End If")
            sbVBpom.Append(nvrd)
        End If

        sbVBpom.Append("          Catch ex As Exception")
        sbVBpom.Append(nvrd)
        sbVBpom.Append("                    args.IsValid = False")
        sbVBpom.Append(nvrd)
        sbVBpom.Append("          End Try")
        sbVBpom.Append(nvrd)
        sbVBpom.Append("End Sub")
        sbVBpom.Append(nvrd)
    End Sub

    Sub spremiJS(ByVal polje As String, ByVal nnizneV() As String, ByVal nnizdaV() As String)

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        sbJS.Append(nvrd)
        'sbJS.Append("<script type=" & nvd & "text/javascript" & nvd & ">")
        'sbJS.Append(nvrd)
        sbJS.Append("function c_vrednosti_DaNe_" & polje.Trim & "(oSrc, args) {")
        sbJS.Append(nvrd)

        If funkcijaNe = True Then
            sbJS.Append("args.IsValid = true;")
            sbJS.Append(nvrd)
            For i As Integer = 0 To nnizneV.GetUpperBound(0)
                sbJS.Append("if (args.Value == " & nnizneV(i) & ") {args.IsValid = false;}")
                sbJS.Append(nvrd)
            Next
        End If
        If funkcijaDa = True Then
            sbJS.Append("args.IsValid = false;")
            sbJS.Append(nvrd)
            For i As Integer = 0 To nnizdaV.GetUpperBound(0)
                sbJS.Append("if (args.Value == " & nnizdaV(i) & ") {args.IsValid = true;}")
                sbJS.Append(nvrd)
            Next
        End If
        sbJS.Append("}")
        sbJS.Append(nvrd)
        'sbJS.Append("</script>")
        'sbJS.Append(nvrd)

    End Sub

    Sub ZaProveru(ByVal pomOD As String, ByVal polje As String, ByVal tip As String, ByVal duzina As String)

        RangeV = False 'Range Validator
        RegExV = False 'Regular Expression Validator  za min duzinu
        RequiredF = False 'Required Field Validator  za min duzinu
        CustomV = False 'Custom  Validator

        funkcijaDa = False
        funkcijaNe = False
        funkcijaCBODodela = False
        funkcijaSkoci = False
        funkcijaSamoCita = False

        Dim nizProvera() As String = {}
        Dim daV As String = ""
        Dim nizdaV() As String = {}
        Dim neV As String = ""
        Dim nizneV() As String = {}
        'Dim obaveznaV As String = ""
        'Dim nizobaveznaV() As String = {}

        Dim skociNA As String = ""
        Dim skociAKO As String = ""

        'Dim porukaJe As String = ""
        'Dim nizporukaJE() As String = {}
        'Dim porukaAKO As String = ""
        'Dim nizporukaAKO() As String = {}
        ''readOnly
        Dim samoCita As String = ""
        Dim samoCitaAKO As String = ""

        Dim dodeliKome As String = ""
        Dim dodeliSta As String = ""
        Dim dodeliAko As String = ""

        minL = ""
        minV = ""
        maxV = ""
        tipRV = "Integer"

        ReDim nizdodeliKome(-1)
        ReDim nizdodeliSta(-1)
        ReDim nizdodeliAko(-1)
        ReDim nizskociNA(-1)
        ReDim nizskociAKO(-1)
        ReDim nizsamoCita(-1)
        ReDim nizsamoCitaAKO(-1)

        Dim tt As String
        Dim pt As String = ""
        tt = CStr(tip).ToUpper.Trim
        If tt <> "" Then
            If tt = "INT" Or tt = "INTEGER" Or tt = "SMALLINT" Or tt = "TINYINT" Or
                                        tt = "BIG" Or tt = "BIGINT" Then
                pt = "I"
                dozvoljeno = "0123456789"
                minV = 0
                tipRV = "Integer"
            ElseIf tt = "BOOLEAN" Then
                pt = "B"
                dozvoljeno = "01"
            ElseIf tt = "FLOAT" Or tt = "REAL" Or tt = "DECIMAL" Then
                pt = "D"
                dozvoljeno = "0123456789."
                minV = 0
                tipRV = "Double"
            Else
                pt = "CT"
                dozvoljeno = ""
            End If
        Else
            pt = "CT" 'char,text,....
            dozvoljeno = ""
        End If

        If CStr(duzina).ToUpper.Trim <> "" Then
            maxL = CStr(duzina).Trim
        Else
            maxL = "0"
        End If

        If tt = "BOOLEAN" Then
            maxL = "1"
        End If

        If pomOD.Length > 0 AndAlso pomOD.Trim.IndexOf("#{") = 0 Then
            pomOD = pomOD.Replace("#{", "")
            pomOD = pomOD.Replace("}", "")
            pomOD = pomOD.Replace(Microsoft.VisualBasic.vbCrLf, "")

            nizProvera = Microsoft.VisualBasic.Split(pomOD, ";")
            For i As Integer = 0 To nizProvera.GetUpperBound(0)

                If nizProvera(i).IndexOf("MIN=") >= 0 Then
                    minV = nizProvera(i).Replace("MIN=", "")
                    RangeV = True
                End If
                If nizProvera(i).IndexOf("MAX=") >= 0 Then
                    maxV = nizProvera(i).Replace("MAX=", "")
                    RangeV = True
                End If

                If nizProvera(i).IndexOf("MNDUZINA=") >= 0 Then
                    minL = nizProvera(i).Replace("MNDUZINA=", "")
                    RegExV = True
                End If
                If nizProvera(i).IndexOf("MXDUZINA=") >= 0 Then
                    maxL = nizProvera(i).Replace("MXDUZINA=", "")
                End If
                If nizProvera(i).IndexOf("DA=") >= 0 Then
                    daV = nizProvera(i).Replace("DA=", "")
                    nizdaV = Microsoft.VisualBasic.Split(daV, ",")
                    For k As Integer = 0 To nizdaV.GetUpperBound(0)
                        If nizdaV(k).Trim.ToUpper = "NUMERIC" Then
                            If pt = "I" Then dozvoljeno = "0123456789"
                            If pt = "D" Then dozvoljeno = "0123456789."
                            If pt = "B" Then dozvoljeno = "01"
                            If pt = "CT" Then dozvoljeno = "0123456789"
                        ElseIf nizdaV(k).Trim.ToUpper = "INTEGER" Then
                            dozvoljeno = "0123456789"
                        ElseIf nizdaV(k).Trim.ToUpper = "ALPHA" Then
                            dozvoljeno = "ALPHA"
                        ElseIf nizdaV(k).Trim.ToUpper = "ALPHANUMERIC" Then
                            dozvoljeno = ""   'sve sem /
                        End If
                    Next
                    Dim j As Integer = -1
                    ReDim Preserve nnizdaV(j)
                    For k As Integer = 0 To nizdaV.GetUpperBound(0)
                        If nizdaV(k).Trim <> "" AndAlso nizdaV(k) <> "NUMERIC" AndAlso
                    nizdaV(k) <> "ALPHA" AndAlso nizdaV(k) <> "ALPHANUMERIC" Then
                            j = j + 1
                            ReDim Preserve nnizdaV(j)
                            nnizdaV(j) = nizdaV(k).Trim
                        End If
                    Next
                    If j >= 0 Then
                        funkcijaDa = True
                        CustomV = True
                    End If

                End If
                If nizProvera(i).IndexOf("NE=") >= 0 Then
                    neV = nizProvera(i).Replace("NE=", "")
                    nizneV = Microsoft.VisualBasic.Split(neV, ",")

                    Dim j As Integer = -1
                    ReDim Preserve nnizneV(j)
                    For k As Integer = 0 To nizneV.GetUpperBound(0)
                        If nizneV(k).Trim = "" Then
                            RequiredF = True
                        Else
                            j = j + 1
                            ReDim Preserve nnizneV(j)
                            nnizneV(j) = nizneV(k).Trim
                        End If
                    Next
                    If j >= 0 Then
                        funkcijaNe = True
                        CustomV = True
                    End If
                End If
                'If nizProvera(i).IndexOf("OBAVEZNOAKO=") >= 0 Then obaveznaV = nizProvera(i).Replace("OBAVEZNOAKO=", "")

                If nizProvera(i).IndexOf("DODELIKOME=") >= 0 Then
                    dodeliKome = nizProvera(i).Replace("DODELIKOME=", "")
                    nizdodeliKome = Microsoft.VisualBasic.Split(dodeliKome, "$")
                    funkcijaCBODodela = True
                End If
                If nizProvera(i).IndexOf("DODELISTA=") >= 0 Then
                    dodeliSta = nizProvera(i).Replace("DODELISTA=", "")
                    nizdodeliSta = Microsoft.VisualBasic.Split(dodeliSta, "$")
                End If
                If nizProvera(i).IndexOf("DODELIAKO=") >= 0 Then
                    dodeliAko = (nizProvera(i).Replace("DODELIAKO=", ""))
                    nizdodeliAko = Microsoft.VisualBasic.Split(dodeliAko, "$")
                End If

                If nizProvera(i).IndexOf("SKOCINA=") >= 0 Then
                    skociNA = nizProvera(i).Replace("SKOCINA=", "")
                    nizskociNA = Microsoft.VisualBasic.Split(skociNA, "$")
                    funkcijaSkoci = True
                End If
                If nizProvera(i).IndexOf("SKOCIAKO=") >= 0 Then
                    skociAKO = nizProvera(i).Replace("SKOCIAKO=", "")
                    nizskociAKO = Microsoft.VisualBasic.Split(skociAKO, "$")
                End If
                If nizProvera(i).IndexOf("READONLY=") >= 0 Then
                    samoCita = nizProvera(i).Replace("READONLY=", "")
                    nizsamoCita = Microsoft.VisualBasic.Split(samoCita, "$")
                    funkcijaSamoCita = True
                End If
                If nizProvera(i).IndexOf("READONLYAKO=") >= 0 Then
                    samoCitaAKO = (nizProvera(i).Replace("READONLYAKO=", ""))
                    nizsamoCitaAKO = Microsoft.VisualBasic.Split(samoCitaAKO, "$")
                End If

            Next
            'overRide ? da li za MBR isto to?
            If CStr(polje).ToUpper.Trim = "GOD" OrElse CStr(polje).ToUpper.Trim = "ISTYEAR" Then
                dozvoljeno = "0123456789"
                maxL = "4"
            ElseIf CStr(polje).ToUpper.Trim = "MES" OrElse CStr(polje).ToUpper.Trim = "ISTMONTH" Then
                dozvoljeno = "0123456789"
                maxL = "2"
            End If
        Else
        End If

    End Sub

    Public Function isAlphaNumeric(ByVal tekst As String) As Boolean

        Dim strCompare As String
        Dim strInput As String
        isAlphaNumeric = False
        If tekst.Trim.Length = 0 Then
            isAlphaNumeric = True
        Else
            For i As Integer = 1 To tekst.Trim.Length
                strCompare = Microsoft.VisualBasic.Strings.Mid(tekst, i, 1)
                strInput = Microsoft.VisualBasic.Strings.Mid(tekst, i + 1, tekst.Trim.Length)
                If strCompare Like ("[A-Z]") Or strCompare Like ("[a-z]") Or strCompare Like ("#") Or strCompare Like ("-") Then
                    isAlphaNumeric = True
                Else
                    isAlphaNumeric = False
                    Exit Function
                End If
            Next i
        End If
    End Function

    Public Function jisNumeric(ByVal tekst As String) As Boolean

        jisNumeric = False
        If tekst.Trim.Length = 0 Then
            jisNumeric = True
        Else
            If Microsoft.VisualBasic.IsNumeric(tekst) Then jisNumeric = True
        End If
    End Function

    Function popuniDDL(ByVal imepolja As String, ByVal dsIme As String, ByVal upisujese As String, ByVal vidise As String) As String
        Dim txtpopuni As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\popuniDDL.txt")
        Dim strpopuni As String = txtpopuni.ReadToEnd
        strpopuni = strpopuni.Replace("99imepolja99", imepolja)
        strpopuni = strpopuni.Replace("99dsIzSesije99", dsIme)
        strpopuni = strpopuni.Replace("99upisujese99", upisujese)
        strpopuni = strpopuni.Replace("99vidise99", vidise)
        popuniDDL = strpopuni
        txtpopuni.Close()
    End Function
    Function popuniFiltriraniCBO(ByVal imepolja As String, ByVal dsIme As String, ByVal poljeFilter As String, ByVal upisujese As String, ByVal vidise As String) As String
        Dim txtpopuni As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\popuniFiltriraniCBO.txt")
        Dim strpopuni As String = txtpopuni.ReadToEnd
        strpopuni = strpopuni.Replace("99imepolja99", imepolja)
        strpopuni = strpopuni.Replace("99poljeFilter99", poljeFilter)
        strpopuni = strpopuni.Replace("99dsIzSesije99", dsIme)
        strpopuni = strpopuni.Replace("99upisujese99", upisujese)
        strpopuni = strpopuni.Replace("99vidise99", vidise)
        popuniFiltriraniCBO = strpopuni
        txtpopuni.Close()
    End Function

    Function dajFiltriraniCBOTextChanged(ByVal tabela As String, ByVal KojiSeFiltrira As String, ByVal PoKomeSeFiltrira As String, ByVal sledecePolje As String) As String
        Dim txtpopuni As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\FiltriraniCBOTextChanged.txt")
        Dim strpopuni As String = txtpopuni.ReadToEnd

        Dim trt As String = ""
        Dim trtUslov As String = ""

        If RangeV = True Then
            trt = trt & "RV_" & PoKomeSeFiltrira & ".Validate() : "
            trtUslov = trtUslov & "RV_" & PoKomeSeFiltrira & ".IsValid AndAlso "
        End If
        If RegExV = True Then
            trt = trt & "REV_" & PoKomeSeFiltrira & ".Validate() : "
            trtUslov = trtUslov & "REV_" & PoKomeSeFiltrira & ".IsValid AndAlso "
        End If
        If CustomV = True Then
            trt = trt & "CV_" & PoKomeSeFiltrira & ".Validate() : "
            trtUslov = trtUslov & "CV_" & PoKomeSeFiltrira & ".IsValid AndAlso "
        End If
        If RequiredF = True Then
            trt = trt & "RFV_" & PoKomeSeFiltrira & ".Validate()  "
            trtUslov = trtUslov & "RFV_" & PoKomeSeFiltrira & ".IsValid "
        End If
        strpopuni = strpopuni.Replace("99validatori99", trt)
        strpopuni = strpopuni.Replace("99uslovValidatori99", trtUslov)
        strpopuni = strpopuni.Replace("99KojiSeFiltrira99", KojiSeFiltrira)
        strpopuni = strpopuni.Replace("99PoKomeSeFiltrira99", PoKomeSeFiltrira)
        strpopuni = strpopuni.Replace("99sledecePolje99", sledecePolje)

        Dim dv As New System.Data.DataView(dISTPoljaKonsult)
        dv.RowFilter = "tabela='" & tabela & "' and polje='" & PoKomeSeFiltrira.Substring(3) & "'"

        Dim pomOD As String = ""
        If Not (CType(dv.Item(0), System.Data.DataRowView).Row("OD").GetType Is GetType(System.DBNull)) Then pomOD = CType(dv.Item(0), System.Data.DataRowView).Row("OD").Trim.toupper
        Dim pomTip As String = ""
        If Not (CType(dv.Item(0), System.Data.DataRowView).Row("tip").GetType Is GetType(System.DBNull)) Then pomTip = CType(dv.Item(0), System.Data.DataRowView).Row("tip").Trim.toupper
        Dim pomDuzina As String = ""
        If Not (CType(dv.Item(0), System.Data.DataRowView).Row("duzina").GetType Is GetType(System.DBNull)) Then pomDuzina = CType(dv.Item(0), System.Data.DataRowView).Row("duzina").Trim.toupper
        Call ZaProveru(pomOD, PoKomeSeFiltrira, pomTip, pomDuzina)

        'nizdodeliSta, nizdodeliKome, nizdodeliAko, nizskociNA, nizskociAKO)

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim str As String = "" + nvrd

        For i As Integer = 0 To nizdodeliSta.GetUpperBound(0)
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim = tabela Then
                    If CDate(t.Item("Vod")) <= vt AndAlso vt <= CDate(t.Item("Vdo")) Then
                        If t.Item("polje").trim.toupper = nizdodeliKome(i).Trim.ToUpper AndAlso nizdodeliSta(i).Substring(0, 1) <> "#" Then
                            'ako je filter CBO mora ponovo popuni tajCBO kroz filter
                            If t.Item("filtriranoPolje") = 1 Then
                                str = str + "       XXX" + t.Item("imeWeb").trim + "XXX" + nvrd
                            End If
                            If nizdodeliSta(i).Trim.Length = 0 OrElse nizdodeliSta(i).Trim = "''" Then
                                str = str + "       Me." + t.Item("imeWeb").trim + ".Text = " + nvd + nvd + "" + nvrd
                            Else
                                str = str + "       Me." + t.Item("imeWeb").trim + ".Text = dt.Select(sta)(0).Item(" + nvd + nizdodeliSta(i) + nvd + ").ToString.Trim" + nvrd
                            End If
                        End If
                    End If
                End If
            Next
        Next

        strpopuni = strpopuni.Replace("99DODELA99", str)

        str = "" + nvrd
        For i As Integer = 0 To nizskociNA.GetUpperBound(0)
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim = tabela Then
                    If CDate(t.Item("Vod")) <= vt AndAlso vt <= CDate(t.Item("Vdo")) Then
                        If t.Item("polje").trim.toupper = nizskociNA(i).Trim.ToUpper Then
                            If nizskociAKO.Length > 0 Then

                                nizskociAKO(i) = nizskociAKO(i).Replace("d.", "")
                                Dim bbb() As String = razkvantaj(nizskociAKO(i))
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    Dim sta As String = "tabela='" & tabela & "' and polje='" & bbb(ll).ToUpper.Trim & "'"
                                    If dISTPoljaKonsult.Select(sta).Length > 0 Then
                                        bbb(ll) = dISTDodela.Select(sta)(0).Item("imeWeb").ToString.Trim + ".Text"
                                    End If
                                Next
                                nizskociAKO(i) = ustringaj(bbb).ToUpper
                                nizskociAKO(i) = nizskociAKO(i).Replace("'", nvd)
                                nizskociAKO(i) = nizskociAKO(i).Trim.ToUpper.Replace("IS NULL", "=" + nvd + nvd)
                                str = str + "        if (" + nizskociAKO(i) + ") =True then  Me." + t.Item("imeWeb").trim + ".Focus()" + nvrd

                                'str = str + "        if ispitajUslov(" + nvd + nizskociAKO(i) + nvd + ") = True then  Me." + t.Item("imeWeb").trim + ".Focus()" + nvrd
                            Else
                                str = str + "        Me." + t.Item("imeWeb").trim + ".Focus()" + nvrd
                            End If
                        End If
                    End If
                End If
            Next
        Next

        strpopuni = strpopuni.Replace("99SKAKANJE99", str)

        dajFiltriraniCBOTextChanged = strpopuni
        txtpopuni.Close()
    End Function

    'Function dajLabelu(ByVal tekst As String) As String
    '    Dim txtLabela As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\labela.txt")
    '    Dim strLabela As String = txtLabela.ReadToEnd
    '    strLabela = strLabela.Replace("99tekst99", tekst)
    '    dajLabelu = strLabela
    '    txtLabela.Close()
    'End Function

    Function dajRangeValidator(ByVal naziv As String, ByVal minV As String, ByVal maxV As String, ByVal tip As String) As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\rangeValidator.txt")
        Dim strPolje As String = txtpolje.ReadToEnd

        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        If minV = "" Then minV = "0"
        If maxV = "" Then maxV = "999999999"
        strPolje = strPolje.Replace("99min99", minV)
        strPolje = strPolje.Replace("99max99", maxV)
        strPolje = strPolje.Replace("99tip99", tip)

        dajRangeValidator = strPolje
        txtpolje.Close()
    End Function

    Function dajRegularExpressionValidator(ByVal naziv As String, ByVal minduzina As String) As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\regularExpressionValidator.txt")
        Dim strPolje As String = txtpolje.ReadToEnd

        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        strPolje = strPolje.Replace("99minduzina99", minduzina)
        dajRegularExpressionValidator = strPolje
        txtpolje.Close()
    End Function

    Function dajCustomValidator(ByVal naziv As String) As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\CustomValidator.txt")
        Dim strPolje As String = txtpolje.ReadToEnd

        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        dajCustomValidator = strPolje
        txtpolje.Close()
    End Function

    Function dajRequiredFieldValidator(ByVal naziv As String) As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\requiredFieldValidator.txt")
        Dim strPolje As String = txtpolje.ReadToEnd

        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        dajRequiredFieldValidator = strPolje
        txtpolje.Close()
    End Function

    Function dajRequiredFieldValidatorDDL(ByVal naziv As String) As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\requiredFieldValidatorDDL.txt")
        Dim strPolje As String = txtpolje.ReadToEnd

        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        dajRequiredFieldValidatorDDL = strPolje
        txtpolje.Close()
    End Function
    Function dajCHPolje(ByVal tekst As String, ByVal naziv As String, ByVal tabindex As String, ByVal grupa As String) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim chpolje As System.IO.StreamReader
        chpolje = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\CHPolje.txt")
        Dim strPolje As String = chpolje.ReadToEnd
        strPolje = strPolje.Replace("99tekst99", " ")   'tekst
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        strPolje = strPolje.Replace("99tabindeks99", tabindex)
        strPolje = strPolje.Replace("99grupa99", grupa)
        dajCHPolje = strPolje
        chpolje.Close()

    End Function

    Function dajFilterPolje(ByVal prop As Boolean, ByVal tabela As String, ByVal filtrirani As Boolean,
ByVal filtriraniPoCemu As String, ByVal tekst As String, ByVal naziv As String,
ByVal tabindex As String, ByVal duzina As String, ByVal dozvoljeno As String,
ByVal maxLength As String, Optional ByVal vidljivo As Boolean = True) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        ''dodajem update panele samo za CBO koji imaju filter po drugom CBO (ne i za CBO koji imaju filter po nekom txt polju)
        ''npr za opstinu i naselje
        If filtriraniPoCemu <> "" Then
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim = tabela Then
                    If CDate(t.Item("Vod")) <= vt AndAlso vt <= CDate(t.Item("Vdo")) Then
                        If t.Item("polje").trim.toupper = filtriraniPoCemu.Trim.ToUpper Then
                            filtriraniPoCemu = t.Item("imeWeb").trim.toupper
                        End If
                    End If
                End If
            Next
        End If
        Dim cime As String
        Dim sta As String
        Dim txtpolje As System.IO.StreamReader
        If filtrirani = True Then
            txtpolje = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\filterPoljeSaPanelom.txt")
        Else
            txtpolje = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\filterPolje.txt")
        End If

        Dim strPolje As String = txtpolje.ReadToEnd
        strPolje = strPolje.Replace("99tekst99", tekst)
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        strPolje = strPolje.Replace("99tabindeks99", tabindex)

        strPolje = strPolje.Replace("99duzina99", duzina)

        strPolje = strPolje.Replace("99maxlength99", maxLength)
        If filtrirani = True Then strPolje = strPolje.Replace("99pocemu99", filtriraniPoCemu)
        If dozvoljeno = "" Then 'znaci Char ili Text, moze sve sem /
            cime = "FilterMode=" & nvd & "InvalidChars" & nvd & "  InvalidChars=" & nvd & "/" & nvd & ""
            sta = "ValidChars=" & nvd & "99dozvoljeno99" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        ElseIf dozvoljeno = "ALPHA" Then  'samoslova
            cime = "FilterMode=" & nvd & "InvalidChars" & nvd & "  InvalidChars=" & nvd & "/0123456789" & nvd & ""
            sta = "ValidChars=" & nvd & "99dozvoljeno99" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        Else   'numeric
            strPolje = strPolje.Replace("99dozvoljeno99", dozvoljeno)
        End If
        If naziv.Trim.Substring(0, 1) = "H" Or vidljivo = False Then
            cime = "Visible=" & nvd & "False" & nvd & ""
            sta = "Visible=" & nvd & "True" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        End If
        dajFilterPolje = strPolje
        txtpolje.Close()

    End Function

    Function dajDDL(ByVal prop As Boolean, ByVal tekst As String, ByVal naziv As String, ByVal tabindex As String, ByVal duzina As String) As String
        ' Dim txtDDL As New System.IO.StreamReader(m_folderZaGen+"\WEB" + "\DDL.txt")
        Dim txtDDL As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACE.txt")
        Dim strDDL As String = txtDDL.ReadToEnd
        naziv = naziv.Replace(".", "xyz")
        strDDL = strDDL.Replace("99polje99", naziv)
        strDDL = strDDL.Replace("99tabindeks99", tabindex)
        'duzina = CStr(CInt(duzina) + 2)
        strDDL = strDDL.Replace("99duzina99", duzina)
        dajDDL = strDDL
        txtDDL.Close()
    End Function

    Function dajDIVpoc(ByVal str As String) As String
        Dim txtDDL As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\DIVpoc.txt")
        Dim strDDL As String = txtDDL.ReadToEnd
        strDDL = strDDL.Replace("99BROJSTRANE99", str)

        'OVO JE AKO HOCEMO DA STRANA PRVA BUDE STALNO OTVORENA
        'If str = "1" Then strDDL = strDDL.Replace("accBody", "accBody1")

        dajDIVpoc = strDDL
        txtDDL.Close()
    End Function

    Function dajDIVkraj() As String
        Dim txtDDL As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\DIVkraj.txt")
        Dim strDDL As String = txtDDL.ReadToEnd
        dajDIVkraj = strDDL
        txtDDL.Close()
    End Function

    Function dajCBO(ByVal prop As Boolean, ByVal tabela As String, ByVal filtrirani As Boolean, ByVal filtriraniPoCemu As String, ByVal tekst As String, ByVal naziv As String, ByVal tabindex As String, ByVal duzina As String) As String
        'dodajem update panele samo za CBO koji imaju filter po drugom CBO (ne i za CBO koji imaju filter po nekom txt polju)
        'npr za opstinu i naselje
        If filtriraniPoCemu <> "" Then
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim.ToUpper = tabela Then
                    If CDate(t.Item("Vod")) <= vt AndAlso vt <= CDate(t.Item("Vdo")) Then
                        If t.Item("polje").trim.toupper = filtriraniPoCemu.Trim.ToUpper Then
                            filtriraniPoCemu = t.Item("imeWeb").trim.toupper
                        End If
                    End If
                End If
            Next
        End If

        If filtriraniPoCemu.IndexOf("FP{") >= 0 Then
            'NE MOZE AKO JE FILTER PO FIKTIVNOM POLJU
            'postavi da je filter sam sebi, pa nek se prepravlja rucno
            filtriraniPoCemu = naziv
        End If

        Dim txtCBO As System.IO.StreamReader
        If filtrirani = True Then
            txtCBO = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\CBOsaPanelom.txt")
        Else
            txtCBO = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\CBO.txt")
        End If
        Dim strCBO As String = txtCBO.ReadToEnd
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strCBO = strCBO.Replace("99polje99", naziv)
        strCBO = strCBO.Replace("99tabindeks99", tabindex)
        duzina = CStr(CInt(duzina) + 2)
        strCBO = strCBO.Replace("99duzina99", duzina)
        If filtrirani = True Then strCBO = strCBO.Replace("99pocemu99", filtriraniPoCemu)
        dajCBO = strCBO
        txtCBO.Close()

    End Function

    Function dajACE(ByVal tabela As String, ByVal filtrirani As Boolean, ByVal filtriraniPoCemu As String, ByVal tekst As String, ByVal naziv As String, ByVal tabindex As String, ByVal duzina As String) As String

        Dim txtACE As System.IO.StreamReader
        txtACE = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACE.txt")
        Dim strACE As String = txtACE.ReadToEnd
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        Dim nazivLAZNIDDL As String = naziv.Replace("_", "_LAZNIDDL")

        strACE = strACE.Replace("99polje99", naziv.Trim.ToUpper)
        strACE = strACE.Replace("99poljeLAZNIDDL99", nazivLAZNIDDL.Trim.ToUpper)
        strACE = strACE.Replace("99tabindeks99", tabindex)
        strACE = strACE.Replace("99duzina99", duzina)

        dajACE = strACE
        txtACE.Close()
    End Function

    Function dajTKMES() As String

        Dim txtTKMES As System.IO.StreamReader
        txtTKMES = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\TK_MES.txt")
        Dim strTKMES As String = txtTKMES.ReadToEnd
        dajTKMES = strTKMES
        txtTKMES.Close()
    End Function

    Function dajTKKV() As String

        Dim txtTKKV As System.IO.StreamReader
        txtTKKV = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\TK_KV.txt")
        Dim strTKKV As String = txtTKKV.ReadToEnd
        dajTKKV = strTKKV
        txtTKKV.Close()
    End Function

    Function dajACEFilter(ByVal tabela As String, ByVal filtrirani As Boolean, ByVal filtriraniPoCemu As String, ByVal tekst As String, ByVal naziv As String, ByVal tabindex As String, ByVal duzina As String) As String
        If filtriraniPoCemu <> "" Then
            For Each t As System.Data.DataRow In dISTPoljaKonsult.Rows
                If t.Item("tabela").ToString.Trim.ToUpper = tabela Then
                    If CDate(t.Item("Vod")) <= vt AndAlso vt <= CDate(t.Item("Vdo")) Then
                        If t.Item("polje").trim.toupper = filtriraniPoCemu.Trim.ToUpper Then
                            filtriraniPoCemu = t.Item("imeWeb").trim.toupper
                        End If
                    End If
                End If
            Next
        End If

        If filtriraniPoCemu.IndexOf("FP{") >= 0 Then
            'NE MOZE AKO JE FILTER PO FIKTIVNOM POLJU
            'postavi da je filter sam sebi, pa nek se prepravlja rucno
            filtriraniPoCemu = naziv
        End If

        Dim txtACE As System.IO.StreamReader
        txtACE = New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\ACEFilter.txt")
        Dim strACE As String = txtACE.ReadToEnd
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        Dim nazivLAZNIDDL As String = naziv.Replace("_", "_LAZNIDDL")
        strACE = strACE.Replace("99polje99", naziv)
        strACE = strACE.Replace("99poljeLAZNIDDL99", nazivLAZNIDDL)
        strACE = strACE.Replace("99tabindeks99", tabindex)
        strACE = strACE.Replace("99duzina99", duzina)
        If filtrirani = True Then
            Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
            Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
            Dim pp As String = "ACE" + nazivLAZNIDDL
            sbFilter.Append(nvrd)
            sbFilter.Append("<script type=" & nvd & "text/javascript" & nvd & ">")
            sbFilter.Append(nvrd)
            sbFilter.Append("function SetContextKey" + nazivLAZNIDDL.Trim + "() {")
            sbFilter.Append(nvrd)
            sbFilter.Append("       $find('<%=" + pp + ".ClientID %>').set_contextKey($get('<%=" + filtriraniPoCemu + ".ClientID %>').value);")
            sbFilter.Append("}")
            sbFilter.Append(nvrd)
            sbFilter.Append("</script>")
            sbFilter.Append(nvrd)
        End If
        dajACEFilter = strACE
        txtACE.Close()

    End Function

    Function dajFP(ByVal prop As Boolean, ByVal tekst As String, ByVal naziv As String, ByVal tabindex As String, ByVal duzina As String) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim sta As String
        Dim cime As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\FP.txt")
        Dim strPolje As String = txtpolje.ReadToEnd
        strPolje = strPolje.Replace("99opis99", tekst)
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        strPolje = strPolje.Replace("99tabindeks99", tabindex)
        strPolje = strPolje.Replace("99duzina99", duzina)

        If naziv.Trim.Substring(0, 1) = "H" Then
            cime = "Visible=" & nvd & "False" & nvd & ""
            sta = "Visible=" & nvd & "True" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        End If

        dajFP = strPolje
        txtpolje.Close()
    End Function

    Function dajLiteral(ByVal prop As Boolean, ByVal tekst As String, ByVal naziv As String, ByVal bold As String) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim sta As String
        Dim cime As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\literal.txt")
        Dim strPolje As String = txtpolje.ReadToEnd
        Dim pd() As String = tekst.Split("-")
        If pd.Length > 1 Then
            Dim dd() As String = pd(1).Split("#")
            If dd.Length > 0 Then
                tekst = dd(0)
            Else
                tekst = pd(1)
            End If
        Else
            tekst = pd(0)
        End If
        strPolje = strPolje.Replace("99opis99", tekst)
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)

        If naziv.Trim.Substring(0, 1) = "H" Then
            cime = "Visible=" & nvd & "False" & nvd & ""
            sta = "Visible=" & nvd & "True" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        End If

        If bold = "NB" Then
            strPolje = strPolje.Replace("<b>", "")
            strPolje = strPolje.Replace("</b>", "")
        End If
        dajLiteral = strPolje
        txtpolje.Close()
    End Function
    Function dajLiteralRBG(ByVal prop As Boolean, ByVal opis As String, ByVal izraz As String, ByVal naziv As String, ByVal bold As String) As String

        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim rb As Boolean = False
        Dim rbh As Boolean = False
        Dim rbv As Boolean = False


        Dim pd() As String = opis.Split("-")
        If pd.Length > 1 Then
            Dim dd() As String = pd(1).Split("#")
            If dd.Length > 0 Then
                opis = dd(0)
            Else
                opis = pd(1)
            End If
        Else
            opis = pd(0)
        End If

        If izraz.Length >= 11 AndAlso izraz.ToUpper.Substring(0, 11) = "RADIOBUTTON" AndAlso izraz.ToUpper.Substring(0, 12) <> "RADIOBUTTONH" AndAlso izraz.ToUpper.Substring(0, 12) <> "RADIOBUTTONV" Then
            izraz = Replace(izraz, "radiobutton", "radiobuttonv", 1, , CompareMethod.Text)
        End If

        If izraz.Length >= 12 AndAlso izraz.ToUpper.Substring(0, 12) = "RADIOBUTTONV" Then
            rbv = True : rbh = False
        ElseIf izraz.Length >= 12 AndAlso izraz.ToUpper.Substring(0, 12) = "RADIOBUTTONH" Then
            rbv = False : rbh = True
        End If

        Dim strNR As String = ""
        If rbv = True Then strNR = nvrd Else strNR = "   "

        Dim pom As String = izraz.Substring(12).Trim
        pom = Replace(pom, "{", "")
        pom = Replace(pom, ";}", "")
        pom = Replace(pom, "; }", "")
        pom = Replace(pom, "}", "")
        pom = pom.TrimEnd(",")
        pom = pom.TrimStart(",")
        pom = pom.Replace("\N", "")

        Dim nv() As String = pom.Split(",")
        Dim brk As Integer = nv.Length

        naziv = naziv.Replace(".", "xyz")

        'Dim vvalue As String = ""
        Dim ttext As String = ""
        For ii As Integer = 0 To nv.GetUpperBound(0)
            If nv(ii).ToString.Trim.ToUpper.IndexOf("DEFAULT") >= 0 Then
                nv(ii) = NZ(Replace(nv(ii).Trim, "default", "", 1, , CompareMethod.Text)).Trim
            End If
            Dim rtl As Boolean = False
            If nv(ii).ToString.Trim.ToUpper.IndexOf("LEFT") = 0 Then
                nv(ii) = NZ(Replace(nv(ii).Trim, "left", "", 1, , CompareMethod.Text)).Trim
                rtl = True
            End If
            Dim mm As Integer = nv(ii).ToString.IndexOf("'")
            If mm < 0 Then
                nv(ii) = "'" + nv(ii).Trim
                mm = 0
            End If
            Dim tt As String = nv(ii).ToString.Substring(0, mm).Trim
            If mm = 0 OrElse IsNumeric(tt) = False Then
                'vvalue = CStr(ii + 1)
                ttext = ttext + CStr(ii + 1) & "-" & nv(ii).ToString.Replace("'", "").Trim + strNR
            ElseIf IsNumeric(tt) Then
                'vvalue = tt.Trim
                ttext = ttext + tt.Trim & "-" & nv(ii).ToString.Substring(mm).Replace("'", "").Trim + strNR
            End If
        Next

        Dim sta As String
        Dim cime As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\literal.txt")
        Dim strPolje As String = txtpolje.ReadToEnd

        strPolje = strPolje.Replace("99opis99", ttext)
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)

        If naziv.Trim.Substring(0, 1) = "H" Then
            cime = "Visible=" & nvd & "False" & nvd & ""
            sta = "Visible=" & nvd & "True" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        End If

        If bold = "NB" Then
            strPolje = strPolje.Replace("<b>", "")
            strPolje = strPolje.Replace("</b>", "")
        End If
        dajLiteralRBG = opis + ":    " + strPolje
        txtpolje.Close()

    End Function
    Function dajFPrightPanelKljuc(ByVal prop As Boolean, ByVal tekst As String, ByVal naziv As String,
ByVal tabindex As String, ByVal duzina As String) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim sta As String
        Dim cime As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\FPrightPanelKljuc.txt")
        Dim strPolje As String = txtpolje.ReadToEnd
        strPolje = strPolje.Replace("99opis99", tekst)
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        strPolje = strPolje.Replace("99tabindeks99", tabindex)
        strPolje = strPolje.Replace("99duzina99", duzina)

        If naziv.Trim.Substring(0, 1) = "H" Then
            cime = "Visible=" & nvd & "False" & nvd & ""
            sta = "Visible=" & nvd & "True" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        End If

        dajFPrightPanelKljuc = strPolje
        txtpolje.Close()
    End Function

    Function dajFPright(ByVal prop As Boolean, ByVal tekst As String, ByVal naziv As String,
ByVal tabindex As String, ByVal duzina As String) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim sta As String
        Dim cime As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\FPright.txt")
        Dim strPolje As String = txtpolje.ReadToEnd
        strPolje = strPolje.Replace("99opis99", tekst)
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        strPolje = strPolje.Replace("99tabindeks99", tabindex)
        strPolje = strPolje.Replace("99duzina99", duzina)

        If naziv.Trim.Substring(0, 1) = "H" Then
            cime = "Visible=" & nvd & "False" & nvd & ""
            sta = "Visible=" & nvd & "True" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        End If

        dajFPright = strPolje
        txtpolje.Close()
    End Function

    Function dajFPrightBold(ByVal prop As Boolean, ByVal tekst As String, ByVal naziv As String, ByVal tabindex As String, ByVal duzina As String) As String
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim sta As String
        Dim cime As String
        Dim txtpolje As New System.IO.StreamReader(m_folderZaGen + "\WEB" + "\FPrightBold.txt")
        Dim strPolje As String = txtpolje.ReadToEnd
        strPolje = strPolje.Replace("99opis99", tekst)
        'ime kontrole ne sme da sadrži tačku u ASPX-u
        naziv = naziv.Replace(".", "xyz")
        strPolje = strPolje.Replace("99polje99", naziv)
        strPolje = strPolje.Replace("99tabindeks99", tabindex)
        strPolje = strPolje.Replace("99duzina99", duzina)

        If naziv.Trim.Substring(0, 1) = "H" Then
            cime = "Visible=" & nvd & "False" & nvd & ""
            sta = "Visible=" & nvd & "True" & nvd & ""
            strPolje = strPolje.Replace(sta, cime)
        End If

        dajFPrightBold = strPolje
        txtpolje.Close()
    End Function

    Private Sub MIXmlPodaci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIXmlPodaci.Click
        'XML->Podaci.


        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            'Me.m_zadaciIstrazivanje.ButtonUnos_Click()
            Dim dlg As New System.Windows.Forms.OpenFileDialog
            dlg.ShowDialog()
            Dim dttk As String = dlg.FileName
            dlg.Dispose()

            If dttk <> "" Then
                Dim DS As New System.Data.DataSet

                Me.Cursor = Cursors.WaitCursor
                Try
                    DS.ReadXmlSchema(dttk & ".dtd")
                Catch
                End Try
                DS.ReadXml(dttk)
                Me.Cursor = Cursors.Default

                Dim dr As DialogResult = DialogResult.Yes

                Dim cmd As System.Data.SqlClient.SqlCommand = Nothing

                Dim sql As String
                Dim t As System.Data.SqlClient.SqlTransaction = Nothing

                Dim UkRedova As Integer = 0
                If dr <> DialogResult.Cancel Then
                    Me.Cursor = Cursors.WaitCursor
                    Try

                        For Each dt As System.Data.DataTable In DS.Tables
                            If dt.Rows.Count > 0 Then 'cini mi se da delete ide uvek?
                                UkRedova += dt.Rows.Count
                                For Each dtr As System.Data.DataRow In dt.Rows
                                    Dim s1 As String = "" : Dim s2 As String = ""
                                    For Each dtrc As System.Data.DataColumn In dt.Columns
                                        If s1.Trim <> "" Then s1 = s1 & ","
                                        If s2.Trim <> "" Then s2 = s2 & ","
                                        s1 = s1 & dtrc.ColumnName
                                        If dtr.Item(dtrc.ColumnName) Is System.DBNull.Value Then
                                            s2 = s2 & "NULL"
                                        Else
                                            If dtrc.ColumnName.Trim.ToUpper = "VOD" Or dtrc.ColumnName.Trim.ToUpper = "VDO" Then
                                                s2 = s2 & "'" & CDate(dtr.Item(dtrc.ColumnName)) & "'"
                                            Else
                                                Select Case dtrc.DataType.Name
                                                    Case "Boolean"
                                                        If CType(dtr.Item(dtrc.ColumnName), Boolean) = False Then
                                                            s2 = s2 & "0"
                                                        Else
                                                            s2 = s2 & "1"
                                                        End If
                                                    Case "DateTime" 'ovo ne hvata nikad?
                                                        s2 = s2 & "'" & CDate(dtr.Item(dtrc.ColumnName)) & "'"
                                                    Case "String", "char"
                                                        Select Case CStr(dtr.Item(dtrc.ColumnName)).Trim.ToUpper
                                                            Case "TRUE"
                                                                s2 = s2 & "1"
                                                            Case "FALSE"
                                                                s2 = s2 & "0"
                                                            Case Else
                                                                s2 = s2 & "N'" & CStr(dtr.Item(dtrc.ColumnName)).Replace("'", "''") & "'"
                                                        End Select

                                                    Case Else
                                                        s2 = s2 & " CAST('" & CStr(dtr.Item(dtrc.ColumnName)) & "' AS FLOAT) " 'da bi radili i float-ovi
                                                End Select
                                            End If
                                        End If
                                    Next
                                    sql = "INSERT into " & dt.TableName & " (" & s1 & ") values (" & s2 & ") "

                                    Dim ok1 As String = izvrsiSQL(sql, connectionString)
                                    If ok1 <> "ok" Then
                                        ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER23", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    End If
                                Next ' svrshili s Row-ima
                            End If 'ima podaci za pisanje....
                        Next

                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Me.Cursor = Cursors.Default
                        Return

                    End Try
                    Me.Cursor = Cursors.Default
                    ISTMessageBox.Show("Уснимљено " & UkRedova & " ред/а/ова у" & DS.Tables.Count & " табели/е/а", "Уснимљено", MessageBoxButtons.OK,
                                    MessageBoxIcon.Asterisk,
                                    MessageBoxDefaultButton.Button1)
                End If
            End If
        End If
    End Sub

    Private Sub MIPodaciXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIPodaciXml.Click
        'Podaci->XML.


        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Dim DS As New System.Data.DataSet
            Dim imedttk As String = rowIST.SIFIST.Trim & "_" & Me.UserControlVremenskaTacka1.G.ToString.Trim & Me.UserControlVremenskaTacka1.M.ToString.Trim.PadLeft(2, "0"c) & "_PODACI"

            For Each r As DatasetIstrazivanja.ISTTABELERow In dataSetIST.ISTTABELE.Rows
                Dim dT As New System.Data.DataTable

                Dim sqlP As String = " select * from " & r.Tabela & " where 2=3"

                dT = izvrsiSQLvratiDT(sqlP, connectionString, Nothing)

                Dim sqlVT As String = ""
                Dim ImaGOD As Boolean = False
                Dim ImaMES As Boolean = False
                Dim ImaGODE As Boolean = False
                Dim ImaMESE As Boolean = False

                If Not (dT.Columns("GOD") Is Nothing) Then
                    ImaGOD = True : sqlVT += " AND GOD='" + Me.UserControlVremenskaTacka1.G.ToString.Trim + "'"
                End If
                If Not (dT.Columns("MES") Is Nothing) Then
                    ImaMES = True : sqlVT += " AND MES='" & Me.UserControlVremenskaTacka1.M.ToString.Trim.PadLeft(2, "0"c) & "'"
                End If
                If Not (dT.Columns("ISTYEAR") Is Nothing) Then
                    ImaGODE = True : sqlVT += " AND ISTYEAR='" + Me.UserControlVremenskaTacka1.G.ToString.Trim + "'"
                End If
                If Not (dT.Columns("ISTMONTH") Is Nothing) Then
                    ImaMESE = True : sqlVT += " AND ISTMONTH='" & Me.UserControlVremenskaTacka1.M.ToString.Trim.PadLeft(2, "0"c) & "'"
                End If

                ''msg 121
                Dim msgtxt121 As String = getMessageText(dtMessages, "121", Me.jezik)
                ''msg 122
                Dim msgtxt122 As String = getMessageText(dtMessages, "122", Me.jezik)
                Dim por As String = msgtxt121 + nvrd + r.Tabela & " ?"
                If ISTMessageBox.Show("por", msgtxt122, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Else
                    Dim sql As String = " select * from " & r.Tabela & " where 2=2 " & sqlVT

                    dT = izvrsiSQLvratiDT(sql, connectionString, Nothing)

                    dT.TableName = r.Tabela
                    DS.Tables.Add(dT)
                End If
            Next

            Dim dlg As New System.Windows.Forms.SaveFileDialog
            dlg.Filter = "XML files (*.xml)|*.xml"
            dlg.FileName = imedttk 'dlg.InitialDirectory + "\" +
            Dim dr As DialogResult
            dr = dlg.ShowDialog
            Dim fileName As String = dlg.FileName
            dlg.Dispose()
            If dr = DialogResult.OK Then
                DS.DataSetName = fileName
                DS.WriteXml(fileName)
                DS.WriteXmlSchema(fileName & ".dtd")
            End If
        End If
    End Sub
    Dim dataSetIST As DatasetIstrazivanja = Nothing
    Dim dataSetISTPX As DatasetIstrazivanja = Nothing
    Dim connectionString As String = ""
    Dim rowIST As DatasetIstrazivanja.ISTRow = Nothing
    Dim tabelaAdresar As DatasetIstrazivanja.ISTPOLJADataTable = Nothing


    'zakljucavanje
    Private Sub MIZakljucaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIZakljucaj.Click
        ZakljOdklj("1")
    End Sub

    Private Sub MIZakljucajWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIZakljucajWeb.Click
        ZakljOdkljWeb("1")
    End Sub

    Private Sub MIZO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIZO.Click
        Me.Cursor = Cursors.WaitCursor
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonZO_Click()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Public Function KoImaPravoDaOtkljuca() As String
        KoImaPravoDaOtkljuca = ""
        Dim dISTPolja As New System.Data.DataTable
        Dim dataSetIST As DatasetIstrazivanja = Me.m_zadaciVremenskaTacka.dsdsIST
        Dim IzIst As String = CStr(dataSetIST.ISTPOLJA.Rows(0).Item("SifIST")).Trim.ToUpper
        Dim sql As String = "select statisticar from vISTOdgovorni where SifIST='" + IzIst + "'"

        dISTPolja = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        If dISTPolja.Rows.Count > 0 Then
            KoImaPravoDaOtkljuca = dISTPolja.Rows(0).Item(0).ToString.Trim
        End If
        Return KoImaPravoDaOtkljuca
    End Function

    Private Sub MIOtkljucaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIOtkljucaj.Click
        'otkljucavanje
        Dim koWin As String = GetUserName.ToString.Trim
        Dim koIstOtk As String = KoImaPravoDaOtkljuca()
        If koIstOtk.Trim.Length > 0 Then
            If koWin = koIstOtk Then
                ZakljOdklj("0")
            Else
                ''msg 123
                Dim msgtxt As String = getMessageText(dtMessages, "123", Me.jezik)
                ISTMessageBox.Show(msgtxt)
            End If
        Else
            '=0, tj nije definisano ko moze da otkljuca
            ''msg 124
            Dim msgtxt As String = getMessageText(dtMessages, "124", Me.jezik)
            ISTMessageBox.Show(msgtxt)
        End If

    End Sub

    Private Sub MIOtkljucajWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIOtkljucajWeb.Click
        'otkljucavanje
        Dim koWin As String = GetUserName.ToString.Trim
        Dim koIstOtk As String = KoImaPravoDaOtkljuca()
        If koIstOtk.Trim.Length > 0 Then
            If koWin = koIstOtk Then
                ZakljOdkljWeb("0")
            Else
                ''msg 123
                Dim msgtxt As String = getMessageText(dtMessages, "123", Me.jezik)
                ISTMessageBox.Show(msgtxt)
            End If
        Else
            '=0, tj nije definisano ko moze da otkljuca
            ''msg 124
            Dim msgtxt As String = getMessageText(dtMessages, "124", Me.jezik)
            ISTMessageBox.Show(msgtxt)
        End If

    End Sub

    Private Sub ZakljOdklj(ByVal NulaJedan As String)
        Dim PrvaRec As String
        ''msg 125
        Dim msgtxt125 As String = getMessageText(dtMessages, "125", Me.jezik)
        ''msg 126
        Dim msgtxt126 As String = getMessageText(dtMessages, "126", Me.jezik)
        If NulaJedan = "0" Then PrvaRec = msgtxt125 Else PrvaRec = msgtxt126

        Dim ra As Integer = 0
        Dim brT As Integer = 0
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then

            For Each r As DatasetIstrazivanja.ISTTABELERow In dataSetIST.ISTTABELE.Rows
                Dim dT As New System.Data.DataTable
                Dim ImaGOD As Boolean = False
                Dim ImaMES As Boolean = False

                Dim ImaGODE As Boolean = False
                Dim ImaMESE As Boolean = False

                Dim ImaLK As Boolean = False
                Dim sqlP As String = " select * from " & r.Tabela & " where 2=3"

                dT = izvrsiSQLvratiDT(sqlP, connectionString, Nothing)

                If Not (dT.Columns("LK") Is Nothing) Then
                    'ako ima LK
                    brT += 1
                    Dim sqlVT As String = ""
                    If Not (dT.Columns("GOD") Is Nothing) Then ImaGOD = True : sqlVT += " AND GOD='" + Me.UserControlVremenskaTacka1.G.ToString.Trim + "'"
                    If Not (dT.Columns("MES") Is Nothing) Then ImaMES = True : sqlVT += " AND MES='" & Me.UserControlVremenskaTacka1.M.ToString.Trim.PadLeft(2, "0"c) & "'"

                    If Not (dT.Columns("ISTYEAR") Is Nothing) Then ImaGOD = True : sqlVT += " AND ISTYEAR='" + Me.UserControlVremenskaTacka1.G.ToString.Trim + "'"
                    If Not (dT.Columns("ISTMONTH") Is Nothing) Then ImaMES = True : sqlVT += " AND ISTMONTH='" & Me.UserControlVremenskaTacka1.M.ToString.Trim.PadLeft(2, "0"c) & "'"

                    ' da li je već zaključano ili otključano
                    Dim dTPK As New System.Data.DataTable
                    Dim sqlPLK As String = " select distinct LK as mLK from " & r.Tabela & " where 2=2 " & sqlVT

                    dTPK = izvrsiSQLvratiDT(sqlPLK, connectionString, Nothing)

                    Dim ZO As String = "M"
                    If dTPK.Rows.Count = 1 Then 'ili je sve otkljucano ili je sve zakljucano, ostalo je mešovito (M) pa akcija ide uvek
                        ZO = dTPK.Rows(0).Item("mLK").ToString.ToUpper.Trim
                        'kad je Null ZO=""
                    End If

                    Dim sqlLK As String = ""
                    Dim akcija As Boolean = False
                    If NulaJedan = "0" AndAlso (ZO = "TRUE" Or ZO = "M") Then
                        akcija = True
                        If Not (dT.Columns("datum_LKO") Is Nothing) Then sqlLK = sqlLK + ",datum_LKO=(CONVERT([varchar],getdate(),(120)))"
                        If Not (dT.Columns("ko_LKO") Is Nothing) Then sqlLK = sqlLK + ",ko_LKO=suser_sname()"
                    End If
                    If NulaJedan = "1" AndAlso (ZO = "FALSE" Or ZO = "M" Or ZO = "") Then
                        akcija = True
                        If Not (dT.Columns("datum_LKZ") Is Nothing) Then sqlLK = sqlLK + ",datum_LKZ=(CONVERT([varchar],getdate(),(120)))"
                        If Not (dT.Columns("ko_LKZ") Is Nothing) Then sqlLK = sqlLK + ",ko_LKZ=suser_sname()"
                    End If
                    Dim sql As String = " update " & r.Tabela & " SET LK = '" & NulaJedan & "'" & sqlLK & " where 2=2 " & sqlVT

                    If akcija = True Then

                        Try
                            Dim brPom As Integer = izvrsiSQLVratiBrojSlogova(sql, connectionString)
                            ra = ra + brPom

                        Catch ex As System.Exception
                            ISTMessageBox.Show(ex.Message + vbCrLf + sql, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return

                        End Try
                    End If 'treba da se radi, akcija=true
                End If ' ima LK
            Next

            ''msg 127
            Dim msgtxt127 As String = getMessageText(dtMessages, "127", Me.jezik) + nvrd
            ''msg 128
            Dim msgtxt128 As String = getMessageText(dtMessages, "128", Me.jezik) + nvrd
            ''msg 129
            Dim msgtxt129 As String = getMessageText(dtMessages, "129", Me.jezik) + nvrd
            ''msg 130
            Dim msgtxt130 As String = getMessageText(dtMessages, "130", Me.jezik) + nvrd
            'ISTMessageBox.Show(PrvaRec & ra & msgtxt127 & brT & msgtxt128 & CStr(dataSetIST.ISTTABELE.Rows.Count) & msgtxt129, msgtxt130, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Dim por As String = PrvaRec & ra & msgtxt127 & brT & msgtxt128 & CStr(dataSetIST.ISTTABELE.Rows.Count) & msgtxt129
            ISTMessageBox.Show(por, msgtxt130, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ZakljOdkljWeb(ByVal NulaJedan As String)
        Dim PrvaRec As String
        ''msg 131
        Dim msgtxt131 As String = getMessageText(dtMessages, "131", Me.jezik)
        ''msg 132
        Dim msgtxt132 As String = getMessageText(dtMessages, "132", Me.jezik)
        If NulaJedan = "0" Then PrvaRec = msgtxt131 Else PrvaRec = msgtxt132

        Dim ra As Integer = 0
        Dim brT As Integer = 0
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then

            For Each r As DatasetIstrazivanja.ISTTABELERow In dataSetIST.ISTTABELE.Rows
                Dim dT As New System.Data.DataTable
                Dim ImaGOD As Boolean = False
                Dim ImaMES As Boolean = False
                Dim ImaGODE As Boolean = False
                Dim ImaMESE As Boolean = False

                Dim ImaLK As Boolean = False
                Dim sqlP As String = " select * from " & r.Tabela & " where 2=3"

                dT = izvrsiSQLvratiDT(sqlP, connectionString, Nothing)

                If Not (dT.Columns("LKWeb") Is Nothing) Then
                    brT += 1
                    Dim sqlVT As String = ""
                    If Not (dT.Columns("GOD") Is Nothing) Then ImaGOD = True : sqlVT += " AND GOD='" + Me.UserControlVremenskaTacka1.G.ToString.Trim + "'"
                    If Not (dT.Columns("MES") Is Nothing) Then ImaMES = True : sqlVT += " AND MES='" & Me.UserControlVremenskaTacka1.M.ToString.Trim.PadLeft(2, "0"c) & "'"
                    If Not (dT.Columns("ISTYEAR") Is Nothing) Then ImaGOD = True : sqlVT += " AND ISTYEAR='" + Me.UserControlVremenskaTacka1.G.ToString.Trim + "'"
                    If Not (dT.Columns("ISTMONTH") Is Nothing) Then ImaMES = True : sqlVT += " AND ISTMONTH='" & Me.UserControlVremenskaTacka1.M.ToString.Trim.PadLeft(2, "0"c) & "'"

                    ' da li je već zaključano ili otključano
                    Dim dTPK As New System.Data.DataTable
                    Dim sqlPLK As String = " select distinct LKweb as mLK from " & r.Tabela & " where 2=2 " & sqlVT

                    dTPK = izvrsiSQLvratiDT(sqlPLK, connectionString, Nothing)

                    Dim ZO As String = "M"
                    If dTPK.Rows.Count = 1 Then 'ili je sve otkljucano ili je sve zakljucano, ostalo je mešovito (M) pa akcija ide uvek
                        ZO = dTPK.Rows(0).Item("mLK").ToString.ToUpper.Trim
                        'kad je Null ZO=""
                    End If

                    Dim sqlLK As String = ""
                    Dim akcija As Boolean = False
                    If NulaJedan = "0" AndAlso (ZO = "TRUE" Or ZO = "M") Then
                        akcija = True
                        If Not (dT.Columns("datum_LKOweb") Is Nothing) Then sqlLK = sqlLK + ",datum_LKOweb=(CONVERT([varchar],getdate(),(120)))"
                        If Not (dT.Columns("ko_LKOweb") Is Nothing) Then sqlLK = sqlLK + ",ko_LKOweb=suser_sname()"
                    End If
                    If NulaJedan = "1" AndAlso (ZO = "FALSE" Or ZO = "M" Or ZO = "") Then
                        akcija = True
                        If Not (dT.Columns("datum_LKZweb") Is Nothing) Then sqlLK = sqlLK + ",datum_LKZweb=(CONVERT([varchar],getdate(),(120)))"
                        If Not (dT.Columns("ko_LKZweb") Is Nothing) Then sqlLK = sqlLK + ",ko_LKZweb=suser_sname()"
                    End If
                    Dim sql As String = " update " & r.Tabela & " SET LKweb = '" & NulaJedan & "'" & sqlLK & " where 2=2 " & sqlVT
                    If akcija = True Then

                        Try

                            Dim brPom As Integer = izvrsiSQLVratiBrojSlogova(sql, connectionString)
                            ra = ra + brPom

                        Catch ex As System.Exception
                            ISTMessageBox.Show(ex.Message + vbCrLf + sql, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Return

                        End Try
                    End If 'treba da se radi, akcija=true
                End If ' ima LKweb
            Next


            ''msg 127
            Dim msgtxt127 As String = getMessageText(dtMessages, "127", Me.jezik) + nvrd
            ''msg 128
            Dim msgtxt128 As String = getMessageText(dtMessages, "128", Me.jezik) + nvrd
            ''msg 129
            Dim msgtxt129 As String = getMessageText(dtMessages, "129", Me.jezik) + nvrd
            ''msg 130
            Dim msgtxt130 As String = getMessageText(dtMessages, "130", Me.jezik) + nvrd
            'ISTMessageBox.Show(PrvaRec & ra & msgtxt127 & brT & msgtxt128 & CStr(dataSetIST.ISTTABELE.Rows.Count) & msgtxt129, msgtxt130, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Dim por As String = PrvaRec & ra & msgtxt127 & brT & msgtxt128 & CStr(dataSetIST.ISTTABELE.Rows.Count) & msgtxt129
            ISTMessageBox.Show(por, msgtxt130, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function trenutnoDatumVremeSaServera() As String
        Dim konCATI As String = getConnectionString(Me.CATIServer.Trim, Me.CATIBaza.Trim, txtmode, "")
        Dim sql As String = "select CONVERT(varchar, GETDATE(), 120) as dv"
        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sql, konCATI, Nothing)
        If dt.Rows.Count > 0 Then
            trenutnoDatumVremeSaServera = dt.Rows(0).Item("dv").ToString.Trim
        Else
            trenutnoDatumVremeSaServera = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm")
        End If
    End Function

    Private Sub MIProjektanti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MIProjektanti.Click

        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonPr_Click()
        End If
    End Sub

    Public Function KoImaPravoNaMetaBazu() As String
        KoImaPravoNaMetaBazu = "$"
        Dim dt As New System.Data.DataTable
        Dim sql As String = "select zaposlenID,eMail from vZSRIST"

        dt = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        For i As Integer = 0 To dt.Rows.Count - 1
            KoImaPravoNaMetaBazu = KoImaPravoNaMetaBazu + dt.Rows(i).Item(1).ToString.Trim.ToUpper + "$"
        Next

        Return KoImaPravoNaMetaBazu
    End Function


    Private Sub llIST_LinkClicked(ByVal sender As System.Object, ByVal e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.statsrb.lan/MAIN/ISTHome.aspx")
    End Sub

    Private Sub ITMaterijali_LinkClicked(ByVal sender As System.Object, ByVal e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.statsrb.lan/MAIN/IT_Materijali.aspx")
    End Sub

    '*****************************



    Private Sub mTehDok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mTehDok.Click
        Me.Cursor = Cursors.WaitCursor

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(2057)

        Dim sql As String = ""
        Dim sqlTab As String = ""
        Dim sqlPolja As String = ""
        Dim sqlDodela As String = ""
        Dim dISTBaza As New System.Data.DataTable
        Dim dISTPravaBaza As New System.Data.DataTable

        Dim sqlVB As String = ""
        mvt = Me.UserControlVremenskaTacka1
        Dim vtDok As String = ""
        With Me.UserControlVremenskaTacka1.MyValue
            Dim vt1 As Date = New Date(.Year, .Month, Date.DaysInMonth(.Year, .Month))
            vt = CStr(vt1).Trim
            vtDok = CStr(vt1.Month).Trim + "." + CStr(vt1.Year).Trim
        End With

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim dataSetIST As DatasetIstrazivanja = Me.m_zadaciVremenskaTacka.dsdsIST
        IzIst = CStr(dataSetIST.IST.Rows(0).Item("SifIST")).Trim.ToUpper
        Dim IzIstDok As String = IzIst + " - " + CStr(dataSetIST.IST.Rows(0).Item("naziv")).Trim.ToUpper
        'Dim SQLUpitiDok As String = CStr(dataSetIST.IST.Rows(0).Item("TxtDir")).Trim.ToUpper
        Dim SQLUpitiDok As String = ""
        If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
            SQLUpitiDok = GetTXTDir() + CStr(dataSetIST.IST.Rows(0).Item("sifist")).Trim.ToUpper
        Else
            SQLUpitiDok = CStr(dataSetIST.IST.Rows(0).Item("TxtDir")).Trim.ToUpper
        End If
        Dim folder As String = "C:\ISTTD_" + IzIst + "\"

        Try
            Call DeleteFilesFromFolders(folder, Me.jezik)
            Call CopyDirectory(m_folderZaGen + "\TechnicalDocumentation", folder)
            Call DeleteTxtFilesFromFolders(folder)
        Catch ex As System.Exception
            ''msg 99
            Dim msgtxt As String = getMessageText(dtMessages, "99", Me.jezik) + nvrd
            Dim por As String = msgtxt + folder + nvrd
            ISTMessageBox.Show(por + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
        End Try

        Dim Periodika As String = ""
        If dataSetIST.IST.Rows(0).Item("Periodika") Is System.DBNull.Value Then
        Else
            Periodika = CStr(dataSetIST.IST.Rows(0).Item("Periodika")).Trim.ToUpper()
        End If

        Dim PeriodikaDok As String = Periodika

        Dim dt0 As New System.Data.DataTable
        sql = " select pravaBaza,server,konekcijaDok from vBazaServer where SifIST='" + IzIst + "' "

        dt0 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        Dim pravaBazaDok As String = ""
        Dim serverDok As String = ""
        Dim konekcijaDok As String = ""
        If dt0.Rows.Count > 0 Then
            If dt0.Rows(0).Item("pravaBaza") Is System.DBNull.Value Then
            Else
                pravaBazaDok = CStr(dt0.Rows(0).Item("pravaBaza")).Trim.ToUpper()
            End If
            If dt0.Rows(0).Item("server") Is System.DBNull.Value Then
            Else
                serverDok = CStr(dt0.Rows(0).Item("server")).Trim.ToUpper()
            End If
            If dt0.Rows(0).Item("konekcijaDok") Is System.DBNull.Value Then
            Else
                konekcijaDok = CStr(dt0.Rows(0).Item("konekcijaDok")).Trim.ToUpper()
            End If
        End If

        Dim dt1 As New System.Data.DataTable
        sql = " select projektant from vISTOdgovorni where SifIST='" + IzIst + "' "

        dt1 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        Dim projektantDok As String = ""
        If dt1.Rows.Count > 0 Then
            If dt1.Rows(0).Item("projektant") Is System.DBNull.Value Then
            Else
                projektantDok = dt1.Rows(0).Item("projektant").ToString.ToUpper.Trim()
            End If
        End If

        Dim dt2 As New System.Data.DataTable
        sql = " select Statisticar from vISTOdgovorni " _
                + " where SifIST='" + IzIst + "' "

        dt2 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

        Dim StatisticarDok As String = ""
        If dt2.Rows.Count > 0 Then
            If dt2.Rows(0).Item("Statisticar") Is System.DBNull.Value Then
            Else
                projektantDok = dt2.Rows(0).Item("Statisticar").ToString.ToUpper.Trim()
            End If
        End If

        Try
            Dim WordApp As Word.Application
            WordApp = New Word.Application
            Dim WordDoc As Word.Document
            With WordApp
                '.Visible = False
                WordDoc = .Documents.Add
            End With
            WordApp.ChangeFileOpenDirectory(folder)
            WordDoc = WordApp.Documents.Open(FileName:="ISTDok.doc", ConfirmConversions:=False,
                ReadOnly:=False, AddToRecentFiles:=False, PasswordDocument:="",
                PasswordTemplate:="", Revert:=False, WritePasswordDocument:="",
                WritePasswordTemplate:="", Format:=Word.WdOpenFormat.wdOpenFormatAuto)

            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="SIfIST")
            WordApp.Selection.TypeText(Text:=IzIstDok)

            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="SIfIST")
            WordApp.Selection.TypeText(Text:=IzIstDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="VRTACKA")
            WordApp.Selection.TypeText(Text:=vtDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="Projektant")
            WordApp.Selection.TypeText(Text:=projektantDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="Statisticar")
            WordApp.Selection.TypeText(Text:=StatisticarDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="Periodika")
            WordApp.Selection.TypeText(Text:=PeriodikaDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="ConnectionString")
            WordApp.Selection.TypeText(Text:=konekcijaDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="Baza")
            WordApp.Selection.TypeText(Text:=pravaBazaDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="SQLupiti")
            WordApp.Selection.TypeText(Text:=SQLUpitiDok)
            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="Server")
            WordApp.Selection.TypeText(Text:=serverDok)

            Dim table As Word.Table

            'validniIntervali
            Dim dt7 As New System.Data.DataTable
            sql = "select *  from  dbo.vISTVIzaDOK ('" + vt + "','" + IzIst + "')"

            dt7 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="validniIntervali")
            table = WordApp.ActiveDocument.Tables.Add(WordApp.Selection.Range, dt7.Rows.Count + 1, dt7.Columns.Count - 1)
            For k As Integer = 0 To dt7.Columns.Count - 2
                table.Cell(1, k + 1).Range.Text = dt7.Columns(k).Caption.ToString.Trim
            Next
            For r As Integer = 0 To dt7.Rows.Count - 1
                For k As Integer = 0 To dt7.Columns.Count - 2
                    If Not dt7.Rows(r).Item(k) Is Nothing Then table.Cell(r + 2, k + 1).Range.Text = dt7.Rows(r).Item(k).ToString.Trim
                Next
            Next
            'ISTTABELE
            Dim dt3 As New System.Data.DataTable
            sql = "select *  from  dbo.vISTTABELEzaDOK ('" + vt + "','" + IzIst + "')"

            dt3 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="ISTTABELE")
            table = WordApp.ActiveDocument.Tables.Add(WordApp.Selection.Range, dt3.Rows.Count + 1, dt3.Columns.Count - 1)
            For k As Integer = 0 To dt3.Columns.Count - 2
                table.Cell(1, k + 1).Range.Text = dt3.Columns(k).Caption.ToString.Trim
            Next
            For r As Integer = 0 To dt3.Rows.Count - 1
                For k As Integer = 0 To dt3.Columns.Count - 2
                    If Not dt3.Rows(r).Item(k) Is Nothing Then table.Cell(r + 2, k + 1).Range.Text = dt3.Rows(r).Item(k).ToString.Trim
                Next
            Next
            'ISTPOLJA
            Dim dt4 As New System.Data.DataTable
            sql = "select *  from  dbo.vISTPOLJAzaDOK ('" + vt + "','" + IzIst + "')"

            dt4 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="ISTPOLJA")
            table = WordApp.ActiveDocument.Tables.Add(WordApp.Selection.Range, dt4.Rows.Count + 1, dt4.Columns.Count - 1)
            For k As Integer = 0 To dt4.Columns.Count - 2
                table.Cell(1, k + 1).Range.Text = dt4.Columns(k).Caption.ToString.Trim
            Next
            For r As Integer = 0 To dt4.Rows.Count - 1
                For k As Integer = 0 To dt4.Columns.Count - 2
                    If Not dt4.Rows(r).Item(k) Is Nothing Then table.Cell(r + 2, k + 1).Range.Text = dt4.Rows(r).Item(k).ToString.Trim
                Next
            Next
            'ISTLK
            Dim dt5 As New System.Data.DataTable
            sql = "select *  from  dbo.vISTLKzaDOK ('" + vt + "','" + IzIst + "')"

            dt5 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="ISTLK")
            table = WordApp.ActiveDocument.Tables.Add(WordApp.Selection.Range, dt5.Rows.Count + 1, dt5.Columns.Count - 1)
            For k As Integer = 0 To dt5.Columns.Count - 2
                table.Cell(1, k + 1).Range.Text = dt5.Columns(k).Caption.ToString.Trim
            Next
            For r As Integer = 0 To dt5.Rows.Count - 1
                For k As Integer = 0 To dt5.Columns.Count - 2
                    If Not dt5.Rows(r).Item(k) Is Nothing Then table.Cell(r + 2, k + 1).Range.Text = dt5.Rows(r).Item(k).ToString.Trim
                Next
            Next
            'ISTTABS
            Dim dt6 As New System.Data.DataTable
            sql = "select *  from  dbo.vISTTABSzaDok ('" + vt + "','" + IzIst + "')"

            dt6 = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)

            WordApp.Selection.GoTo(What:=Word.WdGoToItem.wdGoToBookmark, Name:="ISTTABS")
            table = WordApp.ActiveDocument.Tables.Add(WordApp.Selection.Range, dt6.Rows.Count + 1, dt6.Columns.Count - 1)
            For k As Integer = 0 To dt6.Columns.Count - 2
                table.Cell(1, k + 1).Range.Text = dt6.Columns(k).Caption.ToString.Trim
            Next
            For r As Integer = 0 To dt6.Rows.Count - 1
                For k As Integer = 0 To dt6.Columns.Count - 2
                    If Not dt6.Rows(r).Item(k) Is Nothing Then table.Cell(r + 2, k + 1).Range.Text = dt6.Rows(r).Item(k).ToString.Trim
                Next
            Next
            With WordDoc
                .SaveAs(folder + "ISTDok" + IzIst.Trim + ".doc")
                .Close()
            End With
            WordDoc = Nothing
            WordApp.Quit()
            WordApp = Nothing

            Call End_App("EXCEL", Nothing, Nothing)
            Call End_App("WINWORD", Nothing, Nothing)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            ''msg 134
            Dim msgtxt As String = getMessageText(dtMessages, "134", Me.jezik) + nvrd
            Dim poruka As String = msgtxt + folder
            ISTMessageBox.Show(poruka, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mVodic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mVodic.Click
        program(m_folderZaGen + "\Guides\ISTDeveloperGuide.docx", True)
    End Sub

    Private Sub MICatiGuide_Click(sender As Object, e As EventArgs) Handles MICatiGuide.Click
        program(m_folderZaGen + "\Guides\ISTCatiGuide.docx", True)
    End Sub

    Private Sub mKorisnickoUputstvo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mKorisnickoUputstvo.Click
        program(m_folderZaGen + "\Guides\ISTUserGuide.docx", True)
    End Sub

    Public Sub program(ByVal fn As String, ByVal readOnlyDok As Boolean)
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = fn
        If readOnlyDok = True Then Microsoft.VisualBasic.SetAttr(fn, Microsoft.VisualBasic.vbReadOnly)
        p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Try
            System.Diagnostics.Process.Start(p)
        Catch e As System.Exception
            ISTMessageBox.Show(e.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub

    Private Sub LLImenik_LinkClicked(ByVal sender As System.Object, ByVal e As LinkLabelLinkClickedEventArgs)
        System.Diagnostics.Process.Start("http://www.statsrb.lan/MAIN/Imenik.aspx")
        'aaaa
    End Sub

    Private Sub office()

        Call SetLang()

        If txtoffice.Trim.ToUpper = "PK" Then
            Me.MILanguage.Visible = False
            Me.lblPVT.Visible = True
            Me.lblPVT.Text = "Подаци постоје за временски период:    " + nvrd + dajDEPOPVT()
        End If
    End Sub

    Private Sub mEnglish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mEnglish.Click
        Me.jezik = "EN"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mVIET_Click(sender As Object, e As EventArgs) Handles mVIET.Click
        Me.jezik = "VN"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mAlbanian_Click(sender As Object, e As EventArgs) Handles mAlbanian.Click
        Me.jezik = "SHQ"
        Call SetLang()
        Call office()
    End Sub
    Private Sub mKirgyz_Click(sender As Object, e As EventArgs) Handles mKirgyz.Click
        Me.jezik = "KGZ"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mSrpskiC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mSrpskiC.Click
        Me.jezik = "SRC"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mSrpskiL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mSrpskiL.Click
        Me.jezik = "SRL"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mMneL_Click(sender As Object, e As EventArgs) Handles mMneL.Click
        Me.jezik = "MNE"
        Call SetLang()
        Call office()
    End Sub
    Private Sub mGerL_Click(sender As Object, e As EventArgs) Handles mGerL.Click
        Me.jezik = "GER"
        Call SetLang()
        Call office()
    End Sub
    Private Sub mTurL_Click(sender As Object, e As EventArgs) Handles mTurL.Click
        Me.jezik = "TUR"
        Call SetLang()
        Call office()
    End Sub
    Private Sub mMakC_Click(sender As Object, e As EventArgs) Handles mMakC.Click
        Me.jezik = "MKD"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mItalian_Click(sender As Object, e As EventArgs) Handles mItalian.Click
        Me.jezik = "ITA"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mBulgarian_Click(sender As Object, e As EventArgs) Handles mBulgarian.Click
        Me.jezik = "BG"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mRussian_Click(sender As Object, e As EventArgs) Handles mRussian.Click
        Me.jezik = "RUS"
        Call SetLang()
        Call office()
    End Sub

    Private Sub mUzbek_Click(sender As Object, e As EventArgs) Handles mUzbek.Click
        Me.jezik = "UZ"
        Call SetLang()
        Call office()
    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formIstrazivanje")

        MIAplikacija.Text = getControlText2(dt, "MIAplikacija", Me.jezik)
        MIZO.Text = getControlText2(dt, "MIZO", Me.jezik)
        MIZakljucaj.Text = getControlText2(dt, "MIZakljucaj", Me.jezik)
        MIZakljucajWeb.Text = getControlText2(dt, "MIZakljucajWeb", Me.jezik)
        MIOtkljucaj.Text = getControlText2(dt, "MIOtkljucaj", Me.jezik)
        MIOtkljucajWeb.Text = getControlText2(dt, "MIOtkljucajWeb", Me.jezik)
        MIAdministracija.Text = getControlText2(dt, "MIAdministracija", Me.jezik)
        MIist2xml.Text = getControlText2(dt, "MIist2xml", Me.jezik)
        MIIstUAspax.Text = getControlText2(dt, "MIIstUAspax", Me.jezik)
        MIPodaciXml.Text = getControlText2(dt, "MIPodaciXml", Me.jezik)
        MIXmlPodaci.Text = getControlText2(dt, "MIXmlPodaci", Me.jezik)
        MIProjektanti.Text = getControlText2(dt, "MIProjektanti", Me.jezik)
        MIMreza.Text = getControlText2(dt, "MIMreza", Me.jezik)
        mTehDok.Text = getControlText2(dt, "mTehDok", Me.jezik)
        mVodic.Text = getControlText2(dt, "mVodic", Me.jezik)
        mKorisnickoUputstvo.Text = getControlText2(dt, "mKorisnickoUputstvo", Me.jezik)

        Dim bspace As String = "      "
        ButtonUnos.Text = bspace + getControlText2(dt, "ButtonUnos", Me.jezik)
        ButtonUnos.Tag = ButtonUnos.Text
        ButtonAzuriranje.Text = bspace + getControlText2(dt, "ButtonAzuriranje", Me.jezik)
        ButtonAzuriranje.Tag = ButtonAzuriranje.Text
        ButtonLogickaKontrola.Text = bspace + getControlText2(dt, "ButtonLogickaKontrola", Me.jezik)
        ButtonLogickaKontrola.Tag = ButtonLogickaKontrola.Text
        ButtonAK.Text = bspace + getControlText2(dt, "ButtonAK", Me.jezik)
        ButtonAK.Tag = ButtonAK.Text
        ButtonIzvestaji.Text = bspace + getControlText2(dt, "ButtonIzvestaji", Me.jezik)
        ButtonIzvestaji.Tag = ButtonIzvestaji.Text
        BtnAdvancedSearch.Text = bspace + getControlText2(dt, "ButtonNPretraga", Me.jezik)
        BtnAdvancedSearch.Tag = BtnAdvancedSearch.Text

        btnUnosA.Text = bspace + getControlText2(dt, "btnUnosA", Me.jezik)
        btnUnosA.Tag = btnUnosA.Text
        BtnAzurK.Text = bspace + getControlText2(dt, "BtnAzurK", Me.jezik)
        BtnAzurK.Tag = BtnAzurK.Text

        btnCATI.Tag = btnCATI.Text

        ButtonPromenaIstrazivanja.Text = bspace + getControlText2(dt, "ButtonPromenaIstrazivanja", Me.jezik)
        'bBrojSlogova.Text = getControlText2(dt, "ButtonBrojSlogova", Me.jezik)
        'bPoslednjiDatumSaPodacima.Text = getControlText2(dt, "ButtonPoslednjiDatumSaPodacima", Me.jezik)
        'bValidniIntervali.Text = getControlText2(dt, "ButtonValidniIntervali", Me.jezik)
        bSemiAutomaticCoding.Text = bspace + getControlText2(dt, "ButtonSifriranje", Me.jezik)
        bSemiAutomaticCoding.Tag = bSemiAutomaticCoding.Text


        btnCAPI.Text = bspace + getControlText2(dt, "IstTileCAPI1", Me.jezik)
        btnCAPI.Tag = btnCAPI.Text

        If Me.lblSifra.Text.Trim.ToUpper = "POPIS_21" OrElse Me.lblSifra.Text.Trim.ToUpper = "PES_21" OrElse Me.lblSifra.Text.Trim.ToUpper = "POPTEST" OrElse Me.lblSifra.Text.Trim.ToUpper = "PPES_24" OrElse Me.lblSifra.Text.Trim.ToUpper = "PPES24OK" Then
            BtnAzurK.Visible = False
            lblSifra.Visible = False
        End If

        btnSinhronizacija.Text = getControlText2(dt, "IstCardsCAPI", Me.jezik)
        'bOcena.Text = getControlText2(dt, "buttonOcena", Me.jezik)
        'bLogLK.Text = getControlText2(dt, "buttonLogLK", Me.jezik)

        MIUputstva.Text = getControlText2(dt, "MIUputstva", Me.jezik)

        btnFT1.Text = getControlText2(dt, "ButtonValidniIntervali", Me.jezik)
        btnFT2.Text = getControlText2(dt, "ButtonBrojSlogova", Me.jezik)
        btnFT3.Text = getControlText2(dt, "ButtonPoslednjiDatumSaPodacima", Me.jezik)
        btnFT4.Text = getControlText2(dt, "buttonOcena", Me.jezik)
        btnFT5.Text = getControlText2(dt, "buttonLogLK", Me.jezik)

        PreracunajFooter()

    End Sub

    Private Sub PreracunajFooter()

        btnFTPocetni.Width = 20
        btnFTKraj.Width = 20

        Dim razmak As Integer = (panelFooter.Width - btnFTPocetni.Width - btnFTKraj.Width - btnFT1.Width _
        - btnFT2.Width - btnFT3.Width - btnFT4.Width - btnFT5.Width) / 4

        'btnFT1.Width = 140 + razmak
        'btnFT2.Width = 140 + razmak
        'btnFT3.Width = 140 + razmak
        'btnFT4.Width = 140 + razmak
        'btnFT5.Width = 140 + razmak
        'btnFT6.Width = 140 + razmak

        If razmak > 0 Then
            btnFTRazmak1.Width = razmak
            btnFTRazmak2.Width = razmak
            btnFTRazmak3.Width = razmak
            btnFTRazmak4.Width = razmak
            btnFTRazmak5.Width = razmak
        Else
            btnFTRazmak1.Width = 0
            btnFTRazmak2.Width = 0
            btnFTRazmak3.Width = 0
            btnFTRazmak4.Width = 0
            btnFTRazmak5.Width = 0
        End If

    End Sub

    Private Sub MenuCAPI_Click(sender As Object, e As EventArgs) Handles MenuCAPI.Click

        Me.Cursor = Cursors.WaitCursor
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonCAPI_Click()
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub MenuImportExcel_Click(sender As Object, e As EventArgs) Handles MenuImportExcel.Click
        Me.Cursor = Cursors.WaitCursor
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonImportExcel_Click()
        End If
        Me.Cursor = Cursors.Default
    End Sub


    Dim catiprefix As String
    Private Sub FormIstrazivanje_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If txtmode.Trim.ToUpper.IndexOf("CLOUD") >= 0 Then
            Call UnMapirajAzureDrive()
            'ovde ide logoff ako je cloud
            Dim sifIST As String = Me.lblSifra.Text
            Dim konCATI As String = getConnectionString(Me.CATIServer.Trim, Me.CATIBaza.Trim, txtmode, "")
            Dim sqlCATILogovanje As String = ""
            Dim txtVremeLogOFF As String = trenutnoDatumVremeSaServera()
            If Me.LogovanAnketarCloud.Text <> "" Then
                sqlCATILogovanje = "insert into " + Me.catiprefix + "[ISTCATILogovanje] (sifIST,anketar,onoff,vreme,ko_insert) " _
                + " values('" & sifIST & "','" + Me.LogovanAnketarCloud.Text + "','off','" + txtVremeLogOFF + "','" + Me.LogovanAnketarCloud.Text + "')"
                Dim odg As String = izvrsiSQL(sqlCATILogovanje, konCATI)
                If odg = "nok" Then
                    ''msg 298
                    Dim msgtxt298 As String = getMessageText(dtMessages, "298", Me.jezik)
                    ISTMessageBox.Show(msgtxt298, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If
            Me.LogovanAnketarCloud.Text = ""
        End If
    End Sub
    Private Sub MRefresh_Click(sender As Object, e As EventArgs) Handles MRefresh.Click
        Call MrefreshClick()
    End Sub
    Sub refreshISTAPP()
        'Dim sql As String = "  select distinct ist.Sifist as sifist ,  naziv as Naziv,ist.sifist+' - '+naziv as sifistnaziv from (select sifist,min(vod) as vod from ist group by sifist ) i inner join ist on i.sifist=ist.sifist and i.vod=ist.vod where year(ist.vod)<2100 order by ist.sifist"
        'dtSpisakIST = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)
        popunidtSpisakIST()
        Me.dgvIST.DataSource = dtSpisakIST
    End Sub
    Private Function MrefreshClick() As Boolean
        If txtlogin <> "" Then
            Call refreshISTAPP()
        End If

        MrefreshClick = True
        If Me.postojiISTApp = False Then
            Me.lblSifra.Text = ""
            Me.lblNaziv.Text = "PLEASE, CHOOSE IST APPLICATION"
            txtIST.Focus()
            MrefreshClick = False
            Exit Function
        End If

        Dim app As String = Me.lblSifra.Text

        Dim pomocnoMes As Integer = Me.UserControlVremenskaTacka1.M
        If Me.UserControlVremenskaTacka1.M > 12 Then
            pomocnoMes = 12
        End If
        Dim d As Date = New Date(Me.UserControlVremenskaTacka1.G.ToString, pomocnoMes, 2)
        Dim vtvt As String = d.ToString("yyyy-MM-dd")
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja
        Call puniDatasetIstrazivanja(app, vtvt)
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja
        'puni DatasetIstrazivanja

        Me.Cursor = Cursors.WaitCursor

        If Me.dsIST.IST.Rows.Count = 0 Then
            Me.Cursor = Cursors.Default
            Exit Function
        End If


        Call newnew(ISTConnectionString, Me.rist, dsIST, Nothing,
                    m_folderProgramaZaUnos, appRegKeyL, Nothing, txtpismo, txtoffice, Nothing, txtmode, DSBrisanjeDEPO,
                    DSBrisanjeServer, DSBrisanjeBaza, m_folderZaGen, CATIServer, CATIBaza, CAPIServer, CAPIBaza, PublicDBServer, PublicDBBaza,
                    Nothing, PXMETAApp, PXMETATable, "refresh")

        If txtIST.Enabled = True Then
            txtIST.Focus()
        End If

        Me.Cursor = Cursors.Default
        'ISTMessageBox.Show("Metadata is refreshed!")
    End Function

    Sub puniDatasetIstrazivanja(ByVal app As String, ByVal vtvt As String)
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

        fISTTABELE(Me.dsIST, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)

        fISTNovo2Deo(app, appStaraApl, vtvt, tablesT.Trim.ToUpper)  'ISTOPOLJA, ISTLK
        fISTOstalo(app, appStaraApl, vtvt, tablesT.Trim.ToUpper)

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
                'Dim msgtxt277 As String = getMessageText(dtMessages, "277", Me.jezik)
                'Throw New System.Exception(msgtxt277)
                Dim msgtxt258 As String = getMessageText(dtMessages, "258", Me.jezik)
                ISTMessageBox.Show(msgtxt258)
                Me.txtIST.Focus()
            End If
        Catch ex As System.Exception
            'Dim por As String = "CHECK databaseType (FIZBAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseType THAT DOES NOT EXISTS IN table _ISTDatabaseConnStrings (ISTBAZE)." + nvrd + nvrd +
            '    "CHECK databaseAlias (BAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseAlias THAT DOES NOT EXISTS IN table _IST." + nvrd
            'ISTMessageBox.Show("_IST _ISTDatabaseConnStrings (ISTBAZE) !!!! " + nvrd + por + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Sub fISTNovo2Deo(ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String)
        If Me.dsIST.ISTTABELE.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt2741 As String = getMessageText(dtMessages, "2741", Me.jezik)
            ISTMessageBox.Show(msgtxt2741)
            Exit Sub
        End If
        Dim sqlISTPolja As String = ""
        Dim sqlISTLK As String = ""
        If app <> appStaraApl Then
            sqlISTPolja = "select * from ISTPolja where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
               "  and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
               " and '" + vtvt + "' <= vdo  " +
               " order by tabela,rbr;"
            sqlISTLK = "select SIfIST,TABELA,RbrGreske,replace(GRESKA,'webrelacija','Relacija') as greska,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo" +
                 " from ISTLk " +
                 " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo order by sifIST,tabela,rbrgreske;"
        Else
            'tabele koje postoje u ISTTabele
            Dim ttabele As String = ""
            For i As Integer = 0 To Me.dsIST.ISTTABELE.Rows.Count - 1
                ttabele = ttabele + "'" + DirectCast((Me.dsIST.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
            Next
            ttabele = ttabele.TrimEnd(CType(",", Char()))

            sqlISTPolja = "select * from ISTPolja where sifIST =N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                    " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                    " and '" + vtvt + "' <= vdo  " +
                    " order by tabela,rbr;"
            sqlISTLK = "select SIfIST,TABELA,RbrGreske,replace(GRESKA,'webrelacija','Relacija') as greska,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo" +
              " from ISTLk " +
              " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
              " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
              " and '" + vtvt + "' <= vdo  order by sifIST,tabela,rbrgreske; "
        End If

        Dim ssql As String = sqlISTPolja + sqlISTLK

        Dim ds As New System.Data.DataSet
        ds = izvrsiSQLvratiDS(ssql, Me.ISTConnectionString, Nothing)
        If app <> appStaraApl Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i)("sifIST") = app
            Next
            Call promenaMETA(tablesT, ds.Tables(0), False, True)
        End If

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


        If app <> appStaraApl Then
            For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
                ds.Tables(1).Rows(i)("sifIST") = app
            Next
            Call promenaMETA(tablesT, ds.Tables(1),,,,, True)
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

    Sub fISTTABELE(ByVal ds As DatasetIstrazivanja, ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String)

        Dim sql As String = ""
        If app <> appStaraApl Then
            sql = "select * from ISTTabele where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
                    " and vod <= Convert(DateTime, DateAdd(Month, DateDiff(Month, 0, '" + vtvt + "'), 0), 126) " +
                    " and '" + vtvt + "' <= vdo and isnull(T1,'') not like '%ISTVIEW%'" +
                    " order by baza"
        Else
            sql = "select * from ISTTabele where sifIST=N'" + appStaraApl.Trim + "'" +
                    " and vod <= Convert(DateTime, DateAdd(Month, DateDiff(Month, 0, '" + vtvt + "'), 0), 126) " +
                    " and '" + vtvt + "' <= vdo and isnull(T1,'') not like '%ISTVIEW%'" +
                    " order by baza"
        End If

        Try
            Dim dtIST As System.Data.DataTable = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)
            ds.ISTTABELE.Clear()

            For i As Integer = 0 To dtIST.Rows.Count - 1
                ds.ISTTABELE.ImportRow(dtIST.Rows(i))
            Next

            If app <> appStaraApl Then
                For i As Integer = 0 To ds.ISTTABELE.Rows.Count - 1
                    ds.ISTTABELE.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, ds.ISTTABELE, True, False, True, True)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub fISTOstalo(ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String)

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

        If app <> appStaraApl Then
            sqlISTAWLs = " select * from ISTAWLs" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                  " and '" + vtvt + "' <= vdo  " +
                  " order by tabela,polje;"
            sqlISTQuestionExplanation = " select * from ISTQuestionExplanation" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                  " and '" + vtvt + "' <= vdo  " +
                  " order by tabela,polje;"
            sqlISTLabels = " select * from ISTLabels" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                  " and '" + vtvt + "' <= vdo  " +
                  " order by tabela,polje;"
        Else
            'tabele koje postoje u ISTTabele
            Dim ttabele As String = ""
            For i As Integer = 0 To Me.dsIST.ISTTABELE.Rows.Count - 1
                ttabele = ttabele + "'" + DirectCast((Me.dsIST.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
            Next
            ttabele = ttabele.TrimEnd(CType(",", Char()))

            sqlISTAWLs = "select * from ISTAWLs " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo  " +
                 " order by tabela,polje;"
            sqlISTQuestionExplanation = "select * from ISTQuestionExplanation " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo  " +
                 " order by tabela,polje;"
            sqlISTLabels = "select * from ISTLabels " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo  " +
                 " order by tabela,polje;"
        End If

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
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtAWL.Rows.Count - 1
                    mdtAWL.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, mdtAWL, False, True)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtQE = ds.Tables(2)
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtQE.Rows.Count - 1
                    mdtQE.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, mdtQE, False, True)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtLabel = ds.Tables(3)
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtLabel.Rows.Count - 1
                    mdtLabel.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, mdtLabel, False, True)
            End If
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

    Sub promenaMETA(ByVal tablesT As String, ByVal dt As System.Data.DataTable,
                Optional nadtabela As Boolean = False, Optional izraz As Boolean = False, Optional T1 As Boolean = False, Optional T2 As Boolean = False, Optional greska As Boolean = False)
        Dim prom As Boolean = False
        If tablesT <> "" Then
            Dim pp() As String = tablesT.Trim.Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "").Split(CType(",", Char()))
            For i As Integer = 0 To pp.GetUpperBound(0)
                prom = False
                Dim kk() As String = pp(i).Split(CType("=", Char()))
                If kk.Length = 2 AndAlso kk(0) <> "" AndAlso kk(1) <> "" Then
                    If kk(0) <> kk(1) Then
                        Dim kkL As String = kk(0) : Dim kkD As String = kk(1)
                        For ii As Integer = 0 To dt.Rows.Count - 1
                            If dt.Rows(ii)("tabela").ToString.Trim.ToUpper = kk(0) Then
                                dt.Rows(ii)("tabela") = kk(1)
                                prom = True
                            End If

                            If nadtabela = True AndAlso dt.Rows(ii)("nadtabela").ToString.Trim.ToUpper = kk(0) Then dt.Rows(ii)("nadtabela") = kk(1)

                            If T1 = True AndAlso dt.Rows(ii)("t1").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("t1").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("t1") = iizz
                            End If
                            If T2 = True AndAlso dt.Rows(ii)("t2").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("t2").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("t2") = iizz
                            End If

                            If izraz = True AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("SELECT") >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("izraz").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) AndAlso bbb(ll - 1) = "FROM" Then
                                        bbb(ll) = kk(1)
                                    End If
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("izraz") = iizz
                            End If
                            If izraz = True AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                                dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf(".") > 0 AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("}") > 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("izraz").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) AndAlso bbb(ll - 1) = "{" AndAlso bbb.GetUpperBound(0) >= ll + 1 AndAlso bbb(ll + 1) = "." Then
                                        bbb(ll) = kk(1)
                                    End If
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("izraz") = iizz
                            End If
                            If izraz = True AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                                dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf(".") > 0 AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("}") > 0 AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("SELECT") < 0 Then
                                Dim nn As String = dt.Rows(ii)("izraz").ToString.Trim.ToUpper
                                nn = nn.Replace(kk(0).Trim.ToUpper, kk(1).Trim.ToUpper)
                                dt.Rows(ii)("izraz") = nn
                            End If
                            If greska = True AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("greska").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("greska") = iizz
                            End If
                            If greska = True AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                               dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("RELACIJA") > 0 AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("}") > 0 AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("SELECT") < 0 Then
                                Dim nn As String = dt.Rows(ii)("greska").ToString.Trim.ToUpper
                                nn = nn.Replace(kk(0).Trim.ToUpper, kk(1).Trim.ToUpper)
                                dt.Rows(ii)("greska") = nn
                            End If
                        Next
                    End If
                End If
            Next
        End If
    End Sub
    Private Sub fISTgetAwlQELabelsMeassages()
        Dim app As String = Me.lblSifra.Text
        Dim appStaraApl As String = app : Dim appR As String = app : Dim tablesT As String = "" 'tabele, polja i LK moraju da budu iz iste app

        If Not m_zadaciVremenskaTacka.dsdsIST.IST.Rows(0).Item("Abaza") Is System.DBNull.Value Then
            Dim additionalParameters As String = m_zadaciVremenskaTacka.dsdsIST.IST.Rows(0).Item("Abaza").ToString.Trim.ToUpper
            Dim pp() As String = additionalParameters.Split(CType(";", Char()))
            For i As Integer = 0 To pp.GetUpperBound(0)
                Dim kk() As String = pp(i).Split(CType("=", Char()))
                If kk.Length = 2 AndAlso kk(0) <> "" AndAlso kk(1) <> "" Then
                    If kk(0) = "ISTTABELE" OrElse kk(0) = "ISTTABLES" Then appStaraApl = kk(1)
                    If kk(0) = "ISTTABS" OrElse kk(0) = "ISTREPORTSPROCEDURES" Then appR = kk(1)
                    If kk(0) <> "ISTTABELE" AndAlso kk(0) <> "ISTTABLES" AndAlso kk(0) <> "ISTTABS" AndAlso kk(0) <> "ISTREPORTSPROCEDURES" Then
                        tablesT = tablesT + ";" + pp(i)
                    End If
                End If
            Next

            'provera da li je ista baza za istrazivanja NE MORA MOZDA JE ISTA APP NA RAZLICITIM SERVERIMA
            'app=appStaraApl=appR
            'If checkBaza(app, appStaraApl, appR, Me.istConnectionString, Me.jezik) = False Then
            '    appStaraApl = app : appR = app
            '    ISTMessageBox.Show("Error in METADATA. Back end databases for are not the same!")
            'End If
        End If

        Dim godina As Integer = CInt(Me.m_zadaciVremenskaTacka.ucvt.G)
        Dim mesec As Integer = CInt(Me.m_zadaciVremenskaTacka.ucvt.M)

        Dim d As Date = New Date(godina, mesec, 2)
        '2017-09-19 00:34:43.087 mi treba
        Dim vtvt As String = d.ToString("yyyy-MM-dd")


        Dim sqlISTAwls As String = "select * from ISTAwls where sifIST='" + app + "' " +
        " And vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
        " And '" + vtvt + "' <= vdo  " +
        " order by tabela,polje;"
        Dim sqlISTQuestionExplanation As String = "select * from ISTQuestionExplanation where sifIST='" + app + "' " +
        " And vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
        " And '" + vtvt + "' <= vdo  " +
        " order by tabela,polje;"
        Dim sqlISTlabels As String = "select * from ISTlabels where sifIST='" + app + "' " +
        " And vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
        " And '" + vtvt + "' <= vdo  " +
        " order by tabela,polje;"
        Dim sqlISTmessages As String = "select * from ISTmessages where sifIST='" + app + "' " +
        " And vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
        " And '" + vtvt + "' <= vdo  " +
        " order by idlang,idmsg;"

        Dim ssql As String = sqlISTAwls + sqlISTQuestionExplanation + sqlISTlabels + sqlISTmessages

        Dim ds As System.Data.DataSet = izvrsiSQLvratiDS(ssql, Me.ISTConnectionString, Nothing)


        mdtAWL = ds.Tables(0)
        Call promenaMETA(tablesT, mdtAWL)

        mdtQE = ds.Tables(1)
        Call promenaMETA(tablesT, mdtQE)

        mdtLabel = ds.Tables(2)
        Call promenaMETA(tablesT, mdtLabel)

        mdtMessage = ds.Tables(3)
        Call promenaMETA(tablesT, mdtMessage)
    End Sub


    Private Sub MenuItem4_Click(sender As Object, e As EventArgs) Handles mNasL.Click
        Me.jezik = "SRL"
        Call SetLang()
        Call office()
    End Sub
    Dim NePustamUnos As Boolean = False
    Public Sub CAPICensus(ByVal Optional bcapimode As Boolean = True)
        'Me.txtmode = "CAPITEST"
        'Dim overlayHandleISTLoading As ISTFormIsLoading
        'overlayHandleISTLoading = New ISTFormIsLoading(Nothing, Me, True)
        'overlayHandleISTLoading.Show()
        NePustamUnos = False
        Dim appcode As String = Me.lblSifra.Text
        If appcode.Trim.ToUpper = "POPIS_21" OrElse appcode.Trim.ToUpper = "POPTEST" Then

            If bcapimode = True Then
                If MrefreshClick() = False Then Exit Sub
            End If

            If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
                Dim koSamPom As String = ""
                Dim koSam As String = ""
                Me.DBConnectionString = connectionString
                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
                    koSamPom = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)

                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSamPom = GetUserNameZ()
                Else
                    koSamPom = GetUserNameIzBaze(Me.DBConnectionString)
                End If

                If koSamPom = "" Then
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT("select suser_sname() as sn", DBConnectionString, Me.jezik)
                    If dt.Rows.Count > 0 Then
                        koSamPom = dt.Rows(0).Item("sn").ToString.Trim
                    End If
                End If

                If koSamPom.Trim.ToUpper.IndexOf("STATSRB\") >= 0 OrElse koSamPom.Trim.ToUpper.IndexOf("IB15530\KORISNIK") >= 0 Then
                    koSam = kojianketar(koSamPom, Me.DBConnectionString)
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSam = GetUserNameZ()
                Else
                    koSam = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                End If


                If koSam = "" Then
                    ISTMessageBox.Show("Nemate dozvole za ulazak u aplikaciju")
                    Exit Sub
                End If

                Dim strSQl As String = " select cast(count(*) as varchar(4)) as BrojVracenihStanovaBroj " + nvrd +
                                       " from adresar " + nvrd +
                                       " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                Dim BrojVracenihStanovaBroj As String = "0"
                Dim dt1 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)

                Dim strSQlpk As String = " select distinct left(krug_idcd,4) as krugovi " + nvrd +
                                       " from adresar " + nvrd +
                                       " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                Dim krugoviVracenih As String = ""
                Dim dtpk As System.Data.DataTable = izvrsiSQLvratiDT(strSQlpk, DBConnectionString, Me.jezik)
                If dtpk.Rows.Count > 0 Then
                    For i As Integer = 0 To dtpk.Rows.Count - 1
                        krugoviVracenih = krugoviVracenih + dtpk.Rows(i).Item("krugovi").ToString.Trim + ", "
                    Next
                    krugoviVracenih = krugoviVracenih.Trim.TrimEnd(",")
                End If

                If dt1.Rows.Count > 0 Then
                    BrojVracenihStanovaBroj = dt1.Rows(0).Item("BrojVracenihStanovaBroj").ToString.Trim
                End If
                lblBrojVracenihStanovaBroj.Text = BrojVracenihStanovaBroj
                If BrojVracenihStanovaBroj > 0 Then
                    lblBrojVracenihStanova.ForeColor = Color.DarkRed
                    lblBrojVracenihStanovaBroj.ForeColor = Color.DarkRed
                    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:" + nvrd + krugoviVracenih
                    lblKrugoviDorada.Visible = True
                Else
                    lblBrojVracenihStanova.ForeColor = Color.Black
                    lblBrojVracenihStanovaBroj.ForeColor = Color.Black
                    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:"
                    lblKrugoviDorada.Visible = False
                End If

                strSQl = " select cast(count(*) as varchar(4)) as BrojQCBroj " + nvrd +
                                " from adresar " + nvrd +
                                " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=1"
                Dim BrojQCBroj As String = "0"
                Dim dt2 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt2.Rows.Count > 0 Then
                    BrojQCBroj = dt2.Rows(0).Item("BrojQCBroj").ToString.Trim
                End If
                lblBrojQCBroj.Text = BrojQCBroj

                strSQl = " select cast(count(*) as varchar(4)) as BrojPoslatihBroj " + nvrd +
                       " from adresar " + nvrd +
                       " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=2"
                Dim BrojPoslatihBroj As String = "0"
                Dim dt3 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt3.Rows.Count > 0 Then
                    BrojPoslatihBroj = dt3.Rows(0).Item("BrojPoslatihBroj").ToString.Trim
                End If
                lblBrojPoslatihBroj.Text = BrojPoslatihBroj

                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then
                    Dim konCAPI As String = getConnectionString(Me.CAPIServer.Trim, Me.CAPIBaza.Trim, txtmode, "")
                    Dim strNeuspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('popis_21','') and anketarnalog='" + koSam + "' and statusakcije='ERROR'"
                    Dim dtNeuspesno As System.Data.DataTable = izvrsiSQLvratiDT(strNeuspesno, konCAPI, Me.jezik)
                    If Not dtNeuspesno Is Nothing AndAlso dtNeuspesno.Rows.Count > 0 AndAlso dtNeuspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                        Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtNeuspesno.Rows(0).Item(0).ToString + " - neuspešna"
                        Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                        lblPorukaSinhronizacija.Visible = True
                        NePustamUnos = True
                    Else
                        Dim strUspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('popis_21','') and anketarnalog='" + koSam + "' and statusakcije='OK'"
                        Dim dtUspesno As System.Data.DataTable = izvrsiSQLvratiDT(strUspesno, konCAPI, Me.jezik)
                        If Not dtUspesno Is Nothing AndAlso dtUspesno.Rows.Count > 0 AndAlso dtUspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                            Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtUspesno.Rows(0).Item(0).ToString + " - uspešna"
                            Me.lblSinhrNeuspesno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = False
                        Else
                            Me.lblSinhrNeuspesno.Text = ""
                            Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = True
                        End If
                    End If

                    If bcapimode = True Then Call capiMode(appcode)

                    Dim str As String = " select datediff(day,max(DatumAkcije),getdate()) from istcapi.dbo.StatusAkcijaLocal " + nvrd +
                                        " where akcijaid in (20,30) and trim(sifIST) in ('popis_21','') and anketarnalog='" + koSam + "'"
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(str, konCAPI, Me.jezik)


                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item(0) > 1 AndAlso dt.Rows(0).Item(0).ToString.Trim <> "" Then
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                    End If


                    Me.mMneL.Visible = False
                    Me.mVIET.Visible = False
                    Me.mItalian.Visible = False
                    Me.mMakC.Visible = False
                    Me.mUzbek.Visible = False
                    Me.mAlbanian.Visible = False
                    Me.mKirgyz.Visible = False
                    Me.mNasL.Visible = False
                    Me.mBulgarian.Visible = False
                    Me.mGerL.Visible = False
                    Me.mEnglish.Visible = False
                    Me.mRussian.Visible = False
                    Me.mTurL.Visible = False


                End If

                If bcapimode = True Then Call capiMode(appcode)

            End If



        ElseIf appcode.Trim.ToUpper = "PES_21" Then

            If bcapimode = True Then
                If MrefreshClick() = False Then Exit Sub
            End If

            If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
                Dim koSamPom As String = ""
                Dim koSam As String = ""
                Me.DBConnectionString = connectionString
                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
                    koSamPom = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                    'ElseIf anketarcloud <> "" OrElse txtmode = "CLOUD" Then
                    '    koSam = anketarcloud
                    '    txtcloudcati = True
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSamPom = GetUserNameZ()
                Else
                    koSamPom = GetUserNameIzBaze(Me.DBConnectionString)
                End If

                If koSamPom = "" Then
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT("select suser_sname() as sn", DBConnectionString, Me.jezik)
                    If dt.Rows.Count > 0 Then
                        koSamPom = dt.Rows(0).Item("sn").ToString.Trim
                    End If
                End If

                If koSamPom.Trim.ToUpper.IndexOf("STATSRB\") >= 0 OrElse koSamPom.Trim.ToUpper.IndexOf("IB15530\KORISNIK") >= 0 Then
                    koSam = kojianketar(koSamPom, Me.DBConnectionString)
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSam = GetUserNameZ()
                Else
                    koSam = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                End If


                If koSam = "" Then
                    ISTMessageBox.Show("Nemate dozvole za ulazak u aplikaciju")
                    Exit Sub
                End If

                Dim strSQl As String = " select cast(count(*) as varchar(4)) as BrojVracenihStanovaBroj " + nvrd +
                                       " from adresar " + nvrd +
                                       " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                Dim BrojVracenihStanovaBroj As String = "0"
                Dim dt1 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)

                Dim strSQlpk As String = " select distinct left(krug_idcd,4) as krugovi " + nvrd +
                                       " from adresar " + nvrd +
                                       " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                Dim krugoviVracenih As String = ""
                Dim dtpk As System.Data.DataTable = izvrsiSQLvratiDT(strSQlpk, DBConnectionString, Me.jezik)
                If dtpk.Rows.Count > 0 Then
                    For i As Integer = 0 To dtpk.Rows.Count - 1
                        krugoviVracenih = krugoviVracenih + dtpk.Rows(i).Item("krugovi").ToString.Trim + ", "
                    Next
                    krugoviVracenih = krugoviVracenih.Trim.TrimEnd(",")
                End If

                If dt1.Rows.Count > 0 Then
                    BrojVracenihStanovaBroj = dt1.Rows(0).Item("BrojVracenihStanovaBroj").ToString.Trim
                End If
                lblBrojVracenihStanovaBroj.Text = BrojVracenihStanovaBroj
                If BrojVracenihStanovaBroj > 0 Then
                    lblBrojVracenihStanova.ForeColor = Color.DarkRed
                    lblBrojVracenihStanovaBroj.ForeColor = Color.DarkRed
                    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:" + nvrd + krugoviVracenih
                    lblKrugoviDorada.Visible = True
                Else
                    lblBrojVracenihStanova.ForeColor = Color.Black
                    lblBrojVracenihStanovaBroj.ForeColor = Color.Black
                    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:"
                    lblKrugoviDorada.Visible = False
                End If

                strSQl = " select cast(count(*) as varchar(4)) as BrojQCBroj " + nvrd +
                                " from adresar " + nvrd +
                                " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=1"
                Dim BrojQCBroj As String = "0"
                Dim dt2 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt2.Rows.Count > 0 Then
                    BrojQCBroj = dt2.Rows(0).Item("BrojQCBroj").ToString.Trim
                End If
                lblBrojQCBroj.Text = BrojQCBroj

                strSQl = " select cast(count(*) as varchar(4)) as BrojPoslatihBroj " + nvrd +
                       " from adresar " + nvrd +
                       " where IDANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=2"
                Dim BrojPoslatihBroj As String = "0"
                Dim dt3 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt3.Rows.Count > 0 Then
                    BrojPoslatihBroj = dt3.Rows(0).Item("BrojPoslatihBroj").ToString.Trim
                End If
                lblBrojPoslatihBroj.Text = BrojPoslatihBroj




                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then
                    Dim konCAPI As String = getConnectionString(Me.CAPIServer.Trim, Me.CAPIBaza.Trim, txtmode, "")
                    Dim strNeuspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('pes_21','') and anketarnalog='" + koSam + "' and statusakcije='ERROR'"
                    Dim dtNeuspesno As System.Data.DataTable = izvrsiSQLvratiDT(strNeuspesno, konCAPI, Me.jezik)
                    If Not dtNeuspesno Is Nothing AndAlso dtNeuspesno.Rows.Count > 0 AndAlso dtNeuspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                        Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtNeuspesno.Rows(0).Item(0).ToString + " - neuspešna"
                        Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                        lblPorukaSinhronizacija.Visible = True
                        NePustamUnos = True
                    Else
                        Dim strUspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('pes_21','') and anketarnalog='" + koSam + "' and statusakcije='OK'"
                        Dim dtUspesno As System.Data.DataTable = izvrsiSQLvratiDT(strUspesno, konCAPI, Me.jezik)
                        If Not dtUspesno Is Nothing AndAlso dtUspesno.Rows.Count > 0 AndAlso dtUspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                            Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtUspesno.Rows(0).Item(0).ToString + " - uspešna"
                            Me.lblSinhrNeuspesno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = False
                        Else
                            Me.lblSinhrNeuspesno.Text = ""
                            Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = True
                        End If
                    End If

                    If bcapimode = True Then Call capiMode(appcode)

                    Dim str As String = " select datediff(day,max(DatumAkcije),getdate()) from istcapi.dbo.StatusAkcijaLocal " + nvrd +
                                        " where akcijaid in (20,30) and trim(sifIST) in ('pes_21','') and anketarnalog='" + koSam + "'"
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(str, konCAPI, Me.jezik)


                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item(0) > 1 AndAlso dt.Rows(0).Item(0).ToString.Trim <> "" Then
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                    End If



                End If
                Me.mMneL.Visible = False
                Me.mVIET.Visible = False
                Me.mItalian.Visible = False
                Me.mMakC.Visible = False
                Me.mUzbek.Visible = False
                Me.mAlbanian.Visible = False
                Me.mKirgyz.Visible = False
                Me.mNasL.Visible = False
                Me.mBulgarian.Visible = False
                Me.mGerL.Visible = False
                Me.mEnglish.Visible = False
                Me.mRussian.Visible = False
                Me.mTurL.Visible = False
                If bcapimode = True Then Call capiMode(appcode)

            End If




        ElseIf appcode.Trim.ToUpper = "xPPOLJO" Then

            If bcapimode = True Then
                If MrefreshClick() = False Then Exit Sub
            End If

            If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
                Dim koSamPom As String = ""
                Dim koSam As String = ""
                Me.DBConnectionString = connectionString
                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
                    koSamPom = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                    'ElseIf anketarcloud <> "" OrElse txtmode = "CLOUD" Then
                    '    koSam = anketarcloud
                    '    txtcloudcati = True
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSamPom = GetUserNameZ()
                Else
                    koSamPom = GetUserNameIzBaze(Me.DBConnectionString)
                End If

                If koSamPom = "" Then
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT("select suser_sname() as sn", DBConnectionString, Me.jezik)
                    If dt.Rows.Count > 0 Then
                        koSamPom = dt.Rows(0).Item("sn").ToString.Trim
                    End If
                End If

                If txtmode.Trim.ToUpper = "Z" OrElse koSamPom.Trim.ToUpper.IndexOf("STATSRB\") >= 0 OrElse koSamPom.Trim.ToUpper.IndexOf("IB15530\KORISNIK") >= 0 Then
                    koSam = kojianketar(koSamPom, Me.DBConnectionString)
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSam = GetUserNameZ()
                Else
                    koSam = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                End If

                lblKrugoviDorada.Visible = False
                lblBrojPoslatih.Text = "Do sada poslato gazdinstava:"
                lblBrojQC.Text = "Spremnih gazdinstava za slanje:"
                lblBrojVracenihStanova.Text = "Vraćeno gazdinstava na doradu:"

                lblBrojPoslatihBroj.Location = New System.Drawing.Point(lblBrojVracenihStanova.Location.X + lblBrojVracenihStanova.Width + 10, lblBrojPoslatihBroj.Location.Y)
                lblBrojQCBroj.Location = New System.Drawing.Point(lblBrojVracenihStanova.Location.X + lblBrojVracenihStanova.Width + 10, lblBrojQCBroj.Location.Y)
                lblBrojVracenihStanovaBroj.Location = New System.Drawing.Point(lblBrojVracenihStanova.Location.X + lblBrojVracenihStanova.Width + 10, lblBrojVracenihStanovaBroj.Location.Y)

                Dim strSQl As String = " select cast(count(*) as varchar(4)) as BrojVracenihDom " + nvrd +
                                       " from adresar " + nvrd +
                                       " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                Dim BrojVracenihDom As String = "0"
                Dim dt1 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)

                'Dim strSQlpk As String = " select distinct left(krug_idcd,4) as krugovi " + nvrd +
                '                       " from adresar " + nvrd +
                '                       " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                'Dim krugoviVracenih As String = ""
                'Dim dtpk As System.Data.DataTable = izvrsiSQLvratiDT(strSQlpk, DBConnectionString, Me.jezik)
                'If dtpk.Rows.Count > 0 Then
                '    For i As Integer = 0 To dtpk.Rows.Count - 1
                '        krugoviVracenih = krugoviVracenih + dtpk.Rows(i).Item("krugovi").ToString.Trim + ", "
                '    Next
                '    krugoviVracenih = krugoviVracenih.Trim.TrimEnd(",")
                'End If

                If dt1.Rows.Count > 0 Then
                    BrojVracenihDom = dt1.Rows(0).Item("BrojVracenihDom").ToString.Trim
                End If
                lblBrojVracenihStanovaBroj.Text = BrojVracenihDom
                'If BrojVracenihStanovaBroj > 0 Then
                '    lblBrojVracenihStanova.ForeColor = Color.DarkRed
                '    lblBrojVracenihStanovaBroj.ForeColor = Color.DarkRed
                '    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:" + nvrd + krugoviVracenih
                '    lblKrugoviDorada.Visible = True
                'Else
                '    lblBrojVracenihStanova.ForeColor = Color.Black
                '    lblBrojVracenihStanovaBroj.ForeColor = Color.Black
                '    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:"
                '    lblKrugoviDorada.Visible = False
                'End If

                strSQl = " select cast(count(*) as varchar(4)) as BrojQCBroj " + nvrd +
                                " from adresar " + nvrd +
                                " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=1"
                Dim BrojQCBroj As String = "0"
                Dim dt2 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt2.Rows.Count > 0 Then
                    BrojQCBroj = dt2.Rows(0).Item("BrojQCBroj").ToString.Trim
                End If
                lblBrojQCBroj.Text = BrojQCBroj

                strSQl = " select cast(count(*) as varchar(4)) as BrojPoslatihBroj " + nvrd +
                       " from adresar " + nvrd +
                       " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=2"
                Dim BrojPoslatihBroj As String = "0"
                Dim dt3 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt3.Rows.Count > 0 Then
                    BrojPoslatihBroj = dt3.Rows(0).Item("BrojPoslatihBroj").ToString.Trim
                End If
                lblBrojPoslatihBroj.Text = BrojPoslatihBroj


                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then
                    Dim konCAPI As String = getConnectionString(Me.CAPIServer.Trim, Me.CAPIBaza.Trim, txtmode, "")
                    Dim strNeuspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('ppoljo','') and anketarnalog='" + koSam + "' and statusakcije='ERROR'"
                    Dim dtNeuspesno As System.Data.DataTable = izvrsiSQLvratiDT(strNeuspesno, konCAPI, Me.jezik)
                    If Not dtNeuspesno Is Nothing AndAlso dtNeuspesno.Rows.Count > 0 AndAlso dtNeuspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                        Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtNeuspesno.Rows(0).Item(0).ToString + " - neuspešna"
                        Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                        lblPorukaSinhronizacija.Visible = True
                        NePustamUnos = True
                    Else
                        Dim strUspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('ppoljo','') and anketarnalog='" + koSam + "' and statusakcije='OK'"
                        Dim dtUspesno As System.Data.DataTable = izvrsiSQLvratiDT(strUspesno, konCAPI, Me.jezik)
                        If Not dtUspesno Is Nothing AndAlso dtUspesno.Rows.Count > 0 AndAlso dtUspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                            Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtUspesno.Rows(0).Item(0).ToString + " - uspešna"
                            Me.lblSinhrNeuspesno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = False
                        Else
                            Me.lblSinhrNeuspesno.Text = ""
                            Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = True
                        End If
                    End If

                    If bcapimode = True Then Call capiMode(appcode)

                    Dim str As String = " select datediff(day,max(DatumAkcije),getdate()) from istcapi.dbo.StatusAkcijaLocal " + nvrd +
                                        " where akcijaid in (20,30) and trim(sifIST) in ('ppoljo','') and anketarnalog='" + koSam + "'"
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(str, konCAPI, Me.jezik)


                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item(0) > 1 AndAlso dt.Rows(0).Item(0).ToString.Trim <> "" Then
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                    End If

                End If


                Me.mMneL.Visible = False
                Me.mVIET.Visible = False
                Me.mItalian.Visible = False
                Me.mMakC.Visible = False
                Me.mUzbek.Visible = False
                Me.mAlbanian.Visible = False
                Me.mKirgyz.Visible = False
                Me.mNasL.Visible = False
                Me.mBulgarian.Visible = False
                Me.mGerL.Visible = False
                Me.mEnglish.Visible = False
                Me.mRussian.Visible = False
                Me.mTurL.Visible = False
                If koSam = "" Then
                    ISTMessageBox.Show("Nemate dozvole za ulazak u aplikaciju")
                    Exit Sub
                End If
                If bcapimode = True Then Call capiMode(appcode)

            End If
        ElseIf appcode.Trim.ToUpper = "PPOLJO23" Then

            If bcapimode = True Then
                If MrefreshClick() = False Then Exit Sub
            End If

            If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
                Dim koSamPom As String = ""
                Dim koSam As String = ""
                Me.DBConnectionString = connectionString
                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
                    koSamPom = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                    'ElseIf anketarcloud <> "" OrElse txtmode = "CLOUD" Then
                    '    koSam = anketarcloud
                    '    txtcloudcati = True
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSamPom = GetUserNameZ()
                ElseIf txtmode.Trim.ToUpper = "Z" AndAlso txtlogin = "TRUE" Then
                    koSamPom = GetUserNameZ()
                ElseIf txtmode.Trim.ToUpper = "Z" AndAlso txtlogin <> "TRUE" Then
                    GetUserNameIzBaze(Me.DBConnectionString)
                Else
                    koSamPom = GetUserNameIzBaze(Me.DBConnectionString)
                End If

                If koSamPom = "" Then
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT("select suser_sname() as sn", DBConnectionString, Me.jezik)
                    If dt.Rows.Count > 0 Then
                        koSamPom = dt.Rows(0).Item("sn").ToString.Trim
                    End If
                End If

                If koSamPom.Trim.ToUpper.IndexOf("STATSRB\") >= 0 OrElse koSamPom.Trim.ToUpper.IndexOf("IB15530\KORISNIK") >= 0 Then
                    koSam = kojianketar(koSamPom, Me.DBConnectionString)
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" OrElse koSamPom.Trim.ToUpper.IndexOf("STATSRB\") < 0 Then
                    koSam = GetUserNameZ()
                Else
                    koSam = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                End If

                Me.mMneL.Visible = False
                Me.mVIET.Visible = False
                Me.mItalian.Visible = False
                Me.mMakC.Visible = False
                Me.mUzbek.Visible = False
                Me.mAlbanian.Visible = False
                Me.mKirgyz.Visible = False
                Me.mNasL.Visible = False
                Me.mBulgarian.Visible = False
                Me.mGerL.Visible = False
                Me.mEnglish.Visible = False
                Me.mRussian.Visible = False
                Me.mTurL.Visible = False
                If koSam = "" Then
                    ISTMessageBox.Show("Nemate dozvole za ulazak u aplikaciju")
                    Exit Sub
                End If
                If bcapimode = True Then Call capiMode(appcode)

            End If
        ElseIf appcode.Trim.ToUpper = "PPES_24" Then

            If bcapimode = True Then
                If MrefreshClick() = False Then Exit Sub
            End If

            If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
                Dim koSamPom As String = ""
                Dim koSam As String = ""
                Me.DBConnectionString = connectionString
                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
                    koSamPom = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                    'ElseIf anketarcloud <> "" OrElse txtmode = "CLOUD" Then
                    '    koSam = anketarcloud
                    '    txtcloudcati = True
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSamPom = GetUserNameZ()
                Else
                    koSamPom = GetUserNameIzBaze(Me.DBConnectionString)
                End If

                If koSamPom = "" Then
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT("select suser_sname() as sn", DBConnectionString, Me.jezik)
                    If dt.Rows.Count > 0 Then
                        koSamPom = dt.Rows(0).Item("sn").ToString.Trim
                    End If
                End If

                If txtmode.Trim.ToUpper = "Z" OrElse koSamPom.Trim.ToUpper.IndexOf("STATSRB\") >= 0 OrElse koSamPom.Trim.ToUpper.IndexOf("IB15530\KORISNIK") >= 0 Then
                    koSam = kojianketar(koSamPom, Me.DBConnectionString)
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSam = GetUserNameZ()
                Else
                    koSam = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                End If

                lblKrugoviDorada.Visible = False
                lblBrojPoslatih.Text = "Do sada poslato gazdinstava:"
                lblBrojQC.Text = "Spremnih gazdinstava za slanje:"
                lblBrojVracenihStanova.Text = "Vraćeno gazdinstava na doradu:"

                lblBrojPoslatihBroj.Location = New System.Drawing.Point(lblBrojVracenihStanova.Location.X + lblBrojVracenihStanova.Width + 10, lblBrojPoslatihBroj.Location.Y)
                lblBrojQCBroj.Location = New System.Drawing.Point(lblBrojVracenihStanova.Location.X + lblBrojVracenihStanova.Width + 10, lblBrojQCBroj.Location.Y)
                lblBrojVracenihStanovaBroj.Location = New System.Drawing.Point(lblBrojVracenihStanova.Location.X + lblBrojVracenihStanova.Width + 10, lblBrojVracenihStanovaBroj.Location.Y)

                Dim strSQl As String = " select cast(count(*) as varchar(4)) as BrojVracenihDom " + nvrd +
                                       " from adresar " + nvrd +
                                       " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                Dim BrojVracenihDom As String = "0"
                Dim dt1 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)

                'Dim strSQlpk As String = " select distinct left(krug_idcd,4) as krugovi " + nvrd +
                '                       " from adresar " + nvrd +
                '                       " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=0 and (isnull(USER_statusAnketar,'') like 'I7%' or isnull(USER_statusAnketar,'') like 'I8%')"
                'Dim krugoviVracenih As String = ""
                'Dim dtpk As System.Data.DataTable = izvrsiSQLvratiDT(strSQlpk, DBConnectionString, Me.jezik)
                'If dtpk.Rows.Count > 0 Then
                '    For i As Integer = 0 To dtpk.Rows.Count - 1
                '        krugoviVracenih = krugoviVracenih + dtpk.Rows(i).Item("krugovi").ToString.Trim + ", "
                '    Next
                '    krugoviVracenih = krugoviVracenih.Trim.TrimEnd(",")
                'End If

                If dt1.Rows.Count > 0 Then
                    BrojVracenihDom = dt1.Rows(0).Item("BrojVracenihDom").ToString.Trim
                End If
                lblBrojVracenihStanovaBroj.Text = BrojVracenihDom
                'If BrojVracenihStanovaBroj > 0 Then
                '    lblBrojVracenihStanova.ForeColor = Color.DarkRed
                '    lblBrojVracenihStanovaBroj.ForeColor = Color.DarkRed
                '    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:" + nvrd + krugoviVracenih
                '    lblKrugoviDorada.Visible = True
                'Else
                '    lblBrojVracenihStanova.ForeColor = Color.Black
                '    lblBrojVracenihStanovaBroj.ForeColor = Color.Black
                '    lblKrugoviDorada.Text = "Stanovi vraćeni na doradu su u krugovima:"
                '    lblKrugoviDorada.Visible = False
                'End If

                strSQl = " select cast(count(*) as varchar(4)) as BrojQCBroj " + nvrd +
                                " from adresar " + nvrd +
                                " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=1"
                Dim BrojQCBroj As String = "0"
                Dim dt2 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt2.Rows.Count > 0 Then
                    BrojQCBroj = dt2.Rows(0).Item("BrojQCBroj").ToString.Trim
                End If
                lblBrojQCBroj.Text = BrojQCBroj

                strSQl = " select cast(count(*) as varchar(4)) as BrojPoslatihBroj " + nvrd +
                       " from adresar " + nvrd +
                       " where ANKETAR=N'" + koSam + "' and isnull(statusAnketar,0)=2"
                Dim BrojPoslatihBroj As String = "0"
                Dim dt3 As System.Data.DataTable = izvrsiSQLvratiDT(strSQl, DBConnectionString, Me.jezik)
                If dt3.Rows.Count > 0 Then
                    BrojPoslatihBroj = dt3.Rows(0).Item("BrojPoslatihBroj").ToString.Trim
                End If
                lblBrojPoslatihBroj.Text = BrojPoslatihBroj


                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" OrElse txtmode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then
                    Dim konCAPI As String = getConnectionString(Me.CAPIServer.Trim, Me.CAPIBaza.Trim, txtmode, "")
                    Dim strNeuspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('PPES_24','') and anketarnalog='" + koSam + "' and statusakcije='ERROR'"
                    Dim dtNeuspesno As System.Data.DataTable = izvrsiSQLvratiDT(strNeuspesno, konCAPI, Me.jezik)
                    If Not dtNeuspesno Is Nothing AndAlso dtNeuspesno.Rows.Count > 0 AndAlso dtNeuspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                        Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtNeuspesno.Rows(0).Item(0).ToString + " - neuspešna"
                        Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                        lblPorukaSinhronizacija.Visible = True
                        NePustamUnos = True
                    Else
                        Dim strUspesno As String = "select  isnull(CONVERT(VARCHAR(10), max(DatumAkcije), 104),'') from istcapi.dbo.StatusAkcijaLocal where trim(sifIST) in ('PPES_24','') and anketarnalog='" + koSam + "' and statusakcije='OK'"
                        Dim dtUspesno As System.Data.DataTable = izvrsiSQLvratiDT(strUspesno, konCAPI, Me.jezik)
                        If Not dtUspesno Is Nothing AndAlso dtUspesno.Rows.Count > 0 AndAlso dtUspesno.Rows(0).Item(0).ToString.Trim <> "" Then
                            Me.lblSinhrNeuspesno.Text = "*Poslednja sinhronizacija:  " + dtUspesno.Rows(0).Item(0).ToString + " - uspešna"
                            Me.lblSinhrNeuspesno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = False
                        Else
                            Me.lblSinhrNeuspesno.Text = ""
                            Me.lblSinhrNeuspesno.ForeColor = Color.Maroon
                            lblPorukaSinhronizacija.Visible = False
                            NePustamUnos = True
                        End If
                    End If

                    If bcapimode = True Then Call capiMode(appcode)

                    Dim str As String = " select datediff(day,max(DatumAkcije),getdate()) from istcapi.dbo.StatusAkcijaLocal " + nvrd +
                                        " where akcijaid in (20,30) and trim(sifIST) in ('PPES_24','') and anketarnalog='" + koSam + "'"
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(str, konCAPI, Me.jezik)


                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item(0) > 1 AndAlso dt.Rows(0).Item(0).ToString.Trim <> "" Then
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                        ISTMessageBox.Show("Od poslednje sinhronizacije PODATAKA prošlo je više od 2 dana. Molimo vas da se sinhronizujete što pre!")
                    End If

                End If


                Me.mMneL.Visible = False
                Me.mVIET.Visible = False
                Me.mItalian.Visible = False
                Me.mMakC.Visible = False
                Me.mUzbek.Visible = False
                Me.mAlbanian.Visible = False
                Me.mKirgyz.Visible = False
                Me.mNasL.Visible = False
                Me.mBulgarian.Visible = False
                Me.mGerL.Visible = False
                Me.mEnglish.Visible = False
                Me.mRussian.Visible = False
                Me.mTurL.Visible = False
                If koSam = "" Then
                    ISTMessageBox.Show("Nemate dozvole za ulazak u aplikaciju")
                    Exit Sub
                End If
                If bcapimode = True Then Call capiMode(appcode)

            End If
        ElseIf appcode.Trim.ToUpper = "PPES24OK" Then

            If bcapimode = True Then
                If MrefreshClick() = False Then Exit Sub
            End If

            If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
                Dim koSamPom As String = ""
                Dim koSam As String = ""
                Me.DBConnectionString = connectionString
                If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
                    koSamPom = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                    'ElseIf anketarcloud <> "" OrElse txtmode = "CLOUD" Then
                    '    koSam = anketarcloud
                    '    txtcloudcati = True
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
                    koSamPom = GetUserNameZ()
                ElseIf txtmode.Trim.ToUpper = "Z" AndAlso txtlogin = "TRUE" Then
                    koSamPom = GetUserNameZ()
                ElseIf txtmode.Trim.ToUpper = "Z" AndAlso txtlogin <> "TRUE" Then
                    GetUserNameIzBaze(Me.DBConnectionString)
                Else
                    koSamPom = GetUserNameIzBaze(Me.DBConnectionString)
                End If

                If koSamPom = "" Then
                    Dim dt As System.Data.DataTable = izvrsiSQLvratiDT("select suser_sname() as sn", DBConnectionString, Me.jezik)
                    If dt.Rows.Count > 0 Then
                        koSamPom = dt.Rows(0).Item("sn").ToString.Trim
                    End If
                End If

                If koSamPom.Trim.ToUpper.IndexOf("STATSRB\") >= 0 OrElse koSamPom.Trim.ToUpper.IndexOf("IB15530\KORISNIK") >= 0 Then
                    koSam = kojianketar(koSamPom, Me.DBConnectionString)
                ElseIf txtmode.Trim.ToUpper = "ZCAPI" OrElse koSamPom.Trim.ToUpper.IndexOf("STATSRB\") < 0 Then
                    koSam = GetUserNameZ()
                Else
                    koSam = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
                End If

                Me.mMneL.Visible = False
                Me.mVIET.Visible = False
                Me.mItalian.Visible = False
                Me.mMakC.Visible = False
                Me.mUzbek.Visible = False
                Me.mAlbanian.Visible = False
                Me.mKirgyz.Visible = False
                Me.mNasL.Visible = False
                Me.mBulgarian.Visible = False
                Me.mGerL.Visible = False
                Me.mEnglish.Visible = False
                Me.mRussian.Visible = False
                Me.mTurL.Visible = False
                If koSam = "" Then
                    ISTMessageBox.Show("Nemate dozvole za ulazak u aplikaciju")
                    Exit Sub
                End If
                If bcapimode = True Then Call capiMode(appcode)

            End If
        End If
        'Me.overlayHandleISTLoading.Close()
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        CollapseMenu()
        PreracunajFooter()
    End Sub
    Private Sub CollapseMenu()

        PanelBoje.Visible = False
        If Me.PanelMenu.Width > 200 Then
            PanelMenu.Width = 60
            setTollTip(True)
            Dim dIndex = Logovan.Text.IndexOf(".")
            If (dIndex > -1) AndAlso (dIndex + 2) < Len(Logovan.Text) Then
                Logovan.Visible = True
                Logovan.Text = Logovan.Text.Trim.ToUpper.Substring(0, 1) + Logovan.Text.Trim.ToUpper.Substring(dIndex, 2)
            Else
                Logovan.Visible = False
            End If
            panelmenucollapse = True
            Button2.Visible = False
            Button7.Image = Nothing
            btnLinija1.Visible = False
            btnLinija2.Visible = False
            If PanelMenu.Contains(PanelBoje) = True Then
                Me.PanelMenu.Controls.Remove(Me.PanelBoje)
            End If
            Me.PanelContext.Controls.Add(Me.PanelBoje)
            PanelBoje.Location = New System.Drawing.Point(buttonTheme.Location.X + buttonTheme.Width - 25, buttonTheme.Location.Y - PanelBoje.Height + buttonTheme.Height / 2)

        Else
            Logovan.Visible = True
            Logovan.Text = zapamtilogovanog
            If PanelContext.Contains(PanelBoje) = True Then
                Me.PanelContext.Controls.Remove(Me.PanelBoje)
            End If
            Me.PanelMenu.Controls.Add(Me.PanelBoje)
            PanelBoje.Location = New System.Drawing.Point(buttonTheme.Location.X + buttonTheme.Width + 20, buttonTheme.Location.Y - PanelBoje.Height + buttonTheme.Height / 2 + 10)

            PanelMenu.Width = 255
            setTollTip(False)
            panelmenucollapse = False
            Button7.Image = My.Resources.crtaaaaa.ToBitmap
            Button2.Visible = True
            btnLinija1.Visible = True
            btnLinija2.Visible = True
        End If
    End Sub

    Sub setTollTip(ByVal visibleTrue As Boolean)
        If visibleTrue = True Then
            ToolTip1.SetToolTip(ButtonUnos, ButtonUnos.Tag)
            ToolTip1.SetToolTip(ButtonLogickaKontrola, ButtonLogickaKontrola.Tag)
            ToolTip1.SetToolTip(ButtonAK, ButtonAK.Tag)
            ToolTip1.SetToolTip(ButtonAzuriranje, ButtonAzuriranje.Tag)
            ToolTip1.SetToolTip(ButtonIzvestaji, ButtonIzvestaji.Tag)
            ToolTip1.SetToolTip(ButtonUnos, ButtonUnos.Tag)
            ToolTip1.SetToolTip(BtnAdvancedSearch, BtnAdvancedSearch.Tag)
            ToolTip1.SetToolTip(btnUnosA, btnUnosA.Tag)
            ToolTip1.SetToolTip(BtnAzurK, BtnAzurK.Tag)
            ToolTip1.SetToolTip(btnCATI, btnCATI.Tag)
        Else
            ToolTip1.SetToolTip(ButtonUnos, "")
            ToolTip1.SetToolTip(ButtonLogickaKontrola, "")
            ToolTip1.SetToolTip(ButtonAK, "")
            ToolTip1.SetToolTip(ButtonAzuriranje, "")
            ToolTip1.SetToolTip(ButtonIzvestaji, "")
            ToolTip1.SetToolTip(ButtonUnos, "")
            ToolTip1.SetToolTip(BtnAdvancedSearch, "")
            ToolTip1.SetToolTip(btnUnosA, "")
            ToolTip1.SetToolTip(BtnAzurK, "")
            ToolTip1.SetToolTip(btnCATI, "")
        End If
    End Sub

    Private currentBtn As Button
    Private Sub DisableButton(ByVal color As Color)
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = color
        End If
    End Sub

    Private Sub FormIstrazivanje_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call PreVentFlicker()
        Call SettingObjForTheme(GetTheme())
        'prvo ide activate pa load

        'Dim customfont As PrivateFontCollection = New PrivateFontCollection
        'customfont.AddFontFile(System.Windows.Forms.Application.StartupPath + "\Konexy.ttf")
        'Button7.Font = New System.Drawing.Font(customfont.Families(0), 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.LogovanAnketarCloud.Text = ""
        If txtmode.Trim.ToUpper.IndexOf("CLOUD") >= 0 Then
            Me.LogovanAnketarCloud.Visible = True
            For Each k As Control In Me.Controls
                If TypeOf k Is LinkLabel Then
                    If Not k.Tag Is Nothing AndAlso k.Tag.trim.tolower = "always" Then
                        k.Visible = True
                    Else
                        k.Visible = False
                    End If
                End If
            Next
        Else
            Me.LogovanAnketarCloud.Visible = False
        End If

        dgvIST.Columns("sifistnaziv").Visible = False
        dgvIST.Columns("sifist").Width = 100
        dgvIST.Columns("Naziv").Width = dgvIST.Width - dgvIST.Columns("sifist").Width - dgvIST.RowHeadersWidth - 18
        Dim seenRows As Integer = 13 '13-broj redova koji hocemo da se vidi
        dgvIST.Dock = DockStyle.None
        dgvIST.Height = Me.dgvIST.RowTemplate.Height * seenRows
        panelIST.Height = Me.dgvIST.RowTemplate.Height * seenRows + Me.dgvIST.Top + 2 + 20
        PanelBoje.Location = New System.Drawing.Point(buttonTheme.Location.X + buttonTheme.Width + 20, buttonTheme.Location.Y - PanelBoje.Height + buttonTheme.Height / 2 + 10)

        'Call CAPICensus()
        Call PreracunajFooter()
        'Call srediPremaRezoluciji()

        If Me.postojiISTApp = False Then
            Me.lblSifra.Text = ""
            Me.lblNaziv.Text = "PLEASE, CHOOSE IST APPLICATION"
        End If

        If txtIST.Enabled = True Then
            txtIST.Focus()
        End If

    End Sub
    Sub srediPremaRezoluciji()
        'laptop 1366x768
        'desktop 1920x1080
        Dim resWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim resHeight As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim CW As Integer = 1920
        'Dim RWF As Double = Math.Round((1366 - 1920) / 1366, 1) + 0.1 ' Ratio change of width

        If resWidth < 1500 Then
            Dim RWF As Double = -0.7  'smanji 30 posto
            panelFooter.Width = panelFooter.Width + CInt(panelFooter.Width * RWF)    'CInt(Ctrl.Width * RW-0.08)
            panelFooter.Left = panelFooter.Left + CInt(panelFooter.Left * RWF)
            For Each Ctrl As Control In panelFooter.Controls
                If TypeOf Ctrl Is Button Then
                    'Ctrl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Ctrl.Width, Ctrl.Height, 5, 5))
                    Ctrl.Width = Ctrl.Width + CInt(Ctrl.Width * RWF)    'CInt(Ctrl.Width * RW-0.08)
                    Ctrl.Height = Ctrl.Height + CInt(Ctrl.Height * RWF)
                    Ctrl.Left = Ctrl.Left + CInt(Ctrl.Left * RWF)
                    If RWF < 0 Then
                        CType(Ctrl, Button).Font = New System.Drawing.Font(CType(Ctrl, Button).Font.Name, 8.0!)
                    End If
                End If
            Next
        End If

    End Sub

    Sub showTaskbar()
        Dim LokalniISTfolder As String = Environment.GetEnvironmentVariable("TEMP") + "\IST"
        Dim pshowTaskBar As String = LokalniISTfolder + "\showTaskBar.bat"
        'ko ide preko ISTProveriPaKreni
        Dim p As New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = pshowTaskBar
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.Verb = "runas"

        Try
            p.Start()
            p.WaitForExit()
        Catch ex As System.Exception
            'ko ide direktno preko bgd-a
            pshowTaskBar = ".\showTaskBar.bat"
            p.StartInfo.FileName = pshowTaskBar
            Try
                p.Start()
                p.WaitForExit()
            Catch ex2 As System.Exception
                ISTMessageBox.Show(ex2.ToString())
            End Try
        End Try
    End Sub

    Private Declare Function AddFontResourceEx Lib "gdi32" Alias "AddFontResourceExA" (ByVal lpszFilename As String, ByVal fl As Integer, ByVal pdv As Integer) As Integer
    Private Const FR_PRIVATE As Integer = &H10
    Sub installBarCodeFont(ByVal tmode As String)

        Try
            Dim putanjadoISTa As String = Environment.GetEnvironmentVariable("TEMP") + "\IST"
            If File.Exists("C:\Windows\fonts\LibreBarcode39-Regular.ttf") = False Then
                Dim myProcess As Process
                Dim ppp As System.Diagnostics.Process
                Try
                    Dim putanjadoVBS As String = putanjadoISTa + "\ps_2.txt"
                    If File.Exists(putanjadoVBS) = True Then
                        Dim newFilePath As String = ""
                        newFilePath = putanjadoVBS.Replace(".txt", ".vbs")
                        System.IO.File.Move(putanjadoVBS, newFilePath)
                    End If
                    myProcess = Process.Start(putanjadoISTa + "\ps_2.vbs")
                    myProcess.WaitForExit()
                    Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
                    psi.FileName = putanjadoISTa + "\ps_2.vbs"
                    psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
                    ppp = System.Diagnostics.Process.Start(psi)
                    ppp.WaitForExit()
                Catch ex As System.Exception
                    'ko ide direktno preko bgd-a
                    Try
                        Dim putanjadoVBS As String = ".\ps_2.txt"
                        If File.Exists(putanjadoVBS) = True Then
                            Dim newFilePath As String = ""
                            newFilePath = putanjadoVBS.Replace(".txt", ".vbs")
                            System.IO.File.Move(putanjadoVBS, newFilePath)
                        End If
                        myProcess = Process.Start(".\ps_2.vbs")
                        myProcess.WaitForExit()
                        Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
                        psi.FileName = ".\ps_2.vbs"
                        psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
                        ppp = System.Diagnostics.Process.Start(psi)
                        ppp.WaitForExit()
                    Catch ex2 As System.Exception
                        ISTMessageBox.Show(ex2.ToString())
                    End Try
                End Try
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
        'End If

    End Sub


    Sub BestPerformance()
        Dim LokalniISTfolder As String = Environment.GetEnvironmentVariable("TEMP") + "\IST"
        Dim pBestPerformance As String = LokalniISTfolder + "\BestPerformance.bat"
        'ko ide preko ISTProveriPaKreni
        Dim p As New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = pBestPerformance
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.Verb = "runas"

        Try
            p.Start()
            p.WaitForExit()
        Catch ex As System.Exception
            'ko ide direktno preko bgd-a
            pBestPerformance = ".\BestPerformance.bat"
            p.StartInfo.FileName = pBestPerformance
            Try
                p.Start()
                p.WaitForExit()
            Catch ex2 As System.Exception
                ISTMessageBox.Show(ex2.ToString())
            End Try
        End Try
    End Sub

    Private Sub ISTMetaOld_Click(sender As Object, e As EventArgs) Handles ISTMetaOld.Click
        If MrefreshClick() = False Then Exit Sub
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New IstrazivanjaZadaci.Form_IST(Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                        Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, Me.PublicDBServer.Trim.ToUpper, Me.PublicDBBaza.Trim.ToUpper, Me.txtmode, Me.jezik, Me.UserControlVremenskaTacka1, kosamnew)
        Me.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            frm.Dispose()
            Me.Show()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.btnCerrar.PerformClick()
    End Sub
    Private Sub btnCAPI_Click(sender As Object, e As EventArgs) Handles btnCAPI.Click
        If MrefreshClick() = False Then Exit Sub
        'Dim msgtxt400 As String = getMessageText(dtMessages, "400", Me.jezik) + nvrd
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then

            If NePustamUnos = True Then
                'Dim msgtxt400 As String = getMessageText(dtMessages, "400", Me.jezik) + nvrd
                ISTMessageBox.Show("Poslednja sinhronizacija je bila neuspešna." + nvrd + "Morate se sinhronizovati, a zatim nastaviti sa unosom podataka.")
                Exit Sub
            End If
            Me.m_zadaciIstrazivanje.ButtonUnosGrid_Click()
            Call CAPICensus(False)
        End If
    End Sub

    Private Sub ButtonUnos_Click(sender As Object, e As EventArgs) Handles ButtonUnos.Click

        If MrefreshClick() = False Then Exit Sub

        ButtonUnos.Enabled = False

        Try
            Dim dataSetIST As DatasetIstrazivanja = Nothing
            Dim dataSetISTPX As DatasetIstrazivanja = Nothing
            Dim connectionString As String = ""
            Dim rowIST As DatasetIstrazivanja.ISTRow = Nothing
            Dim tabelaAdresar As DatasetIstrazivanja.ISTPOLJADataTable = Nothing
            If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) = True Then
                If Me.txtmode.Trim.ToUpper.IndexOf("CLOUD") >= 0 Then
                    If Me.LogovanAnketarCloud.Text.Trim <> "" Then
                        'provera da li je anketar iz tog istrazivanja
                        Dim strSQL As String = "select anketar from dbo.[ISTCATIUsersPass] where userid='" + Me.LogovanAnketarCloud.Text.Trim + "'"
                        strSQL = strSQL + " and sifIST='" + Me.lblSifra.Text + "'"

                        Dim dt As New System.Data.DataTable
                        Dim konCATI As String = getConnectionString(Me.CATIServer.Trim, Me.CATIBaza.Trim, txtmode, "")
                        dt = izvrsiSQLvratiDT(strSQL, konCATI, Nothing)

                        If dt.Rows.Count > 0 Then
                            'postoji anketar sve ok
                        Else
                            Me.LogovanAnketarCloud.Text = ""
                        End If
                    End If

                    If Me.LogovanAnketarCloud.Text.Trim = "" Then
                        Dim p As String = Me.m_zadaciIstrazivanje.ButtonCLOUD_Click()
                        Dim pp() As String = p.Split(";")
                        If pp(0) = "da" Then
                            Me.LogovanAnketarCloud.Text = pp(1)
                            Me.m_zadaciIstrazivanje.anketarCloud = pp(1)
                            Me.m_zadaciIstrazivanje.ButtonUnos_Click()
                        End If
                    Else
                        Me.m_zadaciIstrazivanje.anketarCloud = Me.LogovanAnketarCloud.Text
                        Me.m_zadaciIstrazivanje.ButtonUnos_Click()
                    End If
                Else
                    'nije CLOUD
                    Me.m_zadaciIstrazivanje.ButtonUnos_Click()
                End If
            End If
        Catch ex As System.Exception
            ButtonUnos.Enabled = True
        End Try

        ButtonUnos.Enabled = True
    End Sub

    Private Sub ButtonLogickaKontrola_Click(sender As Object, e As EventArgs) Handles ButtonLogickaKontrola.Click

        If MrefreshClick() = False Then Exit Sub
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenuCollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonLogickaKontrola_Click()
        End If
    End Sub

    Private Sub ButtonAK_Click(sender As Object, e As EventArgs) Handles ButtonAK.Click
        If MrefreshClick() = False Then Exit Sub
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonAK_Click()
        End If
    End Sub

    Private Sub ButtonAzuriranje_Click(sender As Object, e As EventArgs) Handles ButtonAzuriranje.Click
        If MrefreshClick() = False Then Exit Sub
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonAzuriranje_Click()
        End If
    End Sub

    Private Sub ButtonIzvestaji_Click(sender As Object, e As EventArgs) Handles ButtonIzvestaji.Click

        If MrefreshClick() = False Then Exit Sub
        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonIzvestaji_Click()
        End If
    End Sub
    Private Sub BtnAdvancedSearch_Click(sender As Object, e As EventArgs) Handles BtnAdvancedSearch.Click
        If MrefreshClick() = False Then Exit Sub

        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonNPretraga_Click()
        End If
    End Sub
    Private Sub btnCATI_Click(sender As Object, e As EventArgs) Handles btnCATI.Click
        If MrefreshClick() = False Then Exit Sub

        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonCATI_Click()
        End If
    End Sub
    Private Sub btnUnosA_Click(sender As Object, e As EventArgs) Handles btnUnosA.Click
        If MrefreshClick() = False Then Exit Sub

        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.ButtonUnos_Click("Pomocne")
        End If
    End Sub
    Private Sub BtnAzurK_Click(sender As Object, e As EventArgs) Handles BtnAzurK.Click
        If MrefreshClick() = False Then Exit Sub

        If Me.Login(dataSetIST, connectionString, rowIST, tabelaAdresar, dataSetISTPX) Then
            Me.m_zadaciIstrazivanje.panelmenucollapse = panelmenucollapse
            Me.m_zadaciIstrazivanje.ButtonAzuriranje_Click("Pomocne")
        End If
    End Sub
    Private Sub btnProba_Click(sender As Object, e As EventArgs) Handles btnProba.Click
        Dim frm As New FormAbout(Me.jezik)
        frm.ShowDialog()
        frm.Dispose()
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
        System.Windows.Forms.Application.Exit()
        End

    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMenu2_Click(sender As Object, e As EventArgs) Handles btnMenu2.Click
        Dim btnSender As Button = CType(sender, Button)
        Dim ptLowerLeft As System.Drawing.Point = New System.Drawing.Point(0, btnSender.Height)
        ptLowerLeft = btnSender.PointToScreen(ptLowerLeft)
        ctMenuStrip.Show(ptLowerLeft)
    End Sub
    Private Sub ActivateButton(ByVal senderBtn As Object, ByVal color As Color)
        If senderBtn IsNot Nothing Then
            DisableButton(Color.Transparent)
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = color
        End If
    End Sub
    Private Sub ButtonUnos_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonUnos.MouseDown, ButtonLogickaKontrola.MouseDown, ButtonIzvestaji.MouseDown, ButtonAzuriranje.MouseDown, ButtonAK.MouseDown, btnUnosA.MouseDown, btnCATI.MouseDown, btnCAPI.MouseDown, BtnAzurK.MouseDown, BtnAdvancedSearch.MouseDown
        ActivateButton(sender, ActivateButtonColor)
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("http://istportal.net")
    End Sub

    Private Sub MiXMLuIST_Click(sender As Object, e As EventArgs) Handles MiXMLuIST.Click
        Dim msg As Boolean = xml2ist(CType(dtSpisakIST, System.Data.DataTable))
        If MrefreshClick() = False Then Exit Sub
        ''msg 135
        Dim msgtxt135 As String = getMessageText(dtMessages, "135", Me.jezik)
        ''msg 136
        Dim msgtxt136 As String = getMessageText(dtMessages, "136", Me.jezik)
        If msg Then ISTMessageBox.Show(msgtxt135, msgtxt136, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
    Public Function xml2ist(ByVal dd As System.Data.DataTable) As Boolean
        'XML->IST
        Dim dlg As New System.Windows.Forms.OpenFileDialog
        dlg.ShowDialog()
        Dim dttk As String = dlg.FileName
        dlg.Dispose()

        Dim logP As New FormLogin
        logP.ShowDialog()
        Dim lcs As String = logP.MyConnectionString()
        logP.Dispose()

        Dim DtsetIST As New System.Data.DataSet 'Istrazivanja
        DtsetIST.ReadXml(dttk)
        Dim dr As System.Windows.Forms.DialogResult = System.Windows.Forms.DialogResult.Yes
        Dim UcitIst As String = CStr(DtsetIST.Tables("IST").Rows(0).Item("SifIst")).Trim.ToUpper

        Dim sql As String

        If dd.Select("SifIst='" & UcitIst & "'").GetUpperBound(0) >= 0 Then
            ''msg 278
            Dim msgtxt278 As String = getMessageText(dtMessages, "278", Me.jezik)
            ''msg 279
            Dim msgtxt279 As String = getMessageText(dtMessages, "279", Me.jezik)
            ''msg 280
            Dim msgtxt280 As String = getMessageText(dtMessages, "280", Me.jezik)
            Dim por1 As String = msgtxt278 & UcitIst & msgtxt279
            Dim por2 As String = UcitIst & msgtxt280
            dr = ISTMessageBox.Show(por1, por2, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If dr = System.Windows.Forms.DialogResult.Yes Then
                Try

                    'obrisi istrazivanje....  IST, ISTPolja, ISTTabele, ISTLK, ISTTABS
                    Dim tble() As String = {"IST", "ISTPolja", "ISTTabele", "ISTLK", "ISTTABS"}
                    For i As Integer = 0 To tble.GetUpperBound(0)
                        sql = "delete from " & tble(i) & " where SifIst='" & UcitIst & "'"

                        Dim ok1 As String = izvrsiSQL(sql, lcs)
                        If ok1 <> "ok" Then
                            ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER26", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                    Next

                Catch ex As System.Exception
                    ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False

                End Try
            End If
        End If
        If dr <> DialogResult.Cancel Then
            Try
                't = conn.BeginTransaction(System.Data.IsolationLevel.ReadCommitted)
                For Each dt As System.Data.DataTable In DtsetIST.Tables
                    If dt.TableName.Trim.ToUpper = "ISTBAZE" Then
                    Else
                        If dt.Rows.Count > 0 Then 'cini mi se da delete ide uvek?
                            For Each dtr As System.Data.DataRow In dt.Rows
                                Dim s1 As String = "" : Dim s2 As String = ""
                                For Each dtrc As System.Data.DataColumn In dt.Columns
                                    If s1.Trim <> "" Then s1 = s1 & ","
                                    If s2.Trim <> "" Then s2 = s2 & ","
                                    s1 = s1 & dtrc.ColumnName
                                    If dtr.Item(dtrc.ColumnName) Is System.DBNull.Value Then
                                        s2 = s2 & "NULL"
                                    Else
                                        If dtrc.ColumnName.Trim.ToUpper = "VOD" Or dtrc.ColumnName.Trim.ToUpper = "VDO" Then
                                            s2 = s2 & "'" & CDate(dtr.Item(dtrc.ColumnName)) & "'"
                                        Else
                                            Select Case dtrc.DataType.Name
                                                Case "Boolean"
                                                    If CType(dtr.Item(dtrc.ColumnName), Boolean) = False Then
                                                        s2 = s2 & "0"
                                                    Else
                                                        s2 = s2 & "1"
                                                    End If
                                                Case "DateTime" 'ovo ne hvata nikad?
                                                    s2 = s2 & "'" & CDate(dtr.Item(dtrc.ColumnName)) & "'"
                                                Case "String", "char"
                                                    s2 = s2 & "N'" & Replace(CStr(dtr.Item(dtrc.ColumnName)), "'", "''") & "'"
                                                Case Else
                                                    s2 = s2 & " CAST('" & CStr(dtr.Item(dtrc.ColumnName)) & "' AS FLOAT) " 'da bi radili i float-ovi
                                            End Select
                                        End If
                                    End If
                                Next
                                sql = "INSERT into " & dt.TableName & " (" & s1 & ") values (" & s2 & ") "
                                Dim ok1 As String = izvrsiSQL(sql, lcs)
                                If ok1 <> "ok" Then
                                    ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER27", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If


                            Next ' svrshili s Row-ima
                        End If 'ima podaci za pisanje....
                    End If
                Next

            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End Try
        End If
        Return True
    End Function

    'Dim zapamtibojuteme As Color = Nothing
    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelMenu
        ReDim Preserve nizButtonOboji(2)
        nizButtonOboji(2) = lblSifra
        ReDim Preserve nizButtonOboji(3)
        nizButtonOboji(3) = lblNaziv
        ReDim Preserve nizButtonOboji(4)
        nizButtonOboji(4) = btnChoose
        ReDim Preserve nizButtonOboji(5)
        nizButtonOboji(5) = btnChoose

        Dim nizButtonOrange() As Button = {}
        Dim inizButtonOrange As Integer = -1

        For i As Integer = 0 To nizButton.GetUpperBound(0)
            ReDim Preserve nizButtonOrange(i)
            nizButtonOrange(i) = nizButton(i)
            inizButtonOrange = i
        Next
        zapamtibojuteme = setTheme(nizButtonOboji, nizButtonOrange, theme)

    End Sub
    Dim zapamtibojuteme As Color = Nothing
    Private Sub buttonTheme_Click(sender As Object, e As EventArgs) Handles buttonTheme.Click
        If PanelBoje.Visible = True Then
            PanelBoje.Visible = False
        Else
            PanelBoje.Visible = True
            Dim kojatema As String = GetTheme().ToUpper
            If kojatema = "LIGHT" Then
                btnLight.Focus()
            ElseIf kojatema = "A1" Then
                btnA1.Focus()
            ElseIf kojatema = "A2" Then
                btnA2.Focus()
            ElseIf kojatema = "A3" Then
                btnA3.Focus()
            ElseIf kojatema = "A4" Then
                btnA4.Focus()
            ElseIf kojatema = "A5" Then
                btnA5.Focus()
            ElseIf kojatema = "A6" Then
                btnA6.Focus()
            ElseIf kojatema = "A7" Then
                btnA7.Focus()
            ElseIf kojatema = "DARK" Then
                btnDark.Focus()
            Else
                PanelBoje.Focus()
            End If
        End If

    End Sub

    Private Sub btnA2_Click(sender As Object, e As EventArgs) Handles btnDark.Click, btnLight.Click, btnA1.Click, btnA2.Click, btnA3.Click, btnA4.Click, btnA5.Click, btnA6.Click, btnA7.Click
        Call SelectedColor(sender.tag.ToString.ToUpper)
    End Sub

    Private Sub SelectedColor(ByVal btnColorName As String)
        Call SaveTheme(btnColorName)
        Call SettingObjForTheme(btnColorName)
    End Sub

    Private Sub PanelBoje_LostFocus(sender As Object, e As EventArgs) Handles PanelBoje.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnDark_LostFocus(sender As Object, e As EventArgs) Handles btnDark.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnLight_LostFocus(sender As Object, e As EventArgs) Handles btnLight.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnA1_LostFocus(sender As Object, e As EventArgs) Handles btnA1.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnA2_LostFocus(sender As Object, e As EventArgs) Handles btnA2.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnA3_LostFocus(sender As Object, e As EventArgs) Handles btnA3.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnA4_LostFocus(sender As Object, e As EventArgs) Handles btnA4.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnA5_LostFocus(sender As Object, e As EventArgs) Handles btnA5.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnA6_LostFocus(sender As Object, e As EventArgs) Handles btnA6.LostFocus
        zatvoriPanelBoje()
    End Sub
    Private Sub btnA7_LostFocus(sender As Object, e As EventArgs) Handles btnA7.LostFocus
        zatvoriPanelBoje()
    End Sub

    Private Sub zatvoriPanelBoje()
        If buttonTheme.Focused = False AndAlso btnDark.Focused = False AndAlso btnLight.Focused = False AndAlso btnA1.Focused = False AndAlso btnA2.Focused = False AndAlso btnA3.Focused = False AndAlso
        btnA4.Focused = False AndAlso btnA5.Focused = False AndAlso btnA6.Focused = False AndAlso btnA7.Focused = False AndAlso PanelBoje.Focused = False Then
            PanelBoje.Visible = False
        End If
    End Sub

    Private Sub Panel_Click(sender As Object, e As EventArgs) Handles PanelContext.Click, PanelMenu.Click, PanelTop.Click
        PanelBoje.Visible = False
    End Sub

    Private Sub btnFT1_MouseHover(sender As Object, e As EventArgs) Handles btnFT1.MouseHover, btnFT2.MouseHover, btnFT3.MouseHover, btnFT4.MouseHover, btnFT5.MouseHover
        Call hoverOnFooter(DirectCast(sender, Button))
    End Sub

    Private Sub btnFT1_MouseLeave(sender As Object, e As EventArgs) Handles btnFT1.MouseLeave, btnFT2.MouseLeave, btnFT3.MouseLeave, btnFT4.MouseLeave, btnFT5.MouseLeave
        Call hoverOnFooterLeave(DirectCast(sender, Button))
    End Sub

    Private Sub hoverOnFooter(ByVal kontrola As Button)
        kontrola.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub hoverOnFooterLeave(ByVal kontrola As Button)
        kontrola.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub

    Private Sub panelIST_Click(sender As Object, e As EventArgs) Handles panelIST.Click
        PanelBoje.Visible = False
    End Sub

    Private Sub panelFooter_Click(sender As Object, e As EventArgs) Handles panelFooter.Click
        PanelBoje.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("http://istportal.net")
    End Sub

    Private Sub txtIST_Leave(sender As Object, e As EventArgs) Handles txtIST.Leave
        If Me.postojiISTApp = False Then
            txtIST.Focus()
        End If

    End Sub

    Sub visiblePanelTOP()
        btnArrowDownHover.Visible = False
        PanelTop.BackColor = zapamtibojuteme
        btnCerrar.Visible = True
        btnMinimizar.Visible = True
        MRefresh.Visible = True
        If Me.lblSifra.Text.Trim.ToUpper <> "PPES_24" Then
            btnMenu2.Visible = True
        End If
    End Sub

    Sub nonvisiblePanelTOP()
        'If ctMenuStrip.Visible = False Then

        btnCerrar.Visible = False
            btnMinimizar.Visible = False
            MRefresh.Visible = False
            btnMenu2.Visible = False
            PanelTop.BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
            btnArrowDownHover.Visible = True

        'End If

    End Sub

    Private Sub PanelTop_MouseLeave(sender As Object, e As EventArgs) Handles PanelTop.MouseLeave, btnCerrar.MouseLeave, btnMinimizar.MouseLeave, MRefresh.MouseLeave, btnMenu2.MouseLeave, ctMenuStrip.MouseLeave
        If MouseIsOverCTMenuStrip(ctMenuStrip) OrElse MouseIsOverButton(btnCerrar) OrElse MouseIsOverButton(btnMinimizar) OrElse MouseIsOverButton(MRefresh) OrElse MouseIsOverButton(btnMenu2) OrElse MouseIsOverPanel(PanelTop) Then

        Else
            If otvorenSubMenu = False Then
                nonvisiblePanelTOP()
            End If

            'End If
        End If
    End Sub
    Dim otvorenSubMenu As Boolean = False
    Private Sub ctMenuStrip_Opened(sender As Object, e As EventArgs) Handles ctMenuStrip.Opened
        Dim contextMenuStrip As ContextMenuStrip = DirectCast(sender, ContextMenuStrip)
        otvorenSubMenu = True

    End Sub

    Private Sub ContextMenuStrip_Closed(sender As Object, e As ToolStripDropDownClosedEventArgs) Handles ctMenuStrip.Closed
        Dim contextMenuStrip As ContextMenuStrip = DirectCast(sender, ContextMenuStrip)
        otvorenSubMenu = False
        If MouseIsOverButton(btnCerrar) OrElse MouseIsOverButton(btnMinimizar) OrElse MouseIsOverButton(MRefresh) OrElse MouseIsOverButton(btnMenu2) OrElse MouseIsOverPanel(PanelTop) Then

        Else

            nonvisiblePanelTOP()


            'End If
        End If

    End Sub

    Private Sub btnArrowDownHover_MouseHover(sender As Object, e As EventArgs) Handles btnArrowDownHover.MouseHover, PanelTop.MouseHover
        visiblePanelTOP()
    End Sub

    Private Sub PanelMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnCerrar.MouseEnter, btnMinimizar.MouseEnter, MRefresh.MouseEnter, btnMenu2.MouseEnter ', ctMenuStrip.MouseEnter
        visiblePanelTOP()
    End Sub

    Private Function MouseIsOverButton(ByVal btn As Button) As Boolean
        Return btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position))
    End Function

    Private Function MouseIsOverPanel(ByVal pnl As Panel) As Boolean
        Return pnl.ClientRectangle.Contains(pnl.PointToClient(Cursor.Position))
    End Function

    Private Function MouseIsOverCTMenuStrip(ByVal CTMS As ContextMenuStrip) As Boolean
        Return CTMS.ClientRectangle.Contains(CTMS.PointToClient(Cursor.Position))
    End Function



    'Private Function MouseIsOverCTMenuStripItem(ByVal CTMSItem As DropDownItem) As Boolean
    '    Return CTMSItem.ClientRectangle.Contains(CTMSItem.PointToClient(Cursor.Position))
    'End Function

    'Private Function MouseIsOverCTMenuStripItem(ByVal CTMSItem As ToolStripMenuItem) As Boolean
    '    Dim contextMenuStrip As ContextMenuStrip = CType(CTMSItem.Owner, ContextMenuStrip)

    '    If contextMenuStrip IsNot Nothing Then
    '        Dim mousePositionInContextMenu As Drawing.Point = contextMenuStrip.PointToClient(Cursor.Position)
    '        Return CTMSItem.Bounds.Contains(mousePositionInContextMenu)
    '    End If

    '    Return False
    'End Function

    'For Each item As ToolStripMenuItem In ctMenuStrip.Items
    ''item.ForeColor = Color.White
    'For Each subitem As ToolStripMenuItem In item.DropDownItems
    '            subitem.ForeColor = Color.White
    '        Next
    'Next
End Class