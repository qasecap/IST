'Option Strict Off

Imports System.Web

Public Class mFormExitEventStop
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
    Friend WithEvents btnStop As Button
    Friend WithEvents pStop19 As Label
    Friend WithEvents pStop18 As Label
    Friend WithEvents pStop17 As Label
    Friend WithEvents pStop16 As Label
    Friend WithEvents pStop15 As Label
    Friend WithEvents pStop14 As Label
    Friend WithEvents pStop13 As Label
    Friend WithEvents pStop12 As Label
    Friend WithEvents pStop11 As Label
    Friend WithEvents pStop10 As Label
    Friend WithEvents pStop9 As Label
    Friend WithEvents pStop8 As Label
    Friend WithEvents pStop7 As Label
    Friend WithEvents pStop6 As Label
    Friend WithEvents pStop5 As Label
    Friend WithEvents pStop4 As Label
    Friend WithEvents pStop3 As Label
    Friend WithEvents pStop2 As Label
    Friend WithEvents pStop1 As Label
    Friend WithEvents tStopMsg20 As TextBox
    Friend WithEvents tStopMsg19 As TextBox
    Friend WithEvents tStopMsg18 As TextBox
    Friend WithEvents tStopMsg17 As TextBox
    Friend WithEvents tStopMsg16 As TextBox
    Friend WithEvents tStopMsg15 As TextBox
    Friend WithEvents tStopMsg14 As TextBox
    Friend WithEvents tStopMsg13 As TextBox
    Friend WithEvents tStopMsg12 As TextBox
    Friend WithEvents tStopMsg11 As TextBox
    Friend WithEvents tStopMsg10 As TextBox
    Friend WithEvents tStopMsg9 As TextBox
    Friend WithEvents tStopMsg8 As TextBox
    Friend WithEvents tStopMsg7 As TextBox
    Friend WithEvents tStopMsg6 As TextBox
    Friend WithEvents tStopMsg5 As TextBox
    Friend WithEvents tStopMsg4 As TextBox
    Friend WithEvents tStopMsg3 As TextBox
    Friend WithEvents tStopMsg2 As TextBox
    Friend WithEvents tStopMsg1 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents lStop20 As Label
    Friend WithEvents tStopIf20 As TextBox
    Friend WithEvents lStop19 As Label
    Friend WithEvents tStopIf19 As TextBox
    Friend WithEvents lStop18 As Label
    Friend WithEvents tStopIf18 As TextBox
    Friend WithEvents lStop17 As Label
    Friend WithEvents tStopIf17 As TextBox
    Friend WithEvents lStop16 As Label
    Friend WithEvents tStopIf16 As TextBox
    Friend WithEvents lStop15 As Label
    Friend WithEvents tStopIf15 As TextBox
    Friend WithEvents lStop14 As Label
    Friend WithEvents tStopIf14 As TextBox
    Friend WithEvents lStop13 As Label
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents lStop12 As Label
    Friend WithEvents tStopIf12 As TextBox
    Friend WithEvents lStop11 As Label
    Friend WithEvents tStopIf11 As TextBox
    Friend WithEvents lStop10 As Label
    Friend WithEvents tStopIf10 As TextBox
    Friend WithEvents lStop9 As Label
    Friend WithEvents tStopIf9 As TextBox
    Friend WithEvents lStop8 As Label
    Friend WithEvents tStopIf8 As TextBox
    Friend WithEvents lStop7 As Label
    Friend WithEvents tStopIf7 As TextBox
    Friend WithEvents lStop6 As Label
    Friend WithEvents tStopIf6 As TextBox
    Friend WithEvents lStop5 As Label
    Friend WithEvents tStopIf5 As TextBox
    Friend WithEvents lStop4 As Label
    Friend WithEvents tStopIf4 As TextBox
    Friend WithEvents lStop3 As Label
    Friend WithEvents tStopIf3 As TextBox
    Friend WithEvents lStop2 As Label
    Friend WithEvents tStopIf2 As TextBox
    Friend WithEvents lStop1 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents tStopIf1 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.pStop19 = New System.Windows.Forms.Label()
        Me.pStop18 = New System.Windows.Forms.Label()
        Me.pStop17 = New System.Windows.Forms.Label()
        Me.pStop16 = New System.Windows.Forms.Label()
        Me.pStop15 = New System.Windows.Forms.Label()
        Me.pStop14 = New System.Windows.Forms.Label()
        Me.pStop13 = New System.Windows.Forms.Label()
        Me.pStop12 = New System.Windows.Forms.Label()
        Me.pStop11 = New System.Windows.Forms.Label()
        Me.pStop10 = New System.Windows.Forms.Label()
        Me.pStop9 = New System.Windows.Forms.Label()
        Me.pStop8 = New System.Windows.Forms.Label()
        Me.pStop7 = New System.Windows.Forms.Label()
        Me.pStop6 = New System.Windows.Forms.Label()
        Me.pStop5 = New System.Windows.Forms.Label()
        Me.pStop4 = New System.Windows.Forms.Label()
        Me.pStop3 = New System.Windows.Forms.Label()
        Me.pStop2 = New System.Windows.Forms.Label()
        Me.pStop1 = New System.Windows.Forms.Label()
        Me.tStopMsg20 = New System.Windows.Forms.TextBox()
        Me.tStopMsg19 = New System.Windows.Forms.TextBox()
        Me.tStopMsg18 = New System.Windows.Forms.TextBox()
        Me.tStopMsg17 = New System.Windows.Forms.TextBox()
        Me.tStopMsg16 = New System.Windows.Forms.TextBox()
        Me.tStopMsg15 = New System.Windows.Forms.TextBox()
        Me.tStopMsg14 = New System.Windows.Forms.TextBox()
        Me.tStopMsg13 = New System.Windows.Forms.TextBox()
        Me.tStopMsg12 = New System.Windows.Forms.TextBox()
        Me.tStopMsg11 = New System.Windows.Forms.TextBox()
        Me.tStopMsg10 = New System.Windows.Forms.TextBox()
        Me.tStopMsg9 = New System.Windows.Forms.TextBox()
        Me.tStopMsg8 = New System.Windows.Forms.TextBox()
        Me.tStopMsg7 = New System.Windows.Forms.TextBox()
        Me.tStopMsg6 = New System.Windows.Forms.TextBox()
        Me.tStopMsg5 = New System.Windows.Forms.TextBox()
        Me.tStopMsg4 = New System.Windows.Forms.TextBox()
        Me.tStopMsg3 = New System.Windows.Forms.TextBox()
        Me.tStopMsg2 = New System.Windows.Forms.TextBox()
        Me.tStopMsg1 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lStop20 = New System.Windows.Forms.Label()
        Me.tStopIf20 = New System.Windows.Forms.TextBox()
        Me.lStop19 = New System.Windows.Forms.Label()
        Me.tStopIf19 = New System.Windows.Forms.TextBox()
        Me.lStop18 = New System.Windows.Forms.Label()
        Me.tStopIf18 = New System.Windows.Forms.TextBox()
        Me.lStop17 = New System.Windows.Forms.Label()
        Me.tStopIf17 = New System.Windows.Forms.TextBox()
        Me.lStop16 = New System.Windows.Forms.Label()
        Me.tStopIf16 = New System.Windows.Forms.TextBox()
        Me.lStop15 = New System.Windows.Forms.Label()
        Me.tStopIf15 = New System.Windows.Forms.TextBox()
        Me.lStop14 = New System.Windows.Forms.Label()
        Me.tStopIf14 = New System.Windows.Forms.TextBox()
        Me.lStop13 = New System.Windows.Forms.Label()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.lStop12 = New System.Windows.Forms.Label()
        Me.tStopIf12 = New System.Windows.Forms.TextBox()
        Me.lStop11 = New System.Windows.Forms.Label()
        Me.tStopIf11 = New System.Windows.Forms.TextBox()
        Me.lStop10 = New System.Windows.Forms.Label()
        Me.tStopIf10 = New System.Windows.Forms.TextBox()
        Me.lStop9 = New System.Windows.Forms.Label()
        Me.tStopIf9 = New System.Windows.Forms.TextBox()
        Me.lStop8 = New System.Windows.Forms.Label()
        Me.tStopIf8 = New System.Windows.Forms.TextBox()
        Me.lStop7 = New System.Windows.Forms.Label()
        Me.tStopIf7 = New System.Windows.Forms.TextBox()
        Me.lStop6 = New System.Windows.Forms.Label()
        Me.tStopIf6 = New System.Windows.Forms.TextBox()
        Me.lStop5 = New System.Windows.Forms.Label()
        Me.tStopIf5 = New System.Windows.Forms.TextBox()
        Me.lStop4 = New System.Windows.Forms.Label()
        Me.tStopIf4 = New System.Windows.Forms.TextBox()
        Me.lStop3 = New System.Windows.Forms.Label()
        Me.tStopIf3 = New System.Windows.Forms.TextBox()
        Me.lStop2 = New System.Windows.Forms.Label()
        Me.tStopIf2 = New System.Windows.Forms.TextBox()
        Me.lStop1 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.tStopIf1 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Validation"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(1207, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnStop.Location = New System.Drawing.Point(487, 565)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(589, 25)
        Me.btnStop.TabIndex = 952
        Me.btnStop.Text = "Insert"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'pStop19
        '
        Me.pStop19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop19.Location = New System.Drawing.Point(1080, 512)
        Me.pStop19.Name = "pStop19"
        Me.pStop19.Size = New System.Drawing.Size(16, 16)
        Me.pStop19.TabIndex = 951
        Me.pStop19.Tag = "19"
        Me.pStop19.Text = "+"
        Me.pStop19.Visible = False
        '
        'pStop18
        '
        Me.pStop18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop18.Location = New System.Drawing.Point(1080, 490)
        Me.pStop18.Name = "pStop18"
        Me.pStop18.Size = New System.Drawing.Size(16, 16)
        Me.pStop18.TabIndex = 950
        Me.pStop18.Tag = "18"
        Me.pStop18.Text = "+"
        Me.pStop18.Visible = False
        '
        'pStop17
        '
        Me.pStop17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop17.Location = New System.Drawing.Point(1080, 468)
        Me.pStop17.Name = "pStop17"
        Me.pStop17.Size = New System.Drawing.Size(16, 16)
        Me.pStop17.TabIndex = 949
        Me.pStop17.Tag = "17"
        Me.pStop17.Text = "+"
        Me.pStop17.Visible = False
        '
        'pStop16
        '
        Me.pStop16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop16.Location = New System.Drawing.Point(1080, 446)
        Me.pStop16.Name = "pStop16"
        Me.pStop16.Size = New System.Drawing.Size(16, 16)
        Me.pStop16.TabIndex = 948
        Me.pStop16.Tag = "16"
        Me.pStop16.Text = "+"
        Me.pStop16.Visible = False
        '
        'pStop15
        '
        Me.pStop15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop15.Location = New System.Drawing.Point(1080, 424)
        Me.pStop15.Name = "pStop15"
        Me.pStop15.Size = New System.Drawing.Size(16, 16)
        Me.pStop15.TabIndex = 947
        Me.pStop15.Tag = "15"
        Me.pStop15.Text = "+"
        Me.pStop15.Visible = False
        '
        'pStop14
        '
        Me.pStop14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop14.Location = New System.Drawing.Point(1080, 402)
        Me.pStop14.Name = "pStop14"
        Me.pStop14.Size = New System.Drawing.Size(16, 16)
        Me.pStop14.TabIndex = 946
        Me.pStop14.Tag = "14"
        Me.pStop14.Text = "+"
        Me.pStop14.Visible = False
        '
        'pStop13
        '
        Me.pStop13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop13.Location = New System.Drawing.Point(1080, 380)
        Me.pStop13.Name = "pStop13"
        Me.pStop13.Size = New System.Drawing.Size(16, 16)
        Me.pStop13.TabIndex = 945
        Me.pStop13.Tag = "13"
        Me.pStop13.Text = "+"
        Me.pStop13.Visible = False
        '
        'pStop12
        '
        Me.pStop12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop12.Location = New System.Drawing.Point(1080, 358)
        Me.pStop12.Name = "pStop12"
        Me.pStop12.Size = New System.Drawing.Size(16, 16)
        Me.pStop12.TabIndex = 944
        Me.pStop12.Tag = "12"
        Me.pStop12.Text = "+"
        Me.pStop12.Visible = False
        '
        'pStop11
        '
        Me.pStop11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop11.Location = New System.Drawing.Point(1080, 336)
        Me.pStop11.Name = "pStop11"
        Me.pStop11.Size = New System.Drawing.Size(16, 16)
        Me.pStop11.TabIndex = 943
        Me.pStop11.Tag = "11"
        Me.pStop11.Text = "+"
        Me.pStop11.Visible = False
        '
        'pStop10
        '
        Me.pStop10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop10.Location = New System.Drawing.Point(1080, 297)
        Me.pStop10.Name = "pStop10"
        Me.pStop10.Size = New System.Drawing.Size(16, 16)
        Me.pStop10.TabIndex = 942
        Me.pStop10.Tag = "10"
        Me.pStop10.Text = "+"
        Me.pStop10.Visible = False
        '
        'pStop9
        '
        Me.pStop9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop9.Location = New System.Drawing.Point(1080, 275)
        Me.pStop9.Name = "pStop9"
        Me.pStop9.Size = New System.Drawing.Size(16, 16)
        Me.pStop9.TabIndex = 941
        Me.pStop9.Tag = "9"
        Me.pStop9.Text = "+"
        Me.pStop9.Visible = False
        '
        'pStop8
        '
        Me.pStop8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop8.Location = New System.Drawing.Point(1080, 253)
        Me.pStop8.Name = "pStop8"
        Me.pStop8.Size = New System.Drawing.Size(16, 16)
        Me.pStop8.TabIndex = 940
        Me.pStop8.Tag = "8"
        Me.pStop8.Text = "+"
        Me.pStop8.Visible = False
        '
        'pStop7
        '
        Me.pStop7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop7.Location = New System.Drawing.Point(1080, 231)
        Me.pStop7.Name = "pStop7"
        Me.pStop7.Size = New System.Drawing.Size(16, 16)
        Me.pStop7.TabIndex = 939
        Me.pStop7.Tag = "7"
        Me.pStop7.Text = "+"
        Me.pStop7.Visible = False
        '
        'pStop6
        '
        Me.pStop6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop6.Location = New System.Drawing.Point(1080, 209)
        Me.pStop6.Name = "pStop6"
        Me.pStop6.Size = New System.Drawing.Size(16, 16)
        Me.pStop6.TabIndex = 938
        Me.pStop6.Tag = "6"
        Me.pStop6.Text = "+"
        Me.pStop6.Visible = False
        '
        'pStop5
        '
        Me.pStop5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop5.Location = New System.Drawing.Point(1080, 187)
        Me.pStop5.Name = "pStop5"
        Me.pStop5.Size = New System.Drawing.Size(16, 16)
        Me.pStop5.TabIndex = 937
        Me.pStop5.Tag = "5"
        Me.pStop5.Text = "+"
        Me.pStop5.Visible = False
        '
        'pStop4
        '
        Me.pStop4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop4.Location = New System.Drawing.Point(1080, 165)
        Me.pStop4.Name = "pStop4"
        Me.pStop4.Size = New System.Drawing.Size(16, 16)
        Me.pStop4.TabIndex = 936
        Me.pStop4.Tag = "4"
        Me.pStop4.Text = "+"
        Me.pStop4.Visible = False
        '
        'pStop3
        '
        Me.pStop3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop3.Location = New System.Drawing.Point(1080, 143)
        Me.pStop3.Name = "pStop3"
        Me.pStop3.Size = New System.Drawing.Size(16, 16)
        Me.pStop3.TabIndex = 935
        Me.pStop3.Tag = "3"
        Me.pStop3.Text = "+"
        Me.pStop3.Visible = False
        '
        'pStop2
        '
        Me.pStop2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop2.Location = New System.Drawing.Point(1080, 121)
        Me.pStop2.Name = "pStop2"
        Me.pStop2.Size = New System.Drawing.Size(16, 16)
        Me.pStop2.TabIndex = 934
        Me.pStop2.Tag = "2"
        Me.pStop2.Text = "+"
        Me.pStop2.Visible = False
        '
        'pStop1
        '
        Me.pStop1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pStop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pStop1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pStop1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pStop1.Location = New System.Drawing.Point(1080, 99)
        Me.pStop1.Name = "pStop1"
        Me.pStop1.Size = New System.Drawing.Size(16, 16)
        Me.pStop1.TabIndex = 933
        Me.pStop1.Tag = "1"
        Me.pStop1.Text = "+"
        '
        'tStopMsg20
        '
        Me.tStopMsg20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg20.Location = New System.Drawing.Point(487, 531)
        Me.tStopMsg20.Name = "tStopMsg20"
        Me.tStopMsg20.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg20.TabIndex = 932
        Me.tStopMsg20.Tag = "20"
        Me.tStopMsg20.Visible = False
        '
        'tStopMsg19
        '
        Me.tStopMsg19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg19.Location = New System.Drawing.Point(487, 509)
        Me.tStopMsg19.Name = "tStopMsg19"
        Me.tStopMsg19.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg19.TabIndex = 931
        Me.tStopMsg19.Tag = "19"
        Me.tStopMsg19.Visible = False
        '
        'tStopMsg18
        '
        Me.tStopMsg18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg18.Location = New System.Drawing.Point(487, 487)
        Me.tStopMsg18.Name = "tStopMsg18"
        Me.tStopMsg18.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg18.TabIndex = 930
        Me.tStopMsg18.Tag = "18"
        Me.tStopMsg18.Visible = False
        '
        'tStopMsg17
        '
        Me.tStopMsg17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg17.Location = New System.Drawing.Point(487, 465)
        Me.tStopMsg17.Name = "tStopMsg17"
        Me.tStopMsg17.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg17.TabIndex = 929
        Me.tStopMsg17.Tag = "17"
        Me.tStopMsg17.Visible = False
        '
        'tStopMsg16
        '
        Me.tStopMsg16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg16.Location = New System.Drawing.Point(487, 443)
        Me.tStopMsg16.Name = "tStopMsg16"
        Me.tStopMsg16.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg16.TabIndex = 928
        Me.tStopMsg16.Tag = "16"
        Me.tStopMsg16.Visible = False
        '
        'tStopMsg15
        '
        Me.tStopMsg15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg15.Location = New System.Drawing.Point(487, 421)
        Me.tStopMsg15.Name = "tStopMsg15"
        Me.tStopMsg15.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg15.TabIndex = 927
        Me.tStopMsg15.Tag = "15"
        Me.tStopMsg15.Visible = False
        '
        'tStopMsg14
        '
        Me.tStopMsg14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg14.Location = New System.Drawing.Point(487, 399)
        Me.tStopMsg14.Name = "tStopMsg14"
        Me.tStopMsg14.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg14.TabIndex = 926
        Me.tStopMsg14.Tag = "14"
        Me.tStopMsg14.Visible = False
        '
        'tStopMsg13
        '
        Me.tStopMsg13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg13.Location = New System.Drawing.Point(487, 377)
        Me.tStopMsg13.Name = "tStopMsg13"
        Me.tStopMsg13.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg13.TabIndex = 925
        Me.tStopMsg13.Tag = "13"
        Me.tStopMsg13.Visible = False
        '
        'tStopMsg12
        '
        Me.tStopMsg12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg12.Location = New System.Drawing.Point(487, 355)
        Me.tStopMsg12.Name = "tStopMsg12"
        Me.tStopMsg12.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg12.TabIndex = 924
        Me.tStopMsg12.Tag = "12"
        Me.tStopMsg12.Visible = False
        '
        'tStopMsg11
        '
        Me.tStopMsg11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg11.Location = New System.Drawing.Point(487, 333)
        Me.tStopMsg11.Name = "tStopMsg11"
        Me.tStopMsg11.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg11.TabIndex = 923
        Me.tStopMsg11.Tag = "11"
        Me.tStopMsg11.Visible = False
        '
        'tStopMsg10
        '
        Me.tStopMsg10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg10.Location = New System.Drawing.Point(487, 297)
        Me.tStopMsg10.Name = "tStopMsg10"
        Me.tStopMsg10.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg10.TabIndex = 922
        Me.tStopMsg10.Tag = "10"
        Me.tStopMsg10.Visible = False
        '
        'tStopMsg9
        '
        Me.tStopMsg9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg9.Location = New System.Drawing.Point(487, 275)
        Me.tStopMsg9.Name = "tStopMsg9"
        Me.tStopMsg9.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg9.TabIndex = 921
        Me.tStopMsg9.Tag = "9"
        Me.tStopMsg9.Visible = False
        '
        'tStopMsg8
        '
        Me.tStopMsg8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg8.Location = New System.Drawing.Point(487, 253)
        Me.tStopMsg8.Name = "tStopMsg8"
        Me.tStopMsg8.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg8.TabIndex = 920
        Me.tStopMsg8.Tag = "8"
        Me.tStopMsg8.Visible = False
        '
        'tStopMsg7
        '
        Me.tStopMsg7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg7.Location = New System.Drawing.Point(487, 231)
        Me.tStopMsg7.Name = "tStopMsg7"
        Me.tStopMsg7.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg7.TabIndex = 919
        Me.tStopMsg7.Tag = "7"
        Me.tStopMsg7.Visible = False
        '
        'tStopMsg6
        '
        Me.tStopMsg6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg6.Location = New System.Drawing.Point(487, 209)
        Me.tStopMsg6.Name = "tStopMsg6"
        Me.tStopMsg6.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg6.TabIndex = 918
        Me.tStopMsg6.Tag = "6"
        Me.tStopMsg6.Visible = False
        '
        'tStopMsg5
        '
        Me.tStopMsg5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg5.Location = New System.Drawing.Point(487, 187)
        Me.tStopMsg5.Name = "tStopMsg5"
        Me.tStopMsg5.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg5.TabIndex = 917
        Me.tStopMsg5.Tag = "5"
        Me.tStopMsg5.Visible = False
        '
        'tStopMsg4
        '
        Me.tStopMsg4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg4.Location = New System.Drawing.Point(487, 165)
        Me.tStopMsg4.Name = "tStopMsg4"
        Me.tStopMsg4.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg4.TabIndex = 916
        Me.tStopMsg4.Tag = "4"
        Me.tStopMsg4.Visible = False
        '
        'tStopMsg3
        '
        Me.tStopMsg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg3.Location = New System.Drawing.Point(487, 143)
        Me.tStopMsg3.Name = "tStopMsg3"
        Me.tStopMsg3.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg3.TabIndex = 915
        Me.tStopMsg3.Tag = "3"
        Me.tStopMsg3.Visible = False
        '
        'tStopMsg2
        '
        Me.tStopMsg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg2.Location = New System.Drawing.Point(487, 121)
        Me.tStopMsg2.Name = "tStopMsg2"
        Me.tStopMsg2.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg2.TabIndex = 914
        Me.tStopMsg2.Tag = "2"
        Me.tStopMsg2.Visible = False
        '
        'tStopMsg1
        '
        Me.tStopMsg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopMsg1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopMsg1.Location = New System.Drawing.Point(487, 99)
        Me.tStopMsg1.Name = "tStopMsg1"
        Me.tStopMsg1.Size = New System.Drawing.Size(589, 20)
        Me.tStopMsg1.TabIndex = 913
        Me.tStopMsg1.Tag = "1"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(487, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(589, 50)
        Me.Label25.TabIndex = 912
        Me.Label25.Text = "Stop message"
        '
        'lStop20
        '
        Me.lStop20.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop20.Location = New System.Drawing.Point(3, 531)
        Me.lStop20.Name = "lStop20"
        Me.lStop20.Size = New System.Drawing.Size(30, 20)
        Me.lStop20.TabIndex = 910
        Me.lStop20.Tag = "20"
        Me.lStop20.Text = "20"
        Me.lStop20.Visible = False
        '
        'tStopIf20
        '
        Me.tStopIf20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf20.Location = New System.Drawing.Point(38, 531)
        Me.tStopIf20.Name = "tStopIf20"
        Me.tStopIf20.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf20.TabIndex = 911
        Me.tStopIf20.Tag = "20"
        Me.tStopIf20.Visible = False
        '
        'lStop19
        '
        Me.lStop19.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop19.Location = New System.Drawing.Point(3, 509)
        Me.lStop19.Name = "lStop19"
        Me.lStop19.Size = New System.Drawing.Size(30, 20)
        Me.lStop19.TabIndex = 908
        Me.lStop19.Tag = "19"
        Me.lStop19.Text = "19"
        Me.lStop19.Visible = False
        '
        'tStopIf19
        '
        Me.tStopIf19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf19.Location = New System.Drawing.Point(38, 509)
        Me.tStopIf19.Name = "tStopIf19"
        Me.tStopIf19.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf19.TabIndex = 909
        Me.tStopIf19.Tag = "19"
        Me.tStopIf19.Visible = False
        '
        'lStop18
        '
        Me.lStop18.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop18.Location = New System.Drawing.Point(3, 487)
        Me.lStop18.Name = "lStop18"
        Me.lStop18.Size = New System.Drawing.Size(30, 20)
        Me.lStop18.TabIndex = 906
        Me.lStop18.Tag = "18"
        Me.lStop18.Text = "18"
        Me.lStop18.Visible = False
        '
        'tStopIf18
        '
        Me.tStopIf18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf18.Location = New System.Drawing.Point(38, 487)
        Me.tStopIf18.Name = "tStopIf18"
        Me.tStopIf18.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf18.TabIndex = 907
        Me.tStopIf18.Tag = "18"
        Me.tStopIf18.Visible = False
        '
        'lStop17
        '
        Me.lStop17.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop17.Location = New System.Drawing.Point(3, 465)
        Me.lStop17.Name = "lStop17"
        Me.lStop17.Size = New System.Drawing.Size(30, 20)
        Me.lStop17.TabIndex = 904
        Me.lStop17.Tag = "17"
        Me.lStop17.Text = "17"
        Me.lStop17.Visible = False
        '
        'tStopIf17
        '
        Me.tStopIf17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf17.Location = New System.Drawing.Point(38, 465)
        Me.tStopIf17.Name = "tStopIf17"
        Me.tStopIf17.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf17.TabIndex = 905
        Me.tStopIf17.Tag = "17"
        Me.tStopIf17.Visible = False
        '
        'lStop16
        '
        Me.lStop16.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop16.Location = New System.Drawing.Point(3, 443)
        Me.lStop16.Name = "lStop16"
        Me.lStop16.Size = New System.Drawing.Size(30, 20)
        Me.lStop16.TabIndex = 902
        Me.lStop16.Tag = "16"
        Me.lStop16.Text = "16"
        Me.lStop16.Visible = False
        '
        'tStopIf16
        '
        Me.tStopIf16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf16.Location = New System.Drawing.Point(38, 443)
        Me.tStopIf16.Name = "tStopIf16"
        Me.tStopIf16.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf16.TabIndex = 903
        Me.tStopIf16.Tag = "16"
        Me.tStopIf16.Visible = False
        '
        'lStop15
        '
        Me.lStop15.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop15.Location = New System.Drawing.Point(3, 421)
        Me.lStop15.Name = "lStop15"
        Me.lStop15.Size = New System.Drawing.Size(30, 20)
        Me.lStop15.TabIndex = 900
        Me.lStop15.Tag = "15"
        Me.lStop15.Text = "15"
        Me.lStop15.Visible = False
        '
        'tStopIf15
        '
        Me.tStopIf15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf15.Location = New System.Drawing.Point(38, 421)
        Me.tStopIf15.Name = "tStopIf15"
        Me.tStopIf15.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf15.TabIndex = 901
        Me.tStopIf15.Tag = "15"
        Me.tStopIf15.Visible = False
        '
        'lStop14
        '
        Me.lStop14.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop14.Location = New System.Drawing.Point(3, 399)
        Me.lStop14.Name = "lStop14"
        Me.lStop14.Size = New System.Drawing.Size(30, 20)
        Me.lStop14.TabIndex = 898
        Me.lStop14.Tag = "14"
        Me.lStop14.Text = "14"
        Me.lStop14.Visible = False
        '
        'tStopIf14
        '
        Me.tStopIf14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf14.Location = New System.Drawing.Point(38, 399)
        Me.tStopIf14.Name = "tStopIf14"
        Me.tStopIf14.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf14.TabIndex = 899
        Me.tStopIf14.Tag = "14"
        Me.tStopIf14.Visible = False
        '
        'lStop13
        '
        Me.lStop13.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop13.Location = New System.Drawing.Point(3, 377)
        Me.lStop13.Name = "lStop13"
        Me.lStop13.Size = New System.Drawing.Size(30, 20)
        Me.lStop13.TabIndex = 896
        Me.lStop13.Tag = "13"
        Me.lStop13.Text = "13"
        Me.lStop13.Visible = False
        '
        'TextBox38
        '
        Me.TextBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox38.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox38.Location = New System.Drawing.Point(38, 377)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(448, 20)
        Me.TextBox38.TabIndex = 897
        Me.TextBox38.Tag = "13"
        Me.TextBox38.Visible = False
        '
        'lStop12
        '
        Me.lStop12.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop12.Location = New System.Drawing.Point(3, 355)
        Me.lStop12.Name = "lStop12"
        Me.lStop12.Size = New System.Drawing.Size(30, 20)
        Me.lStop12.TabIndex = 894
        Me.lStop12.Tag = "12"
        Me.lStop12.Text = "12"
        Me.lStop12.Visible = False
        '
        'tStopIf12
        '
        Me.tStopIf12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf12.Location = New System.Drawing.Point(38, 355)
        Me.tStopIf12.Name = "tStopIf12"
        Me.tStopIf12.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf12.TabIndex = 895
        Me.tStopIf12.Tag = "12"
        Me.tStopIf12.Visible = False
        '
        'lStop11
        '
        Me.lStop11.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop11.Location = New System.Drawing.Point(3, 333)
        Me.lStop11.Name = "lStop11"
        Me.lStop11.Size = New System.Drawing.Size(30, 20)
        Me.lStop11.TabIndex = 892
        Me.lStop11.Tag = "11"
        Me.lStop11.Text = "11"
        Me.lStop11.Visible = False
        '
        'tStopIf11
        '
        Me.tStopIf11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf11.Location = New System.Drawing.Point(38, 333)
        Me.tStopIf11.Name = "tStopIf11"
        Me.tStopIf11.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf11.TabIndex = 893
        Me.tStopIf11.Tag = "11"
        Me.tStopIf11.Visible = False
        '
        'lStop10
        '
        Me.lStop10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop10.Location = New System.Drawing.Point(3, 303)
        Me.lStop10.Name = "lStop10"
        Me.lStop10.Size = New System.Drawing.Size(30, 20)
        Me.lStop10.TabIndex = 890
        Me.lStop10.Tag = "10"
        Me.lStop10.Text = "10"
        Me.lStop10.Visible = False
        '
        'tStopIf10
        '
        Me.tStopIf10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf10.Location = New System.Drawing.Point(38, 297)
        Me.tStopIf10.Name = "tStopIf10"
        Me.tStopIf10.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf10.TabIndex = 891
        Me.tStopIf10.Tag = "10"
        Me.tStopIf10.Visible = False
        '
        'lStop9
        '
        Me.lStop9.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop9.Location = New System.Drawing.Point(3, 281)
        Me.lStop9.Name = "lStop9"
        Me.lStop9.Size = New System.Drawing.Size(30, 20)
        Me.lStop9.TabIndex = 888
        Me.lStop9.Tag = "9"
        Me.lStop9.Text = "9"
        Me.lStop9.Visible = False
        '
        'tStopIf9
        '
        Me.tStopIf9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf9.Location = New System.Drawing.Point(38, 275)
        Me.tStopIf9.Name = "tStopIf9"
        Me.tStopIf9.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf9.TabIndex = 889
        Me.tStopIf9.Tag = "9"
        Me.tStopIf9.Visible = False
        '
        'lStop8
        '
        Me.lStop8.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop8.Location = New System.Drawing.Point(3, 257)
        Me.lStop8.Name = "lStop8"
        Me.lStop8.Size = New System.Drawing.Size(30, 20)
        Me.lStop8.TabIndex = 886
        Me.lStop8.Tag = "8"
        Me.lStop8.Text = "8"
        Me.lStop8.Visible = False
        '
        'tStopIf8
        '
        Me.tStopIf8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf8.Location = New System.Drawing.Point(38, 253)
        Me.tStopIf8.Name = "tStopIf8"
        Me.tStopIf8.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf8.TabIndex = 887
        Me.tStopIf8.Tag = "8"
        Me.tStopIf8.Visible = False
        '
        'lStop7
        '
        Me.lStop7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop7.Location = New System.Drawing.Point(3, 234)
        Me.lStop7.Name = "lStop7"
        Me.lStop7.Size = New System.Drawing.Size(30, 20)
        Me.lStop7.TabIndex = 884
        Me.lStop7.Tag = "7"
        Me.lStop7.Text = "7"
        Me.lStop7.Visible = False
        '
        'tStopIf7
        '
        Me.tStopIf7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf7.Location = New System.Drawing.Point(38, 231)
        Me.tStopIf7.Name = "tStopIf7"
        Me.tStopIf7.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf7.TabIndex = 885
        Me.tStopIf7.Tag = "7"
        Me.tStopIf7.Visible = False
        '
        'lStop6
        '
        Me.lStop6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop6.Location = New System.Drawing.Point(3, 212)
        Me.lStop6.Name = "lStop6"
        Me.lStop6.Size = New System.Drawing.Size(30, 20)
        Me.lStop6.TabIndex = 882
        Me.lStop6.Tag = "6"
        Me.lStop6.Text = "6"
        Me.lStop6.Visible = False
        '
        'tStopIf6
        '
        Me.tStopIf6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf6.Location = New System.Drawing.Point(38, 209)
        Me.tStopIf6.Name = "tStopIf6"
        Me.tStopIf6.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf6.TabIndex = 883
        Me.tStopIf6.Tag = "6"
        Me.tStopIf6.Visible = False
        '
        'lStop5
        '
        Me.lStop5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop5.Location = New System.Drawing.Point(3, 190)
        Me.lStop5.Name = "lStop5"
        Me.lStop5.Size = New System.Drawing.Size(30, 20)
        Me.lStop5.TabIndex = 880
        Me.lStop5.Tag = "5"
        Me.lStop5.Text = "5"
        Me.lStop5.Visible = False
        '
        'tStopIf5
        '
        Me.tStopIf5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf5.Location = New System.Drawing.Point(38, 187)
        Me.tStopIf5.Name = "tStopIf5"
        Me.tStopIf5.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf5.TabIndex = 881
        Me.tStopIf5.Tag = "5"
        Me.tStopIf5.Visible = False
        '
        'lStop4
        '
        Me.lStop4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop4.Location = New System.Drawing.Point(3, 168)
        Me.lStop4.Name = "lStop4"
        Me.lStop4.Size = New System.Drawing.Size(30, 20)
        Me.lStop4.TabIndex = 878
        Me.lStop4.Tag = "4"
        Me.lStop4.Text = "4"
        Me.lStop4.Visible = False
        '
        'tStopIf4
        '
        Me.tStopIf4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf4.Location = New System.Drawing.Point(38, 165)
        Me.tStopIf4.Name = "tStopIf4"
        Me.tStopIf4.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf4.TabIndex = 879
        Me.tStopIf4.Tag = "4"
        Me.tStopIf4.Visible = False
        '
        'lStop3
        '
        Me.lStop3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop3.Location = New System.Drawing.Point(3, 144)
        Me.lStop3.Name = "lStop3"
        Me.lStop3.Size = New System.Drawing.Size(30, 20)
        Me.lStop3.TabIndex = 876
        Me.lStop3.Tag = "3"
        Me.lStop3.Text = "3"
        Me.lStop3.Visible = False
        '
        'tStopIf3
        '
        Me.tStopIf3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf3.Location = New System.Drawing.Point(38, 143)
        Me.tStopIf3.Name = "tStopIf3"
        Me.tStopIf3.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf3.TabIndex = 877
        Me.tStopIf3.Tag = "3"
        Me.tStopIf3.Visible = False
        '
        'lStop2
        '
        Me.lStop2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop2.Location = New System.Drawing.Point(3, 121)
        Me.lStop2.Name = "lStop2"
        Me.lStop2.Size = New System.Drawing.Size(30, 20)
        Me.lStop2.TabIndex = 874
        Me.lStop2.Tag = "2"
        Me.lStop2.Text = "2"
        Me.lStop2.Visible = False
        '
        'tStopIf2
        '
        Me.tStopIf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf2.Location = New System.Drawing.Point(38, 121)
        Me.tStopIf2.Name = "tStopIf2"
        Me.tStopIf2.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf2.TabIndex = 875
        Me.tStopIf2.Tag = "2"
        Me.tStopIf2.Visible = False
        '
        'lStop1
        '
        Me.lStop1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lStop1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lStop1.Location = New System.Drawing.Point(3, 99)
        Me.lStop1.Name = "lStop1"
        Me.lStop1.Size = New System.Drawing.Size(30, 20)
        Me.lStop1.TabIndex = 872
        Me.lStop1.Tag = "1"
        Me.lStop1.Text = "1"
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label49.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label49.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label49.Location = New System.Drawing.Point(3, 28)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(34, 50)
        Me.Label49.TabIndex = 871
        Me.Label49.Text = "No"
        '
        'tStopIf1
        '
        Me.tStopIf1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tStopIf1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tStopIf1.Location = New System.Drawing.Point(38, 99)
        Me.tStopIf1.Name = "tStopIf1"
        Me.tStopIf1.Size = New System.Drawing.Size(448, 20)
        Me.tStopIf1.TabIndex = 873
        Me.tStopIf1.Tag = "1"
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label50.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label50.Location = New System.Drawing.Point(38, 28)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(448, 50)
        Me.Label50.TabIndex = 870
        Me.Label50.Text = "Stop If"
        '
        'mFormExitEventStop
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1207, 601)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.pStop19)
        Me.Controls.Add(Me.pStop18)
        Me.Controls.Add(Me.pStop17)
        Me.Controls.Add(Me.pStop16)
        Me.Controls.Add(Me.pStop15)
        Me.Controls.Add(Me.pStop14)
        Me.Controls.Add(Me.pStop13)
        Me.Controls.Add(Me.pStop12)
        Me.Controls.Add(Me.pStop11)
        Me.Controls.Add(Me.pStop10)
        Me.Controls.Add(Me.pStop9)
        Me.Controls.Add(Me.pStop8)
        Me.Controls.Add(Me.pStop7)
        Me.Controls.Add(Me.pStop6)
        Me.Controls.Add(Me.pStop5)
        Me.Controls.Add(Me.pStop4)
        Me.Controls.Add(Me.pStop3)
        Me.Controls.Add(Me.pStop2)
        Me.Controls.Add(Me.pStop1)
        Me.Controls.Add(Me.tStopMsg20)
        Me.Controls.Add(Me.tStopMsg19)
        Me.Controls.Add(Me.tStopMsg18)
        Me.Controls.Add(Me.tStopMsg17)
        Me.Controls.Add(Me.tStopMsg16)
        Me.Controls.Add(Me.tStopMsg15)
        Me.Controls.Add(Me.tStopMsg14)
        Me.Controls.Add(Me.tStopMsg13)
        Me.Controls.Add(Me.tStopMsg12)
        Me.Controls.Add(Me.tStopMsg11)
        Me.Controls.Add(Me.tStopMsg10)
        Me.Controls.Add(Me.tStopMsg9)
        Me.Controls.Add(Me.tStopMsg8)
        Me.Controls.Add(Me.tStopMsg7)
        Me.Controls.Add(Me.tStopMsg6)
        Me.Controls.Add(Me.tStopMsg5)
        Me.Controls.Add(Me.tStopMsg4)
        Me.Controls.Add(Me.tStopMsg3)
        Me.Controls.Add(Me.tStopMsg2)
        Me.Controls.Add(Me.tStopMsg1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.lStop20)
        Me.Controls.Add(Me.tStopIf20)
        Me.Controls.Add(Me.lStop19)
        Me.Controls.Add(Me.tStopIf19)
        Me.Controls.Add(Me.lStop18)
        Me.Controls.Add(Me.tStopIf18)
        Me.Controls.Add(Me.lStop17)
        Me.Controls.Add(Me.tStopIf17)
        Me.Controls.Add(Me.lStop16)
        Me.Controls.Add(Me.tStopIf16)
        Me.Controls.Add(Me.lStop15)
        Me.Controls.Add(Me.tStopIf15)
        Me.Controls.Add(Me.lStop14)
        Me.Controls.Add(Me.tStopIf14)
        Me.Controls.Add(Me.lStop13)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.lStop12)
        Me.Controls.Add(Me.tStopIf12)
        Me.Controls.Add(Me.lStop11)
        Me.Controls.Add(Me.tStopIf11)
        Me.Controls.Add(Me.lStop10)
        Me.Controls.Add(Me.tStopIf10)
        Me.Controls.Add(Me.lStop9)
        Me.Controls.Add(Me.tStopIf9)
        Me.Controls.Add(Me.lStop8)
        Me.Controls.Add(Me.tStopIf8)
        Me.Controls.Add(Me.lStop7)
        Me.Controls.Add(Me.tStopIf7)
        Me.Controls.Add(Me.lStop6)
        Me.Controls.Add(Me.tStopIf6)
        Me.Controls.Add(Me.lStop5)
        Me.Controls.Add(Me.tStopIf5)
        Me.Controls.Add(Me.lStop4)
        Me.Controls.Add(Me.tStopIf4)
        Me.Controls.Add(Me.lStop3)
        Me.Controls.Add(Me.tStopIf3)
        Me.Controls.Add(Me.lStop2)
        Me.Controls.Add(Me.tStopIf2)
        Me.Controls.Add(Me.lStop1)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.tStopIf1)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormExitEventStop"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Validation"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
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
        End With
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.dIst = dIst

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")

        Dim dt As System.Data.DataTable = getDTC()
        If dt.Rows.Count = 1 Then
            Call getVariablesC(dt)
            Try

                getMetaDataPane()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If
        Dim strSQl As String = "select polje as displaymember,polje as valuemember from ISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' order by polje"
        Me.Label1.Text = "Stop on field " + pp(2).Trim + "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim
    End Sub

    Dim validatingEvent As String = ""
    Dim validatingEventOst As String = ""

    Function getDTC() As System.Data.DataTable
        validatingEvent = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select od " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "' and pp<>'fp' and pp<>'lbl' and pp<>'dgv' and pp<>'button'  " +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        validatingEvent = dt.Rows(0).Item("od").ToString.Trim
    End Sub

    'STOP
    'STOP
    'STOP
    'STOP
    'STOP
    'STOP
    Sub getMetaDataPane()
        validatingEventOst = ""
        'izrazZADGV
        If validatingEvent = "" Then Exit Sub
        validatingEvent = validatingEvent.Replace(vbCrLf, "").Replace("#{", "").Trim
        If validatingEvent.Substring(validatingEvent.Length - 1, 1) = "}" Then validatingEvent = validatingEvent.Substring(0, validatingEvent.Length - 1)

        Dim pp() As String = validatingEvent.Split(";")

        Dim stopIf() As String = {}
        Dim stopMsg() As String = {}

        For i As Integer = 0 To pp.GetUpperBound(0)

            If pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("STOPIF") >= 0 Then
                stopIf = pp(i).Trim.ToUpper.Replace("STOPIF=", "").Split("$")
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("STOPMSG") >= 0 Then
                stopMsg = pp(i).Trim.ToUpper.Replace("STOPMSG=", "").Split("$")
            ElseIf pp(i).Trim <> "" Then
                validatingEventOst = validatingEventOst + pp(i) + ";"
            End If
        Next

        For i As Integer = 0 To stopIf.GetUpperBound(0)
            For Each k As Control In Me.Controls
                If Not k.Tag Is Nothing AndAlso k.Tag <> "" AndAlso k.Tag = CStr(i + 1).Trim Then
                    k.Visible = True
                End If
            Next
        Next

        For i As Integer = 0 To stopIf.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "tStopIf" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = stopIf(i).Trim
        Next

        For i As Integer = 0 To stopMsg.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "tStopMsg" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = stopMsg(i).Trim
        Next

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        Dim sstop As String = ""
        Dim br As Integer = 0

        'StopIf
        Dim StopIf As String = ""
        For k As Integer = 1 To 20
            Dim tb As Control = NadjiKontrolu(Me, "tStopIf" + CStr(k).Trim)
            If Not tb Is Nothing AndAlso DirectCast(tb, TextBox).Text <> "" Then
                StopIf = StopIf + tb.Text + "$"
                br = br + 1
            End If
        Next
        If StopIf <> "" Then
            StopIf = "StopIf=" + StopIf.TrimEnd("$") + ";"
            sstop = sstop + StopIf
        End If

        'StopIf
        Dim StopMsg As String = ""
        For k As Integer = 1 To br
            Dim tb As Control = NadjiKontrolu(Me, "tStopMsg" + CStr(k).Trim)
            If DirectCast(tb, TextBox).Text <> "" Then StopMsg = StopMsg + tb.Text + "$"
        Next
        If StopMsg <> "" Then
            StopMsg = "StopMsg=" + StopMsg.TrimEnd("$") + ";"
            sstop = sstop + StopMsg
        End If

        sstop = sstop.Replace("'", "''")

        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim

        Dim sql As String = "update istpolja set od=N'#{" + validatingEventOst + ";" + sstop + "}'" +
            " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim +
            "' and  rbr='" + pp(4).Trim + "'"

        Dim p2 As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sql)
        If p2 = "nok" Then ISTMessageBox.Show("Error") Else Me.Close()

    End Sub

    Private Sub pStop1_Click(sender As Object, e As EventArgs) Handles pStop1.Click, pStop2.Click, pStop3.Click, pStop4.Click, pStop5.Click, pStop6.Click, pStop7.Click, pStop8.Click, pStop9.Click, pStop10.Click, pStop11.Click, pStop12.Click, pStop13.Click, pStop14.Click, pStop15.Click, pStop16.Click, pStop17.Click, pStop18.Click, pStop19.Click

        Dim lbl As Label = DirectCast(sender, Label)
        Dim brs As String = lbl.Name.Replace("pStop", "")
        Dim br As Integer = CInt(lbl.Name.Replace("pStop", "").Trim) + 1

        For Each k As Control In Me.Controls
            If Not k.Tag Is Nothing AndAlso k.Tag <> "" AndAlso k.Tag = CStr(br).Trim Then
                k.Visible = True
            End If
        Next

    End Sub

End Class