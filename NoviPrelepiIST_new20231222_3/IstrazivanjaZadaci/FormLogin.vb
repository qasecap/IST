
Imports System.Configuration

Public Class FormLogin
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        Call getISTconn("ISTconnection", Me.m_conn, Me.TextBoxUserID.Text, Me.TextBoxPassword.Text, "")

    End Sub

    Public Sub getISTconn(ByVal cs2 As String, ByRef cst As String, ByRef u As String, ByRef p As String, ByRef r As String)
        cst = ""
        u = ""
        p = ""
        r = ""
        'Dim nv As System.Collections.Specialized.NameValueCollection
        'nv = CType(System.Configuration.ConfigurationSettings.GetConfig(cs2), System.Collections.Specialized.NameValueCollection)

        Dim nv As System.Collections.Specialized.NameValueCollection
        nv = CType(ConfigurationManager.GetSection(cs2), System.Collections.Specialized.NameValueCollection)

        Dim k As String
        For Each k In nv.Keys
            Dim b As Boolean = False
            Dim v As String = nv.Item(k)
            If k = "User ID" Then
                u = v
                b = True
            ElseIf k = "Password" Then
                p = v
                b = True
            End If
            If Not b Then
                cst += k + "=" + v + ";"
            End If
        Next
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
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBoxUserID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonLogin As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItemHelpAbout = New System.Windows.Forms.MenuItem()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(88, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(72, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUserID.Location = New System.Drawing.Point(152, 102)
        Me.TextBoxUserID.MaxLength = 8
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(192, 22)
        Me.TextBoxUserID.TabIndex = 2
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxPassword.Location = New System.Drawing.Point(152, 134)
        Me.TextBoxPassword.MaxLength = 8
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(192, 22)
        Me.TextBoxPassword.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(262, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemHelpAbout})
        Me.MenuItem1.Text = "&Help"
        '
        'MenuItemHelpAbout
        '
        Me.MenuItemHelpAbout.Index = 0
        Me.MenuItemHelpAbout.Text = "&About..."
        '
        'ButtonLogin
        '
        Me.ButtonLogin.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonLogin.Location = New System.Drawing.Point(152, 176)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(82, 24)
        Me.ButtonLogin.TabIndex = 7
        Me.ButtonLogin.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(112, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 66)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(449, 244)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentication"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ReadOnly m_conn As String = ""

    Public ReadOnly Property MyConnectionString() As String
        Get
            Dim conn As String = Me.m_conn
            conn += "User ID=" + Me.TextBoxUserID.Text + ";"
            conn += "Password=" + Me.TextBoxPassword.Text + ";"
            Return conn
        End Get
    End Property

    Public Overloads Sub Dispose()
        MyBase.Dispose()
    End Sub

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub MenuItemHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemHelpAbout.Click
        'Dim frm As New FormAbout
        'frm.ShowDialog()
        'frm.Dispose()
    End Sub

    Private Sub FormLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.TextBoxUserID.Focus()
    End Sub

End Class