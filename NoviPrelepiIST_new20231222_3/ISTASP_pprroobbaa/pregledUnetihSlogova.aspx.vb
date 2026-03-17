'Option Strict On
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text


Partial Class pregledUnetihSlogova
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
 		Dim strSQlG As String = ""
        	If Session("ROLA") = "6" Then
			strSQlG = "select PODACI_SRM21.GOD, PODACI_SRM21.MES, PODACI_SRM21.SIF, PODACI_SRM21.KAPETA, PODACI_SRM21.REDBRJ from PODACI_SRM21  where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "'"
		End If
		If  Session("ROLA") = "3" Then
 			strSQlG = "" + _
			" select PODACI_SRM21.GOD, PODACI_SRM21.MES, PODACI_SRM21.SIF, PODACI_SRM21.KAPETA, PODACI_SRM21.REDBRJ " + _
			" from (select * from PODACI_SRM21 where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "') PODACI_SRM21 " + _
			" inner join " + _
			" (select Kapetanije.Kapetanija from KAPETANIJE where  2=2) KAPETANIJE on  KAPETANIJE.Kapetanija=PODACI_SRM21.KAPETA " + _
			" inner join " + _
			" (select SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 11, 2) as Kapetanija,SUBSTRING(Veza_KljucUserIstrazivanje.kljuc, 9, 2) as Kapetanija from Veza_KljucUserIstrazivanje " + _
			" where IDIstrazivanje='" + Session("IDIstrazivanje") + "' and Veza_KljucUserIstrazivanje.IDUser ='" + Session("IDUser") + "') VEZA" + _
			" on  KAPETANIJE.Kapetanija=VEZA.Kapetanija " 
		End If
		If  Session("ROLA") = "1" Then
 			strSQlG = "" + _
			" select PODACI_SRM21.GOD, PODACI_SRM21.MES, PODACI_SRM21.SIF, PODACI_SRM21.KAPETA, PODACI_SRM21.REDBRJ from PODACI_SRM21  where  2=2 AND PODACI_SRM21.god='" + Me.TK_GOD.Text.Trim + "' AND PODACI_SRM21.mes='" + Me.TK_MES.Text.Trim + "' " + _
			"  AND KAPETA='" + Session("KAPETA").ToString.Trim + "'"

		End If




    End Sub
    Protected Sub OnRowDataBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        If e.Row.RowType = DataControlRowType.DataRow Then
         
	    Dim GOD As String =gvPODACI_SRM21.DataKeys(e.Row.RowIndex)(0).ToString()
Dim MES As String =gvPODACI_SRM21.DataKeys(e.Row.RowIndex)(1).ToString()
Dim SIF As String =gvPODACI_SRM21.DataKeys(e.Row.RowIndex)(2).ToString()
Dim KAPETA As String =gvPODACI_SRM21.DataKeys(e.Row.RowIndex)(3).ToString()
Dim REDBRJ As String =gvPODACI_SRM21.DataKeys(e.Row.RowIndex)(4).ToString()





        End If
    End Sub  
	Sub gvPODACI_SRM21_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gvPODACI_SRM21.PageIndexChanging
        If e.NewPageIndex <> -1 Then
            gvPODACI_SRM21.PageIndex = e.NewPageIndex
            bindGV(gvPODACI_SRM21, Session("strG")).ToString()
        End If
    End Sub

    'Protected Sub chbSK_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbSK.CheckedChanged
    '    If chbSK.Checked = True Then
    '        99bbbBINDGRIDNADTABELE99
    '    Else
    '       99bbbBINDGRIDNADTABELESAMOKLJUC99
    '    End If
    'End Sub

    
    Sub gvPODACI_SRM21_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles gvPODACI_SRM21.SelectedIndexChanged

        Dim GOD As String =gvPODACI_SRM21.DataKeys(gvPODACI_SRM21.SelectedRow.RowIndex)(0).ToString()
Dim MES As String =gvPODACI_SRM21.DataKeys(gvPODACI_SRM21.SelectedRow.RowIndex)(1).ToString()
Dim SIF As String =gvPODACI_SRM21.DataKeys(gvPODACI_SRM21.SelectedRow.RowIndex)(2).ToString()
Dim KAPETA As String =gvPODACI_SRM21.DataKeys(gvPODACI_SRM21.SelectedRow.RowIndex)(3).ToString()
Dim REDBRJ As String =gvPODACI_SRM21.DataKeys(gvPODACI_SRM21.SelectedRow.RowIndex)(4).ToString()

	Dim str As String =String.Format("GOD={0}&MES={1}&SIF={2}&KAPETA={3}&REDBRJ={4}", GOD, MES, SIF, KAPETA, REDBRJ)
        Dim url As String = "PODACI_SRM21.aspx?" + str + "&ODS=P"
        Response.Redirect(url)

    End Sub




End Class


