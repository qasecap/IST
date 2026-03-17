'Option Strict On
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text

Partial Class metodologija
    Inherits System.Web.UI.Page
    Dim b As New Base_IST_PPP()

    Protected Sub lbl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl1.Click
        Response.Redirect("doc/pWord.doc")
    End Sub
    Protected Sub lbl2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl2.Click
        Response.Redirect("doc/pExcel.xls")
    End Sub
    Protected Sub lbl3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl3.Click
        Response.Redirect("doc/pPDF.pdf")
    End Sub
    Protected Sub lbl4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl4.Click
        Response.Redirect("doc/doc.zip")
    End Sub
    Protected Sub lblUputstvoRola1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUputstvoRola1.Click
        Response.Redirect("doc/primerUputstva_rola1.doc")
    End Sub
    Protected Sub lblUputstvoRola3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUputstvoRola3.Click
        Response.Redirect("doc/primerUputstva_rola3.doc")
    End Sub
    Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreInit
        If (Session("Rola") <> Nothing) Then
            If Session("Rola") = "1" Then
                Me.MasterPageFile = "./MasterPageISTR1.master"
            Else
                Me.MasterPageFile = "./MasterPageISTR3.master"
            End If
        Else    'NEMA ROLU
            Response.Redirect("Default.aspx")
            HttpContext.Current.ApplicationInstance.CompleteRequest()
        End If
    End Sub
    Sub Page_Load(ByVal Src As Object, ByVal E As EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then    'crtam se prvi put
                If (Session("Rola") <> Nothing) Then
                    Call loadStrane()
                Else    'NEMA ROLU
                    Response.Redirect("Default.aspx")
                    HttpContext.Current.ApplicationInstance.CompleteRequest()
                End If

            End If 'Not IsPostBack
        Catch ex As Exception
            Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
        Finally
        End Try
    End Sub
    Sub loadStrane()
        ' u sesiji se nalaze: rola, IDUser, god, mes, kv, sed
        'koristi se sa: Session("god")       
        Me.lblKonekcija.Text = "Data Source=IMT2.statsrb.lan;Initial Catalog=SAOBRACAJ;User ID=IST_PPP;Password=Gilgames"    
    End Sub



End Class


