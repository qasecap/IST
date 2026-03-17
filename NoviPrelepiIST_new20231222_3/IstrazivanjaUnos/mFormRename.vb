'Option Strict Off

Imports System.Web
Imports Microsoft.Office.Interop.Word

Public Class mFormRename
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCN As System.Windows.Forms.TextBox
    Friend WithEvents txtNN As System.Windows.Forms.TextBox
    Friend WithEvents lblMSG As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents onlyinIST As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.txtNN = New System.Windows.Forms.TextBox()
        Me.lblMSG = New System.Windows.Forms.Label()
        Me.onlyinIST = New System.Windows.Forms.CheckBox()
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
        Me.BtnFormat.Location = New System.Drawing.Point(230, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(95, 24)
        Me.BtnFormat.TabIndex = 1
        Me.BtnFormat.TabStop = False
        Me.BtnFormat.Text = "Rename"
        Me.BtnFormat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Rename"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 227)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 30)
        Me.Panel1.TabIndex = 38
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnCancel.Location = New System.Drawing.Point(117, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 24)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'pb1
        '
        Me.pb1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.pb1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(343, 25)
        Me.pb1.TabIndex = 14
        Me.pb1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 23)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Current name"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 23)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "New name"
        '
        'txtCN
        '
        Me.txtCN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCN.Enabled = False
        Me.txtCN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCN.Location = New System.Drawing.Point(12, 80)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(313, 21)
        Me.txtCN.TabIndex = 281
        '
        'txtNN
        '
        Me.txtNN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNN.Location = New System.Drawing.Point(12, 155)
        Me.txtNN.Name = "txtNN"
        Me.txtNN.Size = New System.Drawing.Size(313, 21)
        Me.txtNN.TabIndex = 284
        '
        'lblMSG
        '
        Me.lblMSG.AutoSize = True
        Me.lblMSG.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSG.ForeColor = System.Drawing.Color.Red
        Me.lblMSG.Location = New System.Drawing.Point(11, 197)
        Me.lblMSG.Name = "lblMSG"
        Me.lblMSG.Size = New System.Drawing.Size(56, 12)
        Me.lblMSG.TabIndex = 10000014
        Me.lblMSG.Text = "................."
        Me.lblMSG.Visible = False
        '
        'onlyinIST
        '
        Me.onlyinIST.AutoSize = True
        Me.onlyinIST.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.onlyinIST.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.onlyinIST.Location = New System.Drawing.Point(15, 31)
        Me.onlyinIST.Name = "onlyinIST"
        Me.onlyinIST.Size = New System.Drawing.Size(85, 17)
        Me.onlyinIST.TabIndex = 10000015
        Me.onlyinIST.Tag = ""
        Me.onlyinIST.Text = "only in IST"
        Me.onlyinIST.UseVisualStyleBackColor = True
        '
        'mFormRename
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(343, 257)
        Me.Controls.Add(Me.onlyinIST)
        Me.Controls.Add(Me.lblMSG)
        Me.Controls.Add(Me.txtNN)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormRename"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rename"
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
    Dim pp() As String
    Dim ISTDB As Boolean
    Dim dIst As DatasetIstrazivanja

    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String)
        InitializeComponent()
        _parentForm = form
        Me.AccessibleName = ""
        Me.ControlBox = False
        With Me
            If tvRight - Me.Width - 20 < 0 Then
                .Left = 20
            Else
                .Left = tvRight - Me.Width - 20
            End If
            .Top = tvTop + 30
        End With
        Me.sifist = sifist
        Me.dIst = dIst
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.pp = Me.Tag.split(";")
        If Me.AccessibleDescription = "fp" Then
            ISTDB = False
            onlyinIST.Checked = True
        Else
            ISTDB = True
            onlyinIST.Checked = False
        End If
        Me.txtCN.Text = pp(2).Trim
        Me.txtNN.Focus()
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click

        Dim strDB As String = "" : Dim strIST As String = ""
        Dim sqlDBDropTip As String = "" : Dim DropTip As String = ""
        Dim strW As String = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                "' and polje=N'" + Me.txtCN.Text + "'" +
                "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        Dim strWProvera As String = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                "' and polje=N'" + Me.txtNN.Text + "'" +
                "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        Dim pIST As String = "" : Dim pDB As String = "ok"

        Dim strProvera As String = "select polje from istpolja " + strWProvera
        Dim dtprovera As System.Data.DataTable = izvrsiSQLvratiDT(strProvera, Me.ISTConnectionString, Nothing)
        If dtprovera.Rows.Count > 0 Then
            ISTMessageBox.Show("Error. Name already exists in IST!")
            Me.txtNN.Focus()
        Else
            strIST = " update istpolja set polje=N'" + txtNN.Text + "'" + nvrd + strW
            strIST = strIST + " update istawls set polje=N'" + txtNN.Text + "'" + nvrd + strW

            If onlyinIST.Checked = True OrElse ISTDB = False Then
                Try
                    pIST = dodajuIST(pIST, strIST)
                    If pIST = "ok" Then
                        Me.Close()
                    End If
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    ISTMessageBox.Show(ex.Message)
                End Try
            Else
                Try
                    Me.Cursor = Cursors.WaitCursor

                    pDB = "ok"
                    If ISTDB = True Then
                        strDB = " exec sp_rename N'" + pp(0).Trim + "." + txtCN.Text.Trim + "', N'" + txtNN.Text.Trim + "','COLUMN';"
                        pDB = izvrsiSQL(strDB, Me.DBConnectionString)
                        sqlDBDropTip = "exec sp_rename N'" + pp(0).Trim + "." + txtNN.Text.Trim + "', N'" + txtCN.Text.Trim + "','COLUMN';"
                        DropTip = "RENAME"
                        If pDB = "ok" Then
                            pIST = dodajuIST(pIST, strIST, sqlDBDropTip, DropTip)
                        Else
                            Dim ppp As DialogResult = ISTMessageBox.Show("Column already exists in DB." + nvrd + nvrd + "Do you want rename only in IST?", "Error. DB is NOT updated!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                            Select Case ppp
                                Case DialogResult.OK
                                    pIST = dodajuIST(pIST, strIST)
                                    If pIST = "ok" Then
                                        Me.Cursor = Cursors.Default
                                        Me.Close()
                                    End If
                                Case DialogResult.Cancel
                            End Select
                        End If
                    End If

                    If ISTDB = False Then
                        pIST = dodajuIST(pIST, strIST)
                    End If

                    Me.Cursor = Cursors.Default

                    If pDB = "ok" AndAlso pIST = "ok" Then
                        Me.Close()
                    End If
                Catch ex As Exception
                    Me.Cursor = Cursors.Default
                    ISTMessageBox.Show(ex.Message)
                End Try
            End If
        End If

    End Sub

    Function dodajuIST(ByVal pIST As String, ByVal strIST As String, Optional sqlDBDropTip As String = "", Optional DropTip As String = "") As String

        'dodaje polje u IST
        Dim strist2 As String = promenaOstalaPolja("OD")
        strist2 = strist2 + promenaOstalaPolja("DO")
        strist2 = strist2 + promenaOstalaPolja("IZRAZ")
        strist2 = strist2 + promenaOstalaLK("GRESKA")

        strIST = strIST + strist2

        pIST = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, strIST,, sqlDBDropTip, DropTip)

        If pIST = "nok" Then
            Dim por As String = "Error. IST is NOT updated!" + nvrd + nvrd + "Field already exists!" + nvrd + nvrd +
                                "_ISTTablesColumns, validatingEvent is NOT updated!" + nvrd + nvrd +
                                "_ISTTablesColumns, enterEvent is NOT updated!" + nvrd + nvrd +
                                "_ISTTablesColumns, columnAtributes is NOT updated!" + nvrd + nvrd +
                                "_ISTRulesDataValidation, error is NOT updated!"
            ISTMessageBox.Show(por)
        End If

        Return pIST

    End Function

    Function promenaOstalaPolja(ByVal sta As String) As String
        promenaOstalaPolja = ""
        Dim strpom As String = "select polje,isnull(" + sta + ",'') as " + sta + " from istpolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and " + sta + " like N'%" + Me.txtCN.Text + "%'"
        Dim dtpom As System.Data.DataTable = izvrsiSQLvratiDT(strpom, ISTConnectionString, Nothing)
        If dtpom.Rows.Count > 0 Then
            For i As Integer = 0 To dtpom.Rows.Count - 1
                Dim odpom As String = dtpom.Rows(i).Item(sta).ToString.Trim
                If odpom <> "" Then
                    Dim bbb() As String = razkvantaj(odpom)
                    For j As Integer = 0 To bbb.GetUpperBound(0)
                        If bbb(j).Trim.ToUpper = Me.txtCN.Text.Trim.ToUpper Then bbb(j) = Me.txtNN.Text
                    Next
                    Dim zzz As String = ustringaj(bbb)
                    zzz = zzz.Replace("'", "''")
                    promenaOstalaPolja = promenaOstalaPolja + "update istpolja set " + sta + "='" + zzz + "'  where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and polje=N'" + dtpom.Rows(i).Item("polje").ToString.Trim + "';" + nvrd
                End If
            Next
        End If
    End Function

    Function promenaOstalaLK(ByVal sta As String) As String
        promenaOstalaLK = ""
        Dim strpom As String = "select tabela,rbrgreske,isnull(" + sta + ",'') as " + sta + " from istlk where sifist=N'" + sifist + "' and " + sta + " like N'%" + Me.txtCN.Text + "%'"
        Dim dtpom As System.Data.DataTable = izvrsiSQLvratiDT(strpom, ISTConnectionString, Nothing)
        If dtpom.Rows.Count > 0 Then
            For i As Integer = 0 To dtpom.Rows.Count - 1
                Dim odpom As String = dtpom.Rows(i).Item(sta).ToString.Trim
                If odpom <> "" Then
                    Dim bbb() As String = razkvantaj(odpom)
                    For j As Integer = 0 To bbb.GetUpperBound(0)
                        If bbb(j).Trim.ToUpper = Me.txtCN.Text.Trim.ToUpper Then bbb(j) = Me.txtNN.Text
                    Next
                    Dim zzz As String = ustringaj(bbb)
                    zzz = zzz.Replace("'", "''")
                    promenaOstalaLK = promenaOstalaLK + "update istlk set " + sta + "='" + zzz + "'  where sifist=N'" + sifist + "' and tabela=N'" + dtpom.Rows(i).Item("tabela").ToString.Trim + "' and polje=N'" + dtpom.Rows(i).Item("rbrgreske").ToString.Trim + "';" + nvrd
                End If
            Next
        End If
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.AccessibleName = "cancel"
        Me.Close()
    End Sub
End Class