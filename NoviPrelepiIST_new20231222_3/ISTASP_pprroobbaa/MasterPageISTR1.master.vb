Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Partial Class MasterPageISTR1
    Inherits System.Web.UI.MasterPage
    Public strSQl As String
    Private Shared prevPage As String = String.Empty
    Dim b As New Base_IST_PPP



    Protected Sub lbUnosPODACI_SRM21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbUnosPODACI_SRM21.Click
        Me.Session("LastControl") = Nothing
        Me.Session("DynamicControls") = Nothing
        Dim url As String = "PODACI_SRM21.aspx?ODS=Default.aspx"
        Response.Redirect(url)
    End Sub


    Protected Sub lbKraj_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbKraj.Click
        Response.Redirect("http://pod2.stat.gov.rs/unos/ADM_LogIn.aspx", False)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then    'crtam se prvi put


        End If
    End Sub

End Class




