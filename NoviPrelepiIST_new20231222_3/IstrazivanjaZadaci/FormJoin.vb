Option Strict Off

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormJoin
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
    Friend WithEvents BtnJoin As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboT11 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents cboJ1 As ComboBox
    Friend WithEvents cboT12 As ComboBox
    Friend WithEvents cboK11 As ComboBox
    Friend WithEvents cboK12 As ComboBox
    Friend WithEvents cboK22 As ComboBox
    Friend WithEvents cboK21 As ComboBox
    Friend WithEvents cboK32 As ComboBox
    Friend WithEvents cboK31 As ComboBox
    Friend WithEvents cboK42 As ComboBox
    Friend WithEvents cboK41 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboK52 As ComboBox
    Friend WithEvents cboK51 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboK62 As ComboBox
    Friend WithEvents cboK61 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboK72 As ComboBox
    Friend WithEvents cboK71 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboK82 As ComboBox
    Friend WithEvents cboK81 As ComboBox
    Friend WithEvents bAdd As Button
    Friend WithEvents txtJoin As TextBox
    Friend WithEvents lblA1 As Label
    Friend WithEvents lblA2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJoin))
        Me.BtnJoin = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboT11 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.cboJ1 = New System.Windows.Forms.ComboBox()
        Me.cboT12 = New System.Windows.Forms.ComboBox()
        Me.cboK11 = New System.Windows.Forms.ComboBox()
        Me.cboK12 = New System.Windows.Forms.ComboBox()
        Me.cboK22 = New System.Windows.Forms.ComboBox()
        Me.cboK21 = New System.Windows.Forms.ComboBox()
        Me.cboK32 = New System.Windows.Forms.ComboBox()
        Me.cboK31 = New System.Windows.Forms.ComboBox()
        Me.cboK42 = New System.Windows.Forms.ComboBox()
        Me.cboK41 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboK52 = New System.Windows.Forms.ComboBox()
        Me.cboK51 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboK62 = New System.Windows.Forms.ComboBox()
        Me.cboK61 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboK72 = New System.Windows.Forms.ComboBox()
        Me.cboK71 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboK82 = New System.Windows.Forms.ComboBox()
        Me.cboK81 = New System.Windows.Forms.ComboBox()
        Me.bAdd = New System.Windows.Forms.Button()
        Me.txtJoin = New System.Windows.Forms.TextBox()
        Me.lblA1 = New System.Windows.Forms.Label()
        Me.lblA2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnJoin
        '
        Me.BtnJoin.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.BtnJoin.Location = New System.Drawing.Point(680, 9)
        Me.BtnJoin.Name = "BtnJoin"
        Me.BtnJoin.Size = New System.Drawing.Size(96, 24)
        Me.BtnJoin.TabIndex = 1
        Me.BtnJoin.Text = "Join"
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.BtnCancel.Location = New System.Drawing.Point(805, 9)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(96, 24)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(935, 35)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Join tables"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(576, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Please specify tables for join and direction of the columns you wish tables to be" &
    " joined by:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Join By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = " "
        '
        'cboT11
        '
        Me.cboT11.CausesValidation = False
        Me.cboT11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboT11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboT11.FormattingEnabled = True
        Me.cboT11.Location = New System.Drawing.Point(132, 63)
        Me.cboT11.Name = "cboT11"
        Me.cboT11.Size = New System.Drawing.Size(210, 21)
        Me.cboT11.TabIndex = 23
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnClearAll)
        Me.Panel1.Controls.Add(Me.BtnJoin)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(935, 45)
        Me.Panel1.TabIndex = 38
        '
        'btnClearAll
        '
        Me.btnClearAll.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.btnClearAll.Location = New System.Drawing.Point(555, 9)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(96, 24)
        Me.btnClearAll.TabIndex = 3
        Me.btnClearAll.Text = "Reset"
        '
        'cboJ1
        '
        Me.cboJ1.CausesValidation = False
        Me.cboJ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboJ1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboJ1.FormattingEnabled = True
        Me.cboJ1.Location = New System.Drawing.Point(351, 63)
        Me.cboJ1.Name = "cboJ1"
        Me.cboJ1.Size = New System.Drawing.Size(210, 21)
        Me.cboJ1.TabIndex = 49
        '
        'cboT12
        '
        Me.cboT12.CausesValidation = False
        Me.cboT12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboT12.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboT12.FormattingEnabled = True
        Me.cboT12.Location = New System.Drawing.Point(601, 63)
        Me.cboT12.Name = "cboT12"
        Me.cboT12.Size = New System.Drawing.Size(210, 21)
        Me.cboT12.TabIndex = 50
        '
        'cboK11
        '
        Me.cboK11.CausesValidation = False
        Me.cboK11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK11.FormattingEnabled = True
        Me.cboK11.Location = New System.Drawing.Point(351, 116)
        Me.cboK11.Name = "cboK11"
        Me.cboK11.Size = New System.Drawing.Size(210, 21)
        Me.cboK11.TabIndex = 51
        '
        'cboK12
        '
        Me.cboK12.CausesValidation = False
        Me.cboK12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK12.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK12.FormattingEnabled = True
        Me.cboK12.Location = New System.Drawing.Point(601, 116)
        Me.cboK12.Name = "cboK12"
        Me.cboK12.Size = New System.Drawing.Size(210, 21)
        Me.cboK12.TabIndex = 52
        '
        'cboK22
        '
        Me.cboK22.CausesValidation = False
        Me.cboK22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK22.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK22.FormattingEnabled = True
        Me.cboK22.Location = New System.Drawing.Point(601, 142)
        Me.cboK22.Name = "cboK22"
        Me.cboK22.Size = New System.Drawing.Size(210, 21)
        Me.cboK22.TabIndex = 58
        '
        'cboK21
        '
        Me.cboK21.CausesValidation = False
        Me.cboK21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK21.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK21.FormattingEnabled = True
        Me.cboK21.Location = New System.Drawing.Point(351, 142)
        Me.cboK21.Name = "cboK21"
        Me.cboK21.Size = New System.Drawing.Size(210, 21)
        Me.cboK21.TabIndex = 57
        '
        'cboK32
        '
        Me.cboK32.CausesValidation = False
        Me.cboK32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK32.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK32.FormattingEnabled = True
        Me.cboK32.Location = New System.Drawing.Point(601, 168)
        Me.cboK32.Name = "cboK32"
        Me.cboK32.Size = New System.Drawing.Size(210, 21)
        Me.cboK32.TabIndex = 60
        '
        'cboK31
        '
        Me.cboK31.CausesValidation = False
        Me.cboK31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK31.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK31.FormattingEnabled = True
        Me.cboK31.Location = New System.Drawing.Point(351, 168)
        Me.cboK31.Name = "cboK31"
        Me.cboK31.Size = New System.Drawing.Size(210, 21)
        Me.cboK31.TabIndex = 59
        '
        'cboK42
        '
        Me.cboK42.CausesValidation = False
        Me.cboK42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK42.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK42.FormattingEnabled = True
        Me.cboK42.Location = New System.Drawing.Point(601, 196)
        Me.cboK42.Name = "cboK42"
        Me.cboK42.Size = New System.Drawing.Size(210, 21)
        Me.cboK42.TabIndex = 62
        '
        'cboK41
        '
        Me.cboK41.CausesValidation = False
        Me.cboK41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK41.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK41.FormattingEnabled = True
        Me.cboK41.Location = New System.Drawing.Point(351, 196)
        Me.cboK41.Name = "cboK41"
        Me.cboK41.Size = New System.Drawing.Size(210, 21)
        Me.cboK41.TabIndex = 61
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(316, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 14)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "ON"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(316, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 14)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "AND"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(316, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 14)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "AND"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(316, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 14)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "AND"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(316, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 14)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "AND"
        '
        'cboK52
        '
        Me.cboK52.CausesValidation = False
        Me.cboK52.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK52.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK52.FormattingEnabled = True
        Me.cboK52.Location = New System.Drawing.Point(601, 224)
        Me.cboK52.Name = "cboK52"
        Me.cboK52.Size = New System.Drawing.Size(210, 21)
        Me.cboK52.TabIndex = 68
        '
        'cboK51
        '
        Me.cboK51.CausesValidation = False
        Me.cboK51.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK51.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK51.FormattingEnabled = True
        Me.cboK51.Location = New System.Drawing.Point(351, 224)
        Me.cboK51.Name = "cboK51"
        Me.cboK51.Size = New System.Drawing.Size(210, 21)
        Me.cboK51.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 14)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "AND"
        '
        'cboK62
        '
        Me.cboK62.CausesValidation = False
        Me.cboK62.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK62.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK62.FormattingEnabled = True
        Me.cboK62.Location = New System.Drawing.Point(601, 251)
        Me.cboK62.Name = "cboK62"
        Me.cboK62.Size = New System.Drawing.Size(210, 21)
        Me.cboK62.TabIndex = 71
        '
        'cboK61
        '
        Me.cboK61.CausesValidation = False
        Me.cboK61.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK61.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK61.FormattingEnabled = True
        Me.cboK61.Location = New System.Drawing.Point(351, 251)
        Me.cboK61.Name = "cboK61"
        Me.cboK61.Size = New System.Drawing.Size(210, 21)
        Me.cboK61.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(316, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 14)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "AND"
        '
        'cboK72
        '
        Me.cboK72.CausesValidation = False
        Me.cboK72.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK72.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK72.FormattingEnabled = True
        Me.cboK72.Location = New System.Drawing.Point(601, 278)
        Me.cboK72.Name = "cboK72"
        Me.cboK72.Size = New System.Drawing.Size(210, 21)
        Me.cboK72.TabIndex = 74
        '
        'cboK71
        '
        Me.cboK71.CausesValidation = False
        Me.cboK71.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK71.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK71.FormattingEnabled = True
        Me.cboK71.Location = New System.Drawing.Point(351, 278)
        Me.cboK71.Name = "cboK71"
        Me.cboK71.Size = New System.Drawing.Size(210, 21)
        Me.cboK71.TabIndex = 73
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 14)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "AND"
        '
        'cboK82
        '
        Me.cboK82.CausesValidation = False
        Me.cboK82.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK82.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK82.FormattingEnabled = True
        Me.cboK82.Location = New System.Drawing.Point(601, 305)
        Me.cboK82.Name = "cboK82"
        Me.cboK82.Size = New System.Drawing.Size(210, 21)
        Me.cboK82.TabIndex = 77
        '
        'cboK81
        '
        Me.cboK81.CausesValidation = False
        Me.cboK81.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboK81.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cboK81.FormattingEnabled = True
        Me.cboK81.Location = New System.Drawing.Point(351, 305)
        Me.cboK81.Name = "cboK81"
        Me.cboK81.Size = New System.Drawing.Size(210, 21)
        Me.cboK81.TabIndex = 76
        '
        'bAdd
        '
        Me.bAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bAdd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.bAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bAdd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bAdd.Location = New System.Drawing.Point(839, 290)
        Me.bAdd.Margin = New System.Windows.Forms.Padding(0)
        Me.bAdd.Name = "bAdd"
        Me.bAdd.Size = New System.Drawing.Size(67, 36)
        Me.bAdd.TabIndex = 10000145
        Me.bAdd.Text = "Add"
        Me.bAdd.UseVisualStyleBackColor = False
        '
        'txtJoin
        '
        Me.txtJoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJoin.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.txtJoin.Location = New System.Drawing.Point(0, 341)
        Me.txtJoin.Multiline = True
        Me.txtJoin.Name = "txtJoin"
        Me.txtJoin.Size = New System.Drawing.Size(935, 44)
        Me.txtJoin.TabIndex = 10000319
        '
        'lblA1
        '
        Me.lblA1.AutoSize = True
        Me.lblA1.Location = New System.Drawing.Point(132, 87)
        Me.lblA1.Name = "lblA1"
        Me.lblA1.Size = New System.Drawing.Size(19, 14)
        Me.lblA1.TabIndex = 10000320
        Me.lblA1.Text = "..."
        '
        'lblA2
        '
        Me.lblA2.AutoSize = True
        Me.lblA2.Location = New System.Drawing.Point(566, 87)
        Me.lblA2.Name = "lblA2"
        Me.lblA2.Size = New System.Drawing.Size(19, 14)
        Me.lblA2.TabIndex = 10000321
        Me.lblA2.Text = "..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(566, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 14)
        Me.Label13.TabIndex = 10000329
        Me.Label13.Text = "="
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(566, 280)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 14)
        Me.Label14.TabIndex = 10000328
        Me.Label14.Text = "="
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(566, 253)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 14)
        Me.Label15.TabIndex = 10000327
        Me.Label15.Text = "="
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(566, 226)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 14)
        Me.Label16.TabIndex = 10000326
        Me.Label16.Text = "="
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(566, 198)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 14)
        Me.Label17.TabIndex = 10000325
        Me.Label17.Text = "="
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(566, 170)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 14)
        Me.Label18.TabIndex = 10000324
        Me.Label18.Text = "="
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(566, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 14)
        Me.Label19.TabIndex = 10000323
        Me.Label19.Text = "="
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(566, 118)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 14)
        Me.Label20.TabIndex = 10000322
        Me.Label20.Text = "="
        '
        'FormJoin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(935, 433)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblA2)
        Me.Controls.Add(Me.lblA1)
        Me.Controls.Add(Me.txtJoin)
        Me.Controls.Add(Me.bAdd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboK82)
        Me.Controls.Add(Me.cboK81)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboK72)
        Me.Controls.Add(Me.cboK71)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboK62)
        Me.Controls.Add(Me.cboK61)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboK52)
        Me.Controls.Add(Me.cboK51)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboJ1)
        Me.Controls.Add(Me.cboK42)
        Me.Controls.Add(Me.cboK41)
        Me.Controls.Add(Me.cboK32)
        Me.Controls.Add(Me.cboK31)
        Me.Controls.Add(Me.cboK22)
        Me.Controls.Add(Me.cboK21)
        Me.Controls.Add(Me.cboK12)
        Me.Controls.Add(Me.cboK11)
        Me.Controls.Add(Me.cboT12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cboT11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormJoin"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Join"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim kkkolone() As String
    Dim tttabele() As String
    Dim bbbaza() As String
    Dim aaalias() As String

    Public Sub New(ByVal form As Form, ByVal ttabele() As String, ByVal kkolone() As String, ByVal bbaza() As String, ByVal aalias() As String)
        InitializeComponent()
        tttabele = ttabele
        kkkolone = kkolone
        bbbaza = bbaza
        aaalias = aalias
        _parentForm = form
        lblA1.Text = ""
        lblA2.Text = ""
        AddHandler Me.Paint, AddressOf DrawBorder
    End Sub

    Private Sub DrawBorder(ByVal sender As Object, ByVal e As PaintEventArgs)

        Dim rectT11 As Rectangle = New Rectangle(cboT11.Location.X - 1, cboT11.Location.Y - 1, cboT11.Width + 1, cboT11.Height + 1)
        Dim rectJ1 As New Rectangle(cboJ1.Location.X - 1, cboJ1.Location.Y - 1, cboJ1.Width + 1, cboJ1.Height + 1)
        Dim rectT12 As New Rectangle(cboT12.Location.X - 1, cboT12.Location.Y - 1, cboT12.Width + 1, cboT12.Height + 1)

        Dim rectK11 As New Rectangle(cboK11.Location.X - 1, cboK11.Location.Y - 1, cboK11.Width + 1, cboK11.Height + 1)
        Dim rectK21 As New Rectangle(cboK21.Location.X - 1, cboK21.Location.Y - 1, cboK21.Width + 1, cboK21.Height + 1)
        Dim rectK31 As New Rectangle(cboK31.Location.X - 1, cboK31.Location.Y - 1, cboK31.Width + 1, cboK31.Height + 1)
        Dim rectK41 As New Rectangle(cboK41.Location.X - 1, cboK41.Location.Y - 1, cboK41.Width + 1, cboK41.Height + 1)

        Dim rectK51 As New Rectangle(cboK51.Location.X - 1, cboK51.Location.Y - 1, cboK51.Width + 1, cboK51.Height + 1)
        Dim rectK61 As New Rectangle(cboK61.Location.X - 1, cboK61.Location.Y - 1, cboK61.Width + 1, cboK61.Height + 1)
        Dim rectK71 As New Rectangle(cboK71.Location.X - 1, cboK71.Location.Y - 1, cboK71.Width + 1, cboK71.Height + 1)
        Dim rectK81 As New Rectangle(cboK81.Location.X - 1, cboK81.Location.Y - 1, cboK81.Width + 1, cboK81.Height + 1)

        Dim rectK12 As New Rectangle(cboK12.Location.X - 1, cboK12.Location.Y - 1, cboK12.Width + 1, cboK12.Height + 1)
        Dim rectK22 As New Rectangle(cboK22.Location.X - 1, cboK22.Location.Y - 1, cboK22.Width + 1, cboK22.Height + 1)
        Dim rectK32 As New Rectangle(cboK32.Location.X - 1, cboK32.Location.Y - 1, cboK32.Width + 1, cboK32.Height + 1)
        Dim rectK42 As New Rectangle(cboK42.Location.X - 1, cboK42.Location.Y - 1, cboK42.Width + 1, cboK42.Height + 1)
        Dim rectK52 As New Rectangle(cboK52.Location.X - 1, cboK52.Location.Y - 1, cboK52.Width + 1, cboK52.Height + 1)
        Dim rectK62 As New Rectangle(cboK62.Location.X - 1, cboK62.Location.Y - 1, cboK62.Width + 1, cboK62.Height + 1)
        Dim rectK72 As New Rectangle(cboK72.Location.X - 1, cboK72.Location.Y - 1, cboK72.Width + 1, cboK72.Height + 1)
        Dim rectK82 As New Rectangle(cboK82.Location.X - 1, cboK82.Location.Y - 1, cboK82.Width + 1, cboK82.Height + 1)

        Dim pen As New Pen(Color.DarkGray, 1)
        Dim g As Graphics = e.Graphics
        g.DrawRectangle(pen, rectT11)

        g.DrawRectangle(pen, rectJ1)
        g.DrawRectangle(pen, rectT12)
        g.DrawRectangle(pen, rectK11) : g.DrawRectangle(pen, rectK21) : g.DrawRectangle(pen, rectK31) : g.DrawRectangle(pen, rectK41)
        g.DrawRectangle(pen, rectK51) : g.DrawRectangle(pen, rectK61) : g.DrawRectangle(pen, rectK71) : g.DrawRectangle(pen, rectK81)
        g.DrawRectangle(pen, rectK12) : g.DrawRectangle(pen, rectK22) : g.DrawRectangle(pen, rectK32) : g.DrawRectangle(pen, rectK42)
        g.DrawRectangle(pen, rectK52) : g.DrawRectangle(pen, rectK62) : g.DrawRectangle(pen, rectK72) : g.DrawRectangle(pen, rectK82)
    End Sub

    Private Sub btnJoin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnJoin.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Friend ReadOnly Property strJOIN() As String
        Get
            Return Me.txtJoin.Text
        End Get
    End Property

    Private Sub cboT11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboT11.Enter
        Call popuniTcbo(cboT11, "")
    End Sub

    Private Sub cboJ1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboJ1.Enter
        Call popuniJcbo(cboJ1)
    End Sub

    Dim bezTabela As String = ""
    Dim bezPoljaA As String = ""
    Dim bezPoljaB As String = ""

    Private Sub cboT12_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboT12.Enter
        If Not cboT11.SelectedItem Is Nothing AndAlso cboT11.SelectedItem.ToString.Trim <> "" Then
            If cboT11.Visible = True Then bezTabela = bezTabela + cboT11.SelectedItem.ToString.Trim + "$"
            Call popuniTcbo(cboT12, bezTabela.Trim.ToUpper)
        End If
    End Sub

    Sub popuniTcbo(ByVal cb As ComboBox, ByVal beztabela As String)
        cb.Items.Clear()
        For i As Integer = 0 To tttabele.GetUpperBound(0)
            If beztabela.Trim.ToUpper.IndexOf(tttabele(i).Trim.ToUpper + "$") < 0 Then cb.Items.Add(tttabele(i).Trim)
        Next
        cb.Text = ""
    End Sub

    Private Sub cboK11_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK11.Enter
        Call punicboK(DirectCast(sender, ComboBox))
    End Sub

    Private Sub cboK12_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK12.Enter
        Call punicboK2(DirectCast(sender, ComboBox))
    End Sub

    Private Sub cboK21_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK21.Enter
        bezPoljaA = bezPoljaA + cboK11.SelectedItem.ToString.Trim + "$"
        Call punicboK(DirectCast(sender, ComboBox))
    End Sub

    Private Sub cboK22_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK22.Enter
        bezPoljaB = bezPoljaB + cboK12.SelectedItem.ToString.Trim + "$"
        Call punicboK2(DirectCast(sender, ComboBox))
    End Sub

    Private Sub cboK31_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK31.Enter
        bezPoljaA = bezPoljaA + cboK21.SelectedItem.ToString.Trim + "$"
        Call punicboK(DirectCast(sender, ComboBox))
    End Sub

    Private Sub cboK32_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK32.Enter
        bezPoljaB = bezPoljaB + cboK22.SelectedItem.ToString.Trim + "$"
        Call punicboK2(DirectCast(sender, ComboBox))
    End Sub

    Private Sub cboK41_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK41.Enter
        bezPoljaA = bezPoljaA + cboK31.SelectedItem.ToString.Trim + "$"
        Call punicboK(DirectCast(sender, ComboBox))
    End Sub

    Private Sub cboK42_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboK42.Enter
        bezPoljaB = bezPoljaB + cboK32.SelectedItem.ToString.Trim + "$"
        Call punicboK2(DirectCast(sender, ComboBox))
    End Sub

    Sub punicboK(ByVal cboK As ComboBox)
        If cboT11.Visible = True AndAlso Not cboT11.SelectedItem Is Nothing AndAlso cboT11.SelectedItem.ToString.Trim <> "" Then
            Call popuniKcbo(cboK, cboT11.SelectedItem.ToString.Trim, bezPoljaA)
        End If
        If cboT11.Visible = False AndAlso Not cboT12.SelectedItem Is Nothing AndAlso cboT12.SelectedItem.ToString.Trim <> "" Then
            'sve od tabela sto nije u cboT12.items, tj sto je u beztabela
            Dim tt() As String = bezTabela.Split("$")
            Call popuniKcbo2(cboK, tt, bezPoljaB)
        End If
    End Sub

    Sub punicboK2(ByVal cboK As ComboBox)
        If Not cboT12.SelectedItem Is Nothing AndAlso cboT12.SelectedItem.ToString.Trim <> "" Then Call popuniKcbo(cboK, cboT12.SelectedItem.ToString.Trim, bezPoljaB)
    End Sub

    Sub popuniKcbo(ByVal cb As ComboBox, ByVal tabela As String, ByVal bezPolja As String)
        cb.Items.Clear()
        For i As Integer = 0 To tttabele.GetUpperBound(0)
            Dim ind As Integer = Array.IndexOf(tttabele, tttabele(i))
            If tttabele(i).Trim.ToUpper = tabela.Trim.ToUpper Then
                Dim kk() As String = kkkolone(i).Split("$")
                For ii As Integer = 0 To kk.GetUpperBound(0)
                    If bezPolja.Trim.ToUpper.IndexOf(kk(ii).Trim.ToUpper + "$") < 0 Then cb.Items.Add(aaalias(ind) + "." + kk(ii).Trim)
                Next
                Exit For
            End If
        Next
        cb.Text = ""
    End Sub

    Sub popuniKcbo2(ByVal cb As ComboBox, ByVal tabele() As String, ByVal bezPolja As String)
        cb.Items.Clear()
        For i As Integer = 0 To tttabele.GetUpperBound(0)
            Dim ind As Integer = Array.IndexOf(tttabele, tttabele(i))
            For m As Integer = 0 To tabele.GetUpperBound(0)
                If tttabele(i).Trim.ToUpper = tabele(m).Trim.ToUpper Then
                    Dim kk() As String = kkkolone(i).Split("$")
                    For ii As Integer = 0 To kk.GetUpperBound(0)
                        If bezPolja.Trim.ToUpper.IndexOf(kk(ii).Trim.ToUpper + "$") < 0 Then cb.Items.Add(aaalias(ind) + "." + kk(ii).Trim)
                    Next
                    Exit For
                End If
            Next
        Next
        cb.Text = ""
    End Sub

    Sub popuniJcbo(ByVal cb As ComboBox)
        cb.Items.Clear()
        Dim jjoin As String = "INNER JOIN$LEFT JOIN$RIGHT JOIN$FULL OUTER JOIN"
        Dim j() As String = jjoin.Trim.ToUpper.Split("$")
        For i As Integer = 0 To j.GetUpperBound(0)
            cb.Items.Add(j(i).Trim)
        Next
        cb.Text = ""
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        Me.txtJoin.Text = ""
        Call ponisti()
        RectColor(Color.DarkGray)
        cboT11.Visible = True
        bezTabela = ""
        bezPoljaA = ""
        bezPoljaB = ""
    End Sub

    Sub ponisti()
        Me.lblA1.Text = ""
        Me.lblA2.Text = ""
        cboT11.Text = ""
        cboT12.Text = ""
        cboJ1.Text = ""
        cboK11.Text = ""
        cboK21.Text = ""
        cboK31.Text = ""
        cboK41.Text = ""
        cboK51.Text = ""
        cboK61.Text = ""
        cboK71.Text = ""
        cboK81.Text = ""
        cboK12.Text = ""
        cboK22.Text = ""
        cboK32.Text = ""
        cboK42.Text = ""
        cboK52.Text = ""
        cboK62.Text = ""
        cboK72.Text = ""
        cboK82.Text = ""
    End Sub

    Private Sub bAdd_Click(sender As Object, e As EventArgs) Handles bAdd.Click
        Dim join As String = ""
        If cboT11.Visible = True Then
            If cboT11.Text <> "" AndAlso cboJ1.Text <> "" AndAlso cboT12.Text <> "" AndAlso cboK11.Text <> "" AndAlso cboK12.Text <> "" Then
                Dim ind11 As Integer = Array.IndexOf(tttabele, cboT11.Text)
                Dim ind12 As Integer = Array.IndexOf(tttabele, cboT12.Text)
                Dim lt As String = "" : Dim rt As String = ""
                lt = bbbaza(ind11) + cboT11.Text + " AS " + aaalias(ind11)
                rt = bbbaza(ind12) + cboT12.Text + " AS " + aaalias(ind12)

                join = join + lt + " " + cboJ1.Text + " " + rt + " ON " + cboK11.Text + "=" + cboK12.Text
                If cboK21.Text <> "" AndAlso cboK22.Text <> "" Then
                    join = join + " and " + cboK21.Text + "=" + cboK22.Text
                    If cboK31.Text <> "" AndAlso cboK32.Text <> "" Then
                        join = join + " and " + cboK31.Text + "=" + cboK32.Text
                        If cboK41.Text <> "" AndAlso cboK42.Text <> "" Then
                            join = join + " and " + cboK41.Text + "=" + cboK42.Text
                            If cboK51.Text <> "" AndAlso cboK52.Text <> "" Then
                                join = join + " and " + cboK51.Text + "=" + cboK52.Text
                                If cboK61.Text <> "" AndAlso cboK62.Text <> "" Then
                                    join = join + " and " + cboK61.Text + "=" + cboK62.Text
                                    If cboK71.Text <> "" AndAlso cboK72.Text <> "" Then
                                        join = join + " and " + cboK71.Text + "=" + cboK72.Text
                                        If cboK81.Text <> "" AndAlso cboK82.Text <> "" Then
                                            join = join + " and " + cboK81.Text + "=" + cboK82.Text
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            join = join + ")"
            cboT11.Visible = False
            RectColor(SystemColors.Window)
        Else
            If cboJ1.Text <> "" AndAlso cboT12.Text <> "" AndAlso cboK11.Text <> "" AndAlso cboK12.Text <> "" Then
                Dim rt As String = ""
                Dim ind12 As Integer = Array.IndexOf(tttabele, cboT12.Text)
                rt = bbbaza(ind12) + cboT12.Text + " AS " + aaalias(ind12)
                join = join + " " + cboJ1.Text + " " + rt + " ON " + cboK11.Text + "=" + cboK12.Text
                If cboK21.Text <> "" AndAlso cboK22.Text <> "" Then
                    join = join + " and " + cboK21.Text + "=" + cboK22.Text
                    If cboK31.Text <> "" AndAlso cboK32.Text <> "" Then
                        join = join + " and " + cboK31.Text + "=" + cboK32.Text
                        If cboK41.Text <> "" AndAlso cboK42.Text <> "" Then
                            join = join + " and " + cboK41.Text + "=" + cboK42.Text
                            If cboK51.Text <> "" AndAlso cboK52.Text <> "" Then
                                join = join + " and " + cboK51.Text + "=" + cboK52.Text
                                If cboK61.Text <> "" AndAlso cboK62.Text <> "" Then
                                    join = join + " and " + cboK61.Text + "=" + cboK62.Text
                                    If cboK71.Text <> "" AndAlso cboK72.Text <> "" Then
                                        join = join + " and " + cboK71.Text + "=" + cboK72.Text
                                        If cboK81.Text <> "" AndAlso cboK82.Text <> "" Then
                                            join = join + " and " + cboK81.Text + "=" + cboK82.Text
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            join = join + ")"
        End If

        Me.txtJoin.Text = "(" + Me.txtJoin.Text + join
        bezTabela = bezTabela + cboT12.SelectedItem.ToString.Trim + "$"

        Call ponisti()

    End Sub

    Private Sub RectColor(ByVal ccolor As Color)

        Dim myGraphics As Graphics
        Dim myRectangle As Rectangle
        Dim myPen As New Pen(ccolor)
        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)
        myRectangle = New Rectangle(cboT11.Location.X - 1, cboT11.Location.Y - 1, cboT11.Width + 1, cboT11.Height + 1)
        myGraphics.DrawRectangle(pen:=myPen, rect:=myRectangle)

    End Sub

    Private Sub cboT11_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboT11.SelectedIndexChanged
        Dim ind As Integer = Array.IndexOf(tttabele, cboT11.Text)
        Me.lblA1.Text = aaalias(ind)
    End Sub

    Private Sub cboT12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboT12.SelectedIndexChanged
        Dim ind As Integer = Array.IndexOf(tttabele, cboT12.Text)
        Me.lblA2.Text = aaalias(ind)
    End Sub

End Class