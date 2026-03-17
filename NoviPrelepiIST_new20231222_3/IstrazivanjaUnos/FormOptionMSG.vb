Option Strict Off

Public Class FormOptionMSG
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

    Friend WithEvents labelText As Label
    Friend WithEvents bop1 As Button
    Friend WithEvents bop2 As Button
    Friend WithEvents bop3 As Button
    Friend WithEvents PanelContext As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents meText As Label
    Friend WithEvents btnCerrar As Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOptionMSG))
        Me.labelText = New System.Windows.Forms.Label()
        Me.bop1 = New System.Windows.Forms.Button()
        Me.bop2 = New System.Windows.Forms.Button()
        Me.bop3 = New System.Windows.Forms.Button()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContext.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelText
        '
        Me.labelText.AutoSize = True
        Me.labelText.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelText.Location = New System.Drawing.Point(4, 7)
        Me.labelText.Name = "labelText"
        Me.labelText.Size = New System.Drawing.Size(34, 12)
        Me.labelText.TabIndex = 10000018
        Me.labelText.Text = "text..."
        '
        'bop1
        '
        Me.bop1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bop1.BackColor = System.Drawing.Color.Gainsboro
        Me.bop1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bop1.FlatAppearance.BorderSize = 0
        Me.bop1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bop1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bop1.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bop1.Location = New System.Drawing.Point(8, 51)
        Me.bop1.Margin = New System.Windows.Forms.Padding(0)
        Me.bop1.Name = "bop1"
        Me.bop1.Size = New System.Drawing.Size(150, 20)
        Me.bop1.TabIndex = 10000015
        Me.bop1.Tag = "skip1"
        Me.bop1.Text = "text1"
        Me.bop1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bop1.UseVisualStyleBackColor = False
        Me.bop1.Visible = False
        '
        'bop2
        '
        Me.bop2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bop2.BackColor = System.Drawing.Color.Gainsboro
        Me.bop2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bop2.FlatAppearance.BorderSize = 0
        Me.bop2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bop2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bop2.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bop2.Location = New System.Drawing.Point(159, 51)
        Me.bop2.Margin = New System.Windows.Forms.Padding(0)
        Me.bop2.Name = "bop2"
        Me.bop2.Size = New System.Drawing.Size(150, 20)
        Me.bop2.TabIndex = 10000016
        Me.bop2.Tag = "skip2"
        Me.bop2.Text = "text2"
        Me.bop2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bop2.UseVisualStyleBackColor = False
        Me.bop2.Visible = False
        '
        'bop3
        '
        Me.bop3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bop3.BackColor = System.Drawing.Color.Gainsboro
        Me.bop3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bop3.FlatAppearance.BorderSize = 0
        Me.bop3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bop3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bop3.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bop3.Location = New System.Drawing.Point(310, 51)
        Me.bop3.Margin = New System.Windows.Forms.Padding(0)
        Me.bop3.Name = "bop3"
        Me.bop3.Size = New System.Drawing.Size(150, 20)
        Me.bop3.TabIndex = 10000017
        Me.bop3.Tag = "skipIgnore"
        Me.bop3.Text = "text3"
        Me.bop3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bop3.UseVisualStyleBackColor = False
        Me.bop3.Visible = False
        '
        'PanelContext
        '
        Me.PanelContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContext.Controls.Add(Me.bop1)
        Me.PanelContext.Controls.Add(Me.bop3)
        Me.PanelContext.Controls.Add(Me.bop2)
        Me.PanelContext.Controls.Add(Me.labelText)
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(0, 40)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(471, 78)
        Me.PanelContext.TabIndex = 10000019
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.meText)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(471, 40)
        Me.PanelTop.TabIndex = 10000020
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
        Me.meText.Text = "Option message"
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
        Me.btnCerrar.Location = New System.Drawing.Point(426, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 60
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'FormOptionMSG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(471, 118)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = False
        
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormOptionMSG"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContext.ResumeLayout(False)
        Me.PanelContext.PerformLayout()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim GlavnaTabela As String
    Dim plj As String
    Dim trt As Control
    Dim oMSGIF As String
    Dim oMSGIS As String
    Dim oMSGARRAYSKIPTO As String()
    Dim oMSGARRAYBTEXT As String()
    Dim broj As Integer
    Public bbop As String = ""

    Public Sub New(ByVal GlavnaTabela As String, ByVal plj As String, ByVal trt As Control, ByVal oMSGIF As String, ByVal oMSGIS As String,
                  ByVal oMSGARRAYSKIPTO As String(), ByVal oMSGARRAYBTEXT As String(), ByVal broj As Integer)
        Me.New()
        Me.GlavnaTabela = GlavnaTabela
        Me.plj = plj
        Me.trt = trt
        Me.oMSGIF = oMSGIF
        Me.oMSGIS = oMSGIS
        Me.oMSGARRAYSKIPTO = oMSGARRAYSKIPTO
        Me.oMSGARRAYBTEXT = oMSGARRAYBTEXT
        Me.broj = broj

        labelText.Text = oMSGIS.Trim.Substring(1, oMSGIS.Trim.Length - 2)

        If broj <= 3 Then
            bop1.Visible = True
            bop1.Text = oMSGARRAYBTEXT(0).Trim.Substring(1, oMSGARRAYBTEXT(0).Trim.Length - 2)
            bop1.Tag = oMSGARRAYSKIPTO(0)
        End If
        If broj >= 2 Then
            bop2.Visible = True
            bop2.Text = oMSGARRAYBTEXT(1).Trim.Substring(1, oMSGARRAYBTEXT(1).Trim.Length - 2)
            bop2.Tag = oMSGARRAYSKIPTO(1)
        End If
        If broj = 3 Then
            bop3.Visible = True
            bop3.Text = oMSGARRAYBTEXT(2).Trim.Substring(1, oMSGARRAYBTEXT(2).Trim.Length - 2)
            bop3.Tag = oMSGARRAYSKIPTO(2)
        End If
        bbop = ""

        Me.Width = 487 - (3 - broj) * bop3.Width
        Call SetLang()
    End Sub

    Private Sub SetLang()

        'Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")

    End Sub
    Private Sub bop1_Click(sender As Object, e As EventArgs) Handles bop1.Click
        'skip1
        bbop = bop1.Tag
        Me.Close()
    End Sub

    Private Sub bop2_Click(sender As Object, e As EventArgs) Handles bop2.Click
        'skip2
        bbop = bop2.Tag
        Me.Close()
    End Sub

    Private Sub bop3_Click(sender As Object, e As EventArgs) Handles bop3.Click
        'skip3
        bbop = bop3.Tag
        Me.Close()
    End Sub

    Private Sub FormOptionMSG_Load(sender As Object, e As EventArgs) Handles Me.Load

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
End Class