Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Partial Class MasterPageISTR3
    Inherits System.Web.UI.MasterPage
    Public strSQl As String
    Private Shared prevPage As String = String.Empty
    Dim b As New Base_IST_PPP

    Protected Sub lbIzbor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbIzbor.Click
        Dim url As String = "IzborUpitnikaZaUnos.aspx?ODS=Default.aspx"
	Call vrtackaUSesiju()
        Response.Redirect(url)
    End Sub

    '99biloNADTABELE99

    Protected Sub lbPregled_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbPregled.Click
        Dim url As String = "pregledUnetihSlogova.aspx?ODS=Default.aspx"
	Call vrtackaUSesiju()
        Response.Redirect(url)
    End Sub

    Protected Sub lbIzvestaji_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbIzvestaji.Click
        Dim url As String = "izvestaji.aspx?ODS=Default.aspx"
	Call vrtackaUSesiju()
        Response.Redirect(url)
    End Sub

    Protected Sub lbMO_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbMO.Click
        Dim url As String = "metodologija.aspx?ODS=Default.aspx"
	Call vrtackaUSesiju()
        Response.Redirect(url)
    End Sub

    Protected Sub lbKraj_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbKraj.Click
        Response.Redirect("http://pod2.stat.gov.rs/unos/ADM_LogIn.aspx", False)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then    'crtam se prvi put
            
                Dim imaG As Boolean = True
    if not Session("god") is nothing then Me.DDLGOD.Text=Session("god")
    Dim imaM As Boolean = True
    if not Session("mes") is nothing then Me.DDLMES.Text=Session("mes")
    Dim imaK As Boolean = False
    Me.lblKV.Visible = False
    Me.DDLKV.Visible = False

            Dim periodika as string="KV"

            If imaG Then If Not Session("god") Is Nothing Then Me.DDLGOD.Text = Session("god")
            If imaM Then If Not Session("mes") Is Nothing Then Me.DDLMES.Text = Session("mes")
            If imaK Then If Not Session("kv") Is Nothing Then Me.DDLMES.Text = Session("kv")

            Me.lblSED.Visible = False
            Me.DDLSED.Visible = False

            Dim gvds As New DataSet
            Dim kon As String = "Data Source=IMT2.statsrb.lan;Initial Catalog=SAOBRACAJ;User ID=IST_PPP;Password=Gilgames"
            Dim str As String = "select isnull(LEFT(max(GOD+mes),4),'') as god,isnull(RIGHT(max(GOD+mes),2),'') as mes from PODACI_SRM21 where LKWeb=1"
            gvds = b.DajDS_IzUpita(Str, kon)

            Dim pgod As String = ""
            Dim pmes As String = ""
            Dim pkv As String = ""
            Dim nLI As ListItem

           
            If gvds.Tables.Count > 0 AndAlso gvds.Tables(0).Rows.Count > 0 Then
                If imaG AndAlso imaM AndAlso gvds.Tables(0).Rows(0).Item("god").ToString.Trim <> "" _
                AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "12" Then
                    pgod = gvds.Tables(0).Rows(0).Item("god").ToString.Trim
                    DDLGOD.Items.Clear()
                    'daje tekucu godinu
                    nLI = New ListItem(pgod)
                    nLI.Selected = True
                    DDLGOD.Items.Add(nLI)
                End If
                If imaG AndAlso imaM AndAlso gvds.Tables(0).Rows(0).Item("god").ToString.Trim <> "" _
               AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim = "12" Then
                    pgod = gvds.Tables(0).Rows(0).Item("god").ToString.Trim
                    DDLGOD.Items.Clear()
                    'daje sledecu godinu
                    Dim t As String = IIf(CStr(CInt(pgod) + 1).ToString.Trim.Length = 1, "0" + CStr(CInt(pgod) + 1).ToString.Trim, CStr(CInt(pgod) + 1).ToString.Trim)
                    nLI = New ListItem(t)
                    DDLGOD.Items.Add(nLI)
                End If
                If imaG AndAlso imaM = False AndAlso imaK = False AndAlso gvds.Tables(0).Rows(0).Item("god").ToString.Trim <> "" Then
                    pgod = gvds.Tables(0).Rows(0).Item("god").ToString.Trim
                    DDLGOD.Items.Clear()
                    'daje sledecu godinu
                    Dim t As String = IIf(CStr(CInt(pgod) + 1).ToString.Trim.Length = 1, "0" + CStr(CInt(pgod) + 1).ToString.Trim, CStr(CInt(pgod) + 1).ToString.Trim)
                    nLI = New ListItem(t)
                    DDLGOD.Items.Add(nLI)
                End If
                If imaM AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "" _
                AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "10" _
                AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "11" _
                AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "12" Then
                    pmes = gvds.Tables(0).Rows(0).Item("mes").ToString.Trim
                    DDLMES.Items.Clear()
                    'daje sledeca 3 meseca
                    For i As Integer = 1 To 3
                        Dim t As String = IIf(CStr(CInt(pmes) + i).ToString.Trim.Length = 1, "0" + CStr(CInt(pmes) + i).ToString.Trim, CStr(CInt(pmes) + i).ToString.Trim)
                        nLI = New ListItem(t)
                        DDLMES.Items.Add(nLI)
                    Next
                End If
                If imaM AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "" _
                 AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim = "10" Then
                    pmes = gvds.Tables(0).Rows(0).Item("mes").ToString.Trim
                    DDLMES.Items.Clear()
                    'daje 11,12
                    nLI = New ListItem("11")
                    DDLMES.Items.Add(nLI)
                    nLI = New ListItem("12")
                    DDLMES.Items.Add(nLI)
                End If
                If imaM AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "" _
                AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim = "11" Then
                    pmes = gvds.Tables(0).Rows(0).Item("mes").ToString.Trim
                    DDLMES.Items.Clear()
                    'daje 12                  
                    nLI = New ListItem("12")
                    DDLMES.Items.Add(nLI)
                End If
                If imaM AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim <> "" _
                AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim = "12" Then
                    pmes = gvds.Tables(0).Rows(0).Item("mes").ToString.Trim
                    DDLMES.Items.Clear()
                    'daje 01,02,03                  
                    nLI = New ListItem("01")
                    DDLMES.Items.Add(nLI)
                    nLI = New ListItem("02")
                    DDLMES.Items.Add(nLI)
                    nLI = New ListItem("03")
                    DDLMES.Items.Add(nLI)
                End If
                If imaK AndAlso gvds.Tables(0).Rows(0).Item("kv").ToString.Trim <> "" Then
		    pgod = gvds.Tables(0).Rows(0).Item("god").ToString.Trim		
                    pkv = gvds.Tables(0).Rows(0).Item("kv").ToString.Trim
                    DDLKV.Items.Clear()
                    if CInt(pkv) < 4 then
                        Dim t As String = CStr(CInt(pkv) + 1).ToString.Trim
                        nLI = New ListItem(t)
                        DDLKV.Items.Add(nLI)

  			DDLGOD.Items.Clear()
                   	t=  CStr(CInt(pgod)).ToString.Trim
                    	nLI = New ListItem(t)
                    	DDLGOD.Items.Add(nLI)

		    elseIf  CInt(pkv) = 4 then
   			Dim t As String = "1"
                        nLI = New ListItem(t)
                        DDLKV.Items.Add(nLI)

  			DDLGOD.Items.Clear()
                    	'daje sledecu godinu
                    	t= CStr(CInt(pgod) + 1).ToString.Trim
                    	nLI = New ListItem(t)
                    	DDLGOD.Items.Add(nLI)
		    End if
                End If
            Else
                'nema nista zakljucano ide po defaultu
            End If

            'PERIODIKA PGOD IDE POSEBNO JER NIJE VEZANA ZA POLJA U PODACIMA
            'promeniti 06  u  03 i 12 u 09 ako je takva dinamika
            If periodika = "PGOD" Then
                DDLMES.Items.Clear()
                nLI = New ListItem("06")
                DDLMES.Items.Add(nLI)
                nLI = New ListItem("12")
                DDLMES.Items.Add(nLI)
            
            If gvds.Tables.Count > 0 AndAlso gvds.Tables(0).Rows.Count > 0 Then
                If imaG AndAlso imaM AndAlso gvds.Tables(0).Rows(0).Item("god").ToString.Trim <> "" _
                AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim = "12" Then
                    pgod = gvds.Tables(0).Rows(0).Item("god").ToString.Trim
                    DDLGOD.Items.Clear()
                    'daje sledecu godinu
                    Dim t As String = IIf(CStr(CInt(pgod) + 1).ToString.Trim.Length = 1, "0" + CStr(CInt(pgod) + 1).ToString.Trim, CStr(CInt(pgod) + 1).ToString.Trim)
                    nLI = New ListItem(t)
                    DDLGOD.Items.Add(nLI)
                    DDLMES.Items.Clear()
                    nLI = New ListItem("06")
                    DDLMES.Items.Add(nLI)
                End If
                If imaG AndAlso imaM AndAlso gvds.Tables(0).Rows(0).Item("god").ToString.Trim <> "" _
              AndAlso gvds.Tables(0).Rows(0).Item("mes").ToString.Trim = "06" Then
                    pgod = gvds.Tables(0).Rows(0).Item("god").ToString.Trim
                    DDLGOD.Items.Clear()
                    'daje tekucu godinu
                    Dim t As String = gvds.Tables(0).Rows(0).Item("god").ToString.Trim
                    nLI = New ListItem(t)
                    DDLGOD.Items.Add(nLI)
                    DDLMES.Items.Clear()
                    nLI = New ListItem("12")
                    DDLMES.Items.Add(nLI)
                End If
            End If
	End If
    	    If imaG Then If Not Session("god") Is Nothing Then Me.DDLGOD.Text = Session("god")
            If imaM Then If Not Session("mes") Is Nothing Then Me.DDLMES.Text = Session("mes")
            If imaK Then If Not Session("kv") Is Nothing Then Me.DDLMES.Text = Session("kv")
 	End If

    End Sub
    Sub vrtackaUSesiju()
        Session("god") = Me.DDLGOD.Text
        Session("mes") = Me.DDLMES.Text
        Session("kv") = Me.DDLKV.Text
        Session("sed") = Me.DDLSED.Text
    End Sub

    Protected Sub DDLGOD_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLGOD.SelectedIndexChanged
        vrtackaUSesiju()
    End Sub
    Protected Sub DDLMES_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLMES.SelectedIndexChanged
        vrtackaUSesiju()
    End Sub
    Protected Sub DDLKV_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLKV.SelectedIndexChanged
        vrtackaUSesiju()
    End Sub
    Protected Sub DDLSED_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DDLSED.SelectedIndexChanged
        vrtackaUSesiju()
    End Sub
End Class




