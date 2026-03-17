'Option Strict Off

Imports System.Web

Public Class mFormFormatConvertCB
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
    Friend WithEvents mnu02 As ContextMenuStrip
    Friend WithEvents a1 As ToolStripMenuItem
    Friend WithEvents a4 As ToolStripMenuItem
    Friend WithEvents a5 As ToolStripMenuItem
    Friend WithEvents a6 As ToolStripMenuItem
    Friend WithEvents a2 As ToolStripMenuItem
    Friend WithEvents a3 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents txtServer As TextBox
    Friend WithEvents cbYY As CheckBox
    Friend WithEvents cbMM As CheckBox
    Friend WithEvents cbUU As CheckBox
    Friend WithEvents cbG As CheckBox
    Friend WithEvents cbM As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbU As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVS As TextBox
    Friend WithEvents pFilter As Panel
    Friend WithEvents cboIST As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lF As Label
    Friend WithEvents txtfF As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbFilter As CheckBox
    Friend WithEvents txtWhere As TextBox
    Friend WithEvents btnMakeCB As Button
    Friend WithEvents cbCWO As CheckBox
    Friend WithEvents txtCB As TextBox
    Friend WithEvents lDS As Label
    Friend WithEvents txtSelect As TextBox
    Friend WithEvents txtfVM As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtfDM As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lVM As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lDM As Label
    Friend WithEvents txtConnString As TextBox
    Friend WithEvents txtDataSource As TextBox
    Friend WithEvents tvBaza As TreeView
    Friend WithEvents llSB As LinkLabel
    Friend WithEvents txtBaza As TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.mnu02 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.a1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.a4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.a5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.a6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.cbYY = New System.Windows.Forms.CheckBox()
        Me.cbMM = New System.Windows.Forms.CheckBox()
        Me.cbUU = New System.Windows.Forms.CheckBox()
        Me.cbG = New System.Windows.Forms.CheckBox()
        Me.cbM = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbU = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVS = New System.Windows.Forms.TextBox()
        Me.pFilter = New System.Windows.Forms.Panel()
        Me.cboIST = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lF = New System.Windows.Forms.Label()
        Me.txtfF = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbFilter = New System.Windows.Forms.CheckBox()
        Me.txtWhere = New System.Windows.Forms.TextBox()
        Me.btnMakeCB = New System.Windows.Forms.Button()
        Me.cbCWO = New System.Windows.Forms.CheckBox()
        Me.txtCB = New System.Windows.Forms.TextBox()
        Me.lDS = New System.Windows.Forms.Label()
        Me.txtSelect = New System.Windows.Forms.TextBox()
        Me.txtfVM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtfDM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lVM = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lDM = New System.Windows.Forms.Label()
        Me.txtConnString = New System.Windows.Forms.TextBox()
        Me.txtDataSource = New System.Windows.Forms.TextBox()
        Me.tvBaza = New System.Windows.Forms.TreeView()
        Me.llSB = New System.Windows.Forms.LinkLabel()
        Me.txtBaza = New System.Windows.Forms.TextBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu02.SuspendLayout()
        Me.pFilter.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(504, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(307, 23)
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
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Insert ComboBox"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 491)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(819, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
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
        'txtServer
        '
        Me.txtServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServer.Enabled = False
        Me.txtServer.Location = New System.Drawing.Point(12, 58)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(232, 22)
        Me.txtServer.TabIndex = 309
        '
        'cbYY
        '
        Me.cbYY.AccessibleName = ""
        Me.cbYY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbYY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYY.Location = New System.Drawing.Point(340, 228)
        Me.cbYY.Name = "cbYY"
        Me.cbYY.Size = New System.Drawing.Size(158, 20)
        Me.cbYY.TabIndex = 315
        Me.cbYY.Text = "and ISTYear={YYY}"
        '
        'cbMM
        '
        Me.cbMM.AccessibleName = ""
        Me.cbMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMM.Location = New System.Drawing.Point(340, 246)
        Me.cbMM.Name = "cbMM"
        Me.cbMM.Size = New System.Drawing.Size(158, 20)
        Me.cbMM.TabIndex = 316
        Me.cbMM.Text = "and ISTMonth={MMM}"
        '
        'cbUU
        '
        Me.cbUU.AccessibleName = ""
        Me.cbUU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUU.Location = New System.Drawing.Point(340, 264)
        Me.cbUU.Name = "cbUU"
        Me.cbUU.Size = New System.Drawing.Size(158, 20)
        Me.cbUU.TabIndex = 317
        Me.cbUU.Text = "and ISTUser"
        '
        'cbG
        '
        Me.cbG.AccessibleName = ""
        Me.cbG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbG.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbG.Location = New System.Drawing.Point(340, 173)
        Me.cbG.Name = "cbG"
        Me.cbG.Size = New System.Drawing.Size(138, 20)
        Me.cbG.TabIndex = 324
        Me.cbG.Text = "and god={GGG}"
        '
        'cbM
        '
        Me.cbM.AccessibleName = ""
        Me.cbM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbM.Location = New System.Drawing.Point(340, 191)
        Me.cbM.Name = "cbM"
        Me.cbM.Size = New System.Drawing.Size(138, 20)
        Me.cbM.TabIndex = 325
        Me.cbM.Text = "and mes={MMM}"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(504, 309)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(168, 18)
        Me.Label9.TabIndex = 328
        Me.Label9.Text = "Syntax for ComboBox"
        '
        'cbU
        '
        Me.cbU.AccessibleName = ""
        Me.cbU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbU.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbU.Location = New System.Drawing.Point(340, 209)
        Me.cbU.Name = "cbU"
        Me.cbU.Size = New System.Drawing.Size(138, 20)
        Me.cbU.TabIndex = 326
        Me.cbU.Text = "and ISTuser=''"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(504, 433)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 18)
        Me.Label8.TabIndex = 327
        Me.Label8.Text = "Apperance"
        '
        'txtVS
        '
        Me.txtVS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtVS.Location = New System.Drawing.Point(547, 454)
        Me.txtVS.Name = "txtVS"
        Me.txtVS.Size = New System.Drawing.Size(125, 20)
        Me.txtVS.TabIndex = 299
        '
        'pFilter
        '
        Me.pFilter.Controls.Add(Me.cboIST)
        Me.pFilter.Controls.Add(Me.Label4)
        Me.pFilter.Controls.Add(Me.Label3)
        Me.pFilter.Controls.Add(Me.lF)
        Me.pFilter.Controls.Add(Me.txtfF)
        Me.pFilter.Location = New System.Drawing.Point(15, 315)
        Me.pFilter.Name = "pFilter"
        Me.pFilter.Size = New System.Drawing.Size(433, 61)
        Me.pFilter.TabIndex = 323
        Me.pFilter.Visible = False
        '
        'cboIST
        '
        Me.cboIST.DropDownWidth = 450
        Me.cboIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboIST.FormattingEnabled = True
        Me.cboIST.Location = New System.Drawing.Point(170, 31)
        Me.cboIST.Name = "cboIST"
        Me.cboIST.Size = New System.Drawing.Size(253, 22)
        Me.cboIST.TabIndex = 268
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 267
        Me.Label4.Text = "=D."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(170, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 266
        Me.Label3.Text = "Screen field (from IST)"
        '
        'lF
        '
        Me.lF.AutoSize = True
        Me.lF.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lF.Location = New System.Drawing.Point(6, 8)
        Me.lF.Name = "lF"
        Me.lF.Size = New System.Drawing.Size(35, 13)
        Me.lF.TabIndex = 264
        Me.lF.Text = "Filter"
        '
        'txtfF
        '
        Me.txtfF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfF.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtfF.Location = New System.Drawing.Point(6, 31)
        Me.txtfF.Name = "txtfF"
        Me.txtfF.Size = New System.Drawing.Size(126, 20)
        Me.txtfF.TabIndex = 265
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 457)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 298
        Me.Label2.Text = "Width"
        '
        'cbFilter
        '
        Me.cbFilter.AccessibleName = ""
        Me.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFilter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFilter.Location = New System.Drawing.Point(15, 286)
        Me.cbFilter.Name = "cbFilter"
        Me.cbFilter.Size = New System.Drawing.Size(71, 20)
        Me.cbFilter.TabIndex = 322
        Me.cbFilter.Text = "Filter"
        '
        'txtWhere
        '
        Me.txtWhere.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWhere.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtWhere.Location = New System.Drawing.Point(12, 175)
        Me.txtWhere.Multiline = True
        Me.txtWhere.Name = "txtWhere"
        Me.txtWhere.Size = New System.Drawing.Size(321, 59)
        Me.txtWhere.TabIndex = 303
        '
        'btnMakeCB
        '
        Me.btnMakeCB.BackColor = System.Drawing.SystemColors.Control
        Me.btnMakeCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMakeCB.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnMakeCB.Location = New System.Drawing.Point(188, 382)
        Me.btnMakeCB.Name = "btnMakeCB"
        Me.btnMakeCB.Size = New System.Drawing.Size(260, 38)
        Me.btnMakeCB.TabIndex = 321
        Me.btnMakeCB.TabStop = False
        Me.btnMakeCB.Text = "Create syntax for ComboBox"
        Me.btnMakeCB.UseVisualStyleBackColor = False
        '
        'cbCWO
        '
        Me.cbCWO.AccessibleName = ""
        Me.cbCWO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCWO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCWO.Location = New System.Drawing.Point(514, 388)
        Me.cbCWO.Name = "cbCWO"
        Me.cbCWO.Size = New System.Drawing.Size(291, 40)
        Me.cbCWO.TabIndex = 306
        Me.cbCWO.Text = "For web - generate combobox instead of autocomplete list"
        '
        'txtCB
        '
        Me.txtCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCB.Enabled = False
        Me.txtCB.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCB.Location = New System.Drawing.Point(504, 330)
        Me.txtCB.Multiline = True
        Me.txtCB.Name = "txtCB"
        Me.txtCB.Size = New System.Drawing.Size(307, 53)
        Me.txtCB.TabIndex = 320
        '
        'lDS
        '
        Me.lDS.AutoSize = True
        Me.lDS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDS.Location = New System.Drawing.Point(246, 108)
        Me.lDS.Name = "lDS"
        Me.lDS.Size = New System.Drawing.Size(125, 13)
        Me.lDS.TabIndex = 300
        Me.lDS.Text = "Data source  (from )"
        '
        'txtSelect
        '
        Me.txtSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelect.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSelect.Location = New System.Drawing.Point(12, 127)
        Me.txtSelect.Multiline = True
        Me.txtSelect.Name = "txtSelect"
        Me.txtSelect.Size = New System.Drawing.Size(232, 22)
        Me.txtSelect.TabIndex = 319
        Me.txtSelect.Text = "*"
        '
        'txtfVM
        '
        Me.txtfVM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfVM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtfVM.Location = New System.Drawing.Point(119, 262)
        Me.txtfVM.Name = "txtfVM"
        Me.txtfVM.Size = New System.Drawing.Size(125, 20)
        Me.txtfVM.TabIndex = 305
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 13)
        Me.Label7.TabIndex = 318
        Me.Label7.Text = "Select clause  (select )"
        '
        'txtfDM
        '
        Me.txtfDM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfDM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtfDM.Location = New System.Drawing.Point(119, 240)
        Me.txtfDM.Name = "txtfDM"
        Me.txtfDM.Size = New System.Drawing.Size(125, 20)
        Me.txtfDM.TabIndex = 304
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(411, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 314
        '
        'lVM
        '
        Me.lVM.AutoSize = True
        Me.lVM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lVM.Location = New System.Drawing.Point(12, 262)
        Me.lVM.Name = "lVM"
        Me.lVM.Size = New System.Drawing.Size(90, 13)
        Me.lVM.TabIndex = 302
        Me.lVM.Text = "Value member"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 313
        Me.Label5.Text = "Where clause  (where )"
        '
        'lDM
        '
        Me.lDM.AutoSize = True
        Me.lDM.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDM.Location = New System.Drawing.Point(12, 240)
        Me.lDM.Name = "lDM"
        Me.lDM.Size = New System.Drawing.Size(101, 13)
        Me.lDM.TabIndex = 301
        Me.lDM.Text = "Display member"
        '
        'txtConnString
        '
        Me.txtConnString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConnString.Enabled = False
        Me.txtConnString.Location = New System.Drawing.Point(460, 37)
        Me.txtConnString.Multiline = True
        Me.txtConnString.Name = "txtConnString"
        Me.txtConnString.Size = New System.Drawing.Size(38, 28)
        Me.txtConnString.TabIndex = 312
        Me.txtConnString.Visible = False
        '
        'txtDataSource
        '
        Me.txtDataSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDataSource.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtDataSource.Location = New System.Drawing.Point(246, 127)
        Me.txtDataSource.Multiline = True
        Me.txtDataSource.Name = "txtDataSource"
        Me.txtDataSource.Size = New System.Drawing.Size(232, 22)
        Me.txtDataSource.TabIndex = 307
        '
        'tvBaza
        '
        Me.tvBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvBaza.CheckBoxes = True
        Me.tvBaza.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvBaza.ItemHeight = 16
        Me.tvBaza.Location = New System.Drawing.Point(504, 37)
        Me.tvBaza.Name = "tvBaza"
        Me.tvBaza.Size = New System.Drawing.Size(307, 269)
        Me.tvBaza.TabIndex = 311
        Me.tvBaza.Visible = False
        '
        'llSB
        '
        Me.llSB.AutoSize = True
        Me.llSB.Location = New System.Drawing.Point(12, 41)
        Me.llSB.Name = "llSB"
        Me.llSB.Size = New System.Drawing.Size(197, 14)
        Me.llSB.TabIndex = 308
        Me.llSB.TabStop = True
        Me.llSB.Text = "Select server and database ..."
        '
        'txtBaza
        '
        Me.txtBaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBaza.Enabled = False
        Me.txtBaza.Location = New System.Drawing.Point(12, 80)
        Me.txtBaza.Name = "txtBaza"
        Me.txtBaza.Size = New System.Drawing.Size(232, 22)
        Me.txtBaza.TabIndex = 310
        '
        'mFormFormatConvertCB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(819, 521)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtVS)
        Me.Controls.Add(Me.pFilter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbFilter)
        Me.Controls.Add(Me.txtWhere)
        Me.Controls.Add(Me.btnMakeCB)
        Me.Controls.Add(Me.cbCWO)
        Me.Controls.Add(Me.txtCB)
        Me.Controls.Add(Me.lDS)
        Me.Controls.Add(Me.txtSelect)
        Me.Controls.Add(Me.txtfVM)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtfDM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lVM)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lDM)
        Me.Controls.Add(Me.txtConnString)
        Me.Controls.Add(Me.txtDataSource)
        Me.Controls.Add(Me.tvBaza)
        Me.Controls.Add(Me.llSB)
        Me.Controls.Add(Me.txtBaza)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.Controls.Add(Me.cbYY)
        Me.Controls.Add(Me.cbMM)
        Me.Controls.Add(Me.cbUU)
        Me.Controls.Add(Me.cbG)
        Me.Controls.Add(Me.cbM)
        Me.Controls.Add(Me.cbU)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormFormatConvertCB"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert "
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu02.ResumeLayout(False)
        Me.pFilter.ResumeLayout(False)
        Me.pFilter.PerformLayout()
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
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String)
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

        tvBaza.ContextMenuStrip = mnu02
        'DBConnectionString  "Data Source=IMT2.STATSRB.LAN;Initial Catalog=DEPOPROJEKTANTI;Integrated Security=SSPI;Persist Security Info=False"	String
        Call getServerBazaNew(Me.DBConnectionString)

        Call DajTabelePolja2(tvBaza, Me.txtServer.Text, Me.txtBaza.Text)
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        If Me.AccessibleDescription = "fp" Then IST = True Else ISTDB = True
        Dim strSQl As String = "select polje as displaymember,polje as valuemember from ISTPolja where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' order by polje"
        Call popunicbo(cboIST, strSQl, Me.ISTConnectionString)
        Me.BtnFormat.Text = Me.what
        Me.Text = Me.what

        If Me.what.Trim.ToUpper = "CONVERT" Then
            Me.Label1.Text = Me.what + " to ComboBox"
        ElseIf Me.what.Trim.ToUpper = "FORMAT" Then
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    getMetaDataPaneP1()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
            Me.Label1.Text = Me.what + " ComboBox"
        End If
    End Sub

    Dim columnAtributes As String = ""
    Dim vs As String = ""

    Function getDTC() As System.Data.DataTable
        columnAtributes = ""
        vs = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select izraz,vs" +
                " from vrepISTPolja " +
                " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "' and pp='cb'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        columnAtributes = dt.Rows(0).Item("izraz").ToString.Trim
        vs = dt.Rows(0).Item("vs").ToString.Trim
    End Sub

    Function getrbr(ByVal sqlrbr As String) As String
        Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
        If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 Then
            getrbr = dt1.Rows(0).Item("rbr").ToString
        Else
            getrbr = "0"
        End If
    End Function

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        If txtCB.Text.Trim = "" Then
            ISTMessageBox.Show("Syntax for ComboBox is empty!Did you press and release button Make ComboBox?")
            Me.btnMakeCB.Focus()
            Exit Sub
        End If
        Call fformatConvert()
    End Sub

    Sub fformatConvert()
        Dim sqlIST As String = ""
        Dim ppolje As String = pp(2).Trim
        Dim rrbr As String = pp(4).Trim
        Dim trk() As String = pp(3).Split(".")
        Dim p2 As String = ""

        Dim pizraz As String = setMetaDataPaneP1()
        Dim pvs As String = ""
        If txtVS.Text.Trim <> "" Then pvs = txtVS.Text.Trim

        If pizraz <> "" Then
            sqlIST = "update istpolja set" + nvrd +
                " izraz='" + pizraz + "', vs='" + pvs + "'" +
                " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "' and rbr ='" + pp(4).Trim + "'"


            p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST)

            If p2 = "nok" Then ISTMessageBox.Show("Error!") Else Me.Close()
        End If
    End Sub

    Sub getMetaDataPaneP1()

        'izraz i do autocomplete
        If columnAtributes Is Nothing OrElse columnAtributes.Trim = "" Then Exit Sub
        If vs.Trim <> "" Then Me.txtVS.Text = vs
        'Dim ccbo As Boolean = False
        'Dim sselect As Boolean = False
        Dim combo As String = ""
        Dim comboweb As String = ""
        cbCWO.Checked = False
        Me.txtCB.Text = columnAtributes.Trim
        If columnAtributes.Length > 2 AndAlso columnAtributes.Trim.ToUpper.IndexOf("CBW") = 0 Then cbCWO.Checked = True
        Dim cb As String = ""
        If cbCWO.Checked = True Then
            cb = columnAtributes.Trim.ToUpper.Replace("CBW{", "")
        Else
            cb = columnAtributes.Trim.ToUpper.Replace("CBO{", "")
        End If
        If cb.Substring(cb.Length - 1, 1) = "}" Then cb = cb.Substring(0, cb.Length - 1)

        Dim pp() As String = cb.Split(";")

        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("IZVOR") = 0 OrElse pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DATASOURCE") = 0 Then
                Dim ds As String = pp(i).Trim.ToUpper.Replace("DATASOURCE=", "").Replace("IZVOR=", "")
                'Select * From ffff Where dddd

                Dim bbb() As String = razkvantaj(ds)
                Dim s As Integer = -1 : Dim f As Integer = -1 : Dim w As Integer = -1
                For ll As Integer = 0 To bbb.GetUpperBound(0)
                    If bbb(ll).Trim.ToUpper = "SELECT" Then
                        s = ll
                    ElseIf bbb(ll).Trim.ToUpper = "FROM" Then
                        f = ll
                    ElseIf bbb(ll).Trim.ToUpper = "WHERE" Then
                        w = ll
                    End If
                Next
                Dim pom As String = ""
                Dim kr As Integer = w - 1

                If s > -1 AndAlso f > -1 Then
                    For ll As Integer = s + 1 To f - 1
                        pom = pom + bbb(ll) + ","
                    Next
                    pom = pom.TrimEnd(",")
                    pom = pom.Replace(",,", ",")
                    Me.txtSelect.Text = pom

                    pom = ""
                    Dim m() As String = bbb(f + 1).Split(".")
                    If m.Length = 3 Then
                        For k As Integer = 0 To m.GetUpperBound(0)
                            If m(1).Trim.ToUpper = "DBO" Then
                                Me.txtDataSource.Text = m(2).Replace("[", "").Replace("]", "")
                            Else
                                Me.txtDataSource.Text = m(1) + "." + m(2)
                            End If
                        Next
                    Else
                        Me.txtDataSource.Text = bbb(f + 1)
                    End If

                    If w > -1 Then
                        pom = ""
                        For ll As Integer = w + 1 To bbb.GetUpperBound(0)
                            pom = pom + bbb(ll) + ","
                        Next
                        Me.txtWhere.Text = pom
                    End If

                End If

                If s = -1 Then
                    Me.txtSelect.Text = "*"
                    Me.txtDataSource.Text = ds
                    Me.txtWhere.Text = ""
                End If

                If txtWhere.Text.Trim.ToUpper.IndexOf("GOD={GGG}") >= 0 Then
                    cbG.Checked = True : cbYY.Checked = False
                End If
                If txtWhere.Text.Trim.ToUpper.IndexOf("MES={MMM}") >= 0 Then
                    cbM.Checked = True : cbMM.Checked = False
                End If
                If txtWhere.Text.Trim.ToUpper.IndexOf("ISTYEAR={YYY}") >= 0 Then
                    cbYY.Checked = True : cbG.Checked = False
                End If
                If txtWhere.Text.Trim.ToUpper.IndexOf("ISTMONTH={MMM}") >= 0 Then
                    cbMM.Checked = True : cbM.Checked = False
                End If
                'If txtWhere.Text.Trim.ToUpper.IndexOf("GGG") >= 0 Then
                'End If
                'If txtWhere.Text.Trim.ToUpper.IndexOf("GGG") >= 0 Then
                'End If

            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("DISPLAYMEMBER") = 0 OrElse pp(i).Length > 6 AndAlso pp(i).Trim.ToUpper.IndexOf("PRIKAZI") = 0 Then
                Dim dm As String = pp(i).Trim.ToUpper.Replace("DISPLAYMEMBER", "").Replace("PRIKAZI", "").Replace("=", "")
                txtfDM.Text = dm
            ElseIf pp(i).Length > 9 AndAlso pp(i).Trim.ToUpper.IndexOf("VALUEMEMBER") = 0 OrElse pp(i).Length > 4 AndAlso pp(i).Trim.ToUpper.IndexOf("UBAZU") = 0 Then
                Dim vm As String = pp(i).Trim.ToUpper.Replace("VALUEMEMBER", "").Replace("UBAZU", "").Replace("=", "")
                txtfVM.Text = vm
            ElseIf pp(i).Length > 5 AndAlso pp(i).Trim.ToUpper.IndexOf("FILTER") = 0 Then
                Dim ff As String = pp(i).Trim.ToUpper.Replace("FILTER=", "")
                Dim fff() As String = ff.Split("=")
                txtfF.Text = fff(0)
                cboIST.SelectedValue = fff(1).Replace("D.", "").Replace("#FP{", "").Replace("}", "")
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
        'izraz
        Dim pom As String = Me.txtCB.Text
        Return pom
    End Function

    Private Sub llSB_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Call llDB()
    End Sub

    Sub llDB()
        Dim pomn As String = OleDbConnString.EditConnectionString(Me, "")
        Me.txtConnString.Text = pomn.Replace("Provider=SQLOLEDB.1;", "")
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
                    " SELECT ST.NAME AS tableName, SC.NAME AS columnName," +
                    " CASE WHEN SC.colid= SKC.column_id THEN 'P' ELSE '' END AS primaryKey," +
                    " STY.NAME AS columnType, SC.prec  AS columnLenght" +
                    " FROM (select NAME,OBJECT_ID from SYS.TABLES union all select NAME + '_view' ,OBJECT_ID from SYS.VIEWS) AS ST INNER JOIN SYS.SYSCOLUMNS AS SC on SC.ID = ST.OBJECT_ID  " +
                    " left JOIN SYS.TYPES AS STY ON SC.xusertype  = STY.USER_TYPE_ID" +
                    " left JOIN SYS.INDEX_COLUMNS AS SKC" +
                    " ON SKC.OBJECT_ID = ST.OBJECT_ID AND SKC.column_id =SC.colid order by 1"
        Dim dtTP As New DataTable
        dtTP = izvrsiSQLvratiDT(strTP, DBConnectionString, Nothing)
        'ako su tabele u ISTu, uzeti samo one cija sva polja nisu u ISTu

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

    Dim fp As Boolean = False
    Dim polje As String

    Private Sub cboIST_SelectedIndexChanged(sender As Object, e As EventArgs)
        polje = ""
        fp = False
        If Me.cboIST.SelectedValue <> "" Then
            polje = cboIST.SelectedValue.ToString.Trim
            Dim sql As String = "select polje,isnull(pp,'') as pp from vrepistpolja where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje ='" + polje + "'"
            Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 AndAlso dt.Rows(0).Item("pp").ToString.Trim.ToUpper = "fp" Then fp = True
        End If
    End Sub

    Private Sub cbFilter_CheckedChanged(sender As Object, e As EventArgs) Handles cbFilter.CheckedChanged
        If cbFilter.Checked = True Then
            pFilter.Visible = True
        Else
            pFilter.Visible = False
            txtfF.Text = ""
            cboIST.SelectedIndex = -1
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
        ElseIf ci.Name.Trim.ToUpper = "A4" Then   'display
            txtfDM.Text = textselectednode
        ElseIf ci.Name.Trim.ToUpper = "A5" Then  'value
            txtfVM.Text = textselectednode
        ElseIf ci.Name.Trim.ToUpper = "A6" Then   'filter
            txtfF.Text = textselectednode
        End If

    End Sub

    Dim pref As String = "CBO"

    Private Sub btnMakeCB_Click(sender As Object, e As EventArgs) Handles btnMakeCB.Click

        If txtDataSource.Text.Trim = "" Then
            ISTMessageBox.Show("DataSource is empty!")
            txtDataSource.Focus()
            Exit Sub
        ElseIf txtfDM.Text.Trim = "" Then
            ISTMessageBox.Show("Display member is empty!")
            txtfDM.Focus()
            Exit Sub
        ElseIf txtfVM.Text.Trim = "" Then
            ISTMessageBox.Show("Value member is empty!")
            txtfVM.Focus()
            Exit Sub
        End If

        Dim ds As String = "CBO{"
        Dim it As String = ""
        If txtDataSource.Text.IndexOf(".") > 0 Then
            it = txtDataSource.Text
        Else
            it = "dbo.[" + txtDataSource.Text.Trim + "]"
        End If
        Dim ss As String = "datasource=select " + txtSelect.Text + " from [" + txtBaza.Text + "]." + it + ";"
        Dim ff As String = ""
        If polje <> "" AndAlso fp = False Then
            ff = "FILTER=" + Me.txtfF.Text + "=d." + polje + ";"
        ElseIf polje <> "" AndAlso fp = True Then
            ff = "FILTER=" + Me.txtfF.Text.Trim + "=#FP{" + polje.Trim + "};"
        End If

        Dim dm As String = "displaymember=" + Me.txtfDM.Text + ";"
        Dim vm As String = "valuemember=" + Me.txtfVM.Text + ""
        Me.txtCB.Text = pref + "{" + ss + ff + dm + vm + "}"

        Me.BtnFormat.Visible = True
        'CBO{datasource=SELECT distinct NameBashk,CodeBashk,KodiQark FROM AdminDivision;
        '        Filter = KodiQark = d.EntPrefecture;
        'displaymember = NameBashk;
        'valuemember = CodeBashk}
    End Sub

    Private Sub cbCWO_CheckedChanged(sender As Object, e As EventArgs)
        If cbCWO.Checked = True Then
            pref = "CBW"
            If Me.txtCB.Text.IndexOf("CBO") = 0 Then Me.txtCB.Text = pref + Me.txtCB.Text.Substring(3)
        Else
            pref = "CBO"
            If Me.txtCB.Text.IndexOf("CBW") = 0 Then Me.txtCB.Text = pref + Me.txtCB.Text.Substring(3)
        End If
    End Sub

    Private Sub cbG_CheckedChanged(sender As Object, e As EventArgs)
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

    Private Sub cbYY_CheckedChanged(sender As Object, e As EventArgs)
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

    Private Sub cbM_CheckedChanged(sender As Object, e As EventArgs)
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

    Private Sub cbMM_CheckedChanged(sender As Object, e As EventArgs)
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

End Class