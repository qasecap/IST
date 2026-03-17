Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms


'Imports ContentAlignment = System.Drawing.ContentAlignment
'Imports Microsoft.Win32
'Imports System.Runtime.InteropServices
'Imports System.Linq

Public Class FormAbout
    Inherits FormTemplate

    Dim jezik As String
    Friend WithEvents panelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelTitleBar As Panel
    Friend WithEvents PanelShadow As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelDesktop As Panel


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

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PanelTitleBar = New System.Windows.Forms.Panel()
        Me.PanelShadow = New System.Windows.Forms.Panel()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        Me.PanelDesktop.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.PanelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Padding = New System.Windows.Forms.Padding(0, 0, 0, 15)
        Me.panelMenu.Size = New System.Drawing.Size(230, 587)
        Me.panelMenu.TabIndex = 0
        '
        'PanelLogo
        '
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(230, 84)
        Me.PanelLogo.TabIndex = 0
        '
        'PanelTitleBar
        '
        Me.PanelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitleBar.Location = New System.Drawing.Point(230, 0)
        Me.PanelTitleBar.Name = "PanelTitleBar"
        Me.PanelTitleBar.Size = New System.Drawing.Size(887, 75)
        Me.PanelTitleBar.TabIndex = 1
        '
        'PanelShadow
        '
        Me.PanelShadow.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.PanelShadow.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelShadow.Location = New System.Drawing.Point(230, 75)
        Me.PanelShadow.Name = "PanelShadow"
        Me.PanelShadow.Size = New System.Drawing.Size(887, 9)
        Me.PanelShadow.TabIndex = 2
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDesktop.Controls.Add(Me.Button1)
        Me.PanelDesktop.Controls.Add(Me.TextBox1)
        Me.PanelDesktop.Controls.Add(Me.Panel1)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(230, 84)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(887, 503)
        Me.PanelDesktop.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(468, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 186)
        Me.Panel1.TabIndex = 0
        '
        'FormAbout
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1117, 587)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.PanelShadow)
        Me.Controls.Add(Me.PanelTitleBar)
        Me.Controls.Add(Me.panelMenu)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "FormAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IST"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region


    Public Sub New(ByVal jezik As String)
        Me.New()
        'default je ćirilica
        Me.jezik = jezik


        Panel1.BorderStyle = FormBorderStyle.None
        Panel1.Padding = New Padding(borderSize)
        Panel1.BackColor = borderColor

        Me.BackColor = Color.FromArgb(98, 102, 244)

    End Sub

    Private borderRadius As Integer = 30
    Private borderSize As Integer = 3
    Private borderColor As Color = Color.HotPink
    Private Sub ActivateButton(ByVal senderBtn As Object, ByVal color As Color)
        If senderBtn IsNot Nothing Then
            DisableButton(Color.Transparent)


        End If
    End Sub

    Private Sub DisableButton(ByVal color As Color)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Process()
        p = Process.GetProcessesByName("qgis-ltr-bin")
        If p.Length > 0 Then
            For Each pp As Process In Process.GetProcesses
                If pp.ProcessName = "qgis-ltr-bin" Then
                    pp.Kill()
                End If
            Next
        End If

        'Button.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim myProcess As Process = Process.Start("C:\PPES_24_QGIS\PPES_24_QGIS.exe")
        myProcess.WaitForExit()
        Dim psi As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo()
        psi.FileName = "C:\Program Files\QGIS 3.4\bin\qgis-ltr-bin.exe"
        psi.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Dim ppp As System.Diagnostics.Process = System.Diagnostics.Process.Start(psi)
        ppp.WaitForExit()

        ISTMessageBox.Show("Rad sa mapom je završen, možete nastaviti sa radom u aplikaciji za unos.")


        Me.Cursor = Cursors.Default
    End Sub

End Class

