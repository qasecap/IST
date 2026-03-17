Option Strict Off

Imports System.Configuration
Imports System.Data
Imports System.Windows.Forms
Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports System
Imports System.Security.Permissions
Imports Microsoft.Win32
Imports System.Data.Linq.Mapping
Imports IstrazivanjaZadaci

Module ModuleMain
    Dim jezik As String
    Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
    Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
    Private objMutex As System.Threading.Mutex
    Public IdleTimer As Timer = New Timer()
    Const MinuteMicroseconds As Integer = 60000 * 20
    Public frmIstrazivanje As FormIstrazivanje = Nothing
    Dim kojaforma As String = ""

    Public Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim limf As LeaveIdleMessageFilter = New LeaveIdleMessageFilter()
        Application.AddMessageFilter(limf)
        AddHandler Application.Idle, New EventHandler(AddressOf Application_Idle)
        IdleTimer.Interval = MinuteMicroseconds
        AddHandler IdleTimer.Tick, AddressOf TimeDone
        IdleTimer.Start()

        'Check to prevent running twice
        Dim DSBrisanjeServer As String = ""
        Dim DSBrisanjeBaza As String = ""
        Dim DSBrisanjeDEPO As String = ""
        Dim DSBrisanjeDEPOUser As String = ""
        Dim DSBrisanjeDEPOPassword As String = ""
        Dim ISTConnectionString As String = ""
        Dim ISTServerBaza As String = ""
        Dim nvIST As System.Collections.Specialized.NameValueCollection
        nvIST = CType(ConfigurationManager.GetSection("ISTconnection"), System.Collections.Specialized.NameValueCollection)
        'Data Source = IMT2.statsrb.lan;Initial Catalog=IST;User ID=obican;Password=obican;
        If Not nvIST Is Nothing Then
            For Each k As String In nvIST.Keys
                Dim v As String = nvIST.Item(k).Trim
                If k.Trim.ToUpper = "DATA SOURCE" Then ISTConnectionString = ISTConnectionString + "Data Source=" + v + ";" : ISTServerBaza = ISTServerBaza + "Data Source=" + v + ";" + nvrd
                If k.Trim.ToUpper = "INITIAL CATALOG" Then ISTConnectionString = ISTConnectionString + "Initial Catalog=" + v + ";" : ISTServerBaza = ISTServerBaza + "Initial Catalog=" + v + ";" + nvrd
                If k.Trim.ToUpper = "USER ID" Then ISTConnectionString = ISTConnectionString + "User ID=" + v + ";"
                If k.Trim.ToUpper = "PASSWORD" Then ISTConnectionString = ISTConnectionString + "Password=" + v + ";"
            Next
        End If

        Dim bUseRecentList As Boolean = True
        Dim folderProgramaZaUnos As String = ""
        Dim txtInstalacija As String = ""
        Dim txtpismo As String = ""
        Dim txtoffice As String = ""
        Dim txtnonavailable As String = ""
        Dim txtdefaultLanguage As String = ""
        Dim txtMode As String = ""
        Dim txtLogIN As String = ""

        Dim folderZaGen As String = ""

        Dim nv As System.Collections.Specialized.NameValueCollection
        nv = CType(ConfigurationManager.GetSection("Istrazivanja"), System.Collections.Specialized.NameValueCollection)
        For Each k As String In nv.Keys
            Dim v As String = nv.Item(k).Trim.ToUpper
            If k.Trim.ToUpper = "FOLDERZAPROGRAMEZAUNOS" Then folderProgramaZaUnos = v
            If k.Trim.ToUpper = "INSTALACIJA" Then txtInstalacija = v
            If k.Trim.ToUpper = "PISMO" Then txtpismo = v
            If k.Trim.ToUpper = "MODE" Then txtMode = v
            If k.Trim.ToUpper = "FOLDERZAGEN" Then folderZaGen = v
            If k.Trim.ToUpper = "OFFICE" Then txtoffice = v
            If k.Trim.ToUpper = "NONAVAILABLE" Then txtnonavailable = v
            If k.Trim.ToUpper = "DEFAULTLANGUAGE" Then txtdefaultLanguage = v
            If k.Trim.ToUpper = "LOGIN" Then txtLogIN = v
        Next

        If txtMode.Trim.ToUpper = "CAPI" OrElse txtMode.Trim.ToUpper = "ZCAPI" OrElse txtMode.Trim.ToUpper = "TESTCAPI" OrElse
         txtMode.Trim.ToUpper = "CAPITEST" OrElse txtMode.Trim.ToUpper = "MIXMODECAPIDESKTOP" Then   'može i testcapi
            objMutex = New System.Threading.Mutex(False, "MyApplicationName")
            If objMutex.WaitOne(0, False) = False Then
                objMutex.Close()
                objMutex = Nothing
                MessageBox.Show("Another instance is already running!")
                End
            End If
        End If

        Dim nvBrisiB As System.Collections.Specialized.NameValueCollection
        Dim nvBrisiD As System.Collections.Specialized.NameValueCollection

        nvBrisiB = CType(ConfigurationManager.GetSection("ISTBrisanja"), System.Collections.Specialized.NameValueCollection)
        nvBrisiD = CType(ConfigurationManager.GetSection("ISTDeletings"), System.Collections.Specialized.NameValueCollection)

        If Not nvBrisiB Is Nothing Then
            For Each k As String In nvBrisiB.Keys
                Dim v As String = nvBrisiB.Item(k).Trim.ToUpper
                If k.Trim.ToUpper = "DATA SOURCE" Then DSBrisanjeServer = v
                If k.Trim.ToUpper = "INITIAL CATALOG" Then DSBrisanjeBaza = v
                If k.Trim.ToUpper = "BRISANJEDEPO" Then DSBrisanjeDEPO = v
                If k.Trim.ToUpper = "USER ID" Then DSBrisanjeDEPOUser = v
                If k.Trim.ToUpper = "PASSWORD" Then DSBrisanjeDEPOPassword = v
            Next
        End If
        If Not nvBrisiD Is Nothing Then
            For Each k As String In nvBrisiD.Keys
                Dim v As String = nvBrisiD.Item(k).Trim.ToUpper
                If k.Trim.ToUpper = "DATA SOURCE" Then DSBrisanjeServer = v
                If k.Trim.ToUpper = "INITIAL CATALOG" Then DSBrisanjeBaza = v
                If k.Trim.ToUpper = "SAVEDELETED" Then DSBrisanjeDEPO = v
                If k.Trim.ToUpper = "USER ID" Then DSBrisanjeDEPOUser = v
                If k.Trim.ToUpper = "PASSWORD" Then DSBrisanjeDEPOPassword = v
            Next
        End If

        If txtdefaultLanguage = "" Then txtdefaultLanguage = "SRC"

        Dim CATIServer As String = ""
        Dim CATIbaza As String = ""
        Dim nvCATI As System.Collections.Specialized.NameValueCollection
        nvCATI = CType(ConfigurationManager.GetSection("ISTCATI"), System.Collections.Specialized.NameValueCollection)

        If Not nvCATI Is Nothing Then
            For Each k As String In nvCATI.Keys
                Dim v As String = nvCATI.Item(k).Trim.ToUpper
                If k.Trim.ToUpper = "DATA SOURCE" Then CATIServer = v
                If k.Trim.ToUpper = "INITIAL CATALOG" Then CATIbaza = v
            Next
        End If

        Dim CAPIServer As String = ""
        Dim CAPIbaza As String = ""
        Dim nvCAPI As System.Collections.Specialized.NameValueCollection
        nvCAPI = CType(ConfigurationManager.GetSection("ISTCAPI"), System.Collections.Specialized.NameValueCollection)

        If Not nvCAPI Is Nothing Then
            For Each k As String In nvCAPI.Keys
                Dim v As String = nvCAPI.Item(k).Trim.ToUpper
                If k.Trim.ToUpper = "DATA SOURCE" Then CAPIServer = v
                If k.Trim.ToUpper = "INITIAL CATALOG" Then CAPIbaza = v
            Next
        End If

        Dim PublicDBServer As String = ""
        Dim PublicDBBaza As String = ""
        Dim nvPublicDB As System.Collections.Specialized.NameValueCollection
        nvPublicDB = CType(ConfigurationManager.GetSection("PUBLICDB"), System.Collections.Specialized.NameValueCollection)

        If Not nvPublicDB Is Nothing Then
            For Each k As String In nvPublicDB.Keys
                Dim v As String = nvPublicDB.Item(k).Trim.ToUpper
                If k.Trim.ToUpper = "DATA SOURCE" Then PublicDBServer = v
                If k.Trim.ToUpper = "INITIAL CATALOG" Then PublicDBBaza = v
            Next
        End If

        'Dim PXMETAServer As String = ""
        Dim PXMETAtable As String = ""
        Dim PXMETAApp As String = ""
        Dim nvPXMETA As System.Collections.Specialized.NameValueCollection
        nvPXMETA = CType(ConfigurationManager.GetSection("ISTPXMETA"), System.Collections.Specialized.NameValueCollection)

        If Not nvPXMETA Is Nothing Then
            For Each k As String In nvPXMETA.Keys
                Dim v As String = nvPXMETA.Item(k).Trim.ToUpper
                If k.Trim.ToUpper = "_IST" Then PXMETAApp = v
                If k.Trim.ToUpper = "_ISTTABLES" Then PXMETAtable = v
            Next
        End If

        If txtMode.Trim.ToUpper.IndexOf("CLOUD") >= 0 Then
            If ISTConnectionString <> "" Then
                Dim cISTConnectionString() As String = ISTConnectionString.Split(";")
                Dim datasource As String = "imt2.database.windows.net"
                For i As Integer = 0 To cISTConnectionString.GetUpperBound(0)
                    If cISTConnectionString(i).Trim.ToUpper.IndexOf("DATA SOURCE") = 0 AndAlso cISTConnectionString(i).Trim.ToLower.IndexOf(datasource) > 0 Then
                        'sve je ok, nase, pustaj, ostaje ISTConnectionString kakav jeste  ISTConnectionString=frmLogin.MyConnectionString
                    End If
                    If cISTConnectionString(i).Trim.ToUpper.IndexOf("DATA SOURCE") = 0 AndAlso cISTConnectionString(i).Trim.ToLower.IndexOf(datasource) < 0 Then
                        'namesteno za demo
                        ISTConnectionString = FormTemplate.getConnectionString(datasource, "IST", "CLOUD", "")
                        DSBrisanjeServer = datasource
                        DSBrisanjeBaza = "DEPO"
                        folderZaGen = "\\istfileshareaccount.file.core.windows.net\istfileshare\IST\SQLtxt\IST"
                        CATIServer = datasource
                        CATIbaza = "IST"
                        CAPIServer = datasource
                        CAPIbaza = "ISTCAPI"
                    End If
                Next
            End If
        End If

        If txtMode.Trim.ToUpper.IndexOf("Z") >= 0 OrElse txtMode.Trim.ToUpper.IndexOf("ZCAPI") >= 0 Then
            ISTConnectionString = FormTemplate.getConnectionString("", "IST", "Z", "")
        End If

        Dim dtZ As DataTable = Nothing
        Dim kosamNEW As String = ""

        Dim frmlogin As FormLoginZ = Nothing
        If txtLogIN.Trim.ToUpper = "TRUE" Then
            'OPEN FORMLOGON
            kojaforma = "FORMLOGINZ"
            frmlogin = New FormLoginZ(ISTConnectionString, DSBrisanjeDEPO, DSBrisanjeServer, DSBrisanjeBaza, txtdefaultLanguage, txtMode)
            Try
                frmlogin.ShowDialog()
                ''loginu napisati u retry prvih 6 na koje ima pravo
            Catch ex As System.Exception
                ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Not frmlogin.IsDisposed Then
                    dtZ = frmlogin.dtZ
                    kosamNEW = frmlogin.KosamNEW
                End If
                frmlogin.Dispose()
                If kosamNEW = "" Then
                    End
                End If
            End Try

        End If

        Dim overlayHandleISTLoading As ISTFormIsLoading
        overlayHandleISTLoading = New ISTFormIsLoading(Nothing, Nothing)
        overlayHandleISTLoading.Show()
        If kosamNEW = "" Then
            kosamNEW = GetUserName.ToString.Trim
        End If
        Call Istrazivanje(ISTConnectionString, txtdefaultLanguage, bUseRecentList, folderProgramaZaUnos,
            txtInstalacija, txtpismo, txtoffice, txtnonavailable, txtMode,
            DSBrisanjeDEPO, DSBrisanjeServer, DSBrisanjeBaza, folderZaGen,
            CATIServer, CATIbaza, CAPIServer, CAPIbaza, PublicDBServer, PublicDBBaza, PXMETAApp, PXMETAtable, dtZ, txtLogIN, kosamNEW, overlayHandleISTLoading)

        RemoveHandler Application.Idle, New EventHandler(AddressOf Application_Idle)

    End Sub

    Declare Function GetUserName Lib "advapi32.dll" Alias _
            "GetUserNameA" (ByVal lpBuffer As String,
            ByRef nSize As Integer) As Integer

    Private Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String
        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Microsoft.VisualBasic.Strings.Chr(0)))
    End Function

    Sub Istrazivanje(ByVal ISTConnectionString As String, ByVal txtdefaultLanguage As String, ByVal bUseRecentList As Boolean, ByVal folderProgramaZaUnos As String,
                     ByVal txtInstalacija As String, ByVal txtpismo As String, ByVal txtoffice As String, ByVal txtnonavailable As String, ByVal txtMode As String,
                     ByVal DSBrisanjeDEPO As String, ByVal DSBrisanjeServer As String, ByVal DSBrisanjeBaza As String, ByVal folderZaGen As String,
                     ByVal CATIServer As String, ByVal CATIbaza As String, ByVal CAPIServer As String, ByVal CAPIbaza As String,
                     ByVal PublicDBServer As String, ByVal PublicDBBaza As String,
                     ByVal PXMETAApp As String, ByVal PXMETAtable As String, ByVal dtZ As DataTable, ByVal txtlogin As String, ByVal kosamNEW As String, ByVal overlayHandleISTLoading As ISTFormIsLoading)


        'REGISTRY PART
        Dim godina As Integer = RegistryPartIzabraniDatum()
        Dim izbor1 As String = RegistryPartIzbor()
        Dim regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\VB and VBA Program Settings\\Istrazivanja", True)

        Dim m_zadaci As IstrazivanjaZadaci.IstrazivanjaZadaci
        Dim postojiISTApp As Boolean = False

        m_zadaci = New IstrazivanjaZadaci.IstrazivanjaZadaci(ISTConnectionString, izbor1, txtdefaultLanguage, txtlogin, kosamNEW)

        If m_zadaci.mti.Rows.Count > 0 AndAlso izbor1 = "" Then
            izbor1 = m_zadaci.mti(0).SIFIST
        End If

        Try
            If bUseRecentList AndAlso izbor1 <> "" Then
                postojiISTApp = m_zadaci.puniDSIST(izbor1)
                If postojiISTApp = False Then
                    If m_zadaci.mti.Rows.Count > 0 Then
                        izbor1 = m_zadaci.mti(0).SIFIST
                        Call m_zadaci.puniDSIST(m_zadaci.mti(0).SIFIST)
                        postojiISTApp = False
                        If txtlogin = "TRUE" AndAlso m_zadaci.mti.Rows.Count = 1 Then
                            postojiISTApp = True
                        End If
                    Else
                        ISTMessageBox.Show("There is no any app")
                    End If
                End If
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Dim frmIstrazivanje As FormIstrazivanje = Nothing
        Try
            kojaforma = "FORMISTRAZIVANJE"
            frmIstrazivanje = New FormIstrazivanje(ISTConnectionString, m_zadaci.MyGetISTRow(izbor1),
            m_zadaci.dsIST, Nothing,
            folderProgramaZaUnos, regVersion,
            txtInstalacija, txtpismo, txtoffice, txtnonavailable, txtMode,
            DSBrisanjeDEPO, DSBrisanjeServer, DSBrisanjeBaza, folderZaGen,
            CATIServer, CATIbaza, CAPIServer, CAPIbaza, PublicDBServer, PublicDBBaza, txtdefaultLanguage, PXMETAApp, PXMETAtable, postojiISTApp, dtZ, txtlogin, kosamNEW, overlayHandleISTLoading)

            frmIstrazivanje.ShowDialog()

            jezik = frmIstrazivanje.jezik

        Catch ex As System.Exception

            ISTMessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not frmIstrazivanje Is Nothing Then
                frmIstrazivanje.Dispose()
            End If
        End Try

    End Sub
    Function RegistryPartIzabraniDatum() As Integer
        Dim regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\IzabranDatum", True)
        If regVersion Is Nothing Then
            regVersion = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(
                 "SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\IzabranDatum")
        End If

        Dim godina As Integer = -1

        If regVersion IsNot Nothing Then godina = If(regVersion.GetValue("godina", "") = "", -1, regVersion.GetValue("godina", -1))
        If godina = -1 Or godina < 1899 Then
            godina = Date.Today.Year
            regVersion.SetValue("godina", godina, RegistryValueKind.String)
        End If
        Dim mesec As Integer = -1
        If regVersion IsNot Nothing Then mesec = If(regVersion.GetValue("mesec", "") = "", -1, regVersion.GetValue("mesec", -1))
        If mesec = -1 Then
            mesec = Date.Today.Month
            regVersion.SetValue("mesec", mesec, RegistryValueKind.String)
        End If

        regVersion.Flush()

        Return godina

    End Function

    Function RegistryPartIzbor() As String
        Dim regVersion = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(
                  "SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\Izbor", True)
        If regVersion Is Nothing Then
            regVersion = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(
                 "SOFTWARE\\VB and VBA Program Settings\\Istrazivanja\\Izbor")
        End If

        Dim izbor1 As String = ""
        If regVersion IsNot Nothing Then izbor1 = regVersion.GetValue("1", "")

        Return izbor1

    End Function
    Public Sub DoRefresh(ByVal con As String)
        Dim a As New OleDbDataAdapter("", con)
        Dim tab() As String = {"IST", "ISTBAZE", "ISTLK", "ISTPOLJA", "ISTTABS", "ISTTABELE", "CAPIdata"}
        Dim d As New DataSet("DatasetIstrazivanja")
        Try
            For Each t As String In tab
                Dim t2 As New DataTable(t.Trim)
                a.SelectCommand.CommandText = "select * from " + t + " where 1=0"
                a.Fill(t2) 'fillSchema pravi tipove za svako polje
                d.Tables.Add(t2)
            Next
            d.WriteXmlSchema(d.DataSetName + ".xsd")
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Application_Idle(ByVal sender As Object, ByVal e As EventArgs)
        If Not IdleTimer.Enabled Then IdleTimer.Start()
    End Sub

    Private Sub TimeDone(ByVal sender As Object, ByVal e As EventArgs)
        IdleTimer.[Stop]()
        MessageBox.Show("Security checking! Automatic logoff! You must open IST again!")
        'If kojaforma = "FORMLOGINZ" Then
        '    FormLoginZ.Close()
        'ElseIf kojaforma = "FORMISTRAZIVANJE" Then
        '    frmIstrazivanje.Close()
        'End If

        System.Windows.Forms.Application.Exit()
        End
    End Sub
End Module


<SecurityPermission(SecurityAction.LinkDemand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
Public Class LeaveIdleMessageFilter

    Implements IMessageFilter
    Const WM_NCLBUTTONDOWN As Integer = &HA1
    Const WM_NCLBUTTONUP As Integer = &HA2
    Const WM_NCRBUTTONDOWN As Integer = &HA4
    Const WM_NCRBUTTONUP As Integer = &HA5
    Const WM_NCMBUTTONDOWN As Integer = &HA7
    Const WM_NCMBUTTONUP As Integer = &HA8
    Const WM_NCXBUTTONDOWN As Integer = &HAB
    Const WM_NCXBUTTONUP As Integer = &HAC
    Const WM_KEYDOWN As Integer = &H100
    Const WM_KEYUP As Integer = &H101
    Const WM_MOUSEMOVE As Integer = &H200
    Const WM_LBUTTONDOWN As Integer = &H201
    Const WM_LBUTTONUP As Integer = &H202
    Const WM_RBUTTONDOWN As Integer = &H204
    Const WM_RBUTTONUP As Integer = &H205
    Const WM_MBUTTONDOWN As Integer = &H207
    Const WM_MBUTTONUP As Integer = &H208
    Const WM_XBUTTONDOWN As Integer = &H20B
    Const WM_XBUTTONUP As Integer = &H20C
    Shared Messages As Integer() = New Integer() {WM_NCLBUTTONDOWN, WM_NCLBUTTONUP, WM_NCRBUTTONDOWN, WM_NCRBUTTONUP, WM_NCMBUTTONDOWN, WM_NCMBUTTONUP, WM_NCXBUTTONDOWN, WM_NCXBUTTONUP, WM_KEYDOWN, WM_KEYUP, WM_LBUTTONDOWN, WM_LBUTTONUP, WM_RBUTTONDOWN, WM_RBUTTONUP, WM_MBUTTONDOWN, WM_MBUTTONUP, WM_XBUTTONDOWN, WM_XBUTTONUP}

    Public Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        If m.Msg = WM_MOUSEMOVE Then Return False
        If Not ModuleMain.IdleTimer.Enabled Then Return False
        If Array.BinarySearch(Messages, m.Msg) >= 0 Then ModuleMain.IdleTimer.[Stop]()
        Return False
    End Function
End Class
