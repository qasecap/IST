Option Strict Off

Imports System
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class FormOcena
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
    Friend WithEvents lbGroupBy As System.Windows.Forms.ListBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView

    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GB As System.Windows.Forms.Button
    Friend WithEvents ButtonPonisti As System.Windows.Forms.Button
    Friend WithEvents ButtonTrazi As System.Windows.Forms.Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents PanelMenu As Panel
    Private WithEvents ButtonUradi As Button
    Friend WithEvents UserControlVremenskaTacka1 As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents PanelContext As Panel
    Friend WithEvents ButtonXML As Button
    Friend WithEvents ButtonJSON As Button
    Friend WithEvents ButtonExcel As Button
    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolTip1 As ToolTip

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOcena))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.lbGroupBy = New System.Windows.Forms.ListBox()
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ButtonPonisti = New System.Windows.Forms.Button()
        Me.ButtonTrazi = New System.Windows.Forms.Button()
        Me.GB = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ButtonXML = New System.Windows.Forms.Button()
        Me.ButtonJSON = New System.Windows.Forms.Button()
        Me.ButtonExcel = New System.Windows.Forms.Button()
        Me.ButtonUradi = New System.Windows.Forms.Button()
        Me.UserControlVremenskaTacka1 = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(696, 709)
        Me.dgv.TabIndex = 10000054
        '
        'lbGroupBy
        '
        Me.lbGroupBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lbGroupBy.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbGroupBy.CausesValidation = False
        Me.lbGroupBy.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbGroupBy.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbGroupBy.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbGroupBy.ItemHeight = 14
        Me.lbGroupBy.Location = New System.Drawing.Point(0, 50)
        Me.lbGroupBy.Name = "lbGroupBy"
        Me.lbGroupBy.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbGroupBy.Size = New System.Drawing.Size(195, 266)
        Me.lbGroupBy.TabIndex = 1
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
        'SplitContainer2
        '
        Me.SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonPonisti)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonTrazi)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lbGroupBy)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GB)
        Me.SplitContainer2.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer2.Size = New System.Drawing.Size(895, 709)
        Me.SplitContainer2.SplitterDistance = 195
        Me.SplitContainer2.TabIndex = 0
        '
        'ButtonPonisti
        '
        Me.ButtonPonisti.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonPonisti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonPonisti.FlatAppearance.BorderSize = 0
        Me.ButtonPonisti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPonisti.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPonisti.ForeColor = System.Drawing.Color.Black
        Me.ButtonPonisti.Location = New System.Drawing.Point(7, 355)
        Me.ButtonPonisti.Name = "ButtonPonisti"
        Me.ButtonPonisti.Size = New System.Drawing.Size(186, 30)
        Me.ButtonPonisti.TabIndex = 220
        Me.ButtonPonisti.TabStop = False
        Me.ButtonPonisti.Text = "Поништи"
        Me.ButtonPonisti.UseVisualStyleBackColor = False
        '
        'ButtonTrazi
        '
        Me.ButtonTrazi.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonTrazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonTrazi.FlatAppearance.BorderSize = 0
        Me.ButtonTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrazi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTrazi.ForeColor = System.Drawing.Color.Black
        Me.ButtonTrazi.Location = New System.Drawing.Point(7, 319)
        Me.ButtonTrazi.Name = "ButtonTrazi"
        Me.ButtonTrazi.Size = New System.Drawing.Size(186, 30)
        Me.ButtonTrazi.TabIndex = 219
        Me.ButtonTrazi.TabStop = False
        Me.ButtonTrazi.Text = "Тражи"
        Me.ButtonTrazi.UseVisualStyleBackColor = False
        '
        'GB
        '
        Me.GB.BackColor = System.Drawing.Color.Transparent
        Me.GB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GB.Cursor = System.Windows.Forms.Cursors.Default
        Me.GB.Dock = System.Windows.Forms.DockStyle.Top
        Me.GB.FlatAppearance.BorderSize = 0
        Me.GB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GB.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.GB.Location = New System.Drawing.Point(0, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(195, 50)
        Me.GB.TabIndex = 215
        Me.GB.TabStop = False
        Me.GB.Text = "Изаберите по чему желите број слогова:  "
        Me.GB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GB.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1150, 40)
        Me.PanelTop.TabIndex = 142
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
        Me.b3.TabIndex = 183
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1067, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = True
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
        Me.btnCerrar.Location = New System.Drawing.Point(1110, 0)
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
        Me.Logovan.Location = New System.Drawing.Point(858, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.ButtonXML)
        Me.PanelMenu.Controls.Add(Me.ButtonJSON)
        Me.PanelMenu.Controls.Add(Me.ButtonExcel)
        Me.PanelMenu.Controls.Add(Me.ButtonUradi)
        Me.PanelMenu.Controls.Add(Me.UserControlVremenskaTacka1)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button7)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(255, 709)
        Me.PanelMenu.TabIndex = 143
        '
        'ButtonXML
        '
        Me.ButtonXML.BackColor = System.Drawing.Color.Transparent
        Me.ButtonXML.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonXML.FlatAppearance.BorderSize = 0
        Me.ButtonXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonXML.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonXML.ForeColor = System.Drawing.Color.White
        Me.ButtonXML.Image = CType(resources.GetObject("ButtonXML.Image"), System.Drawing.Image)
        Me.ButtonXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonXML.Location = New System.Drawing.Point(10, 254)
        Me.ButtonXML.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonXML.Name = "ButtonXML"
        Me.ButtonXML.Size = New System.Drawing.Size(240, 38)
        Me.ButtonXML.TabIndex = 187
        Me.ButtonXML.Tag = "      Xml"
        Me.ButtonXML.Text = "      Xml"
        Me.ButtonXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonXML.UseVisualStyleBackColor = False
        '
        'ButtonJSON
        '
        Me.ButtonJSON.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJSON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonJSON.FlatAppearance.BorderSize = 0
        Me.ButtonJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJSON.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJSON.ForeColor = System.Drawing.Color.White
        Me.ButtonJSON.Image = CType(resources.GetObject("ButtonJSON.Image"), System.Drawing.Image)
        Me.ButtonJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonJSON.Location = New System.Drawing.Point(10, 199)
        Me.ButtonJSON.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonJSON.Name = "ButtonJSON"
        Me.ButtonJSON.Size = New System.Drawing.Size(240, 38)
        Me.ButtonJSON.TabIndex = 185
        Me.ButtonJSON.Tag = "      Json"
        Me.ButtonJSON.Text = "      Json"
        Me.ButtonJSON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonJSON.UseVisualStyleBackColor = False
        '
        'ButtonExcel
        '
        Me.ButtonExcel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonExcel.FlatAppearance.BorderSize = 0
        Me.ButtonExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExcel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExcel.ForeColor = System.Drawing.Color.White
        Me.ButtonExcel.Image = CType(resources.GetObject("ButtonExcel.Image"), System.Drawing.Image)
        Me.ButtonExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExcel.Location = New System.Drawing.Point(10, 144)
        Me.ButtonExcel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonExcel.Name = "ButtonExcel"
        Me.ButtonExcel.Size = New System.Drawing.Size(240, 38)
        Me.ButtonExcel.TabIndex = 183
        Me.ButtonExcel.Tag = "      Excel"
        Me.ButtonExcel.Text = "      Excel"
        Me.ButtonExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonExcel.UseVisualStyleBackColor = False
        '
        'ButtonUradi
        '
        Me.ButtonUradi.BackColor = System.Drawing.Color.White
        Me.ButtonUradi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonUradi.ForeColor = System.Drawing.Color.DarkRed
        Me.ButtonUradi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonUradi.Location = New System.Drawing.Point(202, 483)
        Me.ButtonUradi.Name = "ButtonUradi"
        Me.ButtonUradi.Size = New System.Drawing.Size(32, 24)
        Me.ButtonUradi.TabIndex = 182
        Me.ButtonUradi.Text = "Контрола ст"
        Me.ButtonUradi.UseVisualStyleBackColor = False
        Me.ButtonUradi.Visible = False
        '
        'UserControlVremenskaTacka1
        '
        Me.UserControlVremenskaTacka1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UserControlVremenskaTacka1.Enabled = False
        Me.UserControlVremenskaTacka1.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.UserControlVremenskaTacka1.ForeColor = System.Drawing.Color.DarkRed
        Me.UserControlVremenskaTacka1.Location = New System.Drawing.Point(202, 513)
        Me.UserControlVremenskaTacka1.Name = "UserControlVremenskaTacka1"
        Me.UserControlVremenskaTacka1.Size = New System.Drawing.Size(32, 27)
        Me.UserControlVremenskaTacka1.TabIndex = 20
        Me.UserControlVremenskaTacka1.Visible = False
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
        Me.PanelContext.Controls.Add(Me.SplitContainer2)
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
        'FormOcena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 749)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormOcena"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContext.ResumeLayout(False)
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

    Dim DBConnectionString As String
    Dim ttab As DatasetIstrazivanja.ISTTABSDataTable
    Dim istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Dim istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Dim istLK As DatasetIstrazivanja.ISTLKDataTable
    Dim istBaze As DatasetIstrazivanja.ISTBAZEDataTable
    Dim mrist As DatasetIstrazivanja.ISTRow

    Dim trtDSpom As System.Data.DataSet
    Dim tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim mTrt As String
    Dim mxls As String
    Dim mExcelXML As String
    Dim mXML As String
    Dim mXSL As String
    Dim dword As String
    Dim wfn As String = ""
    Dim jesteExcelXML As Integer = 0
    Dim putanja As String
    Dim dtSelect As New System.Data.DataTable
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim lokalno As Boolean
    Dim jezik As String
    Dim txtmode As String
    Dim sifist As String
    Dim panelmenucollapse As Boolean


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
        Else
            PanelMenu.Width = 255
            setTollTip(False)
            panelmenucollapse = False
            Button7.Image = My.Resources.crtaaaaa.ToBitmap
            Button2.Visible = True
        End If

    End Sub
    Sub setTollTip(ByVal visibleTrue As Boolean)
        If visibleTrue = True Then
            ToolTip1.SetToolTip(ButtonExcel, ButtonExcel.Tag)
            ToolTip1.SetToolTip(ButtonXML, ButtonXML.Tag)
            ToolTip1.SetToolTip(ButtonJSON, ButtonJSON.Tag)
        Else
            ToolTip1.SetToolTip(ButtonExcel, "")
            ToolTip1.SetToolTip(ButtonXML, "")
            ToolTip1.SetToolTip(ButtonJSON, "")
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                    ByVal txtPismo As String,
                    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
                    ByVal txt_DSBrisanjeBaza As String, ByVal txtmode As String, ByVal jezik As String, ByVal panelmenucollapse As Boolean)

        Me.New()

        Me.jezik = jezik
        Call SetLang()
        Me.panelmenucollapse = panelmenucollapse
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Logovan.Text = GetUserName.ToString.Trim

        Me.txtmode = txtmode
        sifist = ri.Item(0).ToString.Trim
        Me.Text += " - " + ri.Naziv.Trim
        Me.ttab = ttab
        Me.mrist = ri
        Me.DBConnectionString = DBConnectionString
        ucvt.Init(vt)
        tacv = vt

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        lokalno = False
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

        If lokalno = True Then
            Me.Close()
        Else
            ''POPUNJAVAM  lbGroupBy
            Dim dt As New System.Data.DataTable
            dt.Columns.Add("display")
            dt.Columns.Add("value")

            dt.Rows.Add(New Object() {"Year", "GOD"})
            dt.Rows.Add(New Object() {"Month", "MES"})
            dt.Rows.Add(New Object() {"Table", "Tabela"})
            dt.Rows.Add(New Object() {"PrimaryKey", "kljuc"})
            dt.Rows.Add(New Object() {"Variable", "Varijabla"})
            dt.Rows.Add(New Object() {"TypeOfChange", "vrstaPromene"})
            Me.lbGroupBy.DataSource = dt

            Me.lbGroupBy.DisplayMember = dt.Columns("display").ColumnName
            Me.lbGroupBy.ValueMember = dt.Columns("value").ColumnName
        End If
        b3.Text = sifist + "    " + String.Format("{0:d2}", Me.tacv.M) + " / " + Me.tacv.G.ToString

        Me.jezik = jezik
    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        GB.Text = getControlText2(dt, "GBOcena", Me.jezik)
        ButtonTrazi.Text = getControlText2(dt, "ButtonOcenaTrazi", Me.jezik)
        ButtonPonisti.Text = getControlText2(dt, "ButtonOcenaPonisti", Me.jezik)
        Dim bspace As String = "      "
        ButtonExcel.Tag = ButtonExcel.Text
        ButtonXML.Tag = ButtonExcel.Text
        ButtonJSON.Tag = ButtonJSON.Text

    End Sub



    '**********************************
    Private Sub dgrid(ByVal str As String)

        Dim DEPOConnectionString As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)

        Dim DS As New System.Data.DataSet
        Dim rs As Long
        Try
            DS = izvrsiSQLvratiDS(str, DEPOConnectionString, Me.jezik)
            rs = DS.Tables(0).Rows.Count
            ''msg 8
            Dim msgtxt8 As String = getMessageText(dtMessages, "8", Me.jezik)
            ''msg 9
            Dim msgtxt9 As String = getMessageText(dtMessages, "9", Me.jezik)
            ''msg 10
            Dim msgtxt10 As String = getMessageText(dtMessages, "10", Me.jezik)

            Dim por1 As String = msgtxt8 + rs.ToString + msgtxt9
            Dim por2 As String = msgtxt10
            If rs > 1000 AndAlso ISTMessageBox.Show(por1, por2, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            Else
                dgv.DataSource = DS.Tables(0)
                trtDSpom = DS
            End If

        Catch ex As System.Exception
            Dim poruka As String = ex.Message
            If CType(ex, SqlClient.SqlException).ErrorCode = -2147217913 Then
                ''msg 11
                Dim msgtxt11 As String = getMessageText(dtMessages, "11", Me.jezik)
                poruka = msgtxt11
            End If
            ISTMessageBox.Show(poruka, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

    End Sub



    Private Sub dg_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles dgv.RowPostPaint
        Dim dgv As System.Windows.Forms.DataGridView = CType(sender, System.Windows.Forms.DataGridView)
        Dim rowIdx As Integer = CInt((e.RowIndex + 1).ToString())
        Dim rowFont As New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dim centerFormat As Object = New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        centerFormat.LineAlignment = StringAlignment.Center
        Dim headerBounds As Rectangle = New Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height)
        e.Graphics.DrawString(rowIdx, rowFont, SystemBrushes.ControlText, headerBounds, centerFormat)
    End Sub

    Private Sub ButtonTrazi_Click(sender As Object, e As System.EventArgs) Handles ButtonTrazi.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim nizGB As String = ""
        Dim nizS As String = ""
        Dim groupBy As String = ""
        For i As Integer = 0 To lbGroupBy.SelectedItems.Count - 1
            nizS = nizS + lbGroupBy.SelectedItems(i).Item("value") + " as [" + lbGroupBy.SelectedItems(i).Item("display") + "],"
            nizGB = nizGB + lbGroupBy.SelectedItems(i).Item("value") + ","
        Next
        nizGB = nizGB + "$" : nizS = nizS + "$"
        nizGB = nizGB.Replace(",$", "") : nizS = nizS.Replace(",$", "")
        nizS = nizS.Replace("PrimaryKey", "Record")

        Dim strSelect As String = ""
        strSelect = "SELECT " + nizS & ", count(*) as Count " _
        + " FROM dbo.ISTPromenaVarijabli " _
        + " WHERE sifist='" + Me.mrist.SIFIST.Trim.ToUpper + "'" _
        + " group by " + nizGB
        Call dgrid(strSelect)
        Call srediGridView(dgv)
        dgv.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Verdana", 8.0!, FontStyle.Bold)

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ButtonPonisti_Click_1(sender As Object, e As System.EventArgs) Handles ButtonPonisti.Click
        lbGroupBy.ClearSelected()
        dgv.DataSource = Nothing
    End Sub

    Private Sub ButtonExcel_Click(sender As Object, e As System.EventArgs) Handles ButtonExcel.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Export2Excel_DGV(lokalno, trtDSpom, Me.jezik)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub ButtonXML_Click(sender As Object, e As System.EventArgs) Handles ButtonXML.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim vt As String = tacv.G.ToString.Trim & tacv.M.ToString.Trim.PadLeft(2, "0"c)
        Dim dv As String = Now.ToShortDateString.Trim.Replace("/", "") & "_" & Now.ToShortTimeString.Trim.Replace(":", "")
        Export2XML_DGV(mrist.SIFIST.Trim & "_" & vt.Trim & "_" & dv.Trim, lokalno, trtDSpom, Me.jezik)

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub ButtonJSON_Click(sender As Object, e As System.EventArgs) Handles ButtonJSON.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim datumVreme As String = Now.ToShortDateString.Trim.Replace("/", "") & "_" & Now.ToShortTimeString.Trim.Replace(":", "")
        Export2JSON_DGV(datumVreme.Trim, lokalno, trtDSpom, Me.jezik)

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub



    Private Sub FormOcena_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call PreVentFlicker()
        Call setTheme(GetTheme())

        Me.SplitContainer2.SplitterDistance = 200
        If Me.panelmenucollapse = True Then
            Call CollapseMenu()
        End If
        Me.lbGroupBy.Focus()
    End Sub
    Sub setTheme(ByVal theme As String)
        If theme = "L" Then
            ISTTheme.ChosenTheme("Light")
            ActivateButtonColor = ISTTheme.ActivateButtons
            PanelMenu.BackColor = ISTTheme.PanelParent
            PanelTop.BackColor = ISTTheme.PanelParent
        Else
            ISTTheme.ChosenTheme("Dark")
            ActivateButtonColor = ISTTheme.ActivateButtons
            PanelMenu.BackColor = ISTTheme.PanelParent
            PanelTop.BackColor = ISTTheme.PanelParent
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.btnCerrar.PerformClick()
    End Sub

    Private Sub ButtonExcel_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonXML.MouseDown, ButtonJSON.MouseDown, ButtonExcel.MouseDown
        ActivateButton(sender, ActivateButtonColor)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://istportal.net")
    End Sub
End Class