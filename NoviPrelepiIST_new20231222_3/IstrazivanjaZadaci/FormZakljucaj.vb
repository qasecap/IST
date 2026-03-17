Option Strict Off
Imports System
Imports System.Data
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class FormZakljucaj
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
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

    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents ButtonZOZakljucaj As System.Windows.Forms.Button
    Friend WithEvents txtKoIstOtk As System.Windows.Forms.TextBox
    Friend WithEvents txtKoWin As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents b3 As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Logovan As System.Windows.Forms.Label
    Friend WithEvents PanelTop2 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents lblZO As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormZakljucaj))
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka()
        Me.ButtonZOZakljucaj = New System.Windows.Forms.Button()
        Me.txtKoIstOtk = New System.Windows.Forms.TextBox()
        Me.txtKoWin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblZO = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.PanelTop2 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.PanelTop2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ucvt
        '
        Me.ucvt.BackColor = System.Drawing.Color.Transparent
        Me.ucvt.Enabled = False
        Me.ucvt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvt.Location = New System.Drawing.Point(805, 6)
        Me.ucvt.Name = "ucvt"
        Me.ucvt.Size = New System.Drawing.Size(76, 36)
        Me.ucvt.TabIndex = 6
        Me.ucvt.Visible = False
        '
        'ButtonZOZakljucaj
        '
        Me.ButtonZOZakljucaj.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonZOZakljucaj.FlatAppearance.BorderSize = 0
        Me.ButtonZOZakljucaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonZOZakljucaj.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonZOZakljucaj.ForeColor = System.Drawing.Color.Black
        Me.ButtonZOZakljucaj.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonZOZakljucaj.Location = New System.Drawing.Point(467, 44)
        Me.ButtonZOZakljucaj.Name = "ButtonZOZakljucaj"
        Me.ButtonZOZakljucaj.Size = New System.Drawing.Size(137, 29)
        Me.ButtonZOZakljucaj.TabIndex = 21
        Me.ButtonZOZakljucaj.Text = "Уради"
        Me.ButtonZOZakljucaj.UseVisualStyleBackColor = False
        '
        'txtKoIstOtk
        '
        Me.txtKoIstOtk.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtKoIstOtk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKoIstOtk.ForeColor = System.Drawing.Color.Black
        Me.txtKoIstOtk.Location = New System.Drawing.Point(106, 51)
        Me.txtKoIstOtk.Name = "txtKoIstOtk"
        Me.txtKoIstOtk.Size = New System.Drawing.Size(320, 22)
        Me.txtKoIstOtk.TabIndex = 41
        '
        'txtKoWin
        '
        Me.txtKoWin.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtKoWin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKoWin.ForeColor = System.Drawing.Color.Black
        Me.txtKoWin.Location = New System.Drawing.Point(106, 19)
        Me.txtKoWin.Name = "txtKoWin"
        Me.txtKoWin.Size = New System.Drawing.Size(320, 22)
        Me.txtKoWin.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 15)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "user"
        '
        'lblZO
        '
        Me.lblZO.Location = New System.Drawing.Point(10, 51)
        Me.lblZO.Name = "lblZO"
        Me.lblZO.Size = New System.Drawing.Size(80, 15)
        Me.lblZO.TabIndex = 44
        Me.lblZO.Text = "откључава"
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnMinimizar)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(945, 40)
        Me.PanelTop.TabIndex = 143
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.Transparent
        Me.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b3.FlatAppearance.BorderSize = 0
        Me.b3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.Color.DarkOrange
        Me.b3.Location = New System.Drawing.Point(10, 4)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(240, 32)
        Me.b3.TabIndex = 183
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(862, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.UseVisualStyleBackColor = True
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
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(905, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Logovan
        '
        Me.Logovan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(653, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelTop2
        '
        Me.PanelTop2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.PanelTop2.Controls.Add(Me.txtKoWin)
        Me.PanelTop2.Controls.Add(Me.ButtonZOZakljucaj)
        Me.PanelTop2.Controls.Add(Me.lblZO)
        Me.PanelTop2.Controls.Add(Me.ucvt)
        Me.PanelTop2.Controls.Add(Me.Label1)
        Me.PanelTop2.Controls.Add(Me.txtKoIstOtk)
        Me.PanelTop2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop2.Location = New System.Drawing.Point(0, 40)
        Me.PanelTop2.Name = "PanelTop2"
        Me.PanelTop2.Size = New System.Drawing.Size(945, 100)
        Me.PanelTop2.TabIndex = 144
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 140)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(945, 432)
        Me.dgv.TabIndex = 145
        '
        'FormZakljucaj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(945, 572)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.PanelTop2)
        Me.Controls.Add(Me.PanelTop)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormZakljucaj"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop2.ResumeLayout(False)
        Me.PanelTop2.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    '*******
    Private originalExStyle As Integer = -1
    Private enableFormLevelDoubleBuffering As Boolean = True
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            If originalExStyle = -1 Then originalExStyle = MyBase.CreateParams.ExStyle
            Dim cp As CreateParams = MyBase.CreateParams

            If enableFormLevelDoubleBuffering Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            Else
                cp.ExStyle = originalExStyle
            End If
            Return cp
        End Get
    End Property
    Public Sub TurnOffFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = False
        'Me.MaximizeBox = True
    End Sub
    Public Sub TurnOnFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = True
        ' Me.MaximizeBox = True
    End Sub
    Private Sub Form_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        TurnOnFormLevelDoubleBuffering()
    End Sub

    Private Sub Form_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        TurnOffFormLevelDoubleBuffering()
    End Sub
    '*******

    Dim DBConnectionString As String
    Public ttab As DatasetIstrazivanja.ISTTABSDataTable
    Public istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Public istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Public istLK As DatasetIstrazivanja.ISTLKDataTable
    Public istBaze As DatasetIstrazivanja.ISTBAZEDataTable
    Public mrist As DatasetIstrazivanja.ISTRow

    Dim trtDSpom As System.Data.DataSet
    Public tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Public mTrt As String
    Public mKoIstOtk As String
    Public mxls As String
    Public mExcelXML As String
    Public mXML As String
    Public mXSL As String
    Public dword As String
    Public wfn As String = ""
    Public jesteExcelXML As Integer = 0
    Dim strFROMpom As String = ""
    Dim strSelectpom As String = ""
    Private m_zadaciIstrazivanje As IstrazivanjeZadaci = Nothing
    Private ReadOnly m_folderProgramaZaUnos As String
    Private ReadOnly Instalacija As String
    Public dgDT As System.Data.DataTable
    Dim ISTConnectionString As String
    Dim jezik As String

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                    ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                    ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable,
                    ByVal istPolja As DatasetIstrazivanja.ISTPOLJADataTable,
                    ByVal istLK As DatasetIstrazivanja.ISTLKDataTable,
                    ByVal istBaze As DatasetIstrazivanja.ISTBAZEDataTable,
                    ByVal mmb As DatasetIstrazivanja.ISTBAZERow,
                    ByVal ISTConnectionString As String, ByVal txtpismo As String, ByVal jezik As String)

        Me.New()

        Me.jezik = jezik
        Call SetLang()
        Me.Logovan.Text = GetUserName.ToString.Trim

        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Me.m_folderProgramaZaUnos = ""
        Me.Instalacija = ""

        Me.DBConnectionString = DBConnectionString
        Me.ISTConnectionString = ISTConnectionString

        Me.Text += " - " + ri.Naziv.Trim
        Me.ttab = ttab
        Me.istTabele = istTabele
        Me.istPolja = istPolja
        Me.istLK = istLK
        Me.istBaze = istBaze
        Me.mrist = ri

        ucvt.Init(vt)
        tacv = vt

        Me.txtKoWin.Text = GetUserName.ToString.Trim

        Me.txtKoIstOtk.Text = KoImaPravoDaOtkljuca()
        Me.mKoIstOtk = KoImaPravoDaOtkljuca()

        Dim i As Integer = 0

        dgDT = istTabele.Copy
        Dim brKol As Integer = 0
        brKol = dgDT.Columns.Count
        dgDT.Columns.Remove("RbrUnos")
        dgDT.Columns.Remove("BAZA")
        dgDT.Columns.Remove("aBAZA")
        dgDT.Columns.Remove("T1")
        dgDT.Columns.Remove("T2")
        dgDT.Columns.Remove("vdo")
        brKol = brKol - 6

        For j As Integer = 0 To brKol - 1
            dgDT.Columns(j).ReadOnly = True
        Next

        Dim zdcc As System.Data.DataColumn = New System.Data.DataColumn("Zakljucaj", System.Type.GetType("System.Boolean"))
        zdcc.DefaultValue = False
        dgDT.Columns.Add(zdcc)
        dgDT.Columns("Zakljucaj").ReadOnly = False

        Dim odcc As System.Data.DataColumn = New System.Data.DataColumn("Otkljucaj", System.Type.GetType("System.Boolean"))
        odcc.DefaultValue = False
        dgDT.Columns.Add(odcc)
        dgDT.Columns("Otkljucaj").ReadOnly = False

        Dim r As System.Data.DataRow
        For Each r In dgDT.Rows
            If ImaLK(r.Item("tabela").ToString.Trim) = 0 Then
                r.Delete()
            End If
        Next
        dgDT.AcceptChanges()
        'preostali imaju polje LK
        For j As Integer = 0 To dgDT.Rows.Count - 1
            dgDT.Rows(j).Item("zakljucaj") = ProveraLK(dgDT.Rows(j).Item("tabela").ToString.Trim)
        Next
        For j As Integer = 0 To dgDT.Rows.Count - 1
            dgDT.Rows(j).Item("otkljucaj") = IIf(ProveraLK(dgDT.Rows(j).Item("tabela").ToString.Trim), 0, 1)
        Next

        Call dgridDT(dgDT)
        Call srediGridView(Me.dgv, True, 50,,,,,,, 1)
        Dim sifist As String = CStr(mrist.SIFIST).Trim.ToUpper
        b3.Text = sifist + "    " + String.Format("{0:d2}", Me.tacv.M) + " / " + Me.tacv.G.ToString
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        ButtonZOZakljucaj.Text = getControlText2(dt, "ButtonZOZakljucaj", Me.jezik)
        lblZO.Text = getControlText2(dt, "lblZO", Me.jezik)

    End Sub

    Public Function KoImaPravoDaOtkljuca() As String
        KoImaPravoDaOtkljuca = ""
        Dim dISTPolja As New System.Data.DataTable

        Dim IzIst As String = CStr(mrist.SIFIST).Trim.ToUpper
        Dim sql As String = "select statisticar from vISTOdgovorni where SifIst='" + IzIst + "'"

        Try
            dISTPolja = izvrsiSQLvratiDT(sql, Me.ISTConnectionString, Nothing)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        If dISTPolja.Rows.Count > 0 Then
            KoImaPravoDaOtkljuca = dISTPolja.Rows(0).Item(0).ToString.Trim
        End If
        Return KoImaPravoDaOtkljuca
    End Function

    Private Function ImaLK(ByVal tabela As String) As Integer ' vraca 1 ako je zakljucan unos
        ImaLK = 0
        Dim sqlK As String = " select top 1 * from " & tabela & " where 2=2 "

        Dim dtK As System.Data.DataTable
        dtK = izvrsiSQLvratiDT(sqlK, DBConnectionString, Me.jezik)
        If Not (dtK Is Nothing) AndAlso dtK.Rows.Count > 0 Then
            'da li uopste postoji LK polje
            If Not (dtK.Columns("LK") Is Nothing) Then
                ImaLK = 1
            End If
        Else
        End If
        Return ImaLK
    End Function

    Private Function ProveraLK(ByVal tabela As String) As Integer ' vraca 1 ako je zakljucan unos
        ProveraLK = 0
        Dim sqlK As String = " select top 1 * from " & tabela & " where 2=2 "

        Dim dtK As System.Data.DataTable
        dtK = izvrsiSQLvratiDT(sqlK, DBConnectionString, Me.jezik)
        Dim sql As String = " select min(cast (isnull(LK,0) as integer)) as LK from " & tabela & " where 2=2 "

        If Not (dtK.Columns("GOD") Is Nothing) Then sql = sql + " and GOD ='" & Me.ucvt.G.ToString.Trim & "'"
        If Not (dtK.Columns("MES") Is Nothing) Then sql = sql + " and MES ='" & Me.ucvt.M.ToString.Trim.PadLeft(2, "0"c) & "'"

        If Not (dtK.Columns("ISTYEAR") Is Nothing) Then sql = sql + " and ISTYEAR ='" & Me.ucvt.G.ToString.Trim & "'"
        If Not (dtK.Columns("ISTMONTH") Is Nothing) Then sql = sql + " and ISTMONTH ='" & Me.ucvt.M.ToString.Trim.PadLeft(2, "0"c) & "'"

        Dim dt As System.Data.DataTable
        dt = izvrsiSQLvratiDT(sql, DBConnectionString, Me.jezik)

        'ako je min=1 to znaci da us svi iz vrtacke imaju LK 1 tj zakljucana tabela,
        'ako ima mesano onda 0
        If Not (dt.Rows(0).Item("LK") Is Nothing) AndAlso
        (Not (dt.Rows(0).Item("LK").GetType Is GetType(System.DBNull))) AndAlso dt.Rows(0).Item("LK") = 1 Then
            ProveraLK = 1
        End If

        Return ProveraLK
    End Function

    Private Sub ButtonZakljucaj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonZOZakljucaj.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call ZakljucajOtkljucaj(dgDT)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ZakljucajOtkljucaj(ByVal pom As System.Data.DataTable)
        Dim ra As Integer = 0
        Dim brT As Integer = 0

        Dim dISTPolja As New System.Data.DataTable

        Dim red As System.Data.DataRow
        Dim dss As New System.Data.DataTable
        dss = pom.Copy

        Dim poruka As Integer = 0

        For Each red In dss.Rows
            Try
                Dim dT As New System.Data.DataTable
                Dim ImaG As Boolean = False
                Dim ImaM As Boolean = False
                Dim ImaGE As Boolean = False
                Dim ImaME As Boolean = False
                Dim ImaLK As Boolean = False
                Dim sqlP As String = " select * from " & red.Item("tabela").ToString & " where 2=3"

                Try
                    dT = izvrsiSQLvratiDT(sqlP, Me.DBConnectionString, Nothing)
                Catch ex As System.Exception
                    ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

                Dim NulaJedan As String = ""
                If Not red.Item("zakljucaj") Is System.DBNull.Value Then
                    If CType(CType(red.Item("zakljucaj"), Object), Boolean) = True Then NulaJedan = "1"
                End If
                If Not red.Item("otkljucaj") Is System.DBNull.Value Then
                    If CType(CType(red.Item("otkljucaj"), Object), Boolean) = True Then NulaJedan = "0"
                End If

                If Not (dT.Columns("LK") Is Nothing) Then
                    brT += 1
                    Dim sqlVT As String = ""
                    If Not (dT.Columns("GOD") Is Nothing) Then ImaG = True : sqlVT += " AND GOD='" + Me.ucvt.G.ToString.Trim + "'"
                    If Not (dT.Columns("MES") Is Nothing) Then ImaM = True : sqlVT += " AND MES='" & Me.ucvt.M.ToString.Trim.PadLeft(2, "0"c) & "'"
                    If Not (dT.Columns("ISTYEAR") Is Nothing) Then ImaG = True : sqlVT += " AND ISTYEAR='" + Me.ucvt.G.ToString.Trim + "'"
                    If Not (dT.Columns("ISTMONTH") Is Nothing) Then ImaM = True : sqlVT += " AND ISTYEAR='" & Me.ucvt.M.ToString.Trim.PadLeft(2, "0"c) & "'"

                    ' da li je već zaključano ili otključano
                    Dim dTPK As New System.Data.DataTable
                    Dim sqlPLK As String = " select distinct LK as mLK from " & red.Item("tabela").ToString & " where 2=2 " & sqlVT
                    Try
                        dTPK = izvrsiSQLvratiDT(sqlPLK, Me.DBConnectionString, Nothing)
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                    Dim ZO As String = "M"
                    If dTPK.Rows.Count = 1 Then 'ili je sve otkljucano ili je sve zakljucano, ostalo je mešovito (M) pa akcija ide uvek
                        ZO = dTPK.Rows(0).Item("mLK").ToString.ToUpper.Trim
                        'kad je Null ZO=""
                    End If

                    Dim sqlLK As String = ""
                    Dim akcija As Boolean = False
                    If NulaJedan = "0" AndAlso (ZO = "TRUE" Or ZO = "M") Then
                        akcija = True
                        If Not (dT.Columns("datum_LKO") Is Nothing) Then sqlLK = sqlLK + ",datum_LKO=(CONVERT([varchar],getdate(),(120)))"
                        If Not (dT.Columns("ko_LKO") Is Nothing) Then sqlLK = sqlLK + ",ko_LKO=suser_sname()"
                    End If
                    If NulaJedan = "1" AndAlso (ZO = "FALSE" Or ZO = "M" Or ZO = "") Then
                        akcija = True
                        If Not (dT.Columns("datum_LKZ") Is Nothing) Then sqlLK = sqlLK + ",datum_LKZ=(CONVERT([varchar],getdate(),(120)))"
                        If Not (dT.Columns("ko_LKZ") Is Nothing) Then sqlLK = sqlLK + ",ko_LKZ=suser_sname()"
                    End If
                    Dim sql As String = ""
                    'DA ZAKLJUCA MOZE SVAKO KO IMA PRAVO NA ISTRAZIVANJE
                    If NulaJedan = "1" Then
                        sql = " update " & red.Item("tabela").ToString & " SET LK = '" & NulaJedan & "'" & sqlLK & " where 2=2 " & sqlVT
                        Dim ok1 As String = izvrsiSQL(sql, Me.DBConnectionString)
                        If ok1 <> "ok" Then
                            ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER39", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        poruka = 1
                    End If
                    If NulaJedan = "0" Then
                        If Me.mKoIstOtk.Trim.Length > 0 Then
                            If Me.txtKoWin.Text.Trim.ToUpper = Me.mKoIstOtk.Trim.ToUpper Then
                                sql = " update " & red.Item("tabela").ToString & " SET LK = '" & NulaJedan & "'" & sqlLK & " where 2=2 " & sqlVT
                                Dim ok1 As String = izvrsiSQL(sql, Me.DBConnectionString)
                                If ok1 <> "ok" Then
                                    ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER38", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                                poruka = 1
                            Else

                                ''msg 123
                                Dim msgtxt123 As String = getMessageText(dtMessages, "123", Me.jezik)
                                ISTMessageBox.Show(msgtxt123, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Else
                            '=0, tj nije definisano ko moze da otkljuca

                            ''msg 124
                            Dim msgtxt124 As String = getMessageText(dtMessages, "124", Me.jezik)
                            ISTMessageBox.Show(msgtxt124, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If ' ima LK
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Next
        ''msg 254
        Dim msgtxt254 As String = getMessageText(dtMessages, "254", Me.jezik)
        If poruka = 1 Then ISTMessageBox.Show(msgtxt254, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgridDT(ByVal dt As System.Data.DataTable)
        Try
            dgv.DataSource = dt
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Finally
        End Try
    End Sub
    Private Sub dgv1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim kolona As Integer = e.ColumnIndex
        Dim red As Integer = e.RowIndex
        Try
            If kolona = 6 Then
                If Not dgv.Rows(red).Cells(kolona).Value Is System.DBNull.Value Then
                    If dgv.Rows(red).Cells(kolona).Value = False Then
                        dgv.Rows(red).Cells(kolona).Value = True
                        dgv.Rows(red).Cells(kolona + 1).Value = False
                    End If
                End If
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            If kolona = 7 Then
                If Not dgv.Rows(red).Cells(kolona).Value Is System.DBNull.Value Then
                    If dgv.Rows(red).Cells(kolona).Value = False Then
                        dgv.Rows(red).Cells(kolona).Value = True
                        dgv.Rows(red).Cells(kolona - 1).Value = False
                    End If
                End If
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormZakljucaj_Load(sender As Object, e As EventArgs) Handles Me.Load

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