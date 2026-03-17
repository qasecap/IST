Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Threading.Tasks
Imports AjaxControlToolkit
Imports AjaxControlToolkit.HTMLEditor.ToolbarButton

Partial Class Registration
    Inherits System.Web.UI.Page

    Private ReadOnly b As New Base_IST_PPP()
    Dim connIST As String = b.GetConnStr("connIST")
    Dim connCatalog As String = b.GetConnStr("connCatalog")

    Protected Sub Page_Load(sender As Object, ByVal e As EventArgs) Handles Me.Load
        b.SetLabels(Page, Session("izabranJezik"), connIST, Session("Country"))
        If Not IsPostBack Then
        Else
            'izbrisi ssve greske sa input polja
            IzbrisiSveGreske()
        End If
    End Sub

    Protected Sub IzbrisiSveGreske()
        Dim inputControl As HtmlInputText = New HtmlInputText
        Dim genericControl As HtmlGenericControl = New HtmlGenericControl
        b.IsHITErrorTB(inputControl, 0, "", trnslt_ImeFirma)
        b.IsValidMsgError(imeFirmaValid, 0, "")
        b.IsHITErrorTB(inputControl, 0, "", trnslt_mbr)
        b.IsValidMsgError(mbrValid, 0, "")
        b.IsHITErrorTB(inputControl, 0, "", trnslt_Ime)
        b.IsValidMsgError(ImeValid, 0, "")
        b.IsHITErrorTB(inputControl, 0, "", trnslt_Prezime)
        b.IsValidMsgError(PrezimeValid, 0, "")
        b.IsHITErrorTB(inputControl, 0, "", trnslt_Email)
        b.IsValidMsgError(EmailValid, 0, "")
        b.IsHITError(trnslt_Lozinka, 0, "", genericControl)
        b.IsValidMsgError(LozinkaValid, 0, "")
        b.IsHITError(trnslt_LozinkaPotvrda, 0, "", genericControl)
        b.IsValidMsgError(LozinkaPotvrdaValid, 0, "")
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

        ' provera imenafirme da li je prazno polje
        b.IsHITErrorTB(inputControl, 0, "", trnslt_ImeFirma)
        If ProveraBezVrednostiTB(trnslt_ImeFirma, genericControl, "TEXT", "", imeFirmaValid) = 0 Then
            b.IsHITErrorTB(inputControl, 2, "", trnslt_ImeFirma)
            ValidacijaRegistracije += 1
        Else
            b.IsHITErrorTB(inputControl, 0, "", trnslt_ImeFirma)
        End If

        ' provera imena da li je prazno polje
        b.IsHITErrorTB(inputControl, 0, "", trnslt_Ime)
        If ProveraBezVrednostiTB(trnslt_Ime, genericControl, "TEXT", "", ImeValid) = 0 Then
            b.IsHITErrorTB(inputControl, 2, "", trnslt_Ime)
            ValidacijaRegistracije += 1
        Else
            b.IsHITErrorTB(inputControl, 0, "", trnslt_Ime)
        End If

        ' provera prezimena da li je prazno polje
        b.IsHITErrorTB(inputControl, 0, "", trnslt_Prezime)
        If ProveraBezVrednostiTB(trnslt_Prezime, genericControl, "TEXT", "", PrezimeValid) = 0 Then
            b.IsHITErrorTB(inputControl, 2, "", trnslt_Prezime)
            ValidacijaRegistracije += 1
        Else
            b.IsHITErrorTB(inputControl, 0, "", trnslt_Prezime)
        End If

        ' provera imejla da li je prazno polje
        b.IsHITErrorTB(inputControl, 0, "", trnslt_Email)
        If ProveraBezVrednostiTB(trnslt_Email, genericControl, "TEXT", "", EmailValid) = 0 Then
            b.IsHITErrorTB(inputControl, 2, "", trnslt_Email)
            ValidacijaRegistracije += 1
        Else
            b.IsHITErrorTB(inputControl, 0, "", trnslt_Email)

            If b.IsValidEmailFormat(trnslt_Email.Text) > 0 Then
                b.IsHITErrorTB(inputControl, 2, "", trnslt_Email)
                b.IsValidMsgError(EmailValid, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "formatemail"))
                ValidacijaRegistracije += 1
            Else
                b.IsHITErrorTB(inputControl, 0, "", trnslt_Email)
                b.IsValidMsgError(EmailValid, 0, "")

                If Not trnslt_Email.Text Is Nothing AndAlso trnslt_Email.Text <> "" Then
                    ' provera naloga da li postoji vec u bazi - mora biti uniq
                    Dim upit = "SELECT APPUser FROM ISTUsers WHERE UserEmailForgotPass = '" + trnslt_Email.Text + "'"
                    Dim ds As DataSet = b.DajDS_IzUpita(upit, connIST, Session("Country"))
                    If ds.Tables.Count > 0 Then
                        If ds.Tables(0).Rows.Count > 0 Then
                            b.IsHITErrorTB(inputControl, 2, "", trnslt_Email)
                            b.IsValidMsgError(EmailValid, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "uniqueemail"))
                            ValidacijaRegistracije = 1
                        Else
                            b.IsHITErrorTB(inputControl, 0, "", trnslt_Email)
                        End If
                    End If
                End If
            End If


        End If

        ' provera trnslt_mbr da li je prazno polje
        b.IsHITErrorTB(inputControl, 0, "", trnslt_mbr)
        If ProveraBezVrednostiTB(trnslt_mbr, genericControl, "TEXT", "", mbrValid) = 0 Then
            b.IsHITErrorTB(inputControl, 2, "", trnslt_mbr)
            ValidacijaRegistracije += 1
        Else
            b.IsHITErrorTB(inputControl, 0, "", trnslt_mbr)

            Dim mbrLengthError = 0
            If Not String.IsNullOrEmpty(trnslt_mbr.Text) Then
                If trnslt_mbr.Text.Length < 4 Or trnslt_mbr.Text.Length > 8 Then
                    mbrLengthError = 1
                End If
            End If

            If mbrLengthError > 0 Then
                b.IsHITErrorTB(inputControl, 2, "", trnslt_mbr)
                b.IsValidMsgError(mbrValid, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "formatmbr"))
                ValidacijaRegistracije += 1
            Else
                b.IsHITErrorTB(inputControl, 0, "", trnslt_mbr)
                b.IsValidMsgError(mbrValid, 0, "")
            End If
        End If

        ValidacijaRegistracije += proveraLozinke(LozinkaValid, LozinkaPotvrdaValid)

        Return ValidacijaRegistracije
    End Function

    Protected Async Sub RegistrationButton_Click(Source As Object, e As EventArgs) Handles trnslt_RegisterButton.Click
        Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", connIST, Session("Country"))
        Session("dsErrors") = dsErrors
        ' Ako je validna registracija salji verifikacioni mail
        If isValidForm() Then
            Try
                Dim serverPath As String = HttpContext.Current.Request.Url.Authority

                Dim listControl As List(Of Control) = New List(Of Control)
                Dim txt As TextBox = New TextBox
                Dim vod As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                Dim vdo As DateTime = New DateTime(9999, 1, 1)

                'upis u bazu
                Dim rezultat As String = b.UpisPromenaBrisanje("INSERT INTO ISTUsers (APPUser, PassCrypt, vod, vdo, UserEmailForgotPass, nameUser, LastnameUser, nameCompany, VerifiedEmail) VALUES ('" + trnslt_mbr.Text + "', [dbo].EncryptDIRO('" + trnslt_Lozinka.Value + "'), '" + vod + "', '" + vdo + "', '" + trnslt_Email.Text + "', '" + trnslt_Ime.Text + "', '" + trnslt_Prezime.Text + "', '" + trnslt_ImeFirma.Text + "', 0);", connIST, Session("Country"))
                If rezultat = True Then
                    'proso insert

                    'Dim intResult As Integer = Await SendMailAsync()
                    Dim poslatMail = 0
                    Await Task.Run(Sub()
                                       poslatMail = b.SendMail(Session("izabranJezik"), "verifikacija", trnslt_Email.Text, trnslt_mbr.Text, serverPath, dsErrors)
                                   End Sub)

                    b.IsInfoError(infoMsg, 0, "")
                    infoMsg.InnerText = b.SetError(dsErrors, Session("IzabranJezik"), "uspesnaregistracija")

                    Session.Remove("izabranMBR")

                    RegistrationForm.Visible = False
                    msgPanel.Visible = True
                Else
                    b.IsInfoError(infoMsg, 2, "")
                    infoMsg.InnerText = "GRESKA"
                End If
            Catch ex As Exception
                System.Diagnostics.Trace.TraceError("Registration insert error: " & ex.ToString())
                b.IsInfoError(infoMsg, 2, "")
                infoMsg.InnerText = "GRESKA"
            End Try
        Else
            ' nije validna forma
            'infoMsg.InnerText = "НИЈЕ ВАЛИДНA ФОРМА."
        End If
        Session("dsErrors") = Nothing
    End Sub
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
    Public Function ProveraBezVrednostiTB(TB As TextBox, HIGC As HtmlGenericControl, INDVrednost As String, Klasa As String, Poruka As HtmlGenericControl) As Integer

        Dim genericControl As HtmlGenericControl = New HtmlGenericControl
        Dim inputControl As HtmlInputText = New HtmlInputText

        '0 - VREDNOST NE
        '1 - VREDNOST DA
        If Not TB Is Nothing Then
            Select Case INDVrednost
                Case "TEXT"
                    If b.DajTBTextTB(TB) = "" Or b.DajTBTextTB(TB) = Nothing Then
                        b.IsHITErrorTB(inputControl, 2, "", TB)
                        b.IsValidMsgError(Poruka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "obaveznopolje"))

                        ProveraBezVrednostiTB = 0
                    Else
                        b.IsHITErrorTB(inputControl, 0, "", TB)
                        b.IsValidMsgError(Poruka, 0, "")
                        ProveraBezVrednostiTB = 1
                    End If
            End Select
        Else
            Select Case INDVrednost
                Case "TEXT"
                    If b.DajHIGCText(HIGC) = "" Or b.DajHIGCText(HIGC) = Nothing Then
                        b.IsHITError(inputControl, 2, "", HIGC)
                        b.IsValidMsgError(Poruka, 2, b.SetError(Session("dsErrors"), Session("IzabranJezik"), "obaveznopolje"))
                        ProveraBezVrednostiTB = 0
                    Else
                        b.IsHITError(inputControl, 0, "", HIGC)
                        b.IsValidMsgError(Poruka, 0, "")
                        ProveraBezVrednostiTB = 1
                    End If
            End Select
        End If

        Return ProveraBezVrednostiTB
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