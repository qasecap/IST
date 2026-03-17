Option Strict Off
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text
Imports Microsoft.Office.Interop

Public Class FormAK
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
    Friend WithEvents tbSql As System.Windows.Forms.TextBox

    Friend WithEvents TableLayoutPanelTABLE As TableLayoutPanel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents dgvGreske As DataGridView
    Friend WithEvents dgvTabele As DataGridView
    Friend WithEvents b2 As Button
    Friend WithEvents UserControlVremenskaTacka1 As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ButtonAKLK1 As Button
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents ButtonAK1 As Button
    Friend WithEvents ButtonAKuzLK1 As Button
    Friend WithEvents ButtonAKIzvestaj As Button
    Friend WithEvents PanelContext As Panel
    Friend WithEvents b1 As Button
    Friend WithEvents btnPrazno As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents logovan As Label
    Friend WithEvents btnLinijaRazmak As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnArrowDownHover As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents ToolTip1 As ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAK))
        Me.tbSql = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelTABLE = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.b2 = New System.Windows.Forms.Button()
        Me.dgvGreske = New System.Windows.Forms.DataGridView()
        Me.b1 = New System.Windows.Forms.Button()
        Me.dgvTabele = New System.Windows.Forms.DataGridView()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ButtonAKLK1 = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.ButtonAK1 = New System.Windows.Forms.Button()
        Me.ButtonAKuzLK1 = New System.Windows.Forms.Button()
        Me.ButtonAKIzvestaj = New System.Windows.Forms.Button()
        Me.btnPrazno = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.UserControlVremenskaTacka1 = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.logovan = New System.Windows.Forms.Label()
        Me.btnLinijaRazmak = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnArrowDownHover = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanelTABLE.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgvGreske, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTabele, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tbSql.Location = New System.Drawing.Point(3, 564)
        Me.tbSql.Multiline = True
        Me.tbSql.Name = "tbSql"
        Me.tbSql.Size = New System.Drawing.Size(887, 93)
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
        Me.TableLayoutPanelTABLE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelTABLE.Location = New System.Drawing.Point(2, 40)
        Me.TableLayoutPanelTABLE.Name = "TableLayoutPanelTABLE"
        Me.TableLayoutPanelTABLE.RowCount = 3
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelTABLE.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanelTABLE.Size = New System.Drawing.Size(893, 709)
        Me.TableLayoutPanelTABLE.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.b2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvGreske, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.b1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgvTabele, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(887, 555)
        Me.TableLayoutPanel1.TabIndex = 179
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.b2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.b2.FlatAppearance.BorderSize = 0
        Me.b2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.ForeColor = System.Drawing.Color.Black
        Me.b2.Location = New System.Drawing.Point(224, 3)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(660, 21)
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
        Me.dgvGreske.Location = New System.Drawing.Point(222, 28)
        Me.dgvGreske.Margin = New System.Windows.Forms.Padding(1)
        Me.dgvGreske.Name = "dgvGreske"
        Me.dgvGreske.Size = New System.Drawing.Size(664, 526)
        Me.dgvGreske.TabIndex = 9
        Me.dgvGreske.TabStop = False
        Me.dgvGreske.Text = "dgvGreske"
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.b1.Size = New System.Drawing.Size(215, 21)
        Me.b1.TabIndex = 185
        Me.b1.TabStop = False
        Me.b1.Text = "."
        Me.b1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b1.UseVisualStyleBackColor = False
        '
        'dgvTabele
        '
        Me.dgvTabele.AllowUserToAddRows = False
        Me.dgvTabele.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvTabele.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTabele.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTabele.Location = New System.Drawing.Point(1, 28)
        Me.dgvTabele.Margin = New System.Windows.Forms.Padding(1)
        Me.dgvTabele.Name = "dgvTabele"
        Me.dgvTabele.Size = New System.Drawing.Size(219, 526)
        Me.dgvTabele.TabIndex = 8
        Me.dgvTabele.TabStop = False
        Me.dgvTabele.Text = "dgvTabele"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.Window
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.ForeColor = System.Drawing.Color.SteelBlue
        Me.ProgressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 663)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(887, 43)
        Me.ProgressBar1.TabIndex = 174
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnBack)
        Me.PanelMenu.Controls.Add(Me.logovan)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button7)
        Me.PanelMenu.Controls.Add(Me.ButtonAKLK1)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.ButtonAK1)
        Me.PanelMenu.Controls.Add(Me.ButtonAKuzLK1)
        Me.PanelMenu.Controls.Add(Me.ButtonAKIzvestaj)
        Me.PanelMenu.Controls.Add(Me.btnPrazno)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(255, 749)
        Me.PanelMenu.TabIndex = 143
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
        Me.Button2.TabIndex = 10000080
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
        Me.Button7.TabIndex = 10000079
        Me.Button7.Text = "IST"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button7.UseVisualStyleBackColor = False
        '
        'ButtonAKLK1
        '
        Me.ButtonAKLK1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAKLK1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAKLK1.FlatAppearance.BorderSize = 0
        Me.ButtonAKLK1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonAKLK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAKLK1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAKLK1.ForeColor = System.Drawing.Color.White
        Me.ButtonAKLK1.Image = CType(resources.GetObject("ButtonAKLK1.Image"), System.Drawing.Image)
        Me.ButtonAKLK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAKLK1.Location = New System.Drawing.Point(10, 144)
        Me.ButtonAKLK1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAKLK1.Name = "ButtonAKLK1"
        Me.ButtonAKLK1.Size = New System.Drawing.Size(240, 38)
        Me.ButtonAKLK1.TabIndex = 30
        Me.ButtonAKLK1.Text = "    Контрола"
        Me.ButtonAKLK1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAKLK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAKLK1.UseVisualStyleBackColor = False
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
        'ButtonAK1
        '
        Me.ButtonAK1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAK1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAK1.FlatAppearance.BorderSize = 0
        Me.ButtonAK1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonAK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAK1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAK1.ForeColor = System.Drawing.Color.White
        Me.ButtonAK1.Image = CType(resources.GetObject("ButtonAK1.Image"), System.Drawing.Image)
        Me.ButtonAK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAK1.Location = New System.Drawing.Point(10, 282)
        Me.ButtonAK1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAK1.Name = "ButtonAK1"
        Me.ButtonAK1.Size = New System.Drawing.Size(240, 38)
        Me.ButtonAK1.TabIndex = 4
        Me.ButtonAK1.Text = "    АК - појединачно"
        Me.ButtonAK1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAK1.UseVisualStyleBackColor = False
        '
        'ButtonAKuzLK1
        '
        Me.ButtonAKuzLK1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAKuzLK1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAKuzLK1.FlatAppearance.BorderSize = 0
        Me.ButtonAKuzLK1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonAKuzLK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAKuzLK1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAKuzLK1.ForeColor = System.Drawing.Color.White
        Me.ButtonAKuzLK1.Image = CType(resources.GetObject("ButtonAKuzLK1.Image"), System.Drawing.Image)
        Me.ButtonAKuzLK1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAKuzLK1.Location = New System.Drawing.Point(10, 236)
        Me.ButtonAKuzLK1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAKuzLK1.Name = "ButtonAKuzLK1"
        Me.ButtonAKuzLK1.Size = New System.Drawing.Size(240, 38)
        Me.ButtonAKuzLK1.TabIndex = 2
        Me.ButtonAKuzLK1.Text = "    AK"
        Me.ButtonAKuzLK1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAKuzLK1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAKuzLK1.UseVisualStyleBackColor = False
        '
        'ButtonAKIzvestaj
        '
        Me.ButtonAKIzvestaj.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAKIzvestaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAKIzvestaj.FlatAppearance.BorderSize = 0
        Me.ButtonAKIzvestaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonAKIzvestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAKIzvestaj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAKIzvestaj.ForeColor = System.Drawing.Color.White
        Me.ButtonAKIzvestaj.Image = CType(resources.GetObject("ButtonAKIzvestaj.Image"), System.Drawing.Image)
        Me.ButtonAKIzvestaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAKIzvestaj.Location = New System.Drawing.Point(10, 190)
        Me.ButtonAKIzvestaj.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonAKIzvestaj.Name = "ButtonAKIzvestaj"
        Me.ButtonAKIzvestaj.Size = New System.Drawing.Size(240, 38)
        Me.ButtonAKIzvestaj.TabIndex = 0
        Me.ButtonAKIzvestaj.Text = "    Извештај"
        Me.ButtonAKIzvestaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAKIzvestaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAKIzvestaj.UseVisualStyleBackColor = False
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
        Me.btnPrazno.TabIndex = 32
        Me.btnPrazno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrazno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrazno.UseVisualStyleBackColor = False
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
        Me.Button3.TabIndex = 10000081
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PanelContext
        '
        Me.PanelContext.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContext.Controls.Add(Me.TableLayoutPanelTABLE)
        Me.PanelContext.Controls.Add(Me.PanelTop)
        Me.PanelContext.Controls.Add(Me.btnLinijaRazmak)
        Me.PanelContext.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(255, 0)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(895, 749)
        Me.PanelContext.TabIndex = 145
        '
        'UserControlVremenskaTacka1
        '
        Me.UserControlVremenskaTacka1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UserControlVremenskaTacka1.Enabled = False
        Me.UserControlVremenskaTacka1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.UserControlVremenskaTacka1.ForeColor = System.Drawing.Color.DarkRed
        Me.UserControlVremenskaTacka1.Location = New System.Drawing.Point(12, 556)
        Me.UserControlVremenskaTacka1.Name = "UserControlVremenskaTacka1"
        Me.UserControlVremenskaTacka1.Size = New System.Drawing.Size(122, 51)
        Me.UserControlVremenskaTacka1.TabIndex = 20
        Me.UserControlVremenskaTacka1.Visible = False
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
        Me.btnBack.Location = New System.Drawing.Point(13, 377)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 33)
        Me.btnBack.TabIndex = 10000087
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'logovan
        '
        Me.logovan.BackColor = System.Drawing.Color.Transparent
        Me.logovan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.logovan.Location = New System.Drawing.Point(0, 711)
        Me.logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.logovan.Name = "logovan"
        Me.logovan.Size = New System.Drawing.Size(255, 18)
        Me.logovan.TabIndex = 10000088
        Me.logovan.Tag = "nediraj"
        Me.logovan.Text = "aleksandar.karadjordjevic"
        Me.logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btnLinijaRazmak.TabIndex = 10000077
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
        'FormAK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1150, 749)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormAK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanelTABLE.ResumeLayout(False)
        Me.TableLayoutPanelTABLE.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvGreske, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTabele, System.ComponentModel.ISupportInitialize).EndInit()
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
    Dim strGrid25 As String

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
    Public mrist As DatasetIstrazivanja.ISTRow

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
    Dim panelmenucollapse As Boolean
    Dim zapamtilogovanog As String = ""


    Public Overloads Sub Dispose()
        Me.mls.Dispose()
        MyBase.Dispose()
    End Sub

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
    ByVal txt_CAPIServer As String, ByVal txt_CAPIBaza As String, ByVal mdtLabel As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable, ByVal mdtMessage As DataTable, ByVal panelmenucollapse As Boolean, ByVal kosamnew As String)
        Me.New()

        AddHandler dgvTabele.CellClick, AddressOf Me.dgvTabele_CellClick


        Me.jezik = jezik
        Call SetLang()

        Me.panelmenucollapse = panelmenucollapse
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtLabel = mdtLabel
        Me.mdtMessage = mdtMessage
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size

        Me.Logovan.Text = kosamnew 'GetUserName.ToString.Trim
        zapamtilogovanog = Logovan.Text.Trim
        Me.Text = Me.Text + " " + txtInstalacije + " - " + nazivIstrazivanja.Trim
        Me.UserControlVremenskaTacka1.Init(vt)

        mrist = rowIST

        ml = New LogickaKontrola(DBConnectionString, rowBaze, ISTTabele, allFromISTFields, pkISTFields, allFromISTLK, Me.ProgressBar1, Me.tbSql, Me.UserControlVremenskaTacka1, Me.jezik)
        mls = New LKizv(DBConnectionString, rowBaze, allFromISTLK, Nothing, Me.ProgressBar1, True, Me.UserControlVremenskaTacka1, Me.jezik, Me.dgvTabele, Me.dgvGreske)

        Me.jezik = jezik
        Me.txtmode = txtmode

        Me.allFromISTFields = allFromISTFields
        Me.pkISTFields = pkISTFields
        Me.allFromISTLK = allFromISTLK

        Me.istLK = ml.mtip
        Call napunidgvTabeledgvGeske()

        'Me.istPolja = allFromISTFields
        'Call napunidgvP()

        'Me.dFold = fold
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

        Call srediGridView(Me.dgvTabele, True, 50)
        Call srediGridView(Me.dgvGreske, False, 50)

        btnBack.Location = New System.Drawing.Point(ButtonAKLK1.Location.X + 3, Logovan.Location.Y - btnBack.Width - 10)

        Me.dgvTabele.ReadOnly = True
        Me.dgvGreske.ReadOnly = False

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
    End Sub

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
        dgDT.Columns.Add("akcija", System.Type.GetType("System.String"))

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
                If istLK.Rows(i).Item("akcija") Is System.DBNull.Value Then
                    NR("akcija") = ""
                Else
                    NR("akcija") = Me.istLK.Rows(i).Item("akcija").ToString.Trim
                End If

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

    Sub imenaKolona2(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("sifist") Is Nothing Then dgDT.Columns("sifist").ColumnName = strGrid6
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = strGrid7
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = strGrid8
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = strGrid9
        If Not dgDT.Columns("USLOV") Is Nothing Then dgDT.Columns("USLOV").ColumnName = strGrid10
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = strGrid11
        If Not dgDT.Columns("tezina") Is Nothing Then dgDT.Columns("tezina").ColumnName = strGrid12
        If Not dgDT.Columns("LK") Is Nothing Then dgDT.Columns("LK").ColumnName = strGrid13
        If Not dgDT.Columns("akcija") Is Nothing Then dgDT.Columns("akcija").ColumnName = strGrid19
    End Sub

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

        Dim bspace As String = "      "
        ButtonAKIzvestaj.Text = bspace + getControlText2(dt, "ButtonAKIzvestaj", Me.jezik)
        ButtonAKIzvestaj.Tag = ButtonAKIzvestaj.Text         '
        ButtonAKuzLK1.Text = bspace + getControlText2(dt, "ButtonAKuzLK", Me.jezik)
        ButtonAKuzLK1.Tag = ButtonAKuzLK1.Text
        ButtonAK1.Text = bspace + getControlText2(dt, "ButtonAK", Me.jezik)
        ButtonAK1.Tag = ButtonAK1.Text
        ButtonAKLK1.Text = bspace + getControlText2(dt, "buttonLK", Me.jezik)
        ButtonAKLK1.Tag = ButtonAKLK1.Text

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
        Me.strGrid25 = getControlText2(dt, "dgGrid25", Me.jezik)

        'Me.Text = getControlText2(dt, "naslov4", Me.jezik)



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
        Me.dgvTabele.Visible = True
        Me.dgvGreske.Visible = True
        Me.tbSql.Visible = True

    End Sub

    Sub imenaKolona1(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("sifist") Is Nothing Then dgDT.Columns("sifist").ColumnName = strGrid6
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = strGrid7
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

    Private Sub FormAK_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call PreVentFlicker()

        Call seeFirst()
        If Me.panelmenucollapse = True Then
            Call CollapseMenu()
        End If
        Call SettingObjForTheme(GetTheme())
        Call nonvisiblePanelTOP()
        ButtonAKLK1.Focus()
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
            Dim dIndex = logovan.Text.IndexOf(".")
            If (dIndex > -1) AndAlso (dIndex + 2) < Len(zapamtilogovanog) Then
                logovan.Visible = True
                logovan.Text = zapamtilogovanog.Trim.ToUpper.Substring(0, 1) + zapamtilogovanog.Trim.ToUpper.Substring(dIndex, 2)
            Else
                logovan.Text = ""
            End If
        Else
            PanelMenu.Width = 255
            setTollTip(False)
            panelmenucollapse = False
            Button7.Image = My.Resources.crtaaaaa.ToBitmap
            Button2.Visible = True
            logovan.Visible = True
            logovan.Text = zapamtilogovanog
        End If


    End Sub
    Sub setTollTip(ByVal visibleTrue As Boolean)
        If visibleTrue = True Then



            ToolTip1.SetToolTip(ButtonAKIzvestaj, ButtonAKIzvestaj.Tag)
            ToolTip1.SetToolTip(ButtonAKuzLK1, ButtonAKuzLK1.Tag)
            ToolTip1.SetToolTip(ButtonAK1, ButtonAK1.Tag)
            ToolTip1.SetToolTip(ButtonAKLK1, ButtonAKLK1.Tag)

        Else
            ToolTip1.SetToolTip(ButtonAKIzvestaj, "")
            ToolTip1.SetToolTip(ButtonAKuzLK1, "")
            ToolTip1.SetToolTip(ButtonAK1, "")
            ToolTip1.SetToolTip(ButtonAKLK1, "")

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

    'Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
    '    Me.Close()
    'End Sub
    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelMenu
        ReDim Preserve nizButtonOboji(2)
        nizButtonOboji(2) = PanelTop
        ReDim Preserve nizButtonOboji(3)
        'Dim nizButtonOrange() As Button = {}
        'Dim inizButtonOrange As Integer = -1

        'For i As Integer = 0 To nizButton.GetUpperBound(0)
        '    ReDim Preserve nizButtonOrange(i)
        '    nizButtonOrange(i) = nizButton(i)
        '    inizButtonOrange = i
        'Next
        zapamtibojuteme = setTheme(nizButtonOboji, Nothing, theme)

    End Sub
    Dim zapamtibojuteme As Color = Nothing
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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

        Me.Cursor = Cursors.Default
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub ButtonAKLK_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        Call seeFirst()
        'Me.b1.Text = strGrid21
        'Me.b2.Text = strGrid22
        Me.Cursor = Cursors.WaitCursor
        ml.LK("", "", True)
        ''msg 139
        Dim msgtxt As String = getMessageText(dtMessages, "139", Me.jezik)
        ISTMessageBox.Show(msgtxt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''msg 140
        Dim msgtxt140 As String = getMessageText(dtMessages, "140", Me.jezik)
        Call UpisiISTLogLK(msgtxt140)
        Call buttonAKIzvestajClick()
        Me.Cursor = Cursors.Default

    End Sub
    Sub buttonAKIzvestajClick()
        Call seeFirst()
        Me.Cursor = Cursors.WaitCursor
        mls.puniGrid("", "")

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

    Private Sub ButtonAKuzLK_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.tbSql.Visible = False
        Me.Cursor = Cursors.WaitCursor
        mls.AKuzLK("", "", mrist,, txtmode)
        mls.puniGrid("", "")
        ''msg 137
        Dim msgtxt As String = getMessageText(dtMessages, "137", Me.jezik)
        ISTMessageBox.Show(msgtxt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonAK_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Cursor = Cursors.WaitCursor
        mls.AK("", "", mrist, strGrid25, strGrid19,, txtmode)
        mls.puniGrid("", "")
        ''msg 140
        Dim msgtxt As String = getMessageText(dtMessages, "140", Me.jezik)
        ISTMessageBox.Show(msgtxt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub ButtonAKLK1_Click(sender As Object, e As EventArgs) Handles ButtonAKLK1.Click
        Call seeFirst()

        Me.Cursor = Cursors.WaitCursor
        ml.LK("", "", True)
        ''msg 139
        Dim msgtxt As String = getMessageText(dtMessages, "139", Me.jezik)
        ISTMessageBox.Show(msgtxt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ''msg 140
        Dim msgtxt140 As String = getMessageText(dtMessages, "140", Me.jezik)
        Call UpisiISTLogLK(msgtxt140)
        Call buttonAKIzvestajClick()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonAKIzvestaj1_Click(sender As Object, e As EventArgs) Handles ButtonAKIzvestaj.Click
        Call buttonAKIzvestajClick()
    End Sub

    Private Sub ButtonAKuzLK1_Click(sender As Object, e As EventArgs) Handles ButtonAKuzLK1.Click

        Me.tbSql.Visible = False
        Me.Cursor = Cursors.WaitCursor
        mls.AKuzLK("", "", mrist,, txtmode)
        mls.puniGrid("", "")
        ''msg 137
        Dim msgtxt As String = getMessageText(dtMessages, "137", Me.jezik)
        ISTMessageBox.Show(msgtxt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonAK1_Click(sender As Object, e As EventArgs) Handles ButtonAK1.Click

        Me.Cursor = Cursors.WaitCursor
        mls.AK("", "", mrist, strGrid25, strGrid19,, txtmode)
        mls.puniGrid("", "")
        ''msg 140
        Dim msgtxt As String = getMessageText(dtMessages, "140", Me.jezik)
        ISTMessageBox.Show(msgtxt, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.btnCerrar.PerformClick()
    End Sub

    Private Sub ButtonAKLK1_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonAKuzLK1.MouseDown, ButtonAKLK1.MouseDown, ButtonAKIzvestaj.MouseDown, ButtonAK1.MouseDown
        ActivateButton(sender, ActivateButtonColor)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://istportal.net")
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
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