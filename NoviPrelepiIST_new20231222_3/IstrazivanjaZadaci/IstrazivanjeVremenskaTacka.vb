Imports System.Configuration
Imports System.Windows.Forms


Public Class IstrazivanjeVremenskaTacka
    Inherits FormTemplate
    Dim forma As FormTemplate
    Public dsdsIST As DatasetIstrazivanja
    Public dsdsISTPX As DatasetIstrazivanja
    Dim dsIST_lokalni As New DatasetIstrazivanja
    Dim dsISTPX_lokalni As New DatasetIstrazivanja
    Dim f2 As FormIntervaliVremenskeTacke
    Dim tafil_vod As New DatasetIstrazivanja.ISTPOLJADataTable
    Dim tafil_vodPX As New DatasetIstrazivanja.ISTPOLJADataTable
    Public lchk As LCHk2
    Dim ISTConnectionString As String
    Dim bpromena As System.Windows.Forms.Button
    Dim bizlaz As System.Windows.Forms.LinkLabel
    Dim dreg As Microsoft.Win32.RegistryKey
    Public WithEvents ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim redIST As DatasetIstrazivanja.ISTRow
    Dim redISTPX As DatasetIstrazivanja.ISTRow
    Dim brd As Boolean = True
    Dim blo As Boolean = True
    Dim con2 As String
    Dim lbclk As System.Windows.Forms.Button
    Dim txtpismo As String
    Dim txtmode As String
    Dim PXMETAApp As String
    Dim jezik As String

    Public ReadOnly Property LB_CLK() As System.Windows.Forms.Button
        Get
            Return Me.lbclk
        End Get
    End Property


    Public Sub DDispose()
        Me.f2.Dispose()
        dsIST_lokalni.Dispose()
        Me.tafil_vod.Dispose()
    End Sub

    Public Sub New(
    ByVal frm As FormTemplate,
    ByVal ri As DatasetIstrazivanja.ISTRow,
    ByVal cn As String,
    ByVal ds As DatasetIstrazivanja, ByVal dsPX As DatasetIstrazivanja,
    ByVal ucvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
    ByVal tbs As System.Windows.Forms.Label,
    ByVal tbn As System.Windows.Forms.Label,
    ByVal bpi As System.Windows.Forms.Button,
    ByVal bizl As System.Windows.Forms.LinkLabel,
    ByVal appRegistryKey As Microsoft.Win32.RegistryKey,
    ByVal txtpismo As String, ByVal txtMode As String, ByVal jezik As String, ByVal PXMETAApp As String, ByVal odakle As String)
        Me.forma = frm
        Me.dsdsIST = ds
        Me.dsdsISTPX = dsPX
        Me.ISTConnectionString = cn
        Me.jezik = jezik
        Me.PXMETAApp = PXMETAApp
        Me.txtpismo = txtpismo
        Me.txtmode = txtMode
        Me.ucvt = ucvt
        Me.f2 = New FormIntervaliVremenskeTacke(dsdsIST, Me.txtpismo, Me.jezik)
        Me.lchk = New LCHk2(cn, Me.jezik, Me.txtmode)

        Dim godina As Integer
        Dim mesec As Integer
        Dim d As Date

        If txtMode = "CAPI" OrElse txtMode = "TESTCAPI" OrElse txtMode = "CAPITEST" Then
            tbs.Text = DirectCast((ds.IST.Rows(0)), DatasetIstrazivanja.ISTRow).SIFIST
            tbn.Text = DirectCast((ds.IST.Rows(0)), DatasetIstrazivanja.ISTRow).Naziv
            godina = ucvt.G
            mesec = ucvt.M
            d = New Date(godina, mesec, 2)
            Me.ucvt.MyInit("Vod", "Vdo", Date.MinValue, Date.MaxValue, New Date(ucvt.G, ucvt.M, 2))
        Else
            Me.bpromena = bpi
            Me.bizlaz = bizl
            If ri Is Nothing Then Exit Sub
            tbs.Text = ri.SIFIST.Trim
            tbn.Text = ri.Naziv.Trim

            ''''''''
            Dim subKeyDatum As String = "IzabranDatum"
            appRegistryKey.CreateSubKey(subKeyDatum)
            Me.dreg = appRegistryKey.OpenSubKey(subKeyDatum, True)
            If odakle.Trim.ToUpper = "NEW" Then
                d = Me.f2.zvvt
                Dim godinaPom As String = System.Text.RegularExpressions.Regex.Replace(CStr(Me.dreg.GetValue("godina", d.Year)), "[^\d]", " ")
                If godinaPom = "" Then godinaPom = CStr(Year(System.DateTime.Now))
                godina = CInt(godinaPom)
                Dim mesecPom As String = System.Text.RegularExpressions.Regex.Replace(CStr(Me.dreg.GetValue("mesec", d.Month)), "[^\d]", " ")
                If mesecPom = "" Then mesecPom = CStr(Month(System.DateTime.Now))
                mesec = CInt(mesecPom)
                If mesec > 12 Then mesec = 12 Else If mesec = 0 Then mesec = 1
                d = New Date(godina, mesec, 2)
                Me.ucvt.MyInit(ds.IST.VodColumn.ColumnName, ds.IST.VdoColumn.ColumnName, Date.MinValue, Date.MaxValue, d)
                'Else
                '    godina = ucvt.G
                '    mesec = ucvt.M
            End If
        End If

    End Sub

    Public Function MyUpdateDatasetFilteredByVodVdo() As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        MyUpdateDatasetFilteredByVodVdo = "0" 'sve ok
        dsIST_lokalni.Clear()
        dsIST_lokalni.AcceptChanges()
        Dim vt As Date
        With Me.ucvt.MyValue
            vt = New Date(.Year, .Month, Date.DaysInMonth(.Year, .Month))
        End With
        '''''''
        ''''
        'ISTBaza

        For Each rowISTBaza As DatasetIstrazivanja.ISTBAZERow In dsdsIST.ISTBAZE.Rows
            Try
                If rowISTBaza.Vod <= vt AndAlso vt <= rowISTBaza.Vdo Then
                    'If dsIST_lokalni.ISTBAZE.Rows.Count > 162 Then
                    '    ISTMessageBox.Show("ssss")
                    '    Dim sss As Integer = 1
                    '    sss = sss + 1
                    'End If
                    dsIST_lokalni.ISTBAZE.Rows.Add(rowISTBaza.ItemArray)
                End If
            Catch ex As System.Exception
                MyUpdateDatasetFilteredByVodVdo = "1"
                Exit For
            End Try
        Next

        If dsIST_lokalni.ISTBAZE.Rows.Count = 0 Then
            ''msg 255
            Dim msgtxt255 As String = getMessageText(dtMessages, "255", Me.jezik)
            Throw New System.Exception(msgtxt255)
        End If
        Dim poruka As String = ""
        Dim fizbaza As Boolean = False
        'IST
        For Each rowIST As DatasetIstrazivanja.ISTRow In dsdsIST.IST.Rows
            Try
                If rowIST.Vod <= vt AndAlso vt <= rowIST.Vdo Then
                    Try
                        dsIST_lokalni.IST.Rows.Add(rowIST.ItemArray)
                    Catch ex As System.Exception
                        'rowIST.ItemArray
                        Dim baza As String = rowIST.Item("baza").ToString.Trim
                        Dim txt As String = baza + " do not exists in _ISTDatabaseConnStrings " + nvrd + nvrd +
                        "Check ValidFrom and ValidTo for " + baza + " in _ISTDatabaseConnStrings"
                        poruka = txt + nvrd + nvrd + ex.Message
                        fizbaza = True
                    End Try
                    Me.redIST = rowIST
                    Exit For
                End If
            Catch ex As System.Exception
                MyUpdateDatasetFilteredByVodVdo = "2"
                Exit For
            End Try
        Next
        If dsIST_lokalni.IST.Rows.Count = 0 Then
            If fizbaza = True Then
                Throw New System.Exception(poruka)
            Else
                ''msg 258
                Dim msgtxt258 As String = getMessageText(dtMessages, "258", Me.jezik)
                Throw New System.Exception(msgtxt258)
            End If
        End If

        'ISTTABELE
        For Each rowISTTABELE As DatasetIstrazivanja.ISTTABELERow In dsdsIST.ISTTABELE.Rows
            Try
                If rowISTTABELE.Vod <= vt AndAlso vt <= rowISTTABELE.Vdo Then
                    dsIST_lokalni.ISTTABELE.Rows.Add(rowISTTABELE.ItemArray)
                End If
            Catch ex As System.Exception
                MyUpdateDatasetFilteredByVodVdo = "3$" + rowISTTABELE.Tabela.ToString
                Exit For
            End Try
        Next
        'javice mRefresh!!!
        'If dsIST_lokalni.ISTTABELE.Rows.Count = 0 Then
        '    ''msg 259
        '    Dim msgtxt259 As String = getMessageText(dtMessages, "259", Me.jezik)
        '    'Throw New System.Exception(msgtxt259)
        '    ISTMessageBox.Show(msgtxt259)
        'End If
        ''''
        'ISTLK
        For Each vazecaTabela As DatasetIstrazivanja.ISTTABELERow In dsIST_lokalni.ISTTABELE.Rows
            For Each rowISTLK As DatasetIstrazivanja.ISTLKRow In dsdsIST.ISTLK.Rows
                Try
                    If rowISTLK.Vod <= vt AndAlso vt <= rowISTLK.Vdo AndAlso rowISTLK.TABELA.Trim.ToUpper = vazecaTabela.Tabela.Trim.ToUpper Then
                        dsIST_lokalni.ISTLK.Rows.Add(rowISTLK.ItemArray)
                    End If
                Catch ex As System.Exception
                    MyUpdateDatasetFilteredByVodVdo = "4$" + rowISTLK.TABELA.ToString + "$" + rowISTLK.RbrGreske.ToString
                    Exit For
                End Try
            Next
        Next
        ''''
        'ISTPOLJA
        For Each vazecaTabela As DatasetIstrazivanja.ISTTABELERow In dsIST_lokalni.ISTTABELE.Rows
            For Each rowISTPolja As DatasetIstrazivanja.ISTPOLJARow In dsdsIST.ISTPOLJA.Rows
                Try
                    If rowISTPolja.Vod <= vt AndAlso vt <= rowISTPolja.Vdo AndAlso rowISTPolja.TABELA.Trim.ToUpper = vazecaTabela.Tabela.Trim.ToUpper Then
                        dsIST_lokalni.ISTPOLJA.Rows.Add(rowISTPolja.ItemArray)
                    End If
                Catch ex As System.Exception
                    MyUpdateDatasetFilteredByVodVdo = "5$" + rowISTPolja.TABELA.Trim.ToUpper + "$" + rowISTPolja.POLJE.ToString
                    Exit For
                End Try
            Next
        Next
        ''''
        'ISTTABS
        For Each rowISTTabs As DatasetIstrazivanja.ISTTABSRow In dsdsIST.ISTTABS.Rows
            Try
                If rowISTTabs.Vod <= vt AndAlso vt <= rowISTTabs.Vdo Then
                    dsIST_lokalni.ISTTABS.Rows.Add(rowISTTabs.ItemArray)
                End If
            Catch ex As System.Exception
                MyUpdateDatasetFilteredByVodVdo = "6$" + rowISTTabs.RbrTabele.ToString + "$" + rowISTTabs.Naziv.ToString
                Exit For
            End Try
        Next
        ''''''
        Me.tafil_vod.Clear()
        For Each red As DatasetIstrazivanja.ISTPOLJARow In dsIST_lokalni.ISTPOLJA.Rows
            Dim aaa As String = red.ISTTABELERowParent.IsDGNull.ToString.Trim
            If Not red.ISTTABELERowParent.IsDGNull _
            AndAlso Not red.IsKLJUCNull _
            AndAlso red.KLJUC.Trim = "P" _
            AndAlso Not red.IsVodNull _
            AndAlso Not red.IsVdoNull _
            AndAlso red.Vod <= vt AndAlso vt <= red.Vdo Then
                Me.tafil_vod.Rows.Add(red.ItemArray)
            End If
        Next
        dsIST_lokalni.AcceptChanges()
        Me.tafil_vod.AcceptChanges()
    End Function

    Public Function filterFORPXMETADATA() As String
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        filterFORPXMETADATA = "0" 'sve ok
        dsISTPX_lokalni.Clear()
        dsISTPX_lokalni.AcceptChanges()
        Dim vt As Date
        With Me.ucvt.MyValue
            vt = New Date(.Year, .Month, Date.DaysInMonth(.Year, .Month))
        End With
        '''''''
        ''''
        'ISTBaza
        For Each rowISTBaza As DatasetIstrazivanja.ISTBAZERow In dsIST_lokalni.ISTBAZE.Rows
            Try
                If rowISTBaza.Vod <= vt AndAlso vt <= rowISTBaza.Vdo Then
                    dsISTPX_lokalni.ISTBAZE.Rows.Add(rowISTBaza.ItemArray)
                End If
            Catch
                filterFORPXMETADATA = "1"
                Exit For
            End Try
        Next
        filterFORPXMETADATA = "8"
        If dsISTPX_lokalni.ISTBAZE.Rows.Count = 0 Then
            ''msg 255
            Dim msgtxt255 As String = getMessageText(dtMessages, "255", Me.jezik)
            Throw New System.Exception(msgtxt255)
        End If
        Dim poruka As String = ""
        Dim fizbaza As Boolean = False
        'IST
        For Each rowIST As DatasetIstrazivanja.ISTRow In IstrazivanjaZadaci.mti.Rows
            Try
                If rowIST.Vod <= vt AndAlso vt <= rowIST.Vdo AndAlso rowIST.SIFIST.Trim.ToUpper = Me.PXMETAApp.Trim.ToUpper Then
                    Try
                        dsISTPX_lokalni.IST.Rows.Add(rowIST.ItemArray)
                    Catch ex As System.Exception
                        ''msg 256
                        Dim msgtxt256 As String = getMessageText(dtMessages, "256", Me.jezik)
                        ''msg 257
                        Dim msgtxt257 As String = getMessageText(dtMessages, "257", Me.jezik)
                        poruka = msgtxt256 + nvrd + msgtxt257 + nvrd + nvrd + ex.Message
                        fizbaza = True
                    End Try
                    Me.redISTPX = rowIST
                    Exit For
                End If
            Catch
                filterFORPXMETADATA = "2"
                Exit For
            End Try
        Next
        If dsISTPX_lokalni.IST.Rows.Count = 0 Then
            If fizbaza = True Then
                Throw New System.Exception(poruka)
            Else
                ''msg 258
                Dim msgtxt258 As String = getMessageText(dtMessages, "258", Me.jezik)
                Throw New System.Exception(msgtxt258)
            End If
        End If

        'ISTTABELE
        For Each rowISTTABELE As DatasetIstrazivanja.ISTTABELERow In dsdsISTPX.ISTTABELE.Rows
            Try
                If rowISTTABELE.Vod <= vt AndAlso vt <= rowISTTABELE.Vdo AndAlso rowISTTABELE.SifIst.Trim.ToUpper = Me.PXMETAApp.Trim.ToUpper Then
                    dsISTPX_lokalni.ISTTABELE.Rows.Add(rowISTTABELE.ItemArray)
                End If
            Catch
                filterFORPXMETADATA = "3$" + rowISTTABELE.Tabela.ToString
                Exit For
            End Try
        Next
        If dsISTPX_lokalni.ISTTABELE.Rows.Count = 0 Then
            ''msg 259
            Dim msgtxt259 As String = getMessageText(dtMessages, "259", Me.jezik)
            Throw New System.Exception(msgtxt259)
        End If
        ''''
        'ISTLK
        For Each vazecaTabela As DatasetIstrazivanja.ISTTABELERow In dsISTPX_lokalni.ISTTABELE.Rows
            For Each rowISTLK As DatasetIstrazivanja.ISTLKRow In dsdsISTPX.ISTLK.Rows
                Try
                    If rowISTLK.Vod <= vt AndAlso vt <= rowISTLK.Vdo AndAlso rowISTLK.SIFIST.Trim.ToUpper = Me.PXMETAApp.Trim.ToUpper AndAlso rowISTLK.TABELA.Trim.ToUpper = vazecaTabela.Tabela.Trim.ToUpper Then
                        dsISTPX_lokalni.ISTLK.Rows.Add(rowISTLK.ItemArray)
                    End If
                Catch
                    filterFORPXMETADATA = "4$" + rowISTLK.TABELA.ToString + "$" + rowISTLK.RbrGreske.ToString
                    Exit For
                End Try
            Next
        Next
        ''''
        'ISTPOLJA
        For Each vazecaTabela As DatasetIstrazivanja.ISTTABELERow In dsISTPX_lokalni.ISTTABELE.Rows
            For Each rowISTPolja As DatasetIstrazivanja.ISTPOLJARow In dsdsISTPX.ISTPOLJA.Rows
                Try
                    If rowISTPolja.Vod <= vt AndAlso vt <= rowISTPolja.Vdo AndAlso rowISTPolja.SIFIST.Trim.ToUpper = Me.PXMETAApp.Trim.ToUpper AndAlso rowISTPolja.TABELA.Trim.ToUpper = vazecaTabela.Tabela.Trim.ToUpper Then
                        dsISTPX_lokalni.ISTPOLJA.Rows.Add(rowISTPolja.ItemArray)
                    End If
                Catch
                    filterFORPXMETADATA = "5$" + rowISTPolja.TABELA.Trim.ToUpper + "$" + rowISTPolja.POLJE.ToString
                    Exit For
                End Try
            Next
        Next
        ''''
        'ISTTABS
        For Each rowISTTabs As DatasetIstrazivanja.ISTTABSRow In dsdsISTPX.ISTTABS.Rows
            Try
                If rowISTTabs.Vod <= vt AndAlso vt <= rowISTTabs.Vdo AndAlso rowISTTabs.SIFIST.Trim.ToUpper = Me.PXMETAApp.Trim.ToUpper Then
                    dsISTPX_lokalni.ISTTABS.Rows.Add(rowISTTabs.ItemArray)
                End If
            Catch
                filterFORPXMETADATA = "6$" + rowISTTabs.RbrTabele.ToString + "$" + rowISTTabs.Naziv.ToString
                Exit For
            End Try
        Next
        ''''''
        Me.tafil_vodPX.Clear()
        For Each red As DatasetIstrazivanja.ISTPOLJARow In dsISTPX_lokalni.ISTPOLJA.Rows
            Dim aaa As String = red.ISTTABELERowParent.IsDGNull.ToString.Trim
            If Not red.ISTTABELERowParent.IsDGNull _
            AndAlso Not red.IsKLJUCNull _
            AndAlso red.KLJUC.Trim = "P" _
            AndAlso Not red.IsVodNull _
            AndAlso Not red.IsVdoNull _
            AndAlso red.Vod <= vt AndAlso vt <= red.Vdo Then
                Me.tafil_vodPX.Rows.Add(red.ItemArray)
            End If
        Next
        dsISTPX_lokalni.AcceptChanges()
        Me.tafil_vodPX.AcceptChanges()
    End Function

    Public Class LCHk2
        Inherits FormTemplate
        Public g As New DatasetIstrazivanja.ISTLogDataTable
        Public c As String
        Public con2s As String
        Dim jezik As String
        Dim txtmode As String

        Public Sub New(ByVal s As String, ByVal jezik As String, ByVal txtmode As String)
            c = s
            Me.jezik = jezik
            Me.txtmode = txtmode
        End Sub

        Public Function tc(ByVal r As DatasetIstrazivanja.ISTRow, ByVal lc As String, ByRef cw As String) As Boolean
            Dim id As String = ""
            Dim p As String = ""
            Call ucitaj("Istrazivanja", "", id, p, "")
            cw = Uzmistr(r.ISTBAZERow, id, p)
            'proba konekcije
            Try
                Dim sql As String = "select getdate() as dd"
                Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sql, cw, Nothing)
                Me.con2s = cw
                Return True
            Catch ex As System.Exception
                ''msg 6
                Dim msgtxt6 As String = getMessageText(dtMessages, "6", Me.jezik)
                ''msg 7
                Dim msgtxt7 As String = getMessageText(dtMessages, "7", Me.jezik)
                ISTMessageBox.Show(msgtxt6, msgtxt7, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Function

        Public Function Uzmistr(ByVal r As DatasetIstrazivanja.ISTBAZERow,
            ByVal userID As String, ByVal password As String) As String
            Dim s As String = r.IzrazODBC.Trim
            If Not (r.IsIzrazOLENull OrElse r.IzrazOLE.Trim = "") Then s = r.IzrazOLE.Trim
            s = Replace(s, "provider=sqloledb.1;", "", 1, , CompareMethod.Text)

            If s.ToLower.IndexOf("password") >= 0 OrElse s.ToLower.IndexOf("pwd") >= 0 Then
            Else

                If txtmode.Trim.ToUpper = "Z" OrElse txtmode.Trim.ToUpper = "ZCAPI" Then
                    ' s = "Data Source=IMT2.statsrb.lan;Initial Catalog=" + InitialCatalog + ";Persist Security Info=True;User ID=AnkIST;Password=p0l1t1ka25;idinazmaja;"
                    Dim server As String = ""
                    Dim pravaBaza As String = ""
                    Dim p() As String = s.Split(CChar(";"))
                    For i As Integer = 0 To p.GetUpperBound(0)
                        If p(i).Trim.ToUpper.IndexOf("DATA SOURCE") = 0 Then
                            server = NZ(Replace(p(i), "data source", "", 1, , CompareMethod.Text)).Trim
                            server = server.Trim.Replace("=", "").Trim
                        End If
                        If p(i).Trim.ToUpper.IndexOf("INITIAL CATALOG") = 0 Then
                            pravaBaza = NZ(Replace(p(i), "initial catalog", "", 1, , CompareMethod.Text)).Trim
                            pravaBaza = pravaBaza.Trim.Replace("=", "").Trim
                        End If

                    Next
                    s = getConnectionString(server, pravaBaza, txtmode, "")
                Else
                    If userID <> "" AndAlso password <> "" Then
                        s = s + ";User ID=" + userID + ";Password=" + password + ";"
                    Else
                        'windows auth
                        If txtmode.Trim.ToUpper <> "CLOUD" Then
                            s = s + ";Integrated Security=SSPI;Persist Security Info=False"
                        End If

                        s = s.Replace(";;", ";")
                    End If
                End If
            End If

            Uzmistr = s
        End Function

        Public Sub ucitaj(ByVal cs2 As String, ByRef cst As String, ByRef u As String, ByRef p As String, ByRef r As String)
            cst = ""
            u = ""
            p = ""
            r = ""
            Dim nv As System.Collections.Specialized.NameValueCollection
            nv = CType(ConfigurationManager.GetSection(cs2), System.Collections.Specialized.NameValueCollection)

            Dim k As String
            For Each k In nv.Keys
                Dim b As Boolean = False
                Dim v As String = nv.Item(k)
                If k = "User ID" Then
                    u = v
                    b = True
                ElseIf k = "Password" Then
                    p = v
                    b = True
                End If
                If Not b Then
                    cst += k + "=" + v + ";"
                End If
            Next
        End Sub
    End Class

    Public Function ButtonLogin_Click(
    ByRef dataSetIST As DatasetIstrazivanja,
    ByRef connectionString As String,
    ByRef rowIST As DatasetIstrazivanja.ISTRow,
    ByRef tabelaAdresar As DatasetIstrazivanja.ISTPOLJADataTable,
    ByRef dataSetISTPX As DatasetIstrazivanja) As Boolean

        dataSetIST = Nothing
        connectionString = ""
        rowIST = Nothing
        tabelaAdresar = Nothing
        dataSetISTPX = Nothing

        'If Me.brd Then
        Me.forma.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim niz As String = MyUpdateDatasetFilteredByVodVdo()
            Dim ii() As String = Microsoft.VisualBasic.Split(niz, "$")
                Dim i As String = ii(0)
            Dim poruka As String = ""
            ''msg 260
            Dim msgtxt260 As String = getMessageText(dtMessages, "260", Me.jezik)
            ''msg 267
            Dim msgtxt267 As String = getMessageText(dtMessages, "267", Me.jezik)
            Select Case i
                    'mora prvo ISTBaza, inače ne radi
                Case "1"
                    poruka = msgtxt260
                    ''msg 261
                    Dim msgtxt261 As String = getMessageText(dtMessages, "261", Me.jezik)
                    poruka = poruka + nvrd + msgtxt261 + nvrd
                Case "2"
                    poruka = msgtxt260
                    ''msg262
                    Dim msgtxt262 As String = getMessageText(dtMessages, "262", Me.jezik)
                    poruka = poruka + nvrd + msgtxt262 + nvrd
                Case "3"
                    poruka = msgtxt260
                    ''msg 263
                    Dim msgtxt263 As String = getMessageText(dtMessages, "263", Me.jezik)
                    poruka = poruka + nvrd + msgtxt263 + nvrd

                    poruka = poruka + nvrd + msgtxt267 + nvrd + ii(1)
                Case "4"
                    poruka = msgtxt260
                    ''msg 264
                    Dim msgtxt264 As String = getMessageText(dtMessages, "264", Me.jezik)
                    poruka = poruka + nvrd + msgtxt264 + nvrd
                    ''msg 268
                    Dim msgtxt268 As String = getMessageText(dtMessages, "268", Me.jezik)
                    poruka = poruka + nvrd + msgtxt267 + nvrd + ii(1) + nvrd + msgtxt268 + nvrd + ii(2) + nvrd
                Case "5"
                    poruka = msgtxt260
                    ''msg 265
                    Dim msgtxt265 As String = getMessageText(dtMessages, "265", Me.jezik)
                    poruka = poruka + nvrd + msgtxt265 + nvrd
                    ''msg 271
                    Dim msgtxt271 As String = getMessageText(dtMessages, "271", Me.jezik)
                    poruka = poruka + nvrd + msgtxt267 + nvrd + ii(1) + nvrd + msgtxt271 + nvrd + ii(2) + nvrd
                Case "6"
                    poruka = msgtxt260
                    ''msg 266
                    Dim msgtxt266 As String = getMessageText(dtMessages, "266", Me.jezik)
                    poruka = poruka + nvrd + msgtxt266 + nvrd
                    ''msg 269
                    Dim msgtxt269 As String = getMessageText(dtMessages, "269", Me.jezik)
                    ''msg 270
                    Dim msgtxt270 As String = getMessageText(dtMessages, "270", Me.jezik)
                    poruka = poruka + nvrd + msgtxt269 + nvrd + ii(1) + nvrd + msgtxt270 + nvrd + ii(2) + nvrd
                Case Else
            End Select
            If i > "0" Then
                ISTMessageBox.Show(poruka, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Me.forma.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        Me.brd = False
        Me.blo = True
        'End If
        If Me.blo Then
            Me.forma.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim connStr As String = ""
            Dim b As Boolean = False
            Try
                b = Me.lchk.tc(Me.redIST, Me.redIST.Naziv.Trim, connStr)
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message)
            End Try

            Me.forma.Cursor = System.Windows.Forms.Cursors.Default
            If b Then
                Me.con2 = connStr
                Me.blo = False
            Else
                Return False
            End If
        End If
        dataSetIST = dsIST_lokalni
        connectionString = Me.con2
        rowIST = Me.redIST
        tabelaAdresar = Me.tafil_vod
        If txtmode <> "CAPI" AndAlso txtmode <> "TESTCAPI" AndAlso txtmode <> "CAPITEST" Then
            Me.dreg.SetValue("godina", Me.ucvt.G.ToString)
            Me.dreg.SetValue("mesec", Me.ucvt.M.ToString)
            Me.dreg.Flush()
        End If

        If Not dataSetISTPX Is Nothing Then
            Dim nizPX As String = filterFORPXMETADATA()
            dataSetISTPX = dsISTPX_lokalni
        End If
        Return True
    End Function

    Public Sub ButtonIzlaz_Click()
        Me.forma.Hide()
    End Sub

    Public Sub ucvt_ValueChanged() Handles ucvt.ValueChanged
        Me.brd = True
    End Sub

    Private Sub InitializeComponent()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IstrazivanjeVremenskaTacka
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(336, 217)
        Me.Name = "IstrazivanjeVremenskaTacka"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class
