'Option Strict Off

Public Class mFormInsertRelacija
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
    Friend WithEvents txtDataSource As TextBox
    Friend WithEvents lDS As Label
    Friend WithEvents cbWebRel As CheckBox
    Friend WithEvents txtWhere As TextBox
    Friend WithEvents txtBaza As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents llSB As LinkLabel
    Friend WithEvents tvBaza As TreeView
    Friend WithEvents txtConnString As TextBox
    Friend WithEvents mnu02 As ContextMenuStrip
    Friend WithEvents a1 As ToolStripMenuItem
    Friend WithEvents a4 As ToolStripMenuItem
    Friend WithEvents a5 As ToolStripMenuItem
    Friend WithEvents a6 As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbYY As CheckBox
    Friend WithEvents cbMM As CheckBox
    Friend WithEvents cbUU As CheckBox
    Friend WithEvents txtSelect As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents a2 As ToolStripMenuItem
    Friend WithEvents btnCreateRel As Button
    Friend WithEvents a3 As ToolStripMenuItem
    Friend WithEvents cbU As CheckBox
    Friend WithEvents cbM As CheckBox
    Friend WithEvents cbG As CheckBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents p1 As Panel
    Friend WithEvents cboDS1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lF As Label
    Friend WithEvents btnAdd1 As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents cboIST1 As ComboBox
    Friend WithEvents cbDA As CheckBox
    Friend WithEvents p2 As Panel
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents txt2 As TextBox
    Friend WithEvents cboIST2 As ComboBox
    Friend WithEvents cboDS2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvRel As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCaNCEL As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCaNCEL = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.lDS = New System.Windows.Forms.Label()
        Me.cbWebRel = New System.Windows.Forms.CheckBox()
        Me.txtWhere = New System.Windows.Forms.TextBox()
        Me.txtBaza = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.llSB = New System.Windows.Forms.LinkLabel()
        Me.tvBaza = New System.Windows.Forms.TreeView()
        Me.txtConnString = New System.Windows.Forms.TextBox()
        Me.mnu02 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.a1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.a4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.a6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbYY = New System.Windows.Forms.CheckBox()
        Me.cbMM = New System.Windows.Forms.CheckBox()
        Me.cbUU = New System.Windows.Forms.CheckBox()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCreateRel = New System.Windows.Forms.Button()
        Me.cbU = New System.Windows.Forms.CheckBox()
        Me.cbM = New System.Windows.Forms.CheckBox()
        Me.cbG = New System.Windows.Forms.CheckBox()
        Me.p1 = New System.Windows.Forms.Panel()
        Me.btnAdd1 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.cboIST1 = New System.Windows.Forms.ComboBox()
        Me.cboDS1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lF = New System.Windows.Forms.Label()
        Me.cbDA = New System.Windows.Forms.CheckBox()
        Me.p2 = New System.Windows.Forms.Panel()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.cboIST2 = New System.Windows.Forms.ComboBox()
        Me.cboDS2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvRel = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu02.SuspendLayout()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        CType(Me.dgvRel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(891, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(154, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.TabStop = False
        Me.BtnFormat.Text = "Save"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Function Relacija "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnCaNCEL)
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 566)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 30)
        Me.Panel1.TabIndex = 38
        '
        'btnCaNCEL
        '
        Me.btnCaNCEL.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCaNCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCaNCEL.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCaNCEL.Location = New System.Drawing.Point(1051, 3)
        Me.btnCaNCEL.Name = "btnCaNCEL"
        Me.btnCaNCEL.Size = New System.Drawing.Size(149, 24)
        Me.btnCaNCEL.TabIndex = 2
        Me.btnCaNCEL.TabStop = False
        Me.btnCaNCEL.Text = "Cancel"
        Me.btnCaNCEL.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(1204, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'txtDataSource
        '
        Me.txtDataSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDataSource.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtDataSource.Location = New System.Drawing.Point(244, 48)
        Me.txtDataSource.Multiline = True
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(232, 22)
        Me.txtDataSource.TabIndex = 252
        '
        'lDS
        '
        Me.lDS.AutoSize = True
        Me.lDS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDS.Location = New System.Drawing.Point(244, 29)
        Me.lDS.Name = "lDS"
        Me.lDS.Size = New System.Drawing.Size(125, 13)
        Me.lDS.TabIndex = 243
        Me.lDS.Text = "Data source  (from )"
        '
        'cbWebRel
        '
        Me.cbWebRel.AccessibleName = ""
        Me.cbWebRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbWebRel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbWebRel.Location = New System.Drawing.Point(633, 48)
        Me.cbWebRel.Name = "cbWebRel"
        Me.cbWebRel.Size = New System.Drawing.Size(220, 21)
        Me.cbWebRel.TabIndex = 251
        Me.cbWebRel.Text = "For web - generate also for web"
        '
        'txtWhere
        '
        Me.txtWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWhere.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtWhere.Location = New System.Drawing.Point(10, 96)
        Me.txtWhere.Multiline = True
        Me.txtWhere.Name = "txtWhere"
        Me.txtWhere.Size = New System.Drawing.Size(466, 59)
        Me.txtWhere.TabIndex = 247
        '
        'txtBaza
        '
        Me.txtBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaza.Enabled = False
        Me.txtBaza.Location = New System.Drawing.Point(891, 72)
        Me.txtBaza.Name = "txtBaza"
        Me.txtBaza.Size = New System.Drawing.Size(232, 22)
        Me.txtBaza.TabIndex = 256
        '
        'txtServer
        '
        Me.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServer.Enabled = False
        Me.txtServer.Location = New System.Drawing.Point(891, 50)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(232, 22)
        Me.txtServer.TabIndex = 255
        '
        'llSB
        '
        Me.llSB.AutoSize = True
        Me.llSB.Location = New System.Drawing.Point(891, 33)
        Me.llSB.Name = "llSB"
        Me.llSB.Size = New System.Drawing.Size(197, 14)
        Me.llSB.TabIndex = 253
        Me.llSB.TabStop = True
        Me.llSB.Text = "Select server and database ..."
        '
        'tvBaza
        '
        Me.tvBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvBaza.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvBaza.ItemHeight = 16
        Me.tvBaza.Location = New System.Drawing.Point(891, 96)
        Me.tvBaza.Name = "tvBaza"
        Me.tvBaza.Size = New System.Drawing.Size(307, 234)
        Me.tvBaza.TabIndex = 257
        Me.tvBaza.Visible = False
        '
        'txtConnString
        '
        Me.txtConnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConnString.Enabled = False
        Me.txtConnString.Location = New System.Drawing.Point(1160, 62)
        Me.txtConnString.Multiline = True
        Me.txtConnString.Name = "txtConnString"
        Me.txtConnString.Size = New System.Drawing.Size(38, 28)
        Me.txtConnString.TabIndex = 258
        Me.txtConnString.Visible = False
        '
        'mnu02
        '
        Me.mnu02.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu02.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnu02.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.a1, Me.a2, Me.a3, Me.ToolStripSeparator1, Me.a4, Me.a5, Me.ToolStripSeparator2, Me.a6})
        Me.mnu02.Name = "mnuColumn"
        Me.mnu02.ShowCheckMargin = True
        Me.mnu02.Size = New System.Drawing.Size(321, 148)
        '
        'a1
        '
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(320, 22)
        Me.a1.Text = "Add tabele/view/function to datasource"
        '
        'a2
        '
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(320, 22)
        Me.a2.Text = "Add column to Select clause"
        '
        'a3
        '
        Me.a3.Name = "a3"
        Me.a3.Size = New System.Drawing.Size(320, 22)
        Me.a3.Text = "Add column to Where clause"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(317, 6)
        '
        'a4
        '
        Me.a4.Name = "a4"
        Me.a4.Size = New System.Drawing.Size(320, 22)
        Me.a4.Text = "Add column as Display member"
        '
        'a5
        '
        Me.a5.Name = "a5"
        Me.a5.Size = New System.Drawing.Size(320, 22)
        Me.a5.Text = "Add column as Value member"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(317, 6)
        '
        'a6
        '
        Me.a6.Name = "a6"
        Me.a6.Size = New System.Drawing.Size(320, 22)
        Me.a6.Text = "Add column as Filter column"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 264
        Me.Label5.Text = "Where clause  (where )"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(409, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 265
        '
        'cbYY
        '
        Me.cbYY.AccessibleName = ""
        Me.cbYY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbYY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYY.Location = New System.Drawing.Point(633, 96)
        Me.cbYY.Name = "cbYY"
        Me.cbYY.Size = New System.Drawing.Size(158, 20)
        Me.cbYY.TabIndex = 266
        Me.cbYY.Text = "and ISTYear={YYY}"
        '
        'cbMM
        '
        Me.cbMM.AccessibleName = ""
        Me.cbMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMM.Location = New System.Drawing.Point(633, 114)
        Me.cbMM.Name = "cbMM"
        Me.cbMM.Size = New System.Drawing.Size(158, 20)
        Me.cbMM.TabIndex = 267
        Me.cbMM.Text = "and ISTMonth={MMM}"
        '
        'cbUU
        '
        Me.cbUU.AccessibleName = ""
        Me.cbUU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUU.Location = New System.Drawing.Point(633, 132)
        Me.cbUU.Name = "cbUU"
        Me.cbUU.Size = New System.Drawing.Size(158, 20)
        Me.cbUU.TabIndex = 268
        Me.cbUU.Text = "and ISTUser"
        '
        'txtSelect
        '
        Me.txtSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelect.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSelect.Location = New System.Drawing.Point(10, 48)
        Me.txtSelect.Multiline = True
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(232, 22)
        Me.txtSelect.TabIndex = 270
        Me.txtSelect.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 13)
        Me.Label7.TabIndex = 269
        Me.Label7.Text = "Select clause  (select )"
        '
        'btnCreateRel
        '
        Me.btnCreateRel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCreateRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateRel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCreateRel.Location = New System.Drawing.Point(815, 196)
        Me.btnCreateRel.Name = "btnCreateRel"
        Me.btnCreateRel.Size = New System.Drawing.Size(67, 38)
        Me.btnCreateRel.TabIndex = 272
        Me.btnCreateRel.TabStop = False
        Me.btnCreateRel.Tag = "Add"
        Me.btnCreateRel.Text = "Add Relacija"
        Me.btnCreateRel.UseVisualStyleBackColor = False
        '
        'cbU
        '
        Me.cbU.AccessibleName = ""
        Me.cbU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbU.Location = New System.Drawing.Point(502, 132)
        Me.cbU.Name = "cbU"
        Me.cbU.Size = New System.Drawing.Size(125, 20)
        Me.cbU.TabIndex = 277
        Me.cbU.Text = "and ISTuser=''"
        '
        'cbM
        '
        Me.cbM.AccessibleName = ""
        Me.cbM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbM.Location = New System.Drawing.Point(502, 114)
        Me.cbM.Name = "cbM"
        Me.cbM.Size = New System.Drawing.Size(125, 20)
        Me.cbM.TabIndex = 276
        Me.cbM.Text = "and mes={MMM}"
        '
        'cbG
        '
        Me.cbG.AccessibleName = ""
        Me.cbG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbG.Location = New System.Drawing.Point(502, 96)
        Me.cbG.Name = "cbG"
        Me.cbG.Size = New System.Drawing.Size(125, 20)
        Me.cbG.TabIndex = 275
        Me.cbG.Text = "and god={GGG}"
        '
        'p1
        '
        Me.p1.Controls.Add(Me.btnAdd1)
        Me.p1.Controls.Add(Me.txt1)
        Me.p1.Controls.Add(Me.cboIST1)
        Me.p1.Controls.Add(Me.cboDS1)
        Me.p1.Controls.Add(Me.Label4)
        Me.p1.Controls.Add(Me.Label8)
        Me.p1.Controls.Add(Me.lF)
        Me.p1.Location = New System.Drawing.Point(8, 196)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(401, 134)
        Me.p1.TabIndex = 300
        '
        'btnAdd1
        '
        Me.btnAdd1.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAdd1.Location = New System.Drawing.Point(360, 37)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(30, 22)
        Me.btnAdd1.TabIndex = 302
        Me.btnAdd1.TabStop = False
        Me.btnAdd1.Text = "+"
        Me.btnAdd1.UseVisualStyleBackColor = False
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.Location = New System.Drawing.Point(6, 65)
        Me.txt1.Multiline = True
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(384, 53)
        Me.txt1.TabIndex = 302
        '
        'cboIST1
        '
        Me.cboIST1.DropDownWidth = 450
        Me.cboIST1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboIST1.FormattingEnabled = True
        Me.cboIST1.Location = New System.Drawing.Point(6, 37)
        Me.cboIST1.Name = "cboIST1"
        Me.cboIST1.Size = New System.Drawing.Size(164, 22)
        Me.cboIST1.TabIndex = 269
        '
        'cboDS1
        '
        Me.cboDS1.DropDownWidth = 450
        Me.cboDS1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDS1.FormattingEnabled = True
        Me.cboDS1.Location = New System.Drawing.Point(195, 37)
        Me.cboDS1.Name = "cboDS1"
        Me.cboDS1.Size = New System.Drawing.Size(164, 22)
        Me.cboDS1.TabIndex = 268
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(173, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 267
        Me.Label4.Text = "="
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 266
        Me.Label8.Text = "Screen field (from IST)"
        '
        'lF
        '
        Me.lF.AutoSize = True
        Me.lF.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lF.Location = New System.Drawing.Point(195, 18)
        Me.lF.Name = "lF"
        Me.lF.Size = New System.Drawing.Size(149, 13)
        Me.lF.TabIndex = 264
        Me.lF.Text = "Column from datasource"
        '
        'cbDA
        '
        Me.cbDA.AccessibleName = ""
        Me.cbDA.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDA.Location = New System.Drawing.Point(413, 175)
        Me.cbDA.Name = "cbDA"
        Me.cbDA.Size = New System.Drawing.Size(420, 21)
        Me.cbDA.TabIndex = 302
        Me.cbDA.Text = "Assign value of selected data source row columns to screen fields"
        '
        'p2
        '
        Me.p2.Controls.Add(Me.btnAdd2)
        Me.p2.Controls.Add(Me.txt2)
        Me.p2.Controls.Add(Me.cboIST2)
        Me.p2.Controls.Add(Me.cboDS2)
        Me.p2.Controls.Add(Me.Label2)
        Me.p2.Controls.Add(Me.Label3)
        Me.p2.Controls.Add(Me.Label10)
        Me.p2.Location = New System.Drawing.Point(413, 196)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(401, 134)
        Me.p2.TabIndex = 303
        Me.p2.Visible = False
        '
        'btnAdd2
        '
        Me.btnAdd2.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnAdd2.Location = New System.Drawing.Point(360, 37)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(30, 22)
        Me.btnAdd2.TabIndex = 302
        Me.btnAdd2.TabStop = False
        Me.btnAdd2.Text = "+"
        Me.btnAdd2.UseVisualStyleBackColor = False
        '
        'txt2
        '
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.Location = New System.Drawing.Point(6, 65)
        Me.txt2.Multiline = True
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(384, 53)
        Me.txt2.TabIndex = 302
        '
        'cboIST2
        '
        Me.cboIST2.DropDownWidth = 450
        Me.cboIST2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboIST2.FormattingEnabled = True
        Me.cboIST2.Location = New System.Drawing.Point(6, 37)
        Me.cboIST2.Name = "cboIST2"
        Me.cboIST2.Size = New System.Drawing.Size(164, 22)
        Me.cboIST2.TabIndex = 269
        '
        'cboDS2
        '
        Me.cboDS2.DropDownWidth = 450
        Me.cboDS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDS2.FormattingEnabled = True
        Me.cboDS2.Location = New System.Drawing.Point(194, 37)
        Me.cboDS2.Name = "cboDS2"
        Me.cboDS2.Size = New System.Drawing.Size(164, 22)
        Me.cboDS2.TabIndex = 268
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 267
        Me.Label2.Text = "="
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 266
        Me.Label3.Text = "Screen field (from IST)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(194, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 13)
        Me.Label10.TabIndex = 264
        Me.Label10.Text = "Column from datasource"
        '
        'dgvRel
        '
        Me.dgvRel.AllowDrop = True
        Me.dgvRel.AllowUserToAddRows = False
        Me.dgvRel.AllowUserToDeleteRows = False
        Me.dgvRel.AllowUserToOrderColumns = True
        Me.dgvRel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRel.ColumnHeadersHeight = 30
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRel.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvRel.GridColor = System.Drawing.SystemColors.Control
        Me.dgvRel.Location = New System.Drawing.Point(8, 336)
        Me.dgvRel.MultiSelect = False
        Me.dgvRel.Name = "dgvRel"
        Me.dgvRel.RowHeadersWidth = 33
        Me.dgvRel.RowTemplate.Height = 30
        Me.dgvRel.Size = New System.Drawing.Size(1184, 224)
        Me.dgvRel.TabIndex = 306
        Me.dgvRel.Tag = "9"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 307
        Me.Label9.Text = "Map join criteria"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnClear.Location = New System.Drawing.Point(815, 261)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 38)
        Me.btnClear.TabIndex = 308
        Me.btnClear.TabStop = False
        Me.btnClear.Tag = " "
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'mFormInsertRelacija
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1204, 596)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvRel)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.cbDA)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.btnCreateRel)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConnString)
        Me.Controls.Add(Me.tvBaza)
        Me.Controls.Add(Me.txtBaza)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.llSB)
        Me.Controls.Add(Me.txtDataSource)
        Me.Controls.Add(Me.lDS)
        Me.Controls.Add(Me.cbWebRel)
        Me.Controls.Add(Me.txtWhere)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.cbU)
        Me.Controls.Add(Me.cbM)
        Me.Controls.Add(Me.cbG)
        Me.Controls.Add(Me.cbUU)
        Me.Controls.Add(Me.cbMM)
        Me.Controls.Add(Me.cbYY)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormInsertRelacija"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert "
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu02.ResumeLayout(False)
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        CType(Me.dgvRel, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.gde = gde
        Me.dIst = dIst
        Me.what = what

        tvBaza.ContextMenuStrip = mnu02
        'DBConnectionString  "Data Source=IMT2.STATSRB.LAN;Initial Catalog=DEPOPROJEKTANTI;Integrated Security=SSPI;Persist Security Info=False"	String
        Call getServerBazaNew(Me.DBConnectionString)
        Call DajTabelePolja2(tvBaza, Me.txtServer.Text, Me.txtBaza.Text)
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        Call dajDGV()

        Dim strSQl As String = "select polje as displaymember,polje as valuemember from ISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' order by polje"
        Call popunicbo(cboIST1, strSQl, Me.ISTConnectionString)
        Call popunicbo(cboIST2, strSQl, Me.ISTConnectionString)
        Me.BtnFormat.Text = Me.what
        Me.tvBaza.Focus()

    End Sub

    Sub dajDGV(Optional ByVal rreset As Integer = 0)

        Me.dgvRel.DataSource = getDTC()
        Call dodajll()
        dgvRel.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 8)
        dgvRel.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Verdana", 8, FontStyle.Bold)
        dgvRel.Columns("appCode").Visible = False
        dgvRel.Columns("tableName").Visible = False
        dgvRel.Columns("errNumber").ReadOnly = True
        dgvRel.Columns("errWeight").Visible = False
        dgvRel.Columns("error").Width = 200
        dgvRel.Columns("errTitle").Width = 150
        'dgvRel.Columns("Action").Visible = False
        '"select appCode,tableName,errNumber,error,errWeight,errTitle,errAction,ValidFrom,ValidTo, 0 as xxx"
    End Sub

    Dim errN As String = ""

    Private Sub dgvRel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRel.CellClick
        ' e.ColumnIndex = 10 je edit link, 9 je xxx
        ' e.ColumnIndex = 11 je deactivate link, 9 je xxx
        ' e.ColumnIndex = 12 je activate link, 9 je xxx
        ' e.ColumnIndex = 13 je delete link, 9 je xxx
        Me.btnCreateRel.Tag = "-1"
        If e.ColumnIndex = 10 Then
            'ISTMessageBox.Show("yes" + dgvRel.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
            dgvRel.Item(9, e.RowIndex).Value = "Update"
            Me.btnCreateRel.Text = "Update"
            Me.btnCreateRel.Tag = (e.RowIndex).ToString.Trim

            errN = dgvRel.Item(2, e.RowIndex).Value

            'appCode,tableName,errNumber,error,errWeight,errTitle,errAction,ValidFrom,ValidTo, '' as Action
            Dim sselect As String = ""
            Dim sspajanje As String = ""
            Dim ddodela As String = ""

            Dim pom As String = dgvRel.Item(3, e.RowIndex).Value
            pom = pom.Replace("#Relacija{", "").TrimEnd("}")
            Dim pp() As String = pom.Split(";")
            If pp.Length = 1 Then
                sselect = pom
            Else
                sselect = pp(0)
                Dim ppm() As String = pp(1).Split(":")
                If ppm.Length = 1 Then
                    sspajanje = pp(1)
                Else
                    sspajanje = ppm(0)
                    ddodela = ppm(1)
                End If
            End If
            If sselect.Trim.Substring(0, 1) = "(" AndAlso sselect.Trim.Substring(sselect.Length - 1, 1) = ")" Then sselect = sselect.Substring(1, sselect.Length - 2)
            Dim sss As String = ""
            Dim ds As String = ""
            Dim wh As String = ""
            If sselect.Trim.ToUpper.IndexOf("SELECT") = 0 Then
                Dim ss As Integer = -1 : Dim ff As Integer = -1 : Dim ww As Integer = -1
                Dim bMEM() As String = {} : bMEM = razkvantaj(sselect)
                For mm As Integer = 0 To bMEM.GetUpperBound(0)
                    If bMEM(mm).Trim.ToUpper.IndexOf("SELECT") = 0 Then ss = mm
                    If bMEM(mm).Trim.ToUpper.IndexOf("FROM") = 0 Then ff = mm
                    If bMEM(mm).Trim.ToUpper.IndexOf("WHERE") = 0 Then ww = mm
                Next
                For mm As Integer = ss + 1 To ff - 1
                    sss = sss + bMEM(mm)
                Next
                If ff > -1 And ww > -1 Then
                    For mm As Integer = ff + 1 To ww - 1
                        ds = ds + bMEM(mm)
                    Next
                End If
                If ff > -1 And ww = -1 Then
                    For mm As Integer = ff + 1 To bMEM.GetUpperBound(0)
                        ds = ds + bMEM(mm)
                    Next
                End If
                If ww > -1 Then
                    For mm As Integer = ww + 1 To bMEM.GetUpperBound(0)
                        wh = wh + bMEM(mm) + " "
                    Next
                End If
            Else
                sss = "*"
                ds = sselect
                wh = ""
            End If
            Me.txtSelect.Text = sss
            Me.txtWhere.Text = wh

            Me.txtDataSource.Text = ds
            If Me.txtDataSource.Text <> "" Then dajCBODS(Me.txtDataSource.Text)

            If sspajanje <> "" Then Me.txt1.Text = sspajanje

            If ddodela <> "" Then
                Me.txt2.Text = ddodela
                p2.Visible = True
                Me.cbDA.Checked = True
            End If

        ElseIf e.ColumnIndex = 11 Then
            dgvRel.Item(7, e.RowIndex).Value = "6432/1/1"
            dgvRel.Item(9, e.RowIndex).Value = "Deactivate"
        ElseIf e.ColumnIndex = 12 Then
            dgvRel.Item(7, e.RowIndex).Value = "2020/1/1"
            dgvRel.Item(9, e.RowIndex).Value = "Activate"
        ElseIf e.ColumnIndex = 13 Then
            If ISTMessageBox.Show("Are you sure you want to delete this row?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                dgvRel.Item(9, e.RowIndex).Value = "Delete"
                dgvRel.Rows(e.RowIndex).Height = 1
            End If
            'dgvRel.Rows.Remove(dgvRel.Rows(e.RowIndex))
        End If
    End Sub

    Sub dodajll()
        Dim ll As DataGridViewLinkColumn = New DataGridViewLinkColumn()
        ll.Text = "Edit"
        ll.Name = "Edit"
        ll.DataPropertyName = "Edit"
        ll.Width = 50
        ll.HeaderText = ""
        ll.UseColumnTextForLinkValue = True
        ll.LinkBehavior = LinkBehavior.AlwaysUnderline
        ll.LinkColor = Color.Black
        ll.VisitedLinkColor = Color.Gray
        ll.TrackVisitedState = True
        dgvRel.Columns.Add(ll)
        dgvRel.Columns(ll.Text).DisplayIndex = 0

        Dim ll2 As DataGridViewLinkColumn = New DataGridViewLinkColumn()
        ll2.Text = "Deactivate"
        ll2.Name = "Deactivate"
        ll2.DataPropertyName = "Deactivate"
        ll2.Width = 75
        ll2.HeaderText = ""
        ll2.UseColumnTextForLinkValue = True
        ll2.LinkBehavior = LinkBehavior.AlwaysUnderline
        ll2.LinkColor = Color.Black
        ll2.VisitedLinkColor = Color.Gray
        ll2.TrackVisitedState = True
        dgvRel.Columns.Add(ll2)
        dgvRel.Columns(ll2.Text).DisplayIndex = 1

        Dim ll4 As DataGridViewLinkColumn = New DataGridViewLinkColumn()
        ll4.Text = "Activate"
        ll4.Name = "Activate"
        ll4.DataPropertyName = "Activate"
        ll4.Width = 75
        ll4.HeaderText = ""
        ll4.UseColumnTextForLinkValue = True
        ll4.LinkBehavior = LinkBehavior.AlwaysUnderline
        ll4.LinkColor = Color.Black
        ll4.VisitedLinkColor = Color.Gray
        ll4.TrackVisitedState = True
        dgvRel.Columns.Add(ll4)
        dgvRel.Columns(ll4.Text).DisplayIndex = 2

        Dim ll3 As DataGridViewLinkColumn = New DataGridViewLinkColumn()
        ll3.Text = "Delete"
        ll3.Name = "Delete"
        ll3.DataPropertyName = "Delete"
        ll3.Width = 50
        ll3.HeaderText = ""
        ll3.UseColumnTextForLinkValue = True
        ll3.LinkBehavior = LinkBehavior.AlwaysUnderline
        ll3.LinkColor = Color.Black
        ll3.VisitedLinkColor = Color.Gray
        ll3.TrackVisitedState = True
        dgvRel.Columns.Add(ll3)
        dgvRel.Columns(ll3.Text).DisplayIndex = 3

    End Sub

    Function getDTC() As System.Data.DataTable
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select appCode,tableName,errNumber,error,errWeight,errTitle," +
            " cast(case when errAction='DONTSAVE' then 1 else 0 end as bit) as DontSave,ValidFrom,ValidTo, '' as Action " +
                " from _ISTRulesDataValidation " +
                " where appCode=N'" + sifist + "' and tableName=N'" + pp(0).Trim + "' and error like N'%Relacija%'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Try

            Dim sqlIST As String = ""
            Dim sqlDB As String = ""
            Dim sqlDBDropTip As String = ""
            Dim DropTip As String = ""
            Dim sset As String = ""
            Dim uslov As String = ""
            Dim vod As String = ""
            Dim vdo As String = ""
            Dim greska As String = ""
            Dim nazivgreske As String = ""
            Dim rbrgreske As String = ""
            For i As Integer = 0 To dgvRel.Rows.Count - 1
                If dgvRel.Item(6, i).Value.ToString.Trim = "True" Then uslov = "DONTSAVE" Else uslov = ""
                If dgvRel.Item(7, i).Value.ToString.Trim <> "" Then vod = Convert.ToDateTime(dgvRel.Item(7, i).Value).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) Else vod = "2020/1/1"
                If dgvRel.Item(8, i).Value.ToString.Trim <> "" Then vdo = Convert.ToDateTime(dgvRel.Item(8, i).Value).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) Else vdo = "2099/1/1"
                If dgvRel.Item(3, i).Value.ToString.Trim <> "" Then greska = dgvRel.Item(3, i).Value.ToString.Trim Else greska = "2=3"
                If dgvRel.Item(5, i).Value.ToString.Trim <> "" Then nazivgreske = dgvRel.Item(5, i).Value.ToString.Trim Else nazivgreske = "Relacija"
                rbrgreske = dgvRel.Item(2, i).Value.ToString.Trim

                If dgvRel.Item(9, i).Value.ToString.Trim <> "" AndAlso dgvRel.Item(9, i).Value.ToString.Trim = "Update" Then

                    sset = " vod='" + vod + "'," +
                    " vdo='" + vdo + "'," +
                    " uslov='" + uslov + "'," +
                    " greska='" + greska + "'," +
                    " nazivgreske='" + nazivgreske + "'"

                    sqlIST = sqlIST + "update ISTLK set  " + sset + " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbrgreske='" + rbrgreske + "';" + nvrd

                ElseIf dgvRel.Item(9, i).Value.ToString.Trim <> "" AndAlso dgvRel.Item(9, i).Value.ToString.Trim = "Delete" Then

                    sqlIST = sqlIST + "delete from ISTLK where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbrgreske='" + rbrgreske + "';" + nvrd

                ElseIf dgvRel.Item(9, i).Value.ToString.Trim <> "" AndAlso dgvRel.Item(9, i).Value.ToString.Trim = "Insert" Then

                    sqlDB = sqlDB + "ALTER TABLE " + pp(0).Trim + " ADD  " + rbrgreske + " BIT NULL;" + nvrd
                    sqlDBDropTip = sqlDBDropTip + pp(0).Trim + ";" + rbrgreske.ToString.Trim + "#"
                    DropTip = DropTip + "ADD" + "#"

                    sqlIST = sqlIST + "insert into ISTLK (sifist,tabela,rbrgreske,greska,tezina,nazivgreske,uslov,vod,vdo) values (N'" + sifist + "'," +
                    "N'" + pp(0).Trim + "','" + rbrgreske + "',N'" + greska + "','T',N'" + nazivgreske + "',N'" + uslov + "'," +
                    "'" + vod + "','" + vdo + "');" + nvrd

                End If
            Next

            'dgvRel.Item(9, i).Value = "Update"
            'dgvRel.Item(8, i).Value = "2030/1/1"
            'dgvRel.Item(7, i).Value = "2020/1/1"
            'dgvRel.Item(6, i).Value = False
            'dgvRel.Item(5, i).Value = "Relation"
            'dgvRel.Item(4, i).Value = "T"
            'dgvRel.Item(3, i).Value = Err()
            'dgvRel.Item(2, i).Value = errN
            'dgvRel.Item(1, i).Value = pp(0).Trim
            'dgvRel.Item(0, i).Value = sifist

            Dim p2 As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST,, sqlDBDropTip.TrimEnd("#"), DropTip.TrimEnd("#"))

            If p2 = "ok" Then
                p2 = izvrsiSQLDB(sqlDB, Me.DBConnectionString)
                If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to DB!")
            End If

            If p2 = "nok" Then
                ISTMessageBox.Show("Error!")
            Else
                Me.Cursor = Cursors.Default
                Me.Close()
            End If


        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Function setMetaDataPaneP1() As String
        'izraz
        Dim pom As String = ""
        Return pom
    End Function

    Private Sub llSB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llSB.LinkClicked
        Call llDB()
    End Sub

    Sub llDB()
        Dim pomn As String = OleDbConnString.EditConnectionString(Me, "")
        Me.txtConnString.Text = pomn.Replace("Provider= SQLOLEDB.1;", "")
        Call getServerBazaNew(pomn)
        Call DajTabelePolja2(tvBaza, Me.txtServer.Text, Me.txtBaza.Text)
    End Sub

    Sub getServerBazaNew(ByVal pomn As String)
        Dim pp() As String = pomn.Split(";")
        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).IndexOf("Initial Catalog=") = 0 Then
                Me.txtBaza.Text = pp(i).Replace("Initial Catalog=", "")
                Me.txtBaza.Visible = True
            End If
            If pp(i).IndexOf("Data Source=") = 0 Then
                Me.txtServer.Text = pp(i).Replace("Data Source=", "")
                Me.txtServer.Visible = True
            End If
        Next
        If txtBaza.Text <> "" Then tvBaza.Visible = True
    End Sub

    Sub DajTabelePolja2(ByVal tv As TreeView, ByVal server As String, ByVal baza As String)
        tv.Nodes.Clear()
        Dim DBConnectionString As String = getConnectionString(server, baza, "", Me.DBConnectionString)

        Dim strTP As String = " use " + baza +
                    " Select ST.NAME As tableName, SC.NAME As columnName," +
                    " Case When SC.colid= SKC.column_id Then 'P' ELSE '' END AS primaryKey," +
                    " STY.NAME AS columnType, SC.prec  AS columnLenght" +
                    " FROM (select NAME,OBJECT_ID from SYS.TABLES union all select NAME,OBJECT_ID from SYS.VIEWS) AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
                    " left JOIN SYS.TYPES AS STY ON SC.xusertype  = STY.USER_TYPE_ID" +
                    " left JOIN SYS.INDEX_COLUMNS AS SKC" +
                    " ON SKC.OBJECT_ID = ST.OBJECT_ID AND SKC.column_id =SC.colid order by 1"
        Dim dtTP As New DataTable
        dtTP = izvrsiSQLvratiDT(strTP, DBConnectionString, Nothing)

        If dtTP.Rows.Count > 0 Then
            Dim node As TreeNode
            Dim tab As String = dtTP.Rows(0).Item("tableName").ToString.Trim
            Dim slTab As String = ""
            node = tv.Nodes.Add(tab)
            node.Tag = node.Text
            Dim polje As String = dtTP.Rows(0).Item("columnName").ToString.Trim
            node.Nodes.Add(polje)
            node.Nodes(node.Nodes.Count - 1).Tag =
            dtTP.Rows(0).Item("columnName").ToString.Trim &
            ";" & NZ(dtTP.Rows(0).Item("primaryKey")).ToString.Trim &
            ";" & NZ(dtTP.Rows(0).Item("columnType")).ToString.Trim &
            ";" & NZ(dtTP.Rows(0).Item("columnLenght")).ToString.Trim
            For i As Integer = 1 To dtTP.Rows.Count - 1
                slTab = dtTP.Rows(i).Item("tableName").ToString.Trim
                If tab <> slTab Then
                    tab = slTab
                    node = tv.Nodes.Add(slTab)
                    node.Tag = node.Text
                End If
                polje = dtTP.Rows(i).Item("columnName").ToString.Trim
                node.Nodes.Add(polje)
                node.Nodes(node.Nodes.Count - 1).Tag =
               dtTP.Rows(i).Item("columnName").ToString.Trim &
                ";" & dtTP.Rows(i).Item("primaryKey").ToString.Trim &
                ";" & dtTP.Rows(i).Item("columnType").ToString.Trim &
                ";" & dtTP.Rows(i).Item("columnLenght").ToString.Trim
            Next
            tv.Visible = True
        End If
    End Sub

    Sub dajCBODS(ByVal tabela As String)
        Dim DBConnectionString As String = getConnectionString(Me.txtServer.Text, Me.txtBaza.Text, "", Me.DBConnectionString)
        'Dim strTP As String = " use " + Me.txtBaza.Text +
        '            " SELECT SC.NAME AS displaymember,SC.NAME AS valuemember" +
        '            " FROM (select NAME,OBJECT_ID from SYS.TABLES union all select NAME + '_view' ,OBJECT_ID from SYS.VIEWS) AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
        '            " where ST.NAME='" + tabela + "'" +
        '            " order by 1"

        Dim strTP As String = " use " + Me.txtBaza.Text +
                    " SELECT SC.NAME AS displaymember,SC.NAME AS valuemember" +
                    " FROM (select NAME,OBJECT_ID from SYS.TABLES union all select NAME,OBJECT_ID from SYS.VIEWS) AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
                    " where ST.NAME='" + tabela + "'" +
                    " order by 1"

        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(strTP, DBConnectionString, Nothing)

        Call popunicboDT(cboDS1, dt)
        Call popunicboDT(cboDS2, dt)
    End Sub

    Dim fp As Boolean = False
    Dim polje As String

    Private Sub cboIST1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboIST1.SelectedIndexChanged
        polje = ""
        fp = False
        If Me.cboIST1.SelectedValue <> "" Then
            polje = cboIST1.SelectedValue.ToString.Trim
            Dim sql As String = "select polje,isnull(pp,'') as pp from vrepistpolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje =N'" + polje + "'"
            Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item("pp").ToString.Trim.ToUpper = "fp" Then fp = True
        End If
    End Sub

    Private Sub cbDA_CheckedChanged(sender As Object, e As EventArgs) Handles cbDA.CheckedChanged
        If cbDA.Checked = True Then
            p2.Visible = True
        Else
            p2.Visible = False
            txt2.Text = ""
            cboIST2.SelectedIndex = -1
            cboDS2.SelectedIndex = -1
        End If
    End Sub

    Dim textselectednode As String = ""

    Private Sub tv_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvBaza.NodeMouseClick
        textselectednode = ""
        Dim ClickPoint As Point = New Point(e.X, e.Y)
        Dim ClickNode As TreeNode = tvBaza.GetNodeAt(ClickPoint)
        If ClickNode Is Nothing Then Return

        tvBaza.SelectedNode = e.Node
        Dim mySelectedNode As TreeNode
        mySelectedNode = tvBaza.SelectedNode

        'Call tvNodeMouseDoubleClick(mySelectedNode)

        If e.Button = MouseButtons.Right Then
            If mySelectedNode.Parent Is Nothing Then
                'tabela
                a1.Visible = True
                a2.Visible = False
                a3.Visible = False
                a4.Visible = False
                a5.Visible = False
                a6.Visible = False
                Me.ToolStripSeparator1.Visible = False
                Me.ToolStripSeparator2.Visible = False
            Else
                'polje
                a1.Visible = False
                a2.Visible = True
                a3.Visible = True
                a4.Visible = True
                a5.Visible = True
                a6.Visible = True
                Me.ToolStripSeparator1.Visible = True
                Me.ToolStripSeparator2.Visible = True
            End If
            textselectednode = mySelectedNode.Text
        End If
    End Sub

    Private Sub mnu02_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnu02.ItemClicked
        Dim ci As ToolStripMenuItem = DirectCast(e.ClickedItem, ToolStripMenuItem)

        If ci.Name.Trim.ToUpper = "A1" Then   'DS
            txtDataSource.Text = textselectednode
            If textselectednode.Trim <> "" Then dajCBODS(textselectednode)

            Me.cbDA.Checked = False

        ElseIf ci.Name.Trim.ToUpper = "A2" Then   'select
            txtSelect.Text = Replace(txtSelect.Text, "*", "").Trim
            If txtSelect.Text = "" Then
                txtSelect.Text = textselectednode
            Else
                txtSelect.Text = txtSelect.Text + "," + textselectednode
            End If
        ElseIf ci.Name.Trim.ToUpper = "A3" Then  'where
            If txtWhere.Text = "" Then
                txtWhere.Text = "WHERE " + textselectednode
            Else
                txtWhere.Text = txtWhere.Text + " AND " + textselectednode
            End If

        End If

    End Sub

    Dim dodppolje As String = ""

    Private Sub btnMakeCB_Click(sender As Object, e As EventArgs) Handles btnCreateRel.Click
        Try
            If txtDataSource.Text.Trim = "" Then
                ISTMessageBox.Show("DataSource is empty!")
                txtDataSource.Focus()
                Exit Sub
            End If
            If txt1.Text.Trim = "" Then
                ISTMessageBox.Show("Connection is empty!")
                txt1.Focus()
                Exit Sub
            End If

            Dim dt As DataTable = Me.dgvRel.DataSource
            If Me.btnCreateRel.Text.Trim.ToUpper = "UPDATE" Then
            Else
                errN = dajUniqueImeISTLK(pp(0).Trim, "E", dodppolje)
            End If

            dodppolje = dodppolje + errN + ";"

            Dim rrel As String = "Relacija"
            If cbWebRel.Checked = True Then rrel = "WebRelacija"
            Dim err As String = ""

            If txtSelect.Text.Trim = "" Then txtSelect.Text = "*"

            If txtSelect.Text.Trim = "*" AndAlso txtWhere.Text.Trim = "" Then
                err = "#" + rrel + "{" + txtDataSource.Text.Trim + ";" + txt1.Text
            Else
                Dim wwhh As String = Replace(txtWhere.Text.Trim, "where", "", 1, , CompareMethod.Text)

                err = "#" + rrel + "{(select " + txtSelect.Text.Trim + " from " + txtDataSource.Text.Trim + " where " + wwhh + ");" + txt1.Text
            End If
            If txt2.Text <> "" Then
                err = err + ":" + txt2.Text + "}"
            Else
                err = err + "}"
            End If

            '#Relacija{ProizvodiC;god=god,sifra=sifpr}

            If Me.btnCreateRel.Text = "Update" Then

                Dim eRowIndex As Integer = CInt(Me.btnCreateRel.Tag)

                dgvRel.Item(9, eRowIndex).Value = "Update"
                dgvRel.Item(8, eRowIndex).Value = "2099/1/1"
                dgvRel.Item(7, eRowIndex).Value = "2020/1/1"
                dgvRel.Item(6, eRowIndex).Value = False
                dgvRel.Item(5, eRowIndex).Value = "Relation"
                dgvRel.Item(4, eRowIndex).Value = "T"
                dgvRel.Item(3, eRowIndex).Value = err
                dgvRel.Item(2, eRowIndex).Value = errN
                dgvRel.Item(1, eRowIndex).Value = pp(0).Trim
                dgvRel.Item(0, eRowIndex).Value = sifist

                Me.btnCreateRel.Text = "Add Relacija"
                Me.btnCreateRel.Tag = "-1"
            Else
                dt.Rows.Add(sifist, pp(0).Trim, errN, err, "T", "Relation", False, "2020/1/1", "2030/1/1", "Insert")
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

    End Sub

    Function dajUniqueImeISTLK(ByVal tabela As String, ByVal errname As String, ByVal dodpolje As String) As String
        Dim sql As String = ""
        dajUniqueImeISTLK = errname + "1"
        For i As Integer = 1 To 100000
            If dodpolje = "" OrElse dodpolje.IndexOf(errname + CStr(i).Trim + ";") < 0 Then
                sql = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tabela + "'   and  COLUMN_NAME='" + errname + CStr(i).Trim + "'"
                Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
                If dt Is Nothing OrElse dt.Rows.Count = 0 Then
                    dajUniqueImeISTLK = errname + CStr(i).Trim
                    sql = "SELECT rbrGreske FROM ISTLK where sifist=N'" + sifist + "' and tabela=N'" + tabela + "' and rbrGreske='" + dajUniqueImeISTLK + "'"
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

    ''Function dajUniqueImeISTLK1(ByVal tabela As String, ByVal errname As String, ByVal dodpolje As String) As String
    ''    Dim sql As String = ""
    ''    dajUniqueImeISTLK1 = errname + "1"
    ''    For i As Integer = 1 To 100000
    ''        If dodpolje = "" OrElse dodpolje.IndexOf(errname + CStr(i).Trim + ";") < 0 Then
    ''            sql = "SELECT rbrGreske FROM ISTLK where sifist=N'" + sifist + "' and tabela=N'" + tabela + "' and rbrGreske='" + errname + CStr(i).Trim + "'"
    ''            Dim dtI As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
    ''            If dtI Is Nothing OrElse dtI.Rows.Count = 0 Then
    ''                'sve ok
    ''                Exit For
    ''            Else
    ''                'teraj dalje
    ''            End If
    ''        End If
    ''    Next
    ''End Function
    Private Sub cbG_CheckedChanged(sender As Object, e As EventArgs) Handles cbG.CheckedChanged
        txtWhere.Text = txtWhere.Text.Replace(" and god={GGG}", "")
        If cbG.Checked = True Then
            cbYY.Checked = False
            If txtWhere.Text.Trim = "" Then
                txtWhere.Text = "WHERE god={GGG}"
            Else
                txtWhere.Text = txtWhere.Text + " AND god={GGG}"
            End If

        End If
    End Sub

    Private Sub cbYY_CheckedChanged(sender As Object, e As EventArgs) Handles cbYY.CheckedChanged
        txtWhere.Text = txtWhere.Text.Replace(" and ISTYear={YYY}", "")
        If cbYY.Checked = True Then
            cbG.Checked = False
            If txtWhere.Text.Trim = "" Then
                txtWhere.Text = "WHERE ISTYear={YYY}"
            Else
                txtWhere.Text = txtWhere.Text + " AND ISTYear={YYY}"
            End If
        End If
    End Sub

    Private Sub cbM_CheckedChanged(sender As Object, e As EventArgs) Handles cbM.CheckedChanged
        txtWhere.Text = txtWhere.Text.Replace(" and mes={MMM}", "")
        If cbM.Checked = True Then
            cbMM.Checked = False
            If txtWhere.Text.Trim = "" Then
                txtWhere.Text = "WHERE mes={MMM}"
            Else
                txtWhere.Text = txtWhere.Text + " AND mes={MMM}"
            End If
        End If
    End Sub

    Private Sub cbMM_CheckedChanged(sender As Object, e As EventArgs) Handles cbMM.CheckedChanged
        txtWhere.Text = txtWhere.Text.Replace(" and ISTMonth={MMM}", "")
        If cbMM.Checked = True Then
            cbM.Checked = False
            If txtWhere.Text.Trim = "" Then
                txtWhere.Text = "WHERE ISTMonth={MMM}"
            Else
                txtWhere.Text = txtWhere.Text + " AND ISTMonth={MMM}"
            End If
        End If
    End Sub

    Private Sub bntAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Dim pIST As String = ""
        Dim pDS As String = ""
        If Me.cboIST1.SelectedValue <> "" AndAlso Me.cboDS1.SelectedValue <> "" Then
            pIST = cboIST1.SelectedValue.ToString.Trim
            pDS = cboDS1.SelectedValue.ToString.Trim
            If txt1.Text.Trim = "" Then
                txt1.Text = pIST + "=" + pDS
            Else
                txt1.Text = txt1.Text.Trim + "," + pIST + "=" + pDS
            End If
        End If
    End Sub

    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Dim pIST As String = ""
        Dim pDS As String = ""
        If Me.cboIST2.SelectedValue <> "" AndAlso Me.cboDS2.SelectedValue <> "" Then
            pIST = cboIST2.SelectedValue.ToString.Trim
            pDS = cboDS2.SelectedValue.ToString.Trim
            If txt2.Text.Trim = "" Then
                txt2.Text = pIST + "=" + pDS
            Else
                txt2.Text = txt2.Text.Trim + "," + pIST + "=" + pDS
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call cclear()
    End Sub

    Sub cclear()
        Me.txtSelect.Text = "*"
        Me.txtDataSource.Text = ""
        Me.txtWhere.Text = ""
        Me.txt1.Text = ""
        Me.cbDA.Checked = False
        Me.btnCreateRel.Text = "Add Relacija"
        Me.btnCreateRel.Tag = "-1"
        p2.Visible = False
        txt2.Text = ""
        cboIST1.SelectedIndex = -1
        cboDS1.SelectedIndex = -1
        cboIST2.SelectedIndex = -1
        cboDS2.SelectedIndex = -1
    End Sub

    Private Sub btnCaNCEL_Click(sender As Object, e As EventArgs) Handles btnCaNCEL.Click
        Call cclear()

        Call ResetDataGridView(dgvRel)

        Call dajDGV()
    End Sub

    Private Sub ResetDataGridView(ByVal dgv As DataGridView)
        dgv.CancelEdit()
        dgv.Columns.Clear()
        dgv.DataSource = Nothing
    End Sub

End Class