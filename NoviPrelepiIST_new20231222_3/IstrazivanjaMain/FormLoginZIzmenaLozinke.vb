Option Strict Off
Imports IST_CAPI.Konekcije
Imports System.Data.SqlClient
Imports System.IO
Imports System.Configuration
Imports System.ComponentModel
Imports System.Threading
Imports Microsoft.Win32
Imports DITO.Ditonv
Imports DITO.ZipUnZip
Imports DITO.ADM_DITO
Imports System.Management

Imports System.Net
Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing

Public Class FormLoginZIzmenaLozinke
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents lblLozinka2 As System.Windows.Forms.Label
    Friend WithEvents lblLozinka As System.Windows.Forms.Label
    Friend WithEvents txtNovaLozinka2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaLozinka As System.Windows.Forms.TextBox
    Friend WithEvents btnPromenaLozinke As Button
    Friend WithEvents txtNacinRada As TextBox
    Friend WithEvents labVerzija As Label
    Friend WithEvents btnLogo2 As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents panelZaglavlje As Panel
    Friend WithEvents btnCrta As Button
    Friend WithEvents lblNapomena As Label
    Friend WithEvents panelFooter As Panel
    Friend WithEvents btnEye1 As Button
    Friend WithEvents btnEye2 As Button
    Friend WithEvents panelKontrole As Panel
    Friend WithEvents btnX As Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginZIzmenaLozinke))
        Me.lblLozinka2 = New System.Windows.Forms.Label()
        Me.lblLozinka = New System.Windows.Forms.Label()
        Me.txtNovaLozinka2 = New System.Windows.Forms.TextBox()
        Me.txtNovaLozinka = New System.Windows.Forms.TextBox()
        Me.btnPromenaLozinke = New System.Windows.Forms.Button()
        Me.txtNacinRada = New System.Windows.Forms.TextBox()
        Me.labVerzija = New System.Windows.Forms.Label()
        Me.btnLogo2 = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.panelZaglavlje = New System.Windows.Forms.Panel()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnCrta = New System.Windows.Forms.Button()
        Me.lblNapomena = New System.Windows.Forms.Label()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.btnEye1 = New System.Windows.Forms.Button()
        Me.btnEye2 = New System.Windows.Forms.Button()
        Me.panelKontrole = New System.Windows.Forms.Panel()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelZaglavlje.SuspendLayout()
        Me.panelFooter.SuspendLayout()
        Me.panelKontrole.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLozinka2
        '
        Me.lblLozinka2.BackColor = System.Drawing.Color.Transparent
        Me.lblLozinka2.ForeColor = System.Drawing.Color.White
        Me.lblLozinka2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLozinka2.Location = New System.Drawing.Point(96, 80)
        Me.lblLozinka2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLozinka2.Name = "lblLozinka2"
        Me.lblLozinka2.Size = New System.Drawing.Size(302, 21)
        Me.lblLozinka2.TabIndex = 8
        Me.lblLozinka2.Text = "Потврда нове лозинке:"
        Me.lblLozinka2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLozinka
        '
        Me.lblLozinka.BackColor = System.Drawing.Color.Transparent
        Me.lblLozinka.ForeColor = System.Drawing.Color.White
        Me.lblLozinka.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLozinka.Location = New System.Drawing.Point(96, 20)
        Me.lblLozinka.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLozinka.Name = "lblLozinka"
        Me.lblLozinka.Size = New System.Drawing.Size(302, 21)
        Me.lblLozinka.TabIndex = 7
        Me.lblLozinka.Text = "Нова лозинка:"
        Me.lblLozinka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNovaLozinka2
        '
        Me.txtNovaLozinka2.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNovaLozinka2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNovaLozinka2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovaLozinka2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtNovaLozinka2.Location = New System.Drawing.Point(99, 102)
        Me.txtNovaLozinka2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNovaLozinka2.MaxLength = 50
        Me.txtNovaLozinka2.Name = "txtNovaLozinka2"
        Me.txtNovaLozinka2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaLozinka2.Size = New System.Drawing.Size(299, 27)
        Me.txtNovaLozinka2.TabIndex = 10
        '
        'txtNovaLozinka
        '
        Me.txtNovaLozinka.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNovaLozinka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNovaLozinka.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNovaLozinka.Location = New System.Drawing.Point(99, 42)
        Me.txtNovaLozinka.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNovaLozinka.MaxLength = 20
        Me.txtNovaLozinka.Name = "txtNovaLozinka"
        Me.txtNovaLozinka.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNovaLozinka.Size = New System.Drawing.Size(299, 27)
        Me.txtNovaLozinka.TabIndex = 9
        '
        'btnPromenaLozinke
        '
        Me.btnPromenaLozinke.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnPromenaLozinke.FlatAppearance.BorderSize = 0
        Me.btnPromenaLozinke.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPromenaLozinke.ForeColor = System.Drawing.Color.White
        Me.btnPromenaLozinke.Location = New System.Drawing.Point(99, 162)
        Me.btnPromenaLozinke.Name = "btnPromenaLozinke"
        Me.btnPromenaLozinke.Size = New System.Drawing.Size(299, 34)
        Me.btnPromenaLozinke.TabIndex = 11
        Me.btnPromenaLozinke.Text = "ПРОМЕНА ЛОЗИНКЕ"
        Me.btnPromenaLozinke.UseVisualStyleBackColor = False
        '
        'txtNacinRada
        '
        Me.txtNacinRada.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.txtNacinRada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNacinRada.Enabled = False
        Me.txtNacinRada.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtNacinRada.Location = New System.Drawing.Point(12, 367)
        Me.txtNacinRada.Multiline = True
        Me.txtNacinRada.Name = "txtNacinRada"
        Me.txtNacinRada.Size = New System.Drawing.Size(173, 21)
        Me.txtNacinRada.TabIndex = 120
        Me.txtNacinRada.Visible = False
        '
        'labVerzija
        '
        Me.labVerzija.AutoSize = True
        Me.labVerzija.Location = New System.Drawing.Point(285, 365)
        Me.labVerzija.Name = "labVerzija"
        Me.labVerzija.Size = New System.Drawing.Size(37, 16)
        Me.labVerzija.TabIndex = 121
        Me.labVerzija.Text = "V4.6"
        '
        'btnLogo2
        '
        Me.btnLogo2.BackColor = System.Drawing.Color.Transparent
        Me.btnLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLogo2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogo2.FlatAppearance.BorderSize = 0
        Me.btnLogo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo2.ForeColor = System.Drawing.Color.White
        Me.btnLogo2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogo2.Location = New System.Drawing.Point(0, 69)
        Me.btnLogo2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLogo2.Name = "btnLogo2"
        Me.btnLogo2.Size = New System.Drawing.Size(497, 28)
        Me.btnLogo2.TabIndex = 10000075
        Me.btnLogo2.TabStop = False
        Me.btnLogo2.Text = "W H E R E  I N T E G R A T I O N  M E E T S  I N F O R M A T I O N"
        Me.btnLogo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogo2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogo2.UseVisualStyleBackColor = False
        '
        'btnLogo
        '
        Me.btnLogo.BackColor = System.Drawing.Color.Transparent
        Me.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogo.FlatAppearance.BorderSize = 0
        Me.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogo.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogo.ForeColor = System.Drawing.Color.White
        Me.btnLogo.Image = CType(resources.GetObject("btnLogo.Image"), System.Drawing.Image)
        Me.btnLogo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogo.Location = New System.Drawing.Point(0, 24)
        Me.btnLogo.Name = "btnLogo"
        Me.btnLogo.Size = New System.Drawing.Size(497, 45)
        Me.btnLogo.TabIndex = 10000074
        Me.btnLogo.TabStop = False
        Me.btnLogo.Text = "IST"
        Me.btnLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnLogo.UseVisualStyleBackColor = False
        '
        'panelZaglavlje
        '
        Me.panelZaglavlje.BackColor = System.Drawing.Color.Transparent
        Me.panelZaglavlje.Controls.Add(Me.btnX)
        Me.panelZaglavlje.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelZaglavlje.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelZaglavlje.Location = New System.Drawing.Point(0, 0)
        Me.panelZaglavlje.Name = "panelZaglavlje"
        Me.panelZaglavlje.Size = New System.Drawing.Size(497, 24)
        Me.panelZaglavlje.TabIndex = 10000082
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.Transparent
        Me.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnX.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnX.FlatAppearance.BorderSize = 0
        Me.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnX.ForeColor = System.Drawing.Color.White
        Me.btnX.Image = CType(resources.GetObject("btnX.Image"), System.Drawing.Image)
        Me.btnX.Location = New System.Drawing.Point(447, 0)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(50, 24)
        Me.btnX.TabIndex = 10000083
        Me.btnX.TabStop = False
        Me.btnX.UseVisualStyleBackColor = False
        '
        'btnCrta
        '
        Me.btnCrta.BackColor = System.Drawing.Color.Transparent
        Me.btnCrta.BackgroundImage = CType(resources.GetObject("btnCrta.BackgroundImage"), System.Drawing.Image)
        Me.btnCrta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCrta.FlatAppearance.BorderSize = 0
        Me.btnCrta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCrta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCrta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrta.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrta.ForeColor = System.Drawing.Color.Transparent
        Me.btnCrta.Location = New System.Drawing.Point(43, 209)
        Me.btnCrta.Name = "btnCrta"
        Me.btnCrta.Size = New System.Drawing.Size(412, 15)
        Me.btnCrta.TabIndex = 10000083
        Me.btnCrta.TabStop = False
        Me.btnCrta.UseVisualStyleBackColor = False
        '
        'lblNapomena
        '
        Me.lblNapomena.BackColor = System.Drawing.Color.Transparent
        Me.lblNapomena.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNapomena.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblNapomena.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNapomena.Location = New System.Drawing.Point(99, 11)
        Me.lblNapomena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNapomena.Name = "lblNapomena"
        Me.lblNapomena.Size = New System.Drawing.Size(299, 53)
        Me.lblNapomena.TabIndex = 10000083
        Me.lblNapomena.Text = "a"
        Me.lblNapomena.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.Transparent
        Me.panelFooter.Controls.Add(Me.lblNapomena)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 333)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(497, 71)
        Me.panelFooter.TabIndex = 10000078
        '
        'btnEye1
        '
        Me.btnEye1.BackColor = System.Drawing.SystemColors.Menu
        Me.btnEye1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEye1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEye1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.btnEye1.FlatAppearance.BorderSize = 0
        Me.btnEye1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu
        Me.btnEye1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu
        Me.btnEye1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEye1.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEye1.ForeColor = System.Drawing.Color.White
        Me.btnEye1.Image = CType(resources.GetObject("btnEye1.Image"), System.Drawing.Image)
        Me.btnEye1.Location = New System.Drawing.Point(368, 43)
        Me.btnEye1.Name = "btnEye1"
        Me.btnEye1.Size = New System.Drawing.Size(28, 20)
        Me.btnEye1.TabIndex = 10000088
        Me.btnEye1.TabStop = False
        Me.btnEye1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEye1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEye1.UseVisualStyleBackColor = False
        '
        'btnEye2
        '
        Me.btnEye2.BackColor = System.Drawing.SystemColors.Menu
        Me.btnEye2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEye2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEye2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.btnEye2.FlatAppearance.BorderSize = 0
        Me.btnEye2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu
        Me.btnEye2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu
        Me.btnEye2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEye2.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEye2.ForeColor = System.Drawing.Color.White
        Me.btnEye2.Image = CType(resources.GetObject("btnEye2.Image"), System.Drawing.Image)
        Me.btnEye2.Location = New System.Drawing.Point(368, 103)
        Me.btnEye2.Name = "btnEye2"
        Me.btnEye2.Size = New System.Drawing.Size(28, 20)
        Me.btnEye2.TabIndex = 10000089
        Me.btnEye2.TabStop = False
        Me.btnEye2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEye2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEye2.UseVisualStyleBackColor = False
        '
        'panelKontrole
        '
        Me.panelKontrole.BackColor = System.Drawing.Color.Transparent
        Me.panelKontrole.Controls.Add(Me.btnEye2)
        Me.panelKontrole.Controls.Add(Me.btnCrta)
        Me.panelKontrole.Controls.Add(Me.btnEye1)
        Me.panelKontrole.Controls.Add(Me.lblLozinka)
        Me.panelKontrole.Controls.Add(Me.txtNovaLozinka)
        Me.panelKontrole.Controls.Add(Me.btnPromenaLozinke)
        Me.panelKontrole.Controls.Add(Me.lblLozinka2)
        Me.panelKontrole.Controls.Add(Me.txtNovaLozinka2)
        Me.panelKontrole.Location = New System.Drawing.Point(0, 103)
        Me.panelKontrole.Name = "panelKontrole"
        Me.panelKontrole.Size = New System.Drawing.Size(497, 229)
        Me.panelKontrole.TabIndex = 10000090
        '
        'FormLoginZIzmenaLozinke
        '
        Me.AutoScroll = False
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(497, 404)
        Me.Controls.Add(Me.btnLogo2)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.panelZaglavlje)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.labVerzija)
        Me.Controls.Add(Me.txtNacinRada)
        Me.Controls.Add(Me.panelKontrole)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLoginZIzmenaLozinke"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST CAPI"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelZaglavlje.ResumeLayout(False)
        Me.panelFooter.ResumeLayout(False)
        Me.panelKontrole.ResumeLayout(False)
        Me.panelKontrole.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Private objMutex As System.Threading.Mutex

    'Dim Cekaj1Tekst As String = "САЧЕКАЈТЕ!"
    Dim StopThread As Boolean = False

    Dim ISTConnectionString As String = ""
    Dim DSBrisanjeDEPO As String = ""
    Dim DSBrisanjeServer As String = ""
    Dim DSBrisanjeBaza As String = ""
    Dim jezik As String = ""
    Public dtZ As DataTable = Nothing
    Public KosamNEW As String = ""
    Dim txtmode As String = ""
    Dim DEPOConnString As String = ""
    Dim userName As String = ""
    Dim lozinka As String = ""
    Dim theme As String = ""

    Public Sub New(ByVal ISTConnectionString As String, ByVal DSBrisanjeDEPO As String, ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String, ByVal jezik As String, ByVal txtmode As String, ByVal userName As String, ByVal lozinka As String, ByVal theme As String)

        Me.New()

        Me.ISTConnectionString = ISTConnectionString
        Me.DSBrisanjeDEPO = DSBrisanjeDEPO
        Me.DSBrisanjeServer = DSBrisanjeServer
        Me.DSBrisanjeBaza = DSBrisanjeBaza
        Me.jezik = jezik
        Me.txtmode = txtmode
        Me.DEPOConnString = getConnectionString("", DSBrisanjeBaza, txtmode, "")
        Me.userName = userName
        Me.lozinka = lozinka
        Me.theme = theme
        setTheme(theme)

    End Sub

    Sub setTheme(ByVal theme As String)
        If theme = "Light" Then
            ISTTheme.ChosenTheme("Light")
            Me.BackColor = ISTTheme.PanelParent
        ElseIf theme = "A1" Then
            ISTTheme.ChosenTheme("A1")
            Me.BackColor = ISTTheme.PanelParent
        ElseIf theme = "A2" Then
            ISTTheme.ChosenTheme("A2")
            Me.BackColor = ISTTheme.PanelParent
        ElseIf theme = "A3" Then
            ISTTheme.ChosenTheme("A3")
            Me.BackColor = ISTTheme.PanelParent
        ElseIf theme = "A4" Then
            ISTTheme.ChosenTheme("A4")
            Me.BackColor = ISTTheme.PanelParent
        ElseIf theme = "A5" Then
            ISTTheme.ChosenTheme("A5")
            Me.BackColor = ISTTheme.PanelParent
        ElseIf theme = "A6" Then
            ISTTheme.ChosenTheme("A6")
            Me.BackColor = ISTTheme.PanelParent
        ElseIf theme = "A7" Then
            ISTTheme.ChosenTheme("A7")
            Me.BackColor = ISTTheme.PanelParent
        Else
            ISTTheme.ChosenTheme("Dark")
            Me.BackColor = ISTTheme.PanelParent
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnPromenaLozinke.Click
        Me.Cursor = Cursors.WaitCursor
        Dim MsgPoruka As String = ""
        'Dim ExitApp As Boolean = False
        Dim AzuriranaUNICAPI_APP As Boolean = False
        Dim PreuzetiISTMetaPodaciSaServera As Boolean = False
        Dim CorrectionsDone As Boolean = False
        Dim CorrectionsErrorMsg As String = ""
        Dim StatusAzuriranja As String = ""
        Dim StatusCorrection As String = ""
        Dim StatusLocalDB As String = "" 'status za LocalDB
        Dim StatusLogin As String = ""
        Dim StatusImaPravNaIstrazivanje As String = ""

        Dim KorisnikAutentifikovan As Boolean = False
        Dim ImaDodeljenihIstrazivanja As Boolean = False
        Dim PromeniNacinRada As Boolean = False
        Dim MozeDalje As Boolean = True
        Dim nacinrada As String = ""
        Dim onInternet As Boolean = False
        btnPromenaLozinke.Enabled = False
        Dim RacunarKorisnika As String = Environment.MachineName
        Dim IPAdresaKorisnika As String = System.Net.Dns.GetHostByName(HostName()).AddressList(0).ToString()

        Dim msg As String = ""
        onInternet = isConnected()
        KosamNEW = ""
        txtNovaLozinka.Focus()
        If onInternet = True Then
            If txtNovaLozinka.Text.Trim = "" OrElse txtNovaLozinka2.Text.Trim = "" Then
                msg = getMessageText(dtMessages, "604", Me.jezik)
                '"Morate popuniti oba polja za password!"
                Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                ISTMessageBox.Show(msg)
                btnPromenaLozinke.Enabled = True
            Else
                If lozinka = txtNovaLozinka.Text.Trim OrElse lozinka = txtNovaLozinka2.Text.Trim Then
                    msg = getMessageText(dtMessages, "605", Me.jezik)
                    '"Lozinka ne može biti ista kao inicijalna!"
                    Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                    ISTMessageBox.Show(msg)
                    btnPromenaLozinke.Enabled = True
                Else
                    If txtNovaLozinka.Text = txtNovaLozinka2.Text Then
                        If txtNovaLozinka.Text.Trim.Length >= 8 AndAlso txtNovaLozinka2.Text.Trim.Length >= 8 Then
                            If txtNovaLozinka.Text.IndexOf(" ") >= 0 Then
                                msg = getMessageText(dtMessages, "606", Me.jezik)
                                '= "Neispravna lozinka!"
                                Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                                ISTMessageBox.Show(msg)
                                btnPromenaLozinke.Enabled = True
                            Else
                                Dim struser As String = "exec NewPassUpdate N'" + userName + "' , N'" + txtNovaLozinka.Text.Trim + "'"
                                Try
                                    Dim dt As DataTable = izvrsiSQLvratiDT(struser, ISTConnectionString, Me.jezik)
                                    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                                        If dt.Rows(0).Item(0).ToString.Trim.ToUpper = "PROSLO VREME" Then
                                            msg = getMessageText(dtMessages, "625", Me.jezik)
                                            Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                                            ISTMessageBox.Show(msg)
                                        Else
                                            msg = getMessageText(dtMessages, "607", Me.jezik)
                                            '= "Uspešno promenjena lozinka! Morate se ulogovati sa novom lozinkom!"
                                            Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                                            ISTMessageBox.Show(msg)
                                        End If
                                    Else
                                        msg = getMessageText(dtMessages, "627", Me.jezik)
                                        Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                                        ISTMessageBox.Show(msg)

                                    End If
                                Catch ex As System.Exception
                                    ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End Try
                                Me.Cursor = Cursors.Default
                                Me.Close()
                            End If
                        Else
                            msg = getMessageText(dtMessages, "608", Me.jezik)
                            '"Lozinka mora biti minimalno dužine 8"
                            Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                            ISTMessageBox.Show(msg)
                            btnPromenaLozinke.Enabled = True
                        End If
                    Else
                        msg = getMessageText(dtMessages, "609", Me.jezik)
                        ' "Lozinke nisu identične!"
                        Call UpisiULogMonitoring("2", userName.Trim, "", "InitialPassChange - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                        ISTMessageBox.Show(msg)
                        btnPromenaLozinke.Enabled = True
                    End If
                End If

            End If
        Else
            msg = getMessageText(dtMessages, "603", Me.jezik)
            ISTMessageBox.Show(msg)
            '("Nema interneta")
        End If


        Me.Cursor = Cursors.Default

    End Sub

    Private Sub SetLang()

        Dim dt As DataTable = getDTVBText(dtLang, "FormLoginZIzmenaLozinke")
        lblLozinka.Text = getControlText2(dt, "lblLozinka", Me.jezik)
        lblLozinka2.Text = getControlText2(dt, "lblLozinka2", Me.jezik)
        btnPromenaLozinke.Text = getControlText2(dt, "btnPromenaLozinke", Me.jezik)
        lblNapomena.Text = getControlText2(dt, "lblNapomena", Me.jezik)

    End Sub
    Public Shared Function isConnected() As Boolean
        Try
            Dim addresslist As Net.IPAddress() = Dns.GetHostAddresses("www.google.com")
            If addresslist(0).ToString().Length > 6 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Sockets.SocketException
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Shared Function HostName() As String

        Dim strHostName As String = ""
        Dim strIPAddress As String = ""

        strHostName = System.Net.Dns.GetHostName()
        'strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()

        Return strHostName

    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Dim msg As String = getMessageText(dtMessages, "610", Me.jezik)
        ISTMessageBox.Show(msg)
        '("Niste promenili lozinku, ne možete se logovati!")
        Me.Close()
    End Sub

    Private Sub LoginFormIST_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim onInternet As Boolean = False
        onInternet = isConnected()
        If onInternet = False Then
            Dim msg As String = getMessageText(dtMessages, "611", Me.jezik)
            ISTMessageBox.Show(msg)
            '("Niste konektovani na internet!")
            Me.Close()
        End If
        lblNapomena.Text = "Lozinka mora da bude minimalne dužine 8 karaktera." + nvrd + "Razmaci nisu dozvoljeni!"

        btnEye1.Image = My.Resources.eyeOrange.ToBitmap
        pomEye1 = "ORANGE"
        txtNovaLozinka.PasswordChar = "*"

        btnEye2.Image = My.Resources.eyeOrange.ToBitmap
        pomEye2 = "ORANGE"
        txtNovaLozinka2.PasswordChar = "*"
        Call SetLang()

        Dim RezJava As Boolean = False 'ProveraJava32Exist()
        'If RezJava = False Then
        '    'Dim result As DialogResult = ISTMessageBox.Show(Translate.TranslateLanguage.getMessageText(Translate.TranslateLanguage.dtMessages, "66", jezik), "", MessageBoxButtons.YesNo)
        '    If result = DialogResult.No Then
        '        Application.Exit()
        '    ElseIf result = DialogResult.Yes Then
        '        'ISTMessageBox.Show("Yes pressed")
        '        Dim Komanda As String = "/C START /min /wait https://webrzs.stat.gov.rs/wsISTCAPI/Install/jre-8u251-windows-i586.exe"
        '        b.Run_CMD(Komanda)
        '    End If
        'End If

        'Postavi_labNacinRada()
    End Sub

    Dim pomEye1 As String = ""
    Dim pomEye2 As String = ""

    'Private Sub btnEye1_Click(sender As Object, e As EventArgs)
    '    If pomEye1 = "ORANGE" Then
    '        btnEye2.Image = My.Resources.eyeBlue.ToBitmap
    '        pomEye1 = "BLUE"
    '        txtNovaLozinka.PasswordChar = Nothing
    '    Else
    '        btnEye1.Image = My.Resources.eyeOrange.ToBitmap
    '        pomEye1 = "ORANGE"
    '        txtNovaLozinka.PasswordChar = "*"
    '    End If
    'End Sub

    'Private Sub btnEye2_Click(sender As Object, e As EventArgs) Handles btnEye1.Click

    '    If pomEye2 = "ORANGE" Then
    '        btnEye2.Image = My.Resources.eyeBlue.ToBitmap
    '        pomEye2 = "BLUE"
    '        txtNovaLozinka2.PasswordChar = Nothing
    '    Else
    '        btnEye2.Image = My.Resources.eyeOrange.ToBitmap
    '        pomEye2 = "ORANGE"
    '        txtNovaLozinka2.PasswordChar = "*"
    '    End If
    'End Sub

    Dim WithEvents timer1 As New System.Windows.Forms.Timer
    Dim milliseconds1 As Integer = 0
    Dim WithEvents timer2 As New System.Windows.Forms.Timer
    Dim milliseconds2 As Integer = 0


    Private Sub btnEye1_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEye1.MouseDown
        milliseconds1 = 0
        timer1.Start()
        btnEye1.Image = My.Resources.eyeBlue.ToBitmap
        pomEye1 = "BLUE"
        txtNovaLozinka.PasswordChar = Nothing
        Me.btnEye1.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnEye1_MouseUp(sender As Object, e As MouseEventArgs) Handles btnEye1.MouseUp
        timer1.Stop()
        If milliseconds1 >= 0 Then
            btnEye1.Image = My.Resources.eyeOrange.ToBitmap
            pomEye1 = "ORANGE"
            txtNovaLozinka.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnEye1Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer1.Tick
        milliseconds1 += 1
    End Sub

    Private Sub btnEye2_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEye2.MouseDown
        milliseconds2 = 0
        timer2.Start()
        btnEye2.Image = My.Resources.eyeBlue.ToBitmap
        pomEye2 = "BLUE"
        txtNovaLozinka2.PasswordChar = Nothing
        Me.btnEye2.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnEye2_MouseUp(sender As Object, e As MouseEventArgs) Handles btnEye2.MouseUp
        timer2.Stop()
        If milliseconds2 >= 0 Then
            btnEye2.Image = My.Resources.eyeOrange.ToBitmap
            pomEye2 = "ORANGE"
            txtNovaLozinka2.PasswordChar = "*"
        End If
    End Sub

    Private Sub btnEye2Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer2.Tick
        milliseconds2 += 1
    End Sub

    Private Sub FormLoginZIzmenaLozinke_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtNovaLozinka.Focus()
    End Sub

    Private Sub fPreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles txtNovaLozinka.PreviewKeyDown, txtNovaLozinka2.PreviewKeyDown
        'If e.KeyData = Keys.Tab Then
        '    e.IsInputKey = True
        'End If
    End Sub

    Private Sub TextBoxUserID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNovaLozinka.KeyDown, txtNovaLozinka2.KeyDown

        Dim tbox As TextBox = DirectCast(sender, TextBox)
        Dim p As Object = tbox.Parent
        Select Case e.KeyCode
            Case Keys.Enter
                Dim k As Control = fKeysDown(tbox.TabIndex, tbox.Parent)
                If Not k Is Nothing Then k.Focus()
                e.SuppressKeyPress = True
            Case Keys.Up
                e.SuppressKeyPress = False
            Case Keys.Down
                e.SuppressKeyPress = False
            Case Keys.Tab
                'e.SuppressKeyPress = False
            Case Else
        End Select
    End Sub

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

    Function fKeysDown(ByVal ti As Integer, ByVal p As Panel) As Control
        fKeysDown = Nothing
        Dim k As Control = p.GetNextControl(p, True) 'Get the first control in the tab order.
        Do Until k Is Nothing  'MORA PREKO LOOPA
            If (TypeOf k Is TextBox OrElse TypeOf k Is Button) AndAlso k.TabIndex > 0 AndAlso k.Visible = True AndAlso k.Enabled = True AndAlso k.TabStop = True Then
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

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btnEye1.Paint, btnEye2.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(System.Drawing.SystemColors.Menu)
            e.Graphics.DrawRectangle(P, 4, 4, 19, 14)
        End Using
    End Sub

    Dim MoveForm As Boolean
    Dim MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles panelZaglavlje.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles panelZaglavlje.MouseMove

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles panelZaglavlje.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub btnPromenaLozinke_GotFocus(sender As Object, e As EventArgs) Handles btnPromenaLozinke.GotFocus
        Dim dugme As Button = CType(sender, Button)
        dugme.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnPromenaLozinke_LostFocus(sender As Object, e As EventArgs) Handles btnPromenaLozinke.LostFocus
        Dim dugme As Button = CType(sender, Button)
        dugme.FlatAppearance.BorderSize = 0
    End Sub

End Class