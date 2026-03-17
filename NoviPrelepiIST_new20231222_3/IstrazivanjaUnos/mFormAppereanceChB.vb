'Option Strict Off
Public Class mFormAppereanceChB
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
    Friend WithEvents gbOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cb2 As System.Windows.Forms.CheckBox
    Friend WithEvents cb1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chbTL As CheckBox
    Friend WithEvents chbTR As CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbTL = New System.Windows.Forms.CheckBox()
        Me.chbTR = New System.Windows.Forms.CheckBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnFormat
        '
        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtnFormat.Location = New System.Drawing.Point(351, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(108, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.Text = "Set appereance"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "CheckBox"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(476, 30)
        Me.Panel1.TabIndex = 38
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(476, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Location = New System.Drawing.Point(3, 31)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(185, 77)
        Me.gbOptions.TabIndex = 40
        Me.gbOptions.TabStop = False
        '
        'cb2
        '
        Me.cb2.AccessibleDescription = " "
        Me.cb2.AutoSize = True
        Me.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb2.Location = New System.Drawing.Point(12, 40)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(101, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Multiresponse"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb1.Location = New System.Drawing.Point(12, 17)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(124, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Simple CheckBox"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Appereance"
        '
        'chbTL
        '
        Me.chbTL.AccessibleName = ""
        Me.chbTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbTL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTL.Location = New System.Drawing.Point(15, 157)
        Me.chbTL.Name = "chbTL"
        Me.chbTL.Size = New System.Drawing.Size(377, 19)
        Me.chbTL.TabIndex = 263
        Me.chbTL.Text = "Label on the left side of the checkbox (default)"
        '
        'chbTR
        '
        Me.chbTR.AccessibleName = ""
        Me.chbTR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbTR.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTR.Location = New System.Drawing.Point(14, 182)
        Me.chbTR.Name = "chbTR"
        Me.chbTR.Size = New System.Drawing.Size(296, 19)
        Me.chbTR.TabIndex = 262
        Me.chbTR.Text = "Label on the right side of the checkbox "
        '
        'mFormAppereanceChB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(476, 398)
        Me.Controls.Add(Me.chbTL)
        Me.Controls.Add(Me.chbTR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormAppereanceChB"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Appereance"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbOptions.ResumeLayout(False)
        Me.gbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private _parentForm As Form
    Dim sifist As String
    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim pp() As String
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String)
        InitializeComponent()
        _parentForm = form
        With Me
            If tvRight - Me.Width - 20 < 0 Then
                .Left = 20
            Else
                .Left = tvRight - Me.Width - 20
            End If
            .Top = tvTop + 30
        End With

        Me.dIst = dIst
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cb1.Checked = True
        Me.pp = Me.Tag.split(";")
        Me.Label1.Text = "CheckBox " + pp(2).Trim + "    Type: " + CStr(pp(5)).Trim + ", MaxLength= " + CStr(pp(6)).Trim
    End Sub

    Dim izraz As String = ""

    Function getDTC() As System.Data.DataTable

        izraz = ""
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select  izraz " +
                " from vrepISTPolja " +
                " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and polje='" + pp(2).Trim + "'" +
                " and cast (vod as date)='" + Convert.ToDateTime(pp(1).Trim).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        getDTC = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Function getDTCtabela(ByVal strW As String) As System.Data.DataTable
        'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
        Dim strSQl As String = "select polje,vod,izraz from vrepISTPolja " + strW
        getDTCtabela = izvrsiSQLvratiDT(strSQl, ISTConnectionString, Nothing)
    End Function

    Sub getVariablesC(ByVal dt As System.Data.DataTable)
        izraz = dt.Rows(0).Item("izraz").ToString.Trim
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked = True Then
            cb2.Checked = False

            Me.pp = Me.Tag.split(";")
            Dim dt As System.Data.DataTable = getDTC()
            If dt.Rows.Count = 1 Then
                Call getVariablesC(dt)
                Try
                    Call getMetaDataPaneP3()
                Catch ex As Exception
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        If cb2.Checked = True Then
            cb1.Checked = False
        End If
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        Dim pizraz As String = ""
        Dim popis As String = ""
        Dim strU As String = "update istpolja "
        Dim strS As String = ""
        Dim strI As String = ""
        Dim strW As String = ""

        Dim trk() As String = pp(3).Split(".")

        Try
            Me.Cursor = Cursors.WaitCursor
            'mnu02.Tag = GlavnaTabela + ";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + Str(Forma).Trim + ";" + Str(p.rbr).Trim
            Dim strIST As String = ""
            If cb2.Checked = True Then
                'grupa checkbox
            End If

            If cb1.Checked = True Then
                'simple checkbox
                strW = " where sifist='" + sifist + "' and tabela='" + pp(0).Trim +
                    "' and polje='" + pp(2).Trim + "'" +
                    "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
                'cell/filed
                strS = ""
                pizraz = setMetaDataPaneP3()
                If pizraz.Trim <> "" Then strS = " izraz=N'" + pizraz + "'"
                strIST = " update istpolja set" + nvrd + strS.TrimStart(",") + nvrd + strW + ";" + nvrd
            End If

            Dim pI As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strIST)
            If pI = "ok" Then
                ISTMessageBox.Show("Please refresh!")
                Me.Cursor = Cursors.Default
                Me.Close()
            End If
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Function getrbr(ByVal sqlrbr As String) As String
        Dim dt1 As DataTable = izvrsiSQLvratiDT(sqlrbr, Me.ISTConnectionString, Nothing)
        If Not dt1 Is Nothing AndAlso dt1.Rows.Count > 0 Then
            getrbr = dt1.Rows(0).Item(0).ToString
        Else
            getrbr = "0"
        End If
    End Function

    Sub getMetaDataPaneP3()

        If izraz.Trim.ToUpper.IndexOf("CHECKBOXR") >= 0 Then
            chbTR.Checked = True
            chbTL.Checked = False
        Else
            chbTR.Checked = False
            chbTL.Checked = True
        End If

    End Sub

    Function setMetaDataPaneP3() As String
        Dim pom As String
        If chbTR.Checked = True Then
            pom = "CheckBoxR"
        Else
            pom = "CheckBoxL"
        End If

        Return pom
    End Function

    'Function getttt(ByVal text As String, ByVal what As String) As String
    '    getttt = ""
    '    If text.Trim.ToUpper.IndexOf(what) >= 0 Then
    '        Dim b As Integer = text.Trim.ToUpper.IndexOf(what)
    '        getttt = text.Trim.ToUpper.Substring(b + what.Length)
    '    End If
    'End Function

    Private Sub chbTL_CheckedChanged(sender As Object, e As EventArgs) Handles chbTL.CheckedChanged
        If chbTL.Checked = True Then chbTR.Checked = False
    End Sub

    Private Sub chbTR_CheckedChanged(sender As Object, e As EventArgs) Handles chbTR.CheckedChanged
        If chbTR.Checked = True Then chbTL.Checked = False
    End Sub

End Class