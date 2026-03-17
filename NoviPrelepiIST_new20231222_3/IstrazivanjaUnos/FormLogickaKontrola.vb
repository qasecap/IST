Option Strict Off
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports Microsoft.Office.Interop

Public Class FormLogickaKontrola
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents tbSql As System.Windows.Forms.TextBox

    Friend WithEvents TableLayoutPanelTABLE As TableLayoutPanel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents dgvG As DataGridView
    Friend WithEvents dgvT As DataGridView
    Friend WithEvents dgvP As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvGreske As DataGridView
    Friend WithEvents dgvTabele As DataGridView
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents UserControlVremenskaTacka1 As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents ButtonLKPOPoljimaUradi As Button
    Private WithEvents ButtonUradi As Button
    Friend WithEvents ButtonLKPOTabelamaUradi As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ButtonLK1 As Button
    Friend WithEvents ButtonLKPOPoljima As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents ButtonLKPOTabelama As Button
    Friend WithEvents BtnEx1 As Button
    Friend WithEvents cmdOpenIzv1 As Button
    Friend WithEvents cmdSaveIZV1 As Button
    Friend WithEvents ButtonIzvestaj1 As Button
    Friend WithEvents PanelContext As Panel
    Friend WithEvents btnPrazno As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLinijaRazmak As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnArrowDownHover As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents ToolTip1 As ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogickaKontrola))
        Me.tbSql = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelTABLE = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.dgvGreske = New System.Windows.Forms.DataGridView()
        Me.dgvG = New System.Windows.Forms.DataGridView()
        Me.dgvTabele = New System.Windows.Forms.DataGridView()
        Me.dgvT = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.dgvP = New System.Windows.Forms.DataGridView()
        Me.ButtonLKPOPoljimaUradi = New System.Windows.Forms.Button()
        Me.ButtonLKPOTabelamaUradi = New System.Windows.Forms.Button()
        Me.ButtonUradi = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ButtonLK1 = New System.Windows.Forms.Button()
        Me.UserControlVremenskaTacka1 = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.ButtonLKPOPoljima = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.ButtonLKPOTabelama = New System.Windows.Forms.Button()
        Me.BtnEx1 = New System.Windows.Forms.Button()
        Me.cmdOpenIzv1 = New System.Windows.Forms.Button()
        Me.cmdSaveIZV1 = New System.Windows.Forms.Button()
        Me.ButtonIzvestaj1 = New System.Windows.Forms.Button()
        Me.btnPrazno = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnLinijaRazmak = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnArrowDownHover = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelTABLE.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTabele, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContext.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSql
        '
        Me.tbSql.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tbSql.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSql.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSql.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbSql.Location = New System.Drawing.Point(3, 604)
        Me.tbSql.Multiline = True
        Me.tbSql.Name = "tbSql"
        Me.tbSql.Size = New System.Drawing.Size(887, 100)
        Me.tbSql.TabIndex = 49
        Me.tbSql.Visible = False
        '
        'TableLayoutPanelTABLE
        '
        Me.TableLayoutPanelTABLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TableLayoutPanelTABLE.ColumnCount = 1
        Me.TableLayoutPanelTABLE.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanelTABLE.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.ProgressBar1, 0, 2)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.tbSql, 0, 1)
        Me.TableLayoutPanelTABLE.Controls.Add(Me.dgvP, 0, 1)
        Me.TableLayoutPanelTABLE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelTABLE.Location = New System.Drawing.Point(2, 0)
        Me.TableLayoutPanelTABLE.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanelTABLE.Name = "TableLayoutPanelTABLE"
        Me.TableLayoutPanelTABLE.RowCount = 3
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTABLE.Size = New System.Drawing.Size(893, 749)
        Me.TableLayoutPanelTABLE.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.b1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.b2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvGreske, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvG, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvTabele, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvT, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(893, 601)
        Me.TableLayoutPanel1.TabIndex = 179
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.Transparent
        Me.b1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b1.FlatAppearance.BorderSize = 0
        Me.b1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ForeColor = System.Drawing.Color.Black
        Me.b1.Location = New System.Drawing.Point(3, 3)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(217, 9)
        Me.b1.TabIndex = 179
        Me.b1.TabStop = False
        Me.b1.Text = "."
        Me.b1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b1.UseVisualStyleBackColor = False
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.Transparent
        Me.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b2.FlatAppearance.BorderSize = 0
        Me.b2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.ForeColor = System.Drawing.Color.Black
        Me.b2.Location = New System.Drawing.Point(226, 3)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(664, 9)
        Me.b2.TabIndex = 179
        Me.b2.TabStop = False
        Me.b2.Text = "."
        Me.b2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b2.UseVisualStyleBackColor = False
        '
        'dgvGreske
        '
        Me.dgvGreske.AllowUserToAddRows = False
        Me.dgvGreske.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvGreske.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGreske.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGreske.Location = New System.Drawing.Point(226, 18)
        Me.dgvGreske.Name = "dgvGreske"
        Me.dgvGreske.Size = New System.Drawing.Size(664, 286)
        Me.dgvGreske.TabIndex = 9
        Me.dgvGreske.TabStop = False
        Me.dgvGreske.Text = "dgvGreske"
        '
        'dgvG
        '
        Me.dgvG.AllowUserToAddRows = False
        Me.dgvG.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvG.Location = New System.Drawing.Point(226, 310)
        Me.dgvG.Name = "dgvG"
        Me.dgvG.Size = New System.Drawing.Size(664, 288)
        Me.dgvG.TabIndex = 3
        Me.dgvG.TabStop = False
        Me.dgvG.Text = "dgvG"
        Me.dgvG.Visible = False
        '
        'dgvTabele
        '
        Me.dgvTabele.AllowUserToAddRows = False
        Me.dgvTabele.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvTabele.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTabele.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabele.Location = New System.Drawing.Point(3, 18)
        Me.dgvTabele.Name = "dgvTabele"
        Me.dgvTabele.Size = New System.Drawing.Size(217, 286)
        Me.dgvTabele.TabIndex = 8
        Me.dgvTabele.TabStop = False
        Me.dgvTabele.Text = "dgvTabele"
        '
        'dgvT
        '
        Me.dgvT.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvT.Location = New System.Drawing.Point(3, 310)
        Me.dgvT.Name = "dgvT"
        Me.dgvT.Size = New System.Drawing.Size(217, 288)
        Me.dgvT.TabIndex = 2
        Me.dgvT.TabStop = False
        Me.dgvT.Text = "dgvT"
        Me.dgvT.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Window
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.ForeColor = System.Drawing.Color.SteelBlue
        Me.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 731)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(887, 15)
        Me.ProgressBar1.TabIndex = 174
        '
        'dgvP
        '
        Me.dgvP.AllowUserToAddRows = False
        Me.dgvP.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvP.Location = New System.Drawing.Point(3, 710)
        Me.dgvP.Name = "dgvP"
        Me.dgvP.Size = New System.Drawing.Size(887, 15)
        Me.dgvP.TabIndex = 3
        Me.dgvP.TabStop = False
        Me.dgvP.Text = "dgvP"
        Me.dgvP.Visible = False
        '
        'ButtonLKPOPoljimaUradi
        '
        Me.ButtonLKPOPoljimaUradi.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonLKPOPoljimaUradi.BackgroundImage = CType(resources.GetObject("ButtonLKPOPoljimaUradi.BackgroundImage"), System.Drawing.Image)
        Me.ButtonLKPOPoljimaUradi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonLKPOPoljimaUradi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLKPOPoljimaUradi.FlatAppearance.BorderSize = 0
        Me.ButtonLKPOPoljimaUradi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.ButtonLKPOPoljimaUradi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLKPOPoljimaUradi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLKPOPoljimaUradi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLKPOPoljimaUradi.Location = New System.Drawing.Point(228, 427)
        Me.ButtonLKPOPoljimaUradi.Name = "ButtonLKPOPoljimaUradi"
        Me.ButtonLKPOPoljimaUradi.Size = New System.Drawing.Size(22, 24)
        Me.ButtonLKPOPoljimaUradi.TabIndex = 56
        Me.ButtonLKPOPoljimaUradi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonLKPOPoljimaUradi.UseVisualStyleBackColor = False
        Me.ButtonLKPOPoljimaUradi.Visible = False
        '
        'ButtonLKPOTabelamaUradi
        '
        Me.ButtonLKPOTabelamaUradi.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonLKPOTabelamaUradi.BackgroundImage = CType(resources.GetObject("ButtonLKPOTabelamaUradi.BackgroundImage"), System.Drawing.Image)
        Me.ButtonLKPOTabelamaUradi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonLKPOTabelamaUradi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLKPOTabelamaUradi.FlatAppearance.BorderSize = 0
        Me.ButtonLKPOTabelamaUradi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Bisque
        Me.ButtonLKPOTabelamaUradi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLKPOTabelamaUradi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLKPOTabelamaUradi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLKPOTabelamaUradi.Location = New System.Drawing.Point(228, 381)
        Me.ButtonLKPOTabelamaUradi.Name = "ButtonLKPOTabelamaUradi"
        Me.ButtonLKPOTabelamaUradi.Size = New System.Drawing.Size(22, 24)
        Me.ButtonLKPOTabelamaUradi.TabIndex = 52
        Me.ButtonLKPOTabelamaUradi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonLKPOTabelamaUradi.UseVisualStyleBackColor = False
        Me.ButtonLKPOTabelamaUradi.Visible = False
        '
        'ButtonUradi
        '
        Me.ButtonUradi.BackColor = System.Drawing.Color.White
        Me.ButtonUradi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUradi.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonUradi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonUradi.Location = New System.Drawing.Point(194, 543)
        Me.ButtonUradi.Name = "ButtonUradi"
        Me.ButtonUradi.Size = New System.Drawing.Size(32, 24)
        Me.ButtonUradi.TabIndex = 182
        Me.ButtonUradi.Text = "Контрола ст"
        Me.ButtonUradi.UseVisualStyleBackColor = False
        Me.ButtonUradi.Visible = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnBack)
        Me.PanelMenu.Controls.Add(Me.Logovan)
        Me.PanelMenu.Controls.Add(Me.ButtonLKPOPoljimaUradi)
        Me.PanelMenu.Controls.Add(Me.ButtonLKPOTabelamaUradi)
        Me.PanelMenu.Controls.Add(Me.ButtonUradi)
        Me.PanelMenu.Controls.Add(Me.ButtonLK1)
        Me.PanelMenu.Controls.Add(Me.UserControlVremenskaTacka1)
        Me.PanelMenu.Controls.Add(Me.ButtonLKPOPoljima)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.ButtonLKPOTabelama)
        Me.PanelMenu.Controls.Add(Me.BtnEx1)
        Me.PanelMenu.Controls.Add(Me.cmdOpenIzv1)
        Me.PanelMenu.Controls.Add(Me.cmdSaveIZV1)
        Me.PanelMenu.Controls.Add(Me.ButtonIzvestaj1)
        Me.PanelMenu.Controls.Add(Me.btnPrazno)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button7)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(255, 749)
        Me.PanelMenu.TabIndex = 142
        '
        'ButtonLK1
        '
        Me.ButtonLK1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLK1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLK1.FlatAppearance.BorderSize = 0
        Me.ButtonLK1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonLK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLK1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLK1.ForeColor = System.Drawing.Color.White
        Me.ButtonLK1.Image = CType(resources.GetObject("ButtonLK1.Image"), System.Drawing.Image)
        Me.ButtonLK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLK1.Location = New System.Drawing.Point(10, 144)
        Me.ButtonLK1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonLK1.Name = "ButtonLK1"
        Me.ButtonLK1.Size = New System.Drawing.Size(240, 38)
        Me.ButtonLK1.TabIndex = 30
        Me.ButtonLK1.Text = "    Контрола"
        Me.ButtonLK1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLK1.UseVisualStyleBackColor = False
        '
        'UserControlVremenskaTacka1
        '
        Me.UserControlVremenskaTacka1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UserControlVremenskaTacka1.Enabled = False
        Me.UserControlVremenskaTacka1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.UserControlVremenskaTacka1.ForeColor = System.Drawing.Color.DarkRed
        Me.UserControlVremenskaTacka1.Location = New System.Drawing.Point(194, 573)
        Me.UserControlVremenskaTacka1.Name = "UserControlVremenskaTacka1"
        Me.UserControlVremenskaTacka1.Size = New System.Drawing.Size(32, 27)
        Me.UserControlVremenskaTacka1.TabIndex = 20
        Me.UserControlVremenskaTacka1.Visible = False
        '
        'ButtonLKPOPoljima
        '
        Me.ButtonLKPOPoljima.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLKPOPoljima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLKPOPoljima.FlatAppearance.BorderSize = 0
        Me.ButtonLKPOPoljima.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonLKPOPoljima.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLKPOPoljima.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLKPOPoljima.ForeColor = System.Drawing.Color.White
        Me.ButtonLKPOPoljima.Image = CType(resources.GetObject("ButtonLKPOPoljima.Image"), System.Drawing.Image)
        Me.ButtonLKPOPoljima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLKPOPoljima.Location = New System.Drawing.Point(10, 420)
        Me.ButtonLKPOPoljima.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonLKPOPoljima.Name = "ButtonLKPOPoljima"
        Me.ButtonLKPOPoljima.Size = New System.Drawing.Size(240, 38)
        Me.ButtonLKPOPoljima.TabIndex = 19
        Me.ButtonLKPOPoljima.Text = "    ЛК са филтером"
        Me.ButtonLKPOPoljima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLKPOPoljima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLKPOPoljima.UseVisualStyleBackColor = False
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
        'ButtonLKPOTabelama
        '
        Me.ButtonLKPOTabelama.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLKPOTabelama.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLKPOTabelama.FlatAppearance.BorderSize = 0
        Me.ButtonLKPOTabelama.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonLKPOTabelama.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLKPOTabelama.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLKPOTabelama.ForeColor = System.Drawing.Color.White
        Me.ButtonLKPOTabelama.Image = CType(resources.GetObject("ButtonLKPOTabelama.Image"), System.Drawing.Image)
        Me.ButtonLKPOTabelama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLKPOTabelama.Location = New System.Drawing.Point(10, 374)
        Me.ButtonLKPOTabelama.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonLKPOTabelama.Name = "ButtonLKPOTabelama"
        Me.ButtonLKPOTabelama.Size = New System.Drawing.Size(240, 38)
        Me.ButtonLKPOTabelama.TabIndex = 8
        Me.ButtonLKPOTabelama.Text = "    ЛК по табелама/грешкама"
        Me.ButtonLKPOTabelama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonLKPOTabelama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLKPOTabelama.UseVisualStyleBackColor = False
        '
        'BtnEx1
        '
        Me.BtnEx1.BackColor = System.Drawing.Color.Transparent
        Me.BtnEx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEx1.CausesValidation = False
        Me.BtnEx1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEx1.FlatAppearance.BorderSize = 0
        Me.BtnEx1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BtnEx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEx1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEx1.ForeColor = System.Drawing.Color.White
        Me.BtnEx1.Image = CType(resources.GetObject("BtnEx1.Image"), System.Drawing.Image)
        Me.BtnEx1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEx1.Location = New System.Drawing.Point(10, 328)
        Me.BtnEx1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnEx1.Name = "BtnEx1"
        Me.BtnEx1.Size = New System.Drawing.Size(240, 38)
        Me.BtnEx1.TabIndex = 6
        Me.BtnEx1.Tag = "    Excel"
        Me.BtnEx1.Text = "    Excel"
        Me.BtnEx1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEx1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEx1.UseVisualStyleBackColor = False
        '
        'cmdOpenIzv1
        '
        Me.cmdOpenIzv1.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpenIzv1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdOpenIzv1.FlatAppearance.BorderSize = 0
        Me.cmdOpenIzv1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdOpenIzv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOpenIzv1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenIzv1.ForeColor = System.Drawing.Color.White
        Me.cmdOpenIzv1.Image = CType(resources.GetObject("cmdOpenIzv1.Image"), System.Drawing.Image)
        Me.cmdOpenIzv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOpenIzv1.Location = New System.Drawing.Point(10, 282)
        Me.cmdOpenIzv1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdOpenIzv1.Name = "cmdOpenIzv1"
        Me.cmdOpenIzv1.Size = New System.Drawing.Size(240, 38)
        Me.cmdOpenIzv1.TabIndex = 4
        Me.cmdOpenIzv1.Text = "    Претходни извештаји"
        Me.cmdOpenIzv1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOpenIzv1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOpenIzv1.UseVisualStyleBackColor = False
        '
        'cmdSaveIZV1
        '
        Me.cmdSaveIZV1.BackColor = System.Drawing.Color.Transparent
        Me.cmdSaveIZV1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSaveIZV1.FlatAppearance.BorderSize = 0
        Me.cmdSaveIZV1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cmdSaveIZV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaveIZV1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveIZV1.ForeColor = System.Drawing.Color.White
        Me.cmdSaveIZV1.Image = CType(resources.GetObject("cmdSaveIZV1.Image"), System.Drawing.Image)
        Me.cmdSaveIZV1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSaveIZV1.Location = New System.Drawing.Point(10, 236)
        Me.cmdSaveIZV1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmdSaveIZV1.Name = "cmdSaveIZV1"
        Me.cmdSaveIZV1.Size = New System.Drawing.Size(240, 38)
        Me.cmdSaveIZV1.TabIndex = 2
        Me.cmdSaveIZV1.Text = "    Сачувај извештај"
        Me.cmdSaveIZV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSaveIZV1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSaveIZV1.UseVisualStyleBackColor = False
        '
        'ButtonIzvestaj1
        '
        Me.ButtonIzvestaj1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIzvestaj1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzvestaj1.FlatAppearance.BorderSize = 0
        Me.ButtonIzvestaj1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonIzvestaj1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIzvestaj1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzvestaj1.ForeColor = System.Drawing.Color.White
        Me.ButtonIzvestaj1.Image = CType(resources.GetObject("ButtonIzvestaj1.Image"), System.Drawing.Image)
        Me.ButtonIzvestaj1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzvestaj1.Location = New System.Drawing.Point(10, 190)
        Me.ButtonIzvestaj1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonIzvestaj1.Name = "ButtonIzvestaj1"
        Me.ButtonIzvestaj1.Size = New System.Drawing.Size(240, 38)
        Me.ButtonIzvestaj1.TabIndex = 0
        Me.ButtonIzvestaj1.Text = "    Извештај"
        Me.ButtonIzvestaj1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzvestaj1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonIzvestaj1.UseVisualStyleBackColor = False
        '
        'btnPrazno
        '
        Me.btnPrazno.BackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPrazno.FlatAppearance.BorderSize = 0
        Me.btnPrazno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrazno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrazno.ForeColor = System.Drawing.Color.White
        Me.btnPrazno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrazno.Location = New System.Drawing.Point(0, 729)
        Me.btnPrazno.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrazno.Name = "btnPrazno"
        Me.btnPrazno.Size = New System.Drawing.Size(255, 20)
        Me.btnPrazno.TabIndex = 184
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
        Me.PanelContext.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContext.Controls.Add(Me.PanelTop)
        Me.PanelContext.Controls.Add(Me.TableLayoutPanelTABLE)
        Me.PanelContext.Controls.Add(Me.btnLinijaRazmak)
        Me.PanelContext.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(255, 0)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(895, 749)
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
        Me.btnLinijaRazmak.TabIndex = 10000085
        Me.btnLinijaRazmak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinijaRazmak.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnArrowDownHover)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(2, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(893, 40)
        Me.PanelTop.TabIndex = 10000086
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
        Me.b3.Location = New System.Drawing.Point(18, 7)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(240, 27)
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
        Me.btnBack.Location = New System.Drawing.Point(13, 671)
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
        Me.Logovan.Location = New System.Drawing.Point(0, 711)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(255, 18)
        Me.Logovan.TabIndex = 10000088
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLogickaKontrola
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1150, 749)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormLogickaKontrola"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelTABLE.ResumeLayout(False)
        Me.TableLayoutPanelTABLE.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvGreske, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTabele, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
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
    Dim strGrid1 As String 'ByTables
    Dim strGrid2 As String 'ByErrors
    Dim strGrid3 As String 'Batch logical control (data checking) by chosen table Or chosen errors
    Dim strGrid4 As String 'ChooseValueForFilterByField
    Dim strGrid5 As String 'Batch logical control (data checking) For specific field values
    Dim strGrid6 As String 'AppCode
    Dim strGrid7 As String 'table
    Dim strGrid8 As String 'ErrorNumber
    Dim strGrid9 As String 'Error

    Dim strGrid10 As String 'Condition
    Dim strGrid11 As String 'ErrorTitle
    Dim strGrid12 As String 'Weigth
    Dim strGrid13 As String 'BLC
    Dim strGrid14 As String 'Field
    Dim strGrid15 As String 'Name
    Dim strGrid16 As String 'Value
    Dim strGrid17 As String 'Records
    Dim strGrid18 As String 'Incorrect (neispravnih)
    Dim strGrid19 As String 'Action
    Dim strGrid20 As String 'Errors in total (greske sumarno)
    Dim strGrid21 As String 'Tables
    Dim strGrid22 As String 'Errors
    Dim strGrid23 As String 'TableErrors
    Dim strGrid24 As String 'App

    Dim ml As LogickaKontrola
    Dim mls As LKizv
    Dim istLK As DatasetIstrazivanja.ISTLKDataTable
    Dim istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Dim tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim dFold As String
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim lokalno As Boolean
    Dim DBConnectionString As String

    Dim jezik As String
    Dim txtmode As String
    Dim txtInst As String
    Dim txtpismo As String

    Dim dISTTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Dim dsIST As DatasetIstrazivanja
    Dim drowIST As DatasetIstrazivanja.ISTRow
    Dim CAPIServer As String
    Dim CAPIBaza As String
    Dim mdtAWL As DataTable
    Dim mdtQE As DataTable
    Dim mdtLabel As DataTable
    Dim mdtMessage As DataTable

    Dim ISTConnectionString As String
    Dim allFromISTFields As DatasetIstrazivanja.ISTPOLJADataTable
    Dim pkISTFields As DatasetIstrazivanja.ISTPOLJADataTable
    Dim allFromISTLK As DatasetIstrazivanja.ISTLKDataTable


    Public Overloads Sub Dispose()
        Me.mls.Dispose()
        MyBase.Dispose()
    End Sub
    Dim panelmenucollapse As Boolean
    Dim zapamtilogovanog As String = ""
    Public Sub New(ByVal ds As DatasetIstrazivanja, ByVal DBConnectionString As String, ByVal nazivIstrazivanja As String,
    ByVal rowIST As DatasetIstrazivanja.ISTRow,
    ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow,
    ByVal ISTTabele As DatasetIstrazivanja.ISTTABELEDataTable,
    ByVal allFromISTFields As DatasetIstrazivanja.ISTPOLJADataTable,
    ByVal pkISTFields As DatasetIstrazivanja.ISTPOLJADataTable,
    ByVal allFromISTLK As DatasetIstrazivanja.ISTLKDataTable,
    ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
    ByVal txtInstalacije As String, ByVal txtPismo As String, ByVal fold As String,
    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
    ByVal txt_DSBrisanjeBaza As String, ByVal txtmode As String, ByVal jezik As String, ByVal ISTConnectionString As String,
    ByVal txt_CAPIServer As String, ByVal txt_CAPIBaza As String, ByVal mdtLabel As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable, ByVal mdtMessage As DataTable, ByVal panelmenucollapse As Boolean)
        Me.New()

        AddHandler dgvTabele.CellClick, AddressOf Me.dgvTabele_CellClick

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size

        Me.jezik = jezik
        Call SetLang()
        Me.panelmenucollapse = panelmenucollapse
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtLabel = mdtLabel
        Me.mdtMessage = mdtMessage
        Me.Logovan.Text = GetUserName.ToString.Trim
        Me.Text = Me.Text + " " + txtInstalacije + " - " + nazivIstrazivanja.Trim
        Me.UserControlVremenskaTacka1.Init(vt)
        ml = New LogickaKontrola(DBConnectionString, rowBaze, ISTTabele, allFromISTFields, pkISTFields, allFromISTLK, Me.ProgressBar1, Me.tbSql, Me.UserControlVremenskaTacka1, Me.jezik)
        mls = New LKizv(DBConnectionString, rowBaze, allFromISTLK, Nothing, Me.ProgressBar1, True, Me.UserControlVremenskaTacka1, Me.jezik, Me.dgvTabele, Me.dgvGreske)

        f_Resize(Nothing, Nothing)

        Me.jezik = jezik
        Me.txtmode = txtmode

        Me.allFromISTFields = allFromISTFields
        Me.pkISTFields = pkISTFields
        Me.allFromISTLK = allFromISTLK

        Me.istLK = ml.mtip
        Call napunidgvTabeledgvGeske()

        Me.istPolja = allFromISTFields
        Call napunidgvP()

        Me.dFold = fold
        Me.DBConnectionString = DBConnectionString

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        lokalno = False
        'NS je trazio da za njih se ne radi DEPO pri brisanju
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True
        Me.tacv = vt

        Dim sifist As String = istLK.Rows(0).Item(0).ToString.Trim()
        Me.b3.Text = sifist + "    " + String.Format("{0:d2}", Me.tacv.M) + " / " + Me.tacv.G.ToString

        btnBack.Location = New System.Drawing.Point(ButtonLKPOPoljima.Location.X + 3, Logovan.Location.Y - btnBack.Width - 10)
        zapamtilogovanog = Logovan.Text.Trim

        Call srediGridView(Me.dgvTabele, True, 50)
        Call srediGridView(Me.dgvGreske, False, 50)

        Call srediGridView(Me.dgvT, True, 50)
        Call srediGridView(Me.dgvG, False, 50)

        Call srediGridView(Me.dgvP, True, 50)

        Me.dgvT.ReadOnly = False
        Me.dgvG.ReadOnly = False
        Me.dgvP.ReadOnly = False
        Me.dgvTabele.ReadOnly = True
        Me.dgvGreske.ReadOnly = True

        Me.dsIST = ds
        Me.dISTTabele = ISTTabele
        Me.drowIST = rowIST
        Me.ISTConnectionString = ISTConnectionString
        Me.b1.Text = ""
        Me.b2.Text = ""
    End Sub

    Private Sub napunidgvTabeledgvGeske()
        Dim dtTabele As New System.Data.DataTable
        Dim dtGreske As New System.Data.DataTable
        dtTabele = napuniDGTabele()
        dtGreske = napuniDGGreske()
        Me.dgvT.DataSource = dtTabele
        Me.dgvG.DataSource = dtGreske
    End Sub

    Private Sub napunidgvP()
        Dim dtP As New System.Data.DataTable
        dtP = napuniDGPolja()
        Call imenaKolona5(dtP)
        dgvP.DataSource = dtP
    End Sub
    Private Function napuniDGPolja() As System.Data.DataTable

        Dim i As Integer = 0
        Dim dgDT As New System.Data.DataTable
        dgDT.Columns.Add("sifist", System.Type.GetType("System.String"))
        dgDT.Columns.Add("tabela", System.Type.GetType("System.String"))
        dgDT.Columns.Add("polje", System.Type.GetType("System.String"))
        dgDT.Columns.Add("naziv", System.Type.GetType("System.String"))
        dgDT.Columns.Add("LK", System.Type.GetType("System.Boolean"))
        dgDT.Columns.Add("vrednost", System.Type.GetType("System.String"))

        For i = 0 To istPolja.Rows.Count - 1
            If Not (istPolja.Rows(i).Item("izraz") Is System.DBNull.Value) AndAlso (istPolja.Rows(i).Item("izraz").trim.tolower.IndexOf("datavalidationfor") >= 0) Then
                Dim NR As System.Data.DataRow = dgDT.NewRow()
                NR("sifist") = Me.istPolja.Rows(i).Item("sifist").ToString.Trim
                NR("tabela") = Me.istPolja.Rows(i).Item("tabela").ToString.Trim
                NR("polje") = Me.istPolja.Rows(i).Item("polje").ToString.Trim
                NR("naziv") = NR("polje")
                NR("LK") = False
                NR("vrednost") = ""
                dgDT.Rows.Add(NR)
            Else
            End If
        Next

        For j As Integer = 0 To 3
            dgDT.Columns(j).ReadOnly = True
        Next

        dgDT.AcceptChanges()
        napuniDGPolja = dgDT.Copy

    End Function

    Private Function napuniDGTabele() As System.Data.DataTable
        Dim dgDT As New System.Data.DataTable

        dgDT.Columns.Add("sifist", System.Type.GetType("System.String"))
        dgDT.Columns.Add("tabela", System.Type.GetType("System.String"))
        dgDT.Columns.Add("LK", System.Type.GetType("System.Boolean"))

        Dim noviRed As System.Data.DataRow = dgDT.NewRow()
        Dim pTabela As String = ""

        If Me.istLK.Rows.Count > 0 Then
            noviRed("sifist") = Me.istLK.Rows(0).Item("sifist").ToString.Trim
            noviRed("tabela") = Me.istLK.Rows(0).Item("tabela").ToString.Trim
            noviRed("LK") = False
            dgDT.Rows.Add(noviRed)
            pTabela = Me.istLK.Rows(0).Item("tabela").ToString.Trim

            If Me.istLK.Rows.Count > 1 Then
                For i As Integer = 1 To Me.istLK.Rows.Count - 1
                    If Me.istLK.Rows(i).Item("tabela").ToString.Trim() <> pTabela Then
                        Dim NR As System.Data.DataRow = dgDT.NewRow()
                        NR("sifist") = Me.istLK.Rows(i).Item("sifist").ToString.Trim
                        NR("tabela") = Me.istLK.Rows(i).Item("tabela").ToString.Trim()
                        NR("LK") = False
                        dgDT.Rows.Add(NR)
                        pTabela = Me.istLK.Rows(i).Item("tabela").ToString.Trim()
                    Else
                        'nista, idi dalje
                    End If
                Next
            End If
        End If
        For j As Integer = 0 To 1
            dgDT.Columns(j).ReadOnly = True
        Next

        Call imenaKolona1(dgDT)

        dgDT.AcceptChanges()
        napuniDGTabele = dgDT.Copy
        Return napuniDGTabele

    End Function

    Private Function napuniDGGreske() As System.Data.DataTable
        Dim dgDT As New System.Data.DataTable
        Dim i As Integer = 0

        dgDT.Columns.Add("sifist", System.Type.GetType("System.String"))
        dgDT.Columns.Add("tabela", System.Type.GetType("System.String"))
        dgDT.Columns.Add("RbrGreske", System.Type.GetType("System.String"))
        dgDT.Columns.Add("GRESKA", System.Type.GetType("System.String"))
        dgDT.Columns.Add("USLOV", System.Type.GetType("System.String"))
        dgDT.Columns.Add("NazivGreske", System.Type.GetType("System.String"))
        dgDT.Columns.Add("tezina", System.Type.GetType("System.String"))

        For i = 0 To istLK.Rows.Count - 1
            If (istLK.Rows(i).Item("uslov") Is System.DBNull.Value) OrElse istLK.Rows(i).Item("uslov").ToString.Trim.ToUpper <> "LKUNOS" Then
                Dim NR As System.Data.DataRow = dgDT.NewRow()
                NR("sifist") = Me.istLK.Rows(i).Item("sifist").ToString.Trim
                NR("tabela") = Me.istLK.Rows(i).Item("tabela").ToString.Trim
                NR("RbrGreske") = Me.istLK.Rows(i).Item("RbrGreske").ToString.Trim
                NR("GRESKA") = Me.istLK.Rows(i).Item("GRESKA").ToString.Trim
                'NR("USLOV") = Me.istLK.Rows(i).Item("USLOV").ToString.Trim
                NR("NazivGreske") = Me.istLK.Rows(i).Item("NazivGreske").ToString.Trim
                NR("tezina") = Me.istLK.Rows(i).Item("tezina").ToString.Trim
                dgDT.Rows.Add(NR)
            Else
            End If
        Next

        Dim brKol As Integer = 0
        brKol = dgDT.Columns.Count

        For j As Integer = 0 To brKol - 1
            dgDT.Columns(j).ReadOnly = True
        Next

        Dim zdcc As System.Data.DataColumn = New System.Data.DataColumn("LK", System.Type.GetType("System.Boolean"))
        zdcc.DefaultValue = False
        dgDT.Columns.Add(zdcc)
        dgDT.Columns("LK").ReadOnly = False

        Call imenaKolona2(dgDT)

        dgDT.AcceptChanges()
        napuniDGGreske = dgDT.Copy
        Return napuniDGGreske

    End Function
    Private Sub dgvTabele_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)

        If e.RowIndex >= 0 Then
            dgvTabele.Rows(e.RowIndex).Selected = True
        End If

    End Sub
    Sub refreshdgvGreske(Optional ByVal eRowIndex As Integer = -1)
        Dim tabela As String = dgvTabele.Rows(eRowIndex).Cells(0).Value.ToString
        dgvGreske.DataSource.DefaultView.RowFilter = "[" + strGrid7 + "]" + " = '" + tabela + "'"
        dgvGreske.DataSource.DefaultView.Sort = "[" + strGrid8 + "]" + " asc"
    End Sub
    Private Sub SetLang()
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "LogickaKontrola")

        Dim bspace As String = "     "
        ButtonIzvestaj1.Text = bspace + getControlText2(dt, "ButtonIzvestaj", Me.jezik)
        ButtonIzvestaj1.Tag = ButtonIzvestaj1.Text
        ButtonLK1.Text = bspace + getControlText2(dt, "ButtonLK", Me.jezik)
        ButtonLK1.Tag = ButtonLK1.Text
        ButtonLKPOTabelama.Text = bspace + getControlText2(dt, "ButtonLKPOTabelama", Me.jezik)
        ButtonLKPOTabelama.Tag = ButtonLKPOTabelama.Text
        ButtonLKPOPoljima.Text = bspace + getControlText2(dt, "ButtonLKPOPoljima", Me.jezik)
        ButtonLKPOPoljima.Tag = ButtonLKPOPoljima.Text
        cmdSaveIZV1.Text = bspace + getControlText2(dt, "cmdSaveIZV", Me.jezik)
        cmdSaveIZV1.Tag = cmdSaveIZV1.Text
        cmdOpenIzv1.Text = bspace + getControlText2(dt, "cmdOpenIzv", Me.jezik)
        cmdOpenIzv1.Tag = cmdOpenIzv1.Text
        BtnEx1.Text = bspace + "Excel"
        BtnEx1.Tag = BtnEx1.Text

        '****GRIDOVI
        Me.strGrid1 = getControlText2(dt, "dgGrid1", Me.jezik)
        Me.strGrid2 = getControlText2(dt, "dgGrid2", Me.jezik)
        Me.strGrid3 = getControlText2(dt, "dgGrid3", Me.jezik)
        Me.strGrid4 = getControlText2(dt, "dgGrid4", Me.jezik)
        Me.strGrid5 = getControlText2(dt, "dgGrid5", Me.jezik)
        Me.strGrid6 = getControlText2(dt, "dgGrid6", Me.jezik)
        Me.strGrid7 = getControlText2(dt, "dgGrid7", Me.jezik)
        Me.strGrid8 = getControlText2(dt, "dgGrid8", Me.jezik)
        Me.strGrid9 = getControlText2(dt, "dgGrid9", Me.jezik)
        Me.strGrid10 = getControlText2(dt, "dgGrid10", Me.jezik)
        Me.strGrid11 = getControlText2(dt, "dgGrid11", Me.jezik)
        Me.strGrid12 = getControlText2(dt, "dgGrid12", Me.jezik)
        Me.strGrid13 = getControlText2(dt, "dgGrid13", Me.jezik)
        Me.strGrid14 = getControlText2(dt, "dgGrid14", Me.jezik)
        Me.strGrid15 = getControlText2(dt, "dgGrid15", Me.jezik)
        Me.strGrid16 = getControlText2(dt, "dgGrid16", Me.jezik)
        Me.strGrid17 = getControlText2(dt, "dgGrid17", Me.jezik)
        Me.strGrid18 = getControlText2(dt, "dgGrid18", Me.jezik)
        Me.strGrid19 = getControlText2(dt, "dgGrid19", Me.jezik)
        Me.strGrid20 = getControlText2(dt, "dgGrid20", Me.jezik)
        Me.strGrid21 = getControlText2(dt, "dgGrid21", Me.jezik)
        Me.strGrid22 = getControlText2(dt, "dgGrid22", Me.jezik)
        Me.strGrid23 = getControlText2(dt, "dgGrid23", Me.jezik)
        Me.strGrid24 = getControlText2(dt, "dgGrid24", Me.jezik)


    End Sub

    Private Sub ButtonUradi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUradi.Click
        ''LK ODJEDNOM
        Me.tbSql.Visible = False
        Me.Cursor = Cursors.WaitCursor
        ml.LK("", "")
        ''msg 139
        Dim msgtxt As String = getMessageText(dtMessages, "139", Me.jezik)
        ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call buttonIzvestajClick()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub UpisiISTLogLK(ByVal proces As String)
        ''NOVO*****
        ''UPISUJEM LogLK U DEPO, tj PUNIM DEPO.dbo.ISTLogLK
        Dim dss As New System.Data.DataSet
        Dim dtt As New System.Data.DataTable

        dtt = DirectCast(dgvGreske.DataSource, System.Data.DataTable).DataSet.Tables(1)

        Dim god As String = Me.tacv.G.ToString
        Dim mes As String = String.Format("{0:d2}", Me.tacv.M)
        Dim sifist As String = istLK.Rows(0).Item(0).ToString.Trim()
        Dim sqlLogLK As String = ""
        If lokalno = False AndAlso dtt.Rows.Count > 0 Then
            'sklopi sqlLogLK
            For i As Integer = 0 To dtt.Rows.Count - 1
                Dim tabela As String = dtt.Rows(i).Item(strGrid7).ToString.Trim()
                Dim rbrGreske As String = dtt.Rows(i).Item(strGrid8).ToString.Trim()
                Dim Slogova As Integer = CInt(dtt.Rows(i).Item(strGrid17).ToString.Trim())
                Dim Greska As String = dtt.Rows(i).Item(strGrid9).ToString.Trim().Replace("'", "''").Replace("\", "\\")
                Dim nazivGreske As String = dtt.Rows(i).Item(strGrid11).ToString.Trim().Replace("'", "''").Replace("\", "\\")
                Dim Akcija As String = dtt.Rows(i).Item(strGrid19).ToString.Trim().Replace("'", "''").Replace("\", "\\")

                sqlLogLK = sqlLogLK + "insert into ISTLogLK" _
                    & "(SifIst,god,mes,TABELA,rbrGreske,Slogova,Greska,nazivGreske,Akcija,ko_insert,datum_insert) " _
                    & " values( " _
                    & "N'" & sifist & "','" & god & "','" & mes & "'," _
                    & "N'" & tabela & "',N'" & rbrGreske & "'," _
                    & Slogova & "," _
                    & "N'" & Greska & "',N'" & nazivGreske & "',N'" & Akcija & "'," _
                    & "N'" & GetUserName.ToString.Trim & "'," _
                    & "" & "(select top 1 GETDATE())" & ");" + nvrd
            Next
        End If
        If sqlLogLK <> "" Then
            'upis u DEPO.dbo.ISTLogLK
            Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)
            Dim ok1 As String = izvrsiSQL(sqlLogLK, konDepo)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sqlLogLK + nvrd + nvrd + "is not executed! ER92", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            'upis u DEPO.dbo.ISTLogKoriscenjaProcesa
            Dim upit As String = "insert into ISTLogKoriscenjaProcesa" _
              & "(SifIst,god,mes,proces,izvestaj,ko_insert,datum_insert) " _
              & " values( " _
              & "N'" & sifist & "','" & god & "','" & mes & "'," _
              & "N'" & proces & "','" + "iz frmLK" & "'," _
              & "N'" & GetUserName.ToString.Trim & "'," _
              & "" & "(select top 1 GETDATE())" & ");" + nvrd
            ok1 = izvrsiSQL(upit, konDepo)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(upit + nvrd + nvrd + "is not executed! ER93", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        ''NOVO*****
        ''UPISUJEM LogLK U DEPO
    End Sub


    Sub seeFirst()
        Me.TableLayoutPanel1.RowStyles(1).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(1).Height = 95
        Me.TableLayoutPanel1.RowStyles(2).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(2).Height = 0
        Me.TableLayoutPanelTABLE.RowStyles(0).SizeType = SizeType.Percent
        Me.TableLayoutPanelTABLE.RowStyles(0).Height = 85
        Me.TableLayoutPanelTABLE.RowStyles(1).SizeType = SizeType.Percent
        Me.TableLayoutPanelTABLE.RowStyles(1).Height = 15
        Me.dgvTabele.Visible = True
        Me.dgvGreske.Visible = True
        Me.dgvT.Visible = False
        Me.dgvG.Visible = False
        Me.dgvP.Visible = False
        Me.tbSql.Visible = True
        Me.ButtonLKPOTabelamaUradi.Visible = False
        Me.ButtonLKPOPoljimaUradi.Visible = False
    End Sub
    Sub seeSecond()
        Me.TableLayoutPanel1.RowStyles(1).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(1).Height = 0
        Me.TableLayoutPanel1.RowStyles(2).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(2).Height = 100
        Me.TableLayoutPanelTABLE.RowStyles(0).SizeType = SizeType.Percent
        Me.TableLayoutPanelTABLE.RowStyles(0).Height = 100
        Me.TableLayoutPanelTABLE.RowStyles(1).SizeType = SizeType.Percent
        Me.TableLayoutPanelTABLE.RowStyles(1).Height = 0
        Me.dgvTabele.Visible = False
        Me.dgvGreske.Visible = False
        Me.dgvT.Visible = True
        Me.dgvG.Visible = True
        Me.dgvP.Visible = False
        Me.tbSql.Visible = True
        Me.ButtonLKPOTabelamaUradi.Visible = True
        Me.ButtonLKPOPoljimaUradi.Visible = False
    End Sub
    Sub seeThird()
        Me.TableLayoutPanel1.RowStyles(1).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(1).Height = 0
        Me.TableLayoutPanel1.RowStyles(2).SizeType = SizeType.Percent
        Me.TableLayoutPanel1.RowStyles(2).Height = 0

        Me.TableLayoutPanelTABLE.RowStyles(0).SizeType = SizeType.Percent
        Me.TableLayoutPanelTABLE.RowStyles(0).Height = 5
        Me.TableLayoutPanelTABLE.RowStyles(1).SizeType = SizeType.Percent
        Me.TableLayoutPanelTABLE.RowStyles(1).Height = 95
        b1.Text = "" : b2.Text = ""
        Me.dgvTabele.Visible = False
        Me.dgvGreske.Visible = False
        Me.dgvT.Visible = False
        Me.dgvG.Visible = False
        Me.dgvP.Visible = True
        Me.tbSql.Visible = False
        Me.ButtonLKPOTabelamaUradi.Visible = False
        Me.ButtonLKPOPoljimaUradi.Visible = True
    End Sub
    Sub imenaKolona1(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("sifist") Is Nothing Then dgDT.Columns("sifist").ColumnName = strGrid6
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = strGrid7
        If Not dgDT.Columns("LK") Is Nothing Then dgDT.Columns("LK").ColumnName = strGrid13
    End Sub

    Sub imenaKolona2(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("sifist") Is Nothing Then dgDT.Columns("sifist").ColumnName = strGrid6
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = strGrid7
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = strGrid8
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = strGrid9
        If Not dgDT.Columns("USLOV") Is Nothing Then dgDT.Columns("USLOV").ColumnName = strGrid10
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = strGrid11
        If Not dgDT.Columns("tezina") Is Nothing Then dgDT.Columns("tezina").ColumnName = strGrid12
        If Not dgDT.Columns("LK") Is Nothing Then dgDT.Columns("LK").ColumnName = strGrid13
    End Sub

    Sub imenaKolona3(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("naziv") Is Nothing Then dgDT.Columns("naziv").ColumnName = strGrid15
        If Not dgDT.Columns("slogova") Is Nothing Then dgDT.Columns("slogova").ColumnName = strGrid17
        If Not dgDT.Columns("neispravnih") Is Nothing Then dgDT.Columns("neispravnih").ColumnName = strGrid18
    End Sub

    Sub imenaKolona4(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = strGrid7
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = strGrid8
        If Not dgDT.Columns("Slogova") Is Nothing Then dgDT.Columns("Slogova").ColumnName = strGrid17
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = strGrid9
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = strGrid11
        If Not dgDT.Columns("akcija") Is Nothing Then dgDT.Columns("akcija").ColumnName = strGrid19
    End Sub

    Sub imenaKolona5(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("sifist") Is Nothing Then dgDT.Columns("sifist").ColumnName = strGrid6
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = strGrid7
        If Not dgDT.Columns("LK") Is Nothing Then dgDT.Columns("LK").ColumnName = strGrid13
        If Not dgDT.Columns("polje") Is Nothing Then dgDT.Columns("polje").ColumnName = strGrid14
        If Not dgDT.Columns("naziv") Is Nothing Then dgDT.Columns("naziv").ColumnName = strGrid15
        If Not dgDT.Columns("vrednost") Is Nothing Then dgDT.Columns("vrednost").ColumnName = strGrid16
    End Sub


    Private Sub ButtonLKPOTabelamaUradi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLKPOTabelamaUradi.Click
        Dim red As System.Data.DataRow
        Dim dtt As New System.Data.DataTable
        Dim p As Boolean = False

        dtt = dgvT.DataSource
        For Each red In dtt.Rows
            Try
                'strGrid13 LK
                If Not red.Item(strGrid13) Is System.DBNull.Value AndAlso CType(CType(red.Item(strGrid13), Object), Boolean) = True Then
                    'strGrid7 TABELA
                    ml.LK("", red.Item(strGrid7).ToString(), True)
                    p = True
                End If
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next

        If p = True Then
            'msg 144
            Dim msgtxt144 As String = getMessageText(dtMessages, "144", Me.jezik) + nvrd
            ISTMessageBox.Show(msgtxt144, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'poništi
            For i As Integer = 0 To dgvT.Rows.Count - 1
                dgvT(2, i).Value = False

            Next
        End If

        'prebacujem samo one koje su oznacene da se urade
        Dim mdtt As New DatasetIstrazivanja.ISTLKDataTable
        dtt = dgvG.DataSource
        For Each red In dtt.Rows
            Try
                'strGrid13 LK
                If Not red.Item(strGrid13) Is System.DBNull.Value AndAlso CType(CType(red.Item(strGrid13), Object), Boolean) = True Then
                    Dim R As DataRow = mdtt.NewRow
                    R("sifist") = red.Item(strGrid24).ToString.Trim
                    R("TABELA") = red.Item(strGrid7).ToString.Trim
                    R("RbrGreske") = red.Item(strGrid8).ToString.Trim
                    R("GRESKA") = red.Item(strGrid9).ToString.Trim
                    R("USLOV") = red.Item(strGrid10).ToString.Trim
                    R("tezina") = red.Item(strGrid12).ToString.Trim
                    mdtt.Rows.Add(R)
                End If
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
        If mdtt.Rows.Count > 0 Then
            ml.LKIzabrane(mdtt, "", "", True)
            'msg 145
            Dim msgtxt145 As String = getMessageText(dtMessages, "145", Me.jezik) + nvrd
            ISTMessageBox.Show(msgtxt145, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'poništi
            For i As Integer = 0 To dgvG.Rows.Count - 1
                dgvG(7, i).Value = False
            Next
        End If

        Call buttonIzvestajClick()

        'msg 146
        Dim msgtxt146 As String = getMessageText(dtMessages, "146", Me.jezik) + nvrd
        Call UpisiISTLogLK(msgtxt146)

    End Sub

    Private Sub ButtonLKPOPoljimaUradi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLKPOPoljimaUradi.Click

        Dim dtt As New System.Data.DataTable
        dtt = dgvP.DataSource.Copy
        If dtt.Rows.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor
            For Each Red As System.Data.DataRow In dtt.Rows
                Try
                    If Not Red.Item(strGrid13) Is System.DBNull.Value AndAlso CType(CType(Red.Item(strGrid13), Object), Boolean) = True Then
                        ml.LKFilter("", Red.Item(strGrid7).ToString.Trim(), Red.Item(strGrid14).ToString.Trim(), Red.Item(strGrid16).ToString.Trim())
                    End If
                Catch ex As System.Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            Next
            ''msg 147
            Dim msgtxt147 As String = getMessageText(dtMessages, "147", Me.jezik)
            ISTMessageBox.Show(msgtxt147, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'poništi
            For i As Integer = 0 To dgvP.Rows.Count - 1
                dgvP(4, i).Value = False
                dgvP(5, i).Value = ""
            Next

            Call buttonIzvestajClick()

            ''msg 148
            Dim msgtxt148 As String = getMessageText(dtMessages, "148", Me.jezik)
            Call UpisiISTLogLK(msgtxt148)

            Me.ButtonLKPOPoljimaUradi.Visible = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub FormLK1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call PreVentFlicker()
        Call seeFirst()

        If Me.panelmenucollapse = True Then
            Call CollapseMenu()
        End If

        ButtonLK1.Focus()

        Call SettingObjForTheme(GetTheme())
        nonvisiblePanelTOP()
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

    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelMenu
        ReDim Preserve nizButtonOboji(2)
        nizButtonOboji(2) = PanelTop
        ReDim Preserve nizButtonOboji(3)

        zapamtibojuteme = setTheme(nizButtonOboji, Nothing, theme)

    End Sub
    Dim zapamtibojuteme As Color = Nothing
    Private Sub f_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize

    End Sub

    Private Sub dgvGreske_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvGreske.RowHeaderMouseDoubleClick

        If dgvGreske.SelectedRows.Count <= 0 Then Exit Sub
        dgvGreske.Rows(e.RowIndex).Selected = True
        Dim table As String = dgvGreske.Rows(e.RowIndex).Cells(dgvGreske.Columns(strGrid7).Index).Value.ToString
        Dim errnumber As String = dgvGreske.Rows(e.RowIndex).Cells(dgvGreske.Columns(strGrid8).Index).Value.ToString

        Me.Cursor = Cursors.WaitCursor


        Dim frm As New IstrazivanjaUnos.FormAzuriraj("LK", dsIST, mdtLabel, mdtAWL, mdtQE, mdtMessage, tacv, DBConnectionString, dsIST.ISTTABELE, dsIST.ISTPOLJA,
                                            pkISTFields, dsIST.ISTLK, Me.drowIST, Me.dFold,
                                            Me.txtInst, Me.txtpismo, txtmode, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.jezik, Me.ISTConnectionString,
                                            CAPIServer, CAPIBaza, errnumber, panelmenucollapse, Nothing, table, Logovan.Text)


        frm.ShowDialog()
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub dgvTabele_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTabele.RowHeaderMouseDoubleClick
        If dgvTabele.SelectedRows.Count <= 0 Then Exit Sub
        dgvTabele.Rows(e.RowIndex).Selected = True
        Dim table As String = dgvTabele.Rows(e.RowIndex).Cells(dgvTabele.Columns(strGrid15).Index).Value.ToString
        'Dim errnumber As String = dgvGreske.Rows(e.RowIndex).Cells(dgvGreske.Columns(strGrid8).Index).Value.ToString

        Me.Cursor = Cursors.WaitCursor
        Dim frm As New IstrazivanjaUnos.FormAzuriraj("LK", dsIST, mdtLabel, mdtAWL, mdtQE, mdtMessage, tacv, DBConnectionString, dsIST.ISTTABELE, dsIST.ISTPOLJA,
                                            pkISTFields, dsIST.ISTLK, Me.drowIST, Me.dFold,
                                            Me.txtInst, Me.txtpismo, txtmode, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.jezik, Me.ISTConnectionString,
                                            CAPIServer, CAPIBaza, "", panelmenucollapse, Nothing, table, Logovan.Text)


        frm.ShowDialog()

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub ExportToExcelDGVS(ByVal dss() As System.Data.DataSet, ByVal fajl As String, ByVal cuvaj As Boolean)
        Dim ppdatestart As Date = Date.Now
        Dim brSH As Integer = UBound(dss)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a2 As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim dt As System.Data.DataTable
        Dim finalRow As Integer = 2
        Dim col, row As Integer
        Try
            wb = a2.Workbooks.Add
            ws = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            For i As Integer = 0 To brSH
                'pisi ds
                For Each dt In dss(i).Tables
                    Dim rawData(dt.Rows.Count, dt.Columns.Count - 1) As Object
                    For col = 0 To dt.Columns.Count - 1
                        rawData(0, col) = dt.Columns(col).ColumnName
                    Next
                    For col = 0 To dt.Columns.Count - 1
                        For row = 0 To dt.Rows.Count - 1
                            rawData(row + 1, col) = dt.Rows(row).ItemArray(col)
                        Next
                    Next
                    Dim finalColLetter As String = String.Empty
                    Dim colCharset As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                    Dim colCharsetLen As Integer = colCharset.Length

                    If dt.Columns.Count > colCharsetLen Then
                        finalColLetter = colCharset.Substring((dt.Columns.Count - 1) \ colCharsetLen - 1, 1)
                    End If
                    finalColLetter = finalColLetter + colCharset.Substring((dt.Columns.Count - 1) Mod colCharsetLen, 1)

                    Dim brojredova As Integer
                    If dt.Rows.Count > 0 Then
                        brojredova = finalRow + dt.Rows.Count - 1
                    Else
                        brojredova = finalRow
                    End If

                    Dim excelRange As String = String.Format("A1" & ":{0}{1}", finalColLetter, brojredova)
                    ws.Range(excelRange).Value2 = rawData
                    finalRow = finalRow + dt.Rows.Count + 1
                    rawData = Nothing
                Next
                If dss(i).Namespace.Trim <> "" Then ws.Name = dss(i).Namespace.Trim.Replace("'", "")
                If i <> brSH Then ws = wb.Sheets.Add(After:=wb.Worksheets(i + 1))

                finalRow = 2
            Next

            If cuvaj = False Then a2.Visible = True

            If cuvaj = True Then
                wb.SaveAs(fajl)
                If Not wb Is Nothing Then
                    Try
                        wb.Close(False)
                    Catch
                    End Try
                End If
                a2.Quit()
            End If

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI


        Catch ex As System.Runtime.InteropServices.ExternalException
            If ex.ErrorCode <> -2146788248 Then
                Throw ex
            End If
        Finally
            If cuvaj = True Then

                If Not ws Is Nothing Then Marshal.ReleaseComObject(ws)
                Marshal.ReleaseComObject(wb)
                Marshal.ReleaseComObject(a2)
                GC.Collect()
                GC.WaitForPendingFinalizers()

                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
                End_Excel_App(ppdatestart, Date.Now)
            End If
        End Try
    End Sub


    Public Sub program(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
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
        Catch e As System.Exception
            ISTMessageBox.Show(e.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Sub buttonIzvestajClick()
        Call seeFirst()
        Me.Cursor = Cursors.WaitCursor

        mls.LK2("", "")

        Dim dtTabele As New System.Data.DataTable
        Dim dtGreske As New System.Data.DataTable

        dtTabele = dgvTabele.DataSource
        dtGreske = dgvGreske.DataSource

        Me.b1.Text = strGrid21 + "  " + dtTabele.Rows.Count.ToString.Trim
        Me.b2.Text = strGrid22 + "  " + dgvGreske.DataSource.DefaultView.Count.ToString.Trim

        'tabele tables(0)
        Call imenaKolona3(dtTabele)
        'greske tables(1)
        Call imenaKolona4(dtGreske)

        dtTabele.TableName = "[" + strGrid21 + "]"
        dtGreske.TableName = "[" + strGrid22 + "]"

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub dgvTabele_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTabele.SelectionChanged

        Me.Cursor = Cursors.WaitCursor

        If dgvTabele.SelectedRows.Count > 0 Then
            Dim eRowIndex As Integer = dgvTabele.SelectedRows(0).Index

            If eRowIndex >= 0 Then
                Call refreshdgvGreske(eRowIndex)
                Me.b2.Text = strGrid22 + "  " + dgvGreske.DataSource.DefaultView.Count.ToString.Trim
                If dgvGreske.Rows.Count > 0 Then
                    dgvGreske.Focus()
                    dgvGreske.ClearSelection()
                    dgvGreske.Rows(0).Selected = True
                End If
            End If
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonLK1_Click(sender As Object, e As EventArgs) Handles ButtonLK1.Click

        'OVO JE KONTROLA REDOM GREŠKA PO GREŠKA
        Call seeFirst()
        Me.b1.Text = strGrid21
        Me.b2.Text = strGrid22

        Me.ButtonLKPOTabelamaUradi.Visible = False
        Me.ButtonLKPOPoljimaUradi.Visible = False
        Me.Cursor = Cursors.WaitCursor
        ml.LK("", "", True)
        ''msg 139
        Dim msgtxt139 As String = getMessageText(dtMessages, "139", Me.jezik)
        ISTMessageBox.Show(msgtxt139, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call buttonIzvestajClick()
        ''msg 140
        Dim msgtxt140 As String = getMessageText(dtMessages, "140", Me.jezik)
        Call UpisiISTLogLK(msgtxt140)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonIzvestaj1_Click(sender As Object, e As EventArgs) Handles ButtonIzvestaj1.Click

        Call seeFirst()
        Me.Cursor = Cursors.WaitCursor

        mls.LK2("", "")

        Dim dtTabele As New System.Data.DataTable
        Dim dtGreske As New System.Data.DataTable

        dtTabele = dgvTabele.DataSource
        dtGreske = dgvGreske.DataSource

        Me.b1.Text = strGrid21 + "  " + dtTabele.Rows.Count.ToString.Trim
        Me.b2.Text = strGrid22 + "  " + dgvGreske.DataSource.DefaultView.Count.ToString.Trim

        'tabele tables(0)
        Call imenaKolona3(dtTabele)
        'greske tables(1)
        Call imenaKolona4(dtGreske)

        dtTabele.TableName = "[" + strGrid21 + "]"
        dtGreske.TableName = "[" + strGrid22 + "]"

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdSaveIZV1_Click(sender As Object, e As EventArgs) Handles cmdSaveIZV1.Click

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dd As String = String.Format("{0:yyyyMMdd_HHmmss}", System.DateTime.Now)
        Dim folder As String = dFold + "\LK"
        If Not Directory.Exists(folder) Then
            Directory.CreateDirectory(folder)
        End If

        Dim fajl As String = dFold + "\LK" + "\LK_" + Me.mls.s.Trim + "_" + dd + ".xlsx"
        Call seeFirst()
        Me.Cursor = Cursors.WaitCursor
        If dgvTabele.Rows.Count <= 0 AndAlso dgvTabele.Rows.Count <= 0 Then
            ''msg 149
            Dim msgtxt149 As String = getMessageText(dtMessages, "149", Me.jezik)
            ISTMessageBox.Show(msgtxt149, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Cursor = Cursors.WaitCursor

            Dim dsNew(1) As DataSet

            Dim dssT As New DataSet
            Dim dtt As DataTable = dgvTabele.DataSource
            Dim dttn As DataTable = dtt.Copy
            'dttn.TableName = strGrid21
            dssT.Tables.Add(dttn)

            Dim dssG As New DataSet
            Dim dv As DataView = DirectCast(dgvGreske.DataSource, System.Data.DataTable).DefaultView
            Dim dtg As DataTable = dv.ToTable
            Dim dtgn As DataTable = dtg.Copy
            'dtgn.TableName = strGrid22
            dssG.Tables.Add(dtgn)

            dsNew(0) = dssT
            dsNew(0).Namespace = strGrid21
            dsNew(1) = dssG
            dsNew(1).Namespace = strGrid22

            ExportToExcelDGVS(dsNew, fajl, True)

            Me.Cursor = Cursors.Default
            Dim msgtxt150 As String = getMessageText(dtMessages, "150", Me.jezik)
            ISTMessageBox.Show(msgtxt150 + nvrd + fajl, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdOpenIzv1_Click(sender As Object, e As EventArgs) Handles cmdOpenIzv1.Click

        Call seeFirst()
        Me.Cursor = Cursors.WaitCursor
        Dim d As System.Windows.Forms.OpenFileDialog
        d = New System.Windows.Forms.OpenFileDialog
        ''msg 151
        Dim msgtxt As String = getMessageText(dtMessages, "151", Me.jezik)
        d.Title = msgtxt
        d.InitialDirectory = dFold + "\LK"
        d.Filter = "(*.*) |*.*"
        If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                program(d.FileName, True, "", "")
            Catch Ex As System.Exception
                ISTMessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            End Try
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnEx1_Click(sender As Object, e As EventArgs) Handles BtnEx1.Click

        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim dd As String = String.Format("{0:yyyyMMdd_HHmmss}", System.DateTime.Now)
        Dim fajl As String = dFold + "\LK" + "\LK_" + Me.mls.s.Trim + "_" + dd + ".xls"


        If dgvTabele.Rows.Count > 0 OrElse dgvTabele.Rows.Count > 0 Then
            Me.Cursor = Cursors.WaitCursor

            Dim dsNew(1) As DataSet

            Dim dssT As New DataSet
            Dim dtt As DataTable = dgvTabele.DataSource
            Dim dttn As DataTable = dtt.Copy
            'dttn.TableName = strGrid21
            dssT.Tables.Add(dttn)

            Dim dssG As New DataSet
            Dim dv As DataView = DirectCast(dgvGreske.DataSource, System.Data.DataTable).DefaultView
            Dim dtg As DataTable = dv.ToTable
            Dim dtgn As DataTable = dtg.Copy
            'dtgn.TableName = strGrid22
            dssG.Tables.Add(dtgn)

            dsNew(0) = dssT
            dsNew(0).Namespace = strGrid21
            dsNew(1) = dssG
            dsNew(1).Namespace = strGrid22

            ExportToExcelDGVS(dsNew, fajl, False)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ButtonLKPOTabelama_Click(sender As Object, e As EventArgs) Handles ButtonLKPOTabelama.Click

        Call seeSecond()
    End Sub

    Private Sub ButtonLKPOPoljima_Click(sender As Object, e As EventArgs) Handles ButtonLKPOPoljima.Click

        Call seeThird()
    End Sub

    Private Sub ButtonIzlaz1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        CollapseMenu()
    End Sub
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
            ToolTip1.SetToolTip(ButtonIzvestaj1, ButtonIzvestaj1.Tag)
            ToolTip1.SetToolTip(ButtonLK1, ButtonLK1.Tag)
            ToolTip1.SetToolTip(ButtonLKPOTabelama, ButtonLKPOTabelama.Tag)
            ToolTip1.SetToolTip(ButtonLKPOPoljima, ButtonLKPOPoljima.Tag)
            ToolTip1.SetToolTip(cmdSaveIZV1, cmdSaveIZV1.Tag)
            ToolTip1.SetToolTip(cmdOpenIzv1, cmdOpenIzv1.Tag)
            ToolTip1.SetToolTip(BtnEx1, BtnEx1.Tag)
        Else
            ToolTip1.SetToolTip(ButtonIzvestaj1, "")
            ToolTip1.SetToolTip(ButtonLK1, "")
            ToolTip1.SetToolTip(ButtonLKPOTabelama, "")
            ToolTip1.SetToolTip(ButtonLKPOPoljima, "")
            ToolTip1.SetToolTip(cmdSaveIZV1, "")
            ToolTip1.SetToolTip(cmdOpenIzv1, "")
            ToolTip1.SetToolTip(BtnEx1, "")
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

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.btnCerrar.PerformClick()
    End Sub

    Private Sub ButtonLK1_MouseDown(sender As Object, e As MouseEventArgs) Handles cmdSaveIZV1.MouseDown, cmdOpenIzv1.MouseDown, ButtonLKPOTabelama.MouseDown, ButtonLKPOPoljima.MouseDown, ButtonLK1.MouseDown, ButtonIzvestaj1.MouseDown, BtnEx1.MouseDown
        ActivateButton(sender, ActivateButtonColor)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://istportal.net")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
    End Sub


    Sub visiblePanelTOP()
        btnArrowDownHover.Visible = False
        b3.Visible = True
        PanelTop.BackColor = zapamtibojuteme
        btnCerrar.Visible = True
        btnMinimizar.Visible = True
    End Sub

    Sub nonvisiblePanelTOP()
        btnCerrar.Visible = False
        btnMinimizar.Visible = False
        b3.Visible = False
        PanelTop.BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
        btnArrowDownHover.Visible = True
    End Sub

    Private Sub PanelTop_MouseLeave(sender As Object, e As EventArgs) Handles PanelTop.MouseLeave, btnMinimizar.MouseLeave, btnCerrar.MouseLeave, b3.MouseLeave
        If MouseIsOverButton(b3) OrElse MouseIsOverButton(btnCerrar) OrElse MouseIsOverButton(btnMinimizar) OrElse MouseIsOverPanel(PanelTop) Then
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
        System.Windows.Forms.Application.Exit()
    End Sub

    'Dim strGrid1 As String 'ByTables
    'Dim strGrid2 As String 'ByErrors
    'Dim strGrid3 As String 'Batch logical control (data checking) by chosen table Or chosen errors
    'Dim strGrid4 As String 'ChooseValueForFilterByField
    'Dim strGrid5 As String 'Batch logical control (data checking) For specific field values
    'Dim strGrid6 As String 'AppCode
    'Dim strGrid7 As String 'table
    'Dim strGrid8 As String 'ErrorNumber
    'Dim strGrid9 As String 'Error

    'Dim strGrid10 As String 'Condition
    'Dim strGrid11 As String 'ErrorTitle
    'Dim strGrid12 As String 'Weigth
    'Dim strGrid13 As String 'BLC
    'Dim strGrid14 As String 'Field
    'Dim strGrid15 As String 'Name
    'Dim strGrid16 As String 'Value
    'Dim strGrid17 As String 'Records
    'Dim strGrid18 As String 'Incorrect (neispravnih)
    'Dim strGrid19 As String 'Action
    'Dim strGrid20 As String 'Errors in total (greske sumarno)
    'Dim strGrid21 As String 'Tables
    'Dim strGrid22 As String 'Errors
    'Dim strGrid23 As String 'TableErrors
    'Dim strGrid24 As String 'App


End Class