
Imports System.Data
Imports System.Reflection

Partial Class ADM_Registration
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connLog As String = b.GetConnStr("connLog")

    Sub Page_Load(ByVal Src As Object, ByVal E As EventArgs) Handles Me.Load
        Try
            If Not IsPostBack Then 'crtam se prvi put
                If (Session("NALOG") <> Nothing AndAlso Session("NALOG") <> "") Then
                    setAuthorization()
                Else    'NEMA ROLU
                    Response.Redirect("Default.aspx")
                    HttpContext.Current.ApplicationInstance.CompleteRequest()
                End If

            Else
                Dim myMasterPage As MasterPage = TryCast(Me.Master, MasterPage)
                If myMasterPage IsNot Nothing Then
                    'AddHandler myMasterPage.MasterPageDDLChanged, AddressOf MasterPageDDLChanged
                End If

            End If 'Not IsPostBack
        Catch ex As Exception
            'Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
        Finally
        End Try
    End Sub

    Sub bindGVDistrictReg()
        Dim ds As DataSet = b.DajDS_IzUpita("SELECT TOP (20) ID_Zaposleni, Ime_i_Prezime, UserName FROM Zaposleni ORDER BY ID_Zaposleni", connLog, Session("Country"))

        If ds.Tables(0).Rows.Count > 0 Then
            gvDistrictReg.DataSource = ds
            gvDistrictReg.DataBind()
        Else
            BezRedova(ds.Tables(0), gvDistrictReg)
        End If

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

    Sub setAuthorization()
        If Session("Rola").ToString <> "" AndAlso Session("Rola").ToString IsNot Nothing Then
            If Session("Rola").ToString = "ADM" Then
                panelDistrictReg.Visible = True
                panelRespondentsReg.Visible = True
            ElseIf Session("Rola").ToString = "DIS" Then
                panelRespondentsReg.Visible = True
            End If
        End If
    End Sub

    Private Sub districtRegistration_Click(sender As Object, e As EventArgs) Handles districtRegistration.Click
        gvDistrictReg.Visible = True
        bindGVDistrictReg()
    End Sub
End Class
