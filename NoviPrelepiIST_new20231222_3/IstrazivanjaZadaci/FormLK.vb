Option Strict Off

Public Class FormLK
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ButtonIzlaz As System.Windows.Forms.Button
    Friend WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Friend WithEvents GB1 As System.Windows.Forms.GroupBox
    Friend WithEvents clbSelect As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtUslov As System.Windows.Forms.TextBox
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents cboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents cboOP As System.Windows.Forms.ComboBox
    Friend WithEvents txtVrednost As System.Windows.Forms.TextBox
    Friend WithEvents cboVeznik As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonD As System.Windows.Forms.Button
    Friend WithEvents GBUslov As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonTrazi As System.Windows.Forms.Button
    Friend WithEvents ButtonPrikaziExcel As System.Windows.Forms.Button
    Friend WithEvents ButtonXML As System.Windows.Forms.Button
    Friend WithEvents ButtonPoništi As System.Windows.Forms.Button
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GB1 = New System.Windows.Forms.GroupBox
        Me.dg = New System.Windows.Forms.DataGrid
        Me.GBUslov = New System.Windows.Forms.GroupBox
        Me.cboSelect = New System.Windows.Forms.ComboBox
        Me.txtVrednost = New System.Windows.Forms.TextBox
        Me.cboVeznik = New System.Windows.Forms.ComboBox
        Me.ButtonD = New System.Windows.Forms.Button
        Me.cboOP = New System.Windows.Forms.ComboBox
        Me.txtUslov = New System.Windows.Forms.TextBox
        Me.clbSelect = New System.Windows.Forms.CheckedListBox
        Me.txtSQL = New System.Windows.Forms.TextBox
        Me.ButtonIzlaz = New System.Windows.Forms.Button
        Me.ucvt = New IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
        Me.ButtonTrazi = New System.Windows.Forms.Button
        Me.ButtonPrikaziExcel = New System.Windows.Forms.Button
        Me.ButtonXML = New System.Windows.Forms.Button
        Me.ButtonPoništi = New System.Windows.Forms.Button
        Me.GB1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBUslov.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB1
        '
        Me.GB1.Controls.Add(Me.dg)
        Me.GB1.Controls.Add(Me.GBUslov)
        Me.GB1.Controls.Add(Me.clbSelect)
        Me.GB1.Controls.Add(Me.txtSQL)
        Me.GB1.Location = New System.Drawing.Point(14, 80)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(914, 416)
        Me.GB1.TabIndex = 3
        Me.GB1.TabStop = False
        Me.GB1.Text = "Izaberite:"
        '
        'dg
        '
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.dg.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.dg.DataMember = ""
        Me.dg.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dg.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dg.Location = New System.Drawing.Point(8, 256)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.TabIndex = 19
        Me.dg.TabStop = False
        '
        'GBUslov
        '
        Me.GBUslov.Controls.Add(Me.cboSelect)
        Me.GBUslov.Controls.Add(Me.txtVrednost)
        Me.GBUslov.Controls.Add(Me.cboVeznik)
        Me.GBUslov.Controls.Add(Me.ButtonD)
        Me.GBUslov.Controls.Add(Me.cboOP)
        Me.GBUslov.Controls.Add(Me.txtUslov)
        Me.GBUslov.Location = New System.Drawing.Point(240, 16)
        Me.GBUslov.Name = "GBUslov"
        Me.GBUslov.Size = New System.Drawing.Size(664, 144)
        Me.GBUslov.TabIndex = 18
        Me.GBUslov.TabStop = False
        Me.GBUslov.Text = "Postavite uslov:"
        '
        'cboSelect
        '
        Me.cboSelect.Location = New System.Drawing.Point(8, 40)
        Me.cboSelect.Name = "cboSelect"
        Me.cboSelect.Size = New System.Drawing.Size(312, 22)
        Me.cboSelect.TabIndex = 13
        Me.cboSelect.Text = "Izaberite polje..."
        '
        'txtVrednost
        '
        Me.txtVrednost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVrednost.Location = New System.Drawing.Point(424, 40)
        Me.txtVrednost.Name = "txtVrednost"
        Me.txtVrednost.Size = New System.Drawing.Size(128, 22)
        Me.txtVrednost.TabIndex = 15
        Me.txtVrednost.Text = ""
        '
        'cboVeznik
        '
        Me.cboVeznik.Items.AddRange(New Object() {"AND", "OR"})
        Me.cboVeznik.Location = New System.Drawing.Point(556, 40)
        Me.cboVeznik.Name = "cboVeznik"
        Me.cboVeznik.Size = New System.Drawing.Size(64, 22)
        Me.cboVeznik.TabIndex = 16
        Me.cboVeznik.Text = "AND"
        '
        'ButtonD
        '
        Me.ButtonD.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonD.Location = New System.Drawing.Point(624, 40)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(22, 22)
        Me.ButtonD.TabIndex = 17
        Me.ButtonD.Text = "+"
        '
        'cboOP
        '
        Me.cboOP.Items.AddRange(New Object() {"=", ">=", "<=", ">", "<", "<>", "like", "not like", "between", "not between", "in", "not in", "is", "is not"})
        Me.cboOP.Location = New System.Drawing.Point(324, 40)
        Me.cboOP.Name = "cboOP"
        Me.cboOP.Size = New System.Drawing.Size(96, 22)
        Me.cboOP.TabIndex = 14
        Me.cboOP.Text = "="
        '
        'txtUslov
        '
        Me.txtUslov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUslov.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtUslov.Location = New System.Drawing.Point(8, 72)
        Me.txtUslov.Multiline = True
        Me.txtUslov.Name = "txtUslov"
        Me.txtUslov.Size = New System.Drawing.Size(640, 56)
        Me.txtUslov.TabIndex = 10
        Me.txtUslov.Text = ""
        '
        'clbSelect
        '
        Me.clbSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clbSelect.Location = New System.Drawing.Point(8, 24)
        Me.clbSelect.Name = "clbSelect"
        Me.clbSelect.Size = New System.Drawing.Size(224, 138)
        Me.clbSelect.TabIndex = 1
        '
        'txtSQL
        '
        Me.txtSQL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSQL.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtSQL.Location = New System.Drawing.Point(8, 176)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(896, 72)
        Me.txtSQL.TabIndex = 11
        Me.txtSQL.Text = ""
        '
        'ButtonIzlaz
        '
        Me.ButtonIzlaz.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonIzlaz.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonIzlaz.Location = New System.Drawing.Point(712, 16)
        Me.ButtonIzlaz.Name = "ButtonIzlaz"
        Me.ButtonIzlaz.Size = New System.Drawing.Size(88, 24)
        Me.ButtonIzlaz.TabIndex = 4
        Me.ButtonIzlaz.Text = "Izlaz"
        '
        'ucvt
        '
        Me.ucvt.Enabled = False
        Me.ucvt.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ucvt.Location = New System.Drawing.Point(8, 8)
        Me.ucvt.Name = "ucvt"
        Me.ucvt.Size = New System.Drawing.Size(130, 58)
        Me.ucvt.TabIndex = 6
        '
        'ButtonTrazi
        '
        Me.ButtonTrazi.BackColor = System.Drawing.Color.RosyBrown
        Me.ButtonTrazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonTrazi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonTrazi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonTrazi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonTrazi.Location = New System.Drawing.Point(264, 16)
        Me.ButtonTrazi.Name = "ButtonTrazi"
        Me.ButtonTrazi.Size = New System.Drawing.Size(88, 24)
        Me.ButtonTrazi.TabIndex = 21
        Me.ButtonTrazi.Text = "Traži"
        '
        'ButtonPrikaziExcel
        '
        Me.ButtonPrikaziExcel.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonPrikaziExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrikaziExcel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonPrikaziExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPrikaziExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonPrikaziExcel.Location = New System.Drawing.Point(528, 16)
        Me.ButtonPrikaziExcel.Name = "ButtonPrikaziExcel"
        Me.ButtonPrikaziExcel.Size = New System.Drawing.Size(88, 24)
        Me.ButtonPrikaziExcel.TabIndex = 5
        Me.ButtonPrikaziExcel.Text = "Excel"
        '
        'ButtonXML
        '
        Me.ButtonXML.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonXML.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonXML.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonXML.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonXML.Location = New System.Drawing.Point(620, 16)
        Me.ButtonXML.Name = "ButtonXML"
        Me.ButtonXML.Size = New System.Drawing.Size(88, 24)
        Me.ButtonXML.TabIndex = 7
        Me.ButtonXML.Text = "XML"
        '
        'ButtonPoništi
        '
        Me.ButtonPoništi.BackColor = System.Drawing.Color.RosyBrown
        Me.ButtonPoništi.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPoništi.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonPoništi.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonPoništi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonPoništi.Location = New System.Drawing.Point(360, 16)
        Me.ButtonPoništi.Name = "ButtonPoništi"
        Me.ButtonPoništi.Size = New System.Drawing.Size(88, 24)
        Me.ButtonPoništi.TabIndex = 22
        Me.ButtonPoništi.Text = "Poništi"
        '
        'FormNPretraga
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(945, 528)
        Me.Controls.Add(Me.ButtonPoništi)
        Me.Controls.Add(Me.ucvt)
        Me.Controls.Add(Me.ButtonIzlaz)
        Me.Controls.Add(Me.GB1)
        Me.Controls.Add(Me.ButtonXML)
        Me.Controls.Add(Me.ButtonPrikaziExcel)
        Me.Controls.Add(Me.ButtonTrazi)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormNPretraga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Napredna pretraga"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GB1.ResumeLayout(False)
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBUslov.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ms As String
    Public ttab As DatasetIstrazivanja.ISTTABSDataTable
    Public istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Public istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Public istLK As DatasetIstrazivanja.ISTLKDataTable
    Public istBaze As DatasetIstrazivanja.ISTBAZEDataTable
    Public mrist As DatasetIstrazivanja.ISTRow

    Dim trtDSpom As System.Data.DataSet
    Public tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Public mTrt As String
    Public mxls As String
    Public mExcelXML As String
    Public mXML As String
    Public mXSL As String
    Public dword As String
    Public wfn As String = ""
    Public jesteExcelXML As Integer = 0
    Dim strFROMpom As String = ""
    Dim strSelectpom As String = ""

    Public Sub New(ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, _
                    ByVal s As String, ByVal ri As DatasetIstrazivanja.ISTRow, _
                    ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable, _
                    ByVal istPolja As DatasetIstrazivanja.ISTPOLJADataTable, _
                    ByVal istLK As DatasetIstrazivanja.ISTLKDataTable, _
                    ByVal istBaze As DatasetIstrazivanja.ISTBAZEDataTable, _
                    ByVal mmb As DatasetIstrazivanja.ISTBAZERow)

        Me.New()
        Me.HP.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.HP.SetHelpKeyword(Me, "Izv.htm")
        Me.HP.SetShowHelp(Me, True)

        Dim ww As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width()
        Dim hh As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height()

        Me.GB1.Height = hh - ucvt.Height - 100
        Me.GB1.Width = ww - 100

        Me.clbSelect.Width = Me.GB1.Width - Me.GBUslov.Width - 20
        Me.GBUslov.Location = New System.Drawing.Point(Me.clbSelect.Location.X + Me.clbSelect.Width + 5, Me.clbSelect.Location.Y)

        Me.clbSelect.Height = 0.25 * Me.GB1.Height - 50
        Me.clbSelect.Height = 0.25 * Me.GB1.Height - 50
        Me.GBUslov.Height = 0.25 * Me.GB1.Height - 50

        Me.txtSQL.Location = New System.Drawing.Point(Me.clbSelect.Location.X, Me.clbSelect.Location.Y + Me.clbSelect.Height + 10)
        Me.txtSQL.Width = Me.GB1.Width - 20
        Me.txtSQL.Height = 0.2 * Me.GB1.Height - 50

        dg.Location = New System.Drawing.Point(Me.txtSQL.Location.X, Me.txtSQL.Location.Y + Me.txtSQL.Height + 10)
        dg.Width = Me.txtSQL.Width
        dg.Height = Me.GB1.Height - 50 - Me.txtSQL.Height - Me.clbSelect.Height
        'Me.ButtonIzlaz.Location = New System.Drawing.Point(ww - 100, 8)

        Me.Text += " - " + ri.Naziv.Trim
        Me.ttab = ttab
        Me.istTabele = istTabele
        Me.istPolja = istPolja
        Me.istLK = istLK
        Me.istBaze = istBaze
        Me.mrist = ri
        Me.ms = s
        ucvt.Init(vt)
        tacv = vt

        Dim vistPolja As System.Data.DataView
        vistPolja = istPolja.DefaultView
        vistPolja.Sort = "tabela , rbr"

        Dim tt As String
        Dim pp As String
        Dim ii As String
        Dim tt_pp As String
        Dim i As Integer = 0

        Dim dt As New System.Data.DataTable
        dt.Columns.Add("tabela")
        dt.Columns.Add("polje")
        dt.Columns.Add("izraz")
        dt.Columns.Add("tabelaPolje")

        Dim dt2 As New System.Data.DataTable
        dt2.Columns.Add("tabela")
        dt2.Columns.Add("polje")
        dt2.Columns.Add("izraz")
        dt2.Columns.Add("tabelaPolje")

        For i = 0 To vistPolja.Count - 1
            If vistPolja.Item(i).Item("izraz") Is System.DBNull.Value OrElse vistPolja.Item(i).Item("izraz") = "" Then
                ii = " "
            Else
                ii = vistPolja.Item(i).Item("izraz")
            End If

            If vistPolja.Item(i).Item("polje").IndexOf("nonFilter") > -1 OrElse ii.Substring(0, 1) = "'" Then
                'da uopse ne udju oni koji nisu FP već samo "glume" labele - to su oni kojima je izraz 'pa nešto'
            Else
                tt = vistPolja.Item(i).Item("tabela")
                pp = vistPolja.Item(i).Item("polje")
                tt_pp = tt.Trim & "_" & pp.Trim

                dt.Rows.Add(New Object() {tt, pp, ii.Trim, tt_pp})
                dt2.Rows.Add(New Object() {tt, pp, ii.Trim, tt_pp})
            End If
        Next

        Me.clbSelect.DataSource = dt
        Me.clbSelect.DisplayMember = dt.Columns("tabelaPolje").ColumnName
        Me.clbSelect.ValueMember = dt.Columns("izraz").ColumnName

        Me.cboSelect.DataSource = dt2
        Me.cboSelect.DisplayMember = dt2.Columns("tabelaPolje").ColumnName
        Me.cboSelect.ValueMember = dt2.Columns("izraz").ColumnName

        ms = s
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

    End Sub

    Private Sub FormIzvestaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub ButtonD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonD.Click
        Dim pom As String
        Dim pomCir As String
        Dim pomLat As String
        Dim tabelapolje As String
        Dim tabela As String
        Dim polje As String
        Dim izraz As String
        Dim op As String
        Dim vred As String = Me.txtVrednost.Text.Trim

        op = Me.cboOP.SelectedItem
        tabelapolje = CType(CType(cboSelect.SelectedItem, Object), System.Data.DataRowView).Item("tabelapolje")
        tabela = CType(CType(cboSelect.SelectedItem, Object), System.Data.DataRowView).Item("tabela")
        polje = CType(CType(cboSelect.SelectedItem, Object), System.Data.DataRowView).Item("polje")
        izraz = CType(CType(cboSelect.SelectedItem, Object), System.Data.DataRowView).Item("izraz")

        If strFROMpom.IndexOf(tabela) = -1 Then
            strFROMpom = strFROMpom & tabela & ","
        Else
            'vec postoji, ne dodajem tabelu u FROM
        End If

        If izraz.Length > 0 Then 'postoji FP
            izraz = izraz.Replace("#", "")
            izraz = izraz.Replace("{", "")
            izraz = izraz.Replace("}", "")
            izraz = izraz.Replace(":SN", "")
            izraz = izraz.Replace(":S", "")
            izraz = izraz.Replace("d.", tabela & ".")
            If strSelectpom.IndexOf(tabelapolje) = -1 Then
                strSelectpom = strSelectpom & "(" & izraz & ") AS " & tabelapolje & ","
            Else 'vec postoji, ne dodajem u strSelectpom
            End If
        Else
            If strSelectpom.IndexOf(tabelapolje) = -1 Then
                strSelectpom = strSelectpom & " " & tabela & "." & polje & " AS " & tabelapolje & ","
            Else 'vec postoji, ne dodajem u strSelectpom
            End If
        End If

        If op.IndexOf("in") > -1 Then     'in; not in
            vred = vred.Trim
            vred = vred.Replace("(", "")
            vred = vred.Replace(")", "")
            vred = vred.Replace("'", "")
            vred = vred.Replace(";", ",")
            Dim trt() As String = vred.Trim.Split(","c)
            Dim bb As String = "('"
            For l As Integer = 0 To trt.GetUpperBound(0)
                bb = bb + trt(l) + "','"
            Next
            bb = bb.Trim.Substring(0, strFROMpom.Trim.LastIndexOf("','"))
            bb = bb + ")"
            vred = bb
        End If
        If op.IndexOf("like") > -1 Then    'like; not like
            pom = tabelapolje & " " & op & " N'%" & vred & "%'"
        Else
            pom = tabelapolje & " " & op & " N'" & vred & "'"
        End If

        If IsNumeric(vred) = True Then
        Else
            Dim vredCir As String = konverzijaLatCir(vred)
            Dim vredLat As String = konverzijaCirLat(vred)
            If op.IndexOf("like") > -1 Then
                pomCir = "(" & tabelapolje & " " & op & " N'%" & vredCir & "%')"
                pomLat = "(" & tabelapolje & " " & op & " N'%" & vredLat & "%')"
                pom = pomCir & " OR " & pomLat
            Else
                pomCir = "(" & tabelapolje & " " & op & " N'" & vredCir & "')"
                pomLat = "(" & tabelapolje & " " & op & " N'" & vredLat & "')"
                pom = pomCir & " OR " & pomLat
            End If
        End If

        If Me.txtUslov.Text.Trim.Length > 0 Then
            Me.txtUslov.Text = "(" & Me.txtUslov.Text & ") " & Me.cboVeznik.SelectedItem & " " & pom
        Else
            Me.txtUslov.Text = pom
        End If
        'If vred.Trim.Length > 0 Then
        'Else
        '    System.Windows.Forms.MessageBox.Show("Unesite vrednost za poređenje!", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
        'End If
    End Sub

    Private Sub ButtonTrazi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTrazi.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim strSQLpom As String
        Dim strSelect As String = ""
        Dim strJOIN As String = ""
        Dim strCount As String = ""

        Dim tabela As String
        Dim polje As String
        Dim izraz As String
        Dim tabelapolje As String

        If Me.clbSelect.CheckedItems.Count > 0 Then
            For i As Integer = 0 To Me.clbSelect.CheckedItems.Count - 1
                tabelapolje = CType(CType(clbSelect.CheckedItems.Item(i), Object), System.Data.DataRowView).Item("tabelapolje")
                izraz = CType(CType(clbSelect.CheckedItems.Item(i), Object), System.Data.DataRowView).Item("izraz")
                tabela = CType(CType(clbSelect.CheckedItems.Item(i), Object), System.Data.DataRowView).Item("tabela")
                polje = CType(CType(clbSelect.CheckedItems.Item(i), Object), System.Data.DataRowView).Item("polje")

                If strFROMpom.IndexOf(tabela) = -1 Then
                    strFROMpom = strFROMpom & tabela & ","
                Else 'vec postoji, ne dodajem tabelu u FROM
                End If

                If izraz.Length > 0 Then
                    'postoji FP
                    izraz = izraz.Replace("#", "")
                    izraz = izraz.Replace("{", "")
                    izraz = izraz.Replace("}", "")
                    izraz = izraz.Replace(":SN", "")
                    izraz = izraz.Replace(":S", "")
                    izraz = izraz.Replace("d.", tabela & ".")

                    If strSelectpom.IndexOf(tabelapolje) = -1 Then
                        strSelectpom = strSelectpom & "(" & izraz & ") AS " & tabelapolje & ","
                    Else 'vec postoji, ne dodajem u strSelectpom
                    End If
                Else
                    If strSelectpom.IndexOf(tabelapolje) = -1 Then
                        strSelectpom = strSelectpom & " " & tabela & "." & polje & " AS " & tabelapolje & ","
                    Else 'vec postoji, ne dodajem u strSelectpom
                    End If
                End If
                strSelect = strSelect & tabelapolje & ","
            Next

            Dim nizTabela() As String = strFROMpom.Trim.Substring(0, strFROMpom.Trim.LastIndexOf(",")).Split(","c)
            If nizTabela.GetUpperBound(0) = 0 Then 'samo jedna u strFROMpom - ne idi u relacije
            Else
                strJOIN = SklopiRelacije(nizTabela)
                If strJOIN.Length > 0 Then
                    strJOIN = " and " + strJOIN
                End If
            End If

            'skini poslednji zarez sa strFROMpom
            strFROMpom = strFROMpom.Trim.Substring(0, strFROMpom.Trim.LastIndexOf(","))

            'skini poslednji zarez sa strSelectpom
            strSelectpom = strSelectpom.Trim.Substring(0, strSelectpom.Trim.LastIndexOf(","))
            strSelectpom = Space(6) & "SELECT " & strSelectpom & vbCrLf _
                         & Space(6) & "FROM " & strFROMpom & vbCrLf _
                         & Space(6) & "WHERE 2=2 " & strJOIN

            'skini poslednji zarez sa strSelect
            strSelect = strSelect.Trim.Substring(0, strSelect.Trim.LastIndexOf(","))
            strSelect = "SELECT distinct " & strSelect & vbCrLf _
                      & "FROM (" & vbCrLf _
                      & strSelectpom & vbCrLf _
                      & ") AAA " & vbCrLf _
                      & "WHERE 2=2 "

            If txtUslov.Text.Length > 0 Then
                strSelect = strSelect & " AND (" & Me.txtUslov.Text.Trim & ")"
            End If

            Me.txtSQL.Text = strSelect.Trim
            Call dgrid(strSelect)
        ElseIf Me.txtSQL.Text.Trim.Length > 0 Then
            'ako postoji nešto u Me.txtSQL.Text.Trim da ga izvrši
            'ovo je ako neko hoće sam da piše neki upit
            Call dgrid(Me.txtSQL.Text.Trim)
        Else
            System.Windows.Forms.MessageBox.Show("Nije ništa izabrano!", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Private Function SklopiRelacije(ByVal tabele() As String) As String
        'za sve tabele koje su inicijalno u strFROMpom
        Dim broj As Integer = 1
        'PRVO protrci kroz ISTTabele
        'kroz polje tabela
        ' ako nađe tabelu u polju tabela i ako polje nadtabela nije prazno
        ' - pravi relaciju preko kljuceva ove 2 tabele; to ide u JOIN
        '(dodaje i tabelu iz polja nadtabela u strFROMpom ako je tamo nema)
        Dim niz() As String = {}
        Dim trt As String = ""
        Dim redISTTabele As DatasetIstrazivanja.ISTTABELERow
        Dim redISTLK As DatasetIstrazivanja.ISTLKRow
        Dim redISTPolja As DatasetIstrazivanja.ISTPOLJARow
        Dim redISTBaze As DatasetIstrazivanja.ISTBAZERow
        Dim kk As Integer
        Dim i As Integer = -1

        Dim w As String = ""
        For kk = 0 To tabele.GetUpperBound(0)
            For Each redISTTabele In istTabele.Rows
                If redISTTabele.Tabela.Trim.ToUpper = tabele(kk).Trim.ToUpper Then
                    If Not redISTTabele.IsNadTabelaNull Then
                        If strFROMpom.Trim.ToUpper.IndexOf(redISTTabele.NadTabela.Trim.ToUpper & ",") = -1 Then
                            strFROMpom = strFROMpom & redISTTabele.NadTabela & ","
                        Else 'vec postoji, ne dodajem tabelu u FROM
                        End If
                        'pravi relaciju spajam rt.NadTabela i rt.Tabela po kljucevima
                        For Each r As DatasetIstrazivanja.ISTPOLJARow In istPolja
                            If r.TABELA.Trim.ToUpper = redISTTabele.NadTabela.Trim.ToUpper Then
                                If Not r.IsKLJUCNull AndAlso r.KLJUC.Trim.ToUpper = "P" Then
                                    w = w + redISTTabele.NadTabela.Trim + "." + r.POLJE.Trim + "=" + redISTTabele.Tabela.Trim + "." + r.POLJE.Trim.Trim & " AND "
                                End If
                            End If
                        Next
                    End If
                    If w <> "" Then
                        trt = trt + w
                        w = ""
                    End If
                End If
            Next
            'Next
            ' u nizu niz su sad sve relacije iz ISTTabele
            w = ""

            'DRUGO  protrci kroz ISTLK
            'kroz polje greska
            'ako nađe tabelu u polju greska (u okviru Relacija, Konsult, Adresar)
            '21  relacija + tabelu
            '22  Konsult + tabelu
            '23  Adresar + tabelu

            ' - pravi relaciju iz te tabele i tabele iz polja tabela; to ide u JOIN
            '(dodaje i tabelu iz polja tabela u strFROMpom ako je tamo nema)

            Dim gr As String
            Dim rel As String

            ' For kk = 0 To tabele.GetUpperBound(0)
            For Each redISTLK In istLK.Rows
                gr = redISTLK.GRESKA.Trim.Replace(" ", "")
                '21
                If InStr(1, gr, "#Relacija", CompareMethod.Text) > 0 Then
                    Dim p As Integer = InStr(1, gr, "#Relacija", CompareMethod.Text)
                    Dim t As Integer = InStr(p, gr, "}", CompareMethod.Text)
                    rel = gr.Substring(p - 1, t - p + 1)
                    rel = rel.Replace("#Relacija{", "")
                    rel = rel.Replace("}", "")
                    rel = rel.Trim
                    Dim tackaZarez As Integer = rel.IndexOf(";")
                    If tackaZarez < 0 Then
                        Throw New System.Exception("Greška kod RELACIJA funkcije")
                    End If
                    Dim relTab As String = rel.Substring(0, tackaZarez).Trim
                    If relTab.Trim.ToUpper = tabele(kk).Trim.ToUpper Then   'postoji bas ta u relaciji
                        If strFROMpom.Trim.ToUpper.IndexOf(redISTLK.TABELA.Trim.ToUpper & ",") = -1 Then
                            strFROMpom = strFROMpom & redISTLK.TABELA.Trim & ","
                        Else 'vec postoji, ne dodajem tabelu u FROM
                        End If

                        Dim poljaRel() As String = rel.Substring(tackaZarez + 1).Split(","c)
                        If poljaRel.Length = 0 Then
                            Throw New System.Exception("Greška kod RELACIJA funkcije")
                        End If
                        Dim kl As Integer
                        For kl = 0 To poljaRel.GetUpperBound(0)
                            If w <> "" Then
                                w += " AND "
                            End If
                            Dim kk1() As String = poljaRel(kl).Split("="c)
                            w = w + redISTLK.TABELA.Trim + "." + kk1(0).Trim + "=" + relTab + "." + kk1(1).Trim
                        Next
                        If kl <= 0 Then
                            Throw New System.Exception("Greška kod RELACIJA funkcije")
                        Else
                            If trt.Trim.ToUpper.IndexOf(w.Trim.ToUpper) = -1 Then
                                trt = trt + w
                            Else 'vec postoji, ne dodajem tabelu u FROM
                            End If
                            w = ""
                        End If
                    End If
                End If '#Relacija{Kontrolnik;
                Dim polje As String
                Dim tabKonsult As String
                Dim bazaKonsult As String
                Dim pompom As String

                If InStr(1, gr, "#Konsult", CompareMethod.Text) > 0 Then
                    Dim p As Integer = InStr(1, gr, "#Konsult", CompareMethod.Text)
                    Dim t As Integer = InStr(p, gr, "}", CompareMethod.Text)
                    polje = gr.Substring(p - 1, t - p + 1)
                    polje = polje.Replace("#Konsult{", "")
                    polje = polje.Replace("}", "")
                    polje = polje.Trim

                    'za to polje odlazim u istPOLJA 
                    For Each redISTPolja In istPolja.Rows
                        If redISTPolja.TABELA.Trim.ToUpper = redISTLK.TABELA.Trim.ToUpper Then
                            If redISTPolja.POLJE.Trim.ToUpper = polje.Trim.ToUpper Then
                                For Each redISTBaze In istBaze.Rows
                                    If redISTBaze.Baza.Trim.ToUpper = redISTPolja.RelBaza.Trim.ToUpper Then
                                        If redISTBaze.FizBaza.Trim.ToLower = "ss" Then
                                            Dim db As String = conparametar(redISTBaze.IzrazODBC.Trim, "database")
                                            If db = "" Then
                                                db = conparametar(redISTBaze.IzrazODBC.Trim, "initial catalog")
                                                If db = "" Then
                                                    db = redISTBaze.Baza.Trim
                                                End If
                                            End If
                                            bazaKonsult = db
                                            Exit For
                                        End If
                                    End If
                                Next
                                tabKonsult = "[" & bazaKonsult & "].[dbo].[" & redISTPolja.RelTabela.Trim & "]"
                                broj = broj + 1
                                tabKonsult = tabKonsult & " AS Kons" & Str(broj).Trim

                                If strFROMpom.Trim.ToUpper.IndexOf(tabKonsult.Trim.ToUpper & ",") = -1 Then
                                    strFROMpom = strFROMpom & tabKonsult.Trim & ","
                                Else 'vec postoji, ne dodajem tabelu u FROM
                                End If

                                trt = trt + redISTPolja.TABELA.Trim + "." & redISTPolja.POLJE.Trim & "=Kons" & Str(broj).Trim & ".[" & redISTPolja.RelPolje.Trim & "] AND "

                                'trt = trt + redISTPolja.TABELA.Trim + "." & redISTPolja.POLJE.Trim & "=" & tabKonsult & ".[" & redISTPolja.RelPolje.Trim & "] AND "
                                Exit For
                            End If
                        End If
                    Next


                    'If strFROMpom.Trim.ToUpper.IndexOf(tabKonsult.Trim.ToUpper & ",") = -1 Then
                    '    strFROMpom = strFROMpom & tabKonsult.Trim & ","
                    'Else 'vec postoji, ne dodajem tabelu u FROM
                    'End If


                    If strFROMpom.Trim.ToUpper.IndexOf(redISTLK.TABELA.Trim.ToUpper & ",") = -1 Then
                        strFROMpom = strFROMpom & redISTLK.TABELA.Trim & ","
                    Else 'vec postoji, ne dodajem tabelu u FROM
                    End If


                End If '#Konsult{Kd08}
                If InStr(1, gr, "#Adresar", CompareMethod.Text) > 0 Then
                    Dim p As Integer = InStr(1, gr, "#Adresar", CompareMethod.Text)
                    Dim t As Integer = InStr(p, gr, "}", CompareMethod.Text)
                    rel = gr.Substring(p - 1, t - p + 1)
                    rel = rel.Replace("#Adresar{", "")
                    rel = rel.Replace("}", "")
                    rel = rel.Trim
                End If '#Adresar{GRA11;
            Next
        Next
        trt = trt.Substring(0, trt.LastIndexOf(" AND "))
        Return trt
    End Function
    Private Function conparametar(ByVal connectionString As String, ByVal parameter As String) As String
        Dim i As Integer = connectionString.ToLower.IndexOf(parameter)
        Dim iStart As Integer = i
        If i >= 0 Then
            i = connectionString.IndexOf("=", i + 1)
            If i >= 0 Then
                Dim j As Integer = connectionString.IndexOf(";", i + 1)
                If j >= 0 Then
                    Return connectionString.Substring(i + 1, j - i - 1).Trim
                Else : Return connectionString.Substring(i + 1).Trim
                End If
            End If
        End If
        Return ""
    End Function
    Private Sub dgrid(ByVal str As String)
        Dim c As New System.Data.OleDb.OleDbConnection(Me.ms)
        Dim cmd As New System.Data.OleDb.OleDbCommand
        Dim adp As System.Data.OleDb.OleDbDataAdapter
        Dim rs As Long
        Try
            c.Open()
            cmd.CommandTimeout = 0
            cmd.CommandText = str
            cmd.Connection = c
            adp = New System.Data.OleDb.OleDbDataAdapter(cmd)
            Dim trtDS As New System.Data.DataSet
            adp.Fill(trtDS)
            rs = trtDS.Tables(0).Rows.Count

            If rs > 20 AndAlso System.Windows.Forms.MessageBox.Show("Pronađen broj slogova: " + rs.ToString + ". Prikazati?", "Filter", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button1) = System.Windows.Forms.DialogResult.No Then
            Else
                dg.DataSource = trtDS.Tables(0)

                'sredi grid
                Dim ts As New System.Windows.Forms.DataGridTableStyle
                ts.MappingName = trtDS.Tables(0).TableName
                dg.TableStyles.Clear()
                dg.TableStyles.Add(ts)
                Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromHwnd(dg.Handle)
                Dim sf As System.Drawing.StringFormat = New System.Drawing.StringFormat(System.Drawing.StringFormat.GenericTypographic)
                Dim size As System.Drawing.SizeF
                Dim width As Single
                Dim row, col As Integer
                Dim totalRows As Integer = CType(dg.DataSource, System.data.DataTable).Rows.Count
                Dim countRows As Integer = totalRows
                Dim countColumns As Integer = CType(dg.DataSource, System.data.DataTable).Columns.Count
                Dim caption As String
                If countColumns > 0 Then
                    For col = 0 To countColumns - 1
                        caption = CType(dg.DataSource, System.Data.DataTable).Columns(col).Caption.ToString
                        size = g.MeasureString(caption, dg.HeaderFont, 200, sf)
                        width = size.Width + 15
                        If countRows > 0 Then
                            For row = 0 To countRows - 1
                                size = g.MeasureString(dg(row, col).ToString, dg.Font, 200, sf)
                                If (size.Width + 15 > width) Then
                                    width = size.Width + 15
                                End If
                            Next
                            dg.TableStyles(ts.MappingName).GridColumnStyles(col).Width = CType(width, Integer)
                            dg.TableStyles(ts.MappingName).GridColumnStyles(col).NullText = ""
                        End If
                    Next
                End If
                ts = Nothing
                g.Dispose()

                'visina grida NEPOTREBNO
                'If countRows > 0 Then
                '    Dim r As System.Drawing.Rectangle = dg.GetCellBounds(countRows - 1, 0)
                '    Dim s As System.Drawing.Size = dg.ClientSize
                '    s.Height = r.Y + r.Height + 20
                '    dg.ClientSize = s
                'Else
                'End If
                'sredi grid     


                'Dim mGTS As System.Windows.Forms.DataGridTableStyle = New System.Windows.Forms.DataGridTableStyle
                'mGTS.MappingName = trtDS.Tables(0).TableName

                'dg.TableStyles.Clear()
                'dg.TableStyles.Add(mGTS)
                'mGTS = dg.TableStyles.Item(0)

                'Dim mCS As System.Windows.Forms.DataGridColumnStyle
                'For i As Integer = 0 To mGTS.GridColumnStyles.Count - 1
                '    mCS = mGTS.GridColumnStyles.Item(i)
                '    mCS.Width = 0.8 * 10 * trtDS.Tables(0).Columns.Item(i).Caption.Trim.Length
                '    mCS.NullText = ""
                'Next
                dg.CaptionText = "Pronađen broj slogova: " + rs.ToString.Trim + ""
            End If
            trtDSpom = trtDS.Copy

        Catch ex As System.Exception
            adp.Dispose()
            System.Windows.Forms.MessageBox.Show(ex.Message, "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error)
            Return
        Finally
            adp.Dispose()
            If Not cmd Is Nothing Then
                cmd.Dispose()
            End If
            c.Dispose()
        End Try

        Call ponisti()
    End Sub
    Private Sub ponisti()
        Me.txtUslov.Text = ""
        Dim i As Integer
        For i = 0 To (clbSelect.Items.Count - 1)
            clbSelect.SetItemChecked(i, False)
        Next
        strFROMpom = ""
        strSelectpom = ""
    End Sub
    Private Sub ButtonPoništi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPoništi.Click
        Call ponisti()
        Me.txtSQL.Text = ""
        dg.DataSource = Nothing
        dg.CaptionText = ""
    End Sub

    Private Sub ButtonPrikaziExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrikaziExcel.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Export2Excel()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Public Sub Export2Excel()
        Dim e As Object

        Dim DS As System.Data.DataSet = trtDSpom
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        e = CreateObject("Excel.Application")

        Dim s, b, t As Object
        b = e.Workbooks.Add
        Dim ww As Object

        Dim dt As System.Data.DataTable = DS.Tables(0)
        t = dg.TableStyles(0).GridColumnStyles()
        ww = b.Worksheets.Item(1)
        Dim row, col, i As Integer
        col = 1
        row = 1
        Dim matrica(dt.Rows.Count, -1) As Object

        For Each s In t
            ReDim Preserve matrica(dt.Rows.Count, 1 + matrica.GetUpperBound(1))
            matrica(0, col - 1) = s.MappingName
            col = col + 1
        Next

        If col > 255 Or dt.Rows.Count > 65535 Then
            If System.Windows.Forms.MessageBox.Show("Kolona: " & CStr(col) & "; redova: " & CStr(dt.Rows.Count) & ". Postoji mogućnost da ne uspe prenos u Excel. Nastavljam?", "?Excel", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Exclamation, System.Windows.Forms.MessageBoxDefaultButton.Button2) <> System.Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
        End If

        Dim tipKolone As String
        For kolona As Integer = 0 To col - 2

            tipKolone = dt.Rows(0).Item(matrica(0, kolona)).GetType.ToString
            If tipKolone.Trim = "System.String" Then
                For red As Integer = 0 To dt.Rows.Count - 1
                    matrica(red + 1, kolona) = "'" + dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper).tostring.trim
                Next
            Else
                For red As Integer = 0 To dt.Rows.Count - 1
                    matrica(red + 1, kolona) = dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper)
                Next
            End If
        Next

        e.visible = True
        ww.Range("A1").Resize(matrica.GetUpperBound(0) + 1, matrica.GetUpperBound(1) + 1).value = matrica

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub

    Private Sub ButtonXML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonXML.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Export2XML(mrist.SIFIST.Trim & "_" & tacv.G.ToString.Trim & tacv.M.ToString.Trim.PadLeft(2, "0"c) & "_PODACI")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    Public Sub Export2XML(ByVal imedttk As String)
        Dim DS1 As System.Data.DataSet = trtDSpom
        Dim DS As New System.Data.DataSet
        Dim nt As New System.Data.DataTable
        nt.TableName = trtDSpom.Tables(0).TableName
        Dim t As Object = dg.TableStyles(0).GridColumnStyles()
        For Each s As Object In t
            Dim kk As New System.Data.DataColumn
            kk.ColumnName = CStr(s.MappingName)
            kk.DataType = DS1.Tables(0).Columns(CStr(s.MappingName)).DataType
            nt.Columns.Add(kk)
        Next
        DS.Tables.Add(nt)
        For i As Integer = 0 To DS1.Tables(0).Rows.Count - 1
            Dim red() As Object = {}
            For Each c As System.Data.DataColumn In DS.Tables(0).Columns
                ReDim Preserve red(1 + red.GetUpperBound(0))
                red(red.GetUpperBound(0)) = DS1.Tables(0).Rows(i).Item(c.ColumnName)
            Next
            DS.Tables(0).Rows.Add(red)
        Next
        Dim dlg As New System.Windows.Forms.SaveFileDialog
        dlg.Filter = "XML files (*.xml)|*.xml"
        dlg.FileName = imedttk & "_A" 'dlg.InitialDirectory + "\" + 
        Dim dr As System.Windows.Forms.DialogResult
        dr = dlg.ShowDialog
        Dim fileName As String = dlg.FileName
        dlg.Dispose()
        If dr = System.Windows.Forms.DialogResult.OK Then
            DS.DataSetName = fileName
            DS.WriteXml(fileName)
        End If
    End Sub
    Private Function konverzijaLatCir(ByVal naziv As String) As String
        naziv = Replace(naziv, "Dž", "Џ")
        naziv = Replace(naziv, "DŽ", "Џ")
        naziv = Replace(naziv, "Đ", "Ђ")
        naziv = Replace(naziv, "Ž", "Ж")
        naziv = Replace(naziv, "Ć", "Ћ")
        naziv = Replace(naziv, "Č", "Ч")
        naziv = Replace(naziv, "Š", "Ш")

        naziv = Replace(naziv, "dž", "џ")
        naziv = Replace(naziv, "đ", "ђ")
        naziv = Replace(naziv, "ž", "ж")
        naziv = Replace(naziv, "ć", "ћ")
        naziv = Replace(naziv, "č", "ч")
        naziv = Replace(naziv, "š", "ш")

        naziv = Replace(naziv, "Dj", "Ђ")
        naziv = Replace(naziv, "Zh", "Ж")
        naziv = Replace(naziv, "Lj", "Љ")
        naziv = Replace(naziv, "LJ", "Љ")
        naziv = Replace(naziv, "Nj", "Њ")
        naziv = Replace(naziv, "NJ", "Њ")
        naziv = Replace(naziv, "Th", "Ћ")
        naziv = Replace(naziv, "Ch", "Ч")
        naziv = Replace(naziv, "Dz", "Џ")
        naziv = Replace(naziv, "Sh", "Ш")

        naziv = Replace(naziv, "dj", "ђ")
        naziv = Replace(naziv, "zh", "ж")
        naziv = Replace(naziv, "lj", "љ")
        naziv = Replace(naziv, "nj", "њ")
        naziv = Replace(naziv, "th", "ћ")
        naziv = Replace(naziv, "ch", "ч")
        naziv = Replace(naziv, "dz", "џ")
        naziv = Replace(naziv, "sh", "ш")

        naziv = Replace(naziv, "A", "А")
        naziv = Replace(naziv, "B", "Б")
        naziv = Replace(naziv, "V", "В")
        naziv = Replace(naziv, "G", "Г")
        naziv = Replace(naziv, "D", "Д")
        naziv = Replace(naziv, "E", "Е")
        naziv = Replace(naziv, "Z", "З")
        naziv = Replace(naziv, "I", "И")
        naziv = Replace(naziv, "J", "Ј")
        naziv = Replace(naziv, "K", "К")
        naziv = Replace(naziv, "L", "Л")
        naziv = Replace(naziv, "M", "М")
        naziv = Replace(naziv, "N", "Н")
        naziv = Replace(naziv, "O", "О")
        naziv = Replace(naziv, "P", "П")
        naziv = Replace(naziv, "R", "Р")
        naziv = Replace(naziv, "S", "С")
        naziv = Replace(naziv, "T", "Т")
        naziv = Replace(naziv, "U", "У")
        naziv = Replace(naziv, "F", "Ф")
        naziv = Replace(naziv, "H", "Х")
        naziv = Replace(naziv, "C", "Ц")

        naziv = Replace(naziv, "a", "а")
        naziv = Replace(naziv, "b", "б")
        naziv = Replace(naziv, "v", "в")
        naziv = Replace(naziv, "g", "г")
        naziv = Replace(naziv, "d", "д")
        naziv = Replace(naziv, "e", "е")
        naziv = Replace(naziv, "z", "з")
        naziv = Replace(naziv, "i", "и")
        naziv = Replace(naziv, "j", "ј")
        naziv = Replace(naziv, "k", "к")
        naziv = Replace(naziv, "l", "л")
        naziv = Replace(naziv, "m", "м")
        naziv = Replace(naziv, "n", "н")
        naziv = Replace(naziv, "o", "о")
        naziv = Replace(naziv, "p", "п")
        naziv = Replace(naziv, "r", "р")
        naziv = Replace(naziv, "s", "с")
        naziv = Replace(naziv, "t", "т")
        naziv = Replace(naziv, "u", "у")
        naziv = Replace(naziv, "f", "ф")
        naziv = Replace(naziv, "h", "х")
        naziv = Replace(naziv, "c", "ц")
        Return naziv
    End Function
    Private Function konverzijaCirLat(ByVal naziv As String) As String
        naziv = Replace(naziv, "Џ", "Dž")
        naziv = Replace(naziv, "Џ", "DŽ")
        naziv = Replace(naziv, "Ђ", "Đ")
        naziv = Replace(naziv, "Ж", "Ž")
        naziv = Replace(naziv, "Ћ", "Ć")
        naziv = Replace(naziv, "Ч", "Č")
        naziv = Replace(naziv, "Ш", "Š")

        naziv = Replace(naziv, "џ", "dž")
        naziv = Replace(naziv, "ђ", "đ")
        naziv = Replace(naziv, "ж", "ž")
        naziv = Replace(naziv, "ћ", "ć")
        naziv = Replace(naziv, "ч", "č")
        naziv = Replace(naziv, "ш", "š")

        naziv = Replace(naziv, "Ђ", "Dj")
        naziv = Replace(naziv, "Ж", "Zh")
        naziv = Replace(naziv, "Љ", "Lj")
        naziv = Replace(naziv, "Љ", "LJ")
        naziv = Replace(naziv, "Њ", "Nj")
        naziv = Replace(naziv, "Њ", "NJ")
        naziv = Replace(naziv, "Ћ", "Th")
        naziv = Replace(naziv, "Ч", "Ch")
        naziv = Replace(naziv, "Џ", "Dz")
        naziv = Replace(naziv, "Ш", "Sh")

        naziv = Replace(naziv, "ђ", "dj")
        naziv = Replace(naziv, "ж", "zh")
        naziv = Replace(naziv, "љ", "lj")
        naziv = Replace(naziv, "њ", "nj")
        naziv = Replace(naziv, "ћ", "th")
        naziv = Replace(naziv, "ч", "ch")
        naziv = Replace(naziv, "џ", "dz")
        naziv = Replace(naziv, "ш", "sh")

        naziv = Replace(naziv, "А", "A")
        naziv = Replace(naziv, "Б", "B")
        naziv = Replace(naziv, "В", "V")
        naziv = Replace(naziv, "Г", "G")
        naziv = Replace(naziv, "Д", "D")
        naziv = Replace(naziv, "Е", "E")
        naziv = Replace(naziv, "З", "Z")
        naziv = Replace(naziv, "И", "I")
        naziv = Replace(naziv, "Ј", "J")
        naziv = Replace(naziv, "К", "K")
        naziv = Replace(naziv, "Л", "L")
        naziv = Replace(naziv, "М", "M")
        naziv = Replace(naziv, "Н", "N")
        naziv = Replace(naziv, "О", "O")
        naziv = Replace(naziv, "П", "P")
        naziv = Replace(naziv, "Р", "R")
        naziv = Replace(naziv, "С", "S")
        naziv = Replace(naziv, "Т", "T")
        naziv = Replace(naziv, "У", "U")
        naziv = Replace(naziv, "Ф", "F")
        naziv = Replace(naziv, "Х", "H")
        naziv = Replace(naziv, "Ц", "C")

        naziv = Replace(naziv, "а", "a")
        naziv = Replace(naziv, "б", "b")
        naziv = Replace(naziv, "в", "v")
        naziv = Replace(naziv, "г", "g")
        naziv = Replace(naziv, "д", "d")
        naziv = Replace(naziv, "е", "e")
        naziv = Replace(naziv, "з", "z")
        naziv = Replace(naziv, "и", "i")
        naziv = Replace(naziv, "ј", "j")
        naziv = Replace(naziv, "к", "k")
        naziv = Replace(naziv, "л", "l")
        naziv = Replace(naziv, "м", "m")
        naziv = Replace(naziv, "н", "n")
        naziv = Replace(naziv, "о", "o")
        naziv = Replace(naziv, "п", "p")
        naziv = Replace(naziv, "р", "r")
        naziv = Replace(naziv, "с", "s")
        naziv = Replace(naziv, "т", "t")
        naziv = Replace(naziv, "у", "u")
        naziv = Replace(naziv, "ф", "f")
        naziv = Replace(naziv, "х", "h")
        naziv = Replace(naziv, "ц", "c")
        Return naziv
    End Function


End Class