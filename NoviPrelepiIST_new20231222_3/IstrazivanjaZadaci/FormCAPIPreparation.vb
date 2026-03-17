Option Strict Off

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class FormCAPIPreparation
    'Inherits FormTemplate
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

    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents GBLapTop As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSQLTxt As CheckBox
    Friend WithEvents cbVF As CheckBox
    Friend WithEvents cbABook As CheckBox
    Friend WithEvents cbInsertData As CheckBox
    Friend WithEvents cbTables As CheckBox
    Friend WithEvents cbDB As CheckBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents GBCAPIServer As GroupBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents cbRBat As CheckBox
    Friend WithEvents cbTBat As CheckBox
    Friend WithEvents cbSlanje As CheckBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents gbxISTMeta As GroupBox
    Friend WithEvents cbISTReportsProcedures As CheckBox
    Friend WithEvents cbISTRulesLogicalControl As CheckBox
    Friend WithEvents cbISTTablesColumns As CheckBox
    Friend WithEvents cbISTTables As CheckBox
    Friend WithEvents lblISTRulesLogicalControl As Label
    Friend WithEvents lblISTReportsProcedures As Label
    Friend WithEvents lblISTTablesColumns As Label
    Friend WithEvents lblSTTables As Label
    Friend WithEvents tclCapiPreparation As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Tabpackages As TabPage
    Friend WithEvents dgvPackages As DataGridView
    Friend WithEvents cbPackages As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSavePackages As Button
    Friend WithEvents dgvTest As DataGridView
    Friend WithEvents ButtonUradi As Button
    Friend WithEvents ButtonUradi2 As Button
    Friend WithEvents ButtonISTMeta As Button
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCAPIPreparation))
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.GBLapTop = New System.Windows.Forms.GroupBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonUradi = New System.Windows.Forms.Button()
        Me.cbSQLTxt = New System.Windows.Forms.CheckBox()
        Me.cbVF = New System.Windows.Forms.CheckBox()
        Me.cbABook = New System.Windows.Forms.CheckBox()
        Me.cbInsertData = New System.Windows.Forms.CheckBox()
        Me.cbTables = New System.Windows.Forms.CheckBox()
        Me.cbDB = New System.Windows.Forms.CheckBox()
        Me.GBCAPIServer = New System.Windows.Forms.GroupBox()
        Me.ButtonUradi2 = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.cbRBat = New System.Windows.Forms.CheckBox()
        Me.cbTBat = New System.Windows.Forms.CheckBox()
        Me.cbSlanje = New System.Windows.Forms.CheckBox()
        Me.gbxISTMeta = New System.Windows.Forms.GroupBox()
        Me.ButtonISTMeta = New System.Windows.Forms.Button()
        Me.lblISTRulesLogicalControl = New System.Windows.Forms.Label()
        Me.lblISTReportsProcedures = New System.Windows.Forms.Label()
        Me.lblISTTablesColumns = New System.Windows.Forms.Label()
        Me.lblSTTables = New System.Windows.Forms.Label()
        Me.cbISTReportsProcedures = New System.Windows.Forms.CheckBox()
        Me.cbISTRulesLogicalControl = New System.Windows.Forms.CheckBox()
        Me.cbISTTablesColumns = New System.Windows.Forms.CheckBox()
        Me.cbISTTables = New System.Windows.Forms.CheckBox()
        Me.tclCapiPreparation = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Tabpackages = New System.Windows.Forms.TabPage()
        Me.dgvTest = New System.Windows.Forms.DataGridView()
        Me.btnSavePackages = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPackages = New System.Windows.Forms.DataGridView()
        Me.cbPackages = New System.Windows.Forms.ComboBox()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBLapTop.SuspendLayout()
        Me.GBCAPIServer.SuspendLayout()
        Me.gbxISTMeta.SuspendLayout()
        Me.tclCapiPreparation.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Tabpackages.SuspendLayout()
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPackages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucvt
        '
        Me.ucvt.BackColor = System.Drawing.SystemColors.Control
        Me.ucvt.Enabled = False
        Me.ucvt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvt.ForeColor = System.Drawing.Color.DarkRed
        Me.ucvt.Location = New System.Drawing.Point(748, 18)
        Me.ucvt.Name = "ucvt"
        Me.ucvt.Size = New System.Drawing.Size(72, 12)
        Me.ucvt.TabIndex = 6
        Me.ucvt.Visible = False
        '
        'GBLapTop
        '
        Me.GBLapTop.Controls.Add(Me.lbl1)
        Me.GBLapTop.Controls.Add(Me.Label2)
        Me.GBLapTop.Controls.Add(Me.ButtonUradi)
        Me.GBLapTop.Controls.Add(Me.cbSQLTxt)
        Me.GBLapTop.Controls.Add(Me.cbVF)
        Me.GBLapTop.Controls.Add(Me.cbABook)
        Me.GBLapTop.Controls.Add(Me.cbInsertData)
        Me.GBLapTop.Controls.Add(Me.cbTables)
        Me.GBLapTop.Controls.Add(Me.cbDB)
        Me.GBLapTop.Location = New System.Drawing.Point(19, 6)
        Me.GBLapTop.Name = "GBLapTop"
        Me.GBLapTop.Size = New System.Drawing.Size(558, 329)
        Me.GBLapTop.TabIndex = 112
        Me.GBLapTop.TabStop = False
        Me.GBLapTop.Text = "Generation of scripts for mobile device "
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(87, 20)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(359, 19)
        Me.lbl1.TabIndex = 120
        Me.lbl1.Text = "- scripts will be generate on c:\ISTCAPI_ "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(30, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 19)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "(if not exists) on CAPI server for database"
        '
        'ButtonUradi
        '
        Me.ButtonUradi.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonUradi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonUradi.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonUradi.FlatAppearance.BorderSize = 0
        Me.ButtonUradi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUradi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonUradi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonUradi.Location = New System.Drawing.Point(301, 291)
        Me.ButtonUradi.Name = "ButtonUradi"
        Me.ButtonUradi.Size = New System.Drawing.Size(251, 30)
        Me.ButtonUradi.TabIndex = 121
        Me.ButtonUradi.Text = "Generate"
        Me.ButtonUradi.UseVisualStyleBackColor = False
        '
        'cbSQLTxt
        '
        Me.cbSQLTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSQLTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbSQLTxt.Location = New System.Drawing.Point(16, 292)
        Me.cbSQLTxt.Name = "cbSQLTxt"
        Me.cbSQLTxt.Size = New System.Drawing.Size(264, 22)
        Me.cbSQLTxt.TabIndex = 117
        Me.cbSQLTxt.Text = "Copy SQLTxt"
        '
        'cbVF
        '
        Me.cbVF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbVF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbVF.Location = New System.Drawing.Point(16, 222)
        Me.cbVF.Name = "cbVF"
        Me.cbVF.Size = New System.Drawing.Size(481, 22)
        Me.cbVF.TabIndex = 116
        Me.cbVF.Text = "Create views, functions and stored procedures"
        '
        'cbABook
        '
        Me.cbABook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbABook.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbABook.Location = New System.Drawing.Point(16, 187)
        Me.cbABook.Name = "cbABook"
        Me.cbABook.Size = New System.Drawing.Size(264, 22)
        Me.cbABook.TabIndex = 115
        Me.cbABook.Text = "Create insert Adress book"
        '
        'cbInsertData
        '
        Me.cbInsertData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbInsertData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbInsertData.Location = New System.Drawing.Point(16, 152)
        Me.cbInsertData.Name = "cbInsertData"
        Me.cbInsertData.Size = New System.Drawing.Size(264, 22)
        Me.cbInsertData.TabIndex = 114
        Me.cbInsertData.Text = "Create insert data"
        '
        'cbTables
        '
        Me.cbTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbTables.Location = New System.Drawing.Point(16, 85)
        Me.cbTables.Name = "cbTables"
        Me.cbTables.Size = New System.Drawing.Size(391, 22)
        Me.cbTables.TabIndex = 113
        Me.cbTables.Text = "Create tables, check constraints, trigers  "
        '
        'cbDB
        '
        Me.cbDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbDB.Location = New System.Drawing.Point(16, 50)
        Me.cbDB.Name = "cbDB"
        Me.cbDB.Size = New System.Drawing.Size(458, 22)
        Me.cbDB.TabIndex = 112
        Me.cbDB.Text = "Create DB for laptop (do not execute on CAPI server)"
        '
        'GBCAPIServer
        '
        Me.GBCAPIServer.Controls.Add(Me.ButtonUradi2)
        Me.GBCAPIServer.Controls.Add(Me.lbl2)
        Me.GBCAPIServer.Controls.Add(Me.lbl3)
        Me.GBCAPIServer.Controls.Add(Me.cbRBat)
        Me.GBCAPIServer.Controls.Add(Me.cbTBat)
        Me.GBCAPIServer.Controls.Add(Me.cbSlanje)
        Me.GBCAPIServer.Location = New System.Drawing.Point(613, 6)
        Me.GBCAPIServer.Name = "GBCAPIServer"
        Me.GBCAPIServer.Size = New System.Drawing.Size(558, 329)
        Me.GBCAPIServer.TabIndex = 113
        Me.GBCAPIServer.TabStop = False
        Me.GBCAPIServer.Text = "Generation of scripts for transfering data"
        '
        'ButtonUradi2
        '
        Me.ButtonUradi2.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonUradi2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonUradi2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonUradi2.FlatAppearance.BorderSize = 0
        Me.ButtonUradi2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUradi2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonUradi2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonUradi2.Location = New System.Drawing.Point(301, 291)
        Me.ButtonUradi2.Name = "ButtonUradi2"
        Me.ButtonUradi2.Size = New System.Drawing.Size(251, 30)
        Me.ButtonUradi2.TabIndex = 122
        Me.ButtonUradi2.Text = "Generate"
        Me.ButtonUradi2.UseVisualStyleBackColor = False
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(48, 85)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(359, 19)
        Me.lbl2.TabIndex = 121
        Me.lbl2.Text = "from mobile device"
        '
        'lbl3
        '
        Me.lbl3.Location = New System.Drawing.Point(87, 20)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(359, 19)
        Me.lbl3.TabIndex = 120
        Me.lbl3.Text = "- scripts will be generate on c:\ISTCAPI_ "
        '
        'cbRBat
        '
        Me.cbRBat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbRBat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbRBat.Location = New System.Drawing.Point(16, 152)
        Me.cbRBat.Name = "cbRBat"
        Me.cbRBat.Size = New System.Drawing.Size(264, 22)
        Me.cbRBat.TabIndex = 114
        Me.cbRBat.Text = "Create receive BAT file"
        '
        'cbTBat
        '
        Me.cbTBat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTBat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbTBat.Location = New System.Drawing.Point(16, 120)
        Me.cbTBat.Name = "cbTBat"
        Me.cbTBat.Size = New System.Drawing.Size(391, 22)
        Me.cbTBat.TabIndex = 113
        Me.cbTBat.Text = "Create transfer BAT file"
        '
        'cbSlanje
        '
        Me.cbSlanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSlanje.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbSlanje.Location = New System.Drawing.Point(16, 50)
        Me.cbSlanje.Name = "cbSlanje"
        Me.cbSlanje.Size = New System.Drawing.Size(458, 22)
        Me.cbSlanje.TabIndex = 112
        Me.cbSlanje.Text = "Create script for transfering data to central CAPI server"
        '
        'gbxISTMeta
        '
        Me.gbxISTMeta.Controls.Add(Me.ButtonISTMeta)
        Me.gbxISTMeta.Controls.Add(Me.lblISTRulesLogicalControl)
        Me.gbxISTMeta.Controls.Add(Me.lblISTReportsProcedures)
        Me.gbxISTMeta.Controls.Add(Me.lblISTTablesColumns)
        Me.gbxISTMeta.Controls.Add(Me.lblSTTables)
        Me.gbxISTMeta.Controls.Add(Me.cbISTReportsProcedures)
        Me.gbxISTMeta.Controls.Add(Me.cbISTRulesLogicalControl)
        Me.gbxISTMeta.Controls.Add(Me.cbISTTablesColumns)
        Me.gbxISTMeta.Controls.Add(Me.cbISTTables)
        Me.gbxISTMeta.Location = New System.Drawing.Point(19, 402)
        Me.gbxISTMeta.Name = "gbxISTMeta"
        Me.gbxISTMeta.Size = New System.Drawing.Size(558, 189)
        Me.gbxISTMeta.TabIndex = 114
        Me.gbxISTMeta.TabStop = False
        Me.gbxISTMeta.Text = "Refresh IST Meta - copy MetaData from production server to CAPI server"
        '
        'ButtonISTMeta
        '
        Me.ButtonISTMeta.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonISTMeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonISTMeta.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonISTMeta.FlatAppearance.BorderSize = 0
        Me.ButtonISTMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonISTMeta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonISTMeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonISTMeta.Location = New System.Drawing.Point(301, 155)
        Me.ButtonISTMeta.Name = "ButtonISTMeta"
        Me.ButtonISTMeta.Size = New System.Drawing.Size(251, 30)
        Me.ButtonISTMeta.TabIndex = 130
        Me.ButtonISTMeta.Text = "Rewrite"
        Me.ButtonISTMeta.UseVisualStyleBackColor = False
        '
        'lblISTRulesLogicalControl
        '
        Me.lblISTRulesLogicalControl.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblISTRulesLogicalControl.ForeColor = System.Drawing.Color.Red
        Me.lblISTRulesLogicalControl.Location = New System.Drawing.Point(298, 78)
        Me.lblISTRulesLogicalControl.Name = "lblISTRulesLogicalControl"
        Me.lblISTRulesLogicalControl.Size = New System.Drawing.Size(75, 19)
        Me.lblISTRulesLogicalControl.TabIndex = 129
        '
        'lblISTReportsProcedures
        '
        Me.lblISTReportsProcedures.BackColor = System.Drawing.SystemColors.Control
        Me.lblISTReportsProcedures.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblISTReportsProcedures.ForeColor = System.Drawing.Color.Red
        Me.lblISTReportsProcedures.Location = New System.Drawing.Point(298, 106)
        Me.lblISTReportsProcedures.Name = "lblISTReportsProcedures"
        Me.lblISTReportsProcedures.Size = New System.Drawing.Size(75, 19)
        Me.lblISTReportsProcedures.TabIndex = 128
        '
        'lblISTTablesColumns
        '
        Me.lblISTTablesColumns.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblISTTablesColumns.ForeColor = System.Drawing.Color.Red
        Me.lblISTTablesColumns.Location = New System.Drawing.Point(298, 50)
        Me.lblISTTablesColumns.Name = "lblISTTablesColumns"
        Me.lblISTTablesColumns.Size = New System.Drawing.Size(75, 19)
        Me.lblISTTablesColumns.TabIndex = 127
        '
        'lblSTTables
        '
        Me.lblSTTables.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSTTables.ForeColor = System.Drawing.Color.Red
        Me.lblSTTables.Location = New System.Drawing.Point(298, 25)
        Me.lblSTTables.Name = "lblSTTables"
        Me.lblSTTables.Size = New System.Drawing.Size(75, 19)
        Me.lblSTTables.TabIndex = 126
        '
        'cbISTReportsProcedures
        '
        Me.cbISTReportsProcedures.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbISTReportsProcedures.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbISTReportsProcedures.Location = New System.Drawing.Point(29, 109)
        Me.cbISTReportsProcedures.Name = "cbISTReportsProcedures"
        Me.cbISTReportsProcedures.Size = New System.Drawing.Size(264, 22)
        Me.cbISTReportsProcedures.TabIndex = 125
        Me.cbISTReportsProcedures.Text = "IST Reports Procedures"
        '
        'cbISTRulesLogicalControl
        '
        Me.cbISTRulesLogicalControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbISTRulesLogicalControl.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbISTRulesLogicalControl.Location = New System.Drawing.Point(29, 82)
        Me.cbISTRulesLogicalControl.Name = "cbISTRulesLogicalControl"
        Me.cbISTRulesLogicalControl.Size = New System.Drawing.Size(264, 22)
        Me.cbISTRulesLogicalControl.TabIndex = 124
        Me.cbISTRulesLogicalControl.Text = "IST RulesLogical Control"
        '
        'cbISTTablesColumns
        '
        Me.cbISTTablesColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbISTTablesColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbISTTablesColumns.Location = New System.Drawing.Point(29, 55)
        Me.cbISTTablesColumns.Name = "cbISTTablesColumns"
        Me.cbISTTablesColumns.Size = New System.Drawing.Size(264, 22)
        Me.cbISTTablesColumns.TabIndex = 123
        Me.cbISTTablesColumns.Text = "ISTTablesColumns"
        '
        'cbISTTables
        '
        Me.cbISTTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbISTTables.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbISTTables.Location = New System.Drawing.Point(29, 28)
        Me.cbISTTables.Name = "cbISTTables"
        Me.cbISTTables.Size = New System.Drawing.Size(264, 22)
        Me.cbISTTables.TabIndex = 122
        Me.cbISTTables.Text = "ISTTables"
        '
        'tclCapiPreparation
        '
        Me.tclCapiPreparation.Controls.Add(Me.TabPage1)
        Me.tclCapiPreparation.Controls.Add(Me.Tabpackages)
        Me.tclCapiPreparation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tclCapiPreparation.Location = New System.Drawing.Point(0, 40)
        Me.tclCapiPreparation.Name = "tclCapiPreparation"
        Me.tclCapiPreparation.SelectedIndex = 0
        Me.tclCapiPreparation.Size = New System.Drawing.Size(1305, 709)
        Me.tclCapiPreparation.TabIndex = 115
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.GBLapTop)
        Me.TabPage1.Controls.Add(Me.gbxISTMeta)
        Me.TabPage1.Controls.Add(Me.GBCAPIServer)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1297, 682)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'Tabpackages
        '
        Me.Tabpackages.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Tabpackages.Controls.Add(Me.dgvTest)
        Me.Tabpackages.Controls.Add(Me.btnSavePackages)
        Me.Tabpackages.Controls.Add(Me.Label3)
        Me.Tabpackages.Controls.Add(Me.dgvPackages)
        Me.Tabpackages.Controls.Add(Me.cbPackages)
        Me.Tabpackages.Location = New System.Drawing.Point(4, 23)
        Me.Tabpackages.Name = "Tabpackages"
        Me.Tabpackages.Padding = New System.Windows.Forms.Padding(3)
        Me.Tabpackages.Size = New System.Drawing.Size(1297, 682)
        Me.Tabpackages.TabIndex = 1
        Me.Tabpackages.Text = "Packages"
        '
        'dgvTest
        '
        Me.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTest.Location = New System.Drawing.Point(34, 488)
        Me.dgvTest.Name = "dgvTest"
        Me.dgvTest.Size = New System.Drawing.Size(1060, 150)
        Me.dgvTest.TabIndex = 5
        '
        'btnSavePackages
        '
        Me.btnSavePackages.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSavePackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSavePackages.ForeColor = System.Drawing.Color.Black
        Me.btnSavePackages.Location = New System.Drawing.Point(34, 646)
        Me.btnSavePackages.Name = "btnSavePackages"
        Me.btnSavePackages.Size = New System.Drawing.Size(162, 30)
        Me.btnSavePackages.TabIndex = 4
        Me.btnSavePackages.Text = "Save"
        Me.btnSavePackages.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'dgvPackages
        '
        Me.dgvPackages.AllowUserToAddRows = False
        Me.dgvPackages.AllowUserToDeleteRows = False
        Me.dgvPackages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPackages.Location = New System.Drawing.Point(34, 78)
        Me.dgvPackages.Name = "dgvPackages"
        Me.dgvPackages.Size = New System.Drawing.Size(1060, 385)
        Me.dgvPackages.TabIndex = 1
        '
        'cbPackages
        '
        Me.cbPackages.FormattingEnabled = True
        Me.cbPackages.Location = New System.Drawing.Point(34, 44)
        Me.cbPackages.Name = "cbPackages"
        Me.cbPackages.Size = New System.Drawing.Size(325, 22)
        Me.cbPackages.TabIndex = 0
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.ucvt)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1305, 40)
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
        Me.b3.TabIndex = 184
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
        Me.btnMinimizar.Location = New System.Drawing.Point(1222, 0)
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
        Me.btnCerrar.Location = New System.Drawing.Point(1265, 0)
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
        Me.Logovan.Location = New System.Drawing.Point(1013, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormCAPIPreparation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1305, 749)
        Me.Controls.Add(Me.tclCapiPreparation)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormCAPIPreparation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBLapTop.ResumeLayout(False)
        Me.GBCAPIServer.ResumeLayout(False)
        Me.gbxISTMeta.ResumeLayout(False)
        Me.tclCapiPreparation.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Tabpackages.ResumeLayout(False)
        Me.Tabpackages.PerformLayout()
        CType(Me.dgvTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPackages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
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

    Dim DBConnectionString As String
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
    Private m_zadaciIstrazivanje As IstrazivanjeZadaci = Nothing
    Private ReadOnly m_folderProgramaZaUnos As String
    Private ReadOnly Instalacija As String
    Dim dgDT As System.Data.DataTable
    Dim ISTConnectionString As String
    Dim jezik As String
    Dim sifist As String = ""
    Dim folderZaGen As String = ""
    Dim pravaBaza As String
    Dim dtKS As New System.Data.DataTable
    Dim dtGA As New System.Data.DataTable
    Dim dtD As New System.Data.DataTable
    Dim dtGD As New System.Data.DataTable
    Dim CAPIserverName As String
    Dim CAPIserverIPAddress As String
    Dim CAPIconn As String

    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                    ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable,
                    ByVal istPolja As DatasetIstrazivanja.ISTPOLJADataTable,
                    ByVal istLK As DatasetIstrazivanja.ISTLKDataTable,
                    ByVal istBaze As DatasetIstrazivanja.ISTBAZEDataTable,
                    ByVal mmb As DatasetIstrazivanja.ISTBAZERow,
                    ByVal ISTConnectionString As String,
                    ByVal folderZaGen As String,
                    ByVal txtpismo As String, ByVal jezik As String)

        Me.New()

        Me.jezik = jezik
        Call SetLang()
        Me.folderZaGen = folderZaGen
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size

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
        Me.ISTConnectionString = ISTConnectionString

        ucvt.Init(vt)
        tacv = vt

        Me.sifist = CStr(mrist.SIFIST).Trim.ToUpper

        Me.b3.Text = sifist + "    " + String.Format("{0:d2}", Me.tacv.M) + " / " + Me.tacv.G.ToString

        Me.Logovan.Text = GetUserName.ToString.Trim


        Dim dt As New System.Data.DataTable
        Dim sql As String = " select pravaBaza,server,konekcijaDok from vBazaServer where SifIst='" + sifist + "' "
        dt = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)

        pravaBaza = dt.Rows(0).Item("pravaBaza").ToString.ToUpper.Trim

        Dim sqlKS As String = " select tabela from isttabele where SifIst='" + sifist + "' and DG in('K','S') "
        dtKS = izvrsiSQLvratiDT(sqlKS, Me.ISTConnectionString, Nothing)

        Dim sqlGA As String = " select tabela from isttabele where SifIst='" + sifist + "' and DG in('G','A') "
        dtGA = izvrsiSQLvratiDT(sqlGA, Me.ISTConnectionString, Nothing)

        Dim sqlD As String = " select tabela from isttabele where SifIst='" + sifist + "' and DG ='D' "
        dtD = izvrsiSQLvratiDT(sqlD, Me.ISTConnectionString, Nothing)

        Dim sqlGD As String = " select tabela from isttabele where SifIst='" + sifist + "' and DG in('G','D') "
        dtGD = izvrsiSQLvratiDT(sqlGD, Me.ISTConnectionString, Nothing)

        Dim dtCAPIS As New System.Data.DataTable
        Dim sqlCAPIS As String = " select isnull(CAPIServerName,'') as CAPIServerName from _IST where appCode='" + sifist + "'"
        dtCAPIS = izvrsiSQLvratiDT(sqlCAPIS, Me.ISTConnectionString, Nothing)

        CAPIserverName = ""
        CAPIserverIPAddress = ""
        CAPIconn = ""
        sveok = True
        If dtCAPIS.Rows(0).Item("CAPIServerName").trim = "" Then
            MsgBox("CAPIServerName field is table _IST is empty!" + nvrd + nvrd + "Please, enter server details for CAPIServerName!", vbCritical, "Error in _IST!!!!!")
            sveok = False
        Else
            Dim pom() As String = dtCAPIS.Rows(0).Item("CAPIServerName").trim.toupper.split("$")
            If Not pom Is Nothing AndAlso pom.Length > 0 Then
                CAPIserverName = pom(0)
            End If
            If Not pom Is Nothing AndAlso pom.Length > 1 Then
                CAPIserverIPAddress = pom(1)
            End If
            If Not pom Is Nothing AndAlso pom.Length > 2 Then
                CAPIconn = pom(2)
            End If

            Me.lbl1.Text = Me.lbl1.Text.Trim + sifist
            Me.lbl3.Text = Me.lbl3.Text.Trim + sifist
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        End If

    End Sub

    Dim sveok As Boolean = True

    Private Sub FormCAPIPreparation_Load(sender As Object, e As EventArgs) Handles Me.Load

        If sveok = False Then Me.Close()
        Call setTheme(GetTheme())

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

    Private Sub SetLang()
        ''
        'Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        'ButtonZOZakljucaj.Text = getControlText2(dt, "ButtonZOZakljucaj", Me.jezik)
        'ButtonZOIzlaz.Text = getControlText2(dt, "ButtonZOIzlaz", Me.jezik)
        'lblZO.Text = getControlText2(dt, "lblZO", Me.jezik)

    End Sub

    Sub sVF05(what As Integer)

        Dim sql As String = ""
        Dim template01 As String = folderZaGen + "\CAPI" + "\template01createvfsp.txt"
        Dim txt As New System.IO.StreamReader(template01)
        Dim str1 As String = txt.ReadToEnd
        txt.Close()
        sql = str1.ToString

        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateT As String = ""
            screateT = folder + "05" + "_" + sifist + "_view_SP_Func.sql"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateT)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateT)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
            Dim sT As System.Text.StringBuilder = New System.Text.StringBuilder
            sT.Append("USE [" + pravaBaza + "]" + nvrd)
            sT.Append("GO" + nvrd)

            Dim dt As New DataTable
            dt = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

            Dim textred As String = ""
            For i As Integer = 0 To dt.Rows.Count - 1
                textred = dt.Rows(i).Item("typename").ToString.Trim + nvrd + "GO"
                sT.Append(textred + nvrd)
                'this gives create
                Dim ff As String = "sp_helptext @objname = '" + dt.Rows(i).Item("name").ToString.Trim + "'"
                Dim dtpom As DataTable = izvrsiSQLvratiDT(ff, Me.DBConnectionString, Me.jezik)
                For red As Integer = 0 To dtpom.Rows.Count - 1
                    textred = dtpom.Rows(red).Item(0).ToString.Trim
                    sT.Append(textred + nvrd)
                Next
                sT.Append("GO" + nvrd)
            Next
            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateT, False, System.Text.Encoding.UTF8)
                outfile.Write(sT.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at create views, SP, functions")
        End Try

    End Sub

    Sub sABook04()
        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateT As String = ""
            screateT = folder + "04_" + sifist + "_ADRESAR.sql"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateT)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateT)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try

            Dim sT As System.Text.StringBuilder = New System.Text.StringBuilder
            sT.Append("USE [" + pravaBaza + "]" + nvrd)
            sT.Append("GO" + nvrd)
            sT.Append("Declare @TerPod as varchar(50)" + nvrd)
            sT.Append("Set @TerPod = '$(TerPod)'" + nvrd)

            Dim sqlI As String = ""
            For redT As Integer = 0 To dtGA.Rows.Count - 1
                sT.Append("INSERT INTO [dbo]." + dtGA.Rows(redT).Item("tabela").ToString.Trim.ToUpper + nvrd)
                sT.Append("select *" + nvrd)
                sT.Append("FROM [" + CAPIserverIPAddress + "].[" + pravaBaza + "].dbo.[" +
                          dtGA.Rows(redT).Item("tabela").ToString.Trim.ToUpper + "]" + nvrd)
                sT.Append("WHERE PO = @TerPod" + nvrd)
            Next

            For redT As Integer = 0 To dtD.Rows.Count - 1
                Dim tabela As String = dtD.Rows(redT).Item("tabela").ToString.Trim.ToUpper
                Dim nadtabela As String = nadtabelaJe(tabela)
                Dim kljucevi() As String = {}
                kljucevi = DajKljuceve(nadtabela)

                sT.Append("INSERT INTO [dbo]." + tabela + nvrd)
                sT.Append("select p.* " + nvrd)
                sT.Append("from [" + CAPIserverIPAddress + "].[" + pravaBaza + "].dbo.[" + nadtabela + "] d inner join " + nvrd)
                sT.Append("[" + CAPIserverIPAddress + "].[" + pravaBaza + "].dbo.[" + tabela + "] p On " + nvrd)

                Dim klj As String = ""
                For kk As Integer = 0 To kljucevi.GetUpperBound(0)
                    klj = klj + "d." + kljucevi(kk) + "=p." + kljucevi(kk) + " And "
                Next
                klj = klj + "d.PO=@TerPod"
                sT.Append(klj + nvrd)
            Next

            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateT, False, System.Text.Encoding.UTF8)
                outfile.Write(sT.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at create TABLES")
        End Try
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

    Sub sInsertData03()

        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateT As String = ""
            screateT = folder + "03_" + sifist + "_INSERTDATA.sql"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateT)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateT)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try

            Dim sT As System.Text.StringBuilder = New System.Text.StringBuilder
            sT.Append("USE [" + pravaBaza + "]" + nvrd)
            sT.Append("GO" + nvrd)

            Dim sqlI As String = ""
            For redT As Integer = 0 To dtKS.Rows.Count - 1

                Dim sql As String = ""
                sql = "select * from dbo." + dtKS.Rows(redT).Item("tabela").ToString.Trim.ToUpper + ""

                Dim dt0 As New System.Data.DataTable

                dt0 = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

                For red As Integer = 0 To dt0.Rows.Count - 1
                    Dim sqlInsert As String = ""
                    Dim sqlValues As String = ""
                    For k As Integer = 0 To dt0.Columns.Count - 1
                        sqlInsert = sqlInsert + dt0.Columns(k).Caption.ToString.Trim + ","
                        sqlValues = sqlValues + "N'" + dt0.Rows(red).Item(dt0.Columns(k).Caption.ToString.Trim).ToString.Trim.Replace("'", "''") + "',"
                    Next
                    sqlInsert = sqlInsert + ")"
                    sqlInsert = sqlInsert.Replace(",)", "")
                    sqlValues = sqlValues + ")"
                    sqlValues = sqlValues.Replace(",)", "")
                    sqlI = sqlI + "insert into dbo." + dtKS.Rows(redT).Item("tabela").ToString.Trim.ToUpper + " (" + sqlInsert + ") values (" + sqlValues + "); " + nvrd
                Next
            Next
            sT.Append(sqlI + nvrd)
            sT.Append("GO" + nvrd)

            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateT, False, System.Text.Encoding.UTF8)
                outfile.Write(sT.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at insert data")
        End Try
    End Sub

    Sub sTables02()
        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateT As String = ""
            screateT = folder + "02_" + sifist + "_CREATETABLE.sql"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateT)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateT)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try

            Dim sql As String = ""
            Dim template01 As String = ""
            Dim template02 As String = ""
            Dim template03 As String = ""
            template01 = folderZaGen + "\CAPI" + "\template01createtable.txt"
            template02 = folderZaGen + "\CAPI" + "\template01checkconstraint.txt"
            template03 = folderZaGen + "\CAPI" + "\template01createtriggers.txt"

            Dim txt As New System.IO.StreamReader(template01)
            Dim str1 As String = txt.ReadToEnd
            txt.Close()
            str1 = str1.Replace("99databasename99", pravaBaza.Trim.ToUpper)
            sql = str1.ToString

            Dim dt0 As New System.Data.DataTable
            dt0 = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

            Dim sT As System.Text.StringBuilder = New System.Text.StringBuilder
            sT.Append("USE [" + pravaBaza + "]" + nvrd)
            sT.Append("GO" + nvrd)
            For i As Integer = 0 To dt0.Rows.Count - 1
                Dim sqltablename As String = dt0.Rows(i).Item("tablename").ToString.ToUpper.Trim
                sqltablename = "If Not EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[" + sqltablename + "]') AND type in (N'U'))"
                sT.Append(sqltablename + nvrd)
                Dim sqlcreate As String = dt0.Rows(i).Item("createStatement").ToString.ToUpper.Trim
                sT.Append(sqlcreate + nvrd)
                sT.Append("GO" + nvrd)
            Next

            'CHECK CONSTRAINTS
            txt = New System.IO.StreamReader(template02)
            Dim str2 As String = txt.ReadToEnd
            txt.Close()
            sql = str2.ToString
            Dim dt11 As New System.Data.DataTable
            dt11 = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
            For i As Integer = 0 To dt11.Rows.Count - 1
                sT.Append(dt11.Rows(i).Item("cpart1").ToString.Trim + nvrd)
                sT.Append("GO" + nvrd)
                sT.Append(dt11.Rows(i).Item("cpart2").ToString.Trim + nvrd)
                sT.Append("GO" + nvrd)
            Next

            'TRIGERS
            Dim dt1 As New DataTable
            txt = New System.IO.StreamReader(template03)
            Dim sql1 As String = txt.ReadToEnd
            txt.Close()
            dt1 = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

            For i As Integer = 0 To dt1.Rows.Count - 1
                Dim ff As String = "sp_helptext @objname = '" + dt1.Rows(i).Item("name").ToString.Trim + "'"
                Dim dtpom As DataTable = izvrsiSQLvratiDT(ff, Me.DBConnectionString, Me.jezik)
                For red As Integer = 0 To dtpom.Rows.Count - 1
                    Dim textred As String = dtpom.Rows(red).Item(0).ToString.Trim
                    sT.Append(textred + nvrd)
                Next
                sT.Append("GO" + nvrd)
            Next

            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateT, False, System.Text.Encoding.UTF8)
                outfile.Write(sT.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at create TABLES, CHECK CONSTRAINTS,TRIGERS")
        End Try
    End Sub

    Sub sSQLTxt06()
        Dim folder As String = "C:\ISTCAPI_" + sifist + "\SQLTxt\" + sifist + "\"
        Try
            Call DeleteFilesFromFolders(folder, Me.jezik)
            Directory.CreateDirectory(folder)
            Dim folderZaGen As String = ""
            Dim lfolderZaGen As String = CStr(mrist.TxtDir).Trim.ToUpper
            Call CopyDirectory(lfolderZaGen, folder)
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at copy SQLTxt")
        End Try
    End Sub

    Sub sDB01()
        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateDB As String = ""
            screateDB = folder + "01_" + sifist + "_CREATEDB.sql"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateDB)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateDB)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try

            Dim sql As String = ""
            Dim template01 As String = ""
            template01 = folderZaGen + "\CAPI" + "\template01createDB.txt"

            Dim txt As New System.IO.StreamReader(template01)
            Dim str1 As String = txt.ReadToEnd
            txt.Close()
            str1 = str1.Replace("99databasename99", pravaBaza.Trim.ToUpper)
            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateDB, False, System.Text.Encoding.UTF8)
                outfile.Write(str1.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at create DB")
        End Try
    End Sub

    Private Sub ButtonUradi_Click(sender As Object, e As System.EventArgs) Handles ButtonUradi.Click
        Me.Cursor = Cursors.WaitCursor

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(2057)

        Try
            If cbDB.Checked = True Then Call sDB01()
            If cbTables.Checked = True Then Call sTables02()
            If cbInsertData.Checked = True Then Call sInsertData03()
            If cbABook.Checked = True Then Call sABook04()
            If cbVF.Checked = True Then Call sVF05(1)

            If cbSQLTxt.Checked = True Then Call sSQLTxt06()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        cbDB.Checked = False
        cbTables.Checked = False
        cbInsertData.Checked = False
        cbABook.Checked = False
        cbVF.Checked = False
        cbSQLTxt.Checked = False
        ISTMessageBox.Show("Scripts are generated!" + nvrd + nvrd + "on C:\ISTCAPI_" + sifist)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ButtonUradi2_Click(sender As Object, e As System.EventArgs) Handles ButtonUradi2.Click
        Me.Cursor = Cursors.WaitCursor

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(2057)

        Try
            If cbSlanje.Checked = True Then Call sslanje()
            If cbTBat.Checked = True Then Call sslanjeBAT()
            If cbRBat.Checked = True Then Call sprijemBAT()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        cbSlanje.Checked = False
        cbTBat.Checked = False
        cbRBat.Checked = False

        ISTMessageBox.Show("Scripts are generated!" + nvrd + nvrd + "on C:\ISTCAPI_" + sifist)

        Me.Cursor = Cursors.Default
    End Sub

    Sub sslanjeBAT()
        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateDB As String = ""
            screateDB = folder + "" + sifist + "_Slanje.bat"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateDB)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateDB)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try

            Dim sql As String = ""
            Dim template01 As String = ""
            template01 = folderZaGen + "\CAPI" + "\template01TransferBAT.txt"

            Dim txt As New System.IO.StreamReader(template01)
            Dim str1 As String = txt.ReadToEnd
            txt.Close()
            str1 = str1.Replace("99databasename99", pravaBaza.Trim.ToUpper)
            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateDB, False, System.Text.Encoding.UTF8)
                outfile.Write(str1.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at create DB")
        End Try
    End Sub

    Sub sprijemBAT()
        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateDB As String = ""
            screateDB = folder + "" + sifist + "_Preuzimanje.bat"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateDB)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateDB)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try

            Dim sql As String = ""
            Dim template01 As String = ""
            template01 = folderZaGen + "\CAPI" + "\template01ReceiveBAT.txt"

            Dim txt As New System.IO.StreamReader(template01)
            Dim str1 As String = txt.ReadToEnd
            txt.Close()
            str1 = str1.Replace("99databasename99", pravaBaza.Trim.ToUpper)
            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateDB, False, System.Text.Encoding.UTF8)
                outfile.Write(str1.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at create DB")
        End Try
    End Sub

    Sub sslanje()
        Dim folder As String = "C:\ISTCAPI_" + sifist + "\"
        Try
            Dim screateDB As String = ""
            screateDB = folder + "" + sifist + "_SLANJE.sql"
            Try
                'brisem sve sto postoji u folderu
                Dim fi As New System.IO.FileInfo(screateDB)
                If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                    System.IO.Directory.CreateDirectory(fi.DirectoryName)
                End If
                System.IO.File.Delete(screateDB)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try

            Dim sql As String = ""
            Dim template01 As String = ""
            template01 = folderZaGen + "\CAPI" + "\template01TransferStart.txt"
            Dim template02 As String = ""
            template02 = folderZaGen + "\CAPI" + "\template01TransferTable.txt"

            Dim txt As New System.IO.StreamReader(template01)
            Dim str1 As String = txt.ReadToEnd
            txt.Close()
            str1 = str1.Replace("99databasename99", pravaBaza.Trim.ToUpper)

            Dim str2 As String = ""
            Dim strTables As String = ""
            Dim pomGR As String = ""
            For redT As Integer = 0 To dtGD.Rows.Count - 1
                Dim tabela As String = dtGD.Rows(redT).Item("tabela").ToString.Trim.ToUpper
                txt = New System.IO.StreamReader(template02)
                str2 = txt.ReadToEnd
                txt.Close()
                str2 = str2.Replace("99tablename99", tabela.Trim.ToUpper)
                str2 = str2.Replace("99databasename99", pravaBaza.Trim.ToUpper)
                strTables = strTables + str2 + nvrd
                pomGR = pomGR + "@Gr_" + tabela.Trim.ToUpper + "+"
            Next

            pomGR = pomGR + "+"
            pomGR = pomGR.Replace("++", ">0")
            pomGR = "If " + pomGR + nvrd + "raiserror('222001', 16, 1);"

            str1 = str1 + nvrd + nvrd + strTables + nvrd + pomGR
            '           If @Gr_Dem+@Gr_DemEnd+@Gr_Person+@Gr_QUEST>0
            'raiserror('222001', 16, 1);

            'KONACAN ISPIS
            Try
                Dim outfile As New System.IO.StreamWriter(screateDB, False, System.Text.Encoding.UTF8)
                outfile.Write(str1.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show("Error at create script for transfer")
        End Try
    End Sub

    Private Sub ButtonISTMeta_Click(sender As Object, e As System.EventArgs) Handles ButtonISTMeta.Click

        If cbISTTables.Checked = True Then
            If (rewriteIstMetaData("istTabele") = 1) Then lblSTTables.Text = "!Error"
        End If
        If cbISTTablesColumns.Checked = True Then
            If (rewriteIstMetaData("istpolja") = 1) Then lblISTTablesColumns.Text = "!Error"
        End If
        If cbISTReportsProcedures.Checked = True Then
            If rewriteIstMetaData("ISTTABS") = 1 Then lblISTReportsProcedures.Text = "!Error"
        End If
        If cbISTRulesLogicalControl.Checked = True Then
            If rewriteIstMetaData("ISTLK") = 1 Then lblISTRulesLogicalControl.Text = "!Error"
        End If

    End Sub

    Function rewriteIstMetaData(tableName As String) As Integer

        'Select iz tabele koja se prepisuje

        Dim sqlIstSelect As String = "select * from ist.dbo.[" + tableName + "] where sifist ='" + Me.sifist + "'"

        Dim destTableName As String = tableName
        Dim sqlIstCapiDelete As String = "DELETE FROM IST.dbo.[" + destTableName + "] where sifist ='" + sifist + "'"

        Dim transaction As SqlTransaction = Nothing
        Dim dtSelect As New DataTable

        'Na odredisnom serveru brisem za to istrazivanje pa prepisujem sa razvojnog..
        Dim strConDest As New SqlConnection("Data Source=" + CAPIserverName + "; Initial Catalog=IST;Integrated Security=True")

        Dim commandDelete As SqlCommand = New SqlCommand()
        commandDelete.Connection = strConDest
        commandDelete.CommandText = sqlIstCapiDelete

        Try

            dtSelect = izvrsiSQLvratiDT(sqlIstSelect, Me.ISTConnectionString, Nothing)

            If dtSelect.Rows.Count > 0 Then
                Try
                    strConDest.Open()
                    transaction = strConDest.BeginTransaction("TransferMeta")
                    commandDelete.Transaction = transaction
                    Dim bulkCopy As SqlBulkCopy = New SqlBulkCopy(strConDest, SqlBulkCopyOptions.KeepIdentity, transaction)
                    bulkCopy.DestinationTableName = destTableName
                    commandDelete.ExecuteNonQuery()
                    bulkCopy.BatchSize = 10000
                    bulkCopy.WriteToServer(dtSelect)
                    transaction.Commit()
                    rewriteIstMetaData = 0
                Catch ex As System.Exception
                    rewriteIstMetaData = 1
                    transaction.Rollback()
                    ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine("Commit Exception Type: {0}", ex.GetType())
                    System.Console.WriteLine("  Message: {0}", ex.Message)
                Finally
                    strConDest.Close()
                End Try
            End If
        Finally
        End Try

    End Function

    Private Sub tclCapiPreparation_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tclCapiPreparation.SelectedIndexChanged
        If tclCapiPreparation.SelectedTab.Name = "Tabpackages" Then

            Dim di As DirectoryInfo = New DirectoryInfo("\\10.13.18.75\IST_SRV_Share\ISTRAZIVANJA\" + sifist)
            Dim aryFi As FileInfo() = di.GetFiles("*.bat")
            Dim fi As FileInfo

            For Each fi In aryFi
                cbPackages.Items.Add("Z:\ISTRAZIVANJA\" + sifist + "\" + fi.Name)
            Next

        End If
    End Sub

    Private Sub readPackages()

        Dim sqlPackages As String = "select  cast(0 as bit) as DodajNovi,*,1 as vecPostoji
                                    from lfs.dbo.test_PreuzimanjaBAT
                                    where sifist = @sifist and putanja = @putanja
                                    order by redosledSkripta ;
                                    select *
                                    from lfs.dbo.test_Veza_Anketari_IST as a
                                    where not exists (select  * from LFs.dbo.test_PreuzimanjaBAT  as b where a.AnketarNalog=b.AnketarNalog and Putanja =@putanja)
	                                 and SIFIST=@sifist;
                                    select  max(RedosledSkripta) + 1 as RedosledSkripta
                                    from lfs.dbo.test_PreuzimanjaBAT
                                    where sifist = @sifist and
                                    not exists(select * from lfs.dbo.test_PreuzimanjaBAT where sifist = @sifist and  putanja = @putanja)"

        Dim dsIstCapi As New DataSet
        Dim dtPackages As DataTable
        Dim dtVezaAnketari As DataTable

        Dim ConnCAPI As New SqlConnection("Data Source=" + CAPIserverName + "; Initial Catalog=LFS;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand(sqlPackages, ConnCAPI)
        cmd.Parameters.AddWithValue("@sifist", sifist)
        cmd.Parameters.AddWithValue("@putanja", cbPackages.SelectedItem.ToString())
        Dim adp As New SqlDataAdapter(cmd)
        Dim newRow As DataRow
        adp.Fill(dsIstCapi)

        dtPackages = dsIstCapi.Tables(0)
        dtVezaAnketari = dsIstCapi.Tables(1)

        For Each row As DataRow In dtVezaAnketari.Rows

            newRow = dtPackages.NewRow

            newRow(dtPackages.Columns(1).ColumnName) = row.Item(dtPackages.Columns(1).ColumnName).ToString()

            newRow(dtPackages.Columns(2).ColumnName) = sifist
            If dsIstCapi.Tables(2).Rows.Count > 0 Then
                newRow(dtPackages.Columns(3).ColumnName) = dsIstCapi.Tables(2).Rows(0).Item("RedosledSkripta")
            Else
                newRow(dtPackages.Columns(3).ColumnName) = dtPackages.Rows(0).Item(dtPackages.Columns(3).ColumnName).ToString()
            End If

            newRow(dtPackages.Columns(4).ColumnName) = cbPackages.SelectedItem.ToString()
            newRow(dtPackages.Columns("vecPostoji").ColumnName) = 0
            dtPackages.Rows.Add(newRow)

        Next

        dgvPackages.DataSource = dtPackages

    End Sub

    Private Sub cbPackages_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbPackages.SelectedIndexChanged

        readPackages()
        dgvTest.DataSource = Nothing

    End Sub

    Private Sub dgvPackages_RowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPackages.RowLeave

    End Sub

    Private Sub btnSavePackages_Click(sender As Object, e As System.EventArgs) Handles btnSavePackages.Click
        Dim DestinationTableName As String = ""
        Dim ConnCAPI As New SqlConnection("Data Source=" + CAPIserverName + "; Initial Catalog=LFS;Integrated Security=True")
        ConnCAPI.Open()
        Dim bcp As SqlBulkCopy = New SqlBulkCopy(ConnCAPI)
        Dim destinationTable As String = "test_PreuzimanjaBAT"
        bcp.DestinationTableName = destinationTable

        Dim dtNew, dtUpdate, dtChanges As DataTable '= dgvPackages.DataSource
        Dim dvUpdate As DataView = New DataView(dgvPackages.DataSource)
        Dim dvNew As DataView = New DataView(dgvPackages.DataSource)
        Dim dvCHAnges As DataView = New DataView(dgvPackages.DataSource)
        dvNew.RowFilter = "DodajNovi =true and vecPostoji=0 "
        dtNew = dvNew.ToTable()
        '''' dtChanges = dvChanges.Table.Copy
        dtNew.Columns.Remove("DodajNovi")
        dtNew.Columns.Remove("vecPostoji")
        'dgvTest.DataSource = dtNew
        bcp.WriteToServer(dtNew)

        dvUpdate.RowFilter = "DodajNovi =true and vecPostoji=1"
        dtUpdate = dvUpdate.ToTable()
        dgvTest.DataSource = dtUpdate

        Dim cmd As SqlCommand = New SqlCommand()
        cmd.Connection = ConnCAPI
        cmd.CommandText = "update " + destinationTable + " set aktivan=@aktivan,DatumPreuzimanja=@DatumPreuzimanja where RedosledSkripta =@RedosledSkripta and sifist=@sifist and anketarNAlog=@anketarNalog"
        cmd.Parameters.Add("@aktivan", SqlDbType.Int)
        cmd.Parameters.Add("@DatumPreuzimanja", SqlDbType.NVarChar, 50)
        cmd.Parameters.Add("@sifist", SqlDbType.NChar, 8)
        cmd.Parameters.Add("@anketarNalog", SqlDbType.NVarChar, 50)
        cmd.Parameters.Add("@RedosledSkripta", SqlDbType.Int)
        If dtUpdate.Rows.Count > 0 Then

            For Each r As DataRow In dtUpdate.Rows
                cmd.Parameters("@aktivan").Value = r("aktivan")
                cmd.Parameters("@sifist").Value = r("sifist")
                cmd.Parameters("@DatumPreuzimanja").Value = r("DatumPreuzimanja")
                cmd.Parameters("@anketarNalog").Value = r("anketarNalog")
                cmd.Parameters("@RedosledSkripta").Value = r("RedosledSkripta")

                cmd.ExecuteNonQuery()
            Next
        End If

        dvCHAnges.RowFilter = "DodajNovi =true"
        dtChanges = dvCHAnges.ToTable()
        dgvTest.DataSource = dtChanges

        readPackages()
        ConnCAPI.Close()

    End Sub

    Private Sub dgvPackages_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPackages.CellValueChanged
        dgvPackages.Rows(e.RowIndex).Cells(0).Value = True
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class