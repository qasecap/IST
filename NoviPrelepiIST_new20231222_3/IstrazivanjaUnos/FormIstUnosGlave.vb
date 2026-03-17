Imports System.Runtime.InteropServices

Public Class FormISTUnosGlave

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
    Friend WithEvents lv As ListView
    Friend WithEvents table As ColumnHeader
    Friend WithEvents PanelTop As Panel
    Friend WithEvents b3 As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Logovan As Label
    Friend WithEvents description As ColumnHeader

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormISTUnosGlave))
        Me.lv = New System.Windows.Forms.ListView()
        Me.table = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv
        '
        Me.lv.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.table, Me.description})
        Me.lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv.FullRowSelect = True
        Me.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lv.HideSelection = False
        Me.lv.Location = New System.Drawing.Point(0, 40)
        Me.lv.MultiSelect = False
        Me.lv.Name = "lv"
        Me.lv.Scrollable = False
        Me.lv.Size = New System.Drawing.Size(900, 460)
        Me.lv.TabIndex = 34
        Me.lv.UseCompatibleStateImageBehavior = False
        Me.lv.View = System.Windows.Forms.View.Details
        '
        'table
        '
        Me.table.Text = ""
        Me.table.Width = 300
        '
        'description
        '
        Me.description.Text = ""
        Me.description.Width = 950
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(900, 40)
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
        Me.b3.TabIndex = 184
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
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
        Me.btnCerrar.Location = New System.Drawing.Point(860, 0)
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
        Me.Logovan.Location = New System.Drawing.Point(652, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormISTUnosGlave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.lv)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormISTUnosGlave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IST"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dist As DatasetIstrazivanja
    Dim txtInst As String
    Dim txtpismo As String
    Dim txtmode As String
    Dim vrt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim pom As String
    Dim jezik As String
    Dim DBConnectionString As String
    Dim ISTConnectionString As String
    Dim CAPIServer As String
    Dim CAPIBaza As String
    Dim dtJson As DataTable
    Dim mdtAWL As DataTable
    Dim mdtQE As DataTable
    Dim mdtLabel As DataTable
    Dim mdtMessage As DataTable
    Dim kosamnew As String = ""
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Public Sub New(ByVal dsIST As DatasetIstrazivanja, ByVal mdtLabel As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable, ByVal mdtMessage As DataTable,
                   ByVal DBConnectionString As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
    ByVal txtInstalacije As String, ByVal txtpismo As String, ByVal txtmode As String, ByVal jezik As String,
    ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String, ByVal txt_DSBrisanjeBaza As String, ByVal ISTConnectionString As String,
    Optional ByVal GlavneIliPomocne As String = Nothing, Optional ByVal txt_CAPIServer As String = "",
                   Optional ByVal txt_CAPIBaza As String = "", Optional ByVal dtJson As DataTable = Nothing, Optional kosamnew As String = "")
        Me.New()
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString

        Me.dist = dsIST
        Me.Logovan.Text = GetUserName.ToString.Trim
        Me.vrt = vt
        Me.txtInst = txtInstalacije
        Me.txtmode = txtmode
        Me.txtpismo = txtpismo
        Me.kosamnew = kosamnew

        Me.CAPIServer = txt_CAPIServer
        Me.CAPIBaza = txt_CAPIBaza
        Me.dtJson = dtJson
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtLabel = mdtLabel
        Me.mdtMessage = mdtMessage

        Me.jezik = jezik
        Call SetLang()
        Dim tOpis As String = ""

        If Not (dist.IST.Rows(0).Item("ABAZA") Is System.DBNull.Value) AndAlso dist.IST.Rows(0).Item("ABAZA").ToString.Trim.ToUpper.IndexOf("ONLYTABLEDESCRIPTION") >= 0 Then
            lv.Columns(0).Width = 10
        End If
        If GlavneIliPomocne Is Nothing Then
            Dim redoviMEMGD() As DataRow = dist.ISTTABELE.Select("isnull(baza,'')<>'0' and isnull(T1,'') not like '%ISTview%' and isnull(DG,'G')='G'", "baza ASC")
            If redoviMEMGD.Length = 1 Then
                Dim rt As DatasetIstrazivanja.ISTTABELERow = redoviMEMGD(0)
                Call lvi(rt, tOpis)
            Else
                Dim rt As DatasetIstrazivanja.ISTTABELERow
                For nmnm As Integer = 0 To redoviMEMGD.GetUpperBound(0)
                    rt = redoviMEMGD(nmnm)
                    Call lvi(rt, tOpis)
                Next
            End If
        Else 'pomocne
            Dim redoviMEMAK() As DataRow

            If Not (dist.IST.Rows(0).Item("SIFIST") Is System.DBNull.Value) AndAlso (dist.IST.Rows(0).Item("SIFIST").ToString.Trim.ToUpper = "xPPOLJO" OrElse dist.IST.Rows(0).Item("SIFIST").ToString.Trim.ToUpper = "PPOLJO23" OrElse dist.IST.Rows(0).Item("SIFIST").ToString.Trim.ToUpper = "PPES24OK") Then
                redoviMEMAK = dist.ISTTABELE.Select("isnull(baza,'')<>'0' and isnull(T1,'') not like '%ISTview%' and  isnull(DG,'')='K' and tabela like '%evaluacija%'", "baza ASC")
            Else
                redoviMEMAK = dist.ISTTABELE.Select("isnull(baza,'')<>'0' and isnull(T1,'') not like '%ISTview%' and (isnull(DG,'')='A' or isnull(DG,'')='K')", "baza ASC")
            End If

            Dim rt As DatasetIstrazivanja.ISTTABELERow
            For nmnm As Integer = 0 To redoviMEMAK.GetUpperBound(0)
                rt = redoviMEMAK(nmnm)
                If rt.IsT1Null = False AndAlso rt.T1.Trim <> "" AndAlso rt.T1.Trim.ToUpper.IndexOf("TABLEVISIBLEFALSE") >= 0 Then
                Else
                    Call lvi(rt, tOpis)
                End If
            Next
        End If
        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        If Not GlavneIliPomocne Is Nothing Then
            Me.pom = GlavneIliPomocne
        Else
            Me.pom = "G"
        End If

        lv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

    End Sub

    Private Sub SetLang()
        ''

        Dim sifist As String = dist.IST.Rows(0).Item("SIFIST").ToString.Trim
        Me.b3.Text = sifist + "    " + String.Format("{0:d2}", Me.vrt.M) + " / " + Me.vrt.G.ToString


    End Sub

    Sub lvi(ByVal rt As DatasetIstrazivanja.ISTTABELERow, ByVal topis As String)
        If rt.IsOpisNull OrElse rt.Opis.Trim = "" Then topis = "" Else topis = sredjenOpis(rt.Opis)

        Dim MLopis As String = getMultilanguageLabel(mdtLabel, txtmode, rt.Tabela.Trim, "", "td", Me.jezik)
        If MLopis <> "" Then topis = MLopis

        Dim rtTabela As String = "  " + rt.Tabela.Trim
        Dim lvi As ListViewItem = New ListViewItem({rtTabela, topis})
        lvi.Font = New Font(lv.Font, FontStyle.Regular)
        lv.Items.Add(lvi)

    End Sub

    Public Shadows Function ShowDialog() As System.Windows.Forms.DialogResult
        If Me.lv.Items.Count = 0 Then
            Dim por As String = ""
            ''msg 184
            Dim msgtxt184 As String = getMessageText(dtMessages, "184", Me.jezik)
            ''msg 185
            Dim msgtxt185 As String = getMessageText(dtMessages, "185", Me.jezik)
            ''msg 186
            Dim msgtxt186 As String = getMessageText(dtMessages, "186", Me.jezik)
            ''msg 187
            Dim msgtxt187 As String = getMessageText(dtMessages, "187", Me.jezik)
            If Me.pom = "G" Then
                por = msgtxt184 + nvrd + nvrd + msgtxt185
            Else
                por = msgtxt184 + nvrd + nvrd + msgtxt186
            End If
            ISTMessageBox.Show(por, msgtxt187, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Me.lv.Items.Count < 2 Then
                lv.Items(0).Selected = True
                Call BtnPrikaziClick()
                Me.Close()
            Else
                Return MyBase.ShowDialog()
            End If
        End If
    End Function

    Sub BtnPrikaziClick()
        Dim zzak As Boolean = False
        ''msg 188
        Dim msgtxt188 As String = getMessageText(dtMessages, "188", Me.jezik)
        Dim porukaZ As String = msgtxt188
        ''msg 189
        Dim msgtxt189 As String = getMessageText(dtMessages, "189", Me.jezik)
        ''msg 190
        Dim msgtxt190 As String = getMessageText(dtMessages, "190", Me.jezik)
        Dim tabela As String = ""

        If Me.lv.SelectedItems Is Nothing OrElse Me.lv.SelectedItems.Count = 0 Then
            tabela = Me.lv.Items.Item(0).Text.Trim
        Else
            tabela = Me.lv.SelectedItems.Item(0).Text.Trim
        End If

        Dim ImaVODVDO As Boolean = False
        For Each p As DatasetIstrazivanja.ISTPOLJARow In dist.ISTPOLJA.Rows
            If p.TABELA.Trim.ToUpper = tabela.Trim.ToUpper Then
                If (p.POLJE.Trim.ToUpper = "VOD") Then
                    ImaVODVDO = True
                    Exit For
                End If
            End If
        Next
        Dim ssql As String = ""
        If ImaVODVDO Then
            Dim ldm As String = Me.DADD("01.01." + Me.vrt.G.ToString, Me.vrt.M, -1)
            ssql = "((" + ldm + ") between "
            If tabela <> "" Then ssql = ssql + tabela + "."
            ssql = ssql + "VOD" + " and "
            If tabela <> "" Then ssql = ssql + tabela + "."
            ssql = ssql + "VDO" + ")"
        End If

        Call parametriT1(tabela)

        Dim zak As Integer = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, Me.vrt.G, Me.vrt.M, Me.jezik, ssql)
        If zak = 1 Then zzak = True
        If zak = 1 AndAlso ISTMessageBox.Show(msgtxt189, msgtxt190, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
        Else
            If DataEntryAsDataGridView = 0 Then
                If dist.IST.Rows(0).Item("SIFIST").ToString.Trim = "SV20" Then
                    Dim frmsv20 As New IstrazivanjaUnos.FormIstUnosSV20(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
               False, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
               Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Me.dtJson,,,,,,,,,, kosamnew)
                    Try
                        frmsv20.ShowDialog()
                    Catch ex As Exception
                        ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Finally
                        frmsv20.Dispose()
                    End Try
                Else
                    Dim frm As New IstrazivanjaUnos.FormIstUnos(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                                   False, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                   Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Me.dtJson,,,,,,,,,, kosamnew)
                    Try
                        frm.ShowDialog()
                    Catch ex As Exception
                        ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Finally
                        frm.Dispose()
                    End Try
                End If
            Else
                'Dim frmG As New IstrazivanjaUnos.FormIstUnosGrid(Me.dist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.vrt, tabela,
                'False, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                'Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, zzak, zakljucanOdmahSve,,,,,,,,,,,,,,,,, CAPIServer, CAPIBaza,,,,,,,, Me.dtJson)
                'Try
                '    frmG.ShowDialog()
                'Catch ex As Exception
                '    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Finally
                '    frmG.Dispose()
                'End Try
            End If

        End If

    End Sub
    Dim zakljucanOdmahSve As Boolean
    Dim DataEntryAsDataGridView As Integer = 0
    Dim tabelaVisibleFalseZaBiranje As Boolean
    Sub parametriT1(ByVal tabela As String)
        Dim nizIndikatorT1() As String = {}
        Dim IndikatorT1 As String = ""
        For Each tt As DatasetIstrazivanja.ISTTABELERow In dist.ISTTABELE.Rows
            If tt.Tabela.Trim.ToUpper = tabela Then
                If Not (tt.Item("T1") Is System.DBNull.Value) Then
                    IndikatorT1 = IIf(tt.Item("T1") Is System.DBNull.Value, "", tt.Item("T1").ToString.Trim)
                    If IndikatorT1.Trim.ToUpper.Length > 0 Then nizIndikatorT1 = IndikatorT1.Split(";")
                    For k As Integer = 0 To nizIndikatorT1.GetUpperBound(0)
                        nizIndikatorT1(k) = nizIndikatorT1(k).Trim.ToUpper
                        If nizIndikatorT1(k) = "LOCKED" Then zakljucanOdmahSve = True
                        If nizIndikatorT1(k) = "DATAENTRYASDATAGRIDVIEW" Then DataEntryAsDataGridView = 1
                    Next
                End If
                Exit For
            End If
        Next
    End Sub
    Private Sub lv_DoubleClick(sender As Object, e As EventArgs) Handles lv.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Call BtnPrikaziClick()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles lv.KeyPress

        Select Case e.KeyChar
            Case ChrW(13) 'Enter
                Me.Cursor = Cursors.WaitCursor
                Call BtnPrikaziClick()
                Me.Cursor = Cursors.Default
        End Select


    End Sub

    Private Sub FormISTUnosGlave_Load(sender As Object, e As EventArgs) Handles Me.Load

        PanelTop.BackColor = setTheme(Nothing, Nothing)

    End Sub
    'Sub setTheme(ByVal theme As String)
    '    If theme = "L" Then
    '        ISTTheme.ChosenTheme("Light")

    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    Else
    '        ISTTheme.ChosenTheme("Dark")

    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    End If
    'End Sub
End Class