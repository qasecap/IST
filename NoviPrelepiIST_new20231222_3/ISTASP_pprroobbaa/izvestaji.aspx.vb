'Option Strict On
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.Page
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Text

Partial Class izvestaji
    Inherits System.Web.UI.Page
    Dim b As New Base_IST_PPP()

    Protected Sub lbl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl1.Click
        Dim strSQl As String
        'strSQL="sql upit ili procedura ....."
        strSQl = "select getdate() as NazivKolone1,getdate() as NazivKolone2"
        Session.Add("str", strSQl)
        Session.Add("sort", " asc")
        bindGV(gv,lbl1.text).ToString()
       
    End Sub
    Protected Sub lbl2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl2.Click
        Dim strSQl As String
        'strSQL="sql upit ili procedura ....."
        strSQl = "select getdate()"
        Session.Add("str", strSQl)
        Session.Add("sort", " asc")
        bindGV(gv,lbl2.text).ToString()
        
    End Sub
    Protected Sub lbl3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl3.Click
        Dim strSQl As String
        'strSQL="sql upit ili procedura ....."
        strSQl = "select getdate() where 2=3"
        Session.Add("str", strSQl)
        Session.Add("sort", " asc")
        bindGV(gv,lbl3.text).ToString()
       
    End Sub
    Protected Sub lbl4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl4.Click
        Dim strSQl As String
        'strSQL="sql upit ili procedura ....."
        strSQl = "select getdate()"
        Session.Add("str", strSQl)
        Session.Add("sort", " asc")
        bindGV(gv,lbl4.text).ToString()
        
    End Sub
    Public Function bindGV(ByVal gv As GridView, ByVal naslov As String) As Integer
        'poveze grid i vrati broj redova
        Dim gvDS As DataSet
        Dim strSQL As String
        'If IsNothing(Session("ID_Korisnika")) Then
        '    Response.Redirect("Login.aspx")
        'Else
        strSQL = Session("str").ToString
        gvDS = b.DajDS_IzUpita(strSQL, Me.lblKonekcija.Text)

        If gvDS.Tables(0).Rows.Count > 0 Then
            gv.DataSource = gvDS
            gv.DataBind()
            bindGV = gvDS.Tables(0).Rows.Count   'broj redova
        Else
            BezRedova(gvDS.Tables(0), gv)
            bindGV = 0
        End If

        If naslov <> "" Then
            gv.Visible = True
            lblNaslov.Text = naslov.Trim
            lblNaslov.Visible = True
        End If
        'End If
    End Function
    Protected Sub gv_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gv.RowDataBound
        Dim cell As TableCell
        If (e.Row.RowType = DataControlRowType.DataRow) Then
            For Each cell In e.Row.Cells
                cell.Text = cell.Text.Replace(" ", "&nbsp;")
            Next
        End If
    End Sub


    Protected Sub cmdExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExportExcel.Click
        If gv.Visible = True Then
            gv.AllowPaging = False
            If bindGV(gv,"") > 0 Then
                GridViewExportUtil("Export.xls", gv, True)
            End If
        End If

    End Sub
    Sub GridViewExportUtil(ByVal fileName As String, ByVal gv As GridView, Optional ByVal removeCell As Boolean = False)

        HttpContext.Current.Response.ContentType = "application/ms-excel"
        HttpContext.Current.Response.AddHeader("content-disposition", String.Format("attachment; filename={0}", fileName))
        HttpContext.Current.Response.Write("<!DOCTYPE html PUBLIC " & Chr(34) & "-//W3C//DTD XHTML 1.0 Transitional//EN" & Chr(34) & " " & Chr(34) & _
             "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" & Chr(34) & ">" & vbCrLf & _
             "<html xmlns=" & Chr(34) & "http://www.w3.org/1999/xhtml" & Chr(34) & ">" & vbCrLf & _
             "<head>" & vbCrLf & _
             "<meta http-equiv='Content-Type' content='text/html; charset=utf-8'>" & vbCrLf & _
             "</head><body>")


        Dim sw As New System.IO.StringWriter
        Dim htw As New System.Web.UI.HtmlTextWriter(sw)


        Dim style As String = "<style> .text { mso-number-format:\@; } </style> "
        HttpContext.Current.Response.Write(style)

        Dim Table As New Table()
        'da iscrta gridlines u excelu
        Table.GridLines = gv.GridLines
        If Not IsNothing(gv.HeaderRow) Then
            If (removeCell) Then
                'gv.HeaderRow.Controls.Remove(gv.HeaderRow.Controls.Item(0))
                'gv.HeaderRow.Controls.Remove(gv.HeaderRow.Controls.Item(0))
                'gv.HeaderRow.Controls.Remove(gv.HeaderRow.Controls.Item(0))
            End If
            PrepareGridViewForExport(gv.HeaderRow)
            Table.Rows.Add(gv.HeaderRow)
        End If
        Dim row As GridViewRow

        For Each row In gv.Rows
            If (removeCell) Then
                'row.Controls.Remove(row.Controls.Item(0))
                'row.Controls.Remove(row.Controls.Item(0))
                'row.Controls.Remove(row.Controls.Item(0))
            End If

            'For Each cell In row.Cells
            '    cell = String.Format("&nbsp;{0}&nbsp;", cell.ToString)
            'Next
            For Each cell In row.Cells
                cell.Attributes.Add("class", "text")
            Next

            If gv.UniqueID.ToString.ToUpper.Trim = "GVPS" Then
                row.Cells(3).Attributes.Add("align", "right")
                row.Cells(6).Attributes.Add("align", "right")
                row.Cells(7).Attributes.Add("align", "right")
                row.Cells(10).Attributes.Add("align", "right")
                row.Cells(12).Attributes.Add("align", "right")
                row.Cells(15).Attributes.Add("align", "right")
            End If

            PrepareGridViewForExport(row)
            Table.Rows.Add(row)
        Next
        If Not IsNothing(gv.FooterRow) Then
            If (removeCell) Then
                gv.FooterRow.Controls.Remove(gv.FooterRow.Controls.Item(0))
            End If
            PrepareGridViewForExport(gv.FooterRow)
            Table.Rows.Add(gv.FooterRow)
        End If

        Table.RenderControl(htw)
        HttpContext.Current.Response.Write(sw.ToString())
        HttpContext.Current.Response.End()
    End Sub

    Shared Sub PrepareGridViewForExport(ByVal gview As System.Web.UI.Control)
        Dim l As New System.Web.UI.WebControls.Literal
        For i As Int32 = 0 To gview.Controls.Count - 1
            If TypeOf gview.Controls(i) Is System.Web.UI.WebControls.LinkButton Then
                l.Text = CType(gview.Controls(i), System.Web.UI.WebControls.LinkButton).Text
                gview.Controls.Remove(gview.Controls(i))
                gview.Controls.AddAt(i, l)
            ElseIf TypeOf gview.Controls(i) Is System.Web.UI.WebControls.DropDownList Then
                l.Text = CType(gview.Controls(i), System.Web.UI.WebControls.DropDownList).SelectedItem.Text
                gview.Controls.Remove(gview.Controls(i))
                gview.Controls.AddAt(i, l)
            ElseIf TypeOf gview.Controls(i) Is System.Web.UI.WebControls.CheckBox Then
                l.Text = CType(gview.Controls(i), System.Web.UI.WebControls.CheckBox).Checked.ToString
                If l.Text = "False" Then
                    l.Text = "не"
                Else
                    l.Text = "да"
                End If
                gview.Controls.Remove(gview.Controls(i))
                gview.Controls.AddAt(i, l)
            ElseIf TypeOf gview.Controls(i) Is System.Web.UI.WebControls.Literal Then
                l.Text = CType(gview.Controls(i), System.Web.UI.WebControls.Literal).ToString
                gview.Controls.Remove(gview.Controls(i))
                gview.Controls.AddAt(i, l)
            ElseIf TypeOf gview.Controls(i) Is System.Web.UI.WebControls.HyperLink Then
                l.Text = CType(gview.Controls(i), System.Web.UI.WebControls.HyperLink).Text
                gview.Controls.Remove(gview.Controls(i))
                gview.Controls.AddAt(i, l)
            ElseIf TypeOf gview.Controls(i) Is System.Web.UI.WebControls.ImageButton Then
                l.Text = CType(gview.Controls(i), System.Web.UI.WebControls.ImageButton).AlternateText
                gview.Controls.Remove(gview.Controls(i))
                gview.Controls.AddAt(i, l)
            End If
            If gview.Controls(i).HasControls() Then
                PrepareGridViewForExport(gview.Controls(i))
            End If
        Next
    End Sub

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
    Sub loadStrane()
        ' u sesiji se nalaze: rola, IDUser, god, mes, kv, sed
        'koristi se sa: Session("god")
        Me.lblKonekcija.Text = "Data Source=IMT2.statsrb.lan;Initial Catalog=SAOBRACAJ;User ID=IST_PPP;Password=Gilgames"       
    End Sub



End Class

