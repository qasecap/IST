'Option Strict Off

Public Class mFormEnterEventVisibleTrue
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
    Friend WithEvents tb20 As TextBox
    Friend WithEvents tb19 As TextBox
    Friend WithEvents tb18 As TextBox
    Friend WithEvents tb17 As TextBox
    Friend WithEvents tb16 As TextBox
    Friend WithEvents tb15 As TextBox
    Friend WithEvents tb14 As TextBox
    Friend WithEvents tb13 As TextBox
    Friend WithEvents tb12 As TextBox
    Friend WithEvents tb11 As TextBox
    Friend WithEvents tb10 As TextBox
    Friend WithEvents tb9 As TextBox
    Friend WithEvents tb8 As TextBox
    Friend WithEvents tb7 As TextBox
    Friend WithEvents tb6 As TextBox
    Friend WithEvents tb5 As TextBox
    Friend WithEvents tb4 As TextBox
    Friend WithEvents tb3 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents l20 As Label
    Friend WithEvents ta20 As TextBox
    Friend WithEvents l19 As Label
    Friend WithEvents ta19 As TextBox
    Friend WithEvents l18 As Label
    Friend WithEvents ta18 As TextBox
    Friend WithEvents l17 As Label
    Friend WithEvents ta17 As TextBox
    Friend WithEvents l16 As Label
    Friend WithEvents ta16 As TextBox
    Friend WithEvents l15 As Label
    Friend WithEvents ta15 As TextBox
    Friend WithEvents l14 As Label
    Friend WithEvents ta14 As TextBox
    Friend WithEvents l13 As Label
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents l12 As Label
    Friend WithEvents ta12 As TextBox
    Friend WithEvents l11 As Label
    Friend WithEvents ta11 As TextBox
    Friend WithEvents l10 As Label
    Friend WithEvents ta10 As TextBox
    Friend WithEvents l9 As Label
    Friend WithEvents ta9 As TextBox
    Friend WithEvents l8 As Label
    Friend WithEvents ta8 As TextBox
    Friend WithEvents l7 As Label
    Friend WithEvents ta7 As TextBox
    Friend WithEvents l6 As Label
    Friend WithEvents ta6 As TextBox
    Friend WithEvents l5 As Label
    Friend WithEvents ta5 As TextBox
    Friend WithEvents l4 As Label
    Friend WithEvents ta4 As TextBox
    Friend WithEvents l3 As Label
    Friend WithEvents ta3 As TextBox
    Friend WithEvents l2 As Label
    Friend WithEvents ta2 As TextBox
    Friend WithEvents l1 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents ta1 As TextBox
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
        Me.tb20 = New System.Windows.Forms.TextBox()
        Me.tb19 = New System.Windows.Forms.TextBox()
        Me.tb18 = New System.Windows.Forms.TextBox()
        Me.tb17 = New System.Windows.Forms.TextBox()
        Me.tb16 = New System.Windows.Forms.TextBox()
        Me.tb15 = New System.Windows.Forms.TextBox()
        Me.tb14 = New System.Windows.Forms.TextBox()
        Me.tb13 = New System.Windows.Forms.TextBox()
        Me.tb12 = New System.Windows.Forms.TextBox()
        Me.tb11 = New System.Windows.Forms.TextBox()
        Me.tb10 = New System.Windows.Forms.TextBox()
        Me.tb9 = New System.Windows.Forms.TextBox()
        Me.tb8 = New System.Windows.Forms.TextBox()
        Me.tb7 = New System.Windows.Forms.TextBox()
        Me.tb6 = New System.Windows.Forms.TextBox()
        Me.tb5 = New System.Windows.Forms.TextBox()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.l20 = New System.Windows.Forms.Label()
        Me.ta20 = New System.Windows.Forms.TextBox()
        Me.l19 = New System.Windows.Forms.Label()
        Me.ta19 = New System.Windows.Forms.TextBox()
        Me.l18 = New System.Windows.Forms.Label()
        Me.ta18 = New System.Windows.Forms.TextBox()
        Me.l17 = New System.Windows.Forms.Label()
        Me.ta17 = New System.Windows.Forms.TextBox()
        Me.l16 = New System.Windows.Forms.Label()
        Me.ta16 = New System.Windows.Forms.TextBox()
        Me.l15 = New System.Windows.Forms.Label()
        Me.ta15 = New System.Windows.Forms.TextBox()
        Me.l14 = New System.Windows.Forms.Label()
        Me.ta14 = New System.Windows.Forms.TextBox()
        Me.l13 = New System.Windows.Forms.Label()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.l12 = New System.Windows.Forms.Label()
        Me.ta12 = New System.Windows.Forms.TextBox()
        Me.l11 = New System.Windows.Forms.Label()
        Me.ta11 = New System.Windows.Forms.TextBox()
        Me.l10 = New System.Windows.Forms.Label()
        Me.ta10 = New System.Windows.Forms.TextBox()
        Me.l9 = New System.Windows.Forms.Label()
        Me.ta9 = New System.Windows.Forms.TextBox()
        Me.l8 = New System.Windows.Forms.Label()
        Me.ta8 = New System.Windows.Forms.TextBox()
        Me.l7 = New System.Windows.Forms.Label()
        Me.ta7 = New System.Windows.Forms.TextBox()
        Me.l6 = New System.Windows.Forms.Label()
        Me.ta6 = New System.Windows.Forms.TextBox()
        Me.l5 = New System.Windows.Forms.Label()
        Me.ta5 = New System.Windows.Forms.TextBox()
        Me.l4 = New System.Windows.Forms.Label()
        Me.ta4 = New System.Windows.Forms.TextBox()
        Me.l3 = New System.Windows.Forms.Label()
        Me.ta3 = New System.Windows.Forms.TextBox()
        Me.l2 = New System.Windows.Forms.Label()
        Me.ta2 = New System.Windows.Forms.TextBox()
        Me.l1 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.ta1 = New System.Windows.Forms.TextBox()
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
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Visible TRUE"
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
        'tb20
        '
        Me.tb20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb20.Location = New System.Drawing.Point(487, 531)
        Me.tb20.Name = "tb20"
        Me.tb20.Size = New System.Drawing.Size(589, 20)
        Me.tb20.TabIndex = 932
        Me.tb20.Tag = "20"
        Me.tb20.Visible = False
        '
        'tb19
        '
        Me.tb19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb19.Location = New System.Drawing.Point(487, 509)
        Me.tb19.Name = "tb19"
        Me.tb19.Size = New System.Drawing.Size(589, 20)
        Me.tb19.TabIndex = 931
        Me.tb19.Tag = "19"
        Me.tb19.Visible = False
        '
        'tb18
        '
        Me.tb18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb18.Location = New System.Drawing.Point(487, 487)
        Me.tb18.Name = "tb18"
        Me.tb18.Size = New System.Drawing.Size(589, 20)
        Me.tb18.TabIndex = 930
        Me.tb18.Tag = "18"
        Me.tb18.Visible = False
        '
        'tb17
        '
        Me.tb17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb17.Location = New System.Drawing.Point(487, 465)
        Me.tb17.Name = "tb17"
        Me.tb17.Size = New System.Drawing.Size(589, 20)
        Me.tb17.TabIndex = 929
        Me.tb17.Tag = "17"
        Me.tb17.Visible = False
        '
        'tb16
        '
        Me.tb16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb16.Location = New System.Drawing.Point(487, 443)
        Me.tb16.Name = "tb16"
        Me.tb16.Size = New System.Drawing.Size(589, 20)
        Me.tb16.TabIndex = 928
        Me.tb16.Tag = "16"
        Me.tb16.Visible = False
        '
        'tb15
        '
        Me.tb15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb15.Location = New System.Drawing.Point(487, 421)
        Me.tb15.Name = "tb15"
        Me.tb15.Size = New System.Drawing.Size(589, 20)
        Me.tb15.TabIndex = 927
        Me.tb15.Tag = "15"
        Me.tb15.Visible = False
        '
        'tb14
        '
        Me.tb14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb14.Location = New System.Drawing.Point(487, 399)
        Me.tb14.Name = "tb14"
        Me.tb14.Size = New System.Drawing.Size(589, 20)
        Me.tb14.TabIndex = 926
        Me.tb14.Tag = "14"
        Me.tb14.Visible = False
        '
        'tb13
        '
        Me.tb13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb13.Location = New System.Drawing.Point(487, 377)
        Me.tb13.Name = "tb13"
        Me.tb13.Size = New System.Drawing.Size(589, 20)
        Me.tb13.TabIndex = 925
        Me.tb13.Tag = "13"
        Me.tb13.Visible = False
        '
        'tb12
        '
        Me.tb12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb12.Location = New System.Drawing.Point(487, 355)
        Me.tb12.Name = "tb12"
        Me.tb12.Size = New System.Drawing.Size(589, 20)
        Me.tb12.TabIndex = 924
        Me.tb12.Tag = "12"
        Me.tb12.Visible = False
        '
        'tb11
        '
        Me.tb11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb11.Location = New System.Drawing.Point(487, 333)
        Me.tb11.Name = "tb11"
        Me.tb11.Size = New System.Drawing.Size(589, 20)
        Me.tb11.TabIndex = 923
        Me.tb11.Tag = "11"
        Me.tb11.Visible = False
        '
        'tb10
        '
        Me.tb10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb10.Location = New System.Drawing.Point(487, 297)
        Me.tb10.Name = "tb10"
        Me.tb10.Size = New System.Drawing.Size(589, 20)
        Me.tb10.TabIndex = 922
        Me.tb10.Tag = "10"
        Me.tb10.Visible = False
        '
        'tb9
        '
        Me.tb9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb9.Location = New System.Drawing.Point(487, 275)
        Me.tb9.Name = "tb9"
        Me.tb9.Size = New System.Drawing.Size(589, 20)
        Me.tb9.TabIndex = 921
        Me.tb9.Tag = "9"
        Me.tb9.Visible = False
        '
        'tb8
        '
        Me.tb8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb8.Location = New System.Drawing.Point(487, 253)
        Me.tb8.Name = "tb8"
        Me.tb8.Size = New System.Drawing.Size(589, 20)
        Me.tb8.TabIndex = 920
        Me.tb8.Tag = "8"
        Me.tb8.Visible = False
        '
        'tb7
        '
        Me.tb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb7.Location = New System.Drawing.Point(487, 231)
        Me.tb7.Name = "tb7"
        Me.tb7.Size = New System.Drawing.Size(589, 20)
        Me.tb7.TabIndex = 919
        Me.tb7.Tag = "7"
        Me.tb7.Visible = False
        '
        'tb6
        '
        Me.tb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb6.Location = New System.Drawing.Point(487, 209)
        Me.tb6.Name = "tb6"
        Me.tb6.Size = New System.Drawing.Size(589, 20)
        Me.tb6.TabIndex = 918
        Me.tb6.Tag = "6"
        Me.tb6.Visible = False
        '
        'tb5
        '
        Me.tb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb5.Location = New System.Drawing.Point(487, 187)
        Me.tb5.Name = "tb5"
        Me.tb5.Size = New System.Drawing.Size(589, 20)
        Me.tb5.TabIndex = 917
        Me.tb5.Tag = "5"
        Me.tb5.Visible = False
        '
        'tb4
        '
        Me.tb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb4.Location = New System.Drawing.Point(487, 165)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(589, 20)
        Me.tb4.TabIndex = 916
        Me.tb4.Tag = "4"
        Me.tb4.Visible = False
        '
        'tb3
        '
        Me.tb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb3.Location = New System.Drawing.Point(487, 143)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(589, 20)
        Me.tb3.TabIndex = 915
        Me.tb3.Tag = "3"
        Me.tb3.Visible = False
        '
        'tb2
        '
        Me.tb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb2.Location = New System.Drawing.Point(487, 121)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(589, 20)
        Me.tb2.TabIndex = 914
        Me.tb2.Tag = "2"
        Me.tb2.Visible = False
        '
        'tb1
        '
        Me.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tb1.Location = New System.Drawing.Point(487, 99)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(589, 20)
        Me.tb1.TabIndex = 913
        Me.tb1.Tag = "1"
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
        Me.Label25.Text = "Visible true"
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
        'ta20
        '
        Me.ta20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta20.Location = New System.Drawing.Point(38, 531)
        Me.ta20.Name = "ta20"
        Me.ta20.Size = New System.Drawing.Size(448, 20)
        Me.ta20.TabIndex = 911
        Me.ta20.Tag = "20"
        Me.ta20.Visible = False
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
        'ta19
        '
        Me.ta19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta19.Location = New System.Drawing.Point(38, 509)
        Me.ta19.Name = "ta19"
        Me.ta19.Size = New System.Drawing.Size(448, 20)
        Me.ta19.TabIndex = 909
        Me.ta19.Tag = "19"
        Me.ta19.Visible = False
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
        'ta18
        '
        Me.ta18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta18.Location = New System.Drawing.Point(38, 487)
        Me.ta18.Name = "ta18"
        Me.ta18.Size = New System.Drawing.Size(448, 20)
        Me.ta18.TabIndex = 907
        Me.ta18.Tag = "18"
        Me.ta18.Visible = False
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
        'ta17
        '
        Me.ta17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta17.Location = New System.Drawing.Point(38, 465)
        Me.ta17.Name = "ta17"
        Me.ta17.Size = New System.Drawing.Size(448, 20)
        Me.ta17.TabIndex = 905
        Me.ta17.Tag = "17"
        Me.ta17.Visible = False
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
        'ta16
        '
        Me.ta16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta16.Location = New System.Drawing.Point(38, 443)
        Me.ta16.Name = "ta16"
        Me.ta16.Size = New System.Drawing.Size(448, 20)
        Me.ta16.TabIndex = 903
        Me.ta16.Tag = "16"
        Me.ta16.Visible = False
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
        'ta15
        '
        Me.ta15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta15.Location = New System.Drawing.Point(38, 421)
        Me.ta15.Name = "ta15"
        Me.ta15.Size = New System.Drawing.Size(448, 20)
        Me.ta15.TabIndex = 901
        Me.ta15.Tag = "15"
        Me.ta15.Visible = False
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
        'ta14
        '
        Me.ta14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta14.Location = New System.Drawing.Point(38, 399)
        Me.ta14.Name = "ta14"
        Me.ta14.Size = New System.Drawing.Size(448, 20)
        Me.ta14.TabIndex = 899
        Me.ta14.Tag = "14"
        Me.ta14.Visible = False
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
        'ta12
        '
        Me.ta12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta12.Location = New System.Drawing.Point(38, 355)
        Me.ta12.Name = "ta12"
        Me.ta12.Size = New System.Drawing.Size(448, 20)
        Me.ta12.TabIndex = 895
        Me.ta12.Tag = "12"
        Me.ta12.Visible = False
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
        'ta11
        '
        Me.ta11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta11.Location = New System.Drawing.Point(38, 333)
        Me.ta11.Name = "ta11"
        Me.ta11.Size = New System.Drawing.Size(448, 20)
        Me.ta11.TabIndex = 893
        Me.ta11.Tag = "11"
        Me.ta11.Visible = False
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
        'ta10
        '
        Me.ta10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta10.Location = New System.Drawing.Point(38, 297)
        Me.ta10.Name = "ta10"
        Me.ta10.Size = New System.Drawing.Size(448, 20)
        Me.ta10.TabIndex = 891
        Me.ta10.Tag = "10"
        Me.ta10.Visible = False
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
        'ta9
        '
        Me.ta9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta9.Location = New System.Drawing.Point(38, 275)
        Me.ta9.Name = "ta9"
        Me.ta9.Size = New System.Drawing.Size(448, 20)
        Me.ta9.TabIndex = 889
        Me.ta9.Tag = "9"
        Me.ta9.Visible = False
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
        'ta8
        '
        Me.ta8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta8.Location = New System.Drawing.Point(38, 253)
        Me.ta8.Name = "ta8"
        Me.ta8.Size = New System.Drawing.Size(448, 20)
        Me.ta8.TabIndex = 887
        Me.ta8.Tag = "8"
        Me.ta8.Visible = False
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
        'ta7
        '
        Me.ta7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta7.Location = New System.Drawing.Point(38, 231)
        Me.ta7.Name = "ta7"
        Me.ta7.Size = New System.Drawing.Size(448, 20)
        Me.ta7.TabIndex = 885
        Me.ta7.Tag = "7"
        Me.ta7.Visible = False
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
        'ta6
        '
        Me.ta6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta6.Location = New System.Drawing.Point(38, 209)
        Me.ta6.Name = "ta6"
        Me.ta6.Size = New System.Drawing.Size(448, 20)
        Me.ta6.TabIndex = 883
        Me.ta6.Tag = "6"
        Me.ta6.Visible = False
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
        'ta5
        '
        Me.ta5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta5.Location = New System.Drawing.Point(38, 187)
        Me.ta5.Name = "ta5"
        Me.ta5.Size = New System.Drawing.Size(448, 20)
        Me.ta5.TabIndex = 881
        Me.ta5.Tag = "5"
        Me.ta5.Visible = False
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
        'ta4
        '
        Me.ta4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta4.Location = New System.Drawing.Point(38, 165)
        Me.ta4.Name = "ta4"
        Me.ta4.Size = New System.Drawing.Size(448, 20)
        Me.ta4.TabIndex = 879
        Me.ta4.Tag = "4"
        Me.ta4.Visible = False
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
        'ta3
        '
        Me.ta3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta3.Location = New System.Drawing.Point(38, 143)
        Me.ta3.Name = "ta3"
        Me.ta3.Size = New System.Drawing.Size(448, 20)
        Me.ta3.TabIndex = 877
        Me.ta3.Tag = "3"
        Me.ta3.Visible = False
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
        'ta2
        '
        Me.ta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta2.Location = New System.Drawing.Point(38, 121)
        Me.ta2.Name = "ta2"
        Me.ta2.Size = New System.Drawing.Size(448, 20)
        Me.ta2.TabIndex = 875
        Me.ta2.Tag = "2"
        Me.ta2.Visible = False
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
        'ta1
        '
        Me.ta1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ta1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ta1.Location = New System.Drawing.Point(38, 99)
        Me.ta1.Name = "ta1"
        Me.ta1.Size = New System.Drawing.Size(448, 20)
        Me.ta1.TabIndex = 873
        Me.ta1.Tag = "1"
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
        Me.Label50.Text = "Visible true if"
        '
        'mFormEnterEventVisibleTrue
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
        Me.Controls.Add(Me.tb20)
        Me.Controls.Add(Me.tb19)
        Me.Controls.Add(Me.tb18)
        Me.Controls.Add(Me.tb17)
        Me.Controls.Add(Me.tb16)
        Me.Controls.Add(Me.tb15)
        Me.Controls.Add(Me.tb14)
        Me.Controls.Add(Me.tb13)
        Me.Controls.Add(Me.tb12)
        Me.Controls.Add(Me.tb11)
        Me.Controls.Add(Me.tb10)
        Me.Controls.Add(Me.tb9)
        Me.Controls.Add(Me.tb8)
        Me.Controls.Add(Me.tb7)
        Me.Controls.Add(Me.tb6)
        Me.Controls.Add(Me.tb5)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.l20)
        Me.Controls.Add(Me.ta20)
        Me.Controls.Add(Me.l19)
        Me.Controls.Add(Me.ta19)
        Me.Controls.Add(Me.l18)
        Me.Controls.Add(Me.ta18)
        Me.Controls.Add(Me.l17)
        Me.Controls.Add(Me.ta17)
        Me.Controls.Add(Me.l16)
        Me.Controls.Add(Me.ta16)
        Me.Controls.Add(Me.l15)
        Me.Controls.Add(Me.ta15)
        Me.Controls.Add(Me.l14)
        Me.Controls.Add(Me.ta14)
        Me.Controls.Add(Me.l13)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.l12)
        Me.Controls.Add(Me.ta12)
        Me.Controls.Add(Me.l11)
        Me.Controls.Add(Me.ta11)
        Me.Controls.Add(Me.l10)
        Me.Controls.Add(Me.ta10)
        Me.Controls.Add(Me.l9)
        Me.Controls.Add(Me.ta9)
        Me.Controls.Add(Me.l8)
        Me.Controls.Add(Me.ta8)
        Me.Controls.Add(Me.l7)
        Me.Controls.Add(Me.ta7)
        Me.Controls.Add(Me.l6)
        Me.Controls.Add(Me.ta6)
        Me.Controls.Add(Me.l5)
        Me.Controls.Add(Me.ta5)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.ta4)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.ta3)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.ta2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.ta1)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormEnterEventVisibleTrue"
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
        Me.Label1.Text = "On Enter event on field " + pp(2).Trim + "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim + "     VISIBLE TRUE"
    End Sub

    Dim enterEvent As String = ""
    Dim enterEventOst As String = ""

    Function getDTC() As System.Data.DataTable
        enterEvent = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select DO " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "' and pp<>'fp' and pp<>'lbl' and pp<>'dgv' and pp<>'button'  " +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        enterEvent = dt.Rows(0).Item("od").ToString.Trim
    End Sub

    Sub getMetaDataPane()
        enterEventOst = ""
        'izrazZADGV
        If enterEvent = "" Then Exit Sub
        enterEvent = enterEvent.Replace(vbCrLf, "").Replace("#{", "").Trim
        If enterEvent.Substring(enterEvent.Length - 1, 1) = "}" Then enterEvent = enterEvent.Substring(0, enterEvent.Length - 1)

        Dim pp() As String = enterEvent.Split(";")

        Dim visibletrueif() As String = {}
        Dim visibletrue() As String = {}

        For i As Integer = 0 To pp.GetUpperBound(0)

            If pp(i).Length > 12 AndAlso pp(i).Trim.ToUpper.IndexOf("VISIBLETRUEIF") >= 0 Then
                visibletrueif = pp(i).Trim.ToUpper.Replace("VISIBLETRUEIF=", "").Split("$")
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("VISIBLETRUE") >= 0 Then
                visibletrue = pp(i).Trim.ToUpper.Replace("VISIBLETRUE=", "").Split("$")
            ElseIf pp(i).Trim <> "" Then
                enterEventOst = enterEventOst + pp(i) + ";"
            End If
        Next

        For i As Integer = 0 To visibletrueif.GetUpperBound(0)
            For Each k As Control In Me.Controls
                If Not k.Tag Is Nothing AndAlso k.Tag <> "" AndAlso k.Tag = CStr(i + 1).Trim Then
                    k.Visible = True
                End If
            Next
        Next

        For i As Integer = 0 To visibletrueif.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "ta" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = visibletrueif(i).Trim
        Next

        For i As Integer = 0 To visibletrue.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "tb" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = visibletrue(i).Trim
        Next

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim kkon As String = ""
        Dim br As Integer = 0

        'visibletrueif
        Dim visibletrueif As String = ""
        For k As Integer = 1 To 20
            Dim tb As Control = NadjiKontrolu(Me, "ta" + CStr(k).Trim)
            If Not tb Is Nothing AndAlso DirectCast(tb, TextBox).Text <> "" Then
                visibletrueif = visibletrueif + tb.Text + "$"
                br = br + 1
            End If
        Next
        If visibletrueif <> "" Then
            visibletrueif = "visibletrueif=" + visibletrueif.TrimEnd("$") + ";"
            kkon = kkon + visibletrueif
        End If

        'visibletrueif
        Dim visibletrue As String = ""
        For k As Integer = 1 To br
            Dim tb As Control = NadjiKontrolu(Me, "tb" + CStr(k).Trim)
            If DirectCast(tb, TextBox).Text <> "" Then visibletrue = visibletrue + tb.Text + "$"
        Next
        If visibletrue <> "" Then
            visibletrue = "visibletrue=" + visibletrue.TrimEnd("$") + ";"
            kkon = kkon + visibletrue
        End If

        kkon = kkon.Replace("'", "''")

        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim

        Dim sql As String = "update istpolja set DO=N'#{" + enterEventOst + ";" + kkon + "}'" +
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