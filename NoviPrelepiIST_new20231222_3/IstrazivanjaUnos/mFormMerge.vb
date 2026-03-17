'Option Strict Off

Public Class mFormMerge
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
    Friend WithEvents txtN As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents chbC As CheckBox
    Friend WithEvents chbO As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtN = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.chbC = New System.Windows.Forms.CheckBox()
        Me.chbO = New System.Windows.Forms.CheckBox()
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
        Me.BtnFormat.Location = New System.Drawing.Point(587, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(95, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.TabStop = False
        Me.BtnFormat.Text = "Merge"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Merge cells"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 189)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(744, 30)
        Me.Panel1.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCancel.Location = New System.Drawing.Point(473, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 24)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(744, 25)
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
        Me.Label8.Size = New System.Drawing.Size(720, 18)
        Me.Label8.TabIndex = 333
        Me.Label8.Text = "Nsss"
        '
        'txtN
        '
        Me.txtN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtN.Location = New System.Drawing.Point(12, 69)
        Me.txtN.Name = "txtN"
        Me.txtN.Size = New System.Drawing.Size(125, 20)
        Me.txtN.TabIndex = 332
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label81.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label81.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label81.Location = New System.Drawing.Point(12, 135)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(720, 18)
        Me.Label81.TabIndex = 334
        Me.Label81.Text = "Nsss"
        '
        'txtN2
        '
        Me.txtN2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtN2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtN2.Location = New System.Drawing.Point(12, 157)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(125, 20)
        Me.txtN2.TabIndex = 335
        '
        'chbC
        '
        Me.chbC.AccessibleName = ""
        Me.chbC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbC.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbC.Location = New System.Drawing.Point(231, 70)
        Me.chbC.Name = "chbC"
        Me.chbC.Size = New System.Drawing.Size(302, 19)
        Me.chbC.TabIndex = 336
        Me.chbC.Text = "Only current "
        '
        'chbO
        '
        Me.chbO.AccessibleName = ""
        Me.chbO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbO.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbO.Location = New System.Drawing.Point(231, 95)
        Me.chbO.Name = "chbO"
        Me.chbO.Size = New System.Drawing.Size(302, 19)
        Me.chbO.TabIndex = 337
        Me.chbO.Text = "Other "
        '
        'mFormMerge
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(744, 219)
        Me.Controls.Add(Me.chbO)
        Me.Controls.Add(Me.chbC)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtN)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormMerge"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Merge"
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
        Me.AccessibleName = ""
        Me.ControlBox = False
        With Me
            '.TopMost = True
            .StartPosition = FormStartPosition.CenterScreen
        End With
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.what = what
        Me.dIst = dIst

    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        'GlavnaTabela +";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + CStr(Forma).Trim + ";" + CStr(p.rbr).Trim
        Me.txtN.Text = 1
        Me.txtN.Focus()
        Me.txtN.SelectAll()

        If what = "Row" Then
            Me.Label1.Text = Me.Label1.Text + " in row"
            Me.Label8.Text = "Number of cells on LEFT side that you want to merge with this cell"
            Me.Label81.Text = "Apply merging for next rows (separated with comma, or with - for from to)"
            Me.chbC.Text = "Only current row"
            Me.chbO.Text = "Other"
        Else
            Me.Label1.Text = Me.Label1.Text + " in column"
            Me.Label8.Text = "Number of cells BELLOW (DOWN) that you want to merge with this cell"
            Me.Label81.Text = "Apply merging for next columns (separated with comma, or with - for from to)"
            Me.chbC.Text = "Only current column"
            Me.chbO.Text = "Other"
        End If
        Me.chbC.Checked = True

        Me.Label81.Visible = False
        Me.txtN2.Visible = False

    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        If IsNumeric(Me.txtN.Text) AndAlso Me.txtN.Text <> "" Then
            Call fMerge()
        Else
            ISTMessageBox.Show("Must be numeric!")
            Me.txtN.Focus()
            Me.txtN.SelectAll()
        End If
    End Sub

    Sub fMerge()
        If Me.chbC.Checked = True Then Call fMergeC()

        If Me.chbO.Checked = True Then
            'Call fMergeC()
            Dim tN2() As String = {}
            If Me.txtN2.Text <> "" Then
                tN2 = gettNLR(txtN2.Text).Split(",")
                For i As Integer = 0 To tN2.GetUpperBound(0)
                    If IsNumeric(tN2(i)) AndAlso tN2(i).Trim <> "" Then Call fMergeC(tN2(i))
                Next
            Else
                ISTMessageBox.Show("Please enter!")
                Me.txtN2.Focus()
            End If
        End If
    End Sub

    Sub fMergeC(Optional ByVal RC As String = "")
        Dim br As Integer = Me.txtN.Text
        Dim trk() As String = pp(3).Split(".")
        If trk.Length = 3 Then
            'ako je tabela
            Dim t As Integer = CInt(trk(0).Trim)
            Dim r As Integer = CInt(trk(1).Trim)
            Dim k As Integer = CInt(trk(2).Trim)

            If RC <> "" Then   'nije current
                If what = "Row" Then
                    r = CInt(RC.Trim)
                Else
                    k = CInt(RC.Trim)
                End If
            End If

            'If k > 1 AndAlso k <= br Then br = k - 1

            If what = "Row" Then
                Dim odakle As Integer = k
                If odakle > 1 Then
                    Dim usw As Integer = 0
                    Dim sql As String = "select f3,case when wwidth='' then 100 else wwidth end As ww from vrepISTPolja where sifist='" + sifist + "' and tabela='" +
                        pp(0).Trim + "' and f1=" + CStr(t).Trim + " and f2=" + CStr(r).Trim + " and f3<=" + CStr(k).Trim + " order by f3;"
                    Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)

                    Dim b As Integer = 0
                    sql = ""
                    For i As Integer = odakle - 1 To 0 Step -1
                        sql = sql + nvrd + "update istpolja set vs='0'" +
                              " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and forma like '" + CStr(t).Trim + "." + CStr(r).Trim + "." + dt.Rows(i - 1).Item("f3").ToString.Trim + "';"
                        usw = usw + dt.Rows(i - 1).Item("ww").ToString.Trim
                        b = b + 1
                        If b = br Then Exit For
                    Next

                    Dim strpom As String = "select isnull(vs,100) as vs from istpolja where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and forma like '" + CStr(t).Trim + "." + CStr(r).Trim + "." + CStr(k).Trim + "';"
                    Dim dtpom As DataTable = izvrsiSQLvratiDT(strpom, Me.ISTConnectionString, Nothing)
                    Dim vspom As String = dtpom.Rows(0).Item("vs").ToString
                    Dim vs1 As String = "" : Dim vs2 As String = ""
                    Dim pppom() As String
                    If vspom = "" Then vspom = "100"
                    If vspom.IndexOf(";") > 0 Then
                        pppom = vspom.Split(";")
                        vs1 = CStr(CInt(pppom(0)) + usw).Trim
                        vs2 = pppom(1)
                        vspom = vs1 + ";" + vs2
                    Else
                        vs1 = CStr(CInt(vspom) + usw).Trim
                        vs2 = ""
                        vspom = vs1
                    End If

                    sql = sql + nvrd + "update istpolja set vs='" + vspom + "' " +
                              " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and forma like '" + CStr(t).Trim + "." + CStr(r).Trim + "." + CStr(k).Trim + "';"

                    Dim p2 As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sql)
                    If p2 = "nok" Then ISTMessageBox.Show("Error") Else Me.Close()
                Else
                    Me.Close()
                End If
            End If

            If what = "Column" Then
                Dim ush As Integer = 0
                Dim sql As String = "select f2, hheight as hh from vrepISTPolja where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and f1=" + CStr(t).Trim + " and f2>=" + CStr(r).Trim + " and f3=" + CStr(k).Trim + ""
                Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)

                If br > dt.Rows.Count - 1 Then br = dt.Rows.Count - 1

                For i As Integer = 0 To br
                    ush = ush + dt.Rows(i).Item("hh").ToString.Trim
                Next
                ush = ush + br
                sql = " update a set a.vs=ltrim(rtrim(isnull(b.wwidth,100)))+';'+'" + CStr(ush).Trim + "'" +
                             " from istpolja A inner Join vrepistpolja b on a.sifist=b.sifist and a.tabela=b.tabela And a.polje=b.polje And a.vod=b.vod" +
                             " where a.sifist ='" + sifist + "' and a.tabela='" + pp(0).Trim + "' and a.forma like '" + CStr(t).Trim + "." + CStr(r).Trim + "." + CStr(k).Trim + "'" + nvrd
                Dim p2 As String = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sql)
                If p2 = "nok" Then ISTMessageBox.Show("Error") Else Me.Close()
            End If

        End If

    End Sub

    Private Sub chbC_CheckedChanged(sender As Object, e As EventArgs) Handles chbC.CheckedChanged
        If chbC.Checked = True Then
            chbO.Checked = False
            Me.Label81.Visible = False
            Me.txtN2.Visible = False
        Else
            chbO.Checked = True
            Me.Label81.Visible = True
            Me.txtN2.Visible = True
        End If
    End Sub

    Private Sub chbO_CheckedChanged(sender As Object, e As EventArgs) Handles chbO.CheckedChanged
        If chbO.Checked = True Then
            chbC.Checked = False
            Me.Label81.Visible = True
            Me.txtN2.Visible = True
        Else
            chbC.Checked = True
            Me.Label81.Visible = False
            Me.txtN2.Visible = False
        End If
    End Sub

    Function gettNLR(ByVal txt As String) As String
        txt = txt.Replace(";", ",")
        gettNLR = ""
        If txt <> "" Then
            Dim kon As String = ""
            Dim pp() As String = txt.Split(",")
            For i As Integer = 0 To pp.GetUpperBound(0)
                If pp(i) <> "" AndAlso pp(i).IndexOf("-") > 0 Then
                    Dim ip() As String = pp(i).Split("-")
                    If IsNumeric(ip(0).Trim) AndAlso IsNumeric(ip(1).Trim) Then
                        For m As Integer = CInt(ip(0)) To CInt(ip(1))
                            kon = kon + CStr(m).Trim + ","
                        Next
                    End If
                ElseIf pp(i) <> "" AndAlso pp(i).IndexOf("-") <= 0 Then
                    If IsNumeric(pp(i)) Then kon = kon + pp(i) + ","
                ElseIf pp(i) = "" Then
                End If
            Next
            gettNLR = kon.TrimEnd(",")
        End If
        'AndAlso txt.IndexOf("-") > 0
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.AccessibleName = "cancel"
        Me.Close()
    End Sub
End Class

''Option Strict Off

'Public Class mFormMerge
'    Inherits FormTemplate

'#Region " Windows Form Designer generated code "

'    Public Sub New()
'        MyBase.New()

'        'This call is required by the Windows Form Designer.
'        InitializeComponent()

'        'Add any initialization after the InitializeComponent() call

'    End Sub

'    'Form overrides dispose to clean up the component list.
'    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
'        If disposing Then
'            If Not (components Is Nothing) Then
'                components.Dispose()
'            End If
'        End If
'        MyBase.Dispose(disposing)
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.
'    'Do not modify it using the code editor.
'    Friend WithEvents BtnFormat As System.Windows.Forms.Button
'    Friend WithEvents pb1 As System.Windows.Forms.PictureBox
'    Friend WithEvents Label1 As System.Windows.Forms.Label
'    Friend WithEvents Label8 As Label
'    Friend WithEvents txtN As TextBox
'    Friend WithEvents Panel1 As System.Windows.Forms.Panel
'    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
'        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mFormMerge))
'        Me.BtnFormat = New System.Windows.Forms.Button()
'        Me.Label1 = New System.Windows.Forms.Label()
'        Me.Panel1 = New System.Windows.Forms.Panel()
'        Me.pb1 = New System.Windows.Forms.PictureBox()
'        Me.Label8 = New System.Windows.Forms.Label()
'        Me.txtN = New System.Windows.Forms.TextBox()
'        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
'        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.Panel1.SuspendLayout()
'        CType(Me.pb1, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'BtnFormat
'        '
'        Me.BtnFormat.BackColor = System.Drawing.SystemColors.ActiveCaption
'        Me.BtnFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
'        Me.BtnFormat.Font = New System.Drawing.Font("Verdana", 8.0!)
'        Me.BtnFormat.Location = New System.Drawing.Point(377, 2)
'        Me.BtnFormat.Name = "BtnFormat"
'        Me.BtnFormat.Size = New System.Drawing.Size(95, 24)
'        Me.BtnFormat.TabIndex = 1
'        Me.BtnFormat.TabStop = False
'        Me.BtnFormat.Text = "Merge"
'        Me.BtnFormat.UseVisualStyleBackColor = False
'        '
'        'Label1
'        '
'        Me.Label1.AutoSize = True
'        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
'        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
'        Me.Label1.Location = New System.Drawing.Point(12, 6)
'        Me.Label1.Name = "Label1"
'        Me.Label1.Size = New System.Drawing.Size(81, 13)
'        Me.Label1.TabIndex = 16
'        Me.Label1.Text = "Merge cells"
'        '
'        'Panel1
'        '
'        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
'        Me.Panel1.Controls.Add(Me.BtnFormat)
'        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
'        Me.Panel1.Location = New System.Drawing.Point(0, 133)
'        Me.Panel1.Name = "Panel1"
'        Me.Panel1.Size = New System.Drawing.Size(480, 30)
'        Me.Panel1.TabIndex = 38
'        '
'        'pb1
'        '
'        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
'        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
'        Me.pb1.Location = New System.Drawing.Point(0, 0)
'        Me.pb1.Name = "pb1"
'        Me.pb1.Size = New System.Drawing.Size(480, 25)
'        Me.pb1.TabIndex = 14
'        Me.pb1.TabStop = False
'        '
'        'Label8
'        '
'        Me.Label8.BackColor = System.Drawing.SystemColors.ControlLight
'        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
'        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
'        Me.Label8.Location = New System.Drawing.Point(12, 39)
'        Me.Label8.Name = "Label8"
'        Me.Label8.Size = New System.Drawing.Size(460, 18)
'        Me.Label8.TabIndex = 333
'        Me.Label8.Text = "Nsss"
'        '
'        'txtN
'        '
'        Me.txtN.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
'        Me.txtN.Location = New System.Drawing.Point(12, 69)
'        Me.txtN.Name = "txtN"
'        Me.txtN.Size = New System.Drawing.Size(125, 20)
'        Me.txtN.TabIndex = 332
'        '
'        'mFormMerge
'        '
'        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
'        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
'        Me.ClientSize = New System.Drawing.Size(480, 163)
'        Me.Controls.Add(Me.Label8)
'        Me.Controls.Add(Me.txtN)
'        Me.Controls.Add(Me.Panel1)
'        Me.Controls.Add(Me.Label1)
'        Me.Controls.Add(Me.pb1)
'        Me.HelpButton = False
'        
'        Me.MaximizeBox = False
'        Me.MinimizeBox = False
'        Me.Name = "mFormMerge"
'        Me.HP.SetShowHelp(Me, False)
'        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
'        Me.Text = "Merge"
'        Me.TopMost = True
'        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
'        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.Panel1.ResumeLayout(False)
'        CType(Me.pb1, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)
'        Me.PerformLayout()

'    End Sub

'#End Region
'    Private _parentForm As Form
'    Dim sifist As String
'    Dim ISTConnectionString As String
'    Dim DBConnectionString As String
'    Dim what As String
'    Dim pp() As String
'    Dim ISTDB As Boolean
'    Dim IST As Boolean

'    Public Sub New(ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal what As String)
'        InitializeComponent()
'        _parentForm = form
'        With Me
'            .TopMost = True
'            .StartPosition = FormStartPosition.CenterScreen
'        End With
'        Me.sifist = sifist
'        Me.ISTConnectionString = ISTConnectionString
'        Me.DBConnectionString = DBConnectionString
'        Me.what = what
'    End Sub
'    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
'        Me.pp = Me.Tag.split(";")
'        'GlavnaTabela +";" + tValidFrom + ";" + tbox.Name.Substring(2) + ";" + CStr(Forma).Trim + ";" + CStr(p.rbr).Trim
'        Me.txtN.Text = 1
'        Me.txtN.Focus()
'        Me.txtN.SelectAll()

'        If what = "Row" Then
'            Me.Label1.Text = Me.Label1.Text + " in row"
'            Me.Label8.Text = "Number of cells on LEFT side that you want to merge with this cell"
'        Else
'            Me.Label1.Text = Me.Label1.Text + " in columns"
'            Me.Label8.Text = "Number of cells bellow (down) that you want to merge with this cell"
'        End If

'    End Sub

'    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
'        If IsNumeric(Me.txtN.Text) AndAlso Me.txtN.Text <> "" Then
'            Call fMerge()
'        Else
'            ISTMessageBox.Show("Must be numeric!")
'            Me.txtN.Focus()
'            Me.txtN.SelectAll()
'        End If
'    End Sub
'    Sub fMerge()
'        Dim br As Integer = Me.txtN.Text
'        Dim trk() As String = pp(3).Split(".")
'        If trk.Length = 3 Then
'            'ako je tabela
'            Dim t As Integer = CInt(trk(0).Trim)
'            Dim r As Integer = CInt(trk(1).Trim)
'            Dim k As Integer = CInt(trk(2).Trim)
'            If k > 1 AndAlso k <= br Then br = k - 1

'            If what = "Row" Then
'                Dim odakle As Integer = k
'                If odakle > 1 Then
'                    Dim usw As Integer = 0
'                    Dim sql As String = "select f3,wwidth as ww from vrepISTPolja where sifist='" + sifist + "' and tabela='" +
'                        pp(0).Trim + "' and f1=" + CStr(t).Trim + " and f2=" + CStr(r).Trim + " and f3<=" + CStr(k).Trim + " order by f3"
'                    Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)

'                    Dim b As Integer = 0
'                    sql = ""
'                    For i As Integer = odakle - 1 To 0 Step -1
'                        sql = sql + "update istpolja set vs='0'" +
'                              " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and forma like '" + CStr(t).Trim + "." + CStr(r).Trim + "." + dt.Rows(i - 1).Item("f3").ToString.Trim + "'"
'                        usw = usw + dt.Rows(i - 1).Item("ww").ToString.Trim
'                        b = b + 1
'                        If b = br Then Exit For
'                    Next

'                    sql = sql + "update istpolja set vs=vs+" + CStr(usw).Trim + "" +
'                              " where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and forma like '" + CStr(t).Trim + "." + CStr(r).Trim + "." + CStr(k).Trim + "'"

'                    Dim p2 As String = izvrsiSQL(sql, Me.ISTConnectionString)
'                    If p2 = "nok" Then ISTMessageBox.Show("Error") Else Me.Close()
'                Else
'                    Me.Close()
'                End If

'            End If

'            If what = "Column" Then
'                Dim ush As Integer = 0
'                Dim sql As String = "select f2,hheight as hh from vrepISTPolja where sifist='" + sifist + "' and tabela='" + pp(0).Trim + "' and f1=" + CStr(t).Trim + " and f2>=" + CStr(r).Trim + " and f3=" + CStr(k).Trim + ""
'                Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)

'                If br > dt.Rows.Count - 1 Then br = dt.Rows.Count - 1

'                For i As Integer = 0 To br
'                    ush = ush + dt.Rows(i).Item("hh").ToString.Trim
'                Next
'                ush = ush + br
'                sql = " update a set a.vs=ltrim(rtrim(b.wwidth))+';'+'" + CStr(ush).Trim + "'" +
'                             " from istpolja A inner Join vrepistpolja b on a.tabela=b.tabela And a.polje=b.polje And a.vod=b.vod" +
'                             " where a.sifist ='" + sifist + "' and a.tabela='" + pp(0).Trim + "' and a.forma like '" + CStr(t).Trim + "." + CStr(r).Trim + "." + CStr(k).Trim + "'" + nvrd
'                Dim p2 As String = izvrsiSQL(sql, Me.ISTConnectionString)
'                If p2 = "nok" Then ISTMessageBox.Show("Error") Else Me.Close()
'            End If

'        End If

'    End Sub

'End Class