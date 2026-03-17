
Imports System.Data
Imports System.Data.SqlClient
Partial Class AddressBook
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim t As New Template
    Dim connIST As String = b.GetConnStr("connIST")
    Dim conn As String = b.GetConnStr("conn")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Sub Page_Load(ByVal Src As Object, ByVal E As EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then 'crtam se prvi put
                If (Session("NALOG") <> Nothing AndAlso Session("NALOG") <> "") Then
                    'b.SetLabels(Page, Session("izabranJezik"), connIST)
                    
                    popuniDDLGOD()
                    popuniDDLTIP()
                    
                    trnslt_backButton.OnClientClick = "document.getElementById('ModalLoader').style.display = 'block';"
                Else    'NEMA ROLU
                    Response.Redirect("Default.aspx")
                    HttpContext.Current.ApplicationInstance.CompleteRequest()
                End If

            Else
                Dim myMasterPage As MasterPage = TryCast(Me.Master, MasterPage)
                If myMasterPage IsNot Nothing Then
                    AddHandler myMasterPage.MasterPageDDLChanged, AddressOf MasterPageDDLChanged
                End If

            End If 'Not IsPostBack
        Catch ex As Exception
            'Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
            Dim errorMsg As String = ex.Message & "-" & ex.StackTrace
        Finally
        End Try
    End Sub

    Sub loadStrane()
        Session("ROLA") = "1"
        Session("office") = "KGZ"
        Session("god") = "2025"
        Session("IDReg") = "1"

        Dim maintable As String = getMainTable()

        Session("maintable") = maintable
        Dim ssql As String = ""
        Dim DBConnectionString As String = ""
        Dim dkp As String = ""
        Dim vtvt As String = Session("gg") + "-" + String.Format("{0:d2}", Session("mm")) + "-01" '"2023-10-01"
        Dim appcode As String = Session("appcode")
        Dim dsISTTabele As DataSet
        Dim strSQLISTTabele As String = "exec usp_WebLKRelacija @vt='" + vtvt + "',@sifIST=N'" + appcode.Trim + "', @tabela=N'" + Session("maintable") + "' , @IDLang=N'" + Session("izabranJezik") + "'"
        dsISTTabele = b.DajDS_IzUpita(strSQLISTTabele, connIST, Session("Country"))
        Dim pkR As String = ""
        Dim pkRD As String = ""

        If dsISTTabele.Tables.Count > 0 AndAlso dsISTTabele.Tables(0).Rows.Count > 0 Then
            Dim drT As DataRow
            drT = dsISTTabele.Tables(0).Rows(0)
            If Session("ROLA") = "6" Then
                ssql = drT.Item("ssqlRola6").ToString
            ElseIf Session("ROLA") = "3" Then

                If Session("office") = "KGZ" Then
                    ssql = drT.Item("ssqlRola3KGZ").ToString   ' drT.Item("ssqlRola3KGZ").ToString - doraditi kad se vidi gde je njima korespodentna tabela
                End If
                If Session("office") = "RZS" Then
                    ssql = drT.Item("ssqlRola3").ToString
                End If

            ElseIf Session("ROLA") = "1" Then
                ssql = drT.Item("ssqlRola1").ToString
                If Session("office") = "KGZ" Then
                    ssql = Replace(ssql.Trim, "SessionK_PRED", "'" + Session("okpo").ToString.Trim + "'", 1, , CompareMethod.Text)
                    Session.Add("columnsToRemove", drT.Item("T").ToString)
                End If
                If Session("office") = "RZS" Then
                    pkR = drT.Item("pkR").ToString
                    pkRD = drT.Item("pkRD").ToString
                    Dim pp() As String = pkR.Split(",")
                    Dim ppD() As String = pkRD.Split(",")
                    Dim kppD As Integer = 0
                    Dim odkppD As Integer = 0
                    For i As Integer = 0 To pp.GetUpperBound(0)
                        If Session(pp(i).Trim) Is Nothing Then
                            For k As Integer = 0 To ppD.GetUpperBound(0)
                                odkppD = kppD
                                Dim ppPom() As String = ppD(k).Trim.Split("=")
                                If ppPom(0).Trim.ToUpper = pp(i).Trim.ToUpper Then
                                    If IsNumeric(ppPom(1).Trim) Then
                                        kppD = ppPom(1).Trim
                                        odkppD = odkppD + 1
                                    End If
                                    Exit For
                                End If
                            Next
                            Session(pp(i).Trim) = Mid(Request.QueryString.Item("Kljuc"), odkppD, kppD)
                        End If
                        ssql = Replace(ssql.Trim, "Session" + pp(i).Trim, "'" + Session(pp(i).Trim) + "'", 1, , CompareMethod.Text)
                    Next
                End If
            End If

            ssql = t.replaceYYYMMMUser(ssql, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
            DBConnectionString = drT.Item("DBConnectionString").ToString
            dkp = drT.Item("pkT").ToString
        End If


        Dim dk() As String = dkp.Split(",")
        gvCatalog.DataKeyNames = dk

        Dim strSQlG As String = ssql

        Session.Add("strSQlG", strSQlG)
        Session.Add("DBConnectionString", DBConnectionString)
        bindGV(gvCatalog, strSQlG, DBConnectionString).ToString()
        'gvCatalog.Visible = True
    End Sub

    Private Sub CheckSessions()
        If Context.Session IsNot Nothing Then
            If Session.IsNewSession Then
                Dim cookieHeader = Request.Headers("Cookie")
                If (Not String.IsNullOrEmpty(cookieHeader)) AndAlso cookieHeader.IndexOf("ASP.NET_SessionId") >= 0 Then
                    Throw New ArgumentNullException("Session", "Session expired.")
                    'Response.Redirect("~/Default.aspx")
                End If
            End If
        End If
    End Sub

    Private Sub MasterPageDDLChanged(sender As Object, e As EventArgs)
        ' Reset or handle changes to the DDL in the content page
        ResetPeriod()
        popuniDDLTIP()
        'bindGV(gvCatalog, "")
        bindGV(gvCatalog, Session("strSQlG"), Session("DBConnectionString")).ToString()

        'postavi dal se vidi grid ili ne
    End Sub

    Private Sub ResetPeriod()
        DDLTIP.SelectedIndex = -1
        DDLMES.SelectedIndex = -1
        DDLKVA.SelectedIndex = -1
    End Sub

    Protected Sub gvAddressBook_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        If e.CommandName = "Select" Then
            'Determine the RowIndex of the Row whose Button was clicked.
            Dim rowIndex As Integer = Convert.ToInt32(e.CommandArgument)

            'Reference the GridView Row.
            Dim row As GridViewRow = gvCatalog.Rows(rowIndex)

            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "hideLoaderScript", "document.getElementById('ModalLoader').style.display = 'none';", True)
        End If
    End Sub

    Protected Sub gvAddressBook_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles gvCatalog.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            For i = 0 To e.Row.Cells.Count - 2
                Dim cell2 As TableCell = e.Row.Cells(i + 1)
                Dim a1 As DataRowView = DirectCast(e.Row.DataItem, System.Data.DataRowView)
                If Session("columnsToRemove") IsNot Nothing AndAlso Session("columnsToRemove") <> "" Then
                    Dim columnsToRemove = Session("columnsToRemove").ToString.Split(",")
                    For l = 0 To columnsToRemove.Count - 1
                        If a1.DataView.Table.Columns.Item(i).ColumnName = columnsToRemove(l) Then
                            cell2.Visible = False
                            gvCatalog.HeaderRow.Cells(i + 1).Visible = False
                        End If
                    Next

                    For l = 0 To gvCatalog.DataKeyNames.Count - 1
                        If a1.DataView.Table.Columns.Item(i).ColumnName.ToUpper() = gvCatalog.DataKeyNames(l) Then
                            cell2.Visible = False
                            gvCatalog.HeaderRow.Cells(i + 1).Visible = False
                        End If
                    Next
                End If
            Next
            ' Assuming the first column is a ButtonField
            Dim selectButton As LinkButton = DirectCast(e.Row.Cells(0).Controls(0), LinkButton)
            selectButton.Text = b.SetError(Session("dsErrors"), Session("IzabranJezik"), "izaberi")

            Dim button As LinkButton = CType(e.Row.Cells(0).Controls(0), LinkButton) ' Adjust the cell index as necessary
            button.OnClientClick = "document.getElementById('ModalLoader').style.display = 'block';" ' Prevents postback if needed return false;
        End If
    End Sub

    Function getMainTable() As String
        getMainTable = ""
        Dim vtvt As String = Session("gg").ToString + "-" + String.Format("{0:d2}", Session("mm")) + "-01" '"2023-10-01"
        Dim appcode As String = Session("appcode")
        Dim dsISTTabele As DataSet
        Dim strSQLISTTabele As String = "exec usp_WebLocationsTablesNew @vt='" + vtvt + "',@sifIST=N'" + appcode.Trim + "',@IDLANG=N'" + Session("izabranjezik") + "'"
        dsISTTabele = b.DajDS_IzUpita(strSQLISTTabele, connIST, Session("Country"))

        If dsISTTabele.Tables.Count > 0 Then
            Dim drT As DataRow()
            drT = dsISTTabele.Tables(0).Select("DG='G'")
            If drT.Count > 0 Then getMainTable = drT(0).Item("tabela").ToString

        End If
        Return getMainTable
    End Function

    Protected Sub popuniDDLTIP()
        'Session("gg") = Date.Today.Year.ToString
        Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", connIST, Session("Country"))
        Session("dsErrors") = dsErrors

        Dim parts As String() = Session("pkInitSUR").Split("/")
        Dim sifist As String = parts(0)
        Dim okpo As String = parts(2)
        Session("okpo") = okpo
        Session("appcode") = sifist

        Dim txtmes As String = b.SetError(Session("dsErrors"), Session("izaberiJezik"), "mesecno")
        Dim txtgod As String = b.SetError(Session("dsErrors"), Session("izaberiJezik"), "godisnje")
        Dim txtkva As String = b.SetError(Session("dsErrors"), Session("izaberiJezik"), "kvartalno")
        Dim txtpgod As String = b.SetError(Session("dsErrors"), Session("izaberiJezik"), "polugodisnje")

        Dim query = "SELECT periodika FROM IST WHERE sifist = '" + sifist + "'"

        Dim ds As DataSet = b.DajDS_IzUpita(query, connIST, Session("Country"))
        Dim periodika As String = ds.Tables(0).Rows(0).Item("periodika")
        Dim periodikaTranslation As String = periodika

        If periodika.Contains("M") Then
            periodikaTranslation = periodikaTranslation.Replace("M", txtmes)
        End If
        If periodika.Contains("Y") Then
            periodikaTranslation = periodikaTranslation.Replace("Y", txtgod)
        End If
        If periodika.Contains("Q") Then
            periodikaTranslation = periodikaTranslation.Replace("Q", txtkva)
        End If
        If periodika.Contains("H") Then
            periodikaTranslation = periodikaTranslation.Replace("H", txtpgod)
        End If

        Dim splitText() As String
        Dim splitValue() As String

        splitText = periodikaTranslation.Split(",")
        splitValue = periodika.Split(",")

        Dim dataSet As New DataSet()
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("DataText", GetType(String))
        dataTable.Columns.Add("DataValue", GetType(String))
        dataSet.Tables.Add(dataTable)

        For i As Integer = 0 To splitText.Length - 1
            Dim row As DataRow = dataTable.NewRow()
            row("DataText") = splitText(i)
            row("DataValue") = splitValue(i)
            dataTable.Rows.Add(row)
        Next

        'KONVERT SIFRE PERIODA U NAZIVE + PREVOD
        DDLTIP.DataSource = dataSet.Tables(0)
        DDLTIP.DataTextField = "DataText"
        DDLTIP.DataValueField = "DataValue"
        DDLTIP.DataBind()

        If splitValue.Length = 1 Then
            If splitValue(0).ToString = "Y" Then
                panelAdresar.Visible = True
                'bindGV(gvCatalog, "")

                Session("mm") = "12"
                Session("TIP") = "Y"
                loadStrane()
                bindGV(gvCatalog, Session("strSQlG"), Session("DBConnectionString")).ToString()
            Else
                DDLTIP.SelectedValue = splitValue(0).ToString
                DDLTIP_SelectedIndexChanged(DDLTIP, Nothing)
            End If
        Else
            contKvartal.Visible = False
            contMesec.Visible = False
        End If

        DDLTIP.Items.Insert(0, New ListItem("--", ""))
        If DDLTIP.Items.Count = 2 Then
            DDLTIP.SelectedIndex = 1
        End If
    End Sub

    Protected Sub popuniDDLMES(tip As String)

        Dim splitValue() As String
        If tip = "M" Then
            splitValue = {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"}
        ElseIf tip = "H" Then
            splitValue = {"06"}
        End If

        DDLMES.DataSource = splitValue
        DDLMES.DataBind()

        DDLMES.Items.Insert(0, New ListItem("--", ""))
        DDLMES.SelectedIndex = 0
    End Sub

    Protected Sub popuniDDLGOD()

        Dim currentYear As Integer = DateTime.Now.Year
        Session("gg") = currentYear.ToString
        For i As Integer = 0 To 4
            DDLGOD.Items.Add(New ListItem((currentYear - i).ToString(), (currentYear - i).ToString()))
        Next

    End Sub

    '***************MIRIN DEO********************
    Sub gvCatalog_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvCatalog.SelectedIndexChanged
        Dim dk() As String = gvCatalog.DataKeyNames
        Dim keysDict As New Dictionary(Of String, String)
        Dim index As Integer = gvCatalog.SelectedIndex
        Dim row As GridViewRow = gvCatalog.Rows(index)
        For i As Integer = 0 To dk.GetUpperBound(0)
            keysDict.Add(dk(i), gvCatalog.DataKeys(gvCatalog.SelectedRow.RowIndex)(i).ToString())
        Next
        keysDict.Add("PERIOD", Session("TIP").ToString)
        Session.Add("companyname", row.Cells.Item(3).[Text])
        Session("dk") = dk
        Session("keysDict") = keysDict
        Dim url As String = "MainTable.aspx"
        Response.Redirect(url)
    End Sub
    Protected Sub gvCatalog_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs) Handles gvCatalog.Sorting
        Dim gv As GridView = DirectCast(sender, GridView)
        Dim gvDS As DataSet = Session("gvDS")
        Dim dt As DataTable = gvDS.Tables(0)
        If dt IsNot Nothing Then
            dt.DefaultView.Sort = e.SortExpression & " " & GetSortDirection(e.SortExpression)
            gvCatalog.DataSource = dt.DefaultView
            gvCatalog.DataBind()
        End If

    End Sub

    Public Function bindGV(ByVal gv As GridView, ByVal str As String, ByVal DBCOnnectionString As String) As Integer 'poveze grid i vrati broj redova
        Dim gvDS As DataSet
        If DBCOnnectionString.Contains("ZSZ") Then DBCOnnectionString = DBCOnnectionString.Replace("ZSZ", "14TORG")
        If DBCOnnectionString.Contains("imt2") Then DBCOnnectionString = DBCOnnectionString.Replace("imt2", "172.16.18.20")
        gvDS = b.DajDS_IzUpita(str, DBCOnnectionString, Session("Country"))
        If gvDS.Tables.Count = 0 Then
            Dim dtData As New DataTable()
            dtData.Columns.Add(New DataColumn("..."))
            gvCatalog.DataKeyNames = {"..."}
            gvDS.Tables.Add(dtData)
        End If
        If gvDS.Tables(0).Rows.Count > 0 Then
            gv.DataSource = gvDS
            Session("gvDS") = gvDS
            gv.DataBind()
            bindGV = gvDS.Tables(0).Rows.Count   'broj redova
        Else
            BezRedova(gvDS.Tables(0), gv)
            bindGV = 0
        End If

        'End If
    End Function
    Protected Sub BezRedova(ByVal source As DataTable, ByVal gv As GridView)
        source.Rows.Add(source.NewRow())
        gv.DataSource = source
        gv.DataBind()

        Dim columnsCount As Integer = gv.Columns.Count

        gv.Rows(0).Cells.Clear()
        gv.Rows(0).Cells.Add(New TableCell())
        gv.Rows(0).Cells(0).ColumnSpan = columnsCount
        gv.Rows(0).Cells(0).HorizontalAlign = HorizontalAlign.Center
        gv.Rows(0).Cells(0).ForeColor = System.Drawing.Color.Red
        gv.Rows(0).Cells(0).Font.Bold = True
        'gv.Rows(0).Cells(0).Text = "Nema slogova"
        gv.Rows(0).Cells(0).Text = b.SetLabel(Session("izabranJezik"), connIST, "noRows", Session("Country"))

    End Sub

    Sub gvCatalog_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvCatalog.PageIndexChanging
        If e.NewPageIndex <> -1 Then
            gvCatalog.PageIndex = e.NewPageIndex
             bindGV(gvCatalog, Session("strSQlG"), Session("DBConnectionString")).ToString()
            
        End If
    End Sub
    Private Function GetSortDirection(ByVal column As String) As String

        Dim sortDirection = "ASC"
        Dim sortExpression = TryCast(ViewState("SortExpression"), String)

        If sortExpression IsNot Nothing Then
            If sortExpression = column Then
                Dim lastDirection = TryCast(ViewState("SortDirection"), String)
                If lastDirection IsNot Nothing _
                  AndAlso lastDirection = "ASC" Then
                    sortDirection = "DESC"
                End If
            End If
        End If

        ViewState("SortDirection") = sortDirection
        ViewState("SortExpression") = column
        Return sortDirection

    End Function
    '***********************************

    Protected Sub DDLTIP_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim selValue = DirectCast(sender, ListControl).SelectedValue
        Dim tip As String = ""
        DDLKVA.SelectedIndex = 0

        If selValue = "M" Then
            contMesec.Visible = True
            contKvartal.Visible = False
            panelAdresar.Visible = False
            tip = "M"
            popuniDDLMES(tip)
        ElseIf selValue = "H" Then
            contMesec.Visible = True
            contKvartal.Visible = False
            panelAdresar.Visible = False
            tip = "H"
            popuniDDLMES(tip)
        ElseIf selValue = "Q" Then
            contMesec.Visible = False
            contKvartal.Visible = True
            panelAdresar.Visible = False
            tip = "Q"
        ElseIf selValue = "Y" Then
            contMesec.Visible = False
            contKvartal.Visible = False
            Session("mm") = "12"
            tip = "Y"
            loadStrane()
            'bindGV(gvCatalog, "")
            'bindGV(gvCatalog, Session("strSQlG"), Session("DBConnectionString)")).ToString()
            gvCatalog.Visible = True
            panelAdresar.Visible = True
        ElseIf selValue = "" Then
            contMesec.Visible = False
            contKvartal.Visible = False
            panelAdresar.Visible = False
        End If

        If DDLMES.Items.Count > 0 Then
            DDLMES.SelectedIndex = 0
        End If

        Session("TIP") = tip

    End Sub

    Protected Sub DDLGOD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLGOD.SelectedIndexChanged
        Session("gg") = DirectCast(sender, ListControl).SelectedValue.ToString
        ResetPeriod()
        panelAdresar.Visible = False
        popuniDDLTIP()
        'bindGV(gvAddressBook, "")
        'gvAddressBook.Visible = True
        'panelAdresar.Visible = True
    End Sub

    Protected Sub DDLMES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLMES.SelectedIndexChanged
        Session("mm") = DirectCast(sender, ListControl).SelectedValue
        'bindGV(gvCatalog, "")
        'bindGV(gvCatalog, Session("strSQlG"), Session("DBConnectionString)")).ToString()
        loadStrane()
        gvCatalog.Visible = True
        panelAdresar.Visible = True
    End Sub

    Protected Sub DDLKVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DDLKVA.SelectedIndexChanged
        Session("KVA") = DirectCast(sender, ListControl).SelectedValue
        If Session("KVA") = "--" Then
            Session("mm") = 0
        ElseIf Session("KVA") = 1 Then
            Session("mm") = "03"
        ElseIf Session("KVA") = 2 Then
            Session("mm") = "06"
        ElseIf Session("KVA") = 3 Then
            Session("mm") = "09"
        ElseIf Session("KVA") = 4 Then
            Session("mm") = "12"
            'Else
            '    Session("mm") = 0
        End If


        'bindGV(gvCatalog, Session("strG")).ToString()
        'bindGV(gvCatalog, Session("strSQlG"), Session("DBConnectionString)")).ToString()
        loadStrane()
        gvCatalog.Visible = True
        panelAdresar.Visible = True
    End Sub

    Private Sub trnslt_backButton_Click(sender As Object, e As EventArgs) Handles trnslt_backButton.Click
        Response.Redirect("Surveys.aspx")
    End Sub
End Class
