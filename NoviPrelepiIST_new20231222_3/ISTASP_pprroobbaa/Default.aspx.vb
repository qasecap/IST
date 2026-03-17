
Partial Class _Default
    Inherits System.Web.UI.Page
    Sub Page_PreInit(ByVal sender As Object, ByVal e As EventArgs) Handles Me.PreInit
      
        Dim rola As String = ""
        Dim god As String
        Dim mes As String	
        Dim IDUser As String
        Dim IDIstrazivanje As String
	Dim MB As String
Dim KAPETANIJA As String



	'*************************************
        rola = "6" : Session("Rola") = rola
        god = "2022" : Session("God") = god
        mes = "12" : Session("Mes") = mes	
        IDUser = "1265" : Session("IDUser") = IDUser
        IDIstrazivanje = "SRM21" : Session("IDIstrazivanje") = IDIstrazivanje
        MB="17693476" : Session("MB")=MB
        KAPETANIJA = "11" : Session("KAPETANIJA")=KAPETANIJA

        '*************************************

        If not(Request.QueryString("Rola") Is Nothing) Then
    		rola = Request.QueryString("Rola")               
              	If Mid(rola, 1, 1) = "7" Or Mid(rola, 1, 1) = "8" Then
                	rola = "6"                	
            	End If
            	Session("Rola") = rola
            	'*************************************
            	'XXXX spoljniUserKojiTrebaDaVidiSVe
            	'If IDUser = "XXXX" Then rola = "6": Session("Rola") = rola
            	'*************************************          
        Elseif not(Session("Rola") Is Nothing) then
                rola = Session("Rola")
	Else
		Response.Redirect("http://pod2.stat.gov.rs/Unos/ADM_LogIn.aspx", False)
                HttpContext.Current.ApplicationInstance.CompleteRequest()
        End If
  	

        If not(Request.QueryString("God") Is Nothing) Then
    		god = Request.QueryString("God") 
                Session("God") = god
          
        Elseif not(Session("God") Is Nothing) then
                god = Session("God") 
	Else
		Response.Redirect("http://pod2.stat.gov.rs/Unos/ADM_LogIn.aspx", False)
                HttpContext.Current.ApplicationInstance.CompleteRequest()
        End If

        If not(Request.QueryString("Mes") Is Nothing) Then
    		mes= Request.QueryString("Mes") 
                Session("Mes") = mes
          
        Elseif not(Session("Mes") Is Nothing) then
                mes= Session("Mes") 
	Else
		Response.Redirect("http://pod2.stat.gov.rs/Unos/ADM_LogIn.aspx", False)
                HttpContext.Current.ApplicationInstance.CompleteRequest()
        End If

        If not(Request.QueryString("User") Is Nothing) Then
    		IDUser= Request.QueryString("User") 
                Session("IDUser") =IDUser
          
        Elseif not(Session("IDUser") Is Nothing) then
                IDUser= Session("IDUser") 
	Else
		Response.Redirect("http://pod2.stat.gov.rs/Unos/ADM_LogIn.aspx", False)
                HttpContext.Current.ApplicationInstance.CompleteRequest()
        End If

        If not(Request.QueryString("IDIstrazivanje") Is Nothing) Then
    		IDIstrazivanje= Request.QueryString("IDIstrazivanje") 
                Session("IDIstrazivanje") =IDIstrazivanje
          
        Elseif not(Session("IDIstrazivanje") Is Nothing) then
                IDIstrazivanje= Session("IDIstrazivanje") 
	Else
		Response.Redirect("http://pod2.stat.gov.rs/Unos/ADM_LogIn.aspx", False)
                HttpContext.Current.ApplicationInstance.CompleteRequest()
        End If
	
	If Session("MB") Is Nothing Then
     MB =Mid(Request.QueryString.Item("Kljuc"),1,8)
      Session("MB") = MB
Else
     MB = Session("MB")
End If
If Session("KAPETANIJA") Is Nothing Then
     KAPETANIJA =Mid(Request.QueryString.Item("Kljuc"),9,2)
      Session("KAPETANIJA") = KAPETANIJA
Else
     KAPETANIJA = Session("KAPETANIJA")
End If

        Me.MasterPageFile = "./MasterPageISTR1.master"

        'If rola = "1" Then
        '    Me.MasterPageFile = "./MasterPageISTR1.master"  
        'Else
        '    Me.MasterPageFile = "./MasterPageISTR3.master"
        'End If


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then
                If (Session("Rola") <> Nothing) Then                    
                    HttpContext.Current.ApplicationInstance.CompleteRequest()
                Else    'NEMA ROLU
                    Response.Redirect("http://pod2.stat.gov.rs/Unos/ADM_LogIn.aspx", False)
                    HttpContext.Current.ApplicationInstance.CompleteRequest()
                End If
            End If 'Not IsPostBack
        Catch ex As Exception
            Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
        Finally
        End Try
    End Sub
  

End Class

