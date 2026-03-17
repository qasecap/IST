Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.Globalization
Imports System.Web
Imports System.Security.Cryptography
Imports System.Net.Mail

Public Class Base_IST_PPP

    ''***************************KGZ**************************************************************
    Dim wsOpsti

    'Dim wsOpsti As New wsLocalBeka.ServiceSoapClient()
    'Dim wsOpsti As New wsAzureOpsti.ServiceSoapClient()

    Public Function UpisPromenaBrisanje(ByVal Upit As String, ByVal konekcija As String, country As String) As Boolean
        Dim wsOpsti
        If country = "KGZ" Then
            wsOpsti = New wsLocalBeka.ServiceSoapClient()
        Else
            wsOpsti = New wsAzureOpsti.ServiceSoapClient()
        End If
        Dim retSTR As String = wsOpsti.UpisPromenaBrisanje(Encrypt(Upit), Encrypt(konekcija))
        Dim ret As Boolean = False
        If retSTR = "OK" Then ret = True
        Return ret
    End Function

    Public Function DajDS_IzUpita(ByVal Upit As String, ByVal konekcija As String, country As String) As DataSet
        Dim wsOpsti
        If country = "KGZ" Then
            wsOpsti = New wsLocalBeka.ServiceSoapClient()
        Else
            wsOpsti = New wsAzureOpsti.ServiceSoapClient()
        End If
        Dim ResultSet As DataSet = wsOpsti.DajDS_IzUpita(Encrypt(Upit), Encrypt(konekcija))
        Return ResultSet
    End Function
    ''***************************KGZ**************************************************************


    ''***************************RZS**************************************************************
    'Dim wsOpsti As New wsOpstiServisi.Service()
    'Public Function DajDS_IzUpita(ByVal Upit As String, ByVal konekcija As String) As DataSet
    '    Dim ResultSet As DataSet = wsOpsti.RunQuery(Upit, konekcija)
    '    Return ResultSet
    'End Function
    'Public Function UpisPromenaBrisanje(ByVal Upit As String, ByVal konekcija As String) As String
    '    Dim rezultat As String = ""
    '    rezultat = wsOpsti.UpisPromenaBrisanje(Upit, konekcija)
    '    Return rezultat
    'End Function
    ''***************************RZS**************************************************************

    Public Shared Function Encrypt(strInput As String) As String

        Dim strKey As String = "ER$dfl7!3"
        Dim tdDes As New TripleDESCryptoServiceProvider
        tdDes.Key = Truncate(strKey, tdDes.KeySize \ 8)
        tdDes.IV = Truncate("", tdDes.BlockSize \ 8)
        Dim btInputBytes() As Byte = Encoding.Unicode.GetBytes(strInput)
        Dim msInput As New IO.MemoryStream
        Dim csEncrypt As New CryptoStream(msInput, tdDes.CreateEncryptor(), CryptoStreamMode.Write)

        csEncrypt.Write(btInputBytes, 0, btInputBytes.Length)
        csEncrypt.FlushFinalBlock()

        Return Convert.ToBase64String(msInput.ToArray)

    End Function

    Private Shared Function Truncate(strKey As String, ByVal intLength As Integer) As Byte()

        Dim shaCrypto As New SHA1CryptoServiceProvider
        Dim btKeyBytes() As Byte = Encoding.Unicode.GetBytes(strKey)
        Dim btHash() As Byte = shaCrypto.ComputeHash(btKeyBytes)
        ReDim Preserve btHash(intLength - 1)
        Return btHash

    End Function

    Public Function ProveraFormataBrojaTelefona(ByVal BrojTelefona As String) As Int16
        Dim NeispravanBrojTelefona As Integer = 0
        Dim i As Integer
        Dim karakter As Char
        Dim DozvoljeniZnaci = "0123456789=()-/ "

        If BrojTelefona.Length() >= 5 Then
            For i = 0 To BrojTelefona.Length() - 1
                karakter = BrojTelefona.Substring(i, 1)
                If InStr(1, DozvoljeniZnaci, karakter) = 0 Then
                    NeispravanBrojTelefona = 1
                    Exit For
                End If
            Next
        End If

        Return NeispravanBrojTelefona
    End Function

    Public Function IsValidEmailFormat(ByVal inputEmail As String) As Integer

        Dim result As Boolean = True
        Dim ImaGreske As Integer = 0

        If Not String.IsNullOrEmpty(inputEmail) Then

            Dim pattern As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"


            Dim match As RegularExpressions.Match = RegularExpressions.Regex.Match(inputEmail, pattern)
            result = match.Success
        End If

        If result = False Then ImaGreske = 1

        Return ImaGreske
    End Function

    Public Function IsValidURL(ByVal inputURL As String) As Integer

        Dim result As Boolean = True
        Dim ImaGreske As Integer = 0

        If Not String.IsNullOrEmpty(inputURL) Then

            'Dim pattern As String = " ^(([\w]+:)?\/\/)?(([\d\w]|%[a-fA-f\d]{2,2})+(:([\d\w]|%[a-fA-f\d]{2,2})+)?@)?([\d\w][-\d\w]{0,253}[\d\w]\.)+[\w]{2,4}(:[\d]+)?(\/([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)*(\?(&?([-+_~.\d\w]|%[a-fA-f\d]{2,2})=?)*)?(#([-+_~.\d\w]|%[a-fA-f\d]{2,2})*)?$"
            Dim pattern As String = "^(?:http:\/\/)?(?:(?:[a-z0-9][\w\-]*[a-z0-9]*\.)*(?:(?:(?:(?:[a-z0-9][\w\-]*[a-z0-9]*)(?:\.[a-z0-9]+)?)|(?:(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)))(?::[0-9]+)?))?(?:(?:(?:\/(?:[\w`~!$=;\-\+\.\^\(\)\|\{\}\[\]]|(?:%\d\d))+)*\/(?:[\w`~!$=;\-\+\.\^\(\)\|\{\}\[\]]|(?:%\d\d))*)(?:\?[\^#]+)?(?:#[a-z0-9]\w*)?)?$"
            'Dim pattern As String = "http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"
            Dim match As RegularExpressions.Match = RegularExpressions.Regex.Match(inputURL, pattern)
            result = match.Success
        End If

        If result = False Then ImaGreske = 1

        Return ImaGreske
    End Function

    Public Function IsValid_TekstPolje(ByVal TekstPolja As String, ByVal minDuzina As Int16, ByVal maxDuzina As Int16) As Integer

        Dim result As Boolean = True
        Dim ImaGreske As Integer = 0

        If Not String.IsNullOrEmpty(TekstPolja) Then

            Dim pattern As String = "([a-zA-Z0-9]{" & minDuzina.ToString() & "," & maxDuzina.ToString() & "})$"


            Dim match As RegularExpressions.Match = RegularExpressions.Regex.Match(TekstPolja, pattern)
            result = match.Success
        End If

        If result = False Then ImaGreske = 1

        Return ImaGreske
    End Function

    Public Function IsValidIPAddress(ByVal strIPAddress As String) As Boolean
        Try
            Dim varAddress As Object, n As Long, lCount As Long
            varAddress = Split(strIPAddress, ".", , vbTextCompare)
            If IsArray(varAddress) Then
                For n = LBound(varAddress) To UBound(varAddress)
                    lCount = lCount + 1
                    varAddress(n) = CByte(varAddress(n))
                Next
                IsValidIPAddress = (lCount = 4)
            End If
        Catch
            Return False
        End Try
    End Function

    Public Function GetConnStr(ByVal keyName As String) As String
        Dim s As String = ""
        Dim s_default As String = ""

        ' Get the connectionStrings.
        Dim connectionStrings As System.Configuration.ConnectionStringSettingsCollection = System.Configuration.ConfigurationManager.ConnectionStrings

        ' Get the collection enumerator.
        Dim connectionStringsEnum As IEnumerator = connectionStrings.GetEnumerator()

        ' Loop through the collection and 
        ' display the connectionStrings key, value pairs.
        Dim i As Integer = 0
        While connectionStringsEnum.MoveNext()
            Dim name As String = connectionStrings(i).Name
            If (connectionStrings(name).Name.CompareTo(keyName) = 0) Then
                s = connectionStrings(name).ConnectionString
                Return s
            Else
                'ako nije nadjen kljuc, onda uzimamo default-ni
                Dim _def As String = "conn_default"
                's_default = connectionStrings(_def).ConnectionString
                's = s_default
            End If

            i += 1
        End While

        Return s
    End Function

    Public Function SetLabel(izabranJezik As String, conn As String, polje As String, country As String) As String
        Dim ds As DataSet = DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weblabel' and idlang='" + izabranJezik + "'", conn, country)

        Dim dv As DataView = New DataView(ds.Tables(0))
        dv.RowFilter = "POLJE = '" + polje + "'"
        Dim filteredDS As DataSet = New DataSet
        filteredDS.Tables.Add(dv.ToTable())

        Return DajStringPolje(filteredDS, "ttext")
    End Function

    Public Sub SetLabels(container As Control, izabranJezik As String, conn As String, country As String)
        Dim ds As DataSet = DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weblabel' and idlang='" + izabranJezik + "'", conn, country)

        Dim contrlsToTranslate As List(Of Control) = GetControlsStartingWith(container, "trnslt")

        For Each item In contrlsToTranslate
            Dim dv As DataView = New DataView(ds.Tables(0))
            dv.RowFilter = "POLJE = '" + item.ID.Substring(7) + "'"
            Dim filteredDS As DataSet = New DataSet
            filteredDS.Tables.Add(dv.ToTable())

            Dim ctrlID As String = item.ClientID
            Dim fieldValue As String = DajStringPolje(filteredDS, "ttext")

            If TypeOf (item) Is HtmlInputText Then
                CType(item, HtmlInputText).Attributes.Add("placeholder", fieldValue)
            ElseIf (TypeOf (item) Is HtmlInputSubmit) Then
                CType(item, HtmlInputSubmit).Value = fieldValue
            ElseIf (TypeOf (item) Is Label) Then
                CType(item, Label).Text = fieldValue
            ElseIf TypeOf (item) Is HtmlGenericControl Then
                CType(item, HtmlGenericControl).InnerText = fieldValue
            ElseIf TypeOf (item) Is Button Then
                CType(item, Button).Text = fieldValue
            ElseIf TypeOf (item) Is HtmlButton Then
                CType(item, HtmlButton).InnerText = fieldValue
            ElseIf TypeOf (item) Is LinkButton Then
                CType(item, LinkButton).Text = fieldValue
            ElseIf TypeOf (item) Is HyperLink Then
                CType(item, HyperLink).Text = fieldValue
            ElseIf TypeOf (item) Is HtmlInputGenericControl Then
                CType(item, HtmlInputGenericControl).Attributes.Add("placeholder", fieldValue)
            ElseIf TypeOf (item) Is TextBox Then
                CType(item, TextBox).Attributes.Add("placeholder", fieldValue)
            End If
        Next
    End Sub

    Public Function SetError(ds As DataSet, izabranJezik As String, nazivGreske As String) As String

        Dim dv As DataView = New DataView(ds.Tables(0))
        dv.RowFilter = "POLJE = '" + nazivGreske + "'"
        Dim filteredDS As DataSet = New DataSet
        filteredDS.Tables.Add(dv.ToTable())
        Dim fieldValue As String = DajStringPolje(filteredDS, "ttext")

        Return fieldValue
    End Function

    Public Function GetControlsStartingWith(container As Control, idStartsWith As String) As List(Of Control)
        Dim controlsList As New List(Of Control)

        ' Recursive procedure to search controls
        Dim searchControls As Action(Of Control) = Nothing
        searchControls = Sub(ctrl As Control)
                             For Each childCtrl As Control In ctrl.Controls
                                 ' Check if the control's ID starts with the specified string
                                 If Not childCtrl.ID Is Nothing Then
                                     If childCtrl.ID.StartsWith(idStartsWith, StringComparison.OrdinalIgnoreCase) Then
                                         controlsList.Add(childCtrl)
                                     End If

                                 End If
                                 ' If the control has children, search them as well
                                 If childCtrl.HasControls Then
                                     searchControls(childCtrl)
                                 End If
                             Next
                         End Sub

        searchControls(container)
        Return controlsList
    End Function

    Public Function DajStringPolje(ds As DataSet, Polje As String) As String
        If ds.Tables.Count > 0 Then
            If ds.Tables(0).Rows.Count > 0 Then
                Dim Row As DataRow = ds.Tables(0).Rows(0)
                If Not IsDBNull(Row.Item(Polje)) And Row.Item(Polje).ToString() <> "" Then
                    DajStringPolje = Row.Item(Polje).ToString()
                Else
                    DajStringPolje = ""
                End If
            Else
                DajStringPolje = ""
            End If
        Else
            DajStringPolje = ""
        End If
        Return DajStringPolje
    End Function

    Public Function DajTBText(TB As HtmlInputText) As String
        If Trim(TB.Value) <> "" And Trim(TB.Value) <> "&nbsp;" Then
            DajTBText = Trim(TB.Value.ToString())
        Else
            DajTBText = Nothing
        End If
        Return DajTBText
    End Function

    Public Function DajTBTextTB(TB As TextBox) As String
        If Trim(TB.Text) <> "" And Trim(TB.Text) <> "&nbsp;" Then
            DajTBTextTB = Trim(TB.Text.ToString())
        Else
            DajTBTextTB = Nothing
        End If
        Return DajTBTextTB
    End Function

    Public Function DajHIGCText(HIGC As HtmlGenericControl) As String
        If Trim(HIGC.InnerText) <> "" And Trim(HIGC.InnerText) <> "&nbsp;" Then
            DajHIGCText = Trim(HIGC.InnerText.ToString())
        Else
            DajHIGCText = Nothing
        End If
        Return DajHIGCText
    End Function

    Public Sub IsHITError(HIT As HtmlInputText, IsError As Integer, TBKlasa As String, HIGC As HtmlGenericControl)
        Dim Klasa As String = "form-control input-xs " & TBKlasa, Greska As String = "form-control input-xs alpha-danger border border-danger " & TBKlasa, Upozorenje As String = "form-control input-xs alpha-violet border border-warning " & TBKlasa

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

    Public Sub IsValidMsgError(ValidKontrola As HtmlGenericControl, IsError As Integer, Poruka As String)
        Dim Greska As String = "validation-error-label", Upozorenje As String = "regAlert"
        'alert alert-danger shadowBox
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

    Public Function IsValid_DuzinaTekstPolja(TekstPolja As String, minDuzina As Int16, maxDuzina As Int16) As Integer

        Dim result As Boolean = True
        Dim ImaGreske As Integer = 0

        If Not String.IsNullOrEmpty(TekstPolja) Then
            If TekstPolja.Length < minDuzina Or TekstPolja.Length > maxDuzina Then
                result = False
            End If
        End If

        'If Regex.IsMatch(TekstPolja, "[A-ZА-Ш]") Then result = False
        'If Regex.IsMatch(TekstPolja, "\d") Then Else result = False
        If Regex.IsMatch(TekstPolja, "^[0-9]+$") Then Else result = False

        If result = False Then ImaGreske = 1

        Return ImaGreske
    End Function

    Public Sub IsHITErrorTB(HIT As HtmlInputText, IsError As Integer, TBKlasa As String, HIGC As TextBox)
        Dim Klasa As String = "form-control input-xs" & TBKlasa, Greska As String = "form-control input-xs alpha-danger border border-danger" & TBKlasa, Upozorenje As String = "alert alert-danger shadowBox" & TBKlasa

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
                    If HIGC.ClientID.Contains("pig") Then
                        HIGC.CssClass = Klasa
                    Else
                        HIGC.Attributes.Remove("class")
                        HIGC.Attributes.Add("class", Klasa)
                    End If
                Case 1
                    HIGC.Attributes.Remove("class")
                    HIGC.Attributes.Add("class", Greska)
                Case 2
                    If HIGC.ClientID.Contains("pig") Then
                        HIGC.CssClass = Upozorenje
                    Else
                        HIGC.Attributes.Remove("class")
                        HIGC.Attributes.Add("class", Upozorenje)
                    End If
            End Select
        End If
    End Sub

    Public Sub IsInfoError(HIT As HtmlGenericControl, IsError As Integer, TBKlasa As String)
        Dim Klasa As String = "alert alert-info alert-styled-left alert-arrow-left alert-component border-indigo text-indigo-800 pt-2 pb-2" & TBKlasa

        If Not HIT Is Nothing Then
            Select Case IsError
                Case 0
                    HIT.Attributes.Add("class", Klasa)
            End Select
        Else
            ' GRESKA
        End If
    End Sub

    Function SendMail(lang As String, tipSlanja As String, Email As String, Nalog As String, host As String, Optional ds As DataSet = Nothing) As Integer 'As Task(Of Integer)

        Dim callbackUrl As String
        Dim result As Integer = 0
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("natstatcom@stat.kg", "39942463") 'no-replay.ino@stat.gov.rs -T3rmak4
            Smtp_Server.Port = 25 '587
            Smtp_Server.EnableSsl = False
            Smtp_Server.Host = "mail.stat.kg" ' mail.stat.gov.rs

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("natstatcom@stat.kg") 'popis.ino@stat.gov.rs
            e_mail.To.Add(Email)
            Dim bodystring As String = ""

            If tipSlanja = "verifikacija" Then
                If host.Contains("localhost") Then
                    callbackUrl = "http://" + host + "/Verification.aspx?username=" + Nalog + "&lang=" + lang
                Else
                    callbackUrl = "http://10.1.6.20:8080/Verification.aspx?username=" + Nalog + "&lang=" + lang
                End If

                e_mail.Subject = SetError(ds, lang, "verifikacijanaloga")
                bodystring = "<p>"
                bodystring += SetError(ds, lang, "verifikacijanalogamailtekst")
                bodystring += "<a href='" + callbackUrl + "'>"
                bodystring += SetError(ds, lang, "link")
                bodystring += "</a>.</p>"

                e_mail.Body = bodystring  'txtMessage.Text


            ElseIf tipSlanja = "resetPass" Then
                If host.Contains("localhost") Then
                    callbackUrl = "http://" + host + "/PassRess.aspx?username=" + Email + "&lang=" + lang
                Else
                    callbackUrl = "http://10.1.6.20:8080/PassRess.aspx?username=" + Email + "&lang=" + lang
                End If

                e_mail.Subject = SetError(ds, lang, "resetovanjelozinke")
                bodystring = "<p>"
                bodystring += SetError(ds, lang, "promenalozinkemailtekst")
                bodystring += "<a href='" + callbackUrl + "'>"
                bodystring += SetError(ds, lang, "link")
                bodystring += "</a>.</p>"
                e_mail.Body = bodystring

            ElseIf tipSlanja = "greska kod" Then
                e_mail.Subject = "greska kod"
                e_mail.Body = "<p>greska!. <br>greska priliom slanja mejla</p>" 'txtMessage.Text
            End If

            e_mail.IsBodyHtml = True

            Smtp_Server.SendMailAsync(e_mail)

            Return result + 1
        Catch error_t As Exception
            System.Diagnostics.Trace.TraceError("SendMail error: " & error_t.ToString())
            Return result
        End Try
    End Function

    Public Function ProveraKOR(Username As String, Lozinka As String, Tabela As String, connString As String, country As String) As UserInfo
        'Description trenutno umesto role - zameniti
        Dim Upit As String = "SELECT userId, [dbo].DecryptDIRO(password) as planePass, status, role, okpo FROM " + Tabela + " WHERE userId  = '" & Username & "' AND status = '1'"
        Dim Ds As DataSet = DajDS_IzUpita(Upit, connString, country)
        Dim user As New UserInfo()
        If Ds.Tables.Count = 0 Then
            'postoji user
            user.userCode = 0
            Return user
            'Exit Function
        Else
            'dal je aktivan
            'Dim isActive = DajStringPolje(Ds, "status")
            'If Not Boolean.Parse(isActive) Then
            '    'neaktivan
            '    user.userCode = 0
            '    Return user
            '    'Exit Function
            'End If
        End If

        If Ds.Tables(0).Rows.Count > 0 Then
            Dim planePass = DajStringPolje(Ds, "planePass")
            If Lozinka <> planePass Then
                user.userCode = 0
            Else
                user.Rola = DajStringPolje(Ds, "role")
                user.okpo = DajStringPolje(Ds, "okpo")
                user.userCode = 1
            End If
        Else
            user.userCode = 0
        End If

        Return user
    End Function

    Public Class UserInfo
        Public Property Rola As String
        Public Property userCode As Integer
        Public Property okpo As String
    End Class
End Class
