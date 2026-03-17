
Imports System.Data

Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")
    Public Event MasterPageDDLChanged As EventHandler
    'Public WithEvents trnslt_settings As Global.System.Web.UI.WebControls.LinkButton

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Session.Add("Country","SRB")
        Try
            If Not IsPostBack Then    'crtam se prvi put
                If (Session("Nalog") <> Nothing) Then
                    Nalog.Text = Session("Nalog")
                    Nalog.Visible = True
                    If (Session("RolaUser").ToString.ToUpper = "ADMIN") Then
                        trnslt_options.Visible = True
                        
                    End If
                Else    'NEMA ROLU
                    Nalog.Text = ""
                    Nalog.Visible = False
                    trnslt_logout.Visible = False
                    trnslt_options.Visible = False
                End If
                PopuniDDLLang()
                'PopuniDDLSettings()
                b.SetLabels(Page, Session("izabranJezik"), connIST, Session("Country"))
            Else
            End If 'Not IsPostBack
        Catch ex As Exception
            'Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
        Finally
        End Try
    End Sub

    Protected Sub PopuniDDLLang()
        Dim query = "SELECT DISTINCT ltrim(rtrim(IDLang)) as IDLang FROM [ISTLabels] WHERE SIFIST = 'weblabel'"
        Dim languages As DataSet = b.DajDS_IzUpita(query, connIST, Session("Country"))

        DDLLang.DataSource = languages
        DDLLang.DataTextField = "IDLang"
        DDLLang.DataValueField = "IDLang"
        DDLLang.DataBind()

        If Session("Country") = "KGZ" Then
            DDLLang.SelectedValue = "RUS"
        ElseIf Session("Country") = "SRB" Then 
            'nema label na srpskom
            DDLLang.SelectedValue = "RUS"
        End If

        If Session("izabranJezik") Is Nothing Then
            Session.Add("izabranJezik", DDLLang.SelectedValue)
            'Session("izabranJezik") = DDLLang.SelectedValue
        Else
            DDLLang.SelectedValue = Session("izabranJezik").ToString.Trim
            Session.Add("izabranJezik", DDLLang.SelectedValue.ToString.Trim)
            'Session("izabranJezik") = DDLLang.SelectedValue.ToString.Trim
        End If
    End Sub

    Protected Sub DDLLang_selectedIndexChanged(sender As Object, e As EventArgs)
        Session.Add("izabranJezik", DDLLang.SelectedItem.Text.Trim)
        'Session("izabranJezik") = DDLLang.SelectedItem.Text.Trim
        b.SetLabels(Page, Session("izabranJezik"), connIST, Session("Country"))

        Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", connIST, Session("Country"))
        Session("dsErrors") = dsErrors

        RaiseEvent MasterPageDDLChanged(Me, EventArgs.Empty)
    End Sub

    Protected Sub DDLSettings_selectedIndexChanged(sender As Object, e As EventArgs)
        Session.Add("izabranJezik", DDLLang.SelectedItem.Text.Trim)
        'Session("izabranJezik") = DDLLang.SelectedItem.Text.Trim
        b.SetLabels(Page, Session("izabranJezik"), connIST, Session("Country"))

        Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", connIST, Session("Country"))
        Session("dsErrors") = dsErrors

        RaiseEvent MasterPageDDLChanged(Me, EventArgs.Empty)
    End Sub

    Public Sub Logout_Click(sender As Object, e As EventArgs) Handles trnslt_logout.Click
        Session.Remove("NALOG")
        Response.Redirect(ResolveClientUrl("~/Default.aspx"), False)
    End Sub

    Public Sub adm_app_Click(sender As Object, e As EventArgs) Handles trnslt_options.Click
        Dim okpo = Session("NALOG")
        Session("appcode") = "adminweb"
        Session("gg") = Year(Now).ToString
        Session("mm") = "03"
        Session("dk") = {"KPRED", "USERN"}
        Dim url As String = "MainTable.aspx?KPRED=" + okpo + "&USERN=''"
        Response.Redirect(url)
    End Sub
End Class

