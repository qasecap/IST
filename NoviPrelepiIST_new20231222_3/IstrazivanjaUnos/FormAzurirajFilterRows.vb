Imports System.Collections.Generic
Imports System.Reflection
Imports System.Runtime.InteropServices

Public Class FormAzurirajFilterRows
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.prvi_CheckedChanged(Nothing, Nothing)
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
    Friend WithEvents ButtonOK As System.Windows.Forms.Button

    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ComboBoxRedovi As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents NumericUpDownPrvihRedova As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxPrvihRedova As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonRejectChangesPrimaryKey As System.Windows.Forms.Button
    Friend WithEvents ButtonRejectChangesErrorColumns As System.Windows.Forms.Button
    Friend WithEvents ButtonRejectChangesUpdatableColumns As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSQL As System.Windows.Forms.TextBox
    Friend WithEvents TabPageIzbor1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSQL As System.Windows.Forms.TabPage
    Friend WithEvents cmbTezinaGreske As System.Windows.Forms.ComboBox
    Friend WithEvents dgvUpdatableColumns As DataGridView
    Friend WithEvents dgvErrorColumns As DataGridView
    Friend WithEvents dgvPrimaryKey As DataGridView
    Friend WithEvents PanelTop As Panel
    Friend WithEvents Logovan As Label
    Friend WithEvents PanelContext As Panel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents bok As Button
    Friend WithEvents bc As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents meText As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tv As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAzurirajFilterRows))
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxRedovi = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDownPrvihRedova = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxPrvihRedova = New System.Windows.Forms.CheckBox()
        Me.ButtonRejectChangesPrimaryKey = New System.Windows.Forms.Button()
        Me.ButtonRejectChangesErrorColumns = New System.Windows.Forms.Button()
        Me.ButtonRejectChangesUpdatableColumns = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageIzbor1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvUpdatableColumns = New System.Windows.Forms.DataGridView()
        Me.dgvErrorColumns = New System.Windows.Forms.DataGridView()
        Me.dgvPrimaryKey = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTezinaGreske = New System.Windows.Forms.ComboBox()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.TabPageSQL = New System.Windows.Forms.TabPage()
        Me.TextBoxSQL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.bok = New System.Windows.Forms.Button()
        Me.bc = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownPrvihRedova, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPageIzbor1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvUpdatableColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvErrorColumns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPrimaryKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSQL.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelContext.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOK.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonOK.Location = New System.Drawing.Point(218, 811)
        Me.ButtonOK.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(136, 26)
        Me.ButtonOK.TabIndex = 28
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCancel.Location = New System.Drawing.Point(520, 811)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(136, 26)
        Me.ButtonCancel.TabIndex = 29
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(20, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 14)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Остала поља:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(20, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(301, 14)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Поља за јединствену идентификацију слога:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(22, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 14)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Изабрати слогове:"
        '
        'ComboBoxRedovi
        '
        Me.ComboBoxRedovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRedovi.ItemHeight = 14
        Me.ComboBoxRedovi.Location = New System.Drawing.Point(171, 14)
        Me.ComboBoxRedovi.Name = "ComboBoxRedovi"
        Me.ComboBoxRedovi.Size = New System.Drawing.Size(215, 22)
        Me.ComboBoxRedovi.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(20, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 14)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Поља са грешкама: (више изабраних се везује са или)"
        '
        'NumericUpDownPrvihRedova
        '
        Me.NumericUpDownPrvihRedova.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumericUpDownPrvihRedova.Location = New System.Drawing.Point(499, 14)
        Me.NumericUpDownPrvihRedova.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDownPrvihRedova.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownPrvihRedova.Name = "NumericUpDownPrvihRedova"
        Me.NumericUpDownPrvihRedova.Size = New System.Drawing.Size(91, 22)
        Me.NumericUpDownPrvihRedova.TabIndex = 42
        Me.NumericUpDownPrvihRedova.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(597, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 14)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "слогова (макс. 1000)"
        '
        'CheckBoxPrvihRedova
        '
        Me.CheckBoxPrvihRedova.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBoxPrvihRedova.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBoxPrvihRedova.Location = New System.Drawing.Point(422, 14)
        Me.CheckBoxPrvihRedova.Name = "CheckBoxPrvihRedova"
        Me.CheckBoxPrvihRedova.Size = New System.Drawing.Size(71, 19)
        Me.CheckBoxPrvihRedova.TabIndex = 44
        Me.CheckBoxPrvihRedova.Text = "првих:"
        '
        'ButtonRejectChangesPrimaryKey
        '
        Me.ButtonRejectChangesPrimaryKey.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRejectChangesPrimaryKey.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRejectChangesPrimaryKey.FlatAppearance.BorderSize = 0
        Me.ButtonRejectChangesPrimaryKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRejectChangesPrimaryKey.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonRejectChangesPrimaryKey.Image = CType(resources.GetObject("ButtonRejectChangesPrimaryKey.Image"), System.Drawing.Image)
        Me.ButtonRejectChangesPrimaryKey.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRejectChangesPrimaryKey.Location = New System.Drawing.Point(812, 44)
        Me.ButtonRejectChangesPrimaryKey.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonRejectChangesPrimaryKey.Name = "ButtonRejectChangesPrimaryKey"
        Me.ButtonRejectChangesPrimaryKey.Size = New System.Drawing.Size(25, 25)
        Me.ButtonRejectChangesPrimaryKey.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.ButtonRejectChangesPrimaryKey, "Undo")
        Me.ButtonRejectChangesPrimaryKey.UseVisualStyleBackColor = False
        '
        'ButtonRejectChangesErrorColumns
        '
        Me.ButtonRejectChangesErrorColumns.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRejectChangesErrorColumns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRejectChangesErrorColumns.FlatAppearance.BorderSize = 0
        Me.ButtonRejectChangesErrorColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRejectChangesErrorColumns.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonRejectChangesErrorColumns.Image = CType(resources.GetObject("ButtonRejectChangesErrorColumns.Image"), System.Drawing.Image)
        Me.ButtonRejectChangesErrorColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRejectChangesErrorColumns.Location = New System.Drawing.Point(812, 169)
        Me.ButtonRejectChangesErrorColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonRejectChangesErrorColumns.Name = "ButtonRejectChangesErrorColumns"
        Me.ButtonRejectChangesErrorColumns.Size = New System.Drawing.Size(25, 25)
        Me.ButtonRejectChangesErrorColumns.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.ButtonRejectChangesErrorColumns, "Undo")
        Me.ButtonRejectChangesErrorColumns.UseVisualStyleBackColor = False
        '
        'ButtonRejectChangesUpdatableColumns
        '
        Me.ButtonRejectChangesUpdatableColumns.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRejectChangesUpdatableColumns.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRejectChangesUpdatableColumns.FlatAppearance.BorderSize = 0
        Me.ButtonRejectChangesUpdatableColumns.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRejectChangesUpdatableColumns.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonRejectChangesUpdatableColumns.Image = CType(resources.GetObject("ButtonRejectChangesUpdatableColumns.Image"), System.Drawing.Image)
        Me.ButtonRejectChangesUpdatableColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonRejectChangesUpdatableColumns.Location = New System.Drawing.Point(812, 291)
        Me.ButtonRejectChangesUpdatableColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonRejectChangesUpdatableColumns.Name = "ButtonRejectChangesUpdatableColumns"
        Me.ButtonRejectChangesUpdatableColumns.Size = New System.Drawing.Size(25, 25)
        Me.ButtonRejectChangesUpdatableColumns.TabIndex = 47
        Me.ToolTip1.SetToolTip(Me.ButtonRejectChangesUpdatableColumns, "Undo")
        Me.ButtonRejectChangesUpdatableColumns.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageIzbor1)
        Me.TabControl1.Controls.Add(Me.TabPageSQL)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(897, 649)
        Me.TabControl1.TabIndex = 48
        '
        'TabPageIzbor1
        '
        Me.TabPageIzbor1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPageIzbor1.Controls.Add(Me.Panel2)
        Me.TabPageIzbor1.Controls.Add(Me.tv)
        Me.TabPageIzbor1.Location = New System.Drawing.Point(4, 23)
        Me.TabPageIzbor1.Name = "TabPageIzbor1"
        Me.TabPageIzbor1.Size = New System.Drawing.Size(889, 622)
        Me.TabPageIzbor1.TabIndex = 0
        Me.TabPageIzbor1.Text = "Избор 1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.ButtonRejectChangesUpdatableColumns)
        Me.Panel2.Controls.Add(Me.dgvUpdatableColumns)
        Me.Panel2.Controls.Add(Me.ButtonRejectChangesErrorColumns)
        Me.Panel2.Controls.Add(Me.dgvErrorColumns)
        Me.Panel2.Controls.Add(Me.ButtonRejectChangesPrimaryKey)
        Me.Panel2.Controls.Add(Me.dgvPrimaryKey)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.CheckBoxPrvihRedova)
        Me.Panel2.Controls.Add(Me.cmbTezinaGreske)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.NumericUpDownPrvihRedova)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ComboBoxRedovi)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 289)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(889, 333)
        Me.Panel2.TabIndex = 10000087
        Me.Panel2.Visible = False
        '
        'dgvUpdatableColumns
        '
        Me.dgvUpdatableColumns.AllowUserToAddRows = False
        Me.dgvUpdatableColumns.AllowUserToDeleteRows = False
        Me.dgvUpdatableColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUpdatableColumns.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvUpdatableColumns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUpdatableColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUpdatableColumns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvUpdatableColumns.Location = New System.Drawing.Point(23, 319)
        Me.dgvUpdatableColumns.MultiSelect = False
        Me.dgvUpdatableColumns.Name = "dgvUpdatableColumns"
        Me.dgvUpdatableColumns.Size = New System.Drawing.Size(813, 90)
        Me.dgvUpdatableColumns.TabIndex = 10000057
        Me.dgvUpdatableColumns.TabStop = False
        '
        'dgvErrorColumns
        '
        Me.dgvErrorColumns.AllowUserToAddRows = False
        Me.dgvErrorColumns.AllowUserToDeleteRows = False
        Me.dgvErrorColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvErrorColumns.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvErrorColumns.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvErrorColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvErrorColumns.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvErrorColumns.Location = New System.Drawing.Point(23, 198)
        Me.dgvErrorColumns.MultiSelect = False
        Me.dgvErrorColumns.Name = "dgvErrorColumns"
        Me.dgvErrorColumns.Size = New System.Drawing.Size(813, 90)
        Me.dgvErrorColumns.TabIndex = 10000056
        Me.dgvErrorColumns.TabStop = False
        '
        'dgvPrimaryKey
        '
        Me.dgvPrimaryKey.AllowUserToAddRows = False
        Me.dgvPrimaryKey.AllowUserToDeleteRows = False
        Me.dgvPrimaryKey.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPrimaryKey.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvPrimaryKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPrimaryKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrimaryKey.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvPrimaryKey.Location = New System.Drawing.Point(23, 72)
        Me.dgvPrimaryKey.MultiSelect = False
        Me.dgvPrimaryKey.Name = "dgvPrimaryKey"
        Me.dgvPrimaryKey.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dgvPrimaryKey.Size = New System.Drawing.Size(813, 90)
        Me.dgvPrimaryKey.TabIndex = 10000055
        Me.dgvPrimaryKey.TabStop = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(415, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(243, 20)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Бирање по тежини"
        '
        'cmbTezinaGreske
        '
        Me.cmbTezinaGreske.Items.AddRange(New Object() {"T", "L"})
        Me.cmbTezinaGreske.Location = New System.Drawing.Point(664, 173)
        Me.cmbTezinaGreske.Name = "cmbTezinaGreske"
        Me.cmbTezinaGreske.Size = New System.Drawing.Size(40, 22)
        Me.cmbTezinaGreske.TabIndex = 49
        '
        'tv
        '
        Me.tv.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tv.Dock = System.Windows.Forms.DockStyle.Top
        Me.tv.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tv.ItemHeight = 25
        Me.tv.LineColor = System.Drawing.Color.DarkOrange
        Me.tv.Location = New System.Drawing.Point(0, 0)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(889, 289)
        Me.tv.TabIndex = 10000086
        '
        'TabPageSQL
        '
        Me.TabPageSQL.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPageSQL.Controls.Add(Me.TextBoxSQL)
        Me.TabPageSQL.Controls.Add(Me.Label5)
        Me.TabPageSQL.Location = New System.Drawing.Point(4, 23)
        Me.TabPageSQL.Name = "TabPageSQL"
        Me.TabPageSQL.Size = New System.Drawing.Size(889, 622)
        Me.TabPageSQL.TabIndex = 1
        Me.TabPageSQL.Text = "SQL"
        '
        'TextBoxSQL
        '
        Me.TextBoxSQL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSQL.Location = New System.Drawing.Point(14, 32)
        Me.TextBoxSQL.Multiline = True
        Me.TextBoxSQL.Name = "TextBoxSQL"
        Me.TextBoxSQL.Size = New System.Drawing.Size(812, 547)
        Me.TextBoxSQL.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Unesite dodatni izraz u SQL WHERE klauzuli:"
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.meText)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(899, 40)
        Me.PanelTop.TabIndex = 142
        '
        'meText
        '
        Me.meText.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.meText.BackColor = System.Drawing.Color.Transparent
        Me.meText.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.meText.ForeColor = System.Drawing.Color.DarkOrange
        Me.meText.Location = New System.Drawing.Point(6, 0)
        Me.meText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.meText.Name = "meText"
        Me.meText.Size = New System.Drawing.Size(348, 40)
        Me.meText.TabIndex = 63
        Me.meText.Tag = "nediraj"
        Me.meText.Text = "text"
        Me.meText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnCerrar.Location = New System.Drawing.Point(854, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 60
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Logovan
        '
        Me.Logovan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(638, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelContext
        '
        Me.PanelContext.BackColor = System.Drawing.Color.Transparent
        Me.PanelContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContext.Controls.Add(Me.TabControl1)
        Me.PanelContext.Controls.Add(Me.PanelBottom)
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(0, 40)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(899, 709)
        Me.PanelContext.TabIndex = 144
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.bok)
        Me.PanelBottom.Controls.Add(Me.bc)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 649)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(897, 58)
        Me.PanelBottom.TabIndex = 49
        '
        'bok
        '
        Me.bok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bok.BackColor = System.Drawing.Color.Gainsboro
        Me.bok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bok.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bok.ImageIndex = 0
        Me.bok.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bok.Location = New System.Drawing.Point(248, 17)
        Me.bok.Name = "bok"
        Me.bok.Size = New System.Drawing.Size(153, 24)
        Me.bok.TabIndex = 11
        Me.bok.Text = "Потврди"
        Me.bok.UseVisualStyleBackColor = False
        '
        'bc
        '
        Me.bc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bc.BackColor = System.Drawing.Color.Gainsboro
        Me.bc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bc.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bc.Location = New System.Drawing.Point(495, 17)
        Me.bc.Name = "bc"
        Me.bc.Size = New System.Drawing.Size(153, 24)
        Me.bc.TabIndex = 8
        Me.bc.Text = "Одустани"
        Me.bc.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 100
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 20
        '
        'FormAzurirajFilterRows
        '
        Me.AcceptButton = Me.ButtonOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(899, 749)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.PanelTop)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAzurirajFilterRows"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownPrvihRedova, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageIzbor1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvUpdatableColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvErrorColumns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPrimaryKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSQL.ResumeLayout(False)
        Me.TabPageSQL.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelContext.ResumeLayout(False)
        Me.PanelBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage22(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        ReleaseCapture()
        SendMessage22(Me.Handle, &H112&, &HF012&, 0)
    End Sub
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
    Public mj As String
    Public mn As String

    Public jezik As String
    Dim svi As String
    Dim neispravni As String
    Dim ispravni As String
    Dim selectedindexchange As Integer = 0
    Dim niz_TColInfo() As TcolInfo
    Dim niz_dgv() As DataGridView
    Dim sveTabele() As String
    Dim sveTabeleSAPFX() As String
    Dim vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Public indikator As Integer
    Public izabranatabela As String
    Dim redoviMEMG() As DataRow
    Dim redoviMEM() As DataRow
    Dim redoviMEMD() As DataRow
    Dim redoviMEMAK() As DataRow
    Dim brojNodova As Integer = 0
    Dim onlyTableDescription As Boolean = False
    Dim mdtLabel As DataTable
    Dim txtmode As String

    Public Sub New(ByVal ds As DatasetIstrazivanja, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal niz_dgv() As DataGridView, ByVal niz_TColInfo() As TcolInfo,
                   ByVal sveTabele() As String, ByVal sveTabeleSAPFX() As String, ByVal txtpismo As String, ByVal jezik As String,
                   ByVal GlavneIliPomocne As String, ByVal txtmode As String, ByVal mdtLabel As DataTable, ByVal pomind As Integer)
        Me.New()

        DD = 899 'Me.ClientSize.Width
        VV = 849 'Me.ClientSize.Height

        Me.jezik = jezik
        Me.niz_TColInfo = niz_TColInfo
        Me.niz_dgv = niz_dgv
        Me.sveTabele = sveTabele
        Me.sveTabeleSAPFX = sveTabeleSAPFX
        Me.vt = vt
        Me.txtmode = txtmode
        Me.mdtLabel = mdtLabel
        'meText.Text = tidt.Prefix + "." + tidt.TableName
        Call SetLang()
        Me.Logovan.Text = GetUserName.ToString.Trim
        Me.mj = "1"
        Me.mn = "0"

        Dim tOpis As String = ""
        Dim pomocne As Boolean = True
        If GlavneIliPomocne Is Nothing Then pomocne = False
        onlyTableDescription = False
        If Not (ds.IST.Rows(0).Item("ABAZA") Is System.DBNull.Value) AndAlso ds.IST.Rows(0).Item("ABAZA").ToString.Trim.ToUpper.IndexOf("ONLYTABLEDESCRIPTION") >= 0 Then
            onlyTableDescription = True
        End If

        redoviMEMG = ds.ISTTABELE.Select("isnull(DG,'G')='G' and isnull(baza,'')<>'0'", "baza ASC")
        redoviMEMD = ds.ISTTABELE.Select("isnull(DG,'G')='D'  and isnull(baza,'')<>'0'", "baza ASC")
        redoviMEMAK = ds.ISTTABELE.Select("(isnull(DG,'G')='A' or isnull(DG,'G')='K') and isnull(baza,'')<>'0'", "baza ASC")
        tv.Nodes.Clear()
        Dim nnode As TreeNode
        Dim red As DatasetIstrazivanja.ISTTABELERow
        brojNodova = 0
        If pomocne = False Then
            For r1 As Integer = 0 To redoviMEMG.GetUpperBound(0)
                red = redoviMEMG(r1)
                Dim rtTabela As String = red.Tabela
                'dodam glavnu
                nnode = tv.Nodes.Add(dajOpis(red))
                nnode.Tag = rtTabela
                brojNodova = brojNodova + 1
                podtabela(rtTabela, redoviMEMD, 1, nnode)
            Next
        End If
        'ISTMessageBox.Show(brojNodova.ToString)

        tv.ExpandAll()

        If pomocne = True Then
            For r1 As Integer = 0 To redoviMEMAK.GetUpperBound(0)
                red = redoviMEMAK(r1)
                Dim rtTabela As String = red.Tabela
                'dodam glavnu
                nnode = tv.Nodes.Add(dajOpis(red))
                nnode.Tag = rtTabela
                brojNodova = brojNodova + 1
                podtabela(rtTabela, redoviMEMD, 1, Nothing)
            Next
        End If

        Me.ComboBoxRedovi.Items.Add(neispravni)
        Me.ComboBoxRedovi.Items.Add(ispravni)
        Me.ComboBoxRedovi.Items.Add(svi)
        Me.ComboBoxRedovi.SelectedIndex = 0

        If brojNodova > 0 Then

            If pomind = -1 Then
                Call bppclick1(Me.tv.Nodes(0))
                If brojNodova > 1 Then
                    Call fontRegularSelectedNode(tv)
                    Panel2.Visible = False
                Else
                    Panel2.Visible = True
                End If
            Else
                'prepisi
                Dim nn As TreeNode = SearchTheTreeView(tv, sveTabele(pomind).Trim.ToUpper)
                Call bppclick1(nn)
                Call dodaj(pomind)
                Panel2.Visible = True
            End If

        Else
            ''msg 228
            Dim msgtxt228 As String = getMessageText(dtMessages, "228", Me.jezik)
            ''msg 229
            Dim msgtxt229 As String = getMessageText(dtMessages, "229", Me.jezik)
            ISTMessageBox.Show(msgtxt228, msgtxt229, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub


    Sub dodaj(ByVal pomind As Integer)
        'Try
        If Not FormAzuriraj.niz_frsCheckBoxPrvihRedova Is Nothing Then
            Me.CheckBoxPrvihRedova.Checked = FormAzuriraj.niz_frsCheckBoxPrvihRedova(pomind)
        End If
        If Not FormAzuriraj.niz_frsNumericUpDownPrvihRedovaValue Is Nothing AndAlso Not FormAzuriraj.niz_frsNumericUpDownPrvihRedovaValue(pomind) = 0 Then
            Me.NumericUpDownPrvihRedova.Value = FormAzuriraj.niz_frsNumericUpDownPrvihRedovaValue(pomind)
        End If
        'Catch ex As Exception

        'End Try

        If Not FormAzuriraj.niz_frscmbTezinaGreskeSelectedItem Is Nothing AndAlso Not FormAzuriraj.niz_frscmbTezinaGreskeSelectedItem(pomind) Is Nothing Then
            Me.cmbTezinaGreske.SelectedItem = FormAzuriraj.niz_frscmbTezinaGreskeSelectedItem(pomind)
        End If
        If Not FormAzuriraj.niz_frsComboBoxRedoviSelectedItem Is Nothing AndAlso Not FormAzuriraj.niz_frsComboBoxRedoviSelectedItem(pomind) Is Nothing Then
            Me.ComboBoxRedovi.SelectedItem = FormAzuriraj.niz_frsComboBoxRedoviSelectedItem(pomind)
        End If

        If Not FormAzuriraj.niz_pk Is Nothing AndAlso Not FormAzuriraj.niz_pk(pomind) Is Nothing Then
            Me.dgvPrimaryKey.DataSource.Rows(0).Delete()
            Me.dgvPrimaryKey.DataSource.ImportRow(FormAzuriraj.niz_pk(pomind))
            Me.dgvPrimaryKey.DataSource.AcceptChanges()
        End If

        If Not FormAzuriraj.niz_gr Is Nothing AndAlso Not FormAzuriraj.niz_gr(pomind) Is Nothing Then
            Me.dgvErrorColumns.DataSource.Rows(0).Delete()
            Me.dgvErrorColumns.DataSource.ImportRow(FormAzuriraj.niz_gr(pomind))
            Me.dgvErrorColumns.DataSource.AcceptChanges()

        End If
        If Not FormAzuriraj.niz_kol Is Nothing AndAlso Not FormAzuriraj.niz_kol(pomind) Is Nothing Then
            Me.dgvUpdatableColumns.DataSource.Rows(0).Delete()
            Me.dgvUpdatableColumns.DataSource.ImportRow(FormAzuriraj.niz_kol(pomind))
            Me.dgvUpdatableColumns.DataSource.AcceptChanges()
        End If
    End Sub

    Sub podtabela(ByVal rtTabela As String, ByVal redoviMEMD() As DataRow, ByVal nivo As Integer, Optional ByVal no As TreeNode = Nothing)
        For r As Integer = 0 To redoviMEMD.GetUpperBound(0)
            Dim rt As DatasetIstrazivanja.ISTTABELERow
            rt = redoviMEMD(r)
            If rt.IsNadTabelaNull = False AndAlso rt.NadTabela.Trim.ToUpper = rtTabela.Trim.ToUpper Then
                Dim nnode2 As TreeNode
                nnode2 = no.Nodes.Add(dajOpis(rt))
                nnode2.Tag = rt.Tabela
                brojNodova = brojNodova + 1
                Call podtabela(rt.Tabela, redoviMEMD, nivo + 1, nnode2)
            End If
        Next
    End Sub
    Sub tvNodeMouseDoubleClick(ByVal mySelectedNode As TreeNode)
        tv.ExpandAll()
        Call bppclick1(mySelectedNode)
    End Sub

    Sub bppclick1(ByVal nnode As TreeNode, Optional ByVal lk As Boolean = False)

        If Me.tv.Nodes.Count = 0 Then
            Return
        Else

            Dim tt() As String = ttTtt(nnode)
            Dim nadnadtabela As String = tt(0)
            izabranatabela = nnode.Tag.Trim.ToUpper
            If izabranatabela.IndexOf(".") < 0 Then izabranatabela = "DBO." + izabranatabela
            Dim tabela As String = izabranatabela.Trim.ToUpper

            Dim ppp As String = CStr(tabela)
            If ppp.IndexOf("DBO.") = 0 Then
                Dim dd() As String = ppp.Split(".")
                tabela = dd(0)
                If dd.Length > 0 Then tabela = dd(1)
            End If

            Call sselectedindexchange(tabela)
            Call fontRegularSelectedNode(tv)
            tv.SelectedNode = nnode
            tv.SelectedNode.NodeFont = New Font(tv.Font, FontStyle.Bold)

            Panel2.Visible = True
        End If
    End Sub


    Private Sub tv_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tv.NodeMouseClick

        Dim ClickPoint As Point = New Point(e.X, e.Y)
        Dim ClickNode As TreeNode = tv.GetNodeAt(ClickPoint)
        If ClickNode Is Nothing Then Return
        tv.SelectedNode = e.Node
        Dim mySelectedNode As TreeNode
        mySelectedNode = tv.SelectedNode
        Me.Cursor = Cursors.WaitCursor
        Call tvNodeMouseDoubleClick(mySelectedNode)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tv_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles tv.NodeMouseDoubleClick

        Dim mySelectedNode As TreeNode
        mySelectedNode = tv.SelectedNode
        If Not mySelectedNode Is Nothing Then
            If e.Button = MouseButtons.Left Then
                Call tvNodeMouseDoubleClick(mySelectedNode)
            End If
        End If
    End Sub
    Function dajOpis(ByVal rt As DatasetIstrazivanja.ISTTABELERow) As String

        Dim rtTabela As String = rt.Tabela.Trim
        Dim topis As String = rt.Tabela.Trim
        Dim sropis As String = ""
        If rt.IsOpisNull OrElse rt.Opis.Trim = "" Then
        Else
            sropis = sredjenOpis(rt.Opis)
        End If

        If rt.IsOpisNull OrElse rt.Opis.Trim = "" Then
            'topis
        ElseIf rt.Opis.Trim.IndexOf("$") < 0 AndAlso onlyTableDescription = False Then
            If sropis <> "" Then topis = topis + "-" + sropis
        Else
            If sropis <> "" Then topis = sropis
        End If

        Dim MLopis As String = getMultilanguageLabel(mdtLabel, txtmode, rt.Tabela.Trim, "", "td", Me.jezik)
        If MLopis <> "" Then topis = MLopis
        dajOpis = topis + "                 "

    End Function
    Private Sub sselectedindexchange(ByVal tabela As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim ind As Integer = -1
        If tabela.IndexOf(".") > 0 Then
            ind = Array.IndexOf(sveTabeleSAPFX, tabela)
        Else
            ind = Array.IndexOf(sveTabele, tabela)
        End If

        indikator = ind

        Dim t2 As New System.Data.DataTable
        Me.Grid2(niz_TColInfo(ind).dt.PrimaryKey, t2, vt)
        t2.DefaultView.AllowNew = False
        t2.DefaultView.AllowDelete = False
        Me.dgvPrimaryKey.DataSource = t2

        Dim t3 As New System.Data.DataTable
        Me.Grid2(niz_TColInfo(ind).ucol, t3, vt)
        t3.DefaultView.AllowDelete = False
        t3.DefaultView.AllowNew = False
        dgvUpdatableColumns.DataSource = t3

        Dim tec As New System.Data.DataTable
        Me.Grid2(niz_TColInfo(ind).ecol, tec, vt)
        tec.DefaultView.AllowDelete = False
        tec.DefaultView.AllowNew = False
        Me.dgvErrorColumns.DataSource = tec
        NapuniCmbTezinaGreske(tec)

        Call srediGridView(dgvPrimaryKey, True, 50, 30,,,,, 1)
        Call srediGridView(dgvErrorColumns, True, 50, 30,,,,, 1)

        For Each col As DataGridViewColumn In dgvErrorColumns.Columns
            If TypeOf col Is DataGridViewCheckBoxColumn Then
                CType(col, DataGridViewCheckBoxColumn).FlatStyle = FlatStyle.Popup
            End If
        Next
        Call srediGridView(dgvUpdatableColumns, True, 50,,,,,, 1)
        For Each col As DataGridViewColumn In dgvUpdatableColumns.Columns
            If TypeOf col Is DataGridViewCheckBoxColumn Then
                CType(col, DataGridViewCheckBoxColumn).FlatStyle = FlatStyle.Popup
            End If
        Next

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub Grid2(ByVal cs() As System.Data.DataColumn, ByVal t As System.Data.DataTable, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka)
        Dim c As System.Data.DataColumn
        Dim vs() As Object = {}
        For Each c In cs
            If c.ColumnName.Trim <> "INDGR" Then
                Dim col2 As New System.Data.DataColumn(c.ColumnName, c.DataType)
                If Not c.ExtendedProperties Is Nothing Then
                    For Each k As Object In c.ExtendedProperties.Keys
                        col2.ExtendedProperties.Add(k, c.ExtendedProperties.Item(k))
                    Next
                End If
                t.Columns.Add(col2)
                Dim val As Object = System.DBNull.Value
                If c.DataType Is GetType(Boolean) Then
                    c.AllowDBNull = False
                    val = False
                End If
                If c.ColumnName.Trim.ToUpper = "GOD" OrElse c.ColumnName.Trim.ToUpper = "ISTYEAR" Then
                    val = vt.G.ToString
                    col2.DefaultValue = val
                    col2.ReadOnly = True
                ElseIf c.ColumnName.Trim.ToUpper = "MES" OrElse c.ColumnName.Trim.ToUpper = "ISTMONTH" Then
                    val = String.Format("{0:d2}", vt.M)
                    col2.DefaultValue = val
                    col2.ReadOnly = True
                End If
                ReDim Preserve vs(1 + vs.GetUpperBound(0))
                vs(vs.GetUpperBound(0)) = val
            End If
        Next

        t.Rows.Add(vs)
        t.AcceptChanges()
    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formAzurirajFilterRows")
        Label4.Text = getControlText2(dt, "Label4", Me.jezik)
        Label4.Text = getControlText2(dt, "Label4", Me.jezik)
        Label3.Text = getControlText2(dt, "Label3", Me.jezik)
        Label2.Text = getControlText2(dt, "Label2", Me.jezik)
        Label1.Text = getControlText2(dt, "Label1", Me.jezik)
        Label6.Text = getControlText2(dt, "Label6", Me.jezik)
        CheckBoxPrvihRedova.Text = getControlText2(dt, "CheckBoxPrvihRedova", Me.jezik)

        TabPageIzbor1.Text = getControlText2(dt, "TabPageIzbor1", Me.jezik)
        Label7.Text = getControlText2(dt, "Label7", Me.jezik)
        Label5.Text = getControlText2(dt, "Label5", Me.jezik)

        svi = getControlText2(dt, "ComboBoxRedovi1", Me.jezik)
        neispravni = getControlText2(dt, "ComboBoxRedovi2", Me.jezik)
        ispravni = getControlText2(dt, "ComboBoxRedovi3", Me.jezik)

        Dim dt2 As System.Data.DataTable = getDTVBText(dtLang, "formAzuriraj")
        meText.Text = getControlText2(dt2, "ButtonAIzborSlogova", Me.jezik)
    End Sub



    Private Function Row2(ByVal r As System.Data.DataRow, ByVal b2 As Boolean) As String
        Dim rf As String = ""
        Dim col As System.Data.DataColumn
        For Each col In r.Table.Columns
            If Not r.IsNull(col.ColumnName) AndAlso col.ColumnName.Trim.ToUpper <> "INDGR" Then
                Dim b As Boolean
                If col.DataType Is b.GetType Then
                    If CBool(r.Item(col.ColumnName)) Then
                        If rf <> "" Then
                            If b2 Then
                                rf = rf + " and "
                            Else
                                rf = rf + " or "
                            End If
                        End If
                        rf = rf + "d." & col.ColumnName.Trim + "=" + Me.mj
                    End If
                ElseIf CStr(r.Item(col.ColumnName)).Trim <> "" Then
                    If rf <> "" Then
                        If b2 Then
                            rf = rf + " and "
                        Else
                            rf = rf + " or "
                        End If
                    End If
                    rf = rf + Kolona_get(r, col, False)
                End If
            End If
        Next
        If rf <> "" Then rf = "(" + rf + ")"
        Return rf
    End Function

    Private Function Row2Nadtabela(ByVal r As DataRow, ByVal b2 As Boolean, ByVal dt As DataTable) As String
        Dim col As DataColumn
        Dim colArray As String = ""
        For Each col In dt.Columns
            colArray = colArray & "$" & col.ColumnName.Trim.ToUpper
        Next
        colArray = colArray & "$"
        Dim rf As String = ""

        For Each col In r.Table.Columns
            If colArray.IndexOf("$" + col.ColumnName.Trim.ToUpper + "$") >= 0 Then
                If Not r.IsNull(col.ColumnName) AndAlso col.ColumnName.Trim.ToUpper <> "INDGR" Then
                    Dim b As Boolean
                    If col.DataType Is b.GetType Then
                        If CBool(r.Item(col.ColumnName)) Then
                            If rf <> "" Then
                                If b2 Then
                                    rf = rf + " and "
                                Else
                                    rf = rf + " or "
                                End If
                            End If
                            rf = rf + "M." & col.ColumnName.Trim + "=" + Me.mj
                        End If
                    ElseIf CStr(r.Item(col.ColumnName)).Trim <> "" Then
                        If rf <> "" Then
                            If b2 Then
                                rf = rf + " and "
                            Else
                                rf = rf + " or "
                            End If
                        End If
                        rf = rf + Kolona_get(r, col, False, "M.")
                    End If
                End If
            End If

        Next
        If rf <> "" Then rf = "(" + rf + ")"
        Return rf
    End Function

    Public Shared Function Kolona_get(ByVal r As System.Data.DataRow, ByVal c As System.Data.DataColumn, ByVal b As Boolean, Optional prefix As String = "D.") As String

        Dim sql As String = ""
        Dim pom As String = ""
        If Not c.ExtendedProperties.ContainsKey("Izraz") Then
            sql = prefix & c.ColumnName
        Else
            pom = CStr(c.ExtendedProperties.Item("Izraz")).Trim
            sql = Replace(pom, "MULTILINE", "", 1, , CompareMethod.Text)
            Dim ss() As String = sql.Split("#")
            If ss.Length > 1 Then sql = "#" + ss(1)
            If sql <> "" Then
                sql = Replace(sql, "#{", "")
                If sql.ToString.ToUpper.Trim.IndexOf("SELECT") >= 0 AndAlso sql.ToString.ToUpper.Trim.IndexOf("FROM") < 0 Then
                    'ima select bez from-a npr  #{select d.SO}
                    sql = sql.ToString.ToUpper.Replace("SELECT", "")
                End If
                If sql.EndsWith("}") Then sql = sql.Substring(0, Len(sql) - 1)
                If sql.IndexOf(":") >= 0 Then sql = sql.Substring(0, sql.IndexOf(":"))
                ' GAVG i ostale f-je
                Dim mrt As New PrevediAzur
                sql = mrt.PrevediF(sql)
                sql = " (" & sql & ")"
            Else
                sql = prefix & c.ColumnName
            End If
        End If
        If r.IsNull(c.Ordinal) Then
            If b Then
                sql = sql + "="
            Else
                sql = sql + " is "
            End If
            sql = sql + "null"
        Else
            Dim val As Object = r.ItemArray(c.Ordinal)
            If c.DataType Is GetType(String) Then
                If c.Caption.Trim.ToUpper = "GOD" OrElse c.Caption.Trim.ToUpper = "MES" OrElse c.Caption.Trim.ToUpper = "ISTYEAR" OrElse c.Caption.Trim.ToUpper = "ISTMONTH" Then
                    sql = sql + " = " + "'" + CStr(val) + "'"
                Else
                    'prepoznaj da je IZRAZ
                    'sql = d.ri
                    Dim kolona As String = sql

                    If sql.ToString.ToUpper.Trim.IndexOf("SELECT") >= 0 AndAlso sql.ToString.ToUpper.Trim.IndexOf("FROM") > 0 Then
                        Dim jesteizraz As Boolean = False
                        Dim izraz As String = CStr(val)

                        If izraz.IndexOf(">=") > -1 Then
                            jesteizraz = True
                            izraz = izraz.Replace(">=", kolona + ">=")
                        End If
                        If izraz.IndexOf("<=") > -1 Then
                            jesteizraz = True
                            izraz = izraz.Replace("<=", kolona + "<=")
                        End If
                        If izraz.IndexOf("<>") > -1 Then
                            jesteizraz = True
                            izraz = izraz.Replace("<>", kolona + "<>")
                        End If
                        If izraz.IndexOf("<") > -1 And izraz.IndexOf(kolona + "<") < 0 Then
                            jesteizraz = True
                            izraz = izraz.Replace("<", kolona + "<")
                        End If
                        If izraz.IndexOf(">") > -1 And izraz.IndexOf(kolona + ">") < 0 Then
                            jesteizraz = True
                            izraz = izraz.Replace(">", kolona + ">")
                        End If
                        If izraz.IndexOf("=") > -1 And izraz.IndexOf(kolona + ">=") < 0 And izraz.IndexOf(kolona + "<=") < 0 Then
                            jesteizraz = True
                            izraz = izraz.Replace("=", kolona + "=")
                        End If

                        If jesteizraz = True Then
                            sql = ""
                            sql = "(" + izraz + ")"
                        Else
                            sql = sql + " like " + "N'%" + CStr(val) + "%'"
                        End If
                    Else
                        kolona = kolona.Replace("(", "")
                        kolona = kolona.Replace(")", "")
                        Dim jesteizraz As Boolean = False
                        Dim izraz As String = CStr(val)
                        If izraz.IndexOf(">=") > -1 Then
                            jesteizraz = True
                            izraz = izraz.Replace(">=", kolona + ">=")
                        End If
                        If izraz.IndexOf("<=") > -1 Then
                            jesteizraz = True
                            izraz = izraz.Replace("<=", kolona + "<=")
                        End If
                        If izraz.IndexOf("<>") > -1 Then
                            jesteizraz = True
                            izraz = izraz.Replace("<>", kolona + "<>")
                        End If
                        If izraz.IndexOf("<") > -1 And izraz.IndexOf(kolona + "<") < 0 Then
                            jesteizraz = True
                            izraz = izraz.Replace("<", kolona + "<")
                        End If
                        If izraz.IndexOf(">") > -1 And izraz.IndexOf(kolona + ">") < 0 Then
                            jesteizraz = True
                            izraz = izraz.Replace(">", kolona + ">")
                        End If
                        If izraz.IndexOf("=") > -1 And izraz.IndexOf(kolona + ">=") < 0 And izraz.IndexOf(kolona + "<=") < 0 Then
                            jesteizraz = True
                            izraz = izraz.Replace("=", kolona + "=")
                        End If

                        If jesteizraz = True Then
                            sql = ""
                            sql = "(" + izraz + ")"
                        Else
                            sql = sql + " like " + "N'%" + CStr(val) + "%'"
                        End If
                    End If

                End If
            ElseIf c.DataType Is GetType(Boolean) Then
                If CBool(val) Then
                    sql = sql + " like " + "1"
                Else
                    sql = sql + " like " + "0"
                End If
            ElseIf c.DataType Is GetType(Decimal) Then
                sql = sql + " = " + CStr(CDec(val)).Trim
            ElseIf c.DataType Is GetType(Integer) Then
                sql = sql + " = " + CStr(CInt(val)).Trim
            Else
                sql = sql + " like " + CStr(val)
            End If
        End If
        Return sql
    End Function
    Public Function Get_Frowcol(ByVal dt As DataTable) As String

        Dim f As String = "2=2"
        Dim f2 As String = ""
        f2 = Me.Row2(dt.Rows(0), True)
        If f2 <> "" AndAlso f <> "" Then f = f + " and " + f2

        Return f
    End Function
    Public Function Get_rowcol() As String
        Dim t As System.Data.DataTable
        t = CType(Me.dgvPrimaryKey.DataSource, System.Data.DataTable)
        Dim f As String = ""
        f = Me.Row2(t.Rows(0), True)

        If f = "" Then f = "2=2"  'znaci nema ni god ni mes

        t = CType(Me.dgvUpdatableColumns.DataSource, System.Data.DataTable)
        Dim f2 As String = ""
        f2 = Me.Row2(t.Rows(0), True)
        If f2 <> "" AndAlso f <> "" Then f = f + " and " + f2

        t = CType(Me.dgvErrorColumns.DataSource, System.Data.DataTable)
        Dim f3 As String = ""
        f3 = Me.Row2(t.Rows(0), False)
        If f3 <> "" AndAlso f <> "" Then f = f + " and " + f3

        Select Case Me.ComboBoxRedovi.SelectedIndex
            Case 0   'neispravni
                If f <> "" Then f = f + " and " + "d.INDGR" + "=" + Me.mj
            Case 1 'ispravni
                If f <> "" Then f = f + " and " + "d.INDGR=" + Me.mn
        End Select

        If Me.TextBoxSQL.Text.Trim <> "" AndAlso f <> "" Then f = f + " and " + Me.TextBoxSQL.Text.Trim

        Return f

    End Function

    Public Function Get_rowcolWithError(ByVal errNumber As String) As String
        Dim f As String = ""
        If f = "" Then f = f + " d.INDGR" + "= 1"
        If errNumber <> "" Then f = f + " and d." + errNumber + "= 1"
        Return f
    End Function

    Public Function Get_rowcolNadtabela(ByVal dt As DataTable) As String
        'samo kljuc nadtabele NE podtabele
        Dim t As DataTable
        t = CType(Me.dgvPrimaryKey.DataSource, DataTable)   'sta pise za PK

        Dim f As String = ""
        'samo vremenska tačka i ono što pripada ključu nadtabele, ostalo NE

        f = Me.Row2Nadtabela(t.Rows(0), True, dt)
        Return f
    End Function

    Private Sub prvi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxPrvihRedova.CheckedChanged
        Me.NumericUpDownPrvihRedova.Enabled = Me.CheckBoxPrvihRedova.Checked
    End Sub

    Private Sub ButtonRejectChangesPrimaryKey_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRejectChangesPrimaryKey.Click
        'kljuc
        Dim t As System.Data.DataTable
        t = CType(Me.dgvPrimaryKey.DataSource, System.Data.DataTable)

        If t.Rows.Count > 1 Then
            t.Rows(1).Delete()
            t.AcceptChanges()
        Else
            If t.Rows(0).RowState = 2 Then 'unchanged
                For i As Integer = 0 To t.Rows(0).ItemArray.Length - 1
                    If TypeOf t.Rows(0).Item(i) Is Boolean Then
                        If t.Rows(0).Table.Columns.Item(i).ReadOnly = False Then t.Rows(0).Item(i) = False
                    Else
                        If t.Rows(0).Table.Columns.Item(i).ReadOnly = False Then t.Rows(0).Item(i) = System.DBNull.Value
                    End If
                Next
                t.AcceptChanges()
            Else
                t.RejectChanges()
            End If
        End If
    End Sub

    Private Sub ButtonRejectChangesErrorColumns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRejectChangesErrorColumns.Click
        'greske
        Dim t As System.Data.DataTable
        t = CType(Me.dgvErrorColumns.DataSource, System.Data.DataTable)
        If t.Rows.Count > 1 Then
            t.Rows(1).Delete()
            t.AcceptChanges()
        Else
            If t.Rows(0).RowState = 2 Then 'unchanged
                For i As Integer = 0 To t.Rows(0).ItemArray.Length - 1
                    If t.Rows(0).Table.Columns.Item(i).ReadOnly = False Then t.Rows(0).Item(i) = False
                Next
                t.AcceptChanges()
            Else
                t.RejectChanges()
            End If
        End If
        ISTMessageBox.Show("OK.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ButtonRejectChangesUpdatableColumns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRejectChangesUpdatableColumns.Click
        'polja
        Dim t As System.Data.DataTable
        t = CType(Me.dgvUpdatableColumns.DataSource, System.Data.DataTable)
        If t.Rows.Count > 1 Then
            t.Rows(1).Delete()
            t.AcceptChanges()
        Else
            If t.Rows(0).RowState = 2 Then 'unchanged
                For i As Integer = 0 To t.Rows(0).ItemArray.Length - 1
                    If TypeOf t.Rows(0).Item(i) Is Boolean Then
                        If t.Rows(0).Table.Columns.Item(i).ReadOnly = False Then t.Rows(0).Item(i) = False
                    Else
                        If t.Rows(0).Table.Columns.Item(i).ReadOnly = False Then t.Rows(0).Item(i) = System.DBNull.Value
                    End If
                Next
                t.AcceptChanges()
            Else
                t.RejectChanges()
            End If
        End If
        ISTMessageBox.Show("OK.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If Me.TabControl1.SelectedTab Is Me.TabPageSQL Then
            If Me.TextBoxSQL.CanFocus Then
                Me.TextBoxSQL.Focus()
            End If
        End If
    End Sub

    Private Sub cmbTezinaGreske_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTezinaGreske.SelectedIndexChanged
        Dim t As System.Data.DataTable = CType(Me.dgvErrorColumns.DataSource, System.Data.DataTable)
        For Each c As System.Data.DataColumn In t.Columns
            If CStr(c.ExtendedProperties("Tezina")) = CStr(cmbTezinaGreske.SelectedItem) Then
                t.Rows(0).Item(c) = True
            End If
        Next
    End Sub

    Private Sub NapuniCmbTezinaGreske(ByVal tec As System.Data.DataTable)
        cmbTezinaGreske.Items.Clear()
        For Each c As System.Data.DataColumn In tec.Columns
            If Not c.ExtendedProperties Is Nothing Then
                For Each k As Object In c.ExtendedProperties.Keys
                    Dim trt As String = CStr(c.ExtendedProperties.Item(k)).Trim
                    If cmbTezinaGreske.Items.IndexOf(trt) < 0 Then
                        cmbTezinaGreske.Items.Add(trt)
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormAzurirajFilterRows_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Podesi_Formu()

        For Each dgv As DataGridView In niz_dgv
            BufferMethod.DoubleBuffered(dgv, True)
        Next

        'Call setTheme(GetTheme())
        PanelTop.BackColor = setTheme(Nothing, Nothing)
        selectedindexchange = 1
    End Sub
    'Sub setTheme(ByVal theme As String)
    '    If theme = "L" Then
    '        ISTTheme.ChosenTheme("Light")

    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    Else
    '        ISTTheme.ChosenTheme("Dark")

    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    End If
    'End Sub
    Dim wworg As Integer = 1920 '1366
    Dim hhorg As Integer = 1080 '768
    Dim ww As Integer = 1366 'Me.Width
    Dim hh As Integer = 768 'Me.Heigh
    'Dim RW As Double = ww / wworg   ' Ratio change of width
    'Dim RH As Double = hh / hhorg   ' Ratio change of height
    Dim DD As Integer
    Dim VV As Integer
    Private Sub Podesi_Formu()
        Dim RH As Double = 1
        Dim RW As Double = 1
        If Not Me.WindowState = FormWindowState.Minimized Then
            If VV > hh - 50 Then
                RH = (hh - 50) / VV
                Me.Height = hh - 50 'CInt(VV * RH)
            End If
            If DD > ww Then
                RW = ww / wworg
                Me.Width = CInt(DD * RW)
            End If
            If RH < 1 Then
                For Each k As Control In Me.Controls
                    k.Height = CInt(k.Height * RH)
                    k.Top = CInt(k.Top * RH)
                Next

                tv.Height = CInt(tv.Height * RH)
                tv.Top = CInt(tv.Top * RH)

                Panel2.Height = CInt(Panel2.Height * RH)
                Panel2.Top = CInt(Panel2.Top * RH)

                'For Each k As Control In Panel2.Controls
                '    k.Height = CInt(k.Height * RH)
                '    k.Top = CInt(k.Top * RH)
                'Next

                For Each k As Control In PanelContext.Controls
                    k.Height = CInt(k.Height * RH)
                    k.Top = CInt(k.Top * RH)
                Next

                For Each k As Control In TabControl1.Controls
                    k.Height = CInt(k.Height * RH)
                    k.Top = CInt(k.Top * RH)
                Next

                For Each k As Control In TabPageIzbor1.Controls
                    k.Height = CInt(k.Height * RH)
                    k.Top = CInt(k.Top * RH)
                Next


                For Each k As Control In TabPageSQL.Controls
                    k.Height = CInt(k.Height * RH)
                    k.Top = CInt(k.Top * RH)
                Next

            End If
        End If


    End Sub


End Class
