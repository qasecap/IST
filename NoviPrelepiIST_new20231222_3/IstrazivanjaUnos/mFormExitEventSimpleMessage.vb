'Option Strict Off

Imports System.Web

Public Class mFormExitEventSimpleMessage
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
    Friend WithEvents btn As Button
    Friend WithEvents p19 As Label
    Friend WithEvents p18 As Label
    Friend WithEvents p17 As Label
    Friend WithEvents p16 As Label
    Friend WithEvents p15 As Label
    Friend WithEvents p14 As Label
    Friend WithEvents p13 As Label
    Friend WithEvents p12 As Label
    Friend WithEvents p11 As Label
    Friend WithEvents p10 As Label
    Friend WithEvents p9 As Label
    Friend WithEvents p8 As Label
    Friend WithEvents p7 As Label
    Friend WithEvents p6 As Label
    Friend WithEvents p5 As Label
    Friend WithEvents p4 As Label
    Friend WithEvents p3 As Label
    Friend WithEvents p2 As Label
    Friend WithEvents p1 As Label
    Friend WithEvents pMsg20 As TextBox
    Friend WithEvents pMsg19 As TextBox
    Friend WithEvents pMsg18 As TextBox
    Friend WithEvents pMsg17 As TextBox
    Friend WithEvents pMsg16 As TextBox
    Friend WithEvents pMsg15 As TextBox
    Friend WithEvents pMsg14 As TextBox
    Friend WithEvents pMsg13 As TextBox
    Friend WithEvents pMsg12 As TextBox
    Friend WithEvents pMsg11 As TextBox
    Friend WithEvents pMsg10 As TextBox
    Friend WithEvents pMsg9 As TextBox
    Friend WithEvents pMsg8 As TextBox
    Friend WithEvents pMsg7 As TextBox
    Friend WithEvents pMsg6 As TextBox
    Friend WithEvents pMsg5 As TextBox
    Friend WithEvents pMsg4 As TextBox
    Friend WithEvents pMsg3 As TextBox
    Friend WithEvents pMsg2 As TextBox
    Friend WithEvents pMsg1 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents l20 As Label
    Friend WithEvents pIf20 As TextBox
    Friend WithEvents l19 As Label
    Friend WithEvents pIf19 As TextBox
    Friend WithEvents l18 As Label
    Friend WithEvents pIf18 As TextBox
    Friend WithEvents l17 As Label
    Friend WithEvents pIf17 As TextBox
    Friend WithEvents l16 As Label
    Friend WithEvents pIf16 As TextBox
    Friend WithEvents l15 As Label
    Friend WithEvents pIf15 As TextBox
    Friend WithEvents l14 As Label
    Friend WithEvents pIf14 As TextBox
    Friend WithEvents l13 As Label
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents l12 As Label
    Friend WithEvents pIf12 As TextBox
    Friend WithEvents l11 As Label
    Friend WithEvents pIf11 As TextBox
    Friend WithEvents l10 As Label
    Friend WithEvents pIf10 As TextBox
    Friend WithEvents l9 As Label
    Friend WithEvents pIf9 As TextBox
    Friend WithEvents l8 As Label
    Friend WithEvents pIf8 As TextBox
    Friend WithEvents l7 As Label
    Friend WithEvents pIf7 As TextBox
    Friend WithEvents l6 As Label
    Friend WithEvents pIf6 As TextBox
    Friend WithEvents l5 As Label
    Friend WithEvents pIf5 As TextBox
    Friend WithEvents l4 As Label
    Friend WithEvents pIf4 As TextBox
    Friend WithEvents l3 As Label
    Friend WithEvents pIf3 As TextBox
    Friend WithEvents l2 As Label
    Friend WithEvents pIf2 As TextBox
    Friend WithEvents l1 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents pIf1 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.p19 = New System.Windows.Forms.Label()
        Me.p18 = New System.Windows.Forms.Label()
        Me.p17 = New System.Windows.Forms.Label()
        Me.p16 = New System.Windows.Forms.Label()
        Me.p15 = New System.Windows.Forms.Label()
        Me.p14 = New System.Windows.Forms.Label()
        Me.p13 = New System.Windows.Forms.Label()
        Me.p12 = New System.Windows.Forms.Label()
        Me.p11 = New System.Windows.Forms.Label()
        Me.p10 = New System.Windows.Forms.Label()
        Me.p9 = New System.Windows.Forms.Label()
        Me.p8 = New System.Windows.Forms.Label()
        Me.p7 = New System.Windows.Forms.Label()
        Me.p6 = New System.Windows.Forms.Label()
        Me.p5 = New System.Windows.Forms.Label()
        Me.p4 = New System.Windows.Forms.Label()
        Me.p3 = New System.Windows.Forms.Label()
        Me.p2 = New System.Windows.Forms.Label()
        Me.p1 = New System.Windows.Forms.Label()
        Me.pMsg20 = New System.Windows.Forms.TextBox()
        Me.pMsg19 = New System.Windows.Forms.TextBox()
        Me.pMsg18 = New System.Windows.Forms.TextBox()
        Me.pMsg17 = New System.Windows.Forms.TextBox()
        Me.pMsg16 = New System.Windows.Forms.TextBox()
        Me.pMsg15 = New System.Windows.Forms.TextBox()
        Me.pMsg14 = New System.Windows.Forms.TextBox()
        Me.pMsg13 = New System.Windows.Forms.TextBox()
        Me.pMsg12 = New System.Windows.Forms.TextBox()
        Me.pMsg11 = New System.Windows.Forms.TextBox()
        Me.pMsg10 = New System.Windows.Forms.TextBox()
        Me.pMsg9 = New System.Windows.Forms.TextBox()
        Me.pMsg8 = New System.Windows.Forms.TextBox()
        Me.pMsg7 = New System.Windows.Forms.TextBox()
        Me.pMsg6 = New System.Windows.Forms.TextBox()
        Me.pMsg5 = New System.Windows.Forms.TextBox()
        Me.pMsg4 = New System.Windows.Forms.TextBox()
        Me.pMsg3 = New System.Windows.Forms.TextBox()
        Me.pMsg2 = New System.Windows.Forms.TextBox()
        Me.pMsg1 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.l20 = New System.Windows.Forms.Label()
        Me.pIf20 = New System.Windows.Forms.TextBox()
        Me.l19 = New System.Windows.Forms.Label()
        Me.pIf19 = New System.Windows.Forms.TextBox()
        Me.l18 = New System.Windows.Forms.Label()
        Me.pIf18 = New System.Windows.Forms.TextBox()
        Me.l17 = New System.Windows.Forms.Label()
        Me.pIf17 = New System.Windows.Forms.TextBox()
        Me.l16 = New System.Windows.Forms.Label()
        Me.pIf16 = New System.Windows.Forms.TextBox()
        Me.l15 = New System.Windows.Forms.Label()
        Me.pIf15 = New System.Windows.Forms.TextBox()
        Me.l14 = New System.Windows.Forms.Label()
        Me.pIf14 = New System.Windows.Forms.TextBox()
        Me.l13 = New System.Windows.Forms.Label()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.l12 = New System.Windows.Forms.Label()
        Me.pIf12 = New System.Windows.Forms.TextBox()
        Me.l11 = New System.Windows.Forms.Label()
        Me.pIf11 = New System.Windows.Forms.TextBox()
        Me.l10 = New System.Windows.Forms.Label()
        Me.pIf10 = New System.Windows.Forms.TextBox()
        Me.l9 = New System.Windows.Forms.Label()
        Me.pIf9 = New System.Windows.Forms.TextBox()
        Me.l8 = New System.Windows.Forms.Label()
        Me.pIf8 = New System.Windows.Forms.TextBox()
        Me.l7 = New System.Windows.Forms.Label()
        Me.pIf7 = New System.Windows.Forms.TextBox()
        Me.l6 = New System.Windows.Forms.Label()
        Me.pIf6 = New System.Windows.Forms.TextBox()
        Me.l5 = New System.Windows.Forms.Label()
        Me.pIf5 = New System.Windows.Forms.TextBox()
        Me.l4 = New System.Windows.Forms.Label()
        Me.pIf4 = New System.Windows.Forms.TextBox()
        Me.l3 = New System.Windows.Forms.Label()
        Me.pIf3 = New System.Windows.Forms.TextBox()
        Me.l2 = New System.Windows.Forms.Label()
        Me.pIf2 = New System.Windows.Forms.TextBox()
        Me.l1 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.pIf1 = New System.Windows.Forms.TextBox()
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
        Me.Label1.Size = New System.Drawing.Size(104, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Simple message"
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
        'btn
        '
        Me.btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn.Location = New System.Drawing.Point(487, 565)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(589, 25)
        Me.btn.TabIndex = 952
        Me.btn.Text = "Insert"
        Me.btn.UseVisualStyleBackColor = False
        '
        'p19
        '
        Me.p19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p19.Location = New System.Drawing.Point(1080, 512)
        Me.p19.Name = "p19"
        Me.p19.Size = New System.Drawing.Size(16, 16)
        Me.p19.TabIndex = 951
        Me.p19.Tag = "19"
        Me.p19.Text = "+"
        Me.p19.Visible = False
        '
        'p18
        '
        Me.p18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p18.Location = New System.Drawing.Point(1080, 490)
        Me.p18.Name = "p18"
        Me.p18.Size = New System.Drawing.Size(16, 16)
        Me.p18.TabIndex = 950
        Me.p18.Tag = "18"
        Me.p18.Text = "+"
        Me.p18.Visible = False
        '
        'p17
        '
        Me.p17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p17.Location = New System.Drawing.Point(1080, 468)
        Me.p17.Name = "p17"
        Me.p17.Size = New System.Drawing.Size(16, 16)
        Me.p17.TabIndex = 949
        Me.p17.Tag = "17"
        Me.p17.Text = "+"
        Me.p17.Visible = False
        '
        'p16
        '
        Me.p16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p16.Location = New System.Drawing.Point(1080, 446)
        Me.p16.Name = "p16"
        Me.p16.Size = New System.Drawing.Size(16, 16)
        Me.p16.TabIndex = 948
        Me.p16.Tag = "16"
        Me.p16.Text = "+"
        Me.p16.Visible = False
        '
        'p15
        '
        Me.p15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p15.Location = New System.Drawing.Point(1080, 424)
        Me.p15.Name = "p15"
        Me.p15.Size = New System.Drawing.Size(16, 16)
        Me.p15.TabIndex = 947
        Me.p15.Tag = "15"
        Me.p15.Text = "+"
        Me.p15.Visible = False
        '
        'p14
        '
        Me.p14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p14.Location = New System.Drawing.Point(1080, 402)
        Me.p14.Name = "p14"
        Me.p14.Size = New System.Drawing.Size(16, 16)
        Me.p14.TabIndex = 946
        Me.p14.Tag = "14"
        Me.p14.Text = "+"
        Me.p14.Visible = False
        '
        'p13
        '
        Me.p13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p13.Location = New System.Drawing.Point(1080, 380)
        Me.p13.Name = "p13"
        Me.p13.Size = New System.Drawing.Size(16, 16)
        Me.p13.TabIndex = 945
        Me.p13.Tag = "13"
        Me.p13.Text = "+"
        Me.p13.Visible = False
        '
        'p12
        '
        Me.p12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p12.Location = New System.Drawing.Point(1080, 358)
        Me.p12.Name = "p12"
        Me.p12.Size = New System.Drawing.Size(16, 16)
        Me.p12.TabIndex = 944
        Me.p12.Tag = "12"
        Me.p12.Text = "+"
        Me.p12.Visible = False
        '
        'p11
        '
        Me.p11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p11.Location = New System.Drawing.Point(1080, 336)
        Me.p11.Name = "p11"
        Me.p11.Size = New System.Drawing.Size(16, 16)
        Me.p11.TabIndex = 943
        Me.p11.Tag = "11"
        Me.p11.Text = "+"
        Me.p11.Visible = False
        '
        'p10
        '
        Me.p10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p10.Location = New System.Drawing.Point(1080, 297)
        Me.p10.Name = "p10"
        Me.p10.Size = New System.Drawing.Size(16, 16)
        Me.p10.TabIndex = 942
        Me.p10.Tag = "10"
        Me.p10.Text = "+"
        Me.p10.Visible = False
        '
        'p9
        '
        Me.p9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p9.Location = New System.Drawing.Point(1080, 275)
        Me.p9.Name = "p9"
        Me.p9.Size = New System.Drawing.Size(16, 16)
        Me.p9.TabIndex = 941
        Me.p9.Tag = "9"
        Me.p9.Text = "+"
        Me.p9.Visible = False
        '
        'p8
        '
        Me.p8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p8.Location = New System.Drawing.Point(1080, 253)
        Me.p8.Name = "p8"
        Me.p8.Size = New System.Drawing.Size(16, 16)
        Me.p8.TabIndex = 940
        Me.p8.Tag = "8"
        Me.p8.Text = "+"
        Me.p8.Visible = False
        '
        'p7
        '
        Me.p7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p7.Location = New System.Drawing.Point(1080, 231)
        Me.p7.Name = "p7"
        Me.p7.Size = New System.Drawing.Size(16, 16)
        Me.p7.TabIndex = 939
        Me.p7.Tag = "7"
        Me.p7.Text = "+"
        Me.p7.Visible = False
        '
        'p6
        '
        Me.p6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p6.Location = New System.Drawing.Point(1080, 209)
        Me.p6.Name = "p6"
        Me.p6.Size = New System.Drawing.Size(16, 16)
        Me.p6.TabIndex = 938
        Me.p6.Tag = "6"
        Me.p6.Text = "+"
        Me.p6.Visible = False
        '
        'p5
        '
        Me.p5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p5.Location = New System.Drawing.Point(1080, 187)
        Me.p5.Name = "p5"
        Me.p5.Size = New System.Drawing.Size(16, 16)
        Me.p5.TabIndex = 937
        Me.p5.Tag = "5"
        Me.p5.Text = "+"
        Me.p5.Visible = False
        '
        'p4
        '
        Me.p4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p4.Location = New System.Drawing.Point(1080, 165)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(16, 16)
        Me.p4.TabIndex = 936
        Me.p4.Tag = "4"
        Me.p4.Text = "+"
        Me.p4.Visible = False
        '
        'p3
        '
        Me.p3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p3.Location = New System.Drawing.Point(1080, 143)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(16, 16)
        Me.p3.TabIndex = 935
        Me.p3.Tag = "3"
        Me.p3.Text = "+"
        Me.p3.Visible = False
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p2.Location = New System.Drawing.Point(1080, 121)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(16, 16)
        Me.p2.TabIndex = 934
        Me.p2.Tag = "2"
        Me.p2.Text = "+"
        Me.p2.Visible = False
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p1.Location = New System.Drawing.Point(1080, 99)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(16, 16)
        Me.p1.TabIndex = 933
        Me.p1.Tag = "1"
        Me.p1.Text = "+"
        '
        'pMsg20
        '
        Me.pMsg20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg20.Location = New System.Drawing.Point(487, 531)
        Me.pMsg20.Name = "pMsg20"
        Me.pMsg20.Size = New System.Drawing.Size(589, 20)
        Me.pMsg20.TabIndex = 932
        Me.pMsg20.Tag = "20"
        Me.pMsg20.Visible = False
        '
        'pMsg19
        '
        Me.pMsg19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg19.Location = New System.Drawing.Point(487, 509)
        Me.pMsg19.Name = "pMsg19"
        Me.pMsg19.Size = New System.Drawing.Size(589, 20)
        Me.pMsg19.TabIndex = 931
        Me.pMsg19.Tag = "19"
        Me.pMsg19.Visible = False
        '
        'pMsg18
        '
        Me.pMsg18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg18.Location = New System.Drawing.Point(487, 487)
        Me.pMsg18.Name = "pMsg18"
        Me.pMsg18.Size = New System.Drawing.Size(589, 20)
        Me.pMsg18.TabIndex = 930
        Me.pMsg18.Tag = "18"
        Me.pMsg18.Visible = False
        '
        'pMsg17
        '
        Me.pMsg17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg17.Location = New System.Drawing.Point(487, 465)
        Me.pMsg17.Name = "pMsg17"
        Me.pMsg17.Size = New System.Drawing.Size(589, 20)
        Me.pMsg17.TabIndex = 929
        Me.pMsg17.Tag = "17"
        Me.pMsg17.Visible = False
        '
        'pMsg16
        '
        Me.pMsg16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg16.Location = New System.Drawing.Point(487, 443)
        Me.pMsg16.Name = "pMsg16"
        Me.pMsg16.Size = New System.Drawing.Size(589, 20)
        Me.pMsg16.TabIndex = 928
        Me.pMsg16.Tag = "16"
        Me.pMsg16.Visible = False
        '
        'pMsg15
        '
        Me.pMsg15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg15.Location = New System.Drawing.Point(487, 421)
        Me.pMsg15.Name = "pMsg15"
        Me.pMsg15.Size = New System.Drawing.Size(589, 20)
        Me.pMsg15.TabIndex = 927
        Me.pMsg15.Tag = "15"
        Me.pMsg15.Visible = False
        '
        'pMsg14
        '
        Me.pMsg14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg14.Location = New System.Drawing.Point(487, 399)
        Me.pMsg14.Name = "pMsg14"
        Me.pMsg14.Size = New System.Drawing.Size(589, 20)
        Me.pMsg14.TabIndex = 926
        Me.pMsg14.Tag = "14"
        Me.pMsg14.Visible = False
        '
        'pMsg13
        '
        Me.pMsg13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg13.Location = New System.Drawing.Point(487, 377)
        Me.pMsg13.Name = "pMsg13"
        Me.pMsg13.Size = New System.Drawing.Size(589, 20)
        Me.pMsg13.TabIndex = 925
        Me.pMsg13.Tag = "13"
        Me.pMsg13.Visible = False
        '
        'pMsg12
        '
        Me.pMsg12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg12.Location = New System.Drawing.Point(487, 355)
        Me.pMsg12.Name = "pMsg12"
        Me.pMsg12.Size = New System.Drawing.Size(589, 20)
        Me.pMsg12.TabIndex = 924
        Me.pMsg12.Tag = "12"
        Me.pMsg12.Visible = False
        '
        'pMsg11
        '
        Me.pMsg11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg11.Location = New System.Drawing.Point(487, 333)
        Me.pMsg11.Name = "pMsg11"
        Me.pMsg11.Size = New System.Drawing.Size(589, 20)
        Me.pMsg11.TabIndex = 923
        Me.pMsg11.Tag = "11"
        Me.pMsg11.Visible = False
        '
        'pMsg10
        '
        Me.pMsg10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg10.Location = New System.Drawing.Point(487, 297)
        Me.pMsg10.Name = "pMsg10"
        Me.pMsg10.Size = New System.Drawing.Size(589, 20)
        Me.pMsg10.TabIndex = 922
        Me.pMsg10.Tag = "10"
        Me.pMsg10.Visible = False
        '
        'pMsg9
        '
        Me.pMsg9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg9.Location = New System.Drawing.Point(487, 275)
        Me.pMsg9.Name = "pMsg9"
        Me.pMsg9.Size = New System.Drawing.Size(589, 20)
        Me.pMsg9.TabIndex = 921
        Me.pMsg9.Tag = "9"
        Me.pMsg9.Visible = False
        '
        'pMsg8
        '
        Me.pMsg8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg8.Location = New System.Drawing.Point(487, 253)
        Me.pMsg8.Name = "pMsg8"
        Me.pMsg8.Size = New System.Drawing.Size(589, 20)
        Me.pMsg8.TabIndex = 920
        Me.pMsg8.Tag = "8"
        Me.pMsg8.Visible = False
        '
        'pMsg7
        '
        Me.pMsg7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg7.Location = New System.Drawing.Point(487, 231)
        Me.pMsg7.Name = "pMsg7"
        Me.pMsg7.Size = New System.Drawing.Size(589, 20)
        Me.pMsg7.TabIndex = 919
        Me.pMsg7.Tag = "7"
        Me.pMsg7.Visible = False
        '
        'pMsg6
        '
        Me.pMsg6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg6.Location = New System.Drawing.Point(487, 209)
        Me.pMsg6.Name = "pMsg6"
        Me.pMsg6.Size = New System.Drawing.Size(589, 20)
        Me.pMsg6.TabIndex = 918
        Me.pMsg6.Tag = "6"
        Me.pMsg6.Visible = False
        '
        'pMsg5
        '
        Me.pMsg5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg5.Location = New System.Drawing.Point(487, 187)
        Me.pMsg5.Name = "pMsg5"
        Me.pMsg5.Size = New System.Drawing.Size(589, 20)
        Me.pMsg5.TabIndex = 917
        Me.pMsg5.Tag = "5"
        Me.pMsg5.Visible = False
        '
        'pMsg4
        '
        Me.pMsg4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg4.Location = New System.Drawing.Point(487, 165)
        Me.pMsg4.Name = "pMsg4"
        Me.pMsg4.Size = New System.Drawing.Size(589, 20)
        Me.pMsg4.TabIndex = 916
        Me.pMsg4.Tag = "4"
        Me.pMsg4.Visible = False
        '
        'pMsg3
        '
        Me.pMsg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg3.Location = New System.Drawing.Point(487, 143)
        Me.pMsg3.Name = "pMsg3"
        Me.pMsg3.Size = New System.Drawing.Size(589, 20)
        Me.pMsg3.TabIndex = 915
        Me.pMsg3.Tag = "3"
        Me.pMsg3.Visible = False
        '
        'pMsg2
        '
        Me.pMsg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg2.Location = New System.Drawing.Point(487, 121)
        Me.pMsg2.Name = "pMsg2"
        Me.pMsg2.Size = New System.Drawing.Size(589, 20)
        Me.pMsg2.TabIndex = 914
        Me.pMsg2.Tag = "2"
        Me.pMsg2.Visible = False
        '
        'pMsg1
        '
        Me.pMsg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMsg1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pMsg1.Location = New System.Drawing.Point(487, 99)
        Me.pMsg1.Name = "pMsg1"
        Me.pMsg1.Size = New System.Drawing.Size(589, 20)
        Me.pMsg1.TabIndex = 913
        Me.pMsg1.Tag = "1"
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
        Me.Label25.Text = "Message"
        '
        'l20
        '
        Me.l20.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l20.Location = New System.Drawing.Point(3, 531)
        Me.l20.Name = "l20"
        Me.l20.Size = New System.Drawing.Size(30, 20)
        Me.l20.TabIndex = 910
        Me.l20.Tag = "20"
        Me.l20.Text = "20"
        Me.l20.Visible = False
        '
        'pIf20
        '
        Me.pIf20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf20.Location = New System.Drawing.Point(38, 531)
        Me.pIf20.Name = "pIf20"
        Me.pIf20.Size = New System.Drawing.Size(448, 20)
        Me.pIf20.TabIndex = 911
        Me.pIf20.Tag = "20"
        Me.pIf20.Visible = False
        '
        'l19
        '
        Me.l19.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l19.Location = New System.Drawing.Point(3, 509)
        Me.l19.Name = "l19"
        Me.l19.Size = New System.Drawing.Size(30, 20)
        Me.l19.TabIndex = 908
        Me.l19.Tag = "19"
        Me.l19.Text = "19"
        Me.l19.Visible = False
        '
        'pIf19
        '
        Me.pIf19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf19.Location = New System.Drawing.Point(38, 509)
        Me.pIf19.Name = "pIf19"
        Me.pIf19.Size = New System.Drawing.Size(448, 20)
        Me.pIf19.TabIndex = 909
        Me.pIf19.Tag = "19"
        Me.pIf19.Visible = False
        '
        'l18
        '
        Me.l18.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l18.Location = New System.Drawing.Point(3, 487)
        Me.l18.Name = "l18"
        Me.l18.Size = New System.Drawing.Size(30, 20)
        Me.l18.TabIndex = 906
        Me.l18.Tag = "18"
        Me.l18.Text = "18"
        Me.l18.Visible = False
        '
        'pIf18
        '
        Me.pIf18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf18.Location = New System.Drawing.Point(38, 487)
        Me.pIf18.Name = "pIf18"
        Me.pIf18.Size = New System.Drawing.Size(448, 20)
        Me.pIf18.TabIndex = 907
        Me.pIf18.Tag = "18"
        Me.pIf18.Visible = False
        '
        'l17
        '
        Me.l17.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l17.Location = New System.Drawing.Point(3, 465)
        Me.l17.Name = "l17"
        Me.l17.Size = New System.Drawing.Size(30, 20)
        Me.l17.TabIndex = 904
        Me.l17.Tag = "17"
        Me.l17.Text = "17"
        Me.l17.Visible = False
        '
        'pIf17
        '
        Me.pIf17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf17.Location = New System.Drawing.Point(38, 465)
        Me.pIf17.Name = "pIf17"
        Me.pIf17.Size = New System.Drawing.Size(448, 20)
        Me.pIf17.TabIndex = 905
        Me.pIf17.Tag = "17"
        Me.pIf17.Visible = False
        '
        'l16
        '
        Me.l16.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l16.Location = New System.Drawing.Point(3, 443)
        Me.l16.Name = "l16"
        Me.l16.Size = New System.Drawing.Size(30, 20)
        Me.l16.TabIndex = 902
        Me.l16.Tag = "16"
        Me.l16.Text = "16"
        Me.l16.Visible = False
        '
        'pIf16
        '
        Me.pIf16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf16.Location = New System.Drawing.Point(38, 443)
        Me.pIf16.Name = "pIf16"
        Me.pIf16.Size = New System.Drawing.Size(448, 20)
        Me.pIf16.TabIndex = 903
        Me.pIf16.Tag = "16"
        Me.pIf16.Visible = False
        '
        'l15
        '
        Me.l15.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l15.Location = New System.Drawing.Point(3, 421)
        Me.l15.Name = "l15"
        Me.l15.Size = New System.Drawing.Size(30, 20)
        Me.l15.TabIndex = 900
        Me.l15.Tag = "15"
        Me.l15.Text = "15"
        Me.l15.Visible = False
        '
        'pIf15
        '
        Me.pIf15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf15.Location = New System.Drawing.Point(38, 421)
        Me.pIf15.Name = "pIf15"
        Me.pIf15.Size = New System.Drawing.Size(448, 20)
        Me.pIf15.TabIndex = 901
        Me.pIf15.Tag = "15"
        Me.pIf15.Visible = False
        '
        'l14
        '
        Me.l14.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l14.Location = New System.Drawing.Point(3, 399)
        Me.l14.Name = "l14"
        Me.l14.Size = New System.Drawing.Size(30, 20)
        Me.l14.TabIndex = 898
        Me.l14.Tag = "14"
        Me.l14.Text = "14"
        Me.l14.Visible = False
        '
        'pIf14
        '
        Me.pIf14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf14.Location = New System.Drawing.Point(38, 399)
        Me.pIf14.Name = "pIf14"
        Me.pIf14.Size = New System.Drawing.Size(448, 20)
        Me.pIf14.TabIndex = 899
        Me.pIf14.Tag = "14"
        Me.pIf14.Visible = False
        '
        'l13
        '
        Me.l13.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l13.Location = New System.Drawing.Point(3, 377)
        Me.l13.Name = "l13"
        Me.l13.Size = New System.Drawing.Size(30, 20)
        Me.l13.TabIndex = 896
        Me.l13.Tag = "13"
        Me.l13.Text = "13"
        Me.l13.Visible = False
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
        'l12
        '
        Me.l12.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l12.Location = New System.Drawing.Point(3, 355)
        Me.l12.Name = "l12"
        Me.l12.Size = New System.Drawing.Size(30, 20)
        Me.l12.TabIndex = 894
        Me.l12.Tag = "12"
        Me.l12.Text = "12"
        Me.l12.Visible = False
        '
        'pIf12
        '
        Me.pIf12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf12.Location = New System.Drawing.Point(38, 355)
        Me.pIf12.Name = "pIf12"
        Me.pIf12.Size = New System.Drawing.Size(448, 20)
        Me.pIf12.TabIndex = 895
        Me.pIf12.Tag = "12"
        Me.pIf12.Visible = False
        '
        'l11
        '
        Me.l11.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l11.Location = New System.Drawing.Point(3, 333)
        Me.l11.Name = "l11"
        Me.l11.Size = New System.Drawing.Size(30, 20)
        Me.l11.TabIndex = 892
        Me.l11.Tag = "11"
        Me.l11.Text = "11"
        Me.l11.Visible = False
        '
        'pIf11
        '
        Me.pIf11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf11.Location = New System.Drawing.Point(38, 333)
        Me.pIf11.Name = "pIf11"
        Me.pIf11.Size = New System.Drawing.Size(448, 20)
        Me.pIf11.TabIndex = 893
        Me.pIf11.Tag = "11"
        Me.pIf11.Visible = False
        '
        'l10
        '
        Me.l10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l10.Location = New System.Drawing.Point(3, 303)
        Me.l10.Name = "l10"
        Me.l10.Size = New System.Drawing.Size(30, 20)
        Me.l10.TabIndex = 890
        Me.l10.Tag = "10"
        Me.l10.Text = "10"
        Me.l10.Visible = False
        '
        'pIf10
        '
        Me.pIf10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf10.Location = New System.Drawing.Point(38, 297)
        Me.pIf10.Name = "pIf10"
        Me.pIf10.Size = New System.Drawing.Size(448, 20)
        Me.pIf10.TabIndex = 891
        Me.pIf10.Tag = "10"
        Me.pIf10.Visible = False
        '
        'l9
        '
        Me.l9.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l9.Location = New System.Drawing.Point(3, 281)
        Me.l9.Name = "l9"
        Me.l9.Size = New System.Drawing.Size(30, 20)
        Me.l9.TabIndex = 888
        Me.l9.Tag = "9"
        Me.l9.Text = "9"
        Me.l9.Visible = False
        '
        'pIf9
        '
        Me.pIf9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf9.Location = New System.Drawing.Point(38, 275)
        Me.pIf9.Name = "pIf9"
        Me.pIf9.Size = New System.Drawing.Size(448, 20)
        Me.pIf9.TabIndex = 889
        Me.pIf9.Tag = "9"
        Me.pIf9.Visible = False
        '
        'l8
        '
        Me.l8.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l8.Location = New System.Drawing.Point(3, 257)
        Me.l8.Name = "l8"
        Me.l8.Size = New System.Drawing.Size(30, 20)
        Me.l8.TabIndex = 886
        Me.l8.Tag = "8"
        Me.l8.Text = "8"
        Me.l8.Visible = False
        '
        'pIf8
        '
        Me.pIf8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf8.Location = New System.Drawing.Point(38, 253)
        Me.pIf8.Name = "pIf8"
        Me.pIf8.Size = New System.Drawing.Size(448, 20)
        Me.pIf8.TabIndex = 887
        Me.pIf8.Tag = "8"
        Me.pIf8.Visible = False
        '
        'l7
        '
        Me.l7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l7.Location = New System.Drawing.Point(3, 234)
        Me.l7.Name = "l7"
        Me.l7.Size = New System.Drawing.Size(30, 20)
        Me.l7.TabIndex = 884
        Me.l7.Tag = "7"
        Me.l7.Text = "7"
        Me.l7.Visible = False
        '
        'pIf7
        '
        Me.pIf7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf7.Location = New System.Drawing.Point(38, 231)
        Me.pIf7.Name = "pIf7"
        Me.pIf7.Size = New System.Drawing.Size(448, 20)
        Me.pIf7.TabIndex = 885
        Me.pIf7.Tag = "7"
        Me.pIf7.Visible = False
        '
        'l6
        '
        Me.l6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l6.Location = New System.Drawing.Point(3, 212)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(30, 20)
        Me.l6.TabIndex = 882
        Me.l6.Tag = "6"
        Me.l6.Text = "6"
        Me.l6.Visible = False
        '
        'pIf6
        '
        Me.pIf6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf6.Location = New System.Drawing.Point(38, 209)
        Me.pIf6.Name = "pIf6"
        Me.pIf6.Size = New System.Drawing.Size(448, 20)
        Me.pIf6.TabIndex = 883
        Me.pIf6.Tag = "6"
        Me.pIf6.Visible = False
        '
        'l5
        '
        Me.l5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5.Location = New System.Drawing.Point(3, 190)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(30, 20)
        Me.l5.TabIndex = 880
        Me.l5.Tag = "5"
        Me.l5.Text = "5"
        Me.l5.Visible = False
        '
        'pIf5
        '
        Me.pIf5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf5.Location = New System.Drawing.Point(38, 187)
        Me.pIf5.Name = "pIf5"
        Me.pIf5.Size = New System.Drawing.Size(448, 20)
        Me.pIf5.TabIndex = 881
        Me.pIf5.Tag = "5"
        Me.pIf5.Visible = False
        '
        'l4
        '
        Me.l4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.Location = New System.Drawing.Point(3, 168)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(30, 20)
        Me.l4.TabIndex = 878
        Me.l4.Tag = "4"
        Me.l4.Text = "4"
        Me.l4.Visible = False
        '
        'pIf4
        '
        Me.pIf4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf4.Location = New System.Drawing.Point(38, 165)
        Me.pIf4.Name = "pIf4"
        Me.pIf4.Size = New System.Drawing.Size(448, 20)
        Me.pIf4.TabIndex = 879
        Me.pIf4.Tag = "4"
        Me.pIf4.Visible = False
        '
        'l3
        '
        Me.l3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.Location = New System.Drawing.Point(3, 144)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(30, 20)
        Me.l3.TabIndex = 876
        Me.l3.Tag = "3"
        Me.l3.Text = "3"
        Me.l3.Visible = False
        '
        'pIf3
        '
        Me.pIf3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf3.Location = New System.Drawing.Point(38, 143)
        Me.pIf3.Name = "pIf3"
        Me.pIf3.Size = New System.Drawing.Size(448, 20)
        Me.pIf3.TabIndex = 877
        Me.pIf3.Tag = "3"
        Me.pIf3.Visible = False
        '
        'l2
        '
        Me.l2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(3, 121)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(30, 20)
        Me.l2.TabIndex = 874
        Me.l2.Tag = "2"
        Me.l2.Text = "2"
        Me.l2.Visible = False
        '
        'pIf2
        '
        Me.pIf2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf2.Location = New System.Drawing.Point(38, 121)
        Me.pIf2.Name = "pIf2"
        Me.pIf2.Size = New System.Drawing.Size(448, 20)
        Me.pIf2.TabIndex = 875
        Me.pIf2.Tag = "2"
        Me.pIf2.Visible = False
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(3, 99)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(30, 20)
        Me.l1.TabIndex = 872
        Me.l1.Tag = "1"
        Me.l1.Text = "1"
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
        'pIf1
        '
        Me.pIf1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pIf1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.pIf1.Location = New System.Drawing.Point(38, 99)
        Me.pIf1.Name = "pIf1"
        Me.pIf1.Size = New System.Drawing.Size(448, 20)
        Me.pIf1.TabIndex = 873
        Me.pIf1.Tag = "1"
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
        Me.Label50.Text = "Simple message If"
        '
        'mFormExitEventSimpleMessage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1207, 601)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.p19)
        Me.Controls.Add(Me.p18)
        Me.Controls.Add(Me.p17)
        Me.Controls.Add(Me.p16)
        Me.Controls.Add(Me.p15)
        Me.Controls.Add(Me.p14)
        Me.Controls.Add(Me.p13)
        Me.Controls.Add(Me.p12)
        Me.Controls.Add(Me.p11)
        Me.Controls.Add(Me.p10)
        Me.Controls.Add(Me.p9)
        Me.Controls.Add(Me.p8)
        Me.Controls.Add(Me.p7)
        Me.Controls.Add(Me.p6)
        Me.Controls.Add(Me.p5)
        Me.Controls.Add(Me.p4)
        Me.Controls.Add(Me.p3)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.pMsg20)
        Me.Controls.Add(Me.pMsg19)
        Me.Controls.Add(Me.pMsg18)
        Me.Controls.Add(Me.pMsg17)
        Me.Controls.Add(Me.pMsg16)
        Me.Controls.Add(Me.pMsg15)
        Me.Controls.Add(Me.pMsg14)
        Me.Controls.Add(Me.pMsg13)
        Me.Controls.Add(Me.pMsg12)
        Me.Controls.Add(Me.pMsg11)
        Me.Controls.Add(Me.pMsg10)
        Me.Controls.Add(Me.pMsg9)
        Me.Controls.Add(Me.pMsg8)
        Me.Controls.Add(Me.pMsg7)
        Me.Controls.Add(Me.pMsg6)
        Me.Controls.Add(Me.pMsg5)
        Me.Controls.Add(Me.pMsg4)
        Me.Controls.Add(Me.pMsg3)
        Me.Controls.Add(Me.pMsg2)
        Me.Controls.Add(Me.pMsg1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.l20)
        Me.Controls.Add(Me.pIf20)
        Me.Controls.Add(Me.l19)
        Me.Controls.Add(Me.pIf19)
        Me.Controls.Add(Me.l18)
        Me.Controls.Add(Me.pIf18)
        Me.Controls.Add(Me.l17)
        Me.Controls.Add(Me.pIf17)
        Me.Controls.Add(Me.l16)
        Me.Controls.Add(Me.pIf16)
        Me.Controls.Add(Me.l15)
        Me.Controls.Add(Me.pIf15)
        Me.Controls.Add(Me.l14)
        Me.Controls.Add(Me.pIf14)
        Me.Controls.Add(Me.l13)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.l12)
        Me.Controls.Add(Me.pIf12)
        Me.Controls.Add(Me.l11)
        Me.Controls.Add(Me.pIf11)
        Me.Controls.Add(Me.l10)
        Me.Controls.Add(Me.pIf10)
        Me.Controls.Add(Me.l9)
        Me.Controls.Add(Me.pIf9)
        Me.Controls.Add(Me.l8)
        Me.Controls.Add(Me.pIf8)
        Me.Controls.Add(Me.l7)
        Me.Controls.Add(Me.pIf7)
        Me.Controls.Add(Me.l6)
        Me.Controls.Add(Me.pIf6)
        Me.Controls.Add(Me.l5)
        Me.Controls.Add(Me.pIf5)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.pIf4)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.pIf3)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.pIf2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.pIf1)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormExitEventSimpleMessage"
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
        Me.Label1.Text = "Simple message on field " + pp(2).Trim + "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim
    End Sub

    Dim validatingEvent As String = ""
    Dim validatingEventOst As String = ""

    Function getDTC() As System.Data.DataTable
        validatingEvent = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select od " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "' and pp<>'fp' and pp<>'lbl' and pp<>'dgv' and pp<>'button' " +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        validatingEvent = dt.Rows(0).Item("od").ToString.Trim
    End Sub

    Sub getMetaDataPane()
        validatingEventOst = ""
        'izrazZADGV
        If validatingEvent = "" Then Exit Sub
        validatingEvent = validatingEvent.Replace(vbCrLf, "").Replace("#{", "").Trim
        If validatingEvent.Substring(validatingEvent.Length - 1, 1) = "}" Then validatingEvent = validatingEvent.Substring(0, validatingEvent.Length - 1)

        Dim pp() As String = validatingEvent.Split(";")

        Dim simplemessageif() As String = {}
        Dim simplemessageis() As String = {}

        For i As Integer = 0 To pp.GetUpperBound(0)

            If pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("MSGIF") >= 0 Then
                simplemessageif = pp(i).Trim.ToUpper.Replace("MSGIF=", "").Split("$")
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("SIMPLEMSGIS") >= 0 Then
                simplemessageis = pp(i).Trim.ToUpper.Replace("SIMPLEMSGIS=", "").Split("$")
            ElseIf pp(i).Trim <> "" Then
                validatingEventOst = validatingEventOst + pp(i) + ";"
            End If
        Next

        For i As Integer = 0 To simplemessageif.GetUpperBound(0)
            For Each k As Control In Me.Controls
                If Not k.Tag Is Nothing AndAlso k.Tag <> "" AndAlso k.Tag = CStr(i + 1).Trim Then
                    k.Visible = True
                End If
            Next
        Next

        For i As Integer = 0 To simplemessageif.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "pIf" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = simplemessageif(i).Trim
        Next

        For i As Integer = 0 To simplemessageis.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "pMsg" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = simplemessageis(i).Trim
        Next

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim mmsg As String = ""
        Dim br As Integer = 0

        'msgIf
        Dim simplemessageif As String = ""
        For k As Integer = 1 To 20
            Dim tb As Control = NadjiKontrolu(Me, "pIf" + CStr(k).Trim)
            If Not tb Is Nothing AndAlso DirectCast(tb, TextBox).Text <> "" Then
                simplemessageif = simplemessageif + tb.Text + "$"
                br = br + 1
            End If
        Next
        If simplemessageif <> "" Then
            simplemessageif = "MsgIf=" + simplemessageif.TrimEnd("$") + ";"
            mmsg = mmsg + simplemessageif
        End If

        'msgIf
        Dim simplemessageis As String = ""
        For k As Integer = 1 To br
            Dim tb As Control = NadjiKontrolu(Me, "pMsg" + CStr(k).Trim)
            If DirectCast(tb, TextBox).Text <> "" Then simplemessageis = simplemessageis + tb.Text + "$"
        Next
        If simplemessageis <> "" Then
            simplemessageis = "SimpleMsgIs=" + simplemessageis.TrimEnd("$") + ";"
            mmsg = mmsg + simplemessageis
        End If

        mmsg = mmsg.Replace("'", "''")

        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim

        Dim sql As String = "update istpolja set od=N'#{" + validatingEventOst + ";" + mmsg + "}'" +
            " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim +
            "' and  rbr='" + pp(4).Trim + "'"

        Dim p2 As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sql)
        If p2 = "nok" Then ISTMessageBox.Show("Error") Else Me.Close()

    End Sub

    Private Sub p1_Click(sender As Object, e As EventArgs) Handles p1.Click, p2.Click, p3.Click, p4.Click, p5.Click, p6.Click, p7.Click, p8.Click, p9.Click, p10.Click, p11.Click, p12.Click, p13.Click, p14.Click, p15.Click, p16.Click, p17.Click, p18.Click, p19.Click

        Dim lbl As Label = DirectCast(sender, Label)
        Dim brs As String = lbl.Name.Replace("p", "")
        Dim br As Integer = CInt(lbl.Name.Replace("p", "").Trim) + 1

        For Each k As Control In Me.Controls
            If Not k.Tag Is Nothing AndAlso k.Tag <> "" AndAlso k.Tag = CStr(br).Trim Then
                k.Visible = True
            End If
        Next

    End Sub

End Class