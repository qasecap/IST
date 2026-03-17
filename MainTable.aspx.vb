
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
Imports TextBox = System.Web.UI.WebControls.TextBox
Imports Label = System.Web.UI.WebControls.Label
Imports System.Net
Imports Microsoft.VisualBasic.Devices
Imports System.Linq
Imports System.Reflection.Emit
Imports System.Linq.Expressions
Imports System.Web.Services
Imports System.Configuration
Imports System.Data.SqlClient
Imports AjaxControlToolkit.HTMLEditor.ToolbarButton
Imports System.Net.WebRequestMethods
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Numerics
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Runtime.Remoting
Imports System.Runtime.InteropServices
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq


Partial Class MainTable
    Inherits System.Web.UI.Page
    Public strSQl As String
    Private Shared prevPage As String = String.Empty
    Dim b As New Base_IST_PPP
    Dim t As New Template
    Dim conn As String = b.GetConnStr("connIST") '"Data Source=IMT2.statsrb.lan;Initial Catalog=IST;User ID=IST_PPP;Password=Gilgames" 'b.connIST
    Dim office As String = ""

    'Protected Overrides Sub Render(writer As HtmlTextWriter)
    '    Using sw As New StringWriter()
    '        Using tw As New HtmlTextWriter(sw)
    '            MyBase.Render(tw)
    '            Dim renderedContent As String = sw.ToString()

    '            ' Specify the path to your desktop
    '            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    '            Dim filePath As String = Path.Combine(desktopPath, "SavedPage.html")

    '            ' Save to a file on the desktop
    '            IO.File.WriteAllText(filePath, renderedContent)
    '        End Using
    '    End Using

    '    'MyBase.Render(writer)
    'End Sub

    Protected Overrides Sub OnInit(e As EventArgs)

        Dim cultureInfo As New CultureInfo("en-US")
        cultureInfo.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture = cultureInfo
        Thread.CurrentThread.CurrentUICulture = cultureInfo
        MyBase.OnInit(e)

        MyBase.OnInit(e)
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dsErrors As DataSet = b.DajDS_IzUpita("SELECT * FROM [ISTLabels] WHERE sifist='weberror' and idlang='" + Session("izabranJezik") + "'", conn, Session("Country"))
        Session("dsErrors") = dsErrors
        If (Session("NALOG") <> Nothing AndAlso Session("NALOG") <> "") Then
            If Not Me.IsPostBack Then
                IsCollapsed = False ' default shown
                Call ResetSessions()
                Call GetParameters()
                Call LoadPage()
                Call triggerAutoComplete()
                Dim myMasterPage As MasterPage = TryCast(Me.Master, MasterPage)
                If myMasterPage IsNot Nothing Then AddHandler myMasterPage.MasterPageDDLChanged, AddressOf MasterPageDDLChanged
                Dim al As ArrayList = CType(Me.Session("DynamicControlsNavigation"), ArrayList)
                Dim ciN As ControlInfoNavigation = al(0)
                If Not ciN.ID Is Nothing AndAlso ciN.ID.IndexOf("NB_") = 0 Then
                    Dim b2 As WebControls.LinkButton = CType(MyPanel.FindControl(ciN.ID), WebControls.LinkButton)
                    If Not b2 Is Nothing Then b2.CssClass = "buttonActive"
                End If
            Else
                Dim myMasterPage As MasterPage = TryCast(Me.Master, MasterPage)
                If myMasterPage IsNot Nothing Then
                    AddHandler myMasterPage.MasterPageDDLChanged, AddressOf MasterPageDDLChanged
                End If

                RecreatePersistedControlsNavigation()
                RecreatePersistedControlsSave()
                RecreatePersistedControls()
                RecreatePersistedControlsGrid()
                'if Request.Form("__EVENTTARGET").Contains("$gvFiles") then
                If Session("gvFilesOpen") Then
                    CreateGridGuide()
                End If
                'ovo vazi za rowDeleting
                If Not Session("visibleTableGrid") Is Nothing AndAlso Session("visibleTableGrid") <> "" Then
                    Dim gvID As String = Session("visibleTableGrid")
                    gvID = gvID.Replace("TableGrid", "GV")
                    Dim controlID As String = Request.Params("__EVENTTARGET")
                    If Not String.IsNullOrEmpty(controlID) Then
                        ' Find the control
                        Dim control As Control = Page.FindControl(controlID)
                        If Not control Is Nothing Then
                            If control.ID = gvID Then
                                Call resetSnackBar()
                            End If
                        End If
                    Else
                        Dim panel As ContentPlaceHolder = CType(Form.FindControl("bodyMainTable"), ContentPlaceHolder)
                        Dim snack As HtmlGenericControl = CType(panel.FindControl("snackbar"), HtmlGenericControl)

                    End If
                Else
                    Dim panel As ContentPlaceHolder = CType(Form.FindControl("bodyMainTable"), ContentPlaceHolder)
                    Dim snack As HtmlGenericControl = CType(panel.FindControl("snackbar"), HtmlGenericControl)

                End If
            End If
        Else    'NEMA ROLU
            Response.Redirect("Default.aspx")
            HttpContext.Current.ApplicationInstance.CompleteRequest()
        End If
    End Sub



    Private Sub MasterPageDDLChanged(sender As Object, e As EventArgs)
        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)

        Dim app As String = Session("appcode")
        Dim vtvt As String = Session("gg") + "-" + String.Format("{0:d2}", Session("mm")) + "-01" '"2023-10-01"       

        Dim maintable As String = Session("maintable")
        Dim ds As DataSet
        Dim sql As String = "exec usp_WebLocations @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + maintable + "',@IDLANG='" + Session("izabranjezik") + "'"

        ds = b.DajDS_IzUpita(sql, conn, Session("Country"))
        Dim nn() As String
        Dim ind As Integer = -1
        Dim ppmt() As String


        If ds.Tables.Count > 0 Then
            Dim drT As DataRow()
            drT = ds.Tables(0).Select("pp2='Label'")
            For i As Integer = 1 = 0 To drT.Count - 1
                Dim nname As String = drT(i).Item("polje")
                'If nname.indexof("listpk")=0 Then nname=nname.Substring(6)
                ind = ind + 1
                ReDim Preserve nn(ind)
                ReDim Preserve ppmt(ind)
                nn(ind) = nname
                ppmt(ind) = drT(i).Item("izraz")
            Next

        End If



        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.Type = "Label" Then
                For m As Integer = 0 To nn.GetUpperBound(0)
                    If ci.ID.Substring(3).Trim.ToUpper = nn(m).Trim.ToUpper Then
                        ci.ttext = ppmt(m).Replace("'", "")
                    End If
                Next



            End If
            al(i) = ci
        Next
        Me.Session("DynamicControls") = al
        Response.Redirect(Request.RawUrl)


    End Sub

    Sub triggerAutoComplete()
        Dim script As String = "function triggerAutoComplete() {" +
                       "    var extenders = Sys.Application.getComponents();" +
                       "    for (var i = 0; i < extenders.length; i++) {" +
                       "        if (Sys.Extended.UI.AutoCompleteBehavior.isInstanceOfType(extenders[i])) {" +
                       "            extenders[i]._onGotFocus();" +
                       "        }" +
                       "    }" +
                       "}" +
                       "Sys.Application.add_load(function() {" +
                       "    var textBoxes = document.querySelectorAll('input[type=text]');" +
                       "    for (var j = 0; j < textBoxes.length; j++) {" +
                       "        textBoxes[j].onfocus = triggerAutoComplete;" +
                       "    }" +
                       "});"

        Page.ClientScript.RegisterStartupScript(Me.GetType(), "AutoCompleteScript", script, True)
    End Sub
    Sub ResetSessions()
        'session (logovan) se ne brise
        'session (pkinit)
        'session (pkinitValue)          
        Me.Session("gvPageIndex") = Nothing
        Me.Session("prviukljucuD") = Nothing
        Me.Session("prviukljucuDTP") = Nothing
        Me.Session("provera") = Nothing
        Me.Session("DynamicControls") = Nothing
        Me.Session("DynamicControlsNavigation") = Nothing
        Me.Session("DynamicControlsSave") = Nothing
        Me.Session("DynamicControlsGrid") = Nothing

        Me.Session("pkCurrentTable") = Nothing
        Me.Session("pkCurrentTableValue") = Nothing
        Me.Session("pkPreviousTable") = Nothing
        Me.Session("pkPreviousTableValue") = Nothing

        Me.Session("masterTabledsDB") = Nothing
        Me.Session("subTable") = Nothing
        Me.Session("dsDB") = Nothing
        Me.Session("dsISTLK") = Nothing
        Me.Session("dsISTLKPolja") = Nothing
        Me.Session("dsIST") = Nothing
        Me.Session("dsISTTabele") = Nothing
        Me.Session("dsISTLKRelacija") = Nothing
        Me.Session("datarowgrid") = Nothing
        Me.Session("visibleTab") = Nothing
        Me.Session("visibleTableGrid") = Nothing

        Me.Session("arrayFP") = Nothing
        Me.Session("arrayFPPK") = Nothing
        Me.Session("arrayFPNPK") = Nothing
        Me.Session("arrayFPE") = Nothing
        Me.Session("arrayFPPMW") = Nothing
        Me.Session("arrayFPPM") = Nothing

        Me.Session("arrayttabindex") = Nothing
        Me.Session("arrayttabindexF") = Nothing
        Me.Session("arrayttabindexTPF") = Nothing
        Me.Session("arrayttabindexPK") = Nothing

        Me.Session("arrayttabindexPK") = Nothing
        Me.Session("arrayContextKey") = Nothing
        Me.Session("arrayContextKeySQL") = Nothing
        Me.Session("arrayContextKeySQLGET") = Nothing
        Me.Session("arrayContextKeyDM") = Nothing
        Me.Session("arrayContextKeyFilter") = Nothing
        Me.Session("arrayContextKeyFilterTN") = Nothing

        Me.Session("dsDDL") = Nothing
        Me.Session("nddl") = Nothing


        If Not Me.Session("filter") Is Nothing Then
            Me.Session("filter") = Me.Session("filter").trimend(";")
            Dim pp() As String = Me.Session("filter").trim.split(";")
            For i As Integer = 0 To pp.GetUpperBound(0)
                Me.Session(pp(i)) = Nothing
            Next
            Me.Session("filter") = Nothing
        End If
    End Sub

   Sub GetParameters(Optional pCode As String = Nothing, Optional pValue As String = Nothing)
        Dim maintable As String = ""
        maintable = getMainTable()
        Session("MainTable") = maintable

        Dim pkInitValue As String = ""
        Dim pkInit As String = ""
        'Dim dk() As String = Session("dk")
        Dim dk() As String = Split(Session("ChildPKSmg").ToString.ToLower, ",")

        'For i As Integer = 0 To dk.GetUpperBound(0)
        '    pkInit = pkInit + dk(i).Trim + ";"
        '    'Dim value = Request.QueryString.Item(dk(i).Trim)
        '    Dim value = Session("keysDict")(dk(i).Trim.ToUpper)

        '    If value Is Nothing Then
        '        If pValue Is Nothing Then
        '            If Session("Office") = "KGZ" AndAlso dk(i).ToLower.Trim = "period" Then
        '                pkInitValue = pkInitValue + Session("TIP").ToString.Trim + ";"
        '            Else
        '                pkInitValue = pkInitValue + "''" + ";"
        '            End If

        '        Else
        '            pkInitValue = pkInitValue + pValue + ";"
        '        End If

        '    Else
        '        'ne treba kgz
        '        'value = b.Decrypt(value)
        '        pkInitValue = pkInitValue + value + ";"
        '    End If
        'Next

        ' Dim dk() As String = Split(Session("ChildPKSmg").ToString.ToLower, ",")

        For i As Integer = 0 To dk.GetUpperBound(0)
            pkInit = pkInit + dk(i).Trim + ";"

            Dim keyName As String = dk(i).Trim.ToUpper
            Dim value As Object = Nothing

            ' 🔹 если состав ключей содержит PERIOD → берем из Session("keysDict")
            ' 🔹 если состав ключей содержит USERN → берем из QueryString
            ' 🔹 иначе — можно задать дефолтную логику
            If Session("ChildPKSmg").ToString.ToUpper.Contains("PERIOD") Then
                If Session("keysDict").ContainsKey(keyName) Then
                    value = Session("keysDict")(keyName)
                End If

            ElseIf Session("ChildPKSmg").ToString.ToUpper.Contains("USERN") Then
                value = Request.QueryString.Item(dk(i).Trim)

            Else
                ' по умолчанию, если не попадает под условия
                If Session("keysDict").ContainsKey(keyName) Then
                    value = Session("keysDict")(keyName)
                Else
                    value = Request.QueryString.Item(dk(i).Trim)
                End If
            End If

            ' 🔹 дальше стандартная логика
            If value Is Nothing Then
                If pValue Is Nothing Then
                    If Session("Office") = "KGZ" AndAlso dk(i).ToLower.Trim = "period" Then
                        pkInitValue = pkInitValue + Session("TIP").ToString.Trim + ";"
                    Else
                        pkInitValue = pkInitValue + "''" + ";"
                    End If
                Else
                    pkInitValue = pkInitValue + pValue + ";"
                End If
            Else
                pkInitValue = pkInitValue + value + ";"
            End If
        Next

        Dim vtvt As String = Session("gg") + "-" + String.Format("{0:d2}", Session("mm")) + "-01" '"2023-10-01"
        Session("mes") = Session("mm")
        Session("god") = Session("gg")
        Dim dsISTLKRelacija As New DataSet
        Dim strSQLISTLKRelacija As String = "exec usp_WebLKRelacija @vt='" + vtvt + "',@sifIST=N'" + Session("appcode").Trim + "',@tabela=N'" + maintable + "'" ', @idLang=N'" + Session("izabranjezik") + "'
        dsISTLKRelacija = b.DajDS_IzUpita(strSQLISTLKRelacija, conn, Session("Country"))
        Session.Add("dsISTLKRelacija", dsISTLKRelacija)

        Dim dbconnectionstring As String = dsISTLKRelacija.Tables(0).Rows(0).Item("DBconnectionstring")
        'If dbconnectionstring.Contains("ZSZ") Then dbconnectionstring=dbconnectionstring.Replace("ZSZ", "14TORG")
        'If dbconnectionstring.Contains("imt2") Then dbconnectionstring=dbconnectionstring.Replace("imt2", "172.16.18.20")
        Dim GM As String = setPMGK(dbconnectionstring)
        Dim ggmm As String = "" : Dim ssggmm As String = ""

        If GM = "G" Then ggmm = "GOD;" : ssggmm = Session("gg") + ";"
        If GM = "GM" Then ggmm = "GOD;MES;" : ssggmm = Session("gg") + ";" + Session("mm") + ";"
        If GM = "Y" Then ggmm = "ISTYear;" : ssggmm = Session("gg") + ";"
        If GM = "YM" Then ggmm = "ISTYear;ISTMonth;" : ssggmm = Session("gg") + ";" + Session("mm") + ";"

        Session("pkInit") = ggmm + pkInit.TrimEnd(";")
        Session("pkInitValue") = ssggmm + pkInitValue.TrimEnd(";")

        'If Session("office") = "KGZ" Then
        'If Session("appcode") <> "adminweb" Then
        'Session("pkInit") = Session("pkInit") + ";" + "PERIOD"
        'Session("pkInitValue") = Session("pkInitValue") + ";" + Session("TIP").ToString.Trim
        'End If
        'End If

        Session("maintable") = maintable
        Session("pkCurrentTable") = Session("pkInit").ToString.Trim.ToUpper
        Session("pkCurrentTableValue") = Session("pkInitValue")


        Session("classic") = False
        If Session("mode") = "classic" Then
            Session("classic") = True
        End If
    End Sub
    Function getMainTable() As String

        getMainTable = ""
        Dim vtvt As String = Session("gg") + "-" + String.Format("{0:d2}", Session("mm")) + "-01" '"2023-10-01"
        Dim appcode As String = Session("appcode")
        Dim dsISTTabele As New DataSet

        Dim strSQLISTTabele As String = "exec usp_WebLocationsTablesNew @vt='" + vtvt + "',@sifIST=N'" + appcode.Trim + "',@IDLANG=N'" + Session("izabranjezik") + "'"
        dsISTTabele = b.DajDS_IzUpita(strSQLISTTabele, conn, Session("Country"))

        If dsISTTabele.Tables.Count > 0 Then
            Dim drT As DataRow()
            drT = dsISTTabele.Tables(0).Select("DG='G'")
            If drT.Count > 0 Then
                getMainTable = drT(0).Item("tabela").ToString

                Dim childPKS As String = ""

                If drT(0).Item("childPKS").ToString.Contains("GOD") Then

                    childPKS = drT(0).Item("childPKS").ToString.Replace("GOD,", "")

                End If

                If childPKS.Contains("MES") Then

                    childPKS = childPKS.Replace("MES,", "")

                End If

                Session.Add("ChildPKSmg", childPKS)
            End If

        End If
        Return getMainTable
    End Function
    Sub LoadPage(Optional podtabela As Boolean = False, Optional gridadd As String = "")

        Me.lblappcode.Text = Session("appcode")
        Me.lblgg.Text = Session("gg")
        Me.lblmm.Text = Session("mm")
        Me.lblUser.Text = Session("uuser")
        Dim appcode As String = Session("appcode")
        Dim vtvt As String = Session("gg") + "-" + String.Format("{0:d2}", Session("mm")) + "-01" '"2023-10-01"   
        Dim gg As String = Session("gg")
        Dim mm As String = String.Format("{0:d2}", Session("mm"))
        Dim maintable As String = Session("maintable")
        Dim uuser As String = Session("uuser")
        Dim subTable As String = ""
        Call PuniDatasetIstrazivanja(appcode, vtvt, maintable, podtabela, gridadd)

        Call CreateNavigation()
        Call CreateSave()
        If podtabela = False Then
            Call CreatePage()
        Else
            subTable = Session("maintable")
            Session("subTable") = subTable
            If Me.lblDG.Text = "G" Then
                Call CreatePage()
            Else
                Call CreatePage(True, gridadd)
            End If

        End If
        Call CreateGrid()

        If podtabela = False Then
            Call Puni_dsDB()
            'postavi fokus na prvu kontrolu u prvom tabu (myTable3)
            'Dim txt As TextBox = CType(MyPanel.FindControl(firstControl), TextBox)
            'If Not txt Is Nothing Then Page.SetFocus(txt)
        Else
            Call Puni_dsDB(True)
            'postavljen fokus na prvi prazan kljuc
        End If

        Call getVFALL()
        Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
        Dim ct As Control = findControlByName(pkCurrentTable(pkCurrentTable.GetUpperBound(0)))
        Call executeEnabled(ct.ID)
        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")
        Dim arrayttabindexPK() As String = Session("arrayttabindexPK")
        Dim firstControl As String = ""
        For i As Integer = 0 To arrayttabindexPK.GetUpperBound(0)
            If arrayttabindexPK(i) = "0" Then
                firstControl = arrayttabindexTPF(i)
                Exit For
            End If
        Next

        Call ValidateSave(True)
    End Sub

    Sub PuniDatasetIstrazivanja(ByVal app As String, ByVal vtvt As String, ByVal glavnatabela As String, Optional podtabela As Boolean = False, Optional gridadd As String = "")

        Dim dsIST As DataSet
        Dim strSQLIST As String = "exec usp_WebLocations @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + glavnatabela + "',@IDLANG='" + Session("izabranjezik") + "'"
        dsIST = b.DajDS_IzUpita(strSQLIST, conn, Session("Country"))
        Session.Add("dsIST", dsIST)

        Dim pkCurrentTable As String = Session("pkCurrentTable")
        Dim pkCurrentTableValue As String = Session("pkCurrentTableValue")

        If podtabela = True AndAlso gridadd = "Add" Then

            Dim bbb As String = ""
            Dim npkPreviousTable() As String = Session("pkPreviousTable").split(";")
            Dim npkPreviousTableValue() As String = Session("pkPreviousTableValue").split(";")
            Dim npkCurrentTable() As String = Session("pkCurrentTable").split(";")

            If npkPreviousTable.Length < npkCurrentTable.Length Then
                'podtabela, dopuni
                Dim pp() As String = npkPreviousTableValue
                bbb = ""
                For i As Integer = 0 To pp.GetUpperBound(0)
                    bbb = bbb + pp(i) + ";"
                Next
                Session("prviukljucuDTP") = npkCurrentTable(npkPreviousTable.GetUpperBound(0) + 1)

                For i As Integer = npkPreviousTable.GetUpperBound(0) + 1 To npkCurrentTable.GetUpperBound(0)
                    bbb = bbb + "''" + ";"
                Next
            End If
            If npkPreviousTable.Length >= npkCurrentTable.Length Then
                'natabela                 
                Dim pp() As String = npkPreviousTableValue
                bbb = ""
                For i As Integer = 0 To pp.GetUpperBound(0)
                    bbb = bbb + pp(i) + ";"
                Next

            End If
            pkCurrentTableValue = bbb.TrimEnd(";")
            Session.Add("pkCurrentTableValue", pkCurrentTableValue)
        End If

        If podtabela = True AndAlso gridadd = "GridView" Then
            pkCurrentTableValue = pkCurrentTableValue.TrimEnd(";")
            Me.lblInsertUpdate.Text = "U"
        End If

        Dim dsISTTabele As New DataSet

        Dim strSQLISTTabele As String = "exec usp_WebLocationsTablesNew @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@IDLANG=N'" + Session("izabranjezik") + "'"
        dsISTTabele = b.DajDS_IzUpita(strSQLISTTabele, conn, Session("Country"))
        Session.Add("dsISTTabele", dsISTTabele)

        Dim dsISTLK As New DataSet

        If dsISTTabele.Tables.Count > 0 Then

            Dim datarowsGrid As DataRow() = dsIST.Tables(0).Select("pp2='ButtonGrid'")
            Session.Add("datarowsGrid", datarowsGrid)

            Dim strSQLISTLK As String = "exec usp_WebLK @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + glavnatabela + "', @IDLang=N'" + Session("izabranjezik") + "'"
            dsISTLK = b.DajDS_IzUpita(strSQLISTLK, conn, Session("Country"))
            Session.Add("dsISTLK", dsISTLK)

            Dim drT As DataRow()
            drT = dsISTTabele.Tables(0).Select("tabela='" + glavnatabela + "'")
            Dim red As DataRow = drT(0)
            Dim DG As String = red.Item("DG").ToString.Trim.ToUpper
            Dim childPK As String = red.Item("childPK")
            Dim parentPK As String = red.Item("parentPK")
            If DG = "D" Then
                If childPK > parentPK Then
                    DG = "D"
                Else '1-1
                    DG = "G"
                End If
            Else
                'If red.Item("ConnectionString").Contains("ZSZ") Then Me.DBConnectionString.Text=red.Item("ConnectionString").Replace("ZSZ", "14TORG")
                'If red.Item("ConnectionString").Contains("imt2") Then Me.DBConnectionString.Text=Me.DBConnectionString.Text.Replace("imt2", "172.16.18.20")
                Me.DBConnectionString.Text = red.Item("ConnectionString")
            End If

            Me.lblDG.Text = DG
            If podtabela = True AndAlso gridadd = "GridView" Then Me.lblDG.Text = "G"
        Else
            'treba nesto da izadje kao poruka
        End If

        Dim dsISTLKPolja As New DataSet

        Dim strSQLISTLKPolja As String = "exec usp_WebLKPolja @vt='" + vtvt + "',@sifIST=N'" + app.Trim + "',@tabela=N'" + glavnatabela + "'"
        dsISTLKPolja = b.DajDS_IzUpita(strSQLISTLKPolja, conn, Session("Country"))
        'treba prepisati naziv greske iz istlk u istlkpolja / zbog istmsg
        Dim dtISTLK As DataTable = dsISTLK.Tables(0)
        Dim dtISTLKPolja As DataTable = dsISTLKPolja.Tables(0)

        ' Build a lookup from ds1: KeyA -> ValA
        Dim map As New Dictionary(Of String, Object)(StringComparer.OrdinalIgnoreCase)
        For Each r As DataRow In dtISTLK.Rows
            Dim k As String = Convert.ToString(r("rbrgreske"))
            If Not String.IsNullOrEmpty(k) Then
                map(k) = If(IsDBNull(r("nazivgreske")), Nothing, r("nazivgreske"))
            End If
        Next

        ' Overwrite ds2 where keys match
        For Each r As DataRow In dtISTLKPolja.Rows
            Dim k As String = Convert.ToString(r("gr"))
            If Not String.IsNullOrEmpty(k) AndAlso map.ContainsKey(k) Then
                r("nazivgreske") = If(map(k), DBNull.Value)   ' write Nothing as NULL
            End If
        Next
        Session.Add("dsISTLKPolja", dsISTLKPolja)


        Session.Add("dsISTLKPolja", dsISTLKPolja)

        Dim dtt As DataTable = dsIST.Tables(0)
        Dim dr As DataRow() = dtt.Select("isnull(cbodatasource,'')<>'' and isnull(cbosortby,'')='SORT'")
        Dim dlsqlP As String = ""
        Dim dlsqlT As String = ""
        Dim dlsqlCS As String = ""
        For i As Integer = 0 To dr.Count - 1
            dlsqlP = dlsqlP + dr(i).Item("polje").trim.toupper + ";"
            Dim CBODisplayMember As String = dr(i).Item("CBODisplayMember").ToString.Trim
            Dim CBOValueMember As String = dr(i).Item("CBOValueMember").ToString.Trim
            Dim CBOFilter As String = dr(i).Item("CBOFilter").ToString.Trim
            If CBOFilter.Trim = "" Then CBOFilter = "''"
            Dim CBOFilterBy As String = dr(i).Item("CBOFilterBy").ToString.Trim
            If CBOFilterBy.Trim = "" Then CBOFilterBy = "''"
            Dim CBOSortBy As String = dr(i).Item("CBOSortBy").ToString.Trim
            Dim sortby As String = ""
            Dim ssortby As String = "''"
            If CBOSortBy.Trim <> "" Then
                sortby = ", " + CBOSortBy + " as SORT"
                ssortby = " order by " + CBOSortBy
            End If
            Dim sql As String = "select '' as DisplayMember, null as valueMember, null as sort union select " + CBODisplayMember + " as DisplayMember," + CBOValueMember +
                " as ValueMember " + sortby + " from " + dr(i).Item("cbodatasource") + " A" ''-999' umesto null
            If ssortby <> "''" Then sql = sql + ssortby
            dlsqlT = dlsqlT + sql + ";"
        Next
        dlsqlP = dlsqlP.TrimEnd(";")
        Dim nP() As String = dlsqlP.Split(";")
        Session.Add("nddl", nP)
        Dim dsDDL = returnDS(dlsqlT, "usp_WebLocationsPhone" + glavnatabela + ".json", Me.DBConnectionString.Text)
        Session.Add("dsDDL", dsDDL)

    End Sub
    Function returnDSDB(ByVal sql As String, ByVal sqlDBwhere As String, ByVal jjson As String, ByVal conn As String) As DataSet
        Dim ds As New DataSet
        If sqlDBwhere.Trim <> "" Then
            If sqlDBwhere.Trim.ToUpper.IndexOf("WHERE") = 0 Then sqlDBwhere = sqlDBwhere.Trim.Substring(5)
            If sqlDBwhere.Trim.ToUpper.IndexOf("AND") = 0 Then
                sqlDBwhere = "2=2 " + sqlDBwhere
            Else
                sqlDBwhere = "2=2 AND " + sqlDBwhere
            End If
        End If

        Dim dt As New DataTable

        ds = b.DajDS_IzUpita(sql, conn, Session("Country"))

        Return ds
    End Function
    Function returnDS(ByVal sql As String, ByVal jjson As String, ByVal conn As String) As DataSet
        Dim ds As New DataSet
        Dim dt As DataTable

        ds = b.DajDS_IzUpita(sql, conn, Session("Country"))

        Return ds
    End Function

    Sub Puni_dsDB(Optional podtabela As Boolean = False, Optional ddlChange As Boolean = False, Optional value As String = "")

        Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
        Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")

        Dim sqlDB As String = "select * from " + Session("maintable") + " where 2=2 "
        Dim sqlDBwhere As String = ""

        For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
            If ddlChange = True Then
                If pkCurrentTableValue(i) = "''" Then pkCurrentTableValue(i) = value
            End If
            If pkCurrentTableValue(i) = "''" Then pkCurrentTableValue(i) = ""
            sqlDBwhere = sqlDBwhere + " and " + pkCurrentTable(i) + "='" + pkCurrentTableValue(i) + "'"
        Next

        sqlDB = sqlDB + sqlDBwhere

        Dim dsDB As DataSet = b.DajDS_IzUpita(sqlDB, Me.DBConnectionString.Text, Session("Country"))

        If dsDB.Tables(0).Rows.Count = 1 Then
            Me.lblInsertUpdate.Text = "U"       'UPDATE
            Session.Add("dsDB", dsDB)
            Call GetDataIfExists()
            Call getVFALL()
            Call zatvoriOtvori()
        End If

        If dsDB.Tables(0).Rows.Count = 0 Then
            Me.lblInsertUpdate.Text = "I"       'INSERT   
            Dim drNewRow As DataRow = dsDB.Tables(0).NewRow()
            For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                Dim vvalue As String = pkCurrentTableValue(i)
                If vvalue = "''" OrElse vvalue = "" Then
                    drNewRow(pkCurrentTable(i)) = DBNull.Value
                Else
                    drNewRow(pkCurrentTable(i)) = vvalue
                End If
            Next

            If Not Session("dsISTLKRelacija") Is Nothing AndAlso podtabela = False Then
                'XXX OVDE TREBA DODATI IZ RELACIJE DODELU AKO POSTOJI         
                Dim ass As String = ""
                Dim vass As String = ""
                Dim pass() As String = {}
                Dim pvass() As String = {}

                Dim dt As DataTable = Session("dsISTLKRelacija").tables(0)
                If dt.Rows(0).Item("T") <> "" Then
                    Dim pkT As String = dt.Rows(0).Item("pkT")
                    Dim pkR As String = dt.Rows(0).Item("pkR")
                    Dim ppkT() As String = pkT.Split(",")
                    Dim ppkR() As String = pkR.Split(",")
                    Dim sp As String = ""
                    For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                        Dim b As String = pkCurrentTable(i).Trim.ToUpper
                        Dim bv As String = ""
                        Dim v As String = pkCurrentTableValue(i)
                        If v = "''" OrElse v = "" Then
                            bv = ""
                        Else
                            bv = v
                        End If
                        For ii As Integer = 0 To ppkT.GetUpperBound(0)
                            If ppkT(ii).Trim.ToUpper = b Then
                                sp = sp + "R." + ppkR(ii).Trim + "=N'" + v + "' AND "
                                Exit For
                            End If
                        Next
                    Next
                    sp = sp + ";"
                    sp = sp.Replace(" AND ;", "")

                    Dim ssqlR As String = ""
                    If Session("ROLA") = "6" Then
                        ssqlR = dt.Rows(0).Item("ssqlRola6")
                    ElseIf Session("ROLA") = "3" Then
                        ssqlR = dt.Rows(0).Item("ssqlRola3")
                    ElseIf Session("ROLA") = "1" Then
                        ssqlR = dt.Rows(0).Item("ssqlRola11")
                    Else
                        'ako je rola terpod daj mu za 6icu kasnije ce se skratiti po kljkucu
                        ssqlR = dt.Rows(0).Item("ssqlRola6")
                    End If

                    ssqlR = t.replaceYYYMMMUser(ssqlR, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                    ssqlR = ssqlR + " where " + sp
                    Dim dsR As DataSet = b.DajDS_IzUpita(ssqlR, Me.DBConnectionString.Text, Session("Country"))
                    Dim T1 As String = dt.Rows(0).Item("T")
                    Dim R2 As String = dt.Rows(0).Item("R")
                    Dim pT() As String = T1.Split(",")
                    Dim pR() As String = R2.Split(",")
                    For iii As Integer = 0 To pT.GetUpperBound(0)
                        If drNewRow.Table.Columns.Contains(pT(iii).Trim) AndAlso Not IsDBNull(dsR.Tables(0).Rows(0).Item(pT(iii).Trim)) Then
                            Dim vvalue As String = dsR.Tables(0).Rows(0).Item(pT(iii).Trim)
                            If vvalue = "''" OrElse vvalue = "" Then
                                drNewRow(pT(iii).Trim) = DBNull.Value
                            Else
                                drNewRow(pT(iii).Trim) = vvalue
                                ass = ass + pT(iii).Trim + ";"
                                vass = vass + vvalue + ";"
                            End If
                        End If
                    Next
                    ass = ass.TrimEnd(";")
                    vass = vass.TrimEnd(";")
                    pass = ass.Split(";")
                    pvass = vass.Split(";")
                End If
            End If


            dsDB.Tables(0).Rows.Add(drNewRow)
            dsDB.Tables(0).AcceptChanges()
            Call WriteTableData(MyPanel, drNewRow)
            Dim prvi As Boolean = False

            For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                Dim vvalue As String = pkCurrentTableValue(i).Replace(ChrW(&H200B), "").Trim
                If vvalue = "''" OrElse vvalue = "" Then 'podtabela
                    If prvi = False Then
                        SetFocusEvent(pkCurrentTable(i))
                        prvi = True
                        Session("provera") = 0
                    End If
                End If
            Next

            Session.Add("dsDB", dsDB)
        End If
    End Sub
    Sub zatvoriOtvori()
        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")
        Dim arrayttabindexF() As String = Session("arrayttabindexF")
        Dim arraypodtabela() As String = Session("arraypodtabela")
        Dim arrayTabButton() As String = Session("arrayTabButton")
        Dim arrayTabButtonBT() As String = Session("arrayTabButtonBT")

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim skipto As String = ""
        Dim skipif As String = ""
        Dim skippedenabledfalse As String = False
        Dim skippedsetempty As String = False

        Dim vVisibleTrue As String = ""
        Dim vVisibleTrueIf As String = ""
        Dim vVisibleFalse As String = ""
        Dim vVisibleFalseIf As String = ""
        Dim eEnabledTrue As String = ""
        Dim eEnabledTrueIf As String = ""
        Dim eEnabledFalse As String = ""
        Dim eEnabledFalseIf As String = ""

        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID Is Nothing OrElse ci.ID = "" OrElse (ci.ID.Trim.ToUpper.IndexOf("LB_") = 0 OrElse ci.ID.Trim.ToUpper.IndexOf("BT_") = 0) Then
            Else
                br = i
                skipto = ci.sskipto
                skipif = ci.sskipif
                skippedenabledfalse = ci.sskippedenabledfalse
                skippedsetempty = ci.sskippedsetempty
                Dim vred As String = t.SE(ci.ID.Trim.ToUpper.Substring(3), MyPanel).Trim

                'skip
                If skipto <> "" AndAlso vred <> "" Then
                    Dim st() As String = skipto.Split("$")
                    Dim si() As String = skipif.Split("$")
                    Dim sk As Boolean = False
                    For ii As Integer = 0 To si.GetUpperBound(0)
                        Dim a As String = getExpression(si(ii), ci.ID)
                        Dim indTo As Integer = Array.IndexOf(arrayttabindexF, st(ii).Trim.ToUpper)
                        Dim ppIDskipTO As String = ""
                        If indTo > 0 Then
                            ppIDskipTO = arrayttabindexTPF(indTo)
                        End If
                        If a = "True" Then
                            skipEvent(ci.ID, ppIDskipTO, skippedenabledfalse, skippedsetempty, False)
                            sk = True
                            'TREBA PONOVO JER U SKIPU MOZE NESTO DA ANULIRA
                            Call getVFNPK(ci.ID)   'sracunajFP
                            Exit For
                        End If
                    Next
                End If

                'visible
                vVisibleTrue = ci.vVisibleTrue
                vVisibleTrueIf = ci.vVisibleTrueIf
                vVisibleFalse = ci.vVisibleFalse
                vVisibleFalseIf = ci.vVisibleFalseIf
                If vVisibleTrueIf <> "" AndAlso vred <> "" Then
                    Dim at() As String = vVisibleTrue.Split("$")
                    Dim ai() As String = vVisibleTrueIf.Split("$")

                    For ii As Integer = 0 To ai.GetUpperBound(0)
                        Dim a As String = getExpression(ai(ii), ci.ID)
                        Dim avred As Boolean = False
                        If a = "True" Then avred = True
                        Dim att() As String = at(ii).Split(",")
                        For iii As Integer = 0 To att.GetUpperBound(0)
                            Dim ppIDskipTO As String = ""
                            Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(iii).Trim.ToUpper)
                            If indTo > -1 Then
                                ppIDskipTO = arrayttabindexTPF(indTo)
                            Else
                                indTo = Array.IndexOf(arraypodtabela, att(iii).Trim.ToUpper)
                                If indTo > -1 Then ppIDskipTO = arraypodtabela(indTo)
                            End If
                            If ppIDskipTO <> "" Then VisibleEvent(ppIDskipTO, avred)
                        Next
                    Next
                End If
                If vVisibleFalseIf <> "" AndAlso vred <> "" Then
                    Dim at() As String = vVisibleFalse.Split("$")
                    Dim ai() As String = vVisibleFalseIf.Split("$")
                    For ii As Integer = 0 To ai.GetUpperBound(0)
                        Dim a As String = getExpression(ai(ii), ci.ID)
                        Dim avred As Boolean = False
                        If a = "True" Then avred = True
                        Dim att() As String = at(ii).Split(",")
                        For iii As Integer = 0 To att.GetUpperBound(0)
                            Dim ppIDskipTO As String = ""
                            Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(iii).Trim.ToUpper)
                            If indTo > -1 Then
                                ppIDskipTO = arrayttabindexTPF(indTo)
                            Else
                                indTo = Array.IndexOf(arraypodtabela, att(iii).Trim.ToUpper.Replace("TABLE", ""))
                                If indTo > -1 Then
                                    ppIDskipTO = arrayTabButtonBT(indTo)
                                End If
                            End If
                            If ppIDskipTO <> "" Then VisibleEvent(ppIDskipTO, Not avred)
                        Next
                    Next
                End If
                'enable


                eEnabledTrue = ci.eEnabledTrue
                eEnabledTrueIf = ci.eEnabledTrueIf
                eEnabledFalse = ci.eEnabledFalse
                eEnabledFalseIf = ci.eEnabledFalseIf
                If eEnabledTrueIf <> "" AndAlso vred <> "" Then
                    Dim at() As String = eEnabledTrue.Split("$")
                    Dim ai() As String = eEnabledTrueIf.Split("$")
                    For ii As Integer = 0 To ai.GetUpperBound(0)
                        Dim a As String = getExpression(ai(ii), ci.ID)
                        Dim avred As Boolean = False
                        If a = "True" Then avred = True
                        Dim att() As String = at(ii).Split(",")
                        For iii As Integer = 0 To att.GetUpperBound(0)
                            Dim ppIDskipTO As String = ""
                            Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(iii).Trim.ToUpper)
                            If indTo > -1 Then
                                ppIDskipTO = arrayttabindexTPF(indTo)
                            Else
                                indTo = Array.IndexOf(arraypodtabela, att(iii).Trim.ToUpper)
                                If indTo > -1 Then ppIDskipTO = arraypodtabela(indTo)
                            End If
                            If ppIDskipTO <> "" Then EnabledEvent(ppIDskipTO, avred)
                        Next
                    Next
                End If

                If eEnabledFalseIf <> "" AndAlso vred <> "" Then
                    Dim at() As String = eEnabledFalse.Split("$")
                    Dim ai() As String = eEnabledFalseIf.Split("$")
                    For ii As Integer = 0 To ai.GetUpperBound(0)
                        Dim a As String = getExpression(ai(ii), ci.ID)
                        Dim avred As Boolean = False
                        If a = "True" Then avred = True
                        Dim att() As String = at(ii).Split(",")
                        For iii As Integer = 0 To att.GetUpperBound(0)
                            Dim ppIDskipTO As String = ""
                            Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(iii).Trim.ToUpper)
                            If indTo > -1 Then
                                ppIDskipTO = arrayttabindexTPF(indTo)
                            Else
                                indTo = Array.IndexOf(arraypodtabela, att(iii).Trim.ToUpper.Replace("TABLE", ""))
                                If indTo > -1 Then
                                    ppIDskipTO = arrayTabButtonBT(indTo)
                                End If
                            End If
                            If ppIDskipTO <> "" Then EnabledEvent(ppIDskipTO, Not avred)
                        Next
                    Next
                End If
            End If
        Next

    End Sub
    Sub GetDataIfExists()
        Dim dsDB As DataSet
        dsDB = Session("dsDB")
        Dim rrow As DataRow = dsDB.Tables(0).Rows(0)
        Call WriteTableData(MyPanel, rrow)
    End Sub

    Public Sub WriteTableData(ByVal MyPanel As System.Web.UI.WebControls.Panel, ByVal rrow As DataRow)

        For Each pp As Control In MyPanel.Controls
            If TypeOf pp Is WebControls.Panel Then
                For Each ccc As Control In pp.Controls
                    If TypeOf ccc Is HtmlGenericControl AndAlso ccc.ID.IndexOf("ISTDIV") = 0 Then
                        For Each c2 As Control In ccc.Controls
                            If TypeOf c2 Is Table Then
                                Dim mytable As Table = CType(c2, Table)
                                ' Iterate through rows and cells of the table
                                ProcessControls(mytable, rrow)
                            End If
                        Next
                    End If

                    If TypeOf ccc Is Table Then
                        Dim mytable As Table = CType(ccc, Table)
                        ' Iterate through rows and cells of the table
                        ProcessControls(mytable, rrow)
                    End If

                Next

            End If
            ' Check if the control is a Table
        Next
    End Sub
    Sub ProcessControls(ByVal MyTable As Table, ByVal rrow As DataRow)

        For Each row As TableRow In MyTable.Rows
            For Each cell As TableCell In row.Cells
                For Each control As Control In cell.Controls
                    If TypeOf control Is TextBox AndAlso CType(control, System.Web.UI.WebControls.TextBox).ClientID.Substring(0, 3) = "TP_" Then
                        Call SetTBox(control, rrow)
                    ElseIf TypeOf control Is TextBox AndAlso CType(control, System.Web.UI.WebControls.TextBox).ClientID.Substring(0, 3) = "CB_" Then
                        Call SetCBox(control, rrow)
                    ElseIf TypeOf control Is DropDownList AndAlso CType(control, System.Web.UI.WebControls.DropDownList).ClientID.Substring(0, 3) = "DL_" Then
                        Call SetDDL(control, rrow)
                    ElseIf TypeOf control Is RadioButtonList AndAlso CType(control, System.Web.UI.WebControls.RadioButtonList).ClientID.Substring(0, 3) = "RB_" Then
                        Call SetRBox(control, rrow)
                    ElseIf TypeOf control Is CheckBox AndAlso CType(control, System.Web.UI.WebControls.RadioButtonList).ClientID.Substring(0, 3) = "CH_" Then
                        Call SetCHox(control, rrow)
                    ElseIf TypeOf control Is UpdatePanel Then
                        For Each controlInUP As Control In CType(control, UpdatePanel).Controls
                            For i As Integer = 0 To DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Count - 1
                                If TypeOf DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i) Is TextBox AndAlso DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i).ClientID.Substring(0, 3) = "TP_" Then
                                    Call SetTBoxUP(controlInUP, i, rrow)
                                ElseIf TypeOf DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i) Is TextBox AndAlso DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i).ClientID.Substring(0, 3) = "CB_" Then
                                    Call SetCBoxUP(controlInUP, i, rrow)
                                ElseIf TypeOf DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i) Is DropDownList AndAlso DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i).ClientID.Substring(0, 3) = "DL_" Then
                                    Call SetDDLUP(controlInUP, i, rrow)
                                ElseIf TypeOf DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i) Is RadioButtonList AndAlso DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i).ClientID.Substring(0, 3) = "RB_" Then
                                    Call SetRBoxUP(controlInUP, i, rrow)
                                ElseIf TypeOf DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i) Is CheckBox AndAlso DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i).ClientID.Substring(0, 3) = "CH_" Then
                                    Call SetCHoxUP(controlInUP, i, rrow)
                                End If
                            Next
                        Next
                    End If
                Next
            Next
        Next

    End Sub

    Public Sub SetRBox(ByVal control As Control, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(control, RadioButtonList).ClientID.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            CType(control, System.Web.UI.WebControls.RadioButtonList).SelectedValue = rrow.Item(nname).ToString.Trim
        End If
    End Sub
    Public Sub SetRBoxUP(ByVal controlInUP As Control, ByVal i As Integer, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), RadioButtonList).ClientID.Trim.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), RadioButtonList).SelectedValue = rrow.Item(nname).ToString.Trim
        End If
    End Sub
    Public Sub SetCHox(ByVal control As Control, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(control, CheckBox).ClientID.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            If rrow.Item(nname).ToString.Trim = "True" OrElse (rrow.Item(nname).ToString.Trim <> "0" AndAlso rrow.Item(nname).ToString.Trim <> "") Then
                CType(control, System.Web.UI.WebControls.CheckBox).Checked = True
            ElseIf rrow.Item(nname).ToString.Trim = "False" OrElse rrow.Item(nname).ToString.Trim <> "1" Then
                CType(control, System.Web.UI.WebControls.CheckBox).Checked = False
            End If
            'Else
            '     CType(control, System.Web.UI.WebControls.checkbox).Checked =false
        End If
    End Sub
    Public Sub SetCHoxUP(ByVal controlInUP As Control, ByVal i As Integer, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), CheckBox).ClientID.Trim.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            If rrow.Item(nname).ToString.Trim = "True" OrElse (rrow.Item(nname).ToString.Trim <> "0" AndAlso rrow.Item(nname).ToString.Trim <> "") Then
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), CheckBox).Checked = True
            ElseIf rrow.Item(nname).ToString.Trim = "False" OrElse rrow.Item(nname).ToString.Trim <> "1" Then
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), CheckBox).Checked = False
            End If
            'Else
            '      CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), checkbox).Checked =false
        End If
    End Sub
    Public Sub SetTBox(ByVal control As Control, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(control, TextBox).ClientID.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            If rrow.Item(nname).ToString.Trim = "True" Then
                CType(control, System.Web.UI.WebControls.TextBox).Text = "1"
            ElseIf rrow.Item(nname).ToString.Trim = "False" Then
                CType(control, System.Web.UI.WebControls.TextBox).Text = "0"
            Else
                CType(control, System.Web.UI.WebControls.TextBox).Text = rrow.Item(nname).ToString.Trim
            End If
        End If
    End Sub
    Public Sub SetTBoxUP(ByVal controlInUP As Control, ByVal i As Integer, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).ClientID.Trim.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            If rrow.Item(nname).ToString.Trim = "True" Then
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).Text = "1"
            ElseIf rrow.Item(nname).ToString.Trim = "False" Then
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).Text = "0"
            Else
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).Text = rrow.Item(nname).ToString.Trim
            End If
        End If
    End Sub
    Public Sub SetCBox(ByVal control As Control, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(control, TextBox).ClientID.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            If rrow.Item(nname).ToString.Trim = "True" Then
                vvalue = "1"
            ElseIf rrow.Item(nname).ToString.Trim = "False" Then
                vvalue = "0"
            Else
                vvalue = rrow.Item(nname).ToString.Trim
            End If
        End If
        Dim arrayContextKey() As String = Session("arrayContextKey")
        Dim arrayContextKeySQL() As String = Session("arrayContextKeySQL")
        Dim arrayContextKeySQLGET() As String = Session("arrayContextKeySQLGET")
        Dim arrayContextKeyDM() As String = Session("arrayContextKeyDM")
        Dim arrayContextKeyFilter() As String = Session("arrayContextKeyFilter")
        Dim sql As String = ""

        For i As Integer = 0 To arrayContextKey.GetUpperBound(0)
            If arrayContextKey(i).Trim.ToUpper = nname.Trim.ToUpper Then
                sql = arrayContextKeySQLGET(i) + "N'" + vvalue + "'"
            End If
        Next

        Dim ds As New DataSet
        ds = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
        If ds.Tables(0).Rows.Count > 0 Then
            CType(control, System.Web.UI.WebControls.TextBox).Text = ds.Tables(0).Rows(0).Item("DisplayMember").ToString.Trim
        Else
            CType(control, System.Web.UI.WebControls.TextBox).Text = ""
        End If

    End Sub
    Public Sub SetCBoxUP(ByVal controlInUP As Control, ByVal i As Integer, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim nname As String = CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).ClientID.Trim.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalue As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            If rrow.Item(nname).ToString.Trim = "True" Then
                vvalue = "1"
            ElseIf rrow.Item(nname).ToString.Trim = "False" Then
                vvalue = "0"
            Else
                vvalue = rrow.Item(nname).ToString.Trim
            End If
        End If
        Dim arrayContextKey() As String = Session("arrayContextKey")
        Dim arrayContextKeySQL() As String = Session("arrayContextKeySQL")
        Dim arrayContextKeySQLGET() As String = Session("arrayContextKeySQLGET")
        Dim arrayContextKeyDM() As String = Session("arrayContextKeyDM")
        Dim arrayContextKeyFilter() As String = Session("arrayContextKeyFilter")
        Dim arrayContextKeyFilterTN() As String = Session("arrayContextKeyFilterTN")
        Dim sql As String = ""
        Dim ppTN As String = ""
        For j As Integer = 0 To arrayContextKey.GetUpperBound(0)
            If arrayContextKey(j).Trim.ToUpper = CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).ClientID.Trim.ToUpper Then
                sql = arrayContextKeySQLGET(j) + "N'" + vvalue + "'"
                ppTN = arrayContextKey(j).Trim.ToUpper.Substring(3)
                Exit For
            End If
        Next
        Dim dt As New DataSet
        dt = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
        Dim vvaueVM As String = ""
        If dt.Tables(0).Rows.Count > 0 Then
            vvalue = dt.Tables(0).Rows(0).Item("DisplayMember").ToString.Trim
            vvaueVM = dt.Tables(0).Rows(0).Item("ValueMember").ToString.Trim
        Else
            vvalue = ""
            vvaueVM = ""
        End If

        Dim ind As Integer = Array.IndexOf(arrayContextKeyFilterTN, ppTN)
        If ind > 1 Then
            Session(ppTN) = vvaueVM   'treba filter = filter + HttpContext.Current.Session(pp(m).Substring(2)) + "="
            Session("filter") = Session("filter") + ppTN + ";"
        End If

        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            If vvalue.ToString.Trim = "True" Then
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).Text = "1"
            ElseIf vvalue.ToString.Trim = "False" Then
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).Text = "0"
            Else
                CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), TextBox).Text = vvalue
            End If
        End If
    End Sub
    Public Sub SetDDL(ByVal control As Control, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim ddl As DropDownList = CType(control, System.Web.UI.WebControls.DropDownList)
        Dim nname As String = ddl.ClientID.Trim.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalueVM As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            vvalueVM = rrow.Item(nname).ToString.Trim
        End If
        Dim arrayContextKey() As String = Session("arrayContextKey")
        Dim arrayContextKeySQL() As String = Session("arrayContextKeySQL")
        Dim arrayContextKeySQLGET() As String = Session("arrayContextKeySQLGET")
        Dim arrayContextKeyDM() As String = Session("arrayContextKeyDM")
        Dim arrayContextKeyFilter() As String = Session("arrayContextKeyFilter")
        Dim arrayContextKeyFilterTN() As String = Session("arrayContextKeyFilterTN")
        Dim sql As String = ""
        Dim ppTN As String = ""

        If vvalueVM = "" AndAlso ddl.DataSource Is Nothing Then
            Call PopulateDependantDropDownList(ddl, Me.DBConnectionString.Text)

        End If


        If vvalueVM <> "" Then
            For j As Integer = 0 To arrayContextKey.GetUpperBound(0)
                If arrayContextKey(j).Trim.ToUpper = ddl.ClientID.Trim.ToUpper Then
                    sql = arrayContextKeySQLGET(j) + "N'" + vvalueVM + "'"
                    ppTN = arrayContextKey(j).Trim.ToUpper.Substring(3)
                    Exit For
                End If
            Next
            Dim dt As New DataSet
            dt = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
            Dim vvalueDM As String = ""
            If dt.Tables(0).Rows.Count > 0 Then
                vvalueDM = dt.Tables(0).Rows(0).Item("DisplayMember").ToString.Trim
                vvalueVM = dt.Tables(0).Rows(0).Item("ValueMember").ToString.Trim
            Else
                vvalueDM = ""
                vvalueVM = ""
            End If

            Dim ind As Integer = Array.IndexOf(arrayContextKeyFilterTN, ppTN)
            If ind > 1 Then
                Session(ppTN) = vvalueVM   'treba filter = filter + HttpContext.Current.Session(pp(m).Substring(2)) + "="
                Session("filter") = Session("filter") + ppTN + ";"
            End If

            If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
                If Not ddl.DataSource Is Nothing Then
                    If vvalueVM = "" Then vvalueVM = 0 'bilo bez ovoga, pucalo kad je prazan ("") ddl
                    ddl.SelectedValue = vvalueVM
                Else
                    'dependant
                    Call PopulateDependantDropDownList(ddl, Me.DBConnectionString.Text)
                    ddl.SelectedValue = vvalueVM
                End If
            End If
        End If
    End Sub
    Public Sub SetDDLUP(ByVal controlInUP As Control, ByVal i As Integer, ByVal rrow As DataRow)
        Dim ttype As String = ""
        Dim ddl As DropDownList = CType(DirectCast(controlInUP.Controls, System.Web.UI.ControlCollection).Item(i), DropDownList)
        Dim nname As String = ddl.ClientID.Trim.Substring(3).ToUpper
        ttype = rrow.Table.Columns(nname).DataType.ToString
        Dim vvalueVM As String = ""
        If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
            vvalueVM = rrow.Item(nname).ToString.Trim
        End If
        Dim arrayContextKey() As String = Session("arrayContextKey")
        Dim arrayContextKeySQL() As String = Session("arrayContextKeySQL")
        Dim arrayContextKeySQLGET() As String = Session("arrayContextKeySQLGET")
        Dim arrayContextKeyDM() As String = Session("arrayContextKeyDM")
        Dim arrayContextKeyFilter() As String = Session("arrayContextKeyFilter")
        Dim arrayContextKeyFilterTN() As String = Session("arrayContextKeyFilterTN")
        Dim sql As String = ""
        Dim ppTN As String = ""

        If vvalueVM = "" AndAlso ddl.DataSource Is Nothing Then
            Call PopulateDependantDropDownList(ddl, Me.DBConnectionString.Text)
        End If
        If vvalueVM <> "" Then
            For j As Integer = 0 To arrayContextKey.GetUpperBound(0)
                If arrayContextKey(j).Trim.ToUpper = ddl.ClientID.Trim.ToUpper Then
                    sql = arrayContextKeySQLGET(j) + "N'" + vvalueVM + "'"
                    ppTN = arrayContextKey(j).Trim.ToUpper.Substring(3)
                    Exit For
                End If
            Next
            Dim dt As New DataSet
            dt = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
            Dim vvalueDM As String = ""
            If dt.Tables(0).Rows.Count > 0 Then
                vvalueDM = dt.Tables(0).Rows(0).Item("DisplayMember").ToString.Trim
                vvalueVM = dt.Tables(0).Rows(0).Item("ValueMember").ToString.Trim
            Else
                vvalueDM = ""
                vvalueVM = ""
            End If

            Dim ind As Integer = Array.IndexOf(arrayContextKeyFilterTN, ppTN)
            If ind > 1 Then
                Session(ppTN) = vvalueVM   'treba filter = filter + HttpContext.Current.Session(pp(m).Substring(2)) + "="
                Session("filter") = Session("filter") + ppTN + ";"
            End If

            If Not IsDBNull(rrow.Item(nname).ToString.Trim) Then
                If Not ddl.DataSource Is Nothing Then
                    ddl.SelectedValue = vvalueVM
                Else
                    'dependant
                    Call PopulateDependantDropDownList(ddl, Me.DBConnectionString.Text)
                    ddl.SelectedValue = vvalueVM
                End If
            End If
        End If



    End Sub
    Private Sub RecreatePersistedControlsGrid()
        Dim tableNames = ""
        If Not Me.Session("DynamicControlsGrid") Is Nothing Then
            Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)     'control
            If alG IsNot Nothing Then
                For i As Integer = 0 To alG.Count - 1
                    Dim ciG As ControlInfoGrid = DirectCast(alG(i), ControlInfoGrid)
                    If ciG.Type = "ButtonAdd" Then
                        Dim tableP As New Table()
                        table = tableP
                        table.ID = "TableGrid_" + ciG.tab
                        Dim rowP As New TableRow()
                        row = rowP
                        CreateControlGrid(ciG)
                        row.Controls.Add(cell)
                        cell = Nothing
                        table.Rows.Add(row)
                        row = Nothing
                    ElseIf ciG.Type = "GridView" Then
                        Dim rowP2 As New TableRow()
                        row = rowP2
                        CreateControlGrid(ciG)
                        row.Controls.Add(cell)
                        cell = Nothing
                        table.Rows.Add(row)
                        row = Nothing
                        PanelGrid.Controls.Add(table)
                        tableNames = tableNames + table.ClientID + ";"
                        table = Nothing
                    End If
                Next
            End If
        End If
        Session.Add("PanelGridTables", tableNames)
        If Not Session("visibleTableGrid") Is Nothing Then
            Dim pp() As String = Session("visibleTableGrid").split(";")
            For i As Integer = 0 To pp.GetUpperBound(0)
                Dim tt As WebControls.Table = CType(PanelGrid.FindControl(pp(i)), WebControls.Table)
                If Not tt Is Nothing Then tt.Style("display") = "block"
            Next
        End If

    End Sub
    Private Sub RecreatePersistedControlsSave()

        If Not Me.Session("DynamicControlsSave") Is Nothing Then
            Dim al As ArrayList = CType(Me.Session("DynamicControlsSave"), ArrayList)     'control
            If al IsNot Nothing Then
                Dim tableP As New Table()
                table = tableP
                table.ID = "TableSave"

                Dim rowP As New TableRow()
                row = rowP
                For i As Integer = 0 To Session("NumberOfButtonsPanelSave") - 1

                    Dim ciT1 As ControlInfoSave = DirectCast(al(i), ControlInfoSave)
                    CreateControlSave(ciT1)
                    row.Controls.Add(cell)
                    cell = Nothing
                Next

                table.Rows.Add(row)
                row = Nothing

                Dim rowP2 As New TableRow()
                row = rowP2
                Dim ciR1 As ControlInfoSave = DirectCast(al(Session("NumberOfButtonsPanelSave")), ControlInfoSave)
                CreateControlSave(ciR1)
                cell.ColumnSpan = Session("NumberOfButtonsPanelSave")
                row.Controls.Add(cell)
                table.Rows.Add(row)

                Dim rowP3 As New TableRow()
                row = rowP3
                Dim ciR2 As ControlInfoSave = DirectCast(al(Session("NumberOfButtonsPanelSave") + 1), ControlInfoSave)
                CreateControlSave(ciR2)
                cell.ColumnSpan = Session("NumberOfButtonsPanelSave")
                row.Controls.Add(cell)
                table.Rows.Add(row)

                row = Nothing
                cell = Nothing

                PanelSave.Controls.Add(table)
                table = Nothing
            End If
        End If

    End Sub
    Private Sub RecreatePersistedControlsNavigation()

        If Not Me.Session("DynamicControlsNavigation") Is Nothing Then
            Dim al As ArrayList = CType(Me.Session("DynamicControlsNavigation"), ArrayList)     'control
            If al IsNot Nothing Then
                Dim ulP As New HtmlGenericControl("ul")
                ul = ulP
                For i As Integer = 0 To al.Count - 1
                    Dim ciN As ControlInfoNavigation = DirectCast(al(i), ControlInfoNavigation)
                    CreateControlNavigation(ciN, i)
                    ul.Controls.Add(li)
                    li = Nothing
                Next
                PlaceHolderNav.Controls.Add(ul)
                ul = Nothing
            End If
        End If

    End Sub
    Private Sub RecreatePersistedControls()

        If Not Me.Session("DynamicControls") Is Nothing Then
            Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)     'control
            If al IsNot Nothing Then
                Dim pamtiY As Integer = 0
                Dim pamtif1 As Integer = 0
                Dim f1 As Integer = 0
                Dim webtab As Integer = 0
                Dim pamtiwebtab As Integer = 0
                Dim tableP As New Table()
                table = tableP
                Dim rowP As New TableRow()
                row = rowP
                Dim vid As Integer = 3
                If lblDG.Text = "D" AndAlso Session("provera") = 0 Then vid = 2
                For i As Integer = 0 To al.Count - 1
                    Dim ci As ControlInfo = DirectCast(al(i), ControlInfo)
                    f1 = ci.f1
                    webtab = ci.webTab
                    If f1 > pamtif1 Then
                        If pamtif1 > 0 Then
                            If pamtiY > 0 AndAlso Not row Is Nothing Then
                                table.Rows.Add(row)
                                row = Nothing
                                cell = Nothing
                            End If
                            'PrintControlTree(MyTable)
                            If IsTableEmpty(table) = False Then
                                Dim createDiv As System.Web.UI.HtmlControls.HtmlGenericControl = New System.Web.UI.HtmlControls.HtmlGenericControl("DIV")
                                createDiv.ID = "ISTDIV" + table.ID
                                createDiv.Style.Add(HtmlTextWriterStyle.OverflowX, "Auto")
                                createDiv.Controls.Add(table)
                                panel.Controls.Add(createDiv)

                                If webtab > pamtiwebtab Then
                                    MyPanel.Controls.Add(panel)
                                    panel = Nothing
                                End If
                                table = Nothing
                                row = Nothing
                                cell = Nothing
                            End If
                        End If

                        If webtab > pamtiwebtab Then
                            Dim panelN As New WebControls.Panel
                            panel = panelN
                            panel.ID = "MyPanel" + CStr(ci.webTab).Trim
                            If f1 > vid Then panel.Style("display") = "none"
                            pamtiwebtab = webtab
                        End If

                        Dim tableN As New Table()
                        table = tableN
                        table.ID = "MyTable" + CStr(ci.f1).Trim
                        pamtif1 = f1
                    End If

                    If ci.ttop > pamtiY Then
                        If pamtiY > 0 AndAlso Not row Is Nothing Then
                            table.Rows.Add(row)
                            row = Nothing
                            cell = Nothing
                        End If
                        'otvram nov red
                        Dim rowN As New TableRow()
                        row = rowN
                        pamtiY = ci.ttop
                    End If

                    If ci.ID Is Nothing Then
                        Dim cell As New TableHeaderCell()
                        cell.Text = String.Empty
                        row.Cells.Add(cell)
                        cell = Nothing
                    ElseIf ci.rReadOnly = False OrElse ci.ttext.Trim <> "" Then
                        Call CreateControlPage(ci)
                        row.Cells.Add(cell)   'OVDE IDE CELL; NE CELLI
                        cell = Nothing
                    End If
                Next
                'poslednjired, poslednje tabele
                If f1 = pamtif1 Then
                    If pamtif1 > 0 Then
                        If pamtiY > 0 AndAlso Not row Is Nothing Then
                            table.Rows.Add(row)
                            row = Nothing
                            cell = Nothing
                        End If
                        'PrintControlTree(MyTable)
                        If IsTableEmpty(table) = False Then
                            Dim createDiv As System.Web.UI.HtmlControls.HtmlGenericControl = New System.Web.UI.HtmlControls.HtmlGenericControl("DIV")
                            createDiv.ID = "ISTDIV" + table.ID
                            createDiv.Style.Add(HtmlTextWriterStyle.OverflowX, "Auto")
                            createDiv.Controls.Add(table)
                            panel.Controls.Add(createDiv)

                            MyPanel.Controls.Add(panel)
                            panel = Nothing
                            table = Nothing
                            row = Nothing
                            cell = Nothing
                        End If
                    End If
                End If
            End If
        End If

        If Not Session("visibleTab") Is Nothing Then
            Dim pp() As String = Session("visibleTab").split(";")
            For i As Integer = 0 To pp.GetUpperBound(0)
                Dim panel As WebControls.Panel = CType(MyPanel.FindControl(pp(i)), WebControls.Panel)
                If Not panel Is Nothing Then
                    panel.Style("display") = "block"

                    Dim buttonid As String = ""
                    If pp(i).Trim.ToUpper.Contains("MYPANEL") Then
                        buttonid = pp(i).Trim.ToUpper.Replace("MYPANEL", "BT_BUTTON")
                        Dim b As WebControls.Button = CType(MyPanel.FindControl(buttonid), WebControls.Button)
                        If Not b Is Nothing Then b.CssClass = "buttonActive" 'b.BackColor = Color.rosybrown 'Color.FromARGB(46,126,193)'
                    End If
                End If
            Next
        End If

    End Sub
    'Sub PrintControlTree(parentControl As Control, Optional indent As Integer = 0)
    '    For Each ctrl As Control In parentControl.Controls
    '        ' Print the control with indentation for readability
    '        'Debug.Print(StrDup(indent, " ") & ctrl.GetType().ToString() & " - " & ctrl.ID)
    '        'Debug.Print(ctrl.ID)

    '        ' If the control has children, recursively print them
    '        If ctrl.HasControls() Then
    '            PrintControlTree(ctrl)
    '        End If
    '    Next
    'End Sub
    Private Sub AppendEvent(ByVal ctl As Control, ByVal handler As String)
        Select Case handler
            Case "Click"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.Button_Click)
            Case "ClickTab"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.ButtonTab_Click)
            Case "ClickTabGrid"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.ButtonTabGrid_Click)
            Case "GridOnRowBound"
                AddHandler(CType(ctl, GridView)).RowDataBound, New GridViewRowEventHandler(AddressOf Me.Grid_RowBound)
            Case "GridLoad"
                AddHandler(CType(ctl, GridView)).Load, New System.EventHandler(AddressOf Me.Grid_Load)
            Case "GridOnRowDeleting"
                AddHandler(CType(ctl, GridView)).RowDeleting, New GridViewDeleteEventHandler(AddressOf Me.Grid_RowDeleting)
            Case "ClickShowErrors"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.btnToggle_Click)
            Case "GridPageIndexChanging"
                AddHandler(CType(ctl, GridView)).PageIndexChanging, New GridViewPageEventHandler(AddressOf Me.Grid_PageIndexChanging)
            Case "GridSelectedIndexChanged"
                AddHandler(CType(ctl, GridView)).SelectedIndexChanged, New System.EventHandler(AddressOf Me.Grid_SelectedIndexChanged)
            Case "GridSorting"
                AddHandler(CType(ctl, GridView)).Sorting, New GridViewSortEventHandler(AddressOf Me.Grid_Sorting)
            Case "ClickSave"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.ButtonSave_Click)
            Case "ClickLK"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.ButtonLK_Click)
            Case "ClickBack"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.trnslt_backButton_Click)
            Case "ClickGuide"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.ButtonGuide_Click)
            'Case "ClickPrint"
            '    AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.PrintButton_Click)
            Case "ClickAdd"
                AddHandler(CType(ctl, Button)).Click, New System.EventHandler(AddressOf Me.ButtonAdd_Click)
            Case "ClickNavigation"
                AddHandler(CType(ctl, LinkButton)).Click, New System.EventHandler(AddressOf Me.ButtonNavigation_Click)
            Case "TextChanged"
                AddHandler(CType(ctl, TextBox)).TextChanged, New System.EventHandler(AddressOf Me.TextBox_TextChanged)
            Case "SelectedIndexChanged"
                AddHandler(CType(ctl, DropDownList)).SelectedIndexChanged, New System.EventHandler(AddressOf Me.DropDownList_SelectedIndexChanged)
            Case "MenuBoxSelectedIndexChanged"
                AddHandler(CType(ctl, DropDownList)).SelectedIndexChanged, New System.EventHandler(AddressOf Me.MenuBox_SelectedIndexChanged)
            Case "RadioButtonList"
                AddHandler(CType(ctl, RadioButtonList)).SelectedIndexChanged, New System.EventHandler(AddressOf RadioButtonList_SelectedIndexChanged)
            Case "CheckBox"
                AddHandler(CType(ctl, CheckBox)).CheckedChanged, New System.EventHandler(AddressOf CheckBox_CheckedChanged)
        End Select
    End Sub
    'Protected Sub SomeServerSideMethod()
    '    If Not IsFocusManagedOnClientSide() Then
    '        ' Your logic to set focus
    '        ' Example: TextBox1.Focus()
    '    End If
    'End Sub
    'Private Function IsFocusManagedOnClientSide() As Boolean
    '    ' Check if a hidden field or a flag is set by your client-side script
    '    ' Example: Return MyHiddenField.Value = "FocusManaged"
    '    Return False ' Adjust based on your implementation
    'End Function



    Sub getVFNPK(ByVal ppID As String)
        If Session("arrayFP") Is Nothing Then Exit Sub

        Dim arrayFP() As String = Session("arrayFP")
        Dim arrayFPE() As String = Session("arrayFPE")
        Dim arrayFPNPK() As String = Session("arrayFPNPK")
        If arrayFPNPK.Length = 0 OrElse arrayFPNPK.Length = 1 AndAlso arrayFPNPK(0) = "" Then Exit Sub

        'textbox is in expression;
        For i As Integer = 0 To arrayFPNPK.GetUpperBound(0)
            If arrayFPNPK(i) <> "" Then
                Dim expression As String = arrayFPE(i)
                Dim pexpression As String = expression
                Dim vvalue As String = ""
                'pexpression= SrediPMGK(pexpression)'THIS IS NOT POSSIBLE HERE
                If ppID <> "" AndAlso pexpression.Trim.ToUpper.IndexOf(ppID.Trim.ToUpper.Substring(3)) >= 0 Then
                    pexpression = getHEAD(pexpression)
                    pexpression = t.zameniFP(pexpression, Session("dsDB"), MyPanel, arrayFP)
                    pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                    If arrayFPE(i).Trim.ToUpper.IndexOf("SELECT") >= 0 AndAlso arrayFPE(i).Trim.ToUpper.IndexOf("FROM") >= 0 Then
                        vvalue = getSQL(pexpression, arrayFPE(i))
                        Call t.NE(arrayFP(i), MyPanel, vvalue)
                    Else
                        pexpression = t.sracunajIzraz(pexpression, MyPanel, ppID.Trim.ToUpper.Substring(3))
                        Dim a As String = t.scompute(pexpression, Session("dsDB"))
                        Call t.NE(arrayFP(i), MyPanel, a)
                    End If
                End If
            End If
        Next

        'textbox is part of vitual field from expression;  
        For i As Integer = 0 To arrayFPNPK.GetUpperBound(0)
            If arrayFPNPK(i) <> "" Then
                Dim fp As Boolean = False
                Dim expression As String = arrayFPE(i)
                Dim pexpression As String = expression
                Dim vvalue As String = ""
                'pexpression= SrediPMGK(pexpression) 'THIS IS NOT POSSIBLE HERE
                If pexpression.Trim.ToUpper.IndexOf("#FP{") >= 0 Then
                    fp = t.ucestvujePoljeuFP(arrayFPE(i), ppID.Trim.ToUpper.Substring(3), Session("dsDB"), MyPanel, arrayFP, arrayFPE)
                End If
                If ppID <> "" AndAlso fp = True Then
                    pexpression = getHEAD(pexpression)
                    pexpression = t.zameniFP(pexpression, Session("dsDB"), MyPanel, arrayFP)
                    pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                    If arrayFPE(i).Trim.ToUpper.IndexOf("SELECT") >= 0 AndAlso arrayFPE(i).Trim.ToUpper.IndexOf("FROM") >= 0 Then
                        vvalue = getSQL(pexpression, arrayFPE(i))
                        Call t.NE(arrayFP(i), MyPanel, vvalue)
                    Else

                        pexpression = Replace(pexpression, "select", "", 1, , CompareMethod.Text)

                        If pexpression.Trim.ToUpper.IndexOf("CASE") >= 0 Then
                            pexpression = t.sracunajCase(pexpression, MyPanel)
                            pexpression = t.scompute(pexpression, Session("dsDB"))
                        End If
                        pexpression = pexpression.Replace("''", "'")

                        If pexpression.IndexOf("'") = 0 Then
                            vvalue = pexpression.Replace("'", "")
                        Else
                            pexpression = t.sracunajIzraz(pexpression, MyPanel, ppID.Trim.ToUpper.Substring(3))
                            vvalue = t.scompute(pexpression, Session("dsDB"))
                        End If

                        Call t.NE(arrayFP(i), MyPanel, vvalue)

                    End If
                End If
            End If
        Next
    End Sub
    Sub getVFNPKALL() 'daje sve koji nisu PK (na save)
        If Session("arrayFP") Is Nothing Then Exit Sub
        Dim arrayFP() As String = Session("arrayFP")
        Dim arrayFPE() As String = Session("arrayFPE")
        Dim arrayFPNPK() As String = Session("arrayFPNPK")
        If arrayFPNPK.Length = 0 OrElse arrayFPNPK.Length = 1 AndAlso arrayFPNPK(0) = "" Then Exit Sub

        Dim thisTextBoxInFP As Boolean = False
        For i As Integer = 0 To arrayFPNPK.GetUpperBound(0)
            Dim expression As String = ""
            Dim pexpression As String = ""
            If arrayFPNPK(i) <> "" AndAlso arrayFPE(i) <> "" Then
                expression = arrayFPE(i)
                pexpression = expression
                Dim vvalue As String = ""
                pexpression = getHEAD(pexpression)

                If pexpression.Trim.ToUpper.IndexOf("#FP{") >= 0 Then pexpression = t.zameniFP(pexpression, Session("dsDB"), MyPanel, arrayFP)
                pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                If arrayFPE(i).Trim.ToUpper.IndexOf("SELECT") >= 0 AndAlso arrayFPE(i).Trim.ToUpper.IndexOf("FROM") >= 0 Then
                    vvalue = getSQL(pexpression, arrayFPE(i))
                    Call t.NE(arrayFP(i), MyPanel, vvalue)
                Else

                    pexpression = Replace(pexpression, "select", "", 1, , CompareMethod.Text)
                    If pexpression.Trim.ToUpper.IndexOf("#FP{") >= 0 Then expression = t.zameniFP(pexpression, Session("dsDB"), MyPanel, arrayFP)
                    pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                    If pexpression.Trim.ToUpper.IndexOf("CASE") >= 0 Then
                        pexpression = t.sracunajCase(pexpression, MyPanel)
                        pexpression = t.scompute(pexpression, Session("dsDB"))
                    End If
                    pexpression = pexpression.Replace("''", "'")
                    If pexpression.IndexOf("'") = 0 Then
                        vvalue = pexpression.Replace("'", "")
                    Else
                        pexpression = t.sracunajIzraz(pexpression, MyPanel)
                        vvalue = t.scompute(pexpression, Session("dsDB"))
                    End If

                    Call t.NE(arrayFP(i), MyPanel, vvalue)
                End If
                'If pexpression.Trim.ToUpper.IndexOf("#FP{") >= 0 Then pexpression = t.zameniFP(expression, Session("dsDB"), MyPanel, arrayFP)
                'pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"))
                'pexpression = t.sracunajIzraz(pexpression, MyPanel)
                'Dim a As String = t.scompute(pexpression, Session("dsDB"))
                'Call t.NE(arrayFP(i), MyPanel, a)

            End If
        Next
    End Sub
    Sub getVFALL() 'daje sve
        If Session("arrayFP") Is Nothing Then Exit Sub
        Dim arrayFP() As String = Session("arrayFP")
        Dim arrayFPE() As String = Session("arrayFPE")
        Dim arrayFPPM() As String = Session("arrayFPPM")
        Dim arrayFPPMW() As String = Session("arrayFPPMW")
        If arrayFP.Length = 0 OrElse arrayFP.Length = 1 AndAlso arrayFP(0) = "" Then Exit Sub

        Dim thisTextBoxInFP As Boolean = False
        For i As Integer = 0 To arrayFP.GetUpperBound(0)
            Dim expression As String = ""
            Dim pexpression As String = ""
            If arrayFPE(i) <> "" Then
                expression = arrayFPE(i)
                pexpression = expression
                Dim vvalue As String = ""
                pexpression = getHEAD(pexpression)
                If arrayFPPMW(i) <> "" Then
                    vvalue = getPMGK(pexpression, arrayFPPMW(i))
                    Call t.NE(arrayFP(i), MyPanel, vvalue)
                Else
                    If pexpression.Trim <> "" Then
                        If pexpression.Trim.ToUpper.IndexOf("#FP{") >= 0 Then pexpression = t.zameniFP(pexpression, Session("dsDB"), MyPanel, arrayFP)
                        pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                        If arrayFPE(i).Trim.ToUpper.IndexOf("SELECT") >= 0 AndAlso arrayFPE(i).Trim.ToUpper.IndexOf("FROM") >= 0 Then
                            vvalue = getSQL(pexpression, arrayFPE(i))
                            Call t.NE(arrayFP(i), MyPanel, vvalue)
                        Else
                            pexpression = Replace(pexpression, "select", "", 1, , CompareMethod.Text)
                            If pexpression.Trim.ToUpper.IndexOf("#FP{") >= 0 Then expression = t.zameniFP(pexpression, Session("dsDB"), MyPanel, arrayFP)
                            pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                            If pexpression.Trim.ToUpper.IndexOf("CASE") >= 0 Then
                                pexpression = t.sracunajCase(pexpression, MyPanel)
                                pexpression = t.scompute(pexpression, Session("dsDB"))
                            End If
                            pexpression = pexpression.Replace("''", "'")
                            If pexpression.IndexOf("'") = 0 Then
                                vvalue = pexpression.Replace("'", "")
                            Else
                                pexpression = t.sracunajIzraz(pexpression, MyPanel)
                                vvalue = t.scompute(pexpression, Session("dsDB"))
                            End If

                            Call t.NE(arrayFP(i), MyPanel, vvalue)
                        End If
                    End If

                End If
            End If
        Next
    End Sub
    Function getSQL(ByVal sql As String, ByVal FPE As String) As String
        getSQL = ""
        sql = sql.Replace("#{", "").Replace("}", "")
        Dim bbb() As String = t.razkvantaj(sql)
        Dim pp As String = ""
        For ll As Integer = 0 To bbb.GetUpperBound(0)
            If bbb(ll).Trim.ToUpper.IndexOf("D.") = 0 Then
                bbb(ll) = bbb(ll).Trim.ToUpper.Replace("D.", "")
                Dim qq As String = t.SE(bbb(ll), MyPanel)
                If qq Is Nothing OrElse qq.Trim = "" Then
                    bbb(ll) = "Null"
                Else
                    bbb(ll) = "N'" + qq + "'"
                End If
            End If
        Next
        bbb = t.josJedanKrug(bbb)
        sql = t.ustringaj(bbb)
        Dim dsIST As DataSet
        dsIST = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
        If Not dsIST Is Nothing AndAlso dsIST.Tables.Count > 0 AndAlso Not dsIST.Tables(0) Is Nothing AndAlso dsIST.Tables(0).Rows.Count > 0 AndAlso Not dsIST.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
            getSQL = dsIST.Tables(0).Rows(0).Item(0).ToString.Trim
        End If
    End Function

    Function getCompleteSQL(ByVal sql As String) As String
        getCompleteSQL = ""
        sql = sql.Replace("#{", "").Replace("}", "")
        Dim bbb() As String = t.razkvantaj(sql)
        Dim pp As String = ""
        For ll As Integer = 0 To bbb.GetUpperBound(0)
            If bbb(ll).Trim.ToUpper.IndexOf("D.") = 0 Then
                bbb(ll) = bbb(ll).Trim.ToUpper.Replace("D.", "")
                Dim qq As String = t.SE(bbb(ll), MyPanel)
                If qq Is Nothing OrElse qq.Trim = "" Then
                    bbb(ll) = "Null"
                Else
                    If IsNumeric(qq) Then
                        bbb(ll) = qq
                    Else
                        bbb(ll) = "N'" + qq + "'"
                    End If


                End If
            End If
        Next
        bbb = t.josJedanKrug(bbb)
        sql = t.ustringaj(bbb)
        Dim ds As DataSet
        ds = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
        If Not ds Is Nothing AndAlso ds.Tables.Count > 0 Then
            getCompleteSQL = sql
        End If
    End Function

    Function getHEAD(ByVal expression As String) As String
        getHEAD = expression
        If expression.IndexOf("HEAD.") = 0 Then
            Dim midsdb As DataSet = Session("masterTabledsDB")
            'Dim sql As String = "select * from nadtabela  where kljuc nadtabele"
            Dim bbb() As String = t.razkvantaj(expression)
            Dim ppp As String = ""
            Dim expr As String = ""
            For i As Integer = 0 To bbb.GetUpperBound(0)
                If bbb(i).Trim.ToUpper.IndexOf("HEAD.") = 0 Then
                    Dim p As String = bbb(i).Trim.ToUpper.Replace("HEAD.", "")
                    If Not midsdb Is Nothing Then
                        Dim ttype As String = midsdb.Tables(0).Columns(p).DataType.Name.ToString.Trim
                        Dim dodaj As Integer = 0
                        Select Case ttype
                            Case "DateTime", "String", "Date"
                                dodaj = 1
                        End Select
                        Dim vvalue As String = ""
                        If Not IsDBNull(midsdb.Tables(0).Rows(0).Item(p)) Then
                            vvalue = midsdb.Tables(0).Rows(0).Item(p).ToString.Trim
                        End If
                        If dodaj = 1 Then expr = expr + "'" + vvalue + "' " Else expr = expr + vvalue + " "
                    End If

                Else
                    expr = expr + bbb(i) + " "
                End If
            Next
            getHEAD = expr
        End If
    End Function

    Function setPMGK(ByVal dbconnectionstring As String) As String
        setPMGK = ""
        Dim sql As String = "select * from " + Session("maintable") + " where 2=3"
        Dim ds As DataSet = b.DajDS_IzUpita(sql, dbconnectionstring, Session("Country"))
        Dim dt As DataTable = ds.Tables(0)
        Dim GM As String = ""
        If dt.Columns.Contains("GOD") Then GM = GM + "G"
        If dt.Columns.Contains("ISTYear") Then GM = GM + "Y"
        If dt.Columns.Contains("MES") Then GM = GM + "M"
        If dt.Columns.Contains("ISTMonth") Then GM = GM + "M"
        setPMGK = GM
    End Function

    Function getPMGK(ByVal expression As String, ByVal FPPMW As String) As String
        getPMGK = ""
        expression = expression.Replace("{", "").Replace("}", "")
        Dim dsDB As DataSet = Session("dsDB")
        Dim dt As DataTable = dsDB.Tables(0).Rows(0).Table
        Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
        Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")
        Dim strPK As String = ""

        For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
            If pkCurrentTable(i).Trim.ToUpper <> "GOD" AndAlso pkCurrentTable(i).Trim.ToUpper <> "MES" AndAlso pkCurrentTable(i).Trim.ToUpper <> "ISTYEAR" AndAlso pkCurrentTable(i).Trim.ToUpper <> "ISTMONTH" Then
                strPK = strPK + " and " + pkCurrentTable(i) + "='" + pkCurrentTableValue(i) + "'"
            End If
        Next

        Dim godString As String = ""
        Dim mesString As String = ""

        If dt.Columns.Contains("GOD") Then godString = "GOD" : mesString = "MES"
        If dt.Columns.Contains("ISTYear") Then godString = "ISTYear" : mesString = "ISTMonth"
        Dim pp() As String = expression.Split(".")
        Dim sql As String = "select " + pp(1) + " from " + Session("maintable") + " where 2=2 " + strPK
        Dim gg As String = Session("gg")
        Dim mm As String = Session("mm")
        Dim ggm As Integer
        Dim mmm As Integer
        Dim ggmK As String
        Dim mmmK As String
        If FPPMW = "PG" Then
            ggm = CInt(gg) - 1
        ElseIf FPPMW = "PM" Then
            If CInt(mm) = 1 Then
                ggm = CInt(gg) - 1
                mmm = 12
            Else
                ggm = CInt(gg)
                mmm = CInt(mm) - 1
            End If
        ElseIf FPPMW = "PK" Then
            If CInt(mm) = 3 Then
                ggm = CInt(gg) - 1
                mmm = 12
            Else
                ggm = CInt(gg)
                mmm = CInt(mm) - 3
            End If
        ElseIf FPPMW = "PP" Then
            If CInt(mm) = 6 Then
                ggm = CInt(gg) - 1
                mmm = 12
            Else
                ggm = CInt(gg)
                mmm = 6
            End If
        End If
        ggmK = CStr(ggm)
        mmmK = String.Format("{0:d2}", mmm)
        If FPPMW = "PG" Then
            sql = sql + " and " + godString + "=" + ggmK
        ElseIf FPPMW = "PM" OrElse FPPMW = "PK" OrElse FPPMW = "PP" Then
            sql = sql + " and " + godString + "='" + ggmK + "' and " + mesString + "='" + mmmK + "'"
        End If
        Dim dsIST As DataSet
        dsIST = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))

        If Not dsIST Is Nothing AndAlso dsIST.Tables.Count > 0 AndAlso Not dsIST.Tables(0) Is Nothing AndAlso dsIST.Tables(0).Rows.Count > 0 AndAlso Not dsIST.Tables(0).Rows(0).Item(0) Is DBNull.Value Then
            getPMGK = dsIST.Tables(0).Rows(0).Item(0).ToString.Trim
        End If
    End Function
    Function getPP(ByVal FPPMW As String) As DataSet
        getPP = Nothing

        Dim dsDB As DataSet = Session("dsDB")
        Dim dt As DataTable = dsDB.Tables(0).Rows(0).Table
        Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
        Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")
        Dim strPK As String = ""

        For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
            If pkCurrentTable(i).Trim.ToUpper <> "GOD" AndAlso pkCurrentTable(i).Trim.ToUpper <> "MES" AndAlso pkCurrentTable(i).Trim.ToUpper <> "ISTYEAR" AndAlso pkCurrentTable(i).Trim.ToUpper <> "ISTMONTH" Then
                strPK = strPK + " and " + pkCurrentTable(i) + "='" + pkCurrentTableValue(i) + "'"
            End If
        Next

        Dim godString As String = ""
        Dim mesString As String = ""

        If dt.Columns.Contains("GOD") Then godString = "GOD" : mesString = "MES"
        If dt.Columns.Contains("ISTYear") Then godString = "ISTYear" : mesString = "ISTMonth"

        Dim sql As String = "select * from " + Session("maintable") + " where 2=2 " + strPK
        Dim gg As String = Session("gg")
        Dim mm As String = Session("mm")
        Dim ggm As Integer
        Dim mmm As Integer
        Dim ggmK As String
        Dim mmmK As String
        If FPPMW = "PG" Then
            ggm = CInt(gg) - 1
        ElseIf FPPMW = "PM" Then
            If CInt(mm) = 1 Then
                ggm = CInt(gg) - 1
                mmm = 12
            Else
                ggm = CInt(gg)
                mmm = CInt(mm) - 1
            End If
        ElseIf FPPMW = "PK" Then
            If CInt(mm) = 3 Then
                ggm = CInt(gg) - 1
                mmm = 12
            Else
                ggm = CInt(gg)
                mmm = CInt(mm) - 3
            End If
        ElseIf FPPMW = "PP" Then
            If CInt(mm) = 6 Then
                ggm = CInt(gg) - 1
                mmm = 12
            Else
                ggm = CInt(gg)
                mmm = 6
            End If
        End If
        ggmK = CStr(ggm)
        mmmK = String.Format("{0:d2}", mmm)
        If FPPMW = "PG" Then
            sql = sql + " and " + godString + "=" + ggmK
        ElseIf FPPMW = "PM" OrElse FPPMW = "PK" OrElse FPPMW = "PP" Then
            sql = sql + " and " + godString + "='" + ggmK + "' and " + mesString + "='" + mmmK + "'"
        End If
        Dim dsIST As DataSet
        dsIST = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
        Return dsIST

    End Function
    Sub executeSkip(ByVal ppID As String)
        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")
        Dim arrayttabindexF() As String = Session("arrayttabindexF")
        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim skipto As String = ""
        Dim skipif As String = ""
        Dim skippedenabledfalse As String = False
        Dim skippedsetempty As String = False
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID = ppID Then
                br = i
                skipto = ci.sskipto
                skipif = ci.sskipif
                skippedenabledfalse = ci.sskippedenabledfalse
                skippedsetempty = ci.sskippedsetempty
                Exit For
            End If
        Next

        Dim cidNext As String = ""
        For i As Integer = br + 1 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.Type = "TextBox" OrElse ci.Type = "DropDownList" Then
                cidNext = ci.ID
                Exit For
            End If
        Next
        If skipto = "" Then
            'go to next by tabindex
            Call skipEvent(ppID, cidNext, False, False)
        End If

        If skipto <> "" Then

            Dim st() As String = skipto.Split("$")
            Dim si() As String = skipif.Split("$")
            Dim sk As Boolean = False
            For i As Integer = 0 To si.GetUpperBound(0)
                Dim a As String = getExpression(si(i), ppID)
                If si(i).ToString.Trim.ToUpper = "SKIPPEDSETEMPTY" Then Exit For
                Dim indTo As Integer = Array.IndexOf(arrayttabindexF, st(i).Trim.ToUpper)
                If indTo > 0 Then
                    Dim ppIDskipTO As String = arrayttabindexTPF(indTo)
                    ResetEvent(ppID, ppIDskipTO)
                End If
            Next

            For i As Integer = 0 To si.GetUpperBound(0)
                Dim a As String = getExpression(si(i), ppID)
                Dim indTo As Integer = Array.IndexOf(arrayttabindexF, st(i).Trim.ToUpper)
                Dim ppIDskipTO As String = ""
                If indTo > 0 Then
                    ppIDskipTO = arrayttabindexTPF(indTo)
                End If
                If a = "True" Then
                    skipEvent(ppID, ppIDskipTO, skippedenabledfalse, skippedsetempty)
                    sk = True
                    'TREBA PONOVO JER U SKIPU MOZE NESTO DA ANULIRA
                    Call getVFNPK(ppID)   'sracunajFP
                    Exit For
                End If
            Next
            If sk = False Then
                Call skipEvent(ppID, cidNext, False, False)
            End If
            'skipto
        End If

    End Sub
    Private Sub ResetEvent(ByVal ppID As String, ByVal ppIDskipTO As String)
        If Session("arrayttabindex") Is Nothing Then Exit Sub

        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")

        Dim indFrom As Integer = Array.IndexOf(arrayttabindexTPF, ppID)
        Dim indTo As Integer = Array.IndexOf(arrayttabindexTPF, ppIDskipTO)

        For i As Integer = indFrom + 1 To indTo - 1
            EnabledEvent(arrayttabindexTPF(i), True)
        Next

    End Sub
    Private Sub skipEvent(ByVal ppID As String, ByVal ppIDskipTO As String, ByVal skippedenabledfalse As Boolean, ByVal skippedsetempty As Boolean, Optional ByVal skip As Boolean = True)
        If Session("arrayttabindex") Is Nothing Then Exit Sub

        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")

        Dim indFrom As Integer = Array.IndexOf(arrayttabindexTPF, ppID)
        Dim indTo As Integer = Array.IndexOf(arrayttabindexTPF, ppIDskipTO)

        If skippedsetempty = True Then
            For i As Integer = indFrom + 1 To indTo - 1
                AssignEvent(arrayttabindexTPF(i), "")
            Next
        End If

        If skippedenabledfalse = True Then
            For i As Integer = indFrom + 1 To indTo - 1
                EnabledEvent(arrayttabindexTPF(i), False)
            Next
        End If
        If skip Then
            Dim ct As Control = findControlByName(ppIDskipTO)
            If Not ct Is Nothing Then ct.Focus()
        End If

    End Sub
    Sub executeAssign(ByVal ppID As String)

        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")
        Dim arrayttabindexF() As String = Session("arrayttabindexF")

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim aassignto As String = ""
        Dim aassignif As String = ""
        Dim aassignwhat As String = ""

        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID = ppID Then
                br = i
                aassignto = ci.aassignto
                aassignif = ci.aassignif
                aassignwhat = ci.aassignwhat
                Exit For
            End If
        Next

        If aassignto <> "" Then
            Dim st() As String = aassignto.Split("$")
            Dim si() As String = aassignif.Split("$")
            Dim sw() As String = aassignwhat.Split("$")
            For i As Integer = 0 To si.GetUpperBound(0)

                Dim a As String = getExpression(si(i), ppID)
                If a = "True" Then
                    Dim att() As String = st(i).Split(",")
                    For ii As Integer = 0 To att.GetUpperBound(0)
                        Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(ii).Trim.ToUpper)
                        Dim ppIDskipTO As String = arrayttabindexTPF(indTo)
                        Dim ex As String = getExpression(sw(i), ppID)
                        AssignEvent(ppIDskipTO, ex)
                    Next
                End If
            Next
        End If
    End Sub
    Function getExpression(ByVal expression As String, ByVal ppID As String) As String
        getExpression = ""
        Dim arrayFP() As String = Session("arrayFP")
        Dim pexpression As String = expression
        pexpression = getHEAD(pexpression)
        pexpression = t.zameniFP(pexpression, Session("dsDB"), MyPanel, arrayFP)
        pexpression = t.replaceYYYMMMUser(pexpression, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
        pexpression = t.sracunajIzraz(pexpression, MyPanel, ppID.Trim.ToUpper.Substring(3))
        Dim a As String = t.scompute(pexpression, Session("dsDB"))
        getExpression = a
    End Function
    Function findControlByName(ByVal nname As String) As Control
        findControlByName = Nothing

        Dim txt As TextBox
        Dim lbl As Label
        Dim chbox As CheckBox
        Dim radiobutton As RadioButtonList
        Dim dropdown As DropDownList
        Dim menudropdown As DropDownList
        Dim ldropdown As DropDownList
        Dim btbtn As Button
        Dim bnbtn As Button
        Dim t As Boolean = False
        Dim l As Boolean = False
        Dim ch As Boolean = False
        Dim rb As Boolean = False
        Dim ddl As Boolean = False
        Dim lddl As Boolean = False
        Dim mlddl As Boolean = False
        Dim lbutton3 As DropDownList
        Dim lbtn3 As Boolean = False
        'Dim li As  Listitem 
        'Dim libtn3 As Boolean = False

        Dim btn As Boolean = False
        Dim bn As Boolean = False
        Dim ostalo As Boolean = False
        If nname.Length < 3 Then
            ostalo = True
        Else
            Dim subName As String = nname.Substring(0, 3)
            Dim ppTN As String = nname.Substring(3)

            If subName = "TP_" Then
                t = True
            ElseIf subName = "CB_" Then
                t = True
                nname = "TP_" + ppTN
            ElseIf subName = "LB_" OrElse subName = "FP_" Then
                l = True
            ElseIf subName = "LS_" Then
                lddl = True
            ElseIf subName = "MB_" Then
                mlddl = True
            ElseIf subName = "CH_" Then
                ch = True
            ElseIf subName = "RB_" Then
                rb = True
            ElseIf subName = "DL_" Then
                ddl = True
            ElseIf subName = "BT_" Then
                btn = True
            ElseIf subName = "MI_" Then
                lbtn3 = True
                'libtn3=true
            ElseIf subName = "BN_" Then
                bn = True
            Else
                ostalo = True
            End If
        End If
        Dim nnname As String = nname
        If ostalo = True Then
            nnname = ""
            txt = CType(MyPanel.FindControl("TP_" + nname), TextBox)
            If Not txt Is Nothing Then t = True : nnname = "TP_" + nname
            txt = CType(MyPanel.FindControl("CB_" + nname), TextBox)
            If Not txt Is Nothing Then t = True : nnname = "TP_" + nname

            lbl = CType(MyPanel.FindControl("LB_" + nname), Label)
            If Not lbl Is Nothing Then l = True : nnname = "LB_" + nname
            lbl = CType(MyPanel.FindControl("FP_" + nname), Label)
            If Not lbl Is Nothing Then l = True : nnname = "FP_" + nname

            chbox = CType(MyPanel.FindControl("CH_" + nname), CheckBox)
            If Not chbox Is Nothing Then ch = True : nnname = "CH_" + nname

            radiobutton = CType(MyPanel.FindControl("RB_" + nname), RadioButtonList)
            If Not radiobutton Is Nothing Then rb = True : nnname = "RB_" + nname

            dropdown = CType(MyPanel.FindControl("DL_" + nname), DropDownList)
            If Not dropdown Is Nothing Then ddl = True : nnname = "DL_" + nname

            ldropdown = CType(MyPanel.FindControl("LS_" + nname), DropDownList)
            If Not ldropdown Is Nothing Then lddl = True : nnname = "LS_" + nname

            menudropdown = CType(MyPanel.FindControl("MB_" + nname), DropDownList)
            If Not menudropdown Is Nothing Then lddl = True : nnname = "MB_" + nname

            btbtn = CType(MyPanel.FindControl("BT_" + nname), Button)
            If Not btbtn Is Nothing Then btn = True : nnname = "BT_" + nname

            bnbtn = CType(MyPanel.FindControl("BN_" + nname), Button)
            If Not bnbtn Is Nothing Then btn = True : nnname = "BN_" + nname
        End If

        If t = True Then
            txt = CType(MyPanel.FindControl(nnname), TextBox)
            If Not txt Is Nothing Then findControlByName = txt
        End If
        If l = True Then
            lbl = CType(MyPanel.FindControl(nnname), Label)
            If Not lbl Is Nothing Then findControlByName = lbl
        End If
        If ch = True Then
            chbox = CType(MyPanel.FindControl(nnname), CheckBox)
            If Not chbox Is Nothing Then findControlByName = chbox
        End If
        If rb = True Then
            radiobutton = CType(MyPanel.FindControl(nnname), RadioButtonList)
            If Not radiobutton Is Nothing Then findControlByName = radiobutton
        End If
        If ddl = True Then
            dropdown = CType(MyPanel.FindControl(nnname), DropDownList)
            If Not dropdown Is Nothing Then findControlByName = dropdown
        End If
        If lddl = True Then
            ldropdown = CType(MyPanel.FindControl(nnname), DropDownList)
            If Not ldropdown Is Nothing Then findControlByName = ldropdown
        End If
        If mlddl = True Then
            menudropdown = CType(MyPanel.FindControl(nnname), DropDownList)
            If Not menudropdown Is Nothing Then findControlByName = menudropdown
        End If

        If lbtn3 = True Then
            lbutton3 = CType(MyPanel.FindControl("MB_BUTTON3"), DropDownList)
            If Not lbutton3 Is Nothing Then findControlByName = lbutton3
        End If

        If btn = True Then
            btbtn = CType(MyPanel.FindControl(nnname), Button)
            If Not btbtn Is Nothing Then findControlByName = btbtn
        End If
        If bn = True Then
            bnbtn = CType(MyPanel.FindControl(nnname), Button)
            If Not bnbtn Is Nothing Then findControlByName = bnbtn
        End If


        Return findControlByName
    End Function
    Private Sub SetFocusEvent(ByVal nname As String)
        Dim ct As Control = findControlByName(nname)
        If Not ct Is Nothing Then
            ct.Focus()
        End If
    End Sub
    Private Sub AssignEvent(ByVal nname As String, ByVal vvalue As String)
        Dim ct As Control = findControlByName(nname)
        If Not ct Is Nothing Then
            If TypeOf ct Is TextBox Then
                CType(ct, TextBox).Text = vvalue
                Call putValueInDSTBCB(CType(ct, TextBox), vvalue)
            ElseIf TypeOf ct Is Label Then
                CType(ct, Label).Text = vvalue
            ElseIf TypeOf ct Is RadioButtonList Then
                CType(ct, RadioButtonList).SelectedValue = vvalue
                Call putValueInDSRB(CType(ct, RadioButtonList), vvalue)
            ElseIf TypeOf ct Is DropDownList Then
                If vvalue = "" Then
                    CType(ct, DropDownList).SelectedIndex = -1
                Else
                    CType(ct, DropDownList).SelectedValue = vvalue
                End If
                Call putValueInDSDDL(CType(ct, DropDownList), vvalue)
            ElseIf TypeOf ct Is CheckBox Then
                If vvalue <> "" AndAlso vvalue <> "0" Then CType(ct, CheckBox).Checked = True Else CType(ct, CheckBox).Checked = False
                Call putValueInDSCH(CType(ct, CheckBox), vvalue)
            End If
        End If
    End Sub

    Sub executeEnabled(ByVal ppID As String)

        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")
        Dim arrayttabindexF() As String = Session("arrayttabindexF")
        Dim arraypodtabela() As String = Session("arraypodtabela")
        Dim arrayTabButton() As String = Session("arrayTabButton")
        Dim arrayTabButtonBT() As String = Session("arrayTabButtonBT")
        Dim arrayButton() As String = Session("arrayButton")
        Dim arrayButtonBN() As String = Session("arrayButtonBN")

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim eEnabledTrue As String = ""
        Dim eEnabledTrueIf As String = ""
        Dim eEnabledFalse As String = ""
        Dim eEnabledFalseIf As String = ""

        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID = ppID Then
                br = i
                eEnabledTrue = ci.eEnabledTrue
                eEnabledTrueIf = ci.eEnabledTrueIf
                eEnabledFalse = ci.eEnabledFalse
                eEnabledFalseIf = ci.eEnabledFalseIf
                Exit For
            End If
        Next

        If eEnabledTrueIf <> "" Then
            Dim at() As String = eEnabledTrue.Split("$")
            Dim ai() As String = eEnabledTrueIf.Split("$")

            For i As Integer = 0 To ai.GetUpperBound(0)

                Dim a As String = getExpression(ai(i), ppID)
                Dim avred As Boolean = False

                If a = "True" Then avred = True
                Dim att() As String = at(i).Split(",")
                For ii As Integer = 0 To att.GetUpperBound(0)
                    Dim ppIDskipTO As String = ""
                    Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(ii).Trim.ToUpper)
                    If indTo > -1 Then
                        ppIDskipTO = arrayttabindexTPF(indTo)
                    Else
                        indTo = Array.IndexOf(arraypodtabela, att(ii).Trim.ToUpper)
                        If indTo > -1 Then ppIDskipTO = arraypodtabela(indTo)
                    End If
                    If ppIDskipTO <> "" Then EnabledEvent(ppIDskipTO, avred)
                    If Not att(ii) Is Nothing AndAlso arrayButton.Contains(att(ii).ToString.Trim.ToUpper) Then
                        If avred = True Then
                            If att(ii).Trim.ToUpper.IndexOf("BN_") >= 0 Then
                                EnabledEvent(att(ii), Not avred)
                            Else
                                EnabledEvent("BN_" + att(ii), avred)
                            End If
                        End If
                    End If
                Next
            Next
        End If

        If eEnabledFalseIf <> "" Then
            Dim at() As String = eEnabledFalse.Split("$")
            Dim ai() As String = eEnabledFalseIf.Split("$")
            For i As Integer = 0 To ai.GetUpperBound(0)
                Dim a As String = getExpression(ai(i), ppID)
                Dim avred As Boolean = False

                If a = "True" Then avred = True
                Dim att() As String = at(i).Split(",")
                For ii As Integer = 0 To att.GetUpperBound(0)
                    Dim ppIDskipTO As String = ""
                    Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(ii).Trim.ToUpper)
                    If indTo > -1 Then
                        ppIDskipTO = arrayttabindexTPF(indTo)
                    Else
                        indTo = Array.IndexOf(arraypodtabela, att(ii).Trim.ToUpper.Replace("TABLE", ""))
                        If indTo > -1 Then
                            ppIDskipTO = arrayTabButtonBT(indTo)
                        End If
                    End If
                    If ppIDskipTO <> "" Then EnabledEvent(ppIDskipTO, Not avred)
                    If Not att(ii) Is Nothing AndAlso arrayButton.Contains(att(ii).ToString.Trim.ToUpper) Then
                        If avred = True Then
                            If att(ii).Trim.ToUpper.IndexOf("BN_") >= 0 Then
                                EnabledEvent(att(ii), Not avred)
                            Else
                                EnabledEvent("BN_" + att(ii), Not avred)
                            End If
                        End If
                    End If
                Next
            Next
        End If
    End Sub
    Sub executeVisible(ByVal ppID As String)

        Dim arrayttabindexTPF() As String = Session("arrayttabindexTPF")
        Dim arrayttabindexF() As String = Session("arrayttabindexF")
        Dim arraypodtabela() As String = Session("arraypodtabela")
        Dim arrayTabButton() As String = Session("arrayTabButton")
        Dim arrayTabButtonBT() As String = Session("arrayTabButtonBT")

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim vVisibleTrue As String = ""
        Dim vVisibleTrueIf As String = ""
        Dim vVisibleFalse As String = ""
        Dim vVisibleFalseIf As String = ""

        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID = ppID Then
                br = i
                vVisibleTrue = ci.vVisibleTrue
                vVisibleTrueIf = ci.vVisibleTrueIf
                vVisibleFalse = ci.vVisibleFalse
                vVisibleFalseIf = ci.vVisibleFalseIf
                Exit For
            End If
        Next

        If vVisibleTrueIf <> "" Then
            Dim at() As String = vVisibleTrue.Split("$")
            Dim ai() As String = vVisibleTrueIf.Split("$")

            For i As Integer = 0 To ai.GetUpperBound(0)
                Dim a As String = getExpression(ai(i), ppID)
                Dim avred As Boolean = False

                If a = "True" Then avred = True
                Dim att() As String = at(i).Split(",")
                For ii As Integer = 0 To att.GetUpperBound(0)
                    Dim ppIDskipTO As String = ""
                    Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(ii).Trim.ToUpper)
                    If indTo > -1 Then
                        ppIDskipTO = arrayttabindexTPF(indTo)
                    Else
                        indTo = Array.IndexOf(arraypodtabela, att(ii).Trim.ToUpper)
                        If indTo > -1 Then ppIDskipTO = arraypodtabela(indTo)
                    End If
                    If ppIDskipTO <> "" Then VisibleEvent(ppIDskipTO, avred)
                Next
            Next
        End If

        If vVisibleFalseIf <> "" Then
            Dim at() As String = vVisibleFalse.Split("$")
            Dim ai() As String = vVisibleFalseIf.Split("$")
            For i As Integer = 0 To ai.GetUpperBound(0)
                Dim a As String = getExpression(ai(i), ppID)
                Dim avred As Boolean = False

                If a = "True" Then avred = True
                Dim att() As String = at(i).Split(",")
                For ii As Integer = 0 To att.GetUpperBound(0)
                    Dim ppIDskipTO As String = ""
                    Dim indTo As Integer = Array.IndexOf(arrayttabindexF, att(ii).Trim.ToUpper)
                    If indTo > -1 Then
                        ppIDskipTO = arrayttabindexTPF(indTo)
                    Else
                        indTo = Array.IndexOf(arraypodtabela, att(ii).Trim.ToUpper.Replace("TABLE", ""))
                        If indTo > -1 Then
                            ppIDskipTO = arrayTabButtonBT(indTo)
                        End If
                    End If
                    If ppIDskipTO <> "" Then VisibleEvent(ppIDskipTO, Not avred)
                Next
            Next
        End If
    End Sub
    Private Sub EnabledEvent(ByVal nname As String, ByVal vvalue As Boolean)

        Dim ct As Control = findControlByName(nname)
        If Not ct Is Nothing Then
            If TypeOf ct Is TextBox Then
                CType(ct, TextBox).Enabled = vvalue
            ElseIf TypeOf ct Is Label Then
                CType(ct, Label).Enabled = vvalue
            ElseIf TypeOf ct Is RadioButtonList Then
                CType(ct, RadioButtonList).Enabled = vvalue
            ElseIf TypeOf ct Is CheckBox Then
                CType(ct, CheckBox).Enabled = vvalue
            ElseIf TypeOf ct Is DropDownList AndAlso nname.Trim.ToUpper.IndexOf("MI_") <> 0 Then
                CType(ct, DropDownList).Enabled = vvalue
            ElseIf TypeOf ct Is GridView Then
                CType(ct, GridView).Enabled = vvalue
            ElseIf TypeOf ct Is Button Then
                CType(ct, Button).Enabled = vvalue
            ElseIf TypeOf ct Is DropDownList AndAlso nname.Trim.ToUpper.IndexOf("MI_") = 0 Then
                Dim item As ListItem = CType(ct, DropDownList).Items.FindByValue(nname)
                If item IsNot Nothing Then item.Enabled = vvalue
            End If
        End If

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)

        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID = nname Then
                ci.cEnabled = vvalue
                al(i) = ci
                Exit For
            End If
        Next
        Me.Session("DynamicControls") = al
    End Sub
    Private Sub VisibleEvent(ByVal nname As String, ByVal vvalue As Boolean)

        Dim ct As Control = findControlByName(nname)
        If Not ct Is Nothing Then
            If TypeOf ct Is TextBox Then
                CType(ct, TextBox).Visible = vvalue
            ElseIf TypeOf ct Is Label Then
                CType(ct, Label).Visible = vvalue
            ElseIf TypeOf ct Is RadioButtonList Then
                CType(ct, RadioButtonList).Visible = vvalue
            ElseIf TypeOf ct Is CheckBox Then
                CType(ct, CheckBox).Visible = vvalue
            ElseIf TypeOf ct Is DropDownList AndAlso nname.Trim.ToUpper.IndexOf("MI_") <> 0 Then
                CType(ct, DropDownList).Visible = vvalue
            ElseIf TypeOf ct Is GridView Then
                CType(ct, GridView).Visible = vvalue
            ElseIf TypeOf ct Is Button Then
                CType(ct, Button).Visible = vvalue
            ElseIf TypeOf ct Is DropDownList AndAlso nname.Trim.ToUpper.IndexOf("MI_") = 0 Then
                Dim item As ListItem = CType(ct, DropDownList).Items.FindByValue(nname)
                If item IsNot Nothing Then item.Enabled = vvalue
            End If
        End If

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID = nname AndAlso ci.vvisible = True Then
                ci.cVisible = vvalue
                al(i) = ci
                Exit For
            End If
        Next
        Me.Session("DynamicControls") = al
    End Sub

    Sub DropDownList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim ddl As DropDownList = CType(sender, DropDownList)
        Dim controlID As String = Request.Params("__EVENTTARGET")
        Dim ddlChanged = False
        If controlID <> sender.UniqueID Then Exit Sub

        Dim sifraPolja = sender.UniqueID.ToString.Substring(sender.UniqueID.indexof("DL_") + 3)
        Dim sValue = ddl.SelectedValue

        'Treba daa aproverava ovo samo ako je ddl kljuc*********************************************************************************
        If Session("ddlKey") IsNot Nothing AndAlso Session("ddlKey") = sifraPolja Then

            '*********************************
            GetParameters(sifraPolja, sValue)
            '************************************

            ddlChanged = True
            Dim tablename As String = Session("maintable")
            Dim pkCurrentTableX() As String = Session("pkCurrentTable").trim.toupper.split(";")
            '        pkCurrentTableX = pkCurrentTableX.Concat(New String() {"SIFRAP"}).ToArray()
            Dim strProveiOpetUiliI As String = "select * from " + tablename + " where "
            For i As Integer = 0 To pkCurrentTableX.GetUpperBound(0)
                If t.SE(pkCurrentTableX(i), MyPanel) Is Nothing OrElse t.SE(pkCurrentTableX(i), MyPanel) = "" Then
                    'Return "NERADINISTA"
                    Dim msg = "nista"
                End If
                strProveiOpetUiliI = strProveiOpetUiliI + pkCurrentTableX(i) + "=N'" + t.SE(pkCurrentTableX(i), MyPanel) + "' and "
            Next
            strProveiOpetUiliI = strProveiOpetUiliI + " 2=2"
            Dim dsProveiOpetUiliI As DataSet = b.DajDS_IzUpita(strProveiOpetUiliI, Me.DBConnectionString.Text, Session("Country"))
            If dsProveiOpetUiliI.Tables(0) Is Nothing OrElse dsProveiOpetUiliI.Tables(0).Rows.Count = 0 Then
                lblInsertUpdate.Text = "I"
            Else
                lblInsertUpdate.Text = "U"
            End If

        End If
        '^^^ Treba daa aproverava ovo samo ako je ddl kljuc*********************************************************************************^

        Dim pp As DropDownList = CType(sender, DropDownList)
        Dim ppID As String = CType(sender, DropDownList).ID
        Dim ppTN As String = ppID.Substring(3)
        Dim vvalue As String = pp.SelectedValue
        Session(ppTN) = vvalue   'treba filter = filter + HttpContext.Current.Session(pp(m).Substring(2)) + "="
        Session("filter") = Session("filter") + ppTN + ";"
        Call anulateDependantDDL(ppID)
        Call populateDependantDDL(ppID)
        'skinuti da na proverava ako je -999
        Dim vv As String = executeCheck(ppID, vvalue)
        'If vvalue <> -999 Then vv = executeCheck(ppID, vvalue)
        'needed because No=;
        If vv.Trim <> "" Then
            'CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = vv
            CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Text = vv
            CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Style("display") = "block"
            'pp.Text = ""
            pp.Text = -999
            obojPoljaUExecuteCheckDodajTooltip(ppID, vv)
            'Page.SetFocus(pp)
            Exit Sub
        End If

        If Session("appcode") = "adminweb" AndAlso vvalue <> "" Then
            Dim usern = Session("pkCurrentTableValue").ToString.Split(";")
            usern(3) = vvalue
            Dim aab As String = ""
            For i As Integer = 0 To usern.GetUpperBound(0)
                aab = aab + usern(i) + ";"
            Next
            Session("pkCurrentTableValue") = aab
        End If

        ''upisi polje
        Call putValueInDSDDL(pp, vvalue)
        If ddlChanged Then
            Call Puni_dsDB(False, ddlChanged, vvalue)
            ValidateSave(True)
        End If
        Call LeaveControl(ppID)
    End Sub
    Private Structure ControlInfoGrid
        Public ID As String
        Public Type As String
        Public tab As String
        Public ttext As String
        Public ggrid As String
        Public ggridopis As String
        Public connectionstring As String
        Public datasource As String
        Public where As String
        Public pk As String
        Public pkHT As String
        Public dtG As DataTable
    End Structure
    Sub CreateGrid()
        Dim ciG As ControlInfoGrid
        Dim datarowsGrid As DataRow()
        datarowsGrid = Session("datarowsGrid")
        Dim dsISTTabele As DataSet
        dsISTTabele = Session("dsISTTabele")
        Dim maintable As String = Session("maintable").ToString.Trim.ToUpper
        Dim type As String = ""
        Dim tab As String = ""
        Dim ttext As String = ""
        Dim connectionstring As String = ""
        Dim ggrid As String = ""
        Dim ggridopis As String = ""
        Dim datasource As String = ""
        Dim wwhere As String = ""
        Dim drT As DataRow()
        Dim pk As String = ""
        Dim pkHT As String = ""
        For i As Integer = 0 To datarowsGrid.Count - 1
            Dim redPolja As DataRow = datarowsGrid(i)
            tab = redPolja.Item("polje").ToString.Trim.ToUpper
            drT = dsISTTabele.Tables(0).Select("tabela='" + tab + "'")
            Dim dr As DataRow = drT(0)
            ttext = dr.Item("opis").ToString.Trim
            connectionstring = dr.Item("connectionstring").ToString.Trim
            datasource = "select " + dr.Item("childPKS").ToString.Trim + " from " + tab + " where 2=2 "
            pk = dr.Item("childPKS").ToString.Trim
            pkHT = dr.Item("childPKHT").ToString.Trim
            Dim tableN As New Table()
            table = tableN
            table.ID = "TableGrid_" + tab

            Dim rowN As New TableRow()
            row = rowN

            ID = "AB_" + tab
            ciG = PersistControlGrid(ID, "ButtonAdd", tab, "🞧 " + ttext, "", "", "", "", "")
            CreateControlGrid(ciG)
            row.Cells.Add(cell)
            table.Rows.Add(row)
            row = Nothing
            cell = Nothing

            Dim rowN2 As New TableRow()
            row = rowN2
            ID = "GV_" + tab
            ciG = PersistControlGrid(ID, "GridView", tab, ttext, datasource, wwhere, connectionstring, pk, pkHT)
            CreateControlGrid(ciG)
            row.Cells.Add(cell)
            table.Rows.Add(row)
            row = Nothing
            cell = Nothing


            PanelGrid.Controls.Add(table)
            table.Style("display") = "none"
            table = Nothing

        Next

        datarowsGrid = Nothing

    End Sub

    Private Function CreateControlGrid(ByVal ci As ControlInfoGrid) As Control
        Dim ctl As Control = Nothing
        Dim dsgv As New DataSet
        Dim dt As New DataTable

        Select Case ci.Type
            Case "GridView"
                ctl = New GridView()
                CType(ctl, GridView).AutoGenerateColumns = False
                CType(ctl, GridView).AllowPaging = True
                CType(ctl, GridView).PageSize = 10
                CType(ctl, GridView).AllowSorting = True
                CType(ctl, GridView).DataSource = ci.datasource

                Me.AppendEvent(ctl, "GridOnRowBound")
                Me.AppendEvent(ctl, "GridPageIndexChanging")
                Me.AppendEvent(ctl, "GridSelectedIndexChanged")
                Me.AppendEvent(ctl, "GridSorting")
                Me.AppendEvent(ctl, "GridOnRowDeleting")
                Me.AppendEvent(ctl, "GridLoad")

                Dim selectField As New CommandField()
                selectField.ShowSelectButton = True
                selectField.SelectText = "📑"
                selectField.HeaderText = ""
                CType(ctl, GridView).Columns.Add(selectField)

                Dim deleteField As New CommandField()
                deleteField.ShowDeleteButton = True
                deleteField.DeleteText = "✘"
                deleteField.HeaderText = ""
                CType(ctl, GridView).Columns.Add(deleteField)

                Dim pk() As String = ci.pk.Split(",")
                Dim pkHT() As String = ci.pkHT.Split(",")
                For i As Integer = 0 To pk.GetUpperBound(0)
                    Dim nameField As New BoundField()
                    nameField.DataField = pk(i).Trim 'The name of the field in the data source
                    nameField.HeaderText = pkHT(i).Trim
                    CType(ctl, GridView).Columns.Add(nameField)
                    nameField.SortExpression = nameField.DataField
                Next

            Case "ButtonAdd"
                ctl = New Button()
                CType(ctl, Button).Text = ci.ttext.ToString()
                CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
                Me.AppendEvent(ctl, "ClickAdd")
            Case Else
                Return Nothing
        End Select

        ctl.ID = ci.ID
        If ci.Type = "GridView" Then
            Dim cellN As New TableCell()
            cellN.Controls.Add(ctl)
            cell = cellN
        Else
            Dim cellN As New TableCell()
            cellN.Controls.Add(ctl)
            cell = cellN
        End If

        Return ctl
    End Function

    Public Function bindGV(ByVal gv As GridView, ByVal str As String, ByVal connectionstring As String, Optional strwhere As String = "", Optional tabela As String = "") As Integer
        'If connectionstring.Contains("ZSZ") Then connectionstring=connectionstring.Replace("ZSZ", "14TORG")
        'If connectionstring.Contains("imt2") Then connectionstring=connectionstring.Replace("imt2", "172.16.18.20")
        Dim ds As DataSet = b.DajDS_IzUpita(str, connectionstring, Session("Country"))
        Dim dt As DataTable = ds.Tables(0)
        If ds.Tables(0).Rows.Count > 0 Then
            gv.DataSource = dt
            gv.DataBind()
            bindGV = gv.Rows.Count   'broj redova
        Else
            BezRedova(dt, gv)
            bindGV = 0
        End If


    End Function
    Private Function PersistControlGrid(ByVal id As String, ByVal type As String, ByVal tab As String, ttext As String, ByVal datasource As String, ByVal wwhere As String, ByVal connectionstring As String, ByVal pk As String, ByVal pkHT As String) As ControlInfoGrid
        Dim ciG As New ControlInfoGrid
        ciG.ID = id
        ciG.Type = type
        ciG.tab = tab
        ciG.ttext = ttext
        ciG.connectionstring = connectionstring
        ciG.where = wwhere
        ciG.pk = pk
        ciG.pkHT = pkHT

        'datasource od trenutne tabele pk
        Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
        Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")
        Dim sqlDB As String = datasource
        Dim sqlDBwhere As String = ""
        For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
            sqlDBwhere = sqlDBwhere + " and " + pkCurrentTable(i) + "='" + pkCurrentTableValue(i) + "'"
        Next
        sqlDB = sqlDB + sqlDBwhere
        ciG.datasource = sqlDB
        'datasource      

        Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)
        If alG Is Nothing Then
            alG = New ArrayList()
        End If

        alG.Add(ciG)
        Me.Session("DynamicControlsGrid") = alG

        Return ciG
    End Function

    Private Structure ControlInfo
        Public ID As String
        Public Type As String
        Public ttab As String
        Public ggrid As String
        Public ggridopis As String
        Public colspan As Integer
        Public rowspan As Integer
        Public ttop As Integer
        Public f1 As Integer
        Public lleft As Integer
        Public ttabindex As Integer
        Public rReadOnly As Boolean
        Public vvisible As Boolean
        Public ttext As String
        Public wwidth As Integer
        Public ddisplay As Boolean
        Public hheight As Integer
        Public EventHandler As String
        Public zindex As Integer
        Public mmultiline As Boolean
        Public sskipif As String
        Public sskipto As String
        Public sstopif As String
        Public sstopmsg As String
        Public sskippedenabledfalse As Boolean
        Public sskippedsetempty As Boolean
        Public aassignif As String
        Public aassignto As String
        Public aassignwhat As String
        Public ppk As Boolean
        Public eenabledppk As Boolean
        Public mxlength As Integer
        Public mnlength As Integer
        Public mmin As Long
        Public mmax As Long
        Public yyes As String
        Public nno As String
        Public cEnabled As Boolean
        Public cVisible As Boolean
        Public eEnabledTrue As String
        Public eEnabledTrueIf As String
        Public eEnabledFalse As String
        Public eEnabledFalseIf As String
        Public vVisibleTrue As String
        Public vVisibleTrueIf As String
        Public vVisibleFalse As String
        Public vVisibleFalseIf As String
        Public CBODataSource As String
        Public CBODisplayMember As String
        Public CBOValueMember As String
        Public CBOFilter As String
        Public CBOFilterBy As String
        Public CBOSortBy As String
        Public webTab As Integer
        Public webtabName As String
        Public RadioButtonListFields As String
        Public CheckBoxGroup As String
        Public DBConnectionString As String
        Public gridpk As String
        Public gridpkHT As String
        Public gridok As String
        Public gridokHT As String
    End Structure

    Private Sub CreateControlPage(ByVal ci As ControlInfo)
        Dim ctl As Control = Nothing

        Select Case ci.Type
            Case "Button"
                ctl = New Button()
                CType(ctl, Button).Text = ci.ttext.ToString()
                If ci.ID.Contains("BT_BUTTON") Then If ci.ID.Replace("BT_BUTTON", "").Trim = 3 Then CType(ctl, Button).CssClass = "buttonActive" 'BackColor = Color.rosybrown     'Color.FromARGB(46,126,193)'
                Me.AppendEvent(ctl, ci.EventHandler)
            Case "TextBox"
                ctl = New TextBox()
                CType(ctl, TextBox).ReadOnly = ci.rReadOnly
                'bbackcolor
                If ci.rReadOnly = False Then
                    'prava polja
                    CType(ctl, TextBox).AutoPostBack = True
                    If ci.sskipif <> "" OrElse ci.aassignif <> "" OrElse ci.eEnabledFalseIf <> "" OrElse ci.eEnabledTrueIf <> "" OrElse ci.vVisibleFalseIf <> "" OrElse ci.vVisibleTrueIf <> "" OrElse ci.mmax <> 9999999999 OrElse ci.mmin <> -9999999999 OrElse ci.mnlength <> 0 OrElse ci.yyes <> "" OrElse ci.nno <> "" Then
                        CType(ctl, TextBox).Attributes.Add("data-skip-js-navigation", "True")
                    End If

                    CType(ctl, TextBox).TabIndex = ci.ttabindex
                    CType(ctl, TextBox).MaxLength = ci.mxlength

                    If ci.ppk = True And ci.eenabledppk = False Then
                        CType(ctl, TextBox).Enabled = False
                        CType(ctl, TextBox).TabIndex = -1
                    Else
                        CType(ctl, TextBox).Enabled = True
                    End If
                    If ci.vvisible = True Then
                        CType(ctl, TextBox).Visible = ci.cVisible
                    Else
                        CType(ctl, TextBox).Visible = ci.vvisible
                    End If

                    CType(ctl, TextBox).Attributes.Add("onfocus", "this.style.backgroundColor = 'lightyellow';this.select();")
                    CType(ctl, TextBox).Attributes.Add("onblur", "this.style.backgroundColor = '';")
                Else
                    CType(ctl, TextBox).Text = ci.ttext.ToString()
                End If

                Me.AppendEvent(ctl, ci.EventHandler)

            Case "RadioButtonList"
                ctl = New RadioButtonList()
                Me.AppendEvent(ctl, ci.EventHandler)

            Case "CheckBox"
                ctl = New CheckBox()
                Me.AppendEvent(ctl, ci.EventHandler)

            Case "GridView"
                ctl = New GridView()

                If ci.vvisible = True Then
                    CType(ctl, GridView).Visible = ci.cVisible
                Else
                    CType(ctl, GridView).Visible = ci.vvisible
                End If

                Me.AppendEvent(ctl, ci.EventHandler)
            Case "MenuBox", "ListBox"
                ctl = New DropDownList()
                CType(ctl, DropDownList).AutoPostBack = True
                'CType(ctl, DropDownList).text="AAAAA"
                Dim dm() As String = ci.CBODisplayMember.Split(";")
                Dim vm() As String = ci.CBOValueMember.Split(";")
                'CType(ctl, ListBox).TabIndex = ci.ttabindex
                For i As Integer = 0 To dm.GetUpperBound(0)
                    CType(ctl, DropDownList).Items.Add(New ListItem(dm(i).Replace("'", "").Trim, vm(i).Trim))
                    CType(ctl, DropDownList).Items(i).Attributes.Add("id", vm(i).Trim.ToUpper)
                Next
                Me.AppendEvent(ctl, ci.EventHandler)

            Case "DropDownList"
                ctl = New DropDownList()
                'prava polja
                CType(ctl, DropDownList).AutoPostBack = True
                If ci.sskipif <> "" OrElse ci.aassignif <> "" OrElse ci.eEnabledFalseIf <> "" OrElse ci.eEnabledTrueIf <> "" OrElse ci.vVisibleFalseIf <> "" OrElse ci.vVisibleTrueIf <> "" OrElse ci.mmax <> 9999999999 OrElse ci.mmin <> -9999999999 OrElse ci.mnlength <> 0 OrElse ci.yyes <> "" OrElse ci.nno <> "" Then
                    CType(ctl, DropDownList).Attributes.Add("data-skip-js-navigation", "True")
                End If
                CType(ctl, DropDownList).TabIndex = ci.ttabindex

                If ci.ppk = True And ci.eenabledppk = False Then
                    CType(ctl, DropDownList).Enabled = False
                    CType(ctl, DropDownList).TabIndex = -1
                Else
                    CType(ctl, DropDownList).Enabled = True
                End If
                If ci.vvisible = True Then
                    CType(ctl, DropDownList).Visible = ci.cVisible
                Else
                    CType(ctl, DropDownList).Visible = ci.vvisible
                End If

                CType(ctl, DropDownList).Attributes.Add("onfocus", "this.style.backgroundColor = 'lightyellow';") 'this.select();
                CType(ctl, DropDownList).Attributes.Add("onblur", "this.style.backgroundColor = '';")

                If ci.CBOFilter = "''" Then Call PopulateDropDownList(ci.CBOSortBy, ci.ID.Replace("DL_", "").Trim.ToUpper, CType(ctl, DropDownList), ci.CBODataSource, ci.DBConnectionString, ci.CBODisplayMember, ci.CBOValueMember)

                Me.AppendEvent(ctl, ci.EventHandler)

            Case "Label", "VirtualField"
                ctl = New Label()
                CType(ctl, Label).Text = ci.ttext.ToString
                If ci.wwidth = 1 Then
                    Dim asd As String = "fiktivno polje samo za cuvanje nekog zbira...." ' treba proveriti da se ne kosi sa necim
                    ci.vvisible = False
                    'ci.cVisible = False
                    'ci.cEnabled = false
                    If ci.vvisible = False Then
                        CType(ctl, Label).Style("display") = "none"
                    End If

                End If




                Dim blanks As Integer = CountLeadingBlanks(ci.ttext.ToString)
                If ci.ddisplay = False Then
                    CType(ctl, Label).Style("display") = "none"
                End If

                If blanks > 0 Then
                    CType(ctl, Label).Style("padding-left") = CStr(blanks * 10).Trim + "px"
                End If

            Case Else

        End Select

        ctl.ID = ci.ID

        If ci.rReadOnly = False AndAlso ci.Type = "TextBox" Then
            If ci.ID.Substring(0, 3) = "TP_" Then
                Dim cellN As New TableCell()
                cellN.Controls.Add(ctl)
                cell = cellN
            End If
            If ci.ID.Substring(0, 3) = "CB_" Then
                Dim updatePanelN As New UpdatePanel
                updatePanelN.ID = "UpdatePanel" + ci.ID
                updatePanelN.ContentTemplateContainer.Controls.Add(ctl)
                CType(ctl, TextBox).AutoPostBack = True 'MORA ima update panel, pa ne treba i textbox da bude true jer onda 2x ide na textChanged  
                CType(ctl, TextBox).AutoCompleteType = AutoCompleteType.None
                Dim autoCompleteExtender As New AjaxControlToolkit.AutoCompleteExtender()
                autoCompleteExtender.ID = "AutoCompleteExtender" + ci.ID
                autoCompleteExtender.ServiceMethod = "GetSuggestions"

                autoCompleteExtender.MinimumPrefixLength = 1
                autoCompleteExtender.CompletionInterval = 100 'bilo 1000
                autoCompleteExtender.EnableCaching = False
                autoCompleteExtender.TargetControlID = ctl.ID
                autoCompleteExtender.ContextKey = ci.ID + "$" + ci.DBConnectionString
                autoCompleteExtender.FirstRowSelected = True

                Dim ctlH As New TextBox()
                ctlH.ID = "TP_" + ci.ID.Substring(3)
                ctlH.Visible = False
                updatePanelN.ContentTemplateContainer.Controls.Add(ctlH)
                updatePanelN.ContentTemplateContainer.Controls.Add(autoCompleteExtender)

                Dim cellN As New TableCell()
                cellN.Controls.Add(updatePanelN)
                cell = cellN
            End If

        ElseIf ci.Type = "DropDownList" OrElse ci.Type = "MenuBox" OrElse ci.Type = "ListBox" Then
            'Dim updatePanelN As New UpdatePanel
            'ctl.ID = ci.ID
            'updatePanelN.ID = "UpdatePanel" + ci.ID
            'CType(ctl, DropDownList).AutoPostBack = True
            'updatePanelN.ContentTemplateContainer.Controls.Add(ctl)

            'Dim cellN As New TableCell()
            'cellN.Controls.Add(updatePanelN)
            'cell = cellN
            CType(ctl, DropDownList).AutoPostBack = True
            Dim cellN As New TableCell()
            cellN.Controls.Add(ctl)
            cell = cellN
        ElseIf ci.Type = "GridView" Then
            Dim btn As New Button
            btn.ID = "AB_" + ci.ID.Replace("GV_", "")
            btn.Text = "🞧"

            AddHandler(CType(btn, Button)).Click, New System.EventHandler(AddressOf Me.ButtonAdd_Click)

            CType(ctl, GridView).AutoGenerateColumns = False
            CType(ctl, GridView).AllowPaging = True
            CType(ctl, GridView).PageSize = 10
            CType(ctl, GridView).AllowSorting = True
            CType(ctl, GridView).DataSource = ci.CBODataSource
            'CType(ctl, GridView).DataSource = ci.DBConnectionString   
            CType(ctl, GridView).AllowSorting = True
            'CType(ctl, GridView).EnableViewState =true
            Me.AppendEvent(ctl, "GridOnRowBound")
            Me.AppendEvent(ctl, "GridPageIndexChanging")
            Me.AppendEvent(ctl, "GridSelectedIndexChanged")
            Me.AppendEvent(ctl, "GridSorting")
            Me.AppendEvent(ctl, "GridOnRowDeleting")
            Me.AppendEvent(ctl, "GridLoad")

            Dim selectField As New CommandField()
            selectField.ShowSelectButton = True
            selectField.SelectText = "📑"
            selectField.HeaderText = ""
            CType(ctl, GridView).Columns.Add(selectField)

            Dim deleteField As New CommandField()
            deleteField.ShowDeleteButton = True
            deleteField.DeleteText = "✘"
            deleteField.HeaderText = ""

            CType(ctl, GridView).Columns.Add(deleteField)

            Dim pk() As String = ci.gridpk.Split(",")
            Dim pkHT() As String = ci.gridpkHT.Split(",")

            For i As Integer = 0 To pk.GetUpperBound(0)
                Dim nameField As New BoundField()
                nameField.DataField = pk(i).Trim 'The name of the field in the data source
                nameField.HeaderText = pkHT(i).Trim
                CType(ctl, GridView).Columns.Add(nameField)
                nameField.SortExpression = nameField.DataField
            Next

            Dim ok() As String = ci.gridok.Split(",")
            Dim okHT() As String = ci.gridokHT.Split(",")
            For i As Integer = 0 To ok.GetUpperBound(0)
                Dim nameField As New BoundField()
                nameField.DataField = ok(i).Trim 'The name of the field in the data source
                nameField.HeaderText = okHT(i).Trim
                CType(ctl, GridView).Columns.Add(nameField)
                nameField.SortExpression = nameField.DataField
            Next

            CType(ctl, GridView).Caption = ci.ttext

            Dim cellN As New TableCell()
            cellN.Controls.Add(btn)
            cellN.Controls.Add(ctl)
            cell = cellN

        ElseIf ci.rReadOnly = False AndAlso ci.Type = "Button" AndAlso ci.ttab = "tab" Then 'ne moze kao textbox NE SME DA IMA update panel

            Dim cellN As New TableCell()
            cellN.Controls.Add(ctl)
            cell = cellN


        ElseIf ci.rReadOnly = False AndAlso ci.Type = "CheckBox" Then
            Dim updatePanelN As New UpdatePanel
            ctl.ID = ci.ID
            updatePanelN.ID = "UpdatePanel" + ci.ID
            CType(ctl, CheckBox).AutoPostBack = False

            If ci.CheckBoxGroup <> "" Then
                If hF.IndexOf(ci.CheckBoxGroup + ";") < 0 Then
                    Dim hiddenField As New HiddenField()
                    hiddenField.ID = "hiddenField" + ci.CheckBoxGroup
                    hF = hF + ci.CheckBoxGroup + ";"
                    CType(ctl, CheckBox).Attributes("onclick") = "updateCheckedItems(this, '" & hiddenField.ID & "');"
                    updatePanelN.ContentTemplateContainer.Controls.Add(hiddenField)
                Else
                    Dim hiddenFieldID As String = "hiddenField" + ci.CheckBoxGroup
                    CType(ctl, CheckBox).Attributes("onclick") = "updateCheckedItems(this, '" & hiddenFieldID & "');"
                End If
            End If

            If ci.CheckBoxGroup <> "" Then
                CType(ctl, CheckBox).Attributes.Add("data-myvalue", ci.ID.Replace("CH_", ""))
            End If

            updatePanelN.ContentTemplateContainer.Controls.Add(ctl)

            Dim cellN As New TableCell()
            cellN.Controls.Add(updatePanelN)
            cell = cellN

        ElseIf ci.rReadOnly = False AndAlso ci.Type = "RadioButtonList" Then

            Dim updatePanelN As New UpdatePanel
            updatePanelN.ID = "UpdatePanel" + ci.ID
            CType(ctl, RadioButtonList).AutoPostBack = False

            Dim nv() As String = ci.RadioButtonListFields.Split("$")
            For i As Integer = 1 To nv.Length
                Dim mm As Integer = nv(i - 1).ToString.IndexOf("'")
                If mm < 0 Then
                    nv(i - 1) = "'" + nv(i - 1).Trim
                    mm = 0
                End If
                Dim tt As String = nv(i - 1).ToString.Substring(0, mm).Trim
                Dim rbttext As String = ""
                Dim rbvalue As String = ""
                If mm = 0 OrElse IsNumeric(tt) = False Then
                    rbttext = CStr(i).Trim & "  " & nv(i - 1).ToString.Replace("'", "").Trim
                    rbvalue = CStr(i).Trim
                ElseIf IsNumeric(tt) Then
                    rbttext = tt.Trim & "  " & nv(i - 1).ToString.Substring(mm).Replace("'", "").Trim
                    rbvalue = CStr(tt).Trim
                End If
                CType(ctl, RadioButtonList).Items.Add(New ListItem(rbttext, rbvalue))
            Next

            updatePanelN.ContentTemplateContainer.Controls.Add(ctl)

            Dim cellN As New TableCell()
            cellN.Controls.Add(updatePanelN)
            cell = cellN

        Else
            Dim cellNH As New TableHeaderCell()
            If ci.colspan > 1 Then cellNH.ColumnSpan = ci.colspan
            If ci.rowspan > 1 Then cellNH.RowSpan = ci.rowspan
            cellNH.Controls.Add(ctl)
            cell = cellNH
        End If
    End Sub
    Function CountLeadingBlanks(str As String) As Integer
        Dim count As Integer = 0
        For Each ch In str
            If ch = " " Then
                count += 1
            Else
                Exit For
            End If
        Next
        Return count
    End Function
    Sub PopulateDropDownList(ByVal cbosortby As String, ByVal polje As String, ByVal ddl As DropDownList, ByVal sql As String, ByVal connectionstring As String, ByVal displaymember As String, ByVal valuemember As String)

        Try
            Dim b As New Base_IST_PPP
            Dim dt As New DataTable
            If cbosortby.Trim = "SORT" Then 'AWLS
                Dim n() As String = Session("nddl")
                Dim dsDDL As DataSet = Session("dsDDL")
                Dim ind As Integer = Array.IndexOf(n, polje)
                If ind >= 0 Then
                    dt = dsDDL.Tables(ind)
                End If
            Else
                Dim ds As DataSet = b.DajDS_IzUpita(sql, connectionstring, Session("Country"))
                dt = ds.Tables(0)
                Dim newrow As DataRow = dt.NewRow()     'bilo posle EndIF
                newrow(displaymember) = ""
                'newrow(valuemember) = "0"
                newrow(valuemember) = Nothing
                dt.Rows.InsertAt(newrow, 0)
            End If
            ddl.DataSource = dt
            ddl.DataTextField = displaymember ' The field to display
            ddl.DataValueField = valuemember ' The field value
            ddl.DataBind()

        Catch ex As Exception
            ' Handle exceptions
            Dim message As String = ex.ToString
        End Try
    End Sub

    Dim hF As String = ""
    Private Function CreateControlNavigation(ByVal ciN As ControlInfoNavigation, Optional index As Integer = 999) As Control
        Dim ctl As Control = Nothing

        'dodati listu navigacije u session
        Select Case ciN.Type
            Case "LinkButton"
                ctl = New LinkButton()
                CType(ctl, LinkButton).Text = ciN.text.ToString()
                CType(ctl, LinkButton).Attributes.Add("UseSubmitBehavior", "False")
                Me.AppendEvent(ctl, ciN.eventHandler)
            Case "TextBox"
            Case "Label", "VirtualField"
            Case Else
                Return Nothing
        End Select

        ctl.ID = ciN.ID
        If ciN.Type = "LinkButton" Then
            Dim liN As New HtmlGenericControl("li")
            liN.Controls.Add(ctl)
            li = liN
        End If

        Return ctl
    End Function
    Private Function CreateControlSave(ByVal ciN As ControlInfoSave) As Control
        Dim ctl As Control = Nothing

        Select Case ciN.Type
            Case "ButtonBack"
                ctl = New Button()
                CType(ctl, Button).Text = "🡰"
                CType(ctl, Button).ToolTip = "NAZAD"
                CType(ctl, Button).Attributes.Add("class", "btnSave")
                CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
                Me.AppendEvent(ctl, ciN.eventHandler)
            Case "ButtonGuide"
                ctl = New Button()
                CType(ctl, Button).Text = "🗎" '"📄"'"📁"
                CType(ctl, Button).ToolTip = "UPUTSTVA"
                CType(ctl, Button).Attributes.Add("class", "btnSave")
                CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
                Me.AppendEvent(ctl, ciN.eventHandler)
            Case "ButtonSave"
                ctl = New Button()
                CType(ctl, Button).Text = "🖫" '+ ciN.text.ToString()
                'CType(ctl, Button).ToolTip = "SAČUVAJ"
                CType(ctl, Button).ToolTip = b.SetLabel(Session("izabranJezik"), conn, "save", Session("Country"))
                'CType(ctl, Button).Font.Size=22 
                'CType(ctl, Button).Font.Bold=true
                'CType(ctl, Button).Forecolor=Color.Navy 
                CType(ctl, Button).Attributes.Add("class", "btnSave")
                CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
                Me.AppendEvent(ctl, ciN.eventHandler)
            Case "btnToggle"
                ctl = New Button()
                CType(ctl, Button).Text = If(IsCollapsed, "◻︎", "◼︎")
                CType(ctl, Button).ToolTip = Session("btnToggleText") 'btnToggle.Text
                CType(ctl, Button).Attributes.Add("class", "btnSave")
                CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
                Me.AppendEvent(ctl, ciN.eventHandler)
            Case "ButtonLK"
                ctl = New Button()
                CType(ctl, Button).Text = "🗎" '"📄"'"📁"
                'CType(ctl, Button).ToolTip = "LK" '+ ciN.text.ToString()
                CType(ctl, Button).ToolTip = b.SetLabel(Session("izabranJezik"), conn, "lk", Session("Country"))
                'CType(ctl, Button).Font.Size=22 
                'CType(ctl, Button).Font.Bold=true
                'CType(ctl, Button).Forecolor=Color.Navy 
                CType(ctl, Button).Attributes.Add("class", "btnSave")
                CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
                Me.AppendEvent(ctl, ciN.eventHandler)
            Case "Label"
                ctl = New Label()
                CType(ctl, Label).Text = ciN.text.ToString()
                CType(ctl, Label).Font.Size = 12
                CType(ctl, Label).Font.Bold = True
            Case "LabelResult"
                ctl = New Label()
                CType(ctl, Label).Text = ciN.text.ToString()
                CType(ctl, Label).Font.Size = 10
                CType(ctl, Label).Font.Bold = True
                CType(ctl, Label).ForeColor = Drawing.Color.Red
            'Case "PrintTable"
            '    ctl = New Button()
            '    CType(ctl, Button).Text = "🖨"
            '    CType(ctl, Button).ToolTip = "ŠTAMPAJ"
            '    CType(ctl, Button).Attributes.Add("class", "btnSave")
            '    CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
            '    Me.AppendEvent(ctl, ciN.eventHandler)
            Case "PrintTable"
                ctl = New Button()
                CType(ctl, Button).Text = "🖨"
                CType(ctl, Button).ToolTip = "ŠTAMPAJ"
                CType(ctl, Button).Attributes.Add("class", "btnSave")
                CType(ctl, Button).Attributes.Add("UseSubmitBehavior", "False")
                CType(ctl, Button).Attributes.Add("onclick", "generatePDF(); return false;")
                Me.AppendEvent(ctl, ciN.eventHandler)

            Case Else
                Return Nothing
        End Select

        ctl.ID = ciN.ID

        Dim cellN As New TableCell()
        cellN.Controls.Add(ctl)
        cell = cellN
        If ciN.Type = "LabelResult" Then
            cell.ColumnSpan = 2
        End If

        Return ctl

    End Function
    <System.Web.Services.WebMethod(EnableSession:=True),
     System.Web.Script.Services.ScriptMethod()>
    Public Shared Function GetSuggestions(ByVal prefixText As String, ByVal count As Integer, ByVal contextKey As String) As String()
        GetSuggestions = Nothing

        Dim arrayContextKey() As String = HttpContext.Current.Session("arrayContextKey")
        Dim arrayContextKeySQL() As String = HttpContext.Current.Session("arrayContextKeySQL")
        Dim arrayContextKeyDM() As String = HttpContext.Current.Session("arrayContextKeyDM")
        Dim arrayContextKeyFilter() As String = HttpContext.Current.Session("arrayContextKeyFilter")
        Dim arrayContextKeySortBy() As String = HttpContext.Current.Session("arrayContextKeySortBy")
        Dim country As String = HttpContext.Current.Session("Country")
        Dim sql As String = ""

        Dim tttt() As String = contextKey.Split("$")
        Dim konekcija As String = tttt(1)
        For i As Integer = 0 To arrayContextKey.GetUpperBound(0)
            If arrayContextKey(i) = tttt(0) Then
                Dim vredCir As String = konverzijaLatCir(prefixText)
                Dim vredLat As String = konverzijaCirLat(prefixText)
                Dim pom As String = "((" + arrayContextKeyDM(i) + " like N'%" & vredCir & "%')" & " OR " & "(" + arrayContextKeyDM(i) + " like N'%" & vredLat & "%'))"
                Dim ssort As String = arrayContextKeySortBy(i)
                If ssort = "''" Then ssort = " order by 2"
                If arrayContextKeyFilter(i) <> "''" Then
                    Dim pp() As String = arrayContextKeyFilter(i).Split("=")
                    Dim filter As String = ""
                    For m As Integer = 0 To pp.GetUpperBound(0)
                        If pp(m).Trim.ToUpper.IndexOf("D.") = 0 Then
                            Dim filtevrednost As String = HttpContext.Current.Session(pp(m).Substring(2))
                            filter = filter + filtevrednost + "="
                        Else
                            filter = filter + pp(m) + "="
                        End If
                    Next
                    filter = filter.TrimEnd("=")
                    sql = arrayContextKeySQL(i) + " WHERE 2=2 AND " & filter & " AND " & pom & ssort
                Else
                    sql = arrayContextKeySQL(i) + " WHERE 2=2 AND " & pom & ssort
                End If

                Return FetchData(prefixText, count, sql, contextKey, konekcija, country).ToArray()

                Exit For
            End If
        Next
    End Function
    Private Shared Function FetchData(ByVal prefixText As String, ByVal count As Integer, ByVal sql As String, ByVal contextKey As String, ByVal konekcija As String, country As String) As List(Of String)
        Dim suggestions As New List(Of String)()
        Dim b As New Base_IST_PPP
        Dim ds As DataSet = b.DajDS_IzUpita(sql, konekcija, country)
        For Each sdr As DataRow In ds.Tables(0).Rows
            'suggestions.Add(String.Format("{0}-{1}", sdr("displayMember"), sdr("valueMember")))
            suggestions.Add(String.Format("{0}", sdr("displayMember")))
        Next
        Return suggestions
    End Function

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim ch As CheckBox = CType(sender, CheckBox)
        Dim chID As String = CType(sender, CheckBox).ID
        Dim chTN As String = chID.Substring(3)


        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim chGroup As String = ""
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.ID = ch.ID Then
                chGroup = ci.CheckBoxGroup
                Exit For
            End If
        Next
        If chGroup.Trim <> "" Then
            Dim hiddenField As HiddenField = DirectCast(MyPanel.FindControl("hiddenField" + chGroup), HiddenField)
            Dim groupOrder As String = hiddenField.Value
            Call putValueInDSCHWithOrder(ch, ch.Checked, chGroup, groupOrder)
        Else
            Call putValueInDSCH(ch, ch.Checked)
        End If

        Call LeaveControl(chID)

    End Sub


    Private Sub RadioButtonList_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim rbl As RadioButtonList = CType(sender, RadioButtonList)
        Dim rbID As String = CType(sender, RadioButtonList).ID
        Dim rbTN As String = rbID.Substring(3)
        Call putValueInDSRB(rbl, rbl.SelectedValue.Trim)

        Call LeaveControl(rbID)

    End Sub


    Private Sub TextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim pp As TextBox = CType(sender, TextBox)
        Dim ppID As String = CType(sender, TextBox).ID
        Dim ppTN As String = ppID.Substring(3)
        Dim cbbox As Boolean = False

        If ppID.IndexOf("CB_") = 0 Then
            cbbox = True
            Dim ccode As String = getCode(ppID, pp.Text.Trim)
            Dim limitotlist As Boolean = True
            If limitotlist = True AndAlso ccode = "" Then   '**** checking limittolist  
                CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Text = "Izaberite vrednost iz liste." 'Please select a value from the list.
                CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Style("display") = "block"
                pp.Text = ""
                Page.SetFocus(pp)
                Exit Sub
            Else
                CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Text = ""
                CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Style("display") = "none"
                'resetobojPoljaUExecuteCheckDodajToolTip(ppID)
            End If
            AssignEvent("TP_" + ppTN, ccode.Trim)
            Call anulateDependantCB(ppID)
            Session(ppTN) = ccode   'treba filter = filter + HttpContext.Current.Session(pp(m).Substring(2)) + "="
            Session("filter") = Session("filter") + ppTN + ";"
            ''upisi polje
            If pp.Text.Trim = "" Then
                Call putValueInDSTBCB(pp, pp.Text.Trim)
            End If
            ' Call putValueInDSTBCB(pp, pp.Text.Trim) not need here because it will try to write display member
        End If

        If cbbox = False Then
            If Not pp Is Nothing Then
                Dim vvalue As String = pp.Text
                Dim vv As String = executeCheck(ppID, vvalue) 'not needed for checkBox (****only checked is limittolist)
                If vv.Trim <> "" Then
                    'CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = vv
                    CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Text = vv
                    CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Style("display") = "block"
                    'oboji polja koja ne ispunjavaju uslov min max int itd...
                    obojPoljaUExecuteCheckDodajTooltip(ppID, vv)
                    pp.Text = ""
                    'Page.SetFocus(pp)
                    'dodao marko jer moze da prodje dalje sa pogresnom vrednoscu
                    Call putValueInDSTBCB(pp, pp.Text.Trim)
                    Exit Sub
                End If

                ''upisi polje
                Call putValueInDSTBCB(pp, pp.Text.Trim)
                'CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = ""
                CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Text = ""
                CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Style("display") = "none"
                resetobojPoljaUExecuteCheckDodajToolTip(ppID)
            End If
        End If

        Call LeaveControl(ppID)

    End Sub

    Sub LeaveControl(ByVal ppID As String)
        Call getVFNPK(ppID)   'sracunajFP
        'CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = ""
        CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Text = ""
        CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Style("display") = "none"
        resetobojPoljaUExecuteCheckDodajToolTip(ppID)

        'REDOSLED!!!!
        Call executeAssign(ppID)
        Call executeEnabled(ppID)
        Call executeVisible(ppID)
        Call executeSkip(ppID)

        Dim dk() As String = Session("dk")
        For i As Integer = 0 To dk.GetUpperBound(0)
            If dk(i).Trim.ToUpper = ppID.Trim.ToUpper.Substring(3) Then
                Call ValidateSave(True)
                Exit For
            End If
        Next

    End Sub

    Sub populateDependantDDL(ByVal ppID As String)
        Dim ppTN As String = ppID.Substring(3)
        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim CBOFilterBy As String = "''"
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.CBOFilterBy <> "''" AndAlso ci.CBOFilterBy <> "" Then
                If (ci.CBOFilterBy.Trim.ToUpper.Substring(0, 2) = "D." AndAlso ci.CBOFilterBy.Substring(2).Trim.ToUpper = ppTN.Trim.ToUpper) OrElse
                   (ci.CBOFilterBy.Trim.ToUpper.Substring(0, 2) <> "D." AndAlso ci.CBOFilterBy.Trim.ToUpper = ppTN.Trim.ToUpper) Then
                    Dim ddl As DropDownList = CType(MyPanel.FindControl(ci.ID), DropDownList)
                    Call PopulateDependantDropDownList(ddl, ci.DBConnectionString)
                    AssignEvent("DL_" + ci.ID.Substring(3), "")
                    Call anulateDependantDDL(ci.ID)
                End If
            End If
        Next
    End Sub
    'comment for marko to make comments in russian
    Sub PopulateDependantDropDownList(ByVal ddl As DropDownList, ByVal connectionstring As String)

        Dim arrayContextKey() As String = Session("arrayContextKey")
        Dim arrayContextKeySQL() As String = Session("arrayContextKeySQL")
        Dim arrayContextKeyDM() As String = Session("arrayContextKeyDM")
        Dim arrayContextKeyFilter() As String = Session("arrayContextKeyFilter")
        Dim arrayContextKeySortBy() As String = Session("arrayContextKeySortBy")
        Dim sql As String = ""
        For i As Integer = 0 To arrayContextKey.GetUpperBound(0)
            If arrayContextKey(i) = ddl.ID Then
                Dim ssort As String = arrayContextKeySortBy(i)
                If ssort = "''" Then ssort = " order by 2"

                Dim pom As String = arrayContextKeyFilter(i).Trim.ToUpper
                pom = pom.Replace(" AND ", " $ ")
                Dim pp1() As String = pom.Split("$")
                Dim filter As String = ""

                For m As Integer = 0 To pp1.GetUpperBound(0)
                    Dim pp() As String = pp1(m).Split("=")
                    Dim filterP As String = ""
                    For k As Integer = 0 To pp.GetUpperBound(0)
                        If pp(k).Trim.ToUpper.IndexOf("D.") = 0 Then
                            Dim filtevrednost As String = Session(pp(k).Substring(2))
                            If filtevrednost Is Nothing OrElse filtevrednost = "" Then
                                filtevrednost = t.SE(pp(k).Trim.Substring(2), MyPanel)
                            End If
                            If Not filtevrednost Is Nothing AndAlso filtevrednost <> "" Then
                                filter = filter + "'" + filtevrednost + "'="
                            Else
                                filter = "2=3"
                            End If
                        Else
                            If pp(k) = "''" Then
                                filterP = filterP + "="
                            Else
                                filterP = filterP + pp(k) + "="
                            End If

                        End If
                    Next
                    filter = filter + filterP.TrimEnd("=") + " AND "

                Next
                filter = filter.Replace("''", "'")
                filter = filter + "2=2"

                sql = arrayContextKeySQL(i) + " WHERE 2=2 AND " & filter & ssort
                If sql.Contains(" AND  AND ") Then
                    sql = sql.Replace(" AND  AND ", " AND ")
                End If
                Dim b As New Base_IST_PPP
                Dim ds As DataSet = b.DajDS_IzUpita(sql, connectionstring, Session("Country"))
                Dim dt As DataTable = ds.Tables(0)
                Dim newrow As DataRow = dt.NewRow()
                newrow("DisplayMember") = ""
                'newrow("ValueMember") = "0"
                newrow("ValueMember") = DBNull.Value
                dt.Rows.InsertAt(newrow, 0)
                ddl.DataSource = dt
                ddl.DataTextField = "DisplayMember" ' The field to display
                ddl.DataValueField = "ValueMember" ' The field value
                ddl.Items().Insert(0, "")
                ddl.DataBind()
                If ddl.Items.Count = 1 Then
                    ddl.Enabled = False
                ElseIf ddl.Items.Count = 2 AndAlso ddl.Items(0).Value = "" Then
                    ddl.Enabled = False
                End If
                ddl.SelectedIndex = 1
                Exit For
            End If
        Next
    End Sub

    Sub anulateDependantDDL(ByVal ppID As String)
        Dim ppTN As String = ppID.Substring(3)
        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim CBOFilterBy As String = "''"
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.CBOFilterBy <> "''" AndAlso ci.CBOFilterBy <> "" Then
                If (ci.CBOFilterBy.Trim.ToUpper.Substring(0, 2) = "D." AndAlso ci.CBOFilterBy.Substring(2).Trim.ToUpper = ppTN.Trim.ToUpper) OrElse
                   (ci.CBOFilterBy.Trim.ToUpper.Substring(0, 2) <> "D." AndAlso ci.CBOFilterBy.Trim.ToUpper = ppTN.Trim.ToUpper) Then
                    AssignEvent("DL_" + ci.ID.Substring(3), "")
                    'call anulateDependantDDL(ci.ID)
                End If
            End If
        Next
    End Sub
    Sub anulateDependantCB(ByVal ppID As String)
        Dim ppTN As String = ppID.Substring(3)
        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1
        Dim CBOFilterBy As String = "''"
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If ci.CBOFilterBy <> "''" AndAlso ci.CBOFilterBy <> "" Then
                If (ci.CBOFilterBy.Trim.ToUpper.Substring(0, 2) = "D." AndAlso ci.CBOFilterBy.Substring(2).Trim.ToUpper = ppTN.Trim.ToUpper) OrElse
                   (ci.CBOFilterBy.Trim.ToUpper.Substring(0, 2) <> "D." AndAlso ci.CBOFilterBy.Trim.ToUpper = ppTN.Trim.ToUpper) Then
                    AssignEvent("CB_" + ci.ID.Substring(3), "")
                    AssignEvent("TP_" + ci.ID.Substring(3), "")
                End If
            End If
        Next
    End Sub
    Function getCode(ByVal ppID As String, ByVal DisplayMember As String) As String
        getCode = ""
        Dim arrayContextKey() As String = HttpContext.Current.Session("arrayContextKey")
        Dim arrayContextKeySQL() As String = HttpContext.Current.Session("arrayContextKeySQL")
        Dim arrayContextKeyDM() As String = HttpContext.Current.Session("arrayContextKeyDM")
        Dim arrayContextKeyVM() As String = HttpContext.Current.Session("arrayContextKeyDM")
        Dim arrayContextKeyFilter() As String = HttpContext.Current.Session("arrayContextKeyFilter")
        Dim sql As String = ""

        For i As Integer = 0 To arrayContextKey.GetUpperBound(0)
            If arrayContextKey(i) = ppID Then
                sql = arrayContextKeySQL(i) + " WHERE 2=2 AND  " + arrayContextKeyVM(i) + "=N'" + DisplayMember + "'"
                Dim dt As New DataSet
                dt = b.DajDS_IzUpita(sql, Me.DBConnectionString.Text, Session("Country"))
                If dt.Tables(0).Rows.Count > 0 Then
                    getCode = dt.Tables(0).Rows(0).Item("ValueMember").ToString.Trim
                Else
                    getCode = ""
                End If

                Exit For
            End If
        Next
    End Function
    Sub putValueInDS(ByVal ppTN As String, ByVal vvalue As String)
        vvalue = vvalue.Replace(ChrW(&H200B), "").Trim
        Dim dsDB As DataSet = Session("dsDB")

        If vvalue = "" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = DBNull.Value
        Else
            dsDB.Tables(0).Rows(0).Item(ppTN) = vvalue
        End If

        dsDB.AcceptChanges()
        Session("dsDB") = dsDB
    End Sub
    Sub putValueInDSTBCB(ByVal pp As TextBox, ByVal vvalue As String)
        vvalue = vvalue.Replace(ChrW(&H200B), "").Trim
        Dim dsDB As DataSet = Session("dsDB")
        Dim ppID As String = CType(pp, TextBox).ID
        Dim ppTN As String = ppID.Substring(3)

        'If vvalue = "" Then
        '    dsDB.Tables(0).Rows(0).Item(ppTN) = DBNull.Value
        'Else
        '    If dsDB.Tables(0).Columns(ppTN).DataType.Name = "Decimal" OrElse dsDB.Tables(0).Columns(ppTN).DataType.Name = "Double" OrElse dsDB.Tables(0).Columns(ppTN).DataType.Name = "Int16" OrElse dsDB.Tables(0).Columns(ppTN).DataType.Name = "Int64" OrElse dsDB.Tables(0).Columns(ppTN).DataType.Name = "Single" OrElse dsDB.Tables(0).Columns(ppTN).DataType.Name = "Int32" Then
        '        vvalue = vvalue.Replace(",", ".")
        '    End If
        '    dsDB.Tables(0).Rows(0).Item(ppTN) = vvalue
        'End If



        Dim colType As Type = dsDB.Tables(0).Columns(ppTN).DataType

        If Not dsDB.Tables(0).Columns.Contains(ppTN) Then Exit Sub

        If String.IsNullOrWhiteSpace(vvalue) Then
            dsDB.Tables(0).Rows(0)(ppTN) = DBNull.Value
        Else
            vvalue = vvalue.Replace(",", ".")

            Select Case colType
                Case GetType(Int16), GetType(Int32), GetType(Int64)
                    Dim intValue As Integer
                    If Integer.TryParse(vvalue.Split("."c)(0), intValue) Then
                        dsDB.Tables(0).Rows(0)(ppTN) = intValue
                    Else
                        dsDB.Tables(0).Rows(0)(ppTN) = DBNull.Value
                    End If

                Case GetType(Decimal), GetType(Double), GetType(Single)
                    Dim decValue As Decimal
                    If Decimal.TryParse(vvalue, NumberStyles.Any,
                                CultureInfo.InvariantCulture, decValue) Then
                        dsDB.Tables(0).Rows(0)(ppTN) = decValue
                    Else
                        dsDB.Tables(0).Rows(0)(ppTN) = DBNull.Value
                    End If

                Case Else
                    dsDB.Tables(0).Rows(0)(ppTN) = vvalue
            End Select
        End If




        dsDB.AcceptChanges()
        Session("dsDB") = dsDB
    End Sub

    Sub putValueInDSDDL(ByVal ddl As DropDownList, ByVal vvalue As String)
        vvalue = vvalue.Replace(ChrW(&H200B), "").Trim

        Dim dsDB As DataSet = Session("dsDB")
        Dim ppID As String = CType(ddl, DropDownList).ID
        Dim ppTN As String = ppID.Substring(3)
        If vvalue = "" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = DBNull.Value
        Else
            dsDB.Tables(0).Rows(0).Item(ppTN) = vvalue
        End If

        dsDB.AcceptChanges()
        Session("dsDB") = dsDB
    End Sub
    Sub putValueInDSRB(ByVal rbl As RadioButtonList, ByVal vvalue As String)
        vvalue = vvalue.Replace(ChrW(&H200B), "").Trim
        Dim dsDB As DataSet = Session("dsDB")
        Dim ppID As String = CType(rbl, RadioButtonList).ID
        Dim ppTN As String = ppID.Substring(3)

        If vvalue = "" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = DBNull.Value
        Else
            dsDB.Tables(0).Rows(0).Item(ppTN) = vvalue
        End If

        dsDB.AcceptChanges()
        Session("dsDB") = dsDB
    End Sub
    Sub putValueInDSCHWithOrder(ByVal chl As CheckBox, ByVal vvalue As String, ByVal chGroup As String, ByVal groupOrder As String)
        vvalue = vvalue.Replace(ChrW(&H200B), "").Trim
        Dim dsDB As DataSet = Session("dsDB")
        Dim ppID As String = CType(chl, CheckBox).ID
        Dim ppTN As String = ppID.Substring(3)

        Dim bb() As String = groupOrder.Split(",")
        Dim ind As Integer = Array.IndexOf(bb, ppTN)

        If vvalue = "" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = DBNull.Value
        ElseIf vvalue = "True" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = ind + 1
        ElseIf vvalue = "False" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = 0
        End If

        dsDB.AcceptChanges()
        Session("dsDB") = dsDB

    End Sub
    Sub putValueInDSCH(ByVal chl As CheckBox, ByVal vvalue As String)
        vvalue = vvalue.Replace(ChrW(&H200B), "").Trim
        Dim dsDB As DataSet = Session("dsDB")
        Dim ppID As String = CType(chl, CheckBox).ID
        Dim ppTN As String = ppID.Substring(3)

        If vvalue = "" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = DBNull.Value
        ElseIf vvalue = "True" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = 1
        ElseIf vvalue = "False" Then
            dsDB.Tables(0).Rows(0).Item(ppTN) = 0
        End If

        dsDB.AcceptChanges()
        Session("dsDB") = dsDB

    End Sub
    'Function executeCheck(ByVal ppID As String, ByVal vvalue As String) As String
    '    vvalue = vvalue.Replace(ChrW(&H200B), "").Trim

    '    Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
    '    Dim br As Integer = -1
    '    executeCheck = ""
    '    For i As Integer = 0 To al.Count - 1
    '        Dim ci As ControlInfo = al(i)
    '        If ci.ID = ppID Then
    '            br = i
    '            Exit For
    '        End If
    '    Next

    '    Dim ci2 As ControlInfo = DirectCast(al(br), ControlInfo)

    '    If ci2.mnlength <> 0 AndAlso Len(vvalue.Trim) < ci2.mnlength Then
    '        executeCheck = "Minimalna dužina je " + ci2.mnlength.ToString.Trim + "" '***IZMENA*** Treba srediti po jezicima / Mn lenth is 
    '        Exit Function
    '    End If

    '    If vvalue = "" Then Exit Function

    '    If IsNumeric(vvalue) Then
    '        If ci2.mmin <> -9999999999 AndAlso CInt(vvalue) < ci2.mmin Then
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "minValue") + ci2.mmin.ToString.Trim '"Min is " + ci2.mmin.ToString.Trim  
    '            Exit Function
    '        End If
    '        If ci2.mmax <> 9999999999 AndAlso CInt(vvalue) > ci2.mmax Then
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "maxValue") + ci2.mmax.ToString.Trim '"Max is " + ci2.mmax.ToString.Trim  
    '            Exit Function
    '        End If
    '    End If

    '    If ci2.mnlength <> 0 AndAlso Len(vvalue.Trim) < ci2.mnlength Then
    '        executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "mnLenValue") + ci2.mnlength.ToString.Trim + "" '"Mn lenth is " + ci2.mnlength.ToString.Trim + ""  
    '        Exit Function
    '    End If

    '    If ci2.yyes = "numeric" Then
    '        vvalue = vvalue.Replace(",", ".")
    '        If IsNumeric(vvalue) = False Then
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyNum") '"Only numbers are allowed and . is allowed! "
    '            Exit Function
    '        End If
    '    End If

    '    If ci2.yyes = "numericInt" Then
    '        If IsNumeric(vvalue) = True Then
    '            Dim ii As Integer = CInt(vvalue)   'CLng
    '            If vvalue <> CStr(ii).Trim Then
    '                executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyInt") '"Only integer numbers are allowed!"
    '                Exit Function
    '            End If
    '        Else
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyInt") '"Only integer numbers are allowed!"
    '            Exit Function
    '        End If
    '    End If

    '    If ci2.yyes = "numericBig" Then
    '        If IsNumeric(vvalue) = True Then
    '            Dim bigInt As BigInteger = BigInteger.Parse(vvalue.Trim())
    '            If vvalue.Trim() <> bigInt.ToString() Then
    '                executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyLong") '"Only long numbers are allowed!"
    '                Exit Function
    '            End If
    '        Else
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyInt") '"Only integer numbers are allowed!"
    '            Exit Function
    '        End If
    '    End If

    '    If ci2.yyes = "numericDec" Then
    '        vvalue = vvalue.Replace(",", ".")
    '        If IsNumeric(vvalue) = True Then
    '            Dim ii As Decimal = CDec(vvalue)
    '            If vvalue <> CStr(ii).Trim Then
    '                executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyNum") '"Only numbers are allowed and . is allowed! "
    '                Exit Function
    '            End If
    '        Else
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyInt") '"Only integer numbers are allowed!"
    '            Exit Function
    '        End If
    '    End If
    '    If ci2.yyes = "alphanumeric" Then
    '        Dim ok As Boolean = isAlphaNumeric(vvalue.ToUpper)

    '        If ok = False Then
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "englishLetters") '"Only English letters and numbers are allowed!" 
    '            Exit Function
    '        End If
    '    End If
    '    Dim cinno2 As String = "NoNo"

    '    If ci2.nno <> "NoNo" AndAlso ci2.nno.Trim <> "" Then
    '        Dim pp() As String = ci2.nno.ToString.Trim.Split(",")
    '        For i As Integer = 0 To pp.GetUpperBound(0)
    '            If pp(i).Trim = "" Then
    '                cinno2 = ""
    '            Else
    '                If pp(i).Trim = vvalue.Trim Then
    '                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "notAllowed") '"Value not allowed!"
    '                    Exit Function
    '                End If
    '            End If
    '        Next
    '    End If

    '    If ci2.nno <> "NoNo" AndAlso (ci2.nno.Trim = "" OrElse cinno2 = "") AndAlso vvalue.Trim = "" Then
    '        executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "requiredField") '"* niste popunili obavezno polje" 
    '        Exit Function
    '    End If

    '    Dim allowed As Boolean = False
    '    Dim ci2yyes As String = ci2.yyes.Trim.ToUpper.Replace("NUMERIC", "").Replace("INT", "").Replace("DEC", "").Replace("BIG", "")
    '    If ci2yyes <> "" Then
    '        Dim pp() As String = ci2yyes.ToString.Trim.Split(",")
    '        Dim bbb As String = ""
    '        For i As Integer = 0 To pp.GetUpperBound(0)
    '            If pp(i).Trim = vvalue.Trim Then
    '                allowed = True
    '                Exit For
    '            End If
    '        Next
    '        If allowed = False Then
    '            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlySpecValue") + ci2yyes.Trim '"Value not allowed. Only values " + ci2yyes.Trim + " are allowed"
    '            Exit Function
    '        End If
    '    End If
    'End Function

    Function executeCheck(ByVal ppID As String, ByVal vvalue As String) As String

        executeCheck = ""

        vvalue = If(vvalue, "").Replace(ChrW(&H200B), "").Trim()

        Dim al As ArrayList = CType(Session("DynamicControls"), ArrayList)
        Dim br As Integer = -1

        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = CType(al(i), ControlInfo)
            If ci.ID = ppID Then
                br = i
                Exit For
            End If
        Next

        If br = -1 Then Exit Function

        Dim ci2 As ControlInfo = CType(al(br), ControlInfo)

        ' ===== минимальная длина =====
        If ci2.mnlength > 0 AndAlso vvalue.Length < ci2.mnlength Then
            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "mnLenValue") & ci2.mnlength
            Exit Function
        End If

        ' ===== пустое значение =====
        If vvalue = "" Then Exit Function

        ' ===== min / max (ТОЛЬКО ЧИСЛА) =====
        If ci2.mmin <> -9999999999 OrElse ci2.mmax <> 9999999999 Then
            Dim decVal As Decimal
            If Decimal.TryParse(vvalue.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, decVal) Then
                If ci2.mmin <> -9999999999 AndAlso decVal < ci2.mmin Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "minValue") & ci2.mmin
                    Exit Function
                End If
                If ci2.mmax <> 9999999999 AndAlso decVal > ci2.mmax Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "maxValue") & ci2.mmax
                    Exit Function
                End If
            End If
        End If

        ' ===== ТИП ДАННЫХ =====
        Select Case ci2.yyes

            Case "numeric"
                Dim decVal As Decimal
                If Not Decimal.TryParse(vvalue.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, decVal) Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyNum")
                    Exit Function
                End If

            Case "numericInt"
                Dim intVal As Integer
                If Not Integer.TryParse(vvalue, intVal) Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyInt")
                    Exit Function
                End If
                vvalue = intVal.ToString()

            'Case "numericDec"
            '    Dim decVal As Decimal
            '    If Not Decimal.TryParse(vvalue.Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, decVal) Then
            '        executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyNum")
            '        Exit Function
            '    End If
            '    vvalue = decVal.ToString(CultureInfo.InvariantCulture)
            Case "numericDec"
                Dim decVal As Decimal

                ' Если пустое значение, ничего не делаем
                If String.IsNullOrWhiteSpace(vvalue) Then Exit Select

                ' Если есть буквы – ошибка
                If Regex.IsMatch(vvalue, "[A-Za-zА-Яа-я]") Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyNum")
                    Exit Function
                End If

                ' Заменяем запятую на точку
                Dim tempVal As String = vvalue.Replace(",", ".")

                ' Проверяем, можно ли преобразовать в Decimal
                If Not Decimal.TryParse(tempVal, NumberStyles.Any, CultureInfo.InvariantCulture, decVal) Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyNum")
                    Exit Function
                End If

                ' Преобразованное значение сохраняем с точкой
                vvalue = decVal.ToString(CultureInfo.InvariantCulture)




            Case "numericBig"
                Dim bigVal As BigInteger
                If Not BigInteger.TryParse(vvalue, bigVal) Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlyLong")
                    Exit Function
                End If
                vvalue = bigVal.ToString()

            Case "alphanumeric"
                If Not isAlphaNumeric(vvalue.ToUpperInvariant()) Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "englishLetters")
                    Exit Function
                End If

        End Select

        ' ===== запрещённые значения =====
        If ci2.nno <> "NoNo" AndAlso ci2.nno.Trim <> "" Then
            For Each s As String In ci2.nno.Split(","c)
                If s.Trim <> "" AndAlso s.Trim.Equals(vvalue, StringComparison.OrdinalIgnoreCase) Then
                    executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "notAllowed")
                    Exit Function
                End If
            Next
        End If

        ' ===== обязательное поле =====
        If ci2.nno <> "NoNo" AndAlso ci2.nno.Trim = "" AndAlso vvalue = "" Then
            executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "requiredField")
            Exit Function
        End If

        ' ===== разрешённые значения =====
        Dim spec As String = ci2.yyes.ToUpper().
        Replace("NUMERIC", "").
        Replace("INT", "").
        Replace("DEC", "").
        Replace("BIG", "").
        Trim()

        If spec <> "" Then
            Dim allowed As Boolean = False
            For Each s As String In spec.Split(","c)
                If s.Trim = vvalue Then
                    allowed = True
                    Exit For
                End If
            Next

            If Not allowed Then
                executeCheck = b.SetError(Session("dsErrors"), Session("izabranJezik"), "onlySpecValue") & spec
                Exit Function
            End If
        End If

    End Function



    Function isAlphaNumeric(ByVal tekst As String) As Boolean

        isAlphaNumeric = True

        Dim ValidChars As String = "0123456789ABDCEFGHIJKLMNOPQRSTUVWXYZ"
        'ŠĐČĆŽabdcefghijklmnopqrstuvwxyzšđčćžАБВГДЂЕЖЗИЈКЛЉМНЊОПРСТЋУФХЦЧЏШабвгдђежзијклљмнњопрстћуфхцчџш-;,.:/()ќѓЌЃ' "
        '        ValidChars = ValidChars + "AaĂăÂâBbCcDdĐđEeÊêGgHhIiKkLlMmNnOoÔôƠơPpQqRrSsTtUuƯưVvXxYy"
        '        ValidChars = ValidChars + "AaĂăÂâEeÊêIiOoÔôƠơUuƯưYyÁáẮắẤấÉéẾếÍíÓóỐốỚớÚúỨứÝýÀàẰằẦầÈèỀềÌìÒòỒồỜờÙùỪừỲỳẢảẲẳẨẩẺẻỂểỈỉỎỏỔổỞởỦủỬửỶỷÃãẴẵẪẫẼẽỄễĨĩÕõỖỗỠỡŨũỮữỸỹẠạẶặẬậẸẹỆệỊịỌọỘộỢợỤụỰựỴỵ"
        For i As Integer = 1 To Len(tekst)
            If InStr(ValidChars, Mid(tekst, i, 1)) = 0 Then
                isAlphaNumeric = False
                Exit For
            End If
        Next

    End Function
    Private Structure ControlInfoSave
        Public ID As String
        Public Type As String
        Public tab As String
        Public nadtab As String
        Public text As String
        Public eventHandler As String
        Public connectionstring As String
        Public DG As String
        Public parentPK As String
    End Structure

    Sub CreateSave()
        Dim ciN As ControlInfoSave
        Dim dsISTTabele As DataSet
        dsISTTabele = Session("dsISTTabele")
        Dim maintable As String = Session("maintable").ToString.Trim.ToUpper
        Dim type As String = ""
        Dim tab As String = ""
        Dim nadtab As String = ""
        Dim glavna As String = ""
        Dim ttext As String = ""
        Dim connectionstring As String = ""
        Dim childPK As Integer = 0 : Dim parentPK As Integer = 0
        Dim tableN As New Table()
        table = tableN
        table.ID = "TableSave"
        Dim DG As String = ""
        Dim mainTableExistsinDS As Boolean = False
        Dim rbrCell As Integer = 0

        For i As Integer = 0 To dsISTTabele.Tables(0).Rows.Count - 1
            Dim red As DataRow = dsISTTabele.Tables(0).Rows(i)
            DG = red.Item("DG").ToString.Trim.ToUpper
            tab = red.Item("tabela").ToString.Trim.ToUpper
            childPK = red.Item("childPK")
            parentPK = red.Item("parentPK")
            glavna = red.Item("glavna").ToString.Trim.ToUpper
            nadtab = red.Item("nadtabela").ToString.Trim.ToUpper
            ttext = red.Item("opis").ToString.Trim
            connectionstring = red.Item("connectionstring").ToString.Trim

            If DG = "D" Then
                If childPK > parentPK Then
                    DG = "D"
                    ttext = "...." + ttext.Trim
                Else '1-1
                    DG = "G"
                    ttext = ttext.Trim
                    glavna = tab
                    'nadtab = ""
                    parentPK = 0
                End If
            End If


            If tab = maintable Then
                Dim rowN As New TableRow()
                row = rowN

                ID = "bb_" + red.Item("tabela").ToString.Trim
                ciN = PersistControlSave(ID, "ButtonBack", tab, nadtab, "back " + ttext, "ClickBack", "", "", "")
                CreateControlSave(ciN)
                row.Cells.Add(cell)

                ID = "LB_Title" + red.Item("tabela").ToString.Trim
                ciN = PersistControlSave(ID, "Label", tab, nadtab, ttext, "", "", "", "")
                CreateControlSave(ciN)
                row.Cells.Add(cell)

                ID = "SB_" + red.Item("tabela").ToString.Trim
                ciN = PersistControlSave(ID, "ButtonSave", tab, nadtab, "Save " + ttext, "ClickSave", connectionstring, DG, parentPK)
                CreateControlSave(ciN)
                row.Cells.Add(cell)

                ID = "SE_" + red.Item("tabela").ToString.Trim
                Session.Add("btnToggleID", ID)
                ciN = PersistControlSave(ID, "btnToggle", tab, nadtab, "Errors " + ttext, "ClickShowErrors", "", "", "")
                CreateControlSave(ciN)
                row.Cells.Add(cell)

                ID = "LK_" + red.Item("tabela").ToString.Trim
                ciN = PersistControlSave(ID, "ButtonLK", tab, nadtab, "LK " + ttext, "ClickLK", connectionstring, DG, parentPK)
                CreateControlSave(ciN)
                row.Cells.Add(cell)

                'ID = "PT_" + red.Item("tabela").ToString.Trim
                'ciN = PersistControlSave(ID, "PrintTable", tab, nadtab, "Print " + ttext, "ClickPrint", "", "", "")
                'CreateControlSave(ciN)
                'row.Cells.Add(cell)

                'ID = "BG_" + red.Item("tabela").ToString.Trim
                'ciN = PersistControlSave(ID, "ButtonGuide", tab, nadtab, "Guide " + ttext, "ClickGuide", "", "", "")
                'CreateControlSave(ciN)
                'row.Cells.Add(cell)

                Session("NumberOfButtonsPanelSave") = row.Cells.Count

                table.Rows.Add(row)
                row = Nothing
                cell = Nothing
                Exit For
            End If
        Next

        Dim rowN2 As New TableRow()
        row = rowN2
        ID = "lblResult"
        ciN = PersistControlSave(ID, "LabelResult", maintable, "", "", "", "", "", "")
        CreateControlSave(ciN)
        row.Cells.Add(cell)
        cell.ColumnSpan = Session("NumberOfButtonsPanelSave")
        table.Rows.Add(row)

        Dim rowN3 As New TableRow()
        row = rowN3
        ID = "lblExecuteErrors"
        ciN = PersistControlSave(ID, "LabelResult", maintable, "", "", "", "", "", "")
        CreateControlSave(ciN)
        row.Cells.Add(cell)
        cell.ColumnSpan = Session("NumberOfButtonsPanelSave")
        table.Rows.Add(row)
        row = Nothing
        cell = Nothing

        PanelSave.Controls.Add(table)
        dsISTTabele = Nothing
        table = Nothing

    End Sub

    Private Function PersistControlSave(ByVal id As String, ByVal type As String, ByVal tab As String, ByVal nadtab As String, ttext As String, ByVal eventHandler As String, ByVal connectionstring As String, ByVal DG As String, ByVal parentPK As String) As ControlInfoSave
        Dim ciS As New ControlInfoSave
        ciS.ID = id
        ciS.Type = type
        ciS.tab = tab
        ciS.nadtab = nadtab
        ciS.text = ttext
        ciS.eventHandler = eventHandler
        ciS.connectionstring = connectionstring
        ciS.DG = DG
        ciS.parentPK = parentPK

        Dim alN As ArrayList = CType(Me.Session("DynamicControlsSave"), ArrayList)
        If alN Is Nothing Then
            alN = New ArrayList()
        End If

        alN.Add(ciS)
        Me.Session("DynamicControlsSave") = alN

        Return ciS
    End Function

    Private Structure ControlInfoNavigation
        Public ID As String
        Public Type As String
        Public tab As String
        Public nadtab As String
        Public text As String
        Public eventHandler As String
        Public connectionstring As String
    End Structure
    Dim ul As New HtmlGenericControl("ul")
    Dim li As New HtmlGenericControl("li")
    Sub CreateNavigation()
        hF = ""
        Dim ciN As ControlInfoNavigation
        Dim dsISTTabele As DataSet
        dsISTTabele = Session("dsISTTabele")

        Dim type As String = "LinkButton"
        Dim tab As String = ""
        Dim nadtab As String = ""
        Dim ttext As String = ""
        Dim eventHandler As String = "ClickNavigation"
        Dim connectionstring As String = ""
        Dim childPK As Integer = 0 : Dim parentPK As Integer = 0
        Dim DG As String = "" : Dim glavna As String = ""
        Dim depth As Integer = 0
        Dim ulN As New HtmlGenericControl("ul")
        ul = ulN
        For i As Integer = 0 To dsISTTabele.Tables(0).Rows.Count - 1
            Dim red As DataRow = dsISTTabele.Tables(0).Rows(i)
            childPK = red.Item("childPK")
            parentPK = red.Item("parentPK")
            DG = red.Item("dg").ToString.Trim
            depth = red.Item("depth")
            tab = red.Item("tabela").ToString.Trim
            nadtab = red.Item("nadtabela").ToString.Trim
            glavna = red.Item("glavna").ToString.Trim
            ttext = red.Item("opis").ToString.Trim
            connectionstring = red.Item("connectionstring").ToString.Trim
            ID = "NB_" + red.Item("tabela").ToString.Trim   'navigation button
            If DG = "D" Then
                If childPK > parentPK Then
                    'DG = "D"
                    'ttext = "...." + ttext.Trim 'dodati depth
                Else '1-1 ako ne postoji kao GridView

                    Dim dsIST As DataSet
                    dsIST = Session("dsIST")
                    Dim datarowsGrid As DataRow() = dsIST.Tables(0).Select("pp2='GridView' and izraz='" + tab.Trim + "'")
                    If datarowsGrid.Count = 0 Then
                        DG = "G"
                        ttext = ttext.Trim
                        glavna = tab
                        nadtab = ""
                        parentPK = 0
                    End If
                End If
            End If

            If DG = "G" Then
                ciN = PersistControlNavigation(ID, type, tab, nadtab, ttext, eventHandler, connectionstring)
                CreateControlNavigation(ciN, i)
                ul.Controls.Add(li)
            End If
            Dim dsDDL As DataSet
            dsDDL = Session("dsDDL")
            Dim nddl() As String
            nddl = Session("nddl")
        Next

        PlaceHolderNav.Controls.Add(ul)
        dsISTTabele = Nothing
        ul = Nothing
        li = Nothing

    End Sub

    Private Function PersistControlNavigation(ByVal id As String, ByVal type As String, ByVal tab As String, ByVal nadtab As String, ttext As String, ByVal eventHandler As String, ByVal connectionstring As String) As ControlInfoNavigation
        Dim ciN As New ControlInfoNavigation
        ciN.ID = id
        ciN.Type = type
        ciN.tab = tab
        ciN.nadtab = nadtab
        ciN.text = ttext
        ciN.eventHandler = eventHandler
        ciN.connectionstring = connectionstring

        Dim alN As ArrayList = CType(Me.Session("DynamicControlsNavigation"), ArrayList)
        If alN Is Nothing Then
            alN = New ArrayList()
        End If

        alN.Add(ciN)
        Me.Session("DynamicControlsNavigation") = alN

        Return ciN
    End Function

    Sub CreatePage(Optional podtabela As Boolean = False, Optional gridadd As String = "")
        Dim ci As ControlInfo
        'textbox
        Dim dsIST As DataSet
        dsIST = Session("dsIST")

        Dim dsDDL As DataSet
        dsDDL = Session("dsDDL")
        Dim nddl() As String
        nddl = Session("nddl")

        'istpolja
        Dim plleft As Integer = 20 'odakle krecem
        Dim lleft As Integer = 0
        Dim wwidth As Integer = 100
        Dim hheight As Integer = 22
        Dim ttext As String = ""
        Dim rreadOnly As Boolean = True
        Dim vvisible As Boolean = True
        Dim pttop As Integer = 100 'odakle krecem
        Dim ttop As Integer  'odakle krecem
        Dim ottop As Integer = -10  'originalan
        Dim zzindex As String = "1"
        Dim mmultiline As Boolean = False
        Dim sskipif As String = ""
        Dim sskipto As String = ""
        Dim sstopif As String = ""
        Dim sstopmsg As String = ""
        Dim aassignif As String = ""
        Dim aassignto As String = ""
        Dim aassignwhat As String = ""
        Dim sskippedenabledfalse As Boolean = False
        Dim sskippedsetempty As Boolean = False
        Dim eEnabledTrue As String = ""
        Dim eEnabledTrueIf As String = ""
        Dim eEnabledFalse As String = ""
        Dim eEnabledFalseIf As String = ""
        Dim vVisibleTrue As String = ""
        Dim vVisibleTrueIf As String = ""
        Dim vVisibleFalse As String = ""
        Dim vVisibleFalseIf As String = ""
        Dim ttabindex As Integer = 0

        Dim CBODataSource As String = ""
        Dim CBODisplayMember As String = ""
        Dim CBOValueMember As String = ""
        Dim CBOFilter As String = ""
        Dim CBOFilterBy As String = ""
        Dim CBOSortBy As String = ""
        Dim awlsWeb As String = ""

        Dim ppk As Boolean = False
        Dim nppk As Boolean = False

        Dim pp As String = ""
        Dim arrayFP As String = ""
        Dim arrayFPPK As String = ""
        Dim arraypodtabela As String = ""
        Dim arrayTabButton As String = ""
        Dim arrayTabButtonBT As String = ""
        Dim arrayTabButtonText As String = ""
        Dim arrayButton As String = ""
        Dim arrayButtonBN As String = ""
        Dim arrayttabindex As String = ""
        Dim arrayttabindexF As String = ""
        Dim arrayttabindexTPF As String = ""
        Dim arrayttabindexPK As String = ""
        Dim fppk As String = ""
        Dim arrayFPNPK As String = ""
        Dim arrayFPE As String = ""
        Dim mxlength As Integer = 0
        Dim mnlength As Integer = 0
        Dim mmax As Long = 9999999999
        Dim mmin As Long = -9999999999
        Dim yyes As String = ""
        Dim nno As String = ""
        Dim fpPM As String = ""
        Dim fpselect As String = ""
        Dim arrayFPPM As String = ""
        Dim arrayFPPMW As String = ""
        Dim cEnabled As Boolean = True
        Dim cVisible As Boolean = True

        Dim ttype As String = ""
        Dim arrayContextKey As String = ""
        Dim arrayContextKeySQL As String = ""
        Dim arrayContextKeyDM As String = ""
        Dim arrayContextKeyVM As String = ""
        Dim arrayContextKeyFilter As String = ""
        Dim arrayContextKeyFilterTN As String = ""
        Dim arrayContextKeySQLGET As String = ""
        Dim arrayContextKeySortBy As String = ""
        Dim eventHandler As String = ""
        Dim eenabledppk As Boolean = False
        Dim ttab As String = ""
        Dim RadioButtonListFields As String = ""
        Dim CheckBoxGroup As String = ""

        Dim ggrid As String = ""
        Dim ggridopis As String = ""
        Dim colspan As Integer = 1
        Dim rowspan As Integer = 1

        Dim gridpk As String = ""
        Dim gridpkHT As String = ""
        Dim gridok As String = ""
        Dim gridokHT As String = ""

        Dim WebTab As Integer = 1
        Dim WebTabName As String = ""
        Dim pamtiWebTab As Integer = 0
        Dim f1 As Integer = 1
        Dim pamtiF1 As Integer = 0
        Dim pamtiY As Integer = 0

        Dim rowP As New TableRow()
        row = rowP
        Dim tableP As New Table()
        table = tableP

        Dim vid As Integer = 3
        If podtabela = True AndAlso Session("provera") = "0" Then vid = 2

        Dim panelP As New WebControls.Panel
        panel = panelP

        Dim preskoci As Boolean = False

        Dim dsStopIfLK As New DataSet()
        Dim dsStopIfLKPolja As New DataSet()
        Dim dtStopIfLK As New DataTable("MyTableStopIfLK")
        Dim dtStopIfLKPolja As New DataTable("MyTableStopIfLKPolja")
        dtStopIfLK.Columns.Add("rbrgreske", GetType(String))
        dtStopIfLK.Columns.Add("greska", GetType(String))
        dtStopIfLK.Columns.Add("nazivgreske", GetType(String))
        dtStopIfLK.Columns.Add("uslov", GetType(String))
        dtStopIfLKPolja.Columns.Add("polje", GetType(String))
        dtStopIfLKPolja.Columns.Add("gr", GetType(String))
        dtStopIfLKPolja.Columns.Add("nazivgreske", GetType(String))
        dtStopIfLKPolja.Columns.Add("tezina", GetType(String))
        For i As Integer = 0 To dsIST.Tables(0).Rows.Count - 1
            '*****set to default
            gridpk = ""
            gridpkHT = ""
            gridok = ""
            gridokHT = ""
            preskoci = False
            ttext = ""
            eventHandler = ""
            ttab = ""
            f1 = 1
            ttype = ""
            ttabindex = 0
            ppk = False
            mmultiline = False
            fppk = ""
            fpPM = ""
            fpselect = ""
            mxlength = 0
            mnlength = 0
            mmax = 9999999999
            mmin = -9999999999
            yyes = ""
            nno = ""
            sskipif = ""
            sskipto = ""
            sskippedenabledfalse = False
            sskippedsetempty = False
            aassignto = ""
            aassignif = ""
            aassignwhat = ""
            eEnabledTrue = ""
            eEnabledTrueIf = ""
            eEnabledFalse = ""
            eEnabledFalseIf = ""
            vVisibleTrue = ""
            vVisibleTrueIf = ""
            vVisibleFalse = ""
            vVisibleFalseIf = ""
            CBODataSource = ""
            awlsWeb = ""
            CBODisplayMember = ""
            CBOValueMember = ""
            CBOFilter = ""
            CBOFilterBy = ""
            CBOSortBy = ""
            cEnabled = True
            cVisible = True
            colspan = 1
            rowspan = 1
            nppk = False
            eenabledppk = True
            ggrid = ""
            ggridopis = ""
            WebTab = 1
            WebTabName = ""
            RadioButtonListFields = ""
            CheckBoxGroup = ""
            '*****set to default kraj

            Dim red As DataRow = dsIST.Tables(0).Rows(i)

            If red.Item("primarykey") = "P" Then ppk = True
            If red.Item("primarykeyMaster") = "P" AndAlso red.Item("PP2").ToString.Trim.ToUpper <> "DROPDOWNLIST" Then nppk = True
            If red.Item("primarykeyMaster") = "P" AndAlso red.Item("PP2").ToString.Trim.ToUpper = "DROPDOWNLIST" Then
                Session.Add("ddlKey", red.Item("polje").ToString.Trim.ToUpper)
            End If

            Select Case red.Item("PP2").ToString.Trim.ToUpper
                Case "LABEL"
                    rreadOnly = True
                    ttext = red.Item("izraz")
                    ttext = t.replaceYYYMMMUser(ttext, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
                    ttype = "Label"
                    pp = "LB_"
                Case "BUTTONTAB"
                    ttab = "tab"
                    ttype = "Button"
                    pp = "BT_"
                    If IsNumeric(red.Item("izraz")) = False Then
                        ttext = red.Item("izraz")
                    Else
                        ttext = "UNOS PODATAKA" '***IZMENA*** / "PART     " + red.Item("izraz")
                    End If
                    eventHandler = "ClickTab"
                    If red.Item("podtabela").ToString.Trim.ToUpper <> "" Then
                        arraypodtabela = arraypodtabela + red.Item("podtabela").ToString.Trim.ToUpper + ";"
                        arrayTabButton = arrayTabButton + red.Item("polje").ToString.Trim.ToUpper + ";"
                        arrayTabButtonBT = arrayTabButtonBT + "BT_" + red.Item("polje").ToString.Trim.ToUpper + ";"
                    End If
                Case "BUTTONGRID"
                    ggrid = red.Item("izraz") 'ime tabele, ne opis
                    ggridopis = ""
                    ttype = "Button"
                    pp = "BG_"
                    'ttext = "Grid " + red.Item("izraz")
                    ttext = red.Item("izraz")
                    eventHandler = "ClickTabGrid"
                Case "BUTTON"
                    ttype = "Button"
                    pp = "BN_"
                    ttext = red.Item("izraz")
                    eventHandler = "Click"
                    arraypodtabela = arraypodtabela + red.Item("podtabela").ToString.Trim.ToUpper + ";"
                    arrayButton = arrayButton + red.Item("polje").ToString.Trim.ToUpper + ";"
                    arrayButtonBN = arrayButtonBN + "BN_" + red.Item("polje").ToString.Trim.ToUpper + ";"
                Case "TEXTBOX"
                    rreadOnly = False
                    eenabledppk = True
                    ttext = ""
                    ttype = "TextBox"
                    pp = "TP_"
                    arrayttabindex = arrayttabindex + red.Item("tabindex").ToString.Trim.ToUpper + ";"
                    arrayttabindexF = arrayttabindexF + red.Item("polje").ToString.Trim.ToUpper + ";"
                    arrayttabindexTPF = arrayttabindexTPF + pp + red.Item("polje").ToString.Trim.ToUpper + ";"
                    If ppk = True Then
                        arrayttabindexPK = arrayttabindexPK + "1;"
                    Else
                        arrayttabindexPK = arrayttabindexPK + "0;"
                    End If
                    If ppk = True AndAlso nppk = True Then
                        eenabledppk = False
                    End If
                    If ppk = True AndAlso gridadd = "GridView" Then
                        eenabledppk = False
                    End If

                    eventHandler = "TextChanged"
                Case "COMBOBOX"   'radi kao stvarno text box sa padajucom listom - lazni combobox, puni se dinamicki na ukucavanje vrednosti u textpolje
                    rreadOnly = False
                    eenabledppk = True
                    ttext = ""
                    ttype = "TextBox"
                    pp = "CB_"
                    arrayttabindex = arrayttabindex + red.Item("tabindex").ToString.Trim.ToUpper + ";"
                    arrayttabindexF = arrayttabindexF + red.Item("polje").ToString.Trim.ToUpper + ";"
                    arrayttabindexTPF = arrayttabindexTPF + pp + red.Item("polje").ToString.Trim.ToUpper + ";"
                    If ppk = True Then
                        arrayttabindexPK = arrayttabindexPK + "1;"
                    Else
                        arrayttabindexPK = arrayttabindexPK + "0;"
                    End If
                    If ppk = True AndAlso nppk = True Then
                        eenabledppk = False
                    End If
                    CBODataSource = red.Item("CBODataSource").ToString.Trim
                    CBODataSource = CBODataSource.Trim.Substring(1, CBODataSource.Trim.Length - 2)
                    CBODataSource = t.replaceYYYMMMUser(CBODataSource, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))

                    CBODisplayMember = red.Item("CBODisplayMember").ToString.Trim
                    CBOValueMember = red.Item("CBOValueMember").ToString.Trim
                    CBOFilter = red.Item("CBOFilter").ToString.Trim
                    If CBOFilter.Trim = "" Then CBOFilter = "''"
                    CBOFilterBy = red.Item("CBOFilterBy").ToString.Trim
                    If CBOFilterBy.Trim = "" Then CBOFilterBy = "''"
                    CBOSortBy = red.Item("CBOSortBy").ToString.Trim
                    Dim sortby As String = ""
                    Dim ssortby As String = "''"
                    If CBOSortBy.Trim <> "" Then
                        sortby = ", " + CBOSortBy + " as SORT"
                        ssortby = " order by " + CBOSortBy
                    End If
                    Dim sql As String = "select top 20 " + CBODisplayMember + " as DisplayMember," + CBOValueMember + " as ValueMember " + sortby + " from (" + CBODataSource + ") A"

                    arrayContextKey = arrayContextKey + pp + red.Item("polje").ToString.Trim.ToUpper + ";"

                    arrayContextKeySQL = arrayContextKeySQL + sql + ";"

                    arrayContextKeyDM = arrayContextKeyDM + CBODisplayMember + ";"
                    arrayContextKeyVM = arrayContextKeyVM + CBOValueMember + ";"

                    arrayContextKeyFilter = arrayContextKeyFilter + CBOFilter + ";"
                    arrayContextKeyFilterTN = arrayContextKeyFilterTN + CBOFilterBy.Trim.ToUpper.Replace("D.", "") + ";"

                    Dim sqlGET As String = "select " + CBODisplayMember + " as DisplayMember ," + CBOValueMember + " as ValueMember " + sortby + " from (" + CBODataSource + ") A where 2=2 and " + CBOValueMember + "="

                    arrayContextKeySQLGET = arrayContextKeySQLGET + sqlGET + ";"
                    arrayContextKeySortBy = arrayContextKeySortBy + ssortby + ";"
                    eventHandler = "TextChanged"
                Case "GRIDVIEW"
                    rreadOnly = True
                    ttext = red.Item("fpselect")
                    ttype = "GridView"
                    pp = "GV_"
                    Dim dsISTTabele As DataSet
                    dsISTTabele = Session("dsISTTabele")
                    Dim maintable As String = Session("maintable").ToString.Trim.ToUpper
                    Dim type As String = ""
                    Dim tab As String = red.Item("CBOValueMember").ToString.Trim
                    Dim connectionstring As String = ""
                    Dim datasource As String = ""
                    Dim wwhere As String = ""
                    Dim drT As DataRow()
                    Dim pk As String = ""
                    Dim pkHT As String = ""
                    CBODataSource = "(select * from " + red.Item("CBODataSource").ToString.Trim + ")"
                    CBODataSource = CBODataSource.Trim.Substring(1, CBODataSource.Trim.Length - 2)
                    CBODataSource = t.replaceYYYMMMUser(CBODataSource, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))

                    drT = dsISTTabele.Tables(0).Select("tabela='" + tab + "'")
                    Dim dr As DataRow = drT(0)
                    ttext = dr.Item("opis").ToString.Trim
                    connectionstring = dr.Item("connectionstring").ToString.Trim
                    datasource = "select " + dr.Item("childPKS").ToString.Trim + " from " + CBODataSource + " where 2=2 "
                    gridpk = dr.Item("childPKS").ToString.Trim
                    gridpkHT = dr.Item("childPKHT").ToString.Trim

                    Dim gr As String = red.Item("CBODisplayMember").ToString.Trim
                    Dim grg() As String = gr.Split(",")

                    For iii As Integer = 0 To grg.GetUpperBound(0)
                        Dim g() As String = grg(iii).Split("=")
                        gridok = gridok + g(1) + ","
                        gridokHT = gridokHT + g(0) + ","
                    Next

                    gridok = gridok.TrimEnd(",")
                    gridokHT = gridokHT.TrimEnd(",")

                    eventHandler = "GridSelectedIndexChanged"
                Case "MENUBOX"   'radi na dodelu vrednosti iz liste
                    rreadOnly = False
                    eenabledppk = True
                    ttext = ""
                    ttype = "MenuBox"
                    pp = "MB_"
                    CBODataSource = ""
                    CBODisplayMember = red.Item("CBODisplayMember").ToString.Trim
                    CBOValueMember = red.Item("CBOValueMember").ToString.Trim
                    eventHandler = "MenuBoxSelectedIndexChanged"

                    If red.Item("podtabela").ToString.Trim.ToUpper <> "" Then
                        arraypodtabela = arraypodtabela + red.Item("podtabela").ToString.Trim.ToUpper + ";"
                        arrayTabButton = arrayTabButton + red.Item("CBOFILTER").ToString.Trim.ToUpper + ";"
                        arrayTabButtonBT = arrayTabButtonBT + red.Item("CBOFILTER").replace("BUTTON", "MI_BUTTON").ToString.Trim.ToUpper + ";"
                    End If

                Case "LISTBOX"   'radi na dodelu vrednosti iz liste
                    rreadOnly = False
                    eenabledppk = True
                    ttext = ""
                    ttype = "ListBox"
                    pp = "LB_"
                    CBODataSource = ""
                    CBODisplayMember = red.Item("CBODisplayMember").ToString.Trim
                    CBOValueMember = red.Item("CBOValueMember").ToString.Trim
                    eventHandler = "ListBoxSelectedIndexChanged"

                    If red.Item("podtabela").ToString.Trim.ToUpper <> "" Then
                        arraypodtabela = arraypodtabela + red.Item("podtabela").ToString.Trim.ToUpper + ";"
                        arrayTabButton = arrayTabButton + red.Item("CBOFILTER").ToString.Trim.ToUpper + ";"
                        arrayTabButtonBT = arrayTabButtonBT + red.Item("CBOFILTER").replace("BUTTON", "MI_BUTTON").ToString.Trim.ToUpper + ";"
                    End If
                Case "DROPDOWNLIST"  'radi kao stvarno dropdownlist, vuce iz baze
                    rreadOnly = False
                    eenabledppk = True
                    ttext = ""
                    ttype = "DropDownList"
                    pp = "DL_"
                    arrayttabindex = arrayttabindex + red.Item("tabindex").ToString.Trim.ToUpper + ";"
                    arrayttabindexF = arrayttabindexF + red.Item("polje").ToString.Trim.ToUpper + ";"
                    arrayttabindexTPF = arrayttabindexTPF + pp + red.Item("polje").ToString.Trim.ToUpper + ";"
                    If ppk = True Then
                        arrayttabindexPK = arrayttabindexPK + "1;"
                    Else
                        arrayttabindexPK = arrayttabindexPK + "0;"
                    End If
                    If ppk = True AndAlso nppk = True Then
                        eenabledppk = False
                    End If
                    If ppk = True AndAlso gridadd = "GridView" Then
                        eenabledppk = False
                    End If
                    CBODataSource = red.Item("CBODataSource").ToString.Trim
                    CBODataSource = CBODataSource.Trim.Substring(1, CBODataSource.Trim.Length - 2)
                    CBODataSource = t.replaceYYYMMMUser(CBODataSource, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))

                    CBODisplayMember = red.Item("CBODisplayMember").ToString.Trim
                    CBOValueMember = red.Item("CBOValueMember").ToString.Trim
                    CBOFilter = red.Item("CBOFilter").ToString.Trim
                    If CBOFilter.Trim = "" Then CBOFilter = "''"
                    CBOFilterBy = red.Item("CBOFilterBy").ToString.Trim
                    If CBOFilterBy.Trim = "" Then CBOFilterBy = "''"
                    CBOSortBy = red.Item("CBOSortBy").ToString.Trim
                    Dim sortby As String = ""
                    Dim ssortby As String = "''"
                    If CBOSortBy.Trim <> "" Then
                        sortby = ", " + CBOSortBy + " as SORT"
                        ssortby = " order by " + CBOSortBy
                    End If
                    Dim sql As String = "select " + CBODisplayMember + " as DisplayMember," + CBOValueMember + " as ValueMember " + sortby + " from (" + CBODataSource + ") A"
                    arrayContextKey = arrayContextKey + pp + red.Item("polje").ToString.Trim.ToUpper + ";"

                    arrayContextKeySQL = arrayContextKeySQL + sql + ";"

                    arrayContextKeyDM = arrayContextKeyDM + CBODisplayMember + ";"
                    arrayContextKeyVM = arrayContextKeyVM + CBOValueMember + ";"
                    arrayContextKeyFilter = arrayContextKeyFilter + CBOFilter + ";"
                    arrayContextKeyFilterTN = arrayContextKeyFilterTN + CBOFilterBy.Trim.ToUpper.Replace("D.", "") + ";"

                    Dim sqlGET As String = "select " + CBODisplayMember + " as DisplayMember ," + CBOValueMember + " as ValueMember " + sortby + " from (" + CBODataSource + ") A where 2=2 and " + CBOValueMember + "="

                    arrayContextKeySQLGET = arrayContextKeySQLGET + sqlGET + ";"
                    arrayContextKeySortBy = arrayContextKeySortBy + ssortby + ";"
                    eventHandler = "SelectedIndexChanged"

                Case "RADIOBUTTONLIST"
                    rreadOnly = False
                    eenabledppk = True
                    ttype = "RadioButtonList"
                    pp = "RB_"
                    Dim pom As String = red.Item("izraz").ToString.Trim.ToUpper
                    Dim pppom() As String = pom.Split(";")
                    For j As Integer = 0 To pppom.GetUpperBound(0)
                        If pppom(j).Trim.ToUpper.IndexOf("RADIOBUTTON") = 0 Then
                            pom = pppom(j)
                            Exit For
                        End If
                    Next
                    pom = pom.Replace(vbTab, " ").Replace(vbCr, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Trim
                    pom = Replace(pom, "radiobuttonv", "", 1, , CompareMethod.Text).Trim
                    pom = Replace(pom, "radiobuttonh", "", 1, , CompareMethod.Text).Trim
                    pom = Replace(pom, "\n", ",", 1, , CompareMethod.Text).Trim
                    pom = Replace(pom, "{", "", 1, , CompareMethod.Text).Trim
                    pom = Replace(pom, "}", "", 1, , CompareMethod.Text).Trim

                    pom = pom.Trim.Replace("' ,", "',").Replace("', ", "',")
                    pom = pom.Trim.Replace(", '", ",'").Replace(" ,'", ",'")
                    pom = pom.Trim.Replace("',", "$")

                    pom = pom.TrimEnd("$")
                    RadioButtonListFields = pom

                    arrayttabindex = arrayttabindex + red.Item("tabindex").ToString.Trim.ToUpper + ";"
                    arrayttabindexF = arrayttabindexF + red.Item("polje").ToString.Trim.ToUpper + ";"
                    arrayttabindexTPF = arrayttabindexTPF + pp + red.Item("polje").ToString.Trim.ToUpper + ";"


                    '1'Јануар 2020',2'Фебруар2020',3'Март 2020',13'Јануар 2019',14'Фебруар 2019'\n15'Март 2019',16'Април 2019',17'Мај 2019',18'Јун 2019',19'Јул 2019'\n20'Август 2019',21'Септембар 2019',22'Октобар 2019',23'Новембар 2019',24'Децембар 2019'
                    eventHandler = "RadioButtonList"

                Case "CHECKBOX"
                    rreadOnly = False
                    eenabledppk = True
                    ttype = "CheckBox"
                    pp = "CH_"
                    eventHandler = "CheckBox"
                    CheckBoxGroup = red.Item("CheckBoxGroup").ToString.Trim
                    arrayttabindex = arrayttabindex + red.Item("tabindex").ToString.Trim.ToUpper + ";"
                    arrayttabindexF = arrayttabindexF + red.Item("polje").ToString.Trim.ToUpper + ";"
                    arrayttabindexTPF = arrayttabindexTPF + pp + red.Item("polje").ToString.Trim.ToUpper + ";"

                Case "VIRTUAL FIELD", "VIRTUAL FIELD DB", "VIRTUAL FIELD MEM"
                    rreadOnly = True
                    ttext = red.Item("izraz")
                    fppk = red.Item("fppk")
                    fpselect = red.Item("fpselect")

                    If fpselect = "tselect" Then
                        ttext = ttext.Replace("{", "").Replace("}", "").Replace(":PK", "").Replace(":pk", "").Replace(": PK", "").Replace(": pk", "")
                        Dim mm() As String = ttext.Split(".")
                        If mm.Length = 2 Then
                            Dim drT As DataRow()
                            Dim dsISTTabele As DataSet = Session("dsISTTabele")
                            drT = dsISTTabele.Tables(0).Select("tabela='" + mm(0) + "'")
                            Dim kstr As String = ""
                            If drT.Count > 0 Then
                                Dim kljuc As String = drT(0).Item("childPKS").ToString.Trim
                                Dim kljucevi() As String = kljuc.Split(",")
                                For k As Integer = 0 To kljucevi.GetUpperBound(0)
                                    kstr = kstr + kljucevi(k).Trim + "=D." + kljucevi(k).Trim + " and "
                                Next
                                kstr = kstr + ";"
                                kstr = kstr.Replace(" and ;", "")
                                ttext = "#{select " + mm(1) + " from " + mm(0) + " where " + kstr + " :PK}"
                            Else
                                ttext = "' '"
                            End If
                        Else
                            ttext = "' '"
                        End If

                    End If

                    fpPM = red.Item("fppm")
                    ttype = "VirtualField"
                    pp = "FP_"
                    arrayFP = arrayFP + red.Item("polje").ToString.Trim.ToUpper + ";"
                    If fppk = ":pk" Then
                        arrayFPPK = arrayFPPK + red.Item("polje").ToString.Trim.ToUpper + ";"
                        arrayFPNPK = arrayFPNPK + "-" + ";"
                    Else
                        arrayFPPK = arrayFPPK + "-" + ";"
                        arrayFPNPK = arrayFPNPK + red.Item("polje").ToString.Trim.ToUpper + ";"
                    End If
                    If fpPM = "PM" OrElse fpPM = "PG" OrElse fpPM = "PK" Then
                        arrayFPPM = arrayFPPM + red.Item("polje").ToString.Trim.ToUpper + ";"
                        arrayFPPMW = arrayFPPMW + fpPM + ";"
                    Else
                        arrayFPPM = arrayFPPM + "-" + ";"
                        arrayFPPMW = arrayFPPMW + "-" + ";"
                    End If

                    arrayFPE = arrayFPE + ttext.Replace(vbTab, " ").Replace(vbCr, " ").Replace(vbCrLf, " ").Replace(vbLf, " ").Trim + ";"
                    arrayFPE = Replace(arrayFPE, ":pk", "", 1, , CompareMethod.Text).Trim
                    arrayFPE = Replace(arrayFPE, ": pk", "", 1, , CompareMethod.Text).Trim
                Case Else 'ne treba da bude bilo šta što nije ovo gore
                    '    treba da preskoči
                    preskoci = True
            End Select

            If preskoci = False Then

                If red.Item("wwidth").ToString <> "" AndAlso IsNumeric(red.Item("wwidth")) Then wwidth = red.Item("wwidth") Else wwidth = 100
                If red.Item("mxlength").ToString <> "" AndAlso IsNumeric(red.Item("mxlength")) Then mxlength = red.Item("mxlength")
                If red.Item("mnlength").ToString <> "" AndAlso IsNumeric(red.Item("mnlength")) Then mnlength = red.Item("mnlength")
                If red.Item("mmin").ToString <> "" AndAlso IsNumeric(red.Item("mmin")) Then mmin = red.Item("mmin")
                If red.Item("mmax").ToString <> "" AndAlso IsNumeric(red.Item("mmax")) Then mmax = red.Item("mmax")
                If red.Item("yyes").ToString <> "" Then yyes = red.Item("yyes")
                If red.Item("nno").ToString <> "" Then nno = red.Item("nno") 'AndAlso IsNumeric(red.Item("nno")) 

                ttabindex = CInt(red.Item("tabindex").ToString.Trim)

                'skip
                sskipif = red.Item("skipif").ToString.Trim.ToUpper
                sskipto = red.Item("skipto").ToString.Trim.ToUpper

                'stop
                sstopif = red.Item("stopif").ToString.Trim.ToUpper
                sstopmsg = red.Item("stopmsg").ToString.Trim.ToUpper

                If sstopif <> "" OrElse sstopmsg <> "" Then
                    Dim rowStopIfLK As DataRow = dtStopIfLK.NewRow()
                    Dim rowStopIfLKPolja As DataRow = dtStopIfLKPolja.NewRow()
                    rowStopIfLK("rbrgreske") = red.Item("polje")
                    rowStopIfLK("greska") = sstopif
                    rowStopIfLK("nazivgreske") = sstopmsg
                    rowStopIfLK("uslov") = "D"

                    dtStopIfLK.Rows.Add(rowStopIfLK)

                    rowStopIfLKPolja("polje") = red.Item("polje")
                    rowStopIfLKPolja("gr") = red.Item("polje")
                    rowStopIfLKPolja("nazivgreske") = sstopmsg
                    rowStopIfLKPolja("tezina") = "D"

                    dtStopIfLKPolja.Rows.Add(rowStopIfLKPolja)
                End If

                'assign
                aassignto = red.Item("assignto").ToString.Trim.ToUpper
                aassignif = red.Item("assignif").ToString.Trim.ToUpper
                aassignwhat = red.Item("assignwhat").ToString.Trim

                'eEnabled, vvVisible
                eEnabledTrue = red.Item("EnabledTrue").ToString.Trim.ToUpper
                eEnabledTrueIf = red.Item("EnabledTrueIf").ToString.Trim.ToUpper
                eEnabledFalse = red.Item("EnabledFalse").ToString.Trim
                eEnabledFalseIf = red.Item("EnabledFalseIf").ToString.Trim.ToUpper
                vVisibleTrue = red.Item("VisibleTrue").ToString.Trim.ToUpper
                vVisibleTrueIf = red.Item("VisibleTrueIf").ToString.Trim.ToUpper
                vVisibleFalse = red.Item("VisibleFalse").ToString.Trim.ToUpper
                vVisibleFalseIf = red.Item("VisibleFalseIf").ToString.Trim.ToUpper

                If red.Item("skippedenabledfalse") = "skippedenabledfalse" Then sskippedenabledfalse = True
                If red.Item("skippedsetempty") = "skippedsetempty" Then sskippedsetempty = True

                If wwidth = 0 Then
                    vvisible = False
                ElseIf ttext = "''" OrElse ttext.Replace("'", "").Trim = "" Then
                    vvisible = True
                Else
                    vvisible = True
                End If

                ttext = ttext.Replace("'", "")

                If rreadOnly = False AndAlso ttype = "TextBox" Then
                    ttext = ""
                End If

                ttop = pttop + red.Item("locy")
                ottop = red.Item("locy")

                colspan = red.Item("colspan").ToString.Trim
                rowspan = red.Item("rowspan").ToString.Trim

                f1 = red.Item("f1").ToString.Trim
                WebTab = red.Item("webTab").ToString.Trim
                WebTabName = red.Item("WebTabName").ToString.Trim

                If f1 > pamtiF1 Then
                    If pamtiF1 > 0 Then
                        If pamtiY > 0 AndAlso Not row Is Nothing Then
                            table.Rows.Add(row)
                            row = Nothing
                            cell = Nothing
                        End If
                        If IsTableEmpty(table) = False Then
                            Dim createDiv As System.Web.UI.HtmlControls.HtmlGenericControl = New System.Web.UI.HtmlControls.HtmlGenericControl("DIV")
                            createDiv.ID = "ISTDIV" + table.ID
                            createDiv.Style.Add(HtmlTextWriterStyle.OverflowX, "Auto")
                            createDiv.Controls.Add(table)
                            panel.Controls.Add(createDiv)

                            If WebTab > pamtiWebTab Then
                                MyPanel.Controls.Add(panel)
                                panel = Nothing
                            End If

                            table = Nothing
                            row = Nothing
                            cell = Nothing
                        End If
                    End If
                    'otvaram novu tabelu

                    If WebTab > pamtiWebTab Then
                        Dim panelN As New WebControls.Panel()
                        panel = panelN
                        panel.ID = "MyPanel" + CStr(WebTab).Trim
                        If f1 > vid Then panel.Style("display") = "none"
                        pamtiWebTab = WebTab
                    End If


                    Dim tableN As New Table()
                    table = tableN
                    table.ID = "MyTable" + CStr(f1).Trim
                    pamtiF1 = f1
                End If

                If ttop > pamtiY Then
                    If pamtiY > 0 AndAlso Not row Is Nothing Then
                        table.Rows.Add(row)
                        row = Nothing
                        cell = Nothing
                    End If
                    'otvaram nov red
                    Dim rowN As New TableRow()
                    row = rowN
                    pamtiY = ttop
                End If

                Dim prviposleKljuca As Boolean = False
                If rreadOnly = False OrElse ttext.Trim <> "" Then

                    Dim naziv As String = ""
                    If red.Item("polje").ToString.Trim.ToUpper.Count > 2 AndAlso red.Item("polje").ToString.Trim.ToUpper.Substring(0, 3) = "FP_" Then
                        naziv = red.Item("polje").ToString.Trim.ToUpper
                    Else
                        naziv = pp & red.Item("polje").ToString.Trim.ToUpper
                    End If
                    If naziv.Contains("FP_9") Then
                        Dim stopmsg = ""
                    End If
                    ci = PersistControlPage(naziv, ttype, ttab, ppk, eenabledppk,
                                    eEnabledTrue, eEnabledTrueIf, eEnabledFalse, eEnabledFalseIf, cEnabled,
                                    vVisibleTrue, vVisibleTrueIf, vVisibleFalse, vVisibleFalseIf, cVisible,
                                    mmultiline, ttop, lleft, wwidth, hheight, ttext,
                                    rreadOnly, vvisible, zzindex,
                                    sskipif, sskipto, sstopif, sstopmsg, sskippedenabledfalse, sskippedsetempty,
                                    aassignto, aassignif, aassignwhat, ttabindex,
                                    mxlength, mnlength, mmin, mmax, yyes, nno,
                                    CBODataSource, CBODisplayMember, CBOValueMember, CBOFilter, CBOFilterBy, CBOSortBy,
                                    f1, WebTab, WebTabName, colspan, rowspan, ggrid, ggridopis, RadioButtonListFields, CheckBoxGroup,
                                    gridpk, gridpkHT, gridok, gridokHT, eventHandler)
                    Call CreateControlPage(ci)
                    row.Cells.Add(cell)
                    cell = Nothing
                Else
                    Dim cellNH As New TableHeaderCell()
                    cell = cellNH
                    cell.RowSpan = rowspan
                    cell.ColumnSpan = colspan
                    cell.Text = String.Empty
                    row.Cells.Add(cell)
                    cell = Nothing
                    Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
                    If al Is Nothing Then al = New ArrayList()
                    Dim ciEmpty As ControlInfo = New ControlInfo()
                    ciEmpty.f1 = f1
                    ciEmpty.webTab = WebTab
                    ciEmpty.webtabName = WebTabName
                    ciEmpty.ttop = ttop
                    al.Add(ciEmpty)
                    Me.Session("DynamicControls") = al
                End If

            End If 'prekoci =false
        Next

        'ovde ubaaci stopif ds u sesiju
        dsStopIfLK.Tables.Add(dtStopIfLK)
        dsStopIfLKPolja.Tables.Add(dtStopIfLKPolja)
        Session.Add("dsISTStopIfLK", dsStopIfLK)
        Session.Add("dsISTStopIfLKPolja", dsStopIfLKPolja)

        'poslednjired, poslednje tabele
        If f1 = pamtiF1 Then
            If pamtiF1 > 0 Then
                If pamtiY > 0 AndAlso Not row Is Nothing Then
                    table.Rows.Add(row)
                    row = Nothing
                    cell = Nothing
                End If
                If IsTableEmpty(table) = False Then
                    Dim createDiv As System.Web.UI.HtmlControls.HtmlGenericControl = New System.Web.UI.HtmlControls.HtmlGenericControl("DIV")
                    createDiv.ID = "ISTDIV" + table.ID
                    createDiv.Style.Add(HtmlTextWriterStyle.OverflowX, "Auto")
                    createDiv.Controls.Add(table)

                    panel.Controls.Add(createDiv)
                    MyPanel.Controls.Add(panel)
                    panel = Nothing
                    table = Nothing
                    row = Nothing
                    cell = Nothing
                End If
            End If
        End If

        arraypodtabela = arraypodtabela.TrimEnd(";")
        Session("arraypodtabela") = arraypodtabela.Split(";")

        arrayTabButton = arrayTabButton.TrimEnd(";")
        Session("arrayTabButton") = arrayTabButton.Split(";")
        arrayTabButtonBT = arrayTabButtonBT.TrimEnd(";")
        Session("arrayTabButtonBT") = arrayTabButtonBT.Split(";")

        arrayButton = arrayButton.TrimEnd(";")
        Session("arrayButton") = arrayButton.Split(";")
        arrayButtonBN = arrayButtonBN.TrimEnd(";")
        Session("arrayButtonBN") = arrayButtonBN.Split(";")

        arrayttabindex = arrayttabindex.TrimEnd(";")
        Session("arrayttabindex") = arrayttabindex.Split(";")
        arrayttabindexF = arrayttabindexF.TrimEnd(";")
        Session("arrayttabindexF") = arrayttabindexF.Split(";")
        arrayttabindexTPF = arrayttabindexTPF.TrimEnd(";")
        Session("arrayttabindexTPF") = arrayttabindexTPF.Split(";")
        arrayttabindexPK = arrayttabindexPK.TrimEnd(";")
        Session("arrayttabindexPK") = arrayttabindexPK.Split(";")

        arrayFP = arrayFP.TrimEnd(";")
        Session("arrayFP") = arrayFP.Split(";")
        arrayFPE = arrayFPE.TrimEnd(";")
        Session("arrayFPE") = arrayFPE.Split(";")

        arrayFPPK = arrayFPPK.TrimEnd(";")
        arrayFPPK = arrayFPPK.Replace("-", "")
        Session("arrayFPPK") = arrayFPPK.Split(";")
        arrayFPNPK = arrayFPNPK.TrimEnd(";")
        arrayFPNPK = arrayFPNPK.Replace("-", "")
        Session("arrayFPNPK") = arrayFPNPK.Split(";")
        arrayFPPM = arrayFPPM.TrimEnd(";")
        arrayFPPM = arrayFPPM.Replace("-", "")
        Session("arrayFPPM") = arrayFPPM.Split(";")
        arrayFPPMW = arrayFPPMW.TrimEnd(";")
        arrayFPPMW = arrayFPPMW.Replace("-", "")
        Session("arrayFPPMW") = arrayFPPMW.Split(";")

        arrayContextKey = arrayContextKey.TrimEnd(";")
        Session("arrayContextKey") = arrayContextKey.Split(";")
        arrayContextKeySQL = arrayContextKeySQL.TrimEnd(";")
        Session("arrayContextKeySQL") = arrayContextKeySQL.Split(";")
        arrayContextKeySQLGET = arrayContextKeySQLGET.TrimEnd(";")
        Session("arrayContextKeySQLGET") = arrayContextKeySQLGET.Split(";")
        arrayContextKeySortBy = arrayContextKeySortBy.TrimEnd(";")
        Session("arrayContextKeySortBy") = arrayContextKeySortBy.Split(";")
        arrayContextKeyDM = arrayContextKeyDM.TrimEnd(";")
        Session("arrayContextKeyDM") = arrayContextKeyDM.Split(";")
        arrayContextKeyVM = arrayContextKeyVM.TrimEnd(";")
        Session("arrayContextKeyVM") = arrayContextKeyVM.Split(";")
        arrayContextKeyFilter = arrayContextKeyFilter.TrimEnd(";")
        Session("arrayContextKeyFilter") = arrayContextKeyFilter.Split(";")
        arrayContextKeyFilterTN = arrayContextKeyFilterTN.TrimEnd(";")
        Session("arrayContextKeyFilterTN") = arrayContextKeyFilterTN.Split(";")
    End Sub

    Function IsRowEmpty(ByVal row As TableRow) As Boolean
        IsRowEmpty = True
        If row.Cells.Count > 0 Then
            For Each cell As TableCell In row.Cells
                If cell.Controls.Count > 0 Then
                    ' If any cell has controls, the row is not empty
                    Return False
                End If
            Next
        End If
    End Function
    Function IsTableEmpty(ByVal ttable As Table) As Boolean
        IsTableEmpty = True
        If ttable.Rows.Count > 0 Then
            For Each row As TableRow In ttable.Rows
                If row.Cells.Count > 0 Then
                    For Each cell As TableCell In row.Cells
                        If cell.Controls.Count > 0 Then
                            ' If any cell has controls, the row is not empty
                            Return False
                        End If
                    Next
                End If
            Next
        End If
    End Function

    Dim table As Table
    Dim panel As WebControls.Panel
    Dim row As TableRow
    Dim cell As TableCell
    Dim headercell As TableHeaderCell
    Dim grid As GridView
    Private Function PersistControlPage(ByVal id As String, ByVal ttype As String, ByVal ttab As String, ByVal ppk As Boolean, ByVal eenabledppk As Boolean,
                                    ByVal eEnabledTrue As String, ByVal eEnabledTrueIf As String, ByVal eenabledFalse As String, ByVal eEnabledFalseIf As String, ByVal cEnabled As Boolean,
                                    ByVal vVisibleTrue As String, ByVal vVisibleTrueIf As String, ByVal vVisibleFalse As String, ByVal vVisibleFalseIf As String, ByVal cVisible As Boolean,
                                    ByVal mmultiline As Boolean, ByVal ttop As Integer, ByVal lleft As Integer, ByVal wwidth As Integer, ByVal hheight As Integer, ByVal ttext As String,
                                    ByVal rreadOnly As Boolean, ByVal vvisible As Boolean, ByVal zzindex As String, ByVal sskipif As String, ByVal sskipto As String,
                                    ByVal sstopif As String, ByVal sstopmsg As String, ByVal sskippedenabledfalse As Boolean, ByVal sskippedsetempty As Boolean,
                                    ByVal aassignto As String, ByVal aassignif As String, ByVal aassignwhat As String, ByVal ttabindex As Integer,
                                    ByVal mxlength As Integer, ByVal mnlength As Integer, ByVal mmin As Long, ByVal mmax As Long, ByVal yyes As String, ByVal nno As String,
                                    ByVal CBODataSource As String, ByVal CBODisplayMember As String, ByVal CBOValueMember As String, ByVal CBOFilter As String, ByVal CBOFilterBy As String, ByVal CBOSortBy As String,
                                    ByVal f1 As Integer, ByVal webtab As Integer, ByVal WebTabName As String, ByVal colspan As Integer, ByVal rowspan As Integer, ByVal ggrid As String, ByVal ggridopis As String, ByVal RadioButtonListFields As String,
                                    ByVal CheckBoxGroup As String,
                                    ByVal gridpk As String, ByVal gridpkHT As String, ByVal gridok As String, ByVal gridokHT As String,
                                    ByVal eventHandler As String) As ControlInfo
        Dim ci As ControlInfo = New ControlInfo()
        ci.ID = id  'name
        ci.wwidth = wwidth
        ci.Type = ttype
        ci.ttab = ttab
        ci.ggridopis = ggridopis
        ci.ggrid = ggrid
        ci.f1 = f1
        ci.webTab = webtab
        ci.webtabName = WebTabName
        ci.ttop = ttop
        ci.lleft = lleft
        ci.rReadOnly = rreadOnly
        ci.vvisible = vvisible
        ci.ttext = ttext
        ci.colspan = colspan
        ci.rowspan = rowspan
        ci.zindex = zzindex
        ci.mmultiline = mmultiline
        ci.sskipif = sskipif
        ci.sskipto = sskipto
        ci.sstopif = sstopif
        ci.sstopmsg = sstopmsg
        ci.sskippedenabledfalse = sskippedenabledfalse
        ci.sskippedsetempty = sskippedsetempty
        ci.aassignto = aassignto
        ci.aassignif = aassignif
        ci.aassignwhat = aassignwhat
        ci.cEnabled = cEnabled
        ci.eEnabledTrue = eEnabledTrue
        ci.eEnabledTrueIf = eEnabledTrueIf
        ci.eEnabledFalse = eenabledFalse
        ci.eEnabledFalseIf = eEnabledFalseIf
        ci.cVisible = cVisible
        If wwidth = "999999" Then
            ci.ddisplay = False
        Else
            ci.ddisplay = True
        End If
        ci.vVisibleTrue = vVisibleTrue
        ci.vVisibleTrueIf = vVisibleTrueIf
        ci.vVisibleFalse = vVisibleFalse
        ci.vVisibleFalseIf = vVisibleFalseIf

        ci.CBODataSource = CBODataSource
        ci.CBODisplayMember = CBODisplayMember
        ci.CBOValueMember = CBOValueMember
        ci.CBOFilter = CBOFilter
        ci.CBOFilterBy = CBOFilterBy
        ci.CBOSortBy = CBOSortBy

        ci.RadioButtonListFields = RadioButtonListFields
        ci.CheckBoxGroup = CheckBoxGroup

        ci.ppk = ppk
        ci.eenabledppk = eenabledppk
        ci.ttabindex = ttabindex
        ci.mxlength = mxlength
        ci.mnlength = mnlength
        ci.mmin = mmin
        ci.mmax = mmax
        ci.yyes = yyes
        ci.nno = nno
        ci.DBConnectionString = Me.DBConnectionString.Text
        ci.gridpk = gridpk
        ci.gridpkHT = gridpkHT
        ci.gridok = gridok
        ci.gridokHT = gridokHT

        If ttype = "TextBox" Then
            ci.EventHandler = eventHandler
        ElseIf ttype = "DropDownList" Then
            ci.EventHandler = eventHandler
        ElseIf ttype = "ListBox" Then
            ci.EventHandler = eventHandler
        ElseIf ttype = "MenuBox" Then
            ci.EventHandler = eventHandler
        ElseIf ttype = "GridView" Then
            ci.EventHandler = eventHandler
        ElseIf ttype = "Button" Then
            ci.EventHandler = eventHandler
        ElseIf ttype = "RadioButtonList" Then
            ci.EventHandler = eventHandler
        ElseIf ttype = "CheckBox" Then
            ci.EventHandler = eventHandler
        Else
            ci.EventHandler = ""
        End If

        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)

        If al Is Nothing Then
            al = New ArrayList()
        End If

        al.Add(ci)
        Me.Session("DynamicControls") = al

        Return ci
    End Function

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

    Function ValidateSave(Optional ByVal onlyValidate As Boolean = False) As String()
        Dim dsDB As DataSet
        dsDB = Session("dsDB")
        Session("masterTabledsDB") = Session("dsDB")
        Dim rowDB As DataRow = dsDB.Tables(0).Rows(0)
        Dim dsISTLK As DataSet
        dsISTLK = Session("dsISTLK")
        Dim dsISTStopIFLK As DataSet
        Dim dsISTStopIFLKPolja As DataSet
        dsISTStopIFLK = Session("dsISTStopIFLK")
        dsISTStopIFLKPolja = Session("dsISTStopIFLKPolja")

        Dim dsISTLKPolja As DataSet
        dsISTLKPolja = Session("dsISTLKPolja")



        Dim dt1 As DataTable = dsISTLK.Tables(0)
        Dim dt2 As DataTable = dsISTStopIFLK.Tables(0)

        Dim dt11 As DataTable = dsISTLKPolja.Tables(0)
        Dim dt22 As DataTable = dsISTStopIFLKPolja.Tables(0)

        Dim existingKeysLK As New HashSet(Of String)(dt1.AsEnumerable().Select(Function(r) r("rbrgreske").ToString() & "-" & r("greska").ToString()))

        Dim existingKeysLKPolja As New HashSet(Of String)(dt11.AsEnumerable().Select(Function(r) r("polje").ToString() & "-" & r("nazivgreske").ToString()))

        For Each row As DataRow In dt2.Rows
            Dim key As String = row("rbrgreske").ToString() & "-" & row("greska").ToString()
            If Not existingKeysLK.Contains(key) Then
                dt1.ImportRow(row)
                existingKeysLK.Add(key)
            End If
        Next

        For Each row As DataRow In dt22.Rows
            Dim key As String = row("polje").ToString() & "-" & row("nazivgreske").ToString()
            If Not existingKeysLKPolja.Contains(key) Then
                dt11.ImportRow(row)
                existingKeysLKPolja.Add(key)
            End If
        Next

        Dim rowDBLK As DataRow()
        Dim strSQLDB As String = ""
        Dim ImaG As Boolean = False
        Dim msg As String = ""
        Dim pmsg As String = ""
        Dim strerrorNumber As String = ""
        Dim strDONTSAVE As String = ""
        Dim arrayFP() As String = Session("arrayFP")
        dsDB.Tables(0).Rows(0).Item("INDGR") = False

        For i As Integer = 0 To dsISTLK.Tables(0).Rows.Count - 1
            Dim rowISTError As String = dsISTLK.Tables(0).Rows(i).Item("greska").ToString.Trim
            Dim tabela As String = Session("maintable")
            Dim pkbbbvalue As String = Session("pkCurrentTableValue")
            Dim pkCurrentTableValue() As String = pkbbbvalue.Split(";")
            Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
            Dim kljuc As String = ""
            For ll As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                kljuc = kljuc + " and " + pkCurrentTable(ll) + "='" + pkCurrentTableValue(ll) + "'"
            Next

            rowISTError = t.zameniFP(rowISTError, Session("dsDB"), MyPanel, arrayFP)
            rowISTError = t.razCASTi(rowISTError, dsDB)
            rowISTError = t.replaceYYYMMMUser(rowISTError, Session("appcode"), Session("gg"), Session("mm"), Session("uuser"), Session("tip"))
            'PMPG
            If rowISTError.Trim.ToUpper.IndexOf(" PM.") >= 0 OrElse rowISTError.Trim.ToUpper.IndexOf(" PG.") OrElse rowISTError.Trim.ToUpper.IndexOf(" PY.") OrElse rowISTError.Trim.ToUpper.IndexOf(" PK.") Then
                rowISTError = getPMGKsql(rowISTError)
            End If

            Dim rowISTErrorNumber As String = dsISTLK.Tables(0).Rows(i).Item("rbrgreske").ToString.Trim
            If rowISTErrorNumber <> "" Then
                If dsISTLK.Tables(0).Rows(i).Item("uslov").ToString.Trim <> "D" Then dsDB.Tables(0).Rows(0).Item(rowISTErrorNumber) = False

                Dim rowISTErrorDescription As String = dsISTLK.Tables(0).Rows(i).Item("nazivgreske").ToString.Trim
                Dim rowISTDontSave As String = "0"
                If dsISTLK.Tables(0).Rows(i).Item("uslov").ToString.Trim.Trim.ToUpper.IndexOf("DONTSAVE") >= 0 Then
                    rowISTDontSave = "1"
                End If
                Dim rowISTErrorWhere As String = ""
                If rowISTError.Trim.ToUpper.IndexOf("SELECT") >= 0 AndAlso rowISTError.Trim.ToUpper.IndexOf("SELECT") >= 0 Then
                    If rowISTError.Trim.ToUpper.IndexOf("SELECT") > 0 Then
                        'rowISTError = "select * from " + tabela + " where 2=2 "
                        'rowISTErrorWhere = kljuc + " and " + rowISTError
                        'rowISTError = rowISTError + rowISTErrorWhere

                        rowISTError = "select * from " + tabela + " where 2=2 " + kljuc + " and " + rowISTError
                    End If
                    'rowISTError = getCompleteSQL(rowISTError)
                    'database                
                    'Dim ds As New DataSet
                    'ds = b.DajDS_IzUpita(rowISTError, Me.DBConnectionString.Text)
                    Dim ds As New DataSet
                    ds = returnDSDB(rowISTError, rowISTErrorWhere, tabela + ".JSON", Me.DBConnectionString.Text)

                    If ds.Tables(0).Rows.Count > 0 Then
                        'msg = msg + rowISTErrorNumber + " " + rowISTErrorDescription + ";<br/>"
                        msg = msg + " " + rowISTErrorDescription + ";<br/>"
                        strerrorNumber = strerrorNumber + rowISTErrorNumber + ";"
                        pmsg = pmsg + "gr='" + rowISTErrorNumber + "' OR "
                        strDONTSAVE = strDONTSAVE + rowISTDontSave + ";"
                        ImaG = True
                        dsDB.Tables(0).Rows(0).Item("INDGR") = ImaG
                        dsDB.Tables(0).Rows(0).Item(rowISTErrorNumber) = ImaG
                    End If
                Else
                    'datatable               
                    rowDBLK = dsDB.Tables(0).Select(rowISTError)
                    If rowDBLK.Length > 0 Then
                        msg = msg + rowISTErrorDescription + ";<br/>" '+ " (NAZIV TABA GDE JE GRESKA)"
                        'msg = msg + " " + rowISTErrorDescription + "(" + dsISTLK.Tables(0).Rows(i).Item("rbrgreske").ToString.Trim + ")" +  ";<br/>"
                        strerrorNumber = strerrorNumber + rowISTErrorNumber + ";"
                        If dsISTLK.Tables(0).Rows(i).Item("uslov").ToString.Trim = "D" Then
                            pmsg = pmsg + "gr='" + dsISTLK.Tables(0).Rows(i).Item("rbrgreske").ToString.Trim + "' OR "
                            'msg = msg + rowISTErrorNumber + " " + rowISTErrorDescription + ";<br/>"
                        Else
                            pmsg = pmsg + "gr='" + rowISTErrorNumber + "' OR "
                            'msg = msg + " " + rowISTErrorDescription + "(" + dsISTLKPolja.Tables(0).Rows(i).Item("polje").ToString.Trim + ")" + ";<br/>"
                        End If

                        strDONTSAVE = strDONTSAVE + rowISTDontSave + ";"
                        ImaG = True
                        dsDB.Tables(0).Rows(0).Item("INDGR") = ImaG
                        If dsISTLK.Tables(0).Rows(i).Item("uslov").ToString.Trim <> "D" Then dsDB.Tables(0).Rows(0).Item(rowISTErrorNumber) = ImaG
                    End If
                End If
            End If
        Next

        Dim imaDontSave As Boolean = False
        strerrorNumber = strerrorNumber.TrimEnd(";")
        strDONTSAVE = strDONTSAVE.TrimEnd(";")
        Dim k As Integer = -1
        Dim bbbE() As String = strerrorNumber.Split(";")
        Dim bbbDS() As String = strDONTSAVE.Split(";")
        For i As Integer = 0 To bbbE.GetUpperBound(0)
            If bbbDS(i).Trim.ToUpper = "1" Then
                imaDontSave = True
                k = i
                Exit For
            End If
        Next

        Dim rowsToDelete As New List(Of DataRow)
        For Each row As DataRow In dt1.Rows
            If row("uslov").ToString() = "D" Then
                rowsToDelete.Add(row)
            End If
        Next

        For Each row As DataRow In rowsToDelete
            dt1.Rows.Remove(row)
        Next

        Dim msg1 As String = ""
        CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = ""
        CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "none"
        CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Text = ""
        CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Style("display") = "none"
        Call resetobojPoljaUGresciDodajToolTip(dsISTLKPolja.Tables(0))
        Call resetobojTabUGresci(dsISTLKPolja.Tables(0))
        Dim values As New List(Of String)

        If imaDontSave = False Then
            If onlyValidate = True AndAlso Me.lblInsertUpdate.Text.Trim = "U" Then
                Call prikazigreske(ImaG, dsISTLKPolja, pmsg, msg1 + " " + msg) 'dsISTStopIF
            End If
            If onlyValidate = False Then
                Dim ok As Boolean = SaveInDB()
                If ok = True Then
                    Call prikazigreske(ImaG, dsISTLKPolja, pmsg, msg1 + " " + msg) 'dsISTStopIF
                    Call setSnackBar(b.SetError(Session("dsErrors"), Session("izabranJezik"), "successSave"), "green")
                End If
            End If
        Else
            msg1 = b.SetError(Session("dsErrors"), Session("izabranJezik"), "dontSave") '+ bbbE(k) '"Slog sa greskom " + bbbE(k) + " nije dozvoljeno sačuvati - ispravite" + "<br/>" + msg1 'KGZ*
            values.Add(pmsg)
            values.Add(msg1)
            Call prikazigreske(ImaG, dsISTLKPolja, pmsg, msg1 + " " + msg)
            If onlyValidate = False Then
                Call setSnackBar(b.SetError(Session("dsErrors"), Session("izabranJezik"), "dontSave"), "red")
            End If

        End If
        Session("dsDB") = dsDB
        Return values.ToArray()
    End Function
    Sub prikazigreske(ByVal imaG As Boolean, ByVal dsISTLKPolja As DataSet, ByVal pmsg As String, ByVal msg1 As String)
        If imaG = True Then
            pmsg = pmsg + ";"
            pmsg = pmsg.Replace(" OR ;", "")

            Dim dt As DataTable = dsISTLKPolja.Tables(0)
            Dim dr() As DataRow = dt.Select(pmsg)
            obojPoljaUGresciDodajToolTip(dr)
            msg1 = obojTabCijaJeGeska(dr)
            'CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = msg1 '+ "(" + pmsg + ")"
            'msg1 = msg1 + b.SetLabel(Session("izabranJezik"), conn, "errors", Session("Country")) '"Errors!"
            CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = msg1
            If IsCollapsed Then
                CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "none"
            Else
                CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "block"
            End If
        Else
            CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = ""
            CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "none"
        End If
        Call getVFNPKALL()
    End Sub
    Function obojTabCijaJeGeska(dr() As DataRow) As String
        Dim msg = ""
        For i As Integer = 0 To dr.Count - 1
            Dim t As Boolean = False
            Dim cb As Boolean = False
            Dim dl As Boolean = False
            Dim txt As TextBox = Nothing
            Dim ctxt As TextBox = Nothing
            Dim ddl As DropDownList = Nothing
            msg = msg + dr(i).Item(2)
            Try
                txt = CType(MyPanel.FindControl("TP_" + dr(i).Item(0)), TextBox)
                If Not txt Is Nothing Then t = True
            Catch ex As Exception
                'nije TextBox
            End Try

            Try
                ddl = CType(MyPanel.FindControl("DL_" + dr(i).Item(0)), DropDownList)
                If Not ddl Is Nothing Then dl = True
            Catch ex As Exception
                'nije DropDownList
            End Try

            Dim color As System.Drawing.Color = Drawing.Color.Red
            Dim buttonTabTable As Control
            If t = True Then
                buttonTabTable = FindParentPanel(txt)
            End If
            If dl = True Then
                buttonTabTable = FindParentPanel(ddl)
            End If
            If buttonTabTable IsNot Nothing Then
                Dim panelId = buttonTabTable.ID.Replace("MyPanel", "")
                Dim buttonTab As Button = CType(MyPanel.FindControl("BT_BUTTON" + panelId), Button)
                Dim tabName As String = "/"
                If buttonTab IsNot Nothing AndAlso Not buttonTab.BorderColor = Drawing.Color.Red Then
                    buttonTab.BorderColor = color
                    tabName = buttonTab.Text
                End If

                msg = msg & " - " & "(" & tabName & ")" & "<br/>" 'buttonTab.ID
            End If
        Next

        Return msg
    End Function
    Sub resetobojPoljaUExecuteCheckDodajToolTip(ppID As String)

        Dim t As Boolean = False
        Dim cb As Boolean = False
        Dim dl As Boolean = False
        Dim txt As TextBox = Nothing
        Dim ctxt As TextBox = Nothing
        Dim ddl As DropDownList = Nothing

        Try
            ddl = CType(MyPanel.FindControl(ppID), DropDownList)
            If Not ddl Is Nothing Then dl = True
        Catch ex As Exception

        End Try

        Try
            txt = CType(MyPanel.FindControl(ppID), TextBox)
            If Not txt Is Nothing Then
                t = True
            Else

            End If
        Catch ex As Exception

        End Try

        Try
            ctxt = CType(MyPanel.FindControl(ppID), TextBox)
            If Not ctxt Is Nothing Then
                cb = True
            Else
                ddl = CType(MyPanel.FindControl(ppID), DropDownList)
                If Not ddl Is Nothing Then dl = True
            End If
        Catch ex As Exception

        End Try



        If t = True Then
            txt.BorderColor = System.Drawing.Color.Empty
            txt.BorderStyle = BorderStyle.NotSet
            txt.ToolTip = ""
        End If
        If cb = True Then
            ctxt.BorderColor = System.Drawing.Color.Empty
            ctxt.BorderStyle = BorderStyle.NotSet
            ctxt.ToolTip = ""
        End If
        If dl = True Then
            ddl.BorderColor = System.Drawing.Color.Empty
            ddl.BorderStyle = BorderStyle.NotSet
            ddl.ToolTip = ""
        End If
    End Sub

    Sub resetobojTabUGresci(ByVal dt As DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim t As Boolean = False
            Dim cb As Boolean = False
            Dim dl As Boolean = False
            Dim txt As TextBox = Nothing
            Dim ctxt As TextBox = Nothing
            Dim ddl As DropDownList = Nothing

            txt = CType(MyPanel.FindControl("TP_" + dt.Rows(i).Item(0)), TextBox)
            If Not txt Is Nothing Then
                t = True
            Else
                ctxt = CType(MyPanel.FindControl("CB_" + dt.Rows(i).Item(0)), TextBox)
                If Not ctxt Is Nothing Then
                    cb = True
                Else
                    ddl = CType(MyPanel.FindControl("DL_" + dt.Rows(i).Item(0)), DropDownList)
                    If Not ddl Is Nothing Then dl = True
                End If
            End If
            Dim buttonTabTable As Control
            If t = True Then
                buttonTabTable = FindParentPanel(txt)

            End If
            If dl = True Then
                buttonTabTable = FindParentPanel(ddl)
            End If
            If buttonTabTable IsNot Nothing Then
                Dim panelId = buttonTabTable.ID.Replace("MyPanel", "")
                Dim buttonTab As Button = CType(MyPanel.FindControl("BT_BUTTON" + panelId), Button)
                If buttonTab IsNot Nothing AndAlso buttonTab.BorderColor = Drawing.Color.Red Then
                    buttonTab.BorderColor = Drawing.Color.Transparent
                End If
            End If
        Next
    End Sub

    Sub resetobojPoljaUGresciDodajToolTip(ByVal dt As DataTable)
        For i As Integer = 0 To dt.Rows.Count - 1
            Dim t As Boolean = False
            Dim cb As Boolean = False
            Dim dl As Boolean = False
            Dim txt As TextBox = Nothing
            Dim ctxt As TextBox = Nothing
            Dim ddl As DropDownList = Nothing
            txt = CType(MyPanel.FindControl("TP_" + dt.Rows(i).Item(0)), TextBox)
            If Not txt Is Nothing Then
                t = True
            Else
                ctxt = CType(MyPanel.FindControl("CB_" + dt.Rows(i).Item(0)), TextBox)
                If Not ctxt Is Nothing Then
                    cb = True
                Else
                    ddl = CType(MyPanel.FindControl("DL_" + dt.Rows(i).Item(0)), DropDownList)
                    If Not ddl Is Nothing Then dl = True
                End If
            End If

            If t = True Then
                txt.BorderColor = System.Drawing.Color.Empty
                txt.BorderStyle = BorderStyle.NotSet
                txt.ToolTip = ""
            End If
            If cb = True Then
                ctxt.BorderColor = System.Drawing.Color.Empty
                ctxt.BorderStyle = BorderStyle.NotSet
                ctxt.ToolTip = ""
            End If
            If dl = True Then
                ddl.BorderColor = System.Drawing.Color.Empty
                ddl.BorderStyle = BorderStyle.NotSet
                ddl.ToolTip = ""
            End If


            'If Not txt Is Nothing Then
            '    txt.BorderColor = System.Drawing.Color.Empty
            '    txt.BorderStyle = BorderStyle.NotSet
            '    txt.ToolTip = ""

            'End If

        Next
    End Sub

    Sub obojPoljaUExecuteCheckDodajTooltip(ppID As String, vv As String)
        Dim t As Boolean = False
        Dim cb As Boolean = False
        Dim dl As Boolean = False
        Dim txt As TextBox = Nothing
        Dim ctxt As TextBox = Nothing
        Dim ddl As DropDownList = Nothing

        Try
            txt = CType(MyPanel.FindControl(ppID), TextBox)
            If Not txt Is Nothing Then t = True
        Catch ex As Exception
            'nije TextBox
        End Try

        Try
            ddl = CType(MyPanel.FindControl(ppID), DropDownList)
            If Not ddl Is Nothing Then dl = True
        Catch ex As Exception
            'nije DropDownList
        End Try


        'wut?
        'txt = CType(MyPanel.FindControl(ppID), TextBox)

        'If Not txt Is Nothing Then
        '    t = True
        'Else
        '    ctxt = CType(MyPanel.FindControl(ppID), TextBox)
        '    If Not ctxt Is Nothing Then
        '        cb = True
        '    Else
        '        ddl = CType(MyPanel.FindControl(ppID), DropDownList)
        '        If Not ddl Is Nothing Then dl = True
        '    End If
        'End If

        If t = True Then
            txt.BorderColor = Drawing.Color.Red
            txt.BorderStyle = BorderStyle.NotSet
            If txt.ToolTip <> "" AndAlso txt.ToolTip IsNot Nothing Then
                txt.ToolTip = txt.ToolTip + "; " + vv
            Else
                txt.ToolTip = vv
            End If

        End If
        If cb = True Then
            ctxt.BorderColor = Drawing.Color.Red
            ctxt.BorderStyle = BorderStyle.NotSet
            If ctxt.ToolTip <> "" AndAlso ctxt.ToolTip IsNot Nothing Then
                ctxt.ToolTip = ctxt.ToolTip + "; " + vv
            Else
                ctxt.ToolTip = vv
            End If
        End If
        If dl = True Then
            ddl.BorderColor = Drawing.Color.Red
            ddl.BorderStyle = BorderStyle.NotSet
            If ddl.ToolTip <> "" AndAlso ddl.ToolTip IsNot Nothing Then
                ddl.ToolTip = ddl.ToolTip + "; " + vv
            Else
                ddl.ToolTip = vv
            End If
        End If
    End Sub

    Sub obojPoljaUGresciDodajToolTip(ByVal dr() As DataRow)
        For i As Integer = 0 To dr.Count - 1
            Dim t As Boolean = False
            Dim cb As Boolean = False
            Dim dl As Boolean = False
            Dim txt As TextBox = Nothing
            Dim ctxt As TextBox = Nothing
            Dim ddl As DropDownList = Nothing

            Try
                txt = CType(MyPanel.FindControl("TP_" + dr(i).Item(0)), TextBox)
                If Not txt Is Nothing Then t = True
            Catch ex As Exception
                'nije TextBox
            End Try

            Try
                ddl = CType(MyPanel.FindControl("DL_" + dr(i).Item(0)), DropDownList)
                If Not ddl Is Nothing Then dl = True
            Catch ex As Exception
                'nije DropDownList
            End Try

            'txt = CType(MyPanel.FindControl("TP_" + dr(i).Item(0)), TextBox)

            'If Not txt Is Nothing Then
            '    t = True
            'Else
            '    ctxt = CType(MyPanel.FindControl("CB_" + dr(i).Item(0)), TextBox)
            '    If Not ctxt Is Nothing Then
            '        cb = True
            '    Else
            '        ddl = CType(MyPanel.FindControl("DL_" + dr(i).Item(0)), DropDownList)
            '        If Not ddl Is Nothing Then dl = True
            '    End If
            'End If

            Dim color As System.Drawing.Color = Drawing.Color.Red
            'if dr(i).Item(3) = "L" Then color = Drawing.Color.Yellow

            If t = True Then
                If Not txt.BorderColor = Drawing.Color.Red Then
                    txt.BorderColor = color
                End If

                txt.BorderStyle = BorderStyle.NotSet
                If Not txt.ToolTip.Contains(dr(i).Item(2)) Then
                    If IsDBNull(dr(i).Item(2)) = False Then
                        If txt.ToolTip = "" Then
                            txt.ToolTip = dr(i).Item(2)
                        Else
                            txt.ToolTip = txt.ToolTip + "; " + dr(i).Item(2)
                        End If
                    End If
                End If
            End If
            If cb = True Then
                ctxt.BorderColor = color
                ctxt.BorderStyle = BorderStyle.NotSet
                If Not ctxt.ToolTip.Contains(dr(i).Item(2)) Then
                    If IsDBNull(dr(i).Item(2)) = False Then
                        If ctxt.ToolTip = "" Then
                            ctxt.ToolTip = dr(i).Item(2)
                        Else
                            ctxt.ToolTip = ctxt.ToolTip + "; " + dr(i).Item(2)
                        End If
                    End If
                End If
            End If
            If dl = True Then
                ddl.BorderColor = color
                ddl.BorderStyle = BorderStyle.NotSet
                If Not ddl.ToolTip.Contains(dr(i).Item(2)) Then
                    If IsDBNull(dr(i).Item(2)) = False Then
                        If ddl.ToolTip = "" Then
                            ddl.ToolTip = dr(i).Item(2)
                        Else
                            ddl.ToolTip = ddl.ToolTip + "; " + dr(i).Item(2)
                        End If
                    End If
                End If
            End If


            'If Not txt Is Nothing Then
            '    txt.BorderStyle = BorderStyle.NotSet
            '    txt.BorderColor = Drawing.Color.Red
            '    If isdbnull(dr(i).Item(2))=False Then txt.ToolTip = dr(i).Item(2)        
            'End If
        Next

    End Sub
    Function getPMGKsql(ByVal rowISTError As String) As String

        getPMGKsql = ""
        Dim bbb() As String = t.razkvantaj(rowISTError)
        Dim ppp As String = ""
        For i As Integer = 0 To bbb.GetUpperBound(0)
            If bbb(i).Trim.ToUpper.IndexOf("PM.") = 0 Then
                getPMGKsql = getPMGKsql + getPMGK(bbb(i), "PM") + " "
            ElseIf bbb(i).Trim.ToUpper.IndexOf("PG.") = 0 OrElse bbb(i).Trim.ToUpper.IndexOf("PY.") = 0 Then
                getPMGKsql = getPMGKsql + getPMGK(bbb(i), "PG") + " "
            ElseIf bbb(i).Trim.ToUpper.IndexOf("PK.") = 0 Then
                getPMGKsql = getPMGKsql + getPMGK(bbb(i), "PK") + " "
            ElseIf bbb(i).Trim.ToUpper.IndexOf("PP.") = 0 Then
                getPMGKsql = getPMGKsql + getPMGK(bbb(i), "PP") + " "
            Else
                getPMGKsql = getPMGKsql + bbb(i) + " "
            End If
        Next

        Return getPMGKsql

    End Function
    Function SaveInDB() As Boolean
        SaveInDB = True
        Page.Validate()
        If Page.IsValid Then

            Dim okSave As String = saveMainTableData()
            If okSave = "OK" Then
                SaveInDB = True
            Else
                SaveInDB = False
            End If

            If okSave = "OK" OrElse okSave = "NERADINISTA" Then
                CType(PanelSave.FindControl("lblResult"), WebControls.Label).Visible = True
                CType(PanelSave.FindControl("lblExecuteErrors"), WebControls.Label).Visible = True
            End If


            If okSave = "NOK" Then
                CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = "Greška prilikom čuvanja podataka!"
                CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "block"
            End If
        End If
    End Function

    Function saveMainTableData() As String
        saveMainTableData = "NOK"
        Dim tablename As String = Session("maintable")
        Dim arrayttabindexF() As String = Session("arrayttabindexF")
        Dim dsDB As DataSet
        dsDB = Session("dsDB")
        Dim dsISTLK As DataSet
        dsISTLK = Session("dsISTLK")
        Dim sql As String = ""

        Dim pkCurrentTableX() As String = Session("pkCurrentTable").trim.toupper.split(";")
        Dim strProveiOpetUiliI As String = "select * from " + tablename + " where "
        For i As Integer = 0 To pkCurrentTableX.GetUpperBound(0)
            If t.SE(pkCurrentTableX(i), MyPanel) Is Nothing OrElse t.SE(pkCurrentTableX(i), MyPanel) = "" Then
                Return "NERADINISTA"
            End If
            strProveiOpetUiliI = strProveiOpetUiliI + pkCurrentTableX(i) + "=N'" + t.SE(pkCurrentTableX(i), MyPanel) + "' and "
        Next
        strProveiOpetUiliI = strProveiOpetUiliI + " 2=2"
        Dim dsProveiOpetUiliI As DataSet = b.DajDS_IzUpita(strProveiOpetUiliI, Me.DBConnectionString.Text, Session("Country"))
        If dsProveiOpetUiliI.Tables(0) Is Nothing OrElse dsProveiOpetUiliI.Tables(0).Rows.Count = 0 Then
            lblInsertUpdate.Text = "I"
        Else
            lblInsertUpdate.Text = "U"
        End If

        If lblInsertUpdate.Text = "U" Then
            Dim pkCurrentTable() As String = Session("pkCurrentTable").trim.toupper.split(";")
            sql = t.makeUpdate(tablename, dsDB, Me.lblUser.Text.Trim, pkCurrentTable, arrayttabindexF, dsISTLK)
        End If
        If lblInsertUpdate.Text = "I" Then
            sql = t.makeInsert(tablename, dsDB, Me.lblUser.Text.Trim, arrayttabindexF, dsISTLK)
        End If

        Dim ok As String = b.UpisPromenaBrisanje(sql, Me.DBConnectionString.Text, Session("Country"))
        If ok = "OK" OrElse ok = "True" Then
            saveMainTableData = "OK"
            lblInsertUpdate.Text = "U"
        Else
            saveMainTableData = "NOK"
        End If

        'exec on save
        Dim strexeconsave As String = ""
        For i As Integer = 0 To Session("dsISTTabele").tables(0).rows.count - 1
            If Session("dsISTTabele").tables(0).rows(i).item("tabela").ToString.Trim.ToUpper = tablename.Trim.ToUpper Then
                If Session("dsISTTabele").tables(0).rows(i).item("execonsave").ToString.Trim.ToUpper <> "" Then
                    strexeconsave = Session("dsISTTabele").tables(0).rows(i).item("execonsave").ToString.Trim.ToUpper
                    Exit For
                End If
            End If
        Next
        If strexeconsave <> "" Then
            If strexeconsave.IndexOf("D.") >= 0 Then
                Dim prviD As Integer = strexeconsave.IndexOf("D.")
                Dim Dovi As String = strexeconsave.Substring(prviD)
                Dim doviSplit As String() = Dovi.Split(",")
                For i As Integer = 0 To doviSplit.GetUpperBound(0)
                    doviSplit(i) = doviSplit(i).Replace(";", "").Replace("D.", "").Trim
                    strexeconsave = strexeconsave.Replace("D." + doviSplit(i), "N'" + t.SE(doviSplit(i), MyPanel) + "'")
                Next
            End If
            Dim dsExec = b.DajDS_IzUpita(strexeconsave, Me.DBConnectionString.Text, Session("Country"))
        End If
    End Function

    Private Sub ButtonNavigation_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim al As ArrayList = CType(Me.Session("DynamicControlsNavigation"), ArrayList)
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfoNavigation = al(i)
            If Not ci.ID Is Nothing AndAlso ci.ID.IndexOf("NB_") = 0 Then
                Dim b2 As WebControls.LinkButton = CType(MyPanel.FindControl(ci.ID), WebControls.LinkButton)
                If Not b2 Is Nothing Then b2.CssClass = "buttonPassive" 'b2.BackColor = Color.MistyRose 'Color.FromARGB(240,240,240)'
            End If
        Next

        Me.lblDG.Text = "G"

        Call ValidateSave()

        Dim dd As LinkButton = CType(sender, LinkButton)
        Dim maintable As String = dd.ID
        maintable = maintable.Replace("NB_", "")  'navigation button      

        Call ResetSessions()

        Me.Session("pkCurrentTable") = Session("pkinit")
        Me.Session("pkCurrentTableValue") = Session("pkinitvalue")

        Call ResetPage()

        Session("maintable") = maintable
        Session("provera") = 0
        'Session("uuser") = "logovan"
        'init  

        Call LoadPage()  'G

        'Dim btn As LinkButton = TryCast(sender, LinkButton)
        'If btn IsNot Nothing Then
        '    btn.CssClass = "buttonActive"
        'End If

        Dim b As WebControls.LinkButton = CType(MyPanel.FindControl(CType(sender, LinkButton).ID), WebControls.LinkButton)
        If Not b Is Nothing Then b.CssClass = "buttonActive"

    End Sub
    Sub ResetPage()

        For i As Integer = PlaceHolderNav.Controls.Count - 1 To 0 Step -1
            PlaceHolderNav.Controls.Remove(PlaceHolderNav.Controls(i))
        Next

        For i As Integer = PanelSave.Controls.Count - 1 To 0 Step -1
            PanelSave.Controls.Remove(PanelSave.Controls(i))
        Next

        For i As Integer = MyPanel.Controls.Count - 1 To 0 Step -1
            MyPanel.Controls.Remove(MyPanel.Controls(i))
        Next

        For i As Integer = PanelGrid.Controls.Count - 1 To 0 Step -1
            PanelGrid.Controls.Remove(PanelGrid.Controls(i))
        Next
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim aa As String = "aa"
        Dim bID As String = CType(sender, Button).ID
        Call LeaveControl(bID)
        Call getVFNPKALL()
    End Sub
    Private Sub ButtonLK_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        'samo lk
        Call ValidateSave(True)
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ok As Boolean = False

        'ne moze da sacuva ako ima greske
        'If CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text <> "" Then
        '    Exit Sub
        'End If

        If lblDG.Text = "G" Then ok = True
        If lblDG.Text = "D" AndAlso Session("provera") > 0 Then ok = True

        If lblDG.Text = "D" AndAlso ok = False Then
            'vrati na prvi prazan           
            'Dim prvi As Boolean =false
            'isprazni deo kljuca

            Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
            Dim pkNadtabela As Integer = Session("pkPreviousTable").split(";").GetUpperBound(0)
            For i As Integer = pkNadtabela + 1 To pkCurrentTable.GetUpperBound(0)
                Call AssignEvent(pkCurrentTable(i), "")
            Next
            'focus na prvi
            Call SetFocusEvent(Session("prviukljucuDTP"))
            Session("provera") = 0

            'Session("dsDB")=nothing
            ok = False

        End If

        If ok = True Then
            Dim samoLK As Boolean = False  'kad gruja namesti značemo kako dobija vrednost

            If samoLK Then
                Call ValidateSave(True)
            Else
                Dim isValid = ValidateSave()

                Dim dd As Button = CType(sender, Button)
                Dim tab As String = ""
                Dim nadtabela As String = ""
                Dim parentPK As String = ""
                Dim DG As String = ""
                If Not Me.Session("DynamicControlsSave") Is Nothing Then
                    Dim al As ArrayList = CType(Me.Session("DynamicControlsSave"), ArrayList)     'control
                    If al IsNot Nothing Then
                        For i As Integer = 0 To al.Count - 1
                            Dim ci As ControlInfoSave = DirectCast(al(i), ControlInfoSave)
                            If ci.Type = "ButtonSave" AndAlso ci.ID = dd.ID Then
                                nadtabela = ci.nadtab
                                tab = ci.tab
                                parentPK = ci.parentPK
                                DG = ci.DG
                                Exit For
                            End If
                        Next
                        If nadtabela <> "" AndAlso isValid.Length = 0 Then '
                            'Session("provera") = 0
                            'Dim pkPreviousTableValue As String = Session("pkPreviousTableValue")
                            'Dim pkPreviousTable As String = Session("pkPreviousTable")
                            'Dim gvPageIndex As Integer = Session("gvPageIndex")
                            'Call ResetSessions()
                            'Call ResetPage()
                            'Session("maintable") = nadtabela
                            'Session("pkCurrentTableValue") = pkPreviousTableValue
                            'Session("pkCurrentTable") = pkPreviousTable
                            'Session("gvPageIndex") = gvPageIndex
                            'Call LoadPage()

                            'Dim rg As Integer = ResetGrid("TableGrid_" + tab)
                            'If rg = 0 Then Call ResetISTGrid("GV_" + tab)

                            Session("provera") = 0

                            If Session("pkPreviousTableValue") Is Nothing Then
                                Dim pkCurrentTable1 As String = Session("pkCurrentTable")
                                Dim pkCurrentTableValue1 As String = Session("pkCurrentTableValue")
                                Dim gvPageIndex1 As Integer = Session("gvPageIndex")
                                'Call ResetSessions()
                                'Call ResetPage()

                                Session("gvPageIndex") = gvPageIndex1
                                Session("pkPreviousTable") = pkCurrentTable1
                                Session("pkPreviousTableValue") = pkCurrentTableValue1
                                'Call LoadPage()

                                'Dim rg As Integer = ResetGrid("TableGrid_" + tab)
                                'If rg = 0 Then Call ResetISTGrid("GV_" + tab)
                            Else
                                Dim pkPreviousTableValue As String = Session("pkPreviousTableValue")
                                Dim pkPreviousTable As String = Session("pkPreviousTable")
                                Dim gvPageIndex As Integer = Session("gvPageIndex")
                                Call ResetSessions()
                                Call ResetPage()
                                Session("maintable") = nadtabela
                                Session("pkCurrentTableValue") = pkPreviousTableValue
                                Session("pkCurrentTable") = pkPreviousTable
                                Session("gvPageIndex") = gvPageIndex
                                Call LoadPage()

                                Dim rg As Integer = ResetGrid("TableGrid_" + tab)
                                If rg = 0 Then Call ResetISTGrid("GV_" + tab)

                                setPassiveSubTableButton()
                                setPassiveButton()

                                Dim b As WebControls.Button = CType(MyPanel.FindControl("BG_" + tab), WebControls.Button)
                                If Not b Is Nothing Then b.CssClass = "buttonActive"
                            End If



                        ElseIf isValid.Length > 0 Then 'bilo nadtabela <> "" AndAlso isValid.Length > 0
                            prikazigreske(True, Session("dsISTLKPolja"), DirectCast(isValid, String())(0), DirectCast(isValid, String())(1))
                        End If
                    End If
                End If
            End If

        End If
    End Sub
    Private Sub ButtonAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Call ValidateSave()

        Dim dd As Button = CType(sender, Button)
        Dim maintable As String = dd.ID
        maintable = maintable.Replace("AB_", "") 'Add button

        Dim pkct As String = DataKeysPK(dd)
        Dim pkCurrentTable As String = Session("pkCurrentTable")
        Dim pkCurrentTableValue As String = Session("pkCurrentTableValue")
        Dim gvPageIndex As Integer = Session("gvPageIndex")
        Dim mtdsdb As DataSet = Session("dsDB")
        Call ResetSessions()
        Call ResetPage()

        Session("gvPageIndex") = gvPageIndex
        Session("pkPreviousTable") = pkCurrentTable
        Session("pkPreviousTableValue") = pkCurrentTableValue
        Session("pkCurrentTable") = pkct
        Session("masterTabledsDB") = mtdsdb
        Session("maintable") = maintable
        Session("provera") = 0

        Call LoadPage(True, "Add")

        Session("pkPreviousTable") = pkCurrentTable
        Session("pkPreviousTableValue") = pkCurrentTableValue
        Session("pkCurrentTable") = pkct

    End Sub
    Private Sub ButtonTab_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim btnTab As Button = CType(sender, Button)
        Call ButtonTabClick(btnTab.ID)

    End Sub

    Sub MenuBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        Dim lb As DropDownList = CType(sender, DropDownList)
        Dim btnTabID As String = lb.SelectedValue.ToString.Trim.ToUpper
        Call ButtonTabClick(btnTabID)
    End Sub
    Sub ButtonTabClick(ByVal btnTabID As String)

        setPassiveSubTableButton()
        setPassiveButton()

        'ako je glavna tabela i hocu dami cuva i kad klikne tab za taj deo dok je njemu, ne znam da li ovo treba???????        
        If lblDG.Text = "G" AndAlso Session("provera") Is Nothing Then
            Session("provera") = 1
        End If
        'ako je podtabela da pitam da li postoji i da prikazem ili da ga vratim da postavi novi kljuc
        'lbldg='D'
        If lblDG.Text = "D" AndAlso Session("provera") = 0 Then
            Session("provera") = 1
            Call pkCheckD()
        End If

        If (lblDG.Text = "G" OrElse lblDG.Text = "D") AndAlso Session("provera") > 0 Then
            If lblDG.Text = "D" AndAlso Session("provera") = 2 Then Call ValidateSave()
            If lblDG.Text = "G" Then Call ValidateSave()
            Session("provera") = 2

            For Each control As Control In MyPanel.Controls
                ' Check if the control is a panel
                If TypeOf control Is WebControls.Panel Then
                    Dim mypanel As WebControls.Panel = CType(control, WebControls.Panel)
                    Dim intn As String = mypanel.ID.Trim.ToUpper.Replace("MYPANEL", "")
                    If CInt(intn) > 2 Then
                        mypanel.Style("display") = "none"
                    End If
                End If
            Next
            Session("visibleTableGrid") = ""
            For Each control As Control In PanelGrid.Controls
                ' Check if the control is a panel
                If TypeOf control Is WebControls.Table Then
                    Dim tt As WebControls.Table = CType(control, WebControls.Table)
                    tt.Style("display") = "none"
                End If
            Next

            Dim nname As String = btnTabID
            nname = nname.Replace("BT_BUTTON", "MyPanel")
            nname = nname.Replace("MI_BUTTON", "MyPanel")

            Dim panel As WebControls.Panel = CType(MyPanel.FindControl(nname), WebControls.Panel)
            If Not panel Is Nothing Then panel.Style("display") = "block"

            Dim b As WebControls.Button = CType(MyPanel.FindControl(btnTabID), WebControls.Button)
            If Not b Is Nothing Then b.CssClass = "buttonActive" 'b.BackColor = Color.RosyBrown 'Color.FromARGB(46,126,193)'

            Session("visibleTab") = nname
        End If

        If Session("provera") = 0 AndAlso lblDG.Text = "D" Then
            CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = "Već postoji unos!" '***IZMENA*** Treba srediti po jezicima  /Already exists!
            CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "block"
        ElseIf Session("provera") <> 0 AndAlso lblDG.Text = "D" Then
            CType(PanelSave.FindControl("lblResult"), WebControls.Label).Text = ""
            CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "none"
        End If
    End Sub

    Sub pkCheckD()
        'provera da su svi kljucevi uneti

        Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
        Dim pkNadtabela As Integer = Session("pkpreviousTable").split(";").getupperbound(0)
        Dim prazanKljuc As Boolean = False
        Dim pkbbbvalue As String = ""
        For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
            Dim bbb As String = ""
            Dim vvalueSE As String = t.SE(pkCurrentTable(i), MyPanel)
            'If Not txt Is Nothing Then
            bbb = vvalueSE
            If bbb = "" Then
                prazanKljuc = True
                Session("provera") = 0
                'Session("dsDB")  =nothing
                'daj poruku
                SetFocusEvent(pkCurrentTable(i))
                Exit For
            Else
                pkbbbvalue = pkbbbvalue + bbb.Replace(ChrW(&H200B), "").Trim + ";"
            End If
            'End If
        Next
        If prazanKljuc = True Then
            Session("provera") = 0
            Exit Sub
        End If
        If prazanKljuc = False Then
            pkbbbvalue = pkbbbvalue.TrimEnd(";")
            Session("pkCurrentTableValue") = pkbbbvalue
            Dim pkCurrentTableValue() As String = pkbbbvalue.Split(";")
            'SSSSSSSSSSSSSSSSSSS
            Dim sqlDB As String = "select * from " + Session("maintable") + " where 2=2 "
            Dim sqlDBwhere As String = ""
            For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                sqlDBwhere = sqlDBwhere + " and " + pkCurrentTable(i) + "='" + pkCurrentTableValue(i) + "'"
            Next
            sqlDB = sqlDB + sqlDBwhere
            Dim dsDB As DataSet = b.DajDS_IzUpita(sqlDB, Me.DBConnectionString.Text, Session("Country"))
            'U
            If dsDB.Tables(0).Rows.Count = 1 Then
                Me.lblInsertUpdate.Text = "U"
                'postoji
                'poruka da li hoće da ga menja
                'ako hoce:
                'Session.Add("dsDB", dsDB)
                'Call GetDataIfExists()
                'ako nece :
                'ponisti kljuc
                'isprazni deo kljuca
                For i As Integer = pkNadtabela + 1 To pkCurrentTable.GetUpperBound(0)
                    Call AssignEvent(pkCurrentTable(i), "")   'assign write value in DS
                Next
                'focus na prvi
                Call SetFocusEvent(Session("prviukljucuDTP"))
                Session("provera") = 0


            End If
            'I
            If dsDB.Tables(0).Rows.Count = 0 Then
                Me.lblInsertUpdate.Text = "I"       'INSERT   
                Dim drNewRow As DataRow = dsDB.Tables(0).NewRow()
                For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                    drNewRow(pkCurrentTable(i)) = pkCurrentTableValue(i)
                Next
                dsDB.Tables(0).Rows.Add(drNewRow)
                dsDB.Tables(0).AcceptChanges()
                Session.Add("dsDB", dsDB)
            End If
        End If

    End Sub
    Private Sub ButtonTabGrid_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Call ValidateSave()
        setPassiveButton()
        setPassiveSubTableButton()

        Dim dd As Button = CType(sender, Button)
        Dim nname As String = dd.ID
        nname = nname.Replace("BG_", "TableGrid_")
        If Not dd Is Nothing Then dd.CssClass = "buttonActive"

        Call ResetGrid(nname)
    End Sub

    Function ResetGrid(ByVal nname As String) As Integer
        ResetGrid = 0
        Session("visibleTab") = ""
        For Each control As Control In MyPanel.Controls
            ' Check if the control is a panel
            If TypeOf control Is WebControls.Panel Then
                Dim mypanel As WebControls.Panel = CType(control, WebControls.Panel)
                Dim intn As String = mypanel.ID.Trim.ToUpper.Replace("MYPANEL", "")
                If CInt(intn) > 2 Then
                    mypanel.Style("display") = "none"
                End If
            End If
        Next
        For Each control As Control In PanelGrid.Controls
            If TypeOf control Is WebControls.Table Then
                Dim tt As WebControls.Table = CType(control, WebControls.Table)
                tt.Style("display") = "none"
            End If
        Next

        Dim ttv As WebControls.Table = CType(PanelGrid.FindControl(nname), WebControls.Table)

        If Not ttv Is Nothing Then
            'if nname.contains("TableGrid_") then display block/table
            ttv.Style("display") = "table"
            ResetGrid = 1
        End If

        Session("visibleTableGrid") = nname

    End Function
    Sub ResetISTGrid(ByVal nname As String)

        Dim tables() As String = Session("PanelGridTables").split(";")
        For i As Integer = 0 To tables.GetUpperBound(0)
            Dim tt As WebControls.Table = CType(PanelGrid.FindControl(tables(i)), WebControls.Table)
            If Not tt Is Nothing Then tt.Style("display") = "none"
        Next
        Dim tableActive As String = ""
        Dim gv As GridView = CType(MyPanel.FindControl(nname), GridView)
        Dim parentPanel As Panel = FindParentPanel(gv)
        If parentPanel IsNot Nothing Then
            parentPanel.Style("display") = "block"
            If Not Session("visibleTableGrid") Is Nothing Then
                Dim pp() As String = Session("visibleTableGrid").split(";")
                For i As Integer = 0 To pp.GetUpperBound(0)
                    Dim tt As WebControls.Table = CType(PanelGrid.FindControl(pp(i)), WebControls.Table)
                    If Not tt Is Nothing Then
                        tt.Style("display") = "table"
                        tableActive = tt.ClientID.Replace("TableGrid_", "BG_")
                    End If
                Next
            End If
            'Session("visibleTableGrid") = ""
            Session("visibleTab") = parentPanel.ID
        End If

        setPassiveSubTableButton()
        setPassiveButton()

        Dim b As WebControls.Button = CType(MyPanel.FindControl(tableActive), WebControls.Button)
        If Not b Is Nothing Then b.CssClass = "buttonActive" 'b.BackColor = Color.RosyBrown 'Color.FromARGB(46,126,193)'
    End Sub

    Sub setPassiveSubTableButton()
        Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)
        If alG IsNot Nothing Then
            For i As Integer = 0 To alG.Count - 1
                Dim ci As ControlInfoGrid = alG(i)
                If Not ci.ID Is Nothing AndAlso ci.ID.IndexOf("AB_") = 0 Then
                    Dim b2 As WebControls.Button = CType(MyPanel.FindControl(ci.ID.Replace("AB_", "BG_")), WebControls.Button)
                    If Not b2 Is Nothing Then b2.CssClass = "buttonPassive" 'b2.BackColor = Color.MistyRose 'Color.FromARGB(240,240,240)'
                End If
            Next
        End If
    End Sub


    Sub setPassiveButton()
        Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
        For i As Integer = 0 To al.Count - 1
            Dim ci As ControlInfo = al(i)
            If Not ci.ID Is Nothing AndAlso ci.ID.IndexOf("BT_") = 0 Then
                Dim b2 As WebControls.Button = CType(MyPanel.FindControl(ci.ID), WebControls.Button)
                If Not b2 Is Nothing Then b2.CssClass = "buttonPassive" 'b2.BackColor = Color.MistyRose 'Color.FromARGB(240,240,240)'
            End If
        Next
    End Sub

    Function FindParentPanel(control As Control) As Panel
        Dim parent As Control = control.Parent
        While parent IsNot Nothing
            If TypeOf parent Is Panel Then
                Return DirectCast(parent, Panel)
            End If
            parent = parent.Parent
        End While
        Return Nothing
    End Function
    Sub Grid_RowDeleting(sender As Object, e As GridViewDeleteEventArgs)

        Dim gv As GridView = CType(sender, GridView)
        Dim str As String = ""
        Dim connectionstring As String = ""
        Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)
        If Not alG Is Nothing Then
            For i As Integer = 0 To alG.Count - 1
                Dim ci As ControlInfoGrid = alG(i)
                If ci.ID = gv.ID Then
                    str = ci.datasource
                    connectionstring = ci.connectionstring
                    Exit For
                End If
            Next
        End If

        Dim sqlDBwhere As String = ""
        If str = "" Then
            Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
            For i As Integer = 0 To al.Count - 1
                Dim ci As ControlInfo = al(i)
                If ci.ID = gv.ID Then
                    connectionstring = ci.DBConnectionString
                    'datasource od trenutne tabele pk
                    Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
                    Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")
                    Dim sqlDB As String = ci.CBODataSource
                    sqlDBwhere = " WHERE 2=2 "
                    For ii As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                        sqlDBwhere = sqlDBwhere + " and " + pkCurrentTable(ii) + "='" + pkCurrentTableValue(ii) + "'"
                    Next
                    sqlDB = sqlDB + sqlDBwhere
                    str = sqlDB

                    Exit For
                End If
            Next
        End If


        Dim index As Integer = e.RowIndex

        Dim maintable As String = gv.ID
        maintable = maintable.Replace("GV_", "")  'gridview   
        Dim wwhere As String = DataKeys(gv, "RowDeleting", index).Split("#")(0)
        Dim sql As String = "delete from " + maintable + " where 2=2 " + wwhere

        Dim ok As String = b.UpisPromenaBrisanje(sql, Me.DBConnectionString.Text, Session("Country"))
        If ok = "OK" OrElse ok = "True" Then

            Call bindGV(gv, str, connectionstring, sqlDBwhere, maintable)
            Call setSnackBar("Row deleted successfully!")

            Dim nname As String = gv.ID
            If nname.IndexOf("GV_") = 0 Then
                Call ResetISTGrid(nname)
            Else
                Call ResetGrid(nname)
            End If
        Else
            'poruka
            Dim poruka = ""
        End If
    End Sub
    Sub setSnackBar(ByVal ttext As String, Optional ByVal color As String = "blue")
        Dim panel As ContentPlaceHolder = CType(Form.FindControl("bodyMainTable"), ContentPlaceHolder)
        Dim snack As HtmlGenericControl = CType(panel.FindControl("snackbar"), HtmlGenericControl)
        If color = "red" Then
            RemoveClass(snack, "green")
            RemoveClass(snack, "blue")
            AddClass(snack, "red")
        ElseIf color = "green" Then
            RemoveClass(snack, "blue")
            RemoveClass(snack, "red")
            AddClass(snack, "green")
        Else
            RemoveClass(snack, "red")
            RemoveClass(snack, "green")
            AddClass(snack, "blue")
        End If
        If Not snack Is Nothing Then
            'snack.InnerHtml = ttext
            'snack.Attributes.Remove("class")
            'snack.Attributes.Add("class", "showw")
            Dim script As String = "(function () {var msg = document.getElementById('snackbar');if (msg) {msg.style.opacity = '1';msg.innerHTML = '" + ttext + "';setTimeout(function () {msg.style.opacity = '0';}, 5000);}})();"
            'Dim script As String = "setTimeout(function(){ var x = document.getElementById('snackbar'); x.className = 'showw'; }, 3000);"
            ClientScript.RegisterStartupScript(Me.GetType(), "IntervalScript", script, True)
        End If
    End Sub
    Sub resetSnackBar()
        Dim panel As ContentPlaceHolder = CType(Form.FindControl("bodyMainTable"), ContentPlaceHolder)
        Dim snack As HtmlGenericControl = CType(panel.FindControl("snackbar"), HtmlGenericControl)
        If Not snack Is Nothing Then
            Dim script As String = "(function(){ var x = document.getElementById('snackbar'); x.className = '';x.innerHTML = ''; };"
            ClientScript.RegisterStartupScript(Me.GetType(), "IntervalScript", script, True)
        End If
    End Sub

    ' Adds a class if not already present
    Sub AddClass(ctrl As System.Web.UI.HtmlControls.HtmlControl, className As String)
        Dim current = If(ctrl.Attributes("class"), "")
        Dim parts = current.Split(New Char() {" "c, vbTab, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries).ToList()
        If Not parts.Contains(className) Then
            parts.Add(className)
            ctrl.Attributes("class") = String.Join(" ", parts)
        End If
    End Sub

    ' Removes a class if present
    Sub RemoveClass(ctrl As System.Web.UI.HtmlControls.HtmlControl, className As String)
        Dim current = If(ctrl.Attributes("class"), "")
        Dim parts = current.Split(New Char() {" "c, vbTab, vbCr, vbLf}, StringSplitOptions.RemoveEmptyEntries).ToList()
        parts.RemoveAll(Function(c) String.Equals(c, className, StringComparison.Ordinal))
        ctrl.Attributes("class") = String.Join(" ", parts)
    End Sub
    Sub Grid_RowBound(ByVal sender As Object, ByVal e As GridViewRowEventArgs)
        Dim gv As GridView = CType(sender, GridView)
        If e.Row.RowType = DataControlRowType.DataRow Then
            ' Iterate over each control in the designated cell
            For Each control As Control In e.Row.Cells(1).Controls
                ' Check if the control is a LinkButton and has a CommandName of "Delete"
                Dim button As LinkButton = TryCast(control, LinkButton)
                If button IsNot Nothing AndAlso button.CommandName = "Delete" Then
                    ' Add the JavaScript confirmation
                    Dim label_delete As String = b.SetLabel(Session("izabranJezik"), conn, "deleteRow", Session("Country"))
                    Dim script As String = "javascript:return confirm('" + label_delete + "');"
                    button.Attributes.Add("onclick", script) '***IZMENA*** Are you sure you want to delete this record
                    Exit For
                End If
            Next
        End If

    End Sub

    Sub Grid_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs)
        Dim gv As GridView = CType(sender, GridView)
        Dim dt As New DataTable
        Dim str As String = ""
        Dim connectionstring As String = ""
        Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)
        If Not alG Is Nothing Then
            For i As Integer = 0 To alG.Count - 1
                Dim ci As ControlInfoGrid = alG(i)
                If ci.ID = gv.ID Then
                    str = ci.datasource
                    connectionstring = ci.connectionstring
                    Exit For
                End If
            Next
        End If
        Dim sqlDBwhere As String = ""
        If str = "" Then
            Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
            For i As Integer = 0 To al.Count - 1
                Dim ci As ControlInfo = al(i)
                If ci.ID = gv.ID Then
                    connectionstring = ci.DBConnectionString
                    'datasource od trenutne tabele pk
                    Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
                    Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")
                    Dim sqlDB As String = ci.CBODataSource
                    sqlDBwhere = " WHERE 2=2 "
                    For ii As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                        sqlDBwhere = sqlDBwhere + " and " + pkCurrentTable(ii) + "='" + pkCurrentTableValue(ii) + "'"
                    Next
                    sqlDB = sqlDB + sqlDBwhere
                    str = sqlDB

                    Exit For
                End If
            Next
        End If

        If e.NewPageIndex <> -1 Then
            gv.PageIndex = e.NewPageIndex
            Session("gvPageIndex") = gv.PageIndex
            Call bindGV(gv, str, connectionstring, sqlDBwhere, gv.ID.Replace("GV_", ""))
        End If
    End Sub
    Sub Grid_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim gv As GridView = CType(sender, GridView)
        Dim dt As New DataTable
        Dim str As String = ""
        Dim connectionstring As String = ""

        Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)
        If Not alG Is Nothing Then
            For i As Integer = 0 To alG.Count - 1
                Dim ci As ControlInfoGrid = alG(i)
                If ci.ID = gv.ID Then
                    str = ci.datasource
                    connectionstring = ci.connectionstring
                    Exit For
                End If
            Next
        End If
        Dim sqlDBwhere As String = ""
        If str = "" Then
            Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
            For i As Integer = 0 To al.Count - 1
                Dim ci As ControlInfo = al(i)
                If ci.ID = gv.ID Then
                    connectionstring = ci.DBConnectionString
                    'datasource od trenutne tabele pk
                    Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
                    Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")
                    Dim sqlDB As String = ci.CBODataSource
                    sqlDBwhere = " WHERE 2=2 "
                    For ii As Integer = 0 To pkCurrentTable.GetUpperBound(0)
                        sqlDBwhere = sqlDBwhere + " and " + pkCurrentTable(ii) + "='" + pkCurrentTableValue(ii) + "'"
                    Next
                    sqlDB = sqlDB + sqlDBwhere
                    str = sqlDB

                    Exit For
                End If
            Next
        End If

        If Not Session("gvPageIndex") Is Nothing Then
            gv.PageIndex = Session("gvPageIndex")
        End If
        Call bindGV(gv, str, connectionstring, sqlDBwhere, gv.ID.Replace("GV_", ""))

    End Sub
    Dim a As Integer = 0
    Sub Grid_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

        a = a + 1

        If a < 2 Then
            Call ValidateSave()
            Dim gv As GridView = CType(sender, GridView)
            Dim index As Integer = gv.SelectedIndex

            Dim pkctValue As String = DataKeys(gv, "SelectedIndexChanged", index).Split("#")(0)
            Dim pkct As String = DataKeys(gv, "SelectedIndexChanged", index).Split("#")(1)
            Dim pkCurrentTable As String = Session("pkCurrentTable")
            Dim pkCurrentTableValue As String = Session("pkCurrentTableValue")

            Dim gvPageIndex As Integer = Session("gvPageIndex")
            Dim mtdsdb As DataSet = Session("dsDB")
            Call ResetSessions()
            Call ResetPage()
            Session("gvPageIndex") = gvPageIndex
            Session("pkPreviousTable") = pkCurrentTable
            Session("pkPreviousTableValue") = pkCurrentTableValue
            Session("pkCurrentTable") = pkct
            Session("pkCurrentTableValue") = pkctValue
            Session("masterTabledsDB") = mtdsdb
            Dim maintable As String = gv.ID
            maintable = maintable.Replace("GV_", "")  'gridview   
            Session("maintable") = maintable
            Session("provera") = 1

            Call LoadPage(True, "GridView")

            Session("pkPreviousTable") = pkCurrentTable
            Session("pkPreviousTableValue") = pkCurrentTableValue
            Session("pkCurrentTable") = pkct
            Session("pkCurrentTableValue") = pkctValue

        Else
            a = 0
        End If

    End Sub
    Function DataKeys(ByVal gv As GridView, ByVal funk As String, Optional index As Integer = -1) As String
        DataKeys = ""
        Dim pk As String = ""
        Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)
        If Not alG Is Nothing Then
            For i As Integer = 0 To alG.Count - 1
                Dim ci As ControlInfoGrid = alG(i)
                If ci.ID = gv.ID Then
                    pk = ci.pk
                    Exit For
                End If
            Next
        End If

        If pk = "" Then
            Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
            For i As Integer = 0 To al.Count - 1
                Dim ci As ControlInfo = al(i)
                If ci.ID = gv.ID Then
                    pk = ci.gridpk
                    Exit For
                End If
            Next
        End If

        Dim pkCT As String = ""
        Dim pkCTValues As String = ""
        Dim pp() As String = pk.Split(",")
        Dim cellValue As String = ""
        For i As Integer = 0 To pp.GetUpperBound(0)

            cellValue = ""
            Dim columnIndex As Integer = -1
            Dim fieldName As String = pp(i).Trim.ToUpper
            Dim dt As DataTable = gv.DataSource
            Dim getout As Integer = 0

            For k As Integer = 0 To dt.Columns.Count - 1
                If dt.Columns(k).ColumnName.Trim.ToUpper = fieldName Then
                    For g As Integer = 2 To gv.Columns.Count - 1
                        If DirectCast(gv.Columns(g), System.Web.UI.WebControls.BoundField).DataField.ToString.Trim.ToUpper = fieldName Then
                            cellValue = gv.Rows(index).Cells(g).Text
                            getout = 1
                            Exit For
                        End If
                    Next
                End If
                If getout = 1 Then Exit For
            Next
            pkCTValues = pkCTValues + cellValue.ToString + ";"

        Next
        pkCT = pk.Replace(",", ";").TrimEnd(";").Replace(" ", "")
        pkCTValues = pkCTValues.TrimEnd(";")
        If funk = "SelectedIndexChanged" Then
            DataKeys = pkCTValues + "#" + pkCT
        End If
        If funk = "RowDeleting" Then
            Dim pkv() As String = pkCTValues.Split(";")
            Dim bbb As String = ""
            For i As Integer = 0 To pp.GetUpperBound(0)
                bbb = bbb + " and " + pp(i) + "='" + pkv(i).Trim + "'"
            Next
            DataKeys = bbb
        End If
        Return DataKeys
    End Function
    Function DataKeysPK(ByVal dd As Button) As String
        DataKeysPK = ""
        Dim pk As String = ""
        Dim alG As ArrayList = CType(Me.Session("DynamicControlsGrid"), ArrayList)
        If Not alG Is Nothing Then
            For i As Integer = 0 To alG.Count - 1
                Dim ci As ControlInfoGrid = alG(i)
                If ci.ID = dd.ID.Replace("AB_", "GV_") Then
                    pk = ci.pk
                    Exit For
                End If
            Next
        End If

        If pk = "" Then
            Dim al As ArrayList = CType(Me.Session("DynamicControls"), ArrayList)
            For i As Integer = 0 To al.Count - 1
                Dim ci As ControlInfo = al(i)
                If ci.ID = dd.ID.Replace("AB_", "GV_") Then
                    pk = ci.gridpk
                    Exit For
                End If
            Next
        End If
        Dim pkCT As String = ""


        pkCT = pk.Replace(",", ";").TrimEnd(";").Replace(" ", "")

        Return pkCT
    End Function

    Protected Sub Grid_Sorting(ByVal sender As Object, ByVal e As GridViewSortEventArgs)
        Dim gv As GridView = CType(sender, GridView)
        Dim dt As DataTable = gv.DataSource
        If dt IsNot Nothing Then
            dt.DefaultView.Sort = e.SortExpression & " " & GetSortDirection(e.SortExpression)
            gv.DataSource = dt.DefaultView
            gv.DataBind()
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
    Protected Sub BezRedova(ByVal source As DataTable, ByVal gv As GridView)
        source.Rows.Add(source.NewRow())
        gv.DataSource = source
        gv.DataBind()

        Dim columnsCount As Integer = gv.Columns.Count

        gv.Rows(0).Cells.Clear()
        gv.Rows(0).Cells.Add(New TableCell())
        gv.Rows(0).Cells(0).ColumnSpan = columnsCount
        gv.Rows(0).Cells(0).HorizontalAlign = HorizontalAlign.Center
        'gv.Rows(0).Cells(0).ForeColor = System.Drawing.Color.Red
        'gv.Rows(0).Cells(0).Font.Bold = True
        'gv.Rows(0).Cells(0).Text = "Nema slogova"
        gv.Rows(0).Cells(0).Text = b.SetLabel(Session("izabranJezik"), conn, "noRows", Session("Country"))

    End Sub
    Protected Sub cmdPP_Click(sender As Object, e As EventArgs) Handles cmdPP.Click
        Dim sql As String = "select * from " + Session("mainTable") + " where 2=2 "
        Dim pp As String = ""
        If Session("TIP") = "Y" Then
            pp = "PG"
        ElseIf Session("TIP") = "M" Then
            pp = "PM"
        ElseIf Session("TIP") = "Q" Then
            pp = "PK"
        ElseIf Session("TIP") = "H" Then
            pp = "PP"
        End If
        Dim dsPP As DataSet = getPP(pp)

        Dim dsDB As DataSet = Session("dsDB")
        Dim dt As DataTable = dsDB.Tables(0).Rows(0).Table
        Dim pkCurrentTable() As String = Session("pkCurrentTable").split(";")
        Dim pkCurrentTableValue() As String = Session("pkCurrentTableValue").split(";")
        Dim strPK As String = ""

        Dim pk As String = ""
        For i As Integer = 0 To pkCurrentTable.GetUpperBound(0)
            pk = pk + pkCurrentTable(i).Trim.ToUpper + ";"
        Next

        If Not dsDB Is Nothing AndAlso dsDB.Tables.Count > 0 AndAlso Not dsDB.Tables(0) Is Nothing AndAlso dsDB.Tables(0).Rows.Count > 0 Then
            If Not dsPP Is Nothing AndAlso dsPP.Tables.Count > 0 AndAlso Not dsPP.Tables(0) Is Nothing AndAlso dsPP.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To dsDB.Tables(0).Columns.Count - 1
                    If pk.IndexOf(dsDB.Tables(0).Columns(i).Caption.Trim.ToUpper + ";") < 0 Then
                        dsDB.Tables(0).Rows(0).Item(i) = dsPP.Tables(0).Rows(0).Item(i)
                    End If
                Next
            End If

            'AndAlso Not dsIST.Tables(0).Rows(0).Item(0) Is DBNull.Value

        End If
        Session.Add("dsDB", dsDB)
        Call GetDataIfExists()
        Call getVFALL()
    End Sub

    Private Sub trnslt_backButton_Click(sender As Object, e As EventArgs) 'Handles trnslt_backButton.Click
        'Response.Redirect(Session("PreviousPage"))
        If Session("RolaUser").ToString.ToUpper = "ADMIN" Then
            Response.Redirect("Surveys.aspx")
        Else
            Response.Redirect("AddressBook.aspx")
        End If

    End Sub

    Private Sub ButtonGuide_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        CreateGridGuide(True)
    End Sub

    Private Sub CreateGridGuide(Optional buttonGuid As Boolean = False)
        If Session("gvFilesOpen") IsNot Nothing AndAlso Session("gvFilesOpen") = True AndAlso buttonGuid Then
            phGridView.Controls.Clear()
            Session.Add("gvFilesOpen", False)
            Exit Sub
        End If
        Session.Add("gvFilesOpen", True)
        ' Path to the folder containing the files
        Dim relativePath As String = ""
        Dim basePath As String = AppDomain.CurrentDomain.BaseDirectory
        If basePath.ToUpper().Contains("ISTWEB") Then
            relativePath = "static\docs\" + Session("appcode").Trim
        Else
            relativePath = "istweb\static\docs\" + Session("appcode").Trim
        End If
        Dim folderPath As String = Path.Combine(basePath, relativePath)
        ' Check if the folder exists
        If Not Directory.Exists(folderPath) Then
            'Response.Write("Folder does not exist.")
            setSnackBar("Folder ne postoji!")
            Session.Add("gvFilesOpen", False)
            Return
        End If

        ' Fetch all files in the folder
        Dim files As New List(Of FileDetails)()
        For Each filePath As String In Directory.GetFiles(folderPath)
            files.Add(New FileDetails With {
                .FileName = Path.GetFileName(filePath),
                .FilePath = filePath
            })
        Next

        ' Check if no files were found
        If files.Count = 0 Then
            ' Add a placeholder object with a "No files" message
            files.Add(New FileDetails With {
                .FileName = "No files available",
                .FilePath = String.Empty
            })
        End If

        ' Dynamically create a GridView
        Dim gvFiles As New GridView()
        gvFiles.ID = "gvFiles"
        gvFiles.AutoGenerateColumns = False

        ' Add columns to the GridView
        ' Column 1: File Name
        Dim fileNameColumn As New BoundField()
        fileNameColumn.DataField = "FileName"
        fileNameColumn.HeaderText = "Naziv dokumenta"
        gvFiles.Columns.Add(fileNameColumn)

        ' Column 2: Download Button
        Dim downloadButtonColumn As New ButtonField()
        downloadButtonColumn.Text = "Preuzmi"
        downloadButtonColumn.ButtonType = ButtonType.Link
        downloadButtonColumn.CommandName = "Download"
        downloadButtonColumn.HeaderText = "Preuzmi"
        'downloadButtonColumn.ItemStyle.CssClass = "preventPostback"
        gvFiles.Columns.Add(downloadButtonColumn)

        ' Add a "Close" button
        'Dim btnClose As New Button()
        'btnClose.ID = "btnCloseGrid"
        'btnClose.Text = "Zatvori uputstva"
        'btnClose.CssClass = "btn-close"
        'AddHandler btnClose.Click, AddressOf CloseGridView_Click

        ' Bind the data
        gvFiles.DataSource = files
        gvFiles.DataBind()

        ' Handle the RowCommand event for download
        AddHandler gvFiles.RowCommand, AddressOf GridView_RowCommand

        ' Add the GridView to the PlaceHolder
        phGridView.Controls.Clear()
        'phGridView.Controls.Add(btnClose)
        phGridView.Controls.Add(gvFiles)


        ' Hide the download button if no files are available
        If files.Count = 1 AndAlso files(0).FilePath = String.Empty Then
            gvFiles.Columns(1).Visible = False ' Hide the Download column
        End If
    End Sub

    Protected Sub CloseGridView_Click(sender As Object, e As EventArgs)
        phGridView.Controls.Clear()
        Session.Add("gvFilesOpen", False)
    End Sub

    Protected Sub GridView_RowCommand(sender As Object, e As GridViewCommandEventArgs)
        If e.CommandName = "Download" Then
            Dim rowIndex As Integer = Convert.ToInt32(e.CommandArgument)
            Dim filePath As String = CType(CType(sender, GridView).DataSource(rowIndex).FilePath, String)

            If IO.File.Exists(filePath) Then
                Dim fileName As String = Path.GetFileName(filePath)
                Response.Clear()
                Response.ContentType = "application/octet-stream"
                Response.AddHeader("Content-Disposition", "attachment; filename=" & fileName)
                Response.WriteFile(filePath)
                Response.End()
            Else
                Response.Write("File not found.")
            End If
        End If
    End Sub

    'Private Sub trnslt_backButton_Click(sender As Object, e As EventArgs) 'Handles trnslt_backButton.Click
    '    Response.Redirect("Default.aspx")
    'End Sub

    Private Function FindControlInPanel(panel As Control, id As String) As Control
        For Each ctrl As Control In panel.Controls
            If ctrl.ID = id Then
                Return ctrl
            Else
                Dim child = FindControlInPanel(ctrl, id)
                If child IsNot Nothing Then Return child
            End If
        Next
        Return Nothing
    End Function

    Protected Sub btnToggle_Click(sender As Object, e As EventArgs)
        IsCollapsed = Not IsCollapsed
        ApplyToggle()
    End Sub
    Private Sub ApplyToggle()
        Dim btnToggle As WebControls.Button = CType(PanelSave.FindControl(Session("btnToggleID")), WebControls.Button)
        Dim showErrors = b.SetLabel(Session("izabranJezik"), conn, "showErrors", Session("Country"))
        Dim hideErrors = b.SetLabel(Session("izabranJezik"), conn, "hideErrors", Session("Country"))
        Dim btnToggleText = If(IsCollapsed, showErrors, hideErrors)
        Session.Add("btnToggleText", btnToggleText)
        If btnToggle IsNot Nothing Then
            If IsCollapsed Then
                CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "none"
            Else
                CType(PanelSave.FindControl("lblResult"), WebControls.Label).Style("display") = "block"
            End If
            btnToggle.ToolTip = btnToggleText
            btnToggle.Text = If(IsCollapsed, "◻︎", "◼︎")
        End If

    End Sub

    Private Property IsCollapsed As Boolean
        Get
            Return Convert.ToBoolean(ViewState("IsCollapsed")) ' Nothing -> False
        End Get
        Set(value As Boolean)
            ViewState("IsCollapsed") = value
        End Set
    End Property


    ' Class to store file details
    Public Class FileDetails
        Public Property FileName As String
        Public Property FilePath As String
    End Class
End Class



