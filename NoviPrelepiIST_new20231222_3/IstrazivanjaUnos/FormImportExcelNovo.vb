Option Strict Off

Imports System.Data
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Imports Microsoft

Public Class FormImportExcelNovo
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonIzlaz As System.Windows.Forms.Button
    Friend WithEvents cbOLEDB As CheckBox
    Friend WithEvents ButtonCF As Button
    Friend WithEvents lblBaza As Label
    Friend WithEvents cbNew As CheckBox
    Friend WithEvents cbJoin As CheckBox
    Friend WithEvents cbJoinAll As CheckBox
    Friend WithEvents cbExisting As CheckBox
    Friend WithEvents tbJoin As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents lblKoWin As Label
    Friend WithEvents PanelRight As Panel
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer5 As SplitContainer
    Friend WithEvents lbUB As ListBox
    Friend WithEvents lbColumnsInExcel As ListBox
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents tbShemaName As TextBox
    Friend WithEvents cbShema As CheckBox
    Friend WithEvents tbTableName As TextBox
    Friend WithEvents lblTN As Label
    Friend WithEvents lblSN As Label
    Friend WithEvents SplitContainer6 As SplitContainer
    Friend WithEvents lbColumnsInDB As ListBox
    Friend WithEvents lbDBTables As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblUB As Label
    Friend WithEvents cbSAll As CheckBox
    Friend WithEvents lblCol As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonCreateImport As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormImportExcelNovo))
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbJoin = New System.Windows.Forms.CheckBox()
        Me.cbJoinAll = New System.Windows.Forms.CheckBox()
        Me.cbExisting = New System.Windows.Forms.CheckBox()
        Me.cbNew = New System.Windows.Forms.CheckBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lblBaza = New System.Windows.Forms.Label()
        Me.ButtonCF = New System.Windows.Forms.Button()
        Me.cbOLEDB = New System.Windows.Forms.CheckBox()
        Me.lblKoWin = New System.Windows.Forms.Label()
        Me.tbJoin = New System.Windows.Forms.TextBox()
        Me.ButtonIzlaz = New System.Windows.Forms.Button()
        Me.PanelRight = New System.Windows.Forms.Panel()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.lbUB = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUB = New System.Windows.Forms.Label()
        Me.lbColumnsInExcel = New System.Windows.Forms.ListBox()
        Me.cbSAll = New System.Windows.Forms.CheckBox()
        Me.lblCol = New System.Windows.Forms.Label()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.tbShemaName = New System.Windows.Forms.TextBox()
        Me.lblSN = New System.Windows.Forms.Label()
        Me.cbShema = New System.Windows.Forms.CheckBox()
        Me.tbTableName = New System.Windows.Forms.TextBox()
        Me.lblTN = New System.Windows.Forms.Label()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.lbColumnsInDB = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbDBTables = New System.Windows.Forms.ListBox()
        Me.ButtonCreateImport = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.PanelRight.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucvt
        '
        Me.ucvt.BackColor = System.Drawing.SystemColors.Control
        Me.ucvt.Enabled = False
        Me.ucvt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvt.Location = New System.Drawing.Point(3, 631)
        Me.ucvt.Name = "ucvt"
        Me.ucvt.Size = New System.Drawing.Size(106, 33)
        Me.ucvt.TabIndex = 6
        Me.ucvt.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbJoin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbJoinAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbExisting)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbNew)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblPath)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblBaza)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCF)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbOLEDB)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblKoWin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.tbJoin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ucvt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonIzlaz)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelRight)
        Me.SplitContainer1.Size = New System.Drawing.Size(1386, 580)
        Me.SplitContainer1.SplitterDistance = 238
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 4
        '
        'cbJoin
        '
        Me.cbJoin.BackColor = System.Drawing.Color.Transparent
        Me.cbJoin.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbJoin.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbJoin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbJoin.Location = New System.Drawing.Point(0, 259)
        Me.cbJoin.Name = "cbJoin"
        Me.cbJoin.Padding = New System.Windows.Forms.Padding(3)
        Me.cbJoin.Size = New System.Drawing.Size(238, 32)
        Me.cbJoin.TabIndex = 10000139
        Me.cbJoin.Text = "Join"
        Me.cbJoin.UseVisualStyleBackColor = False
        Me.cbJoin.Visible = False
        '
        'cbJoinAll
        '
        Me.cbJoinAll.BackColor = System.Drawing.Color.Transparent
        Me.cbJoinAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbJoinAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbJoinAll.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbJoinAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbJoinAll.Location = New System.Drawing.Point(0, 227)
        Me.cbJoinAll.Name = "cbJoinAll"
        Me.cbJoinAll.Padding = New System.Windows.Forms.Padding(3)
        Me.cbJoinAll.Size = New System.Drawing.Size(238, 32)
        Me.cbJoinAll.TabIndex = 10000138
        Me.cbJoinAll.Text = "Join all by names"
        Me.cbJoinAll.UseVisualStyleBackColor = False
        Me.cbJoinAll.Visible = False
        '
        'cbExisting
        '
        Me.cbExisting.BackColor = System.Drawing.Color.Transparent
        Me.cbExisting.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbExisting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbExisting.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbExisting.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbExisting.Location = New System.Drawing.Point(0, 195)
        Me.cbExisting.Name = "cbExisting"
        Me.cbExisting.Padding = New System.Windows.Forms.Padding(3)
        Me.cbExisting.Size = New System.Drawing.Size(238, 32)
        Me.cbExisting.TabIndex = 10000137
        Me.cbExisting.Text = "Exisiting table"
        Me.cbExisting.UseVisualStyleBackColor = False
        Me.cbExisting.Visible = False
        '
        'cbNew
        '
        Me.cbNew.BackColor = System.Drawing.Color.Transparent
        Me.cbNew.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNew.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbNew.Location = New System.Drawing.Point(0, 163)
        Me.cbNew.Name = "cbNew"
        Me.cbNew.Padding = New System.Windows.Forms.Padding(3)
        Me.cbNew.Size = New System.Drawing.Size(238, 32)
        Me.cbNew.TabIndex = 10000136
        Me.cbNew.Text = "New table"
        Me.cbNew.UseVisualStyleBackColor = False
        Me.cbNew.Visible = False
        '
        'lblPath
        '
        Me.lblPath.BackColor = System.Drawing.Color.Transparent
        Me.lblPath.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPath.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPath.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblPath.Location = New System.Drawing.Point(0, 131)
        Me.lblPath.Margin = New System.Windows.Forms.Padding(3)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Padding = New System.Windows.Forms.Padding(3)
        Me.lblPath.Size = New System.Drawing.Size(238, 32)
        Me.lblPath.TabIndex = 10000141
        Me.lblPath.Text = "Excel file"
        Me.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBaza
        '
        Me.lblBaza.BackColor = System.Drawing.Color.Transparent
        Me.lblBaza.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBaza.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblBaza.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblBaza.Location = New System.Drawing.Point(0, 99)
        Me.lblBaza.Margin = New System.Windows.Forms.Padding(3)
        Me.lblBaza.Name = "lblBaza"
        Me.lblBaza.Padding = New System.Windows.Forms.Padding(3)
        Me.lblBaza.Size = New System.Drawing.Size(238, 32)
        Me.lblBaza.TabIndex = 10000135
        Me.lblBaza.Text = "Database"
        Me.lblBaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonCF
        '
        Me.ButtonCF.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonCF.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonCF.FlatAppearance.BorderSize = 0
        Me.ButtonCF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCF.ForeColor = System.Drawing.Color.Black
        Me.ButtonCF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCF.Location = New System.Drawing.Point(0, 64)
        Me.ButtonCF.Name = "ButtonCF"
        Me.ButtonCF.Padding = New System.Windows.Forms.Padding(3)
        Me.ButtonCF.Size = New System.Drawing.Size(238, 35)
        Me.ButtonCF.TabIndex = 10000133
        Me.ButtonCF.Text = "Choose file"
        Me.ButtonCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCF.UseVisualStyleBackColor = False
        '
        'cbOLEDB
        '
        Me.cbOLEDB.BackColor = System.Drawing.Color.Transparent
        Me.cbOLEDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbOLEDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOLEDB.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbOLEDB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbOLEDB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbOLEDB.Location = New System.Drawing.Point(0, 32)
        Me.cbOLEDB.Name = "cbOLEDB"
        Me.cbOLEDB.Padding = New System.Windows.Forms.Padding(3)
        Me.cbOLEDB.Size = New System.Drawing.Size(238, 32)
        Me.cbOLEDB.TabIndex = 10000134
        Me.cbOLEDB.Text = "via OLEDB (64 bit OS/Office or 32 bit OS/Office)"
        Me.cbOLEDB.UseVisualStyleBackColor = False
        '
        'lblKoWin
        '
        Me.lblKoWin.BackColor = System.Drawing.Color.Transparent
        Me.lblKoWin.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblKoWin.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblKoWin.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblKoWin.Location = New System.Drawing.Point(0, 0)
        Me.lblKoWin.Margin = New System.Windows.Forms.Padding(3)
        Me.lblKoWin.Name = "lblKoWin"
        Me.lblKoWin.Padding = New System.Windows.Forms.Padding(3)
        Me.lblKoWin.Size = New System.Drawing.Size(238, 32)
        Me.lblKoWin.TabIndex = 10000142
        Me.lblKoWin.Text = "User windows"
        Me.lblKoWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbJoin
        '
        Me.tbJoin.Enabled = False
        Me.tbJoin.Location = New System.Drawing.Point(3, 338)
        Me.tbJoin.Name = "tbJoin"
        Me.tbJoin.Size = New System.Drawing.Size(50, 22)
        Me.tbJoin.TabIndex = 10000140
        Me.tbJoin.Visible = False
        '
        'ButtonIzlaz
        '
        Me.ButtonIzlaz.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonIzlaz.BackgroundImage = CType(resources.GetObject("ButtonIzlaz.BackgroundImage"), System.Drawing.Image)
        Me.ButtonIzlaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonIzlaz.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonIzlaz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonIzlaz.FlatAppearance.BorderSize = 0
        Me.ButtonIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIzlaz.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzlaz.ForeColor = System.Drawing.Color.FromArgb(CType(CType(179, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ButtonIzlaz.Location = New System.Drawing.Point(0, 50)
        Me.ButtonIzlaz.Name = "ButtonIzlaz"
        Me.ButtonIzlaz.Size = New System.Drawing.Size(307, 25)
        Me.ButtonIzlaz.TabIndex = 218
        Me.ButtonIzlaz.TabStop = False
        Me.ButtonIzlaz.Text = "Излаз"
        Me.ButtonIzlaz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzlaz.UseVisualStyleBackColor = False
        '
        'PanelRight
        '
        Me.PanelRight.AllowDrop = True
        Me.PanelRight.Controls.Add(Me.SplitContainer4)
        Me.PanelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRight.Location = New System.Drawing.Point(0, 0)
        Me.PanelRight.Name = "PanelRight"
        Me.PanelRight.Size = New System.Drawing.Size(1142, 580)
        Me.PanelRight.TabIndex = 10000132
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer4.Size = New System.Drawing.Size(1142, 580)
        Me.SplitContainer4.SplitterDistance = 1083
        Me.SplitContainer4.SplitterWidth = 6
        Me.SplitContainer4.TabIndex = 10000141
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer5)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1083, 580)
        Me.SplitContainer2.SplitterDistance = 356
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 10000141
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer5.Panel1.Controls.Add(Me.lbUB)
        Me.SplitContainer5.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer5.Panel1.Controls.Add(Me.lblUB)
        Me.SplitContainer5.Panel1MinSize = 50
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer5.Panel2.Controls.Add(Me.lbColumnsInExcel)
        Me.SplitContainer5.Panel2.Controls.Add(Me.cbSAll)
        Me.SplitContainer5.Panel2.Controls.Add(Me.lblCol)
        Me.SplitContainer5.Panel2MinSize = 50
        Me.SplitContainer5.Size = New System.Drawing.Size(356, 580)
        Me.SplitContainer5.SplitterDistance = 173
        Me.SplitContainer5.SplitterWidth = 6
        Me.SplitContainer5.TabIndex = 8
        '
        'lbUB
        '
        Me.lbUB.AllowDrop = True
        Me.lbUB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbUB.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbUB.ItemHeight = 14
        Me.lbUB.Location = New System.Drawing.Point(0, 44)
        Me.lbUB.Name = "lbUB"
        Me.lbUB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbUB.Size = New System.Drawing.Size(173, 490)
        Me.lbUB.TabIndex = 8
        Me.lbUB.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 22)
        Me.Label1.TabIndex = 10000136
        Me.Label1.Text = "."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUB
        '
        Me.lblUB.BackColor = System.Drawing.Color.Transparent
        Me.lblUB.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblUB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUB.Location = New System.Drawing.Point(0, 0)
        Me.lblUB.Name = "lblUB"
        Me.lblUB.Size = New System.Drawing.Size(173, 22)
        Me.lblUB.TabIndex = 10000135
        Me.lblUB.Text = "Unique by"
        Me.lblUB.Visible = False
        '
        'lbColumnsInExcel
        '
        Me.lbColumnsInExcel.AllowDrop = True
        Me.lbColumnsInExcel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbColumnsInExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbColumnsInExcel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.lbColumnsInExcel.ItemHeight = 14
        Me.lbColumnsInExcel.Location = New System.Drawing.Point(0, 44)
        Me.lbColumnsInExcel.Name = "lbColumnsInExcel"
        Me.lbColumnsInExcel.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbColumnsInExcel.Size = New System.Drawing.Size(177, 490)
        Me.lbColumnsInExcel.TabIndex = 7
        Me.lbColumnsInExcel.Visible = False
        '
        'cbSAll
        '
        Me.cbSAll.BackColor = System.Drawing.Color.Transparent
        Me.cbSAll.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbSAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbSAll.Location = New System.Drawing.Point(0, 22)
        Me.cbSAll.Name = "cbSAll"
        Me.cbSAll.Size = New System.Drawing.Size(177, 22)
        Me.cbSAll.TabIndex = 10000135
        Me.cbSAll.Text = "Select all"
        Me.cbSAll.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbSAll.UseVisualStyleBackColor = False
        Me.cbSAll.Visible = False
        '
        'lblCol
        '
        Me.lblCol.BackColor = System.Drawing.Color.Transparent
        Me.lblCol.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCol.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCol.Location = New System.Drawing.Point(0, 0)
        Me.lblCol.Name = "lblCol"
        Me.lblCol.Size = New System.Drawing.Size(177, 22)
        Me.lblCol.TabIndex = 10000134
        Me.lblCol.Text = "Columns"
        Me.lblCol.Visible = False
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer3.Panel1.Controls.Add(Me.tbShemaName)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblSN)
        Me.SplitContainer3.Panel1.Controls.Add(Me.cbShema)
        Me.SplitContainer3.Panel1.Controls.Add(Me.tbTableName)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblTN)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer3.Size = New System.Drawing.Size(721, 580)
        Me.SplitContainer3.SplitterDistance = 179
        Me.SplitContainer3.SplitterWidth = 6
        Me.SplitContainer3.TabIndex = 0
        '
        'tbShemaName
        '
        Me.tbShemaName.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbShemaName.Location = New System.Drawing.Point(0, 88)
        Me.tbShemaName.Name = "tbShemaName"
        Me.tbShemaName.Size = New System.Drawing.Size(179, 22)
        Me.tbShemaName.TabIndex = 10000143
        Me.tbShemaName.Visible = False
        '
        'lblSN
        '
        Me.lblSN.BackColor = System.Drawing.Color.Transparent
        Me.lblSN.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSN.Location = New System.Drawing.Point(0, 66)
        Me.lblSN.Name = "lblSN"
        Me.lblSN.Size = New System.Drawing.Size(179, 22)
        Me.lblSN.TabIndex = 10000144
        Me.lblSN.Text = "Shema name"
        Me.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSN.Visible = False
        '
        'cbShema
        '
        Me.cbShema.BackColor = System.Drawing.Color.Transparent
        Me.cbShema.Dock = System.Windows.Forms.DockStyle.Top
        Me.cbShema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbShema.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbShema.Location = New System.Drawing.Point(0, 44)
        Me.cbShema.Name = "cbShema"
        Me.cbShema.Size = New System.Drawing.Size(179, 22)
        Me.cbShema.TabIndex = 10000142
        Me.cbShema.Text = "Shema"
        Me.cbShema.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cbShema.UseVisualStyleBackColor = False
        Me.cbShema.Visible = False
        '
        'tbTableName
        '
        Me.tbTableName.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbTableName.Location = New System.Drawing.Point(0, 22)
        Me.tbTableName.Name = "tbTableName"
        Me.tbTableName.Size = New System.Drawing.Size(179, 22)
        Me.tbTableName.TabIndex = 10000140
        Me.tbTableName.Visible = False
        '
        'lblTN
        '
        Me.lblTN.BackColor = System.Drawing.Color.Transparent
        Me.lblTN.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTN.Location = New System.Drawing.Point(0, 0)
        Me.lblTN.Name = "lblTN"
        Me.lblTN.Size = New System.Drawing.Size(179, 22)
        Me.lblTN.TabIndex = 10000141
        Me.lblTN.Text = "Table name"
        Me.lblTN.Visible = False
        '
        'SplitContainer6
        '
        Me.SplitContainer6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer6.Panel1.Controls.Add(Me.lbColumnsInDB)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer6.Panel1MinSize = 50
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.SplitContainer6.Panel2.Controls.Add(Me.lbDBTables)
        Me.SplitContainer6.Panel2.Controls.Add(Me.ButtonCreateImport)
        Me.SplitContainer6.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer6.Panel2MinSize = 50
        Me.SplitContainer6.Size = New System.Drawing.Size(536, 580)
        Me.SplitContainer6.SplitterDistance = 177
        Me.SplitContainer6.SplitterWidth = 6
        Me.SplitContainer6.TabIndex = 9
        '
        'lbColumnsInDB
        '
        Me.lbColumnsInDB.AllowDrop = True
        Me.lbColumnsInDB.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbColumnsInDB.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbColumnsInDB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.lbColumnsInDB.ItemHeight = 14
        Me.lbColumnsInDB.Location = New System.Drawing.Point(0, 44)
        Me.lbColumnsInDB.Name = "lbColumnsInDB"
        Me.lbColumnsInDB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbColumnsInDB.Size = New System.Drawing.Size(177, 490)
        Me.lbColumnsInDB.TabIndex = 8
        Me.lbColumnsInDB.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 44)
        Me.Label2.TabIndex = 10000135
        Me.Label2.Text = "."
        '
        'lbDBTables
        '
        Me.lbDBTables.AllowDrop = True
        Me.lbDBTables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lbDBTables.ItemHeight = 14
        Me.lbDBTables.Location = New System.Drawing.Point(0, 42)
        Me.lbDBTables.Name = "lbDBTables"
        Me.lbDBTables.Size = New System.Drawing.Size(363, 490)
        Me.lbDBTables.TabIndex = 9
        Me.lbDBTables.Visible = False
        '
        'ButtonCreateImport
        '
        Me.ButtonCreateImport.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonCreateImport.FlatAppearance.BorderSize = 0
        Me.ButtonCreateImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCreateImport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCreateImport.ForeColor = System.Drawing.Color.Black
        Me.ButtonCreateImport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCreateImport.Location = New System.Drawing.Point(0, 18)
        Me.ButtonCreateImport.Name = "ButtonCreateImport"
        Me.ButtonCreateImport.Size = New System.Drawing.Size(363, 24)
        Me.ButtonCreateImport.TabIndex = 10000133
        Me.ButtonCreateImport.Text = "Import"
        Me.ButtonCreateImport.UseVisualStyleBackColor = False
        Me.ButtonCreateImport.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 18)
        Me.Label3.TabIndex = 10000137
        Me.Label3.Text = "."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1386, 40)
        Me.PanelTop.TabIndex = 142
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.Transparent
        Me.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b3.FlatAppearance.BorderSize = 0
        Me.b3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.Color.DarkOrange
        Me.b3.Location = New System.Drawing.Point(10, 4)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(240, 32)
        Me.b3.TabIndex = 183
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1303, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1346, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Logovan
        '
        Me.Logovan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(1114, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(183, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContenedor.Controls.Add(Me.SplitContainer1)
        Me.PanelContenedor.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1386, 580)
        Me.PanelContenedor.TabIndex = 145
        '
        'FormImportExcelNovo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1386, 620)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormImportExcelNovo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.PanelRight.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer5.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer6.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '*******
    Private originalExStyle As Integer = -1
    Private enableFormLevelDoubleBuffering As Boolean = True
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            If originalExStyle = -1 Then originalExStyle = MyBase.CreateParams.ExStyle
            Dim cp As CreateParams = MyBase.CreateParams

            If enableFormLevelDoubleBuffering Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            Else
                cp.ExStyle = originalExStyle
            End If
            Return cp
        End Get
    End Property
    Public Sub TurnOffFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = False
        'Me.MaximizeBox = True
    End Sub
    Public Sub TurnOnFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = True
        ' Me.MaximizeBox = True
    End Sub
    Private Sub Form_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        TurnOnFormLevelDoubleBuffering()
    End Sub

    Private Sub Form_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        TurnOffFormLevelDoubleBuffering()
    End Sub
    '*******
    Dim putanja As String
    Dim dtSelect As New System.Data.DataTable
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim lokalno As Boolean

    Dim ttab As DatasetIstrazivanja.ISTTABSDataTable
    Dim istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Dim istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Dim istLK As DatasetIstrazivanja.ISTLKDataTable
    Dim istBaze As DatasetIstrazivanja.ISTBAZEDataTable
    Dim mrist As DatasetIstrazivanja.ISTRow

    Dim trtDSpom As System.Data.DataSet
    Dim tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim mTrt As String
    Dim mKoIstOtk As String
    Dim mxls As String
    Dim mExcelXML As String
    Dim mXML As String
    Dim mXSL As String
    Dim dword As String
    Dim wfn As String = ""
    Dim jesteExcelXML As Integer = 0
    Dim strFROMpom As String = ""
    Dim strSelectpom As String = ""

    Private ReadOnly m_folderProgramaZaUnos As String
    Private ReadOnly Instalacija As String
    Dim dgDT As System.Data.DataTable
    Dim DBConnectionString As String
    Dim ISTConnectionString As String
    Dim jezik As String
    Dim txtmode As String
    Dim sifist As String = ""
    Dim folderZaGen As String = ""
    Dim pravaBaza As String
    Dim server As String
    Dim dtKS As New System.Data.DataTable
    Dim dtGA As New System.Data.DataTable
    Dim dtD As New System.Data.DataTable
    Dim dtGD As New System.Data.DataTable

    Dim vt1 As String

    '********************************************
    Private startPoint As Point

    Private endPoint As Point
    Private startIndex As Integer
    Private connections As New Hashtable
    Private lastIndex As Integer = -1
    Private lbs1 As ListBoxScroll
    Private lbs2 As ListBoxScroll
    Private selected As String
    Private cm As New ContextMenu
    Private mi As New MenuItem("Delete Relation")
    Dim dateStart As Date

    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                    ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable,
                    ByVal istPolja As DatasetIstrazivanja.ISTPOLJADataTable,
                    ByVal istLK As DatasetIstrazivanja.ISTLKDataTable,
                    ByVal istBaze As DatasetIstrazivanja.ISTBAZEDataTable,
                    ByVal mmb As DatasetIstrazivanja.ISTBAZERow,
                    ByVal ISTConnectionString As String, ByVal txtpismo As String, ByVal jezik As String, ByVal txtMode As String, ByVal DSBrisanjeDEPO As String, ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String)

        Me.New()

        Me.jezik = jezik
        Me.txtmode = txtMode

        Me.m_folderProgramaZaUnos = ""
        Me.Instalacija = ""

        Me.Text += " - " + ri.Naziv.Trim
        Me.ttab = ttab
        Me.istTabele = istTabele
        Me.istPolja = istPolja
        Me.istLK = istLK
        Me.istBaze = istBaze
        Me.mrist = ri
        Me.DBConnectionString = DBConnectionString
        ucvt.Init(vt)
        tacv = vt

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Logovan.Text = GetUserName.ToString.Trim
        Me.ISTConnectionString = ISTConnectionString

        Me.DSBrisanjeDEPO = DSBrisanjeDEPO
        Me.DSBrisanjeServer = DSBrisanjeServer
        Me.DSBrisanjeBaza = DSBrisanjeBaza

        Me.sifist = CStr(mrist.SIFIST).Trim.ToUpper
        'folderZaGen = CStr(mrist.TxtDir).Trim.ToUpper
        folderZaGen = ""
        If txtMode.IndexOf("Z") = 0 OrElse txtMode.IndexOf("ZCAPI") = 0 Then
            folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper
        Else
            folderZaGen = CStr(mrist.TxtDir).Trim.ToUpper
        End If

        Me.lblKoWin.Text = GetUserName.ToString.Trim

        Dim dt As New System.Data.DataTable
        Dim sql As String = " select pravaBaza,server,konekcijaDok from vBazaServer where SifIst='" + sifist + "' "
        dt = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)

        pravaBaza = dt.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim
        server = dt.Rows(0).Item("server").ToString.ToUpper.Trim
        Me.lblBaza.Text = server.Trim.ToUpper + "\" + pravaBaza.Trim.ToUpper

        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

        b3.Text = sifist + "    " + String.Format("{0:d2}", Me.tacv.M) + " / " + Me.tacv.G.ToString

        dateStart = Date.Now
        Me.WindowState = FormWindowState.Maximized

        Call SetLang()
    End Sub
    Private Sub SetLang()

        'Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")


    End Sub
    Private Sub FormOcena_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call PreVentFlicker()
        Call setTheme(GetTheme())

        Me.SplitContainer1.SplitterDistance = 249
        lbs1 = New ListBoxScroll(Me.lbColumnsInExcel)
        lbs2 = New ListBoxScroll(Me.lbColumnsInDB)
        AddHandler lbs1.Scrolled, AddressOf Me.lbs_Scrolled
        AddHandler lbs2.Scrolled, AddressOf Me.lbs_Scrolled

        cm.MenuItems.Add(mi)
        'AddHandler mi.Click, AddressOf Me.mi_Click
        cbOLEDB.Checked = True

        lbUB.Height = lbColumnsInExcel.Height



    End Sub
    Sub setTheme(ByVal theme As String)
        If theme = "L" Then
            ISTTheme.ChosenTheme("Light")

            PanelTop.BackColor = ISTTheme.PanelParent
        Else
            ISTTheme.ChosenTheme("Dark")

            PanelTop.BackColor = ISTTheme.PanelParent
        End If
    End Sub

    Private Sub lbs_Scrolled()
        PanelRight.Refresh()
    End Sub

    Private Function nadtabelaJe(ByVal t As String) As String
        'nadji nadtabela sta je
        nadtabelaJe = ""
        For Each r As DatasetIstrazivanja.ISTTABELERow In istTabele.Rows
            If (Not r.IsNadTabelaNull) AndAlso r.Tabela.Trim.ToUpper = t.Trim.ToUpper Then
                nadtabelaJe = r.NadTabela.Trim.ToUpper
            End If
        Next
    End Function

    Private Function DajKljuceve(ByVal tbl As String) As String()
        Dim klj() As String = {}
        For Each p As DatasetIstrazivanja.ISTPOLJARow In istPolja.Rows
            If p.TABELA.Trim.ToUpper = tbl.Trim.ToUpper Then
                If Not p.IsKLJUCNull AndAlso p.KLJUC.Trim.ToUpper = "P" Then
                    ReDim Preserve klj(1 + klj.GetUpperBound(0))
                    klj(klj.GetUpperBound(0)) = p.POLJE.Trim.ToUpper
                End If
            End If
        Next
        Return klj
    End Function

    Dim strFileName As String = ""
    Dim dtExcel99 As DataTable
    Private Sub ButtonCF_Click(sender As Object, e As EventArgs) Handles ButtonCF.Click
        Me.Cursor = Cursors.WaitCursor
        lbColumnsInExcel.DrawMode = DrawMode.Normal
        lbColumnsInDB.DrawMode = DrawMode.Normal
        Dim fd As OpenFileDialog = New OpenFileDialog()
        strFileName = ""
        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Excel Files(.xls)|*.xls|Excel Files(.xlsx)|*.xlsx|Excel Files(*.xlsm)|*.xlsm|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Me.lblPath.Text = strFileName
        End If

        If strFileName = "" Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If


        Me.BackColor = Me.BackColor

        Me.Cursor = Cursors.WaitCursor
        Dim fileExt As String = IO.Path.GetExtension(strFileName)
        Try

            dtExcel99 = Nothing

            If cbOLEDB.Checked = True Then
                dtExcel99 = exceldataOLEDB(strFileName)
            Else
                dtExcel99 = exceldata(strFileName)
            End If

            dtExcel99 = removeEmptyRows(dtExcel99)

            Call addToLB(dtExcel99)

            lblPath.Visible = True
            Me.cbNew.Visible = True
            Me.cbExisting.Visible = True
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Function removeFromLBExcel(ByVal selectAll As Integer) As Integer
        removeFromLBExcel = 1
        Dim columnsInDBArray() As String = getArrayFromLB(lbColumnsInDB)
        Dim columnsInExcelArray() As String = getArrayFromLB(lbColumnsInExcel)
        Dim columnsUB() As String = getArrayFromLB(lbUB)

        Dim selectedColumnsExcel As String = ""
        'podrazumeva se da je cbJoinAll.Checked = True  za sad
        Dim selectedcolumnsInExcelArray() As String = {}
        If selectAll = 1 Then  'sve vec selectovane
            selectedcolumnsInExcelArray = columnsInExcelArray
        Else
            For i As Integer = 0 To lbColumnsInExcel.Items.Count - 1
                If lbColumnsInExcel.GetSelected(i) = True Then
                    Dim ind As Integer = Array.IndexOf(columnsInDBArray, lbColumnsInExcel.Items(i).ToString.Trim.ToUpper)   'samo ako postoji i u DB tabeli
                    If ind > -1 Then
                        selectedColumnsExcel = selectedColumnsExcel + lbColumnsInExcel.Items(i).ToString.Trim + ","
                    End If
                End If
            Next i
            selectedcolumnsInExcelArray = selectedColumnsExcel.Trim.ToUpper.Split(",")
        End If

        Dim presek() As String = newintersectString(selectedcolumnsInExcelArray, columnsInDBArray)

        If presek.Length = 0 Then
            removeFromLBExcel = 0
        Else

            Dim str As String = ""

            For i As Integer = 0 To columnsInExcelArray.GetUpperBound(0)
                str = columnsInExcelArray(i)
                Dim ind As Integer = Array.IndexOf(columnsInDBArray, str.Trim.ToUpper)   'samo ako postoji i u DB tabeli
                If ind < 0 Then lbColumnsInExcel.Items.Remove(str.Trim.ToUpper)
            Next
            For i As Integer = 0 To columnsUB.GetUpperBound(0)
                str = columnsUB(i)
                Dim ind As Integer = Array.IndexOf(columnsInDBArray, str.Trim.ToUpper)   'samo ako postoji i u DB tabeli
                If ind < 0 Then lbUB.Items.Remove(str.Trim.ToUpper)
            Next

            If lbColumnsInExcel.Items.Count = 0 Then
                removeFromLBExcel = 0
            End If

        End If
    End Function
    Sub addToLB(ByVal dtExcel99 As DataTable)

        With lbUB.Items
            .Clear()
        End With
        With lbColumnsInExcel.Items
            .Clear()
        End With
        Dim str As String = ""

        For i As Integer = 0 To dtExcel99.Columns.Count - 1
            str = dtExcel99.Columns(i).Caption
            lbColumnsInExcel.Items.Add(str.Trim.ToUpper)
            'ADF dodaj samo one koje se slaži ako je izabrana postojeća tabela
            lbUB.Items.Add(str.Trim.ToUpper)
        Next


    End Sub

    Function removeEmptyRows(dt As DataTable) As DataTable
        For i As Integer = dt.Rows.Count - 1 To 0 Step -1
            Dim row As DataRow = dt.Rows(i)
            Dim izbaci As Boolean = True
            For k As Integer = 0 To dt.Columns.Count - 1
                If Not row.Item(k) Is Nothing AndAlso row.Item(k).ToString.Trim <> "" Then
                    izbaci = False
                End If
            Next
            If izbaci = True Then dt.Rows.Remove(row)
        Next
        dt.AcceptChanges()
        Return dt
    End Function
    Private Sub cbSall_CheckedChanged(sender As Object, e As EventArgs) Handles cbSAll.CheckedChanged
        Call checkDeCheckAll()
    End Sub

    Sub checkDeCheckAll()
        If cbSAll.Checked = True Then
            cbSAll.Text = "Deselect all"
            For i As Integer = 0 To lbColumnsInExcel.Items.Count - 1 Step 1
                Me.lbColumnsInExcel.SetSelected(i, True)
            Next
        Else
            cbSAll.Text = "Select all"
            For i As Integer = 0 To lbColumnsInExcel.Items.Count - 1 Step 1
                Me.lbColumnsInExcel.SetSelected(i, False)
            Next
        End If
    End Sub
    Public Shared Function exceldataOLEDB(filePath As String) As DataTable
        Dim dtexcel As New DataTable()
        Dim hasHeaders As Boolean = False
        Dim HDR As String = If(hasHeaders, "Yes", "No")
        Dim strConn As String
        If filePath.Substring(filePath.LastIndexOf("."c)).ToLower() = ".xlsx" Then
            strConn = (Convert.ToString((Convert.ToString("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=") & filePath) + ";Extended Properties=""Excel 12.0;HDR=") & HDR) + ";IMEX=0"""
        Else
            strConn = (Convert.ToString((Convert.ToString("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=") & filePath) + ";Extended Properties=""Excel 8.0;HDR=") & HDR) + ";IMEX=0"""
        End If
        Dim conn As New OleDbConnection(strConn)
        conn.Open()
        Dim schemaTable As DataTable = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})

        Dim schemaRow As DataRow = schemaTable.Rows(0)
        Dim sheet As String = schemaRow("TABLE_NAME").ToString()
        If Not sheet.EndsWith("_") Then
            Dim query As String = "SELECT  * FROM [" + sheet + "]"
            Dim daexcel As New OleDbDataAdapter(query, conn)
            dtexcel.Locale = CultureInfo.CurrentCulture
            daexcel.Fill(dtexcel)
        End If

        conn.Close()
        Return dtexcel

    End Function

    Public Shared Function exceldata(filePath As String) As DataTable
        exceldata = Nothing
        Dim dtexcel As New DataTable()
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        Dim oWB As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim oRng As Microsoft.Office.Interop.Excel.Range = Nothing
        Dim oXL As Office.Interop.Excel.Application = New Office.Interop.Excel.Application()
        oWB = oXL.Workbooks.Open(filePath, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value)

        For Each oSheet As Microsoft.Office.Interop.Excel.Worksheet In oWB.Sheets
            Dim dt As System.Data.DataTable = New System.Data.DataTable(oSheet.Name)
            Dim dr As DataRow
            Dim jValue As Integer = oSheet.UsedRange.Cells.Columns.Count
            Dim iValue As Integer = oSheet.UsedRange.Cells.Rows.Count
            For j As Integer = 1 To jValue
                Dim strColValue As String = oSheet.Cells(1, j).Text.ToString()
                dt.Columns.Add(strColValue, System.Type.[GetType]("System.String"))
            Next
            For i As Integer = 2 To iValue
                dr = dt.NewRow
                For j As Integer = 1 To jValue
                    Dim strColValue As String = oSheet.Cells(1, j).Text.ToString()
                    Dim strValue As String = oSheet.Cells(i, j).Text.ToString()
                    dr.Item(strColValue) = strValue
                Next
                dt.Rows.Add(dr)
            Next
            Return dt
            Exit For
        Next

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

    End Function

    Sub DajTabelePolja(ByVal DBConnectionString As String)

        Dim strSQl As String = " use " + pravaBaza + " Select TABLE_SCHEMA +'.'+TABLE_NAME as NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' order by 1"

        Dim dt As New DataTable
        Dim str As String = ""
        lbDBTables.Items.Clear()
        dt = izvrsiSQLvratiDT(strSQl, DBConnectionString, "")
        For i As Integer = 0 To dt.Rows.Count - 1
            str = dt.Rows(i).Item("NAME").ToString
            lbDBTables.Items.Add(str)
        Next

        lbDBTables.Visible = True

    End Sub

    Private Sub lbtabele_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbDBTables.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor

        Dim tn As String = lbDBTables.SelectedItem.trim.toupper

        Dim strSQl As String = " use " + pravaBaza + " SELECT NAME as columnName FROM sys.columns WHERE object_id = OBJECT_ID('" + tn + "')  "
        Dim pk() As String = dajKljuc(tn)
        Dim indx As Integer = -1

        Dim dt As New DataTable
        Dim str As String = ""
        lbColumnsInDB.Items.Clear()
        dt = izvrsiSQLvratiDT(strSQl, DBConnectionString, "")

        For i As Integer = 0 To dt.Rows.Count - 1
            str = dt.Rows(i).Item("columnName").ToString
            lbColumnsInDB.Items.Add(str.Trim.ToUpper)
            If Not pk Is Nothing Then indx = Array.IndexOf(pk, str.Trim.ToUpper)
            If indx >= 0 Then
                lbColumnsInDB.SetSelected(i, True)
            End If
        Next

        lbColumnsInDB.Visible = True

        Dim r As Integer = removeFromLBExcel(1)
        If r = 0 Then
            'nema istih u izabranoj tabeli
            ISTMessageBox.Show("There is no matched columns in Excel file and in chosen DB table!")
        End If

        lbColumnsInExcel.Visible = True
        Me.lblCol.Visible = True
        Me.cbSAll.Visible = True
        Me.cbSAll.Checked = True


        If r > 0 Then
            Call joinAllByName()
            Call checkDeCheckAll()
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Sub DeCheckAll(ByVal lb As ListBox)

        For i As Integer = 0 To lb.Items.Count - 1 Step 1
            lb.SetSelected(i, False)
        Next

    End Sub

    Sub joinAllByName()

        Dim imeE As String = ""
        Dim ime As String = ""
        For i As Integer = 0 To lbColumnsInDB.Items.Count - 1
            lbColumnsInDB.SetSelected(i, True)
        Next i
        'For i As Integer = 0 To lbExcel.Items.Count - 1
        If lbColumnsInExcel.Items.Count <> lbColumnsInDB.Items.Count Then
            'ISTMessageBox.Show("Number of columns in table and in excel file are not the same!")
            'samo selectovane
            Dim r As Integer = removeFromLBExcel(0)
            If r = 0 Then
                'nema istih u izabranoj tabeli
                ISTMessageBox.Show("There is no matched columns in Excel file and in chosen DB table!")
                Exit Sub
            End If
        End If

        For i As Integer = 0 To lbColumnsInDB.Items.Count - 1 Step 1
            Me.lbColumnsInDB.SetSelected(i, False)
        Next

        For i As Integer = 0 To lbColumnsInExcel.Items.Count - 1
            If lbColumnsInExcel.GetSelected(i) = True Then
                imeE = lbColumnsInDB.Items(i).ToString.Trim.ToUpper
                For ii As Integer = 0 To lbColumnsInDB.Items.Count - 1
                    ime = lbColumnsInDB.Items(ii).ToString.Trim.ToUpper
                    If ime = imeE Then
                        lbColumnsInDB.SetSelected(ii, True)
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    'Private Sub cbJoinAll_CheckedChanged(sender As Object, e As EventArgs) Handles cbJoinAll.CheckedChanged

    '    Try
    '        If cbJoinAll.Checked = True Then

    '            lbColumnsInExcel.DrawMode = DrawMode.Normal
    '            lbColumnsInDB.DrawMode = DrawMode.Normal

    '            cbJoin.Checked = False
    '            tbJoin.Visible = False
    '            tbJoin.Text = ""

    '            Call joinAllByName()

    '        End If
    '    Catch ex As Exception
    '        ISTMessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Function dajKljuc(ByVal tn As String) As String()
        dajKljuc = Nothing
        Dim strSQl As String = " use " + pravaBaza + " select ccu.COLUMN_NAME as columnname " +
        " From INFORMATION_SCHEMA.TABLE_CONSTRAINTS tc" +
        " Join INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE ccu ON tc.CONSTRAINT_NAME = ccu.Constraint_name" +
        " Where tc.TABLE_SCHEMA +'.'+ tc.TABLE_NAME='" + tn.Trim + "' and tc.CONSTRAINT_TYPE = 'Primary Key'"
        Dim str As String = ""
        Dim dtpk As New DataTable
        dtpk = izvrsiSQLvratiDT(strSQl, DBConnectionString, "")

        Dim m As String = ""
        If dtpk.Rows.Count > 0 Then
            For i As Integer = 0 To dtpk.Rows.Count - 1
                m = m + dtpk.Rows(i).Item("columnname").ToString.Trim.ToUpper + ","
            Next
            m = m + "," : m = m.Replace(",,", "")
            m = m.Trim.ToUpper
            Dim mm() As String = m.Split(",")
            dajKljuc = mm
        End If
    End Function

    Sub importRows(ByVal dt As DataTable, ByVal tn As String)
        cbJoinAll.Checked = True
        Dim mm() As String = dajKljuc(tn)
        If Not mm Is Nothing AndAlso mm.Length > 0 Then
            'ima kljuc
            Call tztzt(dt, tn, mm)
        Else
            Call tztzt(dt, tn)
        End If
    End Sub
    Function getArrayFromLB(ByVal lb As ListBox) As String()
        Dim niz() As String = New String(lb.Items.Count - 1) {}
        lb.Items.CopyTo(niz, 0)
        Return niz
    End Function
    Sub tztzt(ByVal dtExcel As DataTable, ByVal tn As String, Optional ByVal pkcolumnsInDBArray() As String = Nothing)

        Dim sqlI As String = ""

        Dim selectedColumnsExcel As String = ""
        Dim columnsInDBArray() As String = getArrayFromLB(lbColumnsInDB)
        'podrazumeva se da je cbJoinAll.Checked = True  za sad

        For i As Integer = 0 To lbColumnsInExcel.Items.Count - 1
            If lbColumnsInExcel.GetSelected(i) = True Then
                Dim ind As Integer = Array.IndexOf(columnsInDBArray, lbColumnsInExcel.Items(i).ToString.Trim.ToUpper)   'samo ako postoji i u DB tabeli
                If ind > -1 Then
                    selectedColumnsExcel = selectedColumnsExcel + lbColumnsInExcel.Items(i).ToString.Trim + ","
                End If
            End If
        Next i

        Dim columnsInExcelArray() As String = getArrayFromLB(lbColumnsInExcel)
        Dim selectedcolumnsInExcelArray() As String = selectedColumnsExcel.Trim.ToUpper.Split(",")
        Dim presekPK() As String = {}
        If Not pkcolumnsInDBArray Is Nothing Then
            presekPK = newintersectString(selectedcolumnsInExcelArray, pkcolumnsInDBArray)
            If presekPK.Length = 0 Then
                ISTMessageBox.Show("There is no column in Excel file that is primary key in DB table!")
                Exit Sub
            End If
        End If

        Dim presek() As String = newintersectString(selectedcolumnsInExcelArray, columnsInDBArray)

        If presek.Length = 0 Then
            ISTMessageBox.Show("There is no same columns in selected Excel file columns and chosen DB table!")
            Exit Sub
        Else

            Dim preskoci As Boolean = False
            For r As Integer = 0 To dtExcel.Rows.Count - 1
                Dim sqlPK As String = ""
                preskoci = False
                If Not pkcolumnsInDBArray Is Nothing Then
                    For i As Integer = 0 To pkcolumnsInDBArray.GetUpperBound(0)
                        Dim pkcolumnname As String = pkcolumnsInDBArray(i).ToString.Trim
                        Try
                            Dim pkcolumnvalue As String = dtExcel.Rows(r).Item(pkcolumnname).ToString.Trim
                            If pkcolumnvalue <> "" Then
                                sqlPK = sqlPK + "BEGIN " + nvrd + " If NOT EXISTS(SELECT * FROM " + tn.Trim + "" + " WHERE 2=2 and"
                                sqlPK = sqlPK + " " + pkcolumnname + " = N'" + pkcolumnvalue + "' and"
                                sqlPK = sqlPK + "," : sqlPK = sqlPK.Replace("and,", "")
                                sqlPK = sqlPK + ")" + nvrd

                                Dim columnValue As String = ""
                                Dim columnName As String = ""
                                For p As Integer = 0 To presek.GetUpperBound(0)
                                    columnValue = columnValue + "N'" + dtExcel.Rows(r).Item(presek(p)).ToString.Trim.Replace("'", "''") + "',"
                                    columnName = columnName + "" + presek(p) + ","
                                Next

                                columnValue = columnValue.TrimEnd(",")
                                columnName = columnName.TrimEnd(",")

                                sqlI = sqlI + sqlPK + nvrd + "BEGIN " + nvrd + " insert into " + tn + "(" + columnName.Trim + ") values (" + columnValue.Trim + ");" + nvrd + "END;"
                                sqlI = sqlI + nvrd + "END;"
                                sqlI = sqlI + nvrd

                            End If
                        Catch ex As Exception
                            ISTMessageBox.Show("Column " + pkcolumnname + " does not exists in Excel file!")
                        End Try
                    Next
                Else
                    Dim columnValue As String = ""
                    Dim columnName As String = ""
                    For p As Integer = 0 To presek.GetUpperBound(0)
                        columnValue = columnValue + "N'" + dtExcel.Rows(r).Item(presek(p)).ToString.Trim.Replace("'", "''") + "',"
                        columnName = columnName + "" + presek(p) + ","
                    Next

                    columnValue = columnValue.TrimEnd(",")
                    columnName = columnName.TrimEnd(",")

                    sqlI = sqlI + sqlPK + nvrd + "BEGIN " + nvrd + " insert into " + tn + "(" + columnName.Trim + ") values (" + columnValue.Trim + ");" + nvrd + "END;"
                    sqlI = sqlI + nvrd
                End If
            Next
        End If

        Dim sqlKon As String = "begin transaction;" + nvrd + sqlI + nvrd + "commit;"
        Call izvrsiiPonisti(sqlKon, tn)
    End Sub

    Private Sub cbExisting_CheckedChanged(sender As Object, e As EventArgs) Handles cbExisting.CheckedChanged

        Me.ButtonCreateImport.Visible = True
        Me.Cursor = Cursors.WaitCursor
        If cbExisting.Checked = True Then
            Me.ButtonCreateImport.Text = "Import"
            Me.cbNew.Checked = False
            Call DajTabelePolja(DBConnectionString)
        Else
            Me.ButtonCreateImport.Text = "Create"
            lbColumnsInDB.Items.Clear()
            lbColumnsInDB.Visible = False
            lbDBTables.Items.Clear()
            lbDBTables.Visible = False
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cbNew_CheckedChanged(sender As Object, e As EventArgs) Handles cbNew.CheckedChanged

        Me.ButtonCreateImport.Visible = True
        If cbNew.Checked = True Then
            Me.ButtonCreateImport.Text = "Create and import"
            Me.tbTableName.Visible = True
            Me.lbUB.Focus()

            Me.lbUB.Visible = True
            Me.lblTN.Visible = True
            Me.lblUB.Visible = True
            Me.lblCol.Visible = True

            lbColumnsInExcel.Visible = True

            Me.cbShema.Visible = True
            Me.cbShema.Checked = False

            Me.cbExisting.Checked = False

            Me.cbSAll.Checked = True
            Me.cbSAll.Visible = True

            Me.cbJoin.Checked = False
            Me.cbJoinAll.Checked = False

            Me.cbJoin.Visible = False
            Me.cbJoinAll.Visible = False

            Call checkDeCheckAll()


            Me.lbUB.Height = Me.lbColumnsInExcel.Height
            Me.lbColumnsInDB.Height = Me.lbColumnsInExcel.Height
            Me.lbDBTables.Height = Me.lbColumnsInExcel.Height

        Else
            Me.ButtonCreateImport.Text = "Import"
            Me.tbTableName.Visible = False
            Me.tbTableName.Text = ""
            Me.tbShemaName.Visible = False
            Me.tbShemaName.Text = ""

            Me.lbUB.Visible = False
            Me.lblTN.Visible = False
            Me.lblUB.Visible = False
            Me.lblCol.Visible = True

            'podrazumeva se da je Me.cbJoinAll.Checked = true  , tj nije odrađen deo da se spaja a da imena nisu ista

            lbColumnsInExcel.Visible = True

            Me.cbSAll.Checked = True
            Me.cbSAll.Visible = True

            Me.cbShema.Checked = False
            Me.cbShema.Visible = False

            Call checkDeCheckAll()
        End If
    End Sub


    Private Sub tbTableName_GotFocus(sender As Object, e As EventArgs) Handles tbTableName.GotFocus
        tbTableName.BackColor = Color.Beige
    End Sub

    Private Sub tbTableName_LostFocus(sender As Object, e As EventArgs) Handles tbTableName.LostFocus
        tbTableName.BackColor = SystemColors.ControlLightLight
    End Sub

    Private Sub tbShemaName_GotFocus(sender As Object, e As EventArgs) Handles tbShemaName.GotFocus
        tbShemaName.BackColor = Color.Beige
    End Sub

    Private Sub tbShemaName_LostFocus(sender As Object, e As EventArgs) Handles tbShemaName.LostFocus
        tbShemaName.BackColor = SystemColors.ControlLightLight
    End Sub

    Private Sub ButtonCreateImport_Click(sender As Object, e As EventArgs) Handles ButtonCreateImport.Click
        Me.Cursor = Cursors.WaitCursor
        Try

            If lbColumnsInExcel.SelectedIndex = -1 Then
                ISTMessageBox.Show("No excel column Is checked!")
                Me.lbColumnsInExcel.Focus()
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If cbNew.Checked = True Then
                If Me.tbTableName.Text.Trim = "" Then
                    ISTMessageBox.Show("Table name Is required field!")
                    Me.tbTableName.Focus()
                    Me.Cursor = Cursors.Default
                    Exit Sub
                End If

                Call srediLB()

                Dim tn As String = Me.tbTableName.Text.Trim
                Dim sn As String = Me.tbShemaName.Text.Trim
                If sn = "" Then sn = "dbo"
                If sn <> "dbo" Then
                    Dim sqlSN As String = "If Not EXISTS( SELECT  * From sys.schemas where Name = N'" + sn + "') " + nvrd +
                   "EXEC('CREATE SCHEMA [" + sn + "] AUTHORIZATION [dbo]'); " '+ nvrd +
                    '"GO"
                    Dim ok1 As String = izvrsiSQL(sqlSN, Me.DBConnectionString)
                    If ok1 <> "ok" Then
                        ISTMessageBox.Show(sqlSN + nvrd + nvrd + "is not executed! ER43", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If

                If tableExists("[" + sn + "].[" + tn + "]") = False Then
                    Dim sql As String = dajSQL(dtExcel99, sn, tn)
                    Dim sqlKon As String = "begin transaction;" + nvrd + sql + nvrd + "commit;"
                    Call izvrsiiPonisti(sqlKon, "[" + sn + "].[" + tn + "]")
                Else
                    'da brisem ili drugo ime
                    Dim dr As DialogResult
                    dr = ISTMessageBox.Show("Table exists." + nvrd + nvrd + " Delete existing table?", "...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    If dr = DialogResult.Yes Then
                        Dim sql As String = dajSQL(dtExcel99, sn, tn)
                        Dim sqlDrop As String = "drop table [" + sn + "].[" + tn + "]"

                        Dim ok1 As String = izvrsiSQL(sqlDrop, Me.DBConnectionString)
                        If ok1 <> "ok" Then
                            ISTMessageBox.Show(sqlDrop + nvrd + nvrd + "is not executed! ER42", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If

                        Dim sqlKon As String = "begin transaction;" + nvrd + sql + nvrd + "commit;"
                        Call izvrsiiPonisti(sqlKon, "[" + sn + "].[" + tn + "]")
                    Else

                        Me.tbTableName.Focus()
                    End If
                End If
            End If

            If cbExisting.Checked = True Then
                Dim tn As String = lbDBTables.SelectedItem.trim.toupper
                Try
                    Call importRows(dtExcel99, tn)
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Call End_App("EXCEL", dateStart, Date.Now, False)

        Me.Cursor = Cursors.Default
    End Sub

    Function brS(ByVal tn As String) As String
        Dim dtt As DataTable = izvrsiSQLvratiDT("select count (*) from " + tn + " ", DBConnectionString, Nothing)
        brS = dtt.Rows(0).Item(0).ToString.Trim
    End Function
    Sub izvrsiiPonisti(ByVal sqlkon As String, ByVal tn As String)
        'Dim sqlkonPom As String = sqlkon.Replace(vbCrLf, " ")
        'Dim words() As String = sqlkonPom.Split(New Char() {" ", ",", ".", ";"}) ' add other punctuation as appropriate 
        'Dim countInsert = words.Count(Function(word) word = "insert")

        Dim countInsert As Long = dtExcel99.Rows.Count
        Dim BrSlInitial As String = "0"
        If tableExists(tn) = True Then
            BrSlInitial = brS(tn)
        End If

        Dim okok As String = izvrsiSQL(sqlkon, DBConnectionString)
        If okok <> "ok" Then
            Exit Sub
        End If

        Dim BrSEnd As String = brS(tn)
        Dim imported As String = CStr(CInt(BrSEnd) - CInt(BrSlInitial)).Trim
        Dim notImported As String = CStr(CInt(countInsert) - CInt(imported)).Trim

        If okok = "ok" Then
            If sqlkon.Trim.ToUpper.IndexOf("INSERT") > 0 Then
                ISTMessageBox.Show("Import is done!" + nvrd + nvrd +
                    "Number of records in  chosen DB table before insert: " + CStr(BrSlInitial).Trim + " " + nvrd + nvrd +
                    "Number of records in Excel file: " + CStr(countInsert).Trim + " " + nvrd + nvrd +
                    "Number of imported records: " + Str(imported).Trim + " " + nvrd + nvrd +
                    "Number of records that are not imported: " + Str(notImported).Trim + " " + nvrd + nvrd +
                    "Number of records in chosen DB table after insert: " + Str(BrSEnd).Trim + " " + nvrd + nvrd +
                    "Remark: Only distinct records are imported" + nvrd +
                    "(by primary key, if primary key exists in chosen DB table)")
            End If
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Imported " + Str(imported).Trim + " records from Excel file ", lblPath.Text, "to:" + lblBaza.Text + "." + tn)

        Else
            ISTMessageBox.Show("Something is wrong, import is not done!")
        End If

        Me.cbNew.Checked = False
        Me.cbNew.Visible = False

        Me.cbExisting.Checked = False
        Me.cbExisting.Visible = False

        Me.cbShema.Checked = False
        Me.cbShema.Visible = False

        Me.cbJoin.Checked = False
        Me.cbJoin.Visible = False

        Me.cbJoinAll.Checked = False
        Me.cbJoinAll.Visible = False

        Me.cbSAll.Checked = False
        Me.cbSAll.Visible = False

        lbColumnsInExcel.Visible = False
        lblPath.Visible = False
        Me.ButtonCreateImport.Visible = False
        Me.tbTableName.Visible = False
        Me.lbUB.Visible = False
        Me.lblTN.Visible = False
        Me.lblUB.Visible = False
        Me.lblCol.Visible = False

        lbColumnsInDB.Visible = False
        lbDBTables.Visible = False

        Me.cbOLEDB.Checked = True

    End Sub
    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, ByVal excelpath As String, ByVal baza As String)
        Dim computerName As String = System.Environment.MachineName
        Dim sifist As String = Me.sifist
        Dim god As String = Me.tacv.G.ToString
        Dim mes As String = String.Format("{0:d2}", Me.tacv.M)
        Dim excelFile As String = computerName + " " + excelpath
        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
        & "(sifist,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
        & " values( " _
        & "N'" & sifist & "','" & god & "','" & mes & "'," _
        & "N'" & proces.Replace("'", "") & "',left(N'" + excelFile.Replace("'", "") & "',250), left(N'" + baza.Trim.Replace("'", "") & "',250)," _
        & "N'" & GetUserName.ToString.Trim & "'," _
        & "" & "(select top 1 GETDATE())" & ");" + nvrd

        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)

        Dim ok1 As String = izvrsiSQL(strSQL, konDepo)
        If ok1 = "nok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER79", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Sub srediLB()
        For i As Integer = 0 To lbUB.Items.Count - 1
            If lbUB.GetSelected(i) = True Then
                For ii As Integer = 0 To lbColumnsInExcel.Items.Count - 1
                    If ii = i Then lbColumnsInExcel.SetSelected(ii, True)
                Next ii
            End If
        Next i
    End Sub

    Function dajSQL(ByVal dt As DataTable, ByVal sn As String, ByVal tn As String) As String


        dajSQL = ""

        Dim nnull As String = " NULL,"
        Dim notnnull As String = " Not  NULL,"
        Dim ttip As String = " [nvarchar](255)"
        Dim sqlI As String = ""
        Dim sql As String = ""
        Dim sqlM As String = ""
        Dim sqlstart As String = "create table [" + sn + "].[" + tn + "]( "

        For i As Integer = 0 To lbUB.Items.Count - 1
            If lbUB.GetSelected(i) = True Then
                sqlM = sqlM + "[" + lbUB.Items(i).ToString.Trim + "]" + ttip + notnnull + nvrd
            End If
        Next i
        Dim columnName As String = ""
        For i As Integer = 0 To lbColumnsInExcel.Items.Count - 1
            If lbColumnsInExcel.GetSelected(i) = True Then
                If sqlM.IndexOf("[" + lbColumnsInExcel.Items(i).ToString.Trim + "]") < 0 Then
                    sqlM = sqlM + "[" + lbColumnsInExcel.Items(i).ToString.Trim + "]" + ttip + nnull + nvrd
                End If
                columnName = columnName + lbColumnsInExcel.Items(i).ToString.Trim + ","
            End If
        Next i

        Dim pk As String = "PRIMARY KEY("
        Dim ssort As String = ""
        For i As Integer = 0 To lbUB.Items.Count - 1
            If lbUB.GetSelected(i) = True Then
                pk = pk + lbUB.Items(i).ToString.Trim + ","
                ssort = ssort + lbUB.Items(i).ToString.Trim + " desc,"
            End If
        Next i
        If lbUB.SelectedIndex > -1 Then
            pk = (pk + ")").Replace(",)", ")")
            ssort = (ssort + "#").Replace(",#", "")
        Else
            sqlM = (sqlM + "##").Replace("," + nvrd + "##", "")
            pk = ""
        End If
        Dim oo As String() = ssort.Trim.ToUpper.Replace("DESC", "").Replace(" ", "").Split(",")
        sql = sqlstart + nvrd + sqlM + pk + nvrd + ");"

        Try
            If Not dt Is Nothing Then
                If lbUB.SelectedIndex > -1 Then
                    Dim dv As DataView = dt.DefaultView
                    dt = EliminateDuplicates(dt, ssort, oo)
                End If

                If sql <> "" Then
                    Dim columnValue As String = ""
                    For r As Integer = 0 To dt.Rows.Count - 1
                        columnValue = ""
                        For k As Integer = 0 To dt.Columns.Count - 1
                            If columnName.Trim.ToUpper.IndexOf(dt.Columns(k).Caption.Trim.ToUpper + ",") >= 0 Then
                                columnValue = columnValue + "N'" + dt.Rows(r).Item(k).ToString.Trim.Replace("'", "''") + "',"
                            End If
                        Next
                        sqlI = sqlI + "insert into [" + sn + "].[" + tn + "](" + (columnName.Trim + "#").Trim.Replace(",#", "") + ") values (" + (columnValue.Trim + "#").Trim.Replace(",#", "") + ");" + nvrd
                    Next
                End If
            End If
            dajSQL = sql + nvrd + sqlI
        Catch ex As Exception
        End Try
    End Function

    Function tableExists(ByVal tn As String) As Boolean
        tn = tn.Replace("[", "").Replace("]", "")
        Dim pp() As String = tn.Split(".")

        If pp.Length >= 2 Then
            Dim ostatak As String = ""
            For i As Integer = 1 To pp.GetUpperBound(0)
                ostatak = ostatak + "[" + pp(i) + "]" + "."
            Next
            ostatak = ostatak.TrimEnd(".")
            tn = "[" + pp(0).Trim + "]." + ostatak
        ElseIf pp.Length = 1 Then
            tn = "[dbo].[" + pp(0).Trim + "]"
        End If


        tableExists = False
        Dim strSQl As String = " use " + pravaBaza + " select '['+TABLE_SCHEMA +'].['+TABLE_NAME +']' AS NAME FROM INFORMATION_SCHEMA.TABLES" +
        " WHERE TABLE_TYPE='BASE TABLE' AND  '['+TABLE_SCHEMA +'].['+TABLE_NAME +']'='" + tn.Trim + "'"
        Dim dtm As New DataTable
        Dim str As String = ""
        dtm = izvrsiSQLvratiDT(strSQl, DBConnectionString, "")

        If dtm.Rows.Count > 0 Then tableExists = True

    End Function

    Function EliminateDuplicates(ByVal dt1 As DataTable, ByVal ssort As String, ByVal oo() As String) As DataTable
        Dim dtpm As DataTable = Nothing
        Dim r As Integer, c As Integer

        Dim bdelete() As Integer = {}
        ReDim Preserve bdelete(oo.GetUpperBound(0))

        'brisi prazne
        For r = dt1.Rows.Count - 1 To 1 Step -1
            For c = 0 To oo.GetUpperBound(0)
                If dt1.Rows(r).Item(oo(c)).ToString.Trim.ToUpper = "" Then
                    dt1.Rows(r).Delete()
                    Exit For
                End If
            Next c
        Next

        dt1.DefaultView.Sort = ssort
        dtpm = dt1.DefaultView.ToTable

        For r = dtpm.Rows.Count - 1 To 1 Step -1
            Dim ss As Integer = 0
            For c = 0 To oo.GetUpperBound(0)
                If dtpm.Rows(r).Item(oo(c)).ToString.Trim.ToUpper = dtpm.Rows(r - 1).Item(oo(c)).ToString.Trim.ToUpper Then
                    bdelete(c) = 1
                    ss = ss + bdelete(c)
                End If
            Next c
            If ss = oo.Length Then dtpm.Rows(r).Delete()
        Next
        Return dtpm
    End Function

    Private Sub cbShema_CheckedChanged(sender As Object, e As EventArgs) Handles cbShema.CheckedChanged
        If cbShema.Checked = True Then

            Me.tbShemaName.Visible = True
            lblSN.Visible = True
            Me.tbShemaName.Focus()
        Else
            Me.tbShemaName.Text = ""
            Me.tbShemaName.Visible = False
            lblSN.Visible = False
        End If
    End Sub

    Private Class ListBoxScroll
        Inherits NativeWindow

        Private Const WM_VSCROLL = &H115

        Public Event Scrolled()

        Public Sub New(ByVal lb As ListBox)
            Me.AssignHandle(lb.Handle)
        End Sub

        Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
            If m.Msg = WM_VSCROLL Then
                RaiseEvent Scrolled()
            End If

            MyBase.WndProc(m)
        End Sub

    End Class

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Call End_App("EXCEL", dateStart, Date.Now, False)
        Me.Close()
    End Sub


    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class