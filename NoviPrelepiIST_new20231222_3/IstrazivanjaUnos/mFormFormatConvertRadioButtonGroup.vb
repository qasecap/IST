'Option Strict Off

Imports System.Web

Public Class mFormFormatConvertRadioButtonGroup
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
    Friend WithEvents BtnFormat As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbHRB As CheckBox
    Friend WithEvents cbVRB As CheckBox
    Friend WithEvents tbv1 As TextBox
    Friend WithEvents chbc20 As CheckBox
    Friend WithEvents Label24 As Label
    Friend WithEvents tbc20 As TextBox
    Friend WithEvents chbc19 As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents tbc19 As TextBox
    Friend WithEvents chbc18 As CheckBox
    Friend WithEvents Label22 As Label
    Friend WithEvents tbc18 As TextBox
    Friend WithEvents chbc17 As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tbc17 As TextBox
    Friend WithEvents chbc16 As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents tbc16 As TextBox
    Friend WithEvents chbc15 As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbc15 As TextBox
    Friend WithEvents chbc14 As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbc14 As TextBox
    Friend WithEvents chbc13 As CheckBox
    Friend WithEvents Label17 As Label
    Friend WithEvents tbc13 As TextBox
    Friend WithEvents chbc12 As CheckBox
    Friend WithEvents Label16 As Label
    Friend WithEvents tbc12 As TextBox
    Friend WithEvents chbc11 As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbc11 As TextBox
    Friend WithEvents chbc10 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents tbc10 As TextBox
    Friend WithEvents chbc9 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents tbc9 As TextBox
    Friend WithEvents chbc8 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbc8 As TextBox
    Friend WithEvents chbc7 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbc7 As TextBox
    Friend WithEvents chbc6 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbc6 As TextBox
    Friend WithEvents chbc5 As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbc5 As TextBox
    Friend WithEvents chbc4 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbc4 As TextBox
    Friend WithEvents chbc3 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbc3 As TextBox
    Friend WithEvents chbc2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbc2 As TextBox
    Friend WithEvents chbc1 As CheckBox
    Friend WithEvents l1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbc1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents tbv2 As TextBox
    Friend WithEvents tbv3 As TextBox
    Friend WithEvents tbv4 As TextBox
    Friend WithEvents tbv5 As TextBox
    Friend WithEvents tbv6 As TextBox
    Friend WithEvents tbv7 As TextBox
    Friend WithEvents tbv8 As TextBox
    Friend WithEvents tbv9 As TextBox
    Friend WithEvents tbv10 As TextBox
    Friend WithEvents tbv11 As TextBox
    Friend WithEvents tbv12 As TextBox
    Friend WithEvents tbv13 As TextBox
    Friend WithEvents tbv14 As TextBox
    Friend WithEvents tbv15 As TextBox
    Friend WithEvents tbv16 As TextBox
    Friend WithEvents tbv17 As TextBox
    Friend WithEvents tbv18 As TextBox
    Friend WithEvents tbv19 As TextBox
    Friend WithEvents tbv20 As TextBox
    Friend WithEvents txtmcl As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.cbHRB = New System.Windows.Forms.CheckBox()
        Me.cbVRB = New System.Windows.Forms.CheckBox()
        Me.tbv1 = New System.Windows.Forms.TextBox()
        Me.chbc20 = New System.Windows.Forms.CheckBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbc20 = New System.Windows.Forms.TextBox()
        Me.chbc19 = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbc19 = New System.Windows.Forms.TextBox()
        Me.chbc18 = New System.Windows.Forms.CheckBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.tbc18 = New System.Windows.Forms.TextBox()
        Me.chbc17 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbc17 = New System.Windows.Forms.TextBox()
        Me.chbc16 = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbc16 = New System.Windows.Forms.TextBox()
        Me.chbc15 = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbc15 = New System.Windows.Forms.TextBox()
        Me.chbc14 = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbc14 = New System.Windows.Forms.TextBox()
        Me.chbc13 = New System.Windows.Forms.CheckBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tbc13 = New System.Windows.Forms.TextBox()
        Me.chbc12 = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbc12 = New System.Windows.Forms.TextBox()
        Me.chbc11 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tbc11 = New System.Windows.Forms.TextBox()
        Me.chbc10 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbc10 = New System.Windows.Forms.TextBox()
        Me.chbc9 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tbc9 = New System.Windows.Forms.TextBox()
        Me.chbc8 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbc8 = New System.Windows.Forms.TextBox()
        Me.chbc7 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbc7 = New System.Windows.Forms.TextBox()
        Me.chbc6 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbc6 = New System.Windows.Forms.TextBox()
        Me.chbc5 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbc5 = New System.Windows.Forms.TextBox()
        Me.chbc4 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbc4 = New System.Windows.Forms.TextBox()
        Me.chbc3 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbc3 = New System.Windows.Forms.TextBox()
        Me.chbc2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbc2 = New System.Windows.Forms.TextBox()
        Me.chbc1 = New System.Windows.Forms.CheckBox()
        Me.l1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbc1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbv2 = New System.Windows.Forms.TextBox()
        Me.tbv3 = New System.Windows.Forms.TextBox()
        Me.tbv4 = New System.Windows.Forms.TextBox()
        Me.tbv5 = New System.Windows.Forms.TextBox()
        Me.tbv6 = New System.Windows.Forms.TextBox()
        Me.tbv7 = New System.Windows.Forms.TextBox()
        Me.tbv8 = New System.Windows.Forms.TextBox()
        Me.tbv9 = New System.Windows.Forms.TextBox()
        Me.tbv10 = New System.Windows.Forms.TextBox()
        Me.tbv11 = New System.Windows.Forms.TextBox()
        Me.tbv12 = New System.Windows.Forms.TextBox()
        Me.tbv13 = New System.Windows.Forms.TextBox()
        Me.tbv14 = New System.Windows.Forms.TextBox()
        Me.tbv15 = New System.Windows.Forms.TextBox()
        Me.tbv16 = New System.Windows.Forms.TextBox()
        Me.tbv17 = New System.Windows.Forms.TextBox()
        Me.tbv18 = New System.Windows.Forms.TextBox()
        Me.tbv19 = New System.Windows.Forms.TextBox()
        Me.tbv20 = New System.Windows.Forms.TextBox()
        Me.txtmcl = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(372, 4)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(89, 23)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.TabStop = False
        Me.BtnFormat.Text = "Insert"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "RadioButton group"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 610)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(475, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'cbHRB
        '
        Me.cbHRB.AccessibleName = ""
        Me.cbHRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHRB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHRB.Location = New System.Drawing.Point(139, 38)
        Me.cbHRB.Name = "cbHRB"
        Me.cbHRB.Size = New System.Drawing.Size(87, 19)
        Me.cbHRB.TabIndex = 336
        Me.cbHRB.Text = "Horizontal "
        '
        'cbVRB
        '
        Me.cbVRB.AccessibleName = ""
        Me.cbVRB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbVRB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVRB.Location = New System.Drawing.Point(18, 38)
        Me.cbVRB.Name = "cbVRB"
        Me.cbVRB.Size = New System.Drawing.Size(87, 19)
        Me.cbVRB.TabIndex = 335
        Me.cbVRB.Text = "Vertical"
        '
        'tbv1
        '
        Me.tbv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv1.Location = New System.Drawing.Point(372, 119)
        Me.tbv1.Name = "tbv1"
        Me.tbv1.Size = New System.Drawing.Size(89, 20)
        Me.tbv1.TabIndex = 559
        '
        'chbc20
        '
        Me.chbc20.AccessibleName = ""
        Me.chbc20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc20.Location = New System.Drawing.Point(316, 537)
        Me.chbc20.Name = "chbc20"
        Me.chbc20.Size = New System.Drawing.Size(35, 20)
        Me.chbc20.TabIndex = 555
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 537)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 20)
        Me.Label24.TabIndex = 556
        Me.Label24.Text = "20"
        '
        'tbc20
        '
        Me.tbc20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc20.Location = New System.Drawing.Point(52, 537)
        Me.tbc20.Name = "tbc20"
        Me.tbc20.Size = New System.Drawing.Size(250, 20)
        Me.tbc20.TabIndex = 557
        '
        'chbc19
        '
        Me.chbc19.AccessibleName = ""
        Me.chbc19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc19.Location = New System.Drawing.Point(316, 515)
        Me.chbc19.Name = "chbc19"
        Me.chbc19.Size = New System.Drawing.Size(35, 20)
        Me.chbc19.TabIndex = 551
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 515)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 552
        Me.Label23.Text = "19"
        '
        'tbc19
        '
        Me.tbc19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc19.Location = New System.Drawing.Point(52, 515)
        Me.tbc19.Name = "tbc19"
        Me.tbc19.Size = New System.Drawing.Size(250, 20)
        Me.tbc19.TabIndex = 553
        '
        'chbc18
        '
        Me.chbc18.AccessibleName = ""
        Me.chbc18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc18.Location = New System.Drawing.Point(316, 493)
        Me.chbc18.Name = "chbc18"
        Me.chbc18.Size = New System.Drawing.Size(35, 20)
        Me.chbc18.TabIndex = 547
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 493)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(30, 20)
        Me.Label22.TabIndex = 548
        Me.Label22.Text = "18"
        '
        'tbc18
        '
        Me.tbc18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc18.Location = New System.Drawing.Point(52, 493)
        Me.tbc18.Name = "tbc18"
        Me.tbc18.Size = New System.Drawing.Size(250, 20)
        Me.tbc18.TabIndex = 549
        '
        'chbc17
        '
        Me.chbc17.AccessibleName = ""
        Me.chbc17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc17.Location = New System.Drawing.Point(316, 471)
        Me.chbc17.Name = "chbc17"
        Me.chbc17.Size = New System.Drawing.Size(35, 20)
        Me.chbc17.TabIndex = 543
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 471)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 20)
        Me.Label21.TabIndex = 544
        Me.Label21.Text = "17"
        '
        'tbc17
        '
        Me.tbc17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc17.Location = New System.Drawing.Point(52, 471)
        Me.tbc17.Name = "tbc17"
        Me.tbc17.Size = New System.Drawing.Size(250, 20)
        Me.tbc17.TabIndex = 545
        '
        'chbc16
        '
        Me.chbc16.AccessibleName = ""
        Me.chbc16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc16.Location = New System.Drawing.Point(316, 449)
        Me.chbc16.Name = "chbc16"
        Me.chbc16.Size = New System.Drawing.Size(35, 20)
        Me.chbc16.TabIndex = 539
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(16, 449)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(30, 20)
        Me.Label20.TabIndex = 540
        Me.Label20.Text = "16"
        '
        'tbc16
        '
        Me.tbc16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc16.Location = New System.Drawing.Point(52, 449)
        Me.tbc16.Name = "tbc16"
        Me.tbc16.Size = New System.Drawing.Size(250, 20)
        Me.tbc16.TabIndex = 541
        '
        'chbc15
        '
        Me.chbc15.AccessibleName = ""
        Me.chbc15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc15.Location = New System.Drawing.Point(316, 427)
        Me.chbc15.Name = "chbc15"
        Me.chbc15.Size = New System.Drawing.Size(35, 20)
        Me.chbc15.TabIndex = 535
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 427)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(30, 20)
        Me.Label19.TabIndex = 536
        Me.Label19.Text = "15"
        '
        'tbc15
        '
        Me.tbc15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc15.Location = New System.Drawing.Point(52, 427)
        Me.tbc15.Name = "tbc15"
        Me.tbc15.Size = New System.Drawing.Size(250, 20)
        Me.tbc15.TabIndex = 537
        '
        'chbc14
        '
        Me.chbc14.AccessibleName = ""
        Me.chbc14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc14.Location = New System.Drawing.Point(316, 405)
        Me.chbc14.Name = "chbc14"
        Me.chbc14.Size = New System.Drawing.Size(35, 20)
        Me.chbc14.TabIndex = 531
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 405)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(30, 20)
        Me.Label18.TabIndex = 532
        Me.Label18.Text = "14"
        '
        'tbc14
        '
        Me.tbc14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc14.Location = New System.Drawing.Point(52, 405)
        Me.tbc14.Name = "tbc14"
        Me.tbc14.Size = New System.Drawing.Size(250, 20)
        Me.tbc14.TabIndex = 533
        '
        'chbc13
        '
        Me.chbc13.AccessibleName = ""
        Me.chbc13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc13.Location = New System.Drawing.Point(316, 383)
        Me.chbc13.Name = "chbc13"
        Me.chbc13.Size = New System.Drawing.Size(35, 20)
        Me.chbc13.TabIndex = 527
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 383)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 20)
        Me.Label17.TabIndex = 528
        Me.Label17.Text = "13"
        '
        'tbc13
        '
        Me.tbc13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc13.Location = New System.Drawing.Point(52, 383)
        Me.tbc13.Name = "tbc13"
        Me.tbc13.Size = New System.Drawing.Size(250, 20)
        Me.tbc13.TabIndex = 529
        '
        'chbc12
        '
        Me.chbc12.AccessibleName = ""
        Me.chbc12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc12.Location = New System.Drawing.Point(316, 361)
        Me.chbc12.Name = "chbc12"
        Me.chbc12.Size = New System.Drawing.Size(35, 20)
        Me.chbc12.TabIndex = 523
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 361)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(30, 20)
        Me.Label16.TabIndex = 524
        Me.Label16.Text = "12"
        '
        'tbc12
        '
        Me.tbc12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc12.Location = New System.Drawing.Point(52, 361)
        Me.tbc12.Name = "tbc12"
        Me.tbc12.Size = New System.Drawing.Size(250, 20)
        Me.tbc12.TabIndex = 525
        '
        'chbc11
        '
        Me.chbc11.AccessibleName = ""
        Me.chbc11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc11.Location = New System.Drawing.Point(316, 339)
        Me.chbc11.Name = "chbc11"
        Me.chbc11.Size = New System.Drawing.Size(35, 20)
        Me.chbc11.TabIndex = 519
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 339)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 20)
        Me.Label15.TabIndex = 520
        Me.Label15.Text = "11"
        '
        'tbc11
        '
        Me.tbc11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc11.Location = New System.Drawing.Point(52, 339)
        Me.tbc11.Name = "tbc11"
        Me.tbc11.Size = New System.Drawing.Size(250, 20)
        Me.tbc11.TabIndex = 521
        '
        'chbc10
        '
        Me.chbc10.AccessibleName = ""
        Me.chbc10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc10.Location = New System.Drawing.Point(316, 317)
        Me.chbc10.Name = "chbc10"
        Me.chbc10.Size = New System.Drawing.Size(35, 20)
        Me.chbc10.TabIndex = 515
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 317)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 20)
        Me.Label14.TabIndex = 516
        Me.Label14.Text = "10"
        '
        'tbc10
        '
        Me.tbc10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc10.Location = New System.Drawing.Point(52, 317)
        Me.tbc10.Name = "tbc10"
        Me.tbc10.Size = New System.Drawing.Size(250, 20)
        Me.tbc10.TabIndex = 517
        '
        'chbc9
        '
        Me.chbc9.AccessibleName = ""
        Me.chbc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc9.Location = New System.Drawing.Point(316, 295)
        Me.chbc9.Name = "chbc9"
        Me.chbc9.Size = New System.Drawing.Size(35, 20)
        Me.chbc9.TabIndex = 511
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 295)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 512
        Me.Label13.Text = "9"
        '
        'tbc9
        '
        Me.tbc9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc9.Location = New System.Drawing.Point(52, 295)
        Me.tbc9.Name = "tbc9"
        Me.tbc9.Size = New System.Drawing.Size(250, 20)
        Me.tbc9.TabIndex = 513
        '
        'chbc8
        '
        Me.chbc8.AccessibleName = ""
        Me.chbc8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc8.Location = New System.Drawing.Point(316, 273)
        Me.chbc8.Name = "chbc8"
        Me.chbc8.Size = New System.Drawing.Size(35, 20)
        Me.chbc8.TabIndex = 507
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 273)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(30, 20)
        Me.Label12.TabIndex = 508
        Me.Label12.Text = "8"
        '
        'tbc8
        '
        Me.tbc8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc8.Location = New System.Drawing.Point(52, 273)
        Me.tbc8.Name = "tbc8"
        Me.tbc8.Size = New System.Drawing.Size(250, 20)
        Me.tbc8.TabIndex = 509
        '
        'chbc7
        '
        Me.chbc7.AccessibleName = ""
        Me.chbc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc7.Location = New System.Drawing.Point(316, 251)
        Me.chbc7.Name = "chbc7"
        Me.chbc7.Size = New System.Drawing.Size(35, 20)
        Me.chbc7.TabIndex = 503
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(16, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 504
        Me.Label11.Text = "7"
        '
        'tbc7
        '
        Me.tbc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc7.Location = New System.Drawing.Point(52, 251)
        Me.tbc7.Name = "tbc7"
        Me.tbc7.Size = New System.Drawing.Size(250, 20)
        Me.tbc7.TabIndex = 505
        '
        'chbc6
        '
        Me.chbc6.AccessibleName = ""
        Me.chbc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc6.Location = New System.Drawing.Point(316, 229)
        Me.chbc6.Name = "chbc6"
        Me.chbc6.Size = New System.Drawing.Size(35, 20)
        Me.chbc6.TabIndex = 499
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 229)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 500
        Me.Label10.Text = "6"
        '
        'tbc6
        '
        Me.tbc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc6.Location = New System.Drawing.Point(52, 229)
        Me.tbc6.Name = "tbc6"
        Me.tbc6.Size = New System.Drawing.Size(250, 20)
        Me.tbc6.TabIndex = 501
        '
        'chbc5
        '
        Me.chbc5.AccessibleName = ""
        Me.chbc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc5.Location = New System.Drawing.Point(316, 207)
        Me.chbc5.Name = "chbc5"
        Me.chbc5.Size = New System.Drawing.Size(35, 20)
        Me.chbc5.TabIndex = 495
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 20)
        Me.Label7.TabIndex = 496
        Me.Label7.Text = "5"
        '
        'tbc5
        '
        Me.tbc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc5.Location = New System.Drawing.Point(52, 207)
        Me.tbc5.Name = "tbc5"
        Me.tbc5.Size = New System.Drawing.Size(250, 20)
        Me.tbc5.TabIndex = 497
        '
        'chbc4
        '
        Me.chbc4.AccessibleName = ""
        Me.chbc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc4.Location = New System.Drawing.Point(316, 185)
        Me.chbc4.Name = "chbc4"
        Me.chbc4.Size = New System.Drawing.Size(35, 20)
        Me.chbc4.TabIndex = 491
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 492
        Me.Label6.Text = "4"
        '
        'tbc4
        '
        Me.tbc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc4.Location = New System.Drawing.Point(52, 185)
        Me.tbc4.Name = "tbc4"
        Me.tbc4.Size = New System.Drawing.Size(250, 20)
        Me.tbc4.TabIndex = 493
        '
        'chbc3
        '
        Me.chbc3.AccessibleName = ""
        Me.chbc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc3.Location = New System.Drawing.Point(316, 163)
        Me.chbc3.Name = "chbc3"
        Me.chbc3.Size = New System.Drawing.Size(35, 20)
        Me.chbc3.TabIndex = 487
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 488
        Me.Label5.Text = "3"
        '
        'tbc3
        '
        Me.tbc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc3.Location = New System.Drawing.Point(52, 163)
        Me.tbc3.Name = "tbc3"
        Me.tbc3.Size = New System.Drawing.Size(250, 20)
        Me.tbc3.TabIndex = 489
        '
        'chbc2
        '
        Me.chbc2.AccessibleName = ""
        Me.chbc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc2.Location = New System.Drawing.Point(316, 141)
        Me.chbc2.Name = "chbc2"
        Me.chbc2.Size = New System.Drawing.Size(35, 20)
        Me.chbc2.TabIndex = 483
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 20)
        Me.Label3.TabIndex = 484
        Me.Label3.Text = "2"
        '
        'tbc2
        '
        Me.tbc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc2.Location = New System.Drawing.Point(52, 141)
        Me.tbc2.Name = "tbc2"
        Me.tbc2.Size = New System.Drawing.Size(250, 20)
        Me.tbc2.TabIndex = 485
        '
        'chbc1
        '
        Me.chbc1.AccessibleName = ""
        Me.chbc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbc1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbc1.Location = New System.Drawing.Point(316, 119)
        Me.chbc1.Name = "chbc1"
        Me.chbc1.Size = New System.Drawing.Size(35, 20)
        Me.chbc1.TabIndex = 475
        Me.chbc1.Visible = False
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(16, 119)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(30, 20)
        Me.l1.TabIndex = 480
        Me.l1.Text = "1"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 50)
        Me.Label4.TabIndex = 479
        Me.Label4.Text = "No"
        '
        'tbc1
        '
        Me.tbc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc1.Location = New System.Drawing.Point(52, 119)
        Me.tbc1.Name = "tbc1"
        Me.tbc1.Size = New System.Drawing.Size(250, 20)
        Me.tbc1.TabIndex = 481
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(52, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(250, 50)
        Me.Label9.TabIndex = 477
        Me.Label9.Text = "Option text"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(303, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(67, 50)
        Me.Label25.TabIndex = 478
        Me.Label25.Text = "Start new column"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label26.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(372, 68)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 50)
        Me.Label26.TabIndex = 476
        Me.Label26.Text = "Option value"
        '
        'tbv2
        '
        Me.tbv2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv2.Location = New System.Drawing.Point(372, 141)
        Me.tbv2.Name = "tbv2"
        Me.tbv2.Size = New System.Drawing.Size(89, 20)
        Me.tbv2.TabIndex = 565
        '
        'tbv3
        '
        Me.tbv3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv3.Location = New System.Drawing.Point(372, 163)
        Me.tbv3.Name = "tbv3"
        Me.tbv3.Size = New System.Drawing.Size(89, 20)
        Me.tbv3.TabIndex = 566
        '
        'tbv4
        '
        Me.tbv4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv4.Location = New System.Drawing.Point(372, 185)
        Me.tbv4.Name = "tbv4"
        Me.tbv4.Size = New System.Drawing.Size(89, 20)
        Me.tbv4.TabIndex = 567
        '
        'tbv5
        '
        Me.tbv5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv5.Location = New System.Drawing.Point(372, 207)
        Me.tbv5.Name = "tbv5"
        Me.tbv5.Size = New System.Drawing.Size(89, 20)
        Me.tbv5.TabIndex = 568
        '
        'tbv6
        '
        Me.tbv6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv6.Location = New System.Drawing.Point(372, 229)
        Me.tbv6.Name = "tbv6"
        Me.tbv6.Size = New System.Drawing.Size(89, 20)
        Me.tbv6.TabIndex = 569
        '
        'tbv7
        '
        Me.tbv7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv7.Location = New System.Drawing.Point(372, 251)
        Me.tbv7.Name = "tbv7"
        Me.tbv7.Size = New System.Drawing.Size(89, 20)
        Me.tbv7.TabIndex = 570
        '
        'tbv8
        '
        Me.tbv8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv8.Location = New System.Drawing.Point(372, 273)
        Me.tbv8.Name = "tbv8"
        Me.tbv8.Size = New System.Drawing.Size(89, 20)
        Me.tbv8.TabIndex = 571
        '
        'tbv9
        '
        Me.tbv9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv9.Location = New System.Drawing.Point(372, 295)
        Me.tbv9.Name = "tbv9"
        Me.tbv9.Size = New System.Drawing.Size(89, 20)
        Me.tbv9.TabIndex = 572
        '
        'tbv10
        '
        Me.tbv10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv10.Location = New System.Drawing.Point(372, 317)
        Me.tbv10.Name = "tbv10"
        Me.tbv10.Size = New System.Drawing.Size(89, 20)
        Me.tbv10.TabIndex = 573
        '
        'tbv11
        '
        Me.tbv11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv11.Location = New System.Drawing.Point(372, 339)
        Me.tbv11.Name = "tbv11"
        Me.tbv11.Size = New System.Drawing.Size(89, 20)
        Me.tbv11.TabIndex = 574
        '
        'tbv12
        '
        Me.tbv12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv12.Location = New System.Drawing.Point(372, 361)
        Me.tbv12.Name = "tbv12"
        Me.tbv12.Size = New System.Drawing.Size(89, 20)
        Me.tbv12.TabIndex = 575
        '
        'tbv13
        '
        Me.tbv13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv13.Location = New System.Drawing.Point(372, 383)
        Me.tbv13.Name = "tbv13"
        Me.tbv13.Size = New System.Drawing.Size(89, 20)
        Me.tbv13.TabIndex = 576
        '
        'tbv14
        '
        Me.tbv14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv14.Location = New System.Drawing.Point(372, 405)
        Me.tbv14.Name = "tbv14"
        Me.tbv14.Size = New System.Drawing.Size(89, 20)
        Me.tbv14.TabIndex = 577
        '
        'tbv15
        '
        Me.tbv15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv15.Location = New System.Drawing.Point(372, 427)
        Me.tbv15.Name = "tbv15"
        Me.tbv15.Size = New System.Drawing.Size(89, 20)
        Me.tbv15.TabIndex = 578
        '
        'tbv16
        '
        Me.tbv16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv16.Location = New System.Drawing.Point(372, 449)
        Me.tbv16.Name = "tbv16"
        Me.tbv16.Size = New System.Drawing.Size(89, 20)
        Me.tbv16.TabIndex = 579
        '
        'tbv17
        '
        Me.tbv17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv17.Location = New System.Drawing.Point(372, 471)
        Me.tbv17.Name = "tbv17"
        Me.tbv17.Size = New System.Drawing.Size(89, 20)
        Me.tbv17.TabIndex = 580
        '
        'tbv18
        '
        Me.tbv18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv18.Location = New System.Drawing.Point(372, 493)
        Me.tbv18.Name = "tbv18"
        Me.tbv18.Size = New System.Drawing.Size(89, 20)
        Me.tbv18.TabIndex = 581
        '
        'tbv19
        '
        Me.tbv19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv19.Location = New System.Drawing.Point(372, 515)
        Me.tbv19.Name = "tbv19"
        Me.tbv19.Size = New System.Drawing.Size(89, 20)
        Me.tbv19.TabIndex = 582
        '
        'tbv20
        '
        Me.tbv20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbv20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbv20.Location = New System.Drawing.Point(372, 537)
        Me.tbv20.Name = "tbv20"
        Me.tbv20.Size = New System.Drawing.Size(89, 20)
        Me.tbv20.TabIndex = 583
        '
        'txtmcl
        '
        Me.txtmcl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmcl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmcl.Location = New System.Drawing.Point(372, 579)
        Me.txtmcl.Name = "txtmcl"
        Me.txtmcl.Size = New System.Drawing.Size(89, 21)
        Me.txtmcl.TabIndex = 584
        Me.txtmcl.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AccessibleName = ""
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(33, 579)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox1.Size = New System.Drawing.Size(298, 19)
        Me.CheckBox1.TabIndex = 587
        Me.CheckBox1.Text = "If muticolumn  add column length"
        '
        'mFormFormatConvertRadioButtonGroup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(475, 640)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtmcl)
        Me.Controls.Add(Me.tbv20)
        Me.Controls.Add(Me.tbv19)
        Me.Controls.Add(Me.tbv18)
        Me.Controls.Add(Me.tbv17)
        Me.Controls.Add(Me.tbv16)
        Me.Controls.Add(Me.tbv15)
        Me.Controls.Add(Me.tbv14)
        Me.Controls.Add(Me.tbv13)
        Me.Controls.Add(Me.tbv12)
        Me.Controls.Add(Me.tbv11)
        Me.Controls.Add(Me.tbv10)
        Me.Controls.Add(Me.tbv9)
        Me.Controls.Add(Me.tbv8)
        Me.Controls.Add(Me.tbv7)
        Me.Controls.Add(Me.tbv6)
        Me.Controls.Add(Me.tbv5)
        Me.Controls.Add(Me.tbv4)
        Me.Controls.Add(Me.tbv3)
        Me.Controls.Add(Me.tbv2)
        Me.Controls.Add(Me.tbv1)
        Me.Controls.Add(Me.chbc20)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.tbc20)
        Me.Controls.Add(Me.chbc19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.tbc19)
        Me.Controls.Add(Me.chbc18)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.tbc18)
        Me.Controls.Add(Me.chbc17)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.tbc17)
        Me.Controls.Add(Me.chbc16)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.tbc16)
        Me.Controls.Add(Me.chbc15)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tbc15)
        Me.Controls.Add(Me.chbc14)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tbc14)
        Me.Controls.Add(Me.chbc13)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tbc13)
        Me.Controls.Add(Me.chbc12)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.tbc12)
        Me.Controls.Add(Me.chbc11)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tbc11)
        Me.Controls.Add(Me.chbc10)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbc10)
        Me.Controls.Add(Me.chbc9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tbc9)
        Me.Controls.Add(Me.chbc8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbc8)
        Me.Controls.Add(Me.chbc7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tbc7)
        Me.Controls.Add(Me.chbc6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tbc6)
        Me.Controls.Add(Me.chbc5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tbc5)
        Me.Controls.Add(Me.chbc4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tbc4)
        Me.Controls.Add(Me.chbc3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbc3)
        Me.Controls.Add(Me.chbc2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbc2)
        Me.Controls.Add(Me.chbc1)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbc1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cbHRB)
        Me.Controls.Add(Me.cbVRB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormFormatConvertRadioButtonGroup"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RadioButton group"
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
    Dim what As String
    Dim pp() As String
    Dim ISTDB As Boolean
    Dim IST As Boolean
    Dim dIst As DatasetIstrazivanja

    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.what = what
        Me.dIst = dIst
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")

        Me.Text = Me.what
        cbVRB.Checked = True
        If Me.what.Trim.ToUpper = "CONVERT" Then
            Me.Label1.Text = Me.what + " to RadioButton group"
        ElseIf Me.what.Trim.ToUpper = "FORMAT" Then
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    getMetaDataPaneP1()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
            Me.Label1.Text = Me.what + " RadioButton group"
        End If

    End Sub

    Dim iizraz As String = ""
    Dim vs As String = ""

    Function getDTC() As System.Data.DataTable
        iizraz = ""
        vs = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select izraz,vs" +
                " from ISTPolja " +
                " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "' and izraz like '%radiobutton%'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        iizraz = dt.Rows(0).Item("izraz").ToString.Trim
        vs = dt.Rows(0).Item("vs").ToString.Trim
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        Call fformatConvert()
    End Sub

    Sub fformatConvert()

        Dim sqlIST As String = ""
        Dim ppolje As String = pp(2).Trim
        Dim rrbr As String = pp(4).Trim
        Dim p2 As String = ""
        Dim pvs As String = ""

        Dim pizraz As String = ostatakIzraz + setMetaDataPaneP1()
        sqlIST = "update istpolja set" + nvrd +
                " izraz=N'" + pizraz + "'" +
                " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "' and rbr ='" + pp(4).Trim + "'"

        p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST)

        If p2 = "nok" Then ISTMessageBox.Show("Error!") Else Me.Close()

    End Sub

    Dim ostatakIzraz As String = ""

    Function setMetaDataPaneP1() As String
        'RadioButtonV{'ДА','НЕ'}
        'RadioButtonV{1'Znatno bolja',2'Nešto bolja',3'Bez promena',4'Nešto lošija',5'Znatno lošija',9'Ne znam'}
        Dim ss As String = ""
        Dim sso As String = ""
        For brK As Integer = 1 To 20
            sso = ""

            Dim tbv As TextBox = NadjiKontrolu(Me, "tbv" + Str(brK).Trim)
            Dim tbc As TextBox = NadjiKontrolu(Me, "tbc" + Str(brK).Trim)
            Dim chb As CheckBox = NadjiKontrolu(Me, "chbc" + Str(brK).Trim)

            If Not chb Is Nothing AndAlso chb.Checked = True Then ss = ss.TrimEnd(",") : ss = ss + "\n"

            If Not tbv Is Nothing Then
                If tbv.Text <> "" Then sso = tbv.Text
                If tbv.Text = "" AndAlso Not tbc Is Nothing AndAlso tbc.Text <> "" Then sso = Str(brK).Trim
            End If

            If Not tbc Is Nothing AndAlso tbc.Text.Trim <> "" Then sso = sso + "''" + tbc.Text + "''"
            If sso.Trim <> "" Then ss = ss + sso + ","

        Next
        'RadioButtonV{''повећан'',''непромењен'',''смањен''}
        'COLUMNLENGHT = 40
        ss = ss.TrimEnd(",")
        If cbVRB.Checked = True Then ss = "RadioButtonV{" + ss + "}"
        If cbHRB.Checked = True Then ss = "RadioButtonH{" + ss + "}"

        If txtmcl.Text.Trim <> "" AndAlso IsNumeric(txtmcl.Text.Trim) Then ss = ss + ";COLUMNLENGHT=" + txtmcl.Text.Trim

        Return ss

    End Function

    Sub getMetaDataPaneP1()
        'If vs.Trim <> "" Then Me.txtVS.Text = vs
        'Dim dgv As String
        'dgvRB.Rows.Clear()
        Dim radiobuttonvo As String = ""
        Dim radiobuttonv As String = ""

        If iizraz Is Nothing Then iizraz = "" : Exit Sub
        Dim iizrazORG As String = iizraz
        iizraz = Replace(iizraz, "multiline", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "fontbold", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "readonly", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "fontitalic", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "fontunderline", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "visiblefalse", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "enablefalse", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "frighta", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "fcentera", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "fcentrea", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "pcentarp", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "pdesnop", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "fcentera", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "borderfixed", "", 1, , CompareMethod.Text)
        iizraz = Replace(iizraz, "bordernone", "", 1, , CompareMethod.Text)

        ostatakIzraz = Replace(iizrazORG, iizraz, "", 1, , CompareMethod.Text)

        Dim pp() As String = iizraz.Split(";")
        Dim brK As Integer = 0
        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Trim.ToUpper.IndexOf("RADIOBUTTONV") >= 0 Then
                cbVRB.Checked = True
                Dim rbb() As String = pp(i).Trim.ToUpper.Replace("RADIOBUTTONV{", "").Replace("}", "").Split(",")
                For j As Integer = 0 To rbb.GetUpperBound(0)
                    radiobuttonvo = rbb(j).Split("'")(1)
                    radiobuttonv = rbb(j).Split("'")(0)
                    brK = brK + 1
                    Dim tbc As TextBox = NadjiKontrolu(Me, "tbc" + Str(brK).Trim)
                    If Not tbc Is Nothing Then tbc.Text = radiobuttonvo
                    Dim tbv As TextBox = NadjiKontrolu(Me, "tbv" + Str(brK).Trim)
                    If Not tbv Is Nothing Then tbv.Text = radiobuttonv

                Next
            ElseIf pp(i).Trim.ToUpper.IndexOf("RADIOBUTTONH") >= 0 Then
                cbHRB.Checked = True
                Dim rbb() As String = pp(i).Trim.ToUpper.Replace("RADIOBUTTONH{", "").Replace("}", "").Split(",")
                For j As Integer = 0 To rbb.GetUpperBound(0)
                    radiobuttonvo = rbb(j).Split("'")(1)
                    radiobuttonv = rbb(j).Split("'")(0)
                    Dim tbc As TextBox = NadjiKontrolu(Me, "tbc" + Str(brK).Trim)
                    If Not tbc Is Nothing Then tbc.Text = radiobuttonvo
                    Dim tbv As TextBox = NadjiKontrolu(Me, "tbv" + Str(brK).Trim)
                    If Not tbv Is Nothing Then tbv.Text = radiobuttonv
                Next
            End If
        Next

    End Sub

    Private Sub cbVRB_Click(sender As Object, e As EventArgs) Handles cbVRB.Click
        cbHRB.Checked = Not cbVRB.Checked

    End Sub

    Private Sub cbhRB_Click(sender As Object, e As EventArgs) Handles cbHRB.Click
        cbVRB.Checked = Not cbHRB.Checked
    End Sub

End Class