
Partial Class ErrorPage
    Inherits System.Web.UI.Page

    Private Sub backToDefault_Click(sender As Object, e As EventArgs) Handles backToDefault.Click
        Response.Redirect("Default.aspx")
    End Sub
End Class
