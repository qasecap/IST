Option Strict Off
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class IstrazivanjaZadaci
    Inherits FormTemplate
    Dim ISTConnectionString As String
    Public dsIST As New DatasetIstrazivanja
    Dim m_dsPX As New DatasetIstrazivanja
    Dim mdtAWL As New System.Data.DataTable
    Dim mdtQE As New System.Data.DataTable
    Dim mdtLabel As New System.Data.DataTable
    Dim mdtMessage As New System.Data.DataTable
    Dim PXMETAApp As String

    Public Shared mti As New DatasetIstrazivanja.ISTDataTable

    Public ReadOnly Property MyDatasetIstrazivanja() As DatasetIstrazivanja
        Get
            Return Me.dsIST
        End Get
    End Property

    Public Overloads Sub Dispose()
        mti.Dispose()
        Me.dsIST.Dispose()
        Me.m_dsPX.Dispose()
        mdtAWL.Dispose()
        mdtQE.Dispose()
        mdtLabel.Dispose()
        mdtMessage.Dispose()

    End Sub

    Public jezik As String
    Dim txtlogin As String
    Dim kosamNEW As String
    Dim sql As String
    Public Sub New(ByVal ISTConnectionString As String, ByVal sifist As String, ByVal jezik As String, ByVal txtlogin As String, ByVal kosamNEW As String)

        Me.jezik = jezik
        Me.ISTConnectionString = ISTConnectionString
        'Dim sql As String = ""
        sql = ""
        If txtlogin <> "TRUE" Then
            sql = " select ist.* from (select sifist,min(vod) as vod from ist group by sifist ) i inner join ist on ist.sifist=i.sifist and ist.vod=i.vod where year(ist.vod)<2100"
        Else
            sql = "select SIFIST, sifraT, Naziv, Metodologija, Upitnik, Periodika, BrojTabela, BAZA, ABAZA, TxtDir, ProgUnos, " + nvrd +
                  " (case when ist.vod>u.vod then ist.vod else u.vod end) vod," + nvrd +
                  " (case when ist.vdo<u.vdo then ist.vdo else u.vdo end) vdo, Projektant, Statisticar from ist ist  " + nvrd +
                  " inner join (select * from ISTAPPUsers where APPUser=N'" + kosamNEW + "') u " + nvrd +
                  " on u.appcode=ist.sifist where u.vod<u.vdo and ist.vod<ist.vdo and ist.vod<u.vdo and u.vod<ist.vdo"
        End If

        Try
            Dim dtIST As System.Data.DataTable = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)
            mti.Clear()
            For i As Integer = 0 To dtIST.Rows.Count - 1
                mti.ImportRow(dtIST.Rows(i))
            Next

            If mti.Rows.Count = 0 Then
                Throw New System.Exception("No app!")
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
        Dim appName As String = getControlText2(dt, "lblISTTab1Naziv", Me.jezik)
        Dim appCode As String = getControlText2(dt, "lblISTSifra", Me.jezik)

        With mti
            .SIFISTColumn.Caption = appCode
            .NazivColumn.Caption = appName
            Dim alwaysVisibleCols() As System.Data.DataColumn = { .SIFISTColumn, .NazivColumn}
            Dim cols(.Columns.Count - 1) As System.Data.DataColumn
            .Columns.CopyTo(cols, 0)
            .DefaultView.AllowNew = False
        End With
        Me.dsIST.EnforceConstraints = False
    End Sub



    Public Function MyGetISTRow(ByVal menuItemText As String) As DatasetIstrazivanja.ISTRow
        Dim rv As DatasetIstrazivanja.ISTRow
        rv = dsIST.IST.FindBySIFIST(menuItemText)
        If rv Is Nothing Then
            Return Nothing
        End If
        Return rv
    End Function

    Public Function puniDSIST(ByVal menuItemText As String) As Boolean
        Dim app As String = menuItemText
        Dim proveraISTpostojiAPP As Boolean = proveraISTpostoji(app)
        Try
            If proveraISTpostojiAPP = True Then
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                Call puniDatasetIstrazivanja(app)
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                'puni DatasetIstrazivanja
                Call UpdateReg(app)
            End If

        Catch ex As System.Exception
            Call DeleteReg(app)
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return proveraISTpostojiAPP
    End Function
    Function proveraISTpostoji(ByVal app As String) As Boolean
        'Dim sqlIST = "select * from IST where sifIST=N'" + app.Trim + "';"
        Dim sqlist As String = sql + " and ist.sifist=N'" + app.Trim + "';"
        Dim postoji As Boolean = True
        Try
            Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sqlIST, ISTConnectionString, Nothing)
            If dt.Rows.Count = 0 Then
                postoji = False
            End If
        Catch ex As System.Exception
            postoji = False
        End Try
        Return postoji
    End Function
    Sub puniDatasetIstrazivanja(ByVal app As String)
        Me.dsIST.Clear()
        Me.m_dsPX.Clear()
        Me.mdtAWL.Clear()
        Me.mdtQE.Clear()
        Me.mdtLabel.Clear()
        Me.mdtMessage.Clear()

        fISTNovo1Deo(app) 'ISTBAZE,IST

        If Me.dsIST.IST.Rows.Count = 0 Then
            Exit Sub
        End If

        Dim appStaraApl As String = app : Dim appR As String = app : Dim tablesT As String = "" 'tabele, polja i LK moraju da budu iz iste app
        If Not Me.dsIST.IST.Rows(0).Item("Abaza") Is System.DBNull.Value Then
            Dim additionalParameters As String = Me.dsIST.IST.Rows(0).Item("Abaza").ToString.Trim.ToUpper
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

        fISTTABELE(Me.dsIST, app, appStaraApl, tablesT.Trim.ToUpper)
        fISTNovo2Deo(app, appStaraApl, tablesT.Trim.ToUpper)  'ISTOPOLJA, ISTLK
        fISTOstalo(app, appStaraApl, tablesT.Trim.ToUpper)


    End Sub

    Sub fISTNovo1Deo(ByVal app As String)
        Dim sqlISTBAZE As String = "select * from ISTBaze;"
        'Dim sqlIST = "select * from IST where sifIST=N'" + app.Trim + "';"
        Dim sqlist As String = sql + " and  ist.sifIST=N'" + app.Trim + "';"
        Dim ssql As String = sqlISTBAZE + sqlist

        Try
            Dim ds As System.Data.DataSet = izvrsiSQLvratiDS(ssql, ISTConnectionString, Nothing)
            'Me.dsIST.ISTBAZE.Clear()
            'Me.dsIST.IST.Clear()
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Me.dsIST.ISTBAZE.ImportRow(ds.Tables(0).Rows(i))
            Next
            For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
                Me.dsIST.IST.ImportRow(ds.Tables(1).Rows(i))
            Next
            If Me.dsIST.IST.Rows.Count = 0 Then
                ''msg 277
                Dim msgtxt277 As String = getMessageText(dtMessages, "277", Me.jezik)
                Throw New System.Exception(msgtxt277)
            End If
        Catch ex As System.Exception
            'vrati se na povratak istrazivanja
            Dim por As String = ""
            'Dim por As String = "CHECK databaseType (FIZBAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseType THAT DOES NOT EXISTS IN table _ISTDatabaseConnStrings (ISTBAZE)." + nvrd + nvrd +
            '    "CHECK databaseAlias (BAZA) IN THIS TABLE, YOU PROBABLY HAVE databaseAlias THAT DOES NOT EXISTS IN table _IST." + nvrd
            ISTMessageBox.Show("_IST _ISTDatabaseConnStrings (ISTBAZE) !!!! " + nvrd + por + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub fISTNovo2Deo(ByVal app As String, ByVal appStaraApl As String, ByVal tablesT As String)
        If Me.dsIST.ISTTABELE.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt2741 As String = getMessageText(dtMessages, "2741", Me.jezik)
            ISTMessageBox.Show(msgtxt2741)
            Exit Sub
        End If
        Dim sqlISTPolja As String = ""
        Dim sqlISTLK As String = ""
        If app <> appStaraApl Then
            sqlISTPolja = "select * from ISTPolja where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')  order by tabela,rbr;"
            sqlISTLK = "select SIfIST,TABELA,RbrGreske,replace(GRESKA,'webrelacija','Relacija') as greska,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo" +
                 " from ISTLk " +
                 " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                 " order by sifIST,tabela,rbrgreske;"
        Else
            'tabele koje postoje u ISTTabele
            Dim ttabele As String = ""
            For i As Integer = 0 To Me.dsIST.ISTTABELE.Rows.Count - 1
                ttabele = ttabele + "'" + DirectCast((Me.dsIST.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
            Next
            ttabele = ttabele.TrimEnd(CType(",", Char()))

            sqlISTPolja = "select * from ISTPolja where sifIST =N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                    " order by tabela,rbr;"
            sqlISTLK = "select SIfIST,TABELA,RbrGreske,replace(GRESKA,'webrelacija','Relacija') as greska,USLOV,NazivGreske,Akcija,tezina,Vod,Vdo" +
              " from ISTLk " +
              " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
              " order by sifIST,tabela,rbrgreske; "
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

        Me.dsIST.ISTPOLJA.Clear()

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Me.dsIST.ISTPOLJA.ImportRow(ds.Tables(0).Rows(i))
        Next

        If Me.dsIST.ISTPOLJA.Rows.Count = 0 Then
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
        Me.dsIST.ISTLK.Clear()

        For i As Integer = 0 To ds.Tables(1).Rows.Count - 1
            Me.dsIST.ISTLK.ImportRow(ds.Tables(1).Rows(i))
        Next

        If Me.dsIST.ISTLK.Rows.Count = 0 Then
            ''msg 275
            Dim msgtxt275 As String = getMessageText(dtMessages, "275", Me.jezik)
            ISTMessageBox.Show(msgtxt275, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            For i As Integer = 0 To Me.dsIST.ISTLK.Rows.Count - 1
                Dim ppp As String = ""
                If Not (Me.dsIST.ISTLK.Rows(i).Item("uslov").GetType Is GetType(System.DBNull) OrElse Me.dsIST.ISTLK.Rows(i).Item("uslov").Trim = "") Then
                    ppp = Me.dsIST.ISTLK.Rows(i).Item("uslov").trim.toupper
                    If ppp.IndexOf("LKVELIKA") < 0 AndAlso ppp.IndexOf("LKUNOS") < 0 AndAlso ppp.IndexOf("EXECUTEONLYONDATAENTRYFORM") < 0 AndAlso ppp.IndexOf("EXECUTEONLYFROMDATAVALIDATIONMODULE") < 0 AndAlso ppp.IndexOf("EXECUTEONLYONADDEDBUTTONCONTROL") < 0 AndAlso ppp.IndexOf("DONTSAVE") < 0 AndAlso ppp.IndexOf("DONTSEND") < 0 Then
                        Me.dsIST.ISTLK.Rows(i).Item("uslov") = ""
                    End If
                End If
            Next
        End If

    End Sub

    Sub fISTTABELE(ByVal ds As DatasetIstrazivanja, ByVal app As String, ByVal appStaraApl As String, ByVal tablesT As String)

        Dim sql As String = ""
        If app <> appStaraApl Then
            sql = "select * from ISTTabele where sifist in (N'" + app.Trim + "',N'" + app.Trim + "') and isnull(T1,'') not like '%ISTVIEW%'  order by baza"
        Else
            sql = "select * from ISTTabele where sifist=N'" + app.Trim + "' and isnull(T1,'') not like '%ISTVIEW%' order by baza"
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

    Sub fISTOstalo(ByVal app As String, ByVal appStaraApl As String, ByVal tablesT As String)

        If Me.dsIST.ISTTABELE.Rows.Count = 0 Then
            ''msg 274
            Dim msgtxt2741 As String = getMessageText(dtMessages, "2741", Me.jezik)
            ISTMessageBox.Show(msgtxt2741)
            Exit Sub
        End If

        Dim sqlISTAWLs As String = ""
        Dim sqlISTQuestionExplanation As String = ""
        Dim sqlISTLabels As String = ""

        Dim sqlISTABS As String = "select * from ISTTabs where sifist in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
        " order by sifist,rbrTabele;"

        Dim sqlISTMessages As String = " select * from ISTMessages where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "') " +
            " order by IDLang,IDMsg;"

        If app <> appStaraApl Then
            sqlISTAWLs = " select * from ISTAWLs" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " order by tabela,polje;"
            sqlISTQuestionExplanation = " select * from ISTQuestionExplanation" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " order by tabela,polje;"
            sqlISTLabels = " select * from ISTLabels" +
                  " where sifIST in (N'" + appStaraApl.Trim + "',N'" + app.Trim + "')" +
                  " order by tabela,polje;"
        Else
            'tabele koje postoje u ISTTabele
            Dim ttabele As String = ""
            For i As Integer = 0 To Me.dsIST.ISTTABELE.Rows.Count - 1
                ttabele = ttabele + "'" + DirectCast((Me.dsIST.ISTTABELE.Rows(i)), DatasetIstrazivanja.ISTTABELERow).Tabela + "',"
            Next
            ttabele = ttabele.TrimEnd(CType(",", Char()))

            sqlISTAWLs = "select * from ISTAWLs " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " order by tabela,polje;"
            sqlISTQuestionExplanation = "select * from ISTQuestionExplanation " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " order by tabela,polje;"
            sqlISTLabels = "select * from ISTLabels " +
                 " where sifIST=N'" + appStaraApl.Trim + "' and tabela in (" + ttabele + ")" +
                 " order by tabela,polje;"
        End If

        Dim ssql As String = sqlISTABS + sqlISTAWLs + sqlISTQuestionExplanation + sqlISTLabels + sqlISTMessages

        Dim ds As System.Data.DataSet = izvrsiSQLvratiDS(ssql, Me.ISTConnectionString, Nothing)
        If app <> appStaraApl Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i)("sifIST") = app
            Next
        End If
        Me.dsIST.ISTTABS.Clear()

        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            Me.dsIST.ISTTABS.ImportRow(ds.Tables(0).Rows(i))
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

    Public mri As DatasetIstrazivanja.ISTRow

    Sub promenaMETA(ByVal tablesT As String, ByVal dt As System.Data.DataTable, Optional nadtabela As Boolean = False,
                    Optional izraz As Boolean = False, Optional T1 As Boolean = False, Optional T2 As Boolean = False,
                    Optional greska As Boolean = False)
        Dim prom As Boolean = False
        If tablesT <> "" Then
            Dim pp() As String = tablesT.Trim.Replace(vbCrLf, "").Replace(vbCr, "").Replace(vbLf, "").Split(CType(",", Char()))
            For i As Integer = 0 To pp.GetUpperBound(0)
                prom = False
                Dim kk() As String = pp(i).Split(CType("=", Char()))
                If kk.Length = 2 AndAlso kk(0) <> "" AndAlso kk(1) <> "" Then
                    If kk(0) <> kk(1) Then
                        Dim kkL As String = kk(0)
                        Dim kkD As String = kk(1)

                        For ii As Integer = 0 To dt.Rows.Count - 1

                            If dt.Rows(ii).Item("tabela").ToString.Trim.ToUpper = kk(0) Then
                                dt.Rows(ii).Item("tabela") = kk(1)
                                prom = True
                            End If

                            If nadtabela = True AndAlso dt.Rows(ii).Item("nadtabela").ToString.Trim.ToUpper = kk(0) Then dt.Rows(ii).Item("nadtabela") = kk(1)

                            If T1 = True AndAlso dt.Rows(ii).Item("t1").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii).Item("t1").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("t1") = iizz
                            End If
                            If T2 = True AndAlso dt.Rows(ii).Item("t2").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii).Item("t2").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("t2") = iizz
                            End If

                            If izraz = True AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("SELECT") >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) AndAlso bbb(ll - 1) = "FROM" Then
                                        bbb(ll) = kk(1)
                                    End If
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("izraz") = iizz
                            End If
                            If izraz = True AndAlso dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                                dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper.IndexOf(".") > 0 AndAlso dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper.IndexOf("}") > 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) AndAlso bbb(ll - 1) = "{" AndAlso bbb.GetUpperBound(0) >= ll + 1 AndAlso bbb(ll + 1) = "." Then
                                        bbb(ll) = kk(1)
                                    End If
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("izraz") = iizz
                            End If
                            If izraz = True AndAlso dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                                dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf(".") > 0 AndAlso dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper.IndexOf("}") > 0 AndAlso dt.Rows(ii)("izraz").ToString.Trim.ToUpper.IndexOf("SELECT") < 0 Then
                                Dim nn As String = dt.Rows(ii).Item("izraz").ToString.Trim.ToUpper
                                nn = nn.Replace(kk(0).Trim.ToUpper, kk(1).Trim.ToUpper)
                                dt.Rows(ii)("izraz") = nn
                            End If
                            If greska = True AndAlso dt.Rows(ii).Item("greska").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 Then
                                Dim bbb() As String = razkvantaj(dt.Rows(ii).Item("greska").ToString.Trim.ToUpper)
                                For ll As Integer = 0 To bbb.GetUpperBound(0)
                                    If bbb(ll) = kk(0) Then bbb(ll) = kk(1)
                                    If bbb(ll).IndexOf(".") >= 0 Then
                                        Dim tt() As String = bbb(ll).Split(CChar("."))
                                        If tt.Length = 2 AndAlso tt(0) = kk(0) Then bbb(ll) = kk(1) + "." + tt(1)
                                        If tt.Length = 3 AndAlso tt(2) = kk(0) Then bbb(ll) = tt(0) + "." + tt(1) + "." + kk(1)   'sbs2020.dbo.imetabele
                                    End If
                                Next
                                Dim iizz As String = ustringaj(bbb).ToUpper.Replace(" =", "=").Replace("= ", "=").Replace(" = ", "=")
                                dt.Rows(ii)("greska") = iizz
                            End If
                            If greska = True AndAlso dt.Rows(ii).Item("greska").ToString.Trim.ToUpper.IndexOf(kk(0)) >= 0 AndAlso dt.Rows(ii).Item("greska").ToString.Trim.ToUpper.IndexOf("{") >= 0 AndAlso
                                dt.Rows(ii).Item("greska").ToString.Trim.ToUpper.IndexOf("RELACIJA") > 0 AndAlso dt.Rows(ii).Item("greska").ToString.Trim.ToUpper.IndexOf("}") > 0 AndAlso dt.Rows(ii)("greska").ToString.Trim.ToUpper.IndexOf("SELECT") < 0 Then
                                Dim nn As String = dt.Rows(ii).Item("greska").ToString.Trim.ToUpper
                                nn = nn.Replace(kk(0).Trim.ToUpper, kk(1).Trim.ToUpper)
                                dt.Rows(ii).Item("greska") = nn
                            End If
                        Next

                    End If
                End If
            Next
        End If
    End Sub

    Private Sub fttabs(ByVal ds As DatasetIstrazivanja, ByVal app As String, ByVal appT As String)
        Dim sql As String
        sql = "select * from ISTTabs where sifist in (N'" + appT.Trim + "',N'" + app.Trim + "') order by sifist,rbrTabele"
        Try
            Dim dtIST As System.Data.DataTable = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)
            ds.ISTTABS.Clear()
            For i As Integer = 0 To dtIST.Rows.Count - 1
                ds.ISTTABS.ImportRow(dtIST.Rows(i))
            Next
            If app <> appT Then
                For i As Integer = 0 To ds.ISTTABS.Rows.Count - 1
                    ds.ISTTABS.Rows(i)("sifist") = app
                Next
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message)
        End Try
    End Sub

    'Public Sub IstrazivanjaRefresh()
    '    Dim sql As String
    '    mti.Clear()
    '    With mti 'prepisano iz New, odvojen kao poseban, mada ga New ne koristi...
    '        sql = "select " + mti.TableName.Trim + ".*"
    '        sql += " from (select " + mti.SIFISTColumn.ColumnName + ",min(" + mti.VodColumn.ColumnName + ") as " + .VodColumn.ColumnName +
    '            " from " + .TableName + " group by " + mti.SIFISTColumn.ColumnName + ") i inner join " + mti.TableName + " on i." + .SIFISTColumn.ColumnName + "=" + mti.TableName.Trim + "." + .SIFISTColumn.ColumnName + " and i." + mti.VodColumn.ColumnName + "=" + mti.TableName.Trim + "." + mti.VodColumn.ColumnName
    '        sql += " where year(IST.vod)<2100 "
    '        sql += " order by " + mti.TableName.Trim + "." + mti.SIFISTColumn.ColumnName
    '    End With


    '    Try

    '        Dim dtIST As System.Data.DataTable = izvrsiSQLvratiDT(sql, ISTConnectionString, Nothing)
    '        mti.Clear()
    '        For i As Integer = 0 To dtIST.Rows.Count - 1
    '            mti.ImportRow(dtIST.Rows(i))
    '        Next

    '        If mti.Rows.Count = 0 Then
    '            ''msg 273
    '            Dim msgtxt273 As String = getMessageText(dtMessages, "273", Me.jezik)
    '            Throw New System.Exception(msgtxt273)
    '        End If
    '        mti.AcceptChanges()
    '    Catch ex As System.Exception
    '        ISTMessageBox.Show(ex.Message)

    '    End Try

    'End Sub

End Class