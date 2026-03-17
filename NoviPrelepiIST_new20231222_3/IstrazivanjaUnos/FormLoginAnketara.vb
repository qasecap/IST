Option Strict Off

Public Class FormLoginAnketara
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
    Friend WithEvents lblAuth1 As System.Windows.Forms.Label

    Friend WithEvents lblAuth3 As System.Windows.Forms.Label
    Friend WithEvents lblAuth2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthPoruka As System.Windows.Forms.Label
    Friend WithEvents btnLogIN As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents txtVremeLogON As System.Windows.Forms.TextBox
    Friend WithEvents dgA As DataGridView
    Friend WithEvents GBVT As GroupBox
    Friend WithEvents cbVT As ComboBox
    Friend WithEvents lblAuthPoruka2 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginAnketara))
        Me.lblAuth1 = New System.Windows.Forms.Label()
        Me.lblAuth3 = New System.Windows.Forms.Label()
        Me.lblAuth2 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUserID = New System.Windows.Forms.TextBox()
        Me.lblAuthPoruka = New System.Windows.Forms.Label()
        Me.btnLogIN = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.lblAuthPoruka2 = New System.Windows.Forms.Label()
        Me.txtVremeLogON = New System.Windows.Forms.TextBox()
        Me.dgA = New System.Windows.Forms.DataGridView()
        Me.GBVT = New System.Windows.Forms.GroupBox()
        Me.cbVT = New System.Windows.Forms.ComboBox()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBVT.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAuth1
        '
        Me.lblAuth1.Location = New System.Drawing.Point(69, 95)
        Me.lblAuth1.Name = "lblAuth1"
        Me.lblAuth1.Size = New System.Drawing.Size(404, 26)
        Me.lblAuth1.TabIndex = 7
        Me.lblAuth1.Text = "Унесите ваше корисничко име и лозинку"
        '
        'lblAuth3
        '
        Me.lblAuth3.AutoSize = True
        Me.lblAuth3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAuth3.Location = New System.Drawing.Point(140, 173)
        Me.lblAuth3.Name = "lblAuth3"
        Me.lblAuth3.Size = New System.Drawing.Size(77, 14)
        Me.lblAuth3.TabIndex = 9
        Me.lblAuth3.Text = "Лозинка    "
        '
        'lblAuth2
        '
        Me.lblAuth2.AutoSize = True
        Me.lblAuth2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAuth2.Location = New System.Drawing.Point(92, 133)
        Me.lblAuth2.Name = "lblAuth2"
        Me.lblAuth2.Size = New System.Drawing.Size(128, 14)
        Me.lblAuth2.TabIndex = 8
        Me.lblAuth2.Text = "Корисничко име    "
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBoxPassword.Location = New System.Drawing.Point(232, 173)
        Me.TextBoxPassword.MaxLength = 8
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(192, 22)
        Me.TextBoxPassword.TabIndex = 11
        '
        'TextBoxUserID
        '
        Me.TextBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUserID.Location = New System.Drawing.Point(232, 133)
        Me.TextBoxUserID.MaxLength = 8
        Me.TextBoxUserID.Name = "TextBoxUserID"
        Me.TextBoxUserID.Size = New System.Drawing.Size(192, 22)
        Me.TextBoxUserID.TabIndex = 10
        '
        'lblAuthPoruka
        '
        Me.lblAuthPoruka.ForeColor = System.Drawing.Color.Red
        Me.lblAuthPoruka.Location = New System.Drawing.Point(12, 259)
        Me.lblAuthPoruka.Name = "lblAuthPoruka"
        Me.lblAuthPoruka.Size = New System.Drawing.Size(490, 21)
        Me.lblAuthPoruka.TabIndex = 14
        Me.lblAuthPoruka.Text = "Унети подаци нису тачни, молимо Вас да покушате поново!"
        Me.lblAuthPoruka.Visible = False
        '
        'btnLogIN
        '
        Me.btnLogIN.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogIN.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnLogIN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLogIN.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLogIN.Location = New System.Drawing.Point(95, 218)
        Me.btnLogIN.Name = "btnLogIN"
        Me.btnLogIN.Size = New System.Drawing.Size(80, 24)
        Me.btnLogIN.TabIndex = 124
        Me.btnLogIN.Text = "LogIn"
        Me.btnLogIN.UseVisualStyleBackColor = False
        '
        'btnIzlaz
        '
        Me.btnIzlaz.BackColor = System.Drawing.Color.Transparent
        Me.btnIzlaz.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIzlaz.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnIzlaz.Location = New System.Drawing.Point(344, 218)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(80, 24)
        Me.btnIzlaz.TabIndex = 125
        Me.btnIzlaz.Text = "Cancel"
        Me.btnIzlaz.UseVisualStyleBackColor = False
        '
        'lblAuthPoruka2
        '
        Me.lblAuthPoruka2.ForeColor = System.Drawing.Color.Red
        Me.lblAuthPoruka2.Location = New System.Drawing.Point(12, 283)
        Me.lblAuthPoruka2.Name = "lblAuthPoruka2"
        Me.lblAuthPoruka2.Size = New System.Drawing.Size(408, 16)
        Me.lblAuthPoruka2.TabIndex = 126
        Me.lblAuthPoruka2.Text = "Проверите временску тачку!"
        Me.lblAuthPoruka2.Visible = False
        '
        'txtVremeLogON
        '
        Me.txtVremeLogON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVremeLogON.Location = New System.Drawing.Point(493, 43)
        Me.txtVremeLogON.MaxLength = 8
        Me.txtVremeLogON.Name = "txtVremeLogON"
        Me.txtVremeLogON.Size = New System.Drawing.Size(36, 22)
        Me.txtVremeLogON.TabIndex = 141
        Me.txtVremeLogON.Visible = False
        '
        'dgA
        '
        Me.dgA.AllowUserToAddRows = False
        Me.dgA.AllowUserToDeleteRows = False
        Me.dgA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgA.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgA.GridColor = System.Drawing.Color.DarkGray
        Me.dgA.Location = New System.Drawing.Point(487, 12)
        Me.dgA.Name = "dgA"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgA.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgA.Size = New System.Drawing.Size(42, 25)
        Me.dgA.TabIndex = 10000054
        '
        'GBVT
        '
        Me.GBVT.Controls.Add(Me.cbVT)
        Me.GBVT.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.GBVT.Location = New System.Drawing.Point(274, 65)
        Me.GBVT.Name = "GBVT"
        Me.GBVT.Size = New System.Drawing.Size(150, 56)
        Me.GBVT.TabIndex = 10000055
        Me.GBVT.TabStop = False
        Me.GBVT.Text = "Year/Month"
        Me.GBVT.Visible = False
        '
        'cbVT
        '
        Me.cbVT.FormattingEnabled = True
        Me.cbVT.Location = New System.Drawing.Point(12, 21)
        Me.cbVT.Name = "cbVT"
        Me.cbVT.Size = New System.Drawing.Size(121, 22)
        Me.cbVT.TabIndex = 0
        '
        'FormLoginAnketara
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.CancelButton = Me.btnIzlaz
        Me.ClientSize = New System.Drawing.Size(541, 347)
        Me.Controls.Add(Me.GBVT)
        Me.Controls.Add(Me.txtVremeLogON)
        Me.Controls.Add(Me.lblAuthPoruka2)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnLogIN)
        Me.Controls.Add(Me.lblAuthPoruka)
        Me.Controls.Add(Me.lblAuth3)
        Me.Controls.Add(Me.lblAuth2)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUserID)
        Me.Controls.Add(Me.lblAuth1)
        Me.Controls.Add(Me.dgA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLoginAnketara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentication"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBVT.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim CATIServer As String
    Dim CATIBaza As String
    Dim ri As DatasetIstrazivanja.ISTRow
    Dim tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim GG As String
    Dim MM As String
    Dim sifist As String
    Dim tabela As String
    Dim tabelaLog As String
    Dim DBConnectionString As String
    Dim anketar As String
    Dim txtInst As String
    Dim txtpismo As String
    Dim adresarCati As String
    Dim istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Dim istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Dim istLK As DatasetIstrazivanja.ISTLKDataTable
    Dim mfold As String
    Dim nazivIst As String
    Dim konCATI As String
    Dim izazur As Boolean
    Dim jezik As String
    Dim dsIst As DatasetIstrazivanja
    Dim ISTConnectionString As String
    Dim txtmode As String
    Dim txtZoiper As String
    Dim mdtAWL As DataTable
    Dim mdtQE As DataTable
    Dim mdtLabel As DataTable
    Dim mdtMessage As DataTable
    Dim catiprefix As String
    Public Sub New(ByVal ds As DatasetIstrazivanja, ByVal mdtLabel As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable, ByVal mdtMessage As DataTable,
                    ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal fold As String,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                    ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable,
                    ByVal istPolja As DatasetIstrazivanja.ISTPOLJADataTable, ByVal istLK As DatasetIstrazivanja.ISTLKDataTable,
                    ByVal txtInst As String, ByVal txtPismo As String,
                    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String, ByVal txt_DSBrisanjeBaza As String,
                    ByVal txt_CATIServer As String, ByVal txt_CATIBaza As String, ByVal adresarCati As String,
                    ByVal txtmode As String, ByVal jezik As String, ByVal ISTConnectionString As String, ByVal txtZoiper As String,
                    Optional ByVal izazur As Boolean = False)
        Me.New()
        Me.mfold = fold
        Me.ISTConnectionString = ISTConnectionString
        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        Me.CATIServer = txt_CATIServer
        Me.CATIBaza = txt_CATIBaza
        Me.txtZoiper = txtZoiper
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtLabel = mdtLabel
        Me.mdtMessage = mdtMessage
        Me.txtmode = txtmode
        Me.sifist = ri.Item(0).ToString.Trim
        Me.konCATI = getConnectionString(Me.CATIServer.Trim, Me.CATIBaza.Trim, txtmode, "")
        Me.catiprefix = "dbo."

        If Me.txtmode.Trim.ToUpper.IndexOf("CLOUD") = 0 Then Me.catiprefix = "cati."

        Dim dtSelect As New System.Data.DataTable
        Dim sql As String = "select ISTmonth+'/'+ISTyear as displaymember,ISTmonth+'/'+ISTyear as valuemember from " + Me.catiprefix + "ISTCATIDef D where aktivan=1 and sifist='" + sifist + "'"

        Call popunicbo(cbVT, sql, Me.konCATI, False)
        If cbVT.DataSource.Rows.Count > 1 Then
            Me.GBVT.Visible = True
            Me.lblAuth1.Location = New Point(Me.lblAuth1.Location.X, 26)
        End If

        Me.Text += " - " + ri.Naziv.Trim
        Me.ri = ri
        Me.txtInst = txtInst
        Me.txtpismo = txtPismo
        Me.tacv = vt
        Me.GG = CStr(Me.tacv.G)
        Me.MM = CStr(Me.tacv.M).Trim.PadLeft(2, "0"c)
        Me.DBConnectionString = DBConnectionString
        Me.adresarCati = adresarCati
        Me.istTabele = istTabele
        Me.istPolja = istPolja
        Me.istLK = istLK
        Me.nazivIst = ds.IST.Rows(0).Item("naziv").ToString.Trim
        Me.izazur = izazur

        Me.jezik = jezik
        Call SetLang()
        Me.dsIst = ds
    End Sub


    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "formLoginCATICloud")
        lblAuth1.Text = getControlText2(dt, "lblAuth1", Me.jezik)
        lblAuth2.Text = getControlText2(dt, "lblAuth2", Me.jezik)
        lblAuth3.Text = getControlText2(dt, "lblAuth3", Me.jezik)
        lblAuthPoruka.Text = getControlText2(dt, "lblAuthPoruka", Me.jezik)
        lblAuthPoruka2.Text = getControlText2(dt, "lblAuthPoruka2", Me.jezik)
    End Sub

    Public Sub AnyTextBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tb As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        tb.BackColor = System.Drawing.Color.Thistle
        tb.SelectAll()
    End Sub

    Public Sub AnyTextBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim tb As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        tb.BackColor = System.Drawing.SystemColors.ControlLightLight
    End Sub

    Public Sub AnyTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tt As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub FormLoginAnketara_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'enterToTab
        'ulaz u polje postavlja boju polja na drugu
        Dim TopControl As Control = DirectCast(sender, Control)
        For Each c As Control In TopControl.Controls
            If TypeOf c Is TextBox Then
                If CType(c, TextBox).Multiline = False Then
                    AddHandler c.KeyPress, AddressOf AnyTextBox_KeyPress
                    AddHandler c.Enter, AddressOf AnyTextBox_Enter
                    AddHandler c.Leave, AddressOf AnyTextBox_Leave
                End If
            End If
            If TypeOf c Is ComboBox Then
                AddHandler c.KeyPress, AddressOf AnyComboBox_KeyPress
                AddHandler c.KeyDown, AddressOf AnyComboBox_KeyDown
                AddHandler c.Enter, AddressOf AnyComboBox_Enter
                AddHandler c.Leave, AddressOf AnyComboBox_Leave
            End If
        Next
    End Sub

    Public Sub AnyComboBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Public Sub AnyComboBox_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim cb As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        cb.BackColor = System.Drawing.Color.Thistle
        Try
            If cb.SelectedValue Is Nothing OrElse cb.SelectedValue = "" Then
            Else
                cboIndexNaEnter = cb.SelectedIndex
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Public cboIndexNaEnter As Integer

    Public Sub AnyComboBox_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim cb As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        cb.BackColor = System.Drawing.SystemColors.ControlLightLight
    End Sub

    Public Sub AnyComboBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim cb As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        'ISTMessageBox.Show("cbpp_KeyDown", MsgBoxStyle.Information)
        Select Case e.KeyCode
            Case Keys.Escape
            Case Keys.Enter  'Enter
                Dim aaa As String = cb.Name
                If Not (cb.SelectedValue) Is Nothing Then
                    'ako je poslednji nema gde dole!!!!
                    If cboIndexNaEnter <> cb.SelectedIndex Then
                        If cb.SelectedValue = CType(CType(cb.Items(cb.Items.Count - 1), Object), System.Data.DataRowView).Item(1) Then
                            System.Windows.Forms.SendKeys.Send("{UP}")
                            System.Windows.Forms.SendKeys.Send("{DOWN}")
                        Else
                            System.Windows.Forms.SendKeys.Send("{DOWN}")
                            System.Windows.Forms.SendKeys.Send("{UP}")
                        End If
                    End If
                Else
                    'dodato 11022013
                    If cb.Text.Trim.Length > 0 AndAlso cb.SelectedText.Trim.Length = 0 Then
                        System.Windows.Forms.SendKeys.Send("{DOWN}")
                        System.Windows.Forms.SendKeys.Send("{DOWN}")
                        'ako nije poslednji
                        Dim dt As DataTable = CType(CType(cb.DataSource, Object), System.Data.DataTable)
                        Dim sqlText As String = "2=2 AND prikazi LIKE '" & cb.Text.Trim.ToUpper & "%'"
                        Dim red01 As System.Data.DataRow() = dt.Select(sqlText)
                        Dim poslednjiPrikazi As String = CType(CType(cb.Items(cb.Items.Count - 1), Object), System.Data.DataRowView).Item(0).ToString.Trim.ToUpper
                        If red01.Length = 1 AndAlso red01(0).Item("prikazi").ToString.Trim.ToUpper = poslednjiPrikazi Then
                            'POSLEDNJI
                        Else
                            System.Windows.Forms.SendKeys.Send("{UP}")
                        End If
                    Else
                        System.Windows.Forms.SendKeys.Send("{DOWN}")
                    End If
                End If
            Case Else
        End Select
    End Sub
    Dim g As String
    Dim m As String
    Dim vtvt As String
    Private Sub btnLogIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIN.Click

        If GBVT.Visible = True Then
            g = cbVT.Text.Substring(3, 4)
            m = cbVT.Text.Substring(0, 2)
            Dim d As Date = New Date(g, m, 2)
            vtvt = d.ToString("yyyy-MM-dd")

            Try

                Call puniDatasetIstrazivanja(sifist, vtvt)
            Catch EX As System.Exception
                ISTMessageBox.Show(EX.Message)
            End Try
        End If

        Call logIN()
    End Sub
    'Private rist As DatasetIstrazivanja.ISTRow
    Sub puniDatasetIstrazivanja(ByVal app As String, ByVal vtvt As String)
        Me.dsIst.Clear()
        fISTNovo1Deo(app, vtvt) 'ISTBAZE,IST

        If Me.dsIst.IST.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim appStaraApl As String = app : Dim appR As String = app : Dim tablesT As String = "" 'tabele, polja i LK moraju da budu iz iste app
        If Not Me.dsIst.IST.Rows(0).Item("Abaza") Is System.DBNull.Value Then
            Dim additionalParameters As String = Me.dsIst.IST.Rows(0).Item("Abaza").ToString.Trim.ToUpper
            Dim pp() As String = additionalParameters.Split(CType(";", Char()))
            For i As Integer = 0 To pp.GetUpperBound(0)
                Dim kk() As String = pp(i).Split(CType("=", Char()))
                If kk.Length >= 2 AndAlso kk(0) <> "" AndAlso kk(1) <> "" Then
                    If kk(0) = "IST" Then appStaraApl = kk(1).Trim
                    If kk(0) = "ISTTABS" OrElse kk(0) = "ISTREPORTSPROCEDURES" Then appR = kk(1)
                    If kk(0) = "ISTTABLES" OrElse kk(0) = "ISTTABELE" Then
                        'ISTTABLES=A1=A,B1=B,C1=C
                        'A1=A,B1=B,C1=C
                        tablesT = pp(i).Trim.ToUpper.Replace("ISTTABLES=", "").Replace("ISTTABELE=", "")
                    End If
                End If
            Next
        End If

        fISTTABELE(Me.dsIst, app, appStaraApl, vtvt, tablesT.Trim.ToUpper)

        fISTNovo2Deo(app, appStaraApl, vtvt, tablesT.Trim.ToUpper)  'ISTOPOLJA, ISTLK
        fISTOstalo(app, appStaraApl, vtvt, tablesT.Trim.ToUpper)

        'For Each rowIST As DatasetIstrazivanja.ISTRow In dsIst.IST.Rows
        '    Me.rist = rowIST
        'Next
    End Sub
    Sub fISTNovo1Deo(ByVal app As String, ByVal vtvt As String, Optional ByVal x As Integer = 0)
        Dim sqlISTBAZE As String = "select * from ISTBaze where vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) And '" + vtvt + "' <= vdo;"
        Dim sqlIST As String = "select * from IST where sifIST=N'" + app.Trim + "' And vod <= Convert(DateTime, DateAdd(Month, DateDiff(Month, 0, '" + vtvt + "'), 0), 126) and '" + vtvt + "' <= vdo;"
        Dim ssql As String = sqlISTBAZE + sqlIST
        If x = 1 Then
            sqlIST = "select * from IST"
        End If
        Try
            Dim ds As System.Data.DataSet = izvrsiSQLvratiDS(ssql, ISTConnectionString, Nothing)
            'Me.dsIST.ISTBAZE.Clear()
            'Me.dsIST.IST.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Me.dsIst.ISTBAZE.ImportRow(ds.Tables(0).Rows(i))
            Next
            For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
                Me.dsIst.IST.ImportRow(ds.Tables(1).Rows(i))
            Next
            If Me.dsIst.IST.Rows.Count = 0 Then
                ''msg 277
                Dim msgtxt277 As String = getMessageText(dtMessages, "277", Me.jezik)
                Throw New System.Exception(msgtxt277)
            End If
        Catch ex As System.Exception
            Dim por As String = "CHECK databaseType (FIZBAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseType THAT DOES NOT EXISTS IN table _ISTDatabaseConnStrings (ISTBAZE)." + nvrd + nvrd +
                "CHECK databaseAlias (BAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseAlias THAT DOES NOT EXISTS IN table _IST." + nvrd
            ISTMessageBox.Show("_IST _ISTDatabaseConnStrings (ISTBAZE) !!!! " + nvrd + por + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fISTNovo2Deo(ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String)
        If Me.dsIst.ISTTABELE.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt2741 As String = getMessageText(dtMessages, "2741", Me.jezik)
            ISTMessageBox.Show(msgtxt2741)
            Exit Sub
        End If
        Dim sqlISTPolja As String = ""
        Dim sqlISTLK As String = ""
        If app <> appStaraApl Then
            sqlISTPolja = "select * from ISTPolja where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
               "  and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
               " and '" + vtvt + "' <= vdo  " +
               " order by tabela,rbr;"
            sqlISTLK = "select SIfIST,TABELA,RbrGreske,replace(GRESKA,'webrelacija','Relacija') as greska,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo" +
                 " from ISTLk " +
                 " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo order by sifIST,tabela,rbrgreske;"
        Else
            'tabele koje postoje u ISTTabele
            Dim ttabele As String = ""
            For i As Integer = 0 To Me.dsIst.ISTTABELE.Rows.Count - 1
                ttabele = ttabele + "'" + DirectCast((Me.dsIst.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
            Next
            ttabele = ttabele.TrimEnd(CType(",", Char()))

            sqlISTPolja = "select * from ISTPolja where sifIST =N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                    " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                    " and '" + vtvt + "' <= vdo  " +
                    " order by tabela,rbr;"
            sqlISTLK = "select SIfIST,TABELA,RbrGreske,replace(GRESKA,'webrelacija','Relacija') as greska,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo" +
              " from ISTLk " +
              " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
              " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
              " and '" + vtvt + "' <= vdo  order by sifIST,tabela,rbrgreske; "
        End If

        Dim ssql As String = sqlISTPolja + sqlISTLK

        Dim ds As New System.Data.DataSet
        ds = izvrsiSQLvratiDS(ssql, Me.ISTConnectionString, Nothing)
        If app <> appStaraApl Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i)("sifIST") = app
            Next
            Call promenaMETA(tablesT, ds.Tables(0), False, True)
        End If

        Me.dsIst.ISTPOLJA.Clear()

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Me.dsIst.ISTPOLJA.ImportRow(ds.Tables(0).Rows(i))
        Next

        If Me.dsIst.ISTPOLJA.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt274 As String = getMessageText(dtMessages, "274", Me.jezik)
            'Throw New System.Exception(msgtxt274)
            ISTMessageBox.Show(msgtxt274)
        End If


        If app <> appStaraApl Then
            For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
                ds.Tables(1).Rows(i)("sifIST") = app
            Next
            Call promenaMETA(tablesT, ds.Tables(1),,,,, True)
        End If
        Me.dsIst.ISTLK.Clear()

        For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
            Me.dsIst.ISTLK.ImportRow(ds.Tables(1).Rows(i))
        Next

        If Me.dsIst.ISTLK.Rows.Count = 0 Then
            ''msg 275
            Dim msgtxt275 As String = getMessageText(dtMessages, "275", Me.jezik)
            ISTMessageBox.Show(msgtxt275, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            For i As Integer = 0 To Me.dsIst.ISTLK.Rows.Count - 1
                Dim ppp As String = ""
                If Not (Me.dsIst.ISTLK.Rows(i).Item("uslov").GetType Is GetType(System.DBNull) OrElse Me.dsIst.ISTLK.Rows(i).Item("uslov").Trim = "") Then
                    ppp = Me.dsIst.ISTLK.Rows(i).Item("uslov").trim.toupper
                    If ppp.IndexOf("LKVELIKA") < 0 AndAlso ppp.IndexOf("LKUNOS") < 0 AndAlso ppp.IndexOf("EXECUTEONLYONDATAENTRYFORM") < 0 AndAlso ppp.IndexOf("EXECUTEONLYFROMDATAVALIDATIONMODULE") < 0 AndAlso ppp.IndexOf("EXECUTEONLYONADDEDBUTTONCONTROL") < 0 AndAlso ppp.IndexOf("DONTSAVE") < 0 AndAlso ppp.IndexOf("DONTSEND") < 0 Then
                        Me.dsIst.ISTLK.Rows(i).Item("uslov") = ""
                    End If
                End If
            Next
        End If

    End Sub

    Sub fISTTABELE(ByVal ds As DatasetIstrazivanja, ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String)

        Dim sql As String = ""
        If app <> appStaraApl Then
            sql = "select * from ISTTabele where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
                    " and vod <= Convert(DateTime, DateAdd(Month, DateDiff(Month, 0, '" + vtvt + "'), 0), 126) " +
                    " and '" + vtvt + "' <= vdo and isnull(T1,'') not like '%ISTVIEW%'" +
                    " order by baza"
        Else
            sql = "select * from ISTTabele where sifIST=N'" + appStaraApl.Trim + "'" +
                    " and vod <= Convert(DateTime, DateAdd(Month, DateDiff(Month, 0, '" + vtvt + "'), 0), 126) " +
                    " and '" + vtvt + "' <= vdo and isnull(T1,'') not like '%ISTVIEW%'" +
                    " order by baza"
        End If

        Try
            Dim dtIST As System.Data.DataTable = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)
            ds.ISTTABELE.Clear()

            For i As Integer = 0 To dtIST.Rows.Count - 1
                ds.ISTTABELE.ImportRow(dtIST.Rows(i))
            Next

            If app <> appStaraApl Then
                For i As Integer = 0 To ds.ISTTABELE.Rows.Count - 1
                    ds.ISTTABELE.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, ds.ISTTABELE, True, False, True, True)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub fISTOstalo(ByVal app As String, ByVal appStaraApl As String, ByVal vtvt As String, ByVal tablesT As String)

        If Me.dsIst.ISTTABELE.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt2741 As String = getMessageText(dtMessages, "2741", Me.jezik)
            ISTMessageBox.Show(msgtxt2741)
            Exit Sub
        End If

        Dim sqlISTAWLs As String = ""
        Dim sqlISTQuestionExplanation As String = ""
        Dim sqlISTLabels As String = ""

        Dim sqlISTABS As String = "select * from ISTTabs where sifist in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
        " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
        " and '" + vtvt + "' <= vdo  " +
        " order by sifist,rbrTabele;"

        Dim sqlISTMessages As String = " select * from ISTMessages where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
            " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
            " and '" + vtvt + "' <= vdo  " +
            " order by IDLang,IDMsg;"

        If app <> appStaraApl Then
            sqlISTAWLs = " select * from ISTAWLs" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                  " and '" + vtvt + "' <= vdo  " +
                  " order by tabela,polje;"
            sqlISTQuestionExplanation = " select * from ISTQuestionExplanation" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                  " and '" + vtvt + "' <= vdo  " +
                  " order by tabela,polje;"
            sqlISTLabels = " select * from ISTLabels" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                  " and '" + vtvt + "' <= vdo  " +
                  " order by tabela,polje;"
        Else
            'tabele koje postoje u ISTTabele
            Dim ttabele As String = ""
            For i As Integer = 0 To Me.dsIst.ISTTABELE.Rows.Count - 1
                ttabele = ttabele + "'" + DirectCast((Me.dsIst.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
            Next
            ttabele = ttabele.TrimEnd(CType(",", Char()))

            sqlISTAWLs = "select * from ISTAWLs " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo  " +
                 " order by tabela,polje;"
            sqlISTQuestionExplanation = "select * from ISTQuestionExplanation " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo  " +
                 " order by tabela,polje;"
            sqlISTLabels = "select * from ISTLabels " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
                 " and '" + vtvt + "' <= vdo  " +
                 " order by tabela,polje;"
        End If

        Dim ssql As String = sqlISTABS + sqlISTAWLs + sqlISTQuestionExplanation + sqlISTLabels + sqlISTMessages

        Dim ds As System.Data.DataSet = izvrsiSQLvratiDS(ssql, Me.ISTConnectionString, Nothing)
        If app <> appStaraApl Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i)("sifIST") = app
            Next
        End If
        Me.dsIst.ISTTABS.Clear()
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Me.dsIst.ISTTABS.ImportRow(ds.Tables(0).Rows(i))
        Next

        Try
            mdtAWL = ds.Tables(1)
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtAWL.Rows.Count - 1
                    mdtAWL.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, mdtAWL, False, True)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtQE = ds.Tables(2)
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtQE.Rows.Count - 1
                    mdtQE.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, mdtQE, False, True)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtLabel = ds.Tables(3)
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtLabel.Rows.Count - 1
                    mdtLabel.Rows(i)("sifIST") = app
                Next
                Call promenaMETA(tablesT, mdtLabel, False, True)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try

        Try
            mdtMessage = ds.Tables(4)
            If app <> appStaraApl Then
                For i As Integer = 0 To mdtMessage.Rows.Count - 1
                    mdtMessage.Rows(i)("sifIST") = app
                Next
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub promenaMETA(ByVal tablesT As String, ByVal dt As System.Data.DataTable,
                Optional nadtabela As Boolean = False, Optional izraz As Boolean = False, Optional T1 As Boolean = False, Optional T2 As Boolean = False, Optional greska As Boolean = False)
        Dim prom As Boolean = False
        If tablesT <> "" Then
            Dim pp() As String = tablesT.Trim.Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "").Split(CType(",", Char()))
            For i As Integer = 0 To pp.GetUpperBound(0)
                prom = False
                Dim kk() As String = pp(i).Split(CType("=", Char()))
                If kk.Length = 2 AndAlso kk(0) <> "" AndAlso kk(1) <> "" Then
                    If kk(0) <> kk(1) Then
                        Dim kkL As String = kk(0) : Dim kkD As String = kk(1)
                        For ii As Integer = 0 To dt.Rows.Count - 1
                            If dt.Rows(ii)("tabela").ToString.Trim.ToUpper = kk(0) Then
                                dt.Rows(ii)("tabela") = kk(1)
                                prom = True
                            End If

                            If nadtabela = True AndAlso dt.Rows(ii)("nadtabela").ToString.Trim.ToUpper = kk(0) Then dt.Rows(ii)("nadtabela") = kk(1)

                            If T1 = True AndAlso dt.Rows(ii)("t1").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("t1").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("t1") = iizz
                            End If
                            If T2 = True AndAlso dt.Rows(ii)("t2").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("t2").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("t2") = iizz
                            End If

                            If izraz = True AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("SELECT") >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("izraz").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) AndAlso bbb(ll - 1) = "FROM" Then
                                        bbb(ll) = kk(1)
                                    End If
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("izraz") = iizz
                            End If
                            If izraz = True AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                                dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf(".") > 0 AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("}") > 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("izraz").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) AndAlso bbb(ll - 1) = "{" AndAlso bbb.GetUpperBound(0) >= ll + 1 AndAlso bbb(ll + 1) = "." Then
                                        bbb(ll) = kk(1)
                                    End If
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("izraz") = iizz
                            End If
                            If izraz = True AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                                dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf(".") > 0 AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("}") > 0 AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("SELECT") < 0 Then
                                Dim nn As String = dt.Rows(ii)("izraz").ToString.Trim.ToUpper
                                nn = nn.Replace(kk(0).Trim.ToUpper, kk(1).Trim.ToUpper)
                                dt.Rows(ii)("izraz") = nn
                            End If
                            If greska = True AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii)("greska").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("greska") = iizz
                            End If
                            If greska = True AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                               dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("RELACIJA") > 0 AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("}") > 0 AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("SELECT") < 0 Then
                                Dim nn As String = dt.Rows(ii)("greska").ToString.Trim.ToUpper
                                nn = nn.Replace(kk(0).Trim.ToUpper, kk(1).Trim.ToUpper)
                                dt.Rows(ii)("greska") = nn
                            End If
                        Next
                    End If
                End If
            Next
        End If
    End Sub


    Private Sub logIN()
        Dim sveok As Boolean = True
        Dim poruka As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        anketar = ""

        If Me.TextBoxUserID.Text <> "" AndAlso Me.TextBoxPassword.Text <> "" Then
            Dim strSQL As String = "select isnull(anketar,'Error') as anketar from " + Me.catiprefix + "[ISTCATIUsersPass]" _
            + " where userid='" + Me.TextBoxUserID.Text + "'  and password='" + Me.TextBoxPassword.Text + "'"
            strSQL = strSQL + " and sifist='" + sifist + "'"

            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(strSQL, Me.konCATI, Nothing)

            If dt.Rows.Count > 0 Then
                'postoji anketar
                anketar = ""
                anketar = dt.Rows(0).Item("anketar").ToString.Trim
                If anketar = "" OrElse anketar = "Error" OrElse dt.Rows(0).Item("anketar") Is System.DBNull.Value Then
                    ISTMessageBox.Show("Please logOn again!")
                    Me.TextBoxUserID.Text = ""
                    Me.TextBoxUserID.Focus()
                    Exit Sub
                End If

                'da li je vec logovan negde
                Dim stron As String = "select  max(vreme) As onvreme from  " + Me.catiprefix + "[ISTCATILogovanje]  where  anketar='" + anketar + "' and sifist='" + sifist + "' and onoff='on'"
                Dim dton As DataTable = izvrsiSQLvratiDT(stron, Me.konCATI, Nothing)
                Dim stroff As String = "select  max(vreme) As offvreme  From  " + Me.catiprefix + "[ISTCATILogovanje]  where anketar ='" + anketar + "' and sifist='" + sifist + "' and onoff='off'"
                Dim dtoff As DataTable = izvrsiSQLvratiDT(stroff, Me.konCATI, Nothing)

                If dton.Rows.Count > 0 Then
                    If dtoff.Rows.Count > 0 Then
                        If dton.Rows(0).Item("onvreme") Is System.DBNull.Value Then
                            sveok = True
                        Else
                            Dim son As DateTime = IIf(dton.Rows(0).Item("onvreme") Is System.DBNull.Value, System.DateTime.Now, dton.Rows(0).Item("onvreme"))
                            Dim sof As DateTime = IIf(dtoff.Rows(0).Item("offvreme") Is System.DBNull.Value, System.DateTime.Now, dtoff.Rows(0).Item("offvreme"))
                            If son > sof Then sveok = False
                        End If
                    End If
                End If
            Else
                anketar = ""
                sveok = False
            End If

            If sveok = True Then
                'upisi(ISTCATILogovanje)
                Dim sqlCATILogovanje As String = ""
                Me.txtVremeLogON.Text = trenutnoDatumVremeSaServera()

                sqlCATILogovanje = sqlCATILogovanje + "insert into " + Me.catiprefix + "[ISTCATILogovanje] (sifist,anketar,onoff,vreme) " _
                    + " values('" & sifist & "','" + anketar + "','on','" + Me.txtVremeLogON.Text.Trim + "')"
                Dim odg As String = izvrsiSQL(sqlCATILogovanje, Me.konCATI)
                If odg = "" Then
                    ''msg 298
                    Dim msgtxt298 As String = getMessageText(dtMessages, "298", Me.jezik)
                    ISTMessageBox.Show(msgtxt298, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim dtSelect As New System.Data.DataTable
                Dim sql As String = "select sifist,tabela, isnull(nazivCATIS,'') as nazivIst,ISTyear,ISTmonth from " + Me.catiprefix + "[ISTCATIDef] D " +
                                        " where aktivan=1 and sifist='" + sifist + "' and exists " +
                                        " (select * from " + Me.catiprefix + "ISTCATIUsersPass where sifist=d.sifist" +
                                        " and anketar='" + anketar + "')"
                If GBVT.Visible = True Then
                    Dim g As String = cbVT.Text.Substring(3, 4)
                    Dim m As String = cbVT.Text.Substring(0, 2)
                    sql = sql + " and ISTYear='" + g + "' and ISTMonth='" + m + "'"
                End If

                dtSelect = izvrsiSQLvratiDT(sql, Me.konCATI, Nothing)
                If dtSelect.Rows.Count > 1 Then
                    dgA.DataSource = dtSelect
                    dgA.BringToFront()
                    dgA.Location = New Point(0, 0)
                    dgA.Width = 500
                    dgA.Height = 200
                    dgA.Focus()
                ElseIf dtSelect.Rows.Count = 1 Then
                    tabela = dtSelect.Rows(0).Item("tabela").trim
                    If izazur = False Then
                        'provera za vrtacku!!!
                        Dim gg As String = dtSelect.Rows(0).Item("ISTyear").ToString.Trim
                        Dim mm As String = dtSelect.Rows(0).Item("ISTmonth").ToString.Trim

                        Dim godina As Integer = CInt(gg)
                        Dim mesec As Integer = CInt(mm)

                        Dim d As Date = New Date(godina, mesec, 2)
                        Me.tacv.MyInit("Vod", "Vdo", Date.MinValue, Date.MaxValue, New Date(gg, mm, 2))

                        Dim frm As New FormCATI(dsIst, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.tacv, Me.mfold, Me.DBConnectionString, Me.ri, istTabele, istPolja, istLK, txtInst,
                                                Me.txtpismo, DSBrisanjeDEPO, DSBrisanjeServer, DSBrisanjeBaza, CATIServer, CATIBaza,
                                                anketar, adresarCati, Me.txtVremeLogON.Text.Trim, ri.Item(0).ToString.Trim, nazivIst,
                                                tabela, Me.jezik, Me.ISTConnectionString, Me.txtmode, Me.txtZoiper)
                        Try
                            frm.ShowDialog()
                        Catch ex As System.Exception
                            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            frm.Dispose()
                        End Try
                    End If
                    Me.Close()
                End If
            End If

            If sveok = False Then

                If Me.txtmode.Trim.ToUpper.IndexOf("CLOUD") < 0 Then
                    Dim pp As String
                    If anketar = "" Then
                        ''msg 192
                        Dim msgtxt192 As String = getMessageText(dtMessages, "192", Me.jezik)
                        pp = msgtxt192
                    Else
                        ''msg 193
                        Dim msgtxt193 As String = getMessageText(dtMessages, "193", Me.jezik)
                        pp = msgtxt193
                    End If
                    ISTMessageBox.Show(pp, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.lblAuthPoruka.Visible = True
                    Me.lblAuthPoruka2.Visible = True
                    Me.TextBoxUserID.Focus()
                End If

                If Me.txtmode.Trim.ToUpper.IndexOf("CLOUD") = 0 Then
                    If anketar = "" Then
                        ISTMessageBox.Show("Please logOn again!")
                        Me.TextBoxUserID.Text = ""
                        Me.TextBoxUserID.Focus()
                        Exit Sub
                    End If

                    Dim sqlCATILogovanje As String = ""
                    Me.txtVremeLogON.Text = trenutnoDatumVremeSaServera()
                    sqlCATILogovanje = sqlCATILogovanje + "insert into " + Me.catiprefix + "[ISTCATILogovanje] (sifist,anketar,onoff,vreme) " _
                    + " values('" & sifist & "','" + anketar + "','off','" + Me.txtVremeLogON.Text.Trim + "')"
                    Dim odg As String = izvrsiSQL(sqlCATILogovanje, Me.konCATI)

                    If odg = "" Then
                        ''msg 298
                        Dim msgtxt298 As String = getMessageText(dtMessages, "298", Me.jezik)
                        ISTMessageBox.Show(msgtxt298, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        'ISTMessageBox.Show("You were loged on, now you are loged off. " + nvrd + nvrd + "Please try again to logon!")
                        'Me.TextBoxUserID.Focus()
                        Call logIN()
                    End If
                End If

            End If

        End If
    End Sub

    Function trenutnoDatumVremeSaServera() As String
        Dim sql As String = "select CONVERT(varchar, GETDATE(), 120) as dv"
        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        If dt.Rows.Count > 0 Then
            trenutnoDatumVremeSaServera = dt.Rows(0).Item("dv").ToString.Trim
        Else
            trenutnoDatumVremeSaServera = System.DateTime.Now.ToString("yyyy.MM.dd HH:mm")
        End If
    End Function
    Private Sub btnIzlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzlaz.Click
        Me.Close()
    End Sub

    Private Sub dgA_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgA.DoubleClick
        'samo 1
        If dgA.CurrentRow.Index > -1 Then
            sifist = dgA.CurrentRow.Cells(0).Value.ToString.Trim
            tabela = dgA.CurrentRow.Cells(1).Value.ToString.Trim

            Dim frm As New FormCATI(dsIst, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.tacv, Me.mfold, Me.DBConnectionString, Me.ri, istTabele, istPolja, istLK, txtInst,
                 Me.txtpismo, DSBrisanjeDEPO, DSBrisanjeServer, DSBrisanjeBaza, CATIServer, CATIBaza,
                 anketar, adresarCati, Me.txtVremeLogON.Text.Trim, ri.Item(0).ToString.Trim, nazivIst,
                 tabela, "", Me.ISTConnectionString, Me.txtmode, Me.txtZoiper)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
            End Try
            Me.Close()
        End If
    End Sub

End Class