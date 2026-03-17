'Option Strict Off

Imports System.Web

Public Class mFormInsertTB
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
    Friend WithEvents lblName As Label
    Friend WithEvents lVM As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbB As CheckBox
    Friend WithEvents cbA As CheckBox
    Friend WithEvents txtTip As TextBox
    Friend WithEvents txtp2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtp1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDuzChar As TextBox
    Friend WithEvents cbNOTNULL As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cdt21 As CheckBox
    Friend WithEvents cdt18 As CheckBox
    Friend WithEvents cdt19 As CheckBox
    Friend WithEvents cdt20 As CheckBox
    Friend WithEvents ccs15 As CheckBox
    Friend WithEvents ccs16 As CheckBox
    Friend WithEvents ccs17 As CheckBox
    Friend WithEvents ccs12 As CheckBox
    Friend WithEvents ccs13 As CheckBox
    Friend WithEvents ccs14 As CheckBox
    Friend WithEvents can10 As CheckBox
    Friend WithEvents can11 As CheckBox
    Friend WithEvents cen9 As CheckBox
    Friend WithEvents cen8 As CheckBox
    Friend WithEvents cen7 As CheckBox
    Friend WithEvents cen6 As CheckBox
    Friend WithEvents cen5 As CheckBox
    Friend WithEvents cen4 As CheckBox
    Friend WithEvents cen3 As CheckBox
    Friend WithEvents cen2 As CheckBox
    Friend WithEvents cen1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents gbGde As GroupBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents gbType As GroupBox
    Friend WithEvents bb11 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDuzOstalo As TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lVM = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbB = New System.Windows.Forms.CheckBox()
        Me.cbA = New System.Windows.Forms.CheckBox()
        Me.txtTip = New System.Windows.Forms.TextBox()
        Me.txtp2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtp1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDuzChar = New System.Windows.Forms.TextBox()
        Me.cbNOTNULL = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cdt21 = New System.Windows.Forms.CheckBox()
        Me.cdt18 = New System.Windows.Forms.CheckBox()
        Me.cdt19 = New System.Windows.Forms.CheckBox()
        Me.cdt20 = New System.Windows.Forms.CheckBox()
        Me.ccs15 = New System.Windows.Forms.CheckBox()
        Me.ccs16 = New System.Windows.Forms.CheckBox()
        Me.ccs17 = New System.Windows.Forms.CheckBox()
        Me.ccs12 = New System.Windows.Forms.CheckBox()
        Me.ccs13 = New System.Windows.Forms.CheckBox()
        Me.ccs14 = New System.Windows.Forms.CheckBox()
        Me.can10 = New System.Windows.Forms.CheckBox()
        Me.can11 = New System.Windows.Forms.CheckBox()
        Me.cen9 = New System.Windows.Forms.CheckBox()
        Me.cen8 = New System.Windows.Forms.CheckBox()
        Me.cen7 = New System.Windows.Forms.CheckBox()
        Me.cen6 = New System.Windows.Forms.CheckBox()
        Me.cen5 = New System.Windows.Forms.CheckBox()
        Me.cen4 = New System.Windows.Forms.CheckBox()
        Me.cen3 = New System.Windows.Forms.CheckBox()
        Me.cen2 = New System.Windows.Forms.CheckBox()
        Me.cen1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gbGde = New System.Windows.Forms.GroupBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDuzOstalo = New System.Windows.Forms.TextBox()
        Me.bb11 = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGde.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.gbType.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(420, 4)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(190, 23)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.TabStop = False
        Me.BtnFormat.Text = "Insert"
        Me.BtnFormat.UseVisualStyleBackColor = False
        Me.BtnFormat.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Insert TextBox"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 430)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(613, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(139, 31)
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
        Me.txtName.Location = New System.Drawing.Point(136, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(276, 20)
        Me.txtName.TabIndex = 248
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(339, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 265
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
        'txtTip
        '
        Me.txtTip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTip.Location = New System.Drawing.Point(368, 322)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.ReadOnly = True
        Me.txtTip.Size = New System.Drawing.Size(84, 21)
        Me.txtTip.TabIndex = 322
        '
        'txtp2
        '
        Me.txtp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtp2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtp2.Location = New System.Drawing.Point(338, 228)
        Me.txtp2.Name = "txtp2"
        Me.txtp2.Size = New System.Drawing.Size(39, 21)
        Me.txtp2.TabIndex = 321
        Me.txtp2.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(290, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 320
        Me.Label9.Text = "decimal precision"
        Me.Label9.Visible = False
        '
        'txtp1
        '
        Me.txtp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtp1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtp1.Location = New System.Drawing.Point(294, 228)
        Me.txtp1.Name = "txtp1"
        Me.txtp1.Size = New System.Drawing.Size(42, 21)
        Me.txtp1.TabIndex = 319
        Me.txtp1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(368, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 318
        Me.Label8.Text = "MaxLength"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.Label7.Location = New System.Drawing.Point(10, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(196, 12)
        Me.Label7.TabIndex = 317
        Me.Label7.Text = "* in IST format will be dd.MM.yyyy"
        '
        'txtDuzChar
        '
        Me.txtDuzChar.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuzChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuzChar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuzChar.Location = New System.Drawing.Point(371, 97)
        Me.txtDuzChar.Name = "txtDuzChar"
        Me.txtDuzChar.Size = New System.Drawing.Size(84, 21)
        Me.txtDuzChar.TabIndex = 316
        Me.txtDuzChar.Visible = False
        '
        'cbNOTNULL
        '
        Me.cbNOTNULL.AutoSize = True
        Me.cbNOTNULL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNOTNULL.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbNOTNULL.Location = New System.Drawing.Point(13, 25)
        Me.cbNOTNULL.Name = "cbNOTNULL"
        Me.cbNOTNULL.Size = New System.Drawing.Size(79, 17)
        Me.cbNOTNULL.TabIndex = 315
        Me.cbNOTNULL.Tag = ""
        Me.cbNOTNULL.Text = "NOT NULL"
        Me.cbNOTNULL.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.Label2.Location = New System.Drawing.Point(10, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(186, 12)
        Me.Label2.TabIndex = 313
        Me.Label2.Text = "* in DB type will be nvarchar(50)"
        '
        'cdt21
        '
        Me.cdt21.AutoSize = True
        Me.cdt21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt21.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt21.Location = New System.Drawing.Point(13, 212)
        Me.cdt21.Name = "cdt21"
        Me.cdt21.Size = New System.Drawing.Size(48, 17)
        Me.cdt21.TabIndex = 314
        Me.cdt21.Tag = "time"
        Me.cdt21.Text = "time"
        Me.cdt21.UseVisualStyleBackColor = True
        '
        'cdt18
        '
        Me.cdt18.AutoSize = True
        Me.cdt18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt18.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt18.Location = New System.Drawing.Point(13, 192)
        Me.cdt18.Name = "cdt18"
        Me.cdt18.Size = New System.Drawing.Size(48, 17)
        Me.cdt18.TabIndex = 312
        Me.cdt18.Tag = "date"
        Me.cdt18.Text = "date"
        Me.cdt18.UseVisualStyleBackColor = True
        '
        'cdt19
        '
        Me.cdt19.AutoSize = True
        Me.cdt19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt19.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt19.Location = New System.Drawing.Point(13, 172)
        Me.cdt19.Name = "cdt19"
        Me.cdt19.Size = New System.Drawing.Size(73, 17)
        Me.cdt19.TabIndex = 311
        Me.cdt19.Tag = "datetime"
        Me.cdt19.Text = "datetime"
        Me.cdt19.UseVisualStyleBackColor = True
        '
        'cdt20
        '
        Me.cdt20.AutoSize = True
        Me.cdt20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cdt20.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cdt20.Location = New System.Drawing.Point(13, 152)
        Me.cdt20.Name = "cdt20"
        Me.cdt20.Size = New System.Drawing.Size(81, 17)
        Me.cdt20.TabIndex = 310
        Me.cdt20.Tag = "ISTDate"
        Me.cdt20.Text = "ISTDate *"
        Me.cdt20.UseVisualStyleBackColor = True
        '
        'ccs15
        '
        Me.ccs15.AutoSize = True
        Me.ccs15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs15.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs15.Location = New System.Drawing.Point(297, 111)
        Me.ccs15.Name = "ccs15"
        Me.ccs15.Size = New System.Drawing.Size(45, 17)
        Me.ccs15.TabIndex = 309
        Me.ccs15.Tag = "text"
        Me.ccs15.Text = "text"
        Me.ccs15.UseVisualStyleBackColor = True
        Me.ccs15.Visible = False
        '
        'ccs16
        '
        Me.ccs16.AutoSize = True
        Me.ccs16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs16.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs16.Location = New System.Drawing.Point(297, 94)
        Me.ccs16.Name = "ccs16"
        Me.ccs16.Size = New System.Drawing.Size(67, 17)
        Me.ccs16.TabIndex = 308
        Me.ccs16.Tag = "varchar"
        Me.ccs16.Text = "varchar"
        Me.ccs16.UseVisualStyleBackColor = True
        '
        'ccs17
        '
        Me.ccs17.AutoSize = True
        Me.ccs17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs17.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs17.Location = New System.Drawing.Point(297, 77)
        Me.ccs17.Name = "ccs17"
        Me.ccs17.Size = New System.Drawing.Size(48, 17)
        Me.ccs17.TabIndex = 307
        Me.ccs17.Tag = "char"
        Me.ccs17.Text = "char"
        Me.ccs17.UseVisualStyleBackColor = True
        '
        'ccs12
        '
        Me.ccs12.AutoSize = True
        Me.ccs12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs12.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs12.Location = New System.Drawing.Point(218, 111)
        Me.ccs12.Name = "ccs12"
        Me.ccs12.Size = New System.Drawing.Size(52, 17)
        Me.ccs12.TabIndex = 306
        Me.ccs12.Tag = "ntext"
        Me.ccs12.Text = "ntext"
        Me.ccs12.UseVisualStyleBackColor = True
        Me.ccs12.Visible = False
        '
        'ccs13
        '
        Me.ccs13.AutoSize = True
        Me.ccs13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs13.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs13.Location = New System.Drawing.Point(218, 94)
        Me.ccs13.Name = "ccs13"
        Me.ccs13.Size = New System.Drawing.Size(74, 17)
        Me.ccs13.TabIndex = 305
        Me.ccs13.Tag = "nvarchar"
        Me.ccs13.Text = "nvarchar"
        Me.ccs13.UseVisualStyleBackColor = True
        '
        'ccs14
        '
        Me.ccs14.AutoSize = True
        Me.ccs14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccs14.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ccs14.Location = New System.Drawing.Point(218, 77)
        Me.ccs14.Name = "ccs14"
        Me.ccs14.Size = New System.Drawing.Size(55, 17)
        Me.ccs14.TabIndex = 304
        Me.ccs14.Tag = "nchar"
        Me.ccs14.Text = "nchar"
        Me.ccs14.UseVisualStyleBackColor = True
        '
        'can10
        '
        Me.can10.AutoSize = True
        Me.can10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.can10.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.can10.Location = New System.Drawing.Point(13, 95)
        Me.can10.Name = "can10"
        Me.can10.Size = New System.Drawing.Size(45, 17)
        Me.can10.TabIndex = 303
        Me.can10.Tag = "real"
        Me.can10.Text = "real"
        Me.can10.UseVisualStyleBackColor = True
        '
        'can11
        '
        Me.can11.AutoSize = True
        Me.can11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.can11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.can11.Location = New System.Drawing.Point(13, 73)
        Me.can11.Name = "can11"
        Me.can11.Size = New System.Drawing.Size(48, 17)
        Me.can11.TabIndex = 302
        Me.can11.Tag = "float"
        Me.can11.Text = "float"
        Me.can11.UseVisualStyleBackColor = True
        '
        'cen9
        '
        Me.cen9.AutoSize = True
        Me.cen9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen9.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen9.Location = New System.Drawing.Point(221, 323)
        Me.cen9.Name = "cen9"
        Me.cen9.Size = New System.Drawing.Size(58, 17)
        Me.cen9.TabIndex = 301
        Me.cen9.Tag = "tinyint"
        Me.cen9.Text = "tinyint"
        Me.cen9.UseVisualStyleBackColor = True
        '
        'cen8
        '
        Me.cen8.AutoSize = True
        Me.cen8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen8.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen8.Location = New System.Drawing.Point(221, 306)
        Me.cen8.Name = "cen8"
        Me.cen8.Size = New System.Drawing.Size(92, 17)
        Me.cen8.TabIndex = 300
        Me.cen8.Tag = "smallmoney"
        Me.cen8.Text = "smallmoney"
        Me.cen8.UseVisualStyleBackColor = True
        '
        'cen7
        '
        Me.cen7.AutoSize = True
        Me.cen7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen7.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen7.Location = New System.Drawing.Point(221, 289)
        Me.cen7.Name = "cen7"
        Me.cen7.Size = New System.Drawing.Size(67, 17)
        Me.cen7.TabIndex = 299
        Me.cen7.Tag = "smallint"
        Me.cen7.Text = "smallint"
        Me.cen7.UseVisualStyleBackColor = True
        '
        'cen6
        '
        Me.cen6.AutoSize = True
        Me.cen6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen6.Location = New System.Drawing.Point(221, 272)
        Me.cen6.Name = "cen6"
        Me.cen6.Size = New System.Drawing.Size(69, 17)
        Me.cen6.TabIndex = 298
        Me.cen6.Tag = "numeric"
        Me.cen6.Text = "numeric"
        Me.cen6.UseVisualStyleBackColor = True
        '
        'cen5
        '
        Me.cen5.AutoSize = True
        Me.cen5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen5.Location = New System.Drawing.Point(221, 255)
        Me.cen5.Name = "cen5"
        Me.cen5.Size = New System.Drawing.Size(62, 17)
        Me.cen5.TabIndex = 297
        Me.cen5.Tag = "money"
        Me.cen5.Text = "money"
        Me.cen5.UseVisualStyleBackColor = True
        '
        'cen4
        '
        Me.cen4.AutoSize = True
        Me.cen4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen4.Location = New System.Drawing.Point(221, 238)
        Me.cen4.Name = "cen4"
        Me.cen4.Size = New System.Drawing.Size(37, 17)
        Me.cen4.TabIndex = 296
        Me.cen4.Tag = "int"
        Me.cen4.Text = "int"
        Me.cen4.UseVisualStyleBackColor = True
        '
        'cen3
        '
        Me.cen3.AutoSize = True
        Me.cen3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen3.Location = New System.Drawing.Point(221, 221)
        Me.cen3.Name = "cen3"
        Me.cen3.Size = New System.Drawing.Size(67, 17)
        Me.cen3.TabIndex = 295
        Me.cen3.Tag = "decimal"
        Me.cen3.Text = "decimal"
        Me.cen3.UseVisualStyleBackColor = True
        '
        'cen2
        '
        Me.cen2.AutoSize = True
        Me.cen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen2.Location = New System.Drawing.Point(221, 204)
        Me.cen2.Name = "cen2"
        Me.cen2.Size = New System.Drawing.Size(37, 17)
        Me.cen2.TabIndex = 294
        Me.cen2.Tag = "bit"
        Me.cen2.Text = "bit"
        Me.cen2.UseVisualStyleBackColor = True
        '
        'cen1
        '
        Me.cen1.AutoSize = True
        Me.cen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cen1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cen1.Location = New System.Drawing.Point(221, 187)
        Me.cen1.Name = "cen1"
        Me.cen1.Size = New System.Drawing.Size(54, 17)
        Me.cen1.TabIndex = 293
        Me.cen1.Tag = "bigint"
        Me.cen1.Text = "bigint"
        Me.cen1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(215, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 292
        Me.Label4.Text = "Character strings."
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(10, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 291
        Me.Label3.Text = "Date and time"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(10, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 20)
        Me.Label5.TabIndex = 290
        Me.Label5.Text = "Approximate numerics"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(215, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(155, 20)
        Me.Label10.TabIndex = 289
        Me.Label10.Text = "Exact numerics"
        '
        'gbGde
        '
        Me.gbGde.Controls.Add(Me.cbA)
        Me.gbGde.Controls.Add(Me.cbB)
        Me.gbGde.Location = New System.Drawing.Point(8, 31)
        Me.gbGde.Name = "gbGde"
        Me.gbGde.Size = New System.Drawing.Size(116, 74)
        Me.gbGde.TabIndex = 323
        Me.gbGde.TabStop = False
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cb3)
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Location = New System.Drawing.Point(8, 123)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(116, 85)
        Me.gbOptions.TabIndex = 325
        Me.gbOptions.TabStop = False
        Me.gbOptions.Visible = False
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
        Me.cb3.Visible = False
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
        Me.cb2.Visible = False
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
        'gbType
        '
        Me.gbType.Controls.Add(Me.Label11)
        Me.gbType.Controls.Add(Me.txtDuzOstalo)
        Me.gbType.Controls.Add(Me.Label5)
        Me.gbType.Controls.Add(Me.Label6)
        Me.gbType.Controls.Add(Me.Label10)
        Me.gbType.Controls.Add(Me.Label3)
        Me.gbType.Controls.Add(Me.cbNOTNULL)
        Me.gbType.Controls.Add(Me.Label4)
        Me.gbType.Controls.Add(Me.txtTip)
        Me.gbType.Controls.Add(Me.cen1)
        Me.gbType.Controls.Add(Me.txtp2)
        Me.gbType.Controls.Add(Me.cen2)
        Me.gbType.Controls.Add(Me.Label9)
        Me.gbType.Controls.Add(Me.cen3)
        Me.gbType.Controls.Add(Me.txtp1)
        Me.gbType.Controls.Add(Me.cen4)
        Me.gbType.Controls.Add(Me.Label8)
        Me.gbType.Controls.Add(Me.cen5)
        Me.gbType.Controls.Add(Me.Label7)
        Me.gbType.Controls.Add(Me.cen6)
        Me.gbType.Controls.Add(Me.txtDuzChar)
        Me.gbType.Controls.Add(Me.cen7)
        Me.gbType.Controls.Add(Me.cen8)
        Me.gbType.Controls.Add(Me.Label2)
        Me.gbType.Controls.Add(Me.cen9)
        Me.gbType.Controls.Add(Me.cdt21)
        Me.gbType.Controls.Add(Me.can11)
        Me.gbType.Controls.Add(Me.cdt18)
        Me.gbType.Controls.Add(Me.can10)
        Me.gbType.Controls.Add(Me.cdt19)
        Me.gbType.Controls.Add(Me.ccs14)
        Me.gbType.Controls.Add(Me.cdt20)
        Me.gbType.Controls.Add(Me.ccs13)
        Me.gbType.Controls.Add(Me.ccs15)
        Me.gbType.Controls.Add(Me.ccs12)
        Me.gbType.Controls.Add(Me.ccs16)
        Me.gbType.Controls.Add(Me.ccs17)
        Me.gbType.Location = New System.Drawing.Point(136, 74)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(472, 346)
        Me.gbType.TabIndex = 326
        Me.gbType.TabStop = False
        Me.gbType.Text = "Type"
        Me.gbType.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(368, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 324
        Me.Label11.Text = "MaxLength"
        Me.Label11.Visible = False
        '
        'txtDuzOstalo
        '
        Me.txtDuzOstalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuzOstalo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuzOstalo.Location = New System.Drawing.Point(368, 277)
        Me.txtDuzOstalo.Name = "txtDuzOstalo"
        Me.txtDuzOstalo.Size = New System.Drawing.Size(84, 21)
        Me.txtDuzOstalo.TabIndex = 323
        Me.txtDuzOstalo.Visible = False
        '
        'bb11
        '
        Me.bb11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bb11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bb11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.bb11.Location = New System.Drawing.Point(418, 46)
        Me.bb11.Name = "bb11"
        Me.bb11.Size = New System.Drawing.Size(190, 23)
        Me.bb11.TabIndex = 327
        Me.bb11.TabStop = False
        Me.bb11.Text = "Check name"
        Me.bb11.UseVisualStyleBackColor = False
        '
        'mFormInsertTB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(613, 460)
        Me.Controls.Add(Me.bb11)
        Me.Controls.Add(Me.gbType)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.gbGde)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lVM)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormInsertTB"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert "
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGde.ResumeLayout(False)
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.gbType.ResumeLayout(False)
        Me.gbType.PerformLayout()
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
    Dim ISTDB As Boolean
    Dim IST As Boolean
    Dim what As String

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
        Me.what = what

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

        Me.txtDuzChar.Text = "10"
        cbB.Checked = True
        ccs14.Checked = True
        Me.txtDuzChar.Visible = True
        Me.BtnFormat.Text = Me.what

        Me.Text = Me.what

        If Me.what.Trim.ToUpper = "CONVERT" Then
            postojiCF = True
            If postojiuDB(pp(0).Trim, pp(2).Trim) = False Then postojiCF = False
            If postojiCF = False Then
                gbType.Visible = False
                txtName.Visible = False
                lblName.Visible = False
                bb11.Visible = False
                BtnFormat.Visible = True
            Else
                gbType.Visible = True
            End If

            If Not Me.AccessibleDescription Is Nothing AndAlso Me.AccessibleDescription <> "lbl" AndAlso Me.AccessibleDescription <> "fp" Then
                Me.txtName.Text = pp(2).Trim
                Me.txtName.Enabled = False
                trebadb = False
            Else
                Me.txtName.Text = pp(2).Trim
                Me.txtName.Enabled = True
                trebadb = True
            End If

            gbOptions.Visible = True
            gbGde.Visible = False
            gbOptions.Top = gbGde.Top
            Me.Label1.Text = Me.what + " to TextBox"
            Me.BtnFormat.Visible = True
        Else
            Me.Label1.Text = Me.what + " TextBox"
            Me.BtnFormat.Visible = False
        End If
    End Sub

    Dim columnAtributes As String = ""
    Dim vs As String = ""

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        If gbOptions.Visible = True Then
            If (ccs12.Checked = True OrElse ccs13.Checked = True OrElse ccs14.Checked = True OrElse ccs15.Checked = True OrElse ccs16.Checked = True OrElse ccs17.Checked = True) AndAlso
            (Me.txtDuzChar.Text = "" OrElse IsNumeric(Me.txtDuzChar.Text) = False) Then
                ISTMessageBox.Show("Lenght must be entered!")
                Me.txtDuzChar.Focus()
                Exit Sub
            End If
        End If

        Call fformat()
    End Sub
    Sub fformat()
        If Me.what.Trim.ToUpper = "INSERT" Then Call aactionInsert(trebadb)
        If Me.what.Trim.ToUpper = "CONVERT" Then Call aactionConvert()
    End Sub

    Sub aactionInsert(ByVal trebadb As Boolean)
        Dim gde As String = "below"
        If cbA.Checked = True Then gde = "above"
        Call bdodajField(pp, gde, trebadb)
    End Sub
    Sub aactionConvert()
        Call bToTextBox(pp, 0)
    End Sub

    Private Sub cbA_CheckedChanged(sender As Object, e As EventArgs) Handles cbA.CheckedChanged
        If cbA.Checked = True Then cbB.Checked = False
    End Sub

    Private Sub cbB_CheckedChanged(sender As Object, e As EventArgs) Handles cbB.CheckedChanged
        If cbB.Checked = True Then cbA.Checked = False
    End Sub

    Function fformat(ByVal tabela As String, ByVal ppolje As String) As String
        sqlDBDropTip = ""
        DropTip = ""
        Dim duz As String = "" : Dim prec As String = "" : Dim sNN As String = ""
        If txtTip.Text = "" Then txtTip.Text = "nvarchar" : Me.txtDuzChar.Text = "50"
        If Me.txtTip.Tag = "S" Then
            If Me.txtDuzChar.Text.Trim = "" OrElse IsNumeric(Me.txtDuzChar.Text.Trim) = False Then Me.txtDuzChar.Text = "10"
            duz = "(" + Me.txtDuzChar.Text.Trim + ")"
        End If
        If Me.txtTip.Tag = "ISTDate" Then
            Me.txtDuzChar.Text = "10"
            duz = "(" + Me.txtDuzChar.Text.Trim + ")"
            txtTip.Text = "nvarchar"
        End If
        If Me.txtTip.Tag = "D" Then
            If Me.txtp1.Text.Trim = "" OrElse IsNumeric(Me.txtp1.Text.Trim) = False Then Me.txtp1.Text = "18"
            If Me.txtp2.Text.Trim = "" OrElse IsNumeric(Me.txtp2.Text.Trim) = False Then Me.txtp2.Text = "2"
            prec = "(" + Me.txtp1.Text.Trim + "," + Me.txtp2.Text.Trim + ")"
        End If

        If cbNOTNULL.Checked = True Then sNN = "NOT NULL"

        fformat = "ALTER TABLE " + tabela + " ADD  " + ppolje + " " + txtTip.Text + " " + prec + " " + duz + " " + sNN + ";" + nvrd
        sqlDBDropTip = tabela + ";" + ppolje
        DropTip = "ADD"
    End Function

    Sub bdodajField(ByVal pp() As String, ByVal gde As String, ByVal trebadb As Boolean)

        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
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
            If gde <> "left" Then
                If gde = "above" Then
                    rrbr = minrbrzatab
                Else
                    rrbr = maxrbrzatab
                End If
            End If
        End If

        If gde <> "left" Then
            If gde = "above" Then
                pomrbr = rrbr + 10
                rrbr = rrbr
            Else
                pomrbr = rrbr
                rrbr = rrbr + 10
            End If
            sqlIST = " update istpolja Set rbr=rbr+10 where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                    "' and rbr>=" + rrbr.Trim + ";" + nvrd
            Dim popis As String = "$LRIGHTA$Label for " + ppolje
            Dim pizraz As String = ""
            Dim pvs As String = ""
            Dim ptip As String = ""
            Dim pduzina As String = ""

            ptip = Me.txtTip.Text
            If Me.txtDuzChar.Text <> "" Then pduzina = Me.txtDuzChar.Text Else pduzina = Me.txtDuzOstalo.Text

            If cdt20.Checked = True Then
                ptip = "ISTDate"
                pduzina = "10"
            End If

            If cdt19.Checked = True Then
                ptip = "datetime"
                pduzina = ""
            End If

            If cdt18.Checked = True Then
                ptip = "date"
                pduzina = ""
            End If

            If cdt21.Checked = True Then
                ptip = "time"
                pduzina = ""
            End If

            sqlIST = sqlIST + "insert into istpolja (sifist,tabela,polje,vod,vdo,rbr,opis,izraz,vs,tip,duzina)" + nvrd +
                      " select sifist,tabela,N'" + ppolje + "' as polje,vod,vdo,'" + rrbr.Trim + "' as rbr,N'" + popis + "',N'" + pizraz + "','" + pvs + "','" + ptip + "','" + pduzina + "'" +
                      " from istpolja " +
                      " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr ='" + pomrbr + "'"

            Dim sqlDB As String = fformat(pp(0).Trim, ppolje)
            p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST,, sqlDBDropTip, DropTip)

            If p2 = "ok" Then
                If trebadb = True Then
                    p2 = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                    If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to DB!")
                End If
            End If

            If p2 = "nok" Then
                ISTMessageBox.Show("Error!")
            Else
                Me.Cursor = Cursors.Default
                Me.Close()
            End If

            'p2 = izvrsiSQL(" begin transaction; " + nvrd + sqlIST + nvrd + " commit; ", Me.ISTConnectionString)

        End If

    End Sub
    Dim sqlDBDropTip As String = ""
    Dim DropTip As String = ""
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

    Function getrbr(ByVal sqlrbr As String) As String
        getrbr = "0"
        Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
        If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 AndAlso dt1.Rows(0).Item("rbr").ToString <> "0" Then getrbr = dt1.Rows(0).Item("rbr").ToString
    End Function

    Private Sub chb_CheckedChanged(sender As Object, e As EventArgs) Handles cen1.CheckedChanged, cen2.CheckedChanged, cen3.CheckedChanged, cen4.CheckedChanged, cen5.CheckedChanged, cen6.CheckedChanged,
                        cen7.CheckedChanged, cen8.CheckedChanged, cen9.CheckedChanged, can10.CheckedChanged, can11.CheckedChanged, ccs12.CheckedChanged, ccs13.CheckedChanged, ccs14.CheckedChanged, ccs15.CheckedChanged, ccs16.CheckedChanged,
                        ccs17.CheckedChanged, cdt18.CheckedChanged, cdt19.CheckedChanged, cdt20.CheckedChanged, cdt21.CheckedChanged
        Dim chb As CheckBox = DirectCast(sender, CheckBox)
        If chb.Checked = True Then
            Me.txtTip.Text = chb.Tag.trim
            'all false
            For Each k As Control In gbType.Controls
                If TypeOf k Is CheckBox AndAlso Not (DirectCast(k, CheckBox).Name = chb.Name) AndAlso Not DirectCast(k, CheckBox).Tag Is Nothing AndAlso DirectCast(k, CheckBox).Tag <> "" Then
                    DirectCast(k, CheckBox).Checked = False
                End If
            Next

            Me.txtTip.Tag = ""

            If chb.Name.Trim.Substring(0, 3) = "ccs" Then   'string
                Me.txtTip.Tag = "S"
                Me.Label8.Visible = True
                Me.txtDuzChar.Visible = True
                Me.txtDuzChar.Text = "10"

                Me.Label11.Visible = False
                Me.txtDuzOstalo.Visible = False
                Me.txtDuzOstalo.Text = ""
            Else
                Me.Label8.Visible = False
                Me.txtDuzChar.Visible = False
                Me.txtDuzChar.Text = ""

                Me.Label11.Visible = True
                Me.txtDuzOstalo.Visible = True
                Me.txtDuzOstalo.Text = "10"
            End If

            If chb.Tag = "ISTDate" Then   'decimal
                Me.txtTip.Tag = "ISTDate"
                Me.txtTip.Text = "nvarchar"
                Me.txtDuzChar.Text = "10"
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

    Sub bToTextBox(ByVal pp() As String, ByVal p As Integer)
        ' trt.AccessibleDefaultActionDescription = GlavnaTabela + ";" + p.vod.tostring("yyyy/MM/dd").trim + ";" + trt.Name.Substring(2) + ";" + pomforma + ";" + cStr(p.rbr).Trim
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + cStr(Forma).Trim + ";" + cStr(p.rbr).Trim

        'Me.AccessibleDescription  lbl fp

        Dim sqlI As String = ""
        Dim sqlDB As String = ""
        Dim p2 As String = "nok"

        Dim pom() As String = pp
        Dim sql As String = ""
        sqlI = "" : sqlDB = ""
        Dim pomdo As String = ""
        If p = 0 Then
            'obicno
            Dim ppolje As String = ""
            If Not Me.AccessibleDescription Is Nothing AndAlso Me.AccessibleDescription <> "lbl" AndAlso Me.AccessibleDescription <> "fp" Then
                'konvertujem cb,dtp,chb,ll,rbg,actb
                ppolje = pp(2).Trim

                If Me.AccessibleDescription = "actb" Then pomdo = ",do=''"

                sqlI = " update IStpolja set izraz=''" + pomdo + " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + ppolje + "'" +
                       " and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                'ne dodaje se u bazu, vec postoji, nek ga reimenuju ako bas hoce
                sqlDB = ""
            Else
                'konvertujem lbl and fp
                ppolje = Me.txtName.Text.Trim
                sqlI = " update istpolja set izraz='',polje=N'" + ppolje + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                    "' and polje=N'" + pp(2).Trim + "'" +
                    " and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                'mora polje da se doda u bazu ako ne postoji
                If postojiuDB(pp(0).Trim, ppolje) = False Then
                    sqlDB = fformat(pp(0).Trim, ppolje)
                End If
            End If
        End If

        'OSTALO NEDOZVOLJENO!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! ZBOG IMENA I TIPOVA


        p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlI,, sqlDBDropTip, DropTip)

        If p2 = "ok" Then
            If trebadb = True Then
                p2 = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to DB!")
            End If
        End If

        If p2 = "nok" Then
            ISTMessageBox.Show("Error!")
        Else
            Me.Cursor = Cursors.Default
            Me.Close()
        End If

    End Sub

    Function postojiuDB(ByVal tabela As String, ByVal polje As String) As Boolean
        postojiuDB = True
        Dim sql As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + tabela + "' and  COLUMN_NAME=N'" + polje + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            postojiuDB = False
        End If
    End Function

    Function postojiuIST(ByVal tabela As String, ByVal polje As String) As Boolean
        postojiuIST = True
        Dim sql As String = "SELECT polje FROM istpolja where sifist=N'" + sifist + "' and tabela = N'" + tabela + "' and  polje=N'" + polje + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            postojiuIST = False
        End If
    End Function

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        cb1.Checked = True
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then

            postojiCF = True
            cb1.Checked = False
            cb3.Checked = False
            Dim sql As String = "select polje,vod,f3 from vrepistpolja where sifist=N'" + sifist + "' and tabela=N'" +
                pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + "." + CStr(currentred).Trim + ".%' order by rbr"
            Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
            For i As Integer = 0 To dt.Rows.Count - 1
                If postojiuDB(pp(0).Trim, dt.Rows(i).Item("polje").ToString.Trim) = False Then
                    postojiCF = False
                    Exit For
                End If
            Next
            If postojiCF = False Then
                gbType.Visible = False
                txtName.Visible = False
                lblName.Visible = False
                bb11.Visible = False
                BtnFormat.Visible = True
            Else
                gbType.Visible = True
            End If
        End If
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        If cb3.Checked = True Then
            postojiCF = True
            cb1.Checked = False
            cb2.Checked = False
            Dim sql As String = "select polje,vod,f2 from vrepistpolja where sifist=N'" + sifist + "' and tabela=N'" +
                pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%." + CStr(currentkol).Trim + "' order by rbr"
            Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
            For i As Integer = 0 To dt.Rows.Count - 1
                If postojiuDB(pp(0).Trim, dt.Rows(i).Item("polje").ToString.Trim) = False Then
                    postojiCF = False
                    Exit For
                End If
            Next
            If postojiCF = False Then
                gbType.Visible = False
                txtName.Visible = False
                lblName.Visible = False
                bb11.Visible = False
                BtnFormat.Visible = True
            Else
                gbType.Visible = True
            End If

        End If
    End Sub

    Dim poIST As Boolean = False
    Dim poDB As Boolean = False
    Dim trebadb As Boolean = True

    Private Sub bb11_Click(sender As Object, e As EventArgs) Handles bb11.Click

        If txtName.Text.Trim = "" Then
            ISTMessageBox.Show("Name is mandatory")
            Me.txtName.Focus()
            Exit Sub
        End If

        poIST = postojiuIST(pp(0).Trim, txtName.Text.Trim)
        poDB = postojiuDB(pp(0).Trim, txtName.Text.Trim)

        If poIST = True AndAlso poDB = True Then
            ISTMessageBox.Show("Column with this name already exists in IST and DB!")
            Me.txtName.Focus()
            Me.txtName.SelectAll()
        ElseIf poIST = True Then
            ISTMessageBox.Show("Column with this name already exists in IST!")
            Me.txtName.Focus()
            Me.txtName.SelectAll()
        ElseIf poIST = False And poDB = True Then
            'odmah insert ili convert u IST bez icega za DB
            trebadb = False
            gbType.Visible = False
            BtnFormat.Visible = False
            Call fformat()
        ElseIf poIST = False And poDB = False Then
            trebadb = True
            gbType.Visible = True
            BtnFormat.Visible = True
        End If
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        Me.gbType.Visible = False
    End Sub

End Class