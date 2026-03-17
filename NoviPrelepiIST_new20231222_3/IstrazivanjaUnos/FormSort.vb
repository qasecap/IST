Option Strict Off

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormSort
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
    Friend WithEvents BtnSort As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo5 As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents rbd1 As System.Windows.Forms.RadioButton
    Friend WithEvents rba1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rbd2 As System.Windows.Forms.RadioButton
    Friend WithEvents rba2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton9 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton10 As System.Windows.Forms.RadioButton
    Friend WithEvents rbd4 As System.Windows.Forms.RadioButton
    Friend WithEvents rba4 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents rbd3 As System.Windows.Forms.RadioButton
    Friend WithEvents rba3 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton11 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton12 As System.Windows.Forms.RadioButton
    Friend WithEvents rbd5 As System.Windows.Forms.RadioButton
    Friend WithEvents rba5 As System.Windows.Forms.RadioButton
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSort))
        Me.BtnSort = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo1 = New System.Windows.Forms.ComboBox()
        Me.cbo2 = New System.Windows.Forms.ComboBox()
        Me.cbo3 = New System.Windows.Forms.ComboBox()
        Me.cbo4 = New System.Windows.Forms.ComboBox()
        Me.cbo5 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbd1 = New System.Windows.Forms.RadioButton()
        Me.rba1 = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.rbd2 = New System.Windows.Forms.RadioButton()
        Me.rba2 = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.rbd4 = New System.Windows.Forms.RadioButton()
        Me.rba4 = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rbd3 = New System.Windows.Forms.RadioButton()
        Me.rba3 = New System.Windows.Forms.RadioButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.RadioButton11 = New System.Windows.Forms.RadioButton()
        Me.RadioButton12 = New System.Windows.Forms.RadioButton()
        Me.rbd5 = New System.Windows.Forms.RadioButton()
        Me.rba5 = New System.Windows.Forms.RadioButton()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSort
        '
        Me.BtnSort.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnSort.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnSort.FlatAppearance.BorderSize = 0
        Me.BtnSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSort.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSort.Location = New System.Drawing.Point(510, 10)
        Me.BtnSort.Name = "BtnSort"
        Me.BtnSort.Size = New System.Drawing.Size(96, 24)
        Me.BtnSort.TabIndex = 1
        Me.BtnSort.Text = "Sort"
        Me.BtnSort.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnCancel.FlatAppearance.BorderSize = 0
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(635, 10)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(96, 24)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.Color.Transparent
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(771, 35)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(27, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 14)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Multi Column Sort"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(25, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(500, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Please specify the sort order and direction of the columns you wish to sort by:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 14)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Sort By:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 14)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Sort By:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 14)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Sort By:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 14)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Sort By:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Sort By:"
        '
        'cbo1
        '
        Me.cbo1.CausesValidation = False
        Me.cbo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo1.FormattingEnabled = True
        Me.cbo1.Location = New System.Drawing.Point(89, 63)
        Me.cbo1.Name = "cbo1"
        Me.cbo1.Size = New System.Drawing.Size(401, 22)
        Me.cbo1.TabIndex = 23
        '
        'cbo2
        '
        Me.cbo2.CausesValidation = False
        Me.cbo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo2.FormattingEnabled = True
        Me.cbo2.Location = New System.Drawing.Point(89, 89)
        Me.cbo2.Name = "cbo2"
        Me.cbo2.Size = New System.Drawing.Size(401, 22)
        Me.cbo2.TabIndex = 26
        '
        'cbo3
        '
        Me.cbo3.CausesValidation = False
        Me.cbo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo3.FormattingEnabled = True
        Me.cbo3.Location = New System.Drawing.Point(89, 115)
        Me.cbo3.Name = "cbo3"
        Me.cbo3.Size = New System.Drawing.Size(401, 22)
        Me.cbo3.TabIndex = 29
        '
        'cbo4
        '
        Me.cbo4.CausesValidation = False
        Me.cbo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo4.FormattingEnabled = True
        Me.cbo4.Location = New System.Drawing.Point(89, 143)
        Me.cbo4.Name = "cbo4"
        Me.cbo4.Size = New System.Drawing.Size(401, 22)
        Me.cbo4.TabIndex = 32
        '
        'cbo5
        '
        Me.cbo5.CausesValidation = False
        Me.cbo5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo5.FormattingEnabled = True
        Me.cbo5.Location = New System.Drawing.Point(89, 171)
        Me.cbo5.Name = "cbo5"
        Me.cbo5.Size = New System.Drawing.Size(401, 22)
        Me.cbo5.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnClearAll)
        Me.Panel1.Controls.Add(Me.BtnSort)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(771, 45)
        Me.Panel1.TabIndex = 38
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.Gainsboro
        Me.btnClearAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnClearAll.FlatAppearance.BorderSize = 0
        Me.btnClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.Location = New System.Drawing.Point(385, 10)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(96, 24)
        Me.btnClearAll.TabIndex = 3
        Me.btnClearAll.Text = "Clear all"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.rbd1)
        Me.Panel2.Controls.Add(Me.rba1)
        Me.Panel2.Location = New System.Drawing.Point(497, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(238, 22)
        Me.Panel2.TabIndex = 39
        '
        'rbd1
        '
        Me.rbd1.AutoSize = True
        Me.rbd1.Location = New System.Drawing.Point(128, 1)
        Me.rbd1.Name = "rbd1"
        Me.rbd1.Size = New System.Drawing.Size(98, 18)
        Me.rbd1.TabIndex = 44
        Me.rbd1.TabStop = True
        Me.rbd1.Text = "Descending"
        Me.rbd1.UseVisualStyleBackColor = True
        '
        'rba1
        '
        Me.rba1.AutoSize = True
        Me.rba1.Location = New System.Drawing.Point(12, 1)
        Me.rba1.Name = "rba1"
        Me.rba1.Size = New System.Drawing.Size(89, 18)
        Me.rba1.TabIndex = 43
        Me.rba1.TabStop = True
        Me.rba1.Text = "Ascending"
        Me.rba1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.rbd2)
        Me.Panel3.Controls.Add(Me.rba2)
        Me.Panel3.Location = New System.Drawing.Point(497, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(238, 22)
        Me.Panel3.TabIndex = 42
        '
        'rbd2
        '
        Me.rbd2.AutoSize = True
        Me.rbd2.Location = New System.Drawing.Point(128, 1)
        Me.rbd2.Name = "rbd2"
        Me.rbd2.Size = New System.Drawing.Size(98, 18)
        Me.rbd2.TabIndex = 44
        Me.rbd2.TabStop = True
        Me.rbd2.Text = "Descending"
        Me.rbd2.UseVisualStyleBackColor = True
        '
        'rba2
        '
        Me.rba2.AutoSize = True
        Me.rba2.Location = New System.Drawing.Point(12, 1)
        Me.rba2.Name = "rba2"
        Me.rba2.Size = New System.Drawing.Size(89, 18)
        Me.rba2.TabIndex = 43
        Me.rba2.TabStop = True
        Me.rba2.Text = "Ascending"
        Me.rba2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.rbd4)
        Me.Panel4.Controls.Add(Me.rba4)
        Me.Panel4.Location = New System.Drawing.Point(497, 143)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(238, 22)
        Me.Panel4.TabIndex = 46
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.RadioButton9)
        Me.Panel6.Controls.Add(Me.RadioButton10)
        Me.Panel6.Location = New System.Drawing.Point(8, 27)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(238, 22)
        Me.Panel6.TabIndex = 47
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Location = New System.Drawing.Point(128, 1)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(98, 18)
        Me.RadioButton9.TabIndex = 44
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Descending"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.Location = New System.Drawing.Point(12, 1)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(89, 18)
        Me.RadioButton10.TabIndex = 43
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "Ascending"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'rbd4
        '
        Me.rbd4.AutoSize = True
        Me.rbd4.Location = New System.Drawing.Point(128, 1)
        Me.rbd4.Name = "rbd4"
        Me.rbd4.Size = New System.Drawing.Size(98, 18)
        Me.rbd4.TabIndex = 44
        Me.rbd4.TabStop = True
        Me.rbd4.Text = "Descending"
        Me.rbd4.UseVisualStyleBackColor = True
        '
        'rba4
        '
        Me.rba4.AutoSize = True
        Me.rba4.Location = New System.Drawing.Point(12, 1)
        Me.rba4.Name = "rba4"
        Me.rba4.Size = New System.Drawing.Size(89, 18)
        Me.rba4.TabIndex = 43
        Me.rba4.TabStop = True
        Me.rba4.Text = "Ascending"
        Me.rba4.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.rbd3)
        Me.Panel5.Controls.Add(Me.rba3)
        Me.Panel5.Location = New System.Drawing.Point(497, 115)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 22)
        Me.Panel5.TabIndex = 45
        '
        'rbd3
        '
        Me.rbd3.AutoSize = True
        Me.rbd3.Location = New System.Drawing.Point(128, 1)
        Me.rbd3.Name = "rbd3"
        Me.rbd3.Size = New System.Drawing.Size(98, 18)
        Me.rbd3.TabIndex = 44
        Me.rbd3.TabStop = True
        Me.rbd3.Text = "Descending"
        Me.rbd3.UseVisualStyleBackColor = True
        '
        'rba3
        '
        Me.rba3.AutoSize = True
        Me.rba3.Location = New System.Drawing.Point(12, 1)
        Me.rba3.Name = "rba3"
        Me.rba3.Size = New System.Drawing.Size(89, 18)
        Me.rba3.TabIndex = 43
        Me.rba3.TabStop = True
        Me.rba3.Text = "Ascending"
        Me.rba3.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Transparent
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.rbd5)
        Me.Panel7.Controls.Add(Me.rba5)
        Me.Panel7.Location = New System.Drawing.Point(497, 171)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(238, 22)
        Me.Panel7.TabIndex = 48
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.RadioButton11)
        Me.Panel8.Controls.Add(Me.RadioButton12)
        Me.Panel8.Location = New System.Drawing.Point(8, 27)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(238, 22)
        Me.Panel8.TabIndex = 47
        '
        'RadioButton11
        '
        Me.RadioButton11.AutoSize = True
        Me.RadioButton11.Location = New System.Drawing.Point(128, 1)
        Me.RadioButton11.Name = "RadioButton11"
        Me.RadioButton11.Size = New System.Drawing.Size(98, 18)
        Me.RadioButton11.TabIndex = 44
        Me.RadioButton11.TabStop = True
        Me.RadioButton11.Text = "Descending"
        Me.RadioButton11.UseVisualStyleBackColor = True
        '
        'RadioButton12
        '
        Me.RadioButton12.AutoSize = True
        Me.RadioButton12.Location = New System.Drawing.Point(12, 1)
        Me.RadioButton12.Name = "RadioButton12"
        Me.RadioButton12.Size = New System.Drawing.Size(89, 18)
        Me.RadioButton12.TabIndex = 43
        Me.RadioButton12.TabStop = True
        Me.RadioButton12.Text = "Ascending"
        Me.RadioButton12.UseVisualStyleBackColor = True
        '
        'rbd5
        '
        Me.rbd5.AutoSize = True
        Me.rbd5.Location = New System.Drawing.Point(128, 1)
        Me.rbd5.Name = "rbd5"
        Me.rbd5.Size = New System.Drawing.Size(98, 18)
        Me.rbd5.TabIndex = 44
        Me.rbd5.TabStop = True
        Me.rbd5.Text = "Descending"
        Me.rbd5.UseVisualStyleBackColor = True
        '
        'rba5
        '
        Me.rba5.AutoSize = True
        Me.rba5.Location = New System.Drawing.Point(12, 1)
        Me.rba5.Name = "rba5"
        Me.rba5.Size = New System.Drawing.Size(89, 18)
        Me.rba5.TabIndex = 43
        Me.rba5.TabStop = True
        Me.rba5.Text = "Ascending"
        Me.rba5.UseVisualStyleBackColor = True
        '
        'FormSort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(771, 273)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbo5)
        Me.Controls.Add(Me.cbo4)
        Me.Controls.Add(Me.cbo3)
        Me.Controls.Add(Me.cbo2)
        Me.Controls.Add(Me.cbo1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSort"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sort"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Public kolone As String

    Public Sub New(ByVal form As Form, ByVal dgvC As String)
        InitializeComponent()
        dgvC = dgvC + "$"
        dgvC = dgvC.Replace("$$", "")
        kolone = dgvC
        _parentForm = form
        AddHandler Me.Paint, AddressOf DrawBorder
    End Sub

    Private Sub DrawBorder(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim rect1 As New Rectangle(cbo1.Location.X - 1, cbo1.Location.Y - 1, cbo1.Width + 1, cbo1.Height + 1)
        Dim rect2 As New Rectangle(cbo2.Location.X - 1, cbo2.Location.Y - 1, cbo2.Width + 1, cbo2.Height + 1)
        Dim rect3 As New Rectangle(cbo3.Location.X - 1, cbo3.Location.Y - 1, cbo3.Width + 1, cbo3.Height + 1)
        Dim rect4 As New Rectangle(cbo4.Location.X - 1, cbo4.Location.Y - 1, cbo4.Width + 1, cbo4.Height + 1)
        Dim rect5 As New Rectangle(cbo5.Location.X - 1, cbo5.Location.Y - 1, cbo5.Width + 1, cbo5.Height + 1)
        Dim pen As New Pen(Color.DarkGray, 1)
        Dim g As Graphics = e.Graphics
        g.DrawRectangle(pen, rect1)
        g.DrawRectangle(pen, rect2)
        g.DrawRectangle(pen, rect3)
        g.DrawRectangle(pen, rect4)
        g.DrawRectangle(pen, rect5)
    End Sub

    Private Sub btnSort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSort.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ReadOnly Property SortOrder() As String
        Get

            Dim sort As String = ""
            If cbo1.Text <> "" Then
                sort = sort + cbo1.Text + " "
                If rba1.Checked = False AndAlso rbd1.Checked = False Then rba1.Checked = True
                If rba1.Checked = True Then sort = sort + " ASC,"
                If rbd1.Checked = True Then sort = sort + " DESC,"
            End If
            If cbo2.Text <> "" Then
                sort = sort + cbo2.Text + " "
                If rba2.Checked = False AndAlso rbd2.Checked = False Then rba2.Checked = True
                If rba2.Checked = True Then sort = sort + " ASC,"
                If rbd2.Checked = True Then sort = sort + " DESC,"
            End If
            If cbo3.Text <> "" Then
                sort = sort + cbo3.Text + " "
                If rba3.Checked = False AndAlso rbd3.Checked = False Then rba3.Checked = True
                If rba3.Checked = True Then sort = sort + " ASC,"
                If rbd3.Checked = True Then sort = sort + " DESC,"
            End If
            If cbo4.Text <> "" Then
                sort = sort + cbo4.Text + " "
                If rba4.Checked = False AndAlso rbd4.Checked = False Then rba4.Checked = True
                If rba4.Checked = True Then sort = sort + " ASC,"
                If rbd4.Checked = True Then sort = sort + " DESC,"
            End If
            If cbo5.Text <> "" Then
                sort = sort + cbo5.Text + " "
                If rba5.Checked = False AndAlso rba5.Checked = False Then rba5.Checked = True
                If rba5.Checked = True Then sort = sort + " ASC,"
                If rbd5.Checked = True Then sort = sort + " DESC,"
            End If

            sort = sort + ","
            sort = sort.Replace(",,", "")

            Return sort
        End Get
    End Property

    Private Sub cbo1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo1.Enter
        Call popunicboL(cbo1)
    End Sub

    Private Sub cbo2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo2.Enter
        Call popunicboL(cbo2)
    End Sub

    Private Sub cbo3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo3.Enter
        Call popunicboL(cbo3)
    End Sub

    Private Sub cbo4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo4.Enter
        Call popunicboL(cbo4)
    End Sub

    Private Sub cbo5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo5.Enter
        Call popunicboL(cbo5)
    End Sub

    Sub popunicboL(ByVal cb As ComboBox)
        Dim ime As String = cb.Name.Trim.ToUpper

        Dim s As String = ""
        If cbo1.Text <> "" AndAlso cbo1.Name.Trim.ToUpper <> ime Then s = s + cbo1.Text + "$"
        If cbo2.Text <> "" AndAlso cbo2.Name.Trim.ToUpper <> ime Then s = s + cbo2.Text + "$"
        If cbo3.Text <> "" AndAlso cbo3.Name.Trim.ToUpper <> ime Then s = s + cbo3.Text + "$"
        If cbo4.Text <> "" AndAlso cbo4.Name.Trim.ToUpper <> ime Then s = s + cbo4.Text + "$"
        If cbo5.Text <> "" AndAlso cbo5.Name.Trim.ToUpper <> ime Then s = s + cbo5.Text + "$"
        s = s.Trim.ToUpper
        cb.Items.Clear()
        Dim k() As String = kolone.Trim.ToUpper.Split("$")
        For i As Integer = 0 To k.GetUpperBound(0)
            If s.IndexOf(k(i) + "$") < 0 Then
                cb.Items.Add(k(i))
            End If
        Next
        cb.Text = ""
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        cbo1.Text = ""
        cbo2.Text = ""
        cbo3.Text = ""
        cbo4.Text = ""
        cbo5.Text = ""
        Me.rba1.Checked = False
        Me.rba2.Checked = False
        Me.rba3.Checked = False
        Me.rba4.Checked = False
        Me.rba5.Checked = False
        Me.rbd1.Checked = False
        Me.rbd2.Checked = False
        Me.rbd3.Checked = False
        Me.rbd4.Checked = False
        Me.rbd5.Checked = False
    End Sub

End Class