Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Windows.Forms

Public Class mFormRenameTC
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCN As TextBox
    Friend WithEvents txtNN As TextBox
    Friend WithEvents lblMSG As Label
    Friend WithEvents gbOptions As GroupBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents cb1 As CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mFormRenameTC))
        Me.BtnFormat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.txtNN = New System.Windows.Forms.TextBox()
        Me.lblMSG = New System.Windows.Forms.Label()
        Me.gbOptions = New System.Windows.Forms.GroupBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.cb1 = New System.Windows.Forms.CheckBox()
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
        Me.BtnFormat.Location = New System.Drawing.Point(193, 3)
        Me.BtnFormat.Name = "BtnFormat"
        Me.BtnFormat.Size = New System.Drawing.Size(132, 24)
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
        Me.Panel1.Controls.Add(Me.BtnFormat)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 296)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 30)
        Me.Panel1.TabIndex = 38
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
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 23)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Current name"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 23)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "New name"
        '
        'txtCN
        '
        Me.txtCN.Enabled = False
        Me.txtCN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCN.Location = New System.Drawing.Point(12, 142)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(313, 21)
        Me.txtCN.TabIndex = 281
        '
        'txtNN
        '
        Me.txtNN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNN.Location = New System.Drawing.Point(12, 217)
        Me.txtNN.Name = "txtNN"
        Me.txtNN.Size = New System.Drawing.Size(313, 21)
        Me.txtNN.TabIndex = 284
        '
        'lblMSG
        '
        Me.lblMSG.AutoSize = True
        Me.lblMSG.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMSG.ForeColor = System.Drawing.Color.Red
        Me.lblMSG.Location = New System.Drawing.Point(11, 259)
        Me.lblMSG.Name = "lblMSG"
        Me.lblMSG.Size = New System.Drawing.Size(56, 12)
        Me.lblMSG.TabIndex = 10000014
        Me.lblMSG.Text = "................."
        Me.lblMSG.Visible = False
        '
        'gbOptions
        '
        Me.gbOptions.Controls.Add(Me.cb2)
        Me.gbOptions.Controls.Add(Me.cb1)
        Me.gbOptions.Location = New System.Drawing.Point(15, 31)
        Me.gbOptions.Name = "gbOptions"
        Me.gbOptions.Size = New System.Drawing.Size(185, 64)
        Me.gbOptions.TabIndex = 10000015
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
        Me.cb2.Size = New System.Drawing.Size(40, 17)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "DB"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cb1.Location = New System.Drawing.Point(12, 17)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(43, 17)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "IST"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'mFormRenameTC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(343, 326)
        Me.Controls.Add(Me.gbOptions)
        Me.Controls.Add(Me.lblMSG)
        Me.Controls.Add(Me.txtNN)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pb1)
        Me.HelpButton = False

        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "mFormRenameTC"
        Me.HP.SetShowHelp(Me, False)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rename"
        Me.TopMost = True
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
    Dim ISTDB As Boolean
    Dim IST As Boolean
    Dim what As String
    Dim dIst As DatasetIstrazivanja
    Public Sub New(ByVal dIst As DatasetIstrazivanja, ByVal form As Form, ByVal tvRight As Integer, ByVal tvTop As Integer, ByVal sifist As String, ByVal ISTConnectionString As String, ByVal DBConnectionString As String, ByVal pp() As String, ByVal what As String)
        InitializeComponent()
        _parentForm = form
        With Me
            .TopMost = True
            If tvRight - Me.Width - 20 < 0 Then
                .Left = 20
            Else
                .Left = tvRight - Me.Width - 20
            End If
            .Top = tvTop + 30
        End With
        Me.sifist = sifist
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.pp = pp
        Me.what = what
        Me.dIst = dIst
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cb1.Checked = True
        Me.cb2.Checked = True
        If Me.what = "T" Then
            Me.BtnFormat.Text = "Rename table"
            Me.txtCN.Text = pp(0).Trim
        Else
            Me.BtnFormat.Text = "Rename column"
            Me.txtCN.Text = pp(3).Trim
        End If
        Me.txtNN.Focus()
    End Sub

    Private Sub BtnFormat_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnFormat.Click
        Try
            Dim pompom As String = ""
            If Me.cb1.Checked = True AndAlso Me.cb2.Checked = True Then
                pompom = "ISTDB"
            ElseIf Me.cb1.Checked = True AndAlso Me.cb2.Checked = False Then
                pompom = "IST"
            ElseIf Me.cb1.Checked = False AndAlso Me.cb2.Checked = True Then
                pompom = "DB"
            ElseIf Me.cb1.Checked = False AndAlso Me.cb2.Checked = False Then
                ISTMessageBox.Show("Nothing is selected! Not IST, not DB!")
                Exit Sub
            End If
            If Me.what = "T" Then
                Call rrenameT(pompom)
            Else
                Call rrenameC(pompom)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub rrenameC(ByVal pompom As String)
        'pp(0) je tabela , pp(3) je polje    mnu02.Tag = tabela + ";" + tValidFrom + ";" + tMaxRbr + ";" + polje
        Dim strDB As String = "" : Dim strIST As String = "" : Dim strIST2 As String = ""
        Dim postojiuDB As Boolean = False : Dim postojiuIST As Boolean = False

        Dim stWrNN As String = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                "' and polje=N'" + Me.txtNN.Text + "'" +
                "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"
        Dim strWCN As String = " where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim +
                "' and polje=N'" + Me.txtCN.Text + "'" +
                "  and cast (vod as date)='" + Convert.ToDateTime(pp(1)).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) + "'"

        Dim pIST As String = "" : Dim pIST2 As String = "" : Dim pDB As String = ""

        If pompom = "ISTDB" Then
            Dim tabela As String = pp(0).Trim : Dim shema As String = "dbo"
            If tabela.IndexOf(".") > 0 Then
                Dim pom() As String = tabela.Split(".")
                shema = pom(0).Trim
                tabela = pom(1).Trim
            End If
            strDB = "SELECT 1 FROM sys.columns WHERE Name = N'" + Me.txtNN.Text + "' AND Object_ID = Object_ID(N'" + shema + "." + tabela + "')"
            Dim dtDB As DataTable = izvrsiSQLvratiDT(strDB, Me.DBConnectionString, Nothing)
            If dtDB.Rows.Count > 0 Then postojiuDB = True
            If postojiuDB = False Then
                strDB = " exec sp_rename N'" + pp(0).Trim + "." + txtCN.Text.Trim + "', N'" + txtNN.Text.Trim + "','COLUMN';"
                strIST = " select * from ISTPolja " + stWrNN
                Dim dtIST As DataTable = izvrsiSQLvratiDT(strIST, Me.ISTConnectionString, Nothing)
                If dtIST.Rows.Count > 0 Then postojiuIST = True
                If postojiuIST = False Then
                    Dim sqlI As String = " update istpolja set polje=N'" + txtNN.Text + "'" + nvrd + strWCN
                    sqlI = sqlI + "update ISTAWLs set polje=N'" + txtNN.Text + "'" + nvrd + strWCN
                    pDB = izvrsiSQL(" begin transaction; " + nvrd + strDB + nvrd + " commit; ", Me.DBConnectionString)
                    If pDB = "nok" Then
                        ISTMessageBox.Show("Error. Not renamed in DB!")
                    Else
                        pIST = izvrsiSQL(" begin transaction; " + nvrd + sqlI + nvrd + " commit; ", Me.ISTConnectionString)
                        If pIST = "nok" Then
                            ISTMessageBox.Show("Error. Not renamed in IST!")
                        Else
                            'treba promeniti i u ISTPOLJA (OD,DO,izraz) i u ISTLK (GRESKA)
                            strIST2 = promenaOstalaPolja("OD")
                            If strIST2 <> "" Then pIST2 = izvrsiSQL(strIST2, Me.ISTConnectionString)
                            If pIST2 = "nok" Then ISTMessageBox.Show("Error. _ISTTablesColumns, validatingEvent is NOT updated!")
                            strIST2 = promenaOstalaPolja("DO")
                            If strIST2 <> "" Then pIST2 = izvrsiSQL(strIST2, Me.ISTConnectionString)
                            If pIST2 = "nok" Then ISTMessageBox.Show("Error. _ISTTablesColumns, enterEvent is NOT updated!")
                            strIST2 = promenaOstalaPolja("IZRAZ")
                            If strIST2 <> "" Then pIST2 = izvrsiSQL(strIST2, Me.ISTConnectionString)
                            If pIST2 = "nok" Then ISTMessageBox.Show("Error. _ISTTablesColumns, columnAtributes is NOT updated!")

                            strIST2 = promenaOstalaLK("GRESKA")
                            If strIST2 <> "" Then pIST2 = izvrsiSQL(strIST2, Me.ISTConnectionString)
                            If pIST2 = "nok" Then ISTMessageBox.Show("Error. _ISTRulesDataValidation, error is NOT updated!")

                        End If
                    End If
                Else
                    ISTMessageBox.Show("Name already exists in IST!")
                    Me.txtNN.Focus()
                    Me.txtNN.SelectAll()
                End If
            Else
                ISTMessageBox.Show("Name already exists in DB!")
                Me.txtNN.Focus()
                Me.txtNN.SelectAll()
            End If
        End If

        If pDB = "ok" AndAlso pIST = "ok" Then
            ISTMessageBox.Show("Renamed in DB and IST!")
            Me.Close()
        End If

        If pompom = "IST" Then
            strIST = " select * from ISTPolja " + stWrNN
            Dim dtIST As DataTable = izvrsiSQLvratiDT(strIST, Me.ISTConnectionString, Nothing)
            If dtIST.Rows.Count > 0 Then postojiuIST = True
            If postojiuIST = False Then
                Dim sqlI As String = " update istpolja set polje=N'" + txtNN.Text + "'" + nvrd + strWCN
                sqlI = sqlI + "update ISTAWLs set polje=N'" + txtNN.Text + "'" + nvrd + strWCN
                Dim p1 As String = "nok"
                p1 = izvrsiSQL(" begin transaction; " + nvrd + sqlI + nvrd + " commit; ", Me.ISTConnectionString)
                If p1 = "nok" Then ISTMessageBox.Show("Error. Not renamed in IST!") Else ISTMessageBox.Show("Renamed in IST!") : Me.Close()
            Else
                ISTMessageBox.Show("Name already exists in IST!")
                Me.txtNN.Focus()
                Me.txtNN.SelectAll()
            End If
        End If

        If pompom = "DB" Then
            Dim tabela As String = pp(0).Trim : Dim shema As String = "dbo"
            If tabela.IndexOf(".") > 0 Then
                Dim pom() As String = tabela.Split(".")
                shema = pom(0).Trim
                tabela = pom(1).Trim
            End If
            strDB = "SELECT 1 FROM sys.columns WHERE Name = N'" + Me.txtNN.Text + "' AND Object_ID = Object_ID(N'" + shema + "." + tabela + "')"
            Dim dtDB As DataTable = izvrsiSQLvratiDT(strDB, Me.DBConnectionString, Nothing)
            If dtDB.Rows.Count > 0 Then postojiuDB = True
            If postojiuDB = False Then
                strDB = " exec sp_rename N'" + pp(0).Trim + "." + txtCN.Text.Trim + "', N'" + txtNN.Text.Trim + "','COLUMN';"
                Dim p2 As String = "nok"
                p2 = izvrsiSQL(" begin transaction; " + nvrd + strDB + nvrd + " commit; ", Me.DBConnectionString)
                If p2 = "nok" Then
                    ISTMessageBox.Show("Error. Not renamed in DB!")
                Else
                    ISTMessageBox.Show("Renamed in DB!") : Me.Close()
                End If
            Else
                ISTMessageBox.Show("Name already exists in DB!")
                Me.txtNN.Focus()
                Me.txtNN.SelectAll()
            End If
        End If

    End Sub

    Function promenaOstalaPolja(ByVal sta As String) As String
        promenaOstalaPolja = ""
        Dim strpom As String = "select polje,isnull(" + sta + ",'') as " + sta + " from istpolja where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "' and " + sta + " like N'%" + Me.txtCN.Text + "%'"
        Dim dtpom As DataTable = izvrsiSQLvratiDT(strpom, ISTConnectionString, Nothing)
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
        Dim dtpom As DataTable = izvrsiSQLvratiDT(strpom, ISTConnectionString, Nothing)
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

    Sub rrenameT(ByVal pompom As String)
        'pp(0) je tabela     mnu03.Tag =  tabela + ";" + tValidFrom + ";" + Str(indextabela).Trim
        Dim strDB As String = "" : Dim strIST As String = ""
        Dim sqlDBDropTip As String = "" : Dim DropTip As String = ""
        Dim postojiuDB As Boolean = False : Dim postojiuIST As Boolean = False
        Dim shema As String = "dbo" : Dim tabela As String = txtNN.Text
        If txtNN.Text.IndexOf(".") > 0 Then
            Dim pom() As String = txtNN.Text.Split(".")
            shema = pom(0).Trim
            tabela = pom(1).Trim
        End If

        If pompom = "ISTDB" Then
            strDB = "select * from INFORMATION_SCHEMA.TABLES Where TABLE_SCHEMA = '" + shema + "' And TABLE_NAME = '" + tabela + "'"
            Dim dtDB As DataTable = izvrsiSQLvratiDT(strDB, Me.DBConnectionString, Nothing)
            If dtDB.Rows.Count > 0 Then postojiuDB = True
            If postojiuDB = False Then

                strDB = " exec sp_rename N'[" + pp(0).Trim + "]', N'" + txtNN.Text.Trim + "';"
                sqlDBDropTip = " exec sp_rename N'[" + txtNN.Text.Trim + "]', N'" + pp(0).Trim + "';"
                DropTip = "RENAME"

                strIST = " select * from ISTTabele where sifist=N'" + sifist + "' and tabela=N'" + txtNN.Text.Trim + "';" + nvrd
                Dim dtIST As DataTable = izvrsiSQLvratiDT(strIST, Me.ISTConnectionString, Nothing)
                If dtIST.Rows.Count > 0 Then postojiuIST = True
                If postojiuIST = False Then

                    Dim sqlI As String = "update IstTabele set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"
                    sqlI = sqlI + "update ISTpolja set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"
                    sqlI = sqlI + "update ISTAWLs set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"
                    sqlI = sqlI + "update ISTLK set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"

                    Dim pIST As String = "nok" : Dim pDB As String = "nok"
                    pIST = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlI, "ISTTABELE;ISTPOLJA;ISTAWLS;ISTLK", sqlDBDropTip, DropTip)
                    If pIST = "nok" Then ISTMessageBox.Show("Error. Not renamed in IST!")
                    If pIST = "ok" Then
                        pDB = izvrsiSQL(strDB, Me.DBConnectionString)
                        If pDB = "nok" Then ISTMessageBox.Show("Error. Not renamed in DB!")
                    End If

                    If pIST = "ok" AndAlso pDB = "ok" Then
                        ISTMessageBox.Show("Renamed in DB and IST!")
                    End If
                Else
                    ISTMessageBox.Show("Name already exists in IST!")
                    Me.txtNN.Focus()
                    Me.txtNN.SelectAll()
                End If
            Else
                ISTMessageBox.Show("Name already exists in DB!")
                Me.txtNN.Focus()
                Me.txtNN.SelectAll()
            End If
        End If

        If pompom = "IST" Then
            strIST = " select * from ISTTabele where sifist=N'" + sifist + "' and tabela=N'" + txtNN.Text.Trim + "';"
            Dim dtIST As DataTable = izvrsiSQLvratiDT(strIST, Me.ISTConnectionString, Nothing)
            If dtIST.Rows.Count > 0 Then postojiuIST = True
            If postojiuIST = False Then
                Dim sqlI As String = "update IstTabele set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"
                sqlI = sqlI + "update ISTpolja set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"
                sqlI = sqlI + "update ISTAWLs set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"
                sqlI = sqlI + "update ISTLK set tabela=N'" + Me.txtNN.Text + "' where sifist=N'" + sifist + "' and tabela=N'" + pp(0).Trim + "';"
                Dim pIST As String = "nok"
                pIST = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, sqlI, "ISTTABELE;ISTPOLJA;ISTAWLS;ISTLK")
                If pIST = "nok" Then ISTMessageBox.Show("Error. Not renamed in IST!") Else ISTMessageBox.Show("Renamed inIST!") : Me.Close()
            Else
                ISTMessageBox.Show("Name already exists in IST!")
                Me.txtNN.Focus()
                Me.txtNN.SelectAll()
            End If
        End If

        If pompom = "DB" Then
            strDB = "select * from INFORMATION_SCHEMA.TABLES Where TABLE_SCHEMA = '" + shema + "' And TABLE_NAME = '" + tabela + "'"
            Dim dtDB As DataTable = izvrsiSQLvratiDT(strDB, Me.DBConnectionString, Nothing)
            If dtDB.Rows.Count > 0 Then postojiuDB = True
            If postojiuDB = False Then
                strDB = " exec sp_rename N'[" + pp(0).Trim + "]', N'" + txtNN.Text.Trim + "';"
                sqlDBDropTip = " exec sp_rename N'[" + txtNN.Text.Trim + "]', N'" + pp(0).Trim + "';"
                DropTip = "RENAME"
                Dim pIST As String = "nok" : Dim pDB As String = "nok"
                pIST = napraviIzOpenFormeBackUpIzvrsiSQL(dIst, sifist, pp(0), Me.DBConnectionString, Me.ISTConnectionString, "", "", sqlDBDropTip, DropTip)

                pDB = izvrsiSQL(strDB, Me.DBConnectionString)
                If pDB = "nok" Then ISTMessageBox.Show("Error. Not renamed in DB!")

                If pDB = "ok" Then
                    ISTMessageBox.Show("Renamed in DB and IST!")
                End If

            Else
                ISTMessageBox.Show("Name already exists in DB!")
                Me.txtNN.Focus()
                Me.txtNN.SelectAll()
            End If
        End If

    End Sub

End Class