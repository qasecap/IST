Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports System
Imports System.Globalization
Imports System.Web

Public Class Base_IST_PPP
  
    Dim ISTBAze As New wsOpstiServisi.Service()
    Dim auth As New intraweb_authenticate.wsAuthenticate()
      
    Public Function DajDS_IzUpita(ByVal Upit As String, ByVal konekcija As String) As DataSet
        Dim ResultSet As DataSet = ISTBAze.RunQuery(Upit, konekcija)
        Return ResultSet
    End Function
    Public Function UpisPromenaBrisanje(ByVal Upit As String, ByVal konekcija As String) As String
        Dim rezultat As String = ""
        rezultat = ISTBAze.UpisPromenaBrisanje(Upit, konekcija)
        Return rezultat
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
        On Error GoTo Handler
        Dim varAddress As Object, n As Long, lCount As Long
        varAddress = Split(strIPAddress, ".", , vbTextCompare)
        '// 
        If IsArray(varAddress) Then
            For n = LBound(varAddress) To UBound(varAddress)
                lCount = lCount + 1
                varAddress(n) = CByte(varAddress(n))
            Next
            '// 
            IsValidIPAddress = (lCount = 4)
        End If
        '// 
Handler:
    End Function
End Class
