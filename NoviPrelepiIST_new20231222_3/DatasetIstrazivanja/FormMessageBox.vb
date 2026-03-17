Option Strict Off
Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class FormMessageBox
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

    Private WithEvents panelBody As Panel
    Private WithEvents labelMessage As Label
    Private WithEvents pictureBoxIcon As PictureBox
    Private WithEvents panelButtons As Panel
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents panelTitleBar As Panel
    Private WithEvents labelCaption As Label
    Private WithEvents btnClose As Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMessageBox))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.labelCaption = New System.Windows.Forms.Label()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button3 = New System.Windows.Forms.Button()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.pictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.labelMessage = New System.Windows.Forms.Label()
        Me.panelBody = New System.Windows.Forms.Panel()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitleBar.SuspendLayout()
        Me.panelButtons.SuspendLayout()
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(414, 0)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(53, 32)
        Me.btnClose.TabIndex = 3
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'labelCaption
        '
        Me.labelCaption.AutoSize = True
        Me.labelCaption.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCaption.ForeColor = System.Drawing.Color.White
        Me.labelCaption.Location = New System.Drawing.Point(12, 9)
        Me.labelCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelCaption.Name = "labelCaption"
        Me.labelCaption.Size = New System.Drawing.Size(87, 16)
        Me.labelCaption.TabIndex = 4
        Me.labelCaption.Text = "labelCaption"
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.labelCaption)
        Me.panelTitleBar.Controls.Add(Me.btnClose)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(467, 32)
        Me.panelTitleBar.TabIndex = 1
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button1.Location = New System.Drawing.Point(92, 8)
        Me.button1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(113, 24)
        Me.button1.TabIndex = 0
        Me.button1.Text = "button1"
        Me.button1.UseVisualStyleBackColor = False
        '
        'button2
        '
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button2.Location = New System.Drawing.Point(217, 8)
        Me.button2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(113, 24)
        Me.button2.TabIndex = 1
        Me.button2.Text = "button2"
        Me.button2.UseVisualStyleBackColor = False
        '
        'button3
        '
        Me.button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button3.FlatAppearance.BorderSize = 0
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.button3.Location = New System.Drawing.Point(342, 8)
        Me.button3.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(113, 24)
        Me.button3.TabIndex = 2
        Me.button3.Text = "button3"
        Me.button3.UseVisualStyleBackColor = False
        '
        'panelButtons
        '
        Me.panelButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.panelButtons.Controls.Add(Me.button3)
        Me.panelButtons.Controls.Add(Me.button2)
        Me.panelButtons.Controls.Add(Me.button1)
        Me.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelButtons.Location = New System.Drawing.Point(0, 87)
        Me.panelButtons.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(467, 40)
        Me.panelButtons.TabIndex = 2
        '
        'pictureBoxIcon
        '
        Me.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.pictureBoxIcon.Image = CType(resources.GetObject("pictureBoxIcon.Image"), System.Drawing.Image)
        Me.pictureBoxIcon.Location = New System.Drawing.Point(13, 11)
        Me.pictureBoxIcon.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pictureBoxIcon.Name = "pictureBoxIcon"
        Me.pictureBoxIcon.Size = New System.Drawing.Size(53, 44)
        Me.pictureBoxIcon.TabIndex = 0
        Me.pictureBoxIcon.TabStop = False
        '
        'labelMessage
        '
        Me.labelMessage.AutoSize = True
        Me.labelMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.labelMessage.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.labelMessage.Location = New System.Drawing.Point(66, 11)
        Me.labelMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelMessage.MaximumSize = New System.Drawing.Size(800, 0)
        Me.labelMessage.Name = "labelMessage"
        Me.labelMessage.Padding = New System.Windows.Forms.Padding(7, 5, 13, 16)
        Me.labelMessage.Size = New System.Drawing.Size(114, 37)
        Me.labelMessage.TabIndex = 1
        Me.labelMessage.Text = "labelMessage"
        Me.labelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelBody
        '
        Me.panelBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelBody.Controls.Add(Me.labelMessage)
        Me.panelBody.Controls.Add(Me.pictureBoxIcon)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 32)
        Me.panelBody.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Padding = New System.Windows.Forms.Padding(13, 11, 0, 0)
        Me.panelBody.Size = New System.Drawing.Size(467, 55)
        Me.panelBody.TabIndex = 3
        '
        'FormMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 127)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelButtons)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(461, 159)
        Me.Name = "FormMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FormMessageBox"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.panelButtons.ResumeLayout(False)
        CType(Me.pictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region
    'Fields

    Private _primaryColor As Color = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
    'Color.CornflowerBlue 'System.Drawing.Color.FromArgb(3, 10, 26)
    Private _borderSize As Integer = 1

    'Properties
    'Public Property PrimaryColor As Color
    '    Get
    '        Return _primaryColor
    '    End Get
    '    Set(value As Color)
    '        _primaryColor = value

    '        Me.BackColor = System.Drawing.Color.FromArgb(3, 10, 26) 'Form Border Color
    '        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(3, 10, 26) ' 'Title Bar Back Color
    '        Me.panelBody.BackColor = System.Drawing.Color.FromArgb(252, 251, 249) 'panelBody 
    '        Me.PanelButtons.BackColor = System.Drawing.Color.FromArgb(252, 251, 249) 'PanelButtons 
    '    End Set
    'End Property
    Public Property PrimaryColor As Color
        Get
            Return _primaryColor
        End Get
        Set(value As Color)
            _primaryColor = value
            Me.BackColor = PrimaryColor 'Form Border Color
            Me.panelBody.BackColor = System.Drawing.Color.FromArgb(252, 251, 249) 'panelBody 
            Me.panelTitleBar.BackColor = PrimaryColor 'Title Bar Back Color
        End Set
    End Property

    'Constructors
    Public Sub New(text As String)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = ""
        SetFormSize()
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1) 'Set Default Buttons
    End Sub

    Public Sub New(text As String, caption As String)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1) 'Set Default Buttons
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, MessageBoxDefaultButton.Button1) 'Set [Default Button 1]
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, MessageBoxDefaultButton.Button1) 'Set [Default Button 1]
        SetIcon(icon)
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, defaultButton)
        SetIcon(icon)
    End Sub

    '-> Private Methods
    Private Sub InitializeItems()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(_borderSize) 'Set border size
        Me.labelMessage.MaximumSize = New Size(550, 0)
        Me.btnClose.DialogResult = DialogResult.Cancel
        Me.button1.DialogResult = DialogResult.OK
        Me.button1.Visible = False
        Me.button2.Visible = False
        Me.button3.Visible = False
    End Sub

    Private Sub SetFormSize()
        Dim widht As Integer = Me.labelMessage.Width + Me.pictureBoxIcon.Width + Me.panelBody.Padding.Left
        Dim height As Integer = Me.panelTitleBar.Height + Me.labelMessage.Height + Me.panelButtons.Height + Me.panelBody.Padding.Top
        Me.Size = New Size(widht, height)
    End Sub

    Private Sub SetButtons(buttons As MessageBoxButtons, defaultButton As MessageBoxDefaultButton)
        Dim xCenter As Integer = (Me.panelButtons.Width - button1.Width) / 2
        Dim yCenter As Integer = (Me.panelButtons.Height - button1.Height) / 2
        Dim xRight As Integer = Me.panelButtons.Width - 15

        Select Case buttons
            Case MessageBoxButtons.OK
                'OK Button
                button1.Visible = True
                button1.Location = New Point(xCenter, yCenter)
                button1.Text = "Ok"
                button1.DialogResult = DialogResult.OK 'Set DialogResult

                'Set Default Button
                SetDefaultButton(defaultButton)

            Case MessageBoxButtons.OKCancel
                'OK Button
                button1.Visible = True
                button1.Location = New Point(xRight - 2 * button1.Width - 15, yCenter)
                button1.Text = "Ok"
                button1.DialogResult = DialogResult.OK 'Set DialogResult

                'Cancel Button
                button2.Visible = True
                button2.Location = New Point(xRight - 1 * button1.Width, yCenter)
                button2.Text = "Cancel"
                button2.DialogResult = DialogResult.Cancel 'Set DialogResult
                button2.BackColor = Color.DimGray

                'Set Default Button
                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.RetryCancel
                'Retry Button
                button1.Visible = True
                button1.Location = New Point(xRight - 2 * button1.Width - 15, yCenter)
                button1.Text = "Retry"
                button1.DialogResult = DialogResult.Retry 'Set DialogResult

                'Cancel Button
                button2.Visible = True
                button2.Location = New Point(xRight - 1 * button1.Width, yCenter)
                button2.Text = "Cancel"
                button2.DialogResult = DialogResult.Cancel 'Set DialogResult
                button2.BackColor = Color.DimGray

                'Set Default Button
                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.YesNo
                'Yes Button
                button1.Visible = True
                button1.Location = New Point(xRight - 2 * button1.Width - 15, yCenter)
                button1.Text = "Yes"
                button1.DialogResult = DialogResult.Yes 'Set DialogResult

                'No Button
                button2.Visible = True
                button2.Location = New Point(xRight - 1 * button1.Width, yCenter)
                button2.Text = "No"
                button2.DialogResult = DialogResult.No 'Set DialogResult
                button2.BackColor = Color.IndianRed

                'Set Default Button
                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.YesNoCancel
                'Yes Button
                button1.Visible = True
                button1.Location = New Point(xRight - 3 * button1.Width - 10, yCenter)
                button1.Text = "Yes"
                button1.DialogResult = DialogResult.Yes 'Set DialogResult

                'No Button
                button2.Visible = True
                button2.Location = New Point(xRight - 2 * button1.Width, yCenter)
                button2.Text = "No"
                button2.DialogResult = DialogResult.No 'Set DialogResult
                button2.BackColor = Color.IndianRed

                'Cancel Button
                button3.Visible = True
                button3.Location = New Point(xRight - 1 * button1.Width + 10, yCenter)
                button3.Text = "Cancel"
                button3.DialogResult = DialogResult.Cancel 'Set DialogResult
                button3.BackColor = Color.DimGray

                SetDefaultButton(defaultButton)

            Case MessageBoxButtons.AbortRetryIgnore
                'Abort Button
                button1.Visible = True
                button1.Location = New Point(xRight - 3 * button1.Width - 10, yCenter)
                button1.Text = "Abort"
                button1.DialogResult = DialogResult.Abort 'Set DialogResult
                button1.BackColor = Color.Goldenrod

                'Retry Button
                button2.Visible = True
                button2.Location = New Point(xRight - 2 * button1.Width, yCenter)
                button2.Text = "Retry"
                button2.DialogResult = DialogResult.Retry 'Set DialogResult

                'Ignore Button
                button3.Visible = True
                button3.Location = New Point(xRight - 1 * button1.Width + 10, yCenter)
                button3.Text = "Ignore"
                button3.DialogResult = DialogResult.Ignore 'Set DialogResult
                button3.BackColor = Color.IndianRed

                SetDefaultButton(defaultButton)
        End Select
    End Sub

    Private Sub SetDefaultButton(defaultButton As MessageBoxDefaultButton)
        Select Case defaultButton
            Case MessageBoxDefaultButton.Button1 'Focus button 1
                button1.Select()
                button1.ForeColor = Color.White
                button1.Font = New Font(button1.Font, FontStyle.Underline)
            Case MessageBoxDefaultButton.Button2 'Focus button 2
                button2.Select()
                button2.ForeColor = Color.White
                button2.Font = New Font(button2.Font, FontStyle.Underline)
            Case MessageBoxDefaultButton.Button3 'Focus button 3
                button3.Select()
                button3.ForeColor = Color.White
                button3.Font = New Font(button3.Font, FontStyle.Underline)
        End Select
    End Sub

    Private Sub SetIcon(icon As MessageBoxIcon)
        Select Case icon
            Case MessageBoxIcon.Error
                Me.pictureBoxIcon.Image = My.Resources._error
                PrimaryColor = Color.FromArgb(224, 79, 95)
                Me.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson
            Case MessageBoxIcon.Information
                Me.pictureBoxIcon.Image = My.Resources.information
                PrimaryColor = Color.FromArgb(38, 191, 166)
            Case MessageBoxIcon.Question
                Me.pictureBoxIcon.Image = My.Resources.question
                PrimaryColor = Color.FromArgb(10, 119, 232)
            Case MessageBoxIcon.Exclamation
                Me.pictureBoxIcon.Image = My.Resources.exclamation
                PrimaryColor = Color.FromArgb(255, 140, 0)
            Case MessageBoxIcon.None
                Me.pictureBoxIcon.Image = My.Resources.chat
                PrimaryColor = Color.CornflowerBlue
        End Select
    End Sub

    '-> Events Methods
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

#Region "-> Drag Form"
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As System.IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
    Private Sub BtnIzlaz_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles button1.PreviewKeyDown, button2.PreviewKeyDown, button3.PreviewKeyDown
        Select Case (e.KeyCode)
            Case Keys.Down, Keys.Up, Keys.Right, Keys.Left
                e.IsInputKey = True
        End Select
    End Sub
    Private Sub form_KeyDown(ByVal sender As Control, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Tab Or e.KeyCode = Keys.Enter Then
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
            e.Handled = True
        End If
    End Sub
    Private Sub button_KeyDown(sender As Object, e As KeyEventArgs) Handles button1.KeyDown, button2.KeyDown, button3.KeyDown

        Select Case (e.KeyCode)
            Case Keys.Down
                SendKeys.Send("{TAB}")
            Case Keys.Up
                SendKeys.Send("{TAB}")
            Case Keys.Right
                SendKeys.Send("{TAB}")
            Case Keys.Left
                SendKeys.Send("{TAB}")
        End Select
    End Sub

    Private Sub button_Enter(sender As Object, e As EventArgs) Handles button1.Enter, button2.Enter, button3.Enter
        Dim button As Button = DirectCast(sender, Button)
        button.ForeColor = Color.White
        button.Font = New Font(button.Font, FontStyle.Underline)
        Dim x As Integer = button.Location.X : Dim y As Integer = button.Location.Y
        button.Height = button.Height + 4
        button.Location = New Point(button.Location.X, button.Location.Y - 2)
    End Sub

    Private Sub button_Leave(sender As Object, e As EventArgs) Handles button1.Leave, button2.Leave, button3.Leave
        Dim button As Button = DirectCast(sender, Button)
        button.ForeColor = Color.White
        button.Font = New Font(button.Font, FontStyle.Regular)
        button.Height = button.Height - 4
        button.Location = New Point(button.Location.X, button.Location.Y + 2)
    End Sub

#End Region
End Class

