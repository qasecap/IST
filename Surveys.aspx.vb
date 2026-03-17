
Imports System.Data
Imports System.Diagnostics
Imports AjaxControlToolkit.AsyncFileUpload.Constants

Partial Class Surveys
    Inherits System.Web.UI.Page

    Dim b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Sub Page_Load(ByVal Src As Object, ByVal E As EventArgs) Handles Me.Load
        '****************ZA TESTIRANJE**********************************
        'Session("NALOG") = "11111111"
        'Session("izabranJezik") = "SRL"
        'Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", connIST)
        'Session("dsErrors") = dsErrors
        '****************ZA TESTIRANJE**********************************
        Try
            If Not IsPostBack Then    'crtam se prvi put
                If (Session("NALOG") <> Nothing AndAlso Session("NALOG") <> "") Then
                    'b.SetLabels(Page, Session("izabranJezik"), connIST)
                    Call loadStrane()
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
            System.Diagnostics.Trace.TraceError("Surveys Page_Load error: " & ex.ToString())
        End Try
    End Sub

    Protected Sub gvSurveys_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        'If e.CommandName = "Select" Then
        '    ScriptManager.RegisterStartupScript(Me, Me.GetType(), "hideLoaderScript", "document.getElementById('ModalLoader').style.display = 'none';", True)
        'End If
    End Sub

    Protected Sub gvSurveys_RowDataBound(sender As Object, e As GridViewRowEventArgs) Handles gvSurveys.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            ' Assuming the first column is a ButtonField
            Dim selectButton As LinkButton = DirectCast(e.Row.Cells(0).Controls(0), LinkButton)
            selectButton.Text = b.SetError(Session("dsErrors"), Session("IzabranJezik"), "izaberi")

            Dim button As LinkButton = CType(e.Row.Cells(0).Controls(0), LinkButton) ' Adjust the cell index as necessary
            'button.OnClientClick = "document.getElementById('ModalLoader').style.display = 'block';" ' Prevents postback if needed return false;
        End If
    End Sub

    Sub loadStrane()
        'prikazi dodatne funkcije zavisnosti od role
        If Session("Rola") = "" Then
            Dim myMasterPage As MasterPage = TryCast(Me.Master, MasterPage)
            'myMasterPage.trnslt_settings.visible = true
            'Master.trnslt_settings.visible = true
        End If
        bindGV(gvSurveys).ToString()
        gvSurveys.Visible = True
    End Sub

    Private Sub MasterPageDDLChanged(sender As Object, e As EventArgs)
        bindGV(gvSurveys)
    End Sub

    Protected Sub btnProcess_Click(sender As Object, e As EventArgs)
        ' Perform your synchronous server-side task here
        System.Threading.Thread.Sleep(3000)
        ' Hide the loader after the task is complete
        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "hideLoaderScript", "hideLoader();", True)
    End Sub

    Public Function bindGV(ByVal gv As GridView) As Integer
        'Dim str As String = "SELECT sifist,naziv,periodika,okpo, (sifist+'/'+periodika+'/'+okpo) as keys FROM [ist].[dbo].ist As b INNER JOIN (SELECT * FROM [istweb].[dbo].vISTAPPUsersWeb WHERE okpo='" + Session("NALOG") + "') as a ON a.survayId=b.sifist"
        Dim str As String = "SELECT sifist,naziv,periodika,k_pred COLLATE Cyrillic_General_CI_AS as okpo, (sifist +'/'+periodika+'/'+k_pred COLLATE Cyrillic_General_CI_AS) as keys  FROM [ist].[dbo].ist As b INNER JOIN (SELECT * FROM [istweb].[dbo].vISTAPPUsersWeb WHERE k_pred='" + Session("NALOG") + "') as a ON a.forma=b.sifist"
        'Dim str As String = "SELECT sifist,naziv,periodika,okpo COLLATE Cyrillic_General_CI_AS as okpo, (sifist +'/'+periodika+'/'+okpo COLLATE Cyrillic_General_CI_AS) as keys  FROM [ist].[dbo].ist As b INNER JOIN (SELECT * FROM [istweb].[dbo].ISTAPPUsersWeb WHERE okpo='" + Session("NALOG") + "') as a ON a.survayid=b.sifist"
        Dim gvDS As DataSet = b.DajDS_IzUpita(str, connIST, Session("Country"))

        'treba dodati ako je admin da ima admin apps

        If gvDS.Tables.Count > 0 AndAlso gvDS.Tables(0).Rows.Count > 0 Then
            DirectCast(gvSurveys.Columns(1), BoundField).HeaderText = b.SetError(Session("dsErrors"), Session("izabranJezik"), "sifraistrazivanja")
            DirectCast(gvSurveys.Columns(2), BoundField).HeaderText = b.SetError(Session("dsErrors"), Session("izabranJezik"), "nazivistrazivanja")
            gv.DataKeyNames = {"sifist", "periodika", "okpo"}
            gv.DataSource = gvDS
            gv.DataBind()
            bindGV = gvDS.Tables(0).Rows.Count 'broj redova
            'sakrivena kolona sa kljucevima
            gv.Columns(1).Visible = False
            gv.Columns(3).Visible = False
        Else
            BezRedova(gvDS.Tables(0), gv)
            bindGV = 0
        End If
        Session.Add("gvSurveys", gvDS.Tables(0))
    End Function

    Protected Sub BezRedova(ByVal source As DataTable, ByVal gv As GridView)
        source.Rows.Add(source.NewRow())
        gv.DataSource = source
        gv.DataBind()

        '+ command column
        Dim columnsCount As Integer = source.Columns.Count + 1

        gv.Rows(0).Cells.Clear()
        gv.Rows(0).Cells.Add(New TableCell())
        gv.Rows(0).Cells(0).ColumnSpan = columnsCount
        gv.Rows(0).Cells(0).HorizontalAlign = HorizontalAlign.Center
        gv.Rows(0).Cells(0).ForeColor = System.Drawing.Color.Red
        gv.Rows(0).Cells(0).Font.Bold = True
        'gv.Rows(0).Cells(0).Text = "Nema slogova"
        gv.Rows(0).Cells(0).Text = b.SetLabel(Session("izabranJezik"), connIST, "noRows", Session("Country"))
    End Sub

    Sub gvCODEBOOK_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvSurveys.SelectedIndexChanged
        Dim index As Integer = gvSurveys.SelectedIndex
        Dim row As GridViewRow = gvSurveys.Rows(index)
        Dim value As String = ""
        Session.Add("survayName", row.Cells.Item(2).[Text])
        For i As Integer = 0 To gvSurveys.DataKeyNames.Length - 1
            If i > 0 Then value += "/"
            value += gvSurveys.DataKeys(index).Values(i).ToString()
        Next

        Session("pkInitSUR") = value
        Response.Redirect("AddressBook.aspx")
    End Sub

    Private Sub gvSurveys_PageIndexChanging(sender As Object, e As GridViewPageEventArgs) Handles gvSurveys.PageIndexChanging
        'bindGV(gvSurveys)

        If e.NewPageIndex <> -1 Then
            gvSurveys.PageIndex = e.NewPageIndex
            bindGV(gvSurveys)
        End If
    End Sub

    Private Function GetColumnIndexByName(row As GridViewRow, columnName As String) As Integer

        Dim columnIndex As Integer = 0

        For Each cell As DataControlFieldCell In row.Cells
            If TypeOf cell.ContainingField Is BoundField Then
                If CType(cell.ContainingField, BoundField).DataField.Equals(columnName) Then
                    Exit For
                End If
            End If

            columnIndex += 1
        Next

        Return columnIndex
    End Function
End Class
