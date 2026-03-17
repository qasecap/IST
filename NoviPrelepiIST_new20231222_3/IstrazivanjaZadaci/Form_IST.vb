Option Strict Off

Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Form_IST
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

    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents b3 As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelContext As Panel
    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents tvBaza As TreeView
    Friend WithEvents PanelNewEditApp As Panel
    Friend WithEvents cbCopy As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSDB As CheckBox
    Friend WithEvents cbPDB As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbNew As CheckBox
    Friend WithEvents btnISTNew As Button
    Friend WithEvents btnISTUpdate As Button
    Friend WithEvents llCapiServer As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIP As Label
    Friend WithEvents lblCAPIServer As Label
    Friend WithEvents txtCAPIBaza As TextBox
    Friend WithEvents txtIP As TextBox
    Friend WithEvents txtCapiServer As TextBox
    Friend WithEvents dgvLinkTables As DataGridView
    Friend WithEvents cbLinkTables As CheckBox
    Friend WithEvents lblISTTab1Naziv As Label
    Friend WithEvents txtNaziv As TextBox
    Friend WithEvents cboPeriodika As ComboBox
    Friend WithEvents lblISTPeriodika As Label
    Friend WithEvents txtConnString As TextBox
    Friend WithEvents txtBaza As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtCAPI As TextBox
    Friend WithEvents llD As LinkLabel
    Friend WithEvents lblISTTextDir As Label
    Friend WithEvents cbotxtDir As TextBox
    Friend WithEvents llSB As LinkLabel
    Friend WithEvents lblDBAlias As Label
    Friend WithEvents txtDBAlias As TextBox
    Friend WithEvents txtvdo As DateTimePicker2
    Friend WithEvents txtvod As DateTimePicker2
    Friend WithEvents cbLink As CheckBox
    Friend WithEvents cbPTP As CheckBox
    Friend WithEvents lblISTSifra As Label
    Friend WithEvents cboCopyLink As ComboBox
    Friend WithEvents txtappCode As TextBox
    Friend WithEvents panelDBIST As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn3OK As Button
    Friend WithEvents txtVDO1 As TextBox
    Friend WithEvents txtVALIDFROM1 As TextBox
    Friend WithEvents tvBazaPK As TreeView
    Friend WithEvents cbISTCopy As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn2OK As Button
    Friend WithEvents tvBazaPP As TreeView
    Friend WithEvents cbISTNewFields As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn1OK As Button
    Friend WithEvents tvBazaP As TreeView
    Friend WithEvents cbISTNewTable As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtPravaBazaP As TextBox
    Friend WithEvents txtServerP As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents cboApp As ComboBox
    Friend WithEvents cbNewApp As Button
    Friend WithEvents cbEditApp As Button
    Friend WithEvents llDelete As Button
    Friend WithEvents llDBtoIST As Button
    Friend WithEvents llEditIST As Button
    Friend WithEvents llISTLK As Button
    Friend WithEvents llISTPolja As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents btnArrowDownHover As Button
    Friend WithEvents LogovanAnketarCloud As Label
    Friend WithEvents MRefresh As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnLinijaRazmak As Button
    Friend WithEvents btnLinija As Button
    Friend WithEvents ToolTip1 As ToolTip

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_IST))
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PanelNewEditApp = New System.Windows.Forms.Panel()
        Me.cbCopy = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSDB = New System.Windows.Forms.CheckBox()
        Me.cbPDB = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbNew = New System.Windows.Forms.CheckBox()
        Me.btnISTNew = New System.Windows.Forms.Button()
        Me.btnISTUpdate = New System.Windows.Forms.Button()
        Me.llCapiServer = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIP = New System.Windows.Forms.Label()
        Me.lblCAPIServer = New System.Windows.Forms.Label()
        Me.txtCAPIBaza = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.txtCapiServer = New System.Windows.Forms.TextBox()
        Me.dgvLinkTables = New System.Windows.Forms.DataGridView()
        Me.cbLinkTables = New System.Windows.Forms.CheckBox()
        Me.lblISTTab1Naziv = New System.Windows.Forms.Label()
        Me.txtNaziv = New System.Windows.Forms.TextBox()
        Me.cboPeriodika = New System.Windows.Forms.ComboBox()
        Me.lblISTPeriodika = New System.Windows.Forms.Label()
        Me.txtConnString = New System.Windows.Forms.TextBox()
        Me.txtBaza = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtCAPI = New System.Windows.Forms.TextBox()
        Me.llD = New System.Windows.Forms.LinkLabel()
        Me.lblISTTextDir = New System.Windows.Forms.Label()
        Me.cbotxtDir = New System.Windows.Forms.TextBox()
        Me.llSB = New System.Windows.Forms.LinkLabel()
        Me.lblDBAlias = New System.Windows.Forms.Label()
        Me.txtDBAlias = New System.Windows.Forms.TextBox()
        Me.txtvdo = New DateTimePicker2()
        Me.txtvod = New DateTimePicker2()
        Me.cbLink = New System.Windows.Forms.CheckBox()
        Me.cbPTP = New System.Windows.Forms.CheckBox()
        Me.lblISTSifra = New System.Windows.Forms.Label()
        Me.cboCopyLink = New System.Windows.Forms.ComboBox()
        Me.txtappCode = New System.Windows.Forms.TextBox()
        Me.panelDBIST = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn3OK = New System.Windows.Forms.Button()
        Me.txtVDO1 = New System.Windows.Forms.TextBox()
        Me.txtVALIDFROM1 = New System.Windows.Forms.TextBox()
        Me.tvBazaPK = New System.Windows.Forms.TreeView()
        Me.cbISTCopy = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn2OK = New System.Windows.Forms.Button()
        Me.tvBazaPP = New System.Windows.Forms.TreeView()
        Me.cbISTNewFields = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn1OK = New System.Windows.Forms.Button()
        Me.tvBazaP = New System.Windows.Forms.TreeView()
        Me.cbISTNewTable = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtPravaBazaP = New System.Windows.Forms.TextBox()
        Me.txtServerP = New System.Windows.Forms.TextBox()
        Me.cboApp = New System.Windows.Forms.ComboBox()
        Me.llDelete = New System.Windows.Forms.Button()
        Me.llEditIST = New System.Windows.Forms.Button()
        Me.llDBtoIST = New System.Windows.Forms.Button()
        Me.tvBaza = New System.Windows.Forms.TreeView()
        Me.b3 = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.llISTLK = New System.Windows.Forms.Button()
        Me.llISTPolja = New System.Windows.Forms.Button()
        Me.cbEditApp = New System.Windows.Forms.Button()
        Me.cbNewApp = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MRefresh = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnArrowDownHover = New System.Windows.Forms.Button()
        Me.LogovanAnketarCloud = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnLinijaRazmak = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnLinija = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelNewEditApp.SuspendLayout()
        CType(Me.dgvLinkTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDBIST.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContext.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucvt
        '
        Me.ucvt.BackColor = System.Drawing.SystemColors.Control
        Me.ucvt.Enabled = False
        Me.ucvt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvt.Location = New System.Drawing.Point(3, 631)
        Me.ucvt.Name = "ucvt"
        Me.ucvt.Size = New System.Drawing.Size(106, 33)
        Me.ucvt.TabIndex = 6
        Me.ucvt.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanelNewEditApp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.panelDBIST)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboApp)
        Me.SplitContainer1.Panel1.Controls.Add(Me.llDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.llEditIST)
        Me.SplitContainer1.Panel1.Controls.Add(Me.llDBtoIST)
        Me.SplitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.tvBaza)
        Me.SplitContainer1.Size = New System.Drawing.Size(895, 709)
        Me.SplitContainer1.SplitterDistance = 629
        Me.SplitContainer1.TabIndex = 0
        '
        'PanelNewEditApp
        '
        Me.PanelNewEditApp.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelNewEditApp.Controls.Add(Me.cbCopy)
        Me.PanelNewEditApp.Controls.Add(Me.Label2)
        Me.PanelNewEditApp.Controls.Add(Me.cbSDB)
        Me.PanelNewEditApp.Controls.Add(Me.cbPDB)
        Me.PanelNewEditApp.Controls.Add(Me.Label1)
        Me.PanelNewEditApp.Controls.Add(Me.cbNew)
        Me.PanelNewEditApp.Controls.Add(Me.btnISTNew)
        Me.PanelNewEditApp.Controls.Add(Me.btnISTUpdate)
        Me.PanelNewEditApp.Controls.Add(Me.llCapiServer)
        Me.PanelNewEditApp.Controls.Add(Me.Label3)
        Me.PanelNewEditApp.Controls.Add(Me.lblIP)
        Me.PanelNewEditApp.Controls.Add(Me.lblCAPIServer)
        Me.PanelNewEditApp.Controls.Add(Me.txtCAPIBaza)
        Me.PanelNewEditApp.Controls.Add(Me.txtIP)
        Me.PanelNewEditApp.Controls.Add(Me.txtCapiServer)
        Me.PanelNewEditApp.Controls.Add(Me.dgvLinkTables)
        Me.PanelNewEditApp.Controls.Add(Me.cbLinkTables)
        Me.PanelNewEditApp.Controls.Add(Me.lblISTTab1Naziv)
        Me.PanelNewEditApp.Controls.Add(Me.txtNaziv)
        Me.PanelNewEditApp.Controls.Add(Me.cboPeriodika)
        Me.PanelNewEditApp.Controls.Add(Me.lblISTPeriodika)
        Me.PanelNewEditApp.Controls.Add(Me.txtConnString)
        Me.PanelNewEditApp.Controls.Add(Me.txtBaza)
        Me.PanelNewEditApp.Controls.Add(Me.txtServer)
        Me.PanelNewEditApp.Controls.Add(Me.txtCAPI)
        Me.PanelNewEditApp.Controls.Add(Me.llD)
        Me.PanelNewEditApp.Controls.Add(Me.lblISTTextDir)
        Me.PanelNewEditApp.Controls.Add(Me.cbotxtDir)
        Me.PanelNewEditApp.Controls.Add(Me.llSB)
        Me.PanelNewEditApp.Controls.Add(Me.lblDBAlias)
        Me.PanelNewEditApp.Controls.Add(Me.txtDBAlias)
        Me.PanelNewEditApp.Controls.Add(Me.txtvdo)
        Me.PanelNewEditApp.Controls.Add(Me.txtvod)
        Me.PanelNewEditApp.Controls.Add(Me.cbLink)
        Me.PanelNewEditApp.Controls.Add(Me.cbPTP)
        Me.PanelNewEditApp.Controls.Add(Me.lblISTSifra)
        Me.PanelNewEditApp.Controls.Add(Me.cboCopyLink)
        Me.PanelNewEditApp.Controls.Add(Me.txtappCode)
        Me.PanelNewEditApp.Location = New System.Drawing.Point(6, 416)
        Me.PanelNewEditApp.Name = "PanelNewEditApp"
        Me.PanelNewEditApp.Size = New System.Drawing.Size(608, 284)
        Me.PanelNewEditApp.TabIndex = 163
        Me.PanelNewEditApp.Visible = False
        '
        'cbCopy
        '
        Me.cbCopy.AutoSize = True
        Me.cbCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCopy.Location = New System.Drawing.Point(189, 58)
        Me.cbCopy.Name = "cbCopy"
        Me.HP.SetShowHelp(Me.cbCopy, False)
        Me.cbCopy.Size = New System.Drawing.Size(218, 18)
        Me.cbCopy.TabIndex = 203
        Me.cbCopy.Text = "Copy metadata from other app"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 553)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 14)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Parameters for CAPI script generation"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbSDB
        '
        Me.cbSDB.AutoSize = True
        Me.cbSDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSDB.Location = New System.Drawing.Point(189, 390)
        Me.cbSDB.Name = "cbSDB"
        Me.HP.SetShowHelp(Me.cbSDB, False)
        Me.cbSDB.Size = New System.Drawing.Size(135, 18)
        Me.cbSDB.TabIndex = 201
        Me.cbSDB.Text = "Choose database"
        '
        'cbPDB
        '
        Me.cbPDB.AutoSize = True
        Me.cbPDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPDB.Location = New System.Drawing.Point(189, 368)
        Me.cbPDB.Name = "cbPDB"
        Me.HP.SetShowHelp(Me.cbPDB, False)
        Me.cbPDB.Size = New System.Drawing.Size(123, 18)
        Me.cbPDB.TabIndex = 200
        Me.cbPDB.Text = "Public database"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(693, 322)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 14)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Validity period"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbNew
        '
        Me.cbNew.AutoSize = True
        Me.cbNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNew.Location = New System.Drawing.Point(189, 35)
        Me.cbNew.Name = "cbNew"
        Me.HP.SetShowHelp(Me.cbNew, False)
        Me.cbNew.Size = New System.Drawing.Size(116, 18)
        Me.cbNew.TabIndex = 198
        Me.cbNew.Text = "New metadata"
        '
        'btnISTNew
        '
        Me.btnISTNew.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnISTNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnISTNew.Location = New System.Drawing.Point(693, 111)
        Me.btnISTNew.Name = "btnISTNew"
        Me.btnISTNew.Size = New System.Drawing.Size(347, 70)
        Me.btnISTNew.TabIndex = 197
        Me.btnISTNew.Tag = "0"
        Me.btnISTNew.Text = "Form new app (insert into _IST table)"
        Me.btnISTNew.UseVisualStyleBackColor = False
        Me.btnISTNew.Visible = False
        '
        'btnISTUpdate
        '
        Me.btnISTUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnISTUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnISTUpdate.Location = New System.Drawing.Point(693, 31)
        Me.btnISTUpdate.Name = "btnISTUpdate"
        Me.btnISTUpdate.Size = New System.Drawing.Size(347, 70)
        Me.btnISTUpdate.TabIndex = 170
        Me.btnISTUpdate.Tag = "0"
        Me.btnISTUpdate.Text = "Edit app (_IST table updating)"
        Me.btnISTUpdate.UseVisualStyleBackColor = False
        Me.btnISTUpdate.Visible = False
        '
        'llCapiServer
        '
        Me.llCapiServer.AutoSize = True
        Me.llCapiServer.Location = New System.Drawing.Point(189, 576)
        Me.llCapiServer.Name = "llCapiServer"
        Me.llCapiServer.Size = New System.Drawing.Size(231, 14)
        Me.llCapiServer.TabIndex = 196
        Me.llCapiServer.TabStop = True
        Me.llCapiServer.Text = "Select CAPI server and database ..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(22, 653)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 14)
        Me.Label3.TabIndex = 194
        Me.Label3.Text = "DB"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Enabled = False
        Me.lblIP.Location = New System.Drawing.Point(22, 629)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(75, 14)
        Me.lblIP.TabIndex = 193
        Me.lblIP.Text = "IP Address"
        Me.lblIP.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCAPIServer
        '
        Me.lblCAPIServer.AutoSize = True
        Me.lblCAPIServer.Enabled = False
        Me.lblCAPIServer.Location = New System.Drawing.Point(22, 605)
        Me.lblCAPIServer.Name = "lblCAPIServer"
        Me.lblCAPIServer.Size = New System.Drawing.Size(82, 14)
        Me.lblCAPIServer.TabIndex = 192
        Me.lblCAPIServer.Text = "CAPI Server"
        Me.lblCAPIServer.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCAPIBaza
        '
        Me.txtCAPIBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCAPIBaza.Enabled = False
        Me.txtCAPIBaza.Location = New System.Drawing.Point(189, 653)
        Me.txtCAPIBaza.Name = "txtCAPIBaza"
        Me.txtCAPIBaza.Size = New System.Drawing.Size(465, 22)
        Me.txtCAPIBaza.TabIndex = 190
        '
        'txtIP
        '
        Me.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIP.Enabled = False
        Me.txtIP.Location = New System.Drawing.Point(189, 629)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(465, 22)
        Me.txtIP.TabIndex = 189
        '
        'txtCapiServer
        '
        Me.txtCapiServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCapiServer.Enabled = False
        Me.txtCapiServer.Location = New System.Drawing.Point(189, 605)
        Me.txtCapiServer.Name = "txtCapiServer"
        Me.txtCapiServer.Size = New System.Drawing.Size(465, 22)
        Me.txtCapiServer.TabIndex = 188
        '
        'dgvLinkTables
        '
        Me.dgvLinkTables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLinkTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLinkTables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvLinkTables.Location = New System.Drawing.Point(679, 908)
        Me.dgvLinkTables.Name = "dgvLinkTables"
        Me.dgvLinkTables.Size = New System.Drawing.Size(199, 48)
        Me.dgvLinkTables.TabIndex = 187
        Me.dgvLinkTables.Visible = False
        '
        'cbLinkTables
        '
        Me.cbLinkTables.AutoSize = True
        Me.cbLinkTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLinkTables.Location = New System.Drawing.Point(691, 874)
        Me.cbLinkTables.Name = "cbLinkTables"
        Me.HP.SetShowHelp(Me.cbLinkTables, False)
        Me.cbLinkTables.Size = New System.Drawing.Size(91, 18)
        Me.cbLinkTables.TabIndex = 185
        Me.cbLinkTables.Text = "Link tables"
        Me.cbLinkTables.Visible = False
        '
        'lblISTTab1Naziv
        '
        Me.lblISTTab1Naziv.AutoSize = True
        Me.lblISTTab1Naziv.Location = New System.Drawing.Point(22, 135)
        Me.lblISTTab1Naziv.Name = "lblISTTab1Naziv"
        Me.lblISTTab1Naziv.Size = New System.Drawing.Size(33, 14)
        Me.lblISTTab1Naziv.TabIndex = 170
        Me.lblISTTab1Naziv.Text = "Title"
        Me.lblISTTab1Naziv.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNaziv
        '
        Me.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNaziv.Location = New System.Drawing.Point(189, 135)
        Me.txtNaziv.Multiline = True
        Me.txtNaziv.Name = "txtNaziv"
        Me.txtNaziv.Size = New System.Drawing.Size(465, 228)
        Me.txtNaziv.TabIndex = 167
        '
        'cboPeriodika
        '
        Me.cboPeriodika.ItemHeight = 14
        Me.cboPeriodika.Location = New System.Drawing.Point(693, 246)
        Me.cboPeriodika.Name = "cboPeriodika"
        Me.cboPeriodika.Size = New System.Drawing.Size(346, 22)
        Me.cboPeriodika.TabIndex = 168
        '
        'lblISTPeriodika
        '
        Me.lblISTPeriodika.AutoSize = True
        Me.lblISTPeriodika.Location = New System.Drawing.Point(693, 210)
        Me.lblISTPeriodika.Name = "lblISTPeriodika"
        Me.lblISTPeriodika.Size = New System.Drawing.Size(72, 14)
        Me.lblISTPeriodika.TabIndex = 171
        Me.lblISTPeriodika.Text = "Frequency"
        Me.lblISTPeriodika.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtConnString
        '
        Me.txtConnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConnString.Enabled = False
        Me.txtConnString.Location = New System.Drawing.Point(189, 679)
        Me.txtConnString.Multiline = True
        Me.txtConnString.Name = "txtConnString"
        Me.txtConnString.Size = New System.Drawing.Size(465, 96)
        Me.txtConnString.TabIndex = 184
        '
        'txtBaza
        '
        Me.txtBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaza.Enabled = False
        Me.txtBaza.Location = New System.Drawing.Point(189, 497)
        Me.txtBaza.Name = "txtBaza"
        Me.txtBaza.Size = New System.Drawing.Size(465, 22)
        Me.txtBaza.TabIndex = 183
        '
        'txtServer
        '
        Me.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServer.Enabled = False
        Me.txtServer.Location = New System.Drawing.Point(189, 474)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(465, 22)
        Me.txtServer.TabIndex = 182
        '
        'txtCAPI
        '
        Me.txtCAPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCAPI.Enabled = False
        Me.txtCAPI.Location = New System.Drawing.Point(189, 777)
        Me.txtCAPI.Name = "txtCAPI"
        Me.txtCAPI.Size = New System.Drawing.Size(465, 22)
        Me.txtCAPI.TabIndex = 54
        Me.txtCAPI.Visible = False
        '
        'llD
        '
        Me.llD.AutoSize = True
        Me.llD.Location = New System.Drawing.Point(693, 517)
        Me.llD.Name = "llD"
        Me.llD.Size = New System.Drawing.Size(120, 14)
        Me.llD.TabIndex = 178
        Me.llD.TabStop = True
        Me.llD.Text = "Select directory ..."
        '
        'lblISTTextDir
        '
        Me.lblISTTextDir.AutoSize = True
        Me.lblISTTextDir.Location = New System.Drawing.Point(693, 545)
        Me.lblISTTextDir.Name = "lblISTTextDir"
        Me.lblISTTextDir.Size = New System.Drawing.Size(46, 14)
        Me.lblISTTextDir.TabIndex = 176
        Me.lblISTTextDir.Text = "Txt dir"
        Me.lblISTTextDir.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbotxtDir
        '
        Me.cbotxtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbotxtDir.Location = New System.Drawing.Point(691, 571)
        Me.cbotxtDir.Multiline = True
        Me.cbotxtDir.Name = "cbotxtDir"
        Me.cbotxtDir.Size = New System.Drawing.Size(347, 56)
        Me.cbotxtDir.TabIndex = 177
        '
        'llSB
        '
        Me.llSB.AutoSize = True
        Me.llSB.Location = New System.Drawing.Point(189, 417)
        Me.llSB.Name = "llSB"
        Me.llSB.Size = New System.Drawing.Size(197, 14)
        Me.llSB.TabIndex = 179
        Me.llSB.TabStop = True
        Me.llSB.Text = "Select server and database ..."
        '
        'lblDBAlias
        '
        Me.lblDBAlias.AutoSize = True
        Me.lblDBAlias.Location = New System.Drawing.Point(22, 445)
        Me.lblDBAlias.Name = "lblDBAlias"
        Me.lblDBAlias.Size = New System.Drawing.Size(57, 14)
        Me.lblDBAlias.TabIndex = 175
        Me.lblDBAlias.Text = "DB alias"
        Me.lblDBAlias.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtDBAlias
        '
        Me.txtDBAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDBAlias.Location = New System.Drawing.Point(189, 445)
        Me.txtDBAlias.MaxLength = 10
        Me.txtDBAlias.Name = "txtDBAlias"
        Me.txtDBAlias.Size = New System.Drawing.Size(465, 22)
        Me.txtDBAlias.TabIndex = 180
        '
        'txtvdo
        '
        Me.txtvdo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvdo.Location = New System.Drawing.Point(694, 412)
        Me.txtvdo.Name = "txtvdo"
        Me.txtvdo.Size = New System.Drawing.Size(346, 22)
        Me.txtvdo.TabIndex = 174
        '
        'txtvod
        '
        Me.txtvod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtvod.Location = New System.Drawing.Point(694, 375)
        Me.txtvod.Name = "txtvod"
        Me.txtvod.Size = New System.Drawing.Size(346, 22)
        Me.txtvod.TabIndex = 173
        '
        'cbLink
        '
        Me.cbLink.AutoSize = True
        Me.cbLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbLink.Location = New System.Drawing.Point(189, 83)
        Me.cbLink.Name = "cbLink"
        Me.HP.SetShowHelp(Me.cbLink, False)
        Me.cbLink.Size = New System.Drawing.Size(289, 18)
        Me.cbLink.TabIndex = 165
        Me.cbLink.Text = "Use metadata from other app (linked app)"
        '
        'cbPTP
        '
        Me.cbPTP.AutoSize = True
        Me.cbPTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPTP.Location = New System.Drawing.Point(189, 528)
        Me.cbPTP.Name = "cbPTP"
        Me.HP.SetShowHelp(Me.cbPTP, False)
        Me.cbPTP.Size = New System.Drawing.Size(142, 18)
        Me.cbPTP.TabIndex = 181
        Me.cbPTP.Text = "Show tables, fields"
        '
        'lblISTSifra
        '
        Me.lblISTSifra.AutoSize = True
        Me.lblISTSifra.Location = New System.Drawing.Point(22, 7)
        Me.lblISTSifra.Name = "lblISTSifra"
        Me.lblISTSifra.Size = New System.Drawing.Size(65, 14)
        Me.lblISTSifra.TabIndex = 169
        Me.lblISTSifra.Text = "App code"
        '
        'cboCopyLink
        '
        Me.cboCopyLink.ItemHeight = 14
        Me.cboCopyLink.Location = New System.Drawing.Point(189, 106)
        Me.cboCopyLink.Name = "cboCopyLink"
        Me.cboCopyLink.Size = New System.Drawing.Size(462, 22)
        Me.cboCopyLink.TabIndex = 165
        Me.cboCopyLink.Visible = False
        '
        'txtappCode
        '
        Me.txtappCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtappCode.Location = New System.Drawing.Point(189, 7)
        Me.txtappCode.MaxLength = 8
        Me.txtappCode.Name = "txtappCode"
        Me.txtappCode.Size = New System.Drawing.Size(465, 22)
        Me.txtappCode.TabIndex = 166
        '
        'panelDBIST
        '
        Me.panelDBIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.panelDBIST.Controls.Add(Me.TableLayoutPanel1)
        Me.panelDBIST.Controls.Add(Me.TextBox1)
        Me.panelDBIST.Controls.Add(Me.TextBox2)
        Me.panelDBIST.Controls.Add(Me.TextBox3)
        Me.panelDBIST.Controls.Add(Me.TextBox4)
        Me.panelDBIST.Controls.Add(Me.txtPravaBazaP)
        Me.panelDBIST.Controls.Add(Me.txtServerP)
        Me.panelDBIST.Location = New System.Drawing.Point(7, 105)
        Me.panelDBIST.Name = "panelDBIST"
        Me.panelDBIST.Size = New System.Drawing.Size(595, 301)
        Me.panelDBIST.TabIndex = 164
        Me.panelDBIST.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(833, 555)
        Me.TableLayoutPanel1.TabIndex = 94
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn3OK)
        Me.Panel3.Controls.Add(Me.txtVDO1)
        Me.Panel3.Controls.Add(Me.txtVALIDFROM1)
        Me.Panel3.Controls.Add(Me.tvBazaPK)
        Me.Panel3.Controls.Add(Me.cbISTCopy)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 373)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(827, 179)
        Me.Panel3.TabIndex = 2
        '
        'btn3OK
        '
        Me.btn3OK.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn3OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3OK.Location = New System.Drawing.Point(607, 0)
        Me.btn3OK.Name = "btn3OK"
        Me.btn3OK.Size = New System.Drawing.Size(195, 34)
        Me.btn3OK.TabIndex = 168
        Me.btn3OK.Tag = "0"
        Me.btn3OK.Text = "OK"
        Me.btn3OK.UseVisualStyleBackColor = False
        '
        'txtVDO1
        '
        Me.txtVDO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVDO1.Enabled = False
        Me.txtVDO1.Location = New System.Drawing.Point(43, 401)
        Me.txtVDO1.Name = "txtVDO1"
        Me.txtVDO1.Size = New System.Drawing.Size(1591, 22)
        Me.txtVDO1.TabIndex = 87
        Me.txtVDO1.Visible = False
        '
        'txtVALIDFROM1
        '
        Me.txtVALIDFROM1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVALIDFROM1.Enabled = False
        Me.txtVALIDFROM1.Location = New System.Drawing.Point(43, 313)
        Me.txtVALIDFROM1.Name = "txtVALIDFROM1"
        Me.txtVALIDFROM1.Size = New System.Drawing.Size(1591, 22)
        Me.txtVALIDFROM1.TabIndex = 86
        Me.txtVALIDFROM1.Visible = False
        '
        'tvBazaPK
        '
        Me.tvBazaPK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvBazaPK.CheckBoxes = True
        Me.tvBazaPK.LabelEdit = True
        Me.tvBazaPK.Location = New System.Drawing.Point(0, 36)
        Me.tvBazaPK.Name = "tvBazaPK"
        Me.tvBazaPK.Size = New System.Drawing.Size(803, 134)
        Me.tvBazaPK.TabIndex = 85
        '
        'cbISTCopy
        '
        Me.cbISTCopy.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cbISTCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbISTCopy.Location = New System.Drawing.Point(0, 0)
        Me.cbISTCopy.Name = "cbISTCopy"
        Me.cbISTCopy.Size = New System.Drawing.Size(803, 34)
        Me.cbISTCopy.TabIndex = 84
        Me.cbISTCopy.Text = "Copy existing table from IST to IST"
        Me.cbISTCopy.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn2OK)
        Me.Panel2.Controls.Add(Me.tvBazaPP)
        Me.Panel2.Controls.Add(Me.cbISTNewFields)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 188)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 179)
        Me.Panel2.TabIndex = 1
        '
        'btn2OK
        '
        Me.btn2OK.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn2OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2OK.Location = New System.Drawing.Point(607, 0)
        Me.btn2OK.Name = "btn2OK"
        Me.btn2OK.Size = New System.Drawing.Size(195, 34)
        Me.btn2OK.TabIndex = 168
        Me.btn2OK.Tag = "0"
        Me.btn2OK.Text = "OK"
        Me.btn2OK.UseVisualStyleBackColor = False
        '
        'tvBazaPP
        '
        Me.tvBazaPP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvBazaPP.CheckBoxes = True
        Me.tvBazaPP.Location = New System.Drawing.Point(0, 36)
        Me.tvBazaPP.Name = "tvBazaPP"
        Me.tvBazaPP.Size = New System.Drawing.Size(803, 134)
        Me.tvBazaPP.TabIndex = 91
        '
        'cbISTNewFields
        '
        Me.cbISTNewFields.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cbISTNewFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbISTNewFields.Location = New System.Drawing.Point(0, 0)
        Me.cbISTNewFields.Name = "cbISTNewFields"
        Me.cbISTNewFields.Size = New System.Drawing.Size(803, 34)
        Me.cbISTNewFields.TabIndex = 90
        Me.cbISTNewFields.Text = "Insert fields from DB table to ISTTablesColumns table"
        Me.cbISTNewFields.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn1OK)
        Me.Panel1.Controls.Add(Me.tvBazaP)
        Me.Panel1.Controls.Add(Me.cbISTNewTable)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 179)
        Me.Panel1.TabIndex = 0
        '
        'btn1OK
        '
        Me.btn1OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1OK.Location = New System.Drawing.Point(607, 0)
        Me.btn1OK.Name = "btn1OK"
        Me.btn1OK.Size = New System.Drawing.Size(195, 34)
        Me.btn1OK.TabIndex = 168
        Me.btn1OK.Tag = "0"
        Me.btn1OK.Text = "OK"
        Me.btn1OK.UseVisualStyleBackColor = True
        '
        'tvBazaP
        '
        Me.tvBazaP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvBazaP.CheckBoxes = True
        Me.tvBazaP.Location = New System.Drawing.Point(0, 36)
        Me.tvBazaP.Name = "tvBazaP"
        Me.tvBazaP.Size = New System.Drawing.Size(803, 134)
        Me.tvBazaP.TabIndex = 78
        '
        'cbISTNewTable
        '
        Me.cbISTNewTable.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cbISTNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbISTNewTable.Location = New System.Drawing.Point(0, 0)
        Me.cbISTNewTable.Name = "cbISTNewTable"
        Me.cbISTNewTable.Size = New System.Drawing.Size(803, 34)
        Me.cbISTNewTable.TabIndex = 53
        Me.cbISTNewTable.Text = "Insert tables from DB to IST "
        Me.cbISTNewTable.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(2671, 864)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(245, 22)
        Me.TextBox1.TabIndex = 93
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(2671, 790)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(245, 22)
        Me.TextBox2.TabIndex = 92
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(2369, 864)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(245, 22)
        Me.TextBox3.TabIndex = 91
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(2369, 790)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(245, 22)
        Me.TextBox4.TabIndex = 90
        Me.TextBox4.Visible = False
        '
        'txtPravaBazaP
        '
        Me.txtPravaBazaP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPravaBazaP.Enabled = False
        Me.txtPravaBazaP.Location = New System.Drawing.Point(238, 1528)
        Me.txtPravaBazaP.Name = "txtPravaBazaP"
        Me.txtPravaBazaP.Size = New System.Drawing.Size(1591, 22)
        Me.txtPravaBazaP.TabIndex = 81
        Me.txtPravaBazaP.Visible = False
        '
        'txtServerP
        '
        Me.txtServerP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServerP.Enabled = False
        Me.txtServerP.Location = New System.Drawing.Point(238, 1462)
        Me.txtServerP.Name = "txtServerP"
        Me.txtServerP.Size = New System.Drawing.Size(1591, 22)
        Me.txtServerP.TabIndex = 79
        Me.txtServerP.Visible = False
        '
        'cboApp
        '
        Me.cboApp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboApp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboApp.DropDownWidth = 412
        Me.cboApp.FormattingEnabled = True
        Me.cboApp.Location = New System.Drawing.Point(19, 8)
        Me.cboApp.Name = "cboApp"
        Me.cboApp.Size = New System.Drawing.Size(240, 22)
        Me.cboApp.TabIndex = 176
        Me.cboApp.Visible = False
        '
        'llDelete
        '
        Me.llDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.llDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.llDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llDelete.ForeColor = System.Drawing.Color.Black
        Me.llDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llDelete.Location = New System.Drawing.Point(277, 72)
        Me.llDelete.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.llDelete.Name = "llDelete"
        Me.llDelete.Size = New System.Drawing.Size(340, 27)
        Me.llDelete.TabIndex = 192
        Me.llDelete.TabStop = False
        Me.llDelete.Tag = ""
        Me.llDelete.Text = "Delete app from IST"
        Me.llDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.llDelete.UseVisualStyleBackColor = False
        Me.llDelete.Visible = False
        '
        'llEditIST
        '
        Me.llEditIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.llEditIST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llEditIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.llEditIST.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llEditIST.ForeColor = System.Drawing.Color.Black
        Me.llEditIST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llEditIST.Location = New System.Drawing.Point(277, 8)
        Me.llEditIST.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.llEditIST.Name = "llEditIST"
        Me.llEditIST.Size = New System.Drawing.Size(340, 27)
        Me.llEditIST.TabIndex = 190
        Me.llEditIST.TabStop = False
        Me.llEditIST.Tag = ""
        Me.llEditIST.Text = "Edit IST"
        Me.llEditIST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.llEditIST.UseVisualStyleBackColor = False
        Me.llEditIST.Visible = False
        '
        'llDBtoIST
        '
        Me.llDBtoIST.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.llDBtoIST.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llDBtoIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.llDBtoIST.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llDBtoIST.ForeColor = System.Drawing.Color.Black
        Me.llDBtoIST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llDBtoIST.Location = New System.Drawing.Point(277, 40)
        Me.llDBtoIST.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.llDBtoIST.Name = "llDBtoIST"
        Me.llDBtoIST.Size = New System.Drawing.Size(340, 27)
        Me.llDBtoIST.TabIndex = 191
        Me.llDBtoIST.TabStop = False
        Me.llDBtoIST.Tag = "    "
        Me.llDBtoIST.Text = "DB to IST - Add new tables and fields to IST from DB"
        Me.llDBtoIST.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.llDBtoIST.UseVisualStyleBackColor = False
        Me.llDBtoIST.Visible = False
        '
        'tvBaza
        '
        Me.tvBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvBaza.CheckBoxes = True
        Me.tvBaza.ItemHeight = 16
        Me.tvBaza.Location = New System.Drawing.Point(23, 70)
        Me.tvBaza.Name = "tvBaza"
        Me.tvBaza.Size = New System.Drawing.Size(220, 457)
        Me.tvBaza.TabIndex = 78
        Me.tvBaza.Visible = False
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
        Me.b3.Size = New System.Drawing.Size(227, 32)
        Me.b3.TabIndex = 183
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        Me.b3.Visible = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnLinija)
        Me.PanelMenu.Controls.Add(Me.btnBack)
        Me.PanelMenu.Controls.Add(Me.Logovan)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.Button7)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Controls.Add(Me.llISTLK)
        Me.PanelMenu.Controls.Add(Me.llISTPolja)
        Me.PanelMenu.Controls.Add(Me.cbEditApp)
        Me.PanelMenu.Controls.Add(Me.cbNewApp)
        Me.PanelMenu.Controls.Add(Me.LinkLabel2)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(255, 749)
        Me.PanelMenu.TabIndex = 143
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
        Me.Logovan.TabIndex = 10000079
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Button1.TabIndex = 10000080
        Me.Button1.Tag = ""
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.Button2.TabIndex = 10000077
        Me.Button2.Text = "W H E R E  I N T E G R A T I O N  M E E T S  I N F O R M A T I O N"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.btnMenu.TabIndex = 10000075
        Me.btnMenu.TabStop = False
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
        Me.Button7.TabIndex = 10000076
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
        Me.Button3.TabIndex = 10000078
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'llISTLK
        '
        Me.llISTLK.BackColor = System.Drawing.Color.Transparent
        Me.llISTLK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llISTLK.FlatAppearance.BorderSize = 0
        Me.llISTLK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.llISTLK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.llISTLK.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llISTLK.ForeColor = System.Drawing.Color.White
        Me.llISTLK.Image = CType(resources.GetObject("llISTLK.Image"), System.Drawing.Image)
        Me.llISTLK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llISTLK.Location = New System.Drawing.Point(8, 348)
        Me.llISTLK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.llISTLK.Name = "llISTLK"
        Me.llISTLK.Size = New System.Drawing.Size(240, 38)
        Me.llISTLK.TabIndex = 195
        Me.llISTLK.Tag = "      Edit ISTRulesLogicalControl"
        Me.llISTLK.Text = "      Edit ISTRulesLogicalControl"
        Me.llISTLK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llISTLK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.llISTLK.UseVisualStyleBackColor = False
        '
        'llISTPolja
        '
        Me.llISTPolja.BackColor = System.Drawing.Color.Transparent
        Me.llISTPolja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.llISTPolja.FlatAppearance.BorderSize = 0
        Me.llISTPolja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.llISTPolja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.llISTPolja.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llISTPolja.ForeColor = System.Drawing.Color.White
        Me.llISTPolja.Image = CType(resources.GetObject("llISTPolja.Image"), System.Drawing.Image)
        Me.llISTPolja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llISTPolja.Location = New System.Drawing.Point(8, 297)
        Me.llISTPolja.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.llISTPolja.Name = "llISTPolja"
        Me.llISTPolja.Size = New System.Drawing.Size(240, 38)
        Me.llISTPolja.TabIndex = 194
        Me.llISTPolja.Tag = "      Edit ISTTablesColumns"
        Me.llISTPolja.Text = "      Edit ISTTablesColumns"
        Me.llISTPolja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.llISTPolja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.llISTPolja.UseVisualStyleBackColor = False
        '
        'cbEditApp
        '
        Me.cbEditApp.BackColor = System.Drawing.Color.Transparent
        Me.cbEditApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbEditApp.FlatAppearance.BorderSize = 0
        Me.cbEditApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbEditApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEditApp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEditApp.ForeColor = System.Drawing.Color.White
        Me.cbEditApp.Image = CType(resources.GetObject("cbEditApp.Image"), System.Drawing.Image)
        Me.cbEditApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbEditApp.Location = New System.Drawing.Point(10, 195)
        Me.cbEditApp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbEditApp.Name = "cbEditApp"
        Me.cbEditApp.Size = New System.Drawing.Size(240, 38)
        Me.cbEditApp.TabIndex = 189
        Me.cbEditApp.Tag = "      Edit IST"
        Me.cbEditApp.Text = "      Edit IST"
        Me.cbEditApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbEditApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cbEditApp.UseVisualStyleBackColor = False
        '
        'cbNewApp
        '
        Me.cbNewApp.BackColor = System.Drawing.Color.Transparent
        Me.cbNewApp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbNewApp.FlatAppearance.BorderSize = 0
        Me.cbNewApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbNewApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNewApp.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNewApp.ForeColor = System.Drawing.Color.White
        Me.cbNewApp.Image = CType(resources.GetObject("cbNewApp.Image"), System.Drawing.Image)
        Me.cbNewApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbNewApp.Location = New System.Drawing.Point(10, 144)
        Me.cbNewApp.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbNewApp.Name = "cbNewApp"
        Me.cbNewApp.Size = New System.Drawing.Size(240, 38)
        Me.cbNewApp.TabIndex = 188
        Me.cbNewApp.Tag = "      New app"
        Me.cbNewApp.Text = "      New app"
        Me.cbNewApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbNewApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cbNewApp.UseVisualStyleBackColor = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(7, 658)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(70, 13)
        Me.LinkLabel2.TabIndex = 178
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "_xxxxxxxx"
        Me.LinkLabel2.Visible = False
        '
        'PanelContext
        '
        Me.PanelContext.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContext.Controls.Add(Me.SplitContainer1)
        Me.PanelContext.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(255, 40)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(895, 709)
        Me.PanelContext.TabIndex = 145
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
        Me.MRefresh.Location = New System.Drawing.Point(775, 0)
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
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.btnArrowDownHover)
        Me.PanelTop.Controls.Add(Me.Button4)
        Me.PanelTop.Controls.Add(Me.LogovanAnketarCloud)
        Me.PanelTop.Controls.Add(Me.MRefresh)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(255, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(895, 40)
        Me.PanelTop.TabIndex = 141
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
        Me.btnArrowDownHover.Location = New System.Drawing.Point(855, 0)
        Me.btnArrowDownHover.Name = "btnArrowDownHover"
        Me.btnArrowDownHover.Size = New System.Drawing.Size(40, 40)
        Me.btnArrowDownHover.TabIndex = 10000077
        Me.btnArrowDownHover.UseVisualStyleBackColor = False
        '
        'LogovanAnketarCloud
        '
        Me.LogovanAnketarCloud.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogovanAnketarCloud.BackColor = System.Drawing.Color.Transparent
        Me.LogovanAnketarCloud.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogovanAnketarCloud.ForeColor = System.Drawing.Color.DarkOrange
        Me.LogovanAnketarCloud.Location = New System.Drawing.Point(236, 1)
        Me.LogovanAnketarCloud.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LogovanAnketarCloud.Name = "LogovanAnketarCloud"
        Me.LogovanAnketarCloud.Size = New System.Drawing.Size(222, 40)
        Me.LogovanAnketarCloud.TabIndex = 119
        Me.LogovanAnketarCloud.Tag = "always"
        Me.LogovanAnketarCloud.Text = "aleksandar.karadjordjevicCloud"
        Me.LogovanAnketarCloud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LogovanAnketarCloud.Visible = False
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
        Me.btnMinimizar.Location = New System.Drawing.Point(815, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(855, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = False
        Me.btnCerrar.Visible = False
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
        Me.btnBack.Location = New System.Drawing.Point(13, 675)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 33)
        Me.btnBack.TabIndex = 10000086
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
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
        Me.btnLinijaRazmak.Location = New System.Drawing.Point(255, 40)
        Me.btnLinijaRazmak.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLinijaRazmak.Name = "btnLinijaRazmak"
        Me.btnLinijaRazmak.Size = New System.Drawing.Size(2, 709)
        Me.btnLinijaRazmak.TabIndex = 10000077
        Me.btnLinijaRazmak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinijaRazmak.UseVisualStyleBackColor = False
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
        'btnLinija
        '
        Me.btnLinija.BackColor = System.Drawing.Color.Transparent
        Me.btnLinija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLinija.FlatAppearance.BorderSize = 0
        Me.btnLinija.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLinija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLinija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinija.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLinija.ForeColor = System.Drawing.Color.White
        Me.btnLinija.Image = CType(resources.GetObject("btnLinija.Image"), System.Drawing.Image)
        Me.btnLinija.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLinija.Location = New System.Drawing.Point(-1, 262)
        Me.btnLinija.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLinija.Name = "btnLinija"
        Me.btnLinija.Size = New System.Drawing.Size(255, 17)
        Me.btnLinija.TabIndex = 10000088
        Me.btnLinija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLinija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinija.UseVisualStyleBackColor = False
        '
        'Form_IST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 749)
        Me.Controls.Add(Me.btnLinijaRazmak)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelTop)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Form_IST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelNewEditApp.ResumeLayout(False)
        Me.PanelNewEditApp.PerformLayout()
        CType(Me.dgvLinkTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDBIST.ResumeLayout(False)
        Me.panelDBIST.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContext.ResumeLayout(False)
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
    Private DSBrisanjeDEPO As String
    Private DSBrisanjeServer As String
    Private DSBrisanjeBaza As String
    Dim dtIST As New System.Data.DataTable
    Dim dtISTBaze As New System.Data.DataTable
    Dim jezik As String
    Dim txtmode As String
    Dim ISTConnectionString As String = ""
    Dim DBConnectionString As String = ""
    Dim vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim DepoConnectionString As String
    Dim PublicDBServer As String
    Dim PublicDBBaza As String

    Dim panelmenucollapse As Boolean
    Dim CW As Integer
    Public Sub New(ByVal ISTConnectionString As String,
                    ByVal DSBrisanjeDEPO As String, ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String,
                    ByVal PublicDBServer As String, ByVal PublicDBBaza As String,
                    ByVal txtmode As String, ByVal jezik As String, ByVal mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal kosamnew As String)

        Me.New()
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Logovan.Text = kosamnew
        Me.jezik = jezik
        Call SetLang()
        Me.txtmode = txtmode
        Me.ISTConnectionString = ISTConnectionString
        zapamtilogovanog = Logovan.Text.Trim
        CW = Me.Width
        'Dim ww As Integer = Screen.PrimaryScreen.Bounds.Width()
        'Dim hh As Integer = Screen.PrimaryScreen.Bounds.Height()
        '*****
        Call napunidtIST()

        Dim strSQl As String = "select top 1 databaseserver,COUNT(*) from  vBazaServerEng group by databaseserver order by 2 desc"
        Dim dtp As DataTable = izvrsiSQLvratiDT(strSQl, Me.ISTConnectionString, Me.jezik)

        If dtp.Rows.Count = 1 Then
            txtServer.Text = dtp.Rows(0).Item(0).ToString.Trim
        Else
            txtServer.Text = ""
        End If

        strSQl = "select * from _ISTDatabaseConnStrings"
        dtISTBaze = izvrsiSQLvratiDT(strSQl, Me.ISTConnectionString, Me.jezik)

        Me.DSBrisanjeDEPO = DSBrisanjeDEPO
        Me.DSBrisanjeServer = DSBrisanjeServer
        Me.DSBrisanjeBaza = DSBrisanjeBaza

        Me.PublicDBServer = PublicDBServer
        Me.PublicDBBaza = PublicDBBaza

        strSQl = "select distinct periodics as displaymember,periodics as valuemember from _IST order by 1"
        Call popunicbo(cboPeriodika, strSQl, Me.ISTConnectionString)

        strSQl = "select distinct appCode as displaymember,appCode as valuemember from _IST order by 1"
        Call popunicbo(cboCopyLink, strSQl, Me.ISTConnectionString)
        DepoConnectionString = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, DBConnectionString)

        Me.vt = mvt

    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "GUI")

        cbPTP.Text = getControlText2(dt, "prikazISTTab1TP", Me.jezik)
        cbCopy.Text = getControlText2(dt, "cbISTKopija", Me.jezik)
        'cbLink.Text = getControlText2(dt, "cbISTLink", Me.jezik)
        lblISTTextDir.Text = getControlText2(dt, "lblISTTextDir", Me.jezik)
        lblDBAlias.Text = getControlText2(dt, "lblISTAlias", Me.jezik)
        lblISTPeriodika.Text = getControlText2(dt, "lblISTPeriodika", Me.jezik)
        lblISTTab1Naziv.Text = getControlText2(dt, "lblISTTab1Naziv", Me.jezik)
        lblISTSifra.Text = getControlText2(dt, "lblISTSifra", Me.jezik)
        b3.Text = getControlText2(dt, "naslov8", Me.jezik)

    End Sub

    Sub napunidtIST()
        Dim strSQl As String = "select *,month(VALIDFROM) as mmod, year(VALIDFROM) as ggod, month(VALIDTO) as mmdo, year(VALIDTO) as ggdo from _IST"
        dtIST = izvrsiSQLvratiDT(strSQl, Me.ISTConnectionString, Me.jezik)
    End Sub
    'Private Sub prikazCh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    tvBaza.BeginUpdate()
    '    tvBaza.CollapseAll()
    '    AddHandler tvBaza.BeforeExpand, AddressOf CheckForCheckedChildren
    '    tvBaza.ExpandAll()
    '    RemoveHandler tvBaza.BeforeExpand, AddressOf CheckForCheckedChildren
    '    tvBaza.EndUpdate()
    'End Sub

    'Private Sub CheckForCheckedChildren(ByVal sender As Object, ByVal e As TreeViewCancelEventArgs)
    '    If Not HasCheckedChildNodes(e.Node) Then
    '        e.Cancel = True
    '    End If
    'End Sub
    Private Function HasCheckedChildNodes(ByVal node As TreeNode) As Boolean
        If node.Nodes.Count = 0 Then
            Return False
        End If
        Dim childNode As TreeNode
        For Each childNode In node.Nodes
            If childNode.Checked Then
                Return True
            End If
            If HasCheckedChildNodes(childNode) Then
                Return True
            End If
        Next childNode
        Return False
    End Function

    Private Sub CheckAllChildNodes(ByVal treeNode As TreeNode, ByVal nodeChecked As Boolean)
        Dim node As TreeNode
        For Each node In treeNode.Nodes
            node.Checked = nodeChecked
            If node.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next node
    End Sub

    Private Sub tvBaza_AfterCheck(ByVal sender As System.Object, ByVal e As TreeViewEventArgs) Handles tvBaza.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Nodes.Count > 0 Then
                Me.CheckAllChildNodes(e.Node, e.Node.Checked)
            End If
        End If
    End Sub
    Sub DajTabelePoljaIST(ByVal tv As TreeView, ByVal sifist As String)

        Dim izrazODBC As String = ""
        tv.Nodes.Clear()

        Dim sql As String = "select * from _ISTTablesColumns where appCode='" + sifist.Trim + "' order by tableName,orderNumber"
        Dim dISTPolja As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)

        If dISTPolja.Rows.Count > 0 Then
            Dim node As TreeNode
            Dim tab As String = dISTPolja.Rows(0).Item("tableName").ToString.Trim.ToUpper
            Dim slTab As String = ""
            node = tv.Nodes.Add(tab)
            node.Tag = node.Text
            Dim polje As String = dISTPolja.Rows(0).Item("columnName").ToString.Trim
            node.Nodes.Add(polje)
            node.Nodes(node.Nodes.Count - 1).Tag = node.Nodes(node.Nodes.Count - 1).Text
            For i As Integer = 1 To dISTPolja.Rows.Count - 1
                slTab = dISTPolja.Rows(i).Item("tableName").ToString.Trim.ToUpper
                If tab <> slTab Then
                    tab = slTab
                    node = tv.Nodes.Add(slTab)
                    node.Tag = node.Text
                End If
                polje = dISTPolja.Rows(i).Item("columnName").ToString.Trim
                node.Nodes.Add(polje)
                node.Nodes(node.Nodes.Count - 1).Tag = node.Nodes(node.Nodes.Count - 1).Text
            Next
            tv.Visible = True
        End If
    End Sub

    Private Sub txtappCode_Leave(sender As Object, e As EventArgs) Handles txtappCode.Leave


        'proveri da li takvo već postoji
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(2057)

        Dim por As String = ""
        If (Me.cbEditApp.Focused) OrElse (llISTLK.Focused) OrElse (llISTPolja.Focused) OrElse (Me.btnCerrar.Focused) OrElse cbNewApp.Focused Then
            Exit Sub
        ElseIf Not Me.cbCopy.Focused AndAlso (txtappCode.Text.Trim = Nothing OrElse txtappCode.Text.Trim = "") Then
            ''msg 305
            Dim msgtxt305 As String = getMessageText(dtMessages, "305", Me.jezik)
            ISTMessageBox.Show(msgtxt305, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtappCode.Focus()
            Exit Sub
        ElseIf (txtappCode.Text.Trim = Nothing OrElse txtappCode.Text.Trim = "") Then
            Me.Close()
            Exit Sub
        ElseIf (Me.cbCopy.Focused) AndAlso (txtappCode.Text.Trim = Nothing OrElse txtappCode.Text.Trim = "") Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Me.txtvod.Text = "2015-01-01"
        Me.txtvdo.Text = "9989-01-01"

        Dim poruka As String = ""
        por = ISTpostojiGde()
        If por <> "" Then
            ''msg 306
            Dim msgtxt306 As String = getMessageText(dtMessages, "306", Me.jezik)
            ''msg 307
            Dim msgtxt307 As String = getMessageText(dtMessages, "307", Me.jezik)
            ''msg 308
            Dim msgtxt308 As String = getMessageText(dtMessages, "308", Me.jezik)

            poruka = msgtxt306 + nvrd + nvrd
            poruka = poruka + "             " + por + nvrd + nvrd
            poruka = poruka + msgtxt307 + nvrd
            poruka = poruka + msgtxt308 + nvrd
            ISTMessageBox.Show(poruka, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtappCode.Focus()
            Me.txtappCode.SelectAll()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Function ISTpostojiGde() As String

        Dim dIST As New System.Data.DataTable
        Dim por As String = ""
        Dim sql As String = ""
        sql = sql + " select '_IST' as wwhere, count(*) as ccount from _IST where appCode='" & Me.txtappCode.Text.Trim & "'" & " union all " & nvrd
        sql = sql + " select '_ISTTables' as wwhere, count(*) as ccount from _ISTTables where appCode='" & Me.txtappCode.Text.Trim & "'" & " union all " & nvrd
        sql = sql + " select '_ISTTablesColumns' as wwhere, count(*) as ccount from _ISTTablesColumns where appCode='" & Me.txtappCode.Text.Trim & "'" & " union all " & nvrd
        sql = sql + " select '_ISTRulesDataValidation' as wwhere, count(*) as ccount from _ISTRulesDataValidation where appCode='" & Me.txtappCode.Text.Trim & "'" & " union all " & nvrd
        sql = sql + " select '_ISTReportsProcedures' as wwhere, count(*) as ccount from _ISTReportsProcedures where appCode='" & Me.txtappCode.Text.Trim & "'" & nvrd

        dIST = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)

        For j As Integer = 0 To dIST.Rows.Count - 1
            If dIST.Rows(j).Item("ccount").ToString.Trim <> "0" Then
                por = por + dIST.Rows(j).Item("wwhere").ToString.Trim + ";"
            End If
        Next

        ISTpostojiGde = por

    End Function

    Function proveraAliasa() As Integer
        proveraAliasa = 0
        Dim strSQl As String = "select distinct databaseAlias,rdatabase,databaseserver from vBazaServerEng where databaseAlias='" + txtDBAlias.Text.Trim + "'"
        Dim dt2 As DataTable = izvrsiSQLvratiDT(strSQl, Me.ISTConnectionString, Me.jezik)

        If dt2.Rows.Count > 0 AndAlso
            dt2.Rows(0).Item("rdatabase").ToString.Trim.ToUpper <> txtBaza.Text.Trim.ToUpper Then
            ''msg 311
            Dim msgtxt311 As String = getMessageText(dtMessages, "311", Me.jezik)
            ISTMessageBox.Show(msgtxt311, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.txtDBAlias.Text = ""
            Me.txtDBAlias.Focus()
            proveraAliasa = 2
        ElseIf dt2.Rows.Count > 0 AndAlso
           dt2.Rows(0).Item("rdatabase").ToString.Trim.ToUpper = txtBaza.Text.Trim.ToUpper Then
            'postoji za istu bazu, onda ga ne upisujemo
            proveraAliasa = 1
        Else
            'alias ne postoji
            proveraAliasa = 0
        End If
    End Function

    Private Sub txtAliasBaze_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtDBAlias.Text.Trim <> "" Then Call proveraAliasa()
    End Sub

    Private Function GetQuotedName(ByVal label As String) As String
        GetQuotedName = ""
        Dim pos1 As Integer
        Dim pos2 As Integer
        pos1 = label.IndexOf("\") + 1
        pos2 = label.LastIndexOf("\")
        If ((pos2 - pos1) > 0) Then
            GetQuotedName(label.Substring(pos1, pos2 - pos1))
        End If
    End Function

    Private Sub btnISTNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnISTNew.Click
        Me.Cursor = Cursors.WaitCursor
        Dim formNovoOk As Boolean = False

        If cboPeriodika.SelectedValue = "" AndAlso cboPeriodika.Text.Trim = "" Then
            If Me.jezik = "SRC" OrElse Me.jezik = "SRL" OrElse Me.jezik = "MNE" Then
                cboPeriodika.SelectedValue = "MES"
            Else
                cboPeriodika.SelectedValue = "MMM"
            End If
        End If
        If Me.cbCopy.Checked = True Then
            If sveoknovo() = True Then formNovoOk = formirajCopy()
        ElseIf Me.cbLink.Checked = True Then
            If sveoknovo() = True Then formNovoOk = formirajLinked()
        Else
            If sveoknovo() = True Then formNovoOk = formirajNew()
        End If

        If formNovoOk = True Then
            ''msg 312
            'Dim msgtxt312 As String = getMessageText(dtMessages, "312", Me.jezik)
            'ISTMessageBox.Show(msgtxt312, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information

            ISTMessageBox.Show("App is formed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ponistiEkran(tvBaza, Nothing, Nothing)
            Call cbEditAppCheckedTrue()
            cboApp.SelectedText = txtappCode.Text
            cboApp.SelectedValue = txtappCode.Text
        Else
            ''msg 313
            Dim msgtxt313 As String = getMessageText(dtMessages, "313", Me.jezik)
            ISTMessageBox.Show(msgtxt313, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Cursor = Cursors.Default
        Call resetEditAPP()
    End Sub

    Private Sub btnISTUpdate_Click(sender As Object, e As EventArgs) Handles btnISTUpdate.Click
        Me.Cursor = Cursors.WaitCursor
        Dim formEditOk As Boolean = False

        If cboPeriodika.SelectedValue = "" Then cboPeriodika.SelectedValue = "MES"

        If sveoknovo() = True Then formEditOk = formirajNew("U")

        If formEditOk = True Then
            ISTMessageBox.Show("App is updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ponistiEkran(tvBaza, Nothing, Nothing)
            Call cbEditAppCheckedTrue()
            cboApp.SelectedText = txtappCode.Text
            cboApp.SelectedValue = txtappCode.Text
        Else
            ''msg 313
            Dim msgtxt313 As String = getMessageText(dtMessages, "313", Me.jezik)
            ISTMessageBox.Show(msgtxt313, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Cursor = Cursors.Default
        Call resetEditAPP()
    End Sub
    Sub cbEditAppCheckedTrue()

        Call panelsVisibleFalse()

        btnISTNew.Visible = False
        btnISTUpdate.Visible = True
        cboApp.Width = cbEditApp.Width
        cboApp.Visible = True

        Call refreshAppList()

        Call cbNewAppCheckedFalse()

        '*****
        tvBaza.Visible = False
        '*****
    End Sub
    Dim samoIST As Boolean
    Sub cbNewAppCheckedFalse()
        Call panelsVisibleFalse()
        PanelNewEditApp.Visible = False
    End Sub

    Sub cbEditAppCheckedFalse()
        Call panelsVisibleFalse()
        cboApp.Visible = False
        llEditIST.Visible = False
        llDBtoIST.Visible = False
        llDelete.Visible = False
    End Sub
    Function sveoknovo(Optional ByVal obavezanRename As Boolean = False) As Boolean
        samoIST = False
        sveoknovo = False
        Dim sifist As String = Me.txtappCode.Text.Trim
        Dim Naziv As String = Me.txtNaziv.Text.Trim
        Dim Periodika As String = Me.cboPeriodika.Text.Trim
        Dim BAZA As String = Me.txtDBAlias.Text.Trim
        Dim TxtDir As String = Me.cbotxtDir.Text.Trim
        Dim pravaBaza As String = txtBaza.Text
        If sifist.Length = 0 Then
            Me.txtappCode.Focus()
        ElseIf Naziv.Length = 0 Then
            Me.txtNaziv.Focus()
        ElseIf Periodika.Length = 0 Then
            Me.cboPeriodika.Focus()
        ElseIf pravaBaza.Length = 0 Then
            Me.llSB.Focus()
        ElseIf BAZA.Length = 0 Then
            Me.txtDBAlias.Focus()
            'ElseIf TxtDir.Length = 0 Then
            '    Me.cbotxtDir.Focus()
        ElseIf prazanTreeView(tvBaza) = True Then
            samoIST = True
            sveoknovo = True
            ''msg 315
            'Dim msgtxt315 As String = getMessageText(dtMessages, "315", Me.jezik)
            'ISTMessageBox.Show(msgtxt315, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Me.tvBaza.Focus()
        ElseIf obavezanRename = True AndAlso preimenovanOnajKojiJeCekiran(tvBaza) = False Then
            ''msg 316
            Dim msgtxt316 As String = getMessageText(dtMessages, "316", Me.jezik)
            ISTMessageBox.Show(msgtxt316, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.tvBaza.Focus()
        Else
            sveoknovo = True
        End If
    End Function

    Function preimenovanOnajKojiJeCekiran(ByVal tv As TreeView) As Boolean
        Dim nTabela As TreeNode
        Dim nPolje As TreeNode
        preimenovanOnajKojiJeCekiran = True
        For Each nTabela In tv.Nodes
            For Each nPolje In nTabela.Nodes
                If nPolje.Checked Then
                    If nTabela.Text.Trim.ToUpper = nTabela.Tag.Trim.ToUpper Then
                        preimenovanOnajKojiJeCekiran = False
                        Exit For
                    End If
                End If
            Next nPolje
        Next nTabela

    End Function

    Sub ponistiEkran(ByVal tv1 As TreeView,
    ByVal tv2 As TreeView,
    ByVal tv3 As TreeView)
        For Each k As Control In SplitContainer1.Panel1.Controls
            If TypeOf k Is ComboBox Then k.Text = ""
            If TypeOf k Is TextBox AndAlso
            CType(k, TextBox).Name <> "txtServerP" AndAlso
            CType(k, TextBox).Name <> "txtPravaBazaP" AndAlso
             CType(k, TextBox).Name <> "txtVALIDFROM1" AndAlso
              CType(k, TextBox).Name <> "txtVDO1" Then
                k.Text = ""
            End If
            If TypeOf k Is CheckBox Then CType(k, CheckBox).Checked = False
        Next

        If Not tv1 Is Nothing Then tv1.Nodes.Clear()
        If Not tv2 Is Nothing Then tv2.Nodes.Clear()
        If Not tv3 Is Nothing Then tv3.Nodes.Clear()
    End Sub

    Function prazanTreeView(ByVal tv As TreeView) As Boolean
        Dim nTabela As TreeNode
        Dim nPolje As TreeNode
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

    Function formirajNew(Optional ByVal updateIST As String = "") As Boolean

        Dim VALIDFROM As Date = CDate(txtvod.Text)
        Dim VALIDTO As Date = CDate(txtvdo.Text)

        formirajNew = True
        Dim sql As String = ""

        Dim sifist As String = Me.txtappCode.Text.Trim
        Dim Naziv As String = Me.txtNaziv.Text.Trim
        Dim Periodika As String = Me.cboPeriodika.Text.Trim
        Dim pravaBaza As String = txtBaza.Text.Trim
        Dim BAZA As String = Me.txtDBAlias.Text.Trim
        Dim TxtDir As String = Me.cbotxtDir.Text.Trim
        Dim DBConnectionString As String = Me.txtConnString.Text.Trim

        Dim Metodologija As String = Me.txtCAPI.Text.Trim

        Try
            sql = " begin transaction; "

            If updateIST = "U" Then sql = sql & "delete from _IST where appcode='" + sifist + "'"

            sql = sql & " insert into _IST" &
            "(appCode,appInEditMeta,appTitle,periodics,databaseAlias,pathToQuery,VALIDFROM,VALIDTO)" &
            " values(" &
            "'" & sifist & "',4," &
            "N'" & Naziv & "'," &
            "'" & Periodika & "'," &
            "'" & BAZA & "'," &
            "'" & TxtDir & "'," &
            "'" & VALIDFROM.ToString("yyyy-MM-01") & "'," &
            "'" & VALIDTO.ToString("yyyy-MM-dd") & "');" & nvrd

            If proveraAliasa() = 0 Then
                sql = sql & " insert into _ISTDatabaseConnStrings" &
                "(databaseAlias,databaseType,ODBC,VALIDFROM,VALIDTO)" &
                " values(" &
                "'" & BAZA & "','SS','" & DBConnectionString & "'," &
                "'" & VALIDFROM.ToString("yyyy-MM-01") & "'," &
                "'" & VALIDTO.ToString("yyyy-MM-dd") & "'" &
                    ");" & nvrd
            End If

            Dim nTabela As TreeNode
            Dim nPolje As TreeNode
            Dim mozeT As Boolean
            Dim rbr As Integer

            If samoIST = False AndAlso tvBaza.Visible = True Then
                For Each nTabela In tvBaza.Nodes
                    mozeT = False
                    rbr = 0
                    For Each nPolje In nTabela.Nodes
                        If nPolje.Checked Then
                            mozeT = True
                            rbr = rbr + 10
                            Dim np As String() = Microsoft.VisualBasic.Split(nPolje.Tag, ";")
                            Dim kljuc As String = np(1).Trim
                            Dim tip As String = np(2).Trim
                            Dim duzina As String = np(3).Trim
                            sql = sql & " insert into _ISTTablesColumns" &
                                            "(appCode,tableName,columnName,primaryKey,relationalDatabase,relationalTable,relationaColumn,controlSize,validatingEvent," +
                                            "enterEvent,defaultValue,label,orderNumber,columnType,columnLenght,tableLayout,VALIDFROM,VALIDTO,columnAtributes)" &
                                            " values(" &
                                            "'" & sifist & "'," &
                                            "N'" & nTabela.Text & "'," &
                                            "N'" & nPolje.Text & "'," &
                                            "'" & kljuc & "'," &
                                            "Null,Null,Null,Null,Null,Null,Null," &
                                            "N'$LRIGHTA$" & nPolje.Text & "'," &
                                            "" & CStr(rbr).Trim & "," &
                                            "'" & tip & "','" & duzina & "','1'," &
                                            "'" & VALIDFROM.ToString("yyyy-MM-01") & "'," &
                                            "'" & VALIDTO.ToString("yyyy-MM-dd") & "'," &
                                            "Null" &
                                            ");" & nvrd
                        End If
                    Next nPolje

                    If mozeT = True Then
                        sql = sql & " insert into _ISTTables" &
                        "(appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder,tableOrder,parentAtributes,childAtributes,VALIDFROM,VALIDTO)" &
                        " values(" &
                        "'" & sifist & "'," &
                        "N'" & nTabela.Text & "'," &
                        "'G'," &
                        "Null," &
                        "N'" & nTabela.Text & "'," &
                        "Null,Null,Null,Null," &
                        "'" & VALIDFROM.ToString("yyyy-MM-01") & "'," &
                        "'" & VALIDTO.ToString("yyyy-MM-dd") & "'" &
                        ");" & nvrd
                        sql = sql & " insert into _ISTRulesDataValidation" &
                        "(appCode,tableName, errNumber, error, condition, errTitle, errAction, errWeight, VALIDFROM, VALIDTO)" &
                        " values(" &
                        "'" & sifist & "'," &
                        "N'" & nTabela.Text & "'," &
                        "'G001','2=3',Null,'If is needed',Null,'T'," &
                        "'" & VALIDFROM.ToString("yyyy-MM-01") & "'," &
                        "'" & VALIDTO.ToString("yyyy-MM-dd") & "'" &
                        ");" & nvrd

                        DBConnectionString = DBConnectionString + ";Integrated Security=SSPI;Persist Security Info=False"
                        Call dodatnaPoljaZaTabelu(nTabela.Text, DBConnectionString)
                        'za cekiranu tabelu provera postojanja dodatnih polja u tabeli
                        'INDGR, i ostalo
                    Else
                        'mora biti oznaceno bar jedno polje
                    End If
                Next nTabela
            End If

            sql = sql & " commit; "


            Dim ok1 As String = izvrsiSQL(sql, Me.ISTConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER28", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As System.Exception

            formirajNew = False
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function
    Sub dodatnaPoljaZaTabelu(ByVal tabela As String, ByVal connPravaBaza As String)

        Dim sql As String = ""
        Dim sql1 As String = ""
        'INDGR
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='INDGR'"
        Dim dt1 As New System.Data.DataTable
        dt1 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt1.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add INDGR bit null;" + nvrd
        'LK
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='LK'"
        Dim dt2 As New System.Data.DataTable
        dt2 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt2.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add LK bit null;" + nvrd
        'LKweb
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='LKweb'"
        Dim dtw2 As New System.Data.DataTable
        dtw2 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dtw2.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add LKweb bit null;" + nvrd
        'G001
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='G001'"
        Dim dt3 As New System.Data.DataTable
        dt3 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt3.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add G001 bit null;" + nvrd
        'date_LKZ
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='date_LKZ'"
        Dim dt22 As New System.Data.DataTable
        dt22 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt22.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add date_LKZ datetime null;" + nvrd
        'date_LKO
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='date_LKO'"
        Dim dt23 As New System.Data.DataTable
        dt23 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt23.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add date_LKO datetime null;" + nvrd
        'user_LKZ
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='user_LKZ'"
        Dim dt24 As New System.Data.DataTable
        dt24 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt24.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add user_LKZ nvarchar(50) null;" + nvrd
        'user_LKO
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='user_LKO'"
        Dim dt25 As New System.Data.DataTable
        dt25 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt25.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add user_LKO nvarchar(50) null;" + nvrd
        'date_LKZweb
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='date_LKZweb'"
        Dim dtw22 As New System.Data.DataTable
        dtw22 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dtw22.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add date_LKZweb datetime null;" + nvrd
        'date_LKOweb
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='date_LKOweb'"
        Dim dtw23 As New System.Data.DataTable
        dtw23 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dtw23.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add date_LKOweb datetime null;" + nvrd
        'user_LKZweb
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='user_LKZweb'"
        Dim dtw24 As New System.Data.DataTable
        dtw24 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dtw24.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add user_LKZweb nvarchar(50) null;" + nvrd
        'user_LKOweb
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='user_LKOweb'"
        Dim dtw25 As New System.Data.DataTable
        dtw25 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dtw25.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add user_LKOweb nvarchar(50) null;" + nvrd
        'user_INSERT
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='user_INSERT'"
        Dim dt4 As New System.Data.DataTable
        dt4 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt4.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add user_INSERT nvarchar(50) null;" + nvrd
        'date_INSERT
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='date_INSERT'"
        Dim dt5 As New System.Data.DataTable
        dt5 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt5.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add date_INSERT datetime null;" + nvrd
        'sourceof_INSERT
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='sourceof_INSERT'"
        Dim dt6 As New System.Data.DataTable
        dt6 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt6.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add sourceof_INSERT nvarchar(5) null;" + nvrd
        'user_UPDATE
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='user_UPDATE'"
        Dim dt7 As New System.Data.DataTable
        dt7 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt7.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add user_UPDATE nvarchar(50) null;" + nvrd
        'date_UPDATE
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='date_UPDATE'"
        Dim dt8 As New System.Data.DataTable
        dt8 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt8.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add date_UPDATE datetime null;" + nvrd

        'CAPIEXPORTED
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='CAPIEXPORTED'"
        Dim dt9 As New System.Data.DataTable
        dt9 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt9.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add CAPIEXPORTED integer null;" + nvrd
        'CAPIDELETED
        sql = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + tabela + "') and name='CAPIDELETED'"
        Dim dt10 As New System.Data.DataTable
        dt10 = izvrsiSQLvratiDT(sql, connPravaBaza, Me.jezik)
        If dt10.Rows.Count = 0 Then sql1 = sql1 + "ALTER TABLE " + tabela.Trim + " add CAPIDELETED integer null;" + nvrd

        sql1 = "begin transaction;" + nvrd + sql1 + nvrd + "commit;"
        If sql1 <> "" Then

            Dim ok1 As String = izvrsiSQL(sql1, connPravaBaza)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql1 + nvrd + nvrd + "is not executed! ER29", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Function formirajLinked() As Boolean
        Dim VALIDFROM As Date = CDate(txtvod.Text)
        Dim VALIDTO As Date = CDate(txtvdo.Text)

        formirajLinked = True
        Dim sql As String = ""

        Dim sifist As String = Me.txtappCode.Text.Trim
        Dim Naziv As String = Me.txtNaziv.Text.Trim
        Dim Periodika As String = Me.cboPeriodika.Text.Trim
        Dim pravaBaza As String = txtBaza.Text.Trim
        Dim BAZA As String = Me.txtDBAlias.Text.Trim
        Dim TxtDir As String = Me.cbotxtDir.Text.Trim
        Dim IzrazODBC As String = Me.txtConnString.Text.Trim
        Dim Metodologija As String = Me.txtCAPI.Text.Trim
        Dim ABAZA As String = "IST=" + cboCopyLink.SelectedValue.trim + ";"

        If cbLinkTables.Visible = True AndAlso cbLinkTables.Checked = True Then
            Dim strs As String = ""
            For i As Integer = 0 To dgvLinkTables.Rows.Count - 1
                If Not dgvLinkTables.Rows(i).Cells(0).Value Is Nothing AndAlso dgvLinkTables.Rows(i).Cells(0).Value.ToString.Trim <> "" AndAlso
                    Not dgvLinkTables.Rows(i).Cells(1).Value Is Nothing AndAlso dgvLinkTables.Rows(i).Cells(1).Value.ToString.Trim <> "" Then
                    strs = strs + dgvLinkTables.Rows(i).Cells(0).Value.ToString.Trim + "=" + dgvLinkTables.Rows(i).Cells(1).Value.ToString.Trim + ","
                End If
            Next
            If strs <> "" Then strs = strs.TrimEnd(",")
            ABAZA = ABAZA + strs
        End If

        Try
            sql = " begin transaction; "

            sql = sql & " insert into _IST" &
            "(appCode,appTitle,periodics,databaseAlias,additionalParameters,pathToQuery,VALIDFROM,VALIDTO)" &
            " values(" &
            "'" & sifist & "'," &
            "N'" & Naziv & "'," &
            "'" & Periodika & "'," &
            "'" & BAZA & "'," &
            "'" & ABAZA & "'," &
            "'" & TxtDir & "'," &
            "'" & VALIDFROM.ToString("yyyy-MM-01") & "'," &
            "'" & VALIDTO.ToString("yyyy-MM-dd") & "');" & nvrd

            If proveraAliasa() = 0 Then
                sql = sql & " insert into _ISTDatabaseConnStrings" &
                "(databaseAlias,databaseType,ODBC,VALIDFROM,VALIDTO)" &
                " values(" &
                "'" & BAZA & "','SS','" & IzrazODBC & "'," &
                "'" & VALIDFROM.ToString("yyyy-MM-01") & "'," &
                "'" & VALIDTO.ToString("yyyy-MM-dd") & "'" &
                    ");" & nvrd
            End If

            sql = sql & " commit; "

            Dim ok1 As String = izvrsiSQL(sql, Me.ISTConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER30", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            formirajLinked = False
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Function

    Function formirajCopy() As Boolean

        formirajCopy = True
        Dim sql As String = ""

        Dim sifist As String = Me.txtappCode.Text.Trim
        Dim Naziv As String = Me.txtNaziv.Text.Trim
        Dim Periodika As String = Me.cboPeriodika.Text.Trim
        Dim pravaBaza As String = txtBaza.Text.Trim
        Dim BAZA As String = Me.txtDBAlias.Text.Trim
        Dim TxtDir As String = Me.cbotxtDir.Text.Trim
        Dim IzrazODBC As String = Me.txtConnString.Text.Trim
        Dim Metodologija As String = Me.txtCAPI.Text.Trim

        Dim VALIDFROM As Date = CDate(txtvod.Text)
        Dim VALIDTO As Date = CDate(txtvdo.Text)

        Try
            sql = " begin transaction; "
            sql = sql & " insert into _IST(appCode,appTitle,periodics,appInEditMeta,databaseAlias,pathToQuery,ValidFrom,ValidTo,IdDeveloper,IdStatistician) " &
            "select '" & sifist & "',N'" & Naziv & "','" & Periodika & "',appInEditMeta,databaseAlias,pathToQuery,ValidFrom,ValidTo,IdDeveloper,IdStatistician " &
            "from _IST where appCode='" & cboCopyLink.Text & "';" & nvrd

            Dim nTabela As TreeNode
            Dim nPolje As TreeNode
            Dim tabela As String = ""
            Dim polje As String = ""

            Dim mozeT As Boolean
            Dim niztabela As String = "$"

            For Each nTabela In tvBaza.Nodes
                Dim nizpolja As String = "$"
                mozeT = False
                For Each nPolje In nTabela.Nodes
                    If nPolje.Checked Then
                        mozeT = True
                        tabela = nTabela.Text
                        polje = nPolje.Text
                        If nizpolja.IndexOf("$" + polje + "$") < 0 Then
                            nizpolja = nizpolja + polje + "$"
                            sql = sql & " insert into _ISTTablesColumns (appCode,tableName,columnName,primaryKey,relationalDatabase,relationalTable,relationaColumn,controlSize,validatingEvent," +
                            "enterEvent,defaultValue,label,orderNumber,columnType,columnLenght,tableLayout,ValidFrom,ValidTo,columnAtributes) " &
                            "select '" & sifist & "','" & tabela & "','" & polje & "',primaryKey,relationalDatabase,relationalTable,relationaColumn,controlSize,validatingEvent, " &
                            "enterEvent,defaultValue,label,orderNumber,columnType,columnLenght,tableLayout,ValidFrom,ValidTo,columnAtributes " &
                            "from _ISTTablesColumns where appCode='" & cboCopyLink.Text & "' and tableName ='" & nTabela.Tag & "' and columnName='" & nPolje.Tag & "';" & nvrd

                            sql = sql & " insert into _ISTAwls(appCode, tableName, columnName, ValidFrom, IDLang, IDAwl, ttext, ValidTo, onF1) " &
                            "select '" + sifist + "',tableName, columnName, ValidFrom, IDLang, IDAwl, ttext, ValidTo, onF1 " &
                            "from _ISTAwls where appCode='" & cboCopyLink.Text & "' and tableName ='" & nTabela.Tag & "' and columnName='" & nPolje.Tag & "';" & nvrd

                            sql = sql & " insert into _ISTQuestionExplanation(appCode, tableName, columnName, ValidFrom, IDLang, IDQuestionExplanation, ttext, ValidTo, briefDescription, questionaryText) " &
                            "select '" + sifist + "',tableName, columnName, ValidFrom, IDLang, IDQuestionExplanation, ttext, ValidTo, briefDescription, questionaryText " &
                            "from _ISTQuestionExplanation where appCode='" & cboCopyLink.Text & "' and tableName ='" & nTabela.Tag & "' and columnName='" & nPolje.Tag & "';" & nvrd

                            sql = sql & " insert into _ISTLabels(appCode,tableName,columnName,ValidFrom,IDLang,IDLabel,lType,ttext,ValidTo) " &
                             "select '" + sifist + "',tableName,columnName,ValidFrom,IDLang,IDLabel,lType,ttext,ValidTo " &
                             "from _ISTLabels where appCode='" & cboCopyLink.Text & "' and tableName ='" & nTabela.Tag & "' and columnName='" & nPolje.Tag & "';" & nvrd
                        End If
                    End If
                Next nPolje

                If mozeT = True Then
                    tabela = nTabela.Text
                    If niztabela.IndexOf("$" + tabela + "$") < 0 Then
                        niztabela = nizpolja + tabela + "$"
                        sql = sql & " insert into _ISTTables(appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder,tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo) " &
                                          "select '" & sifist & "','" & tabela & "',typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder,tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo " &
                                          "from _ISTTables where appCode='" & cboCopyLink.Text & "' and tableName ='" & nTabela.Tag & "';" & nvrd
                        '''''''''''''''''''''''''''''''''''''''''''''''''
                        Dim sqlpom As String = " select * from _ISTRulesDataValidation where appCode='" & cboCopyLink.Text & "' and tableName ='" & nTabela.Tag & "'"
                        Dim dISTLK As DataTable = izvrsiSQLvratiDT(sqlpom, Me.ISTConnectionString, Me.jezik)

                        If dISTLK.Rows.Count > 0 Then
                            sql = sql & " insert into _ISTRulesDataValidation(appCode,tableName,errNumber,error,errWeight,errTitle,condition,errAction,ValidFrom,ValidTo) " &
                                         "select '" & sifist & "','" & tabela & "',errNumber,error,errWeight,errTitle,condition,errAction,ValidFrom,ValidTo " &
                                         "from _ISTRulesDataValidation where appCode='" & cboCopyLink.Text & "' and tableName ='" & nTabela.Text & "';" & nvrd
                        Else
                            sql = sql & " insert into _ISTRulesDataValidation(appCode,tableName,errNumber,Error,errWeight,errTitle,condition,errAction,ValidFrom,ValidTo)" &
                                          "values('" & sifist & "',N'" & nTabela.Text & "','G001','2=3','T','If is needed...',Null,Null,'" & VALIDFROM.ToString("yyyy-MM-dd") & "','" & VALIDTO.ToString("yyyy-MM-dd") & "');" & nvrd
                        End If
                    End If
                Else
                    'mora biti oznaceno bar jedno polje
                End If
            Next nTabela

            sql = sql & " insert into _ISTReportsProcedures(appCode,SeqNumber,Title,query,pivotGraphs,messageBeforeQuery,macroExcel,ExcelHeader,docFormat,ValidFrom,ValidTo) " &
                 "select '" + sifist + "',SeqNumber,Title,query,pivotGraphs,messageBeforeQuery,macroExcel,ExcelHeader,docFormat,ValidFrom,ValidTo " &
                 "from _ISTReportsProcedures where appCode='" & cboCopyLink.Text & "';" & nvrd

            sql = sql & " insert into _ISTMessages(appCode,ValidFrom,IDLang,IDMsg,ttext,ValidTo) " &
                             "select '" + sifist + "',ValidFrom,IDLang,IDMsg,ttext,ValidTo " &
                             "from _ISTMessages where appCode='" & cboCopyLink.Text & "';" & nvrd

            sql = sql & " commit; "

            Dim ok1 As String = izvrsiSQL(sql, Me.ISTConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER32", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            formirajCopy = False
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Function

    Function maxrbr(ByVal sifist As String, ByVal tabela As String) As Integer
        maxrbr = 0
        Dim sql As String = "select tableName,max(orderNumber) As mrbr from _ISTTablesColumns where appCode='" + sifist + "' and tableName='" + tabela + "' group by tableName"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)
        If dt.Rows.Count > 0 Then maxrbr = CInt(dt.Rows(0).Item("mrbr").ToString.Trim)
    End Function

    Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer
    Private Const VK_CONTROL = &H11

    Private Sub cbNewApp_Click(sender As Object, e As EventArgs) Handles cbNewApp.Click
        Call panelsVisibleFalse()


        btnISTNew.Visible = True
        btnISTUpdate.Visible = False
        btnISTNew.Top = btnISTUpdate.Top

        Me.txtappCode.Enabled = True

        Call cbEditAppCheckedFalse()
        '*****
        Me.txtvdo.Text = "2099/12/31"
        cbNew.Checked = True
        '*****

        'Call Podesi_PanelNewEditApp()
        PanelNewEditApp.Visible = True
        Me.txtappCode.Focus()

    End Sub
    Sub panelsVisibleFalse()
        Me.panelDBIST.Visible = False
        Me.PanelNewEditApp.Visible = False
        btnISTNew.Visible = False
        btnISTUpdate.Visible = False
        Call panelDBISTReset()
        Call rreset(PanelNewEditApp)
        cboApp.Visible = False
        llEditIST.Visible = False
        llDBtoIST.Visible = False
        llDelete.Visible = False

    End Sub
    Sub panelDBISTReset()
        Me.cbISTNewTable.Checked = False
        Me.cbISTNewFields.Checked = False
        Me.cbISTCopy.Checked = False
    End Sub


    Sub rreset(ByVal panel As Panel)
        For Each k As Control In panel.Controls
            If TypeOf k Is ComboBox Then k.Text = ""
            If TypeOf k Is TextBox Then k.Text = ""
            If TypeOf k Is CheckBox Then CType(k, CheckBox).Checked = False
            If TypeOf k Is DataGridView Then CType(k, DataGridView).Rows.Clear()
        Next
    End Sub

    Private Sub cbEditApp_Click(sender As Object, e As EventArgs) Handles cbEditApp.Click

        Call panelsVisibleFalse()

        btnISTNew.Visible = False
        btnISTUpdate.Visible = True
        cboApp.Width = cbEditApp.Width
        cboApp.Visible = True
        Call refreshAppList()
        '*****
        tvBaza.Visible = False
        '*****
    End Sub


    Private Sub llEditIST_Click(sender As Object, e As EventArgs) Handles llEditIST.Click
        Call panelsVisibleFalse()
        llEditIST.Visible = True
        llDBtoIST.Visible = True
        llDelete.Visible = True
        cboApp.Visible = True
        btnISTNew.Visible = False
        btnISTUpdate.Visible = True
        btnISTUpdate.Top = btnISTNew.Top
        Call dajIST(Me.cboApp.SelectedValue)
        'Call Podesi_PanelNewEditApp()
        PanelNewEditApp.Visible = True
    End Sub


    Private Sub llD_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llD.LinkClicked
        Dim folderBrowserDialog1 As New FolderBrowserDialog()
        folderBrowserDialog1.ShowNewFolderButton = True
        If (folderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            cbotxtDir.Text = folderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub llSB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSB.LinkClicked
        Call llDB()
    End Sub

    Sub llDB()
        Dim pomn As String = OleDbConnString.EditConnectionString(Me, "")
        Me.txtConnString.Text = pomn.Replace("Provider=SQLOLEDB.1;", "")
        Call getServerBazaNew(pomn)
    End Sub

    Sub getServerBazaNew(ByVal pomn As String)
        Dim pp() As String = pomn.Split(";")
        Dim sql As String = "select databaseAlias from vBazaServerEng where rdatabase='" + Me.txtBaza.Text + "' and  sserver='" + Me.txtServer.Text + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
        If dt.Rows.Count > 0 Then
            txtDBAlias.Text = dt.Rows(0).Item("databaseAlias").ToString.Trim
        Else
            txtDBAlias.Text = ""
        End If

        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).IndexOf("Initial Catalog=") = 0 Then
                Me.txtBaza.Text = pp(i).Replace("Initial Catalog=", "")
                Me.txtBaza.Visible = True
            End If
            If pp(i).IndexOf("Data Source=") = 0 Then
                Me.txtServer.Text = pp(i).Replace("Data Source=", "")
                Me.txtServer.Visible = True
            End If
        Next
        If txtBaza.Text <> "" Then cbPTP.Visible = True
        If Me.txtDBAlias.Text.Trim = "" Then txtDBAlias.Text = txtBaza.Text
    End Sub

    Private Sub cbPTP_CheckedChanged(sender As Object, e As EventArgs) Handles cbPTP.CheckedChanged
        Call PTP()
    End Sub

    Sub PTP()
        If Me.txtBaza.Text <> "" Then
            Me.tvBaza.Visible = cbPTP.Checked
            If tvBaza.Visible = True Then
                Call DajTabelePolja2(tvBaza, Me.txtServer.Text, Me.txtBaza.Text)
            End If
        End If
    End Sub

    Sub DajTabelePolja2(ByVal tv As TreeView, ByVal server As String, ByVal baza As String)
        tv.Nodes.Clear()
        'Dim DBConnectionString As String = Me.txtConnString.Text.Replace("Provider=SQLOLEDB.1;", "")

        Dim DBConnectionString As String = getConnectionString(server, baza, txtmode, Me.DBConnectionString)

        Dim strTP As String = " use " + baza +
                    " SELECT ST.NAME AS tableName, SC.NAME AS columnName," +
                    " CASE WHEN SC.colid= SKC.column_id THEN 'P' ELSE '' END AS primaryKey," +
                    " STY.NAME AS columnType, SC.prec  AS columnLenght" +
                    " FROM (select NAME,OBJECT_ID from SYS.TABLES union all select NAME + '_view' ,OBJECT_ID from SYS.VIEWS) AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
                    " left JOIN SYS.TYPES AS STY ON SC.xusertype  = STY.USER_TYPE_ID" +
                    " left JOIN SYS.INDEX_COLUMNS AS SKC" +
                    " ON SKC.OBJECT_ID = ST.OBJECT_ID AND SKC.column_id =SC.colid order by 1"

        Dim dtTP As New DataTable
        dtTP = izvrsiSQLvratiDT(strTP, DBConnectionString, Me.jezik)
        'ako su tabele u ISTu, uzeti samo one cija sva polja nisu u ISTu

        If dtTP.Rows.Count > 0 Then
            Dim node As TreeNode
            Dim tab As String = dtTP.Rows(0).Item("tableName").ToString.Trim
            Dim slTab As String = ""
            node = tv.Nodes.Add(tab)
            node.Tag = node.Text
            Dim polje As String = dtTP.Rows(0).Item("columnName").ToString.Trim
            node.Nodes.Add(polje)
            node.Nodes(node.Nodes.Count - 1).Tag =
            dtTP.Rows(0).Item("columnName").ToString.Trim &
            ";" & NZ(dtTP.Rows(0).Item("primaryKey")).ToString.Trim &
            ";" & NZ(dtTP.Rows(0).Item("columnType")).ToString.Trim &
            ";" & NZ(dtTP.Rows(0).Item("columnLenght")).ToString.Trim
            For i As Integer = 1 To dtTP.Rows.Count - 1
                slTab = dtTP.Rows(i).Item("tableName").ToString.Trim
                If tab <> slTab Then
                    tab = slTab
                    node = tv.Nodes.Add(slTab)
                    node.Tag = node.Text
                End If
                polje = dtTP.Rows(i).Item("columnName").ToString.Trim
                node.Nodes.Add(polje)
                node.Nodes(node.Nodes.Count - 1).Tag =
               dtTP.Rows(i).Item("columnName").ToString.Trim &
                ";" & dtTP.Rows(i).Item("primaryKey").ToString.Trim &
                ";" & dtTP.Rows(i).Item("columnType").ToString.Trim &
                ";" & dtTP.Rows(i).Item("columnLenght").ToString.Trim
            Next
            tv.Visible = True
        End If
    End Sub

    Sub DajTabelePolja(ByVal tv As TreeView, ByVal server As String, ByVal baza As String,
                   ByVal uIstuTabele As Boolean, Optional ByVal uIstuPolja As Boolean = False)

        tv.Nodes.Clear()

        Dim DBConnectionString As String = getConnectionString(server, baza, txtmode, Me.DBConnectionString)
        Dim strSQl As String = " use " + baza +
                    " SELECT ST.NAME AS tableName, SC.NAME AS columnName," +
                    " CASE WHEN SC.colid= SKC.column_id THEN 'P' ELSE '' END AS primaryKey," +
                    " STY.NAME AS columnType, SC.prec  AS columnLenght" +
                    " FROM (select NAME,OBJECT_ID from SYS.TABLES union all select NAME + '_view' ,OBJECT_ID from SYS.VIEWS) AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
                    " left JOIN SYS.TYPES AS STY ON SC.xusertype  = STY.USER_TYPE_ID" +
                    " left JOIN SYS.INDEX_COLUMNS AS SKC" +
                    " ON SKC.OBJECT_ID = ST.OBJECT_ID AND SKC.column_id =SC.colid "

        Dim pomTabeleIST As String = ""
        Dim colation As String = " COLLATE Latin1_General_CS_AS "
        If cboApp.Visible = True AndAlso cboApp.SelectedValue.ToString <> "" Then pomTabeleIST = "(select * from ist.dbo._ISTTablesColumns where appCode=N'" + cboApp.SelectedValue.ToString + "'"
        If uIstuTabele = False AndAlso pomTabeleIST.Trim <> "" Then strSQl = strSQl + " where not exists " + pomTabeleIST + " and upper(tableName)" + colation + "=upper(ST.NAME)" + colation + ")"
        If uIstuTabele = True AndAlso pomTabeleIST.Trim <> "" Then strSQl = strSQl + " where exists " + pomTabeleIST + " and upper(tableName)" + colation + "=upper(ST.NAME)" + colation + ")"
        If uIstuTabele = True AndAlso uIstuPolja = False AndAlso pomTabeleIST.Trim <> "" Then
            strSQl = strSQl + " and not exists (select * from ist.dbo._ISTTablesColumns where appCode=N'" + cboApp.SelectedValue.ToString + "' and upper(tableName)" + colation + "=upper(ST.NAME)" + colation + "and upper(columnName)" + colation + "=upper(SC.NAME)" + colation + ")"
        End If

        strSQl = strSQl + " order by 1"
        Dim ds As New System.Data.DataSet
        ds = izvrsiSQLvratiDS(strSQl, DBConnectionString, Nothing)

        ''ako su tabele u ISTu, uzeti samo one cija sva polja nisu u ISTu
        If ds.Tables(0).Rows.Count > 0 Then
            Dim node As TreeNode
            Dim tab As String = ds.Tables(0).Rows(0).Item("tableName").ToString.Trim
            Dim slTab As String = ""
            node = tv.Nodes.Add(tab)
            node.Tag = node.Text
            Dim polje As String = ds.Tables(0).Rows(0).Item("columnName").ToString.Trim
            node.Nodes.Add(polje)
            node.Nodes(node.Nodes.Count - 1).Tag =
            ds.Tables(0).Rows(0).Item("columnName").ToString.Trim &
            ";" & NZ(ds.Tables(0).Rows(0).Item("primaryKey")).ToString.Trim &
            ";" & NZ(ds.Tables(0).Rows(0).Item("columnType")).ToString.Trim &
            ";" & NZ(ds.Tables(0).Rows(0).Item("columnLenght")).ToString.Trim
            For i As Integer = 1 To ds.Tables(0).Rows.Count - 1
                slTab = ds.Tables(0).Rows(i).Item("tableName").ToString.Trim
                If tab <> slTab Then
                    tab = slTab
                    node = tv.Nodes.Add(slTab)
                    node.Tag = node.Text
                End If
                polje = ds.Tables(0).Rows(i).Item("columnName").ToString.Trim
                node.Nodes.Add(polje)
                node.Nodes(node.Nodes.Count - 1).Tag =
                ds.Tables(0).Rows(i).Item("columnName").ToString.Trim &
                ";" & ds.Tables(0).Rows(i).Item("primaryKey").ToString.Trim &
                ";" & ds.Tables(0).Rows(i).Item("columnType").ToString.Trim &
                ";" & ds.Tables(0).Rows(i).Item("columnLenght").ToString.Trim
            Next
            tv.Visible = True
        End If
    End Sub

    Sub DajTabelePoljaNisuIstiServeri(ByVal tv As TreeView, ByVal server As String, ByVal baza As String,
                       ByVal uIstuTabele As Boolean, Optional ByVal uIstuPolja As Boolean = False)
        'ISTMessageBox.Show("cbpp_SelectionChangeCommitted", MsgBoxStyle.Information)
        ''POPUNJAVAM  lbSelectTabele
        'Dim server As String = Me.txtServer.Text.Trim
        'Dim baza As String = Me.cboPravaBaza.Text.Trim

        tv.Nodes.Clear()

        Dim DBConnectionString As String = getConnectionString(server, baza, txtmode, "")
        Dim strSQl As String = " use " + baza +
                    " SELECT ST.NAME AS tableName, SC.NAME AS columnName," +
                    " CASE WHEN SC.colid= SKC.column_id THEN 'P' ELSE '' END AS primaryKey," +
                    " STY.NAME AS columnType, SC.prec  AS columnLenght" +
                    " FROM SYS.TABLES AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
                    " left JOIN SYS.TYPES AS STY ON SC.xusertype  = STY.USER_TYPE_ID" +
                    " left JOIN SYS.INDEX_COLUMNS AS SKC" +
                    " ON SKC.OBJECT_ID = ST.OBJECT_ID AND SKC.column_id =SC.colid "

        Dim pomTabeleIST As String = ""
        'IST baza i baza sa podacima ne moraju da budu na istom serveru
        'zato ide odvojeno

        Dim str As String = "select tableName from _ISTTablesColumns where appCode='" + Me.cboApp.SelectedValue.ToString + "'"
        Dim dtp As DataTable = izvrsiSQLvratiDT(str, Me.ISTConnectionString, Me.jezik)

        If Me.cboApp.Visible = True AndAlso Me.cboApp.SelectedValue.ToString <> "" Then
            For i As Integer = 0 To dtp.Rows.Count - 1
                pomTabeleIST = pomTabeleIST + "'" + dtp.Rows(i).Item("tableName").ToString.Trim + "',"
            Next
            pomTabeleIST = pomTabeleIST + "$"
            pomTabeleIST = pomTabeleIST.Replace(",$", "")
            pomTabeleIST = "(" + pomTabeleIST + ")"
            pomTabeleIST = pomTabeleIST.ToUpper
        End If

        If uIstuTabele = False AndAlso pomTabeleIST.Trim <> "" AndAlso pomTabeleIST <> "($)" Then strSQl = strSQl + " where upper(ST.NAME) not in " + pomTabeleIST + ""
        If uIstuTabele = True AndAlso pomTabeleIST.Trim <> "" AndAlso pomTabeleIST <> "($)" Then strSQl = strSQl + " where upper(ST.NAME) in " + pomTabeleIST + ""
        strSQl = strSQl + " order by 1"

        Dim ds As New System.Data.DataSet
        ds = izvrsiSQLvratiDS(strSQl, DBConnectionString, Nothing)

        If uIstuTabele = True AndAlso uIstuPolja = False AndAlso pomTabeleIST.Trim <> "" Then
            str = "select tableName,columnName from _ISTTablesColumns where appCode='" + Me.cboApp.SelectedValue.ToString + "'"
            Dim dist As DataTable = izvrsiSQLvratiDT(str, Me.ISTConnectionString, Me.jezik)
            Dim dbaza As DataSet = izvrsiSQLvratiDS(strSQl, Me.ISTConnectionString, Me.jezik)
            For b As Integer = 0 To dbaza.Tables(0).Rows.Count - 1
                Dim bT As String = dbaza.Tables(0).Rows(b).Item("tableName").ToString.Trim.ToUpper
                Dim bP As String = dbaza.Tables(0).Rows(b).Item("columnName").ToString.Trim.ToUpper
                Dim postoji As Boolean = False
                For i As Integer = 0 To dist.Rows.Count - 1
                    Dim iT As String = dist.Rows(i).Item("tableName").ToString.Trim.ToUpper
                    Dim iP As String = dist.Rows(i).Item("columnName").ToString.Trim.ToUpper
                    If bT = iT AndAlso bP = iP Then
                        postoji = True
                        Exit For
                    End If
                Next
                If postoji = True Then
                    dbaza.Tables(0).Rows(b).Delete()
                End If
            Next
            dbaza.Tables(0).AcceptChanges()
            ds.Clear()
            ds = dbaza.Copy
            'strSQl = strSQl + " and SC.NAME not in (select polje from _ISTTablesColumns where sifist='" + Me.cboKopijaOd1.Text + "' and TABELA=ST.NAME )"
        End If

        ''ako su tabele u ISTu, uzeti samo one cija sva polja nisu u ISTu
        If ds.Tables(0).Rows.Count > 0 Then
            Dim node As TreeNode
            Dim tab As String = ds.Tables(0).Rows(0).Item("tableName").ToString.Trim
            Dim slTab As String = ""
            node = tv.Nodes.Add(tab)
            node.Tag = node.Text
            Dim polje As String = ds.Tables(0).Rows(0).Item("columnName").ToString.Trim
            node.Nodes.Add(polje)
            node.Nodes(node.Nodes.Count - 1).Tag =
            ds.Tables(0).Rows(0).Item("columnName").ToString.Trim &
            ";" & NZ(ds.Tables(0).Rows(0).Item("primaryKey")).ToString.Trim &
            ";" & NZ(ds.Tables(0).Rows(0).Item("columnType")).ToString.Trim &
            ";" & NZ(ds.Tables(0).Rows(0).Item("columnLenght")).ToString.Trim
            For i As Integer = 1 To ds.Tables(0).Rows.Count - 1
                slTab = ds.Tables(0).Rows(i).Item("tableName").ToString.Trim
                If tab <> slTab Then
                    tab = slTab
                    node = tv.Nodes.Add(slTab)
                    node.Tag = node.Text
                End If
                polje = ds.Tables(0).Rows(i).Item("columnName").ToString.Trim
                node.Nodes.Add(polje)
                node.Nodes(node.Nodes.Count - 1).Tag =
                ds.Tables(0).Rows(i).Item("columnName").ToString.Trim &
                ";" & ds.Tables(0).Rows(i).Item("primaryKey").ToString.Trim &
                ";" & ds.Tables(0).Rows(i).Item("columnType").ToString.Trim &
                ";" & ds.Tables(0).Rows(i).Item("columnLenght").ToString.Trim
            Next
            tv.Visible = True
        End If
    End Sub
    Private Sub chbISTTAB2PostojecaTabela_CheckedChanged(sender As Object, e As EventArgs) Handles cbISTCopy.CheckedChanged
        tvBazaPK.Visible = cbISTCopy.Checked
        If Me.cbISTCopy.Checked = True AndAlso Me.cboApp.SelectedValue.ToString.Trim <> "" Then
            Me.Cursor = Cursors.WaitCursor
            Call DajTabelePoljaIST(tvBazaPK, Me.cboApp.SelectedValue.ToString)
            Me.Cursor = Cursors.Default
        Else
            tvBazaPK.Nodes.Clear()
        End If
    End Sub

    Function sveokPostojece(ByVal tv As TreeView, Optional ByVal obavezanRename As Boolean = False) As Boolean
        sveokPostojece = False
        Dim KopijaOd1 As String = Me.cboApp.SelectedValue.ToString
        If KopijaOd1.Length = 0 Then
            Me.cboApp.Focus()
        ElseIf prazanTreeView(tv) = True Then
            ''msg 315
            Dim msgtxt315 As String = getMessageText(dtMessages, "315", Me.jezik)
            ISTMessageBox.Show(msgtxt315, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

            tv.Focus()
        ElseIf obavezanRename = True AndAlso preimenovanOnajKojiJeCekiran(tv) = False Then
            ''msg 316
            Dim msgtxt316 As String = getMessageText(dtMessages, "316", Me.jezik)
            ISTMessageBox.Show(msgtxt316, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

            tv.Focus()
        Else
            sveokPostojece = True
        End If
    End Function

    Function formirajPostojeceNovo() As Boolean

        formirajPostojeceNovo = True

        Dim sql As String = ""

        Dim t As System.Data.SqlClient.SqlTransaction = Nothing
        Dim nTabela As TreeNode
        Dim nPolje As TreeNode

        Dim KopijaOd1 As String = Me.cboApp.SelectedValue.ToString.Trim
        Dim sifist As String = KopijaOd1

        sql = ""
        If cbISTNewTable.Checked = True Then
            'dodajem novu tabelu i polja u ISTTabele, ISTPolja
            Dim mozeT As Boolean
            Dim rbr As Integer
            For Each nTabela In tvBazaP.Nodes
                Dim tabela As String = nTabela.Text
                If tabela.Length > 4 AndAlso tabela.ToLower.Substring(tabela.Length - 5) = "_view" Then tabela = tabela.Replace("_view", "")
                mozeT = False
                rbr = 0
                For Each nPolje In nTabela.Nodes
                    If nPolje.Checked Then
                        mozeT = True
                        rbr = rbr + 10
                        Dim np As String() = Microsoft.VisualBasic.Split(nPolje.Tag, ";")
                        Dim kljuc As String = np(1).Trim
                        Dim tip As String = np(2).Trim
                        Dim duzina As String = np(3).Trim
                        sql = sql & " insert into _ISTTablesColumns" &
                                        "(appCode,tableName,columnName,primaryKey,relationalDatabase,relationalTable,relationaColumn,controlSize,validatingEvent,enterEvent,defaultValue,label,orderNumber," +
                                        "columnType,columnLenght,tableLayout,ValidFrom,ValidTo,columnAtributes)" &
                                        " values(" &
                                        "'" & sifist & "',N'" & tabela & "',N'" & nPolje.Text & "','" & kljuc & "'," &
                                        "Null,Null,Null,Null,Null,Null,Null,N'$LRIGHTA$" & nPolje.Text & "'," &
                                        "" & CStr(rbr).Trim & ",'" & tip & "','" & duzina & "','1'," &
                                        "'" & CDate(txtVALIDFROM1.Text.Trim).ToString("yyyy-MM-01") & "'," &
                                        "'" & CDate(txtVDO1.Text.Trim).ToString("yyyy-MM-28") & "',Null);" & nvrd
                    End If
                Next nPolje

                If mozeT = True Then
                    sql = sql & " insert into _ISTTables" &
                    "(appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder,tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo)" &
                    " values(" &
                    "'" & sifist & "',N'" & tabela & "','G',Null,N'LCENTERA$" & tabela & "',Null,Null,Null,Null," &
                    "'" & CDate(txtVALIDFROM1.Text.Trim).ToString("yyyy-MM-01") & "'," &
                    "'" & CDate(txtVDO1.Text.Trim).ToString("yyyy-MM-28") & "');" & nvrd

                    sql = sql & " insert into _ISTRulesDataValidation(appCode,tableName, errNumber,error,condition,errTitle,errAction,errWeight,ValidFrom,ValidTo)" &
                    " values(" &
                    "'" & sifist & "',N'" & tabela & "','G001','2=3',Null,'If is needed',Null,'T'," &
                    "'" & CDate(txtVALIDFROM1.Text.Trim).ToString("yyyy-MM-01") & "'," &
                    "'" & CDate(txtVDO1.Text.Trim).ToString("yyyy-MM-28") & "');" & nvrd

                    'Dim ISTConnStr As String = getConnectionString(Me.txtServerP.Text, Me.txtPravaBazaP.Text, txtmode, Me.ISTConnectionString, "short")
                    Dim DBConnectionString As String = getConnectionString(Me.txtServerP.Text, Me.txtPravaBazaP.Text, txtmode, "")

                    If nTabela.Text.Length > 4 AndAlso nTabela.Text.ToLower.Substring(nTabela.Text.Length - 5) <> "_view" Then
                        Call dodatnaPoljaZaTabelu(nTabela.Text, DBConnectionString)
                    End If
                Else
                    'mora biti oznaceno bar jedno polje
                End If
            Next nTabela
        End If

        If cbISTNewFields.Checked = True Then
            'max rbr iz postojece
            'dodajem novo polje u ISTPolja
            Dim rbr As Integer
            For Each nTabela In tvBazaPP.Nodes
                Dim tabela As String = nTabela.Text
                If tabela.Length > 4 AndAlso tabela.ToLower.Substring(tabela.Length - 5) = "_view" Then tabela = tabela.Replace("_view", "")
                rbr = maxrbr(sifist, nTabela.Text)
                For Each nPolje In nTabela.Nodes
                    If nPolje.Checked Then
                        rbr = rbr + 10
                        Dim np As String() = Microsoft.VisualBasic.Split(nPolje.Tag, ";")
                        Dim kljuc As String = np(1).Trim
                        Dim tip As String = np(2).Trim
                        Dim duzina As String = np(3).Trim
                        sql = sql & " insert into _ISTTablesColumns" &
                                        "(appCode,tableName,columnName,primaryKey,relationalDatabase,relationalTable,relationaColumn,controlSize,validatingEvent,enterEvent,defaultValue,label,orderNumber," +
                                        "columnType,columnLenght,tableLayout,ValidFrom,ValidTo,columnAtributes)" &
                                        " values(" &
                                        "'" & sifist & "',N'" & tabela & "',N'" & nPolje.Text & "'," &
                                        "'" & kljuc & "',Null,Null,Null,Null,Null,Null,Null,N'$LRIGHTA$" & nPolje.Text & "'," &
                                        "" & CStr(rbr).Trim & ",'" & tip & "','" & duzina & "','1'," &
                                        "'" & CDate(txtVALIDFROM1.Text.Trim).ToString("yyyy-MM-01") & "'," &
                                        "'" & CDate(txtVDO1.Text.Trim).ToString("yyyy-MM-28") & "',Null);" & nvrd
                    End If
                Next nPolje
            Next nTabela
        End If

        'kod kopiranja idu originalne vrtacke
        Dim niztabela As String = "$"
        If cbISTCopy.Checked = True Then
            Dim tabela As String = ""
            Dim polje As String = ""
            Dim mozeT As Boolean
            For Each nTabela In tvBazaPK.Nodes
                Dim nizpolja As String = "$"
                mozeT = False
                For Each nPolje In nTabela.Nodes
                    tabela = nTabela.Text
                    If tabela.Length > 4 AndAlso tabela.ToLower.Substring(tabela.Length - 5) = "_view" Then tabela = tabela.Replace("_view", "")
                    polje = nPolje.Text
                    If nPolje.Checked Then
                        mozeT = True
                        If nizpolja.IndexOf("$" + polje + "$") < 0 Then
                            nizpolja = nizpolja + polje + "$"
                            sql = sql & " insert into _ISTTablesColumns (appCode,tableName,columnName,primaryKey,relationalDatabase,relationalTable,relationaColumn,controlSize,validatingEvent,enterEvent," &
                                "defaultValue,label,orderNumber,columnType,columnLenght,tableLayout,ValidFrom, ValidTo, columnAtributes )" &
                            "select '" & sifist & "','" & tabela & "','" & polje & "',primaryKey,relationalDatabase,relationalTable,relationaColumn,controlSize,validatingEvent,enterEvent," &
                            "defaultValue,label,orderNumber,columnType,columnLenght,tableLayout,CONVERT(VARCHAR(10), ValidFrom, 111), CONVERT(VARCHAR(10), ValidTo, 111),columnAtributes " &
                            "from _ISTTablesColumns where appCode='" & sifist & "' and tableName ='" & nTabela.Tag & "' and columnName='" & nPolje.Tag & "';" & nvrd
                        End If
                    End If
                Next nPolje
                If mozeT = True Then
                    tabela = nTabela.Text
                    If tabela.Length > 4 AndAlso tabela.ToLower.Substring(tabela.Length - 5) = "_view" Then tabela = tabela.Replace("_view", "")
                    If niztabela.IndexOf("$" + tabela + "$") < 0 Then
                        niztabela = niztabela + tabela + "$"
                        sql = sql & " insert into _ISTTables (appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder,tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo) " &
                                    "select '" & sifist & "','" & tabela & "',typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder,tableOrder,parentAtributes,childAtributes,CONVERT(VARCHAR(10), ValidFrom, 111), CONVERT(VARCHAR(10), ValidTo, 111) " &
                                    "from _ISTTables where appCode='" & sifist & "' and tableName ='" & nTabela.Tag & "';" & nvrd

                        sql = sql & " insert into _ISTRulesDataValidation (appCode,tableName,errNumber,error,errWeight,errTitle,condition,errAction,ValidFrom,ValidTo)" &
                        "select '" & sifist & "','" & tabela & "', errNumber,error,errWeight,errTitle,condition,errAction, CONVERT(VARCHAR(10), ValidFrom, 111), CONVERT(VARCHAR(10), ValidTo, 111) " &
                        "from _ISTRulesDataValidation where appCode='" & sifist & "' and tableName ='" & nTabela.Tag & "';" & nvrd
                    End If
                Else
                    'mora biti oznaceno bar jedno polje
                End If
            Next nTabela

        End If
        Try
            sql = " begin transaction; " & nvrd & sql & " commit; "
            Dim ok1 As String = izvrsiSQL(sql, Me.ISTConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER33", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As System.Exception
            formirajPostojeceNovo = False
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub btn1OK_Click(sender As Object, e As EventArgs) Handles btn1OK.Click
        Me.Cursor = Cursors.WaitCursor
        Dim formPostojeceOk As Boolean = False

        '3. u postojeći dodaj novu tabelu iz baze
        'ISTtabele,ISTpolja
        If cbISTNewTable.Checked = True Then
            If sveokPostojece(tvBazaP) = False Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        If txtVALIDFROM1.Text.Trim.Length > 19 Then
            txtVALIDFROM1.Text = txtVALIDFROM1.Text.Substring(0, 19)
        End If
        If txtVDO1.Text.Trim.Length > 19 Then
            txtVDO1.Text = txtVDO1.Text.Substring(0, 19)
        End If


        formPostojeceOk = formirajPostojeceNovo()

        If formPostojeceOk = True Then
            ''msg 314
            ISTMessageBox.Show("Adding to an existing app completed!", "Infprmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ponistiEkran(tvBazaP, tvBazaPP, tvBazaPK)
        Else
            ''msg 313
            ISTMessageBox.Show("App is NOT formed!", "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Cursor = Cursors.Default
        Call resetEditAPP()
    End Sub

    Private Sub btn2OK_Click(sender As Object, e As EventArgs) Handles btn2OK.Click
        Me.Cursor = Cursors.WaitCursor
        Dim formPostojeceOk As Boolean = False

        '4. u postojeći dodaj nova polja za vec postojecu tabelu
        'ISTtabele,ISTpolja
        If cbISTNewFields.Checked = True Then
            If sveokPostojece(tvBazaPP) = False Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        formPostojeceOk = formirajPostojeceNovo()

        If formPostojeceOk = True Then
            ''msg 314
            ISTMessageBox.Show("Adding to an existing app completed!", "Infprmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ponistiEkran(tvBazaP, tvBazaPP, tvBazaPK)
        Else
            ''msg 313
            ISTMessageBox.Show("App is NOT formed!", "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Cursor = Cursors.Default
        Call resetEditAPP()
    End Sub

    Private Sub btn3OK_Click(sender As Object, e As EventArgs) Handles btn3OK.Click
        Me.Cursor = Cursors.WaitCursor
        Dim formPostojeceOk As Boolean = False

        '5. u postojeći dodaj novu tabelu - kopija postojeće
        'ISTtabele,ISTpolja
        If cbISTCopy.Checked = True Then
            If sveokPostojece(tvBazaPK, True) = False Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        formPostojeceOk = formirajPostojeceNovo()

        If formPostojeceOk = True Then
            ''msg 314
            ISTMessageBox.Show("Adding to an existing app completed!", "Infprmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ponistiEkran(tvBazaP, tvBazaPP, tvBazaPK)
        Else
            ''msg 313
            ISTMessageBox.Show("App is NOT formed!", "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Me.Cursor = Cursors.Default
        Call resetEditAPP()
    End Sub
    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, Optional ByVal izvestaj As String = "", Optional ByVal upit As String = "")

        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
                & "(SifIst,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
                & " values( " _
                & "N'_IST',(select top 1 year(GETDATE())),(select top 1 month(GETDATE()))," _
                & "'" & proces & "','" + izvestaj & "','" + upit & "'," _
                & "N'" & GetUserName.ToString.Trim & "'," _
                & "" & "(select top 1 GETDATE())" & ");" + nvrd
        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)

        Dim ok1 As String = izvrsiSQL(strSQL, konDepo)
        If ok1 <> "ok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER35", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Function jelGaima(ByVal imef As String) As Boolean
        Dim sqlP As String = " select * from _IST where appCode='" + imef.Trim + "' "
        Dim dtP As DataTable = izvrsiSQLvratiDT(sqlP, Me.ISTConnectionString, Me.jezik)
        jelGaima = False
        If dtP.Rows.Count > 0 Then jelGaima = True
    End Function

    Private Sub cboCopyLink_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCopyLink.SelectedIndexChanged

        If cboCopyLink.Text <> "" Then
            Dim sqlP As String = " select *,month(VALIDFROM) as mmod, year(VALIDFROM) as ggod, month(VALIDTO) as mmdo, year(VALIDTO) as ggdo from _IST where appCode='" + cboCopyLink.Text.Trim + "' "
            Dim dtP As DataTable = izvrsiSQLvratiDT(sqlP, Me.ISTConnectionString, Me.jezik)

            Dim sql As String = " select distinct databaseAlias,rdatabase,databaseserver,connectionDoc,ODBC from vBazaServerEng where appCode='" + cboCopyLink.Text.Trim + "' "
            Dim dtISTBaze As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)

            Dim i As Integer = 0

            Dim fn As String = cboCopyLink.Text.Trim
            Dim iapp As String = Me.txtappCode.Text.Trim

            If iapp = "" Then
                If jelGaima(fn) = True Then
                    Do
                        i = i + 1
                    Loop While jelGaima(fn + "_" + i.ToString())
                    fn = fn + "_" + i.ToString()
                End If
                Me.txtappCode.Text = fn
            Else

                If jelGaima(iapp) = True Then
                    Do
                        i = i + 1
                    Loop While jelGaima(iapp + "_" + i.ToString())
                    iapp = iapp + "_" + i.ToString()
                    Me.txtappCode.Text = iapp
                Else
                    'nista ostaje
                End If
            End If

            If dtP.Rows.Count <> 1 Then
                ''msg 310
                Dim msgtxt310 As String = getMessageText(dtMessages, "310", Me.jezik)
                ISTMessageBox.Show(msgtxt310, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                If Not dtP.Rows(0).Item("appTitle") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("appTitle") <> "" Then Me.txtNaziv.Text = dtP.Rows(0).Item("appTitle").ToString.Trim
                If Not dtP.Rows(0).Item("capiservername") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("capiservername") <> "" Then Me.txtCAPI.Text = dtP.Rows(0).Item("capiservername").ToString.Trim
                'If Not dtP.Rows(0).Item("Upitnik") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("Upitnik") <> "" Then Me.txtUpitnik.Text = dtP.Rows(0).Item("Upitnik").ToString.Trim
                If Not dtP.Rows(0).Item("periodics") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("periodics") <> "" Then Me.cboPeriodika.Text = dtP.Rows(0).Item("periodics").ToString.Trim
                If Not dtP.Rows(0).Item("pathToQuery") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("pathToQuery") <> "" Then Me.cbotxtDir.Text = dtP.Rows(0).Item("pathToQuery").ToString.Trim
                If Not dtP.Rows(0).Item("VALIDFROM") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("VALIDFROM").ToString.Trim <> "" Then Me.txtvod.Text = CDate(dtP.Rows(0).Item("VALIDFROM")).ToString("yyyy-MM-dd")
                If Not dtP.Rows(0).Item("VALIDTO") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("VALIDTO").ToString.Trim <> "" Then Me.txtvdo.Text = CDate(dtP.Rows(0).Item("VALIDTO")).ToString("yyyy-MM-dd")
                If Not dtP.Rows(0).Item("databaseAlias") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("databaseAlias") <> "" Then Me.txtDBAlias.Text = dtP.Rows(0).Item("databaseAlias").ToString.Trim
                If Not dtISTBaze.Rows(0).Item("databaseserver") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("databaseserver") <> "" Then txtServer.Text = dtISTBaze.Rows(0).Item("databaseserver").ToString.Trim
                If Not dtISTBaze.Rows(0).Item("rdatabase") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("rdatabase") <> "" Then txtBaza.Text = dtISTBaze.Rows(0).Item("rdatabase").ToString.Trim
                If Not dtISTBaze.Rows(0).Item("ODBC") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("ODBC") <> "" Then Me.txtConnString.Text = dtISTBaze.Rows(0).Item("ODBC").ToString.Trim

                Dim ggod As Integer = CInt(dtP.Rows(0).Item("ggod").ToString.Trim)
                Dim mmod As Integer = CInt(dtP.Rows(0).Item("mmod").ToString.Trim)
                Dim dod As Date = New Date(ggod, mmod, 2)
                Dim ggdo As Integer = CInt(dtP.Rows(0).Item("ggdo").ToString.Trim)
                Dim mmdo As Integer = CInt(dtP.Rows(0).Item("mmdo").ToString.Trim)
                Dim ddo As Date = New Date(ggdo, mmdo, 2)

                Me.txtvod.Text = dod
                Me.txtvdo.Text = ddo

                If Me.cbLink.Checked = False Then
                    'popuni tvBaza sa podacima iz ISTa
                    Call DajTabelePoljaIST(tvBaza, Me.cboCopyLink.Text)
                    Dim pomn As String = Me.txtConnString.Text
                    pomn = pomn.Replace("Provider=SQLOLEDB.1;", "")
                    Call getServerBazaNew(pomn)
                Else
                    Me.txtDBAlias.Text = ""
                End If
            End If

        End If
    End Sub

    Private Sub cbLinkTables_CheckedChanged(sender As Object, e As EventArgs) Handles cbLinkTables.CheckedChanged
        If Me.txtServer.Text = "" Then
            ISTMessageBox.Show("Choose server and database...")
            Call llDB()
            cbLinkTables.Checked = False
        Else
            dgvLinkTables.Visible = cbLinkTables.Checked
            dgvLinkTables.Location = New Point(cbLinkTables.Location.X, dgvLinkTables.Location.Y)
        End If

        Call addDGVLinkTables()
    End Sub

    Function DajDBTabele(ByVal server As String, ByVal baza As String) As String
        DajDBTabele = ""
        Dim izrazODBC As String = Me.txtConnString.Text.Replace("Provider=SQLOLEDB.1;", "")
        izrazODBC = izrazODBC + ";Integrated Security=SSPI;Persist Security Info=False"
        Dim strTP As String = " use " + txtBaza.Text +
                                " select name from sys.objects " +
                                " where Type In( 'U','V')" +
                                " and is_ms_shipped = 0 And name<>'sysdiagrams'" +
                                " order by type, Name"
        Dim dtTP As DataTable = izvrsiSQLvratiDT(strTP, izrazODBC, Me.jezik)
        For i As Integer = 0 To dtTP.Rows.Count - 1
            DajDBTabele = DajDBTabele + dtTP.Rows(i).Item("name").ToString.Trim + ";"
        Next
        DajDBTabele = DajDBTabele.TrimEnd(";")
    End Function

    Function DajISTTabele(ByVal appCode As String) As String
        DajISTTabele = ""
        Dim sql As String = "select tablename from _ISTTables where appCode='" + appCode + "' and typeOfTableParentChild<>'S' order by tableName"
        Dim dISTPolja As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)
        For i As Integer = 0 To dISTPolja.Rows.Count - 1
            DajISTTabele = DajISTTabele + dISTPolja.Rows(i).Item("tablename").ToString.Trim + ";"
        Next
        DajISTTabele = DajISTTabele.TrimEnd(";")
    End Function

    Private Sub llCapiServer_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llCapiServer.LinkClicked
        Call llDBCAPI()
        Me.txtCAPI.Visible = True
    End Sub

    Sub llDBCAPI()
        Dim pomn As String = OleDbConnString.EditConnectionString(Me, "")
        'Me.txtIzrazODBC.Text = pomn.Replace("Provider=SQLOLEDB.1;", "")
        Call getCAPIServerBazaNew(pomn)
    End Sub

    Sub getCAPIServerBazaNew(ByVal pomn As String)
        'CAPITOOL$10.13.18.75$DATA SOURCE=CAPITOOL;INITIAL CATALOG=ARSCAPI;
        Dim pp() As String = pomn.Split(";")
        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).IndexOf("Initial Catalog=") = 0 Then
                Me.txtCAPIBaza.Text = pp(i).Replace("Initial Catalog=", "")
                Me.txtCAPIBaza.Visible = True
            End If
            If pp(i).IndexOf("Data Source=") = 0 Then
                Me.txtCapiServer.Text = pp(i).Replace("Data Source=", "")
                Me.txtCapiServer.Visible = True
            End If
        Next
        Dim myIPs As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(txtServer.Text.Trim.ToUpper)
        For Each myIP As System.Net.IPAddress In myIPs.AddressList
            txtIP.Text = myIP.ToString()
        Next
        Me.txtCAPI.Text = txtCapiServer.Text + "$" + txtIP.Text + "$" + "DATA SOURCE=" + txtCapiServer.Text + ";INITIAL CATALOG=" + txtCAPIBaza.Text + ";"
    End Sub
    Sub dajIST(ByVal appCode As String)
        If cboApp.Text <> "" Then
            Dim sqlP As String = " select *,month(VALIDFROM) as mmod, year(VALIDFROM) as ggod, month(VALIDTO) as mmdo, year(VALIDTO) as ggdo from _IST where appCode='" + appCode + "' "
            Dim dtP As DataTable = izvrsiSQLvratiDT(sqlP, Me.ISTConnectionString, Me.jezik)

            Dim sql As String = " select distinct databaseAlias,rdatabase,databaseserver,connectionDoc,ODBC from vBazaServerEng where appCode='" + appCode + "' "
            Dim dtISTBaze As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)

            If dtP.Rows.Count <> 1 Then
                ''msg 310
                Dim msgtxt310 As String = getMessageText(dtMessages, "310", Me.jezik)
                ISTMessageBox.Show(msgtxt310, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            Else
                Dim llink As String = ""
                Me.txtappCode.Text = dtP.Rows(0).Item("appcode").ToString.Trim
                Me.txtappCode.Enabled = False
                If Not dtP.Rows(0).Item("appTitle") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("appTitle") <> "" Then Me.txtNaziv.Text = dtP.Rows(0).Item("appTitle").ToString.Trim
                If Not dtP.Rows(0).Item("capiservername") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("capiservername") <> "" Then Me.txtCAPI.Text = dtP.Rows(0).Item("capiservername").ToString.Trim
                'If Not dtP.Rows(0).Item("Upitnik") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("Upitnik") <> "" Then Me.txtUpitnik.Text = dtP.Rows(0).Item("Upitnik").ToString.Trim
                If Not dtP.Rows(0).Item("periodics") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("periodics") <> "" Then Me.cboPeriodika.Text = dtP.Rows(0).Item("periodics").ToString.Trim
                If Not dtP.Rows(0).Item("pathToQuery") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("pathToQuery") <> "" Then Me.cbotxtDir.Text = dtP.Rows(0).Item("pathToQuery").ToString.Trim
                If Not dtP.Rows(0).Item("VALIDFROM") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("VALIDFROM").ToString.Trim <> "" Then Me.txtvod.Text = CDate(dtP.Rows(0).Item("VALIDFROM")).ToString("yyyy-MM-dd")
                If Not dtP.Rows(0).Item("VALIDTO") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("VALIDTO").ToString.Trim <> "" Then Me.txtvdo.Text = CDate(dtP.Rows(0).Item("VALIDTO")).ToString("yyyy-MM-dd")
                If Not dtP.Rows(0).Item("databaseAlias") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("databaseAlias") <> "" Then Me.txtDBAlias.Text = dtP.Rows(0).Item("databaseAlias").ToString.Trim
                If Not dtP.Rows(0).Item("additionalParameters") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("additionalParameters") <> "" Then llink = dtP.Rows(0).Item("additionalParameters").ToString.Trim
                If Not dtISTBaze.Rows(0).Item("databaseserver") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("databaseserver") <> "" Then txtServer.Text = dtISTBaze.Rows(0).Item("databaseserver").ToString.Trim
                If Not dtISTBaze.Rows(0).Item("rdatabase") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("rdatabase") <> "" Then txtBaza.Text = dtISTBaze.Rows(0).Item("rdatabase").ToString.Trim
                If Not dtISTBaze.Rows(0).Item("ODBC") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("ODBC") <> "" Then Me.txtConnString.Text = dtISTBaze.Rows(0).Item("ODBC").ToString.Trim

                Dim ggod As Integer = CInt(dtP.Rows(0).Item("ggod").ToString.Trim)
                Dim mmod As Integer = CInt(dtP.Rows(0).Item("mmod").ToString.Trim)
                Dim dod As Date = New Date(ggod, mmod, 2)
                Dim ggdo As Integer = CInt(dtP.Rows(0).Item("ggdo").ToString.Trim)
                Dim mmdo As Integer = CInt(dtP.Rows(0).Item("mmdo").ToString.Trim)
                Dim ddo As Date = New Date(ggdo, mmdo, 2)

                Me.txtvod.Text = dod
                Me.txtvdo.Text = ddo

                If txtCAPI.Text.Trim <> "" Then
                    Dim p() As String = txtCAPI.Text.Trim.Split("$")
                    'txtCapiServer.Text = p(0)
                    If p.Length > 1 Then txtIP.Text = p(1)

                    Dim pp() As String = p(2).Split(";")
                    For i As Integer = 0 To pp.GetUpperBound(0)
                        If pp(i).Trim.ToUpper.IndexOf("INITIAL CATALOG=") = 0 Then
                            Me.txtCAPIBaza.Text = pp(i).Trim.ToUpper.Replace("INITIAL CATALOG=", "")
                            Me.txtCAPIBaza.Visible = True
                        End If
                        If pp(i).Trim.ToUpper.IndexOf("DATA SOURCE=") = 0 Then
                            Me.txtCapiServer.Text = pp(i).Trim.ToUpper.Replace("DATA SOURCE=", "")
                            Me.txtCapiServer.Visible = True
                        End If
                    Next
                    If txtBaza.Text <> "" Then cbPTP.Visible = True
                End If

                If llink <> "" Then
                    Me.cbLink.Checked = True
                    Dim p() As String = llink.Split(";")

                    Dim lt As String = ""
                    For i As Integer = 0 To p.GetUpperBound(0)
                        If p(i).Trim.ToUpper.IndexOf("IST=") = 0 Then
                            cboCopyLink.SelectedValue = p(i).Trim.ToUpper.Replace("IST=", "").Trim
                        ElseIf p(i).Trim.ToUpper.IndexOf("ISTTABLES=") = 0 Then
                            lt = p(i).Trim.ToUpper.Replace("ISTTABLES=", "").Trim
                        ElseIf p(i).Trim.ToUpper.IndexOf("ISTTABELE=") = 0 Then
                            lt = p(i).Trim.ToUpper.Replace("ISTTABELE=", "").Trim
                        End If
                    Next
                    If lt <> "" Then

                        Call addDGVLinkTables()

                        dgvLinkTables.Rows.Clear()
                        cbLinkTables.Checked = True
                        dgvLinkTables.Visible = True
                        dgvLinkTables.Location = New Point(cbLinkTables.Location.X, dgvLinkTables.Location.Y)
                        Dim pp() As String = lt.Split(",")
                        For i As Integer = 0 To pp.GetUpperBound(0)
                            Dim ll() As String = pp(i).Split("=")
                            dgvLinkTables.Rows.Add(New String() {ll(0), ll(1)})
                        Next

                        For k As Integer = 0 To dgvLinkTables.ColumnCount - 1
                            dgvLinkTables.AutoResizeColumn(k)
                        Next
                    End If
                End If

            End If

        End If
    End Sub

    Sub addDGVLinkTables()
        Dim colDBTable As New DataGridViewComboBoxColumn
        colDBTable.Name = "DBTable"
        If dgvLinkTables.Columns.Contains("DBTable") = False Then
            dgvLinkTables.Columns.Add(colDBTable)
            colDBTable.Width = 200
            colDBTable.DropDownWidth = 300
            Dim dd As String = DajDBTabele(txtServer.Text, txtBaza.Text)
            If dd <> "" Then
                Dim dbt() As String = dd.Split(";")
                For i As Integer = 0 To dbt.GetUpperBound(0)
                    colDBTable.Items.Add(dbt(i).Trim.ToUpper)
                Next
            End If
        End If

        Dim colISTTable As New DataGridViewComboBoxColumn
        colISTTable.Name = "ISTTable"

        If dgvLinkTables.Columns.Contains("ISTTable") = False Then
            dgvLinkTables.Columns.Add(colISTTable)
            colISTTable.Width = 200
            colISTTable.DropDownWidth = 300
            Dim dbI() As String = DajISTTabele(Me.cboCopyLink.Text).Split(";")
            For i As Integer = 0 To dbI.GetUpperBound(0)
                colISTTable.Items.Add(dbI(i).Trim.ToUpper)
            Next
        End If
    End Sub

    Private Sub cbNew_CheckedChanged(sender As Object, e As EventArgs) Handles cbNew.CheckedChanged
        If cbNew.Checked = True Then
            cbCopy.Checked = False
            cbLink.Checked = False
            cboCopyLink.Visible = False
            cbPTP.Visible = True
            btnISTUpdate.Visible = False
            btnISTNew.Visible = True
            btnISTNew.Top = btnISTUpdate.Top
        End If
    End Sub

    Private Sub cbCopy_CheckedChanged(sender As Object, e As EventArgs) Handles cbCopy.CheckedChanged

        If btnISTUpdate.Visible = False Then
            cbPTP.Visible = Not cbCopy.Checked
        Else
            cbPTP.Visible = False
        End If

        tvBaza.Nodes.Clear()
        If Me.cbCopy.Checked Then
            cbNew.Checked = False
            cbLink.Checked = False
            Me.cboCopyLink.Visible = True
            Me.txtDBAlias.Enabled = False

            Call PTP()
            Me.cbPTP.Checked = True
            'osvezi cboKopijaOD
            Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST order by 1"   'where year(ValidFrom)<2100
            Call popunicbo(cboCopyLink, strSQl, Me.ISTConnectionString)
            'osvezi dtIST
            Call napunidtIST()
        Else
            Me.cboCopyLink.Visible = False
            Me.txtDBAlias.Enabled = True
            Me.txtServer.Text = ""
            Me.txtBaza.Text = ""
        End If
    End Sub

    Private Sub cbLink_CheckedChanged(sender As Object, e As EventArgs) Handles cbLink.CheckedChanged

        If btnISTUpdate.Visible = False Then
            cbPTP.Visible = Not cbLink.Checked
        Else
            cbPTP.Visible = False
        End If

        tvBaza.Nodes.Clear()
        cbLinkTables.Visible = cbLink.Checked

        If Me.cbLink.Checked Then
            cbPTP.Visible = False
            cbCopy.Checked = False
            Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST order by 1"   'where year(ValidFrom)<2100
            Call popunicbo(cboCopyLink, strSQl, Me.ISTConnectionString)
            Me.cboCopyLink.Visible = True
            Me.txtDBAlias.Enabled = True
            Me.cbPTP.Visible = False
        Else
            cbPTP.Visible = True
            cbLinkTables.Checked = False
            Me.cboCopyLink.Visible = False
            Me.txtDBAlias.Enabled = True
            Me.cbPTP.Visible = False
            Me.txtServer.Text = ""
            Me.txtBaza.Text = ""

        End If
    End Sub

    Private Sub cbPDB_CheckedChanged(sender As Object, e As EventArgs) Handles cbPDB.CheckedChanged
        cbSDB.Checked = Not cbPDB.Checked
        Call DBReset()

        If cbPDB.Checked = True Then
            txtDBAlias.Text = "PUBLICDB"
            txtServer.Text = Me.PublicDBServer
            txtBaza.Text = Me.PublicDBBaza
            txtDBAlias.Enabled = False
            Me.txtConnString.Text = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtBaza.Text + ";Integrated Security=SSPI;Persist Security Info=False"
            Call DBTablesReset()
        Else
            txtDBAlias.Text = ""
            txtServer.Text = ""
            txtBaza.Text = ""
            txtDBAlias.Enabled = True
            Me.txtConnString.Text = ""
            Call DBTablesReset()
        End If

    End Sub

    Private Sub cbSDB_CheckedChanged(sender As Object, e As EventArgs) Handles cbSDB.CheckedChanged
        cbPDB.Checked = Not cbSDB.Checked
        Call DBReset()
    End Sub

    Sub DBTablesReset()
        cbPTP.Checked = False
        tvBaza.Visible = False
        tvBaza.Nodes.Clear()
    End Sub

    Sub DBReset()
        llSB.Visible = cbSDB.Checked
        'txtDBAlias.Visible = cbSDB.Checked
        'lblDBAlias.Visible = cbSDB.Checked
        'txtServer.Visible = cbSDB.Checked
        'txtBaza.Visible = cbSDB.Checked
    End Sub

    Private Sub cboApp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboApp.SelectedIndexChanged
        If cboApp.SelectedValue <> "" Then
            llEditIST.Visible = True
            llDBtoIST.Visible = True
            llDelete.Visible = True
            PanelNewEditApp.Visible = False
        End If
    End Sub


    Function deleteConn() As String
        deleteConn = ""
        Dim appcode As String = cboApp.SelectedValue.ToString
        Dim strdbA As String = "select databaseAlias from ist.dbo._IST where appcode='" + appcode + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(strdbA, Me.ISTConnectionString, Me.jezik)
        Dim dba As String = ""
        If dt.Rows.Count > 0 Then dba = dt.Rows(0).Item("databaseAlias").ToString.Trim.ToUpper
        strdbA = "select appcode from ist.dbo._IST where databaseAlias='" + dba + "' and appcode<>'" + appcode + "'"
        Dim dt2 As DataTable = izvrsiSQLvratiDT(strdbA, Me.ISTConnectionString, Me.jezik)
        If dt2.Rows.Count = 0 Then deleteConn = dba
    End Function

    Sub refreshAppList()
        Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST where appInEditMeta =4 order by 1"
        Call popunicbo(cboApp, strSQl, Me.ISTConnectionString)
    End Sub

    Private Sub CheckTreeViewNode(ByVal node As TreeNode, ByVal isChecked As Boolean)
        For Each item As TreeNode In node.Nodes
            item.Checked = isChecked

            If item.Nodes.Count > 0 Then
                Me.CheckTreeViewNode(item, isChecked)
            End If
        Next
    End Sub

    Private Sub tvBazaP_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvBazaP.AfterCheck
        CheckTreeViewNode(e.Node, e.Node.Checked)
    End Sub

    Private Sub tvBazaPP_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvBazaPP.AfterCheck
        CheckTreeViewNode(e.Node, e.Node.Checked)
    End Sub

    Private Sub tvBazaPK_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvBazaPK.AfterCheck
        CheckTreeViewNode(e.Node, e.Node.Checked)
    End Sub

    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelMenu
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
        Me.SplitContainer1.SplitterDistance = 4 * SplitContainer1.Width \ 5

        Call Podesi_PanelNewEditApp()
        Call Podesi_panelDBIST()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        CollapseMenu()
    End Sub



    Private Sub Podesi_PanelNewEditApp()
        ' 'PanelNewEditApp.Width ' Current Width
        PanelNewEditApp.Width = SplitContainer1.Panel1.Width - 5
        PanelNewEditApp.Height = SplitContainer1.Panel1.Height - 75
        PanelNewEditApp.Location = New Point(2, 102)

        Dim RW As Double = (PanelNewEditApp.Width - CW) / CW  ' Ratio change of width

        For Each Ctrl As Control In PanelNewEditApp.Controls
            Ctrl.Width = Ctrl.Width + CInt(Ctrl.Width * RW)    'CInt(Ctrl.Width * RW-0.08)
            Ctrl.Left = Ctrl.Left + CInt(Ctrl.Left * RW)
        Next
    End Sub

    Private Sub Podesi_panelDBIST()

        panelDBIST.Width = SplitContainer1.Panel1.Width - 5
        panelDBIST.Height = SplitContainer1.Panel1.Height - 75
        panelDBIST.Location = New Point(2, 102)

        TableLayoutPanel1.Width = panelDBIST.Width - 5
        TableLayoutPanel1.Height = panelDBIST.Height - 5
        TableLayoutPanel1.Location = New Point(2, 2)

        Panel1.Width = TableLayoutPanel1.Width - 5
        Panel1.Height = panelDBIST.Height \ 3 - 25
        Panel1.Location = New Point(2, 2)

        Panel2.Width = TableLayoutPanel1.Width - 5
        Panel2.Height = panelDBIST.Height \ 3 - 25
        Panel2.Location = New Point(2, Panel1.Location.Y + Panel1.Height + 2)

        Panel3.Width = TableLayoutPanel1.Width - 5
        Panel3.Height = panelDBIST.Height \ 3 - 25
        Panel3.Location = New Point(2, Panel2.Location.Y + Panel2.Height + 2)

        Dim RW As Double = (panelDBIST.Width - CW) / CW  ' Ratio change of width

        For Each Ctrl As Control In panelDBIST.Controls
            Ctrl.Width = Ctrl.Width + CInt(Ctrl.Width * RW)    'CInt(Ctrl.Width * RW-0.08)
            Ctrl.Left = Ctrl.Left + CInt(Ctrl.Left * RW)
        Next
        For Each Ctrl As Control In TableLayoutPanel1.Controls
            Ctrl.Width = Ctrl.Width + CInt(Ctrl.Width * RW)    'CInt(Ctrl.Width * RW-0.08)
            Ctrl.Left = Ctrl.Left + CInt(Ctrl.Left * RW)
        Next
        For Each Ctrl As Control In Panel1.Controls
            Ctrl.Width = Ctrl.Width + CInt(Ctrl.Width * RW)    'CInt(Ctrl.Width * RW-0.08)
            Ctrl.Left = Ctrl.Left + CInt(Ctrl.Left * RW)
        Next
        For Each Ctrl As Control In Panel2.Controls
            Ctrl.Width = Ctrl.Width + CInt(Ctrl.Width * RW)    'CInt(Ctrl.Width * RW-0.08)
            Ctrl.Left = Ctrl.Left + CInt(Ctrl.Left * RW)
        Next
        For Each Ctrl As Control In Panel3.Controls
            Ctrl.Width = Ctrl.Width + CInt(Ctrl.Width * RW)    'CInt(Ctrl.Width * RW-0.08)
            Ctrl.Left = Ctrl.Left + CInt(Ctrl.Left * RW)
        Next
        tvBazaP.Height = 4 * Panel1.Height \ 5
        tvBazaPP.Height = 4 * Panel2.Height \ 5
        tvBazaPK.Height = 4 * Panel3.Height \ 5

    End Sub

    Private Sub form_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call PreVentFlicker()
        Call SettingObjForTheme(GetTheme())

        Me.SplitContainer1.SplitterDistance = PanelContext.Width - 255

        If Me.panelmenucollapse = True Then
            Call CollapseMenu()
        End If

    End Sub
    'Private Sub CollapseMenu()
    '    If Me.PanelMenu.Width > 200 Then
    '        PanelMenu.Width = 60
    '        setTollTip(True)
    '        panelmenucollapse = True
    '        Button2.Visible = False
    '        Button7.Image = Nothing
    '    Else
    '        PanelMenu.Width = 255
    '        setTollTip(False)
    '        panelmenucollapse = False
    '        Button7.Image = My.Resources.crtaaaaa.ToBitmap
    '        Button2.Visible = True
    '    End If
    '    Me.SplitContainer1.SplitterDistance = PanelContext.Width - 255
    'End Sub

    Dim zapamtilogovanog As String = ""

    Private Sub CollapseMenu()

        'PanelBoje.Visible = False
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
            PanelMenu.Width = 60
            panelmenucollapse = True
            Button2.Visible = False
            btnLinija.Image = Nothing
            Button7.Image = Nothing
        Else
            Logovan.Visible = True
            Logovan.Text = zapamtilogovanog
            PanelMenu.Width = 255
            setTollTip(False)
            panelmenucollapse = False
            btnLinija.Image = My.Resources.crtaaaaa.ToBitmap
            Button7.Image = My.Resources.crtaaaaa.ToBitmap
            Button2.Visible = True

        End If
    End Sub



    Sub setTollTip(ByVal visibleTrue As Boolean)
        If visibleTrue = True Then
            'ToolTip1.SetToolTip(ButtonAAzuriraj1, ButtonAAzuriraj1.Tag)
            'ToolTip1.SetToolTip(ButtonAIzborKolona1, ButtonAIzborKolona1.Tag)
            'ToolTip1.SetToolTip(ButtonAIzborSlogova1, ButtonAIzborSlogova1.Tag)
            'ToolTip1.SetToolTip(ButtonABrisi1, ButtonABrisi1.Tag)
            'ToolTip1.SetToolTip(ButtonANoviSlog1, ButtonANoviSlog1.Tag)
            'ToolTip1.SetToolTip(ButtonAUpitnik1, ButtonAUpitnik1.Tag)
            'ToolTip1.SetToolTip(ButtonLK1, ButtonLK1.Tag)
            'ToolTip1.SetToolTip(btnNP1, btnNP1.Tag)
            'ToolTip1.SetToolTip(BtnEx1, BtnEx1.Tag)
            'ToolTip1.SetToolTip(btn_JSON, btn_JSON.Tag)
            'ToolTip1.SetToolTip(Btn_XML, Btn_XML.Tag)
            'ToolTip1.SetToolTip(btn_SPSS1, btn_SPSS1.Tag)
        Else
            'ToolTip1.SetToolTip(ButtonAAzuriraj1, "")
            'ToolTip1.SetToolTip(ButtonAIzborKolona1, "")
            'ToolTip1.SetToolTip(ButtonAIzborSlogova1, "")
            'ToolTip1.SetToolTip(ButtonABrisi1, "")
            'ToolTip1.SetToolTip(ButtonANoviSlog1, "")
            'ToolTip1.SetToolTip(ButtonAUpitnik1, "")
            'ToolTip1.SetToolTip(ButtonLK1, "")
            'ToolTip1.SetToolTip(btnNP1, "")
            'ToolTip1.SetToolTip(BtnEx1, "")
            'ToolTip1.SetToolTip(btn_JSON, "")
            'ToolTip1.SetToolTip(Btn_XML, "")
            'ToolTip1.SetToolTip(btn_SPSS1, "")
        End If
    End Sub

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
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
        System.Windows.Forms.Application.Exit()

    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub llDBtoIST_Click(sender As Object, e As EventArgs) Handles llDBtoIST.Click
        Call panelsVisibleFalse()
        llEditIST.Visible = True
        llDBtoIST.Visible = True
        llDelete.Visible = True
        cboApp.Visible = True
        Dim vrednost As String = cboApp.SelectedValue.ToString

        Dim sqlP As String = "select * from _IST where appCode='" + vrednost + "' "
        Dim dtP As DataTable = izvrsiSQLvratiDT(sqlP, Me.ISTConnectionString, Me.jezik)

        Dim sql As String = "select databaseAlias,rdatabase,databaseserver,connectionDoc,ODBC from vBazaServerEng where appcode='" + vrednost + "' "
        Dim dtISTBaze As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Me.jezik)

        If dtP.Rows.Count <> 1 Then
            ''msg 311
            Dim msgtxt311 As String = getMessageText(dtMessages, "311", Me.jezik)
            ISTMessageBox.Show(msgtxt311, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If Not dtP.Rows(0).Item("VALIDFROM") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("VALIDFROM").ToString.Trim <> "" Then Me.txtVALIDFROM1.Text = CDate(dtP.Rows(0).Item("VALIDFROM")).ToString("yyyy-MM-dd")
            If Not dtP.Rows(0).Item("VALIDTO") Is System.DBNull.Value AndAlso dtP.Rows(0).Item("VALIDTO").ToString.Trim <> "" Then Me.txtVDO1.Text = CDate(dtP.Rows(0).Item("VALIDTO")).ToString("yyyy-MM-dd")
            If Not dtISTBaze.Rows(0).Item("databaseserver") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("databaseserver") <> "" Then Me.txtServerP.Text = dtISTBaze.Rows(0).Item("databaseserver").ToString.Trim
            If Not dtISTBaze.Rows(0).Item("rdatabase") Is System.DBNull.Value AndAlso dtISTBaze.Rows(0).Item("rdatabase") <> "" Then Me.txtPravaBazaP.Text = dtISTBaze.Rows(0).Item("rdatabase").ToString.Trim
        End If

        tvBazaP.Nodes.Clear()
        tvBazaPP.Nodes.Clear()
        tvBazaPK.Nodes.Clear()

        'Call Podesi_panelDBIST()

        panelDBIST.Visible = True
    End Sub

    Private Sub llDelete_Click(sender As Object, e As EventArgs) Handles llDelete.Click

        Dim appcode As String = cboApp.SelectedValue.ToString
        If ISTMessageBox.Show("Are you sure you want to delete app " + appcode + " from IST metadata?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ISTMessageBox.Show("Are you sure you want to delete app " + appcode + " from IST metadata?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Dim p1 As String = "nok"
                Dim strSQl As String = "begin transaction" + nvrd
                strSQl = strSQl + "delete from ist.dbo._IST where appcode='" + appcode + "';" + nvrd
                Dim dba As String = deleteConn()
                If dba <> "" Then strSQl = strSQl + "delete from ist.dbo._ISTDatabaseConnStrings where databaseAlias='" + dba + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTTables where appcode='" + appcode + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTTablesColumns where appcode='" + appcode + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTReportsProcedures where appcode='" + appcode + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTRulesDataValidation where appcode='" + appcode + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTAWLs where appcode='" + appcode + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTQuestionExplanation where appcode='" + appcode + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTLabels where appcode='" + appcode + "';" + nvrd
                strSQl = strSQl + "delete from ist.dbo._ISTMessages where appcode='" + appcode + "';" + nvrd

                strSQl = strSQl + "commit;" + nvrd
                p1 = izvrsiSQL(strSQl, Me.ISTConnectionString)
                If p1 = "nok" Then
                    ISTMessageBox.Show("Error. App has not been deleted from IST!")
                Else
                    ISTMessageBox.Show("App has been deleted from IST!")
                    Call refreshAppList()
                End If
            End If
        End If
        Call resetEditAPP()

    End Sub
    Sub resetEditAPP()
        Call panelsVisibleFalse()

        btnISTNew.Visible = False
        btnISTUpdate.Visible = True
        cboApp.Width = cbEditApp.Width
        cboApp.Visible = True
        Call refreshAppList()
        '*****
        tvBaza.Visible = False
        '*****
        ActivateButton(cbEditApp, ActivateButtonColor)
    End Sub
    Private Sub llISTPolja_Click(sender As Object, e As EventArgs) Handles llISTPolja.Click
        Me.Cursor = Cursors.WaitCursor
        Call panelsVisibleFalse()

        Dim frm As New Form_ISTTables(Me.DBConnectionString, Me.ISTConnectionString, Me.txtmode, Me.jezik, Me.DSBrisanjeDEPO.Trim.ToUpper, Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, Me.vt)
        Me.Hide()
        Try
            Me.Cursor = Cursors.Default
            Me.Hide()
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
            frm.Dispose()
            Me.Show()
            Call UpisiUISTLogKoriscenjaProcesa("_ISTTables")
        End Try
    End Sub

    Private Sub llISTLK_Click(sender As Object, e As EventArgs) Handles llISTLK.Click
        Call panelsVisibleFalse()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New Form_ISTLK(Me.DBConnectionString, Me.ISTConnectionString, cboApp.SelectedValue, Me.txtmode, Me.jezik)
        Me.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            Me.Show()
            Call UpisiUISTLogKoriscenjaProcesa("_ISTLK")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub


    Private Sub cbISTNewTable_CheckedChanged(sender As Object, e As EventArgs) Handles cbISTNewTable.CheckedChanged
        tvBazaP.Visible = Me.cbISTNewTable.Checked
        If Me.cbISTNewTable.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            'tabele nisu u Istu
            Dim ISTserver As String = ""
            Dim kkk() As String = Me.ISTConnectionString.Split(";")
            For i As Integer = 0 To kkk.GetUpperBound(0)
                Dim ppp() As String = kkk(i).Split("=")
                If ppp(0).Trim.ToUpper = "DATA SOURCE" Then ISTserver = ppp(1)
            Next
            'zbog brzine
            Dim iistserver As String = ""
            If ISTserver.Trim.ToUpper.IndexOf(".") > 0 Then iistserver = ISTserver.Split(".")(0) Else iistserver = ISTserver
            Dim ttxtServerP As String = ""
            If txtServerP.Text.Trim.ToUpper.IndexOf(".") > 0 Then ttxtServerP = txtServerP.Text.Split(".")(0) Else ttxtServerP = txtServerP.Text

            If iistserver.Trim.ToUpper = ttxtServerP.Trim.ToUpper Then
                Call DajTabelePolja(tvBazaP, Me.txtServerP.Text, Me.txtPravaBazaP.Text, False)
            Else
                Call DajTabelePoljaNisuIstiServeri(tvBazaP, Me.txtServerP.Text, Me.txtPravaBazaP.Text, False)
            End If
            Me.Cursor = Cursors.Default
        Else
            tvBazaP.Nodes.Clear()
        End If
    End Sub

    Private Sub cbISTNewFields_CheckedChanged(sender As Object, e As EventArgs) Handles cbISTNewFields.CheckedChanged
        tvBazaPP.Visible = cbISTNewFields.Checked
        If Me.cbISTNewFields.Checked = True Then
            Me.Cursor = Cursors.WaitCursor
            'tabele u Istu, polja nisu u Istu, tabela cija su sva polja vec u istu se ne prikazuju
            'tabele nisu u Istu
            Dim ISTserver As String = ""
            Dim kkk() As String = Me.ISTConnectionString.Split(";")
            For i As Integer = 0 To kkk.GetUpperBound(0)
                Dim ppp() As String = kkk(i).Split("=")
                If ppp(0).Trim.ToUpper = "DATA SOURCE" Then ISTserver = ppp(1)
            Next
            'zbog brzine
            Dim iistserver As String = ""
            If ISTserver.Trim.ToUpper.IndexOf(".") > 0 Then iistserver = ISTserver.Split(".")(0) Else iistserver = ISTserver
            Dim ttxtServerP As String = ""
            If txtServerP.Text.Trim.ToUpper.IndexOf(".") > 0 Then ttxtServerP = txtServerP.Text.Split(".")(0) Else ttxtServerP = txtServerP.Text

            If iistserver.Trim.ToUpper = ttxtServerP.Trim.ToUpper Then
                Call DajTabelePolja(tvBazaPP, Me.txtServerP.Text, Me.txtPravaBazaP.Text, True, False)
            Else
                Call DajTabelePoljaNisuIstiServeri(tvBazaPP, Me.txtServerP.Text, Me.txtPravaBazaP.Text, True, False)
            End If
            Me.Cursor = Cursors.Default
        Else
            tvBazaPP.Nodes.Clear()
        End If
    End Sub

    Private Sub cbNewApp_MouseDown(sender As Object, e As MouseEventArgs) Handles llISTPolja.MouseDown, llISTLK.MouseDown, cbNewApp.MouseDown, cbEditApp.MouseDown
        ActivateButton(sender, ActivateButtonColor)
    End Sub

    Dim zapamtibojuteme As Color = Nothing

    Sub visiblePanelTOP()
        btnArrowDownHover.Visible = False
        PanelTop.BackColor = zapamtibojuteme
        btnCerrar.Visible = True
        'btnMinimizar.Visible = True
        'MRefresh.Visible = True
        'b3.Visible = True

    End Sub

    Sub nonvisiblePanelTOP()
        'If ctMenuStrip.Visible = False Then

        btnCerrar.Visible = False
        'btnMinimizar.Visible = False
        'MRefresh.Visible = False
        'b3.Visible = False
        PanelTop.BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
        btnArrowDownHover.Visible = True

        'End If

    End Sub

    Private Sub PanelTop_MouseLeave(sender As Object, e As EventArgs) Handles PanelTop.MouseLeave, btnCerrar.MouseLeave, btnMinimizar.MouseLeave, MRefresh.MouseLeave, b3.MouseLeave
        If MouseIsOverButton(b3) OrElse MouseIsOverButton(btnCerrar) OrElse MouseIsOverButton(btnMinimizar) OrElse MouseIsOverButton(MRefresh) OrElse MouseIsOverPanel(PanelTop) Then

        Else
            If otvorenSubMenu = False Then
                nonvisiblePanelTOP()
            End If

            'End If
        End If
    End Sub
    Dim otvorenSubMenu As Boolean = False

    Private Sub btnArrowDownHover_MouseHover(sender As Object, e As EventArgs) Handles btnArrowDownHover.MouseHover, PanelTop.MouseHover
        visiblePanelTOP()
    End Sub

    Private Sub PanelMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnCerrar.MouseEnter, btnMinimizar.MouseEnter, MRefresh.MouseEnter, b3.MouseEnter ', ctMenuStrip.MouseEnter
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class