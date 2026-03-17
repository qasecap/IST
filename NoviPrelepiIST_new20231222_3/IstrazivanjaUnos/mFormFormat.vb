'Option Strict Off
Public Class mFormFormat
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
    Friend WithEvents Label2 As Label
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents Label126 As Label
    Friend WithEvents r13 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents gbYES As GroupBox
    Friend WithEvents rbYesTime As RadioButton
    Friend WithEvents rbYesISTDate As RadioButton
    Friend WithEvents rbYesDate As RadioButton
    Friend WithEvents rbYesSpec As RadioButton
    Friend WithEvents txtYesSpec As TextBox
    Friend WithEvents rbYesA As RadioButton
    Friend WithEvents rbYesAN As RadioButton
    Friend WithEvents rbYesN As RadioButton
    Friend WithEvents gbNO As GroupBox
    Friend WithEvents Label85 As Label
    Friend WithEvents chbNoNotEmpty As CheckBox
    Friend WithEvents txtNoSpec As TextBox
    Friend WithEvents chbYes As CheckBox
    Friend WithEvents chbNO As CheckBox
    Friend WithEvents txtDP As TextBox
    Friend WithEvents lblAMVF3 As Label
    Friend WithEvents lblAMVF2 As Label
    Friend WithEvents txtAMVF3 As TextBox
    Friend WithEvents txtAMVF2 As TextBox
    Friend WithEvents txtMin As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents txtMinL As TextBox
    Friend WithEvents txtMaxL As TextBox
    Friend WithEvents cbAMV As CheckBox
    Friend WithEvents chbWarning As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chbNTS As CheckBox
    Friend WithEvents chbVF As CheckBox
    Friend WithEvents chbEF As CheckBox
    Friend WithEvents txtMultilineH As TextBox
    Friend WithEvents chbMultiline As CheckBox
    Friend WithEvents chbRO As CheckBox
    Friend WithEvents chbMultilineH As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDG As TextBox
    Friend WithEvents txtRif As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.r13 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.gbYES = New System.Windows.Forms.GroupBox()
        Me.rbYesTime = New System.Windows.Forms.RadioButton()
        Me.rbYesISTDate = New System.Windows.Forms.RadioButton()
        Me.rbYesDate = New System.Windows.Forms.RadioButton()
        Me.rbYesSpec = New System.Windows.Forms.RadioButton()
        Me.txtYesSpec = New System.Windows.Forms.TextBox()
        Me.rbYesA = New System.Windows.Forms.RadioButton()
        Me.rbYesAN = New System.Windows.Forms.RadioButton()
        Me.rbYesN = New System.Windows.Forms.RadioButton()
        Me.gbNO = New System.Windows.Forms.GroupBox()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.chbNoNotEmpty = New System.Windows.Forms.CheckBox()
        Me.txtNoSpec = New System.Windows.Forms.TextBox()
        Me.chbYes = New System.Windows.Forms.CheckBox()
        Me.chbNO = New System.Windows.Forms.CheckBox()
        Me.txtDP = New System.Windows.Forms.TextBox()
        Me.lblAMVF3 = New System.Windows.Forms.Label()
        Me.lblAMVF2 = New System.Windows.Forms.Label()
        Me.txtAMVF3 = New System.Windows.Forms.TextBox()
        Me.txtAMVF2 = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.txtMinL = New System.Windows.Forms.TextBox()
        Me.txtMaxL = New System.Windows.Forms.TextBox()
        Me.cbAMV = New System.Windows.Forms.CheckBox()
        Me.chbWarning = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbNTS = New System.Windows.Forms.CheckBox()
        Me.chbVF = New System.Windows.Forms.CheckBox()
        Me.chbEF = New System.Windows.Forms.CheckBox()
        Me.txtMultilineH = New System.Windows.Forms.TextBox()
        Me.chbMultiline = New System.Windows.Forms.CheckBox()
        Me.chbRO = New System.Windows.Forms.CheckBox()
        Me.chbMultilineH = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDG = New System.Windows.Forms.TextBox()
        Me.txtRif = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.gbYES.SuspendLayout()
        Me.gbNO.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(598, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(195, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.Text = "Format"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Format"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 407)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(840, 25)
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
        Me.gbOptions.Size = New System.Drawing.Size(185, 115)
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
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(249, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Value"
        '
        'Label126
        '
        Me.Label126.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label126.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(476, 129)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(51, 31)
        Me.Label126.TabIndex = 307
        Me.Label126.Text = "Add AWL"
        Me.Label126.Visible = False
        '
        'r13
        '
        Me.r13.AutoSize = True
        Me.r13.Location = New System.Drawing.Point(455, 143)
        Me.r13.Name = "r13"
        Me.r13.Size = New System.Drawing.Size(15, 14)
        Me.r13.TabIndex = 306
        Me.r13.UseVisualStyleBackColor = True
        Me.r13.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(249, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 308
        Me.Label3.Text = "Length"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label90.Location = New System.Drawing.Point(380, 31)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(30, 13)
        Me.Label90.TabIndex = 330
        Me.Label90.Text = "Max"
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label91.Location = New System.Drawing.Point(206, 99)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(97, 41)
        Me.Label91.TabIndex = 329
        Me.Label91.Text = "Max number of decimal places"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label93.Location = New System.Drawing.Point(308, 31)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(26, 13)
        Me.Label93.TabIndex = 327
        Me.Label93.Text = "Min"
        '
        'gbYES
        '
        Me.gbYES.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.gbYES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbYES.Controls.Add(Me.rbYesTime)
        Me.gbYES.Controls.Add(Me.rbYesISTDate)
        Me.gbYES.Controls.Add(Me.rbYesDate)
        Me.gbYES.Controls.Add(Me.rbYesSpec)
        Me.gbYES.Controls.Add(Me.txtYesSpec)
        Me.gbYES.Controls.Add(Me.rbYesA)
        Me.gbYES.Controls.Add(Me.rbYesAN)
        Me.gbYES.Controls.Add(Me.rbYesN)
        Me.gbYES.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbYES.Location = New System.Drawing.Point(271, 180)
        Me.gbYES.Margin = New System.Windows.Forms.Padding(0)
        Me.gbYES.Name = "gbYES"
        Me.gbYES.Size = New System.Drawing.Size(256, 185)
        Me.gbYES.TabIndex = 325
        Me.gbYES.TabStop = False
        Me.gbYES.Visible = False
        '
        'rbYesTime
        '
        Me.rbYesTime.AutoSize = True
        Me.rbYesTime.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbYesTime.Location = New System.Drawing.Point(7, 112)
        Me.rbYesTime.Name = "rbYesTime"
        Me.rbYesTime.Size = New System.Drawing.Size(53, 17)
        Me.rbYesTime.TabIndex = 179
        Me.rbYesTime.TabStop = True
        Me.rbYesTime.Text = "Time"
        Me.rbYesTime.UseVisualStyleBackColor = True
        '
        'rbYesISTDate
        '
        Me.rbYesISTDate.AutoSize = True
        Me.rbYesISTDate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbYesISTDate.Location = New System.Drawing.Point(7, 92)
        Me.rbYesISTDate.Name = "rbYesISTDate"
        Me.rbYesISTDate.Size = New System.Drawing.Size(72, 17)
        Me.rbYesISTDate.TabIndex = 178
        Me.rbYesISTDate.TabStop = True
        Me.rbYesISTDate.Text = "ISTDate"
        Me.rbYesISTDate.UseVisualStyleBackColor = True
        '
        'rbYesDate
        '
        Me.rbYesDate.AutoSize = True
        Me.rbYesDate.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbYesDate.Location = New System.Drawing.Point(7, 72)
        Me.rbYesDate.Name = "rbYesDate"
        Me.rbYesDate.Size = New System.Drawing.Size(52, 17)
        Me.rbYesDate.TabIndex = 177
        Me.rbYesDate.TabStop = True
        Me.rbYesDate.Text = "Date"
        Me.rbYesDate.UseVisualStyleBackColor = True
        '
        'rbYesSpec
        '
        Me.rbYesSpec.AutoSize = True
        Me.rbYesSpec.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbYesSpec.Location = New System.Drawing.Point(7, 132)
        Me.rbYesSpec.Name = "rbYesSpec"
        Me.rbYesSpec.Size = New System.Drawing.Size(187, 17)
        Me.rbYesSpec.TabIndex = 176
        Me.rbYesSpec.TabStop = True
        Me.rbYesSpec.Text = "Values separated by comma"
        Me.rbYesSpec.UseVisualStyleBackColor = True
        '
        'txtYesSpec
        '
        Me.txtYesSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYesSpec.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYesSpec.Location = New System.Drawing.Point(7, 152)
        Me.txtYesSpec.Name = "txtYesSpec"
        Me.txtYesSpec.Size = New System.Drawing.Size(244, 21)
        Me.txtYesSpec.TabIndex = 174
        '
        'rbYesA
        '
        Me.rbYesA.AutoSize = True
        Me.rbYesA.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbYesA.Location = New System.Drawing.Point(7, 52)
        Me.rbYesA.Name = "rbYesA"
        Me.rbYesA.Size = New System.Drawing.Size(57, 17)
        Me.rbYesA.TabIndex = 2
        Me.rbYesA.TabStop = True
        Me.rbYesA.Text = "Alpha"
        Me.rbYesA.UseVisualStyleBackColor = True
        '
        'rbYesAN
        '
        Me.rbYesAN.AutoSize = True
        Me.rbYesAN.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbYesAN.Location = New System.Drawing.Point(7, 32)
        Me.rbYesAN.Name = "rbYesAN"
        Me.rbYesAN.Size = New System.Drawing.Size(107, 17)
        Me.rbYesAN.TabIndex = 1
        Me.rbYesAN.TabStop = True
        Me.rbYesAN.Text = "Alpha numeric"
        Me.rbYesAN.UseVisualStyleBackColor = True
        '
        'rbYesN
        '
        Me.rbYesN.AutoSize = True
        Me.rbYesN.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.rbYesN.Location = New System.Drawing.Point(7, 12)
        Me.rbYesN.Name = "rbYesN"
        Me.rbYesN.Size = New System.Drawing.Size(72, 17)
        Me.rbYesN.TabIndex = 0
        Me.rbYesN.TabStop = True
        Me.rbYesN.Text = "Numeric"
        Me.rbYesN.UseVisualStyleBackColor = True
        '
        'gbNO
        '
        Me.gbNO.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.gbNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbNO.Controls.Add(Me.Label85)
        Me.gbNO.Controls.Add(Me.chbNoNotEmpty)
        Me.gbNO.Controls.Add(Me.txtNoSpec)
        Me.gbNO.Cursor = System.Windows.Forms.Cursors.Default
        Me.gbNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbNO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gbNO.Location = New System.Drawing.Point(2, 180)
        Me.gbNO.Margin = New System.Windows.Forms.Padding(0)
        Me.gbNO.Name = "gbNO"
        Me.gbNO.Size = New System.Drawing.Size(256, 88)
        Me.gbNO.TabIndex = 324
        Me.gbNO.TabStop = False
        Me.gbNO.Visible = False
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label85.Location = New System.Drawing.Point(7, 41)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(169, 13)
        Me.Label85.TabIndex = 277
        Me.Label85.Text = "Values separated by comma"
        '
        'chbNoNotEmpty
        '
        Me.chbNoNotEmpty.AccessibleName = ""
        Me.chbNoNotEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNoNotEmpty.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNoNotEmpty.Location = New System.Drawing.Point(7, 16)
        Me.chbNoNotEmpty.Name = "chbNoNotEmpty"
        Me.chbNoNotEmpty.Size = New System.Drawing.Size(185, 19)
        Me.chbNoNotEmpty.TabIndex = 193
        Me.chbNoNotEmpty.Text = "Empty"
        '
        'txtNoSpec
        '
        Me.txtNoSpec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSpec.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSpec.Location = New System.Drawing.Point(7, 61)
        Me.txtNoSpec.Name = "txtNoSpec"
        Me.txtNoSpec.Size = New System.Drawing.Size(244, 21)
        Me.txtNoSpec.TabIndex = 174
        '
        'chbYes
        '
        Me.chbYes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chbYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbYes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbYes.Location = New System.Drawing.Point(271, 163)
        Me.chbYes.Name = "chbYes"
        Me.chbYes.Size = New System.Drawing.Size(256, 20)
        Me.chbYes.TabIndex = 323
        Me.chbYes.Text = "Allowed values"
        Me.chbYes.UseVisualStyleBackColor = False
        '
        'chbNO
        '
        Me.chbNO.AccessibleName = ""
        Me.chbNO.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.chbNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNO.Location = New System.Drawing.Point(3, 163)
        Me.chbNO.Name = "chbNO"
        Me.chbNO.Size = New System.Drawing.Size(256, 20)
        Me.chbNO.TabIndex = 322
        Me.chbNO.Text = "Not allowed values"
        Me.chbNO.UseVisualStyleBackColor = False
        '
        'txtDP
        '
        Me.txtDP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDP.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDP.Location = New System.Drawing.Point(308, 96)
        Me.txtDP.Name = "txtDP"
        Me.txtDP.Size = New System.Drawing.Size(71, 21)
        Me.txtDP.TabIndex = 321
        '
        'lblAMVF3
        '
        Me.lblAMVF3.AutoSize = True
        Me.lblAMVF3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMVF3.Location = New System.Drawing.Point(139, 320)
        Me.lblAMVF3.Name = "lblAMVF3"
        Me.lblAMVF3.Size = New System.Drawing.Size(20, 13)
        Me.lblAMVF3.TabIndex = 320
        Me.lblAMVF3.Text = "F3"
        Me.lblAMVF3.Visible = False
        '
        'lblAMVF2
        '
        Me.lblAMVF2.AutoSize = True
        Me.lblAMVF2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMVF2.Location = New System.Drawing.Point(138, 298)
        Me.lblAMVF2.Name = "lblAMVF2"
        Me.lblAMVF2.Size = New System.Drawing.Size(20, 13)
        Me.lblAMVF2.TabIndex = 319
        Me.lblAMVF2.Text = "F2"
        Me.lblAMVF2.Visible = False
        '
        'txtAMVF3
        '
        Me.txtAMVF3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAMVF3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAMVF3.Location = New System.Drawing.Point(169, 320)
        Me.txtAMVF3.Name = "txtAMVF3"
        Me.txtAMVF3.Size = New System.Drawing.Size(83, 21)
        Me.txtAMVF3.TabIndex = 318
        Me.txtAMVF3.Visible = False
        '
        'txtAMVF2
        '
        Me.txtAMVF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAMVF2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAMVF2.Location = New System.Drawing.Point(169, 298)
        Me.txtAMVF2.Name = "txtAMVF2"
        Me.txtAMVF2.Size = New System.Drawing.Size(83, 21)
        Me.txtAMVF2.TabIndex = 317
        Me.txtAMVF2.Visible = False
        '
        'txtMin
        '
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMin.Location = New System.Drawing.Point(308, 52)
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(71, 21)
        Me.txtMin.TabIndex = 316
        '
        'txtMax
        '
        Me.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMax.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMax.Location = New System.Drawing.Point(380, 52)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(71, 21)
        Me.txtMax.TabIndex = 315
        '
        'txtMinL
        '
        Me.txtMinL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinL.Location = New System.Drawing.Point(308, 74)
        Me.txtMinL.Name = "txtMinL"
        Me.txtMinL.Size = New System.Drawing.Size(71, 21)
        Me.txtMinL.TabIndex = 314
        '
        'txtMaxL
        '
        Me.txtMaxL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaxL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaxL.Location = New System.Drawing.Point(380, 74)
        Me.txtMaxL.Name = "txtMaxL"
        Me.txtMaxL.Size = New System.Drawing.Size(71, 21)
        Me.txtMaxL.TabIndex = 313
        '
        'cbAMV
        '
        Me.cbAMV.AccessibleName = ""
        Me.cbAMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAMV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAMV.Location = New System.Drawing.Point(3, 298)
        Me.cbAMV.Name = "cbAMV"
        Me.cbAMV.Size = New System.Drawing.Size(134, 19)
        Me.cbAMV.TabIndex = 312
        Me.cbAMV.Text = "Add missing value"
        '
        'chbWarning
        '
        Me.chbWarning.AccessibleName = "Warning"
        Me.chbWarning.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbWarning.Location = New System.Drawing.Point(453, 28)
        Me.chbWarning.Name = "chbWarning"
        Me.chbWarning.Size = New System.Drawing.Size(106, 62)
        Me.chbWarning.TabIndex = 311
        Me.chbWarning.Text = "Only warning (do not stop)"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.CausesValidation = False
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(591, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 20)
        Me.Label4.TabIndex = 336
        Me.Label4.Text = "Behavior"
        Me.Label4.Visible = False
        '
        'chbNTS
        '
        Me.chbNTS.AccessibleName = ""
        Me.chbNTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNTS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNTS.Location = New System.Drawing.Point(598, 317)
        Me.chbNTS.Name = "chbNTS"
        Me.chbNTS.Size = New System.Drawing.Size(103, 20)
        Me.chbNTS.TabIndex = 343
        Me.chbNTS.Text = "No Tab Stop"
        Me.chbNTS.Visible = False
        '
        'chbVF
        '
        Me.chbVF.AccessibleName = "visiblefalse"
        Me.chbVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVF.Location = New System.Drawing.Point(598, 242)
        Me.chbVF.Name = "chbVF"
        Me.chbVF.Size = New System.Drawing.Size(103, 19)
        Me.chbVF.TabIndex = 342
        Me.chbVF.Text = "Visible false"
        Me.chbVF.Visible = False
        '
        'chbEF
        '
        Me.chbEF.AccessibleName = "enabledfalse"
        Me.chbEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEF.Location = New System.Drawing.Point(598, 267)
        Me.chbEF.Name = "chbEF"
        Me.chbEF.Size = New System.Drawing.Size(103, 19)
        Me.chbEF.TabIndex = 341
        Me.chbEF.Text = "Enable false"
        Me.chbEF.Visible = False
        '
        'txtMultilineH
        '
        Me.txtMultilineH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMultilineH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMultilineH.Location = New System.Drawing.Point(743, 217)
        Me.txtMultilineH.Name = "txtMultilineH"
        Me.txtMultilineH.Size = New System.Drawing.Size(50, 21)
        Me.txtMultilineH.TabIndex = 340
        Me.txtMultilineH.Visible = False
        '
        'chbMultiline
        '
        Me.chbMultiline.AccessibleName = "multiline"
        Me.chbMultiline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMultiline.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMultiline.Location = New System.Drawing.Point(598, 192)
        Me.chbMultiline.Name = "chbMultiline"
        Me.chbMultiline.Size = New System.Drawing.Size(103, 19)
        Me.chbMultiline.TabIndex = 338
        Me.chbMultiline.Text = "Multiline"
        Me.chbMultiline.Visible = False
        '
        'chbRO
        '
        Me.chbRO.AccessibleName = "readonly"
        Me.chbRO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRO.Location = New System.Drawing.Point(598, 292)
        Me.chbRO.Name = "chbRO"
        Me.chbRO.Size = New System.Drawing.Size(241, 19)
        Me.chbRO.TabIndex = 337
        Me.chbRO.Text = "Read Only*"
        Me.chbRO.Visible = False
        '
        'chbMultilineH
        '
        Me.chbMultilineH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMultilineH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMultilineH.Location = New System.Drawing.Point(598, 217)
        Me.chbMultilineH.Name = "chbMultilineH"
        Me.chbMultilineH.Size = New System.Drawing.Size(145, 19)
        Me.chbMultilineH.TabIndex = 339
        Me.chbMultilineH.Text = "Multiline height in px"
        Me.chbMultilineH.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(591, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 20)
        Me.Label5.TabIndex = 344
        Me.Label5.Text = "Default value"
        '
        'txtDG
        '
        Me.txtDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDG.Location = New System.Drawing.Point(596, 123)
        Me.txtDG.Name = "txtDG"
        Me.txtDG.Size = New System.Drawing.Size(90, 21)
        Me.txtDG.TabIndex = 345
        '
        'txtRif
        '
        Me.txtRif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRif.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRif.Location = New System.Drawing.Point(596, 74)
        Me.txtRif.Name = "txtRif"
        Me.txtRif.Size = New System.Drawing.Size(196, 21)
        Me.txtRif.TabIndex = 347
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(591, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 20)
        Me.Label6.TabIndex = 346
        Me.Label6.Text = "Required if"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(355, 391)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(346, 13)
        Me.Label7.TabIndex = 348
        Me.Label7.Text = "*Read only fields will have No Tab Stop=True automatically"
        Me.Label7.Visible = False
        '
        'mFormFormat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(840, 437)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRif)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDG)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chbNTS)
        Me.Controls.Add(Me.chbVF)
        Me.Controls.Add(Me.chbEF)
        Me.Controls.Add(Me.txtMultilineH)
        Me.Controls.Add(Me.chbMultiline)
        Me.Controls.Add(Me.chbRO)
        Me.Controls.Add(Me.chbMultilineH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label90)
        Me.Controls.Add(Me.Label91)
        Me.Controls.Add(Me.Label93)
        Me.Controls.Add(Me.gbYES)
        Me.Controls.Add(Me.gbNO)
        Me.Controls.Add(Me.chbYes)
        Me.Controls.Add(Me.chbNO)
        Me.Controls.Add(Me.txtDP)
        Me.Controls.Add(Me.lblAMVF3)
        Me.Controls.Add(Me.lblAMVF2)
        Me.Controls.Add(Me.txtAMVF3)
        Me.Controls.Add(Me.txtAMVF2)
        Me.Controls.Add(Me.txtMin)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtMinL)
        Me.Controls.Add(Me.txtMaxL)
        Me.Controls.Add(Me.cbAMV)
        Me.Controls.Add(Me.chbWarning)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label126)
        Me.Controls.Add(Me.r13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormFormat"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Format"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbYES.ResumeLayout(False)
        Me.gbYES.PerformLayout()
        Me.gbNO.ResumeLayout(False)
        Me.gbNO.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim pp() As String
    Dim dIst As DatasetIstrazivanja
    Dim od As String = ""
    Dim odOst As String = ""
    Dim formatizraz As String = ""
    Dim DG As String = ""
    Dim izraz As String = ""
    Dim what As String

    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String,
                   ByVal DBConnectionString As String, ByVal sender As Control, ByVal what As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
            '.Left = tvRight - Me.Width - 20
            '.Top = tvTop + 30
        End With
        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.what = what
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        Me.cb1.Checked = True
        Me.Label1.Text = "Format field " + pp(2).Trim '+ "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cb2.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            Me.pp = Me.Tag.split(";")
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    getMetaDataPaneP3()
                    getMetaDataPaneP5()
                    getMetaDataPaneDG()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Function getDTC() As System.Data.DataTable
        od = ""
        izraz = ""
        formatizraz = ""
        DG = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select od,izraz,formatizraz,DG " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Function getDTCtabela(ByVal strW As String) As System.Data.DataTable
        od = ""
        izraz = ""
        formatizraz = ""
        DG = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select polje,vod,od,izraz,formatizraz,DG from vrepISTPolja " + strW
        getDTCtabela = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        od = dt.Rows(0).Item("od").ToString.Trim
        izraz = dt.Rows(0).Item("izraz").ToString.Trim
        formatizraz = dt.Rows(0).Item("formatizraz").ToString.Trim
        DG = dt.Rows(0).Item("DG").ToString.Trim
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            cb1.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            Label1.Text = "Warning"
        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            cb2.Checked = False
            cb1.Checked = False
            cb4.Checked = False
            Label1.Text = "Warning"
        End If
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked = True Then
            cb2.Checked = False
            cb3.Checked = False
            cb1.Checked = False
            Label1.Text = "Warning"
        End If
    End Sub

    Private Sub cbNO_CheckedChanged(sender As Object, e As EventArgs) Handles chbNO.CheckedChanged
        Me.gbNO.Visible = chbNO.Checked
        If Me.gbNO.Visible = True Then
            Me.gbNO.Focus()
        Else
            resetAllControls(gbNO)
        End If
    End Sub

    Private Sub cbYes_CheckedChanged(sender As Object, e As EventArgs) Handles chbYes.CheckedChanged
        Me.gbYES.Visible = chbYes.Checked
        If Me.gbYES.Visible = True Then
            Me.gbYES.Focus()
        Else
            resetAllControls(gbYES)
        End If
    End Sub

    Private Sub resetAllControls(ByVal container As Control)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is RadioButton Then
                DirectCast(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is CheckBox Then
                DirectCast(ctrl, CheckBox).Checked = False
            End If
            'If ctrl.Controls.Count > 0 Then
            '    resetAllControls(ctrl)
            'End If
        Next
    End Sub

    Private Sub cbAMV_CheckedChanged(sender As Object, e As EventArgs) Handles cbAMV.CheckedChanged
        Me.lblAMVF2.Visible = cbAMV.Checked
        Me.lblAMVF3.Visible = cbAMV.Checked
        Me.txtAMVF2.Visible = cbAMV.Checked
        Me.txtAMVF3.Visible = cbAMV.Checked

        If cbAMV.Checked = False Then
            Me.txtAMVF2.Text = ""
            Me.txtAMVF3.Text = ""
        Else
            If Me.txtAMVF3.Visible = True Then Me.txtAMVF2.Focus()
        End If

    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        If chbRO.Checked = True Then chbNTS.Checked = True

        Dim strW As String = ""
        Dim trk() As String = pp(3).Split(".")
        Dim currenttab As Integer : Dim currentred As Integer : Dim currentkol As Integer
        Dim ttab As Boolean = False
        Dim pI As String = ""
        Dim fforma As String = ""

        If trk.Length = 3 Then
            ''ako je tabela
            ttab = True
            currenttab = CInt(trk(0).Trim)
            currentred = CInt(trk(1).Trim)
            currentkol = CInt(trk(2).Trim)
        End If

        Try
            Dim strIST As String = ""
            Dim strS As String = ""
            Me.Cursor = Cursors.WaitCursor

            If ttab = True AndAlso (cb2.Checked = True OrElse cb3.Checked = True OrElse cb4.Checked = True) Then                ''ako je tabela
                If cb2.Checked = True Then fforma = CStr(currenttab).Trim + "." + CStr(currentred).Trim + ".%" 'row
                If cb3.Checked = True Then fforma = CStr(currenttab).Trim + ".%." + CStr(currentkol).Trim 'column
                If cb4.Checked = True Then fforma = CStr(currenttab).Trim + ".%" 'table
                strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"

                Dim dt As System.Data.DataTable = getDTCtabela(strW)
                If dt.Rows.Count > 0 Then

                    For i As Integer = 0 To dt.Rows.Count - 1
                        strS = ""
                        Dim pizraz As String = setMetaDataPaneP3_3(dt.Rows(i).Item("izraz").ToString.Trim)
                        Dim odost As String = odOSTatak(dt.Rows(i).Item("od").ToString.Trim)
                        Dim pod As String = setMetaDataPaneP5_5(dt.Rows(i).Item("od").ToString.Trim, odost)
                        Dim pDG As String = setMetaDataPaneDG()
                        If pod.Trim <> "" Then strS = strS + " od=N'#{" + pod + "}'"
                        If pizraz.Trim <> "" Then strS = strS + ", izraz=N'" + pizraz + "'"
                        If Me.txtDG.Text.Trim <> "" Then strS = strS + " DG=N'" + pDG + "'"
                        strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                        " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod").ToString.Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                        strIST = strIST + " update istpolja set " + nvrd + strS.TrimStart(",") + nvrd + strW + nvrd
                    Next
                End If

            End If

            If cb1.Checked = True Then
                strS = ""
                Dim pizraz As String = setMetaDataPaneP3()
                Dim pod As String = setMetaDataPaneP5()
                Dim pDG As String = setMetaDataPaneDG()

                strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                "' and polje=N'" + pp(2).Trim + "'" +
                "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"

                If pod.Trim <> "" Then strS = strS + " od=N'#{" + pod + "}'"
                strS = strS + ", izraz=N'" + pizraz + "'"
                strS = strS + ", DG=N'" + pDG + "'"

                strIST = " update istpolja set " + nvrd + strS.TrimStart(",") + nvrd + strW + nvrd

            End If

            pI = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strIST)

            Me.Cursor = Cursors.Default

            If pI = "ok" Then
                Me.Close()
            Else
                ISTMessageBox.Show("Error")
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub getMetaDataPaneP5()

        If od = "" Then Exit Sub
        odOst = ""
        Dim ood As String = od
        If od.IndexOf("#{") >= 0 Then
            Dim ind2 As Integer = od.IndexOf("#{")
            Dim poc As String = od.Substring(0, ind2)
            Dim kraj As String = od.Substring(ind2 + 2)
            kraj = kraj.TrimEnd("}")
            ood = poc + ";" + kraj
        End If
        Dim ppp() As String = ood.Split(";")
        Dim req As String = ""
        Dim min As String = ""
        Dim max As String = ""
        Dim minL As String = ""
        Dim maxL As String = ""
        Dim pagedownto As String = ""
        Dim exec As String = ""
        Dim decpart As String = ""
        Dim misingvalue As String = ""
        Dim allowed As String = ""
        Dim notallowed As String = ""
        Dim f2 As String = ""
        Dim f3 As String = ""

        Dim a As Integer = 0
        For i As Integer = 0 To ppp.GetUpperBound(0)
            If ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("NOTABSTOP") = 0 Then
                chbNTS.Checked = True
            ElseIf ppp(i).Length > 6 AndAlso ppp(i).Trim.ToUpper.IndexOf("WARNING") = 0 OrElse ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("UPOZORENJE") >= 0 Then
                chbWarning.Checked = True
            ElseIf ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("REQUREDIF") = 0 OrElse ppp(i).Length > 10 AndAlso ppp(i).Trim.ToUpper.IndexOf("OBAVEZNOAKO") >= 0 Then
                Dim rq As String = ppp(i).Trim.ToUpper.Replace("REQUREDIF=", "").Replace("OBAVEZNOAKO=", "")
                txtRif.Text = rq
                req = getttt(ppp(i), "REQUREDIF")
            ElseIf ppp(i).Length > 2 AndAlso ppp(i).Trim.ToUpper.IndexOf("MIN") = 0 Then
                Dim mn As String = ppp(i).Trim.ToUpper.Replace("MIN=", "")
                txtMin.Text = mn
                min = getttt(ppp(i), "MIN")
            ElseIf ppp(i).Length > 2 AndAlso ppp(i).Trim.ToUpper.IndexOf("MAX") = 0 Then
                Dim mx As String = ppp(i).Trim.ToUpper.Replace("MAX=", "")
                txtMax.Text = mx
                max = getttt(ppp(i), "MAX")
            ElseIf ppp(i).Length > 7 AndAlso (ppp(i).Trim.ToUpper.IndexOf("MNLENGTH") = 0 OrElse ppp(i).Trim.ToUpper.IndexOf("MNDUZINA") >= 0) Then
                Dim mnl As String = ppp(i).Trim.ToUpper.Replace("MNLENGTH=", "").Replace("MNDUZINA=", "")
                txtMinL.Text = mnl
                minL = getttt(ppp(i), "MNLENGTH")
            ElseIf ppp(i).Length > 7 AndAlso (ppp(i).Trim.ToUpper.IndexOf("MXLENGTH") = 0 OrElse ppp(i).Trim.ToUpper.IndexOf("MXDUZINA") >= 0) Then
                Dim mxl As String = ppp(i).Trim.ToUpper.Replace("MXLENGTH=", "").Replace("MXDUZINA=", "")
                txtMaxL.Text = mxl
                maxL = getttt(ppp(i), "MXLENGTH")
            ElseIf ppp(i).Length > 6 AndAlso ppp(i).Trim.ToUpper.IndexOf("DECPART") = 0 Then
                Dim dp As String = ppp(i).Trim.ToUpper.Replace("DECPART=", "")
                txtDP.Text = dp
                decpart = getttt(ppp(i), "DECPART")
            ElseIf ppp(i).Length > 1 AndAlso (ppp(i).Trim.ToUpper.IndexOf("NO") = 0 OrElse ppp(i).Trim.ToUpper.IndexOf("NE") = 0) Then
                chbNO.Checked = True
                Dim na As String = ""
                na = Replace(ppp(i), "no=", "", 1, , CompareMethod.Text)
                na = Replace(na, "ne=", "", 1, , CompareMethod.Text)
                If na = "" Then
                    chbNoNotEmpty.Checked = True
                Else
                    txtNoSpec.Text = na.TrimStart(",")
                    If na.IndexOf(",") = 0 Then
                        chbNoNotEmpty.Checked = True
                    Else
                        Dim opo() As String = na.Split(",")
                        For nn As Integer = 0 To opo.GetUpperBound(0)
                            If opo(nn).Trim = "" Then chbNoNotEmpty.Checked = True : Exit For
                        Next
                    End If
                End If
                notallowed = getttt(ppp(i), "NO")
            ElseIf ppp(i).Length > 2 AndAlso ppp(i).Trim.ToUpper.IndexOf("YES") = 0 OrElse ppp(i).Length > 1 AndAlso ppp(i).Trim.ToUpper.IndexOf("DA") = 0 Then
                Dim al As String = ppp(i).Trim.ToUpper.Replace("YES=", "").Replace("DA=", "")
                If al = "NUMERIC" Then
                    rbYesN.Checked = True
                    chbYes.Checked = True
                ElseIf al = "ALPHANUMERIC" Then
                    rbYesAN.Checked = True
                    chbYes.Checked = True
                ElseIf al = "ALPHA" Then
                    rbYesA.Checked = True
                    chbYes.Checked = True
                ElseIf al = "DATE" Then
                    rbYesDate.Checked = True
                    chbYes.Checked = True
                ElseIf al = "ISTDATE" Then
                    rbYesISTDate.Checked = True
                    chbYes.Checked = True
                ElseIf al = "TIME" Then
                    rbYesTime.Checked = True
                    chbYes.Checked = True
                Else
                    rbYesSpec.Checked = True
                    txtYesSpec.Text = al
                    chbYes.Checked = True
                    allowed = getttt(ppp(i), "YES")
                End If
            ElseIf ppp(i).Length > 13 AndAlso ppp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE") = 0 Then
                ppp(i) = ppp(i).Trim.ToUpper.Replace("ADDMISSINGVALUE", "")
                Dim f2f3() As String = ppp(i).Split("=")
                If f2f3(0).Trim.ToUpper = "F2" Then
                    If f2f3(1).Trim.ToUpper.IndexOf("F3") >= 0 Then
                        Dim pom() As String = f2f3(1).Split("F3")
                        If pom.Length = 2 Then
                            f3 = f2f3(2)
                            f2 = pom(0).Replace("F3=", "")
                        End If
                        If pom.Length = 1 Then
                            f2 = pom(0)
                        End If
                    Else
                        f2 = f2f3(1)
                        f2 = f2.TrimEnd("F3")
                    End If
                Else
                    If f2f3(1).Trim.ToUpper.IndexOf("F2") >= 0 Then
                        Dim pom() As String = f2f3(1).Split("F2")
                        If pom.Length = 2 Then
                            f2 = f2f3(2)
                            f3 = pom(0).Replace("F2=", "")
                        End If
                        If pom.Length = 1 Then
                            f3 = pom(0)
                        End If
                    Else
                        f3 = f2f3(1)
                    End If
                End If
                txtAMVF2.Text = f2
                txtAMVF3.Text = f3
                cbAMV.Checked = True
            ElseIf ppp(i).Trim <> "" Then
                odOst = odOst + ";" + ppp(i).Trim
            End If
        Next
        odOst = odOst.TrimStart(";")
        If f2 <> "" OrElse f3 <> "" Then
            cbAMV.Checked = True
            txtAMVF2.Visible = True
            txtAMVF3.Visible = True
        End If
    End Sub

    Function odOSTatak(ByVal od As String) As String
        odOst = ""
        If od = "" Then Return odOst : Exit Function
        Dim ood As String = od
        If od.IndexOf("#{") >= 0 Then
            Dim ind2 As Integer = od.IndexOf("#{")
            Dim poc As String = od.Substring(0, ind2)
            Dim kraj As String = od.Substring(ind2 + 2)
            kraj = kraj.TrimEnd("}")
            ood = poc + ";" + kraj
        End If
        Dim ppp() As String = ood.Split(";")
        Dim req As String = ""
        Dim min As String = ""
        Dim max As String = ""
        Dim minL As String = ""
        Dim maxL As String = ""
        Dim pagedownto As String = ""
        Dim exec As String = ""
        Dim decpart As String = ""
        Dim misingvalue As String = ""
        Dim allowed As String = ""
        Dim notallowed As String = ""
        Dim f2 As String = ""
        Dim f3 As String = ""

        Dim a As Integer = 0
        For i As Integer = 0 To ppp.GetUpperBound(0)
            If ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("NOTABSTOP") = 0 Then
            ElseIf ppp(i).Length > 6 AndAlso ppp(i).Trim.ToUpper.IndexOf("WARNING") = 0 OrElse ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("UPOZORENJE") >= 0 Then
            ElseIf ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("REQUREDIF") = 0 OrElse ppp(i).Length > 10 AndAlso ppp(i).Trim.ToUpper.IndexOf("OBAVEZNOAKO") >= 0 Then
            ElseIf ppp(i).Length > 2 AndAlso ppp(i).Trim.ToUpper.IndexOf("MIN") = 0 Then
            ElseIf ppp(i).Length > 2 AndAlso ppp(i).Trim.ToUpper.IndexOf("MAX") = 0 Then
            ElseIf ppp(i).Length > 7 AndAlso (ppp(i).Trim.ToUpper.IndexOf("MNLENGTH") = 0 OrElse ppp(i).Trim.ToUpper.IndexOf("MNDUZINA") >= 0) Then
            ElseIf ppp(i).Length > 7 AndAlso (ppp(i).Trim.ToUpper.IndexOf("MXLENGTH") = 0 OrElse ppp(i).Trim.ToUpper.IndexOf("MXDUZINA") >= 0) Then
            ElseIf ppp(i).Length > 6 AndAlso ppp(i).Trim.ToUpper.IndexOf("DECPART") = 0 Then
            ElseIf ppp(i).Length > 1 AndAlso (ppp(i).Trim.ToUpper.IndexOf("NO") = 0 OrElse ppp(i).Trim.ToUpper.IndexOf("NE") = 0) Then
            ElseIf ppp(i).Length > 2 AndAlso ppp(i).Trim.ToUpper.IndexOf("YES") = 0 OrElse ppp(i).Length > 1 AndAlso ppp(i).Trim.ToUpper.IndexOf("DA") = 0 Then
            ElseIf ppp(i).Length > 13 AndAlso ppp(i).Trim.ToUpper.IndexOf("ADDMISSINGVALUE") = 0 Then
            ElseIf ppp(i).Trim <> "" Then
                odOst = odOst + ";" + ppp(i).Trim
            End If
        Next
        odOst = odOst.TrimStart(";")

        Return odOst

    End Function

    Dim columnAtributesOst As String = ""

    Sub getMetaDataPaneP3()

        Dim multilineheight As String = ""
        Dim ccolumnAtributes As String = formatizraz
        If ccolumnAtributes.Trim = "" Then Exit Sub
        columnAtributesOst = ""
        ccolumnAtributes = Replace(ccolumnAtributes, "multiline", "multiline" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "readonly", "readonly" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "visiblefalse", "visiblefalse" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = Replace(ccolumnAtributes, "enablefalse", "enablefalse" + "$", 1, , CompareMethod.Text)
        ccolumnAtributes = ccolumnAtributes.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")

        Dim ppp() As String = ccolumnAtributes.Split("$")
        For i As Integer = 0 To ppp.GetUpperBound(0)
            If ppp(i).Trim = "" Then
            ElseIf ppp(i).Length > 14 AndAlso ppp(i).Trim.ToUpper.IndexOf("MULTILINEHEIGHT") = 0 Then
                Dim mlh As String = ppp(i).Trim.ToUpper.Replace("MULTILINEHEIGHT", "")
                txtMultilineH.Text = mlh
                chbMultilineH.Checked = True
                multilineheight = getttt(ppp(i), "MULTILINEHEIGHT")
            ElseIf ppp(i).Length > 7 AndAlso ppp(i).Trim.ToUpper.IndexOf("READONLY") = 0 Then
                chbRO.Checked = True
            ElseIf ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("MULTILINE") = 0 Then
                chbMultiline.Checked = True
            ElseIf ppp(i).Length > 11 AndAlso ppp(i).Trim.ToUpper.IndexOf("VISIBLEFALSE") = 0 Then
                chbVF.Checked = True
            ElseIf ppp(i).Length > 10 AndAlso ppp(i).Trim.ToUpper.IndexOf("ENABLEFALSE") = 0 Then
                chbEF.Checked = True
            ElseIf ppp(i).Length > 1 AndAlso ppp(i).Trim.ToUpper.IndexOf("'") = 0 Then
                'izraz
            ElseIf ppp(i).Trim <> "" Then
                columnAtributesOst = columnAtributesOst + "$" + ppp(i).Trim
            End If
        Next
        columnAtributesOst = columnAtributesOst.TrimStart("$")
    End Sub

    Sub getMetaDataPaneDG()
        Dim ddefaultvalue As String = DG
        If ddefaultvalue.Trim = "" Then Exit Sub
        Me.txtDG.Text = ddefaultvalue
    End Sub

    'Function getttt(ByVal text As String, ByVal what As String) As String
    '    getttt = ""
    '    If text.Trim.ToUpper.IndexOf(what) >= 0 Then
    '        Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
    '        getttt = text.Trim.ToUpper.Substring(b + what.Length)
    '    End If
    'End Function

    Function setMetaDataPaneP3() As String
        'izraz
        Dim pom As String = ""
        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso DirectCast(k, CheckBox).Name <> "chbNTS" AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim.ToUpper + "$"
            End If
        Next

        If chbMultilineH.Checked = True Then pom = pom + "multilineheight" + txtMultilineH.Text + "$"

        'fontBold$fontItalic$#{select 888}
        'fontBold$fontItalic$'888'

        If pom.Trim = "" AndAlso izraz.Trim = "" Then
        ElseIf pom = "" AndAlso izraz.Trim <> "" Then
            If izraz.Trim.Substring(0, 1) = "'" Then pom = "'" + izraz + "'"
            If izraz.Trim.Substring(0, 1) <> "'" Then pom = izraz
        ElseIf pom <> "" AndAlso izraz = "" Then
            'pom = pom
        ElseIf pom <> "" AndAlso izraz <> "" Then
            If izraz.Trim.Substring(0, 1) = "'" Then pom = pom + "$'" + izraz + "'"
            If izraz.Trim.Substring(0, 1) <> "'" Then pom = pom + "$" + izraz + ""
        End If

        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
        Return pom
    End Function

    Function setMetaDataPaneP3_3(ByVal izraz As String) As String
        'izraz
        Dim pom As String = ""
        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim.ToUpper + "$"
            End If
        Next

        If chbMultilineH.Checked = True Then pom = pom + "multilineheight" + txtMultilineH.Text + "$"

        'fontBold$fontItalic$#{select 888}
        'fontBold$fontItalic$'888'
        'If izraz <> "" Then izraz = izraz.Replace("'", "''")
        If izraz <> "" AndAlso izraz.Trim.Substring(0, 1) = "'" Then pom = pom + "$'" + izraz + "'"
        If izraz <> "" AndAlso izraz.Trim.Substring(0, 1) <> "'" Then pom = pom + "$" + izraz + ""

        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
        Return pom
    End Function

    Function setMetaDataPaneP5() As String
        'od (validating event)
        Dim pom As String = ""

        'If chbReq.Checked = True Then pom = pom + "requredif=" + txtReq.Text + ";"
        If txtMinL.Text.Trim <> "" Then pom = pom + "MNLength=" + txtMinL.Text + ";"
        If txtMaxL.Text.Trim <> "" Then pom = pom + "MXLength=" + txtMaxL.Text + ";"
        If txtMin.Text.Trim <> "" Then pom = pom + "min=" + txtMin.Text + ";"
        If txtMax.Text.Trim <> "" Then pom = pom + "max=" + txtMax.Text + ";"
        If txtDP.Text.Trim <> "" Then pom = pom + "decpart=" + txtDP.Text + ";"
        If chbNTS.Checked = True Then pom = pom + "noTabStop" + ";"

        If cbAMV.Checked = True AndAlso txtAMVF2.Text <> "" AndAlso txtAMVF3.Text <> "" Then
            pom = pom + "ADDMISSINGVALUEF2=" + txtAMVF2.Text + "F3=" + txtAMVF3.Text + ";"
        ElseIf cbAMV.Checked = True AndAlso txtAMVF2.Text <> "" AndAlso txtAMVF3.Text = "" Then
            pom = pom + "ADDMISSINGVALUEF2=" + txtAMVF2.Text + ";"
        ElseIf cbAMV.Checked = True AndAlso txtAMVF2.Text = "" AndAlso txtAMVF3.Text <> "" Then
            pom = pom + "ADDMISSINGVALUEF3=" + txtAMVF3.Text + ";"
        End If

        Dim nn As String = ""

        If chbNO.Checked = True Then
            If txtNoSpec.Text <> "" Then nn = nn + txtNoSpec.Text.TrimEnd(",")
            If chbNoNotEmpty.Checked = True Then nn = "," + nn
            If nn <> "" Then pom = pom + "No=" + nn + ";"
        End If

        If chbYes.Checked = True AndAlso rbYesN.Checked = True Then
            pom = pom + "Yes=Numeric;"
        ElseIf chbYes.Checked = True AndAlso rbYesAN.Checked = True Then
            pom = pom + "Yes=AlphaNumeric;"
        ElseIf chbYes.Checked = True AndAlso rbYesA.Checked = True Then
            pom = pom + "Yes=Alpha;"
        ElseIf chbYes.Checked = True AndAlso rbYesDate.Checked = True Then
            pom = pom + "Yes=Date;"
        ElseIf chbYes.Checked = True AndAlso rbYesISTDate.Checked = True Then
            pom = pom + "Yes=ISTDate;"
        ElseIf chbYes.Checked = True AndAlso rbYesTime.Checked = True Then
            pom = pom + "Yes=Time;"
        ElseIf chbYes.Checked = True AndAlso rbYesSpec.Checked = True AndAlso txtYesSpec.Text <> "" Then
            pom = pom + "Yes=" + txtYesSpec.Text.TrimEnd(",") + ";"
        End If

        If pom.Trim = "" AndAlso odOst.Trim = "" Then
        ElseIf pom = "" AndAlso odOst.Trim <> "" Then
            pom = odOst
        ElseIf pom <> "" AndAlso odOst = "" Then
            'pom = pom
        ElseIf pom <> "" AndAlso odOst <> "" Then
            pom = pom + ";" + odOst
        End If
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
        Return pom
    End Function

    Function setMetaDataPaneP5_5(ByVal od As String, ByVal odOst As String) As String
        'od (validating event)
        Dim pom As String = ""

        'If chbReq.Checked = True Then pom = pom + "requredif=" + txtReq.Text + ";"
        If txtMinL.Text.Trim <> "" Then pom = pom + "MNLength=" + txtMinL.Text + ";"
        If txtMaxL.Text.Trim <> "" Then pom = pom + "MXLength=" + txtMaxL.Text + ";"
        If txtMin.Text.Trim <> "" Then pom = pom + "min=" + txtMin.Text + ";"
        If txtMax.Text.Trim <> "" Then pom = pom + "max=" + txtMax.Text + ";"
        If txtDP.Text.Trim <> "" Then pom = pom + "decpart=" + txtDP.Text + ";"
        If txtRif.Text.Trim <> "" Then pom = pom + "requiredif=" + txtRif.Text + ";"
        If chbNTS.Checked = True Then pom = pom + "noTabStop" + ";"

        If cbAMV.Checked = True AndAlso txtAMVF2.Text <> "" AndAlso txtAMVF3.Text <> "" Then
            pom = pom + "ADDMISSINGVALUEF2=" + txtAMVF2.Text + "F3=" + txtAMVF3.Text + ";"
        ElseIf cbAMV.Checked = True AndAlso txtAMVF2.Text <> "" AndAlso txtAMVF3.Text = "" Then
            pom = pom + "ADDMISSINGVALUEF2=" + txtAMVF2.Text + ";"
        ElseIf cbAMV.Checked = True AndAlso txtAMVF2.Text = "" AndAlso txtAMVF3.Text <> "" Then
            pom = pom + "ADDMISSINGVALUEF3=" + txtAMVF3.Text + ";"
        End If

        Dim nn As String = ""

        If chbNO.Checked = True Then
            If txtNoSpec.Text <> "" Then nn = nn + txtNoSpec.Text.TrimEnd(",")
            If chbNoNotEmpty.Checked = True Then nn = "," + nn
            If nn <> "" Then pom = pom + "No=" + nn + ";"
        End If

        If chbYes.Checked = True AndAlso rbYesN.Checked = True Then
            pom = pom + "Yes=Numeric;"
        ElseIf chbYes.Checked = True AndAlso rbYesAN.Checked = True Then
            pom = pom + "Yes=AlphaNumeric;"
        ElseIf chbYes.Checked = True AndAlso rbYesA.Checked = True Then
            pom = pom + "Yes=Alpha;"
        ElseIf chbYes.Checked = True AndAlso rbYesDate.Checked = True Then
            pom = pom + "Yes=Date;"
        ElseIf chbYes.Checked = True AndAlso rbYesISTDate.Checked = True Then
            pom = pom + "Yes=ISTDate;"
        ElseIf chbYes.Checked = True AndAlso rbYesTime.Checked = True Then
            pom = pom + "Yes=Time;"
        ElseIf chbYes.Checked = True AndAlso rbYesSpec.Checked = True AndAlso txtYesSpec.Text <> "" Then
            pom = pom + "Yes=" + txtYesSpec.Text.TrimEnd(",") + ";"
        End If

        If pom.Trim = "" AndAlso odOst.Trim = "" Then
        ElseIf pom = "" AndAlso odOst.Trim <> "" Then
            pom = odOst
        ElseIf pom <> "" AndAlso odOst = "" Then
            'pom = pom
        ElseIf pom <> "" AndAlso odOst <> "" Then
            pom = pom + ";" + odOst
        End If
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
        Return pom
    End Function

    Function setMetaDataPaneDG() As String
        Dim pom As String = ""
        If Me.txtDG.Text.Trim <> "" Then pom = Me.txtDG.Text.Trim.TrimEnd("'").TrimStart("'")
        Return pom
    End Function

    Private Sub chbRO_CheckedChanged(sender As Object, e As EventArgs) Handles chbRO.CheckedChanged
        If chbRO.Checked = True Then Me.chbNTS.Checked = True : chbNTS.Enabled = False
        If chbRO.Checked = False Then Me.chbNTS.Checked = False : chbNTS.Enabled = True
    End Sub

End Class