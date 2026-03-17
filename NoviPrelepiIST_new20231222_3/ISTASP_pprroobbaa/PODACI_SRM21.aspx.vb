Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Web
Imports System.Web.SessionState
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.HtmlControls
Imports System.Text
Imports System.Collections.Generic
Imports AjaxControlToolkit
Imports System.Xml.Linq
Imports System.Net.Mime.MediaTypeNames
Imports MSScriptControl
Imports System.Reflection


'Public Class DynamicControls
Partial Class PODACI_SRM21
    Inherits System.Web.UI.Page
    Public strSQl As String
    Private Shared prevPage As String = String.Empty
    Dim b As New Base_IST_PPP

    'Protected TextBox1 As System.Web.UI.WebControls.TextBox
    'Protected lblResult As System.Web.UI.WebControls.Label
    'Protected lblText As System.Web.UI.WebControls.Label
    'Protected cmdAdd As System.Web.UI.WebControls.Button
    'Protected Button1 As System.Web.UI.WebControls.Button
    'Protected Label1 As System.Web.UI.WebControls.Label
    'Protected Form1 As System.Web.UI.HtmlControls.HtmlForm



    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Me.Session.Add("LastControl", 0)
            Call LoadStrane()
        Else
            RecreatePersistedControls()
        End If
    End Sub

    'Dim ISTttabele() As String = {"IST", "ISTBaze", "ISTTabele", "ISTPolja", "ISTLK", "ISTTABS"}
    'Sub puniDatasetIstrazivanja(ByVal app As String, ByVal vtvt As String, ByVal glavnatabela As String)
    '    Dim dsIST As DataSet
    '    Dim strSQLIST As String = ""
    '    For i As Integer = 0 To ISTttabele.GetUpperBound(0)
    '        strSQLIST = strSQLIST + templateISTsql(app, ISTttabele(i), glavnatabela, vtvt)
    '    Next
    '    strSQLIST = strSQLIST.TrimEnd(";")
    '    dsIST = b.DajDS_IzUpita(strSQLIST, Me.DBConnectionString.Text)
    '    Session.Add("dsIST", dsIST)
    'End Sub
    'Function templateISTsql(ByVal app As String, ByVal ISTtabela As String, ByVal glavnatabela As String, ByVal vtvt As String) As String
    '    Dim str As String = "" : Dim dodatak As String = " " : Dim oorderby As String = " "
    '    If ISTtabela = "ISTTabele" OrElse "ISTPolja" OrElse "ISTLK" Then
    '        dodatak = " and tabela='" + glavnatabela + "'"
    '    End If
    '    If ISTtabela = "ISTPolja" Then
    '        oorderby = " order by ist, tabela,rbr"
    '    End If
    '    str = "select *  FROM " + ISTtabela + " where sifist='" + app + "'" + dodatak +
    '                                " and vod<= CONVERT(datetime, DATEADD(month, DATEDIFF(month, 0, '" + vtvt + "'), 0), 126) " +
    '                                " and '" + vtvt + "' <= vdo" + oorderby + ";"
    '    Return str
    'End Function
    Sub LoadStrane()
        Me.DBConnectionString.Text = "Data Source=IMT2.statsrb.lan;Initial Catalog=KIRGISTAN;User ID=IST_PPP;Password=Gilgames"
        Me.ISTConnectionString.Text = "Data Source=IMT2.statsrb.lan;Initial Catalog=IST;User ID=IST_PPP;Password=Gilgames"
        Dim app As String = "z6041017"
        Dim vtvt As String = "2023-10-01"
        Dim glavnatabela As String = "Employment_Monthly"
        Call puniDatasetIstrazivanja(app, vtvt, glavnatabela)
        'Call dsIzSesijeCBO()
        'Call popuniCBO(ByVal app As String)
    End Sub
    Sub puniDatasetIstrazivanja(ByVal app As String, ByVal vtvt As String, ByVal glavnatabela As String)
        Dim dsISTPolja As DataSet
        Dim strSQLISTPolja As String = "exec usp_WebLocations @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + glavnatabela + "'"
        dsISTPolja = b.DajDS_IzUpita(strSQLISTPolja, Me.ISTConnectionString.Text)
        Session.Add("dsISTPolja", dsISTPolja)

    End Sub

    Sub popuniCBO()
        Dim nname As String = ""
        For Each cntl In Panel1.Controls
            If TypeOf (cntl) Is DropDownList Then
                Dim ccbox As DropDownList = CType(Panel1.FindControl(nname), DropDownList)
            End If
        Next
        Dim cbox As DropDownList = CType(Panel1.FindControl(nname), DropDownList)
        Call popuniCBOizvor(cbox, "ds0", "mbops", "NAZIVL")
    End Sub
    Public Sub popuniCBOizvor(ByVal cbox As DropDownList, ByVal dsIme As String, ByVal ubazu As String, ByVal prikazi As String)
        Dim ds As DataSet
        ds = Session(dsIme)
        cbox.DataSource = ds
        cbox.DataValueField = ubazu
        cbox.DataTextField = prikazi
        cbox.DataBind()
        cbox.Items().Insert(0, "")
        cbox.SelectedIndex = 0
    End Sub
    Sub dsIzSesijeCBO()
        Dim ds As DataSet
        Dim strSQL As String
        strSQL = "select *  FROM rpj.DBO.Opstine"
        ds = b.DajDS_IzUpita(strSQL, Me.DBConnectionString.Text)
        Session.Add("ds0", ds)
    End Sub
    Private Sub RecreatePersistedControls()
        If Not Me.Session("DynamicControls") Is Nothing Then
            Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
            If al IsNot Nothing Then
                For Each ci As ControlInfo In al
                    Call CreateControl(ci)
                Next
            End If
        End If
    End Sub

    Private Function CreateControl(ByVal ci As ControlInfo) As Control
        Dim ctl As Control = Nothing

        Select Case ci.Type
            Case "Button"
                ctl = New Button()
                CType(ctl, Button).Style("Position") = "Absolute"
                CType(ctl, Button).Style("Top") = ci.ttop.ToString()
                CType(ctl, Button).Style("Left") = ci.lleft.ToString()

                Me.AppendEvent(ctl, ci.EventHandler)
            Case "TextBox"
                ctl = New TextBox()
                CType(ctl, TextBox).Style("Position") = "Absolute"
                CType(ctl, TextBox).Style("top") = ci.ttop.ToString()
                CType(ctl, TextBox).Style("left") = ci.lleft.ToString()
                CType(ctl, TextBox).Style("z-Index") = ci.zindex.ToString()

                CType(ctl, TextBox).Width = ci.wwidth
                CType(ctl, TextBox).Height = ci.hheight
                CType(ctl, TextBox).Text = ci.ttext.ToString()
                CType(ctl, TextBox).ReadOnly = ci.rReadOnly
                CType(ctl, TextBox).Visible = ci.vvisible

                CType(ctl, TextBox).AutoPostBack = True
                Me.AppendEvent(ctl, ci.EventHandler)
            Case "CBOX"
                ctl = New DropDownList()
                CType(ctl, DropDownList).Style("Position") = "Absolute"
                CType(ctl, DropDownList).Style("Top") = ci.ttop.ToString()
                CType(ctl, DropDownList).Style("Left") = ci.lleft.ToString()
                CType(ctl, DropDownList).AutoPostBack = True
                Me.AppendEvent(ctl, ci.EventHandler)
            Case "Label"
                ctl = New Label()
                CType(ctl, Label).Style("Position") = "Absolute"
                CType(ctl, Label).Style("Top") = ci.ttop.ToString()
                CType(ctl, Label).Style("Left") = ci.lleft.ToString()
                CType(ctl, Label).Style("z-Index") = ci.zindex.ToString()
            Case Else
                Return Nothing
        End Select
        ctl.ID = ci.ID
        Me.Panel1.Controls.Add(ctl)
        Return ctl


    End Function

    Private Sub AppendEvent(ByVal ctl As Control, ByVal handler As String)
        Select Case handler
            Case "Click"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.Button_Click)
            Case "TextChanged"
                AddHandler(CType(ctl, TextBox)).TextChanged, New System.EventHandler(AddressOf Me.TextBox_TextChanged)
            Case "SelectedIndexChanged"
                AddHandler(CType(ctl, DropDownList)).SelectedIndexChanged, New System.EventHandler(AddressOf Me.DropDownList_SelectedIndexChanged)
        End Select
    End Sub



    Private Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblResult.Text = (CType(sender, Button)).Text & " clicked"
        Call enabledFalse("textbox3")
        Call skok("textbox5")
        Call dodela("textbox2", "222")
    End Sub

    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblText.Text = (CType(sender, TextBox)).Text & " text changed"
        Call enabledFalse("textbox3")
        Call dodela("textbox2", "2")
        Call skok("textbox5")
    End Sub
    Private Sub DropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lblText.Text = (CType(sender, DropDownList)).Text & " SelectedIndexChanged"
        Call dodela("textbox3", "2")
        Call skok("textbox6")
    End Sub

    Private Const TOP As Integer = 96
    Private Const HEIGHT As Integer = 22 '48
    'Private Const BUTTON_LEFT As Integer = 48
    'Private Const LABEL_LEFT As Integer = 48
    Private Const TEXTBOX_LEFT As Integer = 128
    'Private Const CBOX_LEFT As Integer = 128
    'Dim ISTttabele() As String = {"IST", "ISTBaze", "ISTTabele", "ISTPolja", "ISTLK", "ISTTABS"}
    Private Structure ControlInfo
        Public ID As String
        Public Type As String
        Public ttop As Integer
        Public lleft As Integer
        Public rReadOnly As Boolean
        Public vvisible As Boolean
        Public ttext As String
        Public wwidth As Integer
        Public hheight As Integer
        Public EventHandler As String
        Public zindex As Integer
    End Structure
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim lastControl As Integer = CInt(Me.Session("LastControl"))
        'Dim count As Integer = lastControl / 2 + 1
        Dim count As Integer = lastControl / 2 + 1
        Dim ci As ControlInfo
        'textbox
        Dim dsISTPolja As DataSet
        dsISTPolja = Session("dsISTPolja")
        'istpolja

        Dim lleft As String = TEXTBOX_LEFT
        Dim wwidth As Integer = 100
        Dim hheight As Integer = 22
        Dim ttext As String = ""

        'Dim ttop As Integer = TOP + HEIGHT * (count - 1)
        Dim rreadOnly As Boolean = True
        Dim vvisible As Boolean = True

        Dim ttop As Integer = 10 'odakle krecem
        Dim zzindex As String = "1"
        For i As Integer = 0 To dsISTPolja.Tables(0).Rows.Count - 1
            Dim red As DataRow = dsISTPolja.Tables(0).Rows(i)
            Select Case red.Item("PP2").ToString.Trim.ToUpper
                Case "LABEL"
                    rreadOnly = True
                    ttext = red.Item("izraz").replace("'", "")
                Case "TEXTBOX"
                    rreadOnly = False
                    ttext = ""
                Case "VIRTUAL FIELD"
                    rreadOnly = True
                    ttext = red.Item("izraz").replace("'", "")
                Case Else
                    rreadOnly = False
                    ttext = ""
            End Select

            If red.Item("wwidth") <> "" AndAlso IsNumeric(red.Item("wwidth")) Then wwidth = red.Item("wwidth") Else wwidth = 100
            If wwidth = 0 Then vvisible = False Else vvisible = True
            hheight = red.Item("hheight")

            ttop = red.Item("locy") * 1.2
            lleft = red.Item("locx") * 1.2


            If hheight > 22 Then
                zzindex = "1"
            Else
                zzindex = "0"
            End If

            hheight = hheight * 1.2
            wwidth = wwidth * 1.2

            ci = PersistControl("TP_" & red.Item("polje").ToString(), "TextBox", ttop, lleft, wwidth, hheight, ttext, rreadOnly, vvisible, zzindex, "TextChanged")
            CreateControl(ci)



            'ttop = ttop + hheight + 1



            count = count + 1
        Next

        Me.Session("LastControl") = count + 1

    End Sub

    Private Function PersistControl(ByVal id As String, ByVal type As String, ByVal ttop As Integer, ByVal lleft As Integer, ByVal wwidth As Integer, ByVal hheight As Integer, ByVal ttext As String, ByVal rreadOnly As Boolean, ByVal vvisible As Boolean, ByVal zzindex As String, ByVal eventHandler As String) As ControlInfo
        Dim ci As ControlInfo = New ControlInfo()
        ci.ID = id  'name
        ci.Type = type
        ci.ttop = ttop
        ci.lleft = lleft
        ci.rReadOnly = rreadOnly
        ci.vvisible = vvisible
        ci.ttext = ttext
        ci.wwidth = wwidth
        ci.hheight = hheight
        ci.zindex = zzindex
        ci.EventHandler = eventHandler

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)

        If al Is Nothing Then
            al = New ArrayList()
        End If

        al.Add(ci)
        Me.Session("DynamicControls") = al
        Return ci
    End Function

    Private Sub enabledFalse(ByVal nname As String)
        Dim txt As TextBox = CType(Panel1.FindControl(nname), TextBox)
        If Not txt Is Nothing Then txt.Enabled = Not txt.Enabled
    End Sub
    Private Sub skok(ByVal nname As String)
        Dim txt As TextBox = CType(Panel1.FindControl(nname), TextBox)
        If Not txt Is Nothing Then txt.Focus()
    End Sub
    Private Sub dodela(ByVal nname As String, ByVal vrednost As String)
        Dim txt As TextBox = CType(Panel1.FindControl(nname), TextBox)
        Dim p As String
        If Not txt Is Nothing Then
            p = txt.Text
            If p = "" Then p = "0"
            txt.Text = CStr(CInt(p) + 1)   'ili vrednost
        End If
    End Sub




End Class


''Option Strict On
'Imports System.Data
'Imports System.Data.OleDb
'Imports System.Data.SqlClient
'Imports System.Web.UI.Page
'Imports System.Web.UI.WebControls
'Imports System.IO
'Imports System.Text
'Imports System.Collections.Generic
'Imports System.Linq

'Partial Class PODACI_SRM21
'    Inherits System.Web.UI.Page
'    Public strSQl As String
'    Private Shared prevPage As String = String.Empty
'    Dim b As New Base_IST_PPP


'    Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
'        Dim stringWriter As New System.IO.StringWriter()
'        Dim htmlWriter As New HtmlTextWriter(stringWriter)
'        MyBase.Render(htmlWriter)
'        Dim html As String = stringWriter.ToString()
'        html = Regex.Replace(html, "/>\s{2, 4}<input", "/>" + String.Empty + "<input")
'        html = Regex.Replace(html, "/>\s{2, 4}<span", "/>" + String.Empty + "<span")
'        html = Regex.Replace(html, "/>\s{2, 4}<Select", "/>" + String.Empty + "<Select")
'        writer.Write(html)
'    End Sub

'    Sub Page_Load(ByVal Src As Object, ByVal E As EventArgs) Handles Me.Load
'        Try
'            If Not IsPostBack Then    'crtam se prvi put
'                If (Session("Rola") <> Nothing) Then
'                    Call CRTAJ()

'                Else    'NEMA ROLU
'                    Response.Redirect("Default.aspx", False)
'                    HttpContext.Current.ApplicationInstance.CompleteRequest()
'                End If
'            End If 'Not IsPostBack
'        Catch ex As Exception
'            Response.Write("<p align=center>" & ex.Message & "-" & ex.StackTrace)
'        Finally
'        End Try
'    End Sub
'    Function RepeatStrBuilder(ByVal text As String, ByVal n As UInteger) As String
'        Return New StringBuilder(text.Length * CInt(n)).Insert(0, text, CInt(n)).ToString()
'    End Function
'    Private Sub GetValues()
'        ''Me.Panel1.Controls.Clear()
'        ''CreateTextBox()
'        'Dim objBuilder As StringBuilder = New StringBuilder()
'        'Dim Id As String = ""

'        'For i As Integer = 1 To 4
'        '    Id = "Text22" & Convert.ToString(i)
'        '    Dim tb As TextBox = (CType(Me.Page.FindControl(Id), TextBox))

'        '    If tb IsNot Nothing Then
'        '        objBuilder.Append("Text22" & Convert.ToString(i) & " Value = " + tb.Text)
'        '    End If
'        'Next
'    End Sub
'    Sub CRTAJ()
'        Dim i As Integer
'        Dim numlabels As Integer

'        ' Get the number of labels to create.
'        numlabels = 500
'        Dim pp As String
'        For i = 1 To numlabels
'            Dim myLabel As Label = New Label()
'            'Set the label's Text and ID properties.
'            'pp = RepeatStrBuilder("asdf", i)
'            myLabel.Text = "Label " & i '& pp
'            myLabel.ID = "Label" & i
'            PlaceHolder1.Controls.Add(myLabel)
'            Dim tb As TextBox = New TextBox()
'            ' Set the label's Text and ID properties.
'            tb.Text = "Text" & i
'            tb.ID = "Text22" & i
'            'tb.AutoPostBack = True
'            'tb.CausesValidation = True
'            'tb.Width = i * 100
'            AddHandler tb.TextChanged, AddressOf tb_textchanged

'            PlaceHolder1.Controls.Add(tb)

'            Dim rfvtxt = New RegularExpressionValidator()
'            rfvtxt.Display = ValidatorDisplay.Dynamic
'            rfvtxt.ControlToValidate = tb.ID
'            rfvtxt.ErrorMessage = "Minimalna dužina polja je 2!"
'            rfvtxt.ToolTip = "Minimalna dužina polja je 2!"
'            rfvtxt.SetFocusOnError = True
'            rfvtxt.ValidationExpression = "^.{2,}$"
'            rfvtxt.Text = " **Minimalna dužina polja je 2! for" + "Text" & i ' "*"
'            rfvtxt.EnableClientScript = True
'            rfvtxt.Attributes.Add("style", "color: Red;")
'            PlaceHolder1.Controls.Add(rfvtxt)
'            Dim rfv1 As New RangeValidator()
'            rfv1.Display = ValidatorDisplay.Dynamic
'            rfv1.ControlToValidate = tb.ID
'            rfv1.Text = " **Vrednost mora biti između 21 i 27! for" + "Text" & i ' "*"
'            rfv1.MinimumValue = "21"
'            rfv1.MaximumValue = "27"
'            rfv1.SetFocusOnError = True
'            rfv1.EnableClientScript = True
'            rfv1.Attributes.Add("style", "color: Blue;")
'            rfv1.Type = ValidationDataType.Integer
'            PlaceHolder1.Controls.Add(rfv1)

'            'Dim ff = New FilteredTextBoxExtender()
'            '<asp:FilteredTextBoxExtender ID = "ftbeTK_SIF" runat="server" TargetControlID="TK_SIF"
'            'FilterType = "Custom" ValidChars="0123456789" />
'            ' Add a spacer in the form of an HTML <br /> element
'            Dim spacer As LiteralControl = New LiteralControl("<br />")
'            PlaceHolder1.Controls.Add(spacer)


'        Next

'        Call GetValues()
'    End Sub

'    Sub tb_textchanged(ByVal sender As Object, ByVal e As EventArgs)
'        lblKonekcija.Text = "You textchanged the tb labeled " & sender.ID
'        Response.Write("You textchanged the tb labeled " & sender.ID)
'    End Sub

'    Protected Sub TK_MES_TextChanged(sender As Object, e As EventArgs) Handles TK_MES.TextChanged

'        lblKonekcija.Text = "You textchanged the tb labeled " & sender.ID
'    End Sub
'End Class
