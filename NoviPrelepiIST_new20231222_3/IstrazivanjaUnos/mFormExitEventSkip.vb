'Option Strict Off

Imports System.Web

Public Class mFormExitEventSkip
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
    Friend WithEvents p19 As Label
    Friend WithEvents p18 As Label
    Friend WithEvents p17 As Label
    Friend WithEvents p16 As Label
    Friend WithEvents p15 As Label
    Friend WithEvents p14 As Label
    Friend WithEvents p13 As Label
    Friend WithEvents p12 As Label
    Friend WithEvents p11 As Label
    Friend WithEvents lbl96 As Label
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
    Friend WithEvents lbl94 As Label
    Friend WithEvents lbl95 As Label
    Friend WithEvents txtSSEExceptIf As TextBox
    Friend WithEvents cbSSEExcept As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents cbc10 As TextBox
    Friend WithEvents cbc9 As TextBox
    Friend WithEvents cbc8 As TextBox
    Friend WithEvents cbc7 As TextBox
    Friend WithEvents cbc6 As TextBox
    Friend WithEvents cbc5 As TextBox
    Friend WithEvents cbc4 As TextBox
    Friend WithEvents cbc3 As TextBox
    Friend WithEvents cbc2 As TextBox
    Friend WithEvents cbc1 As TextBox
    Friend WithEvents btnSkip As Button
    Friend WithEvents es20 As CheckBox
    Friend WithEvents nv20 As CheckBox
    Friend WithEvents d20 As CheckBox
    Friend WithEvents se20 As CheckBox
    Friend WithEvents es19 As CheckBox
    Friend WithEvents nv19 As CheckBox
    Friend WithEvents d19 As CheckBox
    Friend WithEvents se19 As CheckBox
    Friend WithEvents es18 As CheckBox
    Friend WithEvents nv18 As CheckBox
    Friend WithEvents d18 As CheckBox
    Friend WithEvents se18 As CheckBox
    Friend WithEvents es17 As CheckBox
    Friend WithEvents nv17 As CheckBox
    Friend WithEvents d17 As CheckBox
    Friend WithEvents se17 As CheckBox
    Friend WithEvents es16 As CheckBox
    Friend WithEvents nv16 As CheckBox
    Friend WithEvents d16 As CheckBox
    Friend WithEvents se16 As CheckBox
    Friend WithEvents es15 As CheckBox
    Friend WithEvents nv15 As CheckBox
    Friend WithEvents d15 As CheckBox
    Friend WithEvents se15 As CheckBox
    Friend WithEvents es14 As CheckBox
    Friend WithEvents nv14 As CheckBox
    Friend WithEvents d14 As CheckBox
    Friend WithEvents se14 As CheckBox
    Friend WithEvents es13 As CheckBox
    Friend WithEvents nv13 As CheckBox
    Friend WithEvents d13 As CheckBox
    Friend WithEvents se13 As CheckBox
    Friend WithEvents es12 As CheckBox
    Friend WithEvents nv12 As CheckBox
    Friend WithEvents d12 As CheckBox
    Friend WithEvents se12 As CheckBox
    Friend WithEvents es11 As CheckBox
    Friend WithEvents nv11 As CheckBox
    Friend WithEvents d11 As CheckBox
    Friend WithEvents se11 As CheckBox
    Friend WithEvents es10 As CheckBox
    Friend WithEvents nv10 As CheckBox
    Friend WithEvents d10 As CheckBox
    Friend WithEvents se10 As CheckBox
    Friend WithEvents es9 As CheckBox
    Friend WithEvents nv9 As CheckBox
    Friend WithEvents d9 As CheckBox
    Friend WithEvents se9 As CheckBox
    Friend WithEvents es8 As CheckBox
    Friend WithEvents nv8 As CheckBox
    Friend WithEvents d8 As CheckBox
    Friend WithEvents se8 As CheckBox
    Friend WithEvents es7 As CheckBox
    Friend WithEvents nv7 As CheckBox
    Friend WithEvents d7 As CheckBox
    Friend WithEvents se7 As CheckBox
    Friend WithEvents es6 As CheckBox
    Friend WithEvents nv6 As CheckBox
    Friend WithEvents d6 As CheckBox
    Friend WithEvents se6 As CheckBox
    Friend WithEvents es5 As CheckBox
    Friend WithEvents nv5 As CheckBox
    Friend WithEvents d5 As CheckBox
    Friend WithEvents se5 As CheckBox
    Friend WithEvents es4 As CheckBox
    Friend WithEvents nv4 As CheckBox
    Friend WithEvents d4 As CheckBox
    Friend WithEvents se4 As CheckBox
    Friend WithEvents es3 As CheckBox
    Friend WithEvents nv3 As CheckBox
    Friend WithEvents d3 As CheckBox
    Friend WithEvents se3 As CheckBox
    Friend WithEvents es2 As CheckBox
    Friend WithEvents nv2 As CheckBox
    Friend WithEvents d2 As CheckBox
    Friend WithEvents se2 As CheckBox
    Friend WithEvents txtSSEExceptWhat As TextBox
    Friend WithEvents es1 As CheckBox
    Friend WithEvents nv1 As CheckBox
    Friend WithEvents d1 As CheckBox
    Friend WithEvents lbl97 As Label
    Friend WithEvents l20 As Label
    Friend WithEvents tbc20 As TextBox
    Friend WithEvents l19 As Label
    Friend WithEvents tbc19 As TextBox
    Friend WithEvents l18 As Label
    Friend WithEvents tbc18 As TextBox
    Friend WithEvents l17 As Label
    Friend WithEvents tbc17 As TextBox
    Friend WithEvents l16 As Label
    Friend WithEvents tbc16 As TextBox
    Friend WithEvents l15 As Label
    Friend WithEvents tbc15 As TextBox
    Friend WithEvents l14 As Label
    Friend WithEvents tbc14 As TextBox
    Friend WithEvents l13 As Label
    Friend WithEvents tbc13 As TextBox
    Friend WithEvents l12 As Label
    Friend WithEvents tbc12 As TextBox
    Friend WithEvents l11 As Label
    Friend WithEvents tbc11 As TextBox
    Friend WithEvents l10 As Label
    Friend WithEvents tbc10 As TextBox
    Friend WithEvents l9 As Label
    Friend WithEvents tbc9 As TextBox
    Friend WithEvents l8 As Label
    Friend WithEvents tbc8 As TextBox
    Friend WithEvents l7 As Label
    Friend WithEvents tbc7 As TextBox
    Friend WithEvents l6 As Label
    Friend WithEvents tbc6 As TextBox
    Friend WithEvents l5 As Label
    Friend WithEvents tbc5 As TextBox
    Friend WithEvents l4 As Label
    Friend WithEvents tbc4 As TextBox
    Friend WithEvents l3 As Label
    Friend WithEvents tbc3 As TextBox
    Friend WithEvents l2 As Label
    Friend WithEvents tbc2 As TextBox
    Friend WithEvents l1 As Label
    Friend WithEvents lbl93 As Label
    Friend WithEvents tbc1 As TextBox
    Friend WithEvents lbl98 As Label
    Friend WithEvents lbl99 As Label
    Friend WithEvents cbSEFAll As CheckBox
    Friend WithEvents cbSSEAll As CheckBox
    Friend WithEvents cbSDSAll As CheckBox
    Friend WithEvents cbSVFAll As CheckBox
    Friend WithEvents se1 As CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.p19 = New System.Windows.Forms.Label()
        Me.p18 = New System.Windows.Forms.Label()
        Me.p17 = New System.Windows.Forms.Label()
        Me.p16 = New System.Windows.Forms.Label()
        Me.p15 = New System.Windows.Forms.Label()
        Me.p14 = New System.Windows.Forms.Label()
        Me.p13 = New System.Windows.Forms.Label()
        Me.p12 = New System.Windows.Forms.Label()
        Me.p11 = New System.Windows.Forms.Label()
        Me.lbl96 = New System.Windows.Forms.Label()
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
        Me.lbl94 = New System.Windows.Forms.Label()
        Me.lbl95 = New System.Windows.Forms.Label()
        Me.txtSSEExceptIf = New System.Windows.Forms.TextBox()
        Me.cbSSEExcept = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.cbc10 = New System.Windows.Forms.TextBox()
        Me.cbc9 = New System.Windows.Forms.TextBox()
        Me.cbc8 = New System.Windows.Forms.TextBox()
        Me.cbc7 = New System.Windows.Forms.TextBox()
        Me.cbc6 = New System.Windows.Forms.TextBox()
        Me.cbc5 = New System.Windows.Forms.TextBox()
        Me.cbc4 = New System.Windows.Forms.TextBox()
        Me.cbc3 = New System.Windows.Forms.TextBox()
        Me.cbc2 = New System.Windows.Forms.TextBox()
        Me.cbc1 = New System.Windows.Forms.TextBox()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.es20 = New System.Windows.Forms.CheckBox()
        Me.nv20 = New System.Windows.Forms.CheckBox()
        Me.d20 = New System.Windows.Forms.CheckBox()
        Me.se20 = New System.Windows.Forms.CheckBox()
        Me.es19 = New System.Windows.Forms.CheckBox()
        Me.nv19 = New System.Windows.Forms.CheckBox()
        Me.d19 = New System.Windows.Forms.CheckBox()
        Me.se19 = New System.Windows.Forms.CheckBox()
        Me.es18 = New System.Windows.Forms.CheckBox()
        Me.nv18 = New System.Windows.Forms.CheckBox()
        Me.d18 = New System.Windows.Forms.CheckBox()
        Me.se18 = New System.Windows.Forms.CheckBox()
        Me.es17 = New System.Windows.Forms.CheckBox()
        Me.nv17 = New System.Windows.Forms.CheckBox()
        Me.d17 = New System.Windows.Forms.CheckBox()
        Me.se17 = New System.Windows.Forms.CheckBox()
        Me.es16 = New System.Windows.Forms.CheckBox()
        Me.nv16 = New System.Windows.Forms.CheckBox()
        Me.d16 = New System.Windows.Forms.CheckBox()
        Me.se16 = New System.Windows.Forms.CheckBox()
        Me.es15 = New System.Windows.Forms.CheckBox()
        Me.nv15 = New System.Windows.Forms.CheckBox()
        Me.d15 = New System.Windows.Forms.CheckBox()
        Me.se15 = New System.Windows.Forms.CheckBox()
        Me.es14 = New System.Windows.Forms.CheckBox()
        Me.nv14 = New System.Windows.Forms.CheckBox()
        Me.d14 = New System.Windows.Forms.CheckBox()
        Me.se14 = New System.Windows.Forms.CheckBox()
        Me.es13 = New System.Windows.Forms.CheckBox()
        Me.nv13 = New System.Windows.Forms.CheckBox()
        Me.d13 = New System.Windows.Forms.CheckBox()
        Me.se13 = New System.Windows.Forms.CheckBox()
        Me.es12 = New System.Windows.Forms.CheckBox()
        Me.nv12 = New System.Windows.Forms.CheckBox()
        Me.d12 = New System.Windows.Forms.CheckBox()
        Me.se12 = New System.Windows.Forms.CheckBox()
        Me.es11 = New System.Windows.Forms.CheckBox()
        Me.nv11 = New System.Windows.Forms.CheckBox()
        Me.d11 = New System.Windows.Forms.CheckBox()
        Me.se11 = New System.Windows.Forms.CheckBox()
        Me.es10 = New System.Windows.Forms.CheckBox()
        Me.nv10 = New System.Windows.Forms.CheckBox()
        Me.d10 = New System.Windows.Forms.CheckBox()
        Me.se10 = New System.Windows.Forms.CheckBox()
        Me.es9 = New System.Windows.Forms.CheckBox()
        Me.nv9 = New System.Windows.Forms.CheckBox()
        Me.d9 = New System.Windows.Forms.CheckBox()
        Me.se9 = New System.Windows.Forms.CheckBox()
        Me.es8 = New System.Windows.Forms.CheckBox()
        Me.nv8 = New System.Windows.Forms.CheckBox()
        Me.d8 = New System.Windows.Forms.CheckBox()
        Me.se8 = New System.Windows.Forms.CheckBox()
        Me.es7 = New System.Windows.Forms.CheckBox()
        Me.nv7 = New System.Windows.Forms.CheckBox()
        Me.d7 = New System.Windows.Forms.CheckBox()
        Me.se7 = New System.Windows.Forms.CheckBox()
        Me.es6 = New System.Windows.Forms.CheckBox()
        Me.nv6 = New System.Windows.Forms.CheckBox()
        Me.d6 = New System.Windows.Forms.CheckBox()
        Me.se6 = New System.Windows.Forms.CheckBox()
        Me.es5 = New System.Windows.Forms.CheckBox()
        Me.nv5 = New System.Windows.Forms.CheckBox()
        Me.d5 = New System.Windows.Forms.CheckBox()
        Me.se5 = New System.Windows.Forms.CheckBox()
        Me.es4 = New System.Windows.Forms.CheckBox()
        Me.nv4 = New System.Windows.Forms.CheckBox()
        Me.d4 = New System.Windows.Forms.CheckBox()
        Me.se4 = New System.Windows.Forms.CheckBox()
        Me.es3 = New System.Windows.Forms.CheckBox()
        Me.nv3 = New System.Windows.Forms.CheckBox()
        Me.d3 = New System.Windows.Forms.CheckBox()
        Me.se3 = New System.Windows.Forms.CheckBox()
        Me.es2 = New System.Windows.Forms.CheckBox()
        Me.nv2 = New System.Windows.Forms.CheckBox()
        Me.d2 = New System.Windows.Forms.CheckBox()
        Me.se2 = New System.Windows.Forms.CheckBox()
        Me.txtSSEExceptWhat = New System.Windows.Forms.TextBox()
        Me.es1 = New System.Windows.Forms.CheckBox()
        Me.nv1 = New System.Windows.Forms.CheckBox()
        Me.d1 = New System.Windows.Forms.CheckBox()
        Me.lbl97 = New System.Windows.Forms.Label()
        Me.l20 = New System.Windows.Forms.Label()
        Me.tbc20 = New System.Windows.Forms.TextBox()
        Me.l19 = New System.Windows.Forms.Label()
        Me.tbc19 = New System.Windows.Forms.TextBox()
        Me.l18 = New System.Windows.Forms.Label()
        Me.tbc18 = New System.Windows.Forms.TextBox()
        Me.l17 = New System.Windows.Forms.Label()
        Me.tbc17 = New System.Windows.Forms.TextBox()
        Me.l16 = New System.Windows.Forms.Label()
        Me.tbc16 = New System.Windows.Forms.TextBox()
        Me.l15 = New System.Windows.Forms.Label()
        Me.tbc15 = New System.Windows.Forms.TextBox()
        Me.l14 = New System.Windows.Forms.Label()
        Me.tbc14 = New System.Windows.Forms.TextBox()
        Me.l13 = New System.Windows.Forms.Label()
        Me.tbc13 = New System.Windows.Forms.TextBox()
        Me.l12 = New System.Windows.Forms.Label()
        Me.tbc12 = New System.Windows.Forms.TextBox()
        Me.l11 = New System.Windows.Forms.Label()
        Me.tbc11 = New System.Windows.Forms.TextBox()
        Me.l10 = New System.Windows.Forms.Label()
        Me.tbc10 = New System.Windows.Forms.TextBox()
        Me.l9 = New System.Windows.Forms.Label()
        Me.tbc9 = New System.Windows.Forms.TextBox()
        Me.l8 = New System.Windows.Forms.Label()
        Me.tbc8 = New System.Windows.Forms.TextBox()
        Me.l7 = New System.Windows.Forms.Label()
        Me.tbc7 = New System.Windows.Forms.TextBox()
        Me.l6 = New System.Windows.Forms.Label()
        Me.tbc6 = New System.Windows.Forms.TextBox()
        Me.l5 = New System.Windows.Forms.Label()
        Me.tbc5 = New System.Windows.Forms.TextBox()
        Me.l4 = New System.Windows.Forms.Label()
        Me.tbc4 = New System.Windows.Forms.TextBox()
        Me.l3 = New System.Windows.Forms.Label()
        Me.tbc3 = New System.Windows.Forms.TextBox()
        Me.l2 = New System.Windows.Forms.Label()
        Me.tbc2 = New System.Windows.Forms.TextBox()
        Me.l1 = New System.Windows.Forms.Label()
        Me.lbl93 = New System.Windows.Forms.Label()
        Me.tbc1 = New System.Windows.Forms.TextBox()
        Me.lbl98 = New System.Windows.Forms.Label()
        Me.lbl99 = New System.Windows.Forms.Label()
        Me.cbSEFAll = New System.Windows.Forms.CheckBox()
        Me.cbSSEAll = New System.Windows.Forms.CheckBox()
        Me.cbSDSAll = New System.Windows.Forms.CheckBox()
        Me.cbSVFAll = New System.Windows.Forms.CheckBox()
        Me.se1 = New System.Windows.Forms.CheckBox()
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
        Me.Label1.Size = New System.Drawing.Size(31, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Skip"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(1230, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'p19
        '
        Me.p19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p19.Location = New System.Drawing.Point(774, 512)
        Me.p19.Name = "p19"
        Me.p19.Size = New System.Drawing.Size(16, 16)
        Me.p19.TabIndex = 879
        Me.p19.Tag = "19"
        Me.p19.Text = "+"
        Me.p19.Visible = False
        '
        'p18
        '
        Me.p18.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p18.Location = New System.Drawing.Point(774, 490)
        Me.p18.Name = "p18"
        Me.p18.Size = New System.Drawing.Size(16, 16)
        Me.p18.TabIndex = 878
        Me.p18.Tag = "18"
        Me.p18.Text = "+"
        Me.p18.Visible = False
        '
        'p17
        '
        Me.p17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p17.Location = New System.Drawing.Point(774, 468)
        Me.p17.Name = "p17"
        Me.p17.Size = New System.Drawing.Size(16, 16)
        Me.p17.TabIndex = 877
        Me.p17.Tag = "17"
        Me.p17.Text = "+"
        Me.p17.Visible = False
        '
        'p16
        '
        Me.p16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p16.Location = New System.Drawing.Point(774, 446)
        Me.p16.Name = "p16"
        Me.p16.Size = New System.Drawing.Size(16, 16)
        Me.p16.TabIndex = 876
        Me.p16.Tag = "16"
        Me.p16.Text = "+"
        Me.p16.Visible = False
        '
        'p15
        '
        Me.p15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p15.Location = New System.Drawing.Point(774, 424)
        Me.p15.Name = "p15"
        Me.p15.Size = New System.Drawing.Size(16, 16)
        Me.p15.TabIndex = 875
        Me.p15.Tag = "15"
        Me.p15.Text = "+"
        Me.p15.Visible = False
        '
        'p14
        '
        Me.p14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p14.Location = New System.Drawing.Point(774, 402)
        Me.p14.Name = "p14"
        Me.p14.Size = New System.Drawing.Size(16, 16)
        Me.p14.TabIndex = 874
        Me.p14.Tag = "14"
        Me.p14.Text = "+"
        Me.p14.Visible = False
        '
        'p13
        '
        Me.p13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p13.Location = New System.Drawing.Point(774, 380)
        Me.p13.Name = "p13"
        Me.p13.Size = New System.Drawing.Size(16, 16)
        Me.p13.TabIndex = 873
        Me.p13.Tag = "13"
        Me.p13.Text = "+"
        Me.p13.Visible = False
        '
        'p12
        '
        Me.p12.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p12.Location = New System.Drawing.Point(774, 358)
        Me.p12.Name = "p12"
        Me.p12.Size = New System.Drawing.Size(16, 16)
        Me.p12.TabIndex = 872
        Me.p12.Tag = "12"
        Me.p12.Text = "+"
        Me.p12.Visible = False
        '
        'p11
        '
        Me.p11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p11.Location = New System.Drawing.Point(774, 336)
        Me.p11.Name = "p11"
        Me.p11.Size = New System.Drawing.Size(16, 16)
        Me.p11.TabIndex = 871
        Me.p11.Tag = "11"
        Me.p11.Text = "+"
        Me.p11.Visible = False
        '
        'lbl96
        '
        Me.lbl96.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl96.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl96.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl96.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl96.Location = New System.Drawing.Point(831, 28)
        Me.lbl96.Name = "lbl96"
        Me.lbl96.Size = New System.Drawing.Size(342, 50)
        Me.lbl96.TabIndex = 870
        Me.lbl96.Text = "Skipping rules valid for all conditions"
        '
        'p10
        '
        Me.p10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p10.Location = New System.Drawing.Point(774, 297)
        Me.p10.Name = "p10"
        Me.p10.Size = New System.Drawing.Size(16, 16)
        Me.p10.TabIndex = 869
        Me.p10.Tag = "10"
        Me.p10.Text = "+"
        Me.p10.Visible = False
        '
        'p9
        '
        Me.p9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p9.Location = New System.Drawing.Point(774, 275)
        Me.p9.Name = "p9"
        Me.p9.Size = New System.Drawing.Size(16, 16)
        Me.p9.TabIndex = 868
        Me.p9.Tag = "9"
        Me.p9.Text = "+"
        Me.p9.Visible = False
        '
        'p8
        '
        Me.p8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p8.Location = New System.Drawing.Point(774, 253)
        Me.p8.Name = "p8"
        Me.p8.Size = New System.Drawing.Size(16, 16)
        Me.p8.TabIndex = 867
        Me.p8.Tag = "8"
        Me.p8.Text = "+"
        Me.p8.Visible = False
        '
        'p7
        '
        Me.p7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p7.Location = New System.Drawing.Point(774, 231)
        Me.p7.Name = "p7"
        Me.p7.Size = New System.Drawing.Size(16, 16)
        Me.p7.TabIndex = 866
        Me.p7.Tag = "7"
        Me.p7.Text = "+"
        Me.p7.Visible = False
        '
        'p6
        '
        Me.p6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p6.Location = New System.Drawing.Point(774, 209)
        Me.p6.Name = "p6"
        Me.p6.Size = New System.Drawing.Size(16, 16)
        Me.p6.TabIndex = 865
        Me.p6.Tag = "6"
        Me.p6.Text = "+"
        Me.p6.Visible = False
        '
        'p5
        '
        Me.p5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p5.Location = New System.Drawing.Point(774, 187)
        Me.p5.Name = "p5"
        Me.p5.Size = New System.Drawing.Size(16, 16)
        Me.p5.TabIndex = 864
        Me.p5.Tag = "5"
        Me.p5.Text = "+"
        Me.p5.Visible = False
        '
        'p4
        '
        Me.p4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p4.Location = New System.Drawing.Point(774, 165)
        Me.p4.Name = "p4"
        Me.p4.Size = New System.Drawing.Size(16, 16)
        Me.p4.TabIndex = 863
        Me.p4.Tag = "4"
        Me.p4.Text = "+"
        Me.p4.Visible = False
        '
        'p3
        '
        Me.p3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p3.Location = New System.Drawing.Point(774, 143)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(16, 16)
        Me.p3.TabIndex = 862
        Me.p3.Tag = "3"
        Me.p3.Text = "+"
        Me.p3.Visible = False
        '
        'p2
        '
        Me.p2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p2.Location = New System.Drawing.Point(774, 121)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(16, 16)
        Me.p2.TabIndex = 861
        Me.p2.Tag = "2"
        Me.p2.Text = "+"
        Me.p2.Visible = False
        '
        'p1
        '
        Me.p1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.p1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.p1.Location = New System.Drawing.Point(774, 99)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(16, 16)
        Me.p1.TabIndex = 860
        Me.p1.Tag = "1"
        Me.p1.Text = "+"
        '
        'lbl94
        '
        Me.lbl94.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl94.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl94.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl94.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl94.Location = New System.Drawing.Point(849, 266)
        Me.lbl94.Name = "lbl94"
        Me.lbl94.Size = New System.Drawing.Size(342, 20)
        Me.lbl94.TabIndex = 859
        Me.lbl94.Text = "List of fields to be excepted - separated by comma"
        '
        'lbl95
        '
        Me.lbl95.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl95.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl95.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl95.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl95.Location = New System.Drawing.Point(849, 221)
        Me.lbl95.Name = "lbl95"
        Me.lbl95.Size = New System.Drawing.Size(342, 20)
        Me.lbl95.TabIndex = 858
        Me.lbl95.Text = "Condition for exception"
        '
        'txtSSEExceptIf
        '
        Me.txtSSEExceptIf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSSEExceptIf.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSSEExceptIf.Location = New System.Drawing.Point(849, 243)
        Me.txtSSEExceptIf.Name = "txtSSEExceptIf"
        Me.txtSSEExceptIf.Size = New System.Drawing.Size(342, 20)
        Me.txtSSEExceptIf.TabIndex = 857
        '
        'cbSSEExcept
        '
        Me.cbSSEExcept.AccessibleName = ""
        Me.cbSSEExcept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSSEExcept.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSSEExcept.Location = New System.Drawing.Point(849, 190)
        Me.cbSSEExcept.Name = "cbSSEExcept"
        Me.cbSSEExcept.Size = New System.Drawing.Size(264, 19)
        Me.cbSSEExcept.TabIndex = 856
        Me.cbSSEExcept.Text = "Skipped Set Empty Except..."
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(41, 531)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(70, 20)
        Me.TextBox1.TabIndex = 855
        Me.TextBox1.Tag = "20"
        Me.TextBox1.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(41, 509)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(70, 20)
        Me.TextBox2.TabIndex = 854
        Me.TextBox2.Tag = "19"
        Me.TextBox2.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(41, 487)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(70, 20)
        Me.TextBox3.TabIndex = 853
        Me.TextBox3.Tag = "18"
        Me.TextBox3.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(41, 465)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(70, 20)
        Me.TextBox4.TabIndex = 852
        Me.TextBox4.Tag = "17"
        Me.TextBox4.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(41, 443)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(70, 20)
        Me.TextBox5.TabIndex = 851
        Me.TextBox5.Tag = "16"
        Me.TextBox5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(41, 421)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(70, 20)
        Me.TextBox6.TabIndex = 850
        Me.TextBox6.Tag = "15"
        Me.TextBox6.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(41, 399)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(70, 20)
        Me.TextBox7.TabIndex = 849
        Me.TextBox7.Tag = "14"
        Me.TextBox7.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(41, 377)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(70, 20)
        Me.TextBox8.TabIndex = 848
        Me.TextBox8.Tag = "13"
        Me.TextBox8.Visible = False
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(41, 355)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(70, 20)
        Me.TextBox9.TabIndex = 847
        Me.TextBox9.Tag = "12"
        Me.TextBox9.Visible = False
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(41, 333)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(70, 20)
        Me.TextBox10.TabIndex = 846
        Me.TextBox10.Tag = "11"
        Me.TextBox10.Visible = False
        '
        'cbc10
        '
        Me.cbc10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc10.Location = New System.Drawing.Point(41, 297)
        Me.cbc10.Name = "cbc10"
        Me.cbc10.Size = New System.Drawing.Size(70, 20)
        Me.cbc10.TabIndex = 845
        Me.cbc10.Tag = "10"
        Me.cbc10.Visible = False
        '
        'cbc9
        '
        Me.cbc9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc9.Location = New System.Drawing.Point(41, 275)
        Me.cbc9.Name = "cbc9"
        Me.cbc9.Size = New System.Drawing.Size(70, 20)
        Me.cbc9.TabIndex = 844
        Me.cbc9.Tag = "9"
        Me.cbc9.Visible = False
        '
        'cbc8
        '
        Me.cbc8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc8.Location = New System.Drawing.Point(41, 253)
        Me.cbc8.Name = "cbc8"
        Me.cbc8.Size = New System.Drawing.Size(70, 20)
        Me.cbc8.TabIndex = 843
        Me.cbc8.Tag = "8"
        Me.cbc8.Visible = False
        '
        'cbc7
        '
        Me.cbc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc7.Location = New System.Drawing.Point(41, 231)
        Me.cbc7.Name = "cbc7"
        Me.cbc7.Size = New System.Drawing.Size(70, 20)
        Me.cbc7.TabIndex = 842
        Me.cbc7.Tag = "7"
        Me.cbc7.Visible = False
        '
        'cbc6
        '
        Me.cbc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc6.Location = New System.Drawing.Point(41, 209)
        Me.cbc6.Name = "cbc6"
        Me.cbc6.Size = New System.Drawing.Size(70, 20)
        Me.cbc6.TabIndex = 841
        Me.cbc6.Tag = "6"
        Me.cbc6.Visible = False
        '
        'cbc5
        '
        Me.cbc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc5.Location = New System.Drawing.Point(41, 187)
        Me.cbc5.Name = "cbc5"
        Me.cbc5.Size = New System.Drawing.Size(70, 20)
        Me.cbc5.TabIndex = 840
        Me.cbc5.Tag = "5"
        Me.cbc5.Visible = False
        '
        'cbc4
        '
        Me.cbc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc4.Location = New System.Drawing.Point(41, 165)
        Me.cbc4.Name = "cbc4"
        Me.cbc4.Size = New System.Drawing.Size(70, 20)
        Me.cbc4.TabIndex = 839
        Me.cbc4.Tag = "4"
        Me.cbc4.Visible = False
        '
        'cbc3
        '
        Me.cbc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc3.Location = New System.Drawing.Point(41, 143)
        Me.cbc3.Name = "cbc3"
        Me.cbc3.Size = New System.Drawing.Size(70, 20)
        Me.cbc3.TabIndex = 838
        Me.cbc3.Tag = "3"
        Me.cbc3.Visible = False
        '
        'cbc2
        '
        Me.cbc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc2.Location = New System.Drawing.Point(41, 121)
        Me.cbc2.Name = "cbc2"
        Me.cbc2.Size = New System.Drawing.Size(70, 20)
        Me.cbc2.TabIndex = 837
        Me.cbc2.Tag = "2"
        Me.cbc2.Visible = False
        '
        'cbc1
        '
        Me.cbc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbc1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbc1.Location = New System.Drawing.Point(41, 99)
        Me.cbc1.Name = "cbc1"
        Me.cbc1.Size = New System.Drawing.Size(70, 20)
        Me.cbc1.TabIndex = 836
        Me.cbc1.Tag = "1"
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnSkip.Location = New System.Drawing.Point(849, 466)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(342, 24)
        Me.btnSkip.TabIndex = 835
        Me.btnSkip.Text = "Insert"
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'es20
        '
        Me.es20.AccessibleName = "SkippedDontSave;"
        Me.es20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es20.Location = New System.Drawing.Point(640, 532)
        Me.es20.Name = "es20"
        Me.es20.Size = New System.Drawing.Size(131, 19)
        Me.es20.TabIndex = 834
        Me.es20.Tag = "20"
        Me.es20.Text = "Empted on Save "
        Me.es20.Visible = False
        '
        'nv20
        '
        Me.nv20.AccessibleName = "SkippedVisibleFalse;"
        Me.nv20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv20.Location = New System.Drawing.Point(443, 531)
        Me.nv20.Name = "nv20"
        Me.nv20.Size = New System.Drawing.Size(85, 19)
        Me.nv20.TabIndex = 832
        Me.nv20.Tag = "20"
        Me.nv20.Text = "Not visible"
        Me.nv20.Visible = False
        '
        'd20
        '
        Me.d20.AccessibleName = "d20"
        Me.d20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d20.Location = New System.Drawing.Point(366, 531)
        Me.d20.Name = "d20"
        Me.d20.Size = New System.Drawing.Size(82, 19)
        Me.d20.TabIndex = 831
        Me.d20.Tag = "20"
        Me.d20.Text = "Disabled"
        Me.d20.Visible = False
        '
        'se20
        '
        Me.se20.AccessibleName = "SkippedSetEmpty;"
        Me.se20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se20.Location = New System.Drawing.Point(533, 531)
        Me.se20.Name = "se20"
        Me.se20.Size = New System.Drawing.Size(109, 19)
        Me.se20.TabIndex = 833
        Me.se20.Tag = "20"
        Me.se20.Text = "Set to empty"
        Me.se20.Visible = False
        '
        'es19
        '
        Me.es19.AccessibleName = "SkippedDontSave;"
        Me.es19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es19.Location = New System.Drawing.Point(640, 510)
        Me.es19.Name = "es19"
        Me.es19.Size = New System.Drawing.Size(131, 19)
        Me.es19.TabIndex = 830
        Me.es19.Tag = "19"
        Me.es19.Text = "Empted on Save "
        Me.es19.Visible = False
        '
        'nv19
        '
        Me.nv19.AccessibleName = "SkippedVisibleFalse;"
        Me.nv19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv19.Location = New System.Drawing.Point(443, 509)
        Me.nv19.Name = "nv19"
        Me.nv19.Size = New System.Drawing.Size(85, 19)
        Me.nv19.TabIndex = 828
        Me.nv19.Tag = "19"
        Me.nv19.Text = "Not visible"
        Me.nv19.Visible = False
        '
        'd19
        '
        Me.d19.AccessibleName = "d19"
        Me.d19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d19.Location = New System.Drawing.Point(366, 509)
        Me.d19.Name = "d19"
        Me.d19.Size = New System.Drawing.Size(82, 19)
        Me.d19.TabIndex = 827
        Me.d19.Tag = "19"
        Me.d19.Text = "Disabled"
        Me.d19.Visible = False
        '
        'se19
        '
        Me.se19.AccessibleName = "SkippedSetEmpty;"
        Me.se19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se19.Location = New System.Drawing.Point(533, 509)
        Me.se19.Name = "se19"
        Me.se19.Size = New System.Drawing.Size(109, 19)
        Me.se19.TabIndex = 829
        Me.se19.Tag = "19"
        Me.se19.Text = "Set to empty"
        Me.se19.Visible = False
        '
        'es18
        '
        Me.es18.AccessibleName = "SkippedDontSave;"
        Me.es18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es18.Location = New System.Drawing.Point(640, 488)
        Me.es18.Name = "es18"
        Me.es18.Size = New System.Drawing.Size(131, 19)
        Me.es18.TabIndex = 826
        Me.es18.Tag = "18"
        Me.es18.Text = "Empted on Save "
        Me.es18.Visible = False
        '
        'nv18
        '
        Me.nv18.AccessibleName = "SkippedVisibleFalse;"
        Me.nv18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv18.Location = New System.Drawing.Point(443, 487)
        Me.nv18.Name = "nv18"
        Me.nv18.Size = New System.Drawing.Size(85, 19)
        Me.nv18.TabIndex = 824
        Me.nv18.Tag = "18"
        Me.nv18.Text = "Not visible"
        Me.nv18.Visible = False
        '
        'd18
        '
        Me.d18.AccessibleName = "d18"
        Me.d18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d18.Location = New System.Drawing.Point(366, 487)
        Me.d18.Name = "d18"
        Me.d18.Size = New System.Drawing.Size(82, 19)
        Me.d18.TabIndex = 823
        Me.d18.Tag = "18"
        Me.d18.Text = "Disabled"
        Me.d18.Visible = False
        '
        'se18
        '
        Me.se18.AccessibleName = "SkippedSetEmpty;"
        Me.se18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se18.Location = New System.Drawing.Point(533, 487)
        Me.se18.Name = "se18"
        Me.se18.Size = New System.Drawing.Size(109, 19)
        Me.se18.TabIndex = 825
        Me.se18.Tag = "18"
        Me.se18.Text = "Set to empty"
        Me.se18.Visible = False
        '
        'es17
        '
        Me.es17.AccessibleName = "SkippedDontSave;"
        Me.es17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es17.Location = New System.Drawing.Point(640, 466)
        Me.es17.Name = "es17"
        Me.es17.Size = New System.Drawing.Size(131, 19)
        Me.es17.TabIndex = 822
        Me.es17.Tag = "17"
        Me.es17.Text = "Empted on Save "
        Me.es17.Visible = False
        '
        'nv17
        '
        Me.nv17.AccessibleName = "SkippedVisibleFalse;"
        Me.nv17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv17.Location = New System.Drawing.Point(443, 465)
        Me.nv17.Name = "nv17"
        Me.nv17.Size = New System.Drawing.Size(85, 19)
        Me.nv17.TabIndex = 820
        Me.nv17.Tag = "17"
        Me.nv17.Text = "Not visible"
        Me.nv17.Visible = False
        '
        'd17
        '
        Me.d17.AccessibleName = "d17"
        Me.d17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d17.Location = New System.Drawing.Point(366, 465)
        Me.d17.Name = "d17"
        Me.d17.Size = New System.Drawing.Size(82, 19)
        Me.d17.TabIndex = 819
        Me.d17.Tag = "17"
        Me.d17.Text = "Disabled"
        Me.d17.Visible = False
        '
        'se17
        '
        Me.se17.AccessibleName = "SkippedSetEmpty;"
        Me.se17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se17.Location = New System.Drawing.Point(533, 465)
        Me.se17.Name = "se17"
        Me.se17.Size = New System.Drawing.Size(109, 19)
        Me.se17.TabIndex = 821
        Me.se17.Tag = "17"
        Me.se17.Text = "Set to empty"
        Me.se17.Visible = False
        '
        'es16
        '
        Me.es16.AccessibleName = "SkippedDontSave;"
        Me.es16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es16.Location = New System.Drawing.Point(640, 444)
        Me.es16.Name = "es16"
        Me.es16.Size = New System.Drawing.Size(131, 19)
        Me.es16.TabIndex = 818
        Me.es16.Tag = "16"
        Me.es16.Text = "Empted on Save "
        Me.es16.Visible = False
        '
        'nv16
        '
        Me.nv16.AccessibleName = "SkippedVisibleFalse;"
        Me.nv16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv16.Location = New System.Drawing.Point(443, 443)
        Me.nv16.Name = "nv16"
        Me.nv16.Size = New System.Drawing.Size(85, 19)
        Me.nv16.TabIndex = 816
        Me.nv16.Tag = "16"
        Me.nv16.Text = "Not visible"
        Me.nv16.Visible = False
        '
        'd16
        '
        Me.d16.AccessibleName = "d16"
        Me.d16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d16.Location = New System.Drawing.Point(366, 443)
        Me.d16.Name = "d16"
        Me.d16.Size = New System.Drawing.Size(82, 19)
        Me.d16.TabIndex = 815
        Me.d16.Tag = "16"
        Me.d16.Text = "Disabled"
        Me.d16.Visible = False
        '
        'se16
        '
        Me.se16.AccessibleName = "SkippedSetEmpty;"
        Me.se16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se16.Location = New System.Drawing.Point(533, 443)
        Me.se16.Name = "se16"
        Me.se16.Size = New System.Drawing.Size(109, 19)
        Me.se16.TabIndex = 817
        Me.se16.Tag = "16"
        Me.se16.Text = "Set to empty"
        Me.se16.Visible = False
        '
        'es15
        '
        Me.es15.AccessibleName = "SkippedDontSave;"
        Me.es15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es15.Location = New System.Drawing.Point(640, 422)
        Me.es15.Name = "es15"
        Me.es15.Size = New System.Drawing.Size(131, 19)
        Me.es15.TabIndex = 814
        Me.es15.Tag = "15"
        Me.es15.Text = "Empted on Save "
        Me.es15.Visible = False
        '
        'nv15
        '
        Me.nv15.AccessibleName = "SkippedVisibleFalse;"
        Me.nv15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv15.Location = New System.Drawing.Point(443, 421)
        Me.nv15.Name = "nv15"
        Me.nv15.Size = New System.Drawing.Size(85, 19)
        Me.nv15.TabIndex = 812
        Me.nv15.Tag = "15"
        Me.nv15.Text = "Not visible"
        Me.nv15.Visible = False
        '
        'd15
        '
        Me.d15.AccessibleName = "d15"
        Me.d15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d15.Location = New System.Drawing.Point(366, 421)
        Me.d15.Name = "d15"
        Me.d15.Size = New System.Drawing.Size(82, 19)
        Me.d15.TabIndex = 811
        Me.d15.Tag = "15"
        Me.d15.Text = "Disabled"
        Me.d15.Visible = False
        '
        'se15
        '
        Me.se15.AccessibleName = "SkippedSetEmpty;"
        Me.se15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se15.Location = New System.Drawing.Point(533, 421)
        Me.se15.Name = "se15"
        Me.se15.Size = New System.Drawing.Size(109, 19)
        Me.se15.TabIndex = 813
        Me.se15.Tag = "15"
        Me.se15.Text = "Set to empty"
        Me.se15.Visible = False
        '
        'es14
        '
        Me.es14.AccessibleName = "SkippedDontSave;"
        Me.es14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es14.Location = New System.Drawing.Point(640, 400)
        Me.es14.Name = "es14"
        Me.es14.Size = New System.Drawing.Size(131, 19)
        Me.es14.TabIndex = 810
        Me.es14.Tag = "14"
        Me.es14.Text = "Empted on Save "
        Me.es14.Visible = False
        '
        'nv14
        '
        Me.nv14.AccessibleName = "SkippedVisibleFalse;"
        Me.nv14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv14.Location = New System.Drawing.Point(443, 399)
        Me.nv14.Name = "nv14"
        Me.nv14.Size = New System.Drawing.Size(85, 19)
        Me.nv14.TabIndex = 808
        Me.nv14.Tag = "14"
        Me.nv14.Text = "Not visible"
        Me.nv14.Visible = False
        '
        'd14
        '
        Me.d14.AccessibleName = "d14"
        Me.d14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d14.Location = New System.Drawing.Point(366, 399)
        Me.d14.Name = "d14"
        Me.d14.Size = New System.Drawing.Size(82, 19)
        Me.d14.TabIndex = 807
        Me.d14.Tag = "14"
        Me.d14.Text = "Disabled"
        Me.d14.Visible = False
        '
        'se14
        '
        Me.se14.AccessibleName = "SkippedSetEmpty;"
        Me.se14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se14.Location = New System.Drawing.Point(533, 399)
        Me.se14.Name = "se14"
        Me.se14.Size = New System.Drawing.Size(109, 19)
        Me.se14.TabIndex = 809
        Me.se14.Tag = "14"
        Me.se14.Text = "Set to empty"
        Me.se14.Visible = False
        '
        'es13
        '
        Me.es13.AccessibleName = "SkippedDontSave;"
        Me.es13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es13.Location = New System.Drawing.Point(640, 378)
        Me.es13.Name = "es13"
        Me.es13.Size = New System.Drawing.Size(131, 19)
        Me.es13.TabIndex = 806
        Me.es13.Tag = "13"
        Me.es13.Text = "Empted on Save "
        Me.es13.Visible = False
        '
        'nv13
        '
        Me.nv13.AccessibleName = "SkippedVisibleFalse;"
        Me.nv13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv13.Location = New System.Drawing.Point(443, 377)
        Me.nv13.Name = "nv13"
        Me.nv13.Size = New System.Drawing.Size(85, 19)
        Me.nv13.TabIndex = 804
        Me.nv13.Tag = "13"
        Me.nv13.Text = "Not visible"
        Me.nv13.Visible = False
        '
        'd13
        '
        Me.d13.AccessibleName = "d13"
        Me.d13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d13.Location = New System.Drawing.Point(366, 377)
        Me.d13.Name = "d13"
        Me.d13.Size = New System.Drawing.Size(82, 19)
        Me.d13.TabIndex = 803
        Me.d13.Tag = "13"
        Me.d13.Text = "Disabled"
        Me.d13.Visible = False
        '
        'se13
        '
        Me.se13.AccessibleName = "SkippedSetEmpty;"
        Me.se13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se13.Location = New System.Drawing.Point(533, 377)
        Me.se13.Name = "se13"
        Me.se13.Size = New System.Drawing.Size(109, 19)
        Me.se13.TabIndex = 805
        Me.se13.Tag = "13"
        Me.se13.Text = "Set to empty"
        Me.se13.Visible = False
        '
        'es12
        '
        Me.es12.AccessibleName = "SkippedDontSave;"
        Me.es12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es12.Location = New System.Drawing.Point(640, 356)
        Me.es12.Name = "es12"
        Me.es12.Size = New System.Drawing.Size(131, 19)
        Me.es12.TabIndex = 802
        Me.es12.Tag = "12"
        Me.es12.Text = "Empted on Save "
        Me.es12.Visible = False
        '
        'nv12
        '
        Me.nv12.AccessibleName = "SkippedVisibleFalse;"
        Me.nv12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv12.Location = New System.Drawing.Point(443, 355)
        Me.nv12.Name = "nv12"
        Me.nv12.Size = New System.Drawing.Size(85, 19)
        Me.nv12.TabIndex = 800
        Me.nv12.Tag = "12"
        Me.nv12.Text = "Not visible"
        Me.nv12.Visible = False
        '
        'd12
        '
        Me.d12.AccessibleName = "d12"
        Me.d12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d12.Location = New System.Drawing.Point(366, 355)
        Me.d12.Name = "d12"
        Me.d12.Size = New System.Drawing.Size(82, 19)
        Me.d12.TabIndex = 799
        Me.d12.Tag = "12"
        Me.d12.Text = "Disabled"
        Me.d12.Visible = False
        '
        'se12
        '
        Me.se12.AccessibleName = "SkippedSetEmpty;"
        Me.se12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se12.Location = New System.Drawing.Point(533, 355)
        Me.se12.Name = "se12"
        Me.se12.Size = New System.Drawing.Size(109, 19)
        Me.se12.TabIndex = 801
        Me.se12.Tag = "12"
        Me.se12.Text = "Set to empty"
        Me.se12.Visible = False
        '
        'es11
        '
        Me.es11.AccessibleName = "SkippedDontSave;"
        Me.es11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es11.Location = New System.Drawing.Point(640, 334)
        Me.es11.Name = "es11"
        Me.es11.Size = New System.Drawing.Size(131, 19)
        Me.es11.TabIndex = 798
        Me.es11.Tag = "11"
        Me.es11.Text = "Empted on Save "
        Me.es11.Visible = False
        '
        'nv11
        '
        Me.nv11.AccessibleName = "SkippedVisibleFalse;"
        Me.nv11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv11.Location = New System.Drawing.Point(443, 333)
        Me.nv11.Name = "nv11"
        Me.nv11.Size = New System.Drawing.Size(85, 19)
        Me.nv11.TabIndex = 796
        Me.nv11.Tag = "11"
        Me.nv11.Text = "Not visible"
        Me.nv11.Visible = False
        '
        'd11
        '
        Me.d11.AccessibleName = "d11"
        Me.d11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d11.Location = New System.Drawing.Point(366, 333)
        Me.d11.Name = "d11"
        Me.d11.Size = New System.Drawing.Size(82, 19)
        Me.d11.TabIndex = 795
        Me.d11.Tag = "11"
        Me.d11.Text = "Disabled"
        Me.d11.Visible = False
        '
        'se11
        '
        Me.se11.AccessibleName = "SkippedSetEmpty;"
        Me.se11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se11.Location = New System.Drawing.Point(533, 333)
        Me.se11.Name = "se11"
        Me.se11.Size = New System.Drawing.Size(109, 19)
        Me.se11.TabIndex = 797
        Me.se11.Tag = "11"
        Me.se11.Text = "Set to empty"
        Me.se11.Visible = False
        '
        'es10
        '
        Me.es10.AccessibleName = "SkippedDontSave;"
        Me.es10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es10.Location = New System.Drawing.Point(640, 297)
        Me.es10.Name = "es10"
        Me.es10.Size = New System.Drawing.Size(131, 19)
        Me.es10.TabIndex = 794
        Me.es10.Tag = "10"
        Me.es10.Text = "Empted on Save "
        Me.es10.Visible = False
        '
        'nv10
        '
        Me.nv10.AccessibleName = "SkippedVisibleFalse;"
        Me.nv10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv10.Location = New System.Drawing.Point(443, 297)
        Me.nv10.Name = "nv10"
        Me.nv10.Size = New System.Drawing.Size(85, 19)
        Me.nv10.TabIndex = 792
        Me.nv10.Tag = "10"
        Me.nv10.Text = "Not visible"
        Me.nv10.Visible = False
        '
        'd10
        '
        Me.d10.AccessibleName = "d10"
        Me.d10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d10.Location = New System.Drawing.Point(366, 297)
        Me.d10.Name = "d10"
        Me.d10.Size = New System.Drawing.Size(82, 19)
        Me.d10.TabIndex = 791
        Me.d10.Tag = "10"
        Me.d10.Text = "Disabled"
        Me.d10.Visible = False
        '
        'se10
        '
        Me.se10.AccessibleName = "SkippedSetEmpty;"
        Me.se10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se10.Location = New System.Drawing.Point(533, 297)
        Me.se10.Name = "se10"
        Me.se10.Size = New System.Drawing.Size(109, 19)
        Me.se10.TabIndex = 793
        Me.se10.Tag = "10"
        Me.se10.Text = "Set to empty"
        Me.se10.Visible = False
        '
        'es9
        '
        Me.es9.AccessibleName = "SkippedDontSave;"
        Me.es9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es9.Location = New System.Drawing.Point(640, 275)
        Me.es9.Name = "es9"
        Me.es9.Size = New System.Drawing.Size(131, 19)
        Me.es9.TabIndex = 790
        Me.es9.Tag = "9"
        Me.es9.Text = "Empted on Save "
        Me.es9.Visible = False
        '
        'nv9
        '
        Me.nv9.AccessibleName = "SkippedVisibleFalse;"
        Me.nv9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv9.Location = New System.Drawing.Point(443, 275)
        Me.nv9.Name = "nv9"
        Me.nv9.Size = New System.Drawing.Size(85, 19)
        Me.nv9.TabIndex = 788
        Me.nv9.Tag = "9"
        Me.nv9.Text = "Not visible"
        Me.nv9.Visible = False
        '
        'd9
        '
        Me.d9.AccessibleName = "d9"
        Me.d9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d9.Location = New System.Drawing.Point(366, 275)
        Me.d9.Name = "d9"
        Me.d9.Size = New System.Drawing.Size(82, 19)
        Me.d9.TabIndex = 787
        Me.d9.Tag = "9"
        Me.d9.Text = "Disabled"
        Me.d9.Visible = False
        '
        'se9
        '
        Me.se9.AccessibleName = "SkippedSetEmpty;"
        Me.se9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se9.Location = New System.Drawing.Point(533, 275)
        Me.se9.Name = "se9"
        Me.se9.Size = New System.Drawing.Size(109, 19)
        Me.se9.TabIndex = 789
        Me.se9.Tag = "9"
        Me.se9.Text = "Set to empty"
        Me.se9.Visible = False
        '
        'es8
        '
        Me.es8.AccessibleName = "SkippedDontSave;"
        Me.es8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es8.Location = New System.Drawing.Point(640, 253)
        Me.es8.Name = "es8"
        Me.es8.Size = New System.Drawing.Size(131, 19)
        Me.es8.TabIndex = 786
        Me.es8.Tag = "8"
        Me.es8.Text = "Empted on Save "
        Me.es8.Visible = False
        '
        'nv8
        '
        Me.nv8.AccessibleName = "nv7"
        Me.nv8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv8.Location = New System.Drawing.Point(443, 253)
        Me.nv8.Name = "nv8"
        Me.nv8.Size = New System.Drawing.Size(85, 19)
        Me.nv8.TabIndex = 784
        Me.nv8.Tag = "8"
        Me.nv8.Text = "Not visible"
        Me.nv8.Visible = False
        '
        'd8
        '
        Me.d8.AccessibleName = "d8"
        Me.d8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d8.Location = New System.Drawing.Point(366, 253)
        Me.d8.Name = "d8"
        Me.d8.Size = New System.Drawing.Size(82, 19)
        Me.d8.TabIndex = 783
        Me.d8.Tag = "8"
        Me.d8.Text = "Disabled"
        Me.d8.Visible = False
        '
        'se8
        '
        Me.se8.AccessibleName = "SkippedSetEmpty;"
        Me.se8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se8.Location = New System.Drawing.Point(533, 253)
        Me.se8.Name = "se8"
        Me.se8.Size = New System.Drawing.Size(109, 19)
        Me.se8.TabIndex = 785
        Me.se8.Tag = "8"
        Me.se8.Text = "Set to empty"
        Me.se8.Visible = False
        '
        'es7
        '
        Me.es7.AccessibleName = "SkippedDontSave;"
        Me.es7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es7.Location = New System.Drawing.Point(640, 231)
        Me.es7.Name = "es7"
        Me.es7.Size = New System.Drawing.Size(131, 19)
        Me.es7.TabIndex = 782
        Me.es7.Tag = "7"
        Me.es7.Text = "Empted on Save "
        Me.es7.Visible = False
        '
        'nv7
        '
        Me.nv7.AccessibleName = "nv7"
        Me.nv7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv7.Location = New System.Drawing.Point(443, 231)
        Me.nv7.Name = "nv7"
        Me.nv7.Size = New System.Drawing.Size(85, 19)
        Me.nv7.TabIndex = 780
        Me.nv7.Tag = "7"
        Me.nv7.Text = "Not visible"
        Me.nv7.Visible = False
        '
        'd7
        '
        Me.d7.AccessibleName = "d7"
        Me.d7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d7.Location = New System.Drawing.Point(366, 231)
        Me.d7.Name = "d7"
        Me.d7.Size = New System.Drawing.Size(82, 19)
        Me.d7.TabIndex = 779
        Me.d7.Tag = "7"
        Me.d7.Text = "Disabled"
        Me.d7.Visible = False
        '
        'se7
        '
        Me.se7.AccessibleName = "SkippedSetEmpty;"
        Me.se7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se7.Location = New System.Drawing.Point(533, 231)
        Me.se7.Name = "se7"
        Me.se7.Size = New System.Drawing.Size(109, 19)
        Me.se7.TabIndex = 781
        Me.se7.Tag = "7"
        Me.se7.Text = "Set to empty"
        Me.se7.Visible = False
        '
        'es6
        '
        Me.es6.AccessibleName = "SkippedDontSave;"
        Me.es6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es6.Location = New System.Drawing.Point(640, 209)
        Me.es6.Name = "es6"
        Me.es6.Size = New System.Drawing.Size(131, 19)
        Me.es6.TabIndex = 778
        Me.es6.Tag = "6"
        Me.es6.Text = "Empted on Save "
        Me.es6.Visible = False
        '
        'nv6
        '
        Me.nv6.AccessibleName = "nv6"
        Me.nv6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv6.Location = New System.Drawing.Point(443, 209)
        Me.nv6.Name = "nv6"
        Me.nv6.Size = New System.Drawing.Size(85, 19)
        Me.nv6.TabIndex = 776
        Me.nv6.Tag = "6"
        Me.nv6.Text = "Not visible"
        Me.nv6.Visible = False
        '
        'd6
        '
        Me.d6.AccessibleName = "d6"
        Me.d6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d6.Location = New System.Drawing.Point(366, 209)
        Me.d6.Name = "d6"
        Me.d6.Size = New System.Drawing.Size(82, 19)
        Me.d6.TabIndex = 775
        Me.d6.Tag = "6"
        Me.d6.Text = "Disabled"
        Me.d6.Visible = False
        '
        'se6
        '
        Me.se6.AccessibleName = "SkippedSetEmpty;"
        Me.se6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se6.Location = New System.Drawing.Point(533, 209)
        Me.se6.Name = "se6"
        Me.se6.Size = New System.Drawing.Size(109, 19)
        Me.se6.TabIndex = 777
        Me.se6.Tag = "6"
        Me.se6.Text = "Set to empty"
        Me.se6.Visible = False
        '
        'es5
        '
        Me.es5.AccessibleName = "SkippedDontSave;"
        Me.es5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es5.Location = New System.Drawing.Point(640, 187)
        Me.es5.Name = "es5"
        Me.es5.Size = New System.Drawing.Size(131, 19)
        Me.es5.TabIndex = 774
        Me.es5.Tag = "5"
        Me.es5.Text = "Empted on Save "
        Me.es5.Visible = False
        '
        'nv5
        '
        Me.nv5.AccessibleName = "nv5"
        Me.nv5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv5.Location = New System.Drawing.Point(443, 187)
        Me.nv5.Name = "nv5"
        Me.nv5.Size = New System.Drawing.Size(85, 19)
        Me.nv5.TabIndex = 772
        Me.nv5.Tag = "5"
        Me.nv5.Text = "Not visible"
        Me.nv5.Visible = False
        '
        'd5
        '
        Me.d5.AccessibleName = "d5"
        Me.d5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d5.Location = New System.Drawing.Point(366, 187)
        Me.d5.Name = "d5"
        Me.d5.Size = New System.Drawing.Size(82, 19)
        Me.d5.TabIndex = 771
        Me.d5.Tag = "5"
        Me.d5.Text = "Disabled"
        Me.d5.Visible = False
        '
        'se5
        '
        Me.se5.AccessibleName = "SkippedSetEmpty;"
        Me.se5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se5.Location = New System.Drawing.Point(533, 187)
        Me.se5.Name = "se5"
        Me.se5.Size = New System.Drawing.Size(109, 19)
        Me.se5.TabIndex = 773
        Me.se5.Tag = "5"
        Me.se5.Text = "Set to empty"
        Me.se5.Visible = False
        '
        'es4
        '
        Me.es4.AccessibleName = "SkippedDontSave;"
        Me.es4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es4.Location = New System.Drawing.Point(640, 165)
        Me.es4.Name = "es4"
        Me.es4.Size = New System.Drawing.Size(131, 19)
        Me.es4.TabIndex = 770
        Me.es4.Tag = "4"
        Me.es4.Text = "Empted on Save "
        Me.es4.Visible = False
        '
        'nv4
        '
        Me.nv4.AccessibleName = "nv4"
        Me.nv4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv4.Location = New System.Drawing.Point(443, 165)
        Me.nv4.Name = "nv4"
        Me.nv4.Size = New System.Drawing.Size(85, 19)
        Me.nv4.TabIndex = 768
        Me.nv4.Tag = "4"
        Me.nv4.Text = "Not visible"
        Me.nv4.Visible = False
        '
        'd4
        '
        Me.d4.AccessibleName = "d4"
        Me.d4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d4.Location = New System.Drawing.Point(366, 165)
        Me.d4.Name = "d4"
        Me.d4.Size = New System.Drawing.Size(82, 19)
        Me.d4.TabIndex = 767
        Me.d4.Tag = "4"
        Me.d4.Text = "Disabled"
        Me.d4.Visible = False
        '
        'se4
        '
        Me.se4.AccessibleName = "SkippedSetEmpty;"
        Me.se4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se4.Location = New System.Drawing.Point(533, 165)
        Me.se4.Name = "se4"
        Me.se4.Size = New System.Drawing.Size(109, 19)
        Me.se4.TabIndex = 769
        Me.se4.Tag = "4"
        Me.se4.Text = "Set to empty"
        Me.se4.Visible = False
        '
        'es3
        '
        Me.es3.AccessibleName = "SkippedDontSave;"
        Me.es3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es3.Location = New System.Drawing.Point(640, 143)
        Me.es3.Name = "es3"
        Me.es3.Size = New System.Drawing.Size(131, 19)
        Me.es3.TabIndex = 766
        Me.es3.Tag = "3"
        Me.es3.Text = "Empted on Save "
        Me.es3.Visible = False
        '
        'nv3
        '
        Me.nv3.AccessibleName = "nv3"
        Me.nv3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv3.Location = New System.Drawing.Point(443, 143)
        Me.nv3.Name = "nv3"
        Me.nv3.Size = New System.Drawing.Size(85, 19)
        Me.nv3.TabIndex = 764
        Me.nv3.Tag = "3"
        Me.nv3.Text = "Not visible"
        Me.nv3.Visible = False
        '
        'd3
        '
        Me.d3.AccessibleName = "d3"
        Me.d3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d3.Location = New System.Drawing.Point(366, 143)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(82, 19)
        Me.d3.TabIndex = 763
        Me.d3.Tag = "3"
        Me.d3.Text = "Disabled"
        Me.d3.Visible = False
        '
        'se3
        '
        Me.se3.AccessibleName = "SkippedSetEmpty;"
        Me.se3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se3.Location = New System.Drawing.Point(533, 143)
        Me.se3.Name = "se3"
        Me.se3.Size = New System.Drawing.Size(109, 19)
        Me.se3.TabIndex = 765
        Me.se3.Tag = "3"
        Me.se3.Text = "Set to empty"
        Me.se3.Visible = False
        '
        'es2
        '
        Me.es2.AccessibleName = "SkippedDontSave;"
        Me.es2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es2.Location = New System.Drawing.Point(640, 121)
        Me.es2.Name = "es2"
        Me.es2.Size = New System.Drawing.Size(131, 19)
        Me.es2.TabIndex = 762
        Me.es2.Tag = "2"
        Me.es2.Text = "Empted on Save "
        Me.es2.Visible = False
        '
        'nv2
        '
        Me.nv2.AccessibleName = "nv2"
        Me.nv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv2.Location = New System.Drawing.Point(443, 121)
        Me.nv2.Name = "nv2"
        Me.nv2.Size = New System.Drawing.Size(85, 19)
        Me.nv2.TabIndex = 760
        Me.nv2.Tag = "2"
        Me.nv2.Text = "Not visible"
        Me.nv2.Visible = False
        '
        'd2
        '
        Me.d2.AccessibleName = "d2"
        Me.d2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d2.Location = New System.Drawing.Point(366, 121)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(82, 19)
        Me.d2.TabIndex = 759
        Me.d2.Tag = "2"
        Me.d2.Text = "Disabled"
        Me.d2.Visible = False
        '
        'se2
        '
        Me.se2.AccessibleName = "SkippedSetEmpty;"
        Me.se2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se2.Location = New System.Drawing.Point(533, 121)
        Me.se2.Name = "se2"
        Me.se2.Size = New System.Drawing.Size(109, 19)
        Me.se2.TabIndex = 761
        Me.se2.Tag = "2"
        Me.se2.Text = "Set to empty"
        Me.se2.Visible = False
        '
        'txtSSEExceptWhat
        '
        Me.txtSSEExceptWhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSSEExceptWhat.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSSEExceptWhat.Location = New System.Drawing.Point(849, 289)
        Me.txtSSEExceptWhat.Name = "txtSSEExceptWhat"
        Me.txtSSEExceptWhat.Size = New System.Drawing.Size(342, 20)
        Me.txtSSEExceptWhat.TabIndex = 758
        '
        'es1
        '
        Me.es1.AccessibleName = "SkippedDontSave;"
        Me.es1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.es1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.es1.Location = New System.Drawing.Point(640, 99)
        Me.es1.Name = "es1"
        Me.es1.Size = New System.Drawing.Size(131, 19)
        Me.es1.TabIndex = 757
        Me.es1.Tag = "1"
        Me.es1.Text = "Empted on Save "
        '
        'nv1
        '
        Me.nv1.AccessibleName = "nv1"
        Me.nv1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nv1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nv1.Location = New System.Drawing.Point(443, 99)
        Me.nv1.Name = "nv1"
        Me.nv1.Size = New System.Drawing.Size(85, 19)
        Me.nv1.TabIndex = 755
        Me.nv1.Tag = "1"
        Me.nv1.Text = "Not visible"
        '
        'd1
        '
        Me.d1.AccessibleName = "d1"
        Me.d1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.d1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d1.Location = New System.Drawing.Point(366, 99)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(75, 19)
        Me.d1.TabIndex = 754
        Me.d1.Tag = "1"
        Me.d1.Text = "Disabled"
        '
        'lbl97
        '
        Me.lbl97.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl97.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl97.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl97.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl97.Location = New System.Drawing.Point(363, 28)
        Me.lbl97.Name = "lbl97"
        Me.lbl97.Size = New System.Drawing.Size(429, 50)
        Me.lbl97.TabIndex = 753
        Me.lbl97.Text = "Skipped fields will be"
        '
        'l20
        '
        Me.l20.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l20.Location = New System.Drawing.Point(6, 531)
        Me.l20.Name = "l20"
        Me.l20.Size = New System.Drawing.Size(30, 20)
        Me.l20.TabIndex = 751
        Me.l20.Tag = "20"
        Me.l20.Text = "20"
        Me.l20.Visible = False
        '
        'tbc20
        '
        Me.tbc20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc20.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc20.Location = New System.Drawing.Point(112, 531)
        Me.tbc20.Name = "tbc20"
        Me.tbc20.Size = New System.Drawing.Size(250, 20)
        Me.tbc20.TabIndex = 752
        Me.tbc20.Tag = "20"
        Me.tbc20.Visible = False
        '
        'l19
        '
        Me.l19.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l19.Location = New System.Drawing.Point(6, 509)
        Me.l19.Name = "l19"
        Me.l19.Size = New System.Drawing.Size(30, 20)
        Me.l19.TabIndex = 749
        Me.l19.Tag = "19"
        Me.l19.Text = "19"
        Me.l19.Visible = False
        '
        'tbc19
        '
        Me.tbc19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc19.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc19.Location = New System.Drawing.Point(112, 509)
        Me.tbc19.Name = "tbc19"
        Me.tbc19.Size = New System.Drawing.Size(250, 20)
        Me.tbc19.TabIndex = 750
        Me.tbc19.Tag = "19"
        Me.tbc19.Visible = False
        '
        'l18
        '
        Me.l18.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l18.Location = New System.Drawing.Point(6, 487)
        Me.l18.Name = "l18"
        Me.l18.Size = New System.Drawing.Size(30, 20)
        Me.l18.TabIndex = 747
        Me.l18.Tag = "18"
        Me.l18.Text = "18"
        Me.l18.Visible = False
        '
        'tbc18
        '
        Me.tbc18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc18.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc18.Location = New System.Drawing.Point(112, 487)
        Me.tbc18.Name = "tbc18"
        Me.tbc18.Size = New System.Drawing.Size(250, 20)
        Me.tbc18.TabIndex = 748
        Me.tbc18.Tag = "18"
        Me.tbc18.Visible = False
        '
        'l17
        '
        Me.l17.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l17.Location = New System.Drawing.Point(6, 465)
        Me.l17.Name = "l17"
        Me.l17.Size = New System.Drawing.Size(30, 20)
        Me.l17.TabIndex = 745
        Me.l17.Tag = "17"
        Me.l17.Text = "17"
        Me.l17.Visible = False
        '
        'tbc17
        '
        Me.tbc17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc17.Location = New System.Drawing.Point(112, 465)
        Me.tbc17.Name = "tbc17"
        Me.tbc17.Size = New System.Drawing.Size(250, 20)
        Me.tbc17.TabIndex = 746
        Me.tbc17.Tag = "17"
        Me.tbc17.Visible = False
        '
        'l16
        '
        Me.l16.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l16.Location = New System.Drawing.Point(6, 443)
        Me.l16.Name = "l16"
        Me.l16.Size = New System.Drawing.Size(30, 20)
        Me.l16.TabIndex = 743
        Me.l16.Tag = "16"
        Me.l16.Text = "16"
        Me.l16.Visible = False
        '
        'tbc16
        '
        Me.tbc16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc16.Location = New System.Drawing.Point(112, 443)
        Me.tbc16.Name = "tbc16"
        Me.tbc16.Size = New System.Drawing.Size(250, 20)
        Me.tbc16.TabIndex = 744
        Me.tbc16.Tag = "16"
        Me.tbc16.Visible = False
        '
        'l15
        '
        Me.l15.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l15.Location = New System.Drawing.Point(6, 421)
        Me.l15.Name = "l15"
        Me.l15.Size = New System.Drawing.Size(30, 20)
        Me.l15.TabIndex = 741
        Me.l15.Tag = "15"
        Me.l15.Text = "15"
        Me.l15.Visible = False
        '
        'tbc15
        '
        Me.tbc15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc15.Location = New System.Drawing.Point(112, 421)
        Me.tbc15.Name = "tbc15"
        Me.tbc15.Size = New System.Drawing.Size(250, 20)
        Me.tbc15.TabIndex = 742
        Me.tbc15.Tag = "15"
        Me.tbc15.Visible = False
        '
        'l14
        '
        Me.l14.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l14.Location = New System.Drawing.Point(6, 399)
        Me.l14.Name = "l14"
        Me.l14.Size = New System.Drawing.Size(30, 20)
        Me.l14.TabIndex = 739
        Me.l14.Tag = "14"
        Me.l14.Text = "14"
        Me.l14.Visible = False
        '
        'tbc14
        '
        Me.tbc14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc14.Location = New System.Drawing.Point(112, 399)
        Me.tbc14.Name = "tbc14"
        Me.tbc14.Size = New System.Drawing.Size(250, 20)
        Me.tbc14.TabIndex = 740
        Me.tbc14.Tag = "14"
        Me.tbc14.Visible = False
        '
        'l13
        '
        Me.l13.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l13.Location = New System.Drawing.Point(6, 377)
        Me.l13.Name = "l13"
        Me.l13.Size = New System.Drawing.Size(30, 20)
        Me.l13.TabIndex = 737
        Me.l13.Tag = "13"
        Me.l13.Text = "13"
        Me.l13.Visible = False
        '
        'tbc13
        '
        Me.tbc13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc13.Location = New System.Drawing.Point(112, 377)
        Me.tbc13.Name = "tbc13"
        Me.tbc13.Size = New System.Drawing.Size(250, 20)
        Me.tbc13.TabIndex = 738
        Me.tbc13.Tag = "13"
        Me.tbc13.Visible = False
        '
        'l12
        '
        Me.l12.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l12.Location = New System.Drawing.Point(6, 355)
        Me.l12.Name = "l12"
        Me.l12.Size = New System.Drawing.Size(30, 20)
        Me.l12.TabIndex = 735
        Me.l12.Tag = "12"
        Me.l12.Text = "12"
        Me.l12.Visible = False
        '
        'tbc12
        '
        Me.tbc12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc12.Location = New System.Drawing.Point(112, 355)
        Me.tbc12.Name = "tbc12"
        Me.tbc12.Size = New System.Drawing.Size(250, 20)
        Me.tbc12.TabIndex = 736
        Me.tbc12.Tag = "12"
        Me.tbc12.Visible = False
        '
        'l11
        '
        Me.l11.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l11.Location = New System.Drawing.Point(6, 333)
        Me.l11.Name = "l11"
        Me.l11.Size = New System.Drawing.Size(30, 20)
        Me.l11.TabIndex = 733
        Me.l11.Tag = "11"
        Me.l11.Text = "11"
        Me.l11.Visible = False
        '
        'tbc11
        '
        Me.tbc11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc11.Location = New System.Drawing.Point(112, 333)
        Me.tbc11.Name = "tbc11"
        Me.tbc11.Size = New System.Drawing.Size(250, 20)
        Me.tbc11.TabIndex = 734
        Me.tbc11.Tag = "11"
        Me.tbc11.Visible = False
        '
        'l10
        '
        Me.l10.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l10.Location = New System.Drawing.Point(6, 303)
        Me.l10.Name = "l10"
        Me.l10.Size = New System.Drawing.Size(30, 20)
        Me.l10.TabIndex = 731
        Me.l10.Tag = "10"
        Me.l10.Text = "10"
        Me.l10.Visible = False
        '
        'tbc10
        '
        Me.tbc10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc10.Location = New System.Drawing.Point(112, 297)
        Me.tbc10.Name = "tbc10"
        Me.tbc10.Size = New System.Drawing.Size(250, 20)
        Me.tbc10.TabIndex = 732
        Me.tbc10.Tag = "10"
        Me.tbc10.Visible = False
        '
        'l9
        '
        Me.l9.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l9.Location = New System.Drawing.Point(6, 281)
        Me.l9.Name = "l9"
        Me.l9.Size = New System.Drawing.Size(30, 20)
        Me.l9.TabIndex = 729
        Me.l9.Tag = "9"
        Me.l9.Text = "9"
        Me.l9.Visible = False
        '
        'tbc9
        '
        Me.tbc9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc9.Location = New System.Drawing.Point(112, 275)
        Me.tbc9.Name = "tbc9"
        Me.tbc9.Size = New System.Drawing.Size(250, 20)
        Me.tbc9.TabIndex = 730
        Me.tbc9.Tag = "9"
        Me.tbc9.Visible = False
        '
        'l8
        '
        Me.l8.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l8.Location = New System.Drawing.Point(6, 257)
        Me.l8.Name = "l8"
        Me.l8.Size = New System.Drawing.Size(30, 20)
        Me.l8.TabIndex = 727
        Me.l8.Tag = "8"
        Me.l8.Text = "8"
        Me.l8.Visible = False
        '
        'tbc8
        '
        Me.tbc8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc8.Location = New System.Drawing.Point(112, 253)
        Me.tbc8.Name = "tbc8"
        Me.tbc8.Size = New System.Drawing.Size(250, 20)
        Me.tbc8.TabIndex = 728
        Me.tbc8.Tag = "8"
        Me.tbc8.Visible = False
        '
        'l7
        '
        Me.l7.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l7.Location = New System.Drawing.Point(6, 234)
        Me.l7.Name = "l7"
        Me.l7.Size = New System.Drawing.Size(30, 20)
        Me.l7.TabIndex = 725
        Me.l7.Tag = "7"
        Me.l7.Text = "7"
        Me.l7.Visible = False
        '
        'tbc7
        '
        Me.tbc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc7.Location = New System.Drawing.Point(112, 231)
        Me.tbc7.Name = "tbc7"
        Me.tbc7.Size = New System.Drawing.Size(250, 20)
        Me.tbc7.TabIndex = 726
        Me.tbc7.Tag = "7"
        Me.tbc7.Visible = False
        '
        'l6
        '
        Me.l6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l6.Location = New System.Drawing.Point(6, 212)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(30, 20)
        Me.l6.TabIndex = 723
        Me.l6.Tag = "6"
        Me.l6.Text = "6"
        Me.l6.Visible = False
        '
        'tbc6
        '
        Me.tbc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc6.Location = New System.Drawing.Point(112, 209)
        Me.tbc6.Name = "tbc6"
        Me.tbc6.Size = New System.Drawing.Size(250, 20)
        Me.tbc6.TabIndex = 724
        Me.tbc6.Tag = "6"
        Me.tbc6.Visible = False
        '
        'l5
        '
        Me.l5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l5.Location = New System.Drawing.Point(6, 190)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(30, 20)
        Me.l5.TabIndex = 721
        Me.l5.Tag = "5"
        Me.l5.Text = "5"
        Me.l5.Visible = False
        '
        'tbc5
        '
        Me.tbc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc5.Location = New System.Drawing.Point(112, 187)
        Me.tbc5.Name = "tbc5"
        Me.tbc5.Size = New System.Drawing.Size(250, 20)
        Me.tbc5.TabIndex = 722
        Me.tbc5.Tag = "5"
        Me.tbc5.Visible = False
        '
        'l4
        '
        Me.l4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l4.Location = New System.Drawing.Point(6, 168)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(30, 20)
        Me.l4.TabIndex = 719
        Me.l4.Tag = "4"
        Me.l4.Text = "4"
        Me.l4.Visible = False
        '
        'tbc4
        '
        Me.tbc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc4.Location = New System.Drawing.Point(112, 165)
        Me.tbc4.Name = "tbc4"
        Me.tbc4.Size = New System.Drawing.Size(250, 20)
        Me.tbc4.TabIndex = 720
        Me.tbc4.Tag = "4"
        Me.tbc4.Visible = False
        '
        'l3
        '
        Me.l3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.Location = New System.Drawing.Point(6, 144)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(30, 20)
        Me.l3.TabIndex = 717
        Me.l3.Tag = "3"
        Me.l3.Text = "3"
        Me.l3.Visible = False
        '
        'tbc3
        '
        Me.tbc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc3.Location = New System.Drawing.Point(112, 143)
        Me.tbc3.Name = "tbc3"
        Me.tbc3.Size = New System.Drawing.Size(250, 20)
        Me.tbc3.TabIndex = 718
        Me.tbc3.Tag = "3"
        Me.tbc3.Visible = False
        '
        'l2
        '
        Me.l2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.Location = New System.Drawing.Point(6, 121)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(30, 20)
        Me.l2.TabIndex = 715
        Me.l2.Tag = "2"
        Me.l2.Text = "2"
        Me.l2.Visible = False
        '
        'tbc2
        '
        Me.tbc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc2.Location = New System.Drawing.Point(112, 121)
        Me.tbc2.Name = "tbc2"
        Me.tbc2.Size = New System.Drawing.Size(250, 20)
        Me.tbc2.TabIndex = 716
        Me.tbc2.Tag = "2"
        Me.tbc2.Visible = False
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.l1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.Location = New System.Drawing.Point(6, 99)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(30, 20)
        Me.l1.TabIndex = 713
        Me.l1.Tag = "1"
        Me.l1.Text = "1"
        '
        'lbl93
        '
        Me.lbl93.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl93.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl93.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl93.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl93.Location = New System.Drawing.Point(6, 28)
        Me.lbl93.Name = "lbl93"
        Me.lbl93.Size = New System.Drawing.Size(34, 50)
        Me.lbl93.TabIndex = 712
        Me.lbl93.Text = "No"
        '
        'tbc1
        '
        Me.tbc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbc1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbc1.Location = New System.Drawing.Point(112, 99)
        Me.tbc1.Name = "tbc1"
        Me.tbc1.Size = New System.Drawing.Size(250, 20)
        Me.tbc1.TabIndex = 714
        Me.tbc1.Tag = "1"
        '
        'lbl98
        '
        Me.lbl98.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl98.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl98.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl98.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl98.Location = New System.Drawing.Point(112, 28)
        Me.lbl98.Name = "lbl98"
        Me.lbl98.Size = New System.Drawing.Size(250, 50)
        Me.lbl98.TabIndex = 711
        Me.lbl98.Text = "Skip If"
        '
        'lbl99
        '
        Me.lbl99.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl99.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl99.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl99.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl99.Location = New System.Drawing.Point(41, 28)
        Me.lbl99.Name = "lbl99"
        Me.lbl99.Size = New System.Drawing.Size(70, 50)
        Me.lbl99.TabIndex = 710
        Me.lbl99.Text = "Skip To"
        '
        'cbSEFAll
        '
        Me.cbSEFAll.AccessibleName = "SkippedEnabledFalse;"
        Me.cbSEFAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSEFAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSEFAll.Location = New System.Drawing.Point(849, 98)
        Me.cbSEFAll.Name = "cbSEFAll"
        Me.cbSEFAll.Size = New System.Drawing.Size(264, 19)
        Me.cbSEFAll.TabIndex = 706
        Me.cbSEFAll.Text = "Skipped Enabled False"
        '
        'cbSSEAll
        '
        Me.cbSSEAll.AccessibleName = "SkippedSetEmpty;"
        Me.cbSSEAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSSEAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSSEAll.Location = New System.Drawing.Point(849, 167)
        Me.cbSSEAll.Name = "cbSSEAll"
        Me.cbSSEAll.Size = New System.Drawing.Size(264, 19)
        Me.cbSSEAll.TabIndex = 707
        Me.cbSSEAll.Text = "Skipped Set Empty"
        '
        'cbSDSAll
        '
        Me.cbSDSAll.AccessibleName = "SkippedDontSave;"
        Me.cbSDSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSDSAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSDSAll.Location = New System.Drawing.Point(849, 144)
        Me.cbSDSAll.Name = "cbSDSAll"
        Me.cbSDSAll.Size = New System.Drawing.Size(264, 19)
        Me.cbSDSAll.TabIndex = 708
        Me.cbSDSAll.Text = "Skipped Dont Save"
        '
        'cbSVFAll
        '
        Me.cbSVFAll.AccessibleName = "SkippedVisibleFalse;"
        Me.cbSVFAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSVFAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSVFAll.Location = New System.Drawing.Point(849, 121)
        Me.cbSVFAll.Name = "cbSVFAll"
        Me.cbSVFAll.Size = New System.Drawing.Size(264, 19)
        Me.cbSVFAll.TabIndex = 709
        Me.cbSVFAll.Text = "Skipped Visible False"
        '
        'se1
        '
        Me.se1.AccessibleName = "SkippedSetEmpty;"
        Me.se1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.se1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.se1.Location = New System.Drawing.Point(533, 99)
        Me.se1.Name = "se1"
        Me.se1.Size = New System.Drawing.Size(109, 19)
        Me.se1.TabIndex = 756
        Me.se1.Tag = "1"
        Me.se1.Text = "Set to empty"
        '
        'mFormExitEventSkip
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1230, 601)
        Me.Controls.Add(Me.p19)
        Me.Controls.Add(Me.p18)
        Me.Controls.Add(Me.p17)
        Me.Controls.Add(Me.p16)
        Me.Controls.Add(Me.p15)
        Me.Controls.Add(Me.p14)
        Me.Controls.Add(Me.p13)
        Me.Controls.Add(Me.p12)
        Me.Controls.Add(Me.p11)
        Me.Controls.Add(Me.lbl96)
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
        Me.Controls.Add(Me.lbl94)
        Me.Controls.Add(Me.lbl95)
        Me.Controls.Add(Me.txtSSEExceptIf)
        Me.Controls.Add(Me.cbSSEExcept)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.cbc10)
        Me.Controls.Add(Me.cbc9)
        Me.Controls.Add(Me.cbc8)
        Me.Controls.Add(Me.cbc7)
        Me.Controls.Add(Me.cbc6)
        Me.Controls.Add(Me.cbc5)
        Me.Controls.Add(Me.cbc4)
        Me.Controls.Add(Me.cbc3)
        Me.Controls.Add(Me.cbc2)
        Me.Controls.Add(Me.cbc1)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.es20)
        Me.Controls.Add(Me.nv20)
        Me.Controls.Add(Me.d20)
        Me.Controls.Add(Me.se20)
        Me.Controls.Add(Me.es19)
        Me.Controls.Add(Me.nv19)
        Me.Controls.Add(Me.d19)
        Me.Controls.Add(Me.se19)
        Me.Controls.Add(Me.es18)
        Me.Controls.Add(Me.nv18)
        Me.Controls.Add(Me.d18)
        Me.Controls.Add(Me.se18)
        Me.Controls.Add(Me.es17)
        Me.Controls.Add(Me.nv17)
        Me.Controls.Add(Me.d17)
        Me.Controls.Add(Me.se17)
        Me.Controls.Add(Me.es16)
        Me.Controls.Add(Me.nv16)
        Me.Controls.Add(Me.d16)
        Me.Controls.Add(Me.se16)
        Me.Controls.Add(Me.es15)
        Me.Controls.Add(Me.nv15)
        Me.Controls.Add(Me.d15)
        Me.Controls.Add(Me.se15)
        Me.Controls.Add(Me.es14)
        Me.Controls.Add(Me.nv14)
        Me.Controls.Add(Me.d14)
        Me.Controls.Add(Me.se14)
        Me.Controls.Add(Me.es13)
        Me.Controls.Add(Me.nv13)
        Me.Controls.Add(Me.d13)
        Me.Controls.Add(Me.se13)
        Me.Controls.Add(Me.es12)
        Me.Controls.Add(Me.nv12)
        Me.Controls.Add(Me.d12)
        Me.Controls.Add(Me.se12)
        Me.Controls.Add(Me.es11)
        Me.Controls.Add(Me.nv11)
        Me.Controls.Add(Me.d11)
        Me.Controls.Add(Me.se11)
        Me.Controls.Add(Me.es10)
        Me.Controls.Add(Me.nv10)
        Me.Controls.Add(Me.d10)
        Me.Controls.Add(Me.se10)
        Me.Controls.Add(Me.es9)
        Me.Controls.Add(Me.nv9)
        Me.Controls.Add(Me.d9)
        Me.Controls.Add(Me.se9)
        Me.Controls.Add(Me.es8)
        Me.Controls.Add(Me.nv8)
        Me.Controls.Add(Me.d8)
        Me.Controls.Add(Me.se8)
        Me.Controls.Add(Me.es7)
        Me.Controls.Add(Me.nv7)
        Me.Controls.Add(Me.d7)
        Me.Controls.Add(Me.se7)
        Me.Controls.Add(Me.es6)
        Me.Controls.Add(Me.nv6)
        Me.Controls.Add(Me.d6)
        Me.Controls.Add(Me.se6)
        Me.Controls.Add(Me.es5)
        Me.Controls.Add(Me.nv5)
        Me.Controls.Add(Me.d5)
        Me.Controls.Add(Me.se5)
        Me.Controls.Add(Me.es4)
        Me.Controls.Add(Me.nv4)
        Me.Controls.Add(Me.d4)
        Me.Controls.Add(Me.se4)
        Me.Controls.Add(Me.es3)
        Me.Controls.Add(Me.nv3)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.se3)
        Me.Controls.Add(Me.es2)
        Me.Controls.Add(Me.nv2)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.se2)
        Me.Controls.Add(Me.txtSSEExceptWhat)
        Me.Controls.Add(Me.es1)
        Me.Controls.Add(Me.nv1)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.lbl97)
        Me.Controls.Add(Me.l20)
        Me.Controls.Add(Me.tbc20)
        Me.Controls.Add(Me.l19)
        Me.Controls.Add(Me.tbc19)
        Me.Controls.Add(Me.l18)
        Me.Controls.Add(Me.tbc18)
        Me.Controls.Add(Me.l17)
        Me.Controls.Add(Me.tbc17)
        Me.Controls.Add(Me.l16)
        Me.Controls.Add(Me.tbc16)
        Me.Controls.Add(Me.l15)
        Me.Controls.Add(Me.tbc15)
        Me.Controls.Add(Me.l14)
        Me.Controls.Add(Me.tbc14)
        Me.Controls.Add(Me.l13)
        Me.Controls.Add(Me.tbc13)
        Me.Controls.Add(Me.l12)
        Me.Controls.Add(Me.tbc12)
        Me.Controls.Add(Me.l11)
        Me.Controls.Add(Me.tbc11)
        Me.Controls.Add(Me.l10)
        Me.Controls.Add(Me.tbc10)
        Me.Controls.Add(Me.l9)
        Me.Controls.Add(Me.tbc9)
        Me.Controls.Add(Me.l8)
        Me.Controls.Add(Me.tbc8)
        Me.Controls.Add(Me.l7)
        Me.Controls.Add(Me.tbc7)
        Me.Controls.Add(Me.l6)
        Me.Controls.Add(Me.tbc6)
        Me.Controls.Add(Me.l5)
        Me.Controls.Add(Me.tbc5)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.tbc4)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.tbc3)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.tbc2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.lbl93)
        Me.Controls.Add(Me.tbc1)
        Me.Controls.Add(Me.lbl98)
        Me.Controls.Add(Me.lbl99)
        Me.Controls.Add(Me.cbSEFAll)
        Me.Controls.Add(Me.cbSSEAll)
        Me.Controls.Add(Me.cbSDSAll)
        Me.Controls.Add(Me.cbSVFAll)
        Me.Controls.Add(Me.se1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormExitEventSkip"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "On Exit event"
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
        Me.Label1.Text = "Skip on field " + pp(2).Trim + "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim

        'pp(2) + nvrd + "Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim)
    End Sub

    Dim validatingEvent As String = ""
    Dim validatingEventOst As String = ""

    Function getDTC() As System.Data.DataTable
        validatingEvent = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select od " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "' and pp<>'fp' and pp<>'lbl' and pp<>'dgv' and pp<>'button'   " +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        '" (od like '%skip%' or od like '%skoci%' )" +
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

        Dim skipif() As String = {}
        Dim skipto() As String = {}
        Dim skipaction() As String = {}
        Dim skipsetemptyexceptif As String = ""
        Dim skipsetemptyexceptwhat As String = ""
        For i As Integer = 0 To pp.GetUpperBound(0)

            If pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPIF") >= 0 OrElse pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("SKOCIAKO") >= 0 Then
                skipif = pp(i).Trim.ToUpper.Replace("SKIPIF=", "").Replace("SKOCIAKO=", "").Split("$")
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPTO") >= 0 OrElse pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("SKOCINA") >= 0 Then
                skipto = pp(i).Trim.ToUpper.Replace("SKIPTO=", "").Replace("SKOCINA=", "").Split("$")
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPACTION") >= 0 Then
                skipaction = pp(i).Trim.ToUpper.Replace("SKIPACTION=", "").Split("$")

            ElseIf pp(i).Length > 18 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDENABLEDFALSE") = 0 Then
                cbSEFAll.Checked = True

            ElseIf pp(i).Length > 14 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDSETEMPTY") = 0 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDSETEMPTYEXCEPT") < 0 Then
                cbSSEAll.Checked = True

            ElseIf pp(i).Length > 18 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDVISIBLEFALSE") = 0 Then
                cbSVFAll.Checked = True

            ElseIf pp(i).Length > 14 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDDONTSAVE") = 0 Then
                cbSDSAll.Checked = True

            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDSETEMPTYEXCEPT") >= 0 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDSETEMPTYEXCEPTIF") < 0 Then
                skipsetemptyexceptwhat = pp(i).Trim.ToUpper.Replace("SKIPPEDSETEMPTYEXCEPT=", "")
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("SKIPPEDSETEMPTYEXCEPTIF") >= 0 Then
                skipsetemptyexceptif = pp(i).Trim.ToUpper.Replace("SKIPPEDSETEMPTYEXCEPTIF=", "")
            ElseIf pp(i).Trim <> "" Then
                validatingEventOst = validatingEventOst + pp(i) + ";"
            End If
        Next

        For i As Integer = 0 To skipto.GetUpperBound(0)
            For Each k As Control In Me.Controls
                If Not k.Tag Is Nothing AndAlso k.Tag <> "" AndAlso k.Tag = CStr(i + 1).Trim Then
                    k.Visible = True
                End If
            Next
        Next

        For i As Integer = 0 To skipto.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "cbc" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = skipto(i).Trim
        Next

        For i As Integer = 0 To skipif.GetUpperBound(0)
            Dim tb As Control = NadjiKontrolu(Me, "tbc" + CStr(i + 1).Trim)
            If Not tb Is Nothing Then DirectCast(tb, TextBox).Text = skipif(i).Trim
        Next

        For i As Integer = 0 To skipaction.GetUpperBound(0)
            Dim tt() As String = skipaction(i).Split(",")
            For k As Integer = 0 To tt.GetUpperBound(0)
                If tt(k).Trim.ToUpper = "ENABLEDFALSE" Then
                    Dim chb As Control = NadjiKontrolu(Me, "d" + CStr(i + 1).Trim)
                    If Not chb Is Nothing Then DirectCast(chb, CheckBox).Checked = True Else DirectCast(chb, CheckBox).Checked = False
                End If
                If tt(k).Trim.ToUpper = "SETEMPTY" Then
                    Dim chb As Control = NadjiKontrolu(Me, "se" + CStr(i + 1).Trim)
                    If Not chb Is Nothing Then DirectCast(chb, CheckBox).Checked = True Else DirectCast(chb, CheckBox).Checked = False
                End If
                If tt(k).Trim.ToUpper = "VISIBLEFALSE" Then
                    Dim chb As Control = NadjiKontrolu(Me, "nv" + CStr(i + 1).Trim)
                    If Not chb Is Nothing Then DirectCast(chb, CheckBox).Checked = True Else DirectCast(chb, CheckBox).Checked = False
                End If
                If tt(k).Trim.ToUpper = "DONTSAVE" Then
                    Dim chb As Control = NadjiKontrolu(Me, "es" + CStr(i + 1).Trim)
                    If Not chb Is Nothing Then DirectCast(chb, CheckBox).Checked = True Else DirectCast(chb, CheckBox).Checked = False
                End If
            Next
        Next

        If skipsetemptyexceptwhat.Trim <> "" Then
            cbSSEExcept.Checked = True
            txtSSEExceptWhat.Text = skipsetemptyexceptwhat
        End If
        If skipsetemptyexceptif.Trim <> "" Then
            cbSSEExcept.Checked = True
            txtSSEExceptIf.Text = skipsetemptyexceptif
        End If
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        'skipto
        Dim skip As String = ""

        Dim br As Integer = 0
        Dim skipto As String = ""
        For k As Integer = 1 To 20
            Dim tb As Control = NadjiKontrolu(Me, "cbc" + CStr(k).Trim)
            If Not tb Is Nothing AndAlso DirectCast(tb, TextBox).Text <> "" Then
                skipto = skipto + tb.Text + "$"
                br = br + 1
            End If
        Next
        If skipto <> "" Then
            skipto = "SkipTo=" + skipto.TrimEnd("$") + ";"
            skip = skip + skipto
        End If

        'skipif
        Dim skipif As String = ""
        For k As Integer = 1 To br
            Dim tb As Control = NadjiKontrolu(Me, "tbc" + CStr(k).Trim)
            If DirectCast(tb, TextBox).Text <> "" Then skipif = skipif + tb.Text + "$"
        Next
        If skipif <> "" Then
            skipif = "SkipIf=" + skipif.TrimEnd("$") + ";"
            skipif = skipif.Replace("'", "''")
            skip = skip + skipif
        End If

        'skipaction
        Dim skipaction As String = ""
        For k As Integer = 1 To br
            Dim chb1 As Control = NadjiKontrolu(Me, "d" + CStr(k).Trim)
            If DirectCast(chb1, CheckBox).Checked = True Then skipaction = skipaction + "EnabledFalse" + ","
            Dim chb2 As Control = NadjiKontrolu(Me, "se" + CStr(k).Trim)
            If DirectCast(chb2, CheckBox).Checked = True Then skipaction = skipaction + "SetEmpty" + ","
            Dim chb3 As Control = NadjiKontrolu(Me, "nv" + CStr(k).Trim)
            If DirectCast(chb3, CheckBox).Checked = True Then skipaction = skipaction + "VisibleFalse" + ","
            Dim chb4 As Control = NadjiKontrolu(Me, "es" + CStr(k).Trim)
            If DirectCast(chb4, CheckBox).Checked = True Then skipaction = skipaction + "DontSave" + ","
            skipaction = skipaction.TrimEnd(",") + "$"
        Next

        If skipaction <> "" AndAlso skipaction.TrimEnd("$") <> "" Then
            If skipaction.Substring(Len(skipaction) - 1, 1) = "$" Then
                skipaction = skipaction.Substring(0, Len(skipaction) - 1)
            End If
            skip = skip + "SkipAction=" + skipaction + ";"
        End If

        'sef
        'sds
        'svf
        'sse
        If br > 0 Then
            If cbSEFAll.Checked = True Then skip = skip + "SKIPPEDENABLEDFALSE;"
            If cbSSEAll.Checked = True Then skip = skip + "SKIPPEDSETEMPTY;"
            If cbSVFAll.Checked = True Then skip = skip + "SKIPPEDVISIBLEFALSE;"
            If cbSDSAll.Checked = True Then skip = skip + "SKIPPEDDONTSAVE;"

            'ssee
            If cbSSEExcept.Checked = True Then
                If txtSSEExceptIf.Text.Trim <> "" Then skip = skip + "SKIPPEDSETEMPTYIF=" + txtSSEExceptIf.Text.Trim + ";"
                If txtSSEExceptWhat.Text.Trim <> "" Then skip = skip + "SKIPPEDSETEMPTY=" + txtSSEExceptWhat.Text.Trim + ";"
            End If
        End If

        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim

        Dim sql As String = "update istpolja set od=N'#{" + validatingEventOst + ";" + skip + "}'" +
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
                If TypeOf k Is CheckBox Then DirectCast(k, CheckBox).Checked = False
            End If
        Next

    End Sub

End Class