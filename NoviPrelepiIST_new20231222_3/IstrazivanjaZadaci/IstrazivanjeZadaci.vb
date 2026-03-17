Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Script.Serialization
Imports System.Windows.Forms
Public Class IstrazivanjeZadaci
    Inherits FormTemplate
    Dim m_f As FormTemplate
    Dim m_fold As String
    Public Shared mds As DatasetIstrazivanja
    Public Shared mdsPX As DatasetIstrazivanja
    Dim mucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim DBConnectionString As String
    Dim mta As DatasetIstrazivanja.ISTPOLJADataTable
    Dim mfzpzu As String
    Dim txtInst As String
    Dim txtpismo As String
    Dim txtmode As String

    Dim dtJson As DataTable

    Dim txtZoiper As String
    Dim txtoffice As String

    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeDEPOUser As String
    Dim DSBrisanjeDEPOPassword As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String

    Dim PublicDBServer As String
    Dim PublicDBBaza As String

    Dim CATIServer As String
    Dim CATIBaza As String
    Dim mrist As DatasetIstrazivanja.ISTRow
    Dim koIstOtk As String
    Dim ISTConnectionString As String
    Dim lokalno As Boolean
    Public jezik As String
    Dim dtm As System.Data.DataTable
    Dim CAPIServer As String
    Dim CAPIBaza As String
    Dim PXMETATable As String
    Dim folderZaGen As String
    Dim mdtAWL As DataTable
    Dim mdtQE As DataTable
    Dim mdtLabel As DataTable
    Dim mdtMessage As DataTable
    Dim sifist As String
    Public anketarCloud As String
    Public panelmenucollapse As Boolean
    Dim kosamnew As String

    Public Sub New(ByVal DBConnectionString As String, ByVal ds As DatasetIstrazivanja, ByVal dsPX As DatasetIstrazivanja,
    ByVal ta As DatasetIstrazivanja.ISTPOLJADataTable, ByVal rist As DatasetIstrazivanja.ISTRow,
    ByVal f As FormTemplate, ByVal ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
    ByVal fzpzu As String, ByVal txtInst As String, ByVal txtpismo As String, ByVal txtmode As String, ByVal ISTConnectionString As String,
    ByVal DSBrisanjeDEPO As String, ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String,
    ByVal CATIServer As String, ByVal CATIBaza As String, ByVal jezik As String,
    ByVal dtmessage As System.Data.DataTable, ByVal txtoffice As String,
    ByVal CAPIServer As String, ByVal CAPIBaza As String, ByVal PXMETATable As String, ByVal dtjson As DataTable, ByVal folderZaGen As String,
    ByVal PublicDBServer As String, ByVal PublicDBBaza As String, ByVal mdtLabel As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable, ByVal mdtMessage As DataTable, Optional kosamnew As String = "")

        Me.jezik = jezik
        Me.txtoffice = txtoffice
        Me.ISTConnectionString = ISTConnectionString
        Me.DBConnectionString = DBConnectionString
        Me.m_f = f
        Me.PXMETATable = PXMETATable
        Me.mucvt = ucvt
        Me.kosamnew = kosamnew
        'If datasetISTRefresh Is Nothing Then
        IstrazivanjeZadaci.mds = ds
        'Else
        '    IstrazivanjeZadaci.mds = datasetISTRefresh
        'End If
        IstrazivanjeZadaci.mdsPX = dsPX
        Me.mta = ta
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtLabel = mdtLabel
        Me.mdtMessage = mdtMessage

        Me.sifist = rist.SIFIST

        Me.mrist = rist
        m_fold = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + "\Istrazivanja"
        Me.mfzpzu = fzpzu
        Me.txtInst = txtInst
        Me.txtpismo = txtpismo
        Me.txtmode = txtmode
        Me.dtJson = dtjson
        Me.folderZaGen = folderZaGen
        Me.DSBrisanjeDEPO = DSBrisanjeDEPO
        Me.DSBrisanjeServer = DSBrisanjeServer
        Me.DSBrisanjeBaza = DSBrisanjeBaza

        Me.CAPIServer = CAPIServer
        Me.CAPIBaza = CAPIBaza

        Me.jezik = jezik
        Me.CATIServer = CATIServer
        Me.CATIBaza = CATIBaza

        Me.PublicDBServer = PublicDBServer
        Me.PublicDBBaza = PublicDBBaza

        lokalno = False
        If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

        Me.dtm = dtmessage

    End Sub

    Public Sub ButtonAK_Click()
        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim frm As New IstrazivanjaUnos.FormAK(IstrazivanjeZadaci.mds, Me.DBConnectionString, Me.mrist.Naziv,
        Me.mrist, Me.mrist.ISTBAZERow, IstrazivanjeZadaci.mds.ISTTABELE, IstrazivanjeZadaci.mds.ISTPOLJA, Me.mta, IstrazivanjeZadaci.mds.ISTLK, Me.mucvt,
        Me.txtInst, Me.txtpismo, m_fold, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik,
        Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, mdtLabel, mdtAWL, mdtQE, mdtMessage, panelmenucollapse, kosamnew)


        m_f.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Batch automatic correction")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

   Public Sub ButtonAzuriranje_Click(Optional ByVal GlavneIliPomocne As String = Nothing)

        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As IstrazivanjaUnos.FormAzuriraj = Nothing

        Try
            If mds.ISTLK.Rows.Count = 0 Then
                'poruka = "У табели ISTLK морате имати бар једно правило логичке контроле!"
                'ISTMessageBox.Show(poruka, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ''msg 2
                Dim msgtxt As String = getMessageText(dtm, "2", Me.jezik) + nvrd
                ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                frm = New IstrazivanjaUnos.FormAzuriraj("", mds, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.mucvt, DBConnectionString, mds.ISTTABELE, mds.ISTPOLJA,
                                             Me.mta, mds.ISTLK, Me.mrist, Me.mfzpzu,
                                            Me.txtInst, Me.txtpismo, txtmode, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.jezik, Me.ISTConnectionString,
                                            CAPIServer, CAPIBaza, "", panelmenucollapse, GlavneIliPomocne,, kosamnew)

                m_f.Hide()
                frm.ShowDialog()

                If GlavneIliPomocne Is Nothing Then
                    If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Data editing")
                Else
                    'pomocne
                    If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Data editing", GlavneIliPomocne)
                End If
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
            m_f.Show()
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub    
  
  Public Sub ButtonNPretraga_Click()
        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New IstrazivanjaUnos.FormNaprednaPretragaUnos(Me.mucvt, Me.DBConnectionString, Me.mrist, Me.ISTConnectionString, Me.txtInst, Me.txtpismo, Me.DSBrisanjeDEPO,
                                            Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik, panelmenucollapse)

        m_f.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Public Sub ButtonUnosGrid_Click()

        Dim koSamPom As String = ""
        Dim koSam As String = ""
        If txtmode.Trim.ToUpper = "CAPI" OrElse txtmode.Trim.ToUpper = "TESTCAPI" OrElse txtmode.Trim.ToUpper = "CAPITEST" Then   'može i testcapi
            koSamPom = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
            'ElseIf anketarcloud <> "" OrElse txtmode = "CLOUD" Then
            '    koSam = anketarcloud
            '    txtcloudcati = True
        ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
            koSamPom = GetUserNameZ()
        End If

        If koSamPom = "" Then
            Dim dt As DataTable = izvrsiSQLvratiDT("select suser_sname() as sn", DBConnectionString, Me.jezik)
            If dt.Rows.Count > 0 Then
                koSamPom = dt.Rows(0).Item("sn").ToString.Trim
            End If
        End If

        If txtmode.Trim.ToUpper = "Z" OrElse koSamPom.Trim.ToUpper.IndexOf("STATSRB\") >= 0 OrElse koSamPom.Trim.ToUpper.IndexOf("IB15530\KORISNIK") >= 0 Then
            koSam = kojianketar(koSamPom, Me.DBConnectionString)
        ElseIf txtmode.Trim.ToUpper = "ZCAPI" Then
            koSam = GetUserNameZ()
        Else
            koSam = GetUserNameCAPI(Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, Me.DBConnectionString)
        End If
        If koSam = "" Then
            ISTMessageBox.Show("Nemate dozvole za ulazak u aplikaciju")
            Exit Sub
        End If

        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor

        If sifist.Trim.ToUpper = "POPIS_21" OrElse sifist.Trim.ToUpper = "PES_21" OrElse sifist.Trim.ToUpper = "POPTEST" Then
            Dim sql As String = "select * from adresar where indgr=1 and idanketar='" + koSam + "'"
            Dim dt2 As DataTable = izvrsiSQLvratiDT(sql, DBConnectionString, Me.jezik)
            If Not dt2 Is Nothing AndAlso dt2.Rows.Count > 0 Then
                ISTMessageBox.Show("Ne možete unositi podatke dok instruktor ne završi preraspodelu vašeg materijala.")
                m_f.Cursor = System.Windows.Forms.Cursors.Default
                Exit Sub
            End If
        End If


        If sifist.Trim.ToUpper = "POPIS_21" OrElse sifist.Trim.ToUpper = "POPTEST" Then
            Dim frm As New IstrazivanjaUnos.FormPopisAdresar(mds, mds.ISTTABS, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.mucvt,
                   Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, ISTConnectionString, Me.CAPIServer, Me.CAPIBaza,
                   Me.txtoffice, m_fold, Me.mrist.ISTBAZERow, koSam)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
                'm_f.Show()
                If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
                m_f.Cursor = System.Windows.Forms.Cursors.Default
            End Try
        ElseIf sifist.Trim.ToUpper = "PES_21" Then
            Dim frm As New IstrazivanjaUnos.FormPESAdresar(mds, mds.ISTTABS, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.mucvt,
               Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, ISTConnectionString, Me.CAPIServer, Me.CAPIBaza,
               Me.txtoffice, m_fold, Me.mrist.ISTBAZERow, koSam)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
                'm_f.Show()
                If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
                m_f.Cursor = System.Windows.Forms.Cursors.Default
            End Try
        ElseIf sifist.Trim.ToUpper = "xPPOLJO" Then
            Dim frm As New IstrazivanjaUnos.FormPoljoprivreda(mds, mds.ISTTABS, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.mucvt,
               Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, ISTConnectionString, Me.CAPIServer, Me.CAPIBaza,
               Me.txtoffice, m_fold, Me.mrist.ISTBAZERow, koSam)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
                'm_f.Show()
                If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
                m_f.Cursor = System.Windows.Forms.Cursors.Default
            End Try
        ElseIf sifist.Trim.ToUpper = "PPOLJO23" Then
            Dim frm As New IstrazivanjaUnos.FormPpoljoKon(mds, mds.ISTTABS, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.mucvt,
               Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, ISTConnectionString, Me.CAPIServer, Me.CAPIBaza,
               Me.txtoffice, m_fold, Me.mrist.ISTBAZERow, koSam)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
                'm_f.Show()
                If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
                m_f.Cursor = System.Windows.Forms.Cursors.Default
            End Try
        ElseIf sifist.Trim.ToUpper = "PPES_24" Then
            Dim frm As New IstrazivanjaUnos.FormPoljoPES(mds, mds.ISTTABS, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.mucvt,
               Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, ISTConnectionString, Me.CAPIServer, Me.CAPIBaza,
               Me.txtoffice, m_fold, Me.mrist.ISTBAZERow, koSam)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
                'm_f.Show()
                If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
                m_f.Cursor = System.Windows.Forms.Cursors.Default
            End Try
        ElseIf sifist.Trim.ToUpper = "PPES24OK" Then
            Dim frm As New IstrazivanjaUnos.FormPpoljoPesKon(mds, mds.ISTTABS, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.mucvt,
               Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, ISTConnectionString, Me.CAPIServer, Me.CAPIBaza,
               Me.txtoffice, m_fold, Me.mrist.ISTBAZERow, koSam)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
                'm_f.Show()
                If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced search")
                m_f.Cursor = System.Windows.Forms.Cursors.Default
            End Try
        End If


        'm_f.Hide()


    End Sub



    Public Sub ButtonZO_Click()
        Dim frm As FormZakljucaj = Nothing
        Try
            frm = New FormZakljucaj(Me.mucvt, Me.DBConnectionString, Me.mrist, IstrazivanjeZadaci.mds.ISTTABELE,
             IstrazivanjeZadaci.mds.ISTPOLJA, IstrazivanjeZadaci.mds.ISTLK, IstrazivanjeZadaci.mds.ISTBAZE,
             Me.mrist.ISTBAZERow, Me.ISTConnectionString, Me.txtpismo, Me.jezik) ', Me.koIstOtk)
            m_f.Hide()
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Lock/Unlock by tables")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Public Sub ButtonCAPI_Click()

        Dim frm As FormCAPIPreparation = Nothing
        Try
            frm = New FormCAPIPreparation(Me.mucvt, Me.DBConnectionString, Me.mrist, mds.ISTTABELE, mds.ISTPOLJA, mds.ISTLK, mds.ISTBAZE,
             Me.mrist.ISTBAZERow, Me.ISTConnectionString, Me.folderZaGen, Me.txtpismo, Me.jezik) ', Me.koIstOtk)
            m_f.Hide()
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("CAPI preparation")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Public Sub ButtonImportExcel_Click()

        Dim frm As IstrazivanjaUnos.FormImportExcelNovo = Nothing
        Try
            frm = New IstrazivanjaUnos.FormImportExcelNovo(Me.mucvt, Me.DBConnectionString, Me.mrist, mds.ISTTABELE, mds.ISTPOLJA, mds.ISTLK, mds.ISTBAZE, Me.mrist.ISTBAZERow,
                                      Me.ISTConnectionString, Me.txtpismo, Me.jezik, Me.txtmode, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza)
            m_f.Hide()
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Import excel")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try

    End Sub

    Public Sub BtnQueryDesigner()
        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New FormQD(Me.mucvt, Me.DBConnectionString, Me.mrist, mds.ISTTABELE, Me.ISTConnectionString, Me.txtInst, Me.txtpismo, Me.DSBrisanjeDEPO,
                              Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik)
        m_f.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Query designer")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    Public Sub ButtonLogickaKontrola_Click()
        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New IstrazivanjaUnos.FormLogickaKontrola(IstrazivanjeZadaci.mds, Me.DBConnectionString, Me.mrist.Naziv,
        Me.mrist, Me.mrist.ISTBAZERow, IstrazivanjeZadaci.mds.ISTTABELE, IstrazivanjeZadaci.mds.ISTPOLJA, Me.mta, IstrazivanjeZadaci.mds.ISTLK, Me.mucvt,
        Me.txtInst, Me.txtpismo, m_fold, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik,
        Me.ISTConnectionString, Me.CAPIServer, Me.CAPIBaza, mdtLabel, mdtAWL, mdtQE, mdtMessage, panelmenucollapse)

        m_f.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Batch logical control")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub


    Public Sub ButtonPr_Click()
        Dim frm As FormProjektantiNovo = Nothing
        Try
            frm = New FormProjektantiNovo(Me.mucvt, Me.ISTConnectionString, Me.mrist, Me.txtpismo, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik, panelmenucollapse)

            m_f.Hide()
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
            m_f.Show()
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Public Sub ButtonIzvestaji_Click()
        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New IstrazivanjaUnos.FormIzvestaji(Me.DBConnectionString, Me.ISTConnectionString, mds.ISTTABS, Me.mrist, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.mucvt, m_fold, Me.mrist.ISTBAZERow,
                                     Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.CAPIServer, Me.CAPIBaza, txtmode,
                                     Me.jezik, Me.panelmenucollapse, Me.txtInst, Me.txtpismo, Me.txtoffice, mdsPX, PXMETATable, kosamnew)
        m_f.Hide()
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            m_f.Show()
            If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Procedures and reports")
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    'Public Sub ButtonIzlaz_Click()
    '    m_f.Close()
    'End Sub

    Public Sub ButtonBrojSlogova_Click()
        m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim ssql As String = ""

        Dim ti As New System.Data.DataTable
        Dim cs As System.Data.DataColumn

        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        Dim colTab As String = getControlText2(dt, "colTab", Me.jezik)
        Dim colBrSl As String = getControlText2(dt, "colBrSl", Me.jezik)

        ti.Columns.Add(colTab)
        cs = ti.Columns.Add(colBrSl, GetType(Long))
        Try
            For Each rt As DatasetIstrazivanja.ISTTABELERow In IstrazivanjeZadaci.mds.ISTTABELE.Rows
                Dim n As String = tabelaSQL(Me.mrist.ISTBAZERow, Nothing, rt.Tabela)

                ssql = "select count(*) as " + colBrSl + " from " + n
                ssql = ssql + " where 1=1"
                Dim v As String = Me.mucvt.vWhere(n, "", Me.DBConnectionString)
                If v <> "" Then
                    ssql = ssql + " and " + v
                End If

                Dim dtPom As DataTable = izvrsiSQLvratiDT(ssql, Me.DBConnectionString, Nothing)
                Dim r As System.Data.DataRow = dtPom.Rows(0)
                ti.Rows.Add(New Object() {rt.Tabela, r.ItemArray(0)})

            Next
            ti.DefaultView.AllowNew = False
            ti.DefaultView.Sort = cs.ColumnName + " desc"
            Dim frm As New FormBrojSlogovaIzvestaj(Me.txtpismo, Me.jezik)
            frm.dgv.DataSource = ti

            Try
                frm.ShowDialog()
            Finally
                frm.Dispose()
            End Try
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            m_f.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Record number")
    End Sub

    Public Sub ButtonOcena_Click()
        Dim frm As FormOcena = Nothing
        Try
            frm = New FormOcena(Me.mucvt, Me.DBConnectionString, Me.mrist, Me.txtpismo, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik, panelmenucollapse)
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
        End Try
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Number of inputations and edits of variables")
    End Sub

    Public Sub ButtonLogLK_Click()
        Dim frm As FormLogLKNovo = Nothing
        Try
            frm = New FormLogLKNovo(Me.mucvt, Me.DBConnectionString, Me.mrist, Me.txtpismo, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik, panelmenucollapse)
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If

        End Try
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Overview of batch logical control")
    End Sub

    Public Sub llSifriranjeS_Click()
        Dim frm As FormSACodingSimple = Nothing
        Try
            frm = New FormSACodingSimple(Me.mucvt, Me.DBConnectionString, Me.mrist, Me.ISTConnectionString, Me.txtInst, Me.txtpismo, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik)
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
        End Try
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Semi-automatic coding advanced")
    End Sub

    Public Sub llAdvancedUpdating_Click()
        Dim frm As FormAdvancedUpdating = Nothing
        Try
            frm = New FormAdvancedUpdating(Me.mucvt, Me.DBConnectionString, Me.mrist, Me.ISTConnectionString, Me.txtInst, Me.txtpismo, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, Me.txtmode, Me.jezik)
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
        End Try
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Advanced updating")
    End Sub

    Public Sub ButtonValidniIntervali_Click()
        Dim frm As FormIntervaliVremenskeTacke = Nothing
        Try
            frm = New FormIntervaliVremenskeTacke(mds, Me.txtpismo, Me.jezik)
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
        End Try
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Overview of batch logical control")

    End Sub


    Public Function tabelaSQL(ByVal b As DatasetIstrazivanja.ISTBAZERow, ByVal r As DatasetIstrazivanja.ISTBAZERow, ByVal t2 As String) As String
        If r Is Nothing Then r = b

        Dim s As String = r.IzrazODBC.Trim
        If Not (r.IsIzrazOLENull OrElse r.IzrazOLE.Trim = "") Then s = r.IzrazOLE.Trim
        s = Replace(s, "provider=sqloledb.1;", "", 1, , CompareMethod.Text)

        Dim server As String = ""
        Dim baza As String = ""
        Dim pp() As String = s.Split(";")
        For i As Integer = 0 To pp.GetUpperBound(0)
            If pp(i).Trim.ToLower.IndexOf("data source") >= 0 Then
                server = Replace(pp(i), "data source", "", 1, , CompareMethod.Text)
                server = server.Replace("=", "").Trim
            End If
            If pp(i).Trim.ToLower.IndexOf("initial catalog") >= 0 Then
                baza = Replace(pp(i), "initial catalog", "", 1, , CompareMethod.Text)
                baza = baza.Replace("=", "").Trim
            End If
        Next

        Dim n As String = t2.Trim
        n = imeparent(n)
        n = itabsaprfx(r, n)

        If Not b Is r Then
            Dim provider As String = stringparametar(s, "provider")
            If provider = "" Then provider = "SQLNCLI11"
            n = "OPENROWSET('" + provider + "','" + "Server=" + server + ";Trusted_Connection=yes;'," + n + ")"
        End If
        Return n

    End Function

    Private Function stringparametar(ByVal connectionString As String, ByVal parameter As String) As String
        Dim i As Integer = connectionString.ToLower.IndexOf(parameter)
        Dim iStart As Integer = i
        If i >= 0 Then
            i = connectionString.IndexOf("=", i + 1)
            If i >= 0 Then
                Dim j As Integer = connectionString.IndexOf(";", i + 1)
                If j >= 0 Then
                    Return connectionString.Substring(i + 1, j - i - 1).Trim
                Else
                    Return connectionString.Substring(i + 1).Trim
                End If
            End If
        End If
        Return ""
    End Function

    Public Function itabsaprfx(ByVal r As DatasetIstrazivanja.ISTBAZERow, ByVal tableName As String) As String
        If Not r.IsprefixNull AndAlso r.prefix.Trim <> "" Then
            Dim p As String = r.prefix.Trim
            p = ime_zagrada(p)
            Return p + "." + tableName
        Else
            Return "dbo." + tableName
        End If
        Return tableName
    End Function
    Public Function itabsaprfx2(ByVal r As DatasetIstrazivanja.ISTBAZERow, ByVal tableName As String) As String
        If Not r.IsprefixNull AndAlso r.prefix.Trim <> "" AndAlso r.prefix.Trim <> "dbo" Then
            Dim p As String = r.prefix.Trim
            p = ime_zagrada(p)
            Return p + "." + tableName
        Else
            Return tableName
        End If
        Return tableName
    End Function
    Public Function ime_zagrada(ByVal n As String) As String
        n = n.Trim
        If n.Chars(0) <> "["c Then
            Return "[" + n + "]"
        End If
        Return n
    End Function


    Public Function imeparent(ByVal name As String) As String
        name = name.Trim
        If name.Chars(0) <> "["c Then
            Return "[" + name + "]"
        End If
        Return name
    End Function

    Public Sub ButtonPoslednjiDatumSaPodacima_Click()
        Dim strsql As String = ""
        Dim tn As String = ""
        Dim tnn As String = ""
        For Each rt5 As DatasetIstrazivanja.ISTTABELERow In IstrazivanjeZadaci.mds.ISTTABELE.Rows
            tn = itabsaprfx2(Me.mrist.ISTBAZERow, rt5.Tabela.Trim)
            tnn = tnn + tn + ";"
            strsql = strsql + "select * from " + tn + " where 1=0;"
        Next
        tnn = tnn.TrimEnd(";")
        strsql = strsql.TrimEnd(";")

        Dim frm As FormPoslednjiDatumSaPodacima = Nothing
        Try
            frm = New FormPoslednjiDatumSaPodacima(mds, Me.txtpismo, Me.jezik, Me.DBConnectionString, strsql, tnn)
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frm Is Nothing Then
                frm.Dispose()
            End If
        End Try
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("The last date for which the records exist")


    End Sub

    Public Sub ButtonUnos_Click(Optional ByVal GlavneIliPomocne As String = Nothing)

        Dim frm As IstrazivanjaUnos.FormISTUnosGlave = Nothing
        Dim frmU As IstrazivanjaUnos.FormIstUnos = Nothing
        Dim frmUSV20 As IstrazivanjaUnos.FormIstUnosSV20 = Nothing


        'Dim frmUG As IstrazivanjaUnos.FormIstUnosGrid = Nothing
        Me.mrist.ProgUnos = ""
        If Me.mrist.IsProgUnosNull OrElse Me.mrist.ProgUnos.Trim = "" Then
            m_f.Cursor = System.Windows.Forms.Cursors.WaitCursor

            Dim tabela As String = ""
            Dim brT As Integer = 0
            Dim ozak As Integer = 0
            Dim DataEntryAsDataGridView As Integer = 0
            Dim locked As Boolean = False
            Dim lockedOdmahSve As Boolean = False
            If GlavneIliPomocne Is Nothing Then   'nisu konsult ili adresar ili S
                For Each t As DatasetIstrazivanja.ISTTABELERow In mds.ISTTABELE.Rows
                    Dim IndikatorT1 As String = IIf(t.Item("T1") Is System.DBNull.Value, "", t.Item("T1").ToString.Trim).trim.toupper
                    If IndikatorT1.Trim.ToUpper.IndexOf("LOCKED") >= 0 Then ozak = 1 : locked = True : lockedOdmahSve = True
                    If IndikatorT1.Trim.ToUpper.IndexOf("DATAENTRYASDATAGRIDVIEW") >= 0 Then DataEntryAsDataGridView = 1

                    If Not t.IsDGNull AndAlso t.DG.ToUpper.Trim = "G" Then
                        brT = brT + 1
                        tabela = t.Tabela.Trim.ToUpper
                        If Not dtJson Is Nothing AndAlso dtJson.Rows.Count > 0 Then 'samo može iz jsona
                            If stopAll(IndikatorT1, tabela) = 1 Then
                                m_f.Cursor = System.Windows.Forms.Cursors.Default
                                Exit Sub
                            End If
                        End If
                    ElseIf Not t.IsDGNull AndAlso t.DG.ToUpper.Trim <> "G" Then
                        brT = brT + 1
                        tabela = t.Tabela.Trim.ToUpper
                    End If
                Next
            End If

            If brT = 1 Then   'samo jedna, odmah otvara unos
                Dim ImaVODVDO As Boolean = False
                For Each p As DatasetIstrazivanja.ISTPOLJARow In mds.ISTPOLJA.Rows
                    If p.TABELA.Trim.ToUpper = tabela.Trim.ToUpper Then
                        If (p.POLJE.Trim.ToUpper = "VOD") Then
                            ImaVODVDO = True
                            Exit For
                        End If
                    End If
                Next

                Dim ssql As String = ""
                If ImaVODVDO Then
                    Dim ldm As String = Me.DADD("01.01." + Me.mucvt.G.ToString, Me.mucvt.M, -1)
                    ssql = "((" + ldm + ") between "
                    If tabela <> "" Then ssql = ssql + tabela + "."
                    ssql = ssql + "VOD" + " and "
                    If tabela <> "" Then ssql = ssql + tabela + "."
                    ssql = ssql + "VDO" + ")"
                End If

                If ozak <> 1 Then ozak = ProveraUnosLOCKTemplate(tabela, Me.DBConnectionString, mucvt.G, mucvt.M, Me.jezik, ssql)

                If ozak = 1 Then locked = True
                Dim msgtxt189 As String = getMessageText(dtMessages, "189", Me.jezik)
                Dim msgtxt190 As String = getMessageText(dtMessages, "190", Me.jezik)

                If ozak = 1 AndAlso ISTMessageBox.Show(msgtxt189, msgtxt190, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then  'zakljucan unos
                Else

                    If DataEntryAsDataGridView = 0 Then

                        If sifist.Trim.ToUpper = "SV20" Then
                            frmUSV20 = New IstrazivanjaUnos.FormIstUnosSV20(mds, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, mucvt, tabela,
                                    False, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                    Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, locked, lockedOdmahSve, , , , , , , , , , , , , , , , , CAPIServer, CAPIBaza, , , , , , , , dtJson,, anketarCloud,,,,,,,, kosamnew)

                        Else
                            frmU = New IstrazivanjaUnos.FormIstUnos(mds, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, mucvt, tabela,
                                    False, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                    Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, locked, lockedOdmahSve, , , , , , , , , , , , , , , , , CAPIServer, CAPIBaza, , , , , , , , dtJson,, anketarCloud,,,,,,,, kosamnew)
                        End If
                        If sifist.Trim.ToUpper = "SV20" Then
                            Try
                                'm_f.Hide()  
                                'NE SME JER ONDA NEMA IKONICE ZA IST, KOJA SE NE POJAVLJUJE ZA UNOS ZBOG
                                'u propertijima od forma postavljenoi ShownInTaskBar=false  (tao je za previewEditMode u New postavljeno true eksplicitno)
                                frmUSV20.ShowDialog()

                            Catch ex As System.Exception
                                ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Finally
                                frmUSV20.Dispose()
                            End Try
                        Else
                            Try
                                'm_f.Hide()  
                                'NE SME JER ONDA NEMA IKONICE ZA IST, KOJA SE NE POJAVLJUJE ZA UNOS ZBOG
                                'u propertijima od forma postavljenoi ShownInTaskBar=false  (tao je za previewEditMode u New postavljeno true eksplicitno)
                                frmU.ShowDialog()

                            Catch ex As System.Exception
                                ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Finally
                                frmU.Dispose()
                            End Try
                        End If

                    End If

                End If
            Else
                Try
                    frm = New IstrazivanjaUnos.FormISTUnosGlave(mds, mdtLabel, mdtAWL, mdtQE, mdtMessage, DBConnectionString, Me.mucvt, Me.txtInst, Me.txtpismo, Me.txtmode, Me.jezik,
                  Me.DSBrisanjeDEPO, Me.DSBrisanjeServer, Me.DSBrisanjeBaza, ISTConnectionString, GlavneIliPomocne, CAPIServer, CAPIBaza, dtJson, kosamnew)
                    'm_f.Hide()
                    'NE SME JER ONDA NEMA IKONICE ZA IST, KOJA SE NE POJAVLJUJE ZA UNOS ZBOG
                    'u propertijima od forma postavljenoi ShownInTaskBar=false  (tao je za previewEditMode u New postavljeno true eksplicitno)
                    frm.ShowDialog()

                    If GlavneIliPomocne Is Nothing Then
                        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Data entry")
                    Else
                        'pomocne
                        Dim pm As String = ""
                        If Not GlavneIliPomocne Is Nothing AndAlso GlavneIliPomocne.Trim.ToUpper = "POMOCNE" Then
                            pm = "CodeBook table"
                        Else
                            pm = "Main table"
                        End If
                        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("Data entry", pm)
                    End If
                Catch ex As System.Exception
                    If CType(ex, SqlClient.SqlException).ErrorCode = -2147217911 Then
                        Dim msgtxt As String = getMessageText(dtm, "3", Me.jezik) + nvrd
                        ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf CType(ex, SqlClient.SqlException).ErrorCode = -2147217865 Then
                        Dim msgtxt As String = getMessageText(dtm, "4", Me.jezik) + nvrd
                        ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf Me.txtmode <> "Z" AndAlso txtmode.Trim.ToUpper <> "ZCAPI" Then
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        ISTMessageBox.Show("Error, something wrong with database permissions!", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Finally
                    If Not frm Is Nothing Then
                        frm.Dispose()
                    End If
                End Try

            End If
            m_f.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End If
        If Me.mrist.ProgUnos.ToLower.IndexOf(".exe") >= 0 OrElse Me.mrist.ProgUnos.ToLower.IndexOf(".bat") >= 0 Then
            Dim a As String = Me.DBConnectionString
            a = a + Me.mucvt.vtpos
            proces(Me.mfzpzu + "\" + Me.mrist.ProgUnos.Trim, False, Me.mfzpzu, a)
        End If

    End Sub

    Function stopAll(ByVal IndikatorT1 As String, ByVal tabela As String) As Integer

        'da ne zavisimo ni od koga

        Dim Kljucevi() As String = DajKljuceve(tabela)
        Dim capiPrenos As Boolean = CAPIdataUpis1(Kljucevi)

        If capiPrenos = True Then
            Try
                Dim sqlJson As String = "SELECT [key], [keyIST] as name, [value], [type] FROM vCAPIData where ISTapp='" + Me.mrist.SIFIST + "'"
                Try
                    dtJson = Nothing
                    dtJson = izvrsiSQLvratiDTJSON(sqlJson, Me.DBConnectionString, "")
                Catch ex As System.Exception
                    dtJson = Nothing
                End Try
            Catch ex As System.Exception
                dtJson = Nothing
            End Try

            stopAll = 0
            Dim dontopenMSG1 As String = ""
            If IndikatorT1.Trim.ToUpper.IndexOf("DONTOPENIF=") >= 0 Then
                Dim dontopenIF As String = ""
                Dim dontopenMSGIS As String = ""
                Dim nizIndikatorT1() As String = IndikatorT1.Split(";")
                For k As Integer = 0 To nizIndikatorT1.GetUpperBound(0)
                    If nizIndikatorT1(k).IndexOf("DONTOPENIF=") = 0 Then
                        dontopenIF = nizIndikatorT1(k).Replace("DONTOPENIF=", "").Trim.ToUpper
                    End If
                    If nizIndikatorT1(k).IndexOf("DONTOPENMSGIS=") = 0 Then
                        dontopenMSGIS = nizIndikatorT1(k).Replace("DONTOPENMSGIS=", "")
                        If dontopenMSGIS.Trim.ToUpper.IndexOf("<BR>") >= 0 Then
                            dontopenMSGIS = Replace(dontopenMSGIS, "<br>", "~", 1, , CompareMethod.Text)
                            Dim aa() As String = dontopenMSGIS.Split("~")
                            Dim tekst As String = ""
                            For i As Integer = 0 To aa.GetUpperBound(0)
                                tekst = tekst + aa(i) + nvrd
                            Next
                            dontopenMSG1 = tekst
                        Else
                            dontopenMSG1 = dontopenMSGIS
                        End If
                    End If
                Next
                Dim jkey As String = ""
                Dim jvalue As String = ""
                For i As Integer = 0 To dtJson.Rows.Count - 1
                    jkey = jkey + dtJson.Rows(i).Item("key").ToString.Trim.ToUpper + ";"
                    jvalue = jvalue + dtJson.Rows(i).Item("value").ToString.Trim.ToUpper + ";"
                Next
                Dim jk() As String = jkey.Split(";")
                Dim jv() As String = jvalue.Split(";")

                dontopenIF = dontopenIF.Trim.ToUpper.Replace("JSON.", "")
                'Dim kk() As String = dontopenIF.Split("=")
                Dim bbb() As String = razkvantaj(dontopenIF)
                Dim pp As String = ""
                For ll As Integer = 0 To bbb.GetUpperBound(0)
                    If bbb(ll) <> "<>" AndAlso bbb(ll) <> "=" AndAlso bbb(ll) <> "(" AndAlso bbb(ll) <> ")" AndAlso
                   bbb(ll) <> "AND" AndAlso bbb(ll) <> "OR" AndAlso bbb(ll) <> "CAST" AndAlso bbb(ll) <> "," AndAlso
                   bbb(ll) <> "INT" AndAlso bbb(ll) <> "AS" AndAlso bbb(ll) <> "<=" AndAlso bbb(ll) <> ">=" AndAlso
                   bbb(ll) <> "<" AndAlso bbb(ll) <> ">" Then
                        Dim ind As Integer = System.Array.IndexOf(jk, bbb(ll))
                        If ind >= 0 Then
                            bbb(ll) = jv(ind)
                        End If
                    End If
                Next
                Dim zzz As String = ustringaj(bbb).ToUpper()
                stopAll = scompute(zzz, "dontCloseIf", "_ISTTables")
                If stopAll = 1 Then
                    ISTMessageBox.Show(dontopenMSG1, "The end.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("dontOpen message ", "table " + tabela, "dontOpenIF")
                End If
            End If
        End If  'nema prenos

    End Function

    Private Function DajKljuceve(ByVal tbl As String) As String()
        Dim klj() As String = {}
        For Each p As DatasetIstrazivanja.ISTPOLJARow In IstrazivanjeZadaci.mds.ISTPOLJA.Rows
            If p.TABELA.Trim.ToUpper = tbl.Trim.ToUpper Then
                If Not p.IsKLJUCNull AndAlso p.KLJUC.Trim.ToUpper = "P" Then
                    ReDim Preserve klj(1 + klj.GetUpperBound(0))
                    klj(klj.GetUpperBound(0)) = p.POLJE.Trim.ToUpper
                End If
            End If
        Next
        Return klj
    End Function

    Function CAPIdataUpis1(ByVal Kljucevi() As String) As Boolean

        CAPIdataUpis1 = True

        Dim dtCAPI As New Data.DataTable
        Dim dtvCAPI As New Data.DataTable
        Dim dt As New Data.DataTable
        Dim dtpom As New Data.DataTable

        Dim praviKljuc As String = ""
        For i As Integer = 0 To Kljucevi.GetUpperBound(0)
            praviKljuc = praviKljuc + Kljucevi(i).Trim.ToUpper + ";"
        Next
        'CAPITOOL
        'ISTCAPI
        Dim konCAPI As String = getConnectionString(Me.CAPIServer.Trim, Me.CAPIBaza.Trim, txtmode, "")
        Dim sqlCAPI As String = "select top 1 * from CAPIdata"
        dtCAPI = izvrsiSQLvratiDT(sqlCAPI, konCAPI, Me.jezik)
        'provera za vrtacku!!!
        Dim gg As String = dtCAPI.Rows(0).Item("ISTYear").ToString.Trim
        Dim mm As String = dtCAPI.Rows(0).Item("ISTMonth").ToString.Trim
        Dim logovan As String = dtCAPI.Rows(0).Item("ISTUser").ToString.Trim
        If logovan Is Nothing OrElse logovan.Trim = "" Then
            logovan = GetUserName.Trim
        End If
        Dim app As String = dtCAPI.Rows(0).Item("ISTapp").ToString.Trim
        Dim sqlJson As String = dtCAPI.Rows(0).Item("JsonData").ToString.Trim

        If sqlJson Is Nothing OrElse sqlJson.Trim = "" OrElse sqlJson.Trim = "null" Then
            'nema json, nista ne uzima i nista ne moze da predaje
            CAPIdataUpis1 = False
            Exit Function
        End If

        Dim kljucvForJsonData As String = ""
        Dim kljucForJsonData As String = ""

        'PRAVA BAZA
        Dim sqlApp As String = "select * from vForJsonData where 2=3 "
        dtpom = izvrsiSQLvratiDT(sqlApp, Me.DBConnectionString, Me.jezik)
        For Each r As DataColumn In dtpom.Columns   'vForJsonData
            If praviKljuc.IndexOf(r.ColumnName.Trim.ToUpper.Trim.ToUpper + ";") >= 0 Then
                kljucvForJsonData = kljucvForJsonData + r.ColumnName.Trim.ToUpper + ";"
            End If
        Next

        Dim imaG As Boolean = False : Dim imaM As Boolean = False : Dim imaGE As Boolean = False : Dim imaME As Boolean = False
        If kljucvForJsonData.IndexOf("GOD;") >= 0 Then imaG = True : If kljucvForJsonData.IndexOf("ISTYEAR;") >= 0 Then imaGE = True
        If kljucvForJsonData.IndexOf("MES;") >= 0 Then imaM = True : If kljucvForJsonData.IndexOf("ISTMONTH;") >= 0 Then imaME = True

        sqlCAPI = "select [key],keyIST,expr from vCAPIData where Istapp='" + app + "'"
        dtvCAPI = izvrsiSQLvratiDT(sqlCAPI, Me.DBConnectionString, Me.jezik)
        Dim ttt As String = "2=2"

        For i As Integer = 0 To dtvCAPI.Rows.Count - 1
            If kljucvForJsonData.IndexOf(dtvCAPI.Rows(i).Item("keyIST").Trim.ToUpper + ";") >= 0 Then
                ttt = ttt + " and " + dtvCAPI.Rows(i).Item("expr").Trim.ToUpper
            End If
            If praviKljuc.IndexOf(dtvCAPI.Rows(i).Item("keyIST").Trim.ToUpper + ";") >= 0 Then
                kljucForJsonData = kljucForJsonData + dtvCAPI.Rows(i).Item("keyIST").Trim.ToUpper + ";"
            End If
        Next

        If imaG = True Then ttt = ttt + " and GOD='" + CStr(Me.mucvt.G) + "'"
        If imaGE = True Then ttt = ttt + " and ISTYEAR='" + CStr(Me.mucvt.G) + "'"
        If imaM = True Then ttt = ttt + " and MES='" + CStr(Me.mucvt.M).Trim.PadLeft(2, "0"c) + "'"
        If imaME = True Then ttt = ttt + " and ISTMONTH='" + CStr(Me.mucvt.M).Trim.PadLeft(2, "0"c) + "'"

        Dim s As String = ""
        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(sqlJson)

        Try

            sqlApp = "select * from vForJsonData where " + ttt
            dt = izvrsiSQLvratiDT(sqlApp, Me.DBConnectionString, Me.jezik)

            Dim aa As String = ""
            For Each r As DataColumn In dt.Columns
                aa = r.ColumnName.Trim.ToUpper
                If aa <> "GOD" AndAlso aa <> "MES" AndAlso aa <> "ISTYEAR" AndAlso aa <> "ISTMONTH" AndAlso kljucForJsonData.IndexOf(r.ColumnName.Trim.ToUpper + ";") < 0 Then
                    Dim dv As DataRow() = dtvCAPI.Select("keyIST='" + r.ColumnName.Trim.ToUpper + "'")
                    If dv.Length > 0 Then
                        'postoji
                        s = dict(dv(0).Item("key"))
                        dict(dv(0).Item("key")) = dt.Rows(0).Item(r).ToString
                    Else
                        'ne postoji, dodaj u json dv(0).Item("key"), value: dt.Rows(0).Item(r).ToString
                        If dt.Rows.Count > 0 Then
                            dict.Add(r.ColumnName, dt.Rows(0).Item(r).ToString)
                        Else
                            dict.Add(r.ColumnName, "0")
                        End If
                    End If
                End If
            Next

            's = dict("popunjenbroj_stanova")
            'dict("popunjenbroj_stanova") = "321"
            Dim strJson As String = jss.Serialize(dict)
            Dim sql As String = "update CAPIdata set JsonData=N'" + strJson + "' where Istapp='" + app + "'"

            Dim ok1 As String = izvrsiSQL(sql, konCAPI)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER25", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            'ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function

    Function scompute(ByVal zzz As String, ByVal plj As String, ByVal fwhere As String) As Integer
        zzz = razCASTi(zzz)
        scompute = 0
        Dim xxx
        Try
            Dim pom As String = "IIF (" + CStr(zzz).Trim.ToUpper.Replace("D.", "") + ", 1,0)"
            Dim tbl = New DataTable()
            xxx = NZ(tbl.Compute(pom, Nothing))
        Catch ex As System.Exception
            'Dim msg As String = "Syntax for " & plj & " in " & fwhere.Trim.ToUpper & " is not correct" 'getMessageText(dtMessages, "21", Me.jezik)
            'ISTMessageBox.Show(msg + nvrd + ex.Message, msg + ":" + fwhere.Trim.ToUpper, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            xxx = 0
        End Try
        scompute = CInt(xxx)
    End Function

    Public Sub proces(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
        Dim p As New System.Diagnostics.ProcessStartInfo
        ISTMessageBox.Show(fn)
        p.FileName = fn
        p.UseShellExecute = b
        If p.UseShellExecute Then
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Else
            p.WorkingDirectory = wd
            p.Arguments = a
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Try
            System.Diagnostics.Process.Start(p)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub



    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, Optional ByVal izvestaj As String = "", Optional ByVal upit As String = "")
        Dim sifist As String = Me.mrist.SIFIST
        Dim god As String = Me.mucvt.G.ToString
        Dim mes As String = String.Format("{0:d2}", Me.mucvt.M)
        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
                & "(SifIst,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
                & " values( " _
                & "N'" & sifist & "','" & god & "','" & mes & "'," _
                & "'" & proces & "','" + izvestaj & "','" + upit & "'," _
                & "N'" & m_f.GetUserName.ToString.Trim & "'," _
                & "" & "(select top 1 GETDATE())" & ");" + nvrd

        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtmode, Me.DBConnectionString)


        Dim ok1 As String = m_f.izvrsiSQL(strSQL, konDepo)
        If ok1 = "nok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER78", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Public Sub ButtonCATI_Click()
        'prvo logovanje anketara
        'pa ako je to ok onda cati
        Dim adresarCati As String = ""
        Me.txtZoiper = "TRUE"
        Dim catiA As Boolean = False
        Dim catiG As Boolean = False
        If IstrazivanjeZadaci.mds.IST.Rows.Count > 0 Then
            If IstrazivanjeZadaci.mds.ISTTABELE.Rows.Count > 0 Then
                For i As Integer = 0 To IstrazivanjeZadaci.mds.ISTTABELE.Rows.Count - 1
                    Dim t As System.Data.DataRow = IstrazivanjeZadaci.mds.ISTTABELE.Rows(i)
                    Dim tab As String = t.Item("tabela").ToString.Trim.ToUpper
                    Dim dg As String = IIf(t.Item("DG") Is System.DBNull.Value, "", t.Item("DG").ToString.Trim)
                    Dim t1 As String = IIf(t.Item("T1") Is System.DBNull.Value, "", t.Item("T1").ToString.Trim)
                    t1 = t1.Trim.ToUpper
                    If t1.Length > 0 Then
                        Dim pp() As String = t1.Split(";")
                        For k As Integer = 0 To pp.GetUpperBound(0)
                            If pp(k).IndexOf("MIXMODE") = 0 Then
                                Me.txtmode = "MIXMODE"
                                If dg = "" Then dg = "G"
                                If dg = "A" Then
                                    catiA = True
                                    adresarCati = t.Item("tabela").ToString.Trim.ToUpper
                                End If
                                If dg = "G" Then catiG = True
                            ElseIf pp(k).IndexOf("CATI") = 0 Then
                                Me.txtmode = "CATI"
                                If dg = "" Then dg = "G"
                                If dg = "A" Then
                                    catiA = True
                                    adresarCati = t.Item("tabela").ToString.Trim.ToUpper
                                End If
                                If dg = "G" Then catiG = True
                            ElseIf pp(k).IndexOf("CLOUDCATI") = 0 Then
                                Me.txtmode = "CLOUDCATI"
                                If dg = "" Then dg = "G"
                                If dg = "A" Then
                                    catiA = True
                                    adresarCati = t.Item("tabela").ToString.Trim.ToUpper
                                End If
                                If dg = "G" Then catiG = True
                            ElseIf pp(k).IndexOf("ZOIPER=FALSE") = 0 Then
                                Me.txtZoiper = "FALSE"
                            End If
                        Next
                    End If
                Next
            End If
        End If

        If (catiA = True AndAlso catiG = True) Then
            Dim frm As New IstrazivanjaUnos.FormLoginAnketara(IstrazivanjeZadaci.mds, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.mucvt, Me.m_fold, Me.DBConnectionString, Me.mrist,
                                        IstrazivanjeZadaci.mds.ISTTABELE, IstrazivanjeZadaci.mds.ISTPOLJA, IstrazivanjeZadaci.mds.ISTLK,
                                        Me.txtInst, Me.txtpismo, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer,
                                        Me.DSBrisanjeBaza, Me.CATIServer, Me.CATIBaza, adresarCati, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.txtZoiper)
            Try
                frm.ShowDialog()
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                frm.Dispose()
            End Try
        Else
            'Dim por As String = "НЕМАТЕ НИ АДРЕСАР, НИ ТАБЕЛУ ОЗНАЧЕНУ ЗА CATI У ИСТ МЕТАБАЗИ."
            'ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ''msg 5
            Dim msgtxt As String = getMessageText(dtm, "5", Me.jezik) + nvrd
            ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("CATI")
    End Sub

    Public Function ButtonCLOUD_Click() As String
        'prvo logovanje
        'pa ako je to ok onda cloud
        Dim adresarCati As String = ""
        Me.txtZoiper = "FALSE"

        Dim frm As New IstrazivanjaUnos.FormLoginCloud(IstrazivanjeZadaci.mds, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.mucvt, Me.m_fold, Me.DBConnectionString, Me.mrist,
                                        IstrazivanjeZadaci.mds.ISTTABELE, IstrazivanjeZadaci.mds.ISTPOLJA, IstrazivanjeZadaci.mds.ISTLK,
                                        Me.txtInst, Me.txtpismo, Me.DSBrisanjeDEPO, Me.DSBrisanjeServer,
                                        Me.DSBrisanjeBaza, Me.CATIServer, Me.CATIBaza, adresarCati, Me.txtmode, Me.jezik, Me.ISTConnectionString, Me.txtZoiper)
        Try
            frm.ShowDialog()
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Dispose()
            'ISTMessageBox.Show(frm.odgovor)
            ButtonCLOUD_Click = frm.odgovor + ";" + frm.anketarCloud
        End Try

        If lokalno = False Then Call UpisiUISTLogKoriscenjaProcesa("CLOUD")
    End Function

    Private Function razCASTi(ByVal s As String, Optional ByVal tabela As String = "") As String
        Dim raz As Boolean = True

        If s.Trim.ToUpper.IndexOf("CAST") < 0 AndAlso s.Trim.ToUpper.IndexOf("CHARINDEX") < 0 AndAlso s.Trim.ToUpper.IndexOf("INSTR") < 0 AndAlso s.Trim.ToUpper.IndexOf("ISDATE") < 0 AndAlso
s.Trim.ToUpper.IndexOf("ISNUMERIC") < 0 AndAlso s.Trim.ToUpper.IndexOf("LTRIM") < 0 AndAlso s.Trim.ToUpper.IndexOf("RTRIM") < 0 AndAlso s.Trim.ToUpper.IndexOf("LEFT") < 0 AndAlso
s.Trim.ToUpper.IndexOf("RIGHT") < 0 AndAlso s.Trim.ToUpper.IndexOf("LEN") < 0 AndAlso s.Trim.ToUpper.IndexOf("FLOOR") < 0 Then
            raz = False
        End If

        If raz = True Then
            ' CAST ( nesto... AS tip )
            Dim kk() As String = razkvantaj(s)
            Dim trt As String = ""
            Dim i As Integer = 0
            While i <= kk.GetUpperBound(0)
                If kk(i).Trim = "CAST" Or kk(i).Trim = "CHARINDEX" Or kk(i).Trim = "INSTR" Or kk(i).Trim = "ISDATE" Or
kk(i).Trim = "ISNUMERIC" Or kk(i).Trim = "LTRIM" Or kk(i).Trim = "RTRIM" Or kk(i).Trim = "LEFT" Or
kk(i).Trim = "RIGHT" Or kk(i).Trim = "LEN" Or kk(i).Trim = "FLOOR" Then
                    Dim brz As Integer = 1 : Dim pC As Integer = i + 2 : Dim kC As Integer = 0
                    Dim Fja As String = kk(i).Trim
                    Dim ZnakRazdvajanja As String = IIf(kk(i).Trim = "CAST", "AS", ",")
                    i = i + 1
                    While brz > 0
                        i = i + 1
                        If kk(i) = "(" Then brz += 1
                        If kk(i) = ")" Then brz -= 1
                        If kk(i) = ZnakRazdvajanja Then kC = i - 1 'If kk(i) = "AS" Then kC = i - 1
                    End While

                    Dim frazla As String = ""
                    Dim drugiP As String = ""
                    Dim parm As Integer = 0
                    Select Case Fja
                        Case "CAST", "INSTR" '1-vi parametar
                            frazla = ustringaj(kk, pC, kC)'.ToUpper
                        Case "CHARINDEX" '2-gi parametar
                            frazla = ustringaj(kk, kC + 2, i - 1)
                        Case "LEFT", "RIGHT" '1 i 2-gi parametar
                            frazla = ustringaj(kk, pC, kC) '.ToUpper
                            drugiP = ustringaj(kk, kC + 2, i - 1)
                            parm = CType(drugiP, Int32)
                        Case "ISDATE" 'samo 1 parametar
                            frazla = ustringaj(kk, pC, i - 1)
                        Case "ISNUMERIC" 'samo 1 parametar
                            frazla = ustringaj(kk, pC, i - 1)
                        Case "RTRIM" 'samo 1 parametar
                            frazla = ustringaj(kk, pC, i - 1)
                        Case "LTRIM" 'samo 1 parametar
                            frazla = ustringaj(kk, pC, i - 1)
                        Case "LEN" 'samo 1 parametar
                            frazla = ustringaj(kk, pC, i - 1)
                        Case "FLOOR" 'samo 1 parametar
                            frazla = ustringaj(kk, pC, i - 1)
                    End Select
                    If frazla.IndexOf("CAST") >= 0 Or frazla.IndexOf("CHARINDEX") >= 0 Or
                    frazla.IndexOf("INSTR") >= 0 Or frazla.IndexOf("ISDATE") >= 0 Or
                    frazla.IndexOf("ISNUMERIC") >= 0 Or frazla.IndexOf("LTRIM") >= 0 Or
                    frazla.IndexOf("RTRIM") >= 0 Or frazla.IndexOf("LEFT") >= 0 Or
                    frazla.IndexOf("RIGHT") >= 0 Or frazla.IndexOf("LEN") >= 0 Or
                    frazla.IndexOf("FLOOR") >= 0 Then
                        frazla = razCASTi(frazla)
                    End If
                    Dim mrt As Object = Nothing
                    If IsNumeric(frazla) Then    'konstanta, vec je skupio vrednost sa ekrana
                        mrt = frazla
                    Else
                        Dim pomkol As New DataColumn("pomKol")
                        pomkol.Expression = frazla
                        'ako je stiglo iz panela ima kao parametar i tabelu
                        'izbaceno
                    End If
                    mrt = mrt.trim
                    Dim bezNavodnika As String = Replace(Replace(kk(pC), "'", ""), """", "")
                    Select Case Fja
                        Case "CAST"
                            Select Case kk(kC + 2)
                                Case "DATE", "DATETIME", "CHAR", "STRING"
                                    mrt = "'" & CType(mrt, System.String).Trim & "'"
                                Case "INT", "INTEGER", "REAL", "FLOAT", "DECIMAL", "NUMERIC"

                                    If CType(mrt, System.String).Trim.ToUpper.IndexOf("ISNULL") >= 0 Then

                                        'ne radi nista
                                    Else

                                        If mrt.GetType Is GetType(System.DBNull) OrElse
                                CType(mrt, System.String).Trim = "" OrElse
                                IsNumeric(mrt) = False Then
                                            mrt = "0"
                                        End If
                                    End If

                                Case Else
                            End Select
                        Case "CHARINDEX"
                            mrt = InStr(mrt, bezNavodnika)
                        Case "INSTR"
                            mrt = InStr(bezNavodnika, mrt)
                        Case "ISDATE"
                            If IsDate(mrt) Then mrt = " 2=3 " Else mrt = " 2=2 "
                        Case "ISNUMERIC"
                            If IsNumeric(mrt) = True Then
                                mrt = " 2=2 "
                            Else
                                mrt = " 2=3 "
                            End If
                        Case "LTRIM"
                            mrt = "'" & CType(mrt, System.String).Trim & "'"
                        Case "RTRIM"
                            mrt = "'" & CType(mrt, System.String).Trim & "'"
                        Case "LEN"
                            mrt = "'" & CType(mrt, System.String).Trim.Length & "'"
                        Case "FLOOR"
                            If mrt.GetType Is GetType(System.DBNull) OrElse CType(mrt, System.String).Trim = "" OrElse IsNumeric(mrt) = False Then
                                mrt = "0"
                            Else
                                'mrt je the largest integer less than or equal
                                mrt = CType(mrt, Double)
                                mrt = Math.Floor(mrt)
                            End If
                        Case "LEFT"
                            If mrt.trim.length >= parm Then
                                mrt = "'" & mrt.Substring(0, parm).ToString.Trim.ToUpper & "'"
                            Else
                                mrt = "'" & mrt.trim & "'"
                            End If
                        Case "RIGHT"
                            If mrt.trim.length >= parm Then
                                mrt = "'" & mrt.substring(mrt.trim.length - parm) & "'"
                            Else
                                mrt = "'" & mrt.trim & "'"
                            End If
                    End Select
                    trt = trt + " " & mrt
                Else
                    trt = trt + " " & kk(i)
                End If
                trt = trt.Replace(" ' ", "'")
                i = i + 1
            End While
            Return trt
        Else
            Return s
        End If
    End Function

    Private Sub InitializeComponent()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IstrazivanjeZadaci
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(336, 217)
        Me.Name = "IstrazivanjeZadaci"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class