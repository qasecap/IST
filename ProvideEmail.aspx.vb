
Imports System.Data
Imports System.Threading.Tasks
Imports AjaxControlToolkit.AsyncFileUpload.Constants

Partial Class ProvideEmail
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connISTWEB As String = b.GetConnStr("connISTWEB")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Protected Sub Page_Load(sender As Object, ByVal e As EventArgs) Handles Me.Load
        b.SetLabels(Page, Session("izabranJezik"), connIST, Session("Country"))
        Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", connIST, Session("Country"))
        Session("dsErrors") = dsErrors
    End Sub

    Protected Async Sub ResetMeilButton_Click(Source As Object, e As EventArgs) Handles trnslt_ResetMeilButton.Click

        If isValidForm() Then
            Try
                If Not Session("EmailUserDS") Is Nothing Then
                    Dim DS As DataSet = Session("EmailUserDS")
                    Dim email = b.DajStringPolje(DS, "email")
                    'Dim testEmail = "markogrujicic@mail.com"
                    If email <> "" Then
                        Dim querySendMail As String = "exec usp_ISTWEBAdminSendEmail @appuser='" & Trim(trnslt_user.Value) & "',@Okpo=N'" & Trim(trnslt_okpo.Value) & "',@email=N'" & Trim(email) & "'"
                        Dim execProc = b.DajDS_IzUpita(querySendMail, connISTWEB, Session("Country"))
                        'Session.Add("execProc", execProc)

                        IsInfoError(InfoMsg, 0, "")
                        PotvrdaIdentitetaForm.Visible = False
                        ProvideEmailForm.Visible = True
                        InfoMsg.InnerHtml = b.SetError(Session("dsErrors"), Session("izabranJezik"), "promenalozinke") + " <a href='Default.aspx'>" + b.SetError(Session("dsErrors"), Session("izabranJezik"), "backToLogin") + "</a>" '"НА МЕЈЛ АДРЕСУ ЋЕ ВАМ СТИЋИ ЛИНК ЗА ПРОМЕНУ ЛОЗИНКЕ." 'srediti KGZ*
                    Else
                        IsInfoError(InfoMsg, 1, "")
                        InfoMsg.InnerText = b.SetError(Session("dsErrors"), Session("izabranJezik"), "noEmail") '"u bazi ne postoji email kontaktirajte regi.cent."
                    End If


                Else
                    ' prazna sesija ne sme da se desi
                End If

            Catch ex As Exception
                'custom greska slanje maila
                MsgBox("Can't load Web page" & vbCrLf & ex.Message)
            End Try
        Else
            ' nije validna forma
        End If

    End Sub

    Protected Function isValidForm() As Boolean
        If ValidacijaResetPass(2) > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ValidacijaResetPass(IsError As Integer) As Integer
        ValidacijaResetPass = 0
        Dim inputControl As HtmlInputGenericControl

        ' provera usera da li je prazno polje
        IsHITError(trnslt_user, 0, "", inputControl)
        If ProveraBezVrednosti(trnslt_user, inputControl, "TEXT", "", userValid) = 0 Then
            IsHITError(trnslt_user, 2, "", inputControl)
            ValidacijaResetPass = 1
        Else
            IsHITError(trnslt_user, 0, "", inputControl)
        End If

        ' provera okpo da li je prazno polje
        IsHITError(trnslt_okpo, 0, "", inputControl)
        If ProveraBezVrednosti(trnslt_okpo, inputControl, "TEXT", "", OKPOValid) = 0 Then
            IsHITError(trnslt_okpo, 2, "", inputControl)
            ValidacijaResetPass = 1
        Else
            IsHITError(trnslt_okpo, 0, "", inputControl)
        End If

        ' ako je uneo nesto u polja proveri da li postoji ta kombinacija user/okpo
        If ValidacijaResetPass = 0 Then
            'proveri da li postoji okpo i user - ako ima prebaci ga da upise ako ne iybaci gresku

            Dim UpitSelect As String = "SELECT okpo, userid, role, email FROM istusersweb WHERE okpo = '" & Trim(trnslt_okpo.Value) & "' And userid='" & Trim(trnslt_user.Value) & "'"
            Dim DS As DataSet = b.DajDS_IzUpita(UpitSelect, connISTWEB, Session("Country"))
            Session("EmailUserDS") = DS
            Dim role As String = b.DajStringPolje(DS, "role")
            If role.ToUpper = "ADMIN" Then
                If DS.Tables(0).Rows.Count < 1 Then
                    ' ne postoji user mail combo izbaci gresk
                    IsHITError(trnslt_user, 0, "", inputControl)
                    IsHITError(trnslt_user, 2, "", inputControl)
                    'okpo
                    IsHITError(trnslt_okpo, 0, "", inputControl)
                    IsHITError(trnslt_okpo, 2, "", inputControl)
                    'IsValidMsgError(NalogValid, 2, "Комбинација налога и имејла не постоји у бази!")
                    IsValidMsgError(userValid, 2, "User не постоји у бази!")
                    IsValidMsgError(OKPOValid, 2, "Okpo не постоји у бази!")
                    ValidacijaResetPass = 1
                Else
                    'validna forma
                    IsHITError(trnslt_user, 0, "", inputControl)
                    IsHITError(trnslt_okpo, 0, "", inputControl)
                End If
                PorukaNeuspesno.InnerText = ""
            Else
                PorukaNeuspesno.InnerText = b.SetError(Session("dsErrors"), Session("IzabranJezik"), "notAdmin") '"Nisi admin kontaktiraj administratora u vasem preduzecu."
                ValidacijaResetPass = 1
            End If

        End If

        Return ValidacijaResetPass
    End Function

    Public Sub IsHITError(HIT As HtmlInputText, IsError As Integer, TBKlasa As String, HIGC As HtmlInputGenericControl)
        Dim Klasa As String = "form-control input-xs " & TBKlasa, Greska As String = "form-control input-xs alpha-danger border border-danger " & TBKlasa,
            Upozorenje As String = "form-control input-xs alpha-violet border border-warning " & TBKlasa

        If Not HIT Is Nothing Then
            Select Case IsError
                Case 0
                    HIT.Attributes.Add("class", Klasa)
                Case 1
                    HIT.Attributes.Add("class", Greska)
                Case 2
                    HIT.Attributes.Add("class", Upozorenje)
            End Select
        Else
            Select Case IsError
                Case 0
                    HIGC.Attributes.Add("class", Klasa)
                Case 1
                    HIGC.Attributes.Add("class", Greska)
                Case 2
                    HIGC.Attributes.Add("class", Upozorenje)
            End Select
        End If

    End Sub

    Public Sub IsInfoError(HIT As HtmlGenericControl, IsError As Integer, TBKlasa As String)
        Dim Klasa As String = "form-cont input-xs " & TBKlasa, Greska As String = "form-cont input-xs alpha-danger border border-danger " & TBKlasa,
            Upozorenje As String = "form-cont input-xs alpha-violet border border-warning " & TBKlasa

        If Not HIT Is Nothing Then
            Select Case IsError
                Case 0
                    HIT.Attributes.Add("class", Klasa)
                Case 1
                    HIT.Attributes.Add("class", Greska)
            End Select
        Else
            ' GRESKA
        End If

    End Sub

    Public Function DajTBText(TB As HtmlInputText) As String
        If Trim(TB.Value) <> "" And Trim(TB.Value) <> "&nbsp;" Then
            DajTBText = Trim(TB.Value.ToString())
        Else
            DajTBText = Nothing
        End If
        Return DajTBText
    End Function

    Public Function DajHIGCText(HIGC As HtmlInputGenericControl) As String
        If Trim(HIGC.Value) <> "" And Trim(HIGC.Value) <> "&nbsp;" Then
            DajHIGCText = Trim(HIGC.Value.ToString())
        Else
            DajHIGCText = Nothing
        End If
        Return DajHIGCText
    End Function

    Public Function ProveraBezVrednosti(TB As HtmlInputText, HIGC As HtmlInputGenericControl, INDVrednost As String, Klasa As String, Poruka As HtmlGenericControl) As Integer

        Dim genericControl As HtmlInputGenericControl = New HtmlInputGenericControl
        Dim inputControl As HtmlInputText = New HtmlInputText

        '0 - VREDNOST NE
        '1 - VREDNOST DA
        If Not TB Is Nothing Then
            Select Case INDVrednost
                Case "TEXT"
                    If DajTBText(TB) = "" Or DajTBText(TB) = Nothing Then
                        IsHITError(TB, 2, "", genericControl)
                        'IsValidMsgError(Poruka, 2, "Обавезно поље!")
                        IsValidMsgError(Poruka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "obaveznopolje"))
                        ProveraBezVrednosti = 0
                    Else
                        IsHITError(TB, 0, "", genericControl)
                        IsValidMsgError(Poruka, 0, "")
                        ProveraBezVrednosti = 1
                    End If
            End Select
        Else
            Select Case INDVrednost
                Case "TEXT"
                    If DajHIGCText(HIGC) = "" Or DajHIGCText(HIGC) = Nothing Then
                        IsHITError(inputControl, 2, "", HIGC)
                        'IsValidMsgError(Poruka, 2, "Обавезно поље!")
                        IsValidMsgError(Poruka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "obaveznopolje"))
                        ProveraBezVrednosti = 0
                    Else
                        IsHITError(inputControl, 0, "", HIGC)
                        IsValidMsgError(Poruka, 0, "")
                        ProveraBezVrednosti = 1
                    End If
            End Select
        End If

        Return ProveraBezVrednosti
    End Function

    Public Sub IsValidMsgError(ValidKontrola As HtmlGenericControl, IsError As Integer, Poruka As String)
        Dim Greska As String = "validation-error-label", Upozorenje As String = "validation-warning-label"
        Select Case IsError
            Case 0
                Poruka = ""
            Case 1
                ValidKontrola.Attributes.Add("class", Greska)
            Case 2
                ValidKontrola.Attributes.Add("class", Upozorenje)
        End Select
        ValidKontrola.InnerHtml = Poruka
    End Sub
End Class
