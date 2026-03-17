Option Strict Off

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class FormFilterN
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
    Friend WithEvents BtnFilter As Button
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb3 As CheckBox
    Friend WithEvents cb4 As CheckBox
    Friend WithEvents txtFilter1 As TextBox
    Friend WithEvents cb5 As CheckBox
    Friend WithEvents txtFilter2 As TextBox
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents PanelContext As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents meText As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFilterN))
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.BtnFilter = New System.Windows.Forms.Button()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb3 = New System.Windows.Forms.CheckBox()
        Me.cb4 = New System.Windows.Forms.CheckBox()
        Me.txtFilter1 = New System.Windows.Forms.TextBox()
        Me.cb5 = New System.Windows.Forms.CheckBox()
        Me.txtFilter2 = New System.Windows.Forms.TextBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.gbOptions.SuspendLayout()
        Me.PanelContext.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelBottom.Controls.Add(Me.BtnFilter)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 177)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(304, 30)
        Me.PanelBottom.TabIndex = 38
        '
        'BtnFilter
        '
        Me.BtnFilter.BackColor = System.Drawing.Color.Gainsboro
        Me.BtnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.BtnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFilter.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFilter.Location = New System.Drawing.Point(172, 3)
        Me.BtnFilter.Name = "BtnFilter"
        Me.BtnFilter.Size = New System.Drawing.Size(119, 23)
        Me.BtnFilter.TabIndex = 2
        Me.BtnFilter.Text = "Filter"
        Me.BtnFilter.UseVisualStyleBackColor = False
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb1.Location = New System.Drawing.Point(12, 14)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(60, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Equals"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AccessibleDescription = " "
        Me.cb2.AutoSize = True
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb2.Location = New System.Drawing.Point(12, 35)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(109, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Does not equal"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb3.Location = New System.Drawing.Point(12, 56)
        Me.cb3.Name = "cb3"
        Me.cb3.Size = New System.Drawing.Size(77, 17)
        Me.cb3.TabIndex = 2
        Me.cb3.Text = "Less then"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb4
        '
        Me.cb4.AccessibleDescription = " "
        Me.cb4.AutoSize = True
        Me.cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb4.Location = New System.Drawing.Point(12, 77)
        Me.cb4.Name = "cb4"
        Me.cb4.Size = New System.Drawing.Size(96, 17)
        Me.cb4.TabIndex = 3
        Me.cb4.Text = "Greater then"
        Me.cb4.UseVisualStyleBackColor = True
        '
        'txtFilter1
        '
        Me.txtFilter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtFilter1.Location = New System.Drawing.Point(172, 95)
        Me.txtFilter1.Name = "txtFilter1"
        Me.txtFilter1.Size = New System.Drawing.Size(119, 20)
        Me.txtFilter1.TabIndex = 1
        Me.txtFilter1.Visible = False
        '
        'cb5
        '
        Me.cb5.AutoSize = True
        Me.cb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb5.Location = New System.Drawing.Point(12, 98)
        Me.cb5.Name = "cb5"
        Me.cb5.Size = New System.Drawing.Size(72, 17)
        Me.cb5.TabIndex = 4
        Me.cb5.Text = "Between"
        Me.cb5.UseVisualStyleBackColor = True
        '
        'txtFilter2
        '
        Me.txtFilter2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFilter2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtFilter2.Location = New System.Drawing.Point(172, 123)
        Me.txtFilter2.Name = "txtFilter2"
        Me.txtFilter2.Size = New System.Drawing.Size(119, 20)
        Me.txtFilter2.TabIndex = 5
        Me.txtFilter2.Visible = False
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.txtFilter2)
        Me.gbOptions.Controls.Add(Me.cb5)
        Me.gbOptions.Controls.Add(Me.txtFilter1)
        Me.gbOptions.Controls.Add(Me.cb4)
        Me.gbOptions.Controls.Add(Me.cb3)
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbOptions.Location = New System.Drawing.Point(0, 0)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(304, 207)
        Me.gbOptions.TabIndex = 41
        Me.gbOptions.TabStop = False
        '
        'PanelContext
        '
        Me.PanelContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContext.Controls.Add(Me.PanelBottom)
        Me.PanelContext.Controls.Add(Me.gbOptions)
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(0, 40)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(306, 209)
        Me.PanelContext.TabIndex = 42
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.meText)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(306, 40)
        Me.PanelTop.TabIndex = 144
        '
        'meText
        '
        Me.meText.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.meText.BackColor = System.Drawing.Color.Transparent
        Me.meText.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.meText.ForeColor = System.Drawing.Color.DarkOrange
        Me.meText.Location = New System.Drawing.Point(5, 0)
        Me.meText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.meText.Name = "meText"
        Me.meText.Size = New System.Drawing.Size(135, 40)
        Me.meText.TabIndex = 59
        Me.meText.Tag = "nediraj"
        Me.meText.Text = "Find - Number filter"
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
        Me.btnCerrar.Location = New System.Drawing.Point(266, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 61
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormFilterN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(306, 249)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFilterN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.PanelContext.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _parentForm As Form
    Public kolone As String

    Public Sub New(ByVal form As Form)
        InitializeComponent()
        _parentForm = form
        AddHandler Me.Paint, AddressOf DrawBorder
        Call SetLang()
    End Sub
    Private Sub SetLang()

        'Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")

    End Sub
    Private Sub DrawBorder(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim rect1 As New Rectangle(txtFilter1.Location.X - 1, txtFilter1.Location.Y - 1, txtFilter1.Width + 1, txtFilter1.Height + 1)

        Dim pen As New Pen(Color.Black, 1)
        Dim g As Graphics = e.Graphics
        g.DrawRectangle(pen, rect1)

    End Sub

    Private Sub btnSort_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFilter.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ReadOnly Property Filter() As String
        Get
            Dim ff As String = ""
            If Me.txtFilter1.Text <> "" Then
                ff = " = " & Me.txtFilter1.Text & ""
                If cb1.Checked = True Then ff = " = " & Me.txtFilter1.Text & ""
                If cb2.Checked = True Then ff = " <> " & Me.txtFilter1.Text & ""
                If cb3.Checked = True Then ff = " < " & Me.txtFilter1.Text & ""
                If cb4.Checked = True Then ff = " > " & Me.txtFilter1.Text & ""
                If cb5.Checked = True Then ff = Me.txtFilter1.Text & ";" & Me.txtFilter2.Text
            Else
                ff = ""
                If cb5.Checked = True Then ff = Me.txtFilter1.Text & ";" & Me.txtFilter2.Text
            End If
            Return ff
        End Get
    End Property

    Private Sub txtFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFilter1.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True
            System.Windows.Forms.SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub cb1_Click(sender As Object, e As EventArgs) Handles cb1.Click
        If cb1.Checked = True Then
            Me.txtFilter1.Top = cb1.Top
            Me.txtFilter1.Visible = True
            Me.txtFilter2.Visible = False
            cb2.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            cb5.Checked = False
        End If
    End Sub

    Private Sub cb2_Click(sender As Object, e As EventArgs) Handles cb2.Click
        If cb2.Checked = True Then
            Me.txtFilter1.Top = cb2.Top
            Me.txtFilter1.Visible = True
            Me.txtFilter2.Visible = False
            cb1.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            cb5.Checked = False

        End If
    End Sub

    Private Sub cb3_Click(sender As Object, e As EventArgs) Handles cb3.Click
        If cb3.Checked = True Then
            Me.txtFilter1.Top = cb3.Top
            Me.txtFilter1.Visible = True
            Me.txtFilter2.Visible = False
            cb1.Checked = False
            cb2.Checked = False
            cb4.Checked = False
            cb5.Checked = False
        End If
    End Sub

    Private Sub cb4_Click(sender As Object, e As EventArgs) Handles cb4.Click
        If cb4.Checked = True Then
            Me.txtFilter1.Top = cb4.Top
            Me.txtFilter1.Visible = True
            Me.txtFilter2.Visible = False
            cb1.Checked = False
            cb3.Checked = False
            cb2.Checked = False
            cb5.Checked = False
        End If
    End Sub

    Private Sub cb5_Click(sender As Object, e As EventArgs) Handles cb5.Click
        If cb5.Checked = True Then
            Me.txtFilter1.Top = cb5.Top
            Me.txtFilter1.Visible = True
            Me.txtFilter2.Visible = True
            cb1.Checked = False
            cb3.Checked = False
            cb4.Checked = False
            cb2.Checked = False
        End If
    End Sub

    Private Sub FormFilterN_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Call setTheme(GetTheme())
        PanelTop.BackColor = setTheme(Nothing, Nothing)

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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class