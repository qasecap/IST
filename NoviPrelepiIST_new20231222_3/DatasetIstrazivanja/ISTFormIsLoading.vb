Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Timers
Imports System.IO

Public Class ISTFormIsLoading
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

    Friend WithEvents btnGIF As Button


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnGIF = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGIF
        '
        Me.btnGIF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGIF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGIF.Location = New System.Drawing.Point(0, 0)
        Me.btnGIF.Name = "btnGIF"
        Me.btnGIF.Size = New System.Drawing.Size(912, 509)
        Me.btnGIF.TabIndex = 0
        Me.btnGIF.UseVisualStyleBackColor = True
        '
        'ISTFormIsLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(912, 509)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGIF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ISTFormIsLoading"
        Me.Opacity = 0.93R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ISTFormIsLoading"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents cntl As Control
    Private WithEvents frm As Form

    Public Sub New(ByVal FormToDisable As Form, ByVal ControlToDisable As Control, Optional ByVal prosiri As Boolean = False)
        InitializeComponent()

        Dim GetTheme As String = "Dark"
        Dim gde As String = System.Environment.GetEnvironmentVariable("TEMP") & "\ISTTheme.txt"
        If File.Exists(gde) Then
            Dim str As String = GetFileContents(gde)
            GetTheme = str.Trim.ToUpper
        End If


        cntl = ControlToDisable
        Me.cntl = ControlToDisable
        Me.frm = FormToDisable
        Me.DoubleBuffered = True
        Me.Opacity = 0.9
        Me.Size = New Size(710, 433)
        If Not cntl Is Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            Me.WindowState = FormWindowState.Normal
            Me.Owner = FormToDisable
            If prosiri = False Then
                'Me.Size = cntl.Size
            Else
                Me.StartPosition = FormStartPosition.CenterScreen
                Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
                Me.WindowState = FormWindowState.Maximized
            End If
        Else
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.WindowState = FormWindowState.Normal
            Me.Size = New Size(710, 433)
            'Me.Size = New Size(600, 600)
            'Me.Opacity = 1
        End If
        setTheme(GetTheme)
        Me.ShowInTaskbar = False

        'Me.BackColor = Color.FromArgb(252, 251, 249)
        'Me.Opacity = 80%
        Me.Cursor = Cursors.Default
    End Sub

    Sub setTheme(ByVal theme As String)
        If theme = "Light" Then
            ISTTheme.ChosenTheme("Light")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifLIGHT
        ElseIf theme = "A1" Then
            ISTTheme.ChosenTheme("A1")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifA1
        ElseIf theme = "A2" Then
            ISTTheme.ChosenTheme("A2")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifA2
        ElseIf theme = "A3" Then
            ISTTheme.ChosenTheme("A3")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifA3
        ElseIf theme = "A4" Then
            ISTTheme.ChosenTheme("A4")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifA2
        ElseIf theme = "A5" Then
            ISTTheme.ChosenTheme("A5")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifA5
        ElseIf theme = "A6" Then
            ISTTheme.ChosenTheme("A6")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifA6
        ElseIf theme = "A7" Then
            ISTTheme.ChosenTheme("A7")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifA7
        Else
            ISTTheme.ChosenTheme("Dark")
            Me.BackColor = ISTTheme.PanelParent
            btnGIF.Image = My.Resources.gifDARK
        End If
    End Sub

    'Private Sub Overlay_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
    '    FocusOverlay()
    'End Sub
    Dim proc_timer As New System.Timers.Timer   'ne moze obican Timer

    Private Sub ISTFormIsLoading_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Cursor = Cursors.Default
        'AddHandler proc_timer.Elapsed, AddressOf proc_Timer_Ticker
        'proc_timer.Interval = 1000
        'proc_timer.AutoReset = True
        'proc_timer.Enabled = True
        'proc_timer.Start()
        FocusOverlay()
    End Sub
    'Private Sub proc_Timer_Ticker(sender As Object, e As EventArgs)
    '    Dim rand As New Random
    '    Me.BackColor = Color.FromArgb(rand.Next(232, 252), rand.Next(231, 251), rand.Next(229, 249))
    'End Sub

    Private Sub ISTFormIsLoading_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        proc_timer.Stop()
        If frm Is Nothing Then
            Me.StartPosition = FormStartPosition.Manual
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub FocusOverlay()
        If frm Is Nothing Then

            Me.BringToFront()
            Me.Focus()
        ElseIf cntl.Name = frm.Name Then
            Me.BringToFront()
            Me.Focus()
        Else
            Me.Location = New Point(frm.Location.X + cntl.Location.X - 20, frm.Location.Y + cntl.Location.Y)
        End If
    End Sub

    Private Sub frm_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cntl.GotFocus, frm.GotFocus
        FocusOverlay()
    End Sub

    Private Sub frm_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles cntl.Move, frm.Move
        FocusOverlay()
    End Sub
    Private Sub frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles frm.Activated
        FocusOverlay()
    End Sub
    Private Sub frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles cntl.Resize, frm.Resize
        FocusOverlay()
    End Sub


End Class

