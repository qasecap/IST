'Option Strict Off
Public Class mFormAppereancePodTabBtn
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
    Friend WithEvents Label14 As Label
    Friend WithEvents txtT2BY As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtT2BX As TextBox
    Friend WithEvents cbT2DisableMouse As CheckBox
    Friend WithEvents cbAR As CheckBox
    Friend WithEvents cbI As CheckBox
    Friend WithEvents cbB As CheckBox
    Friend WithEvents cbAC As CheckBox
    Friend WithEvents cbFS As CheckBox
    Friend WithEvents cbNoButton As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtDESO As TextBox
    Friend WithEvents txtT2BH As TextBox
    Friend WithEvents txtT2BW As TextBox
    Friend WithEvents txtGH As TextBox
    Friend WithEvents cbView As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Mkc_ColorCombobox3T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox4T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbBH As CheckBox
    Friend WithEvents cbT2BBC As CheckBox
    Friend WithEvents cbBW As CheckBox
    Friend WithEvents cbT2BFC As CheckBox
    Friend WithEvents cbHA As CheckBox
    Friend WithEvents cbScrollBar As CheckBox
    Friend WithEvents cbNoGridSpace As CheckBox
    Friend WithEvents cbNoGrid As CheckBox
    Friend WithEvents cbPanel As CheckBox
    Friend WithEvents cbGCI As CheckBox
    Friend WithEvents cbT2Max As CheckBox
    Friend WithEvents cbGH As CheckBox
    Friend WithEvents cbT2Min As CheckBox
    Friend WithEvents cbGCAR As CheckBox
    Friend WithEvents cbT2Web As CheckBox
    Friend WithEvents cbNoPlus As CheckBox
    Friend WithEvents cbBVF As CheckBox
    Friend WithEvents cbDESO As CheckBox
    Friend WithEvents cbT2HSVF As CheckBox
    Friend WithEvents cbT2VSVF As CheckBox
    Friend WithEvents tbFS As TrackBar
    Friend WithEvents cbOnButtonClick As CheckBox
    Friend WithEvents cbOnSavePanel As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCaption As TextBox
    Friend WithEvents cbU As CheckBox
    Friend WithEvents cbAL As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbN As CheckBox
    Friend WithEvents panelB As Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtT2BY = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtT2BX = New System.Windows.Forms.TextBox()
        Me.cbT2DisableMouse = New System.Windows.Forms.CheckBox()
        Me.cbAR = New System.Windows.Forms.CheckBox()
        Me.cbI = New System.Windows.Forms.CheckBox()
        Me.cbB = New System.Windows.Forms.CheckBox()
        Me.cbAC = New System.Windows.Forms.CheckBox()
        Me.cbFS = New System.Windows.Forms.CheckBox()
        Me.cbNoButton = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDESO = New System.Windows.Forms.TextBox()
        Me.txtT2BH = New System.Windows.Forms.TextBox()
        Me.txtT2BW = New System.Windows.Forms.TextBox()
        Me.txtGH = New System.Windows.Forms.TextBox()
        Me.cbView = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Mkc_ColorCombobox3T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox4T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbBH = New System.Windows.Forms.CheckBox()
        Me.cbT2BBC = New System.Windows.Forms.CheckBox()
        Me.cbBW = New System.Windows.Forms.CheckBox()
        Me.cbT2BFC = New System.Windows.Forms.CheckBox()
        Me.cbHA = New System.Windows.Forms.CheckBox()
        Me.cbScrollBar = New System.Windows.Forms.CheckBox()
        Me.cbNoGridSpace = New System.Windows.Forms.CheckBox()
        Me.cbNoGrid = New System.Windows.Forms.CheckBox()
        Me.cbPanel = New System.Windows.Forms.CheckBox()
        Me.cbGCI = New System.Windows.Forms.CheckBox()
        Me.cbT2Max = New System.Windows.Forms.CheckBox()
        Me.cbGH = New System.Windows.Forms.CheckBox()
        Me.cbT2Min = New System.Windows.Forms.CheckBox()
        Me.cbGCAR = New System.Windows.Forms.CheckBox()
        Me.cbT2Web = New System.Windows.Forms.CheckBox()
        Me.cbNoPlus = New System.Windows.Forms.CheckBox()
        Me.cbBVF = New System.Windows.Forms.CheckBox()
        Me.cbDESO = New System.Windows.Forms.CheckBox()
        Me.cbT2HSVF = New System.Windows.Forms.CheckBox()
        Me.cbT2VSVF = New System.Windows.Forms.CheckBox()
        Me.tbFS = New System.Windows.Forms.TrackBar()
        Me.cbOnButtonClick = New System.Windows.Forms.CheckBox()
        Me.cbOnSavePanel = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCaption = New System.Windows.Forms.TextBox()
        Me.cbU = New System.Windows.Forms.CheckBox()
        Me.cbAL = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbN = New System.Windows.Forms.CheckBox()
        Me.panelB = New System.Windows.Forms.Panel()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelB.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(686, 4)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(108, 24)
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
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Appereance"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 387)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(806, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(388, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 20)
        Me.Label14.TabIndex = 325
        Me.Label14.Text = "Visible false"
        '
        'txtT2BY
        '
        Me.txtT2BY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BY.Location = New System.Drawing.Point(363, 338)
        Me.txtT2BY.Name = "txtT2BY"
        Me.txtT2BY.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BY.TabIndex = 321
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(281, 317)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 324
        Me.Label18.Text = "Location"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(346, 338)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 323
        Me.Label19.Text = "Y"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(280, 338)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 322
        Me.Label20.Text = "X"
        '
        'txtT2BX
        '
        Me.txtT2BX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BX.Location = New System.Drawing.Point(298, 338)
        Me.txtT2BX.Name = "txtT2BX"
        Me.txtT2BX.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BX.TabIndex = 320
        '
        'cbT2DisableMouse
        '
        Me.cbT2DisableMouse.AccessibleName = "DisableMouse"
        Me.cbT2DisableMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2DisableMouse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2DisableMouse.Location = New System.Drawing.Point(12, 134)
        Me.cbT2DisableMouse.Name = "cbT2DisableMouse"
        Me.cbT2DisableMouse.Size = New System.Drawing.Size(222, 19)
        Me.cbT2DisableMouse.TabIndex = 319
        Me.cbT2DisableMouse.Text = "Disable mouse"
        '
        'cbAR
        '
        Me.cbAR.AccessibleName = "lRightA"
        Me.cbAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAR.Location = New System.Drawing.Point(151, 283)
        Me.cbAR.Name = "cbAR"
        Me.cbAR.Size = New System.Drawing.Size(64, 19)
        Me.cbAR.TabIndex = 314
        Me.cbAR.Text = "Right"
        '
        'cbI
        '
        Me.cbI.AccessibleName = "fontItalic"
        Me.cbI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbI.Location = New System.Drawing.Point(79, 236)
        Me.cbI.Name = "cbI"
        Me.cbI.Size = New System.Drawing.Size(64, 19)
        Me.cbI.TabIndex = 315
        Me.cbI.Text = "Italic"
        '
        'cbB
        '
        Me.cbB.AccessibleName = "fontBold"
        Me.cbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbB.Location = New System.Drawing.Point(8, 236)
        Me.cbB.Name = "cbB"
        Me.cbB.Size = New System.Drawing.Size(64, 19)
        Me.cbB.TabIndex = 312
        Me.cbB.Text = "Bold"
        '
        'cbAC
        '
        Me.cbAC.AccessibleName = "lCenterA"
        Me.cbAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAC.Location = New System.Drawing.Point(79, 283)
        Me.cbAC.Name = "cbAC"
        Me.cbAC.Size = New System.Drawing.Size(66, 19)
        Me.cbAC.TabIndex = 313
        Me.cbAC.Text = "Center"
        '
        'cbFS
        '
        Me.cbFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFS.Location = New System.Drawing.Point(8, 191)
        Me.cbFS.Name = "cbFS"
        Me.cbFS.Size = New System.Drawing.Size(53, 19)
        Me.cbFS.TabIndex = 316
        Me.cbFS.Text = "Size"
        '
        'cbNoButton
        '
        Me.cbNoButton.AccessibleName = "NoButton"
        Me.cbNoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoButton.Location = New System.Drawing.Point(265, 224)
        Me.cbNoButton.Name = "cbNoButton"
        Me.cbNoButton.Size = New System.Drawing.Size(116, 19)
        Me.cbNoButton.TabIndex = 310
        Me.cbNoButton.Text = "No button at all"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(258, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 20)
        Me.Label6.TabIndex = 295
        Me.Label6.Text = "Button apperance"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 20)
        Me.Label5.TabIndex = 294
        Me.Label5.Text = "Grid options"
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(258, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(232, 20)
        Me.Label16.TabIndex = 309
        Me.Label16.Text = "Panel options"
        '
        'txtDESO
        '
        Me.txtDESO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDESO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDESO.Location = New System.Drawing.Point(178, 90)
        Me.txtDESO.Name = "txtDESO"
        Me.txtDESO.Size = New System.Drawing.Size(45, 21)
        Me.txtDESO.TabIndex = 307
        Me.txtDESO.Visible = False
        '
        'txtT2BH
        '
        Me.txtT2BH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BH.Location = New System.Drawing.Point(330, 169)
        Me.txtT2BH.Name = "txtT2BH"
        Me.txtT2BH.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BH.TabIndex = 301
        Me.txtT2BH.Visible = False
        '
        'txtT2BW
        '
        Me.txtT2BW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BW.Location = New System.Drawing.Point(330, 192)
        Me.txtT2BW.Name = "txtT2BW"
        Me.txtT2BW.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BW.TabIndex = 299
        Me.txtT2BW.Visible = False
        '
        'txtGH
        '
        Me.txtGH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGH.Location = New System.Drawing.Point(81, 330)
        Me.txtGH.Name = "txtGH"
        Me.txtGH.Size = New System.Drawing.Size(45, 21)
        Me.txtGH.TabIndex = 280
        Me.txtGH.Visible = False
        '
        'cbView
        '
        Me.cbView.AccessibleName = "view"
        Me.cbView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbView.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbView.Location = New System.Drawing.Point(12, 68)
        Me.cbView.Name = "cbView"
        Me.cbView.Size = New System.Drawing.Size(222, 19)
        Me.cbView.TabIndex = 284
        Me.cbView.Text = "Data are read only"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 306
        Me.Label7.Visible = False
        '
        'Mkc_ColorCombobox3T
        '
        Me.Mkc_ColorCombobox3T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox3T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox3T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox3T.Location = New System.Drawing.Point(352, 269)
        Me.Mkc_ColorCombobox3T.Name = "Mkc_ColorCombobox3T"
        Me.Mkc_ColorCombobox3T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox3T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox3T.TabIndex = 303
        Me.Mkc_ColorCombobox3T.Tag = "VF"
        Me.Mkc_ColorCombobox3T.Visible = False
        '
        'Mkc_ColorCombobox4T
        '
        Me.Mkc_ColorCombobox4T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox4T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox4T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox4T.Location = New System.Drawing.Point(352, 292)
        Me.Mkc_ColorCombobox4T.Name = "Mkc_ColorCombobox4T"
        Me.Mkc_ColorCombobox4T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox4T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox4T.TabIndex = 302
        Me.Mkc_ColorCombobox4T.Tag = "VF"
        Me.Mkc_ColorCombobox4T.Visible = False
        '
        'cbBH
        '
        Me.cbBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBH.Location = New System.Drawing.Point(265, 169)
        Me.cbBH.Name = "cbBH"
        Me.cbBH.Size = New System.Drawing.Size(69, 19)
        Me.cbBH.TabIndex = 300
        Me.cbBH.Text = "Height"
        '
        'cbT2BBC
        '
        Me.cbT2BBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BBC.Location = New System.Drawing.Point(265, 292)
        Me.cbT2BBC.Name = "cbT2BBC"
        Me.cbT2BBC.Size = New System.Drawing.Size(87, 19)
        Me.cbT2BBC.TabIndex = 298
        Me.cbT2BBC.Text = "Back color"
        '
        'cbBW
        '
        Me.cbBW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBW.Location = New System.Drawing.Point(265, 192)
        Me.cbBW.Name = "cbBW"
        Me.cbBW.Size = New System.Drawing.Size(69, 19)
        Me.cbBW.TabIndex = 297
        Me.cbBW.Text = "Width"
        '
        'cbT2BFC
        '
        Me.cbT2BFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BFC.Location = New System.Drawing.Point(265, 269)
        Me.cbT2BFC.Name = "cbT2BFC"
        Me.cbT2BFC.Size = New System.Drawing.Size(87, 19)
        Me.cbT2BFC.TabIndex = 296
        Me.cbT2BFC.Text = "Fore color"
        '
        'cbHA
        '
        Me.cbHA.AccessibleName = "HORIZONTAL"
        Me.cbHA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbHA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHA.Location = New System.Drawing.Point(12, 112)
        Me.cbHA.Name = "cbHA"
        Me.cbHA.Size = New System.Drawing.Size(222, 19)
        Me.cbHA.TabIndex = 293
        Me.cbHA.Text = "Horizontal aligment for all buttons"
        '
        'cbScrollBar
        '
        Me.cbScrollBar.AccessibleName = "ScrollBar"
        Me.cbScrollBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbScrollBar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbScrollBar.Location = New System.Drawing.Point(266, 87)
        Me.cbScrollBar.Name = "cbScrollBar"
        Me.cbScrollBar.Size = New System.Drawing.Size(109, 19)
        Me.cbScrollBar.TabIndex = 290
        Me.cbScrollBar.Text = "With scroll bar"
        '
        'cbNoGridSpace
        '
        Me.cbNoGridSpace.AccessibleName = "NoGridSpace"
        Me.cbNoGridSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoGridSpace.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoGridSpace.Location = New System.Drawing.Point(12, 288)
        Me.cbNoGridSpace.Name = "cbNoGridSpace"
        Me.cbNoGridSpace.Size = New System.Drawing.Size(176, 19)
        Me.cbNoGridSpace.TabIndex = 291
        Me.cbNoGridSpace.Text = "No space between grids"
        '
        'cbNoGrid
        '
        Me.cbNoGrid.AccessibleName = "noGrid"
        Me.cbNoGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoGrid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoGrid.Location = New System.Drawing.Point(12, 351)
        Me.cbNoGrid.Name = "cbNoGrid"
        Me.cbNoGrid.Size = New System.Drawing.Size(114, 19)
        Me.cbNoGrid.TabIndex = 283
        Me.cbNoGrid.Text = "Collapse grid"
        '
        'cbPanel
        '
        Me.cbPanel.AccessibleName = "panel"
        Me.cbPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbPanel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPanel.Location = New System.Drawing.Point(266, 65)
        Me.cbPanel.Name = "cbPanel"
        Me.cbPanel.Size = New System.Drawing.Size(108, 19)
        Me.cbPanel.TabIndex = 286
        Me.cbPanel.Text = "Panel"
        '
        'cbGCI
        '
        Me.cbGCI.AccessibleName = "gridColumnsIst"
        Me.cbGCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGCI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGCI.Location = New System.Drawing.Point(12, 225)
        Me.cbGCI.Name = "cbGCI"
        Me.cbGCI.Size = New System.Drawing.Size(188, 19)
        Me.cbGCI.TabIndex = 287
        Me.cbGCI.Text = "Columns from IST"
        '
        'cbT2Max
        '
        Me.cbT2Max.AccessibleName = "Max"
        Me.cbT2Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2Max.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2Max.Location = New System.Drawing.Point(12, 267)
        Me.cbT2Max.Name = "cbT2Max"
        Me.cbT2Max.Size = New System.Drawing.Size(96, 19)
        Me.cbT2Max.TabIndex = 281
        Me.cbT2Max.Text = "Maximized"
        '
        'cbGH
        '
        Me.cbGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGH.Location = New System.Drawing.Point(12, 330)
        Me.cbGH.Name = "cbGH"
        Me.cbGH.Size = New System.Drawing.Size(63, 19)
        Me.cbGH.TabIndex = 289
        Me.cbGH.Text = "Height"
        '
        'cbT2Min
        '
        Me.cbT2Min.AccessibleName = "Min"
        Me.cbT2Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2Min.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2Min.Location = New System.Drawing.Point(12, 246)
        Me.cbT2Min.Name = "cbT2Min"
        Me.cbT2Min.Size = New System.Drawing.Size(87, 19)
        Me.cbT2Min.TabIndex = 282
        Me.cbT2Min.Text = "Minimized"
        '
        'cbGCAR
        '
        Me.cbGCAR.AccessibleName = "gridColAutoResize"
        Me.cbGCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbGCAR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGCAR.Location = New System.Drawing.Point(12, 204)
        Me.cbGCAR.Name = "cbGCAR"
        Me.cbGCAR.Size = New System.Drawing.Size(188, 19)
        Me.cbGCAR.TabIndex = 288
        Me.cbGCAR.Text = "Columns auto resize"
        '
        'cbT2Web
        '
        Me.cbT2Web.AccessibleName = "web"
        Me.cbT2Web.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2Web.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2Web.Location = New System.Drawing.Point(12, 46)
        Me.cbT2Web.Name = "cbT2Web"
        Me.cbT2Web.Size = New System.Drawing.Size(222, 19)
        Me.cbT2Web.TabIndex = 285
        Me.cbT2Web.Text = "Generate web page for this table"
        '
        'cbNoPlus
        '
        Me.cbNoPlus.AccessibleName = "NoPlus"
        Me.cbNoPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNoPlus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNoPlus.Location = New System.Drawing.Point(12, 309)
        Me.cbNoPlus.Name = "cbNoPlus"
        Me.cbNoPlus.Size = New System.Drawing.Size(87, 19)
        Me.cbNoPlus.TabIndex = 292
        Me.cbNoPlus.Text = "No + sign"
        '
        'cbBVF
        '
        Me.cbBVF.AccessibleName = "buttonVisibleFalse"
        Me.cbBVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBVF.Location = New System.Drawing.Point(265, 246)
        Me.cbBVF.Name = "cbBVF"
        Me.cbBVF.Size = New System.Drawing.Size(98, 19)
        Me.cbBVF.TabIndex = 311
        Me.cbBVF.Text = "Visible false"
        '
        'cbDESO
        '
        Me.cbDESO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDESO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDESO.Location = New System.Drawing.Point(12, 90)
        Me.cbDESO.Name = "cbDESO"
        Me.cbDESO.Size = New System.Drawing.Size(176, 19)
        Me.cbDESO.TabIndex = 308
        Me.cbDESO.Text = "Data entry screen order"
        '
        'cbT2HSVF
        '
        Me.cbT2HSVF.AccessibleName = "HorizontalScrollVisibleFalse"
        Me.cbT2HSVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2HSVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2HSVF.Location = New System.Drawing.Point(388, 110)
        Me.cbT2HSVF.Name = "cbT2HSVF"
        Me.cbT2HSVF.Size = New System.Drawing.Size(124, 19)
        Me.cbT2HSVF.TabIndex = 305
        Me.cbT2HSVF.Text = "Horizontal scroll"
        '
        'cbT2VSVF
        '
        Me.cbT2VSVF.AccessibleName = "VerticalScrollVisibleFalse"
        Me.cbT2VSVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2VSVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2VSVF.Location = New System.Drawing.Point(388, 87)
        Me.cbT2VSVF.Name = "cbT2VSVF"
        Me.cbT2VSVF.Size = New System.Drawing.Size(124, 19)
        Me.cbT2VSVF.TabIndex = 304
        Me.cbT2VSVF.Text = "Vertical scroll"
        '
        'tbFS
        '
        Me.tbFS.AccessibleName = "lHeight"
        Me.tbFS.LargeChange = 1
        Me.tbFS.Location = New System.Drawing.Point(70, 191)
        Me.tbFS.Maximum = 20
        Me.tbFS.Minimum = 6
        Me.tbFS.Name = "tbFS"
        Me.tbFS.Size = New System.Drawing.Size(84, 45)
        Me.tbFS.TabIndex = 326
        Me.tbFS.TabStop = False
        Me.tbFS.Tag = "8"
        Me.tbFS.Value = 8
        Me.tbFS.Visible = False
        '
        'cbOnButtonClick
        '
        Me.cbOnButtonClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOnButtonClick.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOnButtonClick.Location = New System.Drawing.Point(538, 46)
        Me.cbOnButtonClick.Name = "cbOnButtonClick"
        Me.cbOnButtonClick.Size = New System.Drawing.Size(152, 19)
        Me.cbOnButtonClick.TabIndex = 317
        Me.cbOnButtonClick.Text = "Button on click event"
        Me.cbOnButtonClick.Visible = False
        '
        'cbOnSavePanel
        '
        Me.cbOnSavePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOnSavePanel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOnSavePanel.Location = New System.Drawing.Point(538, 29)
        Me.cbOnSavePanel.Name = "cbOnSavePanel"
        Me.cbOnSavePanel.Size = New System.Drawing.Size(152, 19)
        Me.cbOnSavePanel.TabIndex = 318
        Me.cbOnSavePanel.Text = "Panel events"
        Me.cbOnSavePanel.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(5, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 20)
        Me.Label8.TabIndex = 328
        Me.Label8.Text = "Button caption"
        '
        'txtCaption
        '
        Me.txtCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCaption.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaption.Location = New System.Drawing.Point(5, 26)
        Me.txtCaption.Multiline = True
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(246, 110)
        Me.txtCaption.TabIndex = 327
        '
        'cbU
        '
        Me.cbU.AccessibleName = "fontUnderline"
        Me.cbU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbU.Location = New System.Drawing.Point(151, 236)
        Me.cbU.Name = "cbU"
        Me.cbU.Size = New System.Drawing.Size(85, 19)
        Me.cbU.TabIndex = 329
        Me.cbU.Text = "Underline"
        '
        'cbAL
        '
        Me.cbAL.AccessibleName = ""
        Me.cbAL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAL.Location = New System.Drawing.Point(11, 283)
        Me.cbAL.Name = "cbAL"
        Me.cbAL.Size = New System.Drawing.Size(64, 19)
        Me.cbAL.TabIndex = 330
        Me.cbAL.Text = "Left"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(5, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 20)
        Me.Label2.TabIndex = 331
        Me.Label2.Text = "Font"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(5, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 20)
        Me.Label3.TabIndex = 332
        Me.Label3.Text = "Aligment"
        '
        'cbN
        '
        Me.cbN.AccessibleName = ""
        Me.cbN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbN.Location = New System.Drawing.Point(8, 142)
        Me.cbN.Name = "cbN"
        Me.cbN.Size = New System.Drawing.Size(175, 19)
        Me.cbN.TabIndex = 333
        Me.cbN.Text = "Without DB table name"
        '
        'panelB
        '
        Me.panelB.Controls.Add(Me.txtCaption)
        Me.panelB.Controls.Add(Me.cbN)
        Me.panelB.Controls.Add(Me.tbFS)
        Me.panelB.Controls.Add(Me.Label3)
        Me.panelB.Controls.Add(Me.cbFS)
        Me.panelB.Controls.Add(Me.Label2)
        Me.panelB.Controls.Add(Me.cbAC)
        Me.panelB.Controls.Add(Me.cbAL)
        Me.panelB.Controls.Add(Me.cbB)
        Me.panelB.Controls.Add(Me.cbU)
        Me.panelB.Controls.Add(Me.cbI)
        Me.panelB.Controls.Add(Me.Label8)
        Me.panelB.Controls.Add(Me.cbAR)
        Me.panelB.Location = New System.Drawing.Point(538, 71)
        Me.panelB.Name = "panelB"
        Me.panelB.Size = New System.Drawing.Size(256, 312)
        Me.panelB.TabIndex = 334
        '
        'mFormAppereancePodTabBtn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(806, 417)
        Me.Controls.Add(Me.panelB)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtT2BY)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtT2BX)
        Me.Controls.Add(Me.cbT2DisableMouse)
        Me.Controls.Add(Me.cbOnButtonClick)
        Me.Controls.Add(Me.cbNoButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtDESO)
        Me.Controls.Add(Me.txtT2BH)
        Me.Controls.Add(Me.txtT2BW)
        Me.Controls.Add(Me.txtGH)
        Me.Controls.Add(Me.cbView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Mkc_ColorCombobox3T)
        Me.Controls.Add(Me.Mkc_ColorCombobox4T)
        Me.Controls.Add(Me.cbBH)
        Me.Controls.Add(Me.cbT2BBC)
        Me.Controls.Add(Me.cbBW)
        Me.Controls.Add(Me.cbT2BFC)
        Me.Controls.Add(Me.cbHA)
        Me.Controls.Add(Me.cbScrollBar)
        Me.Controls.Add(Me.cbNoGridSpace)
        Me.Controls.Add(Me.cbNoGrid)
        Me.Controls.Add(Me.cbPanel)
        Me.Controls.Add(Me.cbGCI)
        Me.Controls.Add(Me.cbT2Max)
        Me.Controls.Add(Me.cbGH)
        Me.Controls.Add(Me.cbT2Min)
        Me.Controls.Add(Me.cbGCAR)
        Me.Controls.Add(Me.cbT2Web)
        Me.Controls.Add(Me.cbNoPlus)
        Me.Controls.Add(Me.cbBVF)
        Me.Controls.Add(Me.cbDESO)
        Me.Controls.Add(Me.cbT2HSVF)
        Me.Controls.Add(Me.cbT2VSVF)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.cbOnSavePanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormAppereancePodTabBtn"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Appereance"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelB.ResumeLayout(False)
        Me.panelB.PerformLayout()
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
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        Dim dt As System.Data.DataTable = getDTT()
        If dt.Rows.Count = 1 Then
            Call getVariablesT(dt)
            Try
                getMetaDataPaneT1()
                getMetaDataPaneT3()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If
        Me.Label1.Text = "Appereance for  " + pp(0).Trim
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        Dim strIST As String = ""
        Dim strU As String = "update isttabele "
        Dim strS As String = ""
        Dim strW As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor
            'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
            'gde sam

            Dim pOpis As String = setMetaDataPaneT1()
            Dim pT2 As String = setMetaDataPaneT3()

            strS = " set T2=N'" + pT2 + "',opis=N'" + pOpis + "'" + nvrd
            strW = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "'" + "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

            strIST = strU + nvrd + strS + nvrd + strW

            Dim pI As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strIST)

            Me.Cursor = Cursors.Default

            If pI = "ok" Then
                ISTMessageBox.Show("Please refresh!")
                Me.Close()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim typeOfTableParentChild As String = ""
    Dim parentTableName As String = ""
    Dim ValidFrom As String = ""
    Dim ValidTo As String = ""
    Dim tableDescription As String = ""
    Dim tableOrder As String = ""

    Dim dataentryScreenOrder As String = ""
    Dim parentAtributes As String = ""
    Dim childAtributes As String = ""

    Dim tableDescriptionOst As String = ""
    Dim parentAtributesOst As String = ""

    Function getDTT() As DataTable
        typeOfTableParentChild = "" : parentTableName = "" : tableDescription = "" : dataentryScreenOrder = "" : tableOrder = ""
        parentAtributes = "" : childAtributes = "" : ValidFrom = "" : ValidTo = ""

        Dim strSQl As String = "select appCode,tableName,typeOfTableParentChild,parentTableName,tableDescription,dataentryScreenOrder," +
                " tableOrder,parentAtributes,childAtributes,ValidFrom,ValidTo from _ISTTables where appCode='" + sifist +
                "' and tableName='" + pp(0).Trim + "' and cast (validFrom as date)='" +
                Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTT = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesT(ByVal dt As DataTable)
        typeOfTableParentChild = dt.Rows(0).Item("typeOfTableParentChild").ToString.Trim
        parentTableName = dt.Rows(0).Item("parentTableName").ToString.Trim
        tableOrder = dt.Rows(0).Item("tableOrder").ToString.Trim
        tableDescription = dt.Rows(0).Item("tableDescription").ToString.Trim
        parentAtributes = dt.Rows(0).Item("parentAtributes").ToString.Trim
        childAtributes = dt.Rows(0).Item("childAtributes").ToString.Trim
        ValidFrom = CDate(dt.Rows(0).Item("VALIDFROM")).ToString("dd.MM.yyyy")
        ValidTo = CDate(dt.Rows(0).Item("VALIDTO")).ToString("dd.MM.yyyy")
        dataentryScreenOrder = dt.Rows(0).Item("dataentryScreenOrder").ToString.Trim
    End Sub

    Dim childAtributesOst As String = ""

    Sub getMetaDataPaneT3()
        Dim pp() As String = childAtributes.Split(";")
        Dim sstopif() As String = {}
        Dim sstopmsg() As String = {}
        Dim skipto() As String = {}
        Dim skipif() As String = {}
        Dim onenterskipto() As String = {}
        Dim onenterskipif() As String = {}
        Dim autolistby As String = ""
        Dim autolistto As String = ""
        Dim addnewrowto As String = ""
        Dim ffields As String = ""
        Dim vvalues As String = ""
        Dim addnewrowif As String = ""

        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("MAX") = 0 Then
                cbT2Max.Checked = True
            ElseIf pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("MIN") = 0 Then
                cbT2Min.Checked = True
            ElseIf pp(i).Length > 3 AndAlso pp(i).Trim.ToUpper.IndexOf("VIEW") = 0 Then
                cbView.Checked = True
            ElseIf pp(i).Length > 2 AndAlso pp(i).Trim.ToUpper.IndexOf("WEB") = 0 Then
                cbT2Web.Checked = True
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("DISABLEMOUSE") = 0 Then
                cbT2DisableMouse.Checked = True
            ElseIf pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("PANEL") = 0 Then
                cbPanel.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper = "SCROLLBAR" Then
                cbScrollBar.Checked = True
            ElseIf pp(i).Length > 25 AndAlso pp(i).Trim.ToUpper.IndexOf("VERTICALSCROLLVISIBLEFALSE") = 0 Then
                cbT2VSVF.Checked = True
            ElseIf pp(i).Length > 27 AndAlso pp(i).Trim.ToUpper.IndexOf("HORIZONTALSCROLLVISIBLEFALSE") = 0 Then
                cbT2HSVF.Checked = True
            ElseIf pp(i).Length > 16 AndAlso pp(i).Trim.ToUpper = "GRIDCOLAUTORESIZE" Then
                cbGCAR.Checked = True
            ElseIf pp(i).Length > 13 AndAlso pp(i).Trim.ToUpper = "GRIDCOLUMNSIST" Then
                cbGCI.Checked = True
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper = "NOGRID" Then
                cbNoGrid.Checked = True
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper = "NOPLUS" Then
                cbNoPlus.Checked = True
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper = "NOGRIDSPACE" Then
                cbNoGridSpace.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("GRIDHEIGHT") = 0 Then
                cbGH.Checked = True
                Me.txtGH.Text = pp(i).Trim.ToUpper.Split("=")(1)
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper = "HORIZONTAL" Then
                cbHA.Checked = True
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONHEIGHT") >= 0 Then
                cbBH.Checked = True
                txtT2BH.Text = pp(i).Trim.ToUpper.Split("=")(1)
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONWIDTH") >= 0 Then
                cbBW.Checked = True
                txtT2BW.Text = pp(i).Trim.ToUpper.Split("=")(1)
            ElseIf pp(i).Length > 13 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONCAPTION") = 0 Then
                txtCaption.Text = Replace(pp(i), "buttoncaption", "", 1, , CompareMethod.Text).Replace("=", "").Trim
            ElseIf pp(i).Length > 13 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONLOCATION") >= 0 Then
                'BUTTONLOCATION(X=1,Y=270)
                Dim pom As String = pp(i).Trim.ToUpper.Replace("BUTTONLOCATION", "")
                Dim p() As String = pom.Split(",")
                If p.Length = 2 Then
                    txtT2BX.Text = CInt(p(0).Trim.ToUpper.Replace("X=", "").Replace("(", ""))
                    txtT2BY.Text = CInt(p(1).Trim.ToUpper.Replace("Y=", "").Replace(")", ""))
                End If
                If p.Length = 1 Then
                    p(0) = p(0).Trim.ToUpper.Replace("(", "").Replace(")", "").Replace("=", "")
                    If p(0).Trim.ToUpper.IndexOf("X") >= 0 Then txtT2BX.Text = CInt(p(0).Trim.ToUpper.Replace("X", ""))
                    If p(0).Trim.ToUpper.IndexOf("Y") >= 0 Then txtT2BY.Text = CInt(p(0).Trim.ToUpper.Replace("Y", ""))
                End If
            ElseIf pp(i).Trim.ToUpper = "BUTTONVISIBLEFALSE" Then
                cbBVF.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper = "NOBUTTON" Then
                cbNoButton.Checked = True
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") = 0 Then
                cbT2BFC.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorCombobox3T.SelectedColor = Color.FromName(fc)
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") = 0 Then
                cbT2BBC.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorCombobox4T.SelectedColor = Color.FromName(bc)
            ElseIf pp(i).Trim <> "" Then
                childAtributesOst = childAtributesOst + "$" + pp(i).Trim
            End If
        Next

        If dataentryScreenOrder.Trim <> "" Then
            Me.cbDESO.Checked = True
            Me.txtDESO.Text = dataentryScreenOrder
        End If

    End Sub

    Sub getMetaDataPaneT1()

        tableDescriptionOst = ""

        Dim opisG As String = tableDescription
        Dim pa As String = parentAtributes
        Dim naslovForeColor As String = ""
        Dim naslovBackColor As String = ""
        Dim naslovVisina As String = ""
        Dim naslovFontSize As String = ""
        Dim naslovBackGroundColor As String = ""

        If tableDescription.Trim = "" Then Exit Sub
        Dim buttoncaption As String = ""
        Dim pp() As String = tableDescription.Split("$")

        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i) = "" Then cbN.Checked = True

            If pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                cbB.Checked = True
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTITALIC") = 0 Then
                cbI.Checked = True
            ElseIf pp(i).Length > 12 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTUNDERLINE") = 0 Then
                cbU.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("LCENTERA") = 0 Then
                cbAC.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("LRIGHTA") = 0 Then
                cbAC.Checked = True
            ElseIf pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("LLEFTA") = 0 Then
                cbAL.Checked = True
            ElseIf pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTSIZE") = 0 Then
                Dim fs As Integer = CInt(pp(i).Trim.ToUpper.Replace("FONTSIZE", ""))
                cbFS.Checked = True
                tbFS.Value = fs
                naslovFontSize = getttt(pp(i), "FONTSIZE")
            ElseIf pp(i).Trim <> "" Then
                txtCaption.Text = pp(i)
            End If
        Next

        opisG = Replace(opisG, "fontbold", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontitalic", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontunderline", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "ldesnop", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentarp", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lrighta", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "lcentera", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "llefta", "", 1, , CompareMethod.Text)
        opisG = Replace(opisG, "fontsize" + naslovFontSize.ToLower, "", 1, , CompareMethod.Text)
        opisG = opisG.Replace("$$", "$")

        If opisG.IndexOf("$") >= 0 AndAlso opisG.Trim.Substring(0, 1) = "$" Then
            cbN.Checked = True
        ElseIf opisG.Length > 0 AndAlso opisG.IndexOf("$") < 0 Then
            cbN.Checked = False
        ElseIf opisG.Length = 0 Then
            cbN.Checked = True
        End If
    End Sub

    Function setMetaDataPaneT1() As String

        Dim pom As String = ""

        For Each k As Control In panelB.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim + "$"
            End If
        Next

        If cbN.Checked = True Then pom = "$" + pom + "$"

        Dim ffs As String = "8"
        Dim fs As Integer = CInt(tbFS.Value.ToString())
        ffs = CStr(fs).Trim
        pom = pom + "fontSize" + ffs + "$"
        If Me.txtCaption.Text <> "" Then
            pom = pom + "$" + Me.txtCaption.Text.Trim + "$"
        End If
        pom = pom.Replace("$$", "$")

        'If txtCaption.Text <> "" Then pom = pom + "" + txtCaption.Text.TrimStart("'").TrimEnd("'") + ""
        Return pom
    End Function

    Function setMetaDataPaneT3() As String
        setMetaDataPaneT3 = ""
        Dim pom As String = ""

        If Me.cbDESO.Checked = True AndAlso Me.txtDESO.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill data screen entry order")
            Me.txtDESO.Focus()
            Exit Function
        End If
        If Me.cbGH.Checked = True AndAlso Me.txtGH.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill grid height")
            Me.txtGH.Focus()
            Exit Function
        End If
        If Me.cbBW.Checked = True AndAlso Me.txtT2BW.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill button width")
            Me.txtT2BW.Focus()
            Exit Function
        End If
        If Me.cbBH.Checked = True AndAlso Me.txtT2BH.Text.Trim = "" Then
            ISTMessageBox.Show("Please, fill button height")
            Me.txtT2BH.Focus()
            Exit Function
        End If
        'If Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text = "" Then
        '    ISTMessageBox.Show("Please, fill button location Y")
        '    Me.txtT2BY.Focus()
        '    Exit Function
        'End If
        'If Me.txtT2BX.Text = "" AndAlso Me.txtT2BY.Text <> "" Then
        '    ISTMessageBox.Show("Please, fill button location X")
        '    Me.txtT2BX.Focus()
        '    Exit Function
        'End If

        'dataentryScreenOrder
        If Me.cbDESO.Checked = True AndAlso Me.txtDESO.Text <> "" Then dataentryScreenOrder = Me.txtDESO.Text

        For Each k As Control In Me.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                Dim text As String = k.AccessibleName.Trim
                If DirectCast(k, CheckBox).Checked = True Then If pom.Trim.ToUpper.IndexOf(text.Trim.ToUpper) < 0 Then pom = pom + text + ";"
            End If
        Next
        'If cbFS.Checked = True Then
        '    Dim ffbs As String = "8"
        '    Dim fsbs As Integer = CInt(tbFS.Value.ToString())
        '    ffbs = CStr(fsbs).Trim
        '    pom = pom + "fontSize" + ffbs + ";"
        'End If

        If Me.cbGH.Checked = True Then pom = pom + "gridHeight=" + Me.txtGH.Text.Trim + ";"
        If Me.cbBW.Checked = True Then pom = pom + "buttonWidth=" + Me.txtT2BW.Text.Trim + ";"
        If Me.cbBH.Checked = True Then pom = pom + "buttonHeight=" + Me.txtT2BH.Text.Trim + ";"

        If Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text = "" Then
            pom = pom + "buttonLocation(X=" + Me.txtT2BX.Text.Trim + ");"
        ElseIf Me.txtT2BX.Text = "" AndAlso Me.txtT2BY.Text <> "" Then
            pom = pom + "buttonLocation(Y=" + Me.txtT2BY.Text.Trim + ");"
        ElseIf Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text <> "" Then
            pom = pom + "buttonLocation(X=" + Me.txtT2BX.Text.Trim + ",Y=" + Me.txtT2BY.Text.Trim + ");"
        End If

        If Mkc_ColorCombobox4T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox4T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox3T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox3T.SelectedColor = Color.Chocolate

        If Mkc_ColorCombobox4T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox4T.SelectedColor = Color.Snow

        If cbT2BFC.Checked = True AndAlso Mkc_ColorCombobox3T.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorCombobox3T.SelectedColor.Name + ";"
        If cbT2BBC.Checked = True AndAlso Mkc_ColorCombobox4T.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorCombobox4T.SelectedColor.Name + ";"

        pom = pom.Replace(";;", ";").Replace(";;", ";").Replace(";;", ";").Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")
        If Me.txtCaption.Text <> "" Then
            pom = pom + "buttonCaption=" + Me.txtCaption.Text.Trim + ";"
        End If
        If childAtributesOst.Trim = "" Then
            'pom
        ElseIf pom.Trim = "" AndAlso childAtributesOst.Trim <> "" Then
            pom = childAtributesOst
        ElseIf pom.Trim <> "" AndAlso childAtributesOst.Trim <> "" Then
            pom = pom + ";" + childAtributesOst
        End If

        Return pom

    End Function

    Private Sub cbDESO_CheckedChanged(sender As Object, e As EventArgs) Handles cbDESO.CheckedChanged
        txtDESO.Visible = cbDESO.Checked
        txtDESO.Focus()
    End Sub

    Private Sub cbGH_CheckedChanged(sender As Object, e As EventArgs) Handles cbGH.CheckedChanged
        txtGH.Visible = cbGH.Checked
        txtGH.Focus()
    End Sub

    Private Sub cbBH_CheckedChanged(sender As Object, e As EventArgs) Handles cbBH.CheckedChanged
        txtT2BH.Visible = cbBH.Checked
        txtT2BH.Focus()
    End Sub

    Private Sub cbBW_CheckedChanged(sender As Object, e As EventArgs) Handles cbBW.CheckedChanged
        txtT2BW.Visible = cbBW.Checked
        txtT2BW.Focus()
    End Sub

    Private Sub cbT2BFC_CheckedChanged(sender As Object, e As EventArgs) Handles cbT2BFC.CheckedChanged
        Mkc_ColorCombobox3T.Visible = cbT2BFC.Checked
        If cbT2BFC.Checked = False Then
            Mkc_ColorCombobox3T.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_ColorCombobox3T.Focus()
        End If
    End Sub

    Private Sub cbT2BBC_CheckedChanged(sender As Object, e As EventArgs) Handles cbT2BBC.CheckedChanged
        Mkc_ColorCombobox4T.Visible = cbT2BBC.Checked
        If cbT2BBC.Checked = False Then
            Mkc_ColorCombobox4T.SelectedColor = System.Drawing.Color.Empty
        Else
            Mkc_ColorCombobox4T.Focus()
        End If
    End Sub

    Private Sub cbT2BS_CheckedChanged(sender As Object, e As EventArgs) Handles cbFS.CheckedChanged
        tbFS.Visible = cbFS.Checked
        If cbFS.Checked = True Then tbFS.Value = tbFS.Tag
    End Sub

    Private Sub cbT2BAC_CheckedChanged(sender As Object, e As EventArgs) Handles cbAC.CheckedChanged
        If cbAC.Checked = True Then
            cbAL.Checked = False
            cbAR.Checked = False
        End If
    End Sub

    Private Sub ccbT2BAL_CheckedChanged(sender As Object, e As EventArgs) Handles cbAL.CheckedChanged
        If cbAL.Checked = True Then
            cbAC.Checked = False
            cbAR.Checked = False
        End If
    End Sub

    Private Sub cbT2BAR_CheckedChanged(sender As Object, e As EventArgs) Handles cbAR.CheckedChanged
        If cbAR.Checked = True Then
            cbAL.Checked = False
            cbAC.Checked = False
        End If
    End Sub

End Class