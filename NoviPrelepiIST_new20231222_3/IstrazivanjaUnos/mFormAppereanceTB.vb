'Option Strict Off
Public Class mFormAppereanceTB
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents chbBN As CheckBox
    Friend WithEvents cbe4 As CheckBox
    Friend WithEvents chbRight As CheckBox
    Friend WithEvents chbCenter As CheckBox
    Friend WithEvents cbBC As CheckBox
    Friend WithEvents cbFC As CheckBox
    Friend WithEvents cbe1 As CheckBox
    Friend WithEvents cbe2 As CheckBox
    Friend WithEvents chbBF As CheckBox
    Friend WithEvents cbB As CheckBox
    Friend WithEvents cbI As CheckBox
    Friend WithEvents cbU As CheckBox
    Friend WithEvents cbe51 As TextBox
    Friend WithEvents cbe6 As CheckBox
    Friend WithEvents cbe3 As CheckBox
    Friend WithEvents cbe5 As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVS1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Mkc_ColorComboboxBC As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorComboboxFC As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbF As CheckBox
    Friend WithEvents ttekst As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVS2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbFS As TextBox
    Friend WithEvents BtnAWL As Button
    Friend WithEvents btnOKCPE As Button
    Friend WithEvents btnCancelCPE As Button
    Friend WithEvents PanelCPE As Panel
    Friend WithEvents dgvCPE As DataGridView
    Friend WithEvents BtnQE As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbC As CheckBox
    Friend WithEvents gbB As GroupBox
    Friend WithEvents cbW As CheckBox
    Friend WithEvents tbW As TextBox
    Friend WithEvents tbH As TextBox
    Friend WithEvents cbH As CheckBox
    Friend WithEvents gbWH As GroupBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbBN = New System.Windows.Forms.CheckBox()
        Me.cbe4 = New System.Windows.Forms.CheckBox()
        Me.chbRight = New System.Windows.Forms.CheckBox()
        Me.chbCenter = New System.Windows.Forms.CheckBox()
        Me.cbBC = New System.Windows.Forms.CheckBox()
        Me.cbFC = New System.Windows.Forms.CheckBox()
        Me.cbe1 = New System.Windows.Forms.CheckBox()
        Me.cbe2 = New System.Windows.Forms.CheckBox()
        Me.chbBF = New System.Windows.Forms.CheckBox()
        Me.cbB = New System.Windows.Forms.CheckBox()
        Me.cbI = New System.Windows.Forms.CheckBox()
        Me.cbU = New System.Windows.Forms.CheckBox()
        Me.cbe51 = New System.Windows.Forms.TextBox()
        Me.cbe6 = New System.Windows.Forms.CheckBox()
        Me.cbe3 = New System.Windows.Forms.CheckBox()
        Me.cbe5 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVS1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Mkc_ColorComboboxBC = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorComboboxFC = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbF = New System.Windows.Forms.CheckBox()
        Me.ttekst = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVS2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbFS = New System.Windows.Forms.TextBox()
        Me.BtnAWL = New System.Windows.Forms.Button()
        Me.btnOKCPE = New System.Windows.Forms.Button()
        Me.btnCancelCPE = New System.Windows.Forms.Button()
        Me.PanelCPE = New System.Windows.Forms.Panel()
        Me.dgvCPE = New System.Windows.Forms.DataGridView()
        Me.BtnQE = New System.Windows.Forms.Button()
        Me.cbC = New System.Windows.Forms.CheckBox()
        Me.gbB = New System.Windows.Forms.GroupBox()
        Me.cbW = New System.Windows.Forms.CheckBox()
        Me.tbW = New System.Windows.Forms.TextBox()
        Me.tbH = New System.Windows.Forms.TextBox()
        Me.cbH = New System.Windows.Forms.CheckBox()
        Me.gbWH = New System.Windows.Forms.GroupBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.PanelCPE.SuspendLayout()
        CType(Me.dgvCPE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbB.SuspendLayout()
        Me.gbWH.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(562, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(193, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.Text = "Set appereance"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Text box and virtual field appereance"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 513)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 30)
        Me.Panel1.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCancel.Location = New System.Drawing.Point(362, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(193, 24)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(768, 25)
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
        Me.gbOptions.Size = New System.Drawing.Size(185, 114)
        Me.gbOptions.TabIndex = 40
        Me.gbOptions.TabStop = False
        '
        'cb4
        '
        Me.cb4.AccessibleDescription = " "
        Me.cb4.AutoSize = True
        Me.cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb4.Location = New System.Drawing.Point(13, 86)
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
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(5, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Appereance"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(13, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Font"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(402, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Text aligment"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(275, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Border style"
        '
        'chbBN
        '
        Me.chbBN.AccessibleName = "borderNone"
        Me.chbBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBN.Location = New System.Drawing.Point(292, 168)
        Me.chbBN.Name = "chbBN"
        Me.chbBN.Size = New System.Drawing.Size(75, 19)
        Me.chbBN.TabIndex = 264
        Me.chbBN.Text = "None"
        '
        'cbe4
        '
        Me.cbe4.AccessibleName = ""
        Me.cbe4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe4.Location = New System.Drawing.Point(23, 117)
        Me.cbe4.Name = "cbe4"
        Me.cbe4.Size = New System.Drawing.Size(103, 20)
        Me.cbe4.TabIndex = 278
        Me.cbe4.Text = "No tab stop"
        '
        'chbRight
        '
        Me.chbRight.AccessibleName = "fRightA"
        Me.chbRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRight.Location = New System.Drawing.Point(423, 143)
        Me.chbRight.Name = "chbRight"
        Me.chbRight.Size = New System.Drawing.Size(82, 19)
        Me.chbRight.TabIndex = 271
        Me.chbRight.Text = "Right"
        '
        'chbCenter
        '
        Me.chbCenter.AccessibleName = "fCenterA"
        Me.chbCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCenter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCenter.Location = New System.Drawing.Point(423, 168)
        Me.chbCenter.Name = "chbCenter"
        Me.chbCenter.Size = New System.Drawing.Size(82, 19)
        Me.chbCenter.TabIndex = 270
        Me.chbCenter.Text = "Center"
        '
        'cbBC
        '
        Me.cbBC.AccessibleName = ""
        Me.cbBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBC.Location = New System.Drawing.Point(7, 267)
        Me.cbBC.Name = "cbBC"
        Me.cbBC.Size = New System.Drawing.Size(92, 19)
        Me.cbBC.TabIndex = 269
        Me.cbBC.Text = "Back color"
        '
        'cbFC
        '
        Me.cbFC.AccessibleName = ""
        Me.cbFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFC.Location = New System.Drawing.Point(7, 242)
        Me.cbFC.Name = "cbFC"
        Me.cbFC.Size = New System.Drawing.Size(92, 19)
        Me.cbFC.TabIndex = 268
        Me.cbFC.Text = "Fore color"
        '
        'cbe1
        '
        Me.cbe1.AccessibleName = "visibleFalse"
        Me.cbe1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe1.Location = New System.Drawing.Point(23, 42)
        Me.cbe1.Name = "cbe1"
        Me.cbe1.Size = New System.Drawing.Size(103, 19)
        Me.cbe1.TabIndex = 267
        Me.cbe1.Text = "Visible false"
        '
        'cbe2
        '
        Me.cbe2.AccessibleName = "enabledFalse"
        Me.cbe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe2.Location = New System.Drawing.Point(23, 67)
        Me.cbe2.Name = "cbe2"
        Me.cbe2.Size = New System.Drawing.Size(103, 19)
        Me.cbe2.TabIndex = 266
        Me.cbe2.Text = "Enable false"
        '
        'chbBF
        '
        Me.chbBF.AccessibleName = "borderFixed"
        Me.chbBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBF.Location = New System.Drawing.Point(292, 143)
        Me.chbBF.Name = "chbBF"
        Me.chbBF.Size = New System.Drawing.Size(95, 19)
        Me.chbBF.TabIndex = 265
        Me.chbBF.Text = "Fixed single"
        '
        'cbB
        '
        Me.cbB.AccessibleName = "fontBold"
        Me.cbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbB.Location = New System.Drawing.Point(7, 217)
        Me.cbB.Name = "cbB"
        Me.cbB.Size = New System.Drawing.Size(60, 19)
        Me.cbB.TabIndex = 263
        Me.cbB.Text = "Bold"
        '
        'cbI
        '
        Me.cbI.AccessibleName = "fontItalic"
        Me.cbI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbI.Location = New System.Drawing.Point(72, 217)
        Me.cbI.Name = "cbI"
        Me.cbI.Size = New System.Drawing.Size(56, 19)
        Me.cbI.TabIndex = 262
        Me.cbI.Text = "Italic"
        '
        'cbU
        '
        Me.cbU.AccessibleName = "fontUnderline"
        Me.cbU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbU.Location = New System.Drawing.Point(133, 217)
        Me.cbU.Name = "cbU"
        Me.cbU.Size = New System.Drawing.Size(92, 19)
        Me.cbU.TabIndex = 261
        Me.cbU.Text = "Underline"
        '
        'cbe51
        '
        Me.cbe51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbe51.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe51.Location = New System.Drawing.Point(174, 142)
        Me.cbe51.Name = "cbe51"
        Me.cbe51.Size = New System.Drawing.Size(50, 21)
        Me.cbe51.TabIndex = 260
        '
        'cbe6
        '
        Me.cbe6.AccessibleName = "multiline"
        Me.cbe6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe6.Location = New System.Drawing.Point(23, 168)
        Me.cbe6.Name = "cbe6"
        Me.cbe6.Size = New System.Drawing.Size(103, 19)
        Me.cbe6.TabIndex = 258
        Me.cbe6.Text = "Multiline"
        '
        'cbe3
        '
        Me.cbe3.AccessibleName = "readOnly"
        Me.cbe3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe3.Location = New System.Drawing.Point(23, 92)
        Me.cbe3.Name = "cbe3"
        Me.cbe3.Size = New System.Drawing.Size(103, 19)
        Me.cbe3.TabIndex = 257
        Me.cbe3.Text = "Read Only*"
        '
        'cbe5
        '
        Me.cbe5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe5.Location = New System.Drawing.Point(23, 143)
        Me.cbe5.Name = "cbe5"
        Me.cbe5.Size = New System.Drawing.Size(145, 19)
        Me.cbe5.TabIndex = 259
        Me.cbe5.Text = "Multiline height in px"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 279
        Me.Label6.Text = "Behavior"
        '
        'txtVS1
        '
        Me.txtVS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVS1.Location = New System.Drawing.Point(133, 43)
        Me.txtVS1.Name = "txtVS1"
        Me.txtVS1.Size = New System.Drawing.Size(110, 21)
        Me.txtVS1.TabIndex = 280
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(133, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 20)
        Me.Label7.TabIndex = 281
        Me.Label7.Text = "Width"
        '
        'Mkc_ColorComboboxBC
        '
        Me.Mkc_ColorComboboxBC.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorComboboxBC.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorComboboxBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorComboboxBC.Location = New System.Drawing.Point(97, 267)
        Me.Mkc_ColorComboboxBC.Name = "Mkc_ColorComboboxBC"
        Me.Mkc_ColorComboboxBC.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorComboboxBC.Size = New System.Drawing.Size(144, 21)
        Me.Mkc_ColorComboboxBC.TabIndex = 283
        Me.Mkc_ColorComboboxBC.Visible = False
        '
        'Mkc_ColorComboboxFC
        '
        Me.Mkc_ColorComboboxFC.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorComboboxFC.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorComboboxFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorComboboxFC.Location = New System.Drawing.Point(97, 242)
        Me.Mkc_ColorComboboxFC.Name = "Mkc_ColorComboboxFC"
        Me.Mkc_ColorComboboxFC.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorComboboxFC.Size = New System.Drawing.Size(144, 21)
        Me.Mkc_ColorComboboxFC.TabIndex = 282
        Me.Mkc_ColorComboboxFC.Tag = "VF"
        Me.Mkc_ColorComboboxFC.Visible = False
        '
        'cbF
        '
        Me.cbF.AccessibleName = ""
        Me.cbF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbF.Location = New System.Drawing.Point(7, 293)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(84, 19)
        Me.cbF.TabIndex = 284
        Me.cbF.Text = "Font size"
        '
        'ttekst
        '
        Me.ttekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ttekst.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttekst.Location = New System.Drawing.Point(288, 27)
        Me.ttekst.Multiline = True
        Me.ttekst.Name = "ttekst"
        Me.ttekst.Size = New System.Drawing.Size(471, 76)
        Me.ttekst.TabIndex = 286
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(227, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 287
        Me.Label8.Text = "Text"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(133, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 20)
        Me.Label9.TabIndex = 289
        Me.Label9.Text = "Height"
        '
        'txtVS2
        '
        Me.txtVS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVS2.Location = New System.Drawing.Point(133, 91)
        Me.txtVS2.Name = "txtVS2"
        Me.txtVS2.Size = New System.Drawing.Size(110, 21)
        Me.txtVS2.TabIndex = 288
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(262, 404)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(346, 13)
        Me.Label10.TabIndex = 349
        Me.Label10.Text = "*Read only fields will have No Tab Stop=True automatically"
        '
        'cbFS
        '
        Me.cbFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFS.Location = New System.Drawing.Point(97, 293)
        Me.cbFS.Name = "cbFS"
        Me.cbFS.Size = New System.Drawing.Size(50, 21)
        Me.cbFS.TabIndex = 350
        '
        'BtnAWL
        '
        Me.BtnAWL.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnAWL.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAWL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAWL.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnAWL.Location = New System.Drawing.Point(527, 106)
        Me.BtnAWL.Name = "BtnAWL"
        Me.BtnAWL.Size = New System.Drawing.Size(80, 24)
        Me.BtnAWL.TabIndex = 351
        Me.BtnAWL.Text = "AWL"
        Me.BtnAWL.UseVisualStyleBackColor = False
        '
        'btnOKCPE
        '
        Me.btnOKCPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOKCPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOKCPE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOKCPE.Location = New System.Drawing.Point(36, 5)
        Me.btnOKCPE.Name = "btnOKCPE"
        Me.btnOKCPE.Size = New System.Drawing.Size(75, 23)
        Me.btnOKCPE.TabIndex = 181
        Me.btnOKCPE.Tag = "0"
        Me.btnOKCPE.Text = "Save"
        Me.btnOKCPE.UseVisualStyleBackColor = True
        '
        'btnCancelCPE
        '
        Me.btnCancelCPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelCPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelCPE.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCPE.Location = New System.Drawing.Point(117, 5)
        Me.btnCancelCPE.Name = "btnCancelCPE"
        Me.btnCancelCPE.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelCPE.TabIndex = 180
        Me.btnCancelCPE.Tag = "0"
        Me.btnCancelCPE.Text = "Exit"
        Me.btnCancelCPE.UseVisualStyleBackColor = True
        '
        'PanelCPE
        '
        Me.PanelCPE.Controls.Add(Me.btnOKCPE)
        Me.PanelCPE.Controls.Add(Me.btnCancelCPE)
        Me.PanelCPE.Controls.Add(Me.dgvCPE)
        Me.PanelCPE.Location = New System.Drawing.Point(7, 356)
        Me.PanelCPE.Name = "PanelCPE"
        Me.PanelCPE.Size = New System.Drawing.Size(196, 49)
        Me.PanelCPE.TabIndex = 352
        Me.PanelCPE.Visible = False
        '
        'dgvCPE
        '
        Me.dgvCPE.AllowUserToAddRows = False
        Me.dgvCPE.AllowUserToDeleteRows = False
        Me.dgvCPE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCPE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCPE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCPE.Location = New System.Drawing.Point(0, 0)
        Me.dgvCPE.Name = "dgvCPE"
        Me.dgvCPE.Size = New System.Drawing.Size(196, 49)
        Me.dgvCPE.TabIndex = 10000027
        '
        'BtnQE
        '
        Me.BtnQE.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnQE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQE.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnQE.Location = New System.Drawing.Point(527, 139)
        Me.BtnQE.Name = "BtnQE"
        Me.BtnQE.Size = New System.Drawing.Size(80, 24)
        Me.BtnQE.TabIndex = 353
        Me.BtnQE.Text = "QE"
        Me.BtnQE.UseVisualStyleBackColor = False
        '
        'cbC
        '
        Me.cbC.AccessibleName = ""
        Me.cbC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbC.Location = New System.Drawing.Point(552, 210)
        Me.cbC.Name = "cbC"
        Me.cbC.Size = New System.Drawing.Size(145, 78)
        Me.cbC.TabIndex = 354
        Me.cbC.Text = "..."
        Me.cbC.Visible = False
        '
        'gbB
        '
        Me.gbB.Controls.Add(Me.Label6)
        Me.gbB.Controls.Add(Me.cbe5)
        Me.gbB.Controls.Add(Me.cbe3)
        Me.gbB.Controls.Add(Me.cbe6)
        Me.gbB.Controls.Add(Me.cbe51)
        Me.gbB.Controls.Add(Me.cbe2)
        Me.gbB.Controls.Add(Me.Label9)
        Me.gbB.Controls.Add(Me.cbe1)
        Me.gbB.Controls.Add(Me.txtVS2)
        Me.gbB.Controls.Add(Me.cbe4)
        Me.gbB.Controls.Add(Me.txtVS1)
        Me.gbB.Controls.Add(Me.Label7)
        Me.gbB.Location = New System.Drawing.Point(278, 193)
        Me.gbB.Name = "gbB"
        Me.gbB.Size = New System.Drawing.Size(260, 201)
        Me.gbB.TabIndex = 355
        Me.gbB.TabStop = False
        '
        'cbW
        '
        Me.cbW.AccessibleName = ""
        Me.cbW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbW.Location = New System.Drawing.Point(6, 21)
        Me.cbW.Name = "cbW"
        Me.cbW.Size = New System.Drawing.Size(118, 25)
        Me.cbW.TabIndex = 356
        Me.cbW.Text = "..."
        '
        'tbW
        '
        Me.tbW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbW.Location = New System.Drawing.Point(149, 25)
        Me.tbW.Name = "tbW"
        Me.tbW.Size = New System.Drawing.Size(50, 21)
        Me.tbW.TabIndex = 357
        '
        'tbH
        '
        Me.tbH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbH.Location = New System.Drawing.Point(149, 56)
        Me.tbH.Name = "tbH"
        Me.tbH.Size = New System.Drawing.Size(50, 21)
        Me.tbH.TabIndex = 359
        '
        'cbH
        '
        Me.cbH.AccessibleName = ""
        Me.cbH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbH.Location = New System.Drawing.Point(6, 52)
        Me.cbH.Name = "cbH"
        Me.cbH.Size = New System.Drawing.Size(118, 25)
        Me.cbH.TabIndex = 358
        Me.cbH.Text = "..."
        '
        'gbWH
        '
        Me.gbWH.Controls.Add(Me.cbW)
        Me.gbWH.Controls.Add(Me.tbH)
        Me.gbWH.Controls.Add(Me.tbW)
        Me.gbWH.Controls.Add(Me.cbH)
        Me.gbWH.Location = New System.Drawing.Point(552, 294)
        Me.gbWH.Name = "gbWH"
        Me.gbWH.Size = New System.Drawing.Size(207, 100)
        Me.gbWH.TabIndex = 360
        Me.gbWH.TabStop = False
        Me.gbWH.Visible = False
        '
        'mFormAppereanceTB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(768, 543)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbWH)
        Me.Controls.Add(Me.gbB)
        Me.Controls.Add(Me.cbC)
        Me.Controls.Add(Me.PanelCPE)
        Me.Controls.Add(Me.BtnAWL)
        Me.Controls.Add(Me.cbFS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ttekst)
        Me.Controls.Add(Me.cbF)
        Me.Controls.Add(Me.Mkc_ColorComboboxBC)
        Me.Controls.Add(Me.Mkc_ColorComboboxFC)
        Me.Controls.Add(Me.chbBN)
        Me.Controls.Add(Me.chbRight)
        Me.Controls.Add(Me.chbCenter)
        Me.Controls.Add(Me.cbBC)
        Me.Controls.Add(Me.cbFC)
        Me.Controls.Add(Me.chbBF)
        Me.Controls.Add(Me.cbB)
        Me.Controls.Add(Me.cbI)
        Me.Controls.Add(Me.cbU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.BtnQE)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormAppereanceTB"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Appereance"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.PanelCPE.ResumeLayout(False)
        CType(Me.dgvCPE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbB.ResumeLayout(False)
        Me.gbB.PerformLayout()
        Me.gbWH.ResumeLayout(False)
        Me.gbWH.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim pp() As String
    Dim what As String
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String,
                   ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String)
        InitializeComponent()
        _parentForm = form
        Me.AccessibleName = ""
        Me.ControlBox = False

        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.what = what
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cb1.Checked = True
        Me.pp = Me.Tag.split(";")
        If what = "tp" Then
            Me.ttekst.Enabled = False
            Me.Label1.Text = "Text box appereance for " + pp(2).Trim + "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim
        End If
        If what = "fp" Then
            Me.Label1.Text = "Virtual field appereance for " + pp(2).Trim
        End If
    End Sub

    Dim formatIzraz As String = ""
    Dim formatIzrazOst As String = ""
    Dim izraz As String = ""
    Dim label As String = ""
    Dim labelOst As String = ""
    Dim tipp As String = ""
    Dim od As String = ""
    Dim odOst As String = ""

    Function getDTC() As System.Data.DataTable
        formatIzraz = ""
        izraz = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select izraz,formatIzraz,pp,od " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Function getDTCtabela(ByVal strW As String) As System.Data.DataTable
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select polje,vod,izraz,isnull(formatizraz,'') as formatizraz,pp,od,wwidth,hheight from vrepISTPolja " + strW
        getDTCtabela = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        formatIzraz = dt.Rows(0).Item("formatIzraz").ToString.Trim
        izraz = dt.Rows(0).Item("izraz").ToString.Trim
        tipp = dt.Rows(0).Item("pp").ToString.Trim
        od = dt.Rows(0).Item("od").ToString.Trim
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cb2.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            Me.ttekst.Enabled = True
            Me.gbB.Enabled = True
            Me.cbC.Visible = False
            Me.cbC.Text = "..."
            Me.gbWH.Visible = False
            Me.cbC.Checked = False
            Me.pp = Me.Tag.split(";")
            Dim dt As System.Data.DataTable = getDTC()
            Call EnableSve()

            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    Call getMetaDataPaneP3()
                    Call getMetaDataPaneP5()
                    Call getMetaDataVS()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            cb1.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            cbC.Text = "Do not change width, height and behavior for row"
            Me.cbC.Visible = True
            cbC.Checked = True

            cbW.Text = "Change width for row"
            cbH.Text = "Change height for row"
            Me.gbWH.Visible = True

            Call EnableSve()

            Me.ttekst.Enabled = False
            gbB.Enabled = False
        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            cb2.Checked = False
            cb1.Checked = False
            cb4.Checked = False
            cbC.Text = "Do not change width, height and behavior for column"
            Me.cbC.Visible = True
            cbC.Checked = True

            cbW.Text = "Change width for column"
            cbH.Text = "Change height for column"
            Me.gbWH.Visible = True

            Call disableSve()

            Me.ttekst.Enabled = False
            gbB.Enabled = False
        End If
    End Sub
    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        If cb4.Checked = True Then
            cb2.Checked = False
            cb1.Checked = False
            cb3.Checked = False
            cbC.Text = "Do not change width, height and behavior for table"
            Me.cbC.Visible = True
            cbC.Checked = True
            Me.gbB.Enabled = False
            Me.cbC.Checked = True
            cbW.Text = "Change width for all columns"
            cbH.Text = "Change height for rows"
            Me.gbWH.Visible = True

            Call disableSve()

            Me.ttekst.Enabled = False
            gbB.Enabled = False
        End If
    End Sub
    Sub disableSve()

        Me.ttekst.Enabled = True

        Me.cbe1.Enabled = False
        cbe2.Enabled = False
        cbe3.Enabled = False
        cbe4.Enabled = False
        cbe5.Enabled = False
        cbe51.Enabled = False
        cbe6.Enabled = False

    End Sub

    Sub EnableSve()
        For Each k As Control In Me.Controls
            k.Enabled = True
        Next
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        If cbe3.Checked = True Then cbe4.Checked = True

        If gbB.Enabled = False Then
            If cbW.Checked = True AndAlso IsNumeric(tbW.Text) = False Then
                ISTMessageBox.Show("Please, enter the value for width")
                tbW.Focus()
                Exit Sub
            End If
            If cbH.Checked = True AndAlso IsNumeric(tbH.Text) = False Then
                ISTMessageBox.Show("Please, enter the value for height")
                tbH.Focus()
                Exit Sub
            End If
        End If

        Dim pizraz As String = ""
        Dim pod As String = ""
        Dim popis As String = ""
        Dim strU As String = "update istpolja "
        Dim strS As String = ""
        Dim strI As String = ""
        Dim strW As String = ""

        Dim trk() As String = pp(3).Split(".")
        Dim currenttab As Integer
        Dim currentred As Integer
        Dim currentkol As Integer

        If txtVS1.Text.Trim = "0" Then txtVS2.Text = ""

        Dim ttab As Boolean = False
        If trk.Length = 3 Then
            ''ako je tabela
            ttab = True
            currenttab = CInt(trk(0).Trim)
            currentred = CInt(trk(1).Trim)
            currentkol = CInt(trk(2).Trim)
        End If

        Dim strVs As String = ""
        If txtVS1.Text <> "" AndAlso IsNumeric(txtVS1.Text) Then strVs = txtVS1.Text Else strVs = "100"
        If txtVS2.Text <> "" AndAlso IsNumeric(txtVS2.Text) Then strVs = strVs + ";" + txtVS2.Text
        Dim fforma As String = ""
        Try
            Me.Cursor = Cursors.WaitCursor
            'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
            'gde sam
            Dim strIST As String = ""
            If ttab = True AndAlso (cb2.Checked = True OrElse cb3.Checked = True) Then                ''ako je tabela
                If cb2.Checked = True AndAlso cbW.Checked = False AndAlso cbH.Checked = False Then
                    fforma = Str(currenttab).Trim + "." + Str(currentred).Trim + ".%" 'row
                    strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"
                    Dim dt As System.Data.DataTable = getDTCtabela(strW)
                    If dt.Rows.Count > 0 Then
                        For i As Integer = 0 To dt.Rows.Count - 1
                            strS = ""
                            pizraz = setMetaDataPaneP3_3(dt.Rows(i).Item("izraz").ToString.Trim)
                            strS = " izraz=N'" + pizraz.Trim + "'"
                            pod = setMetaDataPaneP5()
                            If pod.Trim <> "" Then pod = ",od=N'#{" + pod + "}'"
                            If gbB.Enabled = True AndAlso txtVS1.Text <> "" AndAlso IsNumeric(txtVS1.Text) Then strS = strS + ", vs='" + strVs + "'" + pod
                            strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                                   " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod")).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                            strIST = strIST + " update istpolja set " + nvrd + strS.TrimStart(",") + nvrd + strW + nvrd
                        Next
                    End If
                End If

                If cb2.Checked = True AndAlso (cbW.Checked = True OrElse cbH.Checked = True) Then
                    fforma = Str(currenttab).Trim + "." + Str(currentred).Trim + ".%" 'row
                    strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"
                    Dim dt As System.Data.DataTable = getDTCtabela(strW)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim w As Integer = -1 : Dim h As Integer = -1
                        If gbB.Enabled = False AndAlso cbW.Checked = True AndAlso tbW.Text <> "" AndAlso IsNumeric(tbW.Text) Then w = CInt(tbW.Text.Trim)
                        If gbB.Enabled = False AndAlso cbH.Checked = True AndAlso tbH.Text <> "" AndAlso IsNumeric(tbH.Text) Then h = CInt(tbH.Text.Trim)
                        Dim dtw As String = dt.Rows(i).Item("wwidth").ToString.Trim
                        If dtw = "" Then dtw = "100"
                        Dim dth As String = dt.Rows(i).Item("hheight").ToString.Trim
                        If dth = "" Then dth = "22"
                        Dim wwidth As Integer = CInt(dtw)
                        Dim hheight As Integer = CInt(dth)
                        If w > -1 Then
                            wwidth = w
                        End If
                        If h > -1 Then
                            hheight = h
                        End If
                        strS = " vs='" + CStr(wwidth).Trim + ";" + CStr(hheight).Trim + "'"
                        strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                                   " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod")).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                        strIST = strIST + " update istpolja set " + strS + nvrd + strW + nvrd
                    Next
                End If

                If cb3.Checked = True AndAlso cbW.Checked = False AndAlso cbH.Checked = False Then   'kolona , može da menja samo text samo je prazno
                    fforma = Str(currenttab).Trim + ".%." + Str(currentkol).Trim 'column
                    strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"
                    Dim dt As System.Data.DataTable = getDTCtabela(strW)
                    If dt.Rows.Count > 0 Then
                        For i As Integer = 0 To dt.Rows.Count - 1
                            strS = ""
                            pizraz = setMetaDataPaneP3_3(dt.Rows(i).Item("izraz").ToString.Trim)
                            strS = " izraz=N'" + pizraz.Trim + "'"
                            pod = setMetaDataPaneP5()
                            If pod.Trim <> "" Then pod = ",od=N'#{" + pod + "}'"
                            If gbB.Enabled = True AndAlso txtVS1.Text <> "" AndAlso IsNumeric(txtVS1.Text) Then strS = strS + ", vs='" + strVs + "'" + pod
                            strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                            " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod")).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                            strIST = strIST + " update istpolja set " + nvrd + strS.TrimStart(",") + nvrd + strW + nvrd
                        Next
                    End If
                End If

                If cb3.Checked = True AndAlso (cbW.Checked = True OrElse cbH.Checked = True) Then   'kolona , može da menja samo text samo je prazno
                    fforma = Str(currenttab).Trim + ".%." + Str(currentkol).Trim 'column
                    strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"
                    Dim dt As System.Data.DataTable = getDTCtabela(strW)
                    If dt.Rows.Count > 0 Then
                        For i As Integer = 0 To dt.Rows.Count - 1
                            Dim w As Integer = -1 : Dim h As Integer = -1
                            If gbB.Enabled = False AndAlso cbW.Checked = True AndAlso tbW.Text <> "" AndAlso IsNumeric(tbW.Text) Then w = CInt(tbW.Text.Trim)
                            If gbB.Enabled = False AndAlso cbH.Checked = True AndAlso tbH.Text <> "" AndAlso IsNumeric(tbH.Text) Then h = CInt(tbH.Text.Trim)
                            Dim dtw As String = dt.Rows(i).Item("wwidth").ToString.Trim
                            If dtw = "" Then dtw = "100"
                            Dim dth As String = dt.Rows(i).Item("hheight").ToString.Trim
                            If dth = "" Then dth = "22"
                            Dim wwidth As Integer = CInt(dtw)
                            Dim hheight As Integer = CInt(dth)
                            If w > -1 Then
                                wwidth = w
                            End If
                            If h > -1 Then
                                hheight = h
                            End If
                            strS = " vs='" + CStr(wwidth).Trim + ";" + CStr(hheight).Trim + "'"
                            strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                            " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod")).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                            strIST = strIST + " update istpolja set " + strS + nvrd + strW + nvrd
                        Next
                    End If
                End If

            End If

            If cb1.Checked = True Then
                'moze i ne mora da bude tabela jer je c1 cell/field
                strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                    "' and polje=N'" + pp(2).Trim + "'" +
                    "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                'cell/filed
                strS = ""
                pizraz = setMetaDataPaneP3()
                pod = setMetaDataPaneP5()
                If pod.Trim <> "" Then pod = ",od=N'#{" + pod + "}'"
                If pizraz.Trim <> "" Then strS = " izraz=N'" + pizraz.Trim + "'"
                strS = strS + ", vs='" + strVs + "'" + pod
                strIST = " update istpolja set" + nvrd + strS.TrimStart(",") + nvrd + strW + ";" + nvrd
            End If

            If cb4.Checked = True Then
                fforma = Str(currenttab).Trim + ".%" 'row
                strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"
                Dim dt As System.Data.DataTable = getDTCtabela(strW)
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        strS = ""
                        Dim w As Integer = -1 : Dim h As Integer = -1
                        If gbB.Enabled = False AndAlso (cbW.Checked = True OrElse cbH.Checked = True) Then

                            If cbW.Checked = True AndAlso tbW.Text <> "" AndAlso IsNumeric(tbW.Text) Then w = CInt(tbW.Text.Trim)
                            If cbH.Checked = True AndAlso tbH.Text <> "" AndAlso IsNumeric(tbH.Text) Then h = CInt(tbH.Text.Trim)
                            Dim dtw As String = dt.Rows(i).Item("wwidth").ToString.Trim
                            If dtw = "" Then dtw = "100"
                            Dim dth As String = dt.Rows(i).Item("hheight").ToString.Trim
                            If dth = "" Then dth = "22"
                            Dim wwidth As Integer = CInt(dtw)
                            Dim hheight As Integer = CInt(dth)
                            If w > -1 Then
                                wwidth = w
                            End If
                            If h > -1 Then
                                hheight = h
                            End If
                            strS = " vs='" + CStr(wwidth).Trim + ";" + CStr(hheight).Trim + "'"
                        End If

                        If gbB.Enabled = True Then strS = " vs='" + strVs + "'"

                        pizraz = setMetaDataPaneP3_3(dt.Rows(i).Item("izraz").ToString.Trim)
                        If pizraz.Trim <> "" Then pizraz = " izraz=N'" + pizraz.Trim + "'"
                        If strS <> "" AndAlso pizraz.Trim <> "" Then
                            strS = strS + "," + pizraz
                        ElseIf strS = "" AndAlso pizraz.Trim <> "" Then
                            strS = pizraz
                        ElseIf strS <> "" AndAlso pizraz.Trim = "" Then
                            'ostaje strs
                        End If

                        pod = setMetaDataPaneP5()
                        If pod.Trim <> "" Then pod = "od=N'#{" + pod + "}'"
                        If strS <> "" AndAlso pod.Trim <> "" Then
                            strS = strS + "," + pod
                        ElseIf strS = "" AndAlso pod.Trim <> "" Then
                            strS = pod
                        ElseIf strS <> "" AndAlso pod.Trim = "" Then
                            'ostaje strs
                        End If

                        strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                        " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod")).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                        strIST = strIST + " update istpolja set " + strS + nvrd + strW + nvrd
                    Next
                End If
            End If

            Dim pI As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strIST)

            If pI = "ok" Then
                Me.Cursor = Cursors.Default
                Me.Close()
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Function setMetaDataPaneP3() As String
        'izraz
        Dim pom As String = ""

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName + "$"
            End If
        Next

        If cbe5.Checked = True Then pom = pom + "multilineheight" + cbe51.Text + "$"
        If cbe6.Checked = True Then pom = pom + "multiline" + "$"

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxBC.SelectedColor = Color.Chocolate
        If Mkc_ColorComboboxFC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxFC.SelectedColor = Color.Chocolate

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow
        'If Mkc_ColorComboboxFC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow

        If cbFC.Checked = True AndAlso Mkc_ColorComboboxFC.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorComboboxFC.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorComboboxBC.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorComboboxBC.SelectedColor.Name + "$"

        If cbF.Checked = True Then
            Dim ffs As String = "8"
            Dim fs As Integer = CInt(cbFS.Text.Trim)
            ffs = CStr(fs).Trim
            pom = pom + "fontSize" + ffs + "$"
        End If

        If ttekst.Tag Is Nothing Then
        ElseIf ttekst.Tag <> "lbl" Then    'nije labela, ni FP koje glumi labelu
            pom = pom + "$" + ttekst.Text.TrimStart("'").TrimEnd("'") + ""
        Else
            If ttekst.Text = "''" Then
                pom = pom + "$''    ''"
            ElseIf ttekst.Text.Trim = "" Then
                pom = pom + "$''    ''"
            Else
                pom = pom + "$''" + ttekst.Text.TrimStart("'").TrimEnd("'") + "''"
            End If
        End If

        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")

        Return pom
    End Function

    Function setMetaDataPaneP3_3(ByVal izraz As String) As String
        'izraz iz vrepoISTPolja, sto znaci ako je prazno onda je pravo polje

        Dim fpom As String = ""
        Dim pom As String = ""

        Dim fformatIzraz As String = ""

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then fpom = fpom + k.AccessibleName + "$"
            End If
        Next

        fformatIzraz = fpom + fformatIzraz
        If Mkc_ColorComboboxBC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxBC.SelectedColor = Color.Chocolate
        If Mkc_ColorComboboxFC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxFC.SelectedColor = Color.Chocolate

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow
        'If Mkc_ColorComboboxFC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxFC.SelectedColor = Color.Snow

        If gbB.Enabled = True Then
            If cbe5.Checked = True Then pom = pom + "multilineheight" + cbe51.Text + "$"
            If cbe6.Checked = True Then pom = pom + "multiline" + "$"
        End If


        If cbFC.Checked = True AndAlso Mkc_ColorComboboxFC.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorComboboxFC.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorComboboxBC.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorComboboxBC.SelectedColor.Name + "$"

        If cbF.Checked = True Then
            Dim ffs As String = "8"
            Dim fs As Integer = CInt(cbFS.Text.Trim)
            ffs = CStr(fs).Trim
            pom = pom + "fontSize" + ffs + "$"
        End If

        If izraz.Trim <> "" Then   ' NIJE PRAVO POLJE
            If Me.ttekst.Enabled = True AndAlso Me.ttekst.Text.Trim = "" Then
                izraz = "'    '" 'moze da se menja samo je prazno, inace svakom ostaje onaj koji je bio
                pom = pom + "$" + izraz + ""
            Else
                'row, column
                If pom.Trim = "" AndAlso izraz.Trim = "" Then
                ElseIf pom = "" AndAlso izraz.Trim <> "" Then
                    pom = izraz
                    If izraz.Trim.Substring(0, 1) = "'" Then pom = "'" + izraz.Replace("'", "") + "'"
                    If izraz.Trim.Substring(0, 1) <> "'" Then pom = izraz
                ElseIf pom <> "" AndAlso izraz = "" Then
                    'pom = pom
                ElseIf pom <> "" AndAlso izraz.Trim <> "" Then
                    If izraz.Trim.Substring(0, 1) = "'" Then pom = pom + "$'" + izraz.Replace("'", "") + "'"
                    If izraz.Trim.Substring(0, 1) <> "'" Then pom = pom + "$" + izraz + ""
                End If
            End If
            pom = pom.Replace("'", "''")
        End If

        pom = fformatIzraz + "$" + pom
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")

        Return pom
    End Function

    Function setMetaDataPaneP3_4(ByVal izraz As String) As String
        'izraz
        Dim fpom As String = ""
        Dim pom As String = ""

        Dim fformatIzraz As String = ""
        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then fpom = fpom + k.AccessibleName + "$"
            End If
        Next

        fformatIzraz = fpom + fformatIzraz

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxBC.SelectedColor = Color.Chocolate
        If Mkc_ColorComboboxFC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxFC.SelectedColor = Color.Chocolate

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow

        If cbe5.Checked = True Then pom = pom + "multilineheight" + cbe51.Text + "$"
        If cbFC.Checked = True AndAlso Mkc_ColorComboboxFC.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorComboboxFC.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorComboboxBC.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorComboboxBC.SelectedColor.Name + "$"

        If cbF.Checked = True Then
            Dim ffs As String = "8"
            Dim fs As Integer = CInt(cbFS.Text.Trim)
            ffs = CStr(fs).Trim
            pom = pom + "fontSize" + ffs + "$"
        End If

        If Me.ttekst.Text.Trim = "" Then
            izraz = "'    '" 'moze da se menja samo je prazno, inace svakom ostaje onaj koji je bio
            pom = pom + "$" + izraz + ""
        Else
            'column
            If pom.Trim = "" AndAlso izraz.Trim = "" Then
            ElseIf pom = "" AndAlso izraz.Trim <> "" Then
                pom = izraz
                If izraz.Trim.Substring(0, 1) = "'" Then pom = "'" + izraz.Replace("'", "") + "'"
                If izraz.Trim.Substring(0, 1) <> "'" Then pom = izraz
            ElseIf pom <> "" AndAlso izraz = "" Then
                'pom = pom
            ElseIf pom <> "" AndAlso izraz.Trim <> "" Then
                If izraz.Trim.Substring(0, 1) = "'" Then pom = pom + "$'" + izraz.Replace("'", "") + "'"
                If izraz.Trim.Substring(0, 1) <> "'" Then pom = pom + "$" + izraz + ""
            End If
        End If
        pom = pom.Replace("'", "''")
        pom = fformatIzraz + "$" + pom
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")

        Return pom
    End Function

    Function setMetaDataPaneP5() As String
        'od (validating event)
        Dim pom As String = ""

        If gbB.Enabled = True AndAlso cbe4.Checked = True Then pom = pom + "noTabStop" + ";"

        If pom.Trim = "" AndAlso odOst.Trim = "" Then
        ElseIf pom = "" AndAlso odOst.Trim <> "" Then
            pom = odOst
        ElseIf pom <> "" AndAlso odOst = "" Then
            'pom = pom
        ElseIf pom <> "" AndAlso odOst <> "" Then
            pom = pom + ";" + odOst
        End If
        pom = pom.Replace("'", "''")
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
        Return pom
    End Function

    Function getrbr(ByVal sqlrbr As String) As String
        Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
        If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 Then
            getrbr = dt1.Rows(0).Item(0).ToString
        Else
            getrbr = "0"
        End If
    End Function

    Private Sub chbFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbFC.CheckedChanged
        Me.Mkc_ColorComboboxFC.Visible = cbFC.Checked
        If cbFC.Checked = False Then
            Mkc_ColorComboboxFC.SelectedColor = System.Drawing.Color.Empty
        Else
            Me.Mkc_ColorComboboxFC.Focus()
        End If
    End Sub

    Private Sub chbBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbBC.CheckedChanged
        Me.Mkc_ColorComboboxBC.Visible = cbBC.Checked
        If cbBC.Checked = False Then
            Mkc_ColorComboboxBC.SelectedColor = System.Drawing.Color.Empty
        Else
            Me.Mkc_ColorComboboxBC.Focus()
        End If
    End Sub

    Private Sub chbFSize_CheckedChanged(sender As Object, e As EventArgs) Handles cbF.CheckedChanged
        Me.cbFS.Visible = cbF.Checked
    End Sub

    Sub getMetaDataPaneP3()

        Dim multilineheight As String = ""
        Dim forecolor As String = ""
        Dim backcolor As String = ""
        Dim fformatIzraz As String = formatIzraz
        If fformatIzraz.Trim = "" AndAlso izraz.Trim = "" Then Exit Sub

        If fformatIzraz.Trim <> "" Then
            If fformatIzraz.IndexOf("$") < 0 Then

                If fformatIzraz.IndexOf("multilineheight") < 0 Then
                    fformatIzraz = Replace(fformatIzraz, "multiline", "multiline" + "$", 1, , CompareMethod.Text)
                End If

                fformatIzraz = Replace(fformatIzraz, "fontbold", "fontbold" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "readonly", "readonly" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "fontitalic", "fontitalic" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "fontunderline", "fontunderline" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "visiblefalse", "visiblefalse" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "enablefalse", "enablefalse" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "frighta", "frighta" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "fcentera", "fcentera" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "fcentrea", "fcentrea" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "borderfixed", "borderfixed" + "$", 1, , CompareMethod.Text)
                fformatIzraz = Replace(fformatIzraz, "bordernone", "bordernone" + "$", 1, , CompareMethod.Text)
                fformatIzraz = fformatIzraz.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")
            End If

            Dim pp() As String = fformatIzraz.Split("$")
            For i As Integer = 0 To pp.GetUpperBound(0)
                pp(i) = pp(i).Replace(vbCrLf, "").Replace("#{", "").Trim
                If pp(i).Length > 1 AndAlso pp(i).Substring(pp(i).Length - 1, 1) = "}" Then pp(i) = pp(i).Substring(0, pp(i).Length - 1)
                If pp(i).Trim = "" Then
                ElseIf pp(i).Length > 14 AndAlso pp(i).Trim.ToUpper.IndexOf("MULTILINEHEIGHT") = 0 Then
                    Dim mlh As String = pp(i).Trim.ToUpper.Replace("MULTILINEHEIGHT", "")
                    cbe51.Text = mlh
                    cbe5.Checked = True
                    cbe6.Checked = False
                    multilineheight = getttt(pp(i), "MULTILINEHEIGHT")
                ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") >= 0 Then
                    cbFC.Checked = True
                    Dim fc As String = getttt(pp(i), "FORECOLOR")
                    If fc <> "" Then Mkc_ColorComboboxFC.SelectedColor = Color.FromName(fc)
                    forecolor = fc
                ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") >= 0 Then
                    cbBC.Checked = True
                    Dim bc As String = getttt(pp(i), "BACKCOLOR")
                    If bc <> "" Then Mkc_ColorComboboxBC.SelectedColor = Color.FromName(bc)
                    backcolor = bc
                ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("READONLY") = 0 Then
                    cbe3.Checked = True
                ElseIf pp(i).Length > 8 AndAlso pp(i).Length < 14 AndAlso pp(i).Trim.ToUpper.IndexOf("MULTILINE") = 0 AndAlso pp(i).Trim.ToUpper.IndexOf("HEIGHT") < 0 Then
                    cbe6.Checked = True
                    cbe5.Checked = False
                ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                    cbB.Checked = True
                ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                    cbI.Checked = True
                ElseIf pp(i).Length > 12 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTUNDERLINE") = 0 Then
                    cbU.Checked = True
                ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("VISIBLEFALSE") = 0 Then
                    cbe1.Checked = True
                ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("ENABLEFALSE") = 0 Then
                    cbe2.Checked = True
                ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("FRIGHTA") = 0 Then
                    chbRight.Checked = True
                ElseIf pp(i).Length > 7 AndAlso (pp(i).Trim.ToUpper.IndexOf("FCENTERA") = 0 OrElse pp(i).Trim.ToUpper.IndexOf("FCENTREA") = 0) Then
                    chbCenter.Checked = True
                ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("BORDERFIXED") = 0 Then
                    chbBF.Checked = True
                ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("BORDERNONE") = 0 Then
                    chbBN.Checked = True
                ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                    Dim fs As Integer = CInt(pp(i).Trim.ToUpper.Replace("FONTSIZE", ""))
                    cbF.Checked = True
                    cbFS.Text = fs
                    'ElseIf pp(i).Length > 1 AndAlso pp(i).Trim.ToUpper.IndexOf("'") = 0 Then
                    '    Dim tekst As String = pp(i).Trim
                    '    If tekst <> "" Then ttekst.Text = tekst.TrimStart("'").TrimEnd("'")
                ElseIf pp(i).Trim <> "" Then
                    formatIzrazOst = formatIzrazOst + "$" + pp(i).Trim
                End If
            Next
        End If

        If tipp <> "lbl" AndAlso tipp <> "fp" Then
            ttekst.Tag = "tp"
        Else
            If izraz <> "" Then
                If izraz.Trim.Substring(0, 1) = "'" Then
                    ttekst.Tag = "lbl" : ttekst.Text = izraz.TrimStart("'").TrimEnd("'") : ttekst.Text = ttekst.Text.Replace("''", "'")
                Else
                    ttekst.Tag = "select" : ttekst.Text = izraz.Trim : ttekst.Text = ttekst.Text.Replace("''", "'")
                End If
            Else
                ttekst.Tag = "lbl" : ttekst.Text = izraz.TrimStart("'").TrimEnd("'") : ttekst.Text = ttekst.Text.Replace("''", "'")
            End If
        End If

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

        Dim a As Integer = 0
        For i As Integer = 0 To ppp.GetUpperBound(0)
            If ppp(i).Length > 8 AndAlso ppp(i).Trim.ToUpper.IndexOf("NOTABSTOP") = 0 Then
                cbe4.Checked = True
            ElseIf ppp(i).Trim <> "" Then
                odOst = odOst + ";" + ppp(i).Trim
            End If
        Next
        odOst = odOst.TrimStart(";")
    End Sub

    Sub getMetaDataVS()

        Dim sqlIST As String = "select isnull(vs,100),wwidth,hheight from vrepistpolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
            "' and polje=N'" + pp(2).Trim + "'" +
          " and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sqlIST, Me.ISTConnectionString, Nothing)

        If dt.Rows.Count > 0 Then
            Me.txtVS1.Text = dt.Rows(0).Item("wwidth").ToString
            Me.txtVS2.Text = dt.Rows(0).Item("hheight").ToString
        End If
    End Sub

    Private Sub chbBF_CheckedChanged(sender As Object, e As EventArgs) Handles chbBF.CheckedChanged
        If chbBF.Checked = True Then chbBN.Checked = False
    End Sub

    Private Sub chbBn_CheckedChanged(sender As Object, e As EventArgs) Handles chbBN.CheckedChanged
        If chbBN.Checked = True Then chbBF.Checked = False
    End Sub

    Private Sub chbRight_CheckedChanged(sender As Object, e As EventArgs) Handles chbRight.CheckedChanged
        If chbRight.Checked = True Then chbCenter.Checked = False
    End Sub

    Private Sub chbCentar_CheckedChanged(sender As Object, e As EventArgs) Handles chbCenter.CheckedChanged
        If chbCenter.Checked = True Then chbRight.Checked = False
    End Sub

    Private Sub chbMultiline_CheckedChanged(sender As Object, e As EventArgs) Handles cbe6.CheckedChanged
        If cbe6.Checked = True Then cbe5.Checked = False : Me.cbe51.Text = "" : Me.cbe51.Visible = False
    End Sub

    Private Sub chbMultilineH_CheckedChanged(sender As Object, e As EventArgs) Handles cbe5.CheckedChanged
        Me.cbe51.Visible = cbe5.Checked
        If cbe5.Checked = False Then
            Me.cbe51.Text = ""
        Else
            Me.cbe51.Focus()
            cbe6.Checked = False
        End If
    End Sub

    Private Sub cbe3_CheckedChanged(sender As Object, e As EventArgs) Handles cbe3.CheckedChanged
        If cbe3.Checked = True Then Me.cbe4.Checked = True : cbe4.Enabled = False
        If cbe3.Checked = False Then Me.cbe4.Checked = False : cbe4.Enabled = True
    End Sub

    Private Sub BtnAWL_Click(sender As Object, e As EventArgs) Handles BtnAWL.Click

        Dim strSQl As String = " select distinct 'Screen form     ' + cast(f1 as char)  as displaymember,f1  as valuemember " +
                                " from vrepISTPolja " +
                                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'"
        dgvCPE.AccessibleDescription = "AWL"
        Me.PanelCPE.Dock = DockStyle.Fill
        Me.PanelCPE.Visible = True
        Me.BtnFormat.Visible = False
        Call fillDGV()
    End Sub

    Private Sub BtnQE_Click(sender As Object, e As EventArgs) Handles BtnQE.Click

        Dim strSQl As String = " select distinct 'Screen form     ' + cast(f1 as char)  as displaymember,f1  as valuemember " +
                                " from vrepISTPolja " +
                                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'"
        dgvCPE.AccessibleDescription = "QUESTIONEXPLANATION"
        Me.PanelCPE.Dock = DockStyle.Fill
        Me.PanelCPE.Visible = True
        Me.BtnFormat.Visible = False
        Call fillDGV()
    End Sub

    Sub fillDGV()
        'Dim tab As String = Me.cboCPE.SelectedValue.ToString
        Dim strSQl As String = ""

        '0-7
        Dim sqlselect1 As String = "select sifist as appCode,tabela as _table,polje as field,rbr as ordinalNumber,vod as validFrom, cast(f1 as integer) as ttable, cast(f2 as integer)  as rrow, cast(f3 as integer)  as ccolumn,"
        Dim sqlfromwhereISTPolja As String = " from vrepISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'"
        Dim sqlfromwhereAWLS As String = " from vrepISTAWLs where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'"
        Dim sqlfromwhereQE As String = " from vrepISTQuestionExplanation where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'"

        If Not dgvCPE.AccessibleDescription Is Nothing AndAlso dgvCPE.AccessibleDescription.Trim.ToUpper = "AWL" Then
            strSQl = sqlselect1 + " Idlang, IdAwl, ttext as text, onF1 as [appears only when F1 is pressed (if true set 1)]" + sqlfromwhereAWLS
        ElseIf Not dgvCPE.AccessibleDescription Is Nothing AndAlso dgvCPE.AccessibleDescription.Trim.ToUpper = "QUESTIONEXPLANATION" Then
            strSQl = sqlselect1 + " Idlang, IdQuestionExplanation, ttext as text " + sqlfromwhereQE
        Else
            Exit Sub
        End If

        'If Not (cboCPE.SelectedValue = "All") Then strSQl = strSQl + " and cast(f1 as int)= " + cboCPE.SelectedValue.ToString
        strSQl = strSQl + " order by rbr "

        'ttable
        Dim dt As DataTable = izvrsiSQLvratiDT(strSQl, Me.ISTConnectionString, Nothing)
        Me.dgvCPE.DataSource = dt

        dgvCPE.Columns("appCode").Visible = False
        dgvCPE.Columns("_table").Visible = False

        dgvCPE.DefaultCellStyle.BackColor = SystemColors.ButtonFace
        dgvCPE.Columns("field").ReadOnly = True
        dgvCPE.Columns("ordinalNumber").ReadOnly = True
        dgvCPE.Columns("validFrom").ReadOnly = True
        dgvCPE.Columns("ttable").ReadOnly = True
        dgvCPE.Columns("rrow").ReadOnly = True
        dgvCPE.Columns("ccolumn").ReadOnly = True

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "LABEL" Then
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
            dgvCPE.Columns("formatizraz").Visible = False
            dgvCPE.Columns("formatopis").Visible = False
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "VF" Then
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
            dgvCPE.Columns("formatizraz").Visible = False
            dgvCPE.Columns("formatopis").Visible = False
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "NAME" Then
            dgvCPE.Columns("label").ReadOnly = True
            dgvCPE.Columns("typeF").ReadOnly = True

            dgvCPE.Columns("field").ReadOnly = False
            dgvCPE.Columns("field").DefaultCellStyle.BackColor = Color.AntiqueWhite

            dgvCPE.Columns("fieldOrg").Visible = False
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "AWL" Then
            dgvCPE.Columns("Idlang").ReadOnly = True
            dgvCPE.Columns("IDAwl").ReadOnly = True
            '- for multiply lines use <br>
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
            dgvCPE.Columns("appears only when F1 is pressed (if true set 1)").DefaultCellStyle.BackColor = Color.AntiqueWhite  '11
        End If

        If dgvCPE.AccessibleDescription.Trim.ToUpper = "QUESTIONEXPLANATION" Then
            dgvCPE.Columns("Idlang").ReadOnly = True
            dgvCPE.Columns("IdQuestionExplanation").ReadOnly = True
            '- for multiply lines use <br>
            dgvCPE.Columns("text").DefaultCellStyle.BackColor = Color.AntiqueWhite
        End If

        Me.dgvCPE.Tag = dt
    End Sub

    Private Sub dgvCPE_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCPE.EditingControlShowing
        If TypeOf e.Control Is TextBox Then
            Dim tb As TextBox = TryCast(e.Control, TextBox)
            RemoveHandler tb.KeyPress, AddressOf tb_KeyPress
            '11=onF1
            If dgvCPE.AccessibleDescription.Trim.ToUpper = "AWL" AndAlso Me.dgvCPE.CurrentCell.ColumnIndex = 11 Then AddHandler tb.KeyPress, AddressOf tb_KeyPress
        End If
    End Sub

    Private Sub dgvCPE_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCPE.KeyDown
        Try
            If e.Control And (e.KeyCode = Keys.C) Then
                Dim d As DataObject = dgvCPE.GetClipboardContent()
                Clipboard.SetDataObject(d)
                e.Handled = True
            ElseIf (e.Control And e.KeyCode = Keys.V) Then
                PasteUnboundRecords()
            End If
        Catch ex As Exception
            'Log Exception
        End Try
    End Sub

    Private Sub tb_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) Or (Char.IsDigit(e.KeyChar) And e.KeyChar <> "1"c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub PasteUnboundRecords()
        Try
            Dim rowLines As String() = Clipboard.GetText(TextDataFormat.UnicodeText).Split(New String(0) {vbCr & vbLf}, StringSplitOptions.None)
            Dim currentRowIndex As Integer = (If(dgvCPE.CurrentRow IsNot Nothing, dgvCPE.CurrentRow.Index, 0))
            Dim currentColumnIndex As Integer = (If(dgvCPE.CurrentCell IsNot Nothing, dgvCPE.CurrentCell.ColumnIndex, 0))
            Dim currentColumnCount As Integer = dgvCPE.Columns.Count

            dgvCPE.AllowUserToAddRows = False
            For rowLine As Integer = 0 To rowLines.Length - 1

                If rowLine = rowLines.Length - 1 AndAlso String.IsNullOrEmpty(rowLines(rowLine)) Then
                    Exit For
                End If

                Dim columnsData As String() = rowLines(rowLine).Split(New String(0) {vbTab}, StringSplitOptions.None)
                If (currentColumnIndex + columnsData.Length) > dgvCPE.Columns.Count Then
                    For columnCreationCounter As Integer = 0 To ((currentColumnIndex + columnsData.Length) - currentColumnCount) - 1
                        If columnCreationCounter = rowLines.Length - 1 Then
                            Exit For
                        End If
                    Next
                End If
                If dgvCPE.Rows.Count > (currentRowIndex + rowLine) Then
                    For columnsDataIndex As Integer = 0 To columnsData.Length - 1
                        If currentColumnIndex + columnsDataIndex <= dgvCPE.Columns.Count - 1 Then
                            dgvCPE.Rows(currentRowIndex + rowLine).Cells(currentColumnIndex + columnsDataIndex).Value = columnsData(columnsDataIndex)
                        End If
                    Next
                Else
                    Dim pasteCells As String() = New String(dgvCPE.Columns.Count - 1) {}
                    For cellStartCounter As Integer = currentColumnIndex To dgvCPE.Columns.Count - 1
                        If columnsData.Length > (cellStartCounter - currentColumnIndex) Then
                            pasteCells(cellStartCounter) = columnsData(cellStartCounter - currentColumnIndex)
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            'Log Exception
        End Try

    End Sub

    Private Sub btnOKCPE_Click(sender As Object, e As EventArgs) Handles btnOKCPE.Click

        Dim str As String = ""
        Dim dt As DataTable = Me.dgvCPE.DataSource
        Dim pDB As String = "ok" : Dim pIST As String = "ok"
        Dim ppNOK As Boolean = False
        Dim sta As String = Me.dgvCPE.AccessibleDescription.Trim.ToUpper

        Try
            For i As Integer = 0 To dt.Rows.Count - 1
                pDB = "ok" : pIST = "ok"
                Dim sifist As String = dt.Rows(i).Item("appCode").ToString.Trim
                Dim tabela As String = dt.Rows(i).Item("_table").ToString
                Dim polje As String = dt.Rows(i).Item("field").ToString.Trim

                Dim vvod As String = dt.Rows(i).Item("validFrom").ToString
                Dim ttext As String = dt.Rows(i).Item("text").ToString.Trim
                If ttext.Trim.StartsWith("'") AndAlso ttext.Trim.EndsWith("'") Then ttext = ttext.Substring(1, Len(ttext) - 2)
                ttext = ttext.Replace("'", "''")

                If sta = "VF" AndAlso dt.Rows(i).Item("text").ToString.IndexOf("Text_") < 0 Then
                    Dim formatizraz As String = dt.Rows(i).Item("formatizraz").ToString.Trim
                    formatizraz = formatizraz.TrimEnd("$")
                    If ttext.Trim = "" Then ttext = "      "
                    str = " update istpolja set izraz = N'" + formatizraz + "$''" + ttext + "''' " +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + dt.Rows(i).Item("_table").ToString + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                    pIST = izvrsiSQL(" begin transaction; " + nvrd + str + nvrd + " commit; ", Me.ISTConnectionString)
                    If pIST = "nok" Then ppNOK = True : ISTMessageBox.Show("Error. IST is NOT updated! Virtual filed value for " + polje + " Is skipped!")
                End If

                If sta = "LABEL" Then
                    Dim formatopis As String = dt.Rows(i).Item("formatopis").ToString.Trim
                    formatopis = formatopis.TrimEnd("$")
                    str = " update istpolja set opis = N'" + formatopis + "$" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + dt.Rows(i).Item("_table").ToString + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                    pIST = izvrsiSQL(" begin transaction; " + nvrd + str + nvrd + " commit; ", Me.ISTConnectionString)
                    If pIST = "nok" Then ppNOK = True : ISTMessageBox.Show("Error. IST is NOT updated! Rename for " + polje + " Is skipped!")
                End If

                If sta = "AWL" Then
                    Dim onF1awls As String = ""
                    If Not (dt.Rows(i).Item(11) Is System.DBNull.Value) AndAlso dt.Rows(i).Item(11).ToString.Trim <> "" Then onF1awls = ", onF1=1"
                    If (dt.Rows(i).Item(11) Is System.DBNull.Value) Then onF1awls = ", onF1=Null"
                    str = " update istAwls set ttext = N'" + ttext + "'" + onF1awls +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + dt.Rows(i).Item("_table").ToString + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString + "' and IDAwl=" + dt.Rows(i).Item("IDAwl").ToString + ";"
                    pIST = izvrsiSQL(" begin transaction; " + nvrd + str + nvrd + " commit; ", Me.ISTConnectionString)
                    If pIST = "nok" Then ppNOK = True : ISTMessageBox.Show("Error. IST is NOT updated! Awl value for " + polje + " Is skipped!")
                End If

                If sta = "QUESTIONEXPLANATION" Then
                    str = " update ISTQuestionExplanation set ttext = N'" + ttext + "'" +
                           " where sifist=N'" + dt.Rows(i).Item("appCode").ToString + "' and tabela=N'" + dt.Rows(i).Item("_table").ToString + "'" +
                           " and polje=N'" + dt.Rows(i).Item("field").ToString + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'" +
                           " and IDLang='" + dt.Rows(i).Item("IDLang").ToString + "' and IdQuestionExplanation=" + dt.Rows(i).Item("IdQuestionExplanation").ToString + ";"
                    pIST = izvrsiSQL(" begin transaction; " + nvrd + str + nvrd + " commit; ", Me.ISTConnectionString)
                    If pIST = "nok" Then ppNOK = True : ISTMessageBox.Show("Error. IST is NOT updated! Question explanation value for " + polje + " Is skipped!")
                End If

                If sta = "NAME" Then
                    Dim currentName As String = dt.Rows(i).Item("fieldOrg").ToString.Trim
                    Dim newName As String = dt.Rows(i).Item("field").ToString.Trim
                    If currentName.Trim.ToUpper <> newName.Trim.ToUpper Then
                        Dim pp2 As String = dt.Rows(i).Item("typeF").ToString.Trim
                        Dim strWProvera As String = " where sifist=N'" + sifist + "' and tabela=N'" + tabela +
                            "' and polje=N'" + newName + "'" +
                            "  and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                        Dim strProvera As String = "select polje from istpolja " + strWProvera
                        Dim dtprovera As DataTable = izvrsiSQLvratiDT(strProvera, Me.ISTConnectionString, Nothing)
                        If dtprovera.Rows.Count > 0 Then
                            ppNOK = True
                            ISTMessageBox.Show("Error. Name " + newName + " already exists! Rename for " + newName + " is skipped!")
                        Else
                            If pp2.Trim.ToUpper <> "DATAGRIDVIEW" AndAlso pp2.Trim.ToUpper <> "LABEL" Then
                                Dim strDB As String = " exec sp_rename '" + tabela + "." + currentName + "', '" + newName + "','COLUMN';"
                                pDB = izvrsiSQL(" begin transaction; " + nvrd + strDB + nvrd + " commit; ", Me.DBConnectionString)
                            End If
                            If pDB = "nok" Then
                                ppNOK = True
                                ISTMessageBox.Show("Error. DB is NOT updated! Rename for " + newName + " is skipped!")
                            Else
                                str = " update istpolja set polje = N'" + newName + "'" +
                              " where sifist=N'" + sifist + "' and tabela=N'" + tabela + "'" +
                              " and polje=N'" + currentName + "' and cast (vod as date)='" + Convert.ToDateTime(vvod).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                                pIST = izvrsiSQL(" begin transaction; " + nvrd + str + nvrd + " commit; ", Me.ISTConnectionString)
                                If pIST = "nok" Then ppNOK = True : ISTMessageBox.Show("Error. IST is NOT updated!Rename for " + newName + " is skipped!")
                            End If
                        End If
                    End If
                End If
            Next

            Me.Cursor = Cursors.Default

            If ppNOK = True Then
                Call fillDGV()
            Else
                Call closeCEP()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btncancelCPE_Click(sender As Object, e As EventArgs) Handles btnCancelCPE.Click
        If ISTMessageBox.Show("Are you sure you want to exit without SAVE?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call closeCEP()
        End If
    End Sub

    Sub closeCEP()
        Me.PanelCPE.Dock = DockStyle.None
        Me.PanelCPE.Visible = False
        Me.BtnFormat.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.AccessibleName = "cancel"
        Me.Close()
    End Sub

    Private Sub cbC_CheckedChanged(sender As Object, e As EventArgs) Handles cbC.CheckedChanged
        If cbC.Checked = True Then
            Me.gbB.Enabled = False
        Else
            Me.gbB.Enabled = True
        End If
    End Sub

    Private Sub cbW_CheckedChanged(sender As Object, e As EventArgs) Handles cbW.CheckedChanged
        Me.gbB.Enabled = False
        Me.cbC.Checked = True
    End Sub

    Private Sub cbH_CheckedChanged(sender As Object, e As EventArgs) Handles cbH.CheckedChanged
        Me.gbB.Enabled = False
        Me.cbC.Checked = True
    End Sub

    Private Sub tbW_Leave(sender As Object, e As EventArgs) Handles tbW.Leave
        If tbW.Text <> "" AndAlso IsNumeric(tbW.Text) = True Then
            cbW.Checked = True
        Else
            cbW.Checked = False
            tbW.Text = ""
        End If
    End Sub
    Private Sub tbH_Leave(sender As Object, e As EventArgs) Handles tbH.Leave
        If tbH.Text <> "" AndAlso IsNumeric(tbH.Text) = True Then
            cbH.Checked = True
        Else
            cbW.Checked = False
            cbH.Text = ""
        End If
    End Sub
End Class