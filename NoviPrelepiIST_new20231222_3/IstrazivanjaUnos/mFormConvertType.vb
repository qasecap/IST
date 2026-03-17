'Option Strict Off

Public Class mFormConvertType
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
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cen1 As CheckBox
    Friend WithEvents cen2 As CheckBox
    Friend WithEvents cen3 As CheckBox
    Friend WithEvents cen4 As CheckBox
    Friend WithEvents cen5 As CheckBox
    Friend WithEvents cen6 As CheckBox
    Friend WithEvents cen7 As CheckBox
    Friend WithEvents cen8 As CheckBox
    Friend WithEvents cen9 As CheckBox
    Friend WithEvents can10 As CheckBox
    Friend WithEvents can11 As CheckBox
    Friend WithEvents ccs12 As CheckBox
    Friend WithEvents ccs13 As CheckBox
    Friend WithEvents ccs14 As CheckBox
    Friend WithEvents ccs15 As CheckBox
    Friend WithEvents ccs16 As CheckBox
    Friend WithEvents ccs17 As CheckBox
    Friend WithEvents cdt18 As CheckBox
    Friend WithEvents cdt19 As CheckBox
    Friend WithEvents cdt20 As CheckBox
    Friend WithEvents cdt21 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbNOTNULL As CheckBox
    Friend WithEvents txtDuz As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtp1 As TextBox
    Friend WithEvents txtp2 As TextBox
    Friend WithEvents txtTip As TextBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDuzOstalo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cen1 = New System.Windows.Forms.CheckBox()
        Me.cen2 = New System.Windows.Forms.CheckBox()
        Me.cen3 = New System.Windows.Forms.CheckBox()
        Me.cen4 = New System.Windows.Forms.CheckBox()
        Me.cen5 = New System.Windows.Forms.CheckBox()
        Me.cen6 = New System.Windows.Forms.CheckBox()
        Me.cen7 = New System.Windows.Forms.CheckBox()
        Me.cen8 = New System.Windows.Forms.CheckBox()
        Me.cen9 = New System.Windows.Forms.CheckBox()
        Me.can10 = New System.Windows.Forms.CheckBox()
        Me.can11 = New System.Windows.Forms.CheckBox()
        Me.ccs12 = New System.Windows.Forms.CheckBox()
        Me.ccs13 = New System.Windows.Forms.CheckBox()
        Me.ccs14 = New System.Windows.Forms.CheckBox()
        Me.ccs15 = New System.Windows.Forms.CheckBox()
        Me.ccs16 = New System.Windows.Forms.CheckBox()
        Me.ccs17 = New System.Windows.Forms.CheckBox()
        Me.cdt18 = New System.Windows.Forms.CheckBox()
        Me.cdt19 = New System.Windows.Forms.CheckBox()
        Me.cdt20 = New System.Windows.Forms.CheckBox()
        Me.cdt21 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbNOTNULL = New System.Windows.Forms.CheckBox()
        Me.txtDuz = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtp1 = New System.Windows.Forms.TextBox()
        Me.txtp2 = New System.Windows.Forms.TextBox()
        Me.txtTip = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDuzOstalo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(405, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(84, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.Text = "Convert"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Convert type in DB and IST"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(509, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cb4)
        Me.gbOptions.Controls.Add(Me.cb3)
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Location = New System.Drawing.Point(3, 31)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(185, 112)
        Me.gbOptions.TabIndex = 40
        Me.gbOptions.TabStop = False
        '
        'cb4
        '
        Me.cb4.AccessibleDescription = " "
        Me.cb4.AutoSize = True
        Me.cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb4.Location = New System.Drawing.Point(12, 86)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(53, 17)
        Me.cb4.TabIndex = 3
        Me.cb4.Text = "Table"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AccessibleDescription = " "
        Me.cb3.AutoSize = True
        Me.cb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb3.Location = New System.Drawing.Point(12, 63)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(67, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "Column"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AccessibleDescription = " "
        Me.cb2.AutoSize = True
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb2.Location = New System.Drawing.Point(12, 40)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(47, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Row"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb1.Location = New System.Drawing.Point(12, 17)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(74, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Cell/field"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(218, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Exact numerics"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Approximate numerics"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Date and time"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(218, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Character strings."
        '
        'cen1
        '
        Me.cen1.AutoSize = True
        Me.cen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen1.Location = New System.Drawing.Point(224, 178)
        Me.cen1.Name = "cen1"
        Me.cen1.Size = New System.Drawing.Size(54, 17)
        Me.cen1.TabIndex = 56
        Me.cen1.Tag = "bigint"
        Me.cen1.Text = "bigint"
        Me.cen1.UseVisualStyleBackColor = True
        '
        'cen2
        '
        Me.cen2.AutoSize = True
        Me.cen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen2.Location = New System.Drawing.Point(224, 195)
        Me.cen2.Name = "cen2"
        Me.cen2.Size = New System.Drawing.Size(37, 17)
        Me.cen2.TabIndex = 57
        Me.cen2.Tag = "bit"
        Me.cen2.Text = "bit"
        Me.cen2.UseVisualStyleBackColor = True
        '
        'cen3
        '
        Me.cen3.AutoSize = True
        Me.cen3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen3.Location = New System.Drawing.Point(224, 212)
        Me.cen3.Name = "cen3"
        Me.cen3.Size = New System.Drawing.Size(67, 17)
        Me.cen3.TabIndex = 58
        Me.cen3.Tag = "decimal"
        Me.cen3.Text = "decimal"
        Me.cen3.UseVisualStyleBackColor = True
        '
        'cen4
        '
        Me.cen4.AutoSize = True
        Me.cen4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen4.Location = New System.Drawing.Point(224, 229)
        Me.cen4.Name = "cen4"
        Me.cen4.Size = New System.Drawing.Size(37, 17)
        Me.cen4.TabIndex = 59
        Me.cen4.Tag = "int"
        Me.cen4.Text = "int"
        Me.cen4.UseVisualStyleBackColor = True
        '
        'cen5
        '
        Me.cen5.AutoSize = True
        Me.cen5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen5.Location = New System.Drawing.Point(224, 246)
        Me.cen5.Name = "cen5"
        Me.cen5.Size = New System.Drawing.Size(62, 17)
        Me.cen5.TabIndex = 60
        Me.cen5.Tag = "money"
        Me.cen5.Text = "money"
        Me.cen5.UseVisualStyleBackColor = True
        '
        'cen6
        '
        Me.cen6.AutoSize = True
        Me.cen6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen6.Location = New System.Drawing.Point(224, 263)
        Me.cen6.Name = "cen6"
        Me.cen6.Size = New System.Drawing.Size(69, 17)
        Me.cen6.TabIndex = 61
        Me.cen6.Tag = "numeric"
        Me.cen6.Text = "numeric"
        Me.cen6.UseVisualStyleBackColor = True
        '
        'cen7
        '
        Me.cen7.AutoSize = True
        Me.cen7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen7.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen7.Location = New System.Drawing.Point(224, 280)
        Me.cen7.Name = "cen7"
        Me.cen7.Size = New System.Drawing.Size(67, 17)
        Me.cen7.TabIndex = 62
        Me.cen7.Tag = "smallint"
        Me.cen7.Text = "smallint"
        Me.cen7.UseVisualStyleBackColor = True
        '
        'cen8
        '
        Me.cen8.AutoSize = True
        Me.cen8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen8.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen8.Location = New System.Drawing.Point(224, 297)
        Me.cen8.Name = "cen8"
        Me.cen8.Size = New System.Drawing.Size(92, 17)
        Me.cen8.TabIndex = 63
        Me.cen8.Tag = "smallmoney"
        Me.cen8.Text = "smallmoney"
        Me.cen8.UseVisualStyleBackColor = True
        '
        'cen9
        '
        Me.cen9.AutoSize = True
        Me.cen9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen9.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen9.Location = New System.Drawing.Point(224, 314)
        Me.cen9.Name = "cen9"
        Me.cen9.Size = New System.Drawing.Size(58, 17)
        Me.cen9.TabIndex = 64
        Me.cen9.Tag = "tinyint"
        Me.cen9.Text = "tinyint"
        Me.cen9.UseVisualStyleBackColor = True
        '
        'can10
        '
        Me.can10.AutoSize = True
        Me.can10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.can10.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.can10.Location = New System.Drawing.Point(15, 182)
        Me.can10.Name = "can10"
        Me.can10.Size = New System.Drawing.Size(45, 17)
        Me.can10.TabIndex = 66
        Me.can10.Tag = "real"
        Me.can10.Text = "real"
        Me.can10.UseVisualStyleBackColor = True
        '
        'can11
        '
        Me.can11.AutoSize = True
        Me.can11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.can11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.can11.Location = New System.Drawing.Point(15, 165)
        Me.can11.Name = "can11"
        Me.can11.Size = New System.Drawing.Size(48, 17)
        Me.can11.TabIndex = 65
        Me.can11.Tag = "float"
        Me.can11.Text = "float"
        Me.can11.UseVisualStyleBackColor = True
        '
        'ccs12
        '
        Me.ccs12.AutoSize = True
        Me.ccs12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs12.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs12.Location = New System.Drawing.Point(221, 92)
        Me.ccs12.Name = "ccs12"
        Me.ccs12.Size = New System.Drawing.Size(52, 17)
        Me.ccs12.TabIndex = 69
        Me.ccs12.Tag = "ntext"
        Me.ccs12.Text = "ntext"
        Me.ccs12.UseVisualStyleBackColor = True
        '
        'ccs13
        '
        Me.ccs13.AutoSize = True
        Me.ccs13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs13.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs13.Location = New System.Drawing.Point(221, 75)
        Me.ccs13.Name = "ccs13"
        Me.ccs13.Size = New System.Drawing.Size(74, 17)
        Me.ccs13.TabIndex = 68
        Me.ccs13.Tag = "nvarchar"
        Me.ccs13.Text = "nvarchar"
        Me.ccs13.UseVisualStyleBackColor = True
        '
        'ccs14
        '
        Me.ccs14.AutoSize = True
        Me.ccs14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs14.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs14.Location = New System.Drawing.Point(221, 58)
        Me.ccs14.Name = "ccs14"
        Me.ccs14.Size = New System.Drawing.Size(55, 17)
        Me.ccs14.TabIndex = 67
        Me.ccs14.Tag = "nchar"
        Me.ccs14.Text = "nchar"
        Me.ccs14.UseVisualStyleBackColor = True
        '
        'ccs15
        '
        Me.ccs15.AutoSize = True
        Me.ccs15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs15.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs15.Location = New System.Drawing.Point(300, 92)
        Me.ccs15.Name = "ccs15"
        Me.ccs15.Size = New System.Drawing.Size(45, 17)
        Me.ccs15.TabIndex = 72
        Me.ccs15.Tag = "text"
        Me.ccs15.Text = "text"
        Me.ccs15.UseVisualStyleBackColor = True
        '
        'ccs16
        '
        Me.ccs16.AutoSize = True
        Me.ccs16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs16.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs16.Location = New System.Drawing.Point(300, 75)
        Me.ccs16.Name = "ccs16"
        Me.ccs16.Size = New System.Drawing.Size(67, 17)
        Me.ccs16.TabIndex = 71
        Me.ccs16.Tag = "varchar"
        Me.ccs16.Text = "varchar"
        Me.ccs16.UseVisualStyleBackColor = True
        '
        'ccs17
        '
        Me.ccs17.AutoSize = True
        Me.ccs17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs17.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs17.Location = New System.Drawing.Point(300, 58)
        Me.ccs17.Name = "ccs17"
        Me.ccs17.Size = New System.Drawing.Size(48, 17)
        Me.ccs17.TabIndex = 70
        Me.ccs17.Tag = "char"
        Me.ccs17.Text = "char"
        Me.ccs17.UseVisualStyleBackColor = True
        '
        'cdt18
        '
        Me.cdt18.AutoSize = True
        Me.cdt18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt18.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt18.Location = New System.Drawing.Point(15, 284)
        Me.cdt18.Name = "cdt18"
        Me.cdt18.Size = New System.Drawing.Size(48, 17)
        Me.cdt18.TabIndex = 75
        Me.cdt18.Tag = "date"
        Me.cdt18.Text = "date"
        Me.cdt18.UseVisualStyleBackColor = True
        '
        'cdt19
        '
        Me.cdt19.AutoSize = True
        Me.cdt19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt19.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt19.Location = New System.Drawing.Point(15, 264)
        Me.cdt19.Name = "cdt19"
        Me.cdt19.Size = New System.Drawing.Size(73, 17)
        Me.cdt19.TabIndex = 74
        Me.cdt19.Tag = "datetime"
        Me.cdt19.Text = "datetime"
        Me.cdt19.UseVisualStyleBackColor = True
        '
        'cdt20
        '
        Me.cdt20.AutoSize = True
        Me.cdt20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt20.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt20.Location = New System.Drawing.Point(15, 244)
        Me.cdt20.Name = "cdt20"
        Me.cdt20.Size = New System.Drawing.Size(81, 17)
        Me.cdt20.TabIndex = 73
        Me.cdt20.Tag = "ISTDate"
        Me.cdt20.Text = "ISTDate *"
        Me.cdt20.UseVisualStyleBackColor = True
        '
        'cdt21
        '
        Me.cdt21.AutoSize = True
        Me.cdt21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt21.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt21.Location = New System.Drawing.Point(15, 304)
        Me.cdt21.Name = "cdt21"
        Me.cdt21.Size = New System.Drawing.Size(48, 17)
        Me.cdt21.TabIndex = 77
        Me.cdt21.Tag = "time"
        Me.cdt21.Text = "time"
        Me.cdt21.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.Label6.Location = New System.Drawing.Point(12, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 12)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "* in DB type will be nvarchar(50)"
        '
        'cbNOTNULL
        '
        Me.cbNOTNULL.AutoSize = True
        Me.cbNOTNULL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNOTNULL.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbNOTNULL.Location = New System.Drawing.Point(405, 308)
        Me.cbNOTNULL.Name = "cbNOTNULL"
        Me.cbNOTNULL.Size = New System.Drawing.Size(65, 17)
        Me.cbNOTNULL.TabIndex = 78
        Me.cbNOTNULL.Tag = ""
        Me.cbNOTNULL.Text = "not null"
        Me.cbNOTNULL.UseVisualStyleBackColor = True
        '
        'txtDuz
        '
        Me.txtDuz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuz.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuz.Location = New System.Drawing.Point(405, 79)
        Me.txtDuz.Name = "txtDuz"
        Me.txtDuz.Size = New System.Drawing.Size(84, 21)
        Me.txtDuz.TabIndex = 281
        Me.txtDuz.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.Label7.Location = New System.Drawing.Point(12, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 12)
        Me.Label7.TabIndex = 282
        Me.Label7.Text = "* in IST format will be dd.MM.yyyy"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(402, 222)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 285
        Me.Label9.Text = "Precision"
        Me.Label9.Visible = False
        '
        'txtp1
        '
        Me.txtp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtp1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtp1.Location = New System.Drawing.Point(402, 242)
        Me.txtp1.Name = "txtp1"
        Me.txtp1.Size = New System.Drawing.Size(42, 21)
        Me.txtp1.TabIndex = 284
        Me.txtp1.Visible = False
        '
        'txtp2
        '
        Me.txtp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtp2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtp2.Location = New System.Drawing.Point(447, 242)
        Me.txtp2.Name = "txtp2"
        Me.txtp2.Size = New System.Drawing.Size(39, 21)
        Me.txtp2.TabIndex = 286
        Me.txtp2.Visible = False
        '
        'txtTip
        '
        Me.txtTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTip.Location = New System.Drawing.Point(405, 331)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.ReadOnly = True
        Me.txtTip.Size = New System.Drawing.Size(84, 21)
        Me.txtTip.TabIndex = 287
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(402, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 327
        Me.Label11.Text = "MaxLength"
        Me.Label11.Visible = False
        '
        'txtDuzOstalo
        '
        Me.txtDuzOstalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuzOstalo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuzOstalo.Location = New System.Drawing.Point(402, 185)
        Me.txtDuzOstalo.Name = "txtDuzOstalo"
        Me.txtDuzOstalo.Size = New System.Drawing.Size(84, 21)
        Me.txtDuzOstalo.TabIndex = 326
        Me.txtDuzOstalo.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(405, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 325
        Me.Label8.Text = "MaxLength"
        Me.Label8.Visible = False
        '
        'mFormConvertType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(509, 398)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDuzOstalo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTip)
        Me.Controls.Add(Me.txtp2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtp1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDuz)
        Me.Controls.Add(Me.cbNOTNULL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cdt21)
        Me.Controls.Add(Me.cdt18)
        Me.Controls.Add(Me.cdt19)
        Me.Controls.Add(Me.cdt20)
        Me.Controls.Add(Me.ccs15)
        Me.Controls.Add(Me.ccs16)
        Me.Controls.Add(Me.ccs17)
        Me.Controls.Add(Me.ccs12)
        Me.Controls.Add(Me.ccs13)
        Me.Controls.Add(Me.ccs14)
        Me.Controls.Add(Me.can10)
        Me.Controls.Add(Me.can11)
        Me.Controls.Add(Me.cen9)
        Me.Controls.Add(Me.cen8)
        Me.Controls.Add(Me.cen7)
        Me.Controls.Add(Me.cen6)
        Me.Controls.Add(Me.cen5)
        Me.Controls.Add(Me.cen4)
        Me.Controls.Add(Me.cen3)
        Me.Controls.Add(Me.cen2)
        Me.Controls.Add(Me.cen1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormConvertType"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Convert type"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim pp() As String
    Dim izrazIzBaze As String
    Dim dIst As DatasetIstrazivanja

    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            '.Left = tvRight - Me.Width - 20
            '.Top = tvTop + 30
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cb1.Checked = True
        Me.pp = Me.Tag.split(";")
        Me.txtDuz.Text = "50"
        Me.Label1.Text = Me.Label1.Text + " for " + pp(2).Trim.ToUpper
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cb2.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            Me.pp = Me.Tag.split(";")
        End If
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            cb1.Checked = False
            cb3.Checked = False
            cb4.Checked = False
        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            cb2.Checked = False
            cb1.Checked = False
            cb4.Checked = False
        End If
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked = True Then
            cb2.Checked = False
            cb1.Checked = False
            cb3.Checked = False
        End If
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        If gbOptions.Visible = True Then
            If (ccs12.Checked = True OrElse ccs13.Checked = True OrElse ccs14.Checked = True OrElse ccs15.Checked = True OrElse ccs16.Checked = True OrElse ccs17.Checked = True) AndAlso
            (Me.txtDuz.Text = "" OrElse IsNumeric(Me.txtDuz.Text) = False) Then
                ISTMessageBox.Show("Lenght must be entered!")
                Me.txtDuz.Focus()
                Exit Sub
            End If
        End If

        Dim strW As String = "" : Dim strDB As String = "" : Dim strI As String = ""
        Dim trk() As String = pp(3).Split(".")
        Dim currenttab As Integer : Dim currentred As Integer : Dim currentkol As Integer
        Dim ttab As Boolean = False
        Dim duz As String = "" : Dim prec As String = ""
        Dim pI As String = "" : Dim pD As String = ""
        Dim fforma As String = ""

        If Me.txtTip.Tag = "S" Then
            If Me.txtDuz.Text.Trim = "" OrElse IsNumeric(Me.txtDuz.Text.Trim) = False Then Me.txtDuz.Text = "10"
            duz = "(" + Me.txtDuz.Text.Trim + ")"
        End If
        If Me.txtTip.Tag = "D" Then
            If Me.txtp1.Text.Trim = "" OrElse IsNumeric(Me.txtp1.Text.Trim) = False Then Me.txtp1.Text = "18"
            If Me.txtp2.Text.Trim = "" OrElse IsNumeric(Me.txtp2.Text.Trim) = False Then Me.txtp2.Text = "2"
            prec = "(" + Me.txtp1.Text.Trim + "," + Me.txtp2.Text.Trim + ")"

        End If

        If trk.Length = 3 Then
            ''ako je tabela
            ttab = True
            currenttab = CInt(trk(0).Trim)
            currentred = CInt(trk(1).Trim)
            currentkol = CInt(trk(2).Trim)
        End If

        Try
            Dim sNN As String = ""
            Dim sqlDBDropTip As String = "" : Dim DropTip As String = ""
            If cbNOTNULL.Checked = True Then sNN = "NOT NULL"

            Me.Cursor = Cursors.WaitCursor
            If ttab = True AndAlso (cb2.Checked = True OrElse cb3.Checked = True OrElse cb4.Checked = True) Then                ''ako je tabela
                sqlDBDropTip = ""
                If cb2.Checked = True Then fforma = CStr(currenttab).Trim + "." + CStr(currentred).Trim + ".%" 'row
                If cb3.Checked = True Then fforma = CStr(currenttab).Trim + ".%." + CStr(currentkol).Trim 'column
                If cb4.Checked = True Then fforma = CStr(currenttab).Trim + ".%" 'table

                strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"

                Dim str As String = "select polje from istpolja " + strW + " order by rbr"
                Dim dt As DataTable = izvrsiSQLvratiDT(str, Me.ISTConnectionString, Nothing)
                For i As Integer = 0 To dt.Rows.Count - 1
                    strDB = strDB + " ALTER TABLE " + pp(0).Trim + " ALTER COLUMN " + dt.Rows(i).Item("polje").ToString.Trim + " " + txtTip.Text + " " + prec + " " + duz + " " + sNN + ";" + nvrd
                    sqlDBDropTip = sqlDBDropTip + pp(0) + ";" + pp(1) + "#"
                    DropTip = DropTip + "ALTER COLUMN" + "#"
                Next

                strI = " update istpolja set tip='" + txtTip.Text + "', duzina='" + duz.Replace("(", "").Replace(")", "").Trim + "'" + nvrd + strW

                pI = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strI,, sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))

                If pI = "ok" Then
                    pD = izvrsiSQL(strDB, Me.DBConnectionString)
                End If

            End If

            If cb1.Checked = True Then
                sqlDBDropTip = ""
                strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                "' and polje=N'" + pp(2).Trim + "'" +
                "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

                'ALTER TABLE t2 ALTER COLUMN c VARCHAR (5);
                strDB = " ALTER TABLE " + pp(0).Trim + " ALTER COLUMN " + pp(2).Trim + " " + txtTip.Text + " " + prec + " " + duz + " " + sNN + ";" + nvrd
                sqlDBDropTip = sqlDBDropTip + pp(0) + ";" + pp(1) + "#"
                DropTip = DropTip + "ALTER COLUMN" + "#"
                Dim pduzina As String = ""
                If Me.txtDuz.Text <> "" Then pduzina = Me.txtDuz.Text Else pduzina = Me.txtDuzOstalo.Text
                strI = " update istpolja set tip='" + txtTip.Text + "', duzina='" + pduzina + "'" + nvrd + strW

                pI = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strI,, sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))
                If pI = "ok" Then
                    pD = izvrsiSQL(strDB, Me.DBConnectionString)
                End If

            End If

            Me.Cursor = Cursors.Default

            If pD = "ok" AndAlso pI = "ok" Then
                ISTMessageBox.Show("Done!")
                Me.Close()
            Else
                ISTMessageBox.Show("Error")
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chb_CheckedChanged(sender As Object, e As EventArgs) Handles cen1.CheckedChanged, cen2.CheckedChanged, cen3.CheckedChanged, cen4.CheckedChanged, cen5.CheckedChanged, cen6.CheckedChanged,
cen7.CheckedChanged, cen8.CheckedChanged, cen9.CheckedChanged, can10.CheckedChanged, can11.CheckedChanged, ccs12.CheckedChanged, ccs13.CheckedChanged, ccs14.CheckedChanged, ccs15.CheckedChanged, ccs16.CheckedChanged,
ccs17.CheckedChanged, cdt18.CheckedChanged, cdt19.CheckedChanged, cdt20.CheckedChanged, cdt21.CheckedChanged
        Dim chb As CheckBox = DirectCast(sender, CheckBox)
        If chb.Checked = True Then
            Me.txtTip.Text = chb.Tag.trim
            'all false
            For Each k As Control In Me.Controls
                If TypeOf k Is CheckBox AndAlso Not (DirectCast(k, CheckBox).Name = chb.Name) AndAlso Not DirectCast(k, CheckBox).Tag Is Nothing AndAlso DirectCast(k, CheckBox).Tag <> "" Then
                    DirectCast(k, CheckBox).Checked = False
                End If
            Next

            Me.txtTip.Tag = ""

            If chb.Name.Trim.Substring(0, 3) = "ccs" Then   'string
                Me.txtTip.Tag = "S"
                Me.Label8.Visible = True
                Me.txtDuz.Visible = True
                Me.txtDuz.Text = "10"

                Me.Label11.Visible = False
                Me.txtDuzOstalo.Visible = False
                Me.txtDuzOstalo.Text = ""
            Else
                Me.Label8.Visible = False
                Me.txtDuz.Visible = False
                Me.txtDuz.Text = ""

                Me.Label11.Visible = True
                Me.txtDuzOstalo.Visible = True
                Me.txtDuzOstalo.Text = "10"
            End If

            If chb.Tag = "ISTDate" Then   'decimal
                Me.txtTip.Text = "nvarchar (50)"
            End If

            If chb.Tag = "decimal" Then   'decimal
                Me.txtTip.Tag = "D"
                Me.Label9.Visible = True
                Me.txtp1.Visible = True
                Me.txtp2.Visible = True
                Me.txtp1.Text = "18"
                Me.txtp2.Text = "2"
                Me.txtp1.Focus()
            Else
                Me.Label9.Visible = False
                Me.txtp1.Visible = False
                Me.txtp2.Visible = False
                Me.txtp1.Text = ""
                Me.txtp2.Text = ""
            End If

        End If

    End Sub

End Class