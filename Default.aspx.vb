Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualBasic.Logging
Partial Class _Default
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connISTWeb As String = b.GetConnStr("connISTWEB")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("Country") = "KGZ"
        If Not IsPostBack Then
            Session.Remove("NALOG")
            trnslt_Nalog.Value = Nothing
            If Session("izabranJezik") Is Nothing Then
                If Session("Country") = "KGZ" Then
                    Session("izabranJezik") = "RUS"
                ElseIf Session("Country") = "SRB" Then
                    'nema label na srpskom
                    Session("izabranJezik") = "RUS"
                End If

            End If
            b.SetLabels(Page, Session("izabranJezik"), connIST, Session("Country"))

        Else
            'izbrisi sve errore
            PorukaNeuspesno.Style("display") = "none"
        End If
    End Sub

    Protected Sub LoginButton_Click(Source As Object, E As EventArgs) Handles trnslt_LoginButton.Click

        Dim IdiUProgram As Integer = 0
        Dim Status As Boolean = False

        Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", connIST, Session("Country"))
        Session("dsErrors") = dsErrors
        If Page.IsValid Then

            Dim Nalog As String = Me.trnslt_Nalog.Value
            Dim Pass As String = trnslt_Lozinka.Value
            Dim Rola As String = ""
            Dim okpo As String = ""

            If Nalog = "" Or Pass = "" Then
                'Obavezno polje
                PorukaNeuspesno.InnerText = b.SetError(dsErrors, Session("izabranJezik"), "obaveznopolje")
                PorukaNeuspesno.Style("display") = "block"

                Exit Sub
            End If

            If Nalog <> "" And Pass <> "" Then
                Dim IDKOR = b.ProveraKOR(Trim(Nalog), Trim(Pass), "[ISTUsersWeb]", connISTWeb, Session("Country"))

                If IDKOR.userCode = 0 Then
                    'nema tog korisnika ili nije aktivan
                    LogPoruke.Visible = True
                    PorukaNeuspesno.InnerText = b.SetError(dsErrors, Session("izabranJezik"), "pogresankorisnik")
                    PorukaNeuspesno.Style("display") = "block"
                    'trnslt_ForgotPassword.Style("display") = "block"
                    Exit Sub
                ElseIf IDKOR.userCode = 1 Then
                    'sve kako treba
                    'provera da li je nalog admin/distric/respondent
                    Rola = IDKOR.Rola
                    okpo = IDKOR.okpo
                    IdiUProgram = 1
                End If
            End If

            'log
            'h.LOGArhivaPoljo(Session.SessionID.ToString, ipadresa(0), Browser, BrowserVersion, Me.Nalog.Value, Status)

            If IdiUProgram = 1 Then
                Session.Add("NALOG", okpo)
                Session.Add("uuser", Me.trnslt_Nalog.Value)
                Session.Add("RolaUser", Rola)
                Response.Redirect(ResolveClientUrl("~/Surveys.aspx"), False)
                'If Rola = "RES" Then
                '    Response.Redirect(ResolveClientUrl("~/Surveys.aspx"), False)
                'Else
                '    Response.Redirect(ResolveClientUrl("~/ADM/ADM_Home.aspx"), False)
                'End If
            End If
        End If
    End Sub

    'Protected Sub RegisterButton_click(sender As Object, e As EventArgs) Handles trnslt_RegisterButton.ServerClick
    '    Response.Redirect(ResolveClientUrl("~/Registration.aspx"), False)
    'End Sub
    Protected Sub ForgotPassword_Click(Source As Object, e As EventArgs) Handles trnslt_ForgotPassword.Click
        Response.Redirect(ResolveClientUrl("~/ProvideEmail.aspx"), False)
    End Sub
End Class

