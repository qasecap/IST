
Imports System.Data
Imports System.Net

Partial Class Verification
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Protected Sub Page_Load(sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim User As String = Request.QueryString("username")
        Dim lang As String = Request.QueryString("lang")

        If User Is Nothing OrElse lang Is Nothing Then
            'ne treba da prikaze stranu jer nema podataka direktnu stigao na ovu stranu?
            Response.Redirect(ResolveClientUrl("~/Default.aspx"), False)
        Else
            b.SetLabels(Page, lang, connIST, Session("Country"))

            Dim rezultat As String = b.UpisPromenaBrisanje("UPDATE ISTUsers SET VerifiedEmail=1 WHERE appUSER = '" + User + "';", connIST, Session("Country"))
            If rezultat = True Then
                'MsgBox("OK")
            Else
                'MsgBox("Fail")
            End If
        End If
    End Sub
End Class
