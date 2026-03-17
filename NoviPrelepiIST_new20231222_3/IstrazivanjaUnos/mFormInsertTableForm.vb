Imports System.Web

Public Class mFormInsertTableForm
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
    Friend WithEvents BtnInsert As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents nudR As NumericUpDown
    Friend WithEvents nudC As NumericUpDown
    Friend WithEvents nudHR As NumericUpDown
    Friend WithEvents nudHC As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTabDownLeft As CheckBox
    Friend WithEvents lblNumber1AC As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents txtCI As TextBox
    Friend WithEvents txtRI As TextBox
    Friend WithEvents cbCI As CheckBox
    Friend WithEvents cbRI As CheckBox
    Friend WithEvents bb11 As Button
    Friend WithEvents gbType As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDuzOstalo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbNOTNULL As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTip As TextBox
    Friend WithEvents cen1 As CheckBox
    Friend WithEvents txtp2 As TextBox
    Friend WithEvents cen2 As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cen3 As CheckBox
    Friend WithEvents txtp1 As TextBox
    Friend WithEvents cen4 As CheckBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cen5 As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cen6 As CheckBox
    Friend WithEvents txtDuzChar As TextBox
    Friend WithEvents cen7 As CheckBox
    Friend WithEvents cen8 As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cen9 As CheckBox
    Friend WithEvents cdt21 As CheckBox
    Friend WithEvents can11 As CheckBox
    Friend WithEvents cdt18 As CheckBox
    Friend WithEvents can10 As CheckBox
    Friend WithEvents cdt19 As CheckBox
    Friend WithEvents ccs14 As CheckBox
    Friend WithEvents cdt20 As CheckBox
    Friend WithEvents ccs13 As CheckBox
    Friend WithEvents ccs15 As CheckBox
    Friend WithEvents ccs12 As CheckBox
    Friend WithEvents ccs16 As CheckBox
    Friend WithEvents ccs17 As CheckBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cbSN As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents nudFC As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents nudFR As NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnInsert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.nudR = New System.Windows.Forms.NumericUpDown()
        Me.nudC = New System.Windows.Forms.NumericUpDown()
        Me.nudHR = New System.Windows.Forms.NumericUpDown()
        Me.nudHC = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTabDownLeft = New System.Windows.Forms.CheckBox()
        Me.lblNumber1AC = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.txtRI = New System.Windows.Forms.TextBox()
        Me.cbCI = New System.Windows.Forms.CheckBox()
        Me.cbRI = New System.Windows.Forms.CheckBox()
        Me.bb11 = New System.Windows.Forms.Button()
        Me.gbType = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDuzOstalo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbNOTNULL = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTip = New System.Windows.Forms.TextBox()
        Me.cen1 = New System.Windows.Forms.CheckBox()
        Me.txtp2 = New System.Windows.Forms.TextBox()
        Me.cen2 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cen3 = New System.Windows.Forms.CheckBox()
        Me.txtp1 = New System.Windows.Forms.TextBox()
        Me.cen4 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cen5 = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cen6 = New System.Windows.Forms.CheckBox()
        Me.txtDuzChar = New System.Windows.Forms.TextBox()
        Me.cen7 = New System.Windows.Forms.CheckBox()
        Me.cen8 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cen9 = New System.Windows.Forms.CheckBox()
        Me.cdt21 = New System.Windows.Forms.CheckBox()
        Me.can11 = New System.Windows.Forms.CheckBox()
        Me.cdt18 = New System.Windows.Forms.CheckBox()
        Me.can10 = New System.Windows.Forms.CheckBox()
        Me.cdt19 = New System.Windows.Forms.CheckBox()
        Me.ccs14 = New System.Windows.Forms.CheckBox()
        Me.cdt20 = New System.Windows.Forms.CheckBox()
        Me.ccs13 = New System.Windows.Forms.CheckBox()
        Me.ccs15 = New System.Windows.Forms.CheckBox()
        Me.ccs12 = New System.Windows.Forms.CheckBox()
        Me.ccs16 = New System.Windows.Forms.CheckBox()
        Me.ccs17 = New System.Windows.Forms.CheckBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cbSN = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.nudFC = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.nudFR = New System.Windows.Forms.NumericUpDown()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        CType(Me.nudR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbType.SuspendLayout()
        CType(Me.nudFC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInsert
        '
        Me.BtnInsert.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsert.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnInsert.Location = New System.Drawing.Point(540, 3)
        Me.BtnInsert.Name = "BtnInsert"
        Me.BtnInsert.Size = New System.Drawing.Size(190, 24)
        Me.BtnInsert.TabIndex = 1
        Me.BtnInsert.Text = "Insert"
        Me.BtnInsert.UseVisualStyleBackColor = False
        Me.BtnInsert.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Insert tableForm"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnInsert)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 479)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 30)
        Me.Panel1.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCancel.Location = New System.Drawing.Point(318, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 24)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(745, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Location = New System.Drawing.Point(3, 31)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(247, 65)
        Me.gbOptions.TabIndex = 40
        Me.gbOptions.TabStop = False
        '
        'cb2
        '
        Me.cb2.AccessibleDescription = " "
        Me.cb2.AutoSize = True
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb2.Location = New System.Drawing.Point(12, 38)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(57, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Below"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb1.Location = New System.Drawing.Point(12, 17)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(59, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Above"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'nudR
        '
        Me.nudR.Location = New System.Drawing.Point(190, 102)
        Me.nudR.Name = "nudR"
        Me.nudR.Size = New System.Drawing.Size(60, 21)
        Me.nudR.TabIndex = 44
        Me.nudR.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudC
        '
        Me.nudC.Location = New System.Drawing.Point(190, 132)
        Me.nudC.Name = "nudC"
        Me.nudC.Size = New System.Drawing.Size(60, 21)
        Me.nudC.TabIndex = 45
        Me.nudC.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'nudHR
        '
        Me.nudHR.Location = New System.Drawing.Point(190, 162)
        Me.nudHR.Name = "nudHR"
        Me.nudHR.Size = New System.Drawing.Size(60, 21)
        Me.nudHR.TabIndex = 46
        Me.nudHR.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudHC
        '
        Me.nudHC.Location = New System.Drawing.Point(190, 223)
        Me.nudHC.Name = "nudHC"
        Me.nudHC.Size = New System.Drawing.Size(60, 21)
        Me.nudHC.TabIndex = 47
        Me.nudHC.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(4, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Total number of rows"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(4, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Total number of columns"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(4, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Number of header rows"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(4, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Number of header columns"
        '
        'cbTabDownLeft
        '
        Me.cbTabDownLeft.AutoSize = True
        Me.cbTabDownLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTabDownLeft.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cbTabDownLeft.Location = New System.Drawing.Point(12, 406)
        Me.cbTabDownLeft.Name = "cbTabDownLeft"
        Me.cbTabDownLeft.Size = New System.Drawing.Size(176, 17)
        Me.cbTabDownLeft.TabIndex = 59
        Me.cbTabDownLeft.Text = "Tab - goes down then right"
        Me.cbTabDownLeft.UseVisualStyleBackColor = True
        '
        'lblNumber1AC
        '
        Me.lblNumber1AC.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNumber1AC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber1AC.Location = New System.Drawing.Point(9, 439)
        Me.lblNumber1AC.Name = "lblNumber1AC"
        Me.lblNumber1AC.Size = New System.Drawing.Size(230, 19)
        Me.lblNumber1AC.TabIndex = 60
        Me.lblNumber1AC.Text = "* Tab default goes right then down "
        Me.lblNumber1AC.Visible = False
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label107.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(12, 284)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(116, 13)
        Me.Label107.TabIndex = 289
        Me.Label107.Text = "Cell name iteration"
        Me.Label107.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCI
        '
        Me.txtCI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCI.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtCI.Location = New System.Drawing.Point(190, 327)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(60, 20)
        Me.txtCI.TabIndex = 288
        Me.txtCI.Tag = "VF"
        Me.txtCI.Visible = False
        '
        'txtRI
        '
        Me.txtRI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRI.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtRI.Location = New System.Drawing.Point(190, 305)
        Me.txtRI.Name = "txtRI"
        Me.txtRI.Size = New System.Drawing.Size(60, 20)
        Me.txtRI.TabIndex = 287
        Me.txtRI.Tag = "VF"
        Me.txtRI.Visible = False
        '
        'cbCI
        '
        Me.cbCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCI.Location = New System.Drawing.Point(12, 328)
        Me.cbCI.Name = "cbCI"
        Me.cbCI.Size = New System.Drawing.Size(150, 16)
        Me.cbCI.TabIndex = 286
        Me.cbCI.Text = "Columns start from"
        Me.cbCI.UseVisualStyleBackColor = True
        '
        'cbRI
        '
        Me.cbRI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRI.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRI.Location = New System.Drawing.Point(12, 305)
        Me.cbRI.Name = "cbRI"
        Me.cbRI.Size = New System.Drawing.Size(125, 17)
        Me.cbRI.TabIndex = 285
        Me.cbRI.Text = "Rows start from"
        Me.cbRI.UseVisualStyleBackColor = True
        '
        'bb11
        '
        Me.bb11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bb11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bb11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.bb11.Location = New System.Drawing.Point(540, 46)
        Me.bb11.Name = "bb11"
        Me.bb11.Size = New System.Drawing.Size(190, 23)
        Me.bb11.TabIndex = 331
        Me.bb11.TabStop = False
        Me.bb11.Text = "Check name"
        Me.bb11.UseVisualStyleBackColor = False
        '
        'gbType
        '
        Me.gbType.Controls.Add(Me.Label11)
        Me.gbType.Controls.Add(Me.txtDuzOstalo)
        Me.gbType.Controls.Add(Me.Label6)
        Me.gbType.Controls.Add(Me.Label7)
        Me.gbType.Controls.Add(Me.Label10)
        Me.gbType.Controls.Add(Me.Label8)
        Me.gbType.Controls.Add(Me.cbNOTNULL)
        Me.gbType.Controls.Add(Me.Label9)
        Me.gbType.Controls.Add(Me.txtTip)
        Me.gbType.Controls.Add(Me.cen1)
        Me.gbType.Controls.Add(Me.txtp2)
        Me.gbType.Controls.Add(Me.cen2)
        Me.gbType.Controls.Add(Me.Label12)
        Me.gbType.Controls.Add(Me.cen3)
        Me.gbType.Controls.Add(Me.txtp1)
        Me.gbType.Controls.Add(Me.cen4)
        Me.gbType.Controls.Add(Me.Label13)
        Me.gbType.Controls.Add(Me.cen5)
        Me.gbType.Controls.Add(Me.Label14)
        Me.gbType.Controls.Add(Me.cen6)
        Me.gbType.Controls.Add(Me.txtDuzChar)
        Me.gbType.Controls.Add(Me.cen7)
        Me.gbType.Controls.Add(Me.cen8)
        Me.gbType.Controls.Add(Me.Label15)
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
        Me.gbType.Location = New System.Drawing.Point(258, 74)
        Me.gbType.Name = "gbType"
        Me.gbType.Size = New System.Drawing.Size(472, 346)
        Me.gbType.TabIndex = 330
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
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(10, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 290
        Me.Label6.Text = "Approximate numerics"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(339, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 265
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
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(10, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 20)
        Me.Label8.TabIndex = 291
        Me.Label8.Text = "Date and time"
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
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(215, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 20)
        Me.Label9.TabIndex = 292
        Me.Label9.Text = "Character strings."
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
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(290, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 320
        Me.Label12.Text = "decimal precision"
        Me.Label12.Visible = False
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(368, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 318
        Me.Label13.Text = "MaxLength"
        Me.Label13.Visible = False
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.Label14.Location = New System.Drawing.Point(10, 260)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(196, 12)
        Me.Label14.TabIndex = 317
        Me.Label14.Text = "* in IST format will be dd.MM.yyyy"
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
        'txtDuzChar
        '
        Me.txtDuzChar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuzChar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuzChar.Location = New System.Drawing.Point(371, 97)
        Me.txtDuzChar.Name = "txtDuzChar"
        Me.txtDuzChar.Size = New System.Drawing.Size(84, 21)
        Me.txtDuzChar.TabIndex = 316
        Me.txtDuzChar.Visible = False
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 7.25!)
        Me.Label15.Location = New System.Drawing.Point(10, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(186, 12)
        Me.Label15.TabIndex = 313
        Me.Label15.Text = "* in DB type will be nvarchar(50)"
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
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(261, 31)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(100, 13)
        Me.lblName.TabIndex = 328
        Me.lblName.Text = "Name of the cell"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtName.Location = New System.Drawing.Point(258, 49)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(276, 20)
        Me.txtName.TabIndex = 329
        '
        'cbSN
        '
        Me.cbSN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSN.Location = New System.Drawing.Point(12, 350)
        Me.cbSN.Name = "cbSN"
        Me.cbSN.Size = New System.Drawing.Size(240, 34)
        Me.cbSN.TabIndex = 332
        Me.cbSN.Text = "Name sufix without tableForm number"
        Me.cbSN.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(5, 254)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(177, 13)
        Me.Label16.TabIndex = 334
        Me.Label16.Text = "Number of footer columns"
        '
        'nudFC
        '
        Me.nudFC.Location = New System.Drawing.Point(191, 254)
        Me.nudFC.Name = "nudFC"
        Me.nudFC.Size = New System.Drawing.Size(60, 21)
        Me.nudFC.TabIndex = 333
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(5, 191)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(154, 13)
        Me.Label17.TabIndex = 336
        Me.Label17.Text = "Number of footer rows"
        '
        'nudFR
        '
        Me.nudFR.Location = New System.Drawing.Point(191, 191)
        Me.nudFR.Name = "nudFR"
        Me.nudFR.Size = New System.Drawing.Size(60, 21)
        Me.nudFR.TabIndex = 335
        '
        'mFormInsertTableForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(745, 509)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.nudFR)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.nudFC)
        Me.Controls.Add(Me.cbSN)
        Me.Controls.Add(Me.bb11)
        Me.Controls.Add(Me.gbType)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label107)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.txtRI)
        Me.Controls.Add(Me.cbCI)
        Me.Controls.Add(Me.cbRI)
        Me.Controls.Add(Me.lblNumber1AC)
        Me.Controls.Add(Me.cbTabDownLeft)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudHC)
        Me.Controls.Add(Me.nudHR)
        Me.Controls.Add(Me.nudC)
        Me.Controls.Add(Me.nudR)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormInsertTableForm"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert table"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        CType(Me.nudR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbType.ResumeLayout(False)
        Me.gbType.PerformLayout()
        CType(Me.nudFC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFR, System.ComponentModel.ISupportInitialize).EndInit()
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
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String,
                   ByVal ISTConnectionString As String, ByVal DBConnectionString As String)
        InitializeComponent()
        _parentForm = form
        Me.AccessibleName = ""
        Me.ControlBox = False
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
        Me.cb2.Checked = True

        pp = Me.Tag.split(";")
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        cb2.Checked = Not cb1.Checked
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        cb1.Checked = Not cb2.Checked
    End Sub

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

    Function fformatPolja(ByVal tabela As String, ByVal ppolje As String) As String
        sqlDBDropTip = ""
        Dim duz As String = "" : Dim prec As String = "" : Dim sNN As String = ""
        If txtTip.Text = "" Then txtTip.Text = "nvarchar" : Me.txtDuzChar.Text = "50"
        If Me.txtTip.Tag = "S" Then
            If Me.txtDuzChar.Text.Trim = "" OrElse IsNumeric(Me.txtDuzChar.Text.Trim) = False Then Me.txtDuzChar.Text = "50"
            duz = "(" + Me.txtDuzChar.Text.Trim + ")"
        End If
        If Me.txtTip.Tag = "D" Then
            If Me.txtp1.Text.Trim = "" OrElse IsNumeric(Me.txtp1.Text.Trim) = False Then Me.txtp1.Text = "18"
            If Me.txtp2.Text.Trim = "" OrElse IsNumeric(Me.txtp2.Text.Trim) = False Then Me.txtp2.Text = "2"
            prec = "(" + Me.txtp1.Text.Trim + "," + Me.txtp2.Text.Trim + ")"
        End If

        If cbNOTNULL.Checked = True Then sNN = "NOT NULL"

        fformatPolja = "ALTER TABLE " + tabela + " ADD  " + ppolje + " " + txtTip.Text + " " + prec + " " + duz + " " + sNN + ";" + nvrd
        sqlDBDropTip = tabela + ";" + ppolje + "#"
        DropTip = "ADD" + "#"

    End Function

    Private Sub BtnInsert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnInsert.Click
        If nudHR.Value > nudR.Value Then
            ISTMessageBox.Show("Number of header rows can not be greater than total number of rows!")
            nudR.Focus()
            Exit Sub
        End If
        If nudFR.Value > nudR.Value Then
            ISTMessageBox.Show("Number of footer rows can not be greater than total number of rows!")
            nudR.Focus()
            Exit Sub
        End If
        If nudHC.Value > nudC.Value Then
            ISTMessageBox.Show("Number of header columns can not be greater than total number of columns!")
            nudC.Focus()
            Exit Sub
        End If
        If nudFC.Value > nudC.Value Then
            ISTMessageBox.Show("Number of footer columns can not be greater than total number of columns!")
            nudC.Focus()
            Exit Sub
        End If

        Try

            Me.Cursor = Cursors.WaitCursor
            Dim ptip As String = ""
            Dim pduzina As String = ""
            ptip = Me.txtTip.Text
            If Me.txtDuzChar.Text <> "" Then pduzina = Me.txtDuzChar.Text Else pduzina = Me.txtDuzOstalo.Text

            Dim gde As String = "below"
            If cb1.Checked = True Then gde = "above"

            Dim str As String = ""
            Dim sqlI As String = ""
            Dim minrbrPosle As String = pp(4).Trim
            Dim maxrbrPre As String = pp(4).Trim
            Dim f1 As String = "1"
            'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
            'gde sam
            Dim trk() As String = pp(3).Split(".")
            If trk.Length = 3 Then
                'ako je tabela
                Dim t As Integer = CInt(trk(0).Trim)
                Dim r As Integer = CInt(trk(1).Trim)
                Dim k As Integer = CInt(trk(2).Trim)
                f1 = trk(0).Trim
                If gde = "below" Then f1 = CStr(CInt(f1) + 1).Trim

                Dim minrbrzatab As String = "select min(rbr) as rbr from vrepISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + trk(0).Trim + ".%'"
                minrbrzatab = getrbr(minrbrzatab)
                Dim maxrbrzatab As String = "select max(rbr) as rbr from vrepISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and ltrim(rtrim(forma)) like '" + trk(0).Trim + ".%'"
                maxrbrzatab = getrbr(maxrbrzatab)

                If gde = "above" Then
                    maxrbrPre = "select max(rbr)  as rbr from vrepISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr <" + minrbrzatab.Trim + ""
                    maxrbrPre = getrbr(maxrbrPre)
                    minrbrPosle = minrbrzatab
                Else
                    minrbrPosle = "select min(rbr) as rbr from vrepISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr >" + maxrbrzatab.Trim + ""
                    minrbrPosle = getrbr(minrbrPosle)
                    maxrbrPre = maxrbrzatab
                End If
            Else
                'ako nije tabela
                str = "select max(isnull(f1,0)) as maxf1 from vrepistpolja where sifist ='" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr<" + pp(4).Trim + ""
                f1 = getrbr(str)
                If f1 <> "0" Then f1 = CStr(CInt(f1) + 1).Trim Else f1 = "1"
                If gde = "above" Then
                    minrbrPosle = pp(4).Trim
                    str = "select max(rbr) as maxrbr from istpolja where sifist ='" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr<" + pp(4).Trim + ""
                    maxrbrPre = getrbr(str)
                Else
                    str = "select min(rbr) as minrbr from istpolja where sifist ='" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr>" + pp(4).Trim + ""
                    minrbrPosle = getrbr(str)
                    maxrbrPre = pp(4).Trim
                End If
            End If

            '1. pomeranje
            sqlI = " update a set a.forma=rtrim(ltrim(str((f1+1))+'.'+rtrim(ltrim(str(f2)))+'.'+rtrim(ltrim(str(f3)))))  " +
                             " from istpolja A inner Join vrepistpolja b on a.tabela=b.tabela And a.polje=b.polje And a.vod=b.vod" +
                             " where a.sifist ='" + sifist + "' and a.tabela=N'" + pp(0).Trim + "' and b.f1>=" + f1 + ";" + nvrd
            '2. pomeranje
            Dim brcells As Integer = nudR.Value * nudC.Value
            Dim pI As String = "ok"
            If minrbrPosle <> "" Then
                sqlI = sqlI + " update istpolja set rbr=rbr+" + CStr(brcells).Trim + "*10 where sifist ='" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr>=" + minrbrPosle.Trim + ";" + nvrd
                pI = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlI)
            End If

            If pI = "ok" Then
                'insert
                'tab default
                Dim i As Integer = 0
                Dim rrbr As Integer = 10
                Dim daizadjemskroz As Integer = 1

                Dim ppolje As String = ""
                Dim fp As Boolean = False

                Dim ir As Integer = 0 : Dim ic As Integer = 0
                If txtRI.Text = "" AndAlso txtCI.Text = "" Then
                ElseIf txtRI.Text = "" AndAlso txtCI.Text <> "" Then
                    'ne moze
                    txtRI.Focus()
                    Exit Sub
                ElseIf txtRI.Text <> "" AndAlso txtCI.Text = "" Then
                    ic = 1
                    ir = CInt(txtRI.Text)
                ElseIf txtRI.Text <> "" AndAlso txtCI.Text <> "" Then
                    ic = CInt(txtCI.Text)
                    ir = CInt(txtRI.Text)
                End If

                If cbTabDownLeft.Checked = False Then
                    dodppolje = ""
                    'fp
                    For red As Integer = 1 To nudHR.Value
                        For kolona As Integer = 1 To nudC.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = True
                            ppolje = dajUniqueImeISTDB(pp(0).Trim, "fp" + txtName.Text + "_", dodppolje)
                            dodppolje = dodppolje + ppolje + ";"
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next
                    Next
                    For kolona As Integer = 1 To nudHC.Value
                        For red As Integer = nudHR.Value + 1 To nudR.Value - nudFR.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = True
                            ppolje = dajUniqueImeISTDB(pp(0).Trim, "fp" + txtName.Text + "_", dodppolje)
                            dodppolje = dodppolje + ppolje + ";"
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next
                    Next
                    'fp

                    dodppolje = ""
                    For red As Integer = nudHR.Value + 1 To nudR.Value - nudFR.Value
                        For kolona As Integer = nudHC.Value + 1 To nudC.Value - nudFC.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = False
                            If ir = 0 AndAlso ic = 0 Then
                                ppolje = txtName.Text + "_" + f1 + "_" + CStr(red) + "_" + CStr(kolona)
                            Else
                                If Me.cbSN.Checked = True Then
                                    ppolje = txtName.Text + CStr(ir) + "_" + CStr(ic)
                                Else
                                    ppolje = txtName.Text + "_" + f1 + "_" + CStr(ir) + "_" + CStr(ic)
                                End If
                                ic = ic + 1
                            End If
                            If ppolje = "" Then txtRI.Focus() : Exit Sub
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next
                        For kolona As Integer = nudC.Value - nudFC.Value + 1 To nudC.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = True
                            ppolje = dajUniqueImeISTDB(pp(0).Trim, "fp" + txtName.Text + "_", dodppolje)
                            dodppolje = dodppolje + ppolje + ";"
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next

                        If ir = 0 AndAlso ic = 0 Then
                        Else
                            ir = ir + 1
                            If txtCI.Text = "" Then ic = 1 Else ic = CInt(txtCI.Text)
                        End If
                    Next


                    'fp
                    For red As Integer = nudR.Value - nudFR.Value + 1 To nudR.Value
                        For kolona As Integer = 1 To nudC.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = True
                            ppolje = dajUniqueImeISTDB(pp(0).Trim, "fp" + txtName.Text + "_", dodppolje)
                            dodppolje = dodppolje + ppolje + ";"
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next
                    Next
                    'fp

                End If '  If cbTabDownLeft.Checked = False Then

                ''tab NIJE default
                If cbTabDownLeft.Checked = True Then
                    dodppolje = ""
                    'fp
                    For red As Integer = 1 To nudHR.Value
                        For kolona As Integer = 1 To nudC.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = True
                            ppolje = dajUniqueImeISTDB(pp(0).Trim, "fp" + txtName.Text + "_", dodppolje)
                            dodppolje = dodppolje + ppolje + ";"
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next
                    Next
                    For kolona As Integer = 1 To nudHC.Value
                        For red As Integer = nudHR.Value + 1 To nudR.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = True
                            ppolje = dajUniqueImeISTDB(pp(0).Trim, "fp" + txtName.Text + "_", dodppolje)
                            dodppolje = dodppolje + ppolje + ";"
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next
                    Next
                    'fp
                    dodppolje = ""
                    For kolona As Integer = nudHC.Value + 1 To nudC.Value
                        For red As Integer = nudHR.Value + 1 To nudR.Value
                            i = i + 1 : rrbr = CInt(maxrbrPre) + i * 10
                            fp = False
                            If ir = 0 AndAlso ic = 0 Then
                                ppolje = txtName.Text + "_" + f1 + "_" + CStr(red) + "_" + CStr(kolona)
                            Else
                                If Me.cbSN.Checked = True Then
                                    ppolje = txtName.Text + CStr(ir) + "_" + CStr(ic)
                                Else
                                    ppolje = txtName.Text + "_" + f1 + "_" + CStr(ir) + "_" + CStr(ic)
                                End If
                                ir = ir + 1
                            End If
                            If ppolje = "" Then txtRI.Focus() : Exit Sub
                            dodajpolje(red, kolona, f1, pp(0).Trim, rrbr, pp(1).Trim, fp, ppolje)
                        Next

                        If ir = 0 AndAlso ic = 0 Then
                        Else
                            ic = ic + 1
                            If txtRI.Text = "" Then ir = 1 Else ir = CInt(txtRI.Text)
                        End If
                    Next
                End If

                Me.Cursor = Cursors.Default
                Me.Close()
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim dodppolje As String = ""

    Function getrbr(ByVal sqlrbr As String) As String
        Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
        If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 Then
            getrbr = dt1.Rows(0).Item(0).ToString
        Else
            getrbr = "0"
        End If
    End Function
    Dim sqlDBDropTip As String = ""
    Dim DropTip As String = ""
    Function dodajpolje(ByVal red As Integer, ByVal kolona As Integer, ByVal f1 As String, ByVal tabela As String, ByVal rrbr As Integer, ByVal tvalidfrom As String, ByVal fp As Boolean, ByVal ppolje As String) As Boolean
        dodajpolje = True
        Dim pizraz As String = ""
        Dim pforma As String = f1.Trim + "." + CStr(red).Trim + "." + CStr(kolona).Trim

        'If fp = True Then pizraz = "''Text_" + pforma + "''"
        If fp = True Then pizraz = "'' ''"

        Dim ptip As String = ""
        Dim pduzina As String = ""
        Dim pDB As String = "ok"

        Dim sqlI As String = "insert into istpolja (sifist,tabela,polje,rbr,izraz,vod,vdo,opis,forma,tip,duzina) " +
                " values ('" + sifist + "','" + tabela + "','" + ppolje + "','" +
            CStr(rrbr).Trim + "','" + pizraz + "','" + Convert.ToDateTime(tvalidfrom).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'," +
            "'2099/12/31','$','" + pforma + "','" + ptip + "','" + pduzina + "');" + nvrd

        Dim sqlDB As String = fformatPolja(tabela, ppolje)
        Dim pI As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlI,, sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))

        If pI = "nok" Then ISTMessageBox.Show("Error! Not added to IST!")

        If fp = False Then
            pDB = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
            ptip = Me.txtTip.Text
            If Me.txtDuzChar.Text <> "" Then pduzina = Me.txtDuzChar.Text Else pduzina = Me.txtDuzOstalo.Text
        End If

        If pDB = "nok" Then
            ISTMessageBox.Show("Error. Not added to DB!")
            dodajpolje = False
        End If


    End Function

    Function dajUniqueImeISTDB(ByVal tabela As String, ByVal cname As String, ByVal dodpolje As String) As String
        Dim sql As String = ""
        dajUniqueImeISTDB = cname + "1"
        For i As Integer = 1 To 100000
            If dodpolje = "" OrElse dodpolje.IndexOf(cname + CStr(i).Trim + ";") < 0 Then
                sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabela + "'   and  COLUMN_NAME='" + cname + CStr(i).Trim + "'"
                Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                    dajUniqueImeISTDB = cname + CStr(i).Trim
                    sql = "SELECT polje FROM istpolja where sifist=N'" + sifist + "' and tabela=N'" + tabela + "' and polje=N'" + dajUniqueImeISTDB + "'"
                    Dim dtI As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
                    'UVEK MORA IZ BAZE, NE MOZE PREKO  redoviMEM
                    If dtI Is Nothing OrElse dtI.Rows.Count = 0 Then
                        'sve ok
                        Exit For
                    Else
                        'teraj dalje
                    End If
                End If
            End If
        Next
    End Function

    Function postojiuDB(ByVal tabela As String, ByVal polje As String) As Boolean
        postojiuDB = True
        Dim sql As String = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabela + "' and  COLUMN_NAME='" + polje + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            postojiuDB = False
        End If
    End Function

    Function postojiuIST(ByVal tabela As String, ByVal polje As String) As Boolean
        postojiuIST = True
        Dim sql As String = "SELECT polje FROM istpolja where sifist=N'" + sifist + "' and tabela = '" + tabela + "' and  polje=N'" + polje + "'"
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
        If dt Is Nothing OrElse dt.Rows.Count = 0 Then
            postojiuIST = False
        End If
    End Function

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
            BtnInsert.Visible = False
            'Call fformat()
        ElseIf poIST = False And poDB = False Then
            trebadb = True
            gbType.Visible = True
            BtnInsert.Visible = True
        End If
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        Me.gbType.Visible = False
    End Sub

    Private Sub cbCNIterate_CheckedChanged(sender As Object, e As EventArgs) Handles cbRI.CheckedChanged
        Me.txtRI.Visible = Me.cbRI.Checked
        If Me.cbRI.Checked = True Then
            txtRI.Focus()
            txtRI.Text = ""
        Else
            txtRI.Text = ""
        End If
    End Sub

    Private Sub cbCN_CheckedChanged(sender As Object, e As EventArgs) Handles cbCI.CheckedChanged
        Me.txtCI.Visible = Me.cbCI.Checked
        If Me.cbCI.Checked = True Then
            txtCI.Focus()
            txtCI.Text = ""
        Else
            txtCI.Text = ""
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.AccessibleName = "cancel"
        Me.Close()
    End Sub
End Class