'Option Strict Off

Public Class mFormInsertMultiCheckB
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

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents l1 As Label
    Friend WithEvents chbc1 As CheckBox
    Friend WithEvents cbc1 As ComboBox
    Friend WithEvents cbc2 As ComboBox
    Friend WithEvents chbc2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbc2 As TextBox
    Friend WithEvents cbc3 As ComboBox
    Friend WithEvents chbc3 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbc3 As TextBox
    Friend WithEvents cbc4 As ComboBox
    Friend WithEvents chbc4 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbc4 As TextBox
    Friend WithEvents cbc5 As ComboBox
    Friend WithEvents chbc5 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbc5 As TextBox
    Friend WithEvents cbc6 As ComboBox
    Friend WithEvents chbc6 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbc6 As TextBox
    Friend WithEvents cbc7 As ComboBox
    Friend WithEvents chbc7 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbc7 As TextBox
    Friend WithEvents cbc8 As ComboBox
    Friend WithEvents chbc8 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbc8 As TextBox
    Friend WithEvents cbc9 As ComboBox
    Friend WithEvents chbc9 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbc9 As TextBox
    Friend WithEvents cbc10 As ComboBox
    Friend WithEvents chbc10 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbc10 As TextBox
    Friend WithEvents cbc11 As ComboBox
    Friend WithEvents chbc11 As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbc11 As TextBox
    Friend WithEvents ComboBox11 As ComboBox
    Friend WithEvents chbc12 As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbc12 As TextBox
    Friend WithEvents cbc13 As ComboBox
    Friend WithEvents chbc13 As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbc13 As TextBox
    Friend WithEvents cbc14 As ComboBox
    Friend WithEvents chbc14 As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbc14 As TextBox
    Friend WithEvents cbc15 As ComboBox
    Friend WithEvents chbc15 As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbc15 As TextBox
    Friend WithEvents cbc16 As ComboBox
    Friend WithEvents chbc16 As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbc16 As TextBox
    Friend WithEvents cbc17 As ComboBox
    Friend WithEvents chbc17 As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tbc17 As TextBox
    Friend WithEvents cbc18 As ComboBox
    Friend WithEvents chbc18 As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tbc18 As TextBox
    Friend WithEvents cbc19 As ComboBox
    Friend WithEvents chbc19 As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tbc19 As TextBox
    Friend WithEvents cbc20 As ComboBox
    Friend WithEvents chbc20 As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tbc20 As TextBox
    Friend WithEvents cbc21 As ComboBox
    Friend WithEvents chbc21 As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents tbc21 As TextBox
    Friend WithEvents cbc22 As ComboBox
    Friend WithEvents chbc22 As CheckBox
    Friend WithEvents Label26 As Label
    Friend WithEvents tbc22 As TextBox
    Friend WithEvents cbc23 As ComboBox
    Friend WithEvents chbc23 As CheckBox
    Friend WithEvents Label27 As Label
    Friend WithEvents tbc23 As TextBox
    Friend WithEvents cbc24 As ComboBox
    Friend WithEvents chbc24 As CheckBox
    Friend WithEvents Label28 As Label
    Friend WithEvents tbc24 As TextBox
    Friend WithEvents cbc25 As ComboBox
    Friend WithEvents chbc25 As CheckBox
    Friend WithEvents Label29 As Label
    Friend WithEvents tbc25 As TextBox
    Friend WithEvents cbc26 As ComboBox
    Friend WithEvents chbc26 As CheckBox
    Friend WithEvents Label30 As Label
    Friend WithEvents tbc26 As TextBox
    Friend WithEvents cbc27 As ComboBox
    Friend WithEvents chbc27 As CheckBox
    Friend WithEvents Label31 As Label
    Friend WithEvents tbc27 As TextBox
    Friend WithEvents cbc28 As ComboBox
    Friend WithEvents chbc28 As CheckBox
    Friend WithEvents Label32 As Label
    Friend WithEvents tbc28 As TextBox
    Friend WithEvents cbc29 As ComboBox
    Friend WithEvents chbc29 As CheckBox
    Friend WithEvents Label33 As Label
    Friend WithEvents tbc29 As TextBox
    Friend WithEvents cbc30 As ComboBox
    Friend WithEvents chbc30 As CheckBox
    Friend WithEvents Label34 As Label
    Friend WithEvents tbc30 As TextBox
    Friend WithEvents btnFormat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents tbc1 As TextBox

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnFormat = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.l1 = New System.Windows.Forms.Label()
        Me.chbc1 = New System.Windows.Forms.CheckBox()
        Me.tbc1 = New System.Windows.Forms.TextBox()
        Me.cbc1 = New System.Windows.Forms.ComboBox()
        Me.cbc2 = New System.Windows.Forms.ComboBox()
        Me.chbc2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbc2 = New System.Windows.Forms.TextBox()
        Me.cbc3 = New System.Windows.Forms.ComboBox()
        Me.chbc3 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbc3 = New System.Windows.Forms.TextBox()
        Me.cbc4 = New System.Windows.Forms.ComboBox()
        Me.chbc4 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbc4 = New System.Windows.Forms.TextBox()
        Me.cbc5 = New System.Windows.Forms.ComboBox()
        Me.chbc5 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbc5 = New System.Windows.Forms.TextBox()
        Me.cbc6 = New System.Windows.Forms.ComboBox()
        Me.chbc6 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbc6 = New System.Windows.Forms.TextBox()
        Me.cbc7 = New System.Windows.Forms.ComboBox()
        Me.chbc7 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbc7 = New System.Windows.Forms.TextBox()
        Me.cbc8 = New System.Windows.Forms.ComboBox()
        Me.chbc8 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbc8 = New System.Windows.Forms.TextBox()
        Me.cbc9 = New System.Windows.Forms.ComboBox()
        Me.chbc9 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbc9 = New System.Windows.Forms.TextBox()
        Me.cbc10 = New System.Windows.Forms.ComboBox()
        Me.chbc10 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbc10 = New System.Windows.Forms.TextBox()
        Me.cbc11 = New System.Windows.Forms.ComboBox()
        Me.chbc11 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbc11 = New System.Windows.Forms.TextBox()
        Me.ComboBox11 = New System.Windows.Forms.ComboBox()
        Me.chbc12 = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbc12 = New System.Windows.Forms.TextBox()
        Me.cbc13 = New System.Windows.Forms.ComboBox()
        Me.chbc13 = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbc13 = New System.Windows.Forms.TextBox()
        Me.cbc14 = New System.Windows.Forms.ComboBox()
        Me.chbc14 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbc14 = New System.Windows.Forms.TextBox()
        Me.cbc15 = New System.Windows.Forms.ComboBox()
        Me.chbc15 = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbc15 = New System.Windows.Forms.TextBox()
        Me.cbc16 = New System.Windows.Forms.ComboBox()
        Me.chbc16 = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbc16 = New System.Windows.Forms.TextBox()
        Me.cbc17 = New System.Windows.Forms.ComboBox()
        Me.chbc17 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbc17 = New System.Windows.Forms.TextBox()
        Me.cbc18 = New System.Windows.Forms.ComboBox()
        Me.chbc18 = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbc18 = New System.Windows.Forms.TextBox()
        Me.cbc19 = New System.Windows.Forms.ComboBox()
        Me.chbc19 = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbc19 = New System.Windows.Forms.TextBox()
        Me.cbc20 = New System.Windows.Forms.ComboBox()
        Me.chbc20 = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbc20 = New System.Windows.Forms.TextBox()
        Me.cbc21 = New System.Windows.Forms.ComboBox()
        Me.chbc21 = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbc21 = New System.Windows.Forms.TextBox()
        Me.cbc22 = New System.Windows.Forms.ComboBox()
        Me.chbc22 = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbc22 = New System.Windows.Forms.TextBox()
        Me.cbc23 = New System.Windows.Forms.ComboBox()
        Me.chbc23 = New System.Windows.Forms.CheckBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.tbc23 = New System.Windows.Forms.TextBox()
        Me.cbc24 = New System.Windows.Forms.ComboBox()
        Me.chbc24 = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbc24 = New System.Windows.Forms.TextBox()
        Me.cbc25 = New System.Windows.Forms.ComboBox()
        Me.chbc25 = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbc25 = New System.Windows.Forms.TextBox()
        Me.cbc26 = New System.Windows.Forms.ComboBox()
        Me.chbc26 = New System.Windows.Forms.CheckBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.tbc26 = New System.Windows.Forms.TextBox()
        Me.cbc27 = New System.Windows.Forms.ComboBox()
        Me.chbc27 = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbc27 = New System.Windows.Forms.TextBox()
        Me.cbc28 = New System.Windows.Forms.ComboBox()
        Me.chbc28 = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tbc28 = New System.Windows.Forms.TextBox()
        Me.cbc29 = New System.Windows.Forms.ComboBox()
        Me.chbc29 = New System.Windows.Forms.CheckBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbc29 = New System.Windows.Forms.TextBox()
        Me.cbc30 = New System.Windows.Forms.ComboBox()
        Me.chbc30 = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.tbc30 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Insert Multiresponse"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 747)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(887, 30)
        Me.Panel1.TabIndex = 38
        '
        'btnFormat
        '
        Me.btnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnFormat.Location = New System.Drawing.Point(563, 3)
        Me.btnFormat.Name = "btnFormat"
        Me.btnFormat.Size = New System.Drawing.Size(89, 24)
        Me.btnFormat.TabIndex = 472
        Me.btnFormat.TabStop = False
        Me.btnFormat.Text = "Insert"
        Me.btnFormat.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(887, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(362, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 50)
        Me.Label8.TabIndex = 296
        Me.Label8.Text = "Add control after choice"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(42, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(250, 50)
        Me.Label9.TabIndex = 297
        Me.Label9.Text = "Choices"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(293, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 50)
        Me.Label4.TabIndex = 349
        Me.Label4.Text = "Start new column"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 50)
        Me.Label2.TabIndex = 350
        Me.Label2.Text = "No"
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(6, 87)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(30, 20)
        Me.l1.TabIndex = 353
        Me.l1.Text = "1"
        '
        'chbc1
        '
        Me.chbc1.AccessibleName = ""
        Me.chbc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc1.Location = New System.Drawing.Point(306, 87)
        Me.chbc1.Name = "chbc1"
        Me.chbc1.Size = New System.Drawing.Size(35, 20)
        Me.chbc1.TabIndex = 273
        Me.chbc1.Visible = False
        '
        'tbc1
        '
        Me.tbc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc1.Location = New System.Drawing.Point(42, 87)
        Me.tbc1.Name = "tbc1"
        Me.tbc1.Size = New System.Drawing.Size(250, 20)
        Me.tbc1.TabIndex = 353
        '
        'cbc1
        '
        Me.cbc1.DropDownWidth = 150
        Me.cbc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc1.FormattingEnabled = True
        Me.cbc1.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc1.Location = New System.Drawing.Point(362, 87)
        Me.cbc1.Name = "cbc1"
        Me.cbc1.Size = New System.Drawing.Size(89, 22)
        Me.cbc1.TabIndex = 354
        '
        'cbc2
        '
        Me.cbc2.DropDownWidth = 150
        Me.cbc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc2.FormattingEnabled = True
        Me.cbc2.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc2.Location = New System.Drawing.Point(362, 109)
        Me.cbc2.Name = "cbc2"
        Me.cbc2.Size = New System.Drawing.Size(89, 22)
        Me.cbc2.TabIndex = 358
        '
        'chbc2
        '
        Me.chbc2.AccessibleName = ""
        Me.chbc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc2.Location = New System.Drawing.Point(306, 109)
        Me.chbc2.Name = "chbc2"
        Me.chbc2.Size = New System.Drawing.Size(35, 20)
        Me.chbc2.TabIndex = 355
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 356
        Me.Label3.Text = "2"
        '
        'tbc2
        '
        Me.tbc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc2.Location = New System.Drawing.Point(42, 109)
        Me.tbc2.Name = "tbc2"
        Me.tbc2.Size = New System.Drawing.Size(250, 20)
        Me.tbc2.TabIndex = 357
        '
        'cbc3
        '
        Me.cbc3.DropDownWidth = 150
        Me.cbc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc3.FormattingEnabled = True
        Me.cbc3.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc3.Location = New System.Drawing.Point(362, 131)
        Me.cbc3.Name = "cbc3"
        Me.cbc3.Size = New System.Drawing.Size(89, 22)
        Me.cbc3.TabIndex = 362
        '
        'chbc3
        '
        Me.chbc3.AccessibleName = ""
        Me.chbc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc3.Location = New System.Drawing.Point(306, 131)
        Me.chbc3.Name = "chbc3"
        Me.chbc3.Size = New System.Drawing.Size(35, 20)
        Me.chbc3.TabIndex = 359
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 360
        Me.Label5.Text = "3"
        '
        'tbc3
        '
        Me.tbc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc3.Location = New System.Drawing.Point(42, 131)
        Me.tbc3.Name = "tbc3"
        Me.tbc3.Size = New System.Drawing.Size(250, 20)
        Me.tbc3.TabIndex = 361
        '
        'cbc4
        '
        Me.cbc4.DropDownWidth = 150
        Me.cbc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc4.FormattingEnabled = True
        Me.cbc4.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc4.Location = New System.Drawing.Point(362, 153)
        Me.cbc4.Name = "cbc4"
        Me.cbc4.Size = New System.Drawing.Size(89, 22)
        Me.cbc4.TabIndex = 366
        '
        'chbc4
        '
        Me.chbc4.AccessibleName = ""
        Me.chbc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc4.Location = New System.Drawing.Point(306, 153)
        Me.chbc4.Name = "chbc4"
        Me.chbc4.Size = New System.Drawing.Size(35, 20)
        Me.chbc4.TabIndex = 363
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 364
        Me.Label6.Text = "4"
        '
        'tbc4
        '
        Me.tbc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc4.Location = New System.Drawing.Point(42, 153)
        Me.tbc4.Name = "tbc4"
        Me.tbc4.Size = New System.Drawing.Size(250, 20)
        Me.tbc4.TabIndex = 365
        '
        'cbc5
        '
        Me.cbc5.DropDownWidth = 150
        Me.cbc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc5.FormattingEnabled = True
        Me.cbc5.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc5.Location = New System.Drawing.Point(362, 175)
        Me.cbc5.Name = "cbc5"
        Me.cbc5.Size = New System.Drawing.Size(89, 22)
        Me.cbc5.TabIndex = 370
        '
        'chbc5
        '
        Me.chbc5.AccessibleName = ""
        Me.chbc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc5.Location = New System.Drawing.Point(306, 175)
        Me.chbc5.Name = "chbc5"
        Me.chbc5.Size = New System.Drawing.Size(35, 20)
        Me.chbc5.TabIndex = 367
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 368
        Me.Label7.Text = "5"
        '
        'tbc5
        '
        Me.tbc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc5.Location = New System.Drawing.Point(42, 175)
        Me.tbc5.Name = "tbc5"
        Me.tbc5.Size = New System.Drawing.Size(250, 20)
        Me.tbc5.TabIndex = 369
        '
        'cbc6
        '
        Me.cbc6.DropDownWidth = 150
        Me.cbc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc6.FormattingEnabled = True
        Me.cbc6.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc6.Location = New System.Drawing.Point(362, 197)
        Me.cbc6.Name = "cbc6"
        Me.cbc6.Size = New System.Drawing.Size(89, 22)
        Me.cbc6.TabIndex = 374
        '
        'chbc6
        '
        Me.chbc6.AccessibleName = ""
        Me.chbc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc6.Location = New System.Drawing.Point(306, 197)
        Me.chbc6.Name = "chbc6"
        Me.chbc6.Size = New System.Drawing.Size(35, 20)
        Me.chbc6.TabIndex = 371
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 197)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 372
        Me.Label10.Text = "6"
        '
        'tbc6
        '
        Me.tbc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc6.Location = New System.Drawing.Point(42, 197)
        Me.tbc6.Name = "tbc6"
        Me.tbc6.Size = New System.Drawing.Size(250, 20)
        Me.tbc6.TabIndex = 373
        '
        'cbc7
        '
        Me.cbc7.DropDownWidth = 150
        Me.cbc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc7.FormattingEnabled = True
        Me.cbc7.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc7.Location = New System.Drawing.Point(362, 219)
        Me.cbc7.Name = "cbc7"
        Me.cbc7.Size = New System.Drawing.Size(89, 22)
        Me.cbc7.TabIndex = 378
        '
        'chbc7
        '
        Me.chbc7.AccessibleName = ""
        Me.chbc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc7.Location = New System.Drawing.Point(306, 219)
        Me.chbc7.Name = "chbc7"
        Me.chbc7.Size = New System.Drawing.Size(35, 20)
        Me.chbc7.TabIndex = 375
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 376
        Me.Label11.Text = "7"
        '
        'tbc7
        '
        Me.tbc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc7.Location = New System.Drawing.Point(42, 219)
        Me.tbc7.Name = "tbc7"
        Me.tbc7.Size = New System.Drawing.Size(250, 20)
        Me.tbc7.TabIndex = 377
        '
        'cbc8
        '
        Me.cbc8.DropDownWidth = 150
        Me.cbc8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc8.FormattingEnabled = True
        Me.cbc8.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc8.Location = New System.Drawing.Point(362, 241)
        Me.cbc8.Name = "cbc8"
        Me.cbc8.Size = New System.Drawing.Size(89, 22)
        Me.cbc8.TabIndex = 382
        '
        'chbc8
        '
        Me.chbc8.AccessibleName = ""
        Me.chbc8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc8.Location = New System.Drawing.Point(306, 241)
        Me.chbc8.Name = "chbc8"
        Me.chbc8.Size = New System.Drawing.Size(35, 20)
        Me.chbc8.TabIndex = 379
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 20)
        Me.Label12.TabIndex = 380
        Me.Label12.Text = "8"
        '
        'tbc8
        '
        Me.tbc8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc8.Location = New System.Drawing.Point(42, 241)
        Me.tbc8.Name = "tbc8"
        Me.tbc8.Size = New System.Drawing.Size(250, 20)
        Me.tbc8.TabIndex = 381
        '
        'cbc9
        '
        Me.cbc9.DropDownWidth = 150
        Me.cbc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc9.FormattingEnabled = True
        Me.cbc9.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc9.Location = New System.Drawing.Point(362, 263)
        Me.cbc9.Name = "cbc9"
        Me.cbc9.Size = New System.Drawing.Size(89, 22)
        Me.cbc9.TabIndex = 386
        '
        'chbc9
        '
        Me.chbc9.AccessibleName = ""
        Me.chbc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc9.Location = New System.Drawing.Point(306, 263)
        Me.chbc9.Name = "chbc9"
        Me.chbc9.Size = New System.Drawing.Size(35, 20)
        Me.chbc9.TabIndex = 383
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 384
        Me.Label13.Text = "9"
        '
        'tbc9
        '
        Me.tbc9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc9.Location = New System.Drawing.Point(42, 263)
        Me.tbc9.Name = "tbc9"
        Me.tbc9.Size = New System.Drawing.Size(250, 20)
        Me.tbc9.TabIndex = 385
        '
        'cbc10
        '
        Me.cbc10.DropDownWidth = 150
        Me.cbc10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc10.FormattingEnabled = True
        Me.cbc10.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc10.Location = New System.Drawing.Point(362, 285)
        Me.cbc10.Name = "cbc10"
        Me.cbc10.Size = New System.Drawing.Size(89, 22)
        Me.cbc10.TabIndex = 390
        '
        'chbc10
        '
        Me.chbc10.AccessibleName = ""
        Me.chbc10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc10.Location = New System.Drawing.Point(306, 285)
        Me.chbc10.Name = "chbc10"
        Me.chbc10.Size = New System.Drawing.Size(35, 20)
        Me.chbc10.TabIndex = 387
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 285)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 20)
        Me.Label14.TabIndex = 388
        Me.Label14.Text = "10"
        '
        'tbc10
        '
        Me.tbc10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc10.Location = New System.Drawing.Point(42, 285)
        Me.tbc10.Name = "tbc10"
        Me.tbc10.Size = New System.Drawing.Size(250, 20)
        Me.tbc10.TabIndex = 389
        '
        'cbc11
        '
        Me.cbc11.DropDownWidth = 150
        Me.cbc11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc11.FormattingEnabled = True
        Me.cbc11.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc11.Location = New System.Drawing.Point(362, 307)
        Me.cbc11.Name = "cbc11"
        Me.cbc11.Size = New System.Drawing.Size(89, 22)
        Me.cbc11.TabIndex = 394
        '
        'chbc11
        '
        Me.chbc11.AccessibleName = ""
        Me.chbc11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc11.Location = New System.Drawing.Point(306, 307)
        Me.chbc11.Name = "chbc11"
        Me.chbc11.Size = New System.Drawing.Size(35, 20)
        Me.chbc11.TabIndex = 391
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 307)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 20)
        Me.Label15.TabIndex = 392
        Me.Label15.Text = "11"
        '
        'tbc11
        '
        Me.tbc11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc11.Location = New System.Drawing.Point(42, 307)
        Me.tbc11.Name = "tbc11"
        Me.tbc11.Size = New System.Drawing.Size(250, 20)
        Me.tbc11.TabIndex = 393
        '
        'ComboBox11
        '
        Me.ComboBox11.DropDownWidth = 150
        Me.ComboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox11.FormattingEnabled = True
        Me.ComboBox11.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.ComboBox11.Location = New System.Drawing.Point(362, 329)
        Me.ComboBox11.Name = "ComboBox11"
        Me.ComboBox11.Size = New System.Drawing.Size(89, 22)
        Me.ComboBox11.TabIndex = 398
        '
        'chbc12
        '
        Me.chbc12.AccessibleName = ""
        Me.chbc12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc12.Location = New System.Drawing.Point(306, 329)
        Me.chbc12.Name = "chbc12"
        Me.chbc12.Size = New System.Drawing.Size(35, 20)
        Me.chbc12.TabIndex = 395
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 329)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 20)
        Me.Label16.TabIndex = 396
        Me.Label16.Text = "12"
        '
        'tbc12
        '
        Me.tbc12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc12.Location = New System.Drawing.Point(42, 329)
        Me.tbc12.Name = "tbc12"
        Me.tbc12.Size = New System.Drawing.Size(250, 20)
        Me.tbc12.TabIndex = 397
        '
        'cbc13
        '
        Me.cbc13.DropDownWidth = 150
        Me.cbc13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc13.FormattingEnabled = True
        Me.cbc13.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc13.Location = New System.Drawing.Point(362, 351)
        Me.cbc13.Name = "cbc13"
        Me.cbc13.Size = New System.Drawing.Size(89, 22)
        Me.cbc13.TabIndex = 402
        '
        'chbc13
        '
        Me.chbc13.AccessibleName = ""
        Me.chbc13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc13.Location = New System.Drawing.Point(306, 351)
        Me.chbc13.Name = "chbc13"
        Me.chbc13.Size = New System.Drawing.Size(35, 20)
        Me.chbc13.TabIndex = 399
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 351)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 20)
        Me.Label17.TabIndex = 400
        Me.Label17.Text = "13"
        '
        'tbc13
        '
        Me.tbc13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc13.Location = New System.Drawing.Point(42, 351)
        Me.tbc13.Name = "tbc13"
        Me.tbc13.Size = New System.Drawing.Size(250, 20)
        Me.tbc13.TabIndex = 401
        '
        'cbc14
        '
        Me.cbc14.DropDownWidth = 150
        Me.cbc14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc14.FormattingEnabled = True
        Me.cbc14.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc14.Location = New System.Drawing.Point(362, 373)
        Me.cbc14.Name = "cbc14"
        Me.cbc14.Size = New System.Drawing.Size(89, 22)
        Me.cbc14.TabIndex = 406
        '
        'chbc14
        '
        Me.chbc14.AccessibleName = ""
        Me.chbc14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc14.Location = New System.Drawing.Point(306, 373)
        Me.chbc14.Name = "chbc14"
        Me.chbc14.Size = New System.Drawing.Size(35, 20)
        Me.chbc14.TabIndex = 403
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 373)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 20)
        Me.Label18.TabIndex = 404
        Me.Label18.Text = "14"
        '
        'tbc14
        '
        Me.tbc14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc14.Location = New System.Drawing.Point(42, 373)
        Me.tbc14.Name = "tbc14"
        Me.tbc14.Size = New System.Drawing.Size(250, 20)
        Me.tbc14.TabIndex = 405
        '
        'cbc15
        '
        Me.cbc15.DropDownWidth = 150
        Me.cbc15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc15.FormattingEnabled = True
        Me.cbc15.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc15.Location = New System.Drawing.Point(362, 395)
        Me.cbc15.Name = "cbc15"
        Me.cbc15.Size = New System.Drawing.Size(89, 22)
        Me.cbc15.TabIndex = 410
        '
        'chbc15
        '
        Me.chbc15.AccessibleName = ""
        Me.chbc15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc15.Location = New System.Drawing.Point(306, 395)
        Me.chbc15.Name = "chbc15"
        Me.chbc15.Size = New System.Drawing.Size(35, 20)
        Me.chbc15.TabIndex = 407
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 395)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 408
        Me.Label19.Text = "15"
        '
        'tbc15
        '
        Me.tbc15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc15.Location = New System.Drawing.Point(42, 395)
        Me.tbc15.Name = "tbc15"
        Me.tbc15.Size = New System.Drawing.Size(250, 20)
        Me.tbc15.TabIndex = 409
        '
        'cbc16
        '
        Me.cbc16.DropDownWidth = 150
        Me.cbc16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc16.FormattingEnabled = True
        Me.cbc16.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc16.Location = New System.Drawing.Point(362, 417)
        Me.cbc16.Name = "cbc16"
        Me.cbc16.Size = New System.Drawing.Size(89, 22)
        Me.cbc16.TabIndex = 414
        '
        'chbc16
        '
        Me.chbc16.AccessibleName = ""
        Me.chbc16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc16.Location = New System.Drawing.Point(306, 417)
        Me.chbc16.Name = "chbc16"
        Me.chbc16.Size = New System.Drawing.Size(35, 20)
        Me.chbc16.TabIndex = 411
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 417)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 20)
        Me.Label20.TabIndex = 412
        Me.Label20.Text = "16"
        '
        'tbc16
        '
        Me.tbc16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc16.Location = New System.Drawing.Point(42, 417)
        Me.tbc16.Name = "tbc16"
        Me.tbc16.Size = New System.Drawing.Size(250, 20)
        Me.tbc16.TabIndex = 413
        '
        'cbc17
        '
        Me.cbc17.DropDownWidth = 150
        Me.cbc17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc17.FormattingEnabled = True
        Me.cbc17.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc17.Location = New System.Drawing.Point(362, 439)
        Me.cbc17.Name = "cbc17"
        Me.cbc17.Size = New System.Drawing.Size(89, 22)
        Me.cbc17.TabIndex = 418
        '
        'chbc17
        '
        Me.chbc17.AccessibleName = ""
        Me.chbc17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc17.Location = New System.Drawing.Point(306, 439)
        Me.chbc17.Name = "chbc17"
        Me.chbc17.Size = New System.Drawing.Size(35, 20)
        Me.chbc17.TabIndex = 415
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 439)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 20)
        Me.Label21.TabIndex = 416
        Me.Label21.Text = "17"
        '
        'tbc17
        '
        Me.tbc17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc17.Location = New System.Drawing.Point(42, 439)
        Me.tbc17.Name = "tbc17"
        Me.tbc17.Size = New System.Drawing.Size(250, 20)
        Me.tbc17.TabIndex = 417
        '
        'cbc18
        '
        Me.cbc18.DropDownWidth = 150
        Me.cbc18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc18.FormattingEnabled = True
        Me.cbc18.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc18.Location = New System.Drawing.Point(362, 461)
        Me.cbc18.Name = "cbc18"
        Me.cbc18.Size = New System.Drawing.Size(89, 22)
        Me.cbc18.TabIndex = 422
        '
        'chbc18
        '
        Me.chbc18.AccessibleName = ""
        Me.chbc18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc18.Location = New System.Drawing.Point(306, 461)
        Me.chbc18.Name = "chbc18"
        Me.chbc18.Size = New System.Drawing.Size(35, 20)
        Me.chbc18.TabIndex = 419
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 461)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 20)
        Me.Label22.TabIndex = 420
        Me.Label22.Text = "18"
        '
        'tbc18
        '
        Me.tbc18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc18.Location = New System.Drawing.Point(42, 461)
        Me.tbc18.Name = "tbc18"
        Me.tbc18.Size = New System.Drawing.Size(250, 20)
        Me.tbc18.TabIndex = 421
        '
        'cbc19
        '
        Me.cbc19.DropDownWidth = 150
        Me.cbc19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc19.FormattingEnabled = True
        Me.cbc19.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc19.Location = New System.Drawing.Point(362, 483)
        Me.cbc19.Name = "cbc19"
        Me.cbc19.Size = New System.Drawing.Size(89, 22)
        Me.cbc19.TabIndex = 426
        '
        'chbc19
        '
        Me.chbc19.AccessibleName = ""
        Me.chbc19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc19.Location = New System.Drawing.Point(306, 483)
        Me.chbc19.Name = "chbc19"
        Me.chbc19.Size = New System.Drawing.Size(35, 20)
        Me.chbc19.TabIndex = 423
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 483)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 424
        Me.Label23.Text = "19"
        '
        'tbc19
        '
        Me.tbc19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc19.Location = New System.Drawing.Point(42, 483)
        Me.tbc19.Name = "tbc19"
        Me.tbc19.Size = New System.Drawing.Size(250, 20)
        Me.tbc19.TabIndex = 425
        '
        'cbc20
        '
        Me.cbc20.DropDownWidth = 150
        Me.cbc20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc20.FormattingEnabled = True
        Me.cbc20.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc20.Location = New System.Drawing.Point(362, 505)
        Me.cbc20.Name = "cbc20"
        Me.cbc20.Size = New System.Drawing.Size(89, 22)
        Me.cbc20.TabIndex = 430
        '
        'chbc20
        '
        Me.chbc20.AccessibleName = ""
        Me.chbc20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc20.Location = New System.Drawing.Point(306, 505)
        Me.chbc20.Name = "chbc20"
        Me.chbc20.Size = New System.Drawing.Size(35, 20)
        Me.chbc20.TabIndex = 427
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 505)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 20)
        Me.Label24.TabIndex = 428
        Me.Label24.Text = "20"
        '
        'tbc20
        '
        Me.tbc20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc20.Location = New System.Drawing.Point(42, 505)
        Me.tbc20.Name = "tbc20"
        Me.tbc20.Size = New System.Drawing.Size(250, 20)
        Me.tbc20.TabIndex = 429
        '
        'cbc21
        '
        Me.cbc21.DropDownWidth = 150
        Me.cbc21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc21.FormattingEnabled = True
        Me.cbc21.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc21.Location = New System.Drawing.Point(362, 527)
        Me.cbc21.Name = "cbc21"
        Me.cbc21.Size = New System.Drawing.Size(89, 22)
        Me.cbc21.TabIndex = 434
        '
        'chbc21
        '
        Me.chbc21.AccessibleName = ""
        Me.chbc21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc21.Location = New System.Drawing.Point(306, 527)
        Me.chbc21.Name = "chbc21"
        Me.chbc21.Size = New System.Drawing.Size(35, 20)
        Me.chbc21.TabIndex = 431
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 527)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(30, 20)
        Me.Label25.TabIndex = 432
        Me.Label25.Text = "21"
        '
        'tbc21
        '
        Me.tbc21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc21.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc21.Location = New System.Drawing.Point(42, 527)
        Me.tbc21.Name = "tbc21"
        Me.tbc21.Size = New System.Drawing.Size(250, 20)
        Me.tbc21.TabIndex = 433
        '
        'cbc22
        '
        Me.cbc22.DropDownWidth = 150
        Me.cbc22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc22.FormattingEnabled = True
        Me.cbc22.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc22.Location = New System.Drawing.Point(362, 549)
        Me.cbc22.Name = "cbc22"
        Me.cbc22.Size = New System.Drawing.Size(89, 22)
        Me.cbc22.TabIndex = 438
        '
        'chbc22
        '
        Me.chbc22.AccessibleName = ""
        Me.chbc22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc22.Location = New System.Drawing.Point(306, 549)
        Me.chbc22.Name = "chbc22"
        Me.chbc22.Size = New System.Drawing.Size(35, 20)
        Me.chbc22.TabIndex = 435
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 549)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 20)
        Me.Label26.TabIndex = 436
        Me.Label26.Text = "22"
        '
        'tbc22
        '
        Me.tbc22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc22.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc22.Location = New System.Drawing.Point(42, 549)
        Me.tbc22.Name = "tbc22"
        Me.tbc22.Size = New System.Drawing.Size(250, 20)
        Me.tbc22.TabIndex = 437
        '
        'cbc23
        '
        Me.cbc23.DropDownWidth = 150
        Me.cbc23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc23.FormattingEnabled = True
        Me.cbc23.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc23.Location = New System.Drawing.Point(362, 571)
        Me.cbc23.Name = "cbc23"
        Me.cbc23.Size = New System.Drawing.Size(89, 22)
        Me.cbc23.TabIndex = 442
        '
        'chbc23
        '
        Me.chbc23.AccessibleName = ""
        Me.chbc23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc23.Location = New System.Drawing.Point(306, 571)
        Me.chbc23.Name = "chbc23"
        Me.chbc23.Size = New System.Drawing.Size(35, 20)
        Me.chbc23.TabIndex = 439
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 571)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(30, 20)
        Me.Label27.TabIndex = 440
        Me.Label27.Text = "23"
        '
        'tbc23
        '
        Me.tbc23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc23.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc23.Location = New System.Drawing.Point(42, 571)
        Me.tbc23.Name = "tbc23"
        Me.tbc23.Size = New System.Drawing.Size(250, 20)
        Me.tbc23.TabIndex = 441
        '
        'cbc24
        '
        Me.cbc24.DropDownWidth = 150
        Me.cbc24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc24.FormattingEnabled = True
        Me.cbc24.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc24.Location = New System.Drawing.Point(362, 593)
        Me.cbc24.Name = "cbc24"
        Me.cbc24.Size = New System.Drawing.Size(89, 22)
        Me.cbc24.TabIndex = 446
        '
        'chbc24
        '
        Me.chbc24.AccessibleName = ""
        Me.chbc24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc24.Location = New System.Drawing.Point(306, 593)
        Me.chbc24.Name = "chbc24"
        Me.chbc24.Size = New System.Drawing.Size(35, 20)
        Me.chbc24.TabIndex = 443
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 593)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 444
        Me.Label28.Text = "24"
        '
        'tbc24
        '
        Me.tbc24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc24.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc24.Location = New System.Drawing.Point(42, 593)
        Me.tbc24.Name = "tbc24"
        Me.tbc24.Size = New System.Drawing.Size(250, 20)
        Me.tbc24.TabIndex = 445
        '
        'cbc25
        '
        Me.cbc25.DropDownWidth = 150
        Me.cbc25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc25.FormattingEnabled = True
        Me.cbc25.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc25.Location = New System.Drawing.Point(362, 615)
        Me.cbc25.Name = "cbc25"
        Me.cbc25.Size = New System.Drawing.Size(89, 22)
        Me.cbc25.TabIndex = 450
        '
        'chbc25
        '
        Me.chbc25.AccessibleName = ""
        Me.chbc25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc25.Location = New System.Drawing.Point(306, 615)
        Me.chbc25.Name = "chbc25"
        Me.chbc25.Size = New System.Drawing.Size(35, 20)
        Me.chbc25.TabIndex = 447
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(6, 615)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 20)
        Me.Label29.TabIndex = 448
        Me.Label29.Text = "25"
        '
        'tbc25
        '
        Me.tbc25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc25.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc25.Location = New System.Drawing.Point(42, 615)
        Me.tbc25.Name = "tbc25"
        Me.tbc25.Size = New System.Drawing.Size(250, 20)
        Me.tbc25.TabIndex = 449
        '
        'cbc26
        '
        Me.cbc26.DropDownWidth = 150
        Me.cbc26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc26.FormattingEnabled = True
        Me.cbc26.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc26.Location = New System.Drawing.Point(362, 637)
        Me.cbc26.Name = "cbc26"
        Me.cbc26.Size = New System.Drawing.Size(89, 22)
        Me.cbc26.TabIndex = 454
        '
        'chbc26
        '
        Me.chbc26.AccessibleName = ""
        Me.chbc26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc26.Location = New System.Drawing.Point(306, 637)
        Me.chbc26.Name = "chbc26"
        Me.chbc26.Size = New System.Drawing.Size(35, 20)
        Me.chbc26.TabIndex = 451
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(6, 637)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(30, 20)
        Me.Label30.TabIndex = 452
        Me.Label30.Text = "26"
        '
        'tbc26
        '
        Me.tbc26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc26.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc26.Location = New System.Drawing.Point(42, 637)
        Me.tbc26.Name = "tbc26"
        Me.tbc26.Size = New System.Drawing.Size(250, 20)
        Me.tbc26.TabIndex = 453
        '
        'cbc27
        '
        Me.cbc27.DropDownWidth = 150
        Me.cbc27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc27.FormattingEnabled = True
        Me.cbc27.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc27.Location = New System.Drawing.Point(362, 659)
        Me.cbc27.Name = "cbc27"
        Me.cbc27.Size = New System.Drawing.Size(89, 22)
        Me.cbc27.TabIndex = 458
        '
        'chbc27
        '
        Me.chbc27.AccessibleName = ""
        Me.chbc27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc27.Location = New System.Drawing.Point(306, 659)
        Me.chbc27.Name = "chbc27"
        Me.chbc27.Size = New System.Drawing.Size(35, 20)
        Me.chbc27.TabIndex = 455
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label31.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(6, 659)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 20)
        Me.Label31.TabIndex = 456
        Me.Label31.Text = "27"
        '
        'tbc27
        '
        Me.tbc27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc27.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc27.Location = New System.Drawing.Point(42, 659)
        Me.tbc27.Name = "tbc27"
        Me.tbc27.Size = New System.Drawing.Size(250, 20)
        Me.tbc27.TabIndex = 457
        '
        'cbc28
        '
        Me.cbc28.DropDownWidth = 150
        Me.cbc28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc28.FormattingEnabled = True
        Me.cbc28.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc28.Location = New System.Drawing.Point(362, 681)
        Me.cbc28.Name = "cbc28"
        Me.cbc28.Size = New System.Drawing.Size(89, 22)
        Me.cbc28.TabIndex = 462
        '
        'chbc28
        '
        Me.chbc28.AccessibleName = ""
        Me.chbc28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc28.Location = New System.Drawing.Point(306, 681)
        Me.chbc28.Name = "chbc28"
        Me.chbc28.Size = New System.Drawing.Size(35, 20)
        Me.chbc28.TabIndex = 459
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label32.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(6, 681)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(30, 20)
        Me.Label32.TabIndex = 460
        Me.Label32.Text = "28"
        '
        'tbc28
        '
        Me.tbc28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc28.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc28.Location = New System.Drawing.Point(42, 681)
        Me.tbc28.Name = "tbc28"
        Me.tbc28.Size = New System.Drawing.Size(250, 20)
        Me.tbc28.TabIndex = 461
        '
        'cbc29
        '
        Me.cbc29.DropDownWidth = 150
        Me.cbc29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc29.FormattingEnabled = True
        Me.cbc29.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc29.Location = New System.Drawing.Point(362, 703)
        Me.cbc29.Name = "cbc29"
        Me.cbc29.Size = New System.Drawing.Size(89, 22)
        Me.cbc29.TabIndex = 466
        '
        'chbc29
        '
        Me.chbc29.AccessibleName = ""
        Me.chbc29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc29.Location = New System.Drawing.Point(306, 703)
        Me.chbc29.Name = "chbc29"
        Me.chbc29.Size = New System.Drawing.Size(35, 20)
        Me.chbc29.TabIndex = 463
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label33.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(6, 703)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(30, 20)
        Me.Label33.TabIndex = 464
        Me.Label33.Text = "29"
        '
        'tbc29
        '
        Me.tbc29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc29.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc29.Location = New System.Drawing.Point(42, 703)
        Me.tbc29.Name = "tbc29"
        Me.tbc29.Size = New System.Drawing.Size(250, 20)
        Me.tbc29.TabIndex = 465
        '
        'cbc30
        '
        Me.cbc30.DropDownWidth = 150
        Me.cbc30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbc30.FormattingEnabled = True
        Me.cbc30.Items.AddRange(New Object() {"TextBox", "RadioButton group", "Multiresponse "})
        Me.cbc30.Location = New System.Drawing.Point(362, 725)
        Me.cbc30.Name = "cbc30"
        Me.cbc30.Size = New System.Drawing.Size(89, 22)
        Me.cbc30.TabIndex = 470
        '
        'chbc30
        '
        Me.chbc30.AccessibleName = ""
        Me.chbc30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc30.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc30.Location = New System.Drawing.Point(306, 725)
        Me.chbc30.Name = "chbc30"
        Me.chbc30.Size = New System.Drawing.Size(35, 20)
        Me.chbc30.TabIndex = 467
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label34.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(6, 725)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 20)
        Me.Label34.TabIndex = 468
        Me.Label34.Text = "30"
        '
        'tbc30
        '
        Me.tbc30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc30.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc30.Location = New System.Drawing.Point(42, 725)
        Me.tbc30.Name = "tbc30"
        Me.tbc30.Size = New System.Drawing.Size(250, 20)
        Me.tbc30.TabIndex = 469
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Location = New System.Drawing.Point(831, 87)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 20)
        Me.Button1.TabIndex = 473
        Me.Button1.TabStop = False
        Me.Button1.Text = "+"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(477, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 20)
        Me.TextBox1.TabIndex = 474
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(737, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 20)
        Me.TextBox2.TabIndex = 475
        '
        'mFormInsertMultiCheckB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(887, 777)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbc30)
        Me.Controls.Add(Me.chbc30)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.tbc30)
        Me.Controls.Add(Me.cbc29)
        Me.Controls.Add(Me.chbc29)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.tbc29)
        Me.Controls.Add(Me.cbc28)
        Me.Controls.Add(Me.chbc28)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.tbc28)
        Me.Controls.Add(Me.cbc27)
        Me.Controls.Add(Me.chbc27)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.tbc27)
        Me.Controls.Add(Me.cbc26)
        Me.Controls.Add(Me.chbc26)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.tbc26)
        Me.Controls.Add(Me.cbc25)
        Me.Controls.Add(Me.chbc25)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.tbc25)
        Me.Controls.Add(Me.cbc24)
        Me.Controls.Add(Me.chbc24)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.tbc24)
        Me.Controls.Add(Me.cbc23)
        Me.Controls.Add(Me.chbc23)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.tbc23)
        Me.Controls.Add(Me.cbc22)
        Me.Controls.Add(Me.chbc22)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.tbc22)
        Me.Controls.Add(Me.cbc21)
        Me.Controls.Add(Me.chbc21)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.tbc21)
        Me.Controls.Add(Me.cbc20)
        Me.Controls.Add(Me.chbc20)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.tbc20)
        Me.Controls.Add(Me.cbc19)
        Me.Controls.Add(Me.chbc19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tbc19)
        Me.Controls.Add(Me.cbc18)
        Me.Controls.Add(Me.chbc18)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbc18)
        Me.Controls.Add(Me.cbc17)
        Me.Controls.Add(Me.chbc17)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbc17)
        Me.Controls.Add(Me.cbc16)
        Me.Controls.Add(Me.chbc16)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbc16)
        Me.Controls.Add(Me.cbc15)
        Me.Controls.Add(Me.chbc15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbc15)
        Me.Controls.Add(Me.cbc14)
        Me.Controls.Add(Me.chbc14)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbc14)
        Me.Controls.Add(Me.cbc13)
        Me.Controls.Add(Me.chbc13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbc13)
        Me.Controls.Add(Me.ComboBox11)
        Me.Controls.Add(Me.chbc12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbc12)
        Me.Controls.Add(Me.cbc11)
        Me.Controls.Add(Me.chbc11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbc11)
        Me.Controls.Add(Me.cbc10)
        Me.Controls.Add(Me.chbc10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbc10)
        Me.Controls.Add(Me.cbc9)
        Me.Controls.Add(Me.chbc9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbc9)
        Me.Controls.Add(Me.cbc8)
        Me.Controls.Add(Me.chbc8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbc8)
        Me.Controls.Add(Me.cbc7)
        Me.Controls.Add(Me.chbc7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbc7)
        Me.Controls.Add(Me.cbc6)
        Me.Controls.Add(Me.chbc6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbc6)
        Me.Controls.Add(Me.cbc5)
        Me.Controls.Add(Me.chbc5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbc5)
        Me.Controls.Add(Me.cbc4)
        Me.Controls.Add(Me.chbc4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbc4)
        Me.Controls.Add(Me.cbc3)
        Me.Controls.Add(Me.chbc3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbc3)
        Me.Controls.Add(Me.cbc2)
        Me.Controls.Add(Me.chbc2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbc2)
        Me.Controls.Add(Me.cbc1)
        Me.Controls.Add(Me.chbc1)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbc1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormInsertMultiCheckB"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert "
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim gde As String
    Dim pp() As String
    Dim ISTDB As Boolean
    Dim IST As Boolean
    Dim what As String

    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal gde As String, ByVal what As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
            '.Left = tvRight - Me.Width - 20
            '.Top = tvTop + 30
        End With
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.gde = gde
        Me.dIst = dIst
        Me.what = what

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        If Me.AccessibleDescription = "fp" Then IST = True Else ISTDB = True
        'Dim dt As System.Data.DataTable = getDTC()
        'If dt.Rows.Count = 1 Then
        '    'Call getVariablesC(dt)
        '    'Try
        '    '    getMetaDataPaneP1()
        '    'Catch ex As Exception
        '    '    ISTMessageBox.Show(ex.Message)
        '    'End Try
        'End If
        Dim strSQl As String = "select polje as displaymember,polje as valuemember from ISTPolja where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' order by polje"

        Me.btnFormat.Text = Me.what
        Me.Text = Me.what
        If Me.what.Trim.ToUpper = "CONVERT" Then
            Me.Label1.Text = Me.what + " to ComboBox"
        Else
            Me.Label1.Text = Me.what + " ComboBox"
        End If

    End Sub

    Dim columnAtributes As String = ""
    Dim vs As String = ""
    'Function getDTC() As System.Data.DataTable
    '    columnAtributes = ""
    '    vs = ""
    '    'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
    '    Dim strSQl As String = "select izraz,vs" +
    '            " from vrepISTPolja " +
    '            " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "' and pp='cb'" +
    '            " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
    '    getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    'End Function
    'Sub getVariablesC(ByVal dt As System.Data.DataTable)
    '    columnAtributes = dt.Rows(0).Item("izraz").ToString.Trim
    'End Sub

    'Function minRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
    '    Dim str As String = "select top 1 rbr from vrepISTPolja where sifist='" + sifist + "' and tabela='" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' order by cast(rbr as int)"
    '    minRBRTabela = getrbr(str)
    'End Function
    'Function maxRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
    '    Dim str As String = "select top 1 rbr from vrepISTPolja where sifist='" + sifist + "' and tabela='" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' order by cast(rbr as int) desc"
    '    maxRBRTabela = getrbr(str)
    'End Function

    'Function dajUniqueImeISTDB(ByVal tabela As String, ByVal cname As String, ByVal dodpolje As String) As String
    '    Dim sql As String = ""
    '    dajUniqueImeISTDB = cname + "1"
    '    For i As Integer = 1 To 100000
    '        If dodpolje = "" OrElse dodpolje.IndexOf(cname + CStr(i).Trim + ";") < 0 Then
    '            sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabela + "'   and  COLUMN_NAME='" + cname + CStr(i).Trim + "'"
    '            Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
    '            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
    '                dajUniqueImeISTDB = cname + CStr(i).Trim
    '                sql = "SELECT polje FROM istpolja where sifist='" + sifist + "' and tabela='" + tabela + "' and polje='" + dajUniqueImeISTDB + "'"
    '                Dim dtI As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    '                If dtI Is Nothing OrElse dtI.Rows.Count = 0 Then
    '                    'sve ok
    '                    Exit For
    '                Else
    '                    'teraj dalje
    '                End If
    '            End If
    '        End If
    '    Next
    'End Function
    'Function getrbr(ByVal sqlrbr As String) As String
    '    Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
    '    If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 Then
    '        getrbr = dt1.Rows(0).Item("rbr").ToString
    '    Else
    '        getrbr = "0"
    '    End If
    'End Function

    'Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

    '    If txtCB.Text.Trim = "" Then
    '        ISTMessageBox.Show("Syntax for ComboBox is empty!Did you press and release button Make ComboBox?")
    '        Me.btnMakeCB.Focus()
    '        Exit Sub
    '    End If

    '    'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
    '    Dim sqlIST As String = "" : Dim sqlDB As String = ""
    '    Dim ppolje As String = dajUniqueImeISTDB(pp(0).Trim, "cb_", "")
    '    Dim p2 As String = ""
    '    Dim rrbr As String = pp(4).Trim
    '    Dim pomrbr As String = ""
    '    Dim trk() As String = pp(3).Split(".")
    '    If gde = "" Then  'update
    '        'Dim popis As String = "$"
    '        Dim pizraz As String = setMetaDataPaneP1()
    '        Dim pvs As String = ""
    '        If txtVS.Text.Trim <> "" Then pvs = txtVS.Text.Trim
    '        If postojiPoljeUTabeli(pp(0).Trim, pp(2).Trim) = False Then sqlDB = "ALTER TABLE " + pp(0).Trim + " ADD  " + pp(2).Trim + " NVARCHAR(255) NULL;" + nvrd

    '        If pizraz <> "" Then
    '            sqlIST = "update istpolja set" + nvrd +
    '                    " izraz='" + pizraz + "', vs='" + pvs + "'" +
    '                      " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "' and rbr ='" + pp(4).Trim + "'"
    '            p2 = izvrsiSQL(" begin transaction; " + nvrd + sqlIST + nvrd + " commit; ", Me.ISTConnectionString)
    '            If p2 = "nok" Then ISTMessageBox.Show("Error. Not updated to IST!") Else ISTMessageBox.Show("Please refresh!") : Me.Close()
    '        End If

    '    End If

    '    If gde <> "" Then
    '        If trk.Length = 3 Then
    '            Dim currenttab As Integer = CInt(trk(0).Trim)
    '            Dim minrbrzatab As String = minRBRTabela(currenttab, pp(0).Trim)
    '            Dim maxrbrzatab As String = maxRBRTabela(currenttab, pp(0).Trim)
    '            If gde = "above" Then
    '                rrbr = minrbrzatab
    '            Else
    '                rrbr = maxrbrzatab
    '            End If
    '        End If

    '        If gde = "above" Then
    '            pomrbr = rrbr + 10
    '            rrbr = rrbr
    '        Else
    '            pomrbr = rrbr
    '            rrbr = rrbr + 10
    '        End If

    '        sqlIST = " update istpolja Set rbr=rbr+10 where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr>=" + rrbr.Trim + ";" + nvrd
    '        Dim popis As String = "$"
    '        Dim pizraz As String = setMetaDataPaneP1()
    '        Dim pvs As String = ""
    '        If txtVS.Text.Trim <> "" Then pvs = txtVS.Text.Trim
    '        If pizraz <> "" Then
    '            sqlIST = sqlIST + "insert into istpolja (sifist,tabela,polje,vod,vdo,rbr,opis,izraz,vs)" + nvrd +
    '                 " select sifist,tabela,'" + ppolje + "' as polje,vod,vdo,'" + rrbr.Trim + "' as rbr,'" + popis + "','" + pizraz + "',''" + pvs + "" +
    '                 " from istpolja " +
    '                 " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr ='" + pomrbr + "'"

    '            sqlDB = "ALTER TABLE " + pp(0).Trim + " ADD  " + ppolje + " NVARCHAR(255) NULL;" + nvrd
    '            p2 = izvrsiSQL(" begin transaction; " + nvrd + sqlDB + nvrd + " commit; ", Me.DBConnectionString)
    '            If p2 = "nok" Then
    '                ISTMessageBox.Show("Error. Not added to DB!")
    '            Else
    '                p2 = izvrsiSQL(" begin transaction; " + nvrd + sqlIST + nvrd + " commit; ", Me.ISTConnectionString)
    '                If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to IST!") Else ISTMessageBox.Show("Please refresh!") : Me.Close()
    '            End If
    '        End If
    '    End If

    'End Sub
    'Function postojiPoljeUTabeli(ByVal tabela As String, ByVal polje As String) As Boolean
    '    postojiPoljeUTabeli = True
    '    Dim sql As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabela + "' and  COLUMN_NAME='" + polje + "'"
    '    Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
    '    If dt Is Nothing OrElse dt.Rows.Count = 0 Then
    '        postojiPoljeUTabeli = False
    '    End If
    'End Function
    'Sub getMetaDataPaneP1()

    '    'izraz i do autocomplete
    '    If columnAtributes Is Nothing OrElse columnAtributes.Trim = "" Then Exit Sub
    '    If vs.Trim <> "" Then Me.txtVS.Text = vs
    '    'Dim ccbo As Boolean = False
    '    'Dim sselect As Boolean = False
    '    Dim combo As String = ""
    '    Dim comboweb As String = ""
    '    cbCWO.Checked = False
    '    Me.txtCB.Text = columnAtributes.Trim
    '    If columnAtributes.Length > 2 AndAlso columnAtributes.Trim.ToUpper.IndexOf("CBW") = 0 Then cbCWO.Checked = True
    '    Dim cb As String = ""
    '    If cbCWO.Checked = True Then
    '        cb = columnAtributes.Trim.ToUpper.Replace("CBW{", "")
    '    Else
    '        cb = columnAtributes.Trim.ToUpper.Replace("CBO{", "")
    '    End If
    '    If cb.Substring(cb.Length - 1, 1) = "}" Then cb = cb.Substring(0, cb.Length - 1)

    '    Dim pp() As String = cb.Split(";")

    '    For i As Integer = 0 To pp.GetUpperBound(0)
    '        If pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("IZVOR") = 0 OrElse pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DATASOURCE") = 0 Then
    '            Dim ds As String = pp(i).Trim.ToUpper.Replace("DATASOURCE=", "").Replace("IZVOR=", "")
    '            'Select * From ffff Where dddd

    '            Dim bbb() As String = razkvantaj(ds)
    '            Dim s As Integer = -1 : Dim f As Integer = -1 : Dim w As Integer = -1
    '            For ll As Integer = 0 To bbb.GetUpperBound(0)
    '                If bbb(ll).Trim.ToUpper = "SELECT" Then
    '                    s = ll
    '                ElseIf bbb(ll).Trim.ToUpper = "FROM" Then
    '                    f = ll
    '                ElseIf bbb(ll).Trim.ToUpper = "WHERE" Then
    '                    w = ll
    '                End If
    '            Next
    '            Dim pom As String = ""
    '            Dim kr As Integer = w - 1

    '            If s > -1 AndAlso f > -1 Then
    '                For ll As Integer = s + 1 To f - 1
    '                    pom = pom + bbb(ll) + ","
    '                Next
    '                pom = pom.TrimEnd(",")
    '                pom = pom.Replace(",,", ",")
    '                Me.txtSelect.Text = pom

    '                pom = ""
    '                Dim m() As String = bbb(f + 1).Split(".")
    '                If m.Length = 3 Then
    '                    For k As Integer = 0 To m.GetUpperBound(0)
    '                        If m(1).Trim.ToUpper = "DBO" Then
    '                            Me.txtDataSource.Text = m(2).Replace("[", "").Replace("]", "")
    '                        Else
    '                            Me.txtDataSource.Text = m(1) + "." + m(2)
    '                        End If
    '                    Next
    '                Else
    '                    Me.txtDataSource.Text = bbb(f + 1)
    '                End If

    '                If w > -1 Then
    '                    pom = ""
    '                    For ll As Integer = w + 1 To bbb.GetUpperBound(0)
    '                        pom = pom + bbb(ll) + ","
    '                    Next
    '                    Me.txtWhere.Text = pom
    '                End If

    '            End If

    '            If s = -1 Then
    '                Me.txtSelect.Text = "*"
    '                Me.txtDataSource.Text = ds
    '                Me.txtWhere.Text = ""
    '            End If

    '            If txtWhere.Text.Trim.ToUpper.IndexOf("GOD={GGG}") >= 0 Then
    '                cbG.Checked = True : cbYY.Checked = False
    '            End If
    '            If txtWhere.Text.Trim.ToUpper.IndexOf("MES={MMM}") >= 0 Then
    '                cbM.Checked = True : cbMM.Checked = False
    '            End If
    '            If txtWhere.Text.Trim.ToUpper.IndexOf("ISTYEAR={YYY}") >= 0 Then
    '                cbYY.Checked = True : cbG.Checked = False
    '            End If
    '            If txtWhere.Text.Trim.ToUpper.IndexOf("ISTMONTH={MMM}") >= 0 Then
    '                cbMM.Checked = True : cbM.Checked = False
    '            End If
    '            'If txtWhere.Text.Trim.ToUpper.IndexOf("GGG") >= 0 Then
    '            'End If
    '            'If txtWhere.Text.Trim.ToUpper.IndexOf("GGG") >= 0 Then
    '            'End If

    '        ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DISPLAYMEMBER") = 0 OrElse pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("PRIKAZI") = 0 Then
    '            Dim dm As String = pp(i).Trim.ToUpper.Replace("DISPLAYMEMBER", "").Replace("PRIKAZI", "").Replace("=", "")
    '            txtfDM.Text = dm
    '        ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("VALUEMEMBER") = 0 OrElse pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("UBAZU") = 0 Then
    '            Dim vm As String = pp(i).Trim.ToUpper.Replace("VALUEMEMBER", "").Replace("UBAZU", "").Replace("=", "")
    '            txtfVM.Text = vm
    '        ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("FILTER") = 0 Then
    '            Dim ff As String = pp(i).Trim.ToUpper.Replace("FILTER=", "")
    '            Dim fff() As String = ff.Split("=")
    '            txtfF.Text = fff(0)
    '            cboIST.SelectedValue = fff(1).Replace("D.", "").Replace("#FP{", "").Replace("}", "")
    '        End If
    '    Next
    'End Sub
    'Function getttt(ByVal text As String, ByVal what As String) As String
    '    getttt = ""
    '    If text.Trim.ToUpper.IndexOf(what) >= 0 Then
    '        Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
    '        getttt = text.Trim.ToUpper.Substring(b + what.Length)
    '    End If
    'End Function
    'Function setMetaDataPaneP1() As String
    '    'izraz
    '    Dim pom As String = Me.txtCB.Text
    '    Return pom
    'End Function

    'Private Sub llSB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    '    Call llDB()
    'End Sub
    'Sub llDB()
    '    Dim pomn As String = OleDbConnString.EditConnectionString(Me, "")
    '    Me.txtConnString.Text = pomn.Replace("Provider=SQLOLEDB.1;", "")
    '    Call getServerBazaNew(pomn)
    '    Call DajTabelePolja2(tvBaza, Me.txtServer.Text, Me.txtBaza.Text)
    'End Sub

    'Sub getServerBazaNew(ByVal pomn As String)
    '    Dim pp() As String = pomn.Split(";")
    '    For i As Integer = 0 To pp.GetUpperBound(0)
    '        If pp(i).IndexOf("Initial Catalog=") = 0 Then
    '            Me.txtBaza.Text = pp(i).Replace("Initial Catalog=", "")
    '            Me.txtBaza.Visible = True
    '        End If
    '        If pp(i).IndexOf("Data Source=") = 0 Then
    '            Me.txtServer.Text = pp(i).Replace("Data Source=", "")
    '            Me.txtServer.Visible = True
    '        End If
    '    Next
    '    If txtBaza.Text <> "" Then tvBaza.Visible = True
    'End Sub
    'Sub DajTabelePolja2(ByVal tv As TreeView, ByVal server As String, ByVal baza As String)
    '    tv.Nodes.Clear()
    '    Dim DBConnectionString As String = getConnectionString(server, baza, "", Me.DBConnectionString)

    '    Dim strTP As String = " use " + baza +
    '                " SELECT ST.NAME AS tableName, SC.NAME AS columnName," +
    '                " CASE WHEN SC.colid= SKC.column_id THEN 'P' ELSE '' END AS primaryKey," +
    '                " STY.NAME AS columnType, SC.prec  AS columnLenght" +
    '                " FROM (select NAME,OBJECT_ID from SYS.TABLES union all select NAME + '_view' ,OBJECT_ID from SYS.VIEWS) AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
    '                " left JOIN SYS.TYPES AS STY ON SC.xusertype  = STY.USER_TYPE_ID" +
    '                " left JOIN SYS.INDEX_COLUMNS AS SKC" +
    '                " ON SKC.OBJECT_ID = ST.OBJECT_ID AND SKC.column_id =SC.colid order by 1"
    '    Dim dtTP As New DataTable
    '    dtTP = izvrsiSQLvratiDT(strTP, DBConnectionString, Nothing)
    '    'ako su tabele u ISTu, uzeti samo one cija sva polja nisu u ISTu

    '    If dtTP.Rows.Count > 0 Then
    '        Dim node As TreeNode
    '        Dim tab As String = dtTP.Rows(0).Item("tableName").ToString.Trim
    '        Dim slTab As String = ""
    '        node = tv.Nodes.Add(tab)
    '        node.Tag = node.Text
    '        Dim polje As String = dtTP.Rows(0).Item("columnName").ToString.Trim
    '        node.Nodes.Add(polje)
    '        node.Nodes(node.Nodes.Count - 1).Tag =
    '        dtTP.Rows(0).Item("columnName").ToString.Trim &
    '        ";" & NZ(dtTP.Rows(0).Item("primaryKey")).ToString.Trim &
    '        ";" & NZ(dtTP.Rows(0).Item("columnType")).ToString.Trim &
    '        ";" & NZ(dtTP.Rows(0).Item("columnLenght")).ToString.Trim
    '        For i As Integer = 1 To dtTP.Rows.Count - 1
    '            slTab = dtTP.Rows(i).Item("tableName").ToString.Trim
    '            If tab <> slTab Then
    '                tab = slTab
    '                node = tv.Nodes.Add(slTab)
    '                node.Tag = node.Text
    '            End If
    '            polje = dtTP.Rows(i).Item("columnName").ToString.Trim
    '            node.Nodes.Add(polje)
    '            node.Nodes(node.Nodes.Count - 1).Tag =
    '           dtTP.Rows(i).Item("columnName").ToString.Trim &
    '            ";" & dtTP.Rows(i).Item("primaryKey").ToString.Trim &
    '            ";" & dtTP.Rows(i).Item("columnType").ToString.Trim &
    '            ";" & dtTP.Rows(i).Item("columnLenght").ToString.Trim
    '        Next
    '        tv.Visible = True
    '    End If
    'End Sub
    'Dim fp As Boolean = False
    'Dim polje As String
    'Private Sub cboIST_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    polje = ""
    '    fp = False
    '    If Me.cboIST.SelectedValue <> "" Then
    '        polje = cboIST.SelectedValue.ToString.Trim
    '        Dim sql As String = "select polje,isnull(pp,'') as pp from vrepistpolja where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje ='" + polje + "'"
    '        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    '        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item("pp").ToString.Trim.ToUpper = "fp" Then fp = True
    '    End If
    'End Sub

    'Private Sub cbFilter_CheckedChanged(sender As Object, e As EventArgs) Handles cbFilter.CheckedChanged, cbn1.CheckedChanged
    '    If cbFilter.Checked = True Then
    '        pFilter.Visible = True
    '    Else
    '        pFilter.Visible = False
    '        txtfF.Text = ""
    '        cboIST.SelectedIndex = -1
    '    End If
    'End Sub
    'Dim textselectednode As String = ""
    'Private Sub tv_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
    '    textselectednode = ""
    '    Dim ClickPoint As Point = New Point(e.X, e.Y)
    '    Dim ClickNode As TreeNode = tvBaza.GetNodeAt(ClickPoint)
    '    If ClickNode Is Nothing Then Return

    '    tvBaza.SelectedNode = e.Node
    '    Dim mySelectedNode As TreeNode
    '    mySelectedNode = tvBaza.SelectedNode

    '    'Call tvNodeMouseDoubleClick(mySelectedNode)

    '    If e.Button = MouseButtons.Right Then
    '        If mySelectedNode.Parent Is Nothing Then
    '            'tabela
    '            a1.Visible = True
    '            a2.Visible = False
    '            a3.Visible = False
    '            a4.Visible = False
    '            a5.Visible = False
    '            a6.Visible = False
    '            Me.ToolStripSeparator1.Visible = False
    '            Me.ToolStripSeparator2.Visible = False
    '        Else
    '            'polje
    '            a1.Visible = False
    '            a2.Visible = True
    '            a3.Visible = True
    '            a4.Visible = True
    '            a5.Visible = True
    '            a6.Visible = True
    '            Me.ToolStripSeparator1.Visible = True
    '            Me.ToolStripSeparator2.Visible = True
    '        End If
    '        textselectednode = mySelectedNode.Text
    '    End If
    'End Sub
    'Private Sub mnu02_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu02.ItemClicked
    '    Dim ci As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)

    '    If ci.Name.Trim.ToUpper = "A1" Then   'DS
    '        txtDataSource.Text = textselectednode
    '    ElseIf ci.Name.Trim.ToUpper = "A2" Then   'select
    '        txtSelect.Text = Replace(txtSelect.Text, "*", "").Trim
    '        If txtSelect.Text = "" Then
    '            txtSelect.Text = textselectednode
    '        Else
    '            txtSelect.Text = txtSelect.Text + "," + textselectednode
    '        End If
    '    ElseIf ci.Name.Trim.ToUpper = "A3" Then  'where
    '        If txtWhere.Text = "" Then
    '            txtWhere.Text = "WHERE " + textselectednode
    '        Else
    '            txtWhere.Text = txtWhere.Text + " AND " + textselectednode
    '        End If
    '    ElseIf ci.Name.Trim.ToUpper = "A4" Then   'display
    '        txtfDM.Text = textselectednode
    '    ElseIf ci.Name.Trim.ToUpper = "A5" Then  'value
    '        txtfVM.Text = textselectednode
    '    ElseIf ci.Name.Trim.ToUpper = "A6" Then   'filter
    '        txtfF.Text = textselectednode
    '    End If

    'End Sub
    'Dim pref As String = "CBO"
    'Private Sub btnMakeCB_Click(sender As Object, e As EventArgs)

    '    If txtDataSource.Text.Trim = "" Then
    '        ISTMessageBox.Show("DataSource is empty!")
    '        txtDataSource.Focus()
    '        Exit Sub
    '    ElseIf txtfDM.Text.Trim = "" Then
    '        ISTMessageBox.Show("Display member is empty!")
    '        txtfDM.Focus()
    '        Exit Sub
    '    ElseIf txtfVM.Text.Trim = "" Then
    '        ISTMessageBox.Show("Value member is empty!")
    '        txtfVM.Focus()
    '        Exit Sub
    '    End If

    '    Dim ds As String = "CBO{"
    '    Dim it As String = ""
    '    If txtDataSource.Text.IndexOf(".") > 0 Then
    '        it = txtDataSource.Text
    '    Else
    '        it = "dbo.[" + txtDataSource.Text.Trim + "]"
    '    End If
    '    Dim ss As String = "datasource=select " + txtSelect.Text + " from [" + txtBaza.Text + "]." + it + ";"
    '    Dim ff As String = ""
    '    If polje <> "" AndAlso fp = False Then
    '        ff = "FILTER=" + Me.txtfF.Text + "=d." + polje + ";"
    '    ElseIf polje <> "" AndAlso fp = True Then
    '        ff = "FILTER=" + Me.txtfF.Text.Trim + "=#FP{" + polje.Trim + "};"
    '    End If

    '    Dim dm As String = "displaymember=" + Me.txtfDM.Text + ";"
    '    Dim vm As String = "valuemember=" + Me.txtfVM.Text + ""
    '    Me.txtCB.Text = pref + "{" + ss + ff + dm + vm + "}"

    '    'CBO{datasource=SELECT distinct NameBashk,CodeBashk,KodiQark FROM AdminDivision;
    '    '        Filter = KodiQark = d.EntPrefecture;
    '    'displaymember = NameBashk;
    '    'valuemember = CodeBashk}
    'End Sub
    'Private Sub cbCWO_CheckedChanged(sender As Object, e As EventArgs)
    '    If cbCWO.Checked = True Then
    '        pref = "CBW"
    '        If Me.txtCB.Text.IndexOf("CBO") = 0 Then Me.txtCB.Text = pref + Me.txtCB.Text.Substring(3)
    '    Else
    '        pref = "CBO"
    '        If Me.txtCB.Text.IndexOf("CBW") = 0 Then Me.txtCB.Text = pref + Me.txtCB.Text.Substring(3)
    '    End If
    'End Sub

    'Private Sub cbG_CheckedChanged(sender As Object, e As EventArgs)
    '    txtWhere.Text = txtWhere.Text.Replace(" and god={GGG}", "")
    '    If cbG.Checked = True Then
    '        cbYY.Checked = False
    '        If txtWhere.Text.Trim = "" Then
    '            txtWhere.Text = "WHERE god={GGG}"
    '        Else
    '            txtWhere.Text = txtWhere.Text + " AND god={GGG}"
    '        End If

    '    End If
    'End Sub
    'Private Sub cbYY_CheckedChanged(sender As Object, e As EventArgs)
    '    txtWhere.Text = txtWhere.Text.Replace(" and ISTYear={YYY}", "")
    '    If cbYY.Checked = True Then
    '        cbG.Checked = False
    '        If txtWhere.Text.Trim = "" Then
    '            txtWhere.Text = "WHERE ISTYear={YYY}"
    '        Else
    '            txtWhere.Text = txtWhere.Text + " AND ISTYear={YYY}"
    '        End If
    '    End If
    'End Sub
    'Private Sub cbM_CheckedChanged(sender As Object, e As EventArgs)
    '    txtWhere.Text = txtWhere.Text.Replace(" and mes={MMM}", "")
    '    If cbM.Checked = True Then
    '        cbMM.Checked = False
    '        If txtWhere.Text.Trim = "" Then
    '            txtWhere.Text = "WHERE mes={MMM}"
    '        Else
    '            txtWhere.Text = txtWhere.Text + " AND mes={MMM}"
    '        End If
    '    End If
    'End Sub
    Function dajUniqueImeISTDB(ByVal tabela As String, ByVal cname As String, ByVal dodpolje As String) As String
        Dim sql As String = ""
        dajUniqueImeISTDB = cname + "1"
        For i As Integer = 1 To 100000
            If dodpolje = "" OrElse dodpolje.IndexOf(cname + CStr(i).Trim + ";") < 0 Then
                sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabela + "'   and  COLUMN_NAME='" + cname + CStr(i).Trim + "'"
                Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                    dajUniqueImeISTDB = cname + CStr(i).Trim
                    sql = "SELECT polje FROM istpolja where sifist='" + sifist + "' and tabela='" + tabela + "' and polje='" + dajUniqueImeISTDB + "'"
                    Dim dtI As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
                    If dtI Is Nothing OrElse dtI.Rows.Count = 0 Then
                        'sve ok
                        Exit For
                    Else
                        'teraj dalje
                    End If
                End If
            End If
        Next
    End Function

    Function getrbr(ByVal sqlrbr As String) As String
        Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
        If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 Then
            getrbr = dt1.Rows(0).Item("rbr").ToString
        Else
            getrbr = "0"
        End If
    End Function

    Function minRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
        Dim str As String = "select min(rbr) as rbr from vrepISTPolja where sifist='" + sifist + "' and tabela='" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%'"
        minRBRTabela = getrbr(str)
    End Function

    Function maxRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
        Dim str As String = "select max(rbr) as rbr from vrepISTPolja where sifist='" + sifist + "' and tabela='" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%'"
        maxRBRTabela = getrbr(str)
    End Function

    Dim dodppolje As String = ""

    Private Sub btnMakeCB_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        'tbc1   - tbc30
        'chbc1
        'cbc1
        Dim ss As String = ""
        Dim br As Integer = 1
        For Each t As Control In Me.Controls
            If TypeOf t Is TextBox AndAlso t.Name.Trim.ToUpper.IndexOf("TBC") = 0 Then
                If t.Text <> "" Then
                    br = br + 1
                End If
            End If
        Next

        Dim brkol As Integer = 0
        For Each t As Control In Me.Controls
            If TypeOf t Is CheckBox AndAlso t.Name.Trim.ToUpper.IndexOf("CHBC") = 0 Then
                If DirectCast(t, CheckBox).Checked = True Then
                    brkol = brkol + 1
                End If
            End If
        Next

        Dim sqlIST As String = "" : Dim sqlDB As String = ""
        Dim ppolje As String = ""
        Dim p2 As String = ""
        Dim str As String = ""
        Dim rrbr As String = pp(4).Trim
        Dim pomrbr As String = ""
        Dim f1 As String = "1"
        Dim trk() As String = pp(3).Split(".")
        If gde <> "" Then
            If trk.Length = 3 Then

                f1 = trk(0).Trim
                If gde = "below" Then f1 = CStr(CInt(f1) + 1).Trim

                Dim currenttab As Integer = CInt(trk(0).Trim)
                Dim minrbrzatab As String = minRBRTabela(currenttab, pp(0).Trim)
                Dim maxrbrzatab As String = maxRBRTabela(currenttab, pp(0).Trim)
                If gde = "above" Then
                    rrbr = minrbrzatab
                Else
                    rrbr = maxrbrzatab
                End If
            Else
                'ako nije tabela
                str = "select max(isnull(f1,0)) as maxf1 from vrepistpolja where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr<" + pp(4).Trim + ""
                f1 = getrbr(str)
                If f1 <> "0" Then f1 = CStr(CInt(f1) + 1).Trim Else f1 = "1"
            End If

            If gde = "above" Then
                pomrbr = rrbr + br * 10
                rrbr = rrbr
            Else
                pomrbr = rrbr
                rrbr = rrbr + br * 10
            End If

            sqlIST = " update istpolja set rbr=rbr+" + CStr(br) + "*10 where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr>=" + rrbr.Trim + ";" + nvrd

            Dim pforma As String = ""

            Dim popis As String = ""
            Dim pizraz As String = ""
            dodppolje = ""
            Dim psql As String = "select isnull(max(chbG),0)+1 as brG from vrepistpolja where  sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and pp ='chbg'"
            Dim pdt As DataTable = izvrsiSQLvratiDT(psql, Me.ISTConnectionString, Nothing)
            Dim brG As String = "1"
            If pdt.Rows.Count > 0 Then brG = pdt.Rows(0).Item("brG").ToString.Trim()
            Dim sqlDBDropTip As String = "" : Dim DropTip As String = ""
            Dim tab As Integer = f1
            Dim red As Integer = 0
            Dim kol As Integer = 1
            Dim t As Integer = 0
            Dim p() As String
            If tbc1.Text <> "" Then
                t = t + 1
                p = sI(tbc1, t, chbc1, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#"
            End If
            If tbc2.Text <> "" Then
                t = t + 1
                p = sI(tbc2, t, chbc2, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc3.Text <> "" Then
                t = t + 1
                p = sI(tbc3, t, chbc3, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc4.Text <> "" Then
                t = t + 1
                p = sI(tbc4, t, chbc4, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc5.Text <> "" Then
                t = t + 1
                p = sI(tbc5, t, chbc5, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc6.Text <> "" Then
                t = t + 1
                p = sI(tbc6, t, chbc6, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc7.Text <> "" Then
                t = t + 1
                p = sI(tbc7, t, chbc7, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc8.Text <> "" Then
                t = t + 1
                p = sI(tbc8, t, chbc8, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc9.Text <> "" Then
                t = t + 1
                p = sI(tbc9, t, chbc9, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If
            If tbc10.Text <> "" Then
                t = t + 1
                p = sI(tbc10, t, chbc10, rrbr, brG, brkol, tab, red, kol, pomrbr).Split("~")
                sqlDB = sqlDB + p(0) : sqlIST = sqlIST + p(2) : sqlDBDropTip = sqlDBDropTip + p(1).ToString.Trim + "#" : DropTip = DropTip + "ADD" + "#"
            End If



            sqlIST = sqlIST + " update a set a.forma=rtrim(ltrim(str((f1+1))+'.'+rtrim(ltrim(str(f2)))+'.'+rtrim(ltrim(str(f3)))))  " +
                             " from istpolja A inner Join vrepistpolja b on a.tabela=b.tabela And a.polje=b.polje And a.vod=b.vod" +
                             " where a.sifist ='" + sifist + "' and a.tabela='" + pp(0).Trim + "' and b.f1>=" + f1 + ";" + nvrd

            p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST,, sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))


            If p2 = "ok" Then
                p2 = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to DB!")
            End If

            If p2 = "nok" Then
                ISTMessageBox.Show("Error!")
            Else
                Me.Cursor = Cursors.Default
                Me.Close()
            End If


        End If

    End Sub

    Function sI(ByVal tb As TextBox, ByVal t As Integer, ByVal chb As CheckBox, ByVal rrbr As String, ByVal brG As String, ByVal brkol As String,
        ByVal tab As Integer, ByRef red As Integer, ByRef kol As Integer, ByVal pomrbr As String) As String
        Dim aligment As String = "R"
        'If chbTR.Checked = True Then aligment = "R"
        Dim popis As String = tb.Text.Trim
        Dim prbr As String = CStr(CInt(rrbr) + t * 10).Trim
        Dim pizraz As String = "checkBox" + aligment + "_G" + brG

        Dim ppolje As String = dajUniqueImeISTDB(pp(0).Trim, "chb_", dodppolje) : dodppolje = dodppolje + ppolje + ";"
        If chb.Checked = True Then red = 1 : kol = kol + 1
        If chb.Checked = False Then red = red + 1
        Dim pforma As String = ""
        If brkol > 0 Then pforma = CStr(tab).Trim + "." + CStr(red).Trim + "." + CStr(kol).Trim

        Dim sD As String = "ALTER TABLE " + pp(0).Trim + " ADD  " + ppolje + " tinyint NULL; ~" + pp(0) + ";" + ppolje + "~"
        sI = sD + "insert into istpolja (sifist,tabela,polje,vod,vdo,rbr,opis,izraz,forma)" + nvrd +
                 " select sifist,tabela,'" + ppolje + "' as polje,vod,vdo,'" + prbr + "' as rbr,N'$" + popis + "','" + pizraz + "','" + pforma + "'" +
                 " from istpolja " +
                 " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr ='" + pomrbr + "';" + nvrd

    End Function

End Class