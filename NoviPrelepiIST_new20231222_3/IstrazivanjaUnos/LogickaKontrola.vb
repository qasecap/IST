Option Strict Off

Public Class LogickaKontrola
    Inherits FormTemplate
    Public DBConnectionString As String
    Public mrb As DatasetIstrazivanja.ISTBAZERow
    Public mtt As DatasetIstrazivanja.ISTTABELEDataTable
    Public mtp As DatasetIstrazivanja.ISTPOLJADataTable
    Public mta As DatasetIstrazivanja.ISTPOLJADataTable
    Public mtip As DatasetIstrazivanja.ISTLKDataTable
    Public mvlk As System.Data.DataView
    Public mrn As String
    Public mrj As String
    Public mprog As System.Windows.Forms.ProgressBar
    Public mtbSql As System.Windows.Forms.TextBox
    Public mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim VBCRLF As String = System.Environment.NewLine


    Public Sub Export2Excel(ByVal d As Object, ByVal a As Object, ByVal w As Object, Optional ByVal cuvaj As Boolean = False, Optional ByVal fajl As String = "")
        Dim e As Object
        Dim DS As System.Data.DataSet = w.Table.DataSet
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)

        e = Microsoft.VisualBasic.Interaction.CreateObject("Excel.Application")

        Dim s, b, t As Object
        b = e.Workbooks.Add
        Dim ww As Object

        Dim dt As System.Data.DataTable = DS.Tables(a)

        t = d.TableStyles(CStr(a)).GridColumnStyles()
        ww = b.Worksheets.Item(1)
        Dim row, col As Integer
        col = 1
        row = 1
        Dim matrica(dt.Rows.Count, -1) As Object

        For Each s In t
            ReDim Preserve matrica(dt.Rows.Count, 1 + matrica.GetUpperBound(1))
            matrica(0, col - 1) = s.MappingName
            col = col + 1
        Next

        If col > 255 Or dt.Rows.Count > 65535 Then
            ''msg 152
            Dim msgtxt152 As String = getMessageText(dtMessages, "152", Me.jezik) + nvrd
            ''msg 153
            Dim msgtxt153 As String = getMessageText(dtMessages, "153", Me.jezik) + nvrd
            ''msg 154
            Dim msgtxt154 As String = getMessageText(dtMessages, "154", Me.jezik) + nvrd
            ''msg 155
            Dim msgtxt155 As String = getMessageText(dtMessages, "155", Me.jezik) + nvrd
            If ISTMessageBox.Show(msgtxt152 & CStr(col) & msgtxt153 & CStr(dt.Rows.Count) & msgtxt154, msgtxt155, MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> System.Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
        End If

        Dim tipKolone As String
        For kolona As Integer = 0 To col - 2
            tipKolone = dt.Columns(kolona).DataType.FullName()
            If tipKolone.Trim = "System.String" Then
                For red As Integer = 0 To dt.Rows.Count - 1
                    Dim pomtrt As String = ""
                    If dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper).ToString.Trim.Length > 900 Then
                        pomtrt = dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper).ToString.Trim.Substring(0, 899)
                    Else
                        pomtrt = dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper).ToString.Trim
                    End If
                    matrica(red + 1, kolona) = "'" + pomtrt
                Next
            Else
                For red As Integer = 0 To dt.Rows.Count - 1
                    matrica(red + 1, kolona) = dt.Rows(red).Item(matrica(0, kolona).Trim.ToUpper)
                Next
            End If
        Next

        If cuvaj = False Then e.visible = True
        ww.Range("A1").Resize(matrica.GetUpperBound(0) + 1, matrica.GetUpperBound(1) + 1).value = matrica

        If cuvaj = True Then
            Dim fi As New System.IO.FileInfo(fajl)
            If Not System.IO.Directory.Exists(fi.DirectoryName) Then
                System.IO.Directory.CreateDirectory(fi.DirectoryName)
            End If
            ww.SaveAs(fajl)

            If Not ww Is Nothing Then
                Try
                    ww.Close(False)
                Catch
                End Try
            End If
            e.Quit()
        End If

        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

    End Sub

    Public Shared Function IzrazLKTabele(ByVal OrigBAZERow As DatasetIstrazivanja.ISTBAZERow, ByVal VanBAZERow As DatasetIstrazivanja.ISTBAZERow, ByVal imetabele As String) As String
        Return RedTabele.tabelaSQL(OrigBAZERow, VanBAZERow, imetabele)
    End Function

    Public Shared Function ImeLKTabeleIzIzraza(ByVal VanBAZERow As DatasetIstrazivanja.ISTBAZERow, ByVal imetabele As String) As String
        Return RedTabele.prepare_ime(VanBAZERow, imetabele)
    End Function

    Public Shared Function cs_U_OLE(ByVal VanBAZERow As DatasetIstrazivanja.ISTBAZERow, ByVal u As String, ByVal p As String) As String
        Return RedTabele.Strc(RedTabele.enumLK2.e2, VanBAZERow, u, p)
    End Function

    Dim jezik As String
    Dim sifist As String = ""
    Dim txtmode As String = ""
    Public Sub New(ByVal DBConnectionString As String, ByVal rb As DatasetIstrazivanja.ISTBAZERow,
    ByVal tt As DatasetIstrazivanja.ISTTABELEDataTable,
    ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable, ByVal ta As DatasetIstrazivanja.ISTPOLJADataTable,
    ByVal tlk As DatasetIstrazivanja.ISTLKDataTable, ByVal pb As System.Windows.Forms.ProgressBar,
    ByVal tb As System.Windows.Forms.TextBox, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal jezik As String)

        Me.sifist = tt.Rows(0).Item("sifist").ToString.Trim.ToUpper
        Me.DBConnectionString = DBConnectionString
        Me.mrb = rb
        Me.mrn = "0"
        Me.mrj = "1"

        Me.mtbSql = tb
        Me.mtp = tp
        Me.mtt = tt
        Me.mta = ta
        Me.mtip = tlk
        Me.mvlk = New System.Data.DataView(Me.mtip, "", Me.mtip.TABELAColumn.ColumnName, System.Data.DataViewRowState.CurrentRows)

        Me.mprog = pb
        Me.mvt = vt
        Me.jezik = jezik
        Me.txtmode = txtmode

    End Sub

    Public Sub LK(ByVal sTab As String, ByVal posebnatabela As String, Optional ByVal GreskaPoGreska As Boolean = False)
        posebnatabela = posebnatabela.Trim

        Dim ppp As String = CStr(posebnatabela)
        If ppp.IndexOf("DBO.") = 0 Then
            Dim pp() As String = ppp.Split(".")
            posebnatabela = pp(0)
            If pp.Length > 0 Then posebnatabela = pp(1)
        End If

        If Not Me.mprog Is Nothing Then
            Me.mprog.Visible = True
            Me.mprog.Value = Me.mprog.Minimum
            Me.mprog.Maximum = Me.mtip.Rows.Count
            Me.mprog.Step = Me.mprog.Maximum \ 20
            If Me.mprog.Step = 0 Then Me.mprog.Step = 1
        End If

        Try
            Dim prevedi As New RedTabele(Me.mrb, Me.mtt, Me.mtp, Me.mta, Me.mvt, Me.DBConnectionString, Me.jezik)

            Dim brojac As Integer
            If GreskaPoGreska Then
                'radi grešku po grešku
                Me.Uslov1(Me.mtp, prevedi, brojac, sTab, posebnatabela)
                'uradi update INDGR
                Me.uslov3(sTab, posebnatabela)
            Else
                Me.Uslov1(Me.mtp, prevedi, brojac, sTab, posebnatabela)
                'uradi update set G001=1, G002=1 itd, tj veliki sql
                Me.uslov2(prevedi, brojac, sTab, posebnatabela)
                'uradi update INDGR
                Me.uslov3(sTab, posebnatabela)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not Me.mprog Is Nothing Then Me.mprog.Visible = False
        End Try
    End Sub

    Public Sub LKISTLK(ByVal sTab As String, ByVal posebnatabela As String, Optional ByVal GreskaPoGreska As Boolean = False)
        posebnatabela = posebnatabela.Trim
        If Not Me.mprog Is Nothing Then
            Me.mprog.Visible = True
            Me.mprog.Value = Me.mprog.Minimum
            Me.mprog.Maximum = Me.mtip.Rows.Count
            Me.mprog.Step = Me.mprog.Maximum \ 20
            If Me.mprog.Step = 0 Then Me.mprog.Step = 1
        End If

        Try
            Dim prevedi As New RedTabele(Me.mrb, Me.mtt, Me.mtp, Me.mta, Me.mvt, Me.DBConnectionString, Me.jezik)

            Dim brojac As Integer
            If GreskaPoGreska Then
                'radi grešku po grešku
                Me.Uslov1ISTLK(Me.mtp, prevedi, brojac, sTab, posebnatabela)
                'uradi update INDGR
                Me.uslov3ISTLK(sTab, posebnatabela)
            Else
                Me.Uslov1ISTLK(Me.mtp, prevedi, brojac, sTab, posebnatabela)
                'uradi update set G001=1, G002=1 itd, tj veliki sql
                Me.uslov2ISTLK(prevedi, brojac, sTab, posebnatabela)
                'uradi update INDGR
                Me.uslov3ISTLK(sTab, posebnatabela)
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If Not Me.mprog Is Nothing Then Me.mprog.Visible = False
        End Try
    End Sub

    Private Sub Uslov1ISTLK(ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable,
                       ByVal pr As RedTabele, ByRef brojac2 As Integer, ByVal sTab As String, ByVal posebnatabela As String,
                       Optional ByVal GreskaPoGreska As Boolean = False)
        'Const e As RedTabele.enumLK = RedTabele.enumLK.e1
        Dim r As DatasetIstrazivanja.ISTLKRow
        For Each r In Me.mtip.Rows
            If (posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.TABELA.Trim.ToUpper) Then
                If Not (r.Item("USLOV").GetType Is GetType(System.DBNull)) AndAlso r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYONADDEDBUTTONCONTROL") >= 0 Then
                    Dim n As String = prfxt(r.TABELA)
                    Dim sql As String
                    sql = "set nocount off;update " & n & VBCRLF +
                        " set " & r.RbrGreske + "=" & Me.mrn & VBCRLF +
                        " where (" + r.RbrGreske + "<>" & Me.mrn + " or " + r.RbrGreske + " is null)"

                    If sTab <> "" Then sql = sql + " and " + sTab
                    Dim v As String = Me.mvt.vWhere(n, "", Me.DBConnectionString)
                    If v <> "" Then sql = sql + " and " + v


                    Dim brPom As Integer = izvrsiSQLVratiBrojSlogova(sql, Me.DBConnectionString)
                    brojac2 = brojac2 + brPom

                    If brPom < 0 Then
                        Me.mtbSql.Visible = True
                        ''msg 156
                        Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                        Me.mtbSql.Text = msgtxt + VBCRLF + r.RbrGreske.Trim + " : " + r.GRESKA.Trim & VBCRLF & VBCRLF & sql
                    End If

                    'bilo prefikstabele(Me.mrb, r.TABELA)
                    sql = "update " & prfxt(r.TABELA) & VBCRLF +
                        " set " & r.RbrGreske + "=" & Me.mrj & VBCRLF +
                        " where ( " + pr.Uslov2R(r, "", r.GRESKA) + " ) " + VBCRLF +
                                            " and (" + r.RbrGreske + "<>" & Me.mrj + " or " + r.RbrGreske + " is null)"

                    If sTab <> "" Then sql = sql + " and " + sTab
                    If v <> "" Then sql = sql + " and " + v

                    Dim odg As String = izvrsiSQL(sql, Me.DBConnectionString)
                    If odg = "nok" Then
                        Me.mtbSql.Visible = True
                        ''msg 156
                        Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                        Me.mtbSql.Text = msgtxt + VBCRLF + r.RbrGreske.Trim + " : " + r.GRESKA.Trim + VBCRLF + VBCRLF + sql
                    End If

                    If Not Me.mprog Is Nothing Then
                        With Me.mprog
                            .Value = .Value + 1
                            .Refresh()
                        End With
                    End If
                End If 'NIJE LKUNOS
            End If 'IF GreskaPoGreska.....
        Next
    End Sub


    Private Sub Uslov1(ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable,
                       ByVal pr As RedTabele, ByRef brojac2 As Integer, ByVal sTab As String, ByVal posebnatabela As String,
                       Optional ByVal GreskaPoGreska As Boolean = False)

        Dim r As DatasetIstrazivanja.ISTLKRow
        For Each r In Me.mtip.Rows
            If (posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.TABELA.Trim.ToUpper) Then
                If r.Item("USLOV").GetType Is GetType(System.DBNull) OrElse r.Item("USLOV").Trim = "" OrElse r.Item("USLOV").Trim.ToUpper.indexof("LKVELIKA") >= 0 OrElse r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                    Dim n As String = prfxt(r.TABELA)
                    Dim sql As String
                    sql = "set nocount off;update " & n & VBCRLF +
                        " set " & r.RbrGreske + "=" & Me.mrn & VBCRLF +
                        " where (" + r.RbrGreske + "<>" & Me.mrn + " or " + r.RbrGreske + " is null)"

                    If sTab <> "" Then sql = sql + " and " + sTab
                    Dim v As String = Me.mvt.vWhere(n, "", Me.DBConnectionString)
                    If v <> "" Then sql = sql + " and " + v

                    Dim brPom As Integer = izvrsiSQLVratiBrojSlogova(sql, Me.DBConnectionString)
                    brojac2 = brojac2 + brPom

                    If brPom < 0 Then
                        Me.mtbSql.Visible = True
                        ''msg 156
                        Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                        Me.mtbSql.Text = msgtxt + VBCRLF + r.RbrGreske.Trim + " : " + r.GRESKA.Trim & VBCRLF & VBCRLF & sql
                    End If

                    'bilo  prefikstabele(Me.mrb, r.TABELA)
                    sql = "update " & prfxt(r.TABELA) & VBCRLF +
                        " set " & r.RbrGreske + "=" & Me.mrj & VBCRLF +
                        " where ( " + pr.Uslov2R(r, "", r.GRESKA) + " ) " + VBCRLF +
                                            " and (" + r.RbrGreske + "<>" & Me.mrj + " or " + r.RbrGreske + " is null)"

                    If sTab <> "" Then sql = sql + " and " + sTab
                    If v <> "" Then sql = sql + " and " + v

                    Dim odg As String = izvrsiSQL(sql, Me.DBConnectionString)
                    If odg = "nok" Then                        '
                        Me.mtbSql.Visible = True
                        ''msg 156
                        Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                        Me.mtbSql.Text = msgtxt + VBCRLF + r.RbrGreske.Trim + " : " + r.GRESKA.Trim + VBCRLF + VBCRLF + sql
                    End If

                    If Not Me.mprog Is Nothing Then
                        With Me.mprog
                            .Value = .Value + 1
                            .Refresh()
                        End With
                    End If
                End If 'NIJE LKUNOS
            End If 'IF GreskaPoGreska.....
        Next
    End Sub

    Public Sub LKIzabrane(ByVal mdtt As DatasetIstrazivanja.ISTLKDataTable, ByVal sTab As String, ByVal posebnatabela As String, Optional ByVal GreskaPoGreska As Boolean = False)
        posebnatabela = posebnatabela.Trim
        If Not Me.mprog Is Nothing Then
            Me.mprog.Visible = True
            Me.mprog.Value = Me.mprog.Minimum
            Me.mprog.Maximum = Me.mtip.Rows.Count
            Me.mprog.Step = Me.mprog.Maximum \ 20
            If Me.mprog.Step = 0 Then Me.mprog.Step = 1
        End If

        Try
            Dim prevedi As New RedTabele(Me.mrb, Me.mtt, Me.mtp, Me.mta, Me.mvt, Me.DBConnectionString, Me.jezik)

            Dim brojac As Integer
            If GreskaPoGreska Then
                'radi grešku po grešku
                Me.Uslov11(mdtt, Me.mtp, prevedi, brojac, sTab, posebnatabela, GreskaPoGreska)
                'uradi update INDGR
                Me.uslov3(sTab, posebnatabela)
            End If
        Finally
            If Not Me.mprog Is Nothing Then
                Me.mprog.Visible = False
            End If
        End Try

    End Sub

    Private Sub Uslov11(ByVal mdtt As DatasetIstrazivanja.ISTLKDataTable, ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable,
     ByVal pr As RedTabele, ByRef brojac2 As Integer, ByVal sTab As String,
     ByVal posebnatabela As String, Optional ByVal GreskaPoGreska As Boolean = False)
        'Const e As RedTabele.enumLK = RedTabele.enumLK.e1
        Dim r As DatasetIstrazivanja.ISTLKRow
        For Each r In mdtt.Rows
            'If GreskaPoGreska OrElse (pr.GetEnumLK(r.Item("GRESKA")) = e AndAlso (posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.Item("TABELA").Trim.ToUpper)) Then
            If (posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.Item("TABELA").Trim.ToUpper) Then
                If r.Item("USLOV").GetType Is GetType(System.DBNull) OrElse r.Item("USLOV").Trim = "" OrElse r.Item("USLOV").Trim.ToUpper.indexof("LKVELIKA") >= 0 OrElse r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                    Dim n As String = prfxt(r.Item("TABELA"))
                    Dim sql As String
                    sql = "set nocount off;update " & n & VBCRLF +
                            " set " & r.Item("RbrGreske") + "=" & Me.mrn & VBCRLF +
                            " where (" + r.Item("RbrGreske") + "<>" & Me.mrn + " or " + r.Item("RbrGreske") + " is null)"
                    If sTab <> "" Then sql = sql + " and " + sTab
                    Dim v As String = Me.mvt.vWhere(n, "", Me.DBConnectionString)
                    If v <> "" Then sql = sql + " and " + v

                    Dim brPom As Integer = izvrsiSQLVratiBrojSlogova(sql, Me.DBConnectionString)
                    brojac2 = brojac2 + brPom

                    If brPom < 0 Then
                        Me.mtbSql.Visible = True
                        ''msg 156
                        Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                        Me.mtbSql.Text = msgtxt + VBCRLF + r.RbrGreske.Trim + " : " + r.GRESKA.Trim & VBCRLF & VBCRLF & sql
                    End If

                    sql = " update " & prfxt(r.Item("TABELA")) & VBCRLF +
                              " set " & r.Item("RbrGreske") + "=" & Me.mrj & VBCRLF +
                              " where ( " + pr.Uslov2R(r, "", r.Item("GRESKA")) + " ) " + VBCRLF +
                              " and (" + r.Item("RbrGreske") + "<>" & Me.mrj + " or " + r.Item("RbrGreske") + " is null)"

                    If sTab <> "" Then sql = sql + " and " + sTab
                    If v <> "" Then sql = sql + " and " + v

                    Dim odg As String = izvrsiSQL(sql, Me.DBConnectionString)
                    If odg = "nok" Then
                        Me.mtbSql.Visible = True
                        ''msg 156
                        Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                        Me.mtbSql.Text = msgtxt + VBCRLF + r.RbrGreske.Trim + " : " + r.GRESKA.Trim + VBCRLF + VBCRLF + sql
                    End If

                    If Not Me.mprog Is Nothing Then
                        With Me.mprog
                            .Value = .Value + 1
                            .Refresh()
                        End With
                    End If
                End If 'NIJE LKUNOS
            End If 'IF GreskaPoGreska
        Next

    End Sub

    Public Sub LKFilter(ByVal sTab As String, ByVal tabela As String, ByVal polje As String, ByVal vrednost As String)

        If Not Me.mprog Is Nothing Then
            Me.mprog.Visible = True
            Me.mprog.Value = Me.mprog.Minimum
            Me.mprog.Maximum = Me.mtip.Rows.Count
            Me.mprog.Step = Me.mprog.Maximum \ 20
            If Me.mprog.Step = 0 Then Me.mprog.Step = 1
        End If

        Try
            Dim prevedi As New RedTabele(Me.mrb, Me.mtt, Me.mtp, Me.mta, Me.mvt, Me.DBConnectionString, Me.jezik)

            'radi grešku po grešku
            Me.UslovFilter(Me.mtp, prevedi, sTab, tabela, polje, vrednost)
            ''uradi update INDGR
            Me.uslov3(sTab, "")
        Catch ex As Exception
            ISTMessageBox.Show(ex.Message)
        Finally
            If Not Me.mprog Is Nothing Then
                Me.mprog.Visible = False
            End If
        End Try
    End Sub

    Private Sub UslovFilter(ByVal tp As DatasetIstrazivanja.ISTPOLJADataTable,
    ByVal pr As RedTabele, ByVal sTab As String, ByVal tabela As String, ByVal polje As String, ByVal vrednost As String)

        Dim r As DatasetIstrazivanja.ISTLKRow

        For Each r In Me.mtip.Rows  'redovi iz LK cele
            If (tabela.Trim.ToUpper = r.TABELA.Trim.ToUpper) Then
                If r.Item("USLOV").GetType Is GetType(System.DBNull) OrElse r.Item("USLOV").Trim = "" OrElse r.Item("USLOV").Trim.ToUpper.indexof("LKVELIKA") >= 0 OrElse r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                    Dim vA As String = Me.mvt.vWhere(tabela, "", Me.DBConnectionString)
                    If vA <> "" Then vA = vA + " AND "

                    Dim vv As String = ""

                    If IsNumeric(vrednost) Then
                        vv = "'" + vrednost + "'"
                    Else
                        vv = "N'" + vrednost + "'"
                    End If

                    Dim sql As String = "set nocount off;update " + prfxt(r.TABELA) + VBCRLF +
                        " set " + r.RbrGreske + "=" + Me.mrj + VBCRLF +
                        " where  " + vA + pr.prevediFP(r.TABELA, polje) + "=" + vv + " and ( " + pr.Uslov2R(r, "", r.GRESKA) + " ) " + VBCRLF +
                        " and (" + r.RbrGreske + "<>" & Me.mrj + " Or " + r.RbrGreske + " Is null)"
                    Try
                        Dim ok1 As String = izvrsiSQL(sql, Me.DBConnectionString)
                        If ok1 <> "ok" Then
                            ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER49", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message + VBCRLF + r.RbrGreske.Trim + " : " + r.GRESKA.Trim, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.mtbSql.Visible = True
                        ''msg 156
                        Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                        Me.mtbSql.Text = msgtxt & VBCRLF & sql
                    End Try

                    If Not Me.mprog Is Nothing Then
                        With Me.mprog
                            .Value = .Value + 1
                            .Refresh()
                        End With
                    End If
                End If 'NIJE LKUNOS
            End If
        Next
    End Sub

    Private Class uslovLK
        Public m_rowBaze As DatasetIstrazivanja.ISTBAZERow
        Public mrn As String
        Public mrj As String
        Public m_sTab As String
        Public mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
        Public DBConnectionString As String
        Public rbr As String
        Public VBCRLF As String = System.Environment.NewLine

        Public Sub New(ByVal r As DatasetIstrazivanja.ISTBAZERow, ByVal rn As String, ByVal rj As String, ByVal sTab As String,
                       ByVal v As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal DBConnectionString As String)
            Me.m_rowBaze = r
            Me.mrn = rn
            Me.mrj = rj
            Me.m_sTab = sTab
            Me.mvt = v
            Me.DBConnectionString = DBConnectionString
        End Sub

        Public Sub Izmeni(ByVal r As DatasetIstrazivanja.ISTLKRow, ByVal p As RedTabele)
            If Me.rbr <> "" Then Me.rbr = Me.rbr + "," + VBCRLF
            Dim sr As String
            sr = r.RbrGreske + "="
            sr = sr + "(case when(" & p.Uslov2R(r, "", r.GRESKA) & ") then " & Me.mrj &
                    " else " & Me.mrn & " end)"
            Me.rbr = Me.rbr + sr
        End Sub

        Public Function pref2(
        ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow,
        ByVal tableName As String) As String
            If Not rowBaze.IsprefixNull _
            AndAlso rowBaze.prefix.Trim <> "" Then
                Dim prefix As String = rowBaze.prefix.Trim
                prefix = zagr(prefix)
                Return prefix + "." + tableName
            End If
            Return tableName
        End Function

        Public Function zagr(ByVal name As String) As String
            name = name.Trim
            If name.Chars(0) <> "["c Then
                Return "[" + name + "]"
            End If
            Return name
        End Function

        Public Function GetStringTab(ByVal nazivTabele As String) As String
            Dim n As String = pref2(Me.m_rowBaze, nazivTabele)
            Dim sql As String
            sql = "update " & n + VBCRLF + " set " & Me.rbr
            sql = sql + " where 1=1"
            If Me.m_sTab <> "" Then sql = sql + " and " + Me.m_sTab
            Dim v As String = Me.mvt.vWhere(n, "", Me.DBConnectionString)
            If v <> "" Then sql = sql + " and " + v
            Return sql
        End Function

        Public Sub Reset()
            Me.rbr = ""
        End Sub

    End Class

    Private Class Azuriraj2
        Dim VBCRLF As String = System.Environment.NewLine
        Public m_rowBaze As DatasetIstrazivanja.ISTBAZERow
        Public mrn As String
        Public mrj As String
        Public m_sTab As String
        Public DBConnectionString As String
        Public mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
        Public mset_gr As String

        Public Sub New(ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow, ByVal n As String, ByVal j As String, ByVal sTab As String,
                       ByVal v As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal DBConnectionString As String)
            Me.m_rowBaze = rowBaze
            Me.mrn = n
            Me.mrj = j
            Me.m_sTab = sTab
            Me.mvt = v
            Me.DBConnectionString = DBConnectionString
        End Sub

        Public Sub OrColumn(ByVal r As DatasetIstrazivanja.ISTLKRow)
            If Me.mset_gr <> "" Then Me.mset_gr = Me.mset_gr + " or "
            Dim sINDGR As String = r.RbrGreske & " = " & Me.mrj
            Me.mset_gr = Me.mset_gr + sINDGR
        End Sub

        Public Function prefiks(
        ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow,
        ByVal tableName As String) As String
            If Not rowBaze.IsprefixNull _
            AndAlso rowBaze.prefix.Trim <> "" Then
                Dim prefix As String = rowBaze.prefix.Trim
                prefix = zagrada(prefix)
                Return prefix + "." + tableName
            End If
            Return tableName
        End Function

        Public Function zagrada(ByVal name As String) As String
            name = name.Trim
            If name.Chars(0) <> "["c Then
                Return "[" + name + "]"
            End If
            Return name
        End Function

        Public Function StringAppend(ByVal n As String) As String
            'Dim n2 As String = prefiks(Me.m_rowBaze, n)
            'Dim n2 As String = prfxt(n)
            Dim pp() As String : Dim prefixx As String = "dbo" : Dim tabbb As String = n
            If n.IndexOf(".") > 0 Then
                pp = n.Split(CType(".", Char()))
                prefixx = pp(0)
                tabbb = pp(1)
            End If
            Dim n2 As String = prefixx + "." + tabbb
            Dim sql As String = "update " & n2 + VBCRLF +
                " set INDGR=(case when (" & Me.mset_gr & ") then " & Me.mrj + VBCRLF +
                            " else " & Me.mrn & VBCRLF +
                            " end)" + VBCRLF
            sql = sql + " where 1=1"
            If Me.m_sTab <> "" Then sql = sql + " and " + Me.m_sTab

            Dim w As String = Me.mvt.vWhere(n2, "", Me.DBConnectionString)
            If w <> "" Then sql = sql + " and " + w

            Return sql
        End Function

        Public Sub Reset()
            Me.mset_gr = ""
        End Sub

    End Class

    Private Sub uslov3(ByVal sTab As String, ByVal posebnatabela As String)
        Dim b As Boolean = False
        Dim updateINDGR As New Azuriraj2(Me.mrb, Me.mrn, Me.mrj, sTab, Me.mvt, Me.DBConnectionString)
        Dim pt As String = ""
        Dim rv As System.Data.DataRowView
        For Each rv In Me.mvlk
            Dim r As DatasetIstrazivanja.ISTLKRow
            r = CType(rv.Row, DatasetIstrazivanja.ISTLKRow)
            If posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.TABELA.Trim.ToUpper Then
                If r.Item("USLOV").GetType Is GetType(System.DBNull) OrElse r.Item("USLOV").Trim = "" OrElse r.Item("USLOV").Trim.ToUpper.indexof("LKVELIKA") >= 0 OrElse r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                    b = True
                    pt = pt.Trim.ToUpper
                    If pt <> r.TABELA.Trim.ToUpper AndAlso pt <> "" Then
                        Dim ssql As String = updateINDGR.StringAppend(pt)
                        Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
                        If ok1 <> "ok" Then
                            ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER50", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        updateINDGR.Reset()
                    End If
                    updateINDGR.OrColumn(r)
                    pt = r.TABELA.Trim.ToUpper
                End If
            End If
        Next
        If b Then
            Dim ssql As String = updateINDGR.StringAppend(pt.Trim.ToUpper)
            Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER51", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub uslov3ISTLK(ByVal sTab As String, ByVal posebnatabela As String)
        Dim b As Boolean = False
        Dim updateINDGR As New Azuriraj2(Me.mrb, Me.mrn, Me.mrj, sTab, Me.mvt, Me.DBConnectionString)
        Dim pt As String = ""
        Dim rv As System.Data.DataRowView
        For Each rv In Me.mvlk
            Dim r As DatasetIstrazivanja.ISTLKRow
            r = CType(rv.Row, DatasetIstrazivanja.ISTLKRow)
            If posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.TABELA.Trim.ToUpper Then
                If Not (r.Item("USLOV").GetType Is GetType(System.DBNull)) AndAlso r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYONADDEDBUTTONCONTROL") >= 0 Then
                    b = True
                    pt = pt.Trim.ToUpper
                    If pt <> r.TABELA.Trim.ToUpper AndAlso pt <> "" Then
                        Dim ssql As String = updateINDGR.StringAppend(pt)
                        Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
                        If ok1 <> "ok" Then
                            ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER52", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        updateINDGR.Reset()
                    End If
                    updateINDGR.OrColumn(r)
                    pt = r.TABELA.Trim.ToUpper
                End If
            End If
        Next
        If b Then
            Dim ssql As String = updateINDGR.StringAppend(pt.Trim.ToUpper)
            Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER53", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub uslov2(ByVal prevedi As RedTabele, ByRef rowsAff As Integer, ByVal sTab As String, ByVal posebnatabela As String)
        'Const e2 As RedTabele.enumLK = RedTabele.enumLK.e2
        Dim b As Boolean
        Dim ugr As New uslovLK(Me.mrb, Me.mrn, Me.mrj, sTab, Me.mvt, Me.DBConnectionString)
        Dim tab As String = ""
        Dim rv As System.Data.DataRowView
        For Each rv In Me.mvlk
            Dim r As DatasetIstrazivanja.ISTLKRow
            r = CType(rv.Row, DatasetIstrazivanja.ISTLKRow)
            If (posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.TABELA.Trim.ToUpper) Then
                If r.Item("USLOV").GetType Is GetType(System.DBNull) OrElse r.Item("USLOV").Trim = "" OrElse r.Item("USLOV").Trim.ToUpper.indexof("LKVELIKA") >= 0 OrElse r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                    b = True
                    If tab <> r.TABELA.Trim AndAlso tab <> "" Then
                        Dim ssql As String = ugr.GetStringTab(tab)
                        Try
                            Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
                            If ok1 <> "ok" Then
                                ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER54", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As System.Exception
                            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.mtbSql.Visible = True
                            ''msg 156
                            Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                            Me.mtbSql.Text = msgtxt & VBCRLF & ssql
                        End Try
                        ugr.Reset()
                    End If
                    ugr.Izmeni(r, prevedi)
                    tab = r.TABELA.Trim
                    If Not Me.mprog Is Nothing Then
                        With Me.mprog
                            If .Value < mprog.Maximum Then .Value = .Value + 1
                            .Refresh()
                        End With
                    End If
                End If 'NIJE LKUNOS

            End If
        Next
        If b Then
            Dim ssql As String = ugr.GetStringTab(tab)
            Try
                Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER55", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.mtbSql.Visible = True
                ''msg 156
                Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                Me.mtbSql.Text = msgtxt & VBCRLF & ssql
            End Try

        End If
    End Sub
    Private Sub uslov2ISTLK(ByVal prevedi As RedTabele, ByRef rowsAff As Integer, ByVal sTab As String, ByVal posebnatabela As String)
        'Const e2 As RedTabele.enumLK = RedTabele.enumLK.e2
        Dim b As Boolean
        Dim ugr As New uslovLK(Me.mrb, Me.mrn, Me.mrj, sTab, Me.mvt, Me.DBConnectionString)
        Dim tab As String = ""
        Dim rv As System.Data.DataRowView
        For Each rv In Me.mvlk
            Dim r As DatasetIstrazivanja.ISTLKRow
            r = CType(rv.Row, DatasetIstrazivanja.ISTLKRow)
            If (posebnatabela = "" OrElse posebnatabela.Trim.ToUpper = r.TABELA.Trim.ToUpper) Then
                If Not (r.Item("USLOV").GetType Is GetType(System.DBNull)) AndAlso r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYONADDEDBUTTONCONTROL") >= 0 Then
                    b = True
                    If tab <> r.TABELA.Trim AndAlso tab <> "" Then
                        Dim ssql As String = ugr.GetStringTab(tab)
                        Try
                            Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
                            If ok1 <> "ok" Then
                                ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER56", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        Catch ex As System.Exception
                            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.mtbSql.Visible = True
                            ''msg 156
                            Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                            Me.mtbSql.Text = msgtxt & VBCRLF & ssql
                        End Try
                        ugr.Reset()
                    End If
                    ugr.Izmeni(r, prevedi)
                    tab = r.TABELA.Trim
                    If Not Me.mprog Is Nothing Then
                        With Me.mprog
                            If .Value < mprog.Maximum Then .Value = .Value + 1
                            .Refresh()
                        End With
                    End If
                End If 'NIJE LKUNOS

            End If
        Next
        If b Then
            Dim ssql As String = ugr.GetStringTab(tab)
            Try
                Dim ok1 As String = izvrsiSQL(ssql, Me.DBConnectionString)
                If ok1 <> "ok" Then
                    ISTMessageBox.Show(ssql + nvrd + nvrd + "is not executed! ER57", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.mtbSql.Visible = True
                ''msg 156
                Dim msgtxt As String = getMessageText(dtMessages, "156", Me.jezik) + nvrd
                Me.mtbSql.Text = msgtxt & VBCRLF & ssql
            End Try

        End If
    End Sub
    Private Class RedTabele

        Inherits FormTemplate
        Public DBConnectionString As String
        Public mb As DatasetIstrazivanja.ISTBAZERow
        Public m_tabelaPolja As DatasetIstrazivanja.ISTPOLJADataTable
        Public m_tabele As DatasetIstrazivanja.ISTTABELEDataTable
        Public mta As DatasetIstrazivanja.ISTPOLJADataTable
        Public mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
        Dim VBCRLF As String = Microsoft.VisualBasic.vbCrLf

        Public Enum enumLK
            e1
            e2
        End Enum

        Public Function GetEnumLK(ByVal uslov As String) As enumLK
            uslov = uslov.ToUpper
            If uslov.IndexOf("#" + "{") >= 0 OrElse uslov.IndexOf("#" + "KONSULT") >= 0 OrElse uslov.IndexOf("#" + "UPARK") >= 0 Then
                Return enumLK.e1
            End If
            Return enumLK.e2
        End Function

        Public Function Uslov2R(ByVal r As DatasetIstrazivanja.ISTLKRow, ByVal nf As String, ByVal tf As String) As String

            tf = ZameniGGGMMM(tf, Me.mvt.G.ToString, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""), Me.sifist)

            Dim ind2 As Integer = tf.IndexOf("#")
            Dim ind3 As Integer = -1
            Dim x As String = ""
            While ind2 >= 0
                x = x + tf.Substring(ind3 + 1, ind2 - ind3 - 1)
                Dim z As Integer = tf.IndexOf("{", ind2 + 1)
                If z < 0 Then
                    ''msg 157
                    Dim msgtxt157 As String = getMessageText(dtMessages, "157", Me.jezik) + nvrd
                    ''msg 159
                    Dim msgtxt159 As String = getMessageText(dtMessages, "159", Me.jezik) + nvrd
                    Throw New System.Exception(msgtxt157 + r.TABELA + msgtxt159 + r.RbrGreske)
                End If
                ind3 = iTag(tf, z)
                If ind3 < 0 Then
                    ''msg 158
                    Dim msgtxt158 As String = getMessageText(dtMessages, "158", Me.jezik) + nvrd
                    ''msg 159
                    Dim msgtxt159 As String = getMessageText(dtMessages, "159", Me.jezik) + nvrd
                    Throw New System.Exception(msgtxt158 + r.TABELA + msgtxt159 + r.RbrGreske)
                End If
                Dim f2 As String = tf.Substring(ind2 + 1, z - ind2 - 1)
                Dim f3 As String = tf.Substring(z + 1, ind3 - z - 1)
                x = x + Me.Uslov2R(r, f2, f3)
                ind2 = tf.IndexOf("#", ind3 + 1)
            End While
            x = x + tf.Substring(ind3 + 1)
            If nf <> "" Then x = Me.LKfunc(r, nf, x)

            If x.ToUpper.IndexOf("GLAVA.") >= 0 OrElse x.ToUpper.IndexOf("HEAD.") >= 0 Then
                'svaku glavu promeni u odgovarajuci select
                Dim bbb() As String = razkvantaj(x.ToUpper)
                For ll As Integer = 0 To bbb.GetUpperBound(0)
                    If bbb(ll).ToUpper.Trim.IndexOf("GLAVA.") = 0 OrElse bbb(ll).ToUpper.Trim.IndexOf("HEAD.") = 0 Then
                        bbb(ll) = bbb(ll).Replace("GLAVA.", "")
                        bbb(ll) = bbb(ll).Replace("HEAD.", "")
                        bbb(ll) = " (" & USelektajGLAVU(bbb(ll), r.TABELA.Trim) & ") "
                    End If
                Next
                x = ustringaj(bbb).ToUpper
            End If

            Return x.Trim
        End Function

        Function prevediFP(ByVal tabela As String, ByVal p As String) As String

            If p.IndexOf(":") >= 0 Then p = p.Substring(0, p.IndexOf(":"))
            Dim r As DatasetIstrazivanja.ISTPOLJARow
            r = Me.m_tabelaPolja.FindBySIFISTTABELAPOLJE(Me.sifist, tabela, p.Trim)
            If r Is Nothing Then
                ''msg 160
                Dim msgtxt160 As String = getMessageText(dtMessages, "160", Me.jezik) + nvrd
                ''msg 161
                Dim msgtxt161 As String = getMessageText(dtMessages, "161", Me.jezik) + nvrd
                ''msg 162
                Dim msgtxt162 As String = getMessageText(dtMessages, "162", Me.jezik) + nvrd
                Throw New System.Exception(msgtxt160 + Me.sifist + nvrd + msgtxt161 + tabela + nvrd + msgtxt162 + p)
            End If
            Dim izr As String = ""
            If Not r.IsIzrazNull Then
                izr = r.Izraz.Trim.ToUpper
                'zamena GGGMMM
                Dim sql As String
                sql = izr
                sql = strrpl(sql, "{GGG}", "'" + Me.mvt.G.ToString + "'")
                sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", Me.mvt.M) + "'")
                sql = strrpl(sql, "{YYY}", "'" + Me.mvt.G.ToString + "'")
                sql = GGMMGoreDole(sql, Me.mvt.G, mvt.M)
                sql = strrpl(sql, "VRTACKA", Me.mvt.vtwhere(""))
                sql = strrpl(sql, "GGG", Me.mvt.GWhere(""))
                sql = strrpl(sql, "MMM", Me.mvt.mWhere(""))
                sql = strrpl(sql, "YYY", Me.mvt.YWhere(""))
                sql = sql.Replace(Microsoft.VisualBasic.ChrW(26), "")

                izr = sql

                izr = SrediIzrazZaFP(izr)

                If izr Is Nothing OrElse izr.Trim = "" Then
                    'nije FP
                    Return p
                    Exit Function
                End If

                '''''''''
                If izr.ToUpper.IndexOf("GLAVA.") >= 0 OrElse izr.ToUpper.IndexOf("HEAD.") >= 0 Then
                    'svaku glavu promeni u odgovarajuci select
                    Dim polje() As String = razkvantaj(izr)
                    For ll As Integer = 0 To polje.GetUpperBound(0)
                        If polje(ll).ToUpper.Trim.IndexOf("GLAVA.") = 0 OrElse polje(ll).ToUpper.Trim.IndexOf("HEAD.") = 0 Then
                            polje(ll) = polje(ll).Replace("GLAVA.", "")
                            polje(ll) = polje(ll).Replace("HEAD.", "")
                            polje(ll) = " (" & USelektajGLAVU(polje(ll), tabela.Trim) & ") "
                        End If
                    Next
                    izr = ustringaj(polje).ToUpper
                End If

                'ako je FP u stvari polje od nekog dupeta npr f025 je {POGL_02.p025}
                If izr.IndexOf("{") = 0 Then
                    izr = izr.Replace("{", "")
                    izr = izr.Replace("}", "")
                    izr = " (" & USelektajDUPE(izr, tabela.Trim) & ") "
                ElseIf izr.IndexOf("#FP{") >= 0 AndAlso izr.IndexOf("DBO.") < 0 Then  'fp unutar fp-a
                    Dim a1 As Integer = izr.IndexOf("#FP{")
                    Dim a2 As String = izr.Substring(a1 + 4, izr.Substring(a1).IndexOf("}") - 4)
                    izr = Me.prevediFP(tabela, a2)
                ElseIf izr.IndexOf("#FP{") >= 0 AndAlso izr.IndexOf("DBO.") > 0 Then  'fp unutar fp-a i jos u nekoj funkciji
                    Dim a1 As Integer = izr.IndexOf("#FP{")
                    Dim a2 As String = izr.Substring(a1 + 4, izr.Substring(a1).IndexOf("}") - 4)
                    Dim a3 As String = "#FP{" + a2.Trim.ToUpper + "}"
                    izr = izr.Replace(a3, Me.prevediFP(tabela, a2).Trim.ToUpper)
                    If izr.IndexOf(":") >= 0 Then izr = izr.Substring(0, izr.IndexOf(":"))
                    If izr.IndexOf("#") >= 0 Then izr = izr.Replace("#", "")
                    If izr.IndexOf("{") >= 0 Then izr = izr.Replace("{", "")
                    If izr.IndexOf("}") >= 0 Then izr = izr.Replace("}", "")
                    Dim dd As Boolean = False
                    While izr.IndexOf("D.") >= 0
                        dd = True
                        If izr.IndexOf("D.") = 0 Then
                            izr = tabela.Trim & "." & izr.Substring(2)
                        Else
                            Dim g As Integer = izr.IndexOf("D.")
                            Dim c As Char = izr.Substring(g - 1, 1).ToCharArray()(0)
                            If Not Char.IsLetterOrDigit(c) Then
                                izr = izr.Substring(0, g) & " " & tabela.Trim & "." & izr.Substring(g + 2)
                            End If
                        End If
                    End While
                    If dd = True Then izr = izr + " from " + tabela.Trim
                    Dim dt As New System.Data.DataTable
                    dt = izvrsiSQLvratiDT(izr, DBConnectionString, Me.jezik)

                    If dt.Rows.Count > 0 Then
                        izr = dt.Rows(0).Item(0)
                    Else
                        izr = ""
                    End If
                Else
                    If izr.IndexOf(":") >= 0 Then izr = izr.Substring(0, izr.IndexOf(":"))
                    If izr.IndexOf("#") >= 0 Then izr = izr.Replace("#", "")
                    If izr.IndexOf("{") >= 0 Then izr = izr.Replace("{", "")
                    If izr.IndexOf("}") >= 0 Then izr = izr.Replace("}", "")
                    While izr.IndexOf("D.") >= 0
                        If izr.IndexOf("D.") = 0 Then
                            izr = tabela.Trim & "." & izr.Substring(2)
                        Else
                            Dim g As Integer = izr.IndexOf("D.")
                            Dim c As Char = izr.Substring(g - 1, 1).ToCharArray()(0)
                            If Not Char.IsLetterOrDigit(c) Then
                                izr = izr.Substring(0, g) & " " & tabela.Trim & "." & izr.Substring(g + 2)
                            End If
                        End If
                    End While

                    If izr.IndexOf(" MEM ") > 0 Then
                        'DODAJKLJUCNADTABELE
                        Dim podtabela As String = ""
                        Dim bbb() As String = razkvantaj(izr)
                        For ll As Integer = 1 To bbb.GetUpperBound(0) 'ne moze mem da bude nulti
                            If bbb(ll).Trim.ToUpper = "MEM" Then podtabela = bbb(ll - 1) : Exit For
                        Next
                        Dim nadtabela As String = ""
                        For Each t As DatasetIstrazivanja.ISTTABELERow In m_tabele.Rows
                            If (Not t.IsNadTabelaNull) AndAlso t.Tabela.Trim.ToUpper = podtabela Then
                                nadtabela = t.NadTabela.Trim.ToUpper
                                Exit For
                            End If
                        Next
                        Dim klj() As String = DajKljuceve(nadtabela)
                        For ii As Integer = 0 To klj.GetUpperBound(0)
                            izr = izr + " and " + klj(ii) + "=MEM" + "." + klj(ii)
                        Next
                    End If
                End If

                While izr.IndexOf("PM.") >= 0
                    Dim g As Integer = izr.IndexOf("PM.")
                    Dim j As Integer = g + 3
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While
                While izr.IndexOf("PK.") >= 0
                    Dim g As Integer = izr.IndexOf("PK.")
                    Dim j As Integer = g + 3
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While
                While izr.IndexOf("PG.") >= 0
                    Dim g As Integer = izr.IndexOf("PG.")
                    Dim j As Integer = g + 3
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While
                While izr.IndexOf("PP.") >= 0
                    Dim g As Integer = izr.IndexOf("PP.")
                    Dim j As Integer = g + 3
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While

                'engleski
                While izr.IndexOf("PMONTH.") >= 0
                    Dim g As Integer = izr.IndexOf("PMONTH.")
                    Dim j As Integer = g + 7
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While
                While izr.IndexOf("PQ.") >= 0
                    Dim g As Integer = izr.IndexOf("PQ.")
                    Dim j As Integer = g + 3
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While
                While izr.IndexOf("PY.") >= 0
                    Dim g As Integer = izr.IndexOf("PY.")
                    Dim j As Integer = g + 3
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While
                While izr.IndexOf("PH.") >= 0
                    Dim g As Integer = izr.IndexOf("PH.")
                    Dim j As Integer = g + 3
                    Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                    While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                        j = j + 1
                        c = izr.Substring(j, 1).ToCharArray()(0)
                    End While
                    izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), tabela.Trim) & ") " & izr.Substring(j + 1)
                End While
                'engleski
            End If

            Return " (" & izr.Trim & ") "

        End Function

        Public Function iTag(ByVal t As String, ByVal i As Integer) As Integer
            Dim index As Integer = i
            index = index + 1
            Dim tagsFreq As Integer = 1
            While tagsFreq > 0 AndAlso index < t.Length
                If t.IndexOf("{", index, 1) >= 0 Then
                    tagsFreq = tagsFreq + 1
                    index = index + 1
                ElseIf t.IndexOf("}", index, 1) >= 0 Then
                    tagsFreq = tagsFreq - 1
                    If tagsFreq = 0 Then
                        Return index
                    End If
                    index = index + 1
                Else
                    index = index + 1
                End If
            End While
            Return -1
        End Function

        Private Function LKfunc(ByVal r3 As DatasetIstrazivanja.ISTLKRow, ByVal nf As String, ByVal p As String) As String
            Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
            Dim a As String = nf.ToUpper
            Select Case a
                Case ""
                    Return p
                Case "KONSULT"
                    If p.IndexOf(":") >= 0 Then p = p.Substring(0, p.IndexOf(":"))
                    Dim r As DatasetIstrazivanja.ISTPOLJARow
                    r = Me.m_tabelaPolja.FindBySIFISTTABELAPOLJE(r3.SIFIST, r3.TABELA, p)
                    If r Is Nothing Then
                        ''msg 160
                        Dim msgtxt160 As String = getMessageText(dtMessages, "160", Me.jezik) + nvrd
                        ''msg 161
                        Dim msgtxt161 As String = getMessageText(dtMessages, "161", Me.jezik) + nvrd
                        ''msg 162
                        Dim msgtxt162 As String = getMessageText(dtMessages, "162", Me.jezik) + nvrd
                        Throw New System.Exception(msgtxt160 + r3.SIFIST + nvrd + msgtxt161 + r3.TABELA + nvrd + msgtxt162 + p)
                    End If
                    Dim sql As String
                    Dim tb As DatasetIstrazivanja.ISTBAZEDataTable
                    tb = CType(mb.Table, DatasetIstrazivanja.ISTBAZEDataTable)
                    Dim r2 As DatasetIstrazivanja.ISTBAZERow
                    r2 = tb.FindByBaza(r.RelBaza)
                    Dim q As String = tabelaSQL(mb, r2, r.RelTabela.Trim)
                    sql = "NOT EXISTS(SELECT * FROM " + q + " t" + VBCRLF
                    sql = sql + " WHERE " + prepare_ime(mb, r.TABELA.Trim) + "." + r.POLJE.Trim +
                            "=t." + r.RelPolje
                    Dim sDBConnectionString As String
                    If r2 Is mb Then
                        sDBConnectionString = Me.DBConnectionString
                    Else
                        sDBConnectionString = Strc(enumLK2.e2, r2, "", "")
                    End If
                    Dim v As String = Me.mvt.vWhere(q, "t", sDBConnectionString)
                    If v <> "" Then
                        sql = sql + " and " + v
                    End If
                    sql = sql + ")"
                    Return sql
                Case "MBRP"
                    Dim d As String
                    d = "cast(" + f(p, 1, 1) + " as integer)*2+" + VBCRLF
                    For i As Integer = 2 To 7
                        d = d + "cast(" + f(p, i, 1) + " as integer)*" + (9 - i).ToString
                        If i < 7 Then
                            d = d + "+"
                        End If
                        d = d + VBCRLF
                    Next
                    Dim sql2 As String = m2(d, "11")
                    sql2 = "11-" + sql2
                    sql2 = sql2 + "<>" + "cast(" + f(p, 8, 1) + " as integer)"
                    Dim sql As String
                    sql = "(" + sql2 + ")"
                    '
                    sql2 = m2(d, "11")
                    sql2 = sql2 + ">1"
                    sql = sql + " and (" + sql2 + ") or (cast(" + f(p, 8, 1) + " as integer)<>0)" + VBCRLF
                    ''
                    sql2 = m2(d, "11")
                    sql2 = sql2 + "=1"
                    sql = sql + " and (" + sql2 + ")"
                    ''
                    sql2 = m2(d, "11")
                    sql2 = sql2 + "=0"
                    sql = sql + " or (" + sql2 + ")"
                    Return sql
                Case "JMBG"
                    Return mod_11(p, 13, mb, VBCRLF)
                    'Dim MyCheck As Boolean
                    'MyCheck = IsNumeric(p)   ' Returns True.
                Case "VNAS"
                    Return mod_11(p, 6, mb, VBCRLF)
                Case "VOPS"
                    Return mod_11(p, 5, mb, VBCRLF)
                Case "MOD11"
                    Dim ic As Integer = p.IndexOf(",")
                    Dim pp0 As String
                    Dim pp1 As Integer
                    If ic >= 0 Then
                        pp0 = p.Substring(0, ic)
                        pp1 = CInt(p.Substring(ic + 1))
                    Else
                        pp0 = p
                        pp1 = p.Length()
                    End If
                    Return mod_11(pp0, pp1, mb, VBCRLF)
                Case "VPIB"
                    Return V_PIB(p, mb, VBCRLF)
                    'Return " 2=3 "
                Case "UPARK"
                    Dim t2 As String = r3.TABELA.Trim
                    Dim w As String = ""
                    Dim r As DatasetIstrazivanja.ISTPOLJARow
                    For Each r In Me.m_tabelaPolja.Rows
                        If r.TABELA.Trim = t2 AndAlso kcol(r) Then
                            If w <> "" Then w = w + " AND "
                            w = w + t2 + "." + r.POLJE + "=" + r.POLJE
                        End If
                    Next
                    Dim ic As Integer = p.IndexOf(",")
                    Dim mt As String = p.Substring(0, ic)
                    Dim p2 As String = p.Substring(ic + 1)
                    Dim v As String = Me.mvt.vWhere(mt, "", Me.DBConnectionString)
                    If v <> "" Then
                        p2 = p2 + " and " + v
                    End If
                    Dim sql As String = "EXISTS (SELECT * FROM " & mt &
                            " WHERE " & w & " AND " & p2 & ")"
                    Return sql
                Case "ADRESAR"
                    If p.IndexOf(":") >= 0 Then p = p.Substring(0, p.IndexOf(":"))

                    Dim t2 As String = r3.TABELA.Trim
                    Dim it As Integer = p.IndexOf(";")
                    If it < 0 Then
                        ''msg 163
                        Dim msgtxt As String = getMessageText(dtMessages, "163", Me.jezik) + nvrd
                        Throw New System.Exception(msgtxt)
                    End If
                    Dim at As String = p.Substring(0, it).Trim
                    Dim k() As String = p.Substring(it + 1).Split(","c)
                    If k.Length = 0 Then
                        ''msg 163
                        Dim msgtxt As String = getMessageText(dtMessages, "163", Me.jezik) + nvrd
                        Throw New System.Exception(msgtxt)
                    End If
                    Dim w As String = ""
                    Dim v As New System.Data.DataView(Me.mta, Me.mta.TABELAColumn.ColumnName + "='" + at + "'", Me.mta.rbrColumn.ColumnName, System.Data.DataViewRowState.CurrentRows)
                    Dim i As Integer = -1
                    For Each rv As System.Data.DataRowView In v
                        Dim r As DatasetIstrazivanja.ISTPOLJARow = CType(rv.Row, DatasetIstrazivanja.ISTPOLJARow)
                        If w <> "" Then
                            w = w + " AND "
                        End If
                        i = i + 1
                        If k(i).IndexOf("'") >= 0 Then
                            w = w + "t." + r.POLJE + "='" + k(i).Replace("'", "").Trim + "' "
                        Else
                            w = w + "t." + r.POLJE + "=" + t2 + "." + k(i)
                        End If
                    Next
                    v.Dispose()
                    If i < 0 Then
                        ''msg 163
                        Dim msgtxt163 As String = getMessageText(dtMessages, "163", Me.jezik)
                        ''msg 164
                        Dim msgtxt164 As String = getMessageText(dtMessages, "164", Me.jezik)
                        ''msg 165
                        Dim msgtxt165 As String = getMessageText(dtMessages, "165", Me.jezik)

                        Throw New System.Exception(msgtxt163 + nvrd + nvrd + msgtxt164 + at + msgtxt165)
                    End If
                    Dim sql As String = "NOT EXISTS (SELECT * FROM " & at & " t WHERE " & w
                    Dim v2 As String = Me.mvt.vWhere(at, "t", Me.DBConnectionString)
                    If v2 <> "" Then sql = sql + " and " + v2
                    sql = sql + ")"
                    Return sql
                Case "RELACIJA"
                    If p.IndexOf(":") >= 0 Then p = p.Substring(0, p.IndexOf(":"))

                    Dim t2 As String = r3.TABELA.Trim
                    Dim it As Integer = p.IndexOf(";")
                    If it < 0 Then
                        ''msg 166
                        Dim msgtxt As String = getMessageText(dtMessages, "166", Me.jezik)
                        Throw New System.Exception(msgtxt)
                    End If
                    Dim at As String = p.Substring(0, it).Trim
                    'zamena MMM,GGG i ostalo u LK
                    at = strrpl(at, "{SIFIST}", "'" + Me.sifist + "'")
                    at = strrpl(at, "{APPCODE}", "'" + Me.sifist + "'")
                    at = strrpl(at, "{GGG}", "'" + mvt.G.ToString + "'")
                    at = strrpl(at, "{MMM}", "'" + String.Format("{0:d2}", mvt.M) + "'")
                    at = strrpl(at, "{YYY}", "'" + mvt.G.ToString + "'")

                    at = GGMMGoreDole(at, mvt.G, mvt.M)
                    at = strrpl(at, "VRTACKA", mvt.vtwhere(""))
                    at = strrpl(at, "GGG", mvt.GWhere(""))
                    at = strrpl(at, "MMM", mvt.mWhere(""))
                    at = strrpl(at, "YYY", mvt.YWhere(""))

                    at = strrpl(at, "{GGG", "'" + mvt.G.ToString + "'")
                    at = strrpl(at, "{MMM", "'" + String.Format("{0:d2}", mvt.M) + "'")
                    at = strrpl(at, "{YYY", "'" + mvt.G.ToString + "'")

                    at = at.Replace(Microsoft.VisualBasic.ChrW(26), "")
                    at = ZameniVodVdo(at, mvt)
                    at = pu(Nothing, String.Empty, at)

                    at = at.Replace("Convert", "CAST").Replace(",'System.Int32'", " as integer")

                    ''prvo zameni ako postoji D.
                    'napuni ddd sa onim sql sto je u  trt.Tag.Rel(1)
                    'prvo zameni ako postoji D.
                    If at.Trim.ToUpper.IndexOf("D.") > 0 Then
                        Dim aaa() As String = razkvantaj(at.Trim)
                        For ii As Integer = 0 To aaa.Length() - 1
                            If aaa(ii).Length() > 1 AndAlso aaa(ii).Substring(0, 2).ToUpper = "D." Then
                                'aaa(ii) = aaa(ii).Replace("D.", "").Trim.ToUpper

                                aaa(ii) = aaa(ii).Replace("D.", r3.TABELA + ".").Trim.ToUpper
                            End If
                        Next
                        at = ustringaj(aaa).ToUpper
                    End If
                    Dim k() As String = p.Substring(it + 1).Split(","c)
                    If k.Length = 0 Then
                        ''msg 166
                        Dim msgtxt As String = getMessageText(dtMessages, "166", Me.jezik)
                        Throw New System.Exception(msgtxt)
                    End If
                    Dim w As String = ""
                    Dim i As Integer
                    For i = 0 To k.GetUpperBound(0)
                        If w <> "" Then w = w + " AND "
                        Dim kk() As String = k(i).Split("="c)
                        w = w + t2 + "." + kk(0).Trim + "= t." + kk(1).Trim
                    Next
                    If i <= 0 Then
                        ''msg 166
                        Dim msgtxt As String = getMessageText(dtMessages, "166", Me.jezik)
                        Throw New System.Exception(msgtxt)
                    End If

                    Dim sql As String = "NOT EXISTS (SELECT * FROM " & at & " t WHERE " & w
                    Dim v2 As String = Me.mvt.vWhere(at, "t", Me.DBConnectionString)
                    If v2 <> "" Then sql = sql + " and " + v2
                    sql = sql + ")"
                    Return sql
                Case "YYY"
                    Return "'" & (Me.mvt.G + CInt(p)).ToString.Trim & " '"
                Case "GGG"
                    Return "'" & (Me.mvt.G + CInt(p)).ToString.Trim & " '"
                Case "GGM"
                    Dim mrt As Integer = Me.mvt.M + CInt(p) Mod 12
                    Dim trt As Integer = Me.mvt.G + (CInt(p) \ 12)
                    If mrt <= 0 Then trt = trt - 1
                    If mrt > 12 Then trt = trt + 1
                    Return "'" & trt.ToString.Trim & " '"
                Case "MMM"
                    Dim trt As Integer = Me.mvt.M + (CInt(p) Mod 12)
                    If trt <= 0 Then trt = trt + 12
                    If trt > 12 Then trt = trt - 12
                    Return "'" & trt.ToString.Trim.PadLeft(2, "0"c) & " '"

                Case "FP"
                    If p.IndexOf(":") >= 0 Then p = p.Substring(0, p.IndexOf(":"))
                    Dim r As DatasetIstrazivanja.ISTPOLJARow
                    r = Me.m_tabelaPolja.FindBySIFISTTABELAPOLJE(r3.SIFIST, r3.TABELA, p.Trim)
                    If r Is Nothing Then
                        ''msg 160
                        Dim msgtxt160 As String = getMessageText(dtMessages, "160", Me.jezik) + nvrd
                        ''msg 161
                        Dim msgtxt161 As String = getMessageText(dtMessages, "161", Me.jezik) + nvrd
                        ''msg 162
                        Dim msgtxt162 As String = getMessageText(dtMessages, "162", Me.jezik) + nvrd
                        Throw New System.Exception(msgtxt160 + r3.SIFIST + nvrd + msgtxt161 + r3.TABELA + nvrd + msgtxt162 + p)
                    End If
                    Dim izr As String = ""
                    If Not r.IsIzrazNull Then
                        izr = r.Izraz.Trim.ToUpper
                        'zamena GGGMMM
                        Dim sql As String
                        sql = izr
                        sql = strrpl(sql, "{GGG}", "'" + Me.mvt.G.ToString + "'")
                        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", Me.mvt.M) + "'")
                        sql = strrpl(sql, "{YYY}", "'" + Me.mvt.G.ToString + "'")

                        sql = GGMMGoreDole(sql, mvt.G, mvt.M)
                        sql = strrpl(sql, "VRTACKA", Me.mvt.vtwhere(""))
                        sql = strrpl(sql, "GGG", Me.mvt.GWhere(""))
                        sql = strrpl(sql, "MMM", Me.mvt.mWhere(""))
                        sql = strrpl(sql, "YYY", Me.mvt.YWhere(""))

                        sql = sql.Replace(Microsoft.VisualBasic.ChrW(26), "")
                        'sql = ZameniVodVdo(sql, Me.mvt)
                        izr = sql

                        izr = SrediIzrazZaFP(izr)

                        If izr.ToUpper.IndexOf("GLAVA.") >= 0 OrElse izr.ToUpper.IndexOf("HEAD.") >= 0 Then
                            'svaku glavu promeni u odgovarajuci select
                            Dim polje() As String = razkvantaj(izr)
                            For ll As Integer = 0 To polje.GetUpperBound(0)
                                If polje(ll).ToUpper.Trim.IndexOf("GLAVA.") = 0 OrElse polje(ll).ToUpper.Trim.IndexOf("HEAD.") = 0 Then
                                    polje(ll) = polje(ll).Replace("GLAVA.", "")
                                    polje(ll) = polje(ll).Replace("HEAD.", "")
                                    polje(ll) = " (" & USelektajGLAVU(polje(ll), r3.TABELA.Trim) & ") "
                                End If
                            Next
                            izr = ustringaj(polje).ToUpper
                        End If

                        'ako je FP u stvari polje od nekog dupeta npr f025 je {POGL_02.p025}
                        If izr.IndexOf("{") = 0 Then
                            izr = izr.Replace("{", "")
                            izr = izr.Replace("}", "")
                            izr = " (" & USelektajDUPE(izr, r3.TABELA.Trim) & ") "
                        ElseIf izr.IndexOf("#FP{") >= 0 AndAlso izr.IndexOf("DBO.") < 0 Then  'fp unutar fp-a
                            Dim a1 As Integer = izr.IndexOf("#FP{")
                            Dim a2 As String = izr.Substring(a1 + 4, izr.Substring(a1).IndexOf("}") - 4)
                            izr = Me.LKfunc(r3, "fp", a2)
                        ElseIf izr.IndexOf("#FP{") >= 0 AndAlso izr.IndexOf("DBO.") > 0 Then  'fp unutar fp-a i jos u nekoj funkciji
                            Dim a1 As Integer = izr.IndexOf("#FP{")
                            Dim a2 As String = izr.Substring(a1 + 4, izr.Substring(a1).IndexOf("}") - 4)
                            Dim a3 As String = "#FP{" + a2.Trim.ToUpper + "}"
                            izr = izr.Replace(a3, Me.LKfunc(r3, "fp", a2).Trim.ToUpper)
                            If izr.IndexOf(":") >= 0 Then izr = izr.Substring(0, izr.IndexOf(":"))
                            If izr.IndexOf("#") >= 0 Then izr = izr.Replace("#", "")
                            If izr.IndexOf("{") >= 0 Then izr = izr.Replace("{", "")
                            If izr.IndexOf("}") >= 0 Then izr = izr.Replace("}", "")
                            Dim dd As Boolean = False
                            While izr.IndexOf("D.") >= 0
                                dd = True
                                If izr.IndexOf("D.") = 0 Then
                                    izr = r3.TABELA.Trim & "." & izr.Substring(2)
                                Else
                                    Dim g As Integer = izr.IndexOf("D.")
                                    Dim c As Char = izr.Substring(g - 1, 1).ToCharArray()(0)
                                    If Not Char.IsLetterOrDigit(c) Then
                                        izr = izr.Substring(0, g) & " " & r3.TABELA.Trim & "." & izr.Substring(g + 2)
                                    End If
                                End If
                            End While
                            If dd = True Then izr = izr + " from " + r3.TABELA.Trim
                            Dim dt As New System.Data.DataTable
                            dt = izvrsiSQLvratiDT(izr, DBConnectionString, Me.jezik)

                            If dt.Rows.Count > 0 Then
                                izr = dt.Rows(0).Item(0)
                            Else
                                izr = ""
                            End If

                            'izr = Me.LKfunc(r3, "fp", a2)
                        Else
                            If izr.IndexOf(":") >= 0 Then izr = izr.Substring(0, izr.IndexOf(":"))
                            If izr.IndexOf("#") >= 0 Then izr = izr.Replace("#", "")
                            If izr.IndexOf("{") >= 0 Then izr = izr.Replace("{", "")
                            If izr.IndexOf("}") >= 0 Then izr = izr.Replace("}", "")
                            While izr.IndexOf("D.") >= 0
                                If izr.IndexOf("D.") = 0 Then
                                    izr = r3.TABELA.Trim & "." & izr.Substring(2)
                                Else
                                    Dim g As Integer = izr.IndexOf("D.")
                                    Dim c As Char = izr.Substring(g - 1, 1).ToCharArray()(0)
                                    If Not Char.IsLetterOrDigit(c) Then
                                        izr = izr.Substring(0, g) & " " & r3.TABELA.Trim & "." & izr.Substring(g + 2)
                                    End If
                                End If
                            End While

                            If izr.IndexOf(" MEM ") > 0 Then
                                'DODAJKLJUCNADTABELE
                                Dim podtabela As String = ""
                                Dim bbb() As String = razkvantaj(izr)
                                For ll As Integer = 1 To bbb.GetUpperBound(0) 'ne moze mem da bude nulti
                                    If bbb(ll).Trim.ToUpper = "MEM" Then podtabela = bbb(ll - 1) : Exit For
                                Next

                                Dim nadtabela As String = ""
                                For Each t As DatasetIstrazivanja.ISTTABELERow In m_tabele.Rows
                                    If (Not t.IsNadTabelaNull) AndAlso t.Tabela.Trim.ToUpper = podtabela Then
                                        nadtabela = t.NadTabela.Trim.ToUpper
                                        Exit For
                                    End If
                                Next
                                Dim klj() As String = DajKljuceve(nadtabela)
                                For ii As Integer = 0 To klj.GetUpperBound(0)
                                    izr = izr + " and " + klj(ii) + "=MEM" + "." + klj(ii)
                                    '+ podtabela.Trim.ToUpper
                                Next
                            End If
                        End If

                        While izr.IndexOf("PM.") >= 0
                            Dim g As Integer = izr.IndexOf("PM.")
                            Dim j As Integer = g + 3
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While
                        While izr.IndexOf("PK.") >= 0
                            Dim g As Integer = izr.IndexOf("PK.")
                            Dim j As Integer = g + 3
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While
                        While izr.IndexOf("PG.") >= 0
                            Dim g As Integer = izr.IndexOf("PG.")
                            Dim j As Integer = g + 3
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While
                        While izr.IndexOf("PP.") >= 0
                            Dim g As Integer = izr.IndexOf("PP.")
                            Dim j As Integer = g + 3
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While

                        'engleski
                        While izr.IndexOf("PMONTH.") >= 0
                            Dim g As Integer = izr.IndexOf("PMONTH.")
                            Dim j As Integer = g + 7
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While
                        While izr.IndexOf("PQ.") >= 0
                            Dim g As Integer = izr.IndexOf("PQ.")
                            Dim j As Integer = g + 3
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While
                        While izr.IndexOf("PY.") >= 0
                            Dim g As Integer = izr.IndexOf("PY.")
                            Dim j As Integer = g + 3
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While
                        While izr.IndexOf("PH.") >= 0
                            Dim g As Integer = izr.IndexOf("PH.")
                            Dim j As Integer = g + 3
                            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
                            While j < izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                                j = j + 1
                                c = izr.Substring(j, 1).ToCharArray()(0)
                            End While
                            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g + 1), r3.TABELA.Trim) & ") " & izr.Substring(j + 1)
                        End While
                        'engleski

                    End If
                    Return " (" & izr.Trim & ") "
                Case "VODVDO"
                    Dim v As String
                    If p.GetType Is GetType(System.DBNull) OrElse p.Trim = "" Then
                        v = Me.mvt.vWhere("", "", "")
                    Else
                        v = Me.mvt.vWhere("", p, "")
                    End If
                    Return v
                Case Else
                    ''msg 167
                    Dim msgtxt As String = getMessageText(dtMessages, "167", Me.jezik)
                    Throw New System.Exception("'" + a + msgtxt)
            End Select
        End Function

        Private Function DajKljuceve(ByVal tbl As String) As String()
            Dim klj() As String = {}
            For Each p As DatasetIstrazivanja.ISTPOLJARow In m_tabelaPolja.Rows
                If p.TABELA.Trim.ToUpper = tbl.Trim.ToUpper Then
                    If Not p.IsKLJUCNull AndAlso p.KLJUC.Trim.ToUpper = "P" Then
                        ReDim Preserve klj(1 + klj.GetUpperBound(0))
                        klj(klj.GetUpperBound(0)) = p.POLJE.Trim.ToUpper
                    End If
                End If
            Next
            Return klj
        End Function

        Private Function USelektajDUPE(ByVal s As String, ByVal t As String) As String
            Dim kljNizGlava() As String = {}
            Dim trt As String = "SELECT "
            Dim n() As String = s.Split("."c)
            trt = trt + n(1) & " FROM " & n(0) & " P where "
            Dim imaG As Boolean = False
            Dim imaM As Boolean = False
            Dim imaGE As Boolean = False
            Dim imaME As Boolean = False

            For Each rGlava As DatasetIstrazivanja.ISTPOLJARow In Me.m_tabelaPolja
                If rGlava.TABELA.Trim.ToUpper = n(0).Trim.ToUpper Then
                    If Not rGlava.IsKLJUCNull AndAlso rGlava.KLJUC.Trim.ToUpper = "P" Then
                        If rGlava.POLJE.Trim.ToUpper <> "GOD" AndAlso rGlava.POLJE.Trim.ToUpper <> "MES" _
                            AndAlso rGlava.POLJE.Trim.ToUpper <> "ISTYEAR" AndAlso rGlava.POLJE.Trim.ToUpper <> "ISTMONTH" Then
                            ReDim Preserve kljNizGlava(kljNizGlava.GetUpperBound(0) + 1)
                            kljNizGlava(kljNizGlava.GetUpperBound(0)) = rGlava.POLJE.Trim.ToUpper
                        End If
                        If rGlava.POLJE.Trim.ToUpper = "GOD" Then imaG = True
                        If rGlava.POLJE.Trim.ToUpper = "MES" Then imaM = True
                        If rGlava.POLJE.Trim.ToUpper = "ISTYEAR" Then imaGE = True
                        If rGlava.POLJE.Trim.ToUpper = "ISTMONTH" Then imaME = True
                    End If
                End If
            Next
            For i As Integer = 0 To kljNizGlava.GetUpperBound(0)
                trt = trt + "P." & kljNizGlava(i) & " = " & t & "." & kljNizGlava(i) & " AND "
            Next
            '+vremenska tacka ako je ima u kljucu
            Dim GG As String = CStr(Me.mvt.G)
            Dim MM As String = CStr(Me.mvt.M).Trim.PadLeft(2, "0"c)
            If imaG = True Then trt = trt + "P.GOD='" & GG & "' AND "
            If imaM = True Then trt = trt + "P.MES='" & MM & "' AND "
            If imaGE = True Then trt = trt + "P.ISTYEAR='" & GG & "' AND "
            If imaME = True Then trt = trt + "P.ISTMONTH='" & MM & "' AND "

            trt = trt + " 2=2"
            Return trt
        End Function

        Private Function USelektajGLAVU(ByVal polje As String, ByVal tabela As String) As String
            Dim kljNizGlava() As String = {}
            Dim trt As String = "SELECT "

            Dim imaG As Boolean = False
            Dim imaM As Boolean = False
            Dim imaGE As Boolean = False
            Dim imaME As Boolean = False
            Dim nadtabela As String = ""

            For Each t As DatasetIstrazivanja.ISTTABELERow In Me.m_tabele
                If t.Tabela.Trim.ToUpper = tabela.Trim.ToUpper Then
                    nadtabela = Microsoft.VisualBasic.IIf(t.Item("nadtabela") Is System.DBNull.Value, "", t.Item("nadtabela").ToString.Trim)
                    Exit For
                End If
            Next
            trt = trt + polje & " FROM " & nadtabela & " P where "
            For Each rGlava As DatasetIstrazivanja.ISTPOLJARow In Me.m_tabelaPolja
                If rGlava.TABELA.Trim.ToUpper = nadtabela.Trim.ToUpper Then
                    If Not rGlava.IsKLJUCNull AndAlso rGlava.KLJUC.Trim.ToUpper = "P" Then
                        If rGlava.POLJE.Trim.ToUpper <> "GOD" AndAlso rGlava.POLJE.Trim.ToUpper <> "MES" _
                           AndAlso rGlava.POLJE.Trim.ToUpper <> "ISTYEAR" AndAlso rGlava.POLJE.Trim.ToUpper <> "ISTMONTH" Then
                            ReDim Preserve kljNizGlava(kljNizGlava.GetUpperBound(0) + 1)
                            kljNizGlava(kljNizGlava.GetUpperBound(0)) = rGlava.POLJE.Trim.ToUpper
                        End If
                        If rGlava.POLJE.Trim.ToUpper = "GOD" Then imaG = True
                        If rGlava.POLJE.Trim.ToUpper = "MES" Then imaM = True
                        If rGlava.POLJE.Trim.ToUpper = "ISTYEAR" Then imaGE = True
                        If rGlava.POLJE.Trim.ToUpper = "ISTMONTH" Then imaME = True
                    End If
                End If
            Next
            For i As Integer = 0 To kljNizGlava.GetUpperBound(0)
                trt = trt + "P." & kljNizGlava(i) & " = " & tabela & "." & kljNizGlava(i) & " AND "
            Next
            '+vremenska tacka ako je ima u kljucu
            Dim GG As String = CStr(Me.mvt.G)
            Dim MM As String = CStr(Me.mvt.M).Trim.PadLeft(2, "0"c)
            If imaG = True Then trt = trt + "P.GOD='" & GG & "' AND "
            If imaM = True Then trt = trt + "P.MES='" & MM & "' AND "
            If imaGE = True Then trt = trt + "P.ISTYEAR='" & GG & "' AND "
            If imaME = True Then trt = trt + "P.ISTMONTH='" & MM & "' AND "
            trt = trt + " 2=2"
            Return trt
        End Function

        Private Function ZameniVodVdo(ByVal ss As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka) As String
            Dim s As String = ss.Trim
            Dim sss As String = ss.Trim.ToUpper
            Dim gde As Integer = sss.IndexOf("#VODVDO{")
            While gde >= 0
                Dim doklen As Integer = s.IndexOf("}", gde + 6)
                Dim sta As String = s.Substring(gde, doklen - gde + 1)
                Dim p As String = ""
                If sta.Length > 9 Then p = sta.Substring(8, sta.Length() - 9).Trim
                s = strrpl(s, sta, vt.vWhere("", p, ""))
                sss = s.ToUpper
                gde = sss.IndexOf("#VODVDO{")
            End While
            Return s
        End Function

        Public Function gindex(
  ByVal t As String,
  ByVal i2 As Integer,
  ByVal st As String,
  ByVal et As String) As Integer
            Dim i As Integer = i2
            i += st.Length
            Dim tf As Integer = 1
            While tf > 0 AndAlso i < t.Length
                If t.IndexOf(st, i, st.Length) >= 0 Then
                    tf += 1
                    i += st.Length
                ElseIf t.IndexOf(et, i, et.Length) >= 0 Then
                    tf -= 1
                    If tf = 0 Then
                        Return i
                    End If
                    i += et.Length
                Else
                    i += 1
                End If
            End While
            Return -1
        End Function

        Private Function xf(ByVal k As DatasetIstrazivanja.ISTLKRow, ByVal nf As String, ByVal p As String) As String
            xf = ""
            Dim fn As String = nf.Trim.ToUpper
            Select Case fn
                Case String.Empty
                    Return p
                Case "VODVDO"
                    Return Me.mvt.vWhere(String.Empty, p, String.Empty)
                Case Else
                    ISTMessageBox.Show("Error at function xf", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        End Function

        Public Function pu(
        ByVal k As DatasetIstrazivanja.ISTLKRow,
        ByVal nf As String,
        ByVal tf As String) As String
            Dim it As Integer = tf.IndexOf("#")
            Dim idz As Integer = -1
            Dim rz As String = String.Empty
            While it >= 0
                rz += tf.Substring(idz + 1, it - idz - 1)
                Dim ilz As Integer = tf.IndexOf("{", it + 1)
                If ilz < 0 Then
                    ISTMessageBox.Show("Error at function pu", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                idz = gindex(tf, ilz, "{", "}")
                If idz < 0 Then
                    ISTMessageBox.Show("Error at function pu", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Dim nf2 As String = tf.Substring(it + 1, ilz - it - 1)
                Dim tf2 As String = tf.Substring(ilz + 1, idz - ilz - 1)
                rz += pu(k, nf2, tf2)
                it = tf.IndexOf("#", idz + 1)
            End While
            rz += tf.Substring(idz + 1)
            If nf <> String.Empty Then
                rz = xf(k, nf, rz)
            End If
            Return rz.Trim
        End Function

        Private Function USelektajPM(ByVal s As String, ByVal t As String) As String
            Dim kljNiz() As String = {}
            For Each r As DatasetIstrazivanja.ISTPOLJARow In Me.m_tabelaPolja
                If r.TABELA.Trim.ToUpper = t.Trim.ToUpper Then
                    If Not r.IsKLJUCNull AndAlso r.KLJUC.Trim.ToUpper = "P" Then
                        If r.POLJE.Trim.ToUpper <> "GOD" AndAlso r.POLJE.Trim.ToUpper <> "MES" _
                            AndAlso r.POLJE.Trim.ToUpper <> "ISTYEAR" AndAlso r.POLJE.Trim.ToUpper <> "ISTMONTH" Then
                            ReDim Preserve kljNiz(kljNiz.GetUpperBound(0) + 1)
                            kljNiz(kljNiz.GetUpperBound(0)) = r.POLJE.Trim.ToUpper
                        End If
                    End If
                End If
            Next
            Dim trt As String = "SELECT "
            Dim n() As String = s.Split("."c)
            trt = trt + n(1) & " FROM " & t & " P where "
            For i As Integer = 0 To kljNiz.GetUpperBound(0)
                trt = trt + "P." & kljNiz(i) & " = " & t & "." & kljNiz(i) & " AND "
            Next

            Dim GG1 As String = CStr(Me.mvt.G - 1)
            Dim MM1 As String = CStr(Me.mvt.M - 1).Trim.PadLeft(2, "0"c)
            If Me.mvt.M = 1 Then MM1 = "12"
            Dim GGM1 As String = CStr(Me.mvt.G)
            If Me.mvt.M = 1 Then GGM1 = GG1
            Dim GGM3 As String = CStr(Me.mvt.G)
            If Me.mvt.M < 4 Then GGM3 = GG1
            Dim MM3 As String = CStr(Me.mvt.M - 3).Trim.PadLeft(2, "0"c)
            If Me.mvt.M < 4 Then MM3 = CStr(Me.mvt.M + 9).Trim.PadLeft(2, "0"c)

            'prethodno polugođe
            Dim GGM4 As String = CStr(Me.mvt.G)
            If Me.mvt.M < 6 Then GGM4 = GG1 'prethodna godina
            Dim MM4 As String = CStr(Me.mvt.M - 6).Trim.PadLeft(2, "0"c)
            If Me.mvt.M < 6 Then MM4 = CStr(Me.mvt.M + 6).Trim.PadLeft(2, "0"c)

            Select Case n(0).Trim.ToUpper
                Case "PM"
                    trt = trt + "(P.mes = '" & MM1 & "' AND P.god='" & GGM1 & "' )"
                Case "PMONTH"
                    trt = trt + "(P.ISTMONTH = '" & MM1 & "' AND P.ISTYEAR='" & GGM1 & "' )"
                Case "PK"
                    trt = trt + "(P.mes = '" & MM3 & "' AND P.god='" & GGM3 & "' )"
                Case "PQ"
                    trt = trt + "(P.ISTMONTH = '" & MM3 & "' AND P.ISTYEAR='" & GGM3 & "' )"
                Case "PG"
                    trt = trt + "(P.mes= '" & CStr(Me.mvt.M).Trim.PadLeft(2, "0"c) & "' AND P.God='" & GG1 & "' )"
                Case "PY"
                    trt = trt + "(P.ISTMONTH= '" & CStr(Me.mvt.M).Trim.PadLeft(2, "0"c) & "' AND P.ISTYEAR='" & GG1 & "' )"
                Case "PP"
                    trt = trt + "(P.mes = '" & MM4 & "' AND P.god='" & GGM4 & "' )"
                Case "PH"
                    trt = trt + "(P.ISTMONTH = '" & MM4 & "' AND P.ISTYEAR='" & GGM4 & "' )"
            End Select
            Return trt
        End Function

        Private Function V_PIB(ByVal p As String, ByVal mb As DatasetIstrazivanja.ISTBAZERow, ByVal VBCRLF As String) As String
            Dim trt As String = " (cast( " & f(p, 1, 1) & " as INT)) "
            For i As Integer = 2 To 8
                trt = " ( " & m2(" ( " & trt & " *2 ) ", "11") & " ) "
                trt = " ( " & m2(f(p, i, 1) & " +  " & trt, "10") & " ) "
                trt = " ( CASE WHEN 0= " & trt & " THEN 10 ELSE " & trt & " END ) " & VBCRLF
            Next
            trt = " ( " & m2(" ( " & trt & " *2 ) ", "11") & " ) "
            trt = m2(" ( 11 - " & trt & " ) ", "10")
            trt = f(p, 9, 1) & " <> ( " & trt & " ) "
            Return trt
        End Function

        Private Function mod_11(ByVal p As String, ByVal duz As Integer, ByVal mb As DatasetIstrazivanja.ISTBAZERow, ByVal VBCRLF As String) As String
            Dim d As String = ""

            Dim la As Integer = duz - 1
            For i As Integer = 0 To la - 1
                d = d + "cast(" + f(p, i + 1, 1) + " as integer)*" + (((la - i - 1) Mod 6) + 2).ToString
                If i < la - 1 Then d = d + "+"
                d = d + VBCRLF
            Next

            Dim sql2 As String = m2(d, "11")

            sql2 = "(case when 11-" + sql2 + " <10 then 11-" + sql2 + " else 0 end)"
            sql2 = sql2 + "<>" + "cast(" + f(p, duz, 1) + " as integer)"
            Dim sql As String
            sql = "(" + sql2 + ")"

            Return sql
        End Function

        Public Shared Function prepare_ime(ByVal r As DatasetIstrazivanja.ISTBAZERow, ByVal t As String) As String
            If Not r.IsprefixNull AndAlso r.prefix.Trim <> "" Then
                Dim p As String = r.prefix.Trim
                p = dozagrade(p)
                Return p + "." + t
            End If
            Return t
        End Function

        Public Shared Function dozagrade(ByVal name As String) As String
            name = name.Trim
            If name.Chars(0) <> "["c Then
                Return "[" + name + "]"
            End If
            Return name
        End Function

        Public Shared Function tabelaSQL(ByVal b As DatasetIstrazivanja.ISTBAZERow, ByVal r As DatasetIstrazivanja.ISTBAZERow,
        ByVal t2 As String) As String

            If r Is Nothing Then r = b

            Dim s As String = r.IzrazODBC.Trim
            If Not (r.IsIzrazOLENull OrElse r.IzrazOLE.Trim = "") Then s = r.IzrazOLE.Trim
            s = Replace(s, "provider=sqloledb.1;", "", 1, , CompareMethod.Text)
            'Data Source = IMT2.statsrb.lan;Initial Catalog=BCCPI;
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
            n = dozagrade(n)
            n = prepare_ime(r, n)

            Dim prefix As String = dozagrade(baza)
            n = prefix.Trim + "." + n
            If Not b Is r Then
                Dim provider As String = str_parametar(s, "provider")
                If provider = "" Then provider = "SQLNCLI11"
                n = "OPENROWSET('" + provider + "','" + "Server=" + server + ";Trusted_Connection=yes;'," + n + ")"
            End If
            Return n
        End Function

        Public Shared Function str_parametar(ByVal s As String, ByVal parameter As String) As String
            Dim i As Integer = s.ToLower.IndexOf(parameter)
            Dim iStart As Integer = i
            If i >= 0 Then
                i = s.IndexOf("=", i + 1)
                If i >= 0 Then
                    Dim j As Integer = s.IndexOf(";", i + 1)
                    If j >= 0 Then
                        Return s.Substring(i + 1, j - i - 1).Trim
                    Else
                        Return s.Substring(i + 1).Trim
                    End If
                End If
            End If
            Return ""
        End Function

        Public Enum enumLK2
            e1
            e2
        End Enum

        Public Shared Function Strc(ByVal auth As enumLK2, ByVal r As DatasetIstrazivanja.ISTBAZERow, ByVal userID As String, ByVal password As String) As String

            Dim s As String = r.IzrazODBC.Trim
            If Not (r.IsIzrazOLENull OrElse r.IzrazOLE.Trim = "") Then s = r.IzrazOLE.Trim
            s = Replace(s, "provider=sqloledb.1;", "", 1, , CompareMethod.Text)

            If s.ToLower.IndexOf("password") >= 0 OrElse s.ToLower.IndexOf("pwd") >= 0 Then
            Else
                If userID <> "" AndAlso password <> "" Then
                    s = s + ";User ID=" + userID + ";Password=" + password + ";"
                Else
                    'windows auth
                    'If txtmode <> "CLOUD" Then  s = s + ";Integrated Security=SSPI;Persist Security Info=False"
                    s = s + ";Integrated Security=SSPI;Persist Security Info=False"

                    s = s.Replace(";;", ";")
                End If
            End If

            Strc = s

        End Function

        Public Function kcol(ByVal r As DatasetIstrazivanja.ISTPOLJARow) As Boolean
            If Not r.IsKLJUCNull _
            AndAlso r.KLJUC.Trim.ToUpper = "P" Then
                Return True
            End If
            Return False
        End Function

        Public Function m2(ByVal d2 As String, ByVal d3 As String) As String
            Dim sql As String = "(" + d2 + ")%" + d3
            Return sql
        End Function

        Public Function f(ByVal colName As String, ByVal start As Integer, ByVal length As Integer) As String
            Dim s As String = "substring"
            Return s + "(" + colName + "," + start.ToString + "," + length.ToString + ")"
        End Function

        Dim jezik As String
        Dim sifist As String

        Public Sub New(
        ByVal b As DatasetIstrazivanja.ISTBAZERow,
        ByVal t As DatasetIstrazivanja.ISTTABELEDataTable,
        ByVal p As DatasetIstrazivanja.ISTPOLJADataTable,
        ByVal a As DatasetIstrazivanja.ISTPOLJADataTable,
        ByVal v As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
        ByVal s As String, ByVal jezik As String)
            mb = b
            Me.m_tabelaPolja = p
            Me.m_tabele = t
            Me.mta = a
            Me.mvt = v
            Me.DBConnectionString = s
            Me.jezik = jezik
            Me.sifist = t.Rows(0).Item("sifist").ToString.Trim.ToUpper
        End Sub

    End Class

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogickaKontrola))
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogickaKontrola
        '
        Me.ClientSize = New System.Drawing.Size(336, 217)

        Me.Name = "LogickaKontrola"
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
End Class

Public Class LKizv
    Inherits FormTemplate
    Public mrist As DatasetIstrazivanja.ISTRow
    Dim VBCRLF As String = System.Environment.NewLine
    Public DBConnectionString As String
    Public mrb As DatasetIstrazivanja.ISTBAZERow
    Public mtip As DatasetIstrazivanja.ISTLKDataTable
    Public mvlk As System.Data.DataView
    Public mprog As System.Windows.Forms.ProgressBar
    Public ds As New DatasetLogickaKontrolaIzvestaj
    Public s As String
    Public mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Private WithEvents gr As DataGridView
    Private WithEvents grT As DataGridView
    Private WithEvents grG As DataGridView

    Private Sub LK3(ByVal sTab As String, ByVal tt As String, ByVal sc As String, ByRef pt As String, ByRef ss As String)
        Dim str As String = ""
        If pt <> tt AndAlso pt <> "" Then

            Dim tn As String = uzmisqltab(Me.mrb, Nothing, pt)
            str = "select count(*) as Slogova,sum(isnull(cast (INDGR as int),0)) as Neispravnih," + ss + " from " + tn + " where 1=1"
            If sTab <> "" Then str = str + " and " + sTab
            Dim v As String = Me.mvt.vWhere(tn, "", Me.DBConnectionString)
            If v <> "" Then str = str + " and " + v

            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)

            Dim r As System.Data.DataRow = dt.Rows(0)
            ds.Tables(0).Rows.Add(New Object() {pt, r.ItemArray(0), r.ItemArray(1)})
            Dim i As Integer = 0
            While i < dt.Columns.Count
                If Not r.IsNull(i) Then
                    Dim errCount As Long = CLng(r.Item(i))
                    If errCount = 0 Then
                        dt.Columns.RemoveAt(i)
                        i -= 1
                    End If
                End If
                i += 1
            End While
            For i = 2 To dt.Columns.Count - 1
                Dim rLK As DatasetIstrazivanja.ISTLKRow
                rLK = Me.mtip.FindBySIFISTTABELARbrGreske(s, pt, dt.Columns(i).ColumnName)
                If rLK.Item("USLOV").GetType Is GetType(System.DBNull) OrElse rLK.Item("USLOV").Trim = "" OrElse rLK.Item("USLOV").Trim.ToUpper.indexof("LKVELIKA") >= 0 OrElse rLK.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                    Dim items() As Object = {pt, dt.Columns(i).ColumnName, r.ItemArray(i), rLK.Item(Me.mtip.GRESKAColumn.Ordinal), rLK.Item(Me.mtip.NazivGreskeColumn.Ordinal), rLK.Item(Me.mtip.AkcijaColumn.Ordinal)}
                    ' ako nije Slogova prazno (znaci da nema gresaka)
                    If Not items(2) Is System.DBNull.Value Then
                        ds.Tables(1).Rows.Add(items)
                    End If
                End If
            Next
            dt.Dispose()
            ss = ""

        End If
        If ss <> "" Then
            ss += ","
        End If
        ss += "sum(isnull(cast (" + sc.Trim + " as int),0)) as " + sc.Trim
        pt = tt
    End Sub

    Public Function uzmisqltab(ByVal crb As DatasetIstrazivanja.ISTBAZERow, ByVal rowBaze As DatasetIstrazivanja.ISTBAZERow,
    ByVal ta As String) As String
        If rowBaze Is Nothing Then rowBaze = crb
        Dim tn As String = ta.Trim
        tn = prfxt(tn)
        Dim sODBC As String = rowBaze.IzrazODBC.Trim.ToLower.Replace("provider=sqloledb.1;", "")

        Dim db As String = parametar_s(sODBC, "database")
        If db = "" Then
            db = parametar_s(sODBC, "initial catalog")
            If db = "" Then db = rowBaze.Baza.Trim
        End If
        tn = prfxt(tn)

        If Not crb Is rowBaze Then
            Dim provider As String = parametar_s(sODBC, "provider")
            If provider = "" Then provider = "SQLNCLI11" '
            tn = "OPENROWSET('" + provider + "','" + sODBC + "'," + tn + ")"
        End If
        Return tn
    End Function

    Private Function parametar_s(ByVal connectionString As String, ByVal parameter As String) As String
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

    Dim jezik As String

    'Public Sub New(ByVal s2 As String, ByVal b2 As DatasetIstrazivanja.ISTBAZERow, ByVal t As DatasetIstrazivanja.ISTLKDataTable, ByVal g As MyDataGridControl.MyDataGrid,
    '               ByVal p As System.Windows.Forms.ProgressBar, ByVal bb As Boolean, ByVal vv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal jezik As String)

    '    Me.jezik = jezik
    '    Call SetLang()

    '    DBConnectionString = s2
    '    mrb = b2
    '    mtip = t
    '    mvlk = New System.Data.DataView(mtip, "", mtip.TABELAColumn.ColumnName, System.Data.DataViewRowState.CurrentRows)
    '    mprog = p
    '    mvt = vv
    '    s = CType(mtip.Rows(0), DatasetIstrazivanja.ISTLKRow).SIFIST

    '    gr = g
    '    If Not bb Then
    '        Dim cs(ds.Tables(1).Columns.Count - 1) As System.Data.DataColumn
    '        Dim i As Integer = 0
    '        For Each c As System.Data.DataColumn In ds.Tables(1).Columns
    '            cs(i) = c
    '            i = i + 1
    '        Next
    '        gr.MyAppendTableStyle(ds.Tables(1).TableName, cs, cs, Nothing)
    '    End If

    '    ds.Tables(0).DefaultView.AllowNew = False
    '    ds.Tables(1).DefaultView.AllowNew = False

    '    ds.Tables(0).TableName = "[" + dgGrid21 + "]"
    '    ds.Tables(1).TableName = "[" + dgGrid22 + "]"
    '    ds.Relations.Item(0).RelationName = "[" + dgGrid23 + "]"

    '    Call imenaKolona4(ds.Tables(1))

    '    ds.Tables(1).DefaultView.RowFilter = "[" + dgGrid17 + "]" + ">0"
    '    ds.Tables(1).DefaultView.Sort = "[" + dgGrid17 + "]" + " desc"
    '    ds.DataSetName = dgGrid20
    '    gr.DataSource = ds

    'End Sub
    Public Sub New(ByVal s2 As String, ByVal b2 As DatasetIstrazivanja.ISTBAZERow, ByVal t As DatasetIstrazivanja.ISTLKDataTable, ByVal g As DataGridView,
                   ByVal p As System.Windows.Forms.ProgressBar, ByVal bb As Boolean, ByVal vv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal jezik As String,
                   Optional ByVal gT As DataGridView = Nothing, Optional ByVal gG As DataGridView = Nothing)

        Me.jezik = jezik
        Call SetLang()

        DBConnectionString = s2
        mrb = b2
        mtip = t
        mvlk = New System.Data.DataView(mtip, "", mtip.TABELAColumn.ColumnName, System.Data.DataViewRowState.CurrentRows)
        mprog = p
        mvt = vv
        s = CType(mtip.Rows(0), DatasetIstrazivanja.ISTLKRow).SIFIST

        If Not g Is Nothing Then
            gr = g
            If Not bb Then
                Dim cs(ds.Tables(1).Columns.Count - 1) As System.Data.DataColumn
                Dim i As Integer = 0
                For Each c As System.Data.DataColumn In ds.Tables(1).Columns
                    cs(i) = c
                    i = i + 1
                Next
                ' gr.MyAppendTableStyle(ds.Tables(1).TableName, cs, cs, Nothing)
            End If
        Else
            grT = gT
            grG = gG
        End If


        ds.Tables(0).DefaultView.AllowNew = False
        ds.Tables(1).DefaultView.AllowNew = False

        ds.Tables(0).TableName = "[" + dgGrid21 + "]"
        ds.Tables(1).TableName = "[" + dgGrid22 + "]"
        ds.Relations.Item(0).RelationName = "[" + dgGrid23 + "]"

        Call imenaKolona4(ds.Tables(1))

        ds.Tables(1).DefaultView.RowFilter = "[" + dgGrid17 + "]" + ">0"
        ds.Tables(1).DefaultView.Sort = "[" + dgGrid17 + "]" + " desc"
        ds.DataSetName = dgGrid20

        If Not g Is Nothing Then
            gr.DataSource = ds
        Else
            gT.DataSource = ds.Tables(0)
            gG.DataSource = ds.Tables(1)
        End If


    End Sub

    Dim dgGrid1 As String
    Dim dgGrid2 As String
    Dim dgGrid3 As String
    Dim dgGrid4 As String
    Dim dgGrid5 As String
    Dim dgGrid6 As String
    Dim dgGrid7 As String
    Dim dgGrid8 As String
    Dim dgGrid9 As String
    Dim dgGrid10 As String
    Dim dgGrid11 As String
    Dim dgGrid12 As String
    Dim dgGrid13 As String
    Dim dgGrid14 As String
    Dim dgGrid15 As String
    Dim dgGrid16 As String
    Dim dgGrid17 As String
    Dim dgGrid18 As String
    Dim dgGrid19 As String
    Dim dgGrid20 As String
    Dim dgGrid21 As String
    Dim dgGrid22 As String
    Dim dgGrid23 As String
    Dim dgGrid24 As String
    Dim dgGrid25 As String

    Sub imenaKolona2(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("sifist") Is Nothing Then dgDT.Columns("sifist").ColumnName = dgGrid6
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = dgGrid7
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = dgGrid8
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = dgGrid9
        If Not dgDT.Columns("USLOV") Is Nothing Then dgDT.Columns("USLOV").ColumnName = dgGrid10
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = dgGrid11
        If Not dgDT.Columns("tezina") Is Nothing Then dgDT.Columns("tezina").ColumnName = dgGrid12
        If Not dgDT.Columns("LK") Is Nothing Then dgDT.Columns("LK").ColumnName = dgGrid13
    End Sub

    Sub imenaKolona4(ByVal dgDT As System.Data.DataTable)
        If Not dgDT.Columns("tabela") Is Nothing Then dgDT.Columns("tabela").ColumnName = dgGrid7
        If Not dgDT.Columns("RbrGreske") Is Nothing Then dgDT.Columns("RbrGreske").ColumnName = dgGrid8
        If Not dgDT.Columns("Slogova") Is Nothing Then dgDT.Columns("Slogova").ColumnName = dgGrid17
        If Not dgDT.Columns("GRESKA") Is Nothing Then dgDT.Columns("GRESKA").ColumnName = dgGrid9
        If Not dgDT.Columns("NazivGreske") Is Nothing Then dgDT.Columns("NazivGreske").ColumnName = dgGrid11
        If Not dgDT.Columns("akcija") Is Nothing Then dgDT.Columns("akcija").ColumnName = dgGrid19
    End Sub

    Private Sub SetLang()
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "LogickaKontrola")
        '****GRIDOVI
        Me.dgGrid1 = getControlText2(dt, "dgGrid1", Me.jezik)
        Me.dgGrid2 = getControlText2(dt, "dgGrid2", Me.jezik)
        Me.dgGrid3 = getControlText2(dt, "dgGrid3", Me.jezik)
        Me.dgGrid4 = getControlText2(dt, "dgGrid4", Me.jezik)
        Me.dgGrid5 = getControlText2(dt, "dgGrid5", Me.jezik)
        Me.dgGrid6 = getControlText2(dt, "dgGrid6", Me.jezik)
        Me.dgGrid7 = getControlText2(dt, "dgGrid7", Me.jezik)
        Me.dgGrid8 = getControlText2(dt, "dgGrid8", Me.jezik)
        Me.dgGrid9 = getControlText2(dt, "dgGrid9", Me.jezik)
        Me.dgGrid10 = getControlText2(dt, "dgGrid10", Me.jezik)
        Me.dgGrid11 = getControlText2(dt, "dgGrid11", Me.jezik)
        Me.dgGrid12 = getControlText2(dt, "dgGrid12", Me.jezik)
        Me.dgGrid13 = getControlText2(dt, "dgGrid13", Me.jezik)
        Me.dgGrid14 = getControlText2(dt, "dgGrid14", Me.jezik)
        Me.dgGrid15 = getControlText2(dt, "dgGrid15", Me.jezik)
        Me.dgGrid16 = getControlText2(dt, "dgGrid16", Me.jezik)
        Me.dgGrid17 = getControlText2(dt, "dgGrid17", Me.jezik)
        Me.dgGrid18 = getControlText2(dt, "dgGrid18", Me.jezik)
        Me.dgGrid19 = getControlText2(dt, "dgGrid19", Me.jezik)
        Me.dgGrid20 = getControlText2(dt, "dgGrid20", Me.jezik)
        Me.dgGrid21 = getControlText2(dt, "dgGrid21", Me.jezik)
        Me.dgGrid22 = getControlText2(dt, "dgGrid22", Me.jezik)
        Me.dgGrid23 = getControlText2(dt, "dgGrid23", Me.jezik)
        Me.dgGrid24 = getControlText2(dt, "dgGrid24", Me.jezik)
        Me.dgGrid25 = getControlText2(dt, "dgGrid25", Me.jezik)
    End Sub

    Public ReadOnly Property dtname() As String
        Get
            Return ds.Tables(1).TableName
        End Get
    End Property

    Public Sub LK2(ByVal sTab As String, ByVal posebnatabela As String)
        posebnatabela = posebnatabela.Trim.ToUpper
        If Not mprog Is Nothing Then
            mprog.Visible = True
            mprog.Value = mprog.Minimum
            mprog.Maximum = mtip.Rows.Count
            mprog.Step = mprog.Maximum \ 20
            If mprog.Step = 0 Then mprog.Step = 1
        End If
        ds.Clear()
        ds.AcceptChanges()
        Try
            Dim t2 As String = ""
            Dim ss As String = ""
            Dim rv As System.Data.DataRowView
            For Each rv In Me.mvlk
                Dim r As DatasetIstrazivanja.ISTLKRow
                r = CType(rv.Row, DatasetIstrazivanja.ISTLKRow)
                Dim tab As String = r.TABELA.Trim.ToUpper
                If posebnatabela = "" OrElse posebnatabela = tab Then
                    If r.Item("USLOV").GetType Is GetType(System.DBNull) OrElse r.Item("USLOV").Trim = "" OrElse r.Item("USLOV").Trim.ToUpper.indexof("LKVELIKA") >= 0 OrElse r.Item("USLOV").Trim.ToUpper.indexof("EXECUTEONLYFROMDATAVALIDATIONMODULE") >= 0 Then
                        Me.LK3(sTab, tab, r.RbrGreske, t2, ss)
                        If Not Me.mprog Is Nothing Then
                            Me.mprog.Value += 1
                            Me.mprog.Refresh()
                        End If
                    End If

                End If
            Next
            Me.LK3(sTab, "", "", t2, ss)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not Me.mprog Is Nothing Then
                Me.mprog.Visible = False
            End If
        End Try


        If Not gr Is Nothing Then
            If posebnatabela <> "" Then
                gr.DataMember = ds.Tables(1).TableName
                'ds.Tables(1).DefaultView.RowFilter = ds.Greske.TabelaColumn.ColumnName + "='" + posebnatabela + "'"
                ds.Tables(1).DefaultView.RowFilter = dgGrid7 + "='" + posebnatabela + "'"
            Else
                gr.DataMember = ""
                'gr.Expand(-1)
                ds.Tables(1).DefaultView.RowFilter = ""
            End If
        Else
            If posebnatabela <> "" Then
                grG.DataMember = ds.Tables(1).TableName
                ds.Tables(1).DefaultView.RowFilter = dgGrid7 + "='" + posebnatabela + "'"
            Else
                grG.DataMember = ""
                ds.Tables(1).DefaultView.RowFilter = ""
            End If
        End If


    End Sub
    Public Sub AKuzLK(ByVal sTab As String, ByVal posebnatabela As String, ByVal mrist As DatasetIstrazivanja.ISTRow, Optional ByVal GreskaPoGreska As Boolean = False, Optional ByVal txtmode As String = "")

        Dim red As System.Data.DataRow
        Dim dss As New System.Data.DataTable
        dss = ds.Tables(1).Copy
        For Each red In dss.Rows
            If CType(CType(red.Item(dgGrid19), Object), String).Trim.Length > 0 AndAlso CType(CType(red.Item(dgGrid19), Object), String).Trim.Substring(0, 1).ToUpper = "#" Then
                Dim folderZaGen As String = ""
                If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                    folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper
                Else
                    folderZaGen = Me.mrist.TxtDir.Trim
                End If

                Dim sf As String = mrist.TxtDir.Trim + "\" + red.Item(dgGrid19).ToString.Trim.Substring(1, red.Item(dgGrid19).ToString.Trim.Length - 1)
                Dim sr As New System.IO.StreamReader(sf)
                Dim sql As String = ""
                'procitaj ak.... odradi..........izvrsi akciju!!!!!
                'prvo ZAMENA!!!!!
                Try
                    While sr.Peek() >= 0
                        Dim l As String = sr.ReadLine().Trim
                        'zamena
                        sql = strrpl(sql, "{GGG}", "'" + mvt.G.ToString + "'")
                        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", mvt.M) + "'")
                        sql = strrpl(sql, "{YYY}", "'" + mvt.G.ToString + "'")

                        sql = GGMMGoreDole(sql, mvt.G, mvt.M)
                        sql = strrpl(sql, "VRTACKA", mvt.vtwhere(""))
                        sql = strrpl(sql, "GGG", mvt.GWhere(""))
                        sql = strrpl(sql, "MMM", mvt.mWhere(""))
                        sql = strrpl(sql, "YYY", mvt.YWhere(""))

                        sql = sql.Replace(Microsoft.VisualBasic.ChrW(26), "")
                        sql = ZameniVodVdo(sql, mvt)
                        sql = pu(Nothing, String.Empty, sql)
                        ''
                        sql = sql + " " + l
                    End While

                    Try
                        Dim trtDS As New System.Data.DataSet
                        trtDS = izvrsiSQLvratiDS(sql, Me.DBConnectionString, Nothing)
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Finally
                    sr.Close()
                End Try
            End If
        Next
    End Sub

    Public Sub puniGrid(ByVal sTab As String, ByVal posebnatabela As String)
        posebnatabela = posebnatabela.Trim
        If Not mprog Is Nothing Then
            mprog.Visible = True
            mprog.Value = mprog.Minimum
            mprog.Maximum = mtip.Rows.Count
            mprog.Step = mprog.Maximum \ 20
            If mprog.Step = 0 Then mprog.Step = 1
        End If
        ds.Clear()
        ds.AcceptChanges()
        Try
            Dim t2 As String = ""
            Dim ss As String = ""
            Dim rv As System.Data.DataRowView
            For Each rv In Me.mvlk
                Dim r As DatasetIstrazivanja.ISTLKRow
                r = CType(rv.Row, DatasetIstrazivanja.ISTLKRow)
                Dim tab As String = r.TABELA.Trim
                If posebnatabela = "" OrElse posebnatabela = tab Then
                    Me.puniDSGreske(sTab, tab, r.RbrGreske, t2, ss)
                    If Not Me.mprog Is Nothing Then
                        Me.mprog.Value += 1
                        Me.mprog.Refresh()
                    End If
                End If
            Next
            Me.puniDSGreske(sTab, "", "", t2, ss)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not Me.mprog Is Nothing Then
                Me.mprog.Visible = False
            End If
        End Try

        'If posebnatabela <> "" Then
        '    gr.DataMember = ds.Tables(1).TableName
        '    ds.Tables(1).DefaultView.RowFilter = dgGrid7 + "='" + posebnatabela + "'"
        'Else
        '    gr.DataMember = ""
        '    'da se u gridu prikazu svi redovi gr.expand(-1)
        '    gr.Expand(-1)
        '    ds.Tables(1).DefaultView.RowFilter = ""
        'End If

        If Not gr Is Nothing Then
            If posebnatabela <> "" Then
                gr.DataMember = ds.Tables(1).TableName
                'ds.Tables(1).DefaultView.RowFilter = ds.Greske.TabelaColumn.ColumnName + "='" + posebnatabela + "'"
                ds.Tables(1).DefaultView.RowFilter = dgGrid7 + "='" + posebnatabela + "'"
            Else
                gr.DataMember = ""
                'gr.Expand(-1)
                ds.Tables(1).DefaultView.RowFilter = ""
            End If
        Else
            If posebnatabela <> "" Then
                grG.DataMember = ds.Tables(1).TableName
                ds.Tables(1).DefaultView.RowFilter = dgGrid7 + "='" + posebnatabela + "'"
            Else
                grG.DataMember = ""
                ds.Tables(1).DefaultView.RowFilter = ""
            End If
        End If


    End Sub

    Private Sub puniDSGreske(ByVal sTab As String, ByVal tt As String, ByVal sc As String, ByRef pt As String, ByRef ss As String)
        Dim str As String = ""
        If pt <> tt AndAlso pt <> "" Then
            Dim tn As String = uzmisqltab(Me.mrb, Nothing, pt)
            str = "select count(*) as Slogova,sum(isnull(cast (INDGR as int),0)) as Neispravnih," + ss + " from " + tn + " where 1=1"
            If sTab <> "" Then str += " and " + sTab

            Dim v As String = Me.mvt.vWhere(tn, "", Me.DBConnectionString)
            If v <> "" Then str += " and " + v

            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(str, DBConnectionString, Me.jezik)
            Dim r As System.Data.DataRow = dt.Rows(0)
            ds.Tables(0).Rows.Add(New Object() {pt, r.ItemArray(0), r.ItemArray(1)})
            Dim i As Integer = 0
            While i < dt.Columns.Count
                If Not r.IsNull(i) Then
                    Dim errCount As Long = CLng(r.Item(i))
                    If errCount = 0 Then
                        dt.Columns.RemoveAt(i)
                        i -= 1
                    End If
                End If
                i += 1
            End While
            For i = 2 To dt.Columns.Count - 1
                Dim rLK As DatasetIstrazivanja.ISTLKRow
                rLK = Me.mtip.FindBySIFISTTABELARbrGreske(s, pt, dt.Columns(i).ColumnName)
                Dim items() As Object = {pt, dt.Columns(i).ColumnName, r.ItemArray(i), rLK.Item(Me.mtip.GRESKAColumn.Ordinal), rLK.Item(Me.mtip.NazivGreskeColumn.Ordinal), rLK.Item(Me.mtip.AkcijaColumn.Ordinal)}
                'ako nije Slogova prazno (znaci da nema gresaka) i ako postoji akcija
                If Not items(2) Is System.DBNull.Value Then
                    If Not items(5) Is System.DBNull.Value Then
                        ds.Tables(1).Rows.Add(items)
                    End If
                End If
            Next
            Dim dcc As System.Data.DataColumn = New System.Data.DataColumn(dgGrid25, System.Type.GetType("System.Boolean"))

            dcc.DefaultValue = False
            If ds.Tables(1).Columns.Count = 6 Then
                ds.Tables(1).Columns.Add(dcc)
                'inace vec dodato
            End If

            dt.Dispose()
            ss = ""
        End If
        If ss <> "" Then
            ss += ","
        End If
        ss += "sum(isnull(cast (" + sc.Trim + " as int),0)) as " + sc.Trim
        pt = tt
    End Sub

    Public Sub AK(ByVal sTab As String, ByVal posebnatabela As String, ByVal mrist As DatasetIstrazivanja.ISTRow,
        ByVal izabrano As String, ByVal akcija As String,
        Optional ByVal GreskaPoGreska As Boolean = False, Optional ByVal txtmode As String = "")

        Dim sf As String
        Dim red As System.Data.DataRow
        Dim dss As New System.Data.DataTable
        dss = ds.Tables(1).Copy
        For Each red In dss.Rows
            If CType(CType(red.Item(izabrano), Object), Boolean) = True Then
                Dim folderZaGen As String = ""
                If txtmode.IndexOf("Z") = 0 OrElse txtmode.IndexOf("ZCAPI") = 0 Then
                    folderZaGen = GetTXTDir() + CStr(mrist.SIFIST).Trim.ToUpper
                Else
                    folderZaGen = Me.mrist.TxtDir.Trim
                End If
                If CType(CType(red.Item(akcija), Object), String).Trim.Substring(0, 1).ToUpper = "#" Then
                    sf = folderZaGen + "\" + red.Item(akcija).ToString.Trim.Substring(1, red.Item(akcija).ToString.Trim.Length - 1)
                Else
                    sf = folderZaGen + "\" + red.Item(akcija).ToString
                End If

                Dim sr As New System.IO.StreamReader(sf)
                Dim sql As String = ""
                'procitaj ak.... odradi..........izvrsi akciju!!!!!
                'prvo ZAMENA!!!!!

                Try
                    While sr.Peek() >= 0
                        Dim linija As String = sr.ReadLine().Trim
                        sql = sql + " " + linija

                        sql = strrpl(sql, "{GGG}", "'" + mvt.G.ToString + "'")
                        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", mvt.M) + "'")
                        sql = strrpl(sql, "{YYY}", "'" + mvt.G.ToString + "'")

                        sql = GGMMGoreDole(sql, mvt.G, mvt.M)
                        sql = strrpl(sql, "VRTACKA", mvt.vtwhere(""))
                        sql = strrpl(sql, "GGG", mvt.GWhere(""))
                        sql = strrpl(sql, "MMM", mvt.mWhere(""))
                        sql = strrpl(sql, "YYY", mvt.YWhere(""))

                        sql = sql.Replace(Microsoft.VisualBasic.ChrW(26), "")
                        sql = ZameniVodVdo(sql, mvt)
                        sql = pu(Nothing, String.Empty, sql)
                        ''
                    End While

                    Try
                        Dim trtDS As New System.Data.DataSet
                        trtDS = izvrsiSQLvratiDS(sql, Me.DBConnectionString, Nothing)
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Catch ex As System.Exception
                    ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    sr.Close()
                End Try
            End If
        Next
    End Sub



    Public Function gindex(
      ByVal t As String,
      ByVal i2 As Integer,
      ByVal st As String,
      ByVal et As String) As Integer
        Dim i As Integer = i2
        i += st.Length
        Dim tf As Integer = 1
        While tf > 0 AndAlso i < t.Length
            If t.IndexOf(st, i, st.Length) >= 0 Then
                tf += 1
                i += st.Length
            ElseIf t.IndexOf(et, i, et.Length) >= 0 Then
                tf -= 1
                If tf = 0 Then
                    Return i
                End If
                i += et.Length
            Else : i += 1
            End If
        End While
        Return -1
    End Function

    Private Function xf(ByVal k As DatasetIstrazivanja.ISTLKRow, ByVal nf As String, ByVal p As String) As String
        xf = ""
        Dim fn As String = nf.Trim.ToUpper
        Select Case fn
            Case String.Empty
                Return p
            Case "VODVDO"
                Return Me.mvt.vWhere(String.Empty, p, String.Empty)
            Case Else
                ISTMessageBox.Show("Error as function xf", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Function

    Public Function pu(
    ByVal k As DatasetIstrazivanja.ISTLKRow,
    ByVal nf As String,
    ByVal tf As String) As String
        Dim it As Integer = tf.IndexOf("#")
        Dim idz As Integer = -1
        Dim rz As String = String.Empty
        While it >= 0
            rz += tf.Substring(idz + 1, it - idz - 1)
            Dim ilz As Integer = tf.IndexOf("{", it + 1)
            If ilz < 0 Then
                Throw New System.Exception("Error")
            End If
            idz = gindex(tf, ilz, "{", "}")
            If idz < 0 Then
                Throw New System.Exception("Error")
            End If
            Dim nf2 As String = tf.Substring(it + 1, ilz - it - 1)
            Dim tf2 As String = tf.Substring(ilz + 1, idz - ilz - 1)
            rz += pu(k, nf2, tf2)
            it = tf.IndexOf("#", idz + 1)
        End While
        rz += tf.Substring(idz + 1)
        If nf <> String.Empty Then
            rz = xf(k, nf, rz)
        End If
        Return rz.Trim
    End Function


    Private Function ZameniVodVdo(ByVal ss As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka) As String
        Dim s As String = ss.Trim
        Dim sss As String = ss.Trim.ToUpper
        Dim gde As Integer = sss.IndexOf("#VODVDO{")
        While gde >= 0
            Dim doklen As Integer = s.IndexOf("}", gde + 6)
            Dim sta As String = s.Substring(gde, doklen - gde + 1)
            Dim p As String = ""
            If sta.Length > 9 Then p = sta.Substring(8, sta.Length() - 9).Trim
            s = strrpl(s, sta, vt.vWhere("", p, ""))
            sss = s.ToUpper
            gde = sss.IndexOf("#VODVDO{")
        End While
        Return s
    End Function

    Private Function pReplace(ByVal ss As String, ByVal Sta As String, ByVal SuCim As String) As String
        Dim s As String = ss
        Dim oklen As Integer = 0
        Dim GdeSam As Integer = s.ToLower.IndexOf(Sta.ToLower, oklen)
        While GdeSam >= 0
            Dim pre As Integer = GdeSam - 1
            Dim iza As Integer = GdeSam + Sta.Length()
            Dim cp As Char = " "
            If pre >= 0 Then cp = CType(s.Substring(pre, 1), Char)
            Dim ci As Char = " "
            If iza < s.Length() Then ci = CType(s.Substring(iza, 1), Char)
            If (Not Char.IsLetterOrDigit(cp)) And Not (Char.IsLetterOrDigit(ci)) Then
                s = s.Substring(0, pre + 1) & "'" & SuCim & "'" & s.Substring(GdeSam + Sta.Length())
                oklen += SuCim.Length() + 2
            End If
            GdeSam = s.ToLower.IndexOf(Sta.ToLower, oklen)
        End While
        Return s
    End Function

    'Private Sub gr_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gr.DataSourceChanged
    '    gr.MyAutoFit(ds.Tables(0).TableName, True)
    '    gr.MyAutoFit_FitWidth(ds.Tables(1).TableName)
    'End Sub

End Class