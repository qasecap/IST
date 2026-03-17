'Option Strict On
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text


Partial Class IzborUpitnikaZaUnos
    Inherits System.Web.UI.Page
    Dim b As New Base_IST_PPP()

    Public Function bindGV(ByVal gv As GridView, ByVal str As String) As Integer
        'poveze grid i vrati broj redova
        Dim gvDS As DataSet

        'If IsNothing(Session("ID_Korisnika")) Then
        '    Response.Redirect("Login.aspx")
        'Else

        gvDS = b.DajDS_IzUpita(str, Me.lblKonekcija.Text)
        If gvDS.Tables(0).Rows.Count > 0 Then
            gv.DataSource = gvDS
            gv.DataBind()
            bindGV = gvDS.Tables(0).Rows.Count   'broj redova
        Else
            BezRedova(gvDS.Tables(0), gv)
            bindGV = 0
        End If
        Session.Add("gvKAPETANIJE", gvDS.Tables(0))
        'End If
    End Function
    Protected Sub BezRedova(ByVal source As DataTable, ByVal gv As GridView)
        source.Rows.Add(source.NewRow())
        gv.DataSource = source
        gv.DataBind()

        Dim columnsCount As Integer = gv.Columns.Count

        gv.Rows(0).Cells.Clear()
        gv.Rows(0).Cells.Add(New TableCell())
        gv.Rows(0).Cells(0).ColumnSpan = columnsCount
        gv.Rows(0).Cells(0).HorizontalAlign = HorizontalAlign.Center
        gv.Rows(0).Cells(0).ForeColor = System.Drawing.Color.Red
        gv.Rows(0).Cells(0).Font.Bold = True
        gv.Rows(0).Cells(0).Text = "Nema slogova"

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
    Sub vrtackaIzSesije()
    	    TK_GOD.Text=Session("god")
    TK_MES.Text=Session("mes")
 
    	'AKO JE ZA ISTRAZIVANJE VRTACKA KVARTAL ILI SEDMICA OVO JE MESTO GDE TREBA TO DODATI 
    	'imepoljaKvartal.Text=Session("kv") 
    	'imepoljaSedmica.Text=Session("sed")   
    End Sub
    Sub loadStrane()
	Me.lblKonekcija.Text = "Data Source=IMT2.statsrb.lan;Initial Catalog=SAOBRACAJ;User ID=IST_PPP;Password=Gilgames"  
	Call vrtackaIzSesije()
  
        Me.TK_GOD.Enabled = False
        Me.TK_MES.Enabled = False


        'strSQLGLAVNA="sql upit ili procedura ....."

 	Dim strSQlG As String =""

        If Session("ROLA") = "6" Then

        strSQlG = "" + _
        " select distinct ADRREL.Kapetanija, ADRREL.nKapetanija, " + _
        " case when isnull(PODACI_SRM21.god,'')='' then 0 else 1 end as [Унето] " + _
        " from KAPETANIJE ADRREL Left Join " + _
        " (select GOD,MES,SIF,KAPETA,REDBRJ from PODACI_SRM21 where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "') PODACI_SRM21 on  ADRREL.Kapetanija=PODACI_SRM21.KAPETA where  2=2" + _
        " order by [Унето]"

        End If

        If Session("ROLA") = "1" orElse Session("ROLA") = "3" Then

         strSQlG = "" + _
        " select distinct ADRREL.Kapetanija, ADRREL.nKapetanija, " + _
        " case when isnull(PODACI_SRM21.god,'')='' then 0 else 1 end as [Унето] " + _
        " from KAPETANIJE ADRREL Left Join " + _
        " (select GOD,MES,SIF,KAPETA,REDBRJ from PODACI_SRM21 where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "') PODACI_SRM21 on  ADRREL.Kapetanija=PODACI_SRM21.KAPETA  inner join" + _
        " (select SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 11, 2) as Kapetanija,SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 9, 2) as Kapetanija from Veza_KljucUserIstrazivanje " + _
        " where IDIstrazivanje='" + Session("IDIstrazivanje") + "' and Veza_KljucUserIstrazivanje.IDUser ='" + Session("IDUser") + "') VEZA" + _
        " on  ADRREL.Kapetanija=VEZA.Kapetanija " + _
        " where  2=2" + _
        " order by [Унето]"

        End If

       
        Session.Add("strG", strSQlG)
        Session.Add("sort", " asc")
        bindGV(gvKAPETANIJE, Session("strG")).ToString()
        gvKAPETANIJE.Visible = True
    End Sub
    Protected Sub OnRowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
         
	    Dim Kapetanija As String =gvKAPETANIJE.DataKeys(e.Row.RowIndex)(0).ToString()
	 
      
        End If
    End Sub
  Sub gvKAPETANIJE_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvKAPETANIJE.SelectedIndexChanged

        Dim Kapetanija As String =gvKAPETANIJE.DataKeys(gvKAPETANIJE.SelectedRow.RowIndex)(0).ToString()

        Dim str As String = String.Format("KAPETA={0}", Kapetanija)
        Me.Session("LastControl") = Nothing
        Me.Session("DynamicControls") = Nothing
        Dim url As String = "PODACI_SRM21.aspx?" + str + "&ODS=IzbUp"
        Response.Redirect(url)

    End Sub

	Sub gvKAPETANIJE_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvKAPETANIJE.PageIndexChanging
        If e.NewPageIndex <> -1 Then
            gvKAPETANIJE.PageIndex = e.NewPageIndex
            bindGV(gvKAPETANIJE, Session("strG")).ToString()
        End If
    End Sub

    Protected Sub gvKAPETANIJE_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs) Handles gvKAPETANIJE.Sorting

        Dim dt = TryCast(Session("gvKAPETANIJE"), DataTable)
        If dt IsNot Nothing Then
            dt.DefaultView.Sort = e.SortExpression & " " & GetSortDirection(e.SortExpression)
            gvKAPETANIJE.DataSource = dt.DefaultView
            gvKAPETANIJE.DataBind()
        End If

    End Sub


    Private Function GetSortDirection(ByVal column As String) As String

        Dim sortDirection = "ASC"
        Dim sortExpression = TryCast(ViewState("SortExpression"), String)

        If sortExpression IsNot Nothing Then
            If sortExpression = column Then
                Dim lastDirection = TryCast(ViewState("SortDirection"), String)
                If lastDirection IsNot Nothing _
                  AndAlso lastDirection = "ASC" Then
                    sortDirection = "DESC"
                End If
            End If
        End If

        ViewState("SortDirection") = sortDirection
        ViewState("SortExpression") = column
        Return sortDirection

    End Function
  
  Protected Sub lbtnPretraga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtnPretraga.Click
        If rbMbr.Checked Then
            Call PretraziMBR()
        ElseIf rbNaziv.Checked Then
            Call PretraziNaziv()
        End If
    End Sub
    Protected Sub lbtnPonistavanjePretrage_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbtnPonistavanjePretrage.Click
        txtPretraga.Text = String.Empty
        rbMbr.Checked = True
        rbNaziv.Checked = False
        Call loadStrane()
    End Sub
    Sub PretraziMBR()
        Dim vred As String = Me.txtPretraga.Text.Trim
        Dim pom As String = "(ADRREL.MBR like N'%" & vred & "%')" 

 	Dim strSQlG As String =""

        If Session("ROLA") = "6" Then

        strSQlG = "" + _
        " select distinct ADRREL.Kapetanija, ADRREL.nKapetanija, " + _
        " case when isnull(PODACI_SRM21.god,'')='' then 0 else 1 end as [Унето] " + _
        " from KAPETANIJE ADRREL Left Join " + _
        " (select GOD,MES,SIF,KAPETA,REDBRJ from PODACI_SRM21 where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "') PODACI_SRM21 on  ADRREL.Kapetanija=PODACI_SRM21.KAPETA " + _
	" where  2=2 AND " + pom + _
        " order by [Унето]"

        End If

        If Session("ROLA") = "1" orElse Session("ROLA") = "3" Then

         strSQlG = "" + _
        " select distinct ADRREL.Kapetanija, ADRREL.nKapetanija, " + _
        " case when isnull(PODACI_SRM21.god,'')='' then 0 else 1 end as [Унето] " + _
        " from KAPETANIJE ADRREL Left Join " + _
        " (select GOD,MES,SIF,KAPETA,REDBRJ from PODACI_SRM21 where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "') PODACI_SRM21 on  ADRREL.Kapetanija=PODACI_SRM21.KAPETA  inner join" + _
        " (select SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 11, 2) as Kapetanija,SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 9, 2) as Kapetanija from Veza_KljucUserIstrazivanje " + _
        " where IDIstrazivanje='" + Session("IDIstrazivanje") + "' and Veza_KljucUserIstrazivanje.IDUser ='" + Session("IDUser") + "') VEZA" + _
        " on  ADRREL.Kapetanija=VEZA.Kapetanija " + _
	" where  2=2 AND " + pom + _
        " order by [Унето]"

        End If

       
        Session.Add("strG", strSQlG)
        Session.Add("sort", " asc")
        bindGV(gvKAPETANIJE, Session("strG")).ToString() 
   
  
    End Sub

    Sub PretraziNaziv()
      Dim strSQlG As String =""

        Dim vredCir As String = konverzijaLatCir(Me.txtPretraga.Text.Trim)
        Dim vredLat As String = konverzijaCirLat(Me.txtPretraga.Text.Trim)
        Dim pom As String = "((ADRREL.nazivFirme like N'%" & vredCir & "%')" & " OR " & "(ADRREL.nazivFirme like N'%" & vredLat & "%'))"
	
        If Session("ROLA") = "6" Then

        strSQlG = "" + _
        " select distinct ADRREL.Kapetanija, ADRREL.nKapetanija, " + _
        " case when isnull(PODACI_SRM21.god,'')='' then 0 else 1 end as [Унето] " + _
        " from KAPETANIJE ADRREL Left Join " + _
        " (select GOD,MES,SIF,KAPETA,REDBRJ from PODACI_SRM21 where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "') PODACI_SRM21 on  ADRREL.Kapetanija=PODACI_SRM21.KAPETA " + _
        " where  2=2 AND " + pom + _
        " order by [Унето]"

        End If

        If Session("ROLA") = "1" orElse Session("ROLA") = "3" Then

         strSQlG = "" + _
        " select distinct ADRREL.Kapetanija, ADRREL.nKapetanija, " + _
        " case when isnull(PODACI_SRM21.god,'')='' then 0 else 1 end as [Унето] " + _
        " from KAPETANIJE ADRREL Left Join " + _
        " (select GOD,MES,SIF,KAPETA,REDBRJ from PODACI_SRM21 where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "') PODACI_SRM21 on  ADRREL.Kapetanija=PODACI_SRM21.KAPETA  inner join" + _
        " (select SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 11, 2) as Kapetanija,SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 9, 2) as Kapetanija from Veza_KljucUserIstrazivanje " + _
        " where IDIstrazivanje='" + Session("IDIstrazivanje") + "' and Veza_KljucUserIstrazivanje.IDUser ='" + Session("IDUser") + "') VEZA" + _
        " on  ADRREL.Kapetanija=VEZA.Kapetanija " + _
        " where  2=2 AND " + pom + _
        " order by [Унето]"

        End If

       
        Session.Add("strG", strSQlG)
        Session.Add("sort", " asc")
        bindGV(gvKAPETANIJE, Session("strG")).ToString() 
    End Sub
 Public Shared Function konverzijaLatCir(ByVal naziv As String) As String
        naziv = Replace(naziv, "Dž", "Џ")
        naziv = Replace(naziv, "DŽ", "Џ")
        naziv = Replace(naziv, "Đ", "Ђ")
        naziv = Replace(naziv, "Ž", "Ж")
        naziv = Replace(naziv, "Ć", "Ћ")
        naziv = Replace(naziv, "Č", "Ч")
        naziv = Replace(naziv, "Š", "Ш")
        naziv = Replace(naziv, "Lj", "Љ")
        naziv = Replace(naziv, "LJ", "Љ")
        naziv = Replace(naziv, "Nj", "Њ")
        naziv = Replace(naziv, "NJ", "Њ")

        naziv = Replace(naziv, "dž", "џ")
        naziv = Replace(naziv, "đ", "ђ")
        naziv = Replace(naziv, "ž", "ж")
        naziv = Replace(naziv, "ć", "ћ")
        naziv = Replace(naziv, "č", "ч")
        naziv = Replace(naziv, "š", "ш")
        naziv = Replace(naziv, "lj", "љ")
        naziv = Replace(naziv, "nj", "њ")

        naziv = Replace(naziv, "A", "А")
        naziv = Replace(naziv, "B", "Б")
        naziv = Replace(naziv, "V", "В")
        naziv = Replace(naziv, "G", "Г")
        naziv = Replace(naziv, "D", "Д")
        naziv = Replace(naziv, "E", "Е")
        naziv = Replace(naziv, "Z", "З")
        naziv = Replace(naziv, "I", "И")
        naziv = Replace(naziv, "J", "Ј")
        naziv = Replace(naziv, "K", "К")
        naziv = Replace(naziv, "L", "Л")
        naziv = Replace(naziv, "M", "М")
        naziv = Replace(naziv, "N", "Н")
        naziv = Replace(naziv, "O", "О")
        naziv = Replace(naziv, "P", "П")
        naziv = Replace(naziv, "R", "Р")
        naziv = Replace(naziv, "S", "С")
        naziv = Replace(naziv, "T", "Т")
        naziv = Replace(naziv, "U", "У")
        naziv = Replace(naziv, "F", "Ф")
        naziv = Replace(naziv, "H", "Х")
        naziv = Replace(naziv, "C", "Ц")

        naziv = Replace(naziv, "a", "а")
        naziv = Replace(naziv, "b", "б")
        naziv = Replace(naziv, "v", "в")
        naziv = Replace(naziv, "g", "г")
        naziv = Replace(naziv, "d", "д")
        naziv = Replace(naziv, "e", "е")
        naziv = Replace(naziv, "z", "з")
        naziv = Replace(naziv, "i", "и")
        naziv = Replace(naziv, "j", "ј")
        naziv = Replace(naziv, "k", "к")
        naziv = Replace(naziv, "l", "л")
        naziv = Replace(naziv, "m", "м")
        naziv = Replace(naziv, "n", "н")
        naziv = Replace(naziv, "o", "о")
        naziv = Replace(naziv, "p", "п")
        naziv = Replace(naziv, "r", "р")
        naziv = Replace(naziv, "s", "с")
        naziv = Replace(naziv, "t", "т")
        naziv = Replace(naziv, "u", "у")
        naziv = Replace(naziv, "f", "ф")
        naziv = Replace(naziv, "h", "х")
        naziv = Replace(naziv, "c", "ц")
        Return naziv
    End Function
    Public Shared Function konverzijaCirLat(ByVal naziv As String) As String
        naziv = Replace(naziv, "Џ", "Dž")
        naziv = Replace(naziv, "Ђ", "Đ")
        naziv = Replace(naziv, "Ж", "Ž")
        naziv = Replace(naziv, "Ћ", "Ć")
        naziv = Replace(naziv, "Ч", "Č")
        naziv = Replace(naziv, "Ш", "Š")
        naziv = Replace(naziv, "Љ", "Lj")
        naziv = Replace(naziv, "Њ", "Nj")

        naziv = Replace(naziv, "џ", "dž")
        naziv = Replace(naziv, "ђ", "đ")
        naziv = Replace(naziv, "ж", "ž")
        naziv = Replace(naziv, "ћ", "ć")
        naziv = Replace(naziv, "ч", "č")
        naziv = Replace(naziv, "ш", "š")
        naziv = Replace(naziv, "љ", "lj")
        naziv = Replace(naziv, "њ", "nj")

        naziv = Replace(naziv, "А", "A")
        naziv = Replace(naziv, "Б", "B")
        naziv = Replace(naziv, "В", "V")
        naziv = Replace(naziv, "Г", "G")
        naziv = Replace(naziv, "Д", "D")
        naziv = Replace(naziv, "Е", "E")
        naziv = Replace(naziv, "З", "Z")
        naziv = Replace(naziv, "И", "I")
        naziv = Replace(naziv, "Ј", "J")
        naziv = Replace(naziv, "К", "K")
        naziv = Replace(naziv, "Л", "L")
        naziv = Replace(naziv, "М", "M")
        naziv = Replace(naziv, "Н", "N")
        naziv = Replace(naziv, "О", "O")
        naziv = Replace(naziv, "П", "P")
        naziv = Replace(naziv, "Р", "R")
        naziv = Replace(naziv, "С", "S")
        naziv = Replace(naziv, "Т", "T")
        naziv = Replace(naziv, "У", "U")
        naziv = Replace(naziv, "Ф", "F")
        naziv = Replace(naziv, "Х", "H")
        naziv = Replace(naziv, "Ц", "C")

        naziv = Replace(naziv, "а", "a")
        naziv = Replace(naziv, "б", "b")
        naziv = Replace(naziv, "в", "v")
        naziv = Replace(naziv, "г", "g")
        naziv = Replace(naziv, "д", "d")
        naziv = Replace(naziv, "е", "e")
        naziv = Replace(naziv, "з", "z")
        naziv = Replace(naziv, "и", "i")
        naziv = Replace(naziv, "ј", "j")
        naziv = Replace(naziv, "к", "k")
        naziv = Replace(naziv, "л", "l")
        naziv = Replace(naziv, "м", "m")
        naziv = Replace(naziv, "н", "n")
        naziv = Replace(naziv, "о", "o")
        naziv = Replace(naziv, "п", "p")
        naziv = Replace(naziv, "р", "r")
        naziv = Replace(naziv, "с", "s")
        naziv = Replace(naziv, "т", "t")
        naziv = Replace(naziv, "у", "u")
        naziv = Replace(naziv, "ф", "f")
        naziv = Replace(naziv, "х", "h")
        naziv = Replace(naziv, "ц", "c")
        Return naziv
    End Function

End Class


