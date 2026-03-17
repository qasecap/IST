'Option Strict Off

Public Class mFormFormatConvertLinkLabel
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
    Friend WithEvents BtnFormat As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtVS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(248, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(95, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.TabStop = False
        Me.BtnFormat.Text = "Insert"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "LinkLabel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(358, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(358, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(26, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 18)
        Me.Label8.TabIndex = 333
        Me.Label8.Text = "Apperance"
        '
        'txtVS
        '
        Me.txtVS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtVS.Location = New System.Drawing.Point(69, 76)
        Me.txtVS.Name = "txtVS"
        Me.txtVS.Size = New System.Drawing.Size(125, 20)
        Me.txtVS.TabIndex = 332
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 331
        Me.Label2.Text = "Width"
        '
        'mFormFormatConvertLinkLabel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(358, 163)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtVS)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormFormatConvertLinkLabel"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "LinkLabel"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim what As String
    Dim pp() As String
    Dim ISTDB As Boolean
    Dim IST As Boolean
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.what = what
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")

        Me.Text = Me.what

        If Me.what.Trim.ToUpper = "CONVERT" Then
            Me.Label1.Text = Me.what + " to LinkLabel"
        ElseIf Me.what.Trim.ToUpper = "FORMAT" Then
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    getMetaDataPaneP1()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
            Me.Label1.Text = Me.what + " LinkLabel"
        End If

    End Sub

    Dim cDO As String = ""
    Dim vs As String = ""

    Function getDTC() As System.Data.DataTable
        cDO = ""
        vs = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select vs" +
                " from ISTPolja " +
                " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "' and izraz like '%LinkLabel%'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        vs = dt.Rows(0).Item("vs").ToString.Trim
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        Call fformatConvert()
    End Sub

    Sub fformatConvert()

        Dim sqlIST As String = ""
        Dim ppolje As String = pp(2).Trim
        Dim rrbr As String = pp(4).Trim
        Dim p2 As String = ""
        Dim pvs As String = ""
        If txtVS.Text.Trim <> "" Then pvs = txtVS.Text.Trim

        sqlIST = "update istpolja set" + nvrd +
                " vs='" + pvs + "',izraz='LinkLabel'" +
                " where sifist ='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "' and rbr ='" + pp(4).Trim + "'"
        p2 = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlIST)
        If p2 = "nok" Then ISTMessageBox.Show("Error!") Else Me.Close()

    End Sub

    Sub getMetaDataPaneP1()
        If vs.Trim <> "" Then Me.txtVS.Text = vs
    End Sub

End Class