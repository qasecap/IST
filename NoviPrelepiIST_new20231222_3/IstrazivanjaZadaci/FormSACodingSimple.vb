Option Strict Off

Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormSACodingSimple
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

    Friend WithEvents txtSQLUpdate As TextBox
    Friend WithEvents panelTabelaA As Panel
    Friend WithEvents ucvtA As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents txtAppA As TextBox
    Friend WithEvents bAddTableB As Button
    Friend WithEvents bDownAppA As PictureBox
    Friend WithEvents clbAppA As CheckedListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clbTabelaA As CheckedListBox
    Friend WithEvents txtTabelaA As TextBox
    Friend WithEvents bDownTA As PictureBox
    Friend WithEvents clbFilterA As CheckedListBox
    Friend WithEvents ButtonFieldA As Button
    Friend WithEvents lbltabelaA As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents panelTabelaB As Panel
    Friend WithEvents ButtonISTIzlaz As Button
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bAdd As Button
    Friend WithEvents bRemove As Button
    Friend WithEvents bJoin As Button
    Friend WithEvents ButtonFieldB As Button
    Friend WithEvents txtAppB As TextBox
    Friend WithEvents bDownAppB As PictureBox
    Friend WithEvents clbAppB As CheckedListBox
    Friend WithEvents clbFilterB As CheckedListBox
    Friend WithEvents bDownTB As PictureBox
    Friend WithEvents txtTabelaB As TextBox
    Friend WithEvents clbTabelaB As CheckedListBox
    Friend WithEvents ucvtB As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents lbltabelaB As Label
    Friend WithEvents lblApp As Label
    Friend WithEvents lblDistinctCount As Label
    Friend WithEvents TLP As TableLayoutPanel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSACodingSimple))
        Me.panelTabelaA = New System.Windows.Forms.Panel()
        Me.ucvtA = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.txtAppA = New System.Windows.Forms.TextBox()
        Me.bAddTableB = New System.Windows.Forms.Button()
        Me.bDownAppA = New System.Windows.Forms.PictureBox()
        Me.clbAppA = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbTabelaA = New System.Windows.Forms.CheckedListBox()
        Me.txtTabelaA = New System.Windows.Forms.TextBox()
        Me.bDownTA = New System.Windows.Forms.PictureBox()
        Me.clbFilterA = New System.Windows.Forms.CheckedListBox()
        Me.ButtonFieldA = New System.Windows.Forms.Button()
        Me.lbltabelaA = New System.Windows.Forms.Label()
        Me.txtSQLUpdate = New System.Windows.Forms.TextBox()
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ButtonISTIzlaz = New System.Windows.Forms.Button()
        Me.panelTabelaB = New System.Windows.Forms.Panel()
        Me.ButtonFieldB = New System.Windows.Forms.Button()
        Me.txtAppB = New System.Windows.Forms.TextBox()
        Me.bDownAppB = New System.Windows.Forms.PictureBox()
        Me.clbAppB = New System.Windows.Forms.CheckedListBox()
        Me.clbFilterB = New System.Windows.Forms.CheckedListBox()
        Me.bDownTB = New System.Windows.Forms.PictureBox()
        Me.txtTabelaB = New System.Windows.Forms.TextBox()
        Me.clbTabelaB = New System.Windows.Forms.CheckedListBox()
        Me.ucvtB = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.lbltabelaB = New System.Windows.Forms.Label()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bRemove = New System.Windows.Forms.Button()
        Me.bJoin = New System.Windows.Forms.Button()
        Me.lblDistinctCount = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTabelaA.SuspendLayout()
        CType(Me.bDownAppA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDownTA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TLP.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panelTabelaB.SuspendLayout()
        CType(Me.bDownAppB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bDownTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelTabelaA
        '
        Me.panelTabelaA.Controls.Add(Me.ucvtA)
        Me.panelTabelaA.Controls.Add(Me.txtAppA)
        Me.panelTabelaA.Controls.Add(Me.bAddTableB)
        Me.panelTabelaA.Controls.Add(Me.bDownAppA)
        Me.panelTabelaA.Controls.Add(Me.clbAppA)
        Me.panelTabelaA.Controls.Add(Me.Label1)
        Me.panelTabelaA.Controls.Add(Me.clbTabelaA)
        Me.panelTabelaA.Controls.Add(Me.txtTabelaA)
        Me.panelTabelaA.Controls.Add(Me.bDownTA)
        Me.panelTabelaA.Controls.Add(Me.clbFilterA)
        Me.panelTabelaA.Controls.Add(Me.ButtonFieldA)
        Me.panelTabelaA.Controls.Add(Me.lbltabelaA)
        Me.panelTabelaA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.panelTabelaA.Location = New System.Drawing.Point(3, 3)
        Me.panelTabelaA.Name = "panelTabelaA"
        Me.panelTabelaA.Size = New System.Drawing.Size(315, 298)
        Me.panelTabelaA.TabIndex = 10000325
        '
        'ucvtA
        '
        Me.ucvtA.BackColor = System.Drawing.SystemColors.Control
        Me.ucvtA.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvtA.Location = New System.Drawing.Point(45, 9)
        Me.ucvtA.Name = "ucvtA"
        Me.ucvtA.Size = New System.Drawing.Size(109, 48)
        Me.ucvtA.TabIndex = 10000155
        Me.ucvtA.TabStop = False
        '
        'txtAppA
        '
        Me.txtAppA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAppA.Location = New System.Drawing.Point(45, 63)
        Me.txtAppA.MaxLength = 20
        Me.txtAppA.Name = "txtAppA"
        Me.txtAppA.Size = New System.Drawing.Size(212, 21)
        Me.txtAppA.TabIndex = 10000185
        Me.txtAppA.Visible = False
        '
        'bAddTableB
        '
        Me.bAddTableB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAddTableB.BackColor = System.Drawing.SystemColors.Control
        Me.bAddTableB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAddTableB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAddTableB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bAddTableB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bAddTableB.Location = New System.Drawing.Point(287, 100)
        Me.bAddTableB.Margin = New System.Windows.Forms.Padding(0)
        Me.bAddTableB.Name = "bAddTableB"
        Me.bAddTableB.Size = New System.Drawing.Size(21, 21)
        Me.bAddTableB.TabIndex = 10000144
        Me.bAddTableB.Text = "+"
        Me.bAddTableB.UseVisualStyleBackColor = False
        Me.bAddTableB.Visible = False
        '
        'bDownAppA
        '
        Me.bDownAppA.BackColor = System.Drawing.Color.Transparent
        Me.bDownAppA.Image = CType(resources.GetObject("bDownAppA.Image"), System.Drawing.Image)
        Me.bDownAppA.Location = New System.Drawing.Point(257, 63)
        Me.bDownAppA.Name = "bDownAppA"
        Me.bDownAppA.Size = New System.Drawing.Size(21, 21)
        Me.bDownAppA.TabIndex = 10000186
        Me.bDownAppA.TabStop = False
        Me.bDownAppA.Visible = False
        '
        'clbAppA
        '
        Me.clbAppA.BackColor = System.Drawing.SystemColors.Window
        Me.clbAppA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbAppA.CheckOnClick = True
        Me.clbAppA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbAppA.FormattingEnabled = True
        Me.clbAppA.Location = New System.Drawing.Point(45, 83)
        Me.clbAppA.Name = "clbAppA"
        Me.clbAppA.Size = New System.Drawing.Size(212, 18)
        Me.clbAppA.TabIndex = 10000184
        Me.clbAppA.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(3, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 26)
        Me.Label1.TabIndex = 10000183
        Me.Label1.Text = "App"
        Me.Label1.Visible = False
        '
        'clbTabelaA
        '
        Me.clbTabelaA.BackColor = System.Drawing.SystemColors.Window
        Me.clbTabelaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbTabelaA.CheckOnClick = True
        Me.clbTabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbTabelaA.FormattingEnabled = True
        Me.clbTabelaA.Location = New System.Drawing.Point(45, 120)
        Me.clbTabelaA.Name = "clbTabelaA"
        Me.clbTabelaA.Size = New System.Drawing.Size(212, 18)
        Me.clbTabelaA.TabIndex = 10000130
        Me.clbTabelaA.Visible = False
        '
        'txtTabelaA
        '
        Me.txtTabelaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTabelaA.Location = New System.Drawing.Point(45, 100)
        Me.txtTabelaA.MaxLength = 20
        Me.txtTabelaA.Name = "txtTabelaA"
        Me.txtTabelaA.Size = New System.Drawing.Size(212, 21)
        Me.txtTabelaA.TabIndex = 10000131
        '
        'bDownTA
        '
        Me.bDownTA.BackColor = System.Drawing.Color.Transparent
        Me.bDownTA.Image = CType(resources.GetObject("bDownTA.Image"), System.Drawing.Image)
        Me.bDownTA.Location = New System.Drawing.Point(257, 100)
        Me.bDownTA.Name = "bDownTA"
        Me.bDownTA.Size = New System.Drawing.Size(21, 21)
        Me.bDownTA.TabIndex = 10000132
        Me.bDownTA.TabStop = False
        '
        'clbFilterA
        '
        Me.clbFilterA.BackColor = System.Drawing.SystemColors.Window
        Me.clbFilterA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbFilterA.CheckOnClick = True
        Me.clbFilterA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbFilterA.FormattingEnabled = True
        Me.clbFilterA.Location = New System.Drawing.Point(45, 137)
        Me.clbFilterA.Name = "clbFilterA"
        Me.clbFilterA.Size = New System.Drawing.Size(212, 146)
        Me.clbFilterA.TabIndex = 10000141
        Me.clbFilterA.Visible = False
        '
        'ButtonFieldA
        '
        Me.ButtonFieldA.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFieldA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFieldA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFieldA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonFieldA.Image = CType(resources.GetObject("ButtonFieldA.Image"), System.Drawing.Image)
        Me.ButtonFieldA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonFieldA.Location = New System.Drawing.Point(257, 137)
        Me.ButtonFieldA.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFieldA.Name = "ButtonFieldA"
        Me.ButtonFieldA.Size = New System.Drawing.Size(21, 21)
        Me.ButtonFieldA.TabIndex = 10000143
        Me.ButtonFieldA.UseVisualStyleBackColor = False
        Me.ButtonFieldA.Visible = False
        '
        'lbltabelaA
        '
        Me.lbltabelaA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltabelaA.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbltabelaA.Location = New System.Drawing.Point(2, 100)
        Me.lbltabelaA.Name = "lbltabelaA"
        Me.lbltabelaA.Size = New System.Drawing.Size(40, 20)
        Me.lbltabelaA.TabIndex = 10000133
        Me.lbltabelaA.Text = "Table"
        '
        'txtSQLUpdate
        '
        Me.txtSQLUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSQLUpdate.Enabled = False
        Me.txtSQLUpdate.Location = New System.Drawing.Point(324, 602)
        Me.txtSQLUpdate.Multiline = True
        Me.txtSQLUpdate.Name = "txtSQLUpdate"
        Me.txtSQLUpdate.Size = New System.Drawing.Size(313, 26)
        Me.txtSQLUpdate.TabIndex = 10000103
        '
        'TLP
        '
        Me.TLP.ColumnCount = 4
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0!))
        Me.TLP.Controls.Add(Me.dgv2, 3, 1)
        Me.TLP.Controls.Add(Me.Panel2, 3, 0)
        Me.TLP.Controls.Add(Me.panelTabelaB, 1, 0)
        Me.TLP.Controls.Add(Me.panelTabelaA, 0, 0)
        Me.TLP.Controls.Add(Me.dgv1, 0, 1)
        Me.TLP.Controls.Add(Me.Panel3, 2, 1)
        Me.TLP.Controls.Add(Me.txtSQLUpdate, 1, 2)
        Me.TLP.Controls.Add(Me.lblDistinctCount, 0, 2)
        Me.TLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP.Location = New System.Drawing.Point(0, 0)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 3
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.25398!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.799!))
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.947019!))
        Me.TLP.Size = New System.Drawing.Size(1284, 631)
        Me.TLP.TabIndex = 10000327
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv2.Location = New System.Drawing.Point(722, 307)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(559, 289)
        Me.dgv2.TabIndex = 10000332
        Me.dgv2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bAdd)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TextBox3)
        Me.Panel2.Controls.Add(Me.ButtonISTIzlaz)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Panel2.Location = New System.Drawing.Point(722, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 298)
        Me.Panel2.TabIndex = 10000330
        '
        'bAdd
        '
        Me.bAdd.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bAdd.BackColor = System.Drawing.SystemColors.Control
        Me.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAdd.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.bAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bAdd.Location = New System.Drawing.Point(168, 129)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(70, 23)
        Me.bAdd.TabIndex = 10000093
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(14, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 18)
        Me.Label4.TabIndex = 10000104
        Me.Label4.Text = "Вредности изабраног поља за"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(14, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 22)
        Me.Label5.TabIndex = 10000099
        Me.Label5.Text = "Dodatno"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(14, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 21)
        Me.TextBox3.TabIndex = 10000092
        '
        'ButtonISTIzlaz
        '
        Me.ButtonISTIzlaz.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonISTIzlaz.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonISTIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonISTIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonISTIzlaz.Location = New System.Drawing.Point(223, 9)
        Me.ButtonISTIzlaz.Name = "ButtonISTIzlaz"
        Me.ButtonISTIzlaz.Size = New System.Drawing.Size(87, 24)
        Me.ButtonISTIzlaz.TabIndex = 10000327
        Me.ButtonISTIzlaz.Text = "Излаз"
        Me.ButtonISTIzlaz.UseVisualStyleBackColor = False
        '
        'panelTabelaB
        '
        Me.panelTabelaB.Controls.Add(Me.ButtonFieldB)
        Me.panelTabelaB.Controls.Add(Me.txtAppB)
        Me.panelTabelaB.Controls.Add(Me.bDownAppB)
        Me.panelTabelaB.Controls.Add(Me.clbAppB)
        Me.panelTabelaB.Controls.Add(Me.clbFilterB)
        Me.panelTabelaB.Controls.Add(Me.bDownTB)
        Me.panelTabelaB.Controls.Add(Me.txtTabelaB)
        Me.panelTabelaB.Controls.Add(Me.clbTabelaB)
        Me.panelTabelaB.Controls.Add(Me.ucvtB)
        Me.panelTabelaB.Controls.Add(Me.lbltabelaB)
        Me.panelTabelaB.Controls.Add(Me.lblApp)
        Me.panelTabelaB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelTabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.panelTabelaB.Location = New System.Drawing.Point(324, 3)
        Me.panelTabelaB.Name = "panelTabelaB"
        Me.panelTabelaB.Size = New System.Drawing.Size(315, 298)
        Me.panelTabelaB.TabIndex = 10000328
        '
        'ButtonFieldB
        '
        Me.ButtonFieldB.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFieldB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFieldB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFieldB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonFieldB.Image = CType(resources.GetObject("ButtonFieldB.Image"), System.Drawing.Image)
        Me.ButtonFieldB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonFieldB.Location = New System.Drawing.Point(274, 137)
        Me.ButtonFieldB.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonFieldB.Name = "ButtonFieldB"
        Me.ButtonFieldB.Size = New System.Drawing.Size(21, 21)
        Me.ButtonFieldB.TabIndex = 10000195
        Me.ButtonFieldB.UseVisualStyleBackColor = False
        Me.ButtonFieldB.Visible = False
        '
        'txtAppB
        '
        Me.txtAppB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtAppB.Location = New System.Drawing.Point(62, 63)
        Me.txtAppB.MaxLength = 20
        Me.txtAppB.Name = "txtAppB"
        Me.txtAppB.Size = New System.Drawing.Size(212, 21)
        Me.txtAppB.TabIndex = 10000192
        '
        'bDownAppB
        '
        Me.bDownAppB.BackColor = System.Drawing.Color.Transparent
        Me.bDownAppB.Image = CType(resources.GetObject("bDownAppB.Image"), System.Drawing.Image)
        Me.bDownAppB.Location = New System.Drawing.Point(274, 63)
        Me.bDownAppB.Name = "bDownAppB"
        Me.bDownAppB.Size = New System.Drawing.Size(21, 21)
        Me.bDownAppB.TabIndex = 10000193
        Me.bDownAppB.TabStop = False
        '
        'clbAppB
        '
        Me.clbAppB.BackColor = System.Drawing.SystemColors.Window
        Me.clbAppB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbAppB.CheckOnClick = True
        Me.clbAppB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbAppB.FormattingEnabled = True
        Me.clbAppB.Location = New System.Drawing.Point(62, 83)
        Me.clbAppB.Name = "clbAppB"
        Me.clbAppB.Size = New System.Drawing.Size(212, 18)
        Me.clbAppB.TabIndex = 10000191
        Me.clbAppB.Visible = False
        '
        'clbFilterB
        '
        Me.clbFilterB.BackColor = System.Drawing.SystemColors.Window
        Me.clbFilterB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbFilterB.CheckOnClick = True
        Me.clbFilterB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbFilterB.FormattingEnabled = True
        Me.clbFilterB.Location = New System.Drawing.Point(62, 137)
        Me.clbFilterB.Name = "clbFilterB"
        Me.clbFilterB.Size = New System.Drawing.Size(212, 146)
        Me.clbFilterB.TabIndex = 10000189
        Me.clbFilterB.Visible = False
        '
        'bDownTB
        '
        Me.bDownTB.BackColor = System.Drawing.Color.Transparent
        Me.bDownTB.Image = CType(resources.GetObject("bDownTB.Image"), System.Drawing.Image)
        Me.bDownTB.Location = New System.Drawing.Point(274, 100)
        Me.bDownTB.Name = "bDownTB"
        Me.bDownTB.Size = New System.Drawing.Size(21, 21)
        Me.bDownTB.TabIndex = 10000187
        Me.bDownTB.TabStop = False
        '
        'txtTabelaB
        '
        Me.txtTabelaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtTabelaB.Location = New System.Drawing.Point(62, 100)
        Me.txtTabelaB.MaxLength = 20
        Me.txtTabelaB.Name = "txtTabelaB"
        Me.txtTabelaB.Size = New System.Drawing.Size(212, 21)
        Me.txtTabelaB.TabIndex = 10000186
        '
        'clbTabelaB
        '
        Me.clbTabelaB.BackColor = System.Drawing.SystemColors.Window
        Me.clbTabelaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbTabelaB.CheckOnClick = True
        Me.clbTabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.clbTabelaB.FormattingEnabled = True
        Me.clbTabelaB.Location = New System.Drawing.Point(62, 120)
        Me.clbTabelaB.Name = "clbTabelaB"
        Me.clbTabelaB.Size = New System.Drawing.Size(212, 18)
        Me.clbTabelaB.TabIndex = 10000185
        Me.clbTabelaB.Visible = False
        '
        'ucvtB
        '
        Me.ucvtB.BackColor = System.Drawing.SystemColors.Control
        Me.ucvtB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvtB.Location = New System.Drawing.Point(62, 9)
        Me.ucvtB.Name = "ucvtB"
        Me.ucvtB.Size = New System.Drawing.Size(109, 48)
        Me.ucvtB.TabIndex = 10000188
        Me.ucvtB.TabStop = False
        '
        'lbltabelaB
        '
        Me.lbltabelaB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lbltabelaB.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbltabelaB.Location = New System.Drawing.Point(20, 101)
        Me.lbltabelaB.Name = "lbltabelaB"
        Me.lbltabelaB.Size = New System.Drawing.Size(40, 20)
        Me.lbltabelaB.TabIndex = 10000194
        Me.lbltabelaB.Text = "Table"
        Me.lbltabelaB.Visible = False
        '
        'lblApp
        '
        Me.lblApp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblApp.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblApp.Location = New System.Drawing.Point(20, 64)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(32, 26)
        Me.lblApp.TabIndex = 10000190
        Me.lblApp.Text = "App"
        Me.lblApp.Visible = False
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TLP.SetColumnSpan(Me.dgv1, 2)
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 307)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(636, 289)
        Me.dgv1.TabIndex = 10000331
        Me.dgv1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bRemove)
        Me.Panel3.Controls.Add(Me.bJoin)
        Me.Panel3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Panel3.Location = New System.Drawing.Point(645, 307)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(71, 284)
        Me.Panel3.TabIndex = 10000333
        '
        'bRemove
        '
        Me.bRemove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bRemove.BackColor = System.Drawing.SystemColors.Control
        Me.bRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bRemove.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.bRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bRemove.Location = New System.Drawing.Point(3, 210)
        Me.bRemove.Name = "bRemove"
        Me.bRemove.Size = New System.Drawing.Size(65, 23)
        Me.bRemove.TabIndex = 10000094
        Me.bRemove.Text = "Remove"
        Me.bRemove.UseVisualStyleBackColor = False
        '
        'bJoin
        '
        Me.bJoin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bJoin.BackColor = System.Drawing.SystemColors.Control
        Me.bJoin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bJoin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bJoin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bJoin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bJoin.Location = New System.Drawing.Point(3, 103)
        Me.bJoin.Name = "bJoin"
        Me.bJoin.Size = New System.Drawing.Size(65, 23)
        Me.bJoin.TabIndex = 10000095
        Me.bJoin.Text = "<=>"
        Me.bJoin.UseVisualStyleBackColor = False
        '
        'lblDistinctCount
        '
        Me.lblDistinctCount.AutoSize = True
        Me.lblDistinctCount.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblDistinctCount.Location = New System.Drawing.Point(3, 599)
        Me.lblDistinctCount.Name = "lblDistinctCount"
        Me.lblDistinctCount.Size = New System.Drawing.Size(11, 13)
        Me.lblDistinctCount.TabIndex = 10000334
        Me.lblDistinctCount.Text = "."
        '
        'FormSACodingSimple
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1284, 631)
        Me.Controls.Add(Me.TLP)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.Name = "FormSACodingSimple"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTabelaA.ResumeLayout(False)
        Me.panelTabelaA.PerformLayout()
        CType(Me.bDownAppA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDownTA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TLP.ResumeLayout(False)
        Me.TLP.PerformLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panelTabelaB.ResumeLayout(False)
        Me.panelTabelaB.PerformLayout()
        CType(Me.bDownAppB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bDownTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ttab As DatasetIstrazivanja.ISTTABSDataTable
    Dim istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Dim istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Dim istLK As DatasetIstrazivanja.ISTLKDataTable
    Dim istBaze As DatasetIstrazivanja.ISTBAZEDataTable
    Dim mrist As DatasetIstrazivanja.ISTRow

    Dim ISTConnectionString As String = ""
    Dim DBConnectionString As String = ""

    Dim putanja As String
    Dim dtSelect As New System.Data.DataTable
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String

    Dim jezik As String
    Dim txtmode As String
    Dim vtA As String
    Dim vtB As String

    Dim mvtA As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim mvtB As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka

    Dim sifistA As String
    Dim dbNameA As String
    Dim dbServerNameA As String
    Dim dbNameB As String
    Dim dbServerNameB As String

    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow, ByVal ISTConnectionString As String,
                    ByVal txtInst As String, ByVal txtPismo As String,
                    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String,
                    ByVal txt_DSBrisanjeBaza As String, ByVal txtmode As String, ByVal jezik As String)
        Me.New()

        Me.jezik = jezik
        Call SetLang()
        Me.txtmode = txtmode

        Me.Text = Me.Text + " - " + ri.Naziv.Trim
        Me.ttab = ttab

        Me.mrist = ri

        ucvtA.Init(vt) : ucvtB.Init(vt)

        Me.sifistA = ri.SIFIST.Trim
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString

        Dim bs() As String = dajBazuServer(sifistA, Me.ISTConnectionString).Split("$")
        dbNameA = bs(0) : dbServerNameA = bs(1)

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza

        Me.mvtA = ucvtA
        Me.mvtB = ucvtB

        vtA = ucvtA.G.ToString + "-" + String.Format("{0:d2}", ucvtA.M) + "-01"
        vtB = ucvtB.G.ToString + "-" + String.Format("{0:d2}", ucvtB.M) + "-01"

        Dim strSQlA As String = "select  distinct tabela as valuemember,tabela+' '+opis as displaymember from vISTTABELEzaDOK('" + vtA + "','" + Me.sifistA.ToString.Trim + "')  order by 1"

        Call fillCLB(clbTabelaA, strSQlA, Me.ISTConnectionString)

        Call srediformu()

        Me.jezik = jezik

        lbltabelaA.Visible = True
        lbltabelaA.Location = New Point(Me.Label1.Location.X, txtAppA.Location.Y + txtAppA.Height + 1)
        txtTabelaA.Location = New Point(Me.txtAppA.Location.X, txtAppA.Location.Y + txtAppA.Height + 1)
        bDownTA.Location = New Point(Me.txtTabelaA.Location.X + txtTabelaA.Width + 1, txtTabelaA.Location.Y)
        bAddTableB.Location = New Point(Me.bDownTA.Location.X + bDownTA.Width + 1, bDownTA.Location.Y)
        ButtonFieldA.Location = New Point(Me.clbFilterA.Location.X + clbFilterA.Width + 1, clbFilterA.Location.Y)

    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")

    End Sub

    Sub srediformu()
        Dim ww As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width()
        Dim hh As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height()
        Dim xx As Integer = ww - (ButtonISTIzlaz.Width + 25)
        Me.ButtonISTIzlaz.Location = New System.Drawing.Point(xx, 8)
    End Sub


    Sub fillCLB(ByVal clb As System.Windows.Forms.CheckedListBox, ByVal str As String, ByVal kkon As String)

        Dim tt As String = "NULL"
        Dim pp As String = "NULL"

        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(str, kkon, Me.jezik)
        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "valuemember"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")

        For i As Integer = 0 To dvPK.Count - 1
            If Not (dvPK(i).Item("displaymember") Is System.DBNull.Value) AndAlso Not (dvPK(i).Item("valuemember") Is System.DBNull.Value) Then
                tt = dvPK(i).Item("valuemember").ToString.Trim
                pp = dvPK(i).Item("displaymember").ToString.Trim
                dtKon.Rows.Add(New Object() {tt, pp})
            End If
        Next

        clb.DataSource = dtKon
        clb.DisplayMember = "displaymember"
        clb.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtKon)
        clb.DataSource = dv

    End Sub

    Private Sub bDownTA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bDownTA.Click
        Me.clbTabelaA.Height = Me.Height \ 5
        Me.clbTabelaA.Visible = Not Me.clbTabelaA.Visible
        Dim strSQlA As String = "select  distinct tabela as valuemember,tabela as displaymember from vISTTABELEzaDOK('" + vtA + "','" + sifistA.Trim + "') order by 1"
        If Me.clbTabelaA.Visible = True Then Me.clbTabelaA.BringToFront()
        clbTabelaA.Location = New Point(txtTabelaA.Location.X, txtTabelaA.Location.Y + txtTabelaA.Height + 1)
        Call fillCLB(clbTabelaA, strSQlA, Me.ISTConnectionString)
        Me.txtTabelaA.Text = ""
    End Sub

    Private Sub clbAppB_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAppB.ItemCheck
        Call fillApp(sender, e, vtB, clbAppB, clbTabelaB, lbltabelaB, bDownTB, txtTabelaB, txtAppB)
        lbltabelaB.Visible = True
        lbltabelaB.Location = New Point(Me.lblApp.Location.X, txtAppB.Location.Y + txtAppB.Height + 1)
        txtTabelaB.Location = New Point(Me.txtAppB.Location.X, txtAppB.Location.Y + txtAppB.Height + 1)
        bDownTB.Location = New Point(Me.txtTabelaB.Location.X + txtTabelaB.Width + 1, txtTabelaB.Location.Y)
    End Sub

    Sub fillApp(ByVal sender As Object, ByVal e As ItemCheckEventArgs,
           ByVal vt As String, ByVal clbApp As CheckedListBox, ByVal clbTabela As CheckedListBox, ByVal lbltabela As Label,
           ByVal bDownT As PictureBox, ByVal txtTabela As TextBox, ByVal txtApp As TextBox)

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To clbApp.Items.Count - 1 Step 1
                If i <> e.Index Then
                    clbApp.SetItemChecked(i, False)
                End If
            Next i
            txtApp.Text = clbApp.SelectedValue.Trim
            Dim strSQl As String = "select  distinct tabela as valuemember,tabela+' '+opis as displaymember from vISTTABELEzaDOK('" + vt + "','" + clbApp.SelectedValue.ToString.Trim.ToUpper + "')  order by 1"
            Call fillCLB(clbTabela, strSQl, Me.ISTConnectionString)
            If Not lbltabela Is Nothing Then lbltabela.Visible = True
            txtTabela.Visible = True
            bDownT.Visible = True
        End If
        clbApp.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub bDownTB_Click(sender As Object, e As EventArgs) Handles bDownTB.Click
        Call fillTable(vtB, clbAppB, txtAppB, clbTabelaB, txtTabelaB)
    End Sub

    Sub fillTable(ByVal vt As String, ByVal clbApp As CheckedListBox, ByVal txtApp As TextBox, ByVal clbTabela As CheckedListBox, ByVal txtTabela As TextBox, Optional ByVal pom As String = "")
        If pom = "" Then pom = vt + "','" + txtApp.Text.Trim.ToUpper
        Dim strSQl As String = "select  distinct tabela as valuemember,tabela as displaymember from vISTTABELEzaDOK('" + pom + "')  order by 1"
        clbTabela.Height = Me.Height \ 5
        clbTabela.Visible = Not clbTabela.Visible

        If clbTabela.Visible = True Then clbTabela.BringToFront()
        clbTabela.Location = New Point(txtTabela.Location.X, txtTabela.Location.Y + txtTabela.Height + 1)
        Call fillCLB(clbTabela, strSQl, Me.ISTConnectionString)
        txtTabela.Text = ""
    End Sub

    Private Sub txttabelaA_TextChanged(sender As Object, e As EventArgs) Handles txtTabelaA.TextChanged
        Call txtTC(clbTabelaA, txtTabelaA)
    End Sub

    Private Sub txtTabelaB_TextChanged(sender As Object, e As EventArgs) Handles txtTabelaB.TextChanged
        Call txtTC(clbTabelaB, txtTabelaB)
    End Sub

    Sub txtTC(ByVal clb As CheckedListBox, ByVal txt As TextBox)

        clb.Visible = True
        clb.BringToFront()
        Dim vred As String = txt.Text
        Dim dv As New System.Data.DataView
        dv = clb.DataSource
        If IsNumeric(vred) = False Then
            Dim vredCir As String = konverzijaLatCir(vred)
            Dim vredLat As String = konverzijaCirLat(vred)
            dv.RowFilter = "displaymember Like '%" & vredCir & "%' OR displaymember LIKE '%" & vredLat & "%'"
        Else
            dv.RowFilter = "displaymember Like '%" & vred & "%'"
        End If
        clb.DataSource = dv

        clb.Height = dv.Count * 20
        If clb.Height > Me.Height \ 4 Then clb.Height = Me.Height \ 4
    End Sub

    Private Sub bAddTableB_Click(sender As Object, e As EventArgs) Handles bAddTableB.Click
        ucvtB.Visible = True
        Call bAddApp(panelTabelaB, txtAppB, bDownAppB, txtTabelaB, bDownTB, clbTabelaB, clbFilterB, ButtonFieldB)
        Me.lblApp.Visible = True
    End Sub

    Private Sub txtAppB_TextChanged(sender As Object, e As EventArgs) Handles txtAppB.TextChanged
        Call txtTC(clbAppB, txtAppB)
    End Sub

    Private Sub bAddApp(ByVal panelTabela As Panel, ByVal txtApp As TextBox, ByVal bDownApp As PictureBox,
                        ByVal txtTabela As TextBox, ByVal bDownT As PictureBox, ByVal clbTabela As CheckedListBox,
                        ByVal clbFilter As CheckedListBox, ByVal ButtonField As Button)
        panelTabela.Visible = True
        txtApp.Visible = True
        bDownApp.Visible = True
        txtTabela.Visible = False
        bDownT.Visible = False
        clbTabela.Visible = False
        Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST order by 1"
        Call fillCLB(clbAppB, strSQl, Me.ISTConnectionString)

    End Sub

    Private Sub clbTabelaA_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbTabelaA.ItemCheck

        clbFilterA.Location = New Point(Me.txtTabelaA.Location.X, txtTabelaA.Location.Y + txtTabelaA.Height + 1)
        Me.txtAppA.Text = sifistA
        Call tabelaIC(sender, e, "A", vtA, txtAppA, clbAppA, txtTabelaA, clbFilterA, bDownTA, ButtonFieldA)

        bAddTableB.Visible = True
    End Sub

    Private Sub clbTabelaB_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbTabelaB.ItemCheck

        clbFilterB.Location = New Point(Me.txtTabelaB.Location.X, txtTabelaB.Location.Y + txtTabelaB.Height + 1)
        Call tabelaIC(sender, e, "B", vtB, txtAppB, clbAppB, txtTabelaB, clbFilterB, bDownTB, ButtonFieldB)

    End Sub

    Private Sub ButtonFieldA_Click(sender As Object, e As EventArgs) Handles ButtonFieldA.Click
        Call part(clbFilterA, clbTabelaA, ucvtA, sifistA.ToString.Trim.ToUpper, dgv1)
    End Sub

    Private Sub ButtonFieldB_Click(sender As Object, e As EventArgs) Handles ButtonFieldB.Click
        Call part(clbFilterB, clbTabelaB, ucvtB, txtAppB.Text.Trim.ToUpper, dgv2)
    End Sub

    Dim iscombobox As Integer
    Dim iizraz As String = ""
    Dim ppolje As String = ""
    Dim cCBOprikazi As String = ""
    Dim cCBOprikaziO As String = ""
    Dim ccboFilter As String = ""
    Dim cCBOubazu As String = ""
    Dim ttabela As String = ""
    Dim cCBOtabela As String = ""
    Dim cCBOtabelaIzraz As String = ""

    Dim fieldsPart As String
    Dim fromPart As String

    Sub part(ByVal clbFilter As CheckedListBox, ByVal clbTabela As CheckedListBox,
           ByVal ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal sifist As String, ByVal dgv As DataGridView)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If clbFilter.CheckedItems.Count = 0 Then
            ISTMessageBox.Show("Please, choose fields for filtering by ")
            clbFilter.Focus()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        Else
            Dim dv As DataView = clbFilter.DataSource
            Dim notIn As String = ""
            ttabela = clbTabela.SelectedValue.Trim

            Dim pomDTbl As DataTable = Nothing
            pomDTbl = dv.ToTable()
            Dim dvq As New DataView(pomDTbl)

            Dim vrt As String = imaGODMES(dvq, ttabela)

            Dim strTP As String = ""
            If vrt <> "" AndAlso vrt.IndexOf("GOD") > -1 Then strTP = strTP + " and god='" + ucvt.G.ToString + "'"
            If vrt <> "" AndAlso vrt.IndexOf("MES") > -1 Then strTP = strTP + " and mes='" + String.Format("{0:d2}", ucvt.M) + "'"
            If vrt <> "" AndAlso vrt.IndexOf("ISTYEAR") > -1 Then strTP = strTP + " and ISTYEAR='" + ucvt.G.ToString + "'"
            If vrt <> "" AndAlso vrt.IndexOf("ISTMONTH") > -1 Then strTP = strTP + " and ISTMONTH=''" + String.Format("{0:d2}", ucvt.M) + "'"

            fieldsPart = ""

            If strTP <> "" Then
                fromPart = "(select * from " + ttabela + " where 2=2 " & strTP + " )  as " + ttabela
            Else
                fromPart = ttabela
            End If

            For Each itemChecked As Object In clbFilter.CheckedItems
                Dim si As Integer = clbFilter.Items.IndexOf(itemChecked)
                Dim dvrow As DataRow = dv(si).Row

                If dvrow.Item("combobox").ToString = "1" Then
                    'iscombobox = 1
                    ppolje = dvrow.Item("polje").ToString
                    cCBOprikazi = dvrow.Item("CBOprikazi").ToString
                    cCBOprikaziO = dvrow.Item("CBOprikazio").ToString
                    cCBOubazu = dvrow.Item("CBOubazu").ToString
                    ttabela = dvrow.Item("tabela").ToString
                    iizraz = dvrow.Item("izraz").ToString
                    cCBOtabela = dvrow.Item("CBOtabela").ToString
                    ccboFilter = srediFilter(dvrow.Item("izraz").ToString)
                    cCBOtabelaIzraz = CBOdatasource(dvrow.Item("izraz").ToString)
                    If cCBOtabelaIzraz.Trim.IndexOf("(") < 0 AndAlso cCBOtabelaIzraz.Trim.ToUpper.IndexOf("SELECT") = 0 Then cCBOtabelaIzraz = "(" + cCBOtabelaIzraz + ")"

                    If fieldsPart.Trim.ToUpper.IndexOf(ttabela.Trim.ToUpper + "." + ppolje.Trim.ToUpper & ",") < 0 Then
                        fieldsPart = fieldsPart & ttabela + "." + ppolje & "," + cCBOtabela + "." + cCBOprikaziO + ","
                    ElseIf fieldsPart.Trim.ToUpper.IndexOf(cCBOtabela.Trim.ToUpper + "." + cCBOprikaziO.ToUpper & ",") < 0 Then
                        fieldsPart = fieldsPart & cCBOtabela + "." + cCBOprikaziO + ","
                    End If

                    If fromPart.Trim.ToUpper.IndexOf(cCBOtabelaIzraz.Trim.ToUpper & " AS ") < 0 Then
                        fromPart = fromPart + " inner join " + cCBOtabelaIzraz + " as " + cCBOtabela + " on " + ccboFilter + " and " + ttabela + "." + ppolje + "=" + cCBOtabela + "." + cCBOubazu
                    End If
                Else
                    'iscombobox = 0
                    If fieldsPart.Trim.ToUpper.IndexOf(ttabela.Trim.ToUpper + "." + dvrow.Item("valuemember").ToString.Trim.ToUpper & ",") < 0 Then fieldsPart = fieldsPart & ttabela + "." + dvrow.Item("valuemember").ToString.Trim.ToUpper & ","
                End If

                notIn = notIn + "'" & dvrow.Item("valuemember").ToString.Trim.ToUpper & "',"

            Next

            notIn = notIn + "$"
            notIn = " and polje not in (" + notIn.Replace(",$", ")")

            fieldsPart = (fieldsPart + "$").Replace(",$", "")
            Dim str As String = "select distinct " + fieldsPart + " from " + fromPart + " order by " + fieldsPart

            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            Dim dt As New System.Data.DataTable
            Dim sql As String = " select pravaBaza,konekcija,naziv,periodika,server from vBazaServer where sifist='" + sifist + "'"

            Try
                dt = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try


            Dim dbName As String = dt.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim
            Dim dbServerName As String = dt.Rows(0).Item("server").ToString.ToUpper.Trim

            Dim dgvConn As String = getConnectionString(dbServerName, dbName, txtmode, Me.DBConnectionString)

            Call dgvv(dgv, dgvConn, str)

            lblDistinctCount.Text = "Distinct Count - " & dgv1.Rows.Count.ToString
            lblDistinctCount.Visible = True
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Sub dgvv(ByVal dgv As DataGridView, ByVal dgvConn As String, ByVal str As String)
        Call popuniDGridView(dgv, dgvConn, str, Me.jezik)
        Call srediGridView(dgv, False, 30)
        Call nijeZaSort(dgv)
        dgv.Visible = True
    End Sub

    Function CBOdatasource(ByVal izraz As String) As String
        Dim str As String = ""
        If izraz.Length > 0 Then
            izraz = zamena(izraz)
            If izraz Is Nothing Then izraz = ""
        End If

        Dim izvorCBO As String = ""
        Dim prikaziCBO As String = ""
        Dim upisiCBO As String = ""
        Dim prenesiCBO As String = ""
        CBOdatasource = ""
        Dim sta As String = izraz.Trim
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        sta = sta.Substring(0, sta.Length - 1)
        sta = sta.Replace("}", "")
        Dim nizCB As String() = Microsoft.VisualBasic.Split(sta, ";")
        For ii As Integer = 0 To nizCB.GetUpperBound(0)
            If nizCB(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                CBOdatasource = nizCB(ii).Replace("IZVOR=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                CBOdatasource = nizCB(ii).Replace("DATASOURCE=", "")
            End If
        Next

    End Function

    Private Sub bDownAppB_Click(sender As Object, e As EventArgs) Handles bDownAppB.Click
        Call bAddTable(clbAppB, txtAppB, "'" + sifistA + "'")
    End Sub

    Private Sub bAddTable(ByVal clbApp As CheckedListBox, ByVal txtApp As TextBox, ByVal sifreist As String)
        clbApp.Height = Me.Height \ 4
        clbApp.Visible = Not clbApp.Visible
        ' Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST where appcode not in (" + sifreist + ") order by 1"
        Dim strSQl As String = "select distinct appCode as displaymember,appCode as valuemember from _IST   order by 1"
        If clbApp.Visible = True Then clbApp.BringToFront()
        Call fillCLB(clbApp, strSQl, Me.ISTConnectionString)
        txtApp.Text = ""
    End Sub

    Function srediFilter(ByVal izraz As String) As String

        If izraz.Length > 0 Then
            izraz = zamena(izraz)
            If izraz Is Nothing Then izraz = ""
        End If
        Dim filterCBO As String = ""
        Dim sta As String = izraz.Trim
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        sta = sta.Substring(0, sta.Length - 1)
        sta = sta.Replace("}", "")

        Dim nizCB As String() = Microsoft.VisualBasic.Split(sta, ";")
        For ii As Integer = 0 To nizCB.GetUpperBound(0)
            If nizCB(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                filterCBO = nizCB(ii).Replace("FILTER=", "") 'naselje_maticni_broj=d.sif_Naselja
                Dim pp() As String = filterCBO.Split("=")
                Dim ff As String = ""
                Dim poc As String = ""
                For i As Integer = 0 To pp.GetUpperBound(0)
                    If pp(i).Trim.ToUpper.IndexOf("D.") = 0 Then
                        pp(i) = ttabela + "." + pp(i).Trim.ToUpper.Replace("D.", "")
                    Else
                        pp(i) = cCBOtabela + "." + pp(i)
                    End If
                Next
                izraz = pp(0) + "=" + pp(1)
            End If
        Next
        If filterCBO = "" Then
            srediFilter = "2=2"
        Else
            srediFilter = izraz
        End If

    End Function

    Function zamena(ByVal sta As String) As String

        sta = sta.ToUpper.Trim
        sta = Replace(sta, "MULTILINE", "", 1, , CompareMethod.Text)
        sta = Replace(sta, "FONTBOLD", "", 1, , CompareMethod.Text)
        sta = Replace(sta, "BORDERNONE", "", 1, , CompareMethod.Text)
        sta = Replace(sta, "BORDERFIXED", "", 1, , CompareMethod.Text)
        sta = Replace(sta.Trim, "READONLY", "", 1, , CompareMethod.Text)
        sta = Replace(sta.Trim, "PDESNOP", "", 1, , CompareMethod.Text)
        sta = Replace(sta.Trim, "FRIGHTA", "", 1, , CompareMethod.Text)
        sta = sta.Replace("CBO{", "")
        sta = sta.Replace("CBW{", "")
        If sta.Length > 0 Then sta = sta.Substring(0, sta.Length - 1)
        'sta = sta.Replace("}", "")
        'zamena GGGMMM
        sta = sta.Trim.ToUpper
        sta = strrpl(sta, "{GGG}", "'" + Me.mvtA.G.ToString + "'")
        sta = strrpl(sta, "{MMM}", "'" + String.Format("{0:d2}", Me.mvtA.M) + "'")
        sta = strrpl(sta, "{YYY}", "'" + Me.mvtA.G.ToString + "'")

        sta = GGMMGoreDole(sta, Me.mvtA.G, Me.mvtA.M)
        sta = strrpl(sta, "VRTACKA", Me.mvtA.vtwhere(""))
        sta = strrpl(sta, "GGG", Me.mvtA.GWhere(""))
        sta = strrpl(sta, "MMM", Me.mvtA.mWhere(""))
        sta = strrpl(sta, "YYY", Me.mvtA.YWhere(""))

        sta = sta.Replace(ChrW(26), "")
        Return sta
    End Function

    Function fillPolja(ByVal tabela As String, ByVal clb As System.Windows.Forms.CheckedListBox, ByVal str As String, ByVal kkon As String) As DataView
        'polje as valuemember,polje + ' ' + replace(opispom,'$','') as displaymember,combobox,izraz,cbotabela,cboprikazi,cboubazu,cbofilter,rbr
        Dim tt As String = "NULL"
        Dim pp As String = "NULL"

        Dim d2 As String = "NULL"
        Dim d3 As String = "NULL"
        Dim d4 As String = "NULL"
        Dim d5 As String = "NULL"
        Dim d6 As String = "NULL"
        Dim d7 As String = "NULL"
        Dim d8 As String = "NULL"
        Dim d9 As String = "NULL"
        Dim d10 As String = "NULL"
        Dim d11 As String = "NULL"

        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(str, kkon, Me.jezik)
        Dim dvPK As New System.Data.DataView(dt)
        dvPK.Sort = "rbr"
        Dim dtKon As New System.Data.DataTable
        dtKon.Columns.Add("valuemember")
        dtKon.Columns.Add("displaymember")

        dtKon.Columns.Add("combobox")
        dtKon.Columns.Add("izraz")
        dtKon.Columns.Add("cbotabela")
        dtKon.Columns.Add("cboprikazi")
        dtKon.Columns.Add("cboubazu")
        dtKon.Columns.Add("cbofilter")

        dtKon.Columns.Add("polje")
        dtKon.Columns.Add("tabela")
        dtKon.Columns.Add("cboprikaziO")
        dtKon.Columns.Add("opisPom")
        dtKon.Columns.Add("tabdisplaymember")

        For i As Integer = 0 To dvPK.Count - 1
            'uvek
            If Not (dvPK(i).Item("valuemember") Is System.DBNull.Value) Then tt = dvPK(i).Item("valuemember").ToString.Trim
            If Not (dvPK(i).Item("displaymember") Is System.DBNull.Value) Then pp = dvPK(i).Item("displaymember").ToString.Trim
            If Not (dvPK(i).Item("tabela") Is System.DBNull.Value) Then d8 = dvPK(i).Item("tabela").ToString.Trim
            If Not (dvPK(i).Item("opisPom") Is System.DBNull.Value) Then d10 = dvPK(i).Item("opisPom").ToString.Trim
            If Not (dvPK(i).Item("polje") Is System.DBNull.Value) Then d7 = dvPK(i).Item("polje").ToString.Trim

            dtKon.Rows.Add(New Object() {tt, pp, "0", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", tabela + "." + pp})

            'cbo
            If Not dvPK(i).Item("combobox") Is System.DBNull.Value AndAlso dvPK(i).Item("combobox").ToString.Trim = "1" Then
                If Not (dvPK(i).Item("cboubazu") Is System.DBNull.Value) Then tt = dvPK(i).Item("cboubazu").ToString.Trim
                If Not (dvPK(i).Item("cboprikazi") Is System.DBNull.Value) Then pp = dvPK(i).Item("cboprikazi").ToString.Trim
                If Not (dvPK(i).Item("izraz") Is System.DBNull.Value) Then d2 = dvPK(i).Item("izraz").ToString.Trim
                If Not (dvPK(i).Item("cbotabela") Is System.DBNull.Value) Then d3 = dvPK(i).Item("cbotabela").ToString.Trim
                If Not (dvPK(i).Item("cboprikazi") Is System.DBNull.Value) Then d4 = dvPK(i).Item("cboprikazi").ToString.Trim
                If Not (dvPK(i).Item("cboubazu") Is System.DBNull.Value) Then d5 = dvPK(i).Item("cboubazu").ToString.Trim
                If Not (dvPK(i).Item("cbofilter") Is System.DBNull.Value) Then d6 = dvPK(i).Item("cbofilter").ToString.Trim
                If Not (dvPK(i).Item("cboprikaziO") Is System.DBNull.Value) Then d9 = dvPK(i).Item("cboprikaziO").ToString.Trim '& "_" & CStr(i).Trim

                dtKon.Rows.Add(New Object() {tt, d9, "1", d2, d3, d4, d5, d6, d7, d8, d9, d10, tabela + "." + d9})
            End If
        Next

        clb.DataSource = dtKon
        clb.DisplayMember = "displaymember"
        clb.ValueMember = "valuemember"

        Dim dv As New System.Data.DataView(dtKon)
        clb.DataSource = dv

        fillPolja = dv

    End Function

    Function imaGODMES(ByVal dv As DataView, ByVal tabela As String) As String
        Dim imaG As Boolean = False
        Dim imaM As Boolean = False
        Dim imaGE As Boolean = False
        Dim imaME As Boolean = False

        Dim imaK As Boolean = False
        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dvG As New System.Data.DataView
        dvG = dv
        dvG.RowFilter = "valuemember='GOD'"
        If dvG.Count = 1 Then imaG = True
        Dim dvM As New System.Data.DataView
        dvM = dv
        dvM.RowFilter = "valuemember='MES'"
        If dvM.Count = 1 Then imaM = True

        Dim dvGE As New System.Data.DataView
        dvGE = dv
        dvGE.RowFilter = "valuemember='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = True
        Dim dvME As New System.Data.DataView
        dvME = dv
        dvME.RowFilter = "valuemember='ISTMONTH'"
        If dvME.Count = 1 Then imaME = True

        If imaG = True Then s = s + "$GOD$"
        If imaM = True Then s = s + "$MES$"
        If imaGE = True Then s = s + "$ISTYEAR$"
        If imaME = True Then s = s + "$ISTMONTH$"

        imaGODMES = s
    End Function

    Dim dvPKA As New DataView
    Dim dvPKARBR As New DataView

    Dim dvPKB As New DataView
    Dim dvPKBRBR As New DataView

    Sub tabelaIC(sender As Object, e As ItemCheckEventArgs, ByVal slovo As String, ByVal vt As String, ByVal txtApp As TextBox, ByVal clbApp As CheckedListBox,
               ByVal txtTabela As TextBox, ByVal clbFilter As CheckedListBox, ByVal bDownT As PictureBox,
               ByVal ButtonField As Button, Optional pom As String = "")
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim clbtabela As CheckedListBox = DirectCast(sender, CheckedListBox)

        If e.NewValue = CheckState.Checked Then
            For i As Integer = 0 To clbtabela.Items.Count - 1 Step 1
                If i <> e.Index Then
                    clbtabela.SetItemChecked(i, False)
                End If
            Next i

            txtTabela.Text = clbtabela.SelectedValue.ToString.Trim
            If pom = "" Then pom = vt + "','" + txtApp.Text.Trim.ToUpper

            Dim strSQL1 As String = "select distinct polje as valuemember,polje as displaymember,tabela, polje, Replace(Replace(opispom,'$',''),' ','_') as opispom," +
                     "combobox,izraz,cbotabela,cboprikazi As cboprikaziO," +
                     "cboprikazi+ ' ' + replace(opispom,'$','') as cboprikazi,cboubazu,cbofilter,rbr " +
                     "from vISTPoljaKonsultTabela('" + pom + "','" + txtTabela.Text.Trim + "') " +
                     "where tipPolja<>'LBL' order by rbr"
            If slovo = "A" Then
                dvPKARBR = fillPolja(slovo, clbFilter, strSQL1, Me.ISTConnectionString)
            End If
            Dim bs() As String = dajBazuServer(txtApp.Text, Me.ISTConnectionString).Split("$")
            If slovo = "B" Then
                dvPKBRBR = fillPolja(slovo, clbFilter, strSQL1, Me.ISTConnectionString)
                dbNameB = bs(0) : dbServerNameB = bs(1)
            End If

            Dim strSQL2 As String = "select distinct polje as valuemember,polje as displaymember,tabela, polje, Replace(Replace(opispom,'$',''),' ','_') as opispom," +
                     "combobox,izraz,cbotabela,cboprikazi As cboprikaziO," +
                     "cboprikazi+ ' ' + replace(opispom,'$','') as cboprikazi,cboubazu,cbofilter " +
                     "from vISTPoljaKonsultTabela('" + pom + "','" + txtTabela.Text.Trim + "') " +
                     "where tipPolja<>'LBL' order by 1"

            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(strSQL2, Me.ISTConnectionString, Me.jezik)
            If slovo = "A" Then dvPKA = dt.AsDataView
            If slovo = "B" Then dvPKB = dt.AsDataView

            For i As Integer = 0 To clbFilter.Items.Count - 1 Step 1
                clbFilter.SetItemChecked(i, False)
            Next i

            clbFilter.Visible = True
            clbFilter.Width = clbtabela.Width - bDownT.Width

            ButtonField.Visible = True
            ButtonField.Location = New Point(clbFilter.Location.X + clbFilter.Width + 1, clbFilter.Location.Y)
        End If
        clbtabela.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub nijeZaSort(ByVal dg As DataGridView)
        Dim dt As DataTable = dg.DataSource
        For i As Integer = 0 To dg.Columns.Count - 1
            Dim kolTip As String = dt.Columns(i).DataType.Name
            If Not (kolTip = "Boolean" OrElse kolTip = "Char" OrElse kolTip = "DateTime" OrElse kolTip = "Guid" OrElse kolTip = "String" OrElse kolTip = "TimeSpan") Then
                dg.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            dg.Columns.Item(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next i
    End Sub

End Class