'Option Strict Off

Imports System.Web

Public Class mFormInsertButton
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
    Friend WithEvents btnInsert As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bb11 As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbB As CheckBox
    Friend WithEvents gbGde As GroupBox
    Friend WithEvents cbA As CheckBox
    Friend WithEvents lblE As Label
    Friend WithEvents txtE As TextBox
    Friend WithEvents panelB As Panel
    Friend WithEvents txtCaption As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbFS As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbAC As CheckBox
    Friend WithEvents cbAL As CheckBox
    Friend WithEvents cbBold As CheckBox
    Friend WithEvents cbU As CheckBox
    Friend WithEvents cbI As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbAR As CheckBox
    Friend WithEvents txtT2BY As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtT2BX As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtT2BH As TextBox
    Friend WithEvents txtT2BW As TextBox
    Friend WithEvents Mkc_ColorCombobox3T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents Mkc_ColorCombobox4T As mkc_ColorCombobox.mkc_ColorCombobox
    Friend WithEvents cbBH As CheckBox
    Friend WithEvents cbT2BBC As CheckBox
    Friend WithEvents cbBW As CheckBox
    Friend WithEvents cbT2BFC As CheckBox
    Friend WithEvents cbVF As CheckBox
    Friend WithEvents cbNTS As CheckBox
    Friend WithEvents cbEF As CheckBox
    Friend WithEvents tbFS As TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.bb11 = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbB = New System.Windows.Forms.CheckBox()
        Me.gbGde = New System.Windows.Forms.GroupBox()
        Me.cbA = New System.Windows.Forms.CheckBox()
        Me.lblE = New System.Windows.Forms.Label()
        Me.txtE = New System.Windows.Forms.TextBox()
        Me.panelB = New System.Windows.Forms.Panel()
        Me.tbFS = New System.Windows.Forms.TextBox()
        Me.txtCaption = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbFS = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbAC = New System.Windows.Forms.CheckBox()
        Me.cbAL = New System.Windows.Forms.CheckBox()
        Me.cbBold = New System.Windows.Forms.CheckBox()
        Me.cbU = New System.Windows.Forms.CheckBox()
        Me.cbI = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbAR = New System.Windows.Forms.CheckBox()
        Me.txtT2BY = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtT2BX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtT2BH = New System.Windows.Forms.TextBox()
        Me.txtT2BW = New System.Windows.Forms.TextBox()
        Me.Mkc_ColorCombobox3T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.Mkc_ColorCombobox4T = New mkc_ColorCombobox.mkc_ColorCombobox()
        Me.cbBH = New System.Windows.Forms.CheckBox()
        Me.cbT2BBC = New System.Windows.Forms.CheckBox()
        Me.cbBW = New System.Windows.Forms.CheckBox()
        Me.cbT2BFC = New System.Windows.Forms.CheckBox()
        Me.cbVF = New System.Windows.Forms.CheckBox()
        Me.cbNTS = New System.Windows.Forms.CheckBox()
        Me.cbEF = New System.Windows.Forms.CheckBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGde.SuspendLayout()
        Me.panelB.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnInsert.Location = New System.Drawing.Point(445, 3)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(190, 24)
        Me.btnInsert.TabIndex = 1
        Me.btnInsert.TabStop = False
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = False
        Me.btnInsert.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Insert Button"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnInsert)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 508)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(640, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'bb11
        '
        Me.bb11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bb11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bb11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.bb11.Location = New System.Drawing.Point(445, 54)
        Me.bb11.Name = "bb11"
        Me.bb11.Size = New System.Drawing.Size(190, 23)
        Me.bb11.TabIndex = 331
        Me.bb11.TabStop = False
        Me.bb11.Text = "Check name"
        Me.bb11.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(128, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 13)
        Me.lblName.TabIndex = 328
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtName.Location = New System.Drawing.Point(125, 56)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(314, 20)
        Me.txtName.TabIndex = 329
        '
        'cbB
        '
        Me.cbB.AccessibleName = ""
        Me.cbB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbB.Location = New System.Drawing.Point(15, 41)
        Me.cbB.Name = "cbB"
        Me.cbB.Size = New System.Drawing.Size(78, 20)
        Me.cbB.TabIndex = 276
        Me.cbB.Text = "below"
        '
        'gbGde
        '
        Me.gbGde.Controls.Add(Me.cbA)
        Me.gbGde.Controls.Add(Me.cbB)
        Me.gbGde.Location = New System.Drawing.Point(5, 30)
        Me.gbGde.Name = "gbGde"
        Me.gbGde.Size = New System.Drawing.Size(116, 74)
        Me.gbGde.TabIndex = 330
        Me.gbGde.TabStop = False
        '
        'cbA
        '
        Me.cbA.AccessibleName = ""
        Me.cbA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbA.Location = New System.Drawing.Point(15, 19)
        Me.cbA.Name = "cbA"
        Me.cbA.Size = New System.Drawing.Size(78, 20)
        Me.cbA.TabIndex = 275
        Me.cbA.Text = "above"
        '
        'lblE
        '
        Me.lblE.AutoSize = True
        Me.lblE.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblE.Location = New System.Drawing.Point(128, 82)
        Me.lblE.Name = "lblE"
        Me.lblE.Size = New System.Drawing.Size(52, 13)
        Me.lblE.TabIndex = 332
        Me.lblE.Text = "Execute"
        '
        'txtE
        '
        Me.txtE.BackColor = System.Drawing.SystemColors.Window
        Me.txtE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtE.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtE.Location = New System.Drawing.Point(125, 102)
        Me.txtE.Multiline = True
        Me.txtE.Name = "txtE"
        Me.txtE.Size = New System.Drawing.Size(510, 82)
        Me.txtE.TabIndex = 333
        '
        'panelB
        '
        Me.panelB.Controls.Add(Me.tbFS)
        Me.panelB.Controls.Add(Me.txtCaption)
        Me.panelB.Controls.Add(Me.Label3)
        Me.panelB.Controls.Add(Me.cbFS)
        Me.panelB.Controls.Add(Me.Label2)
        Me.panelB.Controls.Add(Me.cbAC)
        Me.panelB.Controls.Add(Me.cbAL)
        Me.panelB.Controls.Add(Me.cbBold)
        Me.panelB.Controls.Add(Me.cbU)
        Me.panelB.Controls.Add(Me.cbI)
        Me.panelB.Controls.Add(Me.Label8)
        Me.panelB.Controls.Add(Me.cbAR)
        Me.panelB.Location = New System.Drawing.Point(379, 187)
        Me.panelB.Name = "panelB"
        Me.panelB.Size = New System.Drawing.Size(256, 312)
        Me.panelB.TabIndex = 351
        '
        'tbFS
        '
        Me.tbFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFS.Location = New System.Drawing.Point(79, 193)
        Me.tbFS.Name = "tbFS"
        Me.tbFS.Size = New System.Drawing.Size(45, 21)
        Me.tbFS.TabIndex = 354
        Me.tbFS.Visible = False
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
        'cbBold
        '
        Me.cbBold.AccessibleName = "fontBold"
        Me.cbBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBold.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBold.Location = New System.Drawing.Point(8, 236)
        Me.cbBold.Name = "cbBold"
        Me.cbBold.Size = New System.Drawing.Size(64, 19)
        Me.cbBold.TabIndex = 312
        Me.cbBold.Text = "Bold"
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
        'txtT2BY
        '
        Me.txtT2BY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BY.Location = New System.Drawing.Point(231, 423)
        Me.txtT2BY.Name = "txtT2BY"
        Me.txtT2BY.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BY.TabIndex = 347
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(149, 402)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 350
        Me.Label18.Text = "Location"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(214, 423)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 13)
        Me.Label19.TabIndex = 349
        Me.Label19.Text = "Y"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(148, 423)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 13)
        Me.Label20.TabIndex = 348
        Me.Label20.Text = "X"
        '
        'txtT2BX
        '
        Me.txtT2BX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BX.Location = New System.Drawing.Point(166, 423)
        Me.txtT2BX.Name = "txtT2BX"
        Me.txtT2BX.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BX.TabIndex = 346
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(126, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(232, 20)
        Me.Label6.TabIndex = 335
        Me.Label6.Text = "Button apperance"
        '
        'txtT2BH
        '
        Me.txtT2BH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BH.Location = New System.Drawing.Point(198, 216)
        Me.txtT2BH.Name = "txtT2BH"
        Me.txtT2BH.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BH.TabIndex = 341
        Me.txtT2BH.Visible = False
        '
        'txtT2BW
        '
        Me.txtT2BW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT2BW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtT2BW.Location = New System.Drawing.Point(198, 242)
        Me.txtT2BW.Name = "txtT2BW"
        Me.txtT2BW.Size = New System.Drawing.Size(45, 21)
        Me.txtT2BW.TabIndex = 339
        Me.txtT2BW.Visible = False
        '
        'Mkc_ColorCombobox3T
        '
        Me.Mkc_ColorCombobox3T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mkc_ColorCombobox3T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox3T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox3T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox3T.Location = New System.Drawing.Point(220, 346)
        Me.Mkc_ColorCombobox3T.Name = "Mkc_ColorCombobox3T"
        Me.Mkc_ColorCombobox3T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox3T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox3T.TabIndex = 343
        Me.Mkc_ColorCombobox3T.Tag = "VF"
        Me.Mkc_ColorCombobox3T.Visible = False
        '
        'Mkc_ColorCombobox4T
        '
        Me.Mkc_ColorCombobox4T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Mkc_ColorCombobox4T.ColorType = mkc_ColorCombobox.mkc_ColorCombobox.ColorEnum.KnownColor
        Me.Mkc_ColorCombobox4T.FocusStyle = mkc_ColorCombobox.mkc_ColorCombobox.FocusStyleEnum.IDE
        Me.Mkc_ColorCombobox4T.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mkc_ColorCombobox4T.Location = New System.Drawing.Point(220, 372)
        Me.Mkc_ColorCombobox4T.Name = "Mkc_ColorCombobox4T"
        Me.Mkc_ColorCombobox4T.SelectedColor = System.Drawing.Color.Empty
        Me.Mkc_ColorCombobox4T.Size = New System.Drawing.Size(150, 21)
        Me.Mkc_ColorCombobox4T.TabIndex = 342
        Me.Mkc_ColorCombobox4T.Tag = "VF"
        Me.Mkc_ColorCombobox4T.Visible = False
        '
        'cbBH
        '
        Me.cbBH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBH.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBH.Location = New System.Drawing.Point(133, 216)
        Me.cbBH.Name = "cbBH"
        Me.cbBH.Size = New System.Drawing.Size(69, 19)
        Me.cbBH.TabIndex = 340
        Me.cbBH.Text = "Height"
        '
        'cbT2BBC
        '
        Me.cbT2BBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BBC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BBC.Location = New System.Drawing.Point(133, 372)
        Me.cbT2BBC.Name = "cbT2BBC"
        Me.cbT2BBC.Size = New System.Drawing.Size(87, 19)
        Me.cbT2BBC.TabIndex = 338
        Me.cbT2BBC.Text = "Back color"
        '
        'cbBW
        '
        Me.cbBW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBW.Location = New System.Drawing.Point(133, 242)
        Me.cbBW.Name = "cbBW"
        Me.cbBW.Size = New System.Drawing.Size(69, 19)
        Me.cbBW.TabIndex = 337
        Me.cbBW.Text = "Width"
        '
        'cbT2BFC
        '
        Me.cbT2BFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbT2BFC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbT2BFC.Location = New System.Drawing.Point(133, 346)
        Me.cbT2BFC.Name = "cbT2BFC"
        Me.cbT2BFC.Size = New System.Drawing.Size(87, 19)
        Me.cbT2BFC.TabIndex = 336
        Me.cbT2BFC.Text = "Fore color"
        '
        'cbVF
        '
        Me.cbVF.AccessibleName = "buttonVisibleFalse"
        Me.cbVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbVF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVF.Location = New System.Drawing.Point(133, 320)
        Me.cbVF.Name = "cbVF"
        Me.cbVF.Size = New System.Drawing.Size(98, 19)
        Me.cbVF.TabIndex = 345
        Me.cbVF.Text = "Visible false"
        '
        'cbNTS
        '
        Me.cbNTS.AccessibleDescription = "buttonNoTabStop"
        Me.cbNTS.AccessibleName = ""
        Me.cbNTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNTS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNTS.Location = New System.Drawing.Point(133, 268)
        Me.cbNTS.Name = "cbNTS"
        Me.cbNTS.Size = New System.Drawing.Size(98, 19)
        Me.cbNTS.TabIndex = 352
        Me.cbNTS.Text = "No TabStop"
        '
        'cbEF
        '
        Me.cbEF.AccessibleDescription = "buttonEnabledFalse"
        Me.cbEF.AccessibleName = ""
        Me.cbEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbEF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEF.Location = New System.Drawing.Point(133, 294)
        Me.cbEF.Name = "cbEF"
        Me.cbEF.Size = New System.Drawing.Size(171, 19)
        Me.cbEF.TabIndex = 353
        Me.cbEF.Text = "Enabled false"
        '
        'mFormInsertButton
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(640, 538)
        Me.Controls.Add(Me.cbEF)
        Me.Controls.Add(Me.cbNTS)
        Me.Controls.Add(Me.panelB)
        Me.Controls.Add(Me.txtT2BY)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtT2BX)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtT2BH)
        Me.Controls.Add(Me.txtT2BW)
        Me.Controls.Add(Me.Mkc_ColorCombobox3T)
        Me.Controls.Add(Me.Mkc_ColorCombobox4T)
        Me.Controls.Add(Me.cbBH)
        Me.Controls.Add(Me.cbT2BBC)
        Me.Controls.Add(Me.cbBW)
        Me.Controls.Add(Me.cbT2BFC)
        Me.Controls.Add(Me.cbVF)
        Me.Controls.Add(Me.lblE)
        Me.Controls.Add(Me.txtE)
        Me.Controls.Add(Me.bb11)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.gbGde)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormInsertButton"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert Button"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGde.ResumeLayout(False)
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
    Dim dIst As DatasetIstrazivanja
    Dim pp() As String
    Dim gde As String
    Dim IST As Boolean
    Dim what As String

    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String,
                   ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String)
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
        Me.what = what
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.pp = Me.Tag.split(";")
        cbB.Checked = True
        Me.Text = Me.what

        If Me.what.Trim.ToUpper = "FORMAT" Then
            txtName.Visible = False
            lblName.Visible = False
            bb11.Visible = False
            btnInsert.Visible = True
            gbGde.Visible = False
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    getMetaDataPaneP1()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
            Me.Label1.Text = "Button appereance"
        Else   'INSERT
            gde = "below"
            If cbA.Checked = True Then gde = "above"
            Me.btnInsert.Visible = False
        End If

    End Sub

    Private Sub cbA_CheckedChanged(sender As Object, e As EventArgs) Handles cbA.CheckedChanged
        If cbA.Checked = True Then cbB.Checked = False
    End Sub

    Private Sub cbB_CheckedChanged(sender As Object, e As EventArgs) Handles cbB.CheckedChanged
        If cbB.Checked = True Then cbA.Checked = False
    End Sub

    Dim ood As String = ""
    Dim vvs As String = ""
    Dim oopis As String = ""
    Dim fformatopis As String = ""

    Function getDTC() As System.Data.DataTable
        ood = ""
        vvs = ""
        oopis = ""
        fformatopis = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select od,vs,opis,formatopis " +
                " from vrepISTPolja " +
                " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "' and pp='bb'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        ood = dt.Rows(0).Item("od").ToString.Trim
        vvs = dt.Rows(0).Item("vs").ToString.Trim
        oopis = dt.Rows(0).Item("opis").ToString.Trim
        fformatopis = dt.Rows(0).Item("formatopis").ToString.Trim
    End Sub

    Function minRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
        Dim str As String = "select top 1 rbr from vrepISTPolja where sifist='" + sifist + "' and tabela='" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' order by cast(rbr as int)"
        minRBRTabela = getrbr(str)
    End Function

    Function maxRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
        Dim str As String = "select top 1 rbr from vrepISTPolja where sifist='" + sifist + "' and tabela='" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' order by cast(rbr as int) desc"
        maxRBRTabela = getrbr(str)
    End Function

    Function dajUniqueImeIST(ByVal tabela As String, ByVal cname As String) As String
        Dim sql As String = ""
        dajUniqueImeIST = cname + "1"
        For i As Integer = 1 To 100000
            sql = "select polje FROM istpolja where sifist='" + sifist + "' and tabela='" + tabela + "' and polje='" + cname + CStr(i).Trim + "'"
            Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
            If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                dajUniqueImeIST = cname + CStr(i).Trim
                Exit For
            End If
        Next
    End Function

    Function getrbr(ByVal sqlrbr As String) As String
        Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
        If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 Then
            getrbr = dt1.Rows(0).Item("rbr").ToString
        Else
            getrbr = "0"
        End If
    End Function

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnInsert.Click
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim sqlIST As String = ""
        Dim ppolje As String = dajUniqueImeIST(pp(0).Trim, "btn_")
        Dim p2 As String = ""
        Dim rrbr As String = pp(4).Trim
        Dim pomrbr As String = ""
        Dim trk() As String = pp(3).Split(".")
        If trk.Length = 3 Then
            Dim currenttab As Integer = CInt(trk(0).Trim)
            Dim minrbrzatab As String = minRBRTabela(currenttab, pp(0).Trim)
            Dim maxrbrzatab As String = maxRBRTabela(currenttab, pp(0).Trim)
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
        sqlIST = " update istpolja Set rbr=rbr+10 where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr>=" + rrbr.Trim + ";" + nvrd

        Dim popis As String = setMetaDataPaneP1()

        Dim pod As String = Me.txtE.Text.Trim
        If pod <> "" AndAlso pod.Length > 2 AndAlso pod.Substring(0, 2) <> "#{" Then pod = "#{" + pod
        If pod <> "" AndAlso pod.Length > 2 AndAlso pod.Substring(pod.Length - 1, 1) <> "}" Then pod = pod + "}"
        pod = pod.Replace("'", "''")

        'Dim pvs As String = ""
        If Me.what.Trim.ToUpper = "INSERT" Then
            sqlIST = sqlIST + "insert into istpolja (sifist,tabela,polje,vod,vdo,rbr,opis,izraz,vs,od)" + nvrd +
              " select sifist,tabela,'" + ppolje + "' as polje,vod,vdo,'" + rrbr.Trim + "' as rbr,'" + popis + "','Button','100',N'" + pod + "'" +
              " from istpolja " +
              " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr ='" + pomrbr + "'"
        Else
            sqlIST = "update istpolja set opis=N'" + popis + "',izraz='Button', od=N'" + pod + "'" + nvrd +
             " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and rbr ='" + pomrbr + "'"
        End If

        p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST)

        If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to IST!") Else Me.Close()

    End Sub

    Sub getMetaDataPaneP1()

        Dim naslovFontSize As String = ""
        If oopis Is Nothing OrElse oopis.Trim = "" Then Exit Sub

        txtCaption.Text = oopis
        If ood <> "" AndAlso ood.Length > 2 AndAlso ood.Substring(0, 2) = "#{" Then ood = ood.Substring(2)
        If ood <> "" AndAlso ood.Length > 2 AndAlso ood.Substring(ood.Length - 1, 1) = "}" Then ood = ood.Substring(0, ood.Length - 1)
        txtE.Text = ood

        Dim pp() As String = fformatopis.Split("$")

        For i As Integer = 0 To pp.GetUpperBound(0)
            pp(i) = pp(i).Replace(vbCrLf, "").Trim
            If pp(i).Length > 7 AndAlso pp(i).Trim.ToUpper.IndexOf("FONTBOLD") = 0 Then
                cbBold.Checked = True
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
                tbFS.Text = fs
                naslovFontSize = getttt(pp(i), "FONTSIZE")
            ElseIf pp(i).Length > 11 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONHEIGHT") >= 0 Then
                cbBH.Checked = True : txtT2BH.Visible = True
                txtT2BH.Text = pp(i).Trim.ToUpper.Split("=")(1)
            ElseIf pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("BUTTONWIDTH") >= 0 Then
                cbBW.Checked = True : txtT2BW.Visible = True
                txtT2BW.Text = pp(i).Trim.ToUpper.Split("=")(1)
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
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("FORECOLOR") = 0 Then
                cbT2BFC.Checked = True
                Dim fc As String = getttt(pp(i), "FORECOLOR")
                If fc <> "" Then Mkc_ColorCombobox3T.SelectedColor = Color.FromName(fc)
            ElseIf pp(i).Length > 8 AndAlso pp(i).Trim.ToUpper.IndexOf("BACKCOLOR") = 0 Then
                cbT2BBC.Checked = True
                Dim bc As String = getttt(pp(i), "BACKCOLOR")
                If bc <> "" Then Mkc_ColorCombobox4T.SelectedColor = Color.FromName(bc)
            End If
        Next

    End Sub

    'Function getttt(ByVal text As String, ByVal what As String) As String
    '    getttt = ""
    '    If text.Trim.ToUpper.IndexOf(what) >= 0 Then
    '        Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
    '        getttt = text.Trim.ToUpper.Substring(b + what.Length)
    '    End If
    'End Function

    Function setMetaDataPaneP1() As String

        Dim pom As String = ""

        For Each k As Control In panelB.Controls
            If TypeOf k Is CheckBox AndAlso Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim <> "" Then
                If DirectCast(k, CheckBox).Checked = True Then pom = pom + k.AccessibleName.Trim + "$"
            End If
        Next

        Dim ffs As String = "8"
        If tbFS.Text.Trim <> "" AndAlso IsNumeric(tbFS.Text.Trim) Then ffs = tbFS.Text

        pom = pom + "fontSize" + ffs + "$"
        pom = pom.Replace("$$", "$")

        If txtCaption.Text <> "" Then pom = pom + "" + txtCaption.Text.TrimStart("'").TrimEnd("'") + "$"
        If txtCaption.Text = "" OrElse txtCaption.Text = "''" Then pom = pom + "Button$"
        If Me.cbBW.Checked = True Then pom = pom + "buttonWidth=" + Me.txtT2BW.Text.Trim + "$"
        If Me.cbBH.Checked = True Then pom = pom + "buttonHeight=" + Me.txtT2BH.Text.Trim + "$"

        If Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text = "" Then
            pom = pom + "buttonLocation(X=" + Me.txtT2BX.Text.Trim + ")$"
        ElseIf Me.txtT2BX.Text = "" AndAlso Me.txtT2BY.Text <> "" Then
            pom = pom + "buttonLocation(Y=" + Me.txtT2BY.Text.Trim + ")$"
        ElseIf Me.txtT2BX.Text <> "" AndAlso Me.txtT2BY.Text <> "" Then
            pom = pom + "buttonLocation(X=" + Me.txtT2BX.Text.Trim + ",Y=" + Me.txtT2BY.Text.Trim + ")$"
        End If

        If Mkc_ColorCombobox4T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox4T.SelectedColor = Color.Chocolate
        If Mkc_ColorCombobox3T.SelectedColor.Name = "Chocalate" Then Mkc_ColorCombobox3T.SelectedColor = Color.Chocolate

        If Mkc_ColorCombobox4T.SelectedColor.Name = "Transparent" Then Mkc_ColorCombobox4T.SelectedColor = Color.Snow

        If cbT2BFC.Checked = True AndAlso Mkc_ColorCombobox3T.SelectedColor.Name <> "0" Then pom = pom + "foreColor" + Mkc_ColorCombobox3T.SelectedColor.Name + "$"
        If cbT2BBC.Checked = True AndAlso Mkc_ColorCombobox4T.SelectedColor.Name <> "0" Then pom = pom + "backColor" + Mkc_ColorCombobox4T.SelectedColor.Name + "$"

        pom = pom.Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace("$$", "$").Replace("$$", "$")

        Return pom
    End Function

    Dim poIST As Boolean = False

    Function postojiuIST(ByVal tabela As String, ByVal polje As String) As Boolean
        postojiuIST = True
        Dim sql As String = "SELECT polje FROM istpolja where sifist='" + sifist + "' and tabela = '" + tabela + "' and  polje='" + polje + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            postojiuIST = False
        End If
    End Function

    Private Sub bb11_Click(sender As Object, e As EventArgs) Handles bb11.Click
        If txtName.Text.Trim = "" Then
            ISTMessageBox.Show("Name is mandatory")
            Me.txtName.Focus()
            Exit Sub
        End If

        poIST = postojiuIST(pp(0).Trim, txtName.Text.Trim)

        If poIST = True Then
            ISTMessageBox.Show("Column with this name already exists in IST!")
            Me.txtName.Focus()
            Me.txtName.SelectAll()
        Else
            lblE.Visible = True
            txtE.Visible = True
            btnInsert.Visible = True
        End If
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        lblE.Visible = False
        txtE.Visible = False
        btnInsert.Visible = False
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
        If cbFS.Checked = True Then tbFS.Text = tbFS.Tag
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