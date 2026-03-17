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
Imports System.Diagnostics
Imports System.Security.Cryptography
Imports System.Linq
Imports Microsoft.VisualBasic
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports System.Xml.Linq
Imports System.Net.Security


Public Class FormLoginZ
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
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents txtNacinRada As TextBox
    Friend WithEvents labVerzija As Label
    Friend WithEvents btnLogo2 As Button
    Friend WithEvents btnLogo As Button
    Friend WithEvents panelFooter As Panel
    Friend WithEvents pcbOffLineOnline As PictureBox
    Friend WithEvents panelZaglavlje As Panel
    Friend WithEvents btnCrta As Button
    Friend WithEvents btnEye As Button
    Friend WithEvents panelKontrole As Panel
    Friend WithEvents llForgotPass As LinkLabel
    Friend WithEvents panelForgotPass As Panel
    Friend WithEvents tboxFoPassEmail As TextBox
    Friend WithEvents lblFoPassEmail As Label
    Friend WithEvents lblFoPassUser As Label
    Friend WithEvents tboxFoPassUser As TextBox
    Friend WithEvents tboxFoPassName As TextBox
    Friend WithEvents lblFoPassName As Label
    Friend WithEvents btnFoPass As Button
    Friend WithEvents btnFoPassLogo2 As Button
    Friend WithEvents btnFoPassLogo As Button
    Friend WithEvents panelFoPassZaglavlje As Panel
    Friend WithEvents btnFoPassX As Button
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnX As Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginZ))
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.txtNacinRada = New System.Windows.Forms.TextBox()
        Me.labVerzija = New System.Windows.Forms.Label()
        Me.btnLogo2 = New System.Windows.Forms.Button()
        Me.btnLogo = New System.Windows.Forms.Button()
        Me.panelFooter = New System.Windows.Forms.Panel()
        Me.llForgotPass = New System.Windows.Forms.LinkLabel()
        Me.pcbOffLineOnline = New System.Windows.Forms.PictureBox()
        Me.panelZaglavlje = New System.Windows.Forms.Panel()
        Me.btnX = New System.Windows.Forms.Button()
        Me.btnCrta = New System.Windows.Forms.Button()
        Me.btnEye = New System.Windows.Forms.Button()
        Me.panelKontrole = New System.Windows.Forms.Panel()
        Me.panelForgotPass = New System.Windows.Forms.Panel()
        Me.btnFoPassLogo2 = New System.Windows.Forms.Button()
        Me.btnFoPassLogo = New System.Windows.Forms.Button()
        Me.panelFoPassZaglavlje = New System.Windows.Forms.Panel()
        Me.btnFoPassX = New System.Windows.Forms.Button()
        Me.tboxFoPassEmail = New System.Windows.Forms.TextBox()
        Me.btnFoPass = New System.Windows.Forms.Button()
        Me.lblFoPassEmail = New System.Windows.Forms.Label()
        Me.lblFoPassUser = New System.Windows.Forms.Label()
        Me.tboxFoPassUser = New System.Windows.Forms.TextBox()
        Me.tboxFoPassName = New System.Windows.Forms.TextBox()
        Me.lblFoPassName = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFooter.SuspendLayout()
        CType(Me.pcbOffLineOnline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelZaglavlje.SuspendLayout()
        Me.panelKontrole.SuspendLayout()
        Me.panelForgotPass.SuspendLayout()
        Me.panelFoPassZaglavlje.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPass
        '
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.ForeColor = System.Drawing.Color.White
        Me.lblPass.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPass.Location = New System.Drawing.Point(96, 80)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(302, 21)
        Me.lblPass.TabIndex = 8
        Me.lblPass.Text = "Password:"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblUser.Location = New System.Drawing.Point(96, 20)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(300, 21)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "User ID:"
        Me.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxPassword.Location = New System.Drawing.Point(99, 102)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxPassword.MaxLength = 50
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(299, 27)
        Me.TextBoxPassword.TabIndex = 10
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUserID.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUserID.Location = New System.Drawing.Point(99, 42)
        Me.TextBoxUserID.Margin = New System.Windows.Forms.Padding(1)
        Me.TextBoxUserID.MaxLength = 20
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(299, 27)
        Me.TextBoxUserID.TabIndex = 9
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Location = New System.Drawing.Point(99, 162)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(299, 34)
        Me.btnLogIn.TabIndex = 11
        Me.btnLogIn.Text = "ЛОГОВАЊЕ"
        Me.btnLogIn.UseVisualStyleBackColor = False
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
        'panelFooter
        '
        Me.panelFooter.BackColor = System.Drawing.Color.Transparent
        Me.panelFooter.Controls.Add(Me.lblVersion)
        Me.panelFooter.Controls.Add(Me.llForgotPass)
        Me.panelFooter.Controls.Add(Me.pcbOffLineOnline)
        Me.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelFooter.Location = New System.Drawing.Point(0, 356)
        Me.panelFooter.Name = "panelFooter"
        Me.panelFooter.Size = New System.Drawing.Size(497, 48)
        Me.panelFooter.TabIndex = 10000078
        '
        'llForgotPass
        '
        Me.llForgotPass.ActiveLinkColor = System.Drawing.Color.DarkRed
        Me.llForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.llForgotPass.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.llForgotPass.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llForgotPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.llForgotPass.LinkColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.llForgotPass.Location = New System.Drawing.Point(100, 12)
        Me.llForgotPass.Name = "llForgotPass"
        Me.llForgotPass.Size = New System.Drawing.Size(296, 16)
        Me.llForgotPass.TabIndex = 10000084
        Me.llForgotPass.TabStop = True
        Me.llForgotPass.Text = "Forgot password?"
        Me.llForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbOffLineOnline
        '
        Me.pcbOffLineOnline.Image = CType(resources.GetObject("pcbOffLineOnline.Image"), System.Drawing.Image)
        Me.pcbOffLineOnline.Location = New System.Drawing.Point(12, 3)
        Me.pcbOffLineOnline.Name = "pcbOffLineOnline"
        Me.pcbOffLineOnline.Size = New System.Drawing.Size(34, 35)
        Me.pcbOffLineOnline.TabIndex = 126
        Me.pcbOffLineOnline.TabStop = False
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
        Me.btnCrta.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.btnCrta.ForeColor = System.Drawing.Color.Transparent
        Me.btnCrta.Location = New System.Drawing.Point(43, 209)
        Me.btnCrta.Name = "btnCrta"
        Me.btnCrta.Size = New System.Drawing.Size(410, 15)
        Me.btnCrta.TabIndex = 10000083
        Me.btnCrta.TabStop = False
        Me.btnCrta.UseVisualStyleBackColor = False
        '
        'btnEye
        '
        Me.btnEye.BackColor = System.Drawing.SystemColors.Menu
        Me.btnEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEye.FlatAppearance.BorderColor = System.Drawing.SystemColors.Menu
        Me.btnEye.FlatAppearance.BorderSize = 0
        Me.btnEye.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Menu
        Me.btnEye.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Menu
        Me.btnEye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEye.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEye.ForeColor = System.Drawing.Color.White
        Me.btnEye.Image = CType(resources.GetObject("btnEye.Image"), System.Drawing.Image)
        Me.btnEye.Location = New System.Drawing.Point(368, 103)
        Me.btnEye.Name = "btnEye"
        Me.btnEye.Size = New System.Drawing.Size(28, 20)
        Me.btnEye.TabIndex = 10000087
        Me.btnEye.TabStop = False
        Me.btnEye.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEye.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnEye.UseVisualStyleBackColor = False
        '
        'panelKontrole
        '
        Me.panelKontrole.BackColor = System.Drawing.Color.Transparent
        Me.panelKontrole.Controls.Add(Me.lblUser)
        Me.panelKontrole.Controls.Add(Me.btnEye)
        Me.panelKontrole.Controls.Add(Me.TextBoxUserID)
        Me.panelKontrole.Controls.Add(Me.TextBoxPassword)
        Me.panelKontrole.Controls.Add(Me.lblPass)
        Me.panelKontrole.Controls.Add(Me.btnCrta)
        Me.panelKontrole.Controls.Add(Me.btnLogIn)
        Me.panelKontrole.Location = New System.Drawing.Point(0, 103)
        Me.panelKontrole.Name = "panelKontrole"
        Me.panelKontrole.Size = New System.Drawing.Size(497, 247)
        Me.panelKontrole.TabIndex = 10000084
        '
        'panelForgotPass
        '
        Me.panelForgotPass.BackColor = System.Drawing.Color.Transparent
        Me.panelForgotPass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelForgotPass.Controls.Add(Me.btnFoPassLogo2)
        Me.panelForgotPass.Controls.Add(Me.btnFoPassLogo)
        Me.panelForgotPass.Controls.Add(Me.panelFoPassZaglavlje)
        Me.panelForgotPass.Controls.Add(Me.tboxFoPassEmail)
        Me.panelForgotPass.Controls.Add(Me.btnFoPass)
        Me.panelForgotPass.Controls.Add(Me.lblFoPassEmail)
        Me.panelForgotPass.Controls.Add(Me.lblFoPassUser)
        Me.panelForgotPass.Controls.Add(Me.tboxFoPassUser)
        Me.panelForgotPass.Controls.Add(Me.tboxFoPassName)
        Me.panelForgotPass.Controls.Add(Me.lblFoPassName)
        Me.panelForgotPass.Location = New System.Drawing.Point(3, 3)
        Me.panelForgotPass.Name = "panelForgotPass"
        Me.panelForgotPass.Size = New System.Drawing.Size(491, 398)
        Me.panelForgotPass.TabIndex = 10000089
        Me.panelForgotPass.Visible = False
        '
        'btnFoPassLogo2
        '
        Me.btnFoPassLogo2.BackColor = System.Drawing.Color.Transparent
        Me.btnFoPassLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFoPassLogo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFoPassLogo2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFoPassLogo2.FlatAppearance.BorderSize = 0
        Me.btnFoPassLogo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFoPassLogo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFoPassLogo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoPassLogo2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoPassLogo2.ForeColor = System.Drawing.Color.White
        Me.btnFoPassLogo2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFoPassLogo2.Location = New System.Drawing.Point(0, 69)
        Me.btnFoPassLogo2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnFoPassLogo2.Name = "btnFoPassLogo2"
        Me.btnFoPassLogo2.Size = New System.Drawing.Size(487, 28)
        Me.btnFoPassLogo2.TabIndex = 10000095
        Me.btnFoPassLogo2.TabStop = False
        Me.btnFoPassLogo2.Text = "W H E R E  I N T E G R A T I O N  M E E T S  I N F O R M A T I O N"
        Me.btnFoPassLogo2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFoPassLogo2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFoPassLogo2.UseVisualStyleBackColor = False
        '
        'btnFoPassLogo
        '
        Me.btnFoPassLogo.BackColor = System.Drawing.Color.Transparent
        Me.btnFoPassLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFoPassLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnFoPassLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFoPassLogo.FlatAppearance.BorderSize = 0
        Me.btnFoPassLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFoPassLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnFoPassLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoPassLogo.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoPassLogo.ForeColor = System.Drawing.Color.White
        Me.btnFoPassLogo.Image = CType(resources.GetObject("btnFoPassLogo.Image"), System.Drawing.Image)
        Me.btnFoPassLogo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFoPassLogo.Location = New System.Drawing.Point(0, 24)
        Me.btnFoPassLogo.Name = "btnFoPassLogo"
        Me.btnFoPassLogo.Size = New System.Drawing.Size(487, 45)
        Me.btnFoPassLogo.TabIndex = 10000094
        Me.btnFoPassLogo.TabStop = False
        Me.btnFoPassLogo.Text = "IST"
        Me.btnFoPassLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFoPassLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnFoPassLogo.UseVisualStyleBackColor = False
        '
        'panelFoPassZaglavlje
        '
        Me.panelFoPassZaglavlje.Controls.Add(Me.btnFoPassX)
        Me.panelFoPassZaglavlje.Cursor = System.Windows.Forms.Cursors.Default
        Me.panelFoPassZaglavlje.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelFoPassZaglavlje.Location = New System.Drawing.Point(0, 0)
        Me.panelFoPassZaglavlje.Name = "panelFoPassZaglavlje"
        Me.panelFoPassZaglavlje.Size = New System.Drawing.Size(487, 24)
        Me.panelFoPassZaglavlje.TabIndex = 10000096
        '
        'btnFoPassX
        '
        Me.btnFoPassX.BackColor = System.Drawing.Color.Transparent
        Me.btnFoPassX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFoPassX.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFoPassX.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnFoPassX.FlatAppearance.BorderSize = 0
        Me.btnFoPassX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnFoPassX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnFoPassX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoPassX.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoPassX.ForeColor = System.Drawing.Color.White
        Me.btnFoPassX.Image = CType(resources.GetObject("btnFoPassX.Image"), System.Drawing.Image)
        Me.btnFoPassX.Location = New System.Drawing.Point(437, 0)
        Me.btnFoPassX.Name = "btnFoPassX"
        Me.btnFoPassX.Size = New System.Drawing.Size(50, 24)
        Me.btnFoPassX.TabIndex = 10000083
        Me.btnFoPassX.TabStop = False
        Me.btnFoPassX.UseVisualStyleBackColor = False
        '
        'tboxFoPassEmail
        '
        Me.tboxFoPassEmail.BackColor = System.Drawing.SystemColors.Menu
        Me.tboxFoPassEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxFoPassEmail.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxFoPassEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tboxFoPassEmail.Location = New System.Drawing.Point(95, 257)
        Me.tboxFoPassEmail.Margin = New System.Windows.Forms.Padding(1)
        Me.tboxFoPassEmail.MaxLength = 50
        Me.tboxFoPassEmail.Name = "tboxFoPassEmail"
        Me.tboxFoPassEmail.Size = New System.Drawing.Size(299, 27)
        Me.tboxFoPassEmail.TabIndex = 10000089
        '
        'btnFoPass
        '
        Me.btnFoPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnFoPass.FlatAppearance.BorderSize = 0
        Me.btnFoPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFoPass.ForeColor = System.Drawing.Color.White
        Me.btnFoPass.Location = New System.Drawing.Point(95, 321)
        Me.btnFoPass.Name = "btnFoPass"
        Me.btnFoPass.Size = New System.Drawing.Size(299, 34)
        Me.btnFoPass.TabIndex = 10000091
        Me.btnFoPass.Text = "ПОШАЉИ ЗАХТЕВ ЗА ПРОМЕНУ ЛОЗИНКЕ"
        Me.btnFoPass.UseVisualStyleBackColor = False
        '
        'lblFoPassEmail
        '
        Me.lblFoPassEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblFoPassEmail.ForeColor = System.Drawing.Color.White
        Me.lblFoPassEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFoPassEmail.Location = New System.Drawing.Point(92, 233)
        Me.lblFoPassEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoPassEmail.Name = "lblFoPassEmail"
        Me.lblFoPassEmail.Size = New System.Drawing.Size(301, 21)
        Me.lblFoPassEmail.TabIndex = 10000090
        Me.lblFoPassEmail.Text = "Email:"
        Me.lblFoPassEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFoPassUser
        '
        Me.lblFoPassUser.BackColor = System.Drawing.Color.Transparent
        Me.lblFoPassUser.ForeColor = System.Drawing.Color.White
        Me.lblFoPassUser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFoPassUser.Location = New System.Drawing.Point(92, 121)
        Me.lblFoPassUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoPassUser.Name = "lblFoPassUser"
        Me.lblFoPassUser.Size = New System.Drawing.Size(301, 21)
        Me.lblFoPassUser.TabIndex = 10000085
        Me.lblFoPassUser.Text = "User ID:"
        Me.lblFoPassUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tboxFoPassUser
        '
        Me.tboxFoPassUser.BackColor = System.Drawing.SystemColors.Menu
        Me.tboxFoPassUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxFoPassUser.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxFoPassUser.Location = New System.Drawing.Point(95, 145)
        Me.tboxFoPassUser.Margin = New System.Windows.Forms.Padding(1)
        Me.tboxFoPassUser.MaxLength = 20
        Me.tboxFoPassUser.Name = "tboxFoPassUser"
        Me.tboxFoPassUser.Size = New System.Drawing.Size(299, 27)
        Me.tboxFoPassUser.TabIndex = 10000087
        '
        'tboxFoPassName
        '
        Me.tboxFoPassName.BackColor = System.Drawing.SystemColors.Menu
        Me.tboxFoPassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tboxFoPassName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxFoPassName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tboxFoPassName.Location = New System.Drawing.Point(95, 201)
        Me.tboxFoPassName.Margin = New System.Windows.Forms.Padding(1)
        Me.tboxFoPassName.MaxLength = 50
        Me.tboxFoPassName.Name = "tboxFoPassName"
        Me.tboxFoPassName.Size = New System.Drawing.Size(299, 27)
        Me.tboxFoPassName.TabIndex = 10000088
        '
        'lblFoPassName
        '
        Me.lblFoPassName.BackColor = System.Drawing.Color.Transparent
        Me.lblFoPassName.ForeColor = System.Drawing.Color.White
        Me.lblFoPassName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFoPassName.Location = New System.Drawing.Point(92, 177)
        Me.lblFoPassName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFoPassName.Name = "lblFoPassName"
        Me.lblFoPassName.Size = New System.Drawing.Size(302, 21)
        Me.lblFoPassName.TabIndex = 10000086
        Me.lblFoPassName.Text = "Name:"
        Me.lblFoPassName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblVersion.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblVersion.Location = New System.Drawing.Point(368, 0)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(129, 48)
        Me.lblVersion.TabIndex = 10000085
        Me.lblVersion.Text = "V: 2023.10.27 10:55"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'FormLoginZ
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = False
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(497, 404)
        Me.Controls.Add(Me.panelKontrole)
        Me.Controls.Add(Me.btnLogo2)
        Me.Controls.Add(Me.btnLogo)
        Me.Controls.Add(Me.panelZaglavlje)
        Me.Controls.Add(Me.panelFooter)
        Me.Controls.Add(Me.labVerzija)
        Me.Controls.Add(Me.txtNacinRada)
        Me.Controls.Add(Me.panelForgotPass)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLoginZ"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST LOGIN"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFooter.ResumeLayout(False)
        CType(Me.pcbOffLineOnline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelZaglavlje.ResumeLayout(False)
        Me.panelKontrole.ResumeLayout(False)
        Me.panelKontrole.PerformLayout()
        Me.panelForgotPass.ResumeLayout(False)
        Me.panelForgotPass.PerformLayout()
        Me.panelFoPassZaglavlje.ResumeLayout(False)
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

    Public Sub New(ByVal ISTConnectionString As String, ByVal DSBrisanjeDEPO As String, ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String, ByVal jezik As String, ByVal txtmode As String)

        Me.New()

        Me.ISTConnectionString = ISTConnectionString
        Me.DSBrisanjeDEPO = DSBrisanjeDEPO
        Me.DSBrisanjeServer = DSBrisanjeServer
        Me.DSBrisanjeBaza = DSBrisanjeBaza
        Me.jezik = jezik
        Me.txtmode = txtmode
        Me.DEPOConnString = getConnectionString("", DSBrisanjeBaza, txtmode, "")

        Dim GetTheme As String = "Dark"
        Dim gde As String = System.Environment.GetEnvironmentVariable("TEMP") & "\ISTTheme.txt"
        If File.Exists(gde) Then
            Dim str As String = GetFileContents(gde)
            GetTheme = str.Trim.ToUpper
        End If
        setTheme(GetTheme)

        Dim ISTPath As String = Application.StartupPath
        Dim di As New IO.DirectoryInfo(ISTPath)



        Dim fi As IO.FileInfo = di.GetFiles("Version*.txt").FirstOrDefault()
        If Not fi Is Nothing Then
            Dim fileReader1 As String = My.Computer.FileSystem.ReadAllText(ISTPath + "\" + fi.Name)
            lblVersion.Text = "v_" + fileReader1.Trim + "  "
        Else
            lblVersion.Text = ""
        End If


        lblVersion.Text = lblVersion.Text + nvrd
        'ISTMessageBox.Show("aaa")
        'ISTMessageBox.Show("aaa", "aaa", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        'ISTMessageBox.Show("aaa", "aaa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        'ISTMessageBox.Show("aaa", "aaa", MessageBoxButtons.OK, MessageBoxIcon.Question)
        'ISTMessageBox.Show("aaa", "aaa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


    End Sub

    Sub setTheme(ByVal theme As String)
        If theme = "Light" Then
            ISTTheme.ChosenTheme("Light")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        ElseIf theme = "A1" Then
            ISTTheme.ChosenTheme("A1")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        ElseIf theme = "A2" Then
            ISTTheme.ChosenTheme("A2")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        ElseIf theme = "A3" Then
            ISTTheme.ChosenTheme("A3")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        ElseIf theme = "A4" Then
            ISTTheme.ChosenTheme("A4")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        ElseIf theme = "A5" Then
            ISTTheme.ChosenTheme("A5")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        ElseIf theme = "A6" Then
            ISTTheme.ChosenTheme("A6")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        ElseIf theme = "A7" Then
            ISTTheme.ChosenTheme("A7")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        Else
            ISTTheme.ChosenTheme("Dark")
            Me.BackColor = ISTTheme.PanelParent
            'Me.btnLogIn.ForeColor = ISTTheme.PanelParent
            'Me.btnFoPass.ForeColor = ISTTheme.PanelParent
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

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
        btnLogIn.Enabled = False
        pcbOffLineOnline.Visible = True
        Dim RacunarKorisnika As String = Environment.MachineName
        Dim IPAdresaKorisnika As String = Dns.GetHostByName(HostName()).AddressList(0).ToString()
        Dim promenjenalozinka As Boolean = False
        Dim msg As String = ""

        'Dim hostname2 As IPHostEntry = Dns.GetHostByName("https://istcapi.stat.gov.rs/wsIST/service.asmx")
        'Dim ip As IPAddress() = hostname2.AddressList

        Dim ISTPath As String = Application.StartupPath

        Dim regVersion1 = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\IzabranDatum", True)
        If regVersion1 Is Nothing Then
            regVersion1 = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\IzabranDatum")
        End If

        If regVersion1 IsNot Nothing Then
            regVersion1.SetValue("ISTLocation", ISTPath, RegistryValueKind.String)
        End If

        onInternet = isConnected()

        Dim sqlLOG As String = ""
        KosamNEW = ""

        If onInternet = True Then
            pcbOffLineOnline.Image = My.Resources.wifi.ToBitmap
            Dim struser As String = "exec CheckISTUserApp N'" + TextBoxUserID.Text.Trim + "' , N'" + TextBoxPassword.Text.Trim + "'"
            Dim dt As DataTable = izvrsiSQLvratiDT(struser, ISTConnectionString, jezik)

            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item(0).ToString.Trim = "ISTEKLOVREME" Then
                    msg = getMessageText(dtMessages, "625", Me.jezik)
                    Call UpisiULogMonitoring("1", TextBoxUserID.Text.Trim, "", "LogIn - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                    ISTMessageBox.Show(msg)
                    btnLogIn.Enabled = True
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If
                If dt.Rows(0).Item(0).ToString.Trim = "INITIAL" Then
                    Call UpisiULogMonitoring("1", TextBoxUserID.Text.Trim, "", "LogIn - With initial pass.", "OK", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                    Me.Hide()
                    Dim frmloginZIzmenaLozinke As FormLoginZIzmenaLozinke = Nothing
                    Me.Enabled = False
                    frmloginZIzmenaLozinke = New FormLoginZIzmenaLozinke(ISTConnectionString, DSBrisanjeDEPO, DSBrisanjeServer, DSBrisanjeBaza, jezik, txtmode, TextBoxUserID.Text.Trim, TextBoxPassword.Text.Trim, GetTheme)
                    Try
                        frmloginZIzmenaLozinke.ShowDialog()
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        frmloginZIzmenaLozinke.Dispose()
                        Me.Show()
                        Me.Enabled = True
                        'If KosamNEW = "" Then
                        '    End
                        'End If
                        promenjenalozinka = True
                        TextBoxPassword.Text = ""
                        btnLogIn.Enabled = True
                        If TextBoxUserID.Text.Trim = "" Then
                            TextBoxUserID.Focus()
                        Else
                            TextBoxPassword.Focus()
                        End If
                    End Try
                End If
                If promenjenalozinka = True Then
                    btnLogIn.Enabled = True
                    Me.Cursor = Cursors.Default
                Else
                    If dt.Rows(0).Item(0).ToString.Trim = "0" Then
                        msg = getMessageText(dtMessages, "601", Me.jezik)
                        'msg = "Pogrešno korisničko ime ili lozinka"
                        Call UpisiULogMonitoring("1", TextBoxUserID.Text.Trim, "", "LogIn - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                        ISTMessageBox.Show(msg)
                        TextBoxPassword.Text = ""
                        If TextBoxUserID.Text.Trim = "" Then
                            TextBoxUserID.Focus()
                        Else
                            TextBoxPassword.Focus()
                        End If
                        btnLogIn.Enabled = True
                    Else
                        Me.dtZ = dt
                        KosamNEW = TextBoxUserID.Text.Trim
                        Dim regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\IzabranDatum", True)
                        If regVersion Is Nothing Then
                            regVersion = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\IzabranDatum")
                        End If

                        If regVersion IsNot Nothing Then
                            regVersion.SetValue("ISTuser", TextBoxUserID.Text, RegistryValueKind.String)
                        End If

                        ''Verzija IST-a na serveru
                        Dim VersionServer As String = ""
                        Dim strversion As String = "select istversion from ISTVersion"
                        Dim dtversion As DataTable = izvrsiSQLvratiDT(strversion, ISTConnectionString, jezik)
                        If Not dtversion Is Nothing AndAlso dtversion.Rows.Count > 0 Then
                            VersionServer = dtversion.Rows(0).Item(0)
                        End If

                        ''Verzija IST-a na lokalu
                        Dim VersionLocal As String = ""
                        Dim di As New IO.DirectoryInfo(ISTPath)
                        Dim fi As IO.FileInfo = di.GetFiles("Version*.txt").FirstOrDefault()
                        If fi Is Nothing Then
                            File.Create(ISTPath + "\Version199901010000.txt").Dispose()
                        End If

                        ''Da li postoji SQLTXT na lokalu, dodaj ako ne postoji
                        Dim directorysqltxt As String = ISTPath + "\SQLTXT"
                        If Not Directory.Exists(directorysqltxt) Then
                            Directory.CreateDirectory(directorysqltxt)
                        End If

                        Dim sqltxtfolderi As String = ""
                        For i As Integer = 0 To dt.Rows.Count - 1
                            If Not Directory.Exists(ISTPath + "\SQLTXT\" + dt.Rows(i).Item("SIFIST")) Then
                                Directory.CreateDirectory(ISTPath + "\SQLTXT\" + dt.Rows(i).Item("SIFIST"))
                                sqltxtfolderi = ISTPath + "\SQLTXT\" + dt.Rows(i).Item("SIFIST")
                                Dim txtSQLSIFIST As IO.FileInfo = di.GetFiles("SQLTXTVersion*.txt").FirstOrDefault()
                                If txtSQLSIFIST Is Nothing Then
                                    File.Create(ISTPath + "\SQLTXT\" + dt.Rows(i).Item("SIFIST") + "\SQLTXTVersion199901010000.txt").Dispose()
                                End If
                            End If
                        Next

                        Dim VersionLocalSQLTXT As String = ""

                        If regVersion IsNot Nothing Then
                            regVersion.SetValue("DownloadMode", "", RegistryValueKind.String)
                        End If

                        If Not fi Is Nothing Then
                            VersionLocal = fi.Name.ToString.ToUpper.Replace("VERSION", "").Replace(".TXT", "")
                            If VersionLocal <> VersionServer Then
                                If regVersion IsNot Nothing Then
                                    regVersion.SetValue("DownloadMode", "IST", RegistryValueKind.String)
                                End If

                                msg = getMessageText(dtMessages, "628", Me.jezik)
                                ISTMessageBox.Show(msg)

                                msg = getMessageText(dtMessages, "629", Me.jezik)
                                ISTMessageBox.Show(msg)

                                Dim url As String = "https://istportal.net/downloads.aspx"
                                Process.Start(url)
                                Application.Exit()

                            Else
                                For i As Integer = 0 To dt.Rows.Count - 1
                                    Dim diSQLTXT As New IO.DirectoryInfo(ISTPath + "\SQLTXT\" + dt.Rows(i).Item("SIFIST"))
                                    Dim fisql As IO.FileInfo = diSQLTXT.GetFiles("SQLTXTVERSION*.txt").FirstOrDefault()
                                    VersionLocalSQLTXT = fisql.Name.ToString.ToUpper.Replace("SQLTXTVERSION", "").Replace(".TXT", "")
                                    Dim pomVersionServer() As String = dt.Rows(i).Item("ProgUnos").ToString.Trim.Split(";")
                                    Dim pomSQL As String = ""
                                    For k As Integer = 0 To pomVersionServer.GetUpperBound(0)
                                        If pomVersionServer(k).Trim.ToUpper.IndexOf("SQLTXTVERSION=") = 0 Then
                                            pomSQL = pomVersionServer(k).Replace("SQLTXTVERSION=", "")
                                        End If
                                    Next

                                    If VersionLocalSQLTXT <> pomSQL AndAlso IsNumeric(pomSQL.ToString.Trim) Then
                                        If regVersion IsNot Nothing Then
                                            regVersion.SetValue("DownloadMode", "SQLTXT", RegistryValueKind.String)
                                            msg = getMessageText(dtMessages, "628", Me.jezik)
                                            ISTMessageBox.Show(msg)
                                            msg = getMessageText(dtMessages, "629", Me.jezik)
                                            ISTMessageBox.Show(msg)
                                            Dim url As String = "https://istportal.net/downloads.aspx"
                                            Process.Start(url)

                                            Application.Exit()

                                        End If
                                        Exit For
                                    End If
                                Next
                            End If
                        Else
                            msg = getMessageText(dtMessages, "21", Me.jezik)
                            ISTMessageBox.Show(msg)
                        End If
                        Me.Cursor = Cursors.Default
                        Me.Close()
                    End If
                End If
            Else
                msg = getMessageText(dtMessages, "602", Me.jezik)
                '"Nemate dozvolu ni za jednu aplikaciju."
                Call UpisiULogMonitoring("1", TextBoxUserID.Text.Trim, "", "LogIn - " + msg + "", "ERROR", RacunarKorisnika, IPAdresaKorisnika, "", DEPOConnString)
                ISTMessageBox.Show(msg)
            End If
        Else
            pcbOffLineOnline.Image = My.Resources.nowifi.ToBitmap
            msg = getMessageText(dtMessages, "603", Me.jezik)
            ISTMessageBox.Show(msg)
        End If

        btnLogIn.Enabled = True
        Me.Cursor = Cursors.Default

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
        Me.Close()
    End Sub

    Private Sub LoginFormIST_Load(sender As Object, e As EventArgs) Handles Me.Load


        Dim onInternet As Boolean = False
        onInternet = isConnected()
        If onInternet = True Then
            pcbOffLineOnline.Image = My.Resources.wifi.ToBitmap
        Else
            pcbOffLineOnline.Image = My.Resources.nowifi.ToBitmap
        End If

        btnEye.Image = My.Resources.eyeOrange.ToBitmap
        pomEye = "ORANGE"
        TextBoxPassword.PasswordChar = "*"
        SetLang()

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
        'Dim overlayHandleISTLoading As ISTFormIsLoading
        'overlayHandleISTLoading = New ISTFormIsLoading(Me, Me)
        'overlayHandleISTLoading.Show()



    End Sub



    Dim pomEye As String = ""

    'Private Sub btnEye_Click(sender As Object, e As EventArgs) Handles btnEye.Click
    '    If pomEye = "ORANGE" Then
    '        btnEye.Image = My.Resources.eyeBlue.ToBitmap
    '        pomEye = "BLUE"
    '        TextBoxPassword.PasswordChar = Nothing
    '    Else
    '        btnEye.Image = My.Resources.eyeOrange.ToBitmap
    '        pomEye = "ORANGE"
    '        TextBoxPassword.PasswordChar = "*"
    '    End If
    'End Sub

    Dim WithEvents timer As New System.Windows.Forms.Timer
    Dim milliseconds As Integer


    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles btnEye.MouseDown
        milliseconds = 0
        timer.Start()
        btnEye.Image = My.Resources.eyeBlue.ToBitmap
        pomEye = "BLUE"
        TextBoxPassword.PasswordChar = Nothing
        Me.btnEye.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles btnEye.MouseUp
        timer.Stop()
        'Label1.Text = "Button held down for: " & milliseconds & " milliseconds"
        If milliseconds >= 0 Then 'Mouse has been down for one second

            btnEye.Image = My.Resources.eyeOrange.ToBitmap
            pomEye = "ORANGE"
            TextBoxPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub EggTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        milliseconds += 1
    End Sub

    Private Sub TextBoxUserID_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxUserID.KeyDown, TextBoxPassword.KeyDown, tboxFoPassUser.KeyDown, tboxFoPassName.KeyDown, tboxFoPassEmail.KeyDown

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
                'Case Keys.Tab
                '    e.SuppressKeyPress = False
            Case Else
        End Select
    End Sub
    Private Sub fPreviewKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles TextBoxUserID.PreviewKeyDown, TextBoxPassword.PreviewKeyDown, tboxFoPassUser.PreviewKeyDown, tboxFoPassName.PreviewKeyDown, tboxFoPassEmail.PreviewKeyDown
        'If e.KeyData = Keys.Tab Then
        '    e.IsInputKey = True
        'End If
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

    Private Sub FormLoginZ_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TextBoxUserID.Focus()
    End Sub

    Private Sub ButtonPaint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles btnEye.Paint
        Dim Btn = DirectCast(sender, Button)
        Using P As New Pen(System.Drawing.SystemColors.Menu)
            e.Graphics.DrawRectangle(P, 4, 4, 19, 14)
        End Using
    End Sub

    Private Sub llForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llForgotPass.LinkClicked
        tboxFoPassUser.Text = ""
        tboxFoPassName.Text = ""
        tboxFoPassEmail.Text = ""
        panelForgotPass.BringToFront()
        DisableOsnovniEkran()
        panelForgotPass.Visible = True
        tboxFoPassUser.Focus()
    End Sub

    Private Sub DisableOsnovniEkran()
        panelKontrole.Enabled = False
        panelFooter.Enabled = False
    End Sub

    Private Sub EnableOsnovniEkran()
        panelKontrole.Enabled = True
        panelFooter.Enabled = True
    End Sub


    Private Sub btnFoPassX_Click(sender As Object, e As EventArgs) Handles btnFoPassX.Click
        EnableOsnovniEkran()
        panelForgotPass.SendToBack()
        panelForgotPass.Visible = False
        TextBoxUserID.Focus()
    End Sub

    Private Sub btnFoPass_Click(sender As Object, e As EventArgs) Handles btnFoPass.Click

        If tboxFoPassUser.Text.Trim = "" OrElse tboxFoPassName.Text.Trim = "" OrElse tboxFoPassEmail.Text.Trim = "" OrElse tboxFoPassUser.Text.Trim.Length < 2 _
            OrElse tboxFoPassName.Text.Trim.Length < 2 OrElse tboxFoPassEmail.Text.Trim.IndexOf("@") < 0 Then
            ISTMessageBox.Show(getMessageText(dtMessages, "619", Me.jezik))
            tboxFoPassUser.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim struser As String = "exec CheckISTUserAppForgotPass N'" + tboxFoPassUser.Text.Trim + "',  N'" + tboxFoPassEmail.Text.Trim + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(struser, ISTConnectionString, jezik)
        If dt.Rows.Count > 0 Then

            Dim subject As String = getMessageText(dtMessages, "612", Me.jezik)
            Dim body As String = getMessageText(dtMessages, "626", Me.jezik) + nvrd + nvrd + getMessageText(dtMessages, "623", Me.jezik) + nvrd + nvrd + getMessageText(dtMessages, "624", Me.jezik) + nvrd
            Dim okok As String = izvrsiSQL("exec ISTForgotPassSendEmail N'" + tboxFoPassUser.Text.Trim + "',N'" + tboxFoPassEmail.Text.Trim + "',  N'" + subject + "', N'" + body + "'", ISTConnectionString)
            If okok <> "ok" Then
                ISTMessageBox.Show(getMessageText(dtMessages, "21", Me.jezik))
                Me.Cursor = Cursors.Default
                Exit Sub
            Else
                ISTMessageBox.Show(getMessageText(dtMessages, "620", Me.jezik))
            End If

            Dim pom As Boolean = False
            For i As Integer = 0 To dt.Rows.Count - 1

                If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                    Dim emails As String() = dt.Rows(i).Item("progunos").ToString.ToUpper.Trim.Split("$")
                    Dim emailskome As String = ""
                    Dim subjectadmin As String = getMessageText(dtMessages, "612", Me.jezik)
                    Dim bodyadmin As String = getMessageText(dtMessages, "626", Me.jezik) + nvrd + nvrd + getMessageText(dtMessages, "613", Me.jezik) + " " + tboxFoPassUser.Text.Trim + " (" + tboxFoPassName.Text.Trim + ", " +
                                         tboxFoPassEmail.Text.Trim + ") " + getMessageText(dtMessages, "615", Me.jezik) + nvrd + nvrd +
                                          getMessageText(dtMessages, "617", Me.jezik) + nvrd + nvrd + "ISTPORTAL.net"

                    For j As Integer = 0 To emails.GetUpperBound(0)
                        If emails(j).ToUpper.Trim.IndexOf("EMAILTO=") = 0 Then
                            pom = True
                            emailskome = emails(j).ToUpper.Trim.Replace("EMAILTO=", "").Replace(",", ";")
                            Dim ok As String = izvrsiSQL("exec ISTForgotPassSendEmailAdmin N'" + emailskome + "',  N'" + subjectadmin + "', N'" + bodyadmin + "'", ISTConnectionString)
                            If ok <> "ok" Then
                                ISTMessageBox.Show(getMessageText(dtMessages, "21", Me.jezik))
                                Exit For
                            Else
                                'ISTMessageBox.Show(getMessageText(dtMessages, "620", Me.jezik))
                                Exit For
                            End If
                        End If
                    Next
                End If


            Next
            If pom = False Then
                ISTMessageBox.Show(getMessageText(dtMessages, "622", Me.jezik))
            End If
        Else
            ISTMessageBox.Show(getMessageText(dtMessages, "621", Me.jezik))
            tboxFoPassUser.Focus()
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        TextBoxPassword.Text = ""
        EnableOsnovniEkran()
        panelForgotPass.SendToBack()
        If TextBoxUserID.Text.Trim = "" Then
            TextBoxUserID.Focus()
        Else
            TextBoxPassword.Focus()
        End If

        panelForgotPass.Visible = False
    End Sub

    Dim MoveForm As Boolean
    Dim MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles panelZaglavlje.MouseDown, panelFoPassZaglavlje.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles panelZaglavlje.MouseMove, panelFoPassZaglavlje.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles panelZaglavlje.MouseUp, panelFoPassZaglavlje.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub SetLang()

        Dim dt As DataTable = getDTVBText(dtLang, "FormLoginZ")
        btnLogIn.Text = getControlText2(dt, "btnLogIn", Me.jezik)
        lblUser.Text = getControlText2(dt, "lblUser", Me.jezik)
        lblPass.Text = getControlText2(dt, "lblPass", Me.jezik)
        llForgotPass.Text = getControlText2(dt, "llForgotPass", Me.jezik)

        lblFoPassUser.Text = getControlText2(dt, "lblFoPassUser", Me.jezik)
        lblFoPassName.Text = getControlText2(dt, "lblFoPassName", Me.jezik)
        lblFoPassEmail.Text = getControlText2(dt, "lblFoPassEmail", Me.jezik)
        btnFoPass.Text = getControlText2(dt, "btnFoPass", Me.jezik)

    End Sub

    Private Sub btnLogIn_GotFocus(sender As Object, e As EventArgs) Handles btnLogIn.GotFocus, btnFoPass.GotFocus
        Dim dugme As Button = CType(sender, Button)
        dugme.FlatAppearance.BorderSize = 1
    End Sub

    Private Sub btnLogIn_LostFocus(sender As Object, e As EventArgs) Handles btnLogIn.LostFocus, btnFoPass.LostFocus
        Dim dugme As Button = CType(sender, Button)
        dugme.FlatAppearance.BorderSize = 0
    End Sub
End Class