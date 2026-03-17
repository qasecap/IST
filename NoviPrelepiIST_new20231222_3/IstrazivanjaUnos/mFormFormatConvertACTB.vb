'Option Strict Off

Imports IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka

Public Class mFormFormatConvertACTB
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
    Friend WithEvents gbAC As GroupBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents txtACFilterStart As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents txtACWidth As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents txtACHeight As TextBox
    Friend WithEvents txtACFilterLen As TextBox
    Friend WithEvents cbACLTL As CheckBox
    Friend WithEvents txtACAsgnLen As TextBox
    Friend WithEvents txtACFilterName As TextBox
    Friend WithEvents txtACAsgnStart As TextBox
    Friend WithEvents txtACAsgn As TextBox
    Friend WithEvents txtACMinTL As TextBox
    Friend WithEvents txtACLength As TextBox
    Friend WithEvents txtACStart As TextBox
    Friend WithEvents llACB As LinkLabel
    Friend WithEvents txtACBsaPutanjom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents txtLett As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chbNO As CheckBox
    Friend WithEvents txtACB As TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.gbAC = New System.Windows.Forms.GroupBox()
        Me.txtACB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chbNO = New System.Windows.Forms.CheckBox()
        Me.txtLett = New System.Windows.Forms.TextBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtACFilterStart = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtACWidth = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtACHeight = New System.Windows.Forms.TextBox()
        Me.txtACFilterLen = New System.Windows.Forms.TextBox()
        Me.cbACLTL = New System.Windows.Forms.CheckBox()
        Me.txtACAsgnLen = New System.Windows.Forms.TextBox()
        Me.txtACFilterName = New System.Windows.Forms.TextBox()
        Me.txtACAsgnStart = New System.Windows.Forms.TextBox()
        Me.txtACAsgn = New System.Windows.Forms.TextBox()
        Me.txtACMinTL = New System.Windows.Forms.TextBox()
        Me.txtACLength = New System.Windows.Forms.TextBox()
        Me.txtACStart = New System.Windows.Forms.TextBox()
        Me.llACB = New System.Windows.Forms.LinkLabel()
        Me.txtACBsaPutanjom = New System.Windows.Forms.TextBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAC.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(480, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(284, 24)
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
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Autocomplete TextBox"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 420)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(780, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'gbAC
        '
        Me.gbAC.Controls.Add(Me.txtACB)
        Me.gbAC.Controls.Add(Me.Label7)
        Me.gbAC.Controls.Add(Me.chbNO)
        Me.gbAC.Controls.Add(Me.txtLett)
        Me.gbAC.Controls.Add(Me.cb2)
        Me.gbAC.Controls.Add(Me.cb1)
        Me.gbAC.Controls.Add(Me.Label6)
        Me.gbAC.Controls.Add(Me.Label5)
        Me.gbAC.Controls.Add(Me.Label4)
        Me.gbAC.Controls.Add(Me.Label3)
        Me.gbAC.Controls.Add(Me.Label8)
        Me.gbAC.Controls.Add(Me.txtVS)
        Me.gbAC.Controls.Add(Me.Label2)
        Me.gbAC.Controls.Add(Me.Label36)
        Me.gbAC.Controls.Add(Me.Label37)
        Me.gbAC.Controls.Add(Me.Label39)
        Me.gbAC.Controls.Add(Me.Label40)
        Me.gbAC.Controls.Add(Me.txtACFilterStart)
        Me.gbAC.Controls.Add(Me.Label41)
        Me.gbAC.Controls.Add(Me.Label42)
        Me.gbAC.Controls.Add(Me.Label43)
        Me.gbAC.Controls.Add(Me.txtACWidth)
        Me.gbAC.Controls.Add(Me.Label44)
        Me.gbAC.Controls.Add(Me.Label46)
        Me.gbAC.Controls.Add(Me.Label47)
        Me.gbAC.Controls.Add(Me.Label48)
        Me.gbAC.Controls.Add(Me.Label49)
        Me.gbAC.Controls.Add(Me.txtACHeight)
        Me.gbAC.Controls.Add(Me.txtACFilterLen)
        Me.gbAC.Controls.Add(Me.cbACLTL)
        Me.gbAC.Controls.Add(Me.txtACAsgnLen)
        Me.gbAC.Controls.Add(Me.txtACFilterName)
        Me.gbAC.Controls.Add(Me.txtACAsgnStart)
        Me.gbAC.Controls.Add(Me.txtACAsgn)
        Me.gbAC.Controls.Add(Me.txtACMinTL)
        Me.gbAC.Controls.Add(Me.txtACLength)
        Me.gbAC.Controls.Add(Me.txtACStart)
        Me.gbAC.Controls.Add(Me.llACB)
        Me.gbAC.Controls.Add(Me.txtACBsaPutanjom)
        Me.gbAC.Location = New System.Drawing.Point(6, 31)
        Me.gbAC.Name = "gbAC"
        Me.gbAC.Size = New System.Drawing.Size(765, 381)
        Me.gbAC.TabIndex = 234
        Me.gbAC.TabStop = False
        '
        'txtACB
        '
        Me.txtACB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACB.Location = New System.Drawing.Point(13, 353)
        Me.txtACB.Multiline = True
        Me.txtACB.Name = "txtACB"
        Me.txtACB.Size = New System.Drawing.Size(80, 23)
        Me.txtACB.TabIndex = 340
        Me.txtACB.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(104, 306)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(350, 18)
        Me.Label7.TabIndex = 339
        Me.Label7.Text = "Limitations"
        '
        'chbNO
        '
        Me.chbNO.AccessibleName = ""
        Me.chbNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNO.Location = New System.Drawing.Point(54, 328)
        Me.chbNO.Name = "chbNO"
        Me.chbNO.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbNO.Size = New System.Drawing.Size(185, 19)
        Me.chbNO.TabIndex = 338
        Me.chbNO.Text = "Field is mandatory"
        '
        'txtLett
        '
        Me.txtLett.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLett.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLett.Location = New System.Drawing.Point(495, 103)
        Me.txtLett.Multiline = True
        Me.txtLett.Name = "txtLett"
        Me.txtLett.Size = New System.Drawing.Size(95, 22)
        Me.txtLett.TabIndex = 337
        Me.txtLett.Visible = False
        '
        'cb2
        '
        Me.cb2.AccessibleName = "LAT"
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.Location = New System.Drawing.Point(658, 114)
        Me.cb2.Name = "cb2"
        Me.cb2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb2.Size = New System.Drawing.Size(95, 19)
        Me.cb2.TabIndex = 336
        Me.cb2.Text = "Other"
        '
        'cb1
        '
        Me.cb1.AccessibleName = "CIR"
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.Location = New System.Drawing.Point(658, 83)
        Me.cb1.Name = "cb1"
        Me.cb1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb1.Size = New System.Drawing.Size(95, 19)
        Me.cb1.TabIndex = 335
        Me.cb1.Text = "Cyrillic "
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(471, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(282, 18)
        Me.Label6.TabIndex = 334
        Me.Label6.Text = "Filter"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(471, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 18)
        Me.Label5.TabIndex = 333
        Me.Label5.Text = "."
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(104, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(350, 18)
        Me.Label4.TabIndex = 332
        Me.Label4.Text = "Assignment"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(104, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 18)
        Me.Label3.TabIndex = 331
        Me.Label3.Text = "In each row of chosen text file:"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(474, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(279, 18)
        Me.Label8.TabIndex = 330
        Me.Label8.Text = "Apperance"
        '
        'txtVS
        '
        Me.txtVS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtVS.Location = New System.Drawing.Point(658, 328)
        Me.txtVS.Name = "txtVS"
        Me.txtVS.Size = New System.Drawing.Size(95, 20)
        Me.txtVS.TabIndex = 329
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 328
        Me.Label2.Text = "Width"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(486, 151)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label36.Size = New System.Drawing.Size(166, 15)
        Me.Label36.TabIndex = 265
        Me.Label36.Text = "Dropdown width"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(508, 252)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label37.Size = New System.Drawing.Size(139, 15)
        Me.Label37.TabIndex = 264
        Me.Label37.Text = "Start position of filter"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(47, 135)
        Me.Label39.Name = "Label39"
        Me.Label39.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label39.Size = New System.Drawing.Size(297, 15)
        Me.Label39.TabIndex = 259
        Me.Label39.Text = "Minimum type length for starting autocompletition"
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(508, 277)
        Me.Label40.Name = "Label40"
        Me.Label40.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label40.Size = New System.Drawing.Size(139, 15)
        Me.Label40.TabIndex = 263
        Me.Label40.Text = "Length of filter"
        '
        'txtACFilterStart
        '
        Me.txtACFilterStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACFilterStart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACFilterStart.Location = New System.Drawing.Point(658, 252)
        Me.txtACFilterStart.Multiline = True
        Me.txtACFilterStart.Name = "txtACFilterStart"
        Me.txtACFilterStart.Size = New System.Drawing.Size(95, 22)
        Me.txtACFilterStart.TabIndex = 184
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(47, 244)
        Me.Label41.Name = "Label41"
        Me.Label41.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label41.Size = New System.Drawing.Size(297, 15)
        Me.Label41.TabIndex = 257
        Me.Label41.Text = "Length of value that should be assigned"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(508, 227)
        Me.Label42.Name = "Label42"
        Me.Label42.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label42.Size = New System.Drawing.Size(139, 15)
        Me.Label42.TabIndex = 262
        Me.Label42.Text = "Filter name"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(47, 219)
        Me.Label43.Name = "Label43"
        Me.Label43.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label43.Size = New System.Drawing.Size(297, 15)
        Me.Label43.TabIndex = 256
        Me.Label43.Text = "Start position of value that should be assigned"
        '
        'txtACWidth
        '
        Me.txtACWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACWidth.Location = New System.Drawing.Point(658, 151)
        Me.txtACWidth.Multiline = True
        Me.txtACWidth.Name = "txtACWidth"
        Me.txtACWidth.Size = New System.Drawing.Size(95, 22)
        Me.txtACWidth.TabIndex = 194
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(47, 194)
        Me.Label44.Name = "Label44"
        Me.Label44.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label44.Size = New System.Drawing.Size(297, 15)
        Me.Label44.TabIndex = 255
        Me.Label44.Text = "Assign value to"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(486, 176)
        Me.Label46.Name = "Label46"
        Me.Label46.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label46.Size = New System.Drawing.Size(166, 15)
        Me.Label46.TabIndex = 261
        Me.Label46.Text = "Dropdown height"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(47, 110)
        Me.Label47.Name = "Label47"
        Me.Label47.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label47.Size = New System.Drawing.Size(297, 15)
        Me.Label47.TabIndex = 254
        Me.Label47.Text = "Length of autocompletition text"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(47, 85)
        Me.Label48.Name = "Label48"
        Me.Label48.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label48.Size = New System.Drawing.Size(297, 15)
        Me.Label48.TabIndex = 253
        Me.Label48.Text = "Start position of autocompletition text"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(485, 85)
        Me.Label49.Name = "Label49"
        Me.Label49.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label49.Size = New System.Drawing.Size(192, 15)
        Me.Label49.TabIndex = 260
        Me.Label49.Text = "Conversion to code book letter"
        '
        'txtACHeight
        '
        Me.txtACHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACHeight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACHeight.Location = New System.Drawing.Point(658, 176)
        Me.txtACHeight.Multiline = True
        Me.txtACHeight.Name = "txtACHeight"
        Me.txtACHeight.Size = New System.Drawing.Size(95, 22)
        Me.txtACHeight.TabIndex = 192
        '
        'txtACFilterLen
        '
        Me.txtACFilterLen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACFilterLen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACFilterLen.Location = New System.Drawing.Point(658, 277)
        Me.txtACFilterLen.Multiline = True
        Me.txtACFilterLen.Name = "txtACFilterLen"
        Me.txtACFilterLen.Size = New System.Drawing.Size(95, 22)
        Me.txtACFilterLen.TabIndex = 182
        '
        'cbACLTL
        '
        Me.cbACLTL.AccessibleName = ""
        Me.cbACLTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbACLTL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbACLTL.Location = New System.Drawing.Point(245, 328)
        Me.cbACLTL.Name = "cbACLTL"
        Me.cbACLTL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbACLTL.Size = New System.Drawing.Size(209, 19)
        Me.cbACLTL.TabIndex = 187
        Me.cbACLTL.Text = "Filed's values are limit to list"
        '
        'txtACAsgnLen
        '
        Me.txtACAsgnLen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACAsgnLen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACAsgnLen.Location = New System.Drawing.Point(359, 244)
        Me.txtACAsgnLen.Multiline = True
        Me.txtACAsgnLen.Name = "txtACAsgnLen"
        Me.txtACAsgnLen.Size = New System.Drawing.Size(95, 22)
        Me.txtACAsgnLen.TabIndex = 186
        '
        'txtACFilterName
        '
        Me.txtACFilterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACFilterName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACFilterName.Location = New System.Drawing.Point(658, 227)
        Me.txtACFilterName.Multiline = True
        Me.txtACFilterName.Name = "txtACFilterName"
        Me.txtACFilterName.Size = New System.Drawing.Size(95, 22)
        Me.txtACFilterName.TabIndex = 180
        '
        'txtACAsgnStart
        '
        Me.txtACAsgnStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACAsgnStart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACAsgnStart.Location = New System.Drawing.Point(359, 219)
        Me.txtACAsgnStart.Multiline = True
        Me.txtACAsgnStart.Name = "txtACAsgnStart"
        Me.txtACAsgnStart.Size = New System.Drawing.Size(95, 22)
        Me.txtACAsgnStart.TabIndex = 184
        '
        'txtACAsgn
        '
        Me.txtACAsgn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACAsgn.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACAsgn.Location = New System.Drawing.Point(359, 194)
        Me.txtACAsgn.Multiline = True
        Me.txtACAsgn.Name = "txtACAsgn"
        Me.txtACAsgn.Size = New System.Drawing.Size(95, 22)
        Me.txtACAsgn.TabIndex = 182
        '
        'txtACMinTL
        '
        Me.txtACMinTL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACMinTL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACMinTL.Location = New System.Drawing.Point(359, 135)
        Me.txtACMinTL.Multiline = True
        Me.txtACMinTL.Name = "txtACMinTL"
        Me.txtACMinTL.Size = New System.Drawing.Size(95, 22)
        Me.txtACMinTL.TabIndex = 180
        '
        'txtACLength
        '
        Me.txtACLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACLength.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACLength.Location = New System.Drawing.Point(359, 110)
        Me.txtACLength.Multiline = True
        Me.txtACLength.Name = "txtACLength"
        Me.txtACLength.Size = New System.Drawing.Size(95, 22)
        Me.txtACLength.TabIndex = 178
        '
        'txtACStart
        '
        Me.txtACStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACStart.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACStart.Location = New System.Drawing.Point(359, 85)
        Me.txtACStart.Multiline = True
        Me.txtACStart.Name = "txtACStart"
        Me.txtACStart.Size = New System.Drawing.Size(95, 22)
        Me.txtACStart.TabIndex = 176
        '
        'llACB
        '
        Me.llACB.AutoSize = True
        Me.llACB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llACB.Location = New System.Drawing.Point(10, 21)
        Me.llACB.Name = "llACB"
        Me.llACB.Size = New System.Drawing.Size(59, 13)
        Me.llACB.TabIndex = 175
        Me.llACB.TabStop = True
        Me.llACB.Text = "Choose file"
        '
        'txtACBsaPutanjom
        '
        Me.txtACBsaPutanjom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtACBsaPutanjom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtACBsaPutanjom.Location = New System.Drawing.Point(109, 17)
        Me.txtACBsaPutanjom.Multiline = True
        Me.txtACBsaPutanjom.Name = "txtACBsaPutanjom"
        Me.txtACBsaPutanjom.Size = New System.Drawing.Size(644, 23)
        Me.txtACBsaPutanjom.TabIndex = 172
        '
        'mFormFormatConvertACTB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(780, 450)
        Me.Controls.Add(Me.gbAC)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormFormatConvertACTB"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Autocomplete TextBox"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAC.ResumeLayout(False)
        Me.gbAC.PerformLayout()
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
    Dim folder As String
    Dim dIst As DatasetIstrazivanja
    Dim txtmode As String = ""
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String, ByVal folder As String, ByVal txtmode As String)
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
        Me.txtmode = txtmode
        Me.folder = folder
    End Sub

    Dim txtDir As String = ""

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        Me.Text = Me.what

        Dim strSQl As String = "select txtdir  from IST where sifist=N'" + sifist + "'"
        Dim dtI As DataTable = izvrsiSQLvratiDT(strSQl, Me.ISTConnectionString, Nothing)

        Dim folderZaGen As String = ""
        If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
            folderZaGen = GetTXTDir() + dtI.Rows(0).Item("sifist").ToString.Trim
        Else
            folderZaGen = dtI.Rows(0).Item("txtdir").ToString.Trim
        End If

        txtDir = folderZaGen

        If Me.what.Trim.ToUpper = "CONVERT" Then
            Me.Label1.Text = Me.what + " to AutoComplete TextBox"
            Dim dt As System.Data.DataTable = getDTC0()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Call getMetaDataPaneP2()
                If vs.Trim <> "" Then Me.txtVS.Text = vs
            End If
        ElseIf Me.what.Trim.ToUpper = "FORMAT" Then
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    getMetaDataPaneP1()
                    getMetaDataPaneP2()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
            Me.Label1.Text = Me.what + " AutoComplete TextBox" '+ "   " + Me.folder
        End If
        BtnFormat.Text = Me.what
    End Sub

    Dim cDO As String = ""
    Dim cOD As String = ""
    Dim vs As String = ""

    Function getDTC() As System.Data.DataTable
        cDO = ""
        vs = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select do,vs,od" +
                " from ISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "' and do like '%autocomplete%'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)

    End Function

    Function getDTC0() As System.Data.DataTable
        cDO = ""
        vs = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select do,vs,od " +
                " from ISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC0 = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)

    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        cDO = dt.Rows(0).Item("do").ToString.Trim
        cOD = dt.Rows(0).Item("od").ToString.Trim
        vs = dt.Rows(0).Item("vs").ToString.Trim
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        Call fformatConvert()
    End Sub

    Sub fformatConvert()

        Dim sqlIST As String = "" : Dim strDB As String = "" : Dim sqlDBDropTip As String = ""
        Dim ppolje As String = pp(2).Trim
        Dim rrbr As String = pp(4).Trim
        Dim p1 As String = "" : Dim p2 As String = ""

        Dim pDO As String = setMetaDataPaneP11()
        Dim pOD As String = ""
        If chbNO.Checked = True Then pOD = "No=;" + cODostatak Else pOD = cODostatak

        If pOD.Trim <> "" Then pOD = ",OD=N'#{" + pOD + "}'"

        Dim pvs As String = ""
        If txtVS.Text.Trim <> "" Then pvs = txtVS.Text.Trim

        If pDO <> "" Then
            sqlIST = "update istpolja set" + nvrd +
                " DO=N'#{" + pDO + "}', vs='" + pvs + "',tip='nvarchar', duzina='255'" + pOD +
                " where sifist ='" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "' and rbr ='" + pp(4).Trim + "'"

            strDB = " alter table " + pp(0).Trim + "  ALTER COLUMN " + pp(2).Trim + " nvarchar(255); "

            p1 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST,, sqlDBDropTip, "ALTER")
            'ALTER TABLE t2 ALTER COLUMN c VARCHAR (5);
            p2 = izvrsiSQLDB(strDB, Me.DBConnectionString)

            If p1 = "nok" OrElse p2 = "nok" Then ISTMessageBox.Show("Error!")
            If p1 = "ok" AndAlso p2 = "ok" Then Me.Close()
        End If
    End Sub

    Dim cODostatak As String = ""

    Sub getMetaDataPaneP2()
        If cOD.Trim = "" Then Exit Sub
        cOD = cOD.Replace(vbCrLf, "").Replace("#{", "").Trim
        If cOD.Substring(cOD.Length - 1, 1) = "}" Then cOD = cOD.Substring(0, cOD.Length - 1)
        Dim pp() As String = cOD.Split(";")
        Dim fff As String = ""
        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Length > 1 AndAlso (pp(i).Trim.ToUpper.IndexOf("NO") = 0 OrElse pp(i).Trim.ToUpper.IndexOf("NE") = 0) Then
                chbNO.Checked = True
                Dim na As String = ""
                na = Replace(pp(i), "no=", "", 1, , CompareMethod.Text)
                na = Replace(na, "ne=", "", 1, , CompareMethod.Text)
                If na = "" Then
                    chbNO.Checked = True
                Else
                    fff = na.TrimStart(",")
                    If na.IndexOf(",") = 0 Then
                        chbNO.Checked = True
                    Else
                        Dim opo() As String = na.Split(",")
                        For nn As Integer = 0 To opo.GetUpperBound(0)
                            If opo(nn).Trim = "" Then chbNO.Checked = True : Exit For
                        Next
                    End If
                End If
            Else
                cODostatak = cODostatak + pp(i) + ";"
            End If
            cODostatak = cODostatak.TrimEnd(";")
        Next
    End Sub

    Sub getMetaDataPaneP1()
        cDO = cDO.Replace(vbCrLf, "").Replace("#{", "").Trim
        If cDO.Substring(cDO.Length - 1, 1) = "}" Then cDO = cDO.Substring(0, cDO.Length - 1)
        Dim pp() As String = cDO.Split(";")
        If vs.Trim <> "" Then Me.txtVS.Text = vs
        cb2.Checked = True
        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETE=") = 0 Then
                Dim ac As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETE=", "")
                txtACB.Text = ac
                txtACBsaPutanjom.Text = folder + "\" + ac
            ElseIf pp(i).Length > 24 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEMINTYPELENGTH") = 0 Then
                Dim acmtl As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEMINTYPELENGTH=", "")
                txtACMinTL.Text = acmtl
            ElseIf pp(i).Length > 23 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEASSIGNLENGTH") = 0 Then
                Dim acal As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEASSIGNLENGTH=", "")
                txtACAsgnLen.Text = acal
            ElseIf pp(i).Length > 23 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEFILTERLENGTH") = 0 Then
                Dim acfl As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEFILTERLENGTH=", "")
                txtACFilterLen.Text = acfl
            ElseIf pp(i).Length > 22 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEASSIGNSTART") = 0 Then
                Dim acas As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEASSIGNSTART=", "")
                txtACAsgnStart.Text = acas
            ElseIf pp(i).Length > 22 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETELIMITTOLIST") = 0 Then
                Dim acltl As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETELIMITTOLIST=", "")
                If acltl.Trim.ToLower = "true" Then cbACLTL.Checked = True
            ElseIf pp(i).Length > 22 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEFILTERSTART") = 0 Then
                Dim acfs As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEFILTERSTART=", "")
                txtACFilterStart.Text = acfs
            ElseIf pp(i).Length > 19 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEASSIGNTO") = 0 Then
                Dim acat As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEASSIGNTO=", "")
                txtACAsgn.Text = acat
            ElseIf pp(i).Length > 17 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETELETTER") = 0 Then
                Dim acl As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETELETTER=", "")
                txtLett.Text = acl
                If acl.Trim.ToUpper = "CIR" Then cb1.Checked = True
                If acl.Trim.ToUpper = "LAT" Then cb2.Checked = True
            ElseIf pp(i).Length > 17 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEHEIGHT") = 0 Then
                Dim ach As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEHEIGHT=", "")
                txtACHeight.Text = ach
            ElseIf pp(i).Length > 17 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETELENGTH") = 0 Then
                Dim acl As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETELENGTH=", "")
                txtACLength.Text = acl
            ElseIf pp(i).Length > 17 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEFILTER") = 0 Then
                Dim acf As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEFILTER=", "")
                txtACFilterName.Text = acf
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETESTART") = 0 Then
                Dim acs As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETESTART=", "")
                txtACStart.Text = acs
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTOCOMPLETEWIDTH") = 0 Then
                Dim acw As String = pp(i).Trim.ToUpper.Replace("AUTOCOMPLETEWIDTH=", "")
                txtACWidth.Text = acw
            End If
        Next

    End Sub

    Function setMetaDataPaneP11() As String
        'do autocompete
        Dim pom As String = ""

        If txtACB.Text <> "" Then pom = pom + "autocomplete=" + txtACB.Text + ";"
        If txtACStart.Text <> "" Then pom = pom + "autocompletestart=" + txtACStart.Text + ";"
        If txtACLength.Text <> "" Then pom = pom + "autocompletelength=" + txtACLength.Text + ";"
        If txtACMinTL.Text <> "" Then pom = pom + "autocompletemintypelength=" + txtACMinTL.Text + ";"
        If txtACAsgn.Text <> "" Then pom = pom + "autocompleteassignto=" + txtACAsgn.Text + ";"
        If txtACAsgnStart.Text <> "" Then pom = pom + "autocompleteassignstart=" + txtACAsgnStart.Text + ";"
        If txtACAsgnLen.Text <> "" Then pom = pom + "autocompleteassignlength=" + txtACAsgnLen.Text + ";"
        If cbACLTL.Checked = True Then pom = pom + "autocompletelimittolist=True;"
        If txtLett.Text <> "" Then pom = pom + "autocompleteletter=" + txtLett.Text + ";"
        If txtACHeight.Text <> "" Then pom = pom + "autocompleteheight=" + txtACHeight.Text + ";"
        If txtACWidth.Text <> "" Then pom = pom + "autocompletewidth=" + txtACWidth.Text + ";"
        If txtACFilterName.Text <> "" Then pom = pom + "autocompletefilter=" + txtACFilterName.Text + ";"
        If txtACFilterLen.Text <> "" Then pom = pom + "autocompletefilterlength=" + txtACFilterLen.Text + ";"
        If txtACFilterStart.Text <> "" Then pom = pom + "autocompletefilterstart=" + txtACFilterStart.Text + ";"

        Return pom

    End Function

    Private Sub llACB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llACB.LinkClicked
        Dim openFileDialog1 As New OpenFileDialog()
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            txtACBsaPutanjom.Text = openFileDialog1.FileName
            txtACB.Text = openFileDialog1.SafeFileName

            Dim sd As String = openFileDialog1.FileName.Substring(0, openFileDialog1.FileName.Trim.LastIndexOf("\"))
            Dim dd As String = Me.txtDir

            If sd.ToUpper.Trim <> dd.ToUpper.Trim Then
                Call CopyFile(sd + "\", dd + "\", openFileDialog1.SafeFileName)
            End If

        End If
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cb2.Checked = False
            txtLett.Text = "CIR"
        Else
            txtLett.Text = "LAT"
        End If
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            cb1.Checked = False
            txtLett.Text = "LAT"
        End If
    End Sub

End Class