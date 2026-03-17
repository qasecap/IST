
Imports Microsoft.VisualBasic.Logging
Imports System.Data

Partial Class PassRess
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Protected Sub Page_Load(sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim email As String = Request.QueryString("username")
        Dim lang As String = Request.QueryString("lang")

        If email Is Nothing OrElse lang Is Nothing Then
            Response.Redirect(ResolveClientUrl("~/Default.aspx"), False)
        Else
            trnslt_Nalog.Value = email
            Session("izabranJezik") = lang
            b.SetLabels(Page, Session("izabranJezik"), connIST, Session("Country"))
        End If
    End Sub

    Protected Sub PromeniLozinkuButton_Click(Source As Object, e As EventArgs) Handles trnslt_PromeniLozinkuButton.Click
        'PROVERI DA LI SU PRAZNA POLJA I DA LI ISPUNJAVA ZAHTEVE ZA NOVI PASS
        If isValidForm() Then
            Try
                Dim rezultat As String = b.UpisPromenaBrisanje("UPDATE ISTUsers SET PassCrypt=dbo.EncryptDiro('" + trnslt_Lozinka.Value + "') WHERE appuser = '" + trnslt_Nalog.Value + "';", connIST, Session("Country"))

                Dim serverPath As String = HttpContext.Current.Request.Url.Authority
                Dim host As String = HttpContext.Current.Request.Url.Host

                If rezultat Then

                    PassRessForm.Visible = False
                    msgPanel.Style("display") = "block"
                    'dilej pre redirekta da bi se videla poruka
                    Timer1.Interval = 3000
                    Timer1.Enabled = True
                Else
                    'MsgBox("Fail")
                End If
            Catch ex As Exception
                System.Diagnostics.Trace.TraceError("PassRess update error: " & ex.ToString())
            End Try
        End If
        'Response.Redirect(ResolveClientUrl("~/ProvideEmail.aspx"), False)
    End Sub

    Protected Function isValidForm() As Boolean
        If ValidacijaRegistracije(2) > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function ValidacijaRegistracije(IsError As Integer) As Integer
        ValidacijaRegistracije = 0
        Dim genericControl As HtmlGenericControl = New HtmlGenericControl
        Dim inputControl As HtmlInputText = New HtmlInputText

        ValidacijaRegistracije += proveraLozinke(LozinkaValid, LozinkaPotvrdaValid)

        Return ValidacijaRegistracije
    End Function

    Public Function ProveraBezVrednosti(TB As HtmlInputText, HIGC As HtmlGenericControl, INDVrednost As String, Klasa As String, Poruka As HtmlGenericControl) As Integer

        Dim genericControl As HtmlGenericControl = New HtmlGenericControl
        Dim inputControl As HtmlInputText = New HtmlInputText

        '0 - VREDNOST NE
        '1 - VREDNOST DA
        If Not TB Is Nothing Then
            Select Case INDVrednost
                Case "TEXT"
                    If b.DajTBText(TB) = "" Or b.DajTBText(TB) = Nothing Then
                        b.IsHITError(TB, 2, "", genericControl)
                        b.IsValidMsgError(Poruka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "obaveznopolje"))

                        ProveraBezVrednosti = 0
                    Else
                        b.IsHITError(TB, 0, "", genericControl)
                        b.IsValidMsgError(Poruka, 0, "")
                        ProveraBezVrednosti = 1
                    End If
            End Select
        Else
            Select Case INDVrednost
                Case "TEXT"
                    If b.DajHIGCText(HIGC) = "" Or b.DajHIGCText(HIGC) = Nothing Then
                        b.IsHITError(inputControl, 2, "", HIGC)
                        b.IsValidMsgError(Poruka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "obaveznopolje"))
                        ProveraBezVrednosti = 0
                    Else
                        b.IsHITError(inputControl, 0, "", HIGC)
                        b.IsValidMsgError(Poruka, 0, "")
                        ProveraBezVrednosti = 1
                    End If
            End Select
        End If


        Return ProveraBezVrednosti
    End Function

    Protected Function proveraLozinke(porukaLozinka As HtmlGenericControl, porukaLozinkaPotvrda As HtmlGenericControl) As Integer
        PorukaUspesno.InnerText = ""
        PorukaNeuspesno.InnerText = ""

        Dim genericControl As HtmlGenericControl = New HtmlGenericControl
        Dim inputControl As HtmlInputText = New HtmlInputText
        Dim haveErrors As Integer = 0

        If Page.IsValid Then

            Dim pass1 As String = Trim(trnslt_Lozinka.Value())
            Dim pass2 As String = Trim(trnslt_LozinkaPotvrda.Value())

            ' provera lozinke da li je prazno polje
            b.IsHITError(trnslt_Lozinka, 0, "", genericControl)
            If ProveraBezVrednosti(trnslt_Lozinka, genericControl, "TEXT", "", LozinkaValid) = 0 Then
                b.IsHITError(trnslt_Lozinka, 2, "", genericControl)
                haveErrors += 1
            Else
                b.IsHITError(trnslt_Lozinka, 0, "", genericControl)
            End If

            ' provera potvrda lozinke lozinke da li je prazno polje
            b.IsHITError(trnslt_LozinkaPotvrda, 0, "", genericControl)
            If ProveraBezVrednosti(trnslt_LozinkaPotvrda, genericControl, "TEXT", "", LozinkaPotvrdaValid) = 0 Then
                b.IsHITError(trnslt_LozinkaPotvrda, 2, "", genericControl)
                haveErrors += 1
            Else
                b.IsHITError(trnslt_LozinkaPotvrda, 0, "", genericControl)
            End If

            If haveErrors = 0 Then
                'provera razlicite lozinke
                If pass1 <> pass2 Then
                    b.IsHITError(trnslt_Lozinka, 2, "", genericControl)
                    b.IsHITError(trnslt_LozinkaPotvrda, 2, "", genericControl)
                    b.IsValidMsgError(porukaLozinka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "razlicitelozinke"))
                    b.IsValidMsgError(porukaLozinkaPotvrda, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "razlicitelozinke"))
                    haveErrors += 1
                Else
                    'da li je pass 6-12 karaktera i samo broj
                    If b.IsValid_DuzinaTekstPolja(pass1, 6, 12) > 0 Then
                        b.IsHITError(trnslt_Lozinka, 2, "", genericControl)
                        b.IsHITError(trnslt_LozinkaPotvrda, 2, "", genericControl)
                        b.IsValidMsgError(porukaLozinka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "pravilolozinke"))
                        b.IsValidMsgError(porukaLozinkaPotvrda, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "pravilolozinke"))
                        haveErrors += 1
                    End If
                End If
            End If

        End If

        Return haveErrors
    End Function

End Class
