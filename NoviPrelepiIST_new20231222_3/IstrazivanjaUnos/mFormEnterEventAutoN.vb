'Option Strict Off

Public Class mFormEnterEventAutoN
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
    Friend WithEvents btn As System.Windows.Forms.Button

    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtANT As TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtANT = New System.Windows.Forms.TextBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btn.Location = New System.Drawing.Point(377, 2)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(95, 24)
        Me.btn.TabIndex = 1
        Me.btn.Text = "Set"
        Me.btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "AutoNumber to"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(480, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(460, 18)
        Me.Label8.TabIndex = 333
        Me.Label8.Text = "Auto Number To"
        '
        'txtANT
        '
        Me.txtANT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtANT.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtANT.Location = New System.Drawing.Point(12, 69)
        Me.txtANT.Name = "txtANT"
        Me.txtANT.Size = New System.Drawing.Size(460, 20)
        Me.txtANT.TabIndex = 332
        '
        'mFormEnterEventAutoN
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(480, 163)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtANT)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormEnterEventAutoN"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "On Enter Event"
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
    Dim gde As String
    Dim pp() As String
    Dim ISTDB As Boolean
    Dim IST As Boolean
    Dim what As String
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal gde As String, ByVal what As String)
        InitializeComponent()
        _parentForm = form
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.dIst = dIst
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")

        Dim dt As System.Data.DataTable = getDTC()
        If dt.Rows.Count = 1 Then
            Call getVariablesC(dt)
            Try

                getMetaDataPane()
            Catch ex As Exception
                ISTMessageBox.Show(ex.Message)
            End Try
        End If
        Dim strSQl As String = "select polje as displaymember,polje as valuemember from ISTPolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' order by polje"
        Me.Label1.Text = "On Enter event for field " + pp(2).Trim + "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim + "     AutoNumber To"
    End Sub

    Dim enterEvent As String = ""
    Dim enterEventOst As String = ""

    Function getDTC() As System.Data.DataTable
        enterEvent = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select DO " +
                " from vrepISTPolja " +
                " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim + "' and pp<>'fp' and pp<>'lbl' and pp<>'dgv' and pp<>'button'  " +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        enterEvent = dt.Rows(0).Item("od").ToString.Trim
    End Sub

    Sub getMetaDataPane()
        enterEventOst = ""
        'izrazZADGV
        If enterEvent = "" Then Exit Sub
        enterEvent = enterEvent.Replace(vbCrLf, "").Replace("#{", "").Trim
        If enterEvent.Substring(enterEvent.Length - 1, 1) = "}" Then enterEvent = enterEvent.Substring(0, enterEvent.Length - 1)

        Dim pp() As String = enterEvent.Split(";")

        Dim readonlyif() As String = {}
        Dim readonlyis() As String = {}

        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Length > 10 AndAlso pp(i).Trim.ToUpper.IndexOf("AUTONUMBERTO") = 0 Then
                pp(i) = pp(i).Trim.ToUpper.Replace("AUTONUMBERTO=", "")
                Dim ant() As String = pp(i).Split(".")
                If ant.Length = 2 Then
                    txtANT.Text = ant(0) + "." + ant(1)
                Else
                    txtANT.Text = ant(0)
                End If
            ElseIf pp(i).Trim <> "" Then
                enterEventOst = enterEventOst + pp(i) + ";"
            End If
        Next

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim kkon As String = ""

        If txtANT.Text <> "" Then
            kkon = "autonumberto=" + txtANT.Text + ";"
            Dim sql As String = "update istpolja set DO=N'#{" + enterEventOst + ";" + kkon + "}'" +
            " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + pp(2).Trim +
            "' and  rbr='" + pp(4).Trim + "'"


            Dim p2 As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sql)
            If p2 = "nok" Then ISTMessageBox.Show("Error") Else Me.Close()
        End If

        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim

    End Sub

End Class