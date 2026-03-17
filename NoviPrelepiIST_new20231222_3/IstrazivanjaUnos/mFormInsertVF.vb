'Option Strict Off

Imports System.Web

Public Class mFormInsertVF
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
    Friend WithEvents Btn As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblName As Label
    Friend WithEvents lVM As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbBe As CheckBox
    Friend WithEvents cbAe As CheckBox
    Friend WithEvents gbGde As GroupBox
    Friend WithEvents gbType As GroupBox
    Friend WithEvents cbt4 As CheckBox
    Friend WithEvents cbt3 As CheckBox
    Friend WithEvents cbt1 As CheckBox
    Friend WithEvents cbt2 As CheckBox
    Friend WithEvents ttekst As TextBox
    Friend WithEvents lblDescription As Label
    Friend WithEvents cbFS As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtVS2 As TextBox
    Friend WithEvents cbF As CheckBox
    Friend WithEvents Mkc_ColorComboboxBC As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorComboboxFC As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtVS1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chbBN As CheckBox
    Friend WithEvents chbRight As CheckBox
    Friend WithEvents chbCenter As CheckBox
    Friend WithEvents cbBC As CheckBox
    Friend WithEvents cbFC As CheckBox
    Friend WithEvents chbBF As CheckBox
    Friend WithEvents cbB As CheckBox
    Friend WithEvents cbI As CheckBox
    Friend WithEvents cbU As CheckBox
    Friend WithEvents cbe51 As TextBox
    Friend WithEvents cbe6 As CheckBox
    Friend WithEvents cbe5 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents gb4 As GroupBox
    Friend WithEvents cb45 As CheckBox
    Friend WithEvents cb44 As CheckBox
    Friend WithEvents gb5 As GroupBox
    Friend WithEvents cb55 As CheckBox
    Friend WithEvents cb56 As CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lVM = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbBe = New System.Windows.Forms.CheckBox()
        Me.cbAe = New System.Windows.Forms.CheckBox()
        Me.gbGde = New System.Windows.Forms.GroupBox()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.cbt4 = New System.Windows.Forms.CheckBox()
        Me.cbt3 = New System.Windows.Forms.CheckBox()
        Me.cbt1 = New System.Windows.Forms.CheckBox()
        Me.cbt2 = New System.Windows.Forms.CheckBox()
        Me.ttekst = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.cbFS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVS2 = New System.Windows.Forms.TextBox()
        Me.cbF = New System.Windows.Forms.CheckBox()
        Me.Mkc_ColorComboboxBC = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorComboboxFC = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtVS1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chbBN = New System.Windows.Forms.CheckBox()
        Me.chbRight = New System.Windows.Forms.CheckBox()
        Me.chbCenter = New System.Windows.Forms.CheckBox()
        Me.cbBC = New System.Windows.Forms.CheckBox()
        Me.cbFC = New System.Windows.Forms.CheckBox()
        Me.chbBF = New System.Windows.Forms.CheckBox()
        Me.cbB = New System.Windows.Forms.CheckBox()
        Me.cbI = New System.Windows.Forms.CheckBox()
        Me.cbU = New System.Windows.Forms.CheckBox()
        Me.cbe51 = New System.Windows.Forms.TextBox()
        Me.cbe6 = New System.Windows.Forms.CheckBox()
        Me.cbe5 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.gb4 = New System.Windows.Forms.GroupBox()
        Me.cb45 = New System.Windows.Forms.CheckBox()
        Me.cb44 = New System.Windows.Forms.CheckBox()
        Me.gb5 = New System.Windows.Forms.GroupBox()
        Me.cb55 = New System.Windows.Forms.CheckBox()
        Me.cb56 = New System.Windows.Forms.CheckBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGde.SuspendLayout()
        Me.gbType.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.gb4.SuspendLayout()
        Me.gb5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Btn.Location = New System.Drawing.Point(694, 3)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(374, 23)
        Me.Btn.TabIndex = 1
        Me.Btn.TabStop = False
        Me.Btn.Text = "Insert"
        Me.Btn.UseVisualStyleBackColor = False
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
        Me.Label1.Text = "Insert Virtual field"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 592)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1074, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(1074, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(11, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 13)
        Me.lblName.TabIndex = 244
        Me.lblName.Text = "Name"
        '
        'lVM
        '
        Me.lVM.AutoSize = True
        Me.lVM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lVM.Location = New System.Drawing.Point(10, 146)
        Me.lVM.Name = "lVM"
        Me.lVM.Size = New System.Drawing.Size(11, 13)
        Me.lVM.TabIndex = 245
        Me.lVM.Text = " "
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtName.Location = New System.Drawing.Point(8, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(168, 20)
        Me.txtName.TabIndex = 248
        '
        'cbBe
        '
        Me.cbBe.AccessibleName = ""
        Me.cbBe.AutoSize = True
        Me.cbBe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBe.Location = New System.Drawing.Point(15, 41)
        Me.cbBe.Name = "cbBe"
        Me.cbBe.Size = New System.Drawing.Size(56, 17)
        Me.cbBe.TabIndex = 276
        Me.cbBe.Text = "below"
        '
        'cbAe
        '
        Me.cbAe.AccessibleName = ""
        Me.cbAe.AutoSize = True
        Me.cbAe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAe.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAe.Location = New System.Drawing.Point(15, 19)
        Me.cbAe.Name = "cbAe"
        Me.cbAe.Size = New System.Drawing.Size(58, 17)
        Me.cbAe.TabIndex = 275
        Me.cbAe.Text = "above"
        '
        'gbGde
        '
        Me.gbGde.Controls.Add(Me.cbAe)
        Me.gbGde.Controls.Add(Me.cbBe)
        Me.gbGde.Location = New System.Drawing.Point(8, 73)
        Me.gbGde.Name = "gbGde"
        Me.gbGde.Size = New System.Drawing.Size(168, 97)
        Me.gbGde.TabIndex = 323
        Me.gbGde.TabStop = False
        Me.gbGde.Visible = False
        '
        'gbType
        '
        Me.gbType.Controls.Add(Me.cbt4)
        Me.gbType.Controls.Add(Me.cbt3)
        Me.gbType.Controls.Add(Me.cbt1)
        Me.gbType.Controls.Add(Me.cbt2)
        Me.gbType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbType.Location = New System.Drawing.Point(178, 31)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(148, 139)
        Me.gbType.TabIndex = 324
        Me.gbType.TabStop = False
        Me.gbType.Text = "Type of VF"
        '
        'cbt4
        '
        Me.cbt4.AccessibleName = ""
        Me.cbt4.AutoSize = True
        Me.cbt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbt4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbt4.Location = New System.Drawing.Point(7, 91)
        Me.cbt4.Name = "cbt4"
        Me.cbt4.Size = New System.Drawing.Size(118, 17)
        Me.cbt4.TabIndex = 278
        Me.cbt4.Text = "Select from RAM"
        '
        'cbt3
        '
        Me.cbt3.AccessibleName = ""
        Me.cbt3.AutoSize = True
        Me.cbt3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbt3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbt3.Location = New System.Drawing.Point(7, 67)
        Me.cbt3.Name = "cbt3"
        Me.cbt3.Size = New System.Drawing.Size(110, 17)
        Me.cbt3.TabIndex = 277
        Me.cbt3.Text = "Select from DB"
        '
        'cbt1
        '
        Me.cbt1.AccessibleName = ""
        Me.cbt1.AutoSize = True
        Me.cbt1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbt1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbt1.Location = New System.Drawing.Point(7, 19)
        Me.cbt1.Name = "cbt1"
        Me.cbt1.Size = New System.Drawing.Size(53, 17)
        Me.cbt1.TabIndex = 275
        Me.cbt1.Text = "Label"
        '
        'cbt2
        '
        Me.cbt2.AccessibleName = ""
        Me.cbt2.AutoSize = True
        Me.cbt2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbt2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbt2.Location = New System.Drawing.Point(7, 43)
        Me.cbt2.Name = "cbt2"
        Me.cbt2.Size = New System.Drawing.Size(85, 17)
        Me.cbt2.TabIndex = 276
        Me.cbt2.Text = "Expression"
        '
        'ttekst
        '
        Me.ttekst.BackColor = System.Drawing.SystemColors.Window
        Me.ttekst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ttekst.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ttekst.Location = New System.Drawing.Point(8, 173)
        Me.ttekst.Multiline = True
        Me.ttekst.Name = "ttekst"
        Me.ttekst.Size = New System.Drawing.Size(643, 141)
        Me.ttekst.TabIndex = 328
        Me.ttekst.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(10, 321)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(11, 13)
        Me.lblDescription.TabIndex = 329
        Me.lblDescription.Text = "."
        '
        'cbFS
        '
        Me.cbFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFS.Location = New System.Drawing.Point(783, 199)
        Me.cbFS.Name = "cbFS"
        Me.cbFS.Size = New System.Drawing.Size(50, 21)
        Me.cbFS.TabIndex = 380
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(690, 371)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 20)
        Me.Label9.TabIndex = 379
        Me.Label9.Text = "Height"
        '
        'txtVS2
        '
        Me.txtVS2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVS2.Location = New System.Drawing.Point(690, 393)
        Me.txtVS2.Name = "txtVS2"
        Me.txtVS2.Size = New System.Drawing.Size(117, 21)
        Me.txtVS2.TabIndex = 378
        '
        'cbF
        '
        Me.cbF.AccessibleName = ""
        Me.cbF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbF.Location = New System.Drawing.Point(693, 199)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(84, 19)
        Me.cbF.TabIndex = 377
        Me.cbF.Text = "Font size"
        '
        'Mkc_ColorComboboxBC
        '
        Me.Mkc_ColorComboboxBC.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorComboboxBC.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.Normal
        Me.Mkc_ColorComboboxBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorComboboxBC.Location = New System.Drawing.Point(783, 173)
        Me.Mkc_ColorComboboxBC.Name = "Mkc_ColorComboboxBC"
        Me.Mkc_ColorComboboxBC.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorComboboxBC.Size = New System.Drawing.Size(144, 21)
        Me.Mkc_ColorComboboxBC.TabIndex = 376
        Me.Mkc_ColorComboboxBC.Visible = False
        '
        'Mkc_ColorComboboxFC
        '
        Me.Mkc_ColorComboboxFC.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorComboboxFC.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.Normal
        Me.Mkc_ColorComboboxFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorComboboxFC.Location = New System.Drawing.Point(783, 148)
        Me.Mkc_ColorComboboxFC.Name = "Mkc_ColorComboboxFC"
        Me.Mkc_ColorComboboxFC.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorComboboxFC.Size = New System.Drawing.Size(144, 21)
        Me.Mkc_ColorComboboxFC.TabIndex = 375
        Me.Mkc_ColorComboboxFC.Tag = "VF"
        Me.Mkc_ColorComboboxFC.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(690, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 20)
        Me.Label7.TabIndex = 374
        Me.Label7.Text = "Width"
        '
        'txtVS1
        '
        Me.txtVS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVS1.Location = New System.Drawing.Point(690, 347)
        Me.txtVS1.Name = "txtVS1"
        Me.txtVS1.Size = New System.Drawing.Size(117, 21)
        Me.txtVS1.TabIndex = 373
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(690, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 372
        Me.Label6.Text = "Behavior"
        '
        'chbBN
        '
        Me.chbBN.AccessibleName = "borderNone"
        Me.chbBN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBN.Location = New System.Drawing.Point(962, 148)
        Me.chbBN.Name = "chbBN"
        Me.chbBN.Size = New System.Drawing.Size(75, 19)
        Me.chbBN.TabIndex = 363
        Me.chbBN.Text = "None"
        '
        'chbRight
        '
        Me.chbRight.AccessibleName = "fRightA"
        Me.chbRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRight.Location = New System.Drawing.Point(962, 259)
        Me.chbRight.Name = "chbRight"
        Me.chbRight.Size = New System.Drawing.Size(82, 19)
        Me.chbRight.TabIndex = 370
        Me.chbRight.Text = "Right"
        '
        'chbCenter
        '
        Me.chbCenter.AccessibleName = "fCenterA"
        Me.chbCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCenter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCenter.Location = New System.Drawing.Point(962, 284)
        Me.chbCenter.Name = "chbCenter"
        Me.chbCenter.Size = New System.Drawing.Size(82, 19)
        Me.chbCenter.TabIndex = 369
        Me.chbCenter.Text = "Center"
        '
        'cbBC
        '
        Me.cbBC.AccessibleName = ""
        Me.cbBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBC.Location = New System.Drawing.Point(693, 173)
        Me.cbBC.Name = "cbBC"
        Me.cbBC.Size = New System.Drawing.Size(92, 19)
        Me.cbBC.TabIndex = 368
        Me.cbBC.Text = "Back color"
        '
        'cbFC
        '
        Me.cbFC.AccessibleName = ""
        Me.cbFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFC.Location = New System.Drawing.Point(693, 148)
        Me.cbFC.Name = "cbFC"
        Me.cbFC.Size = New System.Drawing.Size(92, 19)
        Me.cbFC.TabIndex = 367
        Me.cbFC.Text = "Fore color"
        '
        'chbBF
        '
        Me.chbBF.AccessibleName = "borderFixed"
        Me.chbBF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbBF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbBF.Location = New System.Drawing.Point(962, 123)
        Me.chbBF.Name = "chbBF"
        Me.chbBF.Size = New System.Drawing.Size(95, 19)
        Me.chbBF.TabIndex = 364
        Me.chbBF.Text = "Fixed single"
        '
        'cbB
        '
        Me.cbB.AccessibleName = "fontBold"
        Me.cbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbB.Location = New System.Drawing.Point(693, 123)
        Me.cbB.Name = "cbB"
        Me.cbB.Size = New System.Drawing.Size(60, 19)
        Me.cbB.TabIndex = 362
        Me.cbB.Text = "Bold"
        '
        'cbI
        '
        Me.cbI.AccessibleName = "fontItalic"
        Me.cbI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbI.Location = New System.Drawing.Point(758, 123)
        Me.cbI.Name = "cbI"
        Me.cbI.Size = New System.Drawing.Size(56, 19)
        Me.cbI.TabIndex = 361
        Me.cbI.Text = "Italic"
        '
        'cbU
        '
        Me.cbU.AccessibleName = "fontUnderline"
        Me.cbU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbU.Location = New System.Drawing.Point(819, 123)
        Me.cbU.Name = "cbU"
        Me.cbU.Size = New System.Drawing.Size(92, 19)
        Me.cbU.TabIndex = 360
        Me.cbU.Text = "Underline"
        '
        'cbe51
        '
        Me.cbe51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cbe51.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe51.Location = New System.Drawing.Point(838, 258)
        Me.cbe51.Name = "cbe51"
        Me.cbe51.Size = New System.Drawing.Size(50, 21)
        Me.cbe51.TabIndex = 359
        '
        'cbe6
        '
        Me.cbe6.AccessibleName = "multiline"
        Me.cbe6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe6.Location = New System.Drawing.Point(693, 284)
        Me.cbe6.Name = "cbe6"
        Me.cbe6.Size = New System.Drawing.Size(103, 19)
        Me.cbe6.TabIndex = 357
        Me.cbe6.Text = "Multiline"
        '
        'cbe5
        '
        Me.cbe5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbe5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbe5.Location = New System.Drawing.Point(693, 259)
        Me.cbe5.Name = "cbe5"
        Me.cbe5.Size = New System.Drawing.Size(145, 19)
        Me.cbe5.TabIndex = 358
        Me.cbe5.Text = "Multiline height in px"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(945, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 355
        Me.Label5.Text = "Border style"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(945, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 354
        Me.Label4.Text = "Text aligment"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(690, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 353
        Me.Label3.Text = "Font"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(680, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 20)
        Me.Label2.TabIndex = 352
        Me.Label2.Text = "Appereance"
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb1.Location = New System.Drawing.Point(12, 15)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(74, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Cell/field"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AccessibleDescription = " "
        Me.cb2.AutoSize = True
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb2.Location = New System.Drawing.Point(93, 15)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(47, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Row"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AccessibleDescription = " "
        Me.cb3.AutoSize = True
        Me.cb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb3.Location = New System.Drawing.Point(147, 15)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(67, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "Column"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cb3)
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Location = New System.Drawing.Point(683, 49)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(326, 38)
        Me.gbOptions.TabIndex = 351
        Me.gbOptions.TabStop = False
        Me.gbOptions.Visible = False
        '
        'gb4
        '
        Me.gb4.Controls.Add(Me.cb45)
        Me.gb4.Controls.Add(Me.cb44)
        Me.gb4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb4.Location = New System.Drawing.Point(328, 31)
        Me.gb4.Name = "gb4"
        Me.gb4.Size = New System.Drawing.Size(209, 68)
        Me.gb4.TabIndex = 352
        Me.gb4.TabStop = False
        Me.gb4.Text = "In data entry VF is recalculated "
        Me.gb4.Visible = False
        '
        'cb45
        '
        Me.cb45.AccessibleDescription = " "
        Me.cb45.AutoSize = True
        Me.cb45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb45.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb45.Location = New System.Drawing.Point(12, 40)
        Me.cb45.Name = "cb45"
        Me.cb45.Size = New System.Drawing.Size(181, 17)
        Me.cb45.TabIndex = 1
        Me.cb45.Text = "Once - on exititing PK fields"
        Me.cb45.UseVisualStyleBackColor = True
        '
        'cb44
        '
        Me.cb44.AutoSize = True
        Me.cb44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb44.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb44.Location = New System.Drawing.Point(12, 17)
        Me.cb44.Name = "cb44"
        Me.cb44.Size = New System.Drawing.Size(63, 17)
        Me.cb44.TabIndex = 0
        Me.cb44.Text = "Always"
        Me.cb44.UseVisualStyleBackColor = True
        '
        'gb5
        '
        Me.gb5.Controls.Add(Me.cb55)
        Me.gb5.Controls.Add(Me.cb56)
        Me.gb5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb5.Location = New System.Drawing.Point(328, 101)
        Me.gb5.Name = "gb5"
        Me.gb5.Size = New System.Drawing.Size(209, 69)
        Me.gb5.TabIndex = 324
        Me.gb5.TabStop = False
        Me.gb5.Text = "VF is NOT shown"
        Me.gb5.Visible = False
        '
        'cb55
        '
        Me.cb55.AccessibleName = ""
        Me.cb55.AutoSize = True
        Me.cb55.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb55.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb55.Location = New System.Drawing.Point(13, 20)
        Me.cb55.Name = "cb55"
        Me.cb55.Size = New System.Drawing.Size(124, 17)
        Me.cb55.TabIndex = 275
        Me.cb55.Text = ":F - on data entry"
        '
        'cb56
        '
        Me.cb56.AccessibleName = ""
        Me.cb56.AutoSize = True
        Me.cb56.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb56.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb56.Location = New System.Drawing.Point(13, 41)
        Me.cb56.Name = "cb56"
        Me.cb56.Size = New System.Drawing.Size(134, 17)
        Me.cb56.TabIndex = 276
        Me.cb56.Text = ":S - on data editing"
        '
        'mFormInsertVF
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1074, 622)
        Me.Controls.Add(Me.gb5)
        Me.Controls.Add(Me.gb4)
        Me.Controls.Add(Me.cbFS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtVS2)
        Me.Controls.Add(Me.cbF)
        Me.Controls.Add(Me.Mkc_ColorComboboxBC)
        Me.Controls.Add(Me.Mkc_ColorComboboxFC)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtVS1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.chbBN)
        Me.Controls.Add(Me.chbRight)
        Me.Controls.Add(Me.chbCenter)
        Me.Controls.Add(Me.cbBC)
        Me.Controls.Add(Me.cbFC)
        Me.Controls.Add(Me.chbBF)
        Me.Controls.Add(Me.cbB)
        Me.Controls.Add(Me.cbI)
        Me.Controls.Add(Me.cbU)
        Me.Controls.Add(Me.cbe51)
        Me.Controls.Add(Me.cbe6)
        Me.Controls.Add(Me.cbe5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.ttekst)
        Me.Controls.Add(Me.gbType)
        Me.Controls.Add(Me.gbGde)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lVM)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormInsertVF"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert "
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGde.ResumeLayout(False)
        Me.gbGde.PerformLayout()
        Me.gbType.ResumeLayout(False)
        Me.gbType.PerformLayout()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gb4.ResumeLayout(False)
        Me.gb4.PerformLayout()
        Me.gb5.ResumeLayout(False)
        Me.gb5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim pp() As String
    Dim ISTDB As Boolean
    Dim IST As Boolean
    Dim what As String
    Dim tipFP As String
    Dim dIst As DatasetIstrazivanja

    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String, Optional ByVal tipFP As String = "")
        InitializeComponent()
        _parentForm = form
        With Me
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.what = what
        Me.tipFP = tipFP
    End Sub

    Dim postojiCF As Boolean = False
    Dim currenttab As Integer = 0
    Dim currentred As Integer = 0
    Dim currentkol As Integer = 0

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.pp = Me.Tag.split(";")

        Dim trk() As String = pp(3).Split(".")
        If trk.Length = 3 Then
            currenttab = CInt(trk(0).Trim)
            currentred = CInt(trk(1).Trim)
            currentkol = CInt(trk(2).Trim)
        End If

        Me.Btn.Text = Me.what
        Me.Text = Me.what

        If Me.what.Trim.ToUpper = "INSERT" Then
            Me.Label1.Text = "Insert virtual field "
            gbGde.Visible = True
            gbOptions.Visible = False
            Me.txtName.Enabled = True
        Else 'format+app

            cb1.Checked = True

            Me.Label1.Text = "Set appereance for virtual field " + pp(2).Trim
            Me.txtName.Text = pp(2).Trim
            Me.txtName.Enabled = False
            gbGde.Visible = False

            If Me.tipFP = "fpDB" Then
                cbt3.Checked = True
            ElseIf Me.tipFP = "fpMEM" Then
                cbt4.Checked = True
            ElseIf Me.tipFP = "lbl" Then
                cbt1.Checked = True
            Else
                cbt2.Checked = True
            End If

        End If
    End Sub

    Dim columnAtributes As String = ""
    Dim vs As String = ""

    Private Sub cbA_CheckedChanged(sender As Object, e As EventArgs) Handles cbAe.CheckedChanged
        If cbAe.Checked = True Then cbBe.Checked = False
    End Sub

    Private Sub cbB_CheckedChanged(sender As Object, e As EventArgs) Handles cbBe.CheckedChanged
        If cbBe.Checked = True Then cbAe.Checked = False
    End Sub

    Function minRBRTabela(ByVal tabela As String, ByVal currenttab As Integer) As String
        minRBRTabela = "0"
        Dim str As String = "select isnull(min(rbr),0) as rbr from ISTpolja where sifist=N'" + sifist + "' and tabela=N'" + tabela +
            "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' "
        minRBRTabela = getrbr(str)
    End Function

    Function maxRBRTabela(ByVal tabela As String, ByVal currenttab As Integer) As String
        maxRBRTabela = "0"
        Dim str As String = "select isnull(max(rbr),0) as rbr from ISTPolja where sifist=N'" + sifist + "' and tabela=N'" + tabela +
            "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' "
        maxRBRTabela = getrbr(str)
    End Function
    Function postojiuIST(ByVal tabela As String, ByVal polje As String) As Boolean
        postojiuIST = True
        Dim sql As String = "SELECT polje FROM istpolja where sifist=N'" + sifist + "' and tabela = N'" + tabela + "' and  polje=N'" + polje + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            postojiuIST = False
        End If
    End Function

    Dim poIST As Boolean = False
    Dim poDB As Boolean = False
    Dim trebadb As Boolean = True

    Private Sub cbt1_CheckedChanged(sender As Object, e As EventArgs) Handles cbt1.CheckedChanged
        If cbt1.Checked = True Then
            ttekst.Visible = True
            If what = "insert" Then gbOptions.Visible = False Else gbOptions.Visible = True
            cbt2.Checked = False
            cbt3.Checked = False
            cbt4.Checked = False
            Me.lblDescription.Text = "Please enter alphanumeric text" + nvrd
        End If
    End Sub

    Private Sub cbt2_CheckedChanged(sender As Object, e As EventArgs) Handles cbt2.CheckedChanged

        If cbt2.Checked = True Then
            Me.gbOptions.Visible = False
            ttekst.Visible = True
            cbt1.Checked = False
            cbt3.Checked = False
            cbt4.Checked = False
            Me.lblDescription.Text = "You can use: " + nvrd +
                " 1. fields from screen - syntax is d.fieldname of #FP{fieldname} for another virtual filed" + nvrd +
                " 2. fields from table in memory (another child or parent table) - syntax is {tableName.fieldname}" + nvrd +
                " 3. fields from parent table - syntax is head.fieldname" + nvrd +
                " 4. fields from table, values from previous month - syntax is PMonth.fieldname" + nvrd +
                "                       values from previous year - syntax is PY.fieldname" + nvrd +
                "                       values from previous quarter - syntax is PQ.fieldname" + nvrd +
                "                       values from previous half year - syntax is PH.fieldname" + nvrd +
                " 5. time point     {YYY}  will be changed with year from chosen time point in IST" + nvrd +
                "                   {MMM}  will be changed with month from chosen time point in IST" + nvrd +
                "    You can use  {YYY-x},{MMM-x},{YYY+x},{MMM+x} where x is any number" + nvrd +
                " " + nvrd +
                "You can use syntax that can be applied on DataTable.Select .net command" + nvrd +
                "For type conversion use function Convert " + nvrd +
                "Examples:  Convert(d.fieldname,'System.Int32'), Convert(d.fieldname, 'System.String') " + nvrd
        End If
    End Sub

    Private Sub cbt3_CheckedChanged(sender As Object, e As EventArgs) Handles cbt3.CheckedChanged

        If cbt3.Checked = True Then
            Me.gbOptions.Visible = False
            ttekst.Visible = True
            cbt1.Checked = False
            cbt2.Checked = False
            cbt4.Checked = False
            Me.lblDescription.Text = "Select query which returns one value." + nvrd +
                "Query runs on DB" + nvrd +
                "Use usual SQL syntax" + nvrd +
                "You can all parameters for expression  (PQ.fieldname, {YYY}, d.fieldname, #FP{fieldname})" + nvrd
        End If
    End Sub

    Private Sub cbt4_CheckedChanged(sender As Object, e As EventArgs) Handles cbt4.CheckedChanged
        If cbt4.Checked = True Then
            Me.gbOptions.Visible = False
            ttekst.Visible = True
            cbt1.Checked = False
            cbt2.Checked = False
            cbt3.Checked = False
            Me.lblDescription.Text = "Select query on tables in RAM memory which returns one value." + nvrd +
                "Query runs on DataTable in memory" + nvrd +
                "Use syntax that can be applied on DataTable.Select .net command" + nvrd +
                " " + nvrd +
                " " + nvrd +
                "For type conversion use function Convert " + nvrd +
                "Examples:  Convert(d.fieldname,'System.Int32'), Convert(d.fieldname, 'System.String') " + nvrd +
                "You can all parameters for expression  (PQ.fieldname, {YYY}, d.fieldname, #FP{fieldname})" + nvrd
        End If
    End Sub

    Dim formatIzraz As String = ""
    Dim formatIzrazOst As String = ""
    Dim izraz As String = ""
    Dim label As String = ""
    Dim labelOst As String = ""
    Dim tipp As String = ""

    Function getDTC() As System.Data.DataTable
        formatIzraz = ""
        izraz = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select izraz,formatIzraz,pp " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Function getDTCtabela(ByVal strW As String) As System.Data.DataTable
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select polje,vod,izraz,isnull(formatizraz,'') as formatizraz,pp from vrepISTPolja " + strW
        getDTCtabela = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        formatIzraz = dt.Rows(0).Item("formatIzraz").ToString.Trim
        izraz = dt.Rows(0).Item("izraz").ToString.Trim
        tipp = dt.Rows(0).Item("pp").ToString.Trim
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cb2.Checked = False
            cb3.Checked = False
            Me.ttekst.Enabled = True
            Me.pp = Me.Tag.split(";")
            Dim dt As System.Data.DataTable = getDTC()
            Call EnableSve()

            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    Call getMetaDataPaneP3()
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
            Call EnableSve()
            Me.ttekst.Enabled = False
        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            cb2.Checked = False
            cb1.Checked = False
            Me.ttekst.Enabled = False
            Call disableSve()
        End If
    End Sub

    Sub disableSve()
        Me.ttekst.Enabled = True
        cbe5.Enabled = False
        cbe51.Enabled = False
        cbe6.Enabled = False
    End Sub

    Sub EnableSve()
        For Each k As Control In Me.Controls
            k.Enabled = True
        Next
    End Sub

    Function proveriIme() As Boolean

        If txtName.Text.Trim = "" Then
            ISTMessageBox.Show("Name is mandatory")
            proveriIme = False
        Else
            poIST = postojiuIST(pp(0).Trim, txtName.Text.Trim)
            If poIST = True Then
                ISTMessageBox.Show("VF with this name already exists in IST!")
                proveriIme = False
            ElseIf poIST = False Then
                proveriIme = True
            End If
        End If

    End Function

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn.Click
        If what = "insert" Then
            If proveriIme() = False Then
                Me.txtName.Focus()
                Me.txtName.SelectAll()
                Exit Sub
            End If
            If cbAe.Checked = False AndAlso cbBe.Checked = False Then cbAe.Checked = True
            If ttekst.Visible = False Then
                gbType.Focus()
                Exit Sub
            End If
            Call iinsert()
        Else
            'app
            Call uupdate()
        End If

    End Sub

    Sub iinsert()

        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim

        Dim gde As String = ""

        If cbAe.Checked = True Then gde = "above"

        Dim sqlIST As String = ""
        Dim ppolje As String = Me.txtName.Text
        Dim p2 As String = ""
        Dim rrbr As String = pp(4).Trim
        Dim pomrbr As String = ""

        Dim trk() As String = pp(3).Split(".")
        If trk.Length = 3 Then
            Dim currenttab As Integer = CInt(trk(0).Trim)
            Dim minrbrzatab As String = minRBRTabela(pp(0).Trim, currenttab)
            Dim maxrbrzatab As String = maxRBRTabela(pp(0).Trim, currenttab)
            If gde = "above" Then
                rrbr = minrbrzatab
            Else
                rrbr = maxrbrzatab
            End If
        End If

        If gde = "above" Then
            pomrbr = rrbr + 10
            rrbr = rrbr
        Else
            pomrbr = rrbr
            rrbr = rrbr + 10
        End If

        sqlIST = " update istpolja set rbr=rbr+10 where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr>=" + rrbr.Trim + ";" + nvrd
        Dim popis As String = "lRightA$Text.............."
        Dim pizraz As String = "''virtual field value''"

        Dim pfizraz As String = setMetaDataPaneP3()
        Dim tt As String = Me.ttekst.Text.Trim
        If tt.Trim = "" Then tt = "      "

        If cbt1.Checked = True Then
            If tt.Trim.IndexOf("'") = 0 AndAlso tt.Trim.LastIndexOf("'") = tt.Trim.Length - 1 Then tt = tt.Substring(1, tt.Trim.Length - 2)
            pizraz = "''" + tt.Replace("'", "''") + "''"
            pizraz = pfizraz + pizraz
        End If
        If cbt2.Checked = True Then
            If tt.Trim.IndexOf("'") = 0 AndAlso tt.Trim.LastIndexOf("'") = tt.Trim.Length - 1 Then tt = tt.Substring(1, tt.Trim.Length - 2)
            pizraz = pfizraz + tt.Replace("'", "''")
        End If
        If cbt3.Checked = True Then
            If tt.Trim.IndexOf("#{") = 0 AndAlso tt.Trim.LastIndexOf("}") = tt.Trim.Length - 1 Then tt = tt.Substring(2, tt.Trim.Length - 2)
            pizraz = pfizraz + "#{" + tt.Replace("'", "''") + exppDod() + "}"
        End If
        If cbt4.Checked = True Then
            If tt.Trim.IndexOf("#{") = 0 AndAlso tt.Trim.LastIndexOf("}") = tt.Trim.Length - 1 Then tt = tt.Substring(2, tt.Trim.Length - 2)
            pizraz = pfizraz + "#{" + tt.Replace("'", "''") + exppDod() + "}"
        End If

        sqlIST = sqlIST + "insert into istpolja (sifist,tabela,polje,vod,vdo,rbr,opis,izraz)" + nvrd +
                   " select sifist,tabela,N'" + ppolje + "' as polje,vod,vdo,'" + rrbr.Trim + "' as rbr,N'" + popis + "',N'" + pizraz + "'" +
                   " from istpolja " +
                   " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr ='" + pomrbr + "'"

        p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST)
        If p2 = "nok" Then ISTMessageBox.Show("Error!") Else Me.Close()

    End Sub

    Function exppDod() As String
        If cb44.Checked = True Then
            exppDod = ""
        ElseIf cb45.Checked = True Then
            exppDod = " :PK"
        ElseIf cb55.Checked = True Then
            exppDod = " :F"
        ElseIf cb56.Checked = True Then
            exppDod = " :S"
        Else
            exppDod = ""
        End If
    End Function

    Sub uupdate()
        Dim pizraz As String = ""
        Dim pfizraz As String = ""
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

        Try
            Me.Cursor = Cursors.WaitCursor
            'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
            'gde sam
            Dim strIST As String = ""
            If ttab = True AndAlso (cb2.Checked = True OrElse cb3.Checked = True) Then                ''ako je tabela
                Dim fforma As String = ""
                If cb2.Checked = True Then
                    fforma = Str(currenttab).Trim + "." + Str(currentred).Trim + ".%" 'row
                    strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"
                    Dim dt As System.Data.DataTable = getDTCtabela(strW)
                    If dt.Rows.Count > 0 Then
                        For i As Integer = 0 To dt.Rows.Count - 1
                            strS = ""
                            pfizraz = setMetaDataPaneP3_3(dt.Rows(i).Item("izraz").ToString.Trim, dt.Rows(i).Item("formatizraz").ToString.Trim)
                            pizraz = pfizraz + pizrazP()

                            strS = " izraz=N'" + pizraz.Trim + "'"

                            If txtVS1.Text <> "" AndAlso IsNumeric(txtVS1.Text) Then strS = strS + ", vs='" + strVs + "'"
                            strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                                   " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod").ToString.Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                            strIST = strIST + " update istpolja set " + nvrd + strS.TrimStart(",") + nvrd + strW + nvrd
                        Next
                    End If
                End If

                If cb3.Checked = True Then   'kolona , može da menja samo text samo je prazno
                    fforma = Str(currenttab).Trim + ".%." + Str(currentkol).Trim 'column
                    strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + fforma + "'"
                    Dim dt As System.Data.DataTable = getDTCtabela(strW)
                    If dt.Rows.Count > 0 Then
                        For i As Integer = 0 To dt.Rows.Count - 1
                            strS = ""
                            pfizraz = setMetaDataPaneP3_4(dt.Rows(i).Item("izraz").ToString.Trim, dt.Rows(i).Item("formatizraz").ToString.Trim)
                            pizraz = pfizraz + pizrazP()

                            strS = " izraz=N'" + pizraz.Trim + "'"

                            If txtVS1.Text <> "" AndAlso IsNumeric(txtVS1.Text) Then strS = strS + ", vs='" + strVs + "'"
                            strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + dt.Rows(i).Item("polje").ToString.Trim + "'" +
                            " and cast (vod as date)='" + Convert.ToDateTime(dt.Rows(i).Item("vod").ToString.Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "';"
                            strIST = strIST + " update istpolja set " + nvrd + strS.TrimStart(",") + nvrd + strW + nvrd
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
                pfizraz = setMetaDataPaneP3()
                pizraz = pfizraz + pizrazP()

                If pizraz.Trim <> "" Then strS = " izraz=N'" + pizraz.Trim + "'"
                If txtVS1.Text <> "" AndAlso IsNumeric(txtVS1.Text) Then strS = strS + ", vs='" + strVs + "'"
                strIST = " update istpolja set" + nvrd + strS.TrimStart(",") + nvrd + strW + ";" + nvrd
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

    Function pizrazP() As String
        pizrazP = ""
        Dim tt As String = Me.ttekst.Text.Trim
        If tt.Trim = "" Then tt = "      "
        If cbt1.Checked = True Then
            If tt.Trim.IndexOf("'") = 0 AndAlso tt.Trim.LastIndexOf("'") = tt.Trim.Length - 1 Then tt = tt.Substring(1, tt.Trim.Length - 2)
            pizrazP = "''" + tt.Replace("'", "''") + "''"
        End If
        If cbt2.Checked = True Then
            If tt.Trim.IndexOf("'") = 0 AndAlso tt.Trim.LastIndexOf("'") = tt.Trim.Length - 1 Then tt = tt.Substring(1, tt.Trim.Length - 2)
            pizrazP = tt.Replace("'", "''")
        End If
        If cbt3.Checked = True Then
            If tt.Trim.IndexOf("#{") = 0 AndAlso tt.Trim.LastIndexOf("}") = tt.Trim.Length - 1 Then tt = tt.Substring(2, tt.Trim.Length - 2)
            pizrazP = "#{" + tt.Replace("'", "''") + exppDod() + "}"
        End If
        If cbt4.Checked = True Then
            If tt.Trim.IndexOf("#{") = 0 AndAlso tt.Trim.LastIndexOf("}") = tt.Trim.Length - 1 Then tt = tt.Substring(2, tt.Trim.Length - 2)
            pizrazP = "#{" + tt.Replace("'", "''") + exppDod() + "}"
        End If
    End Function

    Function setMetaDataPaneP3() As String
        'izraz
        Dim pom As String = ""

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName + "$"
            End If
        Next
        If cbe5.Checked = True Then pom = pom + "multilineheight" + cbe51.Text + "$"

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxBC.SelectedColor = Color.Chocolate
        If Mkc_ColorComboboxFC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxFC.SelectedColor = Color.Chocolate

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow

        If cbFC.Checked = True AndAlso Mkc_ColorComboboxFC.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorComboboxFC.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorComboboxBC.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorComboboxBC.SelectedColor.Name + "$"

        If cbF.Checked = True Then
            Dim ffs As String = "8"
            Dim fs As Integer = CInt(cbFS.Text.Trim)
            ffs = CStr(fs).Trim
            pom = pom + "fontSize" + ffs + "$"
        End If

        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
        If pom = "$" Then pom = ""
        Return pom
    End Function

    Function setMetaDataPaneP3_3(ByVal izraz As String, ByVal formatIzraz As String) As String
        'izraz

        Dim fpom As String = ""
        Dim pom As String = ""
        Dim fformatIzraz As String = formatIzraz
        If fformatIzraz.Trim <> "" Then
            fformatIzraz = Replace(fformatIzraz, "frighta", "frighta" + "$", 1, , CompareMethod.Text)
            fformatIzraz = Replace(fformatIzraz, "fcentera", "fcentera" + "$", 1, , CompareMethod.Text)
            fformatIzraz = Replace(fformatIzraz, "fcentrea", "fcentrea" + "$", 1, , CompareMethod.Text)
            fformatIzraz = fformatIzraz.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")
        End If

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then fpom = fpom + k.AccessibleName + "$"
            End If
        Next

        fformatIzraz = fpom + fformatIzraz

        If cbe5.Checked = True Then pom = pom + "multilineheight" + cbe51.Text + "$"

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxBC.SelectedColor = Color.Chocolate
        If Mkc_ColorComboboxFC.SelectedColor.Name = "Chocalate" Then Mkc_ColorComboboxFC.SelectedColor = Color.Chocolate

        If Mkc_ColorComboboxBC.SelectedColor.Name = "Transparent" Then Mkc_ColorComboboxBC.SelectedColor = Color.Snow

        If cbFC.Checked = True AndAlso Mkc_ColorComboboxFC.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorComboboxFC.SelectedColor.Name + "$"
        If cbBC.Checked = True AndAlso Mkc_ColorComboboxBC.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorComboboxBC.SelectedColor.Name + "$"

        If cbF.Checked = True Then
            Dim ffs As String = "8"
            Dim fs As Integer = CInt(cbFS.Text.Trim)
            ffs = CStr(fs).Trim
            pom = pom + "fontSize" + ffs + "$"
        End If

        'row
        If pom.Trim = "" AndAlso izraz.Trim = "" Then
        ElseIf pom = "" AndAlso izraz.Trim <> "" Then
            If izraz.Trim.Substring(0, 1) = "'" Then pom = "'" + izraz.Replace("'", "") + "'"
            If izraz.Trim.Substring(0, 1) <> "'" Then pom = izraz
        ElseIf pom <> "" AndAlso izraz = "" Then
            'pom = pom
        ElseIf pom <> "" AndAlso izraz <> "" Then
            If izraz.Trim.Substring(0, 1) = "'" Then pom = pom + "$'" + izraz.Replace("'", "") + "'"
            If izraz.Trim.Substring(0, 1) <> "'" Then pom = pom + "$" + izraz + ""
        End If

        pom = pom.Replace("'", "''")
        pom = fformatIzraz + "$" + pom
        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace(";;", ";").Replace(";;", ";").Replace(";;", ";")
        Return pom
    End Function

    Function setMetaDataPaneP3_4(ByVal izraz As String, ByVal formatIzraz As String) As String
        'izraz
        Dim fpom As String = ""
        Dim pom As String = ""
        Dim fformatIzraz As String = formatIzraz
        If fformatIzraz.Trim <> "" Then
            fformatIzraz = Replace(fformatIzraz, "frighta", "frighta" + "$", 1, , CompareMethod.Text)
            fformatIzraz = Replace(fformatIzraz, "fcentera", "fcentera" + "$", 1, , CompareMethod.Text)
            fformatIzraz = Replace(fformatIzraz, "fcentrea", "fcentrea" + "$", 1, , CompareMethod.Text)
            fformatIzraz = fformatIzraz.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")
        End If

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then fpom = fpom + k.AccessibleName + "$"
            End If
        Next
        fformatIzraz = fpom + fformatIzraz
        'row
        If pom.Trim = "" AndAlso izraz.Trim = "" Then
        ElseIf pom = "" AndAlso izraz.Trim <> "" Then
            pom = izraz
            If izraz.Trim.Substring(0, 1) = "'" Then pom = "'" + izraz.Replace("'", "") + "'"
            If izraz.Trim.Substring(0, 1) <> "'" Then pom = izraz
        ElseIf pom <> "" AndAlso izraz = "" Then
            'pom = pom
        ElseIf pom <> "" AndAlso izraz <> "" Then
            If izraz.Trim.Substring(0, 1) = "'" Then pom = pom + "$'" + izraz.Replace("'", "") + "'"
            If izraz.Trim.Substring(0, 1) <> "'" Then pom = pom + "$" + izraz + ""
        End If

        If Me.ttekst.Text.Trim = "" Then izraz = "    " 'moze da se menja samo je prazno, inace svakom ostaje onaj koji je bio

        pom = pom.Replace("'", "''")
        pom = fformatIzraz + "$" + pom
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

                ElseIf pp(i).Length > 8 AndAlso pp(i).Length < 14 AndAlso pp(i).Trim.ToUpper.IndexOf("MULTILINE") = 0 AndAlso pp(i).Trim.ToUpper.IndexOf("HEIGHT") < 0 Then
                    cbe6.Checked = True
                    cbe5.Checked = False
                ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                    cbB.Checked = True
                ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                    cbI.Checked = True
                ElseIf pp(i).Length > 12 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTUNDERLINE") = 0 Then
                    cbU.Checked = True

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

    Sub getMetaDataVS()

        Dim sqlIST As String = "select isnull(vs,100),wwidth,hheight from  vrepistpolja  where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
            "' and polje=N'" + pp(2).Trim + "'" +
          " and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sqlIST, Me.ISTConnectionString, Nothing)

        If dt.Rows.Count > 0 Then
            Me.txtVS1.Text = dt.Rows(0).Item("wwidth").ToString
            Me.txtVS2.Text = dt.Rows(0).Item("hheight").ToString
        End If
    End Sub

    'Function getttt(ByVal text As String, ByVal what As String) As String
    '    getttt = ""
    '    If text.Trim.ToUpper.IndexOf(what) >= 0 Then
    '        Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
    '        getttt = text.Trim.ToUpper.Substring(b + what.Length)
    '    End If
    'End Function

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

    Private Sub cb44_CheckedChanged(sender As Object, e As EventArgs) Handles cb44.CheckedChanged
        If cb44.Checked = True Then cb45.Checked = False
    End Sub

    Private Sub cb45_CheckedChanged(sender As Object, e As EventArgs) Handles cb45.CheckedChanged
        If cb45.Checked = True Then cb44.Checked = False
    End Sub

    Private Sub cb55_CheckedChanged(sender As Object, e As EventArgs) Handles cb55.CheckedChanged
        If cb55.Checked = True Then cb56.Checked = False : cb44.Checked = False : cb45.Checked = False
    End Sub

    Private Sub cb56_CheckedChanged(sender As Object, e As EventArgs) Handles cb56.CheckedChanged
        If cb56.Checked = True Then cb55.Checked = False
    End Sub

End Class