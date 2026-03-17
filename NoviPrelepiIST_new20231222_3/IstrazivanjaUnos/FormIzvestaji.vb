Option Explicit On
Option Strict Off

Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports Microsoft.Win32
Imports System.Linq
Imports Microsoft.Office.Interop.Excel
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
'Imports Microsoft.Office.Interop.Excel


'Imports Microsoft.Office.Interop.Word
Public Class FormIzvestaji
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
    Friend WithEvents b3 As System.Windows.Forms.Button
    Friend WithEvents PanelContext As System.Windows.Forms.Panel
    Friend WithEvents ButtonPrikaziExcel As System.Windows.Forms.Button
    Friend WithEvents ButtonCSV As System.Windows.Forms.Button
    Friend WithEvents ButtonJSON As System.Windows.Forms.Button
    Friend WithEvents ButtonXML As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonEndExcel As System.Windows.Forms.Button
    Friend WithEvents ButtonEndWord As System.Windows.Forms.Button
    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents ButtonIzvNoviIzvestaj As System.Windows.Forms.Button
    Friend WithEvents ButtonEndOpenOffice As System.Windows.Forms.Button
    Friend WithEvents lblPVT As System.Windows.Forms.Label
    Friend WithEvents ButtonTXT As System.Windows.Forms.Button
    Friend WithEvents PanelMenu As System.Windows.Forms.Panel
    Friend WithEvents btnPrazno As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Logovan As System.Windows.Forms.Label
    Friend WithEvents PanelTop As Panel
    Friend WithEvents btnArrowDownHover As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnLinija As System.Windows.Forms.Button
    Friend WithEvents ListBoxNoviIzvestaj As System.Windows.Forms.ListBox
    Friend WithEvents btnLinijaRazmak As System.Windows.Forms.Button
    'Friend WithEvents PanelTop As Panel
    Friend WithEvents ToolTip1 As ToolTip

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormIzvestaji))
        Me.b3 = New System.Windows.Forms.Button()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.btnArrowDownHover = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ListBoxNoviIzvestaj = New System.Windows.Forms.ListBox()
        Me.btnLinijaRazmak = New System.Windows.Forms.Button()
        Me.ButtonPrikaziExcel = New System.Windows.Forms.Button()
        Me.ButtonCSV = New System.Windows.Forms.Button()
        Me.ButtonJSON = New System.Windows.Forms.Button()
        Me.ButtonXML = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.ButtonEndExcel = New System.Windows.Forms.Button()
        Me.ButtonEndWord = New System.Windows.Forms.Button()
        Me.ButtonIzvNoviIzvestaj = New System.Windows.Forms.Button()
        Me.ButtonEndOpenOffice = New System.Windows.Forms.Button()
        Me.lblPVT = New System.Windows.Forms.Label()
        Me.ButtonTXT = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnLinija = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.btnPrazno = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContext.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
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
        Me.b3.Location = New System.Drawing.Point(18, 7)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(240, 27)
        Me.b3.TabIndex = 184
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        Me.b3.Visible = False
        '
        'PanelContext
        '
        Me.PanelContext.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelContext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelContext.Controls.Add(Me.PanelTop)
        Me.PanelContext.Controls.Add(Me.ListBoxNoviIzvestaj)
        Me.PanelContext.Controls.Add(Me.btnLinijaRazmak)
        Me.PanelContext.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(255, 0)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(895, 749)
        Me.PanelContext.TabIndex = 145
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnArrowDownHover)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(2, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(893, 40)
        Me.PanelTop.TabIndex = 141
        Me.PanelTop.Tag = "Theme"
        '
        'btnArrowDownHover
        '
        Me.btnArrowDownHover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnArrowDownHover.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnArrowDownHover.FlatAppearance.BorderSize = 0
        Me.btnArrowDownHover.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArrowDownHover.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArrowDownHover.ForeColor = System.Drawing.Color.White
        Me.btnArrowDownHover.Image = CType(resources.GetObject("btnArrowDownHover.Image"), System.Drawing.Image)
        Me.btnArrowDownHover.Location = New System.Drawing.Point(853, 0)
        Me.btnArrowDownHover.Name = "btnArrowDownHover"
        Me.btnArrowDownHover.Size = New System.Drawing.Size(40, 40)
        Me.btnArrowDownHover.TabIndex = 10000077
        Me.btnArrowDownHover.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(813, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = False
        Me.btnMinimizar.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(853, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = False
        Me.btnCerrar.Visible = False
        '
        'ListBoxNoviIzvestaj
        '
        Me.ListBoxNoviIzvestaj.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ListBoxNoviIzvestaj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxNoviIzvestaj.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ListBoxNoviIzvestaj.FormattingEnabled = True
        Me.ListBoxNoviIzvestaj.ItemHeight = 18
        Me.ListBoxNoviIzvestaj.Location = New System.Drawing.Point(20, 56)
        Me.ListBoxNoviIzvestaj.Margin = New System.Windows.Forms.Padding(15)
        Me.ListBoxNoviIzvestaj.Name = "ListBoxNoviIzvestaj"
        Me.ListBoxNoviIzvestaj.Size = New System.Drawing.Size(872, 679)
        Me.ListBoxNoviIzvestaj.TabIndex = 198
        '
        'btnLinijaRazmak
        '
        Me.btnLinijaRazmak.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.btnLinijaRazmak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLinijaRazmak.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLinijaRazmak.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnLinijaRazmak.FlatAppearance.BorderSize = 0
        Me.btnLinijaRazmak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLinijaRazmak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLinijaRazmak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinijaRazmak.Font = New System.Drawing.Font("Arial Rounded MT Bold", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLinijaRazmak.ForeColor = System.Drawing.Color.White
        Me.btnLinijaRazmak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLinijaRazmak.Location = New System.Drawing.Point(0, 0)
        Me.btnLinijaRazmak.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLinijaRazmak.Name = "btnLinijaRazmak"
        Me.btnLinijaRazmak.Size = New System.Drawing.Size(2, 749)
        Me.btnLinijaRazmak.TabIndex = 10000076
        Me.btnLinijaRazmak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinijaRazmak.UseVisualStyleBackColor = False
        '
        'ButtonPrikaziExcel
        '
        Me.ButtonPrikaziExcel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPrikaziExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPrikaziExcel.FlatAppearance.BorderSize = 0
        Me.ButtonPrikaziExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonPrikaziExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPrikaziExcel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrikaziExcel.ForeColor = System.Drawing.Color.White
        Me.ButtonPrikaziExcel.Image = CType(resources.GetObject("ButtonPrikaziExcel.Image"), System.Drawing.Image)
        Me.ButtonPrikaziExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrikaziExcel.Location = New System.Drawing.Point(10, 199)
        Me.ButtonPrikaziExcel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonPrikaziExcel.Name = "ButtonPrikaziExcel"
        Me.ButtonPrikaziExcel.Size = New System.Drawing.Size(240, 30)
        Me.ButtonPrikaziExcel.TabIndex = 0
        Me.ButtonPrikaziExcel.Tag = "      Excel"
        Me.ButtonPrikaziExcel.Text = "      Excel"
        Me.ButtonPrikaziExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrikaziExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonPrikaziExcel.UseVisualStyleBackColor = False
        '
        'ButtonCSV
        '
        Me.ButtonCSV.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCSV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCSV.FlatAppearance.BorderSize = 0
        Me.ButtonCSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCSV.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCSV.ForeColor = System.Drawing.Color.White
        Me.ButtonCSV.Image = CType(resources.GetObject("ButtonCSV.Image"), System.Drawing.Image)
        Me.ButtonCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCSV.Location = New System.Drawing.Point(10, 230)
        Me.ButtonCSV.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonCSV.Name = "ButtonCSV"
        Me.ButtonCSV.Size = New System.Drawing.Size(240, 30)
        Me.ButtonCSV.TabIndex = 2
        Me.ButtonCSV.Tag = "      Csv"
        Me.ButtonCSV.Text = "      Csv"
        Me.ButtonCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCSV.UseVisualStyleBackColor = False
        '
        'ButtonJSON
        '
        Me.ButtonJSON.BackColor = System.Drawing.Color.Transparent
        Me.ButtonJSON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonJSON.FlatAppearance.BorderSize = 0
        Me.ButtonJSON.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonJSON.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJSON.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJSON.ForeColor = System.Drawing.Color.White
        Me.ButtonJSON.Image = CType(resources.GetObject("ButtonJSON.Image"), System.Drawing.Image)
        Me.ButtonJSON.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonJSON.Location = New System.Drawing.Point(10, 261)
        Me.ButtonJSON.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonJSON.Name = "ButtonJSON"
        Me.ButtonJSON.Size = New System.Drawing.Size(240, 30)
        Me.ButtonJSON.TabIndex = 4
        Me.ButtonJSON.Tag = "      Json"
        Me.ButtonJSON.Text = "      Json"
        Me.ButtonJSON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonJSON.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonJSON.UseVisualStyleBackColor = False
        '
        'ButtonXML
        '
        Me.ButtonXML.BackColor = System.Drawing.Color.Transparent
        Me.ButtonXML.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonXML.FlatAppearance.BorderSize = 0
        Me.ButtonXML.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonXML.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonXML.ForeColor = System.Drawing.Color.White
        Me.ButtonXML.Image = CType(resources.GetObject("ButtonXML.Image"), System.Drawing.Image)
        Me.ButtonXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonXML.Location = New System.Drawing.Point(10, 292)
        Me.ButtonXML.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonXML.Name = "ButtonXML"
        Me.ButtonXML.Size = New System.Drawing.Size(240, 30)
        Me.ButtonXML.TabIndex = 6
        Me.ButtonXML.Text = "      Xml"
        Me.ButtonXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonXML.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonXML.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(212, 5)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(32, 32)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 13
        Me.btnMenu.TabStop = False
        '
        'ButtonEndExcel
        '
        Me.ButtonEndExcel.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEndExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEndExcel.FlatAppearance.BorderSize = 0
        Me.ButtonEndExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonEndExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEndExcel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEndExcel.ForeColor = System.Drawing.Color.White
        Me.ButtonEndExcel.Image = CType(resources.GetObject("ButtonEndExcel.Image"), System.Drawing.Image)
        Me.ButtonEndExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEndExcel.Location = New System.Drawing.Point(10, 419)
        Me.ButtonEndExcel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonEndExcel.Name = "ButtonEndExcel"
        Me.ButtonEndExcel.Size = New System.Drawing.Size(240, 30)
        Me.ButtonEndExcel.TabIndex = 19
        Me.ButtonEndExcel.Tag = "      Close ALL excel files"
        Me.ButtonEndExcel.Text = "      Close ALL excel files"
        Me.ButtonEndExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEndExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonEndExcel.UseVisualStyleBackColor = False
        '
        'ButtonEndWord
        '
        Me.ButtonEndWord.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEndWord.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEndWord.FlatAppearance.BorderSize = 0
        Me.ButtonEndWord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonEndWord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEndWord.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEndWord.ForeColor = System.Drawing.Color.White
        Me.ButtonEndWord.Image = CType(resources.GetObject("ButtonEndWord.Image"), System.Drawing.Image)
        Me.ButtonEndWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEndWord.Location = New System.Drawing.Point(10, 450)
        Me.ButtonEndWord.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonEndWord.Name = "ButtonEndWord"
        Me.ButtonEndWord.Size = New System.Drawing.Size(240, 30)
        Me.ButtonEndWord.TabIndex = 21
        Me.ButtonEndWord.Tag = "      Close ALL word files"
        Me.ButtonEndWord.Text = "      Close ALL word files"
        Me.ButtonEndWord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEndWord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonEndWord.UseVisualStyleBackColor = False
        '
        'ButtonIzvNoviIzvestaj
        '
        Me.ButtonIzvNoviIzvestaj.BackColor = System.Drawing.Color.Transparent
        Me.ButtonIzvNoviIzvestaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonIzvNoviIzvestaj.FlatAppearance.BorderSize = 0
        Me.ButtonIzvNoviIzvestaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonIzvNoviIzvestaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonIzvNoviIzvestaj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIzvNoviIzvestaj.ForeColor = System.Drawing.Color.White
        Me.ButtonIzvNoviIzvestaj.Image = CType(resources.GetObject("ButtonIzvNoviIzvestaj.Image"), System.Drawing.Image)
        Me.ButtonIzvNoviIzvestaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzvNoviIzvestaj.Location = New System.Drawing.Point(10, 144)
        Me.ButtonIzvNoviIzvestaj.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonIzvNoviIzvestaj.Name = "ButtonIzvNoviIzvestaj"
        Me.ButtonIzvNoviIzvestaj.Size = New System.Drawing.Size(240, 38)
        Me.ButtonIzvNoviIzvestaj.TabIndex = 30
        Me.ButtonIzvNoviIzvestaj.Text = "    Направи извештај"
        Me.ButtonIzvNoviIzvestaj.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonIzvNoviIzvestaj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonIzvNoviIzvestaj.UseVisualStyleBackColor = False
        '
        'ButtonEndOpenOffice
        '
        Me.ButtonEndOpenOffice.BackColor = System.Drawing.Color.Transparent
        Me.ButtonEndOpenOffice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEndOpenOffice.FlatAppearance.BorderSize = 0
        Me.ButtonEndOpenOffice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonEndOpenOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEndOpenOffice.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEndOpenOffice.ForeColor = System.Drawing.Color.White
        Me.ButtonEndOpenOffice.Image = CType(resources.GetObject("ButtonEndOpenOffice.Image"), System.Drawing.Image)
        Me.ButtonEndOpenOffice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEndOpenOffice.Location = New System.Drawing.Point(10, 481)
        Me.ButtonEndOpenOffice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonEndOpenOffice.Name = "ButtonEndOpenOffice"
        Me.ButtonEndOpenOffice.Size = New System.Drawing.Size(240, 30)
        Me.ButtonEndOpenOffice.TabIndex = 23
        Me.ButtonEndOpenOffice.Tag = "      Close ALL open office files"
        Me.ButtonEndOpenOffice.Text = "      Close ALL open office files"
        Me.ButtonEndOpenOffice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEndOpenOffice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonEndOpenOffice.UseVisualStyleBackColor = False
        '
        'lblPVT
        '
        Me.lblPVT.AutoEllipsis = True
        Me.lblPVT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPVT.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPVT.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPVT.Location = New System.Drawing.Point(167, 586)
        Me.lblPVT.Name = "lblPVT"
        Me.lblPVT.Size = New System.Drawing.Size(49, 27)
        Me.lblPVT.TabIndex = 107
        Me.lblPVT.Tag = "nediraj"
        Me.lblPVT.Text = "."
        Me.lblPVT.Visible = False
        '
        'ButtonTXT
        '
        Me.ButtonTXT.BackColor = System.Drawing.Color.Transparent
        Me.ButtonTXT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTXT.FlatAppearance.BorderSize = 0
        Me.ButtonTXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ButtonTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTXT.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTXT.ForeColor = System.Drawing.Color.White
        Me.ButtonTXT.Image = CType(resources.GetObject("ButtonTXT.Image"), System.Drawing.Image)
        Me.ButtonTXT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTXT.Location = New System.Drawing.Point(10, 324)
        Me.ButtonTXT.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.ButtonTXT.Name = "ButtonTXT"
        Me.ButtonTXT.Size = New System.Drawing.Size(240, 30)
        Me.ButtonTXT.TabIndex = 108
        Me.ButtonTXT.Tag = "      Txt"
        Me.ButtonTXT.Text = "      Txt"
        Me.ButtonTXT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonTXT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonTXT.UseVisualStyleBackColor = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnLinija)
        Me.PanelMenu.Controls.Add(Me.btnBack)
        Me.PanelMenu.Controls.Add(Me.Logovan)
        Me.PanelMenu.Controls.Add(Me.ButtonTXT)
        Me.PanelMenu.Controls.Add(Me.lblPVT)
        Me.PanelMenu.Controls.Add(Me.ButtonEndOpenOffice)
        Me.PanelMenu.Controls.Add(Me.ButtonIzvNoviIzvestaj)
        Me.PanelMenu.Controls.Add(Me.ucvt)
        Me.PanelMenu.Controls.Add(Me.ButtonEndWord)
        Me.PanelMenu.Controls.Add(Me.ButtonEndExcel)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Controls.Add(Me.ButtonXML)
        Me.PanelMenu.Controls.Add(Me.ButtonJSON)
        Me.PanelMenu.Controls.Add(Me.ButtonCSV)
        Me.PanelMenu.Controls.Add(Me.ButtonPrikaziExcel)
        Me.PanelMenu.Controls.Add(Me.btnPrazno)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button7)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(255, 749)
        Me.PanelMenu.TabIndex = 143
        '
        'btnLinija
        '
        Me.btnLinija.BackColor = System.Drawing.Color.Transparent
        Me.btnLinija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLinija.FlatAppearance.BorderSize = 0
        Me.btnLinija.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLinija.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLinija.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinija.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLinija.ForeColor = System.Drawing.Color.White
        Me.btnLinija.Image = CType(resources.GetObject("btnLinija.Image"), System.Drawing.Image)
        Me.btnLinija.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLinija.Location = New System.Drawing.Point(0, 371)
        Me.btnLinija.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnLinija.Name = "btnLinija"
        Me.btnLinija.Size = New System.Drawing.Size(255, 17)
        Me.btnLinija.TabIndex = 10000087
        Me.btnLinija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLinija.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLinija.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(13, 675)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(32, 33)
        Me.btnBack.TabIndex = 10000085
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Logovan
        '
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(0, 711)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(255, 18)
        Me.Logovan.TabIndex = 10000086
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucvt
        '
        Me.ucvt.BackColor = System.Drawing.SystemColors.Control
        Me.ucvt.Enabled = False
        Me.ucvt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvt.Location = New System.Drawing.Point(185, 737)
        Me.ucvt.Name = "ucvt"
        Me.ucvt.Size = New System.Drawing.Size(49, 27)
        Me.ucvt.TabIndex = 6
        Me.ucvt.Visible = False
        '
        'btnPrazno
        '
        Me.btnPrazno.BackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPrazno.FlatAppearance.BorderSize = 0
        Me.btnPrazno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPrazno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrazno.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrazno.ForeColor = System.Drawing.Color.White
        Me.btnPrazno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrazno.Location = New System.Drawing.Point(0, 729)
        Me.btnPrazno.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPrazno.Name = "btnPrazno"
        Me.btnPrazno.Size = New System.Drawing.Size(255, 20)
        Me.btnPrazno.TabIndex = 111
        Me.btnPrazno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrazno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrazno.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(0, 99)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(255, 28)
        Me.Button2.TabIndex = 10000083
        Me.Button2.Text = "W H E R E  I N T E G R A T I O N  M E E T S  I N F O R M A T I O N"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Candara", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.Location = New System.Drawing.Point(0, 47)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(255, 52)
        Me.Button7.TabIndex = 10000082
        Me.Button7.Text = "IST"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(255, 47)
        Me.Button3.TabIndex = 10000084
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 20
        '
        'FormIzvestaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1150, 749)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormIzvestaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContext.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
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


    Dim ttab As DatasetIstrazivanja.ISTTABSDataTable
    Dim mrist As DatasetIstrazivanja.ISTRow
    Dim mb As DatasetIstrazivanja.ISTBAZERow
    Dim mTrt As String
    Dim mxls As String
    Dim mdoc As String
    Dim mtxt As String
    Dim mOOCalc As String
    Dim mdocx As String
    Dim mdocm As String
    Dim mdotx As String
    Dim mdotm As String
    Dim mExcelXML As String
    Dim mXML As String
    Dim mxlsm As String
    Dim mxlsm88 As String
    Dim mxlsx As String
    Dim zmcsv As String
    Dim mJSON As String
    Dim mCSV As String
    Dim mXSL As String

    Dim dword As String
    Dim wfn As String = ""
    Private mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim lokalno As Boolean
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim CAPIServer As String
    Dim CAPIBaza As String
    Dim jezik As String
    Dim DBConnectionString As String
    Dim ISTConnectionString As String
    Dim txtmode As String

    Dim folder As String
    Dim oopenofficeods As Boolean = False
    Dim oopenofficeodslock As Boolean = False

    Dim txtfile As Boolean = False
    Dim mdtAWL As System.Data.DataTable
    Dim mdtQE As System.Data.DataTable
    Dim mdtLabel As System.Data.DataTable
    Dim mdtMessage As System.Data.DataTable
    Dim dodatak As String = " Declare @Lozinka NVARCHAR(50);    " + vbCrLf +
                  " Declare @Hash NVARCHAR(50);    " + vbCrLf +
                  " Set @Lozinka  = N'Заштити ме молим те рећи ћу ти волим те!!!';    " + vbCrLf +
                  " Set @Hash  = '12345';    " + vbCrLf +
                  " Declare @a as varbinary(256);  " + vbCrLf
    Dim officeVersion As String = ""
    Dim imaoffice As Boolean = False
    Dim sifist As String
    Dim panelmenucollapse As Boolean
    Dim bbiloCancel As Boolean = False

    Public Sub New(ByVal DBConnectionString As String, ByVal ISTConnectionString As String, ByVal ttab As DatasetIstrazivanja.ISTTABSDataTable, ByVal ri As DatasetIstrazivanja.ISTRow,
                   ByVal mdtLabel As System.Data.DataTable, ByVal mdtAWL As System.Data.DataTable, ByVal mdtQE As System.Data.DataTable, ByVal mdtMessage As System.Data.DataTable,
    ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
    ByVal folder As String, ByVal mmb As DatasetIstrazivanja.ISTBAZERow,
    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String, ByVal txt_DSBrisanjeBaza As String,
    ByVal txt_CAPIServer As String, ByVal txt_CAPIBaza As String,
    ByVal txtmode As String, ByVal jezik As String, ByVal panelmenucollapse As Boolean,
    Optional ByVal txtInst As String = "", Optional ByVal txtPismo As String = "", Optional ByVal txtoffice As String = "",
    Optional ByVal dsPX As DatasetIstrazivanja = Nothing, Optional ByVal PXMETATable As String = Nothing, Optional ByVal kosamnew As String = "")

        Me.New()

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")

        If txtmode.Trim.ToUpper = "CLOUD" Then Call MapirajAzureDrive()

        If txtmode.Trim.ToUpper = "Z" OrElse txtmode.Trim.ToUpper = "ZCAPI" Then
            ButtonPrikaziExcel.Visible = False
            ButtonCSV.Visible = False
            ButtonJSON.Visible = False
            ButtonJSON.Visible = False
            ButtonXML.Visible = False
            ButtonTXT.Visible = False

        End If

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.Logovan.Text = kosamnew 'GetUserName.ToString.Trim

        Me.folder = folder
        Me.jezik = jezik
        Me.ISTConnectionString = ISTConnectionString

        Me.txtmode = txtmode
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtLabel = mdtLabel
        Dim ww As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width()
        Dim hh As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height()

        Me.CAPIServer = txt_CAPIServer
        Me.CAPIBaza = txt_CAPIBaza
        Me.sifist = ri.SIFIST


        Me.Text = Me.Text + " " + txtInst ' + " - " + ri.Naziv.Trim
        Me.ttab = ttab
        Me.mrist = ri
        Me.DBConnectionString = DBConnectionString
        Me.mvt = vt
        ucvt.Init(vt)

        If Not Me.mrist.IsUpitnikNull Then

            Dim up As String = Me.mrist.Upitnik
            'TempAsPathforReports
            'C:\Users\UserName\AppData\Local\Temp\  
            If up.Trim.ToUpper.IndexOf("TEMPASPATHFORREPORTS") >= 0 Then
                folder = Path.GetTempPath()
                folder = folder.TrimEnd("\")
            End If

        End If

        Me.mTrt = folder + "\" + Me.mrist.SIFIST.Trim + ".trt"
        Me.mxls = folder + "\" + Me.mrist.SIFIST.Trim + ".xls"
        Me.mdoc = folder + "\" + Me.mrist.SIFIST.Trim + ".doc"
        Me.mtxt = folder + "\" + Me.mrist.SIFIST.Trim + ".txt"
        Me.mOOCalc = folder + "\" + Me.mrist.SIFIST.Trim + ".ods"
        Me.mdocx = folder + "\" + Me.mrist.SIFIST.Trim + ".docx"
        Me.mdocm = folder + "\" + Me.mrist.SIFIST.Trim + ".docm"
        Me.mdotx = folder + "\" + Me.mrist.SIFIST.Trim + ".dotx"
        Me.mdotm = folder + "\" + Me.mrist.SIFIST.Trim + ".dotm"
        Me.mExcelXML = folder + "\" + Me.mrist.SIFIST.Trim + ".xml"
        Me.dword = folder + "\" + Me.mrist.SIFIST.Trim + ".docx"
        Me.mXML = folder + "\" + Me.mrist.SIFIST.Trim + ".XML"
        Me.mXSL = folder + "\" + Me.mrist.SIFIST.Trim + ".XSL"
        Me.mJSON = folder + "\" + Me.mrist.SIFIST.Trim + ".JSON"
        Me.mCSV = folder + "\" + Me.mrist.SIFIST.Trim + ".csv"
        Me.mxlsm = folder + "\" + Me.mrist.SIFIST.Trim + ".xlsm"
        Me.mxlsm88 = folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm"
        Me.mxlsx = folder + "\" + Me.mrist.SIFIST.Trim + ".xlsx"
        Me.zmcsv = folder + "\z" + Me.mrist.SIFIST.Trim + ".csv"

        Dim r As DatasetIstrazivanja.ISTTABSRow

        Dim dt As New DatasetIstrazivanja.ISTTABSDataTable

        For i As Integer = 0 To ttab.Rows.Count - 1
            dt.ImportRow(ttab.Rows(i))
        Next

        For Each r In dt.Rows
            r.BeginEdit()
            If r.Naziv.Trim = "." Then r.Naziv = ""
            If Not r.IsNazivNull AndAlso r.Naziv.Trim <> "" Then
                Dim p As String = r.Naziv
                p = ZameniGGGMMMBezApostrofa(p, Me.mvt.G.ToString, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""), , 0)
                p = zameniCAPIUSER(p, txtmode, CAPIServer, CAPIBaza)
                p = p.Replace("}", "")
                r.Naziv = p
            End If
            If Not r.IsNazivENull AndAlso r.NazivE.Trim <> "" AndAlso r.NazivE.Trim.ToUpper.IndexOf("VISIBLEFALSEIF=") >= 0 Then
                Dim p As String = r.NazivE.Trim.ToUpper
                p = p.Replace("PIVOTINDEX", "").Replace("PIVOT", "").Replace("#{", "").Replace("VISIBLEFALSEIF=", "")
                p = ZameniGGGMMM(p, Me.mvt.G.ToString, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""), , 1)
                p = zameniCAPIUSER(p, txtmode, CAPIServer, CAPIBaza)
                p = p.Replace("}", "")
                Dim dtt As New Data.DataTable
                If p.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") >= 0 Then p = DeKriptoSQL(p)
                dtt = izvrsiSQLvratiDT(p, DBConnectionString, "")
                If dtt.Rows.Count > 0 AndAlso dtt.Rows(0).Item(0).ToString.Trim.ToUpper = "TRUE" Then r.Delete()
            End If
            r.EndEdit()
        Next

        mb = mmb

        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza

        lokalno = False
        'NS je trazio da za njih se ne radi DEPO pri brisanju
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

        If txtoffice = "PK" Then
            Me.ucvt.Enabled = True
            Me.lblPVT.Visible = True
            ''msg 335
            Dim msgtxt335 As String = getMessageText(dtMessages, "335", Me.jezik)
            Me.lblPVT.Text = msgtxt335 + nvrd + dajDEPOPVT()
        End If


        ListBoxNoviIzvestaj.ValueMember = "RbrTabele"
        ListBoxNoviIzvestaj.DisplayMember = "Naziv"
        ListBoxNoviIzvestaj.DataSource = dt

        btnBack.Location = New System.Drawing.Point(ButtonEndOpenOffice.Location.X + 3, Logovan.Location.Y - btnBack.Width - 10)

        Me.officeVersion = ""
        imaoffice = IsOfficeInstalled()
        If imaoffice = True Then
            Me.officeVersion = Determine_OfficeVersion_1()
        End If
        Call SetLang()
        zapamtilogovanog = Logovan.Text.Trim
        Me.panelmenucollapse = panelmenucollapse
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub
    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formIzvestaji")
        Dim bspace As String = "      "
        ButtonIzvNoviIzvestaj.Text = bspace + getControlText2(dt, "ButtonIzvNoviIzvestaj", Me.jezik)
        ButtonIzvNoviIzvestaj.Tag = ButtonIzvNoviIzvestaj.Text

        ButtonPrikaziExcel.Tag = bspace + ButtonPrikaziExcel.Text
        ButtonCSV.Tag = bspace + ButtonCSV.Text
        ButtonJSON.Tag = bspace + ButtonJSON.Text
        ButtonXML.Tag = bspace + ButtonXML.Text
        ButtonTXT.Tag = bspace + ButtonTXT.Text
        ButtonEndExcel.Text = " " + getControlText2(dt, "ButtonEndExcel", Me.jezik) 'ButtonEndExcel.Text
        pomExcel = ButtonEndExcel.Text
        ButtonEndWord.Text = " " + getControlText2(dt, "ButtonEndWord", Me.jezik) 'ButtonEndWord.Text
        pomWord = ButtonEndWord.Text
        ButtonEndOpenOffice.Text = " " + getControlText2(dt, "ButtonEndOpenOffice", Me.jezik) 'ButtonEndOpenOffice.Text
        pomOF = ButtonEndOpenOffice.Text


        b3.Text = sifist + "    " + String.Format("{0:d2}", Me.mvt.M) + " / " + Me.mvt.G.ToString


    End Sub
    Private Sub ListBoxNoviIzvestaj_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles ListBoxNoviIzvestaj.MeasureItem
        Dim naslovHeight As Integer = 18
        Dim naziv As String = DirectCast(DirectCast(ListBoxNoviIzvestaj.Items(e.Index), System.Data.DataRowView).Row, DatasetIstrazivanja.ISTTABSRow).Naziv
        If naziv.Trim <> "" Then
            naziv = naziv.TrimEnd(";").TrimEnd("$")
            Dim kakoL() As String = naziv.Split("$")
            If kakoL.Length > 0 Then
                For iii As Integer = 0 To kakoL.Length - 1
                    kakoL(iii) = kakoL(iii).Trim.ToUpper
                    If kakoL(iii).IndexOf("HEIGHT") >= 0 Then
                        kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("HEIGHT", "")
                        If IsNumeric(kakoL(iii)) = True Then naslovHeight = CInt(kakoL(iii))
                        If naslovHeight > 500 Then naslovHeight = 500
                        e.ItemHeight = naslovHeight
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub ListBoxNoviIzvestaj_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles ListBoxNoviIzvestaj.DrawItem
        e.DrawBackground()
        If e.Index = -1 Then
            Return
        End If
        Dim naziv As String = DirectCast(DirectCast(ListBoxNoviIzvestaj.Items(e.Index), System.Data.DataRowView).Row, DatasetIstrazivanja.ISTTABSRow).Naziv
        Dim myBrush As Brush = Brushes.Black
        Dim naslovBold As Boolean = False
        Dim naslovItalic As Boolean = False
        Dim naslovUnderline As Boolean = False
        Dim naslovFontSize As Integer = 9
        Dim naslovHeight As Integer
        Dim naslovForeColor As String = "BLACK"
        Dim naslovBackColor As String = ""
        Dim ft As FontStyle = FontStyle.Regular
        Dim ftB As FontStyle = FontStyle.Bold
        Dim ftI As FontStyle = FontStyle.Italic
        Dim ftU As FontStyle = FontStyle.Underline
        If naziv.Trim <> "" Then
            naziv = naziv.TrimEnd(";").TrimEnd("$")
            Dim kakoL() As String = naziv.Split("$")
            If kakoL.Length > 0 Then
                For iii As Integer = 0 To kakoL.Length - 1
                    kakoL(iii) = kakoL(iii).Trim.ToUpper
                    If kakoL(iii).IndexOf("FONTBOLD") >= 0 Then
                        naslovBold = True
                    ElseIf kakoL(iii).IndexOf("FONTSIZE") >= 0 Then
                        kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("FONTSIZE", "")
                        If IsNumeric(kakoL(iii)) = True Then naslovFontSize = CInt(kakoL(iii))
                        'If naslovFontSize > 12 Then naslovFontSize = 12
                    ElseIf kakoL(iii).IndexOf("FONTITALIC") >= 0 Then
                        naslovItalic = True
                    ElseIf kakoL(iii).IndexOf("FONTUNDERLINE") >= 0 Then
                        naslovUnderline = True
                    ElseIf kakoL(iii).IndexOf("FORECOLOR") >= 0 Then
                        kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("FORECOLOR", "")
                        naslovForeColor = kakoL(iii)
                    ElseIf kakoL(iii).IndexOf("BACKCOLOR") >= 0 Then
                        kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("BACKCOLOR", "")
                        naslovBackColor = kakoL(iii)
                    ElseIf kakoL(iii).IndexOf("HEIGHT") >= 0 Then
                        kakoL(iii) = kakoL(iii).Trim.ToUpper.Replace("HEIGHT", "")
                        If IsNumeric(kakoL(iii)) = True Then naslovHeight = CInt(kakoL(iii))
                    End If
                Next
            End If

            naziv = NZ(Replace(naziv, "fontbold", "", 1, , CompareMethod.Text))
            naziv = NZ(Replace(naziv, "fontitalic", "", 1, , CompareMethod.Text))
            naziv = NZ(Replace(naziv, "fontunderline", "", 1, , CompareMethod.Text))
            naziv = NZ(Replace(naziv, "forecolor" + naslovForeColor.ToLower, "", 1, , CompareMethod.Text))
            naziv = NZ(Replace(naziv, "backcolor" + naslovBackColor.ToLower, "", 1, , CompareMethod.Text))
            naziv = NZ(Replace(naziv, "fontsize" + CStr(naslovFontSize).Trim, "", 1, , CompareMethod.Text))
            naziv = NZ(Replace(naziv, "height" + CStr(naslovHeight).Trim, "", 1, , CompareMethod.Text))

            naziv = naziv.Replace("$", "")

            If naslovFontSize = 0 Then naslovFontSize = 10

            'B I U
            If naslovBold = True And naslovItalic = True And naslovUnderline = True Then ft = ftB Or ftI Or ftU
            If naslovBold = True And naslovItalic = True And naslovUnderline = False Then ft = ftB Or ftI
            If naslovBold = True And naslovItalic = False And naslovUnderline = False Then ft = ftB
            If naslovBold = True And naslovItalic = False And naslovUnderline = True Then ft = ftB Or ftU
            If naslovBold = False And naslovItalic = True And naslovUnderline = True Then ft = ftI Or ftU
            If naslovBold = False And naslovItalic = False And naslovUnderline = True Then ft = ftU
            If naslovBold = False And naslovItalic = True And naslovUnderline = False Then ft = ftI

            myBrush = New SolidBrush(System.Drawing.Color.FromName(naslovForeColor))
        End If



        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            Dim HiLiteBrush As New SolidBrush(RGBColors.bBackColor)
            e.Graphics.FillRectangle(HiLiteBrush, e.Bounds)
        ElseIf naslovBackColor <> "" Then
            e.Graphics.FillRectangle(New SolidBrush(System.Drawing.Color.FromName(naslovBackColor)), e.Bounds)
        End If

        Dim f As New System.Drawing.Font(e.Font.FontFamily, naslovFontSize, ft)
        e.Graphics.DrawString(naziv, f, myBrush, e.Bounds, StringFormat.GenericDefault)

        e.DrawFocusRectangle()
    End Sub
    Sub izvestajKon()
        Call SuspendDrawing(ListBoxNoviIzvestaj)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call Izvestaj()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Call ResumeDrawing(ListBoxNoviIzvestaj)
    End Sub
    Private Sub ListBoxNoviIzvestaj_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxNoviIzvestaj.DoubleClick
        Call izvestajKon()
    End Sub
    Private Sub ButtonIzvNoviIzvestaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIzvNoviIzvestaj.Click
        Call izvestajKon()
    End Sub

    Function dajDEPOPVT() As String
        'SAMO PK
        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)
        Dim sql As String = "select ISTYEAR as god,ISTMONTH as mes from ISTPKYEARMONTH where sifist='" + Me.mrist.SIFIST.Trim + "' order by ISTYEAR desc, ISTMONTH desc"
        Dim dt As New Data.DataTable
        dt = izvrsiSQLvratiDT(sql, konDepo, "")
        Dim gg As String = ""
        Dim mm As String = ""
        If dt.Rows.Count > 0 Then
            gg = dt.Rows(0).Item("GOD").ToString.Trim
            mm = dt.Rows(0).Item("MES").ToString.Trim
            Dim dmd As String = mm
            If mm = "00" Then dmd = "12"
            Me.ucvt.MyInit("Vod", "Vdo", Date.MinValue, Date.MaxValue, New Date(CInt(gg), CInt(dmd), 2))
        End If

        Dim sqlm As String = "select ISTYEAR as god,ISTMONTH as mes from ISTPKYEARMONTH where sifist='" + Me.mrist.SIFIST.Trim + "' order by ISTYEAR asc, ISTMONTH asc"
        Dim dtm As New Data.DataTable
        dtm = izvrsiSQLvratiDT(sqlm, konDepo, "")
        Dim ggm As String = ""
        Dim mmm As String = ""
        If dtm.Rows.Count > 0 Then
            ggm = dtm.Rows(0).Item("GOD").ToString.Trim
            mmm = dtm.Rows(0).Item("MES").ToString.Trim
        End If

        If mm = "00" Then
            dajDEPOPVT = ggm & "    -   " & gg
        Else
            dajDEPOPVT = mmm & "." & ggm + "    -   " & mm & "." + gg
        End If

    End Function

    Dim tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka

    Private Function SQl22(ByVal sql2 As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByRef sql As String, ByRef sql3 As String, ByRef col2 As Integer) As String
        Me.tacv = vt
        SQl22 = ""
        imaTransfer = False
        Dim sr As New System.IO.StreamReader(sql2)
        sql = ""
        sql3 = ""
        col2 = 0
        Try
            While sr.Peek() >= 0
                Dim l As String = sr.ReadLine().Trim
                l = ZameniGGGMMM(l, Me.tacv.G.ToString, Me.tacv.M, Me.tacv.vtwhere(""), Me.tacv.GWhere(""), Me.tacv.mWhere(""), Me.tacv.YWhere(""))
                l = zameniCAPIUSER(l, txtmode, CAPIServer, CAPIBaza)
                Dim itag As Integer = l.IndexOf("--", 0)
                If itag <> 0 Then
                    sql = sql + " " + nvrd + l
                Else
                    Dim transfer As Integer = l.ToLower.IndexOf("--transfer", 0)
                    If transfer >= 0 Then
                        imaTransfer = True
                        Exit Function
                    End If
                    '***********
                    'PARAMMMMMM
                    'ako postoji --param zameni ga
                    Dim param As Integer = l.ToLower.IndexOf("--param", 0)
                    If param >= 0 Then

                        lbls = Nothing
                        polja = Nothing

                        Call fparametar(l)
                        bbiloCancel = False
                        Dim funos As FormUnesiParametreOdjednom = New FormUnesiParametreOdjednom(Me.DBConnectionString, Me.mvt, lbls, polja, Me.jezik, Me.txtmode, Me.CAPIServer, Me.CAPIBaza, Me.mrist.SIFIST)
                        funos.ShowDialog()
                        VrPar = funos.VrednostParametra
                        VrDODPar = funos.VrednostDodParametra
                        If DirectCast(funos.ActiveControl, System.Windows.Forms.ButtonBase).Text.Trim.ToUpper = "CANCEL" Then
                            bbiloCancel = True
                            Exit Function
                        End If
                        funos.Dispose()
                        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Dim prazan As Boolean = True
                        For i As Integer = 0 To VrPar.GetUpperBound(0)
                            If Not VrPar(i) Is Nothing Then
                                prazan = False
                                Exit For
                            End If
                        Next
                        If prazan = True Then SQl22 = "" : Exit Function
                        For i As Integer = 0 To VrPar.GetUpperBound(0)
                            If VrPar(i) Is Nothing Then VrPar(i) = ""
                        Next
                    Else
                        'bez parametra
                        Dim i As Integer = l.ToLower.IndexOf("izbaci", 0)
                        If i < 0 Then l.ToLower.IndexOf("remove", 0)
                        'ima izbaci
                        If i >= 0 Then
                            col2 = CInt(l.Substring(i + 6))
                        Else
                            'nije izbaci
                            Dim b As Boolean = False
                            Dim j As Integer = l.ToLower.IndexOf("zadnji", 0)
                            If j < 0 Then l.ToLower.IndexOf("istlast", 0)
                            If j >= 0 Then
                                b = True
                            Else
                                Dim k As Integer = l.ToLower.IndexOf("kraj", 0)
                                If k < 0 Then l.ToLower.IndexOf("istend", 0)
                                If k >= 0 Then
                                    b = True
                                End If
                            End If
                            If b Then
                                While sr.Peek() >= 0
                                    l = sr.ReadLine().Trim
                                    Dim q As Integer = l.IndexOf(";")
                                    If q >= 0 Then
                                        sql3 = sql3 + " " + l.Substring(0, q)
                                        sql = sql + " " + l.Substring(q + 1)
                                        Exit While
                                    Else
                                        sql3 += " " + l
                                    End If
                                End While
                            End If   'if b then
                            ''''''
                        End If   'if i>=0
                        'kraj izbaci
                    End If   'if ii>=0
                    'kraj parametra
                End If   'If itag < 0
            End While
        Finally
            sr.Close()
        End Try
        sql = ZameniGGGMMM(sql, Me.tacv.G.ToString, Me.tacv.M, Me.tacv.vtwhere(""), Me.tacv.GWhere(""), Me.tacv.mWhere(""), Me.tacv.YWhere(""))
        sql = zameniCAPIUSER(sql, txtmode, CAPIServer, CAPIBaza)
        sql = ZameniVodVdo(sql, vt)

        sql = ppreplace(VrPar, VrDODPar, sql, Prmtr)

        If Not (VrPar Is Nothing) Then
            ReDim Preserve nizParametra(VrPar.Length - 1)
            For i As Integer = 0 To VrPar.Length - 1
                If Not (VrPar(i) Is Nothing) Then
                    nizParametra(i) = Prmtr(i).ToString.Trim + "=" + VrPar(i).ToString.Trim
                End If
            Next
        End If
        SQl22 = sql

    End Function

    Public VrPar() As String
    Public VrDODPar() As String
    Public Prmtr() As String
    Dim imaTransfer As Boolean = False

    Private Function SQl222(ByVal sql2 As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                            ByRef sql As String, ByRef sql3 As String, ByRef col2 As Integer, Optional ByVal xmlExec As String = "") As System.Data.DataSet()
        SQl222 = Nothing
        imaTransfer = False
        Dim ds() As System.Data.DataSet = {}
        Dim koloneIzbaci() As Integer = {}
        Dim brojSheet As Integer = 0         'da krenem od nultog (kao niz) to je u stvari 1.
        ReDim Preserve ds(brojSheet)
        ReDim Preserve koloneIzbaci(brojSheet)
        Dim nazivSheet() As String = {}
        Dim startAt() As String = {}
        Dim ll As Integer = 0
        Dim prviSheet As Integer = 0
        Me.tacv = vt

        'Dim sr2 As New System.IO.StreamReader(sql2)
        Dim sr As System.IO.StreamReader

        If xmlExec.Trim <> "" Then
            Dim strAsBytes() As Byte = New System.Text.UTF8Encoding().GetBytes(xmlExec)
            Dim msr As MemoryStream
            msr = New System.IO.MemoryStream(strAsBytes)
            sr = New System.IO.StreamReader(msr)
        Else
            sr = New System.IO.StreamReader(sql2)
        End If

        sql = ""
        sql3 = ""
        Try
            While sr.Peek() >= 0
                Dim l As String = sr.ReadLine().Trim
                l = ZameniGGGMMM(l, Me.tacv.G.ToString, Me.tacv.M, Me.tacv.vtwhere(""), Me.tacv.GWhere(""), Me.tacv.mWhere(""), Me.tacv.YWhere(""))
                l = zameniCAPIUSER(l, txtmode, CAPIServer, CAPIBaza)
                Dim itag As Integer = l.IndexOf("--", 0)
                If itag <> 0 Then
                    sql = sql + " " + nvrd + l
                Else
                    Dim transfer As Integer = l.ToLower.IndexOf("--transfer", 0)
                    If transfer >= 0 Then
                        imaTransfer = True
                        Exit Function
                    End If
                    '***********
                    'PARAMMMMMM
                    'ako postoji --param zameni ga
                    Dim param As Integer = l.ToLower.IndexOf("--param", 0)
                    If param >= 0 Then

                        lbls = Nothing
                        polja = Nothing

                        Call fparametar(l)

                        bbiloCancel = False
                        Dim funos As FormUnesiParametreOdjednom = New FormUnesiParametreOdjednom(Me.DBConnectionString, Me.mvt, lbls, polja, Me.jezik, Me.txtmode, Me.CAPIServer, Me.CAPIBaza, Me.mrist.SIFIST)
                        funos.ShowDialog()
                        VrPar = funos.VrednostParametra
                        VrDODPar = funos.VrednostDodParametra
                        If DirectCast(funos.ActiveControl, System.Windows.Forms.ButtonBase).Text.Trim.ToUpper = "CANCEL" Then
                            bbiloCancel = True
                            Exit Function
                        End If
                        funos.Dispose()
                        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                        Dim prazan As Boolean = True
                        For i As Integer = 0 To VrPar.GetUpperBound(0)
                            If Not VrPar(i) Is Nothing Then
                                prazan = False
                                SQl222 = Nothing
                                Exit For
                            End If
                        Next
                        If prazan = True Then SQl222 = Nothing : Exit Function
                        For i As Integer = 0 To VrPar.GetUpperBound(0)
                            If VrPar(i) Is Nothing Then VrPar(i) = ""
                        Next
                    End If

                    'kraj parametra ako postoji
                    '***********
                    Dim S As Integer = l.ToLower.IndexOf("prvisheet", 0)
                    If S < 0 Then S = l.ToLower.IndexOf("firstsheet", 0)
                    If S >= 0 Then
                        'postoji ime za prvi sheet iz *.sql-a
                        prviSheet = 1
                        ll = 0
                        ReDim Preserve nazivSheet(ll)
                        nazivSheet(ll) = l.ToLower.Replace("prvisheet", "").Replace("firstsheet", "")
                        nazivSheet(ll) = nazivSheet(ll).Replace("--", "")
                    End If
                    'ima noviSheet
                    Dim nS As Integer = l.ToLower.IndexOf("novisheet", 0)
                    If nS < 0 Then nS = l.ToLower.IndexOf("nextsheet", 0)
                    If nS >= 0 Then
                        ll = ll + 1
                        ReDim Preserve nazivSheet(ll)
                        'naziv
                        nazivSheet(ll) = l.ToLower.Replace("novisheet", "").Replace("nextsheet", "")
                        nazivSheet(ll) = nazivSheet(ll).Replace("--", "")

                        sql = ZameniGGGMMM(sql, vt.G.ToString, vt.M, vt.vtwhere(""), vt.GWhere(""), vt.mWhere(""), vt.YWhere(""))
                        sql = ZameniVodVdo(sql, vt)
                        sql = zameniCAPIUSER(sql, txtmode, CAPIServer, CAPIBaza)
                        sql = ppreplace(VrPar, VrDODPar, sql, Prmtr)

                        Dim trtDS As New System.Data.DataSet
                        If sql.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") >= 0 Then sql = DeKriptoSQL(sql)
                        trtDS = izvrsiSQLvratiDS(sql, Me.DBConnectionString, Me.jezik)
                        ds(brojSheet) = trtDS.Copy

                        brojSheet = brojSheet + 1
                        ReDim Preserve ds(brojSheet)
                        sql = ""
                    End If  'od novi sheet
                    Dim izb As Integer = l.ToLower.IndexOf("izbaci", 0)
                    If izb < 0 Then izb = l.ToLower.IndexOf("remove", 0)
                    'ima izbaci

                    If izb >= 0 Then
                        ReDim Preserve koloneIzbaci(brojSheet)
                        koloneIzbaci(brojSheet) = CInt(l.Substring(izb + 6))
                    End If
                    Dim sAt As Integer = l.ToLower.IndexOf("startat", 0)
                    'ima startat
                    If sAt >= 0 Then
                        ReDim Preserve startAt(brojSheet)
                        startAt(brojSheet) = l 'l.Substring(sAt + 7)
                    End If

                End If ' If itag < 0 Then

            End While

            sql = ZameniGGGMMM(sql, vt.G.ToString, vt.M, vt.vtwhere(""), vt.GWhere(""), vt.mWhere(""), vt.YWhere(""))
            sql = ZameniVodVdo(sql, vt)
            sql = zameniCAPIUSER(sql, txtmode, CAPIServer, CAPIBaza)
            sql = ppreplace(VrPar, VrDODPar, sql, Prmtr)

            Dim trtDS1 As New System.Data.DataSet
            Try
                If sql.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") >= 0 Then sql = DeKriptoSQL(sql)
                trtDS1 = izvrsiSQLvratiDS(sql, Me.DBConnectionString, Nothing)
                ds(brojSheet) = trtDS1.Copy
                'poslednji sheet
                'If brojSheet > 0 Then ds(brojSheet).Namespace = nazivSheet.ToUpper
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
            '
            'dopuni izbaciKolone
            Dim pom1 As Integer = UBound(koloneIzbaci)
            If pom1 < brojSheet Then
                For i As Integer = pom1 + 1 To brojSheet
                    ReDim Preserve koloneIzbaci(i)
                    koloneIzbaci(i) = koloneIzbaci(pom1)
                Next
            End If

            'dopuni startAt
            For i As Integer = 0 To brojSheet - 1
                If startAt.Length > 0 AndAlso startAt(i) Is Nothing Then
                    startAt(i) = ""
                End If
            Next

            'izbaciti iz ds-va poslednje kolone
            For ppp As Integer = 0 To brojSheet
                'IZBACI
                Dim dt As System.Data.DataTable
                For i As Integer = 0 To ds(ppp).Tables.Count - 1
                    dt = ds(ppp).Tables(i)
                    For mm As Integer = 1 To koloneIzbaci(ppp)
                        dt.Columns.Remove(dt.Columns(dt.Columns.Count - 1).ColumnName)
                    Next
                    dt.AcceptChanges()
                Next
                ds(ppp).AcceptChanges()
                If ppp > 0 Then
                    ds(ppp).Namespace = nazivSheet(ppp).ToUpper.Trim
                    If startAt.Length > 0 Then ds(ppp).Tables(0).Namespace = startAt(ppp).ToUpper.Trim
                End If
                If prviSheet = 1 Then
                    ds(0).Namespace = nazivSheet(0).ToUpper.Trim
                    If startAt.Length > 0 Then ds(0).Tables(0).Namespace = startAt(0).ToUpper.Trim
                End If
            Next
        Finally
            sr.Close()
        End Try

        If Not (VrPar Is Nothing) Then
            ReDim Preserve nizParametra(VrPar.Length - 1)
            For i As Integer = 0 To VrPar.Length - 1
                If Not (VrPar(i) Is Nothing) Then
                    nizParametra(i) = Prmtr(i).ToString.Trim + "=" + VrPar(i).ToString.Trim
                End If
            Next
        End If

        'sql = pu(Nothing, String.Empty, sql)

        Return ds

    End Function
    Dim lbls() As String
    Dim polja() As String

    Sub fparametar(ByVal l As String)
        Dim prmspom() As String
        Dim poml As String = ""

        'postoji parametar
        While l.IndexOf("  ") >= 0
            l = l.Replace("  ", " ")
        End While
        l = l.Replace(" {", "{").Replace("{ ", "{")
        l = l.Replace(" (", "(").Replace("( ", "(")
        l = l.Replace(" :", ":").Replace(": ", ":")
        l = l.Replace(" CBO", "CBO").Replace("CBO ", "CBO")
        l = l.Replace(" CLBOX", "CLBOX").Replace("CLBOX ", "CLBOX")
        l = l.Replace(" $", "$").Replace("$ ", "$")
        l = l.Replace("--", "").Replace("parametar", "").Replace("PARAMETAR", "").Replace("parameter", "").Replace("PARAMETER", "")
        l = l.Trim

        Dim dd As New Regex("\{.*?\}")
        ReDim polja(Split(dd.Replace(l, "").Replace("{}", "").Replace("CBO", "").Replace("CLBOX", ""), " ").GetUpperBound(0))


        poml = NZ(Replace(l, "*isthide", "", 1, , CompareMethod.Text)).Trim()
        Dim input As String = poml
        Dim replacement As String = ""
        Dim result As String = dd.Replace(input, replacement)
        poml = result.Replace("{}", "").Replace("CBO", "").Replace("CLBOX", "")

        'imena parametara
        prmspom = Split(poml, " ") 'default je " "
        ReDim VrPar(prmspom.GetUpperBound(0))
        ReDim lbls(prmspom.GetUpperBound(0))

        ReDim Prmtr(prmspom.GetUpperBound(0))

        For k As Integer = 0 To prmspom.GetUpperBound(0)
            'parametri
            Prmtr(k) = prmspom(k).Substring(0, prmspom(k).IndexOf(":"))
            'nazivi labela
            lbls(k) = prmspom(k).Substring(prmspom(k).IndexOf(":") + 1).Trim.Replace("_", " ").Trim
        Next
        For k As Integer = 0 To prmspom.GetUpperBound(0)
            Dim nIndexStart As Integer = l.IndexOf(Prmtr(k))
            Dim nIndexEnd As Integer = 0
            If k = prmspom.GetUpperBound(0) Then
                nIndexEnd = l.Length
            Else
                nIndexEnd = l.IndexOf(Prmtr(k + 1))
            End If

            If nIndexStart > -1 AndAlso nIndexEnd > -1 Then '-1 means the word was not found.
                'polja sa dodatnim opisom
                polja(k) = Split(Prmtr(k) + Strings.Mid(l, nIndexStart + Prmtr(k).Length + 1, nIndexEnd - nIndexStart - Prmtr(k).Length), ":")(0)
            End If
        Next
    End Sub

    Function ppreplace(ByVal VrPar() As String, ByVal VrDODPar() As String,
                       ByVal sql As String, ByVal Prmtr() As String) As String

        If Not (VrDODPar Is Nothing) Then
            For k As Integer = 0 To VrDODPar.GetUpperBound(0)
                If Not VrDODPar(k) Is Nothing AndAlso VrDODPar(k).Trim <> "" Then sql = pReplace(sql, Prmtr(k).Trim.ToLower + "name", VrDODPar(k).Trim)
            Next
        End If

        If Not (VrPar Is Nothing) Then
            For k As Integer = 0 To VrPar.GetUpperBound(0)
                sql = pReplace(sql, Prmtr(k).Trim.ToLower, VrPar(k).Trim)
            Next
        End If

        sql = sql.Replace(" =", "=").Replace("= ", "=")
        sql = sql.Replace("' )", "')")
        sql = Replace(sql, "isnull (", "isnull(", 1, , CompareMethod.Text)
        sql = sql.Replace("' ',''", "'',''").Replace("'',' '", "'',''").Replace("' ',' '", "'',''")
        sql = sql.Replace("' ',''", "'',''").Replace("'',' '", "'',''").Replace("' ',' '", "'',''")

        sql = sql.Replace("N' ',''", "N'',N''").Replace("N'',' '", "N'',N''").Replace("N' ',' '", "N'',N''")
        sql = sql.Replace("' ',N''", "N'',N''").Replace("'',N' '", "N'',N''").Replace("' ',N' '", "N'',N''")
        sql = sql.Replace("N' ',N''", "N'',N''").Replace("N'',N' '", "N'',N''").Replace("N' ',N' '", "N'',N''")
        sql = sql.Replace("N' ',''", "N'',N''").Replace("N'',' '", "N'',N''").Replace("N' ',' '", "N'',N''")
        sql = sql.Replace("' ',N''", "N'',N''").Replace("'',N' '", "N'',N''").Replace("' ',N' '", "N'',N''")
        sql = sql.Replace("N' ',N''", "N'',N''").Replace("N'',N' '", "N'',N''").Replace("N' ',N' '", "N'',N''")

        sql = Replace(sql, "isnull('','')=''", "2=2", 1, , CompareMethod.Text)
        sql = Replace(sql, "isnull(N'','')=''", "2=2", 1, , CompareMethod.Text)
        sql = Replace(sql, "isnull('',N'')=''", "2=2", 1, , CompareMethod.Text)
        sql = Replace(sql, "isnull(N'',N'')=''", "2=2", 1, , CompareMethod.Text)
        ppreplace = sql
    End Function

    Private Function ZameniVodVdo(ByVal ss As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka) As String
        Dim s As String = ss.Trim
        Dim sss As String = ss.Trim.ToUpper
        Dim gde As Integer = sss.IndexOf("#VODVDO{")
        While gde >= 0
            Dim doklen As Integer = s.IndexOf("}", gde + 6)
            Dim sta As String = s.Substring(gde, doklen - gde + 1)
            Dim p As String = ""
            If sta.Length > 9 Then p = sta.Substring(8, sta.Length() - 9).Trim
            s = strrpl(s, sta, vt.vWhere("", p, ""))
            sss = s.ToUpper
            gde = sss.IndexOf("#VODVDO{")
        End While
        Return s
    End Function

    Private Function pReplace(ByVal ss As String, ByVal staMenjam As String, ByVal cimeMenjam As String) As String
        Dim odakle As Integer = 0
        Dim GdeSam As Integer = ss.ToLower.IndexOf(staMenjam.ToLower, 0)
        While GdeSam >= 0
            Dim pre As Integer = GdeSam - 1
            Dim iza As Integer = GdeSam + staMenjam.Length()
            Dim cp As Char = " "
            If pre >= 0 Then cp = CType(ss.Substring(pre, 1), Char)
            Dim ci As Char = " "
            If iza < ss.Length() Then ci = CType(ss.Substring(iza, 1), Char)
            If (Not Char.IsLetterOrDigit(cp)) And Not (Char.IsLetterOrDigit(ci)) Then
                ss = ss.Substring(0, pre + 1) & "N'" & cimeMenjam & "'" & ss.Substring(GdeSam + staMenjam.Length())
                odakle = odakle + cimeMenjam.Length() + 2
            Else
                'mora jer ima u parametrima P1,P11,P12 stalno nalazi P1 i nikad ne izlazi iz while-a
                odakle = odakle + staMenjam.Length() + 2
            End If
            If odakle >= ss.Trim.Length Then
                GdeSam = -1
            Else
                GdeSam = ss.ToLower.IndexOf(staMenjam.ToLower, odakle)
            End If
        End While
        Return ss
    End Function

    Public Function gindex(ByVal t As String, ByVal i2 As Integer, ByVal st As String, ByVal et As String) As Integer
        Dim i As Integer = i2
        i = i + st.Length
        Dim tf As Integer = 1
        While tf > 0 AndAlso i < t.Length
            If t.IndexOf(st, i, st.Length) >= 0 Then
                tf = tf + 1
                i = i + st.Length
            ElseIf t.IndexOf(et, i, et.Length) >= 0 Then
                tf = tf - 1
                If tf = 0 Then
                    Return i
                End If
                i = i + et.Length
            Else
                i = i + 1
            End If
        End While
        Return -1
    End Function

    Private Function xf(ByVal k As DatasetIstrazivanja.ISTLKRow, ByVal nf As String, ByVal p As String) As String
        xf = ""
        Dim fn As String = nf.Trim.ToUpper
        Select Case fn
            Case String.Empty
                xf = p
                Return p
            Case "VODVDO"
                xf = Me.ucvt.vWhere(String.Empty, p, String.Empty)
                Return Me.ucvt.vWhere(String.Empty, p, String.Empty)
            Case Else
                ISTMessageBox.Show("Error at function xf", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Function

    Public Sub Excel2(ByVal connString As String, ByVal sql As String, ByVal ikol As Integer, ByVal ws As Object, ByVal tipzaglavlja As String)

        If sql.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") >= 0 Then sql = DeKriptoSQL(sql)
        Dim dst As System.Data.DataSet = izvrsiSQLvratiDS(sql, connString, Me.jezik)

        Dim maxKol As Integer = 1024
        If tipzaglavlja.Trim.ToUpper = ".XLS" OrElse tipzaglavlja.Trim.ToUpper = ".ODS" OrElse tipzaglavlja.Trim.ToUpper = "" Then maxKol = 255

        Dim THstr As String = ""
        Dim TDstr As String = ""

        Dim kk, rr As Integer
        kk = 0 : rr = 0
        For Each dt As System.Data.DataTable In dst.Tables
            rr += dt.Rows.Count
            If dt.Columns.Count > kk Then kk = dt.Columns.Count
        Next

        Dim ImeKolone(maxKol) As String
        Dim brKZ As Integer = 0 'dst.Tables(dst.Tables.Count - 1).Columns.Count - ikol - 1
        If dst.Tables.Count > 0 Then
            brKZ = dst.Tables(dst.Tables.Count - 1).Columns.Count - ikol - 1
            For c As Integer = 0 To brKZ
                ImeKolone(c) = "K_" & c.ToString.Trim & "_" & dst.Tables(dst.Tables.Count - 1).Columns(c).ColumnName
                THstr = THstr + "<TH>" & ImeKolone(c) & "</TH>"
                TDstr = TDstr + "<TD> <xsl:value-of select='" & ImeKolone(c) & "'/> </TD>"
            Next
        End If
        If kk > brKZ Then
            For c As Integer = kk + 1 To brKZ
                ImeKolone(c) = "K_" & c.ToString.Trim & "_?"
                THstr = THstr + "<TH>" & ImeKolone(c) & "</TH>"
                TDstr = TDstr + "<TD> <xsl:value-of select='" & ImeKolone(c) & "'/> </TD>"
            Next
        End If

        Dim fi As New System.IO.FileInfo(Me.mXSL)
        If Not System.IO.Directory.Exists(fi.DirectoryName) Then
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
        End If
        System.IO.File.Delete(Me.mXSL)
        Dim objStreamWriter As System.IO.StreamWriter
        objStreamWriter = New System.IO.StreamWriter(Me.mXSL)
        objStreamWriter.WriteLine("<?xml version='1.0'?>")
        objStreamWriter.WriteLine("<xsl:stylesheet version='1.0' xmlns:xsl='http://www.w3.org/1999/XSL/Transform'>")
        objStreamWriter.WriteLine("<xsl:template match='Podaci'>")
        objStreamWriter.WriteLine("<HTML><BODY>")
        objStreamWriter.WriteLine("<TABLE BORDER='1' CELLPADDING='5'>")
        objStreamWriter.WriteLine("<THEAD>" & THstr & "</THEAD>")
        objStreamWriter.WriteLine("<xsl:for-each select='red'>")
        objStreamWriter.WriteLine("<TR ALIGN='center'>" & TDstr & "</TR>")
        objStreamWriter.WriteLine("</xsl:for-each>")
        objStreamWriter.WriteLine("</TABLE></BODY></HTML>")
        objStreamWriter.WriteLine("</xsl:template></xsl:stylesheet>")
        objStreamWriter.Close()

        fi = New System.IO.FileInfo(Me.mXML)
        If Not System.IO.Directory.Exists(fi.DirectoryName) Then
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
        End If
        System.IO.File.Delete(Me.mXML)

        objStreamWriter = New System.IO.StreamWriter(Me.mXML)
        objStreamWriter.WriteLine("<?xml-stylesheet type='text/xsl' href='" & Me.mrist.SIFIST.Trim & ".XSL" & "'?>")
        objStreamWriter.WriteLine("<Podaci>")

        Dim matdata(rr + 1, kk + 1)
        rr = 0
        For Each dt As System.Data.DataTable In dst.Tables
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim izlazXML As String = "<red>"
                For c As Integer = 0 To dt.Columns.Count - 1 - ikol

                    If dt.Rows(i).IsNull(c) Then
                        matdata(i + rr, c) = ""
                    Else
                        matdata(i + rr, c) = dt.Rows(i).Item(c)
                    End If

                    If dt.Rows(i).IsNull(c) Then
                        izlazXML = izlazXML + "<" & ImeKolone(c) & "> </" & ImeKolone(c) & ">"
                    Else
                        izlazXML = izlazXML + "<" & ImeKolone(c) & ">" & XMLizeString(dt.Rows(i).Item(c)) & "</" & ImeKolone(c) & ">"
                    End If
                Next
                izlazXML = izlazXML + "</red>"
                objStreamWriter.WriteLine(izlazXML)
            Next
            rr = rr + dt.Rows.Count
        Next
        objStreamWriter.WriteLine("</Podaci>")
        objStreamWriter.Close()

        'JSON
        fi = New System.IO.FileInfo(Me.mJSON)
        If Not System.IO.Directory.Exists(fi.DirectoryName) Then
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
        End If
        System.IO.File.Delete(Me.mJSON)
        objStreamWriter = New System.IO.StreamWriter(Me.mJSON)

        Dim sbJson As System.Text.StringBuilder = New System.Text.StringBuilder
        If dst.Tables.Count > 0 AndAlso dst.Tables(0).Rows.Count > 0 Then
            objStreamWriter.WriteLine("{" + """" + Me.mrist.SIFIST.Trim + """" + ":[" + nvrd)
            For i As Integer = 0 To dst.Tables(0).Rows.Count - 1
                objStreamWriter.WriteLine("{")
                For j As Integer = 0 To dst.Tables(0).Columns.Count - 1
                    If j < dst.Tables(0).Columns.Count - 1 Then
                        objStreamWriter.WriteLine("""" + dst.Tables(0).Columns(j).ColumnName.ToString() + """:" + """" + dst.Tables(0).Rows(i)(j).ToString() + """,")
                    ElseIf j = dst.Tables(0).Columns.Count - 1 Then
                        objStreamWriter.WriteLine("""" + dst.Tables(0).Columns(j).ColumnName.ToString() + """:" + """" + dst.Tables(0).Rows(i)(j).ToString() + """")
                    End If
                Next
                If i = dst.Tables(0).Rows.Count - 1 Then
                    objStreamWriter.WriteLine("}")
                Else
                    objStreamWriter.WriteLine("},")
                End If
            Next
            objStreamWriter.WriteLine(nvrd + "]}")
        Else
        End If
        objStreamWriter.Close()

        'CSV
        fi = New System.IO.FileInfo(Me.mCSV)
        If Not System.IO.Directory.Exists(fi.DirectoryName) Then
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
        End If
        System.IO.File.Delete(Me.mCSV)
        objStreamWriter = New System.IO.StreamWriter(Me.mCSV)

        Dim sbCSV As System.Text.StringBuilder = New System.Text.StringBuilder
        If dst.Tables.Count > 0 AndAlso dst.Tables(0).Rows.Count > 0 Then

            For j As Integer = 0 To dst.Tables(0).Columns.Count - 1
                objStreamWriter.WriteLine(dst.Tables(0).Columns(j).ColumnName.ToString() + ";")
            Next
            objStreamWriter.WriteLine(nvrd)

            For i As Integer = 0 To dst.Tables(0).Rows.Count - 1
                For j As Integer = 0 To dst.Tables(0).Columns.Count - 1
                    If j < dst.Tables(0).Columns.Count - 1 Then
                        objStreamWriter.WriteLine(dst.Tables(0).Rows(i)(j).ToString() + ";")
                    ElseIf j = dst.Tables(0).Columns.Count - 1 Then
                        objStreamWriter.WriteLine(dst.Tables(0).Rows(i)(j).ToString() + "")
                    End If
                Next
                objStreamWriter.WriteLine(nvrd)
            Next
        Else
        End If
        objStreamWriter.Close()

        'KONACAN ISPIS

        Dim pocExcel As String = "A1"
        If jesteExcelXML = 1 Then
        Else

            If matdata.GetUpperBound(1) > 0 Then
                If ppxlsm = True Then pocExcel = "A" & olastRowzaglavlje.ToString.Trim
                ws.Range(pocExcel).Resize(matdata.GetUpperBound(0), matdata.GetUpperBound(1)).value = matdata
            End If
            ws.Columns.AutoFit()

        End If
    End Sub

    Private Sub Excel3AutomatskiMakro(ByVal ppdatestart As Date, ByVal r As DatasetIstrazivanja.ISTTABSRow, ByVal makro As Integer, Optional ByVal ime As String = "")

        Dim fnm As String = ""

        If makro = 1 Then fnm = "ISTMacro.xls"                 'asa
        If makro = 2 Then fnm = "ISTmPivotChart.xlsm"          'pivot
        If makro = 3 Then fnm = "ISTmPivotChartIndex.xlsm"     'pivot Line
        If makro = 4 Then fnm = "ISTmStartAt.xlsm"              'startAt

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a2 As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim pgm As Microsoft.Office.Interop.Excel.Workbook = Nothing


        Try
            If Me.officeVersion >= "2007" Then
                wb = a2.Workbooks.Open(Me.mxlsm)
            Else
                wb = a2.Workbooks.Open(Me.mxls)
                MsgBox("You can't work with macroes if you have office less then 2007!")
                Exit Sub
            End If

            Dim fi As New System.IO.FileInfo(Me.GetType.Assembly.Location)
            Dim wt As Object = fi.DirectoryName + "\" + fnm
            pgm = a2.Workbooks.Open(wt) 'ovaj red mora, inace ne radi

            Dim fi2 As New System.IO.FileInfo(fnm)
            If makro = 1 Then     'asa
                Dim mn As String = fnm.Replace(".xls", "")
                Try
                    a2.Run(fi2.Name.Trim + "!" + mn.Trim, r.SIFIST.Trim + ".xlsm", ucvt.G.ToString, ucvt.M.ToString)
                    wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                Catch ex As System.Runtime.InteropServices.ExternalException
                    If ex.ErrorCode = -2146827284 Then
                        a2.Run(fi2.Name.Trim + "!" + mn.Trim)
                        wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                    End If
                End Try
            Else
                Dim mn As String = fnm.Replace(".xlsm", "")
                Try
                    If makro = 3 Then
                        a2.Run(fi2.Name.Trim + "!" + mn.Trim, r.SIFIST.Trim + ".xlsm", ime.Trim.ToUpper)
                        wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                    Else    '2 i 4
                        a2.Run(fi2.Name.Trim + "!" + mn.Trim, r.SIFIST.Trim + ".xlsm")
                        wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                    End If
                Catch ex As System.Runtime.InteropServices.ExternalException
                    If ex.ErrorCode = -2146827284 Then
                        a2.Run(fi2.Name.Trim + "!" + mn.Trim)
                        wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                    End If
                End Try
            End If
            wb.Save()
        Catch ex As System.Runtime.InteropServices.ExternalException
            If ex.ErrorCode <> -2146788248 AndAlso ex.ErrorCode <> -2147417848 Then
                Throw ex
            End If
        Finally
            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=False)
                Catch
                End Try
            End If

            a2.Quit()
            If Not ws Is Nothing Then Marshal.ReleaseComObject(ws)
            Marshal.ReleaseComObject(wb)
            Marshal.ReleaseComObject(a2)
            GC.Collect()
            GC.WaitForPendingFinalizers()

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)

            Call sredi88()


        End Try
    End Sub

    Private Sub Excel3(ByVal ppdatestart As Date, ByVal r As DatasetIstrazivanja.ISTTABSRow, ByVal rExcel As String)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a2 As New Microsoft.Office.Interop.Excel.Application
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = Nothing

        'a2.Visible = True
        Try
            wb = a2.Workbooks.Open(Me.mxls)

            Call SaveAsXLSM(a2, wb, Me.mxls)  'u  Me.mxlsm je
            If Not r.IsExcelNull AndAlso r.Excel.Trim <> "" Then
                Try
                    Dim folderZaGen As String = ""
                    If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                        folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper
                    Else
                        folderZaGen = Me.mrist.TxtDir.Trim
                    End If
                    a2.Workbooks.Open(folderZaGen + "\" + r.Excel)
                Catch ex1 As System.Runtime.InteropServices.ExternalException
                    Throw ex1
                End Try

                Dim fi2 As New System.IO.FileInfo(r.Excel)
                Dim mn As String = fi2.Name.Replace(fi2.Extension, "")

                'a2.AutomationSecurity = Microsoft.Office.Core.MsoAutomationSecurity.msoAutomationSecurityLow
                'Dim oBook As Workbook
                'For Each oBook In a2.Workbooks
                '    MsgBox(oBook.Name)
                'Next
                Try
                    a2.Run(fi2.Name.Trim + "!" + mn.Trim + "(" + ucvt.G.ToString + "," + ucvt.M.ToString + ")") ', varg1:=ucvt.G.ToString, varg2:=ucvt.M.ToString)
                    wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                Catch ex As System.Runtime.InteropServices.ExternalException
                    If ex.ErrorCode = -2146827284 Then
                        a2.Run(fi2.Name.Trim + "!" + mn.Trim)
                        wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                    End If
                End Try
                wb.Save()
            End If
        Catch ex As System.Runtime.InteropServices.ExternalException
            If ex.ErrorCode <> -2146788248 Then
                Throw ex
            End If
        Finally

            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=False)
                Catch
                End Try
            End If

            a2.Quit()
            If Not ws Is Nothing Then Marshal.ReleaseComObject(ws)
            Marshal.ReleaseComObject(wb)
            Marshal.ReleaseComObject(a2)
            GC.Collect()
            GC.WaitForPendingFinalizers()

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)

            Call sredi88()



        End Try

    End Sub

    Private Sub Report2(ByVal ppdatestart As Date, ByVal s As String, ByVal sql As String, ByVal sql2 As String, ByVal ikol As Integer, ByVal r As DatasetIstrazivanja.ISTTABSRow)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a2 As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = Nothing
        'Dim wbm As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim pgm As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Try

            Dim fi As New System.IO.FileInfo(Me.mxls)
            Dim fim As New System.IO.FileInfo(Me.mxlsm)
            Dim fix As New System.IO.FileInfo(Me.mxlsx)

            If rExcelZag <> "" Then
                If rExcelZag = "XLSM" Then
                    If Not System.IO.Directory.Exists(fim.DirectoryName) Then System.IO.Directory.CreateDirectory(fim.DirectoryName)
                    System.IO.File.Delete(Me.mxlsm)
                    'FileCopy(Me.mrist.TxtDir.Trim + "\" + r.ExcelZag, Me.mxlsm)

                    If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                        FileCopy(GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.ExcelZag, Me.mxlsm)
                    Else
                        FileCopy(Me.mrist.TxtDir.Trim + "\" + r.ExcelZag, Me.mxlsm)
                    End If


                    wb = a2.Workbooks.Open(Me.mxlsm)
                    ws = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                    Me.SQL3(s, sql, sql2, ikol, ws, ".xlsm")
                    wb.Names.Add(Name:="GGG", RefersToR1C1:=ucvt.G.ToString)  '<-moze i ovo, ali opet izbacuje warning "=Sheet2!R1C1"
                    wb.Names.Add(Name:="YYY", RefersToR1C1:=ucvt.G.ToString)
                    wb.Names.Add(Name:="MMM", RefersToR1C1:=ucvt.M.ToString)  '"=Sheet2!R1C2")
                    wb.Save()

                ElseIf rExcelZag = "XLSX" Then
                    wb = a2.Workbooks.Add
                    Try
                        ws = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                        Me.SQL3(s, sql, sql2, ikol, ws, ".xlsx")
                    Catch ex As Exception
                        Throw ex
                    End Try

                    wb.Names.Add(Name:="GGG", RefersToR1C1:=ucvt.G.ToString)  '<-moze i ovo, ali opet izbacuje warning "=Sheet2!R1C1"
                    wb.Names.Add(Name:="YYY", RefersToR1C1:=ucvt.G.ToString)
                    wb.Names.Add(Name:="MMM", RefersToR1C1:=ucvt.M.ToString)  '"=Sheet2!R1C2")

                    If Not System.IO.Directory.Exists(fix.DirectoryName) Then System.IO.Directory.CreateDirectory(fix.DirectoryName)

                    System.IO.File.Delete(Me.mxlsx)
                    wb.SaveAs(Me.mxlsx)

                    'Call SaveAsXLSM(a2, wb, Me.mxlsx)

                ElseIf rExcelZag = "XLS" Then
                    wb = a2.Workbooks.Add
                    ws = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
                    Me.SQL3(s, sql, sql2, ikol, ws, ".XLS")

                    wb.Names.Add(Name:="GGG", RefersToR1C1:=ucvt.G.ToString)  '<-moze i ovo, ali opet izbacuje warning "=Sheet2!R1C1"
                    wb.Names.Add(Name:="YYY", RefersToR1C1:=ucvt.G.ToString)
                    wb.Names.Add(Name:="MMM", RefersToR1C1:=ucvt.M.ToString)  '"=Sheet2!R1C2")

                    If Not System.IO.Directory.Exists(fi.DirectoryName) Then System.IO.Directory.CreateDirectory(fi.DirectoryName)

                    System.IO.File.Delete(Me.mxls)
                    wb.SaveAs(Me.mxls)

                    'Call SaveAsXLSM(a2, wb, Me.mxls)

                End If
            Else
                'nema zaglavlje
                wb = a2.Workbooks.Add
                ws = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

                Me.SQL3(s, sql, sql2, ikol, ws, "")

                wb.Names.Add(Name:="GGG", RefersToR1C1:=ucvt.G.ToString)  '<-moze i ovo, ali opet izbacuje warning "=Sheet2!R1C1"
                wb.Names.Add(Name:="YYY", RefersToR1C1:=ucvt.G.ToString)
                wb.Names.Add(Name:="MMM", RefersToR1C1:=ucvt.M.ToString)  '"=Sheet2!R1C2")

                If Not System.IO.Directory.Exists(fi.DirectoryName) Then System.IO.Directory.CreateDirectory(fi.DirectoryName)

                System.IO.File.Delete(Me.mxls)
                wb.SaveAs(Me.mxls)

                'Call SaveAsXLSM(a2, wb, Me.mxls)
            End If

            If OpenOffice = False AndAlso Not r.IsExcelNull AndAlso r.Excel.Trim <> "" Then
                pgm = a2.Workbooks.Open(Me.mrist.TxtDir.Trim + "\" + r.Excel)
                If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                    pgm = a2.Workbooks.Open(GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.Excel)
                Else
                    pgm = a2.Workbooks.Open(Me.mrist.TxtDir.Trim + "\" + r.Excel)
                End If

                Dim fi2 As New System.IO.FileInfo(r.Excel)
                Dim mn As String = fi2.Name.Replace(fi2.Extension, "")

                'Dim oBook As Workbook
                'For Each oBook In a2.Workbooks
                '    MsgBox(oBook.Name)
                'Next

                Try
                    a2.Run(fi2.Name.Trim + "!" + mn.Trim + "(" + ucvt.G.ToString + "," + ucvt.M.ToString + ")") ', varg1:=ucvt.G.ToString, varg2:=ucvt.M.ToString)
                    wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                Catch ex As System.Runtime.InteropServices.ExternalException
                    If ex.ErrorCode = -2146827284 Then
                        a2.Run(fi2.Name.Trim + "!" + mn.Trim)
                        wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                    Else
                        Throw ex
                    End If
                End Try
                wb.Save()
            End If
        Catch ex As System.Runtime.InteropServices.ExternalException
            If ex.ErrorCode <> -2146788248 Then
                Throw ex
            End If
        Finally

            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=False)
                Catch
                End Try
            End If
            If Not pgm Is Nothing Then
                Try
                    pgm.Close(SaveChanges:=False)
                Catch
                End Try
            End If

            a2.Quit()

            If Not ws Is Nothing Then Marshal.ReleaseComObject(ws)
            If Not wb Is Nothing Then Marshal.ReleaseComObject(wb)
            If Not pgm Is Nothing Then Marshal.ReleaseComObject(pgm)
            Marshal.ReleaseComObject(a2)

            GC.Collect()
            GC.WaitForPendingFinalizers()

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)

            Call sredi88()
        End Try
    End Sub
    Private Sub SQL3(ByVal connString As String, ByVal sql As String, ByVal sql2 As String, ByVal ikol As Integer, ByVal ws As Object, ByVal tipzaglavlja As String)

        Try
            Me.Excel2(connString, sql, ikol, ws, tipzaglavlja)

            If sql2 <> "" Then
                Dim ok1 As String = izvrsiSQL(sql2, connString)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show(sql2 + nvrd + nvrd + "is not executed! ER44", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As System.Exception
            ''msg 232
            Dim msgtxt232 As String = getMessageText(dtMessages, "232", Me.jezik)
            ''msg 233
            Dim msgtxt233 As String = getMessageText(dtMessages, "233", Me.jezik)
            ''msg 234
            Dim msgtxt234 As String = getMessageText(dtMessages, "234", Me.jezik)
            ''msg 235
            Dim msgtxt235 As String = getMessageText(dtMessages, "235", Me.jezik)
            ''msg 236
            Dim msgtxt236 As String = getMessageText(dtMessages, "236", Me.jezik)
            Dim por As String = msgtxt232 + vbCrLf + " - " + msgtxt233 + vbCrLf + " - " + msgtxt234 + vbCrLf + " - " + msgtxt235 + vbCrLf
            ISTMessageBox.Show(por + vbCrLf + ex.Message, msgtxt236, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub program(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = fn
        p.UseShellExecute = b
        If p.UseShellExecute Then
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Else
            p.WorkingDirectory = wd
            p.Arguments = a
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Try
            System.Diagnostics.Process.Start(p)
        Catch ex As System.Exception
            ''msg 237
            Dim msgtxt237 As String = getMessageText(dtMessages, "237", Me.jezik)
            ''msg 238
            Dim msgtxt238 As String = getMessageText(dtMessages, "238", Me.jezik)
            ''msg 239
            Dim msgtxt239 As String = getMessageText(dtMessages, "239", Me.jezik)
            ISTMessageBox.Show(msgtxt237 + vbCrLf + vbCrLf + msgtxt238 + vbCrLf + vbCrLf + msgtxt239 + vbCrLf + vbCrLf + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub

    Public Sub program22(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = fn
        p.UseShellExecute = b
        If p.UseShellExecute Then
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Else
            p.WorkingDirectory = wd
            p.Arguments = a
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Try
            System.Diagnostics.Process.Start(p)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message.Trim.ToUpper + vbCrLf + vbCrLf + fn.Trim.ToUpper, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub
    Public navedenUpit As Boolean = True
    Public Sub Izvestaj()

        VrPar = Nothing
        VrDODPar = Nothing
        Prmtr = Nothing

        Dim r As DatasetIstrazivanja.ISTTABSRow = Nothing
        If Me.ttab.Rows.Count > 0 Then
            Do
                For Each r In Me.ttab.Rows
                    If r.RbrTabele = CStr(Me.ListBoxNoviIzvestaj.SelectedValue) Then
                        Exit Do
                    End If
                Next
            Loop While False

            If (r.IsUpitZaTabeluNull OrElse r.UpitZaTabelu.Trim = "") AndAlso r.IsRIPORTNull = False AndAlso r.RIPORT.Trim <> "" Then
                Dim f As String = ""
                If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                    f = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.RIPORT.Trim
                Else
                    f = Me.mrist.TxtDir.Trim + "\" + r.RIPORT.Trim
                End If

                If r.RIPORT.Trim.ToUpper.IndexOf("HTTPS:") = 0 OrElse r.RIPORT.Trim.ToUpper.IndexOf("WWW.") = 0 Then
                    f = r.RIPORT.Trim
                End If

                program22(f, True, "", "")

            Else
                formirajIzvestaj()
                If lokalno = False Then
                    If r.IsUpitZaTabeluNull Then r.UpitZaTabelu = ""
                    Call UpisiUISTLogKoriscenjaProcesa("Reports", r.Naziv.Trim, r.UpitZaTabelu.Trim)
                End If
            End If
        End If
    End Sub

    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, Optional ByVal izvestaj As String = "", Optional ByVal upit As String = "")
        Dim sifist As String = Me.mrist.SIFIST
        Dim god As String = Me.mvt.G.ToString
        Dim mes As String = String.Format("{0:d2}", Me.mvt.M)
        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
                & "(SifIst,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
                & " values( " _
                & "N'" & sifist & "','" & god & "','" & mes & "'," _
                & "'" & proces & "',N'" + izvestaj & "','" + upit & "'," _
                & "N'" & GetUserName.ToString.Trim & "'," _
                & "" & "(select top 1 GETDATE())" & ");" + nvrd

        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)

        Dim ok1 As String = izvrsiSQL(strSQL, konDepo)
        If ok1 <> "ok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER69", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Sub formirajIzvestaj()

        If ListBoxNoviIzvestaj.SelectedItem Is Nothing Then
            ''msg 240
            Dim msgtxt240 As String = getMessageText(dtMessages, "240", Me.jezik)
            ISTMessageBox.Show(msgtxt240, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        ''msg 336
        Dim msgtxt336 As String = getMessageText(dtMessages, "336", Me.jezik)
        ''msg 337
        Dim msgtxt337 As String = getMessageText(dtMessages, "337", Me.jezik)
        Dim vrtacka As String = msgtxt336 + ucvt.M.ToString.Trim + msgtxt337 + ucvt.G.ToString.Trim
        Dim r As DatasetIstrazivanja.ISTTABSRow
        Do
            For Each r In Me.ttab.Rows
                If r.RbrTabele = CStr(ListBoxNoviIzvestaj.SelectedValue) Then
                    Exit Do
                End If
            Next
            Return
        Loop While False
        Dim porukaJe As String = ""
        Dim dijalog As Boolean = False
        If r.IsOpisTabeleNull = False AndAlso r.OpisTabele.Trim <> "" Then
            porukaJe = r.OpisTabele
            If porukaJe.IndexOf("DIJALOG") >= 0 Then
                porukaJe = System.Text.RegularExpressions.Regex.Replace(porukaJe, "([Dd][Ii][Jj][Aa][Ll][Oo][Gg][;])", "")
                dijalog = True
            End If
            If porukaJe.IndexOf("DIALOG") >= 0 Then
                porukaJe = System.Text.RegularExpressions.Regex.Replace(porukaJe, "([Dd][Ii][Aa][Ll][Oo][Gg][;])", "")
                dijalog = True
            End If
            porukaJe = System.Text.RegularExpressions.Regex.Replace(porukaJe, "([Pp][Oo][Rr][Uu][Kk][Aa][Jj][Ee][=])", "")
            porukaJe = System.Text.RegularExpressions.Regex.Replace(porukaJe, "([Mm][Ss][Gg][Ii][Ss][=])", "")
            porukaJe = porukaJe.Replace("#{", "")
            porukaJe = porukaJe.Replace("}", "")
            porukaJe = porukaJe.Replace(vbCrLf, "")
            porukaJe = porukaJe.Replace(vbCrLf, "")
        Else
            Call DajIzvestaj(r)
        End If

        If porukaJe <> "" Then
            porukaJe = r.Naziv.Trim + nvrd + vrtacka + nvrd + nvrd + porukaJe
            If dijalog = True Then
                Dim dr As DialogResult = ISTMessageBox.Show(porukaJe, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If dr <> DialogResult.Yes Then
                    Return
                Else
                    Call DajIzvestaj(r)
                End If
            Else
                'samo poruka
                ''msg 187
                Dim msgtxt187 As String = getMessageText(dtMessages, "187", Me.jezik)
                ISTMessageBox.Show(porukaJe, msgtxt187, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Call DajIzvestaj(r)
            End If
        End If
    End Sub

    Public nizParametra() As String
    Public jesteExcelXML As Integer = 0
    Public viseZaglavlja As Boolean

    Function xml(ByVal r As DatasetIstrazivanja.ISTTABSRow, ByVal sf As String, ByVal sql As String, ByVal sz As String, ByVal ikol As Integer, Optional ByVal xmlExec As String = "") As String
        xml = "..."

        'pravi podatke (ds-ove) za fajl excel xml
        jesteExcelXML = 1
        Dim nizdss() As System.Data.DataSet

        nizdss = Me.SQl222(sf, ucvt, sql, sz, ikol, xmlExec)

        If imaTransfer = True Then
            nizdss = Me.ttransfer(sf, ucvt, sql, sz, ikol)
        End If

        If nizdss Is Nothing OrElse nizdss.Length = 0 Then
            xml = ""
            Exit Function
        End If
        'Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim rExcelZag As String = r.ExcelZag.ToString.Trim.ToUpper
        Dim rExcel As String = ""
        If excelPgm = True Then rExcel = r.Excel.ToString.Trim.ToUpper

        viseZaglavlja = False
        If rExcelZag.Length > 0 AndAlso rExcelZag.Trim.IndexOf("#{") = 0 Then
            Dim Zag As String = ""
            Dim nizZag() As String = {}
            Dim ZagAKO As String = ""
            Dim nizZagAKO() As String = {}
            Dim Makro As String = ""
            Dim nizMakro() As String = {}
            Dim nizProvera() As String = {}
            viseZaglavlja = True
            rExcelZag = rExcelZag.Replace("#{", "")
            rExcelZag = rExcelZag.Replace("}", "")
            rExcelZag = rExcelZag.Replace(vbCrLf, "")
            nizProvera = Microsoft.VisualBasic.Split(rExcelZag, ";")
            For i As Integer = 0 To nizProvera.GetUpperBound(0)
                If nizProvera(i).IndexOf("ZAGL=") >= 0 Then
                    Zag = nizProvera(i).Replace("ZAGL=", "")
                    nizZag = Microsoft.VisualBasic.Split(Zag, "$")
                End If
                If nizProvera(i).IndexOf("HEADERIS=") >= 0 Then
                    Zag = nizProvera(i).Replace("HEADERIS=", "")
                    nizZag = Microsoft.VisualBasic.Split(Zag, "$")
                End If
                If nizProvera(i).IndexOf("ZAGLAKO=") >= 0 Then
                    ZagAKO = nizProvera(i).Replace("ZAGLAKO=", "")
                    nizZagAKO = Microsoft.VisualBasic.Split(ZagAKO, "$")
                End If
                If nizProvera(i).IndexOf("HEADERIF=") >= 0 Then
                    ZagAKO = nizProvera(i).Replace("HEADERIF=", "")
                    nizZagAKO = Microsoft.VisualBasic.Split(ZagAKO, "$")
                End If
                If nizProvera(i).IndexOf("MAKRO=") >= 0 Then
                    Makro = nizProvera(i).Replace("MAKRO=", "")
                    Makro = Makro.Trim
                    Dim broj As Integer = Makro.Trim.Split("$").Length - 1
                    Makro = Makro + "".PadLeft(nizZagAKO.Length - 1 - broj, "$")
                    nizMakro = Microsoft.VisualBasic.Split(Makro, "$")
                End If
            Next

            'poredjenje
            Dim kojeZagl As Integer = -1
            If nizZagAKO.Length > 0 AndAlso nizZag.Length > 0 Then
                For i As Integer = 0 To nizParametra.GetUpperBound(0)
                    If Not (nizParametra(i) Is Nothing) Then
                        For k As Integer = 0 To nizZagAKO.GetUpperBound(0)
                            If nizParametra(i).ToUpper.Trim = nizZagAKO(k).ToUpper.Trim Then
                                kojeZagl = k
                                Exit For
                            End If
                        Next
                    End If
                Next
            End If
            If kojeZagl = -1 Then
                ''msg 241
                Dim msgtxt241 As String = getMessageText(dtMessages, "241", Me.jezik)
                ISTMessageBox.Show(msgtxt241, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                rExcelZag = "BEZZAGLAVLJA.XML"
                rExcel = ""
            Else
                rExcelZag = nizZag(kojeZagl)
                rExcel = nizMakro(kojeZagl)
            End If
        End If

        If oopenofficeods = True Then
            Dim iimmmee As String = Me.napraviExcelXML(nizdss, r, rExcelZag, True)
            Exit Function
        End If

        'nije open offfice
        If rExcelZag = "BEZZAGLAVLJA.XML" Or rExcelZag = "WITHOUTHEADER.XML" Then
            ppdatestart = Date.Now
            Me.ExportToExcel(nizdss, r, ppdatestart)
        Else
            Dim ISTmakro As Boolean = False
            Dim mozeMacro As Boolean = False
            For k As Integer = 0 To nizdss.Length - 1
                For i As Integer = 0 To nizdss(k).Tables.Count - 1
                    Dim brojK As Integer = nizdss(k).Tables(i).Columns.Count
                    Dim nazivK As String = CType(CType(nizdss(k).Tables(i), System.Data.DataTable).Columns, System.Data.DataColumnCollection).Item(brojK - 1).ToString.Trim.ToUpper
                    If nazivK.IndexOf("ISTASA") >= 0 Then
                        'IDE MAKRO IZ ISTA
                        ISTmakro = True
                        For red As Integer = 0 To nizdss(k).Tables(i).Rows.Count - 1
                            nizdss(k).Tables(i).Rows(red)("ISTASA") = "ISTASA;" + nizdss(k).Tables(i).Rows(red)("ISTASA")
                        Next
                    End If
                    '***ako je sve prazno ne puštaju se makroi
                    If nizdss(k).Tables(i).Rows.Count > 0 Then mozeMacro = True
                    '***
                Next
            Next

            Dim iimmmee As String = Me.napraviExcelXML(nizdss, r, rExcelZag)
            'ovde je vec napravljen xls ili xlsx
            ppdatestart = Date.Now
            If ISTmakro = True Then Call Excel3AutomatskiMakro(ppdatestart, r, 1)

            'ide uvek
            If startAt.Length > 0 Then
                Call Excel3AutomatskiMakro(ppdatestart, r, 4, iimmmee)
            End If
            If mozeMacro = True Then
                If excelPivot = True AndAlso Me.officeVersion >= "2007" Then Call Excel3AutomatskiMakro(ppdatestart, r, 2)
                If excelPivotIndex = True AndAlso Me.officeVersion >= "2007" Then Call Excel3AutomatskiMakro(ppdatestart, r, 3, iimmmee)
                'ako postoje makroi da se pokrenu
                If excelPgm = True Then Me.Excel3(ppdatestart, r, rExcel)
            End If

        End If

        Me.obicanXML(nizdss)
        Me.obicanJSON(nizdss)
        Me.obicanCSV(nizdss)


        If txtfile = True Then
            Me.obicanTXTtxt(nizdss, True)
        End If

        ''msg 242
        Dim msgtxt242 As String = getMessageText(dtMessages, "242", Me.jezik)
        ISTMessageBox.Show(msgtxt242, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Function
    Dim startAt() As String = {}
    Function ttransfer(ByVal sql2 As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByRef sql As String, ByRef sql3 As String, ByRef col2 As Integer) As System.Data.DataSet()
        ttransfer = Nothing
        Dim ds() As System.Data.DataSet = {}
        Dim koloneIzbaci() As Integer = {}
        Dim brojSheet As Integer = -1     'da krenem od nultog (kao niz) to je u stvari 1.
        ReDim Preserve ds(brojSheet)
        ReDim Preserve koloneIzbaci(brojSheet)
        Dim nazivSheet() As String = {}
        Dim ll As Integer = 0
        Dim prviSheet As Integer = 0
        Me.tacv = vt

        sql = ""
        sql3 = ""
        Try
            Dim txt As New System.IO.StreamReader(sql2)
            sql = txt.ReadToEnd
            txt.Close()

            Dim sr As New System.IO.StreamReader(sql2)
            Dim sql2pom As String = ""
            While sr.Peek() >= 0
                Dim l As String = sr.ReadLine().Trim
                l = ZameniGGGMMM(l, Me.tacv.G.ToString, Me.tacv.M, Me.tacv.vtwhere(""), Me.tacv.GWhere(""), Me.tacv.mWhere(""), Me.tacv.YWhere(""))
                l = zameniCAPIUSER(l, txtmode, CAPIServer, CAPIBaza)
                '***********
                'PARAMMMMMM
                'ako postoji --param zameni ga
                Dim param As Integer = l.ToLower.IndexOf("--param", 0)
                If param >= 0 Then
                    lbls = Nothing
                    polja = Nothing
                    Call fparametar(l)
                    l = NZ(Replace(l, "*isthide", "", 1, , CompareMethod.Text)).Trim()
                    bbiloCancel = False
                    Dim funos As FormUnesiParametreOdjednom = New FormUnesiParametreOdjednom(Me.DBConnectionString, Me.mvt, lbls, polja, Me.jezik, Me.txtmode, Me.CAPIServer, Me.CAPIBaza, Me.mrist.SIFIST)
                    funos.ShowDialog()
                    VrPar = funos.VrednostParametra
                    VrDODPar = funos.VrednostDodParametra
                    If DirectCast(funos.ActiveControl, System.Windows.Forms.ButtonBase).Text.Trim.ToUpper = "CANCEL" Then
                        bbiloCancel = True
                        Exit Function
                    End If
                    funos.Dispose()

                    Dim prazan As Boolean = True
                    For zi As Integer = 0 To VrPar.GetUpperBound(0)
                        If Not VrPar(zi) Is Nothing Then
                            prazan = False
                            Exit For
                        End If
                    Next
                    If prazan = True Then Exit Function
                    For zi As Integer = 0 To VrPar.GetUpperBound(0)
                        If VrPar(zi) Is Nothing Then VrPar(zi) = ""
                    Next
                Else
                    sql2pom = sql2pom + vbCrLf + l
                End If
                'kraj parametra ako postoji
                '***********
            End While

            sql = sql2pom
            sql = sql.ToLower.Replace("--transfer", "")

            Dim samostalno As String = ""
            Dim ssql() As String = sql.Split(";")

            For i As Integer = 0 To ssql.GetUpperBound(0)
                Dim bbb As String = ssql(i).Replace(vbCrLf, " ").Trim
                If bbb <> "" Then
                    If ssql(i).Trim.IndexOf("--") = 0 AndAlso ssql(i).Trim.IndexOf("--prvisheet") <> 0 AndAlso ssql(i).Trim.IndexOf("--firstsheet") <> 0 AndAlso
                  ssql(i).Trim.IndexOf("--novisheet") <> 0 AndAlso ssql(i).Trim.IndexOf("--newsheet") <> 0 AndAlso ssql(i).Trim.IndexOf("--startat") <> 0 Then
                        'NISTA, KOMENTAR JE
                    Else
                        ssql(i) = ZameniGGGMMM(ssql(i), vt.G.ToString, vt.M, vt.vtwhere(""), vt.GWhere(""), vt.mWhere(""), vt.YWhere(""))
                        ssql(i) = ZameniVodVdo(ssql(i), vt)
                        ssql(i) = zameniCAPIUSER(ssql(i), txtmode, CAPIServer, CAPIBaza)
                        ssql(i) = ppreplace(VrPar, VrDODPar, ssql(i), Prmtr)

                        Dim S As Integer = ssql(i).ToLower.IndexOf("--prvisheet", 0)
                        If S < 0 Then S = ssql(i).ToLower.IndexOf("--firstsheet", 0)
                        If S >= 0 Then
                            'postoji ime za prvi sheet iz *.sql-a
                            prviSheet = 1
                            ll = 0
                            ReDim Preserve nazivSheet(ll)
                            Dim sm As Integer = ssql(i).IndexOf(vbCrLf)
                            nazivSheet(ll) = ssql(i).Substring(0, sm).ToLower.Replace("--prvisheet", "").Replace("--firstsheet", "").Trim
                            ssql(i) = ssql(i).Substring(sm)
                            ssql(i) = ssql(i).Replace(vbCrLf, " ")

                            Dim trtDS As New System.Data.DataSet
                            trtDS = tttran(ssql(i))
                            If Not trtDS Is Nothing Then
                                brojSheet = brojSheet + 1
                                ReDim Preserve ds(brojSheet)
                                ds(brojSheet) = trtDS.Copy
                            End If
                        End If

                        'ima noviSheet
                        Dim nS As Integer = ssql(i).ToLower.IndexOf("--novisheet", 0)
                        If nS < 0 Then nS = ssql(i).ToLower.IndexOf("--nextsheet", 0)
                        If nS >= 0 Then
                            ll = ll + 1
                            ReDim Preserve nazivSheet(ll)
                            Dim sm As Integer = ssql(i).IndexOf(vbCrLf)
                            nazivSheet(ll) = ssql(i).Substring(0, sm).ToLower.Replace("--novisheet", "").Replace("--nextsheet", "").Trim
                            ssql(i) = ssql(i).Substring(sm)
                            ssql(i) = ssql(i).Replace(vbCrLf, " ")
                            Dim trtDS As New System.Data.DataSet
                            trtDS = tttran(ssql(i))
                            If Not trtDS Is Nothing Then
                                brojSheet = brojSheet + 1
                                ReDim Preserve ds(brojSheet)
                                ds(brojSheet) = trtDS.Copy
                            End If
                        End If  'od novi sheet

                        If S < 0 AndAlso nS < 0 Then 'nije u sheetovima trebalo bi da ide u begin transaction commit
                            ssql(i) = ssql(i).Replace(vbCrLf, " ")
                            Dim trtDS As New System.Data.DataSet
                            trtDS = tttran(ssql(i))
                            If Not trtDS Is Nothing AndAlso trtDS.DataSetName = "ERROR" Then
                                ttransfer = Nothing
                                ISTMessageBox.Show("Error at:" + nvrd + nvrd + ssql(i))
                                Exit Function
                            Else
                                If Not trtDS Is Nothing AndAlso trtDS.Tables.Count > 0 Then   'znaci nesto vraca
                                    brojSheet = brojSheet + 1
                                    ReDim Preserve ds(brojSheet)
                                    ds(brojSheet) = trtDS.Copy
                                End If
                            End If
                        End If

                        Dim izb As Integer = ssql(i).ToLower.IndexOf("--izbaci", 0)
                        If izb < 0 Then izb = ssql(i).ToLower.IndexOf("--remove", 0)
                        'ima izbaci
                        If izb >= 0 Then
                            ReDim Preserve koloneIzbaci(brojSheet)
                            koloneIzbaci(brojSheet) = CInt(ssql(i).Substring(izb + 8))
                        End If

                        Dim sAt As Integer = ssql(i).ToLower.IndexOf("--startat", 0)
                        'ima izbaci
                        ReDim Preserve startAt(brojSheet)
                        If sAt >= 0 Then
                            startAt(brojSheet) = ssql(i)
                        End If

                    End If 'NIJE KOMENTAR
                End If
            Next

            'dopuni izbaciKolone
            Dim trtPom As Integer = koloneIzbaci.GetUpperBound(0)
            If trtPom > -1 Then
                If trtPom < brojSheet Then
                    For i As Integer = trtPom + 1 To brojSheet
                        ReDim Preserve koloneIzbaci(i)
                        koloneIzbaci(i) = koloneIzbaci(trtPom)
                    Next
                End If
                'izbaciti iz ds-va poslednje kolone
                For ppp As Integer = 0 To brojSheet
                    'IZBACI
                    Dim dt As System.Data.DataTable
                    For i As Integer = 0 To ds(ppp).Tables.Count - 1
                        dt = ds(ppp).Tables(i)
                        For mm As Integer = 1 To koloneIzbaci(ppp)
                            dt.Columns.Remove(dt.Columns(dt.Columns.Count - 1).ColumnName)
                        Next
                        dt.AcceptChanges()
                    Next
                    ds(ppp).AcceptChanges()
                Next
            End If
            For ppp As Integer = 0 To brojSheet
                If ppp > 0 Then
                    ds(ppp).Namespace = nazivSheet(ppp).ToUpper.Trim
                    If startAt.Length > 0 Then
                        ds(ppp).Tables(0).Namespace = startAt(ppp).ToUpper.Trim
                    End If
                End If
                If prviSheet = 1 Then
                    ds(0).Namespace = nazivSheet(0).ToUpper.Trim
                    If startAt.Length > 0 Then
                        ds(0).Tables(0).Namespace = startAt(0).ToUpper.Trim
                    End If
                End If
            Next
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Return ds
    End Function

    Function tttran(ByVal ssqli As String) As DataSet
        tttran = Nothing

        If ssqli = "" Then Exit Function
        'If ssqli.Trim.ToUpper.IndexOf("EXEC") = 0 Then
        ssqli = ssqli.Trim.ToUpper.Replace("EXEC", "")
        'Else
        '    ISTMessageBox.Show("This is not execution of stored procedure!")
        '    Exit Function
        'End If
        tttran = dajkoniizvrsi(ssqli)

    End Function
    Function dajkoniizvrsi(ByVal ssqli As String) As DataSet
        'EXEC [Z].[database].[prefix].[storedProcedure]  parameter1, parameter2, ...
        'EXEC Z.database.prefix.storedProcedure  parameter1, parameter2, ... NE MORAJU UGLASTE ZAGRADE
        dajkoniizvrsi = Nothing
        Dim imaZ As Boolean = False

        ssqli = NZ(Replace(ssqli, "[ z ]", "[Z]", 1, , CompareMethod.Text)).Trim
        ssqli = NZ(Replace(ssqli, "[ z]", "[Z]", 1, , CompareMethod.Text)).Trim
        ssqli = NZ(Replace(ssqli, "[z ]", "[Z]", 1, , CompareMethod.Text)).Trim
        ssqli = NZ(Replace(ssqli, "[ z", "[Z", 1, , CompareMethod.Text)).Trim
        ssqli = NZ(Replace(ssqli, "[  z", "[Z", 1, , CompareMethod.Text)).Trim
        ssqli = NZ(Replace(ssqli, "[z .", "[Z", 1, , CompareMethod.Text)).Trim
        ssqli = NZ(Replace(ssqli, "[z  .", "[Z", 1, , CompareMethod.Text)).Trim


        If ssqli.Trim.ToUpper.IndexOf("[Z].") = 0 OrElse ssqli.Trim.ToUpper.IndexOf("Z.") = 0 OrElse ssqli.Trim.ToUpper.IndexOf("[Z.") = 0 Then imaZ = True

        Dim kon As String = ""

        If imaZ = True Then
            kon = ""
            ' Z MOZE SAMO KOD EXECA
            'sintaksa exec [Z].[IST].[dbo].[sp] p1,p2,p3

            Dim count1 As Integer = ssqli.Split("[").GetUpperBound(0)
            Dim count2 As Integer = ssqli.Split("]").GetUpperBound(0)

            If count1 <> count2 Then
                Dim poruka As String = "Syntax is wrong, it must be written as EXEC [Z].[database].[prefix].[storedProcedure] parameter1, parameter2, ..." + nvrd
                poruka = poruka + "Parameters are optional" + nvrd
                poruka = poruka + "Check is numer of [ is equal with number of ]!"

                ISTMessageBox.Show(poruka)

                Exit Function
            End If

            Dim pp() As String = ssqli.Split(" ")
            Dim putanja As String = pp(0)
            Dim parametri As String = ""
            'pp(0) - server.database.prefix.storedProcedure
            If pp.Length > 1 Then
                'ima parametre
                For i As Integer = 1 To pp.GetUpperBound(0)
                    parametri = parametri + pp(i) + " "
                Next
                parametri = parametri.TrimEnd(" ")
            End If
            Dim sx() As String = putanja.Split(".")
            Dim prefix As String = ""
            Dim baza As String = ""
            Dim sp As String = ""
            Dim server As String = ""

            If sx.GetUpperBound(0) = 3 Then
                sp = sx(3).Replace("[", "").Replace("]", "")
                prefix = sx(2).Replace("[", "").Replace("]", "")
                baza = sx(1).Replace("[", "").Replace("]", "")
                server = sx(0).Replace("[", "").Replace("]", "")
                kon = getConnectionString("", baza, server, "")
                ssqli = "exec [" + prefix + "].[" + sp + "] " + parametri
            Else
                Dim poruka As String = "Syntax Is wrong! It must be written as: " + nvrd + nvrd
                poruka = poruka + "EXEC [Z].[database].[prefix].[storedProcedure] parameter1, parameter2, ..." + nvrd
                poruka = poruka + "Parameters are optional" + nvrd
                ISTMessageBox.Show(poruka)
                Exit Function
            End If
        End If

        If imaZ = False Then
            kon = ""
            ssqli = ssqli.Replace(" .", ".").Replace(". ", ".")
            Dim pp() As String = ssqli.Split(" ")
            Dim parametri As String = ""
            'pp(0) - server.database.prefix.storedProcedure
            If pp.Length > 1 Then
                'ima parametre
                For i As Integer = 1 To pp.GetUpperBound(0)
                    parametri = parametri + pp(i) + " "
                Next
                parametri = parametri.TrimEnd(" ")
            End If

            Dim sx() As String = pp(0).Replace("[", "").Replace("]", "").Split(".")
            If sx.GetUpperBound(0) > 3 Then   'server.baza (imt2.ist)
                Dim poruka As String = ""
                poruka = "Syntax is wrong! It must be written as: " + nvrd + nvrd
                poruka = poruka + "   EXEC server.database.prefix.storedProcedure parameter1, parameter2, ..." + nvrd
                poruka = poruka + "or EXEC database.prefix.storedProcedure parameter1, parameter2, ..." + nvrd
                poruka = poruka + "or EXEC prefix.storedProcedure parameter1, parameter2, ..." + nvrd
                poruka = poruka + "or EXEC storedProcedure parameter1, parameter2, ..." + nvrd
                poruka = poruka + " Parameters are optional"
                ISTMessageBox.Show(poruka)
                Exit Function
            End If

            Dim prefix As String = ""
            Dim sp As String = ""

            Select Case sx.GetUpperBound(0)
                Case 3 'server.database.prefix.storedProcedure
                    kon = "DATA SOURCE=" + sx(0).Trim + ";INITIAL CATALOG=" + sx(1).Trim + ";Integrated Security=SSPI;Persist Security Info=False"
                    prefix = "[" + sx(2) + "]"
                    sp = "[" + sx(3) + "]"
                Case 2 'database.prefix.storedProcedure
                    Dim server As String = ""
                    Dim ds() As String = Me.DBConnectionString.Split(";")
                    For i As Integer = 0 To ds.GetUpperBound(0)
                        If ds(i).Trim.ToUpper = "DATA SOURCE" Then
                            server = ds(i).Trim.ToUpper.Replace("DATA SOURCE=", "")
                            Exit For
                        End If
                    Next
                    If server <> "" Then
                        kon = "DATA SOURCE=" + server + ";INITIAL CATALOG=" + sx(0).Trim + ";Integrated Security=SSPI;Persist Security Info=False"
                    End If
                    prefix = "[" + sx(1) + "]"
                    sp = "[" + sx(2) + "]"
                Case 1 'prefix.storedProcedure
                    prefix = "[" + sx(0) + "]"
                    sp = "[" + sx(1) + "]"
                    kon = ""
                Case 0
                    sp = "[" + sx(0) + "]"
                    prefix = "[dbo]"
                    kon = ""
            End Select
            ssqli = "exec " + prefix + "." + sp + " " + parametri
        End If

        Dim dtS As New System.Data.DataSet
        If kon <> "" Then
            dtS = izvrsiSQLvratiDS(ssqli, kon, "")
        Else
            dtS = izvrsiSQLvratiDS(ssqli, Me.DBConnectionString, "")
        End If

        dajkoniizvrsi = dtS

    End Function
    Private Sub releaseObject(ByVal obj As Object)
        Try
            If Not obj Is Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing

        End Try
    End Sub

    Function praznoXLS(ByVal r As DatasetIstrazivanja.ISTTABSRow, ByVal sf As String, ByVal sql As String,
                       ByVal sz As String, ByVal ikol As Integer, Optional staro As Integer = 0) As String
        praznoXLS = "..."
        Dim provera As String = SQl22(sf, ucvt, sql, sz, ikol)
        Dim ds() As DataSet
        If imaTransfer = True Then
            ds = Me.ttransfer(sf, ucvt, sql, sz, ikol)
            provera = "ods"
        End If
        If provera = "" Then
            praznoXLS = ""
            Exit Function
        End If

        ppdatestart = Date.Now
        If oopenofficeods = False OrElse rExcelZag <> "ODS" Then
            Call Report2(ppdatestart, Me.DBConnectionString, sql, sz, ikol, r)

            If staro = 1 Then Call Xls2staro(r)
            If staro = 0 Then Call Xls2(r)
        End If

        If rExcelZag = "ODS" Then
            If ds Is Nothing Then
                Call ReportODS(ppdatestart, sql, sz, ikol, r, Nothing)
            Else
                Call ReportODS(ppdatestart, sql, sz, ikol, r, ds(0))
            End If

        End If

        'word

    End Function

    Dim izadji As Boolean = False
    Private Sub ReportODS(ByVal ppdatestart As Date, ByVal sql As String, ByVal sql2 As String, ByVal ikol As Integer, ByVal r As DatasetIstrazivanja.ISTTABSRow, Optional ByVal ds As DataSet = Nothing)
        izadji = False
        If rExcelZag = "" OrElse rExcelZag <> "ODS" OrElse oopenofficeods = False Then
            Return
        End If

        Dim pomZaglavlje As String = ""

        If System.IO.File.Exists(Me.mOOCalc) = True Then
            System.IO.File.Delete(Me.mOOCalc)
        End If
        'System.IO.File.Copy(Me.mrist.TxtDir.Trim + "\" + r.ExcelZag, Me.mOOCalc)

        If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
            System.IO.File.Copy(GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.ExcelZag, Me.mOOCalc)
        Else
            System.IO.File.Copy(Me.mrist.TxtDir.Trim + "\" + r.ExcelZag, Me.mOOCalc)
        End If
        pomZaglavlje = Me.mOOCalc
        Try

            Dim fi As New System.IO.FileInfo(pomZaglavlje)

            Dim dst As System.Data.DataSet = Nothing
            If imaTransfer = False Then
                If sql.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") >= 0 Then sql = DeKriptoSQL(sql)
                dst = izvrsiSQLvratiDS(sql, Me.DBConnectionString, Me.jezik)
            Else
                dst = ds
            End If

            If dst Is Nothing Then
                izadji = True
                Exit Sub
            End If

            Dim kk, rr As Integer
            kk = 0 : rr = 0
            For Each dt As System.Data.DataTable In dst.Tables
                rr += dt.Rows.Count
                If dt.Columns.Count > kk Then kk = dt.Columns.Count
            Next
            Dim matdata(rr + 1, kk + 1)
            rr = 0
            For Each dt As System.Data.DataTable In dst.Tables
                For i As Integer = 0 To dt.Rows.Count - 1
                    For c As Integer = 0 To dt.Columns.Count - 1 - ikol
                        If dt.Rows(i).IsNull(c) Then
                            matdata(i + rr, c) = ""
                        Else
                            matdata(i + rr, c) = dt.Rows(i).Item(c)
                        End If
                    Next
                Next
                rr = rr + dt.Rows.Count
            Next

            If sql2 <> "" Then
                Dim ok1 As String = izvrsiSQL(sql2, Me.DBConnectionString)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show(sql2 + nvrd + nvrd + "Is Not executed! ER44", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If

            Dim inputOdsPath As String = pomZaglavlje

            If matdata.GetUpperBound(1) > 0 Then

                Dim oOprocess() As Process
                oOprocess = Process.GetProcessesByName("SOffice")
                If oOprocess.Length > 0 Then
                    ISTMessageBox.Show("Unable to proceed whilst other Open Office programs are running. Close the programs, wait for a short while And re-try.")
                    Exit Sub
                End If

                Dim oSheet As Object
                Dim oSM 'Root object for accessing OpenOffice from VB
                Dim oDesk, oDoc As Object 'First objects from the API
                Dim arg(1) As Object 'Used as parameter in opening doc

                Dim OpenPar(2) As Object
                OpenPar(0) = Nothing 'MakePropertyValue("ReadOnly", True)
                OpenPar(1) = Nothing 'MakePropertyValue("Password", "secret")
                OpenPar(2) = MakePropertyValue("Hidden", True)

                Dim lastRow As Long
                Dim rowIndex As Long
                Dim c As Object

                Try
                    oSM = CreateObject("com.sun.star.ServiceManager") 'Instantiate Open Office for VB
                    oDesk = oSM.createInstance("com.sun.star.frame.Desktop") 'Create service
                    inputOdsPath = "file:///" + inputOdsPath.Replace("\", "/")
                    'Open an existing doc, note no index on arg parameter
                    oDoc = oDesk.loadComponentFromURL(inputOdsPath, "_default", 0, OpenPar)

                Catch ex As Exception

                    'Call End_App("SOFFICE.BIN", Nothing, Nothing)
                    'Call End_App("SOFFICE", Nothing, Nothing)
                    End_OO_App(ppdatestart, Date.Now)
                    Exit Sub
                End Try

                oSheet = oDoc.getSheets().getByIndex(0) 'Get first sheet
                c = oSheet.createCursor
                c.gotoEndOfUsedArea(False) 'Points cursor to the end of the used area, parm sets cursor size to single cell
                lastRow = c.RangeAddress.EndRow 'Get index of last used row – returns zero based index
                rowIndex = lastRow + 1

                For red As Integer = 0 To matdata.GetUpperBound(0)
                    For kolona As Integer = 0 To matdata.GetUpperBound(1)
                        Call oSheet.getCellByPosition(kolona, rowIndex + red).SetString(matdata(red, kolona))
                    Next
                Next

                Try
                    'Save the doc
                    Call oDoc.store()
                    'Tidy open objects
                    oDoc.Close(True)
                    oDoc = Nothing
                    oDesk = Nothing
                    oSM = Nothing

                Catch ex As Exception
                    End_OO_App(ppdatestart, Date.Now)
                    Exit Sub
                End Try

                End_OO_App(ppdatestart, Date.Now)

                ' Tidy up process close
                GC.Collect()
                GC.WaitForPendingFinalizers()
                GC.Collect()
                GC.WaitForPendingFinalizers()
            End If


        Catch ex As System.Runtime.InteropServices.ExternalException
            If ex.ErrorCode <> -2146788248 Then
                Throw ex
            End If
        End Try
    End Sub

    Dim ppxlsm As Boolean = False
    Dim excelPgm As Boolean
    Dim excelPivot As Boolean
    Dim excelPivotIndex As Boolean
    Dim staroExcel As Boolean
    Dim rPX As DatasetIstrazivanja.ISTTABSRow
    Dim txtwithSeparator As Boolean = False
    Dim rProgram As String = ""
    Dim rExcelZag As String = ""
    Public Sub DajIzvestaj(ByVal r As DatasetIstrazivanja.ISTTABSRow)

        excelPgm = False
        staroExcel = False
        If r.IsExcelNull = False AndAlso r.Excel.Trim <> "" Then excelPgm = True
        excelPivot = False
        If r.IsKVIRINull = False AndAlso r.KVIRI.Trim.ToUpper = "PIVOT" Then excelPivot = True
        excelPivotIndex = False
        If r.IsKVIRINull = False AndAlso r.KVIRI.Trim.ToUpper = "PIVOTINDEX" Then excelPivotIndex = True

        jesteExcelXML = 0
        navedenUpit = True
        If Not r.IsProgramNull AndAlso r.Program.Trim <> "" AndAlso
            r.Program.Trim.ToUpper <> "PX" AndAlso
            r.Program.Trim.ToUpper <> "WORD" AndAlso r.Program.Trim.ToUpper.IndexOf(".DOC") < 0 AndAlso
            r.Program.Trim.ToUpper.IndexOf(".DOTX") < 0 AndAlso r.Program.Trim.ToUpper.IndexOf(".DOTM") < 0 AndAlso
            r.Program.Trim.ToUpper.IndexOf("TXT") < 0 AndAlso
            r.Program.Trim.ToUpper.IndexOf("ODS") < 0 Then
            Dim args As String = Me.DBConnectionString
            Dim p As String
            p = ucvt.G.ToString
            p = p + ";"
            p = p + ucvt.M.ToString
            args = args + "#" + p + "##"
            Dim f As String = ""
            If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                f = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.Program.Trim
            Else
                f = Me.mrist.TxtDir.Trim + "\" + r.Program.Trim
            End If

            program(f, False, Me.mrist.TxtDir.Trim, args)
            Return
        End If
        If r.IsUpitZaTabeluNull OrElse r.UpitZaTabelu.Trim = "" Then
            ''msg 243
            Dim msgtxt243 As String = getMessageText(dtMessages, "243", Me.jezik)
            ISTMessageBox.Show(msgtxt243 + CType(r.Table, DatasetIstrazivanja.ISTTABSDataTable).UpitZaTabeluColumn.ColumnName.Trim, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            navedenUpit = False
            Return
        End If

        oopenofficeods = False

        If Not r.IsProgramNull AndAlso r.Program.Trim <> "" AndAlso r.Program.Trim.ToUpper.IndexOf("ODS") = 0 Then
            oopenofficeodslock = False
            Dim p As String = r.Program.Trim.ToUpper.Replace("ODS", "")
            If p <> "" Then oopenofficeodslock = True
            oopenofficeods = True
        End If

        rProgram = ""
        rExcelZag = ""
        Dim sf As String = ""
        If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
            sf = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.UpitZaTabelu.Trim
        Else
            sf = Me.mrist.TxtDir.Trim + "\" + r.UpitZaTabelu.Trim
        End If

        Dim sql As String = ""
        Dim sz As String = ""
        Dim ikol As Integer = 0
        Dim biloCancel As Boolean = False
        Me.wfn = ""
        Try
            'brisem sve sto postoji

            Dim fi As New System.IO.FileInfo(Me.mExcelXML)
            If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                System.IO.Directory.CreateDirectory(fi.DirectoryName)
            End If

            Call DeleteFilesStartingWithSIFIST(Path.GetDirectoryName(mExcelXML), Me.mrist.SIFIST.Trim)

            Call deleteFile(Me.mExcelXML, "SOFFICE.BIN")
            Call deleteFile(Me.mOOCalc, "SOFFICE.BIN")
            Call deleteFile(Me.mxlsm, "EXCEL.EXE")
            Call deleteFile(Me.mxlsx, "EXCEL.EXE")
            Call deleteFile(Me.mExcelXML, "EXCEL.EXE")
            Call deleteFile(Me.mxlsm88, "EXCEL.EXE") 'pomocno
            System.IO.File.Delete(Me.mTrt)   'pomocno

            If oopenofficeods = False Then
                Call deleteFile(Me.mxls, "EXCEL.EXE")
                Call deleteFile(Me.mdoc, "WORD.EXE")
                Call deleteFile(Me.mdocx, "WORD.EXE")
                Call deleteFile(Me.mdocm, "WORD.EXE")
                Call deleteFile(Me.mdotx, "WORD.EXE")
                Call deleteFile(Me.mdotm, "WORD.EXE")
                Call deleteFile(Me.zmcsv, "EXCEL.EXE")

                Dim mTXT() As String = Directory.GetFiles(fi.DirectoryName, Me.mrist.SIFIST.Trim + "*.txt")
                For Each ffd As String In mTXT
                    File.Delete(ffd)
                Next
                Dim pXML() As String = Directory.GetFiles(fi.DirectoryName, Me.mrist.SIFIST.Trim + "*.txt")
                For Each ffd As String In pXML
                    File.Delete(ffd)
                Next
                Dim pJSON() As String = Directory.GetFiles(fi.DirectoryName, Me.mrist.SIFIST.Trim + "*.txt")
                For Each ffd As String In pJSON
                    File.Delete(ffd)
                Next
                Dim pCSV() As String = Directory.GetFiles(fi.DirectoryName, Me.mrist.SIFIST.Trim + "*.txt")
                For Each ffd As String In pCSV
                    File.Delete(ffd)
                Next
            End If

            If oopenofficeods = False AndAlso (Not r.IsProgramNull AndAlso r.Program.Trim <> "") Then
                If r.Program.Trim.ToUpper.IndexOf("DOTX") > 0 Then
                    rProgram = "DOTX"
                ElseIf r.Program.Trim.ToUpper.IndexOf("DOTM") > 0 Then
                    rProgram = "DOTM"
                ElseIf r.Program.Trim.ToUpper.IndexOf("TXTSEPARATOR|") = 0 Then
                    rProgram = "TXTSEPARATOR"
                ElseIf r.Program.Trim.ToUpper = "WORD" Then
                    rProgram = "WORD"
                ElseIf r.Program.Trim.ToUpper.IndexOf(".DOC") > 0 Then
                    rProgram = "DOC"
                ElseIf r.Program.Trim.ToUpper.IndexOf("TXT") = 0 Then
                    rProgram = "TXT"
                End If
            End If

            If Not r.IsExcelZagNull AndAlso r.ExcelZag.Trim <> "" Then
                If r.ExcelZag.ToString.Trim.ToUpper.IndexOf(".XML") > 0 Then
                    rExcelZag = "XML"
                ElseIf oopenofficeods = False AndAlso imaoffice = True AndAlso r.ExcelZag.ToString.Trim.IndexOf(".XLSM") > 0 Then
                    rExcelZag = "XLSM"
                ElseIf r.ExcelZag.Trim.ToUpper.IndexOf("XLSX") > 0 AndAlso imaoffice = True Then
                    rExcelZag = "XLSX"
                ElseIf oopenofficeods = False AndAlso imaoffice = True AndAlso r.ExcelZag.ToString.Trim.ToUpper.IndexOf(".XLS") > 0 AndAlso r.ExcelZag.ToString.Trim.ToUpper.IndexOf(".XLSM") < 0 AndAlso
                 r.ExcelZag.ToString.Trim.ToUpper.IndexOf(".XLSX") < 0 Then
                    rExcelZag = "XLS"
                ElseIf r.ExcelZag.ToString.Trim.ToUpper.IndexOf(".ODS") > 0 Then
                    rExcelZag = "ODS"
                    oopenofficeods = True
                End If
            Else
                rExcelZag = ""
            End If

            Dim pom As String = ""

            If oopenofficeods = False AndAlso r.UpitZaTabelu.Trim.ToUpper.IndexOf("EXEC ") = 0 Then
                'nije iz fajla nego direktno za web
                'samo se izvršava usp, ne treba parametri, ovo nije za desktop, samo za web ako treba
                If rExcelZag = "XML" Then
                    pom = xml(r, sf, sql, sz, ikol, r.UpitZaTabelu.Trim)
                Else
                    ISTMessageBox.Show("You do Not have xml header!" + nvrd + nvrd + "Report will Not be prepared!")
                End If
            Else
                'iz fajla
                ppxlsm = False
                'DOTX
                If oopenofficeods = False AndAlso rProgram = "DOTX" Then
                    'vec obrisao gore
                    'Call deleteFile(Me.mdotx, "WORD.EXE")

                    Dim folderZaGen As String = ""
                    If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                        folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.Program.Trim
                    Else
                        folderZaGen = Me.mrist.TxtDir + "\" + r.Program.Trim
                    End If

                    FileCopy(folderZaGen, Me.mdotx)
                    Dim template As String = Me.mdotx
                    Dim sqlpom As String = SQl22(sf, ucvt, sql, sz, ikol)
                    Try
                        Call wordtemplate(Me.DBConnectionString, sqlpom, template, 1)
                    Catch ex As Exception
                        ISTMessageBox.Show(ex.Message)
                    End Try
                    Exit Sub
                End If
                'DOTM
                If oopenofficeods = False AndAlso rProgram = "DOTM" Then
                    ''vec obrisao gore
                    'System.IO.File.Delete(Me.mdotm)
                    Dim folderZaGen As String = ""
                    If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                        folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + r.Program.Trim
                    Else
                        folderZaGen = Me.mrist.TxtDir + "\" + r.Program.Trim
                    End If

                    FileCopy(folderZaGen, Me.mdotm)
                    Dim template As String = Me.mdotm
                    Dim sqlpom As String = SQl22(sf, ucvt, sql, sz, ikol)
                    Try
                        Call wordtemplate(Me.DBConnectionString, sqlpom, template, 2)
                    Catch ex As Exception
                        ISTMessageBox.Show(ex.Message)
                    End Try
                    Exit Sub
                End If
                'TXTSEPARATOR|
                txtwithSeparator = False
                If oopenofficeods = False AndAlso rProgram = "TXTSEPARATOR" Then txtwithSeparator = True

                If oopenofficeods = False AndAlso imaoffice = True AndAlso rExcelZag = "" Then
                    pom = praznoXLS(r, sf, sql, sz, ikol)
                ElseIf oopenofficeods = False AndAlso imaoffice = True AndAlso rExcelZag = "XLS" Then
                    staroExcel = True
                    pom = praznoXLS(r, sf, sql, sz, ikol, 1)
                ElseIf oopenofficeods = False AndAlso imaoffice = True AndAlso rExcelZag = "XLSM" Then
                    ppxlsm = True
                    pom = praznoXLS(r, sf, sql, sz, ikol)
                ElseIf oopenofficeods = False AndAlso imaoffice = True AndAlso rExcelZag = "XLSX" Then
                    pom = praznoXLS(r, sf, sql, sz, ikol)
                ElseIf rExcelZag = "XML" Then
                    pom = xml(r, sf, sql, sz, ikol)
                ElseIf oopenofficeods = True AndAlso rExcelZag = "ODS" Then
                    pom = praznoXLS(r, sf, sql, sz, ikol)
                End If
                If pom = "" Then biloCancel = True
                If Me.wfn.Trim <> "" Then program(Me.wfn, True, "", "")
            End If

        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try

        If bbiloCancel = True Then
            Exit Sub
        End If

        If oopenofficeods = False AndAlso imaoffice = True AndAlso biloCancel = False AndAlso navedenUpit = True Then
            If rProgram = "WORD" Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                program(Me.dword, True, "", "")
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If
            If rProgram = "DOC" Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                Call MailMerge(r.Program)
                program(Me.dword, True, "", "")
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If
            txtfile = False
            If rProgram = "TXT" Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                txtfile = True
                Call fontNotepad()
                Dim myFiles() As String
                Dim path As String = Me.mExcelXML.Substring(0, Me.mtxt.LastIndexOf("\"))
                myFiles = System.IO.Directory.GetFiles(path, Me.mrist.SIFIST.Trim + "*.txt", IO.SearchOption.AllDirectories)
                For t As Integer = 0 To myFiles.GetUpperBound(0)
                    Dim FILE_NAME As String = myFiles(t)
                    If System.IO.File.Exists(FILE_NAME) = True Then
                        Process.Start(FILE_NAME)
                    Else
                        ISTMessageBox.Show("File Does Not Exist")
                    End If
                Next
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If

            Call prikaziClick()

        End If

        If oopenofficeods = True AndAlso biloCancel = False AndAlso navedenUpit = True Then   'ne tiče me se kakav je tctmode - capi i osatlo mora da otvara ods
            'preuzmi god, mes, sifist i istuser iz CAPIdata
            Try
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                If izadji = True Then
                    Exit Sub
                End If
                Call openOfficeXLS(oopenofficeodslock, rExcelZag)
                Me.Cursor = System.Windows.Forms.Cursors.Default
            Catch ex As Exception
                ISTMessageBox.Show("You don't have OPENOFFICE!")
                End_Excel_App(ppdatestart, Date.Now)
            End Try
        End If
        If oopenofficeods = False AndAlso imaoffice = False AndAlso biloCancel = True AndAlso navedenUpit = True Then
            ISTMessageBox.Show("You don't have MS OFFICE!")
        ElseIf biloCancel = True AndAlso imaoffice = False AndAlso navedenUpit = True Then
            ISTMessageBox.Show("You don't have MS OFFICE!")
        End If
    End Sub
    Sub DeleteFilesStartingWithSIFIST(directoryPath As String, ByVal sifist As String)
        ' Get all files that start with PRJ
        Dim filesToDelete() As String = Directory.GetFiles(directoryPath, sifist + "*.*")

        For Each ff As String In filesToDelete
            Try
                File.Delete(ff)
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        Next
    End Sub
    Sub deleteFile(ByVal fn As String, ByVal what As String)
        Try
            System.IO.File.Delete(fn)
        Catch ex As Exception
            Call KillProcessesHoldingFile(fn, what)
            System.IO.File.Delete(fn)
        End Try
    End Sub

    Public Sub KillProcessesHoldingFile(ByVal filePath As String, ByVal what As String)
        '"soffice.bin" za openoffice
        Dim processes As Process() = Process.GetProcesses()

        For Each process As Process In processes
            Dim processFileName As String = ""
            Try
                processFileName = process.MainModule.FileName
            Catch ex As Exception
                ' An exception can occur if the process has already exited or if we do not have access to the process.
                ' We can safely ignore this exception.
            End Try
            If processFileName.EndsWith(what, StringComparison.OrdinalIgnoreCase) Then
                ' Check if the process is holding the file.
                Dim processHoldingFile As Boolean = False
                Try
                    Dim fileStream As New IO.FileStream(filePath, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
                    fileStream.Close()
                Catch ex As IO.IOException
                    ' If we catch an IOException, it's likely the process is holding the file.
                    processHoldingFile = True
                End Try
                ' If the process is holding the file, kill the process.
                If processHoldingFile Then
                    Try
                        process.Kill()
                    Catch ex As Exception
                        ISTMessageBox.Show("An error occurred while trying to kill the process: " & ex.Message)
                    End Try
                End If
            End If
        Next
    End Sub
    Sub MailMerge(ByVal rProgram As String)

        Dim wrdApp As Word.Application
        Dim wrdDoc As Word._Document

        'mustra
        rProgram = rProgram.TrimEnd(";")
        Dim rPrograms() As String = rProgram.Split(";")
        Dim wordMustra() As String = {}
        Dim wordMustraRez() As String = {}

        For i As Integer = 0 To rPrograms.GetUpperBound(0)
            ReDim Preserve wordMustra(i)
            System.IO.File.Delete(folder + "\" + rPrograms(i).Trim)
            If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                FileCopy(GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + rPrograms(i).Trim, folder + "\" + rPrograms(i).Trim)
            Else
                FileCopy(Me.mrist.TxtDir + "\" + rPrograms(i).Trim, folder + "\" + rPrograms(i).Trim)
            End If

            wordMustra(i) = folder + "\" + rPrograms(i).Trim
        Next

        'SIFIST.xmls u C:\Users\mira.nikic\Documents\Istrazivanja
        Dim source As String = Me.mxlsm
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        xlApp.Workbooks.Open(source, 0, True)
        xlWorkSheet = CType(xlApp.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

        Dim strSheetName As String = ""
        Dim izbaciSheet As String = ""
        For Each xlWorkSheet In xlApp.Sheets
            Dim numofrows As Integer = xlWorkSheet.Cells(xlWorkSheet.Rows.Count, 1).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).row
            If numofrows > 1 Then izbaciSheet = izbaciSheet + "0;" Else izbaciSheet = izbaciSheet + "1;"
            strSheetName = strSheetName + xlWorkSheet.Name + ";"
        Next
        strSheetName = strSheetName.TrimEnd(";")
        izbaciSheet = izbaciSheet.TrimEnd(";")

        Dim strSheetNames() As String = strSheetName.Split(";")
        Dim izbaciSheets() As String = izbaciSheet.Split(";")

        If strSheetNames.Length > wordMustra.Length Then
            For i As Integer = strSheetNames.Length - wordMustra.Length To strSheetNames.Length - 1
                ReDim Preserve wordMustra(i)
                wordMustra(i) = wordMustra(i - 1)
            Next
        End If

        For i As Integer = 0 To strSheetNames.GetUpperBound(0)
            System.IO.File.Delete(Path.Combine(folder, "x" + strSheetNames(i) + ".docx"))
        Next

        Dim listofFiles As New List(Of String)

        Dim imaSh As Boolean = False

        For i As Integer = 0 To strSheetNames.GetUpperBound(0)
            If izbaciSheets(i) = "0" Then
                imaSh = True
                Dim wrdSelection As Word.Selection
                Dim wrdMailMerge As Word.MailMerge
                Dim wrdMergeFields As Word.MailMergeFields
                wrdApp = CreateObject("Word.Application")
                wrdApp.Visible = False

                Dim sql As String = "select * FROM [" + strSheetNames(i) + "$]"
                wrdDoc = wrdApp.Documents.Open(wordMustra(i))
                wrdMailMerge = wrdDoc.MailMerge()
                wrdMailMerge.MainDocumentType = Word.WdMailMergeMainDocType.wdFormLetters
                wrdMailMerge.OpenDataSource(Name:=source, ReadOnly:=True, LinkToSource:=True, Connection:="Data Source=" & source, SQLStatement:=sql)

                Dim sqlQuery As Object = String.Empty
                Dim connection As Object = String.Empty
                Dim odcPath As String = String.Empty
                Dim oMissing As Object = System.Reflection.Missing.Value
                Dim oFalse As Object = False

                With wrdMailMerge
                    .Destination = Word.WdMailMergeDestination.wdSendToNewDocument
                    .SuppressBlankLines = True
                    With .DataSource
                        .FirstRecord = 1
                        .LastRecord = -16
                    End With
                    .Execute(False)
                End With

                Dim strFilename As String = Path.Combine(folder, "x" + strSheetNames(i) + ".docx")
                wrdApp.ActiveDocument.SaveAs(strFilename)
                listofFiles.Add(strFilename)
                wrdApp.ActiveDocument.Close()

                wrdDoc.Saved = True
                wrdDoc.Close(False)

                wrdSelection = Nothing
                wrdMailMerge = Nothing
                wrdMergeFields = Nothing
                wrdDoc = Nothing
                wrdApp = Nothing
            End If
        Next

        If imaSh = True Then CombineDocuments(listofFiles)

    End Sub
    Private Sub CombineDocuments(ByVal strFiles As List(Of String))

        Dim wdPageBreak As Object = 7
        Dim wdStory As Object = 6
        Dim oMissing As Object = System.Reflection.Missing.Value
        Dim oFalse As Object = False
        Dim oTrue As Object = True

        Dim WordApp As Microsoft.Office.Interop.Word.Application = New Microsoft.Office.Interop.Word.Application()
        Dim wDoc As Microsoft.Office.Interop.Word.Document = WordApp.Documents.Add(strFiles(0))

        For i As Integer = 1 To strFiles.Count - 1
            wDoc.Application.Selection.Range.InsertFile(strFiles(i))
            wDoc.Application.Selection.EndKey(wdStory,)
        Next

        System.IO.File.Delete(Me.dword)
        wDoc.SaveAs(Me.dword, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing, oMissing)
        wDoc = Nothing
        WordApp.Documents.Close()
        WordApp.Quit(Word.WdSaveOptions.wdDoNotSaveChanges)

    End Sub


    Function txtdata(ByVal path As String) As DataTable
        Dim SR As StreamReader = New StreamReader(path)
        Dim i As Long = 0
        Dim line As String = SR.ReadLine()
        Dim strArray As String() = line.Split(vbTab)
        Dim dt As DataTable = New System.Data.DataTable()
        Dim row As DataRow

        For Each s As String In strArray
            dt.Columns.Add(New DataColumn())
        Next

        row = dt.NewRow()
        row.ItemArray = line.Split(vbTab)
        dt.Rows.Add(row)

        While SR.Peek() >= 0
            line = SR.ReadLine.Trim()
            row = dt.NewRow()
            row.ItemArray = line.Split(vbTab)
            dt.Rows.Add(row)
        End While

        Return dt
    End Function

    Sub ttxt(ByVal s As String, ByVal sql As String, ByVal imaz As Boolean)

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        'TXT
        Dim fi As New System.IO.FileInfo(Me.mtxt)
        If Not System.IO.Directory.Exists(fi.DirectoryName) Then
            System.IO.Directory.CreateDirectory(fi.DirectoryName)
        End If
        System.IO.File.Delete(Me.mtxt)
        Dim objStreamWriter As System.IO.StreamWriter
        objStreamWriter = New System.IO.StreamWriter(Me.mtxt)

        If imaz Then
            Dim txt As New System.IO.StreamReader(Me.mTrt)
            Dim str1 As String = txt.ReadToEnd
            txt.Close()
            objStreamWriter.Write(str1.ToString)
            objStreamWriter.WriteLine(nvrd)
        End If

        'pomstr = pomstr + ds.Tables(t).Columns(k).ColumnName.ToString()   'ZAGLAVLJE
        Dim ds As New DataSet
        Dim pomstr As String = ""
        If sql.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") >= 0 Then sql = DeKriptoSQL(sql)
        ds = izvrsiSQLvratiDS(sql, s, "")
        For t As Integer = 0 To ds.Tables.Count - 1
            For r As Integer = 0 To ds.Tables(t).Rows.Count - 1
                pomstr = ""
                For k As Integer = 0 To ds.Tables(t).Columns.Count - 1
                    pomstr = pomstr + ds.Tables(t).Rows(r)(k).ToString() + vbTab
                Next
                pomstr = pomstr + "$$"
                pomstr = pomstr.Replace(vbTab + "$$", "")
                objStreamWriter.WriteLine(pomstr)
            Next
            objStreamWriter.WriteLine(nvrd)
            objStreamWriter.WriteLine(nvrd)
            objStreamWriter.WriteLine(nvrd)
        Next

        objStreamWriter.Close()

        If System.IO.File.Exists(Me.mtxt) = True Then
            System.Diagnostics.Process.Start(Me.mtxt)
        Else
            ISTMessageBox.Show("File Does Not Exist")
        End If

    End Sub

    Sub wordtemplate(ByVal connString As String, ByVal sql As String, ByVal template As String, ByVal opc As Integer)

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        If sql.Trim.ToUpper.IndexOf("DBO.DECRYPTZOKI") >= 0 Then sql = DeKriptoSQL(sql)
        Dim dt As DataTable = izvrsiSQLvratiDT(sql, connString, Nothing)

        Dim oMissing As Object = System.Reflection.Missing.Value
        Dim oTemplatePath As Object = template
        Dim oEndOfDoc As Object = "\endofdoc"

        Dim wordApp As New Microsoft.Office.Interop.Word.Application
        Dim wordDoc As New Microsoft.Office.Interop.Word.Document

        wordDoc = wordApp.Documents.Add(oTemplatePath, oMissing, oMissing, oMissing)

        Dim rng As Microsoft.Office.Interop.Word.Range = wordDoc.Content
        rng.Copy()
        rng.Delete()


        For i As Integer = 0 To dt.Rows.Count - 1

            wordDoc.Bookmarks.Item(oEndOfDoc).Range.Paste()
            Clipboard.Clear()

            For Each myMergeField As Microsoft.Office.Interop.Word.Field In wordDoc.Fields
                Dim rngFieldCode As Microsoft.Office.Interop.Word.Range = myMergeField.Code
                Dim fieldText As String = rngFieldCode.Text

                If fieldText.StartsWith(" MERGEFIELD") Then
                    Dim endMerge As Int32 = fieldText.IndexOf("\")
                    Dim fieldNameLength As Int32 = fieldText.Length - endMerge
                    Dim fieldName As String = fieldText.Substring(11, endMerge - 11)
                    fieldName = fieldName.Trim()
                    If i >= 0 Then
                        myMergeField.[Select]()
                        wordApp.Selection.TypeText(dt.Rows(i).Item(fieldName).ToString.Trim)
                        Continue For
                    End If
                End If
            Next
        Next


        'wordApp.DisplayAlerts = False
        If opc = 1 Then
            wordDoc.SaveAs(mdocx)
            wordApp.Documents.Open(mdocx)
            releaseObject(mdocx)
        ElseIf opc = 2 Then
            wordDoc.SaveAs(mdocm)
            wordApp.Documents.Open(mdocm)
            releaseObject(mdocm)
        End If

        Try
            releaseObject(wordApp)
        Catch ex As Exception

        End Try

        'wordApp.DisplayAlerts = True
    End Sub

    Private Function napraviExcelXML(ByVal dss() As System.Data.DataSet, ByVal r As DatasetIstrazivanja.ISTTABSRow,
                                     ByVal rExcelZag As String, Optional openoff As Boolean = False) As String

        napraviExcelXML = ""

        Dim brSH As Integer = UBound(dss)

        Dim zagParam() As String = {}
        Dim zagDODParam() As String = {}
        Dim nazivSheet() As String = {}
        Dim startAtPOM() As String = {}
        ReDim Preserve zagParam(brSH)
        ReDim Preserve zagDODParam(brSH)
        ReDim Preserve nazivSheet(brSH)
        ReDim Preserve startAtPOM(brSH)
        For i As Integer = 0 To brSH
            Dim M As Integer = dss(i).Namespace.Trim.ToLower.IndexOf("zagparam", 0)
            If M < 0 Then M = dss(i).Namespace.Trim.ToLower.IndexOf("headerparam", 0)
            If M > -1 Then
                zagParam(i) = dss(i).Namespace.Trim.ToLower.Substring(M)
                zagDODParam(i) = dss(i).Namespace.Trim.ToLower.Substring(M).Replace("=", "name=")
                nazivSheet(i) = dss(i).Namespace.Trim.ToLower.Substring(0, M).Replace("'", "")
            Else
                zagParam(i) = ""
                zagDODParam(i) = ""
                nazivSheet(i) = dss(i).Namespace.Trim.Replace("'", "")
            End If
            If nazivSheet(i).ToUpper.Trim.Length > 30 Then nazivSheet(i) = nazivSheet(i).ToUpper.Trim.Substring(0, 30)
            startAtPOM(i) = dss(i).Tables(0).Namespace.Trim.ToUpper
        Next

        'pravi xml fajl
        Dim zag As String = ""
        If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
            zag = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper + "\" + rExcelZag.Trim
        Else
            zag = Me.mrist.TxtDir.Trim + "\" + rExcelZag.Trim
        End If

        Dim red As System.Data.DataRow
        Dim kol As System.Data.DataColumn
        Dim dt As System.Data.DataTable
        Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder

        sb.Append("<?xml version='1.0'?>")
        sb.Append("<?mso-application progid='Excel.Sheet'?>")
        sb.Append("<Workbook xmlns='urn:schemas-microsoft-com:office:spreadsheet' ")
        sb.Append("xmlns:o = 'urn:schemas-microsoft-com:office:office' ")
        sb.Append("xmlns:x = 'urn:schemas-microsoft-com:office:excel' ")
        sb.Append("xmlns:ss = 'urn:schemas-microsoft-com:office:spreadsheet' ")
        sb.Append("xmlns:html='http://www.w3.org/TR/REC-html40'>")
        sb.Append("<ExcelWorkbook xmlns='urn:schemas-microsoft-com:office:excel'>")
        sb.Append("<WindowHeight>11760</WindowHeight>")
        sb.Append("<WindowWidth>19035</WindowWidth>")
        sb.Append("<WindowTopX>0</WindowTopX>")
        sb.Append("<WindowTopY>60</WindowTopY>")
        sb.Append("<ProtectStructure>False</ProtectStructure>")
        sb.Append("<ProtectWindows>False</ProtectWindows>")
        sb.Append("</ExcelWorkbook>")

        'STIL FAJLA GDE SU ZAGLAVLJA
        sb.Append("<Styles>")
        Dim strZag As String
        Dim strZagStyles As String
        Dim sr As New System.IO.StreamReader(zag)
        strZag = sr.ReadToEnd()
        'zameni GGG, MMM
        strZag = strZag.Replace("GGG", ucvt.G.ToString)
        strZag = strZag.Replace("YYY", ucvt.G.ToString)
        strZag = strZag.Replace("MMM", Me.ucvt.M.ToString.Trim.PadLeft(2, "0"c))

        Dim StylesPoc As Integer = strZag.IndexOf("<Styles>")
        Dim StylesKraj As Integer = strZag.LastIndexOf("</Styles>")
        strZagStyles = strZag.Trim.Substring(StylesPoc, StylesKraj - StylesPoc)
        strZagStyles = strZagStyles.Replace("<Styles>", "")
        strZagStyles = strZagStyles.Replace("</Styles>", "")
        '''''''''
        sb.Append(strZagStyles)
        sb.Append("</Styles>")

        Dim zaglbrojsheet As Integer = -1
        Dim zagl() As String = {}
        Dim WO() As String = {}
        ReDim Preserve WO(zaglbrojsheet)

        Dim strTab As String
        Dim TabPoc As Integer
        Dim TabKrajSh As Integer

        Dim strWO As String
        Dim WOPoc As Integer
        Dim WOKraj As Integer

        ''ZAGLAVLJA
        TabKrajSh = 0
        WOKraj = 0

        While strZag.IndexOf("<Worksheet ", TabKrajSh) > 0
            zaglbrojsheet = zaglbrojsheet + 1
            ReDim Preserve zagl(zaglbrojsheet)
            ReDim Preserve WO(zaglbrojsheet)

            TabPoc = strZag.IndexOf("<Worksheet ", TabKrajSh)
            Dim pocIzb As Integer = strZag.IndexOf("<Table", TabKrajSh)
            If pocIzb > 0 Then
                Dim krajIzb As Integer = strZag.IndexOf(">", pocIzb)
                TabKrajSh = strZag.IndexOf("</Table>", TabPoc)
                strTab = strZag.Trim.Substring(TabPoc, pocIzb - TabPoc - 1)
                strTab = strTab & " <Table> " & strZag.Trim.Substring(krajIzb + 1, TabKrajSh - krajIzb - 1)
                strTab.Replace("</Table>", "")
                zagl(zaglbrojsheet) = strTab

                WOPoc = strZag.IndexOf("<WorksheetOptions", WOKraj)
                If WOPoc > 0 Then
                    WOKraj = strZag.IndexOf("</WorksheetOptions>", WOPoc)
                Else
                    WOKraj = -1
                End If
                If WOPoc < 0 Or WOKraj < 0 Then
                    strWO = ""
                Else
                    strWO = strZag.Trim.Substring(WOPoc, WOKraj - WOPoc) & "</WorksheetOptions>"
                End If
                WO(zaglbrojsheet) = strWO
            Else
                'nema <Table> - PRAZAN SHEET, izadji!!!!
                zaglbrojsheet = zaglbrojsheet - 1
                Exit While
            End If
        End While

        'dopuna imena sheetova
        Dim trtPom As Integer = zaglbrojsheet
        Dim p As Integer
        Dim k As Integer
        Dim ime As String = ""

        If trtPom <= brSH Then
            For i As Integer = trtPom To brSH
                ReDim Preserve zagl(i)
                zagl(i) = zagl(trtPom)
                p = zagl(i).IndexOf("ss:Name=")
                k = zagl(i).IndexOf(">")
                ime = zagl(i).Substring(p + 9, k - p - 8 - 2)
                If nazivSheet(i).Trim = "" Then
                    If i > 0 Then zagl(i) = zagl(i).Replace("ss:Name=" + Chr(34) + ime, "ss:Name=" + Chr(34) + ime & Str(i).Trim)
                Else
                    zagl(i) = zagl(i).Replace("ss:Name=" + Chr(34) + ime, "ss:Name=" + Chr(34) + nazivSheet(i)) 'dss(i).Namespace.trim)
                End If
                ReDim Preserve WO(i)
                WO(i) = WO(trtPom)
            Next
        End If

        Dim pom As String = ""
        Dim tip As String
        For i As Integer = 0 To brSH
            'zameni ime Sheet-a ako postoji u .sql
            p = zagl(i).IndexOf("ss:Name=")
            k = zagl(i).IndexOf(">")
            ime = zagl(i).Substring(p + 9, k - p - 8 - 2)
            If nazivSheet(i).Trim = "" Then
            Else
                zagl(i) = zagl(i).Replace("ss:Name=" + Chr(34) + ime, "ss:Name=" + Chr(34) + nazivSheet(i))
            End If

            zagParam(i) = zagParam(i).Trim.ToUpper
            zagDODParam(i) = zagDODParam(i).Trim.ToUpper
            If Not (Prmtr Is Nothing) Then
                For jj As Integer = 0 To Prmtr.GetUpperBound(0)
                    If Not (Prmtr(jj) Is Nothing) Then
                        If zagParam(i).Trim.ToUpper.IndexOf("=" + Prmtr(jj).Trim.ToUpper()) >= 0 Then
                            If Not VrDODPar(jj) Is Nothing Then zagDODParam(i) = zagDODParam(i).Replace(Prmtr(jj).Trim.ToUpper(), "'" + VrDODPar(jj).Trim.ToUpper() + "'")
                            zagParam(i) = zagParam(i).Replace(Prmtr(jj).Trim.ToUpper(), "'" + VrPar(jj).Trim.ToUpper() + "'")
                        End If

                    End If
                Next
            End If

            If zagDODParam(i).Trim.Length > 0 Then
                Dim trtzagDODParam1 As String() = Microsoft.VisualBasic.Split(zagDODParam(i), ",")
                For ii As Integer = 0 To trtzagDODParam1.GetUpperBound(0)
                    'ZAGPARAM1NAME=
                    If Not trtzagDODParam1(ii) Is Nothing Then zagl(i) = zagl(i).Replace("ZAGPARAM" + Str(ii + 1).Trim + "NAME", Microsoft.VisualBasic.Split(trtzagDODParam1(ii), "=")(1).Replace("'", "&quot;").ToUpper)
                    If Not trtzagDODParam1(ii) Is Nothing Then zagl(i) = zagl(i).Replace("HEADERPARAM" + Str(ii + 1).Trim + "NAME", Microsoft.VisualBasic.Split(trtzagDODParam1(ii), "=")(1).Replace("'", "&quot;").ToUpper)
                Next
            End If

            If zagParam(i).Trim.Length > 0 Then
                Dim trtzagParam1 As String() = Microsoft.VisualBasic.Split(zagParam(i), ",")
                For ii As Integer = 0 To trtzagParam1.GetUpperBound(0)
                    'ZAGPARAM1='AAA',ZAGPARAM2='BBB'
                    zagl(i) = zagl(i).Replace("ZAGPARAM" + Str(ii + 1).Trim, Microsoft.VisualBasic.Split(trtzagParam1(ii), "=")(1).Replace("'", "&quot;").ToUpper)
                    zagl(i) = zagl(i).Replace("HEADERPARAM" + Str(ii + 1).Trim, Microsoft.VisualBasic.Split(trtzagParam1(ii), "=")(1).Replace("'", "&quot;").ToUpper)
                Next
            End If

            sb.Append(zagl(i))
            'ima startat

            If startAtPOM(i) <> "" Then
                Dim spom As Integer = startAtPOM(i).ToLower.IndexOf("--startat", 0)
                Dim celija As String = ""
                If spom >= 0 Then
                    celija = startAtPOM(i).Substring(spom + 9)
                    sb.Append("<Row>")
                    sb.Append("<Cell>")
                    sb.Append("<Data ss:Type='String'>")
                    sb.Append("ISTSTARTAT" & celija)
                    sb.Append("</Data>")
                    sb.Append(" ")
                    sb.Append("</Cell>")
                    sb.Append("</Row>")
                End If
            End If

            For Each dt In dss(i).Tables
                For Each red In dt.Rows
                    sb.Append("<Row>")
                    For Each kol In dt.Columns
                        sb.Append("<Cell>")
                        pom = "<Data ss:Type='"
                        tip = red(kol.ColumnName).GetType.ToString().Trim
                        If tip = "System.Decimal" Or tip = "System.Int32" Then
                            pom = pom & "Number"
                        Else
                            pom = pom & "String"
                        End If
                        pom = pom & "'>"
                        sb.Append(pom)
                        Dim kk As String = red(kol.ColumnName).ToString()
                        kk = kk.Replace("<", "&#60;")
                        kk = kk.Replace(">", "&#62;")
                        kk = kk.Replace("&", "&#38;")
                        kk = kk.Replace("'", "&#39;")
                        kk = kk.Replace("'''", "&#34;")
                        sb.Append(kk)
                        sb.Append("</Data>")
                        sb.Append(" ")
                        sb.Append("</Cell>")
                    Next
                    sb.Append("</Row>")
                Next ' svaki red u dt
            Next   'svaki dt u ds

            sb.Append("</Table>")
            sb.Append(WO(i))
            sb.Append("</Worksheet>")
            'kraj pisi ds, kraj noviSheet
        Next
        sb.Append("</Workbook>")

        Dim outfile As New System.IO.StreamWriter(Me.mExcelXML)
        outfile.Write(sb.ToString())
        outfile.Flush()
        outfile.Close()
        sr.Close()

        ' u ....xml je fajl (excel xml spreadsheet)
        ' njega save as .xlsx
        If openoff = False Then
            Call SaveAsXLSMSve(Me.mExcelXML)
            System.IO.File.Move(Me.mExcelXML, Me.mTrt)
        Else
            'Me.mExcelXML
        End If

        Dim imastA As Boolean = False

        If startAtPOM.Length > 0 Then
            For i As Integer = 0 To startAtPOM.GetUpperBound(0)
                Dim spom As Integer = startAtPOM(i).ToLower.IndexOf("--startat", 0)
                If spom >= 0 Then
                    imastA = True
                    Exit For
                End If
            Next
            If imastA = True Then startAt = startAtPOM
        End If

        napraviExcelXML = ime

    End Function
    Private Function SaveAsXLSM(ByVal a2 As Microsoft.Office.Interop.Excel.Application, ByVal wb As Microsoft.Office.Interop.Excel.Workbook, ByVal file As String, Optional ByVal EndOFEverything As Boolean = False) As Microsoft.Office.Interop.Excel.Workbook

        a2.DisplayAlerts = False
        'uvek da bi radili makroi koji u sebi podizu npr Windows("PRJ2.xls").Activate
        If oopenofficeods = False Then
            If Me.officeVersion >= "2007" Then
                If excelPgm = True Then
                    wb.SaveAs(Me.mxlsm, FileFormat:=52)
                End If
                If excelPgm = False OrElse EndOFEverything = True Then   'nema program u excelu zakacen
                    wb.SaveAs(Me.mxlsm, FileFormat:=52)
                Else
                    If Not System.IO.File.Exists(Me.mxls) Then
                        wb.SaveAs(Me.mxls, FileFormat:=1)
                    End If
                End If
            Else
                If Not System.IO.File.Exists(Me.mxls) Then
                    wb.SaveAs(Me.mxls, FileFormat:=1)
                End If
            End If
        Else
            'za open office treba
            wb.SaveAs(Me.mxlsm, FileFormat:=52)
        End If

        wb.Save()
        rExcelZag = wb.Name.Split(".")(1).ToUpper
        a2.DisplayAlerts = True
        Return wb
    End Function

    Private Sub SaveAsXLSMSve(ByVal file As String, Optional ByVal EndOFEverything As Boolean = False)

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a2 As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim wbm As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim wbx As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Try
            Try
                wb = a2.Workbooks.Open(file)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            a2.DisplayAlerts = False

            'uvek da bi radili makroi koji u sebi podizu npr Windows("PRJ2.xls").Activate

            If Me.officeVersion >= "2007" Then
                If excelPgm = True Then
                    wbm = SaveAsXLSM(a2, wb, file)
                End If
                If excelPgm = False OrElse EndOFEverything = True Then   'nema program u excelu zakacen
                    wbm = SaveAsXLSM(a2, wb, file)
                Else
                    If Not System.IO.File.Exists(Me.mxls) Then
                        wbm = SaveAsXLS(a2, wb, file)
                    End If
                End If
            Else
                If Not System.IO.File.Exists(Me.mxls) Then
                    wbm = SaveAsXLS(a2, wb, file)
                End If
            End If

            wb.Save()
            rExcelZag = wb.Name.Split(".")(1).ToUpper

            a2.DisplayAlerts = True

            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=True)
                Catch
                End Try
            End If

            a2.Quit()

            If wb IsNot Nothing Then Marshal.ReleaseComObject(wb)
            If wbm IsNot Nothing Then Marshal.ReleaseComObject(wbm)
            Marshal.ReleaseComObject(a2)

            GC.Collect()
            GC.WaitForPendingFinalizers()

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveAsTXT(ByVal file As String)

        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Try
            Try
                wb = a.Workbooks.Open(file)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            a.DisplayAlerts = False

            wb.SaveAs(Me.mTrt, FileFormat:=42)
            wb.SaveAs(Me.mtxt, FileFormat:=42)
            wb.Save()
            rProgram = wb.Name.Split(".")(1).ToUpper
            a.DisplayAlerts = True
            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=True)
                Catch
                End Try
            End If
            a.Quit()
            Marshal.ReleaseComObject(wb)
            Marshal.ReleaseComObject(a)
            GC.Collect()
            GC.WaitForPendingFinalizers()

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)

        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function SaveAsXLS(ByVal a As Microsoft.Office.Interop.Excel.Application, ByVal wb As Microsoft.Office.Interop.Excel.Workbook, ByVal file As String, Optional ByVal EndOFEverything As Boolean = False) As Microsoft.Office.Interop.Excel.Workbook

        a.DisplayAlerts = False
        If Not System.IO.File.Exists(Me.mxls) Then
            wb.SaveAs(Me.mxls, FileFormat:=1)
            rExcelZag = wb.Name.Split(".")(1).ToUpper
        End If
        a.DisplayAlerts = True
        Return wb
    End Function
    Private Sub SaveAsXLSSve(ByVal file As String, Optional ByVal EndOFEverything As Boolean = False)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a As New Microsoft.Office.Interop.Excel.Application

        Try
            Dim wb As Microsoft.Office.Interop.Excel.Workbook = a.Workbooks.Open(file)
            a.DisplayAlerts = False

            If Not System.IO.File.Exists(Me.mxls) Then
                wb.SaveAs(Me.mxls, FileFormat:=1)
                rExcelZag = wb.Name.Split(".")(1).ToUpper
            End If

            a.DisplayAlerts = True

            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=True)
                Catch
                End Try
            End If
            a.Quit()
            Marshal.ReleaseComObject(wb)
            Marshal.ReleaseComObject(a)
            GC.Collect()
            GC.WaitForPendingFinalizers()
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub SaveAsXLSXSve(ByVal file As String, Optional ByVal EndOFEverything As Boolean = False)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a As New Microsoft.Office.Interop.Excel.Application

        Try
            Dim wb As Microsoft.Office.Interop.Excel.Workbook = a.Workbooks.Open(file)
            a.DisplayAlerts = False

            If System.IO.File.Exists(Me.mxlsx) Then
                Call deleteFile(Me.mxlsx, "EXCEL.EXE")
            End If
            wb.SaveAs(Me.mxlsx, FileFormat:=51)
            rExcelZag = wb.Name.Split(".")(1).ToUpper

            a.DisplayAlerts = True

            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=True)
                Catch
                End Try
            End If
            a.Quit()
            Marshal.ReleaseComObject(wb)
            Marshal.ReleaseComObject(a)
            GC.Collect()
            GC.WaitForPendingFinalizers()
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ExportToExcel(ByVal dss() As System.Data.DataSet, ByVal r As DatasetIstrazivanja.ISTTABSRow, ByVal ppdatestart As Date)
        Dim brSH As Integer = UBound(dss)
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim a2 As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = Nothing
        Dim dt As System.Data.DataTable
        Dim finalRow As Integer = 1
        Dim col, row As Integer
        Try
            wb = a2.Workbooks.Add
            ws = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            For i As Integer = 0 To brSH
                'pisi ds
                For Each dt In dss(i).Tables
                    Dim rawData(dt.Rows.Count - 1, dt.Columns.Count - 1) As Object
                    For col = 0 To dt.Columns.Count - 1
                        For row = 0 To dt.Rows.Count - 1
                            rawData(row, col) = dt.Rows(row).ItemArray(col)
                        Next
                    Next
                    Dim finalColLetter As String = String.Empty
                    Dim colCharset As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
                    Dim colCharsetLen As Integer = colCharset.Length

                    If dt.Columns.Count > colCharsetLen Then
                        finalColLetter = colCharset.Substring((dt.Columns.Count - 1) \ colCharsetLen - 1, 1)
                    End If
                    finalColLetter = finalColLetter + colCharset.Substring((dt.Columns.Count - 1) Mod colCharsetLen, 1)

                    Dim brojredova As Integer

                    If dt.Rows.Count > 0 Then
                        brojredova = finalRow + dt.Rows.Count - 1
                    Else
                        brojredova = finalRow
                    End If

                    Dim excelRange As String = String.Format("A" & finalRow.ToString & ":{0}{1}", finalColLetter, brojredova)
                    ws.Range(excelRange).Value2 = rawData
                    finalRow = finalRow + dt.Rows.Count + 1
                    rawData = Nothing
                Next
                If dss(i).Namespace.Trim <> "" Then ws.Name = dss(i).Namespace.Trim.Replace("'", "")
                If i <> brSH Then ws = wb.Sheets.Add(After:=wb.Worksheets(i + 1))
                finalRow = 1
            Next

            Dim fi As New System.IO.FileInfo(Me.mxls)
            If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                System.IO.Directory.CreateDirectory(fi.DirectoryName)
            End If

            System.IO.File.Delete(Me.mxls)
            wb.SaveAs(Me.mxls)

            Call SaveAsXLSM(a2, wb, Me.mxls)  'u  Me.mxlsm je

            If Not r.IsExcelNull AndAlso r.Excel.Trim <> "" Then
                Try
                    Dim folderZaGen As String = ""
                    If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                        folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper
                    Else
                        folderZaGen = Me.mrist.TxtDir.Trim
                    End If
                    a2.Workbooks.Open(folderZaGen + "\" + r.Excel)
                Catch ex1 As System.Runtime.InteropServices.ExternalException
                    Throw ex1
                End Try

                Dim fi2 As New System.IO.FileInfo(r.Excel)
                Dim mn As String = fi2.Name.Replace(fi2.Extension, "")



                Try
                    a2.Run(fi2.Name.Trim + "!" + mn.Trim + "(" + ucvt.G.ToString + "," + ucvt.M.ToString + ")") ', varg1:=ucvt.G.ToString, varg2:=ucvt.M.ToString)
                    wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                Catch ex As System.Runtime.InteropServices.ExternalException
                    If ex.ErrorCode = -2146827284 Then
                        a2.Run(fi2.Name.Trim + "!" + mn.Trim)
                        wb.SaveAs(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
                    End If
                End Try
                wb.Save()
            End If
        Catch ex As System.Runtime.InteropServices.ExternalException
            If ex.ErrorCode <> -2146788248 Then
                Throw ex
            End If
        Finally

            If Not wb Is Nothing Then
                Try
                    wb.Close(SaveChanges:=False)
                Catch
                End Try
            End If

            a2.Quit()
            If Not ws Is Nothing Then Marshal.ReleaseComObject(ws)
            Marshal.ReleaseComObject(wb)
            Marshal.ReleaseComObject(a2)
            GC.Collect()
            GC.WaitForPendingFinalizers()

            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            End_Excel_App(ppdatestart, Date.Now)

            Call sredi88()



        End Try
    End Sub
    Sub sredi88()
        If System.IO.File.Exists(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm") = True Then
            Dim excelApp As Excel.Application = New Excel.Application()
            Dim workbooks As Excel.Workbooks = excelApp.Workbooks
            Dim workbook As Excel.Workbook

            excelApp.DisplayAlerts = False
            workbook = workbooks.Open(folder + "\" + Me.mrist.SIFIST.Trim + "88.xlsm")
            System.IO.File.Delete(Me.mxlsm)
            workbook.SaveAs(Me.mxlsm)
            Me.mxls = Me.mxlsm
            excelApp.Quit()
            If Not workbooks Is Nothing Then Marshal.ReleaseComObject(workbooks)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(excelApp)
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End If

    End Sub
    Public Sub obicanXML(ByVal dss() As System.Data.DataSet)

        Dim dsNovi As New System.Data.DataSet
        Dim dtNovi As New System.Data.DataTable
        Dim dt As New System.Data.DataTable
        Dim br As Integer = 0
        For Each ds As System.Data.DataSet In dss
            For Each dt In ds.Tables
                br = br + 1
                dtNovi = dt.Copy
                dtNovi.TableName = dtNovi.TableName.ToString.Trim & "_" & Str(br).ToString.Trim
                dsNovi.Tables.Add(dtNovi)
            Next
        Next
        dsNovi.AcceptChanges()
        dsNovi.WriteXml(Me.mXML)

    End Sub

    Public Sub obicanJSON(ByVal dss() As System.Data.DataSet)

        Dim dsNovi As New System.Data.DataSet
        Dim dtNovi As New System.Data.DataTable
        Dim dt As New System.Data.DataTable
        Dim br As Integer = 0
        For Each ds As System.Data.DataSet In dss
            For Each dt In ds.Tables
                br = br + 1
                dtNovi = dt.Copy
                dtNovi.TableName = dtNovi.TableName.ToString.Trim & "_" & Str(br).ToString.Trim
                dsNovi.Tables.Add(dtNovi)
            Next
        Next
        dsNovi.AcceptChanges()
        Dim folder As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)

        Dim tJSON As String = ""
        For tab As Integer = 0 To dsNovi.Tables.Count - 1
            tJSON = dsNovi.Tables(tab).TableName + ".JSON"
            'fajlovi = fajlovi + dsNovi.Tables(tab).TableName + ".JSON" + nvrd
            Dim sbJson As System.Text.StringBuilder = New System.Text.StringBuilder
            If dsNovi.Tables(tab).Rows.Count > 0 Then
                sbJson.Append("{" + nvrd + "  " + """" + dsNovi.Tables(tab).TableName + """" + ": [" + nvrd)
                For red As Integer = 0 To dsNovi.Tables(tab).Rows.Count - 1
                    sbJson.Append("    {  " + nvrd)
                    For kolona As Integer = 0 To dsNovi.Tables(tab).Columns.Count - 1
                        If kolona < dsNovi.Tables(tab).Columns.Count - 1 Then
                            sbJson.Append("      " + """" + dsNovi.Tables(tab).Columns(kolona).ColumnName.ToString() + """: " + """" + dsNovi.Tables(tab).Rows(red)(kolona).ToString() + """," + nvrd)
                        ElseIf kolona = dsNovi.Tables(tab).Columns.Count - 1 Then
                            sbJson.Append("      " + """" + dsNovi.Tables(tab).Columns(kolona).ColumnName.ToString() + """: " + """" + dsNovi.Tables(tab).Rows(red)(kolona).ToString() + """")
                        End If
                    Next
                    If red = dsNovi.Tables(tab).Rows.Count - 1 Then
                        sbJson.Append(nvrd + "    }" + nvrd)
                    Else
                        sbJson.Append(nvrd + "    }," + nvrd)
                    End If
                Next
                sbJson.Append("  ]" + nvrd + "}" + nvrd)
            Else
                'sbJson.Append(" ")
            End If
            'KONACAN ISPIS
            Try
                Dim ime As String = Me.mJSON.Replace(".JSON", "") + "_" + tJSON
                Dim outfile As New System.IO.StreamWriter(ime, False, System.Text.Encoding.UTF8)
                outfile.Write(sbJson.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Next

    End Sub

    Public Sub obicanCSV(ByVal dss() As System.Data.DataSet)

        Dim dsNovi As New System.Data.DataSet
        Dim dtNovi As New System.Data.DataTable
        Dim dt As New System.Data.DataTable
        Dim br As Integer = 0
        For Each ds As System.Data.DataSet In dss
            For Each dt In ds.Tables
                br = br + 1
                dtNovi = dt.Copy
                dtNovi.TableName = dtNovi.TableName.ToString.Trim & "_" & Str(br).ToString.Trim
                dsNovi.Tables.Add(dtNovi)
            Next
        Next
        dsNovi.AcceptChanges()
        Dim folder As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)

        Dim tCSV As String = ""
        For tab As Integer = 0 To dsNovi.Tables.Count - 1
            tCSV = dsNovi.Tables(tab).TableName + ".CSV"
            'fajlovi = fajlovi + dsNovi.Tables(tab).TableName + ".CSV" + nvrd
            Dim sbCSV As System.Text.StringBuilder = New System.Text.StringBuilder
            If dsNovi.Tables(tab).Rows.Count > 0 Then
                For j As Integer = 0 To dsNovi.Tables(tab).Columns.Count - 1
                    sbCSV.Append(dsNovi.Tables(tab).Columns(j).ColumnName.ToString() + ";")
                Next
                sbCSV.Append(nvrd)
                For i As Integer = 0 To dsNovi.Tables(tab).Rows.Count - 1
                    For j As Integer = 0 To dsNovi.Tables(tab).Columns.Count - 1
                        If j < dsNovi.Tables(tab).Columns.Count - 1 Then
                            sbCSV.Append(dsNovi.Tables(tab).Rows(i)(j).ToString() + ";")
                        ElseIf j = dsNovi.Tables(tab).Columns.Count - 1 Then
                            sbCSV.Append(dsNovi.Tables(tab).Rows(i)(j).ToString() + "")
                        End If
                    Next
                    sbCSV.Append(nvrd)
                Next
            End If

            'KONACAN ISPIS
            Try
                Dim ime As String = Me.mCSV.Replace(".csv", "") + "_" + tCSV
                Dim outfile As New System.IO.StreamWriter(ime, False, System.Text.Encoding.UTF8)
                outfile.Write(sbCSV.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Next

    End Sub

    Public Sub obicanTXTtxt(ByVal dss() As System.Data.DataSet, Optional txtwithSeparator As Boolean = False)

        Dim dsNovi As New System.Data.DataSet
        Dim dtNovi As New System.Data.DataTable
        Dim dt As New System.Data.DataTable
        Dim br As Integer = 0
        For Each ds As System.Data.DataSet In dss
            For Each dt In ds.Tables
                If dt.Rows.Count > 0 AndAlso dt.Rows(0).ItemArray.Length > 0 AndAlso Not dt.Rows(0).ItemArray(0) Is Nothing AndAlso dt.Rows(0).ItemArray(0).ToString <> "" Then
                    br = br + 1
                    dtNovi = dt.Copy
                    dtNovi.TableName = dtNovi.TableName.ToString.Trim & "_" & Str(br).ToString.Trim
                    dsNovi.Tables.Add(dtNovi)
                End If
            Next
        Next
        dsNovi.AcceptChanges()
        Dim folder As String = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop)

        Dim separator As String = ""
        If txtwithSeparator = True Then separator = "|"

        Dim tTXT As String = ""
        For tab As Integer = 0 To dsNovi.Tables.Count - 1
            tTXT = dsNovi.Tables(tab).TableName + ".TXT"
            Dim sbTXT As System.Text.StringBuilder = New System.Text.StringBuilder
            If dsNovi.Tables(tab).Rows.Count > 0 Then
                Dim txt As String = String.Empty
                'For Each column As DataColumn In dsNovi.Tables(tab).Columns
                '    'Add the Header row for Text file.
                '    txt += column.ColumnName & separator
                'Next
                txt += vbCr & vbLf
                For Each row As DataRow In dsNovi.Tables(tab).Rows
                    For Each column As DataColumn In dsNovi.Tables(tab).Columns
                        txt += row(column.ColumnName).ToString() & separator
                    Next
                    txt += vbCr & vbLf
                Next
                sbTXT.Append(txt)
            End If

            'KONACAN ISPIS
            Try
                Dim ime As String = ""
                If dsNovi.Tables.Count = 1 Then
                    ime = Me.mtxt
                Else
                    ime = Me.mtxt.Replace(".txt", "") + "_" + tTXT
                End If

                Dim outfile As New System.IO.StreamWriter(ime, False, System.Text.Encoding.UTF8)
                'Dim NewFont As Font
                'NewFont = New Font("Courier new", 10, FontStyle.Regular)
                outfile.Write(sbTXT.ToString())
                outfile.Flush()
                outfile.Close()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
            End Try
        Next

    End Sub

    Sub fontNotepad()
        Dim fs = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Notepad", True)
        fs.SetValue("lfFaceName", "Courier New")
        fs.SetValue("fWrap", 0)
        fs.SetValue("iPointSize", 80)
        fs.Close()
    End Sub

    '    [HKEY_CURRENT_USER\Software\Microsoft\Notepad]
    '"lfEscapement"=dword:00000000
    '"lfOrientation"=dword:00000000
    '"lfWeight"=dword:00000190
    '"lfItalic"=dword:00000000
    '"lfUnderline"=dword:00000000
    '"lfStrikeOut"=dword:00000000
    '"lfCharSet"=dword:000000b2
    '"lfOutPrecision"=dword:00000003
    '"lfClipPrecision"=dword:00000002
    '"lfQuality"=dword:00000001
    '"lfPitchAndFamily"=dword:00000031
    '"lfFaceName"="Courier New"
    '"iPointSize"=dword:0000005a



    Private Sub Xls2staro(ByVal r As DatasetIstrazivanja.ISTTABSRow)
        If rExcelZag = "" Then
            Return
        End If
        Dim folderZaGen As String = ""
        If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
            folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper
        Else
            folderZaGen = Me.mrist.TxtDir.Trim
        End If
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
            Dim pomxls As String = Me.mxls
            Dim pomZaglavlje As String = ""
            Try
                If System.IO.File.Exists(folderZaGen + "\" + r.ExcelZag) = True Then
                    If System.IO.File.Exists(folder + "\zz" + r.ExcelZag) = True Then System.IO.File.Delete(folder + "\zz" + r.ExcelZag)
                    System.IO.File.Copy(folderZaGen + "\" + r.ExcelZag, folder + "\zz" + r.ExcelZag)
                End If
                pomZaglavlje = folder + "\zz" + r.ExcelZag
            Catch ex As Exception
                pomZaglavlje = folderZaGen + "\" + r.ExcelZag
            End Try

            Dim oExcel As New Microsoft.Office.Interop.Excel.Application

            Dim oBook As Microsoft.Office.Interop.Excel.Workbook = oExcel.Workbooks.Open(pomxls)
            oExcel.DisplayAlerts = False
            oExcel.CutCopyMode = 1
            oBook.Activate()
            Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet = oBook.Worksheets.Item(1)
            Dim oBook2 As Microsoft.Office.Interop.Excel.Workbook = oExcel.Workbooks.Open(pomZaglavlje)
            Dim oSheet2 As Microsoft.Office.Interop.Excel.Worksheet = oBook2.Worksheets.Item(1)
            oSheet2.Activate()
            Dim zr As Microsoft.Office.Interop.Excel.Range = oSheet2.Rows("1:5")
            zr.Copy()
            oSheet.Activate()
            oSheet.Rows(1).Resize(8).insert()
            oBook.Activate()
            oBook.Save()
            oExcel.CutCopyMode = 0
            oExcel.DisplayAlerts = True
            oBook.Close(False)
            oBook = Nothing
            oBook2.Close(False)
            oBook2 = Nothing
            releaseObject(oBook)
            releaseObject(oBook2)

            oExcel.Quit()
            oExcel = Nothing
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
            releaseObject(oExcel)
            End_Excel_App(ppdatestart, Date.Now)
        Catch
        End Try
    End Sub
    Dim opomZaglavlje As String = ""
    Dim olastRowzaglavlje As Long = 6
    Private Sub Xls2(ByVal r As DatasetIstrazivanja.ISTTABSRow)
        If rExcelZag = "" Then
            Return
        End If
        Dim folderZaGen As String = ""
        If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
            folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper
        Else
            folderZaGen = Me.mrist.TxtDir.Trim
        End If
        Try
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

            ''samo ne za xml
            Dim pomxls As String = ""
            Dim pomZaglavlje As String = ""
            opomZaglavlje = ""
            olastRowzaglavlje = 6
            Try
                If System.IO.File.Exists(folderZaGen + "\" + r.ExcelZag) = True Then
                    If System.IO.File.Exists(folder + "\zz" + r.ExcelZag) = True Then System.IO.File.Delete(folder + "\zz" + r.ExcelZag)
                    System.IO.File.Copy(folderZaGen + "\" + r.ExcelZag, folder + "\zz" + r.ExcelZag)
                End If
                pomZaglavlje = folder + "\zz" + r.ExcelZag
            Catch ex As Exception
                pomZaglavlje = folderZaGen + "\" + r.ExcelZag
            End Try

            If rExcelZag = "XLS" = True Then pomxls = Me.mxls
            If rExcelZag = "XLSX" OrElse rExcelZag = "XLSM" Then pomxls = Me.mxlsm

            If rExcelZag <> "XML" Then   'samo ne za xml
                Dim a2 As New Microsoft.Office.Interop.Excel.Application
                Dim oBookPodaci As Workbook
                oBookPodaci = a2.Workbooks.Open(pomxls)
                Dim oBookZaglavlje As Microsoft.Office.Interop.Excel.Workbook = a2.Workbooks.Open(pomZaglavlje)
                a2.DisplayAlerts = False
                a2.CutCopyMode = 1
                oBookPodaci.Activate()
                Dim oSheetPodaci As Microsoft.Office.Interop.Excel.Worksheet = oBookPodaci.Worksheets.Item(1)
                Dim oSheetZaglavlje As Microsoft.Office.Interop.Excel.Worksheet = oBookZaglavlje.Worksheets.Item(1)
                oSheetZaglavlje.Activate()
                opomZaglavlje = pomZaglavlje
                Dim lastRowzaglavlje As Long = oSheetZaglavlje.Cells(oSheetZaglavlje.Rows.Count, 1).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row
                olastRowzaglavlje = lastRowzaglavlje
                Dim zaglavlje As Microsoft.Office.Interop.Excel.Range = oSheetZaglavlje.Rows("1:" & lastRowzaglavlje.ToString())
                zaglavlje.Copy()
                oSheetPodaci.Activate()

                ' da uzme od zaglavlja bar sirinu kolona
                Dim columnCount As Integer = oSheetZaglavlje.UsedRange.Columns.Count
                For i As Integer = 1 To columnCount
                    Dim currentColumnZ As Microsoft.Office.Interop.Excel.Range = oSheetZaglavlje.Columns(i)
                    Dim columnWidthZ As Double = currentColumnZ.ColumnWidth
                    oSheetPodaci.Columns(i).ColumnWidth = columnWidthZ
                Next

                oSheetPodaci.Rows(1).Resize(8).insert()
                oBookPodaci.Activate()
                oBookPodaci.Save()
                a2.CutCopyMode = 0
                a2.DisplayAlerts = True

                oBookPodaci.Close(False)
                oBookZaglavlje.Close(False)
                a2.Quit()

                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

                releaseObject(oBookPodaci)
                releaseObject(oBookZaglavlje)
                releaseObject(a2)
                End_Excel_App(ppdatestart, Date.Now)

            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim ppdatestart As Date
    Sub prikaziClick()
        If Not System.IO.File.Exists(Me.mxls) AndAlso Not System.IO.File.Exists(Me.mExcelXML) AndAlso Not System.IO.File.Exists(Me.mxlsm) AndAlso Not System.IO.File.Exists(Me.mxlsx) Then
            ''msg 244
            Dim msgtxt244 As String = getMessageText(dtMessages, "244", Me.jezik)
            ISTMessageBox.Show(msgtxt244, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ppdatestart = Date.Now

        ' u ....xml je fajl (excel xml spreadsheet)
        ' njega save as .xlsx
        If oopenofficeods = False AndAlso rExcelZag = "XML" Then
            Call SaveAsXLSMSve(Me.mExcelXML)
            System.IO.File.Move(Me.mExcelXML, Me.mTrt)
        Else
            'Me.mExcelXML
        End If

        If System.IO.File.Exists(Me.mxls) = True Then
            If Me.officeVersion >= "2007" Then
                If excelPgm = True Then
                    SaveAsXLSMSve(Me.mxls, True)
                    program(Me.mxlsm, True, "", "")
                Else
                    If staroExcel = True Then
                        Call SaveAsXLSMSve(Me.mxls, True)
                        If Me.mxlsm <> Me.mxls Then System.IO.File.Delete(Me.mxls)
                        program(Me.mxlsm, True, "", "")
                    Else
                        If System.IO.File.Exists(Me.mxlsm) = False Then Call SaveAsXLSMSve(Me.mxls, True)
                        If Me.mxlsm <> Me.mxls Then System.IO.File.Delete(Me.mxls)
                        program(Me.mxlsm, True, "", "")
                    End If
                End If
            Else
                program(Me.mxls, True, "", "")
            End If
        Else
            If System.IO.File.Exists(Me.mxlsm) = True Then
                program(Me.mxlsm, True, "", "")
            Else
                If System.IO.File.Exists(Me.mxlsx) = True Then program(Me.mxlsx, True, "", "")
            End If
        End If

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub ButtonPrikaziExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrikaziExcel.Click

        Call prikaziClick()
    End Sub

    Private Sub openOfficeXLS(ByVal lockOO As Boolean, ByVal rExcelZagPom As String)
        If Not System.IO.File.Exists(Me.mxls) AndAlso Not System.IO.File.Exists(Me.mExcelXML) AndAlso Not System.IO.File.Exists(Me.mxlsm) AndAlso Not System.IO.File.Exists(Me.mxlsx) AndAlso Not System.IO.File.Exists(Me.mOOCalc) Then
            ''msg 244
            Dim msgtxt244 As String = getMessageText(dtMessages, "244", Me.jezik)
            ISTMessageBox.Show(msgtxt244, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        'Me.mExcelXML or Me.mxlsx
        Dim fpath As String = ""
        If rExcelZagPom = "XML" AndAlso System.IO.File.Exists(Me.mExcelXML) = True Then
            fpath = Me.mExcelXML
        End If

        If rExcelZagPom = "ODS" AndAlso System.IO.File.Exists(Me.mOOCalc) = True Then
            fpath = Me.mOOCalc
        End If

        Dim kk As String = programOO(fpath, lockOO, rExcelZagPom)
        If kk = "" Then End_OO_App(ppdatestart, Date.Now)
    End Sub

    Sub CopyPageStyle(ByVal ePath As String)
        Dim eApp As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = eApp.Workbooks.Open(ePath)
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        Dim oBookZaglavlje As Microsoft.Office.Interop.Excel.Workbook = eApp.Workbooks.Open(opomZaglavlje)
        Dim ss As Microsoft.Office.Interop.Excel.Worksheet = CType(oBookZaglavlje.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

        ws.PageSetup.LeftMargin = ss.PageSetup.LeftMargin
        ws.PageSetup.RightMargin = ss.PageSetup.RightMargin
        ws.PageSetup.TopMargin = ss.PageSetup.TopMargin
        ws.PageSetup.BottomMargin = ss.PageSetup.BottomMargin
        ws.PageSetup.PaperSize = ss.PageSetup.PaperSize
        ws.PageSetup.Zoom = ss.PageSetup.Zoom
        ws.PageSetup.FitToPagesTall = ss.PageSetup.FitToPagesTall
        ws.PageSetup.FitToPagesWide = ss.PageSetup.FitToPagesWide

        ws.PageSetup.Orientation = ss.PageSetup.Orientation
        'ws.PageSetup.CenterHeader = sourceWorkbook.PageSetup.CenterHeader

        Dim columnCount As Integer = ss.UsedRange.Columns.Count
        For i As Integer = 1 To columnCount
            Dim currentColumnZ As Microsoft.Office.Interop.Excel.Range = ss.Columns(i)
            Dim columnWidthZ As Double = currentColumnZ.ColumnWidth
            ws.Columns(i).ColumnWidth = columnWidthZ
        Next

        If Not wb Is Nothing Then
            Try
                wb.Close(SaveChanges:=True)
            Catch
            End Try
        End If
        eApp.Quit()
        Marshal.ReleaseComObject(ws)
        Marshal.ReleaseComObject(wb)
        Marshal.ReleaseComObject(ss)
        Marshal.ReleaseComObject(oBookZaglavlje)
        Marshal.ReleaseComObject(eApp)

        GC.Collect()
        GC.WaitForPendingFinalizers()
        End_Excel_App(ppdatestart, Date.Now)
    End Sub

    Function programOO(ByVal fn As String, ByVal lockOO As Boolean, ByVal rExcelZag As String) As String
        programOO = ""
        Dim ok As String = ""
        Dim kon As String = ""
        Try
            ok = ConnectOpenOffice()
            If ok = "ok" Then
                Dim sNewfileFormName As String = fn
                Dim inputOdsPath As String = sNewfileFormName
                If lockOO = False Then
                    Dim agr(1) As Object
                    inputOdsPath = "file:///" + inputOdsPath.Replace("\", "/")
                    Dim myDoc As Object
                    myDoc = StarDesktop.loadComponentFromURL(convertToURL(sNewfileFormName), "_default", 0, agr)
                    kon = "open"
                Else
                    Dim outputPdfPath As String = NZ(Replace(sNewfileFormName, rExcelZag.ToLower, "pdf", 1, , CompareMethod.Text)).Trim
                    Call DeleteFileIfExists(outputPdfPath)
                    Call ExportOdsToPdf(inputOdsPath, outputPdfPath)
                    Call OpenPdfFile(outputPdfPath)
                    kon = ""
                End If
                If kon = "" Then Call DisconnectOpenOffice()
                programOO = kon
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Function

    Sub OpenPdfFile(pdfPath As String)
        If Not String.IsNullOrEmpty(pdfPath) Then
            Try
                Process.Start(pdfPath)
            Catch ex As Exception
                ISTMessageBox.Show("Error opening PDF file " & ex.Message)
            End Try
        Else
            ISTMessageBox.Show("PDF file path Is empty.")
        End If
    End Sub

    Sub DeleteFileIfExists(filePath As String)
        If Not String.IsNullOrEmpty(filePath) Then
            If File.Exists(filePath) Then
                Try
                    Call deleteFile(filePath, "ACROBAT.EXE")
                Catch ex As Exception
                    '  Console.WriteLine("Error deleting file: " & ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Function Determine_OfficeVersion_1() As String
        Determine_OfficeVersion_1 = ""

        Determine_OfficeVersion_1 = "2003"
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        Dim eApp As New Microsoft.Office.Interop.Excel.Application
        Dim strEVersion As String = "2003"
        Select Case eApp.Version 'Determine Version
            Case "11.0"
                strEVersion = "2003"
            Case "12.0"
                strEVersion = "2007"
            Case "14.0"
                strEVersion = "2010"
            Case "15.0"
                strEVersion = "2013"
            Case "16.0"
                strEVersion = "2016"
        End Select

        Determine_OfficeVersion_1 = strEVersion

        eApp.Quit()
        Marshal.ReleaseComObject(eApp)
        GC.Collect()
        GC.WaitForPendingFinalizers()

    End Function
    Function IsOfficeInstalled() As Boolean

        ' Check for generic Office registry keys
        Dim officeKeys() As String = {
            "SOFTWARE\Microsoft\Office",
            "SOFTWARE\Wow6432Node\Microsoft\Office"
        }

        For Each officeKey As String In officeKeys
            Dim key As RegistryKey = Registry.LocalMachine.OpenSubKey(officeKey)
            If key IsNot Nothing Then
                Return True
            End If
        Next

        ' Office is not found
        Return False
    End Function

    Sub buttonXMLClick()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If oopenofficeods = False AndAlso rExcelZag = "XML" Then
            Call SaveAsXLSMSve(Me.mExcelXML)
            System.IO.File.Move(Me.mExcelXML, Me.mTrt)
        End If

        Dim d As New System.Windows.Forms.OpenFileDialog
        d.Title = "Select XML "
        If Me.wfn.Trim = "" Then
            d.FileName = Me.mXML
        Else
            d.FileName = Me.wfn
        End If
        d.Filter = "XML files (*.xml)|*.xml"
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK AndAlso d.FileName.Trim <> "" Then
            program(d.FileName, True, "", "")
        End If
        d.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Sub ButtonXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonXML.Click


        Call buttonXMLClick()
    End Sub

    Private Sub ButtonJSON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonJSON.Click


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim d As New System.Windows.Forms.OpenFileDialog
        d.Title = "Select JSON "
        If Me.wfn.Trim = "" Then
            d.FileName = Me.mJSON
        Else
            d.FileName = Me.wfn
        End If
        d.Filter = "JSON files (*.json)|*.json"
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK AndAlso d.FileName.Trim <> "" Then
            program(d.FileName, True, "", "")
        End If
        d.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub ButtonCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCSV.Click


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim d As New System.Windows.Forms.OpenFileDialog
        d.Title = "Select CSV "
        If Me.wfn.Trim = "" Then
            d.FileName = Me.mCSV
        Else
            d.FileName = Me.wfn
        End If
        d.Filter = "CSV files (*.csv)|*.csv"
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK AndAlso d.FileName.Trim <> "" Then
            'program(d.FileName, True, "", "")
            System.Diagnostics.Process.Start("notepad.exe", d.FileName)
        End If
        d.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    'XML
    Private Function XMLizeString(ByVal sInput As String) As String
        If Not (IsAlphaNumeric(sInput)) Then
            sInput = sInput.Replace("<", "&#60;")
            sInput = sInput.Replace(">", "&#62;")
            sInput = sInput.Replace("&", "&#38;")
            sInput = sInput.Replace("'", "&#39;")
            sInput = sInput.Replace("'''", "&#34;")
            Return " <![CDATA[" & sInput & "]]>"
        Else
            Return sInput
        End If
    End Function

    Private Function IsAlphaNumeric(ByVal TestString As String) As Boolean
        Dim sTemp As String
        Dim iLen As Integer
        Dim iCtr As Integer
        Dim sChar As String

        sTemp = TestString
        iLen = Len(sTemp)
        If iLen > 0 Then
            For iCtr = 1 To iLen
                sChar = Mid(sTemp, iCtr, 1)
                If Not sChar Like "[0-9A-Za-z.:, ]" Then Exit Function
            Next
            IsAlphaNumeric = True
        End If
    End Function


    Function checkExcelOpen(ByRef sName As String) As Boolean
        Dim fs As FileStream
        Try
            fs = File.Open(sName, FileMode.Open, FileAccess.Read, FileShare.None)
            checkExcelOpen = False
            fs.Close()
        Catch ex As Exception
            checkExcelOpen = True
        End Try
    End Function

    Private Sub ButtonEndExcel_Click(sender As Object, e As EventArgs) Handles ButtonEndExcel.Click


        Call End_App("EXCEL", Nothing, Nothing)
    End Sub
    Private Sub ButtonEndWord_Click(sender As Object, e As EventArgs) Handles ButtonEndWord.Click


        Call End_App("WINWORD", Nothing, Nothing)
    End Sub
    Private Sub ButtonEndOpenOffice_Click(sender As Object, e As EventArgs) Handles ButtonEndOpenOffice.Click


        ' Call End_App("SOFFICE", Nothing, Nothing) 
        Call End_App("SOFFICE.BIN", Nothing, Nothing)
        Call End_App("SOFFICE", Nothing, Nothing)
    End Sub
    Private Sub ButtonTXT_Click(sender As Object, e As EventArgs) Handles ButtonTXT.Click


        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim d As New System.Windows.Forms.OpenFileDialog
        d.Title = "Select TXT "
        If Me.wfn.Trim = "" Then
            d.FileName = Me.mtxt
        Else
            d.FileName = Me.wfn
        End If
        d.Filter = "TXT files (*.txt)|*.txt"
        If d.ShowDialog = System.Windows.Forms.DialogResult.OK AndAlso d.FileName.Trim <> "" Then
            program(d.FileName, True, "", "")
        End If
        d.Dispose()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Public Shared Sub MapirajAzureDrive()
        Dim p As New Process()
        ' Redirect the output stream of the child process.
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C net use S: \\istfileshareaccount.file.core.windows.net\istfileshare /u:AZURE\istfileshareaccount H8q+CSPlIu0nbMbRZWcDHfJanTAVjIiyn0Lr5MRL2IdvC/fmqg8GbyIryCBQHeTGjX4tOz9bMcN+5PcpSSnCLw== /persistent:no"
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.Verb = "runas"
        Try
            p.Start()
            p.WaitForExit()
        Catch ex As Exception
        End Try
    End Sub

    Public Shared Sub UnMapirajAzureDrive()

        Dim p As New Process()
        ' Redirect the output stream of the child process.
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C net use S: /delete"
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.Verb = "runas"
        Try
            p.Start()
            p.WaitForExit()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FormIzvestaji_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If txtmode.Trim.ToUpper = "CLOUD" Then Call UnMapirajAzureDrive()
    End Sub

    Private Sub FormIzvestaji_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call PreVentFlicker()
        Call SettingObjForTheme(GetTheme())
        ListBoxNoviIzvestaj.Width = PanelContext.Width - 21
        ListBoxNoviIzvestaj.Height = PanelContext.Height - PanelTop.Height - 15
        Call nonvisiblePanelTOP()

        If Me.panelmenucollapse = True Then
            Call CollapseMenu()
        End If

        ButtonIzvNoviIzvestaj.Focus()



    End Sub
    ' Sub setTheme(ByVal theme As String)
    'If theme = "L" Then
    '    ISTTheme.ChosenTheme("Light")
    '    ActivateButtonColor = ISTTheme.ActivateButtons
    '    PanelMenu.BackColor = ISTTheme.PanelParent
    '    PanelTop.BackColor = ISTTheme.PanelParent
    'Else
    '    ISTTheme.ChosenTheme("Dark")
    '    ActivateButtonColor = ISTTheme.ActivateButtons
    '    PanelMenu.BackColor = ISTTheme.PanelParent
    '    PanelTop.BackColor = ISTTheme.PanelParent
    'End If
    ' End Sub
    Sub SettingObjForTheme(ByVal theme As String)
        Dim nizButtonOboji() As Control = {}
        Dim inizButtonOboji As Integer = -1

        ReDim Preserve nizButtonOboji(1)
        nizButtonOboji(1) = PanelMenu
        ReDim Preserve nizButtonOboji(2)
        nizButtonOboji(2) = PanelTop
        ReDim Preserve nizButtonOboji(3)
        'Dim nizButtonOrange() As Button = {}
        'Dim inizButtonOrange As Integer = -1

        'For i As Integer = 0 To nizButton.GetUpperBound(0)
        '    ReDim Preserve nizButtonOrange(i)
        '    nizButtonOrange(i) = nizButton(i)
        '    inizButtonOrange = i
        'Next
        zapamtibojuteme = setTheme(nizButtonOboji, Nothing, theme)

    End Sub
    Dim zapamtibojuteme As Color = Nothing

    Public Sub OpenExcel(ByVal ePath As String)
        Dim eApp As New Microsoft.Office.Interop.Excel.Application
        Dim wb As Microsoft.Office.Interop.Excel.Workbook = eApp.Workbooks.Open(ePath)
        Dim ws As Microsoft.Office.Interop.Excel.Worksheet = CType(wb.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)
    End Sub
    Public Sub releaseExcel(ByVal eApp As Microsoft.Office.Interop.Excel.Application, ByVal wb As Microsoft.Office.Interop.Excel.Workbook, ByVal ws As Microsoft.Office.Interop.Excel.Worksheet, ByVal sCh As Boolean)
        wb.Close(SaveChanges:=sCh)
        eApp.Quit()
        Marshal.ReleaseComObject(ws)
        Marshal.ReleaseComObject(wb)
        Marshal.ReleaseComObject(eApp)
    End Sub
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        CollapseMenu()
    End Sub


    Dim zapamtilogovanog As String = ""
    Private Sub CollapseMenu()
        If Me.PanelMenu.Width > 200 Then
            PanelMenu.Width = 60
            ListBoxNoviIzvestaj.Width = PanelContext.Width - 21
            setTollTip(True)
            panelmenucollapse = True
            Button2.Visible = False
            Button7.Image = Nothing
            btnLinija.Width = 0
            ButtonEndExcel.Text = " "
            ButtonEndWord.Text = " "
            ButtonEndOpenOffice.Text = " "
            Dim dIndex = Logovan.Text.IndexOf(".")
            If (dIndex > -1) AndAlso (dIndex + 2) < Len(zapamtilogovanog) Then
                Logovan.Visible = True
                Logovan.Text = zapamtilogovanog.Trim.ToUpper.Substring(0, 1) + zapamtilogovanog.Trim.ToUpper.Substring(dIndex, 2)
            Else
                Logovan.Text = ""
            End If
        Else
            PanelMenu.Width = 255
            ListBoxNoviIzvestaj.Width = PanelContext.Width - 21
            Logovan.Visible = True
            Logovan.Text = zapamtilogovanog
            setTollTip(False)
            panelmenucollapse = False
            Button7.Image = My.Resources.crtaaaaa.ToBitmap

            ButtonEndExcel.Text = pomExcel
            ButtonEndWord.Text = pomWord
            ButtonEndOpenOffice.Text = pomOF
            Button2.Visible = True
        End If

    End Sub
    Dim pomExcel As String = ""
    Dim pomWord As String = ""
    Dim pomOF As String = ""
    Sub setTollTip(ByVal visibleTrue As Boolean)
        If visibleTrue = True Then
            ToolTip1.SetToolTip(ButtonIzvNoviIzvestaj, ButtonIzvNoviIzvestaj.Tag)
            ToolTip1.SetToolTip(ButtonPrikaziExcel, ButtonPrikaziExcel.Tag)
            ToolTip1.SetToolTip(ButtonCSV, ButtonCSV.Tag)
            ToolTip1.SetToolTip(ButtonJSON, ButtonJSON.Tag)
            ToolTip1.SetToolTip(ButtonXML, ButtonXML.Tag)
            ToolTip1.SetToolTip(ButtonTXT, ButtonTXT.Tag)
            ToolTip1.SetToolTip(ButtonEndExcel, ButtonEndExcel.Tag)
            ToolTip1.SetToolTip(ButtonEndWord, ButtonEndWord.Tag)
            ToolTip1.SetToolTip(ButtonEndOpenOffice, ButtonEndOpenOffice.Tag)
        Else
            ToolTip1.SetToolTip(ButtonIzvNoviIzvestaj, "")
            ToolTip1.SetToolTip(ButtonCSV, "")
            ToolTip1.SetToolTip(ButtonJSON, "")
            ToolTip1.SetToolTip(ButtonXML, "")
            ToolTip1.SetToolTip(ButtonTXT, "")
            ToolTip1.SetToolTip(ButtonEndExcel, "")
            ToolTip1.SetToolTip(ButtonEndWord, "")
            ToolTip1.SetToolTip(ButtonEndOpenOffice, "")
        End If
    End Sub
    Private currentBtn As System.Windows.Forms.Button
    Private Sub ActivateButton(ByVal senderBtn As Object, ByVal color As Color)
        If senderBtn IsNot Nothing Then
            DisableButton(Color.Transparent)
            currentBtn = CType(senderBtn, System.Windows.Forms.Button)
            currentBtn.BackColor = color
        End If
    End Sub

    Private Sub DisableButton(ByVal color As Color)
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = color
        End If
    End Sub

    'Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
    '    Me.Close()
    'End Sub


    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.btnCerrar.PerformClick()
    End Sub

    Private Sub ButtonEndOpenOffice_MouseDown(sender As Object, e As MouseEventArgs) Handles ButtonIzvNoviIzvestaj.MouseDown, ButtonXML.MouseDown, ButtonTXT.MouseDown, ButtonPrikaziExcel.MouseDown, ButtonJSON.MouseDown, ButtonEndWord.MouseDown, ButtonEndOpenOffice.MouseDown, ButtonEndExcel.MouseDown, ButtonCSV.MouseDown
        ActivateButton(sender, ActivateButtonColor)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
    End Sub


    Sub visiblePanelTOP()
        btnArrowDownHover.Visible = False
        b3.Visible = True
        PanelTop.BackColor = zapamtibojuteme
        btnCerrar.Visible = True
        btnMinimizar.Visible = True
    End Sub

    Sub nonvisiblePanelTOP()
        btnCerrar.Visible = False
        btnMinimizar.Visible = False
        b3.Visible = False
        PanelTop.BackColor = System.Drawing.Color.FromArgb(252, 251, 249)
        btnArrowDownHover.Visible = True
    End Sub

    Private Sub PanelTop_MouseLeave(sender As Object, e As EventArgs) Handles PanelTop.MouseLeave, btnMinimizar.MouseLeave, btnCerrar.MouseLeave, b3.MouseLeave
        If MouseIsOverButton(b3) OrElse MouseIsOverButton(btnCerrar) OrElse MouseIsOverButton(btnMinimizar) OrElse MouseIsOverPanel(PanelTop) Then
        Else
            nonvisiblePanelTOP()
        End If

    End Sub

    Private Sub btnArrowDownHover_MouseHover(sender As Object, e As EventArgs) Handles btnArrowDownHover.MouseHover, PanelTop.MouseHover
        visiblePanelTOP()
    End Sub

    Private Sub PanelMenu_MouseEnter(sender As Object, e As EventArgs) Handles btnMinimizar.MouseEnter
        visiblePanelTOP()
    End Sub

    Private Function MouseIsOverButton(ByVal btn As System.Windows.Forms.Button) As Boolean
        Return btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position))
    End Function

    Private Function MouseIsOverPanel(ByVal pnl As Panel) As Boolean
        Return pnl.ClientRectangle.Contains(pnl.PointToClient(Cursor.Position))
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Close()
        System.Windows.Forms.Application.Exit()
    End Sub


End Class



