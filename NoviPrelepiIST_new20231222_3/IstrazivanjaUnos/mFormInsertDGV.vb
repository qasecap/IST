'Option Strict Off

Imports System.Web

Public Class mFormInsertDGV
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
    Friend WithEvents TabControlDGV As TabControl
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents cboGS As ComboBox
    Friend WithEvents txtGSW As TextBox
    Friend WithEvents txtGTitle As TextBox
    Friend WithEvents txtGFS As TextBox
    Friend WithEvents txtGWidth As TextBox
    Friend WithEvents txtGLocationX As TextBox
    Friend WithEvents txtGHeight As TextBox
    Friend WithEvents txtGLocationY As TextBox
    Friend WithEvents lblGLocationX As Label
    Friend WithEvents lblGLocationY As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label62 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents txtGColHHght As TextBox
    Friend WithEvents txtGRHW As TextBox
    Friend WithEvents txtGHRFS As TextBox
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents dgvGridStop As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents Label66 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents txtGridEditText As TextBox
    Friend WithEvents txtGridOpenText As TextBox
    Friend WithEvents txtGridDeleteText As TextBox
    Friend WithEvents txtGridDeleteWidth As TextBox
    Friend WithEvents txtGridOpenWidth As TextBox
    Friend WithEvents txtGridEditWidth As TextBox
    Friend WithEvents cboGOpen As ComboBox
    Friend WithEvents chbGEdit As CheckBox
    Friend WithEvents chbGridOpen As CheckBox
    Friend WithEvents chbGridDelete As CheckBox
    Friend WithEvents TabPage8 As TabPage
    Friend WithEvents dgvGridColumn As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage9 As TabPage
    Friend WithEvents dgvGridAddCol As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.TabControlDGV = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cboGS = New System.Windows.Forms.ComboBox()
        Me.txtGSW = New System.Windows.Forms.TextBox()
        Me.txtGTitle = New System.Windows.Forms.TextBox()
        Me.txtGFS = New System.Windows.Forms.TextBox()
        Me.txtGWidth = New System.Windows.Forms.TextBox()
        Me.txtGLocationX = New System.Windows.Forms.TextBox()
        Me.txtGHeight = New System.Windows.Forms.TextBox()
        Me.txtGLocationY = New System.Windows.Forms.TextBox()
        Me.lblGLocationX = New System.Windows.Forms.Label()
        Me.lblGLocationY = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtGColHHght = New System.Windows.Forms.TextBox()
        Me.txtGRHW = New System.Windows.Forms.TextBox()
        Me.txtGHRFS = New System.Windows.Forms.TextBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.dgvGridStop = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtGridEditText = New System.Windows.Forms.TextBox()
        Me.txtGridOpenText = New System.Windows.Forms.TextBox()
        Me.txtGridDeleteText = New System.Windows.Forms.TextBox()
        Me.txtGridDeleteWidth = New System.Windows.Forms.TextBox()
        Me.txtGridOpenWidth = New System.Windows.Forms.TextBox()
        Me.txtGridEditWidth = New System.Windows.Forms.TextBox()
        Me.cboGOpen = New System.Windows.Forms.ComboBox()
        Me.chbGEdit = New System.Windows.Forms.CheckBox()
        Me.chbGridOpen = New System.Windows.Forms.CheckBox()
        Me.chbGridDelete = New System.Windows.Forms.CheckBox()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.dgvGridColumn = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.dgvGridAddCol = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlDGV.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.dgvGridStop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        CType(Me.dgvGridColumn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        CType(Me.dgvGridAddCol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btn
        '
        Me.Btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Btn.Location = New System.Drawing.Point(536, 3)
        Me.Btn.Name = "Btn"
        Me.Btn.Size = New System.Drawing.Size(95, 24)
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
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Insert DataGridView"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.Btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 570)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(656, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(656, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'TabControlDGV
        '
        Me.TabControlDGV.Controls.Add(Me.TabPage4)
        Me.TabControlDGV.Controls.Add(Me.TabPage5)
        Me.TabControlDGV.Controls.Add(Me.TabPage6)
        Me.TabControlDGV.Controls.Add(Me.TabPage7)
        Me.TabControlDGV.Controls.Add(Me.TabPage8)
        Me.TabControlDGV.Controls.Add(Me.TabPage9)
        Me.TabControlDGV.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlDGV.Location = New System.Drawing.Point(12, 31)
        Me.TabControlDGV.Name = "TabControlDGV"
        Me.TabControlDGV.SelectedIndex = 0
        Me.TabControlDGV.Size = New System.Drawing.Size(623, 536)
        Me.TabControlDGV.TabIndex = 222
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label55)
        Me.TabPage4.Controls.Add(Me.Label56)
        Me.TabPage4.Controls.Add(Me.Label57)
        Me.TabPage4.Controls.Add(Me.Label58)
        Me.TabPage4.Controls.Add(Me.Label59)
        Me.TabPage4.Controls.Add(Me.Label60)
        Me.TabPage4.Controls.Add(Me.Label61)
        Me.TabPage4.Controls.Add(Me.cboGS)
        Me.TabPage4.Controls.Add(Me.txtGSW)
        Me.TabPage4.Controls.Add(Me.txtGTitle)
        Me.TabPage4.Controls.Add(Me.txtGFS)
        Me.TabPage4.Controls.Add(Me.txtGWidth)
        Me.TabPage4.Controls.Add(Me.txtGLocationX)
        Me.TabPage4.Controls.Add(Me.txtGHeight)
        Me.TabPage4.Controls.Add(Me.txtGLocationY)
        Me.TabPage4.Controls.Add(Me.lblGLocationX)
        Me.TabPage4.Controls.Add(Me.lblGLocationY)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(615, 510)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Grid specifications"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(17, 143)
        Me.Label55.Name = "Label55"
        Me.Label55.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label55.Size = New System.Drawing.Size(100, 15)
        Me.Label55.TabIndex = 266
        Me.Label55.Text = "Font size"
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(17, 55)
        Me.Label56.Name = "Label56"
        Me.Label56.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label56.Size = New System.Drawing.Size(100, 15)
        Me.Label56.TabIndex = 265
        Me.Label56.Text = "Title"
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(17, 121)
        Me.Label57.Name = "Label57"
        Me.Label57.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label57.Size = New System.Drawing.Size(100, 15)
        Me.Label57.TabIndex = 264
        Me.Label57.Text = "Width"
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(17, 99)
        Me.Label58.Name = "Label58"
        Me.Label58.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label58.Size = New System.Drawing.Size(100, 15)
        Me.Label58.TabIndex = 263
        Me.Label58.Text = "Height"
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(6, 77)
        Me.Label59.Name = "Label59"
        Me.Label59.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label59.Size = New System.Drawing.Size(100, 15)
        Me.Label59.TabIndex = 262
        Me.Label59.Text = "Location"
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(17, 33)
        Me.Label60.Name = "Label60"
        Me.Label60.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label60.Size = New System.Drawing.Size(100, 15)
        Me.Label60.TabIndex = 261
        Me.Label60.Text = "Condition"
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(17, 11)
        Me.Label61.Name = "Label61"
        Me.Label61.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label61.Size = New System.Drawing.Size(100, 15)
        Me.Label61.TabIndex = 260
        Me.Label61.Text = "Source"
        '
        'cboGS
        '
        Me.cboGS.AccessibleName = ""
        Me.cboGS.DropDownWidth = 413
        Me.cboGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboGS.FormattingEnabled = True
        Me.cboGS.Location = New System.Drawing.Point(123, 11)
        Me.cboGS.Name = "cboGS"
        Me.cboGS.Size = New System.Drawing.Size(413, 21)
        Me.cboGS.TabIndex = 151
        '
        'txtGSW
        '
        Me.txtGSW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGSW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGSW.Location = New System.Drawing.Point(123, 33)
        Me.txtGSW.Name = "txtGSW"
        Me.txtGSW.Size = New System.Drawing.Size(413, 21)
        Me.txtGSW.TabIndex = 153
        '
        'txtGTitle
        '
        Me.txtGTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGTitle.Location = New System.Drawing.Point(123, 55)
        Me.txtGTitle.Name = "txtGTitle"
        Me.txtGTitle.Size = New System.Drawing.Size(413, 21)
        Me.txtGTitle.TabIndex = 155
        '
        'txtGFS
        '
        Me.txtGFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGFS.Location = New System.Drawing.Point(123, 143)
        Me.txtGFS.Name = "txtGFS"
        Me.txtGFS.Size = New System.Drawing.Size(137, 21)
        Me.txtGFS.TabIndex = 166
        '
        'txtGWidth
        '
        Me.txtGWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGWidth.Location = New System.Drawing.Point(123, 121)
        Me.txtGWidth.Name = "txtGWidth"
        Me.txtGWidth.Size = New System.Drawing.Size(137, 21)
        Me.txtGWidth.TabIndex = 164
        '
        'txtGLocationX
        '
        Me.txtGLocationX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGLocationX.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGLocationX.Location = New System.Drawing.Point(123, 77)
        Me.txtGLocationX.Name = "txtGLocationX"
        Me.txtGLocationX.Size = New System.Drawing.Size(54, 21)
        Me.txtGLocationX.TabIndex = 158
        '
        'txtGHeight
        '
        Me.txtGHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGHeight.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGHeight.Location = New System.Drawing.Point(123, 99)
        Me.txtGHeight.Name = "txtGHeight"
        Me.txtGHeight.Size = New System.Drawing.Size(137, 21)
        Me.txtGHeight.TabIndex = 163
        '
        'txtGLocationY
        '
        Me.txtGLocationY.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGLocationY.Location = New System.Drawing.Point(206, 77)
        Me.txtGLocationY.Name = "txtGLocationY"
        Me.txtGLocationY.Size = New System.Drawing.Size(54, 21)
        Me.txtGLocationY.TabIndex = 160
        '
        'lblGLocationX
        '
        Me.lblGLocationX.AutoSize = True
        Me.lblGLocationX.Location = New System.Drawing.Point(103, 77)
        Me.lblGLocationX.Name = "lblGLocationX"
        Me.lblGLocationX.Size = New System.Drawing.Size(15, 13)
        Me.lblGLocationX.TabIndex = 157
        Me.lblGLocationX.Text = "X"
        '
        'lblGLocationY
        '
        Me.lblGLocationY.AutoSize = True
        Me.lblGLocationY.Location = New System.Drawing.Point(191, 77)
        Me.lblGLocationY.Name = "lblGLocationY"
        Me.lblGLocationY.Size = New System.Drawing.Size(14, 13)
        Me.lblGLocationY.TabIndex = 159
        Me.lblGLocationY.Text = "Y"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label62)
        Me.TabPage5.Controls.Add(Me.Label64)
        Me.TabPage5.Controls.Add(Me.Label65)
        Me.TabPage5.Controls.Add(Me.txtGColHHght)
        Me.TabPage5.Controls.Add(Me.txtGRHW)
        Me.TabPage5.Controls.Add(Me.txtGHRFS)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(615, 510)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Header"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(16, 63)
        Me.Label62.Name = "Label62"
        Me.Label62.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label62.Size = New System.Drawing.Size(144, 15)
        Me.Label62.TabIndex = 268
        Me.Label62.Text = "Header height"
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(16, 39)
        Me.Label64.Name = "Label64"
        Me.Label64.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label64.Size = New System.Drawing.Size(144, 15)
        Me.Label64.TabIndex = 267
        Me.Label64.Text = "Header font size"
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(16, 15)
        Me.Label65.Name = "Label65"
        Me.Label65.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label65.Size = New System.Drawing.Size(144, 15)
        Me.Label65.TabIndex = 266
        Me.Label65.Text = "Row header width"
        '
        'txtGColHHght
        '
        Me.txtGColHHght.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGColHHght.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGColHHght.Location = New System.Drawing.Point(169, 60)
        Me.txtGColHHght.Name = "txtGColHHght"
        Me.txtGColHHght.Size = New System.Drawing.Size(137, 21)
        Me.txtGColHHght.TabIndex = 172
        '
        'txtGRHW
        '
        Me.txtGRHW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGRHW.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGRHW.Location = New System.Drawing.Point(169, 16)
        Me.txtGRHW.Name = "txtGRHW"
        Me.txtGRHW.Size = New System.Drawing.Size(137, 21)
        Me.txtGRHW.TabIndex = 168
        '
        'txtGHRFS
        '
        Me.txtGHRFS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGHRFS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGHRFS.Location = New System.Drawing.Point(169, 38)
        Me.txtGHRFS.Name = "txtGHRFS"
        Me.txtGHRFS.Size = New System.Drawing.Size(137, 21)
        Me.txtGHRFS.TabIndex = 170
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.dgvGridStop)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(615, 510)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Stop"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'dgvGridStop
        '
        Me.dgvGridStop.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGridStop.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGridStop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridStop.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5})
        Me.dgvGridStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGridStop.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvGridStop.Location = New System.Drawing.Point(3, 3)
        Me.dgvGridStop.Name = "dgvGridStop"
        Me.dgvGridStop.Size = New System.Drawing.Size(609, 504)
        Me.dgvGridStop.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.HeaderText = "Grid link stop if"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 250
        '
        'Column5
        '
        Me.Column5.HeaderText = "Message"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 250
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.Label66)
        Me.TabPage7.Controls.Add(Me.Label67)
        Me.TabPage7.Controls.Add(Me.txtGridEditText)
        Me.TabPage7.Controls.Add(Me.txtGridOpenText)
        Me.TabPage7.Controls.Add(Me.txtGridDeleteText)
        Me.TabPage7.Controls.Add(Me.txtGridDeleteWidth)
        Me.TabPage7.Controls.Add(Me.txtGridOpenWidth)
        Me.TabPage7.Controls.Add(Me.txtGridEditWidth)
        Me.TabPage7.Controls.Add(Me.cboGOpen)
        Me.TabPage7.Controls.Add(Me.chbGEdit)
        Me.TabPage7.Controls.Add(Me.chbGridOpen)
        Me.TabPage7.Controls.Add(Me.chbGridDelete)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(615, 510)
        Me.TabPage7.TabIndex = 3
        Me.TabPage7.Text = "Link action"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(314, 5)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(151, 13)
        Me.Label66.TabIndex = 176
        Me.Label66.Text = "**Specify text for screen"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(492, 5)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(39, 13)
        Me.Label67.TabIndex = 175
        Me.Label67.Text = "Width"
        '
        'txtGridEditText
        '
        Me.txtGridEditText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGridEditText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridEditText.Location = New System.Drawing.Point(314, 26)
        Me.txtGridEditText.Name = "txtGridEditText"
        Me.txtGridEditText.Size = New System.Drawing.Size(177, 21)
        Me.txtGridEditText.TabIndex = 174
        '
        'txtGridOpenText
        '
        Me.txtGridOpenText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGridOpenText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridOpenText.Location = New System.Drawing.Point(314, 48)
        Me.txtGridOpenText.Name = "txtGridOpenText"
        Me.txtGridOpenText.Size = New System.Drawing.Size(177, 21)
        Me.txtGridOpenText.TabIndex = 173
        '
        'txtGridDeleteText
        '
        Me.txtGridDeleteText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGridDeleteText.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridDeleteText.Location = New System.Drawing.Point(314, 70)
        Me.txtGridDeleteText.Name = "txtGridDeleteText"
        Me.txtGridDeleteText.Size = New System.Drawing.Size(177, 21)
        Me.txtGridDeleteText.TabIndex = 172
        '
        'txtGridDeleteWidth
        '
        Me.txtGridDeleteWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGridDeleteWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridDeleteWidth.Location = New System.Drawing.Point(492, 70)
        Me.txtGridDeleteWidth.Name = "txtGridDeleteWidth"
        Me.txtGridDeleteWidth.Size = New System.Drawing.Size(62, 21)
        Me.txtGridDeleteWidth.TabIndex = 171
        '
        'txtGridOpenWidth
        '
        Me.txtGridOpenWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGridOpenWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridOpenWidth.Location = New System.Drawing.Point(492, 48)
        Me.txtGridOpenWidth.Name = "txtGridOpenWidth"
        Me.txtGridOpenWidth.Size = New System.Drawing.Size(62, 21)
        Me.txtGridOpenWidth.TabIndex = 170
        '
        'txtGridEditWidth
        '
        Me.txtGridEditWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGridEditWidth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGridEditWidth.Location = New System.Drawing.Point(492, 26)
        Me.txtGridEditWidth.Name = "txtGridEditWidth"
        Me.txtGridEditWidth.Size = New System.Drawing.Size(62, 21)
        Me.txtGridEditWidth.TabIndex = 169
        '
        'cboGOpen
        '
        Me.cboGOpen.DropDownWidth = 250
        Me.cboGOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboGOpen.FormattingEnabled = True
        Me.cboGOpen.Location = New System.Drawing.Point(97, 48)
        Me.cboGOpen.Name = "cboGOpen"
        Me.cboGOpen.Size = New System.Drawing.Size(216, 21)
        Me.cboGOpen.TabIndex = 168
        '
        'chbGEdit
        '
        Me.chbGEdit.AccessibleName = ""
        Me.chbGEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbGEdit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGEdit.Location = New System.Drawing.Point(6, 26)
        Me.chbGEdit.Name = "chbGEdit"
        Me.chbGEdit.Size = New System.Drawing.Size(104, 19)
        Me.chbGEdit.TabIndex = 167
        Me.chbGEdit.Text = "Edit"
        '
        'chbGridOpen
        '
        Me.chbGridOpen.AccessibleName = ""
        Me.chbGridOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbGridOpen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGridOpen.Location = New System.Drawing.Point(6, 48)
        Me.chbGridOpen.Name = "chbGridOpen"
        Me.chbGridOpen.Size = New System.Drawing.Size(104, 19)
        Me.chbGridOpen.TabIndex = 166
        Me.chbGridOpen.Text = "Open table"
        '
        'chbGridDelete
        '
        Me.chbGridDelete.AccessibleName = ""
        Me.chbGridDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbGridDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGridDelete.Location = New System.Drawing.Point(6, 70)
        Me.chbGridDelete.Name = "chbGridDelete"
        Me.chbGridDelete.Size = New System.Drawing.Size(104, 19)
        Me.chbGridDelete.TabIndex = 165
        Me.chbGridDelete.Text = "Delete"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.dgvGridColumn)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(615, 510)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "Columns in grid"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'dgvGridColumn
        '
        Me.dgvGridColumn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGridColumn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGridColumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridColumn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column8})
        Me.dgvGridColumn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGridColumn.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvGridColumn.Location = New System.Drawing.Point(3, 3)
        Me.dgvGridColumn.Name = "dgvGridColumn"
        Me.dgvGridColumn.Size = New System.Drawing.Size(609, 504)
        Me.dgvGridColumn.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.HeaderText = "Screen name=Database Column name"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 350
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column width"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 90
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.dgvGridAddCol)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(615, 510)
        Me.TabPage9.TabIndex = 5
        Me.TabPage9.Text = "Add column"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'dgvGridAddCol
        '
        Me.dgvGridAddCol.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvGridAddCol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGridAddCol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGridAddCol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column17})
        Me.dgvGridAddCol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGridAddCol.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvGridAddCol.Location = New System.Drawing.Point(3, 3)
        Me.dgvGridAddCol.Name = "dgvGridAddCol"
        Me.dgvGridAddCol.Size = New System.Drawing.Size(609, 504)
        Me.dgvGridAddCol.TabIndex = 0
        '
        'Column9
        '
        Me.Column9.HeaderText = "Screen name=Database Column name"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 300
        '
        'Column17
        '
        Me.Column17.HeaderText = "Column widht"
        Me.Column17.Name = "Column17"
        '
        'mFormInsertDGV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(656, 600)
        Me.Controls.Add(Me.TabControlDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormInsertDGV"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Insert DataGridView"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlDGV.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.dgvGridStop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.dgvGridColumn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        CType(Me.dgvGridAddCol, System.ComponentModel.ISupportInitialize).EndInit()
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
        With Me
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.gde = gde
        Me.what = what
        Me.dIst = dIst

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        If Me.AccessibleDescription = "fp" Then IST = True Else ISTDB = True

        Dim strSQl As String = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" +
                                sifist + "' and isnull(typeOfTableParentChild,'') not in ('K','S','A') order by 1"
        Call popunicbo(cboGS, strSQl, Me.ISTConnectionString)

        strSQl = "select distinct TableName as displaymember,TableName as valuemember from _ISTTables where appcode=N'" +
                                sifist + "' and isnull(typeOfTableParentChild,'')='D' and parentTableName=N'" +
                                pp(0).Trim + "'" + " order by 1"

        Call popunicbo(cboGOpen, strSQl, Me.ISTConnectionString)

        Dim dt As System.Data.DataTable = getDTC()
        If dt.Rows.Count = 1 Then
            Call getVariablesC(dt)
            Try
                getMetaDataPaneP1()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If

        If Me.what.Trim.ToUpper = "FORMAT" Then
            Me.Label1.Text = "DataGridView format"
            Me.Btn.Text = "Format"
        Else   'INSERT
            Me.Label1.Text = "DataGridView insert"
            Me.Btn.Text = "Insert"
        End If

    End Sub

    Dim columnAtributes As String = ""

    Function getDTC() As System.Data.DataTable
        columnAtributes = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select formatdgv as izraz" +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "' and pp='dgv'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        columnAtributes = dt.Rows(0).Item("izraz").ToString.Trim
    End Sub

    Function minRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
        Dim str As String = "select top 1 rbr from vrepISTPolja where sifist=N'" + sifist + "' and tabela=N'" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' order by cast(rbr as int)"
        minRBRTabela = getrbr(str)
    End Function

    Function maxRBRTabela(ByVal currenttab As Integer, ByVal tabela As String) As String
        Dim str As String = "select top 1 rbr from vrepISTPolja where sifist=N'" + sifist + "' and tabela=N'" + tabela + "' and ltrim(rtrim(forma)) like '" + CStr(currenttab).Trim + ".%' order by cast(rbr as int) desc"
        maxRBRTabela = getrbr(str)
    End Function

    Function dajUniqueImeIST(ByVal tabela As String, ByVal cname As String) As String
        Dim sql As String = ""
        dajUniqueImeIST = cname + "1"
        For i As Integer = 1 To 100000
            sql = "SELECT polje FROM istpolja where sifist=N'" + sifist + "' and tabela=N'" + tabela + "' and polje=N'" + cname + CStr(i).Trim + "'"
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

    Private Sub Btn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn.Click
        If Me.what.Trim.ToUpper = "FORMAT" Then
            Call bFormat()
        Else   'INSERT
            Call bInsert()
        End If
    End Sub

    Sub bFormat()
        Dim rbr As String = pp(4).Trim
        Dim polje As String = pp(2).Trim

        Dim sqlIST As String = ""
        Dim p2 As String = ""
        Dim popis As String = "$"
        Dim pizraz As String = setMetaDataPaneP1()
        Dim pvs As String = ""
        sqlIST = sqlIST + "update istpolja " + nvrd +
                      " set izraz=N'" + pizraz + "'" +
                      " where sifist =N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr ='" + rbr + "' and polje=N'" + polje + "';"


        p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST)

        If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to IST!") Else Me.Close()
    End Sub

    Sub bInsert()
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim sqlIST As String = ""
        Dim ppolje As String = dajUniqueImeIST(pp(0).Trim, "DGV_")
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
        sqlIST = " update istpolja Set rbr=rbr+10 where sifist ='" + sifist + "' and tabela='" + pp(0).Trim +
                    "' and rbr>=" + rrbr.Trim + ";" + nvrd
        Dim popis As String = "$"
        Dim pizraz As String = setMetaDataPaneP1()
        Dim pvs As String = ""
        sqlIST = sqlIST + "insert into istpolja (sifist,tabela,polje,vod,vdo,rbr,opis,izraz,vs)" + nvrd +
                      " select sifist,tabela,N'" + ppolje + "' as polje,vod,vdo,'" + rrbr.Trim + "' as rbr,N'" + popis + "',N'" + pizraz + "',''" + pvs + "" +
                      " from istpolja " +
                      " where sifist =N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and rbr ='" + pomrbr + "'"

        p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST)

        If p2 = "nok" Then ISTMessageBox.Show("Error. Not added to IST!") Else Me.Close()

    End Sub

    Sub getMetaDataPaneP1()

        'izrazZADGV
        If columnAtributes Is Nothing OrElse columnAtributes.Trim = "" Then Exit Sub

        Dim ddgv As Boolean = False
        Dim sselect As Boolean = False

        Dim rowheader As String = ""
        Dim gridlinkstopif() As String = {}
        Dim gridlinkstopifmsg() As String = {}
        Dim gridaddcolumn() As String = {}
        'Dim gridaddcolumnname() As String = {}
        Dim gridcolumns() As String = {}
        Dim gridwidth() As String = {}
        Dim gridlinkaction() As String = {}
        Dim gridlinktext() As String = {}
        Dim gridlinkwidth() As String = {}

        Dim pp() As String = columnAtributes.Split(";")

        Dim dgpp() As String = columnAtributes.Split(";")
        For i As Integer = 0 To dgpp.GetUpperBound(0)
            If dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDSOURCE") = 0 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDSOURCEWHERE") < 0 Then
                Dim gs As String = Replace(dgpp(i).Trim, "gridsource=", "", 1, , CompareMethod.Text).Trim
                cboGS.SelectedValue = gs
            ElseIf dgpp(i).Length > 14 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDSOURCEWHERE") = 0 Then
                Dim gsw As String = Replace(dgpp(i).Trim, "gridsourcewhere=", "", 1, , CompareMethod.Text).Trim
                txtGSW.Text = gsw
            ElseIf dgpp(i).Length > 8 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDTITLE") = 0 Then
                Dim gt As String = Replace(dgpp(i).Trim, "gridtitle=", "", 1, , CompareMethod.Text).Trim
                txtGTitle.Text = gt
            ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDHEIGHT") = 0 Then
                Dim gh As String = Replace(dgpp(i).Trim, "gridheight=", "", 1, , CompareMethod.Text).Trim
                txtGHeight.Text = gh
            ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDWIDTH") = 0 Then
                Dim gw As String = Replace(dgpp(i).Trim, "gridwidth=", "", 1, , CompareMethod.Text).Trim
                txtGWidth.Text = gw
            ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDFONTSIZE") = 0 Then
                Dim gfs As String = Replace(dgpp(i).Trim, "gridfontsize=", "", 1, , CompareMethod.Text).Trim
                txtGFS.Text = gfs
            ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLOCATION") = 0 Then
                Dim gl As String = Replace(dgpp(i).Trim, "gridlocation", "", 1, , CompareMethod.Text).Trim
                Dim gll As String = gl.Replace("(", "").Replace(")", "")
                Dim dgl() As String = gll.Split(",")
                Dim xx As String = ""
                Dim yy As String = ""
                If dgl.Length > 1 Then
                    Dim xloc() As String = dgl(0).Split("=")
                    Dim yloc() As String = dgl(1).Split("=")
                    xx = xloc(1)
                    yy = yloc(1)
                End If
                txtGLocationX.Visible = True
                txtGLocationY.Visible = True
                txtGLocationX.Text = xx
                txtGLocationY.Text = yy
            ElseIf dgpp(i).Length > 13 AndAlso dgpp(i).Trim.ToUpper.IndexOf("ROWHEADERSWIDTH") = 0 Then
                Dim rhw As String = Replace(dgpp(i).Trim, "rowheaderswidth=", "", 1, , CompareMethod.Text).Trim
                txtGRHW.Text = rhw
            ElseIf dgpp(i).Length > 9 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDHEADERROWFONTSIZE") = 0 Then
                Dim hfs As String = Replace(dgpp(i).Trim, "gridheaderrowfontsize=", "", 1, , CompareMethod.Text).Trim
                txtGHRFS.Text = hfs
            ElseIf dgpp(i).Length > 17 AndAlso dgpp(i).Trim.ToUpper.IndexOf("COLUMNHEADERSHEIGHT") = 0 Then
                Dim chh As String = Replace(dgpp(i).Trim, "columnheadersheight=", "", 1, , CompareMethod.Text).Trim
                txtGColHHght.Text = chh
            ElseIf dgpp(i).Length > 11 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKACTION") = 0 Then
                gridlinkaction = Replace(dgpp(i).Trim, "gridlinkaction=", "", 1, , CompareMethod.Text).Trim.Split("$")
            ElseIf dgpp(i).Length > 11 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKTEXT") = 0 Then
                gridlinktext = Replace(dgpp(i).Trim, "gridlinktext=", "", 1, , CompareMethod.Text).Trim.Split("$")
            ElseIf dgpp(i).Length > 11 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKWIDTH") = 0 Then
                gridlinkwidth = Replace(dgpp(i).Trim, "gridlinkwidth=", "", 1, , CompareMethod.Text).Trim.Split("$")
            ElseIf dgpp(i).Length > 13 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKSTOPIF") >= 0 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKSTOPIFMSG") < 0 Then
                gridlinkstopif = Replace(dgpp(i).Trim, "gridlinkstopif=", "", 1, , CompareMethod.Text).Trim.Split("$")
            ElseIf dgpp(i).Length > 15 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDLINKSTOPIFMSG") >= 0 Then
                gridlinkstopifmsg = Replace(dgpp(i).Trim, "gridlinkstopifmsg=", "", 1, , CompareMethod.Text).Trim.Split("$")
            ElseIf dgpp(i).Length > 10 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDCOLUMNS") >= 0 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDCOLUMNSWIDTH") < 0 Then
                gridcolumns = Replace(dgpp(i).Trim, "gridcolumns=", "", 1, , CompareMethod.Text).Trim.Split(",")
            ElseIf dgpp(i).Length > 12 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDADDCOLUMN") >= 0 Then
                gridaddcolumn = Replace(dgpp(i).Trim, "gridaddcolumn=", "", 1, , CompareMethod.Text).Trim.Split(",")
            ElseIf dgpp(i).Length > 15 AndAlso dgpp(i).Trim.ToUpper.IndexOf("GRIDCOLUMNSWIDTH") >= 0 Then
                gridwidth = Replace(dgpp(i).Trim, "gridcolumnswidth=", "", 1, , CompareMethod.Text).Trim.Split(",")
            End If
        Next

        If Not gridlinkaction Is Nothing AndAlso gridlinkaction.Length > 0 Then
            For j As Integer = 0 To gridlinkaction.GetUpperBound(0)
                Dim gla As String = gridlinkaction(j).Trim
                If gla.Length > 3 AndAlso gla.ToUpper.IndexOf("EDIT") >= 0 Then
                    Dim le As String = Replace(gla.Trim, "edit=", "", 1, , CompareMethod.Text).Trim
                    chbGEdit.Checked = True
                    If Not gridlinktext Is Nothing Then txtGridEditText.Text = gridlinktext(j)
                    If Not gridlinkwidth Is Nothing Then txtGridEditWidth.Text = gridlinkwidth(j)
                ElseIf gla.Length > 4 AndAlso gla.ToUpper.IndexOf("OPEN=") >= 0 Then
                    chbGridOpen.Checked = True
                    cboGOpen.SelectedValue = Replace(gla.Trim, "open=", "", 1, , CompareMethod.Text).Trim
                    If Not gridlinktext Is Nothing Then txtGridOpenText.Text = gridlinktext(j)
                    If Not gridlinkwidth Is Nothing Then txtGridOpenWidth.Text = gridlinkwidth(j)
                ElseIf gla.Length > 6 AndAlso gla.ToUpper.IndexOf("DELETE=") >= 0 Then
                    Dim ld As String = Replace(gla.Trim, "delete=", "", 1, , CompareMethod.Text).Trim
                    txtGridDeleteText.Text = ld
                    chbGridDelete.Checked = True
                    If Not gridlinktext Is Nothing Then txtGridDeleteText.Text = gridlinktext(j)
                    If Not gridlinkwidth Is Nothing Then txtGridDeleteWidth.Text = gridlinkwidth(j)
                End If
            Next
        End If

        dopuni(gridlinkstopif, gridlinkstopifmsg)
        dgvGridStop.Rows.Clear()
        For i As Integer = 0 To gridlinkstopifmsg.GetUpperBound(0)
            If gridlinkstopif(i) = "" Then gridlinkstopif(i) = "2=2"
            dgvGridStop.Rows.Add(New String() {gridlinkstopif(i), gridlinkstopifmsg(i)})
        Next

        dgvGridColumn.Rows.Clear()
        For i As Integer = 0 To gridcolumns.GetUpperBound(0)
            dgvGridColumn.Rows.Add(New String() {gridcolumns(i), gridwidth(i)})
        Next

        dgvGridAddCol.Rows.Clear()
        'Dim ttt As Integer = gridwidth.Length - gridcolumn.Length
        For i As Integer = 0 To gridaddcolumn.GetUpperBound(0)
            dgvGridAddCol.Rows.Add(New String() {gridaddcolumn(i), gridwidth(gridcolumns.GetUpperBound(0) + i + 1)})
        Next

    End Sub

    Sub dopuni(ByRef iif() As String, ByVal onn() As String)
        Dim iifLength As Integer = iif.Length
        If iif.Length < onn.Length Then
            For ii As Integer = 0 To onn.Length - iifLength - 1
                ReDim Preserve iif(ii)
                iif(ii) = "2=2"
            Next
        End If
    End Sub

    Dim pomgridwidth As String

    Function setMetaDataPaneP1() As String
        'izraz
        Dim pom As String = "DataGridView;" + nvrd
        If txtGTitle.Text <> "" Then pom = pom + "GridTitle=" + txtGTitle.Text + ";" + nvrd
        If txtGLocationX.Text <> "" AndAlso txtGLocationY.Text <> "" Then pom = pom + "GridLocation(X=" + txtGLocationX.Text + ",Y=" + txtGLocationY.Text + ");" + nvrd
        If cboGS.SelectedValue <> "" Then pom = pom + "GridSource=" + cboGS.SelectedValue + ";" + nvrd
        If txtGSW.Text <> "" Then pom = pom + "GridSourceWhere=" + txtGSW.Text + ";" + nvrd
        If txtGHeight.Text <> "" Then pom = pom + "GridHeight=" + txtGHeight.Text + ";" + nvrd
        If txtGWidth.Text <> "" Then pom = pom + "GridWidth=" + txtGWidth.Text + ";" + nvrd
        If txtGFS.Text <> "" Then pom = pom + "GridFontSize=" + txtGFS.Text + ";" + nvrd
        If txtGRHW.Text <> "" Then pom = pom + "RowHeadersWidth=" + txtGRHW.Text + ";" + nvrd
        If txtGHRFS.Text <> "" Then pom = pom + "GridHeaderRowFontSize=" + txtGHRFS.Text + ";" + nvrd
        If txtGColHHght.Text <> "" Then pom = pom + "ColumnHeadersHeight=" + txtGColHHght.Text + ";" + nvrd

        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Edit$Open=" + cboGOpen.SelectedValue + "&Delete;" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkAction=Edit$Open=" + cboGOpen.SelectedValue + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Edit$Delete;" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Open=" + cboGOpen.SelectedValue + "$Delete;" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkAction=Edit;" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkAction=Open=" + cboGOpen.SelectedValue + ";" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkAction=Delete;" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridEditText.Text + "&" + txtGridOpenText.Text + "$" + txtGridDeleteText.Text + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkText=" + txtGridEditText.Text + "&" + txtGridOpenText.Text + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridEditText.Text + "&" + txtGridDeleteText.Text + ";" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridOpenText.Text + "$" + txtGridDeleteText.Text + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkText=" + txtGridEditText.Text + ";" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkText=" + txtGridOpenText.Text + ";" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkText=" + txtGridDeleteText.Text + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + "&" + txtGridOpenWidth.Text + "$" + txtGridDeleteWidth.Text + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + "&" + txtGridOpenWidth.Text + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + "&" + txtGridDeleteWidth.Text + ";" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridOpenWidth.Text + "$" + txtGridDeleteWidth.Text + ";" + nvrd
        If chbGEdit.Checked = True AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkWidth=" + txtGridEditWidth.Text + ";" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = True AndAlso chbGridDelete.Checked = False Then pom = pom + "GridLinkWidth=" + txtGridOpenWidth.Text + ";" + nvrd
        If chbGEdit.Checked = False AndAlso chbGridOpen.Checked = False AndAlso chbGridDelete.Checked = True Then pom = pom + "GridLinkWidth=" + txtGridDeleteWidth.Text + ";" + nvrd

        Dim gridlinkstopif As String = "" : Dim gridlinkstopifmsg As String = ""
        pom = pom + setGridStop(gridlinkstopif, gridlinkstopifmsg, dgvGridStop, "GridLinkStopif", "GridLinkStopIfMsg") + nvrd
        Dim gridcolumns As String = "" : Dim gridwidth As String = "" : pomgridwidth = ""
        pom = pom + setGridCol(gridcolumns, gridwidth, dgvGridColumn, "GridColumns", "GridColumnsWidth") + nvrd
        Dim gridaddcolumn As String = "" : Dim ggridwidth As String = ""
        Dim ppom As String = setGridAddCol(gridaddcolumn, gridwidth + ggridwidth, dgvGridAddCol, pomgridwidth, "GridAddColumn", "GridColumnsWidth")
        If ppom <> "" Then
            pom = pom + nvrd + ppom
        Else
            pom = pom + nvrd + "GridColumnsWidth=" + pomgridwidth + ";"
        End If
        Return pom
    End Function

    Function setGridStop(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String) As String
        's1 je uvek sa IF (ako postoji IF)
        setGridStop = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + "$"
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + "$"
            If s2 <> "" AndAlso s1 = "" Then s1 = "2=2$"
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "$" : s1 = s1.Replace("$$", "")
            setGridStop = setGridStop + ss1 + "=" + s1 + ";"
            s2 = s2 + "$" : s2 = s2.Replace("$$", "")
            setGridStop = setGridStop + ss2 + "=" + s2 + ";"
        End If
        Return setGridStop
    End Function

    Function setGridCol(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal ss1 As String, ByVal ss2 As String) As String

        setGridCol = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + ","
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + ","
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "," : s1 = s1.Replace(",,", "")
            setGridCol = setGridCol + ss1 + "=" + s1 + ";"
            s2 = s2 + "," : s2 = s2.Replace(",,", "")
            'setGridCol = setGridCol + ss2 + "=" + s2 + ";"
            pomgridwidth = s2

        End If
        Return setGridCol
    End Function

    Function setGridAddCol(ByVal s1 As String, ByVal s2 As String, ByVal dgv As DataGridView, ByVal pomgridwidth As String, ByVal ss1 As String, ByVal ss2 As String) As String

        setGridAddCol = ""
        For i As Integer = 0 To dgv.Rows.Count - 1
            If Not dgv.Rows(i).Cells(1).Value Is Nothing AndAlso dgv.Rows(i).Cells(1).Value.ToString.Trim <> "" Then s2 = s2 + dgv.Rows(i).Cells(1).Value.ToString.Trim + ","
            If Not dgv.Rows(i).Cells(0).Value Is Nothing AndAlso dgv.Rows(i).Cells(0).Value.ToString.Trim <> "" Then s1 = s1 + dgv.Rows(i).Cells(0).Value.ToString.Trim + ","
        Next
        If s2 <> "" AndAlso s1 <> "" Then
            s1 = s1 + "," : s1 = s1.Replace(",,", "")
            setGridAddCol = setGridAddCol + ss1 + "=" + s1 + ";"
            s2 = s2 + "," : s2 = s2.Replace(",,", "")
            pomgridwidth = pomgridwidth.TrimEnd(";")
            pomgridwidth = pomgridwidth + "," + s2

            setGridAddCol = setGridAddCol + ss2 + "=" + pomgridwidth + ";"

        End If
        Return setGridAddCol
    End Function

End Class