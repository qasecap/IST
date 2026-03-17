
Imports System.Data
Imports System.Diagnostics
Imports AjaxControlToolkit.AsyncFileUpload.Constants

Partial Class ADM_Home
    Inherits System.Web.UI.Page

    Dim b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Sub Page_Load(ByVal Src As Object, ByVal E As EventArgs) Handles Me.Load
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
                'If myMasterPage IsNot Nothing Then
                '    AddHandler myMasterPage.MasterPageDDLChanged, AddressOf MasterPageDDLChanged
                'End If
            End If 'Not IsPostBack
        Catch ex As Exception
            'Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
        Finally
        End Try
    End Sub

   

    

    Sub loadStrane()
       rola.Text = rola.Text + Session("Rola").ToString
    End Sub

    Protected Sub btnProcess_Click(sender As Object, e As EventArgs)
        ' Perform your synchronous server-side task here
        System.Threading.Thread.Sleep(3000)
        ' Hide the loader after the task is complete
        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "hideLoaderScript", "hideLoader();", True)
    End Sub

    

    
End Class
